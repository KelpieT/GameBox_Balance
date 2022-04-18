using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Balance4
{
	public class JSONHandler : ITextHandler
	{
		private string json;

		public JSONHandler(string json)
		{
			this.json = json;
		}

		public ObstacleDataBalance GetObstacleBalance()
		{
			ObstacleDataBalance obstacleDataBalance = JsonUtility.FromJson<ObstacleDataBalance>(json);
			return obstacleDataBalance;
		}
	}
}
