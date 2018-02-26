Namespace OfficeUniversalExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.formAssistant1 = New DevExpress.XtraBars.FormAssistant()
            Me.ribbonControl1 = New OfficeUniversalExample.RibbonControlEx()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
            Me.ribbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barButtonItem3, Me.barButtonItem2, Me.barButtonItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 13
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.ribbonPageCategory1})
            Me.ribbonControl1.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
            Me.ribbonControl1.PageHeaderItemLinks.Add(Me.barButtonItem1)
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1, Me.ribbonPage2, Me.ribbonPage3})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal
            Me.ribbonControl1.Size = New System.Drawing.Size(668, 56)
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "Item1"
            Me.barButtonItem3.Glyph = (DirectCast(resources.GetObject("barButtonItem3.Glyph"), System.Drawing.Image))
            Me.barButtonItem3.Id = 7
            Me.barButtonItem3.LargeGlyph = (DirectCast(resources.GetObject("barButtonItem3.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "Item3"
            Me.barButtonItem2.Glyph = (DirectCast(resources.GetObject("barButtonItem2.Glyph"), System.Drawing.Image))
            Me.barButtonItem2.Id = 8
            Me.barButtonItem2.LargeGlyph = (DirectCast(resources.GetObject("barButtonItem2.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "barButtonItem1"
            Me.barButtonItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barButtonItem1.Glyph = (DirectCast(resources.GetObject("barButtonItem1.Glyph"), System.Drawing.Image))
            Me.barButtonItem1.Id = 12
            Me.barButtonItem1.LargeGlyph = (DirectCast(resources.GetObject("barButtonItem1.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' ribbonPageCategory1
            ' 
            Me.ribbonPageCategory1.Name = "ribbonPageCategory1"
            Me.ribbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage4})
            Me.ribbonPageCategory1.Text = "ribbonPageCategory1"
            ' 
            ' ribbonPage4
            ' 
            Me.ribbonPage4.Name = "ribbonPage4"
            Me.ribbonPage4.Text = "Category"
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Page1"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem3)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem2)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
            ' 
            ' ribbonPage2
            ' 
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "Page2"
            ' 
            ' ribbonPage3
            ' 
            Me.ribbonPage3.Name = "ribbonPage3"
            Me.ribbonPage3.Text = "Page3"
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(668, 411)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Form1"
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private formAssistant1 As DevExpress.XtraBars.FormAssistant
        Private ribbonControl1 As RibbonControlEx
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
        Private ribbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

