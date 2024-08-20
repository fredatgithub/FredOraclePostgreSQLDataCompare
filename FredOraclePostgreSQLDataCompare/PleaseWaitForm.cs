using System;
using System.Drawing;
using System.Windows.Forms;

namespace FredOraclePostgreSQLDataCompare
{
  public partial class PleaseWaitForm: Form
  {
    public int PositionX { get; set; }
    public int PositionY { get; set; }

    public PleaseWaitForm(int positionX = 200, int positionY = 200, string newLabel = "Veuillez patienter. Cette fenêtre se fermera à la fin du traitement.")
    {
      InitializeComponent();
      PositionX = positionX;
      PositionY = positionY;
      labelPleaseWait.Text = newLabel;
    }

    private void PleaseWaitForm_Load(object sender, EventArgs e) => Location = new Point(PositionX, PositionY);
  }
}
