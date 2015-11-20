using System;
using System.Runtime.Serialization;

namespace proiectPSSC
{
    public class NoteInsuficienteException : Exception
    {

        public NoteInsuficienteException(int _nrnote)
        {
            if (_nrnote < 2)
                Console.Write("Nu se poate face media!");
        }
    }
}