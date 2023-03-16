using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    [SerializeField] string nomeQuest;
    [SerializeField] string descrizioneQuest;
    [SerializeField] int expToGain;
    [SerializeField] bool completed;

    bool questFinished;

    public void OnCompletation()
    {
        Player.Instance.Exp = expToGain;

        GetComponentInParent<QuestManager>().NextQuest();
        

        questFinished = true;
    }
    private void Start()
    {
        GetComponentInParent<QuestManager>().AddQuest(this);
    }

    private void Update()
    {
        if (completed && !questFinished)
        {
            OnCompletation();

            


        }
    }

    public void OnCompleteAction()
    {
        completed = true;
    }




}
