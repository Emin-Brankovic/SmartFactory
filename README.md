# SmartFactory

A comprehensive smart factory monitoring and management system with real-time sensor data, threshold monitoring, and production analytics.

## 🏭 Project Overview

SmartFactory is a full-stack application consisting of:
- **Backend API** (.NET 8 Web API) - Handles data processing, sensor management, and business logic
- **Frontend** (React.js) - Modern web interface for monitoring and controlling factory operations
- **Real-time Data Integration** - Connects to external DataMiner services for live sensor data

## 📋 Prerequisites

### Required Software
- **.NET 8.0 SDK** - [Download here](https://dotnet.microsoft.com/download/dotnet/8.0)
- **Node.js 18+** - [Download here](https://nodejs.org/)
- **Git** - [Download here](https://git-scm.com/)

### Environment Variables
You'll need to set up environment variables for the DataMiner API connection:

1. Create a `.env` file in the `SmartFactoryWebApi` directory
2. Add your DataMiner API token:
```
TOKEN=your_dataminer_api_token_here
```

## 🚀 Quick Start

### 1. Clone the Repository
```bash
git clone <repository-url>
cd SmartFactory
```

### 2. Backend Setup (SmartFactoryWebApi)

```bash
cd SmartFactoryWebApi

# Install dependencies
dotnet restore

# Set up environment variables
# Create a .env file with your DataMiner API token
echo "TOKEN=your_dataminer_api_token_here" > .env

# Run the backend API
dotnet run
```

The backend API will be available at: `https://localhost:7001` or `http://localhost:5001`

### 3. Frontend Setup (smartfactoryfrontend)

```bash
cd smartfactoryfrontend

# Install dependencies
npm install

# Start the development server
npm start
```

The frontend will be available at: `http://localhost:3000`

## 🔧 Configuration

### Backend Configuration

The backend uses several configuration files:

- **appsettings.json** - Main application settings
- **threshold.json** - Sensor threshold configurations (automatically managed)
- **.env** - Environment variables (create this file)


## Disclaimer
If the application fails to display any information, or only displays partial data, it is likely due to Skyline having shut down the APIs that were previously used to retrieve sensor data.
