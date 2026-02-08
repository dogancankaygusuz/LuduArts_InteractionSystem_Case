# LLM Usage Documentation

## Summary
- Total Prompts: 2
- Tools Used: Gemini
- Most Helped Topics: Architecture planning, coding conventions analysis.

## Prompt [Numara]: [Konu Başlığı]

**Tool:** ChatGPT-4
**Date/Time:** 2026-02-08 14:45

**Prompt:**
> "[Buraya bana yazdığın promptun tam metnini yapıştır]"

**Response (Summary):**
> "[Buraya benim verdiğim cevabın ana hatlarını, sunduğum çözümü özetle]"

**How I Used It:**
- [ ] Directly used
- [x] Adapted
- [ ] Rejected

**Explanation:**
> [Buraya neden kullandığını veya neyi değiştirdiğini yaz. Örn: "Kod standartlarını m_ prefixine uyarlayarak projeye dahil ettim."]



## Prompt 3: InteractionDetector Implementation & Scene Setup

**Tool:** ChatGPT-4
**Date/Time:** 2026-02-08 15:40

**Prompt:**
> "Zemin: Bir Plane oluştur ve üzerine birkaç Cube koy. Küplerin Layer'ını Interactable yapmayı unutma. Bunların isimlendirmelerini de detaylı bir şekilde hepsini adım adım açıkla. PROMPTS.md: 'Prompt 3: InteractionDetector Implementation' başlığıyla bu konuşmayı işle. Bu kısmı da detaylı bir şekilde standartlara uygun profesyonelce yazar mısın? Ayrıca cube player vs. onları da Unity'de yapalım ve özelliklerini de detaylı bir şekilde adım adım açıkla."

**Response (Summary):**
> Ludu Arts Naming Convention standartlarına uygun (SM_ prefixi zemin için, P_ prefixi player ve küpler için) sahne kurulumu rehberi sağlandı. InteractionDetector script'inin Player üzerindeki konfigürasyonu (RaycastOrigin, LayerMask, Interval) açıklandı. Sahne hiyerarşisinin düzenlenmesi ve profesyonel transform yönetimi (0,0,0 kuralı) vurgulandı.

**How I Used It:**
- [x] Directly used

**Explanation:**
> Sahne kurulumu ve nesne isimlendirmeleri dökümandaki standartlara %100 uyum sağlayacak şekilde yapılandırıldı. Raycast tabanlı sistemin fizik katmanlarıyla (LayerMask) uyumu sağlandı.




## Prompt 4: Interactable Base Class and Implementation

**Tool:** Gemini-3 Flash-Preview
**Date/Time:** 2026-02-08 16:10

**Prompt:**
> "Tamamdır sıradaki adımı detaylı bir şekilde adım adım açıkla (Interactable Base Class ve Test nesnesi oluşturma üzerine)."

**Response (Summary):**
> Kod tekrarını önlemek için abstract `InteractableBase` sınıfı oluşturuldu. SOLID prensiplerine uygun olarak `IInteractable` interface'i bu base sınıf üzerinden implement edildi. Test amaçlı `TestInteractable` sınıfı yazılarak Raycast Detector ile ilk uçtan uca etkileşim testi (renk değiştirme) gerçekleştirildi.

**How I Used It:**
- [x] Directly used

**Explanation:**
> Modülerliği artırmak için kalıtım (inheritance) yapısı kuruldu. Loglama işlemleri Ludu Arts standartlarına (Silent bypass önleme) uygun yapıldı.


## Prompt 5: Player Movement and Mouse Movement

**Tool:** Gemini-3 Flash-Preview
**Date/Time:** 2026-02-08 15:20

**Prompt:**
> "Oyuncu hareket etti fakat mouse kontrolleri istediğimiz gibi çalışmadı, mouse hareketlerinin doğru bir şekilde çalışabilmesi için yapmam gerekenleri detaylı bir şekilde adım adım açıklar mısın, sonrasında sıradaki adıma geçelim."

**Response (Summary):**
> CharacterController tabanlı, FPS standartlarında bir PlayerController script'i düzenlendi. Mouse hareketi sağlandı ve yeni eklenen gravity mantığı açıklandı.

**How I Used It:**
- [x] Adapted

**Explanation:**
> Mouse hareketleri profesyonel standartlarda uygulandı ve test edildi sorun ortadan kalktı.



## Prompt 6: UI Interaction Prompt Implementation

**Tool:** ChatGPT-4
**Date/Time:** 2026-02-08 17:10

**Prompt:**
> "Tamamdır her şey yolunda sıradaki adıma geçelim. (UI Feedback/Prompt sistemi üzerine)"

**Response (Summary):**
> TextMeshPro tabanlı dinamik bir UI Prompt sistemi kuruldu. InteractionDetector'daki C# eventleri (Action) kullanılarak Observer Pattern uygulandı. Bu sayede detector bir nesne bulduğunda UI otomatik olarak güncelleniyor. Ludu Arts naming convention ve UI prefab kuralları (P_UI_ prefix) uygulandı.

**How I Used It:**
- [x] Directly used

**Explanation:**
> Kullanıcı deneyimini (UX) artırmak için nesneye duyarlı dinamik metin sistemi sisteme entegre edildi. Decoupled (bağımsız) bir yapı kurulması için event-based mimari tercih edildi.


## Prompt 7: Hold Interaction and Progress Bar Implementation

**Tool:** ChatGPT-4
**Date/Time:** 2026-02-08 16:35

**Prompt:**
> "Image buna ne sürüklücez bişi gerekli mi, HoldInteractable bunu ekledikten sonra ayarlamalarını adım adım detaylı bir şekilde anlat, PROMPTS.md: 'Prompt 7: Hold Interaction and Progress Bar' başlığıyla işle. Bu kısmı da detaylı bir şekilde anlat ardından sıradaki adımı detaylı bir şekilde açıkla."

**Response (Summary):**
> Hold interaction mekaniği için gereken UI hiyerarşisi (Background ve Fill imajları) açıklandı. Unity'nin Image component'indeki 'Filled' özelliği kullanılarak dinamik progress bar yapısı kuruldu. HoldInteractable sınıfının Unity Inspector üzerinden UnityEvent'ler ile nasıl modüler hale getirileceği (örneğin etkileşim bitince objeyi deaktif etme) adım adım rehberlendi.

**How I Used It:**
- [x] Adapted

**Explanation:**
> UI bileşenlerinin birbirine bağlanması ve script üzerindeki referansların doğru atanması sağlandı. Event-based (UnityEvent) yaklaşımı ile kod yazmadan etkileşim sonuçları oluşturulabilmesi sağlandı.


## Prompt 8: Toggle Interaction and Door System Implementation

**Tool:** ChatGPT-4
**Date/Time:** 2026-02-08 18:20

**Prompt:**
> "Image buna ne sürüklücez bişi gerekli mi, ardından sıradaki adım. (Toggle Interaction ve Kapı sistemi üzerine)"

**Response (Summary):**
> Unity Sprite Creator kullanılarak placeholder (geçici) UI görselleri oluşturma yöntemi açıklandı. Toggle interaction tipi için base class ve bu sınıftan türeyen dinamik bir Door (Kapı) script'i sağlandı. Kapının fiziksel menteşe yapısı ve Quaternion.Slerp ile yumuşak açılma mekaniği dökümante edildi.

**How I Used It:**
- [x] Directly used

**Explanation:**
> Case gereksinimlerinden olan Toggle tipi ve Kapı etkileşimi, Ludu Arts standartlarına (P_ prefix, smooth rotation) uygun şekilde sisteme dahil edildi.



## Prompt 9: Debugging Interaction System Issues

**Tool:** ChatGPT-4
**Date/Time:** 2026-02-08 19:15

**Prompt:**
> "Kapının yakınına geldim hiçbir şey olmadı."

**Response (Summary):**
> Etkileşim sistemindeki yaygın hatalar (Layer uyuşmazlığı, Collider eksikliği, RaycastOrigin referans hatası) için check-list sağlandı. Physics.Raycast ve LayerMask arasındaki ilişkinin doğrulanması için teknik rehberlik verildi. Script ve Collider'ın aynı hiyerarşi seviyesinde bulunmasının önemi vurgulandı.

**How I Used It:**
- [x] Directly used

**Explanation:**
> Sistemin çalışmama sebebi analiz edildi ve Layer ayarlarının yapılandırılmasıyla sorun çözüldü. Bu süreç, sistemin hata toleransı ve doğru konfigürasyon gereksinimlerini anlamamı sağladı.



## Prompt 10: Inventory and Key System with ScriptableObjects

**Tool:** ChatGPT-4
**Date/Time:** 2026-02-08 20:10

**Prompt:**
> "Simple Inventory ve Key sistemi üzerine sıradaki adımı detaylı açıklar mısın."

**Response (Summary):**
> ScriptableObject tabanlı Item sistemi, InventoryManager ve KeyPickup sınıfları implement edildi. Door sınıfı genişletilerek kilitli (Locked) durum yönetimi ve anahtar kontrol mekanizması eklendi. UI Prompt'un kilit durumuna göre dinamik değişimi sağlandı.

**How I Used It:**
- [x] Directly used

**Explanation:**
> Case'in "Must Have" gereksinimlerinden olan anahtar-kilit mekanizması ve envanter yönetimi SOLID prensiplerine uygun olarak tamamlandı.


## Prompt 11: Fixing NullReferenceException in Door Interaction

**Tool:** ChatGPT-4
**Date/Time:** 2026-02-08 21:00

**Prompt:**
> "Inspector'da Item ID kısımlarına 'BlueKey' ve 'RedKey' yaz. diğer bilgilerini ne yapacağız, NullReferenceException: Object reference not set to an instance of an object... [Hata Metni]"

**Response (Summary):**
> Hatanın kaynağı olan atanmamış referanslar (RequiredKey) ve eksik InventoryManager tespiti analiz edildi. Ludu Arts'ın 'Silent Bypass' yasağına uygun olarak Debug.LogError içeren güvenli kod blokları sağlandı. ScriptableObject alanlarının (ID, Name, Icon) nasıl doldurulacağı detaylandırıldı.

**How I Used It:**
- [x] Adapted

**Explanation:**
> Kodun çalışma anında çökmesini önlemek için null-check mekanizmaları eklendi. Geliştirme sürecindeki hataların loglanması standardı uygulandı.

## Prompt 12: Handling MissingReferenceException and Implementing Complex Interactables

**Tool:** ChatGPT-4
**Date/Time:** 2026-02-08 21:30

**Prompt:**
> "MissingReferenceException: The object of type 'InteractionSystem.Runtime.Interactables.Door' has been destroyed... bu hata var. (Ardından sandık ve şalter adımları)"

**Response (Summary):**
> Unity Editor'ün "Missing Object" referans hatası analiz edildi ve InteractionDetector sınıfına null-check koruması eklendi. Hold interaction kullanan sandık (Chest) ve event-based çalışan şalter (Switch) sistemlerinin kurulum mantığı açıklandı. Nesneler arası bağ kurma (Chained/Chained interactions) yöntemleri UnityEvent üzerinden örneklendi.

**How I Used It:**
- [x] Directly used

**Explanation:**
> Editor kaynaklı hatalar giderilerek sistem stabilitesi artırıldı. Sandık ve Şalter gibi karmaşık nesneler, dökümandaki modüler yapıya sadık kalınarak oluşturuldu.