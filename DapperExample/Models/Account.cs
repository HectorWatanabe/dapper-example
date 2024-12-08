namespace DapperExample.Models
{
    public class Account
    {
        public long Id { get; set; }
        public string Number { get; set; } = string.Empty;
        public string Bank { get; set; } = string.Empty;
        public float Amount { get; set; }
    }
}
