namespace AlulaShop.Domain.Entities
{
    /// <summary>
    /// <see cref="long"/>
    /// </summary>
    public class FileImage :Entity<long> 
    {
        public string FileName { get; set; }
        public Product Product { get; set; }
    }
}