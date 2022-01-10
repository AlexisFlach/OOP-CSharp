# Objektorienterad analys, design och programmering.

## Teori


## Livscykel
---

System Development Life Cycle (SDLC)

SDLC är en metodik/process för att underlätta utveckling som är planstyrd och förändringsdriven.
Systemet hjälper projektledaren med den så kallade projekttriangeln

- Tid
- Krav
- Budget

<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/8/88/Project-triangle-en.svg/440px-Project-triangle-en.svg.png" alt="projecttriangle" width="200"/>


### Faser i en livscykel

1. Konceptuell planering

I den första fasen går man igenom omfattningen av hela projektet. En diskusion påbörjas mellan seniora utvecklare, projektledare, kund, och representant för slutanvändare.
Man kan dela upp det i olika punkter:

- Begränsningar
    - Resurser
    - Budget
    - Tid

- Utvärdering
    - Hur ska projektet utvärderas?

- Riskanalys
    - Vilka risker finns?

- Befintlig teknik
    - Vad finns idag?
    - Investeringsbehov?

2. Kravställning(analys)

I den andra fasen, kravställning, bryts den konceptuella planeringen ned i mindre delar.

Krav identifieras och utvärderas. Dessa sammanställs och presenteras i möte med representant för slutanvändare som får verifiera och godkänna kraven. Vi ska helt enkelt tolka beställarens krav, och hitta sätt att verifiera att vi är på samma våglängd.

Vi fastställer krav i ett Software Requirements Specification(SRS) som beskriver vad systemet ska göra och det förväntas fungera.

SRS kan brytas ned i 4 D:
    - Define your products purpose
    - Describe what you are building
    - Detail the requirements
    - Deliver it for approval

DEFINE, DESCRIBE, DETAIL, DELIVER.

3. Design

I denna fas används SRS som referens. Målet med detta steg är att få med sig en Design Document Specification(DDS).

DDS är ett detaljerat dokument som listar samtliga punkter i kontext av en produkt eller en process. Den beskriver hur punkterna i SRS kommer att bli implementerade.
Som exempel kan här specificeras hur användare ska interagera med systemet.

En samling med krav används alltså för att beskriva en önskvärd lösning. För att vi ska kunna nå detta stadie är det viktigt att kravställningen är tydlig.

Designkrav brukar innehålla en överblick av projektet, huvudmål, och vilken som målgruppen.

Vidare så innehåller den även funktionella krav, vilket vi kommer att gå in på i mer detalj senare, estetiska aspekter, icke-funktionella krav, samt rekommendationer och begränsningar.

Designkrav är mer skrivna för utvecklarna, än övriga stackholders så som beställare.

4. Utveckling och Testing

För i tiden brukade detta vara uppdelat i 2 faser där man skrev tester efter att utveckling-fasen var färdig.

Idag, med moderna system, är det brukligt att interage testning med utveckling genom Test-driven Development(TDD)

Vi börjar med att skriva våra tester och skriver kod så att det testerna godkännas.

5. Driftsättning

Även kallar lansering/release. Detta kan göras i flera steg, bland annat med beta-test där utvalda användare ger feedback.

6. Drift och underhåll

Detta steg sker efter driftsättning där vi utvärder befintliga funktioner, analyserar nya funktioner, fixar buggar...

Har det skett några missförstång i planeringen? Är kund och utvecklare överens om att produkten är vad den var tänkt att vara?

7. Utvärdering

Vi går här igenom och utvärderar pågående arbete. 

- Vad går bra / mindre bra? 
    - Vad kan göras?
        - Utbildning
        - Förbättringar
        - Processer

8. Avfallshantering

Här hittar och identifierar vi material som är överflödiga, eller som måste uppdateras.


## Krav
---

Med krav menas dokumenterat behov. Design, produkt eller process ska uppfylla kravet.
Krav används ofta inom produktutveckling och optimeraring av processer.

*Funktionalitet som en produkt eller tjänst måste ha för att produkten eller tjänsten ska vara användbar för intressenten*

- Önskvärd egenskap eller funktion hos ett IT-system
- Beskrivningar av systemets tjänster och begränsningar
- Vad slutprodukten ska utföra, samt hur den ska se ut

Om vi tar ett kundhanteringssystem som exempel så kan vi (bland många andra) hitta följande krav:

- Man ska kunna lägga till nya kunder
- Användare ska kunna uppdatera betalningsmetod

###### Punktlista Krav

- Krav ska vara tydliga och begripliga
- Krav ska vara testbara
- Krav kan ändras
- Krav ska vara kompletta och korrekta
- Krav ska vara genomförbara
- Krav ska ha ett värde för användaren
- Krav är en referenspunkt för testning
- Krav != Kod
- Beställare != Användare
- Prioritet
    - Ska = Hög prioritet
    - Borde = LÄgra prioritet


##### FURPS

- Functional
- Usability
- Reliability
- Performance
- Supportability


**Funktionella(Functional)**

Krav på hur systemet ska fungera.

Här specificerar vi allt ifrån vad en viss parameter ska ge för resultat, till vad systemet INTE ska göra.

*Man ska kunna lägga till/redigera/ta bort ort*
*Man ska kunna lägga till/redigare/ta bort användare*

**Icke-Funktionella**

Beskriver hur systemet ska fungera.

Komplement till funktionella krav.

Beskriver systemets prestanda och hur systemet ska bete sig.

- Användarvänlighet
    - Hur snabbt kan en användare lära sig systemet?
- Kapacitet
    - Hur många användare kan systemet klara av att hantera på en och samma gång?
- Säkerhet
    - Mått på hur väl systemet klarar av yttre intrångsförsök
- Underhållbarhet
    - Mått på hur enkelt det är att underhålla systemet
- Tillgänglighet
    - Ett krav som beskriver systemet tillgänglighet, exempelvis uppe och tillgänglig 99.99% av tiden


**Användarbarhet(Usability)**

Beskriver hur användarvänligt system är i förhållande till att lära sig det, använda det, och att få hjälp vid behov.

Exempel:

- Inlärningstid ska inte vara längre än 2 timmar
- Det ska vara tydligt för användaren hur en handling ska utföra
- Tydliga beskrivningar i exempelvis inmatningsfält.


**Pålitlighet(Reliability)**

Att kunna lita på systemet under användning.

Vi kan här lista felfrekvens där hur ofta fel får förekomma specificeras.

*Fel av allvarlighetsgrad medel får inträffa max 3 gånger per år*

*Vid fel ska systemet kunna återställa data till ursprungligt skick*


**Prestanda(Performance)**

Tid för systemet att svara på en förfrågan.

*När 300 användare samtidigt söker och registrerar ärenden får svarstiderna inte överstiga 5 sekunder*


**Support(Supportability)**

Krav som rör underhåll och förvaltning i syfte att underlätta testning och felsökning.

*Det ska finnas drift-och systemdokumentation*
*Kommentarer ska finnas i koden*































































Länkar:

SRS

https://krazytech.com/projects/sample-software-requirements-specificationsrs-report-airline-database

https://searchsoftwarequality.techtarget.com/definition/software-requirements-specification

DDS

http://cci.drexel.edu/seniordesign/2016_2017/HighWater/HighWaterDesignDocument.pdf

https://northell.design/blog/how-to-write-the-design-specifications-quick-guide/
































