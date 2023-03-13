using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StoreShoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Subcategorias : ControllerBase
    {
        /// <summary>
        /// Metodo para Consultar Subcategorias
        /// </summary>
        /// <returns></returns>
        [Route("ConsultarSubcategorias")]
        [HttpGet]

        public IActionResult ConsultarSubcategorias()
        {
            List<dynamic> ListaSubcategorias = new List<dynamic>();
            var SubCategory1 = new { Id = 1, name = "Deportivos" };
            var SubCategory2 = new { Id = 2, name = "Formales" };
            var SubCategory3 = new { Id = 3, name = "Casuales" };
            var SubCategory4 = new { Id = 4, name = "Cross" };

            ListaSubcategorias.Add(SubCategory1);
            ListaSubcategorias.Add(SubCategory2);
            ListaSubcategorias.Add(SubCategory3);
            ListaSubcategorias.Add(SubCategory4);

            return Ok(ListaSubcategorias);
        }
        /// <summary>
        /// Metodo para consultar una Subcategoria
        /// </summary>
        /// <param name="idsubcategoria"></param>
        /// <returns></returns>
        [Route("ConsultarSubcategoria/{idsubcategoria}")]
        [HttpGet]

        public IActionResult ConsultarSubcategoria(int idsubcategoria)
        {
            var Subcategorial = new { Id = idsubcategoria, name = "Deportivos" };
            return Ok(Subcategorial);
        }
    }

}


