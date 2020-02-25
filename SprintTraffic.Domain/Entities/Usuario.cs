using System;
using System.Collections.Generic;
using System.Text;

namespace SprintTraffic.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Squad Squad { get; set; }
    }
}
