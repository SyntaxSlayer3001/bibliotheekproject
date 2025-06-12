using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_bib.Business
{
    public class Lening
    {
        private int _leningid;
        private DateOnly _startdatum, _einddatum;

        public int LeningId
        {
            get { return _leningid; }
            set { _leningid = value; }
        }
        public DateOnly Startdatum
        {
            get { return _startdatum; }
            set { _startdatum = value; }
        }
        public DateOnly Einddatum
            {
            get { return _einddatum; }
            set { _einddatum = value; }
        }

        public Lening(DateOnly startdatum, DateOnly einddatum)
        {
            _startdatum = startdatum;
            _einddatum = einddatum;
        }
        public Lening()
        {
            _leningid = 0;
            _startdatum = DateOnly.MinValue;
            _einddatum = DateOnly.MaxValue;
        }
        public override string ToString()
        {
            return $"Lening ID: {_leningid}, Startdatum: {_startdatum}";
        }
    }
}
