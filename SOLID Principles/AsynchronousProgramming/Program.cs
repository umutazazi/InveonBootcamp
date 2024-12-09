// Eşzamanlı (Synchronous) Uzun Süre Alan Metot
static void LongRunningSync()
{
    var list = new List<int>();
    for (int i = 0; i < 10; i++)
    {
        list.Add(i);
        Console.WriteLine($"Eşzamanlı işlem: {i}");
        System.Threading.Thread.Sleep(500); // İşlemi yavaşlatmak için bekleme
    }
}

// Asenkron (Asynchronous) Uzun Süre Alan Metot
static async Task LongRunningAsync()
{
    var list = new List<int>();
    for (int i = 0; i < 10; i++)
    {
        list.Add(i);
        Console.WriteLine($"Asenkron işlem: {i}");
        await Task.Delay(500); // İşlemi yavaşlatmak için asenkron bekleme
    }
}

//Task statik metod örnekleri

//Task.Run
Task.Run(() => Console.WriteLine("Task.Run ile arka plan işlemi çalıştı."));

//Task Delay
await Task.Delay(1000); // 1 saniye bekleme

//WhenAll
var task1 = Task.Run(() => Console.WriteLine("Task 1"));
var task2 = Task.Run(() => Console.WriteLine("Task 2"));

await Task.WhenAll(task1, task2);

//WhenAny
var task3 = Task.Run(() => { Task.Delay(1000).Wait(); Console.WriteLine("Task 1 tamamlandı."); });
var task4 = Task.Run(() => { Task.Delay(500).Wait(); Console.WriteLine("Task 2 tamamlandı."); });

await Task.WhenAny(task1, task2);
Console.WriteLine("İlk task tamamlandı.");

//FromResult
var completedTask = Task.FromResult("Sonuç hazır.");
Console.WriteLine(await completedTask);

//FromException
var failedTask = Task.FromException(new InvalidOperationException("Hata oluştu!"));
try
{
    await failedTask;
}
catch (Exception ex)
{
    Console.WriteLine($"Yakalanan hata: {ex.Message}");
}

//FromCanceled
var cts = new System.Threading.CancellationTokenSource();
var canceledTask = Task.FromCanceled(cts.Token);
Console.WriteLine($"İptal edilen task: {canceledTask.Status}");


//3.Görev
// Asenkron dosya okuma işlemi
static async Task<string> ReadFileAsync(string filePath)
{
    if (string.IsNullOrEmpty(filePath))
        throw new ArgumentException("Dosya yolu boş olamaz!");

    using (StreamReader reader = new StreamReader(filePath))
    {
        // Dosyayı asenkron olarak oku
        string content = await reader.ReadToEndAsync();
        return content;
    }
}
