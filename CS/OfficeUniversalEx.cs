using DevExpress.Skins;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Painters;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Drawing;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OfficeUniversalExample {
    public class RibbonControlEx : RibbonControl {
        protected override DevExpress.XtraBars.Ribbon.ViewInfo.RibbonViewInfo CreateViewInfo() {
            return new RibbonViewInfoEx(this);
        }
    }

    public class RibbonViewInfoEx : RibbonViewInfo {
        public RibbonViewInfoEx(RibbonControl ribbon) : base(ribbon) { }
        protected override RibbonPageHeaderViewInfo CreateHeaderInfo() {
            return new RibbonPageHeaderViewInfoEx(this);
        }
        protected override RibbonCaptionViewInfo CreateCaptionInfo() {
            return new RibbonCaptionViewInfoEx(this);
        }
        protected override int UniversalOfficeApplicationButtonLeftIndent {
            get { return base.UniversalOfficeApplicationButtonLeftIndent + Caption.ContentBounds.X; }
        }
        protected override int CalcMinHeight() {
            return base.CalcMinHeight() - Caption.Bounds.Height + TopIndent + TopIndent;
        }
        public static int TopIndent { get { return 5; } }
    }

    public class RibbonCaptionViewInfoEx : RibbonCaptionViewInfo {
        public RibbonCaptionViewInfoEx(RibbonViewInfo info) : base(info) { }
        protected override ObjectPainter CreateCaptionPainter() {
            return new RibbonCaptionPainterEx();
        }
    }

    public class RibbonPageHeaderViewInfoEx : RibbonPageHeaderViewInfo {
        public RibbonPageHeaderViewInfoEx(RibbonViewInfo info) : base(info) { }
        protected override Rectangle CalcBounds() {
            Rectangle r = base.CalcBounds();
            Rectangle res = new Rectangle(r.X, RibbonViewInfoEx.TopIndent, ViewInfo.Caption.ContentBounds.Width, r.Height + RibbonViewInfoEx.TopIndent);
            if(Ribbon.FindForm() == null || Ribbon.FindForm().WindowState != FormWindowState.Maximized) return res;
            res.Y += RibbonViewInfoEx.TopIndent;
            return res;
        }
        protected override Rectangle CalcAvailableHeaderRect() {
            Rectangle rect = base.CalcAvailableHeaderRect();
            rect.Width -= PageHeaderItemsBounds.Width;
            return rect;
        }
    }

    public class RibbonCaptionPainterEx : RibbonCaptionPainter {
        public override void DrawCaption(ObjectInfoArgs e) { }
        protected override void DrawPageHeaderBackground(ObjectInfoArgs e, bool upperPart) { }
    }
}
