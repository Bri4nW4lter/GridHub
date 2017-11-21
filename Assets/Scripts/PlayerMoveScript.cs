using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoveScript : MonoBehaviour {

    public Button UpButton;
    

    void Start () {
        Button btn = UpButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }


    void TaskOnClick()
    {
        Debug.Log("You clicked up");
    }
	
	
	void Update () {
		
	}
}
