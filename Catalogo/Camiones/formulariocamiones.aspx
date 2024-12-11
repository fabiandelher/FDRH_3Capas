﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="formulariocamiones.aspx.cs" Inherits="FDRH_3Capas.Catalogo.Camiones.formulariocamiones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <asp:Label ID="Titulo" runat="server" CssClass="text-center modal-title"
                Text=""></asp:Label>
            <asp:Label ID="subTitulo" runat="server" CssClass="text-center modal-title"
                Text=""></asp:Label>
        </div>
        <div calss="row">
            <div class="form-group">
                <asp:Label ID="lblmatricula" runat="server" Text="Matricula">
                </asp:Label>
                <%--campo--%>
                <asp:TextBox ID="txtmatricula" runat="server" CssClass="form-control">
                </asp:TextBox>
                <asp:Label ID="lblcapacidad" runat="server" Text="Capacidad">
                </asp:Label>
                <asp:TextBox ID="txtcapacidad" runat="server" CssClass="form-control">
                </asp:TextBox>

                <asp:Label ID="lblkilometraje" runat="server" Text="Kilometraje">
                </asp:Label>
                <asp:TextBox ID="txtkilometraje" runat="server" CssClass="form-control">
                </asp:TextBox>

                <asp:Label ID="lblmarca" runat="server" Text="Marca">
                </asp:Label>
                <asp:TextBox ID="txtmarca" runat="server" CssClass="form-control">
                </asp:TextBox>

<%--                <asp:Label ID="lblmodelo" runat="server" Text="modelo">
                </asp:Label>
                <asp:TextBox ID="txtmodelo" runat="server" CssClass="form-control">
                </asp:TextBox>--%>

                <asp:Label ID="lbltipo" runat="server" Text="Tipo">
                </asp:Label>
                <asp:TextBox ID="txttipo" runat="server" CssClass="form-control">
                </asp:TextBox>

                <%--Campos especiales--%>
                <br />
                <br />
                <asp:Label ID="lbldisponibilidad" runat="server" Text="Disponibilidad"></asp:Label>
                <br />
                <asp:CheckBox ID="chkdisponibilidad" runat="server" />
                <br />
                <br />

                <asp:Label ID="lblimagen" runat="server" Text="Imagen"></asp:Label>
                <input type="file" id="subeimagen" runat="server" class="btn btn-group"/>
                <asp:Button ID="btnsubeimagen" runat="server" CssClass="btn btn-primary" Text="Subir Imagen"
                    OnClick="btnsubeimagen_Click" />

                <asp:Label ID="lblurlfoto" runat="server" Text="Foto"></asp:Label>

                <asp:Image ID="imgfoto" Width="100" Height="100" runat="server" />
                <asp:Image ID="imgcamion" Width="100" Height="100" runat="server" />

                <asp:Label ID="urlfoto" runat="server"></asp:Label>

                <asp:Button ID="btnguardar" CssClass="btn btn-primary" runat="server" Text="Guardar"
                    OnClick="btnguardar_Click" />
            </div>
        </div>
    </div>
</asp:Content>
