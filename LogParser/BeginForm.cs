using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace LogParser
{
    public partial class BeginForm : Form
    {
        const double minExtPower = 9;


        int _processesLines = 0;
        List<DataGridViewRow> _colorList = new List<DataGridViewRow>();

        public BeginForm(string file)
        {
            InitializeComponent();
            _watch.Path = Path.GetDirectoryName(file);
            _watch.Filter = Path.GetFileName(file);
            ReadFile(file);
            Focus();
            TimerAnimation.Start();
        }

        private void ReadFile(string file) {
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines) {
                string[] items = line.Split(new char[] { ',' });
                //Console.WriteLine(string.Join(" ", items));
                int row = -1;
                if (items.Length == 17)
                    //                             ID        Date                 Coords                     Spd       Azi       H         Sat       Act       Ign       Rou        Ext        Int        KM           SLG
                    row = DataGridViewLog.Rows.Add(items[0], ParseDate(items[1]), items[2] + ' ' + items[3], items[4], items[5], items[6], items[7], items[8], items[9], items[10], items[11], items[12], items[13], items[14] + ',' + items[15] + ',' + items[16]);
                else if (items.Length == 16)
                    //                             ID        Date                 Coords                     Spd       Azi       H         Sat       Act       Ign       Rou        Ext        Int        KM           SLG
                    row = DataGridViewLog.Rows.Add(items[0], ParseDate(items[1]), items[2] + ' ' + items[3], items[4], items[5], items[6], items[7], items[8], items[9], items[10], items[11], items[12], items[13], items[14] + ',' + items[15]);
                else if (line.Length > 2)
                {
                    row = DataGridViewLog.Rows.Add(1);
                    DataGridViewRow xrow = DataGridViewLog.Rows[row];

                    /*xrow.Cells[0] = new HMergedCell();
                    HMergedCell cell = (HMergedCell)xrow.Cells[0];
                    cell.LeftColumn = 0;
                    cell.RightColumn = 1;
                    cell.Value = "Сервисное сообщение:";

                    xrow.Cells[2] = new HMergedCell();
                    cell = (HMergedCell)xrow.Cells[2];
                    cell.LeftColumn = 2;
                    cell.RightColumn = 15;
                    cell.Value = line;*/
                    xrow.Cells[0] = new HMergedCell();
                    HMergedCell cell = (HMergedCell)xrow.Cells[0];
                    cell.LeftColumn = 0;
                    cell.RightColumn = 15;
                    cell.Value = line.Clone();

                    row = -1;
                }

                if (row >= 0)
                {
                    DataGridViewRow rr = DataGridViewLog.Rows[row];
                    int tmpInt;
                    double tmpDouble;
                    if (int.TryParse(items[7], out tmpInt) && tmpInt == 0)
                        rr.Cells[6].Style.BackColor = Color.Red;
                    if (double.TryParse(items[11], NumberStyles.Any, CultureInfo.InvariantCulture, out tmpDouble) && tmpDouble < minExtPower) //Set minimal 
                        rr.Cells[10].Style.BackColor = Color.Red;
                    if (items[8] == "14" && int.TryParse(items[9], out tmpInt))
                    {
                        if (tmpInt > 0)
                            rr.Cells[7].Style.BackColor = rr.Cells[8].Style.BackColor = Color.Yellow;
                        else
                            rr.Cells[7].Style.BackColor = rr.Cells[8].Style.BackColor = Color.Orange;
                    }
                }
            }
            DataGridViewLog.FirstDisplayedScrollingRowIndex = DataGridViewLog.RowCount - 1;
            _processesLines = lines.Length;
            Console.WriteLine("Readed {0}({1}) lines", lines.Length, DataGridViewLog.RowCount);
        }

        private void _watch_Changed(object sender, FileSystemEventArgs e)
        {
            string[] lines;
            try
            {
                lines = File.ReadAllLines(e.FullPath);
            }
            catch
            {
                return;
            }
            if (lines.Length <= _processesLines)
                return;
            Color c = Color.FromArgb(0, 255, 0);


            int firstDisplayed = DataGridViewLog.FirstDisplayedScrollingRowIndex;
            int displayed = DataGridViewLog.DisplayedRowCount(true);
            int lastVisible = (firstDisplayed + displayed) - 1;
            int lastIndex = DataGridViewLog.RowCount - 1;

            for (int i = _processesLines; i < lines.Length; i++)
            {
                string[] items = lines[i].Split(new char[] { ',' });
                //Console.WriteLine(string.Join(" ", items));
                int row = -1;
                if (items.Length == 17)
                    //                             ID        Date                 Coords                     Spd       Azi       H         Sat       Act       Ign       Rou        Ext        Int        KM           SLG
                    row = DataGridViewLog.Rows.Add(items[0], ParseDate(items[1]), items[2] + ' ' + items[3], items[4], items[5], items[6], items[7], items[8], items[9], items[10], items[11], items[12], items[13], items[14] + ',' + items[15] + ',' + items[16]);
                else if (items.Length == 16)
                    //                             ID        Date                 Coords                     Spd       Azi       H         Sat       Act       Ign       Rou        Ext        Int        KM           SLG
                    row = DataGridViewLog.Rows.Add(items[0], ParseDate(items[1]), items[2] + ' ' + items[3], items[4], items[5], items[6], items[7], items[8], items[9], items[10], items[11], items[12], items[13], items[14] + ',' + items[15]);
                else
                    DataGridViewLog.Rows.Add("Сервисное сообщение:", lines[i], "", "", "", "", "", "", "", "", "", "", "", "");
                
                if (row >= 0)
                {
                    DataGridViewRow rr = DataGridViewLog.Rows[row];
                    rr.DefaultCellStyle.BackColor = c;
                    int tmpInt;
                    double tmpDouble;
                    if (int.TryParse(items[7], out tmpInt) && tmpInt == 0)
                        rr.Cells[6].Style.BackColor = Color.Red;
                    if (double.TryParse(items[11], NumberStyles.Any, CultureInfo.InvariantCulture, out tmpDouble) && tmpDouble < minExtPower)
                        rr.Cells[10].Style.BackColor = Color.Red;
                    if (items[8] == "14" && int.TryParse(items[9], out tmpInt))
                    {
                        if (tmpInt > 0)
                            rr.Cells[7].Style.BackColor = rr.Cells[8].Style.BackColor = Color.Yellow;
                        else
                            rr.Cells[7].Style.BackColor = rr.Cells[8].Style.BackColor = Color.Orange;
                    }
                    _colorList.Add(DataGridViewLog.Rows[row]);
                }
            }
            _processesLines = lines.Length;

            if (lastVisible == lastIndex)
            {
                DataGridViewLog.FirstDisplayedScrollingRowIndex = firstDisplayed + 1;
            }
        }

        private string ParseDate(string src)
        {
            try
            {
                return DateTime.ParseExact(src, "yyyyMMddHHmmss", CultureInfo.InvariantCulture).ToLocalTime().ToString();
            }
            catch
            {
                return "Некорректное значение";
            }
        }

        private void TimerAnimation_Tick(object sender, EventArgs e)
        {
            for (int i = _colorList.Count - 1; i >= 0; i--)
            {
                if (_colorList[i].DefaultCellStyle.BackColor.B >= 255)
                    _colorList.RemoveAt(i);
                else
                {
                    int c = _colorList[i].DefaultCellStyle.BackColor.B;
                    _colorList[i].DefaultCellStyle.BackColor = Color.FromArgb(c+5, 255, c+5);
                }
            }
        }
    }
}
