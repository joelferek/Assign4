# WeatherTicket Application

## Overview

This application is designed to enhance users' experiences by providing tailored information based on their location. Users input their location, and the app retrieves relevant details such as upcoming sporting events with ticket prices, ski lift information for nearby resorts, zoo ticket prices and special exhibits, amusement park details including ride ticket prices, and current weather conditions. By integrating with various APIs and databases, the app offers a seamless interface for users to access this information, empowering them to make informed decisions and maximize enjoyment during their time in the city.

# Deployment Guide
## What steps should they take (creating the database, cloning the repository, etc.)?
### You should open sql server, copy the the files in the SQL file, and then copy them into sql server and run each file individually. The files should be run in order of Database Creation, DatabaseData, and then any of the Stored procedures in any order you may like. Then they should click code in Github and click "Open With Visual Studio". From there, they can run the program. Make sure to have the API and main project turned on to start both.

## Where should they go for help if they run into errors?
### They should post their error into CHATGPT if that does not work they should reach out to one of us to help figure out the problem.


## Joel Ferek Razor Pages
### Both of my pages use my API's from the assignment before. You can access them by clicking each button at the bottom of the index page

- **City Activities API:** My first Razor page shows activities available in the city that you choose. This is convenient because our application's purpose is to give people things to do based on the weather. You should input the CITYID and the output is the event.
- **City Info API:** My second Razor Page shows the all the details of the city that we have available. This is good for the user because it gives all the information possible. You should input the CITYID and the output is the the city information.

## Samantha Olivio APIs
- **Highest Event Count API:** My first API gathers data about the cities with the most events happening. This shows users what cities offer the most activities and things to do. Outputs include City and Event Count, while no inputs are required. 
- **Low Price Events API:** My second API finds the events that are the cheapest. This helps users find cost-friendly events near them.  
No inputs are required, outputs include Event and Event Price. 
# References

<body>


    <h2>Our Story</h2>
    <p>Welcome to WeatherTicket! We are an innovative application dedicated to assisting ticket pricers in making informed decisions based on weather conditions. Our mission is to provide a seamless integration of weather data into the ticket pricing process, enabling businesses and event organizers to optimize pricing strategies.</p>

    <h3>Who We Are</h3>
    <p>At WeatherTicket, we are a passionate team of developers, data scientists, and weather enthusiasts. Our collective goal is to revolutionize the way ticket prices are determined, taking into account the impact of weather on event attendance. With a commitment to simplicity and effectiveness, we strive to empower our users with valuable insights that enhance their ticket pricing decisions.</p>

    <h3>What We Do</h3>
    <ul>
        <li>Empowering ticket pricers with weather-based insights</li>
        <li>Seamless integration of weather data into pricing strategies</li>
        <li>Optimizing ticket prices for maximum attendance and revenue</li>
    </ul>
    <p>Our application leverages real-time weather data to analyze how different weather conditions influence attendance trends. By combining this information with advanced algorithms, we provide ticket pricers with actionable recommendations to adjust prices dynamically. Whether it's a sports event, concert, or outdoor festival, WeatherTicket ensures that ticket prices align with the prevailing weather conditions, maximizing both attendance and revenue.</p>

    <h3>Features</h3>
    <table border="1">
        <tr>
            <th>Feature</th>
            <th>Description</th>
        </tr>
        <tr>
            <td>Data-Driven Pricing</td>
            <td>Dynamic adjustment of ticket prices based on real-time weather data.</td>
        </tr>
        <tr>
            <td>Optimized Strategies</td>
            <td>Strategies to maximize attendance and revenue under different weather conditions.</td>
        </tr> can you redo this but instead make it about a company that will show you the tickets for certain cities sporting events. Or it will show you other activities to do in the city




CREATE PROCEDURE GetCitiesByAvgTempAboveThreshold
    @ThresholdTemp INT
AS
BEGIN
    SELECT CityID, CityName, AvgTemp
    FROM City
    WHERE AvgTemp > @ThresholdTemp;
END;
GO 
EXEC GetCitiesByAvgTempAboveThreshold @ThresholdTemp = 70;
GO how would I change this so it would create a
 procedure based on if you enter the cities ID itll return yes or no if its abovre the threshold temp




You
@page
@model Assign4.Pages.SearchResults1Model
@{
    var CityID = HttpContext.Request.Query["CityID"];
}

<div id="GetEvents" style="visibility:hidden; "> </div>


<script type="module">
    displayCityEvents(@CityID)
</script>@page
@model Assign4.Pages.IndexModel
@{
    ViewData["Title"] = "Home page";
}

<body>
    <div class="app-wrap">
        <header>
            <a href="Additions">Future Additions</a>
            <input type="text" autocomplete="off" class="search-box" placeholder="Search for an NFL city..." onkeypress="setQuery()" />
            <a href="about-us">About Us</a><br>


        </header>
        <main>
            <div class="temp-heading">Average Temp: </div>
            <div class="price-heading">Average Price: </div>
            <section class="location">
                <div class="city">New York, US</div>
                <div class="date">Wednesday 22 July 2020</div>
            </section>
            <div class="current">
                <div class="temp">59<span>°F</span></div>
                <div class="weather">Sunny</div>
                <div class="hi-low">55°F / 61°F</div>
            </div>
    </div>
    <input type="text" autocomplete="off" class="CityID" placeholder="CityID to see other activities" onkeypress="setQuery()" />
    </main>
    </div>
    <script src="js/site.js"></script>
</body>
</html>
how could I make it so that when i search the city ID in the second input type on my index page that it gives teh results to the api that I made

Can you help me create a Events Controller for my API with my interfaces?

