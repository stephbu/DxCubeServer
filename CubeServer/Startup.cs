﻿// // //------------------------------------------------------------------------------------------------- 
// // // <copyright file="Startup.cs" company="Microsoft Corporation">
// // // Copyright (c) Microsoft Corporation. All rights reserved.
// // // </copyright>
// // //-------------------------------------------------------------------------------------------------

using CubeServer;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace CubeServer
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}