using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Crackme.My
{
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class InternalXmlHelper
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[CompilerGenerated]
		[DebuggerNonUserCode]
		private sealed class RemoveNamespaceAttributesClosure
		{
			private readonly XNamespace[] m_ns;

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal RemoveNamespaceAttributesClosure(XNamespace[] ns)
			{
				m_ns = ns;
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal XElement ProcessXElement(XElement elem)
			{
				return RemoveNamespaceAttributes(m_ns, elem);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal object ProcessObject(object obj)
			{
				//Discarded unreachable code: IL_0022, IL_0029
				XElement xElement = obj as XElement;
				if (xElement != null)
				{
					return RemoveNamespaceAttributes(m_ns, xElement);
				}
				return obj;
			}
		}

		public static string Value
		{
			get
			{
				//Discarded unreachable code: IL_001b
				using (IEnumerator<XElement> enumerator = source.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						XElement current = enumerator.Current;
						return current.Value;
					}
				}
				return null;
			}
			set
			{
				//Discarded unreachable code: IL_001d
				using (IEnumerator<XElement> enumerator = source.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						XElement current = enumerator.Current;
						current.Value = value;
					}
				}
			}
		}

		public static string AttributeValue
		{
			get
			{
				//Discarded unreachable code: IL_0021
				using (IEnumerator<XElement> enumerator = source.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						XElement current = enumerator.Current;
						return (string)current.Attribute(name);
					}
				}
				return null;
			}
			set
			{
				//Discarded unreachable code: IL_001e
				using (IEnumerator<XElement> enumerator = source.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						XElement current = enumerator.Current;
						current.SetAttributeValue(name, value);
					}
				}
			}
		}

		public static string AttributeValue
		{
			get
			{
				return (string)source.Attribute(name);
			}
			set
			{
				source.SetAttributeValue(name, value);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		private InternalXmlHelper()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static XAttribute CreateAttribute(XName name, object value)
		{
			if (value == null)
			{
				return null;
			}
			return new XAttribute(name, RuntimeHelpers.GetObjectValue(value));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static XAttribute CreateNamespaceAttribute(XName name, XNamespace ns)
		{
			XAttribute xAttribute = new XAttribute(name, ns.NamespaceName);
			xAttribute.AddAnnotation(ns);
			return xAttribute;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static object RemoveNamespaceAttributes(XNamespace[] ns, object obj)
		{
			//Discarded unreachable code: IL_002b
			if ((ns != null && obj != null) ? true : false)
			{
				XElement xElement = obj as XElement;
				if (xElement != null)
				{
					return RemoveNamespaceAttributes(ns, xElement);
				}
				IEnumerable enumerable = obj as IEnumerable;
				if (enumerable != null)
				{
					return RemoveNamespaceAttributes(ns, enumerable);
				}
			}
			return obj;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IEnumerable RemoveNamespaceAttributes(XNamespace[] ns, IEnumerable obj)
		{
			//Discarded unreachable code: IL_003c, IL_005f
			if ((ns != null && obj != null) ? true : false)
			{
				IEnumerable<XElement> enumerable = obj as IEnumerable<XElement>;
				if (enumerable != null)
				{
					return enumerable.Select(new RemoveNamespaceAttributesClosure(ns).ProcessXElement);
				}
				return obj.Cast<object>().Select(new RemoveNamespaceAttributesClosure(ns).ProcessObject);
			}
			return obj;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static XElement RemoveNamespaceAttributes(XNamespace[] ns, XElement e)
		{
			checked
			{
				if ((ns != null && e != null) ? true : false)
				{
					XAttribute xAttribute = e.FirstAttribute;
					while (xAttribute != null)
					{
						XAttribute nextAttribute = xAttribute.NextAttribute;
						if (xAttribute.IsNamespaceDeclaration)
						{
							XNamespace xNamespace = xAttribute.Annotation<XNamespace>();
							if ((object)xNamespace != null)
							{
								int num = ns.Length - 1;
								int num2 = num;
								int num3 = 0;
								while (true)
								{
									int num4 = num3;
									int num5 = num2;
									if (num4 > num5)
									{
										break;
									}
									if (xNamespace == ns[num3])
									{
										xAttribute.Remove();
										break;
									}
									num3++;
								}
							}
						}
						xAttribute = nextAttribute;
					}
				}
				return e;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static XNamespace GetNamespace(ref XNamespace xns, string ns)
		{
			if ((object)xns == null)
			{
				xns = XNamespace.Get(ns);
			}
			return xns;
		}
	}
}
