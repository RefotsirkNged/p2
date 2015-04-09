using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    public class TournamentModel
    {
        private static string _name;
        private static int _teamAmount;
        private static string _game;
        private bool _activeTournament;
        private static string _tournamentType;
        private TournamentLists _lists;
        private static DateTime _est_starttime;
        private static DateTime _est_startdate;

        public static TournamentModel instance = null;

        public static TournamentModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TournamentModel();
                }
                return instance;
            }
        }

        public static DateTime est_StartTime
        {
            get { return _est_starttime; }
            set { _est_starttime = value; }
        }
        public static DateTime est_StartDate
        {
            get { return _est_startdate; }
            set { _est_startdate = value; }
        }

        public static string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public static int TeamAmount
        {
            get { return _teamAmount; }
            set { _teamAmount = value; }
        }

        public static string Game
        {
            get { return _game; }
            set { _game = value; }
        }

        public bool ActiveTournament
        {
            get { return _activeTournament; }
            set { _activeTournament = value; }
        }

        public static string TournamentType
        {
            get { return _tournamentType; }
            set { _tournamentType = value; }
        }
    }
}