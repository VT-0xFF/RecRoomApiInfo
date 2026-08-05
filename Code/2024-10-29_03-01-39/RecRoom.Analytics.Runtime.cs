using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AmplitudeAnalytics;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using UnityEngine;
using UnityEngine.Networking;
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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6D13B10", Offset = "0x6D12B10", VA = "0x186D13B10")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D18AF0", Offset = "0x6D17AF0", VA = "0x186D18AF0", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
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
		public AmplitudeAnalyticsClient.Settings AIPPLPJKLFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HABEKALNHNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E50", Offset = "0x8B8E50", VA = "0x1808B9E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private enum KMHNCIEDHGF
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal class CCBDINPLNEG
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class PNLFFBJAGGP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				public int AOKJCBKKDEM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public Dictionary<string, object> FMPIJPAIJJL;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
				public PNLFFBJAGGP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class HFOCDIJHGJE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
				public HFOCDIJHGJE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x6D10650", Offset = "0x6D0F650", VA = "0x186D10650")]
				internal bool PALBOOBJKDG(PNLFFBJAGGP item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private const string DBODAAJJKCA = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly string MBDMHLKHKIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private List<PNLFFBJAGGP> DBEKEIPKCAP;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public int? JPLICDPEOOL
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6D0E290", Offset = "0x6D0D290", VA = "0x186D0E290")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6D0E330", Offset = "0x6D0D330", VA = "0x186D0E330")]
			internal CCBDINPLNEG(string ILHOACFHOMG, string IJLJLFLHMHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6D0D0E0", Offset = "0x6D0C0E0", VA = "0x186D0D0E0")]
			public int BFCGBIICGED([Optional] int? LBPKFHDCOEL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6D0DC80", Offset = "0x6D0CC80", VA = "0x186D0DC80")]
			public List<Dictionary<string, object>> JDCILDGAEKF(int BKCOHAHMDEC, int? LBPKFHDCOEL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6D0DBE0", Offset = "0x6D0CBE0", VA = "0x186D0DBE0")]
			public void GFPHIOCDCMN(AmplitudeAnalyticsIdentifyMessage IFPBFCLBBDP, bool NLACEMKPLAM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6D0DAD0", Offset = "0x6D0CAD0", VA = "0x186D0DAD0")]
			public void GFPHIOCDCMN(Dictionary<string, object> IFPBFCLBBDP, bool NLACEMKPLAM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6D0E110", Offset = "0x6D0D110", VA = "0x186D0E110")]
			public void MCHGIMMMDKG(params Dictionary<string, object>[] BCPALKCNBIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6D0D290", Offset = "0x6D0C290", VA = "0x186D0D290")]
			public void CIEEMANBIOJ(List<Dictionary<string, object>> IDCDIMCIJCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6D0DEF0", Offset = "0x6D0CEF0", VA = "0x186D0DEF0")]
			private void JIHHGMFJPFB(Dictionary<string, object> IFPBFCLBBDP, bool NLACEMKPLAM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6D0D4D0", Offset = "0x6D0C4D0", VA = "0x186D0D4D0")]
			public void CIFIPLHLOND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6D0D6D0", Offset = "0x6D0C6D0", VA = "0x186D0D6D0")]
			private void FDDCLLALEID([Optional] string NPBJAGIJBDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6D0DFF0", Offset = "0x6D0CFF0", VA = "0x186D0DFF0")]
			private static string KPPFLFKKNOP(string BJDKOHEGDOK, string MLAECOMLIEC)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6D18710", Offset = "0x6D17710", VA = "0x186D18710")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct BCHEANGGKAJ<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public int PFKCGKPGHGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public string LKMNDCOBKKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T LKCHEOBBMHH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NLIGCEHMDMB : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private MIAEKAOKMEH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public NLIGCEHMDMB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6D13350", Offset = "0x6D12350", VA = "0x186D13350", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6D13AC0", Offset = "0x6D12AC0", VA = "0x186D13AC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class OLMAHNPMDPE : IEnumerator<object>, IEnumerator, IDisposable
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
			public IIAHDMFNNHP quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public OLMAHNPMDPE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6D13FF0", Offset = "0x6D12FF0", VA = "0x186D13FF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6D14100", Offset = "0x6D13100", VA = "0x186D14100", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class OMAMHBBPDPP : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public OMAMHBBPDPP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6D14150", Offset = "0x6D13150", VA = "0x186D14150", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6D142C0", Offset = "0x6D132C0", VA = "0x186D142C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class OPGKJILBNPM : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private MIAEKAOKMEH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public OPGKJILBNPM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6D14310", Offset = "0x6D13310", VA = "0x186D14310", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6D14570", Offset = "0x6D13570", VA = "0x186D14570", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class BGNKGEOLHJD : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private MIAEKAOKMEH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public BGNKGEOLHJD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6D0CE40", Offset = "0x6D0BE40", VA = "0x186D0CE40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6D0D090", Offset = "0x6D0C090", VA = "0x186D0D090", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class EBHEKOADACJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public CCBDINPLNEG cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public EBHEKOADACJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6D0EB40", Offset = "0x6D0DB40", VA = "0x186D0EB40")]
			internal void BIANMLPNDFF(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6D0EE50", Offset = "0x6D0DE50", VA = "0x186D0EE50")]
			internal void DIEGPILGFFI(BCHEANGGKAJ<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class MPLECCCHBHP : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private MIAEKAOKMEH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CCBDINPLNEG cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private EBHEKOADACJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private float <startTime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private bool <timedOut>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private int <batchSize>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public MPLECCCHBHP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6D128E0", Offset = "0x6D118E0", VA = "0x186D128E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6D130E0", Offset = "0x6D120E0", VA = "0x186D130E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class MBJBDAKBJHN<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public MBJBDAKBJHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x492B1B0", Offset = "0x492A1B0", VA = "0x18492B1B0")]
			internal BCHEANGGKAJ<T> KNMODLHJJCI(JBCJNPMAFJB postResponse)
			{
				return default(BCHEANGGKAJ<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private AANDAFLIKBC CKJGHLPFOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<LGFHHIBMDBE> BELGJDMPIIF;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string KHMMNCFHKMO = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string HMDFPNAHIOH = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string EEMDFIOCNLM = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int NBKFLCOGOFJ = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int GGOAOBNNKGI = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int BCMKEKNHAPO = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float DEIAEJOIIIE = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long DGMAOPFGPBC = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string AGCGAMEALEA = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string EFJEJJHPAKA = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string HJACFCPCAAE = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string KDFJHAGIMNM = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool LKNDOPNEDFA;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool CMBMPJNGIHC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int DOOHCOGMJJM;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int CCMFJEEPLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private HCHEJEGBGFG GGBPLHJAJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private IAKMKHBFGIO PBGGLNKAGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private AKDCHDJNKMF JNPIAHINEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool ACNEAGLBIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float ECGAMCGHCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float KECCAAMHFHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int OLOGOJJFPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int AGFFBKLLPOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? FBPIOEICBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? IEADPLBPHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long DADFLKOGGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string IPDHCGCPBDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string NLANAMJKOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long AKBOHIGEKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string LACNAKNHKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string OHAIMAKOJED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> AEGBGENIOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private KMHNCIEDHGF HDEBDECMFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int EEKGEGKGJGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int ECPDIJPPBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float ODAJKLJABDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool LECDBGCIJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool AINMHCODNFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CCBDINPLNEG CCOMLOEAECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private CCBDINPLNEG FDJELNDMNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CCBDINPLNEG HGLPDHFHBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string PDJBGNHKGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> KFLENAJIJMG;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo NLJAJOAHJBN;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static string GEJGEIEBODE;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string LICIDMJMNPE = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly string ECBEEDLCPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string JHEDBPFLDBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string CCCBBAIHFIF;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private AANDAFLIKBC FNOIGJKFDHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6D08CB0", Offset = "0x6D07CB0", VA = "0x186D08CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private LGFHHIBMDBE DLKHEGPHEID
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6D066F0", Offset = "0x6D056F0", VA = "0x186D066F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int GBGICOFENCN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6D08A20", Offset = "0x6D07A20", VA = "0x186D08A20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long NDDJEBEONCC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B760", Offset = "0x6D0A760", VA = "0x186D0B760")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B870", Offset = "0x6D0A870", VA = "0x186D0B870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string EPOJLMKFDFF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B730", Offset = "0x6D0A730", VA = "0x186D0B730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string KPPKLIALEJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x900980", Offset = "0x8FF980", VA = "0x180900980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9BEC50", Offset = "0x9BDC50", VA = "0x1809BEC50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int? EEKMABNMPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA17040", Offset = "0xA16040", VA = "0x180A17040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1C9D950", Offset = "0x1C9C950", VA = "0x181C9D950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DGBBELPPEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA2E250", Offset = "0xA2D250", VA = "0x180A2E250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1563140", Offset = "0x1562140", VA = "0x181563140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool FEBNLNJPPKC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B600", Offset = "0x6D0A600", VA = "0x186D0B600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> PNJDDMBOCGP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B540", Offset = "0x6D0A540", VA = "0x186D0B540")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B7B0", Offset = "0x6D0A7B0", VA = "0x186D0B7B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D05B80", Offset = "0x6D04B80", VA = "0x186D05B80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D061E0", Offset = "0x6D051E0", VA = "0x186D061E0")]
		private void CIJOLOHFDID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AB90", Offset = "0x6D09B90", VA = "0x186D0AB90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D09830", Offset = "0x6D08830", VA = "0x186D09830", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AEB0", Offset = "0x6D09EB0", VA = "0x186D0AEB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D098E0", Offset = "0x6D088E0", VA = "0x186D098E0")]
		public KKJPAEAJCIM PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D08990", Offset = "0x6D07990", VA = "0x186D08990")]
		[IteratorStateMachine(typeof(NLIGCEHMDMB))]
		public IEnumerator<MIAEKAOKMEH> InitializeForLocalAccount(AmplitudeAnalyticsEvent AHKHKIBNLDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D0A260", Offset = "0x6D09260", VA = "0x186D0A260")]
		public void SendAppEnterEvent(bool GMKNCHPCNAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AE30", Offset = "0x6D09E30", VA = "0x186D0AE30")]
		public void UpdateLastKnownInteractionCategory(string EGPJJAAPCAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AD80", Offset = "0x6D09D80", VA = "0x186D0AD80")]
		public void UpdateLastAliveTime(float MLPBAIIBHBN = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D05920", Offset = "0x6D04920", VA = "0x186D05920")]
		private KKJPAEAJCIM AOHJKDLGHEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D071E0", Offset = "0x6D061E0", VA = "0x186D071E0")]
		private KKJPAEAJCIM GHIAPNPMGEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D0A570", Offset = "0x6D09570", VA = "0x186D0A570")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6D095D0", Offset = "0x6D085D0", VA = "0x186D095D0")]
		[IteratorStateMachine(typeof(OLMAHNPMDPE))]
		private IEnumerator OAAIBKLNJNF(IIAHDMFNNHP MDBPDOPJAEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B140", Offset = "0x6D0A140", VA = "0x186D0B140")]
		[IteratorStateMachine(typeof(OMAMHBBPDPP))]
		public IEnumerator WaitForFlush(float AMBGDNGJBFG = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AC60", Offset = "0x6D09C60", VA = "0x186D0AC60")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D0ABA0", Offset = "0x6D09BA0", VA = "0x186D0ABA0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime JEKIPNBIBLB)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D08490", Offset = "0x6D07490", VA = "0x186D08490")]
		public static GCOIEKMAKCP Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6D059D0", Offset = "0x6D049D0", VA = "0x186D059D0")]
		public static OIDDPCODHOP AccountSelectionPostLoginEvent([NotNull] string MDMBDGJHCNG, string PFEOCJNAHIN, ADDKKECANOD AFIKHOHIOAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6D06A00", Offset = "0x6D05A00", VA = "0x186D06A00")]
		public static OIDDPCODHOP Event([NotNull] string MDMBDGJHCNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6D09A70", Offset = "0x6D08A70", VA = "0x186D09A70")]
		public static OIDDPCODHOP PreviousSessionEvent([NotNull] string MDMBDGJHCNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6D08630", Offset = "0x6D07630", VA = "0x186D08630")]
		public static OIDDPCODHOP InitializeEvent(string PFEOCJNAHIN, int BOHGLPDCIGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6D0A770", Offset = "0x6D09770", VA = "0x186D0A770")]
		public static OIDDPCODHOP StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6D06740", Offset = "0x6D05740", VA = "0x186D06740")]
		public static OIDDPCODHOP CreateOutOfSessionEvent(string MDMBDGJHCNG, bool KOAIGCMAFKA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D08FA0", Offset = "0x6D07FA0", VA = "0x186D08FA0")]
		public static KKJPAEAJCIM LogOutOfSessionEvent(OIDDPCODHOP EDJOADOAIIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D08D40", Offset = "0x6D07D40", VA = "0x186D08D40")]
		public void LogEventAsync(AmplitudeAnalyticsEvent EINBOCHOKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6D09170", Offset = "0x6D08170", VA = "0x186D09170")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent EINBOCHOKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6D092A0", Offset = "0x6D082A0", VA = "0x186D092A0")]
		public void LogSerializedEventAsync(Dictionary<string, object> JJLBLOJICNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6D08E70", Offset = "0x6D07E70", VA = "0x186D08E70")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage EHKHCGLLPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6D065A0", Offset = "0x6D055A0", VA = "0x186D065A0")]
		private void CJLDKFBGPNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D06E90", Offset = "0x6D05E90", VA = "0x186D06E90")]
		private void GCBOENDNIEF(Dictionary<string, object> AFPBGKGFCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6D06D10", Offset = "0x6D05D10", VA = "0x186D06D10")]
		private void FIIIDDNGKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D09660", Offset = "0x6D08660", VA = "0x186D09660")]
		private void OOACIBJHKFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6D06E00", Offset = "0x6D05E00", VA = "0x186D06E00")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6D08C20", Offset = "0x6D07C20", VA = "0x186D08C20")]
		[IteratorStateMachine(typeof(OPGKJILBNPM))]
		private IEnumerator<MIAEKAOKMEH> KCPCPPHIJEN(float AMBGDNGJBFG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6D07140", Offset = "0x6D06140", VA = "0x186D07140")]
		[IteratorStateMachine(typeof(BGNKGEOLHJD))]
		private IEnumerator<MIAEKAOKMEH> GCJEGGHBMBH(float AMBGDNGJBFG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6D09380", Offset = "0x6D08380", VA = "0x186D09380")]
		[IteratorStateMachine(typeof(MPLECCCHBHP))]
		private IEnumerator<MIAEKAOKMEH> MIDACIBCOHH(CCBDINPLNEG NBMFIGMFHDG, int? LBPKFHDCOEL, string ICAFGHBADGL, float AMBGDNGJBFG, Action<int> LNNPCENMHJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6D08040", Offset = "0x6D07040", VA = "0x186D08040")]
		private static void IKHEGOGDPEO(bool FKOLBCLICJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6D08150", Offset = "0x6D07150", VA = "0x186D08150")]
		private OBJFFICJNII<BCHEANGGKAJ<Dictionary<string, object>>> INDIFADFNLA(string ICAFGHBADGL, string NINILBAIEML, Dictionary<string, object> LKCHEOBBMHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6D08220", Offset = "0x6D07220", VA = "0x186D08220")]
		private OBJFFICJNII<BCHEANGGKAJ<List<Dictionary<string, object>>>> INDIFADFNLA(string ICAFGHBADGL, string NINILBAIEML, List<Dictionary<string, object>> LKCHEOBBMHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x36A9180", Offset = "0x36A8180", VA = "0x1836A9180")]
		private OBJFFICJNII<BCHEANGGKAJ<T>> JEBPPCMANFF<T>(string GBNMPILMLDN, string ICAFGHBADGL, string NINILBAIEML, T LKCHEOBBMHH, Dictionary<string, object> NAEHOCBELID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6D066A0", Offset = "0x6D056A0", VA = "0x186D066A0")]
		private bool COFCLLPNFEG(float DFJEEPBJDPF, float AMBGDNGJBFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6D07350", Offset = "0x6D06350", VA = "0x186D07350")]
		private Dictionary<string, object> HOMHKCKPGEF(string ICAFGHBADGL, Dictionary<string, object> LKCHEOBBMHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B230", Offset = "0x6D0A230", VA = "0x186D0B230")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6D09460", Offset = "0x6D08460", VA = "0x186D09460")]
		[CompilerGenerated]
		private long MLJPPLDNAKL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D071D0", Offset = "0x6D061D0", VA = "0x186D071D0")]
		[CompilerGenerated]
		private void GDAOLMHLJMK(int IBBPKGOOMAJ)
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
		private readonly string assignedUserCrm;

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

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6D0C560", Offset = "0x6D0B560", VA = "0x186D0C560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6D0C630", Offset = "0x6D0B630", VA = "0x186D0C630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6D0C5A0", Offset = "0x6D0B5A0", VA = "0x186D0C5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6D0C680", Offset = "0x6D0B680", VA = "0x186D0C680")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6D0C520", Offset = "0x6D0B520", VA = "0x186D0C520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6D0C5E0", Offset = "0x6D0B5E0", VA = "0x186D0C5E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8B4260", Offset = "0x8B3260", VA = "0x1808B4260")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B8D0", Offset = "0x6D0A8D0", VA = "0x186D0B8D0")]
		public static OIDDPCODHOP AIOPMLNOOEO(string FNBFBBNHKCM, [NotNull] string BGGADMIJNIJ, long OIJFPACFEKG, long FCNDJAIPHCJ, string PFEOCJNAHIN, string AFIKHOHIOAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BD60", Offset = "0x6D0AD60", VA = "0x186D0BD60")]
		public static OIDDPCODHOP KOKPPGLOECF(string FNBFBBNHKCM, [NotNull] string BGGADMIJNIJ, long OIJFPACFEKG, long FCNDJAIPHCJ, string PFEOCJNAHIN, long CEMPDIKMCBD, string JPOHFNMBIDD, string CANPOKLHMDN, string NPEGBGGLDKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C380", Offset = "0x6D0B380", VA = "0x186D0C380")]
		private AmplitudeAnalyticsEvent(string FNBFBBNHKCM, [NotNull] string BGGADMIJNIJ, long OIJFPACFEKG, long FCNDJAIPHCJ, string PFEOCJNAHIN, string AFIKHOHIOAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xABDBB0", Offset = "0xABCBB0", VA = "0x180ABDBB0")]
		public void KGACBIIGLLO(long HEOOJHDFPNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B9D0", Offset = "0x6D0A9D0", VA = "0x186D0B9D0", Slot = "5")]
		public override void COMFKPLGLNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BAD0", Offset = "0x6D0AAD0", VA = "0x186D0BAD0", Slot = "6")]
		public override void KFKHOECAKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BEC0", Offset = "0x6D0AEC0", VA = "0x186D0BEC0", Slot = "4")]
		protected override Dictionary<string, object> MFHMAJEDNNI(Dictionary<string, object> NKBBLFEDNJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BC50", Offset = "0x6D0AC50", VA = "0x186D0BC50")]
		private void KIJPFBPFIFM(string MLAECOMLIEC, string BJDKOHEGDOK, bool CPGABPOLKBD = false)
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

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6D0E9C0", Offset = "0x6D0D9C0", VA = "0x186D0E9C0")]
			public void DDGOJABBEEJ(Dictionary<string, object> ELCNKCJJGJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
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

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6D183A0", Offset = "0x6D173A0", VA = "0x186D183A0")]
			public void DDGOJABBEEJ(Dictionary<string, object> BOJHFPIAKCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xE8C120", Offset = "0xE8B120", VA = "0x180E8C120")]
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

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C740", Offset = "0x6D0B740", VA = "0x186D0C740")]
		public static GCOIEKMAKCP AIOPMLNOOEO(string FNBFBBNHKCM, string PFEOCJNAHIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6D0CD80", Offset = "0x6D0BD80", VA = "0x186D0CD80")]
		protected AmplitudeAnalyticsIdentifyMessage(string FNBFBBNHKCM, string PFEOCJNAHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C890", Offset = "0x6D0B890", VA = "0x186D0C890")]
		public Dictionary<string, object> EGMCINPCMOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6D0CA40", Offset = "0x6D0BA40", VA = "0x186D0CA40", Slot = "4")]
		protected virtual Dictionary<string, object> MFHMAJEDNNI(Dictionary<string, object> NKBBLFEDNJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C920", Offset = "0x6D0B920", VA = "0x186D0C920")]
		protected void IGJKDJJOGNN(string MLAECOMLIEC, Dictionary<string, object> PHBEBLBLNOL, Dictionary<string, object> CHBILJAJAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C6D0", Offset = "0x6D0B6D0", VA = "0x186D0C6D0")]
		protected void AGEHMCOAJFI(string MLAECOMLIEC, string BJDKOHEGDOK, Dictionary<string, object> INDNNOCPEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C800", Offset = "0x6D0B800", VA = "0x186D0C800", Slot = "5")]
		public virtual void COMFKPLGLNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C9C0", Offset = "0x6D0B9C0", VA = "0x186D0C9C0", Slot = "6")]
		public virtual void KFKHOECAKNF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GCOIEKMAKCP : MCDPLABCNCC<AmplitudeAnalyticsIdentifyMessage, GCOIEKMAKCP>
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public override GCOIEKMAKCP MCJBLNPKCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage PINIEAKPJHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D0FB60", Offset = "0x6D0EB60", VA = "0x186D0FB60")]
	public GCOIEKMAKCP(AmplitudeAnalyticsIdentifyMessage ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D0FAC0", Offset = "0x6D0EAC0", VA = "0x186D0FAC0", Slot = "4")]
	public override void KFKHOECAKNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OIDDPCODHOP : MCDPLABCNCC<AmplitudeAnalyticsEvent, OIDDPCODHOP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool FDJLLLBBGJA;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override OIDDPCODHOP MCJBLNPKCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public long HOKGJOEDGON
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6D13C30", Offset = "0x6D12C30", VA = "0x186D13C30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D11EB0", Offset = "0x6D10EB0", VA = "0x186D11EB0")]
	public OIDDPCODHOP(AmplitudeAnalyticsEvent ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0", Slot = "5")]
	public override AmplitudeAnalyticsEvent PINIEAKPJHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D13C80", Offset = "0x6D12C80", VA = "0x186D13C80", Slot = "4")]
	public override void KFKHOECAKNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3148DF0", Offset = "0x3147DF0", VA = "0x183148DF0")]
	public OIDDPCODHOP OECFENDIJPG<T>(string EDBGKLDPNAK, T[] BJDKOHEGDOK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3148DF0", Offset = "0x3147DF0", VA = "0x183148DF0")]
	public OIDDPCODHOP OECFENDIJPG(string EDBGKLDPNAK, string[] BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3148B40", Offset = "0x3147B40", VA = "0x183148B40")]
	public OIDDPCODHOP OECFENDIJPG<T>(string EDBGKLDPNAK, T BJDKOHEGDOK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D13E20", Offset = "0x6D12E20", VA = "0x186D13E20")]
	public OIDDPCODHOP OECFENDIJPG(string EDBGKLDPNAK, long BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D13EA0", Offset = "0x6D12EA0", VA = "0x186D13EA0")]
	public OIDDPCODHOP OECFENDIJPG(string EDBGKLDPNAK, string BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D13C50", Offset = "0x6D12C50", VA = "0x186D13C50")]
	public OIDDPCODHOP HEAGMHAEFPD(string EDBGKLDPNAK, object? BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D13B90", Offset = "0x6D12B90", VA = "0x186D13B90")]
	public OIDDPCODHOP DJIGJGMLFNE(string EDBGKLDPNAK, string BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D13D20", Offset = "0x6D12D20", VA = "0x186D13D20")]
	private OIDDPCODHOP LKIKKCKGCHB(string EDBGKLDPNAK, object BJDKOHEGDOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MKHAOLGKIKJ : OIDDPCODHOP
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D11EB0", Offset = "0x6D10EB0", VA = "0x186D11EB0")]
	public MKHAOLGKIKJ(AmplitudeAnalyticsEvent ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D11D00", Offset = "0x6D10D00", VA = "0x186D11D00", Slot = "4")]
	public override void KFKHOECAKNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class MCDPLABCNCC<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : MCDPLABCNCC<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M ABHPFCOODAJ;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract BLDR MCJBLNPKCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public MCDPLABCNCC(M ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x492CBE0", Offset = "0x492BBE0", VA = "0x18492CBE0")]
	public BLDR DKAIAKPFJMI(AmplitudeAnalyticsIdentifyMessage.DeviceInfo LAILEHJEEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x492CD10", Offset = "0x492BD10", VA = "0x18492CD10")]
	public BLDR NOEKICFALKE(AmplitudeAnalyticsIdentifyMessage.RevenueData BOGHCGDPGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x492CC30", Offset = "0x492BC30", VA = "0x18492CC30")]
	public BLDR JABDGCMGPHE(string EDBGKLDPNAK, string BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x327E5E0", Offset = "0x327D5E0", VA = "0x18327E5E0")]
	public BLDR JABDGCMGPHE<T>(string EDBGKLDPNAK, T BJDKOHEGDOK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KFKHOECAKNF();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x492CCE0", Offset = "0x492BCE0", VA = "0x18492CCE0")]
	internal static string JIOLPBNEKBG(string BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x492CD60", Offset = "0x492BD60", VA = "0x18492CD60")]
	private BLDR PCEOGIKJGMG(string EDBGKLDPNAK, object BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M PINIEAKPJHO();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class GCEGIOFACBJ : HCHEJEGBGFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct GPDCLPOAJGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<JBCJNPMAFJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public GCEGIOFACBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private StringContent <requestBody>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private HttpRequestMessage <request>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private HttpResponseMessage <httpResponse>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6D0FBB0", Offset = "0x6D0EBB0", VA = "0x186D0FBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6D105E0", Offset = "0x6D0F5E0", VA = "0x186D105E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient PGNEMBOHIBO;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F9D0", Offset = "0x6D0E9D0", VA = "0x186D0F9D0")]
	[AEDCCIMPEFD.GIGKNHONDJE]
	internal static void GDHFPBFGPMB(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6D0FA40", Offset = "0x6D0EA40", VA = "0x186D0FA40")]
	[RecRoom.NoEngine.Common.Preserve]
	public GCEGIOFACBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F860", Offset = "0x6D0E860", VA = "0x186D0F860", Slot = "4")]
	[AsyncStateMachine(typeof(GPDCLPOAJGH))]
	public Task<JBCJNPMAFJB> FIHCEMPPNFG(string GBNMPILMLDN, string JGDGJHCBEEO, string BDFEIGNBKLG, string EGHBLANPLFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class PIFLOGGPKEK : HCHEJEGBGFG
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OJEGIOIOCGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TaskCompletionSource<JBCJNPMAFJB> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OJEGIOIOCGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6D13F10", Offset = "0x6D12F10", VA = "0x186D13F10")]
		internal void NGLIEMOLNFH(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct FHGFKIAOFLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<JBCJNPMAFJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<JBCJNPMAFJB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F2A0", Offset = "0x6D0E2A0", VA = "0x186D0F2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F7F0", Offset = "0x6D0E7F0", VA = "0x186D0F7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	[AEDCCIMPEFD.GIGKNHONDJE]
	internal static void DLFAJLBMOLH(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	[RecRoom.NoEngine.Common.Preserve]
	public PIFLOGGPKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D162D0", Offset = "0x6D152D0", VA = "0x186D162D0", Slot = "4")]
	[AsyncStateMachine(typeof(FHGFKIAOFLM))]
	public Task<JBCJNPMAFJB> FIHCEMPPNFG(string GBNMPILMLDN, string JGDGJHCBEEO, string BDFEIGNBKLG, string EGHBLANPLFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class KLMKKNMHMLA
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> DEDJEAIJOLB;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6D110A0", Offset = "0x6D100A0", VA = "0x186D110A0")]
	internal static bool CIBLPIIMPMG(string MLAECOMLIEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HCHEJEGBGFG
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JBCJNPMAFJB> FIHCEMPPNFG(string GBNMPILMLDN, string JGDGJHCBEEO, string BDFEIGNBKLG, string EGHBLANPLFE);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct JBCJNPMAFJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly int MMIHLKGJBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly string KCBPPOMHBNC;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x11B3E40", Offset = "0x11B2E40", VA = "0x1811B3E40")]
	public JBCJNPMAFJB(int PFKCGKPGHGK, string LKMNDCOBKKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum ELHGAECJEEF
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	GameInvite,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	RoomChat,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DebugCommand
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DBBJGCGMNAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private long JABGMFOAKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private OIDDPCODHOP NINMKPGMGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool PANAOGDGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float LCHGIBIAMJN;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E830", Offset = "0x6D0D830", VA = "0x186D0E830")]
	public DBBJGCGMNAG(string MAKIGDCKEGL, float LCHGIBIAMJN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6320", Offset = "0x2DB5320", VA = "0x182DB6320")]
	public void OECFENDIJPG<T>(string EDBGKLDPNAK, T BJDKOHEGDOK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E7B0", Offset = "0x6D0D7B0", VA = "0x186D0E7B0")]
	public void OECFENDIJPG(string EDBGKLDPNAK, string BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E6C0", Offset = "0x6D0D6C0", VA = "0x186D0E6C0")]
	public void OCPNAIHEAGD(string DEOKDCPJHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E4A0", Offset = "0x6D0D4A0", VA = "0x186D0E4A0")]
	public void ABKCKPAMPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E5B0", Offset = "0x6D0D5B0", VA = "0x186D0E5B0")]
	private void MEFEELDDFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E560", Offset = "0x6D0D560", VA = "0x186D0E560")]
	private bool EOKICKGFLKO()
	{
		return default(bool);
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum EBFGKECAHDK
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			String,
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			Bool
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private EBFGKECAHDK parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public EBFGKECAHDK Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x98E600", Offset = "0x98D600", VA = "0x18098E600")]
			get
			{
				return default(EBFGKECAHDK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x93B330", Offset = "0x93A330", VA = "0x18093B330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D18510", Offset = "0x6D17510", VA = "0x186D18510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class KHNMFLBBGHG : BPPCCOJCCBL, DENCMADCNDP
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate void ACGJEJNBMPP(EPJGJKFPNDD FKNACJJADLO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly PIBMAOPLCIN IJKEBMGGLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly ACGJEJNBMPP LLMEJBIEPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string EKNEEMEGGDB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string BDOCIHCGBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1634900", Offset = "0x1633900", VA = "0x181634900", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool HGLGHCHDOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D10FF0", Offset = "0x6D0FFF0", VA = "0x186D10FF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CCLAJHAHFKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6D11010", Offset = "0x6D10010", VA = "0x186D11010", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<string> ONJBEJECHKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1634620", Offset = "0x1633620", VA = "0x181634620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6D11030", Offset = "0x6D10030", VA = "0x186D11030")]
	public KHNMFLBBGHG(PIBMAOPLCIN CLGKEAHKEGA, string NBJLCCLHPFC, [Optional] ACGJEJNBMPP KGNFJNNHAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3034090", Offset = "0x3033090", VA = "0x183034090", Slot = "8")]
	public T KIJHOBDIGPJ<T>(string MLAECOMLIEC, T MJBMFFMBOMO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PKILOECEFAH : NIFDEMPMOFN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct PFKGFHLGPCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public IAKMKHBFGIO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public PKILOECEFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6D15920", Offset = "0x6D14920", VA = "0x186D15920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6D16270", Offset = "0x6D15270", VA = "0x186D16270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct NLFCNGKFKPI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6D13130", Offset = "0x6D12130", VA = "0x186D13130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6D132F0", Offset = "0x6D122F0", VA = "0x186D132F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct MAOGPJIOOKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public IAKMKHBFGIO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public PKILOECEFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6D11890", Offset = "0x6D10890", VA = "0x186D11890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6D11CA0", Offset = "0x6D10CA0", VA = "0x186D11CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct LGLEKALDPGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public PKILOECEFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public IAKMKHBFGIO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6D11480", Offset = "0x6D10480", VA = "0x186D11480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6D11830", Offset = "0x6D10830", VA = "0x186D11830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly IReadOnlyDictionary<string, KIEMFFCBMCE> GGPPFJJKBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool OKNENEJPIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool AHDPDDHOHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private TaskCompletionSource<bool> IAHGJKDCJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private TaskCompletionSource<bool> FOFOPGIHLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly SemaphoreSlim KPBELHDDMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private FCKDLOBKLMN EPJBPNEBJCN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Task IIPLFGGNJMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D16B90", Offset = "0x6D15B90", VA = "0x186D16B90", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool OFMKAFANLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x98E930", Offset = "0x98D930", VA = "0x18098E930", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KCKBHFIOCCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xF63200", Offset = "0xF62200", VA = "0x180F63200", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string KPPKLIALEJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6D16680", Offset = "0x6D15680", VA = "0x186D16680", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public AIMAJFKFIGN LBAFEIFBMLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6D16B40", Offset = "0x6D15B40", VA = "0x186D16B40", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FKKBJABGOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6D16690", Offset = "0x6D15690", VA = "0x186D16690", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6D16AA0", Offset = "0x6D15AA0", VA = "0x186D16AA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action AJAEAGKNOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6D165E0", Offset = "0x6D155E0", VA = "0x186D165E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6D177C0", Offset = "0x6D167C0", VA = "0x186D177C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action ODAPOKMPIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6D168E0", Offset = "0x6D158E0", VA = "0x186D168E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6D16BD0", Offset = "0x6D15BD0", VA = "0x186D16BD0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<EPJGJKFPNDD> NBKMCMADDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6D17E30", Offset = "0x6D16E30", VA = "0x186D17E30", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6D16DF0", Offset = "0x6D15DF0", VA = "0x186D16DF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6D16B70", Offset = "0x6D15B70", VA = "0x186D16B70", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6D16980", Offset = "0x6D15980", VA = "0x186D16980", Slot = "12")]
	[AsyncStateMachine(typeof(PFKGFHLGPCI))]
	public Task CPDDJGLEDNE(string IJLJLFLHMHB, [Optional] IAKMKHBFGIO JDEPBMOPKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D16C70", Offset = "0x6D15C70", VA = "0x186D16C70", Slot = "23")]
	[AsyncStateMachine(typeof(NLFCNGKFKPI))]
	public Task GMODJNLCOIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6D18040", Offset = "0x6D17040", VA = "0x186D18040", Slot = "18")]
	[AsyncStateMachine(typeof(MAOGPJIOOKC))]
	public Task PFBLHGDOMGE(IAKMKHBFGIO JDEPBMOPKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6D17FA0", Offset = "0x6D16FA0", VA = "0x186D17FA0")]
	private void NNEOCJLMIAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D17D20", Offset = "0x6D16D20", VA = "0x186D17D20", Slot = "19")]
	[AsyncStateMachine(typeof(LGLEKALDPGK))]
	public Task MHJDBGAFHLC(IAKMKHBFGIO JDEPBMOPKHE, Dictionary<string, string> AEGFMOBOIKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D17EE0", Offset = "0x6D16EE0", VA = "0x186D17EE0", Slot = "20")]
	public bool NFJADCMMNOJ(string DCEOGEKBGBA, bool FJHEMKGLIND = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6D17970", Offset = "0x6D16970", VA = "0x186D17970", Slot = "21")]
	public BPPCCOJCCBL LPLFEOHBFAC(string NBJLCCLHPFC, bool FJHEMKGLIND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6D17B30", Offset = "0x6D16B30", VA = "0x186D17B30")]
	private PIBMAOPLCIN MDGBIBCJBGB(string NBJLCCLHPFC, bool FJHEMKGLIND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6D16730", Offset = "0x6D15730", VA = "0x186D16730", Slot = "22")]
	public GJBHIIJJOHF BLGKMHAMMFB(string PJLCDGDIHNE, bool FJHEMKGLIND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6D16D20", Offset = "0x6D15D20", VA = "0x186D16D20")]
	private NONOFJDLPFJ GPPIDGLCAJK(string PJLCDGDIHNE, bool FJHEMKGLIND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6D16EA0", Offset = "0x6D15EA0", VA = "0x186D16EA0")]
	private LIANGECEOAE KABEPKPOIJJ(IAKMKHBFGIO JDEPBMOPKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6D16430", Offset = "0x6D15430", VA = "0x186D16430")]
	private OGPFNJDJMEC AEACGMLMPBC(string IJLJLFLHMHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6D17860", Offset = "0x6D16860", VA = "0x186D17860")]
	private void LCDHMFIBBAG(string NBJLCCLHPFC, PIBMAOPLCIN CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6D182A0", Offset = "0x6D172A0", VA = "0x186D182A0")]
	public PKILOECEFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6D17780", Offset = "0x6D16780", VA = "0x186D17780")]
	[CompilerGenerated]
	private void KHLJDLMJKHB(EPJGJKFPNDD AAGDOBFBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6D17780", Offset = "0x6D16780", VA = "0x186D17780")]
	[CompilerGenerated]
	private void NHMMOOMKGFP(EPJGJKFPNDD AAGDOBFBLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class OPMAJMDONPI : NIFDEMPMOFN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct MNIEOOPINAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public OPMAJMDONPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public IAKMKHBFGIO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6D11F00", Offset = "0x6D10F00", VA = "0x186D11F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6D12880", Offset = "0x6D11880", VA = "0x186D12880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct LAICOKOJBPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6D11240", Offset = "0x6D10240", VA = "0x186D11240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private PKILOECEFAH NBMMMBNMMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private TaskCompletionSource<bool> IAHGJKDCJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private TaskCompletionSource<bool> FOFOPGIHLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Task EKKKMBMGKKI;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private NIFDEMPMOFN OLHLCHGCLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6D14B20", Offset = "0x6D13B20", VA = "0x186D14B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool KCKBHFIOCCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6D14C70", Offset = "0x6D13C70", VA = "0x186D14C70", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool OFMKAFANLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6D14A00", Offset = "0x6D13A00", VA = "0x186D14A00", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task IIPLFGGNJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6D14D60", Offset = "0x6D13D60", VA = "0x186D14D60", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string KPPKLIALEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6D14660", Offset = "0x6D13660", VA = "0x186D14660", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public AIMAJFKFIGN LBAFEIFBMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6D14C80", Offset = "0x6D13C80", VA = "0x186D14C80", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action AJAEAGKNOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6D145C0", Offset = "0x6D135C0", VA = "0x186D145C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6D15300", Offset = "0x6D14300", VA = "0x186D15300", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action FKKBJABGOHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6D14680", Offset = "0x6D13680", VA = "0x186D14680", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6D14BD0", Offset = "0x6D13BD0", VA = "0x186D14BD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action ODAPOKMPIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6D147E0", Offset = "0x6D137E0", VA = "0x186D147E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6D150A0", Offset = "0x6D140A0", VA = "0x186D150A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<EPJGJKFPNDD> NBKMCMADDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6D15580", Offset = "0x6D14580", VA = "0x186D15580", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6D15250", Offset = "0x6D14250", VA = "0x186D15250", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6D15860", Offset = "0x6D14860", VA = "0x186D15860")]
	[UnityEngine.Scripting.Preserve]
	public OPMAJMDONPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6D14CF0", Offset = "0x6D13CF0", VA = "0x186D14CF0")]
	[AEDCCIMPEFD.GIGKNHONDJE.KBDJNGCKNKK]
	internal static void EKNFAAPFPJB(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6D15030", Offset = "0x6D14030", VA = "0x186D15030")]
	internal static void FIMAJFHNFHO(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6D14CC0", Offset = "0x6D13CC0", VA = "0x186D14CC0", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6D14A10", Offset = "0x6D13A10", VA = "0x186D14A10", Slot = "12")]
	[AsyncStateMachine(typeof(MNIEOOPINAC))]
	public Task CPDDJGLEDNE(string IJLJLFLHMHB, [Optional] IAKMKHBFGIO JDEPBMOPKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6D15750", Offset = "0x6D14750", VA = "0x186D15750", Slot = "18")]
	public Task PFBLHGDOMGE(IAKMKHBFGIO JDEPBMOPKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6D15460", Offset = "0x6D14460", VA = "0x186D15460", Slot = "19")]
	public Task MHJDBGAFHLC(IAKMKHBFGIO JDEPBMOPKHE, Dictionary<string, string> AEGFMOBOIKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6D15630", Offset = "0x6D14630", VA = "0x186D15630", Slot = "20")]
	public bool NFJADCMMNOJ(string DCEOGEKBGBA, bool FJHEMKGLIND = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D153A0", Offset = "0x6D143A0", VA = "0x186D153A0", Slot = "21")]
	public BPPCCOJCCBL LPLFEOHBFAC(string NBJLCCLHPFC, bool FJHEMKGLIND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D14720", Offset = "0x6D13720", VA = "0x186D14720", Slot = "22")]
	public GJBHIIJJOHF BLGKMHAMMFB(string PJLCDGDIHNE, bool FJHEMKGLIND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6D15140", Offset = "0x6D14140", VA = "0x186D15140", Slot = "23")]
	public Task GMODJNLCOIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6D14880", Offset = "0x6D13880", VA = "0x186D14880")]
	private static void CGFHDPEDMCC(TaskCompletionSource<bool> MEEPBDOOLIJ, Task MDAJBHNCGIH, Task MMKJPFHPKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6D14F60", Offset = "0x6D13F60", VA = "0x186D14F60")]
	[AsyncStateMachine(typeof(LAICOKOJBPM))]
	private static void FDPOCDJHBKH(Task KDFIPCHFLGF, TaskCompletionSource<bool> MEEPBDOOLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xB18040", Offset = "0xB17040", VA = "0x180B18040")]
	[CompilerGenerated]
	private void PCFFBGICGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0xABE740", Offset = "0xABD740", VA = "0x180ABE740")]
	[CompilerGenerated]
	private void DCBPGFBKINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x93B110", Offset = "0x93A110", VA = "0x18093B110")]
	[CompilerGenerated]
	private void HOEIHJEBJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6D14B90", Offset = "0x6D13B90", VA = "0x186D14B90")]
	[CompilerGenerated]
	private void DCHCJNENJCE(EPJGJKFPNDD AAGDOBFBLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class FAHANPKGKMK : GJBHIIJJOHF, DENCMADCNDP
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void BAMJCFDAEGD(EPJGJKFPNDD FKNACJJADLO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly BAMJCFDAEGD LLMEJBIEPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly NONOFJDLPFJ GCBOLENPMHB;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string BDOCIHCGBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA3A0F0", Offset = "0xA390F0", VA = "0x180A3A0F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6047FE0", Offset = "0x6046FE0", VA = "0x186047FE0")]
	public FAHANPKGKMK(NONOFJDLPFJ BKMADAFHHHB, [Optional] BAMJCFDAEGD KGNFJNNHAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2F46900", Offset = "0x2F45900", VA = "0x182F46900", Slot = "5")]
	public T KIJHOBDIGPJ<T>(string MLAECOMLIEC, T MJBMFFMBOMO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface DDDJPBIFBHE
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[UsedImplicitly]
public class ANACMKKKPHM : DDDJPBIFBHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly MOKKJHHACCO AAAMCEOADKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<GDMGGFHLKKA> BMNNEJNNLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly string NJJKNAIELPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly string DMCMHDLAAHD;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6D05750", Offset = "0x6D04750", VA = "0x186D05750")]
	[UsedImplicitly]
	[AEDCCIMPEFD.GIGKNHONDJE.KBDJNGCKNKK]
	internal static void LPMGDCHBOCO(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6D057C0", Offset = "0x6D047C0", VA = "0x186D057C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal ANACMKKKPHM([GAHPILLNNBL(null)][NotNull] MOKKJHHACCO AAAMCEOADKE, [GAHPILLNNBL(null)][NotNull] MNKJHFOKLHC ECPOFLEAMNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class HPCHONOBLGD : NIFDEMPMOFN
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task IIPLFGGNJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6D10A60", Offset = "0x6D0FA60", VA = "0x186D10A60", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool KCKBHFIOCCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool OFMKAFANLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string KPPKLIALEJB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public AIMAJFKFIGN LBAFEIFBMLC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action AJAEAGKNOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6D106C0", Offset = "0x6D0F6C0", VA = "0x186D106C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6D10CD0", Offset = "0x6D0FCD0", VA = "0x186D10CD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action FKKBJABGOHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6D10760", Offset = "0x6D0F760", VA = "0x186D10760", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6D109C0", Offset = "0x6D0F9C0", VA = "0x186D109C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action ODAPOKMPIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6D10890", Offset = "0x6D0F890", VA = "0x186D10890", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6D10AF0", Offset = "0x6D0FAF0", VA = "0x186D10AF0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<EPJGJKFPNDD> NBKMCMADDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6D10EB0", Offset = "0x6D0FEB0", VA = "0x186D10EB0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6D10C20", Offset = "0x6D0FC20", VA = "0x186D10C20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	[RecRoom.NoEngine.Common.Preserve]
	public HPCHONOBLGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6D10930", Offset = "0x6D0F930", VA = "0x186D10930", Slot = "12")]
	public Task CPDDJGLEDNE(string IJLJLFLHMHB, [Optional] IAKMKHBFGIO JDEPBMOPKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6D10F60", Offset = "0x6D0FF60", VA = "0x186D10F60", Slot = "18")]
	public Task PFBLHGDOMGE(IAKMKHBFGIO JDEPBMOPKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6D10E20", Offset = "0x6D0FE20", VA = "0x186D10E20", Slot = "19")]
	public Task MHJDBGAFHLC(IAKMKHBFGIO JDEPBMOPKHE, Dictionary<string, string> AEGFMOBOIKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "20")]
	public bool NFJADCMMNOJ(string DCEOGEKBGBA, bool FJHEMKGLIND = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6D10D70", Offset = "0x6D0FD70", VA = "0x186D10D70", Slot = "21")]
	public BPPCCOJCCBL LPLFEOHBFAC(string NBJLCCLHPFC, bool FJHEMKGLIND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6D10800", Offset = "0x6D0F800", VA = "0x186D10800", Slot = "22")]
	public GJBHIIJJOHF BLGKMHAMMFB(string PJLCDGDIHNE, bool FJHEMKGLIND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D10B90", Offset = "0x6D0FB90", VA = "0x186D10B90", Slot = "23")]
	public Task GMODJNLCOIN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal class FCKDLOBKLMN : AIMAJFKFIGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly LIANGECEOAE HBELHIJLIIG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IReadOnlyDictionary<string, object> HCJDNGAJGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA31CC0", Offset = "0xA30CC0", VA = "0x180A31CC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public FCKDLOBKLMN(LIANGECEOAE GIEDBICBHOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface PDIFPAIONLN
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBBJGCGMNAG BCCBAICJILC(string MAKIGDCKEGL);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface AKDCHDJNKMF
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum NBENGJHKNGE
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	long NPDNIEHGGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string KALHHHHKNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string BEENAKGIJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool FOHFOLBBLAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long CHAJIEIPNDI();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PPFJDLLJPGB(long OIJFPACFEKG, bool CPGABPOLKBD = true);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OHDEOPMCEMH(string NDMMIOJEOEB, string IIGMGMKANCC, string HFCGCHPNDEE);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MHIOPOEIPDC(string NDMMIOJEOEB);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AINOEEBFBHF(string NDMMIOJEOEB, string NCAKBHDAOLB, string GEPONHFKMMO);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BJNGJAKGHHD(string MHHGEPFPLHI, object JDKNMMPJKMJ, object DFKHNCKCAEF);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ILJGGBGDGBC(NBENGJHKNGE EBIINHBAKMG, int HDGMOPCDECK, [Optional] PCNFDJAAGAF HBGDDMMBKCA, [Optional] string GCFPIDHJCAF, [Optional] string IPLILPPMPOG);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OOAGAALDLFK(PCNFDJAAGAF HBGDDMMBKCA, long NGCGGGPLLMG, long PNIDHLKEPIK, int FDEJLGMMKHH, string GCFPIDHJCAF, int HDGMOPCDECK);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PEIGKHJOMOM(PCNFDJAAGAF HBGDDMMBKCA, bool BDKLGGLGLFK, [Optional] string IPLILPPMPOG);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OJNNOCGJMKN(PCNFDJAAGAF HBGDDMMBKCA, bool BDKLGGLGLFK, [Optional] string IPLILPPMPOG);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HKFNPKHIKJD(PCNFDJAAGAF HBGDDMMBKCA, bool BDKLGGLGLFK, [Optional] string IPLILPPMPOG);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MCLFIELFHMA(long AHNLEKFKAGC, string EPNKIFNGNBE);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface OPAHMIDIMED
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string IPHLDGBKNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "0")]
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
