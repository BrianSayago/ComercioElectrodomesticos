using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AuthManager
    {
        private static AuthManager _instance;
        private int _usuarioId;

        private AuthManager() { }

        public static AuthManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AuthManager();
                }
                return _instance;
            }
        }
        public void SetUsuarioId(int usuarioId)
        {
            _usuarioId = usuarioId;
        }

        public int GetUsuarioId()
        {
            return _usuarioId;
        }
    }

}

