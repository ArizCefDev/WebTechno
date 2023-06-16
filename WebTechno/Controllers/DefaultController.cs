using Microsoft.AspNetCore.Mvc;
using WebTechno.Business.Abstract;
using WebTechno.DTO;

namespace WebTechno.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ITechnologyService _technologyService;

		public DefaultController(ITechnologyService technologyService)
		{
			_technologyService = technologyService;
		}

		public IActionResult Index()
        {
            var values = _technologyService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
		public IActionResult Add(TechnologyDTO p)
		{
            _technologyService.Insert(p);
            return RedirectToAction("Index");
		}

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _technologyService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(TechnologyDTO p)
        {
            _technologyService.Update(p);
			return RedirectToAction("Index");
		}

        public IActionResult Delete(int id)
        {
            _technologyService.Delete(id);
            return RedirectToAction("Index");
        }
	}
}
