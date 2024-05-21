Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports AppPrintAdministrator_VB.AppPrintAdministrator_VB
Imports DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing

Namespace AppPrintAdministrator_VB
    Public Class Phaser
        Inherits Printer

        Private _sale_price As Decimal

        Public Shadows ReadOnly Property SalePrice() As Decimal
            Get
                Return _sale_price
            End Get
        End Property
        Private _rent_price As Decimal

        Public Shadows ReadOnly Property RentPrice() As Decimal
            Get
                Return _rent_price
            End Get
        End Property
        Public Sub New()
            MyBase.New()
            Series = ""
            _sale_price = 25000D
            _rent_price = 4000D
        End Sub
        Public Sub New(series As String, sale_price As Decimal, rent_price As Decimal)
            MyBase.New(series, sale_price, rent_price)
            Me.Series = series
            _sale_price = 25000D
            _rent_price = 4000D
        End Sub
    End Class
End Namespace
