# ASP.NET MVC

## Link
[Get started with ASP.NET Core MVC](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-7.0&tabs=visual-studio)

## Notes

### [Add a controller](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-7.0&tabs=visual-studio)

- Controllers/HelloWorldController.cs
	```
	public class HelloWorldController : Controller
	```
	- By inheriting from the "Controller" class, the "HelloWorldController" class gains access to various methods and properties defined in the base class. It allows the "HelloWorldController" to implement actions (methods) that can be invoked when specific HTTP requests are made to the corresponding routes. 
	- Every public method in a controller is callable as an HTTP endpoint. 
	- An HTTP endpoint: Is a targetable URL in the web application, such as https://localhost:5001/HelloWorld.

MVC invokes controller classes, and the action methods within them, depending on the incoming URL. The default URL routing logic used by MVC, uses a format like this to determine what code to invoke:
```
/[Controller]/[ActionName]/[Parameters]
```
The routing format is set in the Program.cs file.

- Parameters and query string:

```cs
	//
	// GET: /HelloWorld/Welcome1/?name=Rick&numtimes=4
	// Requires using System.Text.Encodings.Web;
	public string Welcome1(string name, int numTimes = 1)
	{
		return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
	}
```

  - The URL segment Parameters isn't used.
  - The name and numTimes parameters are passed in the query string.
  - The ? (question mark) in the above URL is a separator, and the query string follows.
  - The & character separates field-value pairs.

```cs
public string Welcome(string name, int ID = 1)
{
    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
}
```

  - The third URL segment matched the route parameter id.
  - The `ID` can be found below

In Program.cs
```cs
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
```

  - The third URL segment matched the route parameter id.
  - The Welcome method contains a parameter id that matched the URL template in the MapControllerRoute method.
  - The trailing ? (in id?) indicates the id parameter is optional.
