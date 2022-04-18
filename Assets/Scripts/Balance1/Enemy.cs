using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Balance0 //Hardcode
{
	public class Enemy : MonoBehaviour
	{
		public void TakeDamage()
		{
			Debug.Log(string.Format("TakeDamage {0}", 10));
		}
		public void TakeDamage(int damage)
		{
			Debug.Log(string.Format("TakeDamage {0}", damage));
		}
	}
}
