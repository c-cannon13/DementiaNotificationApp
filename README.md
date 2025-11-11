Dementia Notification App

A cross‑platform .NET MAUI app (C#) aiming to provide simple, glanceable reminders and helpful info for people living with dementia and their carers.

Status: early scaffold. Navigation and pages exist; notifications and data storage are WIP.

Overview

This project targets a clean, calm interface with large touch targets and minimal cognitive load. The initial version focuses on:

A Home screen for today’s reminders

An Info page for key details (e.g., name, address, emergency contact)

A Help page with quick access to support information

As the project grows, the goal is to support scheduled local notifications (e.g., medication times), recurring routines, and optional caregiver prompts.

Project Structure
.
├── App.xaml                     # Global resources, styles
├── App.xaml.cs                  # Application lifecycle
├── AppShell.xaml                # Shell navigation & routes
├── AppShell.xaml.cs
├── MainPage.xaml                # Home page (reminders hub)
├── MainPage.xaml.cs
├── InfoPage.xaml                # Key info screen
├── InfoPage.xaml.cs
├── HelpPage.xaml                # Help/support screen
├── HelpPage.xaml.cs
├── Platforms/                   # iOS / Android / MacCatalyst / Windows heads
├── Properties/                  # MAUI configuration
├── Resources/                   # Fonts, images, raw assets
├── DementiaNotificationApp.csproj
└── DementiaNotificationApp.sln
Features (current)

Shell‑based navigation between Home → Info → Help

Accessible default theming via App.xaml

Cross‑platform layout using standard MAUI controls

Roadmap (next)

Local scheduled notifications (e.g., medication reminders)

Persistent storage for reminders (Preferences/SQLite)

Caregiver contact card with one‑tap call/text

Large‑type mode & high‑contrast theme toggle

Basic onboarding (name, routine times)

Getting Started
Prerequisites

.NET SDK 8.0 (or 7.0) installed

.NET MAUI workloads for your target platform(s)

Install workloads (example):

# Android + iOS + MacCatalyst + Windows
dotnet workload install maui
Clone & Run
git clone https://github.com/c-cannon13/DementiaNotificationApp.git
cd DementiaNotificationApp


# Build
dotnet build


# Run (choose one)
dotnet maui run -t android
# dotnet maui run -t windows
# dotnet maui run -t ios
# dotnet maui run -t maccatalyst

If you’re new to MAUI on a platform (e.g., iOS), ensure your local environment is provisioned (Xcode, emulators, signing, etc.).

Configuration

App styles & resources: App.xaml

Shell routes/menu: AppShell.xaml

Platform permissions (for notifications) will be configured under Platforms/* when notifications are added.

Contributing

Fork the repo

Create a feature branch: git checkout -b feature/your-idea

Commit changes: git commit -m "Add feature"

Push and open a PR

Ideas, bugs, or accessibility suggestions are very welcome.

Accessibility Principles

High contrast, large hit‑areas, and clear hierarchy

Minimal text per screen; icons with labels

Consistent placement for primary actions

License

This project is provided for educational and portfolio demonstration purposes.

Author

Charlotte Cannon — Graduate Software Engineer

GitHub: https://github.com/c-cannon13

LinkedIn: https://www.linkedin.com/in/charlotte-cannon-165875195/