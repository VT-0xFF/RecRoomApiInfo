using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5C06340", Offset = "0x5C05740", VA = "0x185C06340")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78E340", Offset = "0x78D740", VA = "0x18078E340")]
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
		public AmplitudeAnalyticsClient.Settings MDFFMFCNAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GFFLJCAMCDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x767950", Offset = "0x766D50", VA = "0x180767950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum JGPDLFPOOBB
		{
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class EHBLJADPLKA
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class FIGIDCAOMAK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000043")]
				public int KPJAGMGHDBL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000044")]
				public Dictionary<string, object> CBLKKJINDBN;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
				public FIGIDCAOMAK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class JHONPCHBGLK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000045")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
				public JHONPCHBGLK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x5C04E00", Offset = "0x5C04200", VA = "0x185C04E00")]
				internal bool DDCMELLPJOJ(FIGIDCAOMAK item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private const string BFCENEPCMPH = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private readonly string EOEPLCPMJAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private List<FIGIDCAOMAK> LKDPCDNNJGF;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? BEIIJFDPIMI
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x5C00D60", Offset = "0x5C00160", VA = "0x185C00D60")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5C00F30", Offset = "0x5C00330", VA = "0x185C00F30")]
			internal EHBLJADPLKA(string OLIJOMAPFNB, string LPNBEBNNKIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5C00BB0", Offset = "0x5BFFFB0", VA = "0x185C00BB0")]
			public int JPBMHGDFPDL([Optional] int? JIPAEPJHIMK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5C001F0", Offset = "0x5BFF5F0", VA = "0x185C001F0")]
			public List<Dictionary<string, object>> FLDBDILHKJK(int ANHFGLEJEGD, int? JIPAEPJHIMK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5C00150", Offset = "0x5BFF550", VA = "0x185C00150")]
			public void EOIGKMCBAPD(AmplitudeAnalyticsIdentifyMessage IBBNLILJNEB, bool OLEDBDDKCMK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5C00040", Offset = "0x5BFF440", VA = "0x185C00040")]
			public void EOIGKMCBAPD(Dictionary<string, object> IBBNLILJNEB, bool OLEDBDDKCMK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5BFFEB0", Offset = "0x5BFF2B0", VA = "0x185BFFEB0")]
			public void BOABLMCJOBB(params Dictionary<string, object>[] BCBKBJFNIJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5C00960", Offset = "0x5BFFD60", VA = "0x185C00960")]
			public void JJPELEIJGEK(List<Dictionary<string, object>> FLEFANDODMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5C00460", Offset = "0x5BFF860", VA = "0x185C00460")]
			private void GEMLDCIDAJG(Dictionary<string, object> IBBNLILJNEB, bool OLEDBDDKCMK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5BFFC70", Offset = "0x5BFF070", VA = "0x185BFFC70")]
			public void ABOGDPNKJJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5C00570", Offset = "0x5BFF970", VA = "0x185C00570")]
			private void IONBFKJDMOF([Optional] string PHAGAMHJKAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5C00E00", Offset = "0x5C00200", VA = "0x185C00E00")]
			private static string ONHDFAHKMBP(string LPCGJALKADL, string IHHOPACLNAK)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5C06CE0", Offset = "0x5C060E0", VA = "0x185C06CE0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct EBMJLOJNDBF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public int OKHIGOKAHDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public string OLBBMLBKPNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public T AGIFLEAOBOA;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class IHIDCJNGKAC : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private AOAPPGOKEOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
			[DebuggerHidden]
			public IHIDCJNGKAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x5C046C0", Offset = "0x5C03AC0", VA = "0x185C046C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5C04DB0", Offset = "0x5C041B0", VA = "0x185C04DB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JONBBCAJDMJ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public NMHMFMOCBJF quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
			[DebuggerHidden]
			public JONBBCAJDMJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5C04E70", Offset = "0x5C04270", VA = "0x185C04E70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5C04F80", Offset = "0x5C04380", VA = "0x185C04F80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class CLKHOJEOJDN : IEnumerator<object>, IEnumerator, IDisposable
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
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
			[DebuggerHidden]
			public CLKHOJEOJDN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5BFF780", Offset = "0x5BFEB80", VA = "0x185BFF780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x5BFF8F0", Offset = "0x5BFECF0", VA = "0x185BFF8F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class PPHGGHKAGIH : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private AOAPPGOKEOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
			[DebuggerHidden]
			public PPHGGHKAGIH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x5C066A0", Offset = "0x5C05AA0", VA = "0x185C066A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5C06920", Offset = "0x5C05D20", VA = "0x185C06920", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class OOJHPAFOADO : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private AOAPPGOKEOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
			[DebuggerHidden]
			public OOJHPAFOADO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5C063C0", Offset = "0x5C057C0", VA = "0x185C063C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5C06650", Offset = "0x5C05A50", VA = "0x185C06650", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class MALOCDBMCCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public EHBLJADPLKA cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public MALOCDBMCCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x5C06020", Offset = "0x5C05420", VA = "0x185C06020")]
			internal void FEMIHKJPMIB(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5C05BD0", Offset = "0x5C04FD0", VA = "0x185C05BD0")]
			internal void FBJIPAEMAOO(EBMJLOJNDBF<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class KACOFHCNJJJ : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private AOAPPGOKEOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public EHBLJADPLKA cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private MALOCDBMCCJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
			[DebuggerHidden]
			public KACOFHCNJJJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5C04FD0", Offset = "0x5C043D0", VA = "0x185C04FD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5C05820", Offset = "0x5C04C20", VA = "0x185C05820", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class NMNKFDBLKCA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public NMNKFDBLKCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x339BDD0", Offset = "0x339B1D0", VA = "0x18339BDD0")]
			internal EBMJLOJNDBF<T> FPCPKDFPCHF(PECMGEOIGDB postResponse)
			{
				return default(EBMJLOJNDBF<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class FEMHMCBOIFH<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public FEMHMCBOIFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x339BDD0", Offset = "0x339B1D0", VA = "0x18339BDD0")]
			internal EBMJLOJNDBF<T> IAFBECJIMOK(PECMGEOIGDB postResponse)
			{
				return default(EBMJLOJNDBF<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private EGHCFFGENEP GOBFOCBFGCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<KNJNLLGBPHO> LCCBMILHMCB;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string AGFJJIAIFLO = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string FMAPGOFNAGO = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string DIGCNHGIJAM = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int CCEJLFDJALK = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int GNLCDIGHPGI = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int LHCPKDKDMLA = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float CDJPFLMCFDL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long FNPOALHEIKL = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string JCIHBLAEJJA = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string NDIIDLFLPKC = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool OIAEDHGLPID;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool INMPFCDBDPJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int IOGEEJCNLOK;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int CDPDHLBGCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private AMAMDBDBOFA KFDAGFCFCHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool MCJIEGIBNAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private float KOEJJDINGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private float LMICMMOPHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private int HCFBNFDGPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int MAOKBCNJNCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int? HALAJOHPOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int? MLNAHADAPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private long FHMOLBMCFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private string MIHAAFNOMLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool HLHBFKNCNBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private long FBOAJADBFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Dictionary<string, object> NPNALDIBBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private JGPDLFPOOBB KELBFKEPLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int GOBABNEBHPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private int INKPMPHPJBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private float JOPAFBNCGOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private bool HGNNEIHEAOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool KOOKCMMGFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private EHBLJADPLKA GOFEHJPGHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private EHBLJADPLKA MCDAIJKOMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private EHBLJADPLKA AFIIFCLBOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> DIDIOEKCFLB;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo EJLLAOCPPJC;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static string LNPCMIMBKOL;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string BCKJOONDPEG = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly string DEBAKOIEMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly string CNJGPGHOAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly string KIEONOCNADJ;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private EGHCFFGENEP JPLOFOKPKJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5BFB010", Offset = "0x5BFA410", VA = "0x185BFB010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private KNJNLLGBPHO ELLGNNMBLNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5BF9420", Offset = "0x5BF8820", VA = "0x185BF9420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int OGPJKJPMBCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5BFC6D0", Offset = "0x5BFBAD0", VA = "0x185BFC6D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long BCBLBJDGEPA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5BFE040", Offset = "0x5BFD440", VA = "0x185BFE040")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5BFE150", Offset = "0x5BFD550", VA = "0x185BFE150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string FGGCACJFCIF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5BFDFE0", Offset = "0x5BFD3E0", VA = "0x185BFDFE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string HOICJJJCHLG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5BFE010", Offset = "0x5BFD410", VA = "0x185BFE010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ICKFLPLMPHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7F6F50", Offset = "0x7F6350", VA = "0x1807F6F50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x89BDE0", Offset = "0x89B1E0", VA = "0x18089BDE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? MAOGFPHOLCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x89BB10", Offset = "0x89AF10", VA = "0x18089BB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x10DD0D0", Offset = "0x10DC4D0", VA = "0x1810DD0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GOKEOAHMHIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF98670", Offset = "0xF97A70", VA = "0x180F98670")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xF919F0", Offset = "0xF90DF0", VA = "0x180F919F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool LNBNLCKLOFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5BFDEE0", Offset = "0x5BFD2E0", VA = "0x185BFDEE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> DIBILAJGMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5BFDE20", Offset = "0x5BFD220", VA = "0x185BFDE20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5BFE090", Offset = "0x5BFD490", VA = "0x185BFE090")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5BF8D40", Offset = "0x5BF8140", VA = "0x185BF8D40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5BF9470", Offset = "0x5BF8870", VA = "0x185BF9470")]
		private void EHHBKNDJNFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5BFD510", Offset = "0x5BFC910", VA = "0x185BFD510")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5BFC360", Offset = "0x5BFB760", VA = "0x185BFC360", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5BFD7F0", Offset = "0x5BFCBF0", VA = "0x185BFD7F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5BFC8B0", Offset = "0x5BFBCB0", VA = "0x185BFC8B0")]
		public IKPLFJCHDDD PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5BFB510", Offset = "0x5BFA910", VA = "0x185BFB510")]
		[IteratorStateMachine(typeof(IHIDCJNGKAC))]
		public IEnumerator<AOAPPGOKEOI> Initialize(AmplitudeAnalyticsEvent AKDJODANENN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5BFD700", Offset = "0x5BFCB00", VA = "0x185BFD700")]
		public void UpdateLastAliveTime(float PMOHIPDKHDN = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5BFAF50", Offset = "0x5BFA350", VA = "0x185BFAF50")]
		private IKPLFJCHDDD IIMAHLHKKJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5BF9870", Offset = "0x5BF8C70", VA = "0x185BF9870")]
		private IKPLFJCHDDD ENPNJDEAGAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5BFCF60", Offset = "0x5BFC360", VA = "0x185BFCF60")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5BFA0E0", Offset = "0x5BF94E0", VA = "0x185BFA0E0")]
		[IteratorStateMachine(typeof(JONBBCAJDMJ))]
		private IEnumerator GFBKJAGPHAD(NMHMFMOCBJF KJANEHNOMCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5BFDA80", Offset = "0x5BFCE80", VA = "0x185BFDA80")]
		[IteratorStateMachine(typeof(CLKHOJEOJDN))]
		public IEnumerator WaitForFlush(float HKLLMMFEENO = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5BFD5E0", Offset = "0x5BFC9E0", VA = "0x185BFD5E0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5BFD520", Offset = "0x5BFC920", VA = "0x185BFD520")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime OCOBDBFPKCG)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5BFB080", Offset = "0x5BFA480", VA = "0x185BFB080")]
		public static GEDDPAKCKIA Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5BF8BD0", Offset = "0x5BF7FD0", VA = "0x185BF8BD0")]
		public static LFABFEFONGK AccountSelectionPostLoginEvent([NotNull] string GGDNDIFMFJN, string BKPFJDEPNEJ, bool PPAKIAEIHFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5BF9B60", Offset = "0x5BF8F60", VA = "0x185BF9B60")]
		public static LFABFEFONGK Event([NotNull] string GGDNDIFMFJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5BFC8F0", Offset = "0x5BFBCF0", VA = "0x185BFC8F0")]
		public static LFABFEFONGK PreviousSessionEvent([NotNull] string GGDNDIFMFJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5BFB230", Offset = "0x5BFA630", VA = "0x185BFB230")]
		public static LFABFEFONGK InitializeEvent(string BKPFJDEPNEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5BFD120", Offset = "0x5BFC520", VA = "0x185BFD120")]
		public static LFABFEFONGK StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5BF91C0", Offset = "0x5BF85C0", VA = "0x185BF91C0")]
		public static LFABFEFONGK CreateOutOfSessionEvent(string GGDNDIFMFJN, bool EPAOOCNACII = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5BFBCB0", Offset = "0x5BFB0B0", VA = "0x185BFBCB0")]
		public static IKPLFJCHDDD LogOutOfSessionEvent(LFABFEFONGK MHECFILBJDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5BFBA30", Offset = "0x5BFAE30", VA = "0x185BFBA30")]
		public void LogEventAsync(AmplitudeAnalyticsEvent MLOHJANCKDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5BFBFA0", Offset = "0x5BFB3A0", VA = "0x185BFBFA0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent MLOHJANCKDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5BFC0E0", Offset = "0x5BFB4E0", VA = "0x185BFC0E0")]
		public void LogSerializedEventAsync(Dictionary<string, object> GANDMCHKLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5BFBB70", Offset = "0x5BFAF70", VA = "0x185BFBB70")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage BFPDKLLLJHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5BF9070", Offset = "0x5BF8470", VA = "0x185BF9070")]
		private void BFOFDMDFJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5BFC420", Offset = "0x5BFB820", VA = "0x185BFC420")]
		private void PCLAIKHPGAC(Dictionary<string, object> MBBGMGFANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5BF9F60", Offset = "0x5BF9360", VA = "0x185BF9F60")]
		private void FHHAIOIIIJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5BF9D90", Offset = "0x5BF9190", VA = "0x185BF9D90")]
		private void FGCPIOIINNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5BFA050", Offset = "0x5BF9450", VA = "0x185BFA050")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5BFB5A0", Offset = "0x5BFA9A0", VA = "0x185BFB5A0")]
		[IteratorStateMachine(typeof(PPHGGHKAGIH))]
		private IEnumerator<AOAPPGOKEOI> JAEPMMENNKL(float HKLLMMFEENO = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5BFC2D0", Offset = "0x5BFB6D0", VA = "0x185BFC2D0")]
		[IteratorStateMachine(typeof(OOJHPAFOADO))]
		private IEnumerator<AOAPPGOKEOI> NAHJMPNKJLA(float HKLLMMFEENO = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5BFAE40", Offset = "0x5BFA240", VA = "0x185BFAE40")]
		[IteratorStateMachine(typeof(KACOFHCNJJJ))]
		private IEnumerator<AOAPPGOKEOI> IDDNDMMNECP(EHBLJADPLKA OGPEIJFPBNA, int? JIPAEPJHIMK, string GJCBEODFCKJ, string JOKHABOLOHD, float HKLLMMFEENO, Action<int> KMGCLDIODPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5BFC1C0", Offset = "0x5BFB5C0", VA = "0x185BFC1C0")]
		private static void MAFJMANNBLL(bool EICKEPNLEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5BFB630", Offset = "0x5BFAA30", VA = "0x185BFB630")]
		private DMGBOCKAFMH<EBMJLOJNDBF<Dictionary<string, object>>> JAFLKMNFDPC(string GJCBEODFCKJ, string JOKHABOLOHD, string GPFDKKBGIPH, string IOFCFIJAGLJ, Dictionary<string, object> AGIFLEAOBOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5BFB750", Offset = "0x5BFAB50", VA = "0x185BFB750")]
		private DMGBOCKAFMH<EBMJLOJNDBF<List<Dictionary<string, object>>>> JAFLKMNFDPC(string GJCBEODFCKJ, string JOKHABOLOHD, string GPFDKKBGIPH, string IOFCFIJAGLJ, List<Dictionary<string, object>> AGIFLEAOBOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2A161F0", Offset = "0x2A155F0", VA = "0x182A161F0")]
		private DMGBOCKAFMH<EBMJLOJNDBF<T>> GPCJIADAFIF<T>(string GJCBEODFCKJ, string JOKHABOLOHD, string IOFCFIJAGLJ, T AGIFLEAOBOA, Dictionary<string, object> FIJHICCPGGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2A15EC0", Offset = "0x2A152C0", VA = "0x182A15EC0")]
		private DMGBOCKAFMH<EBMJLOJNDBF<T>> EGMLLLNDNAB<T>(string GJCBEODFCKJ, string JOKHABOLOHD, string GPFDKKBGIPH, T AGIFLEAOBOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5BF9170", Offset = "0x5BF8570", VA = "0x185BF9170")]
		private bool CDBACNHLAGE(float DABBGBCMHPI, float HKLLMMFEENO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5BFA170", Offset = "0x5BF9570", VA = "0x185BFA170")]
		private Dictionary<string, object> GHBOGEOBEEK(string JOKHABOLOHD, Dictionary<string, object> AGIFLEAOBOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5BFDB70", Offset = "0x5BFCF70", VA = "0x185BFDB70")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5BF8A70", Offset = "0x5BF7E70", VA = "0x185BF8A70")]
		[CompilerGenerated]
		private long AIEMCNAMBLO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5BFAF40", Offset = "0x5BFA340", VA = "0x185BFAF40")]
		[CompilerGenerated]
		private void IEJLLFMDBNK(int DCKAPIPBAFB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly bool isBrazeUser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5BFEE60", Offset = "0x5BFE260", VA = "0x185BFEE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5BFEF40", Offset = "0x5BFE340", VA = "0x185BFEF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5BFEEA0", Offset = "0x5BFE2A0", VA = "0x185BFEEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5BFEFA0", Offset = "0x5BFE3A0", VA = "0x185BFEFA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5BFEE20", Offset = "0x5BFE220", VA = "0x185BFEE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5BFEEE0", Offset = "0x5BFE2E0", VA = "0x185BFEEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7699F0", Offset = "0x768DF0", VA = "0x1807699F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5BFEB90", Offset = "0x5BFDF90", VA = "0x185BFEB90")]
		public static LFABFEFONGK PJBIIEEDKDI(string KAHINILDCOI, [NotNull] string AKCDJHCJKFH, long HBOGOGMEMJB, long KJDDFHJKGHJ, string BKPFJDEPNEJ, bool PPAKIAEIHFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5BFE6E0", Offset = "0x5BFDAE0", VA = "0x185BFE6E0")]
		public static LFABFEFONGK FHIHKGFNHME(string KAHINILDCOI, [NotNull] string AKCDJHCJKFH, long HBOGOGMEMJB, long KJDDFHJKGHJ, string BKPFJDEPNEJ, long LMEGJGHEHFP, bool PPAKIAEIHFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5BFEC90", Offset = "0x5BFE090", VA = "0x185BFEC90")]
		private AmplitudeAnalyticsEvent(string KAHINILDCOI, [NotNull] string AKCDJHCJKFH, long HBOGOGMEMJB, long KJDDFHJKGHJ, string BKPFJDEPNEJ, bool PPAKIAEIHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x184A700", Offset = "0x1849B00", VA = "0x18184A700")]
		public void NPKGMFCKFGN(long JGHFJJJMNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5BFE7F0", Offset = "0x5BFDBF0", VA = "0x185BFE7F0", Slot = "5")]
		public override void GGFNNGCBOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5BFE900", Offset = "0x5BFDD00", VA = "0x185BFE900", Slot = "6")]
		public override void OCEEGDPLIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5BFE1B0", Offset = "0x5BFD5B0", VA = "0x185BFE1B0", Slot = "4")]
		protected override Dictionary<string, object> BFKIIPMFFJO(Dictionary<string, object> GKGKBJNBKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5BFEA80", Offset = "0x5BFDE80", VA = "0x185BFEA80")]
		private void OPLHCPAOMBD(string IHHOPACLNAK, string LPCGJALKADL, bool COIJNONCPGC = false)
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
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5BFFAF0", Offset = "0x5BFEEF0", VA = "0x185BFFAF0")]
			public void AKPBJFIJLDK(Dictionary<string, object> CCHBPFAMAHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5C06970", Offset = "0x5C05D70", VA = "0x185C06970")]
			public void AKPBJFIJLDK(Dictionary<string, object> LLDGGDDKKLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7D3810", Offset = "0x7D2C10", VA = "0x1807D3810")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x764460", Offset = "0x763860", VA = "0x180764460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5BFF600", Offset = "0x5BFEA00", VA = "0x185BFF600")]
		public static GEDDPAKCKIA PJBIIEEDKDI(string KAHINILDCOI, string BKPFJDEPNEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5BFF6C0", Offset = "0x5BFEAC0", VA = "0x185BFF6C0")]
		protected AmplitudeAnalyticsIdentifyMessage(string KAHINILDCOI, string BKPFJDEPNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5BFF340", Offset = "0x5BFE740", VA = "0x185BFF340")]
		public Dictionary<string, object> EGHDBCCNKEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5BFF000", Offset = "0x5BFE400", VA = "0x185BFF000", Slot = "4")]
		protected virtual Dictionary<string, object> BFKIIPMFFJO(Dictionary<string, object> GKGKBJNBKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5BFF4D0", Offset = "0x5BFE8D0", VA = "0x185BFF4D0")]
		protected void OAGGBFDJEHA(string IHHOPACLNAK, Dictionary<string, object> LFHFBEEGEOE, Dictionary<string, object> DDFPBJNADDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5BFF460", Offset = "0x5BFE860", VA = "0x185BFF460")]
		protected void HAAFMEBGECA(string IHHOPACLNAK, string LPCGJALKADL, Dictionary<string, object> MEKOCDKMDAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5BFF3D0", Offset = "0x5BFE7D0", VA = "0x185BFF3D0", Slot = "5")]
		public virtual void GGFNNGCBOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5BFF570", Offset = "0x5BFE970", VA = "0x185BFF570", Slot = "6")]
		public virtual void OCEEGDPLIOK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GEDDPAKCKIA : MMHKOFFFPED<AmplitudeAnalyticsIdentifyMessage, GEDDPAKCKIA>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override GEDDPAKCKIA NJKOMMNMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage MPDONAGNKHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5C025A0", Offset = "0x5C019A0", VA = "0x185C025A0")]
	public GEDDPAKCKIA(AmplitudeAnalyticsIdentifyMessage LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5C024F0", Offset = "0x5C018F0", VA = "0x185C024F0", Slot = "4")]
	public override void OCEEGDPLIOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LFABFEFONGK : MMHKOFFFPED<AmplitudeAnalyticsEvent, LFABFEFONGK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private bool PPLAHOIEHNF;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override LFABFEFONGK NJKOMMNMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long KFDGBNBGKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1C09730", Offset = "0x1C08B30", VA = "0x181C09730")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5C01270", Offset = "0x5C00670", VA = "0x185C01270")]
	public LFABFEFONGK(AmplitudeAnalyticsEvent LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "5")]
	public override AmplitudeAnalyticsEvent MPDONAGNKHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5C05A90", Offset = "0x5C04E90", VA = "0x185C05A90", Slot = "4")]
	public override void OCEEGDPLIOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x244CBE0", Offset = "0x244BFE0", VA = "0x18244CBE0")]
	public LFABFEFONGK LCKCIPAJBOP<T>(string OIBKEMMFJDM, T[] LPCGJALKADL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x244CBE0", Offset = "0x244BFE0", VA = "0x18244CBE0")]
	public LFABFEFONGK LCKCIPAJBOP(string OIBKEMMFJDM, string[] LPCGJALKADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x244C930", Offset = "0x244BD30", VA = "0x18244C930")]
	public LFABFEFONGK LCKCIPAJBOP<T>(string OIBKEMMFJDM, T LPCGJALKADL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5C059E0", Offset = "0x5C04DE0", VA = "0x185C059E0")]
	public LFABFEFONGK LCKCIPAJBOP(string OIBKEMMFJDM, long LPCGJALKADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5C05970", Offset = "0x5C04D70", VA = "0x185C05970")]
	public LFABFEFONGK LCKCIPAJBOP(string OIBKEMMFJDM, string LPCGJALKADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5C05A60", Offset = "0x5C04E60", VA = "0x185C05A60")]
	public LFABFEFONGK NPDHEPPDLBH(string OIBKEMMFJDM, object? LPCGJALKADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5C05B30", Offset = "0x5C04F30", VA = "0x185C05B30")]
	public LFABFEFONGK OFJIDPKALHE(string OIBKEMMFJDM, string LPCGJALKADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5C05870", Offset = "0x5C04C70", VA = "0x185C05870")]
	private LFABFEFONGK KLHFCPJDJMM(string OIBKEMMFJDM, object LPCGJALKADL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class EJEDPDPPBJE : LFABFEFONGK
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5C01270", Offset = "0x5C00670", VA = "0x185C01270")]
	public EJEDPDPPBJE(AmplitudeAnalyticsEvent LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5C010C0", Offset = "0x5C004C0", VA = "0x185C010C0", Slot = "4")]
	public override void OCEEGDPLIOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class MMHKOFFFPED<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : MMHKOFFFPED<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected M LMJAPBNMKLG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR NJKOMMNMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	public MMHKOFFFPED(M LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3B81690", Offset = "0x3B80A90", VA = "0x183B81690")]
	public BLDR KEMFBBHOEEE(AmplitudeAnalyticsIdentifyMessage.DeviceInfo GOAHOJBIMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3B816E0", Offset = "0x3B80AE0", VA = "0x183B816E0")]
	public BLDR OBJBDCIFKMJ(AmplitudeAnalyticsIdentifyMessage.RevenueData GDFCNCAOGAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3B81730", Offset = "0x3B80B30", VA = "0x183B81730")]
	public BLDR OPGDPMFPLDA(string OIBKEMMFJDM, string LPCGJALKADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2154E10", Offset = "0x2154210", VA = "0x182154E10")]
	public BLDR OPGDPMFPLDA<T>(string OIBKEMMFJDM, T LPCGJALKADL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void OCEEGDPLIOK();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3B81660", Offset = "0x3B80A60", VA = "0x183B81660")]
	internal static string FCDBKPAOCFM(string LPCGJALKADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3B81560", Offset = "0x3B80960", VA = "0x183B81560")]
	private BLDR BNJGOCGLGBL(string OIBKEMMFJDM, object LPCGJALKADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M MPDONAGNKHF();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DCJGBJLKIBD
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> OIGJLONHIDH;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5BFF940", Offset = "0x5BFED40", VA = "0x185BFF940")]
	internal static bool GINOAHBDMEM(string IHHOPACLNAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AMAMDBDBOFA
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool HMLFIHHECBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string KLIANJNDCEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	string CMCADMLFNFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	string GDGLACPEEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	string INNGMLENMCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DMGBOCKAFMH<PECMGEOIGDB> JAFLKMNFDPC(string GJCBEODFCKJ, Dictionary<string, string> HOGDJFCJPCE, bool MBGINJCOGCE = false);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DMGBOCKAFMH<PECMGEOIGDB> PGMEMOLBMFP(string GJCBEODFCKJ, string GHPGGNJDAPN, string ICMHIBFMBEC, string NEAPEJLBOMI);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct PECMGEOIGDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly int PMCNPFEIJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly string BMHCBGPIBKL;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xA9A6B0", Offset = "0xA99AB0", VA = "0x180A9A6B0")]
	public PECMGEOIGDB(int OKHIGOKAHDP, string OLBBMLBKPNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum NOFGEBAGGDA
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	GameInvite
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class ELBEBAMIIFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private long CKNFLJOPEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private LFABFEFONGK GJKICMODDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool JJPIHJGGHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private float JNFKMHIGCOM;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5C01650", Offset = "0x5C00A50", VA = "0x185C01650")]
	public ELBEBAMIIFL(string LLOEIJJLCAJ, float JNFKMHIGCOM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2259600", Offset = "0x2258A00", VA = "0x182259600")]
	public void LCKCIPAJBOP<T>(string OIBKEMMFJDM, T LPCGJALKADL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5C01470", Offset = "0x5C00870", VA = "0x185C01470")]
	public void LCKCIPAJBOP(string OIBKEMMFJDM, string LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5C012C0", Offset = "0x5C006C0", VA = "0x185C012C0")]
	public void DFJFJDAALPJ(string DECFDLNMJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5C013B0", Offset = "0x5C007B0", VA = "0x185C013B0")]
	public void DPFLNPFCBKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5C01540", Offset = "0x5C00940", VA = "0x185C01540")]
	private void PJHMNFCECAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5C014F0", Offset = "0x5C008F0", VA = "0x185C014F0")]
	private bool MIKEHCLNINB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OEDPDKKLCHP
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool JMGKFCEFHMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HPKLFDNNLEJ;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PDJEFBPACGK;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IKPLFJCHDDD OMELHDOHHCI(string HAACLNOHPGF, string LPNBEBNNKIF, [Optional] DEEAKOAIMCF DGDOPLPIJFD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IKPLFJCHDDD AEFBPGIKJDE(DEEAKOAIMCF DGDOPLPIJFD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IKPLFJCHDDD HOBEELNBHCA(DEEAKOAIMCF DGDOPLPIJFD, Dictionary<string, string> MMENJGLDHGP);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IHAIADNEFKA(string CGLPMELGNCO);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ADAHHGBJBDJ CKMCAKJKDEO(string BBHBLBCCNMM);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AGIJIMCIAJA ECGLHMGOLKI(string LPMMMFILEPE);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IKPLFJCHDDD GBONHINCNLA();
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5C06AE0", Offset = "0x5C05EE0", VA = "0x185C06AE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HCFPCGNKKGK : OEDPDKKLCHP
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly IReadOnlyDictionary<string, CIECMNGHCHC> POPCPDLJKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool FCDPPOOCFPP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool JMGKFCEFHMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7B47D0", Offset = "0x7B3BD0", VA = "0x1807B47D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action HPKLFDNNLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5C03820", Offset = "0x5C02C20", VA = "0x185C03820", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5C03310", Offset = "0x5C02710", VA = "0x185C03310", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action PDJEFBPACGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5C03B10", Offset = "0x5C02F10", VA = "0x185C03B10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5C03A70", Offset = "0x5C02E70", VA = "0x185C03A70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5C03BB0", Offset = "0x5C02FB0", VA = "0x185C03BB0", Slot = "8")]
	public IKPLFJCHDDD OMELHDOHHCI(string HAACLNOHPGF, string LPNBEBNNKIF, [Optional] DEEAKOAIMCF DGDOPLPIJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5C031C0", Offset = "0x5C025C0", VA = "0x185C031C0", Slot = "15")]
	public IKPLFJCHDDD GBONHINCNLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5C025F0", Offset = "0x5C019F0", VA = "0x185C025F0", Slot = "10")]
	public IKPLFJCHDDD AEFBPGIKJDE(DEEAKOAIMCF DGDOPLPIJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5C034C0", Offset = "0x5C028C0", VA = "0x185C034C0", Slot = "11")]
	public IKPLFJCHDDD HOBEELNBHCA(DEEAKOAIMCF DGDOPLPIJFD, Dictionary<string, string> MMENJGLDHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5C03790", Offset = "0x5C02B90", VA = "0x185C03790", Slot = "12")]
	public bool IHAIADNEFKA(string CGLPMELGNCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5C02EB0", Offset = "0x5C022B0", VA = "0x185C02EB0", Slot = "13")]
	public ADAHHGBJBDJ CKMCAKJKDEO(string BBHBLBCCNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5C030B0", Offset = "0x5C024B0", VA = "0x185C030B0", Slot = "14")]
	public AGIJIMCIAJA ECGLHMGOLKI(string LPMMMFILEPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5C027E0", Offset = "0x5C01BE0", VA = "0x185C027E0")]
	private FMGBADKIGGP BFCOGNPHICP(DEEAKOAIMCF DGDOPLPIJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5C038C0", Offset = "0x5C02CC0", VA = "0x185C038C0")]
	private EOCLIMIIMCM LCBNNOFNKIF(string LPNBEBNNKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5C033B0", Offset = "0x5C027B0", VA = "0x185C033B0")]
	private void HJAOEJIAGJA(string BBHBLBCCNMM, ADAHHGBJBDJ DAHGDHMNEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public HCFPCGNKKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA200E0", Offset = "0xA1F4E0", VA = "0x180A200E0")]
	[CompilerGenerated]
	private void PMKPIMKBODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5C03140", Offset = "0x5C02540", VA = "0x185C03140")]
	[CompilerGenerated]
	private void FHLKJFNKHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5C04020", Offset = "0x5C03420", VA = "0x185C04020")]
	[CompilerGenerated]
	private void PBOJDIBIKGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GDAEDGEDAAG : OEDPDKKLCHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private OEDPDKKLCHP BDLNIMPLGCJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private OEDPDKKLCHP ABOJMBBIHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5C018F0", Offset = "0x5C00CF0", VA = "0x185C018F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JMGKFCEFHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5C01EC0", Offset = "0x5C012C0", VA = "0x185C01EC0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action HPKLFDNNLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5C01FC0", Offset = "0x5C013C0", VA = "0x185C01FC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5C01D00", Offset = "0x5C01100", VA = "0x185C01D00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action PDJEFBPACGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5C02170", Offset = "0x5C01570", VA = "0x185C02170", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5C020D0", Offset = "0x5C014D0", VA = "0x185C020D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	[UnityEngine.Scripting.Preserve]
	public GDAEDGEDAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5C02060", Offset = "0x5C01460", VA = "0x185C02060")]
	[DCEDJGMCFCN(IIPPAMCLFBJ.GameOnly)]
	private static void KNIANBDCMAC(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5C01A70", Offset = "0x5C00E70", VA = "0x185C01A70")]
	[DCEDJGMCFCN(IIPPAMCLFBJ.EditorOnly)]
	private static void COJKJFLNCLJ(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5C02210", Offset = "0x5C01610", VA = "0x185C02210", Slot = "8")]
	public IKPLFJCHDDD OMELHDOHHCI(string HAACLNOHPGF, string LPNBEBNNKIF, [Optional] DEEAKOAIMCF DGDOPLPIJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5C017E0", Offset = "0x5C00BE0", VA = "0x185C017E0", Slot = "10")]
	public IKPLFJCHDDD AEFBPGIKJDE(DEEAKOAIMCF DGDOPLPIJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5C01DA0", Offset = "0x5C011A0", VA = "0x185C01DA0", Slot = "11")]
	public IKPLFJCHDDD HOBEELNBHCA(DEEAKOAIMCF DGDOPLPIJFD, Dictionary<string, string> MMENJGLDHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5C01F10", Offset = "0x5C01310", VA = "0x185C01F10", Slot = "12")]
	public bool IHAIADNEFKA(string CGLPMELGNCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5C01960", Offset = "0x5C00D60", VA = "0x185C01960", Slot = "13")]
	public ADAHHGBJBDJ CKMCAKJKDEO(string BBHBLBCCNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5C01AE0", Offset = "0x5C00EE0", VA = "0x185C01AE0", Slot = "14")]
	public AGIJIMCIAJA ECGLHMGOLKI(string LPMMMFILEPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5C01BF0", Offset = "0x5C00FF0", VA = "0x185C01BF0", Slot = "15")]
	public IKPLFJCHDDD GBONHINCNLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0280", Offset = "0x7AF680", VA = "0x1807B0280")]
	[CompilerGenerated]
	private void FADEEIIBOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA95CD0", Offset = "0xA950D0", VA = "0x180A95CD0")]
	[CompilerGenerated]
	private void NJCHCEBEIKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class HLBPMJGAFAB : OEDPDKKLCHP
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool JMGKFCEFHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action HPKLFDNNLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5C04450", Offset = "0x5C03850", VA = "0x185C04450", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5C04320", Offset = "0x5C03720", VA = "0x185C04320", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action PDJEFBPACGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5C04590", Offset = "0x5C03990", VA = "0x185C04590", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5C044F0", Offset = "0x5C038F0", VA = "0x185C044F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	[RecRoom.NoEngine.Common.Preserve]
	public HLBPMJGAFAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5C04630", Offset = "0x5C03A30", VA = "0x185C04630", Slot = "8")]
	public IKPLFJCHDDD OMELHDOHHCI(string HAACLNOHPGF, string LPNBEBNNKIF, [Optional] DEEAKOAIMCF DGDOPLPIJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5C041E0", Offset = "0x5C035E0", VA = "0x185C041E0", Slot = "10")]
	public IKPLFJCHDDD AEFBPGIKJDE(DEEAKOAIMCF DGDOPLPIJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5C043C0", Offset = "0x5C037C0", VA = "0x185C043C0", Slot = "11")]
	public IKPLFJCHDDD HOBEELNBHCA(DEEAKOAIMCF DGDOPLPIJFD, Dictionary<string, string> MMENJGLDHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "12")]
	public bool IHAIADNEFKA(string CGLPMELGNCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5C04270", Offset = "0x5C03670", VA = "0x185C04270", Slot = "13")]
	public ADAHHGBJBDJ CKMCAKJKDEO(string BBHBLBCCNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5C04280", Offset = "0x5C03680", VA = "0x185C04280", Slot = "14")]
	public AGIJIMCIAJA ECGLHMGOLKI(string LPMMMFILEPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5C04290", Offset = "0x5C03690", VA = "0x185C04290", Slot = "15")]
	public IKPLFJCHDDD GBONHINCNLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface CMBGOEPCLNJ
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ELBEBAMIIFL PIPEEIIKEJD(string LLOEIJJLCAJ);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FAGBBEOFAHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	long PLJCLIILDAC
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long ALMLFDPHFGF();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HIDOMKHBHMJ(long HBOGOGMEMJB, bool COIJNONCPGC = true);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PPGIGGAIENL(string CNKGFJIJGPA, string IBBAHGLEJNL, string PHMAMENLMAA);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HIDMMPPFNFE(string CNKGFJIJGPA);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OIKCPIDLKGD(string CNKGFJIJGPA, string KOJEGKLCCCO, string JNIEGHBHGOK);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NKCOFAABCGP(string BJCOOPFBLAC, object PDJDGHFLIOP, object PLPFFCBMMAN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface DEEAKOAIMCF
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool AHFPPJCBIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool PCIFFMGNKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool EAPDLEAEJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool? JPIHCOFPPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	int? MAOGFPHOLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int IDALBIAHLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string DFOBCBMKABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string BLJAADKAKCB
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string JFBOPGLEMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	long GKBOKECKALL
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string ILECKFJDDNE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string HFELPBPOLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string JEBKDEPCAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string MKHPFHLDDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	double CEONKOHGMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	int PPGNCPMIAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
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
