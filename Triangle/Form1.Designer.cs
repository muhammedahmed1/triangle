namespace Triangle
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
            this.btnSolve = new System.Windows.Forms.Button();
            this.V3 = new System.Windows.Forms.Label();
            this.v3y = new System.Windows.Forms.TextBox();
            this.v3x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.v2y = new System.Windows.Forms.TextBox();
            this.v2x = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.V1 = new System.Windows.Forms.Label();
            this.v1y = new System.Windows.Forms.TextBox();
            this.v1x = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(988, 140);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 22;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // V3
            // 
            this.V3.AutoSize = true;
            this.V3.Location = new System.Drawing.Point(821, 108);
            this.V3.Name = "V3";
            this.V3.Size = new System.Drawing.Size(20, 13);
            this.V3.TabIndex = 21;
            this.V3.Text = "V3";
            // 
            // v3y
            // 
            this.v3y.Location = new System.Drawing.Point(963, 105);
            this.v3y.Name = "v3y";
            this.v3y.Size = new System.Drawing.Size(100, 20);
            this.v3y.TabIndex = 20;
            // 
            // v3x
            // 
            this.v3x.Location = new System.Drawing.Point(857, 105);
            this.v3x.Name = "v3x";
            this.v3x.Size = new System.Drawing.Size(100, 20);
            this.v3x.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(821, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "V2";
            // 
            // v2y
            // 
            this.v2y.Location = new System.Drawing.Point(963, 74);
            this.v2y.Name = "v2y";
            this.v2y.Size = new System.Drawing.Size(100, 20);
            this.v2y.TabIndex = 17;
            // 
            // v2x
            // 
            this.v2x.Location = new System.Drawing.Point(857, 74);
            this.v2x.Name = "v2x";
            this.v2x.Size = new System.Drawing.Size(100, 20);
            this.v2x.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(991, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(888, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "X";
            // 
            // V1
            // 
            this.V1.AutoSize = true;
            this.V1.Location = new System.Drawing.Point(821, 46);
            this.V1.Name = "V1";
            this.V1.Size = new System.Drawing.Size(20, 13);
            this.V1.TabIndex = 13;
            this.V1.Text = "V1";
            // 
            // v1y
            // 
            this.v1y.Location = new System.Drawing.Point(963, 43);
            this.v1y.Name = "v1y";
            this.v1y.Size = new System.Drawing.Size(100, 20);
            this.v1y.TabIndex = 11;
            // 
            // v1x
            // 
            this.v1x.Location = new System.Drawing.Point(857, 43);
            this.v1x.Name = "v1x";
            this.v1x.Size = new System.Drawing.Size(100, 20);
            this.v1x.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1076, 478);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.V3);
            this.Controls.Add(this.v3y);
            this.Controls.Add(this.v3x);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.v2y);
            this.Controls.Add(this.v2x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.V1);
            this.Controls.Add(this.v1y);
            this.Controls.Add(this.v1x);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.picGrid_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label V3;
        private System.Windows.Forms.TextBox v3y;
        private System.Windows.Forms.TextBox v3x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox v2y;
        private System.Windows.Forms.TextBox v2x;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label V1;
        private System.Windows.Forms.TextBox v1y;
        private System.Windows.Forms.TextBox v1x;


    }
}

