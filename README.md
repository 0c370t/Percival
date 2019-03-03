# Percival
> ASP.NET MVC/JQuery SpaceX Data Aggregator

## Running the program

### UNIX
- Ensure you have ASP.NET Core 2 installed
- Clone or download the repo
- Navigate to Percival/ in the terminal
- Use `dotnet run`
- Navigate to `https://localhost:5001` in a web browser

### Windows
- Ensure you have Visual Studio installed
- Ensure you have .NET Core 2.2 installed (https://dotnet.microsoft.com/download/dotnet-core/2.2)
- Clone or download the repo
- Open Percival/Percival.csproj as a project in Visual Studio
- Run the project, Visual Studio should open a browser and direct you to the page

## Development Process

### Stage 1:
For the very beginnings of this project, I spent about a day just learning C#, ASP.NET, and the other technologies I would be using. I find it's best to get a firm grasp on things while compartmentalizing them in order to effectively apply everything you've learned.
There were several websites I used along with Microsoft documentation to speed my learning, and it was certainly interesting to see the similarities and differences to languages I know (i.e. String vs string or using vs import).
### Stage 2:
Once I had a decent grip on C# I stepped things up a little bit, and spent a few hours with the MVC and Web Forms templates to get an idea of how they work. I quickly picked up MVC as it is a very logical, encapsulated approach, and decided to move forward with that.
MVC also runs on .NET Core 2, which is available on Linux (my favorite OS for development), so nearly everything but my final stage of debugging has been using Linux and Atom.
### Stage 3:
Once I had pages displaying the way I wanted them to in MVC, I started what would be the final project and moved to include Kendo UI. After some deliberation about where/how to implement it (Telerik UI MVC vs. Kendo UI JQuery), I opted for the JQuery option. Not only was it the technology I was most familiar with, but the MVC technology seemed to rely on it anyways.
Once I realized that datasource was actually dataSource, things went very smoothly.
### Stage 4:
After structuring the Javascript in a way that allowed a front-end ajax call without an incredibly disruptive experience, I added bootstrap with a little bit of custom styling to tie everything together.

## Challenges

The biggest challenges I encountered were mostly due to not understanding the program structure and the workflows for C#. For example I wrote several hundred lines of models before I moved to the front end, intending a very literal "Model View Controller" implementation, without taking into consideration that Kendo would be handling most of that.
I also had to decide if Kendo Grid would be a good choice for the details pages, because the majority of launches have only a single payload item, it was very over-complicated for the use case. Instead I opted to make a very simple CSS styling that would display the information in a more pleasing way.

## Overall Thoughts

I thoroughly enjoyed this project. I gave myself a tight deadline to see if I would be able to make it, and had a fully functioning version nearly 2 days early (I still need to debug IE as of Saturday, because I've been on Linux). I had several friends tell me it was too large to be a "fair" test for any potential employment, but I view tests like these as a learning experience, and a way to learn what I don't know.

Overall, the concept is an excellent idea, and the only issue with the project I would amend is the use of a paid library as a requirement. Support was somewhat difficult to use for Kendo, and there was far too much marketing material and far too little succinct but detailed documentation.
