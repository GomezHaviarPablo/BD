using System;
using System.Collections.Generic;
using System.Text;

namespace school
{
    class States
    {
        private int id;
        private int id_countries;
        private string name;
        public States() { }

        public States(int id, int id_countries, string name)
        {
            this.id = id;
            this.id_countries = id_countries;
            this.name = name;
            
        }
        public int Id { get => id; set => id = value; }
        public int Id_countries { get => id_countries; set => id_countries = value; }
        public string Name { get => name; set => name = value; }
    }
}
