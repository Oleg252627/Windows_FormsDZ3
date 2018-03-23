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

namespace DZ3zad1
{
    public partial class Form2_Poisk : Form
    {
        private Point lastCursor;
        private Point lastForm;
        private bool isDragging = false;
        private string maska;
        public Form2_Poisk(Form1 b,int nambe)
        {
            InitializeComponent();
            this.label1_Search.Text = $"C# Search {nambe}";
            this.panel1.MouseMove += Panel1_MouseMove;
            this.panel1.MouseDown += Panel1_MouseDown;
            this.panel1.MouseUp += Panel1_MouseUp;
            this.textBox1_Masca.TextChanged+=new System.EventHandler(textBox1_Masca_TextChanged);
            this.button2_Poisk.Click += Button2_Poisk_Click;
        }

        private void Button2_Poisk_Click(object sender, EventArgs e)
        {
            if (maska == null)
            {
                MessageBox.Show("Вы не ввели маску", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox1_Masca.Text = null;
                return;
            }

            if (maska.Length > 2)
            {
                if ( maska[0] != '*')
                {
                    MessageBox.Show("Вы не ввели *", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.textBox1_Masca.Text = null;
                    return;
                }

                if ( maska[1] != '.')
                {
                    MessageBox.Show("Вы не ввели .", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.textBox1_Masca.Text = null;
                    return;
                }
                FolderBrowserDialog folderbrowserdialog=new FolderBrowserDialog();
                if (folderbrowserdialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] allFile =
                            Directory.GetFiles(folderbrowserdialog.SelectedPath, maska, SearchOption.AllDirectories);
                        if (allFile.Length == 0)
                        {
                            MessageBox.Show("Файлов не найдено!", "Оповещение", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            foreach (var VARIABLE in allFile)
                            {
                                this.listBox1.Items.Add(VARIABLE);
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Не выбрали папку!", "Оповещение", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели маску", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox1_Masca.Text = null;
                return;
            }
        }

        private void textBox1_Masca_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBox1_Masca.Text))
            {
                maska = this.textBox1_Masca.Text;
            }
            else
            {
                textBox1_Masca.Text = null;
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
            this.Close();
        }
    }
}
