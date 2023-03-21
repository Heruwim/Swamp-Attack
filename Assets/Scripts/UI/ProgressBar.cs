using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : Bar
{
    [SerializeField] private Spawner _spawner;

    private void OnEnable()
    {
        _spawner.EnemyCountChanged += OnValueChenged;
        Slider.value = 0;

    }

    private void OnDisable()
    {
        _spawner.EnemyCountChanged -= OnValueChenged;
    }
}
