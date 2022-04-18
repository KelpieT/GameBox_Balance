using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Balance4
{
	[System.Serializable]
	public class ObstacleData
	{
		public string id;
		public int damage;

	}
	[System.Serializable]
	public class ObstacleDataBalance
	{
		public List<ObstacleData> obstacles = new List<ObstacleData>();

	}
}
