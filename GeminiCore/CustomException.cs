/*
* John Gordon & Lauren Wang
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class CustomException : SystemException
    {
        public int lineNumber;
        public string Message;

        public CustomException(int value, string message)
        {
            this.lineNumber = value;
            this.Message = message;
        }
    }
}
