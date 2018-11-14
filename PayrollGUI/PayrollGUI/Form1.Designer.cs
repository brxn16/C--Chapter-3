namespace PayrollGUI
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSocial = new System.Windows.Forms.TextBox();
            this.txtHourly = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSocial = new System.Windows.Forms.Label();
            this.lblHourly = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblStateTax = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblFedTax = new System.Windows.Forms.Label();
            this.lblHelpGross = new System.Windows.Forms.Label();
            this.lblHelpFed = new System.Windows.Forms.Label();
            this.lblHelpState = new System.Windows.Forms.Label();
            this.lblHelpNet = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtSocial
            // 
            this.txtSocial.Location = new System.Drawing.Point(203, 86);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(100, 20);
            this.txtSocial.TabIndex = 1;
            // 
            // txtHourly
            // 
            this.txtHourly.Location = new System.Drawing.Point(203, 127);
            this.txtHourly.Name = "txtHourly";
            this.txtHourly.Size = new System.Drawing.Size(100, 20);
            this.txtHourly.TabIndex = 2;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(203, 166);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.txtHoursWorked.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Enter Your Name";
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.Location = new System.Drawing.Point(6, 86);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(170, 13);
            this.lblSocial.TabIndex = 5;
            this.lblSocial.Text = "Enter Your Social Security Number";
            // 
            // lblHourly
            // 
            this.lblHourly.AutoSize = true;
            this.lblHourly.Location = new System.Drawing.Point(6, 127);
            this.lblHourly.Name = "lblHourly";
            this.lblHourly.Size = new System.Drawing.Size(111, 13);
            this.lblHourly.TabIndex = 6;
            this.lblHourly.Text = "Enter Your Hourly Pay";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(6, 166);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(182, 13);
            this.lblHoursWorked.TabIndex = 7;
            this.lblHoursWorked.Text = "Enter Your Amount Of Hours Worked";
            // 
            // lblGross
            // 
            this.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGross.Location = new System.Drawing.Point(578, 48);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(154, 23);
            this.lblGross.TabIndex = 8;
            // 
            // lblStateTax
            // 
            this.lblStateTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStateTax.Location = new System.Drawing.Point(578, 126);
            this.lblStateTax.Name = "lblStateTax";
            this.lblStateTax.Size = new System.Drawing.Size(154, 23);
            this.lblStateTax.TabIndex = 9;
            // 
            // lblNet
            // 
            this.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNet.Location = new System.Drawing.Point(578, 168);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(154, 23);
            this.lblNet.TabIndex = 10;
            // 
            // lblFedTax
            // 
            this.lblFedTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFedTax.Location = new System.Drawing.Point(578, 88);
            this.lblFedTax.Name = "lblFedTax";
            this.lblFedTax.Size = new System.Drawing.Size(154, 23);
            this.lblFedTax.TabIndex = 12;
            // 
            // lblHelpGross
            // 
            this.lblHelpGross.AutoSize = true;
            this.lblHelpGross.Location = new System.Drawing.Point(506, 48);
            this.lblHelpGross.Name = "lblHelpGross";
            this.lblHelpGross.Size = new System.Drawing.Size(55, 13);
            this.lblHelpGross.TabIndex = 13;
            this.lblHelpGross.Text = "Gross Pay";
            // 
            // lblHelpFed
            // 
            this.lblHelpFed.AutoSize = true;
            this.lblHelpFed.Location = new System.Drawing.Point(506, 85);
            this.lblHelpFed.Name = "lblHelpFed";
            this.lblHelpFed.Size = new System.Drawing.Size(63, 13);
            this.lblHelpFed.TabIndex = 14;
            this.lblHelpFed.Text = "Federal Tax";
            // 
            // lblHelpState
            // 
            this.lblHelpState.AutoSize = true;
            this.lblHelpState.Location = new System.Drawing.Point(506, 126);
            this.lblHelpState.Name = "lblHelpState";
            this.lblHelpState.Size = new System.Drawing.Size(53, 13);
            this.lblHelpState.TabIndex = 15;
            this.lblHelpState.Text = "State Tax";
            // 
            // lblHelpNet
            // 
            this.lblHelpNet.AutoSize = true;
            this.lblHelpNet.Location = new System.Drawing.Point(506, 169);
            this.lblHelpNet.Name = "lblHelpNet";
            this.lblHelpNet.Size = new System.Drawing.Size(45, 13);
            this.lblHelpNet.TabIndex = 16;
            this.lblHelpNet.Text = "Net Pay";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(362, 115);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 17;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblHelpNet);
            this.Controls.Add(this.lblHelpState);
            this.Controls.Add(this.lblHelpFed);
            this.Controls.Add(this.lblHelpGross);
            this.Controls.Add(this.lblFedTax);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblStateTax);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblHourly);
            this.Controls.Add(this.lblSocial);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtHourly);
            this.Controls.Add(this.txtSocial);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSocial;
        private System.Windows.Forms.TextBox txtHourly;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSocial;
        private System.Windows.Forms.Label lblHourly;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblStateTax;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblFedTax;
        private System.Windows.Forms.Label lblHelpGross;
        private System.Windows.Forms.Label lblHelpFed;
        private System.Windows.Forms.Label lblHelpState;
        private System.Windows.Forms.Label lblHelpNet;
        private System.Windows.Forms.Button btnCalc;
    }
}

