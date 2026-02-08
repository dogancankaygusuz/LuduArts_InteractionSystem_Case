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

- **Test Senaryosu:**
  1. Önce kilitli kapıya (`P_Door`) gidin; kilitli olduğunu ve anahtar gerektiğini görün.
  2. Sandığa (`P_Chest`) gidin ve `E` tuşuna 2 saniye basılı tutarak açın. İçinden Kırmızı Anahtarı alın.
  3. Yerden Mavi Anahtarı (`P_Key_Blue`) alın.
  4. Şaltere (`P_Switch`) basarak uzaktaki dekoratif kapıyı tetikleyin.
  5. Doğru anahtarlarla kilitli kapıyı açın.

## 🏗️ Mimari Kararlar

### 1. Interface & Base Class Stratejisi
Sistem, **Dependency Inversion** prensibine uygun olarak `IInteractable` interface'i üzerine kurulmuştur. `InteractionDetector`, somut sınıflara (Door, Key vb.) değil, bu arayüze bağımlıdır. 
- `InteractableBase`: Kod tekrarını (DRY) önlemek için tüm ortak mantığı (Prompt, Highlight, State) burada topladım.
- **Liskov Substitution:** Her yeni etkileşim türü, mevcut sistemi bozmadan sisteme dahil edilebilir.

### 2. Event-Based UI & Chaining
Sistemde **Observer Pattern** kullanılmıştır. `InteractionDetector`, bir nesne bulduğunda veya kaybettiğinde C# Action'ları (`OnInteractableFound`, `OnInteractableLost`) tetikler. UI, bu eventleri dinleyerek detector'dan tamamen bağımsız (Decoupled) çalışır.
- `UnityEvent` kullanımı sayesinde "Switch -> Door" gibi zincirleme etkileşimler kod yazmadan, tasarımcı dostu bir şekilde kurulabilmektedir.

### 3. Data-Driven Inventory
Anahtar ve eşya tanımları için **ScriptableObject** kullanılmıştır. Bu sayede yeni anahtar tipleri oluşturmak için kod değişikliği gerekmez, sadece yeni bir Asset oluşturulması yeterlidir.

## 💎 Ludu Arts Standartlarına Uyum
Proje boyunca belirtilen tüm standartlara titizlikle uyulmuştur:
- **Naming Convention:** 
  - Prefablar için `P_`, Materyaller için `M_`, Textures için `T_`, ScriptableObject'ler için `SO_` prefixleri kullanılmıştır.
- **C# Coding Conventions:** 
  - Private field'lar `m_`, static field'lar `s_`, sabitler `k_` prefixi ile tanımlanmıştır.
  - Kod içerisinde standart `region` sıralaması (`Fields, Events, Properties, Methods...`) uygulanmıştır.
  - Tüm Public API'lar XML documentation ile belgelenmiştir.
- **Prefab Yapısı:** 
  - Tüm prefabların Transform değerleri (0,0,0) olarak sıfırlanmış, Pivot noktaları menteşe mantığına uygun (Bottom-center veya Menteşe kenarı) ayarlanmıştır.

## 🛠️ Bilinen Limitasyonlar & İyileştirmeler
- **Limitasyon:** Şu anki sistemde aynı anda birden fazla anahtar gerektiren kapılar için `InventoryManager`ın genişletilmesi gerekebilir.
- **Öneri:** Gelecekte etkileşim anında karakter animasyonları (Inverse Kinematics) eklenerek görsel kalite artırılabilir.

---
