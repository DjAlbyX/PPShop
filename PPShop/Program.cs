﻿//Shoppingspree
//Lag en base klasse som heter “InventoryItem” hvor du har info om itemets navn, antall og pris.
//Lag to klasser til, ClothingItem og ElectronicItem. Disse skal ha informasjon om størrelse og farge f.eks på klær og f.eks forsikringsinformasjon og spenning på det elektriske.
//La disse klassene arve av baseklassen, slik at de også får bruke navn, antall og pris.
//Lag et interface ISellable som har en funksjon som kalkulerer pris, kanskje nettbutikken har black friday salg og det er 30% rabatt på alle varer? Eller man må legge på skatt for varene?.
//Implementer dette interfacet i ClothingItem og ElectronicItem
//Lag noen forskjellige items for å sjekke at det fungerer som tenkt.
using PPShop;


var runCode = new App();
runCode.Run();