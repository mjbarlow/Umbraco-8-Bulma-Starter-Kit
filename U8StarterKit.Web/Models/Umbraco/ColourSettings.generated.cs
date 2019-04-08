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
	// Mixin Content Type with alias "colourSettings"
	/// <summary>Colour Settings</summary>
	public partial interface IColourSettings : IPublishedElement
	{
		/// <summary>Background Color</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		global::Umbraco.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor BackgroundColor { get; }
	}

	/// <summary>Colour Settings</summary>
	[PublishedModel("colourSettings")]
	public partial class ColourSettings : PublishedElementModel, IColourSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "colourSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ColourSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ColourSettings(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Background Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("backgroundColor")]
		public global::Umbraco.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor BackgroundColor => GetBackgroundColor(this);

		/// <summary>Static getter for Background Color</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static global::Umbraco.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor GetBackgroundColor(IColourSettings that) => that.Value<global::Umbraco.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor>("backgroundColor");
	}
}