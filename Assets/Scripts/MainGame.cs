using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using UnityEngine.UIElements;

public class MainGame : MonoBehaviour
{

    public List<PowerUpScroll> PowerUp = new List<PowerUpScroll>();
    public GameObject PrefabPowerUp;
    public GameObject PrefabParent;
    public TMP_Text TextMoney;
    public float Money;
    

    void Start()
    {
        
        foreach (var Powerup in PowerUp)
        {
            GameObject go = GameObject.Instantiate(PrefabPowerUp, PrefabParent.transform, false);
            go.transform.localPosition = Vector3.zero;
            go.GetComponent<PowerUp>().Initialize(Powerup);
        }
    }


    private void Update()
    {
        TextMoney.text = Money + "";
    }

    
}
