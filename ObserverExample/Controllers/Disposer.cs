using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverExample.Models;

namespace ObserverExample.Controllers
{
    internal class Disposer : IDisposable
    {
        private List<IObserver<Email>> _usuarios;
        private IObserver<Email> _usuario;

        public Disposer(List<IObserver<Email>> usuarios, IObserver<Email> usuario)
        {
            _usuarios = usuarios;
            _usuario = usuario;
        }

        public void Dispose()
        {
            if (_usuarios.Contains(_usuario))
            {
                _usuarios.Remove(_usuario);
            }
        }
    }
}
