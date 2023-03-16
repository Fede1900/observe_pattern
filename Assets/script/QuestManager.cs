using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public List<Quest> quests = new List<Quest>();

    public delegate void QuestInformation(string title, string name, string objective);
    public event QuestInformation OnQuestChange;


    int index = 0;

    private void Start()
    {
        quests[index].gameObject.SetActive(true);
    }

    public void AddQuest(Quest quest)
    {
        quests.Add(quest);

        quest.gameObject.SetActive(false);
    }
 

    public void NextQuest()
    {
        index++;
        if (index <= quests.Count-1)
        {
            quests[index].gameObject.SetActive(true);
            
        }


    }
}
