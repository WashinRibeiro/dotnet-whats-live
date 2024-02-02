namespace WhatsAppFinalApi.Users;

public static class UserFakeDb
{
    public static readonly List<User> Users =
    [
        new User(id: new Guid("13C9D480-52FE-44AA-B0B9-248EAB2F3372"), name: "Harry Potter"),
        new User(id: new Guid("64D17692-60E6-4655-AFED-3E17E1ADCED7"), name: "Albus Dumbledore"),
        new User(id: new Guid("39255C0F-9C63-458A-B637-218EA229A5CA"), name: "Lord Voldemort"),
    ];
}