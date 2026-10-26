
# 🤖 AI Assistant – .NET Learning Companion

An AI-powered chatbot developed using ASP.NET Core MVC and OpenAI API to provide instant answers, programming explanations, and coding examples.

## 📌 Project Overview

AI Assistant is a web-based application designed to help developers and students learn programming concepts through an interactive chatbot.

It integrates the OpenAI API to generate intelligent responses to user questions related to C#, .NET, SQL, ASP.NET MVC, ADO.NET, and other programming technologies.

The application provides formatted responses using Markdown, including headings, bullet points, tables, and code examples.

## 🚀 Features

- Interactive chatbot interface
- OpenAI API integration
- AI-generated programming explanations
- C# and .NET learning assistance
- SQL and ASP.NET MVC interview preparation
- Code examples and explanations
- Markdown-formatted responses
- Quick suggestion buttons
- Secure API key management using .NET User Secrets
- Responsive user interface

## 🛠️ Technologies Used

| Technology | Purpose |
|---|---|
| C# | Backend programming |
| ASP.NET Core MVC | Web application framework |
| OpenAI API | AI-generated responses |
| GPT-4o-mini | Language model |
| HTML5 | Page structure |
| CSS3 | UI styling |
| JavaScript | Client-side interaction |
| Markdig | Markdown-to-HTML conversion |
| JSON | API request and response handling |
| Git & GitHub | Version control |

## 📸 Application Screenshots

### AI Assistant – Welcome Screen

<img width="1917" height="1015" alt="Screenshot 2026-10-27 013539" src="https://github.com/user-attachments/assets/1101fa01-e4fe-448e-8a6d-a1eb5e35abc3" />


### AI Assistant – Generated Response

<img width="1723" height="913" alt="C# AI Assistant Chat Interface" src="https://github.com/user-attachments/assets/52d89c17-9779-4441-8496-b59f0264bf00" />


## ⚙️ Application Workflow

1. User opens the AI Assistant application.
2. User enters a programming-related question.
3. The ASP.NET Core MVC controller receives the question.
4. The controller sends the request to the OpenAI API.
5. OpenAI generates an appropriate response.
6. The application receives the response.
7. Markdig converts the Markdown response into HTML.
8. The formatted response is displayed in the chatbot interface.

## 📂 Project Structure

```text
ChatbotDevep/
│
├── Controllers/
│   └── ChatbotController.cs
│
├── Models/
│   └── Chatbot.cs
│
├── Views/
│   └── Chatbot/
│       └── Index.cshtml
│
├── wwwroot/
│
├── Properties/
│
├── appsettings.json
├── Program.cs
├── ChatbotDevep.csproj
├── .gitignore
└── README.md
```

## 🔧 Installation and Setup

### Prerequisites

- Visual Studio 2022 or later
- .NET SDK compatible with the project
- Git
- OpenAI API key

### Step 1: Clone the Repository

```bash
git clone https://github.com/YOUR_USERNAME/AI-Assistant-ASP.NET-Core-MVC.git
```

### Step 2: Open the Project

Open the solution file in Visual Studio.

### Step 3: Restore NuGet Packages

```bash
dotnet restore
```

### Step 4: Configure OpenAI API Key

Initialize .NET User Secrets:

```bash
dotnet user-secrets init
```

Add your API key:

```bash
dotnet user-secrets set "OpenAI:ApiKey" "YOUR_OPENAI_API_KEY"
```

Never upload your API key to GitHub.

### Step 5: Run the Application

```bash
dotnet run
```

Alternatively, run the application using Visual Studio.

## 🔐 Security

- OpenAI API key is stored using .NET User Secrets.
- API credentials are not hardcoded in source code.
- API requests are handled through the backend controller.

## 🎯 Learning Outcomes

Through this project, I gained practical experience in:

- ASP.NET Core MVC architecture
- C# and asynchronous programming
- HTTP requests using HttpClient
- REST API integration
- JSON serialization and deserialization
- Configuration management
- Secure API key handling
- Markdown rendering using Markdig
- Git and GitHub version control

## 👨‍💻 Author

Developed as a personal learning and development project.

**Project:** AI Assistant – .NET Learning Companion
