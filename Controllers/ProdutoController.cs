using Microsoft.AspNetCore.Mvc;
using Revisao_Aula7_MVC.Models;

namespace Revisao_Aula7_MVC.Controllers
{
	public class ProdutoController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			var produtos = new[]
			{
				new Produto { Id = 1, Nome = "Caneta", Preco = 2 },
				new Produto { Id = 2, Nome = "Lápis", Preco = 1 },
				new Produto { Id = 3, Nome = "Caderno", Preco = 10 }
			}.ToList();

			return View(produtos);
		}
	}
}
