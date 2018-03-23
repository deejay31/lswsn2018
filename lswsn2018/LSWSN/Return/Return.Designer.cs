﻿namespace LSWSN.Return
{
    partial class Return
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.studentId = new System.Windows.Forms.TextBox();
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.gridId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridAccessionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.penaltyFee = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.borrowDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelBook = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.TextBox();
            this.edition = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.accessionNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelBtn.SuspendLayout();
            this.panelBook.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentId
            // 
            this.studentId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentId.Location = new System.Drawing.Point(107, 18);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(292, 25);
            this.studentId.TabIndex = 0;
            this.studentId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.studentId_KeyDown);
            // 
            // myDataGridView
            // 
            this.myDataGridView.AllowUserToAddRows = false;
            this.myDataGridView.AllowUserToDeleteRows = false;
            this.myDataGridView.AllowUserToResizeRows = false;
            this.myDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.myDataGridView.ColumnHeadersHeight = 30;
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.myDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridId,
            this.gridAccessionNo,
            this.gridIsbn,
            this.gridTitle,
            this.issuedate,
            this.duedate,
            this.issueby,
            this.penalty});
            this.myDataGridView.EnableHeadersVisualStyles = false;
            this.myDataGridView.Location = new System.Drawing.Point(8, 266);
            this.myDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myDataGridView.MultiSelect = false;
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.ReadOnly = true;
            this.myDataGridView.RowHeadersVisible = false;
            this.myDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.myDataGridView.RowTemplate.Height = 25;
            this.myDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.myDataGridView.Size = new System.Drawing.Size(863, 222);
            this.myDataGridView.TabIndex = 24;
            this.myDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGridView_CellClick);
            this.myDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.myDataGridView_KeyDown);
            // 
            // gridId
            // 
            this.gridId.HeaderText = "Id";
            this.gridId.Name = "gridId";
            this.gridId.ReadOnly = true;
            this.gridId.Visible = false;
            // 
            // gridAccessionNo
            // 
            this.gridAccessionNo.HeaderText = "Accession No.";
            this.gridAccessionNo.Name = "gridAccessionNo";
            this.gridAccessionNo.ReadOnly = true;
            // 
            // gridIsbn
            // 
            this.gridIsbn.HeaderText = "ISBN";
            this.gridIsbn.Name = "gridIsbn";
            this.gridIsbn.ReadOnly = true;
            this.gridIsbn.Visible = false;
            // 
            // gridTitle
            // 
            this.gridTitle.FillWeight = 170F;
            this.gridTitle.HeaderText = "Title";
            this.gridTitle.Name = "gridTitle";
            this.gridTitle.ReadOnly = true;
            // 
            // issuedate
            // 
            this.issuedate.HeaderText = "Issued Date";
            this.issuedate.Name = "issuedate";
            this.issuedate.ReadOnly = true;
            // 
            // duedate
            // 
            this.duedate.HeaderText = "Due Date";
            this.duedate.Name = "duedate";
            this.duedate.ReadOnly = true;
            // 
            // issueby
            // 
            this.issueby.HeaderText = "Issued By";
            this.issueby.Name = "issueby";
            this.issueby.ReadOnly = true;
            // 
            // penalty
            // 
            this.penalty.HeaderText = "Penalty";
            this.penalty.Name = "penalty";
            this.penalty.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(121)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(449, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(422, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Return Information";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPenalty);
            this.panel2.Controls.Add(this.penaltyFee);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.returnDate);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.borrowDate);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.accountName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(449, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 93);
            this.panel2.TabIndex = 20;
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenalty.ForeColor = System.Drawing.Color.Red;
            this.lblPenalty.Location = new System.Drawing.Point(117, 49);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(88, 17);
            this.lblPenalty.TabIndex = 192;
            this.lblPenalty.Text = "----------------";
            this.lblPenalty.Visible = false;
            // 
            // penaltyFee
            // 
            this.penaltyFee.Enabled = false;
            this.penaltyFee.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyFee.Location = new System.Drawing.Point(120, 19);
            this.penaltyFee.Name = "penaltyFee";
            this.penaltyFee.Size = new System.Drawing.Size(285, 25);
            this.penaltyFee.TabIndex = 190;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(24, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 17);
            this.label14.TabIndex = 191;
            this.label14.Text = "Total Penalty";
            // 
            // returnDate
            // 
            this.returnDate.Enabled = false;
            this.returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.returnDate.Location = new System.Drawing.Point(120, 81);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(285, 25);
            this.returnDate.TabIndex = 2;
            this.returnDate.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(24, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 189;
            this.label12.Text = "Return Date";
            this.label12.Visible = false;
            // 
            // borrowDate
            // 
            this.borrowDate.Enabled = false;
            this.borrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.borrowDate.Location = new System.Drawing.Point(120, 19);
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.Size = new System.Drawing.Size(317, 25);
            this.borrowDate.TabIndex = 0;
            this.borrowDate.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(24, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 187;
            this.label11.Text = "Issue Date";
            this.label11.Visible = false;
            // 
            // accountName
            // 
            this.accountName.Enabled = false;
            this.accountName.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountName.Location = new System.Drawing.Point(120, 50);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(285, 25);
            this.accountName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 185;
            this.label6.Text = "Issue By";
            // 
            // panelBtn
            // 
            this.panelBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBtn.Controls.Add(this.btnRefresh);
            this.panelBtn.Controls.Add(this.btnCancel);
            this.panelBtn.Controls.Add(this.btnSave);
            this.panelBtn.Location = new System.Drawing.Point(596, 493);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(275, 46);
            this.panelBtn.TabIndex = 21;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(121)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(94, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 33);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(121)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(183, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(121)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(9, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 185;
            this.label10.Text = "ID Number";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(121)))));
            this.label17.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(8, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(422, 29);
            this.label17.TabIndex = 22;
            this.label17.Text = "Book Information";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBook
            // 
            this.panelBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBook.Controls.Add(this.category);
            this.panelBook.Controls.Add(this.edition);
            this.panelBook.Controls.Add(this.title);
            this.panelBook.Controls.Add(this.label1);
            this.panelBook.Controls.Add(this.label8);
            this.panelBook.Controls.Add(this.accessionNo);
            this.panelBook.Controls.Add(this.label2);
            this.panelBook.Controls.Add(this.label4);
            this.panelBook.Controls.Add(this.author);
            this.panelBook.Controls.Add(this.label7);
            this.panelBook.Controls.Add(this.isbn);
            this.panelBook.Controls.Add(this.label9);
            this.panelBook.Location = new System.Drawing.Point(8, 36);
            this.panelBook.Name = "panelBook";
            this.panelBook.Size = new System.Drawing.Size(422, 225);
            this.panelBook.TabIndex = 19;
            // 
            // category
            // 
            this.category.Enabled = false;
            this.category.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(107, 81);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(292, 25);
            this.category.TabIndex = 2;
            // 
            // edition
            // 
            this.edition.Enabled = false;
            this.edition.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edition.Location = new System.Drawing.Point(107, 182);
            this.edition.Name = "edition";
            this.edition.Size = new System.Drawing.Size(292, 25);
            this.edition.TabIndex = 5;
            // 
            // title
            // 
            this.title.Enabled = false;
            this.title.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(107, 113);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(292, 25);
            this.title.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 189;
            this.label1.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 187;
            this.label8.Text = "Title";
            // 
            // accessionNo
            // 
            this.accessionNo.Enabled = false;
            this.accessionNo.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessionNo.Location = new System.Drawing.Point(107, 18);
            this.accessionNo.Name = "accessionNo";
            this.accessionNo.Size = new System.Drawing.Size(292, 25);
            this.accessionNo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 185;
            this.label2.Text = "Accession No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 161;
            this.label4.Text = "Edition";
            // 
            // author
            // 
            this.author.Enabled = false;
            this.author.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(107, 147);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(292, 25);
            this.author.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 169;
            this.label7.Text = "Author";
            // 
            // isbn
            // 
            this.isbn.Enabled = false;
            this.isbn.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn.Location = new System.Drawing.Point(107, 49);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(292, 25);
            this.isbn.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(9, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 148;
            this.label9.Text = "ISBN";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.studentId);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(449, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 99);
            this.panel1.TabIndex = 18;
            // 
            // name
            // 
            this.name.Enabled = false;
            this.name.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(107, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(292, 25);
            this.name.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(9, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 148;
            this.label13.Text = "Name";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(57)))), ((int)(((byte)(121)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(449, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Student Information";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 552);
            this.Controls.Add(this.myDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panelBook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBtn.ResumeLayout(false);
            this.panelBook.ResumeLayout(false);
            this.panelBook.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox studentId;
        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DateTimePicker borrowDate;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox accountName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelBook;
        public System.Windows.Forms.TextBox category;
        public System.Windows.Forms.TextBox edition;
        public System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox accessionNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox penaltyFee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAccessionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueby;
        private System.Windows.Forms.DataGridViewTextBoxColumn penalty;
    }
}