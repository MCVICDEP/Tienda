using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tienda.Modelo;
using Tienda.Servicios;

namespace EcommerceAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        readonly InterfazProducto _InterfazProducto;

        ProductoController(InterfazProducto InterfazProducto)
        {
            _InterfazProducto = InterfazProducto;            
        }

        [HttpGet]
        [Route("GetListaCategorias")]
        public async Task<IEnumerable<Categoria>> CategoriaDetalles()
        {
            return await Task.FromResult(_InterfazProducto.GetCategorias());
        }
        //API FUNCIONAL ANTIGUO
        
        /*private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }
        [HttpGet]
        public async Task<IEnumerable<ProductoDto>> Get()
            => await _productoService.ListaProductos();

        [HttpGet("ObtenerProducto/{id}")]
        public async Task<Results<NotFound, Ok<ProductoDto>>>Get(int id)
        {
            var response = await _productoService.BuscarProducto(id);
            if (response == null) return TypedResults.NotFound();

            return TypedResults.Ok(response);
        }
        [HttpPost("EditarProducto/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Results< NotFound,Ok<ProductoDto>>> Post(int id , [FromBody] ProductoFormDto request)
        {
            var response = await _productoService.EditProducto(id, request);

            if (response == null) return TypedResults.NotFound();

            return TypedResults.Ok(response);
        }


        [HttpPost("CrearProducto")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Results<BadRequest, Ok<ProductoDto>>> Post([FromBody] ProductoFormDto request)
        {
            var response = await _productoService.GenerarProducto(request);
            if (response == null) return TypedResults.BadRequest();
            return TypedResults.Ok(response);
        }
        [HttpDelete("EliminarProducto/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<Results<NotFound, Ok<ProductoDto>>> Delete(int id)
        {
            var response = await _productoService.EliminarProducto(id);
            if (response == null) return TypedResults.NotFound();

            return TypedResults.Ok(response);
        }*/
         
         
    }
}
