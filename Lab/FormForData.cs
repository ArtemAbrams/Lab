using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class formForData : Form
    {
        protected List<House>? houses;
        protected DeseralizationToDataGrid dataGrid;
        protected bool check;
        protected SimilarElementsMainFormAndSearchForm menu;
        public formForData(List<House> houses, DeseralizationToDataGrid dataGrid, string name, SimilarElementsMainFormAndSearchForm menu)
        {
            this.menu = menu;
            this.houses = houses;
            this.dataGrid = dataGrid;
            InitializeComponent();
            labelInformation.Text = name;
        }
        public bool CheckDate()
        {
            bool numberCheck = CheckTheData.CheckTheNumber(PublishingHouseIdBox) && CheckTheData.CheckTheNumber(IdBox);
            bool stingCheck = CheckTheData.CheckTheString(NameBox) && CheckTheData.CheckTheString(TitleBox) && CheckTheData.CheckTheString(AdressBox);
            return numberCheck && stingCheck;
        }
        protected virtual void ConfirmButton_Click(object sender, EventArgs e)
        {
        }
    }
}
