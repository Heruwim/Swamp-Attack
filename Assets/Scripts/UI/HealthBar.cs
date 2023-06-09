using UnityEngine;
using UnityEngine.UI;

public class HealthBar : Bar
{
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.HealthChanged += OnValueChenged;
        Slider.value = 1;

    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnValueChenged;
    }
}
