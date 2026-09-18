namespace AtProto.OAuth;

internal static class Base64Url
{
    public static string EncodeToString(ReadOnlySpan<byte> data) =>
        Convert.ToBase64String(data)
            .TrimEnd('=')
            .Replace('+', '-')
            .Replace('/', '_');

    public static byte[] DecodeFromChars(string value)
    {
        ArgumentNullException.ThrowIfNull(value);

        foreach (char character in value)
        {
            if (character is not (>= 'A' and <= 'Z')
                and not (>= 'a' and <= 'z')
                and not (>= '0' and <= '9')
                and not '-'
                and not '_')
            {
                throw new FormatException("The value is not valid base64url.");
            }
        }

        string padding = (value.Length & 3) switch
        {
            0 => string.Empty,
            2 => "==",
            3 => "=",
            _ => throw new FormatException("The value is not valid base64url."),
        };

        return Convert.FromBase64String(value.Replace('-', '+').Replace('_', '/') + padding);
    }
}
