﻿using System.Threading;
using System.Resources;

namespace Core.Mvc.Resource.Areas.Administration.SearchFilterConfigurations
{
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class IconSearchFilterConfigurationResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.SearchFilterConfigurations.IconSearchFilterConfigurationResource", typeof(IconSearchFilterConfigurationResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for ClearButtonLabel.
		/// </summary>
		public static string ClearButtonLabel { get { return GetResourceString("ClearButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for ClearButtonToolTip.
		/// </summary>
		public static string ClearButtonToolTip { get { return GetResourceString("ClearButtonToolTip"); } }

		/// <summary>
		/// Gets the localized string for Code.
		/// </summary>
		public static string Code { get { return GetResourceString("Code"); } }

		/// <summary>
		/// Gets the localized string for Disable.
		/// </summary>
		public static string Disable { get { return GetResourceString("Disable"); } }

		/// <summary>
		/// Gets the localized string for Enable.
		/// </summary>
		public static string Enable { get { return GetResourceString("Enable"); } }

		/// <summary>
		/// Gets the localized string for SearchButtonLabel.
		/// </summary>
		public static string SearchButtonLabel { get { return GetResourceString("SearchButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for Status.
		/// </summary>
		public static string Status { get { return GetResourceString("Status"); } }
	}
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class MenuSearchFilterConfigurationResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.SearchFilterConfigurations.MenuSearchFilterConfigurationResource", typeof(MenuSearchFilterConfigurationResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for AddButtonLabel.
		/// </summary>
		public static string AddButtonLabel { get { return GetResourceString("AddButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for ClearButtonLabel.
		/// </summary>
		public static string ClearButtonLabel { get { return GetResourceString("ClearButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for Description.
		/// </summary>
		public static string Description { get { return GetResourceString("Description"); } }

		/// <summary>
		/// Gets the localized string for EndCreateTime.
		/// </summary>
		public static string EndCreateTime { get { return GetResourceString("EndCreateTime"); } }

		/// <summary>
		/// Gets the localized string for MenuName.
		/// </summary>
		public static string MenuName { get { return GetResourceString("MenuName"); } }

		/// <summary>
		/// Gets the localized string for SearchButtonLabel.
		/// </summary>
		public static string SearchButtonLabel { get { return GetResourceString("SearchButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for StartCreateTime.
		/// </summary>
		public static string StartCreateTime { get { return GetResourceString("StartCreateTime"); } }
	}
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class PermissionSearchFilterConfigurationResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.SearchFilterConfigurations.PermissionSearchFilterConfigurationResource", typeof(PermissionSearchFilterConfigurationResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for ActionCode.
		/// </summary>
		public static string ActionCode { get { return GetResourceString("ActionCode"); } }

		/// <summary>
		/// Gets the localized string for AddButtonLabel.
		/// </summary>
		public static string AddButtonLabel { get { return GetResourceString("AddButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for ClearButtonLabel.
		/// </summary>
		public static string ClearButtonLabel { get { return GetResourceString("ClearButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for Description.
		/// </summary>
		public static string Description { get { return GetResourceString("Description"); } }

		/// <summary>
		/// Gets the localized string for EndCreateTime.
		/// </summary>
		public static string EndCreateTime { get { return GetResourceString("EndCreateTime"); } }

		/// <summary>
		/// Gets the localized string for IsEnable.
		/// </summary>
		public static string IsEnable { get { return GetResourceString("IsEnable"); } }

		/// <summary>
		/// Gets the localized string for Name.
		/// </summary>
		public static string Name { get { return GetResourceString("Name"); } }

		/// <summary>
		/// Gets the localized string for SearchButtonLabel.
		/// </summary>
		public static string SearchButtonLabel { get { return GetResourceString("SearchButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for StartCreateTime.
		/// </summary>
		public static string StartCreateTime { get { return GetResourceString("StartCreateTime"); } }
	}
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class RoleSearchFilterConfigurationResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.SearchFilterConfigurations.RoleSearchFilterConfigurationResource", typeof(RoleSearchFilterConfigurationResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for AddButtonLabel.
		/// </summary>
		public static string AddButtonLabel { get { return GetResourceString("AddButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for ClearButtonLabel.
		/// </summary>
		public static string ClearButtonLabel { get { return GetResourceString("ClearButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for Description.
		/// </summary>
		public static string Description { get { return GetResourceString("Description"); } }

		/// <summary>
		/// Gets the localized string for EndCreateTime.
		/// </summary>
		public static string EndCreateTime { get { return GetResourceString("EndCreateTime"); } }

		/// <summary>
		/// Gets the localized string for Name.
		/// </summary>
		public static string Name { get { return GetResourceString("Name"); } }

		/// <summary>
		/// Gets the localized string for RoleName.
		/// </summary>
		public static string RoleName { get { return GetResourceString("RoleName"); } }

		/// <summary>
		/// Gets the localized string for SearchButtonLabel.
		/// </summary>
		public static string SearchButtonLabel { get { return GetResourceString("SearchButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for StartCreateTime.
		/// </summary>
		public static string StartCreateTime { get { return GetResourceString("StartCreateTime"); } }
	}
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class UserSearchFilterConfigurationResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.SearchFilterConfigurations.UserSearchFilterConfigurationResource", typeof(UserSearchFilterConfigurationResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for AddButtonLabel.
		/// </summary>
		public static string AddButtonLabel { get { return GetResourceString("AddButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for ClearButtonLabel.
		/// </summary>
		public static string ClearButtonLabel { get { return GetResourceString("ClearButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for Description.
		/// </summary>
		public static string Description { get { return GetResourceString("Description"); } }

		/// <summary>
		/// Gets the localized string for DisplayName.
		/// </summary>
		public static string DisplayName { get { return GetResourceString("DisplayName"); } }

		/// <summary>
		/// Gets the localized string for EndCreateTime.
		/// </summary>
		public static string EndCreateTime { get { return GetResourceString("EndCreateTime"); } }

		/// <summary>
		/// Gets the localized string for Forbidden.
		/// </summary>
		public static string Forbidden { get { return GetResourceString("Forbidden"); } }

		/// <summary>
		/// Gets the localized string for ForbiddenStatus.
		/// </summary>
		public static string ForbiddenStatus { get { return GetResourceString("ForbiddenStatus"); } }

		/// <summary>
		/// Gets the localized string for LoginName.
		/// </summary>
		public static string LoginName { get { return GetResourceString("LoginName"); } }

		/// <summary>
		/// Gets the localized string for Name.
		/// </summary>
		public static string Name { get { return GetResourceString("Name"); } }

		/// <summary>
		/// Gets the localized string for Normal.
		/// </summary>
		public static string Normal { get { return GetResourceString("Normal"); } }

		/// <summary>
		/// Gets the localized string for Role.
		/// </summary>
		public static string Role { get { return GetResourceString("Role"); } }

		/// <summary>
		/// Gets the localized string for RoleName.
		/// </summary>
		public static string RoleName { get { return GetResourceString("RoleName"); } }

		/// <summary>
		/// Gets the localized string for SearchButtonLabel.
		/// </summary>
		public static string SearchButtonLabel { get { return GetResourceString("SearchButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for StartCreateTime.
		/// </summary>
		public static string StartCreateTime { get { return GetResourceString("StartCreateTime"); } }
	}
}

namespace Core.Mvc.Resource.Areas.Administration.ViewConfiguration.Icon
{
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class IconResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.ViewConfiguration.Icon.IconResource", typeof(IconResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for Code.
		/// </summary>
		public static string Code { get { return GetResourceString("Code"); } }

		/// <summary>
		/// Gets the localized string for Color.
		/// </summary>
		public static string Color { get { return GetResourceString("Color"); } }

		/// <summary>
		/// Gets the localized string for CreatedByUserName.
		/// </summary>
		public static string CreatedByUserName { get { return GetResourceString("CreatedByUserName"); } }

		/// <summary>
		/// Gets the localized string for CreatedOn.
		/// </summary>
		public static string CreatedOn { get { return GetResourceString("CreatedOn"); } }

		/// <summary>
		/// Gets the localized string for Custom.
		/// </summary>
		public static string Custom { get { return GetResourceString("Custom"); } }

		/// <summary>
		/// Gets the localized string for Icon.
		/// </summary>
		public static string Icon { get { return GetResourceString("Icon"); } }

		/// <summary>
		/// Gets the localized string for Size.
		/// </summary>
		public static string Size { get { return GetResourceString("Size"); } }

		/// <summary>
		/// Gets the localized string for Status.
		/// </summary>
		public static string Status { get { return GetResourceString("Status"); } }
	}
}

namespace Core.Mvc.Resource.Areas.Administration.ViewConfiguration.Menu
{
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class AddMenuDialogConfigurationResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.ViewConfiguration.Menu.AddMenuDialogConfigurationResource", typeof(AddMenuDialogConfigurationResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for AddMenuTitle.
		/// </summary>
		public static string AddMenuTitle { get { return GetResourceString("AddMenuTitle"); } }

		/// <summary>
		/// Gets the localized string for Alias.
		/// </summary>
		public static string Alias { get { return GetResourceString("Alias"); } }

		/// <summary>
		/// Gets the localized string for Cancel.
		/// </summary>
		public static string Cancel { get { return GetResourceString("Cancel"); } }

		/// <summary>
		/// Gets the localized string for Description.
		/// </summary>
		public static string Description { get { return GetResourceString("Description"); } }

		/// <summary>
		/// Gets the localized string for Name.
		/// </summary>
		public static string Name { get { return GetResourceString("Name"); } }

		/// <summary>
		/// Gets the localized string for Sort.
		/// </summary>
		public static string Sort { get { return GetResourceString("Sort"); } }

		/// <summary>
		/// Gets the localized string for Submit.
		/// </summary>
		public static string Submit { get { return GetResourceString("Submit"); } }

		/// <summary>
		/// Gets the localized string for Url.
		/// </summary>
		public static string Url { get { return GetResourceString("Url"); } }
	}
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class EditMenuDialogConfigurationResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.ViewConfiguration.Menu.EditMenuDialogConfigurationResource", typeof(EditMenuDialogConfigurationResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for Alias.
		/// </summary>
		public static string Alias { get { return GetResourceString("Alias"); } }

		/// <summary>
		/// Gets the localized string for Cancel.
		/// </summary>
		public static string Cancel { get { return GetResourceString("Cancel"); } }

		/// <summary>
		/// Gets the localized string for Description.
		/// </summary>
		public static string Description { get { return GetResourceString("Description"); } }

		/// <summary>
		/// Gets the localized string for EditMenuTitle.
		/// </summary>
		public static string EditMenuTitle { get { return GetResourceString("EditMenuTitle"); } }

		/// <summary>
		/// Gets the localized string for Name.
		/// </summary>
		public static string Name { get { return GetResourceString("Name"); } }

		/// <summary>
		/// Gets the localized string for Sort.
		/// </summary>
		public static string Sort { get { return GetResourceString("Sort"); } }

		/// <summary>
		/// Gets the localized string for Submit.
		/// </summary>
		public static string Submit { get { return GetResourceString("Submit"); } }

		/// <summary>
		/// Gets the localized string for Url.
		/// </summary>
		public static string Url { get { return GetResourceString("Url"); } }
	}
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class MenuIndexResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.ViewConfiguration.Menu.MenuIndexResource", typeof(MenuIndexResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for Alias.
		/// </summary>
		public static string Alias { get { return GetResourceString("Alias"); } }

		/// <summary>
		/// Gets the localized string for CreateByUserName.
		/// </summary>
		public static string CreateByUserName { get { return GetResourceString("CreateByUserName"); } }

		/// <summary>
		/// Gets the localized string for CreateTime.
		/// </summary>
		public static string CreateTime { get { return GetResourceString("CreateTime"); } }

		/// <summary>
		/// Gets the localized string for Delete.
		/// </summary>
		public static string Delete { get { return GetResourceString("Delete"); } }

		/// <summary>
		/// Gets the localized string for Description.
		/// </summary>
		public static string Description { get { return GetResourceString("Description"); } }

		/// <summary>
		/// Gets the localized string for Edit.
		/// </summary>
		public static string Edit { get { return GetResourceString("Edit"); } }

		/// <summary>
		/// Gets the localized string for Forbidden.
		/// </summary>
		public static string Forbidden { get { return GetResourceString("Forbidden"); } }

		/// <summary>
		/// Gets the localized string for IsDefaultRouter.
		/// </summary>
		public static string IsDefaultRouter { get { return GetResourceString("IsDefaultRouter"); } }

		/// <summary>
		/// Gets the localized string for MenuManageTitle.
		/// </summary>
		public static string MenuManageTitle { get { return GetResourceString("MenuManageTitle"); } }

		/// <summary>
		/// Gets the localized string for Name.
		/// </summary>
		public static string Name { get { return GetResourceString("Name"); } }

		/// <summary>
		/// Gets the localized string for Normal.
		/// </summary>
		public static string Normal { get { return GetResourceString("Normal"); } }

		/// <summary>
		/// Gets the localized string for ParentName.
		/// </summary>
		public static string ParentName { get { return GetResourceString("ParentName"); } }

		/// <summary>
		/// Gets the localized string for Recover.
		/// </summary>
		public static string Recover { get { return GetResourceString("Recover"); } }

		/// <summary>
		/// Gets the localized string for RowContextMenu.
		/// </summary>
		public static string RowContextMenu { get { return GetResourceString("RowContextMenu"); } }

		/// <summary>
		/// Gets the localized string for Sort.
		/// </summary>
		public static string Sort { get { return GetResourceString("Sort"); } }

		/// <summary>
		/// Gets the localized string for Status.
		/// </summary>
		public static string Status { get { return GetResourceString("Status"); } }

		/// <summary>
		/// Gets the localized string for UpdateByUserName.
		/// </summary>
		public static string UpdateByUserName { get { return GetResourceString("UpdateByUserName"); } }

		/// <summary>
		/// Gets the localized string for UpdateTime.
		/// </summary>
		public static string UpdateTime { get { return GetResourceString("UpdateTime"); } }

		/// <summary>
		/// Gets the localized string for Url.
		/// </summary>
		public static string Url { get { return GetResourceString("Url"); } }

		/// <summary>
		/// Gets the localized string for WidgetTitle.
		/// </summary>
		public static string WidgetTitle { get { return GetResourceString("WidgetTitle"); } }
	}
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class MenuRowContextMenu
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.ViewConfiguration.Menu.MenuRowContextMenu", typeof(MenuRowContextMenu).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for Alias.
		/// </summary>
		public static string Alias { get { return GetResourceString("Alias"); } }

		/// <summary>
		/// Gets the localized string for CreateByUserName.
		/// </summary>
		public static string CreateByUserName { get { return GetResourceString("CreateByUserName"); } }

		/// <summary>
		/// Gets the localized string for CreateTime.
		/// </summary>
		public static string CreateTime { get { return GetResourceString("CreateTime"); } }

		/// <summary>
		/// Gets the localized string for Delete.
		/// </summary>
		public static string Delete { get { return GetResourceString("Delete"); } }

		/// <summary>
		/// Gets the localized string for Description.
		/// </summary>
		public static string Description { get { return GetResourceString("Description"); } }

		/// <summary>
		/// Gets the localized string for Edit.
		/// </summary>
		public static string Edit { get { return GetResourceString("Edit"); } }

		/// <summary>
		/// Gets the localized string for Forbidden.
		/// </summary>
		public static string Forbidden { get { return GetResourceString("Forbidden"); } }

		/// <summary>
		/// Gets the localized string for IsDefaultRouter.
		/// </summary>
		public static string IsDefaultRouter { get { return GetResourceString("IsDefaultRouter"); } }

		/// <summary>
		/// Gets the localized string for MenuManageTitle.
		/// </summary>
		public static string MenuManageTitle { get { return GetResourceString("MenuManageTitle"); } }

		/// <summary>
		/// Gets the localized string for Name.
		/// </summary>
		public static string Name { get { return GetResourceString("Name"); } }

		/// <summary>
		/// Gets the localized string for Normal.
		/// </summary>
		public static string Normal { get { return GetResourceString("Normal"); } }

		/// <summary>
		/// Gets the localized string for ParentName.
		/// </summary>
		public static string ParentName { get { return GetResourceString("ParentName"); } }

		/// <summary>
		/// Gets the localized string for Recover.
		/// </summary>
		public static string Recover { get { return GetResourceString("Recover"); } }

		/// <summary>
		/// Gets the localized string for RowContextMenu.
		/// </summary>
		public static string RowContextMenu { get { return GetResourceString("RowContextMenu"); } }

		/// <summary>
		/// Gets the localized string for Sort.
		/// </summary>
		public static string Sort { get { return GetResourceString("Sort"); } }

		/// <summary>
		/// Gets the localized string for Status.
		/// </summary>
		public static string Status { get { return GetResourceString("Status"); } }

		/// <summary>
		/// Gets the localized string for UpdateByUserName.
		/// </summary>
		public static string UpdateByUserName { get { return GetResourceString("UpdateByUserName"); } }

		/// <summary>
		/// Gets the localized string for UpdateTime.
		/// </summary>
		public static string UpdateTime { get { return GetResourceString("UpdateTime"); } }

		/// <summary>
		/// Gets the localized string for Url.
		/// </summary>
		public static string Url { get { return GetResourceString("Url"); } }

		/// <summary>
		/// Gets the localized string for WidgetTitle.
		/// </summary>
		public static string WidgetTitle { get { return GetResourceString("WidgetTitle"); } }
	}
}

namespace Core.Mvc.Resource.Areas.Administration.ViewConfiguration.Permission
{
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class PermissionIndexResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.ViewConfiguration.Permission.PermissionIndexResource", typeof(PermissionIndexResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for ActionCode.
		/// </summary>
		public static string ActionCode { get { return GetResourceString("ActionCode"); } }

		/// <summary>
		/// Gets the localized string for CreatedByUserName.
		/// </summary>
		public static string CreatedByUserName { get { return GetResourceString("CreatedByUserName"); } }

		/// <summary>
		/// Gets the localized string for CreatedOn.
		/// </summary>
		public static string CreatedOn { get { return GetResourceString("CreatedOn"); } }

		/// <summary>
		/// Gets the localized string for Name.
		/// </summary>
		public static string Name { get { return GetResourceString("Name"); } }

		/// <summary>
		/// Gets the localized string for Status.
		/// </summary>
		public static string Status { get { return GetResourceString("Status"); } }

		/// <summary>
		/// Gets the localized string for WidgetTitle.
		/// </summary>
		public static string WidgetTitle { get { return GetResourceString("WidgetTitle"); } }
	}
}

namespace Core.Mvc.Resource.Areas.Administration.ViewConfiguration.Role
{
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class RoleIndexResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.ViewConfiguration.Role.RoleIndexResource", typeof(RoleIndexResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for AddRoleDialogTitle.
		/// </summary>
		public static string AddRoleDialogTitle { get { return GetResourceString("AddRoleDialogTitle"); } }

		/// <summary>
		/// Gets the localized string for CreatedByUserName.
		/// </summary>
		public static string CreatedByUserName { get { return GetResourceString("CreatedByUserName"); } }

		/// <summary>
		/// Gets the localized string for CreatedOn.
		/// </summary>
		public static string CreatedOn { get { return GetResourceString("CreatedOn"); } }

		/// <summary>
		/// Gets the localized string for EditRoleDialogTitle.
		/// </summary>
		public static string EditRoleDialogTitle { get { return GetResourceString("EditRoleDialogTitle"); } }

		/// <summary>
		/// Gets the localized string for IsBuiltin.
		/// </summary>
		public static string IsBuiltin { get { return GetResourceString("IsBuiltin"); } }

		/// <summary>
		/// Gets the localized string for IsSuperAdministrator.
		/// </summary>
		public static string IsSuperAdministrator { get { return GetResourceString("IsSuperAdministrator"); } }

		/// <summary>
		/// Gets the localized string for Name.
		/// </summary>
		public static string Name { get { return GetResourceString("Name"); } }

		/// <summary>
		/// Gets the localized string for Status.
		/// </summary>
		public static string Status { get { return GetResourceString("Status"); } }

		/// <summary>
		/// Gets the localized string for WidgetTitle.
		/// </summary>
		public static string WidgetTitle { get { return GetResourceString("WidgetTitle"); } }
	}
}

namespace Core.Mvc.Resource.Areas.Administration.ViewConfiguration.User
{
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class AddUserDialogConfigurationResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.ViewConfiguration.User.AddUserDialogConfigurationResource", typeof(AddUserDialogConfigurationResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for Admin.
		/// </summary>
		public static string Admin { get { return GetResourceString("Admin"); } }

		/// <summary>
		/// Gets the localized string for Cancel.
		/// </summary>
		public static string Cancel { get { return GetResourceString("Cancel"); } }

		/// <summary>
		/// Gets the localized string for Description.
		/// </summary>
		public static string Description { get { return GetResourceString("Description"); } }

		/// <summary>
		/// Gets the localized string for DisplayName.
		/// </summary>
		public static string DisplayName { get { return GetResourceString("DisplayName"); } }

		/// <summary>
		/// Gets the localized string for GeneralUser.
		/// </summary>
		public static string GeneralUser { get { return GetResourceString("GeneralUser"); } }

		/// <summary>
		/// Gets the localized string for LoginName.
		/// </summary>
		public static string LoginName { get { return GetResourceString("LoginName"); } }

		/// <summary>
		/// Gets the localized string for Password.
		/// </summary>
		public static string Password { get { return GetResourceString("Password"); } }

		/// <summary>
		/// Gets the localized string for Submit.
		/// </summary>
		public static string Submit { get { return GetResourceString("Submit"); } }

		/// <summary>
		/// Gets the localized string for SuperAdministrator.
		/// </summary>
		public static string SuperAdministrator { get { return GetResourceString("SuperAdministrator"); } }

		/// <summary>
		/// Gets the localized string for Title.
		/// </summary>
		public static string Title { get { return GetResourceString("Title"); } }

		/// <summary>
		/// Gets the localized string for UserRole.
		/// </summary>
		public static string UserRole { get { return GetResourceString("UserRole"); } }
	}
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class EditUserDialogConfigurationResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.ViewConfiguration.User.EditUserDialogConfigurationResource", typeof(EditUserDialogConfigurationResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for Admin.
		/// </summary>
		public static string Admin { get { return GetResourceString("Admin"); } }

		/// <summary>
		/// Gets the localized string for Cancel.
		/// </summary>
		public static string Cancel { get { return GetResourceString("Cancel"); } }

		/// <summary>
		/// Gets the localized string for DisplayName.
		/// </summary>
		public static string DisplayName { get { return GetResourceString("DisplayName"); } }

		/// <summary>
		/// Gets the localized string for GeneralUser.
		/// </summary>
		public static string GeneralUser { get { return GetResourceString("GeneralUser"); } }

		/// <summary>
		/// Gets the localized string for LoginName.
		/// </summary>
		public static string LoginName { get { return GetResourceString("LoginName"); } }

		/// <summary>
		/// Gets the localized string for Password.
		/// </summary>
		public static string Password { get { return GetResourceString("Password"); } }

		/// <summary>
		/// Gets the localized string for Submit.
		/// </summary>
		public static string Submit { get { return GetResourceString("Submit"); } }

		/// <summary>
		/// Gets the localized string for SuperAdministrator.
		/// </summary>
		public static string SuperAdministrator { get { return GetResourceString("SuperAdministrator"); } }

		/// <summary>
		/// Gets the localized string for Title.
		/// </summary>
		public static string Title { get { return GetResourceString("Title"); } }

		/// <summary>
		/// Gets the localized string for UserRole.
		/// </summary>
		public static string UserRole { get { return GetResourceString("UserRole"); } }
	}
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class UserIndexResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.ViewConfiguration.User.UserIndexResource", typeof(UserIndexResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for CreatedByUserName.
		/// </summary>
		public static string CreatedByUserName { get { return GetResourceString("CreatedByUserName"); } }

		/// <summary>
		/// Gets the localized string for CreatedOn.
		/// </summary>
		public static string CreatedOn { get { return GetResourceString("CreatedOn"); } }

		/// <summary>
		/// Gets the localized string for DisplayName.
		/// </summary>
		public static string DisplayName { get { return GetResourceString("DisplayName"); } }

		/// <summary>
		/// Gets the localized string for LoginName.
		/// </summary>
		public static string LoginName { get { return GetResourceString("LoginName"); } }

		/// <summary>
		/// Gets the localized string for Status.
		/// </summary>
		public static string Status { get { return GetResourceString("Status"); } }

		/// <summary>
		/// Gets the localized string for UserType.
		/// </summary>
		public static string UserType { get { return GetResourceString("UserType"); } }

		/// <summary>
		/// Gets the localized string for WidgetTitle.
		/// </summary>
		public static string WidgetTitle { get { return GetResourceString("WidgetTitle"); } }
	}
}

namespace Core.Mvc.Resource.Areas.Administration.ViewConfiguration
{
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class IndexBaseResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.ViewConfiguration.IndexBaseResource", typeof(IndexBaseResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for ErrorLog.
		/// </summary>
		public static string ErrorLog { get { return GetResourceString("ErrorLog"); } }

		/// <summary>
		/// Gets the localized string for IconManage.
		/// </summary>
		public static string IconManage { get { return GetResourceString("IconManage"); } }

		/// <summary>
		/// Gets the localized string for LogManage.
		/// </summary>
		public static string LogManage { get { return GetResourceString("LogManage"); } }

		/// <summary>
		/// Gets the localized string for MenuManage.
		/// </summary>
		public static string MenuManage { get { return GetResourceString("MenuManage"); } }

		/// <summary>
		/// Gets the localized string for PermissionManage.
		/// </summary>
		public static string PermissionManage { get { return GetResourceString("PermissionManage"); } }

		/// <summary>
		/// Gets the localized string for RoleManage.
		/// </summary>
		public static string RoleManage { get { return GetResourceString("RoleManage"); } }

		/// <summary>
		/// Gets the localized string for SystemManage.
		/// </summary>
		public static string SystemManage { get { return GetResourceString("SystemManage"); } }

		/// <summary>
		/// Gets the localized string for UserManage.
		/// </summary>
		public static string UserManage { get { return GetResourceString("UserManage"); } }
	}
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class SidebarNavigationResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Administration.ViewConfiguration.SidebarNavigationResource", typeof(SidebarNavigationResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for AddonsTitle.
		/// </summary>
		public static string AddonsTitle { get { return GetResourceString("AddonsTitle"); } }

		/// <summary>
		/// Gets the localized string for Buttons.
		/// </summary>
		public static string Buttons { get { return GetResourceString("Buttons"); } }

		/// <summary>
		/// Gets the localized string for Calendar.
		/// </summary>
		public static string Calendar { get { return GetResourceString("Calendar"); } }

		/// <summary>
		/// Gets the localized string for Charts.
		/// </summary>
		public static string Charts { get { return GetResourceString("Charts"); } }

		/// <summary>
		/// Gets the localized string for Chat.
		/// </summary>
		public static string Chat { get { return GetResourceString("Chat"); } }

		/// <summary>
		/// Gets the localized string for DashboardTitle.
		/// </summary>
		public static string DashboardTitle { get { return GetResourceString("DashboardTitle"); } }

		/// <summary>
		/// Gets the localized string for Error403.
		/// </summary>
		public static string Error403 { get { return GetResourceString("Error403"); } }

		/// <summary>
		/// Gets the localized string for Error404.
		/// </summary>
		public static string Error404 { get { return GetResourceString("Error404"); } }

		/// <summary>
		/// Gets the localized string for Error405.
		/// </summary>
		public static string Error405 { get { return GetResourceString("Error405"); } }

		/// <summary>
		/// Gets the localized string for Error500.
		/// </summary>
		public static string Error500 { get { return GetResourceString("Error500"); } }

		/// <summary>
		/// Gets the localized string for ErrorTitle.
		/// </summary>
		public static string ErrorTitle { get { return GetResourceString("ErrorTitle"); } }

		/// <summary>
		/// Gets the localized string for FormCommon.
		/// </summary>
		public static string FormCommon { get { return GetResourceString("FormCommon"); } }

		/// <summary>
		/// Gets the localized string for FormsTitle.
		/// </summary>
		public static string FormsTitle { get { return GetResourceString("FormsTitle"); } }

		/// <summary>
		/// Gets the localized string for FormValidation.
		/// </summary>
		public static string FormValidation { get { return GetResourceString("FormValidation"); } }

		/// <summary>
		/// Gets the localized string for FormWizard.
		/// </summary>
		public static string FormWizard { get { return GetResourceString("FormWizard"); } }

		/// <summary>
		/// Gets the localized string for Gallery.
		/// </summary>
		public static string Gallery { get { return GetResourceString("Gallery"); } }

		/// <summary>
		/// Gets the localized string for Grid.
		/// </summary>
		public static string Grid { get { return GetResourceString("Grid"); } }

		/// <summary>
		/// Gets the localized string for Index2.
		/// </summary>
		public static string Index2 { get { return GetResourceString("Index2"); } }

		/// <summary>
		/// Gets the localized string for Interface.
		/// </summary>
		public static string Interface { get { return GetResourceString("Interface"); } }

		/// <summary>
		/// Gets the localized string for Invoice.
		/// </summary>
		public static string Invoice { get { return GetResourceString("Invoice"); } }

		/// <summary>
		/// Gets the localized string for Tables.
		/// </summary>
		public static string Tables { get { return GetResourceString("Tables"); } }

		/// <summary>
		/// Gets the localized string for Widgets.
		/// </summary>
		public static string Widgets { get { return GetResourceString("Widgets"); } }
	}
}

namespace Core.Mvc.Resource.Areas.AdvancedDropDown
{
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class AdvancedDropDownIndexResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.AdvancedDropDown.AdvancedDropDownIndexResource", typeof(AdvancedDropDownIndexResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for MenuName.
		/// </summary>
		public static string MenuName { get { return GetResourceString("MenuName"); } }

		/// <summary>
		/// Gets the localized string for RoleName.
		/// </summary>
		public static string RoleName { get { return GetResourceString("RoleName"); } }

		/// <summary>
		/// Gets the localized string for UserName.
		/// </summary>
		public static string UserName { get { return GetResourceString("UserName"); } }
	}
}

namespace Core.Mvc.Resource.Areas.Log.SearchFilterConfigurations
{
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class LogSearchFilterConfigurationResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Log.SearchFilterConfigurations.LogSearchFilterConfigurationResource", typeof(LogSearchFilterConfigurationResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for ClearButtonLabel.
		/// 删除所有日志
		/// </summary>
		public static string ClearButtonLabel { get { return GetResourceString("ClearButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for ClearButtonToolTip.
		/// </summary>
		public static string ClearButtonToolTip { get { return GetResourceString("ClearButtonToolTip"); } }

		/// <summary>
		/// Gets the localized string for ClearEmptyButtonLabel.
		/// 清空搜索条件
		/// </summary>
		public static string ClearEmptyButtonLabel { get { return GetResourceString("ClearEmptyButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for ClearEmptyButtonToolTip.
		/// </summary>
		public static string ClearEmptyButtonToolTip { get { return GetResourceString("ClearEmptyButtonToolTip"); } }

		/// <summary>
		/// Gets the localized string for Create.
		/// </summary>
		public static string Create { get { return GetResourceString("Create"); } }

		/// <summary>
		/// Gets the localized string for Debug.
		/// </summary>
		public static string Debug { get { return GetResourceString("Debug"); } }

		/// <summary>
		/// Gets the localized string for Delete.
		/// </summary>
		public static string Delete { get { return GetResourceString("Delete"); } }

		/// <summary>
		/// Gets the localized string for EndTime.
		/// </summary>
		public static string EndTime { get { return GetResourceString("EndTime"); } }

		/// <summary>
		/// Gets the localized string for Error.
		/// </summary>
		public static string Error { get { return GetResourceString("Error"); } }

		/// <summary>
		/// Gets the localized string for ID.
		/// </summary>
		public static string ID { get { return GetResourceString("ID"); } }

		/// <summary>
		/// Gets the localized string for Information.
		/// </summary>
		public static string Information { get { return GetResourceString("Information"); } }

		/// <summary>
		/// Gets the localized string for Insert.
		/// </summary>
		public static string Insert { get { return GetResourceString("Insert"); } }

		/// <summary>
		/// Gets the localized string for LogLevel.
		/// </summary>
		public static string LogLevel { get { return GetResourceString("LogLevel"); } }

		/// <summary>
		/// Gets the localized string for Message.
		/// </summary>
		public static string Message { get { return GetResourceString("Message"); } }

		/// <summary>
		/// Gets the localized string for SearchButtonLabel.
		/// </summary>
		public static string SearchButtonLabel { get { return GetResourceString("SearchButtonLabel"); } }

		/// <summary>
		/// Gets the localized string for Select.
		/// </summary>
		public static string Select { get { return GetResourceString("Select"); } }

		/// <summary>
		/// Gets the localized string for SqlType.
		/// </summary>
		public static string SqlType { get { return GetResourceString("SqlType"); } }

		/// <summary>
		/// Gets the localized string for StartTime.
		/// </summary>
		public static string StartTime { get { return GetResourceString("StartTime"); } }

		/// <summary>
		/// Gets the localized string for Update.
		/// </summary>
		public static string Update { get { return GetResourceString("Update"); } }
	}
}

namespace Core.Mvc.Resource.Areas.Log.ViewConfiguration
{
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class ErrorResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Log.ViewConfiguration.ErrorResource", typeof(ErrorResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for Header.
		/// </summary>
		public static string Header { get { return GetResourceString("Header"); } }
	}
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class IndexBaseResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Log.ViewConfiguration.IndexBaseResource", typeof(IndexBaseResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for ErrorLog.
		/// </summary>
		public static string ErrorLog { get { return GetResourceString("ErrorLog"); } }

		/// <summary>
		/// Gets the localized string for IconManage.
		/// </summary>
		public static string IconManage { get { return GetResourceString("IconManage"); } }

		/// <summary>
		/// Gets the localized string for LogManage.
		/// </summary>
		public static string LogManage { get { return GetResourceString("LogManage"); } }

		/// <summary>
		/// Gets the localized string for MenuManage.
		/// </summary>
		public static string MenuManage { get { return GetResourceString("MenuManage"); } }

		/// <summary>
		/// Gets the localized string for PermissionManage.
		/// </summary>
		public static string PermissionManage { get { return GetResourceString("PermissionManage"); } }

		/// <summary>
		/// Gets the localized string for RoleManage.
		/// </summary>
		public static string RoleManage { get { return GetResourceString("RoleManage"); } }

		/// <summary>
		/// Gets the localized string for SystemManage.
		/// </summary>
		public static string SystemManage { get { return GetResourceString("SystemManage"); } }

		/// <summary>
		/// Gets the localized string for UserManage.
		/// </summary>
		public static string UserManage { get { return GetResourceString("UserManage"); } }
	}
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class LogGridConfigurationResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Log.ViewConfiguration.LogGridConfigurationResource", typeof(LogGridConfigurationResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for Copy.
		/// </summary>
		public static string Copy { get { return GetResourceString("Copy"); } }

		/// <summary>
		/// Gets the localized string for CreateTime.
		/// </summary>
		public static string CreateTime { get { return GetResourceString("CreateTime"); } }

		/// <summary>
		/// Gets the localized string for LogLevel.
		/// </summary>
		public static string LogLevel { get { return GetResourceString("LogLevel"); } }

		/// <summary>
		/// Gets the localized string for Message.
		/// </summary>
		public static string Message { get { return GetResourceString("Message"); } }

		/// <summary>
		/// Gets the localized string for SqlType.
		/// </summary>
		public static string SqlType { get { return GetResourceString("SqlType"); } }
	}
	/// <summary>
	/// A static class used to access a specific set of resources.
	/// </summary>
	public static class LogResource
	{
        private static ResourceManager resourceManager;
        
        /// <summary>
        /// Gets the cached ResourceManager instance used by this class.
        /// </summary>
        private static ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(resourceManager, null)) 
				{
                    resourceManager = new ResourceManager("Core.Mvc.Resource.Areas.Log.ViewConfiguration.LogResource", typeof(LogResource).Assembly);
                }
                return resourceManager;
            }
        }
        
        /// <summary>
        /// Returns the formatted resource string.
        /// </summary>
		/// <param name="key">The resource key.</param>
		/// <returns>The localized resource string.</returns>
        private static string GetResourceString(string key)
		{
			var culture = Thread.CurrentThread.CurrentCulture;
            return ResourceManager.GetString(key, culture);
        }
		
		/// <summary>
		/// Gets the localized string for CreateTime.
		/// </summary>
		public static string CreateTime { get { return GetResourceString("CreateTime"); } }

		/// <summary>
		/// Gets the localized string for ID.
		/// </summary>
		public static string ID { get { return GetResourceString("ID"); } }

		/// <summary>
		/// Gets the localized string for Message.
		/// </summary>
		public static string Message { get { return GetResourceString("Message"); } }
	}
}
