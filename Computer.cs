using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRockPaperScissors
{
	public class Computer
	{
		public string Selection { get; set; }
		public Computer() 
		{
			Selection = GetSelection();
		}
		private string GetSelection()
		{
			Random rnd = new Random();
			int randomSelection = rnd.Next(3);
			if(randomSelection == 0)
			{
				return "Rock";
			}
			else if (randomSelection == 1)
			{
				return "Paper";
			}
            else
            {
				return "Scissors";
            }
        }

	}
}
