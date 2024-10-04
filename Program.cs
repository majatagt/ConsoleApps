

Console.WriteLine("This is the ticket selling class! ");
TicketSeller sellingtickets = new TicketSeller();
sellingtickets.ReadInput();
sellingtickets.CalculateAmountToPay();
sellingtickets.DisplayResults();
Console.WriteLine("--------------------------------------");
Console.WriteLine("--------------------------------------");


Console.WriteLine("Here we store information and albums - the Album class ");
Album album = new Album();

album.ReadAlbumName();

album.DisplayAlbumInfo();
album.DisplayArtistName();
album.ReadTracks();
Console.WriteLine("--------------------------------------");
Console.WriteLine("--------------------------------------");

Console.WriteLine("This is the Pet class!");
Pet pet = new Pet();
pet.ReadAndSavePetData();
Console.WriteLine("--------------------------------------");
Console.WriteLine("--------------------------------------");

Console.WriteLine("This is my own class where I sell burgers at a restaurant!");
Burger burger = new Burger();

burger.PurchaseDate();
burger.WriteInput();
burger.PrintReceipt();
Console.WriteLine("--------------------------------------");
Console.WriteLine("--------------------------------------");
