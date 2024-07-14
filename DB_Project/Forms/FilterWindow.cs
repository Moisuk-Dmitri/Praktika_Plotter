using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static DB_Project.GeneralFunction;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DB_Project
{
    public partial class FilterWindow : Form
    {

        DataGridView data;
        public FilterWindow(DataGridView dgv)
        {
            InitializeComponent();
            data = dgv;
        }

        private void FilterWindow_Load(object sender, EventArgs e)
        {
            typeBox.Enabled = false;
            subtypeBox.Enabled = false;
            db dataBase = new db();
            string cmd = "SELECT * FROM `Plotter_Group`";
            addItemToComboBox(cmd, groupBox, 0, 1);

            cmd = "SELECT * FROM `Manufacturer`";
            addItemToComboBox(cmd, manufacturerBox, 0, 1);
            manufacturerBox.Items.Add(new MyItem(-1, ""));
            
            cmd = "SELECT * FROM `Hard_Drive`";
            addItemToComboBox(cmd, hardDriveBox, 0, 1);
            hardDriveBox.Items.Add(new MyItem(-1, ""));

            cmd = "SELECT * FROM `Cartridge_Volume`";
            addItemToComboBox(cmd, cartridgeVolumeBox, 0, 1);
            cartridgeVolumeBox.Items.Add(new MyItem(-1, ""));

            cmd = "SELECT * FROM `Fingerprints_Stacker`";
            addItemToComboBox(cmd, fingerprintsStackerBox, 0, 1);
            fingerprintsStackerBox.Items.Add(new MyItem(-1, ""));
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string nameManufacturer = ((MyItem)(manufacturerBox.SelectedItem)).Name;
            db dataBase = new db();

            int id_Manufacturer = ((MyItem)(manufacturerBox.SelectedItem)).Id;
            int id_Subtype = ((MyItem)(subtypeBox.SelectedItem)).Id;
            int id_HardDrive = ((MyItem)(hardDriveBox.SelectedItem)).Id;
            int id_CartridgeVolume = ((MyItem)(cartridgeVolumeBox.SelectedItem)).Id;
            int id_FingerprintsStacker = ((MyItem)(fingerprintsStackerBox.SelectedItem)).Id;

            string mainCmd = "SELECT Plotter.ID_Plotter as `ID_Плоттера`, " +
                " Plotter.Plotter_Name as 'Модель', " +
                " Manufacturer.Manufacturer_Name as `Производитель`, " +
                " Plotter_Subtype.Subtype_Name as `Подтип`, " +
                " Plotter.Price as `Цена, руб`, " +
                " Plotter.Info as `Информация` " +
                "FROM Plotter " +
                "JOIN Manufacturer ON Plotter.ID_Manufacturer = Manufacturer.ID_Manufacturer " +
                "JOIN Plotter_Subtype ON Plotter.ID_Subtype = Plotter_Subtype.ID_Subtype ";

            string conditionCmd = "WHERE ";

            if(id_Manufacturer != -1)
            {
                conditionCmd += $"Manufacturer.Manufacturer_Name = '{nameManufacturer}' AND ";
            }
            if (id_Subtype != -1)
            {
                conditionCmd += $"Plotter.ID_Subtype = {id_Subtype} AND ";
            }

            if(id_Manufacturer != -1 || id_Subtype != -1)
            {
                mainCmd += conditionCmd;
            }

            string propertiesCmd = "ID_Plotter IN ( " +
                "SELECT ID_Plotter " +
                "FROM Properties WHERE ";

            if(id_HardDrive != -1)
            {
                propertiesCmd += $" ID_Hard_Drive = {id_HardDrive} AND ";
            }
            if (id_CartridgeVolume != -1)
            {
                propertiesCmd += $" ID_Cartridge_Volume = {id_CartridgeVolume} AND ";
            }
            if (id_FingerprintsStacker != -1)
            {
                propertiesCmd += $" ID_Fingerprints_Stacker = {id_FingerprintsStacker} AND ";
            }
            if (id_HardDrive != -1 || id_CartridgeVolume != -1 || id_FingerprintsStacker != -1)
            {
                if(id_Manufacturer == -1 || id_Subtype == -1)
                {
                    mainCmd += conditionCmd;
                }
                mainCmd += propertiesCmd;
                mainCmd = replaceLastOccurance(mainCmd, "AND", "");
                mainCmd += ")";
            }
            else if(id_Manufacturer != -1 || id_Subtype != -1)
            {
                mainCmd = replaceLastOccurance(mainCmd, "AND", "");
            }

            try
            {
                data.DataSource = dataBase.GetDataTable(mainCmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        } 
        public static string replaceLastOccurance(string source, string find, string replace)
        {
            int place = source.LastIndexOf(find);
            if (place == -1)
                return source;
            return source.Remove(place, find.Length).Insert(place, replace);
        }

        private void groupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((MyItem)(groupBox.SelectedItem)).Name == "")
            {
                typeBox.Enabled = false;
                subtypeBox.Enabled = false;
                return;
            }
            db dataBase = new db();
            int idGroup = ((MyItem)(groupBox.SelectedItem)).Id;
            string cmd = $"SELECT * FROM `Plotter_Type` WHERE `ID_Group` = {idGroup} ";
            addItemToComboBox(cmd, typeBox, 0, 1);
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((MyItem)(typeBox.SelectedItem)).Name == "")
            {
                subtypeBox.Enabled = false;
                return;
            }
            db dataBase = new db();
            int idGroup = ((MyItem)(groupBox.SelectedItem)).Id;
            int idType = ((MyItem)(typeBox.SelectedItem)).Id;
            string cmd = $"SELECT * FROM `Plotter_Subtype` WHERE `ID_Group` = {idGroup} AND `ID_Type` = {idType} ";
            addItemToComboBox(cmd, subtypeBox, 0, 1);
        }


        private void comboBox_EnabledChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).Enabled == false)
            {
                ((ComboBox)sender).Items.Clear();
            }
        }
    }
}
