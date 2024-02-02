using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities.Notifications
{
    public class Notes
    {
        #region Contructor
        public Notes() 
        {
            Notefication = new List<Notes>();
        }
        #endregion

        [NotMapped]
        public string NameProperty { get; set; }

        [NotMapped]
        public string Mesage { get; set; }

        [NotMapped]
        public List<Notes> Notefication { get; set; }

        public bool ValidatePropString(string valor, string nameProperty)
        {
            if(string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notefication.Add(new Notes
                {
                    Mesage = "Campo Obrigatório",
                    NameProperty = nameProperty,
                });
            }
            return true;
        }
    }
}
