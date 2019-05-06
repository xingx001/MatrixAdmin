﻿using Core.Web.Identifiers;

namespace Core.Web.GridFilter
{
    public abstract class BaseGridFilter
    {
        protected readonly string ContainerClass = "custom-control-inline";
        private readonly string type;

        protected BaseGridFilter(string labelText, string inputName, TextBoxTypeEnum type = default)
        {
            this.LabelText = labelText;
            this.InputName = inputName;
            this.type = EnumMappings.ToString(type);
        }

        protected string InputName { get; set; }

        protected string LabelText { get; }

        public virtual string Render()
        {
            string id = new Identifier().Value;
            return $"<div class=\"{this.ContainerClass}\">" +
                   $"<div class=\"form-group\">" +
                   $"<label for=\"{id}\">{this.LabelText}</label>" +
                   $"<input class=\"form-control\" id=\"{id}\" name=\"{this.InputName}\" type=\"{this.type}\">" +
                   $"</div>" +
                   $"</div>";
        }
    }
}