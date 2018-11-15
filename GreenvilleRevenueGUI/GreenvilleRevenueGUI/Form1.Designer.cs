namespace GreenvilleRevenueGUI
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
            this.txtYear1 = new System.Windows.Forms.TextBox();
            this.txtYear2 = new System.Windows.Forms.TextBox();
            this.lblYear1 = new System.Windows.Forms.Label();
            this.lblYear2 = new System.Windows.Forms.Label();
            this.lblRev1 = new System.Windows.Forms.Label();
            this.lblRev2 = new System.Windows.Forms.Label();
            this.btnRev = new System.Windows.Forms.Button();
            this.lblMoreCont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYear1
            // 
            this.txtYear1.Location = new System.Drawing.Point(48, 83);
            this.txtYear1.Name = "txtYear1";
            this.txtYear1.Size = new System.Drawing.Size(100, 20);
            this.txtYear1.TabIndex = 0;
            // 
            // txtYear2
            // 
            this.txtYear2.Location = new System.Drawing.Point(251, 83);
            this.txtYear2.Name = "txtYear2";
            this.txtYear2.Size = new System.Drawing.Size(100, 20);
            this.txtYear2.TabIndex = 1;
            // 
            // lblYear1
            // 
            this.lblYear1.AutoSize = true;
            this.lblYear1.Location = new System.Drawing.Point(45, 67);
            this.lblYear1.Name = "lblYear1";
            this.lblYear1.Size = new System.Drawing.Size(165, 13);
            this.lblYear1.TabIndex = 2;
            this.lblYear1.Text = "Last year\'s amount of contestants";
            // 
            // lblYear2
            // 
            this.lblYear2.AutoSize = true;
            this.lblYear2.Location = new System.Drawing.Point(248, 67);
            this.lblYear2.Name = "lblYear2";
            this.lblYear2.Size = new System.Drawing.Size(165, 13);
            this.lblYear2.TabIndex = 3;
            this.lblYear2.Text = "This year\'s amount of contestants";
            // 
            // lblRev1
            // 
            this.lblRev1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRev1.Location = new System.Drawing.Point(48, 175);
            this.lblRev1.Name = "lblRev1";
            this.lblRev1.Size = new System.Drawing.Size(100, 23);
            this.lblRev1.TabIndex = 4;
            // 
            // lblRev2
            // 
            this.lblRev2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRev2.Location = new System.Drawing.Point(251, 175);
            this.lblRev2.Name = "lblRev2";
            this.lblRev2.Size = new System.Drawing.Size(100, 23);
            this.lblRev2.TabIndex = 5;
            // 
            // btnRev
            // 
            this.btnRev.Location = new System.Drawing.Point(159, 132);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(75, 23);
            this.btnRev.TabIndex = 6;
            this.btnRev.Text = "Revnue";
            this.btnRev.UseVisualStyleBackColor = true;
            this.btnRev.Click += new System.EventHandler(this.btnRev_Click);
            // 
            // lblMoreCont
            // 
            this.lblMoreCont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoreCont.Location = new System.Drawing.Point(48, 221);
            this.lblMoreCont.Name = "lblMoreCont";
            this.lblMoreCont.Size = new System.Drawing.Size(186, 23);
            this.lblMoreCont.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMoreCont);
            this.Controls.Add(this.btnRev);
            this.Controls.Add(this.lblRev2);
            this.Controls.Add(this.lblRev1);
            this.Controls.Add(this.lblYear2);
            this.Controls.Add(this.lblYear1);
            this.Controls.Add(this.txtYear2);
            this.Controls.Add(this.txtYear1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYear1;
        private System.Windows.Forms.TextBox txtYear2;
        private System.Windows.Forms.Label lblYear1;
        private System.Windows.Forms.Label lblYear2;
        private System.Windows.Forms.Label lblRev1;
        private System.Windows.Forms.Label lblRev2;
        private System.Windows.Forms.Button btnRev;
        private System.Windows.Forms.Label lblMoreCont;
    }
}

