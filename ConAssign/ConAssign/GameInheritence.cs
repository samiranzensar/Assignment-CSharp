using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConAssign
{
	class Game
	{
		public int players;
		public string country;
		DateTime dob = new DateTime(2007,1,1);
		public int Players
		{
			get
			{
				return players;
			}
			set
			{
				players = value;
			}
		}

		public string Country
		{
			get
			{
				return country;
			}
			set
			{
				country = value;
			}
		}
		public Game() { }
		public Game(int _players, string _country)
		{

		}

		public void Worldcup(string name)
		{
			Console.WriteLine("{0} have Own Cricket WorldCup: {1}", name, dob.Year);
		}
	}

	class Cricket:Game
	{
		public string coachName;
		public string CoachName 
		{
			get
			{
				return coachName;
			}
			set
			{
				coachName = value;
			}
		}

		public Cricket() { }
		public Cricket(int _players, string _country, string _coachName) : base(_players, _country)
		{
			CoachName = _coachName;
			Players = _players;
			Country = _country;
		}
	}

	class Football : Game
	{
		public string leagueName;
		public string LeagueName
		{
			get
			{
				return leagueName;
			}
			set
			{
				leagueName = value;
			}
		}

		public Football() { }
		public Football(int _players, string _country, string _leagueName) : base(_players, _country)
		{
			LeagueName = _leagueName;
			Players = _players;
			Country = _country;
		}
	}

	internal class ShowGameDetails
	{
		public void ShowCricketDetails(Cricket obj)
		{
			Console.WriteLine("Country: {0} No of Players : {1} Coach Name: {2}",obj.Country,obj.Players,obj.CoachName);
		}
		public void ShowFootBallDetails(Football obj)
		{
			Console.WriteLine("Country: {0} No of Players : {1} League Name: {2}", obj.Country, obj.Players, obj.LeagueName);
		}

	}
	class GameInheritence
	{
		static void Main(string[] args)
		{
			Cricket India = new Cricket(11, "India", "John Wright");
			Cricket Australia = new Cricket(11, "Australia", "John Buchanan");

			Football Spain = new Football(14, "Spain", "Spanish League");
			Football England = new Football(13, "England", "English Premiere League");

			ShowGameDetails sh = new ShowGameDetails();
			Console.WriteLine("-----------------------Cricket Information-----------------------");
			sh.ShowCricketDetails(India);
			sh.ShowCricketDetails(Australia);
			Console.WriteLine();
			Console.WriteLine("-----------------------Football Information-----------------------");
			
			sh.ShowFootBallDetails(Spain);
			sh.ShowFootBallDetails(England);
			Console.WriteLine();
			Console.WriteLine();

			Game gm = new Game();
			gm.Worldcup("Australia");
			gm.Worldcup("Spain");
		}
	}
}
