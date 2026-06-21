# Hospital Management System (HMS)

An enterprise-grade C# WinForms application (`.NET Framework 4.7.2`) for managing patient registrations, doctor schedules, appointments, and prescriptions, backed by Microsoft SQL Server.

---

## Getting Started

Follow these steps to set up the project locally on your machine.

### Prerequisites
1. **Visual Studio** (2022 recommended) with the `.NET desktop development` workload installed.
2. **Microsoft SQL Server** (Express or Developer edition).
3. **SQL Server Management Studio (SSMS)**.

---

## Step 1: Database Preparation (SSMS)

1. Open **SQL Server Management Studio (SSMS)**.
2. Connect to your local SQL Server instance.
3. Open the SQL script [create_db.sql](./create_db.sql) located in the root of this project:
   - Click `File` -> `Open` -> `File...` -> Choose `create_db.sql`.
4. Click **Execute** (or press `F5`) to run the script.
   - This script creates the database `HospitalManagementDB`.
   - It sets up all the relational tables (`Users`, `Doctors`, `Patients`, `Sessions`, `Appointments`, `MedicalRecords`).
   - It inserts sample seed data (such as default login credentials, active doctors, registered patients, and doctor sessions).

---

## Step 2: Configure Connection String

The application loads its database connection configuration from `App.config`.

1. In Visual Studio, open the solution.
2. Locate and open `App.config` inside the `hospital-management-system` project.
3. Look at the `<connectionStrings>` block:
   ```xml
   <connectionStrings>
     <add name="HMSConnectionString" 
          connectionString="Data Source=localhost;Initial Catalog=HospitalManagementDB;Integrated Security=True;TrustServerCertificate=True" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
4. If your local SQL Server instance does not run on `localhost` (e.g. if it uses a named instance like `localhost\SQLEXPRESS` or `(localdb)\MSSQLLocalDB`), edit the `Data Source` value accordingly:
   - **Local Default Instance**: `Data Source=localhost;` or `Data Source=.;`
   - **Local Express Instance**: `Data Source=localhost\SQLEXPRESS;` or `Data Source=.\SQLEXPRESS;`
   - **LocalDB Instance**: `Data Source=(localdb)\MSSQLLocalDB;`

---

## Step 3: Run the Application & Log In

Build and run the application in Visual Studio (`Debug` or `Release` mode).

Use the following default credentials created by the database seed script to log into the system:

| Username | Password | Role | Full Name |
| :--- | :--- | :--- | :--- |
| **admin** | `123` | Administrator | System Administrator |
| **doc01** | `doctor123` | Doctor | Dr. Olivia Bennett |

---

## Features Showcase
- **Dynamic User Authentication**: Validates credentials directly against the database `Users` table.
- **Overview Dashboard**: Shows active metrics and displays recent appointments dynamically using SQL joins.
- **Session Management**: Receptionists can view and schedule doctor sessions on demand.
- **Doctor Registration & Patient Registration**: Inputs saved directly to the database with update capabilities.
- **Doctor Hub (Prescriptions)**: Doctors can clinical-diagnose, prescribe medicines, and print automated, styling-rich PDF prescription reports output to their Desktop directory.
