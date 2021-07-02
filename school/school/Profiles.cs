using System;
using System.Collections.Generic;
using System.Text;

namespace school
{
    class Profiles
    {
        private int id;
        private string description;
        private int id_users;
        private int id_cities;
        
        
        public Profiles() { }

        public Profiles(int id, string description, int id_users, int id_cities)
        {
            this.id = id;
            this.description = description;
            this.id_users = id_users;
            this.id_cities = id_cities;
            
            

        }
        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public int Id_users { get => id_users; set => id_users = value; }
        public int Id_cities { get => id_cities; set => id_cities = value; }
        
        
    }
}
