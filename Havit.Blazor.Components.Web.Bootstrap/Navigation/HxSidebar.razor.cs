﻿namespace Havit.Blazor.Components.Web.Bootstrap
{
	/// <summary>
	/// Sidebar component - responsive navigation sidebar.<br />
	/// Full documentation and demos: <see href="https://havit.blazor.eu/components/HxSidebar">https://havit.blazor.eu/components/HxSidebar</see>
	/// </summary>
	public partial class HxSidebar : ComponentBase
	{
		/// <summary>
		/// Sidebar header.
		/// </summary>
		[Parameter] public RenderFragment HeaderTemplate { get; set; }

		/// <summary>
		/// Sidebar items. Use <see cref="HxSidebarItem"/>.
		/// </summary>
		[Parameter] public RenderFragment ItemsTemplate { get; set; }

		/// <summary>
		/// Icon for expanding the desktop version. Use <see cref="TogglerTemplate" /> for more specific customization.
		/// </summary>
		[Parameter] public IconBase ExpandIcon { get; set; } = BootstrapIcon.ChevronBarRight;

		/// <summary>
		/// Icon for collapsing the desktop version. Use <see cref="TogglerTemplate" /> for more specific customization.
		/// </summary>
		[Parameter] public IconBase CollapseIcon { get; set; } = BootstrapIcon.ChevronBarLeft;

		/// <summary>
		/// Sidebar footer (e.g. logged user, language switch, ...).
		/// </summary>
		[Parameter] public RenderFragment FooterTemplate { get; set; }

		/// <summary>
		/// Vertical toggler (desktop version) to be rendered instead of the <see cref="ExpandIcon"/> and <see cref="CollapseIcon"/> icon.
		/// </summary>
		[Parameter] public RenderFragment TogglerTemplate { get; set; }

		/// <summary>
		/// Additional CSS class.
		/// </summary>
		[Parameter] public string CssClass { get; set; }

		/// <summary>
		/// ID of the root sidebar HTML element.
		/// (Autogenerated if not set.)
		/// </summary>
		[Parameter] public string Id { get; set; } = "hx-" + Guid.NewGuid().ToString("N");

		protected internal bool Collapsed { get; set; } = false;
		protected internal string NavContentElementId => Id + "-nav-content";


		private string GetCollapsedCssClass() => Collapsed ? "collapsed" : null;


		private void HandleCollapseToggleClick()
		{
			Collapsed = !Collapsed;
		}
	}
}
