using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingedPlate.Domain.Entities
{
    public class RoleEntity : EntityBase
    {
        public string Name { get; set; } = string.Empty;

        public List<UserEntity> Users { get; set; } = [];
    }
}
