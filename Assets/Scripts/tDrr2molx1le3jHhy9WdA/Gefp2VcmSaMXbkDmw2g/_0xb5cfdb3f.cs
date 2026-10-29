using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0xb5cfdb3f : MonoBehaviour
{
    private float _0x045c6ae0 = 1.5f;
    private void Update()
    {
        int _0xee178fc5 = 1;
        if (this._0xb1360f7f.Count > 0)
        {
            string _0x2664e7a0 = this._0x67239f0a.text;
            foreach (string _0x583df758 in this._0xb1360f7f)
                while (_0x2664e7a0.Contains(_0x583df758))
                    _0x2664e7a0 = _0x2664e7a0.Replace(_0x583df758, "");
            _0xee178fc5 = _0x2664e7a0.Length;
        }
        else
        {
            _0xee178fc5 = this._0x67239f0a.text.Length;
        }

        float _0x1ea7422e = Mathf.Clamp(this._0xf9155477 + this._0xd0fbdf9d * _0xee178fc5, this._0x045c6ae0, this._0x31ace615);
        if (!Mathf.Approximately(this._0x3c493fed.aspectRatio, _0x1ea7422e))
            this._0x3c493fed.aspectRatio = _0x1ea7422e;
    }

    private float _0xd0fbdf9d = 0.6f;
    private float _0x31ace615 = 4;
    private float _0xf9155477;
    private AspectRatioFitter _0x3c493fed;
    private List<string> _0xb1360f7f = new();
    private TMP_Text _0x67239f0a;
}