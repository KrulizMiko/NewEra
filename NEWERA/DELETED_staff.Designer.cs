namespace NEWERA
{
    partial class DELETED_staff
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
            this.label2 = new System.Windows.Forms.Label();
            this.poka = new System.Windows.Forms.TextBox();
            this.id_client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "УДАЛЕНИЕ СОТРУДНИКА\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Введите ID сотрудника";
            // 
            // poka
            // 
            this.poka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poka.Location = new System.Drawing.Point(17, 109);
            this.poka.Multiline = true;
            this.poka.Name = "poka";
            this.poka.Size = new System.Drawing.Size(148, 39);
            this.poka.TabIndex = 53;
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
            this.id_client.TabIndex = 54;
            this.id_client.Text = "УДАЛИТЬ";
            this.id_client.UseVisualStyleBackColor = false;
            this.id_client.Click += new System.EventHandler(this.id_client_Click);
            // 
            // DELETED_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NEWERA.Properties.Resources.фонъ;
            this.ClientSize = new System.Drawing.Size(414, 466);
            this.Controls.Add(this.id_client);
            this.Controls.Add(this.poka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DELETED_staff";
            this.Text = "DELETED_staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poka;
        private System.Windows.Forms.Button id_client;
    }
}