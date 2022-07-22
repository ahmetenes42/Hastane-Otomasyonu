C# Hastane-Otomasyonu

Öncelikle 5 farklı birim var (admin, doktor, hemşire, sekreter, laborant) ve bu 5 farklı birimede ayrı ayrı giriş yapılıp işlem yapılıyor. 
Başhekim (Admin): Personel ekleme, silme, güncelleme, personele izin verme ve eczane (ilaç) işlemleri gerçekleşiyor.
Doktor: Giriş yapan doktor kimse o doktorun hastaları listeleniyor. Filtreleme sayesinde eski hastalarını görebiliyor ve hastaya yatış verebiliyor tahlil isteyebiliyor reçete yazabiliyor bu reçeteyi de sekreter kısmından çıkartabiliyoruz.
Hemşire: Yatış verilen hastalar hemşire sistemine düşüyor ve burda hastaların günlük aldıkları ilaçlarını ve tedavi edilip edilmediğini görebiliyor.Yatış verilen hastaları taburcu edebiliyor.
Sekreter: Hastalara randevu verebiliyor hasta hangi doktordan randevu aldıysa o doktorun sistemine hasta düşüyor ve ek olarak reçeteyi pdf olarak çıkartma işlemi'de burada gerçekleşiyor.
Laborant: Doktor hastasından tahlil istediği zaman bu hasta laborant sistemine düşüyor ve tahlil işlemlerini yapıp tekrar doktor sistemine tahlil sonuçları gönderiliyor.


Veritabanı proje dosyası içerisinde mevcut.
Kullanıcı girişleri veritabanındaki kullanıcı adı ve şifre ile yapılıyor.
Her birim için ayrı form var o yüzden giriş sisteminde kullanıcı adı ve şifreyi ve ek olarak birimini kontrol ederek giriş yapan kişi hangi birime aitse o birimin formuna kullanıcıyı atıyoruz.
