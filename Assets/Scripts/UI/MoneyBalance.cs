using UnityEngine;
using TMPro;

public class MoneyBalance : MonoBehaviour
{
    [SerializeField] private TMP_Text _money;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _money.text = _player.Money.ToString();
        _player.MoneyChanged += OnMoneChanged;
    }

    private void OnDisable()
    {
        _player.MoneyChanged -= OnMoneChanged;
    }

    private void OnMoneChanged(int money)
    {
        _money.text = money.ToString();
    }
}
