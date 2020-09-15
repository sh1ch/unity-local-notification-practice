using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void EntryPoint()
    {
        // 初期化
        var manager = NotificationManager.Instance;

        manager.Initialize();

        // サンプル用コード
        manager.Notification.ScheduleInSeconds("テストのタイトル", "テストのテキストです。", 10);

        Debug.Log("EntryPoint Called.");
    }
}
