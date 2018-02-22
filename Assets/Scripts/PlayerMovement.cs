using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour {

    public TileScript startingTile;
    TileScript currentTile;
    int direction;

    private void Start()
    {
        
    }

    public void UpButton()
    {
        Debug.Log("test");
        direction = 0;
        Move();
    }
    public void DownButton()
    {
        direction = 1;
        Move();
    }
    public void LeftButton()
    {
        direction = 2;
        Move();
    }
    public void RightButton()
    {
        direction = 3;
        Move();
    }


    private void Move()
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
