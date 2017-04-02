using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor; // Contains the PrefabUtility class.

public class God : MonoBehaviour {

	public Transform env;
	public Transform brick;
	public Transform food;

	public GameObject tosave;

	[MenuItem ("My Project/Create Simple Prefab")]
	 void saveEnv()
	{
		PrefabUtility.CreatePrefab("Assets/Prefabs/Whatever.prefab", 
			tosave);
	}

	void putOnGround(Transform obj, int quant, float y) {

		for (int i = 0; i < quant; i++) {
			Instantiate(obj, new Vector3(getGoodRand(), y, getGoodRand()), Quaternion.identity, env);

		}
	}

	void Start() {
		putOnGround (brick, 30, 0.5f);
		putOnGround (food, 60, 0);
		saveEnv ();
	}

	int getGoodRand() {
		return Random.Range (-25, 25);
	}

}