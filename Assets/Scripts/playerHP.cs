using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerHP : MonoBehaviour
{
    public TextMeshProUGUI textRef;
    public Movement myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textRef.SetText("HP : " + myPlayer.hp);

        if(myPlayer.hp <= 0)
        {
            textRef.gameObject.SetActive(false);
        } 
    }
}
