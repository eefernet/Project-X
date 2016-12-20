using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[Serializable]
public class TileSprite : MonoBehaviour {

	public string Name;
	public Sprite TileImage;
	public TerrainTypes TileType;

	public TileSprite(){
		Name = "unset";
		TileImage = new Sprite ();
		TileType = TerrainTypes.unset;
	}

	public TileSprite(string name, Sprite tileImage, TerrainTypes tile){
		Name = name;
		TileImage = tileImage;
		TileType = tile;
	}
}
