# ✈️ **Travel Trip Projesi**

---

## 🌟 **Genel Bakış**

Bu proje, seyahat ve gezi temalı dinamik bir web sitesi olarak yapılandırıldı. Kullanıcılar, gezilen yerlerin fotoğraflarını görüntüleyebilir, yorumlar yapabilir ve iletişim bilgilerine erişebilir. Admin paneli aracılığıyla yöneticiler, blog yazıları ekleyip düzenleyebilir ve içerikleri yönetebilirler. Proje, dinamik yapısı sayesinde kullanıcıların etkileşimde bulunmasını ve gezi düzenemelerini görsel olarak fark etmelerini sağlar.

- 👤 Kullanıcılar, kişisel bilgilerini dinamik olarak ekleyebilir, güncelleyebilir ve silebilir.
- 🔒 **Admin paneline sadece authentication olan kullanıcılar** erişebilir. Admin paneline erişim sağlamak isteyen bir kullanıcı giriş yapmamışsa, **login** sayfasına yönlendirilir.
- 🚫 Kullanıcı olmayan bir sayfaya gitmeye çalışırsa, karşısına **özelleştirilmiş 404** sayfası çıkar.
---

## 🚀 **Özellikler**

- 📸 Yapılan gezilerden kareler paylaşmak için Galeri sayfası
- 🛠️ İçerik yönetimi için admin paneli
- 📝 Kullanıcı etkileşimi için Blog ve Yorum sayfaları
- 🛠️ **CRUD** işlemleri (Ekle, Listele, Güncelle, Sil)
- 🌐 Sosyal medya yönlendirmeleri
- ✉️ Kullanıcıların düşünce ve istekleri için **iletişim** formu
- 💻 **Bootstrap** ile responsive tasarım
- 🚫 Özelleştirilmiş **404** sayfası
---

## ⚙️ **Kullanılan Teknolojiler**

- 💻 Web uygulaması yapısı için **ASP.NET MVC Framework**
- 🛠️ ORM (Object-Relational Mapping) aracı olarak **Entity Framework**
- 🗄️ Veritabanı olarak **MSSQL Server**
- 🏗️ Veritabanı modellemesi için **Code First** yaklaşımı
- 🔎 Verileri etkin bir şekilde sorgulamak için **LINQ**
- 🎨 Duyarlı tasarım için **HTML/CSS** ve **Bootstrap**
- 📄 Sayfalar arası geçişleri kolaylaştırmak için **Partial Views**

---

## 👨‍💻 **Code First**

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TravelTripProject.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<WhosMe> whosMes { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Message> messages { get; set; }
    }
}
```
---

## 🛠️ **Kurulum Adımları**

1. 📥 Depoyu klonlayın:  
   `git clone https://github.com/tunadeveloper/TravelTripProject.git`
2. 🖥️ Projeyi Visual Studio'da açın.
3. 🗄️ **MSSQL Server**'ın yüklü ve yapılandırılmış olduğundan emin olun.
4. 📝 `web.config` dosyasındaki bağlantı dizgisini yerel veritabanı ayarlarınıza göre güncelleyin.
5. ▶️ **NuGet Paketlerini Yükleyin**: Projeyi çalıştırmadan önce gerekli NuGet paketlerini yüklemek için aşağıdaki komutu kullanın:
   ```bash
   Update-Package
   
 6. 🛠️ Veritabanını Oluşturun: Code First ile veritabanını oluşturmak için aşağıdaki komutları kullanın:
```bash
Enable-Migrations
Add-Migration InitialCreate
Update-Database
```
7. ▶️ Projeyi Çalıştırın: Projeyi Visual Studio'nun IIS Express'i kullanarak çalıştırın.
---

# 🔑 **Login Paneli**
![login](https://github.com/user-attachments/assets/b2a25273-853b-4a84-a83d-899d97da5d05)

# 🚫 **404 Sayfası**
![404](https://github.com/user-attachments/assets/6160f929-4d59-4cfb-8c0b-d94362b2bf0e)

---
# 👤 **User Paneli**
---
## 🏠 **Anasayfa**
![1](https://github.com/user-attachments/assets/e74125d3-fc12-414e-9dd6-31a32e21943d)
![2](https://github.com/user-attachments/assets/636c86a1-2c7d-473a-8f45-a468dbfc844c)
![3](https://github.com/user-attachments/assets/fd8bef14-5f82-466c-86c9-7ac27107cde1)
![4](https://github.com/user-attachments/assets/7462c496-4ada-4130-8219-64aa73619792)
![5](https://github.com/user-attachments/assets/709343dd-9775-4b3f-b767-6fe172afdb31)

## 📝 **Hakkımızda**
![6](https://github.com/user-attachments/assets/bf175cd4-3f8d-423a-987b-2b4a1fff79f3)
![7](https://github.com/user-attachments/assets/5b170c10-fde7-4bce-ba56-ab0feb1a9876)

## 🖼️ **Galeri**
![8](https://github.com/user-attachments/assets/b387986c-fe03-427d-ad13-aad56c5e6e5d)
![9](https://github.com/user-attachments/assets/fa069ba2-2646-4a19-8dd2-cd7d1c35b2a8)
![10](https://github.com/user-attachments/assets/3ba66bf0-edbf-49a7-bc2e-3f9145ad5bda)

## ✍️ **Blog**
![11](https://github.com/user-attachments/assets/f973f48e-ed45-4cb9-8191-bdf656b6faf1)
![12](https://github.com/user-attachments/assets/2686c537-2414-41bf-bcc9-9d0358ea119b)
![13](https://github.com/user-attachments/assets/847f5b1e-5829-4dae-b83b-0e13ec66ff98)
![14](https://github.com/user-attachments/assets/6857dcc6-f395-449a-958d-b11692d01876)
![15](https://github.com/user-attachments/assets/aa8cf2c8-91c3-4860-8b68-8a47018b797b)

## ✉️ **İletişim**
![16](https://github.com/user-attachments/assets/fb4e8b10-f71f-4801-8de8-c2fbb4d3b411)
![17](https://github.com/user-attachments/assets/324c668d-ce98-498a-a833-807e0a304c09)

## 🔑 *Admin Paneli**
![18](https://github.com/user-attachments/assets/d07f1abc-fa0e-4044-ac18-2ea453e8d225)
![19](https://github.com/user-attachments/assets/503093b9-7f4f-47ef-8e33-74da390f617d)
![20](https://github.com/user-attachments/assets/13b6b657-b0d3-4468-aebe-ea245f9c0a65)
![21](https://github.com/user-attachments/assets/0c6010d0-9e94-4396-b688-09979012082e)
![22](https://github.com/user-attachments/assets/4f07dd1a-6e82-4c07-9e36-5a566d6b09c6)
![23](https://github.com/user-attachments/assets/b217a74f-5d38-4ed2-856e-1e2609e571a8)
![24](https://github.com/user-attachments/assets/9a4a6074-d549-4fc7-bb7e-0a4695343e22)
![25](https://github.com/user-attachments/assets/678509af-692f-4b19-b097-30c4a4da0c65)
![26](https://github.com/user-attachments/assets/b42d6b2d-ee33-4207-9f63-2efa37638f71)
![27](https://github.com/user-attachments/assets/c1b76ed2-434a-4b5d-8010-e24b8e268be8)
![28](https://github.com/user-attachments/assets/0d97e0c9-2eab-46c7-beed-2bd928c754a7)
![29](https://github.com/user-attachments/assets/02f27017-3ae7-4abf-8b34-8c914961a362)
![30](https://github.com/user-attachments/assets/8967626f-0858-4098-a8dd-f79194a082c4)

---
