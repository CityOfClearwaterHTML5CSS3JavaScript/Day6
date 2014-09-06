Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Return View()
        End Function

        '<Route("")>
        'Function GoHome() As RedirectResult
        '    Return Redirect("/Home/Index")
        'End Function
    End Class
End Namespace