namespace HelloWinFormsApp
{
    partial class appTitle
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
            this.labelFName = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelMsg1 = new System.Windows.Forms.Label();
            this.labelMsg2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(45, 23);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(26, 13);
            this.labelFName.TabIndex = 0;
            this.labelFName.Text = "Imie";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(104, 20);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(152, 20);
            this.textBoxFName.TabIndex = 1;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(104, 50);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(152, 20);
            this.textBoxLName.TabIndex = 2;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(45, 53);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(53, 13);
            this.labelLName.TabIndex = 3;
            this.labelLName.Text = "Nazwisko";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(45, 84);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Wiek";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(104, 81);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(152, 20);
            this.textBoxAge.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(104, 118);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelMsg1
            // 
            this.labelMsg1.AutoSize = true;
            this.labelMsg1.Location = new System.Drawing.Point(45, 162);
            this.labelMsg1.Name = "labelMsg1";
            this.labelMsg1.Size = new System.Drawing.Size(0, 13);
            this.labelMsg1.TabIndex = 7;
            // 
            // labelMsg2
            // 
            this.labelMsg2.AutoSize = true;
            this.labelMsg2.Location = new System.Drawing.Point(45, 197);
            this.labelMsg2.Name = "labelMsg2";
            this.labelMsg2.Size = new System.Drawing.Size(0, 13);
            this.labelMsg2.TabIndex = 8;
            // 
            // appTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 239);
            this.Controls.Add(this.labelMsg2);
            this.Controls.Add(this.labelMsg1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.labelFName);
            this.Name = "appTitle";
            this.Text = "Aplikacja Witaj!";
            this.Load += new System.EventHandler(this.Aplikacja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelMsg1;
        private System.Windows.Forms.Label labelMsg2;
    }
}

