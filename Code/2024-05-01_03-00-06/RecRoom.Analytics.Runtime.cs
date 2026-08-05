using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AmplitudeAnalytics;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x60AD210", Offset = "0x60AC010", VA = "0x1860AD210")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AGAmplitudeAnalyticsSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AmplitudeAnalyticsClient.Settings JBNGFHMNHGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool KNHGEPNLKJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7BA880", Offset = "0x7B9680", VA = "0x1807BA880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B0790", Offset = "0x7AF590", VA = "0x1807B0790")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum CNGEJDALMOJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class IAHMIFKBDGN
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class BCGEDHLLDDH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int OAKJPCDBIDG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> IMNLPGCCNJP;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
				public BCGEDHLLDDH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class AOHDIKPIHAI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
				public AOHDIKPIHAI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x609E850", Offset = "0x609D650", VA = "0x18609E850")]
				internal bool OMHHOMOOILF(BCGEDHLLDDH item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string MDHHPIHGFHK = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string CCKBKBLBNND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<BCGEDHLLDDH> FHOPEBBDFPI;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? LEDOEHPLNGG
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x60A8820", Offset = "0x60A7620", VA = "0x1860A8820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x60A94C0", Offset = "0x60A82C0", VA = "0x1860A94C0")]
			internal IAHMIFKBDGN(string DPJAKIFNNPK, string LFNBBMIGAKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x60A90D0", Offset = "0x60A7ED0", VA = "0x1860A90D0")]
			public int JHLPBNMGCII([Optional] int? EPDAGNEFBIO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x60A8400", Offset = "0x60A7200", VA = "0x1860A8400")]
			public List<Dictionary<string, object>> AMGIMDGGABB(int JKEEBBIJEDC, int? EPDAGNEFBIO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x60A8780", Offset = "0x60A7580", VA = "0x1860A8780")]
			public void COGJLGEIHIO(AmplitudeAnalyticsIdentifyMessage EIFMADKIHON, bool NDHGEDMHHLO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x60A8670", Offset = "0x60A7470", VA = "0x1860A8670")]
			public void COGJLGEIHIO(Dictionary<string, object> EIFMADKIHON, bool NDHGEDMHHLO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x60A88C0", Offset = "0x60A76C0", VA = "0x1860A88C0")]
			public void GBAIPNBFBJP(params Dictionary<string, object>[] NJFEKDEPGMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x60A9280", Offset = "0x60A8080", VA = "0x1860A9280")]
			public void NLNBJBEGKKH(List<Dictionary<string, object>> OIMELCLACOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x60A81E0", Offset = "0x60A6FE0", VA = "0x1860A81E0")]
			private void ABEKJEAMJIL(Dictionary<string, object> EIFMADKIHON, bool NDHGEDMHHLO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x60A8A40", Offset = "0x60A7840", VA = "0x1860A8A40")]
			public void HFLCOJBHDCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x60A8C70", Offset = "0x60A7A70", VA = "0x1860A8C70")]
			private void IMHBNDJLEKI([Optional] string HKKNBOMGFEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x60A82E0", Offset = "0x60A70E0", VA = "0x1860A82E0")]
			private static string AJPAOPIBPNP(string DIBNBLEEFNN, string OBPLDLNDJLE)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x60AFA00", Offset = "0x60AE800", VA = "0x1860AFA00")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct OBGOBNNHMEP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int KDCMCBBPHLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string DJCHNKFLMID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T LCNDILKBIPM;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class ODEJGFPKOJN : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private KMOACDBBKNB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
			[DebuggerHidden]
			public ODEJGFPKOJN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x60ADE20", Offset = "0x60ACC20", VA = "0x1860ADE20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x60AE5E0", Offset = "0x60AD3E0", VA = "0x1860AE5E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GAIGJDGHHNI : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public JGKLBIBCBIK quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
			[DebuggerHidden]
			public GAIGJDGHHNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x60A7D60", Offset = "0x60A6B60", VA = "0x1860A7D60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x60A7E70", Offset = "0x60A6C70", VA = "0x1860A7E70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class LICDEGGHBMH : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
			[DebuggerHidden]
			public LICDEGGHBMH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x60AC740", Offset = "0x60AB540", VA = "0x1860AC740", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x60AC8B0", Offset = "0x60AB6B0", VA = "0x1860AC8B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class FLODPGLECMA : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private KMOACDBBKNB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
			[DebuggerHidden]
			public FLODPGLECMA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x60A6F80", Offset = "0x60A5D80", VA = "0x1860A6F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x60A7200", Offset = "0x60A6000", VA = "0x1860A7200", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class MPOMLLKMMIM : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private KMOACDBBKNB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
			[DebuggerHidden]
			public MPOMLLKMMIM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x60ACAD0", Offset = "0x60AB8D0", VA = "0x1860ACAD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x60ACD50", Offset = "0x60ABB50", VA = "0x1860ACD50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class FPJACAEINMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public IAHMIFKBDGN cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public FPJACAEINMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x60A7A40", Offset = "0x60A6840", VA = "0x1860A7A40")]
			internal void OJAJHBOBLAC(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x60A7600", Offset = "0x60A6400", VA = "0x1860A7600")]
			internal void BBBHOKLDGIE(OBGOBNNHMEP<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ONBNMBDMDND : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private KMOACDBBKNB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public IAHMIFKBDGN cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private FPJACAEINMA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
			[DebuggerHidden]
			public ONBNMBDMDND(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x60AE630", Offset = "0x60AD430", VA = "0x1860AE630", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x60AEEE0", Offset = "0x60ADCE0", VA = "0x1860AEEE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class MENNBBFHOPB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public MENNBBFHOPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3F87250", Offset = "0x3F86050", VA = "0x183F87250")]
			internal OBGOBNNHMEP<T> GAJGFPPKBJH(FBFJJDJAFPA postResponse)
			{
				return default(OBGOBNNHMEP<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class NGPEMHHDANI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public NGPEMHHDANI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3F87250", Offset = "0x3F86050", VA = "0x183F87250")]
			internal OBGOBNNHMEP<T> COKOCPHAEAK(FBFJJDJAFPA postResponse)
			{
				return default(OBGOBNNHMEP<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private IJOABPEABIK BNOKJLEEGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<OBFDCJHIPBF> JLFNOMJNAPG;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string MMNENNMCABD = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string LJCCBAIDGKO = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string IEIGNHDNIFG = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int IBEMIBEPAPE = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int CGHGEEEBGGO = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int KEOMIDFLKAI = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float JCOGNAOIIIP = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long IFBOAFFLFMN = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string EACCECCKHAG = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string IIHEFLONFKD = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool NLBHIGHJLLC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool LBFOBBKHNIA;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int FLNPAPJBGIP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int DMCNCKIMAED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private CCGBDEDPDBI LBKAGGGPLKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private AOLEGGEMOIO EPCPBLJCJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FMIDLBNEILF ENJJJBLPJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool ABHHMKLKPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float DIAFIGKAIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float IIADJNCECKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int EPGDKOEHMDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int AMDILOKKHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? JJJFDHFPEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? EINKLOPALGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long JEKDEDAAJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string ECJHBBLNIIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool AKLIBKBEJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long GCFILHPMDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string GBKCLLAAJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string GGEHGFEABLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> KNLLPFDHAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CNGEJDALMOJ DIGDJCOJECB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int EHMINIAHNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int GIEHKDPOMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float KICDLNLLNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool HOAKFPCBNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool ENNOIBEEIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private IAHMIFKBDGN DFHCHDGENCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private IAHMIFKBDGN EGDDOJMBAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IAHMIFKBDGN GGPNAEFNLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> LMENAOBOFPG;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo PGJCCEPIOJI;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string AOFGCNGHAHL;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string LGHENNECOIO = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string EEOFKFLLCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string LOJPIHNOKNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string DBHKGMMJKOF;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private IJOABPEABIK LGBLDHHOJAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x60A27C0", Offset = "0x60A15C0", VA = "0x1860A27C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private OBFDCJHIPBF MDJLBLIPAKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x60A0AD0", Offset = "0x609F8D0", VA = "0x1860A0AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int ENNHJHBDDAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x60A0900", Offset = "0x609F700", VA = "0x1860A0900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long LKJGHJEACOG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x60A43E0", Offset = "0x60A31E0", VA = "0x1860A43E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x60A4500", Offset = "0x60A3300", VA = "0x1860A4500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string ECCOBKFPPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x60A4380", Offset = "0x60A3180", VA = "0x1860A4380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string JHOGLNJLFEB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x60A43B0", Offset = "0x60A31B0", VA = "0x1860A43B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IMMPGGLCHFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8D6190", Offset = "0x8D4F90", VA = "0x1808D6190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8D61B0", Offset = "0x8D4FB0", VA = "0x1808D61B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? GJEJJCBCHLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8FE9E0", Offset = "0x8FD7E0", VA = "0x1808FE9E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x60A44F0", Offset = "0x60A32F0", VA = "0x1860A44F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BHMMBBBDMHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xFCDB10", Offset = "0xFCC910", VA = "0x180FCDB10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xFCD7C0", Offset = "0xFCC5C0", VA = "0x180FCD7C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool AADIPEHJINO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x60A4260", Offset = "0x60A3060", VA = "0x1860A4260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> PKGBNHDKCJL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x60A41A0", Offset = "0x60A2FA0", VA = "0x1860A41A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x60A4430", Offset = "0x60A3230", VA = "0x1860A4430")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x609ECF0", Offset = "0x609DAF0", VA = "0x18609ECF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60A19C0", Offset = "0x60A07C0", VA = "0x1860A19C0")]
		private void KKPDDCFEGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60A3790", Offset = "0x60A2590", VA = "0x1860A3790")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60A2930", Offset = "0x60A1730", VA = "0x1860A2930", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60A3B30", Offset = "0x60A2930", VA = "0x1860A3B30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x60A2A70", Offset = "0x60A1870", VA = "0x1860A2A70")]
		public LKLLCIBDBNN PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60A18D0", Offset = "0x60A06D0", VA = "0x1860A18D0")]
		[IteratorStateMachine(typeof(ODEJGFPKOJN))]
		public IEnumerator<KMOACDBBKNB> Initialize(AmplitudeAnalyticsEvent FJHDCPNDALD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x60A3A70", Offset = "0x60A2870", VA = "0x1860A3A70")]
		public void UpdateLastKnownInteractionCategory(string GBLBOFFBCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60A3980", Offset = "0x60A2780", VA = "0x1860A3980")]
		public void UpdateLastAliveTime(float KAFHCFGLIGM = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60A0E10", Offset = "0x609FC10", VA = "0x1860A0E10")]
		private LKLLCIBDBNN FBOIBCCNNPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x609F150", Offset = "0x609DF50", VA = "0x18609F150")]
		private LKLLCIBDBNN BFNCNAADGHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x60A3200", Offset = "0x60A2000", VA = "0x1860A3200")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x60A0EC0", Offset = "0x609FCC0", VA = "0x1860A0EC0")]
		[IteratorStateMachine(typeof(GAIGJDGHHNI))]
		private IEnumerator FFMDDBHBLHF(JGKLBIBCBIK CGLOIGOPIGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x60A3DC0", Offset = "0x60A2BC0", VA = "0x1860A3DC0")]
		[IteratorStateMachine(typeof(LICDEGGHBMH))]
		public IEnumerator WaitForFlush(float JODGDKECNNK = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x60A3860", Offset = "0x60A2660", VA = "0x1860A3860")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60A37A0", Offset = "0x60A25A0", VA = "0x1860A37A0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime DIAHEDLEKEE)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60A1460", Offset = "0x60A0260", VA = "0x1860A1460")]
		public static NIKLLDNPLFD Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x609EB90", Offset = "0x609D990", VA = "0x18609EB90")]
		public static NPBMCHBCLFB AccountSelectionPostLoginEvent([NotNull] string MHCDPLAHCLK, string CHJHIJIAALG, bool GFGJLHMFDDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60A0B20", Offset = "0x609F920", VA = "0x1860A0B20")]
		public static NPBMCHBCLFB Event([NotNull] string MHCDPLAHCLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x60A2AB0", Offset = "0x60A18B0", VA = "0x1860A2AB0")]
		public static NPBMCHBCLFB PreviousSessionEvent([NotNull] string MHCDPLAHCLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x60A1600", Offset = "0x60A0400", VA = "0x1860A1600")]
		public static NPBMCHBCLFB InitializeEvent(string CHJHIJIAALG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60A33C0", Offset = "0x60A21C0", VA = "0x1860A33C0")]
		public static NPBMCHBCLFB StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x60A04C0", Offset = "0x609F2C0", VA = "0x1860A04C0")]
		public static NPBMCHBCLFB CreateOutOfSessionEvent(string MHCDPLAHCLK, bool CGBONAMGEOP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60A22D0", Offset = "0x60A10D0", VA = "0x1860A22D0")]
		public static LKLLCIBDBNN LogOutOfSessionEvent(NPBMCHBCLFB IAPKDEMIEBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x60A2070", Offset = "0x60A0E70", VA = "0x1860A2070")]
		public void LogEventAsync(AmplitudeAnalyticsEvent AHOCECMJDOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x60A25B0", Offset = "0x60A13B0", VA = "0x1860A25B0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent AHOCECMJDOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x60A26E0", Offset = "0x60A14E0", VA = "0x1860A26E0")]
		public void LogSerializedEventAsync(Dictionary<string, object> GNFONNBGMGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x60A21A0", Offset = "0x60A0FA0", VA = "0x1860A21A0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage GGGFEAOOHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x609E8C0", Offset = "0x609D6C0", VA = "0x18609E8C0")]
		private void ADHBKDGFCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x609F440", Offset = "0x609E240", VA = "0x18609F440")]
		private void BNJKKBBHKIB(Dictionary<string, object> KOAPOMOHLOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60A03D0", Offset = "0x609F1D0", VA = "0x1860A03D0")]
		private void COKCPCGIOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x609E9C0", Offset = "0x609D7C0", VA = "0x18609E9C0")]
		private void APHPOBAKDLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x60A0F50", Offset = "0x609FD50", VA = "0x1860A0F50")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x60A0870", Offset = "0x609F670", VA = "0x1860A0870")]
		[IteratorStateMachine(typeof(FLODPGLECMA))]
		private IEnumerator<KMOACDBBKNB> EACPFGHCKMM(float JODGDKECNNK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x60A29E0", Offset = "0x60A17E0", VA = "0x1860A29E0")]
		[IteratorStateMachine(typeof(MPOMLLKMMIM))]
		private IEnumerator<KMOACDBBKNB> PHDDBGCBEFB(float JODGDKECNNK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x60A2830", Offset = "0x60A1630", VA = "0x1860A2830")]
		[IteratorStateMachine(typeof(ONBNMBDMDND))]
		private IEnumerator<KMOACDBBKNB> NMIOJFBCHJI(IAHMIFKBDGN GHOBDPKIBDO, int? EPDAGNEFBIO, string DBCHEDPBCOL, string EPMMEEJKBHO, float JODGDKECNNK, Action<int> FGIMMEFKOJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x60A1F60", Offset = "0x60A0D60", VA = "0x1860A1F60")]
		private static void LHGDHGOAIDI(bool ABAFCLEJOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x60A1330", Offset = "0x60A0130", VA = "0x1860A1330")]
		private NPCIDDLFILB<OBGOBNNHMEP<Dictionary<string, object>>> GCPAFPNONLL(string DBCHEDPBCOL, string EPMMEEJKBHO, string HHLNBJBPGIF, string NIFINHBPMLB, Dictionary<string, object> LCNDILKBIPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x60A0FE0", Offset = "0x609FDE0", VA = "0x1860A0FE0")]
		private NPCIDDLFILB<OBGOBNNHMEP<List<Dictionary<string, object>>>> GCPAFPNONLL(string DBCHEDPBCOL, string EPMMEEJKBHO, string HHLNBJBPGIF, string NIFINHBPMLB, List<Dictionary<string, object>> LCNDILKBIPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2F33400", Offset = "0x2F32200", VA = "0x182F33400")]
		private NPCIDDLFILB<OBGOBNNHMEP<T>> DPIHIBHOOOO<T>(string DBCHEDPBCOL, string EPMMEEJKBHO, string NIFINHBPMLB, T LCNDILKBIPM, Dictionary<string, object> GMPNJEGDABF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2F336A0", Offset = "0x2F324A0", VA = "0x182F336A0")]
		private NPCIDDLFILB<OBGOBNNHMEP<T>> OMOKLOBJLCC<T>(string DBCHEDPBCOL, string EPMMEEJKBHO, string HHLNBJBPGIF, T LCNDILKBIPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x60A1970", Offset = "0x60A0770", VA = "0x1860A1970")]
		private bool KHGOIOODLMJ(float EHJFLPFLNII, float JODGDKECNNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x609F700", Offset = "0x609E500", VA = "0x18609F700")]
		private Dictionary<string, object> CMOJEMHPPAH(string EPMMEEJKBHO, Dictionary<string, object> LCNDILKBIPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60A3EB0", Offset = "0x60A2CB0", VA = "0x1860A3EB0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x60A0710", Offset = "0x609F510", VA = "0x1860A0710")]
		[CompilerGenerated]
		private long DPIEBJGOCFC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x60A1960", Offset = "0x60A0760", VA = "0x1860A1960")]
		[CompilerGenerated]
		private void JBMDBEMPOGH(int HEHAOFBKHAM)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly bool isBrazeUser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x60A5230", Offset = "0x60A4030", VA = "0x1860A5230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x60A5300", Offset = "0x60A4100", VA = "0x1860A5300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x60A5270", Offset = "0x60A4070", VA = "0x1860A5270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x60A5350", Offset = "0x60A4150", VA = "0x1860A5350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x60A51F0", Offset = "0x60A3FF0", VA = "0x1860A51F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x60A52B0", Offset = "0x60A40B0", VA = "0x1860A52B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x60A46D0", Offset = "0x60A34D0", VA = "0x1860A46D0")]
		public static NPBMCHBCLFB ANGJMEBBFOG(string MIJEJKOAIDK, [NotNull] string JCJHJKFBEEL, long LDLIPNAEPGL, long HJOBLCLPPFA, string CHJHIJIAALG, bool GFGJLHMFDDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x60A48D0", Offset = "0x60A36D0", VA = "0x1860A48D0")]
		public static NPBMCHBCLFB EJJLJKCOGON(string MIJEJKOAIDK, [NotNull] string JCJHJKFBEEL, long LDLIPNAEPGL, long HJOBLCLPPFA, string CHJHIJIAALG, long OCKHJLKHPDM, bool GFGJLHMFDDD, string ANDDILOIHNC, string BGODLLPKJIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x60A5060", Offset = "0x60A3E60", VA = "0x1860A5060")]
		private AmplitudeAnalyticsEvent(string MIJEJKOAIDK, [NotNull] string JCJHJKFBEEL, long LDLIPNAEPGL, long HJOBLCLPPFA, string CHJHIJIAALG, bool GFGJLHMFDDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7600", Offset = "0x1AF6400", VA = "0x181AF7600")]
		public void LNGAOCCFJPF(long DDGEMNOPEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x60A47D0", Offset = "0x60A35D0", VA = "0x1860A47D0", Slot = "5")]
		public override void EDBEGDAMMIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x60A4560", Offset = "0x60A3360", VA = "0x1860A4560", Slot = "6")]
		public override void ANDLBBDBAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x60A4B40", Offset = "0x60A3940", VA = "0x1860A4B40", Slot = "4")]
		protected override Dictionary<string, object> HMKAEBBOPOC(Dictionary<string, object> KGFELCEIPFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x60A4A30", Offset = "0x60A3830", VA = "0x1860A4A30")]
		private void HJKNBMJJIFB(string OBPLDLNDJLE, string DIBNBLEEFNN, bool EAGIHOOAFIE = false)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x60A6360", Offset = "0x60A5160", VA = "0x1860A6360")]
			public void EPKFEHJGEFJ(Dictionary<string, object> BFEOLNEBMCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x60AF680", Offset = "0x60AE480", VA = "0x1860AF680")]
			public void EPKFEHJGEFJ(Dictionary<string, object> JPMOLONLFBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x917D00", Offset = "0x916B00", VA = "0x180917D00")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7B1BC0", Offset = "0x7B09C0", VA = "0x1807B1BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x60A54C0", Offset = "0x60A42C0", VA = "0x1860A54C0")]
		public static NIKLLDNPLFD ANGJMEBBFOG(string MIJEJKOAIDK, string CHJHIJIAALG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x60A5A50", Offset = "0x60A4850", VA = "0x1860A5A50")]
		protected AmplitudeAnalyticsIdentifyMessage(string MIJEJKOAIDK, string CHJHIJIAALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x60A5580", Offset = "0x60A4380", VA = "0x1860A5580")]
		public Dictionary<string, object> BGBIBCBOOFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x60A56A0", Offset = "0x60A44A0", VA = "0x1860A56A0", Slot = "4")]
		protected virtual Dictionary<string, object> HMKAEBBOPOC(Dictionary<string, object> KGFELCEIPFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x60A53A0", Offset = "0x60A41A0", VA = "0x1860A53A0")]
		protected void AENMANCKDGE(string OBPLDLNDJLE, Dictionary<string, object> KEOAANKDABB, Dictionary<string, object> OJLJOPLKMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x60A59E0", Offset = "0x60A47E0", VA = "0x1860A59E0")]
		protected void KPHDHGOBOOC(string OBPLDLNDJLE, string DIBNBLEEFNN, Dictionary<string, object> ALNJIDNGAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x60A5610", Offset = "0x60A4410", VA = "0x1860A5610", Slot = "5")]
		public virtual void EDBEGDAMMIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x60A5440", Offset = "0x60A4240", VA = "0x1860A5440", Slot = "6")]
		public virtual void ANDLBBDBAJA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NIKLLDNPLFD : FKBEAPKGHGP<AmplitudeAnalyticsIdentifyMessage, NIKLLDNPLFD>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override NIKLLDNPLFD IHGLGDHICAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage OELFNPOEOHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x60ACE40", Offset = "0x60ABC40", VA = "0x1860ACE40")]
	public NIKLLDNPLFD(AmplitudeAnalyticsIdentifyMessage HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x60ACDA0", Offset = "0x60ABBA0", VA = "0x1860ACDA0", Slot = "4")]
	public override void ANDLBBDBAJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NPBMCHBCLFB : FKBEAPKGHGP<AmplitudeAnalyticsEvent, NPBMCHBCLFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool LCOFBIFEBLA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override NPBMCHBCLFB IHGLGDHICAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long GIKJDOECJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x60AD1F0", Offset = "0x60ABFF0", VA = "0x1860AD1F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x60AC6F0", Offset = "0x60AB4F0", VA = "0x1860AC6F0")]
	public NPBMCHBCLFB(AmplitudeAnalyticsEvent HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0", Slot = "5")]
	public override AmplitudeAnalyticsEvent OELFNPOEOHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x60ACF30", Offset = "0x60ABD30", VA = "0x1860ACF30", Slot = "4")]
	public override void ANDLBBDBAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2A0AE30", Offset = "0x2A09C30", VA = "0x182A0AE30")]
	public NPBMCHBCLFB KNGNCJBNMMG<T>(string CINANBNCBIJ, T[] DIBNBLEEFNN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2A0AE30", Offset = "0x2A09C30", VA = "0x182A0AE30")]
	public NPBMCHBCLFB KNGNCJBNMMG(string CINANBNCBIJ, string[] DIBNBLEEFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2A0AB80", Offset = "0x2A09980", VA = "0x182A0AB80")]
	public NPBMCHBCLFB KNGNCJBNMMG<T>(string CINANBNCBIJ, T DIBNBLEEFNN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x60AD100", Offset = "0x60ABF00", VA = "0x1860AD100")]
	public NPBMCHBCLFB KNGNCJBNMMG(string CINANBNCBIJ, long DIBNBLEEFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x60AD180", Offset = "0x60ABF80", VA = "0x1860AD180")]
	public NPBMCHBCLFB KNGNCJBNMMG(string CINANBNCBIJ, string DIBNBLEEFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x60AD0D0", Offset = "0x60ABED0", VA = "0x1860AD0D0")]
	public NPBMCHBCLFB GHDGGPCCKGH(string CINANBNCBIJ, object? DIBNBLEEFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x60ACE90", Offset = "0x60ABC90", VA = "0x1860ACE90")]
	public NPBMCHBCLFB AHLJBFKBNDK(string CINANBNCBIJ, string DIBNBLEEFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x60ACFD0", Offset = "0x60ABDD0", VA = "0x1860ACFD0")]
	private NPBMCHBCLFB ECPNGCONKMO(string CINANBNCBIJ, object DIBNBLEEFNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KLFNPMCEIJN : NPBMCHBCLFB
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x60AC6F0", Offset = "0x60AB4F0", VA = "0x1860AC6F0")]
	public KLFNPMCEIJN(AmplitudeAnalyticsEvent HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x60AC550", Offset = "0x60AB350", VA = "0x1860AC550", Slot = "4")]
	public override void ANDLBBDBAJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class FKBEAPKGHGP<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : FKBEAPKGHGP<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M HPJAAILCALJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR IHGLGDHICAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public FKBEAPKGHGP(M HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x384AD20", Offset = "0x3849B20", VA = "0x18384AD20")]
	public BLDR LLAONLIHFDO(AmplitudeAnalyticsIdentifyMessage.DeviceInfo BINPKAMCFOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x384ADA0", Offset = "0x3849BA0", VA = "0x18384ADA0")]
	public BLDR OHLNFCMINBK(AmplitudeAnalyticsIdentifyMessage.RevenueData MPJCEHMIJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x384ABB0", Offset = "0x38499B0", VA = "0x18384ABB0")]
	public BLDR CBCIHGCGEFL(string CINANBNCBIJ, string DIBNBLEEFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x27CC5B0", Offset = "0x27CB3B0", VA = "0x1827CC5B0")]
	public BLDR CBCIHGCGEFL<T>(string CINANBNCBIJ, T DIBNBLEEFNN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void ANDLBBDBAJA();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x384AD70", Offset = "0x3849B70", VA = "0x18384AD70")]
	internal static string MFCHCEFCEOP(string DIBNBLEEFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x384AC20", Offset = "0x3849A20", VA = "0x18384AC20")]
	private BLDR CFNNPOIEDCG(string CINANBNCBIJ, object DIBNBLEEFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M OELFNPOEOHD();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class FODBCGFOHDE : CCGBDEDPDBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct EDOJIACHLNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<FBFJJDJAFPA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public FODBCGFOHDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private FormUrlEncodedContent <requestBody>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private HttpResponseMessage <httpResponse>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x60A64E0", Offset = "0x60A52E0", VA = "0x1860A64E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x60A6D70", Offset = "0x60A5B70", VA = "0x1860A6D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct AEJAOBKPJJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<FBFJJDJAFPA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public FODBCGFOHDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private StringContent <requestBody>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private HttpRequestMessage <request>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private HttpResponseMessage <httpResponse>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x609DDC0", Offset = "0x609CBC0", VA = "0x18609DDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x609E7E0", Offset = "0x609D5E0", VA = "0x18609E7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient NLAPDEMPNNM;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x60A7250", Offset = "0x60A6050", VA = "0x1860A7250")]
	[DPHBJKOLDBD(OHNOEEJKPCM.None)]
	private static void ACFLEDDPCGO(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x60A7580", Offset = "0x60A6380", VA = "0x1860A7580")]
	[RecRoom.NoEngine.Common.Preserve]
	public FODBCGFOHDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x60A7430", Offset = "0x60A6230", VA = "0x1860A7430", Slot = "4")]
	[AsyncStateMachine(typeof(EDOJIACHLNB))]
	public Task<FBFJJDJAFPA> GCPAFPNONLL(string DBCHEDPBCOL, Dictionary<string, string> LCICPPOAKKI, bool JDGJDJOMJEH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x60A72C0", Offset = "0x60A60C0", VA = "0x1860A72C0", Slot = "5")]
	[AsyncStateMachine(typeof(AEJAOBKPJJN))]
	public Task<FBFJJDJAFPA> DICJIHJJODK(string DBCHEDPBCOL, string JBMPHBACLAP, string AECAGFFEOJP, string JBBJOANNNBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FILAFCMFGBN
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> IDHECJECFOF;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x60A6DE0", Offset = "0x60A5BE0", VA = "0x1860A6DE0")]
	internal static bool LFJAJNJLAHP(string OBPLDLNDJLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CCGBDEDPDBI
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FBFJJDJAFPA> GCPAFPNONLL(string DBCHEDPBCOL, Dictionary<string, string> LCICPPOAKKI, bool JDGJDJOMJEH = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FBFJJDJAFPA> DICJIHJJODK(string DBCHEDPBCOL, string JBMPHBACLAP, string AECAGFFEOJP, string JBBJOANNNBD);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct FBFJJDJAFPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int FJBEPBHIHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string BILOAHKAMEH;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xC2B5C0", Offset = "0xC2A3C0", VA = "0x180C2B5C0")]
	public FBFJJDJAFPA(int KDCMCBBPHLH, string DJCHNKFLMID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum BECGHHJMJOM
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	GameInvite,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	RoomChat,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DebugCommand
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class IJBGEPMNOFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long BFPBLMMOBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private NPBMCHBCLFB KNCKILNGDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool FEBHBHFAAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float PKAGAMBJIFI;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x60A9A40", Offset = "0x60A8840", VA = "0x1860A9A40")]
	public IJBGEPMNOFB(string IFJCEBJJKFM, float PKAGAMBJIFI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x29026F0", Offset = "0x29014F0", VA = "0x1829026F0")]
	public void KNGNCJBNMMG<T>(string CINANBNCBIJ, T DIBNBLEEFNN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x60A9970", Offset = "0x60A8770", VA = "0x1860A9970")]
	public void KNGNCJBNMMG(string CINANBNCBIJ, string DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x60A9880", Offset = "0x60A8680", VA = "0x1860A9880")]
	public void EPACCJOPNEC(string OMJAMCFNEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x60A97C0", Offset = "0x60A85C0", VA = "0x1860A97C0")]
	public void CCGNOMBCFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x60A96B0", Offset = "0x60A84B0", VA = "0x1860A96B0")]
	private void APFKODACFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x60A99F0", Offset = "0x60A87F0", VA = "0x1860A99F0")]
	private bool OACJHECCKJJ()
	{
		return default(bool);
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum HCBHDMOFIOO
		{
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			String,
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			Bool
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private HCBHDMOFIOO parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public HCBHDMOFIOO Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9592D0", Offset = "0x9580D0", VA = "0x1809592D0")]
			get
			{
				return default(HCBHDMOFIOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x87B210", Offset = "0x87A010", VA = "0x18087B210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x60AF7F0", Offset = "0x60AE5F0", VA = "0x1860AF7F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class CMAMINJAOJE : CGADEPEJEON, ODEPNDIFJKH
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void CICCDMDCHGF(LIMCMLNHIBM NHPBNIABEKB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly IKBEHCKCDLH NENLNKFJCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly CICCDMDCHGF FDBFNIICNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly string JINKODGNGMN;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string HBAONAGBJJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x10B0E00", Offset = "0x10AFC00", VA = "0x1810B0E00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PDMNLJGEFIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x60A62D0", Offset = "0x60A50D0", VA = "0x1860A62D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool CMAFKCODFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x60A62B0", Offset = "0x60A50B0", VA = "0x1860A62B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> BKLBPGPFMAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x10B1000", Offset = "0x10AFE00", VA = "0x1810B1000", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x60A62F0", Offset = "0x60A50F0", VA = "0x1860A62F0")]
	public CMAMINJAOJE(IKBEHCKCDLH IACOOBGNHEJ, string CJDMOEDCMDP, [Optional] CICCDMDCHGF MFEDHLBMHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2717EA0", Offset = "0x2716CA0", VA = "0x182717EA0", Slot = "8")]
	public T DJGCEJBDGHO<T>(string OBPLDLNDJLE, T OPPINNBBHIO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JNLLGDCIAAH : AFNONAOOEPJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PMGGBHOCLPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public JNLLGDCIAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AOLEGGEMOIO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x60AF1A0", Offset = "0x60ADFA0", VA = "0x1860AF1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x60AF620", Offset = "0x60AE420", VA = "0x1860AF620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct PIEMOFHKOAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x60AEF30", Offset = "0x60ADD30", VA = "0x1860AEF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x60AF140", Offset = "0x60ADF40", VA = "0x1860AF140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct HHAPOBBDFLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public JNLLGDCIAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AOLEGGEMOIO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x60A7EC0", Offset = "0x60A6CC0", VA = "0x1860A7EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x60A8180", Offset = "0x60A6F80", VA = "0x1860A8180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct OBKGDMIDDGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public JNLLGDCIAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AOLEGGEMOIO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x60AD290", Offset = "0x60AC090", VA = "0x1860AD290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x60AD660", Offset = "0x60AC460", VA = "0x1860AD660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly IReadOnlyDictionary<string, LMJLMJLPBAG> JDKGGDJGDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool MKHOHNNCLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private HGDPEOOAFNF OBHKBPNBKME;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool HLCDKGLKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x801870", Offset = "0x800670", VA = "0x180801870", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string IMMPGGLCHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x60AA920", Offset = "0x60A9720", VA = "0x1860AA920", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public NMOIKPBKEMM CBMGBMNODNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x60AAF50", Offset = "0x60A9D50", VA = "0x1860AAF50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action CGGGBLKIBDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60AA930", Offset = "0x60A9730", VA = "0x1860AA930", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x60AAFF0", Offset = "0x60A9DF0", VA = "0x1860AAFF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GKAKKACGPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x60ABCF0", Offset = "0x60AAAF0", VA = "0x1860ABCF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60AC350", Offset = "0x60AB150", VA = "0x1860AC350", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<LIMCMLNHIBM> NDEBEHFNPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x60ABD90", Offset = "0x60AAB90", VA = "0x1860ABD90", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x60AB2E0", Offset = "0x60AA0E0", VA = "0x1860AB2E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x60AAE10", Offset = "0x60A9C10", VA = "0x1860AAE10", Slot = "10")]
	[AsyncStateMachine(typeof(PMGGBHOCLPI))]
	public Task HBPIHILNAPB(string MMEOHFJIDLK, string LFNBBMIGAKG, [Optional] AOLEGGEMOIO FMPDDEEEKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x60AB090", Offset = "0x60A9E90", VA = "0x1860AB090", Slot = "19")]
	[AsyncStateMachine(typeof(PIEMOFHKOAO))]
	public Task IJEBCPEJMIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x60AA9D0", Offset = "0x60A97D0", VA = "0x1860AA9D0", Slot = "14")]
	[AsyncStateMachine(typeof(HHAPOBBDFLN))]
	public Task DNJIENKNOJG(AOLEGGEMOIO FMPDDEEEKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x60AAD00", Offset = "0x60A9B00", VA = "0x1860AAD00", Slot = "15")]
	[AsyncStateMachine(typeof(OBKGDMIDDGB))]
	public Task FNFMFEHFHFH(AOLEGGEMOIO FMPDDEEEKPA, Dictionary<string, string> DFBGENPIEOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x60AAAC0", Offset = "0x60A98C0", VA = "0x1860AAAC0", Slot = "16")]
	public bool EPCKDJNMAMN(string OGKFDPDLPIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x60AAB50", Offset = "0x60A9950", VA = "0x1860AAB50", Slot = "17")]
	public CGADEPEJEON FBJLAHBLIPF(string CJDMOEDCMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x60ABFF0", Offset = "0x60AADF0", VA = "0x1860ABFF0")]
	private IKBEHCKCDLH NBGOPNNAEEJ(string CJDMOEDCMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x60ABE40", Offset = "0x60AAC40", VA = "0x1860ABE40", Slot = "18")]
	public IEAHOKLNBKJ MMFLKJCANGH(string CFOMNFPLJHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60AB140", Offset = "0x60A9F40", VA = "0x1860AB140")]
	private FAFDJGMJLCP JEKJONMGLGB(string CFOMNFPLJHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x60AB390", Offset = "0x60AA190", VA = "0x1860AB390")]
	private AOLABIDBPNG LDOKPAICACN(AOLEGGEMOIO FMPDDEEEKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x60AC1B0", Offset = "0x60AAFB0", VA = "0x1860AC1B0")]
	private ALCOFKIGJJB NMJCKHNDMNP(string LFNBBMIGAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x60AB1D0", Offset = "0x60A9FD0", VA = "0x1860AB1D0")]
	private void JIJIEJKOHAF(string CJDMOEDCMDP, IKBEHCKCDLH IACOOBGNHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public JNLLGDCIAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60AA520", Offset = "0x60A9320", VA = "0x1860AA520")]
	[CompilerGenerated]
	private void NCHKKPBLKPO(LIMCMLNHIBM HFJACMIAHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60AA520", Offset = "0x60A9320", VA = "0x1860AA520")]
	[CompilerGenerated]
	private void CDOFIHLPILC(LIMCMLNHIBM HFJACMIAHKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class IMEMHEMCGHK : AFNONAOOEPJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BOPKFDCGCEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public IMEMHEMCGHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public AOLEGGEMOIO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x60A5B10", Offset = "0x60A4910", VA = "0x1860A5B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x60A6250", Offset = "0x60A5050", VA = "0x1860A6250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private AFNONAOOEPJ AGCHAOGELLF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private AFNONAOOEPJ IAFJCNLFJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x60AA0B0", Offset = "0x60A8EB0", VA = "0x1860AA0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HLCDKGLKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x60AA4D0", Offset = "0x60A92D0", VA = "0x1860AA4D0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string IMMPGGLCHFO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x60A9BD0", Offset = "0x60A89D0", VA = "0x1860A9BD0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NMOIKPBKEMM CBMGBMNODNL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x60AA260", Offset = "0x60A9060", VA = "0x1860AA260", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action CGGGBLKIBDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x60A9C20", Offset = "0x60A8A20", VA = "0x1860A9C20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x60AA320", Offset = "0x60A9120", VA = "0x1860AA320", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action GKAKKACGPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x60AA610", Offset = "0x60A9410", VA = "0x1860AA610", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x60AA880", Offset = "0x60A9680", VA = "0x1860AA880", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<LIMCMLNHIBM> NDEBEHFNPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x60AA6B0", Offset = "0x60A94B0", VA = "0x1860AA6B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x60AA560", Offset = "0x60A9360", VA = "0x1860AA560", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	[UnityEngine.Scripting.Preserve]
	public IMEMHEMCGHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x60AA810", Offset = "0x60A9610", VA = "0x1860AA810")]
	[DPHBJKOLDBD(OHNOEEJKPCM.GameOnly)]
	private static void NBDEHFOJALI(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x60AA040", Offset = "0x60A8E40", VA = "0x1860AA040")]
	[DPHBJKOLDBD(OHNOEEJKPCM.EditorOnly)]
	private static void GHBFMKPGCNG(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x60AA120", Offset = "0x60A8F20", VA = "0x1860AA120", Slot = "10")]
	[AsyncStateMachine(typeof(BOPKFDCGCEP))]
	public Task HBPIHILNAPB(string MMEOHFJIDLK, string LFNBBMIGAKG, [Optional] AOLEGGEMOIO FMPDDEEEKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x60A9CC0", Offset = "0x60A8AC0", VA = "0x1860A9CC0", Slot = "14")]
	public Task DNJIENKNOJG(AOLEGGEMOIO FMPDDEEEKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x60A9F20", Offset = "0x60A8D20", VA = "0x1860A9F20", Slot = "15")]
	public Task FNFMFEHFHFH(AOLEGGEMOIO FMPDDEEEKPA, Dictionary<string, string> DFBGENPIEOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x60A9DC0", Offset = "0x60A8BC0", VA = "0x1860A9DC0", Slot = "16")]
	public bool EPCKDJNMAMN(string OGKFDPDLPIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x60A9E70", Offset = "0x60A8C70", VA = "0x1860A9E70", Slot = "17")]
	public CGADEPEJEON FBJLAHBLIPF(string CJDMOEDCMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x60AA760", Offset = "0x60A9560", VA = "0x1860AA760", Slot = "18")]
	public IEAHOKLNBKJ MMFLKJCANGH(string CFOMNFPLJHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x60AA3C0", Offset = "0x60A91C0", VA = "0x1860AA3C0", Slot = "19")]
	public Task IJEBCPEJMIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7FB160", Offset = "0x7F9F60", VA = "0x1807FB160")]
	[CompilerGenerated]
	private void DFEFJDEGPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x82EA10", Offset = "0x82D810", VA = "0x18082EA10")]
	[CompilerGenerated]
	private void DKPJCJINOGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x60AA520", Offset = "0x60A9320", VA = "0x1860AA520")]
	[CompilerGenerated]
	private void JOINCGMGBFM(LIMCMLNHIBM HFJACMIAHKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal class DBOOILMKPMP : IEAHOKLNBKJ, ODEPNDIFJKH
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate void GHHLEMDPGEI(LIMCMLNHIBM NHPBNIABEKB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly GHHLEMDPGEI FDBFNIICNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly FAFDJGMJLCP OFLFLMJOOPL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string HBAONAGBJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D570", Offset = "0x1A8C370", VA = "0x181A8D570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x54450C0", Offset = "0x5443EC0", VA = "0x1854450C0")]
	public DBOOILMKPMP(FAFDJGMJLCP NLIBJLKDDFN, [Optional] GHHLEMDPGEI MFEDHLBMHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2742010", Offset = "0x2740E10", VA = "0x182742010", Slot = "5")]
	public T DJGCEJBDGHO<T>(string OBPLDLNDJLE, T OPPINNBBHIO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface MFEDIIHOEAO
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[UsedImplicitly]
public class MJHENIPODGL : MFEDIIHOEAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly NAANJHBDKDD CNAFOMCODFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly List<PKNFONFOMBM> FJDJBGGLKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly string BANLIJCNAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly string ELAENECINHH;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x60AC900", Offset = "0x60AB700", VA = "0x1860AC900")]
	[DPHBJKOLDBD(FMOBJKPMAGC.Root, OHNOEEJKPCM.GameOnly)]
	[UsedImplicitly]
	private static void LLBAHKJCIHJ(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x60AC970", Offset = "0x60AB770", VA = "0x1860AC970")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MJHENIPODGL([PENMPEOFMMN(null)][NotNull] NAANJHBDKDD CNAFOMCODFM, [NotNull][PENMPEOFMMN(null)] NAFBKBOGMOM FKGFDPHBHII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class OCPDFEHHEBH : AFNONAOOEPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HLCDKGLKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string IMMPGGLCHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NMOIKPBKEMM CBMGBMNODNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action CGGGBLKIBDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x60AD6C0", Offset = "0x60AC4C0", VA = "0x1860AD6C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x60AD9C0", Offset = "0x60AC7C0", VA = "0x1860AD9C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action GKAKKACGPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x60ADBA0", Offset = "0x60AC9A0", VA = "0x1860ADBA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x60ADD80", Offset = "0x60ACB80", VA = "0x1860ADD80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<LIMCMLNHIBM> NDEBEHFNPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x60ADC40", Offset = "0x60ACA40", VA = "0x1860ADC40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x60ADAF0", Offset = "0x60AC8F0", VA = "0x1860ADAF0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	[RecRoom.NoEngine.Common.Preserve]
	public OCPDFEHHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x60AD930", Offset = "0x60AC730", VA = "0x1860AD930", Slot = "10")]
	public Task HBPIHILNAPB(string MMEOHFJIDLK, string LFNBBMIGAKG, [Optional] AOLEGGEMOIO FMPDDEEEKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x60AD760", Offset = "0x60AC560", VA = "0x1860AD760", Slot = "14")]
	public Task DNJIENKNOJG(AOLEGGEMOIO FMPDDEEEKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x60AD8A0", Offset = "0x60AC6A0", VA = "0x1860AD8A0", Slot = "15")]
	public Task FNFMFEHFHFH(AOLEGGEMOIO FMPDDEEEKPA, Dictionary<string, string> DFBGENPIEOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "16")]
	public bool EPCKDJNMAMN(string OGKFDPDLPIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x60AD7F0", Offset = "0x60AC5F0", VA = "0x1860AD7F0", Slot = "17")]
	public CGADEPEJEON FBJLAHBLIPF(string CJDMOEDCMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x60ADCF0", Offset = "0x60ACAF0", VA = "0x1860ADCF0", Slot = "18")]
	public IEAHOKLNBKJ MMFLKJCANGH(string CFOMNFPLJHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x60ADA60", Offset = "0x60AC860", VA = "0x1860ADA60", Slot = "19")]
	public Task IJEBCPEJMIN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal class HGDPEOOAFNF : NMOIKPBKEMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly AOLABIDBPNG OBHKBPNBKME;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IReadOnlyDictionary<string, object> FHGDMIKJCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x10B0E50", Offset = "0x10AFC50", VA = "0x1810B0E50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public HGDPEOOAFNF(AOLABIDBPNG OEGOODJPEGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface LDOAFOKBBJA
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IJBGEPMNOFB DEJNOMIPGNF(string IFJCEBJJKFM);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FMIDLBNEILF
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum MDPGNIBGIMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	long NEIAEOOOOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string NPPJBBABCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string PJGFIKEJBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string NNPBEDJJOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string MJCLHPEIAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool JLLDKBBBMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long HKPFAAODHAA();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GMODNJBENCC(long LDLIPNAEPGL, bool EAGIHOOAFIE = true);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KKABOMJKHHH(string EJDIFPAIGMC, string FIBIHHEIDKB, string DBFGACPACOF);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NCBMOLABLDD(string EJDIFPAIGMC);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BCKHFEFKEFM(string EJDIFPAIGMC, string BLCDANMOOND, string BEOMPNLAMIA);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BPHDCGBBGAF(string HMNIBMPKHAC, object HDJDNGBJGNN, object GHKOOAHKEII);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JEIGDBJJLHN(MDPGNIBGIMD HJAAGBALIOP, int KMDAINAHNDF, [Optional] EENHCLKFHEH MMOKIDGCGHC, [Optional] string ABKJJBPLPKC, [Optional] string EPIMHJFIPDE);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void INJHAOCKIBB(EENHCLKFHEH MMOKIDGCGHC, long CHPDIALAJDG, long OJNCDAACLCM, int BOGEPCJOCBD, string ABKJJBPLPKC, int KMDAINAHNDF);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LKBKLICCGPA(EENHCLKFHEH MMOKIDGCGHC, bool KINLMAENCJL, [Optional] string EPIMHJFIPDE);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AGEHJKAMIFL(EENHCLKFHEH MMOKIDGCGHC, bool KINLMAENCJL, [Optional] string EPIMHJFIPDE);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AMDEHKKNDPF(EENHCLKFHEH MMOKIDGCGHC, bool KINLMAENCJL, [Optional] string EPIMHJFIPDE);
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
