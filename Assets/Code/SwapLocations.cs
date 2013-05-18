using UnityEngine;
using System.Collections;

public class SwapLocations : MonoBehaviour 
{
	public static void Swap(GameObject from, GameObject to)
	{
		Vector3 fromPos = from.transform.position;
		int fromX = from.GetComponent<Tile>().xPos;
		int fromY = from.GetComponent<Tile>().yPos;

		from.transform.position = to.transform.position;
		from.GetComponent<Tile>().NewLocation( to.GetComponent<Tile>().xPos, to.GetComponent<Tile>().yPos );

		to.transform.position = fromPos;
		to.GetComponent<Tile>().NewLocation(fromX, fromY);
	}

}
