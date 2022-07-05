using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordController : MonoBehaviour
{
    public Discord.Discord discord;

    void Start()
    {
        discord = new Discord.Discord(993720561790361692, (System.UInt64)Discord.CreateFlags.Default);
        var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity
        {
            Details = "Adventuring Through The Underworld!",
            State = "Playing As: Kaz | Spirit"
        };
        activityManager.UpdateActivity(activity, (res) =>
        {
            if (res == Discord.Result.Ok)
                Debug.Log("Discord Status: Working");
            else
                Debug.Log("Discord Status: Error Detected");
        });
    }


    void Update()
    {
        discord.RunCallbacks();
    }
}
