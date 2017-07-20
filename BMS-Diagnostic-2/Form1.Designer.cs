namespace BMS_Diagnostic_2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdProgrammi = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new System.Data.DataSet();
            this.InstallTable = new System.Data.DataTable();
            this.DisplayName = new System.Data.DataColumn();
            this.DisplayVersion = new System.Data.DataColumn();
            this.EstimatedSize = new System.Data.DataColumn();
            this.InstallDate = new System.Data.DataColumn();
            this.InstallLocation = new System.Data.DataColumn();
            this.Publisher = new System.Data.DataColumn();
            this.btnScan = new System.Windows.Forms.Button();
            this.ScanBar = new System.Windows.Forms.ProgressBar();
            this.btnFile = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProgrammi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallTable)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProgrammi
            // 
            this.grdProgrammi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProgrammi.Location = new System.Drawing.Point(27, 63);
            this.grdProgrammi.Name = "grdProgrammi";
            this.grdProgrammi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.grdProgrammi.Size = new System.Drawing.Size(743, 460);
            this.grdProgrammi.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.InstallTable});
            // 
            // InstallTable
            // 
            this.InstallTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.DisplayName,
            this.DisplayVersion,
            this.EstimatedSize,
            this.InstallDate,
            this.InstallLocation,
            this.Publisher});
            this.InstallTable.TableName = "InstallPrg";
            // 
            // DisplayName
            // 
            this.DisplayName.Caption = "DisplayName";
            this.DisplayName.ColumnName = "DisplayName";
            // 
            // DisplayVersion
            // 
            this.DisplayVersion.Caption = "DisplayVersion";
            this.DisplayVersion.ColumnName = "DisplayVersion";
            // 
            // EstimatedSize
            // 
            this.EstimatedSize.Caption = "EstimatedSize";
            this.EstimatedSize.ColumnName = "EstimatedSize";
            // 
            // InstallDate
            // 
            this.InstallDate.Caption = "InstallDate";
            this.InstallDate.ColumnName = "InstallDate";
            // 
            // InstallLocation
            // 
            this.InstallLocation.Caption = "InstallLocation";
            this.InstallLocation.ColumnName = "InstallLocation";
            // 
            // Publisher
            // 
            this.Publisher.Caption = "Publisher";
            this.Publisher.ColumnName = "Publisher";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(13, 24);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Start Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // ScanBar
            // 
            this.ScanBar.Location = new System.Drawing.Point(123, 529);
            this.ScanBar.Name = "ScanBar";
            this.ScanBar.Size = new System.Drawing.Size(534, 23);
            this.ScanBar.TabIndex = 2;
            this.ScanBar.Visible = false;
            // 
            // btnFile
            // 
            this.btnFile.Enabled = false;
            this.btnFile.Location = new System.Drawing.Point(123, 24);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "Crea File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(120, 565);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Loading...";
            this.lbl1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 603);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.ScanBar);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.grdProgrammi);
            this.Name = "Form1";
            this.Text = "BMS_Diagnostic";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProgrammi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProgrammi;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable InstallTable;
        private System.Data.DataColumn DisplayName;
        private System.Data.DataColumn DisplayVersion;
        private System.Data.DataColumn EstimatedSize;
        private System.Data.DataColumn InstallDate;
        private System.Data.DataColumn InstallLocation;
        private System.Data.DataColumn Publisher;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ProgressBar ScanBar;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lbl1;
    }
}

