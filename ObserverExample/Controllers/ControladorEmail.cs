using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverExample.Models;

namespace ObserverExample.Controllers
{
    internal class ControladorEmail : IObservable<Email>
    {
        public List<IObserver<Email>> _usuarios;
        public Email _email;

        public ControladorEmail(Email email)
        {
            _usuarios = new List<IObserver<Email>>();
            _email = email;
        }

        public IDisposable Subscribe(IObserver<Email> usuario)
        {
            if (!_usuarios.Contains(usuario))
            {
                _usuarios.Add(usuario);
            }

            return new Disposer(_usuarios, usuario);
        }

        public void EnviarEmail()
        {
            _email.Descricao = "Email enviado para o usuário";

            foreach (IObserver<Email> usuario in _usuarios)
            {
                usuario.OnNext(_email);
            }
        }
    }
}
