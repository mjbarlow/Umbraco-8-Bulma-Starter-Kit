//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.0.4
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

namespace U8StarterKit.Web.Models.Umbraco
{
	/// <summary>Home</summary>
	[PublishedModel("home")]
	public partial class Home : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "home";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Home(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("bodyText")]
		public Newtonsoft.Json.Linq.JToken BodyText => this.Value<Newtonsoft.Json.Linq.JToken>("bodyText");

		///<summary>
		/// Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("footerAddress")]
		public string FooterAddress => this.Value<string>("footerAddress");

		///<summary>
		/// Call To Action Caption: Caption on the Call To Action Button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("footerCTACaption")]
		public string FooterCtacaption => this.Value<string>("footerCTACaption");

		///<summary>
		/// Call To Action Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("footerCtalink")]
		public IPublishedContent FooterCtalink => this.Value<IPublishedContent>("footerCtalink");

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("footerDescription")]
		public string FooterDescription => this.Value<string>("footerDescription");

		///<summary>
		/// Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("footerHeader")]
		public string FooterHeader => this.Value<string>("footerHeader");

		///<summary>
		/// Hero Background: Spice up the homepage by adding a beautiful photo that relates to your business
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("heroBackgroundImage")]
		public IPublishedContent HeroBackgroundImage => this.Value<IPublishedContent>("heroBackgroundImage");

		///<summary>
		/// Call To Action Caption: The caption on the button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("heroCTACaption")]
		public string HeroCtacaption => this.Value<string>("heroCTACaption");

		///<summary>
		/// Call To Action Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("heroCTALink")]
		public IPublishedContent HeroCtalink => this.Value<IPublishedContent>("heroCTALink");

		///<summary>
		/// Hero CTA Sublink
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("heroCTASublink")]
		public IPublishedContent HeroCtasublink => this.Value<IPublishedContent>("heroCTASublink");

		///<summary>
		/// Hero CTA Sublink Caption
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("heroCTASublinkCaption")]
		public string HeroCtasublinkCaption => this.Value<string>("heroCTASublinkCaption");

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("heroDescription")]
		public IHtmlString HeroDescription => this.Value<IHtmlString>("heroDescription");

		///<summary>
		/// Header: This is the main headline for the hero area on the Homepage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("heroHeader")]
		public string HeroHeader => this.Value<string>("heroHeader");

		///<summary>
		/// Logo: Optional. If you add a logo it'll be used in the upper left corner instead of the site name. Make sure to use a transparent logo for best results
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("siteLogo")]
		public IPublishedContent SiteLogo => this.Value<IPublishedContent>("siteLogo");

		///<summary>
		/// Sitename: Used on the homepage as well as the title and social cards
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("sitename")]
		public string Sitename => this.Value<string>("sitename");
	}
}
