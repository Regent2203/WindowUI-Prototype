using UnityEngine.UI;
using UI.Windows;
using UnityEngine;
using System.Threading.Tasks;
using System.Collections;

public class PreloaderWindow : BaseWindow
{
    [SerializeField]
    private Image _barImage;

    [SerializeField]
    private Text _barPercent;

    private float _progress; //range: [0 .. 1.0f]
    const float minProgress = 0;
    const float maxProgress = 1.0f;
    const int steps = 1000;

    private void Start()
    {
        _progress = minProgress;
        UpdateProgressView();

        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        var step = maxProgress / steps;
        
        while (_progress < maxProgress)
        {
            _progress = Mathf.Min(maxProgress, _progress + step);
            UpdateProgressView();
            yield return null; //1 frame
        }

        yield return new WaitForSeconds(1.2f);
        Completed();
    }

    private void UpdateProgressView()
    {
        _barImage.fillAmount = _progress;
        _barPercent.text = $"{(_progress * 100).ToString("0.0")}%";
    }

    private void Completed()
    {
        Destroy(this.gameObject);
        BaseWindow.WindowManager.ShowWindow(WndId.Main);
    }
}
