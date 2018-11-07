namespace DynamicUserControlLoading
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.module1Button = new System.Windows.Forms.Button();
            this.module2Button = new System.Windows.Forms.Button();
            this.module3Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.module3Button);
            this.panel1.Controls.Add(this.module2Button);
            this.panel1.Controls.Add(this.module1Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(121, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 52);
            this.panel2.TabIndex = 1;
            // 
            // panMain
            // 
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(121, 52);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(679, 398);
            this.panMain.TabIndex = 2;
            // 
            // module1Button
            // 
            this.module1Button.Location = new System.Drawing.Point(21, 82);
            this.module1Button.Name = "module1Button";
            this.module1Button.Size = new System.Drawing.Size(75, 23);
            this.module1Button.TabIndex = 0;
            this.module1Button.Text = "Module1";
            this.module1Button.UseVisualStyleBackColor = true;
            this.module1Button.Click += new System.EventHandler(this.module1Button_Click);
            // 
            // module2Button
            // 
            this.module2Button.Location = new System.Drawing.Point(21, 132);
            this.module2Button.Name = "module2Button";
            this.module2Button.Size = new System.Drawing.Size(75, 23);
            this.module2Button.TabIndex = 1;
            this.module2Button.Text = "Module 2";
            this.module2Button.UseVisualStyleBackColor = true;
            this.module2Button.Click += new System.EventHandler(this.module2Button_Click);
            // 
            // module3Button
            // 
            this.module3Button.Location = new System.Drawing.Point(21, 184);
            this.module3Button.Name = "module3Button";
            this.module3Button.Size = new System.Drawing.Size(75, 23);
            this.module3Button.TabIndex = 2;
            this.module3Button.Text = "Module 3";
            this.module3Button.UseVisualStyleBackColor = true;
            this.module3Button.Click += new System.EventHandler(this.module3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Button module3Button;
        private System.Windows.Forms.Button module2Button;
        private System.Windows.Forms.Button module1Button;
    }
}

