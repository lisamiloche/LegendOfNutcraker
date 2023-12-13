using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
//using UnityEngine.UIElements;
//using Unity.Mathematics;


[Serializable]
public class PowerUp : MonoBehaviour
{

    public Image Icon;
    public TMP_Text TextLevel;
    public TMP_Text TextName;
    public TMP_Text TextCost;
    public Button button;
    PowerUpScroll _powerUP;
    public float money;
    MainGame _mainGame;


    public void Initialize(PowerUpScroll powerUP, MainGame mainGame = null)
    {
        if(mainGame) _mainGame = mainGame;
        print(_mainGame);
        _powerUP = powerUP;
        Icon.sprite = powerUP.SpriteIcon;
        TextName.text = powerUP.Name + System.Environment.NewLine + Mathf.Round(powerUP.Damage);
        TextCost.text = Mathf.Round(powerUP.Cost) + "£";
        TextLevel.text = "Lv: " + powerUP.Level;
    }



    public void OnClick()
    {
        print("click and " + _mainGame);
        if (_mainGame)
        {
            _mainGame.Money -= _powerUP.Cost;
        }
        _powerUP.Level++;
        _powerUP.Cost *= _powerUP.Augmentation;
        _powerUP.Damage *= 1.1f;
        Initialize(_powerUP);
    }


}

