# WPF Project Logic

This is a placeholder or "hybrid" project for the WPF Application I plan to make. 
I expect to learn more, advance my code and rewrite a few things. I decided to do so in a console app rather than an actual WPF App to be able to concentrate on the functionality before needing to worry about WPF and its design/layout.

# The problem
Many self employed VFX Artists do all the work themselves: from handling clients to book keeping and actually working the projects. There is no uniform way for them to handle the paperwork more efficiently. Some may use google docs or excel spreadsheets to keep up with their data but they struggle to keep everything in one place and well organized. 

# Functionality/Ideas
The app will be used for book keeping. It will help maintain a local database built by user input and filter and retrieve data whenever requested. I plan to also include a statistics viewer as well as a dynamically adjustable bill creator.

# Layout
The app can easily be broken up in different "cards" or "objects". Every created agency, client or project will always have the same fields, like name, id, a timeline of events and so forth.

## Card: Agency

<details>
<summary>Agency Card Contents</summary>

```
AGENCY
├── agency name
├── agency id
├── agency email
├── agency address
│   ├── street name
│   ├── street number
│   ├── zip code
│   ├── province
│   └── country
├── CONTACT (+) # There can be more than one person to contact within an agency
│   ├── contact name
│   ├── contact phone
│   ├── contact address
│      ├── street name
│      ├── street number
│      ├── zip code
│      ├── province
│      └── country
│   └── contact dated note
├── agency dated notes
├── OVERVIEW
│   ├── date first hired dd/mm/yyy
│   ├── total projects 00000
│   ├── total value all projects €€€€
│   ├── last 3 logs preview
│   └── dated note
└── EVENTS (LOG) # Chronologically ordered log of events
   ├── {USER} of {COMPANY} added/removed note
   └── ...

Events: AgencyCreate, AgencyEdit, AgencyUpdate
```
</details>

## Card: Client

<details>
<summary>Client Card Contents</summary>
  
```
CLIENT
├── client name (typically a company)
├── client id
├── client email
├── client address
│   ├── street name
│   ├── street number
│   ├── zip code
│   ├── province
│   └── country
├── CONTACT (+) # There can be more than one person to contact as a client is not always just one person
│   ├── contact name
│   ├── contact phone
│   ├── contact address
│      ├── street name
│      ├── street number
│      ├── zip code
│      ├── province
│      └── country
│   └── contact dated note
├── client dated notes
├── OVERVIEW
│   ├── date first hired dd/mm/yyy
│   ├── total projects 00000
│   ├── total value all projects €€€€
│   ├── last 3 logs preview
│   └── dated note
└── EVENTS (LOG) # Chronologically ordered log of events
   ├── {USER} of {COMPANY} added/removed note
   └── ...

Events: ClientCreate, ClientEdit, ClientUpdate
```
</details>

## Card: Project

<details>
<summary>Project Card Contents</summary>
  
```
PROJECT - STATUS # The status should be easily visible
├── project name
├── project id
├── project dated notes
├── project associated client
│   ├── client name, email, address, phone
├── LOGGING PER {SELFEMPLOYEE} # logs need to be separated in case a second or third person also worked on this
│   ├── date project received               start date dd/mm/yyy - end date dd/mm/yyy = total hours
│   └── {SELFEMPLOYEE} LOG ADD/EDIT
│      ├── start date dd/mm/yyy
│      ├── end date dd/mm/yyy
│      ├── [ ] Override hours (if true, unlock field with num input)
│      ├── [ ] Add overtime (if true, unlock field with num input)
│      ├── sum hours for {SELFEMPLOYEE}
│      ├── bool other employees spent time here?
│      ├── total worth €€€
│      ├── actual delivery date dd/mm/yyy
│      └── dated note
└── EVENTS (LOG) # Chronologically ordered log of events
   ├── {USER} of {COMPANY} added/removed note
   └── ...

Events: ProjectCreate, ProjectEdit, ProjectUpdate
Project Status: RECEIVED, WORKING, AWAITCLIENTREVIEW, DELIVERED, PAID
Note: For projects, we assume a work day to be 8 hours unless specifically overridden per project.
```
</details>

## Card: Company
<details>
<summary>Company Card Contents</summary>
  
```
COMPANY
├── company name
├── company id
├── company email
├── company address
│   ├── street name
│   ├── street number
│   ├── zip code
│   ├── province
│   └── country
├── CONTACT (+) # The user themselves, the employee
│   ├── individual name
│   ├── individual phone
│   ├── individual address
│      ├── street name
│      ├── street number
│      ├── zip code
│      ├── province
│      └── country
├── OVERVIEW
│   ├── some
│   ├── statistics
│   └── maybe?
└── EVENTS (LOG) # Chronologically ordered log of events
   ├── {USER} of {COMPANY} added/removed note
   └── ...

Events: CompanyCreate, CompanyEdit, CompanyUpdate
```
</details>

## Database
- JSON
- SQLITE
- Automatic backups
- JSON - SQLITE conversion in the program to populate data and/or load backups
