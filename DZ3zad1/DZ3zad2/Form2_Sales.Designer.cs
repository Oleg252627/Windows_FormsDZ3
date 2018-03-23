namespace DZ3zad2
{
    partial class Form2_Sales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1_Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1_Exit = new System.Windows.Forms.Button();
            this.button1_ok = new System.Windows.Forms.Button();
            this.label3_AddTovar = new System.Windows.Forms.Label();
            this.textBox1_Model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_Prise = new System.Windows.Forms.TextBox();
            this.textBox2_Opisanie = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 38);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DZ3zad2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1_Close
            // 
            this.button1_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_Close.FlatAppearance.BorderSize = 0;
            this.button1_Close.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button1_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Close.Image = global::DZ3zad2.Properties.Resources._3_close;
            this.button1_Close.Location = new System.Drawing.Point(370, 3);
            this.button1_Close.Name = "button1_Close";
            this.button1_Close.Size = new System.Drawing.Size(32, 32);
            this.button1_Close.TabIndex = 1;
            this.button1_Close.UseVisualStyleBackColor = true;
            this.button1_Close.Click += new System.EventHandler(this.button1_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.button1_Exit);
            this.panel2.Controls.Add(this.button1_ok);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 65);
            this.panel2.TabIndex = 1;
            // 
            // button1_Exit
            // 
            this.button1_Exit.FlatAppearance.BorderSize = 0;
            this.button1_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Exit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Exit.ForeColor = System.Drawing.Color.White;
            this.button1_Exit.Image = global::DZ3zad2.Properties.Resources._7s;
            this.button1_Exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1_Exit.Location = new System.Drawing.Point(47, 0);
            this.button1_Exit.Name = "button1_Exit";
            this.button1_Exit.Size = new System.Drawing.Size(123, 65);
            this.button1_Exit.TabIndex = 14;
            this.button1_Exit.Text = "Отмена";
            this.button1_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1_Exit.UseVisualStyleBackColor = true;
            this.button1_Exit.Click += new System.EventHandler(this.button1_Exit_Click);
            // 
            // button1_ok
            // 
            this.button1_ok.FlatAppearance.BorderSize = 0;
            this.button1_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_ok.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_ok.ForeColor = System.Drawing.Color.White;
            this.button1_ok.Image = global::DZ3zad2.Properties.Resources._10s;
            this.button1_ok.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1_ok.Location = new System.Drawing.Point(250, 0);
            this.button1_ok.Name = "button1_ok";
            this.button1_ok.Size = new System.Drawing.Size(123, 65);
            this.button1_ok.TabIndex = 13;
            this.button1_ok.Text = "Готово";
            this.button1_ok.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1_ok.UseVisualStyleBackColor = true;
            // 
            // label3_AddTovar
            // 
            this.label3_AddTovar.AutoSize = true;
            this.label3_AddTovar.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3_AddTovar.ForeColor = System.Drawing.Color.Crimson;
            this.label3_AddTovar.Location = new System.Drawing.Point(44, 44);
            this.label3_AddTovar.Name = "label3_AddTovar";
            this.label3_AddTovar.Size = new System.Drawing.Size(203, 18);
            this.label3_AddTovar.TabIndex = 7;
            this.label3_AddTovar.Text = "Введите модель компьютера:";
            // 
            // textBox1_Model
            // 
            this.textBox1_Model.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1_Model.Location = new System.Drawing.Point(47, 65);
            this.textBox1_Model.Name = "textBox1_Model";
            this.textBox1_Model.Size = new System.Drawing.Size(326, 22);
            this.textBox1_Model.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(44, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите описание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(44, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите цену компьютера:";
            // 
            // textBox1_Prise
            // 
            this.textBox1_Prise.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1_Prise.Location = new System.Drawing.Point(47, 231);
            this.textBox1_Prise.Name = "textBox1_Prise";
            this.textBox1_Prise.Size = new System.Drawing.Size(326, 22);
            this.textBox1_Prise.TabIndex = 12;
            // 
            // textBox2_Opisanie
            // 
            this.textBox2_Opisanie.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2_Opisanie.Location = new System.Drawing.Point(186, 93);
            this.textBox2_Opisanie.Multiline = true;
            this.textBox2_Opisanie.Name = "textBox2_Opisanie";
            this.textBox2_Opisanie.Size = new System.Drawing.Size(187, 114);
            this.textBox2_Opisanie.TabIndex = 13;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form2_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 326);
            this.Controls.Add(this.textBox2_Opisanie);
            this.Controls.Add(this.textBox1_Prise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_Model);
            this.Controls.Add(this.label3_AddTovar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2_Sales";
            this.Text = "Form2_Sales";
            this.Load += new System.EventHandler(this.Form2_Sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1_ok;
        private System.Windows.Forms.Label label3_AddTovar;
        private System.Windows.Forms.TextBox textBox1_Model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_Prise;
        private System.Windows.Forms.Button button1_Exit;
        private System.Windows.Forms.TextBox textBox2_Opisanie;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}