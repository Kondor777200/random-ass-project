# **Color format converter - SRS**
## introduction
### Purpose
visit readme
### Intended Use
You have a config file, with themes, and other characters. This program will identify any colors in any color model present in the file, and return an object with all of these colors in various formats to stdout.
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
### NRQ1
- Color highlighting in terminal
### NRQ2 optional
- simple tui for the program, used for interactive dialogs