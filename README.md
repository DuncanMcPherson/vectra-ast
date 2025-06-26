# Vectra.AST

[![GitHub](https://img.shields.io/github/v/release/DuncanMcPherson/vectra-ast)](https://github.com/DuncanMcPherson/vectra-ast)
[![Build](https://github.com/DuncanMcPherson/vectra-ast/actions/workflows/release.yaml/badge.svg)](https://github.com/DuncanMcPherson/vectra-ast)

Vectra.AST is a .NET library that provides a comprehensive Abstract Syntax Tree (AST) implementation for programming language analysis and transformation. Built with C# 13.0 and targeting .NET 9.0, this library offers a flexible foundation for language processing tasks.

## Overview

Vectra.AST implements the Visitor design pattern to traverse and process various nodes in an Abstract Syntax Tree. The library provides a robust structure for representing code elements such as:

- Class and type declarations
- Method declarations
- Variable and field declarations
- Property declarations
- Expressions (binary, call, literal, identifier, etc.)
- Statements (return, expression, etc.)

## Installation

Install Vectra.AST via NuGet:

```bash
dotnet add package Vectra.AST
```

## Core Components

### AST Visitor Interface

The `IAstVisitor<T>` interface is at the heart of the library, allowing you to implement specific behaviors for each type of AST node:

```csharp
public interface IAstVisitor<out T>
{
    T VisitClassDeclaration(ClassDeclarationNode node);
    T VisitMethodDeclaration(MethodDeclarationNode node);
    T VisitExpressionStatement(ExpressionStatementNode node);
    T VisitReturnStatement(ReturnStatementNode node);
    T VisitLiteralExpression(LiteralExpressionNode node);
    // ... and more
}
```

### Node Hierarchy

The library organizes AST nodes into logical categories:

- **Declarations**: Classes, methods, fields, properties, etc.
- **Expressions**: Literals, identifiers, binary operations, method calls, etc.
- **Statements**: Return statements, expression statements, etc.

### Source Span Tracking

Each node includes source code location information through the `SourceSpan` class, which is useful for error reporting and tooling.

## Usage Example

```csharp
// Create a simple visitor implementation
public class MyVisitor : IAstVisitor<string>
{
    public string VisitClassDeclaration(ClassDeclarationNode node)
    {
        return $"Found class: {node.Name}";
    }

    // Implement other methods...

    public string VisitLiteralExpression(LiteralExpressionNode node)
    {
        return $"Found literal: {node.Value}";
    }

    // ...
}

// Use the visitor with your AST
var visitor = new MyVisitor();
var result = someAstNode.Accept(visitor);
```

## Project Structure

- **Vectra.AST**: Core library containing the AST implementation
  - **Declarations**: Classes for representing program structure elements
  - **Expressions**: Classes for representing code expressions
  - **Statements**: Classes for representing code statements
  - **Models**: Supporting data structures

## Development

### Prerequisites

- .NET 9.0 SDK or later

### Building the Project

```bash
dotnet build
```

### Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Maintainers

- [DuncanMcPherson](https://github.com/DuncanMcPherson)
