using System;
using System.Threading;

namespace GOPER
{
    internal class SingleInstanceApp : IDisposable
    {
        // Mutex
        private readonly Mutex _siMutex;

        private bool _siMutexOwned;

        // Constructeur
        public SingleInstanceApp(string name)
        {
            _siMutex = new Mutex(false, name);
            _siMutexOwned = false;
        }

        // Application déjà lancée ?

        // Membre de IDisposable

        #region IDisposable Members

        public void Dispose()
        {
            // Libération du mutex si il a été acquis
            if (_siMutexOwned)
                _siMutex.ReleaseMutex();
        }

        #endregion IDisposable Members

        public bool IsRunning()
        {
            // Acquisition du mutex.
            // Si _siMutexOwned vaut true, l'application acquiert le mutex car il est "libre"
            // Sinon le mutex a déjà été acquis lors du lancement d'une instance précédente
            _siMutexOwned = _siMutex.WaitOne(0, true);
            return !(_siMutexOwned);
        }
    }
}