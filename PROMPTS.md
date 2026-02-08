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