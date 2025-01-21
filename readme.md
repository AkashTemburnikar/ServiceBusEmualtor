# **ServiceBusEmulator**

This repository provides a project to set up and test a Service Bus Emulator using Docker. It is built as a .NET 9 console application with the following features:
- **Send Messages**: Send a message to the Service Bus queue.
- **Receive Messages**: Retrieve and process messages from the Service Bus queue.

---

## **Prerequisites**

Make sure you have the following tools installed:
- [Git](https://git-scm.com/)
- [Docker Desktop](https://www.docker.com/products/docker-desktop)
- [.NET 9 SDK](https://dotnet.microsoft.com/)

---

## **Getting Started**

### **1. Clone the Repository**

1. Open your terminal and navigate to your desired directory:
   ```bash
   cd /path/to/your/directory
   ```

2. Clone the repository:
   ```bash
   git clone https://github.com/AkashTemburnikar/ServiceBusEmulator.git
   ```

3. Navigate into the project folder:
   ```bash
   cd ServiceBusEmulator/ServiceBusEmulatorTest
   ```

---

### **2. Install and Verify Docker**

1. Download and install Docker Desktop from the [official page](https://www.docker.com/products/docker-desktop).

2. Start Docker Desktop and verify the installation by running:
   ```bash
   docker --version
   ```

---

### **3. Running the Project with Docker**

1. Ensure Docker Desktop is running.

2. Navigate to the directory containing the `docker-compose.yaml` file:
   ```bash
   cd /path/to/ServiceBusEmulator/ServiceBusEmulatorTest
   ```

3. Start the Docker services:
   ```bash
   docker-compose up
   ```

4. Verify the services are running:
   - Open Docker Desktop and confirm that the containers are running.
   - Check the terminal logs for any errors.

5. Stop the services when done:
   ```bash
   docker-compose down
   ```

---

### **4. Testing the Console Application**

1. Run the application:
   ```bash
   dotnet run
   ```

2. Choose one of the available options:

#### **Send Messages**
- Enter the message content when prompted.
- The application will confirm that the message was sent successfully.

#### **Receive Messages**
- The application will fetch up to 10 messages from the queue and display their content.
- Messages will be removed from the queue after being processed.

---

## **Official Documentation**

For further details, refer to the official Azure documentation:
- [Overview of Service Bus Emulator](https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-emulator)
- [Testing Locally with Service Bus Emulator](https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-emulator-testing)
