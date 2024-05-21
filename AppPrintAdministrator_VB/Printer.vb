Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace AppPrintAdministrator_VB
    Public Class Printer
        Private _brand As String

        Public ReadOnly Property Brand() As String
            Get
                Return _brand
            End Get
        End Property

        Private _series As String

        Public Property Series() As String
            Get
                Return _series
            End Get
            Set(value As String)
                _series = value
            End Set
        End Property

        Private _sale_price As Decimal

        Public ReadOnly Property SalePrice() As Decimal
            Get
                Return _sale_price
            End Get
        End Property

        Private _rent_price As Decimal

        Public ReadOnly Property RentPrice() As Decimal
            Get
                Return _rent_price
            End Get
        End Property

        Public Sub New()
            _brand = "XEROX"
            _series = ""
            _sale_price = 0D
            _rent_price = 0D
        End Sub

        Public Sub New(series As String, sale_price As Decimal, rent_price As Decimal)
            _brand = "XEROX"
            _series = series
            _sale_price = sale_price
            _rent_price = rent_price
        End Sub

        Public Function ShowBrand() As String
            Return _brand
        End Function
    End Class
End Namespace
