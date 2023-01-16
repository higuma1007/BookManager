using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            bookDataSet.bookDataTable.AddbookDataTableRow(
                this.bookName.Text,
                this.auther.Text,
                int.Parse(this.price.Text)
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDisp(DataTable dt)
        {
//            bookDataGrid.RowTemplate.Height = 30;

//            bookDataGrid.RowTemplate.DefaultCellStyle.Padding = new Padding(5);

            bookDataGrid.DataSource = dt;

            bookDataGrid.AutoGenerateColumns = true;
        }

        private void RemoveButtonClicked(object sender, EventArgs e)
        {
            int row = this.bookDataGrid.CurrentRow.Index;
            this.bookDataGrid.Rows.RemoveAt(row);
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            const string FILE_PATH = @"bookManager.csv";

            string msg = "";

            if(bookDataGrid.RowCount <= 0)
            {
                msg = "出力データがありません！";
                MessageBox.Show(msg, "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            msg = "CSVファイルを出力します。" + "\n" + "宜しいでしょうか？";
            DialogResult result = MessageBox.Show(msg, "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if(result != DialogResult.Yes)
            {
                return;
            }

            using (StreamWriter sw = new StreamWriter(FILE_PATH, false, System.Text.Encoding.Default))
            {
                string s = "";

                for(int iCol = 0; iCol < bookDataGrid.Columns.Count; iCol++)
                {
                    string sCell = bookDataGrid.Columns[iCol].HeaderCell.Value.ToString();

                    if(iCol > 0)
                    {
                        s += ",";
                    }

                    s += quoteCommaCheck(sCell);
                }

                sw.WriteLine(s);

                for(int iRow = 0; iRow < bookDataGrid.Rows.Count; iRow++)
                {
                    s = "";
                    for(int iCol = 0; iCol < bookDataGrid.Columns.Count; iCol++)
                    {
                        String sCell = bookDataGrid[iCol, iRow].Value.ToString();

                        if(iCol > 0)
                        {
                            s += ",";
                        }

                        s += quoteCommaCheck(sCell);
                    }
                    
                    sw.WriteLine(s);
                }

                msg = "CSV出力が完了しました。";
                MessageBox.Show(msg, "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string quoteCommaCheck(string sCell)
        {
            const string QUOTE = @""""; // 「"」
            const string COMMA = @",";  // 「,」

            // OR検索用文字列
            string[] a = new string[] { QUOTE, COMMA };

            // セルの値に「”」か「,」が含まれていないか判定する
            if (a.Any(sCell.Contains))
            {
                // 「"」を「"」で囲む
                sCell = sCell.Replace(QUOTE, QUOTE + QUOTE);

                // セルの値を「"」で囲む
                sCell = QUOTE + sCell + QUOTE;
            }
            return sCell;
        }

        private void readButtonClicked(object sender, EventArgs e)
        {
            // 読込先
            const string FILE_PATH = @"bookManager.csv";
            //const string FILE_PATH = @"d:\sample.csv";

            // DataTableを作成する
            DataTable dt = createDataTable();

            // Shift-JISでファイルを開く
            using (TextFieldParser p = new TextFieldParser(FILE_PATH, System.Text.Encoding.Default))
            {
                // カンマ区切りで分割する
                p.TextFieldType = FieldType.Delimited;
                p.Delimiters = new string[] { "," };

                // １行目を無視する（ヘッダー）
                string[] csvHeader = p.ReadFields();

                // ２行目～最終行までループする
                while (!p.EndOfData)
                {
                    // DataTableに行のデータを追加する
                    dt.Rows.Add(p.ReadFields());
                }
            }

            // 一覧を表示する
            dataGridViewDisp(dt);
        }
        private DataTable createDataTable()
        {

            // DataTableを宣言する
            DataTable dt = new DataTable();

            // 列を作成する
            //            dt.Columns.Add("no", typeof(int));                        // No
            dt.Columns.Add("書名", typeof(String));                   // 書名
            dt.Columns.Add("著者", typeof(String));                   // 著者名
            dt.Columns.Add("値段", typeof(System.Int32));                  // 価格
//            dt.Columns.Add("値段", typeof(Decimal));                  // 価格
            //            dt.Columns.Add("publisher", typeof(String));              // 出版社名
            //            dt.Columns.Add("publication_date", typeof(DateTime));     // 出版年月
            //            dt.Columns.Add("stock", typeof(bool));                    // 在庫

            // DataTableを返す
            return dt;
        }
    }
}
