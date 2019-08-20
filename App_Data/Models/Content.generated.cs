//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.0
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

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Content</summary>
	[PublishedModel("content")]
	public partial class Content : PublishedContentModel, IContentControls, IMetaDataControls, INavigationControls, IUmbracoUrlAliasControls, IXmlSiteMapSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "content";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Content, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Content(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Content Grid: Enter the content for the grid
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid => ContentControls.GetContentGrid(this);

		///<summary>
		/// Main Image: Choose an image to show as the main image on this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("mainImage")]
		public IPublishedContent MainImage => ContentControls.GetMainImage(this);

		///<summary>
		/// Title: Enter the title for this page. If you leave this blank, we will use the page name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("title")]
		public string Title => ContentControls.GetTitle(this);

		///<summary>
		/// Meta Description: Enter the meta description. This is what shows up in Google etc. If left blank, will use the page name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => MetaDataControls.GetMetaDescription(this);

		///<summary>
		/// Meta Keywords: Enter the meta keywords. This is used for Search Engine
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaKeywords")]
		public IEnumerable<string> MetaKeywords => MetaDataControls.GetMetaKeywords(this);

		///<summary>
		/// Meta Name: Enter the meta name. If left blank it will use the page name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaName")]
		public string MetaName => MetaDataControls.GetMetaName(this);

		///<summary>
		/// Disable Dropdown: Tick this box if you want to disable the dropdown for this item
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("disableDropdown")]
		public bool DisableDropdown => NavigationControls.GetDisableDropdown(this);

		///<summary>
		/// Text Only In Navigation: Tick this box if you want this item to be just text only in the navigation menu.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("textOnlyInNavigation")]
		public bool TextOnlyInNavigation => NavigationControls.GetTextOnlyInNavigation(this);

		///<summary>
		/// Umbraco Navi Hide: Tick this box if you want to hide it from the site.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide => NavigationControls.GetUmbracoNaviHide(this);

		///<summary>
		/// Umbraco Url Alias: Enter an alternate url in here. Please note that the values you use must be lowercase, not use a leading slash and not use a trailing ".aspx" or trailing slash. If you are adding multiple values, they must be separated with a comma.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias => UmbracoUrlAliasControls.GetUmbracoUrlAlias(this);

		///<summary>
		/// Hide From Xml Sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideFromXmlSitemap")]
		public bool HideFromXmlSitemap => XmlSiteMapSettings.GetHideFromXmlSitemap(this);

		///<summary>
		/// Search Engine Change Frequency
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("searchEngineChangeFrequency")]
		public string SearchEngineChangeFrequency => XmlSiteMapSettings.GetSearchEngineChangeFrequency(this);

		///<summary>
		/// Search Engine Relative Priority
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("searchEngineRelativePriority")]
		public decimal SearchEngineRelativePriority => XmlSiteMapSettings.GetSearchEngineRelativePriority(this);
	}
}