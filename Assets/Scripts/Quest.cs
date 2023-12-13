using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[Serializable]
public class Quest : MonoBehaviour
{
    public TMP_Text TextQuests;
    QuestScroll _quest;

    public void Initialize(QuestScroll quests)
    {
        _quest = quests;
        TextQuests.text = quests.Quests;
    }





}
