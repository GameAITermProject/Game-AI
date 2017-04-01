using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class God : MonoBehaviour {

	public Transform brick;

	void Start() {
		int quant = 100;

		for (int i = 0; i < quant; i++) {
			Instantiate(brick, new Vector3(getGoodRand(), 1, getGoodRand()), Quaternion.identity);
		}
	}

	int getGoodRand() {
		return Random.Range (-25, 25);
	}

}