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

    Partial Public Class Venta
        Public Property IdVenta As Integer
        Public Property Fecha As Date
        Public Property Consecutivo As Integer
        Public Property Valor As Decimal
        Public Property IdPersona As Integer
        Public Property IdVehiculo As Integer
    
        Public Overridable Property Persona As Persona
        Public Overridable Property Vehiculo As Vehiculo
    
    End Class

End Namespace
