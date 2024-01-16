
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
            this.bookListDataGridView = new System.Windows.Forms.DataGridView();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.bookList_tab = new System.Windows.Forms.TabPage();
            this.setNewBook_tab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.bookList_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookListDataGridView
            // 
            this.bookListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.author,
            this.title});
            this.bookListDataGridView.Location = new System.Drawing.Point(6, 48);
            this.bookListDataGridView.Name = "bookListDataGridView";
            this.bookListDataGridView.RowHeadersWidth = 51;
            this.bookListDataGridView.RowTemplate.Height = 29;
            this.bookListDataGridView.Size = new System.Drawing.Size(756, 339);
            this.bookListDataGridView.TabIndex = 0;
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.author.HeaderText = "Szerző";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.Width = 200;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.title.HeaderText = "Cím";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 503;
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar.Location = new System.Drawing.Point(6, 6);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(756, 36);
            this.searchBar.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.bookList_tab);
            this.tabControl.Controls.Add(this.setNewBook_tab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 426);
            this.tabControl.TabIndex = 2;
            // 
            // bookList_tab
            // 
            this.bookList_tab.Controls.Add(this.searchBar);
            this.bookList_tab.Controls.Add(this.bookListDataGridView);
            this.bookList_tab.Location = new System.Drawing.Point(4, 29);
            this.bookList_tab.Name = "bookList_tab";
            this.bookList_tab.Padding = new System.Windows.Forms.Padding(3);
            this.bookList_tab.Size = new System.Drawing.Size(768, 393);
            this.bookList_tab.TabIndex = 0;
            this.bookList_tab.Text = "Lista";
            this.bookList_tab.UseVisualStyleBackColor = true;
            // 
            // setNewBook_tab
            // 
            this.setNewBook_tab.Location = new System.Drawing.Point(4, 29);
            this.setNewBook_tab.Name = "setNewBook_tab";
            this.setNewBook_tab.Padding = new System.Windows.Forms.Padding(3);
            this.setNewBook_tab.Size = new System.Drawing.Size(768, 393);
            this.setNewBook_tab.TabIndex = 1;
            this.setNewBook_tab.Text = "Könyv felvétel";
            this.setNewBook_tab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.bookList_tab.ResumeLayout(false);
            this.bookList_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookListDataGridView;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage bookList_tab;
        private System.Windows.Forms.TabPage setNewBook_tab;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
    }
}

