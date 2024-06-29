using System.ComponentModel;

namespace JsxClassLibrary
{


    /// <summary>
    /// Custom jSilvestri.com 2024 Web API Demo Constants class for handling all product information across 
    /// the jSilvestri.com 2024 Web API Demo Collection projects.
    /// <para>
    /// ⚠ IMPORTANT ⚠
    /// </para>
    /// <para>
    /// This project is currently in Phase <c>1</c> of <c>4</c>, where deliberate "minimum viable product" 
    /// decisions are made to demonstrate the project's evolution across phases. It is important to note that 
    /// storing sensitive data in variables (of most kinds) is not secure and should not be common practice.
    /// </para>
    /// <para>
    /// This project will not follow the common "for simplicity's sake" approach often justified by developers 
    /// when they provide code as a form of volunteering. Such practices go against the purpose of why I began 
    /// developing these cross-platform, cross-resource applications. It is concerning that such bad practices 
    /// are often encouraged across various projects and tech stacks, using both client-side and server-side 
    /// approaches.
    /// </para>
    /// <para>
    /// Using UserSecret files, app settings, and strongly typing static variables in your applications can 
    /// expose them to security risks. At a minimum, consider using a cloud secure vault or encryption when 
    /// re-using this code in your projects.
    /// </para>
    /// <para>
    /// One of the primary reasons for the existence of this class, as well as its elaborate uses, is to avoid 
    /// enforcing specific database uses, cloud storage, local storage solutions, and other decisions or 
    /// implementations that increase setup overhead. This project will increasingly use sealed classes, internal 
    /// declarations, and more secure practices as we progress through the phases.
    /// </para>
    /// </summary>
    public static class JsxConstants
    {
       
        /// <summary>
        /// Custom jSilvestri.com 2024 Web API Demo Constants class used to handle all jSilvestri.com 2024
        /// legal requirements, across all projects included in the jSilvestri 2024 Web API Demo 
        /// Collection projects, such as copyright branding, trademark branding, contact information
        /// and more.
        /// </summary>
        public static class JsxLegalParts
        {
            public const string JsxCopyRight = "Copyright © 2024 All Rights Reserved by Jason Silvestri";
        }

        /// <summary>
        /// Custom jSilvestri.com 2024 Web API Demo Constants class used to handle all jSilvestri.com 2024
        /// brand requirements, across all projects included in the jSilvestri 2024 Web API Demo 
        /// Collection projects.
        /// </summary>
        public static class JsxBrand
        {
            public const string JsxBrandName = "jSilvestri.com";
            public const string JsxBrandNameAppDemos = "jSilvestri.com 2024 App Demos";
            public const string JsxBrandNameGitHubs = "jSilvestri.com GitHubs";
            public const string JsxBrandNameEncoded = "jSilvestri.com";
            public const string JsxBrandNameAndJasonX = "jSilvestri.com - featuring jSX 2024 Web Application";
            public const string JsxBrandNameAndJasonXEncoded = "jSilvestri.com - featuring jSX 2024 Web Application";
        }

        /// <summary>
        /// Custom jSilvestri.com 2024 Web API Demo Constants class used to handle all jSilvestri.com 2024
        /// Web API Demo Product information, across all projects included in the jSilvestri 2024 Web API Demo 
        /// Collection projects.
        /// </summary>
        public static class JsxAppProjects
        {

                /// <summary>
                /// Custom jSilvestri.com jSX Demo App Constants class used to handle 
                /// all Web API Demo Product versions, across all projects,
                /// included the jSilvestri 2024 jSX Demo Collection projects.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// These static constants will eventually be replaced with the versions produced
                /// by each application dynamically via version control. 
                /// </para>
                /// </summary>
                public static class ProductVersions
                {

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Constants property used to 
                    /// handle all Web API Demo Default Product versions.
                    /// </summary>
                    public const string Default = "v2024.0.1";

                    public const string JsxMainProjectName = Default;

                    public const string JsxAngularJsProject = Default;

                    public const string JsxBlazorProject = Default;

                    public const string JsxReactJsProject = Default;

                    public const string JsxVueProject = Default;

                    public const string JsxMAUIProject = Default;

                    public const string JsxClassLibraryProject = Default;

                    public const string JsxWebApiProject = Default;

                    public const string JsxSharedResourcesProject = Default;
                }

                /// <summary>
                /// Custom jSilvestri.com 2024 Web API Demo Constants class used to handle all jSilvestri.com 2024
                /// Web API Demo Product names, across all projects included in the jSilvestri 2024 Web API Demo 
                /// Collection projects.
                /// </summary>
                public static class Names
                {

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Constants class used to handle all jSilvestri.com 2024
                    /// Web API Demo Default Product names.
                    /// </summary>
                    public static class Default
                    {
                        public const string JsxMainProjectName = "jSilvestri.com 2024 jSX Collection Project";

                        public const string JsxAngularJsProject = "jSX Angular Asp.NET Core Web API Demo Project";

                        public const string JsxBlazorProject = "jSX Blazor Asp.NET Core Web API Demo Project";

                        public const string JsxReactJsProject = "jSX React Asp.NET Core Web API Demo Project";

                        public const string JsxVueProject = "jSX Vue Asp.NET Core Web API Demo Project";

                        public const string JsxMAUIProject = "jSX .NET MAUI Demo Project";

                        public const string JsxClassLibraryProject = "jSX Asp.NET Core Class Library Project";

                        public const string JsxWebApiProject = "jSX Asp.NET Core WebAPI Project";

                        public const string JsxSharedResourcesProject = "jSX Asp.NET Shared Resources Project";
                    }


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Constants class used to handle all jSilvestri.com 2024
                    /// Web API Demo Short Product names.
                    /// </summary>
                    public static class Shorts
                    {
                        public const string JsxMainProjectName = "jSX 2024 Demo Collection";

                        public const string JsxAngularJsProject = "jSX Angular Web API Demo";

                        public const string JsxBlazorProject = "jSX Blazor Web API Demo";

                        public const string JsxReactJsProject = "jSX React Web API Demo";

                        public const string JsxVueProject = "jSX Vue Web API Demo";

                        public const string JsxMAUIProject = "jSX .NET MAUI Demo";

                        public const string JsxClassLibraryProject = "jSX Class Library";

                        public const string JsxWebApiProject = "jSX WebAPI";

                        public const string JsxSharedResourcesProject = "jSX Shared Resources";
                    }
                }

                /// <summary>
                /// Custom jSilvestri.com 2024 Web API Demo Constants class used to handle all jSilvestri.com 2024
                /// Web API Demo Product descriptions, across all projects included in the jSilvestri 2024 Web API Demo 
                /// Collection projects.
                /// </summary>
                public static class Descriptions
                {

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Constants class used to handle all jSilvestri.com 2024
                    /// Web API Demo Product default descriptions, across all projects included in the jSilvestri 2024 Web API Demo 
                    /// Collection projects.
                    /// </summary>
                    public static class Default
                    {
                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxMainProject = "The jSilvestri.com 2024 Web API Demo Collection is a comprehensive suite of demonstration projects designed to showcase the integration and usage of various front-end frameworks (Angular, React, Vue, Blazor) with ASP.NET Core 8 Web API. This collection serves as a learning resource and reference for developers looking to understand and implement modern web application architectures using these technologies.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxClassLibrary = "The jSX Class Library Project is a project containing reusable .NET class libraries that provide common functionalities and utilities used across different web applications within the jSilvestri.com BETA v 2024 Web API Demo Collection. This project aims to promote code reuse and maintainability by centralizing shared logic in a single location.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxWebApiProject = "The jSX Web API Project is a custom project that implements an ASP.NET Core 8 Web API, serving as the back-end for the various web applications in the jSilvestri.com BETA v 2024 Web API Demo Collection. It provides RESTful API endpoints for data retrieval and manipulation, showcasing best practices in API development and integration with front-end frameworks.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxSharedResources = "The jSX Shared Resources Project is a project that contains shared resources such as images, styles, and scripts used across multiple web applications in the jSilvestri.com BETA v 2024 Web API Demo Collection. This project aims to maintain consistency and avoid duplication of resources across different projects.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxAngularJsProject = "The jSX Angular Core Web API Demo Project is a demonstration project showcasing how to build a web application using Angular and ASP.NET Core 8 Web API. It highlights the integration of Angular for the client-side with ASP.NET Core for the server-side, providing a comprehensive example of a modern web application stack.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxBlazorProject = "The jSX Blazor Server Core Web API Demo Project is a demonstration project that illustrates how to construct a web application using Blazor Server and ASP.NET Core 8 Web API. This project highlights the use of Blazor for building interactive web UIs with C# and ASP.NET Core for providing powerful server-side capabilities.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxReactJsProject = "The jSX React Core Web API Demo Project is a demonstration project designed to illustrate how to create a web application using React and ASP.NET Core 8 Web API. This project exemplifies the combination of React for building dynamic user interfaces with ASP.NET Core for developing robust server-side APIs.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxVueProject= "The jSX Vue Core Web API Demo Project is a demonstration project intended to demonstrate how to develop a web application using Vue and ASP.NET Core 8 Web API. It showcases the seamless integration of Vue for the front-end and ASP.NET Core for the back-end, offering a clear example of a full-stack web development approach.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxMAUIProject = "The jSX .NET MAUI Core Demo Project is one coming soon that you do not want to miss. Stay tuned!";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Constants class used to handle all jSilvestri.com 2024
                    /// Web API Demo Product Short descriptions, across all projects included in the jSilvestri 2024 Web API Demo 
                    /// Collection projects.
                    /// </summary>
                    public static class Short
                    {
                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxMainProject = "The jSilvestri.com 2024 Web API Demo Collection is a suite of demo projects showcasing Angular, React, Vue, and Blazor with ASP.NET Core 8 Web API, serving as a reference for modern web app architectures.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxClassLibrary = "The jSX Class Library Project Contains reusable .NET class libraries providing common functionalities for various web applications, promoting code reuse and maintainability.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxWebApiProject = "The jSX Web API Project Implements an ASP.NET Core 8 Web API as the back-end for various web apps, providing RESTful endpoints and demonstrating API best practices.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxSharedResources = "The jSX Shared Resources Project is a project that contains shared resources such as images, styles, and scripts used across multiple web applications in the jSilvestri.com BETA v 2024 Web API Demo Collection.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxAngularJsProject = "The jSX Angular Core Web API Demo Project demonstrates building a web app using Angular with ASP.NET Core 8 Web API, showcasing a modern web stack.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxBlazorProject = "The jSX Blazor Server Core Web API Demo Project demonstrates building a web app with Blazor Server and ASP.NET Core 8 Web API, featuring interactive UIs with server-side power.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxReactJsProject = "The jSX React Core Web API Demo Project  illustrates creating a web app with React and ASP.NET Core 8 Web API, combining dynamic UIs with robust APIs.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxVueProject = "The jSX Vue Core Web API Demo Project shows developing a web app using Vue with ASP.NET Core 8 Web API, highlighting a full-stack development approach.";

                        /// <summary>
                        /// Custom jSilvestri.com 2024 Web API Demo Constant used for product description. 
                        /// </summary>
                        public const string JsxMAUIProject = "The jSX .NET MAUI Core Demo Project is one coming soon that you do not want to miss. Stay tuned!";

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com 2024 Web API Demo Constants class used to handle Product GitHub SEO friendly URLs &amp;
                /// .git URLs.
                /// </summary>
                public static class GitHubUrls
                {

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Constants class used to handle Product GitHub SEO friendly URLs (i.e., https://github.com/JasonSilvestri/JsxClassLibrary).
                    /// </summary>
                    public static class SeoFriendlyUrls
                    {
                        public const string JsxMainProjectName = "https://github.com/JasonSilvestri/jSilvestri2024WebApiDemoCollection";

                        public const string JsxAngularJsProject = "https://github.com/JasonSilvestri/JsxAngularCoreWebApiDemo";

                        public const string JsxBlazorProject = "https://github.com/JasonSilvestri/JsxBlazorServerCoreWebApiDemo";

                        public const string JsxReactJsProject = "https://github.com/JasonSilvestri/JsxReactCoreWebApiDemo";

                        public const string JsxVueProject = "https://github.com/JasonSilvestri/JsxVueCoreWebApiDemo";

                        public const string JsxMAUIProject = "https://github.com/JasonSilvestri/JsxBlazorMauiCoreDemo";

                        public const string JsxClassLibraryProject = "https://github.com/JasonSilvestri/JsxClassLibrary";

                        public const string JsxWebApiProject = "https://github.com/JasonSilvestri/JsxWebApi";

                        public const string JsxSharedResourcesProject = "https://github.com/JasonSilvestri/JsxSharedResources";
                    }


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Constants class used to handle Product GitHub SEO friendly URLs (i.e., https://github.com/JasonSilvestri/JsxClassLibrary.git).
                    /// </summary>
                    public static class DotGitUrls
                    {
                        public const string JsxMainProjectName = "https://github.com/JasonSilvestri/jSilvestri2024WebApiDemoCollection.git";

                        public const string JsxAngularJsProject = "https://github.com/JasonSilvestri/JsxAngularCoreWebApiDemo.git";

                        public const string JsxBlazorProject = "https://github.com/JasonSilvestri/JsxBlazorServerCoreWebApiDemo.git";

                        public const string JsxReactJsProject = "https://github.com/JasonSilvestri/JsxReactCoreWebApiDemo.git";

                        public const string JsxVueProject = "https://github.com/JasonSilvestri/JsxVueCoreWebApiDemo.git";

                        public const string JsxMAUIProject = "https://github.com/JasonSilvestri/JsxBlazorMauiCoreDemo.git";

                        public const string JsxClassLibraryProject = "https://github.com/JasonSilvestri/JsxClassLibrary.git";

                        public const string JsxWebApiProject = "https://github.com/JasonSilvestri/JsxWebApi.git";

                        public const string JsxSharedResourcesProject = "https://github.com/JasonSilvestri/JsxSharedResources.git";
                    }

                }

        }

        /// <summary>
        /// Custom jSilvestri.com 2024 Web API Demo Constants class for handling all product information across 
        /// the jSilvestri.com 2024 Web API Demo Collection projects that could be considered sensitive info
        /// and extra steps taken to secure data as the applications evolve through the phases.
        /// <para>
        /// ⚠ IMPORTANT ⚠
        /// </para>
        /// <para>
        /// This project is currently in Phase <c>1</c> of <c>4</c>, where deliberate "minimum viable product" 
        /// decisions are made to demonstrate the project's evolution across phases. It is important to note that 
        /// storing sensitive data in variables (of most kinds) is not secure and should not be common practice.
        /// </para>
        /// <para>
        /// This project will not follow the common "for simplicity's sake" approach often justified by developers 
        /// when they provide code as a form of volunteering. Such practices go against the purpose of why I began 
        /// developing these cross-platform, cross-resource applications. It is concerning that such bad practices 
        /// are often encouraged across various projects and tech stacks, using both client-side and server-side 
        /// approaches.
        /// </para>
        /// <para>
        /// Using UserSecret files, app settings, and strongly typing static variables in your applications can 
        /// expose them to security risks. At a minimum, consider using a cloud secure vault or encryption when 
        /// re-using this code in your projects.
        /// </para>
        /// <para>
        /// One of the primary reasons for the existence of this class, as well as its elaborate uses, is to avoid 
        /// enforcing specific database uses, cloud storage, local storage solutions, and other decisions or 
        /// implementations that increase setup overhead. This project will increasingly use sealed classes, internal 
        /// declarations, and more secure practices as we progress through the phases.
        /// </para>
        /// </summary>
        public static class JsxAppDemoSettings
        {

            public const string JwtIssuer = "YourIssuer";
            public const string JwtAudience = "YourAudience";
            public const string JwtKey = "YourSuperSecretKey";


            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle all common
            /// string-based Favorite Icon settings for Pages 
            /// (for all major devices).
            /// </summary>
            public static class FavoriteIcons
            {
                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Apple Icons for Pages.
                /// </summary>
                public static class AppleTouch
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Apple Icons Rel Link
                    /// Settings.
                    /// </summary>
                    public static class Rels
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Rel Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "apple-touch-icon";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Apple Icons Sizes Link
                    /// Settings.
                    /// </summary>
                    public static class Sizes
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Sizes Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "180x180";

                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Apple Icons Href Link
                    /// Settings.
                    /// </summary>
                    public static class Href
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Href Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "/apple-touch-icon.png";

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons x 32 for Pages.
                /// </summary>
                public static class IconsX32
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 32 Rel Link
                    /// Settings.
                    /// </summary>
                    public static class Rels
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Rel Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "icon";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 32 Types Link
                    /// Settings.
                    /// </summary>
                    public static class Types
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Types Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "image/png";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 32 Sizes Link
                    /// Settings.
                    /// </summary>
                    public static class Sizes
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Sizes Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "32x32";

                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 32 Href Link
                    /// Settings.
                    /// </summary>
                    public static class Href
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Href Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "/favicon-32x32.png";

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons x 16 for Pages.
                /// </summary>
                public static class IconsX16
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 16 Rel Link
                    /// Settings.
                    /// </summary>
                    public static class Rels
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Rel Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "icon";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 16 Types Link
                    /// Settings.
                    /// </summary>
                    public static class Types
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Types Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "image/png";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 16 Sizes Link
                    /// Settings.
                    /// </summary>
                    public static class Sizes
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Sizes Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "16x16";

                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 16 Href Link
                    /// Settings.
                    /// </summary>
                    public static class Href
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Href Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "/favicon-16x16.png";

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons x Manifest for Pages.
                /// </summary>
                public static class IconsXManifest
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x Manifest Rel Link
                    /// Settings.
                    /// </summary>
                    public static class Rels
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Rel Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "manifest";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x Manifest Href Link
                    /// Settings.
                    /// </summary>
                    public static class Href
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Href Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "/site.webmanifest";

                    }
                }


                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons x MaskIcon for Pages.
                /// </summary>
                public static class IconsXMaskIcon
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x MaskIcon Rel Link
                    /// Settings.
                    /// </summary>
                    public static class Rels
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Rel Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "mask-icon";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x MaskIcon Colors Link
                    /// Settings.
                    /// </summary>
                    public static class Colors
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Colors Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "#17699f";

                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x MaskIcon Href Link
                    /// Settings.
                    /// </summary>
                    public static class Href
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Href Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "/safari-pinned-tab.svg";

                    }
                }


                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons Microsoft Applicaition for Pages.
                /// </summary>
                public static class IconsMicrosoftApplicaition
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons Microsoft Applicaition Meta Link
                    /// Settings.
                    /// </summary>
                    public static class Metas
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle all common
                        /// string-based Favorite Icon settings for Icons Microsoft 
                        /// Applicaition Meta Names Settings.
                        /// </summary>
                        public static class Names
                        {
                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds just the 
                            /// string-based Page Meta Name Setting for the Default Value.
                            /// </summary>
                            public const string Default = "msapplication-TileColor";
                        }


                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle all common
                        /// string-based Favorite Icon settings for Icons Microsoft 
                        /// Applicaition Meta Content Settings.
                        /// </summary>
                        public static class Content
                        {
                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds just the 
                            /// string-based Page Meta Name Setting for the Default Value.
                            /// </summary>
                            public const string Default = "#17699f";
                        }
                    }

                }


                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons  Theme Color Applicaition for Pages.
                /// </summary>
                public static class IconsThemeColors
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons  Theme Color Applicaition Meta Link
                    /// Settings.
                    /// </summary>
                    public static class Metas
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle all common
                        /// string-based Favorite Icon settings for Icons  Theme Color 
                        /// Applicaition Meta Names Settings.
                        /// </summary>
                        public static class Names
                        {
                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds just the 
                            /// string-based Page Meta Name Setting for the Default Value.
                            /// </summary>
                            public const string Default = "theme-color";
                        }


                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle all common
                        /// string-based Favorite Icon settings for Icons  Theme Color 
                        /// Applicaition Meta Content Settings.
                        /// </summary>
                        public static class Content
                        {
                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds just the 
                            /// string-based Page Meta Name Setting for the Default Value.
                            /// </summary>
                            public const string Default = "#17699f";
                        }
                    }

                }


                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons Primary FavIcon for Pages.
                /// </summary>
                public static class IconsPrimaryFavIcon
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons Primary FavIcon Rel Link
                    /// Settings.
                    /// </summary>
                    public static class Rels
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Rel Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "icon";

                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Primary FavIcon Types Link
                    /// Settings.
                    /// </summary>
                    public static class Types
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Types Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "image/x-icon";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons Primary FavIcon Href Link
                    /// Settings.
                    /// </summary>
                    public static class Href
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Href Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "favicon.ico";

                    }
                }

            }

            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle all common
            /// string-based Favorite Icon settings for META Tags Format Detection Applicaition for Pages.
            /// </summary>
            public static class FormatDetectionApplicaition
            {
                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for META Tags Format Detection Applicaition Meta Link
                /// Settings.
                /// </summary>
                public static class Metas
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for META Tags Format Detection 
                    /// Applicaition Meta Names Settings.
                    /// </summary>
                    public static class Names
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Meta Name Setting for the Default Value.
                        /// </summary>
                        public const string Default = "format-detection";
                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for META Tags Format Detection 
                    /// Applicaition Meta Content Settings.
                    /// </summary>
                    public static class Content
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Meta Name Setting for the Default Value.
                        /// </summary>
                        public const string Default = "telephone=no";
                    }
                }

            }

            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle all common
            /// string-based Favorite Icon settings for META Tags View Port for Pages.
            /// </summary>
            public static class ViewPort
            {
                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for META Tags View Port Meta Link
                /// Settings.
                /// </summary>
                public static class Metas
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for META Tags Format Detection 
                    /// Applicaition Meta Names Settings.
                    /// </summary>
                    public static class Names
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Meta Name Setting for the Default Value.
                        /// </summary>
                        public const string Default = "viewport";
                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for META Tags Format Detection 
                    /// Applicaition Meta Content Settings.
                    /// </summary>
                    public static class Content
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Meta Name Setting for the Default Value.
                        /// </summary>
                        public const string Default = "width=device-width, height=device-height, initial-scale=1.0, maximum-scale=1.0, user-scalable=0";
                    }
                }

            }


            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle all common
            /// string-based Favorite Icon settings for META Tags Charset for Pages.
            /// </summary>
            public static class Charset
            {
                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for META Tags Charset Meta Link
                /// Settings.
                /// </summary>
                public static class Metas
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Charset.
                    /// </summary>
                    public static class Charset
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Meta Charset Default Value.
                        /// </summary>
                        public const string Default = "utf-8";
                    }

                }

            }


            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle common string-based 
            /// Protocol schemas, such as http, https, etc.
            /// </summary>      
            public static class Protocol
            {

                /// <summary>
                /// Custom jSilvestri.com Constant used to handle the string-based
                /// protocol for SSL (i.e. https://). 
                /// </summary>
                public const string Https = "https://";

                /// <summary>
                /// Custom jSilvestri.com Constant used to handle the string-based
                /// protocol for HTTP (i.e. http://). 
                /// </summary>
                public const string Http = "http://";

                /// <summary>
                /// Custom jSilvestri.com Constant used to handle the string-based
                /// protocol for SSL, with no colons or slashes (i.e. https). 
                /// </summary>
                public const string HttpsNoColonsSlashes = "https";

                /// <summary>
                /// Custom jSilvestri.com Constant used to handle the string-based
                /// protocol for HTTP, with no colons or slashes (i.e. http). 
                /// </summary>
                public const string HttpNoColonsSlashes = "http";

            }

            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle common string-based 
            /// Root object of the application, like the common tilde location to establish Absolute URLs, 
            /// in addition to the DotDot Relative URLs, the DEV or UAT servers, and/or any other root 
            /// object we may want to use.
            /// </summary>      
            public static class Root
            {

                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Root Slug we use to construct the "Root" part of a 
                /// URL or URI.
                /// </summary>
                public static class Slugs
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the "~" Root
                    /// Slug, used to construct the "Root" part of a URL or URI. This Root
                    /// Slug should be the default to use with Absolute URL Helpers we have
                    /// today. The other Root Slug choices are to use in very specific 
                    /// server operations and/or localized testing cases. 
                    /// </summary>
                    public const string Tilde = "~/";

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the "./" Root
                    /// Slug, used to construct the "Root" part of a URL or URI. This Root
                    /// Slug should be the default to use with Absolute URL Helpers we have
                    /// today. The other Root Slug choices are to use in very specific 
                    /// server operations and/or localized testing cases. 
                    /// <para>
                    /// ATTN JasonXWebApp Developer ::
                    /// </para>
                    /// Remember, this is a relative path, and it assumes you are already 
                    /// in the root directory. For deeper drill downs, try the other relative
                    /// path choices.
                    /// </summary>
                    public const string DotForwardSlash = "./";

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Pipeline "Development Server" Root
                    /// Slug, used to construct the "Root" part of a URL or URI.
                    /// </summary>
                    public const string DevelopmentServerPipeline = "www.jsilvestri.com";

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the None Pipeline "Staging Server" Root
                    /// Slug used to construct the "Root" part of a URL or URI. This specific version
                    /// uses SQLVM.
                    /// </summary>
                    public const string StageServerNoPipeline = "www.jsilvestri.com";

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Pipeline "UAT Server" Root
                    /// Slug, used to construct the "Root" part of a URL or URI.
                    /// </summary>
                    public const string UATServerPipeline = "www.jsilvestri.com";

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Pipeline "Production Server" Root
                    /// Slug, used to construct the "Root" part of a URL or URI.
                    /// </summary>
                    public const string ProductionServerPipeline = "jsilvestri.com";

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Pipeline "Production Server" Root
                    /// Slug, used to construct the "Root" part of a URL or URI.
                    /// </summary>
                    public const string ProductionServerPipelineWWW = "www.jsilvestri.com";

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the DefaultRoot
                    /// Slug, used to construct the "Root" part of a URL or URI. This Root
                    /// Slug should be the default to use with Absolute URL Helpers we have
                    /// today. The other Root Slug choices are to use in very specific 
                    /// server operations and/or localized testing cases. For now, it will
                    /// just be targeting the Tilde constant.
                    /// </summary>
                    public const string DefaultJsxRoot = Tilde;
                }

            }


            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle common string-based 
            /// Port object of the application, like the common  location to establish 
            /// Absolute URLs, using localhost (i.e., localhost:44329). Please keep in mind
            /// that these ports are just the potential number integer to use (or not use).
            /// </summary>      
            public static class Ports
            {

                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Root Slug we use to construct the "Port" part of a 
                /// URL or URI (i.e., 80, 443 - which if either, we should make this 
                /// value 0).
                /// </summary>
                public static class Slugs
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Port "80" value
                    /// Slug, used to construct the "Port" part of a URL or URI. This Port
                    /// Slug should be the default to use with Absolute URL Helpers we have
                    /// today.
                    /// <para>
                    /// ⚠ IMPORTANT ⚠
                    /// </para>
                    /// We DO NOT want to create a port value for URLs or URIs if the port value
                    /// is "80", because that is reserved. This value is more to check against in
                    /// -coming ports if anything.
                    /// </summary>
                    public const int port80 = 80;

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Port "443" value
                    /// Slug, used to construct the "Port" part of a URL or URI. This Port
                    /// Slug should be the default to use with Absolute URL Helpers we have
                    /// today.
                    /// <para>
                    /// ⚠ IMPORTANT ⚠
                    /// </para>
                    /// We DO NOT want to create a port value for URLs or URIs if the port value
                    /// is "443", because that is reserved. This value is more to check against in
                    /// -coming ports if anything.
                    /// </summary>
                    public const int port443 = 443;


                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Port "443" value
                    /// Slug, used to construct the "Port" part of a URL or URI. This Port
                    /// Slug should be the default to use with Absolute URL Helpers we have
                    /// today.
                    /// <para>
                    /// ⚠ IMPORTANT ⚠
                    /// </para>
                    /// We DO NOT want to create a port value for URLs or URIs if the port value
                    /// is "443", because that is reserved. This value is more to check against in
                    /// -coming ports if anything.
                    /// </summary>
                    public const string portNone = "";

                }

            }

        }

        /// <summary>
        /// Custom jSilvestri.com Constants class used to handle all common
        /// string-based app Cards (i.e., your contact card on app, 
        /// Swagger card, license cards, etc).
        /// </summary>
        public static class AppCards
        {
            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle most common
            /// string-based properties of your contact card.
            /// </summary>
            public static class YourContactCards
            {

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds just your 
                /// string-based First Name.
                /// </summary>
                public const string FirstName = "Jason";

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds just your 
                /// string-based Last Name.
                /// </summary>
                public const string LastName = "Silvestri";

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds just your 
                /// string-based Full Name.
                /// </summary>
                public const string FullName = FirstName + " " + LastName;

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds just your 
                /// string-based Email.
                /// </summary>
                public const string Email = "therealjasonsilvestri@gmail.com";

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds just your 
                /// string-based primary URL (i.e., your blog, company website, etc.).
                /// </summary>
                public const string PrimaryUrl = "https://jsilvestri.com";

            }

            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle basic App license
            /// cards.
            /// </summary>
            public static class AppLicenseCards
            {
                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                /// card.
                /// </summary>
                public static class Mit
                {

                    /// <summary>
                    /// Custom jSilvestri.com Constants Property that holds 
                    /// string-based default Name Text for the MIT card.
                    /// </summary>
                    public const string Name = "MIT";

                    /// <summary>
                    /// Custom jSilvestri.com Constants Property that holds 
                    /// string-based default URL for the MIT card.
                    /// </summary>
                    public const string Url = "https://opensource.org/licenses/MIT";

                }

                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                /// card.
                /// </summary>
                public static class AppTermsOfServices
                {

                    /// <summary>
                    /// Custom jSilvestri.com Constants Property that holds 
                    /// string-based default Name Text for the App card.
                    /// </summary>
                    public const string Name = "Terms of Service";

                    /// <summary>
                    /// Custom jSilvestri.com Constants Property that holds 
                    /// string-based default URL for the MIT card.
                    /// </summary>
                    public const string Url = "https://opensource.org/licenses/MIT";

                }

            }

            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle basic App Swagger 
            /// cards that allow us a temp, static way, to configure Swagger for each 
            /// application with a working WebAPI which is then used to dynamically
            /// render CRUD services and operartions.
            /// </summary>
            public static class AppSwaggerCards
            {

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds 
                /// string-based default Name Text for the App card.
                /// </summary>
                public const string SwagVersion = "v1";

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds 
                /// string-based default Swagger JSON Endpoint.
                /// </summary>
                public const string SwagEndPointUri = "/swagger/v1/swagger.json";

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds 
                /// the true/false flag, indicating whether Swagger should be
                /// serializable using the legacy 2.0 standard for backwards 
                /// compatability or go for the new 3.0 standard.
                /// </summary>
                public const bool IsSwagSerializeAsV2 = false;


                /// <summary>
                /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class JsxAppsCollections
                {

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsxAppVer = JsxAppProjects.ProductVersions.JsxMainProjectName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsxAppProjects.Names.Shorts.JsxMainProjectName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsxAppProjects.Descriptions.Default.JsxMainProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsxAppProjects.GitHubUrls.SeoFriendlyUrls.JsxMainProjectName;

                    }

                }

                /// <summary>
                /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class JsxClassLibrary
                {

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsxAppVer = JsxAppProjects.ProductVersions.JsxClassLibraryProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsxAppProjects.Names.Shorts.JsxClassLibraryProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsxAppProjects.Descriptions.Default.JsxClassLibrary;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsxAppProjects.GitHubUrls.SeoFriendlyUrls.JsxClassLibraryProject;

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class JsxWebApi
                {


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsxAppVer = JsxAppProjects.ProductVersions.JsxWebApiProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsxAppProjects.Names.Shorts.JsxWebApiProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsxAppProjects.Descriptions.Default.JsxWebApiProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsxAppProjects.GitHubUrls.SeoFriendlyUrls.JsxWebApiProject;

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class JsxSharedResources
                {
                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsxAppVer = JsxAppProjects.ProductVersions.JsxSharedResourcesProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsxAppProjects.Names.Shorts.JsxSharedResourcesProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsxAppProjects.Descriptions.Default.JsxSharedResources;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsxAppProjects.GitHubUrls.SeoFriendlyUrls.JsxSharedResourcesProject;

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class JsxAngular
                {


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsxAppVer = JsxAppProjects.ProductVersions.JsxAngularJsProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsxAppProjects.Names.Shorts.JsxAngularJsProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsxAppProjects.Descriptions.Default.JsxAngularJsProject;


                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsxAppProjects.GitHubUrls.SeoFriendlyUrls.JsxAngularJsProject;

                    }

                }

                /// <summary>
                /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class JsxBlazor
                {


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsxAppVer = JsxAppProjects.ProductVersions.JsxBlazorProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsxAppProjects.Names.Shorts.JsxBlazorProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsxAppProjects.Descriptions.Default.JsxBlazorProject;


                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsxAppProjects.GitHubUrls.SeoFriendlyUrls.JsxBlazorProject;

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class JsxReact
                {


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsxAppVer = JsxAppProjects.ProductVersions.JsxReactJsProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsxAppProjects.Names.Shorts.JsxReactJsProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsxAppProjects.Descriptions.Default.JsxReactJsProject;


                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsxAppProjects.GitHubUrls.SeoFriendlyUrls.JsxReactJsProject;

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class JsxVue
                {


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com 2024 Web API Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsxAppVer = JsxAppProjects.ProductVersions.JsxAngularJsProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsxAppProjects.Names.Shorts.JsxAngularJsProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsxAppProjects.Descriptions.Default.JsxAngularJsProject;


                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsxAppProjects.GitHubUrls.SeoFriendlyUrls.JsxAngularJsProject;

                    }
                }

            }

        }

    }
}
