Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports AcreditPrueba.AcreditPrueba

Namespace Controllers
    Public Class VentasController
        Inherits System.Web.Mvc.Controller

        Private db As New CONCESIONARIOContext

        ' GET: Ventas
        Function Index() As ActionResult
            Dim venta = db.Venta.Include(Function(v) v.Persona).Include(Function(v) v.Vehiculo)
            Return View(venta.ToList())
        End Function

        ' GET: Ventas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim venta As Venta = db.Venta.Find(id)
            If IsNothing(venta) Then
                Return HttpNotFound()
            End If
            Return View(venta)
        End Function

        ' GET: Ventas/Create
        Function Create() As ActionResult
            ViewBag.IdPersona = New SelectList(db.Persona, "IdPersona", "Nombre")
            ViewBag.IdVehiculo = New SelectList(db.Vehiculo, "IdVehiculo", "Placa")
            Return View()
        End Function

        ' POST: Ventas/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="IdVenta,Fecha,Consecutivo,Valor,IdPersona,IdVehiculo")> ByVal venta As Venta) As ActionResult
            If ModelState.IsValid Then
                db.Venta.Add(venta)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.IdPersona = New SelectList(db.Persona, "IdPersona", "Nombre", venta.IdPersona)
            ViewBag.IdVehiculo = New SelectList(db.Vehiculo, "IdVehiculo", "Placa", venta.IdVehiculo)
            Return View(venta)
        End Function

        ' GET: Ventas/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim venta As Venta = db.Venta.Find(id)
            If IsNothing(venta) Then
                Return HttpNotFound()
            End If
            ViewBag.IdPersona = New SelectList(db.Persona, "IdPersona", "Nombre", venta.IdPersona)
            ViewBag.IdVehiculo = New SelectList(db.Vehiculo, "IdVehiculo", "Placa", venta.IdVehiculo)
            Return View(venta)
        End Function

        ' POST: Ventas/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="IdVenta,Fecha,Consecutivo,Valor,IdPersona,IdVehiculo")> ByVal venta As Venta) As ActionResult
            If ModelState.IsValid Then
                db.Entry(venta).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.IdPersona = New SelectList(db.Persona, "IdPersona", "Nombre", venta.IdPersona)
            ViewBag.IdVehiculo = New SelectList(db.Vehiculo, "IdVehiculo", "Placa", venta.IdVehiculo)
            Return View(venta)
        End Function

        ' GET: Ventas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim venta As Venta = db.Venta.Find(id)
            If IsNothing(venta) Then
                Return HttpNotFound()
            End If
            Return View(venta)
        End Function

        ' POST: Ventas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim venta As Venta = db.Venta.Find(id)
            db.Venta.Remove(venta)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
