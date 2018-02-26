Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.Painters
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Drawing
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace OfficeUniversalExample
    Public Class RibbonControlEx
        Inherits RibbonControl

        Protected Overrides Function CreateViewInfo() As DevExpress.XtraBars.Ribbon.ViewInfo.RibbonViewInfo
            Return New RibbonViewInfoEx(Me)
        End Function
    End Class

    Public Class RibbonViewInfoEx
        Inherits RibbonViewInfo

        Public Sub New(ByVal ribbon As RibbonControl)
            MyBase.New(ribbon)
        End Sub
        Protected Overrides Function CreateHeaderInfo() As RibbonPageHeaderViewInfo
            Return New RibbonPageHeaderViewInfoEx(Me)
        End Function
        Protected Overrides Function CreateCaptionInfo() As RibbonCaptionViewInfo
            Return New RibbonCaptionViewInfoEx(Me)
        End Function
        Protected Overrides ReadOnly Property UniversalOfficeApplicationButtonLeftIndent() As Integer
            Get
                Return MyBase.UniversalOfficeApplicationButtonLeftIndent + Caption.ContentBounds.X
            End Get
        End Property
        Protected Overrides Function CalcMinHeight() As Integer
            Return MyBase.CalcMinHeight() - Caption.Bounds.Height + TopIndent + TopIndent
        End Function
        Public Shared ReadOnly Property TopIndent() As Integer
            Get
                Return 5
            End Get
        End Property
    End Class

    Public Class RibbonCaptionViewInfoEx
        Inherits RibbonCaptionViewInfo

        Public Sub New(ByVal info As RibbonViewInfo)
            MyBase.New(info)
        End Sub
        Protected Overrides Function CreateCaptionPainter() As ObjectPainter
            Return New RibbonCaptionPainterEx()
        End Function
    End Class

    Public Class RibbonPageHeaderViewInfoEx
        Inherits RibbonPageHeaderViewInfo

        Public Sub New(ByVal info As RibbonViewInfo)
            MyBase.New(info)
        End Sub
        Protected Overrides Function CalcBounds() As Rectangle
            Dim r As Rectangle = MyBase.CalcBounds()
            Dim res As New Rectangle(r.X, RibbonViewInfoEx.TopIndent, ViewInfo.Caption.ContentBounds.Width, r.Height + RibbonViewInfoEx.TopIndent)
            If Ribbon.FindForm() Is Nothing OrElse Ribbon.FindForm().WindowState <> FormWindowState.Maximized Then
                Return res
            End If
            res.Y += RibbonViewInfoEx.TopIndent
            Return res
        End Function
        Protected Overrides Function CalcAvailableHeaderRect() As Rectangle
            Dim rect As Rectangle = MyBase.CalcAvailableHeaderRect()
            rect.Width -= PageHeaderItemsBounds.Width
            Return rect
        End Function
    End Class

    Public Class RibbonCaptionPainterEx
        Inherits RibbonCaptionPainter

        Public Overrides Sub DrawCaption(ByVal e As ObjectInfoArgs)
        End Sub
        Protected Overrides Sub DrawPageHeaderBackground(ByVal e As ObjectInfoArgs, ByVal upperPart As Boolean)
        End Sub
    End Class
End Namespace
