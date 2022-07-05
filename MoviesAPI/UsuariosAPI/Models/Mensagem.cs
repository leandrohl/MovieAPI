using MimeKit;
using System.Collections.Generic;
using System.Linq;

namespace UsuariosAPI.Models
{
    public class Mensagem
    {
        public List<MailboxAddress> Destinario { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }

        public Mensagem(IEnumerable<string> destinario, 
            string assunto, int usuarioId, string codigoVerificacao)
        {
            Destinario = new List<MailboxAddress>();
            Destinario.AddRange(destinario.Select(d => new MailboxAddress(d)));
            Assunto = assunto;
            Conteudo = $"http://localhost:6000/ativa?UsuarioId={usuarioId}&CodigoDeAtivacao={codigoVerificacao}";
        }
    }
}
