using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class SearchForm : SimilarElementsMainFormAndSearchForm
    {
        List<House>? house = new List<House>();
        Menu menu;
        DeseralizationToDataGrid dataGridMenu;
        LinqClass linqClass;
        public SearchForm(List<House> houses, Menu menu, DeseralizationToDataGrid dataGridMenu)
        {
            this.dataGridMenu = dataGridMenu;
            house = houses;
            this.menu = menu;   
            InitializeComponent();
            InitializeDataGridView(dataGridView);
            dataGrid = new DeseralizationToDataGrid(dataGridView);
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            if(houses!=null)
            {
                Edit_Click_Button();
                int indexFind = house.IndexOf(houses[index]);
                house[indexFind] = houses[index];
                MenuDataGrid();
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            house?.Remove(houses?[index]);
            if (house?.Count == zeroElements)
            {
                house = null;
            }
            DeleteButton_Click_Button();
            MenuDataGrid();
        }
        private void buttonPreviously_Click(object sender, EventArgs e)
        {
            buttonPreviously_Click_Button();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonNext_Click_Button();
        }
        private void SeacrhButton_Click(object sender, EventArgs e)
        {
            houses = new List<House>();
            linqClass = new LinqClass(house);
            linqClass.TitleSearch(TitleBox, ref houses);
            linqClass.IdSearch(IdBox, ref houses);
            linqClass.AdressSearch(AdressBox, ref houses);
            if(houses != null && houses.Count() !=0)
            {
                dataGrid?.DeseralizationTheDate(houses, theFirstIndex);
                index = theFirstIndex;
            }
            else
            {
                OpenFileOrDeleteObjectDeseralization();
                MessageBox.Show("Search showed that there are no such elements");
            }

        }
        private void MenuDataGrid()
        {
            int indexFrom = house?.Count() - 1 ?? int.MinValue;
            menu.GetIndex(indexFrom);
            dataGridMenu.DeseralizationTheDate(house, indexFrom);
        }
        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
