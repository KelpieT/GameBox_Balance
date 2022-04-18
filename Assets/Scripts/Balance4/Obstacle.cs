using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Balance4
{
	public class Obstacle : MonoBehaviour
	{
		[SerializeField] private string id;
		private ObstacleData obstacleData;
		private void OnTriggerEnter(Collider other)
		{
			Player player = other.GetComponent<Player>();

			player?.TakeDamage(obstacleData.damage);

		}
	}
}
