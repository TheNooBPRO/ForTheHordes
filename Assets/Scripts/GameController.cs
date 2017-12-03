using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	static int dominance, influence, conscientiousness, steadiness;
	// Use this for initialization
	void Start () {
		dominance = 0;
		influence = 0;
		conscientiousness = 0;
		steadiness = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void incrDominance(){
		dominance += 1;
		Debug.Log ("Dominance: "+dominance);
	}
	public void incrInfluence(){
		influence += 1;
		Debug.Log ("Influence: "+influence);
	}
	public void incrConscientiousness(){
		conscientiousness += 1;
		Debug.Log ("Conscientiousness: "+conscientiousness);
	}
	public void incrSteadiness(){
		steadiness += 1;
		Debug.Log ("Steadiness: "+steadiness);
	}


	public void decDominance(){
		dominance -= 1;
		Debug.Log ("Dominance: "+dominance);
	}
	public void decInfluence(){
		influence -= 1;
		Debug.Log ("Influence: "+influence);
	}
	public void decConscientiousness(){
		conscientiousness -= 1;
		Debug.Log ("Conscientiousness: "+conscientiousness);
	}
	public void decSteadiness(){
		steadiness -= 1;
		Debug.Log ("Steadiness: "+steadiness);
	}
}
