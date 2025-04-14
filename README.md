# MyPortfolio

MyPortfolio, ASP.NET Core MVC kullanılarak geliştirilmiş bir portföy yönetim uygulamasıdır.  
Kullanıcıların projelerini ekleme, düzenleme ve silme işlemlerini gerçekleştirebileceği bu uygulama, temiz mimari prensiplerini benimseyerek Repository Pattern ve Unit of Work tasarım desenlerini kullanır.  
Bu sayede uygulama, ölçeklenebilirlik ve sürdürülebilirlik açısından avantaj sağlar.

## 🚀 Özellikler

- **Proje Yönetimi**: Kullanıcılar, portföylerine yeni projeler ekleyebilir, mevcut projeleri düzenleyebilir veya silebilirler.
- **CRUD İşlemleri**: Projeler üzerinde Tam Ekleme, Okuma, Güncelleme ve Silme işlemleri desteklenir.
- **Repository & Unit of Work**: Veri erişimi için bu tasarım desenleri kullanılarak kod organizasyonu ve veri yönetimi iyileştirilmiştir.
- **Kullanıcı Kimlik Doğrulama**: Kullanıcılar, güvenli bir kimlik doğrulama sistemi ile portföylerini yönetebilirler.
- **Duyarlı Arayüz**: Modern web teknolojileri kullanılarak oluşturulan kullanıcı arayüzü, sezgisel ve kullanıcı dostudur.

## 🛠️ Kullanılan Teknolojiler

- **ASP.NET Core MVC** – Model-View-Controller deseni ile web uygulaması geliştirme
- **Entity Framework Core** – Veri erişimi ve SQL Server veritabanı ile etkileşim için ORM
- **SQL Server** – Proje verilerini depolamak için veritabanı yönetim sistemi
- **HTML, CSS, JavaScript** – Etkileşimli kullanıcı arayüzü oluşturmak için ön yüz teknolojileri
- **Bootstrap** – Duyarlı ve mobil öncelikli tasarım için CSS framework

## 📁 Proje Yapısı

Proje, MVC (Model-View-Controller) mimarisini takip eder ve aşağıdaki bileşenleri içerir:

- `Models/` – Veri yapısını temsil eden sınıflar (örneğin, Proje, Kullanıcı modelleri)
- `Views/` – Kullanıcıya bilgi sunumunu yöneten görünümler (örneğin, proje listesi, detaylar)
- `Controllers/` – Uygulama mantığını yöneten sınıflar
- `Repositories/` – Veritabanı işlemlerini gerçekleştiren katman
