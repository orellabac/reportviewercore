using System;

namespace Microsoft.Reporting.NETCore
{
	[Serializable]
	public sealed class RenderingExtension
	{
		private string m_name;

		private string m_localizedName;

		private bool m_isVisible;

		public string Name => m_name;

		public string LocalizedName => m_localizedName;

		public bool Visible => m_isVisible;

		internal RenderingExtension(string name, string localizedName, bool isVisible)
		{
			m_name = name;
			m_localizedName = localizedName;
			m_isVisible = isVisible;
		}
	}
}
