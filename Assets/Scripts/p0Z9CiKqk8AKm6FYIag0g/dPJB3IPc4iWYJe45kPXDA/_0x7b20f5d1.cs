using UnityEngine;

public class _0x7b20f5d1 : MonoBehaviour
{
    public bool IsTimerEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsTutorialEnabled;
    public bool IsBestScoreEnabled;
    private void _0x5bf81100()
    {
    }

    public bool IsStoryEnabled;
    private void _0x303ab1c2()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x7b20f5d1>();
            DontDestroyOnLoad(this.gameObject);
            this._0x303ab1c2();
        }
        else
        {
            this._0x5bf81100();
            Destroy(this.gameObject);
        }
    }

    public bool IsLevelIncrementOnWin;
    public static _0x7b20f5d1 Instance;
    public bool IsLevelSelectorEnabled;
    public bool IsCheckScoreEnabled;
    public bool IsSkipSplashEnabled;
}