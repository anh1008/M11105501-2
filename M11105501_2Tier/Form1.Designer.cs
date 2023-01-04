namespace M11105501_2Tier
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVGRpeakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail1BindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.detailDataSet1 = new M11105501_2Tier.DetailDataSet();
            this.detail1BindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.detail1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailDataSet = new M11105501_2Tier.DetailDataSet();
            this.detailDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailTableAdapter = new M11105501_2Tier.DetailDataSetTableAdapters.DetailTableAdapter();
            this.detail1TableAdapter = new M11105501_2Tier.DetailDataSetTableAdapters.Detail1TableAdapter();
            this.detail1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detailDataSet2 = new M11105501_2Tier.DetailDataSet();
            this.detail1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.detail1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.detailDataSet3 = new M11105501_2Tier.DetailDataSet();
            this.detail1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.detail1BindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.detail1BindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.detail2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detail2TableAdapter = new M11105501_2Tier.DetailDataSetTableAdapters.Detail2TableAdapter();
            this.listDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCGRpeakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 466);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Q1-1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regionDataGridViewTextBoxColumn,
            this.aVGRpeakDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detail1BindingSource6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(797, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Q1-2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.ReadOnly = true;
            this.regionDataGridViewTextBoxColumn.Width = 150;
            // 
            // aVGRpeakDataGridViewTextBoxColumn
            // 
            this.aVGRpeakDataGridViewTextBoxColumn.DataPropertyName = "AVG_Rpeak";
            this.aVGRpeakDataGridViewTextBoxColumn.HeaderText = "AVG_Rpeak";
            this.aVGRpeakDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aVGRpeakDataGridViewTextBoxColumn.Name = "aVGRpeakDataGridViewTextBoxColumn";
            this.aVGRpeakDataGridViewTextBoxColumn.ReadOnly = true;
            this.aVGRpeakDataGridViewTextBoxColumn.Width = 150;
            // 
            // detail1BindingSource6
            // 
            this.detail1BindingSource6.DataMember = "Detail1";
            this.detail1BindingSource6.DataSource = this.detailDataSet1;
            // 
            // detailDataSet1
            // 
            this.detailDataSet1.DataSetName = "DetailDataSet";
            this.detailDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detail1BindingSource8
            // 
            this.detail1BindingSource8.DataMember = "Detail1";
            this.detail1BindingSource8.DataSource = this.detailDataSet1;
            // 
            // detail1BindingSource
            // 
            this.detail1BindingSource.DataMember = "Detail1";
            this.detail1BindingSource.DataSource = this.detailDataSet1;
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataMember = "Detail";
            this.detailBindingSource.DataSource = this.detailDataSet;
            // 
            // detailDataSet
            // 
            this.detailDataSet.DataSetName = "DetailDataSet";
            this.detailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailDataSetBindingSource
            // 
            this.detailDataSetBindingSource.DataSource = this.detailDataSet;
            this.detailDataSetBindingSource.Position = 0;
            // 
            // detailTableAdapter
            // 
            this.detailTableAdapter.ClearBeforeFill = true;
            // 
            // detail1TableAdapter
            // 
            this.detail1TableAdapter.ClearBeforeFill = true;
            // 
            // detail1BindingSource1
            // 
            this.detail1BindingSource1.DataMember = "Detail1";
            this.detail1BindingSource1.DataSource = this.detailDataSet1;
            // 
            // detailDataSet2
            // 
            this.detailDataSet2.DataSetName = "DetailDataSet";
            this.detailDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detail1BindingSource2
            // 
            this.detail1BindingSource2.DataMember = "Detail1";
            this.detail1BindingSource2.DataSource = this.detailDataSet2;
            // 
            // detail1BindingSource3
            // 
            this.detail1BindingSource3.DataMember = "Detail1";
            this.detail1BindingSource3.DataSource = this.detailDataSet2;
            // 
            // detailDataSet3
            // 
            this.detailDataSet3.DataSetName = "DetailDataSet";
            this.detailDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detail1BindingSource4
            // 
            this.detail1BindingSource4.DataMember = "Detail1";
            this.detail1BindingSource4.DataSource = this.detailDataSet3;
            // 
            // detail1BindingSource5
            // 
            this.detail1BindingSource5.DataMember = "Detail1";
            this.detail1BindingSource5.DataSource = this.detailDataSet1;
            // 
            // detail1BindingSource7
            // 
            this.detail1BindingSource7.DataMember = "Detail1";
            this.detail1BindingSource7.DataSource = this.detailDataSet1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listDataGridViewTextBoxColumn,
            this.aCGRpeakDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.detail2BindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 31;
            this.dataGridView2.Size = new System.Drawing.Size(797, 428);
            this.dataGridView2.TabIndex = 0;
            // 
            // detail2BindingSource
            // 
            this.detail2BindingSource.DataMember = "Detail2";
            this.detail2BindingSource.DataSource = this.detailDataSet1;
            // 
            // detail2TableAdapter
            // 
            this.detail2TableAdapter.ClearBeforeFill = true;
            // 
            // listDataGridViewTextBoxColumn
            // 
            this.listDataGridViewTextBoxColumn.DataPropertyName = "List";
            this.listDataGridViewTextBoxColumn.HeaderText = "List";
            this.listDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.listDataGridViewTextBoxColumn.Name = "listDataGridViewTextBoxColumn";
            this.listDataGridViewTextBoxColumn.ReadOnly = true;
            this.listDataGridViewTextBoxColumn.Width = 150;
            // 
            // aCGRpeakDataGridViewTextBoxColumn
            // 
            this.aCGRpeakDataGridViewTextBoxColumn.DataPropertyName = "ACG_Rpeak";
            this.aCGRpeakDataGridViewTextBoxColumn.HeaderText = "ACG_Rpeak";
            this.aCGRpeakDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aCGRpeakDataGridViewTextBoxColumn.Name = "aCGRpeakDataGridViewTextBoxColumn";
            this.aCGRpeakDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCGRpeakDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 470);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail1BindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource detailDataSetBindingSource;
        private DetailDataSet detailDataSet;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private DetailDataSetTableAdapters.DetailTableAdapter detailTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DetailDataSet detailDataSet1;
        private System.Windows.Forms.BindingSource detail1BindingSource;
        private DetailDataSetTableAdapters.Detail1TableAdapter detail1TableAdapter;
        private System.Windows.Forms.BindingSource detail1BindingSource1;
        private DetailDataSet detailDataSet2;
        private System.Windows.Forms.BindingSource detail1BindingSource2;
        private System.Windows.Forms.BindingSource detail1BindingSource3;
        private DetailDataSet detailDataSet3;
        private System.Windows.Forms.BindingSource detail1BindingSource4;
        private System.Windows.Forms.BindingSource detail1BindingSource5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVGRpeakDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detail1BindingSource6;
        private System.Windows.Forms.BindingSource detail1BindingSource7;
        private System.Windows.Forms.BindingSource detail1BindingSource8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource detail2BindingSource;
        private DetailDataSetTableAdapters.Detail2TableAdapter detail2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn listDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCGRpeakDataGridViewTextBoxColumn;
    }
}

