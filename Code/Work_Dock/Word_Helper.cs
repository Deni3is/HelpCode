using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace Hotel.Dock_helper
{

    class Word_Helper
    {

        private FileInfo _fileInfo;
        public Word_Helper(string fileName)
        {
            if (File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName);
            }
            else
            {
                throw new ArgumentException("file not found");
            }
        }

        internal bool Process(Dictionary<string, string> items)
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = _fileInfo.FullName; //полный путь к файлу

                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find; // объект с помощью которого и будем искать
                    find.Text = item.Key; // то что будем менять
                    find.Replacement.Text = item.Value; //на что будем менять 

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing, MatchCase: false, MatchWholeWord: false, MatchWildcards: false, MatchSoundsLike: missing,
                        MatchAllWordForms: false, Forward: true, Wrap: wrap, Format: false, ReplaceWith: missing, Replace: replace);
                }

                Object newFileName = Path.Combine(_fileInfo.DirectoryName, DateTime.Now.ToString("yyyyMMdd HHmmss") + _fileInfo.Name);
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (app != null)
                    app.Quit();
            }
            return false;
        }
        // В основной программе нужно передать: 
        //Имя таблицы, Массив имён колонок, имя ключа, даты начала и конца
        //dateName как и имя ключа - название нужной даты в определенной таблице
        // 
        public bool Table(string TableName, string[] ColumnName, string keyName, string dateName, string dateStart, string dateEnd)
        {
            Word.Application app = null;

            try
            {
                MySqlConnection connection = new MySqlConnection(Const.Const.stroka_parol);

                Const.Const.openConnection(connection);
                //Составление списка подходящих по дате ключей
                List<string> list = new List<string>();
                MySqlCommand command = new MySqlCommand("SELECT " + keyName + " FROM " + TableName + " WHERE " +
                   dateName + " >= '" + dateStart + "' AND " + dateName + "<= '" + dateEnd + "' ;", Const.Const.getConnection(connection));
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(Convert.ToString(reader[0])); //первый столбец ВСЕГДА уникальный ключ (не обязательно поле ключ, но уникальная колонка)
                }///
                Const.Const.closeConnection(connection);



                app = new Word.Application();
                Object file = _fileInfo.FullName; //полный путь к файлу

                Object missing = Type.Missing;

                app.Documents.Open(file);
                Word.Document doc = app.Documents.Add(Visible: true);
                Word.Range range = doc.Range();
                range.Text = "";
                range.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape; // альбомный режим страницы
                Word.Table table = doc.Tables.Add(range, list.Count + 1, ColumnName.Length);//Создаёт таблицу на колчиество людей +1 (для названия колонки) и выбранного числа колонок
                table.Borders.Enable = 1;

                foreach (Word.Column column in table.Columns)
                {
                    foreach (Word.Cell cell in column.Cells)
                    {

                        string findStrCell = "";

                        //заполнение названий колонок
                        if (cell.RowIndex == 1)
                        {
                            cell.Range.Text = ColumnName[cell.ColumnIndex - 1]; // В ячейку на первой строке попадает название соответствующей колонки 

                            cell.Range.Bold = 0; //жирность
                            cell.Range.Font.Name = "IMPACT"; //шрифт
                            cell.Range.Font.Size = 8; //размерность

                            //центровка по центру
                            cell.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        }
                        else
                        {
                            Const.Const.openConnection(connection);

                            command = new MySqlCommand("SELECT " + ColumnName[cell.ColumnIndex - 1] + " FROM " + TableName + " WHERE " + keyName + " = @keys ;", Const.Const.getConnection(connection));
                            command.Parameters.Add("@keys", MySqlDbType.Int32).Value = list[cell.RowIndex - 2];//ячейки должны совпадать со списком ключей 
                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                findStrCell = Convert.ToString(reader[0]);

                            }
                            Const.Const.closeConnection(connection);
                            cell.Range.Text = findStrCell;
                        }
                    }
                }


                Object newFileName = Path.Combine(_fileInfo.DirectoryName, DateTime.Now.ToString("yyyyMMdd HHmmss") + _fileInfo.Name);//созданиие нового имени
                app.ActiveDocument.SaveAs2(newFileName); //сохранение документа под новым именем
                app.ActiveDocument.Close();
                app.Documents.Close(file);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            finally
            {
                if (app != null)
                    app.Quit();
            }
            return false;

        }
        void openFile_in_dock()
        {
            Word.Application app = null;
            try
            {

                app = new Word.Application();
                Object file = _fileInfo.FullName; //полный путь к файлу

                Object missing = Type.Missing;
                Word.Document doc = app.Documents.Add(Template: _fileInfo.FullName);
                app.Visible = true;
            }
            catch
            {
                //ошибка открытия файла
            }

        }

    }
}
