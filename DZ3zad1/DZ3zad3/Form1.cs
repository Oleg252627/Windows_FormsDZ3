using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ3zad3
{
    public partial class Form1 : Form
    {
        private Point lastCursor;
        private Point lastForm;
        private bool isDragging;
        public Form1()
        {
            InitializeComponent();
            isDragging = false;
            this.grPanel1.MouseMove += GrPanel1_MouseMove;
            this.grPanel1.MouseDown += GrPanel1_MouseDown;
            this.grPanel1.MouseUp += GrPanel1_MouseUp;
            
            this.button1_Load.MouseHover += new EventHandler(button_MouseHover);
            this.button1_Edit.MouseHover += new EventHandler(button_MouseHover);
            this.button1_Load.MouseLeave += new EventHandler(button_MouseLeave);
            this.button1_Edit.MouseLeave += new EventHandler(button_MouseLeave);
            this.button1_Load.Click += Button1_Load_Click;
            this.button1_Edit.Click += Button1_Edit_Click;
        }

        private void button1_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.bunifuTransition1.HideSync(this.panel3_Load);
            this.bunifuTransition1.HideSync(this.panel3_Edit);
        }

        private void Button1_Edit_Click(object sender, EventArgs e)
        {
            Form2_Edit A=new Form2_Edit(this);
            A.Show();

        }

        private void Button1_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files(*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox1_File.Text = File.ReadAllText(openFileDialog.FileName);
                this.button1_Edit.Enabled = true;
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button=sender as Button;
            if (button.Name == this.button1_Load.Name)
            {
                this.bunifuTransition1.HideSync(this.panel3_Load);
            }
            else if (button.Name == this.button1_Edit.Name)
            {
                this.bunifuTransition1.HideSync(this.panel3_Edit);
            }
        }
        private void button_MouseHover(object sender, EventArgs e)
        {
            Button button=sender as Button;
            if (button.Name == this.button1_Load.Name)
            {
                this.bunifuTransition1.ShowSync(this.panel3_Load);
            }
            else if (button.Name == this.button1_Edit.Name)
            {
                this.bunifuTransition1.ShowSync(this.panel3_Edit);
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

        public TextBox Get_textBox()
        {
            return this.textBox1_File;
        }

        public void Set_textBox(TextBox text)
        {
            this.textBox1_File.Text = text.Text;
        }

    }
}
