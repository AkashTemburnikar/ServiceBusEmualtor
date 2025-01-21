# ServiceBusEmulator

This repository contains a project for setting up and testing a **Service Bus Emulator** using Docker. The project is built as a **.NET 9 console application** with two functionalities:

1. **Send Message**: Sends a message to the Service Bus queue.
2. **Receive Messages**: Retrieves and processes messages from the Service Bus queue.

---

## Prerequisites

Ensure the following tools are installed:

- **Git**: [Download Git](https://git-scm.com/downloads)
- **Docker Desktop**: [Download Docker Desktop](https://www.docker.com/products/docker-desktop)
- **.NET 9 SDK**: [Download .NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

---

## Getting Started

### Clone the Repository

1. Open your terminal and navigate to your desired directory:
   ```bash
   cd /path/to/your/directory

2. Clone the repository:

git clone https://github.com/AkashTemburnikar/ServiceBusEmulator.git.


3. Navigate to the project directory:

    ```bash
       cd ServiceBusEmulator/ServiceBusEmulatorTest

Install and Verify Docker
1.	Download and install Docker Desktop from here.
2.	Start Docker Desktop and verify the installation:

    ```bash
      docker --version.

If installed correctly, it will display the Docker version.

Run the Project with Docker
1.	Ensure Docker Desktop is running.
2.	Navigate to the project directory containing the docker-compose.yaml file:

    ```bash
   cd /path/to/ServiceBusEmulator/ServiceBusEmulatorTest


3. Start the services:

   ```bash
      docker-compose up

This will pull the required Docker images, build the project, and start the containers.

4. Verify the services:
	•	Open Docker Desktop to confirm the containers are running.
	•	Check the terminal logs for any errors.

5. Stop the services when done:

   ```bash
      docker-compose down

Testing the Console Application
1.	Run the Application:
Execute the application in your terminal:

dotnet run


2.	Choose an Option:
	•	Option 1: Send a message to the Service Bus queue.
	   •	Enter the message content when prompted.
	   •	The application will confirm the message was sent successfully.
	•	Option 2: Receive messages from the Service Bus queue.
	   •	The application will fetch up to 10 messages and display their content.
	   •	Messages will be removed from the queue after being processed.

Official Documentation

For more details, refer to the following official resources:

•	Overview of Service Bus Emulator:
https://learn.microsoft.com/en-us/azure/service-bus-messaging/overview-emulator
•	Testing Locally with Service Bus Emulator:
https://learn.microsoft.com/en-us/azure/service-bus-messaging/test-locally-with-service-bus-emulator?tabs=automated-script