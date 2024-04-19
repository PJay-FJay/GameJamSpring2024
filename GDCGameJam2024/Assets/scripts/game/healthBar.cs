using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Need to utilize the UI library in Unity, make sure you are "using UnityEngine.UI"
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    //Gets the component data from the given Slider component
    public Slider slider;

    //Function sets the max health value of our health bar using the inputted health value and sets the slider value to the inputted health value || *this can be called later
    public void setMaxHealth(int health){
        slider.maxValue = health;
        slider.value = health;

    }
    
    //Function sets the slider health value to a given value || in this case we can use it to update damage values to the player
    public void setHealth(int health){
        
        slider.value = health;

    }
}
