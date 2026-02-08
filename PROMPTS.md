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

**Tool:** ChatGPT-4
**Date/Time:** 2026-02-08 16:10

**Prompt:**
> "Tamamdır sıradaki adımı detaylı bir şekilde adım adım açıkla (Interactable Base Class ve Test nesnesi oluşturma üzerine)."

**Response (Summary):**
> Kod tekrarını önlemek için abstract `InteractableBase` sınıfı oluşturuldu. SOLID prensiplerine uygun olarak `IInteractable` interface'i bu base sınıf üzerinden implement edildi. Test amaçlı `TestInteractable` sınıfı yazılarak Raycast Detector ile ilk uçtan uca etkileşim testi (renk değiştirme) gerçekleştirildi.

**How I Used It:**
- [x] Directly used

**Explanation:**
> Modülerliği artırmak için kalıtım (inheritance) yapısı kuruldu. Loglama işlemleri Ludu Arts standartlarına (Silent bypass önleme) uygun yapıldı.


## Prompt 5: Player Movement and Controller Implementation

**Tool:** ChatGPT-4
**Date/Time:** 2026-02-08 16:30

**Prompt:**
> "Oyuncu hareket etmedi şu an hareket ettirmek için yapmam gerekenleri detaylı bir şekilde adım adım açıklar mısın, sonrasında sıradaki adıma geçelim."

**Response (Summary):**
> CharacterController tabanlı, FPS standartlarında bir PlayerController script'i sağlandı. WASD hareket mekaniği, mouse look (bakış) sistemi ve basit yerçekimi (gravity) mantığı açıklandı. Kod, Ludu Arts coding conventions (m_ prefix, region) kurallarına göre yapılandırıldı.

**How I Used It:**
- [x] Directly used

**Explanation:**
> Etkileşim sistemini test edebilmek için gerekli olan temel hareket mekanikleri projeye eklendi. Mouse kilitleme (Cursor lock) ve kamera rotation clamp (sınırlama) gibi detaylar profesyonel standartlarda uygulandı.