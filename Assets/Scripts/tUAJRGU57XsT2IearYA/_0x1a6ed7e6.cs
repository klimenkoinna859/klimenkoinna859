using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// The template defines more panels than this game dresses - five tutorial panels it
/// never shows, each carrying "Lorem Ipsum" and "HEADER". Those panels are NOT switched
/// off (controllers address panels by index and a missing one breaks navigation); their
/// text is blanked instead, at runtime, from generated code (§C.15).
///
/// Panels this game really fills are left alone: the cleaner skips the splash body and
/// PANELS.DEFAULT, and never touches a label a Pop writes into.
/// </summary>
public sealed class _0x1a6ed7e6 : MonoBehaviour
{
    public void _0x62f6649d()
    {
        if (_0x50b9d424.Instance == null || _0x50b9d424.Instance.Panels == null)
        {
            return;
        }

        List<_0x19fbab3b> _0xb6fa2569 = _0x50b9d424.Instance.Panels;
        for (int _0xcc53a957 = 0; _0xcc53a957 < _0xb6fa2569.Count; _0xcc53a957++)
        {
            if (_0xcc53a957 == _0xdfe619ff._0xa6411e87.SPLASH || _0xcc53a957 == _0xdfe619ff._0xa6411e87.DEFAULT)
            {
                continue;
            }

            _0x19fbab3b _0xc2735313 = _0xb6fa2569[_0xcc53a957];
            if (_0xc2735313 == null || _0xc2735313.Content == null)
            {
                continue;
            }

            TMP_Text[] _0xf56cbddd = _0xc2735313.Content.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x3a7df075 = 0; _0x3a7df075 < _0xf56cbddd.Length; _0x3a7df075++)
            {
                if (_0xf56cbddd[_0x3a7df075] == null)
                {
                    continue;
                }

                _0xf56cbddd[_0x3a7df075].text = string.Empty;
            }

            if (_0xc2735313.HeaderText != null)
            {
                _0xc2735313.HeaderText.text = string.Empty;
            }

            if (_0xc2735313.MainText != null)
            {
                _0xc2735313.MainText.text = string.Empty;
            }
        }

        {
#if B_LOGS
            {
                Debug.Log($"[cleaner] blanked undressed template panels, count={_0xb6fa2569.Count}");
            }
#endif
        }
    }
}