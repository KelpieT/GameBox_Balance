using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Balance4
{


	[System.Serializable]
	public class TSVHandler : ITextHandler
	{
		private string tsv;

		public TSVHandler(string tsv)
		{
			this.tsv = tsv;
		}

		public ObstacleDataBalance GetObstacleBalance()
		{
			List<ObstacleData> temp = new List<ObstacleData>();
			string[] lines = tsv.Split('\n');
			for (int i = 1; i < lines.Length; i++)
			{
				string[] data = lines[i].Split('\t');
				ObstacleData obstacleData = new ObstacleData();
				obstacleData.id = data[0];
				obstacleData.damage = int.Parse(data[1]);
				temp.Add(obstacleData);
			}
			ObstacleDataBalance obstacleDataBalance = new ObstacleDataBalance();
			obstacleDataBalance.obstacles = temp;
			return obstacleDataBalance;
		}
	}
}
