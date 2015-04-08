using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication9
{
    public class TeamModel
    {
        private string _teamName;
        private int _points;
        private int _wins;
        private int _ties;
        private int _losses;
        private int _matches;
        private int _group;
        private int _seeding;

        public TeamModel(string inputName)
        {
            TeamName = inputName;
        }

        public string TeamName
        {
            get { return _teamName; }
            set { _teamName = value; }
        }

        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public int Wins
        {
            get { return _wins; }
            set { _wins = value; }
        }

        public int ties
        {
            get { return _ties; }
            set { _ties = value; }
        }

        public int losses
        {
            get { return _losses; }
            set { _losses = value; }
        }

        public int matches
        {
            get { return _matches; }
            set { _matches = value; }
        }

        public int group
        {
            get { return _group; }
            set { _group = value; }
        }
        public int seeding
        {
            get { return _seeding; }
            set { _seeding = value; }
        }
    }
}
