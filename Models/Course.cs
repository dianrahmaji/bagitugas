using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace BagiTugas.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public string Materi { get; set; }
        public string Link { get; set; }
        public float Reward { get; set; }
    }
}