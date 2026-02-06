namespace CryptoApi.Models;

public class CryptoRequest
{
    public string Text { get; set; } = string.Empty;
    public int Shift { get; set; } = 3; // default
}
