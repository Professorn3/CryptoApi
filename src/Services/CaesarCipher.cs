namespace CryptoApi.Services;

public static class CaesarCipher
{
    public static string Encrypt(string input, int shift) => Shift(input, shift);

    public static string Decrypt(string input, int shift) => Shift(input, -shift);

    private static string Shift(string input, int shift)
    {
        if (string.IsNullOrEmpty(input)) return input;

        // Normalisera shift så att t.ex. 29 blir 3, -29 blir -3
        shift %= 26;

        var chars = input.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = ShiftChar(chars[i], shift);
        }
        return new string(chars);
    }

    private static char ShiftChar(char c, int shift)
    {
        if (c >= 'a' && c <= 'z')
            return ShiftWithinRange(c, 'a', 'z', shift);

        if (c >= 'A' && c <= 'Z')
            return ShiftWithinRange(c, 'A', 'Z', shift);

        // Lämna andra tecken som de är (mellanslag, siffror, åäö, punctuation)
        return c;
    }

    private static char ShiftWithinRange(char c, char min, char max, int shift)
    {
        int range = max - min + 1;
        int offset = c - min;
        int shifted = (offset + shift) % range;

        if (shifted < 0) shifted += range;

        return (char)(min + shifted);
    }
}
