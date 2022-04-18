using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Balance1 //Hardcode
{
	public class Enemy : MonoBehaviour
	{
		public void TakeDamage(int damage)
		{
			Debug.Log(string.Format("TakeDamage {0}", damage));
		}
	}
}
