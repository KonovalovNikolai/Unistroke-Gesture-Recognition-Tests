# Unistroke Gesture Recognition Performance Tests

Performance test for Unistroke Gesture Recognition Unity asset. Benchmarking tools and scripts to evaluate recognition speed.

## Requirements

To use the test suite, you need the following:

- Unity Editor (version 2022 or higher)
- **Unistroke Gesture Recognizer** asset installed in your project
- **Performance Testing Extension for Unity Test Runner**

## Getting Started

To import and set up the performance test suite in your Unity project, follow these steps:

Start by downloading the `.unitypackage` file from the [Releases](https://github.com/KonovalovNikolai/Unistroke-Gesture-Recognition-Tests/releases) section of this repository. Once downloaded, open your Unity project and go to `Assets > Import Package > Custom Package...`. Select the downloaded `.unitypackage` file and import all its contents.

Before running the tests, ensure that both the **Unistroke Gesture Recognizer** asset and the **Performance Testing Extension for Unity Test Runner** are installed in your project. If you encounter any assembly reference issues after importing, adjust the references in the `Assembly Definition Asset` of the test suite.

![Assembly Definition Settings](docs/assembly-defenition-reference.png)

Once everything is set up, you can run the tests using the Unity Test Runner. Open the Test Runner window (`Window > General > Test Runner`) and execute tests.

## Running the Tests

The test suite evaluates different aspects of the asset's performance:

The benchmark is designed to measure the execution time of the gesture path recognition method with gesture patterns featuring different parameters, varying numbers of patterns, and varying numbers of points in the path.
