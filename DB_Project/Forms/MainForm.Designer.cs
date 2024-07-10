namespace DB_Project
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
            this.components = new System.ComponentModel.Container();
            this.dataPlotter = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.traitsPanel = new System.Windows.Forms.Panel();
            this.textBoxProp = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.photoPanel = new System.Windows.Forms.Panel();
            this.pictureBoxPlotter = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPlotter = new System.Windows.Forms.Button();
            this.buttonCreator = new System.Windows.Forms.Button();
            this.buttonType = new System.Windows.Forms.Button();
            this.buttonValue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxInfo = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.searchForName_button = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutProgrammMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlotter)).BeginInit();
            this.traitsPanel.SuspendLayout();
            this.photoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlotter)).BeginInit();
            this.adminPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPlotter
            // 
            this.dataPlotter.AllowUserToAddRows = false;
            this.dataPlotter.AllowUserToDeleteRows = false;
            this.dataPlotter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataPlotter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataPlotter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPlotter.Location = new System.Drawing.Point(166, 20);
            this.dataPlotter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataPlotter.Name = "dataPlotter";
            this.dataPlotter.ReadOnly = true;
            this.dataPlotter.RowHeadersWidth = 51;
            this.dataPlotter.RowTemplate.Height = 24;
            this.dataPlotter.Size = new System.Drawing.Size(672, 171);
            this.dataPlotter.TabIndex = 0;
            this.dataPlotter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPlotter_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Описание";
            // 
            // traitsPanel
            // 
            this.traitsPanel.Controls.Add(this.textBoxProp);
            this.traitsPanel.Controls.Add(this.label1);
            this.traitsPanel.Location = new System.Drawing.Point(606, 202);
            this.traitsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.traitsPanel.Name = "traitsPanel";
            this.traitsPanel.Size = new System.Drawing.Size(242, 167);
            this.traitsPanel.TabIndex = 4;
            // 
            // textBoxProp
            // 
            this.textBoxProp.Location = new System.Drawing.Point(4, 21);
            this.textBoxProp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProp.Name = "textBoxProp";
            this.textBoxProp.ReadOnly = true;
            this.textBoxProp.Size = new System.Drawing.Size(230, 132);
            this.textBoxProp.TabIndex = 3;
            this.textBoxProp.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Свойства";
            // 
            // photoPanel
            // 
            this.photoPanel.Controls.Add(this.pictureBoxPlotter);
            this.photoPanel.Controls.Add(this.label2);
            this.photoPanel.Location = new System.Drawing.Point(8, 172);
            this.photoPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.photoPanel.Name = "photoPanel";
            this.photoPanel.Size = new System.Drawing.Size(148, 197);
            this.photoPanel.TabIndex = 4;
            // 
            // pictureBoxPlotter
            // 
            this.pictureBoxPlotter.Location = new System.Drawing.Point(2, 24);
            this.pictureBoxPlotter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxPlotter.Name = "pictureBoxPlotter";
            this.pictureBoxPlotter.Size = new System.Drawing.Size(143, 170);
            this.pictureBoxPlotter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlotter.TabIndex = 3;
            this.pictureBoxPlotter.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фото";
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.buttonUpdate);
            this.adminPanel.Controls.Add(this.buttonAdd);
            this.adminPanel.Controls.Add(this.buttonDelete);
            this.adminPanel.Location = new System.Drawing.Point(532, 380);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(315, 47);
            this.adminPanel.TabIndex = 6;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(2, 2);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 42);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(106, 2);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 42);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(210, 2);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 42);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonPlotter);
            this.flowLayoutPanel1.Controls.Add(this.buttonCreator);
            this.flowLayoutPanel1.Controls.Add(this.buttonType);
            this.flowLayoutPanel1.Controls.Add(this.buttonValue);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 380);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(420, 48);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // buttonPlotter
            // 
            this.buttonPlotter.Location = new System.Drawing.Point(2, 2);
            this.buttonPlotter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlotter.Name = "buttonPlotter";
            this.buttonPlotter.Size = new System.Drawing.Size(100, 42);
            this.buttonPlotter.TabIndex = 1;
            this.buttonPlotter.Text = "Плоттер";
            this.buttonPlotter.UseVisualStyleBackColor = true;
            this.buttonPlotter.Click += new System.EventHandler(this.buttonPlotter_Click);
            // 
            // buttonCreator
            // 
            this.buttonCreator.Location = new System.Drawing.Point(106, 2);
            this.buttonCreator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreator.Name = "buttonCreator";
            this.buttonCreator.Size = new System.Drawing.Size(100, 42);
            this.buttonCreator.TabIndex = 9;
            this.buttonCreator.Text = "Производитель";
            this.buttonCreator.UseVisualStyleBackColor = true;
            this.buttonCreator.Click += new System.EventHandler(this.buttonCreator_Click);
            // 
            // buttonType
            // 
            this.buttonType.Location = new System.Drawing.Point(210, 2);
            this.buttonType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(100, 42);
            this.buttonType.TabIndex = 10;
            this.buttonType.Text = "Тип";
            this.buttonType.UseVisualStyleBackColor = true;
            this.buttonType.Click += new System.EventHandler(this.buttonType_Click);
            // 
            // buttonValue
            // 
            this.buttonValue.Location = new System.Drawing.Point(314, 2);
            this.buttonValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonValue.Name = "buttonValue";
            this.buttonValue.Size = new System.Drawing.Size(100, 42);
            this.buttonValue.TabIndex = 12;
            this.buttonValue.Text = "Свойства всех плоттеров";
            this.buttonValue.UseVisualStyleBackColor = true;
            this.buttonValue.Click += new System.EventHandler(this.buttonChar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxInfo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(166, 202);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 167);
            this.panel1.TabIndex = 11;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInfo.Location = new System.Drawing.Point(4, 21);
            this.textBoxInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(422, 132);
            this.textBoxInfo.TabIndex = 4;
            this.textBoxInfo.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // searchForName_button
            // 
            this.searchForName_button.Location = new System.Drawing.Point(33, 28);
            this.searchForName_button.Margin = new System.Windows.Forms.Padding(2);
            this.searchForName_button.Name = "searchForName_button";
            this.searchForName_button.Size = new System.Drawing.Size(74, 23);
            this.searchForName_button.TabIndex = 12;
            this.searchForName_button.Text = "Найти";
            this.searchForName_button.UseVisualStyleBackColor = true;
            this.searchForName_button.Click += new System.EventHandler(this.searchForName_button_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(14, 7);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(116, 20);
            this.searchTextBox.TabIndex = 13;
            this.searchTextBox.Text = "Поиск по названию";
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(25, 66);
            this.filterButton.Margin = new System.Windows.Forms.Padding(2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(90, 29);
            this.filterButton.TabIndex = 14;
            this.filterButton.Text = "Фильтр";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.filterButton);
            this.panel2.Controls.Add(this.searchForName_button);
            this.panel2.Location = new System.Drawing.Point(8, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 112);
            this.panel2.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgrammMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutProgrammMenuItem
            // 
            this.AboutProgrammMenuItem.Name = "AboutProgrammMenuItem";
            this.AboutProgrammMenuItem.Size = new System.Drawing.Size(94, 22);
            this.AboutProgrammMenuItem.Text = "О программе";
            this.AboutProgrammMenuItem.Click += new System.EventHandler(this.AboutProgrammMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.photoPanel);
            this.Controls.Add(this.traitsPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataPlotter);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Activated += new System.EventHandler(this.MainFrom_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPlotter)).EndInit();
            this.traitsPanel.ResumeLayout(false);
            this.traitsPanel.PerformLayout();
            this.photoPanel.ResumeLayout(false);
            this.photoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlotter)).EndInit();
            this.adminPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPlotter;
        private System.Windows.Forms.Panel traitsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel photoPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel adminPanel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonPlotter;
        private System.Windows.Forms.Button buttonCreator;
        private System.Windows.Forms.Button buttonType;
        private System.Windows.Forms.RichTextBox textBoxProp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox textBoxInfo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxPlotter;
        private System.Windows.Forms.Button buttonValue;
        private System.Windows.Forms.Button searchForName_button;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutProgrammMenuItem;
    }
}

