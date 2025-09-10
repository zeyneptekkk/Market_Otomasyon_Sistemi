# 🛒 Market Otomasyon Sistemi

Bu proje, **market satış ve yönetim işlemlerini kolaylaştırmak** amacıyla geliştirilmiş bir otomasyon sistemidir.  

---

## 🚀 Özellikler  

### 👑 Admin Paneli  
- **Ürün Yönetimi**  
  - ✅ Yeni ürün ekleme  
  - ✏️ Var olan ürünü güncelleme  
  - ❌ Ürün silme  
  - 📦 Depodaki ürünleri listeleme  

- **Kullanıcı Yönetimi**  
  - ✅ Yeni kullanıcı (kasiyer/admin) ekleme  
  - ✏️ Kullanıcı bilgilerini güncelleme  
  - ❌ Kullanıcı silme  
  - 👥 Tüm kullanıcıları listeleme  

---

### 👨‍💼 Kasiyer Paneli  
- Giriş yaptıktan sonra **kategori seçimi**:  
  - Et  
  - İçecek  
  - Tahıl  
  - Meyve & Sebze  

- Seçilen panelde:  
  - 📋 Kategorideki ürünleri görüntüleme  
  - 📷 Kamera ile ürün barkodu okutma  
  - 🔎 Barkod üzerinden ürünü tanıma  
  - ➕ Ürünü satış listesine ekleme  
  - 💰 Ürün fiyatının **hesap makinesine otomatik eklenmesi** (kasiyer manuel fiyat girmez)  

---

### 🔑 Kullanıcı Hesap Yönetimi  
- 👤 Kullanıcılar **farklı rollerle (Admin / Kasiyer)** giriş yapabilir.  
- 🔒 **Şifre sıfırlama sistemi**:  
  - Kullanıcı şifresini unuttuğunda:  
    1. Kayıtlı **telefon numarasına SMS** gider  
    2. **Güvenlik sorusu** gösterilir  
    3. Cevap doğruysa kullanıcıya **e-posta ile doğrulama linki veya geçici şifre** gönderilir  
    4. Kullanıcı yeni şifresini oluşturabilir  

---

## 🛠️ Kullanılan Teknolojiler  
- **Programlama Dili**: C#  
- **Arayüz**: Windows Forms / WPF (hangisini kullandıysan belirt)  
- **Veritabanı**: SQL Server  
- **Ek Kütüphaneler**:  
  - Barkod/QR Kod Okuyucu (örn. AForge.NET, ZXing.Net)  
  - Kamera entegrasyonu  
  - SMTP (Mail gönderimi)  
  - SMS Servisi (Twilio, Turkcell, Vodafone API vb.)  

---

## 📂 Proje Yapısı  



<img width="874" height="564" alt="Ekran görüntüsü 2025-09-10 234843" src="https://github.com/user-attachments/assets/f24e5b0d-ef34-4f8e-b43b-7e35eab2a0ed" />


<img width="791" height="617" alt="Ekran görüntüsü 2025-09-10 234929" src="https://github.com/user-attachments/assets/8bd21ae1-2d3c-46d1-b91b-07e1b0044286" />

<img width="1135" height="772" alt="Ekran görüntüsü 2025-09-10 234703" src="https://github.com/user-attachments/assets/21bbf9a2-b507-441e-a752-8bc92e322693" />


<img width="696" height="648" alt="Ekran görüntüsü 2025-09-10 234858" src="https://github.com/user-attachments/assets/104665c9-6e62-4768-b239-998fe9883998" />

<img width="791" height="617" alt="Ekran görüntüsü 2025-09-10 234929" src="https://github.com/user-attachments/assets/aefd92c1-b251-4758-bb83-761570f84064" />


<img width="1145" height="794" alt="Ekran görüntüsü 2025-09-10 234944" src="https://github.com/user-attachments/assets/899f84c7-37a4-493a-a92c-73ba194cd492" />

<img width="1157" height="755" alt="Ekran görüntüsü 2025-09-10 235002" src="https://github.com/user-attachments/assets/a1bf769e-c382-46d7-bb4a-45430cac2579" />

