# Valetudo MCP - LLM Control for Robot Vacuums

Valetudo MCP is a specialized server that enables Large Language Models (LLMs) to control your Valetudo-powered robot vacuum. This project bridges the gap between conversational AI and smart home automation, allowing AI assistants to perform vacuum operations through natural language commands.

## Features

- **LLM-Powered Vacuum Control**: Enable AI models to control your robot vacuum through a clean API interface
- **Valetudo Integration**: Works seamlessly with [Valetudo](https://github.com/Hypfer/Valetudo), the cloud-free control software for robot vacuums
- **Multiple Operation Modes**: Run in stdio mode for direct LLM integration or HTTP/SSE mode for web-based access


## Usage Modes

### Stdio Mode (for Claude Desktop, Anything-LLM, etc.)

Perfect for direct integration with LLM applications. Example configuration:

```json
{
  "mcpServers": {
    "vacuum-robot": {
      "command": "docker",
      "args": [
        "run",
        "-i",
        "--rm",
        "-e",
        "ValetudoMcp__RobotUri",
        "-e",
        "ValetudoMcp__ServerType",
        "nihfix/valetudo.mcp",
        "--access-mode=unrestricted"
      ],
      "env": {
        "ValetudoMcp__RobotUri": "http://192.168.1.12", // your robot url
        "ValetudoMcp__ServerType": "Stdio"
      }
    }
  }
}
```


### HTTP/SSE Mode (for Web Integrations such as n8n)

Run as a standalone server that exposes endpoints for HTTP and Server-Sent Events:

```bash
docker run -i --rm \
  -e ValetudoMcp__RobotUri="http://192.168.1.12" \
  -e ValetudoMcp__ServerType=http \
  -p 3005:8080 \
  nihfix/valetudo.mcp
```

- SSE endpoint: `http://localhost:3005/sse`
- Streamable protocol endpoint: `http://localhost:3005/`


## Configuration

| Environment Variable | Description |
| :-- | :-- |
| `ValetudoMcp__RobotUri` | URL of your Valetudo-powered robot (required) |
| `ValetudoMcp__ServerType` | Server mode: "Stdio" or "http" |
| `ValetudoMcp__Username` | Username for robot auth (if required) |
| `ValetudoMcp__Password` | Password for robot auth (if required) |

## Available Tools

The server provides a rich set of tools for vacuum control:


| Tool Name | Description |
| :-- | :-- |
| `get-map-segments` | Get available zones for the vacuum robot to clean. Returns a list of segments with names and corresponding IDs. |
| `clean-map-segments` | Enforce vacuum robot to clean defined segments. Requires segment IDs which can be obtained via the get-map-segments tool. |
| `clean-all` | Enforce vacuum robot to clean the entire map (flat, apartment or house) or resume current cleaning. |
| `stop-cleaning` | Enforce vacuum robot to stop its current cleaning operation. |
| `pause-cleaning` | Enforce vacuum robot to pause its current cleaning operation. |
| `go-home` | Enforce vacuum robot to return to its charging station. If you encounter errors, try using stop-cleaning first. |

These tools allow LLMs to perform precise control over your robot vacuum, enabling sophisticated automation and voice-controlled cleaning scenarios.

Experience the next level of smart home automation by connecting your AI assistants directly to your robot vacuum!

