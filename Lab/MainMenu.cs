using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.Devices;
using System.Runtime.CompilerServices;

namespace Lab
{
    public partial class Menu: SimilarElementsMainFormAndSearchForm
    {
        private bool isCollapsed;
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        DeseralizationToList deseralizationToList;
        const string Filter = "Json files(*.json)|*.json|All files(*.*)|*.*";
        string OpenFilename;
        string SaveFilename;    
        const int height = 10;
        Serialization serialization;
        SearchForm searchForm;
        AboutMe aboutMe;
        public Menu()
        {
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = Filter;
            openFileDialog.Filter = Filter;
            InitializeComponent();
            InitializeDataGridView(dataGridView);
            dataGrid = new DeseralizationToDataGrid(dataGridView);
        }
        private void AboutButton_Click(object sender, EventArgs e)
        {
            aboutMe = new AboutMe();
            aboutMe.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panelDropDown.Height += height;
                if(panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelDropDown.Height -= height;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }

        }
        private void FileButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                OpenFilename = openFileDialog.FileName;
                MessageBox.Show("File open successfully");
                deseralizationToList = new DeseralizationToList(OpenFilename);
                houses = deseralizationToList.DeseralizationFromFile();
                OpenFileOrDeleteObjectDeseralization();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialization = new Serialization(OpenFilename);
                serialization.Serialize(houses);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveAsbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                SaveFilename = saveFileDialog.FileName;
                serialization = new Serialization(SaveFilename);
                serialization.Serialize(houses);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonNext_Click_Button();
        }
        private void buttonPreviously_Click(object sender, EventArgs e)
        {
            buttonPreviously_Click_Button();
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteButton_Click_Button();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(houses == null)
            {
                houses = new List<House>();
            }
            formData = new AddHouse(ref houses, dataGrid, "Enter data to create a new house", this);
            formData.Show();
     
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(houses!=null && houses?.Count != zeroElements)
            {
                searchForm = new SearchForm(houses, this, dataGrid);
                searchForm.Show();
            }
            else
            {
                MessageBox.Show("No elements to search");
            }
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            Edit_Click_Button();
        }
    }
}