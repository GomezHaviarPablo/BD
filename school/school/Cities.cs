using System;
using System.Collections.Generic;
using System.Text;

namespace school
{
    class Cities
    {
        private int id;
        private int id_states;
        private string name;
        public Cities() { }

        public Cities(int id, int id_states, string name)
        {
            this.id = id;
            this.id_states = id_states;
            this.name = name;

        }
        public int Id { get => id; set => id = value; }
        public int Id_countries { get => id_states; set => id_states = value; }
        public string Name { get => name; set => name = value; }
    }
}
