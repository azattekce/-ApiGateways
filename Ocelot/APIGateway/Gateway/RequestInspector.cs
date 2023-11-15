namespace Gateway
{
    /*
       Aşağıdaki sınıfın yardımıyla Ocelot'taki belirttiğimiz bir Route'a gelen HTTP istekleri işlenmeden önce araya girebiliriz.
       Request içeriğine bakıp akışı değiştirebiliriz.
       Bu temsilci sınıfını kullanacağımızı yukarıdaki AddDelegatingHandler metodunda belirttik.
       Ayrıca ocelot.json içerisinde, örnek olması açısından /eagames/player/{id} adresine gelen taleplerde araya gireceğimizi belirttik.
   */
    public class RequestInspector : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"\nDevam etmeden önce şu gelen Request içeriğini bir inceyelim\n{request.ToString()}\n");
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
