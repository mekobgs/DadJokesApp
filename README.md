# Dad Jokes Blazor WebAssembly App

This is a Blazor WebAssembly application that fetches and displays random dad jokes using the RapidAPI Dad Jokes API.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Configuration](#configuration)

## Introduction

This Blazor WebAssembly application demonstrates how to fetch and display random dad jokes using the RapidAPI Dad Jokes API. It includes a button to fetch a random joke and displays the joke's setup and punchline.

## Features

- Fetch and display random dad jokes from the RapidAPI Dad Jokes API.
- Button to retrieve a new random joke.
- Configurable API settings for API key, host, and base URI.

## Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- A text editor or integrated development environment (IDE) for code editing

### Installation

1. Clone the repository:

   ```sh
   git clone https://github.com/mekobgs/DadJokesApp.git
   cd dad-jokes-blazor

2. Build and run the application:

   ```sh
   dotnet run

### Usage

  - Open the web application in your browser.
  - Go to Random Jokes Option
  - Click the "Get Random Joke" button to fetch and display a random dad joke.

### Configuration

  The application uses the appsettings.json file for configuration. Modify this file to update the API settings:

  ```json
  {
    "ApiSettings": {
      "X-RapidAPI-Key": "your_api_key",
      "X-RapidAPI-Host": "dad-jokes.p.rapidapi.com",
      "BaseUri": "https://dad-jokes.p.rapidapi.com"
    }
  }

Replace "your_api_key" with your actual RapidAPI key.
