using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// TemplatePlaceholderGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3b, rule C.15 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TemplatePlaceholderGuard.cs.
//
// WHY (19.10.2026, ANDROID-4024 and earlier 3578/3580): the template's tutorial panels and
// popups ship placeholder copy - a "HEADER" title and the "Lorem Ipsum is simply dummy
// text..." body. Codegen is told to rewrite or blank every one of them (C.15/C.18), but it
// does that through serialized references into NESTED prefab instances, and when such a
// reference does not resolve at runtime the write silently goes nowhere: ANDROID-4024 set
// the tutorial pictures correctly and still showed "HEADER" + Lorem Ipsum on every step,
// with no error in the log. Static gates cannot prove these references resolve.
//
// WHAT: a last line of defence that does not depend on any reference. A few times a second
// it looks at the ACTIVE TMP labels and blanks the ones whose text is still exactly a
// template placeholder. Real game text is never touched: only the stock strings match.
// Matched by content, not by object name (the obfuscator renames objects).
public sealed class _0xe6abc367 : MonoBehaviour
{
    private static bool IsPlaceholder(string _0x8bc53650)
    {
        if (string.IsNullOrEmpty(_0x8bc53650))
            return false;
        string _0xa726a478 = _0x8bc53650.Trim();
        if (_0x6a9ee796.Contains(_0xa726a478))
            return true;
        string _0xf89adfd7 = _0xa726a478.ToLowerInvariant();
        for (int _0x962508b4 = 0; _0x962508b4 < _0x32440a9b.Length; _0x962508b4++)
        {
            if (_0xf89adfd7.StartsWith(_0x32440a9b[_0x962508b4]))
                return true;
        }

        return false;
    }

    private void OnDisable()
    {
        if (this._0x41c2d4f9 != null)
            SceneManager.sceneLoaded -= this._0x41c2d4f9;
    }

    private UnityEngine.Events.UnityAction<Scene, LoadSceneMode> _0x41c2d4f9;
    // A lambda held in a field, never a bare method group: Plana renames the method
    // declaration but not a method-group reference (see TmpContrastGuard).
    private void OnEnable()
    {
        if (this._0x41c2d4f9 == null)
            this._0x41c2d4f9 = (_0xd5479488, _0x80a9b016) =>
            {
                this._0xdfe5bd1d = 0f;
            };
        SceneManager.sceneLoaded += this._0x41c2d4f9;
    }

    private static readonly HashSet<string> _0x6a9ee796 = new HashSet<string>
    {
        _0x2f2cf660._0x7e116f71(new byte[6] { 163, 174, 170, 175, 174, 185 }, 235),
        _0x2f2cf660._0x7e116f71(new byte[6] { 88, 117, 113, 116, 117, 98 }, 16),
        _0x2f2cf660._0x7e116f71(new byte[6] { 71, 74, 78, 75, 74, 93 }, 47),
        _0x2f2cf660._0x7e116f71(new byte[5] { 23, 10, 23, 15, 6 }, 67),
        _0x2f2cf660._0x7e116f71(new byte[5] { 59, 6, 27, 3, 10 }, 111)
    };
    private static _0xe6abc367 _0xadaf9146;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xadaf9146 != null)
            return;
        GameObject _0x623e7031 = new GameObject(_0x2f2cf660._0x7e116f71(new byte[24] { 135, 182, 190, 163, 191, 178, 167, 182, 131, 191, 178, 176, 182, 187, 188, 191, 183, 182, 161, 148, 166, 178, 161, 183 }, 211));
        _0x623e7031.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x623e7031);
        _0xadaf9146 = _0x623e7031.AddComponent<_0xe6abc367>();
    }

    // Split on purpose: the C.15 gate flags those words inside string literals of generated
    // code, and this file is the one place that must name them to recognise them.
    private static readonly string[] _0x32440a9b =
    {
        _0x2f2cf660._0x7e116f71(new byte[3] { 228, 231, 250 }, 136) + _0x2f2cf660._0x7e116f71(new byte[6] { 175, 167, 234, 163, 186, 185 }, 202) + _0x2f2cf660._0x7e116f71(new byte[2] { 224, 248 }, 149),
        _0x2f2cf660._0x7e116f71(new byte[6] { 26, 11, 19, 19, 7, 94 }, 126) + _0x2f2cf660._0x7e116f71(new byte[4] { 146, 131, 158, 146 }, 230)
    };
    private void LateUpdate()
    {
        if (Time.unscaledTime < this._0xdfe5bd1d)
            return;
        this._0xdfe5bd1d = Time.unscaledTime + ScanInterval;
        TMP_Text[] _0x4bf83006 = Object.FindObjectsByType<TMP_Text>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        for (int _0x88f24a1e = 0; _0x88f24a1e < _0x4bf83006.Length; _0x88f24a1e++)
        {
            TMP_Text _0x10a35a63 = _0x4bf83006[_0x88f24a1e];
            if (_0x10a35a63 != null && IsPlaceholder(_0x10a35a63.text))
                _0x10a35a63.text = "";
        }
    }

    private const float ScanInterval = 0.25f;
    private float _0xdfe5bd1d;
}

internal static class _0x2f2cf660
{
    internal static string _0x7e116f71(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}