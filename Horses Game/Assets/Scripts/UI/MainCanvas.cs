using Core;
using TMPro;
using UnityEngine;
using Utility;

namespace UI
{
    public class MainCanvas : MonoBehaviour
    {
        private Canvas _canvas;
        private TextMeshProUGUI _startTimerText;

        private void Awake()
        {
            _canvas = GetComponent<Canvas>();

            _startTimerText =
                GameObject.FindGameObjectWithTag(Constants.START_TIMER_TEXT_TAG)
                .GetComponent<TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            EventManager.OnShowTimeInMainCanvas += HandleOnShowTimeInMainCanvas;
            EventManager.OnHorsesStartRun += HandleOnHorsesStartRun;
            EventManager.OnAllHorsesFinish += HandleOnAllHorsesFinish;
        }

        private void OnDisable()
        {
            EventManager.OnShowTimeInMainCanvas -= HandleOnShowTimeInMainCanvas;
            EventManager.OnHorsesStartRun -= HandleOnHorsesStartRun;
            EventManager.OnAllHorsesFinish -= HandleOnAllHorsesFinish;
        }

        private void HandleOnShowTimeInMainCanvas(float time)
        {
            _startTimerText.text = time.ToString("0");
        }

        private void HandleOnHorsesStartRun()
        {
            _canvas.enabled = false;
        }

        private void HandleOnAllHorsesFinish()
        {
          Debug.Log("All Horses Finish");
        }
    }
}