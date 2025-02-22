namespace APIGateway_Ocelot.Model;

public class User(string name, string email)
{
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
}