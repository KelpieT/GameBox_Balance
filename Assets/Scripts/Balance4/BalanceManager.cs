using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;
namespace Balance4
{
	public class BalanceManager : SingletonMono<BalanceManager>
	{
		ITextHandler textHandler;
		ObstacleDataBalance balance;
		[SerializeField] private TextAsset tsv;
		[SerializeField] private TextAsset json;
		const string link = "https://docs.google.com/spreadsheets/d/e/2PACX-1vTbXlwwAuMbiwx071ztnBqQY8SoK6dTA12cMwep-s6ODWOayxZ5nqLW1haGr9TBU3RLb1vP0ZK4D43X/pub?output=tsv";
		protected override void Awake()
		{
			base.Awake();
			Init(tsv.text);
		}

		private void Init(string text)
		{
			textHandler = new TSVHandler(text);
			balance = textHandler.GetObstacleBalance();
		}

		public ObstacleData GetObstacleData(string id)
		{
			return balance.obstacles.FirstOrDefault(x => x.id == id);
		}
		IEnumerator GetTextFromWeb()
		{
			UnityWebRequest www = UnityWebRequest.Get(link);
			yield return www.SendWebRequest();

			if (www.result != UnityWebRequest.Result.Success)
			{
				Debug.Log(www.error);
			}
			else
			{
				Init(www.downloadHandler.text);
			}
		}
	}
}
