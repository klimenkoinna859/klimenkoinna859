using TMPro;
using UnityEngine;
using static _0xdfe619ff;

public class _0x5cc60f4d : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    public void _0x6a8a4ab4()
    {
        this.MoneyCountText.text = _0xd23f50e2._0xf3225ca8.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xfb64590b;
            if (this.gameObject.TryGetComponent(out _0xfb64590b))
                this.MoneyCountText = _0xfb64590b;
        }

        this._0x6a8a4ab4();
    }
}