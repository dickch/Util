﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Optimization;

namespace dickch.Util.Web
{

    //http://stackoverflow.com/a/19765418
    public class CssRewriteUrlTransformWrapper : IItemTransform
    {
        public string Process(string includedVirtualPath, string input)
        {
            return new CssRewriteUrlTransform().Process("~" + VirtualPathUtility.ToAbsolute(includedVirtualPath), input);
        }
    }
}
