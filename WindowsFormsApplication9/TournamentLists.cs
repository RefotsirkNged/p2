using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication9
{
    public class TournamentLists
    {
        private List<List<TeamModel>> _groupList = new List<List<TeamModel>>();
        private List<MatchModel> _matchList = new List<MatchModel>();
        private List<TeamModel> _teamList = new List<TeamModel>();
        private List<TeamModel> _remainingteamList = new List<TeamModel>();

        public List<List<TeamModel>> GroupList
        {
            get { return _groupList; }
            set { _groupList = value; }
        }

        public List<MatchModel> MatchList
        {
            get { return _matchList; }
            set { _matchList = value; }
        }

        public List<TeamModel> TeamList
        {
            get { return _teamList; }
            set { _teamList = value; }
        }

        public List<TeamModel> RemainingTeamList
        {
            get { return _remainingteamList; }
            set { _remainingteamList = value; }
        }
    }
}
