using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLogic : MonoBehaviour { 

	//Look into tilemaps for unity to replace this quick and dirty system.


	//I made a serializefield for this and we might want to consider making rows and coloumns public fields.
	//Did this because I was interested and can change this later on.  I believe this makes things easier to test.
	[SerializeField]
	private int rows;
	[SerializeField]
	private int columns;
	[SerializeField]
	private Sprite tile;

	private Sprite[,] mapTiles;
	public SpriteRenderer spriteR;

	// Use this for initialization
	void Start () {
		//initialize the sprite renderer
		spriteR = gameObject.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
		//2D array to store the tiles and use them when necessary
		Sprite[,] mapTiles = new Sprite[rows,columns];
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < columns; j++) {
				mapTiles [i,j] = tile;

			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
