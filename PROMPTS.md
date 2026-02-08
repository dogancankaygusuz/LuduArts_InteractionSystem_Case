# LLM Kullanım Dokümantasyonu

## Özet
- Toplam prompt sayısı: 9
- Kullanılan araçlar: Gemini-3 Flash
- En çok yardım alınan konular: Mimari plan, Kodun performansını artırma, SOLID, Temiz koda çevirme
- Tahmini LLM ile kazanılan süre : 8 saat

## Prompt 1: Case Projesinin Tanıtımı

**Araç:** Gemini-3 Flash
**Tarih/Saat:** 2026-02-08 13:30

**Prompt:**
> "Kendini Senior Game Developer olarak düşün ve bu sohbetteki bütün cevaplarını bu doğrultuda ver. Unity ve C# kullanarak bir case study yapmam gerekiyor. Bu case için bana en doğru yol haritasını çizmeni, yapmam gerekenleri adım adım detaylı profesyonel bir şekilde açıklamanı istiyorum. Case hakkındaki bazı bilgiler şu şekilde gereken bazı bilgiler ilerleyen kısımlarda verilecek. Oyuncunun dünya içindeki nesnelerle etkileşime geçebileceği modüler bir Interaction System oluşturmalıyız. Projemiz 3D, URP olacak. Bu projede uymamız gereken bazı standartlar yer almakta üreteceğin cevaplarda bunları göz önünde bulundur: - Private field'lar için `m_` prefix'i kullanın
- Private static field'lar için `s_` prefix'i kullanın
- Private const'lar için `k_` prefix'i kullanın
- Prefab'ler `P_` ile başlamalı
- Material'lar `M_` ile başlamalı
- ScriptableObject asset'leri uygun prefix ile oluşturulmalı
- Region'lar standart sırayla kullanılmalı
- Public API'ler XML documentation içermeli
- Silent bypass yapılmamalı (hatalar loglanmalı) bu kurallara dikkat ederek bu projeyi senden yardım alarak tamamlayalım. İlk olarak yol haritamızı belirlemeni ve yapmam gerekenleri belirtmeni istiyorum."

**Alınan Cevap (Özet):**
> "Projede olması gereken standartları incelediğini ve yapacağımız çalışmalarda bunları göz önüne alarak ilerleyeceğimizi belirtti, ilk olarak klasör yapısını doğru bir şekilde oluşturmamı istedi."

**Nasıl Kullandım:**
- [x] Adapte ettim

**Açıklama:**
> "Projede olması gereken klasörleri zaten oluşturacaktım fakat yapay zeka sayesinde daha eksiksiz ve doğru bir yapıda klasör yapısını oluşturmuş oldum."


## Prompt 2: Interaction System & Sahne Kurulumu

**Araç:** Gemini-3 Flash
**Tarih/Saat:** 2026-02-08 14:00

**Prompt:**
> "Zemin: Bir Plane oluştur ve üzerine birkaç Cube koy. Küplerin Layer'ını Interactable yapmayı unutma. Bunların isimlendirmelerini de detaylı bir şekilde hepsini adım adım açıkla. PROMPTS.md: dosyası için bu konuşmayı işle. Bu kısmı da detaylı bir şekilde standartlara uygun profesyonelce yazar mısın? Ayrıca cube player vs. onları da Unity'de yapalım ve özelliklerini de detaylı bir şekilde adım adım açıkla."

**Alınan Cevap (Özet):**
> InteractionDetector script'inin Player üzerindeki konfigürasyonu (RaycastOrigin, LayerMask, Interval) açıklandı. Sahne hiyerarşisinin düzenlenmesi ve profesyonel transform yönetimi (0,0,0 kuralı) vurgulandı.

**Nasıl Kullandım:**
- [x] Direkt kullandım
- [x] Adapte ettim

**Açıklama:**
> Sahne kurulumu ve nesne isimlendirmeleri dökümandaki standartlara %100 uyum sağlayacak şekilde yapılandırıldı. Raycast tabanlı sistemin fizik katmanlarıyla uyumu sağlandı.


## Prompt 3: Etkileşimli Temel Sınıf ve Uygulama

**Araç:** Gemini-3 Flash
**Tarih/Saat:** 2026-02-08 14:10

**Prompt:**
> "Tamamdır sıradaki adımı detaylı bir şekilde adım adım açıkla (Interactable Base Class ve Test nesnesi oluşturma üzerine)."

**Alınan Cevap (Özet):**
> Kod tekrarını önlemek için abstract `InteractableBase` sınıfı oluşturuldu. SOLID prensiplerine uygun olarak `IInteractable` interface'i bu base sınıf üzerinden implement edildi. Test amaçlı `TestInteractable` sınıfı yazılarak Raycast Detector ile ilk uçtan uca etkileşim testi gerçekleştirildi.

**Nasıl Kullandım:**
- [x] Adapte ettim

**Açıklama:**
> Modülerliği artırmak için kalıtım yapısı kuruldu. Loglama işlemleri Ludu Arts standartlarına uygun yapıldı.


## Prompt 4: Oyuncu Hareketi ve Mouse Hareketi

**Araç:** Gemini-3 Flash-Preview
**Tarih/Saat:** 2026-02-08 14:35

**Prompt:**
> "Oyuncu hareket etti fakat mouse kontrolleri istediğimiz gibi çalışmadı, mouse hareketlerinin doğru bir şekilde çalışabilmesi için yapmam gerekenleri detaylı bir şekilde adım adım açıklar mısın, sonrasında sıradaki adıma geçelim."

**Alınan Cevap (Özet):**
> CharacterController tabanlı, FPS standartlarında bir PlayerController script'i düzenlendi. Mouse hareketi sağlandı ve yeni eklenen gravity mantığı açıklandı.

**Nasıl Kullandım:**
- [x] Adapte ettim

**Açıklama:**
> Mouse hareketleri profesyonel standartlarda uygulandı ve test edildi sorun ortadan kalktı.


## Prompt 5: Kullanıcı Arayüzü Etkileşim İstemi Uygulaması

**Araç:** Gemini-3 Flash-Preview
**Tarih/Saat:** 2026-02-08 15:00

**Prompt:**
> "Tamamdır her şey yolunda sıradaki adıma geçelim. (UI Feedback/Prompt sistemi üzerine)"

**Alınan Cevap (Özet):**
> TextMeshPro tabanlı dinamik bir UI Prompt sistemi kuruldu. InteractionDetector'daki C# eventleri kullanılarak Observer Pattern uygulandı. Bu sayede detector bir nesne bulduğunda UI otomatik olarak güncelleniyor. Ludu Arts naming convention ve UI prefab kuralları uygulandı.

**Nasıl Kullandım:**
- [x] Adapte ettim

**Açıklama:**
> Kullanıcı deneyimini (UX) artırmak için nesneye duyarlı dinamik metin sistemi sisteme entegre edildi. Decoupled bir yapı kurulması için event-based mimari tercih edildi.


## Prompt 6: Etkileşimi Tutma ve İlerleme Çubuğu Uygulaması

**Araç:** Gemini-3 Flash-Preview
**Tarih/Saat:** 2026-02-08 16:35

**Prompt:**
> "HoldInteractable ekledikten sonra ayarlamalarını adım adım detaylı bir şekilde anlat"

**Alınan Cevap (Özet):**
> Hold interaction mekaniği için gereken UI hiyerarşisi (Background ve Fill imajları) açıklandı. Unity'nin Image component'indeki 'Filled' özelliği kullanılarak dinamik progress bar yapısı kuruldu. HoldInteractable sınıfının Unity Inspector üzerinden UnityEvent'ler ile nasıl modüler hale getirileceği adım adım rehberlendi.

**Nasıl Kullandım:**
- [x] Direkt kullandım

**Açıklama:**
> UI bileşenlerinin birbirine bağlanması ve script üzerindeki referansların doğru atanması sağlandı. Event-based yaklaşımı ile kod yazmadan etkileşim sonuçları oluşturulabilmesi sağlandı.


## Prompt 7: Kapı Etkileşiminde NullReferenceException Hatasını Düzeltme

**Araç:** Gemini-3 Flash-Preview
**Tarih/Saat:** 2026-02-08 17:45

**Prompt:**
> "Oyunu çalıştırdım fakat console da şu şekilde bir hata aldım. Çözümünü ve yapmam gerekenleri detaylı bir şekilde adım adım açıkla. NullReferenceException: Object reference not set to an instance of an object... [Hata Metni]"

**Alınan Cevap (Özet):**
> Hatanın kaynağı olan atanmamış referanslar (RequiredKey) ve eksik InventoryManager tespiti analiz edildi. Ludu Arts'ın 'Silent Bypass' yasağına uygun olarak Debug.LogError içeren güvenli kod blokları sağlandı. ScriptableObject alanlarının (ID, Name, Icon) nasıl doldurulacağı detaylandırıldı.

**Nasıl Kullandım:**
- [x] Adapte ettim

**Açıklama:**
> Kodun çalışma anında çökmesini önlemek için null-check mekanizmaları eklendi. Geliştirme sürecindeki hataların loglanması standardı uygulandı.

## Prompt 8: MissingReferenceException hatasının ele alınması ve karmaşık etkileşimli nesnelerin uygulanması

**Araç:** Gemini-3 Flash-Preview
**Tarih/Saat:** 2026-02-08 18:10

**Prompt:**
> "MissingReferenceException: The object of type 'InteractionSystem.Runtime.Interactables.Door' has been destroyed... bu hata var. Bu hatanın nedenini ve çözümünü detaylı bir şekilde adım adım açıkla."

**Alınan Cevap (Özet):**
> Unity Editor'ün "Missing Object" referans hatası analiz edildi ve InteractionDetector sınıfına null-check koruması eklendi.

**Nasıl Kullandım:**
- [x] Direkt kullandım
- [x] Adapte ettim

**Açıklama:**
> Editor kaynaklı hatalar giderilerek sistem stabilitesi artırıldı.


## Prompt 9: Sandık ve Anahtar Sistemlerinin Yeniden Yapılandırılması

**Araç:** Gemini-3 Flash-Preview
**Tarih/Saat:** 2026-02-08 20:00

**Prompt:**
> "Chestte anahtar kısmı sıkıntılı aynı şekilde switch te bu arada düzeltmem gereken kısımları detaylı bir şekilde adım adım açıkla."

**Alınan Cevap (Özet):**
> Chest ve Switch sistemleri, daha robust ve görsel geri bildirimli sınıflar (`Chest.cs`, `Switch.cs`) ile refactor edildi. Sandığın tek seferlik açılma mantığı ve eşya verme süreci InventoryManager ile entegre edildi. Switch sisteminin UnityEvent yapısı üzerinden başka Interactable nesnelerle nasıl zincirleme etkileşim kuracağı detaylandırıldı.

**Nasıl Kullandım:**
- [x] Direkt kullandım

**Açıklama:**
> Nesneler arası mantıksal hatalar giderildi ve sistem daha sürdürülebilir hale getirildi. Görsel rotasyon animasyonları koda eklenerek kullanıcı deneyimi artırıldı.

## Genel Değerlendirme

**LLM'in En Çok Yardımcı Olduğu Alanlar**
> Mimari Tasarım ve SOLID: Sistemin sadece "çalışan" değil, aynı zamanda "sürdürülebilir" olması için Interface ve Base Class yapısının kurgulanmasında stratejik destek sağladı.
> Karmaşık Nesne Hiyerarşisi: Özellikle Şalter (Switch) ve Sandık (Chest) gibi nesnelerde Pivot Point (menteşe) mantığının kurulması ve Root-Visual ayrımının yapılmasında doğru hiyerarşik yapıyı adım adım planladı.

**LLM'in Yetersiz Kaldığı Alanlar**
> Görsel ve Uzamsal Farkındalık: Unity sahnesini fiziksel olarak göremediği için Box Collider'ların tam boyutları veya nesnelerin sahne üzerindeki birbirine göre konumlandırmaları gibi görsel hataları fark edemedi. Bu kısımlarda manuel müdahale ve test süreci gerekti.
> Unity Editor Hataları: Unity'nin bazen Inspector'ı geç yenilemesi veya MissingReferenceException gibi Editor tabanlı anlık hataların çözümünde, LLM sadece teorik bilgi verebildi; fiziksel "Clear" işlemi veya referansın sürüklenip bırakılması gibi eylemler tarafımdan yönetildi.

**LLM Kullanımı Hakkında Düşüncelerim**
> Bu case boyunca LLM'i bir kod yazdırıcı değil, bir Senior Game Developer olarak kullandım. Kodun sadece syntax kısmında değil, mantıksal kurgusunda ve standartlara uyumunda bir mentorluk aldım.

**LLM'siz ne kadar sürede bitirebilirdiniz?**
> LLM desteği olmasaydı, Ludu Arts'ın dökümante ettiği standartları tek tek analiz edip koda dökmek ve karmaşık etkileşim türleri için en iyi mimariyi araştırmak muhtemelen 16-18 saatimi alırdı. LLM ile bu süreci 12 saatin altında, çok daha yüksek bir kod kalitesiyle tamamladım.

**Gelecekte LLM'i nasıl daha etkili kullanabilirsiniz?**
Gelecekte LLM'i özellikle tekrarlayan kod bloklarını hızlıca oluşturmak ve karmaşık matematiksel algoritmaları optimize etmek için kullanmaya devam edeceğim. Ancak görsel mizanpaj ve fiziksel test süreçlerinde manuel testin yerinin doldurulamaz olduğunu bir kez daha anladım.

*Bu şablon Ludu Arts Unity Intern Case için hazırlanmıştır.*