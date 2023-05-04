using Microsoft.AspNetCore.Mvc;

namespace FIAPSmartCity.Controllers
{
    public class TipoProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // ERRADO!!!!!!!!!!!!!!!
        [HttpPost]
        public void IActionResultCadastrar(Models.TipoProduto tipoProduto) 
        {
            // Validando o campo descrição
            if (string.IsNullOrEmpty (tipoProduto.DescricaoTipo) )
            {
                // Adicionando a mensagem de Erro para descrição em branco
                ModelState.AddModelError("Descrição", "Descrição obrigatória!");
            }

            if (ModelState.IsValid)
            {
                // Simila que os dados foram gravados.
                System.Diagnostics.Debug.Print("Descrição " + tipoProduto.DescricaoTipo);
                System.Diagnostics.Debug.Print("Comercializado: " + tipoProduto.Comercializado);
                System.Diagnostics.Debug.Print("Gravando o Tipo de Produto");

                // return RedirectToAction("Index", "TipoProduto");
                // Encontrou um erro no preenchimento do campo descrição
            } else
            {
                // retorna para tela do formulário
                // return View(tipoProduto);
            }
        }
    }
}
