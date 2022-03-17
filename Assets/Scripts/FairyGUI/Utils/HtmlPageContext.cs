using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI.Utils
{
	public class HtmlPageContext : IHtmlPageContext
	{
		private Stack<IHtmlObject> _imagePool;

		private Stack<IHtmlObject> _inputPool;

		private Stack<IHtmlObject> _buttonPool;

		private Stack<IHtmlObject> _selectPool;

		private Stack<IHtmlObject> _linkPool;

		public static HtmlPageContext inst;

		private static Transform _poolManager;

		public virtual IHtmlObject CreateObject(RichTextField owner, HtmlElement element)
		{
			return null;
		}

		public virtual void FreeObject(IHtmlObject obj)
		{
		}

		public virtual NTexture GetImageTexture(HtmlImage image)
		{
			return null;
		}

		public virtual void FreeImageTexture(HtmlImage image, NTexture texture)
		{
		}
	}
}
