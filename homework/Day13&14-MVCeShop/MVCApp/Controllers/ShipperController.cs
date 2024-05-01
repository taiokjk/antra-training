using AutoMapper;
using Core.Interfaces.Services;
using Core.Models.Request;
using Core.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class ShipperController : Controller
    {
        private readonly IShipperService _shipperService;
        private readonly IMapper _mapper;

        public ShipperController(IShipperService s, IMapper m)
        {
            _shipperService = s;
            _mapper = m;
        }

        public IActionResult Index()
        {
            var shippers = _shipperService.GetAll();

            return View(shippers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ShipperRequestModel shipper)
        {
            if (ModelState.IsValid)
            {
                _shipperService.Create(shipper);

                return RedirectToAction("Index");
            }

            return View(shipper);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = _shipperService.GetById(id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(ShipperResponseModel shipper)
        {
            var item = _shipperService.Delete(shipper.Id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _shipperService.GetById(id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(ShipperResponseModel shipper)
        {
            if (ModelState.IsValid)
            {
                var r = _mapper.Map<ShipperRequestModel>(shipper);

                _shipperService.Update(r);

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
