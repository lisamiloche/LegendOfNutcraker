using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PowerUP : MonoBehaviour
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

