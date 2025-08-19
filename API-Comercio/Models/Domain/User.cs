namespace API_Comercio.Models.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password {  get; set; } = string.Empty;
        public EAccessLevel AccessLevel { get; set; }
        public enum EAccessLevel
        {
            Salesperson,
            Administrator
        }
    }
}
