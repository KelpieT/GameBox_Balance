using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Balance0 //Hardcode
{
	public class Player : MonoBehaviour
	{
		Enemy enemy;
		private void Attack1()
		{
			enemy.TakeDamage();
		}
		private void Attack2()
		{
			enemy.TakeDamage(10);
		}

	}
}
