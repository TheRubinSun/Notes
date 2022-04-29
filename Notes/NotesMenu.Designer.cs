namespace Notes
{
    partial class NotesMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSizeFont = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.sizeFont = new System.Windows.Forms.ComboBox();
            this.fontName = new System.Windows.Forms.ComboBox();
            this.counterLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deletAll = new System.Windows.Forms.Button();
            this.saveNoteButton = new System.Windows.Forms.Button();
            this.loadNoteButton = new System.Windows.Forms.Button();
            this.deleteNoteButton = new System.Windows.Forms.Button();
            this.createNotesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChangeFont = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameNoteEditBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.editNameButton = new System.Windows.Forms.Button();
            this.listNotes = new System.Windows.Forms.ListView();
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textNoteMenu = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сведенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.labelSizeFont);
            this.panel1.Controls.Add(this.labelFont);
            this.panel1.Controls.Add(this.sizeFont);
            this.panel1.Controls.Add(this.fontName);
            this.panel1.Controls.Add(this.counterLabel);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textNoteMenu);
            this.panel1.Controls.Add(this.menuStrip);
            this.panel1.Location = new System.Drawing.Point(-9, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 625);
            this.panel1.TabIndex = 0;
            // 
            // labelSizeFont
            // 
            this.labelSizeFont.AutoSize = true;
            this.labelSizeFont.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSizeFont.Location = new System.Drawing.Point(233, 30);
            this.labelSizeFont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSizeFont.Name = "labelSizeFont";
            this.labelSizeFont.Size = new System.Drawing.Size(52, 15);
            this.labelSizeFont.TabIndex = 9;
            this.labelSizeFont.Text = "Размер";
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFont.Location = new System.Drawing.Point(22, 30);
            this.labelFont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(50, 15);
            this.labelFont.TabIndex = 3;
            this.labelFont.Text = "Шрифт";
            // 
            // sizeFont
            // 
            this.sizeFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeFont.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeFont.FormattingEnabled = true;
            this.sizeFont.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "16",
            "20",
            "28",
            "32",
            "60"});
            this.sizeFont.Location = new System.Drawing.Point(292, 27);
            this.sizeFont.Name = "sizeFont";
            this.sizeFont.Size = new System.Drawing.Size(76, 23);
            this.sizeFont.TabIndex = 8;
            this.sizeFont.SelectedIndexChanged += new System.EventHandler(this.sizeFont_SelectedIndexChanged);
            // 
            // fontName
            // 
            this.fontName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontName.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontName.FormattingEnabled = true;
            this.fontName.Items.AddRange(new object[] {
            "Arial Narrow",
            "Impact",
            "Montserrat SemiBold",
            "Pacifico",
            "Times New Roman"});
            this.fontName.Location = new System.Drawing.Point(79, 27);
            this.fontName.Name = "fontName";
            this.fontName.Size = new System.Drawing.Size(147, 23);
            this.fontName.Sorted = true;
            this.fontName.TabIndex = 7;
            this.fontName.SelectedIndexChanged += new System.EventHandler(this.fontName_SelectedIndexChanged);
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.Location = new System.Drawing.Point(113, 501);
            this.counterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(180, 15);
            this.counterLabel.TabIndex = 5;
            this.counterLabel.Text = "Символов в тексте 0 и 0 слов";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel4.Controls.Add(this.deletAll);
            this.panel4.Controls.Add(this.saveNoteButton);
            this.panel4.Controls.Add(this.loadNoteButton);
            this.panel4.Controls.Add(this.deleteNoteButton);
            this.panel4.Controls.Add(this.createNotesButton);
            this.panel4.Location = new System.Drawing.Point(12, 521);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(729, 88);
            this.panel4.TabIndex = 4;
            // 
            // deletAll
            // 
            this.deletAll.BackColor = System.Drawing.Color.LightCoral;
            this.deletAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletAll.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletAll.Location = new System.Drawing.Point(252, 47);
            this.deletAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletAll.Name = "deletAll";
            this.deletAll.Size = new System.Drawing.Size(134, 30);
            this.deletAll.TabIndex = 8;
            this.deletAll.Text = "Удалить всё";
            this.deletAll.UseVisualStyleBackColor = false;
            this.deletAll.Click += new System.EventHandler(this.deletAll_Click);
            // 
            // saveNoteButton
            // 
            this.saveNoteButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.saveNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNoteButton.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNoteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveNoteButton.Location = new System.Drawing.Point(137, 11);
            this.saveNoteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveNoteButton.Name = "saveNoteButton";
            this.saveNoteButton.Size = new System.Drawing.Size(107, 66);
            this.saveNoteButton.TabIndex = 5;
            this.saveNoteButton.Text = "Сохранить";
            this.saveNoteButton.UseVisualStyleBackColor = false;
            this.saveNoteButton.Click += new System.EventHandler(this.saveNoteButton_Click);
            // 
            // loadNoteButton
            // 
            this.loadNoteButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.loadNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadNoteButton.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadNoteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadNoteButton.Location = new System.Drawing.Point(23, 11);
            this.loadNoteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadNoteButton.Name = "loadNoteButton";
            this.loadNoteButton.Size = new System.Drawing.Size(107, 66);
            this.loadNoteButton.TabIndex = 6;
            this.loadNoteButton.Text = "Загрузить ";
            this.loadNoteButton.UseVisualStyleBackColor = false;
            this.loadNoteButton.Click += new System.EventHandler(this.loadNoteButton_Click);
            // 
            // deleteNoteButton
            // 
            this.deleteNoteButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteNoteButton.Enabled = false;
            this.deleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNoteButton.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNoteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteNoteButton.Location = new System.Drawing.Point(252, 11);
            this.deleteNoteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteNoteButton.Name = "deleteNoteButton";
            this.deleteNoteButton.Size = new System.Drawing.Size(134, 36);
            this.deleteNoteButton.TabIndex = 7;
            this.deleteNoteButton.Text = "Удалить";
            this.deleteNoteButton.UseVisualStyleBackColor = false;
            this.deleteNoteButton.Click += new System.EventHandler(this.deleteNoteButton_Click);
            // 
            // createNotesButton
            // 
            this.createNotesButton.BackColor = System.Drawing.Color.LimeGreen;
            this.createNotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNotesButton.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNotesButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createNotesButton.Location = new System.Drawing.Point(394, 11);
            this.createNotesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createNotesButton.Name = "createNotesButton";
            this.createNotesButton.Size = new System.Drawing.Size(318, 66);
            this.createNotesButton.TabIndex = 4;
            this.createNotesButton.Text = "Создать новую";
            this.createNotesButton.UseVisualStyleBackColor = false;
            this.createNotesButton.Click += new System.EventHandler(this.createNotesButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.ChangeFont);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.listNotes);
            this.panel2.Location = new System.Drawing.Point(393, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 609);
            this.panel2.TabIndex = 1;
            // 
            // ChangeFont
            // 
            this.ChangeFont.BackColor = System.Drawing.Color.Black;
            this.ChangeFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeFont.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ChangeFont.Location = new System.Drawing.Point(288, 3);
            this.ChangeFont.Name = "ChangeFont";
            this.ChangeFont.Size = new System.Drawing.Size(23, 29);
            this.ChangeFont.TabIndex = 3;
            this.ChangeFont.Text = "Font";
            this.ChangeFont.UseVisualStyleBackColor = false;
            this.ChangeFont.Click += new System.EventHandler(this.ChangeFont_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.nameNoteEditBox);
            this.panel3.Controls.Add(this.labelName);
            this.panel3.Controls.Add(this.editNameButton);
            this.panel3.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(10, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 69);
            this.panel3.TabIndex = 1;
            // 
            // nameNoteEditBox
            // 
            this.nameNoteEditBox.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameNoteEditBox.Location = new System.Drawing.Point(11, 31);
            this.nameNoteEditBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameNoteEditBox.Name = "nameNoteEditBox";
            this.nameNoteEditBox.Size = new System.Drawing.Size(199, 21);
            this.nameNoteEditBox.TabIndex = 2;
            this.nameNoteEditBox.TextChanged += new System.EventHandler(this.nameNoteEditBox_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(66, 3);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(119, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название заметки";
            // 
            // editNameButton
            // 
            this.editNameButton.Enabled = false;
            this.editNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editNameButton.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editNameButton.Location = new System.Drawing.Point(218, 23);
            this.editNameButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editNameButton.Name = "editNameButton";
            this.editNameButton.Size = new System.Drawing.Size(96, 37);
            this.editNameButton.TabIndex = 0;
            this.editNameButton.Text = "Изменить";
            this.editNameButton.UseVisualStyleBackColor = true;
            this.editNameButton.Click += new System.EventHandler(this.editNameButton_Click);
            // 
            // listNotes
            // 
            this.listNotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.data,
            this.name});
            this.listNotes.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNotes.FullRowSelect = true;
            this.listNotes.HideSelection = false;
            this.listNotes.Location = new System.Drawing.Point(11, 93);
            this.listNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listNotes.MultiSelect = false;
            this.listNotes.Name = "listNotes";
            this.listNotes.Size = new System.Drawing.Size(318, 423);
            this.listNotes.TabIndex = 0;
            this.listNotes.UseCompatibleStateImageBehavior = false;
            this.listNotes.View = System.Windows.Forms.View.Details;
            this.listNotes.Click += new System.EventHandler(this.listNotes_Click);
            // 
            // data
            // 
            this.data.Text = "Дата записи";
            this.data.Width = 114;
            // 
            // name
            // 
            this.name.Text = "Название";
            this.name.Width = 153;
            // 
            // textNoteMenu
            // 
            this.textNoteMenu.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.textNoteMenu.Location = new System.Drawing.Point(23, 57);
            this.textNoteMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNoteMenu.Name = "textNoteMenu";
            this.textNoteMenu.Size = new System.Drawing.Size(362, 442);
            this.textNoteMenu.TabIndex = 2;
            this.textNoteMenu.Text = "";
            this.textNoteMenu.TextChanged += new System.EventHandler(this.textNote_TextChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.параметрыToolStripMenuItem,
            this.сведенияToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(794, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.открытьToolStripMenuItem1,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть как...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem1.Text = "Загрузить с корня";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьШрифтToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // изменитьШрифтToolStripMenuItem
            // 
            this.изменитьШрифтToolStripMenuItem.Name = "изменитьШрифтToolStripMenuItem";
            this.изменитьШрифтToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.изменитьШрифтToolStripMenuItem.Text = "Изменить шрифт программы";
            this.изменитьШрифтToolStripMenuItem.Click += new System.EventHandler(this.изменитьШрифтToolStripMenuItem_Click);
            // 
            // сведенияToolStripMenuItem
            // 
            this.сведенияToolStripMenuItem.Name = "сведенияToolStripMenuItem";
            this.сведенияToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.сведенияToolStripMenuItem.Text = "Справка";
            this.сведенияToolStripMenuItem.Click += new System.EventHandler(this.сведенияToolStripMenuItem_Click);
            // 
            // NotesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(722, 611);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Pacifico", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NotesMenu";
            this.Text = "Заметки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NotesMenu_FormClosed);
            this.Load += new System.EventHandler(this.NotesM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listNotes;
        private System.Windows.Forms.RichTextBox textNoteMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox nameNoteEditBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button editNameButton;
        private System.Windows.Forms.Button deleteNoteButton;
        private System.Windows.Forms.Button loadNoteButton;
        private System.Windows.Forms.Button saveNoteButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button createNotesButton;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Button ChangeFont;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьШрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сведенияToolStripMenuItem;
        private System.Windows.Forms.ComboBox fontName;
        private System.Windows.Forms.ComboBox sizeFont;
        private System.Windows.Forms.Label labelSizeFont;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.Button deletAll;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
    }
}

