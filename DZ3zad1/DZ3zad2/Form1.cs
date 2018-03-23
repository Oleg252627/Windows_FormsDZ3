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
    public partial class Form1 : Form
    {
        private List<Tovar> listTovar;
        private Point lastCursor;
        private Point lastForm;
        private bool isDragging;
        private int iSlaider;
        private Double Summ;

        public Form1()
        {
            InitializeComponent();
            listTovar=new List<Tovar>();
            iSlaider = 2;
            Summ = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            isDragging = false;
            this.panel1.MouseMove += Panel1_MouseMove;
            this.panel1.MouseDown += Panel1_MouseDown;
            this.panel1.MouseUp += Panel1_MouseUp;
            this.timer1.Start();
            this.button2_add_tovar.MouseHover += new EventHandler(button_MouseHover);
            this.button2_Nalichie.MouseHover += new EventHandler(button_MouseHover);
            this.button3_Redaktirovat.MouseHover += new EventHandler(button_MouseHover);
            this.button2_add_tovar.MouseLeave += new EventHandler(button_MouseLeave);
            this.button2_Nalichie.MouseLeave += new EventHandler(button_MouseLeave);
            this.button3_Redaktirovat.MouseLeave += new EventHandler(button_MouseLeave);
            this.comboBox1_Nalichie.SelectedIndexChanged+=new EventHandler(comboBox1_SelectedIndexChanged);
            this.button2_add_tovar.Click += Button2_add_tovar_Click;
            this.button3_Redaktirovat.Click += Button3_Redaktirovat_Click;
        }

        private void Button3_Redaktirovat_Click(object sender, EventArgs e)
        {
            if (this.comboBox1_Nalichie.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран товар!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form2_Sales A=new Form2_Sales(this.listTovar[this.comboBox1_Nalichie.SelectedIndex],false);
            int index = this.comboBox1_Nalichie.SelectedIndex;
            if (A.ShowDialog() == DialogResult.OK)
            {
                this.comboBox1_Nalichie.Items.RemoveAt(index);
                this.comboBox1_Nalichie.Items.Insert(index, this.listTovar[index].Name);
                this.comboBox1_Nalichie.SelectedIndex = index;
            }
        }

        private void Button2_add_tovar_Click(object sender, EventArgs e)
        {
            if (this.comboBox1_Nalichie.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран товар!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.listBox1_Prodagi.Items.Add(this.listTovar[this.comboBox1_Nalichie.SelectedIndex].ToString());
            this.Summ += this.listTovar[this.comboBox1_Nalichie.SelectedIndex].Prise;
            this.label4_Summa.Text = this.Summ.ToString()+" грн.";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1_Prise.Text = this.listTovar[this.comboBox1_Nalichie.SelectedIndex].Prise.ToString();
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = sender as Button;
                if (button.Name == this.button2_add_tovar.Name)
                {
                    Bitmap My_image = new Bitmap(String.Format(@"..\..\image\{0}s.png", 4));
                    button.Image = My_image;
                }
                else if (button.Name == this.button2_Nalichie.Name)
                {
                    Bitmap My_image = new Bitmap(String.Format(@"..\..\image\{0}s.png", 6));
                    button.Image = My_image;
                }
                else if (button.Name == this.button3_Redaktirovat.Name)
                {
                    Bitmap My_image = new Bitmap(String.Format(@"..\..\image\{0}s.png", 2));
                    button.Image = My_image;
                }
            }
        }
        private void button_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = sender as Button;
                if (button.Name == this.button2_add_tovar.Name)
                {
                    Bitmap My_image = new Bitmap(String.Format(@"..\..\image\{0}s.png", 3));
                    button.Image = My_image;
                }
                else if (button.Name == this.button2_Nalichie.Name)
                {
                    Bitmap My_image = new Bitmap(String.Format(@"..\..\image\{0}s.png", 5));
                    button.Image = My_image;
                }
                else if (button.Name == this.button3_Redaktirovat.Name)
                {
                    Bitmap My_image = new Bitmap(String.Format(@"..\..\image\{0}s.png", 1));
                    button.Image = My_image;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close_Slaider();
            Show_Slaider();
            
        }

        private void Close_Slaider()
        {
            this.bunifuTransition2.HideSync(this.pictureBox2_Slaider);
            if (iSlaider == 6)
            {
                iSlaider = 0;
            }
            iSlaider++;
        }
        private void Show_Slaider()
        {
            Bitmap My_image = new Bitmap(String.Format(@"..\..\image\{0}.jpg", iSlaider));
            this.pictureBox2_Slaider.Image = My_image;
            this.bunifuTransition1.Show(this.pictureBox2_Slaider);
        }

        private void button2_Nalichie_Click(object sender, EventArgs e)
        {
            
            Tovar tovar=new Tovar();
            Form2_Sales A = new Form2_Sales(tovar,true);
            if (A.ShowDialog()==DialogResult.OK)
            {
                listTovar.Add(tovar);
                this.comboBox1_Nalichie.Items.Add(tovar.Name);
            }
        }

       
    }
}
