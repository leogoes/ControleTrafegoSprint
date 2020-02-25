using System;
using System.Collections.Generic;
using System.Text;

namespace SprintTraffic.Domain.Entities
{
    public class Squad
    {
        public int Id { get; set; }
        public int SquadNumber { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
