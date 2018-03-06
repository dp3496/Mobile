namespace Mobile
{
    public interface IMobile
    {
        int Id { get; set; }
        string BrandName { get; set; }

        string GetMacId(string brandname, int id);
    }
}