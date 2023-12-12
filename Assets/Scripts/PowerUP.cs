using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
//using Unity.Mathematics;


[Serializable]
public class PowerUp : MonoBehaviour
{
    
    public Image Icon;
    public TMP_Text TextLevel;
    public TMP_Text TextName;
    public TMP_Text TextCost;
    PowerUpScroll _powerUP;




    public void Initialize(PowerUpScroll powerUP)
    {
        _powerUP = powerUP;
        Icon.sprite = powerUP.SpriteIcon;
        TextName.text = powerUP.Name + System.Environment.NewLine + powerUP.Damage;
        TextCost.text = powerUP.Cost + "£";
        TextLevel.text = "Lv: " + powerUP.Level;
    }


    public void OnClick()
    {
        _powerUP.Level++;
        _powerUP.Cost *= _powerUP.Augmentation;
        _powerUP.Damage *= 1.1f;
        Initialize(_powerUP);
    }


}

