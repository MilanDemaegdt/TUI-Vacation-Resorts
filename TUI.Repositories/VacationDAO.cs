using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUI.Models;

namespace TUI.Repositories
{
    public class VacationDAO
    {
        
        public VacationDAO()

        {
            

        }

        public IEnumerable<Vacation> GetAll(CountryType type)
        {
            List<Vacation> vacations = new List<Vacation>
            {
            new Vacation{ Id=1, NameHotel="Hotel Europe", Benefit="Familiehotel bij uitstek",
                 City ="Oostende", Country= CountryType.Coast,  Score=7.8 , Stars=4,  Photo="HotelEurope.jpg" },
            new Vacation{ Id=2, NameHotel="Domein Westhoek", Benefit="Zwembad & wellness",
                 City ="Oostduinkerke", Country= CountryType.Coast,  Score=7.3 , Stars=3,  Photo="DomeinWesthoek_Oostduinkerke.jpg" },
            new Vacation{ Id=3, NameHotel="ibis DeHaan", Benefit="Strand op 350 m",
                 City ="De Haan", Country= CountryType.Coast,  Score=8.1 , Stars=4,  Photo="ibisDeHaan_DeHaan.jpg" },
            new Vacation{ Id=4, NameHotel="C-Hotels Excelsior", Benefit="Zwembad & wellness",
                 City ="Middelkerke", Country= CountryType.Coast,  Score=8.5 , Stars=4,  Photo="C-HotelsExcelsior_Middelkerke.jpg" },
            new Vacation{ Id=5, NameHotel="abba Xalet Suites Hotel1", Benefit="Zwembad & wellness",
                 City ="La Massana", Country= CountryType.Wallonia,  Score=7.8 , Stars=1,  Photo="HotelLeValDePoix_St-Hubert.jpg" },
            new Vacation{ Id=6, NameHotel="abba Xalet Suites Hotel2", Benefit="Zwembad & wellness",
                 City ="La Massana", Country= CountryType.Wallonia,  Score=7.8 , Stars=2,  Photo="HotelRadissonBluBalmoral_Spa.jpg" },
            new Vacation{ Id=7, NameHotel="abba Xalet Suites Hotel3", Benefit="Zwembad & wellness",
                 City ="La Massana", Country= CountryType.Wallonia,  Score=7.8 , Stars=3,  Photo="HotelRadissonBluBalmoral_Spa.jpg" },
            new Vacation{ Id=8, NameHotel="abba Xalet Suites Hotel4", Benefit="Zwembad & wellness",
                 City ="La Massana", Country= CountryType.Wallonia,  Score=7.8 , Stars=4,  Photo="HotelRadissonBluBalmoral_Spa.jpg" },

            };
            return vacations.Where(a => a.Country == type); // 
        }
    }
}
