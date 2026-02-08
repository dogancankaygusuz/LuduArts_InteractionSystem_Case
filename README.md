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
