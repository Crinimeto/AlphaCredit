﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Namespace AcreditPrueba

    Partial Public Class CONCESIONARIOContext
        Inherits DbContext
    
        Public Sub New()
            MyBase.New("name=CONCESIONARIOContext")
        End Sub
    
        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            Throw New UnintentionalCodeFirstException()
        End Sub
    
        Public Overridable Property Persona() As DbSet(Of Persona)
        Public Overridable Property Vehiculo() As DbSet(Of Vehiculo)
        Public Overridable Property Venta() As DbSet(Of Venta)
    
    End Class

End Namespace