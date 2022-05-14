namespace GaohangSearch
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblchosen = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.labelsum = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnPatSelectAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlPat = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtcaseType = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPcBuy2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPcBuy1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPatCus = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdt_AppDate2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdt_AppDate1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPcPrice2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPcPrice1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatProType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcaseState = new System.Windows.Forms.TextBox();
            this.txts_CaseName = new System.Windows.Forms.TextBox();
            this.txts_AppNo = new System.Windows.Forms.TextBox();
            this.dgvPat = new System.Windows.Forms.DataGridView();
            this.patCkb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.s_CaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_AppNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_AppDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_CustomField1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_Inventors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_CustomField5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_CustomField6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_CustomField7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_CustomField8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_CustomField9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_CustomField10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPatMore = new System.Windows.Forms.Button();
            this.btnPatSearch = new System.Windows.Forms.Button();
            this.txtPatSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlPat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPat)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 18);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 563);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lblchosen);
            this.tabPage1.Controls.Add(this.btnOut);
            this.tabPage1.Controls.Add(this.labelsum);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.btnPatSelectAll);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.pnlPat);
            this.tabPage1.Controls.Add(this.dgvPat);
            this.tabPage1.Controls.Add(this.btnPatMore);
            this.tabPage1.Controls.Add(this.btnPatSearch);
            this.tabPage1.Controls.Add(this.txtPatSearch);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1342, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "专利查询";
            // 
            // lblchosen
            // 
            this.lblchosen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblchosen.AutoSize = true;
            this.lblchosen.Location = new System.Drawing.Point(252, 513);
            this.lblchosen.Name = "lblchosen";
            this.lblchosen.Size = new System.Drawing.Size(53, 12);
            this.lblchosen.TabIndex = 49;
            this.lblchosen.Text = "选中  条";
            // 
            // btnOut
            // 
            this.btnOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOut.Location = new System.Drawing.Point(154, 506);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 48;
            this.btnOut.Text = "导出数据";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // labelsum
            // 
            this.labelsum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelsum.AutoSize = true;
            this.labelsum.Location = new System.Drawing.Point(69, 513);
            this.labelsum.Name = "labelsum";
            this.labelsum.Size = new System.Drawing.Size(59, 12);
            this.labelsum.TabIndex = 45;
            this.labelsum.Text = "共  0  条";
            this.labelsum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(267, 34);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 16);
            this.checkBox3.TabIndex = 43;
            this.checkBox3.Text = "外观";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(217, 34);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 42;
            this.checkBox2.Text = "实用";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(165, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "发明";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // btnPatSelectAll
            // 
            this.btnPatSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPatSelectAll.Location = new System.Drawing.Point(13, 508);
            this.btnPatSelectAll.Name = "btnPatSelectAll";
            this.btnPatSelectAll.Size = new System.Drawing.Size(37, 23);
            this.btnPatSelectAll.TabIndex = 13;
            this.btnPatSelectAll.Text = "全选";
            this.btnPatSelectAll.UseVisualStyleBackColor = true;
            this.btnPatSelectAll.Click += new System.EventHandler(this.btnPatSelectAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1261, 508);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlPat
            // 
            this.pnlPat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPat.Controls.Add(this.comboBox2);
            this.pnlPat.Controls.Add(this.comboBox1);
            this.pnlPat.Controls.Add(this.txtcaseType);
            this.pnlPat.Controls.Add(this.label17);
            this.pnlPat.Controls.Add(this.txtPcBuy2);
            this.pnlPat.Controls.Add(this.label18);
            this.pnlPat.Controls.Add(this.txtPcBuy1);
            this.pnlPat.Controls.Add(this.label11);
            this.pnlPat.Controls.Add(this.label16);
            this.pnlPat.Controls.Add(this.txtPatCus);
            this.pnlPat.Controls.Add(this.label14);
            this.pnlPat.Controls.Add(this.label10);
            this.pnlPat.Controls.Add(this.label8);
            this.pnlPat.Controls.Add(this.txtdt_AppDate2);
            this.pnlPat.Controls.Add(this.label9);
            this.pnlPat.Controls.Add(this.txtdt_AppDate1);
            this.pnlPat.Controls.Add(this.label7);
            this.pnlPat.Controls.Add(this.txtPcPrice2);
            this.pnlPat.Controls.Add(this.label6);
            this.pnlPat.Controls.Add(this.txtPcPrice1);
            this.pnlPat.Controls.Add(this.label5);
            this.pnlPat.Controls.Add(this.txtPatProType);
            this.pnlPat.Controls.Add(this.label4);
            this.pnlPat.Controls.Add(this.label3);
            this.pnlPat.Controls.Add(this.label2);
            this.pnlPat.Controls.Add(this.label1);
            this.pnlPat.Controls.Add(this.txtcaseState);
            this.pnlPat.Controls.Add(this.txts_CaseName);
            this.pnlPat.Controls.Add(this.txts_AppNo);
            this.pnlPat.Location = new System.Drawing.Point(439, 3);
            this.pnlPat.Name = "pnlPat";
            this.pnlPat.Size = new System.Drawing.Size(903, 49);
            this.pnlPat.TabIndex = 3;
            this.pnlPat.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "已售",
            "未售"});
            this.comboBox2.Location = new System.Drawing.Point(107, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(55, 20);
            this.comboBox2.TabIndex = 45;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "收购",
            "自申请",
            "咨询案"});
            this.comboBox1.Location = new System.Drawing.Point(674, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 20);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtcaseType
            // 
            this.txtcaseType.Location = new System.Drawing.Point(406, 2);
            this.txtcaseType.Name = "txtcaseType";
            this.txtcaseType.ReadOnly = true;
            this.txtcaseType.Size = new System.Drawing.Size(60, 21);
            this.txtcaseType.TabIndex = 35;
            this.txtcaseType.TextChanged += new System.EventHandler(this.txtcaseType_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(274, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 32;
            this.label17.Text = "-";
            // 
            // txtPcBuy2
            // 
            this.txtPcBuy2.Location = new System.Drawing.Point(283, 30);
            this.txtPcBuy2.Name = "txtPcBuy2";
            this.txtPcBuy2.Size = new System.Drawing.Size(40, 21);
            this.txtPcBuy2.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(187, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 30;
            this.label18.Text = "买入价";
            // 
            // txtPcBuy1
            // 
            this.txtPcBuy1.Location = new System.Drawing.Point(234, 30);
            this.txtPcBuy1.Name = "txtPcBuy1";
            this.txtPcBuy1.Size = new System.Drawing.Size(40, 21);
            this.txtPcBuy1.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(615, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "专利来源";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(637, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 28;
            this.label16.Text = "联系人";
            // 
            // txtPatCus
            // 
            this.txtPatCus.Location = new System.Drawing.Point(684, 3);
            this.txtPatCus.Name = "txtPatCus";
            this.txtPatCus.Size = new System.Drawing.Size(74, 21);
            this.txtPatCus.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 23;
            this.label14.Text = "出售状态";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(592, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "年";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "-";
            // 
            // txtdt_AppDate2
            // 
            this.txtdt_AppDate2.Location = new System.Drawing.Point(552, 30);
            this.txtdt_AppDate2.Name = "txtdt_AppDate2";
            this.txtdt_AppDate2.Size = new System.Drawing.Size(40, 21);
            this.txtdt_AppDate2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "申请日";
            // 
            // txtdt_AppDate1
            // 
            this.txtdt_AppDate1.Location = new System.Drawing.Point(503, 30);
            this.txtdt_AppDate1.Name = "txtdt_AppDate1";
            this.txtdt_AppDate1.Size = new System.Drawing.Size(40, 21);
            this.txtdt_AppDate1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "-";
            // 
            // txtPcPrice2
            // 
            this.txtPcPrice2.Location = new System.Drawing.Point(413, 30);
            this.txtPcPrice2.Name = "txtPcPrice2";
            this.txtPcPrice2.Size = new System.Drawing.Size(40, 21);
            this.txtPcPrice2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "底价";
            // 
            // txtPcPrice1
            // 
            this.txtPcPrice1.Location = new System.Drawing.Point(364, 30);
            this.txtPcPrice1.Name = "txtPcPrice1";
            this.txtPcPrice1.Size = new System.Drawing.Size(40, 21);
            this.txtPcPrice1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(764, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "申请方式";
            // 
            // txtPatProType
            // 
            this.txtPatProType.Location = new System.Drawing.Point(821, 3);
            this.txtPatProType.Name = "txtPatProType";
            this.txtPatProType.Size = new System.Drawing.Size(71, 21);
            this.txtPatProType.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "法律状态";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "专利类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "专利名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "专利号";
            // 
            // txtcaseState
            // 
            this.txtcaseState.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcaseState.Location = new System.Drawing.Point(531, 3);
            this.txtcaseState.Name = "txtcaseState";
            this.txtcaseState.Size = new System.Drawing.Size(100, 21);
            this.txtcaseState.TabIndex = 0;
            // 
            // txts_CaseName
            // 
            this.txts_CaseName.Location = new System.Drawing.Point(215, 2);
            this.txts_CaseName.Name = "txts_CaseName";
            this.txts_CaseName.Size = new System.Drawing.Size(125, 21);
            this.txts_CaseName.TabIndex = 0;
            // 
            // txts_AppNo
            // 
            this.txts_AppNo.Location = new System.Drawing.Point(50, 3);
            this.txts_AppNo.Name = "txts_AppNo";
            this.txts_AppNo.Size = new System.Drawing.Size(112, 21);
            this.txts_AppNo.TabIndex = 0;
            // 
            // dgvPat
            // 
            this.dgvPat.AllowUserToAddRows = false;
            this.dgvPat.AllowUserToDeleteRows = false;
            this.dgvPat.AllowUserToOrderColumns = true;
            this.dgvPat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patCkb,
            this.s_CaseName,
            this.s_AppNo,
            this.caseType,
            this.dt_AppDate,
            this.s_CustomField1,
            this.caseFor,
            this.s_Inventors,
            this.s_CustomField5,
            this.s_CustomField6,
            this.s_CustomField7,
            this.s_CustomField8,
            this.s_CustomField9,
            this.s_CustomField10});
            this.dgvPat.Location = new System.Drawing.Point(9, 58);
            this.dgvPat.Name = "dgvPat";
            this.dgvPat.ReadOnly = true;
            this.dgvPat.RowTemplate.Height = 23;
            this.dgvPat.Size = new System.Drawing.Size(1326, 444);
            this.dgvPat.TabIndex = 2;
            this.dgvPat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPat_CellContentClick);
            this.dgvPat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPat_CellMouseClick);
            // 
            // patCkb
            // 
            this.patCkb.HeaderText = "选中";
            this.patCkb.Name = "patCkb";
            this.patCkb.ReadOnly = true;
            // 
            // s_CaseName
            // 
            this.s_CaseName.DataPropertyName = "s_CaseName";
            this.s_CaseName.HeaderText = "专利名";
            this.s_CaseName.Name = "s_CaseName";
            this.s_CaseName.ReadOnly = true;
            // 
            // s_AppNo
            // 
            this.s_AppNo.DataPropertyName = "s_AppNo";
            this.s_AppNo.HeaderText = "申请号";
            this.s_AppNo.Name = "s_AppNo";
            this.s_AppNo.ReadOnly = true;
            // 
            // caseType
            // 
            this.caseType.DataPropertyName = "caseType";
            this.caseType.HeaderText = "专利类型";
            this.caseType.Name = "caseType";
            this.caseType.ReadOnly = true;
            // 
            // dt_AppDate
            // 
            this.dt_AppDate.DataPropertyName = "dt_AppDate";
            this.dt_AppDate.HeaderText = "申请日";
            this.dt_AppDate.Name = "dt_AppDate";
            this.dt_AppDate.ReadOnly = true;
            // 
            // s_CustomField1
            // 
            this.s_CustomField1.DataPropertyName = "s_CustomField1";
            this.s_CustomField1.HeaderText = "法律状态";
            this.s_CustomField1.Name = "s_CustomField1";
            this.s_CustomField1.ReadOnly = true;
            // 
            // caseFor
            // 
            this.caseFor.DataPropertyName = "s_CustomField2";
            this.caseFor.HeaderText = "来源";
            this.caseFor.Name = "caseFor";
            this.caseFor.ReadOnly = true;
            // 
            // s_Inventors
            // 
            this.s_Inventors.DataPropertyName = "s_Inventors";
            this.s_Inventors.HeaderText = "出售状态";
            this.s_Inventors.Name = "s_Inventors";
            this.s_Inventors.ReadOnly = true;
            // 
            // s_CustomField5
            // 
            this.s_CustomField5.DataPropertyName = "s_CustomField5";
            this.s_CustomField5.HeaderText = "联系人1";
            this.s_CustomField5.Name = "s_CustomField5";
            this.s_CustomField5.ReadOnly = true;
            // 
            // s_CustomField6
            // 
            this.s_CustomField6.DataPropertyName = "s_CustomField6";
            this.s_CustomField6.HeaderText = "底价1";
            this.s_CustomField6.Name = "s_CustomField6";
            this.s_CustomField6.ReadOnly = true;
            // 
            // s_CustomField7
            // 
            this.s_CustomField7.DataPropertyName = "s_CustomField7";
            this.s_CustomField7.HeaderText = "买入价1";
            this.s_CustomField7.Name = "s_CustomField7";
            this.s_CustomField7.ReadOnly = true;
            // 
            // s_CustomField8
            // 
            this.s_CustomField8.DataPropertyName = "s_CustomField8";
            this.s_CustomField8.HeaderText = "联系人2";
            this.s_CustomField8.Name = "s_CustomField8";
            this.s_CustomField8.ReadOnly = true;
            // 
            // s_CustomField9
            // 
            this.s_CustomField9.DataPropertyName = "s_CustomField9";
            this.s_CustomField9.HeaderText = "底价2";
            this.s_CustomField9.Name = "s_CustomField9";
            this.s_CustomField9.ReadOnly = true;
            // 
            // s_CustomField10
            // 
            this.s_CustomField10.DataPropertyName = "s_CustomField10";
            this.s_CustomField10.HeaderText = "买入价2";
            this.s_CustomField10.Name = "s_CustomField10";
            this.s_CustomField10.ReadOnly = true;
            // 
            // btnPatMore
            // 
            this.btnPatMore.Location = new System.Drawing.Point(322, 31);
            this.btnPatMore.Name = "btnPatMore";
            this.btnPatMore.Size = new System.Drawing.Size(86, 23);
            this.btnPatMore.TabIndex = 1;
            this.btnPatMore.Text = "高级选项 >>";
            this.btnPatMore.UseVisualStyleBackColor = true;
            this.btnPatMore.Click += new System.EventHandler(this.btnPatMore_Click);
            // 
            // btnPatSearch
            // 
            this.btnPatSearch.Location = new System.Drawing.Point(332, 4);
            this.btnPatSearch.Name = "btnPatSearch";
            this.btnPatSearch.Size = new System.Drawing.Size(64, 23);
            this.btnPatSearch.TabIndex = 1;
            this.btnPatSearch.Text = "搜　索";
            this.btnPatSearch.UseVisualStyleBackColor = true;
            this.btnPatSearch.Click += new System.EventHandler(this.btnPatSearch_Click);
            // 
            // txtPatSearch
            // 
            this.txtPatSearch.Location = new System.Drawing.Point(9, 30);
            this.txtPatSearch.Name = "txtPatSearch";
            this.txtPatSearch.Size = new System.Drawing.Size(143, 21);
            this.txtPatSearch.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.数据ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1336, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 数据ToolStripMenuItem
            // 
            this.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem";
            this.数据ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.数据ToolStripMenuItem.Text = "数据";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel表格|*.xls|文本文档|*.txt|所有文件|*.*";
            this.saveFileDialog1.Title = "导出";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 562);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FormMain";
            this.Text = "高航神器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlPat.ResumeLayout(false);
            this.pnlPat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPat)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtPatSearch;
        private System.Windows.Forms.Panel pnlPat;
        private System.Windows.Forms.DataGridView dgvPat;
        private System.Windows.Forms.Button btnPatSearch;
        private System.Windows.Forms.Button btnPatMore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txts_CaseName;
        private System.Windows.Forms.TextBox txts_AppNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatProType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdt_AppDate2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdt_AppDate1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPcPrice2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPcPrice1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPatCus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPcBuy2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPcBuy1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据ToolStripMenuItem;
        private System.Windows.Forms.Button btnPatSelectAll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtcaseState;
        private System.Windows.Forms.TextBox txtcaseType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.Label labelsum;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblchosen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn patCkb;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_CaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_AppNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_AppDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_CustomField1;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_Inventors;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_CustomField5;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_CustomField6;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_CustomField7;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_CustomField8;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_CustomField9;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_CustomField10;

    }
}