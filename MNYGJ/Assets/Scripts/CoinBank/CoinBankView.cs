using UnityEngine;
using UnityEngine.UI;

public class CoinBankView : MonoBehaviour
{
    [SerializeField]
    private Text _coinText = null;

    private void Start()
    {
        int coins = CoinBank.GetCoins();
        _coinText.text = string.Format("${0}", coins);
    }
}
