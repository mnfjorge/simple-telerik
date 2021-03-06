// (c) Copyright 2002-2010 Telerik 
// This source is subject to the GNU General Public License, version 2
// See http://www.gnu.org/licenses/gpl-2.0.html. 
// All other rights reserved.

namespace Telerik.Web.Mvc.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public interface IPropertyCache
    {
        IEnumerable<PropertyInfo> GetProperties(Type type);

        IEnumerable<PropertyInfo> GetReadOnlyProperties(Type type);

        IEnumerable<PropertyInfo> GetWriteOnlyProperties(Type type);
    }
}