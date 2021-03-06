﻿// // //------------------------------------------------------------------------------------------------- 
// // // <copyright file="LoaderResults.cs" company="Microsoft Corporation">
// // // Copyright (c) Microsoft Corporation. All rights reserved.
// // // </copyright>
// // //-------------------------------------------------------------------------------------------------

namespace CubeServer.DataAccess
{
    using System.Collections.Generic;
    using CubeServer.Model;

    public class LoaderResults
    {
        public LoaderException[] Errors { get; set; }
        public IDictionary<string, Set> Sets { get; set; }
        public bool Success { get; set; }
    }
}