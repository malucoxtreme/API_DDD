using entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities.Entitie
{
    [Table("TB_NOTICIA")]
    public class News : Notes
    {
        [Column("NTC_ID")]
        public int Id { get; set; }

        [Column("NTC_TITLE")]
        [MaxLength(255)]
        public string Title { get; set; }

        [Column("NTC_INFORMATION")]
        [MaxLength(255)]
        public string Information { get; set; }

        [Column("NTC_ACTIVE")]
        public bool Active { get; set; }

        [Column("NTC_DATE_REGISTER")]
        public DateTime RegisterDate { get; set; }

        [Column("NTC_DATE_UPDATE")]
        public DateTime UpdateRegister { get; set; }

        [ForeignKey("AplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual AplicationUser AplicationUser { get; set; }
    }
}
