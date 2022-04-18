using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Balance3 //ScriptableObjects
{
	public class Player : MonoBehaviour
	{
		public void TakeDamage(int damage) 
        { 
            Debug.Log(string.Format("TakeDamage {0}", damage));
        }
	}
}
