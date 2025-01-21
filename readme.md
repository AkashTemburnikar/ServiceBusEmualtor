ServiceBusEmulator

This repository contains a project for setting up and testing a Service Bus Emulator using Docker. The project is built as a .NET 9 console application with two functionalities:
1.	Send Message: Sends a message to the Service Bus queue.
2.	Receive Messages: Retrieves and processes messages from the Service Bus queue.

Prerequisites

Ensure the following tools are installed:
•	Git: Download Git
•	Docker Desktop: Download Docker Desktop
•	.NET 9 SDK: Download .NET 9 SDK

Getting Started

Clone the Repository
1.	Open your terminal and navigate to your desired directory:

cd /path/to/your/directory


2.	Clone the repository:

git clone https://github.com/AkashTemburnikar/ServiceBusEmulator.git


3.	Navigate to the project directory:

cd ServiceBusEmulator/ServiceBusEmulatorTest

Install and Verify Docker
1.	Download and install Docker Desktop from here.
2.	Start Docker Desktop and verify the installation:

docker --version

Run the Project with Docker
1.	Ensure Docker Desktop is running.
2.	Navigate to the project directory containing the docker-compose.yaml file:

cd /path/to/ServiceBusEmulator/ServiceBusEmulatorTest


3.	Start the services:

docker-compose up


4.	Verify the services:
	•	Open Docker Desktop to confirm the containers are running.
	•	Check the terminal logs for any errors.
Stop the services when done:

docker-compose down

Testing the Console Application
1.	Run the application:

dotnet run


2.	Choose an option:
	•	Option 1: Send a message to the Service Bus queue.
	•	Enter the message content when prompted.
	•	The application will confirm the message was sent successfully.
	•	Option 2: Receive messages from the Service Bus queue.
	•	The application will fetch up to 10 messages and display their content.
	•	Messages will be removed from the queue after being processed.

Official Documentation
•	Overview of Service Bus Emulator:
https://learn.microsoft.com/en-us/azure/service-bus-messaging/overview-emulator
•	Testing Locally with Service Bus Emulator:
https://learn.microsoft.com/en-us/azure/service-bus-messaging/test-locally-with-service-bus-emulator?tabs=automated-script
