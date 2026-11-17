namespace PowerDns.Client.Models
{
    /// <summary>
    /// Represets a CName record.
    /// </summary>
    public class CNameRecord(CanonicalName absoluteName) : Record(absoluteName.ToString());
}
