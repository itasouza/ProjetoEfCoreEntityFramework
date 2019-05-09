using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoEF.Database;
using ProjetoEF.Models;

namespace ProjetoEF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext database;

        public HomeController(ApplicationDbContext database)
        {
            this.database = database;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        public IActionResult Teste()
        {
            /*
            Categoria c1 = new Categoria();
            c1.nome = "Vitor";
            Categoria c2 = new Categoria();
            c2.nome = "Itamar";
            Categoria c3 = new Categoria();
            c3.nome = "Mario";

            List<Categoria> carList = new List<Categoria>();
            carList.Add(c1);
            carList.Add(c2);
            carList.Add(c3);

            database.Categoria.AddRange(carList);
            database.SaveChanges();
            */


            //Lista usando uma condição
            //var listaDeCategorias = database.Categoria.Where(cat => cat.nome.Equals("itamar")).ToList();

          

            // lista todos os dados
            var listaDeCategorias = database.Categoria.ToList();
            Console.WriteLine("================categorias==============");

            listaDeCategorias.ForEach(Categoria =>
            {
                Console.WriteLine(Categoria.ToString());
            });
            Console.WriteLine("================categorias==============");

            return Content("Dados salvos");
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
