using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour 
{
	public int xPos;
	public int yPos;

	public void NewLocation(int newX, int newY)
	{
		xPos = newX;
		yPos = newY;

		TheMaze.grid[xPos, yPos] = gameObject;
	}
}
