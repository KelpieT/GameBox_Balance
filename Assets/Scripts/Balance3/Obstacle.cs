using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Balance3 //ScriptableObjects
{
	public class Obstacle : MonoBehaviour
	{
		[SerializeField] private ObstacleData obstacleData;
		private void OnTriggerEnter(Collider other)
		{
			Player player = other.GetComponent<Player>();

			player?.TakeDamage(obstacleData.Damage);

		}
	}
}
