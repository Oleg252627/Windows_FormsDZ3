using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ3zad1
{
    public partial class Form1 : Form
    {
        private Point lastCursor;
        private Point lastForm;
        private bool isDragging;
        private int i;
        public Form1()
        {
            InitializeComponent();
            this.panel1.MouseMove += Panel1_MouseMove;
            this.panel1.MouseDown += Panel1_MouseDown;
            this.panel1.MouseUp += Panel1_MouseUp;
            i = 0;
            isDragging = false;
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

        private void button1_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            Form2_Poisk A = new Form2_Poisk(this,i);
            this.bunifuTransition1.ShowSync(A); //для красивого появления формы!!
            //A.ShowDialog();
        }
    }
}
