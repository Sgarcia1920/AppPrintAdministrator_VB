Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace AppPrintAdministrator_VB
    Public Class Sales
        Private _size As String

        Public Property Size() As String
            Get
                Return _size
            End Get
            Set(value As String)
                _size = value
            End Set
        End Property

        Private _availablePaperSale As String

        Public Property AvailablePaperSales() As String
            Get
                Return _availablePaperSale
            End Get
            Set(value As String)
                _availablePaperSale = value
            End Set
        End Property

        Private _salesOptions As String

        Public Property SalesOptions() As String
            Get
                Return _salesOptions
            End Get
            Set(value As String)
                _salesOptions = value
            End Set
        End Property

        Private _priceSale As Decimal

        Public Property PriceSale() As Decimal
            Get
                Return _priceSale
            End Get
            Set(value As Decimal)
                _priceSale = value
            End Set
        End Property

        Private _numberPrints As Integer

        Public Property NumberPrints() As Integer
            Get
                Return _numberPrints
            End Get
            Set(value As Integer)
                _numberPrints = value
            End Set
        End Property

        Public Sub New()
            _size = ""
            _availablePaperSale = ""
            _salesOptions = ""
            _priceSale = 0D
            _numberPrints = 0
        End Sub

        Public Sub New(size As String, availablePaperSale As String, salesOptions As String, priceSale As Decimal, numberPrints As Integer)
            _size = size
            _availablePaperSale = availablePaperSale
            _salesOptions = salesOptions
            _priceSale = priceSale
            _numberPrints = numberPrints
        End Sub

        Public Function CalculateTotalSale() As Decimal
            Dim total As Decimal = 0
            Select Case _salesOptions
                Case "Pricepacket"
                    total = _priceSale * _numberPrints
                Case "Priceprint"
                    total = _priceSale * _numberPrints
                Case "WhitesheetPrice"
                    total = _priceSale * _numberPrints
            End Select
            Return total
        End Function
    End Class
End Namespace

