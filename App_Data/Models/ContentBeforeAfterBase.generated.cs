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
	// Mixin Content Type with alias "contentBeforeAfterBase"
	/// <summary>Content Before After Base</summary>
	public partial interface IContentBeforeAfterBase : IPublishedContent
	{
		/// <summary>Post Listing Content</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		IEnumerable<IPublishedElement> NestedContentAfter { get; }

		/// <summary>Pre Listing Content</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		IEnumerable<IPublishedElement> NestedContentBefore { get; }
	}

	/// <summary>Content Before After Base</summary>
	[PublishedModel("contentBeforeAfterBase")]
	public partial class ContentBeforeAfterBase : PublishedContentModel, IContentBeforeAfterBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "contentBeforeAfterBase";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContentBeforeAfterBase, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContentBeforeAfterBase(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Post Listing Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("nestedContentAfter")]
		public IEnumerable<IPublishedElement> NestedContentAfter => GetNestedContentAfter(this);

		/// <summary>Static getter for Post Listing Content</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IEnumerable<IPublishedElement> GetNestedContentAfter(IContentBeforeAfterBase that) => that.Value<IEnumerable<IPublishedElement>>("nestedContentAfter");

		///<summary>
		/// Pre Listing Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("nestedContentBefore")]
		public IEnumerable<IPublishedElement> NestedContentBefore => GetNestedContentBefore(this);

		/// <summary>Static getter for Pre Listing Content</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IEnumerable<IPublishedElement> GetNestedContentBefore(IContentBeforeAfterBase that) => that.Value<IEnumerable<IPublishedElement>>("nestedContentBefore");
	}
}
