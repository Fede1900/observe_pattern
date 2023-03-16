using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int level = 1;
    private int currentExp = 0;
    private int expNextLevel = 0;
    public int baseNextLevel = 300;

    private static Player _instance;

    public static Player Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
                _instance = playerObject.GetComponent<Player>();
            }

            return _instance;
        }
    }

    public int Exp
    {
        get => currentExp;
        set
        {
            currentExp += value;

            OnExpChanged.Invoke(currentExp);

            while (currentExp >= NextLevel)
            {
                Level++;
                Debug.Log("sono salito di livello");
            }
        }
    }

    public int Level
    {
        get => level;
        set
        {
            level = value;

            NextLevel += (baseNextLevel * level);

            OnLevelChanged.Invoke(level);
        }
    }

    public int NextLevel
    {
        get => expNextLevel;
        set
        {
            expNextLevel = value;

            OnNextLevelChanged.Invoke(expNextLevel);
        }
    }

    public delegate void OnPlayerValueChangedFunction(int value);
    public event OnPlayerValueChangedFunction OnExpChanged;
    public event OnPlayerValueChangedFunction OnLevelChanged;
    public event OnPlayerValueChangedFunction OnNextLevelChanged;



    // Start is called before the first frame update
    void Start()
    {
        Level = level;
        Exp = currentExp;
        
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
