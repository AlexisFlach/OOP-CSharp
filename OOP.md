# Objektorienterad programmering

För att bygga en applikation som följer objektorienterade tekniker tar vi följande steg:

1. Identifiera klasser från krav eller specifikationer

OOP representerar *entities*  och koncept inom en applikation som en samling klasser.

2. Separera ansvar

Analysera de idenifierade klasserna och separera ansvarsområden.

OOP fokuserar på att separera applikationens ansvarsområden till olika klasser. Idén bakom detta är att applikationen ska brytas ned i delar med minimalt med överlappning.
Om varje klass har ett, och endast ett, syfte, så blir det enklare att skriva och testa, samt modifiera och förlänga(extend). Detta kallas ofta för Seperation of Concerns.

3. Etablera relationer

Vi behöver hitta relationer mellan våra klasser. Relationerna definerar hur objekt skapade från dessa klasser arbetar tillsammans för att utföra applikationens operations.

4. Utnyttja återanvändning

Ett av de stora målen med OOP är återanvändning.

Genom att extrahera *commonality* mellan olika klasser till en separat klass så blir vår kod mer återanvändningsbar.

## Identifiera klasser från krav eller specifikationer

1.Börja med att analysera kraven och identifiera klasser.

Dessa klasser...
- representerar *business entities*, alltså vad som finns att hitta från, exempelvis, kundens perspektiv.
- definierar properties(data)
- definierar metoder(actions/behavior)

Så börja med att kolla efter substantiv; personer, platser, saker...

**Krav**

"Applikationen ska hantera kunder. Applikationen ska hantera våra produkter. Applikationen ska kunna ta emot ordrar från kunder online".

Vilka klasser får ni fram?

"Applikationen ska hantera kunder"

Customer

"Applikationen ska hantera våra produkter"

Product

"Applikationen ska kunna ta emot ordrar från kunder online"

Order

2. Definiera *members*, alltså properties och metods

Vilka properties är rimliga att ha med?

Customer
---
Customer's name (Last name, first name)
Email Address
Home and Work addressess

Product
---
Product name
Description
Current price

Order
---
Customer
Order date
Shipping address

Order item
---
Product
Quantity

3. Ha i åtanke förändring över tid

Kundens data kan komma att förändras, till exempel så kan kundens address ändras. Bryr vi oss om det?

Produktens pris kan komma att förändras, bryr vi oss om det eller ska Order item ga en property för pris vid köptillfälle?

Poängen är att vi bör lägga tid på att se hur tid och förändring kan komma till att påverka vår applikation.

4. Abstraction

Vilken information vi behöver ta från våra business entities in i applikationen.

Relevanta abstraktionen beror helt och hållet på vår applikations krav.

Abstraktion är processen i att definiera klasser som simplifierar verkligheten, ignorerar onödiga detaljer och fokuserar på vad som är viktigt för vårt syfte.

5. Encapsulation

Där abstraction är ett koncept, är encapsulation en teknik. Det är ett sätt för oss att gömma data eller implementations detaljer inom en klass.

Fördelarna med detta är att ingen annan kod i vår applikation behöver veta om dessa detaljer, och är vad vi i  C# har våra getters och setters till.

Encapsulation skyddar även vår data. Vi kan lägga till kod som autorisera innan vi ger ut data.

Implementationen kan förändras utan att det påverkar applikationen.

```
dotnet new sln --name BusinessApp
```

```
dotnet new console --name BusinessApp.BL
```

Customer

```
        public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string EmailAddress { get; set; }
    }
```

###### Testa vår kod

```
dotnet new xunit --name BusinessApp.BLTest
```

```
dotnet add BusinessApp.BLTest/BusinessApp.BLTest.csproj reference BusinessApp.BL/BusinessApp.BL.csproj
```

```
dotnet sln add BusinessApp.Bl/BusinessApp.BL.csproj
dotnet sln add BusinessApp.BlTest/BusinessApp.BLTest.csproj
```

```
dotnet test
```

CustomerTest.cs
```
using Xunit;
using BusinessApp.BL;

namespace BusinessApp.BLTest;


public class CustomerTest
{
    [Fact]
    public void FullNameTestValid()
    {
        // Arrange
        Customer customer = new Customer
        {
            FirstName = "Gabriel",
            LastName = "Batistuta"

        };

        string expected = "Gabriel Batistuta";

        // Actuall
        string actual = customer.FullName;

        // Assert
        Assert.Equal(expected, actual);
    }
}
```

###### Testa ogiltiga värden

```
    [Fact]
    public void TestNoLastname()
    {
        // Arrange
        Customer customer = new Customer
        {
            FirstName = "Gabriel",

        };

        string expected = "Gabriel";

        // Actuall
        string actual = customer.FullName;

        // Assert
        Assert.Equal(expected, actual);
    }
```

Skriv kod så att testen godkänns.

```
 public string FullName
        {
            get
            {   
                string fullName = FirstName;

                if(!string.IsNullOrWhiteSpace(LastName)){
                    if(!string.IsNullOrWhiteSpace(fullName)) {
                        fullName += " ";
                    }
                    fullName += LastName;
                }
                return fullName;
            }
        }
```

## 2. Separation of responsibilities

Andra steget för att bygga objektorienterade applikationer är att titta på varje klass och se om de tar till sig för mycket ansvar.

Vi vill med detta:

- minimera coupling
- maximera cohesion
- simplifiera underhåll
- förbättra testbarheten

**Coupling** är grad av beroende mellan klasserna eller externa resurser.
Med *low coupling* så reducerar vi risken för att förändring i en klass påverkar en annan. 

**Cohesion** är ett mått på hur pass relaterat till syftet alla members i vår klass är.

Låt oss leka med tanken att varje klass vi har skapat har metoder för att hämta, validera och spara, en instans av klassen.

Vi har gått igenom detta mönster tidigare: Repository pattern.

Om en klass är ansvarig för att att hämta och spara data kallas det för en Repository klass.

## 3. Etablera relationer

Tredje steget är att etablera relationer klasserna emellan. De behöver dessa relationer så att de kan interage med varandra.

Inom OOP finns det 3 typer av relationer:

-   Collaboration ("Uses a"), som definierar en relation där ett objekt använder ett annat objekt, som i vanliga fall inte är relaterat till det objektet.

Om vi skapar ett Repository för Customer så använder Customer Repository en Customer för att utföra det den ska utföra.

-   Composition("Has a"), som definierar en relation där ett objekt är sammansatt a andra objekt. En bil har en dator. En Order har en Customer och en samling Order Items.

Composition har två sub-kategorier:

    - Agreggation, när ett objekt är sammansatt av objekt som kan existera utanför dess relation. En order har en Customer, men en Customer kan existera utanför relationen.

    - Composition, när ett objekt är sammansatt av objekt som inte kan existera utanför dess relation. En order har en samling Order Items, men dessa kan inte existera utanför relationen.

-   Inheritance("is a"), vi skulle exempelvis kunna ha olika typer av Customers, med grund Customer.

## 4. Utnyttja återanvändning

Hemligheten bakom återanvänding ligger i följande steg:

1. Bygg den
2. Testa den med unit tests.
3. Återanvänd den
4. Uppdatera den på en plats
