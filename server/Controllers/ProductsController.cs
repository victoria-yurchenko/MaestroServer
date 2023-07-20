using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Models;
using server.Models.Guitar;

namespace server.Controllers
{
    public class ProductsController : Controller
    {
        private readonly MaestroContext _context;
        private List<IProduct> _products;


        public ProductsController(MaestroContext context)
        {
            _context = context;
            _products = new List<IProduct>();
            
            //too heavy for server - controllers recreating
            //todo repository pattern

            PropertyInfo[] contextProperties = _context.GetType().GetProperties();

            foreach (PropertyInfo property in contextProperties)
            {
                foreach(IProduct product in property.GetValue(_context, null) as List<IProduct>)
                    _products.Add(product);
            }
        }

        [HttpGet]
        public ActionResult<List<IProduct>> GetProducts()
        {
            return _products;                
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IProduct>> GetProduct(int id, Category category, ProductKind kind)
        {
            switch (category)
            {
                case Category.Guitar:
                    return await GetGuitar(kind, id);
                default:
                    return NotFound();
            }
        }

        //[HttpGet("{category}")]
        //public async Task<ActionResult<Category>> GetCategories()
        //{
        //    switch )
        //    {
        //        case Category.Guitar:
        //            break;
        //        case Category.Headphones:
        //            break;
        //        case Category.Microphone:
        //            break;
        //        case Category.Percussion:
        //            break;
        //        case Category.Piano:
        //            break;
        //        case Category.StudioEquipment:
        //            break;
        //        default:
        //            break;
        //    }
        //}

        private async Task<ActionResult<IProduct>> GetGuitar(ProductKind kind, int id)
        {
            switch (kind)
            {
                case ProductKind.AcousticGuitar:
                    return Ok(_context.AcousticGuitar.ToList().Find(g => g.Id == id));
                case ProductKind.BassGuitar:
                    return NotFound();
                case ProductKind.ClassicGuitar:
                    return NotFound();
                case ProductKind.ElectricGuitar:
                    return Ok(_context.ElectricGuitar.ToList().Find(g => g.Id == id));
                case ProductKind.ElectroAcousticGuitar:
                    return NotFound();
                case ProductKind.UkuleleGuitar:
                    return NotFound();
                default:
                    return NotFound();
            }
        }
    }
}
