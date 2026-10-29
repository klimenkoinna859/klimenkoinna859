using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x0b45279c : MonoBehaviour
{
    private void _0xe996021d()
    {
        if (this._0x264daa0b.canvasRenderer.GetColor() != this._0xc917d6a2.canvasRenderer.GetColor())
            this._0xc917d6a2.canvasRenderer.SetColor(this._0x264daa0b.canvasRenderer.GetColor());
    }

    private TMP_Text _0xc917d6a2;
    private void Update()
    {
        this._0xe996021d();
    }

    private Image _0x264daa0b;
}