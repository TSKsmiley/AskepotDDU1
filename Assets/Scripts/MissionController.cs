using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionController : MonoBehaviour
{
    public GameObject[] Missions;
    public int CurrentMission;

    public void Next()
    {
        CurrentMission++;
        if (Missions.Length > CurrentMission)
        {
            try { Missions[CurrentMission].GetComponent<NPCconversation>().enabled = true;}
            catch
            {
                // ignored
            }
        
            try { Missions[CurrentMission].GetComponent<MiniGame>().enabled = true;}
            catch
            {
                // ignored
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentMission = 0;

        try { Missions[CurrentMission].GetComponent<NPCconversation>().enabled = true;}
        catch
        {
            // ignored
        }
        
        try { Missions[CurrentMission].GetComponent<MiniGame>().enabled = true;}
        catch
        {
            // ignored
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
