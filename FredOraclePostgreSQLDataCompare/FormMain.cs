//using System.Data.OracleClient;
using FredOraclePostgreSQLDataCompare.Properties;
using FredOraclePostgreSQLDataCompare.DAL;
using FredOraclePostgreSQLDataCompare.DAL.PostgreSql;
using log4net;
using log4net.Config;
using NamespaceYouAreUsing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Windows.Forms;
using System.Xml.Linq;
using Tools;


namespace FredOraclePostgreSQLDataCompare
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private readonly Dictionary<string, string> languageDicoEn = new Dictionary<string, string>();
    private readonly Dictionary<string, string> languageDicoFr = new Dictionary<string, string>();
    internal ILog logger = LogManager.GetLogger(typeof(FormMain));
    // don't forget to set always copy in properties of the file
    private string Log4NetConfigFilePath = "log4net.config.xml";
    private bool bothAuthenticationAreOk = false;
    private bool sourceAuthenticationIsOk = false;
    private bool targetAuthenticationIsOk = false;

    /// <summary>
    /// Key to be used to encrypt source parameters.
    /// </summary>
    private const string SourceKeyFilename = "SourceKey.pidb";
    private const string SourceSaltFilename = "SourceSalt.pidb";

    /// <summary>
    /// All the values encrypted for source parameters.
    /// </summary>
    private const string SourceValue1Filename = "SourceValue1.pidb";
    private const string SourceValue2Filename = "SourceValue2.pidb";
    private const string SourceValue3Filename = "SourceValue3.pidb";
    private const string SourceValue4Filename = "SourceValue4.pidb";
    private const string SourceValue5Filename = "SourceValue5.pidb";

    /// <summary>
    /// Key to be used to encrypt target parameters.
    /// </summary>
    private const string TargetKeyFilename = "TargetKey.pidb";
    private const string TargetSaltFilename = "TargetSalt.pidb";

    /// <summary>
    /// All the values encrypted for source parameters.
    /// </summary>
    private const string TargetValue1Filename = "TargetValue1.pidb";
    private const string TargetValue2Filename = "TargetValue2.pidb";
    private const string TargetValue3Filename = "TargetValue3.pidb";
    private const string TargetValue4Filename = "TargetValue4.pidb";
    private const string TargetValue5Filename = "TargetValue5.pidb";

    private void FormMain_Load(object sender, EventArgs e)
    {
      XmlConfigurator.ConfigureAndWatch(new FileInfo(Log4NetConfigFilePath));
      logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
      logger.Info(string.Empty);
      logger.Info("**************************");
      logger.Info("Démarrage de l'application");
      logger.Info($"Utilisateur connecté : {Environment.UserName}");
      logger.Info($"Version de l'application : {GetApplicationVersion()}");
      logger.Info($"Le nom du serveur applicatif est : {GetServerName()}");
      logger.Info($"Framework ciblé : {GetFramework()}");
      logger.Info($"Application compilée pour architecture : {GetEnvironment64BitProcess()}");
      logger.Info($"Framework installé sur le serveur en version : {GetFrameworkVersion()}");
      Text += GetApplicationVersion();

      GetWindowValue();
      LoadLanguages();
      SetLanguage(Settings.Default.LastLanguageUsed);
      LoadComboboxes();
      LoadAuthentificationParameters();
      GetWindowValue();
      DisplayTitle();
      DisableNotImplementedMenuItems();
    }

    private void DisableNotImplementedMenuItems()
    {
      // enable them whenever code is created
      nouveauToolStripMenuItem.Visible = false;
      ouvrirToolStripMenuItem.Visible = false;
      toolStripSeparator.Visible = false;
      enregistrerToolStripMenuItem.Visible = false;
      enregistrersousToolStripMenuItem.Visible = false;
      toolStripSeparator1.Visible = false;
      imprimerToolStripMenuItem.Visible = false;
      aperçuavantimpressionToolStripMenuItem.Visible = false;
      toolStripSeparator2.Visible = false;

      annulerToolStripMenuItem.Visible = true;

      outilsToolStripMenuItem.Visible = false;

      aideToolStripMenuItem.Visible = true;
      sommaireToolStripMenuItem.Visible = false;
      indexToolStripMenuItem.Visible = false;
      rechercherToolStripMenuItem.Visible = false;
    }

    private string DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      return $"-V{fvi.FileMajorPart}.{fvi.FileMinorPart}.{fvi.FileBuildPart}";
    }

    private void LoadAuthentificationParameters()
    {
      // source parameters
      if (checkBoxSourceRememberCredentials.Checked)
      {
        if (AllFilesExist())
        {
          var encryptionKey = Helper.ReadFile(SourceKeyFilename);
          if (!encryptionKey[Helper.FirstElement].StartsWith(Helper.OK))
          {
            MessageBox.Show("There was an error while trying to read the encryption key", "Error while reading file", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
          }

          string encryptionKeyFinal = encryptionKey[Helper.SecondElement];

          var encryptionSalt = Helper.ReadFile(SourceSaltFilename);
          if (!encryptionSalt[Helper.FirstElement].StartsWith(Helper.OK))
          {
            MessageBox.Show("There was an error while trying to read the encryption vector", "Error while reading file", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
          }

          string encryptionSaltFinal = encryptionSalt[Helper.SecondElement];

          ReadAndDecode(SourceValue1Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxSourceServer);
          ReadAndDecode(SourceValue2Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxSourcePort);
          ReadAndDecode(SourceValue3Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxSourceName);
          ReadAndDecode(SourceValue4Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxSourcePassword);
          ReadAndDecode(SourceValue5Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxDatabaseNameSource);
        }
      }

      // target parameters
      if (checkBoxSourceRememberCredentials.Checked)
      {
        if (AllFilesExist(false))
        {
          var encryptionKey = Helper.ReadFile(TargetKeyFilename);
          if (!encryptionKey[Helper.FirstElement].StartsWith(Helper.OK))
          {
            MessageBox.Show("There was an error while trying to read the encryption key", "Error while reading file", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
          }

          string encryptionKeyFinal = encryptionKey[Helper.SecondElement];

          var encryptionSalt = Helper.ReadFile(TargetSaltFilename);
          if (!encryptionSalt[Helper.FirstElement].StartsWith(Helper.OK))
          {
            MessageBox.Show("There was an error while trying to read the encryption vector", "Error while reading file", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
          }

          string encryptionSaltFinal = encryptionSalt[Helper.SecondElement];

          ReadAndDecode(TargetValue1Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxTargetServer);
          ReadAndDecode(TargetValue2Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxTargetPort);
          ReadAndDecode(TargetValue3Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxTargetName);
          ReadAndDecode(TargetValue4Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxTargetPassword);
          ReadAndDecode(TargetValue5Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxDatabaseNameTarget);
        }
      }
    }

    private bool AllFilesExist(bool source = true)
    {
      if (source)
      {
        return File.Exists(SourceKeyFilename) && File.Exists(SourceSaltFilename) && File.Exists(SourceValue1Filename) && File.Exists(SourceValue2Filename) && File.Exists(SourceValue3Filename) && File.Exists(SourceValue4Filename) && File.Exists(SourceValue5Filename);
      }
      else
      {
        return File.Exists(TargetKeyFilename) && File.Exists(TargetSaltFilename) && File.Exists(TargetValue1Filename) && File.Exists(TargetValue2Filename) && File.Exists(TargetValue3Filename) && File.Exists(TargetValue4Filename) && File.Exists(TargetValue5Filename);
      }
    }

    private void ReadAndDecode(string sourceFilename, string encryptionKey, string encryptionSalt, TextBox textBox)
    {
      var values = Helper.ReadFile(sourceFilename);
      if (!values[Helper.FirstElement].StartsWith(Helper.OK))
      {
        MessageBox.Show("There was an error while trying to read the values file", "Error while reading file", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return;
      }

      string valuesFinal = values[Helper.SecondElement];
      var plainText = Helper.DecodeWithAES(valuesFinal, encryptionKey, encryptionSalt);
      textBox.Text = plainText;
    }

    private void LoadComboboxes()
    {
      textBoxSourceServer.Text = Settings.Default.comboBoxServerSourceItems;
      textBoxTargetServer.Text = Settings.Default.comboBoxServerTargetItems;
      checkBoxSourceRememberCredentials.Checked = Settings.Default.CheckBoxSourceRememberCredentials;
      checkBoxTargetRememberCredentials.Checked = Settings.Default.CheckBoxTargetRememberCredentials;

      comboBoxSourceSchema.Items.Clear();
      string previousSchemaSource = Settings.Default.comboBoxSourceSchemaItems;
      if (string.IsNullOrEmpty(previousSchemaSource))
      {
        comboBoxSourceSchema.Items.Add("public");
      }
      else
      {
        var previousSchemasSourceArray = previousSchemaSource.Split(Punctuation.SemiColon);
        comboBoxSourceSchema.Items.AddRange(previousSchemasSourceArray);
      }

      comboBoxTargetSchema.Items.Clear();
      string previousSchemaTarget = Settings.Default.comboBoxTargetSchemaItems;
      if (string.IsNullOrEmpty(previousSchemaTarget))
      {
        comboBoxTargetSchema.Items.Add("public");
      }
      else
      {
        var previousSchemasTargetArray = previousSchemaTarget.Split(Punctuation.SemiColon);
        comboBoxTargetSchema.Items.AddRange(previousSchemasTargetArray);
      }

      comboBoxSourceSchema.SelectedIndex = Settings.Default.comboBoxSourceSchemaIndex;
      comboBoxTargetSchema.SelectedIndex = Settings.Default.comboBoxTargetSchemaIndex;

      checkBoxSourceRememberCredentials.Checked = Settings.Default.CheckBoxSourceRememberCredentials;
      checkBoxTargetRememberCredentials.Checked = Settings.Default.CheckBoxTargetRememberCredentials;

      textBoxTargetName.Text = Settings.Default.textBoxTargetName;
      textBoxSourceName.Text = Settings.Default.textBoxSourceName;

      comboBoxSourceDatabase.Items.Clear();
      foreach (string item in Settings.Default.comboBoxSourceDatabase.Split(Punctuation.SemiColon))
      {
        comboBoxSourceDatabase.Items.Add(item);
      }

      comboBoxTargetDatabase.Items.Clear();
      foreach (string item in Settings.Default.comboBoxTargetDatabase.Split(Punctuation.SemiColon))
      {
        comboBoxTargetDatabase.Items.Add(item);
      }
    }

    private static string GetApplicationVersion()
    {
      var assembly = Assembly.GetExecutingAssembly();
      var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      return $" V{fvi.FileMajorPart}.{fvi.FileMinorPart}.{fvi.FileBuildPart}.{fvi.FilePrivatePart}";
    }

    private static string GetEnvironment64BitProcess()
    {
      return Environment.Is64BitProcess ? "X64" : "X86";
    }

    public static string GetFrameworkVersion()
    {
      var version = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
      return version;
    }

    private string GetFramework()
    {
      object[] list = Assembly.GetExecutingAssembly().GetCustomAttributes(true);
      var attribute = list.OfType<TargetFrameworkAttribute>().First();
      return attribute.FrameworkDisplayName;
    }

    private static string GetServerName()
    {
      return Environment.MachineName;
    }

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var aboutboxApplication = new AboutBoxApplication();
      aboutboxApplication.Show();
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.LastLanguageUsed = frenchToolStripMenuItem.Checked ? "French" : "English";
      Settings.Default.Save();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      SetLanguageMenu(Settings.Default.LastLanguageUsed);
    }

    private void SetLanguageMenu(string language)
    {
      if (language == "French")
      {
        frenchToolStripMenuItem.Checked = true;
        englishToolStripMenuItem.Checked = false;
      }
      else
      {
        frenchToolStripMenuItem.Checked = false;
        englishToolStripMenuItem.Checked = true;
      }
    }

    private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      logger.Info("Fermeture de l'application");
      SaveWindowValue();
    }

    private void FrenchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SetLanguage(Language.French.ToString());
      frenchToolStripMenuItem.Checked = true;
      englishToolStripMenuItem.Checked = false;
    }

    private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SetLanguage(Language.English.ToString());
      frenchToolStripMenuItem.Checked = false;
      englishToolStripMenuItem.Checked = true;
    }

    // copy the following methods if you don't have them yet (you shouldn't)

    private void SetLanguage(string myLanguage)
    {
      switch (myLanguage)
      {
        case "English":
          //frenchToolStripMenuItem.Checked = false;
          //englishToolStripMenuItem.Checked = true;
          //fileToolStripMenuItem.Text = languageDicoEn["MenuFile"];
          //newToolStripMenuItem.Text = languageDicoEn["MenuFileNew"];
          //openToolStripMenuItem.Text = languageDicoEn["MenuFileOpen"];
          //saveToolStripMenuItem.Text = languageDicoEn["MenuFileSave"];
          //saveasToolStripMenuItem.Text = languageDicoEn["MenuFileSaveAs"];
          //printPreviewToolStripMenuItem.Text = languageDicoEn["MenuFilePrint"];
          //printPreviewToolStripMenuItem.Text = languageDicoEn["MenufilePageSetup"];
          //quitToolStripMenuItem.Text = languageDicoEn["MenufileQuit"];
          //editToolStripMenuItem.Text = languageDicoEn["MenuEdit"];
          //cancelToolStripMenuItem.Text = languageDicoEn["MenuEditCancel"];
          //redoToolStripMenuItem.Text = languageDicoEn["MenuEditRedo"];
          //cutToolStripMenuItem.Text = languageDicoEn["MenuEditCut"];
          //copyToolStripMenuItem.Text = languageDicoEn["MenuEditCopy"];
          //pasteToolStripMenuItem.Text = languageDicoEn["MenuEditPaste"];
          //selectAllToolStripMenuItem.Text = languageDicoEn["MenuEditSelectAll"];
          //toolsToolStripMenuItem.Text = languageDicoEn["MenuTools"];
          //personalizeToolStripMenuItem.Text = languageDicoEn["MenuToolsCustomize"];
          //optionsToolStripMenuItem.Text = languageDicoEn["MenuToolsOptions"];
          //languagetoolStripMenuItem.Text = languageDicoEn["MenuLanguage"];
          //englishToolStripMenuItem.Text = languageDicoEn["MenuLanguageEnglish"];
          //frenchToolStripMenuItem.Text = languageDicoEn["MenuLanguageFrench"];
          //helpToolStripMenuItem.Text = languageDicoEn["MenuHelp"];
          //summaryToolStripMenuItem.Text = languageDicoEn["MenuHelpSummary"];
          indexToolStripMenuItem.Text = languageDicoEn["MenuHelpIndex"];
          //searchToolStripMenuItem.Text = languageDicoEn["MenuHelpSearch"];
          //aboutToolStripMenuItem.Text = languageDicoEn["MenuHelpAbout"];

          break;
        case "French":
          //frenchToolStripMenuItem.Checked = true;
          //englishToolStripMenuItem.Checked = false;
          //fileToolStripMenuItem.Text = languageDicoFr["MenuFile"];
          //newToolStripMenuItem.Text = languageDicoFr["MenuFileNew"];
          //openToolStripMenuItem.Text = languageDicoFr["MenuFileOpen"];
          //saveToolStripMenuItem.Text = languageDicoFr["MenuFileSave"];
          //saveasToolStripMenuItem.Text = languageDicoFr["MenuFileSaveAs"];
          //printPreviewToolStripMenuItem.Text = languageDicoFr["MenuFilePrint"];
          //printPreviewToolStripMenuItem.Text = languageDicoFr["MenufilePageSetup"];
          //quitToolStripMenuItem.Text = languageDicoFr["MenufileQuit"];
          //editToolStripMenuItem.Text = languageDicoFr["MenuEdit"];
          //cancelToolStripMenuItem.Text = languageDicoFr["MenuEditCancel"];
          //redoToolStripMenuItem.Text = languageDicoFr["MenuEditRedo"];
          //cutToolStripMenuItem.Text = languageDicoFr["MenuEditCut"];
          //copyToolStripMenuItem.Text = languageDicoFr["MenuEditCopy"];
          //pasteToolStripMenuItem.Text = languageDicoFr["MenuEditPaste"];
          //selectAllToolStripMenuItem.Text = languageDicoFr["MenuEditSelectAll"];
          //toolsToolStripMenuItem.Text = languageDicoFr["MenuTools"];
          //personalizeToolStripMenuItem.Text = languageDicoFr["MenuToolsCustomize"];
          optionsToolStripMenuItem.Text = languageDicoFr["MenuToolsOptions"];
          //languagetoolStripMenuItem.Text = languageDicoFr["MenuLanguage"];
          //englishToolStripMenuItem.Text = languageDicoFr["MenuLanguageEnglish"];
          //frenchToolStripMenuItem.Text = languageDicoFr["MenuLanguageFrench"];
          //helpToolStripMenuItem.Text = languageDicoFr["MenuHelp"];
          //summaryToolStripMenuItem.Text = languageDicoFr["MenuHelpSummary"];
          indexToolStripMenuItem.Text = languageDicoFr["MenuHelpIndex"];
          //searchToolStripMenuItem.Text = languageDicoFr["MenuHelpSearch"];
          //aboutToolStripMenuItem.Text = languageDicoFr["MenuHelpAbout"];

          break;
      }
    }

    public enum Language
    {
      French,
      English
    }

    private void LoadLanguages()
    {
      if (!File.Exists(Settings.Default.LanguageFileName))
      {
        CreateLanguageFile();
      }

      // read the translation file and feed the language
      XDocument xDoc = XDocument.Load(Settings.Default.LanguageFileName);
      var result = from node in xDoc.Descendants("term")
                   where node.HasElements
                   let xElementName = node.Element("name")
                   where xElementName != null
                   let xElementEnglish = node.Element("englishValue")
                   where xElementEnglish != null
                   let xElementFrench = node.Element("frenchValue")
                   where xElementFrench != null
                   select new
                   {
                     name = xElementName.Value,
                     englishValue = xElementEnglish.Value,
                     frenchValue = xElementFrench.Value
                   };
      foreach (var i in result)
      {
        languageDicoEn.Add(i.name, i.englishValue);
        languageDicoFr.Add(i.name, i.frenchValue);
      }
    }

    private static void CreateLanguageFile()
    {
      List<string> minimumVersion = new List<string>
        {
          "<?xml version=\"1.0\" encoding=\"utf - 8\" ?>",
          "<Document>",
          "<DocumentVersion>",
          "<version> 1.0 </version>",
          "</DocumentVersion>",
          "<terms>",
           "<term>",
          "<name>MenuFile</name>",
          "<englishValue>File</englishValue>",
          "<frenchValue>Fichier</frenchValue>",
          "</term>",
          "  </terms>",
          "</Document>"
        };

      StreamWriter sw = new StreamWriter(Settings.Default.LanguageFileName);
      foreach (string item in minimumVersion)
      {
        sw.WriteLine(item);
      }

      sw.Close();
    }

    private void ButtonCopyServerName_Click(object sender, EventArgs e)
    {
      textBoxTargetServer.Text = textBoxSourceServer.Text;
    }

    private void ButtonCopyUserName_Click(object sender, EventArgs e)
    {
      textBoxTargetName.Text = textBoxSourceName.Text;
    }

    private void ButtonCopyPassword_Click(object sender, EventArgs e)
    {
      textBoxTargetPassword.Text = textBoxSourcePassword.Text;
    }

    private void ButtonCopyDatabaseName_Click(object sender, EventArgs e)
    {
      textBoxDatabaseNameTarget.Text = textBoxDatabaseNameSource.Text;
    }

    private void ButtonTestConnection_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(textBoxSourceServer.Text))
      {
        MessageBox.Show("You have to choose a source server", "No server selected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        sourceAuthenticationIsOk = false;
        return;
      }

      if (string.IsNullOrEmpty(textBoxSourcePort.Text))
      {
        MessageBox.Show("You have to choose a source port number", "No port number", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        sourceAuthenticationIsOk = false;
        return;
      }

      if (string.IsNullOrEmpty(textBoxSourceName.Text))
      {
        MessageBox.Show("You have to choose a source username", "No username", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        sourceAuthenticationIsOk = false;
        return;
      }

      if (string.IsNullOrEmpty(textBoxSourcePassword.Text))
      {
        MessageBox.Show("You have to choose a source password", "No password", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        sourceAuthenticationIsOk = false;
        return;
      }

      if (string.IsNullOrEmpty(textBoxDatabaseNameSource.Text))
      {
        MessageBox.Show("You have to choose a database to conenct to", "No database", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        sourceAuthenticationIsOk = false;
        return;
      }

      PostgreSqlDatabaseAuthentication dbConnexion = new PostgreSqlDatabaseAuthentication
      {
        UserName = textBoxSourceName.Text,
        UserPassword = textBoxSourcePassword.Text,
        ServerName = textBoxSourceServer.Text,
        Port = int.Parse(textBoxSourcePort.Text),
        DatabaseName = textBoxDatabaseNameSource.Text
      };

      string sqlQuery = PostgreSqlConnectionSqlServer.TestRequest();
      if (PostgreSqlDALHelper.TestConnection(dbConnexion.ToString()))
      {
        MessageBox.Show("Connection OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        sourceAuthenticationIsOk = true;
      }
      else
      {
        MessageBox.Show($"Cannot connect to the database: {dbConnexion.DatabaseName} on the server: {dbConnexion.ServerName}", "Connection KO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        sourceAuthenticationIsOk = false;
      }

      CheckBothAuthentication();
    }

    private void CheckBothAuthentication()
    {
      bothAuthenticationAreOk = sourceAuthenticationIsOk && targetAuthenticationIsOk;
    }

    private void ButtonTestconnectionTarget_Click(object sender, EventArgs e)
    {

    }

    private void ButtonSourceRefresh_Click(object sender, EventArgs e)
    {

    }

    private void ButtonRefreshSource_Click(object sender, EventArgs e)
    {

    }

    private void ButtonTargetRefresh_Click(object sender, EventArgs e)
    {

    }

    private void ButtonRefreshTarget_Click(object sender, EventArgs e)
    {

    }

    private void ButtonTargetCreate_Click(object sender, EventArgs e)
    {

    }

    private void ButtonSourceCreate_Click(object sender, EventArgs e)
    {

    }

    private void ButtonCompareCompareNow_Click(object sender, EventArgs e)
    {

    }
  }
}
