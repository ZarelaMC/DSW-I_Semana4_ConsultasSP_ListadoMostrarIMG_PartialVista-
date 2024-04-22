using Microsoft.AspNetCore.Mvc;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using waListadoVendedores.Models;

namespace waListadoVendedores.Controllers
{
    public class VendedorController : Controller
    {
        //Definir la cadena de conexión
        public readonly IConfiguration configuration;
        public VendedorController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //Arreglo de vendedores
        public List<Vendedor> aVendedores()
        {
            List<Vendedor> aVendedores=new List<Vendedor>();
            SqlConnection cn = new 
                SqlConnection(configuration["ConnectionStrings:cn"]);
            cn.Open();
            SqlCommand cmd= new SqlCommand("SP_LISTAR_VENDEDORES", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                aVendedores.Add(new Vendedor()
                {
                    ide_ven = int.Parse(dr[0].ToString()),
                    ven = dr[1].ToString(),
                    sue_ven = double.Parse(dr[2].ToString()),
                    fec_ing = DateTime.Parse(dr[3].ToString()),
                    nom_dis = dr[4].ToString(),
                    fot_ven = dr[5].ToString()
                });
            }
            cn.Close();
            return aVendedores;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult listadoVendedor()
        {
            return View(aVendedores());
        }

    }
}
