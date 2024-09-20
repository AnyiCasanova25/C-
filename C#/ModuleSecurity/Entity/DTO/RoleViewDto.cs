using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class RoleViewDto
    {
        public int Id { get; set; }
        public bool State { get; set; }
        public int IdRole { get; set; }
        public string ? Role { get; set; }
        public int IdView { get; set; }
        public string ? View { get; set; }
    }
}
