using UnityEngine;

public static class CoinBank
{
    private const string _COIN_BANK_PREFS_KEY = "Coins";

    public static void AddCoins(int amount)
    {
        int currentAmount = GetCoins();
        int newAmount = Mathf.Max(0, currentAmount + amount);
        PlayerPrefs.SetInt(_COIN_BANK_PREFS_KEY, newAmount);
    }

    public static int GetCoins()
    {
        return PlayerPrefs.GetInt(_COIN_BANK_PREFS_KEY, 0);
    }
}
