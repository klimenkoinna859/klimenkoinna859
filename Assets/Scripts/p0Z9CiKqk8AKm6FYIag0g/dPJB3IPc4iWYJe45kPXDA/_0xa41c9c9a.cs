using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xa41c9c9a : MonoBehaviour
{
    public List<Button> HomeButtons = new();
    public void _0x84fe19a9()
    {
        if (_0x7b20f5d1.Instance.IsOnlyWinGameEndEnabled)
            this._0xabd49f72();
        if (!this.IsGameEnd)
        {
            this._0x90fe6b66();
            _0x44f9825a.IsAfterLevelComplete = false;
            _0x44f9825a.IsAfterLevelFailed = true;
            _0x84a83be7 _0x87f22c13 = _0x18ece92a.Instance._0xd86b69da(_0xdfe619ff._0xdfb977df.LOSE).GetComponent<_0x84a83be7>();
            if (_0x7b20f5d1.Instance.IsCheckScoreEnabled)
                _0x87f22c13.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x812b87b4}";
            else
                _0x87f22c13.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x87f22c13.ContentAdditionalText.text = $"{0}";
            _0xdfe619ff._0xd23f50e2._0xf3225ca8 += 0;
            _0x18ece92a.Instance._0x97e1675c(_0xdfe619ff._0xdfb977df.LOSE);
        }
    }

    [HideInInspector]
    public bool IsGameEnd;
    public void _0xabd49f72()
    {
        if (!this.IsGameEnd)
        {
            this._0x90fe6b66();
            _0x44f9825a.IsAfterLevelComplete = true;
            _0x44f9825a.IsAfterLevelFailed = false;
            _0x84a83be7 _0xabfaefa2 = _0x18ece92a.Instance._0xd86b69da(_0xdfe619ff._0xdfb977df.WIN).GetComponent<_0x84a83be7>();
            if (_0x7b20f5d1.Instance.IsCheckScoreEnabled)
                _0xabfaefa2.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x812b87b4}";
            else
                _0xabfaefa2.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x7b20f5d1.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xdfe619ff._0xd23f50e2._0xf3225ca8)
                    _0xdfe619ff._0xd23f50e2._0xf3225ca8 = this.ScoreCurrent;
                _0xabfaefa2.ContentAdditionalText.text = $"{_0xdfe619ff._0xd23f50e2._0xf3225ca8}";
            }
            else
            {
                _0xabfaefa2.ContentAdditionalText.text = $"{this._0xfbafaf7a}";
                _0xdfe619ff._0xd23f50e2._0xf3225ca8 += this._0xfbafaf7a;
            }

            if (_0x7b20f5d1.Instance.IsLevelIncrementOnWin)
                ++_0x44f9825a._0x74fffb43._0x8c192152;
            _0x18ece92a.Instance._0x97e1675c(_0xdfe619ff._0xdfb977df.WIN);
        }
    }

    public void _0xb6fa4c18(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x2149f6a1();
            this._0x36e7a15e();
        }
    }

    private void _0x36e7a15e()
    {
        if (this.ScoreCurrent > _0x44f9825a._0x74fffb43._0xcab2d2d4)
            _0x44f9825a._0x74fffb43._0xcab2d2d4 = this.ScoreCurrent;
        if (_0x7b20f5d1.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x812b87b4)
                this._0xabd49f72();
    }

    private void _0x8f2b93e1()
    {
        this.TimerText.ForEach(_0x691625ea => _0x691625ea.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x8e6384e6._0xd45e2bce(new byte[6] { 184, 184, 137, 239, 166, 166 }, 213)));
    }

    public void _0x5aebbe59()
    {
        _0x44f9825a.Instance._0x787fc083(true);
        _0x44f9825a.Instance._0x0e9ebb6d(_0xdfe619ff._0x2cdb8663.SCENE_0);
    }

    private void _0x9190c166()
    {
        if (this.ScoreCurrent >= this._0x812b87b4)
            this._0xabd49f72();
        else
            this._0x84fe19a9();
    }

    private void _0x2149f6a1()
    {
        if (_0x7b20f5d1.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x691625ea => _0x691625ea.text = $"{this.ScoreCurrent}/{this._0x812b87b4}");
        else
            this.ScoreText.ForEach(_0x691625ea => _0x691625ea.text = $"{this.ScoreCurrent}");
    }

    private int _0x48f8ffa8 => this.CustomTimeInitial + _0x44f9825a._0x74fffb43._0x8c192152 * 10;

    [HideInInspector]
    public int ScoreCurrent;
    private void _0x90fe6b66()
    {
        this.IsGameEnd = true;
        _0x44f9825a.IsAfterLevelComplete = true;
    }

    private void Awake()
    {
        _0xb40721a5 = this.gameObject.GetComponent<_0xa41c9c9a>();
    }

    private IEnumerator _0x69709bb1()
    {
        this._0x8f2b93e1();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x44f9825a.Instance._0x44bf2ec4 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x44f9825a.Instance._0xae412e4f)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x8f2b93e1();
            }
        }

        if (!this.IsGameEnd)
            this._0x84fe19a9();
    }

    [HideInInspector]
    public int TimeLeft;
    public List<TMP_Text> SubtitleText = new();
    public int CustomTimeInitial = 30;
    public List<Button> PauseButtons = new();
    public List<TMP_Text> LevelNumberText = new();
    public List<TMP_Text> ScoreText = new();
    private int _0xfbafaf7a => this.ScoreCurrent;

    [HideInInspector]
    public int CurrentGameIndex;
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x48f8ffa8;
        this.CurrentGameIndex = _0x44f9825a.Instance._0x44bf2ec4;
        foreach (Button _0x4968eda2 in this.HomeButtons)
            _0x4968eda2.onClick.AddListener(() =>
            {
                this._0x5aebbe59();
            });
        foreach (Button _0x85dcc334 in this.PauseButtons)
            _0x85dcc334.onClick.AddListener(() =>
            {
                _0x44f9825a.Instance._0x787fc083(false);
                _0x18ece92a.Instance._0x97e1675c(_0xdfe619ff._0xdfb977df.PAUSE);
            });
        this._0x2149f6a1();
        this.LevelNumberText.ForEach(_0x691625ea => _0x691625ea.text = $"LVL {_0x44f9825a._0x74fffb43._0x8c192152 + 1}");
        if (_0x7b20f5d1.Instance.IsTimerEnabled)
        {
            this._0x8f2b93e1();
            this.StartCoroutine(this._0x69709bb1());
        }
    }

    public int CustomTargetScore = 10;
    public List<TMP_Text> TimerText = new();
    private int _0x812b87b4 => this.CustomTargetScore + _0x44f9825a._0x74fffb43._0x8c192152 * 10;

    private static _0xa41c9c9a _0xb40721a5;
}

internal static class _0x8e6384e6
{
    internal static string _0xd45e2bce(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}