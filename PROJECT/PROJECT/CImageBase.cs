using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class CImageBase : IDisposable //part of .NET architecture helps to clean up objects we create
    {
        bool disposed = false;
        Bitmap _bitmap;
        private int X; // koga si vnatre vo igrata vo meni ne vazat
        private int Y;

        public int Left { get { return X; } set { X = value; } } //za primer koga si vo eni
        public int Top { get { return Y; } set { Y = value; } }

        public CImageBase(Bitmap _resouce)
        {
            _bitmap = new Bitmap(_resouce);
        }
        public void DrawImage(Graphics gfx)
        {
            gfx.DrawImage(_bitmap, X, Y);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                _bitmap.Dispose();
            }
            disposed = true;
        }

    }
}
