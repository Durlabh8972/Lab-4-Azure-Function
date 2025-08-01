
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
  <img width="953" height="597" alt="image" src="https://github.com/user-attachments/assets/4f40466e-5f93-483b-9408-18bf0b1cc925" />

  <img width="959" height="599" alt="image" src="https://github.com/user-attachments/assets/6d0cdb46-357d-4679-8107-f310e3278e63" />

  <img width="956" height="574" alt="image" src="https://github.com/user-attachments/assets/019819ef-a12f-41cb-95e7-89711d9513f4" />

- Logs for Build, Test, and Deploy
- 
  <img width="959" height="569" alt="image" src="https://github.com/user-attachments/assets/08bf11fe-5bf6-4240-a0f2-c1cc84f0392f" />

  <img width="959" height="572" alt="image" src="https://github.com/user-attachments/assets/95d6423b-f077-470b-af0a-f0f6a364ca8f" />


- Function running in Azure

<img width="956" height="569" alt="image" src="https://github.com/user-attachments/assets/d29cb370-46e5-4f0b-a03d-80cd2fe188aa" />

<img width="959" height="569" alt="image" src="https://github.com/user-attachments/assets/137156d1-4c9b-4520-b99f-cf43b72fc647" />
  
- Output in browser or Postman

---

**Author**: Durlabh Tilavat  
**Course**: CI/CD
