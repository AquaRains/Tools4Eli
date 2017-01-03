namespace tools4eli
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serialnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filepathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filedataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new tools4eli.dataDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSetMatFilePath = new System.Windows.Forms.Button();
            this.txtMatFilePath = new System.Windows.Forms.TextBox();
            this.txtMFilePath = new System.Windows.Forms.TextBox();
            this.txtNsValue = new System.Windows.Forms.TextBox();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.openFileDialog_filepath = new System.Windows.Forms.OpenFileDialog();
            this.btnListAdd = new System.Windows.Forms.Button();
            this.BtnListMod = new System.Windows.Forms.Button();
            this.BtnListDel = new System.Windows.Forms.Button();
            this.openFileDialog_MatFilePath = new System.Windows.Forms.OpenFileDialog();
            this.file_dataTableAdapter = new tools4eli.dataDataSetTableAdapters.file_dataTableAdapter();
            this.ChkisSameFileName = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filedataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ChkisSameFileName);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.buttonOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파일 경로";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(40, 20);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(495, 21);
            this.txtFilePath.TabIndex = 1;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(540, 19);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(85, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "파일 열기";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1178, 475);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "목록";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialnoDataGridViewTextBoxColumn,
            this.nsvalueDataGridViewTextBoxColumn,
            this.filepathDataGridViewTextBoxColumn,
            this.respathDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filedataBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1172, 455);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // serialnoDataGridViewTextBoxColumn
            // 
            this.serialnoDataGridViewTextBoxColumn.DataPropertyName = "serial_no";
            this.serialnoDataGridViewTextBoxColumn.DividerWidth = 3;
            this.serialnoDataGridViewTextBoxColumn.HeaderText = "serial_no";
            this.serialnoDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.serialnoDataGridViewTextBoxColumn.Name = "serialnoDataGridViewTextBoxColumn";
            this.serialnoDataGridViewTextBoxColumn.Width = 84;
            // 
            // nsvalueDataGridViewTextBoxColumn
            // 
            this.nsvalueDataGridViewTextBoxColumn.DataPropertyName = "ns_value";
            this.nsvalueDataGridViewTextBoxColumn.HeaderText = "ns_value";
            this.nsvalueDataGridViewTextBoxColumn.MinimumWidth = 450;
            this.nsvalueDataGridViewTextBoxColumn.Name = "nsvalueDataGridViewTextBoxColumn";
            this.nsvalueDataGridViewTextBoxColumn.Width = 450;
            // 
            // filepathDataGridViewTextBoxColumn
            // 
            this.filepathDataGridViewTextBoxColumn.DataPropertyName = "file_path";
            this.filepathDataGridViewTextBoxColumn.HeaderText = "file_path";
            this.filepathDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.filepathDataGridViewTextBoxColumn.Name = "filepathDataGridViewTextBoxColumn";
            this.filepathDataGridViewTextBoxColumn.Width = 300;
            // 
            // respathDataGridViewTextBoxColumn
            // 
            this.respathDataGridViewTextBoxColumn.DataPropertyName = "res_path";
            this.respathDataGridViewTextBoxColumn.HeaderText = "res_path";
            this.respathDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.respathDataGridViewTextBoxColumn.Name = "respathDataGridViewTextBoxColumn";
            this.respathDataGridViewTextBoxColumn.Width = 300;
            // 
            // filedataBindingSource
            // 
            this.filedataBindingSource.DataMember = "file_data";
            this.filedataBindingSource.DataSource = this.dataDataSetBindingSource;
            // 
            // dataDataSetBindingSource
            // 
            this.dataDataSetBindingSource.DataSource = this.dataDataSet;
            this.dataDataSetBindingSource.Position = 0;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnSetMatFilePath);
            this.groupBox3.Controls.Add(this.txtMatFilePath);
            this.groupBox3.Controls.Add(this.txtMFilePath);
            this.groupBox3.Controls.Add(this.txtNsValue);
            this.groupBox3.Controls.Add(this.txtSerialNo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1175, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnSetMatFilePath
            // 
            this.btnSetMatFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetMatFilePath.Location = new System.Drawing.Point(1013, 20);
            this.btnSetMatFilePath.Name = "btnSetMatFilePath";
            this.btnSetMatFilePath.Size = new System.Drawing.Size(151, 23);
            this.btnSetMatFilePath.TabIndex = 8;
            this.btnSetMatFilePath.Text = "mat파일 경로 설정";
            this.btnSetMatFilePath.UseVisualStyleBackColor = true;
            this.btnSetMatFilePath.Click += new System.EventHandler(this.btnMatFilePath_Click);
            // 
            // txtMatFilePath
            // 
            this.txtMatFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatFilePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filedataBindingSource, "res_path", true));
            this.txtMatFilePath.Location = new System.Drawing.Point(883, 48);
            this.txtMatFilePath.Name = "txtMatFilePath";
            this.txtMatFilePath.ReadOnly = true;
            this.txtMatFilePath.Size = new System.Drawing.Size(281, 21);
            this.txtMatFilePath.TabIndex = 7;
            // 
            // txtMFilePath
            // 
            this.txtMFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMFilePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filedataBindingSource, "file_path", true));
            this.txtMFilePath.Location = new System.Drawing.Point(578, 48);
            this.txtMFilePath.Name = "txtMFilePath";
            this.txtMFilePath.ReadOnly = true;
            this.txtMFilePath.Size = new System.Drawing.Size(303, 21);
            this.txtMFilePath.TabIndex = 6;
            // 
            // txtNsValue
            // 
            this.txtNsValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filedataBindingSource, "ns_value", true));
            this.txtNsValue.Location = new System.Drawing.Point(92, 48);
            this.txtNsValue.Name = "txtNsValue";
            this.txtNsValue.ReadOnly = true;
            this.txtNsValue.Size = new System.Drawing.Size(483, 21);
            this.txtNsValue.TabIndex = 5;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filedataBindingSource, "serial_no", true));
            this.txtSerialNo.Enabled = false;
            this.txtSerialNo.Location = new System.Drawing.Point(6, 48);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.ReadOnly = true;
            this.txtSerialNo.Size = new System.Drawing.Size(80, 21);
            this.txtSerialNo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(881, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "\"*.mat\"파일 경로";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "\"*.m\"파일 경로";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ns_value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "일련 번호";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(1062, 19);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(119, 48);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "닫기";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // openFileDialog_filepath
            // 
            this.openFileDialog_filepath.FileName = "openFileDialog1";
            this.openFileDialog_filepath.Filter = "*.m 파일|*.m|txt파일|*.txt";
            // 
            // btnListAdd
            // 
            this.btnListAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListAdd.Location = new System.Drawing.Point(891, 155);
            this.btnListAdd.Name = "btnListAdd";
            this.btnListAdd.Size = new System.Drawing.Size(90, 40);
            this.btnListAdd.TabIndex = 4;
            this.btnListAdd.Text = "추가";
            this.btnListAdd.UseVisualStyleBackColor = true;
            this.btnListAdd.Click += new System.EventHandler(this.btnListAdd_Click);
            // 
            // BtnListMod
            // 
            this.BtnListMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListMod.Location = new System.Drawing.Point(987, 155);
            this.BtnListMod.Name = "BtnListMod";
            this.BtnListMod.Size = new System.Drawing.Size(90, 40);
            this.BtnListMod.TabIndex = 4;
            this.BtnListMod.Text = "수정";
            this.BtnListMod.UseVisualStyleBackColor = true;
            this.BtnListMod.Click += new System.EventHandler(this.BtnListMod_Click);
            // 
            // BtnListDel
            // 
            this.BtnListDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListDel.Location = new System.Drawing.Point(1083, 155);
            this.BtnListDel.Name = "BtnListDel";
            this.BtnListDel.Size = new System.Drawing.Size(90, 40);
            this.BtnListDel.TabIndex = 4;
            this.BtnListDel.Text = "삭제";
            this.BtnListDel.UseVisualStyleBackColor = true;
            this.BtnListDel.Click += new System.EventHandler(this.BtnListDel_Click);
            // 
            // openFileDialog_MatFilePath
            // 
            this.openFileDialog_MatFilePath.FileName = "openFileDialog1";
            this.openFileDialog_MatFilePath.Filter = "mat 파일|*.mat|txt파일|*.txt";
            // 
            // file_dataTableAdapter
            // 
            this.file_dataTableAdapter.ClearBeforeFill = true;
            // 
            // ChkisSameFileName
            // 
            this.ChkisSameFileName.AutoSize = true;
            this.ChkisSameFileName.Checked = true;
            this.ChkisSameFileName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkisSameFileName.Location = new System.Drawing.Point(648, 23);
            this.ChkisSameFileName.Name = "ChkisSameFileName";
            this.ChkisSameFileName.Size = new System.Drawing.Size(128, 16);
            this.ChkisSameFileName.TabIndex = 2;
            this.ChkisSameFileName.Text = "같은 경로와 파일명";
            this.ChkisSameFileName.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 676);
            this.Controls.Add(this.BtnListDel);
            this.Controls.Add(this.BtnListMod);
            this.Controls.Add(this.btnListAdd);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1065, 620);
            this.Name = "Form1";
            this.Text = "......일단 만들어 봄 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filedataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dataDataSetBindingSource;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource filedataBindingSource;
        private dataDataSetTableAdapters.file_dataTableAdapter file_dataTableAdapter;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMatFilePath;
        private System.Windows.Forms.TextBox txtMFilePath;
        private System.Windows.Forms.TextBox txtNsValue;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog_filepath;
        private System.Windows.Forms.Button btnSetMatFilePath;
        private System.Windows.Forms.Button btnListAdd;
        private System.Windows.Forms.Button BtnListMod;
        private System.Windows.Forms.Button BtnListDel;
        private System.Windows.Forms.OpenFileDialog openFileDialog_MatFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filepathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respathDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox ChkisSameFileName;
    }
}

