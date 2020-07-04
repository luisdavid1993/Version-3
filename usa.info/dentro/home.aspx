<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="usa.info.dentro.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>USAstreas.info herramientas</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>


    <style>
        .grande {
            font-size: 300%;
        }

        .mediano {
            font-size: 150%;
        }

        .sidenav {
            height: 100%; 
          /*  width: 19.7em; 
            position: fixed; 
            left: 0;
            overflow-x: hidden;*/
            background-color: #f5f5f5;
            border: 2px solid #f5f5f5;
        }

            /* The navigation menu links */
            .sidenav a {
                padding: 6px 8px 6px 16px;
                text-decoration: none;
                font-size: 25px;
                color: #818181;
                display: block;
            }

                /* When you mouse over the navigation links, change their color */
                .sidenav a:hover {
                    color: #000000;
                }

        /* Style page content */
        .main {
            padding: 0px 10px;
        }

        /* On smaller screens, where height is less than 450px, change the style of the sidebar (less padding and a smaller font size) */
        @media screen and (max-height: 450px) {
            .sidenav {
                padding-top: 15px;
            }

                .sidenav a {
                    font-size: 18px;
                }
        }
    </style>


</head>
<body>
    <div class="container-full">

        <asp:Label ID="LabelMenu" runat="server"></asp:Label>

        <div class="container main row col-sm-12 col-md-12">
            <div class="col-sm-12 col-md-4 sidenav">
               <asp:Label ID="LabelInfoModule" runat="server"></asp:Label>
            </div>

            <div class="col-sm-12 col-md-8">
                <div class="panel panel-info">
                    <div class="panel-heading">
                        <asp:Label ID="LabelTitulo" runat="server"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <asp:Label ID="LabelDatos" runat="server"></asp:Label>
                    </div>
                    <div class="panel-footer"></div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
