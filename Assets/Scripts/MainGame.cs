using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using UnityEngine.UIElements;

public class MainGame : MonoBehaviour
{

    public List<PowerUpScroll> PowerUps = new List<PowerUpScroll>();
    public List<QuestScroll> Quests = new List<QuestScroll>();
    public GameObject PrefabPowerUp;
    public GameObject PrefabParent;
    public GameObject PrefabQuest;
    public GameObject ParentQuest;
    public GameObject MoneyHolder;
    public TMP_Text TextMoney;
    public float Money;
    PowerUp _haspowerUp;
    public GameObject PopUp;
    int _timeChest = 1000 * 100;
    public int timePopUp = 0;
    

    void Start()
    {
        PopUp.SetActive(false);
        foreach (var Powerup in PowerUps)
        {
            GameObject go = GameObject.Instantiate(PrefabPowerUp, PrefabParent.transform, false);
            go.transform.localPosition = Vector3.zero;
            go.GetComponent<PowerUp>().Initialize(Powerup,this);
        }
        foreach (var quest in Quests)
        {
            GameObject go = GameObject.Instantiate(PrefabQuest, ParentQuest.transform, false);
            go.transform.localPosition = Vector3.zero;
            go.GetComponent<Quest>().Initialize(quest);
        }
    }

    

    private void Update()
    {
        TextMoney.text = Money.ToString();

        timePopUp++;
        if (timePopUp == _timeChest)
        {
            Time.timeScale = 0f;
            Chest();
        }
    }


    public void Chest()
    {
        PopUp.SetActive(true);
    }

    
}
