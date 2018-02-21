using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public TileScript startingTile;
    TileScript currentTile;
     int direction;

    public void UpButton()
    {
        direction = 0;    
    }
    public void DownButton()
    {
        direction = 1;
    }
    public void LeftButton()
    {
        direction = 2;
    }
    public void RightButton()
    {
        direction = 3;
    }


    // Update is called once per frame
    void Update () {
		
	}
    private void OnMouseUp()
    {
        TileScript finalTile = null;            //tile we want to arrive at
        
        if (currentTile == null)
        {
            finalTile = startingTile;
        }
        else
        {
            finalTile = currentTile.NextTiles[direction];       //direction: 0 = up,    1=down,   2=left,   3=right
        }

        if (finalTile == null)
        {
            return;
        }

        //Move to Position of the Tile
        this.transform.position = finalTile.transform.position;
        currentTile = finalTile;

    }
}
