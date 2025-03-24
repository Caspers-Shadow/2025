
namespace Practical_2
{
    partial class frmAllBooks
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
            this.dbView = new System.Windows.Forms.DataGridView();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnTopRated = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).BeginInit();
            this.SuspendLayout();
            // 
            // dbView
            // 
            this.dbView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbView.Location = new System.Drawing.Point(12, 21);
            this.dbView.Name = "dbView";
            this.dbView.Size = new System.Drawing.Size(646, 268);
            this.dbView.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 323);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(128, 323);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display All";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnTopRated
            // 
            this.btnTopRated.Location = new System.Drawing.Point(247, 323);
            this.btnTopRated.Name = "btnTopRated";
            this.btnTopRated.Size = new System.Drawing.Size(75, 23);
            this.btnTopRated.TabIndex = 3;
            this.btnTopRated.Text = "Top Rated";
            this.btnTopRated.UseVisualStyleBackColor = true;
            this.btnTopRated.Click += new System.EventHandler(this.btnTopRated_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(583, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTopRated);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.dbView);
            this.Name = "frmAllBooks";
            this.Text = "frmAllBooks";
            this.Load += new System.EventHandler(this.frmAllBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbView;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnTopRated;
        private System.Windows.Forms.Button btnExit;
    }
}