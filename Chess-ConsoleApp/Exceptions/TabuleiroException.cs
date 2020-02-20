using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_ConsoleApp.Exceptions
{
    class TabuleiroException: ApplicationException
    {
        public TabuleiroException(string mensagem) : base(mensagem)
        {

        }

    }
}
