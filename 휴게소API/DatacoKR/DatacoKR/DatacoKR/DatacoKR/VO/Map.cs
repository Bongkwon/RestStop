using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatacoKR
{
    public class Map
    {
        private string address_name;
        private int id;
        private string phone;
        private string place_name;
        private string place_url;
        private string x;
        private string y;
        public Map()
        {

        }

        public string Address_name { get => address_name; set => address_name = value; }
        public int Id { get => id; set => id = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Place_name { get => place_name; set => place_name = value; }
        public string Place_url { get => place_url; set => place_url = value; }
        public string X { get => x; set => x = value; }
        public string Y { get => y; set => y = value; }
        
    }
}
