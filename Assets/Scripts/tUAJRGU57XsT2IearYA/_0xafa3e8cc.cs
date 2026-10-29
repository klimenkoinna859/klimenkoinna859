using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xafa3e8cc : MonoBehaviour
{
    private static float Ratio(Color _0x12c71bca, Color _0x9d5758c5)
    {
        float _0x2ef763d7 = Luminance(_0x12c71bca);
        float _0x51df53ac = Luminance(_0x9d5758c5);
        return (Mathf.Max(_0x2ef763d7, _0x51df53ac) + 0.05f) / (Mathf.Min(_0x2ef763d7, _0x51df53ac) + 0.05f);
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x15eef342)
    {
        return 0.2126f * Linear(_0x15eef342.r) + 0.7152f * Linear(_0x15eef342.g) + 0.0722f * Linear(_0x15eef342.b);
    }

    private const float MinRatio = 4.5f;
    private void LateUpdate()
    {
        if (this._0xde5ad8dc.Count == 0)
            return;
        this._0xfda3e95f.Clear();
        this._0xfda3e95f.AddRange(this._0xde5ad8dc);
        this._0xde5ad8dc.Clear();
        for (int _0x7d80ce0f = 0; _0x7d80ce0f < this._0xfda3e95f.Count; _0x7d80ce0f++)
            Fix(this._0xfda3e95f[_0x7d80ce0f]);
    }

    private static void Fix(TMP_Text _0x83ddb904)
    {
        if (_0x83ddb904 == null || !_0x83ddb904.isActiveAndEnabled)
            return;
        Material _0x84ce4cae = _0x83ddb904.fontSharedMaterial;
        if (_0x84ce4cae == null || !_0x84ce4cae.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x84ce4cae.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x84ce4cae.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x12a570e9 = _0x83ddb904.color;
        if (_0x12a570e9.a <= 0f)
            return;
        Color _0xddf18de7 = _0x84ce4cae.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x12a570e9, _0xddf18de7) >= MinRatio)
            return;
        Color _0xe9461534 = Luminance(_0xddf18de7) < 0.5f ? Color.white : Color.black;
        Color _0x4ec3c174;
        if (Ratio(_0xe9461534, _0xddf18de7) < TargetRatio)
        {
            _0x4ec3c174 = _0xe9461534;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xe494e521 = 0f;
            float _0xfda63963 = 1f;
            for (int _0x0f952e55 = 0; _0x0f952e55 < 20; _0x0f952e55++)
            {
                float _0x9fa4d466 = (_0xe494e521 + _0xfda63963) * 0.5f;
                if (Ratio(Color.Lerp(_0x12a570e9, _0xe9461534, _0x9fa4d466), _0xddf18de7) >= TargetRatio)
                    _0xfda63963 = _0x9fa4d466;
                else
                    _0xe494e521 = _0x9fa4d466;
            }

            _0x4ec3c174 = Color.Lerp(_0x12a570e9, _0xe9461534, _0xfda63963);
        }

        _0x4ec3c174.a = _0x12a570e9.a;
        _0x83ddb904.color = _0x4ec3c174;
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xf86e5650(Object _0xa4d206a4)
    {
        TMP_Text _0x3b7aef41 = _0xa4d206a4 as TMP_Text;
        if (_0x3b7aef41 != null)
            this._0xde5ad8dc.Add(_0x3b7aef41);
    }

    private const float MinOutlineWidth = 0.01f;
    private readonly HashSet<TMP_Text> _0xde5ad8dc = new HashSet<TMP_Text>();
    private readonly List<TMP_Text> _0xfda3e95f = new List<TMP_Text>();
    private static _0xafa3e8cc _0x4a4ebcd2;
    private void OnEnable()
    {
        if (this._0xa0a8817c == null)
            this._0xa0a8817c = _0x91e36411 => this._0xf86e5650(_0x91e36411);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xa0a8817c);
    }

    private static float Linear(float _0x1c1c56b5)
    {
        _0x1c1c56b5 = Mathf.Clamp01(_0x1c1c56b5);
        return _0x1c1c56b5 <= 0.03928f ? _0x1c1c56b5 / 12.92f : Mathf.Pow((_0x1c1c56b5 + 0.055f) / 1.055f, 2.4f);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x4a4ebcd2 != null)
            return;
        GameObject _0x13ae8940 = new GameObject(_0x94582ce0._0x68c45762(new byte[16] { 136, 177, 172, 159, 179, 178, 168, 174, 189, 175, 168, 155, 169, 189, 174, 184 }, 220));
        _0x13ae8940.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x13ae8940);
        _0x4a4ebcd2 = _0x13ae8940.AddComponent<_0xafa3e8cc>();
    }

    private const float TargetRatio = 7f;
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xa0a8817c;
    private void OnDisable()
    {
        if (this._0xa0a8817c != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xa0a8817c);
    }
}

internal static class _0x94582ce0
{
    internal static string _0x68c45762(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}