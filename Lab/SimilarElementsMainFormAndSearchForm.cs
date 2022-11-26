using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Lab
{
    public class SimilarElementsMainFormAndSearchForm : Form
    {
        protected List<House>? houses;
        public DeseralizationToDataGrid? dataGrid;
        protected int index = -1;
        const int rowCount = 5;
        const int columnCount = 1;
        DataGridView? dataGridView1;
        protected const int theFirstIndex = 0;
        int theLastIndex;
        protected formForData? formData;
        protected const int zeroElements = 0;
        protected void InitializeDataGridView(DataGridView dataGridView)
        {
            dataGridView1 = dataGridView;
            dataGridView1.ColumnCount = columnCount;
            dataGridView1.Columns[0].Name = "House";
            for (int i = theFirstIndex; i < rowCount; i++)
            {
                dataGridView1.Rows.Add("");
            }
            dataGridView1.Rows[0].HeaderCell.Value = "Publishing House Id";
            dataGridView1.Rows[1].HeaderCell.Value = "Title";
            dataGridView1.Rows[2].HeaderCell.Value = "Id";
            dataGridView1.Rows[3].HeaderCell.Value = "Name";
            dataGridView1.Rows[4].HeaderCell.Value = "Adress";
        }
        protected void buttonNext_Click_Button()
        {
            if(houses != null && houses?.Count()!=zeroElements)
            {
                theLastIndex = houses.Count() - 1;
                if (index == theLastIndex)
                {
                    MessageBox.Show("This is the last house");
                }
                else if (index < theLastIndex)
                {
                    index++;
                }
                dataGrid.DeseralizationTheDate(houses, index);
            }
        }
        protected void buttonPreviously_Click_Button()
        {
            MessageBox.Show(houses.Count().ToString());
          if (houses != null && houses?.Count() != zeroElements)
            {
                if (index == theFirstIndex)
                {
                    MessageBox.Show("This is the first house");
                }
                else if (index > theFirstIndex)
                {
                    index--;
                }
                dataGrid.DeseralizationTheDate(houses, index);
            }
        }
        protected void DeleteButton_Click_Button()
        {
            if (houses != null && houses?.Count() != zeroElements)
            {
                houses.Remove(houses[index]);
            }
            OpenFileOrDeleteObjectDeseralization();
        }
        protected void OpenFileOrDeleteObjectDeseralization()
        {
            if (houses != null && houses?.Count()!= zeroElements)
            {
                index = theFirstIndex;
                dataGrid.DeseralizationTheDate(houses, index);
            }
            else
            {
                houses = null;
                index = int.MinValue;
                dataGridView1[0, 0].Value = "";
                dataGridView1[0, 1].Value = "";
                dataGridView1[0, 2].Value = "";
                dataGridView1[0, 3].Value = "";
                dataGridView1[0, 4].Value = "";
            }
        }
        protected void Edit_Click_Button()
        {

            if (houses != null && houses?.Count()!= zeroElements)
            {
                formData = new EditHouse(ref houses, dataGrid, "Change the data to edit a house", dataGridView1, index, Type());
                formData.Show();
            }
            else
            {
                MessageBox.Show("No elements :(");
            }
        }
        protected SimilarElementsMainFormAndSearchForm Type()
        {
            return this;
        }
        public void GetList(List<House> house)
        {
            houses = house;
        }
        public void GetIndex(int ind)
        {
            index = ind;
        }
    }
}
