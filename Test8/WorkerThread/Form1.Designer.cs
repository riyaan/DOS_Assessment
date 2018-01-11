namespace WorkerThread
{
    partial class frmWorker
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
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(49, 68);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(88, 17);
            this.lblOne.TabIndex = 0;
            this.lblOne.Text = "Put text here";
            this.lblOne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Location = new System.Drawing.Point(49, 135);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(88, 17);
            this.lblTwo.TabIndex = 1;
            this.lblTwo.Text = "Put text here";
            this.lblTwo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.Location = new System.Drawing.Point(49, 205);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(88, 17);
            this.lblThree.TabIndex = 2;
            this.lblThree.Text = "Put text here";
            this.lblThree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(337, 247);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // frmWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 412);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.lblOne);
            this.Name = "frmWorker";
            this.Text = "Worker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Button btnGo;
    }
}

