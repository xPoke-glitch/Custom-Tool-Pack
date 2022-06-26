using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using xPoke.CustomLog;

public class TestCustomLog : MonoBehaviour
{
    public void Start()
    {
        CustomLog.Log(CustomLog.CustomLogType.GENERAL, "General Message");
        CustomLog.Log(CustomLog.CustomLogType.PLAYER, "Player Log Message");
        CustomLog.Log(CustomLog.CustomLogType.TOOL, "Tool Log Message");
        CustomLog.Log(CustomLog.CustomLogType.GAMEPLAY, "Gameplay Log Message");
        CustomLog.Log(CustomLog.CustomLogType.AI, "AI Log Message");
        CustomLog.Log(CustomLog.CustomLogType.INPUT, "Input Log Message");
        CustomLog.Log("Others ...");
    }
}
