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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5F97890", Offset = "0x5F96690", VA = "0x185F97890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E4430", Offset = "0x7E3230", VA = "0x1807E4430")]
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
		public AmplitudeAnalyticsClient.Settings GPOAMOBFMJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HGIGMDHNKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7BE950", Offset = "0x7BD750", VA = "0x1807BE950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum KGGIGCAFBCC
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class EKOJNMMLLIC
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class PPAMPHBEBMN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int MPGHJHBDOKJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> EGIGPBBOJDM;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
				public PPAMPHBEBMN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class ODEOEFOMFAE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
				public ODEOEFOMFAE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5F97910", Offset = "0x5F96710", VA = "0x185F97910")]
				internal bool KJLFNLPKGOE(PPAMPHBEBMN item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string IDMAGBGMKCP = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string NOCEOCEDPNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<PPAMPHBEBMN> CFKODLOJMGF;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? MLKALKGOBAF
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5F90B80", Offset = "0x5F8F980", VA = "0x185F90B80")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5F914D0", Offset = "0x5F902D0", VA = "0x185F914D0")]
			internal EKOJNMMLLIC(string JPONGHMCNGB, string DBFIJLJAMAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5F909D0", Offset = "0x5F8F7D0", VA = "0x185F909D0")]
			public int KAGNALPMKEN([Optional] int? GCLDBHMLKLH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5F91260", Offset = "0x5F90060", VA = "0x185F91260")]
			public List<Dictionary<string, object>> PJPIICLFBDI(int DAHDMDMPPPN, int? GCLDBHMLKLH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5F910B0", Offset = "0x5F8FEB0", VA = "0x185F910B0")]
			public void OFNHMIFPGDJ(AmplitudeAnalyticsIdentifyMessage KDHDNCADFDJ, bool KDJBFHOKCEK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5F91150", Offset = "0x5F8FF50", VA = "0x185F91150")]
			public void OFNHMIFPGDJ(Dictionary<string, object> KDHDNCADFDJ, bool KDJBFHOKCEK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5F90600", Offset = "0x5F8F400", VA = "0x185F90600")]
			public void HGODDMFIBEC(params Dictionary<string, object>[] KBOPFNPIDJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5F90C20", Offset = "0x5F8FA20", VA = "0x185F90C20")]
			public void LNKKLCJOCJJ(List<Dictionary<string, object>> AKDBMCLEKGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5F908C0", Offset = "0x5F8F6C0", VA = "0x185F908C0")]
			private void IFEEGHGJNII(Dictionary<string, object> KDHDNCADFDJ, bool KDJBFHOKCEK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5F90E70", Offset = "0x5F8FC70", VA = "0x185F90E70")]
			public void NEIKAANLONL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5F90210", Offset = "0x5F8F010", VA = "0x185F90210")]
			private void DPBBCBADHAN([Optional] string GMJEAPBKHFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5F90790", Offset = "0x5F8F590", VA = "0x185F90790")]
			private static string HKJKBNCDHPA(string MAEBFBHFPDE, string ONOECNHBCDA)
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
			[Cpp2IlInjected.Address(RVA = "0x5F98370", Offset = "0x5F97170", VA = "0x185F98370")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct PDCKANCDJGA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int JKBFAPPGFNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string KECHNMECDLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T ANLPELJPDKG;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BIFOJFBDNPN : IEnumerator<CPLKNCELBEK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private CPLKNCELBEK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private CPLKNCELBEK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
			[DebuggerHidden]
			public BIFOJFBDNPN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5F8F450", Offset = "0x5F8E250", VA = "0x185F8F450", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5F8FC10", Offset = "0x5F8EA10", VA = "0x185F8FC10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class OHKPFNNKKFK : IEnumerator<object>, IEnumerator, IDisposable
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
			public CBFGLDINGCH quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
			[DebuggerHidden]
			public OHKPFNNKKFK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5F97980", Offset = "0x5F96780", VA = "0x185F97980", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5F97A90", Offset = "0x5F96890", VA = "0x185F97A90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JOKJCIPLDMA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
			[DebuggerHidden]
			public JOKJCIPLDMA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5F951E0", Offset = "0x5F93FE0", VA = "0x185F951E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5F95350", Offset = "0x5F94150", VA = "0x185F95350", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class AHAHBLAOFJC : IEnumerator<CPLKNCELBEK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private CPLKNCELBEK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private CPLKNCELBEK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
			[DebuggerHidden]
			public AHAHBLAOFJC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5F87840", Offset = "0x5F86640", VA = "0x185F87840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5F87AC0", Offset = "0x5F868C0", VA = "0x185F87AC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class NNBNGHJLCMG : IEnumerator<CPLKNCELBEK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private CPLKNCELBEK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private CPLKNCELBEK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
			[DebuggerHidden]
			public NNBNGHJLCMG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5F975B0", Offset = "0x5F963B0", VA = "0x185F975B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5F97840", Offset = "0x5F96640", VA = "0x185F97840", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class HFIHCCKJFDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public EKOJNMMLLIC cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public HFIHCCKJFDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5F94970", Offset = "0x5F93770", VA = "0x185F94970")]
			internal void CMBEALNNNGE(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5F94C90", Offset = "0x5F93A90", VA = "0x185F94C90")]
			internal void PIBMBIPNCJN(PDCKANCDJGA<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ABEBCBCBJHE : IEnumerator<CPLKNCELBEK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private CPLKNCELBEK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public EKOJNMMLLIC cache;

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
			private HFIHCCKJFDM <>8__1;

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
			private CPLKNCELBEK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
			[DebuggerHidden]
			public ABEBCBCBJHE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5F86F40", Offset = "0x5F85D40", VA = "0x185F86F40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5F877F0", Offset = "0x5F865F0", VA = "0x185F877F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class CAHACNFOCGO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public CAHACNFOCGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3B8A770", Offset = "0x3B89570", VA = "0x183B8A770")]
			internal PDCKANCDJGA<T> MHHDMDFAKOA(POBIJKICCPD postResponse)
			{
				return default(PDCKANCDJGA<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class KONDCOJECGF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public KONDCOJECGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3B8A770", Offset = "0x3B89570", VA = "0x183B8A770")]
			internal PDCKANCDJGA<T> JLKAMFOKGOD(POBIJKICCPD postResponse)
			{
				return default(PDCKANCDJGA<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private IBOIAOAEBDB HKNNCCFIKEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<EHDMOCFPOAK> CNBKOAPIOHJ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string DKCLLBAEHEP = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string JEGPMNKJAFF = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string FOONPEKHICB = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int HDIOEPLMFON = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int KDAKLLFKKIA = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int JELPIGJCOCD = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float FFMNLEIGKLB = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long AKANKMJNCCK = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string KEDENBIPDGA = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string KNHFLKKNAGE = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool GNBFLGPLEIB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool NGPFGIAKNJL;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int BDCBFJFOMCO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int MDKCABKHLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private GLDKALFDIFA EFOPLLFOHLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private DAALDLLGEDP MEFDGPMGNJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private OAGIIBPPBNM FFEPAFKMKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool IBAMMABPFOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float JFGEDKCDDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float EEFEBGBBKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int DNNCOPLGDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int NIDBEBLPADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? LFKMJIGLOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? EDDIGAFOGEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long GJPAIABAIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string JDGMFGOMBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool OHDHLCBFOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long GCIFKFEEILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string ANDDPBICKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string GAANEADNCMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> FEHPPOBNGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private KGGIGCAFBCC FPAENBIDPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int PJONMJAHJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int JGACAJDGCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float ONOOPGNDKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool PAKDCJHHAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool KIFOBPHDGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private EKOJNMMLLIC PIAPFCCHLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private EKOJNMMLLIC LKNFGAHHEBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private EKOJNMMLLIC GMNPEEPBMOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> KBLLCCMNLFO;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo IFDLAEKNGMK;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string BLKPGFOIFCA;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string NGNOJKLIKFB = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string BOLCLGDDLBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string OBHCIFJBNJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string DCCFAKDCLPF;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private IBOIAOAEBDB EOPFBBFOJLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5F8AF80", Offset = "0x5F89D80", VA = "0x185F8AF80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private EHDMOCFPOAK PPGNDLOEMAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5F8A540", Offset = "0x5F89340", VA = "0x185F8A540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int GGJHEOAJAMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5F8BA70", Offset = "0x5F8A870", VA = "0x185F8BA70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long JKNFFPAGKGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5F8DCB0", Offset = "0x5F8CAB0", VA = "0x185F8DCB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5F8DDD0", Offset = "0x5F8CBD0", VA = "0x185F8DDD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string KFJDABIOMDC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5F8DC50", Offset = "0x5F8CA50", VA = "0x185F8DC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string CEHAFDIKILI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5F8DC80", Offset = "0x5F8CA80", VA = "0x185F8DC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string KFDAALDBNOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8C41D0", Offset = "0x8C2FD0", VA = "0x1808C41D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8C41E0", Offset = "0x8C2FE0", VA = "0x1808C41E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? OJAJPPIFBBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8E65B0", Offset = "0x8E53B0", VA = "0x1808E65B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5F8DDC0", Offset = "0x5F8CBC0", VA = "0x185F8DDC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LGNMLCCCHAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xFA3610", Offset = "0xFA2410", VA = "0x180FA3610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xFA2AC0", Offset = "0xFA18C0", VA = "0x180FA2AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool MEHMFDOGELL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5F8DB50", Offset = "0x5F8C950", VA = "0x185F8DB50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> KNBBCLEJMKN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5F8DA90", Offset = "0x5F8C890", VA = "0x185F8DA90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5F8DD00", Offset = "0x5F8CB00", VA = "0x185F8DD00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5F882D0", Offset = "0x5F870D0", VA = "0x185F882D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5F89DC0", Offset = "0x5F88BC0", VA = "0x185F89DC0")]
		private void FFILPLHLNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D070", Offset = "0x5F8BE70", VA = "0x185F8D070")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5F8C060", Offset = "0x5F8AE60", VA = "0x185F8C060", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D410", Offset = "0x5F8C210", VA = "0x185F8D410")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5F8C310", Offset = "0x5F8B110", VA = "0x185F8C310")]
		public NGBPOFNIFPL PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5F8AA20", Offset = "0x5F89820", VA = "0x185F8AA20")]
		[IteratorStateMachine(typeof(BIFOJFBDNPN))]
		public IEnumerator<CPLKNCELBEK> Initialize(AmplitudeAnalyticsEvent OKCAJOEMAOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D350", Offset = "0x5F8C150", VA = "0x185F8D350")]
		public void UpdateLastKnownInteractionCategory(string MHDNPPGEDFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D260", Offset = "0x5F8C060", VA = "0x185F8D260")]
		public void UpdateLastAliveTime(float LDLIGJLNGPH = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5F8A480", Offset = "0x5F89280", VA = "0x185F8A480")]
		private NGBPOFNIFPL HGIDLNOGCLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5F8AFF0", Offset = "0x5F89DF0", VA = "0x185F8AFF0")]
		private NGBPOFNIFPL LFDPKDABGPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5F8CAC0", Offset = "0x5F8B8C0", VA = "0x185F8CAC0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5F8AC20", Offset = "0x5F89A20", VA = "0x185F8AC20")]
		[IteratorStateMachine(typeof(OHKPFNNKKFK))]
		private IEnumerator JNGLPDINGFM(CBFGLDINGCH MCJIJKDOHKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D6A0", Offset = "0x5F8C4A0", VA = "0x185F8D6A0")]
		[IteratorStateMachine(typeof(JOKJCIPLDMA))]
		public IEnumerator WaitForFlush(float BPIIOFNDDAL = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D140", Offset = "0x5F8BF40", VA = "0x185F8D140")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D080", Offset = "0x5F8BE80", VA = "0x185F8D080")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime EHBJJHHNHHF)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5F8A590", Offset = "0x5F89390", VA = "0x185F8A590")]
		public static JNKNCHEGABM Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5F88160", Offset = "0x5F86F60", VA = "0x185F88160")]
		public static LCPCLNHECBF AccountSelectionPostLoginEvent([NotNull] string GENDNJKHCLA, string ALDHKAEGBEL, bool OHPFIFFJLOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F899B0", Offset = "0x5F887B0", VA = "0x185F899B0")]
		public static LCPCLNHECBF Event([NotNull] string GENDNJKHCLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F8C350", Offset = "0x5F8B150", VA = "0x185F8C350")]
		public static LCPCLNHECBF PreviousSessionEvent([NotNull] string GENDNJKHCLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5F8A740", Offset = "0x5F89540", VA = "0x185F8A740")]
		public static LCPCLNHECBF InitializeEvent(string ALDHKAEGBEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5F8CC80", Offset = "0x5F8BA80", VA = "0x185F8CC80")]
		public static LCPCLNHECBF StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5F894A0", Offset = "0x5F882A0", VA = "0x185F894A0")]
		public static LCPCLNHECBF CreateOutOfSessionEvent(string GENDNJKHCLA, bool BAADLDFHCMC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5F8B560", Offset = "0x5F8A360", VA = "0x185F8B560")]
		public static NGBPOFNIFPL LogOutOfSessionEvent(LCPCLNHECBF PMKPMKOGKGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5F8B2E0", Offset = "0x5F8A0E0", VA = "0x185F8B2E0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent MHJEIHGCEFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5F8B850", Offset = "0x5F8A650", VA = "0x185F8B850")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent MHJEIHGCEFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5F8B990", Offset = "0x5F8A790", VA = "0x185F8B990")]
		public void LogSerializedEventAsync(Dictionary<string, object> HONDPJJNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5F8B420", Offset = "0x5F8A220", VA = "0x185F8B420")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage FOCBIMDJNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5F8C120", Offset = "0x5F8AF20", VA = "0x185F8C120")]
		private void PCCAHEHJNCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5F89700", Offset = "0x5F88500", VA = "0x185F89700")]
		private void DCGIMEFHJNG(Dictionary<string, object> CBDKIBLJFBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5F8C220", Offset = "0x5F8B020", VA = "0x185F8C220")]
		private void PCNANNHCLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5F8ADB0", Offset = "0x5F89BB0", VA = "0x185F8ADB0")]
		private void KNBEIAMIPJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5F8A360", Offset = "0x5F89160", VA = "0x185F8A360")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5F88740", Offset = "0x5F87540", VA = "0x185F88740")]
		[IteratorStateMachine(typeof(AHAHBLAOFJC))]
		private IEnumerator<CPLKNCELBEK> BCJCBGHPLGJ(float BPIIOFNDDAL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5F8A3F0", Offset = "0x5F891F0", VA = "0x185F8A3F0")]
		[IteratorStateMachine(typeof(NNBNGHJLCMG))]
		private IEnumerator<CPLKNCELBEK> GIFINPILIMD(float BPIIOFNDDAL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5F8ACB0", Offset = "0x5F89AB0", VA = "0x185F8ACB0")]
		[IteratorStateMachine(typeof(ABEBCBCBJHE))]
		private IEnumerator<CPLKNCELBEK> KFAAGNCJLJP(EKOJNMMLLIC AJGMHAKKLJA, int? GCLDBHMLKLH, string OKDOBPLFPCO, string IKNPKIGFLCI, float BPIIOFNDDAL, Action<int> CNNFFGANNHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5F89CB0", Offset = "0x5F88AB0", VA = "0x185F89CB0")]
		private static void FDBEFMPAPLC(bool JCLDEEGPAJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5F8BC50", Offset = "0x5F8AA50", VA = "0x185F8BC50")]
		private IEONLNEHMOD<PDCKANCDJGA<Dictionary<string, object>>> NEEFHEMKJOH(string OKDOBPLFPCO, string IKNPKIGFLCI, string IFHNNFCANNN, string KLLPDPEAFAK, Dictionary<string, object> ANLPELJPDKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5F8BD80", Offset = "0x5F8AB80", VA = "0x185F8BD80")]
		private IEONLNEHMOD<PDCKANCDJGA<List<Dictionary<string, object>>>> NEEFHEMKJOH(string OKDOBPLFPCO, string IKNPKIGFLCI, string IFHNNFCANNN, string KLLPDPEAFAK, List<Dictionary<string, object>> ANLPELJPDKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2D2EE30", Offset = "0x2D2DC30", VA = "0x182D2EE30")]
		private IEONLNEHMOD<PDCKANCDJGA<T>> ILJHCFBNCHI<T>(string OKDOBPLFPCO, string IKNPKIGFLCI, string KLLPDPEAFAK, T ANLPELJPDKG, Dictionary<string, object> FHOELEKLCLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F0F0", Offset = "0x2D2DEF0", VA = "0x182D2F0F0")]
		private IEONLNEHMOD<PDCKANCDJGA<T>> PPHAJPGLGDB<T>(string OKDOBPLFPCO, string IKNPKIGFLCI, string IFHNNFCANNN, T ANLPELJPDKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5F88110", Offset = "0x5F86F10", VA = "0x185F88110")]
		private bool AAAJDHNNLGP(float EOBOIBODBAD, float BPIIOFNDDAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5F887D0", Offset = "0x5F875D0", VA = "0x185F887D0")]
		private Dictionary<string, object> BOFNJCCKMGA(string IKNPKIGFLCI, Dictionary<string, object> ANLPELJPDKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D790", Offset = "0x5F8C590", VA = "0x185F8D790")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5F8AAC0", Offset = "0x5F898C0", VA = "0x185F8AAC0")]
		[CompilerGenerated]
		private long JJNLLPOLOEF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5F8AAB0", Offset = "0x5F898B0", VA = "0x185F8AAB0")]
		[CompilerGenerated]
		private void JENGJDBMEDP(int PEHNFBCOJMK)
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
			[Cpp2IlInjected.Address(RVA = "0x5F8EB30", Offset = "0x5F8D930", VA = "0x185F8EB30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5F8EC10", Offset = "0x5F8DA10", VA = "0x185F8EC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5F8EB70", Offset = "0x5F8D970", VA = "0x185F8EB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5F8EC70", Offset = "0x5F8DA70", VA = "0x185F8EC70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5F8EAF0", Offset = "0x5F8D8F0", VA = "0x185F8EAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5F8EBB0", Offset = "0x5F8D9B0", VA = "0x185F8EBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7BB8A0", Offset = "0x7BA6A0", VA = "0x1807BB8A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5F8E1B0", Offset = "0x5F8CFB0", VA = "0x185F8E1B0")]
		public static LCPCLNHECBF KNBFKAAGFFE(string OCEOBDFJNCG, [NotNull] string FHBHJMFONPA, long OMALGJJGAKG, long DNLLKDHCHED, string ALDHKAEGBEL, bool OHPFIFFJLOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5F8DF40", Offset = "0x5F8CD40", VA = "0x185F8DF40")]
		public static LCPCLNHECBF HDOKCGHHLOL(string OCEOBDFJNCG, [NotNull] string FHBHJMFONPA, long OMALGJJGAKG, long DNLLKDHCHED, string ALDHKAEGBEL, long APEMFLGOEEM, bool OHPFIFFJLOL, string MNJGHMJCCJB, string DKKFDKCCBFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5F8E960", Offset = "0x5F8D760", VA = "0x185F8E960")]
		private AmplitudeAnalyticsEvent(string OCEOBDFJNCG, [NotNull] string FHBHJMFONPA, long OMALGJJGAKG, long DNLLKDHCHED, string ALDHKAEGBEL, bool OHPFIFFJLOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1A67260", Offset = "0x1A66060", VA = "0x181A67260")]
		public void MOLHABOHLPP(long ONIDNDPIGDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5F8E0A0", Offset = "0x5F8CEA0", VA = "0x185F8E0A0", Slot = "5")]
		public override void HMCCEEDCEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5F8E2B0", Offset = "0x5F8D0B0", VA = "0x185F8E2B0", Slot = "6")]
		public override void LNIPPHLNAKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5F8E430", Offset = "0x5F8D230", VA = "0x185F8E430", Slot = "4")]
		protected override Dictionary<string, object> MJCFAGDJMCP(Dictionary<string, object> EBFPKFIKPMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5F8DE30", Offset = "0x5F8CC30", VA = "0x185F8DE30")]
		private void AKMAEBHMOLP(string ONOECNHBCDA, string MAEBFBHFPDE, bool FABGOHBJGKH = false)
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
			[Cpp2IlInjected.Address(RVA = "0x5F90090", Offset = "0x5F8EE90", VA = "0x185F90090")]
			public void OANGBDNEKCD(Dictionary<string, object> BKHFCOCIDJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5F98000", Offset = "0x5F96E00", VA = "0x185F98000")]
			public void OANGBDNEKCD(Dictionary<string, object> NLJAIDPKHMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x902E60", Offset = "0x901C60", VA = "0x180902E60")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7B8190", Offset = "0x7B6F90", VA = "0x1807B8190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EF00", Offset = "0x5F8DD00", VA = "0x185F8EF00")]
		public static JNKNCHEGABM KNBFKAAGFFE(string OCEOBDFJNCG, string ALDHKAEGBEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F390", Offset = "0x5F8E190", VA = "0x185F8F390")]
		protected AmplitudeAnalyticsIdentifyMessage(string OCEOBDFJNCG, string ALDHKAEGBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EDE0", Offset = "0x5F8DBE0", VA = "0x185F8EDE0")]
		public Dictionary<string, object> ECLMBCPLNNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5F8F050", Offset = "0x5F8DE50", VA = "0x185F8F050", Slot = "4")]
		protected virtual Dictionary<string, object> MJCFAGDJMCP(Dictionary<string, object> EBFPKFIKPMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5F8ECD0", Offset = "0x5F8DAD0", VA = "0x185F8ECD0")]
		protected void AOBCKDJGMBH(string ONOECNHBCDA, Dictionary<string, object> IFIBNHAAAAO, Dictionary<string, object> PJEOEJGOCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5F8ED70", Offset = "0x5F8DB70", VA = "0x185F8ED70")]
		protected void BMHCLMINEHH(string ONOECNHBCDA, string MAEBFBHFPDE, Dictionary<string, object> ONENCPHFJNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EE70", Offset = "0x5F8DC70", VA = "0x185F8EE70", Slot = "5")]
		public virtual void HMCCEEDCEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EFC0", Offset = "0x5F8DDC0", VA = "0x185F8EFC0", Slot = "6")]
		public virtual void LNIPPHLNAKG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JNKNCHEGABM : NONHCEAJGGP<AmplitudeAnalyticsIdentifyMessage, JNKNCHEGABM>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override JNKNCHEGABM DDHBHEAHBDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage JHAAHPCAECC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5F95190", Offset = "0x5F93F90", VA = "0x185F95190")]
	public JNKNCHEGABM(AmplitudeAnalyticsIdentifyMessage LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5F950E0", Offset = "0x5F93EE0", VA = "0x185F950E0", Slot = "4")]
	public override void LNIPPHLNAKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LCPCLNHECBF : NONHCEAJGGP<AmplitudeAnalyticsEvent, LCPCLNHECBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool LOFFIOKNDPM;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override LCPCLNHECBF DDHBHEAHBDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long MLHCBNIEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5F96370", Offset = "0x5F95170", VA = "0x185F96370")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5F96600", Offset = "0x5F95400", VA = "0x185F96600")]
	public LCPCLNHECBF(AmplitudeAnalyticsEvent LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400", Slot = "5")]
	public override AmplitudeAnalyticsEvent JHAAHPCAECC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5F96530", Offset = "0x5F95330", VA = "0x185F96530", Slot = "4")]
	public override void LNIPPHLNAKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x27DADE0", Offset = "0x27D9BE0", VA = "0x1827DADE0")]
	public LCPCLNHECBF AMPCJHGJOGH<T>(string EIJAJNKHLMI, T[] MAEBFBHFPDE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x27DADE0", Offset = "0x27D9BE0", VA = "0x1827DADE0")]
	public LCPCLNHECBF AMPCJHGJOGH(string EIJAJNKHLMI, string[] MAEBFBHFPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x27DAB30", Offset = "0x27D9930", VA = "0x1827DAB30")]
	public LCPCLNHECBF AMPCJHGJOGH<T>(string EIJAJNKHLMI, T MAEBFBHFPDE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5F96280", Offset = "0x5F95080", VA = "0x185F96280")]
	public LCPCLNHECBF AMPCJHGJOGH(string EIJAJNKHLMI, long MAEBFBHFPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5F96300", Offset = "0x5F95100", VA = "0x185F96300")]
	public LCPCLNHECBF AMPCJHGJOGH(string EIJAJNKHLMI, string MAEBFBHFPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5F965D0", Offset = "0x5F953D0", VA = "0x185F965D0")]
	public LCPCLNHECBF OMEFFPCHOPH(string EIJAJNKHLMI, object? MAEBFBHFPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F96490", Offset = "0x5F95290", VA = "0x185F96490")]
	public LCPCLNHECBF EGOJAEBIFPI(string EIJAJNKHLMI, string MAEBFBHFPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5F96390", Offset = "0x5F95190", VA = "0x185F96390")]
	private LCPCLNHECBF CDLIDDBKLEO(string EIJAJNKHLMI, object MAEBFBHFPDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LNECNFJIECG : LCPCLNHECBF
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F96600", Offset = "0x5F95400", VA = "0x185F96600")]
	public LNECNFJIECG(AmplitudeAnalyticsEvent LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F97290", Offset = "0x5F96090", VA = "0x185F97290", Slot = "4")]
	public override void LNIPPHLNAKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class NONHCEAJGGP<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : NONHCEAJGGP<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M LJCDGDONMLD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR DDHBHEAHBDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	public NONHCEAJGGP(M LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3F01C40", Offset = "0x3F00A40", VA = "0x183F01C40")]
	public BLDR NIDFBOKEPBI(AmplitudeAnalyticsIdentifyMessage.DeviceInfo NAKPOONDLHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3F01BF0", Offset = "0x3F009F0", VA = "0x183F01BF0")]
	public BLDR ILCLHOIGGBL(AmplitudeAnalyticsIdentifyMessage.RevenueData PPIHJIHEKGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3F01CC0", Offset = "0x3F00AC0", VA = "0x183F01CC0")]
	public BLDR PJHMKIGMBCI(string EIJAJNKHLMI, string MAEBFBHFPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2551360", Offset = "0x2550160", VA = "0x182551360")]
	public BLDR PJHMKIGMBCI<T>(string EIJAJNKHLMI, T MAEBFBHFPDE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LNIPPHLNAKG();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3F01C90", Offset = "0x3F00A90", VA = "0x183F01C90")]
	internal static string NPOMGBEMJHO(string MAEBFBHFPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3F01AF0", Offset = "0x3F008F0", VA = "0x183F01AF0")]
	private BLDR ECGPGIPCGKH(string EIJAJNKHLMI, object MAEBFBHFPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M JHAAHPCAECC();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class LJNMACNOIEC : GLDKALFDIFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct HEKIGPEBDLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<POBIJKICCPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public LJNMACNOIEC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5F94060", Offset = "0x5F92E60", VA = "0x185F94060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5F94900", Offset = "0x5F93700", VA = "0x185F94900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct ELHGCNNEPPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<POBIJKICCPD> <>t__builder;

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
		public LJNMACNOIEC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5F916C0", Offset = "0x5F904C0", VA = "0x185F916C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5F920F0", Offset = "0x5F90EF0", VA = "0x185F920F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient HIBPBHFMDKD;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F96EE0", Offset = "0x5F95CE0", VA = "0x185F96EE0")]
	[HBAMLEIOGOF(BHCECOANHAK.None)]
	private static void JCGIKNPJEIP(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F97210", Offset = "0x5F96010", VA = "0x185F97210")]
	[RecRoom.NoEngine.Common.Preserve]
	public LJNMACNOIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5F970C0", Offset = "0x5F95EC0", VA = "0x185F970C0", Slot = "4")]
	[AsyncStateMachine(typeof(HEKIGPEBDLM))]
	public Task<POBIJKICCPD> NEEFHEMKJOH(string OKDOBPLFPCO, Dictionary<string, string> HEPNHJJAFED, bool KGIFKGLGHKD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5F96F50", Offset = "0x5F95D50", VA = "0x185F96F50", Slot = "5")]
	[AsyncStateMachine(typeof(ELHGCNNEPPN))]
	public Task<POBIJKICCPD> MGHHFJEEKCB(string OKDOBPLFPCO, string HFACHHOFEJL, string FOGLOLBFGEC, string PIHHCPHNPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LEGMFFAIHHO
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> IPEAJNJIAEN;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5F96650", Offset = "0x5F95450", VA = "0x185F96650")]
	internal static bool CCGCCICIHKG(string ONOECNHBCDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GLDKALFDIFA
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<POBIJKICCPD> NEEFHEMKJOH(string OKDOBPLFPCO, Dictionary<string, string> HEPNHJJAFED, bool KGIFKGLGHKD = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<POBIJKICCPD> MGHHFJEEKCB(string OKDOBPLFPCO, string HFACHHOFEJL, string FOGLOLBFGEC, string PIHHCPHNPMD);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct POBIJKICCPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int ICJFDNLOLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string OIOAIHCFDBE;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xBF9910", Offset = "0xBF8710", VA = "0x180BF9910")]
	public POBIJKICCPD(int JKBFAPPGFNF, string KECHNMECDLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum GMJNAPHBFJH
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
public class PCPLLGJEHPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long CHPKJONKHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private LCPCLNHECBF GILLIHHJMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool IFLLPIFAFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float NJMOIABGKFP;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5F97E70", Offset = "0x5F96C70", VA = "0x185F97E70")]
	public PCPLLGJEHPA(string JBOHFBKPKBC, float NJMOIABGKFP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x28ADFA0", Offset = "0x28ACDA0", VA = "0x1828ADFA0")]
	public void AMPCJHGJOGH<T>(string EIJAJNKHLMI, T MAEBFBHFPDE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5F97BA0", Offset = "0x5F969A0", VA = "0x185F97BA0")]
	public void AMPCJHGJOGH(string EIJAJNKHLMI, string MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5F97C20", Offset = "0x5F96A20", VA = "0x185F97C20")]
	public void ELJNEOAFNKD(string AOODGJOHOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5F97AE0", Offset = "0x5F968E0", VA = "0x185F97AE0")]
	public void ALEMFBHCDFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5F97D60", Offset = "0x5F96B60", VA = "0x185F97D60")]
	private void PNDHDADGIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5F97D10", Offset = "0x5F96B10", VA = "0x185F97D10")]
	private bool JDPLBCBOGAD()
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
		public enum BOECLHAMNIC
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
		private BOECLHAMNIC parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public BOECLHAMNIC Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x91FAD0", Offset = "0x91E8D0", VA = "0x18091FAD0")]
			get
			{
				return default(BOECLHAMNIC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7B8D50", Offset = "0x7B7B50", VA = "0x1807B8D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x864240", Offset = "0x863040", VA = "0x180864240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5F98170", Offset = "0x5F96F70", VA = "0x185F98170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class AHMECNFCALA : NMPAGGIHHCE, HOPJCKJKBEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly GBFKNBIFCOH BEIONMKFHGA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string APDGDBMEIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1067410", Offset = "0x1066210", VA = "0x181067410", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool GGNLFOJCJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5F87B30", Offset = "0x5F86930", VA = "0x185F87B30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool NAPONIBEMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5F87B10", Offset = "0x5F86910", VA = "0x185F87B10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> GKGNBPBBPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1067530", Offset = "0x1066330", VA = "0x181067530", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	public AHMECNFCALA(GBFKNBIFCOH OMMMKKDJPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2764590", Offset = "0x2763390", VA = "0x182764590", Slot = "8")]
	public T MHEOMGMBJHC<T>(string ONOECNHBCDA, T KKIHKKGMFIE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class EPDCEDPHEOB : KOJNBDKFDDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct GIAMOFJLNOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public EPDCEDPHEOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public DAALDLLGEDP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5F93B80", Offset = "0x5F92980", VA = "0x185F93B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5F94000", Offset = "0x5F92E00", VA = "0x185F94000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct FOHFFFMOHHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5F93910", Offset = "0x5F92710", VA = "0x185F93910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5F93B20", Offset = "0x5F92920", VA = "0x185F93B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct LCDLGJDPFIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public EPDCEDPHEOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public DAALDLLGEDP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5F95F60", Offset = "0x5F94D60", VA = "0x185F95F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5F96220", Offset = "0x5F95020", VA = "0x185F96220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct CIFGDAMMFBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public EPDCEDPHEOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public DAALDLLGEDP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5F8FC60", Offset = "0x5F8EA60", VA = "0x185F8FC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5F90030", Offset = "0x5F8EE30", VA = "0x185F90030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly IReadOnlyDictionary<string, COLNIFPOHDD> FCNHMOANMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool IEELINMEHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private EECFJLDGLLG IJGDOKCAFIB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool AMNKABLPIGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x80B180", Offset = "0x809F80", VA = "0x18080B180", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string KFDAALDBNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5F93330", Offset = "0x5F92130", VA = "0x185F93330", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public NJANKLNCLDI BAELLDLMKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5F930C0", Offset = "0x5F91EC0", VA = "0x185F930C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action CIGEBJODOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5F93340", Offset = "0x5F92140", VA = "0x185F93340", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5F92300", Offset = "0x5F91100", VA = "0x185F92300", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action DGNCGAIGJEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5F93730", Offset = "0x5F92530", VA = "0x185F93730", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5F92F70", Offset = "0x5F91D70", VA = "0x185F92F70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5F931F0", Offset = "0x5F91FF0", VA = "0x185F931F0", Slot = "8")]
	[AsyncStateMachine(typeof(GIAMOFJLNOG))]
	public Task KCJBJGBIMAI(string GBMPJFKIPDB, string DBFIJLJAMAI, [Optional] DAALDLLGEDP BKOCPHDOGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5F93010", Offset = "0x5F91E10", VA = "0x185F93010", Slot = "17")]
	[AsyncStateMachine(typeof(FOHFFFMOHHL))]
	public Task HOEEAFPNHGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5F92420", Offset = "0x5F91220", VA = "0x185F92420", Slot = "12")]
	[AsyncStateMachine(typeof(LCDLGJDPFIB))]
	public Task DIKJCNFKHJP(DAALDLLGEDP BKOCPHDOGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5F921F0", Offset = "0x5F90FF0", VA = "0x185F921F0", Slot = "13")]
	[AsyncStateMachine(typeof(CIFGDAMMFBP))]
	public Task BKGCKEHFCNL(DAALDLLGEDP BKOCPHDOGLF, Dictionary<string, string> DABFJAJCGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F92160", Offset = "0x5F90F60", VA = "0x185F92160", Slot = "14")]
	public bool BADCPEOOIHI(string CKHIPEOKBEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5F923A0", Offset = "0x5F911A0", VA = "0x185F923A0", Slot = "15")]
	public NMPAGGIHHCE DEDFGDHLAFP(string PJMGLJIGHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5F93460", Offset = "0x5F92260", VA = "0x185F93460")]
	private GBFKNBIFCOH OJGJKLOJDMO(string PJMGLJIGHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5F933E0", Offset = "0x5F921E0", VA = "0x185F933E0", Slot = "16")]
	public EECFEFCOAHL OGFGHPHMGEP(string HPPPGIEIIDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5F93160", Offset = "0x5F91F60", VA = "0x185F93160")]
	private IMDKNCKAOFI JIDHGMIHFEL(string HPPPGIEIIDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5F92510", Offset = "0x5F91310", VA = "0x185F92510")]
	private OKBJPHHAPMC DNEHCMMGIII(DAALDLLGEDP BKOCPHDOGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5F92DC0", Offset = "0x5F91BC0", VA = "0x185F92DC0")]
	private LJAOMKDFJAD FPCFBKDOJBI(string DBFIJLJAMAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5F93620", Offset = "0x5F92420", VA = "0x185F93620")]
	private void PKKGDOLPPJK(string PJMGLJIGHBI, GBFKNBIFCOH OMMMKKDJPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public EPDCEDPHEOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class KEFLBJBAOHH : KOJNBDKFDDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct LEKMEPPLJOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public KEFLBJBAOHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public DAALDLLGEDP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5F96800", Offset = "0x5F95600", VA = "0x185F96800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5F96E80", Offset = "0x5F95C80", VA = "0x185F96E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private KOJNBDKFDDJ MLHJCJAPBCL;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private KOJNBDKFDDJ BLPIGAFJNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5F95C20", Offset = "0x5F94A20", VA = "0x185F95C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool AMNKABLPIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5F95870", Offset = "0x5F94670", VA = "0x185F95870", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string KFDAALDBNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5F95BD0", Offset = "0x5F949D0", VA = "0x185F95BD0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NJANKLNCLDI BAELLDLMKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5F959D0", Offset = "0x5F947D0", VA = "0x185F959D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action CIGEBJODOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5F95C90", Offset = "0x5F94A90", VA = "0x185F95C90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5F95570", Offset = "0x5F94370", VA = "0x185F95570", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action DGNCGAIGJEB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5F95EC0", Offset = "0x5F94CC0", VA = "0x185F95EC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5F957D0", Offset = "0x5F945D0", VA = "0x185F957D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	[UnityEngine.Scripting.Preserve]
	public KEFLBJBAOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5F95E50", Offset = "0x5F94C50", VA = "0x185F95E50")]
	[HBAMLEIOGOF(BHCECOANHAK.GameOnly)]
	private static void PBOKBLGPDEP(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5F95D30", Offset = "0x5F94B30", VA = "0x185F95D30")]
	[HBAMLEIOGOF(BHCECOANHAK.EditorOnly)]
	private static void NMAHPONKIMP(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5F95A90", Offset = "0x5F94890", VA = "0x185F95A90", Slot = "8")]
	[AsyncStateMachine(typeof(LEKMEPPLJOJ))]
	public Task KCJBJGBIMAI(string GBMPJFKIPDB, string DBFIJLJAMAI, [Optional] DAALDLLGEDP BKOCPHDOGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5F956C0", Offset = "0x5F944C0", VA = "0x185F956C0", Slot = "12")]
	public Task DIKJCNFKHJP(DAALDLLGEDP BKOCPHDOGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5F95450", Offset = "0x5F94250", VA = "0x185F95450", Slot = "13")]
	public Task BKGCKEHFCNL(DAALDLLGEDP BKOCPHDOGLF, Dictionary<string, string> DABFJAJCGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5F953A0", Offset = "0x5F941A0", VA = "0x185F953A0", Slot = "14")]
	public bool BADCPEOOIHI(string CKHIPEOKBEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5F95610", Offset = "0x5F94410", VA = "0x185F95610", Slot = "15")]
	public NMPAGGIHHCE DEDFGDHLAFP(string PJMGLJIGHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5F95DA0", Offset = "0x5F94BA0", VA = "0x185F95DA0", Slot = "16")]
	public EECFEFCOAHL OGFGHPHMGEP(string HPPPGIEIIDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5F958C0", Offset = "0x5F946C0", VA = "0x185F958C0", Slot = "17")]
	public Task HOEEAFPNHGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x804B40", Offset = "0x803940", VA = "0x180804B40")]
	[CompilerGenerated]
	private void JAPILHHGPIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xBFC180", Offset = "0xBFAF80", VA = "0x180BFC180")]
	[CompilerGenerated]
	private void CPIFPDGEDHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class HGMHPOJJBDJ : EECFEFCOAHL, HOPJCKJKBEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly IMDKNCKAOFI PDJFPIOCMLN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string APDGDBMEIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1067430", Offset = "0x1066230", VA = "0x181067430", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	public HGMHPOJJBDJ(IMDKNCKAOFI JPKFLBLKANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2764590", Offset = "0x2763390", VA = "0x182764590", Slot = "5")]
	public T MHEOMGMBJHC<T>(string ONOECNHBCDA, T KKIHKKGMFIE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface JLLIGNGGCFJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[UsedImplicitly]
public class MIFMNIIMOIL : JLLIGNGGCFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly HFFILEJFKCD APDNNFGMFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly Dictionary<string, OOBAPOGPENC> LIFBBHGOHKD;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5F97440", Offset = "0x5F96240", VA = "0x185F97440")]
	[HBAMLEIOGOF(EOCHJKOJDMN.Session, BHCECOANHAK.GameOnly)]
	[UsedImplicitly]
	private static void LKEMAGLDGMF(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5F974B0", Offset = "0x5F962B0", VA = "0x185F974B0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MIFMNIIMOIL([BMAJFBAIDDE(null)][NotNull] HFFILEJFKCD APDNNFGMFIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class AHPPPOFJHIM : KOJNBDKFDDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool AMNKABLPIGA
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7D4310", Offset = "0x7D3110", VA = "0x1807D4310", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string KFDAALDBNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NJANKLNCLDI BAELLDLMKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action CIGEBJODOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5F87F50", Offset = "0x5F86D50", VA = "0x185F87F50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5F87BE0", Offset = "0x5F869E0", VA = "0x185F87BE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action DGNCGAIGJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5F88070", Offset = "0x5F86E70", VA = "0x185F88070", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5F87D90", Offset = "0x5F86B90", VA = "0x185F87D90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public AHPPPOFJHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5F87EC0", Offset = "0x5F86CC0", VA = "0x185F87EC0", Slot = "8")]
	public Task KCJBJGBIMAI(string GBMPJFKIPDB, string DBFIJLJAMAI, [Optional] DAALDLLGEDP BKOCPHDOGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5F87D00", Offset = "0x5F86B00", VA = "0x185F87D00", Slot = "12")]
	public Task DIKJCNFKHJP(DAALDLLGEDP BKOCPHDOGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5F87B50", Offset = "0x5F86950", VA = "0x185F87B50", Slot = "13")]
	public Task BKGCKEHFCNL(DAALDLLGEDP BKOCPHDOGLF, Dictionary<string, string> DABFJAJCGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "14")]
	public bool BADCPEOOIHI(string CKHIPEOKBEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5F87C80", Offset = "0x5F86A80", VA = "0x185F87C80", Slot = "15")]
	public NMPAGGIHHCE DEDFGDHLAFP(string PJMGLJIGHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5F87FF0", Offset = "0x5F86DF0", VA = "0x185F87FF0", Slot = "16")]
	public EECFEFCOAHL OGFGHPHMGEP(string HPPPGIEIIDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5F87E30", Offset = "0x5F86C30", VA = "0x185F87E30", Slot = "17")]
	public Task HOEEAFPNHGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal class EECFJLDGLLG : NJANKLNCLDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly OKBJPHHAPMC IJGDOKCAFIB;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IReadOnlyDictionary<string, object> NMJKHMBCPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1067430", Offset = "0x1066230", VA = "0x181067430", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	public EECFJLDGLLG(OKBJPHHAPMC DKIFLHBNFIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface HPOFKGGOIDD
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PCPLLGJEHPA KHJELOBCJNO(string JBOHFBKPKBC);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface OAGIIBPPBNM
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public enum MKPIGKGIIPL
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	long AJCNCEMMPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string MIDIHFDPKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string BAOPOCKDFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string GNHLOINNAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string GBCECMLCJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool NDLIFCDKOAL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long AAIABEPMCJC();

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LGKFGPMCFAO(long OMALGJJGAKG, bool FABGOHBJGKH = true);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HCIGCJEFJPD(string KMABAKEMFMI, string NCJCCEDDEAP, string IIJDCLFJPBN);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EGCJMBDJKAE(string KMABAKEMFMI);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KCFFGEPCHNN(string KMABAKEMFMI, string OAKJNILHEID, string CFCINLEFHCN);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FNCDOAJOLDE(string OLPKJHEOOAO, object MIKNOOCJBEF, object PGDIFLHNPEN);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AGIIMAPKPOO(MKPIGKGIIPL NHBEBEEOHAD, int EJIKHJDMNAB, [Optional] EGNLPHGPENF DACDANCKJON, [Optional] string OLAHMPIAJBP, [Optional] string JCNMJFGAPPH);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IGIBHBDKGBL(EGNLPHGPENF DACDANCKJON, long CIPCFJPLOGG, long GOEAIPCBAOC, int EMAKMMOFMLM, string OLAHMPIAJBP, int EJIKHJDMNAB);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AFMNMPFBPAF(EGNLPHGPENF DACDANCKJON, bool KFNIFOCCFHM, [Optional] string JCNMJFGAPPH);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EHCDLHMNMNI(EGNLPHGPENF DACDANCKJON, bool KFNIFOCCFHM, [Optional] string JCNMJFGAPPH);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AEDFJDLONIO(EGNLPHGPENF DACDANCKJON, bool KFNIFOCCFHM, [Optional] string JCNMJFGAPPH);
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
