using System.ComponentModel;

namespace waListadoVendedores.Models
{
    public class Vendedor
    {
        [DisplayName("CÓDIGO")]
        public int ide_ven { get; set; }

        [DisplayName("VENDEDOR")]
        public string ven { get; set; }

        [DisplayName("SUELDO")]
        public Double sue_ven { get; set; }

        [DisplayName("FECHA DE INGRESO")]
        public DateTime fec_ing { get; set; }

        [DisplayName("DISTRITO")]
        public string nom_dis { get; set; }

        [DisplayName("FOTO")]
        public string fot_ven { get; set; }
    }
}
