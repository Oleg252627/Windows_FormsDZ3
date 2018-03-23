namespace DZ3zad2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3_Redaktirovat = new System.Windows.Forms.Button();
            this.button2_Nalichie = new System.Windows.Forms.Button();
            this.button2_add_tovar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1_Nalichie = new System.Windows.Forms.ComboBox();
            this.listBox1_Prodagi = new System.Windows.Forms.ListBox();
            this.label3_AddTovar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4_Summa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_Prise = new System.Windows.Forms.TextBox();
            this.pictureBox2_Slaider = new System.Windows.Forms.PictureBox();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_Slaider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sale of computers";
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::DZ3zad2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::DZ3zad2.Properties.Resources._3_close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(848, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.button3_Redaktirovat);
            this.panel2.Controls.Add(this.button2_Nalichie);
            this.panel2.Controls.Add(this.button2_add_tovar);
            this.bunifuTransition2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 563);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 90);
            this.panel2.TabIndex = 2;
            // 
            // button3_Redaktirovat
            // 
            this.bunifuTransition1.SetDecoration(this.button3_Redaktirovat, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button3_Redaktirovat, BunifuAnimatorNS.DecorationType.None);
            this.button3_Redaktirovat.FlatAppearance.BorderSize = 0;
            this.button3_Redaktirovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_Redaktirovat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3_Redaktirovat.ForeColor = System.Drawing.Color.White;
            this.button3_Redaktirovat.Image = global::DZ3zad2.Properties.Resources._2s;
            this.button3_Redaktirovat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3_Redaktirovat.Location = new System.Drawing.Point(554, 0);
            this.button3_Redaktirovat.Name = "button3_Redaktirovat";
            this.button3_Redaktirovat.Size = new System.Drawing.Size(217, 90);
            this.button3_Redaktirovat.TabIndex = 6;
            this.button3_Redaktirovat.Text = "Редактировать \r\nтовар";
            this.button3_Redaktirovat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3_Redaktirovat.UseVisualStyleBackColor = true;
            // 
            // button2_Nalichie
            // 
            this.bunifuTransition1.SetDecoration(this.button2_Nalichie, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button2_Nalichie, BunifuAnimatorNS.DecorationType.None);
            this.button2_Nalichie.FlatAppearance.BorderSize = 0;
            this.button2_Nalichie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_Nalichie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2_Nalichie.ForeColor = System.Drawing.Color.White;
            this.button2_Nalichie.Image = global::DZ3zad2.Properties.Resources._6s;
            this.button2_Nalichie.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2_Nalichie.Location = new System.Drawing.Point(331, 0);
            this.button2_Nalichie.Name = "button2_Nalichie";
            this.button2_Nalichie.Size = new System.Drawing.Size(217, 90);
            this.button2_Nalichie.TabIndex = 4;
            this.button2_Nalichie.Text = "Добавить товар \r\nв наличие";
            this.button2_Nalichie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2_Nalichie.UseVisualStyleBackColor = true;
            this.button2_Nalichie.Click += new System.EventHandler(this.button2_Nalichie_Click);
            // 
            // button2_add_tovar
            // 
            this.bunifuTransition1.SetDecoration(this.button2_add_tovar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button2_add_tovar, BunifuAnimatorNS.DecorationType.None);
            this.button2_add_tovar.FlatAppearance.BorderSize = 0;
            this.button2_add_tovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_add_tovar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2_add_tovar.ForeColor = System.Drawing.Color.White;
            this.button2_add_tovar.Image = global::DZ3zad2.Properties.Resources._4s;
            this.button2_add_tovar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2_add_tovar.Location = new System.Drawing.Point(108, 0);
            this.button2_add_tovar.Name = "button2_add_tovar";
            this.button2_add_tovar.Size = new System.Drawing.Size(217, 90);
            this.button2_add_tovar.TabIndex = 3;
            this.button2_add_tovar.Text = "Добавить в список\r\n продаж";
            this.button2_add_tovar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2_add_tovar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(452, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наличие товара:";
            // 
            // comboBox1_Nalichie
            // 
            this.bunifuTransition2.SetDecoration(this.comboBox1_Nalichie, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.comboBox1_Nalichie, BunifuAnimatorNS.DecorationType.None);
            this.comboBox1_Nalichie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_Nalichie.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1_Nalichie.FormattingEnabled = true;
            this.comboBox1_Nalichie.Location = new System.Drawing.Point(458, 336);
            this.comboBox1_Nalichie.Name = "comboBox1_Nalichie";
            this.comboBox1_Nalichie.Size = new System.Drawing.Size(240, 25);
            this.comboBox1_Nalichie.TabIndex = 4;
            // 
            // listBox1_Prodagi
            // 
            this.bunifuTransition2.SetDecoration(this.listBox1_Prodagi, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.listBox1_Prodagi, BunifuAnimatorNS.DecorationType.None);
            this.listBox1_Prodagi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1_Prodagi.FormattingEnabled = true;
            this.listBox1_Prodagi.HorizontalScrollbar = true;
            this.listBox1_Prodagi.ItemHeight = 17;
            this.listBox1_Prodagi.Location = new System.Drawing.Point(49, 336);
            this.listBox1_Prodagi.Name = "listBox1_Prodagi";
            this.listBox1_Prodagi.Size = new System.Drawing.Size(374, 208);
            this.listBox1_Prodagi.TabIndex = 5;
            // 
            // label3_AddTovar
            // 
            this.label3_AddTovar.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3_AddTovar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label3_AddTovar, BunifuAnimatorNS.DecorationType.None);
            this.label3_AddTovar.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3_AddTovar.ForeColor = System.Drawing.Color.Crimson;
            this.label3_AddTovar.Location = new System.Drawing.Point(47, 309);
            this.label3_AddTovar.Name = "label3_AddTovar";
            this.label3_AddTovar.Size = new System.Drawing.Size(183, 24);
            this.label3_AddTovar.TabIndex = 6;
            this.label3_AddTovar.Text = "Проданные товары:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(427, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Общая сумма проданных товаров:";
            // 
            // label4_Summa
            // 
            this.label4_Summa.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4_Summa, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label4_Summa, BunifuAnimatorNS.DecorationType.None);
            this.label4_Summa.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4_Summa.ForeColor = System.Drawing.Color.Crimson;
            this.label4_Summa.Location = new System.Drawing.Point(742, 511);
            this.label4_Summa.Name = "label4_Summa";
            this.label4_Summa.Size = new System.Drawing.Size(20, 24);
            this.label4_Summa.TabIndex = 8;
            this.label4_Summa.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(722, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Цена:";
            // 
            // textBox1_Prise
            // 
            this.bunifuTransition1.SetDecoration(this.textBox1_Prise, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.textBox1_Prise, BunifuAnimatorNS.DecorationType.None);
            this.textBox1_Prise.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1_Prise.Location = new System.Drawing.Point(726, 336);
            this.textBox1_Prise.Name = "textBox1_Prise";
            this.textBox1_Prise.ReadOnly = true;
            this.textBox1_Prise.Size = new System.Drawing.Size(100, 24);
            this.textBox1_Prise.TabIndex = 10;
            this.textBox1_Prise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2_Slaider
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2_Slaider, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox2_Slaider, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2_Slaider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2_Slaider.Image = global::DZ3zad2.Properties.Resources._1;
            this.pictureBox2_Slaider.Location = new System.Drawing.Point(0, 40);
            this.pictureBox2_Slaider.Name = "pictureBox2_Slaider";
            this.pictureBox2_Slaider.Size = new System.Drawing.Size(892, 247);
            this.pictureBox2_Slaider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2_Slaider.TabIndex = 1;
            this.pictureBox2_Slaider.TabStop = false;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(836, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "грн.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 653);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1_Prise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label4_Summa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label3_AddTovar);
            this.Controls.Add(this.listBox1_Prodagi);
            this.Controls.Add(this.comboBox1_Nalichie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2_Slaider);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_Slaider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2_Slaider;
        private System.Windows.Forms.Timer timer1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2_add_tovar;
        private System.Windows.Forms.Button button2_Nalichie;
        private System.Windows.Forms.Button button3_Redaktirovat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1_Nalichie;
        private System.Windows.Forms.ListBox listBox1_Prodagi;
        private System.Windows.Forms.Label label3_AddTovar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4_Summa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_Prise;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label5;
    }
}

