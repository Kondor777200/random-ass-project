# **Color format converter - SRS**
Version: 1.1
Author: Redacted for personal safety
Date: 9.10.24
## introduction
### Purpose
Help designers, developers, and Linux ricing fanboys convert colors between different color models.
### Intended Use
This program will identify any colors in any color model present in a file, and return an object with all of these colors in various formats to stdout.
## Functional requirements
### FRQ0 !
- machine readable, and reproducible outputs
### FRQ1 !
- fail last - Incomplete output is better than no output deps: RQ2
### FRQ2 @
- No result should be returned based on anything other than input e.g. If a hex value is formattedd wrong, the data should still be returned, but if the input value is incomplete it shouldn't be returned
### FRQ3 @
- Should return a config file, with the color model changed.
## Non functional requirements
### NRQ0
- Termminal autocompletions
- priority: low
### NRQ1
- Color highlighting in terminal
- priority: low
### NRQ2 optional
- simple tui for the program, used for interactive dialogs
- priotity: lowewst
### NRQ3 
- Functional without internet connection
- prority: highest
### NRQ4
- Linux first, not designed for windows, macos or any other system
- priority: highest
### NRQ5
- Nix flake - distribute the software as a nix flake
- priority: high
### NRQ6
- application is tested using alacritty terminal, running zsh
- priority: high
### NRQ7
- No bash, fish suppport - application is designed to be ussed with zsh, and no other shells are officially supported
- priority: highest