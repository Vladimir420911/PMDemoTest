namespace PMDemoTest
{
    partial class EditClientForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.ClientPictureBox = new System.Windows.Forms.PictureBox();
            this.ChoosePictureButton = new System.Windows.Forms.Button();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PictureFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Фото";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Имя";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(173, 355);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 36);
            this.CancelButton.TabIndex = 33;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(54, 355);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 36);
            this.OkButton.TabIndex = 32;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ClientPictureBox
            // 
            this.ClientPictureBox.Location = new System.Drawing.Point(139, 32);
            this.ClientPictureBox.Name = "ClientPictureBox";
            this.ClientPictureBox.Size = new System.Drawing.Size(151, 141);
            this.ClientPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClientPictureBox.TabIndex = 31;
            this.ClientPictureBox.TabStop = false;
            // 
            // ChoosePictureButton
            // 
            this.ChoosePictureButton.Location = new System.Drawing.Point(157, 204);
            this.ChoosePictureButton.Name = "ChoosePictureButton";
            this.ChoosePictureButton.Size = new System.Drawing.Size(91, 32);
            this.ChoosePictureButton.TabIndex = 30;
            this.ChoosePictureButton.Text = "Выбрать фото";
            this.ChoosePictureButton.UseVisualStyleBackColor = true;
            this.ChoosePictureButton.Click += new System.EventHandler(this.ChoosePictureButton_Click);
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(12, 153);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(100, 20);
            this.MailTextBox.TabIndex = 29;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(12, 90);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneTextBox.TabIndex = 28;
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(12, 204);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.DescriptionRichTextBox.TabIndex = 27;
            this.DescriptionRichTextBox.Text = "";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 32);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 26;
            // 
            // PictureFileDialog
            // 
            this.PictureFileDialog.FileName = "openFileDialog1";
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ClientPictureBox);
            this.Controls.Add(this.ChoosePictureButton);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.DescriptionRichTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "EditClientForm";
            this.Text = "EditClientForm";
            this.Load += new System.EventHandler(this.EditClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.PictureBox ClientPictureBox;
        private System.Windows.Forms.Button ChoosePictureButton;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.RichTextBox DescriptionRichTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.OpenFileDialog PictureFileDialog;
    }
}