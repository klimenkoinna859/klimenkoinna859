using UnityEngine;
using UnityEngine.UI;

public class _0x9170d3bf : MonoBehaviour
{
    private int _0x03fdfba3;
    private void Start()
    {
        if (this._0x39223763)
            this._0xffc5cf47.onClick.AddListener(() => _0x50b9d424.Instance._0x36f446ad());
        else
            this._0xffc5cf47.onClick.AddListener(() => _0x50b9d424.Instance._0x19681e8b(this._0x03fdfba3));
    }

    private bool _0x39223763;
    private void Awake()
    {
        if (this._0xffc5cf47 == null)
            if (!this.TryGetComponent(out this._0xffc5cf47))
                this._0xffc5cf47 = this.GetComponentInChildren<Button>();
    }

    private Button _0xffc5cf47;
}