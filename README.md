# Interaction System - Mehmet Doğancan Kaygusuz

Ludu Arts Unity Developer Intern Case kapsamında geliştirilmiş, modüler, genişletilebilir ve SOLID prensiplerini temel alan bir etkileşim sistemidir.

## Proje Bilgileri
- **Unity Versiyonu:** 6000.3.6f1
- **Render Pipeline:** URP
- **Case Süresi:** 12 saat
- **Tamamlanma Oranı:** %100
  
  ## Kurulum
- **Nasıl Açılır:** 
1. Repository'yi klonlayın:
```bash
git clone https://github.com/dogancankaygusuz/LuduArts_InteractionSystem_Case.git
```
2. Unity Hub'da projeyi açın
3. `Assets/InteractionSystem/Scenes/TestScene.unity` sahnesini açın
4. Play tuşuna basın

## Nasıl Test Edilir?
### Kontroller
  | Tuş | Aksiyon |
|-----|---------|
| WASD | Hareket |
| Mouse | Bakış yönü |
| E | Etkileşim |

### Test Senaryoları
  1. **Door Test:**
   - Kapıya yaklaşın, "Press E to Open" mesajını görün
   - E'ye basın, kapı açılsın
   - Tekrar basın, kapı kapansın

2. **Key + Locked Door Test:**
   - Kilitli kapıya yaklaşın, "Locked - Key Required" mesajını görün
   - Anahtarı bulun ve toplayın
   - Kilitli kapıya geri dönün, şimdi açılabilir olmalı

3. **Switch Test:**
   - Switch'e yaklaşın ve aktive edin
   - Bağlı nesnenin (kapı/ışık vb.) tetiklendiğini görün

4. **Chest Test:**
   - Sandığa yaklaşın
   - E'ye basılı tutun, progress bar dolsun
   - Sandık açılsın ve içindeki item alınsın
     
## Mimari Kararlar

### Interaction System Yapısı
```
Sistem, Interface-Based ve Data-Driven bir yapı üzerine kurulmuştur. Oyuncu (Player), somut nesneleri tanımaz; sadece IInteractable arayüzü üzerinden mesaj gönderir.
```

**Neden bu yapıyı seçtim:**
> Oyuncu kontrolcüsü ile nesne mantığı birbirinden tamamen ayrılmıştır. Yeni bir etkileşimli nesne eklemek için oyuncu kodunda değişiklik yapmak gerekmez (Open/Closed Principle). InteractableBase sınıfı sayesinde tüm nesneler vurgulama (highlight) ve prompt yönetimi gibi özellikleri otomatik olarak kazanır.

**Alternatifler:**
> Trigger-Based Interaction: Daha performanslı olabilir ancak FPS oyunlarında hassasiyet (point-and-click hissi) düşük olduğu için Raycast tercih edilmiştir.

**Trade-off'lar:**
> Raycast kullanımı her karede fizik hesaplaması gerektirir. Bunu optimize etmek için m_CheckInterval kullanılarak tarama sıklığı saniyede 10'a düşürülmüştür.

### Kullanılan Design Patterns

| Pattern | Kullanım Yeri | Neden |
|---------|---------------|-------|
| Strategy | Interaction Types | Farklı etkileşim davranışlarını aynı interface altında yönetmek için. |
| Template Method | InteractableBase | Alt sınıfların ortak iskeleti kullanıp kendi davranışlarını (OnInteract) tanımlaması için. |
| Observer | UI ve Event Sistemi | Detector ve UI arasındaki bağı koparmak, event-based bir yapı kurmak için |

## Ludu Arts Standartlarına Uyum
### C# Coding Conventions
| Kural | Uygulandı | Notlar |
|-------|-----------|--------|
| m_ prefix (private fields) | [x] / [ ] | Tüm private değişkenlerde uygulandı. |
| s_ prefix (private static) | [x] / [ ] | Statik değişkenlerde kullanıldı. |
| k_ prefix (private const) | [x] / [ ] | Sabitlerde uygulandı. |
| Region kullanımı | [x] / [ ] | Standart region yapısı kuruldu. |
| Region sırası doğru | [x] / [ ] | Fields > Events > Properties > Methods |
| XML documentation | [x] / [ ] | Tüm Public API'lar belgelendi. |
| Silent bypass yok | [x] / [ ] | Hatalar Debug.LogError ile yakalandı. |
| Explicit interface impl. | [x] / [ ] | |

### Naming Convention

| Kural | Uygulandı | Örnekler |
|-------|-----------|----------|
| P_ prefix (Prefab) | [x] / [ ] | P_Door, P_Player, P_Chest |
| M_ prefix (Material) | [] / [x] | |
| T_ prefix (Texture) | [] / [x] | |
| SO isimlendirme | [x] / [ ] | SO_Key_Blue, SO_Item_Data |

### Prefab Kuralları

| Kural | Uygulandı | Notlar |
|-------|-----------|--------|
| Transform (0,0,0) | [x] / [ ] | |
| Pivot bottom-center | [x] / [ ] | |
| Collider tercihi | [x] / [ ] | |
| Hierarchy yapısı | [x] / [ ] | |

### Zorlandığım Noktalar
> Projenin başında yerleşik alışkanlıklar nedeniyle m_, s_ ve k_ prefixlerini her field için tutarlı bir şekilde uygulamak ekstra bir dikkat gerektirdi. Spesifik region sıralaması (Fields > Events > Properties... sırası), standart C# düzeninden biraz farklı olduğu için her yeni sınıf oluşturduğunda bu hiyerarşiyi manuel olarak düzenlemek zaman aldı.

## Tamamlanan Özellikler

### Zorunlu (Must Have)

- [x] / [ ] Core Interaction System
  - [x] / [ ] IInteractable interface
  - [x] / [ ] InteractionDetector
  - [x] / [ ] Range kontrolü

- [x] / [ ] Interaction Types
  - [x] / [ ] Instant
  - [x] / [ ] Hold
  - [x] / [ ] Toggle

- [x] / [ ] Interactable Objects
  - [x] / [ ] Door (locked/unlocked)
  - [x] / [ ] Key Pickup
  - [x] / [ ] Switch/Lever
  - [x] / [ ] Chest/Container

- [x] / [ ] UI Feedback
  - [x] / [ ] Interaction prompt
  - [x] / [ ] Dynamic text
  - [x] / [ ] Hold progress bar
  - [x] / [ ] Cannot interact feedback

- [x] / [ ] Simple Inventory
  - [x] / [ ] Key toplama
  - [x] / [ ] UI listesi

### Bonus (Nice to Have)

- [ ] Animation entegrasyonu
- [ ] Sound effects
- [ ] Multiple keys / color-coded
- [x] Interaction highlight
- [ ] Save/Load states
- [x] Chained interactions

## Bilinen Limitasyonlar

### İyileştirme Önerileri

1. Highlighting - Şu anki renk değişimi yerine daha kaliteli bir "Outline Shader" kullanılabilir.
2. Persistence - Save/Load sistemi eklenerek etkileşim durumları (açık kapılar vb.) kaydedilebilir.

## Dosya Yapısı

```
Assets/
├── InteractionSystem/
│   ├── Scripts/
│   │   ├── Runtime/
│   │   │   ├── Core/
│   │   │   │   ├── IInteractable.cs
│   │   │   │   └── InteractableBase.cs
│   │   │   │   └── InteractionType.cs
│   │   │   │   └── ItemData.cs
│   │   │   ├── Interactables/
│   │   │   │   ├── Chest.cs
│   │   │   │   └── Door.cs
│   │   │   │   └── HoldInteractable.cs
│   │   │   │   └── KeyPickup.cs
│   │   │   │   └── Switch.cs
│   │   │   │   └── TestInteractable.cs
│   │   │   │   └── ToggleInteractable.cs
│   │   │   ├── Player/
│   │   │   │   ├── InteractionDetector.cs
│   │   │   │   └── InventoryManager.cs
│   │   │   │   └── PlayerController.cs
│   │   │   └── UI/
│   │   │       └── InteractionPromptUI.cs
│   ├── ScriptableObjects/
│   │   ├── Items/
│   │   │   ├── SO_Key_Blue.asset
│   │   │   └── SO_Key_Red.asset
│   ├── Prefabs/
│   │   ├── Interactables/
│   │   │   ├── P_Chest.prefab
│   │   │   └── P_Door.prefab
│   │   │   └── P_Switch.prefab
│   │   ├── Player/
│   │   │   └── P_Player.prefab
│   └── Scenes/
│       └── TestScene.unity
├── Docs/
│   ├── CSharp_Coding_Conventions.md
│   ├── Naming_Convention_Kilavuzu.md
│   └── Prefab_Asset_Kurallari.md
├── README.md
├── PROMPTS.md
└── .gitignore
```
## İletişim

| Bilgi | Değer |
|-------|-------|
| Ad Soyad | Mehmet Doğancan Kaygusuz |
| E-posta | mehmetdogancankaygusuz@gmail.com |
| LinkedIn | https://www.linkedin.com/in/dogancan-kaygusuz |
| GitHub | https://github.com/dogancankaygusuz |

*Bu proje Ludu Arts Unity Developer Intern Case için hazırlanmıştır.*

---
