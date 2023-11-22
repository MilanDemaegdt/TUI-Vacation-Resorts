using Microsoft.AspNetCore.Mvc;
using TUI.Models;
using TUI.Services;
using TUICoreNet6.ViewModels;

namespace TUICoreNet6.Controllers
{
    public class VacationController : Controller
    {
        private VacationService vacationService;

        public VacationController()
        {
            // Later with DI
            vacationService = new VacationService();
        }

        public IActionResult Index(CountryType type)
        {


            var lstVacations = vacationService.GetAll(type);  // Domain objects
            List<VacationVM> vacationVMs = new List<VacationVM>();


            foreach (var vacation in lstVacations)
            {
                var vacationVM = new VacationVM();
                // later we use an automapper
                vacationVM.NameHotel = vacation.NameHotel;
                vacationVM.Stars = vacation.Stars;
                vacationVM.Score = vacation.Score;
                vacationVM.Photo = vacation.Photo;
                vacationVM.Benefit = vacation.Benefit;
                vacationVM.City = vacation.City;

                vacationVMs.Add(vacationVM);
            }

            ViewBag.Type = type == CountryType.Coast ? "Vlaamse Kust" : "Ardennen";
            return View(vacationVMs);
        }
    }
}
