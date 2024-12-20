﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listado_camiones.aspx.cs" Inherits="FDRH_3Capas.Catalogo.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <div class="container">
        <div class="row">
            <h3>Listado de Camiones</h3>
            <%--Botón para agregar un nuevo camion--%>
            <p>
                <%--Se genere un evento "OnClick"--%>
                <asp:Button ID="Insertar" runat="server" Text="Agregar" CassClass="btn btn-primary btn-xs" Width="85px"
                    OnClick="Insertar_Click"/>
            </p>
        </div>
        <div class="row">
            <asp:GridView ID="GVCamiones" runat="server"
                CssClass="table table-bordered table-striped table-condensed"
                AutoGenerateColums="false"
                DataKeyNAmes="ID_Camion"
                OnRowDeleting="GVCamiones_RowDeleting"
                OnRowCommand="GVCamiones_RowCommand"
                OnRowEditing="GVCamiones_RowEditing"
                OnRowUpdating="GVCamiones_RowUpdating"
                OnRowCancelingEdit="GVCamiones_RowCancelingEdit">
              
                <%--Arriba se generan los eventos "onrow"--%>
                <Columns>
                    <asp:BoundField DataField="ID_Camion" HeaderText="Número de Camión"
                        ItemStyle-Width="50px" ReadOnly="true"/>
                    <asp:BoundField DataField="Matricula" HeaderText="Matrícula" ItemStyle-Width="85px"/>
                    <asp:BoundField DataField="Tipo_camion" HeaderText="Tipo_Camion" ItemStyle-Width="85px"/>
          
                    <asp:TemplateField HeaderText="Disponibilidad" ItemStyle-Width="50px">
                    <ItemTemplate>
                        <div style="width: 100%">
                            <div style="width: 25%; margin: 0 auto">
                                <asp:CheckBox ID="chkDisponible" runat="server" 
                                    
                                     Checked='<%#Eval("Disponibilidad")%>' Enabled="false"/>

                               
                            </div>

                        </div>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <div style="width: 100%">
                            <div style="width: 25%; margin: 0 auto">
                                <asp:CheckBox  ID="chkEditDisponible" runat="server"
                                    Cheked='<%#Eval("Disponibilidad") %>'/>
                            </div>
                        </div>
                    </EditItemTemplate>
                        </asp:TemplateField>
                    <asp:BoundField DataField="UrlFoto" HeaderText="UrlFoto" ItemStyle-Width="85px" />
                    <asp:ImageField HeaderText="Foto" ReadOnly="true" ItemStyle-Width="120px" ControlStyle-Height="120px"
                       ControlStyle-Width="120px" DataImageUrlField="UrlFoto">
                    </asp:ImageField>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="1" Text="Ver Detalles"
                        ControlStyle-CssClass="btn btn-primary btn-xs" ItemStyle-Width="50px" />
                    <asp:CommandField ButtonType="Button" HeaderText="2" ShowEditButton="true" ShowHeader="true"
                        ControlStyle-CssClass="btn btn-warning btn-xs" ItemStyle-Width="50px" />
                    <asp:CommandField ButtonType="Button" HeaderText="2" ShowDeleteButton="true" ShowHeader="true"
                        ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="50px" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
