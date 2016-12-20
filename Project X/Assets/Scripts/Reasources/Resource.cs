using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Test{
	
}

public class Resource : MonoBehaviour {
	public enum Resources {iron, gold, silver, cobalt, nickel, titanium, magnesium, sodium, phosphorus, water, oxygen, nitrogen};
	//public Resources type;
	public Resources type;
	public int value;
	public int weight;
	public Sprite[] resourceTexture;

	// Use this for initialization
	public Resource(Resources type) {
		this.type = type;

		switch (this.type){

		case Resources.iron:{
				this.Iron();
				break;
			}

		case Resources.gold:{
				this.Gold();
				break;
			}

		case Resources.silver:{
				this.Silver();
				break;
			}

		case Resources.cobalt:{
				this.Cobalt();
				break;
			}

		case Resources.nickel:{
				this.Nickel();
				break;
			}

		case Resources.titanium:{
				this.Titanium();
				break;
			}

		case Resources.magnesium:{
				this.Magnesium();
				break;
			}

		case Resources.sodium:{
				this.Sodium();
				break;
			}

		case Resources.phosphorus:{
				this.Phosphorus();
				break;
			}

		case Resources.water:{
				this.Water();
				break;
			}

		case Resources.oxygen:{
				this.Oxygen();
				break;
			}

		case Resources.nitrogen:{
				this.Nitrogen();
				break;
			}

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Iron(){
		
	}

	void Gold(){
		
	}

	void Silver(){
	
	}

	void Cobalt(){
	
	}

	void Nickel(){
	
	}

	void Titanium(){
	
	}

	void Magnesium(){
	
	}

	void Sodium(){
	
	}

	void Phosphorus(){
	
	}

	void Water(){
	
	}

	void Oxygen(){
	
	}

	void Nitrogen(){
	
	}
}
