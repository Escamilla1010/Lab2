<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
        <title>Eliminar Video</title>
    <meta charset="UTF-8"></meta>
  <meta name="description" content="ASP.NET MVC 2 CRUD Video"></meta>
  <meta name="keywords" content="ASP.NET, MVC, Facpya"></meta>
  <meta name="author" content="Angel Alejandro Escamilla Villarreal"></meta>
  <meta name="viewport" content="width=device-width, initial-scale=1.0"></meta>
    <link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>

 <form action="/Video/Delete" method="post">
    <fieldset> 
    <legend> Video a Eliminar</legend>

        <label for="idVideo">Video ID</label>
        <input type="text" name="idVideo" />
                
        <input type="submit" value="Eliminar" />



    </fieldset>
    </form>


</body>
</html>
