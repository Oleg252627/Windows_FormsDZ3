namespace DZ3zad3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3_Edit = new System.Windows.Forms.Panel();
            this.panel3_Load = new System.Windows.Forms.Panel();
            this.button1_Edit = new System.Windows.Forms.Button();
            this.button1_Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.grPanel3 = new DZ3zad3.GrPanel();
            this.textBox1_File = new System.Windows.Forms.TextBox();
            this.grPanel1 = new DZ3zad3.GrPanel();
            this.button1_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grPanel3.SuspendLayout();
            this.grPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel3_Edit);
            this.panel1.Controls.Add(this.panel3_Load);
            this.panel1.Controls.Add(this.button1_Edit);
            this.panel1.Controls.Add(this.button1_Load);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 52);
            this.panel1.TabIndex = 1;
            // 
            // panel3_Edit
            // 
            this.panel3_Edit.BackColor = System.Drawing.Color.Teal;
            this.bunifuTransition1.SetDecoration(this.panel3_Edit, BunifuAnimatorNS.DecorationType.None);
            this.panel3_Edit.Location = new System.Drawing.Point(513, 41);
            this.panel3_Edit.Name = "panel3_Edit";
            this.panel3_Edit.Size = new System.Drawing.Size(107, 10);
            this.panel3_Edit.TabIndex = 1;
            // 
            // panel3_Load
            // 
            this.panel3_Load.BackColor = System.Drawing.Color.Teal;
            this.bunifuTransition1.SetDecoration(this.panel3_Load, BunifuAnimatorNS.DecorationType.None);
            this.panel3_Load.Location = new System.Drawing.Point(399, 41);
            this.panel3_Load.Name = "panel3_Load";
            this.panel3_Load.Size = new System.Drawing.Size(107, 10);
            this.panel3_Load.TabIndex = 0;
            // 
            // button1_Edit
            // 
            this.button1_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.button1_Edit, BunifuAnimatorNS.DecorationType.None);
            this.button1_Edit.Enabled = false;
            this.button1_Edit.FlatAppearance.BorderSize = 0;
            this.button1_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Edit.ForeColor = System.Drawing.Color.Black;
            this.button1_Edit.Image = global::DZ3zad3.Properties.Resources._5z;
            this.button1_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_Edit.Location = new System.Drawing.Point(513, 0);
            this.button1_Edit.Name = "button1_Edit";
            this.button1_Edit.Size = new System.Drawing.Size(107, 41);
            this.button1_Edit.TabIndex = 1;
            this.button1_Edit.Text = "Изменить";
            this.button1_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1_Edit.UseVisualStyleBackColor = true;
            // 
            // button1_Load
            // 
            this.button1_Load.BackColor = System.Drawing.Color.Transparent;
            this.button1_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.button1_Load, BunifuAnimatorNS.DecorationType.None);
            this.button1_Load.FlatAppearance.BorderSize = 0;
            this.button1_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Load.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Load.ForeColor = System.Drawing.Color.Black;
            this.button1_Load.Image = global::DZ3zad3.Properties.Resources._44z;
            this.button1_Load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_Load.Location = new System.Drawing.Point(399, 0);
            this.button1_Load.Name = "button1_Load";
            this.button1_Load.Size = new System.Drawing.Size(107, 41);
            this.button1_Load.TabIndex = 0;
            this.button1_Load.Text = "Загрузить";
            this.button1_Load.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1_Load.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "C# Edit file";
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::DZ3zad3.Properties.Resources._1z;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
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
            this.bunifuTransition1.MaxAnimationTime = 500;
            this.bunifuTransition1.TimeStep = 0.04F;
            // 
            // grPanel3
            // 
            this.grPanel3.ColorBotom = System.Drawing.Color.Teal;
            this.grPanel3.ColorTop = System.Drawing.Color.White;
            this.grPanel3.Controls.Add(this.textBox1_File);
            this.bunifuTransition1.SetDecoration(this.grPanel3, BunifuAnimatorNS.DecorationType.None);
            this.grPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grPanel3.Location = new System.Drawing.Point(0, 88);
            this.grPanel3.Name = "grPanel3";
            this.grPanel3.Size = new System.Drawing.Size(667, 437);
            this.grPanel3.TabIndex = 3;
            // 
            // textBox1_File
            // 
            this.textBox1_File.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.textBox1_File, BunifuAnimatorNS.DecorationType.None);
            this.textBox1_File.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1_File.Location = new System.Drawing.Point(42, 37);
            this.textBox1_File.Multiline = true;
            this.textBox1_File.Name = "textBox1_File";
            this.textBox1_File.ReadOnly = true;
            this.textBox1_File.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1_File.Size = new System.Drawing.Size(582, 365);
            this.textBox1_File.TabIndex = 1;
            // 
            // grPanel1
            // 
            this.grPanel1.ColorBotom = System.Drawing.Color.Teal;
            this.grPanel1.ColorTop = System.Drawing.Color.White;
            this.grPanel1.Controls.Add(this.button1_Close);
            this.bunifuTransition1.SetDecoration(this.grPanel1, BunifuAnimatorNS.DecorationType.None);
            this.grPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grPanel1.Location = new System.Drawing.Point(0, 0);
            this.grPanel1.Name = "grPanel1";
            this.grPanel1.Size = new System.Drawing.Size(667, 36);
            this.grPanel1.TabIndex = 0;
            // 
            // button1_Close
            // 
            this.button1_Close.BackColor = System.Drawing.Color.Transparent;
            this.button1_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.button1_Close, BunifuAnimatorNS.DecorationType.None);
            this.button1_Close.FlatAppearance.BorderSize = 0;
            this.button1_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Close.Image = global::DZ3zad3.Properties.Resources._4_close;
            this.button1_Close.Location = new System.Drawing.Point(622, 5);
            this.button1_Close.Name = "button1_Close";
            this.button1_Close.Size = new System.Drawing.Size(34, 27);
            this.button1_Close.TabIndex = 1;
            this.button1_Close.UseVisualStyleBackColor = false;
            this.button1_Close.Click += new System.EventHandler(this.button1_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 525);
            this.Controls.Add(this.grPanel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grPanel3.ResumeLayout(false);
            this.grPanel3.PerformLayout();
            this.grPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GrPanel grPanel1;
        private System.Windows.Forms.Button button1_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_Load;
        private System.Windows.Forms.Button button1_Edit;
        private System.Windows.Forms.Panel panel3_Edit;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel panel3_Load;
        private GrPanel grPanel3;
        private System.Windows.Forms.TextBox textBox1_File;
    }
}

