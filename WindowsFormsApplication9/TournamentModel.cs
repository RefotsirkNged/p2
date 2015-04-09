using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class TournamentModel
    {
        private string _name;
        private int _teamAmount;
        private GameModel _game;
        private bool _activeTournament;
        private TournamentTypes _tournamentType;
        private TournamentLists _lists;

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

        public GameModel Game
        {
            get { return _game; }
            set { _game = value; }
        }

        public bool ActiveTournament
        {
            get { return _activeTournament; }
            set { _activeTournament = value; }
        }

        public enum TournamentTypes
        {
            RoundRobin,
            SingleElimination,
            DoubleElimination
        }

        public TournamentTypes TournamentType
        {
            get { return _tournamentType; }
            set { _tournamentType = value; }
        }
    }
}
