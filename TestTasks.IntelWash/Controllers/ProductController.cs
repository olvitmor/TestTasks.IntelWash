using Microsoft.AspNetCore.Mvc;
using TestTasks.IntelWash.Interfaces;

namespace TestTasks.IntelWash.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        #region Fields
        private IProductStorage _storage;
        #endregion

        #region Constructors
        public ProductController(IProductStorage storage)
        {
            _storage = storage;
        }
        #endregion

        #region Actions
        /// <summary>
        /// Получение списка продуктов
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetList()
        {
            var res = _storage.GetList();
            return Ok(res);
        }
        #endregion

        #region Methods

        #endregion
    }
}
