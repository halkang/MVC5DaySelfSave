【ASP.NET MVC 5 開發實戰】練習專案
================================

使用工具
--------

* Visual Studio 2013 
    * [Visual Studio 2013 Update 3](http://www.microsoft.com/zh-tw/download/details.aspx?id=43721)
	* [Web Essentials 2013 for Update 3](http://vswebessentials.com/)
* SQL Server 2012 LocalDB
	* 伺服器名稱: **``(localdb)\v11.0``**
* SQL Server 2012 Management Studio
    * [CHT\x64\SQLManagementStudio_x64_CHT.exe](http://www.microsoft.com/zh-tw/download/details.aspx?id=29062)
 

建立專案
--------

1. [檔案] / [新增] / [專案]

	![image](https://cloud.githubusercontent.com/assets/88981/4964338/795bee9c-6793-11e4-9e8d-ebc2026c8dfa.png)

2. 選擇 [Web] 分類，選擇 [ASP.NET Web 應用程式]，設定專案 [名稱]

	![image](https://cloud.githubusercontent.com/assets/88981/4964335/45a716c6-6793-11e4-9c8a-fecf11e41ea0.png)

3. 選擇 [MVC] 專案範本，並勾選 [Web API] 核心參考

	![image](https://cloud.githubusercontent.com/assets/88981/4964334/4226a9e4-6793-11e4-830f-9b334af7d0f0.png)

專案 NuGet 套件介紹
-------------------

以下是 Visual Studio 2013 Update 3 內建的 ASP.NET MVC 5 專案範本專案的 NuGet 套件介紹。

### [ 後端套件 ]

* ASP.NET MVC 5.2.0
  - 官網: http://www.asp.net/mvc
  - 專案位址: http://aspnetwebstack.codeplex.com/
  - 範例專案: http://aspnet.codeplex.com/SourceControl/latest
* ASP.NET Web API 5.2.0
  - 官網: http://www.asp.net/web-api
  - 專案位址: http://aspnetwebstack.codeplex.com/
  - 範例專案: http://aspnet.codeplex.com/SourceControl/latest
* ASP.NET Identity 2.1.0
  - 官網: http://www.asp.net/identity
  - 專案位址: https://aspnetidentity.codeplex.com/
  - 範例專案: http://aspnet.codeplex.com/SourceControl/latest
* Entity Framework 6.1.1
  - 官網: http://www.asp.net/entity-framework
  - 專案位址: https://entityframework.codeplex.com/
* Microsoft.AspNet.Web.Optimization 1.1.3
  - 用來將 javascript, js 最小化 (minification) 與 打包 (bundling) 的工具
  - ASP.NET Optimization introduces a way to bundle and optimize CSS and JavaScript files.
  - 相關連結
    * [kenhaines.net | WebGrease: As seen in Visual Studio 2012](http://kenhaines.net/post/2012/06/09/WebGrease-As-seen-in-Visual-Studio-2012.aspx)
    * [Web Optimization in Visual Studio 2012 RC | Howard Dierking](http://codebetter.com/howarddierking/2012/06/04/web-optimization-in-visual-studio-2012-rc/)
* Microsoft.Web.Infrastructure 1.0.0.0
  - 用來在執行時期動態註冊 HTTP modules (相依於 Microsoft.AspNet.Web.Optimization 套件)
* WebGrease 1.5.2
  - 用來最佳化 javascript, css 與圖片檔案 (相依於 Microsoft.AspNet.Web.Optimization 套件)
  - WebGrease is a suite of tools for optimizing javascript, css files and images.
  - 專案位址: https://webgrease.codeplex.com/
* Antlr 3.4.1.9004
  - 用來解析 CSS 語法的工具 (相依於 WebGrease 套件) [ [說明](http://stackoverflow.com/questions/20412234/what-is-the-purpose-of-antlr-package-in-visual-studio-2013-asp-net-project) ]
* Newtonsoft.Json (Json.NET) 6.0.3
  - 提供 .NET 環境操作 JSON 資料 (相依於 WebGrease 套件)
  - 官網: http://james.newtonking.com/json
  - 專案位址: https://github.com/JamesNK/Newtonsoft.Json
* OWIN 1.0
  - 官網: http://owin.org/
* Microsoft.Owin 2.1 (Katana)
  - 專案位址: http://katanaproject.codeplex.com/

### [ 前端套件 ]

* jQuery 1.10.2
	* 官網: http://www.jquery.com/
	* 專案位址: http://github.com/jquery/jquery 
* jQuery Validation 1.11.1
	* 官網: http://jqueryvalidation.org/
	* 專案位址: https://github.com/jzaefferer/jquery-validation 
* Bootstrap 3.0.0
	* 官網: http://getbootstrap.com/
* Modernizr 2.6.2
	* 官網: http://modernizr.com/
* Respond 1.2.0
	* 專案位址: https://github.com/scottjehl/Respond 
* Microsoft.jQuery.Unobtrusive.Validation 3.2.0
	* 用來與 ASP.NET MVC 5 表單驗證功能搭配使用的 JS 函式庫  

相關連結
--------

* [Visual Studio 2012 RC is released - The Big Web Rollup - Scott Hanselman](http://www.hanselman.com/blog/VisualStudio2012RCIsReleasedTheBigWebRollup.aspx)
* [ASP.NET features in New Project Templates in Visual Studio 2013](http://blogs.msdn.com/b/webdev/archive/2013/10/16/asp-net-features-in-new-project-templates-in-visual-studio-2013.aspx)
* [Announcing release of ASP.NET and Web Tools 2013.1 for Visual Studio 2012](http://blogs.msdn.com/b/webdev/archive/2013/11/18/announcing-release-of-asp-net-and-web-tools-2013-1-for-visual-studio-2012.aspx)
* [Announcing new Web Features in Visual Studio 2013 Update 2 RTM](http://blogs.msdn.com/b/webdev/archive/2014/05/12/announcing-new-web-features-in-visual-studio-2013-update-2-rtm.aspx)
* [Announcing new Web Features in Visual Studio 2013 Update 3 RTM](http://blogs.msdn.com/b/webdev/archive/2014/08/04/announcing-new-web-features-in-visual-studio-2013-update-3-rtm.aspx)
* [Announcing the Release of ASP.NET MVC 5.1, Web API 2.1 and Web Pages 3.1](http://blogs.msdn.com/b/webdev/archive/2014/01/20/announcing-the-release-of-asp-net-mvc-5-1-asp-net-web-api-2-1-and-asp-net-web-pages-3-1.aspx)
* [Announcing the Release of ASP.NET MVC 5.2, Web API 2.2 and Web Pages 3.2](http://blogs.msdn.com/b/webdev/archive/2014/07/02/announcing-the-release-of-asp-net-mvc-5-2-web-api-2-2-and-web-pages-3-2.aspx)
* [Getting Started with Entity Framework 6 Code First using MVC 5](http://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application)
* [Getting Started with Entity Framework 5 Code First using MVC 4](http://www.asp.net/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application)
* [Getting Started with ASP.NET MVC 4](http://www.asp.net/mvc/overview/older-versions/getting-started-with-aspnet-mvc4/intro-to-aspnet-mvc-4)