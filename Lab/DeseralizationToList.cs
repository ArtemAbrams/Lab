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
            try
            {
                using (var fs = new FileStream(filename, FileMode.Open))
                {
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
