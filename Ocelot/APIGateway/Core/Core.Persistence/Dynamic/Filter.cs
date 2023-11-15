namespace Core.Persistence.Dynamic;

public class Filter
{
    public string Field { get; set; }// Sorgudaki alanı ifade eder .
    public string Operator { get; set; } // Sorgudaki operetörü ifade eder. LIKE ,IN
    public string? Value { get; set; } //Sorgudaki alanın değerini tutar
    public string? Logic { get; set; }// And Or  kuralı için tanımlanır.
    public IEnumerable<Filter>? Filters { get; set; }// Sorguya birçok filte ekleyebiliriz.

    public Filter()
    {
        Field = string.Empty;
        Operator = string.Empty;
    }

    public Filter(string field, string @operator)
    {
        Field = field;
        Operator = @operator;
    }
}
