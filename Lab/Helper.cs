using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Helper
    {
        private List<House>? houses;
        public Helper(List<House> houses)
        {
            this.houses = houses;
        }
        public void TitleSearch(TextBox textBox, ref List<House> houseFind)
        {
            List<House> result = new List<House>();
            if (CheckTheData.CheckTheStringForSearch(textBox))
            {
                if(houses != null)
                {
                    var myLinqQuery = from house in houses where house.Title.Contains(textBox.Text) select house;
                    ValueApproritation(myLinqQuery, result, ref houseFind);
                }    

            }
        }
        public void IdSearch(TextBox textBox, ref List<House> houseFind)
        {
            List<House> result = new List<House>();
            if (CheckTheData.CheckTheNumberForSearch(textBox))
            {
                if(houses != null)
                {
                    var myLinqQuery = from house in houses where house.PublishingHouse.Id.ToString().Contains(textBox.Text) select house;
                    ValueApproritation(myLinqQuery, result, ref houseFind);
                }
            }

        }

        public void AdressSearch(TextBox textBox, ref List<House> houseFind)
        {
            List<House> result = new List<House>();
            if (CheckTheData.CheckTheStringForSearch(textBox))
            {
                if(houses != null)
                {
                    var myLinqQuery = from house in houses where house.PublishingHouse.Adress.Contains(textBox.Text) select house;
                    ValueApproritation(myLinqQuery, result, ref houseFind);
                }
            }
        }
        public static void CreateHouse(ref List<House> houses, TextBox PublishingHouseIdBox, TextBox TitleBox, TextBox IdBox, TextBox NameBox, TextBox AdressBox)
        {
            houses.Add(new House(uint.Parse(PublishingHouseIdBox.Text), TitleBox.Text, uint.Parse(IdBox.Text), NameBox.Text, AdressBox.Text));
        }
        public static void EditHouse(ref List<House> houses, TextBox PublishingHouseIdBox, TextBox TitleBox, TextBox IdBox, TextBox NameBox, TextBox AdressBox, int index)
        {
            houses[index].PublishingHouseId = uint.Parse(PublishingHouseIdBox.Text);
            houses[index].Title = TitleBox.Text;
            houses[index].PublishingHouse.Id = uint.Parse(IdBox.Text);
            houses[index].PublishingHouse.Name = NameBox.Text;
            houses[index].PublishingHouse.Adress = AdressBox.Text;
        }
        public void ValueApproritation(dynamic myLinqQuery, List<House> result, ref List<House> houseFind)
        {
            foreach (House house in myLinqQuery)
            {
                result.Add(house);
            }
            if (result.Count == 0)
            {
                result = null;
            }
            houses = result;
            houseFind = result;
        }
   }
}
       