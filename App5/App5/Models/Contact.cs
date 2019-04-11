﻿using SQLite;

namespace App5
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool Done { get; set; }
    }
}

