using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;



[Serializable]
public class PowerUp : MonoBehaviour
{
    public Image Image;
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
        
        //Image.sprite = powerUP.Sprite;
        TextName.text = powerUP.Name + System.Environment.NewLine + powerUP.Damage;
        TextCost.text = powerUP.Cost + "£";
    }

}

[Serializable]
public class PowerUpScroll
{
    public int Level;
    public string Name;
    public int Cost;
    public int Damage;
    public Image Sprite;
}

