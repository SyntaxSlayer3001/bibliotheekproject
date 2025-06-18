using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_bib.Business
{
    /// <summary>
    /// Klasse die een lening (uitlening) van een boek in het systeem voorstelt.
    /// Bevat informatie over de lening-ID, startdatum en einddatum van de uitlening.
    /// </summary>
    public class Lening
    {
        // Privévelden voor de eigenschappen van de lening
        private int _leningid;
        private DateOnly _startdatum, _einddatum;

        /// <summary>
        /// De unieke ID van de lening.
        /// </summary>
        public int LeningId
        {
            get { return _leningid; }
            set { _leningid = value; }
        }

        /// <summary>
        /// De startdatum van de lening (wanneer het boek is uitgeleend).
        /// </summary>
        public DateOnly Startdatum
        {
            get { return _startdatum; }
            set { _startdatum = value; }
        }

        /// <summary>
        /// De einddatum van de lening (wanneer het boek uiterlijk terug moet zijn).
        /// </summary>
        public DateOnly Einddatum
        {
            get { return _einddatum; }
            set { _einddatum = value; }
        }

        /// <summary>
        /// Constructor waarmee een lening wordt aangemaakt met opgegeven start- en einddatum.
        /// </summary>
        /// <param name="startdatum">De startdatum van de lening.</param>
        /// <param name="einddatum">De einddatum van de lening.</param>
        public Lening(DateOnly startdatum, DateOnly einddatum)
        {
            _startdatum = startdatum;
            _einddatum = einddatum;
        }

        /// <summary>
        /// Standaard constructor. Initialiseert de lening met standaardwaarden.
        /// </summary>
        public Lening()
        {
            _leningid = 0;
            _startdatum = DateOnly.MinValue;
            _einddatum = DateOnly.MaxValue;
        }

        /// <summary>
        /// Geeft een stringrepresentatie van de lening terug, met ID en startdatum.
        /// </summary>
        /// <returns>String met lening-ID en startdatum.</returns>
        public override string ToString()
        {
            return $"Lening ID: {_leningid}, Startdatum: {_startdatum}";
        }
    }
}
