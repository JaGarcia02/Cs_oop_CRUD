namespace CRUD_oop
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
            groupBox1 = new GroupBox();
            btn_create = new Button();
            c_address = new TextBox();
            c_mobile = new TextBox();
            c_name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_delete = new Button();
            btn_update = new Button();
            lb_ID = new Label();
            u_address = new TextBox();
            u_mobile = new TextBox();
            u_name = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_create);
            groupBox1.Controls.Add(c_address);
            groupBox1.Controls.Add(c_mobile);
            groupBox1.Controls.Add(c_name);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 190);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create";
            // 
            // btn_create
            // 
            btn_create.BackColor = Color.SpringGreen;
            btn_create.Location = new Point(74, 158);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(75, 23);
            btn_create.TabIndex = 6;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // c_address
            // 
            c_address.Location = new Point(74, 108);
            c_address.Multiline = true;
            c_address.Name = "c_address";
            c_address.Size = new Size(249, 39);
            c_address.TabIndex = 5;
            // 
            // c_mobile
            // 
            c_mobile.Location = new Point(74, 75);
            c_mobile.Name = "c_mobile";
            c_mobile.Size = new Size(249, 23);
            c_mobile.TabIndex = 4;
            // 
            // c_name
            // 
            c_name.Location = new Point(74, 43);
            c_name.Name = "c_name";
            c_name.Size = new Size(249, 23);
            c_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 111);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 78);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Mobile:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Full name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_delete);
            groupBox2.Controls.Add(btn_update);
            groupBox2.Controls.Add(lb_ID);
            groupBox2.Controls.Add(u_address);
            groupBox2.Controls.Add(u_mobile);
            groupBox2.Controls.Add(u_name);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(347, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 190);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update/Delete";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Salmon;
            btn_delete.Location = new Point(248, 158);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Yellow;
            btn_update.Location = new Point(74, 158);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 7;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // lb_ID
            // 
            lb_ID.AutoSize = true;
            lb_ID.Location = new Point(301, 19);
            lb_ID.Name = "lb_ID";
            lb_ID.Size = new Size(18, 15);
            lb_ID.TabIndex = 12;
            lb_ID.Text = "ID";
            // 
            // u_address
            // 
            u_address.Location = new Point(74, 105);
            u_address.Multiline = true;
            u_address.Name = "u_address";
            u_address.Size = new Size(249, 42);
            u_address.TabIndex = 11;
            // 
            // u_mobile
            // 
            u_mobile.Location = new Point(74, 72);
            u_mobile.Name = "u_mobile";
            u_mobile.Size = new Size(249, 23);
            u_mobile.TabIndex = 10;
            // 
            // u_name
            // 
            u_name.Location = new Point(74, 40);
            u_name.Name = "u_name";
            u_name.Size = new Size(249, 23);
            u_name.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 108);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 8;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 75);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 7;
            label5.Text = "Mobile:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 43);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 6;
            label6.Text = "Full name:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(12, 208);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(664, 230);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Read/View Data";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(652, 202);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox c_address;
        private TextBox c_mobile;
        private TextBox c_name;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lb_ID;
        private TextBox u_address;
        private TextBox u_mobile;
        private TextBox u_name;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Button btn_create;
        private Button btn_delete;
        private Button btn_update;
    }
}