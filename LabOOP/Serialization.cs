using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab
{
    class Serialization
    {
        string path;
        public Serialization(string path)
        {
            this.path = path; 
        }
        public void Serialize(List<House>? houses)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    JsonSerializer.Serialize<List<House>>(fs, houses);
                }
                MessageBox.Show("File is save");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
