Imports System
Imports System.Collections.Generic
Imports System.IO.Packaging
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Xml.Linq

Namespace AppPrintAdministrator_VB
    Public Class TypePaper
        Private _name As String

        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Private _size As String

        Public Property Size() As String
            Get
                Return _size
            End Get
            Set(value As String)
                _size = value
            End Set
        End Property

        Private _pricePacket As Decimal

        Public Property PricePacket() As Decimal
            Get
                Return _pricePacket
            End Get
            Set(value As Decimal)
                _pricePacket = value
            End Set
        End Property

        Private _pricePrint As Decimal

        Public Property PricePrint() As Decimal
            Get
                Return _pricePrint
            End Get
            Set(value As Decimal)
                _pricePrint = value
            End Set
        End Property

        Private _whiteSheetPrice As Decimal

        Public Property WhiteSheetPrice() As Decimal
            Get
                Return _whiteSheetPrice
            End Get
            Set(value As Decimal)
                _whiteSheetPrice = value
            End Set
        End Property

        Public Sub New()
            _name = ""
            _size = ""
            _pricePacket = 0D
            _pricePrint = 0D
            _whiteSheetPrice = 0D
        End Sub

        Public Sub New(name As String, size As String, pricePacket As Decimal, pricePrint As Decimal, whiteSheetPrice As Decimal)
            _name = name
            _size = size
            _pricePacket = pricePacket
            _pricePrint = pricePrint
            _whiteSheetPrice = whiteSheetPrice
        End Sub

        Public Overrides Function ToString() As String
            Return $"{_name} {_size} {_pricePacket} {_pricePrint} {_whiteSheetPrice}"
        End Function
    End Class
End Namespace
