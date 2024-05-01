using AutoMapper;
using Core.Interfaces.Services;
using Core.Models.Request;
using Core.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class RegionController : Controller
    {
        private readonly IRegionService _regionService;
        private readonly IMapper _mapper;

        public RegionController(IRegionService r, IMapper m)
        {
            _regionService = r;
            _mapper = m;
        }

        public IActionResult Index()
        {
            var regions = _regionService.GetAll();

            return View(regions);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RegionRequestModel region)
        {
            if (ModelState.IsValid)
            {
                _regionService.Create(region);

                return RedirectToAction("Index");
            }

            return View(region);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = _regionService.GetById(id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(RegionResponseModel region)
        {
            var item = _regionService.Delete(region.Id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _regionService.GetById(id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(RegionResponseModel region)
        {
            if (ModelState.IsValid)
            {
                var r = _mapper.Map<RegionRequestModel>(region);

                _regionService.Update(r);

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
