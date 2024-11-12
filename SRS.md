### Software Requirements Specification (SRS)  
**Projekt:** Správa knihovny  
**Verze dokumentu:** 1.0

| Verze | Datum       | Autor           | Změny                                               |
|-------|-------------|-----------------|-----------------------------------------------------|
| 1.0   | 12.11.2024  | Albert Vala     | Init |

---

### 1. Úvod

#### 1.1 Cíl dokumentu  
Tento dokument definuje požadavky na vývoj softwaru „Správa knihovny“, který bude sloužit k evidenci knih, správě uživatelů a sledování výpůjček. Dokument poskytuje jak funkční, tak nefunkční požadavky, které budou klíčové pro následný vývoj aplikace. Cílem tohoto projektu je poskytnout knihovnám nástroj pro efektivní správu fondu knih, čtenářů a výpůjček.

#### 1.2 Rozsah projektu
Aplikace bude určena pro knihovny. Obsahuje základní funkce pro správu knih, uživatelů, výpůjček a jejich historie. Vývoj softwaru bude řízen principy objektově orientovaného programování v jazyce C# s využitím .NET Fiddle jako vývojového prostředí. Aplikace bude primárně konzolová, ale s možností budoucího rozšíření o pokročilé funkce (např. textové uživatelské rozhraní TUI). Data budou uchovávána pouze v paměti a nebudou ukládána do souborů.

#### 1.3 Cílové publikum
Cílovými uživateli tohoto dokumentu jsou:
- **Vývojáři:** Ti, kteří budou aplikaci vyvíjet.
- **Zadavatel:** Odpovědní zástupci knihoven, kteří aplikaci budou používat.
---

### 2. Popis systému

#### 2.1 Přehled  
Systém „CLIhovna“ umožní správu knih, evidenci uživatelů a zaznamenávání výpůjček v knihovnách. Projekt se zaměřuje na efektivní řízení knihovního fondu s možností snadného rozšíření o pokročilé funkce. Aplikace bude konzolová, bez potřeby ukládání dat do souborů, a bude implementována s využitím .NET Fiddle. Data (knihy, uživatelé, výpůjčky) budou uchovávána v paměti během běhu aplikace.

#### 2.2 Předpoklady a omezení  
- **Předpoklady:**
  - Aplikace bude primárně konzolová.
  - Data budou uchovávána pouze v paměti (v interních strukturách) a nebudou ukládána na disk.
  - Aplikace bude vyvinuta v C# a použije prostředí .NET Fiddle.
- **Omezení:**
  - Aplikace nebude obsahovat pokročilou bezpečnostní funkcionalitu (autentizace, šifrování).
  - Aplikace nebude podporovat síťovou komunikaci ani cloudové ukládání dat.

---

### 3. Funkční požadavky

#### 3.1 Správa knih  
- **Priorita:** Vysoká  
- **Popis:** Knihovník bude moci přidávat, upravovat, mazat a zobrazovat knihy včetně informací o jejich dostupnosti.  
- **Detailní požadavky:**
  1. **Přidání knihy:** Systém musí umožnit přidání nové knihy s následujícími údaji:
     - Název knihy
     - Autor
     - Rok vydání
     - ISBN (podpora pro ISBN-10 i ISBN-13)
  2. **Úprava knihy:** Knihovník může upravit údaje o knize.
  3. **Smazání knihy:** Systém musí umožnit smazání knihy ze systému.
  4. **Zobrazení knih:** Uživatel bude moci filtrovat seznam knih podle názvu nebo autora.

#### 3.2 Správa uživatelů  
- **Priorita:** Vysoká  
- **Popis:** Uživatel bude moci přidávat, upravovat a mazat čtenáře v systému.  
- **Detailní požadavky:**
  1. **Přidání uživatele:** Systém musí umožnit přidání nového uživatele s následujícími údaji:
     - Jméno a příjmení
     - Adresa
  2. **Úprava uživatele:** Knihovník může upravit údaje o čtenáři.
  3. **Smazání uživatele:** Systém musí umožnit smazání uživatele.

#### 3.3 Správa výpůjček  
- **Priorita:** Vysoká  
- **Popis:** Systém umožní správu výpůjček, včetně půjčení a vrácení knih.
- **Detailní požadavky:**
  1. **Vypůjčení knihy:** Uživatel si může vypůjčit knihu, pokud je dostupná, a systém zaznamená datum výpůjčky a knihovníka.
  2. **Vrácení knihy:** Po vrácení knihy bude zaznamenáno datum vrácení a knihovník, kniha se uvolní pro další výpůjčku.
  3. **Zobrazení výpůjček:** Knihovník si bude moci zobrazit seznam všech aktuálně vypůjčených knih.

#### 3.4 Historie výpůjček  
- **Priorita:** Střední  
- **Popis:** Systém uchová historii výpůjček pro každou knihu i uživatele.  
- **Detailní požadavky:**
  1. **Zobrazení historie knihy:** Možnost zobrazení seznamu uživatelů, kteří si knihu půjčili a vrátili, včetně dat.
  2. **Zobrazení historie uživatele:** Možnost zobrazení seznamu knih, které si uživatel vypůjčil.

---

### 4. Nefunkční požadavky

#### 4.1 Výkon  
- **Priorita:** Střední  
- **Požadavek:** Aplikace musí být schopna pracovat s databází obsahující až 1000 knih a 1000 uživatelů bez znatelné degradace výkonu. Odezva na operace by měla být do 1 sekundy.

#### 4.2 Použitelnost  
- **Priorita:** Střední  
- **Požadavek:** Aplikace musí být intuitivní a snadno ovladatelná i pro uživatele bez technického vzdělání.

#### 4.3 Přenositelnost  
- **Priorita:** Nízká  
- **Požadavek:** Aplikace bude navržena pro platformu Windows. Možnost rozšíření na jiné platformy není prioritou.
---

### 5. Technické požadavky  
- **Programovací jazyk:** C#  
- **Vývojové prostředí:** .NET Fiddle  

---

### 6. Závěr  
Tento dokument specifikuje požadavky na aplikaci „CLIhovna“, která bude implementována v prostředí .NET Fiddle a zaměřena na správu knih, čtenářů a výpůjček bez potřeby trvalého ukládání dat do souborů. Aplikace bude připravena na možné rozšíření o nové funkce v budoucnu.
