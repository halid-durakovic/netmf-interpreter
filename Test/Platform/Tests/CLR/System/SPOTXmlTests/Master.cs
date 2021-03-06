////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using Microsoft.SPOT.Platform.Test;

namespace Microsoft.SPOT.Platform.Tests
{
    public class Master_SPOTxmlTests
    {
        public static void Main()
        {
            string[] args = 
            { 
                "SPOTXmlTests",
                "XmlBasicTests",
                "RandomXmlTests",
                "XmlNameTableTests",
            };

            MFTestRunner runner = new MFTestRunner(args);
        }
    }
}