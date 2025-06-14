# Vectra.AST

A C# .NET 9.0 library for Abstract Syntax Tree (AST) manipulation and traversal.

## Overview

Vectra.AST is a library designed to facilitate the representation, manipulation, and traversal of Abstract Syntax Trees in C# applications. It provides a structured approach to working with code as data, which is essential for tasks such as code analysis, transformation, and generation.

## Features

- **Comprehensive AST Structure**: Includes declarations, expressions, and statements
- **Visitor Pattern Implementation**: Easily traverse and transform AST nodes
- **Modern C# Support**: Built for .NET 9.0 with full nullable reference type support
- **Extensible Design**: Create custom AST processing logic through the visitor interface

## Installation

Install the package via NuGet:

```bash
dotnet add package Vectra.AST
```

## Usage

The library follows the Visitor design pattern for AST traversal:

```csharp
// Implement a custom visitor
public class MyAstVisitor : IAstVisitor<string>
{
    public string VisitClassDeclaration(ClassDeclarationNode node)
    {
        // Process class declaration
        return $"Class: {node.Name}";
    }

    // Implement other visitor methods...
}

// Use the visitor to process AST nodes
var visitor = new MyAstVisitor();
var result = node.Accept(visitor);
```

## Project Structure

- **Declarations**: Contains AST nodes for various declarations (classes, methods, etc.)
- **Expressions**: Contains AST nodes for expressions (literals, identifiers, etc.)
- **Statements**: Contains AST nodes for statements (return, expression statements, etc.)
- **Models**: Contains supporting model classes for the AST

## Requirements

- .NET 9.0

## License

This project is maintained by [DuncanMcPherson](https://github.com/DuncanMcPherson).

## Versioning

This project uses semantic versioning. See the [CHANGELOG.md](CHANGELOG.md) for version details and release notes.
