using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication9
{   public class SingleElimination
    {
    //placeholder liste
   public List<string> hold = new List<string>();

   public void sortList(){
        hold.Add ("Peter");
        hold.Add ("Mathias");
        hold.Add ("Daniel");
        hold.Add ("Kris");
        hold.Add ("Jakob");
        hold.Add ("Rasmus");
        hold.Add ("Ghost1");
        hold.Add ("Ghost2");

       int NumTeams  = hold.Count;
       List<string> sorted = new List<string>();
    
       for (int i = 0; i < NumTeams/2; i++)
			{
			 sorted.Add(hold[i]);
             sorted.Add(hold[NumTeams-i]);
  			}
}
	public SingleElimination()
        {
       
        

            int nte = 0;
            int team = 0; // team er index for hold i ovenstående array / list / collection / whatever
            int teamsLeft = Convert.ToInt32(Math.Pow(2, nte));
 
            while (teamsLeft != 1)
            {
                for (team = 0; team < (teamsLeft / 2); ++team)
                {
                    //team vs (teamsLeft - team);
                }
 
                teamsLeft = teamsLeft / 2;
            }
 
            //Og vinderen er
     }
        public CleanNumberOfTeams()
        {
            int nte = 0;
            int howManyTeams = hold().count;
 
            while (Math.Pow(2, nte) < howManyTeams)
            {
                ++nte;
            }
            TournamentCount.Text = Convert.ToString(Convert.ToInt32(Math.Pow(2, nte)));
 
            //Something der får alle holdene ind i et array / list / collection / whatever        
        }
    }
}