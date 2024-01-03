using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IMensagemBoasVindas
    {
        string CriarMensagem(Cliente cliente);
    }

    public class MensagemBoasVindasPadrao : IMensagemBoasVindas
    {
        public string CriarMensagem(Cliente cliente)
        {
            return $"Olá, {cliente.Nome}, estamos felizes que esteja conosco!";
        }
    }

    public class MensagemBoasVindasPremium : IMensagemBoasVindas
    {
        public string CriarMensagem(Cliente cliente)
        {
            return $"Olá, {cliente.Nome}, estamos felizes que esteja conosco! Você tem 50% de desconto para a primeira compra.";
        }
    }
}
