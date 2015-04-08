using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication9
{
	public class GameModel
	{
		private readonly string _gamename;
		private readonly int _maxtime;
        private readonly int _pointWin;
        private readonly int _pointDraw;
        private readonly int _pointLose;


        public GameModel(string inputName,int maxtime, int win, int loss, int draw)
    {
            _gamename = inputName;
            _maxtime = maxtime;
            _pointDraw = draw;
            _pointLose = loss;
            _pointWin = win;
    }
      
        public string GameName { get { return _gamename; } }

        public int MaxTime { get { return _maxtime; } }  

        public int PointWin { get { return _pointWin; } }

       
        public int PointDraw { get { return _pointDraw; } }

       
        public int PointLose { get { return _pointLose; } }

		public void AddNewGame()
		{
			throw new NotImplementedException();
		}
	}
}
