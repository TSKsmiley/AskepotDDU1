using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionController : MonoBehaviour
{
    public NPCconversation[] Missions;
    public int CurrentMission;

    public void Next()
    {
        CurrentMission++;
        if (Missions.Length > CurrentMission)
        {
            Missions[CurrentMission].enabled = true;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentMission = 0;
        Missions[CurrentMission].enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
