Here’s a simplified and complete markdown version for your GitHub README.md file:

# ServiceBusEmulator

This repository contains a project for setting up and testing a **Service Bus Emulator** using Docker. The project is built as a **.NET 9 console application** with two endpoints:

1. **Send Message Endpoint**: Sends a message to the Service Bus queue.
2. **Receive Message Endpoint**: Retrieves and processes messages from the Service Bus queue.

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

	2.	Clone the repository:

git clone https://github.com/AkashTemburnikar/ServiceBusEmualtor.git


	3.	Navigate to the project directory:

cd ServiceBusEmualtor/ServiceBusEmualtorTest

Install Docker Desktop
1.	Download and install Docker Desktop from here.
2.	Start Docker Desktop and verify the installation:

docker --version

If installed, it will display the Docker version.

Run the Project with Docker
1.	Ensure Docker Desktop is running.
2.	Navigate to the project directory containing the compose.yaml file:

cd /path/to/ServiceBusEmualtor/ServiceBusEmualtorTest


	3.	Start the services:

docker-compose up

This will pull the required Docker images, build, and start the containers.

	4.	Verify the services:
	•	Open Docker Desktop to confirm the containers are running.
	•	Check the terminal logs for errors.

Stop the Services

To stop and remove the running containers:

docker-compose down

Testing the .NET 9 Console Application
1.	Send Message to Service Bus:
•	Run the console application to send a message.
•	Follow the prompts or customize the message in the code.
2.	Receive Message from Service Bus:
•	Run the application’s receive endpoint to fetch and display messages.

Official Documentation

•	Overview of Service Bus Emulator:
https://learn.microsoft.com/en-us/azure/service-bus-messaging/overview-emulator

•	Testing Locally with Service Bus Emulator:
https://learn.microsoft.com/en-us/azure/service-bus-messaging/test-locally-with-service-bus-emulator?tabs=automated-script
