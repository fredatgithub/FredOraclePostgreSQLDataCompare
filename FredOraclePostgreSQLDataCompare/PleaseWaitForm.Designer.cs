namespace FredOraclePostgreSQLDataCompare
{
  partial class PleaseWaitForm
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
      this.labelPleaseWait = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelPleaseWait
      // 
      this.labelPleaseWait.AutoSize = true;
      this.labelPleaseWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelPleaseWait.Location = new System.Drawing.Point(30, 60);
      this.labelPleaseWait.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelPleaseWait.Name = "labelPleaseWait";
      this.labelPleaseWait.Size = new System.Drawing.Size(999, 37);
      this.labelPleaseWait.TabIndex = 1;
      this.labelPleaseWait.Text = "Veuillez patienter. Cette fenêtre se fermera à la fin du traitement.";
      // 
      // PleaseWaitForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(1115, 155);
      this.Controls.Add(this.labelPleaseWait);
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "PleaseWaitForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "PleaseWaitForm";
      this.Load += new System.EventHandler(this.PleaseWaitForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelPleaseWait;
  }
}