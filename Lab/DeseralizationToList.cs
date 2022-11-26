using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab
{
    class DeseralizationToList
    {
        string filename;
        public DeseralizationToList(string filename)
        {
            this.filename = filename;
        }
        public List<House> DeseralizationFromFile()
        {
            MessageBox.Show("tut");
            try
            {
                using (var fs = new FileStream(filename, FileMode.Open))
                {
                    MessageBox.Show("tut");
                    var houses = JsonSerializer.Deserialize<List<House>>(fs);
                    return houses;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
    }
}
