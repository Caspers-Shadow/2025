namespace Practical_4___43054226
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
            this.tbcVehicles = new System.Windows.Forms.TabControl();
            this.tpVSD = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.tbAdd = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.tbcVehicles.SuspendLayout();
            this.tpVSD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.tbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcVehicles
            // 
            this.tbcVehicles.Controls.Add(this.tpVSD);
            this.tbcVehicles.Controls.Add(this.tbAdd);
            this.tbcVehicles.Location = new System.Drawing.Point(0, 2);
            this.tbcVehicles.Name = "tbcVehicles";
            this.tbcVehicles.SelectedIndex = 0;
            this.tbcVehicles.Size = new System.Drawing.Size(788, 436);
            this.tbcVehicles.TabIndex = 0;
            // 
            // tpVSD
            // 
            this.tpVSD.Controls.Add(this.label1);
            this.tpVSD.Controls.Add(this.btnDelete);
            this.tpVSD.Controls.Add(this.txtSearch);
            this.tpVSD.Controls.Add(this.dgvVehicles);
            this.tpVSD.Location = new System.Drawing.Point(4, 25);
            this.tpVSD.Name = "tpVSD";
            this.tpVSD.Padding = new System.Windows.Forms.Padding(3);
            this.tpVSD.Size = new System.Drawing.Size(780, 407);
            this.tpVSD.TabIndex = 0;
            this.tpVSD.Text = "View, Search and Delete";
            this.tpVSD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(25, 274);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete a record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(316, 284);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(8, 6);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.RowHeadersWidth = 51;
            this.dgvVehicles.RowTemplate.Height = 24;
            this.dgvVehicles.Size = new System.Drawing.Size(766, 225);
            this.dgvVehicles.TabIndex = 0;
            // 
            // tbAdd
            // 
            this.tbAdd.Controls.Add(this.label6);
            this.tbAdd.Controls.Add(this.label5);
            this.tbAdd.Controls.Add(this.label4);
            this.tbAdd.Controls.Add(this.label3);
            this.tbAdd.Controls.Add(this.label2);
            this.tbAdd.Controls.Add(this.btnAdd);
            this.tbAdd.Controls.Add(this.cmbType);
            this.tbAdd.Controls.Add(this.txtBrand);
            this.tbAdd.Controls.Add(this.txtModel);
            this.tbAdd.Controls.Add(this.txtYear);
            this.tbAdd.Controls.Add(this.txtVIN);
            this.tbAdd.Location = new System.Drawing.Point(4, 25);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tbAdd.Size = new System.Drawing.Size(780, 407);
            this.tbAdd.TabIndex = 1;
            this.tbAdd.Text = "Add Vehicle";
            this.tbAdd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vehicle Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vehicle Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vehicle Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Veheicle Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vin Number:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(280, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 34);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Vehicle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(239, 272);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 4;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(239, 103);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 22);
            this.txtBrand.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(239, 154);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(239, 216);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 1;
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(239, 45);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(100, 22);
            this.txtVIN.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcVehicles);
            this.Name = "Form1";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcVehicles.ResumeLayout(false);
            this.tpVSD.ResumeLayout(false);
            this.tpVSD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.tbAdd.ResumeLayout(false);
            this.tbAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcVehicles;
        private System.Windows.Forms.TabPage tpVSD;
        private System.Windows.Forms.TabPage tbAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

