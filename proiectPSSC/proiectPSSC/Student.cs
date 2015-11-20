using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace proiectPSSC
{
    public class Student
    {
        public NumarMatricol nrmat { get; internal set; }
        public PlainText Nume { get; internal set; }
        public Note NoteAct { get; internal set; }
        public Nota NotaEx { get; internal set; }
        public Nota Media { get; internal set; }


        internal Student(NumarMatricol nrMatricol, PlainText nume)
        {
            Contract.Requires(nrMatricol != null, "numar matricol");
            Contract.Requires(nume != null, "nume");
            nrmat = nrMatricol;
            Nume = nume;
            NoteAct = new Note();
        }
    }
}
