# Unique PIN Code Generator

This project implements a unique PIN code generator based on the concept of the Shepard tone. The Shepard tone is an auditory illusion that creates the sensation of a continuously ascending pitch, which can be translated into a visual representation of unique codes. This generator produces PIN codes of a specified length, ensuring that the codes are unique within a defined period.

## Features

- Generates unique PIN codes of a specified length.
- Based on the mathematical principles of the Shepard tone.
- Ensures that generated codes do not repeat within a defined period.
- Easy to customize the length of the PIN codes and the uniqueness period.

## Getting Started

### Prerequisites

- .NET SDK (version 5.0 or later) installed on your machine.

### Installation

1. Clone the repository

2. Open the project in your preferred IDE (e.g., Visual Studio, Visual Studio Code).

3. Build the project to restore dependencies.

### Usage

1. Open the `Program.cs` file.
2. Modify the `period` and `codeLength` variables in the `Main` method to set the desired uniqueness period and length of the PIN codes.
3. Run the program. The generated PIN codes will be displayed in the console.

### Example

```csharp
int period = 10; // Number of unique codes before reset
int codeLength = 8; // Length of the PIN code
PinCodeGenerator generator = new PinCodeGenerator(period, codeLength);

for (int i = 0; i < 20; i++)
{
    string pinCode = generator.GeneratePinCode(i);
    Console.WriteLine($"Generated PIN code for x={i}: {pinCode}");
}
```

## How It Works

The generator uses a series of sine functions to create a unique numerical representation for each PIN code. The values are rounded and constrained to the range of 0-9 to form digits. The resulting PIN codes are unique within the specified period, ensuring that users receive distinct codes for verification purposes.

## Contributing

Contributions are welcome! If you have suggestions for improvements or new features, please open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Inspired by the concept of the Shepard tone, which creates an auditory illusion of continuously ascending pitch.
