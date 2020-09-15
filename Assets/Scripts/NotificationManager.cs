using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class NotificationManager
{
    public static NotificationManager Instance { get; } = new NotificationManager();

    public ILocalNotification Notification { get; private set; }


    private NotificationManager() 
    {
        
    }

    public void Initialize()
    {
        ILocalNotification notification = new LocalNotificationForAndroid();

        notification.SmallIcon = "ic_stat_notify_small";
        notification.LargeIcon = "ic_stat_notify_large";

        notification.CreateChannel("sample0916", "sampleName", "sampleDescription");

        Notification = notification;
    }
}
