<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TerrificTurtledoves_FinalProject.index" %>

<!-- Documentation
# Name: Jacob Stamper, Grahame Halliburton, Asfia Siddiqui
# email: stampejp@mail.uc.edu, hallibgl@mail.uc.edu, siddiqaf@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 12/10/24
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This is our final project, allowing users to select which Leet Code problem they wish to solve.
# Citations: For LeetCode solving: https://chatgpt.com/
# Anything else that's relevant: N/A -->

<!DOCTYPE html>
<html>
<head>
    <title>LeetCode Problem Solver</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU" crossorigin="anonymous"/>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        .container {
            width: 60%;
            margin: 0 auto;
        }
        .problem-description {
            border: 1px solid #ccc;
            padding: 15px;
            margin-bottom: 15px;
            background-color: #f9f9f9;
        }
        select, button {
            padding: 10px;
            font-size: 14px;
        }
        .output {
            margin-top: 15px;
            padding: 10px;
            border: 1px solid #28a745;
            background-color: #e9f7ef;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>LeetCode Problem Solver</h1>
            <label for="problemSelect">Select a LeetCode Problem:</label>
            <asp:DropDownList ID="problemSelect" runat="server">
                <asp:ListItem Value="MaxScoreWords" Text="Maximum Score of Words"></asp:ListItem>
                <asp:ListItem Value="SudokuSolver" Text="Sudoku Solver"></asp:ListItem>
                <asp:ListItem Value="ReducingDishes" Text="Reducing Dishes"></asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            <asp:Button ID="btnSolve" runat="server" Text="Solve Problem" CssClass="btn btn-primary" OnClick="btnSolve_Click" />
            <br /><br />
            <asp:Panel ID="descriptionPanel" CssClass="problem-description" runat="server">
                <!-- Problem description will be displayed here -->
            </asp:Panel>
            <asp:Panel ID="outputPanel" CssClass="output" runat="server">
                <!-- Solution output will be displayed here -->
            </asp:Panel>
        </div>
    </form>
</body>
</html>