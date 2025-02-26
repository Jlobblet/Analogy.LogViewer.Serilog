# Analogy LogViewer Serilog Extensions  [![Nuget](https://img.shields.io/nuget/dt/Analogy.LogViewer.Serilog)](https://www.nuget.org/packages/Analogy.LogViewer.Serilog/) <img src="./Assets/AnalogySerilog.png" align="right" width="155px" height="155px">

<p align="center">

![CodeQL](https://github.com/Analogy-LogViewer/Analogy.LogViewer.Serilog/workflows/CodeQL/badge.svg) ![.NET Core Desktop](https://github.com/Analogy-LogViewer/Analogy.LogViewer.Serilog/workflows/.NET%20Core%20Desktop/badge.svg)
<a href="https://github.com/Analogy-LogViewer/Analogy.LogViewer.Serilog/issues">
    <img src="https://img.shields.io/github/issues/Analogy-LogViewer/Analogy.LogViewer.Serilog"  alt="Issues" />
</a>
![GitHub closed issues](https://img.shields.io/github/issues-closed-raw/Analogy-LogViewer/Analogy.LogViewer.Serilog)
<a href="https://github.com/Analogy-LogViewer/Analogy.LogViewer.Serilog/blob/master/LICENSE.md">
    <img src="https://img.shields.io/github/license/Analogy-LogViewer/Analogy.LogViewer.Serilog" img alt="License"/>
</a>
 [![Nuget](https://img.shields.io/nuget/v/Analogy.LogViewer.Serilog)](https://www.nuget.org/packages/Analogy.LogViewer.Serilog/)
<a href="https://github.com/Analogy-LogViewer/Analogy.LogViewer.Serilog/releases">
    <img src="https://img.shields.io/github/v/release/Analogy-LogViewer/Analogy.LogViewer.Serilog" img alt="Latest Release"/>
</a>
<a href="https://github.com/Analogy-LogViewer/Analogy.LogViewer.Serilog/compare/V2.1.0...master">
    <img src="https://img.shields.io/github/commits-since/Analogy-LogViewer/Analogy.LogViewer.Serilog/latest" img alt="Commits Since Latest Release"/>
</a>
</p>

Serilog Parser for Analogy Log Viewer.
| Nuget   |      Version      |  Description |
|----------|:-------------:|------|
| [Analogy.LogViewer.Serilog](https://www.nuget.org/packages/Analogy.LogViewer.Serilog/) |   [![Nuget](https://img.shields.io/nuget/v/Analogy.LogViewer.Serilog)](https://www.nuget.org/packages/Analogy.LogViewer.Serilog) | Serilog Extension for Analogy Log viewer (this package) |
| [Analogy.LogViewer.Serilog.Sinks](https://www.nuget.org/packages/Analogy.LogViewer.Serilog.Sinks/) |   [![Nuget](https://img.shields.io/nuget/v/Analogy.LogViewer.Serilog.Sinks)](https://www.nuget.org/packages/Analogy.LogViewer.Serilog.Sinks) | Serilog Sink for sending logs to Analogy Log server |

Supported formatters, for now, are:

1. [Compact formatting](https://github.com/Analogy-LogViewer/Analogy.LogViewer.Serilog#Compact-formatting)
2. [Regular Expression Parser](https://github.com/Analogy-LogViewer/Analogy.LogViewer.Serilog#regular-expression-parser)
3. [Real Time Sink](https://github.com/Analogy-LogViewer/Analogy.LogViewer.Serilog#Real-Time-Sink)

#### Compact formatting
[Compact formatting](https://github.com/serilog/serilog-formatting-compact). The initial version is based on [this project](https://github.com/serilog/serilog-formatting-compact-reader)

   example log:
   ```json
   {"@t":"2016-10-12T04:46:58.0554314Z","@mt":"Hello, {@User}","User":{"Name":"nblumhardt","Id":101}}
   {"@t":"2016-10-12T04:46:58.0684369Z","@mt":"Number {N:x8}","@r":["0000002a"],"N":42}
   {"@t":"2016-10-12T04:46:58.0724384Z","@mt":"Tags are {Tags}","@l":"Warning","Tags":["test","orange"]}
   {"@t":"2016-10-12T04:46:58.0904378Z","@mt":"Something failed","@l":"Error", "@x":"System.DivideByZer...<snip>"}
   ```
![Main screen](Assets/CompactFormat.jpg)

#### Regular Expression Parser
Regular Expression Parser: in this mode you need to define your custom regex to match you log format in the applcation settings.

![Serilog Settings](Assets/SerilogRegularExpression.jpg)

for example, with the above regex: in the screenshot this example log can be parsed:
```
$2020-04-24 13:18:23,207|1|INFO|logsource|My Manager App Starting...
$2020-04-24 13:28:24,380|1|WARN|files|file not found
$2020-04-24 13:48:27,193|2|INFO|AppBase|Loading done
   ```
 
![Serilog Settings](Assets/serilogParserExample.jpg)

the available tags to use for parsing are:

   ```csharp
   public enum AnalogyLogMessagePropertyName
  {
    Date,
    ID,
    Text,
    Category,
    Source,
    Module,
    MethodName,
    FileName,
    User,
    LineNumber,
    ProcessId,
    ThreadId,
    Level,
    Class,
    MachineName,
  }
 ```
which corresponding to AnalogyLogMessage fields. Saying that, a dynamic way to read properties is to populate the AddtionalInformation property to show new columns at run time like the following image:
![Dynamics Columns](Assets/DynamicsColumns.jpg)


#### Real Time Sink

There is a windows GRPC Service for Sending log messages at https://github.com/Analogy-LogViewer/Analogy.LogViewer.gRPC.
Analogy Log Viewer can read back those messages using the following custom Serilog Sink.


The following modules exists:
| Nuget   |      Version      |  Description |
|----------|:-------------:|------|
| [Analogy.LogViewer.gRPC](https://www.nuget.org/packages/Analogy.LogViewer.gRPC/) |   [![Nuget](https://img.shields.io/nuget/v/Analogy.LogViewer.gRPC)](https://www.nuget.org/packages/Analogy.LogViewer.gRPC/) | Primary Analogy Log Viewer grRPC providers |
| [Analogy.LogServer](https://www.nuget.org/packages/Analogy.LogServer/) |   [![Nuget](https://img.shields.io/nuget/v/Analogy.LogServer)](https://www.nuget.org/packages/Analogy.LogServer/) | A windows Service for receiving logs |
| [Analogy.LogServer.Clients](https://www.nuget.org/packages/Analogy.LogServer.Clients/) |   [![Nuget](https://img.shields.io/nuget/v/Analogy.LogServer.Clients)](https://www.nuget.org/packages/Analogy.LogServer.Clients) | gRPC client to pull back messages from Analogy Service |
| [Analogy.LogViewer.Serilog.Sinks](https://www.nuget.org/packages/Analogy.LogViewer.Serilog.Sinks/) |   [![Nuget](https://img.shields.io/nuget/v/Analogy.LogViewer.Serilog.Sinks)](https://www.nuget.org/packages/Analogy.LogViewer.Serilog.Sinks) | Serilog Sink for sending logs to Analogy Log server |

 
## Issues
- Windows 10 Blocks Zip files by default. Make sure to [unblocked](https://singularlabs.com/tips/how-to-unblock-a-zip-file-on-windows-10/) before unzipping the files.


## How To Use
1. Download the latest [Analogy Log Viewer](https://github.com/Analogy-LogViewer/Analogy.LogViewer) from the [release](https://github.com/Analogy-LogViewer/Analogy.LogViewer/releases) section (.net framework or .net Core version).
2. Download (or Compile) this project and put the compiled DLL in the same folder as the Analogy Log Viewer.
