using Microsoft.ReportingServices.ReportProcessing;

namespace Microsoft.ReportingServices.ReportRendering
{
	internal class ReportSizeCollection
	{
		private ReportSize[] m_reportSizeCollection;

		public virtual ReportSize this[int index]
		{
			get
			{
				if (0 > index || index >= Count)
				{
					throw new RenderingObjectModelException(ProcessingErrorCode.rsInvalidParameterRange, index, 0, Count);
				}
				return m_reportSizeCollection[index];
			}
			set
			{
				if (0 > index || index >= Count)
				{
					throw new RenderingObjectModelException(ProcessingErrorCode.rsInvalidParameterRange, index, 0, Count);
				}
				m_reportSizeCollection[index] = value;
			}
		}

		public virtual int Count
		{
			get
			{
				if (m_reportSizeCollection == null)
				{
					return 0;
				}
				return m_reportSizeCollection.Length;
			}
		}

		internal ReportSizeCollection()
		{
		}

		internal ReportSizeCollection(int count)
		{
			m_reportSizeCollection = new ReportSize[count];
		}
	}
}
