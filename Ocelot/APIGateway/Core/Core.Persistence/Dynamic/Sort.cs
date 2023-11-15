namespace Core.Persistence.Dynamic;

public class Sort
{
    public string Field { get; set; }// Sorguda hangi alana göre sıralama yapılacak.
    public string Dir { get; set; }// Hangi yöne A>Z ya da Z<Â (asc-desc)

    public Sort()
    {
        Field = string.Empty;
        Dir = string.Empty;
    }

    public Sort(string field, string dir)
    {
        Field = field;
        Dir = dir;
    }
}
