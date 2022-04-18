using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Balance3
{
	[CreateAssetMenu(menuName = "GameData/ObstacleData")]
	public class ObstacleData : ScriptableObject
	{
		[SerializeField] private int damage;

		public int Damage { get => damage; }
	}
}
