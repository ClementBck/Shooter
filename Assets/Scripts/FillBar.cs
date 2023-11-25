using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillBar : MonoBehaviour
{
    public Slider mySlider;
    public int charge = 0;
    // Start is called before the first frame update
    void Start()
    {
        mySlider.value = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        mySlider.value = charge;
        if (Input.GetKey(KeyCode.Space))
        {
            if (charge < 100)
            {
                charge++;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (charge <= 100)
            {
                charge = 0;
                print(charge);
            }
        }
    }
}
