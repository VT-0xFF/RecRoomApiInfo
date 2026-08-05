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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BEDC60", Offset = "0x5BECA60", VA = "0x185BEDC60")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C950", Offset = "0x78B750", VA = "0x18078C950")]
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
		public AmplitudeAnalyticsClient.Settings BOGMAIEPFBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MGIBOGAKLAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x76B180", Offset = "0x769F80", VA = "0x18076B180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum KPPBEKFHCPK
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class HEJOFNDIPHL
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class BNELDFLLMKC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000046")]
				public int KAHPEDJHIJH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public Dictionary<string, object> LFEIBOIPKNG;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
				public BNELDFLLMKC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class DNPBMEAABEN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
				public DNPBMEAABEN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5BE72C0", Offset = "0x5BE60C0", VA = "0x185BE72C0")]
				internal bool LLCGGHLBGFJ(BNELDFLLMKC item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private const string CNICMKAICJD = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private readonly string GKNFKOKBKMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private List<BNELDFLLMKC> JEMIILNAEOB;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? NIDANIPFGJJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5BE87E0", Offset = "0x5BE75E0", VA = "0x185BE87E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5BE9170", Offset = "0x5BE7F70", VA = "0x185BE9170")]
			internal HEJOFNDIPHL(string BMGEKFKLEOE, string ONLMOCLKOOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5BE8230", Offset = "0x5BE7030", VA = "0x185BE8230")]
			public int CLBNCPGAAHL([Optional] int? EIFPJCNOIJJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5BE83E0", Offset = "0x5BE71E0", VA = "0x185BE83E0")]
			public List<Dictionary<string, object>> DOCDPFAMDHG(int MCJNECOBMNJ, int? EIFPJCNOIJJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5BE90D0", Offset = "0x5BE7ED0", VA = "0x185BE90D0")]
			public void OKKDPDHCAGG(AmplitudeAnalyticsIdentifyMessage HBDENJGMDDF, bool JPHEILHLLJM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5BE8FC0", Offset = "0x5BE7DC0", VA = "0x185BE8FC0")]
			public void OKKDPDHCAGG(Dictionary<string, object> HBDENJGMDDF, bool JPHEILHLLJM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5BE8650", Offset = "0x5BE7450", VA = "0x185BE8650")]
			public void ENDBHIHILNL(params Dictionary<string, object>[] BOPOANMOPHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7EB0", Offset = "0x5BE6CB0", VA = "0x185BE7EB0")]
			public void ADBFBIOGEEA(List<Dictionary<string, object>> BGDCGEDOOKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5BE8AC0", Offset = "0x5BE78C0", VA = "0x185BE8AC0")]
			private void JMJLCNEBAKI(Dictionary<string, object> HBDENJGMDDF, bool JPHEILHLLJM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5BE8880", Offset = "0x5BE7680", VA = "0x185BE8880")]
			public void INCPLIIJOKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5BE8BD0", Offset = "0x5BE79D0", VA = "0x185BE8BD0")]
			private void KOPDCOPPIOA([Optional] string CPBCFDOLGJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5BE8100", Offset = "0x5BE6F00", VA = "0x185BE8100")]
			private static string AGPGIFGCDKO(string GNLEHBFFNFG, string JLDFGFPAIIN)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5BEE300", Offset = "0x5BED100", VA = "0x185BEE300")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct DPMIBBIAKGA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int LDAPJEHFJGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public string MLOCMFANFAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public T AFHOFNJALHJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LJGLBNGJCBP : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private CCMEGKBIKJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
			[DebuggerHidden]
			public LJGLBNGJCBP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5BEBDD0", Offset = "0x5BEABD0", VA = "0x185BEBDD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5BEC590", Offset = "0x5BEB390", VA = "0x185BEC590", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class EENFCOOFIJA : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public PFGLJDAMMPM quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
			[DebuggerHidden]
			public EENFCOOFIJA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5BE74B0", Offset = "0x5BE62B0", VA = "0x185BE74B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5BE75C0", Offset = "0x5BE63C0", VA = "0x185BE75C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class NGIKMMFLOGL : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
			[DebuggerHidden]
			public NGIKMMFLOGL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5BECFD0", Offset = "0x5BEBDD0", VA = "0x185BECFD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5BED140", Offset = "0x5BEBF40", VA = "0x185BED140", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class LNJNDPNEMJO : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private CCMEGKBIKJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
			[DebuggerHidden]
			public LNJNDPNEMJO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5BEC5E0", Offset = "0x5BEB3E0", VA = "0x185BEC5E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5BEC860", Offset = "0x5BEB660", VA = "0x185BEC860", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class BDFAKLJAKJL : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private CCMEGKBIKJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
			[DebuggerHidden]
			public BDFAKLJAKJL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5BE6FE0", Offset = "0x5BE5DE0", VA = "0x185BE6FE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7270", Offset = "0x5BE6070", VA = "0x185BE7270", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class NPLFLABLCNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public HEJOFNDIPHL cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public NPLFLABLCNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5BED4F0", Offset = "0x5BEC2F0", VA = "0x185BED4F0")]
			internal void GCCFILDEPAL(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5BED810", Offset = "0x5BEC610", VA = "0x185BED810")]
			internal void KDAHFIOOLNI(DPMIBBIAKGA<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class GIMKILNJDMD : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private CCMEGKBIKJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public HEJOFNDIPHL cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private NPLFLABLCNO <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
			[DebuggerHidden]
			public GIMKILNJDMD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7610", Offset = "0x5BE6410", VA = "0x185BE7610", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7E60", Offset = "0x5BE6C60", VA = "0x185BE7E60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class LHKOPEGCBED<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public LHKOPEGCBED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x36A0E20", Offset = "0x369FC20", VA = "0x1836A0E20")]
			internal DPMIBBIAKGA<T> GHLHCGOHBEM(KGAOJBFCDMI postResponse)
			{
				return default(DPMIBBIAKGA<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class IPGFKGCGKCA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public IPGFKGCGKCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x36A0E20", Offset = "0x369FC20", VA = "0x1836A0E20")]
			internal DPMIBBIAKGA<T> PGDFAFFCOEE(KGAOJBFCDMI postResponse)
			{
				return default(DPMIBBIAKGA<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private AABBEAPGIEF CGNFIOACCMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<LEONCCEGHCF> LCNCEBJMEMB;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string KPADAMLCFGF = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string IGJBIBHPHOE = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string KIIAHACGFCD = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int NKHPCIBJBNA = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int EHKJHNPMDFL = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int AAPCCGJABCG = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float APCLKGJEAFL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long GAFOKNEANDN = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string CKFOEKPHEBH = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string ILJKEMLCJOA = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool AGEILKINKIB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool JAHIKLLOJNC;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int BJJKBMOMOEP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int MMOPHAEEPKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private MJKEHGICHHO NAOHKFLEOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private PMJNMLLFCJE MABPPPBBDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool IMILHBHJIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private float KDPBAIHNLLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float JFPGCLGOLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int KCPBJFEMACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int LHEAHHBKBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int? MNMFEDHJFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? FGABONCCHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private long FEDPOFMKNBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private string CKJMOFKEACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool CLFNEILFOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long LJFANKPKLHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string LELBDKFILPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string DIFPCCACNMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Dictionary<string, object> LMENLDCIBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private KPPBEKFHCPK KIMPLJKOEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int AFHCBLDEOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int ILAJHCBIPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private float MMDCGIKJMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool HLDKGANEHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool OIFFCIEGNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private HEJOFNDIPHL DOCKNGGMFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private HEJOFNDIPHL OJAFAGLHACM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private HEJOFNDIPHL KBPIAFMJLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> JNGFLAECCEF;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo ECJDOJOMEFP;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static string JCDNECHHGDP;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const string AIHLNIAHCFI = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string FCELFIKHHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string KNMCJOKJLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string KNIJJLBHHAO;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private AABBEAPGIEF BDHBHNOPDDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5BE11A0", Offset = "0x5BDFFA0", VA = "0x185BE11A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private LEONCCEGHCF BDCAMLAHCCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5BE3BF0", Offset = "0x5BE29F0", VA = "0x185BE3BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int JIOMMONCEEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5BE1580", Offset = "0x5BE0380", VA = "0x185BE1580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long OICBPMEPBMI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5BE5850", Offset = "0x5BE4650", VA = "0x185BE5850")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5BE5960", Offset = "0x5BE4760", VA = "0x185BE5960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string BDDDIJICHLK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5BE57F0", Offset = "0x5BE45F0", VA = "0x185BE57F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string JEBAMPJDIJI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5BE5820", Offset = "0x5BE4620", VA = "0x185BE5820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BJGKPAHMCMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE00", Offset = "0x7DAC00", VA = "0x1807DBE00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE10", Offset = "0x7DAC10", VA = "0x1807DBE10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? GCGJLAELNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8B4A80", Offset = "0x8B3880", VA = "0x1808B4A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x10C2740", Offset = "0x10C1540", VA = "0x1810C2740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AJHMOABILIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x93C380", Offset = "0x93B180", VA = "0x18093C380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xE66E20", Offset = "0xE65C20", VA = "0x180E66E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool KFDLCAIAJEB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5BE56F0", Offset = "0x5BE44F0", VA = "0x185BE56F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> NFHFDNJALHP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5BE5630", Offset = "0x5BE4430", VA = "0x185BE5630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5BE58A0", Offset = "0x5BE46A0", VA = "0x185BE58A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0000", Offset = "0x5BDEE00", VA = "0x185BE0000", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0900", Offset = "0x5BDF700", VA = "0x185BE0900")]
		private void DPKEEMKEBPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4C10", Offset = "0x5BE3A10", VA = "0x185BE4C10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3C40", Offset = "0x5BE2A40", VA = "0x185BE3C40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4FB0", Offset = "0x5BE3DB0", VA = "0x185BE4FB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3EB0", Offset = "0x5BE2CB0", VA = "0x185BE3EB0")]
		public KKKGKPAKNDP PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1EF0", Offset = "0x5BE0CF0", VA = "0x185BE1EF0")]
		[IteratorStateMachine(typeof(LJGLBNGJCBP))]
		public IEnumerator<CCMEGKBIKJP> Initialize(AmplitudeAnalyticsEvent LGCGPPGDBOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4EF0", Offset = "0x5BE3CF0", VA = "0x185BE4EF0")]
		public void UpdateLastKnownInteractionCategory(string HBNBGBFFPNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4E00", Offset = "0x5BE3C00", VA = "0x185BE4E00")]
		public void UpdateLastAliveTime(float MJMBAPAEFJB = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5BDFDD0", Offset = "0x5BDEBD0", VA = "0x185BDFDD0")]
		private KKKGKPAKNDP AOIFAOANDNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3900", Offset = "0x5BE2700", VA = "0x185BE3900")]
		private KKKGKPAKNDP NPFLEGOPKIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4660", Offset = "0x5BE3460", VA = "0x185BE4660")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0360", Offset = "0x5BDF160", VA = "0x185BE0360")]
		[IteratorStateMachine(typeof(EENFCOOFIJA))]
		private IEnumerator BJKIPEHNAEO(PFGLJDAMMPM OPKKOKHJHMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5BE5240", Offset = "0x5BE4040", VA = "0x185BE5240")]
		[IteratorStateMachine(typeof(NGIKMMFLOGL))]
		public IEnumerator WaitForFlush(float FFFIPJLIDCP = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4CE0", Offset = "0x5BE3AE0", VA = "0x185BE4CE0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4C20", Offset = "0x5BE3A20", VA = "0x185BE4C20")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime MGIGPHHIMPB)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1A60", Offset = "0x5BE0860", VA = "0x185BE1A60")]
		public static PEFKMPHKAOP Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5BDFE90", Offset = "0x5BDEC90", VA = "0x185BDFE90")]
		public static NHOGJHEAMCB AccountSelectionPostLoginEvent([NotNull] string BHJFCEAMAEP, string CNGNGPEJHIK, bool CEGEFBFEDHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0EA0", Offset = "0x5BDFCA0", VA = "0x185BE0EA0")]
		public static NHOGJHEAMCB Event([NotNull] string BHJFCEAMAEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3EF0", Offset = "0x5BE2CF0", VA = "0x185BE3EF0")]
		public static NHOGJHEAMCB PreviousSessionEvent([NotNull] string BHJFCEAMAEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1C10", Offset = "0x5BE0A10", VA = "0x185BE1C10")]
		public static NHOGJHEAMCB InitializeEvent(string CNGNGPEJHIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4820", Offset = "0x5BE3620", VA = "0x185BE4820")]
		public static NHOGJHEAMCB StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE03F0", Offset = "0x5BDF1F0", VA = "0x185BE03F0")]
		public static NHOGJHEAMCB CreateOutOfSessionEvent(string BHJFCEAMAEP, bool NPOIGHGLELG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3360", Offset = "0x5BE2160", VA = "0x185BE3360")]
		public static KKKGKPAKNDP LogOutOfSessionEvent(NHOGJHEAMCB EIKOLFNJNKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5BE30E0", Offset = "0x5BE1EE0", VA = "0x185BE30E0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent NKHCNFBGEEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3650", Offset = "0x5BE2450", VA = "0x185BE3650")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent NKHCNFBGEEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3790", Offset = "0x5BE2590", VA = "0x185BE3790")]
		public void LogSerializedEventAsync(Dictionary<string, object> GBBJBOGKOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3220", Offset = "0x5BE2020", VA = "0x185BE3220")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage MAKIIBGFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5BE13F0", Offset = "0x5BE01F0", VA = "0x185BE13F0")]
		private void FLFBMHLHIIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0650", Offset = "0x5BDF450", VA = "0x185BE0650")]
		private void DBLKFLMGHDA(Dictionary<string, object> EEMIJKOCPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1970", Offset = "0x5BE0770", VA = "0x185BE1970")]
		private void IIHIPJHLANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1220", Offset = "0x5BE0020", VA = "0x185BE1220")]
		private void FIDLLFJHHJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5BE14F0", Offset = "0x5BE02F0", VA = "0x185BE14F0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3870", Offset = "0x5BE2670", VA = "0x185BE3870")]
		[IteratorStateMachine(typeof(LNJNDPNEMJO))]
		private IEnumerator<CCMEGKBIKJP> MEBANIJDBGI(float FFFIPJLIDCP = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3050", Offset = "0x5BE1E50", VA = "0x185BE3050")]
		[IteratorStateMachine(typeof(BDFAKLJAKJL))]
		private IEnumerator<CCMEGKBIKJP> LOEDINGGLJB(float FFFIPJLIDCP = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1760", Offset = "0x5BE0560", VA = "0x185BE1760")]
		[IteratorStateMachine(typeof(GIMKILNJDMD))]
		private IEnumerator<CCMEGKBIKJP> GJOADCAABAM(HEJOFNDIPHL PCFHBLIBKPA, int? EIFPJCNOIJJ, string CEILGIOKLML, string KNGHNBHJHBG, float FFFIPJLIDCP, Action<int> IDFLJNJOOJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1860", Offset = "0x5BE0660", VA = "0x185BE1860")]
		private static void HBMGCLEOFHL(bool DCHDJLNMFBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE2F30", Offset = "0x5BE1D30", VA = "0x185BE2F30")]
		private BOOMHLJDOCA<DPMIBBIAKGA<Dictionary<string, object>>> LJOJOLKLBML(string CEILGIOKLML, string KNGHNBHJHBG, string AHOHOKEDONH, string MLBNKLOFGBO, Dictionary<string, object> AFHOFNJALHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE2C50", Offset = "0x5BE1A50", VA = "0x185BE2C50")]
		private BOOMHLJDOCA<DPMIBBIAKGA<List<Dictionary<string, object>>>> LJOJOLKLBML(string CEILGIOKLML, string KNGHNBHJHBG, string AHOHOKEDONH, string MLBNKLOFGBO, List<Dictionary<string, object>> AFHOFNJALHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x29D5090", Offset = "0x29D3E90", VA = "0x1829D5090")]
		private BOOMHLJDOCA<DPMIBBIAKGA<T>> NANMOMAAINJ<T>(string CEILGIOKLML, string KNGHNBHJHBG, string MLBNKLOFGBO, T AFHOFNJALHJ, Dictionary<string, object> OMMMJLHDFEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x29D5330", Offset = "0x29D4130", VA = "0x1829D5330")]
		private BOOMHLJDOCA<DPMIBBIAKGA<T>> OCNMBKLKJFO<T>(string CEILGIOKLML, string KNGHNBHJHBG, string AHOHOKEDONH, T AFHOFNJALHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3D00", Offset = "0x5BE2B00", VA = "0x185BE3D00")]
		private bool PHMGJMOCEJF(float DDFMCFEFMFD, float FFFIPJLIDCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1F80", Offset = "0x5BE0D80", VA = "0x185BE1F80")]
		private Dictionary<string, object> KIOELDJMHCO(string KNGHNBHJHBG, Dictionary<string, object> AFHOFNJALHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5BE5330", Offset = "0x5BE4130", VA = "0x185BE5330")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3D50", Offset = "0x5BE2B50", VA = "0x185BE3D50")]
		[CompilerGenerated]
		private long POEBDICEBGJ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1210", Offset = "0x5BE0010", VA = "0x185BE1210")]
		[CompilerGenerated]
		private void FDJAOMBBMEI(int KIIFLOHOEOL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly bool isBrazeUser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5BE66C0", Offset = "0x5BE54C0", VA = "0x185BE66C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5BE67A0", Offset = "0x5BE55A0", VA = "0x185BE67A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5BE6700", Offset = "0x5BE5500", VA = "0x185BE6700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5BE6800", Offset = "0x5BE5600", VA = "0x185BE6800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5BE6680", Offset = "0x5BE5480", VA = "0x185BE6680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5BE6740", Offset = "0x5BE5540", VA = "0x185BE6740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x766D10", Offset = "0x765B10", VA = "0x180766D10")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6160", Offset = "0x5BE4F60", VA = "0x185BE6160")]
		public static NHOGJHEAMCB HKJMJGOBNGA(string KCPGKFKLEJL, [NotNull] string FOMIHPGFJFH, long BGAGLBFDPDA, long MKNENDKMBJF, string CNGNGPEJHIK, bool CEGEFBFEDHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5BE5EF0", Offset = "0x5BE4CF0", VA = "0x185BE5EF0")]
		public static NHOGJHEAMCB FLLDFMMNMGC(string KCPGKFKLEJL, [NotNull] string FOMIHPGFJFH, long BGAGLBFDPDA, long MKNENDKMBJF, string CNGNGPEJHIK, long FFMFFEIDFMJ, bool CEGEFBFEDHN, string POOCNIGGLAA, string OCPFPOMELMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5BE64F0", Offset = "0x5BE52F0", VA = "0x185BE64F0")]
		private AmplitudeAnalyticsEvent(string KCPGKFKLEJL, [NotNull] string FOMIHPGFJFH, long BGAGLBFDPDA, long MKNENDKMBJF, string CNGNGPEJHIK, bool CEGEFBFEDHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x185C880", Offset = "0x185B680", VA = "0x18185C880")]
		public void CHNPDJBNGMJ(long LAFMBHKOLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6050", Offset = "0x5BE4E50", VA = "0x185BE6050", Slot = "5")]
		public override void GDEFGFHADPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6260", Offset = "0x5BE5060", VA = "0x185BE6260", Slot = "6")]
		public override void HPFEIHBNKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5BE59C0", Offset = "0x5BE47C0", VA = "0x185BE59C0", Slot = "4")]
		protected override Dictionary<string, object> BOHMPLEHBPK(Dictionary<string, object> PEKDGJKFEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5BE63E0", Offset = "0x5BE51E0", VA = "0x185BE63E0")]
		private void LEGCPOMHJDF(string JLDFGFPAIIN, string GNLEHBFFNFG, bool KMMIOGGNJKA = false)
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
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7330", Offset = "0x5BE6130", VA = "0x185BE7330")]
			public void JJMHOEKCAAJ(Dictionary<string, object> LPNJMHEJIFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5BEDF90", Offset = "0x5BECD90", VA = "0x185BEDF90")]
			public void JJMHOEKCAAJ(Dictionary<string, object> KLKAIHNNKAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7EFB40", Offset = "0x7EE940", VA = "0x1807EFB40")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x763960", Offset = "0x762760", VA = "0x180763960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6CA0", Offset = "0x5BE5AA0", VA = "0x185BE6CA0")]
		public static PEFKMPHKAOP HKJMJGOBNGA(string KCPGKFKLEJL, string CNGNGPEJHIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6F20", Offset = "0x5BE5D20", VA = "0x185BE6F20")]
		protected AmplitudeAnalyticsIdentifyMessage(string KCPGKFKLEJL, string CNGNGPEJHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6E90", Offset = "0x5BE5C90", VA = "0x185BE6E90")]
		public Dictionary<string, object> OHDNBGLLGEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5BE68D0", Offset = "0x5BE56D0", VA = "0x185BE68D0", Slot = "4")]
		protected virtual Dictionary<string, object> BOHMPLEHBPK(Dictionary<string, object> PEKDGJKFEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6DF0", Offset = "0x5BE5BF0", VA = "0x185BE6DF0")]
		protected void LPGFMGOAGPB(string JLDFGFPAIIN, Dictionary<string, object> CKMKJKOBPPB, Dictionary<string, object> NPLGOFAFJOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6860", Offset = "0x5BE5660", VA = "0x185BE6860")]
		protected void BHACALBMOFF(string JLDFGFPAIIN, string GNLEHBFFNFG, Dictionary<string, object> CFOFAPIPCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6C10", Offset = "0x5BE5A10", VA = "0x185BE6C10", Slot = "5")]
		public virtual void GDEFGFHADPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6D60", Offset = "0x5BE5B60", VA = "0x185BE6D60", Slot = "6")]
		public virtual void HPFEIHBNKKH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PEFKMPHKAOP : NKDHMALNOAD<AmplitudeAnalyticsIdentifyMessage, PEFKMPHKAOP>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override PEFKMPHKAOP GCAOAPJIFII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage AOABMEOBIPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5BEDF40", Offset = "0x5BECD40", VA = "0x185BEDF40")]
	public PEFKMPHKAOP(AmplitudeAnalyticsIdentifyMessage JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5BEDE90", Offset = "0x5BECC90", VA = "0x185BEDE90", Slot = "4")]
	public override void HPFEIHBNKKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NHOGJHEAMCB : NKDHMALNOAD<AmplitudeAnalyticsEvent, NHOGJHEAMCB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool MGKFINFOPOO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override NHOGJHEAMCB GCAOAPJIFII
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long AKGIDBJBKHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E880", Offset = "0x1C1D680", VA = "0x181C1E880")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5BECA60", Offset = "0x5BEB860", VA = "0x185BECA60")]
	public NHOGJHEAMCB(AmplitudeAnalyticsEvent JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "5")]
	public override AmplitudeAnalyticsEvent AOABMEOBIPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5BED230", Offset = "0x5BEC030", VA = "0x185BED230", Slot = "4")]
	public override void HPFEIHBNKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x24D07D0", Offset = "0x24CF5D0", VA = "0x1824D07D0")]
	public NHOGJHEAMCB LNHIJBBGJIJ<T>(string GGCGADADFCH, T[] GNLEHBFFNFG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x24D07D0", Offset = "0x24CF5D0", VA = "0x1824D07D0")]
	public NHOGJHEAMCB LNHIJBBGJIJ(string GGCGADADFCH, string[] GNLEHBFFNFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x24D0520", Offset = "0x24CF320", VA = "0x1824D0520")]
	public NHOGJHEAMCB LNHIJBBGJIJ<T>(string GGCGADADFCH, T GNLEHBFFNFG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5BED470", Offset = "0x5BEC270", VA = "0x185BED470")]
	public NHOGJHEAMCB LNHIJBBGJIJ(string GGCGADADFCH, long GNLEHBFFNFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5BED400", Offset = "0x5BEC200", VA = "0x185BED400")]
	public NHOGJHEAMCB LNHIJBBGJIJ(string GGCGADADFCH, string GNLEHBFFNFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5BED2D0", Offset = "0x5BEC0D0", VA = "0x185BED2D0")]
	public NHOGJHEAMCB JJHPPECMFGE(string GGCGADADFCH, object? GNLEHBFFNFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5BED190", Offset = "0x5BEBF90", VA = "0x185BED190")]
	public NHOGJHEAMCB BJAHAGJEHMN(string GGCGADADFCH, string GNLEHBFFNFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5BED300", Offset = "0x5BEC100", VA = "0x185BED300")]
	private NHOGJHEAMCB KNEGBAJKOKA(string GGCGADADFCH, object GNLEHBFFNFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MEJHKEOOBNO : NHOGJHEAMCB
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5BECA60", Offset = "0x5BEB860", VA = "0x185BECA60")]
	public MEJHKEOOBNO(AmplitudeAnalyticsEvent JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC8B0", Offset = "0x5BEB6B0", VA = "0x185BEC8B0", Slot = "4")]
	public override void HPFEIHBNKKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class NKDHMALNOAD<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : NKDHMALNOAD<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	protected M JIGBFCEILIK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR GCAOAPJIFII
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	public NKDHMALNOAD(M JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3BE0CB0", Offset = "0x3BDFAB0", VA = "0x183BE0CB0")]
	public BLDR KJECPDONKDK(AmplitudeAnalyticsIdentifyMessage.DeviceInfo BAJPJBJFGOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3BE0D00", Offset = "0x3BDFB00", VA = "0x183BE0D00")]
	public BLDR MDIMAPJGCPG(AmplitudeAnalyticsIdentifyMessage.RevenueData LBPJNFLHHIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3BE0B00", Offset = "0x3BDF900", VA = "0x183BE0B00")]
	public BLDR AAOCNGHGMNO(string GGCGADADFCH, string GNLEHBFFNFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2290360", Offset = "0x228F160", VA = "0x182290360")]
	public BLDR AAOCNGHGMNO<T>(string GGCGADADFCH, T GNLEHBFFNFG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void HPFEIHBNKKH();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3BE0B80", Offset = "0x3BDF980", VA = "0x183BE0B80")]
	internal static string AIMNMKHPLIE(string GNLEHBFFNFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BE0BB0", Offset = "0x3BDF9B0", VA = "0x183BE0BB0")]
	private BLDR BNNHGHHNEFL(string GGCGADADFCH, object GNLEHBFFNFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M AOABMEOBIPJ();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ODCJOOGHIOH
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> PJLCPLLAPPE;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5BEDCE0", Offset = "0x5BECAE0", VA = "0x185BEDCE0")]
	internal static bool JPIOFCFEBEH(string JLDFGFPAIIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MJKEHGICHHO
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool IOCDANBDDKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string DLLHICCFACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	string IFNAJMAAHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	string OFPJENIIIML
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	string ADIOOFCHFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BOOMHLJDOCA<KGAOJBFCDMI> LJOJOLKLBML(string CEILGIOKLML, Dictionary<string, string> LBIENKCFFDF, bool OFDOKEKOJDD = false);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BOOMHLJDOCA<KGAOJBFCDMI> CDKDGLLINLP(string CEILGIOKLML, string PKAHNENKNBF, string MNBBIDHAHPL, string LHCIEBDJFPD);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct KGAOJBFCDMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly int LGDMCEGECPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly string DCNMIPNMMPD;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0xAB0130", Offset = "0xAAEF30", VA = "0x180AB0130")]
	public KGAOJBFCDMI(int LDAPJEHFJGP, string MLOCMFANFAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum GFDDABGPING
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	GameInvite
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NEAAPHODGJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private long ACINFCDPPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private NHOGJHEAMCB EGPDFHPABOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool AIDJHFOFHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private float KAKOMBAIBMA;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5BECE40", Offset = "0x5BEBC40", VA = "0x185BECE40")]
	public NEAAPHODGJM(string HPFOMCALINM, float KAKOMBAIBMA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x24CE590", Offset = "0x24CD390", VA = "0x1824CE590")]
	public void LNHIJBBGJIJ<T>(string GGCGADADFCH, T GNLEHBFFNFG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5BECD70", Offset = "0x5BEBB70", VA = "0x185BECD70")]
	public void LNHIJBBGJIJ(string GGCGADADFCH, string GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5BECAB0", Offset = "0x5BEB8B0", VA = "0x185BECAB0")]
	public void EFMLGIIDCII(string PIIFLCMBBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5BECCB0", Offset = "0x5BEBAB0", VA = "0x185BECCB0")]
	public void FNFAKKBLJBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5BECBA0", Offset = "0x5BEB9A0", VA = "0x185BECBA0")]
	private void FBGOGGEDBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5BECDF0", Offset = "0x5BEBBF0", VA = "0x185BECDF0")]
	private bool NDPDEOHFNIA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MKKKCKMGIGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool KADIPLBDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string BJGKPAHMCMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ACKAOMOIEPO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MBNIIALODAD;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KKKGKPAKNDP OOCIGOIJKNJ(string PFKKELKGHCF, string ONLMOCLKOOC, [Optional] PMJNMLLFCJE CANKJFPDOBL);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KKKGKPAKNDP OJOHKNPNNGE(PMJNMLLFCJE CANKJFPDOBL);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KKKGKPAKNDP CLGJJGFNCFK(PMJNMLLFCJE CANKJFPDOBL, Dictionary<string, string> NNKPKAKEDAG);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NMNMLBCBMAH(string OBMAOFPNDKC);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PKCOCIDEPBP ENOCEEOHHHL(string JGLBGLELGCD);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PADIJOLGDOH AIBHAINOPBI(string IIKHOPJHKPP);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KKKGKPAKNDP MPNANLJHGON();
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5BEE100", Offset = "0x5BECF00", VA = "0x185BEE100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JOCCOPFABHN : MKKKCKMGIGJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly IReadOnlyDictionary<string, FDOJCBEPGPN> LDCMCHOALDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool LJIAGLFCFBO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KADIPLBDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B46A0", Offset = "0x7B34A0", VA = "0x1807B46A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string BJGKPAHMCMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA330", Offset = "0x5BE9130", VA = "0x185BEA330", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action ACKAOMOIEPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9F80", Offset = "0x5BE8D80", VA = "0x185BE9F80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9D30", Offset = "0x5BE8B30", VA = "0x185BE9D30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action MBNIIALODAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA460", Offset = "0x5BE9260", VA = "0x185BEA460", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA3C0", Offset = "0x5BE91C0", VA = "0x185BEA3C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA950", Offset = "0x5BE9750", VA = "0x185BEA950", Slot = "8")]
	public KKKGKPAKNDP OOCIGOIJKNJ(string PFKKELKGHCF, string ONLMOCLKOOC, [Optional] PMJNMLLFCJE CANKJFPDOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA500", Offset = "0x5BE9300", VA = "0x185BEA500", Slot = "16")]
	public KKKGKPAKNDP MPNANLJHGON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA760", Offset = "0x5BE9560", VA = "0x185BEA760", Slot = "11")]
	public KKKGKPAKNDP OJOHKNPNNGE(PMJNMLLFCJE CANKJFPDOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9A60", Offset = "0x5BE8860", VA = "0x185BE9A60", Slot = "12")]
	public KKKGKPAKNDP CLGJJGFNCFK(PMJNMLLFCJE CANKJFPDOBL, Dictionary<string, string> NNKPKAKEDAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA6D0", Offset = "0x5BE94D0", VA = "0x185BEA6D0", Slot = "13")]
	public bool NMNMLBCBMAH(string OBMAOFPNDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA020", Offset = "0x5BE8E20", VA = "0x185BEA020", Slot = "14")]
	public PKCOCIDEPBP ENOCEEOHHHL(string JGLBGLELGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9300", Offset = "0x5BE8100", VA = "0x185BE9300", Slot = "15")]
	public PADIJOLGDOH AIBHAINOPBI(string IIKHOPJHKPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9390", Offset = "0x5BE8190", VA = "0x185BE9390")]
	private PKLADBIPCFJ CJJKEOKJMEE(PMJNMLLFCJE CANKJFPDOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9DD0", Offset = "0x5BE8BD0", VA = "0x185BE9DD0")]
	private NHNBBLPCKNO DHHJEMCFFKO(string ONLMOCLKOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA220", Offset = "0x5BE9020", VA = "0x185BEA220")]
	private void GAHACCAAFFI(string JGLBGLELGCD, PKCOCIDEPBP OMPKHLFKKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public JOCCOPFABHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0xA3D480", Offset = "0xA3C280", VA = "0x180A3D480")]
	[CompilerGenerated]
	private void MBDBPJFLAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA340", Offset = "0x5BE9140", VA = "0x185BEA340")]
	[CompilerGenerated]
	private void KEDGJCIIGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA650", Offset = "0x5BE9450", VA = "0x185BEA650")]
	[CompilerGenerated]
	private void NLFHJLCIBFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KLHJJDLONCC : MKKKCKMGIGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private MKKKCKMGIGJ KPNBGEKHDCH;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private MKKKCKMGIGJ MHHFPBGCKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB380", Offset = "0x5BEA180", VA = "0x185BEB380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KADIPLBDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB440", Offset = "0x5BEA240", VA = "0x185BEB440", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string BJGKPAHMCMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB3F0", Offset = "0x5BEA1F0", VA = "0x185BEB3F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action ACKAOMOIEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB1D0", Offset = "0x5BE9FD0", VA = "0x185BEB1D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB130", Offset = "0x5BE9F30", VA = "0x185BEB130", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action MBNIIALODAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB5A0", Offset = "0x5BEA3A0", VA = "0x185BEB5A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB500", Offset = "0x5BEA300", VA = "0x185BEB500", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	[UnityEngine.Scripting.Preserve]
	public KLHJJDLONCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB490", Offset = "0x5BEA290", VA = "0x185BEB490")]
	[GAPOPKHLLNB(OGJCEJIMIKL.GameOnly)]
	private static void LPIADHCPHKP(OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB750", Offset = "0x5BEA550", VA = "0x185BEB750")]
	[GAPOPKHLLNB(OGJCEJIMIKL.EditorOnly)]
	private static void NGFAIJBOGAC(OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB980", Offset = "0x5BEA780", VA = "0x185BEB980", Slot = "8")]
	public KKKGKPAKNDP OOCIGOIJKNJ(string PFKKELKGHCF, string ONLMOCLKOOC, [Optional] PMJNMLLFCJE CANKJFPDOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB870", Offset = "0x5BEA670", VA = "0x185BEB870", Slot = "11")]
	public KKKGKPAKNDP OJOHKNPNNGE(PMJNMLLFCJE CANKJFPDOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB010", Offset = "0x5BE9E10", VA = "0x185BEB010", Slot = "12")]
	public KKKGKPAKNDP CLGJJGFNCFK(PMJNMLLFCJE CANKJFPDOBL, Dictionary<string, string> NNKPKAKEDAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB7C0", Offset = "0x5BEA5C0", VA = "0x185BEB7C0", Slot = "13")]
	public bool NMNMLBCBMAH(string OBMAOFPNDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB270", Offset = "0x5BEA070", VA = "0x185BEB270", Slot = "14")]
	public PKCOCIDEPBP ENOCEEOHHHL(string JGLBGLELGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5BEAF00", Offset = "0x5BE9D00", VA = "0x185BEAF00", Slot = "15")]
	public PADIJOLGDOH AIBHAINOPBI(string IIKHOPJHKPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB640", Offset = "0x5BEA440", VA = "0x185BEB640", Slot = "16")]
	public KKKGKPAKNDP MPNANLJHGON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7AF370", Offset = "0x7AE170", VA = "0x1807AF370")]
	[CompilerGenerated]
	private void MOGMNGPBBAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xADBCA0", Offset = "0xADAAA0", VA = "0x180ADBCA0")]
	[CompilerGenerated]
	private void DDABEFJNPLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class AKNKDOGIAFG : MKKKCKMGIGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KADIPLBDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string BJGKPAHMCMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action ACKAOMOIEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5BDFA30", Offset = "0x5BDE830", VA = "0x185BDFA30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5BDF990", Offset = "0x5BDE790", VA = "0x185BDF990", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action MBNIIALODAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5BDFB80", Offset = "0x5BDE980", VA = "0x185BDFB80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5BDFAE0", Offset = "0x5BDE8E0", VA = "0x185BDFAE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public AKNKDOGIAFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5BDFD40", Offset = "0x5BDEB40", VA = "0x185BDFD40", Slot = "8")]
	public KKKGKPAKNDP OOCIGOIJKNJ(string PFKKELKGHCF, string ONLMOCLKOOC, [Optional] PMJNMLLFCJE CANKJFPDOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5BDFCB0", Offset = "0x5BDEAB0", VA = "0x185BDFCB0", Slot = "11")]
	public KKKGKPAKNDP OJOHKNPNNGE(PMJNMLLFCJE CANKJFPDOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5BDF900", Offset = "0x5BDE700", VA = "0x185BDF900", Slot = "12")]
	public KKKGKPAKNDP CLGJJGFNCFK(PMJNMLLFCJE CANKJFPDOBL, Dictionary<string, string> NNKPKAKEDAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
	public bool NMNMLBCBMAH(string OBMAOFPNDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5BDFAD0", Offset = "0x5BDE8D0", VA = "0x185BDFAD0", Slot = "14")]
	public PKCOCIDEPBP ENOCEEOHHHL(string JGLBGLELGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5BDF8F0", Offset = "0x5BDE6F0", VA = "0x185BDF8F0", Slot = "15")]
	public PADIJOLGDOH AIBHAINOPBI(string IIKHOPJHKPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5BDFC20", Offset = "0x5BDEA20", VA = "0x185BDFC20", Slot = "16")]
	public KKKGKPAKNDP MPNANLJHGON()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface OECLHBBCONL
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NEAAPHODGJM NFDHMLJFMHI(string HPFOMCALINM);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface EKDFBEOOCOL
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	long FPINOAGJGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long BCNMOEGBDFC();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMFKABJFDDA(long BGAGLBFDPDA, bool KMMIOGGNJKA = true);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EIELHFFOONF(string GMNCNEPJHHN, string IPPCMDLCJLO, string FOAKNKECGPI);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OIAGAGMIDHC(string GMNCNEPJHHN);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BABFGJKMCCI(string GMNCNEPJHHN, string EAICKOPLOLF, string JBEHMDAEHDD);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NIBFIJJJODB(string JFGIJEKPOBI, object NNFCNPHOIIH, object OFOMEMMPKIK);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface PMJNMLLFCJE
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool FDNCBGANMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool LMPBBAJOLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool EMGOOCHCOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool? GFBFDHLLAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	int? GCGJLAELNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	int GGOJPFFLNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string FPMDKMHBLEE
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string BKBIGNOGGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string ABOEPPLALNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	long OAJPFJIBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string ODDFABBALHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string EDACGHFGPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string HMMPCOEDHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string EJDPNIELOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	double MHLBCIONBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	int DHIBGALOAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
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
