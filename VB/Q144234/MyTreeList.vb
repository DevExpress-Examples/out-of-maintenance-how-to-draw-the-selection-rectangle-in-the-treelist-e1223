Imports DevExpress.XtraEditors
Imports System.Drawing
Imports System.Windows.Forms
Imports System
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Namespace DXSample
    Public Class MyTreeList
        Inherits TreeList

        Public Sub New()
            MyBase.New()
            OptionsBehavior.ShowEditorOnMouseUp = True
            OptionsSelection.EnableAppearanceFocusedCell = False
            OptionsSelection.MultiSelect = True
            OptionsView.ShowFocusedFrame = False
        End Sub

        Private selectedRect As Rectangle = Rectangle.Empty
        Private dragRect As Rectangle = Rectangle.Empty

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            If selectedRect = Rectangle.Empty Then
                Return
            End If
            e.Graphics.DrawRectangle(Pens.Blue, selectedRect)
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(50, Color.Blue)), selectedRect)
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                dragRect.X = e.X - SystemInformation.DragSize.Width \ 2
                dragRect.Y = e.Y - SystemInformation.DragSize.Height \ 2
                dragRect.Size = SystemInformation.DragSize
                selectedRect.Location = e.Location
            End If
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left AndAlso selectedRect <> Rectangle.Empty Then
                Selection.Clear()
                For i As Integer = 0 To VisibleNodesCount - 1
                    Dim node As TreeListNode = GetNodeByVisibleIndex(i)
                    If ViewInfo.RowsInfo(node).Bounds.IntersectsWith(selectedRect) Then
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
                    If e.X <= selectedRect.X Then
                        selectedRect.X = e.X
                        selectedRect.Width += tmp.Right - selectedRect.Right
                    Else
                        selectedRect.Width = e.X - selectedRect.X
                    End If

                    If e.Y <= selectedRect.Y Then
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
    End Class
End Namespace