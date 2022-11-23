using System;
using System.Collections.Generic;
using Models;

namespace Data
{
    public static class Database
    {
        public static IList<Voter> VotersTable { get; set; } = new List< Voter > ();
        public static IList<Candidate> CandidateTable { get; set; } = new List<Candidate>();

        public static IList<Election> ElectionTable { get; set; } = new List<Election>();

        public static IList<Party> PartyTable { get; set; } = new List<Party>();
        public static IList<PollingUnit> PollingTable { get; set; } = new List<PollingUnit>();


    }
}
