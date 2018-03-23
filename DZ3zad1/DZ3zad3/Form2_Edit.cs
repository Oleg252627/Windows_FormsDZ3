using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ3zad3
{
    public partial class Form2_Edit : Form
    {
        private Point lastCursor;
        private Point lastForm;
        private bool isDragging;
        private Form1 form1;
        public Form2_Edit(Form1 form)
        {
            InitializeComponent();
            isDragging = false;
            this.form1 = form;
            this.textBox1_FileEdit.Text = this.form1.Get_textBox().Text;
            this.grPanel1.MouseMove += GrPanel1_MouseMove;
            this.grPanel1.MouseDown += GrPanel1_MouseDown;
            this.grPanel1.MouseUp += GrPanel1_MouseUp;
            this.button1_Stop.MouseHover += new EventHandler(button_MouseHover);
            this.button1_Save.MouseHover += new EventHandler(button_MouseHover);
            this.button1_Stop.MouseLeave += new EventHandler(button_MouseLeave);
            this.button1_Save.MouseLeave += new EventHandler(button_MouseLeave);
            this.button1_Save.Click += Button1_Save_Click;
            this.button1_Stop.Click += Button1_Stop_Click;
        }

        private void button1_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Edit_Load(object sender, EventArgs e)
        {
            this.bunifuTransition1.HideSync(this.panel3_Stop);
            this.bunifuTransition1.HideSync(this.panel3_Save);
        }

        private void Button1_Stop_Click(object sender, EventArgs e)
        {
            this.textBox1_FileEdit.Text = this.form1.Get_textBox().Text;
        }

        private void Button1_Save_Click(object sender, EventArgs e)
        {
            this.form1.Set_textBox(this.textBox1_FileEdit);
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Name == this.button1_Stop.Name)
            {
                this.bunifuTransition1.HideSync(this.panel3_Stop);
            }
            else if (button.Name == this.button1_Save.Name)
            {
                this.bunifuTransition1.HideSync(this.panel3_Save);
            }
        }
        private void button_MouseHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Name == this.button1_Stop.Name)
            {
                this.bunifuTransition1.ShowSync(this.panel3_Stop);
            }
            else if (button.Name == this.button1_Save.Name)
            {
                this.bunifuTransition1.ShowSync(this.panel3_Save);
            }
        }
        private void GrPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void GrPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void GrPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location =
                    Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }
    }
}
