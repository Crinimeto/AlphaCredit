'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace AcreditPrueba

    Partial Public Class Vehiculo
        Public Property IdVehiculo As Integer
        Public Property Placa As String
        Public Property Marca As String
        Public Property Linea As String
        Public Property Color As String
        Public Property Modelo As Integer
        Public Property Tipo As String
        Public Property Precio As Decimal
    
        Public Overridable Property Venta As ICollection(Of Venta) = New HashSet(Of Venta)
    
    End Class

End Namespace
