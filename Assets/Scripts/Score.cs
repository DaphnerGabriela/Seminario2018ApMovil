using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    Text text;
    private Controls player;
    
    void Start()
    {
        text = GetComponent<Text>();
        player = FindObjectOfType<Controls>();

    }
	
	void Update () {
        text.text = "Pokeballs: " + player.crystals + " /24";


    }
}
