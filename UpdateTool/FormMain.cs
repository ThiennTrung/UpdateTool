using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UpdateTool.Model;
using UpdateTool.Class;
using System.Configuration;
using System.Transactions;
using System.IO.Compression;
using Newtonsoft.Json;
using System.Text;
using ScintillaNET;
using System.Drawing;
using Newtonsoft.Json.Linq;

namespace UpdateTool
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        private List<ObjConnect> _HISConnects = new List<ObjConnect>();
        public string MABENHVIEN = string.Empty;
        readonly Stopwatch stopWatch = new Stopwatch();
        //PoorMansTSqlFormatterLib.SqlFormattingManager fullFormatter = new PoorMansTSqlFormatterLib.SqlFormattingManager();
        List<UpdateTool.Model.FileInfo> list = new List<UpdateTool.Model.FileInfo>();
        public string Key = string.Empty;
        //public string indexFolder = @"C:\Users\ADMIN\Desktop\Text";
        //public string documentFolder = string.Empty;
        //public Index indexSearch;
        private List<ObjConnect> MuiltiSite = new List<ObjConnect>();
        public HospitalSettings section
        {
            get
            {
                return ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).GetSection("HospitalSettings") as HospitalSettings;
            }
            set { }

        }
        public FormMain()
        {
            InitializeComponent();
            Cbo_ResetDataSource();

            scintilla1.CaretForeColor = Color.White;

            scintilla1.StyleResetDefault();
            scintilla1.Styles[Style.Default].Font = "Consolas";
            scintilla1.Styles[Style.Default].Size = 11;
            scintilla1.Styles[Style.Default].BackColor = Color.FromArgb(41, 49, 52);
            scintilla1.StyleClearAll();

            scintilla1.Lexer = Lexer.Sql;

            scintilla1.Styles[Style.Sql.Word].ForeColor = Color.FromArgb(147, 199, 99);
            scintilla1.Styles[Style.Sql.Word].Bold = true;
            scintilla1.Styles[Style.Sql.Identifier].ForeColor = Color.FromArgb(255, 255, 255);
            scintilla1.Styles[Style.Sql.Character].ForeColor = Color.FromArgb(236, 118, 0);
            scintilla1.Styles[Style.Sql.Number].ForeColor = Color.FromArgb(255, 205, 34);
            scintilla1.Styles[Style.Sql.Operator].ForeColor = Color.FromArgb(232, 226, 183);
            scintilla1.Styles[Style.Sql.Comment].ForeColor = Color.FromArgb(102, 116, 123);
            scintilla1.Styles[Style.Sql.CommentLine].ForeColor = Color.FromArgb(102, 116, 123);

            scintilla1.SetKeywords(0, "select where from set left join inner group having insert into alter create declare");
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            clsDataProvider.CreateSqlConnection((comboBox1.SelectedItem as ObjConnect).value.ToString());
        }
        private void LoadListFileName(string[] files, ref bool sqlbutton, ref bool Formbutton, string path)
        {
            int index = 0;
            foreach (var file in files)
            {
                System.IO.FileInfo oFileInfo = new System.IO.FileInfo(file);

                if (!oFileInfo.Extension.Contains(".sql") && !oFileInfo.Extension.Contains(".txt") && !oFileInfo.Extension.Contains(".gz"))
                    continue;

                list.Add(new UpdateTool.Model.FileInfo(index, oFileInfo.Name, oFileInfo.CreationTime, oFileInfo.FullName));
                index++;
                if (oFileInfo.Extension.Contains(".sql") || oFileInfo.Extension.Contains(".txt"))
                    sqlbutton = true;
                if (oFileInfo.Extension.Contains(".gz"))
                    Formbutton = true;
            }
            //indexSearch = new Index(indexFolder,true);
            //indexSearch.Add(path);

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            scintilla1.Text = string.Empty;
            bool sqlbutton = false;
            bool Formbutton = false;

            FolderBrowserDialog fdBrowser = new FolderBrowserDialog();
            if (fdBrowser.ShowDialog() == DialogResult.OK)
            {
                gridControl1.DataSource = null;

                string[] dirs = Directory.GetDirectories(fdBrowser.SelectedPath);
                var filePaths = new List<string>();
                if (dirs.Count() > 0)
                {
                    foreach (string dir in dirs)
                    {
                        filePaths.AddRange(Directory.GetFiles(dir));
                    }
                }
                else // Try get file from URL input
                {
                    filePaths.AddRange(Directory.GetFiles(fdBrowser.SelectedPath));
                }
            string[] files = filePaths.ToArray();


                textEdit1.Text = fdBrowser.SelectedPath;
                //string[] files = Directory.GetFiles(fdBrowser.SelectedPath);
                if (files.Count() > 0)
                {
                    list.Clear();
                    LoadListFileName(files, ref sqlbutton, ref Formbutton, textEdit1.Text);
                    gridControl1.DataSource = list;
                }
                gridControl1.DataSource = list;
                simpleButton3.Enabled = sqlbutton;
                simpleButton4.Enabled = Formbutton;
            }
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Count() == 0)
                return;
            if (!clsDataProvider.CreateSqlConnection((comboBox1.SelectedItem as ObjConnect).value.ToString()))
            {
                MessageBox.Show("Connect Fail...");
                return;
            }
            progressBar1.Value = 0;
            scintilla1.Text = string.Empty;

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync(gridView1.GetSelectedRows().Count());
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            stopWatch.Start();
            int max = (int)e.Argument;
            int result = 0;
            var list = gridView1.GetSelectedRows();

            string log_fail = Path.Combine(textEdit1.Text, string.Format("FAIL_{0}", Key), "LOG.txt");
            System.IO.FileInfo fi = new System.IO.FileInfo(log_fail);
            if (fi.Exists)
                fi.Delete();

            foreach (var i in list)
            {
                int progressPercentage = Convert.ToInt32(((double)result / max) * 100);
                string filename = gridView1.GetRowCellValue(i, "NAME").ToString();
                string path = gridView1.GetRowCellValue(i, "path").ToString();

                Boolean isSeccess = false;
                string mess = string.Empty;
                isSeccess = Run(ref mess, path, false);

                if (isSeccess)
                {
                    Invoke((MethodInvoker)delegate {
                        gridView1.SetRowCellValue(i, "TRANGTHAI", "Sussces");
                        gridView1.SetRowCellValue(i, "MESS", mess);
                        scintilla1.Text += "Đã chạy file [" + filename + "] ... " + "\r\n";
                    });

                    //string foldername = string.Format("SUCCESS_{0}", Key);
                    //bool exists = System.IO.Directory.Exists(Path.Combine(textEdit1.Text, foldername));
                    //if (!exists) { System.IO.Directory.CreateDirectory(Path.Combine(textEdit1.Text, foldername)); }
                    //System.IO.File.Copy(path, Path.Combine(textEdit1.Text, foldername + @"\" + filename), true);
                }
                else
                {
                    string foldername = string.Format("FAIL_{0}", Key);
                    bool exists = System.IO.Directory.Exists(Path.Combine(textEdit1.Text, foldername));
                    if (!exists) { System.IO.Directory.CreateDirectory(Path.Combine(textEdit1.Text, foldername)); }
                    System.IO.File.Copy(path, Path.Combine(textEdit1.Text, foldername + @"\" + filename), true);

                    using (var sw = new StreamWriter(log_fail, true))
                    {
                        sw.WriteLine(string.Format("{0} ==> {1} \n", filename, mess));
                    }

                    //using (StreamWriter sw = fi.CreateText())
                    //{
                    //    sw.WriteLine(string.Format("{0} ==> {1}", filename, mess));
                    //    sw.WriteLine("Done! ");
                    //}
                    Invoke((MethodInvoker)delegate {
                        gridView1.SetRowCellValue(i, "TRANGTHAI", "Fail");
                        gridView1.SetRowCellValue(i, "MESS", mess);
                        scintilla1.Text += "Đã chạy file [" + filename + "] ... " + "\r\n";
                    });
                }
                result++;
                (sender as BackgroundWorker).ReportProgress(progressPercentage, i);
                //System.Threading.Thread.Sleep(100);
            }
            e.Result = result;
        }
        public static Boolean Run(ref string result, string strFileName, Boolean Backup)
        {
            Boolean bln = true;
            result = " --> DONE";
            try
            {
                String strContent = System.IO.File.ReadAllText(strFileName);
                if (!string.IsNullOrEmpty(strContent))
                {
                    try
                    {
                        var statements = SplitSqlStatements(strContent);
                        foreach (var item in statements)
                        {
                            clsDataProvider.RunExecute(item);
                        }
                    }
                    catch (Exception ex)
                    {
                        result = ex.Message;
                        bln = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
                bln = false;
            }
            return bln;
        }
        private static IEnumerable<string> SplitSqlStatements(string sqlScript)
        {
            sqlScript = Regex.Replace(sqlScript, @"(\r\n|\n\r|\n|\r)", "\n");

            var statements = Regex.Split(
                    sqlScript,
                    @"^[\t ]*GO[\t ]*\d*[\t ]*(?:--.*)?$",
                    RegexOptions.Multiline |
                    RegexOptions.IgnorePatternWhitespace |
                    RegexOptions.IgnoreCase);

            return statements
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(x => x.Trim(' ', '\n'));
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = progressBar1.Maximum;
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("Time {0:00}.{1:00}", ts.Seconds, ts.Milliseconds / 10);
            label3.Text = elapsedTime;
            stopWatch.Reset();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            ConfigForm f = new ConfigForm();
            f.ShowDialog();
            Cbo_ResetDataSource();
        }
        private void Cbo_ResetDataSource()
        {
            if (_HISConnects.Count > 0)
                _HISConnects.Clear();
            comboBox1.DataSource = null;
            comboBox1.DisplayMember = "display";
            comboBox1.ValueMember = "value";

            List<ObjConnect> _HISConnects_PRO = new List<ObjConnect>();
            List<ObjConnect> _HISConnects_STA = new List<ObjConnect>();
            var server = from HospitalSetting s in section.Hospitals select s;
            var a = server.Where(x => !string.IsNullOrWhiteSpace(x.TEXT)).ToList();
            foreach (var item in a)
            {
                ObjConnect obj = new ObjConnect(item.KEY, item.TEXT, item.VALUE, item.BENHVIEN_ID);
                _HISConnects.Add(obj);
                if (item.TEXT.Contains("PRO"))
                {
                    _HISConnects_PRO.Add(obj);
                }
                else { _HISConnects_STA.Add(obj);  }
            }
            comboBox1.DataSource = _HISConnects;


            checkedListBoxControl1.DataSource = _HISConnects_PRO;
            checkedListBoxControl1.DisplayMember = "display";
            checkedListBoxControl1.ValueMember = "value";

            checkedListBoxControl2.DataSource = _HISConnects_STA;
            checkedListBoxControl2.DisplayMember = "display";
            checkedListBoxControl2.ValueMember = "value";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                MABENHVIEN = (comboBox1.SelectedItem as ObjConnect).Benhvien_id.ToString();
                Key = (comboBox1.SelectedItem as ObjConnect).code.ToString();
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (clsDataProvider.CreateSqlConnection((comboBox1.SelectedItem as ObjConnect).value.ToString()))
                MessageBox.Show("Test OK");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (((IEnumerable<int>)this.gridView1.GetSelectedRows()).Count<int>() == 0)
                return;
           
            if (checkEdit2.Checked)
            {
                UpFormMuiltiDB();
            }
            else
            {
                if (!clsDataProvider.CreateSqlConnection((this.comboBox1.SelectedItem as ObjConnect).value.ToString()))
                {
                    int num = (int)MessageBox.Show("Connect Fail...");
                }
                else
                {
                    this.scintilla1.Text = string.Empty;
                    this.progressBar1.Value = 0;
                    if (this.backgroundWorker2.IsBusy)
                        return;
                    this.backgroundWorker2.RunWorkerAsync((object)((IEnumerable<int>)this.gridView1.GetSelectedRows()).Count<int>());
                }
            }
            
        }

        private void UpFormMuiltiDB()
        {
            MuiltiSite.Clear();
            StringBuilder mess = new StringBuilder();

            var itemsPRO = checkedListBoxControl1.CheckedItems.Cast<ObjConnect>();
            var itemsSTA = checkedListBoxControl2.CheckedItems.Cast<ObjConnect>();


            if (itemsPRO.Count() + itemsSTA.Count() <= 0 ) { return; }

            mess.AppendLine("Xác nhận update các site: ");
            foreach (var item in itemsPRO)
            {
                mess.AppendLine(string.Format("   + {0}", item.display));
                MuiltiSite.Add(item);
            }
            foreach (var item in itemsSTA)
            {
                mess.AppendLine(string.Format("   + {0}", item.display));
                MuiltiSite.Add(item);
            }

            DialogResult dr = MessageBox.Show(mess.ToString(),"XÁC NHẬN",MessageBoxButtons.YesNo);

            if (dr == DialogResult.No) { return; }
            if (dr == DialogResult.Yes)
            {

                this.scintilla1.Text = string.Empty;

                if (this.backgroundWorker3.IsBusy)
                    return;

                this.backgroundWorker3.RunWorkerAsync();
            }
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var item in MuiltiSite)
            {
                var list = gridView1.GetSelectedRows();
                foreach (var i in list)
                {
                    Invoke((MethodInvoker)delegate {
                        gridView1.SetRowCellValue(i, "TRANGTHAI", string.Empty);
                        gridView1.SetRowCellValue(i, "MESS", string.Empty);
                    });
                }
           

                ClearColumn();
                string ConnectionString = item.value;
                clsDataProvider.CreateSqlConnection(ConnectionString);

                Invoke((MethodInvoker)delegate {
                    scintilla1.Text += "Start update site  " + item.display + "\r\n";
                });

                
                foreach (var i in list)
                {
                    string filename = gridView1.GetRowCellValue(i, "NAME").ToString();
                    string path = gridView1.GetRowCellValue(i, "path").ToString();

                    UpForm(i, filename, path);
                }
            }
            Invoke((MethodInvoker)delegate {
                scintilla1.Text += "DONE........ "+ "\r\n";
            });
        }
        private void ClearColumn()
        {
            
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int max = (int)e.Argument;
            int result = 0;
            var list = gridView1.GetSelectedRows();

            foreach (var i in list)
            {
                int progressPercentage = Convert.ToInt32(((double)result / max) * 100);
                string filename = gridView1.GetRowCellValue(i, "NAME").ToString();
                string path = gridView1.GetRowCellValue(i, "path").ToString();

                UpForm(i, filename, path);

                result++;
                (sender as BackgroundWorker).ReportProgress(progressPercentage, i);
            }

            e.Result = result;
        } 

        private void UpForm(int i,string filename, string path)
        {
            List<Dictionary<string, object>> items = null;

            System.IO.FileInfo fileToDecompress = new System.IO.FileInfo(path);
            using (TransactionScope transactionScope = new TransactionScope())
            {
                lock (fileToDecompress)
                {
                    try
                    {
                        clsDataProvider.Open();
                        Stopwatch stopWatch = new Stopwatch();
                        stopWatch.Start();
                        string page = Path.GetFileNameWithoutExtension(fileToDecompress.FullName);
                        Dictionary<string, object> parameters1 = new Dictionary<string, object>();
                        parameters1["PAGE"] = page;
                        parameters1["HOSPITAL"] = MABENHVIEN;
                        clsDataProvider.ExcuteQuery("DELETE FROM TM_SYS_SCREEN WHERE PAGE=@PAGE and TM_SYS_SCREEN.HOSPITAL_ID=@HOSPITAL", parameters1);

                        items = Decompress(fileToDecompress);
                        items.RemoveAt(0);
                        int num1 = 1;
                        foreach (Dictionary<string, object> dictionary in items)
                        {
                            string str1 = string.Format("{0}{1:000}", (object)page, (object)num1);
                            dictionary["Id"] = (object)str1;
                            dictionary["HOSPITAL_ID"] = MABENHVIEN;
                            dictionary["Locale"] = "vi-vn";
                            if (!dictionary.ContainsKey("TextAlign"))
                                dictionary.Add("TextAlign", (object)0);
                            ++num1;
                            StringBuilder stringBuilder1 = new StringBuilder();
                            StringBuilder stringBuilder2 = new StringBuilder();
                            Dictionary<string, object> parameters2 = new Dictionary<string, object>();
                            string str = "";
                            stringBuilder1.Append("INSERT INTO TM_SYS_SCREEN (");
                            stringBuilder2.Append(" VALUES(");
                            foreach (KeyValuePair<string, object> keyValuePair in dictionary)
                            {
                                string key = Object2DB(keyValuePair.Key);
                                if (!(key == string.Empty))
                                {
                                    stringBuilder1.Append(str);
                                    stringBuilder1.Append(key);
                                    stringBuilder2.Append(str);
                                    stringBuilder2.Append("@" + key);
                                    parameters2.Add(key, keyValuePair.Value);
                                    str = ",";
                                }
                            }
                            stringBuilder1.Append(")");
                            stringBuilder2.Append(")");
                            stringBuilder1.Append(stringBuilder2.ToString());
                            clsDataProvider.ExcuteQuery(stringBuilder1.ToString(), parameters2);
                        }
                        clsDataProvider.ExcuteQuery("update TM_SYS_CACHE set UPDATE_TIME=GETDATE() WHERE (ID LIKE '%" + page + "%' OR ID like '%REFCONTROL%')", parameters1);
                        stopWatch.Stop();
                        TimeSpan ts = stopWatch.Elapsed;
                        string elapsedTime = String.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds / 10);
                        //Console.WriteLine(string.Format("{0} => Time {1}", page, elapsedTime));

                        Invoke((MethodInvoker)delegate {
                            gridView1.SetRowCellValue(i, "TRANGTHAI", "Sussces");
                            gridView1.SetRowCellValue(i, "MESS", string.Format("Time {0}", elapsedTime));
                            scintilla1.Text += "Đã chạy file [" + filename + "] ... " + "\r\n";
                        });

                    }
                    catch (Exception ex)
                    {
                        Invoke((MethodInvoker)delegate {
                            gridView1.SetRowCellValue(i, "TRANGTHAI", "Fail");
                            gridView1.SetRowCellValue(i, "MESS", ex.Message);
                        });
                    }
                }
                transactionScope.Complete();
            }
            clsDataProvider.Close();
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        public static List<Dictionary<string, object>> Decompress(System.IO.FileInfo fileToDecompress)
        {
            using (FileStream fileStream = fileToDecompress.OpenRead())
            {
                string fullName = fileToDecompress.FullName;
                using (GZipStream gzipStream = new GZipStream((Stream)fileStream, CompressionMode.Decompress))
                {
                    using (StreamReader streamReader = new StreamReader((Stream)gzipStream))
                        return JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(streamReader.ReadToEnd());
                }
            }
        }
        public static string Object2DB(string prop)
        {
            switch (prop)
            {
                case "Anchor":
                    return "ANCHOR";
                case "Attributes":
                    return "ATTRIBUTES";
                case "Command_Click":
                    return "CLICK";
                case "Command_DoubleClick":
                    return "DOUBLECLICK";
                case "Command_SelChanged":
                    return "SELCHANGED";
                case "Command_TextChanged":
                    return "TEXTCHANGED";
                case "DataBindingName":
                    return "DATABINDINGNAME";
                case "DataRefName":
                    return "DATAREFNAME";
                case "Dock":
                    return "DOCK";
                case "Enabled":
                    return "ENABLE";
                case "FormatId":
                    return "FORMAT";
                case "HOSPITAL_ID":
                    return "HOSPITAL_ID";
                case "Height":
                    return "HEIGHT";
                case "Help":
                    return "HELP";
                case "HotKeyId":
                    return "HOTKEY";
                case "Id":
                    return "ID";
                case "Image1":
                    return "IMAGE1";
                case "Image2":
                    return "IMAGE2";
                case "Left":
                    return "X";
                case "Locale":
                    return "LOCALE";
                case "Margin":
                    return "MARGIN";
                case "MaxLength":
                    return "MAXLENGTH";
                case "Name":
                    return "NAME";
                case "Padding":
                    return "PADDING";
                case "Page":
                    return "PAGE";
                case "ParentName":
                    return "PARENTNAME";
                case "StyleId":
                    return "STYLE";
                case "TabIndex":
                    return "TABINDEX";
                case "Template":
                    return "TEMPLATE";
                case "Text":
                    return "TEXT";
                case "Top":
                    return "Y";
                case "ValidationId":
                    return "VALIDATION";
                case "Visible":
                    return "VISIBLE";
                case "WaterMark":
                    return "WATERMARK";
                case "Width":
                    return "WIDTH";
                case "X":
                    return "X";
                case "Y":
                    return "Y";
                default:
                    return string.Empty;
            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = progressBar1.Maximum;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                String strContent = System.IO.File.ReadAllText(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "path").ToString());
                scintilla1.Text = strContent;
            }
        }

        //private void simpleButton5_Click(object sender, EventArgs e)
        //{
        //    SearchResult result = indexSearch.Search(textEdit2.Text);

        //    foreach (FoundDocument document in result)
        //    {
        //        scintilla1.Text += "Document Path : " + document.DocumentInfo.FilePath + "\n";
        //    }
        //}

        private void textEdit1_EditValueChanged_1(object sender, EventArgs e)
        {
            list.Clear();
            scintilla1.Text = string.Empty;
            if (string.IsNullOrEmpty(textEdit1.Text))
            {
                gridControl1.DataSource = null;
                checkEdit1.Checked = false;
                textEdit2.Text = string.Empty;
                return;
            }
            bool sqlbutton = false;
            bool Formbutton = false;
            if (!System.IO.Directory.Exists(textEdit1.Text))
            {
                gridControl1.DataSource = null;
                list.Clear();
                return;
            }

            string[] dirs = Directory.GetDirectories(textEdit1.Text);
            var filePaths = new List<string>();

            if (dirs.Count() > 0)
            {
                foreach (string dir in dirs)
                {
                    filePaths.AddRange(Directory.GetFiles(dir));
                }
            }
            else // Try get file from URL input
            {
                filePaths.AddRange(Directory.GetFiles(textEdit1.Text));
            }

            string[] files = filePaths.ToArray();

            if (files.Count() > 0)
            {
                LoadListFileName(files, ref sqlbutton, ref Formbutton, textEdit1.Text);
                gridControl1.DataSource = list;
            }
            simpleButton3.Enabled = sqlbutton;
            simpleButton4.Enabled = Formbutton;

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var data = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "path").ToString();
            DialogResult dr = MessageBox.Show("Cập nhật file " + data, "Lưu dữ liệu", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No) { return; }
            if (dr == DialogResult.Yes)
            {
                using (var sw = new StreamWriter(data, false))
                {
                    sw.WriteLine(scintilla1.Text);
                }
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                if (string.IsNullOrEmpty(textEdit1.Text))
                {
                    MessageBox.Show("Chưa chọn folder", "Warning");
                    checkEdit1.Checked = false;
                    return;
                }
                scintilla1.Text = string.Empty;
                UpdateTool.Class.Helper.TBFileIndexing = scintilla1;
                UpdateTool.Class.Helper.Index(textEdit1.Text, "INDEXSEARCH");
                scintilla1.AppendText(Environment.NewLine + "Create index DONE....");
                textEdit2.Enabled = true;
            }
            else
            {
                textEdit2.Enabled = false;
                scintilla1.Text = string.Empty;
            }    
        }

        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string term = textEdit2.Text.Trim();
                gridControl1.DataSource = null;
                list.Clear();
                scintilla1.Text = string.Empty;
                bool sqlbutton = false;
                bool Formbutton = false;

                var resultItems = UpdateTool.Class.Helper.SearchInDB(term, "INDEXSEARCH", textEdit1.Text);
                string[] files = resultItems.Select(x => x.Path).ToArray<string>();

                LoadListFileName(files, ref sqlbutton, ref Formbutton, textEdit1.Text);
                gridControl1.DataSource = list;


                simpleButton3.Enabled = sqlbutton;
                simpleButton4.Enabled = Formbutton;

                e.SuppressKeyPress = true;
            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked)
            {
                checkedListBoxControl1.Enabled = true;
                checkedListBoxControl2.Enabled = true;
                comboBox1.SelectedIndex = -1;
                comboBox1.Enabled = false;
            }
            else
            {
                checkedListBoxControl1.UnCheckAll();
                checkedListBoxControl2.UnCheckAll();
                checkedListBoxControl1.Enabled = false;
                checkedListBoxControl2.Enabled = false;
                comboBox1.Enabled = true;

            }
        }
    }
}
