using UnityEngine;
using UnityEngine.UI;

public class _0x44e88c5f : MonoBehaviour
{
    public bool IsShowLastPop;
    public bool IsHideAllPops;
    public int PopToShowIndex;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x18ece92a.Instance._0xe670cf8c();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x18ece92a.Instance._0xb88f638f());
        else
            this.Button.onClick.AddListener(() => _0x18ece92a.Instance._0x97e1675c(this.PopToShowIndex));
    }

    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}