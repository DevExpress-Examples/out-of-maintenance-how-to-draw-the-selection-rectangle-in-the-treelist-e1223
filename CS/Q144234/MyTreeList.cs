using DevExpress.XtraEditors;
using System.Drawing;
using System.Windows.Forms;
using System;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.Utils.Drawing;

namespace DXSample {
    public class MyTreeList : TreeList {
        public MyTreeList()
            : base() {
            OptionsBehavior.ShowEditorOnMouseUp = true;
            OptionsSelection.EnableAppearanceFocusedCell = false;
            OptionsSelection.MultiSelect = true;
            OptionsView.FocusRectStyle = DrawFocusRectStyle.None;
            PaintEx += OnPaintEx;
        }

        void OnPaintEx(object sender, TreeListPaintEventArgs e) {
            if(selectedRect == Rectangle.Empty) return;
            e.Cache.DrawRectangle(Pens.Blue, selectedRect);
            using(SolidBrush selectedBrush = new SolidBrush(Color.FromArgb(50, Color.Blue)))
                e.Cache.FillRectangle(selectedBrush, selectedRect);
        }

        private Rectangle selectedRect = Rectangle.Empty;
        private Rectangle dragRect = Rectangle.Empty;


        protected override void OnMouseDown(MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                dragRect.X = e.X - SystemInformation.DragSize.Width / 2;
                dragRect.Y = e.Y - SystemInformation.DragSize.Height / 2;
                dragRect.Size = SystemInformation.DragSize;
                selectedRect.Location = e.Location;
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e) {
            if(e.Button == MouseButtons.Left && selectedRect != Rectangle.Empty) {
                Selection.Clear();
                for(int i = 0; i < VisibleNodesCount; i++) {
                    TreeListNode node = GetNodeByVisibleIndex(i);
                    if(ViewInfo.RowsInfo[node].Bounds.IntersectsWith(selectedRect))
                        node.Selected = true;
                }
                selectedRect = Rectangle.Empty;
                dragRect = Rectangle.Empty;
            }
            base.OnMouseUp(e);
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e) {
            if(e.Button == MouseButtons.Left && dragRect != Rectangle.Empty) {
                if(!dragRect.Contains(e.Location)) {
                    if(Selection.Count > 0) Selection.Clear();
                    Rectangle tmp = selectedRect;
                    if(e.X <= selectedRect.X) {
                        selectedRect.X = e.X;
                        selectedRect.Width += tmp.Right - selectedRect.Right;
                    }
                    else {
                        selectedRect.Width = e.X - selectedRect.X;
                    }

                    if(e.Y <= selectedRect.Y) {
                        selectedRect.Y = e.Y;
                        selectedRect.Height += tmp.Bottom - selectedRect.Bottom;
                    }
                    else {
                        selectedRect.Height = e.Y - selectedRect.Y;
                    }
                    Invalidate();
                }
            }
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e) {
            if(dragRect != Rectangle.Empty) {
                dragRect = Rectangle.Empty;
                selectedRect = Rectangle.Empty;
            }
            base.OnMouseLeave(e);
        }
        protected override void Dispose(bool disposing) {
            if(disposing) {
                PaintEx -= OnPaintEx;
            }
            base.Dispose(disposing);
        }
    }
}