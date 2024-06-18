using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class Validation
    {
        public bool onlyNumbers(string cadena)
        {
            bool isNumber = int.TryParse(cadena, out _);

            if (isNumber)
                return false;

            return true;
        }

        public bool isEmpty(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
                return true;

            return false;
        }

        public bool onlyLetters(string cadena)
        {
            foreach(char c in cadena)
            {
                if (char.IsDigit(c))
                    return true;
            }

            return false;
        }

    }
}
