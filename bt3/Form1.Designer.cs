namespace bt3
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnaddname = new System.Windows.Forms.Button();
            this.btnsuaten = new System.Windows.Forms.Button();
            this.btnaddphone = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnxoaten = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(83, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(367, 207);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Last Name";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "first Name ";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "phone";
            this.columnHeader3.Width = 86;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxoaten);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnaddphone);
            this.groupBox1.Controls.Add(this.btnsuaten);
            this.groupBox1.Controls.Add(this.btnaddname);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.txtfirstname);
            this.groupBox1.Controls.Add(this.txtlastname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(496, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 386);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "phone";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(39, 58);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(189, 20);
            this.txtlastname.TabIndex = 3;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(41, 145);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(188, 20);
            this.txtfirstname.TabIndex = 4;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(41, 231);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(187, 20);
            this.txtphone.TabIndex = 5;
            // 
            // btnaddname
            // 
            this.btnaddname.Location = new System.Drawing.Point(39, 347);
            this.btnaddname.Name = "btnaddname";
            this.btnaddname.Size = new System.Drawing.Size(75, 23);
            this.btnaddname.TabIndex = 6;
            this.btnaddname.Text = "Add Name";
            this.btnaddname.UseVisualStyleBackColor = true;
            this.btnaddname.Click += new System.EventHandler(this.btnaddname_Click);
            // 
            // btnsuaten
            // 
            this.btnsuaten.Location = new System.Drawing.Point(154, 347);
            this.btnsuaten.Name = "btnsuaten";
            this.btnsuaten.Size = new System.Drawing.Size(75, 23);
            this.btnsuaten.TabIndex = 7;
            this.btnsuaten.Text = "SuaTen";
            this.btnsuaten.UseVisualStyleBackColor = true;
            this.btnsuaten.Click += new System.EventHandler(this.btnsuaten_Click);
            // 
            // btnaddphone
            // 
            this.btnaddphone.Location = new System.Drawing.Point(39, 285);
            this.btnaddphone.Name = "btnaddphone";
            this.btnaddphone.Size = new System.Drawing.Size(75, 23);
            this.btnaddphone.TabIndex = 8;
            this.btnaddphone.Text = "Add phone";
            this.btnaddphone.UseVisualStyleBackColor = true;
            this.btnaddphone.Click += new System.EventHandler(this.btnaddphone_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnxoaten
            // 
            this.btnxoaten.Location = new System.Drawing.Point(154, 285);
            this.btnxoaten.Name = "btnxoaten";
            this.btnxoaten.Size = new System.Drawing.Size(75, 23);
            this.btnxoaten.TabIndex = 10;
            this.btnxoaten.Text = "XoaTen";
            this.btnxoaten.UseVisualStyleBackColor = true;
            this.btnxoaten.Click += new System.EventHandler(this.btnxoaten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "listview1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Button btnxoaten;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnaddphone;
        private System.Windows.Forms.Button btnsuaten;
    }
}

