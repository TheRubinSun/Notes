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
namespace Notes
{
    public partial class NotesMenu : Form
    {
        int curIdNote = -1;
        FontConverter fC = new FontConverter(); //Шрифт конвертер

        public NotesMenu()
        {
            InitializeComponent();
            OpenFile();
            UpdateDisplay();
            CheckCurIdForEnable();//Актевировать или деактивировать компоненты от ситуации
        }
        
        private void NotesM_Load(object sender, EventArgs e)
        {

        }

        private void createNotesButton_Click(object sender, EventArgs e)
        {
            AddNote addNote = new AddNote();
            addNote.ShowDialog();//Обновить таблицу записей
            UpdateDisplay();
        }

        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            DataNotes.RemoveNote(curIdNote);
            UpdateDisplay();//Обновить таблицу записей
            curIdNote = -1; //Обнулить id
            CheckCurIdForEnable();
        }

        private void loadNoteButton_Click(object sender, EventArgs e)
        {
            OpenFile();
            UpdateDisplay();
        }

        private void saveNoteButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void editNameButton_Click(object sender, EventArgs e)
        {
            DataNotes.SetName(curIdNote, nameNoteEditBox.Text);
            UpdateDisplay();
        }

        private void textNote_TextChanged(object sender, EventArgs e)
        {
            if (curIdNote != -1)
            {
                DataNotes.SetText(curIdNote, textNoteMenu.Text);
                counterLabel.Text = $"Символов в тексте {DataNotes.GetCountSymbols(curIdNote)} и {DataNotes.GetCountWords(curIdNote)} слов";
            }
            else
            {
                if(DataNotes.CountNote() == 0 && textNoteMenu.Text!="")
                {
                    DataNotes.CreateNewNote("Заметка №" + (DataNotes.CountNote() + 1));
                    curIdNote = 0;
                    sizeFont.Text = DataNotes.GetSizeFont(curIdNote).ToString();//В граф размера вводим размер из объета
                    fontName.Text = DataNotes.GetFont(curIdNote);//В граф шрифт вводим шрифт из объета
                    nameNoteEditBox.Text = DataNotes.GetName(curIdNote);
                    DataNotes.SetText(curIdNote, textNoteMenu.Text);
                    CheckCurIdForEnable();
                }
                counterLabel.Text = "Символов в тексте 0 и 0 слов";
            }
            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            listNotes.Items.Clear();
            ListViewItem updatedListNotes;
            for(int i = 0;i < DataNotes.CountNote();i++)
            {
                updatedListNotes = new ListViewItem(DataNotes.GetData(i));
                updatedListNotes.SubItems.Add(DataNotes.GetName(i));
                listNotes.Items.Add(updatedListNotes);
            }
        }

        private void listNotes_Click(object sender, EventArgs e)
        {
            string selectedData = listNotes.SelectedItems[0].SubItems[0].Text; //Получаем дату из выделенного объекта
            string selectedName = listNotes.SelectedItems[0].SubItems[1].Text; //Получаем название из выделенного объекта
            
            curIdNote = DataNotes.ReturnIdOfNameAndData(selectedData, selectedName); //Находим id объекта
            textNoteMenu.Text = DataNotes.GetText(curIdNote);                //Текст заметки в область текста

            nameNoteEditBox.Text = DataNotes.GetName(curIdNote);         //Названия заметки в поле для редактирования

            textNoteMenu.Font = fC.ConvertFromString($"{DataNotes.GetFont(curIdNote)}; {DataNotes.GetSizeFont(curIdNote)}pt") as Font;//Подставляем шрифт объекта заметки
            sizeFont.Text = DataNotes.GetSizeFont(curIdNote).ToString();//В граф размера вводим размер из объета
            fontName.Text = DataNotes.GetFont(curIdNote);//В граф шрифт вводим шрифт из объета

            CheckCurIdForEnable();
        }

        private void listNotes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Console.WriteLine("Zad");
        }

        private void nameNoteEditBox_TextChanged(object sender, EventArgs e)
        {
            //Если название заметки пользователь изменил, тогда кнопка становится активной 
            if(nameNoteEditBox.Text != DataNotes.GetName(curIdNote)) editNameButton.Enabled = true;
            else editNameButton.Enabled = false;

        }

        void CheckCurIdForEnable()
        {
            if (curIdNote != -1)
            {
                deleteNoteButton.Enabled = true;
                nameNoteEditBox.Enabled = true;
                //textNoteMenu.Enabled = true;
                sizeFont.Enabled = true;
                fontName.Enabled = true;
            }
            else
            {
                deleteNoteButton.Enabled = false;
                nameNoteEditBox.Enabled = false;

                textNoteMenu.Text = "";
                //textNoteMenu.Enabled = false;

                sizeFont.Enabled = false;
                fontName.Enabled = false;
            }
        }


        private void ChangeFont_Click(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void изменитьШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        bool styleActive = false;
        void ChangeFontStyle()
        {
            if (styleActive == false)
            {
                labelName.Font = new Font("Pacifico", 9, FontStyle.Italic);
                counterLabel.Font = new Font("Pacifico", 9, FontStyle.Italic);
                nameNoteEditBox.Font = new Font("Pacifico", 9, FontStyle.Italic);
                editNameButton.Font = new Font("Pacifico", 9, FontStyle.Italic);
                listNotes.Font = new Font("Pacifico", 9, FontStyle.Italic);
                loadNoteButton.Font = new Font("Pacifico", 9, FontStyle.Italic);
                saveNoteButton.Font = new Font("Pacifico", 9, FontStyle.Italic);
                deleteNoteButton.Font = new Font("Pacifico", 9, FontStyle.Italic);
                createNotesButton.Font = new Font("Pacifico", 9, FontStyle.Italic);
                labelFont.Font = new Font("Pacifico", 9, FontStyle.Italic);
                labelSizeFont.Font = new Font("Pacifico", 9, FontStyle.Italic);

                ChangeFont.BackColor = Color.Red;
                styleActive = true;
            }
            else
            {
                labelName.Font = new Font("Montserrat SemiBold", 8, FontStyle.Bold);
                counterLabel.Font = new Font("Montserrat SemiBold", 8, FontStyle.Bold);
                nameNoteEditBox.Font = new Font("Montserrat SemiBold", 8, FontStyle.Bold);
                editNameButton.Font = new Font("Montserrat SemiBold", 8, FontStyle.Bold);
                listNotes.Font = new Font("Montserrat SemiBold", 8, FontStyle.Bold);
                loadNoteButton.Font = new Font("Montserrat SemiBold", 8, FontStyle.Bold);
                saveNoteButton.Font = new Font("Montserrat SemiBold", 8, FontStyle.Bold);
                deleteNoteButton.Font = new Font("Montserrat SemiBold", 8, FontStyle.Bold);
                createNotesButton.Font = new Font("Montserrat SemiBold", 8, FontStyle.Bold);
                labelFont.Font = new Font("Montserrat SemiBold", 8, FontStyle.Bold);
                labelSizeFont.Font = new Font("Montserrat SemiBold", 8, FontStyle.Bold);

                ChangeFont.BackColor = Color.Black;
                styleActive = false;
            }
        }

        private void сведенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoApp infoApp =  new InfoApp();
            infoApp.ShowDialog();
        }


        //Изменить размер шрифта
        private void sizeFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataNotes.SetSizeFont(curIdNote, int.Parse(sizeFont.Text)); //Обновление размера шрифта
            Font font1 = fC.ConvertFromString($"{DataNotes.GetFont(curIdNote)}; {DataNotes.GetSizeFont(curIdNote)}pt") as Font;
            textNoteMenu.Font = font1;
        }
        //Изменить шрифт
        private void fontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataNotes.SetFont(curIdNote, fontName.Text);
            Font font1 = fC.ConvertFromString($"{DataNotes.GetFont(curIdNote)}; {DataNotes.GetSizeFont(curIdNote)}pt") as Font;
            textNoteMenu.Font = font1;
        }

        string saveName = "\\SaveNotes.txt";
        void SaveFile()
        {
            string location1 = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path1 = Path.GetDirectoryName(location1) + "\\SaveFilesNotes";
            if(!(Directory.Exists(path1)))
            {
                Directory.CreateDirectory(path1);
            }
            string save = "";
            for(int i = 0;i<DataNotes.CountNote();i++)
            {
                save+=DataNotes.GetName(i)+"\n";
                save += DataNotes.GetData(i) + "\n";
                save += DataNotes.GetFont(i) + "\n";
                save += DataNotes.GetSizeFont(i) + "\n";
                //save += DataNotes.GetText(i) + "\n";
                SaveAllText(DataNotes.GetName(i),path1,i); //Сохраняем тексты в отдельный файл
            }
            //File.WriteAllText(path1, save);
            try
            {
                using (StreamWriter sw = new StreamWriter(path1+saveName,false,Encoding.Default))
                {
                    sw.Write(save);
                    sw.Close();
                }
            }
            catch
            {

            }
        }
        void SaveAllText(string nameFile,string path,int id)
        {
            string location1 = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path2 = path + "\\TextFolder";
            if (!(Directory.Exists(path2)))
            {
                Directory.CreateDirectory(path2);
            }
            string saveText = DataNotes.GetText(id);
            try
            {
                using (StreamWriter sw2 = new StreamWriter(path2 +"\\"+nameFile+".txt", false, Encoding.Default))
                {
                    sw2.Write(saveText);
                    sw2.Close();
                }
            }
            catch
            {

            }
        }
        void OpenFile()
        {
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path1 = Path.GetDirectoryName(location) + "\\SaveFilesNotes" + saveName;
            string path2 = Path.GetDirectoryName(location) + "\\SaveFilesNotes\\TextFolder\\";
            if (File.Exists(path1))
            {
                string name = "";
                string data = "";
                string font = "";
                int sizeFont = 0;
                string text = "";

                int countLines = 0;
                string[] readText = File.ReadAllLines(path1);
                foreach(string s in readText)
                {
                    countLines++;
                }
                StreamReader file = new StreamReader(path1,Encoding.Default);
                while(countLines > 0)
                {
                    name = file.ReadLine();
                    data = file.ReadLine();
                    font = file.ReadLine();
                    sizeFont = int.Parse(file.ReadLine());
                    StreamReader file2 = new StreamReader(path2 + (name + ".txt"), Encoding.Default);
                    text = file2.ReadToEnd();
                    DataNotes.CreateNewWholeNote(name, data, font, sizeFont, text);
                    countLines-=4;
                    file2.Close();
                }
                file.Close();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void deletAll_Click(object sender, EventArgs e)
        {
            DataNotes.RemoveAll();
            UpdateDisplay();//Обновить таблицу записей
            curIdNote = -1; //Обнулить id
            CheckCurIdForEnable();
        }

        private void NotesMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveFile();
        }
    }
}
class Note
{
    public string name { get; set; }
    public string data { get; }

    public string font { get; set; }
    public int sizeFont { get; set; }
    public string text { get; set; }
    public Note(string name)
    {
        this.name = name;
        this.font = "Montserrat SemiBold";
        this.sizeFont = 10;
        data = DateTime.Now.ToString();
    }
    public Note(string name, string text)
    {
        this.name = name;
        this.text = text;
        this.font = "Montserrat SemiBold";
        this.sizeFont = 10;
        data = DateTime.Now.ToString();
    }
    public Note(string name,string data,string font,int sizeFont,string text)
    {
        this.name = name;
        this.data = data;
        this.text = text;
        this.font = font;
        this.sizeFont = sizeFont;
    }

    public int countSymbols()//Подсчет символов в заметке
    {
        int countS = 0;
        foreach(char c in text)
        {
            if (c != ' ') countS++;
        }
        return countS;
    }
    public int countWords()//Подсчет слов в заметке
    {
        int countW = 0;
        char lastChar = ' ';
        foreach(char c in text+' ')
        {
            if(c == ' ' && lastChar != ' ')
            {
                countW++;
            }
            lastChar = c;
        }
        return countW;
    }
}
class DataNotes
{
    static List<Note> notes = new List<Note>();
    public static void CreateNewNote(string name)
    {
        notes.Add(new Note(name));
    }
    public static void CreateNewNoteWithText(string name, string text)
    {
        notes.Add(new Note(name, text));
    }
    public static void CreateNewWholeNote(string name, string data, string font, int sizeFont, string text)
    {
        notes.Add(new Note(name, data, font, sizeFont, text));
    }
    public static void RemoveNote(int id)
    {
        notes.Remove(notes[id]);
    }

    public static void RemoveAll()
    {
        notes.Clear();
    }

    public static string GetName(int id) { return notes[id].name; }
    public static string SetName(int id, string _name) { notes[id].name = _name; return ""; }

    public static string GetData(int id) { return notes[id].data; }

    public static string GetText(int id) { return notes[id].text; }
    public static string SetText(int id, string _text) { notes[id].text = _text; return ""; }

    public static string GetFont(int id) { return notes[id].font; }
    public static string SetFont(int id,string _font) { notes[id].font = _font;return ""; }

    public static int GetSizeFont(int id) { return notes[id].sizeFont; }
    public static int SetSizeFont(int id, int _size) { notes[id].sizeFont = _size; return 0; }

    public static int GetCountSymbols(int id) { return notes[id].countSymbols(); }//Подсчет символов в заметке
    public static int GetCountWords(int id) { return notes[id].countWords(); }//Подсчет слов в заметке

    public static int CountNote() { return notes.Count(); }

    public static int ReturnIdOfNameAndData(string data, string name)
    {
        int id = 0;
        foreach(Note note in notes)
        {
            if (data != note.data && name != note.name)
            {
                id++;
            }
            else break;
        }
        return id;
    }
}