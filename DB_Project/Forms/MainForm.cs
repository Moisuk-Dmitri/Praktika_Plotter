using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
//using MySqlX.XDevAPI.Relational;
using System.Data.SQLite;
using System.Drawing.Text;
using System.IO;
using System.Data.Entity;
//using MySqlX.XDevAPI.Common;
using DB_Project.Forms;
using DB_Project.Forms.AdminPanel;

namespace DB_Project
{
    public partial class MainForm : Form
    {
        db dataBase = new db();

        //DataTable table = new DataTable();
        //public int role_ID;

        //Конструкторы
        public MainForm()
        {
            InitializeComponent();
            dataPlotter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public MainForm(bool isAdmin)
        {
            InitializeComponent();
            if (isAdmin == false)
            {
                adminPanel.Visible = false; 
            }
        }


        //Кнопки выбора таблиц
        private void buttonPlotter_Click(object sender, EventArgs e)
        {

            string cmd =
                "SELECT Plotter.ID_Plotter as `ID_Плоттера`, Plotter.Plotter_Name as 'Модель', Manufacturer.Manufacturer_Name as `Производитель`, Plotter_Subtype.Subtype_Name as `Подтип`, " +
                "Plotter.Price as `Цена`, Plotter.Info as `Информация` " +
                "FROM Plotter " +
                "JOIN Manufacturer ON Plotter.ID_Manufacturer = Manufacturer.ID_Manufacturer " +
                "JOIN Plotter_Subtype ON Plotter.ID_Subtype = Plotter_Subtype.ID_Subtype ";

            try
            {
                dataPlotter.DataSource = dataBase.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            adminButton(true);
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT Plotter_Subtype.ID_Subtype as `ID Подтипа`, " +
                "Plotter_Group.Group_Name as `Группа`, " +
                "Plotter_Type.Name_Type as `Тип`, " +
                "Plotter_Subtype.Subtype_Name as `Подтип` " +
                "FROM Plotter_Subtype " +
                "JOIN Plotter_Group ON Plotter_Subtype.ID_Group = Plotter_Group.ID_Group " +
                "JOIN Plotter_Type ON Plotter_Subtype.ID_Type = Plotter_Type.ID_Type; ";
            try
            {
                dataPlotter.DataSource = dataBase.GetDataTable(cmd);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            adminButton(false);

        }

        private void buttonChar_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT Properties.ID_Plotter as `ID_Плоттера`, " +
                "Hard_Drive.Hard_Drive_Capacity as `Жесткий диск`, " +
                "Cartridge_Volume.Cartridge_Volume_Capacity as `Объем картриджа`, " +
                "Fingerprints_Stacker.Presence as `Укладчик отпечатков`, " +
                "Properties.Print_Width as `Ширина печати, мм`, " +
                "Properties.Print_Speed as `Скорость печати (А1), сек`, " +
                "Properties.Rolls_Number as `Кол-во рулонов` " +
                "FROM Properties " +
                "JOIN Hard_Drive ON Properties.ID_Hard_Drive = Hard_Drive.ID_Hard_drive " +
                "JOIN Cartridge_Volume ON Properties.ID_Cartridge_Volume = Cartridge_Volume.ID_Cartridge_Volume " +
                "JOIN Fingerprints_Stacker ON Properties.ID_Fingerprints_Stacker = Fingerprints_Stacker.ID_Fingerprints_Stacker ";
            try
            {
                dataPlotter.DataSource = dataBase.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            adminButton(false);
             
        }

        private void buttonCreator_Click(object sender, EventArgs e)
        {
            string cmd = "select ID_Manufacturer as `ID Компании`, " +
                         "Manufacturer_Name as `Название` from Manufacturer ";
            try
            {
                dataPlotter.DataSource = dataBase.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            adminButton(false);
        }



        //Фукнции формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            db dataBase = new db();

            string cmd =
                 "SELECT Plotter.ID_Plotter as `ID_Плоттера`, Plotter.Plotter_Name as 'Модель', Manufacturer.Manufacturer_Name as `Производитель`, Plotter_Subtype.Subtype_Name as `Подтип`, " +
                 "Plotter.Price as `Цена`, Plotter.Info as `Информация` " +
                 "FROM Plotter " +
                 "JOIN Manufacturer ON Plotter.ID_Manufacturer = Manufacturer.ID_Manufacturer " +
                 "JOIN Plotter_Subtype ON Plotter.ID_Subtype = Plotter_Subtype.ID_Subtype ";
            try
            {
                dataPlotter.DataSource = dataBase.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection forms = Application.OpenForms;
            for(int i = 0; i < forms.Count; i++)
            {
                if (forms[i].Visible)
                    forms[i].Close();
                else
                    forms[i].Show();

            }       
        }

        //Функция, которая собирает свойства передаваемого id плоттера и записывает в textbox
        public void GetPlotterProp(int idPlot, RichTextBox textBox)
        {
            db dataBase = new db();
            List<string> strings = new List<string>() 
            { "Жесткий диск - ",
              "Объем картриджа - ",
              "Укладчик отпечатков - ",
              "Ширина печати, мм - ",
              "Скорость печати(А1), сек - ",
              "Кол-во рулонов - "};
            string cmd = "SELECT " +
                "Hard_Drive.Hard_Drive_Capacity, " +
                "Cartridge_Volume.Cartridge_Volume_Capacity, " +
                "Fingerprints_Stacker.Presence, " +
                "Properties.Print_Width, " +
                "Properties.Print_Speed, " +
                "Properties.Rolls_Number " +
                "FROM Properties " +
                "JOIN Hard_Drive ON Properties.ID_Hard_Drive = Hard_Drive.ID_Hard_Drive " +
                "JOIN Cartridge_Volume ON Properties.ID_Cartridge_Volume = Cartridge_Volume.ID_Cartridge_Volume " +
                "JOIN Fingerprints_Stacker ON Properties.ID_Fingerprints_Stacker = Fingerprints_Stacker.ID_Fingerprints_Stacker " +
               $"WHERE Properties.ID_Plotter = {idPlot};";
           
            List<string> result = dataBase.GetTable(cmd)[0];
            for(int i = 0; i < result.Count; i++)
                strings[i] += result[i];
            textBoxProp.Text = String.Join("\n", strings.ToArray());
            cmd = "SELECT Info " + 
                    "FROM Plotter " +
                    $"WHERE ID_Plotter = {idPlot}";
            result = dataBase.GetTable(cmd)[0];
            textBoxInfo.Text = String.Join("\n", result.ToArray());

            cmd = $"SELECT Path_To_Photo FROM Plotter WHERE ID_Plotter = {idPlot}";
            string file = dataBase.GetFirstValue(cmd);
            ShowImage(file);
            
        }
        //Вставка картинки в messagebox
        public void ShowImage(string fileToDisplay)
        {
            if(File.Exists(fileToDisplay))
            {
                try
                {
                    Image image = Image.FromFile(fileToDisplay);
                    pictureBoxPlotter.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxPlotter.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);

                }
            }
            else
            {
                try
                {
                    Image image = Image.FromFile("../../DataBase/Photo/no_photo.png");
                    pictureBoxPlotter.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxPlotter.Image = image;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Файл изображения не найден.");

                }
            }
        }
        //Получение id выбранного в таблице плоттера


        private void filterButton_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach(Form frm in fc)
            {
                if(frm.Name == "FilterWindow")
                {
                    frm.Focus();
                    return;
                }
            }
            FilterWindow form = new FilterWindow(dataPlotter);
            form.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            db dataBase = new db();
            int idPlotter = GetSelectedPlotId(dataPlotter);
            string cmd = $"DELETE FROM Properties WHERE ID_Plotter = {idPlotter}";
            dataBase.executeCmd(cmd);
            cmd = $"DELETE FROM Plotter WHERE ID_Plotter = {idPlotter}";
            dataBase.executeCmd(cmd);
            MessageBox.Show("Данные удалены.");
        }

        //Вывод данных о плоттере на панельки
        private void dataPlotter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int idPlotter = GetSelectedPlotId(dataPlotter);
            if (idPlotter != -1)
            {
                GetPlotterProp(idPlotter, textBoxProp);
                return;
            }
            textBoxInfo.Text = "";
            textBoxProp.Text = "";


        }

        public int GetSelectedPlotId(DataGridView dataPlotter)
        {
            int plotId = -1;
            try
            {
                int selectedRow = dataPlotter.CurrentCell.RowIndex;
                plotId = Convert.ToInt32(dataPlotter.Rows[selectedRow].Cells["ID_Плоттера"].Value);
            }
            catch (Exception ex)
            {
                return plotId;
            }
            return plotId;
        }

        //Кнопки админа
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "NewPlotterForm")
                {
                    frm.Focus();
                    return;
                }
            }          
            NewPlotterForm form = new NewPlotterForm();
            form.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "UpdateForm")
                {
                    frm.Focus();
                    return;
                }
            }
            int idPlotter = GetSelectedPlotId(dataPlotter);
            UpdateForm form = new UpdateForm(idPlotter);
            form.Show();
        }



        private void searchForName_button_Click(object sender, EventArgs e)
        {
            string str = searchTextBox.Text;
            if (str == "Поиск по названию")
            {
                MessageBox.Show("Введите название!");
                return;
            }
            db dataBase = new db();
            string cmd = "SELECT Plotter.ID_Plotter AS `ID_Плоттера`, " +
               " Plotter.Plotter_Name AS `Модель`, " +
               " Manufacturer.Manufacturer_Name AS `Производитель`, " +
               " Plotter_Subtype.Subtype_Name AS `Подтип`, " +
               " Plotter.Price AS `Цена`, " + 
               " Plotter.Info AS `Информация` " +
               "FROM Plotter " +
               "JOIN Manufacturer ON Plotter.ID_Manufacturer = Manufacturer.ID_Manufacturer " +
               "JOIN Plotter_Subtype ON Plotter.ID_Subtype = Plotter_Subtype.ID_Subtype " +
               $"WHERE Plotter.Plotter_Name LIKE '{str}%'";
            try
            {
                dataPlotter.DataSource = dataBase.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }


        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.Text = "Поиск по названию";
            }
        }

        private void filterButton_Click_1(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "FilterWindow")
                {
                    frm.Focus();
                    return;
                }
            }
            FilterWindow form = new FilterWindow(dataPlotter);
            form.Show();
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Поиск по названию")
                searchTextBox.Clear();
        }

        private void adminButton(bool value)
        {
            buttonUpdate.Enabled = value;
            buttonDelete.Enabled = value;
            buttonAdd.Enabled = value;
        }

        private void MainFrom_Activated(object sender, EventArgs e)
        {
            db dataBase = new db();

            string cmd =
                 "SELECT Plotter.ID_Plotter as `ID_Плоттера`, Plotter.Plotter_Name as 'Модель', Manufacturer.Manufacturer_Name as `Производитель`, Plotter_Subtype.Subtype_Name as `Подтип`, " +
                 "Plotter.Price as `Цена`, Plotter.Info as `Информация` " +
                 "FROM Plotter " +
                 "JOIN Manufacturer ON Plotter.ID_Manufacturer = Manufacturer.ID_Manufacturer " +
                 "JOIN Plotter_Subtype ON Plotter.ID_Subtype = Plotter_Subtype.ID_Subtype ";
            try
            {
                dataPlotter.DataSource = dataBase.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void AboutProgrammMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm form = new AboutProgramForm();
            form.Show();
        }
    }
}
