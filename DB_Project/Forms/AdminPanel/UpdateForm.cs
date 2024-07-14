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

namespace DB_Project.Forms
{
    public partial class UpdateForm : Form
    {
        int id;
        public UpdateForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

            db dataBase = new db();

            idBox.Text = id.ToString();

            string cmd = "SELECT * FROM `Plotter_Group`";
            addItemToComboBox(cmd, groupBox, 0, 1);

            cmd = "SELECT * FROM `Manufacturer`";
            addItemToComboBox(cmd, manufactureBox, 0, 1);

            cmd = "SELECT * FROM `Hard_Drive`";
            addItemToComboBox(cmd, hardDriveBox, 0, 1);

            cmd = "SELECT * FROM `Cartridge_Volume`";
            addItemToComboBox(cmd, cartridgeVolumeBox, 0, 1);

            cmd = "SELECT * FROM `Fingerprints_Stacker`";
            addItemToComboBox(cmd, fingerprintsStackerBox, 0, 1);

            cmd = $"SELECT Print_Speed FROM Properties WHERE ID_Plotter = {id}";
            printSpeedBox.Text = dataBase.GetFirstValue(cmd).ToString(); 

            cmd = $"SELECT Print_Width FROM Properties WHERE ID_Plotter = {id}";
            printWidthBox.Text = dataBase.GetFirstValue(cmd).ToString();

            cmd = $"SELECT Rolls_Number FROM Properties WHERE ID_Plotter = {id}";
            rollsNumberBox.Text = dataBase.GetFirstValue(cmd).ToString();

            cmd = $"SELECT Info FROM Plotter WHERE ID_Plotter = {id}";
            informationTextBox.Text = dataBase.GetFirstValue(cmd).ToString();

            cmd = $"SELECT Plotter_Name FROM Plotter WHERE ID_Plotter = {id}";
            nameBox.Text = dataBase.GetFirstValue(cmd).ToString();

            cmd = $"SELECT Price FROM Plotter WHERE ID_Plotter = {id}";
            priceBox.Text = dataBase.GetFirstValue(cmd).ToString();

            cmd = $"SELECT ID_Manufacturer FROM Plotter WHERE ID_Plotter = {id}";
            selectIndex(manufactureBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT ID_Group FROM Plotter_Subtype WHERE ID_Subtype =" +
                $" (SELECT ID_Subtype FROM Plotter WHERE ID_Plotter = {id})";
            selectIndex(groupBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT ID_Type FROM Plotter_Subtype WHERE ID_Subtype =" +
                $" (SELECT ID_Subtype FROM Plotter WHERE ID_Plotter = {id})";
            selectIndex(typeBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT ID_Subtype FROM Plotter_Subtype WHERE ID_Subtype =" +
                $" (SELECT ID_Subtype FROM Plotter WHERE ID_Plotter = {id})";
            selectIndex(subtypeBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT ID_Hard_Drive FROM Properties WHERE ID_Plotter = {id}";
            selectIndex(hardDriveBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT ID_Cartridge_Volume FROM Properties WHERE ID_Plotter = {id}";
            selectIndex(cartridgeVolumeBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT ID_Fingerprints_Stacker FROM Properties WHERE ID_Plotter = {id}";
            selectIndex(fingerprintsStackerBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT Path_To_Photo FROM Plotter WHERE ID_Plotter = {id}";
            pathToFileBox.Text = dataBase.GetFirstValue(cmd);

        }

        void selectIndex(ComboBox comboBox, int id)
        {
            var items = comboBox.Items;
            for(int i = 0; i < items.Count; i++)
            {
                if (((MyItem)items[i]).Id == id)
                {
                    comboBox.SelectedIndex = i;
                    break;
                }
            }
        }
        

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (priceBox.Text == "")
            {
                priceBox.Text = "NULL";
            }
            db dataBase = new db();
            string cmd = $"UPDATE Plotter SET Plotter_Name = '{nameBox.Text}'," +
                $" Price = {priceBox.Text}, ID_Manufacturer = {getIdFromMyItem(manufactureBox)}," +
                $" ID_Subtype = {getIdFromMyItem(subtypeBox)}," +
                $" Info = '{informationTextBox.Text}', " +
                $" Path_To_Photo = '{pathToFileBox.Text}'" +
                $"WHERE ID_Plotter = {idBox.Text}";
            dataBase.executeCmd(cmd);
            cmd = "UPDATE Properties SET " +
                $"Print_Speed = {printSpeedBox.Text}, " +
                $"Print_Width = {printWidthBox.Text}, " +
                $"Rolls_Number = {rollsNumberBox.Text}, " +
                $"ID_Hard_Drive = {getIdFromMyItem(hardDriveBox)}, " +
                $"ID_Cartridge_Volume = {getIdFromMyItem(cartridgeVolumeBox)}, " +
                $"ID_Fingerprints_Stacker = {getIdFromMyItem(fingerprintsStackerBox)} " +
                $"WHERE ID_Plotter = {idBox.Text}";
            dataBase.executeCmd(cmd);
            MessageBox.Show("Данные обновлены");
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

        private void escapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pathToFileBox_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            if (path == "")
            {
                pathToFileBox.Text = "DEFAULT";
                return;
            }
            pathToFileBox.Text = path;
        }

        private void hardDriveLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
