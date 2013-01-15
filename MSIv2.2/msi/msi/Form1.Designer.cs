namespace msi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButton_con = new System.Windows.Forms.RadioButton();
            this.radioButton_download = new System.Windows.Forms.RadioButton();
            this.radioButton_label = new System.Windows.Forms.RadioButton();
            this.radioButton_real = new System.Windows.Forms.RadioButton();
            this.button_ok = new System.Windows.Forms.Button();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn_id = new System.Data.DataColumn();
            this.dataColumn_appcode = new System.Data.DataColumn();
            this.dataColumn_storecode = new System.Data.DataColumn();
            this.dataColumn_ean = new System.Data.DataColumn();
            this.dataColumn_price = new System.Data.DataColumn();
            this.dataColumn_quantity = new System.Data.DataColumn();
            this.dataColumn_takeover = new System.Data.DataColumn();
            this.panel_applications = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.radioButton_MSI = new System.Windows.Forms.RadioButton();
            this.radioButton_takeover = new System.Windows.Forms.RadioButton();
            this.panel_con = new System.Windows.Forms.Panel();
            this.bindingSource_con = new System.Windows.Forms.BindingSource(this.components);
            this.label_con_storecode = new System.Windows.Forms.Label();
            this.label_con_ean = new System.Windows.Forms.Label();
            this.textBox_con_ean = new System.Windows.Forms.TextBox();
            this.label_con_price = new System.Windows.Forms.Label();
            this.textBox_con_price = new System.Windows.Forms.TextBox();
            this.label_con_store = new System.Windows.Forms.Label();
            this.dataGrid_con = new System.Windows.Forms.DataGrid();
            this.comboBox_con_store = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_takeover = new System.Windows.Forms.Panel();
            this.bindingSource_takeover = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid_takeover = new System.Windows.Forms.DataGrid();
            this.label_takeover_ean = new System.Windows.Forms.Label();
            this.textBox_takeover_ean = new System.Windows.Forms.TextBox();
            this.label_takeover_quantity = new System.Windows.Forms.Label();
            this.textBox_takeover_quantity = new System.Windows.Forms.TextBox();
            this.label_takeover_takeovernum = new System.Windows.Forms.Label();
            this.textBox_takeover_takeovernum = new System.Windows.Forms.TextBox();
            this.label_input_takeovernumber = new System.Windows.Forms.Label();
            this.panel_label = new System.Windows.Forms.Panel();
            this.bindingSource_label = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid_label = new System.Windows.Forms.DataGrid();
            this.label_label_ean = new System.Windows.Forms.Label();
            this.textBox_label_ean = new System.Windows.Forms.TextBox();
            this.label_label_price = new System.Windows.Forms.Label();
            this.textBox_label_price = new System.Windows.Forms.TextBox();
            this.imageList_buttons = new System.Windows.Forms.ImageList();
            this.dataColumn_con_store = new System.Data.DataColumn();
            this.dataColumn_con_ean = new System.Data.DataColumn();
            this.dataColumn_con_price = new System.Data.DataColumn();
            this.dataTable_real = new System.Data.DataTable();
            this.dataColumn_real_ean = new System.Data.DataColumn();
            this.dataColumn_real_quantity = new System.Data.DataColumn();
            this.panel_navigator = new System.Windows.Forms.Panel();
            this.pictureBox_last = new System.Windows.Forms.PictureBox();
            this.pictureBox_first = new System.Windows.Forms.PictureBox();
            this.pictureBox_prev = new System.Windows.Forms.PictureBox();
            this.label_count = new System.Windows.Forms.Label();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            this.pictureBox_add = new System.Windows.Forms.PictureBox();
            this.pictureBox_delete = new System.Windows.Forms.PictureBox();
            this.pictureBox_next = new System.Windows.Forms.PictureBox();
            this.pictureBox_nav_background = new System.Windows.Forms.PictureBox();
            this.panel_real = new System.Windows.Forms.Panel();
            this.bindingSource_real = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid_real = new System.Windows.Forms.DataGrid();
            this.label_real_dev = new System.Windows.Forms.Label();
            this.comboBox_real_dev = new System.Windows.Forms.ComboBox();
            this.label_real_ean = new System.Windows.Forms.Label();
            this.textBox_real_ean = new System.Windows.Forms.TextBox();
            this.label_real_quantity = new System.Windows.Forms.Label();
            this.textBox_real_quantity = new System.Windows.Forms.TextBox();
            this.label_real_quntity_binding = new System.Windows.Forms.Label();
            this.imageList_statusbar = new System.Windows.Forms.ImageList();
            this.panel_statusline = new System.Windows.Forms.Panel();
            this.label_time = new System.Windows.Forms.Label();
            this.pictureBox_time = new System.Windows.Forms.PictureBox();
            this.pictureBox_shift = new System.Windows.Forms.PictureBox();
            this.pictureBox_alpha = new System.Windows.Forms.PictureBox();
            this.panel_status = new System.Windows.Forms.Panel();
            this.label_statusbar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
            this.panel_export = new System.Windows.Forms.Panel();
            this.radioButton_export_delete = new System.Windows.Forms.RadioButton();
            this.radioButton_export_export = new System.Windows.Forms.RadioButton();
            this.button_export_cancel = new System.Windows.Forms.Button();
            this.button_export_ok = new System.Windows.Forms.Button();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle4 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle5 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle6 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn16 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn17 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle7 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn18 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn19 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle8 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn20 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn21 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn22 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle9 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn23 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn24 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn25 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle10 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn26 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn27 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn28 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle11 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn29 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn30 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle12 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn31 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn32 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn33 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle13 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn34 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn35 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn36 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle14 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn37 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn38 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn39 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle15 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn40 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn41 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle16 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn42 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn43 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn44 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.panel_MSI = new System.Windows.Forms.Panel();
            this.bindingSource_MSI = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid_MSI = new System.Windows.Forms.DataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MSI_cod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MSI_cantitate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridTableStyle17 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn45 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn46 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn47 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle18 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn48 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn49 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn50 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle19 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn51 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn52 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle20 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn53 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn54 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn55 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle21 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTableStyle22 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn56 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn57 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn58 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle23 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn59 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn60 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn61 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle24 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn62 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn63 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle25 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn64 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn65 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn66 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle26 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTableStyle27 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn67 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn68 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn69 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle28 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn70 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn71 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn72 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle29 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn73 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn74 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle30 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn75 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn76 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn77 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle31 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTableStyle32 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn78 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn79 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn80 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle33 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn81 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn82 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn83 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle34 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn84 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn85 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle35 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn86 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn87 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn88 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle36 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTableStyle37 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn89 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn90 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn91 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle38 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn92 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn93 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn94 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle39 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn95 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn96 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle40 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn97 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn98 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn99 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle41 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTableStyle42 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn100 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn101 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn102 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle43 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn103 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn104 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn105 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle44 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn106 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn107 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle45 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn108 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn109 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn110 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle46 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTableStyle47 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn111 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn112 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn113 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle48 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn114 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn115 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn116 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle49 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn117 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn118 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle50 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn119 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn120 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn121 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle51 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn122 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn123 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle52 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn124 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn125 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn126 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle53 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn127 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn128 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn129 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle54 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn130 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn131 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle55 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn132 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn133 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn134 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle56 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn135 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn136 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataSet1 = new msi.DataSet1();
            this.dataGridTableStyle57 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn137 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn138 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn139 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle_con = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn_con1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn_con2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn_con3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle58 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn140 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn141 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn142 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle_real = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn_real1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn_real2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn_real3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle59 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn143 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn144 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle_label = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn_label1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn_label2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle60 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn145 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn146 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn147 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle_takeover = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn_take1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn_take2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn_take3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle61 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn148 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn149 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle_MSI = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn_MSI1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn_MSI2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.panel_applications.SuspendLayout();
            this.panel_con.SuspendLayout();
            this.panel_takeover.SuspendLayout();
            this.panel_label.SuspendLayout();
            this.panel_navigator.SuspendLayout();
            this.panel_real.SuspendLayout();
            this.panel_statusline.SuspendLayout();
            this.panel_status.SuspendLayout();
            this.panel_export.SuspendLayout();
            this.panel_MSI.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_con
            // 
            resources.ApplyResources(this.radioButton_con, "radioButton_con");
            this.radioButton_con.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton_con.Name = "radioButton_con";
            this.radioButton_con.TabStop = false;
            this.radioButton_con.Click += new System.EventHandler(this.radioButton_Click);
            this.radioButton_con.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.radioButton_con.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.radioButton_con.CheckedChanged += new System.EventHandler(this.radioButton_Checked_Changed);
            this.radioButton_con.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            // 
            // radioButton_download
            // 
            resources.ApplyResources(this.radioButton_download, "radioButton_download");
            this.radioButton_download.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton_download.Name = "radioButton_download";
            this.radioButton_download.TabStop = false;
            this.radioButton_download.Click += new System.EventHandler(this.radioButton_Click);
            this.radioButton_download.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.radioButton_download.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.radioButton_download.CheckedChanged += new System.EventHandler(this.radioButton_Checked_Changed);
            this.radioButton_download.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            // 
            // radioButton_label
            // 
            resources.ApplyResources(this.radioButton_label, "radioButton_label");
            this.radioButton_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton_label.Name = "radioButton_label";
            this.radioButton_label.TabStop = false;
            this.radioButton_label.Click += new System.EventHandler(this.radioButton_Click);
            this.radioButton_label.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.radioButton_label.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.radioButton_label.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.radioButton_label.CheckedChanged += new System.EventHandler(this.radioButton_Checked_Changed);
            this.radioButton_label.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            // 
            // radioButton_real
            // 
            resources.ApplyResources(this.radioButton_real, "radioButton_real");
            this.radioButton_real.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton_real.Name = "radioButton_real";
            this.radioButton_real.TabStop = false;
            this.radioButton_real.Click += new System.EventHandler(this.radioButton_Click);
            this.radioButton_real.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.radioButton_real.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.radioButton_real.CheckedChanged += new System.EventHandler(this.radioButton_Checked_Changed);
            this.radioButton_real.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.button_ok, "button_ok");
            this.button_ok.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_ok.Name = "button_ok";
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            this.button_ok.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.button_ok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.button_ok.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_id,
            this.dataColumn_appcode,
            this.dataColumn_storecode,
            this.dataColumn_ean,
            this.dataColumn_price,
            this.dataColumn_quantity,
            this.dataColumn_takeover});
            this.dataTable1.DisplayExpression = "";
            this.dataTable1.Prefix = "";
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn_id
            // 
            this.dataColumn_id.AllowDBNull = false;
            this.dataColumn_id.AutoIncrement = true;
            this.dataColumn_id.ColumnMapping = System.Data.MappingType.Element;
            this.dataColumn_id.ColumnName = "id";
            this.dataColumn_id.DataType = typeof(int);
            this.dataColumn_id.DateTimeMode = System.Data.DataSetDateTime.UnspecifiedLocal;
            this.dataColumn_id.Expression = "";
            this.dataColumn_id.Prefix = "";
            // 
            // dataColumn_appcode
            // 
            this.dataColumn_appcode.AllowDBNull = false;
            this.dataColumn_appcode.ColumnMapping = System.Data.MappingType.Element;
            this.dataColumn_appcode.ColumnName = "appcode";
            this.dataColumn_appcode.DataType = typeof(int);
            this.dataColumn_appcode.DateTimeMode = System.Data.DataSetDateTime.UnspecifiedLocal;
            this.dataColumn_appcode.Expression = "";
            this.dataColumn_appcode.Prefix = "";
            // 
            // dataColumn_storecode
            // 
            this.dataColumn_storecode.ColumnMapping = System.Data.MappingType.Element;
            this.dataColumn_storecode.ColumnName = "storecode";
            this.dataColumn_storecode.DataType = typeof(int);
            this.dataColumn_storecode.DateTimeMode = System.Data.DataSetDateTime.UnspecifiedLocal;
            this.dataColumn_storecode.Expression = "";
            this.dataColumn_storecode.Prefix = "";
            // 
            // dataColumn_ean
            // 
            this.dataColumn_ean.AllowDBNull = false;
            this.dataColumn_ean.ColumnMapping = System.Data.MappingType.Element;
            this.dataColumn_ean.ColumnName = "ean";
            this.dataColumn_ean.DataType = typeof(double);
            this.dataColumn_ean.DateTimeMode = System.Data.DataSetDateTime.UnspecifiedLocal;
            this.dataColumn_ean.Expression = "";
            this.dataColumn_ean.Prefix = "";
            // 
            // dataColumn_price
            // 
            this.dataColumn_price.ColumnMapping = System.Data.MappingType.Element;
            this.dataColumn_price.ColumnName = "price";
            this.dataColumn_price.DataType = typeof(double);
            this.dataColumn_price.DateTimeMode = System.Data.DataSetDateTime.UnspecifiedLocal;
            this.dataColumn_price.Expression = "";
            this.dataColumn_price.Prefix = "";
            // 
            // dataColumn_quantity
            // 
            this.dataColumn_quantity.ColumnMapping = System.Data.MappingType.Element;
            this.dataColumn_quantity.ColumnName = "quantity";
            this.dataColumn_quantity.DataType = typeof(double);
            this.dataColumn_quantity.DateTimeMode = System.Data.DataSetDateTime.UnspecifiedLocal;
            this.dataColumn_quantity.Expression = "";
            this.dataColumn_quantity.Prefix = "";
            // 
            // dataColumn_takeover
            // 
            this.dataColumn_takeover.ColumnMapping = System.Data.MappingType.Element;
            this.dataColumn_takeover.ColumnName = "takeover";
            this.dataColumn_takeover.DataType = typeof(int);
            this.dataColumn_takeover.DateTimeMode = System.Data.DataSetDateTime.UnspecifiedLocal;
            this.dataColumn_takeover.Expression = "";
            this.dataColumn_takeover.Prefix = "";
            // 
            // panel_applications
            // 
            this.panel_applications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panel_applications.Controls.Add(this.button_close);
            this.panel_applications.Controls.Add(this.radioButton_MSI);
            this.panel_applications.Controls.Add(this.button_ok);
            this.panel_applications.Controls.Add(this.radioButton_download);
            this.panel_applications.Controls.Add(this.radioButton_takeover);
            this.panel_applications.Controls.Add(this.radioButton_label);
            this.panel_applications.Controls.Add(this.radioButton_real);
            this.panel_applications.Controls.Add(this.radioButton_con);
            resources.ApplyResources(this.panel_applications, "panel_applications");
            this.panel_applications.Name = "panel_applications";
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_close.Name = "button_close";
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // radioButton_MSI
            // 
            resources.ApplyResources(this.radioButton_MSI, "radioButton_MSI");
            this.radioButton_MSI.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton_MSI.Name = "radioButton_MSI";
            this.radioButton_MSI.TabStop = false;
            // 
            // radioButton_takeover
            // 
            resources.ApplyResources(this.radioButton_takeover, "radioButton_takeover");
            this.radioButton_takeover.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton_takeover.Name = "radioButton_takeover";
            this.radioButton_takeover.TabStop = false;
            this.radioButton_takeover.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.radioButton_takeover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.radioButton_takeover.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            // 
            // panel_con
            // 
            this.panel_con.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panel_con.Controls.Add(this.label_con_storecode);
            this.panel_con.Controls.Add(this.label_con_ean);
            this.panel_con.Controls.Add(this.textBox_con_ean);
            this.panel_con.Controls.Add(this.label_con_price);
            this.panel_con.Controls.Add(this.textBox_con_price);
            this.panel_con.Controls.Add(this.label_con_store);
            this.panel_con.Controls.Add(this.dataGrid_con);
            this.panel_con.Controls.Add(this.comboBox_con_store);
            resources.ApplyResources(this.panel_con, "panel_con");
            this.panel_con.Name = "panel_con";
            // 
            // bindingSource_con
            // 
            this.bindingSource_con.AllowNew = true;
            this.bindingSource_con.DataMember = "DataTable_con";
            this.bindingSource_con.DataSource = this.dataSet1;
            this.bindingSource_con.CurrentChanged += new System.EventHandler(this.bindingSource_CurrentChanged);
            // 
            // label_con_storecode
            // 
            this.label_con_storecode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_con, "storecode", true));
            resources.ApplyResources(this.label_con_storecode, "label_con_storecode");
            this.label_con_storecode.Name = "label_con_storecode";
            // 
            // label_con_ean
            // 
            resources.ApplyResources(this.label_con_ean, "label_con_ean");
            this.label_con_ean.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_con_ean.Name = "label_con_ean";
            // 
            // textBox_con_ean
            // 
            this.textBox_con_ean.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_con, "ean", true));
            resources.ApplyResources(this.textBox_con_ean, "textBox_con_ean");
            this.textBox_con_ean.Name = "textBox_con_ean";
            this.textBox_con_ean.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.textBox_con_ean.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.textBox_con_ean.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.textBox_con_ean.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label_con_price
            // 
            resources.ApplyResources(this.label_con_price, "label_con_price");
            this.label_con_price.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_con_price.Name = "label_con_price";
            // 
            // textBox_con_price
            // 
            this.textBox_con_price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_con, "price", true));
            resources.ApplyResources(this.textBox_con_price, "textBox_con_price");
            this.textBox_con_price.Name = "textBox_con_price";
            this.textBox_con_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.textBox_con_price.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.textBox_con_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.textBox_con_price.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label_con_store
            // 
            resources.ApplyResources(this.label_con_store, "label_con_store");
            this.label_con_store.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_con_store.Name = "label_con_store";
            // 
            // dataGrid_con
            // 
            this.dataGrid_con.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid_con.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.dataGrid_con.DataSource = this.bindingSource_con;
            resources.ApplyResources(this.dataGrid_con, "dataGrid_con");
            this.dataGrid_con.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_con.GridLineColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_con.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.dataGrid_con.HeaderForeColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_con.Name = "dataGrid_con";
            this.dataGrid_con.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.dataGrid_con.TableStyles.Add(this.dataGridTableStyle_con);
            this.dataGrid_con.TabStop = false;
            this.dataGrid_con.Tag = "";
            this.dataGrid_con.DoubleClick += new System.EventHandler(this.dataGrid_DoubleClick);
            this.dataGrid_con.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.dataGrid_con.GotFocus += new System.EventHandler(this.dataGrid_GotFocus);
            // 
            // comboBox_con_store
            // 
            this.comboBox_con_store.DisplayMember = "0";
            this.comboBox_con_store.Items.Add(resources.GetString("comboBox_con_store.Items"));
            this.comboBox_con_store.Items.Add(resources.GetString("comboBox_con_store.Items1"));
            this.comboBox_con_store.Items.Add(resources.GetString("comboBox_con_store.Items2"));
            this.comboBox_con_store.Items.Add(resources.GetString("comboBox_con_store.Items3"));
            this.comboBox_con_store.Items.Add(resources.GetString("comboBox_con_store.Items4"));
            this.comboBox_con_store.Items.Add(resources.GetString("comboBox_con_store.Items5"));
            this.comboBox_con_store.Items.Add(resources.GetString("comboBox_con_store.Items6"));
            this.comboBox_con_store.Items.Add(resources.GetString("comboBox_con_store.Items7"));
            this.comboBox_con_store.Items.Add(resources.GetString("comboBox_con_store.Items8"));
            this.comboBox_con_store.Items.Add(resources.GetString("comboBox_con_store.Items9"));
            resources.ApplyResources(this.comboBox_con_store, "comboBox_con_store");
            this.comboBox_con_store.Name = "comboBox_con_store";
            this.comboBox_con_store.ValueMember = "0";
            this.comboBox_con_store.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBox_con_store.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.comboBox_con_store.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.comboBox_con_store.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            // 
            // panel_takeover
            // 
            this.panel_takeover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panel_takeover.Controls.Add(this.dataGrid_takeover);
            this.panel_takeover.Controls.Add(this.label_takeover_ean);
            this.panel_takeover.Controls.Add(this.textBox_takeover_ean);
            this.panel_takeover.Controls.Add(this.label_takeover_quantity);
            this.panel_takeover.Controls.Add(this.textBox_takeover_quantity);
            this.panel_takeover.Controls.Add(this.label_takeover_takeovernum);
            this.panel_takeover.Controls.Add(this.textBox_takeover_takeovernum);
            this.panel_takeover.Controls.Add(this.label_input_takeovernumber);
            resources.ApplyResources(this.panel_takeover, "panel_takeover");
            this.panel_takeover.Name = "panel_takeover";
            // 
            // bindingSource_takeover
            // 
            this.bindingSource_takeover.DataMember = "DataTable_takeover";
            this.bindingSource_takeover.DataSource = this.dataSet1;
            // 
            // dataGrid_takeover
            // 
            this.dataGrid_takeover.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dataGrid_takeover.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.dataGrid_takeover.DataSource = this.bindingSource_takeover;
            resources.ApplyResources(this.dataGrid_takeover, "dataGrid_takeover");
            this.dataGrid_takeover.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_takeover.GridLineColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_takeover.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.dataGrid_takeover.HeaderForeColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_takeover.Name = "dataGrid_takeover";
            this.dataGrid_takeover.TableStyles.Add(this.dataGridTableStyle_takeover);
            this.dataGrid_takeover.TabStop = false;
            this.dataGrid_takeover.DoubleClick += new System.EventHandler(this.dataGrid_DoubleClick);
            this.dataGrid_takeover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.dataGrid_takeover.GotFocus += new System.EventHandler(this.dataGrid_GotFocus);
            this.dataGrid_takeover.Click += new System.EventHandler(this.dataGrid_takeover_Click);
            // 
            // label_takeover_ean
            // 
            resources.ApplyResources(this.label_takeover_ean, "label_takeover_ean");
            this.label_takeover_ean.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_takeover_ean.Name = "label_takeover_ean";
            // 
            // textBox_takeover_ean
            // 
            this.textBox_takeover_ean.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_takeover, "ean", true));
            resources.ApplyResources(this.textBox_takeover_ean, "textBox_takeover_ean");
            this.textBox_takeover_ean.Name = "textBox_takeover_ean";
            this.textBox_takeover_ean.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.textBox_takeover_ean.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.textBox_takeover_ean.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.textBox_takeover_ean.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label_takeover_quantity
            // 
            resources.ApplyResources(this.label_takeover_quantity, "label_takeover_quantity");
            this.label_takeover_quantity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_takeover_quantity.Name = "label_takeover_quantity";
            // 
            // textBox_takeover_quantity
            // 
            this.textBox_takeover_quantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_takeover, "quantity", true));
            resources.ApplyResources(this.textBox_takeover_quantity, "textBox_takeover_quantity");
            this.textBox_takeover_quantity.Name = "textBox_takeover_quantity";
            this.textBox_takeover_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.textBox_takeover_quantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.textBox_takeover_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.textBox_takeover_quantity.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label_takeover_takeovernum
            // 
            resources.ApplyResources(this.label_takeover_takeovernum, "label_takeover_takeovernum");
            this.label_takeover_takeovernum.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_takeover_takeovernum.Name = "label_takeover_takeovernum";
            // 
            // textBox_takeover_takeovernum
            // 
            resources.ApplyResources(this.textBox_takeover_takeovernum, "textBox_takeover_takeovernum");
            this.textBox_takeover_takeovernum.Name = "textBox_takeover_takeovernum";
            this.textBox_takeover_takeovernum.TextChanged += new System.EventHandler(this.textBox_takeover_takeovernum_TextChanged);
            this.textBox_takeover_takeovernum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.textBox_takeover_takeovernum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.textBox_takeover_takeovernum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.textBox_takeover_takeovernum.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label_input_takeovernumber
            // 
            this.label_input_takeovernumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_takeover, "takeovernum", true));
            resources.ApplyResources(this.label_input_takeovernumber, "label_input_takeovernumber");
            this.label_input_takeovernumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_input_takeovernumber.Name = "label_input_takeovernumber";
            // 
            // panel_label
            // 
            this.panel_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panel_label.Controls.Add(this.dataGrid_label);
            this.panel_label.Controls.Add(this.label_label_ean);
            this.panel_label.Controls.Add(this.textBox_label_ean);
            this.panel_label.Controls.Add(this.label_label_price);
            this.panel_label.Controls.Add(this.textBox_label_price);
            resources.ApplyResources(this.panel_label, "panel_label");
            this.panel_label.Name = "panel_label";
            // 
            // bindingSource_label
            // 
            this.bindingSource_label.DataMember = "DataTable_label";
            this.bindingSource_label.DataSource = this.dataSet1;
            // 
            // dataGrid_label
            // 
            this.dataGrid_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid_label.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.dataGrid_label.DataSource = this.bindingSource_label;
            resources.ApplyResources(this.dataGrid_label, "dataGrid_label");
            this.dataGrid_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_label.GridLineColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_label.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.dataGrid_label.HeaderForeColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_label.Name = "dataGrid_label";
            this.dataGrid_label.TableStyles.Add(this.dataGridTableStyle_label);
            this.dataGrid_label.TabStop = false;
            this.dataGrid_label.DoubleClick += new System.EventHandler(this.dataGrid_DoubleClick);
            this.dataGrid_label.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.dataGrid_label.GotFocus += new System.EventHandler(this.dataGrid_GotFocus);
            // 
            // label_label_ean
            // 
            resources.ApplyResources(this.label_label_ean, "label_label_ean");
            this.label_label_ean.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_label_ean.Name = "label_label_ean";
            // 
            // textBox_label_ean
            // 
            this.textBox_label_ean.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_label, "ean", true));
            resources.ApplyResources(this.textBox_label_ean, "textBox_label_ean");
            this.textBox_label_ean.Name = "textBox_label_ean";
            this.textBox_label_ean.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.textBox_label_ean.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.textBox_label_ean.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.textBox_label_ean.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label_label_price
            // 
            resources.ApplyResources(this.label_label_price, "label_label_price");
            this.label_label_price.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_label_price.Name = "label_label_price";
            // 
            // textBox_label_price
            // 
            this.textBox_label_price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_label, "price", true));
            resources.ApplyResources(this.textBox_label_price, "textBox_label_price");
            this.textBox_label_price.Name = "textBox_label_price";
            this.textBox_label_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.textBox_label_price.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.textBox_label_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.textBox_label_price.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // imageList_buttons
            // 
            resources.ApplyResources(this.imageList_buttons, "imageList_buttons");
            this.imageList_buttons.Images.Clear();
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource3"))));
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource4"))));
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource5"))));
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource6"))));
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource7"))));
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource8"))));
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource9"))));
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource10"))));
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource11"))));
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource12"))));
            this.imageList_buttons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource13"))));
            // 
            // dataColumn_con_store
            // 
            this.dataColumn_con_store.AllowDBNull = false;
            this.dataColumn_con_store.ColumnMapping = System.Data.MappingType.Element;
            this.dataColumn_con_store.ColumnName = "con_storecode";
            this.dataColumn_con_store.DataType = typeof(int);
            this.dataColumn_con_store.DateTimeMode = System.Data.DataSetDateTime.UnspecifiedLocal;
            this.dataColumn_con_store.Expression = "";
            this.dataColumn_con_store.Prefix = "";
            // 
            // dataColumn_con_ean
            // 
            this.dataColumn_con_ean.AllowDBNull = false;
            this.dataColumn_con_ean.ColumnMapping = System.Data.MappingType.Element;
            this.dataColumn_con_ean.ColumnName = "con_ean";
            this.dataColumn_con_ean.DataType = typeof(double);
            this.dataColumn_con_ean.DateTimeMode = System.Data.DataSetDateTime.UnspecifiedLocal;
            this.dataColumn_con_ean.Expression = "";
            this.dataColumn_con_ean.Prefix = "";
            // 
            // dataColumn_con_price
            // 
            this.dataColumn_con_price.AllowDBNull = false;
            this.dataColumn_con_price.ColumnMapping = System.Data.MappingType.Element;
            this.dataColumn_con_price.ColumnName = "con_price";
            this.dataColumn_con_price.DataType = typeof(double);
            this.dataColumn_con_price.DateTimeMode = System.Data.DataSetDateTime.UnspecifiedLocal;
            this.dataColumn_con_price.Expression = "";
            this.dataColumn_con_price.Prefix = "";
            // 
            // dataTable_real
            // 
            this.dataTable_real.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_real_ean,
            this.dataColumn_real_quantity});
            this.dataTable_real.DisplayExpression = "";
            this.dataTable_real.Prefix = "";
            this.dataTable_real.TableName = "Table_real";
            // 
            // dataColumn_real_ean
            // 
            this.dataColumn_real_ean.AllowDBNull = false;
            this.dataColumn_real_ean.ColumnMapping = System.Data.MappingType.Element;
            this.dataColumn_real_ean.ColumnName = "real_ean";
            this.dataColumn_real_ean.DataType = typeof(double);
            this.dataColumn_real_ean.DateTimeMode = System.Data.DataSetDateTime.UnspecifiedLocal;
            this.dataColumn_real_ean.Expression = "";
            this.dataColumn_real_ean.Prefix = "";
            // 
            // dataColumn_real_quantity
            // 
            this.dataColumn_real_quantity.AllowDBNull = false;
            this.dataColumn_real_quantity.ColumnMapping = System.Data.MappingType.Element;
            this.dataColumn_real_quantity.ColumnName = "real_quantity";
            this.dataColumn_real_quantity.DataType = typeof(double);
            this.dataColumn_real_quantity.DateTimeMode = System.Data.DataSetDateTime.UnspecifiedLocal;
            this.dataColumn_real_quantity.Expression = "";
            this.dataColumn_real_quantity.Prefix = "";
            // 
            // panel_navigator
            // 
            this.panel_navigator.Controls.Add(this.pictureBox_last);
            this.panel_navigator.Controls.Add(this.pictureBox_first);
            this.panel_navigator.Controls.Add(this.pictureBox_prev);
            this.panel_navigator.Controls.Add(this.label_count);
            this.panel_navigator.Controls.Add(this.pictureBox_back);
            this.panel_navigator.Controls.Add(this.pictureBox_add);
            this.panel_navigator.Controls.Add(this.pictureBox_delete);
            this.panel_navigator.Controls.Add(this.pictureBox_next);
            this.panel_navigator.Controls.Add(this.pictureBox_nav_background);
            resources.ApplyResources(this.panel_navigator, "panel_navigator");
            this.panel_navigator.Name = "panel_navigator";
            // 
            // pictureBox_last
            // 
            this.pictureBox_last.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.pictureBox_last, "pictureBox_last");
            this.pictureBox_last.Name = "pictureBox_last";
            this.pictureBox_last.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox_first
            // 
            resources.ApplyResources(this.pictureBox_first, "pictureBox_first");
            this.pictureBox_first.Name = "pictureBox_first";
            this.pictureBox_first.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox_prev
            // 
            this.pictureBox_prev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.pictureBox_prev, "pictureBox_prev");
            this.pictureBox_prev.Name = "pictureBox_prev";
            this.pictureBox_prev.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label_count
            // 
            resources.ApplyResources(this.label_count, "label_count");
            this.label_count.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_count.Name = "label_count";
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.pictureBox_back, "pictureBox_back");
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Click += new System.EventHandler(this.pictureBox_back_Click);
            // 
            // pictureBox_add
            // 
            this.pictureBox_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.pictureBox_add, "pictureBox_add");
            this.pictureBox_add.Name = "pictureBox_add";
            this.pictureBox_add.Click += new System.EventHandler(this.pictureBox_add_Click);
            // 
            // pictureBox_delete
            // 
            this.pictureBox_delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.pictureBox_delete, "pictureBox_delete");
            this.pictureBox_delete.Name = "pictureBox_delete";
            this.pictureBox_delete.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox_next
            // 
            this.pictureBox_next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.pictureBox_next, "pictureBox_next");
            this.pictureBox_next.Name = "pictureBox_next";
            this.pictureBox_next.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox_nav_background
            // 
            resources.ApplyResources(this.pictureBox_nav_background, "pictureBox_nav_background");
            this.pictureBox_nav_background.Name = "pictureBox_nav_background";
            // 
            // panel_real
            // 
            this.panel_real.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panel_real.Controls.Add(this.dataGrid_real);
            this.panel_real.Controls.Add(this.label_real_dev);
            this.panel_real.Controls.Add(this.comboBox_real_dev);
            this.panel_real.Controls.Add(this.label_real_ean);
            this.panel_real.Controls.Add(this.textBox_real_ean);
            this.panel_real.Controls.Add(this.label_real_quantity);
            this.panel_real.Controls.Add(this.textBox_real_quantity);
            this.panel_real.Controls.Add(this.label_real_quntity_binding);
            resources.ApplyResources(this.panel_real, "panel_real");
            this.panel_real.Name = "panel_real";
            // 
            // bindingSource_real
            // 
            this.bindingSource_real.DataMember = "DataTable_real";
            this.bindingSource_real.DataSource = this.dataSet1;
            this.bindingSource_real.CurrentChanged += new System.EventHandler(this.bindingSource_CurrentChanged);
            // 
            // dataGrid_real
            // 
            this.dataGrid_real.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid_real.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.dataGrid_real.DataSource = this.bindingSource_real;
            resources.ApplyResources(this.dataGrid_real, "dataGrid_real");
            this.dataGrid_real.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_real.GridLineColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_real.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.dataGrid_real.HeaderForeColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_real.Name = "dataGrid_real";
            this.dataGrid_real.TableStyles.Add(this.dataGridTableStyle_real);
            this.dataGrid_real.TabStop = false;
            this.dataGrid_real.DoubleClick += new System.EventHandler(this.dataGrid_DoubleClick);
            this.dataGrid_real.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.dataGrid_real.GotFocus += new System.EventHandler(this.dataGrid_GotFocus);
            this.dataGrid_real.Click += new System.EventHandler(this.dataGrid_real_Click);
            // 
            // label_real_dev
            // 
            resources.ApplyResources(this.label_real_dev, "label_real_dev");
            this.label_real_dev.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_real_dev.Name = "label_real_dev";
            // 
            // comboBox_real_dev
            // 
            this.comboBox_real_dev.Items.Add(resources.GetString("comboBox_real_dev.Items"));
            this.comboBox_real_dev.Items.Add(resources.GetString("comboBox_real_dev.Items1"));
            this.comboBox_real_dev.Items.Add(resources.GetString("comboBox_real_dev.Items2"));
            this.comboBox_real_dev.Items.Add(resources.GetString("comboBox_real_dev.Items3"));
            this.comboBox_real_dev.Items.Add(resources.GetString("comboBox_real_dev.Items4"));
            this.comboBox_real_dev.Items.Add(resources.GetString("comboBox_real_dev.Items5"));
            this.comboBox_real_dev.Items.Add(resources.GetString("comboBox_real_dev.Items6"));
            this.comboBox_real_dev.Items.Add(resources.GetString("comboBox_real_dev.Items7"));
            this.comboBox_real_dev.Items.Add(resources.GetString("comboBox_real_dev.Items8"));
            this.comboBox_real_dev.Items.Add(resources.GetString("comboBox_real_dev.Items9"));
            resources.ApplyResources(this.comboBox_real_dev, "comboBox_real_dev");
            this.comboBox_real_dev.Name = "comboBox_real_dev";
            this.comboBox_real_dev.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBox_real_dev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.comboBox_real_dev.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.comboBox_real_dev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            // 
            // label_real_ean
            // 
            resources.ApplyResources(this.label_real_ean, "label_real_ean");
            this.label_real_ean.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_real_ean.Name = "label_real_ean";
            // 
            // textBox_real_ean
            // 
            this.textBox_real_ean.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_real, "ean", true));
            resources.ApplyResources(this.textBox_real_ean, "textBox_real_ean");
            this.textBox_real_ean.Name = "textBox_real_ean";
            this.textBox_real_ean.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.textBox_real_ean.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.textBox_real_ean.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.textBox_real_ean.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label_real_quantity
            // 
            resources.ApplyResources(this.label_real_quantity, "label_real_quantity");
            this.label_real_quantity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_real_quantity.Name = "label_real_quantity";
            // 
            // textBox_real_quantity
            // 
            this.textBox_real_quantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_real, "quantity", true));
            resources.ApplyResources(this.textBox_real_quantity, "textBox_real_quantity");
            this.textBox_real_quantity.Name = "textBox_real_quantity";
            this.textBox_real_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.textBox_real_quantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.textBox_real_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.textBox_real_quantity.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_real_quantity_Validating);
            // 
            // label_real_quntity_binding
            // 
            this.label_real_quntity_binding.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_real, "devaluation", true));
            resources.ApplyResources(this.label_real_quntity_binding, "label_real_quntity_binding");
            this.label_real_quntity_binding.Name = "label_real_quntity_binding";
            // 
            // imageList_statusbar
            // 
            resources.ApplyResources(this.imageList_statusbar, "imageList_statusbar");
            this.imageList_statusbar.Images.Clear();
            this.imageList_statusbar.Images.Add(((System.Drawing.Image)(resources.GetObject("resource14"))));
            this.imageList_statusbar.Images.Add(((System.Drawing.Image)(resources.GetObject("resource15"))));
            this.imageList_statusbar.Images.Add(((System.Drawing.Image)(resources.GetObject("resource16"))));
            this.imageList_statusbar.Images.Add(((System.Drawing.Image)(resources.GetObject("resource17"))));
            this.imageList_statusbar.Images.Add(((System.Drawing.Image)(resources.GetObject("resource18"))));
            // 
            // panel_statusline
            // 
            this.panel_statusline.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_statusline.Controls.Add(this.label_time);
            this.panel_statusline.Controls.Add(this.pictureBox_time);
            this.panel_statusline.Controls.Add(this.pictureBox_shift);
            this.panel_statusline.Controls.Add(this.pictureBox_alpha);
            this.panel_statusline.Controls.Add(this.panel_status);
            resources.ApplyResources(this.panel_statusline, "panel_statusline");
            this.panel_statusline.Name = "panel_statusline";
            // 
            // label_time
            // 
            this.label_time.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.label_time, "label_time");
            this.label_time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_time.Name = "label_time";
            // 
            // pictureBox_time
            // 
            this.pictureBox_time.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.pictureBox_time, "pictureBox_time");
            this.pictureBox_time.Name = "pictureBox_time";
            this.pictureBox_time.Click += new System.EventHandler(this.pictureBox_time_Click);
            // 
            // pictureBox_shift
            // 
            this.pictureBox_shift.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.pictureBox_shift, "pictureBox_shift");
            this.pictureBox_shift.Name = "pictureBox_shift";
            // 
            // pictureBox_alpha
            // 
            this.pictureBox_alpha.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.pictureBox_alpha, "pictureBox_alpha");
            this.pictureBox_alpha.Name = "pictureBox_alpha";
            // 
            // panel_status
            // 
            this.panel_status.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel_status.Controls.Add(this.label_statusbar);
            resources.ApplyResources(this.panel_status, "panel_status");
            this.panel_status.Name = "panel_status";
            // 
            // label_statusbar
            // 
            this.label_statusbar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.label_statusbar, "label_statusbar");
            this.label_statusbar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_statusbar.Name = "label_statusbar";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_export
            // 
            this.panel_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panel_export.Controls.Add(this.radioButton_export_delete);
            this.panel_export.Controls.Add(this.radioButton_export_export);
            this.panel_export.Controls.Add(this.button_export_cancel);
            this.panel_export.Controls.Add(this.button_export_ok);
            resources.ApplyResources(this.panel_export, "panel_export");
            this.panel_export.Name = "panel_export";
            // 
            // radioButton_export_delete
            // 
            resources.ApplyResources(this.radioButton_export_delete, "radioButton_export_delete");
            this.radioButton_export_delete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton_export_delete.Name = "radioButton_export_delete";
            this.radioButton_export_delete.TabStop = false;
            // 
            // radioButton_export_export
            // 
            resources.ApplyResources(this.radioButton_export_export, "radioButton_export_export");
            this.radioButton_export_export.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButton_export_export.Name = "radioButton_export_export";
            this.radioButton_export_export.TabStop = false;
            // 
            // button_export_cancel
            // 
            this.button_export_cancel.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.button_export_cancel, "button_export_cancel");
            this.button_export_cancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_export_cancel.Name = "button_export_cancel";
            this.button_export_cancel.Click += new System.EventHandler(this.button_export_cancel_Click);
            // 
            // button_export_ok
            // 
            this.button_export_ok.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.button_export_ok, "button_export_ok");
            this.button_export_ok.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_export_ok.Name = "button_export_ok";
            this.button_export_ok.Click += new System.EventHandler(this.button_export_ok_Click);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn1, "dataGridTextBoxColumn1");
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn2, "dataGridTextBoxColumn2");
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn3, "dataGridTextBoxColumn3");
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle2.MappingName = "DataTable_real";
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn4, "dataGridTextBoxColumn4");
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn5, "dataGridTextBoxColumn5");
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn6, "dataGridTextBoxColumn6");
            // 
            // dataGridTableStyle3
            // 
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn8);
            this.dataGridTableStyle3.MappingName = "DataTable_label";
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn7, "dataGridTextBoxColumn7");
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn8, "dataGridTextBoxColumn8");
            // 
            // dataGridTableStyle4
            // 
            this.dataGridTableStyle4.GridColumnStyles.Add(this.dataGridTextBoxColumn9);
            this.dataGridTableStyle4.GridColumnStyles.Add(this.dataGridTextBoxColumn10);
            this.dataGridTableStyle4.GridColumnStyles.Add(this.dataGridTextBoxColumn11);
            this.dataGridTableStyle4.MappingName = "DataTable_takeover";
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn9, "dataGridTextBoxColumn9");
            // 
            // dataGridTextBoxColumn10
            // 
            this.dataGridTextBoxColumn10.Format = "";
            this.dataGridTextBoxColumn10.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn10, "dataGridTextBoxColumn10");
            // 
            // dataGridTextBoxColumn11
            // 
            this.dataGridTextBoxColumn11.Format = "";
            this.dataGridTextBoxColumn11.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn11, "dataGridTextBoxColumn11");
            // 
            // dataGridTableStyle5
            // 
            this.dataGridTableStyle5.GridColumnStyles.Add(this.dataGridTextBoxColumn12);
            this.dataGridTableStyle5.GridColumnStyles.Add(this.dataGridTextBoxColumn13);
            this.dataGridTableStyle5.GridColumnStyles.Add(this.dataGridTextBoxColumn14);
            this.dataGridTableStyle5.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn12
            // 
            this.dataGridTextBoxColumn12.Format = "";
            this.dataGridTextBoxColumn12.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn12, "dataGridTextBoxColumn12");
            // 
            // dataGridTextBoxColumn13
            // 
            this.dataGridTextBoxColumn13.Format = "";
            this.dataGridTextBoxColumn13.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn13, "dataGridTextBoxColumn13");
            // 
            // dataGridTextBoxColumn14
            // 
            this.dataGridTextBoxColumn14.Format = "";
            this.dataGridTextBoxColumn14.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn14, "dataGridTextBoxColumn14");
            // 
            // dataGridTableStyle6
            // 
            this.dataGridTableStyle6.GridColumnStyles.Add(this.dataGridTextBoxColumn15);
            this.dataGridTableStyle6.GridColumnStyles.Add(this.dataGridTextBoxColumn16);
            this.dataGridTableStyle6.GridColumnStyles.Add(this.dataGridTextBoxColumn17);
            this.dataGridTableStyle6.MappingName = "DataTable_real";
            // 
            // dataGridTextBoxColumn15
            // 
            this.dataGridTextBoxColumn15.Format = "";
            this.dataGridTextBoxColumn15.FormatInfo = null;
            // 
            // dataGridTextBoxColumn16
            // 
            this.dataGridTextBoxColumn16.Format = "";
            this.dataGridTextBoxColumn16.FormatInfo = null;
            // 
            // dataGridTextBoxColumn17
            // 
            this.dataGridTextBoxColumn17.Format = "";
            this.dataGridTextBoxColumn17.FormatInfo = null;
            // 
            // dataGridTableStyle7
            // 
            this.dataGridTableStyle7.GridColumnStyles.Add(this.dataGridTextBoxColumn18);
            this.dataGridTableStyle7.GridColumnStyles.Add(this.dataGridTextBoxColumn19);
            // 
            // dataGridTextBoxColumn18
            // 
            this.dataGridTextBoxColumn18.Format = "";
            this.dataGridTextBoxColumn18.FormatInfo = null;
            // 
            // dataGridTextBoxColumn19
            // 
            this.dataGridTextBoxColumn19.Format = "";
            this.dataGridTextBoxColumn19.FormatInfo = null;
            // 
            // dataGridTableStyle8
            // 
            this.dataGridTableStyle8.GridColumnStyles.Add(this.dataGridTextBoxColumn20);
            this.dataGridTableStyle8.GridColumnStyles.Add(this.dataGridTextBoxColumn21);
            this.dataGridTableStyle8.GridColumnStyles.Add(this.dataGridTextBoxColumn22);
            this.dataGridTableStyle8.MappingName = "DataTable_takeover";
            // 
            // dataGridTextBoxColumn20
            // 
            this.dataGridTextBoxColumn20.Format = "";
            this.dataGridTextBoxColumn20.FormatInfo = null;
            // 
            // dataGridTextBoxColumn21
            // 
            this.dataGridTextBoxColumn21.Format = "";
            this.dataGridTextBoxColumn21.FormatInfo = null;
            // 
            // dataGridTextBoxColumn22
            // 
            this.dataGridTextBoxColumn22.Format = "";
            this.dataGridTextBoxColumn22.FormatInfo = null;
            // 
            // dataGridTableStyle9
            // 
            this.dataGridTableStyle9.GridColumnStyles.Add(this.dataGridTextBoxColumn23);
            this.dataGridTableStyle9.GridColumnStyles.Add(this.dataGridTextBoxColumn24);
            this.dataGridTableStyle9.GridColumnStyles.Add(this.dataGridTextBoxColumn25);
            this.dataGridTableStyle9.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn23
            // 
            this.dataGridTextBoxColumn23.Format = "";
            this.dataGridTextBoxColumn23.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn23, "dataGridTextBoxColumn23");
            // 
            // dataGridTextBoxColumn24
            // 
            this.dataGridTextBoxColumn24.Format = "";
            this.dataGridTextBoxColumn24.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn24, "dataGridTextBoxColumn24");
            // 
            // dataGridTextBoxColumn25
            // 
            this.dataGridTextBoxColumn25.Format = "";
            this.dataGridTextBoxColumn25.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn25, "dataGridTextBoxColumn25");
            // 
            // dataGridTableStyle10
            // 
            this.dataGridTableStyle10.GridColumnStyles.Add(this.dataGridTextBoxColumn26);
            this.dataGridTableStyle10.GridColumnStyles.Add(this.dataGridTextBoxColumn27);
            this.dataGridTableStyle10.GridColumnStyles.Add(this.dataGridTextBoxColumn28);
            // 
            // dataGridTextBoxColumn26
            // 
            this.dataGridTextBoxColumn26.Format = "";
            this.dataGridTextBoxColumn26.FormatInfo = null;
            // 
            // dataGridTextBoxColumn27
            // 
            this.dataGridTextBoxColumn27.Format = "";
            this.dataGridTextBoxColumn27.FormatInfo = null;
            // 
            // dataGridTextBoxColumn28
            // 
            this.dataGridTextBoxColumn28.Format = "";
            this.dataGridTextBoxColumn28.FormatInfo = null;
            // 
            // dataGridTableStyle11
            // 
            this.dataGridTableStyle11.GridColumnStyles.Add(this.dataGridTextBoxColumn29);
            this.dataGridTableStyle11.GridColumnStyles.Add(this.dataGridTextBoxColumn30);
            // 
            // dataGridTextBoxColumn29
            // 
            this.dataGridTextBoxColumn29.Format = "";
            this.dataGridTextBoxColumn29.FormatInfo = null;
            // 
            // dataGridTextBoxColumn30
            // 
            this.dataGridTextBoxColumn30.Format = "";
            this.dataGridTextBoxColumn30.FormatInfo = null;
            // 
            // dataGridTableStyle12
            // 
            this.dataGridTableStyle12.GridColumnStyles.Add(this.dataGridTextBoxColumn31);
            this.dataGridTableStyle12.GridColumnStyles.Add(this.dataGridTextBoxColumn32);
            this.dataGridTableStyle12.GridColumnStyles.Add(this.dataGridTextBoxColumn33);
            // 
            // dataGridTextBoxColumn31
            // 
            this.dataGridTextBoxColumn31.Format = "";
            this.dataGridTextBoxColumn31.FormatInfo = null;
            // 
            // dataGridTextBoxColumn32
            // 
            this.dataGridTextBoxColumn32.Format = "";
            this.dataGridTextBoxColumn32.FormatInfo = null;
            // 
            // dataGridTextBoxColumn33
            // 
            this.dataGridTextBoxColumn33.Format = "";
            this.dataGridTextBoxColumn33.FormatInfo = null;
            // 
            // dataGridTableStyle13
            // 
            this.dataGridTableStyle13.GridColumnStyles.Add(this.dataGridTextBoxColumn34);
            this.dataGridTableStyle13.GridColumnStyles.Add(this.dataGridTextBoxColumn35);
            this.dataGridTableStyle13.GridColumnStyles.Add(this.dataGridTextBoxColumn36);
            this.dataGridTableStyle13.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn34
            // 
            this.dataGridTextBoxColumn34.Format = "";
            this.dataGridTextBoxColumn34.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn34, "dataGridTextBoxColumn34");
            // 
            // dataGridTextBoxColumn35
            // 
            this.dataGridTextBoxColumn35.Format = "";
            this.dataGridTextBoxColumn35.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn35, "dataGridTextBoxColumn35");
            // 
            // dataGridTextBoxColumn36
            // 
            this.dataGridTextBoxColumn36.Format = "";
            this.dataGridTextBoxColumn36.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn36, "dataGridTextBoxColumn36");
            // 
            // dataGridTableStyle14
            // 
            this.dataGridTableStyle14.GridColumnStyles.Add(this.dataGridTextBoxColumn37);
            this.dataGridTableStyle14.GridColumnStyles.Add(this.dataGridTextBoxColumn38);
            this.dataGridTableStyle14.GridColumnStyles.Add(this.dataGridTextBoxColumn39);
            // 
            // dataGridTextBoxColumn37
            // 
            this.dataGridTextBoxColumn37.Format = "";
            this.dataGridTextBoxColumn37.FormatInfo = null;
            // 
            // dataGridTextBoxColumn38
            // 
            this.dataGridTextBoxColumn38.Format = "";
            this.dataGridTextBoxColumn38.FormatInfo = null;
            // 
            // dataGridTextBoxColumn39
            // 
            this.dataGridTextBoxColumn39.Format = "";
            this.dataGridTextBoxColumn39.FormatInfo = null;
            // 
            // dataGridTableStyle15
            // 
            this.dataGridTableStyle15.GridColumnStyles.Add(this.dataGridTextBoxColumn40);
            this.dataGridTableStyle15.GridColumnStyles.Add(this.dataGridTextBoxColumn41);
            // 
            // dataGridTextBoxColumn40
            // 
            this.dataGridTextBoxColumn40.Format = "";
            this.dataGridTextBoxColumn40.FormatInfo = null;
            // 
            // dataGridTextBoxColumn41
            // 
            this.dataGridTextBoxColumn41.Format = "";
            this.dataGridTextBoxColumn41.FormatInfo = null;
            // 
            // dataGridTableStyle16
            // 
            this.dataGridTableStyle16.GridColumnStyles.Add(this.dataGridTextBoxColumn42);
            this.dataGridTableStyle16.GridColumnStyles.Add(this.dataGridTextBoxColumn43);
            this.dataGridTableStyle16.GridColumnStyles.Add(this.dataGridTextBoxColumn44);
            // 
            // dataGridTextBoxColumn42
            // 
            this.dataGridTextBoxColumn42.Format = "";
            this.dataGridTextBoxColumn42.FormatInfo = null;
            // 
            // dataGridTextBoxColumn43
            // 
            this.dataGridTextBoxColumn43.Format = "";
            this.dataGridTextBoxColumn43.FormatInfo = null;
            // 
            // dataGridTextBoxColumn44
            // 
            this.dataGridTextBoxColumn44.Format = "";
            this.dataGridTextBoxColumn44.FormatInfo = null;
            // 
            // panel_MSI
            // 
            this.panel_MSI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panel_MSI.Controls.Add(this.dataGrid_MSI);
            this.panel_MSI.Controls.Add(this.label2);
            this.panel_MSI.Controls.Add(this.textBox_MSI_cod);
            this.panel_MSI.Controls.Add(this.label3);
            this.panel_MSI.Controls.Add(this.textBox_MSI_cantitate);
            resources.ApplyResources(this.panel_MSI, "panel_MSI");
            this.panel_MSI.Name = "panel_MSI";
            // 
            // bindingSource_MSI
            // 
            this.bindingSource_MSI.AllowNew = true;
            this.bindingSource_MSI.DataMember = "DataTable_MSI";
            this.bindingSource_MSI.DataSource = this.dataSet1;
            // 
            // dataGrid_MSI
            // 
            this.dataGrid_MSI.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid_MSI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.dataGrid_MSI.DataSource = this.bindingSource_MSI;
            resources.ApplyResources(this.dataGrid_MSI, "dataGrid_MSI");
            this.dataGrid_MSI.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_MSI.GridLineColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_MSI.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.dataGrid_MSI.HeaderForeColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid_MSI.Name = "dataGrid_MSI";
            this.dataGrid_MSI.TableStyles.Add(this.dataGridTableStyle_MSI);
            this.dataGrid_MSI.TabStop = false;
            this.dataGrid_MSI.DoubleClick += new System.EventHandler(this.dataGrid_DoubleClick);
            this.dataGrid_MSI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.dataGrid_MSI.GotFocus += new System.EventHandler(this.dataGrid_GotFocus);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Name = "label2";
            // 
            // textBox_MSI_cod
            // 
            this.textBox_MSI_cod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_MSI, "ean", true));
            resources.ApplyResources(this.textBox_MSI_cod, "textBox_MSI_cod");
            this.textBox_MSI_cod.Name = "textBox_MSI_cod";
            this.textBox_MSI_cod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.textBox_MSI_cod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.textBox_MSI_cod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.textBox_MSI_cod.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Name = "label3";
            // 
            // textBox_MSI_cantitate
            // 
            this.textBox_MSI_cantitate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_MSI, "quantity", true));
            resources.ApplyResources(this.textBox_MSI_cantitate, "textBox_MSI_cantitate");
            this.textBox_MSI_cantitate.Name = "textBox_MSI_cantitate";
            this.textBox_MSI_cantitate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.textBox_MSI_cantitate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyKeyUp);
            this.textBox_MSI_cantitate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.textBox_MSI_cantitate.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label4
            // 
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_real, "devaluation", true));
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // dataGridTableStyle17
            // 
            this.dataGridTableStyle17.GridColumnStyles.Add(this.dataGridTextBoxColumn45);
            this.dataGridTableStyle17.GridColumnStyles.Add(this.dataGridTextBoxColumn46);
            this.dataGridTableStyle17.GridColumnStyles.Add(this.dataGridTextBoxColumn47);
            this.dataGridTableStyle17.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn45
            // 
            this.dataGridTextBoxColumn45.Format = "";
            this.dataGridTextBoxColumn45.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn45, "dataGridTextBoxColumn45");
            // 
            // dataGridTextBoxColumn46
            // 
            this.dataGridTextBoxColumn46.Format = "";
            this.dataGridTextBoxColumn46.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn46, "dataGridTextBoxColumn46");
            // 
            // dataGridTextBoxColumn47
            // 
            this.dataGridTextBoxColumn47.Format = "";
            this.dataGridTextBoxColumn47.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn47, "dataGridTextBoxColumn47");
            // 
            // dataGridTableStyle18
            // 
            this.dataGridTableStyle18.GridColumnStyles.Add(this.dataGridTextBoxColumn48);
            this.dataGridTableStyle18.GridColumnStyles.Add(this.dataGridTextBoxColumn49);
            this.dataGridTableStyle18.GridColumnStyles.Add(this.dataGridTextBoxColumn50);
            this.dataGridTableStyle18.MappingName = "DataTable_real";
            // 
            // dataGridTextBoxColumn48
            // 
            this.dataGridTextBoxColumn48.Format = "";
            this.dataGridTextBoxColumn48.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn48, "dataGridTextBoxColumn48");
            // 
            // dataGridTextBoxColumn49
            // 
            this.dataGridTextBoxColumn49.Format = "";
            this.dataGridTextBoxColumn49.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn49, "dataGridTextBoxColumn49");
            // 
            // dataGridTextBoxColumn50
            // 
            this.dataGridTextBoxColumn50.Format = "";
            this.dataGridTextBoxColumn50.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn50, "dataGridTextBoxColumn50");
            // 
            // dataGridTableStyle19
            // 
            this.dataGridTableStyle19.GridColumnStyles.Add(this.dataGridTextBoxColumn51);
            this.dataGridTableStyle19.GridColumnStyles.Add(this.dataGridTextBoxColumn52);
            this.dataGridTableStyle19.MappingName = "DataTable_label";
            // 
            // dataGridTextBoxColumn51
            // 
            this.dataGridTextBoxColumn51.Format = "";
            this.dataGridTextBoxColumn51.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn51, "dataGridTextBoxColumn51");
            // 
            // dataGridTextBoxColumn52
            // 
            this.dataGridTextBoxColumn52.Format = "";
            this.dataGridTextBoxColumn52.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn52, "dataGridTextBoxColumn52");
            // 
            // dataGridTableStyle20
            // 
            this.dataGridTableStyle20.GridColumnStyles.Add(this.dataGridTextBoxColumn53);
            this.dataGridTableStyle20.GridColumnStyles.Add(this.dataGridTextBoxColumn54);
            this.dataGridTableStyle20.GridColumnStyles.Add(this.dataGridTextBoxColumn55);
            this.dataGridTableStyle20.MappingName = "DataTable_takeover";
            // 
            // dataGridTextBoxColumn53
            // 
            this.dataGridTextBoxColumn53.Format = "";
            this.dataGridTextBoxColumn53.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn53, "dataGridTextBoxColumn53");
            // 
            // dataGridTextBoxColumn54
            // 
            this.dataGridTextBoxColumn54.Format = "";
            this.dataGridTextBoxColumn54.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn54, "dataGridTextBoxColumn54");
            // 
            // dataGridTextBoxColumn55
            // 
            this.dataGridTextBoxColumn55.Format = "";
            this.dataGridTextBoxColumn55.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn55, "dataGridTextBoxColumn55");
            // 
            // dataGridTableStyle21
            // 
            this.dataGridTableStyle21.GridColumnStyles.Add(this.dataGridTextBoxColumn48);
            this.dataGridTableStyle21.GridColumnStyles.Add(this.dataGridTextBoxColumn49);
            this.dataGridTableStyle21.MappingName = "DataTable_MSI";
            // 
            // dataGridTableStyle22
            // 
            this.dataGridTableStyle22.GridColumnStyles.Add(this.dataGridTextBoxColumn56);
            this.dataGridTableStyle22.GridColumnStyles.Add(this.dataGridTextBoxColumn57);
            this.dataGridTableStyle22.GridColumnStyles.Add(this.dataGridTextBoxColumn58);
            this.dataGridTableStyle22.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn56
            // 
            this.dataGridTextBoxColumn56.Format = "";
            this.dataGridTextBoxColumn56.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn56, "dataGridTextBoxColumn56");
            // 
            // dataGridTextBoxColumn57
            // 
            this.dataGridTextBoxColumn57.Format = "";
            this.dataGridTextBoxColumn57.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn57, "dataGridTextBoxColumn57");
            // 
            // dataGridTextBoxColumn58
            // 
            this.dataGridTextBoxColumn58.Format = "";
            this.dataGridTextBoxColumn58.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn58, "dataGridTextBoxColumn58");
            // 
            // dataGridTableStyle23
            // 
            this.dataGridTableStyle23.GridColumnStyles.Add(this.dataGridTextBoxColumn59);
            this.dataGridTableStyle23.GridColumnStyles.Add(this.dataGridTextBoxColumn60);
            this.dataGridTableStyle23.GridColumnStyles.Add(this.dataGridTextBoxColumn61);
            this.dataGridTableStyle23.MappingName = "DataTable_real";
            // 
            // dataGridTextBoxColumn59
            // 
            this.dataGridTextBoxColumn59.Format = "";
            this.dataGridTextBoxColumn59.FormatInfo = null;
            // 
            // dataGridTextBoxColumn60
            // 
            this.dataGridTextBoxColumn60.Format = "";
            this.dataGridTextBoxColumn60.FormatInfo = null;
            // 
            // dataGridTextBoxColumn61
            // 
            this.dataGridTextBoxColumn61.Format = "";
            this.dataGridTextBoxColumn61.FormatInfo = null;
            // 
            // dataGridTableStyle24
            // 
            this.dataGridTableStyle24.GridColumnStyles.Add(this.dataGridTextBoxColumn62);
            this.dataGridTableStyle24.GridColumnStyles.Add(this.dataGridTextBoxColumn63);
            this.dataGridTableStyle24.MappingName = "DataTable_label";
            // 
            // dataGridTextBoxColumn62
            // 
            this.dataGridTextBoxColumn62.Format = "";
            this.dataGridTextBoxColumn62.FormatInfo = null;
            // 
            // dataGridTextBoxColumn63
            // 
            this.dataGridTextBoxColumn63.Format = "";
            this.dataGridTextBoxColumn63.FormatInfo = null;
            // 
            // dataGridTableStyle25
            // 
            this.dataGridTableStyle25.GridColumnStyles.Add(this.dataGridTextBoxColumn64);
            this.dataGridTableStyle25.GridColumnStyles.Add(this.dataGridTextBoxColumn65);
            this.dataGridTableStyle25.GridColumnStyles.Add(this.dataGridTextBoxColumn66);
            this.dataGridTableStyle25.MappingName = "DataTable_takeover";
            // 
            // dataGridTextBoxColumn64
            // 
            this.dataGridTextBoxColumn64.Format = "";
            this.dataGridTextBoxColumn64.FormatInfo = null;
            // 
            // dataGridTextBoxColumn65
            // 
            this.dataGridTextBoxColumn65.Format = "";
            this.dataGridTextBoxColumn65.FormatInfo = null;
            // 
            // dataGridTextBoxColumn66
            // 
            this.dataGridTextBoxColumn66.Format = "";
            this.dataGridTextBoxColumn66.FormatInfo = null;
            // 
            // dataGridTableStyle26
            // 
            this.dataGridTableStyle26.GridColumnStyles.Add(this.dataGridTextBoxColumn59);
            this.dataGridTableStyle26.GridColumnStyles.Add(this.dataGridTextBoxColumn60);
            this.dataGridTableStyle26.MappingName = "DataTable_MSI";
            // 
            // dataGridTableStyle27
            // 
            this.dataGridTableStyle27.GridColumnStyles.Add(this.dataGridTextBoxColumn67);
            this.dataGridTableStyle27.GridColumnStyles.Add(this.dataGridTextBoxColumn68);
            this.dataGridTableStyle27.GridColumnStyles.Add(this.dataGridTextBoxColumn69);
            this.dataGridTableStyle27.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn67
            // 
            this.dataGridTextBoxColumn67.Format = "";
            this.dataGridTextBoxColumn67.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn67, "dataGridTextBoxColumn67");
            // 
            // dataGridTextBoxColumn68
            // 
            this.dataGridTextBoxColumn68.Format = "";
            this.dataGridTextBoxColumn68.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn68, "dataGridTextBoxColumn68");
            // 
            // dataGridTextBoxColumn69
            // 
            this.dataGridTextBoxColumn69.Format = "";
            this.dataGridTextBoxColumn69.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn69, "dataGridTextBoxColumn69");
            // 
            // dataGridTableStyle28
            // 
            this.dataGridTableStyle28.GridColumnStyles.Add(this.dataGridTextBoxColumn70);
            this.dataGridTableStyle28.GridColumnStyles.Add(this.dataGridTextBoxColumn71);
            this.dataGridTableStyle28.GridColumnStyles.Add(this.dataGridTextBoxColumn72);
            this.dataGridTableStyle28.MappingName = "DataTable_real";
            // 
            // dataGridTextBoxColumn70
            // 
            this.dataGridTextBoxColumn70.Format = "";
            this.dataGridTextBoxColumn70.FormatInfo = null;
            // 
            // dataGridTextBoxColumn71
            // 
            this.dataGridTextBoxColumn71.Format = "";
            this.dataGridTextBoxColumn71.FormatInfo = null;
            // 
            // dataGridTextBoxColumn72
            // 
            this.dataGridTextBoxColumn72.Format = "";
            this.dataGridTextBoxColumn72.FormatInfo = null;
            // 
            // dataGridTableStyle29
            // 
            this.dataGridTableStyle29.GridColumnStyles.Add(this.dataGridTextBoxColumn73);
            this.dataGridTableStyle29.GridColumnStyles.Add(this.dataGridTextBoxColumn74);
            this.dataGridTableStyle29.MappingName = "DataTable_label";
            // 
            // dataGridTextBoxColumn73
            // 
            this.dataGridTextBoxColumn73.Format = "";
            this.dataGridTextBoxColumn73.FormatInfo = null;
            // 
            // dataGridTextBoxColumn74
            // 
            this.dataGridTextBoxColumn74.Format = "";
            this.dataGridTextBoxColumn74.FormatInfo = null;
            // 
            // dataGridTableStyle30
            // 
            this.dataGridTableStyle30.GridColumnStyles.Add(this.dataGridTextBoxColumn75);
            this.dataGridTableStyle30.GridColumnStyles.Add(this.dataGridTextBoxColumn76);
            this.dataGridTableStyle30.GridColumnStyles.Add(this.dataGridTextBoxColumn77);
            this.dataGridTableStyle30.MappingName = "DataTable_takeover";
            // 
            // dataGridTextBoxColumn75
            // 
            this.dataGridTextBoxColumn75.Format = "";
            this.dataGridTextBoxColumn75.FormatInfo = null;
            // 
            // dataGridTextBoxColumn76
            // 
            this.dataGridTextBoxColumn76.Format = "";
            this.dataGridTextBoxColumn76.FormatInfo = null;
            // 
            // dataGridTextBoxColumn77
            // 
            this.dataGridTextBoxColumn77.Format = "";
            this.dataGridTextBoxColumn77.FormatInfo = null;
            // 
            // dataGridTableStyle31
            // 
            this.dataGridTableStyle31.GridColumnStyles.Add(this.dataGridTextBoxColumn70);
            this.dataGridTableStyle31.GridColumnStyles.Add(this.dataGridTextBoxColumn71);
            this.dataGridTableStyle31.MappingName = "DataTable_MSI";
            // 
            // dataGridTableStyle32
            // 
            this.dataGridTableStyle32.GridColumnStyles.Add(this.dataGridTextBoxColumn78);
            this.dataGridTableStyle32.GridColumnStyles.Add(this.dataGridTextBoxColumn79);
            this.dataGridTableStyle32.GridColumnStyles.Add(this.dataGridTextBoxColumn80);
            this.dataGridTableStyle32.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn78
            // 
            this.dataGridTextBoxColumn78.Format = "";
            this.dataGridTextBoxColumn78.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn78, "dataGridTextBoxColumn78");
            // 
            // dataGridTextBoxColumn79
            // 
            this.dataGridTextBoxColumn79.Format = "";
            this.dataGridTextBoxColumn79.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn79, "dataGridTextBoxColumn79");
            // 
            // dataGridTextBoxColumn80
            // 
            this.dataGridTextBoxColumn80.Format = "";
            this.dataGridTextBoxColumn80.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn80, "dataGridTextBoxColumn80");
            // 
            // dataGridTableStyle33
            // 
            this.dataGridTableStyle33.GridColumnStyles.Add(this.dataGridTextBoxColumn81);
            this.dataGridTableStyle33.GridColumnStyles.Add(this.dataGridTextBoxColumn82);
            this.dataGridTableStyle33.GridColumnStyles.Add(this.dataGridTextBoxColumn83);
            this.dataGridTableStyle33.MappingName = "DataTable_real";
            // 
            // dataGridTextBoxColumn81
            // 
            this.dataGridTextBoxColumn81.Format = "";
            this.dataGridTextBoxColumn81.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn81, "dataGridTextBoxColumn81");
            // 
            // dataGridTextBoxColumn82
            // 
            this.dataGridTextBoxColumn82.Format = "";
            this.dataGridTextBoxColumn82.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn82, "dataGridTextBoxColumn82");
            // 
            // dataGridTextBoxColumn83
            // 
            this.dataGridTextBoxColumn83.Format = "";
            this.dataGridTextBoxColumn83.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn83, "dataGridTextBoxColumn83");
            // 
            // dataGridTableStyle34
            // 
            this.dataGridTableStyle34.GridColumnStyles.Add(this.dataGridTextBoxColumn84);
            this.dataGridTableStyle34.GridColumnStyles.Add(this.dataGridTextBoxColumn85);
            this.dataGridTableStyle34.MappingName = "DataTable_label";
            // 
            // dataGridTextBoxColumn84
            // 
            this.dataGridTextBoxColumn84.Format = "";
            this.dataGridTextBoxColumn84.FormatInfo = null;
            // 
            // dataGridTextBoxColumn85
            // 
            this.dataGridTextBoxColumn85.Format = "";
            this.dataGridTextBoxColumn85.FormatInfo = null;
            // 
            // dataGridTableStyle35
            // 
            this.dataGridTableStyle35.GridColumnStyles.Add(this.dataGridTextBoxColumn86);
            this.dataGridTableStyle35.GridColumnStyles.Add(this.dataGridTextBoxColumn87);
            this.dataGridTableStyle35.GridColumnStyles.Add(this.dataGridTextBoxColumn88);
            this.dataGridTableStyle35.MappingName = "DataTable_takeover";
            // 
            // dataGridTextBoxColumn86
            // 
            this.dataGridTextBoxColumn86.Format = "";
            this.dataGridTextBoxColumn86.FormatInfo = null;
            // 
            // dataGridTextBoxColumn87
            // 
            this.dataGridTextBoxColumn87.Format = "";
            this.dataGridTextBoxColumn87.FormatInfo = null;
            // 
            // dataGridTextBoxColumn88
            // 
            this.dataGridTextBoxColumn88.Format = "";
            this.dataGridTextBoxColumn88.FormatInfo = null;
            // 
            // dataGridTableStyle36
            // 
            this.dataGridTableStyle36.GridColumnStyles.Add(this.dataGridTextBoxColumn81);
            this.dataGridTableStyle36.GridColumnStyles.Add(this.dataGridTextBoxColumn82);
            this.dataGridTableStyle36.MappingName = "DataTable_MSI";
            // 
            // dataGridTableStyle37
            // 
            this.dataGridTableStyle37.GridColumnStyles.Add(this.dataGridTextBoxColumn89);
            this.dataGridTableStyle37.GridColumnStyles.Add(this.dataGridTextBoxColumn90);
            this.dataGridTableStyle37.GridColumnStyles.Add(this.dataGridTextBoxColumn91);
            this.dataGridTableStyle37.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn89
            // 
            this.dataGridTextBoxColumn89.Format = "";
            this.dataGridTextBoxColumn89.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn89, "dataGridTextBoxColumn89");
            // 
            // dataGridTextBoxColumn90
            // 
            this.dataGridTextBoxColumn90.Format = "";
            this.dataGridTextBoxColumn90.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn90, "dataGridTextBoxColumn90");
            // 
            // dataGridTextBoxColumn91
            // 
            this.dataGridTextBoxColumn91.Format = "";
            this.dataGridTextBoxColumn91.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn91, "dataGridTextBoxColumn91");
            // 
            // dataGridTableStyle38
            // 
            this.dataGridTableStyle38.GridColumnStyles.Add(this.dataGridTextBoxColumn92);
            this.dataGridTableStyle38.GridColumnStyles.Add(this.dataGridTextBoxColumn93);
            this.dataGridTableStyle38.GridColumnStyles.Add(this.dataGridTextBoxColumn94);
            this.dataGridTableStyle38.MappingName = "DataTable_real";
            // 
            // dataGridTextBoxColumn92
            // 
            this.dataGridTextBoxColumn92.Format = "";
            this.dataGridTextBoxColumn92.FormatInfo = null;
            // 
            // dataGridTextBoxColumn93
            // 
            this.dataGridTextBoxColumn93.Format = "";
            this.dataGridTextBoxColumn93.FormatInfo = null;
            // 
            // dataGridTextBoxColumn94
            // 
            this.dataGridTextBoxColumn94.Format = "";
            this.dataGridTextBoxColumn94.FormatInfo = null;
            // 
            // dataGridTableStyle39
            // 
            this.dataGridTableStyle39.GridColumnStyles.Add(this.dataGridTextBoxColumn95);
            this.dataGridTableStyle39.GridColumnStyles.Add(this.dataGridTextBoxColumn96);
            this.dataGridTableStyle39.MappingName = "DataTable_label";
            // 
            // dataGridTextBoxColumn95
            // 
            this.dataGridTextBoxColumn95.Format = "";
            this.dataGridTextBoxColumn95.FormatInfo = null;
            // 
            // dataGridTextBoxColumn96
            // 
            this.dataGridTextBoxColumn96.Format = "";
            this.dataGridTextBoxColumn96.FormatInfo = null;
            // 
            // dataGridTableStyle40
            // 
            this.dataGridTableStyle40.GridColumnStyles.Add(this.dataGridTextBoxColumn97);
            this.dataGridTableStyle40.GridColumnStyles.Add(this.dataGridTextBoxColumn98);
            this.dataGridTableStyle40.GridColumnStyles.Add(this.dataGridTextBoxColumn99);
            this.dataGridTableStyle40.MappingName = "DataTable_takeover";
            // 
            // dataGridTextBoxColumn97
            // 
            this.dataGridTextBoxColumn97.Format = "";
            this.dataGridTextBoxColumn97.FormatInfo = null;
            // 
            // dataGridTextBoxColumn98
            // 
            this.dataGridTextBoxColumn98.Format = "";
            this.dataGridTextBoxColumn98.FormatInfo = null;
            // 
            // dataGridTextBoxColumn99
            // 
            this.dataGridTextBoxColumn99.Format = "";
            this.dataGridTextBoxColumn99.FormatInfo = null;
            // 
            // dataGridTableStyle41
            // 
            this.dataGridTableStyle41.GridColumnStyles.Add(this.dataGridTextBoxColumn92);
            this.dataGridTableStyle41.GridColumnStyles.Add(this.dataGridTextBoxColumn93);
            this.dataGridTableStyle41.MappingName = "DataTable_MSI";
            // 
            // dataGridTableStyle42
            // 
            this.dataGridTableStyle42.GridColumnStyles.Add(this.dataGridTextBoxColumn100);
            this.dataGridTableStyle42.GridColumnStyles.Add(this.dataGridTextBoxColumn101);
            this.dataGridTableStyle42.GridColumnStyles.Add(this.dataGridTextBoxColumn102);
            this.dataGridTableStyle42.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn100
            // 
            this.dataGridTextBoxColumn100.Format = "";
            this.dataGridTextBoxColumn100.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn100, "dataGridTextBoxColumn100");
            // 
            // dataGridTextBoxColumn101
            // 
            this.dataGridTextBoxColumn101.Format = "";
            this.dataGridTextBoxColumn101.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn101, "dataGridTextBoxColumn101");
            // 
            // dataGridTextBoxColumn102
            // 
            this.dataGridTextBoxColumn102.Format = "";
            this.dataGridTextBoxColumn102.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn102, "dataGridTextBoxColumn102");
            // 
            // dataGridTableStyle43
            // 
            this.dataGridTableStyle43.GridColumnStyles.Add(this.dataGridTextBoxColumn103);
            this.dataGridTableStyle43.GridColumnStyles.Add(this.dataGridTextBoxColumn104);
            this.dataGridTableStyle43.GridColumnStyles.Add(this.dataGridTextBoxColumn105);
            this.dataGridTableStyle43.MappingName = "DataTable_real";
            // 
            // dataGridTextBoxColumn103
            // 
            this.dataGridTextBoxColumn103.Format = "";
            this.dataGridTextBoxColumn103.FormatInfo = null;
            // 
            // dataGridTextBoxColumn104
            // 
            this.dataGridTextBoxColumn104.Format = "";
            this.dataGridTextBoxColumn104.FormatInfo = null;
            // 
            // dataGridTextBoxColumn105
            // 
            this.dataGridTextBoxColumn105.Format = "";
            this.dataGridTextBoxColumn105.FormatInfo = null;
            // 
            // dataGridTableStyle44
            // 
            this.dataGridTableStyle44.GridColumnStyles.Add(this.dataGridTextBoxColumn106);
            this.dataGridTableStyle44.GridColumnStyles.Add(this.dataGridTextBoxColumn107);
            this.dataGridTableStyle44.MappingName = "DataTable_label";
            // 
            // dataGridTextBoxColumn106
            // 
            this.dataGridTextBoxColumn106.Format = "";
            this.dataGridTextBoxColumn106.FormatInfo = null;
            // 
            // dataGridTextBoxColumn107
            // 
            this.dataGridTextBoxColumn107.Format = "";
            this.dataGridTextBoxColumn107.FormatInfo = null;
            // 
            // dataGridTableStyle45
            // 
            this.dataGridTableStyle45.GridColumnStyles.Add(this.dataGridTextBoxColumn108);
            this.dataGridTableStyle45.GridColumnStyles.Add(this.dataGridTextBoxColumn109);
            this.dataGridTableStyle45.GridColumnStyles.Add(this.dataGridTextBoxColumn110);
            this.dataGridTableStyle45.MappingName = "DataTable_takeover";
            // 
            // dataGridTextBoxColumn108
            // 
            this.dataGridTextBoxColumn108.Format = "";
            this.dataGridTextBoxColumn108.FormatInfo = null;
            // 
            // dataGridTextBoxColumn109
            // 
            this.dataGridTextBoxColumn109.Format = "";
            this.dataGridTextBoxColumn109.FormatInfo = null;
            // 
            // dataGridTextBoxColumn110
            // 
            this.dataGridTextBoxColumn110.Format = "";
            this.dataGridTextBoxColumn110.FormatInfo = null;
            // 
            // dataGridTableStyle46
            // 
            this.dataGridTableStyle46.GridColumnStyles.Add(this.dataGridTextBoxColumn103);
            this.dataGridTableStyle46.GridColumnStyles.Add(this.dataGridTextBoxColumn104);
            this.dataGridTableStyle46.MappingName = "DataTable_MSI";
            // 
            // dataGridTableStyle47
            // 
            this.dataGridTableStyle47.GridColumnStyles.Add(this.dataGridTextBoxColumn111);
            this.dataGridTableStyle47.GridColumnStyles.Add(this.dataGridTextBoxColumn112);
            this.dataGridTableStyle47.GridColumnStyles.Add(this.dataGridTextBoxColumn113);
            this.dataGridTableStyle47.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn111
            // 
            this.dataGridTextBoxColumn111.Format = "";
            this.dataGridTextBoxColumn111.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn111, "dataGridTextBoxColumn111");
            // 
            // dataGridTextBoxColumn112
            // 
            this.dataGridTextBoxColumn112.Format = "";
            this.dataGridTextBoxColumn112.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn112, "dataGridTextBoxColumn112");
            // 
            // dataGridTextBoxColumn113
            // 
            this.dataGridTextBoxColumn113.Format = "";
            this.dataGridTextBoxColumn113.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn113, "dataGridTextBoxColumn113");
            // 
            // dataGridTableStyle48
            // 
            this.dataGridTableStyle48.GridColumnStyles.Add(this.dataGridTextBoxColumn114);
            this.dataGridTableStyle48.GridColumnStyles.Add(this.dataGridTextBoxColumn115);
            this.dataGridTableStyle48.GridColumnStyles.Add(this.dataGridTextBoxColumn116);
            this.dataGridTableStyle48.MappingName = "DataTable_real";
            // 
            // dataGridTextBoxColumn114
            // 
            this.dataGridTextBoxColumn114.Format = "";
            this.dataGridTextBoxColumn114.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn114, "dataGridTextBoxColumn114");
            // 
            // dataGridTextBoxColumn115
            // 
            this.dataGridTextBoxColumn115.Format = "";
            this.dataGridTextBoxColumn115.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn115, "dataGridTextBoxColumn115");
            // 
            // dataGridTextBoxColumn116
            // 
            this.dataGridTextBoxColumn116.Format = "";
            this.dataGridTextBoxColumn116.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn116, "dataGridTextBoxColumn116");
            // 
            // dataGridTableStyle49
            // 
            this.dataGridTableStyle49.GridColumnStyles.Add(this.dataGridTextBoxColumn117);
            this.dataGridTableStyle49.GridColumnStyles.Add(this.dataGridTextBoxColumn118);
            this.dataGridTableStyle49.MappingName = "DataTable_label";
            // 
            // dataGridTextBoxColumn117
            // 
            this.dataGridTextBoxColumn117.Format = "";
            this.dataGridTextBoxColumn117.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn117, "dataGridTextBoxColumn117");
            // 
            // dataGridTextBoxColumn118
            // 
            this.dataGridTextBoxColumn118.Format = "";
            this.dataGridTextBoxColumn118.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn118, "dataGridTextBoxColumn118");
            // 
            // dataGridTableStyle50
            // 
            this.dataGridTableStyle50.GridColumnStyles.Add(this.dataGridTextBoxColumn119);
            this.dataGridTableStyle50.GridColumnStyles.Add(this.dataGridTextBoxColumn120);
            this.dataGridTableStyle50.GridColumnStyles.Add(this.dataGridTextBoxColumn121);
            this.dataGridTableStyle50.MappingName = "DataTable_takeover";
            // 
            // dataGridTextBoxColumn119
            // 
            this.dataGridTextBoxColumn119.Format = "";
            this.dataGridTextBoxColumn119.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn119, "dataGridTextBoxColumn119");
            // 
            // dataGridTextBoxColumn120
            // 
            this.dataGridTextBoxColumn120.Format = "";
            this.dataGridTextBoxColumn120.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn120, "dataGridTextBoxColumn120");
            // 
            // dataGridTextBoxColumn121
            // 
            this.dataGridTextBoxColumn121.Format = "";
            this.dataGridTextBoxColumn121.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn121, "dataGridTextBoxColumn121");
            // 
            // dataGridTableStyle51
            // 
            this.dataGridTableStyle51.GridColumnStyles.Add(this.dataGridTextBoxColumn122);
            this.dataGridTableStyle51.GridColumnStyles.Add(this.dataGridTextBoxColumn123);
            this.dataGridTableStyle51.MappingName = "DataTable_MSI";
            // 
            // dataGridTextBoxColumn122
            // 
            this.dataGridTextBoxColumn122.Format = "";
            this.dataGridTextBoxColumn122.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn122, "dataGridTextBoxColumn122");
            // 
            // dataGridTextBoxColumn123
            // 
            this.dataGridTextBoxColumn123.Format = "";
            this.dataGridTextBoxColumn123.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn123, "dataGridTextBoxColumn123");
            // 
            // dataGridTableStyle52
            // 
            this.dataGridTableStyle52.GridColumnStyles.Add(this.dataGridTextBoxColumn124);
            this.dataGridTableStyle52.GridColumnStyles.Add(this.dataGridTextBoxColumn125);
            this.dataGridTableStyle52.GridColumnStyles.Add(this.dataGridTextBoxColumn126);
            this.dataGridTableStyle52.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn124
            // 
            this.dataGridTextBoxColumn124.Format = "";
            this.dataGridTextBoxColumn124.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn124, "dataGridTextBoxColumn124");
            // 
            // dataGridTextBoxColumn125
            // 
            this.dataGridTextBoxColumn125.Format = "";
            this.dataGridTextBoxColumn125.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn125, "dataGridTextBoxColumn125");
            // 
            // dataGridTextBoxColumn126
            // 
            this.dataGridTextBoxColumn126.Format = "";
            this.dataGridTextBoxColumn126.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn126, "dataGridTextBoxColumn126");
            // 
            // dataGridTableStyle53
            // 
            this.dataGridTableStyle53.GridColumnStyles.Add(this.dataGridTextBoxColumn127);
            this.dataGridTableStyle53.GridColumnStyles.Add(this.dataGridTextBoxColumn128);
            this.dataGridTableStyle53.GridColumnStyles.Add(this.dataGridTextBoxColumn129);
            this.dataGridTableStyle53.MappingName = "DataTable_real";
            // 
            // dataGridTextBoxColumn127
            // 
            this.dataGridTextBoxColumn127.Format = "";
            this.dataGridTextBoxColumn127.FormatInfo = null;
            // 
            // dataGridTextBoxColumn128
            // 
            this.dataGridTextBoxColumn128.Format = "";
            this.dataGridTextBoxColumn128.FormatInfo = null;
            // 
            // dataGridTextBoxColumn129
            // 
            this.dataGridTextBoxColumn129.Format = "";
            this.dataGridTextBoxColumn129.FormatInfo = null;
            // 
            // dataGridTableStyle54
            // 
            this.dataGridTableStyle54.GridColumnStyles.Add(this.dataGridTextBoxColumn130);
            this.dataGridTableStyle54.GridColumnStyles.Add(this.dataGridTextBoxColumn131);
            this.dataGridTableStyle54.MappingName = "DataTable_label";
            // 
            // dataGridTextBoxColumn130
            // 
            this.dataGridTextBoxColumn130.Format = "";
            this.dataGridTextBoxColumn130.FormatInfo = null;
            // 
            // dataGridTextBoxColumn131
            // 
            this.dataGridTextBoxColumn131.Format = "";
            this.dataGridTextBoxColumn131.FormatInfo = null;
            // 
            // dataGridTableStyle55
            // 
            this.dataGridTableStyle55.GridColumnStyles.Add(this.dataGridTextBoxColumn132);
            this.dataGridTableStyle55.GridColumnStyles.Add(this.dataGridTextBoxColumn133);
            this.dataGridTableStyle55.GridColumnStyles.Add(this.dataGridTextBoxColumn134);
            this.dataGridTableStyle55.MappingName = "DataTable_takeover";
            // 
            // dataGridTextBoxColumn132
            // 
            this.dataGridTextBoxColumn132.Format = "";
            this.dataGridTextBoxColumn132.FormatInfo = null;
            // 
            // dataGridTextBoxColumn133
            // 
            this.dataGridTextBoxColumn133.Format = "";
            this.dataGridTextBoxColumn133.FormatInfo = null;
            // 
            // dataGridTextBoxColumn134
            // 
            this.dataGridTextBoxColumn134.Format = "";
            this.dataGridTextBoxColumn134.FormatInfo = null;
            // 
            // dataGridTableStyle56
            // 
            this.dataGridTableStyle56.GridColumnStyles.Add(this.dataGridTextBoxColumn135);
            this.dataGridTableStyle56.GridColumnStyles.Add(this.dataGridTextBoxColumn136);
            this.dataGridTableStyle56.MappingName = "DataTable_MSI";
            // 
            // dataGridTextBoxColumn135
            // 
            this.dataGridTextBoxColumn135.Format = "";
            this.dataGridTextBoxColumn135.FormatInfo = null;
            // 
            // dataGridTextBoxColumn136
            // 
            this.dataGridTextBoxColumn136.Format = "";
            this.dataGridTextBoxColumn136.FormatInfo = null;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Prefix = "";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridTableStyle57
            // 
            this.dataGridTableStyle57.GridColumnStyles.Add(this.dataGridTextBoxColumn137);
            this.dataGridTableStyle57.GridColumnStyles.Add(this.dataGridTextBoxColumn138);
            this.dataGridTableStyle57.GridColumnStyles.Add(this.dataGridTextBoxColumn139);
            this.dataGridTableStyle57.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn137
            // 
            this.dataGridTextBoxColumn137.Format = "";
            this.dataGridTextBoxColumn137.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn137, "dataGridTextBoxColumn137");
            // 
            // dataGridTextBoxColumn138
            // 
            this.dataGridTextBoxColumn138.Format = "";
            this.dataGridTextBoxColumn138.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn138, "dataGridTextBoxColumn138");
            // 
            // dataGridTextBoxColumn139
            // 
            this.dataGridTextBoxColumn139.Format = "";
            this.dataGridTextBoxColumn139.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn139, "dataGridTextBoxColumn139");
            // 
            // dataGridTableStyle_con
            // 
            this.dataGridTableStyle_con.GridColumnStyles.Add(this.dataGridTextBoxColumn_con1);
            this.dataGridTableStyle_con.GridColumnStyles.Add(this.dataGridTextBoxColumn_con2);
            this.dataGridTableStyle_con.GridColumnStyles.Add(this.dataGridTextBoxColumn_con3);
            this.dataGridTableStyle_con.MappingName = "DataTable_con";
            // 
            // dataGridTextBoxColumn_con1
            // 
            this.dataGridTextBoxColumn_con1.Format = "";
            this.dataGridTextBoxColumn_con1.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn_con1, "dataGridTextBoxColumn_con1");
            // 
            // dataGridTextBoxColumn_con2
            // 
            this.dataGridTextBoxColumn_con2.Format = "";
            this.dataGridTextBoxColumn_con2.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn_con2, "dataGridTextBoxColumn_con2");
            // 
            // dataGridTextBoxColumn_con3
            // 
            this.dataGridTextBoxColumn_con3.Format = "";
            this.dataGridTextBoxColumn_con3.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn_con3, "dataGridTextBoxColumn_con3");
            // 
            // dataGridTableStyle58
            // 
            this.dataGridTableStyle58.GridColumnStyles.Add(this.dataGridTextBoxColumn140);
            this.dataGridTableStyle58.GridColumnStyles.Add(this.dataGridTextBoxColumn141);
            this.dataGridTableStyle58.GridColumnStyles.Add(this.dataGridTextBoxColumn142);
            this.dataGridTableStyle58.MappingName = "DataTable_real";
            // 
            // dataGridTextBoxColumn140
            // 
            this.dataGridTextBoxColumn140.Format = "";
            this.dataGridTextBoxColumn140.FormatInfo = null;
            // 
            // dataGridTextBoxColumn141
            // 
            this.dataGridTextBoxColumn141.Format = "";
            this.dataGridTextBoxColumn141.FormatInfo = null;
            // 
            // dataGridTextBoxColumn142
            // 
            this.dataGridTextBoxColumn142.Format = "";
            this.dataGridTextBoxColumn142.FormatInfo = null;
            // 
            // dataGridTableStyle_real
            // 
            this.dataGridTableStyle_real.GridColumnStyles.Add(this.dataGridTextBoxColumn_real1);
            this.dataGridTableStyle_real.GridColumnStyles.Add(this.dataGridTextBoxColumn_real2);
            this.dataGridTableStyle_real.GridColumnStyles.Add(this.dataGridTextBoxColumn_real3);
            this.dataGridTableStyle_real.MappingName = "DataTable_real";
            // 
            // dataGridTextBoxColumn_real1
            // 
            this.dataGridTextBoxColumn_real1.Format = "";
            this.dataGridTextBoxColumn_real1.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn_real1, "dataGridTextBoxColumn_real1");
            // 
            // dataGridTextBoxColumn_real2
            // 
            this.dataGridTextBoxColumn_real2.Format = "";
            this.dataGridTextBoxColumn_real2.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn_real2, "dataGridTextBoxColumn_real2");
            // 
            // dataGridTextBoxColumn_real3
            // 
            this.dataGridTextBoxColumn_real3.Format = "";
            this.dataGridTextBoxColumn_real3.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn_real3, "dataGridTextBoxColumn_real3");
            // 
            // dataGridTableStyle59
            // 
            this.dataGridTableStyle59.GridColumnStyles.Add(this.dataGridTextBoxColumn143);
            this.dataGridTableStyle59.GridColumnStyles.Add(this.dataGridTextBoxColumn144);
            this.dataGridTableStyle59.MappingName = "DataTable_label";
            // 
            // dataGridTextBoxColumn143
            // 
            this.dataGridTextBoxColumn143.Format = "";
            this.dataGridTextBoxColumn143.FormatInfo = null;
            // 
            // dataGridTextBoxColumn144
            // 
            this.dataGridTextBoxColumn144.Format = "";
            this.dataGridTextBoxColumn144.FormatInfo = null;
            // 
            // dataGridTableStyle_label
            // 
            this.dataGridTableStyle_label.GridColumnStyles.Add(this.dataGridTextBoxColumn_label1);
            this.dataGridTableStyle_label.GridColumnStyles.Add(this.dataGridTextBoxColumn_label2);
            this.dataGridTableStyle_label.MappingName = "DataTable_label";
            // 
            // dataGridTextBoxColumn_label1
            // 
            this.dataGridTextBoxColumn_label1.Format = "";
            this.dataGridTextBoxColumn_label1.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn_label1, "dataGridTextBoxColumn_label1");
            // 
            // dataGridTextBoxColumn_label2
            // 
            this.dataGridTextBoxColumn_label2.Format = "";
            this.dataGridTextBoxColumn_label2.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn_label2, "dataGridTextBoxColumn_label2");
            // 
            // dataGridTableStyle60
            // 
            this.dataGridTableStyle60.GridColumnStyles.Add(this.dataGridTextBoxColumn145);
            this.dataGridTableStyle60.GridColumnStyles.Add(this.dataGridTextBoxColumn146);
            this.dataGridTableStyle60.GridColumnStyles.Add(this.dataGridTextBoxColumn147);
            this.dataGridTableStyle60.MappingName = "DataTable_takeover";
            // 
            // dataGridTextBoxColumn145
            // 
            this.dataGridTextBoxColumn145.Format = "";
            this.dataGridTextBoxColumn145.FormatInfo = null;
            // 
            // dataGridTextBoxColumn146
            // 
            this.dataGridTextBoxColumn146.Format = "";
            this.dataGridTextBoxColumn146.FormatInfo = null;
            // 
            // dataGridTextBoxColumn147
            // 
            this.dataGridTextBoxColumn147.Format = "";
            this.dataGridTextBoxColumn147.FormatInfo = null;
            // 
            // dataGridTableStyle_takeover
            // 
            this.dataGridTableStyle_takeover.GridColumnStyles.Add(this.dataGridTextBoxColumn_take1);
            this.dataGridTableStyle_takeover.GridColumnStyles.Add(this.dataGridTextBoxColumn_take2);
            this.dataGridTableStyle_takeover.GridColumnStyles.Add(this.dataGridTextBoxColumn_take3);
            this.dataGridTableStyle_takeover.MappingName = "DataTable_takeover";
            // 
            // dataGridTextBoxColumn_take1
            // 
            this.dataGridTextBoxColumn_take1.Format = "";
            this.dataGridTextBoxColumn_take1.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn_take1, "dataGridTextBoxColumn_take1");
            // 
            // dataGridTextBoxColumn_take2
            // 
            this.dataGridTextBoxColumn_take2.Format = "";
            this.dataGridTextBoxColumn_take2.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn_take2, "dataGridTextBoxColumn_take2");
            // 
            // dataGridTextBoxColumn_take3
            // 
            this.dataGridTextBoxColumn_take3.Format = "";
            this.dataGridTextBoxColumn_take3.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn_take3, "dataGridTextBoxColumn_take3");
            // 
            // dataGridTableStyle61
            // 
            this.dataGridTableStyle61.GridColumnStyles.Add(this.dataGridTextBoxColumn148);
            this.dataGridTableStyle61.GridColumnStyles.Add(this.dataGridTextBoxColumn149);
            this.dataGridTableStyle61.MappingName = "DataTable_MSI";
            // 
            // dataGridTextBoxColumn148
            // 
            this.dataGridTextBoxColumn148.Format = "";
            this.dataGridTextBoxColumn148.FormatInfo = null;
            // 
            // dataGridTextBoxColumn149
            // 
            this.dataGridTextBoxColumn149.Format = "";
            this.dataGridTextBoxColumn149.FormatInfo = null;
            // 
            // dataGridTableStyle_MSI
            // 
            this.dataGridTableStyle_MSI.GridColumnStyles.Add(this.dataGridTextBoxColumn_MSI1);
            this.dataGridTableStyle_MSI.GridColumnStyles.Add(this.dataGridTextBoxColumn_MSI2);
            this.dataGridTableStyle_MSI.MappingName = "DataTable_MSI";
            // 
            // dataGridTextBoxColumn_MSI1
            // 
            this.dataGridTextBoxColumn_MSI1.Format = "";
            this.dataGridTextBoxColumn_MSI1.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn_MSI1, "dataGridTextBoxColumn_MSI1");
            // 
            // dataGridTextBoxColumn_MSI2
            // 
            this.dataGridTextBoxColumn_MSI2.Format = "";
            this.dataGridTextBoxColumn_MSI2.FormatInfo = null;
            resources.ApplyResources(this.dataGridTextBoxColumn_MSI2, "dataGridTextBoxColumn_MSI2");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ControlBox = false;
            this.Controls.Add(this.panel_con);
            this.Controls.Add(this.panel_real);
            this.Controls.Add(this.panel_label);
            this.Controls.Add(this.panel_takeover);
            this.Controls.Add(this.panel_MSI);
            this.Controls.Add(this.panel_applications);
            this.Controls.Add(this.panel_export);
            this.Controls.Add(this.panel_navigator);
            this.Controls.Add(this.panel_statusline);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyKeyPress);
            this.panel_applications.ResumeLayout(false);
            this.panel_con.ResumeLayout(false);
            this.panel_takeover.ResumeLayout(false);
            this.panel_label.ResumeLayout(false);
            this.panel_navigator.ResumeLayout(false);
            this.panel_real.ResumeLayout(false);
            this.panel_statusline.ResumeLayout(false);
            this.panel_status.ResumeLayout(false);
            this.panel_export.ResumeLayout(false);
            this.panel_MSI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_con;
        private System.Windows.Forms.RadioButton radioButton_real;
        private System.Windows.Forms.RadioButton radioButton_label;
        private System.Windows.Forms.RadioButton radioButton_download;
        private System.Windows.Forms.Button button_ok;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn_id;
        private System.Data.DataColumn dataColumn_appcode;
        private System.Data.DataColumn dataColumn_storecode;
        private System.Data.DataColumn dataColumn_ean;
        private System.Data.DataColumn dataColumn_price;
        private System.Data.DataColumn dataColumn_quantity;
        private System.Data.DataColumn dataColumn_takeover;
        private System.Windows.Forms.BindingSource bindingSource_con;
        private System.Windows.Forms.Panel panel_applications;
        private System.Windows.Forms.Panel panel_con;
        private System.Windows.Forms.ImageList imageList_buttons;
        private System.Windows.Forms.ComboBox comboBox_con_store;
        private System.Windows.Forms.TextBox textBox_con_price;
        private System.Windows.Forms.TextBox textBox_con_ean;
        private System.Data.DataColumn dataColumn_con_store;
        private System.Data.DataColumn dataColumn_con_ean;
        private System.Data.DataColumn dataColumn_con_price;
        private System.Data.DataTable dataTable_real;
        private System.Data.DataColumn dataColumn_real_ean;
        private System.Data.DataColumn dataColumn_real_quantity;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bindingSource_real;
        private System.Windows.Forms.Panel panel_navigator;
        private System.Windows.Forms.PictureBox pictureBox_back;
        private System.Windows.Forms.PictureBox pictureBox_delete;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label_con_price;
        private System.Windows.Forms.Label label_con_ean;
        private System.Windows.Forms.Label label_con_store;
        private System.Windows.Forms.Panel panel_real;
        private System.Windows.Forms.Label label_real_quantity;
        private System.Windows.Forms.Label label_real_ean;
        private System.Windows.Forms.TextBox textBox_real_quantity;
        private System.Windows.Forms.TextBox textBox_real_ean;
        internal System.Windows.Forms.Panel panel_label;
        private System.Windows.Forms.Label label_label_ean;
        private System.Windows.Forms.TextBox textBox_label_price;
        private System.Windows.Forms.TextBox textBox_label_ean;
        private System.Windows.Forms.Label label_label_price;
        private System.Windows.Forms.BindingSource bindingSource_label;
        private System.Windows.Forms.PictureBox pictureBox_nav_background;
        private System.Windows.Forms.PictureBox pictureBox_prev;
        private System.Windows.Forms.PictureBox pictureBox_first;
        private System.Windows.Forms.PictureBox pictureBox_next;
        private System.Windows.Forms.PictureBox pictureBox_last;
        private System.Windows.Forms.PictureBox pictureBox_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource_takeover;
        private System.Windows.Forms.RadioButton radioButton_takeover;
        private System.Windows.Forms.Panel panel_takeover;
        private System.Windows.Forms.TextBox textBox_takeover_quantity;
        private System.Windows.Forms.TextBox textBox_takeover_ean;
        private System.Windows.Forms.TextBox textBox_takeover_takeovernum;
        private System.Windows.Forms.Label label_takeover_quantity;
        private System.Windows.Forms.Label label_takeover_ean;
        private System.Windows.Forms.Label label_takeover_takeovernum;
        
        private System.Windows.Forms.ComboBox comboBox_real_dev;
        private System.Windows.Forms.Label label_real_dev;
        private System.Windows.Forms.Label label_input_takeovernumber;
        
        private System.Windows.Forms.Label label_con_storecode;
        
        private System.Windows.Forms.ImageList imageList_statusbar;
        
        private System.Windows.Forms.Panel panel_statusline;
        private System.Windows.Forms.Panel panel_status;
        
        private System.Windows.Forms.PictureBox pictureBox_time;
        private System.Windows.Forms.PictureBox pictureBox_shift;
        private System.Windows.Forms.PictureBox pictureBox_alpha;
        private System.Windows.Forms.Label label_statusbar;
        
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_time;

        private System.Windows.Forms.DataGrid dataGrid_con;
        private System.Windows.Forms.DataGrid dataGrid_real;
        private System.Windows.Forms.DataGrid dataGrid_label;
        private System.Windows.Forms.DataGrid dataGrid_takeover;
        private System.Windows.Forms.Panel panel_export;
        private System.Windows.Forms.Button button_export_cancel;
        private System.Windows.Forms.Button button_export_ok;
        private System.Windows.Forms.RadioButton radioButton_export_delete;
        private System.Windows.Forms.RadioButton radioButton_export_export;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle_con;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn_con1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn_con2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn_con3;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle_label;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn_label1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn_label2;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle_real;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle_takeover;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn_take1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn_take2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn_take3;
        private System.Windows.Forms.Label label_real_quntity_binding;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn12;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn13;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn14;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn15;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn16;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn17;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn18;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn19;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle8;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn20;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn21;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn22;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle9;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn23;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn24;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn25;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle10;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn26;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn27;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn28;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle11;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn29;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn30;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle12;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn31;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn32;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn33;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle13;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn34;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn35;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn36;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle14;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn37;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn38;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn39;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle15;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn40;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn41;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle16;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn42;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn43;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn44;
        private System.Windows.Forms.RadioButton radioButton_MSI;
        private System.Windows.Forms.Panel panel_MSI;
        private System.Windows.Forms.DataGrid dataGrid_MSI;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle_MSI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MSI_cod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MSI_cantitate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource_MSI;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle17;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn45;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn46;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn47;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle18;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn48;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn49;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn50;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle19;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn51;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn52;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle20;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn53;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn54;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn55;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle21;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle22;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn56;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn57;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn58;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle23;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn59;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn60;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn61;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle24;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn62;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn63;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle25;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn64;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn65;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn66;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle26;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle27;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn67;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn68;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn69;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle28;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn70;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn71;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn72;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle29;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn73;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn74;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle30;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn75;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn76;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn77;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle31;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle32;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn78;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn79;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn80;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle33;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn81;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn82;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn83;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle34;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn84;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn85;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle35;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn86;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn87;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn88;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle36;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle37;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn89;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn90;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn91;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle38;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn92;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn93;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn94;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle39;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn95;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn96;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle40;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn97;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn98;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn99;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle41;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle42;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn100;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn101;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn102;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle43;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn103;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn104;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn105;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle44;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn106;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn107;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle45;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn108;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn109;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn110;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle46;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn_real1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn_real2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn_real3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn_MSI1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn_MSI2;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle47;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn111;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn112;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn113;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle48;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn114;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn115;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn116;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle49;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn117;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn118;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle50;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn119;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn120;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn121;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle51;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn122;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn123;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle52;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn124;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn125;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn126;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle53;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn127;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn128;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn129;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle54;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn130;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn131;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle55;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn132;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn133;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn134;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle56;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn135;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn136;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle57;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn137;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn138;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn139;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle58;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn140;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn141;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn142;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle59;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn143;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn144;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle60;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn145;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn146;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn147;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle61;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn148;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn149;
    }
}

