
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

## Darāmie darbi:
- [x] UI button lietojums
- [x] UI input field lietojums
- [x] UI Text lietojums
- [x] UI Image lietojums
- [x] UI radio button lietojums
- [x] Drag and drop funkcionalitāte
- [x] audio source lietojums
- [x] Riggid body un collider lietojums
- [x] Projekta sagatavosana windows OS
- [x] Izveidot galvenās izvelnes ainu
- [x] Izveidot TV ainu
- [x] Integrēt virtuļu ķeršanas spēli

**Darāmie darbi prieks formatīvā vērtējuma**
  * Izstrādāt C# skriptu, kas nodrošina noķerto virtuļu uzskaiti. Tādējādi īstenojot punktu sistēmu, kas tiek attēlota ekrānā. Piedomāt pie dažādas "vērtības" objektu ķeršanas.
  * Izstrādāt C# skriptu, kas nodrošina taimera sistēmu. Taimeris tiek startēts uzsākot virtuļu ķeršanas spēli, taču tas tiek apturēts zaudējot spēli.
  * Izstrādāt C# skriptu, kas nodrošina spēles zaudēšanas loģiku, piemēram sadursme ar "bīstamu" objektu, ieviest "dzīvību" sistēmu.
  * Projektā ieviest skaņas efektus un animācijas.
  * Projekta izstrādes process tiek jēgpilni versionēts ar Git versiju kontroles sistēmu, GitHub izvietots
    projektu aprakstošs README fails, kurš satur projekta aprakstu un ekrānšāviņus.
  * Projekts ir izstrādāts noteiktajā termiņā, tā izstrāde ir veikta rūpīgi un tas ir darbināms bez funkcionālām nepilnībām.

## Ieskats virtuļu spēlē
<p align="center">
 <img width="447" height="314" alt="image" src="https://github.com/user-attachments/assets/236dc60c-ba1e-47ce-817b-7b2a88ea8b60" />
</p>
