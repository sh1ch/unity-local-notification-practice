using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILocalNotification
{
    /// <summary>
    /// Small Icon タイプのアイコン ID を表すテキストを取得または設定します。
    /// </summary>
    string SmallIcon { get; set; }

    /// <summary>
    /// Large Icon タイプのアイコン ID を表すテキストを取得または設定します。
    /// </summary>
    string LargeIcon { get; set; }

    void CreateChannel(string cannelId, string cannelName, string description);

    /// <summary>
    /// 通知のスケジュールをすべてキャンセル（削除）します。
    /// </summary>
    void CancelAll();

    int Schedule(string title, string text, DateTime fireTime);
    int ScheduleInSeconds(string title, string text, int seconds);
    int ScheduleInMinutes(string title, string text, int minutes);
    int ScheduleInHours(string title, string text, int hours);
}
