using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tiles : MonoBehaviour {

	public static List<GameObject> theTiles = new List<GameObject>();

	public List<GameObject> tilesToAdd = new List<GameObject>();

	void Start()
	{
		Tiles.theTiles.AddRange(tilesToAdd); 
	}

}
