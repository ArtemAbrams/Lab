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
        public AddHouse(ref List<House> houses, DeseralizationToDataGrid dataGrid, string name, SimilarElementsMainFormAndSearchForm menu) : base(ref houses, dataGrid, name, menu)
        {
        }
        protected override void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (CheckDate())
            {
                Helper.CreateHouse(ref houses, PublishingHouseIdBox, TitleBox, IdBox, NameBox, AdressBox);
                menu.GetIndex(houses.Count()-1);
                dataGrid.DeseralizationTheDate(houses, houses.Count() - 1);
                Close();
            }
        }
    }
}
