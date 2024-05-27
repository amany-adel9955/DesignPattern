using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgramming
{
    internal class Ball
    {
        public int Id { get; set; }
		private Location ballLocation;

		public Location BallLocation 
		{
			get { return ballLocation ; }
			set 
			{ 
			if(ballLocation != value)
				{
					ballLocation = value;
					BallLocationChanged?.Invoke();  //  ? not to give null exception
				}
			}
		}

		public event Action BallLocationChanged;

	}
}
