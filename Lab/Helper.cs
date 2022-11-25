using System;
using System.Collections.Generic;
using System.Linq;
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
            if (CheckTheData.CheckTheStringForsearch(textBox))
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
            if (CheckTheData.CheckTheStringForsearch(textBox))
            {
                if(houses != null)
                {
                    var myLinqQuery = from house in houses where house.PublishingHouse.Adress.Contains(textBox.Text) select house;
                    ValueApproritation(myLinqQuery, result, ref houseFind);
                }
            }
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
       