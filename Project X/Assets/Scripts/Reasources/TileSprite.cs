using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[Serializable]
public class TileSprite : MonoBehaviour {

	public string Name;
	public Sprite TileImage;
	public Resources TileType;

	public TileSprite(){
		Name = "unset";
		TileImage = new Sprite ();
		TileType = Resources.unset;
	}

	public TileSprite(string name, Sprite tileImage, Resources tile){
		Name = name;
		TileImage = tileImage;
		TileType = tile;
	}

}
