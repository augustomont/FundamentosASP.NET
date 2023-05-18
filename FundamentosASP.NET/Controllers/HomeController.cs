using FundamentosASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FundamentosASP.NET.Controllers
{
    //Ela quem Controla e Gerencia as informações e processos entre a Model e a View
    public class HomeController : Controller //classe gerada pelo ASP.NET para controlar todas as Actions \\ Uma CLasse pode ter varias Actions
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

            //Action = Method. Ações são executadas dentro da Classe
        public IActionResult Index() //Essa é a Action que fica na home(pegina inicial). toda vez que a pagina inicial abre. é feita uma chamada dessa Action
        {

            HomeModel home = new HomeModel(); //Aqui eu chamo a Model que eu criei. Salvo dentro de uma variavel home.
            home.Nome = "Augusto"; //Agora, sempre que eu chamar a variavel home. com a extensão Nome ou Email, vai aparecer o valor que eu defini aqui
            home.Email = "augusto@augusto.com";
            return View(home);// aqui voce coloca a variavel home dentro da View, pra ela servir de parametro. Toda vez que Index for chamado, vai retornar a View com parametro home

            /*Resumo do que foi feito
             * 1 - Criei uma Model (modelo) - HomeModel.cs
             * 2 - Joguei a Model dentro do Controlador. - HomeController.cs
             * 3 - Defini os parametros que a Controller vai jogar para a View
             */

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