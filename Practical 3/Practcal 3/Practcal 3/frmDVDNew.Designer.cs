
namespace Practcal_3
{
    partial class frmDVDNew
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
            this.dbvGrid = new System.Windows.Forms.DataGridView();
            this.btnAction = new System.Windows.Forms.Button();
            this.sbAge = new System.Windows.Forms.HScrollBar();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dbvGrid
            // 
            this.dbvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbvGrid.Location = new System.Drawing.Point(12, 12);
            this.dbvGrid.Name = "dbvGrid";
            this.dbvGrid.Size = new System.Drawing.Size(551, 246);
            this.dbvGrid.TabIndex = 0;
            this.dbvGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(12, 298);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(111, 33);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Action Movies";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // sbAge
            // 
            this.sbAge.LargeChange = 1;
            this.sbAge.Location = new System.Drawing.Point(410, 314);
            this.sbAge.Name = "sbAge";
            this.sbAge.Size = new System.Drawing.Size(153, 17);
            this.sbAge.TabIndex = 2;
            this.sbAge.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(413, 348);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(82, 13);
            this.lblDisplay.TabIndex = 3;
            this.lblDisplay.Text = "Age Restriction:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select your age:";
            // 
            // frmDVDNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.sbAge);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.dbvGrid);
            this.Name = "frmDVDNew";
            this.Text = "DVD List";
            this.Load += new System.EventHandler(this.frmDVDNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbvGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbvGrid;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.HScrollBar sbAge;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label label1;
    }
}