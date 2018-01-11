namespace PlayerUI
{
    partial class frmPlayerUI
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
            this.dgView = new System.Windows.Forms.DataGridView();
            this.btnRetrieveAllPlayers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.AllowUserToOrderColumns = true;
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.Location = new System.Drawing.Point(0, 0);
            this.dgView.Name = "dgView";
            this.dgView.RowTemplate.Height = 24;
            this.dgView.Size = new System.Drawing.Size(407, 291);
            this.dgView.TabIndex = 0;
            // 
            // btnRetrieveAllPlayers
            // 
            this.btnRetrieveAllPlayers.Location = new System.Drawing.Point(127, 220);
            this.btnRetrieveAllPlayers.Name = "btnRetrieveAllPlayers";
            this.btnRetrieveAllPlayers.Size = new System.Drawing.Size(150, 23);
            this.btnRetrieveAllPlayers.TabIndex = 1;
            this.btnRetrieveAllPlayers.Text = "Show All Players";
            this.btnRetrieveAllPlayers.UseVisualStyleBackColor = true;
            this.btnRetrieveAllPlayers.Click += new System.EventHandler(this.btnRetrieveAllPlayers_Click);
            // 
            // frmPlayerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 291);
            this.Controls.Add(this.btnRetrieveAllPlayers);
            this.Controls.Add(this.dgView);
            this.Name = "frmPlayerUI";
            this.Text = "Player UI";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button btnRetrieveAllPlayers;
    }
}

