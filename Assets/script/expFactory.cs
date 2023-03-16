using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expFactory : MonoBehaviour
{
    public int experience = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Player.Instance.Exp =  experience;
    }
}
