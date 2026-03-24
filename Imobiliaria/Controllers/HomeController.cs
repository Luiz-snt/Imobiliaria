using System.Diagnostics;
using Imobiliaria.Models;
using Imovel;
using Microsoft.AspNetCore.Mvc;


namespace Imobiliaria.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Customer Imovel1 = new Customer
            {
                Id = 1,
                Name = "Casa de Praia",
                Tipo = TipoImovel.Casa,
                Acordo = TipoAcordo.Venda
            };
            Customer Imovel2 = new Customer
            {
                Id = 2,
                Name = "Apartamento no Centro",
                Tipo = TipoImovel.Apartamento,
                Acordo = TipoAcordo.Aluguel
            };
            Customer Imovel3 = new Customer
            {
                Id = 3,
                Name = "Casa de Campo",
                Tipo = TipoImovel.Casa,
                Acordo = TipoAcordo.Venda
            };
            Customer Imovel4 = new Customer
            {
                Id = 4,
                Name = "Apartamento com Vista para o Mar",
                Tipo = TipoImovel.Apartamento,
                Acordo = TipoAcordo.Aluguel
            };
            Customer Imovel5 = new Customer
            {
                Id = 5,
                Name = "Casa Moderna",
                Tipo = TipoImovel.Casa,
                Acordo = TipoAcordo.Venda
            };

            List<Customer> Imoveis = new List<Customer> { Imovel1, Imovel2, Imovel3, Imovel4, Imovel5 };

            return View(Imoveis);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
