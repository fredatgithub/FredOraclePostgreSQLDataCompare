namespace FredOraclePostgreSQLDataCompare
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
      this.buttonTablesCompare = new System.Windows.Forms.Button();
      this.labelSchema = new System.Windows.Forms.Label();
      this.comboBoxPostgresqlSchema = new System.Windows.Forms.ComboBox();
      this.labelPostgresqlTable = new System.Windows.Forms.Label();
      this.comboBoxPostgresqlTable = new System.Windows.Forms.ComboBox();
      this.labelOracleTable = new System.Windows.Forms.Label();
      this.comboBoxOracleTable = new System.Windows.Forms.ComboBox();
      this.dataGridViewPostgreSql = new System.Windows.Forms.DataGridView();
      this.dataGridViewOracle = new System.Windows.Forms.DataGridView();
      this.labelTablesTarget = new System.Windows.Forms.Label();
      this.labelTablesSource = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      this.tabControlMain.SuspendLayout();
      this.tabPageConnection.SuspendLayout();
      this.tabPageTables.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostgreSql)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOracle)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.toolStripMenuItemLanguage,
            this.aideToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1473, 36);
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
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
      this.fichierToolStripMenuItem.Text = "&Fichier";
      // 
      // nouveauToolStripMenuItem
      // 
      this.nouveauToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem.Image")));
      this.nouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
      this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
      this.nouveauToolStripMenuItem.Text = "&Nouveau";
      // 
      // ouvrirToolStripMenuItem
      // 
      this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
      this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
      this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
      this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(307, 6);
      // 
      // enregistrerToolStripMenuItem
      // 
      this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
      this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
      this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
      this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
      // 
      // enregistrersousToolStripMenuItem
      // 
      this.enregistrersousToolStripMenuItem.Name = "enregistrersousToolStripMenuItem";
      this.enregistrersousToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
      this.enregistrersousToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(307, 6);
      // 
      // imprimerToolStripMenuItem
      // 
      this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
      this.imprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
      this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
      this.imprimerToolStripMenuItem.Text = "&Imprimer";
      // 
      // aperçuavantimpressionToolStripMenuItem
      // 
      this.aperçuavantimpressionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem.Image")));
      this.aperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.aperçuavantimpressionToolStripMenuItem.Name = "aperçuavantimpressionToolStripMenuItem";
      this.aperçuavantimpressionToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
      this.aperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(307, 6);
      // 
      // quitterToolStripMenuItem
      // 
      this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
      this.quitterToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
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
      this.editionToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
      this.editionToolStripMenuItem.Text = "&Edition";
      // 
      // annulerToolStripMenuItem
      // 
      this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
      this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.annulerToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
      this.annulerToolStripMenuItem.Text = "&Annuler";
      // 
      // rétablirToolStripMenuItem
      // 
      this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
      this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
      this.rétablirToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(245, 6);
      // 
      // couperToolStripMenuItem
      // 
      this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
      this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
      this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.couperToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
      this.couperToolStripMenuItem.Text = "&Couper";
      // 
      // copierToolStripMenuItem
      // 
      this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
      this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
      this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copierToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
      this.copierToolStripMenuItem.Text = "Co&pier";
      // 
      // collerToolStripMenuItem
      // 
      this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
      this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
      this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.collerToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
      this.collerToolStripMenuItem.Text = "Co&ller";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(245, 6);
      // 
      // sélectionnertoutToolStripMenuItem
      // 
      this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
      this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
      this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
      // 
      // outilsToolStripMenuItem
      // 
      this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnaliserToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
      this.outilsToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
      this.outilsToolStripMenuItem.Text = "&Outils";
      // 
      // personnaliserToolStripMenuItem
      // 
      this.personnaliserToolStripMenuItem.Name = "personnaliserToolStripMenuItem";
      this.personnaliserToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
      this.personnaliserToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // toolStripMenuItemLanguage
      // 
      this.toolStripMenuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frenchToolStripMenuItem,
            this.englishToolStripMenuItem});
      this.toolStripMenuItemLanguage.Name = "toolStripMenuItemLanguage";
      this.toolStripMenuItemLanguage.Size = new System.Drawing.Size(105, 29);
      this.toolStripMenuItemLanguage.Text = "Language";
      // 
      // frenchToolStripMenuItem
      // 
      this.frenchToolStripMenuItem.Checked = true;
      this.frenchToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
      this.frenchToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
      this.frenchToolStripMenuItem.Text = "French";
      this.frenchToolStripMenuItem.Click += new System.EventHandler(this.FrenchToolStripMenuItem_Click);
      // 
      // englishToolStripMenuItem
      // 
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
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
      this.aideToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
      this.aideToolStripMenuItem.Text = "&Aide";
      // 
      // sommaireToolStripMenuItem
      // 
      this.sommaireToolStripMenuItem.Name = "sommaireToolStripMenuItem";
      this.sommaireToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
      this.sommaireToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // rechercherToolStripMenuItem
      // 
      this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
      this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
      this.rechercherToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(223, 6);
      // 
      // àproposdeToolStripMenuItem
      // 
      this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
      this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
      this.àproposdeToolStripMenuItem.Text = "À &propos de...";
      this.àproposdeToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.statusStrip1.Location = new System.Drawing.Point(0, 1041);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
      this.statusStrip1.Size = new System.Drawing.Size(1473, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tabControlMain
      // 
      this.tabControlMain.Controls.Add(this.tabPageConnection);
      this.tabControlMain.Controls.Add(this.tabPageTables);
      this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlMain.Location = new System.Drawing.Point(0, 36);
      this.tabControlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabControlMain.Name = "tabControlMain";
      this.tabControlMain.SelectedIndex = 0;
      this.tabControlMain.Size = new System.Drawing.Size(1473, 1005);
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
      this.tabPageConnection.Location = new System.Drawing.Point(4, 29);
      this.tabPageConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPageConnection.Name = "tabPageConnection";
      this.tabPageConnection.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPageConnection.Size = new System.Drawing.Size(1465, 975);
      this.tabPageConnection.TabIndex = 0;
      this.tabPageConnection.Text = "Connection";
      this.tabPageConnection.UseVisualStyleBackColor = true;
      this.tabPageConnection.Click += new System.EventHandler(this.TabPageConnection_Click);
      // 
      // buttonRefreshTarget
      // 
      this.buttonRefreshTarget.Location = new System.Drawing.Point(1232, 772);
      this.buttonRefreshTarget.Name = "buttonRefreshTarget";
      this.buttonRefreshTarget.Size = new System.Drawing.Size(118, 38);
      this.buttonRefreshTarget.TabIndex = 138;
      this.buttonRefreshTarget.Text = "Refresh";
      this.buttonRefreshTarget.UseVisualStyleBackColor = true;
      this.buttonRefreshTarget.Click += new System.EventHandler(this.ButtonRefreshTarget_Click);
      // 
      // buttonRefreshSource
      // 
      this.buttonRefreshSource.Location = new System.Drawing.Point(466, 777);
      this.buttonRefreshSource.Name = "buttonRefreshSource";
      this.buttonRefreshSource.Size = new System.Drawing.Size(118, 38);
      this.buttonRefreshSource.TabIndex = 137;
      this.buttonRefreshSource.Text = "Refresh";
      this.buttonRefreshSource.UseVisualStyleBackColor = true;
      this.buttonRefreshSource.Click += new System.EventHandler(this.ButtonRefreshSource_Click);
      // 
      // buttonCopyDatabaseName
      // 
      this.buttonCopyDatabaseName.Location = new System.Drawing.Point(680, 448);
      this.buttonCopyDatabaseName.Name = "buttonCopyDatabaseName";
      this.buttonCopyDatabaseName.Size = new System.Drawing.Size(70, 34);
      this.buttonCopyDatabaseName.TabIndex = 136;
      this.buttonCopyDatabaseName.Text = "-->";
      this.buttonCopyDatabaseName.UseVisualStyleBackColor = true;
      this.buttonCopyDatabaseName.Click += new System.EventHandler(this.ButtonCopyDatabaseName_Click);
      // 
      // buttonCopyUserName
      // 
      this.buttonCopyUserName.Location = new System.Drawing.Point(680, 346);
      this.buttonCopyUserName.Name = "buttonCopyUserName";
      this.buttonCopyUserName.Size = new System.Drawing.Size(70, 34);
      this.buttonCopyUserName.TabIndex = 135;
      this.buttonCopyUserName.Text = "-->";
      this.buttonCopyUserName.UseVisualStyleBackColor = true;
      this.buttonCopyUserName.Click += new System.EventHandler(this.ButtonCopyUserName_Click);
      // 
      // textBoxTargetServer
      // 
      this.textBoxTargetServer.Location = new System.Drawing.Point(790, 240);
      this.textBoxTargetServer.Name = "textBoxTargetServer";
      this.textBoxTargetServer.Size = new System.Drawing.Size(630, 35);
      this.textBoxTargetServer.TabIndex = 134;
      // 
      // textBoxSourceServer
      // 
      this.textBoxSourceServer.Location = new System.Drawing.Point(40, 240);
      this.textBoxSourceServer.Name = "textBoxSourceServer";
      this.textBoxSourceServer.Size = new System.Drawing.Size(608, 35);
      this.textBoxSourceServer.TabIndex = 133;
      // 
      // textBoxDatabaseNameTarget
      // 
      this.textBoxDatabaseNameTarget.Location = new System.Drawing.Point(994, 449);
      this.textBoxDatabaseNameTarget.Name = "textBoxDatabaseNameTarget";
      this.textBoxDatabaseNameTarget.Size = new System.Drawing.Size(426, 35);
      this.textBoxDatabaseNameTarget.TabIndex = 132;
      // 
      // labelDatabaseNameTarget
      // 
      this.labelDatabaseNameTarget.AutoSize = true;
      this.labelDatabaseNameTarget.Location = new System.Drawing.Point(784, 449);
      this.labelDatabaseNameTarget.Name = "labelDatabaseNameTarget";
      this.labelDatabaseNameTarget.Size = new System.Drawing.Size(186, 29);
      this.labelDatabaseNameTarget.TabIndex = 131;
      this.labelDatabaseNameTarget.Text = "Database Name";
      // 
      // textBoxDatabaseNameSource
      // 
      this.textBoxDatabaseNameSource.Location = new System.Drawing.Point(222, 446);
      this.textBoxDatabaseNameSource.Name = "textBoxDatabaseNameSource";
      this.textBoxDatabaseNameSource.Size = new System.Drawing.Size(426, 35);
      this.textBoxDatabaseNameSource.TabIndex = 130;
      // 
      // labelDatabaseNameSource
      // 
      this.labelDatabaseNameSource.AutoSize = true;
      this.labelDatabaseNameSource.Location = new System.Drawing.Point(34, 449);
      this.labelDatabaseNameSource.Name = "labelDatabaseNameSource";
      this.labelDatabaseNameSource.Size = new System.Drawing.Size(186, 29);
      this.labelDatabaseNameSource.TabIndex = 129;
      this.labelDatabaseNameSource.Text = "Database Name";
      // 
      // buttonTestconnectionTarget
      // 
      this.buttonTestconnectionTarget.Location = new System.Drawing.Point(994, 554);
      this.buttonTestconnectionTarget.Name = "buttonTestconnectionTarget";
      this.buttonTestconnectionTarget.Size = new System.Drawing.Size(278, 38);
      this.buttonTestconnectionTarget.TabIndex = 128;
      this.buttonTestconnectionTarget.Text = "Test connection";
      this.buttonTestconnectionTarget.UseVisualStyleBackColor = true;
      this.buttonTestconnectionTarget.Click += new System.EventHandler(this.ButtonTestconnectionTarget_Click);
      // 
      // buttonTestConnectionSource
      // 
      this.buttonTestConnectionSource.Location = new System.Drawing.Point(222, 554);
      this.buttonTestConnectionSource.Name = "buttonTestConnectionSource";
      this.buttonTestConnectionSource.Size = new System.Drawing.Size(266, 38);
      this.buttonTestConnectionSource.TabIndex = 127;
      this.buttonTestConnectionSource.Text = "Test connection";
      this.buttonTestConnectionSource.UseVisualStyleBackColor = true;
      this.buttonTestConnectionSource.Click += new System.EventHandler(this.ButtonTestConnection_Click);
      // 
      // textBoxTargetPort
      // 
      this.textBoxTargetPort.Location = new System.Drawing.Point(994, 298);
      this.textBoxTargetPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBoxTargetPort.Name = "textBoxTargetPort";
      this.textBoxTargetPort.Size = new System.Drawing.Size(214, 35);
      this.textBoxTargetPort.TabIndex = 126;
      this.textBoxTargetPort.Text = "5432";
      // 
      // textBoxSourcePort
      // 
      this.textBoxSourcePort.Location = new System.Drawing.Point(222, 300);
      this.textBoxSourcePort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBoxSourcePort.Name = "textBoxSourcePort";
      this.textBoxSourcePort.Size = new System.Drawing.Size(214, 35);
      this.textBoxSourcePort.TabIndex = 125;
      this.textBoxSourcePort.Text = "1521";
      // 
      // labelTargetPort
      // 
      this.labelTargetPort.AutoSize = true;
      this.labelTargetPort.Location = new System.Drawing.Point(784, 303);
      this.labelTargetPort.Name = "labelTargetPort";
      this.labelTargetPort.Size = new System.Drawing.Size(63, 29);
      this.labelTargetPort.TabIndex = 124;
      this.labelTargetPort.Text = "Port:";
      // 
      // labelSourcePort
      // 
      this.labelSourcePort.AutoSize = true;
      this.labelSourcePort.Location = new System.Drawing.Point(32, 303);
      this.labelSourcePort.Name = "labelSourcePort";
      this.labelSourcePort.Size = new System.Drawing.Size(63, 29);
      this.labelSourcePort.TabIndex = 123;
      this.labelSourcePort.Text = "Port:";
      // 
      // buttonCopyServerName
      // 
      this.buttonCopyServerName.Location = new System.Drawing.Point(680, 242);
      this.buttonCopyServerName.Name = "buttonCopyServerName";
      this.buttonCopyServerName.Size = new System.Drawing.Size(70, 34);
      this.buttonCopyServerName.TabIndex = 122;
      this.buttonCopyServerName.Text = "-->";
      this.buttonCopyServerName.UseVisualStyleBackColor = true;
      this.buttonCopyServerName.Click += new System.EventHandler(this.ButtonCopyServerName_Click);
      // 
      // buttonCopyPassword
      // 
      this.buttonCopyPassword.Location = new System.Drawing.Point(680, 394);
      this.buttonCopyPassword.Name = "buttonCopyPassword";
      this.buttonCopyPassword.Size = new System.Drawing.Size(70, 34);
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
      this.buttonCompareCompareNow.Location = new System.Drawing.Point(646, 894);
      this.buttonCompareCompareNow.Name = "buttonCompareCompareNow";
      this.buttonCompareCompareNow.Size = new System.Drawing.Size(165, 46);
      this.buttonCompareCompareNow.TabIndex = 120;
      this.buttonCompareCompareNow.Text = "Compare now";
      this.buttonCompareCompareNow.UseVisualStyleBackColor = false;
      this.buttonCompareCompareNow.Click += new System.EventHandler(this.ButtonCompareCompareNow_Click);
      // 
      // buttonTargetCreate
      // 
      this.buttonTargetCreate.Location = new System.Drawing.Point(789, 709);
      this.buttonTargetCreate.Name = "buttonTargetCreate";
      this.buttonTargetCreate.Size = new System.Drawing.Size(100, 38);
      this.buttonTargetCreate.TabIndex = 119;
      this.buttonTargetCreate.Text = "Create";
      this.buttonTargetCreate.UseVisualStyleBackColor = true;
      this.buttonTargetCreate.Click += new System.EventHandler(this.ButtonTargetCreate_Click);
      // 
      // buttonTargetRefresh
      // 
      this.buttonTargetRefresh.Location = new System.Drawing.Point(1236, 646);
      this.buttonTargetRefresh.Name = "buttonTargetRefresh";
      this.buttonTargetRefresh.Size = new System.Drawing.Size(112, 38);
      this.buttonTargetRefresh.TabIndex = 118;
      this.buttonTargetRefresh.Text = "Refresh";
      this.buttonTargetRefresh.UseVisualStyleBackColor = true;
      this.buttonTargetRefresh.Click += new System.EventHandler(this.ButtonTargetRefresh_Click);
      // 
      // labelTargetDatabase
      // 
      this.labelTargetDatabase.AutoSize = true;
      this.labelTargetDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTargetDatabase.Location = new System.Drawing.Point(789, 606);
      this.labelTargetDatabase.Name = "labelTargetDatabase";
      this.labelTargetDatabase.Size = new System.Drawing.Size(123, 29);
      this.labelTargetDatabase.TabIndex = 117;
      this.labelTargetDatabase.Text = "Database";
      // 
      // comboBoxTargetDatabase
      // 
      this.comboBoxTargetDatabase.FormattingEnabled = true;
      this.comboBoxTargetDatabase.Location = new System.Drawing.Point(792, 649);
      this.comboBoxTargetDatabase.Name = "comboBoxTargetDatabase";
      this.comboBoxTargetDatabase.Size = new System.Drawing.Size(438, 37);
      this.comboBoxTargetDatabase.TabIndex = 116;
      this.comboBoxTargetDatabase.Text = "Database name";
      // 
      // checkBoxTargetRememberCredentials
      // 
      this.checkBoxTargetRememberCredentials.AutoSize = true;
      this.checkBoxTargetRememberCredentials.Location = new System.Drawing.Point(994, 505);
      this.checkBoxTargetRememberCredentials.Name = "checkBoxTargetRememberCredentials";
      this.checkBoxTargetRememberCredentials.Size = new System.Drawing.Size(284, 33);
      this.checkBoxTargetRememberCredentials.TabIndex = 115;
      this.checkBoxTargetRememberCredentials.Text = "Remember credentials";
      this.checkBoxTargetRememberCredentials.UseVisualStyleBackColor = true;
      // 
      // textBoxTargetPassword
      // 
      this.textBoxTargetPassword.Location = new System.Drawing.Point(994, 394);
      this.textBoxTargetPassword.Name = "textBoxTargetPassword";
      this.textBoxTargetPassword.PasswordChar = '*';
      this.textBoxTargetPassword.Size = new System.Drawing.Size(426, 35);
      this.textBoxTargetPassword.TabIndex = 114;
      // 
      // textBoxTargetName
      // 
      this.textBoxTargetName.Location = new System.Drawing.Point(994, 345);
      this.textBoxTargetName.Name = "textBoxTargetName";
      this.textBoxTargetName.Size = new System.Drawing.Size(426, 35);
      this.textBoxTargetName.TabIndex = 113;
      // 
      // labelTargetPassword
      // 
      this.labelTargetPassword.AutoSize = true;
      this.labelTargetPassword.Location = new System.Drawing.Point(784, 394);
      this.labelTargetPassword.Name = "labelTargetPassword";
      this.labelTargetPassword.Size = new System.Drawing.Size(120, 29);
      this.labelTargetPassword.TabIndex = 112;
      this.labelTargetPassword.Text = "Password";
      // 
      // labelTargetUserName
      // 
      this.labelTargetUserName.AutoSize = true;
      this.labelTargetUserName.Location = new System.Drawing.Point(784, 345);
      this.labelTargetUserName.Name = "labelTargetUserName";
      this.labelTargetUserName.Size = new System.Drawing.Size(135, 29);
      this.labelTargetUserName.TabIndex = 111;
      this.labelTargetUserName.Text = "User Name";
      // 
      // comboBoxTargetSchema
      // 
      this.comboBoxTargetSchema.FormattingEnabled = true;
      this.comboBoxTargetSchema.Location = new System.Drawing.Point(906, 775);
      this.comboBoxTargetSchema.Name = "comboBoxTargetSchema";
      this.comboBoxTargetSchema.Size = new System.Drawing.Size(319, 37);
      this.comboBoxTargetSchema.TabIndex = 110;
      // 
      // labelTargetSchema
      // 
      this.labelTargetSchema.AutoSize = true;
      this.labelTargetSchema.Location = new System.Drawing.Point(789, 782);
      this.labelTargetSchema.Name = "labelTargetSchema";
      this.labelTargetSchema.Size = new System.Drawing.Size(101, 29);
      this.labelTargetSchema.TabIndex = 109;
      this.labelTargetSchema.Text = "Schema";
      // 
      // labelTargetServer
      // 
      this.labelTargetServer.AutoSize = true;
      this.labelTargetServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTargetServer.Location = new System.Drawing.Point(789, 197);
      this.labelTargetServer.Name = "labelTargetServer";
      this.labelTargetServer.Size = new System.Drawing.Size(239, 29);
      this.labelTargetServer.TabIndex = 108;
      this.labelTargetServer.Text = "PostgreSQL Server";
      // 
      // labelTargetOperation
      // 
      this.labelTargetOperation.AutoSize = true;
      this.labelTargetOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTargetOperation.Location = new System.Drawing.Point(783, 117);
      this.labelTargetOperation.Name = "labelTargetOperation";
      this.labelTargetOperation.Size = new System.Drawing.Size(102, 32);
      this.labelTargetOperation.TabIndex = 107;
      this.labelTargetOperation.Text = "Target";
      // 
      // buttonSourceCreate
      // 
      this.buttonSourceCreate.Location = new System.Drawing.Point(33, 709);
      this.buttonSourceCreate.Name = "buttonSourceCreate";
      this.buttonSourceCreate.Size = new System.Drawing.Size(99, 38);
      this.buttonSourceCreate.TabIndex = 106;
      this.buttonSourceCreate.Text = "Create";
      this.buttonSourceCreate.UseVisualStyleBackColor = true;
      this.buttonSourceCreate.Click += new System.EventHandler(this.ButtonSourceCreate_Click);
      // 
      // buttonSourceRefresh
      // 
      this.buttonSourceRefresh.Location = new System.Drawing.Point(459, 649);
      this.buttonSourceRefresh.Name = "buttonSourceRefresh";
      this.buttonSourceRefresh.Size = new System.Drawing.Size(118, 38);
      this.buttonSourceRefresh.TabIndex = 105;
      this.buttonSourceRefresh.Text = "Refresh";
      this.buttonSourceRefresh.UseVisualStyleBackColor = true;
      this.buttonSourceRefresh.Click += new System.EventHandler(this.ButtonSourceRefresh_Click);
      // 
      // labelSourceDatabase
      // 
      this.labelSourceDatabase.AutoSize = true;
      this.labelSourceDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSourceDatabase.Location = new System.Drawing.Point(32, 611);
      this.labelSourceDatabase.Name = "labelSourceDatabase";
      this.labelSourceDatabase.Size = new System.Drawing.Size(123, 29);
      this.labelSourceDatabase.TabIndex = 104;
      this.labelSourceDatabase.Text = "Database";
      // 
      // comboBoxSourceDatabase
      // 
      this.comboBoxSourceDatabase.FormattingEnabled = true;
      this.comboBoxSourceDatabase.Location = new System.Drawing.Point(34, 652);
      this.comboBoxSourceDatabase.Name = "comboBoxSourceDatabase";
      this.comboBoxSourceDatabase.Size = new System.Drawing.Size(412, 37);
      this.comboBoxSourceDatabase.TabIndex = 103;
      this.comboBoxSourceDatabase.Text = "Database name";
      // 
      // checkBoxSourceRememberCredentials
      // 
      this.checkBoxSourceRememberCredentials.AutoSize = true;
      this.checkBoxSourceRememberCredentials.Location = new System.Drawing.Point(222, 502);
      this.checkBoxSourceRememberCredentials.Name = "checkBoxSourceRememberCredentials";
      this.checkBoxSourceRememberCredentials.Size = new System.Drawing.Size(284, 33);
      this.checkBoxSourceRememberCredentials.TabIndex = 102;
      this.checkBoxSourceRememberCredentials.Text = "Remember credentials";
      this.checkBoxSourceRememberCredentials.UseVisualStyleBackColor = true;
      // 
      // textBoxSourcePassword
      // 
      this.textBoxSourcePassword.Location = new System.Drawing.Point(222, 392);
      this.textBoxSourcePassword.Name = "textBoxSourcePassword";
      this.textBoxSourcePassword.PasswordChar = '*';
      this.textBoxSourcePassword.Size = new System.Drawing.Size(426, 35);
      this.textBoxSourcePassword.TabIndex = 101;
      // 
      // textBoxSourceName
      // 
      this.textBoxSourceName.Location = new System.Drawing.Point(222, 345);
      this.textBoxSourceName.Name = "textBoxSourceName";
      this.textBoxSourceName.Size = new System.Drawing.Size(426, 35);
      this.textBoxSourceName.TabIndex = 100;
      // 
      // labelSourcePassword
      // 
      this.labelSourcePassword.AutoSize = true;
      this.labelSourcePassword.Location = new System.Drawing.Point(32, 392);
      this.labelSourcePassword.Name = "labelSourcePassword";
      this.labelSourcePassword.Size = new System.Drawing.Size(120, 29);
      this.labelSourcePassword.TabIndex = 99;
      this.labelSourcePassword.Text = "Password";
      // 
      // labelSourceUserName
      // 
      this.labelSourceUserName.AutoSize = true;
      this.labelSourceUserName.Location = new System.Drawing.Point(32, 345);
      this.labelSourceUserName.Name = "labelSourceUserName";
      this.labelSourceUserName.Size = new System.Drawing.Size(135, 29);
      this.labelSourceUserName.TabIndex = 98;
      this.labelSourceUserName.Text = "User Name";
      // 
      // comboBoxSourceSchema
      // 
      this.comboBoxSourceSchema.FormattingEnabled = true;
      this.comboBoxSourceSchema.Location = new System.Drawing.Point(148, 778);
      this.comboBoxSourceSchema.Name = "comboBoxSourceSchema";
      this.comboBoxSourceSchema.Size = new System.Drawing.Size(298, 37);
      this.comboBoxSourceSchema.TabIndex = 97;
      // 
      // labelSourceSchema
      // 
      this.labelSourceSchema.AutoSize = true;
      this.labelSourceSchema.Location = new System.Drawing.Point(32, 778);
      this.labelSourceSchema.Name = "labelSourceSchema";
      this.labelSourceSchema.Size = new System.Drawing.Size(101, 29);
      this.labelSourceSchema.TabIndex = 96;
      this.labelSourceSchema.Text = "Schema";
      // 
      // labelSourceServer
      // 
      this.labelSourceServer.AutoSize = true;
      this.labelSourceServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSourceServer.Location = new System.Drawing.Point(28, 197);
      this.labelSourceServer.Name = "labelSourceServer";
      this.labelSourceServer.Size = new System.Drawing.Size(412, 35);
      this.labelSourceServer.TabIndex = 95;
      this.labelSourceServer.Text = "Oracle Server: network alias";
      // 
      // labelSourceOperation
      // 
      this.labelSourceOperation.AutoSize = true;
      this.labelSourceOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSourceOperation.Location = new System.Drawing.Point(28, 117);
      this.labelSourceOperation.Name = "labelSourceOperation";
      this.labelSourceOperation.Size = new System.Drawing.Size(110, 32);
      this.labelSourceOperation.TabIndex = 94;
      this.labelSourceOperation.Text = "Source";
      // 
      // tabPageTables
      // 
      this.tabPageTables.Controls.Add(this.buttonTablesCompare);
      this.tabPageTables.Controls.Add(this.labelSchema);
      this.tabPageTables.Controls.Add(this.comboBoxPostgresqlSchema);
      this.tabPageTables.Controls.Add(this.labelPostgresqlTable);
      this.tabPageTables.Controls.Add(this.comboBoxPostgresqlTable);
      this.tabPageTables.Controls.Add(this.labelOracleTable);
      this.tabPageTables.Controls.Add(this.comboBoxOracleTable);
      this.tabPageTables.Controls.Add(this.dataGridViewPostgreSql);
      this.tabPageTables.Controls.Add(this.dataGridViewOracle);
      this.tabPageTables.Controls.Add(this.labelTablesTarget);
      this.tabPageTables.Controls.Add(this.labelTablesSource);
      this.tabPageTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabPageTables.Location = new System.Drawing.Point(4, 29);
      this.tabPageTables.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPageTables.Name = "tabPageTables";
      this.tabPageTables.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPageTables.Size = new System.Drawing.Size(1465, 972);
      this.tabPageTables.TabIndex = 1;
      this.tabPageTables.Text = "Tables";
      this.tabPageTables.UseVisualStyleBackColor = true;
      this.tabPageTables.Click += new System.EventHandler(this.TabPageTables_Click);
      // 
      // buttonTablesCompare
      // 
      this.buttonTablesCompare.Location = new System.Drawing.Point(648, 200);
      this.buttonTablesCompare.Name = "buttonTablesCompare";
      this.buttonTablesCompare.Size = new System.Drawing.Size(129, 38);
      this.buttonTablesCompare.TabIndex = 118;
      this.buttonTablesCompare.Text = "Compare";
      this.buttonTablesCompare.UseVisualStyleBackColor = true;
      this.buttonTablesCompare.Click += new System.EventHandler(this.ButtonTablesCompare_Click);
      // 
      // labelSchema
      // 
      this.labelSchema.AutoSize = true;
      this.labelSchema.Location = new System.Drawing.Point(790, 95);
      this.labelSchema.Name = "labelSchema";
      this.labelSchema.Size = new System.Drawing.Size(107, 29);
      this.labelSchema.TabIndex = 117;
      this.labelSchema.Text = "Schema:";
      // 
      // comboBoxPostgresqlSchema
      // 
      this.comboBoxPostgresqlSchema.FormattingEnabled = true;
      this.comboBoxPostgresqlSchema.Location = new System.Drawing.Point(950, 92);
      this.comboBoxPostgresqlSchema.Name = "comboBoxPostgresqlSchema";
      this.comboBoxPostgresqlSchema.Size = new System.Drawing.Size(400, 37);
      this.comboBoxPostgresqlSchema.TabIndex = 116;
      this.comboBoxPostgresqlSchema.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPostgresqlSchema_SelectedIndexChanged);
      // 
      // labelPostgresqlTable
      // 
      this.labelPostgresqlTable.AutoSize = true;
      this.labelPostgresqlTable.Location = new System.Drawing.Point(790, 140);
      this.labelPostgresqlTable.Name = "labelPostgresqlTable";
      this.labelPostgresqlTable.Size = new System.Drawing.Size(148, 29);
      this.labelPostgresqlTable.TabIndex = 115;
      this.labelPostgresqlTable.Text = "Table name:";
      // 
      // comboBoxPostgresqlTable
      // 
      this.comboBoxPostgresqlTable.FormattingEnabled = true;
      this.comboBoxPostgresqlTable.Location = new System.Drawing.Point(950, 137);
      this.comboBoxPostgresqlTable.Name = "comboBoxPostgresqlTable";
      this.comboBoxPostgresqlTable.Size = new System.Drawing.Size(400, 37);
      this.comboBoxPostgresqlTable.TabIndex = 114;
      this.comboBoxPostgresqlTable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPostgresqlTable_SelectedIndexChanged);
      // 
      // labelOracleTable
      // 
      this.labelOracleTable.AutoSize = true;
      this.labelOracleTable.Location = new System.Drawing.Point(50, 135);
      this.labelOracleTable.Name = "labelOracleTable";
      this.labelOracleTable.Size = new System.Drawing.Size(148, 29);
      this.labelOracleTable.TabIndex = 113;
      this.labelOracleTable.Text = "Table name:";
      // 
      // comboBoxOracleTable
      // 
      this.comboBoxOracleTable.FormattingEnabled = true;
      this.comboBoxOracleTable.Location = new System.Drawing.Point(212, 132);
      this.comboBoxOracleTable.Name = "comboBoxOracleTable";
      this.comboBoxOracleTable.Size = new System.Drawing.Size(400, 37);
      this.comboBoxOracleTable.TabIndex = 112;
      this.comboBoxOracleTable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOracleTable_SelectedIndexChanged);
      // 
      // dataGridViewPostgreSql
      // 
      this.dataGridViewPostgreSql.AllowUserToAddRows = false;
      this.dataGridViewPostgreSql.AllowUserToDeleteRows = false;
      this.dataGridViewPostgreSql.AllowUserToOrderColumns = true;
      this.dataGridViewPostgreSql.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.dataGridViewPostgreSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewPostgreSql.Location = new System.Drawing.Point(794, 199);
      this.dataGridViewPostgreSql.Name = "dataGridViewPostgreSql";
      this.dataGridViewPostgreSql.ReadOnly = true;
      this.dataGridViewPostgreSql.RowHeadersWidth = 62;
      this.dataGridViewPostgreSql.RowTemplate.Height = 28;
      this.dataGridViewPostgreSql.Size = new System.Drawing.Size(556, 435);
      this.dataGridViewPostgreSql.TabIndex = 111;
      // 
      // dataGridViewOracle
      // 
      this.dataGridViewOracle.AllowUserToAddRows = false;
      this.dataGridViewOracle.AllowUserToDeleteRows = false;
      this.dataGridViewOracle.AllowUserToOrderColumns = true;
      this.dataGridViewOracle.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.dataGridViewOracle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewOracle.Location = new System.Drawing.Point(54, 199);
      this.dataGridViewOracle.Name = "dataGridViewOracle";
      this.dataGridViewOracle.ReadOnly = true;
      this.dataGridViewOracle.RowHeadersWidth = 62;
      this.dataGridViewOracle.RowTemplate.Height = 28;
      this.dataGridViewOracle.Size = new System.Drawing.Size(556, 435);
      this.dataGridViewOracle.TabIndex = 110;
      // 
      // labelTablesTarget
      // 
      this.labelTablesTarget.AutoSize = true;
      this.labelTablesTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTablesTarget.Location = new System.Drawing.Point(788, 48);
      this.labelTablesTarget.Name = "labelTablesTarget";
      this.labelTablesTarget.Size = new System.Drawing.Size(269, 32);
      this.labelTablesTarget.TabIndex = 109;
      this.labelTablesTarget.Text = "Target: PostgreSql";
      // 
      // labelTablesSource
      // 
      this.labelTablesSource.AutoSize = true;
      this.labelTablesSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTablesSource.Location = new System.Drawing.Point(48, 48);
      this.labelTablesSource.Name = "labelTablesSource";
      this.labelTablesSource.Size = new System.Drawing.Size(217, 32);
      this.labelTablesSource.TabIndex = 108;
      this.labelTablesSource.Text = "Source: Oracle";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1473, 1063);
      this.Controls.Add(this.tabControlMain);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
      this.tabPageTables.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostgreSql)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOracle)).EndInit();
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
    private System.Windows.Forms.Button buttonTablesCompare;
  }
}

