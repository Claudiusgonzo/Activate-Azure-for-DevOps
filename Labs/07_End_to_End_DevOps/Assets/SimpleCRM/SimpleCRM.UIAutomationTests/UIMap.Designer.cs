﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace SimpleCRM.UIAutomationTests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// NavigateMenuItems - Use 'NavigateMenuItemsParams' to pass parameters into this method.
        /// </summary>
        public void NavigateMenuItems(string webAppUrl)
        {
            #region Variable Declarations
            HtmlHyperlink uIProductsHyperlink = this.UIBingInternetExplorerWindow.UIHomePageCRMDocument.UIProductsHyperlink;
            HtmlHyperlink uICustomersHyperlink = this.UIBingInternetExplorerWindow.UIIndexCRMDocument.UICustomersHyperlink;
            HtmlHyperlink uIRegisterHyperlink = this.UIBingInternetExplorerWindow.UIIndexCRMDocument1.UIRegisterHyperlink;
            HtmlHyperlink uILoginHyperlink = this.UIBingInternetExplorerWindow.UIRegisterCRMDocument.UILoginHyperlink;
            HtmlHyperlink uICRMHyperlink = this.UIBingInternetExplorerWindow.UILoginCRMDocument.UICRMHyperlink;
            #endregion

            // Go to web page 'http://localhost:5555/' using new browser instance

            //this.UIBingInternetExplorerWindow.LaunchUrl(new System.Uri(this.NavigateMenuItemsParams.UIBingInternetExplorerWindowUrl));

            this.UIBingInternetExplorerWindow.LaunchUrl(new System.Uri(webAppUrl));
            // Click 'Products' link
            Mouse.Click(uIProductsHyperlink);

            // Click 'Customers' link
            Mouse.Click(uICustomersHyperlink);

            // Click 'Register' link
            //Mouse.Click(uIRegisterHyperlink);

            // Click 'Log in' link
            //Mouse.Click(uILoginHyperlink);

            // Click 'CRM' link
            Mouse.Click(uICRMHyperlink);
        }
        
        #region Properties
        public virtual NavigateMenuItemsParams NavigateMenuItemsParams
        {
            get
            {
                if ((this.mNavigateMenuItemsParams == null))
                {
                    this.mNavigateMenuItemsParams = new NavigateMenuItemsParams();
                }
                return this.mNavigateMenuItemsParams;
            }
        }
        
        public UIBingInternetExplorerWindow UIBingInternetExplorerWindow
        {
            get
            {
                if ((this.mUIBingInternetExplorerWindow == null))
                {
                    this.mUIBingInternetExplorerWindow = new UIBingInternetExplorerWindow();
                }
                return this.mUIBingInternetExplorerWindow;
            }
        }
        #endregion
        
        #region Fields
        private NavigateMenuItemsParams mNavigateMenuItemsParams;
        
        private UIBingInternetExplorerWindow mUIBingInternetExplorerWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'NavigateMenuItems'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class NavigateMenuItemsParams
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'http://localhost:5555/' using new browser instance
        /// </summary>
        public string UIBingInternetExplorerWindowUrl = "http://localhost:5555/";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIBingInternetExplorerWindow : BrowserWindow
    {
        
        public UIBingInternetExplorerWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Bing";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Bing");
            this.WindowTitles.Add("Home Page - CRM");
            this.WindowTitles.Add("Index - CRM");
            this.WindowTitles.Add("Register - CRM");
            this.WindowTitles.Add("Log in - CRM");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHomePageCRMDocument UIHomePageCRMDocument
        {
            get
            {
                if ((this.mUIHomePageCRMDocument == null))
                {
                    this.mUIHomePageCRMDocument = new UIHomePageCRMDocument(this);
                }
                return this.mUIHomePageCRMDocument;
            }
        }
        
        public UIIndexCRMDocument UIIndexCRMDocument
        {
            get
            {
                if ((this.mUIIndexCRMDocument == null))
                {
                    this.mUIIndexCRMDocument = new UIIndexCRMDocument(this);
                }
                return this.mUIIndexCRMDocument;
            }
        }
        
        public UIIndexCRMDocument1 UIIndexCRMDocument1
        {
            get
            {
                if ((this.mUIIndexCRMDocument1 == null))
                {
                    this.mUIIndexCRMDocument1 = new UIIndexCRMDocument1(this);
                }
                return this.mUIIndexCRMDocument1;
            }
        }
        
        public UIRegisterCRMDocument UIRegisterCRMDocument
        {
            get
            {
                if ((this.mUIRegisterCRMDocument == null))
                {
                    this.mUIRegisterCRMDocument = new UIRegisterCRMDocument(this);
                }
                return this.mUIRegisterCRMDocument;
            }
        }
        
        public UILoginCRMDocument UILoginCRMDocument
        {
            get
            {
                if ((this.mUILoginCRMDocument == null))
                {
                    this.mUILoginCRMDocument = new UILoginCRMDocument(this);
                }
                return this.mUILoginCRMDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHomePageCRMDocument mUIHomePageCRMDocument;
        
        private UIIndexCRMDocument mUIIndexCRMDocument;
        
        private UIIndexCRMDocument1 mUIIndexCRMDocument1;
        
        private UIRegisterCRMDocument mUIRegisterCRMDocument;
        
        private UILoginCRMDocument mUILoginCRMDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIHomePageCRMDocument : HtmlDocument
    {
        
        public UIHomePageCRMDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home Page - CRM";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:5555/";
            this.WindowTitles.Add("Home Page - CRM");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIProductsHyperlink
        {
            get
            {
                if ((this.mUIProductsHyperlink == null))
                {
                    this.mUIProductsHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIProductsHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIProductsHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIProductsHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIProductsHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Products";
                    this.mUIProductsHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Products";
                    this.mUIProductsHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIProductsHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:5555/Products";
                    this.mUIProductsHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIProductsHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Products\"";
                    this.mUIProductsHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "3";
                    this.mUIProductsHyperlink.WindowTitles.Add("Home Page - CRM");
                    #endregion
                }
                return this.mUIProductsHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIProductsHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIIndexCRMDocument : HtmlDocument
    {
        
        public UIIndexCRMDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Index - CRM";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Products";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:5555/Products";
            this.WindowTitles.Add("Index - CRM");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UICustomersHyperlink
        {
            get
            {
                if ((this.mUICustomersHyperlink == null))
                {
                    this.mUICustomersHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUICustomersHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUICustomersHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUICustomersHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUICustomersHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Customers";
                    this.mUICustomersHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Customers";
                    this.mUICustomersHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUICustomersHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:5555/Customers";
                    this.mUICustomersHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUICustomersHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Customers\"";
                    this.mUICustomersHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "4";
                    this.mUICustomersHyperlink.WindowTitles.Add("Index - CRM");
                    #endregion
                }
                return this.mUICustomersHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUICustomersHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIIndexCRMDocument1 : HtmlDocument
    {
        
        public UIIndexCRMDocument1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Index - CRM";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Customers";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:5555/Customers";
            this.WindowTitles.Add("Index - CRM");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIRegisterHyperlink
        {
            get
            {
                if ((this.mUIRegisterHyperlink == null))
                {
                    this.mUIRegisterHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIRegisterHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "registerLink";
                    this.mUIRegisterHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIRegisterHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIRegisterHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Register";
                    this.mUIRegisterHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Account/Register";
                    this.mUIRegisterHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIRegisterHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:5555/Account/Register";
                    this.mUIRegisterHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIRegisterHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "id=\"registerLink\" href=\"/Account/Registe";
                    this.mUIRegisterHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "5";
                    this.mUIRegisterHyperlink.WindowTitles.Add("Index - CRM");
                    #endregion
                }
                return this.mUIRegisterHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIRegisterHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIRegisterCRMDocument : HtmlDocument
    {
        
        public UIRegisterCRMDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Register - CRM";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Account/Register";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:5555/Account/Register";
            this.WindowTitles.Add("Register - CRM");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UILoginHyperlink
        {
            get
            {
                if ((this.mUILoginHyperlink == null))
                {
                    this.mUILoginHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUILoginHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "loginLink";
                    this.mUILoginHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUILoginHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUILoginHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Log in";
                    this.mUILoginHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Account/Login";
                    this.mUILoginHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUILoginHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:5555/Account/Login";
                    this.mUILoginHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUILoginHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "id=\"loginLink\" href=\"/Account/Login\"";
                    this.mUILoginHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "6";
                    this.mUILoginHyperlink.WindowTitles.Add("Register - CRM");
                    #endregion
                }
                return this.mUILoginHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUILoginHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UILoginCRMDocument : HtmlDocument
    {
        
        public UILoginCRMDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Log in - CRM";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Account/Login";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:5555/Account/Login";
            this.WindowTitles.Add("Log in - CRM");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UICRMHyperlink
        {
            get
            {
                if ((this.mUICRMHyperlink == null))
                {
                    this.mUICRMHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUICRMHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUICRMHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUICRMHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUICRMHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "CRM";
                    this.mUICRMHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/";
                    this.mUICRMHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUICRMHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:5555/";
                    this.mUICRMHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "navbar-brand";
                    this.mUICRMHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"navbar-brand\" href=\"/\"";
                    this.mUICRMHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUICRMHyperlink.WindowTitles.Add("Log in - CRM");
                    #endregion
                }
                return this.mUICRMHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUICRMHyperlink;
        #endregion
    }
}
