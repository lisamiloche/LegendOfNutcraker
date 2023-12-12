using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{

    public List<PowerUpScroll> PowerUp;
    public GameObject PrefabPowerUp;
    public GameObject PrefabParent;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var PowerUp in PowerUp)
        {
            GameObject go = GameObject.Instantiate(PrefabPowerUp, PrefabParent.transform, false);
            go.transform.localPosition = Vector3.zero;
            //go.GetComponent<PowerUp>().Initilize(powerUP);
        }
    }

   


}
