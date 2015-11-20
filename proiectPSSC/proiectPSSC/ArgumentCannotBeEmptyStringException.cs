using System;

namespace proiectPSSC
{
    public class ArgumentCannotBeEmptyStringException : ArgumentException
    {
        public ArgumentCannotBeEmptyStringException(string parameterName)
            : base(string.Format("Argument {0} cannot be empty string.", parameterName), parameterName)
        {

        }
    }
}