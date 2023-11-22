using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUI.Models;
using TUI.Repositories;

namespace TUI.Services
{
    public class VacationService
    {
        private VacationDAO vacationDAO;
        public VacationService()

        {// later oplossen via DI
            vacationDAO = new VacationDAO();
        }

        public IEnumerable<Vacation> GetAll(CountryType type)
        {
            return vacationDAO.GetAll(type);
        }
    }
}
