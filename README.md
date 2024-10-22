# Groomy - Dog Grooming Appointment App

## Overview
Groomy is a dog grooming application designed to help users manage and locate their next grooming appointments. The application uses Firebase's Firestore cloud database for data management.

## Functional Requirements
1. User Authentication
   - Login functionality with email and password
   - Failed login attempts refresh the form
   - Successful login redirects to home screen with welcome message
   - Local authentication implementation

2. User Creation
   - Form with fields for:
     - First name
     - Last name
     - Email address
     - Password
   - Redirect to login screen after successful creation

3. GUI Requirements
   - Login form display for unauthenticated users
   - Navigation menu with highlighted active item
   - Welcome message display for authenticated users
   - Teal color scheme with lighter teal for active menu items

## Non-Functional Requirements
1. Security
   - Password hashing required for storage
   - No plain text password storage
   - Secure database access

2. Testing
   - Unit tests required for all public methods
   - Test coverage for all classes
   - No testing of private methods
   - Testable code architecture

## System Standards & Conventions

### Technology Stack
- **Frontend**: Windows Forms (.NET)
- **Backend**: C#
- **Database**: Firebase Firestore
- **Authentication**: BCrypt for password hashing

### Database Schema
1. Users Collection
   - First Name
   - Last Name
   - Email Address
   - User ID (auto-generated)

2. Passwords Collection
   - User ID (foreign key)
   - Hashed Password

### Project Structure

We are basically making a folder for each aspect of the project

### Coding Conventions
1. Naming Conventions
   - Classes: camelCase (e.g., `userService`)
   - Methods: camelCase (e.g., `createUser`)
   - Variables: camelCase (e.g., `firstName`)
   - Private fields: _camelCase (e.g., `_userRepository`)

2. Code Organization
   - One class per file
   - Organize by feature/module
   - Keep methods focused and single-purpose
   - Use meaningful names for all identifiers

## Getting Started for Developers

### Prerequisites
1. Install .NET SDK
2. Firebase account and credentials
3. IDE (Visual Studio recommended)
4. Git for version control

### Setup Instructions
1. Clone the repository:
```bash
git clone https://github.com/bsu-cs4360-software-engineering/groomy-peek-performance.git
```

2. Add Firebase credentials:
   - Generate Firebase SDK private key
   - Rename to `firebaseSDK.json`
   - Place in `services` folder

3. Install required packages:
```xml
dotnet add package BCrypt.Net-Next --version 4.0.2
dotnet add package Google.Cloud.Firestore --version 3.2.0
dotnet add package FirebaseAdmin --version 2.3.0
```

### Running the Application
1. Build the project:
```bash
dotnet build
```

2. Run the application:
```bash
dotnet run
```

### Running Tests
```bash
dotnet test
```

## Important Notes
- Never commit `firebaseSDK.json` to version control
- Always write unit tests for new features
- Follow the coding conventions strictly
- Keep documentation updated

## Development Workflow
1. Create a new branch for each feature
2. Write tests before implementing features
3. Ensure all tests pass before creating pull requests
4. Follow code review process
5. Update documentation as needed

## Database Configuration
Ensure proper setup of Firebase Firestore:
- Create Firebase project
- Configure security rules
- Set up appropriate indexes
- In the firstore database add a collection Users
- The documents inside users have the corresponding fields
- email, fName, lName, password (all are strings)
- Test connection before development
