using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class AddNote : Form
    {
        public AddNote()
        {
            InitializeComponent();
            nameNote.Text = "Заметка №" + (DataNotes.CountNote() + 1);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if(textNote.Text != "")
            {
                DataNotes.CreateNewNoteWithText(nameNote.Text, textNote.Text);
            }
            else
            {
                DataNotes.CreateNewNote(nameNote.Text);
            }
            this.Close();
        }

        private void textNote_TextChanged(object sender, EventArgs e)
        {
            counterLabel.Text = $"Символов в тексте {countSymbols(textNote.Text)} и {countWords(textNote.Text)} слов";
        }

        private int countSymbols(string text)//Подсчет символов в заметке
        {
            int countS = 0;
            foreach (char c in text)
            {
                if (c != ' ') countS++;
            }
            return countS;
        }
        private int countWords(string text)
        {
            int countW = 0;
            char lastChar = ' ';
            foreach (char c in text+' ')
            {
                if (c == ' ' && lastChar != ' ')
                {
                    countW++;
                }
                lastChar = c;
            }
            return countW;
        }

        private void nameNote_Click(object sender, EventArgs e)
        {
            nameNote.Text = "";
        }
    }
}
