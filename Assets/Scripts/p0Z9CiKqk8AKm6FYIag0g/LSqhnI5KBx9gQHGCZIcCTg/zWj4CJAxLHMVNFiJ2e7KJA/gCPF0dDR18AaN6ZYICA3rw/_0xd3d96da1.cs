using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xd3d96da1 : MonoBehaviour
{
    public int LoadSceneId;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x44f9825a.Instance._0x0e9ebb6d(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x44f9825a.Instance._0x0e9ebb6d(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
}