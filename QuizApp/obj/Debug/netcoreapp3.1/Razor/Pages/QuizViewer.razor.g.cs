#pragma checksum "C:\Users\Thomas\source\repos\QuizApp\QuizApp\Pages\QuizViewer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f63d64821a5d172523c34d4da55d7941f56cc3a"
// <auto-generated/>
#pragma warning disable 1591
namespace QuizApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\_Imports.razor"
using QuizApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\_Imports.razor"
using QuizApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\Pages\QuizViewer.razor"
using QuizApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/QuizViewer")]
    public partial class QuizViewer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>QuizViewer</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "What is the capital of ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\Pages\QuizViewer.razor"
                           question.QuestionCountry

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, "?");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\Pages\QuizViewer.razor"
 foreach (string option in question.Options)
{
    var buttonText = option;

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\Pages\QuizViewer.razor"
                                                e => GetNewQuestion(buttonText)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, 
#nullable restore
#line 12 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\Pages\QuizViewer.razor"
                                                                                   option

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 13 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\Pages\QuizViewer.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, 
#nullable restore
#line 15 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\Pages\QuizViewer.razor"
    answer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "p");
            __builder.AddContent(17, "Score: ");
            __builder.AddContent(18, 
#nullable restore
#line 16 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\Pages\QuizViewer.razor"
           score

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Thomas\source\repos\QuizApp\QuizApp\Pages\QuizViewer.razor"
       
    static string filename = "C:/Users/Thomas/source/repos/QuizApp/QuizApp/wwwroot/Countries/country-capitals.csv";
    static CsvReader csvreader = new CsvReader(filename);
    static List<Country> countries = csvreader.ReadAllCountries();
    public static QuizItem question = new QuizItem(countries);
    public int score = 0;
    public string answer = question.QuestionAnswer;


    public void GetNewQuestion(string resp)
    {
        if (resp == question.QuestionAnswer)
        {
            question = new QuizItem(countries);
            answer = question.QuestionAnswer;
            score++;
        }
        else
        {
            question = new QuizItem(countries);
            answer = question.QuestionAnswer;
        }

    }

    //bool quizStarted = false;
    public bool CheckAnswer(string answer, QuizItem question)
    {
        if (answer == question.QuestionAnswer)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
