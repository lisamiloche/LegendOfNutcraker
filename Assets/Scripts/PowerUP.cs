using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;


[Serializable]
public class PowerUp : MonoBehaviour
{
    
    public Image Icon;
    public TMP_Text TextLevel;
    public TMP_Text TextName;
    public TMP_Text TextCost;


    public void OnClick(PowerUpScroll Up)
    {
        Up.Level++;
        Up.Cost++;
        Up.Damage += 10;
    }

    public void Initilize(PowerUpScroll powerUP)
    {
        //Icon.sprite = powerUP.SpriteIcon;
        TextName.text = powerUP.Name + System.Environment.NewLine + powerUP.Damage;
        TextCost.text = powerUP.Cost + "£";
    }

    

   
}

