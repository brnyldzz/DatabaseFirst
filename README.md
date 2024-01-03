# DatabaseFirst
Projede **C#** ve **SQL Server Management Studio 19** kullandım. 
İlk aşamada; Bir LOGIN sayfası oluşturup takip sistemine erişebilmek için kullanıcı adı ve şifre girilmesini istedim. İkinci aşamada; C# üzerinden MDIParent ekleyip formlar arası geçiş kodlarını yazdım. Formlara textbox, button, label ve datagridview ekleyerek hangi Tool' a ne yapılması gerektiğini gösteren kodları yazdım. Üçüncü aşamada; northwind adlı veritabanında bulunan tabloları ADO.NET Entity Data Model ile C#'a entegre ettim. Oluşturmuş olduğum tablolar için CRUD işlemlerini C# üzerinden Entity kullanarak yazdım. Where(x => x.ID == id).FirstOrDefault(); **(LINQ)** kullanarak nesne oluşturdum.


<h2 align="left">Amaç</h2>
Veritabanı ile web sitesini bağlamanın iki yolu var:
Database First,
Code First.
Database first ile bağlamayı öğrenip bildiklerimi pekiştirmek.
