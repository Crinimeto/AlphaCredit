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
    Public Class VehiculoesController
        Inherits System.Web.Mvc.Controller

        Private db As New CONCESIONARIOContext

        ' GET: Vehiculoes
        Function Index() As ActionResult
            Return View(db.Vehiculo.ToList())
        End Function

        ' GET: Vehiculoes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vehiculo As Vehiculo = db.Vehiculo.Find(id)
            If IsNothing(vehiculo) Then
                Return HttpNotFound()
            End If
            Return View(vehiculo)
        End Function

        ' GET: Vehiculoes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Vehiculoes/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="IdVehiculo,Placa,Marca,Linea,Color,Modelo,Tipo,Precio")> ByVal vehiculo As Vehiculo) As ActionResult
            If ModelState.IsValid Then
                db.Vehiculo.Add(vehiculo)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(vehiculo)
        End Function

        ' GET: Vehiculoes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vehiculo As Vehiculo = db.Vehiculo.Find(id)
            If IsNothing(vehiculo) Then
                Return HttpNotFound()
            End If
            Return View(vehiculo)
        End Function

        ' POST: Vehiculoes/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="IdVehiculo,Placa,Marca,Linea,Color,Modelo,Tipo,Precio")> ByVal vehiculo As Vehiculo) As ActionResult
            If ModelState.IsValid Then
                db.Entry(vehiculo).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(vehiculo)
        End Function

        ' GET: Vehiculoes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vehiculo As Vehiculo = db.Vehiculo.Find(id)
            If IsNothing(vehiculo) Then
                Return HttpNotFound()
            End If
            Return View(vehiculo)
        End Function

        ' POST: Vehiculoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim vehiculo As Vehiculo = db.Vehiculo.Find(id)
            db.Vehiculo.Remove(vehiculo)
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
