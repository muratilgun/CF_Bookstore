namespace CF_Bookstore.UI
{
    partial class FormDashboard
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
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxBook = new System.Windows.Forms.GroupBox();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.dtpPublDate = new System.Windows.Forms.DateTimePicker();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTotalPages = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnGetAllBook = new System.Windows.Forms.Button();
            this.btnListModifiedBook = new System.Windows.Forms.Button();
            this.btnPassiveListBook = new System.Windows.Forms.Button();
            this.btnActiveListBook = new System.Windows.Forms.Button();
            this.gbxFindByTitle = new System.Windows.Forms.GroupBox();
            this.txtFindByTitle = new System.Windows.Forms.TextBox();
            this.gbxBookOpr = new System.Windows.Forms.GroupBox();
            this.gbxAuthor = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnUpdateAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.btnListPassiveAuthors = new System.Windows.Forms.Button();
            this.btnListActiveAuthors = new System.Windows.Forms.Button();
            this.btnGetAllAuthor = new System.Windows.Forms.Button();
            this.gbxFindByName = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbBookList = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbxBookAuthor = new System.Windows.Forms.GroupBox();
            this.cmbAuthorList = new System.Windows.Forms.ComboBox();
            this.btnActiveBookAuthors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbxBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gbxFindByTitle.SuspendLayout();
            this.gbxBookOpr.SuspendLayout();
            this.gbxAuthor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxFindByName.SuspendLayout();
            this.gbxBookAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::CF_Bookstore.UI.Properties.Resources.power_32;
            this.btnExit.Location = new System.Drawing.Point(1134, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 67);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CF_Bookstore.UI.Properties.Resources.books_512;
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 67);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "B◐◑kst◕re";
            // 
            // gbxBook
            // 
            this.gbxBook.BackColor = System.Drawing.Color.White;
            this.gbxBook.Controls.Add(this.cmbAuthor);
            this.gbxBook.Controls.Add(this.nudRating);
            this.gbxBook.Controls.Add(this.dtpPublDate);
            this.gbxBook.Controls.Add(this.txtPublisher);
            this.gbxBook.Controls.Add(this.txtGenre);
            this.gbxBook.Controls.Add(this.txtISBN);
            this.gbxBook.Controls.Add(this.txtTotalPages);
            this.gbxBook.Controls.Add(this.txtBookTitle);
            this.gbxBook.Controls.Add(this.txtBookId);
            this.gbxBook.Controls.Add(this.label8);
            this.gbxBook.Controls.Add(this.label7);
            this.gbxBook.Controls.Add(this.label16);
            this.gbxBook.Controls.Add(this.label6);
            this.gbxBook.Controls.Add(this.label5);
            this.gbxBook.Controls.Add(this.label4);
            this.gbxBook.Controls.Add(this.label3);
            this.gbxBook.Controls.Add(this.label1);
            this.gbxBook.Controls.Add(this.label9);
            this.gbxBook.Location = new System.Drawing.Point(11, 65);
            this.gbxBook.Name = "gbxBook";
            this.gbxBook.Size = new System.Drawing.Size(296, 375);
            this.gbxBook.TabIndex = 4;
            this.gbxBook.TabStop = false;
            this.gbxBook.Text = "Book";
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(112, 197);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(174, 27);
            this.cmbAuthor.TabIndex = 4;
            // 
            // dtpPublDate
            // 
            this.dtpPublDate.CalendarFont = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Bold);
            this.dtpPublDate.Font = new System.Drawing.Font("NewsGoth BT", 10F, System.Drawing.FontStyle.Bold);
            this.dtpPublDate.Location = new System.Drawing.Point(112, 311);
            this.dtpPublDate.Name = "dtpPublDate";
            this.dtpPublDate.Size = new System.Drawing.Size(174, 23);
            this.dtpPublDate.TabIndex = 2;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(112, 272);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(174, 27);
            this.txtPublisher.TabIndex = 1;
            this.txtPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(112, 236);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(174, 27);
            this.txtGenre.TabIndex = 1;
            this.txtGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(6, 26);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(129, 31);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(112, 164);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(174, 27);
            this.txtISBN.TabIndex = 1;
            this.txtISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalPages
            // 
            this.txtTotalPages.Location = new System.Drawing.Point(112, 92);
            this.txtTotalPages.Name = "txtTotalPages";
            this.txtTotalPages.Size = new System.Drawing.Size(174, 27);
            this.txtTotalPages.TabIndex = 1;
            this.txtTotalPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(112, 56);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(174, 27);
            this.txtBookTitle.TabIndex = 1;
            this.txtBookTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(112, 20);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(174, 27);
            this.txtBookId.TabIndex = 1;
            this.txtBookId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "ISBN NO :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Author :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 314);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Publ. Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Publisher :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Pages :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Id :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Genre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rating :";
            // 
            // nudRating
            // 
            this.nudRating.DecimalPlaces = 1;
            this.nudRating.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudRating.Location = new System.Drawing.Point(112, 129);
            this.nudRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(174, 27);
            this.nudRating.TabIndex = 3;
            this.nudRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(6, 63);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(129, 31);
            this.btnUpdateBook.TabIndex = 2;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.Red;
            this.btnDeleteBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBook.Location = new System.Drawing.Point(6, 100);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(129, 31);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(11, 434);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1177, 274);
            this.dataGridView.TabIndex = 5;
            // 
            // btnGetAllBook
            // 
            this.btnGetAllBook.Location = new System.Drawing.Point(6, 242);
            this.btnGetAllBook.Name = "btnGetAllBook";
            this.btnGetAllBook.Size = new System.Drawing.Size(129, 29);
            this.btnGetAllBook.TabIndex = 7;
            this.btnGetAllBook.Text = "List All Books";
            this.btnGetAllBook.UseVisualStyleBackColor = true;
            // 
            // btnListModifiedBook
            // 
            this.btnListModifiedBook.Location = new System.Drawing.Point(6, 207);
            this.btnListModifiedBook.Name = "btnListModifiedBook";
            this.btnListModifiedBook.Size = new System.Drawing.Size(129, 29);
            this.btnListModifiedBook.TabIndex = 8;
            this.btnListModifiedBook.Text = "List Modified Books";
            this.btnListModifiedBook.UseVisualStyleBackColor = true;
            // 
            // btnPassiveListBook
            // 
            this.btnPassiveListBook.Location = new System.Drawing.Point(6, 172);
            this.btnPassiveListBook.Name = "btnPassiveListBook";
            this.btnPassiveListBook.Size = new System.Drawing.Size(129, 29);
            this.btnPassiveListBook.TabIndex = 9;
            this.btnPassiveListBook.Text = "List Passive Books";
            this.btnPassiveListBook.UseVisualStyleBackColor = true;
            // 
            // btnActiveListBook
            // 
            this.btnActiveListBook.BackColor = System.Drawing.Color.ForestGreen;
            this.btnActiveListBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnActiveListBook.FlatAppearance.BorderSize = 0;
            this.btnActiveListBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActiveListBook.ForeColor = System.Drawing.Color.White;
            this.btnActiveListBook.Location = new System.Drawing.Point(6, 137);
            this.btnActiveListBook.Name = "btnActiveListBook";
            this.btnActiveListBook.Size = new System.Drawing.Size(129, 29);
            this.btnActiveListBook.TabIndex = 10;
            this.btnActiveListBook.Text = "List Active Books";
            this.btnActiveListBook.UseVisualStyleBackColor = false;
            // 
            // gbxFindByTitle
            // 
            this.gbxFindByTitle.Controls.Add(this.txtFindByTitle);
            this.gbxFindByTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbxFindByTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbxFindByTitle.Location = new System.Drawing.Point(6, 277);
            this.gbxFindByTitle.Name = "gbxFindByTitle";
            this.gbxFindByTitle.Size = new System.Drawing.Size(129, 66);
            this.gbxFindByTitle.TabIndex = 11;
            this.gbxFindByTitle.TabStop = false;
            this.gbxFindByTitle.Text = "Find By Title";
            // 
            // txtFindByTitle
            // 
            this.txtFindByTitle.Location = new System.Drawing.Point(6, 26);
            this.txtFindByTitle.Name = "txtFindByTitle";
            this.txtFindByTitle.Size = new System.Drawing.Size(117, 27);
            this.txtFindByTitle.TabIndex = 1;
            this.txtFindByTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbxBookOpr
            // 
            this.gbxBookOpr.Controls.Add(this.btnAddBook);
            this.gbxBookOpr.Controls.Add(this.gbxFindByTitle);
            this.gbxBookOpr.Controls.Add(this.btnDeleteBook);
            this.gbxBookOpr.Controls.Add(this.btnGetAllBook);
            this.gbxBookOpr.Controls.Add(this.btnUpdateBook);
            this.gbxBookOpr.Controls.Add(this.btnListModifiedBook);
            this.gbxBookOpr.Controls.Add(this.btnActiveListBook);
            this.gbxBookOpr.Controls.Add(this.btnPassiveListBook);
            this.gbxBookOpr.Location = new System.Drawing.Point(313, 65);
            this.gbxBookOpr.Name = "gbxBookOpr";
            this.gbxBookOpr.Size = new System.Drawing.Size(142, 375);
            this.gbxBookOpr.TabIndex = 12;
            this.gbxBookOpr.TabStop = false;
            this.gbxBookOpr.Text = "Book Operations";
            // 
            // gbxAuthor
            // 
            this.gbxAuthor.Controls.Add(this.txtAuthorId);
            this.gbxAuthor.Controls.Add(this.label10);
            this.gbxAuthor.Controls.Add(this.lblLastName);
            this.gbxAuthor.Controls.Add(this.lblMiddleName);
            this.gbxAuthor.Controls.Add(this.lblFirstName);
            this.gbxAuthor.Controls.Add(this.txtLastName);
            this.gbxAuthor.Controls.Add(this.txtMiddleName);
            this.gbxAuthor.Controls.Add(this.txtFirstName);
            this.gbxAuthor.Location = new System.Drawing.Point(569, 65);
            this.gbxAuthor.Name = "gbxAuthor";
            this.gbxAuthor.Size = new System.Drawing.Size(307, 156);
            this.gbxAuthor.TabIndex = 13;
            this.gbxAuthor.TabStop = false;
            this.gbxAuthor.Text = "Author";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(25, 125);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(93, 19);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name :";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(6, 92);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(112, 19);
            this.lblMiddleName.TabIndex = 1;
            this.lblMiddleName.Text = "Middle Name :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(23, 59);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(95, 19);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(124, 122);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(171, 27);
            this.txtLastName.TabIndex = 0;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(124, 89);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(171, 27);
            this.txtMiddleName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(124, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(171, 27);
            this.txtFirstName.TabIndex = 0;
            // 
            // btnUpdateAuthor
            // 
            this.btnUpdateAuthor.Location = new System.Drawing.Point(6, 71);
            this.btnUpdateAuthor.Name = "btnUpdateAuthor";
            this.btnUpdateAuthor.Size = new System.Drawing.Size(139, 31);
            this.btnUpdateAuthor.TabIndex = 2;
            this.btnUpdateAuthor.Text = "Update Author";
            this.btnUpdateAuthor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAuthor.FlatAppearance.BorderSize = 0;
            this.btnDeleteAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAuthor.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(6, 108);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(139, 31);
            this.btnDeleteAuthor.TabIndex = 2;
            this.btnDeleteAuthor.Text = "Delete Author";
            this.btnDeleteAuthor.UseVisualStyleBackColor = false;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(6, 34);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(139, 31);
            this.btnAddAuthor.TabIndex = 2;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateAuthor);
            this.groupBox1.Controls.Add(this.btnDeleteAuthor);
            this.groupBox1.Controls.Add(this.btnAddAuthor);
            this.groupBox1.Controls.Add(this.btnGetAllAuthor);
            this.groupBox1.Controls.Add(this.btnListActiveAuthors);
            this.groupBox1.Controls.Add(this.btnListPassiveAuthors);
            this.groupBox1.Location = new System.Drawing.Point(886, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 156);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Author Operations";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(461, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(102, 440);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(461, 292);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(739, 18);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Author Id :";
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(124, 20);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(171, 27);
            this.txtAuthorId.TabIndex = 3;
            // 
            // btnListPassiveAuthors
            // 
            this.btnListPassiveAuthors.Location = new System.Drawing.Point(151, 71);
            this.btnListPassiveAuthors.Name = "btnListPassiveAuthors";
            this.btnListPassiveAuthors.Size = new System.Drawing.Size(129, 29);
            this.btnListPassiveAuthors.TabIndex = 9;
            this.btnListPassiveAuthors.Text = "List Passive Books";
            this.btnListPassiveAuthors.UseVisualStyleBackColor = true;
            // 
            // btnListActiveAuthors
            // 
            this.btnListActiveAuthors.BackColor = System.Drawing.Color.ForestGreen;
            this.btnListActiveAuthors.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListActiveAuthors.FlatAppearance.BorderSize = 0;
            this.btnListActiveAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListActiveAuthors.ForeColor = System.Drawing.Color.White;
            this.btnListActiveAuthors.Location = new System.Drawing.Point(151, 36);
            this.btnListActiveAuthors.Name = "btnListActiveAuthors";
            this.btnListActiveAuthors.Size = new System.Drawing.Size(129, 29);
            this.btnListActiveAuthors.TabIndex = 10;
            this.btnListActiveAuthors.Text = "List Active Books";
            this.btnListActiveAuthors.UseVisualStyleBackColor = false;
            // 
            // btnGetAllAuthor
            // 
            this.btnGetAllAuthor.Location = new System.Drawing.Point(151, 110);
            this.btnGetAllAuthor.Name = "btnGetAllAuthor";
            this.btnGetAllAuthor.Size = new System.Drawing.Size(129, 29);
            this.btnGetAllAuthor.TabIndex = 7;
            this.btnGetAllAuthor.Text = "List All Authors";
            this.btnGetAllAuthor.UseVisualStyleBackColor = true;
            // 
            // gbxFindByName
            // 
            this.gbxFindByName.Controls.Add(this.textBox1);
            this.gbxFindByName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbxFindByName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbxFindByName.Location = new System.Drawing.Point(569, 227);
            this.gbxFindByName.Name = "gbxFindByName";
            this.gbxFindByName.Size = new System.Drawing.Size(619, 66);
            this.gbxFindByName.TabIndex = 11;
            this.gbxFindByName.TabStop = false;
            this.gbxFindByName.Text = "Find By Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(607, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbBookList
            // 
            this.cmbBookList.FormattingEnabled = true;
            this.cmbBookList.Location = new System.Drawing.Point(10, 43);
            this.cmbBookList.Name = "cmbBookList";
            this.cmbBookList.Size = new System.Drawing.Size(205, 27);
            this.cmbBookList.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(468, 19);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(129, 27);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "Books";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Authors";
            // 
            // gbxBookAuthor
            // 
            this.gbxBookAuthor.Controls.Add(this.label12);
            this.gbxBookAuthor.Controls.Add(this.label11);
            this.gbxBookAuthor.Controls.Add(this.btnSubmit);
            this.gbxBookAuthor.Controls.Add(this.cmbAuthorList);
            this.gbxBookAuthor.Controls.Add(this.btnActiveBookAuthors);
            this.gbxBookAuthor.Controls.Add(this.cmbBookList);
            this.gbxBookAuthor.Location = new System.Drawing.Point(569, 316);
            this.gbxBookAuthor.Name = "gbxBookAuthor";
            this.gbxBookAuthor.Size = new System.Drawing.Size(619, 124);
            this.gbxBookAuthor.TabIndex = 15;
            this.gbxBookAuthor.TabStop = false;
            this.gbxBookAuthor.Text = "Book Author";
            // 
            // cmbAuthorList
            // 
            this.cmbAuthorList.FormattingEnabled = true;
            this.cmbAuthorList.Location = new System.Drawing.Point(240, 43);
            this.cmbAuthorList.Name = "cmbAuthorList";
            this.cmbAuthorList.Size = new System.Drawing.Size(205, 27);
            this.cmbAuthorList.TabIndex = 1;
            // 
            // btnActiveBookAuthors
            // 
            this.btnActiveBookAuthors.BackColor = System.Drawing.Color.ForestGreen;
            this.btnActiveBookAuthors.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnActiveBookAuthors.FlatAppearance.BorderSize = 0;
            this.btnActiveBookAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActiveBookAuthors.ForeColor = System.Drawing.Color.White;
            this.btnActiveBookAuthors.Location = new System.Drawing.Point(468, 53);
            this.btnActiveBookAuthors.Name = "btnActiveBookAuthors";
            this.btnActiveBookAuthors.Size = new System.Drawing.Size(129, 29);
            this.btnActiveBookAuthors.TabIndex = 10;
            this.btnActiveBookAuthors.Text = "List Active Books";
            this.btnActiveBookAuthors.UseVisualStyleBackColor = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.gbxFindByName);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxBook);
            this.Controls.Add(this.gbxBookOpr);
            this.Controls.Add(this.gbxAuthor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBookAuthor);
            this.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxBook.ResumeLayout(false);
            this.gbxBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gbxFindByTitle.ResumeLayout(false);
            this.gbxFindByTitle.PerformLayout();
            this.gbxBookOpr.ResumeLayout(false);
            this.gbxAuthor.ResumeLayout(false);
            this.gbxAuthor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbxFindByName.ResumeLayout(false);
            this.gbxFindByName.PerformLayout();
            this.gbxBookAuthor.ResumeLayout(false);
            this.gbxBookAuthor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxBook;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.DateTimePicker dtpPublDate;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTotalPages;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnGetAllBook;
        private System.Windows.Forms.Button btnListModifiedBook;
        private System.Windows.Forms.Button btnPassiveListBook;
        private System.Windows.Forms.Button btnActiveListBook;
        private System.Windows.Forms.GroupBox gbxFindByTitle;
        private System.Windows.Forms.TextBox txtFindByTitle;
        private System.Windows.Forms.GroupBox gbxBookOpr;
        private System.Windows.Forms.GroupBox gbxAuthor;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnUpdateAuthor;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetAllAuthor;
        private System.Windows.Forms.Button btnListActiveAuthors;
        private System.Windows.Forms.Button btnListPassiveAuthors;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox gbxFindByName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbBookList;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbxBookAuthor;
        private System.Windows.Forms.ComboBox cmbAuthorList;
        private System.Windows.Forms.Button btnActiveBookAuthors;
    }
}