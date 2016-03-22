//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.2.93
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly, System.Reflection.AssemblyVersion("0.0.0.1")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Web site</summary>
	[PublishedContentModel("webSite")]
	public partial class WebSite : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "webSite";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public WebSite(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<WebSite, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Author
		///</summary>
		[ImplementPropertyType("author")]
		public object Author
		{
			get { return this.GetPropertyValue("author"); }
		}

		///<summary>
		/// Content Grid: The front page content
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("contentGrid"); }
		}

		///<summary>
		/// Facebook App Id
		///</summary>
		[ImplementPropertyType("facebookAppId")]
		public string FacebookAppId
		{
			get { return this.GetPropertyValue<string>("facebookAppId"); }
		}

		///<summary>
		/// Facebook App Secret
		///</summary>
		[ImplementPropertyType("facebookAppSecret")]
		public string FacebookAppSecret
		{
			get { return this.GetPropertyValue<string>("facebookAppSecret"); }
		}

		///<summary>
		/// Featured Image
		///</summary>
		[ImplementPropertyType("featuredImage")]
		public string FeaturedImage
		{
			get { return this.GetPropertyValue<string>("featuredImage"); }
		}

		///<summary>
		/// Page Snippet
		///</summary>
		[ImplementPropertyType("pageSnippet")]
		public string PageSnippet
		{
			get { return this.GetPropertyValue<string>("pageSnippet"); }
		}

		///<summary>
		/// Page Title
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return this.GetPropertyValue<string>("pageTitle"); }
		}

		///<summary>
		/// Site description
		///</summary>
		[ImplementPropertyType("siteDescription")]
		public string SiteDescription
		{
			get { return this.GetPropertyValue<string>("siteDescription"); }
		}

		///<summary>
		/// Site logo
		///</summary>
		[ImplementPropertyType("siteLogo")]
		public string SiteLogo
		{
			get { return this.GetPropertyValue<string>("siteLogo"); }
		}

		///<summary>
		/// Site snippet: 160 characters about your page
		///</summary>
		[ImplementPropertyType("siteSnippet")]
		public string SiteSnippet
		{
			get { return this.GetPropertyValue<string>("siteSnippet"); }
		}

		///<summary>
		/// Site tags
		///</summary>
		[ImplementPropertyType("siteTags")]
		public object SiteTags
		{
			get { return this.GetPropertyValue("siteTags"); }
		}

		///<summary>
		/// Site title
		///</summary>
		[ImplementPropertyType("siteTitle")]
		public string SiteTitle
		{
			get { return this.GetPropertyValue<string>("siteTitle"); }
		}
	}

	/// <summary>Page</summary>
	[PublishedContentModel("page")]
	public partial class Page : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "page";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Page(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Page, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Author: The main author of this article
		///</summary>
		[ImplementPropertyType("author")]
		public object Author
		{
			get { return this.GetPropertyValue("author"); }
		}

		///<summary>
		/// Author emails: Author Emails
		///</summary>
		[ImplementPropertyType("authorEmails")]
		public string AuthorEmails
		{
			get { return this.GetPropertyValue<string>("authorEmails"); }
		}

		///<summary>
		/// Do not show featured Image
		///</summary>
		[ImplementPropertyType("doNotShowFeaturedImage")]
		public bool DoNotShowFeaturedImage
		{
			get { return this.GetPropertyValue<bool>("doNotShowFeaturedImage"); }
		}

		///<summary>
		/// Featured image: Featured image to use at top of page as well as for social media.
		///</summary>
		[ImplementPropertyType("featuredImage")]
		public object FeaturedImage
		{
			get { return this.GetPropertyValue("featuredImage"); }
		}

		///<summary>
		/// Is featured?
		///</summary>
		[ImplementPropertyType("isFeatured")]
		public bool IsFeatured
		{
			get { return this.GetPropertyValue<bool>("isFeatured"); }
		}

		///<summary>
		/// Page license
		///</summary>
		[ImplementPropertyType("pageLicense")]
		public object PageLicense
		{
			get { return this.GetPropertyValue("pageLicense"); }
		}

		///<summary>
		/// Page Snippet: Short description of page. Used for internal links as well for SEO.
		///</summary>
		[ImplementPropertyType("pageSnippet")]
		public string PageSnippet
		{
			get { return this.GetPropertyValue<string>("pageSnippet"); }
		}

		///<summary>
		/// Page Tags: Tags/keywords for page. Used for finding related links as well as SEO.
		///</summary>
		[ImplementPropertyType("pageTags")]
		public object PageTags
		{
			get { return this.GetPropertyValue("pageTags"); }
		}

		///<summary>
		/// Page Title: Title of the page. Used for head of page and SEO. Max 55 characters.
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return this.GetPropertyValue<string>("pageTitle"); }
		}

		///<summary>
		/// Related links
		///</summary>
		[ImplementPropertyType("relatedLinks")]
		public Newtonsoft.Json.Linq.JArray RelatedLinks
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JArray>("relatedLinks"); }
		}

		///<summary>
		/// Hide in navigation?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Page - Grid</summary>
	[PublishedContentModel("pageGrid")]
	public partial class PageGrid : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageGrid";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageGrid(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageGrid, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content grid: Your fantastic content
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("contentGrid"); }
		}
	}

	/// <summary>Page - Simple</summary>
	[PublishedContentModel("pageSimple")]
	public partial class PageSimple : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageSimple";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageSimple(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageSimple, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// contentHtml
		///</summary>
		[ImplementPropertyType("contentHtml")]
		public IHtmlString ContentHtml
		{
			get { return this.GetPropertyValue<IHtmlString>("contentHtml"); }
		}
	}

	/// <summary>Pagelist - Standard</summary>
	[PublishedContentModel("pagelist")]
	public partial class Pagelist : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pagelist";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Pagelist(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Pagelist, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Html
		///</summary>
		[ImplementPropertyType("contentHtml")]
		public IHtmlString ContentHtml
		{
			get { return this.GetPropertyValue<IHtmlString>("contentHtml"); }
		}
	}

	/// <summary>Page - Lexicon</summary>
	[PublishedContentModel("pageLexicon")]
	public partial class PageLexicon : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageLexicon";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageLexicon(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageLexicon, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content html
		///</summary>
		[ImplementPropertyType("contentHtml")]
		public IHtmlString ContentHtml
		{
			get { return this.GetPropertyValue<IHtmlString>("contentHtml"); }
		}

		///<summary>
		/// Content Read More Doctors
		///</summary>
		[ImplementPropertyType("contentReadMoreDoctors")]
		public IHtmlString ContentReadMoreDoctors
		{
			get { return this.GetPropertyValue<IHtmlString>("contentReadMoreDoctors"); }
		}

		///<summary>
		/// Content Read More Patients
		///</summary>
		[ImplementPropertyType("contentReadMorePatients")]
		public IHtmlString ContentReadMorePatients
		{
			get { return this.GetPropertyValue<IHtmlString>("contentReadMorePatients"); }
		}

		///<summary>
		/// Synonyms: Synonyms for the lexicon word. Comma separated.
		///</summary>
		[ImplementPropertyType("synonyms")]
		public string Synonyms
		{
			get { return this.GetPropertyValue<string>("synonyms"); }
		}
	}

	/// <summary>Page - News</summary>
	[PublishedContentModel("pageNews")]
	public partial class PageNews : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageNews";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageNews(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageNews, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Html
		///</summary>
		[ImplementPropertyType("contentHtml")]
		public IHtmlString ContentHtml
		{
			get { return this.GetPropertyValue<IHtmlString>("contentHtml"); }
		}
	}

	/// <summary>Page - Magazine</summary>
	[PublishedContentModel("pageMagazine")]
	public partial class PageMagazine : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageMagazine";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageMagazine(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageMagazine, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Html
		///</summary>
		[ImplementPropertyType("contentHtml")]
		public IHtmlString ContentHtml
		{
			get { return this.GetPropertyValue<IHtmlString>("contentHtml"); }
		}
	}

	/// <summary>Pagelist - Lexicon</summary>
	[PublishedContentModel("pagelistLexicon")]
	public partial class PagelistLexicon : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pagelistLexicon";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PagelistLexicon(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PagelistLexicon, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Sitemap</summary>
	[PublishedContentModel("sitemap")]
	public partial class Sitemap : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sitemap";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Sitemap(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Sitemap, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide in navigation?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Page section</summary>
	[PublishedContentModel("pageSection")]
	public partial class PageSection : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageSection";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageSection(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageSection, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Html
		///</summary>
		[ImplementPropertyType("contentHtml")]
		public IHtmlString ContentHtml
		{
			get { return this.GetPropertyValue<IHtmlString>("contentHtml"); }
		}
	}

	/// <summary>Page - Standard</summary>
	[PublishedContentModel("pageStandard")]
	public partial class PageStandard : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageStandard";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageStandard(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageStandard, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Html
		///</summary>
		[ImplementPropertyType("contentHtml")]
		public IHtmlString ContentHtml
		{
			get { return this.GetPropertyValue<IHtmlString>("contentHtml"); }
		}
	}

	/// <summary>Robots.txt</summary>
	[PublishedContentModel("robotstxt")]
	public partial class Robotstxt : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "robotstxt";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Robotstxt(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Robotstxt, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// umbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Page - Video</summary>
	[PublishedContentModel("pageVideo")]
	public partial class PageVideo : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageVideo";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageVideo(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageVideo, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Html
		///</summary>
		[ImplementPropertyType("contentHtml")]
		public IHtmlString ContentHtml
		{
			get { return this.GetPropertyValue<IHtmlString>("contentHtml"); }
		}

		///<summary>
		/// Video Embed Code
		///</summary>
		[ImplementPropertyType("videoEmbedCode")]
		public string VideoEmbedCode
		{
			get { return this.GetPropertyValue<string>("videoEmbedCode"); }
		}
	}

	/// <summary>Page - Course</summary>
	[PublishedContentModel("pageCourse")]
	public partial class PageCourse : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageCourse";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageCourse(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageCourse, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Html
		///</summary>
		[ImplementPropertyType("contentHtml")]
		public IHtmlString ContentHtml
		{
			get { return this.GetPropertyValue<IHtmlString>("contentHtml"); }
		}
	}

	/// <summary>Page section - Learn</summary>
	[PublishedContentModel("pageSectionLearn")]
	public partial class PageSectionLearn : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageSectionLearn";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageSectionLearn(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageSectionLearn, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Learning page</summary>
	[PublishedContentModel("learningPage")]
	public partial class LearningPage : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "learningPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public LearningPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LearningPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Html
		///</summary>
		[ImplementPropertyType("contentHtml")]
		public IHtmlString ContentHtml
		{
			get { return this.GetPropertyValue<IHtmlString>("contentHtml"); }
		}
	}

	/// <summary>Writer page</summary>
	[PublishedContentModel("writerPage")]
	public partial class WriterPage : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "writerPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public WriterPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<WriterPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Writer
		///</summary>
		[ImplementPropertyType("writerMemberId")]
		public object WriterMemberId
		{
			get { return this.GetPropertyValue("writerMemberId"); }
		}
	}

	/// <summary>Pagelist - Writers</summary>
	[PublishedContentModel("pagelistWriters")]
	public partial class PagelistWriters : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pagelistWriters";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PagelistWriters(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PagelistWriters, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Image Author
		///</summary>
		[ImplementPropertyType("imageAuthor")]
		public string ImageAuthor
		{
			get { return this.GetPropertyValue<string>("imageAuthor"); }
		}

		///<summary>
		/// Image Author Url
		///</summary>
		[ImplementPropertyType("imageAuthorUrl")]
		public string ImageAuthorUrl
		{
			get { return this.GetPropertyValue<string>("imageAuthorUrl"); }
		}

		///<summary>
		/// Image Description
		///</summary>
		[ImplementPropertyType("imageDescription")]
		public string ImageDescription
		{
			get { return this.GetPropertyValue<string>("imageDescription"); }
		}

		///<summary>
		/// Image License
		///</summary>
		[ImplementPropertyType("imageLicense")]
		public object ImageLicense
		{
			get { return this.GetPropertyValue("imageLicense"); }
		}

		///<summary>
		/// Image Original Title
		///</summary>
		[ImplementPropertyType("imageOriginalTitle")]
		public string ImageOriginalTitle
		{
			get { return this.GetPropertyValue<string>("imageOriginalTitle"); }
		}

		///<summary>
		/// Image Tags
		///</summary>
		[ImplementPropertyType("imageTags")]
		public object ImageTags
		{
			get { return this.GetPropertyValue("imageTags"); }
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bio
		///</summary>
		[ImplementPropertyType("bio")]
		public string Bio
		{
			get { return this.GetPropertyValue<string>("bio"); }
		}

		///<summary>
		/// Facebook Profile Page
		///</summary>
		[ImplementPropertyType("facebookProfilePage")]
		public string FacebookProfilePage
		{
			get { return this.GetPropertyValue<string>("facebookProfilePage"); }
		}

		///<summary>
		/// Yrke
		///</summary>
		[ImplementPropertyType("occupation")]
		public string Occupation
		{
			get { return this.GetPropertyValue<string>("occupation"); }
		}

		///<summary>
		/// Picture: Add a nice picture of yourself!
		///</summary>
		[ImplementPropertyType("picture")]
		public Umbraco.Web.Models.ImageCropDataSet Picture
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("picture"); }
		}

		///<summary>
		/// Twitter User Name
		///</summary>
		[ImplementPropertyType("twitterUserName")]
		public string TwitterUserName
		{
			get { return this.GetPropertyValue<string>("twitterUserName"); }
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}

		///<summary>
		/// Writer Profile
		///</summary>
		[ImplementPropertyType("writerProfile")]
		public object WriterProfile
		{
			get { return this.GetPropertyValue("writerProfile"); }
		}
	}

}
