# Counter Strike Nexon Zombies 2D

Acest proiect a fost realizat pentru **Concursul de Creativitate IT "Severin Bumbaru"**, secțiunea **Liceu**, ediția **2022**.

## 🎮 Despre Joc

**Counter Strike Nexon Zombies 2D** este un joc de supraviețuire top-down shooter dezvoltat în C# folosind Windows Forms. Jucătorul preia rolul unui soldat care trebuie să supraviețuiască valurilor de zombi, să colecteze resurse și să elimine inamicii pentru a avansa.

Obiectivul principal este să supraviețuiești și să elimini **25 de zombi** pentru a completa nivelul.

## 🕹️ Controale

Jocul este controlat folosind tastatura:

| Tastă | Acțiune |
| :--- | :--- |
| **Săgeți (Sus, Jos, Stânga, Dreapta)** | Deplasare jucător |
| **Space** | Trage (Shoot) |
| **Enter** | Restart joc (doar când ești mort) |

## ⚔️ Mecanici de Joc

### 1. Supraviețuire
*   **Viață (Health):** Începi cu 100 HP. Dacă ești atins de un zombi, pierzi viață. Dacă viața ajunge la 0, jocul se termină.
*   **Muniție (Ammo):** Începi cu 20 de gloanțe. Trebuie să gestionezi muniția cu grijă.

### 2. Inamici (Zombi)
*   Zombii apar aleatoriu pe hartă și urmăresc jucătorul constant.
*   Viteza lor crește pe măsură ce avansezi sau în funcție de tipul lor.

### 3. Obiecte (Power-ups)
Pe parcursul jocului, vor apărea resurse pe hartă:
*   **💊 Medkit:** Restaurează viața complet (până la 100). Apare când viața scade sub 50%.
*   **🔫 Muniție:** Adaugă 10 gloanțe. Apare când rămâi fără muniție.

### 4. Sistem de Scor
*   Fiecare zombi eliminat crește scorul ("Kills").
*   La atingerea a **25 de eliminări**, nivelul este completat și apare opțiunea "Next Level".

## 🛠️ Detalii Tehnice

*   **Limbaj de programare:** C#
*   **Framework:** .NET Framework 4.7.2
*   **Tehnologie:** Windows Forms (WinForms)
*   **Sunet:** Utilizează `System.Media.SoundPlayer` pentru efecte sonore (împușcături, pick-ups) și muzică de fundal ("Eye of the Tiger").
*   **Grafică:** Resurse grafice 2D (Sprite-uri pentru jucător, zombi și obiecte).

## 🚀 Cum să rulezi jocul

### Cerințe de sistem
*   Sistem de operare: Windows 7/8/10/11
*   .NET Framework 4.7.2 instalat

### Rulare
1.  Navighează în folderul `bin\Debug`.
2.  Deschide fișierul `Counter Strike Nexon Zombies 2D.exe`.

## 👨‍💻 Autor
Proiect realizat în cadrul concursului "Severin Bumbaru" 2022.

## 📸 Galerie Foto

![Screenshot 1](Poze/Screenshot%202026-01-17%20214538.png)
![Screenshot 2](Poze/Screenshot%202026-01-17%20214622.png)
![Screenshot 3](Poze/Screenshot%202026-01-17%20214645.png)
![Screenshot 4](Poze/Screenshot%202026-01-17%20214727.png)
![Screenshot 5](Poze/Screenshot%202026-01-17%20214749.png)
