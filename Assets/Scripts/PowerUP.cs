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


    public Image Bg;
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
        TextName.text = powerUP.Name + System.Environment.NewLine + powerUP.Value.ToString("F2");
        TextCost.text = Mathf.Round(powerUP.Cost)+"";
        Bg.sprite = powerUP.Bg;
        TextLevel.text = "Lv " + powerUP.Level;
    }

    void Update()
    {
        if (_mainGame.Money <= _powerUP.Cost)
        {
            button.interactable = false;
        }
        else button.interactable = true;

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
        _powerUP.Value *= (1 + _powerUP.ValueUp);
        Initialize(_powerUP);
    }


}

