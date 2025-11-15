using UnityEngine;
using TMPro;

public class AddScore : MonoBehaviour
{
    int killCount = 0;
    public TextMeshProUGUI killCountText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateKillText();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void UpdateKillText()
    {
        killCountText.text = "Kills: " + killCount;
        Debug.Log("kill count : " + killCount);
    }

    public void AddKillCount()
    {
        ++killCount;
        UpdateKillText();
        

    }
}
