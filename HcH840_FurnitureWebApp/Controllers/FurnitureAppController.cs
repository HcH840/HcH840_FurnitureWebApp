using Microsoft.AspNetCore.Mvc;
using HcH840_FurnitureWebApp.Model; // Furniture class is used there according to its namespace
using System.Linq.Expressions; // Using directives outside the namespace

namespace HcH840_FurnitureWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FurnitureAppController : ControllerBase
    {
        public static List<Furniture> frts = new(); // create new Furniture Arraylist with <>
        private readonly ILogger<FurnitureAppController> _logger;

        public FurnitureAppController(ILogger<FurnitureAppController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ListItems")]
        public IEnumerable<Furniture> GetItems()
        {
            return frts;
        } // List Items in the Store
        [HttpPost("CreateItem")]
        public Furniture CreateItem(string mark, string type, string year)
        {
            var numb = frts.Count() + 1; // var is used for known attribute types

            Furniture frt = new(mark, type, year);
            frts.add(frt);
            return frt;
        } // method to show new item on store
        [HttpPut("UpdateItem")]
        public void updateitem(string mark, string newtype, string newyear)
        {
            Furniture NewFrt = frts.Find(frt => frt.Mark == mark);
            if (NewFrt != null)
            {
                NewFrt.update(newtype, newyear);
            }
        } // method to modify item by mark if exists
        [HttpDelete("RemoveItem")]
        public void deleteitem(string type)
        {
            Furniture OldFrt = frts.Find(frt => frt.Type == type);
            if (OldFrt != null)
            {
                frts.remove(OldFrt);
            }
        } // method to remove item based on type if exists
    }
}
