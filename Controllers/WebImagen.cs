using System;

namespace enigmaBilleteras.Controllers
{
    internal class WebImagen
    {
        private object inputStream;

        public WebImagen(object inputStream)
        {
            this.inputStream = inputStream;
        }

        internal byte[] GetBytes()
        {
            throw new NotImplementedException();
        }
    }
}