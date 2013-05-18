using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HighlightTile : MonoBehaviour 
{
	private static GameObject highlightedTile;
	private static List<GameObject> neighbours = new List<GameObject>();

	public static void HighlightTileAt(int xPos, int yPos)
	{
		// add the neighbours
		neighbours.Clear();
		if( xPos > 0 )
			neighbours.Add(TheMaze.grid[xPos - 1, yPos]);
		if( xPos < TheMaze.mazeWidth - 1 )
			neighbours.Add(TheMaze.grid[xPos + 1, yPos]);
		if( yPos > 0 )
			neighbours.Add(TheMaze.grid[xPos, yPos - 1]);
		if( yPos < TheMaze.mazeHeight - 1 )
			neighbours.Add(TheMaze.grid[xPos, yPos + 1]);
		print(neighbours.Count);

		if( neighbours.Contains( highlightedTile) )
		{
			SwapLocations.Swap(highlightedTile, TheMaze.grid[xPos, yPos]);
			highlightedTile.renderer.material.shader = Shader.Find("Diffuse");
			highlightedTile = null;
		}
		else
		{
			if(highlightedTile != null)
			{
				highlightedTile.renderer.material.shader = Shader.Find("Diffuse");
			}
			highlightedTile = TheMaze.grid[xPos,yPos];
			highlightedTile.renderer.material.shader = Shader.Find("Self-Illumin/Diffuse");
		}
	}

}
