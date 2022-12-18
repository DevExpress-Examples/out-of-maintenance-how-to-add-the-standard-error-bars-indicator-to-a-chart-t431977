Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace StandardErrorBars

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Public Class Record

            Public Sub New(ByVal timePoint As Date, ByVal temperature As Integer)
                Me.TimePoint = timePoint
                Me.Temperature = temperature
            End Sub

            Public Property TimePoint As Date

            Public Property Temperature As Double
        End Class

        Private Function GetData() As List(Of Record)
            Return New List(Of Record)() From {New Record(New DateTime(2016, 07, 01), 26), New Record(New DateTime(2016, 07, 02), 24), New Record(New DateTime(2016, 07, 03), 26), New Record(New DateTime(2016, 07, 04), 29), New Record(New DateTime(2016, 07, 05), 30), New Record(New DateTime(2016, 07, 06), 33), New Record(New DateTime(2016, 07, 07), 32), New Record(New DateTime(2016, 07, 08), 30), New Record(New DateTime(2016, 07, 09), 22), New Record(New DateTime(2016, 07, 10), 27), New Record(New DateTime(2016, 07, 11), 27), New Record(New DateTime(2016, 07, 12), 28), New Record(New DateTime(2016, 07, 13), 29), New Record(New DateTime(2016, 07, 14), 31), New Record(New DateTime(2016, 07, 15), 31), New Record(New DateTime(2016, 07, 16), 32), New Record(New DateTime(2016, 07, 17), 32), New Record(New DateTime(2016, 07, 18), 34), New Record(New DateTime(2016, 07, 19), 28), New Record(New DateTime(2016, 07, 20), 29), New Record(New DateTime(2016, 07, 21), 32), New Record(New DateTime(2016, 07, 22), 34), New Record(New DateTime(2016, 07, 23), 36), New Record(New DateTime(2016, 07, 24), 34), New Record(New DateTime(2016, 07, 25), 34), New Record(New DateTime(2016, 07, 26), 32), New Record(New DateTime(2016, 07, 27), 33), New Record(New DateTime(2016, 07, 28), 35), New Record(New DateTime(2016, 07, 29), 29), New Record(New DateTime(2016, 07, 30), 29), New Record(New DateTime(2016, 07, 31), 26)}
        End Function

        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Me.pointSeries IsNot Nothing Then
                Me.pointSeries.ArgumentDataMember = "TimePoint"
                Me.pointSeries.ValueDataMember = "Temperature"
                Me.pointSeries.DataSource = GetData()
            End If
        End Sub
    End Class
End Namespace
