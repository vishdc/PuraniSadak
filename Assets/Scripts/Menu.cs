using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text[] missionDescription, missionReward, missionProgress;
	public GameObject[] rewardButton;

    // Start is called before the first frame update
    void Start()
    {
        SetMission();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartRun()
	{
        GameManager.gm.StartRun();
    }

    public void SetMission()
	{
		for (int i = 0; i < 2; i++)
		{
			MissionBase mission = GameManager.gm.GetMission(i);
			missionDescription[i].text = mission.GetMissionDescription();
			missionReward[i].text = "Reward: "  + mission.reward;
			missionProgress[i].text = mission.progress + mission.currentProgress + " / " + mission.max;
			if (mission.GetMissionComplete())
			{
				rewardButton[i].SetActive(true);
			}
		}

		//GameManager.gm.Save();
	}
}
