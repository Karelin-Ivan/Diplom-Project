using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace MSSQL
{
    public partial class FormCreatePDF : Form
    {
        public FormCreatePDF()
        {
            InitializeComponent();
        }


        private static string generalfile = Properties.Settings.Default.DocumentsInputPath + @"/repairPrinter.docx"; // файл-шаблон
        private static string newfile = $"{Properties.Settings.Default.DocumentsOutputPath} {DateTime.Now.ToString().Replace(":", "")}.pdf"; // новый файл на основе файла-шаблона
        private static Object fileName = generalfile;
        private static Object missing = Type.Missing;

        // Открываем файл test.doc (шаблон)
        private void OpenFile(Word.Application app)
        {
            try
            {
                app.Documents.Open(ref fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Закрытие general и сохранение файла нового файла PDF
        private void SaveCloseFilePDF(Word.Application app)
        {
            if (app.Documents != null && app.ActiveDocument != null)
            {
                app.ActiveDocument.ExportAsFixedFormat(newfile,
                WdExportFormat.wdExportFormatPDF,true);
                app.ActiveDocument.Close(false);
            }
        }

        // Закрытие general и сохранение файла нового файла DOCX
        private void SaveCloseFileDOCX(Word.Application app)
        {
            if (app.Documents != null && app.ActiveDocument != null)
            {
                app.ActiveDocument.SaveAs(newfile + ".docx");
                app.ActiveDocument.Close();
            }
        }

        // поиск и замена
        private void FindReplace(string str_old, string str_new, Word.Application app)
        {
            Word.Find find = app.Selection.Find;

            find.Text = str_old; // текст поиска
            find.Replacement.Text = str_new; // текст замены

            find.Execute(FindText: Type.Missing, MatchCase: false, MatchWholeWord: false, MatchWildcards: false,
                        MatchSoundsLike: missing, MatchAllWordForms: false, Forward: true, Wrap: Word.WdFindWrap.wdFindContinue,
                        Format: false, ReplaceWith: missing, Replace: Word.WdReplace.wdReplaceAll);
        }

        private void Replases(Word.Application app)
        {
            FindReplace("{OutDate}", dateTimePicker1.Value.ToString("dd.MM.yyyy"),app);
            FindReplace("{PrinterName}", comboBoxPrinterModel.Text, app);
            FindReplace("{SerialNumber}", textBoxSN.Text.ToString(), app);
            FindReplace("{NowDate}", dateTimePicker2.Value.ToString("dd.MM.yyyy"), app);
        }

        private void buttonCreatePDF_Click(object sender, EventArgs e)
        {
            Word.Application app = new Word.Application();
            OpenFile(app);
            Replases(app);
            SaveCloseFilePDF(app);

            MessageBox.Show("Документ PDF успешно создан");
        }

        private void buttonCreateDOCX_Click(object sender, EventArgs e)
        {
            Word.Application app = new Word.Application();
            OpenFile(app);
            Replases(app);
            SaveCloseFileDOCX(app);

            MessageBox.Show("Документ DOCX успешно создан");
        }

        private void FormCreatePDF_Load(object sender, EventArgs e)
        {
            foreach (string el in DataBaseCommands.GetUniqueItems("Technics"))
            {
                comboBoxPrinterModel.Items.Add(el);
            }

            dateTimePicker1.Value = DateTime.Now.Date;
            dateTimePicker2.Value = DateTime.Now.Date;
        }
    }
}
