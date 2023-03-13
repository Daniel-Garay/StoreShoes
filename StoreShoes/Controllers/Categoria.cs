using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StoreShoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Categoria : ControllerBase
    {
        /// <summary>
        /// Metodo para consultar el listado de categorias
        /// </summary>
        /// <returns></returns>
        [Route("ConsultarCategorias")]
        [HttpGet]
        public IActionResult ConsultarCategorias()
        {
            List<dynamic> Listcategorias = new List<dynamic>();
            var category1 = new { Id = 1, Branch = "Hombre" };
            var category2 = new { Id = 2, Branch = "Mujer" };
            var category3 = new { Id = 3, Branch = "Niño" };

            Listcategorias.Add(category1);
            Listcategorias.Add(category2);
            Listcategorias.Add(category3);

            return Ok(Listcategorias);
        }

        /// <summary>
        /// Metodo para consultar una categoria
        /// </summary>
        /// <param name="idCategoria"></param>
        /// <returns></returns>
        [Route("ConsultarCategoria/{idCategoria}")]
        [HttpGet]
        public IActionResult ConsultarCategoria(int idCategoria)
        {
            var Categoria1 = new { Id = idCategoria, Branch = "Hombre" };
            return Ok(Categoria1);
        }
    }
}
