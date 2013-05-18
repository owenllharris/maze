using UnityEngine;
using System.Collections;

public class TheMaze : MonoBehaviour 
{

	public int MazeWidth;
	public int MazeHeight;

	public static int mazeWidth = 3;
	public static int mazeHeight = 3;

	public static GameObject[ , ] grid;

	void Start () 
	{
		TheMaze.mazeWidth = MazeWidth;
		TheMaze.mazeHeight = MazeHeight;
		TheMaze.grid = new GameObject[mazeWidth, mazeHeight];
		build();
	}

	void build()
	{
		for( int x = 0; x < mazeWidth; x++ )
		{
			for( int y = 0; y < mazeHeight; y++ )
			{

				GameObject spot = Instantiate(
					Tiles.theTiles[Random.Range(0, Tiles.theTiles.Count)], 
					new Vector3(x, 0, y), 
					Quaternion.identity ) as GameObject;
				spot.AddComponent<Tile>();
				spot.GetComponent<Tile>().xPos = x;
				spot.GetComponent<Tile>().yPos = y;
				TheMaze.grid[x, y] = spot;
			}
		}
	}
}
