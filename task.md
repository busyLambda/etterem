# 🍽 Éttermi Rendelési Rendszer (OOP + Fájlkezelés)

## Feladat:

## Egy éttermi rendelési rendszert kell készíteni C#-ban, ahol a vendégek ételeket és italokat

## rendelhetnek. A rendelések fájlban kerülnek mentésre és betöltésre.

## 🛠 Rendszer felépítése

## A rendszer az alábbi 5 fő osztályból áll:

- **Menüelem (MenuElem** ): Egy ételt vagy italt reprezentál (név, ár, kategória).
- **Vendég (Vendeg** ): A vendég rendelhet ételeket, és fizethet.
- **Rendelés (Rendeles** ): Egy rendelés adatai (vendég neve, rendelési lista).
- **Étterem (Etterem** ): Az étterem kezeli a menüt és a rendeléseket.
- **Fájlkezelő (FajlKezelo** ): Az adatok mentése és betöltése fájlból.

## Adatok tárolása fájlban

- Az ételek listája egy menu.txt fájlban tárolódik.
- A rendelések egy rendelesek.txt fájlban kerülnek elmentésre.

# Osztályok és metódusok részletezése

## 1️⃣ Menüelem osztály

**Feladata:**
Tárolja az étel/ital **nevét** , **árát** és **kategóriáját**.
2️⃣ Vendég osztály
**Feladata:**
A vendégek **rendelhetnek** ételeket és italokat.
A fizetéskor a vendég **rendelése törlődik** , és a fizetendő összeg kiszámításra kerül.
3️⃣ Rendelés osztály


## Feladata:

## Tárolja a rendelés adatait (vendég neve, rendelt ételek/italok).

## Kiszámítja a végösszeget.

4️⃣ Étterem osztály
**Feladata:**
Kezeli az éttermi menüt és rendeléseket.
5️⃣ Fájlkezelő osztály
**Feladata:
Menü és rendelések mentése, betöltése fájlból**.



