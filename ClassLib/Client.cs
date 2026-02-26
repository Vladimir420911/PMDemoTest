using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Client
    {
        private int Id;
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string ImagePath { get; set; }

        public Client(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }
}
