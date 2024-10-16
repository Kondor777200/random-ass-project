# Specifikace požadavků na systém (SRS)

## 1. Úvod

### 1.1 Účel
Cílem této specifikace je popsat požadavky na kozolovou aplikaci napsanou v jazyce C#, která běží na operačních systémech Linux. Aplikace bude zpracovávat barevné hodnoty z vstupu a vracet je ve formátech RGB, RGBA a HEX.

### 1.2 Rozsah
Aplikace přijme barevný řetězec z `stdin`, provede jeho analýzu a vrátí tabulku s různými formáty barev. Bude také schopná zpracovat chybné vstupy a informovat uživatele.

### 1.3 Definice
- **Kozolová aplikace**: Aplikace, která běží v konzolovém režimu.
- **RGB**: Model barev reprezentující červenou, zelenou a modrou.
- **RGBA**: Rozšíření RGB o alfa kanál (průhlednost).
- **HEX**: Šestnáctkový formát pro reprezentaci barev.

## 2. Celkový popis

### 2.1 Perspektiva produktu
Aplikace bude sloužit jako nástroj pro rychlou konverzi barevných hodnot, což usnadní práci designérům a vývojářům.

### 2.2 Funkce produktu
- Přijetí barevného řetězce z `stdin`.
- Převod barev na formáty RGB, RGBA a HEX.
- Výpis tabulky s výsledky do konzole.

### 2.3 Uživatelská charakteristika
Aplikace je určena pro vývojáře, designéry a další uživatele, kteří potřebují rychle převádět barevné hodnoty.

## 3. Požadavky

### 3.1 Funkční požadavky

#### 3.1.1 Přijetí barevného vstupu
- Aplikace musí přijmout barevný řetězec (např. `#FF5733`, `rgb(255, 87, 51)`, `rgba(255, 87, 51, 0.5)`).

#### 3.1.2 Konverze barev
- Aplikace musí převést přijatý barevný vstup do formátů:
  - RGB: `(255, 87, 51)`
  - RGBA: `(255, 87, 51, 1)` (nebo odpovídající alfa hodnotu)
  - HEX: `#FF5733`

#### 3.1.3 Výstup tabulky
- Aplikace musí zobrazit tabulku s výsledky ve formátu:
  ```
  | Format | Value           |
  |--------|------------------|
  | RGB    | (255, 87, 51)    |
  | RGBA   | (255, 87, 51, 1) |
  | HEX    | #FF5733          |
  ```

### 3.2 Nefunkční požadavky

#### 3.2.1 Výkon
- Aplikace by měla zpracovat vstup a vrátit výstup během 1 sekundy.

#### 3.2.2 Bezpečnost
- Aplikace by měla správně zachytit a zpracovat chybné vstupy (např. neplatné barevné hodnoty).

#### 3.2.3 Kompatibilita
- Aplikace musí být kompatibilní s moderními distribucemi Linuxu a vyžaduje nainstalovaný .NET Core.

## 4. Externí rozhraní

### 4.1 Uživatelské rozhraní
Aplikace bude fungovat v textovém režimu, interakce uživatele bude probíhat prostřednictvím příkazového řádku.

### 4.2 Hardwarové rozhraní
- Jakýkoliv počítač s nainstalovaným Linuxem a .NET Core.

### 4.3 Softwarové rozhraní
- .NET Core pro běh aplikace
- Knihovny pro práci s textem (pro analýzu barevných řetězců).

## 5. Doplňky
- Dokumentace pro uživatele bude k dispozici v README souboru.
- Aplikace bude mít interní nápovědu přístupnou pomocí příkazu `--help`.
