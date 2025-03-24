namespace Practical_4___43054226
{
    partial class frmDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelDelete = new System.Windows.Forms.TextBox();
            this.btnFinalDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Model:";
            // 
            // txtModelDelete
            // 
            this.txtModelDelete.Location = new System.Drawing.Point(173, 51);
            this.txtModelDelete.Name = "txtModelDelete";
            this.txtModelDelete.Size = new System.Drawing.Size(100, 22);
            this.txtModelDelete.TabIndex = 1;
            // 
            // btnFinalDelete
            // 
            this.btnFinalDelete.Location = new System.Drawing.Point(347, 40);
            this.btnFinalDelete.Name = "btnFinalDelete";
            this.btnFinalDelete.Size = new System.Drawing.Size(97, 39);
            this.btnFinalDelete.TabIndex = 2;
            this.btnFinalDelete.Text = "Delete";
            this.btnFinalDelete.UseVisualStyleBackColor = true;
            this.btnFinalDelete.Click += new System.EventHandler(this.btnFinalDelete_Click);
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 137);
            this.Controls.Add(this.btnFinalDelete);
            this.Controls.Add(this.txtModelDelete);
            this.Controls.Add(this.label1);
            this.Name = "frmDelete";
            this.Text = "frmDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelDelete;
        private System.Windows.Forms.Button btnFinalDelete;
    }
}