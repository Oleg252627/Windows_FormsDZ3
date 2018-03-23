namespace DZ3zad3
{
    partial class Form2_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_Edit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3_Save = new System.Windows.Forms.Panel();
            this.button1_Save = new System.Windows.Forms.Button();
            this.panel3_Stop = new System.Windows.Forms.Panel();
            this.button1_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.grPanel2 = new DZ3zad3.GrPanel();
            this.textBox1_FileEdit = new System.Windows.Forms.TextBox();
            this.grPanel1 = new DZ3zad3.GrPanel();
            this.button1_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grPanel2.SuspendLayout();
            this.grPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel3_Save);
            this.panel1.Controls.Add(this.button1_Save);
            this.panel1.Controls.Add(this.panel3_Stop);
            this.panel1.Controls.Add(this.button1_Stop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 52);
            this.panel1.TabIndex = 2;
            // 
            // panel3_Save
            // 
            this.panel3_Save.BackColor = System.Drawing.Color.Teal;
            this.bunifuTransition1.SetDecoration(this.panel3_Save, BunifuAnimatorNS.DecorationType.None);
            this.panel3_Save.Location = new System.Drawing.Point(498, 41);
            this.panel3_Save.Name = "panel3_Save";
            this.panel3_Save.Size = new System.Drawing.Size(122, 10);
            this.panel3_Save.TabIndex = 1;
            // 
            // button1_Save
            // 
            this.button1_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.button1_Save, BunifuAnimatorNS.DecorationType.None);
            this.button1_Save.FlatAppearance.BorderSize = 0;
            this.button1_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Save.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Save.ForeColor = System.Drawing.Color.Black;
            this.button1_Save.Image = global::DZ3zad3.Properties.Resources._6z;
            this.button1_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_Save.Location = new System.Drawing.Point(498, 0);
            this.button1_Save.Name = "button1_Save";
            this.button1_Save.Size = new System.Drawing.Size(122, 41);
            this.button1_Save.TabIndex = 1;
            this.button1_Save.Text = "Сохранить";
            this.button1_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1_Save.UseVisualStyleBackColor = true;
            // 
            // panel3_Stop
            // 
            this.panel3_Stop.BackColor = System.Drawing.Color.Teal;
            this.bunifuTransition1.SetDecoration(this.panel3_Stop, BunifuAnimatorNS.DecorationType.None);
            this.panel3_Stop.Location = new System.Drawing.Point(370, 41);
            this.panel3_Stop.Name = "panel3_Stop";
            this.panel3_Stop.Size = new System.Drawing.Size(122, 10);
            this.panel3_Stop.TabIndex = 0;
            // 
            // button1_Stop
            // 
            this.button1_Stop.BackColor = System.Drawing.Color.Transparent;
            this.button1_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.button1_Stop, BunifuAnimatorNS.DecorationType.None);
            this.button1_Stop.FlatAppearance.BorderSize = 0;
            this.button1_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Stop.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Stop.ForeColor = System.Drawing.Color.Black;
            this.button1_Stop.Image = global::DZ3zad3.Properties.Resources._7z;
            this.button1_Stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_Stop.Location = new System.Drawing.Point(370, 0);
            this.button1_Stop.Name = "button1_Stop";
            this.button1_Stop.Size = new System.Drawing.Size(122, 41);
            this.button1_Stop.TabIndex = 0;
            this.button1_Stop.Text = "   Отмена";
            this.button1_Stop.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "C# File";
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
            // grPanel2
            // 
            this.grPanel2.ColorBotom = System.Drawing.Color.Teal;
            this.grPanel2.ColorTop = System.Drawing.Color.White;
            this.grPanel2.Controls.Add(this.textBox1_FileEdit);
            this.bunifuTransition1.SetDecoration(this.grPanel2, BunifuAnimatorNS.DecorationType.None);
            this.grPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grPanel2.Location = new System.Drawing.Point(0, 88);
            this.grPanel2.Name = "grPanel2";
            this.grPanel2.Size = new System.Drawing.Size(651, 398);
            this.grPanel2.TabIndex = 3;
            // 
            // textBox1_FileEdit
            // 
            this.textBox1_FileEdit.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.textBox1_FileEdit, BunifuAnimatorNS.DecorationType.None);
            this.textBox1_FileEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1_FileEdit.Location = new System.Drawing.Point(34, 32);
            this.textBox1_FileEdit.Multiline = true;
            this.textBox1_FileEdit.Name = "textBox1_FileEdit";
            this.textBox1_FileEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1_FileEdit.Size = new System.Drawing.Size(582, 335);
            this.textBox1_FileEdit.TabIndex = 1;
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
            this.grPanel1.Size = new System.Drawing.Size(651, 36);
            this.grPanel1.TabIndex = 1;
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
            this.button1_Close.Location = new System.Drawing.Point(612, 5);
            this.button1_Close.Name = "button1_Close";
            this.button1_Close.Size = new System.Drawing.Size(34, 27);
            this.button1_Close.TabIndex = 1;
            this.button1_Close.UseVisualStyleBackColor = false;
            this.button1_Close.Click += new System.EventHandler(this.button1_Close_Click);
            // 
            // Form2_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 486);
            this.Controls.Add(this.grPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2_Edit";
            this.Text = "Form2_Edit";
            this.Load += new System.EventHandler(this.Form2_Edit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grPanel2.ResumeLayout(false);
            this.grPanel2.PerformLayout();
            this.grPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GrPanel grPanel1;
        private System.Windows.Forms.Button button1_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3_Save;
        private System.Windows.Forms.Panel panel3_Stop;
        private System.Windows.Forms.Button button1_Save;
        private System.Windows.Forms.Button button1_Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private GrPanel grPanel2;
        private System.Windows.Forms.TextBox textBox1_FileEdit;
    }
}