Here’s the complete markdown for your GitHub README.md file:

# ServiceBusEmulator

This repository contains a project for setting up and testing a **Service Bus Emulator** using Docker. The project is built as a **.NET 9 console application** with two endpoints:

1. **Send Message Endpoint**: Sends a message to the Service Bus queue.
2. **Receive Message Endpoint**: Retrieves and processes messages from the Service Bus queue.

---

## Prerequisites

Before you start, ensure you have the following installed:

- **Git**: For cloning the repository.
- **Docker Desktop**: For running the emulator as a Docker container.
- **.NET 9 SDK**: To run the console application.

---

## Getting Started

Follow these steps to clone the repository, install Docker Desktop, and run the project.

### Clone the Repository

1. Open your terminal or command prompt.
2. Navigate to the directory where you want to clone the repository:

   ```bash
   cd /path/to/your/directory

	3.	Clone the repository:

git clone https://github.com/AkashTemburnikar/ServiceBusEmualtor.git


	4.	Navigate to the project directory:

cd ServiceBusEmualtor/ServiceBusEmualtorTest

Install Docker Desktop

Docker Desktop is required to run the emulator as a Docker container.
1.	Download Docker Desktop:
•	Visit the Docker Desktop Downloads Page.
•	Download the appropriate version for your operating system (Windows, macOS, or Linux).
2.	Install Docker Desktop:
•	Run the downloaded installer and follow the on-screen instructions.
3.	Start Docker Desktop:
•	Open Docker Desktop and ensure it is running.
•	Verify the installation by running this command in your terminal:

docker --version


	•	If Docker is installed, you will see the version number.

Run the Project with Docker

The project includes a compose.yaml file to set up the required services.
1.	Ensure Docker Desktop is running.
2.	Navigate to the project directory containing the compose.yaml file:

cd /path/to/ServiceBusEmualtor/ServiceBusEmualtorTest


	3.	Start the services by running the following command:

docker-compose up

This command will:
•	Pull the required Docker images (if not already present locally).
•	Build and start the containers defined in the compose.yaml file.

	4.	Verify the services:
	•	Open Docker Desktop to confirm the containers are running.
	•	Check the terminal logs to ensure there are no errors.

Stop the Services

To stop the running containers, use the following command:

docker-compose down

This command will stop and remove the containers but retain the Docker images for future use.

Testing the .NET 9 Console Application
1.	Send Message to Service Bus:
•	Use the console application to send a message to the Service Bus queue.
•	Follow the prompts provided by the application or edit the code to specify the message details.
2.	Receive Message from Service Bus:
•	Run the console application’s receive message endpoint to retrieve messages from the queue.
•	The messages will be displayed in the console.

Official Documentation

For more details on the Service Bus Emulator, refer to the official documentation:

•	Overview of Service Bus Emulator:
https://learn.microsoft.com/en-us/azure/service-bus-messaging/overview-emulator

•	How to Test Locally with Service Bus Emulator:
https://learn.microsoft.com/en-us/azure/service-bus-messaging/test-locally-with-service-bus-emulator?tabs=automated-script
