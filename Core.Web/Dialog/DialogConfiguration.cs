﻿using System.Collections.Generic;
using Core.Shared.Utilities;
using Core.Web.Button;
using Core.Web.Html;
using Core.Web.Identifiers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Core.Web.Dialog
{
    public abstract class DialogConfiguration<TPostModel, TModel> : IHtmlContent<TPostModel, TModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogConfiguration{TPostModel, TModel}"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="identifier">The id.</param>
        protected DialogConfiguration(Identifier identifier, TModel model = default)
        {
            Check.NotNull(identifier, nameof(identifier));

            this.Model = model;
            this.Identifier = identifier;
        }

        public TModel Model { get; }

        public abstract string Title { get; }

        public Identifier Identifier { get; }

        private TagHelperOutput Buttons
        {
            get
            {
                IList<StandardButton> buttons = new List<StandardButton>();
                this.CreateButtons(buttons);
                TagHelperOutput content = default;
                foreach (var item in buttons)
                {
                    if (content == default)
                    {
                        content = item.Render();
                    }
                    else
                    {
                        content.PostElement.AppendHtml(item.Render());
                    }
                }

                return content;
            }
        }

        private TagHelperOutput Body
        {
            get
            {
                IList<IHtmlContent<TPostModel, TModel>> textBoxes = new List<IHtmlContent<TPostModel, TModel>>();
                this.CreateBody(textBoxes);
                this.CreateHiddenValues(textBoxes);
                TagHelperOutput content = default;
                foreach (var item in textBoxes)
                {
                    if (content == default)
                    {
                        content = item.Render(this.Model);
                    }
                    else
                    {
                        content.PostElement.AppendHtml(item.Render(this.Model));
                    }
                }

                return content;
            }
        }

        public virtual TagHelperOutput Render(TModel model)
        {
            TagHelperAttributeList attributes = new TagHelperAttributeList { { "type", "button" }, { "class", "close" }, { "data-dismiss", "modal" }, };

            var headerTitle = HtmlContent.TagHelper("h4", new TagHelperAttribute("class", "modal-title"), this.Title);
            var headerButton = HtmlContent.TagHelper("button", attributes, "&times;");
            var modalHeader = HtmlContent.TagHelper("div", new TagHelperAttribute("class", "modal-header"), headerTitle, headerButton);
            var modalBody = HtmlContent.TagHelper("div", new TagHelperAttribute("class", "modal-body"), this.Body);
            var modalFooter = HtmlContent.TagHelper("div", new TagHelperAttribute("class", "modal-footer"), this.Buttons);
            var modalContent = HtmlContent.TagHelper("div", new TagHelperAttribute("class", "modal-content"), modalHeader, modalBody, modalFooter);
            var modalDialog = HtmlContent.TagHelper("div", new TagHelperAttribute("class", "modal-dialog modal-lg"), modalContent);

            return HtmlContent.TagHelper("div", new TagHelperAttributeList { { "class", "modal fade" }, { "id", this.Identifier.Value }, }, modalDialog);
        }

        protected abstract void CreateButtons(IList<StandardButton> buttons);

        protected abstract void CreateBody(IList<IHtmlContent<TPostModel, TModel>> textBoxes);

        protected abstract void CreateHiddenValues(IList<IHtmlContent<TPostModel, TModel>> textBoxes);
    }
}
