using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace proiectPSSC
{
    class Materie
    {
        public PlainText Nume { get; internal set; }
        public Coeficient pondereEx { get; internal set; }

        private List<Student> _studentiInscrisi;
        public ReadOnlyCollection<Student> StudentiInscrisi { get { return _studentiInscrisi.AsReadOnly(); } }

        //profi
        internal Materie(PlainText nume, Coeficient pondereExam)
        {
            Contract.Requires(nume != null, "nume");
            Contract.Requires(pondereEx != null, "pondereExamen");

            Nume = nume;
            pondereEx = pondereExam;
            _studentiInscrisi = new List<Student>();
        }

        //secretariat
        internal Materie(PlainText nume, Coeficient pondereExamen, List<Student> studentiInscrisi)
            : this(nume, pondereExamen)
        {
            Contract.Requires(studentiInscrisi != null, "lista de studenti inscrisi");
            _studentiInscrisi = studentiInscrisi;
        }
    }
}
