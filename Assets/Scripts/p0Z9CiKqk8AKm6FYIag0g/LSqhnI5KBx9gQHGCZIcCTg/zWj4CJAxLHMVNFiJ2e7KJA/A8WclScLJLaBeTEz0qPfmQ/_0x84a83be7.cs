using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x84a83be7 : MonoBehaviour
{
    private bool _0x2a738695 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public Image ContentImage;
    public float scaleDuration = 0.4f;
    public TMP_Text ContentAdditionalText;
    public void _0x606d29ea()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public static void HideAllPops()
    {
        _0x18ece92a.Instance._0xb88f638f();
    }

    private void Start()
    {
    // Content.SetActive(false);
    }

    public Ease ease = Ease.OutSine;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xac0a9f04();
    }

    public bool IsOnlyYScale;
    public GameObject Content;
    public TMP_Text ContentMainText;
    public TMP_Text ContentHeaderText;
    private void _0xac0a9f04()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public bool IsScaledDownOnAwake = true;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }
}