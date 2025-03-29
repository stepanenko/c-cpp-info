#include <iostream>
#include <string>
#include <boost/asio.hpp>
#include <boost/json.hpp>

using boost::asio::ip::tcp;

// Function to handle a client connection
void handle_client(tcp::socket socket) {
    try {
        // Read the request
        boost::asio::streambuf buffer;
        boost::asio::read_until(socket, buffer, "\r\n");
        std::string request = boost::asio::buffer_cast<const char*>(buffer.data());
        
        // Extract endpoint (simplified parsing)
        std::string endpoint = "/";
        size_t start = request.find("GET ");
        if (start != std::string::npos) {
            size_t end = request.find(" ", start + 4);
            if (end != std::string::npos) {
                endpoint = request.substr(start + 4, end - (start + 4));
            }
        }
        std::cout << "Request for: " << endpoint << std::endl;
        
        // Generate response
        std::string response;
        if (endpoint == "/top-languages") {
            boost::json::array languages = {"Python", "Java", "JavaScript", "C#", "C++"};
            response = boost::json::serialize(languages) + "\r\n";
        } else {
            response = "Hello from C++ server!\r\n";
        }
        
        // Send response and close
        boost::asio::write(socket, boost::asio::buffer(response));
        socket.close();
    } catch (const std::exception& e) {
        std::cerr << "Error: " << e.what() << std::endl;
    }
}

int main() {
    try {
        boost::asio::io_context io_context;
        tcp::acceptor acceptor(io_context, tcp::endpoint(tcp::v4(), 8080));
        std::cout << "Server listening on port 8080..." << std::endl;
        
        while (true) {
            tcp::socket socket(io_context);
            acceptor.accept(socket);
            std::cout << "Client connected." << std::endl;
            handle_client(std::move(socket));
        }
    } catch (const std::exception& e) {
        std::cerr << "Error: " << e.what() << std::endl;
        return 1;
    }
    
    return 0;
}
