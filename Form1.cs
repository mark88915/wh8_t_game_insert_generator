using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace tgame_insert_sql_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            ofd.FileName = "";
            ofd.Title = "選擇一個Excel檔案";
            resultBox.ScrollBars = ScrollBars.Vertical;

            isThExist.Checked = true;
            isIdExist.Checked = true;
            isViExist.Checked = true;
            isEsExist.Checked = true;
            isPtExist.Checked = true;
            isImageExist.Checked = true;
        }

        private void fileSelectBtn_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            var fileNameArr = ofd.FileName.Split('\\');
            fileName.Text = fileNameArr[fileNameArr.Length - 1];
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (ofd.FileName.Length <= 0) 
            {
                resultBox.Text = "請先選擇檔案";
                return;
            }

            // 需要先設定NonCommercial License，否則會噴錯
            // 細節參考 https://epplussoftware.com/developers/licenseexception
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            string result = string.Empty;
            using (var package = new ExcelPackage(new System.IO.FileInfo(ofd.FileName)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // 使用第一個工作表
                for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
                {
                    string gamecode = CheckNameIfHaveSingleQuote(worksheet.Cells[row, 1].Text), 
                        cn = CheckNameIfHaveSingleQuote(worksheet.Cells[row, 2].Text), 
                        hk = CheckNameIfHaveSingleQuote(worksheet.Cells[row, 3].Text),
                        en = CheckNameIfHaveSingleQuote(worksheet.Cells[row, 4].Text),
                        th = CheckNameIfHaveSingleQuote(worksheet.Cells[row, 5].Text),
                        vi = CheckNameIfHaveSingleQuote(worksheet.Cells[row, 6].Text),
                        id = CheckNameIfHaveSingleQuote(worksheet.Cells[row, 7].Text),
                        es = CheckNameIfHaveSingleQuote(worksheet.Cells[row, 8].Text),
                        pt = CheckNameIfHaveSingleQuote(worksheet.Cells[row, 9].Text);
                    //string imageSQL = $"{(isImageExist.Checked ? $"N'{gamecode}_cn.png', N'{gamecode}_hk.png', N'{gamecode}_en.png', N'{gamecode}_{(isThExist.Checked ? "th" : "en")}.png', N'{gamecode}_{(isViExist.Checked ? "vi" : "en")}.png', N'{gamecode}_{(isIdExist.Checked ? "id" : "en")}.png', N'{gamecode}_{(isEsExist.Checked ? "es" : "en")}.png', N'{gamecode}_{(isPtExist.Checked ? "pt" : "en")}.png'" : "N'', N'', N'', N'', N'', N'', N'', N''")}";
                    string imageSQL = $"{(isImageExist.Checked ? $"N'{gamecode}_cn.png', N'{gamecode}_cn.png', N'{gamecode}_en.png', N'{gamecode}_en.png', N'{gamecode}_en.png', N'{gamecode}_en.png', N'{gamecode}_en.png', N'{gamecode}_en.png'" : "N'', N'', N'', N'', N'', N'', N'', N''")}";
                    string baseStr = $@"INSERT INTO [dbo].[t_game] ([gametype], [gamekind], [device], [platform], [gamecategory], [gamecode], [reportgamecode], [category], [gamename], [gamename_hk], [gamename_en], [gamename_th], [gamename_vi], [gamename_id], [gamename_es], [gamename_pt], [image], [image_hk], [image_en], [image_th], [image_vi], [image_id], [image_es], [image_pt], [seq], [status], [cdate], [remark], [noRebate], [link], [DataVersion]) VALUES ('{gametype.Text}', '{gamekind.Text}', '{device.Text}', {(platform.Text.ToLower() == "null" ? "NULL" : $"'{platform.Text}'")}, '{gamekind.Text}', '{gamecode}', '{gamecode}', '{gamekind.Text}', N'{cn}', N'{hk}', N'{en}', N'{th}', N'{vi}', N'{id}', N'{es}', N'{pt}', {imageSQL},";
                    baseStr += $"{row}, 'Y', GETDATE(), NULL, '0', '', 0);\n";
                    result += baseStr;
                }

                resultBox.Text = result;
            }
        }

        private string CheckNameIfHaveSingleQuote(string gameName)
        {
            if (gameName.Contains("'"))
            {
                int singleQuotePosition = gameName.IndexOf("'", StringComparison.OrdinalIgnoreCase);
                return gameName.Insert(singleQuotePosition, "'");
            }
            else
            {
                return gameName;
            }
        }
    }
}
