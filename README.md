# Mario Game in Unity with SOLID Principles

This is a Mario game built in Unity using C# and adhering to SOLID principles for better code maintainability and flexibility. The project is organized into several folders, each serving a specific purpose.

## Project Structure

### 1. Interfaces Folder

Contains interfaces defining the contracts for various game components:

- **IBullet**: Interface for defining bullet behavior.
- **ICharacter**: Interface for character behavior.
- **ICollectible**: Interface for collectible items.
- **IWeapon**: Interface for weapon behavior.

### 2. Concretes Folder

Houses concrete implementations and abstract classes:

- **SC_Concrete_Bullets**: Implements `IBullet` with bullet behavior.
- **SC_ConcreteCharacter**: Abstract class implementing `ICharacter` providing a base for character-related functionality.
- **SC_ConcreteCollectible**: Implements `ICollectible` defining collectible behavior.
- **SC_ConcreteCollectibleManager**: Manages interactions between collectibles, weapons, and the UI Canvas.
- **SC_ConcreteDeadPlatform**: Implements logic for platforms causing character death.
- **SC_ConcreteWeapon**: Implements `IWeapon` with weapon behavior.

### 3. Implementations Folder

Contains specific implementations for game objects:

- **SC_Enemy**: Extends `SC_ConcreteCharacter` to represent enemy characters with weapon capabilities.

### 4. Managers Folder

Includes scripts managing different aspects of the game:

- **CollectiblesManagers Folder**: Houses managers for each collectible type, extending `SC_ConcreteCollectableManager<T>`.
- **General Managers**: Other scripts managing broader aspects of the game.

## SOLID Principles Adherence

1. **Single Responsibility Principle (SRP)**: Each class has a single responsibility, promoting maintainability.
2. **Open/Closed Principle (OCP)**: The system is open for extension but closed for modification, facilitating future updates.
3. **Liskov Substitution Principle (LSP)**: Derived classes can be substituted for their base classes, enhancing flexibility and modularity.

## Getting Started

To get started with the game, clone this repository and open it in Unity. Ensure you have Unity installed, and then run the project to start playing.

## Contributors

- [Your Name]

## License

This project is licensed under the [MIT License](LICENSE). Feel free to use and modify it according to your needs.

For more details on each component and how they contribute to the game, please refer to the respective folders and scripts in the repository.

**Enjoy playing Mario in Unity with SOLID principles!**
