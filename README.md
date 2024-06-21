
# Google Forms Clone

This project is a simple clone of Google Forms built using Visual Basic for the desktop app and TypeScript with Express for the backend server.

## Features

- **Create Form**: Allows users to create a form by adding questions.
- **Load Form**: Loads a form by its ID and dynamically generates input fields for answers.
- **Submit Form**: Submits answers to a form identified by its ID.
- **View Submissions**: Retrieves and displays all submissions for a specific form.

## Technologies Used

- **Frontend**: Visual Basic (VB) for the desktop application.
- **Backend**: TypeScript, Express.js for REST API.

## Setup Instructions

1. **Clone the repository**:
   ```bash
   git clone https://github.com/V22X4/gform.vb.git
   ```

2. **Install dependencies**:
   - For the backend (Node.js and npm required):
     ```bash
     cd google-forms-backend
     npm install
     ```
   - For the frontend:
    ```bash
     cd GoogleForms
     dotnet add package Newtonsoft.Json
     ```

3. **Run the application**:
   - Start the backend server:
     ```bash
     cd google-forms-backend
     ts-node src/index.ts
     ```
   - Start the frontend:
     ```bash
     cd GoogleForms
     dotnet run
     ```
     

4. **Usage**:
   - Create forms, load them using IDs, submit answers, and view submissions using the desktop application.
