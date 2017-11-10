using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLogic : MonoBehaviour { 
	//I made a serializefield for this and we might want to consider making rows and coloumns public fields.
	//Did this because I was interested and can change this later on.  I believe this makes things easier to test.
	[SerializeField]
	private int rows;
	[SerializeField]
	private int columns;
	[SerializeField]
	private Sprite tile;

	private Sprite[,] mapTiles;
	private SpriteRenderer spriteR;

	// Use this for initialization
	void Start () {
		//2D array to store the tiles and use them when necessary
		Sprite[,] mapTiles = new Sprite[rows,columns];
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < columns; j++) {
				mapTiles [i,j] = tile;
			}
		}
		//initialize the tile sprite into the 2D array.  Can update for more varied map tiles later
		spriteR = gameObject.GetComponent<SpriteRenderer>();
		//mapTiles = Resources.LoadAll<Sprite>(tile);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
