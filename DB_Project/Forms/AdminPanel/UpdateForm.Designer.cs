namespace DB_Project.Forms
{
    partial class UpdateForm
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
            this.updateButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.manufactureLabel = new System.Windows.Forms.Label();
            this.manufactureBox = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.subtypeLabel = new System.Windows.Forms.Label();
            this.subtypeBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.hardDriveLabel = new System.Windows.Forms.Label();
            this.hardDriveBox = new System.Windows.Forms.ComboBox();
            this.cartridgeVolumeLabel = new System.Windows.Forms.Label();
            this.cartridgeVolumeBox = new System.Windows.Forms.ComboBox();
            this.fingerprintsStackerLabel = new System.Windows.Forms.Label();
            this.fingerprintsStackerBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.printSpeedLabel = new System.Windows.Forms.Label();
            this.printSpeedBox = new System.Windows.Forms.TextBox();
            this.printWidthLabel = new System.Windows.Forms.Label();
            this.printWidthBox = new System.Windows.Forms.TextBox();
            this.rollsNumberLabel = new System.Windows.Forms.Label();
            this.rollsNumberBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.informationLabel = new System.Windows.Forms.Label();
            this.informationTextBox = new System.Windows.Forms.RichTextBox();
            this.escapeButton = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.pathToFileBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(1274, 689);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(185, 67);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NameLabel);
            this.flowLayoutPanel1.Controls.Add(this.nameBox);
            this.flowLayoutPanel1.Controls.Add(this.TextLabel);
            this.flowLayoutPanel1.Controls.Add(this.priceBox);
            this.flowLayoutPanel1.Controls.Add(this.manufactureLabel);
            this.flowLayoutPanel1.Controls.Add(this.manufactureBox);
            this.flowLayoutPanel1.Controls.Add(this.groupLabel);
            this.flowLayoutPanel1.Controls.Add(this.groupBox);
            this.flowLayoutPanel1.Controls.Add(this.typeLabel);
            this.flowLayoutPanel1.Controls.Add(this.typeBox);
            this.flowLayoutPanel1.Controls.Add(this.subtypeLabel);
            this.flowLayoutPanel1.Controls.Add(this.subtypeBox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(367, 526);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(143, 32);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Название";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(3, 35);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(309, 38);
            this.nameBox.TabIndex = 5;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(3, 76);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(83, 32);
            this.TextLabel.TabIndex = 7;
            this.TextLabel.Text = "Цена";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(3, 111);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(309, 38);
            this.priceBox.TabIndex = 6;
            // 
            // manufactureLabel
            // 
            this.manufactureLabel.AutoSize = true;
            this.manufactureLabel.Location = new System.Drawing.Point(3, 152);
            this.manufactureLabel.Name = "manufactureLabel";
            this.manufactureLabel.Size = new System.Drawing.Size(219, 32);
            this.manufactureLabel.TabIndex = 4;
            this.manufactureLabel.Text = "Производитель";
            // 
            // manufactureBox
            // 
            this.manufactureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufactureBox.FormattingEnabled = true;
            this.manufactureBox.Location = new System.Drawing.Point(3, 187);
            this.manufactureBox.Name = "manufactureBox";
            this.manufactureBox.Size = new System.Drawing.Size(309, 39);
            this.manufactureBox.TabIndex = 3;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(3, 229);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(108, 32);
            this.groupLabel.TabIndex = 0;
            this.groupLabel.Text = "Группа";
            // 
            // groupBox
            // 
            this.groupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(3, 264);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(309, 39);
            this.groupBox.TabIndex = 3;
            this.groupBox.SelectedIndexChanged += new System.EventHandler(this.groupBox_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(3, 306);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(63, 32);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Тип";
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(3, 341);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(309, 39);
            this.typeBox.TabIndex = 4;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // subtypeLabel
            // 
            this.subtypeLabel.AutoSize = true;
            this.subtypeLabel.Location = new System.Drawing.Point(3, 383);
            this.subtypeLabel.Name = "subtypeLabel";
            this.subtypeLabel.Size = new System.Drawing.Size(111, 32);
            this.subtypeLabel.TabIndex = 2;
            this.subtypeLabel.Text = "Подтип";
            // 
            // subtypeBox
            // 
            this.subtypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subtypeBox.FormattingEnabled = true;
            this.subtypeBox.Location = new System.Drawing.Point(3, 418);
            this.subtypeBox.Name = "subtypeBox";
            this.subtypeBox.Size = new System.Drawing.Size(309, 39);
            this.subtypeBox.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(24, 113);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1447, 545);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.hardDriveLabel);
            this.flowLayoutPanel4.Controls.Add(this.hardDriveBox);
            this.flowLayoutPanel4.Controls.Add(this.cartridgeVolumeLabel);
            this.flowLayoutPanel4.Controls.Add(this.cartridgeVolumeBox);
            this.flowLayoutPanel4.Controls.Add(this.fingerprintsStackerLabel);
            this.flowLayoutPanel4.Controls.Add(this.fingerprintsStackerBox);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(376, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(355, 526);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // hardDriveLabel
            // 
            this.hardDriveLabel.AutoSize = true;
            this.hardDriveLabel.Location = new System.Drawing.Point(3, 0);
            this.hardDriveLabel.Name = "hardDriveLabel";
            this.hardDriveLabel.Size = new System.Drawing.Size(209, 32);
            this.hardDriveLabel.TabIndex = 8;
            this.hardDriveLabel.Text = "Жесткий диск";
            // 
            // hardDriveBox
            // 
            this.hardDriveBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hardDriveBox.FormattingEnabled = true;
            this.hardDriveBox.Location = new System.Drawing.Point(3, 35);
            this.hardDriveBox.Name = "hardDriveBox";
            this.hardDriveBox.Size = new System.Drawing.Size(324, 39);
            this.hardDriveBox.TabIndex = 9;
            // 
            // cartridgeVolumeLabel
            // 
            this.cartridgeVolumeLabel.AutoSize = true;
            this.cartridgeVolumeLabel.Location = new System.Drawing.Point(3, 77);
            this.cartridgeVolumeLabel.Name = "cartridgeVolumeLabel";
            this.cartridgeVolumeLabel.Size = new System.Drawing.Size(176, 32);
            this.cartridgeVolumeLabel.TabIndex = 11;
            this.cartridgeVolumeLabel.Text = "Объем картриджа";
            // 
            // cartridgeVolumeBox
            // 
            this.cartridgeVolumeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cartridgeVolumeBox.FormattingEnabled = true;
            this.cartridgeVolumeBox.Location = new System.Drawing.Point(3, 112);
            this.cartridgeVolumeBox.Name = "cartridgeVolumeBox";
            this.cartridgeVolumeBox.Size = new System.Drawing.Size(324, 39);
            this.cartridgeVolumeBox.TabIndex = 10;
            // 
            // fingerprintsStackerLabel
            // 
            this.fingerprintsStackerLabel.AutoSize = true;
            this.fingerprintsStackerLabel.Location = new System.Drawing.Point(3, 154);
            this.fingerprintsStackerLabel.Name = "fingerprintsStackerLabel";
            this.fingerprintsStackerLabel.Size = new System.Drawing.Size(324, 32);
            this.fingerprintsStackerLabel.TabIndex = 12;
            this.fingerprintsStackerLabel.Text = "Укладчик отпечатков";
            // 
            // fingerprintsStackerBox
            // 
            this.fingerprintsStackerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fingerprintsStackerBox.FormattingEnabled = true;
            this.fingerprintsStackerBox.Location = new System.Drawing.Point(3, 189);
            this.fingerprintsStackerBox.Name = "fingerprintsStackerBox";
            this.fingerprintsStackerBox.Size = new System.Drawing.Size(324, 39);
            this.fingerprintsStackerBox.TabIndex = 13;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.printSpeedLabel);
            this.flowLayoutPanel3.Controls.Add(this.printSpeedBox);
            this.flowLayoutPanel3.Controls.Add(this.printWidthLabel);
            this.flowLayoutPanel3.Controls.Add(this.printWidthBox);
            this.flowLayoutPanel3.Controls.Add(this.rollsNumberLabel);
            this.flowLayoutPanel3.Controls.Add(this.rollsNumberBox);
            this.flowLayoutPanel3.Controls.Add(this.filePathLabel);
            this.flowLayoutPanel3.Controls.Add(this.pathToFileBox);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(737, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(368, 526);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // printSpeedLabel
            // 
            this.printSpeedLabel.AutoSize = true;
            this.printSpeedLabel.Location = new System.Drawing.Point(3, 0);
            this.printSpeedLabel.Name = "printSpeedLabel";
            this.printSpeedLabel.Size = new System.Drawing.Size(268, 32);
            this.printSpeedLabel.TabIndex = 0;
            this.printSpeedLabel.Text = "Скорость печати (А1), сек";
            // 
            // printSpeedBox
            // 
            this.printSpeedBox.Location = new System.Drawing.Point(3, 35);
            this.printSpeedBox.Name = "printSpeedBox";
            this.printSpeedBox.Size = new System.Drawing.Size(347, 38);
            this.printSpeedBox.TabIndex = 3;
            // 
            // printWidthLabel
            // 
            this.printWidthLabel.AutoSize = true;
            this.printWidthLabel.Location = new System.Drawing.Point(3, 76);
            this.printWidthLabel.Name = "printWidthLabel";
            this.printWidthLabel.Size = new System.Drawing.Size(286, 32);
            this.printWidthLabel.TabIndex = 1;
            this.printWidthLabel.Text = "Ширина печати, мм";
            // 
            // printWidthBox
            // 
            this.printWidthBox.Location = new System.Drawing.Point(3, 111);
            this.printWidthBox.Name = "printWidthBox";
            this.printWidthBox.Size = new System.Drawing.Size(347, 38);
            this.printWidthBox.TabIndex = 4;
            // 
            // rollsNumberLabel
            // 
            this.rollsNumberLabel.AutoSize = true;
            this.rollsNumberLabel.Location = new System.Drawing.Point(3, 152);
            this.rollsNumberLabel.Name = "rollsNumberLabel";
            this.rollsNumberLabel.Size = new System.Drawing.Size(347, 32);
            this.rollsNumberLabel.TabIndex = 2;
            this.rollsNumberLabel.Text = "Количество рулонов";
            // 
            // rollsNumberBox
            // 
            this.rollsNumberBox.Location = new System.Drawing.Point(3, 187);
            this.rollsNumberBox.Name = "rollsNumberBox";
            this.rollsNumberBox.Size = new System.Drawing.Size(347, 38);
            this.rollsNumberBox.TabIndex = 5;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.informationLabel);
            this.flowLayoutPanel5.Controls.Add(this.informationTextBox);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(1111, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(324, 526);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(3, 0);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(146, 32);
            this.informationLabel.TabIndex = 5;
            this.informationLabel.Text = "Описание";
            // 
            // informationTextBox
            // 
            this.informationTextBox.Location = new System.Drawing.Point(3, 35);
            this.informationTextBox.Name = "informationTextBox";
            this.informationTextBox.Size = new System.Drawing.Size(312, 478);
            this.informationTextBox.TabIndex = 7;
            this.informationTextBox.Text = "";
            // 
            // escapeButton
            // 
            this.escapeButton.Location = new System.Drawing.Point(27, 689);
            this.escapeButton.Name = "escapeButton";
            this.escapeButton.Size = new System.Drawing.Size(185, 67);
            this.escapeButton.TabIndex = 3;
            this.escapeButton.Text = "Назад";
            this.escapeButton.UseVisualStyleBackColor = true;
            this.escapeButton.Click += new System.EventHandler(this.escapeButton_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(30, 35);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(216, 32);
            this.IDlabel.TabIndex = 4;
            this.IDlabel.Text = "ID Экстрактора";
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(36, 70);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(303, 38);
            this.idBox.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "../../DataBase/Photo/no_photo.png";
            this.openFileDialog.Filter = "\"Image File(*.BMP;*.JPG;*.PNG;*.JPEG)|)*.BMP;*.JPG;*.PNG;*.JPEG\"";
            this.openFileDialog.InitialDirectory = "../../../";
            this.openFileDialog.Title = "Выберите картинку";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(3, 228);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(225, 32);
            this.filePathLabel.TabIndex = 6;
            this.filePathLabel.Text = "Путь к картинке";
            // 
            // pathToFileBox
            // 
            this.pathToFileBox.Location = new System.Drawing.Point(3, 263);
            this.pathToFileBox.Name = "pathToFileBox";
            this.pathToFileBox.ReadOnly = true;
            this.pathToFileBox.Size = new System.Drawing.Size(347, 38);
            this.pathToFileBox.TabIndex = 7;
            this.pathToFileBox.DoubleClick += new System.EventHandler(this.pathToFileBox_DoubleClick);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 786);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.escapeButton);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.updateButton);
            this.Name = "UpdateForm";
            this.Text = "Обновление данных";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox manufactureBox;
        private System.Windows.Forms.Label manufactureLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label subtypeLabel;
        private System.Windows.Forms.ComboBox subtypeBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label hardDriveLabel;
        private System.Windows.Forms.ComboBox hardDriveBox;
        private System.Windows.Forms.Label cartridgeVolumeLabel;
        private System.Windows.Forms.ComboBox cartridgeVolumeBox;
        private System.Windows.Forms.Label fingerprintsStackerLabel;
        private System.Windows.Forms.ComboBox fingerprintsStackerBox;
        private System.Windows.Forms.Button escapeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label printSpeedLabel;
        private System.Windows.Forms.TextBox printSpeedBox;
        private System.Windows.Forms.Label printWidthLabel;
        private System.Windows.Forms.TextBox printWidthBox;
        private System.Windows.Forms.Label rollsNumberLabel;
        private System.Windows.Forms.TextBox rollsNumberBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.RichTextBox informationTextBox;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.TextBox pathToFileBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}