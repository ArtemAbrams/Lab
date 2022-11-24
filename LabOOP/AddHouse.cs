using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class AddHouse : formForData
    {
        List<House>? house = new List<House>();
        public AddHouse( List<House> houses, DeseralizationToDataGrid dataGrid, string name, SimilarElementsMainFormAndSearchForm menu) : base( houses, dataGrid, name, menu)
        {
        }
        protected override void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (CheckDate())
            {
                if (houses == null)
                {
                    house?.Add(new House(uint.Parse(PublishingHouseIdBox.Text), TitleBox.Text, uint.Parse(IdBox.Text), NameBox.Text, AdressBox.Text));
                    menu.GetList(house);
                    menu.GetIndex(house.Count()-1);
                    dataGrid.DeseralizationTheDate(house, house.Count() - 1);
                }
                else
                {
                    houses?.Add(new House(uint.Parse(PublishingHouseIdBox.Text), TitleBox.Text, uint.Parse(IdBox.Text), NameBox.Text, AdressBox.Text));
                    menu.GetIndex(houses.Count()-1);
                    dataGrid.DeseralizationTheDate(houses, houses.Count() - 1);
                }
                Close();
            }
        }
    }
}
