namespace PMDemoTest
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ClientsListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddClientButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.Card = new ClientCard.ClientView();
            this.DeleteClientButton = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientsListBox
            // 
            this.ClientsListBox.FormattingEnabled = true;
            this.ClientsListBox.Location = new System.Drawing.Point(12, 23);
            this.ClientsListBox.Name = "ClientsListBox";
            this.ClientsListBox.Size = new System.Drawing.Size(196, 407);
            this.ClientsListBox.TabIndex = 0;
            this.ClientsListBox.SelectedIndexChanged += new System.EventHandler(this.ClientsListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Card);
            this.panel1.Location = new System.Drawing.Point(207, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 407);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClientButton,
            this.EditButton,
            this.DeleteClientButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddClientButton
            // 
            this.AddClientButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddClientButton.Image = ((System.Drawing.Image)(resources.GetObject("AddClientButton.Image")));
            this.AddClientButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(23, 22);
            this.AddClientButton.Text = "toolStripButton1";
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(23, 22);
            this.EditButton.Text = "Edit";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.White;
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.Location = new System.Drawing.Point(0, 0);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(581, 407);
            this.Card.TabIndex = 0;
            this.Card.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            // 
            // DeleteClientButton
            // 
            this.DeleteClientButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteClientButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteClientButton.Image")));
            this.DeleteClientButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteClientButton.Name = "DeleteClientButton";
            this.DeleteClientButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteClientButton.Text = "toolStripButton1";
            this.DeleteClientButton.Click += new System.EventHandler(this.DeleteClientButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClientsListBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ClientsListBox;
        private System.Windows.Forms.Panel panel1;
        private ClientCard.ClientView Card;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddClientButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteClientButton;
    }
}

