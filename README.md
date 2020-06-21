# ASX Audit Trail

This project's purpose is used to display ASX trading data with candlestick diagram with amChart JavaScript version package.

## Apply amChart css and script files into _layout.cshtml

Add the following files:

stylesheet: candlestick.css

JavaScript: charts.js | animated.js | candlestick.js
``` _layout.cshtml
 </environment>
        <link rel="stylesheet" href="~/css/site.css" />
        <link rel="stylesheet" href="~/css/candlestick.css" />                  *<<< /css/candlestick.css*
    </head>
    <body>
        <header>
            ... ... ...
        <!--<script src="~/js/site.js" asp-append-version="true"></script>-->
        <script src="~/js/core.js" asp-append-version="true"></script>
        <script src="~/js/charts.js" asp-append-version="true"></script>        *<<< /js/core.js*
        <script src="~/themes/animated.js" asp-append-version="true"></script>  *<<< /themes/animated.js*
        <script src="~/js/candlestick.js" asp-append-version="true"></script>   *<<< /js/candlestick.js*
```
## Add candlestick on a View
Add <div id="chartdiv"></div> for the candelstick chart to display.

``` Views/index.cshtml
    <button type="submit">Submit</button>
    <div id="chartdiv"></div>
    </div>
```
