using System;
using System.Windows.Forms;

namespace AutoClicker
{
    internal class Clicker : IDisposable
    {
        private readonly uint buttonDownCode;
        private readonly uint buttonUpCode;
        private readonly IntPtr minecraftHandle;
        private readonly Timer timer = new Timer();

        private bool running = false;
        private bool hold = false;
        private bool disposed = false;

        public Clicker(uint buttonDownCode, uint buttonUpCode, IntPtr minecraftHandle)
        {
            this.buttonDownCode = buttonDownCode;
            this.buttonUpCode = buttonUpCode;
            this.minecraftHandle = minecraftHandle;

            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Click();
        }

        public void Start(int delay)
        {
            if(running)
            {
                throw new InvalidOperationException($"Clicker is already running. Call the Stop function first. (btnDownCode: {buttonDownCode}, btnUpCode: {buttonUpCode})");
            }

            hold = (delay == 0);

            if (hold)
            {
                Hold();
            }
            else
            {
                timer.Interval = delay;
                timer.Start();
                Click();
            }

            running = true;
        }

        public void Stop()
        {
            if(!running)
            {
                return;
            }

            if (!hold)
            {
                timer.Stop();
            }

            Release();
            running = false;
        }

        private void Hold()
        {
            Win32Api.PostMessage(minecraftHandle, buttonDownCode, IntPtr.Zero, IntPtr.Zero);
        }

        private void Release()
        {
            Win32Api.PostMessage(minecraftHandle, buttonUpCode, IntPtr.Zero, IntPtr.Zero);
        }

        private void Click()
        {
            Win32Api.PostMessage(minecraftHandle, buttonDownCode, IntPtr.Zero, IntPtr.Zero);
            Win32Api.PostMessage(minecraftHandle, buttonUpCode, IntPtr.Zero, IntPtr.Zero);
        }

        #region Dispose
        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                Stop();
                timer.Dispose();
            }

            disposed = true;
        }

        ~Clicker()
        {
            Dispose(false);
        }
        #endregion
    }
}
