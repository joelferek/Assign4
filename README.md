# WeatherTicket Application

## Overview

This application is designed to enhance users' experiences by providing tailored information based on their location. Users input their location, and the app retrieves relevant details such as upcoming sporting events with ticket prices, ski lift information for nearby resorts, zoo ticket prices and special exhibits, amusement park details including ride ticket prices, and current weather conditions. By integrating with various APIs and databases, the app offers a seamless interface for users to access this information, empowering them to make informed decisions and maximize enjoyment during their time in the city.

## Pages

1. **Home Page:** Gives the current weather conditions when you enter the city of your choice. Also on this page are other buttons that will redirect you to the other pages.
2. **About Us:** The second page gives a quick summary of what we are (as a mock). We act as an up and coming business. It gives a description of what we do.
3. **Additions:** Because we are a newer company/website, we have a page where we talk about what we plan to add or improve.
4. **City Activities:** This page shows other activities available in the city that you choose. All that needs to be done is to enter the city ID, and it will redirect you to a page where it shows the activity.
5. **City Info:** This page shows you all the info about that city of the cityID that you put in. If you put in the cities ID it will give you all the info stored about that city.
6. **[Placeholder for Service Providers (SPs)]**

## Joel Ferek APIs

- **City Activities API:** My first API shows activities available in the city that you choose. This is convenient because our application's purpose is to give people things to do based on the weather.
- **Average Weather API:** My second API shows the all the details of the city that we have available. This is good for the user because it gives all the information possible.

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
