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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66E5D30", Offset = "0x66E4530", VA = "0x1866E5D30")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
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
		public AmplitudeAnalyticsClient.Settings HPFAIGEKEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LOLOFBBFFHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8472B0", Offset = "0x845AB0", VA = "0x1808472B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum KHLGIMEMLGK
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class MODEKKBLCFM
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class HNLCODAFJBC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				public int DHCBCONGOEB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public Dictionary<string, object> MPIILLPFBFC;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
				public HNLCODAFJBC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class ELNHDONNBFH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
				public ELNHDONNBFH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x66DF790", Offset = "0x66DDF90", VA = "0x1866DF790")]
				internal bool MJAFBHGLJDF(HNLCODAFJBC item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private const string IHLLNFHBCLD = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly string FKOPBOJEAII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private List<HNLCODAFJBC> BBDOGAEOIAP;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public int? PCFCGHKGJFG
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x66E4DB0", Offset = "0x66E35B0", VA = "0x1866E4DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x66E5300", Offset = "0x66E3B00", VA = "0x1866E5300")]
			internal MODEKKBLCFM(string NGEFJOBLDCJ, string EPFOJCLNECJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x66E4C00", Offset = "0x66E3400", VA = "0x1866E4C00")]
			public int LHHJBDKEFGF([Optional] int? FFCMBJBFHCC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x66E41E0", Offset = "0x66E29E0", VA = "0x1866E41E0")]
			public List<Dictionary<string, object>> DABLKBIEENG(int IELCKHPGIAG, int? FFCMBJBFHCC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x66E5150", Offset = "0x66E3950", VA = "0x1866E5150")]
			public void PCDIMHAKNPJ(AmplitudeAnalyticsIdentifyMessage GHDJADLHPAA, bool NHCJHBPJEME = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x66E51F0", Offset = "0x66E39F0", VA = "0x1866E51F0")]
			public void PCDIMHAKNPJ(Dictionary<string, object> GHDJADLHPAA, bool NHCJHBPJEME = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x66E4A80", Offset = "0x66E3280", VA = "0x1866E4A80")]
			public void INHPGKJBPEL(params Dictionary<string, object>[] ELDGNGHHMGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x66E4450", Offset = "0x66E2C50", VA = "0x1866E4450")]
			public void GKEFIFAOHNP(List<Dictionary<string, object>> CKNABJPPPKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x66E4E50", Offset = "0x66E3650", VA = "0x1866E4E50")]
			private void NHPIKNKKKPI(Dictionary<string, object> GHDJADLHPAA, bool NHCJHBPJEME = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x66E4F50", Offset = "0x66E3750", VA = "0x1866E4F50")]
			public void OAGICGKONBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x66E4690", Offset = "0x66E2E90", VA = "0x1866E4690")]
			private void HONDBOENDLC([Optional] string DHBKCBMCMLF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x66E40C0", Offset = "0x66E28C0", VA = "0x1866E40C0")]
			private static string BHCAOHCKHID(string IPHHABIKCHD, string JOEHGGMHBAA)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x66E74F0", Offset = "0x66E5CF0", VA = "0x1866E74F0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct GMLPHFMCBFD<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public int FNFCHEMAEEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public string JLINAODHANE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T LPIAAEELPLB;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class ODBIHAHPNDN : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private PENLHNEFADH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
			[DebuggerHidden]
			public ODBIHAHPNDN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x66E5DB0", Offset = "0x66E45B0", VA = "0x1866E5DB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x66E6570", Offset = "0x66E4D70", VA = "0x1866E6570", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class KOIKCPLJOEI : IEnumerator<object>, IEnumerator, IDisposable
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
			public EJKPJGCLKPC quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
			[DebuggerHidden]
			public KOIKCPLJOEI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x66E38B0", Offset = "0x66E20B0", VA = "0x1866E38B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x66E39C0", Offset = "0x66E21C0", VA = "0x1866E39C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class HJFKBBCMHAG : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
			[DebuggerHidden]
			public HJFKBBCMHAG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x66DFF90", Offset = "0x66DE790", VA = "0x1866DFF90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x66E0100", Offset = "0x66DE900", VA = "0x1866E0100", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class DGMJAMECHMP : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private PENLHNEFADH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
			[DebuggerHidden]
			public DGMJAMECHMP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x66DE960", Offset = "0x66DD160", VA = "0x1866DE960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x66DEBC0", Offset = "0x66DD3C0", VA = "0x1866DEBC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class PCACEHEOKIM : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private PENLHNEFADH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
			[DebuggerHidden]
			public PCACEHEOKIM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x66E6ED0", Offset = "0x66E56D0", VA = "0x1866E6ED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x66E7120", Offset = "0x66E5920", VA = "0x1866E7120", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CNJIFMGJHBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public MODEKKBLCFM cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public CNJIFMGJHBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x66DE200", Offset = "0x66DCA00", VA = "0x1866DE200")]
			internal void DEBLLMGIEHF(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x66DE520", Offset = "0x66DCD20", VA = "0x1866DE520")]
			internal void HANPOKMLCMC(GMLPHFMCBFD<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class EFGAMMINKNP : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private PENLHNEFADH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public MODEKKBLCFM cache;

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
			private CNJIFMGJHBN <>8__1;

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
			private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
			[DebuggerHidden]
			public EFGAMMINKNP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x66DEF30", Offset = "0x66DD730", VA = "0x1866DEF30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x66DF740", Offset = "0x66DDF40", VA = "0x1866DF740", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class EFKBJNNAOJI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public EFKBJNNAOJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x37481E0", Offset = "0x37469E0", VA = "0x1837481E0")]
			internal GMLPHFMCBFD<T> ENEFPKOHOMF(GEHNJKMENLO postResponse)
			{
				return default(GMLPHFMCBFD<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private BACPELMAHOD DAIPDMPJFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<BMCCKCANODM> AECHPJMBMCH;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string MOLNCCDOIED = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string MGDPJJGPCAI = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string FLKELIAMHAB = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int GIPPCAGCODK = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int JNIIJPFKHJL = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int MAHDKJLPEFA = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float EAOEJHAKAFC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long MKIGENCHCLB = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string MPFDAMBMKLD = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string MBNDMALDKPO = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string KDGFFOHIJKK = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string ENDGDAPAMCK = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool LFFHHNOFMFJ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool KKCMIGAHCMH;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int PKDGBFGDLJJ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int CDLAJEEOJDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private DEHIHHNHKAA CLMJNOAPLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private BILGFNFMLLK LIPJILCGDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private MJABBPPPLNF KKGAFJGMJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool FDKLJJAGNNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float GDAENLDHBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float COKIEENBMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int CCDFJPJCCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int MJIKCHIMOEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? IAIEEPLKKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? HJNMLHKCBAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long HGIJDBIKOGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string MCIADKPLJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool ICIKIHJAAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long PJFACOJICKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string NPOEHFIFDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string OAPKMANEGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> PDGJDNLHOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private KHLGIMEMLGK JLKBDBKKMHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int IKPMLPHNLAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int FPGPHLBJOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float LGFEIPKCNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool JCBMMCEALBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool IGOJLGJDMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private MODEKKBLCFM JPEDINDCKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private MODEKKBLCFM BNHJIGNGCIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private MODEKKBLCFM PELAONNEDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string INIMLIHCACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> BMNLNCBAMBP;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo ECJNEOMHHBI;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static string CICDJBDLDKA;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string PBLMOHEADHP = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly string ENADCMMMJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string IGGIPCHEGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string KFAGDEHNDAC;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BACPELMAHOD LCJJLFIGJCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x66D6850", Offset = "0x66D5050", VA = "0x1866D6850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private BMCCKCANODM LBLBANJHNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x66D7070", Offset = "0x66D5870", VA = "0x1866D7070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int KBFIDAFJAJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x66D70C0", Offset = "0x66D58C0", VA = "0x1866D70C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long MCMNHOJDJGB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x66DC540", Offset = "0x66DAD40", VA = "0x1866DC540")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x66DC650", Offset = "0x66DAE50", VA = "0x1866DC650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string LLLBKEIDCCA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x66DC510", Offset = "0x66DAD10", VA = "0x1866DC510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string COPBDEGIIGG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8B21B0", Offset = "0x8B09B0", VA = "0x1808B21B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB34BE0", Offset = "0xB333E0", VA = "0x180B34BE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int? LJCNEOABAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8B21C0", Offset = "0x8B09C0", VA = "0x1808B21C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x166BA00", Offset = "0x166A200", VA = "0x18166BA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KLJFODAINOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x10B7FE0", Offset = "0x10B67E0", VA = "0x1810B7FE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x111B330", Offset = "0x1119B30", VA = "0x18111B330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool CFADPDEIAHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x66DC3E0", Offset = "0x66DABE0", VA = "0x1866DC3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> KLMEOGIFEGM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x66DC320", Offset = "0x66DAB20", VA = "0x1866DC320")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x66DC590", Offset = "0x66DAD90", VA = "0x1866DC590")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x66D6A30", Offset = "0x66D5230", VA = "0x1866D6A30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x66DA2F0", Offset = "0x66D8AF0", VA = "0x1866DA2F0")]
		private void ONJEABKFLKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x66DB910", Offset = "0x66DA110", VA = "0x1866DB910")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x66DA890", Offset = "0x66D9090", VA = "0x1866DA890", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x66DBCB0", Offset = "0x66DA4B0", VA = "0x1866DBCB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x66DA9D0", Offset = "0x66D91D0", VA = "0x1866DA9D0")]
		public JHMBDMCOPKA PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x66D9200", Offset = "0x66D7A00", VA = "0x1866D9200")]
		[IteratorStateMachine(typeof(ODBIHAHPNDN))]
		public IEnumerator<PENLHNEFADH> InitializeForLocalAccount(AmplitudeAnalyticsEvent FPAJAMJLGNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x66DB190", Offset = "0x66D9990", VA = "0x1866DB190")]
		public void SendAppEnterEvent(bool CFNMFJFBNHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x66DBBF0", Offset = "0x66DA3F0", VA = "0x1866DBBF0")]
		public void UpdateLastKnownInteractionCategory(string HHPLICIBMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x66DBB00", Offset = "0x66DA300", VA = "0x1866DBB00")]
		public void UpdateLastAliveTime(float PNBNBIDOECN = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x66D9290", Offset = "0x66D7A90", VA = "0x1866D9290")]
		private JHMBDMCOPKA JCKNLKNPMID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x66D9CB0", Offset = "0x66D84B0", VA = "0x1866D9CB0")]
		private JHMBDMCOPKA NBCCHBBFCGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x66DB370", Offset = "0x66D9B70", VA = "0x1866DB370")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x66DA940", Offset = "0x66D9140", VA = "0x1866DA940")]
		[IteratorStateMachine(typeof(KOIKCPLJOEI))]
		private IEnumerator PEFLEGDCHGD(EJKPJGCLKPC CJKAHGHMGJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x66DBF40", Offset = "0x66DA740", VA = "0x1866DBF40")]
		[IteratorStateMachine(typeof(HJFKBBCMHAG))]
		public IEnumerator WaitForFlush(float GIGKLDABMPI = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x66DB9E0", Offset = "0x66DA1E0", VA = "0x1866DB9E0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x66DB920", Offset = "0x66DA120", VA = "0x1866DB920")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime KJAPNCDOIOK)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x66D8D50", Offset = "0x66D7550", VA = "0x1866D8D50")]
		public static HOJMLIIPIAJ Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x66D68C0", Offset = "0x66D50C0", VA = "0x1866D68C0")]
		public static NOBHHHBFENC AccountSelectionPostLoginEvent([NotNull] string NMDMLLKHKDF, string MPDFLFFJIHG, bool AKLBAMCMCNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x66D7AA0", Offset = "0x66D62A0", VA = "0x1866D7AA0")]
		public static NOBHHHBFENC Event([NotNull] string NMDMLLKHKDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x66DAA10", Offset = "0x66D9210", VA = "0x1866DAA10")]
		public static NOBHHHBFENC PreviousSessionEvent([NotNull] string NMDMLLKHKDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x66D8EF0", Offset = "0x66D76F0", VA = "0x1866D8EF0")]
		public static NOBHHHBFENC InitializeEvent(string MPDFLFFJIHG, int NLAPDPICJEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x66DB530", Offset = "0x66D9D30", VA = "0x1866DB530")]
		public static NOBHHHBFENC StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x66D75E0", Offset = "0x66D5DE0", VA = "0x1866D75E0")]
		public static NOBHHHBFENC CreateOutOfSessionEvent(string NMDMLLKHKDF, bool LFCBLMHKDIG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x66D97E0", Offset = "0x66D7FE0", VA = "0x1866D97E0")]
		public static JHMBDMCOPKA LogOutOfSessionEvent(NOBHHHBFENC CIFHLJOHFJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x66D9580", Offset = "0x66D7D80", VA = "0x1866D9580")]
		public void LogEventAsync(AmplitudeAnalyticsEvent MMDLPOGECKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x66D99B0", Offset = "0x66D81B0", VA = "0x1866D99B0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent MMDLPOGECKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x66D9AE0", Offset = "0x66D82E0", VA = "0x1866D9AE0")]
		public void LogSerializedEventAsync(Dictionary<string, object> JABGEBIGDDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x66D96B0", Offset = "0x66D7EB0", VA = "0x1866D96B0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage LGBFMBOKJLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x66D7F80", Offset = "0x66D6780", VA = "0x1866D7F80")]
		private void GGCKGICDBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x66DA030", Offset = "0x66D8830", VA = "0x1866DA030")]
		private void OHPPEDNNHCF(Dictionary<string, object> ECAMNNMLFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x66D9BC0", Offset = "0x66D83C0", VA = "0x1866D9BC0")]
		private void MIKLEHOODHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x66D7830", Offset = "0x66D6030", VA = "0x1866D7830")]
		private void DHFOEKPKGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x66D7EF0", Offset = "0x66D66F0", VA = "0x1866D7EF0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x66D9FA0", Offset = "0x66D87A0", VA = "0x1866D9FA0")]
		[IteratorStateMachine(typeof(DGMJAMECHMP))]
		private IEnumerator<PENLHNEFADH> NENMLHHPKJF(float GIGKLDABMPI = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A00", Offset = "0x66D6200", VA = "0x1866D7A00")]
		[IteratorStateMachine(typeof(PCACEHEOKIM))]
		private IEnumerator<PENLHNEFADH> DJCGPJDMHKP(float GIGKLDABMPI = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x66D9340", Offset = "0x66D7B40", VA = "0x1866D9340")]
		[IteratorStateMachine(typeof(EFGAMMINKNP))]
		private IEnumerator<PENLHNEFADH> JNIKEBFELGD(MODEKKBLCFM FLJDKJIJGIC, int? FFCMBJBFHCC, string CBIOGKKPOPF, float GIGKLDABMPI, Action<int> LEIDGOHBDAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D90", Offset = "0x66D6590", VA = "0x1866D7D90")]
		private static void FAMDMMNPOHL(bool PLKLIIFGOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x66D72A0", Offset = "0x66D5AA0", VA = "0x1866D72A0")]
		private MOJHALOLCAP<GMLPHFMCBFD<Dictionary<string, object>>> CIPDAOFLHMP(string CBIOGKKPOPF, string KOAJPANCLPG, Dictionary<string, object> LPIAAEELPLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x66D7370", Offset = "0x66D5B70", VA = "0x1866D7370")]
		private MOJHALOLCAP<GMLPHFMCBFD<List<Dictionary<string, object>>>> CIPDAOFLHMP(string CBIOGKKPOPF, string KOAJPANCLPG, List<Dictionary<string, object>> LPIAAEELPLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x317BD30", Offset = "0x317A530", VA = "0x18317BD30")]
		private MOJHALOLCAP<GMLPHFMCBFD<T>> MGBIONLJGCE<T>(string FODEFHKPAEL, string CBIOGKKPOPF, string KOAJPANCLPG, T LPIAAEELPLB, Dictionary<string, object> KAEKCPNAMOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x66D7EA0", Offset = "0x66D66A0", VA = "0x1866D7EA0")]
		private bool FJHGLBMGJNE(float AINMCCGACCK, float GIGKLDABMPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x66D8080", Offset = "0x66D6880", VA = "0x1866D8080")]
		private Dictionary<string, object> GLDPMCBFHNC(string CBIOGKKPOPF, Dictionary<string, object> LPIAAEELPLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x66DC030", Offset = "0x66DA830", VA = "0x1866DC030")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x66D9420", Offset = "0x66D7C20", VA = "0x1866D9420")]
		[CompilerGenerated]
		private long KAHCOLHLCJF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A90", Offset = "0x66D6290", VA = "0x1866D7A90")]
		[CompilerGenerated]
		private void DMAJFNHPOJH(int POOEAKEICHD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
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

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x66DD390", Offset = "0x66DBB90", VA = "0x1866DD390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x66DD460", Offset = "0x66DBC60", VA = "0x1866DD460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x66DD3D0", Offset = "0x66DBBD0", VA = "0x1866DD3D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x66DD4B0", Offset = "0x66DBCB0", VA = "0x1866DD4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x66DD350", Offset = "0x66DBB50", VA = "0x1866DD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x66DD410", Offset = "0x66DBC10", VA = "0x1866DD410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x843F90", Offset = "0x842790", VA = "0x180843F90")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x66DC990", Offset = "0x66DB190", VA = "0x1866DC990")]
		public static NOBHHHBFENC DLNFHNOLCMJ(string MBDJOBPGDCG, [NotNull] string CMHMODCPNNO, long MLGHAMNEBJP, long EPIANPFGGIM, string MPDFLFFJIHG, bool AKLBAMCMCNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x66DC6B0", Offset = "0x66DAEB0", VA = "0x1866DC6B0")]
		public static NOBHHHBFENC BFBNKBDPDGK(string MBDJOBPGDCG, [NotNull] string CMHMODCPNNO, long MLGHAMNEBJP, long EPIANPFGGIM, string MPDFLFFJIHG, long ILCKKKDMBND, bool AKLBAMCMCNK, string JCGBIFBIDFA, string DOCGOAKGAIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x66DD1C0", Offset = "0x66DB9C0", VA = "0x1866DD1C0")]
		private AmplitudeAnalyticsEvent(string MBDJOBPGDCG, [NotNull] string CMHMODCPNNO, long MLGHAMNEBJP, long EPIANPFGGIM, string MPDFLFFJIHG, bool AKLBAMCMCNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1C5A1D0", Offset = "0x1C589D0", VA = "0x181C5A1D0")]
		public void BNACEBLECBB(long NCFLIANLJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x66DCBA0", Offset = "0x66DB3A0", VA = "0x1866DCBA0", Slot = "5")]
		public override void KGNPJAOKDID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x66DC810", Offset = "0x66DB010", VA = "0x1866DC810", Slot = "6")]
		public override void DCFDMGNFNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x66DCCA0", Offset = "0x66DB4A0", VA = "0x1866DCCA0", Slot = "4")]
		protected override Dictionary<string, object> OFJLJEBCMKK(Dictionary<string, object> OKOOBGMNNLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x66DCA90", Offset = "0x66DB290", VA = "0x1866DCA90")]
		private void HFKJGDBGFIL(string JOEHGGMHBAA, string IPHHABIKCHD, bool GPHALNLKNCD = false)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
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

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x66DEDB0", Offset = "0x66DD5B0", VA = "0x1866DEDB0")]
			public void EOKNLFEAKEE(Dictionary<string, object> PJFBFEDAOGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
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

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x66E7170", Offset = "0x66E5970", VA = "0x1866E7170")]
			public void EOKNLFEAKEE(Dictionary<string, object> JAOGPKHIGDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA68610", Offset = "0xA66E10", VA = "0x180A68610")]
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
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x66DD610", Offset = "0x66DBE10", VA = "0x1866DD610")]
		public static HOJMLIIPIAJ DLNFHNOLCMJ(string MBDJOBPGDCG, string MPDFLFFJIHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x66DDBB0", Offset = "0x66DC3B0", VA = "0x1866DDBB0")]
		protected AmplitudeAnalyticsIdentifyMessage(string MBDJOBPGDCG, string MPDFLFFJIHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x66DD500", Offset = "0x66DBD00", VA = "0x1866DD500")]
		public Dictionary<string, object> CHKOBJPJLEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x66DD870", Offset = "0x66DC070", VA = "0x1866DD870", Slot = "4")]
		protected virtual Dictionary<string, object> OFJLJEBCMKK(Dictionary<string, object> OKOOBGMNNLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x66DD6D0", Offset = "0x66DBED0", VA = "0x1866DD6D0")]
		protected void JPJIAIAPPAD(string JOEHGGMHBAA, Dictionary<string, object> NIPCBIOAMGC, Dictionary<string, object> KBJLIIEDBIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x66DD770", Offset = "0x66DBF70", VA = "0x1866DD770")]
		protected void KFHMLKDDEEG(string JOEHGGMHBAA, string IPHHABIKCHD, Dictionary<string, object> EKEENHKGNHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x66DD7E0", Offset = "0x66DBFE0", VA = "0x1866DD7E0", Slot = "5")]
		public virtual void KGNPJAOKDID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x66DD590", Offset = "0x66DBD90", VA = "0x1866DD590", Slot = "6")]
		public virtual void DCFDMGNFNLM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HOJMLIIPIAJ : AHJFICOGOIN<AmplitudeAnalyticsIdentifyMessage, HOJMLIIPIAJ>
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public override HOJMLIIPIAJ PPGHNNCPBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage LJMKBGAJEFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x66E01F0", Offset = "0x66DE9F0", VA = "0x1866E01F0")]
	public HOJMLIIPIAJ(AmplitudeAnalyticsIdentifyMessage CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x66E0150", Offset = "0x66DE950", VA = "0x1866E0150", Slot = "4")]
	public override void DCFDMGNFNLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NOBHHHBFENC : AHJFICOGOIN<AmplitudeAnalyticsEvent, NOBHHHBFENC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool KJCENIAGHAG;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override NOBHHHBFENC PPGHNNCPBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public long OBKDKMPEEAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x66E56A0", Offset = "0x66E3EA0", VA = "0x1866E56A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x66E57F0", Offset = "0x66E3FF0", VA = "0x1866E57F0")]
	public NOBHHHBFENC(AmplitudeAnalyticsEvent CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800", Slot = "5")]
	public override AmplitudeAnalyticsEvent LJMKBGAJEFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x66E5470", Offset = "0x66E3C70", VA = "0x1866E5470", Slot = "4")]
	public override void DCFDMGNFNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2BE96D0", Offset = "0x2BE7ED0", VA = "0x182BE96D0")]
	public NOBHHHBFENC HKEGNCGLLCC<T>(string ABBFPCPEMEH, T[] IPHHABIKCHD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2BE96D0", Offset = "0x2BE7ED0", VA = "0x182BE96D0")]
	public NOBHHHBFENC HKEGNCGLLCC(string ABBFPCPEMEH, string[] IPHHABIKCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9420", Offset = "0x2BE7C20", VA = "0x182BE9420")]
	public NOBHHHBFENC HKEGNCGLLCC<T>(string ABBFPCPEMEH, T IPHHABIKCHD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x66E55B0", Offset = "0x66E3DB0", VA = "0x1866E55B0")]
	public NOBHHHBFENC HKEGNCGLLCC(string ABBFPCPEMEH, long IPHHABIKCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x66E5630", Offset = "0x66E3E30", VA = "0x1866E5630")]
	public NOBHHHBFENC HKEGNCGLLCC(string ABBFPCPEMEH, string IPHHABIKCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x66E56C0", Offset = "0x66E3EC0", VA = "0x1866E56C0")]
	public NOBHHHBFENC JMCIPEKCKOC(string ABBFPCPEMEH, object? IPHHABIKCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x66E5510", Offset = "0x66E3D10", VA = "0x1866E5510")]
	public NOBHHHBFENC HCADKEKNGNH(string ABBFPCPEMEH, string IPHHABIKCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x66E56F0", Offset = "0x66E3EF0", VA = "0x1866E56F0")]
	private NOBHHHBFENC OBAFOLIDIDJ(string ABBFPCPEMEH, object IPHHABIKCHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OEJBPCDAALN : NOBHHHBFENC
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x66E57F0", Offset = "0x66E3FF0", VA = "0x1866E57F0")]
	public OEJBPCDAALN(AmplitudeAnalyticsEvent CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x66E6D20", Offset = "0x66E5520", VA = "0x1866E6D20", Slot = "4")]
	public override void DCFDMGNFNLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class AHJFICOGOIN<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : AHJFICOGOIN<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M CLBGCJICGJG;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract BLDR PPGHNNCPBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public AHJFICOGOIN(M CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3B9DFF0", Offset = "0x3B9C7F0", VA = "0x183B9DFF0")]
	public BLDR EDJLKDKDGKA(AmplitudeAnalyticsIdentifyMessage.DeviceInfo GHLNIGGJPBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3B9DFA0", Offset = "0x3B9C7A0", VA = "0x183B9DFA0")]
	public BLDR AEALNHHNMBB(AmplitudeAnalyticsIdentifyMessage.RevenueData FMBBIJCMNDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3B9E040", Offset = "0x3B9C840", VA = "0x183B9E040")]
	public BLDR FLAKONAMBDN(string ABBFPCPEMEH, string IPHHABIKCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x24D69C0", Offset = "0x24D51C0", VA = "0x1824D69C0")]
	public BLDR FLAKONAMBDN<T>(string ABBFPCPEMEH, T IPHHABIKCHD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DCFDMGNFNLM();

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3B9E0F0", Offset = "0x3B9C8F0", VA = "0x183B9E0F0")]
	internal static string GALACPNFLNA(string IPHHABIKCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3B9E120", Offset = "0x3B9C920", VA = "0x183B9E120")]
	private BLDR GIGHCOKNNLL(string ABBFPCPEMEH, object IPHHABIKCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M LJMKBGAJEFK();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class IOPJAHLOEPK : DEHIHHNHKAA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct AAIHFMCCONH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<GEHNJKMENLO> <>t__builder;

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
		public IOPJAHLOEPK <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x66D5C60", Offset = "0x66D4460", VA = "0x1866D5C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x66D6680", Offset = "0x66D4E80", VA = "0x1866D6680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient FKEFPCLEFAG;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x66E13A0", Offset = "0x66DFBA0", VA = "0x1866E13A0")]
	[ANLGLDAOJJE(ELBANFBEGNE.None)]
	private static void IPBAIGEEEMG(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x66E1580", Offset = "0x66DFD80", VA = "0x1866E1580")]
	[RecRoom.NoEngine.Common.Preserve]
	public IOPJAHLOEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x66E1410", Offset = "0x66DFC10", VA = "0x1866E1410", Slot = "4")]
	[AsyncStateMachine(typeof(AAIHFMCCONH))]
	public Task<GEHNJKMENLO> NILLCNNLPAJ(string FODEFHKPAEL, string OJFEBAMFHEI, string BAGKHIDKAPC, string JHFCMPDIPKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class AFCFHEEHPOL : DEHIHHNHKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KPNIOOAPINE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TaskCompletionSource<GEHNJKMENLO> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KPNIOOAPINE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x66E3A10", Offset = "0x66E2210", VA = "0x1866E3A10")]
		internal void GKPNLCLEEFP(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct FEJGALBFGEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<GEHNJKMENLO> <>t__builder;

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
		private TaskAwaiter<GEHNJKMENLO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x66DF800", Offset = "0x66DE000", VA = "0x1866DF800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x66DFD50", Offset = "0x66DE550", VA = "0x1866DFD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	[ANLGLDAOJJE(ELBANFBEGNE.None)]
	private static void CJHGFEFOOBO(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public AFCFHEEHPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x66D66F0", Offset = "0x66D4EF0", VA = "0x1866D66F0", Slot = "4")]
	[AsyncStateMachine(typeof(FEJGALBFGEM))]
	public Task<GEHNJKMENLO> NILLCNNLPAJ(string FODEFHKPAEL, string OJFEBAMFHEI, string BAGKHIDKAPC, string JHFCMPDIPKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DMMLCGEMCEP
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> JKDBAPJCJCD;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x66DEC10", Offset = "0x66DD410", VA = "0x1866DEC10")]
	internal static bool DDBGKFPOLEM(string JOEHGGMHBAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface DEHIHHNHKAA
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GEHNJKMENLO> NILLCNNLPAJ(string FODEFHKPAEL, string OJFEBAMFHEI, string BAGKHIDKAPC, string JHFCMPDIPKH);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct GEHNJKMENLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly int MMBCADEDEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly string IBDEPJLPGDA;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0xD63BE0", Offset = "0xD623E0", VA = "0x180D63BE0")]
	public GEHNJKMENLO(int FNFCHEMAEEI, string JLINAODHANE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum HNHHCPFCBII
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
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MLDCCCCAKOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private long PHAEINJLHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NOBHHHBFENC OOOBFELFCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool LHBHNKHCPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float BOBFAJJEAIP;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x66E3F30", Offset = "0x66E2730", VA = "0x1866E3F30")]
	public MLDCCCCAKOF(string AHOOPNNKODA, float BOBFAJJEAIP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2B6EBB0", Offset = "0x2B6D3B0", VA = "0x182B6EBB0")]
	public void HKEGNCGLLCC<T>(string ABBFPCPEMEH, T IPHHABIKCHD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x66E3DC0", Offset = "0x66E25C0", VA = "0x1866E3DC0")]
	public void HKEGNCGLLCC(string ABBFPCPEMEH, string IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x66E3E40", Offset = "0x66E2640", VA = "0x1866E3E40")]
	public void LHCJMBPNGBC(string PDIAHNPIDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x66E3CB0", Offset = "0x66E24B0", VA = "0x1866E3CB0")]
	public void BOHJEEHHAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x66E3BA0", Offset = "0x66E23A0", VA = "0x1866E3BA0")]
	private void AHIGENNGAMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x66E3D70", Offset = "0x66E2570", VA = "0x1866E3D70")]
	private bool FLECLDDNLKD()
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
		public enum NGMGAFCCPOK
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
		private NGMGAFCCPOK parameterType;

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
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public NGMGAFCCPOK Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8B89F0", Offset = "0x8B71F0", VA = "0x1808B89F0")]
			get
			{
				return default(NGMGAFCCPOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x993570", Offset = "0x991D70", VA = "0x180993570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x66E72E0", Offset = "0x66E5AE0", VA = "0x1866E72E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class MFGLMCBDMIG : FJGKCCGDGOG, IMHFBBDGKCJ
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void EIOGIAOBEMC(OADCMGPMFIO FHNBEGBFPCE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly CMIDANMPHOO EPOFNBOFHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly EIOGIAOBEMC KDLHEBOIGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string KBGBMGBAOII;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string NEBKGJCCIIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x11C9FC0", Offset = "0x11C87C0", VA = "0x1811C9FC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool KOFOKFJJFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x66E3B10", Offset = "0x66E2310", VA = "0x1866E3B10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool MGGEMPGGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x66E3AF0", Offset = "0x66E22F0", VA = "0x1866E3AF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<string> HDOEFKMBIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x11CA230", Offset = "0x11C8A30", VA = "0x1811CA230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x66E3B30", Offset = "0x66E2330", VA = "0x1866E3B30")]
	public MFGLMCBDMIG(CMIDANMPHOO LNOEPHEPJGF, string IEFFJCBNHII, [Optional] EIOGIAOBEMC JEDIFBFDIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D660", Offset = "0x2B6BE60", VA = "0x182B6D660", Slot = "8")]
	public T NBGKOOJKKKA<T>(string JOEHGGMHBAA, T HLCNDDGKJJF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class KJHGIPGFCLL : CKECBDNFIAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NOIAHDAEJMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public KJHGIPGFCLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public BILGFNFMLLK userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x66E5840", Offset = "0x66E4040", VA = "0x1866E5840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x66E5CD0", Offset = "0x66E44D0", VA = "0x1866E5CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct CEIELILNLLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x66DDF90", Offset = "0x66DC790", VA = "0x1866DDF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x66DE1A0", Offset = "0x66DC9A0", VA = "0x1866DE1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct CAMFLFGCLPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public KJHGIPGFCLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public BILGFNFMLLK userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x66DDC70", Offset = "0x66DC470", VA = "0x1866DDC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x66DDF30", Offset = "0x66DC730", VA = "0x1866DDF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct ILLHODPDJOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public KJHGIPGFCLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public BILGFNFMLLK userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x66E0F70", Offset = "0x66DF770", VA = "0x1866E0F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x66E1340", Offset = "0x66DFB40", VA = "0x1866E1340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly IReadOnlyDictionary<string, DJBAIMJEKGC> MHDKGFKKGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool DBKCNGCHEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FFKGAAAIDEM CAIAPHJIPIJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool ICIDCBOPNAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x895EE0", Offset = "0x8946E0", VA = "0x180895EE0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string COPBDEGIIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x66E32F0", Offset = "0x66E1AF0", VA = "0x1866E32F0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public NIPIJGHHALO BEJEKMBKPMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x66E2230", Offset = "0x66E0A30", VA = "0x1866E2230", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HEDHFKBLFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x66E31C0", Offset = "0x66E19C0", VA = "0x1866E31C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x66E1ED0", Offset = "0x66E06D0", VA = "0x1866E1ED0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action KDFGENPHEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x66E2490", Offset = "0x66E0C90", VA = "0x1866E2490", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x66E3460", Offset = "0x66E1C60", VA = "0x1866E3460", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<OADCMGPMFIO> CDGAMCDHLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x66E33B0", Offset = "0x66E1BB0", VA = "0x1866E33B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x66E23E0", Offset = "0x66E0BE0", VA = "0x1866E23E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x66E22D0", Offset = "0x66E0AD0", VA = "0x1866E22D0", Slot = "10")]
	[AsyncStateMachine(typeof(NOIAHDAEJMH))]
	public Task DIHNAABPOCM(string EPFOJCLNECJ, [Optional] BILGFNFMLLK OENIOELPLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x66E3300", Offset = "0x66E1B00", VA = "0x1866E3300", Slot = "19")]
	[AsyncStateMachine(typeof(CEIELILNLLF))]
	public Task JFEOJICGONL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x66E2F20", Offset = "0x66E1720", VA = "0x1866E2F20", Slot = "14")]
	[AsyncStateMachine(typeof(CAMFLFGCLPG))]
	public Task GMNFKIFKJFH(BILGFNFMLLK OENIOELPLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x66E1F70", Offset = "0x66E0770", VA = "0x1866E1F70", Slot = "15")]
	[AsyncStateMachine(typeof(ILLHODPDJOL))]
	public Task BLLOIFFEAEB(BILGFNFMLLK OENIOELPLPB, Dictionary<string, string> CKKFFLFEAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x66E3500", Offset = "0x66E1D00", VA = "0x1866E3500", Slot = "16")]
	public bool MIJCGPJPJFG(string NIKFIFPEIFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x66E3010", Offset = "0x66E1810", VA = "0x1866E3010", Slot = "17")]
	public FJGKCCGDGOG IBEDDABHIEI(string IEFFJCBNHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x66E3590", Offset = "0x66E1D90", VA = "0x1866E3590")]
	private CMIDANMPHOO OHHFHKDCNPH(string IEFFJCBNHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x66E2080", Offset = "0x66E0880", VA = "0x1866E2080", Slot = "18")]
	public OBBEMGLOCEK CMIMILPNLCE(string HNHDEDMOLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x66E3260", Offset = "0x66E1A60", VA = "0x1866E3260")]
	private EODNPLKGEEI INHKCAGNMLA(string HNHDEDMOLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x66E2640", Offset = "0x66E0E40", VA = "0x1866E2640")]
	private EMIMKBPDMEA EKNKFLDFHCE(BILGFNFMLLK OENIOELPLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x66E1D20", Offset = "0x66E0520", VA = "0x1866E1D20")]
	private OECHFCECIJE AAMAFMDPCJE(string EPFOJCLNECJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x66E2530", Offset = "0x66E0D30", VA = "0x1866E2530")]
	private void EJDKCFHKIOG(string IEFFJCBNHII, CMIDANMPHOO LNOEPHEPJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public KJHGIPGFCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x66E0F30", Offset = "0x66DF730", VA = "0x1866E0F30")]
	[CompilerGenerated]
	private void EPELHDJEOJB(OADCMGPMFIO KEIFIHHDEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x66E0F30", Offset = "0x66DF730", VA = "0x1866E0F30")]
	[CompilerGenerated]
	private void MLEFMMKNJFN(OADCMGPMFIO KEIFIHHDEOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class IAPBAAMNKGP : CKECBDNFIAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JAKHKIEPAOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public IAPBAAMNKGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public BILGFNFMLLK userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x66E1600", Offset = "0x66DFE00", VA = "0x1866E1600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x66E1CC0", Offset = "0x66E04C0", VA = "0x1866E1CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private CKECBDNFIAF JCGKBELADBA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private CKECBDNFIAF DNPOJKCODIO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x66E0C00", Offset = "0x66DF400", VA = "0x1866E0C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool ICIDCBOPNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x66E0D20", Offset = "0x66DF520", VA = "0x1866E0D20", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string COPBDEGIIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x66E0AA0", Offset = "0x66DF2A0", VA = "0x1866E0AA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public NIPIJGHHALO BEJEKMBKPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x66E04B0", Offset = "0x66DECB0", VA = "0x1866E04B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action HEDHFKBLFKG
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x66E0A00", Offset = "0x66DF200", VA = "0x1866E0A00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x66E0240", Offset = "0x66DEA40", VA = "0x1866E0240", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action KDFGENPHEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x66E0730", Offset = "0x66DEF30", VA = "0x1866E0730", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x66E0DE0", Offset = "0x66DF5E0", VA = "0x1866E0DE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<OADCMGPMFIO> CDGAMCDHLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x66E0C70", Offset = "0x66DF470", VA = "0x1866E0C70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x66E0680", Offset = "0x66DEE80", VA = "0x1866E0680", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	[UnityEngine.Scripting.Preserve]
	public IAPBAAMNKGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x66E0D70", Offset = "0x66DF570", VA = "0x1866E0D70")]
	[ANLGLDAOJJE(ELBANFBEGNE.GameOnly)]
	private static void KOADAPLLBPC(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x66E08E0", Offset = "0x66DF0E0", VA = "0x1866E08E0")]
	[ANLGLDAOJJE(ELBANFBEGNE.EditorOnly)]
	private static void HJCAGJGLCOB(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x66E0570", Offset = "0x66DED70", VA = "0x1866E0570", Slot = "10")]
	[AsyncStateMachine(typeof(JAKHKIEPAOB))]
	public Task DIHNAABPOCM(string EPFOJCLNECJ, [Optional] BILGFNFMLLK OENIOELPLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x66E07D0", Offset = "0x66DEFD0", VA = "0x1866E07D0", Slot = "14")]
	public Task GMNFKIFKJFH(BILGFNFMLLK OENIOELPLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x66E02E0", Offset = "0x66DEAE0", VA = "0x1866E02E0", Slot = "15")]
	public Task BLLOIFFEAEB(BILGFNFMLLK OENIOELPLPB, Dictionary<string, string> CKKFFLFEAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x66E0E80", Offset = "0x66DF680", VA = "0x1866E0E80", Slot = "16")]
	public bool MIJCGPJPJFG(string NIKFIFPEIFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x66E0950", Offset = "0x66DF150", VA = "0x1866E0950", Slot = "17")]
	public FJGKCCGDGOG IBEDDABHIEI(string IEFFJCBNHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x66E0400", Offset = "0x66DEC00", VA = "0x1866E0400", Slot = "18")]
	public OBBEMGLOCEK CMIMILPNLCE(string HNHDEDMOLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x66E0AF0", Offset = "0x66DF2F0", VA = "0x1866E0AF0", Slot = "19")]
	public Task JFEOJICGONL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x88EEE0", Offset = "0x88D6E0", VA = "0x18088EEE0")]
	[CompilerGenerated]
	private void LCOBIJOAEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x944E60", Offset = "0x943660", VA = "0x180944E60")]
	[CompilerGenerated]
	private void ADOACHKJEBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x66E0F30", Offset = "0x66DF730", VA = "0x1866E0F30")]
	[CompilerGenerated]
	private void NNCBDOPPJBH(OADCMGPMFIO KEIFIHHDEOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal class KFNFLPCABEH : OBBEMGLOCEK, IMHFBBDGKCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate void FENBNPEPBCM(OADCMGPMFIO FHNBEGBFPCE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly FENBNPEPBCM KDLHEBOIGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly EODNPLKGEEI KADJCBLLBEL;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string NEBKGJCCIIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1BE3570", Offset = "0x1BE1D70", VA = "0x181BE3570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5A71480", Offset = "0x5A6FC80", VA = "0x185A71480")]
	public KFNFLPCABEH(EODNPLKGEEI CKKMCLHJEBN, [Optional] FENBNPEPBCM JEDIFBFDIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2B274D0", Offset = "0x2B25CD0", VA = "0x182B274D0", Slot = "5")]
	public T NBGKOOJKKKA<T>(string JOEHGGMHBAA, T HLCNDDGKJJF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface HCHCEJFLNHL
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[UsedImplicitly]
public class GJCCJBMHCOJ : HCHCEJFLNHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly BJGPEEDKMIF LEGEFPOOFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly List<GLEKGBDOMGL> GPFJIHFCADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly string KPPAPHIGCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly string EIGGEFKBGKG;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x66DFDC0", Offset = "0x66DE5C0", VA = "0x1866DFDC0")]
	[ANLGLDAOJJE(KKPEBAHBECP.Root, ELBANFBEGNE.GameOnly)]
	[UsedImplicitly]
	private static void KLKHAMFMIOA(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x66DFE30", Offset = "0x66DE630", VA = "0x1866DFE30")]
	[RecRoom.NoEngine.Common.Preserve]
	internal GJCCJBMHCOJ([NotNull][GNKLNMHODGG(null)] BJGPEEDKMIF LEGEFPOOFAD, [GNKLNMHODGG(null)][NotNull] DIKFNMBNFPO JMAJMJBPLNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class ODBPKNCKGCO : CKECBDNFIAF
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ICIDCBOPNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string COPBDEGIIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NIPIJGHHALO BEJEKMBKPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action HEDHFKBLFKG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x66E6AA0", Offset = "0x66E52A0", VA = "0x1866E6AA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x66E65C0", Offset = "0x66E4DC0", VA = "0x1866E65C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action KDFGENPHEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x66E68C0", Offset = "0x66E50C0", VA = "0x1866E68C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x66E6C80", Offset = "0x66E5480", VA = "0x1866E6C80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<OADCMGPMFIO> CDGAMCDHLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x66E6BD0", Offset = "0x66E53D0", VA = "0x1866E6BD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x66E6810", Offset = "0x66E5010", VA = "0x1866E6810", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public ODBPKNCKGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x66E6780", Offset = "0x66E4F80", VA = "0x1866E6780", Slot = "10")]
	public Task DIHNAABPOCM(string EPFOJCLNECJ, [Optional] BILGFNFMLLK OENIOELPLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x66E6960", Offset = "0x66E5160", VA = "0x1866E6960", Slot = "14")]
	public Task GMNFKIFKJFH(BILGFNFMLLK OENIOELPLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x66E6660", Offset = "0x66E4E60", VA = "0x1866E6660", Slot = "15")]
	public Task BLLOIFFEAEB(BILGFNFMLLK OENIOELPLPB, Dictionary<string, string> CKKFFLFEAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "16")]
	public bool MIJCGPJPJFG(string NIKFIFPEIFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x66E69F0", Offset = "0x66E51F0", VA = "0x1866E69F0", Slot = "17")]
	public FJGKCCGDGOG IBEDDABHIEI(string IEFFJCBNHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x66E66F0", Offset = "0x66E4EF0", VA = "0x1866E66F0", Slot = "18")]
	public OBBEMGLOCEK CMIMILPNLCE(string HNHDEDMOLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x66E6B40", Offset = "0x66E5340", VA = "0x1866E6B40", Slot = "19")]
	public Task JFEOJICGONL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal class FFKGAAAIDEM : NIPIJGHHALO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly EMIMKBPDMEA CAIAPHJIPIJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IReadOnlyDictionary<string, object> DFCKNBFBLGP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x11CA1E0", Offset = "0x11C89E0", VA = "0x1811CA1E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public FFKGAAAIDEM(EMIMKBPDMEA LLJEHIPFGOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface JBIDLOHBBCD
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLDCCCCAKOF MAAHDGDOGPC(string AHOOPNNKODA);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface MJABBPPPLNF
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum KKNEFNHCKLI
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	long FAKMGDOEAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string EKNDKCHCMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string CJOBFPHPDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool HHGNDKCPLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long HEAMBLIEEEJ();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EDMHIILJOHN(long MLGHAMNEBJP, bool GPHALNLKNCD = true);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DMGKNIEDKAF(string BHFMOMNKABO, string PJIOPKAOOOH, string ENLGLHDEKJC);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MDNELBMNNGN(string BHFMOMNKABO);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GLOGJNOFNAI(string BHFMOMNKABO, string BKLNGBEFGCK, string KGMBIKEOCHD);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BDECFDBNGLP(string KABMICCBEJG, object NHKHMFNGBEK, object BFNFPHFOJNO);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MEHGPIOEHBB(KKNEFNHCKLI IAFIMLHCNFB, int GBNKKMMAMGK, [Optional] AFIIAEICPKN DMNOMPEJLBG, [Optional] string JICDCKBEPIP, [Optional] string EBFMCGAMIGF);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HDJJECDLNLM(AFIIAEICPKN DMNOMPEJLBG, long CPNCKMPBAOC, long LJKIOCAHBJM, int JMLGFFENGOG, string JICDCKBEPIP, int GBNKKMMAMGK);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PBDNLJGDNOL(AFIIAEICPKN DMNOMPEJLBG, bool FEJOFHOJCCF, [Optional] string EBFMCGAMIGF);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NEEIPCNFGMN(AFIIAEICPKN DMNOMPEJLBG, bool FEJOFHOJCCF, [Optional] string EBFMCGAMIGF);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CFNPCNFEBAO(AFIIAEICPKN DMNOMPEJLBG, bool FEJOFHOJCCF, [Optional] string EBFMCGAMIGF);
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
