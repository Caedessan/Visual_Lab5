namespace Visual_Lab5
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
            this.countrybox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teamnamebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numberbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.heightbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.weightbox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.weightPanel = new System.Windows.Forms.Panel();
            this.w3radiobutton = new System.Windows.Forms.RadioButton();
            this.w2radiobutton = new System.Windows.Forms.RadioButton();
            this.w1radiobutton = new System.Windows.Forms.RadioButton();
            this.heightPanel = new System.Windows.Forms.Panel();
            this.h3radiobutton = new System.Windows.Forms.RadioButton();
            this.h2radiobutton = new System.Windows.Forms.RadioButton();
            this.h1radiobutton = new System.Windows.Forms.RadioButton();
            this.bdPanel = new System.Windows.Forms.Panel();
            this.bd3radiobutton = new System.Windows.Forms.RadioButton();
            this.bd2radiobutton = new System.Windows.Forms.RadioButton();
            this.bd1radiobutton = new System.Windows.Forms.RadioButton();
            this.weightPanel.SuspendLayout();
            this.heightPanel.SuspendLayout();
            this.bdPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // countrybox
            // 
            this.countrybox.Location = new System.Drawing.Point(97, 12);
            this.countrybox.Name = "countrybox";
            this.countrybox.Size = new System.Drawing.Size(160, 23);
            this.countrybox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(97, 41);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(160, 23);
            this.namebox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Team name";
            // 
            // teamnamebox
            // 
            this.teamnamebox.Location = new System.Drawing.Point(97, 70);
            this.teamnamebox.Name = "teamnamebox";
            this.teamnamebox.Size = new System.Drawing.Size(160, 23);
            this.teamnamebox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Height";
            // 
            // numberbox
            // 
            this.numberbox.Location = new System.Drawing.Point(97, 99);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(160, 23);
            this.numberbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birthdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Number";
            // 
            // heightbox
            // 
            this.heightbox.Location = new System.Drawing.Point(97, 158);
            this.heightbox.Name = "heightbox";
            this.heightbox.Size = new System.Drawing.Size(160, 23);
            this.heightbox.TabIndex = 7;
            this.heightbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightbox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Weight";
            // 
            // weightbox
            // 
            this.weightbox.Location = new System.Drawing.Point(97, 188);
            this.weightbox.Name = "weightbox";
            this.weightbox.Size = new System.Drawing.Size(160, 23);
            this.weightbox.TabIndex = 13;
            this.weightbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightbox_KeyPress);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(302, 414);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 15;
            this.save.Text = "Save File";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(302, 385);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 16;
            this.open.Text = "Open File";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(5, 415);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 23);
            this.add.TabIndex = 17;
            this.add.Text = "Add new";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(5, 260);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(108, 23);
            this.filter.TabIndex = 18;
            this.filter.Text = "Filter";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(6, 289);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(108, 23);
            this.delete.TabIndex = 19;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(119, 260);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(138, 81);
            this.apply.TabIndex = 21;
            this.apply.Text = "Apply changes";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.AutoArrange = false;
            this.listView1.Location = new System.Drawing.Point(379, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(238, 426);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 23);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // weightPanel
            // 
            this.weightPanel.Controls.Add(this.w3radiobutton);
            this.weightPanel.Controls.Add(this.w2radiobutton);
            this.weightPanel.Controls.Add(this.w1radiobutton);
            this.weightPanel.Location = new System.Drawing.Point(261, 188);
            this.weightPanel.Name = "weightPanel";
            this.weightPanel.Size = new System.Drawing.Size(116, 23);
            this.weightPanel.TabIndex = 24;
            // 
            // w3radiobutton
            // 
            this.w3radiobutton.AutoSize = true;
            this.w3radiobutton.Location = new System.Drawing.Point(79, 3);
            this.w3radiobutton.Name = "w3radiobutton";
            this.w3radiobutton.Size = new System.Drawing.Size(33, 19);
            this.w3radiobutton.TabIndex = 2;
            this.w3radiobutton.Text = ">";
            this.w3radiobutton.UseVisualStyleBackColor = true;
            // 
            // w2radiobutton
            // 
            this.w2radiobutton.AutoSize = true;
            this.w2radiobutton.Checked = true;
            this.w2radiobutton.Location = new System.Drawing.Point(40, 3);
            this.w2radiobutton.Name = "w2radiobutton";
            this.w2radiobutton.Size = new System.Drawing.Size(33, 19);
            this.w2radiobutton.TabIndex = 1;
            this.w2radiobutton.TabStop = true;
            this.w2radiobutton.Text = "=";
            this.w2radiobutton.UseVisualStyleBackColor = true;
            // 
            // w1radiobutton
            // 
            this.w1radiobutton.AutoSize = true;
            this.w1radiobutton.Location = new System.Drawing.Point(1, 3);
            this.w1radiobutton.Name = "w1radiobutton";
            this.w1radiobutton.Size = new System.Drawing.Size(33, 19);
            this.w1radiobutton.TabIndex = 0;
            this.w1radiobutton.Text = "<";
            this.w1radiobutton.UseVisualStyleBackColor = true;
            // 
            // heightPanel
            // 
            this.heightPanel.Controls.Add(this.h3radiobutton);
            this.heightPanel.Controls.Add(this.h2radiobutton);
            this.heightPanel.Controls.Add(this.h1radiobutton);
            this.heightPanel.Location = new System.Drawing.Point(261, 159);
            this.heightPanel.Name = "heightPanel";
            this.heightPanel.Size = new System.Drawing.Size(116, 23);
            this.heightPanel.TabIndex = 25;
            // 
            // h3radiobutton
            // 
            this.h3radiobutton.AutoSize = true;
            this.h3radiobutton.Location = new System.Drawing.Point(79, 3);
            this.h3radiobutton.Name = "h3radiobutton";
            this.h3radiobutton.Size = new System.Drawing.Size(33, 19);
            this.h3radiobutton.TabIndex = 2;
            this.h3radiobutton.Text = ">";
            this.h3radiobutton.UseVisualStyleBackColor = true;
            // 
            // h2radiobutton
            // 
            this.h2radiobutton.AutoSize = true;
            this.h2radiobutton.Checked = true;
            this.h2radiobutton.Location = new System.Drawing.Point(40, 3);
            this.h2radiobutton.Name = "h2radiobutton";
            this.h2radiobutton.Size = new System.Drawing.Size(33, 19);
            this.h2radiobutton.TabIndex = 1;
            this.h2radiobutton.TabStop = true;
            this.h2radiobutton.Text = "=";
            this.h2radiobutton.UseVisualStyleBackColor = true;
            // 
            // h1radiobutton
            // 
            this.h1radiobutton.AutoSize = true;
            this.h1radiobutton.Location = new System.Drawing.Point(1, 3);
            this.h1radiobutton.Name = "h1radiobutton";
            this.h1radiobutton.Size = new System.Drawing.Size(33, 19);
            this.h1radiobutton.TabIndex = 0;
            this.h1radiobutton.Text = "<";
            this.h1radiobutton.UseVisualStyleBackColor = true;
            // 
            // bdPanel
            // 
            this.bdPanel.Controls.Add(this.bd3radiobutton);
            this.bdPanel.Controls.Add(this.bd2radiobutton);
            this.bdPanel.Controls.Add(this.bd1radiobutton);
            this.bdPanel.Location = new System.Drawing.Point(261, 131);
            this.bdPanel.Name = "bdPanel";
            this.bdPanel.Size = new System.Drawing.Size(116, 23);
            this.bdPanel.TabIndex = 26;
            // 
            // bd3radiobutton
            // 
            this.bd3radiobutton.AutoSize = true;
            this.bd3radiobutton.Location = new System.Drawing.Point(79, 3);
            this.bd3radiobutton.Name = "bd3radiobutton";
            this.bd3radiobutton.Size = new System.Drawing.Size(33, 19);
            this.bd3radiobutton.TabIndex = 2;
            this.bd3radiobutton.Text = ">";
            this.bd3radiobutton.UseVisualStyleBackColor = true;
            // 
            // bd2radiobutton
            // 
            this.bd2radiobutton.AutoSize = true;
            this.bd2radiobutton.Checked = true;
            this.bd2radiobutton.Location = new System.Drawing.Point(40, 3);
            this.bd2radiobutton.Name = "bd2radiobutton";
            this.bd2radiobutton.Size = new System.Drawing.Size(33, 19);
            this.bd2radiobutton.TabIndex = 1;
            this.bd2radiobutton.TabStop = true;
            this.bd2radiobutton.Text = "=";
            this.bd2radiobutton.UseVisualStyleBackColor = true;
            // 
            // bd1radiobutton
            // 
            this.bd1radiobutton.AutoSize = true;
            this.bd1radiobutton.Location = new System.Drawing.Point(1, 3);
            this.bd1radiobutton.Name = "bd1radiobutton";
            this.bd1radiobutton.Size = new System.Drawing.Size(33, 19);
            this.bd1radiobutton.TabIndex = 0;
            this.bd1radiobutton.Text = "<";
            this.bd1radiobutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.bdPanel);
            this.Controls.Add(this.heightPanel);
            this.Controls.Add(this.weightPanel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.add);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.weightbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.heightbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teamnamebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countrybox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.weightPanel.ResumeLayout(false);
            this.weightPanel.PerformLayout();
            this.heightPanel.ResumeLayout(false);
            this.heightPanel.PerformLayout();
            this.bdPanel.ResumeLayout(false);
            this.bdPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox countrybox;
        private Label label1;
        private Label label2;
        private TextBox namebox;
        private Label label3;
        private TextBox teamnamebox;
        private Label label4;
        private TextBox numberbox;
        private Label label5;
        private Label label6;
        private TextBox heightbox;
        private Label label7;
        private TextBox weightbox;
        private Button save;
        private Button open;
        private Button add;
        private Button filter;
        private Button delete;
        private Button apply;
        private ListView listView1;
        private DateTimePicker dateTimePicker1;
        private Panel weightPanel;
        private RadioButton w3radiobutton;
        private RadioButton w2radiobutton;
        private RadioButton w1radiobutton;
        private Panel heightPanel;
        private RadioButton h3radiobutton;
        private RadioButton h2radiobutton;
        private RadioButton h1radiobutton;
        private Panel bdPanel;
        private RadioButton bd3radiobutton;
        private RadioButton bd2radiobutton;
        private RadioButton bd1radiobutton;
    }
}