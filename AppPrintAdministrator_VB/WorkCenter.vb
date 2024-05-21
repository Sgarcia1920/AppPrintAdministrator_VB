Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


Namespace AppPrintAdministrator_VB
    Public Class Workcenter
        Inherits Printer

        Private _salePrice As Decimal

        Public Shadows ReadOnly Property SalePrice() As Decimal
            Get
                Return _salePrice
            End Get
        End Property
        Private _rentPrice As Decimal

        Public Shadows ReadOnly Property RentPrice() As Decimal
            Get
                Return _rentPrice
            End Get
        End Property
        Public Sub New()
            MyBase.New()
            Series = ""
            _salePrice = 14500D
            _rentPrice = 3000D
        End Sub
        Public Sub New(series As String, salePrice As Decimal, rentPrice As Decimal)
            MyBase.New(series, salePrice, rentPrice)
            Me.Series = series
            _salePrice = 14500D
            _rentPrice = 3000D
        End Sub
    End Class
End Namespace
