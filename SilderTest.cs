using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SilderTest : MonoBehaviour {
    Slider slider;
    
    // Use this for initialization
    void Start () {
        slider=gameObject.GetComponent<Slider>();
        slider.onValueChanged.AddListener(SliderChange);
    }
    
    void SliderChange(float t)
    {
        print("slider的值"+t);
        
    }
            
    
}