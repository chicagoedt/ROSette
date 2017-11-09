using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLogic : MonoBehaviour {
	[SerializeField] 
	int rows;
	[SerializeField]
	int coloumns;
	[SerializeField]
	Sprite tile;

	private SpriteRenderer spriteR;

	//2D array to store the tiles and use them when necessary
	Sprite[,] mapTiles = new Sprite[rows,coloumns];
	// Use this for initialization
	void Start () {
		//initialize the tile sprite into the 2D array.  Can update for more varied map tiles later
		spriteR = gameObject.GetComponent<SpriteRenderer>();
		for (int i = 0; i < rows; i++) {
			Debug.Log ("testing");
			for (int j = 0; j < coloumns; j++) {
				mapTiles [i,j] = tile;
			}
		}
		//mapTiles = Resources.LoadAll<Sprite>(tile);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
