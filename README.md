# Old Phone Pad Decoder

This application simulates typing on a classic phone keypad.

## Features
- Translates numeric input to letters (e.g., "44 33 555" -> "HEL")
- Handles special characters:
  - "*" to reduce keypress count
  - "#" to cancel input

## How to Run
1. Open the solution in Visual Studio.
2. Set `OldPhonePadApp` as the startup project.
3. Run the project and input numeric strings to see the decoded result.

## Running Tests
- Use Test Explorer (Ctrl+E, T) to run all tests.
- Ensure `xUnit` is installed.

## Example
Input: 4433555 555666096667775553
Output: HELLO WORLD
