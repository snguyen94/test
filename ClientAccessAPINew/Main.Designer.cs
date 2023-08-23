namespace HistorianCSharp
{
    partial class Main
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
            this.cmdReadData = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.cmdWriteData = new System.Windows.Forms.Button();
            this.cmdBrowseTags = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTags = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTagnameFilter = new System.Windows.Forms.TextBox();
            this.grpRead = new System.Windows.Forms.GroupBox();
            this.dataGridData = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtTimestamp = new System.Windows.Forms.DateTimePicker();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WriteDataToMultiField = new System.Windows.Forms.Button();
            this.AddMultiFieldTag = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTagType1 = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridData)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdReadData
            // 
            this.cmdReadData.Location = new System.Drawing.Point(21, 19);
            this.cmdReadData.Name = "cmdReadData";
            this.cmdReadData.Size = new System.Drawing.Size(94, 23);
            this.cmdReadData.TabIndex = 0;
            this.cmdReadData.Text = "Read Data";
            this.cmdReadData.UseVisualStyleBackColor = true;
            this.cmdReadData.Click += new System.EventHandler(this.cmdReadData_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus,
            this.tsProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.BackColor = System.Drawing.Color.Transparent;
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(39, 17);
            this.tsStatus.Text = "Ready";
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Margin = new System.Windows.Forms.Padding(700, 3, 1, 3);
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdConnect);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 52);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server or IP Address";
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(213, 19);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(94, 23);
            this.cmdConnect.TabIndex = 6;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerName.ForeColor = System.Drawing.Color.Red;
            this.txtServerName.Location = new System.Drawing.Point(6, 19);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(188, 26);
            this.txtServerName.TabIndex = 0;
            // 
            // cmdWriteData
            // 
            this.cmdWriteData.Location = new System.Drawing.Point(6, 83);
            this.cmdWriteData.Name = "cmdWriteData";
            this.cmdWriteData.Size = new System.Drawing.Size(94, 23);
            this.cmdWriteData.TabIndex = 7;
            this.cmdWriteData.Text = "Write Data";
            this.cmdWriteData.UseVisualStyleBackColor = true;
            this.cmdWriteData.Click += new System.EventHandler(this.cmdWriteData_Click);
            // 
            // cmdBrowseTags
            // 
            this.cmdBrowseTags.Location = new System.Drawing.Point(325, 19);
            this.cmdBrowseTags.Name = "cmdBrowseTags";
            this.cmdBrowseTags.Size = new System.Drawing.Size(94, 51);
            this.cmdBrowseTags.TabIndex = 6;
            this.cmdBrowseTags.Text = "Browse Tags";
            this.cmdBrowseTags.UseVisualStyleBackColor = true;
            this.cmdBrowseTags.Click += new System.EventHandler(this.cmdBrowseTags_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboTagType1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboTags);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmdBrowseTags);
            this.groupBox2.Controls.Add(this.txtTagnameFilter);
            this.groupBox2.Location = new System.Drawing.Point(18, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 139);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tags";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tags";
            // 
            // cboTags
            // 
            this.cboTags.FormattingEnabled = true;
            this.cboTags.Location = new System.Drawing.Point(21, 106);
            this.cboTags.Name = "cboTags";
            this.cboTags.Size = new System.Drawing.Size(397, 21);
            this.cboTags.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tagname Filter";
            // 
            // txtTagnameFilter
            // 
            this.txtTagnameFilter.Location = new System.Drawing.Point(118, 19);
            this.txtTagnameFilter.Name = "txtTagnameFilter";
            this.txtTagnameFilter.Size = new System.Drawing.Size(189, 20);
            this.txtTagnameFilter.TabIndex = 10;
            this.txtTagnameFilter.Text = "*";
            // 
            // grpRead
            // 
            this.grpRead.Controls.Add(this.dataGridData);
            this.grpRead.Controls.Add(this.cmdReadData);
            this.grpRead.Location = new System.Drawing.Point(454, 70);
            this.grpRead.Name = "grpRead";
            this.grpRead.Size = new System.Drawing.Size(418, 371);
            this.grpRead.TabIndex = 11;
            this.grpRead.TabStop = false;
            this.grpRead.Text = "Read Data";
            // 
            // dataGridData
            // 
            this.dataGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridData.Location = new System.Drawing.Point(6, 48);
            this.dataGridData.Name = "dataGridData";
            this.dataGridData.Size = new System.Drawing.Size(332, 317);
            this.dataGridData.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmdWriteData);
            this.groupBox5.Controls.Add(this.dtTimestamp);
            this.groupBox5.Controls.Add(this.txtValue);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(18, 215);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(430, 124);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Write Data";
            // 
            // dtTimestamp
            // 
            this.dtTimestamp.CustomFormat = "MM/dd/yyyy HH:m:ss";
            this.dtTimestamp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimestamp.Location = new System.Drawing.Point(145, 16);
            this.dtTimestamp.Name = "dtTimestamp";
            this.dtTimestamp.Size = new System.Drawing.Size(149, 20);
            this.dtTimestamp.TabIndex = 6;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(143, 42);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(275, 20);
            this.txtValue.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Timestamp (24hr clock)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Value";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.WriteDataToMultiField);
            this.groupBox3.Controls.Add(this.AddMultiFieldTag);
            this.groupBox3.Location = new System.Drawing.Point(18, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 96);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MultiField Tags";
            // 
            // WriteDataToMultiField
            // 
            this.WriteDataToMultiField.Location = new System.Drawing.Point(27, 59);
            this.WriteDataToMultiField.Name = "WriteDataToMultiField";
            this.WriteDataToMultiField.Size = new System.Drawing.Size(96, 24);
            this.WriteDataToMultiField.TabIndex = 1;
            this.WriteDataToMultiField.Text = "Write Data";
            this.WriteDataToMultiField.UseVisualStyleBackColor = true;
            this.WriteDataToMultiField.Click += new System.EventHandler(this.WriteDataToMultiField_Click);
            // 
            // AddMultiFieldTag
            // 
            this.AddMultiFieldTag.Location = new System.Drawing.Point(14, 19);
            this.AddMultiFieldTag.Name = "AddMultiFieldTag";
            this.AddMultiFieldTag.Size = new System.Drawing.Size(160, 27);
            this.AddMultiFieldTag.TabIndex = 0;
            this.AddMultiFieldTag.Text = "Add MultiField Tag with Type";
            this.AddMultiFieldTag.UseVisualStyleBackColor = true;
            this.AddMultiFieldTag.Click += new System.EventHandler(this.AddMultiFieldTag_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tag Type";
            // 
            // cboTagType1
            // 
            this.cboTagType1.FormattingEnabled = true;
            this.cboTagType1.Location = new System.Drawing.Point(118, 48);
            this.cboTagType1.Name = "cboTagType1";
            this.cboTagType1.Size = new System.Drawing.Size(189, 21);
            this.cboTagType1.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 466);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grpRead);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Main";
            this.Text = "Proficy Historian Client Access API Sample";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpRead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridData)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdReadData;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBrowseTags;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpRead;
        private System.Windows.Forms.DataGridView dataGridData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button cmdWriteData;
        private System.Windows.Forms.DateTimePicker dtTimestamp;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTagnameFilter;
        private System.Windows.Forms.ComboBox cboTags;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button WriteDataToMultiField;
        private System.Windows.Forms.Button AddMultiFieldTag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTagType1;
    }
}

