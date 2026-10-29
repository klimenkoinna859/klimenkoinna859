using UnityEngine;
using UnityEngine.UI;

public class _0x267f341b : MonoBehaviour
{
    public int NextTutorialPanelIndex;
    public Button TutorialEndButton;
    public int EndTutorialPanelIndex = 1;
    public bool IsTutorialEndPanel;
    public Button NextTutorialButton;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x50b9d424.Instance._0x19681e8b(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x44f9825a.Instance._0x0f1c8f25());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x50b9d424.Instance._0x19681e8b(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x50b9d424.Instance._0x19681e8b(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x44f9825a.Instance._0x0f1c8f25());
        }
    }
}