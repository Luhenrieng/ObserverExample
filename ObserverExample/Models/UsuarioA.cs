using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample.Models
{
    internal class UsuarioA : IObserver<Email>
    {
        public IDisposable _disposer;

        public UsuarioA(IObservable<Email> controladorEmail)
        {
            _disposer = controladorEmail.Subscribe(this);
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Email value)
        {
            Console.WriteLine(value.Descricao + "A");
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }

    internal class UsuarioB : IObserver<Email>
    {
        public IDisposable _disposer;

        public UsuarioB(IObservable<Email> controladorEmail)
        {
            _disposer = controladorEmail.Subscribe(this);
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Email value)
        {
            Console.WriteLine(value.Descricao + "B");
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }

    internal class UsuarioC : IObserver<Email>
    {
        public IDisposable _disposer;

        public UsuarioC(IObservable<Email> controladorEmail)
        {
            _disposer = controladorEmail.Subscribe(this);
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Email value)
        {
            Console.WriteLine(value.Descricao + "C");
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }

    
}
