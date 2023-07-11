using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
	// 
	// GET: /HelloWorld/
	public string Index()
	{
		return "This is my default action...";
	}
	//
	// GET: /HelloWorld/Welcome1/?name=Rick&numtimes=4
	// Requires using System.Text.Encodings.Web;
	public string Welcome1(string name, int numTimes = 1)
	{
		return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
	}
	//
	// GET: /HelloWorld/Welcome2/3?name=Rick
	public string Welcome2(string name, int ID = 1)
	{
		return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
	}
}