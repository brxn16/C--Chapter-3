namespace TestsIneractiveGUI
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
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.txtTest3 = new System.Windows.Forms.TextBox();
            this.txtTest4 = new System.Windows.Forms.TextBox();
            this.txtTest5 = new System.Windows.Forms.TextBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblTest1 = new System.Windows.Forms.Label();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.lblTest5 = new System.Windows.Forms.Label();
            this.lblTest4 = new System.Windows.Forms.Label();
            this.lblTest3 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(48, 27);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(100, 20);
            this.txtTest1.TabIndex = 0;
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(48, 77);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(100, 20);
            this.txtTest2.TabIndex = 1;
            // 
            // txtTest3
            // 
            this.txtTest3.Location = new System.Drawing.Point(48, 129);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(100, 20);
            this.txtTest3.TabIndex = 2;
            // 
            // txtTest4
            // 
            this.txtTest4.Location = new System.Drawing.Point(48, 177);
            this.txtTest4.Name = "txtTest4";
            this.txtTest4.Size = new System.Drawing.Size(100, 20);
            this.txtTest4.TabIndex = 3;
            // 
            // txtTest5
            // 
            this.txtTest5.Location = new System.Drawing.Point(48, 225);
            this.txtTest5.Name = "txtTest5";
            this.txtTest5.Size = new System.Drawing.Size(100, 20);
            this.txtTest5.TabIndex = 4;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(189, 127);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 6;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblTest1
            // 
            this.lblTest1.AutoSize = true;
            this.lblTest1.Location = new System.Drawing.Point(48, 13);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(37, 13);
            this.lblTest1.TabIndex = 7;
            this.lblTest1.Text = "Test 1";
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Location = new System.Drawing.Point(48, 61);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(37, 13);
            this.lblTest2.TabIndex = 8;
            this.lblTest2.Text = "Test 2";
            // 
            // lblTest5
            // 
            this.lblTest5.AutoSize = true;
            this.lblTest5.Location = new System.Drawing.Point(48, 209);
            this.lblTest5.Name = "lblTest5";
            this.lblTest5.Size = new System.Drawing.Size(37, 13);
            this.lblTest5.TabIndex = 9;
            this.lblTest5.Text = "Test 5";
            // 
            // lblTest4
            // 
            this.lblTest4.AutoSize = true;
            this.lblTest4.Location = new System.Drawing.Point(48, 161);
            this.lblTest4.Name = "lblTest4";
            this.lblTest4.Size = new System.Drawing.Size(37, 13);
            this.lblTest4.TabIndex = 10;
            this.lblTest4.Text = "Test 4";
            // 
            // lblTest3
            // 
            this.lblTest3.AutoSize = true;
            this.lblTest3.Location = new System.Drawing.Point(48, 113);
            this.lblTest3.Name = "lblTest3";
            this.lblTest3.Size = new System.Drawing.Size(37, 13);
            this.lblTest3.TabIndex = 11;
            this.lblTest3.Text = "Test 3";
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(301, 131);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(345, 21);
            this.lblAverage.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblTest3);
            this.Controls.Add(this.lblTest4);
            this.Controls.Add(this.lblTest5);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.lblTest1);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.txtTest5);
            this.Controls.Add(this.txtTest4);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.txtTest1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.TextBox txtTest3;
        private System.Windows.Forms.TextBox txtTest4;
        private System.Windows.Forms.TextBox txtTest5;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.Label lblTest5;
        private System.Windows.Forms.Label lblTest4;
        private System.Windows.Forms.Label lblTest3;
        private System.Windows.Forms.Label lblAverage;
    }
}

