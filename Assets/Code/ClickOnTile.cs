using UnityEngine;
using System.Collections;

public class ClickOnTile : MonoBehaviour 
{
	void Update()
	{
		if( Input.GetButtonDown("Fire1") )
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if ( Physics.Raycast(ray, out hit, 100f) )
			{
				GameObject tile = hit.collider.gameObject;

				int x = tile.GetComponent<Tile>().xPos;
				int y = tile.GetComponent<Tile>().yPos;
			
				print("X pos: " + x + "Y Pos: " + y);
				HighlightTile.HighlightTileAt(x, y);
			}
		}
	}
}
