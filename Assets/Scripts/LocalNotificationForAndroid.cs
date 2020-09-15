using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class LocalNotificationForAndroid : ILocalNotification
{
    public string ChannelId { get; set; } = "channel-id";
    public string SmallIcon { get; set; } = "icon_0";
    public string LargeIcon { get; set; } = "icon_1";

    public void CreateChannel(string cannelId, string cannelName, string description)
    {
        ChannelId = cannelId;

        var cannel = new AndroidNotificationChannel
        {
            Id = ChannelId,
            Name = cannelName,
            Importance = Importance.High,
            Description = description,
        };

        if (SmallIcon == "icon_0")
        {
            Debug.LogWarning($"{nameof(SmallIcon)} プロパティの値が初期値のままです。アイコンを正しく表示できない恐れがあります。");
        }

        if (LargeIcon == "icon_1")
        {
            Debug.LogWarning($"{nameof(LargeIcon)} プロパティの値が初期値のままです。アイコンを正しく表示できない恐れがあります。");
        }

        AndroidNotificationCenter.RegisterNotificationChannel(cannel);
    }

    public void CancelAll()
    {
        AndroidNotificationCenter.CancelAllScheduledNotifications();
        AndroidNotificationCenter.CancelAllNotifications();
    }


    public int Schedule(string title, string text, DateTime fireTime)
    {
        var notification = new AndroidNotification
        {
            Title = title,
            Text = text,
            FireTime = fireTime,
        };

        notification.SmallIcon = SmallIcon;
        notification.LargeIcon = LargeIcon;

        return AndroidNotificationCenter.SendNotification(notification, ChannelId);
    }

    public int ScheduleInSeconds(string title, string text, int seconds)
        => Schedule(title, text, DateTime.Now.AddSeconds(seconds));
    public int ScheduleInMinutes(string title, string text, int minutes)
        => Schedule(title, text, DateTime.Now.AddMinutes(minutes));
    public int ScheduleInHours(string title, string text, int hours)
        => Schedule(title, text, DateTime.Now.AddHours(hours));
}
