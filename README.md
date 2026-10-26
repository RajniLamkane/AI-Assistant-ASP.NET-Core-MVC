
<div align="center">

# 🤖 AI Assistant
### Your Smart .NET Learning Companion

An AI-powered chatbot built using **ASP.NET Core MVC, C# and OpenAI API** to provide intelligent programming explanations, coding examples and interview preparation assistance.

<br/>

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-MVC-purple?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-Programming-239120?style=for-the-badge&logo=csharp)
![OpenAI](https://img.shields.io/badge/OpenAI-API-black?style=for-the-badge&logo=openai)
![GitHub](https://img.shields.io/badge/GitHub-Version%20Control-181717?style=for-the-badge&logo=github)

</div>

---

## 📌 About The Project

**AI Assistant – .NET Learning Companion** is a web-based chatbot application developed using ASP.NET Core MVC and OpenAI API.

The main objective of this project is to help developers and students learn programming concepts through an interactive AI-powered chatbot.

Users can ask questions related to C#, .NET, SQL, ASP.NET MVC, ADO.NET and other programming technologies and receive intelligent, easy-to-understand responses.

The application uses Markdown formatting to display structured explanations, bullet points, tables and programming code examples.

## ✨ Key Features

| Feature | Description |
|---|---|
| 🤖 AI-Powered Chat | Generates intelligent responses using OpenAI API |
| 💻 Programming Assistance | Helps users understand C#, .NET and programming concepts |
| 🗄️ SQL Learning | Provides SQL explanations and interview questions |
| ⚡ Code Examples | Generates programming examples with explanations |
| 📝 Markdown Rendering | Displays formatted headings, lists, tables and code blocks |
| 💡 Quick Suggestions | Provides predefined questions for easy interaction |
| 🔐 Secure Configuration | Stores API keys using .NET User Secrets |
| 📱 Responsive UI | Modern chatbot interface with responsive styling |

## 🛠️ Technologies & Tools

| Technology | Usage |
|---|---|
| C# | Backend programming language |
| ASP.NET Core MVC | Web application architecture |
| OpenAI API | AI response generation |
| GPT-4o-mini | Language model |
| HTML5 | Frontend structure |
| CSS3 | UI design and styling |
| JavaScript | Client-side interaction |
| Markdig | Markdown-to-HTML conversion |
| HttpClient | API communication |
| System.Text.Json | JSON serialization and deserialization |
| Git & GitHub | Source code management |

---

## 📸 Application Screenshots

### 🏠 1. AI Assistant – Welcome Screen

The welcome screen provides a clean chatbot interface with quick suggestion buttons to help users start a conversation.

<div align="center">

<img src="https://github.com/user-attachments/assets/1101fa01-e4fe-448e-8a6d-a1eb5e35abc3" width="95%" alt="AI Assistant Welcome Screen"/>

</div>

### 💬 2. AI Assistant – Generated Response

The chatbot receives the user's question and displays an AI-generated response with properly formatted explanations and programming examples.

<div align="center">

<img src="https://github.com/user-attachments/assets/52d89c17-9779-4441-8496-b59f0264bf00" width="95%" alt="AI Assistant Generated C# Response"/>

</div>

---

## ⚙️ Application Workflow

The application follows this workflow:

<div align="center">

```text
       USER
         |
         v
  Enters a Question
         |
         v
  ASP.NET Core MVC
      Controller
         |
         v
  HTTP Request using
     HttpClient
         |
         v
     OpenAI API
         |
         v
  AI-Generated Response
         |
         v
   JSON Response
         |
         v
  Markdown Conversion
       (Markdig)
         |
         v
   Formatted HTML
         |
         v
   Display Response
      to User
```

</div>

### Workflow Explanation

1. The user opens the AI Assistant application.
2. The user enters a programming-related question.
3. The Chatbot Controller receives the question.
4. The controller sends an HTTP request to the OpenAI API.
5. OpenAI generates an appropriate response.
6. The application receives the response in JSON format.
7. Markdig converts the Markdown response into HTML.
8. The formatted response is displayed in the chatbot interface.

---

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

---

## 🚀 Installation & Setup

Follow these steps to run the project on your local machine.

### Prerequisites

Make sure you have installed:

- Visual Studio 2022 or later
- Compatible .NET SDK
- Git
- OpenAI API Key

### Step 1: Clone the Repository

```bash
git clone https://github.com/YOUR_USERNAME/AI-Assistant-ASP.NET-Core-MVC.git
```

### Step 2: Open the Project

- Open the downloaded project folder.
- Open the solution file using Visual Studio.
- Wait for NuGet packages to restore.

### Step 3: Restore NuGet Packages

Open the terminal in the project directory and execute:

```bash
dotnet restore
```

### Step 4: Configure OpenAI API Key

Initialize .NET User Secrets:

```bash
dotnet user-secrets init
```

Configure your OpenAI API key:

```bash
dotnet user-secrets set "OpenAI:ApiKey" "YOUR_OPENAI_API_KEY"
```

**Important:** Never upload your actual API key or secret credentials to GitHub.

### Step 5: Run the Application

Execute:

```bash
dotnet run
```

Alternatively, press **F5** in Visual Studio to run the application.

---

## 🔐 Security

- OpenAI API key is managed using .NET User Secrets.
- API credentials are not hardcoded in the source code.
- API requests are processed through the backend controller.
- Sensitive configuration values should never be committed to GitHub.

---

## 🎯 Learning Outcomes

Through this project, I gained practical experience in:

- Developing web applications using ASP.NET Core MVC.
- Working with C# and asynchronous programming.
- Integrating third-party REST APIs.
- Sending HTTP requests using HttpClient.
- Handling JSON responses using System.Text.Json.
- Managing application configuration using IConfiguration.
- Securing API keys using .NET User Secrets.
- Converting Markdown into HTML using Markdig.
- Designing responsive user interfaces using HTML, CSS and JavaScript.
- Managing source code using Git and GitHub.

---

## 🔮 Future Enhancements

- Conversation history management.
- User authentication and authorization.
- Multiple conversation support.
- Chat export functionality.
- Improved error handling and loading indicators.
- Streaming AI responses.

---

## 👨‍💻 Author

**Developed as a personal learning and development project.**

### AI Assistant – .NET Learning Companion

If you find this project useful, feel free to explore the source code and share your feedback.

---

<div align="center">

### ⭐ Learn • Build • Innovate ⭐

**Built with ❤️ using C#, ASP.NET Core MVC and OpenAI API**

</div>
