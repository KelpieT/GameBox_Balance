using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Balance2 //Inspector
{
	public class Obstacle : MonoBehaviour
	{
		[SerializeField] private int damage;
		private void OnTriggerEnter(Collider other)
		{
			Player player = other.GetComponent<Player>();

			player?.TakeDamage(damage);

		}
	}
}
