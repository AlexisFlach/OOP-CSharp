## Objektorienterad analys, design och programmering.

## Teori
---

### Livscykel

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









Länkar:

SRS

https://krazytech.com/projects/sample-software-requirements-specificationsrs-report-airline-database

https://searchsoftwarequality.techtarget.com/definition/software-requirements-specification

DDS

http://cci.drexel.edu/seniordesign/2016_2017/HighWater/HighWaterDesignDocument.pdf

https://northell.design/blog/how-to-write-the-design-specifications-quick-guide/
































