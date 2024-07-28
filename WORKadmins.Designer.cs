namespace NEWERA
{
    partial class WORKadmins
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "РАБОТА ПЕРСОНАЛА /АДМИНА";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_work,
            this.id_staff,
            this.id_client,
            this.id_status,
            this.pack,
            this.SUMa,
            this.Dates});
            this.dataGridView1.Location = new System.Drawing.Point(39, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 258);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_work
            // 
            this.id_work.DataPropertyName = "id_works";
            this.id_work.HeaderText = "Номер транкзации";
            this.id_work.Name = "id_work";
            // 
            // id_staff
            // 
            this.id_staff.DataPropertyName = "id_ staff";
            this.id_staff.HeaderText = "Номер сотрудника";
            this.id_staff.Name = "id_staff";
            // 
            // id_client
            // 
            this.id_client.DataPropertyName = "id_client";
            this.id_client.HeaderText = "Номер клиента";
            this.id_client.Name = "id_client";
            // 
            // id_status
            // 
            this.id_status.DataPropertyName = "id_status";
            this.id_status.HeaderText = "Номер статуса";
            this.id_status.Name = "id_status";
            // 
            // pack
            // 
            this.pack.DataPropertyName = "pack";
            this.pack.HeaderText = "Сеанс клиента";
            this.pack.Name = "pack";
            // 
            // SUMa
            // 
            this.SUMa.DataPropertyName = "SUMa";
            this.SUMa.HeaderText = "Покупка сеанса";
            this.SUMa.Name = "SUMa";
            // 
            // Dates
            // 
            this.Dates.DataPropertyName = "Dates";
            this.Dates.HeaderText = "Дата транкзации";
            this.Dates.Name = "Dates";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.Cursor = System.Windows.Forms.Cursors.Default;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(12, 500);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 49);
            this.button7.TabIndex = 46;
            this.button7.Text = "НАЗАД";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(605, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 53);
            this.button1.TabIndex = 47;
            this.button1.Text = "УЧЕТ РАБОТЫ СОТРУДНИКОВ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(12, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 49);
            this.button2.TabIndex = 48;
            this.button2.Text = "СЕНАС ЗА ДЕНЬ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(12, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 49);
            this.button3.TabIndex = 49;
            this.button3.Text = "КТО БОЛЬШЕ ПОТРАТИЛ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(160, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 49);
            this.button4.TabIndex = 50;
            this.button4.Text = "НЕПОПУЛЯРНЫЙ СТАТУС";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(356, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 49);
            this.button5.TabIndex = 51;
            this.button5.Text = "НЕПОПУЛЯРНЫЙ ПАКЕТ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(161, 401);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 49);
            this.button6.TabIndex = 52;
            this.button6.Text = "УЧЕТ ПОСЕЩАЕМОСТИ\r\n";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.Cursor = System.Windows.Forms.Cursors.Default;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(366, 392);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 49);
            this.button8.TabIndex = 53;
            this.button8.Text = "ПОДОРОЖИЕ УСЛУГ";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.Cursor = System.Windows.Forms.Cursors.Default;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(303, 496);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(132, 49);
            this.button9.TabIndex = 54;
            this.button9.Text = "ОБНОВИТЬ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // WORKadmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NEWERA.Properties.Resources.фонъ;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "WORKadmins";
            this.Text = "WORKadmins";
            this.Load += new System.EventHandler(this.WORKadmins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_work;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn pack;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dates;
        private System.Windows.Forms.Button button9;
    }
}