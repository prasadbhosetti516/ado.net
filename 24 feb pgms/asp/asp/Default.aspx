<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="asp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="FirstPage.aspx"> INSERT STUDENT DETAILS &raquo;</a><br />
                <a class="btn btn-default" href="SecondPage.aspx"> SHOW STUDENT DETAILS&raquo;</a><br />
                <a class="btn btn-default" href="ThirdPage.aspx"> UPDATE STUDENT &raquo;</a><br />
                <a class="btn btn-default" href="FourthPage.aspx"> DELETE STUDENT &raquo;</a><br /><br /><br />

                <a class="btn btn-default" href="FifthPage.aspx"> INSERT COURSE DETAILS&raquo;</a><br />
                <a class="btn btn-default" href="SixthPage.aspx"> SHOW COURSE DETAILS&raquo;</a><br />
                <a class="btn btn-default" href="SeventhPage.aspx"> UPDATE COURSE &raquo;</a><br />
                <a class="btn btn-default" href="EighthPage.aspx"> DELETE COURSE &raquo;</a><br /><br /><br />

                <a class="btn btn-default" href="NinthPage.aspx"> INSERT FACULTY DETAILS&raquo;</a><br />
                <a class="btn btn-default" href="TenthPage.aspx"> SHOW FACULTY DETAILS&raquo;</a><br />
                <a class="btn btn-default" href="EleventhPage.aspx"> UPDATE FACULTY &raquo;</a><br />
                <a class="btn btn-default" href="TwelthPage.aspx"> DELETE FACULTY &raquo;</a><br /><br /><br />


                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
