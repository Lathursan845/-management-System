namespace Management.Views
{
    partial class AddStudent
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
            this.sName = new System.Windows.Forms.Label();
            this.sUT = new System.Windows.Forms.Label();
            this.sNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sEmail = new System.Windows.Forms.Label();
            this.sPassword = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sName
            // 
            this.sName.AutoSize = true;
            this.sName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sName.Location = new System.Drawing.Point(103, 110);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(64, 18);
            this.sName.TabIndex = 2;
            this.sName.Text = "Name   :";
            // 
            // sUT
            // 
            this.sUT.AutoSize = true;
            this.sUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sUT.Location = new System.Drawing.Point(103, 169);
            this.sUT.Name = "sUT";
            this.sUT.Size = new System.Drawing.Size(101, 18);
            this.sUT.TabIndex = 3;
            this.sUT.Text = "UT Number   :";
            // 
            // sNum
            // 
            this.sNum.AutoSize = true;
            this.sNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNum.Location = new System.Drawing.Point(103, 227);
            this.sNum.Name = "sNum";
            this.sNum.Size = new System.Drawing.Size(124, 18);
            this.sNum.TabIndex = 4;
            this.sNum.Text = "Phone Number   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Student";
            // 
            // sEmail
            // 
            this.sEmail.AutoSize = true;
            this.sEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sEmail.Location = new System.Drawing.Point(103, 278);
            this.sEmail.Name = "sEmail";
            this.sEmail.Size = new System.Drawing.Size(66, 18);
            this.sEmail.TabIndex = 6;
            this.sEmail.Text = "E-Mail   :";
            // 
            // sPassword
            // 
            this.sPassword.AutoSize = true;
            this.sPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPassword.Location = new System.Drawing.Point(103, 337);
            this.sPassword.Name = "sPassword";
            this.sPassword.Size = new System.Drawing.Size(91, 18);
            this.sPassword.TabIndex = 7;
            this.sPassword.Text = "Password   :";
            this.sPassword.Click += new System.EventHandler(this.label5_Click);
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(244, 96);
            this.lName.Multiline = true;
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(328, 32);
            this.lName.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 155);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 32);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 213);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 32);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(244, 264);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(328, 32);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(244, 323);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(328, 32);
            this.textBox4.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(458, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.sPassword);
            this.Controls.Add(this.sEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sNum);
            this.Controls.Add(this.sUT);
            this.Controls.Add(this.sName);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sName;
        private System.Windows.Forms.Label sUT;
        private System.Windows.Forms.Label sNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sEmail;
        private System.Windows.Forms.Label sPassword;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
    }
}