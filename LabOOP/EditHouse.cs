using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class EditHouse : formForData
    {
        DataGridView dataGridView;
        int index;
        public EditHouse(List<House> houses, DeseralizationToDataGrid dataGrid, string name, DataGridView dataGridView, int index, SimilarElementsMainFormAndSearchForm menu) : base(houses, dataGrid, name, menu)
        {
            this.dataGridView = dataGridView;
            InitializationHouseInTextBoxs();
            this.index = index; 
        }
        public void InitializationHouseInTextBoxs()
        {
           PublishingHouseIdBox.Text = dataGridView[0,0].Value.ToString();
           TitleBox.Text = dataGridView[0,1].Value.ToString();
           IdBox.Text = dataGridView[0,2].Value.ToString();
           NameBox.Text = dataGridView[0, 3].Value.ToString();
           AdressBox.Text = dataGridView[0,4].Value.ToString();
        }
        protected override void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (CheckDate())
            {
                houses[index].PublishingHouseId = uint.Parse(PublishingHouseIdBox.Text);
                houses[index].Title = TitleBox.Text;
                houses[index].PublishingHouse.Id=uint.Parse(IdBox.Text);
                houses[index].PublishingHouse.Name=NameBox.Text;
                houses[index].PublishingHouse.Adress = AdressBox.Text;
                dataGrid.DeseralizationTheDate(houses, index);
                Close();
            }
        }
    }
}
