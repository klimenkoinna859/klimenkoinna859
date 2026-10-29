using UnityEngine;
using UnityEngine.UI;

public class _0xe15cc4ff : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x44f9825a.Instance._0x787fc083(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
}