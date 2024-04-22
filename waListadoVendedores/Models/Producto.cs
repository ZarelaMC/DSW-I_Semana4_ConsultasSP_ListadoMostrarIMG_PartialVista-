using System.ComponentModel;

namespace waListadoVendedores.Models
{
    public class Producto
    {
        [DisplayName("CÓDIGO")]
        public int ide_pro { get; set; }

        [DisplayName("DESCRIPCIÓN")]
        public string des_pro { get; set; }

        [DisplayName("PRECIO")]
        public Double pre_pro { get; set; }

        [DisplayName("STOCK ACTUAL")]
        public int sac_pro { get; set; }

        [DisplayName("STOCK MÍNIMO")]
        public int smi_pro { get; set; }

        [DisplayName("TIPO UNIDAD")]
        public string uni_pro { get; set; }

        [DisplayName("FOTO")]
        public string fot_pro { get; set; }
    }
}
