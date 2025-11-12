# Coding-Launcher

> A Windows desktop utility written in C# that launches multiple coding tools and resources simultaneously, so I can start a development session with a single click.

## Table of Contents
- [Project Description](#project-description)
- [Directory Structure](#directory-structure)
- [Tech Stack](#tech-stack)
- [How It Works](#how-it-works)
- [Usage](#usage)
- [Features](#features)
- [Lessons Learned](#lessons-learned)
- [Author](#author)

## Project Description

**Coding-Launcher** is a small Windows Forms application that automates my development setup.  
Instead of manually opening editors, terminals, documentation pages, and other tools one by one, this app launches them for me all at once.

It’s designed as a personal productivity tool for my daily coding workflow, and as practice working with:
- C# and the .NET Windows Forms framework  
- Launching external processes from a GUI  
- Basic desktop UI layout and event handling  



## Directory Structure (so far)

```text
.
├── Form1.cs       # Main Windows Form and launcher logic
└── README.md      # Project documentation

## Tech Stack
	•	Language: C#
	•	Framework: .NET (Windows Forms)
	•	Platform: Windows desktop
```

## How It Works

The main form (Form1) contains buttons (or similar controls) mapped to different tools and resources.
When a button is clicked, the app uses process-launching APIs (for example, System.Diagnostics.Process.Start) to open:
	•	Code editor(s)
	•	Browser tabs for documentation or learning resources
	•	Other utilities used frequently while coding

This turns the “start coding” routine into a single interaction.


## Usage

	1.	Open the project in Visual Studio (or another C# IDE that supports Windows Forms).
	2.	Build the project:
	•	Build → Build Solution
	3.	Run the application:
	•	Debug → Start Debugging or press F5

Once the form is open:
	•	Click the configured button(s) to launch your coding tools and resources.
	•	Paths and URLs can be adjusted in Form1.cs to match your local setup and preferred tools.



## Features
	•	One-click startup: Launch multiple coding tools at once.
	•	Simple UI: Minimal Windows Forms interface focused on productivity.
	•	Configurable: Update Form1.cs to customize which programs and URLs are launched.
	•	Good practice project: Reinforces basic C# event handling and desktop app design.


## Lessons Learned
	•	Gained experience using Windows Forms to build simple GUIs.
	•	Practiced launching external processes and handling file/URL paths in C#.
	•	Learned how to structure a small utility app around my personal development workflow.



## Author

Andrew Henderson
	•	GitHub: Anhender1993￼
	•	Portfolio: Github.com/Anhender1993
	•	LinkedIn: linkedin.com/in/andrew-v-henderson￼
