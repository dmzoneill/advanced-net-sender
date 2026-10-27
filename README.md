# Advanced Net Sender

A Windows Forms tool for sending network messages to other computers,
with a German-language interface.

## What it does

- Sends a message (**Nachricht**) to a computer from a configurable
  sender name, using the `NetMessageBufferSend` Windows API.
- Can repeat the message a set number of times (**Anzahl**).
- Optionally shows a notification when a message has been sent
  (**Benachrichtigung**).
- Stores the list of target computers in the registry and lets you edit
  it from an **Optionen** dialog.

`NetMessageBufferSend` relies on the Windows Messenger service, which
was removed in Windows Vista, so the tool only works on older Windows
versions.

## Tech

- Visual Basic .NET (Windows Forms)
- Win32 `netapi32` and `Microsoft.Win32.Registry`

## Building

Open the `.sln` file in Visual Studio and build it. The project was
upgraded to the Visual Studio 2005 format (.NET Framework 2.0) and targets
Windows only.

The solution file is `Advanced Net Sender.sln`.

## License

Licensed under the Apache License 2.0. See [LICENSE](LICENSE).
