using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication9
{
	public class MatchModel
	{
        private readonly TeamModel _team1;
        private readonly TeamModel _team2;
        private int _team1points;
        private int _team2points;
        private int _round;
     
        


        public MatchModel(TeamModel team1, TeamModel team2)
        {
            _team1 = team1;
            _team2 = team2;
            _team1points = 0;
            _team2points = 0;
        }

        public TeamModel Team1
        {
            get { return _team1;}
        }


        public TeamModel Team2
        {
            get { return _team2;}
        }

        public int Team1Points
        {
            get { return _team1points;}
            set { _team1points = value; }
        }

         public int Team2Points
        {
            get { return _team2points;}
            set {_team2points = value;}
        }

         public int Round
         {
             get { return _round; }
             set { _round = value; }
         }

  


		public void RunMatch()
		{
			throw new NotImplementedException();
		}

		public void ReMatch()
		{
			throw new NotImplementedException();
		}

		public void SkipMatch()
		{
			throw new NotImplementedException();
		}

		public void CalcResult()
		{
			throw new NotImplementedException();
		}
	}
}
