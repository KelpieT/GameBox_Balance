using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Balance1 //Hardcode
{
	public class Player : MonoBehaviour
	{
		Enemy enemy;
		private int damage = 10;
		private void Attack()
		{
			enemy.TakeDamage(damage);
		}
	}
}
