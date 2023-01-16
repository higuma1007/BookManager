using System.ComponentModel;

namespace BookManager
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bookDataGrid = new System.Windows.Forms.DataGridView();
            this.書名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.著者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.値段DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookDataSet = new BookManager.BookDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.TextBox();
            this.auther = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.MaskedTextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.bookzDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookzDataTableBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bookDataGrid
            // 
            this.bookDataGrid.AllowUserToAddRows = false;
            this.bookDataGrid.AutoGenerateColumns = false;
            this.bookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.書名DataGridViewTextBoxColumn,
            this.著者DataGridViewTextBoxColumn,
            this.値段DataGridViewTextBoxColumn});
            this.bookDataGrid.DataSource = this.bindingSource1;
            this.bookDataGrid.Location = new System.Drawing.Point(12, 34);
            this.bookDataGrid.Name = "bookDataGrid";
            this.bookDataGrid.RowTemplate.Height = 21;
            this.bookDataGrid.Size = new System.Drawing.Size(776, 348);
            this.bookDataGrid.TabIndex = 0;
            // 
            // 書名DataGridViewTextBoxColumn
            // 
            this.書名DataGridViewTextBoxColumn.DataPropertyName = "書名";
            this.書名DataGridViewTextBoxColumn.HeaderText = "書名";
            this.書名DataGridViewTextBoxColumn.Name = "書名DataGridViewTextBoxColumn";
            // 
            // 著者DataGridViewTextBoxColumn
            // 
            this.著者DataGridViewTextBoxColumn.DataPropertyName = "著者";
            this.著者DataGridViewTextBoxColumn.HeaderText = "著者";
            this.著者DataGridViewTextBoxColumn.Name = "著者DataGridViewTextBoxColumn";
            // 
            // 値段DataGridViewTextBoxColumn
            // 
            this.値段DataGridViewTextBoxColumn.DataPropertyName = "値段";
            this.値段DataGridViewTextBoxColumn.HeaderText = "値段";
            this.値段DataGridViewTextBoxColumn.Name = "値段DataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "bookDataTable";
            this.bindingSource1.DataSource = this.bookDataSet;
            // 
            // bookDataSet
            // 
            this.bookDataSet.DataSetName = "BookDataSet";
            this.bookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "署名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "著者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "値段";
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(47, 413);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(257, 19);
            this.bookName.TabIndex = 4;
            // 
            // auther
            // 
            this.auther.Location = new System.Drawing.Point(47, 462);
            this.auther.Name = "auther";
            this.auther.Size = new System.Drawing.Size(257, 19);
            this.auther.TabIndex = 5;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(48, 508);
            this.price.Mask = "00000";
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(256, 19);
            this.price.TabIndex = 6;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(570, 451);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(218, 46);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "削除";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButtonClicked);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(570, 399);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(218, 46);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "登録";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClicked);
            // 
            // bookzDataTableBindingSource
            // 
            this.bookzDataTableBindingSource.DataMember = "bookzDataTable";
            this.bookzDataTableBindingSource.DataSource = this.bookDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(330, 399);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(218, 46);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "CSVファイルへ出力";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(330, 452);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(218, 45);
            this.readButton.TabIndex = 11;
            this.readButton.Text = "CSVファイルから読み込み";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButtonClicked);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "bookDataTable";
            this.bindingSource2.DataSource = this.bookDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.price);
            this.Controls.Add(this.auther);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.TextBox auther;
        private System.Windows.Forms.MaskedTextBox price;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.BindingSource bookzDataTableBindingSource;
        private BookDataSet bookDataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button readButton;
        private ISupportInitialize bookDataTableBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 著者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 値段DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}

