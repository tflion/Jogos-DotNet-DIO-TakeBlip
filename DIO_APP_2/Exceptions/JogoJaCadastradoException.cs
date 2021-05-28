using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_APP_2.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException()
            : base("Este jogo ja está cadastrado")
        { }
    }
}
