using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FredOraclePostgreSQLDataCompare
{
  public class DataGridViewComparer
  {
    public (int, int) GetDifferenceCounts(DataGridView dgv1, DataGridView dgv2)
    {
      var dgv1Rows = GetRowsAsStrings(dgv1);
      var dgv2Rows = GetRowsAsStrings(dgv2);

      int dgv1NotInDgv2 = dgv1Rows.Except(dgv2Rows).Count();
      int dgv2NotInDgv1 = dgv2Rows.Except(dgv1Rows).Count();

      return (dgv1NotInDgv2, dgv2NotInDgv1);
    }

    public List<string> GetRowsAsStrings(DataGridView dgv)
    {
      var rowsList = new List<string>();

      foreach (DataGridViewRow row in dgv.Rows)
      {
        if (!row.IsNewRow)
        {
          var rowValues = row.Cells
                           .Cast<DataGridViewCell>()
                           .Select(cell => cell.Value?.ToString() ?? string.Empty);
          rowsList.Add(string.Join("|", rowValues));
        }
      }

      return rowsList;
    }
  }
}
