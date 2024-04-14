# ShArpChat.Gui
A MAUI GUI frontend for [ShArpChat](https://github.com/NathanielJS1541/ShArpChat).

## Related Projects
- [arpchat](https://github.com/kognise/arpchat), the main inspiration for this project.
- [ShArpChat](https://github.com/NathanielJS1541/ShArpChat), the C# library that handles sending messages over the ARP protocol.
- Possibly a TUI coming soon?

## Repository Structure
```
ShArpChat.Gui/                   - Main repository folder
├── docs/                        - Application documentation
│   └── api/                     - API documentation
├── src/
│   ├── ShArpChat.Gui/           - ShArpChat MAUI App root folder
│   │   ├── Platforms/           - Platform specific code
│   │   │   ├── Android/
│   │   │   ├── iOS/
│   │   │   ├── MacCatalyst/
│   │   │   └── Windows/
│   │   └── ShArpChat.Gui.csproj - ShArpChat MAUI app project file
│   └── ShArpChat.Gui.sln        - Main library solution file
├── tests/                       - App unit tests
└── utils/                       - Utility scripts
```

## Notes
### Platform Compatability
While I will do my best to keep the library and app as cross-platform as possible, Apple's toolchain restrictions effectively mean I won't be able to build the app at all for iOS / MacCatalyst. Therefore I will not be able to do any testing for Apple's platforms. If you'd like those platforms to work you can fix them and PR the work yourself if you have the hardware for it :).