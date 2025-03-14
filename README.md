# Game Settings Manager

## ?? Description
A modular game settings system for Unity, built with **ScriptableObjects** and **PlayerPrefs**. It allows managing audio, screen, language, and other settings with persistent storage and easy integration into any project.

This module was created for the base projects of **Indie Level Studio**.

## ?? Features
- Modular and extensible settings management.
- Uses **ScriptableObjects** and **PlayerPrefs** for saving configurations.
- Supports multiple setting types (audio, screen, language, etc.).
- Custom UI controllers for handling settings views.
- Hotkey support for opening/closing settings.
- Uses **Localization de Unity, DoTween, TextMeshPro (TMP Text), and Unity 6 Input System**.

## ?? Prefabs for Easy Setup
Prefabs have been created to simplify integration. Just drag and drop them into the scene and customize them according to your artistic and organizational needs.

## ??? Setup
### 1?? Import the Package
Clone or download the repository and add it to your Unity project.

### 2??  Attach the `Canvas-Settings` prefab

### 3?? Configure Hotkey
By default, the settings menu opens with `Esc`. You can change this in the Inspector under `openKey`.

## ?? Usage
- Call `SettingsManager.Initialize()` at the start of your game.
- Press the assigned hotkey to open/close the settings menu.
- Customize available settings by modifying `SettingsControllers` in the Unity Inspector.
- Use `AudioSettingsController` to handle audio settings interactions.

## ?? License
This project is licensed under the MIT License.

