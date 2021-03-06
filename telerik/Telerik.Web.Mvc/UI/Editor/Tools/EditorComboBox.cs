﻿// (c) Copyright 2002-2010 Telerik 
// This source is subject to the GNU General Public License, version 2
// See http://www.gnu.org/licenses/gpl-2.0.html. 
// All other rights reserved.

namespace Telerik.Web.Mvc.UI
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Telerik.Web.Mvc.Extensions;
    using Telerik.Web.Mvc.UI.Html;
    

    public class EditorComboBox : IEditorListTool, IComboBoxRenderable
    {
        public EditorComboBox(string identifier, IList<DropDownItem> items)
        {
            Items = items;
            Identifier = identifier.ToCamelCase();
            HtmlAttributes = new Dictionary<string, object>() { { "class", "t-" + Identifier } };
        }

        public string Identifier { get; private set; }

        public ViewContext ViewContext { get; private set; }

        public IDictionary<string, object> HtmlAttributes { get; private set; }

        string IDropDownRenderable.Id { get { return ""; } }
        string IDropDownRenderable.Name { get { return ""; } }
        IDictionary<string, object> IComboBoxRenderable.InputHtmlAttributes { get { return new Dictionary<string, object>(); } }

        public IList<DropDownItem> Items
        {
            get;
            private set;
        }

        public int SelectedIndex { get; set; }

        public IHtmlBuilder CreateHtmlBuilder()
        {
            return new EditorComboBoxHtmlBuilder(this);
        }
    }
}
