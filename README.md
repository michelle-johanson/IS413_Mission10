# Mission 10 — Bowling League Bowlers

Displays bowlers from the **Marlins** and **Sharks** teams using a .NET 10 API and React/TypeScript frontend.

## Requirements Met

- Bowler Name (First, Middle, Last), Team Name, Address, City, State, Zip, Phone
- Only Marlins and Sharks teams are shown
- Heading component describing the page
- BowlerTable component with a data table
- Both components used in App

## Run Locally

**Prerequisites:** .NET 10 SDK, Node.js

**Terminal 1 — Backend**
```bash
cd backend/BowlingApi
dotnet run --launch-profile http
```
API runs at `http://localhost:5203`

**Terminal 2 — Frontend**
```bash
cd frontend
npm install
npm run dev
```
App runs at `http://localhost:5173`
