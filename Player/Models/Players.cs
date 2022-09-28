using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.Models
{
    public class Players
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Picture { get; set; }
        public string Country { get; set; }       
        public string Email { get; set; }
        public string ClubName { get; set; }
        public DateTime JoinDate { get; set; }
        public bool isContinuing { get; set; } = false;
        public string StartDate { get => this.JoinDate.ToString("yyyy-MM-dd"); }
    }
}
