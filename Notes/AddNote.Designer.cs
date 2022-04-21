namespace Notes
{
    partial class AddNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNote = new System.Windows.Forms.RichTextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.counterLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.counterLabel);
            this.panel1.Controls.Add(this.nameNote);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textNote);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Create);
            this.panel1.Location = new System.Drawing.Point(-2, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 482);
            this.panel1.TabIndex = 0;
            // 
            // nameNote
            // 
            this.nameNote.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.nameNote.Location = new System.Drawing.Point(177, 18);
            this.nameNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameNote.Name = "nameNote";
            this.nameNote.Size = new System.Drawing.Size(194, 21);
            this.nameNote.TabIndex = 5;
            this.nameNote.Click += new System.EventHandler(this.nameNote_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(133, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите текст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите название";
            // 
            // textNote
            // 
            this.textNote.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.textNote.Location = new System.Drawing.Point(22, 60);
            this.textNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(349, 229);
            this.textNote.TabIndex = 2;
            this.textNote.Text = "";
            this.textNote.TextChanged += new System.EventHandler(this.textNote_TextChanged);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.Cancel.Location = new System.Drawing.Point(233, 295);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(139, 47);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Отменить";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.Create.Location = new System.Drawing.Point(22, 295);
            this.Create.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(204, 47);
            this.Create.TabIndex = 0;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.counterLabel.Location = new System.Drawing.Point(111, 277);
            this.counterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(180, 15);
            this.counterLabel.TabIndex = 6;
            this.counterLabel.Text = "Символов в тексте 0 и 0 слов";
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 349);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddNote";
            this.Text = "Добавить заметку";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textNote;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label counterLabel;
    }
}