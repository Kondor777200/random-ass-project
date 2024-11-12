### Funkční specifikace  
**Projekt:** Správa knihovny  
**Verze dokumentu:** 1.0

| Verze | Datum | Autor           | Změny                                              |
|-------|-------|-----------------|----------------------------------------------------|
| 1.0   | 12.11 | Albert Vala   | Init                             |
---

### 1. Úvod

#### 1.1 Cíl dokumentu
Tento dokument poskytuje funkční specifikace aplikace „CLIhovna“. Popisuje jednotlivé funkce, UI a UX, která bude primárně konzolová popř. s textovým uživatelským rozhraním (TUI).

#### 1.2 Rozsah projektu
Aplikace umožní správu knih, čtenářů, zaměstnanců a vypujčení knih . Základní funkce jsou: přidávání, mazání knih a uživatelů, správu půjčení a zobrazení historie výpůjček. Aplikace bude výhradně konzolová s použitím textového uživatelského rozhraní (TUI), což znamená, že nebudou implementovány grafické komponenty.

#### 1.3 Cílové publikum
Cílovými uživateli tohoto dokumentu jsou vývojáři a zadavatel.

---

### 2. Rozsah aplikace

#### 2.1 Správa knih
Aplikace bude podporovat následující funkce pro správu knih:
- **Přidání nové knihy:** Knihovník zadá název, autora, rok vydání a ISBN knihy.
  - **Podpora pro ISBN:** Systém musí umožnit zadání jak nového 13-ciferného ISBN, tak starého 10-ciferného formátu ISBN. 
  - Pro **10-ciferné ISBN** bude při zadávání automaticky prováděna validace podle pravidel tohoto formátu.
  - Pro **13-ciferné ISBN** bude validace také prováděna podle příslušného standardu.
- **Mazání knihy:** Kniha může být smazána.

#### 2.2 Správa uživatelů
Funkce pro správu uživatelů zahrnují:
- **Přidání nového uživatele:** Uživatel zadá jméno, příjmení, a adresu, systém mu vygeneruje UID.
- **Úprava údajů o uživateli:** Uživatel může upravit své údaje.
- **Mazání uživatele:** Uživatel může být smazán.

#### 2.3 Správa výpůjček
Aplikace umožní správu výpůjček:
- **Vytvoření výpůjčky:** Půjčení knihy, zaznamenání data výpůjčky a knihovníka.
- **Ukončení výpůjčky:** Vrácení knihy, zaznamenání data vrácení a knihovníka.
- **Seznam aktuálních výpůjček:** Zobrazení seznamu knih, které jsou momentálně půjčené.

#### 2.4 Zobrazení historie výpůjček
Funkce historie výpůjček zahrnují:
- **Historie výpůjček knih:** Seznam uživatelů, kteří si knihu vypůjčili v minulosti.
- **Historie výpůjček uživatele:** Seznam knih, které si daný uživatel vypůjčil v minulosti.
- **Historie výpůjček knihovníka:** Seznam knih jež knihovník vypůjčil.

---

### 3. UI

#### 3.1 TUI
Aplikace bude konzolová a bude využívat textové uživatelské rozhraní (TUI). Hlavní nabídka bude uživateli umožňovat výběr jednotlivých funkcí:
- Správa knih
- Správa uživatelů
- Správa výpůjček
- Historie výpůjček

Pro každou funkci bude uživatelské rozhraní jasně strukturováno, přičemž uživatel bude provádět jednotlivé akce pomocí textových voleb nebo zadávání údajů v konzoli.

#### 3.2 Formuláře a vstupy
Každá funkce bude mít odpovídající formulář pro zadávání dat v konzoli. Uživatel bude zadávat informace krok za krokem, například zadání názvu knihy, autora, ISBN a dalších údajů. Bude implementována kontrola formátu pro ISBN, která bude podporovat oba formáty:
- **ISBN-10:** Bude podporován 10-ciferný formát ISBN, s validací podle pravidel tohoto formátu.
- **ISBN-13:** Bude podporován nový 13-ciferný formát ISBN, s odpovídající validací.

#### 3.3 Kontrola vstupů
Při zadávání údajů bude systém ověřovat správnost vstupů:
- **Neplatné ISBN (10 i 13 ciferné):** Systém vrátí chybovou hlášku, pokud zadané ISBN není platné. Pro ISBN-10 bude formát validován podle pravidel 10-ciferného ISBN, pro ISBN-13 podle pravidel 13-ciferného ISBN.
  - **Pro ISBN-10**: Systém vrátí chybovou hlášku „Zadejte platné ISBN (10-ciferný formát)“.
  - **Pro ISBN-13**: Systém vrátí chybovou hlášku „Zadejte platné ISBN (13-ciferný formát)“.
- **Chybějící povinné pole:** Systém upozorní: „Vyplňte prosím všechny povinné údaje“.
- **Neexistující záznam:** Pokud uživatel zkusí mazat neexistující knihu, systém zobrazí hlášku „Záznam nebyl nalezen“.

---

### 4. Řešení chybových stavů

#### 4.1 Chybné vstupy
Při zadání neplatných nebo chybných údajů bude aplikace reagovat následujícím způsobem:
- **Chybný formát ISBN:** Aplikace vyvolá odpovídající chybovou hlášku, pokud je ISBN neplatné (buď v 10-ciferném, nebo 13-ciferném formátu).
- **Povinné položky:** Pokud jsou povinné položky prázdné, systém upozorní na jejich vyplnění.

#### 4.2 Zachytávání kritických chyb
Kritické chyby (např. při práci s daty) budou zpracovány tak, aby nedošlo ke ztrátě dat a aplikace bude moci bezpečně restartovat.

---

### 5. Technické specifikace

#### 5.1 Platforma a nástroje
Aplikace bude vyvíjena v jazyce C# s použitím vývojového prostředí .NET fiddle.
---

### 6. Závěr
Tento dokument detailně popisuje funkce aplikace "CLIhovna" a specifikuje chování a reakce systému. Aplikace bude vyvíjena jako konzolová s TUI.
