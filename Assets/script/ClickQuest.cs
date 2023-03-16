using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickQuest : Quest
{
    [SerializeField] int clickToComplete;


    private void OnMouseDown()
    {
        
        clickToComplete--;

        if (clickToComplete <= 0)
        {
            OnCompleteAction();
        }
    }
}
