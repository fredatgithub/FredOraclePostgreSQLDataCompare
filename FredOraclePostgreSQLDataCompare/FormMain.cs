using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Windows.Forms;
using System.Xml.Linq;
using FredOraclePostgreSQLDataCompare.DAL.Oracle;
using FredOraclePostgreSQLDataCompare.DAL.PostgreSql;
using FredOraclePostgreSQLDataCompare.Properties;
using log4net;
using log4net.Config;
using Tools;


namespace FredOraclePostgreSQLDataCompare
{
  public partial class FormMain: Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private readonly Dictionary<string, string> languageDicoEn = new Dictionary<string, string>();
    private readonly Dictionary<string, string> languageDicoFr = new Dictionary<string, string>();
    internal ILog logger = LogManager.GetLogger(typeof(FormMain));
    private readonly string Log4NetConfigFilePath = "log4net.config.xml";
    private bool bothAuthenticationAreOk = false;
    private bool sourceAuthenticationIsOk = false;
    private bool targetAuthenticationIsOk = false;

    /// <summary>
    /// Key to be used to encrypt source parameters.
    /// </summary>
    private const string SourceKeyFilename = "SourceOne.pidb";
    private const string SourceSaltFilename = "SourceTwo.pidb";

    /// <summary>
    /// All the values encrypted for source parameters.
    /// </summary>
    private const string SourceValue1Filename = "SourceV1.pidb";
    private const string SourceValue2Filename = "SourceV2.pidb";
    private const string SourceValue3Filename = "SourceV3.pidb";
    private const string SourceValue4Filename = "SourceV4.pidb";

    /// <summary>
    /// Key to be used to encrypt target parameters.
    /// </summary>
    private const string TargetKeyFilename = "TargetOne.pidb";
    private const string TargetSaltFilename = "TargetTwo.pidb";

    /// <summary>
    /// All the values encrypted for source parameters.
    /// </summary>
    private const string TargetValue1Filename = "TargetV1.pidb";
    private const string TargetValue2Filename = "TargetV2.pidb";
    private const string TargetValue3Filename = "TargetV3.pidb";
    private const string TargetValue4Filename = "TargetV4.pidb";

    private bool[] tabLoaded;

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
      tabLoaded = new bool[tabControlMain.TabCount];
      GetWindowValue();
      LoadLanguages();
      SetLanguage(Settings.Default.LastLanguageUsed);
      LoadComboboxes();
      LoadAuthentificationParameters();
      GetWindowValue();
      DisplayTitle();
      DisableNotImplementedMenuItems();
      CheckTnsNamesOraFile();
    }

    private void CheckTnsNamesOraFile()
    {
      try
      {
        if (!File.Exists("tnsnames.ora"))
        {
          logger.Error("The file tnsnames.ora is not present in the directory of the application");
        }
        else
        {
          logger.Info("The file tnsnames.ora is present in the directory of the application");
        }
      }
      catch (Exception exception)
      {
        logger.Error($"There was an exception while checking if the file tnsnames.ora was present in the directory of the application. The exception is: {exception.Message}");
      }
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
          ReadAndDecode(SourceValue2Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxSourceName);
          ReadAndDecode(SourceValue3Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxSourcePassword);
          ReadAndDecode(SourceValue4Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxDatabaseNameSource);
        }
      }

      // target parameters
      if (checkBoxTargetRememberCredentials.Checked)
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
          ReadAndDecode(TargetValue2Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxTargetName);
          ReadAndDecode(TargetValue3Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxTargetPassword);
          ReadAndDecode(TargetValue4Filename, encryptionKeyFinal, encryptionSaltFinal, textBoxDatabaseNameTarget);
        }
      }
    }

    private bool AllFilesExist(bool source = true)
    {
      if (source)
      {
        return File.Exists(SourceKeyFilename) && File.Exists(SourceSaltFilename) && File.Exists(SourceValue1Filename) && File.Exists(SourceValue2Filename) && File.Exists(SourceValue3Filename) && File.Exists(SourceValue4Filename);
      }
      else
      {
        return File.Exists(TargetKeyFilename) && File.Exists(TargetSaltFilename) && File.Exists(TargetValue1Filename) && File.Exists(TargetValue2Filename) && File.Exists(TargetValue3Filename) && File.Exists(TargetValue4Filename);
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
      var plainText = Crypto.DecodeWithAES(valuesFinal, encryptionKey, encryptionSalt);
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
      var version = RuntimeInformation.FrameworkDescription;
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
      SaveAuthentification();
      Application.Exit();
    }

    private void SaveAuthentification()
    {
      if (checkBoxTargetRememberCredentials.Checked)
      {
        SaveTargetCredentials();
      }

      if (checkBoxSourceRememberCredentials.Checked)
      {
        SaveSourceCredentials();
      }
    }

    private void SaveSourceCredentials()
    {
      EncryptAndSave(SourceValue1Filename, textBoxSourceServer.Text, SourceKeyFilename, SourceSaltFilename);
      EncryptAndSave(SourceValue2Filename, textBoxSourceName.Text, SourceKeyFilename, SourceSaltFilename);
      EncryptAndSave(SourceValue3Filename, textBoxSourcePassword.Text, SourceKeyFilename, SourceSaltFilename);
      EncryptAndSave(SourceValue4Filename, textBoxDatabaseNameSource.Text, SourceKeyFilename, SourceSaltFilename);
    }

    private void SaveTargetCredentials()
    {
      EncryptAndSave(TargetValue1Filename, textBoxTargetServer.Text, TargetKeyFilename, TargetSaltFilename);
      EncryptAndSave(TargetValue2Filename, textBoxTargetName.Text, TargetKeyFilename, TargetSaltFilename);
      EncryptAndSave(TargetValue3Filename, textBoxTargetPassword.Text, TargetKeyFilename, TargetSaltFilename);
      EncryptAndSave(TargetValue4Filename, textBoxDatabaseNameTarget.Text, TargetKeyFilename, TargetSaltFilename);
    }

    private void EncryptAndSave(string filename, string plainText, string keyFile, string saltFile)
    {
      if (string.IsNullOrEmpty(plainText))
      {
        return;
      }

      if (!Helper.CreateFileIfNotExist(filename))
      {
        DisplayAndLogErrorMessage($"Cannot create file : {filename}");
        return;
      }

      var key = string.Empty;

      if (File.Exists(keyFile))
      {
        key = Helper.ReadFileOneLine(keyFile);
        if (string.IsNullOrEmpty(key))
        {
          DisplayAndLogErrorMessage($"The file: {keyFile} is empty. Try again");
          if (!Helper.DeleteFile(keyFile))
          {
            DisplayAndLogErrorMessage($"The file {keyFile} could not be deleted");
          }

          return;
        }
      }
      else
      {
        if (!Helper.CreateFileIfNotExist(keyFile))
        {
          DisplayAndLogErrorMessage($"Cannot create file : {keyFile}");
          return;
        }

        // create an encryption key
        var randomKey = Crypto.Generate(32);
        if (Helper.WriteStringToFile(keyFile, randomKey, false)[Helper.FirstElement] == Helper.OK)
        {
          key = randomKey;
        }
        else
        {
          DisplayAndLogErrorMessage($"Cannot write file: {keyFile}");
          return;
        }
      }

      //salt
      var salt = string.Empty;

      if (File.Exists(saltFile))
      {
        salt = Helper.ReadFileOneLine(saltFile);
        if (string.IsNullOrEmpty(salt))
        {
          DisplayAndLogErrorMessage($"The file: {saltFile} is empty. Try again");
          if (!Helper.DeleteFile(saltFile))
          {
            DisplayAndLogErrorMessage($"The file {saltFile} could not be deleted");
          }

          return;
        }
      }
      else
      {
        if (!Helper.CreateFileIfNotExist(saltFile))
        {
          DisplayAndLogErrorMessage($"Cannot write file: {saltFile}");
          return;
        }

        // create an encryption salt
        var randomSalt = Crypto.Generate(16);
        if (Helper.WriteStringToFile(saltFile, randomSalt, false)[Helper.FirstElement] == Helper.OK)
        {
          salt = randomSalt;
        }
        else
        {
          DisplayAndLogErrorMessage($"Cannot write file: {saltFile}");
          return;
        }
      }

      // encryption
      var cryptedText = Crypto.AesEncrypt(plainText, key, salt);
      //var testDecryption = Crypto.AesDecrypt(cryptedText, key, salt);
      if (Helper.WriteStringToFile(filename, cryptedText, false)[Helper.FirstElement] != Helper.OK)
      {
        DisplayAndLogErrorMessage($"Cannot write file: {filename}");
        return;
      }
    }

    private void DisplayAndLogErrorMessage(string message)
    {
      logger.Error(message);
      MessageBox.Show(message);
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
      Settings.Default.CheckBoxSourceRememberCredentials = checkBoxSourceRememberCredentials.Checked;
      Settings.Default.CheckBoxTargetRememberCredentials = checkBoxTargetRememberCredentials.Checked;
      Settings.Default.TextBoxSourcePort = int.Parse(textBoxSourcePort.Text);
      Settings.Default.Save();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      SetLanguageMenu(Settings.Default.LastLanguageUsed);
      checkBoxSourceRememberCredentials.Checked = Settings.Default.CheckBoxSourceRememberCredentials;
      checkBoxTargetRememberCredentials.Checked = Settings.Default.CheckBoxTargetRememberCredentials;
      textBoxSourcePort.Text = Settings.Default.TextBoxSourcePort.ToString();
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
      SaveAuthentification();
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
        MessageBox.Show("You have to choose a database to connect to", "No database", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        sourceAuthenticationIsOk = false;
        return;
      }

      var dbSourceConnexion = GetSourceConnexion();

      string sqlQuery = OracleDALHelper.TestRequest();
      if (OracleDALHelper.TestOracleDbConnection(dbSourceConnexion.ToString()))
      {
        MessageBox.Show("Connection OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        sourceAuthenticationIsOk = true;
      }
      else
      {
        MessageBox.Show($"Cannot connect to the database: {dbSourceConnexion.DataSource} on the server: {dbSourceConnexion.DataSource}", "Connection KO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
      // test the connection and assign targetAuthenticationIsOk a value
      if (string.IsNullOrEmpty(textBoxTargetServer.Text))
      {
        MessageBox.Show("You have to choose a target server", "No server selected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        targetAuthenticationIsOk = false;
        return;
      }

      if (string.IsNullOrEmpty(textBoxTargetPort.Text))
      {
        MessageBox.Show("You have to choose a target port number", "No port number", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        targetAuthenticationIsOk = false;
        return;
      }

      if (string.IsNullOrEmpty(textBoxTargetName.Text))
      {
        MessageBox.Show("You have to choose a target username", "No username", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        targetAuthenticationIsOk = false;
        return;
      }

      if (string.IsNullOrEmpty(textBoxTargetPassword.Text))
      {
        MessageBox.Show("You have to choose a target password", "No password", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        targetAuthenticationIsOk = false;
        return;
      }

      if (string.IsNullOrEmpty(textBoxDatabaseNameTarget.Text))
      {
        MessageBox.Show("You have to choose a database to connect to", "No database", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        targetAuthenticationIsOk = false;
        return;
      }

      var dbTargetConnexion = GetTargetConnexion();

      string sqlQuery = PostgreSqlConnection.TestRequest();
      if (PostgreSqlDALHelper.TestConnection(dbTargetConnexion.ToString()))
      {
        MessageBox.Show("Connection OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        targetAuthenticationIsOk = true;
      }
      else
      {
        MessageBox.Show($"Cannot connect to the database: {dbTargetConnexion.DatabaseName} on the server: {dbTargetConnexion.ServerName}", "Connection KO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        targetAuthenticationIsOk = false;
      }

      CheckBothAuthentication();
    }

    private PostgreSqlDatabaseAuthentication GetTargetConnexion()
    {
      var dbConnexion = new PostgreSqlDatabaseAuthentication
      {
        UserName = textBoxTargetName.Text,
        UserPassword = textBoxTargetPassword.Text,
        ServerName = textBoxTargetServer.Text,
        Port = int.Parse(textBoxTargetPort.Text),
        DatabaseName = textBoxDatabaseNameTarget.Text
      };

      return dbConnexion;
    }

    private OracleDatabaseAuthentication GetSourceConnexion()
    {
      var dbConnexion = new OracleDatabaseAuthentication
      {
        UserName = textBoxSourceName.Text,
        UserPassword = textBoxSourcePassword.Text,
        Port = int.Parse(textBoxSourcePort.Text),
        DataSource = textBoxDatabaseNameSource.Text
      };

      dbConnexion.CheckTnsNameFile();
      return dbConnexion;
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
      // Checked connections before tab switching
      int backupPositionX = Location.X;
      int backupPositionY = Location.Y + Size.Height / 2;
      var pleaseWait = new PleaseWaitForm(backupPositionX, backupPositionY);
      pleaseWait.Show();
      Application.DoEvents();
      tabControlMain.SelectedIndex = 1;
      pleaseWait.Close();
    }

    private void TabPageTables_Click(object sender, EventArgs e)
    {


    }

    private void ComboBoxOracleTable_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void ComboBoxPostgresqlTable_SelectedIndexChanged(object sender, EventArgs e)
    {
      var breakPoint = true;
    }

    private void TabPageConnection_Click(object sender, EventArgs e)
    {
      var test = 3;
    }

    private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (tabControlMain.SelectedIndex == 1 && tabLoaded[1] == false)
      {
        LoadTargetComboboxes(comboBoxPostgresqlSchema, PostgreSqlConnection.GetAllSchemasRequest());
        LoadSourceCombox(comboBoxOracleTable, OracleDALHelper.GetAllOracleTablesRequest());
        tabLoaded[1] = true;
      }

      if (tabControlMain.SelectedIndex == 2 && tabLoaded[2] == false)
      {
        LoadTargetComboboxes(comboBoxInsertSchemaTarget, PostgreSqlConnection.GetAllSchemasRequest());
        var schema = comboBoxInsertSchemaTarget.SelectedItem.ToString();
        if (!string.IsNullOrEmpty(schema))
        {
          LoadTargetComboboxes(comboBoxInsertTableNameTarget, PostgreSqlConnection.GetAllTableNamesForASpecificSchemaRequest(schema));
        }

        LoadSourceCombox(comboBoxInsertTableSource, OracleDALHelper.GetAllOracleTablesRequest());
        tabLoaded[2] = true;
      }
    }

    private void LoadSourceCombox(ComboBox comboBox, string query)
    {
      comboBox.Items.Clear();
      var items = new List<string>();
      var dbSourceConnexion = GetSourceConnexion();
      items = OracleDALHelper.ExecuteQueryToListOfStrings(dbSourceConnexion.ToString(), query);
      LoadCombobox(comboBox, items);
      if (comboBox.Items.Count > 0)
      {
        comboBox.SelectedIndex = 0;
      }
      else
      {
        comboBox.SelectedIndex = -1;
      }
    }

    private void LoadTargetComboboxes(ComboBox comboBox, string query)
    {
      comboBox.Items.Clear();
      var items = new List<string>();
      var dbTargetConnexion = GetTargetConnexion();
      items = PostgreSqlDALHelper.ExecuteSqlQueryToListOfStrings(dbTargetConnexion.ToString(), query);
      LoadCombobox(comboBox, items);
      if (comboBox.Items.Count > 0)
      {
        comboBox.SelectedIndex = 0;
      }
      else
      {
        comboBox.SelectedIndex = -1;
      }
    }

    private void LoadCombobox(ComboBox comboBox, List<string> items)
    {
      comboBox.Items.Clear();
      comboBox.Items.AddRange(items.ToArray());
    }

    private void ComboBoxPostgresqlSchema_SelectedIndexChanged(object sender, EventArgs e)
    {
      // loading tables for the selected schema
      comboBoxPostgresqlTable.Items.Clear();
      var items = new List<string>();
      var schema = comboBoxPostgresqlSchema.SelectedItem as string;
      var dbTargetConnexion = GetTargetConnexion();
      var query = PostgreSqlConnection.GetAllPostgreSqlTables(schema);
      items = PostgreSqlDALHelper.ExecuteSqlQueryToListOfStrings(dbTargetConnexion.ToString(), query);
      LoadCombobox(comboBoxPostgresqlTable, items);
      if (comboBoxPostgresqlTable.Items.Count > 0)
      {
        comboBoxPostgresqlTable.SelectedIndex = 0;
      }
    }

    private void ButtonTablesCompare_Click(object sender, EventArgs e)
    {
      if (comboBoxPostgresqlSchema.SelectedIndex == -1)
      {
        MessageBox.Show("You have to choose a PostgreSql target schema");
        return;
      }

      if (comboBoxPostgresqlTable.SelectedIndex == -1)
      {
        MessageBox.Show("You have to choose a PostgreSql target table");
        return;
      }

      if (comboBoxOracleTable.SelectedIndex == -1)
      {
        MessageBox.Show("You have to choose an Oracle source table");
        return;
      }

      // vérification if source table name is equal to target table name
      var oracleTableName = comboBoxOracleTable.SelectedItem.ToString().ToLower();
      var postgresqlTableName = comboBoxPostgresqlTable.SelectedItem.ToString().ToLower();
      if (oracleTableName != postgresqlTableName)
      {
        DialogResult result = MessageBox.Show("Are you sure you want to compare two different tables?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.No)
        {
          return;
        }
      }

      int backupPositionX = Location.X;
      int backupPositionY = Location.Y + Size.Height / 2;
      var pleaseWait = new PleaseWaitForm(backupPositionX, backupPositionY);
      pleaseWait.Show();
      Application.DoEvents();

      // get original names for requests
      oracleTableName = comboBoxOracleTable.SelectedItem.ToString();
      postgresqlTableName = comboBoxPostgresqlTable.SelectedItem.ToString();

      // comparison of number of lines
      var numberTarget = 0;
      var dbTargetConnexion = GetTargetConnexion();
      var query = PostgreSqlConnection.CountNumberOfRecordsRequest(postgresqlTableName);
      numberTarget = PostgreSqlDALHelper.ExecuteQueryToInteger(dbTargetConnexion.ToString(), query);
      string formattedNumber = numberTarget.ToString("N0", new CultureInfo("fr-FR"));
      formattedNumber = formattedNumber.Replace(",", " ").Replace(".", " ");
      labelTablesTargetNumberOfLines.Text = $"Number of lines: {formattedNumber}";
      //source
      var dbSourceConnexion = GetSourceConnexion();
      query = OracleDALHelper.CountNumberOfRecordsRequest(oracleTableName);
      var numberSource = OracleDALHelper.ExecuteQueryToInteger(dbSourceConnexion.ToString(), query);
      formattedNumber = numberSource.ToString("N0", new CultureInfo("fr-FR"));
      formattedNumber = formattedNumber.Replace(",", " ").Replace(".", " ");
      labelTablesSourceNumberOfLines.ForeColor = GetColorForEquality(numberSource, numberTarget);
      labelTablesTargetNumberOfLines.ForeColor = GetColorForEquality(numberSource, numberTarget);
      labelTablesSourceNumberOfLines.Text = $"Number of lines: {formattedNumber}";

      // comparison of number of columns: necessary? maybe on column types

      // creation of datagridviews
      // get original names for requests
      oracleTableName = comboBoxOracleTable.SelectedItem.ToString();
      postgresqlTableName = comboBoxPostgresqlTable.SelectedItem.ToString();
      var sourceColumnsList = new List<string>();
      var targetColumnsList = new List<string>();
      //oracle
      query = OracleDALHelper.GetAllColumnsRequest(oracleTableName);
      sourceColumnsList = OracleDALHelper.ExecuteQueryToListOfStrings(dbSourceConnexion.ToString(), query);
      //target
      query = PostgreSqlConnection.GetAllColumnFromATableRequest(postgresqlTableName);
      targetColumnsList = PostgreSqlDALHelper.ExecuteSqlQueryToListOfStrings(dbTargetConnexion.ToString(), query);
      // datagridview oracle
      query = OracleDALHelper.SelectAllFromTableRequest(oracleTableName);
      OracleDALHelper.LoadTableIntoDGV(dbSourceConnexion.ToString(), query, dataGridViewOracle);
      // datagridview postgresql
      query = PostgreSqlConnection.SelectAllFromTableRequest(postgresqlTableName);
      PostgreSqlDALHelper.LoadTableIntoDGV(dbTargetConnexion.ToString(), query, dataGridViewPostgreSql);
      AutosizeAllColumns(dataGridViewPostgreSql);
      AutosizeAllColumns(dataGridViewOracle);

      // comparaison of all rows
      HighlightDifferences(dataGridViewOracle, dataGridViewPostgreSql);
      var numberOfLinesInOracleButNotInPostgreSql = 0;
      var numberOfLinesInPostgreSqlButNotInOracle = 0;
      var comparer = new DataGridViewComparer();
      (numberOfLinesInOracleButNotInPostgreSql, numberOfLinesInPostgreSqlButNotInOracle) = comparer.GetDifferenceCounts(dataGridViewOracle, dataGridViewPostgreSql);
      labelNumberOfLinesInOracleButNotInPostgreSql.Text = $"Number of lines in Oracle but not in PostgreSql: {numberOfLinesInOracleButNotInPostgreSql}";
      labelNumberOfLinesInPostgreSqlButNotInOracle.Text = $"Number of lines in PostgreSql but not in Oracle: {numberOfLinesInPostgreSqlButNotInOracle}";
      pleaseWait.Close();
    }

    private void HighlightDifferences(DataGridView dgv1, DataGridView dgv2)
    {
      if (dgv1.Rows.Count != dgv2.Rows.Count)
      {
        MessageBox.Show("Les tables n'ont pas le même nombre de lignes.");
        return;
      }

      for (int i = 0; i < dgv1.Rows.Count; i++)
      {
        bool rowsAreEqual = true;

        if (dgv1.Columns.Count != dgv2.Columns.Count)
        {
          MessageBox.Show("Les tables n'ont pas le même nombre de colonnes.");
          return;
        }

        for (int j = 0; j < dgv1.Columns.Count; j++)
        {
          var value1 = dgv1.Rows[i].Cells[j].Value?.ToString();
          var value2 = dgv2.Rows[i].Cells[j].Value?.ToString();

          if (value1 != value2)
          {
            rowsAreEqual = false;
            break;
          }
        }

        if (!rowsAreEqual)
        {
          dgv1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
          dgv2.Rows[i].DefaultCellStyle.BackColor = Color.Red;
        }
      }
    }

    private void AutosizeAllColumns(DataGridView dataGridView)
    {
      for (int i = 0; i < dataGridView.ColumnCount; i++)
      {
        dataGridView.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
      }
    }

    private Color GetColorForEquality(int numberSource, int numberTarget)
    {
      return numberSource != numberTarget ? Color.Red : Color.Green;
    }

    private void ComboBoxInsertSchemaTarget_SelectedIndexChanged(object sender, EventArgs e)
    {
      var schema = comboBoxInsertSchemaTarget.SelectedItem.ToString();
      if (!string.IsNullOrEmpty(schema))
      {
        LoadTargetComboboxes(comboBoxInsertTableNameTarget, PostgreSqlConnection.GetAllTableNamesForASpecificSchemaRequest(schema));
      }
    }

    private void ButtonInsertLoad_Click(object sender, EventArgs e)
    {
      if (comboBoxInsertSchemaTarget.SelectedIndex == -1)
      {
        MessageBox.Show("You have to select a target SQL schema");
        return;
      }

      if (comboBoxInsertTableNameTarget.SelectedIndex == -1)
      {
        MessageBox.Show("You have to select a target table");
        return;
      }

      if (comboBoxInsertTableSource.SelectedIndex == -1)
      {
        MessageBox.Show("You have to select a source table");
        return;
      }

      if (comboBoxInsertTableNameTarget.SelectedItem.ToString().ToLower() != comboBoxInsertTableSource.SelectedItem.ToString().ToLower())
      {
        MessageBox.Show("You have to select the same table from source as the target table");
        return;
      }

      int backupPositionX = Location.X;
      int backupPositionY = Location.Y + Size.Height / 2;
      var pleaseWait = new PleaseWaitForm(backupPositionX, backupPositionY);
      pleaseWait.Show();
      Application.DoEvents();

      // get original names for requests
      var oracleTableName = comboBoxInsertTableSource.SelectedItem.ToString();
      var postgresqlTableName = comboBoxInsertTableNameTarget.SelectedItem.ToString();

      // comparison of number of lines
      var numberTarget = 0;
      var dbTargetConnexion = GetTargetConnexion();
      var query = PostgreSqlConnection.CountNumberOfRecordsRequest(postgresqlTableName);
      numberTarget = PostgreSqlDALHelper.ExecuteQueryToInteger(dbTargetConnexion.ToString(), query);
      string formattedNumber = numberTarget.ToString("N0", new CultureInfo("fr-FR"));
      formattedNumber = formattedNumber.Replace(",", " ").Replace(".", " ");
      labelInsertNumberOfLinesTarget.Text = $"Number of lines: {formattedNumber}";

      //source
      var dbSourceConnexion = GetSourceConnexion();
      query = OracleDALHelper.CountNumberOfRecordsRequest(oracleTableName);
      var numberSource = OracleDALHelper.ExecuteQueryToInteger(dbSourceConnexion.ToString(), query);
      formattedNumber = numberSource.ToString("N0", new CultureInfo("fr-FR"));
      formattedNumber = formattedNumber.Replace(",", " ").Replace(".", " ");
      labelInsertNumberOfLinesSource.ForeColor = GetColorForEquality(numberSource, numberTarget);
      labelInsertNumberOfLinesTarget.ForeColor = GetColorForEquality(numberSource, numberTarget);
      labelInsertNumberOfLinesSource.Text = $"Number of lines: {formattedNumber}";

      // creation of datagridviews
      // add selection column to Datagridviews
      dataGridViewInsertSource = AddSelectColumnToDGV(dataGridViewInsertSource);
      dataGridViewInsertTarget = AddSelectColumnToDGV(dataGridViewInsertTarget);

      // datagridview oracle
      query = OracleDALHelper.SelectAllFromTableRequest(oracleTableName);
      var dataTableSource = OracleDALHelper.ExecuteQueryToDataTable(dbSourceConnexion.ToString(), query);
      dataGridViewInsertSource.DataSource = dataTableSource;

      // datagridview postgresql
      query = PostgreSqlConnection.SelectAllFromTableRequest(postgresqlTableName);
      var dataTableTarget = PostgreSqlDALHelper.ExecuteQuerytoDataTable(dbTargetConnexion.ToString(), query);
      dataGridViewInsertTarget.DataSource = dataTableTarget;

      // autosize all columns for Datagridviews
      AutosizeAllColumns(dataGridViewInsertSource);
      AutosizeAllColumns(dataGridViewInsertTarget);

      if (dataTableSource.Rows.Count == 0)
      {
        MessageBox.Show("The source table returned zero lines");
        return;
      }

      if (dataTableTarget.Rows.Count == 0)
      {
        MessageBox.Show("The target table returned zero lines");
        return;
      }

      CheckAllRowsToBeInserted(dataTableSource, dataTableTarget, 1);
      pleaseWait.Close();
    }

    private void CheckAllRowsToBeInserted(DataTable dataTableSource, DataTable dataTableTarget, params int[] index)
    {
      foreach (DataRow sourceRow in dataTableSource.Rows)
      {
        bool foundInTarget = false;

        foreach (DataRow targetRow in dataTableTarget.Rows)
        {
          bool[] allIndexes = new bool[index.Length];
          for (int i = 0; i < index.Length; i++)
          {
            if (sourceRow[i].Equals(targetRow[i]))
            {
              allIndexes[i] = true;
            }
            else
            {
              allIndexes[i] = false;
            }
          }

          if (Helper.AllTrue(allIndexes))
          {
            foundInTarget = true;
            break;
          }
        }

        if (!foundInTarget)
        {
          sourceRow["selectColumn"] = true;
        }
        else
        {
          sourceRow["selectColumn"] = false;
        }
      }
    }

    private DataGridView AddSelectColumnToDGV(DataGridView dataGidView)
    {
      var selectColumn = new DataGridViewCheckBoxColumn
      {
        HeaderText = "Select",
        Name = "selectColumn",
        Width = 50,
        ReadOnly = false,   
        Frozen = false      
      };

      dataGidView.Columns.Add(selectColumn);
      dataGidView.SelectionMode = DataGridViewSelectionMode.CellSelect; 
      return dataGidView;
    }


    private void ButtonInsert_Click(object sender, EventArgs e)
    {
      // check if there is anything to insert from and then insert checked rows from source into target table

    }
  }
}
