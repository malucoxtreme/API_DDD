using entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities.Entitie
{
    public class AplicationUser : IdentityUser
    {
        [Column("USR_AGE")]
        public int Idade { get; set; }

        [Column("USR_MOBILEPHONE")]
        public string celular { get; set; }

        [Column("USR_TIPE")]
        public UserType? Type { get; set; }
    }
}
