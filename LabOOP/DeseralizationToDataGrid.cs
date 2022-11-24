using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class DeseralizationToDataGrid
    {
       DataGridView dataGridView1;
       public DeseralizationToDataGrid(DataGridView dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
        }
        public void DeseralizationTheDate(List<House>? house, int index)
        {
                dataGridView1[0, 0].Value = house?[index]?.PublishingHouseId?.ToString() ?? "";
                dataGridView1[0, 1].Value = house?[index]?.Title ?? "";
                dataGridView1[0, 2].Value = house?[index]?.PublishingHouse?.Id?.ToString() ?? "";
                dataGridView1[0, 3].Value = house?[index]?.PublishingHouse?.Name ?? "";
                dataGridView1[0, 4].Value = house?[index]?.PublishingHouse?.Adress ?? "";
        }
    }
}
