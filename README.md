
# Azure Function CI/CD Pipeline Lab

This project demonstrates a simple CI/CD pipeline using Azure DevOps for deploying an Azure Function App written in C#. It includes three stages: Build, Test, and Deploy.

## ✅ Project Structure

```
azure-function-lab/
│
├── HelloWorldFunction/              # Azure Function App
│   ├── HelloWorldFunction.csproj
│   └── Function1.cs
│
├── HelloWorldFunction.Tests/       # Unit Test Project
│   ├── HelloWorldFunction.Tests.csproj
│   └── FunctionTests.cs
│
└── azure-pipelines.yml             # Azure DevOps Pipeline Definition
```

## 🚀 Instructions

### 1. Clone this repository

```bash
git clone https://github.com/your-username/azure-function-lab.git
cd azure-function-lab
```

### 2. Prerequisites

- GitHub account
- Azure account (Free Trial is okay)
- Azure DevOps organization
- .NET 6 SDK installed

### 3. Set Up in Azure DevOps

1. Create a new Azure DevOps project.
2. Create a new pipeline → Choose GitHub → Select this repo.
3. Use the existing `azure-pipelines.yml` file.
4. Set up a service connection for Azure (ARM).
5. Replace the placeholders in `azure-pipelines.yml`:
   - `azureSubscription`
   - `appName`

### 4. Run the Pipeline

Trigger the pipeline manually or push code changes. Ensure all three stages succeed:

- ✅ Build: Compiles the Azure Function
- ✅ Test: Executes unit tests with xUnit
- ✅ Deploy: Publishes the function to Azure

### 5. Verify Deployment

Go to Azure Portal → Function App → Get Function URL → Test in browser or Postman.

## 🧪 Output

```
Hello, world from Azure Function!
```

## 📸 Screenshots to Include

- Azure Pipeline
- <img width="953" height="597" alt="image" src="https://github.com/user-attachments/assets/4f40466e-5f93-483b-9408-18bf0b1cc925" />

- Logs for Build, Test, and Deploy
- Function running in Azure
- Output in browser or Postman

---

**Author**: Durlabh Tilavat  
**Course**: INFO8985 - Cloud DevOps Practices  
