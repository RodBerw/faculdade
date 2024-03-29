using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.MapGet("/user", () => new {name = "Bernardo Druziki", Age = 19}); //GET É O METODO DE ACESSO.

app.MapPost("/savebook", (Book book) => { //SALVAR O PRODUTO.
    BookRepository.Add(book);
});

app.MapGet("/getbook/{code}", ([FromRoute] string code) => { //VISUALIZAR(OU OBTER) O PRODUTO SALVO.
    var book = BookRepository.GetBy(code);
    return book;
});

app.MapPut("/editbook", (Book book) => { //EDITAR PRODUTO.
    var bookSaved = BookRepository.GetBy(book.Code);
    bookSaved.Name = book.Name;
    bookSaved.author = book.author;
    bookSaved.genre = book.genre;
    bookSaved.publisher = book.publisher;
    bookSaved.year = book.year;
});

app.MapDelete("/deletebook/{code}", ([FromRoute] string code) => { //DELETAR PRODUTO.
    var bookSaved = BookRepository.GetBy(code);
    BookRepository.Remove(bookSaved);
});
////////////////////////////////////////////////////////


app.MapPost("/saveuser", (Client client) => { //SALVAR O USER.
    UserRepository.Add(client);
});

app.MapGet("/getuser/{code}", ([FromRoute] string code) => { //VISUALIZAR(OU OBTER) O USER SALVO.
    var user = UserRepository.GetBy(code);
    return user;
});

app.MapPut("/edituser", (Client client) => { //EDITAR USER.
    var userSaved = UserRepository.GetBy(client.Code);
    userSaved.userName = client.userName;
    userSaved.gender = client.gender;
    userSaved.bornDate = client.bornDate;
    userSaved.cpf = client.bornDate;
});

app.MapDelete("/deleteuser/{code}", ([FromRoute] string code) => { //DELETAR USER.
    var userSaved = UserRepository.GetBy(code);
    UserRepository.Remove(userSaved);
});
app.Run();

public static class BookRepository //FONTE DE DADOS
{
    public static List <Book> Books { get; set; }

    public static void Add(Book book) //ADD PRODUTO
    {
        if(Books == null)
            Books =  new List<Book>();

        Books.Add(book);
    }

    public static Book GetBy(string code) //PEGAR (GET) PELO CÓDIGO (CODE).
    {
        return Books.FirstOrDefault(p => p.Code == code); 
    }

    public static void Remove(Book book)
    {
        Books.Remove(book);
    }
}
////////////////////////////////////////////


public static class UserRepository //FONTE DE DADOS
{
    public static List <Client> Clients { get; set; }

    public static void Add(Client client) //ADD PRODUTO
    {
        if(Clients == null)
            Clients =  new List<Client>();

        Clients.Add(client);
    }

    public static Client GetBy(string code) //PEGAR (GET) PELO CÓDIGO (CODE).
    {
        return Clients.FirstOrDefault(p => p.Code == code); 
    }

    public static void Remove(Client client)
    {
        Clients.Remove(client);
    }
}


public class Book 
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string author { get; set; }
    public string genre { get; set; }
    public string publisher { get; set; }
    public int year { get; set; }

}

 public class Client
{
     public string userName { get; set; }
     public string Code { get; set; }
     public string gender { get; set; }
     public string bornDate { get; set; }
     public string cpf { get; set; }

}
