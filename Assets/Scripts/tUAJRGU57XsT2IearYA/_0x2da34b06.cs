using UnityEngine;

/// <summary>
/// Tuning numbers for the whole app. Literals only - no static field here reads
/// another one, so Plana's declaration reordering cannot break the type.
/// </summary>
public static class _0x2da34b06
{
    // ── canvas ────────────────────────────────────────────────────────────────
    // CanvasScaler reference of both scene templates; every rect below is in these units.
    public const float CanvasW = 1242f;
    public const int StripStops = 24;
    public const float FadeTime = 0.28f;
    public const float CaptionMin = 24f;
    // ── §C.25 two-band discipline for rows and cards ──────────────────────────
    public const float GutterCentre = 62f;
    // ── board geometry, in canvas units ───────────────────────────────────────
    public const float BoardSize = 1080f;
    public const float PressTime = 0.08f;
    public const int GiftCooldownHours = 20;
    // ── progression ───────────────────────────────────────────────────────────
    public const int XpPerSpin = 2;
    public const float PageIn = 0.28f;
    public const float CellSize = 320f;
    public const int ActCount = 3;
    public const float PageOut = 0.22f;
    /// <summary>Space-grouped integer: 1 240. There is no currency symbol - there is no currency.</summary>
    public static string Grouped(int _0x8e82e89f)
    {
        bool _0x1d90bb8d = _0x8e82e89f < 0;
        int _0xe66d8742 = _0x1d90bb8d ? -_0x8e82e89f : _0x8e82e89f;
        string _0xd492af01 = _0xe66d8742.ToString();
        string _0x38f32650 = string.Empty;
        int _0xee7654e0 = 0;
        for (int _0x05f7db7a = _0xd492af01.Length - 1; _0x05f7db7a >= 0; _0x05f7db7a--)
        {
            _0x38f32650 = _0xd492af01[_0x05f7db7a] + _0x38f32650;
            _0xee7654e0++;
            if (_0xee7654e0 % 3 == 0 && _0x05f7db7a > 0)
            {
                _0x38f32650 = _0xbd4dd9a3._0x698fb1f5(new byte[1] { 173 }, 141) + _0x38f32650;
            }
        }

        return _0x1d90bb8d ? _0xbd4dd9a3._0x698fb1f5(new byte[1] { 145 }, 188) + _0x38f32650 : _0x38f32650;
    }

    public const float PressScale = 0.96f;
    public const float ButtonMax = 58f;
    public const float SectionMin = 32f;
    public const float CaptionMax = 28f;
    public const float SpinStagger = 0.25f;
    public const float ResolveHold = 0.70f;
    public const int MaxRank = 20;
    public const int ActStarGoal = 12;
    public const float TextWidth = 820f;
    public const float SectionMax = 56f;
    public const float CellGap = 12f;
    public const float CountUp = 0.60f;
    public const float BodyMin = 26f;
    public const float TitleMin = 44f;
    public const float SymbolSize = 268f;
    // ── credits ───────────────────────────────────────────────────────────────
    public const int StartingCredits = 2500;
    public const float CanvasH = 2688f;
    public const int CardCount = 12;
    public const float NumberMin = 40f;
    public const int MissionCount = 3;
    public const float BoardWindow = 984f;
    public const int ActiveLines = 5;
    public const float GutterWidth = 42f;
    public const int ReelRows = 3;
    public const int GiftStreakBonus = 1500;
    public const int StreakLength = 7;
    public const int XpPerRank = 500;
    // ── motion (seconds) ──────────────────────────────────────────────────────
    public const float SpinRoll = 1.60f;
    public const float Anticipation = 0.45f;
    public const int XpPerAct = 120;
    public const int HouseGrant = 500;
    public const float NumberMax = 72f;
    public const float TextLeft = 129f; // 62 + 21 + 46
    public const int DefaultStake = 10;
    // ── type scale (fontSizeMax / fontSizeMin); no minimum below 24 ───────────
    public const float TitleMax = 84f;
    public const int GiftAmount = 500;
    public const int XpPerLine = 15;
    public const float BodyMax = 34f;
    // ── act ───────────────────────────────────────────────────────────────────
    public const int SpinBudget = 25; // taps, never a timer: the run never ends by itself
    public const float ButtonMin = 34f;
    public const int ReelColumns = 3;
    public const int CandidateLines = 7;
}

internal static class _0xbd4dd9a3
{
    internal static string _0x698fb1f5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}