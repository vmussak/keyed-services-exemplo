using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        //private readonly IMensagemBoasVindas _mensagemBoasVindas;
        //public ClienteController([FromKeyedServices("Padrao")] IMensagemBoasVindas mensagemBoasVindas)
        //{
        //    _mensagemBoasVindas = mensagemBoasVindas;
        //}

        [HttpGet("/api/cliente/{clienteId}/mensagem")]
        public IActionResult EnviarMensagem(IServiceProvider serviceProvider, int clienteId)
        {
            //busca o cliente pelo clienteId informado
            var cliente = new Cliente
            {
                Nome = "Vinicius Mussak",
                TipoCliente = "Premium",
                Id = clienteId
            };

            //Recupera a instância pelo tipo do cliente
            var service = serviceProvider.GetRequiredKeyedService<IMensagemBoasVindas>(cliente.TipoCliente);

            var mensagem = service.CriarMensagem(cliente);

            return Ok(mensagem);
        }

        //[HttpGet("/api/cliente/{clienteId}/mensagem-padrao")]
        //public IActionResult EnviarMensagemPadrao(int clienteId)
        //{
        //    var cliente = new Cliente
        //    {
        //        Nome = "Vinicius Mussak",
        //        TipoCliente = "Padrao",
        //        Id = clienteId
        //    };

        //    var mensagem = _mensagemBoasVindas.CriarMensagem(cliente);

        //    return Ok(mensagem);
        //}
    }
}
