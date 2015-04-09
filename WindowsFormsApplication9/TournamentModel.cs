using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    public class TournamentModel
    {
        private string _name;
        private int _teamAmount;
        private string _game;
        private bool _activeTournament;
        private string _tournamentType;
        private TournamentLists _lists;
        private DateTime _est_starttime;
        private DateTime _est_startdate;

        public DateTime est_StartTime
        {
            get { return _est_starttime; }
            set { _est_starttime = value; }
        }
        public DateTime est_StartDate
        {
            get { return _est_startdate; }
            set { _est_startdate = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int TeamAmount
        {
            get { return _teamAmount; }
            set { _teamAmount = value; }
        }

        public string Game
        {
            get { return _game; }
            set { _game = value; }
        }

        public bool ActiveTournament
        {
            get { return _activeTournament; }
            set { _activeTournament = value; }
        }

        public string TournamentType
        {
            get { return _tournamentType; }
            set { _tournamentType = value; }
        }
    }
}
