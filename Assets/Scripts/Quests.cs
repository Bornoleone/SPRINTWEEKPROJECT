using UnityEngine;
using TMPro;


public class Quests : MonoBehaviour
{
    public AddScore AddScore;
    public TextMeshProUGUI QuestTitle;
    public TextMeshProUGUI QuestProgress;
    public TextMeshProUGUI QuestRequirement;
    bool isON;
    int target;
    int start;
    int end;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Quests()
    {


    }
    public void UpdateText()
    {
        QuestTitle.text = "Kill All Enemies";
        QuestProgress.text = "Killed Enemies: "+ AddScore.killCountText;
    }
    
}
