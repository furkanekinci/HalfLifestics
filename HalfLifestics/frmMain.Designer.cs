namespace HalfLifestics
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.grd_Log = new DevExpress.XtraGrid.GridControl();
            this.grd_Log_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grd_Log_Col_Order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Log_Col_Killer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Log_Col_Killed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Log_Col_Gun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Log_Col_GunTR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChooseArchiveFolder = new System.Windows.Forms.Button();
            this.lbxGroupA = new DevExpress.XtraEditors.ListBoxControl();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lbxGroupB = new DevExpress.XtraEditors.ListBoxControl();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.grd_Actions = new DevExpress.XtraGrid.GridControl();
            this.grd_Actions_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grd_Actions_Col_Order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Actions_Col_Killer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Actions_Col_KillerWithPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Actions_Col_Killed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Actions_Col_KilledWithPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Actions_Col_Gun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Actions_Col_GunTR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Actions_Col_GroupAPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Actions_Col_GroupBPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_Actions_Col_Diff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCalculatePoint = new System.Windows.Forms.Button();
            this.lbxArchive = new DevExpress.XtraEditors.ListBoxControl();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbp_tabMain_Actions = new System.Windows.Forms.TabPage();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.tbp_tabMain_Graphic = new System.Windows.Forms.TabPage();
            this.chtActions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbp_tabMain_PlayerPerformance = new System.Windows.Forms.TabPage();
            this.lblPlayerPerformancePartSize = new System.Windows.Forms.Label();
            this.trkBar_PlayerPerformancePartSize = new System.Windows.Forms.TrackBar();
            this.chtPlayerPerformance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbPlayersForPerformance = new System.Windows.Forms.ComboBox();
            this.lblPlayersForPerformance = new System.Windows.Forms.Label();
            this.tbp_tabMain_ScoreBoard = new System.Windows.Forms.TabPage();
            this.chkScoreBoardKeepPosition = new System.Windows.Forms.CheckBox();
            this.chtScoreGroup2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtScoreGroup1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prgBar_ScoreBoard = new System.Windows.Forms.ProgressBar();
            this.grdScoreGroup2 = new System.Windows.Forms.DataGridView();
            this.grdScoreGroup1 = new System.Windows.Forms.DataGridView();
            this.lblScoreGroup2 = new System.Windows.Forms.Label();
            this.trkBar_ScoreBoard = new System.Windows.Forms.TrackBar();
            this.lblScoreGroup1 = new System.Windows.Forms.Label();
            this.tbp_tabMain_Statistics = new System.Windows.Forms.TabPage();
            this.grdUnluckyPlayers = new System.Windows.Forms.DataGridView();
            this.grdSerialKilleds = new System.Windows.Forms.DataGridView();
            this.lblUnluckyPlayers = new System.Windows.Forms.Label();
            this.grdSerialKillers = new System.Windows.Forms.DataGridView();
            this.lblFastKilleds = new System.Windows.Forms.Label();
            this.lblSerialKillers = new System.Windows.Forms.Label();
            this.btnNewSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Log_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbxGroupA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbxGroupB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Actions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Actions_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbxArchive)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tbp_tabMain_Actions.SuspendLayout();
            this.tbp_tabMain_Graphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtActions)).BeginInit();
            this.tbp_tabMain_PlayerPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBar_PlayerPerformancePartSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtPlayerPerformance)).BeginInit();
            this.tbp_tabMain_ScoreBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtScoreGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtScoreGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdScoreGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdScoreGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBar_ScoreBoard)).BeginInit();
            this.tbp_tabMain_Statistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnluckyPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSerialKilleds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSerialKillers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(154, 35);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(340, 229);
            this.txtLog.TabIndex = 0;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(151, 19);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(25, 13);
            this.lblLog.TabIndex = 1;
            this.lblLog.Text = "Log";
            // 
            // grd_Log
            // 
            this.grd_Log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grd_Log.Location = new System.Drawing.Point(15, 270);
            this.grd_Log.MainView = this.grd_Log_View;
            this.grd_Log.Name = "grd_Log";
            this.grd_Log.Size = new System.Drawing.Size(651, 502);
            this.grd_Log.TabIndex = 2;
            this.grd_Log.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_Log_View});
            // 
            // grd_Log_View
            // 
            this.grd_Log_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grd_Log_Col_Order,
            this.grd_Log_Col_Killer,
            this.grd_Log_Col_Killed,
            this.grd_Log_Col_Gun,
            this.grd_Log_Col_GunTR});
            this.grd_Log_View.GridControl = this.grd_Log;
            this.grd_Log_View.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Order", null, "")});
            this.grd_Log_View.Name = "grd_Log_View";
            this.grd_Log_View.OptionsBehavior.Editable = false;
            this.grd_Log_View.OptionsView.ShowFooter = true;
            // 
            // grd_Log_Col_Order
            // 
            this.grd_Log_Col_Order.Caption = "Order";
            this.grd_Log_Col_Order.FieldName = "Order";
            this.grd_Log_Col_Order.Name = "grd_Log_Col_Order";
            // 
            // grd_Log_Col_Killer
            // 
            this.grd_Log_Col_Killer.Caption = "Killer";
            this.grd_Log_Col_Killer.FieldName = "Killer";
            this.grd_Log_Col_Killer.Name = "grd_Log_Col_Killer";
            this.grd_Log_Col_Killer.Visible = true;
            this.grd_Log_Col_Killer.VisibleIndex = 0;
            // 
            // grd_Log_Col_Killed
            // 
            this.grd_Log_Col_Killed.Caption = "Killed";
            this.grd_Log_Col_Killed.FieldName = "Killed";
            this.grd_Log_Col_Killed.Name = "grd_Log_Col_Killed";
            this.grd_Log_Col_Killed.Visible = true;
            this.grd_Log_Col_Killed.VisibleIndex = 1;
            // 
            // grd_Log_Col_Gun
            // 
            this.grd_Log_Col_Gun.Caption = "Gun";
            this.grd_Log_Col_Gun.FieldName = "Gun";
            this.grd_Log_Col_Gun.Name = "grd_Log_Col_Gun";
            // 
            // grd_Log_Col_GunTR
            // 
            this.grd_Log_Col_GunTR.Caption = "Gun";
            this.grd_Log_Col_GunTR.FieldName = "GunTR";
            this.grd_Log_Col_GunTR.Name = "grd_Log_Col_GunTR";
            this.grd_Log_Col_GunTR.Visible = true;
            this.grd_Log_Col_GunTR.VisibleIndex = 2;
            // 
            // btnChooseArchiveFolder
            // 
            this.btnChooseArchiveFolder.Location = new System.Drawing.Point(15, 6);
            this.btnChooseArchiveFolder.Name = "btnChooseArchiveFolder";
            this.btnChooseArchiveFolder.Size = new System.Drawing.Size(133, 23);
            this.btnChooseArchiveFolder.TabIndex = 3;
            this.btnChooseArchiveFolder.Text = "Choose Archive";
            this.btnChooseArchiveFolder.UseVisualStyleBackColor = true;
            this.btnChooseArchiveFolder.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // lbxGroupA
            // 
            this.lbxGroupA.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard;
            this.lbxGroupA.Location = new System.Drawing.Point(520, 35);
            this.lbxGroupA.Name = "lbxGroupA";
            this.lbxGroupA.Size = new System.Drawing.Size(120, 111);
            this.lbxGroupA.TabIndex = 4;
            this.lbxGroupA.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxGroupA_MouseDoubleClick);
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Location = new System.Drawing.Point(517, 15);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(41, 13);
            this.lblPlayers.TabIndex = 1;
            this.lblPlayers.Text = "Players";
            // 
            // lbxGroupB
            // 
            this.lbxGroupB.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard;
            this.lbxGroupB.Location = new System.Drawing.Point(520, 152);
            this.lbxGroupB.Name = "lbxGroupB";
            this.lbxGroupB.Size = new System.Drawing.Size(120, 112);
            this.lbxGroupB.TabIndex = 4;
            this.lbxGroupB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxGroupB_MouseDoubleClick);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblA.Location = new System.Drawing.Point(500, 38);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(15, 13);
            this.lblA.TabIndex = 5;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblB.Location = new System.Drawing.Point(500, 154);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(15, 13);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "B";
            // 
            // grd_Actions
            // 
            this.grd_Actions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Actions.Location = new System.Drawing.Point(3, 3);
            this.grd_Actions.MainView = this.grd_Actions_View;
            this.grd_Actions.Name = "grd_Actions";
            this.grd_Actions.Size = new System.Drawing.Size(723, 711);
            this.grd_Actions.TabIndex = 6;
            this.grd_Actions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_Actions_View});
            // 
            // grd_Actions_View
            // 
            this.grd_Actions_View.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grd_Actions_View.Appearance.EvenRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grd_Actions_View.Appearance.EvenRow.Options.UseBackColor = true;
            this.grd_Actions_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grd_Actions_Col_Order,
            this.grd_Actions_Col_Killer,
            this.grd_Actions_Col_KillerWithPoint,
            this.grd_Actions_Col_Killed,
            this.grd_Actions_Col_KilledWithPoint,
            this.grd_Actions_Col_Gun,
            this.grd_Actions_Col_GunTR,
            this.grd_Actions_Col_GroupAPoint,
            this.grd_Actions_Col_GroupBPoint,
            this.grd_Actions_Col_Diff});
            this.grd_Actions_View.GridControl = this.grd_Actions;
            this.grd_Actions_View.Name = "grd_Actions_View";
            this.grd_Actions_View.OptionsBehavior.Editable = false;
            this.grd_Actions_View.OptionsCustomization.AllowGroup = false;
            this.grd_Actions_View.OptionsView.EnableAppearanceEvenRow = true;
            this.grd_Actions_View.OptionsView.ShowGroupPanel = false;
            // 
            // grd_Actions_Col_Order
            // 
            this.grd_Actions_Col_Order.Caption = "Order";
            this.grd_Actions_Col_Order.FieldName = "Order";
            this.grd_Actions_Col_Order.MaxWidth = 50;
            this.grd_Actions_Col_Order.MinWidth = 50;
            this.grd_Actions_Col_Order.Name = "grd_Actions_Col_Order";
            this.grd_Actions_Col_Order.Visible = true;
            this.grd_Actions_Col_Order.VisibleIndex = 0;
            this.grd_Actions_Col_Order.Width = 50;
            // 
            // grd_Actions_Col_Killer
            // 
            this.grd_Actions_Col_Killer.Caption = "Killer";
            this.grd_Actions_Col_Killer.FieldName = "Killer";
            this.grd_Actions_Col_Killer.MinWidth = 50;
            this.grd_Actions_Col_Killer.Name = "grd_Actions_Col_Killer";
            this.grd_Actions_Col_Killer.Width = 100;
            // 
            // grd_Actions_Col_KillerWithPoint
            // 
            this.grd_Actions_Col_KillerWithPoint.Caption = "Killer";
            this.grd_Actions_Col_KillerWithPoint.FieldName = "KillerWithPoint";
            this.grd_Actions_Col_KillerWithPoint.MinWidth = 50;
            this.grd_Actions_Col_KillerWithPoint.Name = "grd_Actions_Col_KillerWithPoint";
            this.grd_Actions_Col_KillerWithPoint.Visible = true;
            this.grd_Actions_Col_KillerWithPoint.VisibleIndex = 1;
            this.grd_Actions_Col_KillerWithPoint.Width = 85;
            // 
            // grd_Actions_Col_Killed
            // 
            this.grd_Actions_Col_Killed.Caption = "Killed";
            this.grd_Actions_Col_Killed.FieldName = "Killed";
            this.grd_Actions_Col_Killed.MinWidth = 50;
            this.grd_Actions_Col_Killed.Name = "grd_Actions_Col_Killed";
            this.grd_Actions_Col_Killed.Width = 100;
            // 
            // grd_Actions_Col_KilledWithPoint
            // 
            this.grd_Actions_Col_KilledWithPoint.Caption = "Killed";
            this.grd_Actions_Col_KilledWithPoint.FieldName = "KilledWithPoint";
            this.grd_Actions_Col_KilledWithPoint.MinWidth = 50;
            this.grd_Actions_Col_KilledWithPoint.Name = "grd_Actions_Col_KilledWithPoint";
            this.grd_Actions_Col_KilledWithPoint.Visible = true;
            this.grd_Actions_Col_KilledWithPoint.VisibleIndex = 2;
            this.grd_Actions_Col_KilledWithPoint.Width = 100;
            // 
            // grd_Actions_Col_Gun
            // 
            this.grd_Actions_Col_Gun.Caption = "Gun";
            this.grd_Actions_Col_Gun.FieldName = "Gun";
            this.grd_Actions_Col_Gun.MinWidth = 50;
            this.grd_Actions_Col_Gun.Name = "grd_Actions_Col_Gun";
            this.grd_Actions_Col_Gun.Width = 100;
            // 
            // grd_Actions_Col_GunTR
            // 
            this.grd_Actions_Col_GunTR.Caption = "Gun";
            this.grd_Actions_Col_GunTR.FieldName = "GunTR";
            this.grd_Actions_Col_GunTR.Name = "grd_Actions_Col_GunTR";
            this.grd_Actions_Col_GunTR.Visible = true;
            this.grd_Actions_Col_GunTR.VisibleIndex = 3;
            this.grd_Actions_Col_GunTR.Width = 20;
            // 
            // grd_Actions_Col_GroupAPoint
            // 
            this.grd_Actions_Col_GroupAPoint.AppearanceCell.Options.UseTextOptions = true;
            this.grd_Actions_Col_GroupAPoint.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grd_Actions_Col_GroupAPoint.Caption = "A Point";
            this.grd_Actions_Col_GroupAPoint.FieldName = "APoint";
            this.grd_Actions_Col_GroupAPoint.MaxWidth = 50;
            this.grd_Actions_Col_GroupAPoint.MinWidth = 50;
            this.grd_Actions_Col_GroupAPoint.Name = "grd_Actions_Col_GroupAPoint";
            this.grd_Actions_Col_GroupAPoint.Visible = true;
            this.grd_Actions_Col_GroupAPoint.VisibleIndex = 4;
            this.grd_Actions_Col_GroupAPoint.Width = 50;
            // 
            // grd_Actions_Col_GroupBPoint
            // 
            this.grd_Actions_Col_GroupBPoint.AppearanceCell.Options.UseTextOptions = true;
            this.grd_Actions_Col_GroupBPoint.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grd_Actions_Col_GroupBPoint.Caption = "B Point";
            this.grd_Actions_Col_GroupBPoint.FieldName = "BPoint";
            this.grd_Actions_Col_GroupBPoint.MaxWidth = 50;
            this.grd_Actions_Col_GroupBPoint.MinWidth = 50;
            this.grd_Actions_Col_GroupBPoint.Name = "grd_Actions_Col_GroupBPoint";
            this.grd_Actions_Col_GroupBPoint.Visible = true;
            this.grd_Actions_Col_GroupBPoint.VisibleIndex = 6;
            this.grd_Actions_Col_GroupBPoint.Width = 50;
            // 
            // grd_Actions_Col_Diff
            // 
            this.grd_Actions_Col_Diff.AppearanceCell.Options.UseTextOptions = true;
            this.grd_Actions_Col_Diff.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grd_Actions_Col_Diff.Caption = "Diff";
            this.grd_Actions_Col_Diff.FieldName = "Diff";
            this.grd_Actions_Col_Diff.MaxWidth = 300;
            this.grd_Actions_Col_Diff.MinWidth = 300;
            this.grd_Actions_Col_Diff.Name = "grd_Actions_Col_Diff";
            this.grd_Actions_Col_Diff.Visible = true;
            this.grd_Actions_Col_Diff.VisibleIndex = 5;
            this.grd_Actions_Col_Diff.Width = 300;
            // 
            // btnCalculatePoint
            // 
            this.btnCalculatePoint.Location = new System.Drawing.Point(646, 35);
            this.btnCalculatePoint.Name = "btnCalculatePoint";
            this.btnCalculatePoint.Size = new System.Drawing.Size(20, 229);
            this.btnCalculatePoint.TabIndex = 7;
            this.btnCalculatePoint.Text = ">";
            this.btnCalculatePoint.UseVisualStyleBackColor = true;
            this.btnCalculatePoint.Click += new System.EventHandler(this.btnCalculatePoint_Click);
            // 
            // lbxArchive
            // 
            this.lbxArchive.Location = new System.Drawing.Point(15, 35);
            this.lbxArchive.Name = "lbxArchive";
            this.lbxArchive.Size = new System.Drawing.Size(133, 229);
            this.lbxArchive.TabIndex = 4;
            this.lbxArchive.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxArchive_MouseDoubleClick);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tbp_tabMain_Actions);
            this.tabMain.Controls.Add(this.tbp_tabMain_Graphic);
            this.tabMain.Controls.Add(this.tbp_tabMain_PlayerPerformance);
            this.tabMain.Controls.Add(this.tbp_tabMain_ScoreBoard);
            this.tabMain.Controls.Add(this.tbp_tabMain_Statistics);
            this.tabMain.Location = new System.Drawing.Point(672, 6);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(737, 766);
            this.tabMain.TabIndex = 9;
            // 
            // tbp_tabMain_Actions
            // 
            this.tbp_tabMain_Actions.Controls.Add(this.grd_Actions);
            this.tbp_tabMain_Actions.Controls.Add(this.btnExport);
            this.tbp_tabMain_Actions.Location = new System.Drawing.Point(4, 22);
            this.tbp_tabMain_Actions.Name = "tbp_tabMain_Actions";
            this.tbp_tabMain_Actions.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_tabMain_Actions.Size = new System.Drawing.Size(729, 740);
            this.tbp_tabMain_Actions.TabIndex = 0;
            this.tbp_tabMain_Actions.Text = "Actions";
            this.tbp_tabMain_Actions.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExport.Location = new System.Drawing.Point(3, 714);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(723, 23);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tbp_tabMain_Graphic
            // 
            this.tbp_tabMain_Graphic.Controls.Add(this.chtActions);
            this.tbp_tabMain_Graphic.Location = new System.Drawing.Point(4, 22);
            this.tbp_tabMain_Graphic.Name = "tbp_tabMain_Graphic";
            this.tbp_tabMain_Graphic.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_tabMain_Graphic.Size = new System.Drawing.Size(729, 740);
            this.tbp_tabMain_Graphic.TabIndex = 1;
            this.tbp_tabMain_Graphic.Text = "Graphic";
            this.tbp_tabMain_Graphic.UseVisualStyleBackColor = true;
            // 
            // chtActions
            // 
            chartArea1.Name = "ChartArea1";
            this.chtActions.ChartAreas.Add(chartArea1);
            this.chtActions.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chtActions.Legends.Add(legend1);
            this.chtActions.Location = new System.Drawing.Point(3, 3);
            this.chtActions.Name = "chtActions";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "A";
            series1.YValueMembers = "APoint";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "B";
            series2.YValueMembers = "BPoint";
            this.chtActions.Series.Add(series1);
            this.chtActions.Series.Add(series2);
            this.chtActions.Size = new System.Drawing.Size(723, 734);
            this.chtActions.TabIndex = 0;
            this.chtActions.Text = "chart1";
            // 
            // tbp_tabMain_PlayerPerformance
            // 
            this.tbp_tabMain_PlayerPerformance.Controls.Add(this.lblPlayerPerformancePartSize);
            this.tbp_tabMain_PlayerPerformance.Controls.Add(this.trkBar_PlayerPerformancePartSize);
            this.tbp_tabMain_PlayerPerformance.Controls.Add(this.chtPlayerPerformance);
            this.tbp_tabMain_PlayerPerformance.Controls.Add(this.cmbPlayersForPerformance);
            this.tbp_tabMain_PlayerPerformance.Controls.Add(this.lblPlayersForPerformance);
            this.tbp_tabMain_PlayerPerformance.Location = new System.Drawing.Point(4, 22);
            this.tbp_tabMain_PlayerPerformance.Name = "tbp_tabMain_PlayerPerformance";
            this.tbp_tabMain_PlayerPerformance.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_tabMain_PlayerPerformance.Size = new System.Drawing.Size(729, 740);
            this.tbp_tabMain_PlayerPerformance.TabIndex = 2;
            this.tbp_tabMain_PlayerPerformance.Text = "Player Performance";
            this.tbp_tabMain_PlayerPerformance.UseVisualStyleBackColor = true;
            // 
            // lblPlayerPerformancePartSize
            // 
            this.lblPlayerPerformancePartSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlayerPerformancePartSize.AutoSize = true;
            this.lblPlayerPerformancePartSize.BackColor = System.Drawing.SystemColors.Control;
            this.lblPlayerPerformancePartSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayerPerformancePartSize.Location = new System.Drawing.Point(6, 591);
            this.lblPlayerPerformancePartSize.Name = "lblPlayerPerformancePartSize";
            this.lblPlayerPerformancePartSize.Size = new System.Drawing.Size(11, 13);
            this.lblPlayerPerformancePartSize.TabIndex = 14;
            this.lblPlayerPerformancePartSize.Text = "-";
            // 
            // trkBar_PlayerPerformancePartSize
            // 
            this.trkBar_PlayerPerformancePartSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkBar_PlayerPerformancePartSize.LargeChange = 1;
            this.trkBar_PlayerPerformancePartSize.Location = new System.Drawing.Point(6, 559);
            this.trkBar_PlayerPerformancePartSize.Name = "trkBar_PlayerPerformancePartSize";
            this.trkBar_PlayerPerformancePartSize.Size = new System.Drawing.Size(617, 45);
            this.trkBar_PlayerPerformancePartSize.TabIndex = 13;
            this.trkBar_PlayerPerformancePartSize.Scroll += new System.EventHandler(this.trkBar_PlayerPerformancePartSize_Scroll);
            // 
            // chtPlayerPerformance
            // 
            this.chtPlayerPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chtPlayerPerformance.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtPlayerPerformance.Legends.Add(legend2);
            this.chtPlayerPerformance.Location = new System.Drawing.Point(3, 37);
            this.chtPlayerPerformance.Name = "chtPlayerPerformance";
            this.chtPlayerPerformance.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Killed";
            series3.YValueMembers = "Killed";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Legend = "Legend1";
            series4.Name = "Killer";
            series4.YValueMembers = "Killer";
            this.chtPlayerPerformance.Series.Add(series3);
            this.chtPlayerPerformance.Series.Add(series4);
            this.chtPlayerPerformance.Size = new System.Drawing.Size(623, 516);
            this.chtPlayerPerformance.TabIndex = 12;
            this.chtPlayerPerformance.Text = "chart1";
            // 
            // cmbPlayersForPerformance
            // 
            this.cmbPlayersForPerformance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayersForPerformance.FormattingEnabled = true;
            this.cmbPlayersForPerformance.Location = new System.Drawing.Point(53, 10);
            this.cmbPlayersForPerformance.Name = "cmbPlayersForPerformance";
            this.cmbPlayersForPerformance.Size = new System.Drawing.Size(151, 21);
            this.cmbPlayersForPerformance.TabIndex = 11;
            this.cmbPlayersForPerformance.SelectedIndexChanged += new System.EventHandler(this.cmbPlayersForPerformance_SelectedIndexChanged);
            // 
            // lblPlayersForPerformance
            // 
            this.lblPlayersForPerformance.AutoSize = true;
            this.lblPlayersForPerformance.Location = new System.Drawing.Point(6, 13);
            this.lblPlayersForPerformance.Name = "lblPlayersForPerformance";
            this.lblPlayersForPerformance.Size = new System.Drawing.Size(41, 13);
            this.lblPlayersForPerformance.TabIndex = 10;
            this.lblPlayersForPerformance.Text = "Players";
            // 
            // tbp_tabMain_ScoreBoard
            // 
            this.tbp_tabMain_ScoreBoard.Controls.Add(this.chkScoreBoardKeepPosition);
            this.tbp_tabMain_ScoreBoard.Controls.Add(this.chtScoreGroup2);
            this.tbp_tabMain_ScoreBoard.Controls.Add(this.chtScoreGroup1);
            this.tbp_tabMain_ScoreBoard.Controls.Add(this.prgBar_ScoreBoard);
            this.tbp_tabMain_ScoreBoard.Controls.Add(this.grdScoreGroup2);
            this.tbp_tabMain_ScoreBoard.Controls.Add(this.grdScoreGroup1);
            this.tbp_tabMain_ScoreBoard.Controls.Add(this.lblScoreGroup2);
            this.tbp_tabMain_ScoreBoard.Controls.Add(this.trkBar_ScoreBoard);
            this.tbp_tabMain_ScoreBoard.Controls.Add(this.lblScoreGroup1);
            this.tbp_tabMain_ScoreBoard.Location = new System.Drawing.Point(4, 22);
            this.tbp_tabMain_ScoreBoard.Name = "tbp_tabMain_ScoreBoard";
            this.tbp_tabMain_ScoreBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_tabMain_ScoreBoard.Size = new System.Drawing.Size(729, 740);
            this.tbp_tabMain_ScoreBoard.TabIndex = 3;
            this.tbp_tabMain_ScoreBoard.Text = "Score Board";
            this.tbp_tabMain_ScoreBoard.UseVisualStyleBackColor = true;
            // 
            // chkScoreBoardKeepPosition
            // 
            this.chkScoreBoardKeepPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkScoreBoardKeepPosition.AutoSize = true;
            this.chkScoreBoardKeepPosition.Checked = true;
            this.chkScoreBoardKeepPosition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScoreBoardKeepPosition.Location = new System.Drawing.Point(527, 8);
            this.chkScoreBoardKeepPosition.Name = "chkScoreBoardKeepPosition";
            this.chkScoreBoardKeepPosition.Size = new System.Drawing.Size(96, 17);
            this.chkScoreBoardKeepPosition.TabIndex = 18;
            this.chkScoreBoardKeepPosition.Text = "Keep Positions";
            this.chkScoreBoardKeepPosition.UseVisualStyleBackColor = true;
            // 
            // chtScoreGroup2
            // 
            this.chtScoreGroup2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chtScoreGroup2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtScoreGroup2.Legends.Add(legend3);
            this.chtScoreGroup2.Location = new System.Drawing.Point(9, 461);
            this.chtScoreGroup2.Name = "chtScoreGroup2";
            this.chtScoreGroup2.Size = new System.Drawing.Size(617, 184);
            this.chtScoreGroup2.TabIndex = 17;
            this.chtScoreGroup2.Text = "chart1";
            // 
            // chtScoreGroup1
            // 
            this.chtScoreGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chtScoreGroup1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtScoreGroup1.Legends.Add(legend4);
            this.chtScoreGroup1.Location = new System.Drawing.Point(9, 138);
            this.chtScoreGroup1.Name = "chtScoreGroup1";
            this.chtScoreGroup1.Size = new System.Drawing.Size(617, 184);
            this.chtScoreGroup1.TabIndex = 17;
            this.chtScoreGroup1.Text = "chart1";
            // 
            // prgBar_ScoreBoard
            // 
            this.prgBar_ScoreBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgBar_ScoreBoard.Location = new System.Drawing.Point(9, 660);
            this.prgBar_ScoreBoard.Name = "prgBar_ScoreBoard";
            this.prgBar_ScoreBoard.Size = new System.Drawing.Size(614, 23);
            this.prgBar_ScoreBoard.TabIndex = 16;
            // 
            // grdScoreGroup2
            // 
            this.grdScoreGroup2.AllowUserToAddRows = false;
            this.grdScoreGroup2.AllowUserToDeleteRows = false;
            this.grdScoreGroup2.AllowUserToResizeColumns = false;
            this.grdScoreGroup2.AllowUserToResizeRows = false;
            this.grdScoreGroup2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdScoreGroup2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdScoreGroup2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdScoreGroup2.ColumnHeadersVisible = false;
            this.grdScoreGroup2.Location = new System.Drawing.Point(9, 351);
            this.grdScoreGroup2.Name = "grdScoreGroup2";
            this.grdScoreGroup2.RowHeadersVisible = false;
            this.grdScoreGroup2.Size = new System.Drawing.Size(617, 104);
            this.grdScoreGroup2.TabIndex = 15;
            // 
            // grdScoreGroup1
            // 
            this.grdScoreGroup1.AllowUserToAddRows = false;
            this.grdScoreGroup1.AllowUserToDeleteRows = false;
            this.grdScoreGroup1.AllowUserToResizeColumns = false;
            this.grdScoreGroup1.AllowUserToResizeRows = false;
            this.grdScoreGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdScoreGroup1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdScoreGroup1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdScoreGroup1.ColumnHeadersVisible = false;
            this.grdScoreGroup1.Location = new System.Drawing.Point(9, 28);
            this.grdScoreGroup1.Name = "grdScoreGroup1";
            this.grdScoreGroup1.RowHeadersVisible = false;
            this.grdScoreGroup1.Size = new System.Drawing.Size(617, 104);
            this.grdScoreGroup1.TabIndex = 15;
            // 
            // lblScoreGroup2
            // 
            this.lblScoreGroup2.AutoSize = true;
            this.lblScoreGroup2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScoreGroup2.Location = new System.Drawing.Point(6, 335);
            this.lblScoreGroup2.Name = "lblScoreGroup2";
            this.lblScoreGroup2.Size = new System.Drawing.Size(15, 13);
            this.lblScoreGroup2.TabIndex = 5;
            this.lblScoreGroup2.Text = "B";
            // 
            // trkBar_ScoreBoard
            // 
            this.trkBar_ScoreBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkBar_ScoreBoard.LargeChange = 1;
            this.trkBar_ScoreBoard.Location = new System.Drawing.Point(6, 689);
            this.trkBar_ScoreBoard.Name = "trkBar_ScoreBoard";
            this.trkBar_ScoreBoard.Size = new System.Drawing.Size(617, 45);
            this.trkBar_ScoreBoard.TabIndex = 14;
            this.trkBar_ScoreBoard.Scroll += new System.EventHandler(this.trkBar_ScoreBoard_Scroll);
            // 
            // lblScoreGroup1
            // 
            this.lblScoreGroup1.AutoSize = true;
            this.lblScoreGroup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScoreGroup1.Location = new System.Drawing.Point(6, 12);
            this.lblScoreGroup1.Name = "lblScoreGroup1";
            this.lblScoreGroup1.Size = new System.Drawing.Size(15, 13);
            this.lblScoreGroup1.TabIndex = 5;
            this.lblScoreGroup1.Text = "A";
            // 
            // tbp_tabMain_Statistics
            // 
            this.tbp_tabMain_Statistics.Controls.Add(this.grdUnluckyPlayers);
            this.tbp_tabMain_Statistics.Controls.Add(this.grdSerialKilleds);
            this.tbp_tabMain_Statistics.Controls.Add(this.lblUnluckyPlayers);
            this.tbp_tabMain_Statistics.Controls.Add(this.grdSerialKillers);
            this.tbp_tabMain_Statistics.Controls.Add(this.lblFastKilleds);
            this.tbp_tabMain_Statistics.Controls.Add(this.lblSerialKillers);
            this.tbp_tabMain_Statistics.Location = new System.Drawing.Point(4, 22);
            this.tbp_tabMain_Statistics.Name = "tbp_tabMain_Statistics";
            this.tbp_tabMain_Statistics.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_tabMain_Statistics.Size = new System.Drawing.Size(729, 740);
            this.tbp_tabMain_Statistics.TabIndex = 4;
            this.tbp_tabMain_Statistics.Text = "Statistics";
            this.tbp_tabMain_Statistics.UseVisualStyleBackColor = true;
            // 
            // grdUnluckyPlayers
            // 
            this.grdUnluckyPlayers.AllowUserToAddRows = false;
            this.grdUnluckyPlayers.AllowUserToDeleteRows = false;
            this.grdUnluckyPlayers.AllowUserToResizeColumns = false;
            this.grdUnluckyPlayers.AllowUserToResizeRows = false;
            this.grdUnluckyPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUnluckyPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnluckyPlayers.ColumnHeadersVisible = false;
            this.grdUnluckyPlayers.Location = new System.Drawing.Point(481, 23);
            this.grdUnluckyPlayers.Name = "grdUnluckyPlayers";
            this.grdUnluckyPlayers.RowHeadersVisible = false;
            this.grdUnluckyPlayers.Size = new System.Drawing.Size(230, 169);
            this.grdUnluckyPlayers.TabIndex = 16;
            // 
            // grdSerialKilleds
            // 
            this.grdSerialKilleds.AllowUserToAddRows = false;
            this.grdSerialKilleds.AllowUserToDeleteRows = false;
            this.grdSerialKilleds.AllowUserToResizeColumns = false;
            this.grdSerialKilleds.AllowUserToResizeRows = false;
            this.grdSerialKilleds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSerialKilleds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSerialKilleds.ColumnHeadersVisible = false;
            this.grdSerialKilleds.Location = new System.Drawing.Point(245, 23);
            this.grdSerialKilleds.Name = "grdSerialKilleds";
            this.grdSerialKilleds.RowHeadersVisible = false;
            this.grdSerialKilleds.Size = new System.Drawing.Size(230, 169);
            this.grdSerialKilleds.TabIndex = 16;
            // 
            // lblUnluckyPlayers
            // 
            this.lblUnluckyPlayers.AutoSize = true;
            this.lblUnluckyPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnluckyPlayers.Location = new System.Drawing.Point(478, 7);
            this.lblUnluckyPlayers.Name = "lblUnluckyPlayers";
            this.lblUnluckyPlayers.Size = new System.Drawing.Size(98, 13);
            this.lblUnluckyPlayers.TabIndex = 5;
            this.lblUnluckyPlayers.Text = "Unlucky Players";
            // 
            // grdSerialKillers
            // 
            this.grdSerialKillers.AllowUserToAddRows = false;
            this.grdSerialKillers.AllowUserToDeleteRows = false;
            this.grdSerialKillers.AllowUserToResizeColumns = false;
            this.grdSerialKillers.AllowUserToResizeRows = false;
            this.grdSerialKillers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSerialKillers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSerialKillers.ColumnHeadersVisible = false;
            this.grdSerialKillers.Location = new System.Drawing.Point(9, 23);
            this.grdSerialKillers.Name = "grdSerialKillers";
            this.grdSerialKillers.RowHeadersVisible = false;
            this.grdSerialKillers.Size = new System.Drawing.Size(230, 169);
            this.grdSerialKillers.TabIndex = 16;
            // 
            // lblFastKilleds
            // 
            this.lblFastKilleds.AutoSize = true;
            this.lblFastKilleds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFastKilleds.Location = new System.Drawing.Point(242, 7);
            this.lblFastKilleds.Name = "lblFastKilleds";
            this.lblFastKilleds.Size = new System.Drawing.Size(72, 13);
            this.lblFastKilleds.TabIndex = 5;
            this.lblFastKilleds.Text = "Fast Killeds";
            // 
            // lblSerialKillers
            // 
            this.lblSerialKillers.AutoSize = true;
            this.lblSerialKillers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSerialKillers.Location = new System.Drawing.Point(6, 7);
            this.lblSerialKillers.Name = "lblSerialKillers";
            this.lblSerialKillers.Size = new System.Drawing.Size(77, 13);
            this.lblSerialKillers.TabIndex = 5;
            this.lblSerialKillers.Text = "Serial Killers";
            // 
            // btnNewSave
            // 
            this.btnNewSave.Location = new System.Drawing.Point(417, 6);
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(77, 23);
            this.btnNewSave.TabIndex = 3;
            this.btnNewSave.Text = "New";
            this.btnNewSave.UseVisualStyleBackColor = true;
            this.btnNewSave.Click += new System.EventHandler(this.btnNewSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 784);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnCalculatePoint);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lbxGroupB);
            this.Controls.Add(this.lbxArchive);
            this.Controls.Add(this.lbxGroupA);
            this.Controls.Add(this.btnNewSave);
            this.Controls.Add(this.btnChooseArchiveFolder);
            this.Controls.Add(this.grd_Log);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HalfLifestics";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Log_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbxGroupA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbxGroupB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Actions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Actions_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbxArchive)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tbp_tabMain_Actions.ResumeLayout(false);
            this.tbp_tabMain_Graphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtActions)).EndInit();
            this.tbp_tabMain_PlayerPerformance.ResumeLayout(false);
            this.tbp_tabMain_PlayerPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBar_PlayerPerformancePartSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtPlayerPerformance)).EndInit();
            this.tbp_tabMain_ScoreBoard.ResumeLayout(false);
            this.tbp_tabMain_ScoreBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtScoreGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtScoreGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdScoreGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdScoreGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBar_ScoreBoard)).EndInit();
            this.tbp_tabMain_Statistics.ResumeLayout(false);
            this.tbp_tabMain_Statistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnluckyPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSerialKilleds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSerialKillers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblLog;
        private DevExpress.XtraGrid.GridControl grd_Log;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_Log_View;
        private System.Windows.Forms.Button btnChooseArchiveFolder;
        private DevExpress.XtraEditors.ListBoxControl lbxGroupA;
        private System.Windows.Forms.Label lblPlayers;
        private DevExpress.XtraEditors.ListBoxControl lbxGroupB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private DevExpress.XtraGrid.GridControl grd_Actions;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_Actions_View;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Actions_Col_Order;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Actions_Col_Killer;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Actions_Col_Killed;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Actions_Col_GroupAPoint;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Actions_Col_GroupBPoint;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Actions_Col_Gun;
        private System.Windows.Forms.Button btnCalculatePoint;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Actions_Col_Diff;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Log_Col_Order;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Log_Col_Killer;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Log_Col_Killed;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Log_Col_Gun;
        private DevExpress.XtraEditors.ListBoxControl lbxArchive;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbp_tabMain_Actions;
        private System.Windows.Forms.TabPage tbp_tabMain_Graphic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtActions;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Log_Col_GunTR;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Actions_Col_GunTR;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Actions_Col_KillerWithPoint;
        private DevExpress.XtraGrid.Columns.GridColumn grd_Actions_Col_KilledWithPoint;
        private System.Windows.Forms.TabPage tbp_tabMain_PlayerPerformance;
        private System.Windows.Forms.Label lblPlayersForPerformance;
        private System.Windows.Forms.ComboBox cmbPlayersForPerformance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtPlayerPerformance;
        private System.Windows.Forms.TrackBar trkBar_PlayerPerformancePartSize;
        private System.Windows.Forms.Label lblPlayerPerformancePartSize;
        private System.Windows.Forms.TabPage tbp_tabMain_ScoreBoard;
        private System.Windows.Forms.TrackBar trkBar_ScoreBoard;
        private System.Windows.Forms.DataGridView grdScoreGroup2;
        private System.Windows.Forms.DataGridView grdScoreGroup1;
        private System.Windows.Forms.Label lblScoreGroup2;
        private System.Windows.Forms.Label lblScoreGroup1;
        private System.Windows.Forms.ProgressBar prgBar_ScoreBoard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtScoreGroup1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtScoreGroup2;
        private System.Windows.Forms.CheckBox chkScoreBoardKeepPosition;
        private System.Windows.Forms.TabPage tbp_tabMain_Statistics;
        private System.Windows.Forms.DataGridView grdSerialKillers;
        private System.Windows.Forms.Label lblSerialKillers;
        private System.Windows.Forms.DataGridView grdSerialKilleds;
        private System.Windows.Forms.Label lblFastKilleds;
        private System.Windows.Forms.DataGridView grdUnluckyPlayers;
        private System.Windows.Forms.Label lblUnluckyPlayers;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private System.Windows.Forms.Button btnNewSave;
    }
}

