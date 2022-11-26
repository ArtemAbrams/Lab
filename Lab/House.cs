using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab
{
    public class House
    {
        public uint PublishingHouseId { get; set; }

        public string? Title { get; set; }

        public CPublishingHouse? PublishingHouse { get; set; }
        public House(uint publishingHouseId, string title, uint id, string name, string adress)
        {
            PublishingHouseId = publishingHouseId;
            Title = title;
            PublishingHouse = new CPublishingHouse();
            PublishingHouse.Id = id;
            PublishingHouse.Name = name;
            PublishingHouse.Adress = adress;
        }
    }
    public class CPublishingHouse
    {
        public uint Id { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
    }
}
