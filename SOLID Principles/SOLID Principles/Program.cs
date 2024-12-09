// SRP doğru kullanımı

using SOLID_Principles.DependencyInversion;
using SOLID_Principles.InterfaceSegration;
using SOLID_Principles.LiskovSubstitution;
using SOLID_Principles.OpenClosed;
using SOLID_Principles.SingleResponsibility;

// Bağımlılıkları oluştur
IUserRepository userRepository = new UserRepository();
IEmailService emailService = new EmailService();

// UserManager'ı bağımlılıklarla başlat
UserManager userManager = new UserManager(userRepository, emailService);

// Kullanıcı ekle ve e-posta gönder
userManager.AddUser("Ali", "ali@example.com");

////////////////////////////////////////////////////////////////////////////////////
//OCP doğru kullanımı 

// Alan hesaplayıcı
AreaCalculator calculator = new AreaCalculator();

// Dikdörtgenin alanını hesapla
IShape rectangle = new Rectangle(5, 10);
Console.WriteLine("Dikdörtgen Alanı: " + calculator.Calculate(rectangle));

// Dairenin alanını hesapla
IShape circle = new Circle(7);
Console.WriteLine("Daire Alanı: " + calculator.Calculate(circle));

// Üçgenin alanını hesapla (Yeni bir şekil eklemek istersek)
//IShape triangle = new Triangle(6, 8);
//Console.WriteLine("Üçgen Alanı: " + calculator.Calculate(triangle));

/////////////////////////////////////////////////////////////////////
//Liskov Doğru Kullanımı
// Serçe
Bird sparrow = new Sparrow();
sparrow.Eat();

IFlyable flyableSparrow = new Sparrow();
flyableSparrow.Fly();

// Penguen
Bird penguin = new Penguin();
penguin.Eat();

// penguin.Fly(); // Bu hata vermez çünkü IFlyable implement edilmemiştir.

//////////////////////////////////////////////////////////////////
//ISP Doğru kullanımı
IDrivable car = new Car();
car.Drive(); // Sorunsuz çalışır.

IFlyable plane = new Plane();
plane.Fly(); // Sorunsuz çalışır.

ISailable boat = new Boat();
boat.Sail(); // Sorunsuz çalışır.

///////////////////////////////////////////////////////////////////
//DIP Doğru kullanımı
// IoC: Bağımlılıkların dışarıdan sağlanması
IDatabase sqlDatabase = new SqlDatabase();
OrderService sqlOrderService = new OrderService(sqlDatabase);
sqlOrderService.ProcessOrder("Laptop");

IDatabase mongoDatabase = new MongoDatabase();
OrderService mongoOrderService = new OrderService(mongoDatabase);
mongoOrderService.ProcessOrder("Tablet");