
# Unity Bean

**Unity Bean** ir dinamiska 2D stila spēle, kas izstrādāta Unity vidē ***(un ir kā pirā spēle unity vidē)***. Spēles pamatā ir virtuļu ķeršanas mehānika, TV aina un dažādas podziņas ko var paspaidāt.
## Ieskats projektā
<p align="center">
  <img width="882" alt="Screenshot" src="https://github.com/user-attachments/assets/2ae6079c-7913-4f09-9e11-47a21bbd6ad2" />
</p>

## Virtuļu ķeršanas spēles apraksts
Spēlētājs vada tēlu, kura uzdevums ir noķert pēc iespējas vairāk krītošo virtuļu. 
* **Punktu sistēma:** Katrs noķertais virtulis palielina punktu skaitu un tēla fizisko izmēru.
* **Dzīvību sistēma:** Spēlētājam ir 3 dzīvības. Sadursme ar "sliktajiem" objektiem atņem dzīvību un samazina punktus.
* **Spēles beigas:** Kad dzīvības beidzas, spēle apstājas, tiek parādīta "Game Over" animācija un taimeris tiek apturēts.


## Tehniskās funkcijas
* **Dinamiska objektu ģenerēšana:** `DonutBakerScript` nejauši izvēlas un izmet objektus virs spēlētāja.
* **Reāllaika taimeris:** Uzskaita spēles ilgumu un tiek vadīts caur UI sistēmu.
* **Fizikas simulācija:** Izmantoti `Rigidbody2D` un `Collider2D` komponenti objektu interakcijai.
* **Audio integrācija:** Katram notikumam (ķeršanai, zaudēšanai, beigām) ir savs unikāls skaņas efekts.


## Izpildītie darbi (Checklist)
- [x] UI elementu lietojums (Button, TextMeshPro, Image, Toggle)
- [x] Drag and drop funkcionālais nodrošinājums
- [x] AudioSource un SFX vadība caur kodu
- [x] Fizikas dzinēja (Rigidbody, Colliders) konfigurācija
- [x] Projekta eksports Windows videi
- [x] Galvenās izvēlnes un TV ainas izveide
- [x] C# skripts punktu uzskaitei un "vērtību" objektiem
- [x] Taimera sistēma (starts/stop)
- [x] Dzīvību loģika un "Game Over" scenārijs
- [x] Animāciju izmantošana pie spēles beigām


## Ieskats virtuļu spēlē
<p align="center">
 <img width="447" height="314" alt="image" src="https://github.com/user-attachments/assets/236dc60c-ba1e-47ce-817b-7b2a88ea8b60" />
</p>
