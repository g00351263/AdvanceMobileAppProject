using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLite.Net.Attributes;

namespace App5.Models
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
