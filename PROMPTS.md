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
**Date/Time:** 2026-02-08 17:45

**Prompt:**
> "Image buna ne sürüklücez bişi gerekli mi, HoldInteractable bunu ekledikten sonra ayarlamalarını adım adım detaylı bir şekilde anlat, PROMPTS.md: 'Prompt 7: Hold Interaction and Progress Bar' başlığıyla işle. Bu kısmı da detaylı bir şekilde anlat ardından sıradaki adımı detaylı bir şekilde açıkla."

**Response (Summary):**
> Hold interaction mekaniği için gereken UI hiyerarşisi (Background ve Fill imajları) açıklandı. Unity'nin Image component'indeki 'Filled' özelliği kullanılarak dinamik progress bar yapısı kuruldu. HoldInteractable sınıfının Unity Inspector üzerinden UnityEvent'ler ile nasıl modüler hale getirileceği (örneğin etkileşim bitince objeyi deaktif etme) adım adım rehberlendi.

**How I Used It:**
- [x] Adapted

**Explanation:**
> UI bileşenlerinin birbirine bağlanması ve script üzerindeki referansların doğru atanması sağlandı. Event-based (UnityEvent) yaklaşımı ile kod yazmadan etkileşim sonuçları oluşturulabilmesi sağlandı.