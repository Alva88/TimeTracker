using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Globalization;
namespace TimeTracker
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckIfDirectoryAndFileExist();
            SaveDataToDataSource();
        } 

        private void F_Main_Load(object sender, EventArgs e)
        {
            try
            {
                // Check if directory exists
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "MM-dd-yyyy";
                AppSettings.TempDir = string.Format(@"{0}\TimeTrackLogging", Path.GetTempPath());
                CheckIfDirectoryAndFileExist();
                //build datatable and then bind it to grid
                BindingSource sBind = new BindingSource();
                MainTableClass.Maintable = CreateDataTableFromFile2(AppSettings.TempDir + @"\" + "TimeTracker");
                sBind.DataSource = MainTableClass.Maintable;
                dataGridView2.DataSource = MainTableClass.Maintable;

                //stretch last column to fit screen.
                var lastColIndex = dataGridView2.Columns.Count - 1;
                var lastCol = dataGridView2.Columns[lastColIndex];
                lastCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //Hide RecId and Date Columns
                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[4].Visible = false;
                //starting time tick
                timer1.Start();
                //filter datagridview
                QueryDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue with loading data" + Environment.NewLine + ex.ToString());
            }
        }

        private void QueryDate()
        {
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("Date = '{0}'", dateTimePicker1.Value.ToString("MM-dd-yyyy"));
            if ((dataGridView2.DataSource as DataTable).DefaultView.Count != 0)
            {
                GetRowTypes();
            }
            dataGridView2.Refresh();
        }
        /// <summary>
        /// Loading Types values into comboboxes.
        /// </summary>
        private void GetRowTypes()
        {
            int x = 0;
            if (dataGridView2.Rows != null)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    x++;
                    if (x <= (dataGridView2.DataSource as DataTable).DefaultView.Count)
                    {
                        if (string.IsNullOrEmpty(row.Cells["Type"].Value.ToString()) == false)
                        {
                            row.Cells["Types"].Value = row.Cells["Type"].Value.ToString();
                        }
                    }
                }
            }

        }
        /// <summary>
        /// Check if data directory exists, if it does not, create it within the tempdir.
        /// </summary>
        private void CheckIfDirectoryAndFileExist()
        {
            try
            {
                if (Directory.Exists(AppSettings.TempDir) == false)
                {
                    Directory.CreateDirectory(AppSettings.TempDir);
                    System.IO.FileStream file = System.IO.File.Create(AppSettings.TempDir + @"\" + "TimeTracker");
                    file.Close();
                }
                else
                {
                    if (File.Exists(AppSettings.TempDir + @"\" + "TimeTracker") == false)
                    {
                        System.IO.FileStream file = System.IO.File.Create(AppSettings.TempDir + @"\" + "TimeTracker");
                        file.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public DataTable BuildDataTable()
        {
            //create data table needed for saving/filtering
            DataTable dt = new DataTable("DateTimeRecords");
            DataColumn[] columns =
            {
                new DataColumn("RECID",typeof(int)),
                new DataColumn("Date",typeof(DateTime)),
                new DataColumn("Type",typeof(string)),
                new DataColumn("Time",typeof(string)),
                new DataColumn("Description",typeof(string)),
            };
            dt.Columns.AddRange(columns);
            return dt;
        }
        /// <summary>
        /// saving to textfile
        /// </summary>
        /// <returns></returns>
        private bool SaveDataToDataSource()
        {
            try
            {
                //wirte data to a flatfile
                StringBuilder sb = new StringBuilder();
                string fqp = AppSettings.TempDir + @"\" + "TimeTracker";
                
                //add any records to the flatfile
                foreach (DataRow row in MainTableClass.Maintable.Rows)
                {
                    sb.Append(string.Format("{0}@!@{1}@!@{2}@!@{3}@!@{4}{5}", row["RECID"].ToString(), row["Date"].ToString(), row["Type"].ToString(), row["Time"].ToString(), row["Description"].ToString(),Environment.NewLine));
                }
                if (sb != null)
                {
                    File.WriteAllText(fqp,sb.ToString());
                }
                
                return true;
            }          
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// This will update all the times for 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //For each GREEN row in datagridview, add one tic.
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if(row.Cells["Time"].Style.BackColor == Color.FromArgb(94, 100, 110))
                {
                    //take amount of seconds from cell and store into seconds.
                    string longTime = Convert.ToString(row.Cells["Time"].Value);
                    if(longTime == null | longTime == "")
                    {
                        longTime = "00:00:00";
                    }
                    TimeSpan duration = TimeSpan.Parse(longTime, CultureInfo.InvariantCulture);
                    int seconds = (int)duration.TotalSeconds + 1;
                    TimeSpan t = TimeSpan.FromSeconds(Convert.ToDouble(seconds));
                    row.Cells["Time"].Value = t.ToString(@"hh\:mm\:ss");
                }
            }
        }

        /// <summary>
        /// Loads and returns a datatable based on the file selected.
        /// </summary>
        /// <param name="FQP"></param>
        /// <returns></returns>
        public DataTable CreateDataTableFromFile2(string FQP)
        {
            // Insert code to read the stream here.
            DataTable table = BuildDataTable();
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(FQP);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] Ln = line.Split(new string[] { "@!@" }, StringSplitOptions.None);
                    table.Rows.Add(Ln[0], Ln[1], Ln[2], Ln[3], Ln[4]);
                }
                file.Close();
                return table;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        private void dataGridView2_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Time"].Value = "00:00:00";
            e.Row.Cells["Date"].Value = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            //sort by RECID, get top record, then add one. 
            int TopRecID = 0;
            if (MainTableClass.Maintable.Rows.Count != 0)
            {
                TopRecID = (int)MainTableClass.Maintable.Compute("Max(RECID)", "") +1;
            }
            e.Row.Cells["RECID"].Value = TopRecID;
        }

        public static int colidx = 0;
        public static int rowidx = 0;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //color Time cell green or white
            switch (dataGridView2.CurrentCell.ColumnIndex)
            {
                //Reset time
                case 2:
                    colidx = dataGridView2.CurrentCell.ColumnIndex;
                    rowidx = dataGridView2.CurrentCell.RowIndex;
                    break;
                case 1:
                    var result = MessageBox.Show("Reset time?", "Reset?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        // cancel the closure of the form.
                        return;
                    }
                    else if (result == DialogResult.Yes)
                    {
                        //reset total time
                        dataGridView2.Rows[e.RowIndex].Cells[6].Value = "00:00:00";
                    }
                    break;

                //Start/Stop Time
                case 0:
                    if (dataGridView2.Rows[e.RowIndex].Cells[6].Style.BackColor == Color.FromArgb(94, 100, 110))
                    {

                        dataGridView2.Rows[e.RowIndex].Cells[6].Style.BackColor = Color.FromArgb(28, 30, 33);
                        dataGridView2.Rows[e.RowIndex].Cells[7].Style.BackColor = Color.FromArgb(28, 30, 33);
                    }
                    else
                    {
                        dataGridView2.Rows[e.RowIndex].Cells[6].Style.BackColor = Color.FromArgb(94, 100, 110); 
                        dataGridView2.Rows[e.RowIndex].Cells[7].Style.BackColor = Color.FromArgb(94, 100, 110); 
                    }

                    break;
                default:
                    break;
            }
        }

        private void btnQryDate_Click(object sender, EventArgs e)
        {
              QueryDate();
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
                combo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string item = cb.Text;
            if (item != null)
            dataGridView2.Rows[rowidx].Cells[5].Value = cb.Text;               
        }
    }
}
