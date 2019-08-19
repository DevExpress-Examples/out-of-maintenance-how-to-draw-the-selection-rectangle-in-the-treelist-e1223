Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Namespace DXSample
    Public Class MyTreeList
        Inherits TreeList
        Dim selectedRect As Rectangle = Rectangle.Empty
        Dim dragRect As Rectangle = Rectangle.Empty
        Dim startPoint As Point = Point.Empty
        Public Sub New()
            MyBase.New()
            OptionsBehavior.ShowEditorOnMouseUp = True
            OptionsSelection.EnableAppearanceFocusedCell = False
            OptionsSelection.MultiSelect = True
            OptionsView.FocusRectStyle = DrawFocusRectStyle.None
            AddHandler PaintEx, AddressOf OnPaintEx
        End Sub

        Private Sub OnPaintEx(ByVal sender As Object, ByVal e As TreeListPaintEventArgs)
            If selectedRect = Rectangle.Empty Then
                Return
            End If
            e.Cache.DrawRectangle(Pens.Blue, selectedRect)
            Using selectedBrush As New SolidBrush(Color.FromArgb(50, Color.Blue))
                e.Cache.FillRectangle(selectedBrush, selectedRect)
            End Using
        End Sub
        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                dragRect.X = e.X - SystemInformation.DragSize.Width \ 2
                dragRect.Y = e.Y - SystemInformation.DragSize.Height \ 2
                dragRect.Size = SystemInformation.DragSize
                startPoint = e.Location
                selectedRect.Location = e.Location
            End If
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left AndAlso selectedRect <> Rectangle.Empty Then
                Selection.Clear()
                For i As Integer = 0 To VisibleNodesCount - 1
                    Dim node As TreeListNode = GetNodeByVisibleIndex(i)
                    If ViewInfo.RowsInfo(node) IsNot Nothing AndAlso ViewInfo.RowsInfo(node).Bounds.IntersectsWith(selectedRect) Then
                        node.Selected = True
                    End If
                Next i
                selectedRect = Rectangle.Empty
                dragRect = Rectangle.Empty
            End If
            MyBase.OnMouseUp(e)
            Invalidate()
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left AndAlso dragRect <> Rectangle.Empty Then
                If Not dragRect.Contains(e.Location) Then
                    If Selection.Count > 0 Then
                        Selection.Clear()
                    End If
                    Dim tmp As Rectangle = selectedRect
                    If e.X <= startPoint.X Then
                        selectedRect.X = e.X
                        selectedRect.Width += tmp.Right - selectedRect.Right
                    Else
                        selectedRect.Width = e.X - selectedRect.X
                    End If

                    If e.Y <= startPoint.Y Then
                        selectedRect.Y = e.Y
                        selectedRect.Height += tmp.Bottom - selectedRect.Bottom
                    Else
                        selectedRect.Height = e.Y - selectedRect.Y
                    End If
                    Invalidate()
                End If
            End If
            MyBase.OnMouseMove(e)
        End Sub
        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            If dragRect <> Rectangle.Empty Then
                dragRect = Rectangle.Empty
                selectedRect = Rectangle.Empty
            End If
            MyBase.OnMouseLeave(e)
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                RemoveHandler PaintEx, AddressOf OnPaintEx
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace