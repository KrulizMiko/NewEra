namespace NEWERA
{
    partial class delete_client
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
            this.id_client = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "УДАЛЕНИЕ КЛИЕНТА";
            // 
            // id_client
            // 
            this.id_client.BackColor = System.Drawing.Color.Red;
            this.id_client.Cursor = System.Windows.Forms.Cursors.Default;
            this.id_client.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.id_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_client.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.id_client.Location = new System.Drawing.Point(270, 405);
            this.id_client.Name = "id_client";
            this.id_client.Size = new System.Drawing.Size(132, 49);
            this.id_client.TabIndex = 48;
            this.id_client.Text = "УДАЛИТЬ";
            this.id_client.UseVisualStyleBackColor = false;
            this.id_client.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Введите ID клиента";
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(17, 121);
            this.del.Multiline = true;
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(148, 39);
            this.del.TabIndex = 52;
            // 
            // delete_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NEWERA.Properties.Resources.фонъ;
            this.ClientSize = new System.Drawing.Size(414, 466);
            this.Controls.Add(this.del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_client);
            this.Controls.Add(this.label1);
            this.Name = "delete_client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "delete_client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button id_client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox del;
    }
}