# Doctor's Office Catalogue for the NI course


#### 1. Introduction:
> Write a program that will manage patients in a doctor's office implemented in C# WPF application clients and one .NET Core API server.
- The medical assistant panel will record the patients and their data who enter the office.
  - Name
     - Validation and UNIT test
   - Home Address
   - Health Insurance Number
     - Format have to be:  `000 000 000` 
     - Validation and UNIT test
   - Complaint

- The physician panel will offer to show the data of the patients who entered the office ordered by the time they entered.
  - Able to choose one patient
    - Can see the data of the patient
    - The data could be changeable.
    - Capable of write a diagnosis
    - The patient from the list deletable  

- Server
  - Able to store and provide the data for the clients
  - API, so provide JSON for further applications and it is lightweight
  - After the start or restart the data is load the previous status

- Additions
  - Added Date of birth to manage patient age and more precisely determine their problems.
  - Search panel
    - You can search by Name or SNN (Social Security Number / Health Insurance Card)
    - Show how many valid search have been found. 
  - Added allergy option to handle the patients allergies
  - The physician can prescribe the medicine via medicine panel.

---
#### 2. Team members:
[@bzsol](https://github.com/bzsol)<br>
[@KBE9](https://github.com/KBE9)

---
#### 3. Mentions:
 - The Unit test is written in MSUnit test
 - NuGet packages used in the project:
   - <b>MaterialDesignThemes</b>
   - <b>Newtonsoft.Json</b>
   - <b>MStestFramework</b> 

---



