
# IDF Operation – First Strike


A C# object-oriented simulation representing an Israeli military strike system.  

The system includes intelligence analysis, target prioritization, and automated or manual execution of air and artillery strikes against terrorist threats.


## Project Overview


This project simulates a decision-making and strike process against Hamas terrorist units.  

The simulation includes:


- Initialization of terrorists and their data

- Intelligence reports generation

- Matching strike units to threats based on effectiveness

- Tracking ammunition and terrorist status


## Technologies


- Language: C#

- Framework: .NET Framework 4.8

- Type: Console Application


## System Structure


### IDF (Israel Defense Forces)

- Contains available strike units

- Executes manual and automatic strikes

- Tracks ammunition and strike results


### Hamas

- Holds a list of terrorists

- Each terrorist includes:

  - Name

  - Rank (1–9)

  - Weapon (Knife, Gun, M16, AK47)

  - Location

  - Status (Alive/Dead)


### AMAN (Military Intelligence)

- Generates intelligence reports per terrorist

- Includes last known location and timestamp


## Strike Units


| Unit       | Max Strikes | Effective Against     | Notes                        |

|------------|-------------|------------------------|------------------------------|

| F16 Jet    | 8           | Buildings              | Operated by pilot            |

| Drone      | 3           | People, Vehicles       | One strike per action        |

| Artillery  | 40          | Open areas             | Can hit multiple targets     |


## Features


- Display all strike units and their status

- Display all terrorist information

- Smart auto-strike based on threat level and location

- Manual strike by user choice

- Strike unit recommendation engine

- Weapon effectiveness score system

- Terrorist elimination tracking


## Quality Score Formula


```

Quality Score = Rank × Weapon Power

Weapon Power: Knife = 1, Gun = 2, M16/AK47 = 3

```


## Getting Started


1. Clone the repository

2. Open in Visual Studio

3. Build and run the project

4. Use the menu interface to simulate operations


## Authors


This project was developed by:


- Moti Kopshitz

- Dov Zucker


## License


This project is for educational use only.

