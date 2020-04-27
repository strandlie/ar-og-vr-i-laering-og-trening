# Brann i blokka

Dette er VR applikasjonen til gruppe 5 i EiT landsbyen VR/AR i læring og trening 2020.

Denne applikasjonen skal lære brukeren å bruke et brannslukningsapparat i en brannsituasjon inne på VR-labben.

For å kunne kjøre prosjektet må du laste ned og installere `Oculus Integration` fra Unity Asset Store.

Scenen ligger i `Assets/Scenes/VRLabben.unity`

Brannslukkningsapparatet kan løftes med
`HandTrigger` knappen, og avfyres med `IndexTrigger` knappen,
som illustrert [her](https://developer.oculus.com/documentation/unity/unity-ovrinput/#virtual-mapping-accessed-as-individual-controllers)
Før apparatet kan brukes må sikkerhetssplinten (den oransje sylynderen) trekkes ut.

# Utdrag fra prosjektrapporten:

## Applikasjonens innhold

Applikasjonen består av en scene som inneholder:

* Et virtuelt miljø som ligner VR-labben
* Et brannslukningsapparat som kan interageres med
* Noen flammer som bør slukkes


## Funksjonalitet

* Kroppen og nesen til brannslukningsapparatet kan plukkes opp av VR aktøren hver for seg med hver sin hånd
* Kroppen har en sikkerhetsplint (en oransje sylynder) som begrenser slukkefunksjonaliteten til brannslukningsapparatet.
* Brannslukningsapparatet kan produsere pulverpartikler som sprøytes ut av nesen. Denne funksjonaliteten kan aktiveres av at brukeren Når splinten er trukket, og brukeren holder kroppen til apparatet og trykker på pekefingerknappen.
* Hver brann holder styr på sin egen styrke, og vil vokse med tid op til en øvre grense satt av utvikleren. Den visuelle størrelsen på brannen er bestem av denne styrkeverdien.
* Hver brann har en liten kjerne, som pulverpartikler kan iteragere med.
* Pulverpartikler som treffer kjernen til en brann vil trekke ned styrken til brannen med en hvis mengde, for så å selv forsvinne.
* Når styrken til en brann når 0 vil brannen forsvinne.
* Dører kan åpnes og lukkes med F tasten på tastaturet

