
namespace Book
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bookListDataGridView = new System.Windows.Forms.DataGridView();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.bookList_tab = new System.Windows.Forms.TabPage();
            this.setNewBook_tab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.modifyBook_tab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonModify = new System.Windows.Forms.Button();
            this.textBoxPagesOp = new System.Windows.Forms.TextBox();
            this.textBoxTitleOp = new System.Windows.Forms.TextBox();
            this.textBoxGenreOp = new System.Windows.Forms.TextBox();
            this.textBoxAuthorOp = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.bookList_tab.SuspendLayout();
            this.setNewBook_tab.SuspendLayout();
            this.modifyBook_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookListDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author,
            this.Title,
            this.Genre,
            this.Pages,
            this.OpButton});
            this.bookListDataGridView.Location = new System.Drawing.Point(5, 36);
            this.bookListDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookListDataGridView.Name = "bookListDataGridView";
            this.bookListDataGridView.RowHeadersWidth = 51;
            this.bookListDataGridView.RowTemplate.Height = 29;
            this.bookListDataGridView.Size = new System.Drawing.Size(874, 395);
            this.bookListDataGridView.TabIndex = 0;
            this.bookListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookListDataGridView_CellContentClick);
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Author.DataPropertyName = "Author";
            this.Author.FillWeight = 3F;
            this.Author.HeaderText = "Szerző";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            // 
            // Genre
            // 
            this.Genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Genre.DataPropertyName = "Genre";
            this.Genre.FillWeight = 3F;
            this.Genre.HeaderText = "Műfaj";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 3F;
            this.Title.HeaderText = "Cím";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            // 
            // Pages
            // 
            this.Pages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pages.DataPropertyName = "Pages";
            this.Pages.FillWeight = 1F;
            this.Pages.HeaderText = "Oldal";
            this.Pages.MinimumWidth = 6;
            this.Pages.Name = "Pages";
            // 
            // OpButton
            // 
            this.OpButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OpButton.FillWeight = 2F;
            this.OpButton.HeaderText = "Műveletek";
            this.OpButton.MinimumWidth = 6;
            this.OpButton.Name = "OpButton";
            this.OpButton.Text = "Kiválaszt";
            this.OpButton.UseColumnTextForButtonValue = true;
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar.Location = new System.Drawing.Point(5, 0);
            this.searchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(874, 31);
            this.searchBar.TabIndex = 1;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            this.searchBar.Enter += new System.EventHandler(this.searchBar_Enter);
            this.searchBar.Leave += new System.EventHandler(this.searchBar_Leave);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.bookList_tab);
            this.tabControl.Controls.Add(this.setNewBook_tab);
            this.tabControl.Controls.Add(this.modifyBook_tab);
            this.tabControl.Location = new System.Drawing.Point(10, 9);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(887, 455);
            this.tabControl.TabIndex = 2;
            // 
            // bookList_tab
            // 
            this.bookList_tab.Controls.Add(this.searchBar);
            this.bookList_tab.Controls.Add(this.bookListDataGridView);
            this.bookList_tab.Location = new System.Drawing.Point(4, 24);
            this.bookList_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookList_tab.Name = "bookList_tab";
            this.bookList_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookList_tab.Size = new System.Drawing.Size(879, 427);
            this.bookList_tab.TabIndex = 0;
            this.bookList_tab.Text = "Lista";
            this.bookList_tab.UseVisualStyleBackColor = true;
            // 
            // setNewBook_tab
            // 
            this.setNewBook_tab.Controls.Add(this.label4);
            this.setNewBook_tab.Controls.Add(this.label3);
            this.setNewBook_tab.Controls.Add(this.label2);
            this.setNewBook_tab.Controls.Add(this.label1);
            this.setNewBook_tab.Controls.Add(this.textBoxTitle);
            this.setNewBook_tab.Controls.Add(this.buttonAddBook);
            this.setNewBook_tab.Controls.Add(this.textBoxAuthor);
            this.setNewBook_tab.Controls.Add(this.textBoxGenre);
            this.setNewBook_tab.Controls.Add(this.textBoxPages);
            this.setNewBook_tab.Location = new System.Drawing.Point(4, 24);
            this.setNewBook_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setNewBook_tab.Name = "setNewBook_tab";
            this.setNewBook_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setNewBook_tab.Size = new System.Drawing.Size(879, 427);
            this.setNewBook_tab.TabIndex = 1;
            this.setNewBook_tab.Text = "Könyv felvétel";
            this.setNewBook_tab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Oldalszám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Szerző";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Műfaj";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Könyv címe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(20, 116);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(265, 23);
            this.textBoxTitle.TabIndex = 4;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(19, 336);
            this.buttonAddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(265, 66);
            this.buttonAddBook.TabIndex = 3;
            this.buttonAddBook.Text = "Felvétel";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(20, 17);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(264, 23);
            this.textBoxAuthor.TabIndex = 2;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(20, 68);
            this.textBoxGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(264, 23);
            this.textBoxGenre.TabIndex = 1;
            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(20, 165);
            this.textBoxPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(265, 23);
            this.textBoxPages.TabIndex = 0;
            // 
            // modifyBook_tab
            // 
            this.modifyBook_tab.Controls.Add(this.label5);
            this.modifyBook_tab.Controls.Add(this.label6);
            this.modifyBook_tab.Controls.Add(this.label7);
            this.modifyBook_tab.Controls.Add(this.label8);
            this.modifyBook_tab.Controls.Add(this.buttonModify);
            this.modifyBook_tab.Controls.Add(this.textBoxPagesOp);
            this.modifyBook_tab.Controls.Add(this.textBoxTitleOp);
            this.modifyBook_tab.Controls.Add(this.textBoxGenreOp);
            this.modifyBook_tab.Controls.Add(this.textBoxAuthorOp);
            this.modifyBook_tab.Controls.Add(this.buttonDelete);
            this.modifyBook_tab.Location = new System.Drawing.Point(4, 24);
            this.modifyBook_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyBook_tab.Name = "modifyBook_tab";
            this.modifyBook_tab.Size = new System.Drawing.Size(879, 427);
            this.modifyBook_tab.TabIndex = 2;
            this.modifyBook_tab.Text = "Műveletek";
            this.modifyBook_tab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Oldalszám";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Szerző";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Műfaj";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Könyv címe";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(23, 340);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(270, 64);
            this.buttonModify.TabIndex = 5;
            this.buttonModify.Text = "Módosítás";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // textBoxPagesOp
            // 
            this.textBoxPagesOp.Location = new System.Drawing.Point(23, 150);
            this.textBoxPagesOp.Name = "textBoxPagesOp";
            this.textBoxPagesOp.Size = new System.Drawing.Size(270, 23);
            this.textBoxPagesOp.TabIndex = 4;
            // 
            // textBoxTitleOp
            // 
            this.textBoxTitleOp.Location = new System.Drawing.Point(23, 106);
            this.textBoxTitleOp.Name = "textBoxTitleOp";
            this.textBoxTitleOp.Size = new System.Drawing.Size(270, 23);
            this.textBoxTitleOp.TabIndex = 3;
            // 
            // textBoxGenreOp
            // 
            this.textBoxGenreOp.Location = new System.Drawing.Point(23, 58);
            this.textBoxGenreOp.Name = "textBoxGenreOp";
            this.textBoxGenreOp.Size = new System.Drawing.Size(270, 23);
            this.textBoxGenreOp.TabIndex = 2;
            // 
            // textBoxAuthorOp
            // 
            this.textBoxAuthorOp.Location = new System.Drawing.Point(23, 15);
            this.textBoxAuthorOp.Name = "textBoxAuthorOp";
            this.textBoxAuthorOp.Size = new System.Drawing.Size(270, 23);
            this.textBoxAuthorOp.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(718, 340);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 64);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Könyv törlése";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 475);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "KonyvTar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.bookList_tab.ResumeLayout(false);
            this.bookList_tab.PerformLayout();
            this.setNewBook_tab.ResumeLayout(false);
            this.setNewBook_tab.PerformLayout();
            this.modifyBook_tab.ResumeLayout(false);
            this.modifyBook_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookListDataGridView;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage bookList_tab;
        private System.Windows.Forms.TabPage setNewBook_tab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.DataGridViewButtonColumn OpButton;
        private System.Windows.Forms.TabPage modifyBook_tab;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.TextBox textBoxPagesOp;
        private System.Windows.Forms.TextBox textBoxTitleOp;
        private System.Windows.Forms.TextBox textBoxGenreOp;
        private System.Windows.Forms.TextBox textBoxAuthorOp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

