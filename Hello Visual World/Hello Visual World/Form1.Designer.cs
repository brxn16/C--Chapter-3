namespace Hello_Visual_World
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.btnGoodbye = new System.Windows.Forms.Button();
            this.btnClickLast = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(297, 127);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(75, 23);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // btnGoodbye
            // 
            this.btnGoodbye.Location = new System.Drawing.Point(297, 215);
            this.btnGoodbye.Name = "btnGoodbye";
            this.btnGoodbye.Size = new System.Drawing.Size(75, 42);
            this.btnGoodbye.TabIndex = 1;
            this.btnGoodbye.Text = "Click Me Last";
            this.btnGoodbye.UseVisualStyleBackColor = true;
            this.btnGoodbye.Click += new System.EventHandler(this.btnGoodbye_Click);
            // 
            // btnClickLast
            // 
            this.btnClickLast.Location = new System.Drawing.Point(297, 305);
            this.btnClickLast.Name = "btnClickLast";
            this.btnClickLast.Size = new System.Drawing.Size(75, 79);
            this.btnClickLast.TabIndex = 2;
            this.btnClickLast.Text = "No, Really. Click Me last";
            this.btnClickLast.UseVisualStyleBackColor = true;
            this.btnClickLast.Click += new System.EventHandler(this.btnClickLast_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(294, 55);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(99, 13);
            this.lblHello.TabIndex = 3;
            this.lblHello.Text = "Hello, Visual World!";
            this.lblHello.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnClickLast);
            this.Controls.Add(this.btnGoodbye);
            this.Controls.Add(this.btnClickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Button btnGoodbye;
        private System.Windows.Forms.Button btnClickLast;
        private System.Windows.Forms.Label lblHello;
    }
}

