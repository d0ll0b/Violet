﻿using ShapeLib.VShape;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace violet
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();

            try
            {
                //Check();
                IList<ShapeObj> ret = shapeLib.SupportedShape(Check);

                foreach (ShapeObj obj in ret)
                {

                    Construt(obj);


                }
            }catch(Exception em)
            {
                MessageBox.Show(em.ToString());

            }
   
        }

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.selBtn = this.Factory.CreateRibbonButton();
            this.StrokeThickness = this.Factory.CreateRibbonMenu();
            this.px1 = this.Factory.CreateRibbonButton();
            this.px3 = this.Factory.CreateRibbonButton();
            this.px5 = this.Factory.CreateRibbonButton();
            this.px8 = this.Factory.CreateRibbonButton();
            this.bgp = this.Factory.CreateRibbonButton();
            this.button1 = this.Factory.CreateRibbonButton();
            this.Undo = this.Factory.CreateRibbonButton();
            this.redo = this.Factory.CreateRibbonButton();
            this.circle_btn = this.Factory.CreateRibbonButton();
            this.rectangle_btn = this.Factory.CreateRibbonButton();
            this.line_btn = this.Factory.CreateRibbonButton();
            this.Curve = this.Factory.CreateRibbonButton();
            this.red_btn = this.Factory.CreateRibbonButton();
            this.orange_btn = this.Factory.CreateRibbonButton();
            this.yellow_btn = this.Factory.CreateRibbonButton();
            this.blue_btn = this.Factory.CreateRibbonButton();
            this.violet = this.Factory.CreateRibbonButton();
            this.green_btn = this.Factory.CreateRibbonButton();
            this.black_btn = this.Factory.CreateRibbonButton();
            this.gray = this.Factory.CreateRibbonButton();
            this.white_btn = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "Violet";
            this.tab1.Name = "tab1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.selBtn);
            this.group2.Items.Add(this.StrokeThickness);
            this.group2.Items.Add(this.bgp);
            this.group2.Items.Add(this.button1);
            this.group2.Items.Add(this.Undo);
            this.group2.Items.Add(this.redo);
            this.group2.Label = "Other";
            this.group2.Name = "group2";
            // 
            // selBtn
            // 
            this.selBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.selBtn.Image = ((System.Drawing.Image)(resources.GetObject("selBtn.Image")));
            this.selBtn.Label = "Select";
            this.selBtn.Name = "selBtn";
            this.selBtn.ShowImage = true;
            this.selBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.selBtn_Click);
            // 
            // StrokeThickness
            // 
            this.StrokeThickness.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.StrokeThickness.Image = global::violet.Properties.Resources.strokes;
            this.StrokeThickness.Items.Add(this.px1);
            this.StrokeThickness.Items.Add(this.px3);
            this.StrokeThickness.Items.Add(this.px5);
            this.StrokeThickness.Items.Add(this.px8);
            this.StrokeThickness.Label = "Strokes";
            this.StrokeThickness.Name = "StrokeThickness";
            this.StrokeThickness.ShowImage = true;
            // 
            // px1
            // 
            this.px1.Image = global::violet.Properties.Resources._1px;
            this.px1.Label = "1 px";
            this.px1.Name = "px1";
            this.px1.ShowImage = true;
            this.px1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.px1_Click);
            // 
            // px3
            // 
            this.px3.Image = global::violet.Properties.Resources._3px1;
            this.px3.Label = "3 px";
            this.px3.Name = "px3";
            this.px3.ShowImage = true;
            this.px3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.px3_Click);
            // 
            // px5
            // 
            this.px5.Image = global::violet.Properties.Resources._5px;
            this.px5.Label = "5 px";
            this.px5.Name = "px5";
            this.px5.ShowImage = true;
            this.px5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.px5_Click);
            // 
            // px8
            // 
            this.px8.Image = global::violet.Properties.Resources._8px;
            this.px8.Label = "8 px";
            this.px8.Name = "px8";
            this.px8.ShowImage = true;
            this.px8.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.px8_Click);
            // 
            // bgp
            // 
            this.bgp.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.bgp.Image = global::violet.Properties.Resources.point11;
            this.bgp.Label = "Background Point";
            this.bgp.Name = "bgp";
            this.bgp.ShowImage = true;
            this.bgp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bgp_Click);
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Label = "Clear";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.clear_Click);
            // 
            // Undo
            // 
            this.Undo.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Undo.Image = ((System.Drawing.Image)(resources.GetObject("Undo.Image")));
            this.Undo.Label = "Undo";
            this.Undo.Name = "Undo";
            this.Undo.ShowImage = true;
            this.Undo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.undo_Click);
            // 
            // redo
            // 
            this.redo.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.redo.Image = ((System.Drawing.Image)(resources.GetObject("redo.Image")));
            this.redo.Label = "Redo";
            this.redo.Name = "redo";
            this.redo.ShowImage = true;
            this.redo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.redo_Click);
            // 
            // circle_btn
            // 
            this.circle_btn.Label = "";
            this.circle_btn.Name = "circle_btn";
            // 
            // rectangle_btn
            // 
            this.rectangle_btn.Label = "";
            this.rectangle_btn.Name = "rectangle_btn";
            // 
            // line_btn
            // 
            this.line_btn.Label = "";
            this.line_btn.Name = "line_btn";
            // 
            // Curve
            // 
            this.Curve.Label = "";
            this.Curve.Name = "Curve";
            // 
            // red_btn
            // 
            this.red_btn.Image = global::violet.Properties.Resources.red;
            this.red_btn.Label = " ";
            this.red_btn.Name = "red_btn";
            this.red_btn.ShowImage = true;
            this.red_btn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.red_btn_Click);
            // 
            // orange_btn
            // 
            this.orange_btn.Image = global::violet.Properties.Resources.orange;
            this.orange_btn.Label = " ";
            this.orange_btn.Name = "orange_btn";
            this.orange_btn.ShowImage = true;
            this.orange_btn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button7_Click);
            // 
            // yellow_btn
            // 
            this.yellow_btn.Image = global::violet.Properties.Resources.yellow1;
            this.yellow_btn.Label = " ";
            this.yellow_btn.Name = "yellow_btn";
            this.yellow_btn.ShowImage = true;
            this.yellow_btn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.yellow_btn_Click);
            // 
            // blue_btn
            // 
            this.blue_btn.Image = global::violet.Properties.Resources.blue;
            this.blue_btn.Label = " ";
            this.blue_btn.Name = "blue_btn";
            this.blue_btn.ShowImage = true;
            this.blue_btn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.blue_btn_Click);
            // 
            // violet
            // 
            this.violet.Image = ((System.Drawing.Image)(resources.GetObject("violet.Image")));
            this.violet.Label = " ";
            this.violet.Name = "violet";
            this.violet.ShowImage = true;
            this.violet.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.violet_Click);
            // 
            // green_btn
            // 
            this.green_btn.Image = global::violet.Properties.Resources.green;
            this.green_btn.Label = " ";
            this.green_btn.Name = "green_btn";
            this.green_btn.ShowImage = true;
            this.green_btn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.green_btn_Click);
            // 
            // black_btn
            // 
            this.black_btn.Image = global::violet.Properties.Resources.black;
            this.black_btn.Label = " ";
            this.black_btn.Name = "black_btn";
            this.black_btn.ShowImage = true;
            this.black_btn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.black_btn_Click);
            // 
            // gray
            // 
            this.gray.Image = ((System.Drawing.Image)(resources.GetObject("gray.Image")));
            this.gray.Label = " ";
            this.gray.Name = "gray";
            this.gray.ShowImage = true;
            this.gray.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.gray_Click);
            // 
            // white_btn
            // 
            this.white_btn.Image = global::violet.Properties.Resources.white1;
            this.white_btn.Label = " ";
            this.white_btn.Name = "white_btn";
            this.white_btn.ShowImage = true;
            this.white_btn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.white_btn_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton circle_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton rectangle_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton line_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bgp;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Curve;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton red_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton orange_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton yellow_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton green_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton black_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton blue_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton white_btn;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu StrokeThickness;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton px1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton px3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton px5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton selBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton redo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Undo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton violet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton gray;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton px8;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
