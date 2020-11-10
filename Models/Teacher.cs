using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace BagiTugas.Models
{
    public class Teacher
    {
        public class Teacher
        {
            public int Id { get; set; }
            public string Name { get; set; }
        
            public int jumlahCourse { get; set; }
            public string NUPTK { get; set; }
            public string institusi { get; set; }
        }
    }
}