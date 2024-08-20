﻿namespace FredOraclePostgreSQLDataCompare
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.enregistrersousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aperçuavantimpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.sélectionnertoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.personnaliserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
      this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sommaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tabControlMain = new System.Windows.Forms.TabControl();
      this.tabPageConnection = new System.Windows.Forms.TabPage();
      this.buttonRefreshTarget = new System.Windows.Forms.Button();
      this.buttonRefreshSource = new System.Windows.Forms.Button();
      this.buttonCopyDatabaseName = new System.Windows.Forms.Button();
      this.buttonCopyUserName = new System.Windows.Forms.Button();
      this.textBoxTargetServer = new System.Windows.Forms.TextBox();
      this.textBoxSourceServer = new System.Windows.Forms.TextBox();
      this.textBoxDatabaseNameTarget = new System.Windows.Forms.TextBox();
      this.labelDatabaseNameTarget = new System.Windows.Forms.Label();
      this.textBoxDatabaseNameSource = new System.Windows.Forms.TextBox();
      this.labelDatabaseNameSource = new System.Windows.Forms.Label();
      this.buttonTestconnectionTarget = new System.Windows.Forms.Button();
      this.buttonTestConnectionSource = new System.Windows.Forms.Button();
      this.textBoxTargetPort = new System.Windows.Forms.TextBox();
      this.textBoxSourcePort = new System.Windows.Forms.TextBox();
      this.labelTargetPort = new System.Windows.Forms.Label();
      this.labelSourcePort = new System.Windows.Forms.Label();
      this.buttonCopyServerName = new System.Windows.Forms.Button();
      this.buttonCopyPassword = new System.Windows.Forms.Button();
      this.buttonCompareCompareNow = new System.Windows.Forms.Button();
      this.buttonTargetCreate = new System.Windows.Forms.Button();
      this.buttonTargetRefresh = new System.Windows.Forms.Button();
      this.labelTargetDatabase = new System.Windows.Forms.Label();
      this.comboBoxTargetDatabase = new System.Windows.Forms.ComboBox();
      this.checkBoxTargetRememberCredentials = new System.Windows.Forms.CheckBox();
      this.textBoxTargetPassword = new System.Windows.Forms.TextBox();
      this.textBoxTargetName = new System.Windows.Forms.TextBox();
      this.labelTargetPassword = new System.Windows.Forms.Label();
      this.labelTargetUserName = new System.Windows.Forms.Label();
      this.comboBoxTargetSchema = new System.Windows.Forms.ComboBox();
      this.labelTargetSchema = new System.Windows.Forms.Label();
      this.labelTargetServer = new System.Windows.Forms.Label();
      this.labelTargetOperation = new System.Windows.Forms.Label();
      this.buttonSourceCreate = new System.Windows.Forms.Button();
      this.buttonSourceRefresh = new System.Windows.Forms.Button();
      this.labelSourceDatabase = new System.Windows.Forms.Label();
      this.comboBoxSourceDatabase = new System.Windows.Forms.ComboBox();
      this.checkBoxSourceRememberCredentials = new System.Windows.Forms.CheckBox();
      this.textBoxSourcePassword = new System.Windows.Forms.TextBox();
      this.textBoxSourceName = new System.Windows.Forms.TextBox();
      this.labelSourcePassword = new System.Windows.Forms.Label();
      this.labelSourceUserName = new System.Windows.Forms.Label();
      this.comboBoxSourceSchema = new System.Windows.Forms.ComboBox();
      this.labelSourceSchema = new System.Windows.Forms.Label();
      this.labelSourceServer = new System.Windows.Forms.Label();
      this.labelSourceOperation = new System.Windows.Forms.Label();
      this.tabPageTables = new System.Windows.Forms.TabPage();
      this.tableLayoutPanelTables = new System.Windows.Forms.TableLayoutPanel();
      this.labelTablesSource = new System.Windows.Forms.Label();
      this.dataGridViewPostgreSql = new System.Windows.Forms.DataGridView();
      this.labelTablesTargetNumberOfLines = new System.Windows.Forms.Label();
      this.dataGridViewOracle = new System.Windows.Forms.DataGridView();
      this.labelTablesTarget = new System.Windows.Forms.Label();
      this.comboBoxPostgresqlTable = new System.Windows.Forms.ComboBox();
      this.labelPostgresqlTable = new System.Windows.Forms.Label();
      this.comboBoxPostgresqlSchema = new System.Windows.Forms.ComboBox();
      this.labelSchema = new System.Windows.Forms.Label();
      this.labelTablesSourceNumberOfLines = new System.Windows.Forms.Label();
      this.labelOracleTable = new System.Windows.Forms.Label();
      this.comboBoxOracleTable = new System.Windows.Forms.ComboBox();
      this.buttonTablesCompare = new System.Windows.Forms.Button();
      this.labelNumberOfLinesInOracleButNotInPostgreSql = new System.Windows.Forms.Label();
      this.labelNumberOfLinesInPostgreSqlButNotInOracle = new System.Windows.Forms.Label();
      this.tabPageInsert = new System.Windows.Forms.TabPage();
      this.buttonInsert = new System.Windows.Forms.Button();
      this.labelInsertNumberOfLinesTarget = new System.Windows.Forms.Label();
      this.labelInsertNumberOfLinesSource = new System.Windows.Forms.Label();
      this.buttonInsertLoad = new System.Windows.Forms.Button();
      this.dataGridViewInsertTarget = new System.Windows.Forms.DataGridView();
      this.dataGridViewInsertSource = new System.Windows.Forms.DataGridView();
      this.comboBoxInsertSchemaTarget = new System.Windows.Forms.ComboBox();
      this.labelInsertSchemaTarget = new System.Windows.Forms.Label();
      this.comboBoxInsertTableSource = new System.Windows.Forms.ComboBox();
      this.labelInsertTableNameTarget = new System.Windows.Forms.Label();
      this.labelInsertTableNameSource = new System.Windows.Forms.Label();
      this.comboBoxInsertTableNameTarget = new System.Windows.Forms.ComboBox();
      this.labelInsertTarget = new System.Windows.Forms.Label();
      this.labelInsertSource = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      this.tabControlMain.SuspendLayout();
      this.tabPageConnection.SuspendLayout();
      this.tabPageTables.SuspendLayout();
      this.tableLayoutPanelTables.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostgreSql)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOracle)).BeginInit();
      this.tabPageInsert.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsertTarget)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsertSource)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.toolStripMenuItemLanguage,
            this.aideToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
      this.menuStrip1.Size = new System.Drawing.Size(1283, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fichierToolStripMenuItem
      // 
      this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.toolStripSeparator,
            this.enregistrerToolStripMenuItem,
            this.enregistrersousToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimerToolStripMenuItem,
            this.aperçuavantimpressionToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
      this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
      this.fichierToolStripMenuItem.Text = "&Fichier";
      // 
      // nouveauToolStripMenuItem
      // 
      this.nouveauToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem.Image")));
      this.nouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
      this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.nouveauToolStripMenuItem.Text = "&Nouveau";
      // 
      // ouvrirToolStripMenuItem
      // 
      this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
      this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
      this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
      // 
      // enregistrerToolStripMenuItem
      // 
      this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
      this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
      this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
      // 
      // enregistrersousToolStripMenuItem
      // 
      this.enregistrersousToolStripMenuItem.Name = "enregistrersousToolStripMenuItem";
      this.enregistrersousToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.enregistrersousToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
      // 
      // imprimerToolStripMenuItem
      // 
      this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
      this.imprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
      this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.imprimerToolStripMenuItem.Text = "&Imprimer";
      // 
      // aperçuavantimpressionToolStripMenuItem
      // 
      this.aperçuavantimpressionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem.Image")));
      this.aperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.aperçuavantimpressionToolStripMenuItem.Name = "aperçuavantimpressionToolStripMenuItem";
      this.aperçuavantimpressionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.aperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
      // 
      // quitterToolStripMenuItem
      // 
      this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
      this.quitterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.quitterToolStripMenuItem.Text = "&Quitter";
      this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
      // 
      // editionToolStripMenuItem
      // 
      this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem,
            this.rétablirToolStripMenuItem,
            this.toolStripSeparator3,
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.toolStripSeparator4,
            this.sélectionnertoutToolStripMenuItem});
      this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
      this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
      this.editionToolStripMenuItem.Text = "&Edition";
      // 
      // annulerToolStripMenuItem
      // 
      this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
      this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.annulerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.annulerToolStripMenuItem.Text = "&Annuler";
      // 
      // rétablirToolStripMenuItem
      // 
      this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
      this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.rétablirToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
      // 
      // couperToolStripMenuItem
      // 
      this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
      this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
      this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.couperToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.couperToolStripMenuItem.Text = "&Couper";
      // 
      // copierToolStripMenuItem
      // 
      this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
      this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
      this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copierToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.copierToolStripMenuItem.Text = "Co&pier";
      // 
      // collerToolStripMenuItem
      // 
      this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
      this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
      this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.collerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.collerToolStripMenuItem.Text = "Co&ller";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
      // 
      // sélectionnertoutToolStripMenuItem
      // 
      this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
      this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
      // 
      // outilsToolStripMenuItem
      // 
      this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnaliserToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
      this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
      this.outilsToolStripMenuItem.Text = "&Outils";
      // 
      // personnaliserToolStripMenuItem
      // 
      this.personnaliserToolStripMenuItem.Name = "personnaliserToolStripMenuItem";
      this.personnaliserToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.personnaliserToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // toolStripMenuItemLanguage
      // 
      this.toolStripMenuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frenchToolStripMenuItem,
            this.englishToolStripMenuItem});
      this.toolStripMenuItemLanguage.Name = "toolStripMenuItemLanguage";
      this.toolStripMenuItemLanguage.Size = new System.Drawing.Size(71, 22);
      this.toolStripMenuItemLanguage.Text = "Language";
      // 
      // frenchToolStripMenuItem
      // 
      this.frenchToolStripMenuItem.Checked = true;
      this.frenchToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
      this.frenchToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
      this.frenchToolStripMenuItem.Text = "French";
      this.frenchToolStripMenuItem.Click += new System.EventHandler(this.FrenchToolStripMenuItem_Click);
      // 
      // englishToolStripMenuItem
      // 
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
      this.englishToolStripMenuItem.Text = "English";
      this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
      // 
      // aideToolStripMenuItem
      // 
      this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sommaireToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.toolStripSeparator5,
            this.àproposdeToolStripMenuItem});
      this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
      this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
      this.aideToolStripMenuItem.Text = "&Aide";
      // 
      // sommaireToolStripMenuItem
      // 
      this.sommaireToolStripMenuItem.Name = "sommaireToolStripMenuItem";
      this.sommaireToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.sommaireToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // rechercherToolStripMenuItem
      // 
      this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
      this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.rechercherToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
      // 
      // àproposdeToolStripMenuItem
      // 
      this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
      this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.àproposdeToolStripMenuItem.Text = "À &propos de...";
      this.àproposdeToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.statusStrip1.Location = new System.Drawing.Point(0, 746);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1283, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tabControlMain
      // 
      this.tabControlMain.Controls.Add(this.tabPageConnection);
      this.tabControlMain.Controls.Add(this.tabPageTables);
      this.tabControlMain.Controls.Add(this.tabPageInsert);
      this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlMain.Location = new System.Drawing.Point(0, 24);
      this.tabControlMain.Name = "tabControlMain";
      this.tabControlMain.SelectedIndex = 0;
      this.tabControlMain.Size = new System.Drawing.Size(1283, 722);
      this.tabControlMain.TabIndex = 2;
      this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
      // 
      // tabPageConnection
      // 
      this.tabPageConnection.Controls.Add(this.buttonRefreshTarget);
      this.tabPageConnection.Controls.Add(this.buttonRefreshSource);
      this.tabPageConnection.Controls.Add(this.buttonCopyDatabaseName);
      this.tabPageConnection.Controls.Add(this.buttonCopyUserName);
      this.tabPageConnection.Controls.Add(this.textBoxTargetServer);
      this.tabPageConnection.Controls.Add(this.textBoxSourceServer);
      this.tabPageConnection.Controls.Add(this.textBoxDatabaseNameTarget);
      this.tabPageConnection.Controls.Add(this.labelDatabaseNameTarget);
      this.tabPageConnection.Controls.Add(this.textBoxDatabaseNameSource);
      this.tabPageConnection.Controls.Add(this.labelDatabaseNameSource);
      this.tabPageConnection.Controls.Add(this.buttonTestconnectionTarget);
      this.tabPageConnection.Controls.Add(this.buttonTestConnectionSource);
      this.tabPageConnection.Controls.Add(this.textBoxTargetPort);
      this.tabPageConnection.Controls.Add(this.textBoxSourcePort);
      this.tabPageConnection.Controls.Add(this.labelTargetPort);
      this.tabPageConnection.Controls.Add(this.labelSourcePort);
      this.tabPageConnection.Controls.Add(this.buttonCopyServerName);
      this.tabPageConnection.Controls.Add(this.buttonCopyPassword);
      this.tabPageConnection.Controls.Add(this.buttonCompareCompareNow);
      this.tabPageConnection.Controls.Add(this.buttonTargetCreate);
      this.tabPageConnection.Controls.Add(this.buttonTargetRefresh);
      this.tabPageConnection.Controls.Add(this.labelTargetDatabase);
      this.tabPageConnection.Controls.Add(this.comboBoxTargetDatabase);
      this.tabPageConnection.Controls.Add(this.checkBoxTargetRememberCredentials);
      this.tabPageConnection.Controls.Add(this.textBoxTargetPassword);
      this.tabPageConnection.Controls.Add(this.textBoxTargetName);
      this.tabPageConnection.Controls.Add(this.labelTargetPassword);
      this.tabPageConnection.Controls.Add(this.labelTargetUserName);
      this.tabPageConnection.Controls.Add(this.comboBoxTargetSchema);
      this.tabPageConnection.Controls.Add(this.labelTargetSchema);
      this.tabPageConnection.Controls.Add(this.labelTargetServer);
      this.tabPageConnection.Controls.Add(this.labelTargetOperation);
      this.tabPageConnection.Controls.Add(this.buttonSourceCreate);
      this.tabPageConnection.Controls.Add(this.buttonSourceRefresh);
      this.tabPageConnection.Controls.Add(this.labelSourceDatabase);
      this.tabPageConnection.Controls.Add(this.comboBoxSourceDatabase);
      this.tabPageConnection.Controls.Add(this.checkBoxSourceRememberCredentials);
      this.tabPageConnection.Controls.Add(this.textBoxSourcePassword);
      this.tabPageConnection.Controls.Add(this.textBoxSourceName);
      this.tabPageConnection.Controls.Add(this.labelSourcePassword);
      this.tabPageConnection.Controls.Add(this.labelSourceUserName);
      this.tabPageConnection.Controls.Add(this.comboBoxSourceSchema);
      this.tabPageConnection.Controls.Add(this.labelSourceSchema);
      this.tabPageConnection.Controls.Add(this.labelSourceServer);
      this.tabPageConnection.Controls.Add(this.labelSourceOperation);
      this.tabPageConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
      this.tabPageConnection.Name = "tabPageConnection";
      this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
      this.tabPageConnection.Size = new System.Drawing.Size(1275, 696);
      this.tabPageConnection.TabIndex = 0;
      this.tabPageConnection.Text = "Connection";
      this.tabPageConnection.UseVisualStyleBackColor = true;
      this.tabPageConnection.Click += new System.EventHandler(this.TabPageConnection_Click);
      // 
      // buttonRefreshTarget
      // 
      this.buttonRefreshTarget.Location = new System.Drawing.Point(821, 502);
      this.buttonRefreshTarget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonRefreshTarget.Name = "buttonRefreshTarget";
      this.buttonRefreshTarget.Size = new System.Drawing.Size(79, 25);
      this.buttonRefreshTarget.TabIndex = 138;
      this.buttonRefreshTarget.Text = "Refresh";
      this.buttonRefreshTarget.UseVisualStyleBackColor = true;
      this.buttonRefreshTarget.Click += new System.EventHandler(this.ButtonRefreshTarget_Click);
      // 
      // buttonRefreshSource
      // 
      this.buttonRefreshSource.Location = new System.Drawing.Point(311, 505);
      this.buttonRefreshSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonRefreshSource.Name = "buttonRefreshSource";
      this.buttonRefreshSource.Size = new System.Drawing.Size(79, 25);
      this.buttonRefreshSource.TabIndex = 137;
      this.buttonRefreshSource.Text = "Refresh";
      this.buttonRefreshSource.UseVisualStyleBackColor = true;
      this.buttonRefreshSource.Click += new System.EventHandler(this.ButtonRefreshSource_Click);
      // 
      // buttonCopyDatabaseName
      // 
      this.buttonCopyDatabaseName.Location = new System.Drawing.Point(453, 291);
      this.buttonCopyDatabaseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonCopyDatabaseName.Name = "buttonCopyDatabaseName";
      this.buttonCopyDatabaseName.Size = new System.Drawing.Size(47, 22);
      this.buttonCopyDatabaseName.TabIndex = 136;
      this.buttonCopyDatabaseName.Text = "-->";
      this.buttonCopyDatabaseName.UseVisualStyleBackColor = true;
      this.buttonCopyDatabaseName.Click += new System.EventHandler(this.ButtonCopyDatabaseName_Click);
      // 
      // buttonCopyUserName
      // 
      this.buttonCopyUserName.Location = new System.Drawing.Point(453, 225);
      this.buttonCopyUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonCopyUserName.Name = "buttonCopyUserName";
      this.buttonCopyUserName.Size = new System.Drawing.Size(47, 22);
      this.buttonCopyUserName.TabIndex = 135;
      this.buttonCopyUserName.Text = "-->";
      this.buttonCopyUserName.UseVisualStyleBackColor = true;
      this.buttonCopyUserName.Click += new System.EventHandler(this.ButtonCopyUserName_Click);
      // 
      // textBoxTargetServer
      // 
      this.textBoxTargetServer.Location = new System.Drawing.Point(527, 156);
      this.textBoxTargetServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.textBoxTargetServer.Name = "textBoxTargetServer";
      this.textBoxTargetServer.Size = new System.Drawing.Size(421, 26);
      this.textBoxTargetServer.TabIndex = 134;
      // 
      // textBoxSourceServer
      // 
      this.textBoxSourceServer.Location = new System.Drawing.Point(27, 156);
      this.textBoxSourceServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.textBoxSourceServer.Name = "textBoxSourceServer";
      this.textBoxSourceServer.Size = new System.Drawing.Size(407, 26);
      this.textBoxSourceServer.TabIndex = 133;
      // 
      // textBoxDatabaseNameTarget
      // 
      this.textBoxDatabaseNameTarget.Location = new System.Drawing.Point(663, 292);
      this.textBoxDatabaseNameTarget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.textBoxDatabaseNameTarget.Name = "textBoxDatabaseNameTarget";
      this.textBoxDatabaseNameTarget.Size = new System.Drawing.Size(285, 26);
      this.textBoxDatabaseNameTarget.TabIndex = 132;
      // 
      // labelDatabaseNameTarget
      // 
      this.labelDatabaseNameTarget.AutoSize = true;
      this.labelDatabaseNameTarget.Location = new System.Drawing.Point(523, 292);
      this.labelDatabaseNameTarget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelDatabaseNameTarget.Name = "labelDatabaseNameTarget";
      this.labelDatabaseNameTarget.Size = new System.Drawing.Size(125, 20);
      this.labelDatabaseNameTarget.TabIndex = 131;
      this.labelDatabaseNameTarget.Text = "Database Name";
      // 
      // textBoxDatabaseNameSource
      // 
      this.textBoxDatabaseNameSource.Location = new System.Drawing.Point(148, 290);
      this.textBoxDatabaseNameSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.textBoxDatabaseNameSource.Name = "textBoxDatabaseNameSource";
      this.textBoxDatabaseNameSource.Size = new System.Drawing.Size(285, 26);
      this.textBoxDatabaseNameSource.TabIndex = 130;
      // 
      // labelDatabaseNameSource
      // 
      this.labelDatabaseNameSource.AutoSize = true;
      this.labelDatabaseNameSource.Location = new System.Drawing.Point(23, 292);
      this.labelDatabaseNameSource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelDatabaseNameSource.Name = "labelDatabaseNameSource";
      this.labelDatabaseNameSource.Size = new System.Drawing.Size(125, 20);
      this.labelDatabaseNameSource.TabIndex = 129;
      this.labelDatabaseNameSource.Text = "Database Name";
      // 
      // buttonTestconnectionTarget
      // 
      this.buttonTestconnectionTarget.Location = new System.Drawing.Point(663, 360);
      this.buttonTestconnectionTarget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonTestconnectionTarget.Name = "buttonTestconnectionTarget";
      this.buttonTestconnectionTarget.Size = new System.Drawing.Size(185, 25);
      this.buttonTestconnectionTarget.TabIndex = 128;
      this.buttonTestconnectionTarget.Text = "Test connection";
      this.buttonTestconnectionTarget.UseVisualStyleBackColor = true;
      this.buttonTestconnectionTarget.Click += new System.EventHandler(this.ButtonTestconnectionTarget_Click);
      // 
      // buttonTestConnectionSource
      // 
      this.buttonTestConnectionSource.Location = new System.Drawing.Point(148, 360);
      this.buttonTestConnectionSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonTestConnectionSource.Name = "buttonTestConnectionSource";
      this.buttonTestConnectionSource.Size = new System.Drawing.Size(177, 25);
      this.buttonTestConnectionSource.TabIndex = 127;
      this.buttonTestConnectionSource.Text = "Test connection";
      this.buttonTestConnectionSource.UseVisualStyleBackColor = true;
      this.buttonTestConnectionSource.Click += new System.EventHandler(this.ButtonTestConnection_Click);
      // 
      // textBoxTargetPort
      // 
      this.textBoxTargetPort.Location = new System.Drawing.Point(663, 194);
      this.textBoxTargetPort.Name = "textBoxTargetPort";
      this.textBoxTargetPort.Size = new System.Drawing.Size(144, 26);
      this.textBoxTargetPort.TabIndex = 126;
      this.textBoxTargetPort.Text = "5432";
      // 
      // textBoxSourcePort
      // 
      this.textBoxSourcePort.Location = new System.Drawing.Point(148, 195);
      this.textBoxSourcePort.Name = "textBoxSourcePort";
      this.textBoxSourcePort.Size = new System.Drawing.Size(144, 26);
      this.textBoxSourcePort.TabIndex = 125;
      this.textBoxSourcePort.Text = "1521";
      // 
      // labelTargetPort
      // 
      this.labelTargetPort.AutoSize = true;
      this.labelTargetPort.Location = new System.Drawing.Point(523, 197);
      this.labelTargetPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelTargetPort.Name = "labelTargetPort";
      this.labelTargetPort.Size = new System.Drawing.Size(42, 20);
      this.labelTargetPort.TabIndex = 124;
      this.labelTargetPort.Text = "Port:";
      // 
      // labelSourcePort
      // 
      this.labelSourcePort.AutoSize = true;
      this.labelSourcePort.Location = new System.Drawing.Point(21, 197);
      this.labelSourcePort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelSourcePort.Name = "labelSourcePort";
      this.labelSourcePort.Size = new System.Drawing.Size(42, 20);
      this.labelSourcePort.TabIndex = 123;
      this.labelSourcePort.Text = "Port:";
      // 
      // buttonCopyServerName
      // 
      this.buttonCopyServerName.Location = new System.Drawing.Point(453, 157);
      this.buttonCopyServerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonCopyServerName.Name = "buttonCopyServerName";
      this.buttonCopyServerName.Size = new System.Drawing.Size(47, 22);
      this.buttonCopyServerName.TabIndex = 122;
      this.buttonCopyServerName.Text = "-->";
      this.buttonCopyServerName.UseVisualStyleBackColor = true;
      this.buttonCopyServerName.Click += new System.EventHandler(this.ButtonCopyServerName_Click);
      // 
      // buttonCopyPassword
      // 
      this.buttonCopyPassword.Location = new System.Drawing.Point(453, 256);
      this.buttonCopyPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonCopyPassword.Name = "buttonCopyPassword";
      this.buttonCopyPassword.Size = new System.Drawing.Size(47, 22);
      this.buttonCopyPassword.TabIndex = 121;
      this.buttonCopyPassword.Text = "-->";
      this.buttonCopyPassword.UseVisualStyleBackColor = true;
      this.buttonCopyPassword.Click += new System.EventHandler(this.ButtonCopyPassword_Click);
      // 
      // buttonCompareCompareNow
      // 
      this.buttonCompareCompareNow.BackColor = System.Drawing.Color.RoyalBlue;
      this.buttonCompareCompareNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonCompareCompareNow.ForeColor = System.Drawing.Color.White;
      this.buttonCompareCompareNow.Location = new System.Drawing.Point(431, 581);
      this.buttonCompareCompareNow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonCompareCompareNow.Name = "buttonCompareCompareNow";
      this.buttonCompareCompareNow.Size = new System.Drawing.Size(110, 30);
      this.buttonCompareCompareNow.TabIndex = 120;
      this.buttonCompareCompareNow.Text = "Compare now";
      this.buttonCompareCompareNow.UseVisualStyleBackColor = false;
      this.buttonCompareCompareNow.Click += new System.EventHandler(this.ButtonCompareCompareNow_Click);
      // 
      // buttonTargetCreate
      // 
      this.buttonTargetCreate.Location = new System.Drawing.Point(526, 461);
      this.buttonTargetCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonTargetCreate.Name = "buttonTargetCreate";
      this.buttonTargetCreate.Size = new System.Drawing.Size(67, 25);
      this.buttonTargetCreate.TabIndex = 119;
      this.buttonTargetCreate.Text = "Create";
      this.buttonTargetCreate.UseVisualStyleBackColor = true;
      this.buttonTargetCreate.Click += new System.EventHandler(this.ButtonTargetCreate_Click);
      // 
      // buttonTargetRefresh
      // 
      this.buttonTargetRefresh.Location = new System.Drawing.Point(824, 420);
      this.buttonTargetRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonTargetRefresh.Name = "buttonTargetRefresh";
      this.buttonTargetRefresh.Size = new System.Drawing.Size(75, 25);
      this.buttonTargetRefresh.TabIndex = 118;
      this.buttonTargetRefresh.Text = "Refresh";
      this.buttonTargetRefresh.UseVisualStyleBackColor = true;
      this.buttonTargetRefresh.Click += new System.EventHandler(this.ButtonTargetRefresh_Click);
      // 
      // labelTargetDatabase
      // 
      this.labelTargetDatabase.AutoSize = true;
      this.labelTargetDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTargetDatabase.Location = new System.Drawing.Point(526, 394);
      this.labelTargetDatabase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelTargetDatabase.Name = "labelTargetDatabase";
      this.labelTargetDatabase.Size = new System.Drawing.Size(87, 20);
      this.labelTargetDatabase.TabIndex = 117;
      this.labelTargetDatabase.Text = "Database";
      // 
      // comboBoxTargetDatabase
      // 
      this.comboBoxTargetDatabase.FormattingEnabled = true;
      this.comboBoxTargetDatabase.Location = new System.Drawing.Point(528, 422);
      this.comboBoxTargetDatabase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBoxTargetDatabase.Name = "comboBoxTargetDatabase";
      this.comboBoxTargetDatabase.Size = new System.Drawing.Size(293, 28);
      this.comboBoxTargetDatabase.TabIndex = 116;
      this.comboBoxTargetDatabase.Text = "Database name";
      // 
      // checkBoxTargetRememberCredentials
      // 
      this.checkBoxTargetRememberCredentials.AutoSize = true;
      this.checkBoxTargetRememberCredentials.Location = new System.Drawing.Point(663, 328);
      this.checkBoxTargetRememberCredentials.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.checkBoxTargetRememberCredentials.Name = "checkBoxTargetRememberCredentials";
      this.checkBoxTargetRememberCredentials.Size = new System.Drawing.Size(188, 24);
      this.checkBoxTargetRememberCredentials.TabIndex = 115;
      this.checkBoxTargetRememberCredentials.Text = "Remember credentials";
      this.checkBoxTargetRememberCredentials.UseVisualStyleBackColor = true;
      // 
      // textBoxTargetPassword
      // 
      this.textBoxTargetPassword.Location = new System.Drawing.Point(663, 256);
      this.textBoxTargetPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.textBoxTargetPassword.Name = "textBoxTargetPassword";
      this.textBoxTargetPassword.PasswordChar = '*';
      this.textBoxTargetPassword.Size = new System.Drawing.Size(285, 26);
      this.textBoxTargetPassword.TabIndex = 114;
      // 
      // textBoxTargetName
      // 
      this.textBoxTargetName.Location = new System.Drawing.Point(663, 224);
      this.textBoxTargetName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.textBoxTargetName.Name = "textBoxTargetName";
      this.textBoxTargetName.Size = new System.Drawing.Size(285, 26);
      this.textBoxTargetName.TabIndex = 113;
      // 
      // labelTargetPassword
      // 
      this.labelTargetPassword.AutoSize = true;
      this.labelTargetPassword.Location = new System.Drawing.Point(523, 256);
      this.labelTargetPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelTargetPassword.Name = "labelTargetPassword";
      this.labelTargetPassword.Size = new System.Drawing.Size(78, 20);
      this.labelTargetPassword.TabIndex = 112;
      this.labelTargetPassword.Text = "Password";
      // 
      // labelTargetUserName
      // 
      this.labelTargetUserName.AutoSize = true;
      this.labelTargetUserName.Location = new System.Drawing.Point(523, 224);
      this.labelTargetUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelTargetUserName.Name = "labelTargetUserName";
      this.labelTargetUserName.Size = new System.Drawing.Size(89, 20);
      this.labelTargetUserName.TabIndex = 111;
      this.labelTargetUserName.Text = "User Name";
      // 
      // comboBoxTargetSchema
      // 
      this.comboBoxTargetSchema.FormattingEnabled = true;
      this.comboBoxTargetSchema.Location = new System.Drawing.Point(604, 504);
      this.comboBoxTargetSchema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBoxTargetSchema.Name = "comboBoxTargetSchema";
      this.comboBoxTargetSchema.Size = new System.Drawing.Size(214, 28);
      this.comboBoxTargetSchema.TabIndex = 110;
      // 
      // labelTargetSchema
      // 
      this.labelTargetSchema.AutoSize = true;
      this.labelTargetSchema.Location = new System.Drawing.Point(526, 508);
      this.labelTargetSchema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelTargetSchema.Name = "labelTargetSchema";
      this.labelTargetSchema.Size = new System.Drawing.Size(68, 20);
      this.labelTargetSchema.TabIndex = 109;
      this.labelTargetSchema.Text = "Schema";
      // 
      // labelTargetServer
      // 
      this.labelTargetServer.AutoSize = true;
      this.labelTargetServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTargetServer.Location = new System.Drawing.Point(526, 128);
      this.labelTargetServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelTargetServer.Name = "labelTargetServer";
      this.labelTargetServer.Size = new System.Drawing.Size(163, 20);
      this.labelTargetServer.TabIndex = 108;
      this.labelTargetServer.Text = "PostgreSQL Server";
      // 
      // labelTargetOperation
      // 
      this.labelTargetOperation.AutoSize = true;
      this.labelTargetOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTargetOperation.Location = new System.Drawing.Point(522, 76);
      this.labelTargetOperation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelTargetOperation.Name = "labelTargetOperation";
      this.labelTargetOperation.Size = new System.Drawing.Size(70, 24);
      this.labelTargetOperation.TabIndex = 107;
      this.labelTargetOperation.Text = "Target";
      // 
      // buttonSourceCreate
      // 
      this.buttonSourceCreate.Location = new System.Drawing.Point(22, 461);
      this.buttonSourceCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonSourceCreate.Name = "buttonSourceCreate";
      this.buttonSourceCreate.Size = new System.Drawing.Size(66, 25);
      this.buttonSourceCreate.TabIndex = 106;
      this.buttonSourceCreate.Text = "Create";
      this.buttonSourceCreate.UseVisualStyleBackColor = true;
      this.buttonSourceCreate.Click += new System.EventHandler(this.ButtonSourceCreate_Click);
      // 
      // buttonSourceRefresh
      // 
      this.buttonSourceRefresh.Location = new System.Drawing.Point(306, 422);
      this.buttonSourceRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonSourceRefresh.Name = "buttonSourceRefresh";
      this.buttonSourceRefresh.Size = new System.Drawing.Size(79, 25);
      this.buttonSourceRefresh.TabIndex = 105;
      this.buttonSourceRefresh.Text = "Refresh";
      this.buttonSourceRefresh.UseVisualStyleBackColor = true;
      this.buttonSourceRefresh.Click += new System.EventHandler(this.ButtonSourceRefresh_Click);
      // 
      // labelSourceDatabase
      // 
      this.labelSourceDatabase.AutoSize = true;
      this.labelSourceDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSourceDatabase.Location = new System.Drawing.Point(21, 397);
      this.labelSourceDatabase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelSourceDatabase.Name = "labelSourceDatabase";
      this.labelSourceDatabase.Size = new System.Drawing.Size(87, 20);
      this.labelSourceDatabase.TabIndex = 104;
      this.labelSourceDatabase.Text = "Database";
      // 
      // comboBoxSourceDatabase
      // 
      this.comboBoxSourceDatabase.FormattingEnabled = true;
      this.comboBoxSourceDatabase.Location = new System.Drawing.Point(23, 424);
      this.comboBoxSourceDatabase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBoxSourceDatabase.Name = "comboBoxSourceDatabase";
      this.comboBoxSourceDatabase.Size = new System.Drawing.Size(276, 28);
      this.comboBoxSourceDatabase.TabIndex = 103;
      this.comboBoxSourceDatabase.Text = "Database name";
      // 
      // checkBoxSourceRememberCredentials
      // 
      this.checkBoxSourceRememberCredentials.AutoSize = true;
      this.checkBoxSourceRememberCredentials.Location = new System.Drawing.Point(148, 326);
      this.checkBoxSourceRememberCredentials.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.checkBoxSourceRememberCredentials.Name = "checkBoxSourceRememberCredentials";
      this.checkBoxSourceRememberCredentials.Size = new System.Drawing.Size(188, 24);
      this.checkBoxSourceRememberCredentials.TabIndex = 102;
      this.checkBoxSourceRememberCredentials.Text = "Remember credentials";
      this.checkBoxSourceRememberCredentials.UseVisualStyleBackColor = true;
      // 
      // textBoxSourcePassword
      // 
      this.textBoxSourcePassword.Location = new System.Drawing.Point(148, 255);
      this.textBoxSourcePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.textBoxSourcePassword.Name = "textBoxSourcePassword";
      this.textBoxSourcePassword.PasswordChar = '*';
      this.textBoxSourcePassword.Size = new System.Drawing.Size(285, 26);
      this.textBoxSourcePassword.TabIndex = 101;
      // 
      // textBoxSourceName
      // 
      this.textBoxSourceName.Location = new System.Drawing.Point(148, 224);
      this.textBoxSourceName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.textBoxSourceName.Name = "textBoxSourceName";
      this.textBoxSourceName.Size = new System.Drawing.Size(285, 26);
      this.textBoxSourceName.TabIndex = 100;
      // 
      // labelSourcePassword
      // 
      this.labelSourcePassword.AutoSize = true;
      this.labelSourcePassword.Location = new System.Drawing.Point(21, 255);
      this.labelSourcePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelSourcePassword.Name = "labelSourcePassword";
      this.labelSourcePassword.Size = new System.Drawing.Size(78, 20);
      this.labelSourcePassword.TabIndex = 99;
      this.labelSourcePassword.Text = "Password";
      // 
      // labelSourceUserName
      // 
      this.labelSourceUserName.AutoSize = true;
      this.labelSourceUserName.Location = new System.Drawing.Point(21, 224);
      this.labelSourceUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelSourceUserName.Name = "labelSourceUserName";
      this.labelSourceUserName.Size = new System.Drawing.Size(89, 20);
      this.labelSourceUserName.TabIndex = 98;
      this.labelSourceUserName.Text = "User Name";
      // 
      // comboBoxSourceSchema
      // 
      this.comboBoxSourceSchema.FormattingEnabled = true;
      this.comboBoxSourceSchema.Location = new System.Drawing.Point(99, 506);
      this.comboBoxSourceSchema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBoxSourceSchema.Name = "comboBoxSourceSchema";
      this.comboBoxSourceSchema.Size = new System.Drawing.Size(200, 28);
      this.comboBoxSourceSchema.TabIndex = 97;
      // 
      // labelSourceSchema
      // 
      this.labelSourceSchema.AutoSize = true;
      this.labelSourceSchema.Location = new System.Drawing.Point(21, 506);
      this.labelSourceSchema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelSourceSchema.Name = "labelSourceSchema";
      this.labelSourceSchema.Size = new System.Drawing.Size(68, 20);
      this.labelSourceSchema.TabIndex = 96;
      this.labelSourceSchema.Text = "Schema";
      // 
      // labelSourceServer
      // 
      this.labelSourceServer.AutoSize = true;
      this.labelSourceServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSourceServer.Location = new System.Drawing.Point(19, 128);
      this.labelSourceServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelSourceServer.Name = "labelSourceServer";
      this.labelSourceServer.Size = new System.Drawing.Size(233, 20);
      this.labelSourceServer.TabIndex = 95;
      this.labelSourceServer.Text = "Oracle Server: network alias";
      // 
      // labelSourceOperation
      // 
      this.labelSourceOperation.AutoSize = true;
      this.labelSourceOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSourceOperation.Location = new System.Drawing.Point(19, 76);
      this.labelSourceOperation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelSourceOperation.Name = "labelSourceOperation";
      this.labelSourceOperation.Size = new System.Drawing.Size(77, 24);
      this.labelSourceOperation.TabIndex = 94;
      this.labelSourceOperation.Text = "Source";
      // 
      // tabPageTables
      // 
      this.tabPageTables.Controls.Add(this.tableLayoutPanelTables);
      this.tabPageTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabPageTables.Location = new System.Drawing.Point(4, 22);
      this.tabPageTables.Name = "tabPageTables";
      this.tabPageTables.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
      this.tabPageTables.Size = new System.Drawing.Size(1643, 707);
      this.tabPageTables.TabIndex = 1;
      this.tabPageTables.Text = "Tables";
      this.tabPageTables.UseVisualStyleBackColor = true;
      this.tabPageTables.Click += new System.EventHandler(this.TabPageTables_Click);
      // 
      // tableLayoutPanelTables
      // 
      this.tableLayoutPanelTables.ColumnCount = 5;
      this.tableLayoutPanelTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanelTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanelTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
      this.tableLayoutPanelTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanelTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanelTables.Controls.Add(this.labelTablesSource, 0, 0);
      this.tableLayoutPanelTables.Controls.Add(this.dataGridViewPostgreSql, 3, 6);
      this.tableLayoutPanelTables.Controls.Add(this.labelTablesTargetNumberOfLines, 3, 3);
      this.tableLayoutPanelTables.Controls.Add(this.dataGridViewOracle, 0, 6);
      this.tableLayoutPanelTables.Controls.Add(this.labelTablesTarget, 3, 0);
      this.tableLayoutPanelTables.Controls.Add(this.comboBoxPostgresqlTable, 4, 2);
      this.tableLayoutPanelTables.Controls.Add(this.labelPostgresqlTable, 3, 2);
      this.tableLayoutPanelTables.Controls.Add(this.comboBoxPostgresqlSchema, 4, 1);
      this.tableLayoutPanelTables.Controls.Add(this.labelSchema, 3, 1);
      this.tableLayoutPanelTables.Controls.Add(this.labelTablesSourceNumberOfLines, 0, 3);
      this.tableLayoutPanelTables.Controls.Add(this.labelOracleTable, 0, 2);
      this.tableLayoutPanelTables.Controls.Add(this.comboBoxOracleTable, 1, 2);
      this.tableLayoutPanelTables.Controls.Add(this.buttonTablesCompare, 2, 6);
      this.tableLayoutPanelTables.Controls.Add(this.labelNumberOfLinesInOracleButNotInPostgreSql, 0, 4);
      this.tableLayoutPanelTables.Controls.Add(this.labelNumberOfLinesInPostgreSqlButNotInOracle, 3, 4);
      this.tableLayoutPanelTables.Location = new System.Drawing.Point(5, 5);
      this.tableLayoutPanelTables.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.tableLayoutPanelTables.Name = "tableLayoutPanelTables";
      this.tableLayoutPanelTables.RowCount = 8;
      this.tableLayoutPanelTables.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanelTables.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanelTables.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanelTables.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanelTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanelTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
      this.tableLayoutPanelTables.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanelTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
      this.tableLayoutPanelTables.Size = new System.Drawing.Size(1635, 757);
      this.tableLayoutPanelTables.TabIndex = 121;
      // 
      // labelTablesSource
      // 
      this.labelTablesSource.AutoSize = true;
      this.labelTablesSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTablesSource.Location = new System.Drawing.Point(2, 0);
      this.labelTablesSource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelTablesSource.Name = "labelTablesSource";
      this.labelTablesSource.Size = new System.Drawing.Size(151, 24);
      this.labelTablesSource.TabIndex = 108;
      this.labelTablesSource.Text = "Source: Oracle";
      // 
      // dataGridViewPostgreSql
      // 
      this.dataGridViewPostgreSql.AllowUserToAddRows = false;
      this.dataGridViewPostgreSql.AllowUserToDeleteRows = false;
      this.dataGridViewPostgreSql.AllowUserToOrderColumns = true;
      this.dataGridViewPostgreSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tableLayoutPanelTables.SetColumnSpan(this.dataGridViewPostgreSql, 2);
      this.dataGridViewPostgreSql.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewPostgreSql.Location = new System.Drawing.Point(991, 147);
      this.dataGridViewPostgreSql.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.dataGridViewPostgreSql.Name = "dataGridViewPostgreSql";
      this.dataGridViewPostgreSql.ReadOnly = true;
      this.dataGridViewPostgreSql.RowHeadersWidth = 62;
      this.dataGridViewPostgreSql.RowTemplate.Height = 28;
      this.dataGridViewPostgreSql.Size = new System.Drawing.Size(762, 477);
      this.dataGridViewPostgreSql.TabIndex = 111;
      // 
      // labelTablesTargetNumberOfLines
      // 
      this.labelTablesTargetNumberOfLines.AutoSize = true;
      this.tableLayoutPanelTables.SetColumnSpan(this.labelTablesTargetNumberOfLines, 2);
      this.labelTablesTargetNumberOfLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTablesTargetNumberOfLines.Location = new System.Drawing.Point(991, 88);
      this.labelTablesTargetNumberOfLines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelTablesTargetNumberOfLines.Name = "labelTablesTargetNumberOfLines";
      this.labelTablesTargetNumberOfLines.Size = new System.Drawing.Size(279, 24);
      this.labelTablesTargetNumberOfLines.TabIndex = 120;
      this.labelTablesTargetNumberOfLines.Text = "Number of lines in target table: 0";
      // 
      // dataGridViewOracle
      // 
      this.dataGridViewOracle.AllowUserToAddRows = false;
      this.dataGridViewOracle.AllowUserToDeleteRows = false;
      this.dataGridViewOracle.AllowUserToOrderColumns = true;
      this.dataGridViewOracle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tableLayoutPanelTables.SetColumnSpan(this.dataGridViewOracle, 2);
      this.dataGridViewOracle.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewOracle.Location = new System.Drawing.Point(2, 147);
      this.dataGridViewOracle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.dataGridViewOracle.Name = "dataGridViewOracle";
      this.dataGridViewOracle.ReadOnly = true;
      this.dataGridViewOracle.RowHeadersWidth = 62;
      this.dataGridViewOracle.RowTemplate.Height = 28;
      this.dataGridViewOracle.Size = new System.Drawing.Size(898, 477);
      this.dataGridViewOracle.TabIndex = 110;
      // 
      // labelTablesTarget
      // 
      this.labelTablesTarget.AutoSize = true;
      this.labelTablesTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTablesTarget.Location = new System.Drawing.Point(991, 0);
      this.labelTablesTarget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelTablesTarget.Name = "labelTablesTarget";
      this.labelTablesTarget.Size = new System.Drawing.Size(183, 24);
      this.labelTablesTarget.TabIndex = 109;
      this.labelTablesTarget.Text = "Target: PostgreSql";
      // 
      // comboBoxPostgresqlTable
      // 
      this.comboBoxPostgresqlTable.Dock = System.Windows.Forms.DockStyle.Left;
      this.comboBoxPostgresqlTable.FormattingEnabled = true;
      this.comboBoxPostgresqlTable.Location = new System.Drawing.Point(1178, 58);
      this.comboBoxPostgresqlTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBoxPostgresqlTable.Name = "comboBoxPostgresqlTable";
      this.comboBoxPostgresqlTable.Size = new System.Drawing.Size(401, 28);
      this.comboBoxPostgresqlTable.TabIndex = 114;
      this.comboBoxPostgresqlTable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPostgresqlTable_SelectedIndexChanged);
      // 
      // labelPostgresqlTable
      // 
      this.labelPostgresqlTable.AutoSize = true;
      this.labelPostgresqlTable.Location = new System.Drawing.Point(991, 56);
      this.labelPostgresqlTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelPostgresqlTable.Name = "labelPostgresqlTable";
      this.labelPostgresqlTable.Size = new System.Drawing.Size(96, 20);
      this.labelPostgresqlTable.TabIndex = 115;
      this.labelPostgresqlTable.Text = "Table name:";
      // 
      // comboBoxPostgresqlSchema
      // 
      this.comboBoxPostgresqlSchema.Dock = System.Windows.Forms.DockStyle.Left;
      this.comboBoxPostgresqlSchema.FormattingEnabled = true;
      this.comboBoxPostgresqlSchema.Location = new System.Drawing.Point(1178, 26);
      this.comboBoxPostgresqlSchema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBoxPostgresqlSchema.Name = "comboBoxPostgresqlSchema";
      this.comboBoxPostgresqlSchema.Size = new System.Drawing.Size(401, 28);
      this.comboBoxPostgresqlSchema.TabIndex = 116;
      this.comboBoxPostgresqlSchema.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPostgresqlSchema_SelectedIndexChanged);
      // 
      // labelSchema
      // 
      this.labelSchema.AutoSize = true;
      this.labelSchema.Location = new System.Drawing.Point(991, 24);
      this.labelSchema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelSchema.Name = "labelSchema";
      this.labelSchema.Size = new System.Drawing.Size(72, 20);
      this.labelSchema.TabIndex = 117;
      this.labelSchema.Text = "Schema:";
      // 
      // labelTablesSourceNumberOfLines
      // 
      this.labelTablesSourceNumberOfLines.AutoSize = true;
      this.tableLayoutPanelTables.SetColumnSpan(this.labelTablesSourceNumberOfLines, 2);
      this.labelTablesSourceNumberOfLines.Dock = System.Windows.Forms.DockStyle.Fill;
      this.labelTablesSourceNumberOfLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTablesSourceNumberOfLines.Location = new System.Drawing.Point(2, 88);
      this.labelTablesSourceNumberOfLines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelTablesSourceNumberOfLines.Name = "labelTablesSourceNumberOfLines";
      this.labelTablesSourceNumberOfLines.Size = new System.Drawing.Size(898, 24);
      this.labelTablesSourceNumberOfLines.TabIndex = 119;
      this.labelTablesSourceNumberOfLines.Text = "Number of lines in source table: 0";
      // 
      // labelOracleTable
      // 
      this.labelOracleTable.AutoSize = true;
      this.labelOracleTable.Location = new System.Drawing.Point(2, 56);
      this.labelOracleTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelOracleTable.Name = "labelOracleTable";
      this.labelOracleTable.Size = new System.Drawing.Size(96, 20);
      this.labelOracleTable.TabIndex = 113;
      this.labelOracleTable.Text = "Table name:";
      // 
      // comboBoxOracleTable
      // 
      this.comboBoxOracleTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.comboBoxOracleTable.FormattingEnabled = true;
      this.comboBoxOracleTable.Location = new System.Drawing.Point(157, 58);
      this.comboBoxOracleTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBoxOracleTable.Name = "comboBoxOracleTable";
      this.comboBoxOracleTable.Size = new System.Drawing.Size(743, 28);
      this.comboBoxOracleTable.TabIndex = 112;
      this.comboBoxOracleTable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOracleTable_SelectedIndexChanged);
      // 
      // buttonTablesCompare
      // 
      this.buttonTablesCompare.Dock = System.Windows.Forms.DockStyle.Top;
      this.buttonTablesCompare.Location = new System.Drawing.Point(904, 147);
      this.buttonTablesCompare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonTablesCompare.Name = "buttonTablesCompare";
      this.buttonTablesCompare.Size = new System.Drawing.Size(83, 30);
      this.buttonTablesCompare.TabIndex = 118;
      this.buttonTablesCompare.Text = "Compare";
      this.buttonTablesCompare.UseVisualStyleBackColor = true;
      this.buttonTablesCompare.Click += new System.EventHandler(this.ButtonTablesCompare_Click);
      // 
      // labelNumberOfLinesInOracleButNotInPostgreSql
      // 
      this.labelNumberOfLinesInOracleButNotInPostgreSql.AutoSize = true;
      this.tableLayoutPanelTables.SetColumnSpan(this.labelNumberOfLinesInOracleButNotInPostgreSql, 2);
      this.labelNumberOfLinesInOracleButNotInPostgreSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelNumberOfLinesInOracleButNotInPostgreSql.Location = new System.Drawing.Point(2, 112);
      this.labelNumberOfLinesInOracleButNotInPostgreSql.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelNumberOfLinesInOracleButNotInPostgreSql.Name = "labelNumberOfLinesInOracleButNotInPostgreSql";
      this.labelNumberOfLinesInOracleButNotInPostgreSql.Size = new System.Drawing.Size(422, 20);
      this.labelNumberOfLinesInOracleButNotInPostgreSql.TabIndex = 121;
      this.labelNumberOfLinesInOracleButNotInPostgreSql.Text = "Number of lines in Oracle but not in PostgreSql: 0";
      // 
      // labelNumberOfLinesInPostgreSqlButNotInOracle
      // 
      this.labelNumberOfLinesInPostgreSqlButNotInOracle.AutoSize = true;
      this.tableLayoutPanelTables.SetColumnSpan(this.labelNumberOfLinesInPostgreSqlButNotInOracle, 2);
      this.labelNumberOfLinesInPostgreSqlButNotInOracle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelNumberOfLinesInPostgreSqlButNotInOracle.Location = new System.Drawing.Point(991, 112);
      this.labelNumberOfLinesInPostgreSqlButNotInOracle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelNumberOfLinesInPostgreSqlButNotInOracle.Name = "labelNumberOfLinesInPostgreSqlButNotInOracle";
      this.labelNumberOfLinesInPostgreSqlButNotInOracle.Size = new System.Drawing.Size(422, 20);
      this.labelNumberOfLinesInPostgreSqlButNotInOracle.TabIndex = 122;
      this.labelNumberOfLinesInPostgreSqlButNotInOracle.Text = "Number of lines in PostgreSql but not in Oracle: 0";
      // 
      // tabPageInsert
      // 
      this.tabPageInsert.Controls.Add(this.buttonInsert);
      this.tabPageInsert.Controls.Add(this.labelInsertNumberOfLinesTarget);
      this.tabPageInsert.Controls.Add(this.labelInsertNumberOfLinesSource);
      this.tabPageInsert.Controls.Add(this.buttonInsertLoad);
      this.tabPageInsert.Controls.Add(this.dataGridViewInsertTarget);
      this.tabPageInsert.Controls.Add(this.dataGridViewInsertSource);
      this.tabPageInsert.Controls.Add(this.comboBoxInsertSchemaTarget);
      this.tabPageInsert.Controls.Add(this.labelInsertSchemaTarget);
      this.tabPageInsert.Controls.Add(this.comboBoxInsertTableSource);
      this.tabPageInsert.Controls.Add(this.labelInsertTableNameTarget);
      this.tabPageInsert.Controls.Add(this.labelInsertTableNameSource);
      this.tabPageInsert.Controls.Add(this.comboBoxInsertTableNameTarget);
      this.tabPageInsert.Controls.Add(this.labelInsertTarget);
      this.tabPageInsert.Controls.Add(this.labelInsertSource);
      this.tabPageInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabPageInsert.Location = new System.Drawing.Point(4, 22);
      this.tabPageInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.tabPageInsert.Name = "tabPageInsert";
      this.tabPageInsert.Size = new System.Drawing.Size(1275, 696);
      this.tabPageInsert.TabIndex = 2;
      this.tabPageInsert.Text = "Insert";
      this.tabPageInsert.UseVisualStyleBackColor = true;
      // 
      // buttonInsert
      // 
      this.buttonInsert.Location = new System.Drawing.Point(662, 226);
      this.buttonInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonInsert.Name = "buttonInsert";
      this.buttonInsert.Size = new System.Drawing.Size(80, 31);
      this.buttonInsert.TabIndex = 127;
      this.buttonInsert.Text = "INSERT";
      this.buttonInsert.UseVisualStyleBackColor = true;
      this.buttonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
      // 
      // labelInsertNumberOfLinesTarget
      // 
      this.labelInsertNumberOfLinesTarget.AutoSize = true;
      this.labelInsertNumberOfLinesTarget.Location = new System.Drawing.Point(745, 122);
      this.labelInsertNumberOfLinesTarget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelInsertNumberOfLinesTarget.Name = "labelInsertNumberOfLinesTarget";
      this.labelInsertNumberOfLinesTarget.Size = new System.Drawing.Size(237, 20);
      this.labelInsertNumberOfLinesTarget.TabIndex = 126;
      this.labelInsertNumberOfLinesTarget.Text = "Number of lines in target table: 0";
      // 
      // labelInsertNumberOfLinesSource
      // 
      this.labelInsertNumberOfLinesSource.AutoSize = true;
      this.labelInsertNumberOfLinesSource.Location = new System.Drawing.Point(29, 122);
      this.labelInsertNumberOfLinesSource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelInsertNumberOfLinesSource.Name = "labelInsertNumberOfLinesSource";
      this.labelInsertNumberOfLinesSource.Size = new System.Drawing.Size(243, 20);
      this.labelInsertNumberOfLinesSource.TabIndex = 125;
      this.labelInsertNumberOfLinesSource.Text = "Number of lines in source table: 0";
      // 
      // buttonInsertLoad
      // 
      this.buttonInsertLoad.Location = new System.Drawing.Point(662, 173);
      this.buttonInsertLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonInsertLoad.Name = "buttonInsertLoad";
      this.buttonInsertLoad.Size = new System.Drawing.Size(80, 31);
      this.buttonInsertLoad.TabIndex = 124;
      this.buttonInsertLoad.Text = "LOAD";
      this.buttonInsertLoad.UseVisualStyleBackColor = true;
      this.buttonInsertLoad.Click += new System.EventHandler(this.ButtonInsertLoad_Click);
      // 
      // dataGridViewInsertTarget
      // 
      this.dataGridViewInsertTarget.AllowUserToAddRows = false;
      this.dataGridViewInsertTarget.AllowUserToDeleteRows = false;
      this.dataGridViewInsertTarget.AllowUserToOrderColumns = true;
      this.dataGridViewInsertTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewInsertTarget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewInsertTarget.Location = new System.Drawing.Point(748, 173);
      this.dataGridViewInsertTarget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.dataGridViewInsertTarget.Name = "dataGridViewInsertTarget";
      this.dataGridViewInsertTarget.ReadOnly = true;
      this.dataGridViewInsertTarget.RowHeadersWidth = 62;
      this.dataGridViewInsertTarget.RowTemplate.Height = 28;
      this.dataGridViewInsertTarget.Size = new System.Drawing.Size(506, 506);
      this.dataGridViewInsertTarget.TabIndex = 123;
      // 
      // dataGridViewInsertSource
      // 
      this.dataGridViewInsertSource.AllowUserToAddRows = false;
      this.dataGridViewInsertSource.AllowUserToDeleteRows = false;
      this.dataGridViewInsertSource.AllowUserToOrderColumns = true;
      this.dataGridViewInsertSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.dataGridViewInsertSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewInsertSource.Location = new System.Drawing.Point(31, 173);
      this.dataGridViewInsertSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.dataGridViewInsertSource.Name = "dataGridViewInsertSource";
      this.dataGridViewInsertSource.ReadOnly = true;
      this.dataGridViewInsertSource.RowHeadersWidth = 62;
      this.dataGridViewInsertSource.RowTemplate.Height = 28;
      this.dataGridViewInsertSource.Size = new System.Drawing.Size(627, 506);
      this.dataGridViewInsertSource.TabIndex = 122;
      // 
      // comboBoxInsertSchemaTarget
      // 
      this.comboBoxInsertSchemaTarget.FormattingEnabled = true;
      this.comboBoxInsertSchemaTarget.Location = new System.Drawing.Point(891, 58);
      this.comboBoxInsertSchemaTarget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBoxInsertSchemaTarget.Name = "comboBoxInsertSchemaTarget";
      this.comboBoxInsertSchemaTarget.Size = new System.Drawing.Size(349, 28);
      this.comboBoxInsertSchemaTarget.TabIndex = 120;
      this.comboBoxInsertSchemaTarget.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInsertSchemaTarget_SelectedIndexChanged);
      // 
      // labelInsertSchemaTarget
      // 
      this.labelInsertSchemaTarget.AutoSize = true;
      this.labelInsertSchemaTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelInsertSchemaTarget.Location = new System.Drawing.Point(745, 63);
      this.labelInsertSchemaTarget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelInsertSchemaTarget.Name = "labelInsertSchemaTarget";
      this.labelInsertSchemaTarget.Size = new System.Drawing.Size(72, 20);
      this.labelInsertSchemaTarget.TabIndex = 121;
      this.labelInsertSchemaTarget.Text = "Schema:";
      // 
      // comboBoxInsertTableSource
      // 
      this.comboBoxInsertTableSource.FormattingEnabled = true;
      this.comboBoxInsertTableSource.Location = new System.Drawing.Point(131, 89);
      this.comboBoxInsertTableSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBoxInsertTableSource.Name = "comboBoxInsertTableSource";
      this.comboBoxInsertTableSource.Size = new System.Drawing.Size(349, 28);
      this.comboBoxInsertTableSource.TabIndex = 118;
      // 
      // labelInsertTableNameTarget
      // 
      this.labelInsertTableNameTarget.AutoSize = true;
      this.labelInsertTableNameTarget.Location = new System.Drawing.Point(745, 89);
      this.labelInsertTableNameTarget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelInsertTableNameTarget.Name = "labelInsertTableNameTarget";
      this.labelInsertTableNameTarget.Size = new System.Drawing.Size(96, 20);
      this.labelInsertTableNameTarget.TabIndex = 119;
      this.labelInsertTableNameTarget.Text = "Table name:";
      // 
      // labelInsertTableNameSource
      // 
      this.labelInsertTableNameSource.AutoSize = true;
      this.labelInsertTableNameSource.Location = new System.Drawing.Point(29, 89);
      this.labelInsertTableNameSource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelInsertTableNameSource.Name = "labelInsertTableNameSource";
      this.labelInsertTableNameSource.Size = new System.Drawing.Size(96, 20);
      this.labelInsertTableNameSource.TabIndex = 117;
      this.labelInsertTableNameSource.Text = "Table name:";
      // 
      // comboBoxInsertTableNameTarget
      // 
      this.comboBoxInsertTableNameTarget.FormattingEnabled = true;
      this.comboBoxInsertTableNameTarget.Location = new System.Drawing.Point(891, 89);
      this.comboBoxInsertTableNameTarget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBoxInsertTableNameTarget.Name = "comboBoxInsertTableNameTarget";
      this.comboBoxInsertTableNameTarget.Size = new System.Drawing.Size(349, 28);
      this.comboBoxInsertTableNameTarget.TabIndex = 116;
      // 
      // labelInsertTarget
      // 
      this.labelInsertTarget.AutoSize = true;
      this.labelInsertTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelInsertTarget.Location = new System.Drawing.Point(744, 19);
      this.labelInsertTarget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelInsertTarget.Name = "labelInsertTarget";
      this.labelInsertTarget.Size = new System.Drawing.Size(183, 24);
      this.labelInsertTarget.TabIndex = 110;
      this.labelInsertTarget.Text = "Target: PostgreSql";
      // 
      // labelInsertSource
      // 
      this.labelInsertSource.AutoSize = true;
      this.labelInsertSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelInsertSource.Location = new System.Drawing.Point(27, 19);
      this.labelInsertSource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelInsertSource.Name = "labelInsertSource";
      this.labelInsertSource.Size = new System.Drawing.Size(151, 24);
      this.labelInsertSource.TabIndex = 109;
      this.labelInsertSource.Text = "Source: Oracle";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1283, 768);
      this.Controls.Add(this.tabControlMain);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FormMain";
      this.Text = "Fred Oracle PostgreSQL Data Compare";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabControlMain.ResumeLayout(false);
      this.tabPageConnection.ResumeLayout(false);
      this.tabPageConnection.PerformLayout();
      this.tabPageTables.ResumeLayout(false);
      this.tableLayoutPanelTables.ResumeLayout(false);
      this.tableLayoutPanelTables.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostgreSql)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOracle)).EndInit();
      this.tabPageInsert.ResumeLayout(false);
      this.tabPageInsert.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsertTarget)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsertSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem enregistrersousToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aperçuavantimpressionToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem sélectionnertoutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem personnaliserToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sommaireToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabPageConnection;
    private System.Windows.Forms.TabPage tabPageTables;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLanguage;
    private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    private System.Windows.Forms.Button buttonRefreshTarget;
    private System.Windows.Forms.Button buttonRefreshSource;
    private System.Windows.Forms.Button buttonCopyDatabaseName;
    private System.Windows.Forms.Button buttonCopyUserName;
    private System.Windows.Forms.TextBox textBoxTargetServer;
    private System.Windows.Forms.TextBox textBoxSourceServer;
    private System.Windows.Forms.TextBox textBoxDatabaseNameTarget;
    private System.Windows.Forms.Label labelDatabaseNameTarget;
    private System.Windows.Forms.TextBox textBoxDatabaseNameSource;
    private System.Windows.Forms.Label labelDatabaseNameSource;
    private System.Windows.Forms.Button buttonTestconnectionTarget;
    private System.Windows.Forms.Button buttonTestConnectionSource;
    private System.Windows.Forms.TextBox textBoxTargetPort;
    private System.Windows.Forms.TextBox textBoxSourcePort;
    private System.Windows.Forms.Label labelTargetPort;
    private System.Windows.Forms.Label labelSourcePort;
    private System.Windows.Forms.Button buttonCopyServerName;
    private System.Windows.Forms.Button buttonCopyPassword;
    private System.Windows.Forms.Button buttonCompareCompareNow;
    private System.Windows.Forms.Button buttonTargetCreate;
    private System.Windows.Forms.Button buttonTargetRefresh;
    private System.Windows.Forms.Label labelTargetDatabase;
    private System.Windows.Forms.ComboBox comboBoxTargetDatabase;
    private System.Windows.Forms.CheckBox checkBoxTargetRememberCredentials;
    private System.Windows.Forms.TextBox textBoxTargetPassword;
    private System.Windows.Forms.TextBox textBoxTargetName;
    private System.Windows.Forms.Label labelTargetPassword;
    private System.Windows.Forms.Label labelTargetUserName;
    private System.Windows.Forms.ComboBox comboBoxTargetSchema;
    private System.Windows.Forms.Label labelTargetSchema;
    private System.Windows.Forms.Label labelTargetServer;
    private System.Windows.Forms.Label labelTargetOperation;
    private System.Windows.Forms.Button buttonSourceCreate;
    private System.Windows.Forms.Button buttonSourceRefresh;
    private System.Windows.Forms.Label labelSourceDatabase;
    private System.Windows.Forms.ComboBox comboBoxSourceDatabase;
    private System.Windows.Forms.CheckBox checkBoxSourceRememberCredentials;
    private System.Windows.Forms.TextBox textBoxSourcePassword;
    private System.Windows.Forms.TextBox textBoxSourceName;
    private System.Windows.Forms.Label labelSourcePassword;
    private System.Windows.Forms.Label labelSourceUserName;
    private System.Windows.Forms.ComboBox comboBoxSourceSchema;
    private System.Windows.Forms.Label labelSourceSchema;
    private System.Windows.Forms.Label labelSourceServer;
    private System.Windows.Forms.Label labelSourceOperation;
    private System.Windows.Forms.Label labelTablesTarget;
    private System.Windows.Forms.Label labelTablesSource;
    private System.Windows.Forms.DataGridView dataGridViewOracle;
    private System.Windows.Forms.DataGridView dataGridViewPostgreSql;
    private System.Windows.Forms.Label labelPostgresqlTable;
    private System.Windows.Forms.ComboBox comboBoxPostgresqlTable;
    private System.Windows.Forms.Label labelOracleTable;
    private System.Windows.Forms.ComboBox comboBoxOracleTable;
    private System.Windows.Forms.Label labelSchema;
    private System.Windows.Forms.ComboBox comboBoxPostgresqlSchema;
    private System.Windows.Forms.Label labelTablesTargetNumberOfLines;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTables;
    private System.Windows.Forms.Label labelTablesSourceNumberOfLines;
    private System.Windows.Forms.Button buttonTablesCompare;
    private System.Windows.Forms.Label labelNumberOfLinesInOracleButNotInPostgreSql;
    private System.Windows.Forms.Label labelNumberOfLinesInPostgreSqlButNotInOracle;
    private System.Windows.Forms.TabPage tabPageInsert;
    private System.Windows.Forms.Label labelInsertTarget;
    private System.Windows.Forms.Label labelInsertSource;
    private System.Windows.Forms.ComboBox comboBoxInsertTableSource;
    private System.Windows.Forms.Label labelInsertTableNameTarget;
    private System.Windows.Forms.Label labelInsertTableNameSource;
    private System.Windows.Forms.ComboBox comboBoxInsertTableNameTarget;
    private System.Windows.Forms.ComboBox comboBoxInsertSchemaTarget;
    private System.Windows.Forms.Label labelInsertSchemaTarget;
    private System.Windows.Forms.DataGridView dataGridViewInsertTarget;
    private System.Windows.Forms.DataGridView dataGridViewInsertSource;
    private System.Windows.Forms.Button buttonInsertLoad;
    private System.Windows.Forms.Label labelInsertNumberOfLinesTarget;
    private System.Windows.Forms.Label labelInsertNumberOfLinesSource;
    private System.Windows.Forms.Button buttonInsert;
  }
}

