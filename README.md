# Dementia Notification App - .NET MAUI

A cross‑platform **.NET MAUI** application designed to provide **simple reminders** and **essential information** to assist individuals living with dementia and their caregivers.  
This project integrates key **Human–Computer Interaction (HCI)** principles to ensure the interface is calm, clear, and accessible for users with cognitive and visual challenges.


## Overview
The Dementia Notification App is a user‑centred tool that enhances the independence and daily functioning of individuals with dementia while reducing the burden on caregivers. It offers:

- **Daily Reminders** for medication, appointments, and activities
- **Information Page** for storing emergency and contact details
- **Help Page** for quick access to support and reassurance

Developed using findings from the dissertation *Human‑Computer Interaction in Dementia Care: Developing a Dementia Reminder Application*, this app combines ethical data handling, HCI best practice, and accessible interaction design.


## Key Principles from the Research
- **Human‑Computer Interaction (HCI):** Simplified navigation, large buttons, high contrast colours (purple/yellow), and friendly tone to enhance readability and confidence.
- **Accessibility:** Clear sans‑serif fonts, large text sizes, calm colour palettes (green and blue), and consistent layout.
- **Ethical & Legal Compliance:** Data protection aligned with the **Data Protection Act (2018)** and guidance from dementia care organisations to protect user privacy.
- **User‑Centred Design:** Developed and refined through focus groups with carers and healthcare professionals to ensure real‑world usability.


## Project Structure
```
.
├── DementiaNotificationApp.sln                  # Solution
├── DementiaNotificationApp.csproj               # Project file
├── App.xaml                                     # Global resources, colour themes
├── App.xaml.cs                                  # App lifecycle
├── AppShell.xaml                                # Navigation structure
├── MainPage.xaml                                # Home page (reminders hub)
├── InfoPage.xaml                                # Key user & carer information
├── HelpPage.xaml                                # Emergency assistance & reassurance
├── Platforms/                                   # iOS / Android / Windows / MacCatalyst
└── Resources/                                   # Fonts, images, icons, audio alerts
```


## Features
- Simple **Home screen** with clearly listed daily tasks
- Visual **notifications** and optional audio alerts for reminders
- **Password‑protected info page** for storing private user data
- **Emergency Help page** simulating caregiver contact
- Consistent **confirmation prompts** to avoid accidental actions

Planned enhancements:
- Persistent storage for reminders (SQLite)
- Secure caregiver login & quick call/SMS feature
- Theming for **high contrast** or **large type** display modes


## How to Use the Application

### 1. Launching the App
After installation or deployment, open the Dementia Notification App on your device. You will be taken to the **Home screen**, which displays your daily reminders (e.g., “Take medication at 9:00 AM”).

### 2. Managing Daily Tasks
- View your list of reminders on the **Home page**.
- When a task is complete, tap the **Done** button.
- A confirmation popup appears — select **Yes** to mark it completed or **No** to cancel.
- Completed tasks are removed from the list to keep the interface clear.

### 3. Receiving Notifications
- The app will trigger reminder notifications at preset times.
- Tap **OK** when you receive a notification to acknowledge it.

### 4. Using the Information Page
- Tap **Info** on the Home screen.
- Enter or update personal details (e.g., name, address, carer phone number).
- Press **Save** — you will be asked for a password to confirm changes.
- The app will show a confirmation message if information is successfully saved.

### 5. Accessing Help
- Tap the **Help** button on the Home screen (or from Info page) to simulate contacting a caregiver.
- A message such as “Help is on the way” appears for reassurance.

### 6. Accessibility Tips
- Use device settings for text enlargement or screen readers if needed.
- Maintain sufficient screen brightness for visibility.
- Caregivers may assist with setup, especially during first‑time configuration.


## Testing Summary
Testing was conducted using Visual Studio and emulators for Windows and Android. 
All major navigation paths and reminder functions passed successfully after debugging. User feedback from **11 caregivers and healthcare professionals** highlighted the app’s:

✅ Ease of use and visual simplicity  
✅ Helpful daily reminder system  
⚙️ Suggested improvements in data security and persistent storage  

Overall satisfaction was high, and over half of participants said they would download or recommend the app in its current form.


## Development Tools
- **Language:** C#  
- **Framework:** .NET MAUI  
- **IDE:** Visual Studio 2022  
- **Testing:** Windows Emulator & Android Simulator


## How to Build & Run

### Prerequisites
- **.NET 8 SDK** (or 7)
- **MAUI workloads** installed via terminal:

```bash
dotnet workload install maui
```

### Clone and Build
```bash
git clone https://github.com/c-cannon13/DementiaNotificationApp.git
cd DementiaNotificationApp
dotnet build
```

### Run the App
```bash
dotnet maui run -t windows
# or
# dotnet maui run -t android
```

Ensure an emulator or connected device is available for deployment.


## Future Development
- Enable **automatic cloud backup** of reminders
- Add **voice‑activated commands** (for accessibility)
- Integrate **caregiver dashboard** for remote oversight
- Expand **multi‑language support**
- Refine data encryption & authentication systems


## Author
**Charlotte Cannon**  
BSc (Hons) Software Engineering — University of Winchester  
Graduate Software Engineer  
- [LinkedIn](https://www.linkedin.com/in/charlotte-cannon-165875195/)  
- [GitHub](https://github.com/c-cannon13)


## License
This project is provided for educational and portfolio demonstration purposes.  
© 2024 Charlotte Cannon. All rights reserved.

