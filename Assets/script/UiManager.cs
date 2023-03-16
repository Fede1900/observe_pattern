using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI needExpText;
    [SerializeField] private TextMeshProUGUI currentExpText;
    [SerializeField] private TextMeshProUGUI MissionText;

    // Start is called before the first frame update
    void Start()
    {
        Player.Instance.OnExpChanged += SetExp;
        Player.Instance.OnLevelChanged += SetLevel;
        Player.Instance.OnNextLevelChanged += SetNextExp;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SetExp(int currentExp)
    {
        currentExpText.text = "Exp: " + currentExp.ToString();
    }

    private void SetLevel(int level)
    {
        levelText.text = "Level: " + level.ToString();
    }

    private void SetNextExp(int nextExp)
    {
        needExpText.text = "For next level: " + nextExp.ToString();
        
    }
}
