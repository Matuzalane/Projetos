using Microsoft.AspNetCore.Mvc;
using web_center_distribuidora.Context;

namespace web_center_distribuidora.Controllers
{
    public class ProductCategories : ControllerBase
    {
        private readonly DefaultContext _context;
        private readonly CrmContext _crmContext;

        public ProductCategories(DefaultContext context, CrmContext crmContext)
        {
            _context = context;
            _crmContext = crmContext;
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            var context = _context.Grupos.ToList();

            return Ok(context);
        }
    }
}