using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ3zad2
{
    public partial class Form2_Sales : Form
    {
        private Point lastCursor;
        private Point lastForm;
        private bool isDragging;
        private Tovar tovar;
        private bool newTovar;
        public Form2_Sales(Tovar tovar,bool flag)
        {

            InitializeComponent();
            this.tovar = tovar;
            this.newTovar = flag;
            if (!flag)
            {
                this.button1_ok.Text = "Заменить";
                this.textBox1_Model.Text = this.tovar.Name;
                this.textBox2_Opisanie.Text = this.tovar.Opisanie;
                this.textBox1_Prise.Text = this.tovar.Prise.ToString();
            }
            else
            {
                this.textBox1_Model.Text = null;
                this.textBox2_Opisanie.Text = null;
                this.textBox1_Prise.Text = null;
            }
            
        }
        private void Form2_Sales_Load(object sender, EventArgs e)
        {
            isDragging = false;
            this.panel1.MouseMove += Panel1_MouseMove;
            this.panel1.MouseDown += Panel1_MouseDown;
            this.panel1.MouseUp += Panel1_MouseUp;
            this.button1_ok.MouseHover += new EventHandler(button_MouseHover);
            this.button1_Exit.MouseHover += new EventHandler(button_MouseHover);
            this.button1_ok.MouseLeave += new EventHandler(button_MouseLeave);
            this.button1_Exit.MouseLeave += new EventHandler(button_MouseLeave);
            this.button1_ok.Click += Button1_ok_Click;
        }

        private void Button1_ok_Click(object sender, EventArgs e)
        {
            if (this.textBox1_Model.Text == "" || this.textBox2_Opisanie.Text == "" || this.textBox1_Prise.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.tovar.Name = this.textBox1_Model.Text;
                this.tovar.Opisanie = this.textBox2_Opisanie.Text;
                this.tovar.Prise = Convert.ToDouble(this.textBox1_Prise.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Введите коректную цену!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult= DialogResult.OK;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = sender as Button;
                if (button.Name == this.button1_ok.Name)
                {
                    Bitmap My_imeges = new Bitmap(String.Format(@"..\..\image\{0}s.png", 10));
                    this.button1_ok.Image = My_imeges;
                }
                else if (button.Name == this.button1_Exit.Name)
                {
                    Bitmap My_imeges = new Bitmap(String.Format(@"..\..\image\{0}s.png", 7));
                    this.button1_Exit.Image = My_imeges;
                }
            }
        }
        private void button_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = sender as Button;
                if (button.Name == this.button1_ok.Name)
                {
                    Bitmap My_imeges=new Bitmap(String.Format(@"..\..\image\{0}s.png", 9));
                    this.button1_ok.Image = My_imeges;
                }
                else if (button.Name == this.button1_Exit.Name)
                {
                    Bitmap My_imeges = new Bitmap(String.Format(@"..\..\image\{0}s.png", 8));
                    this.button1_Exit.Image = My_imeges;
                }
            }
        }
        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location =
                    Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }
        private void button1_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
