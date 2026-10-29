using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x19fbab3b : MonoBehaviour
{
    public TMP_Text HeaderText;
    public GameObject OuterBackground;
    public float ScaleDuration = 0.4f;
    private void _0x62ae6134()
    {
        if (this.OuterBackground != null)
        {
            Image _0xebc7e554 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xebc7e554, true);
            _0xebc7e554.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private bool _0xc92776d8 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public void Show()
    {
        this._0x62ae6134();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x50b9d424.Instance._0x91290ee6(_0x50b9d424.Instance.CurrentPanelIndex);
            });
        }
    }

    public void _0x50191284()
    {
        this._0xbdeba879();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private void _0xd64a3dc6()
    {
        if (this.OuterBackground != null)
        {
            Image _0x1969143c = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x1969143c, true);
            _0x1969143c.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private void _0xbdeba879()
    {
        if (this.OuterBackground != null)
        {
            Image _0xf489857a = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xf489857a, true);
            _0xf489857a.DOFade(0f, this.ScaleDuration);
        }
    }

    public TMP_Text MainText;
    public void _0x5789c04e()
    {
        this._0xb2f193ed();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x50b9d424.Instance._0x91290ee6(_0x50b9d424.Instance.CurrentPanelIndex);
    }

    public bool IsScaledDownOnAwake = true;
    public GameObject Content;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xd64a3dc6();
    }

    private void _0xb2f193ed()
    {
        if (this.OuterBackground != null)
        {
            Image _0x258f214e = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x258f214e, true);
            _0x258f214e.DOFade(1f, 0f);
        }
    }

    public Ease Ease = Ease.OutSine;
}