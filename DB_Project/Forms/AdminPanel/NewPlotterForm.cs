using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DB_Project.GeneralFunction;

namespace DB_Project.Forms.AdminPanel
{
    public partial class NewPlotterForm : Form
    {
        public NewPlotterForm()
        {
            InitializeComponent();
        }

        private void NewPlotterForm_Load(object sender, EventArgs e)
        {
            db dataBase = new db();

            string cmd = "SELECT * FROM `Plotter_Group`";
            addItemToComboBox(cmd, groupBox, 0, 1);

            cmd = "SELECT * FROM `Manufacturer`";
            addItemToComboBox(cmd, manufactureBox, 0, 1);

            cmd = "SELECT * FROM `Cartridge_Volume`";
            addItemToComboBox(cmd, cartridgeVolumeBox, 0, 1);

            cmd = "SELECT * FROM `Hard_Drive`";
            addItemToComboBox(cmd, hardDriveBox, 0, 1);

            cmd = "SELECT * FROM `Fingerprints_Stacker`";
            addItemToComboBox(cmd, fingerprintsStackerBox, 0, 1);
        }

        private void escapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            db dataBase = new db();
            int idGroup = ((MyItem)(groupBox.SelectedItem)).Id;
            string cmd = $"SELECT * FROM `Plotter_Type` WHERE `ID_Group` = {idGroup}";
            addItemToComboBox(cmd, typeBox, 0, 1);
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            db dataBase = new db();
            int idGroup = ((MyItem)(groupBox.SelectedItem)).Id;
            int idType = ((MyItem)(typeBox.SelectedItem)).Id;
            string cmd = $"SELECT * FROM `Plotter_Subtype` WHERE `ID_Group` = {idGroup} AND `ID_Type` = {idType}";
            addItemToComboBox(cmd, subtypeBox, 0, 1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            db dataBase = new db();
            Int32.TryParse(priceBox.Text, out int price);
            Int32.TryParse(printSpeedBox.Text, out int printSpeed);
            Int32.TryParse(printWidthBox.Text, out int printWidth); // 
            Int32.TryParse(rollsNumberBox.Text, out int rollsNumber); // AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            if(price == 0 || printSpeed == 0 || printWidth == 0 || rollsNumber == 0)
            {
                MessageBox.Show("Введите положительные числа в полях цены, количества рулонов, ширины печати и скорости печати.");
                return;
            }
            if(nameBox.Text == "")
            {
                MessageBox.Show("Введите название плоттера.");
                return;
            }

            string cmd = "INSERT INTO Plotter(Plotter_Name, Price, ID_Manufacturer, ID_Subtype, Info, Path_To_Photo) " +
                        $"VALUES ('{nameBox.Text}', {price}, {getIdFromMyItem(manufactureBox)}, " +
                        $"{getIdFromMyItem(subtypeBox)}, '{informationTextBox.Text}', " +
                        $"'{pathToFileBox.Text}')";
            dataBase.executeCmd(cmd);
            cmd = "SELECT ID_Plotter FROM Plotter " +
                "WHERE ID_Plotter NOT IN (SELECT Properties.ID_Plotter FROM Properties)";

            int id = Int32.Parse(dataBase.GetFirstValue(cmd));

            cmd = "INSERT INTO Properties(ID_Plotter, Print_Speed,Print_Width," +
                " Rolls_Number, ID_Hard_Drive, ID_Cartridge_Volume," +
                " ID_Fingerprints_Stacker) VALUES " +
                $"({id}, {printSpeed}, {printWidth}, " +
                $"{rollsNumber}, {getIdFromMyItem(hardDriveBox)}, " +
                $"{getIdFromMyItem(cartridgeVolumeBox)}, {getIdFromMyItem(fingerprintsStackerBox)})";
            dataBase.executeCmd(cmd);

            MessageBox.Show("Данные введены.");
            this.Close();
        }

        private void pathToFileBox_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            if(path == "")
            {
                pathToFileBox.Text = "DEFAULT";

            }
        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void informationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
