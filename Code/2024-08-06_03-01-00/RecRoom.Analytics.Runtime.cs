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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6833DF0", Offset = "0x68323F0", VA = "0x186833DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
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
		public AmplitudeAnalyticsClient.Settings FGBFHGNJAIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PFJOIHLPDCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8656E0", Offset = "0x863CE0", VA = "0x1808656E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum AIFMGAKJAGE
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class CILFAIMLKPO
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class PMGHCNMLHDD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				public int KCNKKEGFLKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public Dictionary<string, object> PEFAMCLBEBN;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
				public PMGHCNMLHDD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class LDKOMMELCEP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
				public LDKOMMELCEP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x6831FB0", Offset = "0x68305B0", VA = "0x186831FB0")]
				internal bool MOGPFIJIKLI(PMGHCNMLHDD item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private const string KAFNBKLIJKK = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly string DLMOEDNDKJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private List<PMGHCNMLHDD> AIMLAEABDME;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public int? HCOAJKLBFOO
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x682EAB0", Offset = "0x682D0B0", VA = "0x18682EAB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x682EB50", Offset = "0x682D150", VA = "0x18682EB50")]
			internal CILFAIMLKPO(string HJANPMHJBAD, string MEMPEEEGBMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x682E3F0", Offset = "0x682C9F0", VA = "0x18682E3F0")]
			public int KPELFGCPHBO([Optional] int? INOLBLHEAEH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x682DAC0", Offset = "0x682C0C0", VA = "0x18682DAC0")]
			public List<Dictionary<string, object>> CMHEPDBCHPG(int DPPHLMPINDC, int? INOLBLHEAEH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x682DA20", Offset = "0x682C020", VA = "0x18682DA20")]
			public void AJDLJDNBAEA(AmplitudeAnalyticsIdentifyMessage CDBNFNMIHPK, bool CGAEILPJGPC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x682D910", Offset = "0x682BF10", VA = "0x18682D910")]
			public void AJDLJDNBAEA(Dictionary<string, object> CDBNFNMIHPK, bool CGAEILPJGPC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x682DD30", Offset = "0x682C330", VA = "0x18682DD30")]
			public void HGOAJPEAPAC(params Dictionary<string, object>[] IFHKOPAPEED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x682DFB0", Offset = "0x682C5B0", VA = "0x18682DFB0")]
			public void IGGJMLFNMFK(List<Dictionary<string, object>> HJKCBBBBJNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x682DEB0", Offset = "0x682C4B0", VA = "0x18682DEB0")]
			private void IEOGPACDPIJ(Dictionary<string, object> CDBNFNMIHPK, bool CGAEILPJGPC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x682E1F0", Offset = "0x682C7F0", VA = "0x18682E1F0")]
			public void KILHJEAPPML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x682E6C0", Offset = "0x682CCC0", VA = "0x18682E6C0")]
			private void PINJELPACJC([Optional] string GCPAFBFNOEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x682E5A0", Offset = "0x682CBA0", VA = "0x18682E5A0")]
			private static string ODGABCIDIMB(string FEBGGALLBNN, string MNBFPOFIDHA)
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
			[Cpp2IlInjected.Address(RVA = "0x6835350", Offset = "0x6833950", VA = "0x186835350")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct MODBEMGIFHM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public int MLCLEJFLFIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public string MNONBILENKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T AKHHHKGGHEE;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class FFPEAKLOGKO : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private FDDBCEBEBAE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
			[DebuggerHidden]
			public FFPEAKLOGKO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6830490", Offset = "0x682EA90", VA = "0x186830490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6830C40", Offset = "0x682F240", VA = "0x186830C40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GLDIBBAKMBI : IEnumerator<object>, IEnumerator, IDisposable
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
			public FILOAGJMCDA quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
			[DebuggerHidden]
			public GLDIBBAKMBI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x68313C0", Offset = "0x682F9C0", VA = "0x1868313C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x68314D0", Offset = "0x682FAD0", VA = "0x1868314D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class PLGCPBPLIEK : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
			[DebuggerHidden]
			public PLGCPBPLIEK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x68344F0", Offset = "0x6832AF0", VA = "0x1868344F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6834660", Offset = "0x6832C60", VA = "0x186834660", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class MDDDPKPACDH : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private FDDBCEBEBAE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
			[DebuggerHidden]
			public MDDDPKPACDH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x68325E0", Offset = "0x6830BE0", VA = "0x1868325E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6832840", Offset = "0x6830E40", VA = "0x186832840", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class NPHDHFEBEAK : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private FDDBCEBEBAE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
			[DebuggerHidden]
			public NPHDHFEBEAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6833B50", Offset = "0x6832150", VA = "0x186833B50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6833DA0", Offset = "0x68323A0", VA = "0x186833DA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class NCCBIMFEGIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public CILFAIMLKPO cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public NCCBIMFEGIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6832890", Offset = "0x6830E90", VA = "0x186832890")]
			internal void JJJBLOJMHCN(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6832BA0", Offset = "0x68311A0", VA = "0x186832BA0")]
			internal void LBAMGJJKELH(MODBEMGIFHM<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class EJMILDFMNLI : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private FDDBCEBEBAE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CILFAIMLKPO cache;

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
			private NCCBIMFEGIE <>8__1;

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
			private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
			[DebuggerHidden]
			public EJMILDFMNLI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x682FC40", Offset = "0x682E240", VA = "0x18682FC40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6830440", Offset = "0x682EA40", VA = "0x186830440", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class BAOLIGEIIOL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public BAOLIGEIIOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x4ECF5D0", Offset = "0x4ECDBD0", VA = "0x184ECF5D0")]
			internal MODBEMGIFHM<T> FPIAPHDLJPC(KCKEBHDJGJP postResponse)
			{
				return default(MODBEMGIFHM<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KFDOLDGEEBK KIJLLIDDCJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<GHFBDKANFMN> GMPNLNHDELM;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string JBOFKPIBLDB = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string MBEIFGBBMBH = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string GDOCHMFCDIM = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int EDPFFFCLICA = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int AOFMBBFOABN = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int KDAALLBAGLP = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float IKCMLIJMFMD = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long DKIIOGFKDHI = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string FNPNKPHOMFI = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string MAHCDIEABKC = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string CIIKJCJOGIE = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string BGFLCPOALDP = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool LDLDEMCJBIE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool CIEIKHPMLBD;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int MIGJFNGKLPE;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int KLNDICADMDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PCDOCOBIONO FMCAAKKMKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private LNFFLOCKLNL HEKINDNDFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private FFGAFFIIPGJ GMLKIBFHCGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool OHGMGELGGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float FFIBBIMDDGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float GIKCDEHKNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int HJGPNFHBFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int CNJFIMDHKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? EMEINMJPCMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? ADIJOLMBCMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long EMDGKAOFEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string MGNPHGKAKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool FKIHFCKAJOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long BPHKIGNOIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string JFPNPKLJJIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string DPJDKHADNFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> PDPOBMAJBFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private AIFMGAKJAGE DCEKHIBLOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int AALMABBOOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int BBNBDDDKODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float ADIEONHCKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool CEPGKJLIEMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool AFGLNGPHJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CILFAIMLKPO MAEBNFBBLOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private CILFAIMLKPO LCEKJALHDPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CILFAIMLKPO IOHHKLHAEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string EKGIEHKCMPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> EKMBFHIJOOG;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo KAKFJKDBLJJ;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static string AMLIMLCBGKD;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string GCCMCIBHIBH = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly string HIOKOBOGGAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string MGBDMMJLHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string COHEPDENCPM;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private KFDOLDGEEBK FCAKOOLCBAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6827000", Offset = "0x6825600", VA = "0x186827000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private GHFBDKANFMN JBDBAJFAOAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6827CA0", Offset = "0x68262A0", VA = "0x186827CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int LEEPIJDEBDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x68299C0", Offset = "0x6827FC0", VA = "0x1868299C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long IHHANHIENCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x682B7C0", Offset = "0x6829DC0", VA = "0x18682B7C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x682B8D0", Offset = "0x6829ED0", VA = "0x18682B8D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string APACGDOFPHA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x682B790", Offset = "0x6829D90", VA = "0x18682B790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string BKLGOAGDPIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9A5450", Offset = "0x9A3A50", VA = "0x1809A5450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xC72280", Offset = "0xC70880", VA = "0x180C72280")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int? NGJHHFGEPCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9A5460", Offset = "0x9A3A60", VA = "0x1809A5460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x17AE4E0", Offset = "0x17ACAE0", VA = "0x1817AE4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CADDJNHFBJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x12013E0", Offset = "0x11FF9E0", VA = "0x1812013E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1246530", Offset = "0x1244B30", VA = "0x181246530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool CIBDBPMANMP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x682B660", Offset = "0x6829C60", VA = "0x18682B660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> NINCJJJNLCO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x682B5A0", Offset = "0x6829BA0", VA = "0x18682B5A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x682B810", Offset = "0x6829E10", VA = "0x18682B810")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6825EE0", Offset = "0x68244E0", VA = "0x186825EE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68271C0", Offset = "0x68257C0", VA = "0x1868271C0")]
		private void HEPMNHEBMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x682AB90", Offset = "0x6829190", VA = "0x18682AB90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6828790", Offset = "0x6826D90", VA = "0x186828790", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x682AF30", Offset = "0x6829530", VA = "0x18682AF30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6829B90", Offset = "0x6828190", VA = "0x186829B90")]
		public MKEIEIBMPOE PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6827C10", Offset = "0x6826210", VA = "0x186827C10")]
		[IteratorStateMachine(typeof(FFPEAKLOGKO))]
		public IEnumerator<FDDBCEBEBAE> InitializeForLocalAccount(AmplitudeAnalyticsEvent HMPKGCLDJHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x682A350", Offset = "0x6828950", VA = "0x18682A350")]
		public void SendAppEnterEvent(bool GHFFNOINGMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x682AE70", Offset = "0x6829470", VA = "0x18682AE70")]
		public void UpdateLastKnownInteractionCategory(string FPFBIJKOCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x682AD80", Offset = "0x6829380", VA = "0x18682AD80")]
		public void UpdateLastAliveTime(float KNACCMPDNHB = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68265B0", Offset = "0x6824BB0", VA = "0x1868265B0")]
		private MKEIEIBMPOE CBIKEDDHJEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68268B0", Offset = "0x6824EB0", VA = "0x1868268B0")]
		private MKEIEIBMPOE DCHKCBNLLOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x682A5F0", Offset = "0x6828BF0", VA = "0x18682A5F0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6826520", Offset = "0x6824B20", VA = "0x186826520")]
		[IteratorStateMachine(typeof(GLDIBBAKMBI))]
		private IEnumerator BJBAGFLPANG(FILOAGJMCDA NMCALOCOMBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x682B1C0", Offset = "0x68297C0", VA = "0x18682B1C0")]
		[IteratorStateMachine(typeof(PLGCPBPLIEK))]
		public IEnumerator WaitForFlush(float BKEMADGDEBK = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x682AC60", Offset = "0x6829260", VA = "0x18682AC60")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x682ABA0", Offset = "0x68291A0", VA = "0x18682ABA0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime ECKAMDKCMCB)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6827760", Offset = "0x6825D60", VA = "0x186827760")]
		public static HNGJMHODHEB Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6825D70", Offset = "0x6824370", VA = "0x186825D70")]
		public static GMLEINDPNPE AccountSelectionPostLoginEvent([NotNull] string GGPKLALBFHP, string CFPBMLMOKEI, bool CPBPCOEEGAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6826C80", Offset = "0x6825280", VA = "0x186826C80")]
		public static GMLEINDPNPE Event([NotNull] string GGPKLALBFHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6829BD0", Offset = "0x68281D0", VA = "0x186829BD0")]
		public static GMLEINDPNPE PreviousSessionEvent([NotNull] string GGPKLALBFHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6827900", Offset = "0x6825F00", VA = "0x186827900")]
		public static GMLEINDPNPE InitializeEvent(string CFPBMLMOKEI, int JAFDHJKIDLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x682A7B0", Offset = "0x6828DB0", VA = "0x18682A7B0")]
		public static GMLEINDPNPE StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6826660", Offset = "0x6824C60", VA = "0x186826660")]
		public static GMLEINDPNPE CreateOutOfSessionEvent(string GGPKLALBFHP, bool HKELMOAOEBJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6828150", Offset = "0x6826750", VA = "0x186828150")]
		public static MKEIEIBMPOE LogOutOfSessionEvent(GMLEINDPNPE DBKCGGDFPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6827EF0", Offset = "0x68264F0", VA = "0x186827EF0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent JKAHNFLBJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6828320", Offset = "0x6826920", VA = "0x186828320")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent JKAHNFLBJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6828450", Offset = "0x6826A50", VA = "0x186828450")]
		public void LogSerializedEventAsync(Dictionary<string, object> DLJCJDIMMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6828020", Offset = "0x6826620", VA = "0x186828020")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage FIEEEJAPJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6827070", Offset = "0x6825670", VA = "0x186827070")]
		private void GNGBELFFNLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x68288E0", Offset = "0x6826EE0", VA = "0x1868288E0")]
		private void PGHIDHHMJPH(Dictionary<string, object> FLPFLCGJPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6827CF0", Offset = "0x68262F0", VA = "0x186827CF0")]
		private void JHBJFJDBADI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6828530", Offset = "0x6826B30", VA = "0x186828530")]
		private void MICLKLAFJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6826F70", Offset = "0x6825570", VA = "0x186826F70")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6828840", Offset = "0x6826E40", VA = "0x186828840")]
		[IteratorStateMachine(typeof(MDDDPKPACDH))]
		private IEnumerator<FDDBCEBEBAE> PAPPALFHAKA(float BKEMADGDEBK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6828700", Offset = "0x6826D00", VA = "0x186828700")]
		[IteratorStateMachine(typeof(NPHDHFEBEAK))]
		private IEnumerator<FDDBCEBEBAE> MJDJCCNCPAI(float BKEMADGDEBK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6826BA0", Offset = "0x68251A0", VA = "0x186826BA0")]
		[IteratorStateMachine(typeof(EJMILDFMNLI))]
		private IEnumerator<FDDBCEBEBAE> DHAONJHNNIP(CILFAIMLKPO GIPKBENJJKM, int? INOLBLHEAEH, string FFMHLAPDEJI, float BKEMADGDEBK, Action<int> BHMLNMFCAAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6827DE0", Offset = "0x68263E0", VA = "0x186827DE0")]
		private static void JIMFEECCDNA(bool IDNGKLFLLHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6825CA0", Offset = "0x68242A0", VA = "0x186825CA0")]
		private DNKNPFLFPMI<MODBEMGIFHM<Dictionary<string, object>>> AODFOHDFCEA(string FFMHLAPDEJI, string HNACKJDOLHB, Dictionary<string, object> AKHHHKGGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6825A30", Offset = "0x6824030", VA = "0x186825A30")]
		private DNKNPFLFPMI<MODBEMGIFHM<List<Dictionary<string, object>>>> AODFOHDFCEA(string FFMHLAPDEJI, string HNACKJDOLHB, List<Dictionary<string, object>> AKHHHKGGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x32474C0", Offset = "0x3245AC0", VA = "0x1832474C0")]
		private DNKNPFLFPMI<MODBEMGIFHM<T>> DOFEGEFHAJN<T>(string JLIMHBIBPCP, string FFMHLAPDEJI, string HNACKJDOLHB, T AKHHHKGGHEE, Dictionary<string, object> KGDJEBILAKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6827170", Offset = "0x6825770", VA = "0x186827170")]
		private bool HAGAECPCAIL(float CIOIJMFDMLL, float BKEMADGDEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6828CF0", Offset = "0x68272F0", VA = "0x186828CF0")]
		private Dictionary<string, object> PLPCHAFCFNA(string FFMHLAPDEJI, Dictionary<string, object> AKHHHKGGHEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x682B2B0", Offset = "0x68298B0", VA = "0x18682B2B0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6828B90", Offset = "0x6827190", VA = "0x186828B90")]
		[CompilerGenerated]
		private long PGPGHAKKJMH()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68288D0", Offset = "0x6826ED0", VA = "0x1868288D0")]
		[CompilerGenerated]
		private void PDFEDKENFEH(int JLLCEGKNEGE)
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
			[Cpp2IlInjected.Address(RVA = "0x682C610", Offset = "0x682AC10", VA = "0x18682C610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x682C6E0", Offset = "0x682ACE0", VA = "0x18682C6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x682C650", Offset = "0x682AC50", VA = "0x18682C650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x682C730", Offset = "0x682AD30", VA = "0x18682C730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x682C5D0", Offset = "0x682ABD0", VA = "0x18682C5D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x682C690", Offset = "0x682AC90", VA = "0x18682C690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8656F0", Offset = "0x863CF0", VA = "0x1808656F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x682C130", Offset = "0x682A730", VA = "0x18682C130")]
		public static GMLEINDPNPE KKJEMJBKDLP(string PKICDAADPKG, [NotNull] string ADDIDHNNDFP, long AGNGLGAAPJN, long KGEDLAKGIAM, string CFPBMLMOKEI, bool CPBPCOEEGAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x682BAB0", Offset = "0x682A0B0", VA = "0x18682BAB0")]
		public static GMLEINDPNPE FIEMBANGMCG(string PKICDAADPKG, [NotNull] string ADDIDHNNDFP, long AGNGLGAAPJN, long KGEDLAKGIAM, string CFPBMLMOKEI, long OBIFNFJGHBC, bool CPBPCOEEGAN, string MBKFGPABEOH, string EJANFKBPGKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x682C440", Offset = "0x682AA40", VA = "0x18682C440")]
		private AmplitudeAnalyticsEvent(string PKICDAADPKG, [NotNull] string ADDIDHNNDFP, long AGNGLGAAPJN, long KGEDLAKGIAM, string CFPBMLMOKEI, bool CPBPCOEEGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1DB49F0", Offset = "0x1DB2FF0", VA = "0x181DB49F0")]
		public void PBDLFMOFKEC(long FFPFLCDMBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x682C340", Offset = "0x682A940", VA = "0x18682C340", Slot = "5")]
		public override void OPKGPMMJEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x682B930", Offset = "0x6829F30", VA = "0x18682B930", Slot = "6")]
		public override void BFOBCAGKBGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x682BC10", Offset = "0x682A210", VA = "0x18682BC10", Slot = "4")]
		protected override Dictionary<string, object> GFFANCNAIPJ(Dictionary<string, object> DLGIFJOMNGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x682C230", Offset = "0x682A830", VA = "0x18682C230")]
		private void NLHBAAMHJCE(string MNBFPOFIDHA, string FEBGGALLBNN, bool AMHGAIHCDML = false)
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
			[Cpp2IlInjected.Address(RVA = "0x682F610", Offset = "0x682DC10", VA = "0x18682F610")]
			public void DONNFGGLHBD(Dictionary<string, object> GABJNPJHJDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6834FE0", Offset = "0x68335E0", VA = "0x186834FE0")]
			public void DONNFGGLHBD(Dictionary<string, object> ECEFDGKFMJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xB6DCC0", Offset = "0xB6C2C0", VA = "0x180B6DCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x682CC50", Offset = "0x682B250", VA = "0x18682CC50")]
		public static HNGJMHODHEB KKJEMJBKDLP(string PKICDAADPKG, string CFPBMLMOKEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x682CE30", Offset = "0x682B430", VA = "0x18682CE30")]
		protected AmplitudeAnalyticsIdentifyMessage(string PKICDAADPKG, string CFPBMLMOKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x682CD10", Offset = "0x682B310", VA = "0x18682CD10")]
		public Dictionary<string, object> LBIGHDBADHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x682C8A0", Offset = "0x682AEA0", VA = "0x18682C8A0", Slot = "4")]
		protected virtual Dictionary<string, object> GFFANCNAIPJ(Dictionary<string, object> DLGIFJOMNGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x682C800", Offset = "0x682AE00", VA = "0x18682C800")]
		protected void EAJMNMAFLGI(string MNBFPOFIDHA, Dictionary<string, object> ALBPFOKENHD, Dictionary<string, object> EJPNHFJJJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x682CBE0", Offset = "0x682B1E0", VA = "0x18682CBE0")]
		protected void IFGDCPEPPJF(string MNBFPOFIDHA, string FEBGGALLBNN, Dictionary<string, object> DFMFEIPHIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x682CDA0", Offset = "0x682B3A0", VA = "0x18682CDA0", Slot = "5")]
		public virtual void OPKGPMMJEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x682C780", Offset = "0x682AD80", VA = "0x18682C780", Slot = "6")]
		public virtual void BFOBCAGKBGL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HNGJMHODHEB : FHPBHPKNCEE<AmplitudeAnalyticsIdentifyMessage, HNGJMHODHEB>
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public override HNGJMHODHEB GDIBJHEIFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage HICNKOFMHHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6831940", Offset = "0x682FF40", VA = "0x186831940")]
	public HNGJMHODHEB(AmplitudeAnalyticsIdentifyMessage DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x68318A0", Offset = "0x682FEA0", VA = "0x1868318A0", Slot = "4")]
	public override void BFOBCAGKBGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GMLEINDPNPE : FHPBHPKNCEE<AmplitudeAnalyticsEvent, GMLEINDPNPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool PAIAHPGICGF;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override GMLEINDPNPE GDIBJHEIFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public long CKKEGPCGCJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6831750", Offset = "0x682FD50", VA = "0x186831750")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x682D8C0", Offset = "0x682BEC0", VA = "0x18682D8C0")]
	public GMLEINDPNPE(AmplitudeAnalyticsEvent DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0", Slot = "5")]
	public override AmplitudeAnalyticsEvent HICNKOFMHHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6831520", Offset = "0x682FB20", VA = "0x186831520", Slot = "4")]
	public override void BFOBCAGKBGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2B738E0", Offset = "0x2B71EE0", VA = "0x182B738E0")]
	public GMLEINDPNPE DJOEEFFKLBP<T>(string MLBHCALGJAO, T[] FEBGGALLBNN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2B738E0", Offset = "0x2B71EE0", VA = "0x182B738E0")]
	public GMLEINDPNPE DJOEEFFKLBP(string MLBHCALGJAO, string[] FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2B73630", Offset = "0x2B71C30", VA = "0x182B73630")]
	public GMLEINDPNPE DJOEEFFKLBP<T>(string MLBHCALGJAO, T FEBGGALLBNN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6831660", Offset = "0x682FC60", VA = "0x186831660")]
	public GMLEINDPNPE DJOEEFFKLBP(string MLBHCALGJAO, long FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x68316E0", Offset = "0x682FCE0", VA = "0x1868316E0")]
	public GMLEINDPNPE DJOEEFFKLBP(string MLBHCALGJAO, string FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6831770", Offset = "0x682FD70", VA = "0x186831770")]
	public GMLEINDPNPE PCDGLGGAAAG(string MLBHCALGJAO, object? FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x68315C0", Offset = "0x682FBC0", VA = "0x1868315C0")]
	public GMLEINDPNPE CMKPGKOBIEP(string MLBHCALGJAO, string FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x68317A0", Offset = "0x682FDA0", VA = "0x1868317A0")]
	private GMLEINDPNPE PFGLOFGCGEC(string MLBHCALGJAO, object FEBGGALLBNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BNFHJPHFOHP : GMLEINDPNPE
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x682D8C0", Offset = "0x682BEC0", VA = "0x18682D8C0")]
	public BNFHJPHFOHP(AmplitudeAnalyticsEvent DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x682D710", Offset = "0x682BD10", VA = "0x18682D710", Slot = "4")]
	public override void BFOBCAGKBGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class FHPBHPKNCEE<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : FHPBHPKNCEE<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M DICMABMCPKO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract BLDR GDIBJHEIFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public FHPBHPKNCEE(M DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B570", Offset = "0x3B99B70", VA = "0x183B9B570")]
	public BLDR GKIOKKNMLKE(AmplitudeAnalyticsIdentifyMessage.DeviceInfo PAIJEBGCCDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B5C0", Offset = "0x3B99BC0", VA = "0x183B9B5C0")]
	public BLDR JMGNBJOCOPL(AmplitudeAnalyticsIdentifyMessage.RevenueData JKJGDLDGNKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B3C0", Offset = "0x3B999C0", VA = "0x183B9B3C0")]
	public BLDR AJAJKIIOKPM(string MLBHCALGJAO, string FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2878E50", Offset = "0x2877450", VA = "0x182878E50")]
	public BLDR AJAJKIIOKPM<T>(string MLBHCALGJAO, T FEBGGALLBNN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BFOBCAGKBGL();

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B610", Offset = "0x3B99C10", VA = "0x183B9B610")]
	internal static string MBEBCJONIBA(string FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B470", Offset = "0x3B99A70", VA = "0x183B9B470")]
	private BLDR BOCKGGBCCFP(string MLBHCALGJAO, object FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M HICNKOFMHHI();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class OOHCAKBABBJ : PCDOCOBIONO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct NKEIDKJNJKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<KCKEBHDJGJP> <>t__builder;

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
		public OOHCAKBABBJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x68330C0", Offset = "0x68316C0", VA = "0x1868330C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6833AE0", Offset = "0x68320E0", VA = "0x186833AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient KHINKHMEGOP;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6834260", Offset = "0x6832860", VA = "0x186834260")]
	[CCEDJDOPMOE(CFIDNIINJOK.None)]
	private static void NGGICLDEPPM(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x68342D0", Offset = "0x68328D0", VA = "0x1868342D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OOHCAKBABBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x68340F0", Offset = "0x68326F0", VA = "0x1868340F0", Slot = "4")]
	[AsyncStateMachine(typeof(NKEIDKJNJKH))]
	public Task<KCKEBHDJGJP> CCMEAGJIBAG(string JLIMHBIBPCP, string PEGDKKBNIBK, string CFLDLLALPJA, string OIEKIIBPINH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class IJAODNJONMP : PCDOCOBIONO
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NIKFFFNOHAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TaskCompletionSource<KCKEBHDJGJP> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NIKFFFNOHAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6832FE0", Offset = "0x68315E0", VA = "0x186832FE0")]
		internal void HJKMHIFGPAJ(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct LMCOEGCLAHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<KCKEBHDJGJP> <>t__builder;

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
		private TaskAwaiter<KCKEBHDJGJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6832020", Offset = "0x6830620", VA = "0x186832020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6832570", Offset = "0x6830B70", VA = "0x186832570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	[CCEDJDOPMOE(CFIDNIINJOK.None)]
	private static void PEOFCMMAGIG(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IJAODNJONMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6831990", Offset = "0x682FF90", VA = "0x186831990", Slot = "4")]
	[AsyncStateMachine(typeof(LMCOEGCLAHG))]
	public Task<KCKEBHDJGJP> CCMEAGJIBAG(string JLIMHBIBPCP, string PEGDKKBNIBK, string CFLDLLALPJA, string OIEKIIBPINH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PKBNJHAMHIH
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> DBCFKMLJLJC;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6834350", Offset = "0x6832950", VA = "0x186834350")]
	internal static bool OEIBJMOMCNC(string MNBFPOFIDHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PCDOCOBIONO
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KCKEBHDJGJP> CCMEAGJIBAG(string JLIMHBIBPCP, string PEGDKKBNIBK, string CFLDLLALPJA, string OIEKIIBPINH);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct KCKEBHDJGJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly int IJDFBNFMGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly string FPEPLBJNCCM;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0xEB3A60", Offset = "0xEB2060", VA = "0x180EB3A60")]
	public KCKEBHDJGJP(int MLCLEJFLFIE, string MNONBILENKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum POPIIAFENOM
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
public class DFIIFHDMJGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private long IDPNEEECICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private GMLEINDPNPE EECCPDJPAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool CDABGKDNGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float LOJAJKODLKE;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x682F480", Offset = "0x682DA80", VA = "0x18682F480")]
	public DFIIFHDMJGP(string DKNKEFHHHDG, float LOJAJKODLKE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x29A1EC0", Offset = "0x29A04C0", VA = "0x1829A1EC0")]
	public void DJOEEFFKLBP<T>(string MLBHCALGJAO, T FEBGGALLBNN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x682F2A0", Offset = "0x682D8A0", VA = "0x18682F2A0")]
	public void DJOEEFFKLBP(string MLBHCALGJAO, string FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x682F1B0", Offset = "0x682D7B0", VA = "0x18682F1B0")]
	public void CDPHGMOJFFM(string HODGFGCOLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x682F0F0", Offset = "0x682D6F0", VA = "0x18682F0F0")]
	public void AIEIEFIPGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x682F320", Offset = "0x682D920", VA = "0x18682F320")]
	private void GLNIFKFBOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x682F430", Offset = "0x682DA30", VA = "0x18682F430")]
	private bool PHIBNJGJFEJ()
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
		public enum OHDBCGNBMPO
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
		private OHDBCGNBMPO parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public OHDBCGNBMPO Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x998B00", Offset = "0x997100", VA = "0x180998B00")]
			get
			{
				return default(OHDBCGNBMPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xA7A3C0", Offset = "0xA789C0", VA = "0x180A7A3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6835150", Offset = "0x6833750", VA = "0x186835150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class OJDKOANEKHH : FOOECFICNGH, HEPDEJJEPGP
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void FIGMFLAKLAB(IDDFEOAEJOB NEDCBDOJICE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly FJPJDIPLKNO KGJBGODGLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly FIGMFLAKLAB BIAOPCFDJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string PKLHKHILAEO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string OEEDIBADLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x13091D0", Offset = "0x13077D0", VA = "0x1813091D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool GDCJBPJKIKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6833E70", Offset = "0x6832470", VA = "0x186833E70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool ANNMEAGGCAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6833E90", Offset = "0x6832490", VA = "0x186833E90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<string> GFBMCOMMAKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1308E70", Offset = "0x1307470", VA = "0x181308E70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6833EB0", Offset = "0x68324B0", VA = "0x186833EB0")]
	public OJDKOANEKHH(FJPJDIPLKNO AHDGGDAMLGE, string BCMHPHBJEIM, [Optional] FIGMFLAKLAB JJCHJBPEJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7C50", Offset = "0x2CE6250", VA = "0x182CE7C50", Slot = "8")]
	public T BJJBEHDKBAF<T>(string MNBFPOFIDHA, T PBAONJMDGEK)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class AJNCACANJFM : BBFOFLHBLBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct GFDHFFLILOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public LNFFLOCKLNL userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AJNCACANJFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6830C90", Offset = "0x682F290", VA = "0x186830C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6831360", Offset = "0x682F960", VA = "0x186831360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct EIKCNKLPCOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x682F9D0", Offset = "0x682DFD0", VA = "0x18682F9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x682FBE0", Offset = "0x682E1E0", VA = "0x18682FBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct KLEEAOMMCOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public LNFFLOCKLNL userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AJNCACANJFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6831AF0", Offset = "0x68300F0", VA = "0x186831AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6831F50", Offset = "0x6830550", VA = "0x186831F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct CMOFCICKEBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AJNCACANJFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public LNFFLOCKLNL userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x682ECC0", Offset = "0x682D2C0", VA = "0x18682ECC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x682F090", Offset = "0x682D690", VA = "0x18682F090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly IReadOnlyDictionary<string, BHMKMMHOMGD> LFFOEGDCMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool HJPCOAKIEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool JKKLDHGHBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private TaskCompletionSource<bool> MJAIMMFEJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private TaskCompletionSource<bool> EDCNDKHICFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private GMCEIKLKLNF KMAAFEJFPBH;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Task JMGKAJOEPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6824910", Offset = "0x6822F10", VA = "0x186824910", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool LOFEJJLJJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2A0", Offset = "0x8AD8A0", VA = "0x1808AF2A0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool MKEBHMHNLED
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xC5F2F0", Offset = "0xC5D8F0", VA = "0x180C5F2F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string BKLGOAGDPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6825440", Offset = "0x6823A40", VA = "0x186825440", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FGFGKMMLECO NOMFDBNEJOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6825610", Offset = "0x6823C10", VA = "0x186825610", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JINMLDNGPOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6823E10", Offset = "0x6822410", VA = "0x186823E10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6823EB0", Offset = "0x68224B0", VA = "0x186823EB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action OMCMPCLOICD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6824870", Offset = "0x6822E70", VA = "0x186824870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6823C80", Offset = "0x6822280", VA = "0x186823C80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DFFCJHLIHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6823F50", Offset = "0x6822550", VA = "0x186823F50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6825640", Offset = "0x6823C40", VA = "0x186825640", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<IDDFEOAEJOB> GNCAHCMLFFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x68243E0", Offset = "0x68229E0", VA = "0x1868243E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6823D20", Offset = "0x6822320", VA = "0x186823D20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6824750", Offset = "0x6822D50", VA = "0x186824750", Slot = "12")]
	[AsyncStateMachine(typeof(GFDHFFLILOH))]
	public Task HGDANEHJCNG(string MEMPEEEGBMD, [Optional] LNFFLOCKLNL ABJMKCJGBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6824330", Offset = "0x6822930", VA = "0x186824330", Slot = "23")]
	[AsyncStateMachine(typeof(EIKCNKLPCOC))]
	public Task FJFEOEPJCBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6824490", Offset = "0x6822A90", VA = "0x186824490", Slot = "18")]
	[AsyncStateMachine(typeof(KLEEAOMMCOO))]
	public Task GOPBAGNHNLH(LNFFLOCKLNL ABJMKCJGBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6825770", Offset = "0x6823D70", VA = "0x186825770")]
	private void PJBGBFBAMLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6823FF0", Offset = "0x68225F0", VA = "0x186823FF0", Slot = "19")]
	[AsyncStateMachine(typeof(CMOFCICKEBN))]
	public Task EEIAOMPPOMB(LNFFLOCKLNL ABJMKCJGBOF, Dictionary<string, string> BHNBCCEIEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x68256E0", Offset = "0x6823CE0", VA = "0x1868256E0", Slot = "20")]
	public bool PHNPDCLAHFD(string DPIKBBGEHEI, bool HPHCKIAMMGO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6824590", Offset = "0x6822B90", VA = "0x186824590", Slot = "21")]
	public FOOECFICNGH HDHBALAMFEF(string BCMHPHBJEIM, bool HPHCKIAMMGO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6825450", Offset = "0x6823A50", VA = "0x186825450")]
	private FJPJDIPLKNO NNOBOOABCPJ(string BCMHPHBJEIM, bool HPHCKIAMMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6825290", Offset = "0x6823890", VA = "0x186825290", Slot = "22")]
	public AJHCDAGNBOF KBLDKCPBDOH(string NHKDOCGIOAK, bool HPHCKIAMMGO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x68242A0", Offset = "0x68228A0", VA = "0x1868242A0")]
	private NCEKNGEONOJ FEPKMLOKAGO(string NHKDOCGIOAK, bool HPHCKIAMMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6824950", Offset = "0x6822F50", VA = "0x186824950")]
	private GEIFDLPILBB KAGIOGJMELN(LNFFLOCKLNL ABJMKCJGBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6824100", Offset = "0x6822700", VA = "0x186824100")]
	private PFOOLIKDDDO ENGNDOIOOFK(string MEMPEEEGBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6823B70", Offset = "0x6822170", VA = "0x186823B70")]
	private void BELHNFECBNF(string BCMHPHBJEIM, FJPJDIPLKNO AHDGGDAMLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6825970", Offset = "0x6823F70", VA = "0x186825970")]
	public AJNCACANJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6823DD0", Offset = "0x68223D0", VA = "0x186823DD0")]
	[CompilerGenerated]
	private void CNAIFIEPAKN(IDDFEOAEJOB IIMGHHPJFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6823DD0", Offset = "0x68223D0", VA = "0x186823DD0")]
	[CompilerGenerated]
	private void HPNPLCBLKMM(IDDFEOAEJOB IIMGHHPJFMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class ADEAGHAFEMM : BBFOFLHBLBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BANGDMMDCPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public ADEAGHAFEMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public LNFFLOCKLNL userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x682CEF0", Offset = "0x682B4F0", VA = "0x18682CEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x682D6B0", Offset = "0x682BCB0", VA = "0x18682D6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct EHMJNJGBEOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x682F790", Offset = "0x682DD90", VA = "0x18682F790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private BBFOFLHBLBK JIONOBGNJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private TaskCompletionSource<bool> MJAIMMFEJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private TaskCompletionSource<bool> EDCNDKHICFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Task BKHNHGHICLN;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private BBFOFLHBLBK MBBFMFILBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6823730", Offset = "0x6821D30", VA = "0x186823730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MKEBHMHNLED
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6822790", Offset = "0x6820D90", VA = "0x186822790", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LOFEJJLJJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6823550", Offset = "0x6821B50", VA = "0x186823550", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task JMGKAJOEPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x68232F0", Offset = "0x68218F0", VA = "0x1868232F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string BKLGOAGDPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x68237A0", Offset = "0x6821DA0", VA = "0x1868237A0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public FGFGKMMLECO NOMFDBNEJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6823830", Offset = "0x6821E30", VA = "0x186823830", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action OMCMPCLOICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6823250", Offset = "0x6821850", VA = "0x186823250", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x68229D0", Offset = "0x6820FD0", VA = "0x1868229D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action JINMLDNGPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6822B20", Offset = "0x6821120", VA = "0x186822B20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6822BC0", Offset = "0x68211C0", VA = "0x186822BC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action DFFCJHLIHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6822C60", Offset = "0x6821260", VA = "0x186822C60", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x68238F0", Offset = "0x6821EF0", VA = "0x1868238F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<IDDFEOAEJOB> GNCAHCMLFFF
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6822EC0", Offset = "0x68214C0", VA = "0x186822EC0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6822A70", Offset = "0x6821070", VA = "0x186822A70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6823AB0", Offset = "0x68220B0", VA = "0x186823AB0")]
	[UnityEngine.Scripting.Preserve]
	public ADEAGHAFEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x68234E0", Offset = "0x6821AE0", VA = "0x1868234E0")]
	[CCEDJDOPMOE(CFIDNIINJOK.GameOnly)]
	private static void IPDGANODBNB(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x68227E0", Offset = "0x6820DE0", VA = "0x1868227E0")]
	[CCEDJDOPMOE(CFIDNIINJOK.EditorOnly)]
	private static void AKODHJLAHNE(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6823140", Offset = "0x6821740", VA = "0x186823140", Slot = "12")]
	[AsyncStateMachine(typeof(BANGDMMDCPD))]
	public Task HGDANEHJCNG(string MEMPEEEGBMD, [Optional] LNFFLOCKLNL ABJMKCJGBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6822F70", Offset = "0x6821570", VA = "0x186822F70", Slot = "18")]
	public Task GOPBAGNHNLH(LNFFLOCKLNL ABJMKCJGBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6822D00", Offset = "0x6821300", VA = "0x186822D00", Slot = "19")]
	public Task EEIAOMPPOMB(LNFFLOCKLNL ABJMKCJGBOF, Dictionary<string, string> BHNBCCEIEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6823990", Offset = "0x6821F90", VA = "0x186823990", Slot = "20")]
	public bool PHNPDCLAHFD(string DPIKBBGEHEI, bool HPHCKIAMMGO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6823080", Offset = "0x6821680", VA = "0x186823080", Slot = "21")]
	public FOOECFICNGH HDHBALAMFEF(string BCMHPHBJEIM, bool HPHCKIAMMGO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x68235A0", Offset = "0x6821BA0", VA = "0x1868235A0", Slot = "22")]
	public AJHCDAGNBOF KBLDKCPBDOH(string NHKDOCGIOAK, bool HPHCKIAMMGO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6822E20", Offset = "0x6821420", VA = "0x186822E20", Slot = "23")]
	public Task FJFEOEPJCBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6822850", Offset = "0x6820E50", VA = "0x186822850")]
	private static void BFEHGNNAHOF(TaskCompletionSource<bool> AGJALLMMGDC, Task BCMFDCLEDBK, Task JDCMKMFJBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6823660", Offset = "0x6821C60", VA = "0x186823660")]
	[AsyncStateMachine(typeof(EHMJNJGBEOH))]
	private static void KGEOBEEIGDA(Task OOOMFPPINLE, TaskCompletionSource<bool> AGJALLMMGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x8A8AF0", Offset = "0x8A70F0", VA = "0x1808A8AF0")]
	[CompilerGenerated]
	private void DFJLCAHMJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xA4FDF0", Offset = "0xA4E3F0", VA = "0x180A4FDF0")]
	[CompilerGenerated]
	private void ANELBJJPIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xA544E0", Offset = "0xA52AE0", VA = "0x180A544E0")]
	[CompilerGenerated]
	private void JFCHBJELJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x68237F0", Offset = "0x6821DF0", VA = "0x1868237F0")]
	[CompilerGenerated]
	private void OEDDDHEOFJJ(IDDFEOAEJOB IIMGHHPJFMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class IIKIMGLLKBI : AJHCDAGNBOF, HEPDEJJEPGP
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate void GEJCKOGKNHF(IDDFEOAEJOB NEDCBDOJICE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly GEJCKOGKNHF BIAOPCFDJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly NCEKNGEONOJ GECLFKDNDGM;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string OEEDIBADLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1D79EE0", Offset = "0x1D784E0", VA = "0x181D79EE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F8D0", Offset = "0x5B7DED0", VA = "0x185B7F8D0")]
	public IIKIMGLLKBI(NCEKNGEONOJ ILAGHFEIHOD, [Optional] GEJCKOGKNHF JJCHJBPEJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2B9E2B0", Offset = "0x2B9C8B0", VA = "0x182B9E2B0", Slot = "5")]
	public T BJJBEHDKBAF<T>(string MNBFPOFIDHA, T PBAONJMDGEK)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface BNGOBPCNKAN
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[UsedImplicitly]
public class OMKJKHGAEGN : BNGOBPCNKAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly ENLCEFCAJLK LGPEHGMMCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly List<HCMBILKJFGE> KCGEHOMBNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly string FMDMIHBMBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly string DGLFKGLAPBB;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6833F20", Offset = "0x6832520", VA = "0x186833F20")]
	[CCEDJDOPMOE(GIKFHLNFMKF.Root, CFIDNIINJOK.GameOnly)]
	[UsedImplicitly]
	private static void DGJGMJJCAOC(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6833F90", Offset = "0x6832590", VA = "0x186833F90")]
	[RecRoom.NoEngine.Common.Preserve]
	internal OMKJKHGAEGN([JLPFJOFFNLM(null)][NotNull] ENLCEFCAJLK LGPEHGMMCBC, [NotNull][JLPFJOFFNLM(null)] CCIHNGBJOLE PGKJENLLMCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class PNNPNJPDPDD : BBFOFLHBLBK
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task JMGKAJOEPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6834E20", Offset = "0x6833420", VA = "0x186834E20", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool MKEBHMHNLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool LOFEJJLJJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string BKLGOAGDPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public FGFGKMMLECO NOMFDBNEJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action OMCMPCLOICD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6834D80", Offset = "0x6833380", VA = "0x186834D80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x68346B0", Offset = "0x6832CB0", VA = "0x1868346B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action JINMLDNGPOC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6834800", Offset = "0x6832E00", VA = "0x186834800", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x68348A0", Offset = "0x6832EA0", VA = "0x1868348A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action DFFCJHLIHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6834940", Offset = "0x6832F40", VA = "0x186834940", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6834F40", Offset = "0x6833540", VA = "0x186834F40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<IDDFEOAEJOB> GNCAHCMLFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6834B00", Offset = "0x6833100", VA = "0x186834B00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6834750", Offset = "0x6832D50", VA = "0x186834750", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PNNPNJPDPDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6834CF0", Offset = "0x68332F0", VA = "0x186834CF0", Slot = "12")]
	public Task HGDANEHJCNG(string MEMPEEEGBMD, [Optional] LNFFLOCKLNL ABJMKCJGBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6834BB0", Offset = "0x68331B0", VA = "0x186834BB0", Slot = "18")]
	public Task GOPBAGNHNLH(LNFFLOCKLNL ABJMKCJGBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x68349E0", Offset = "0x6832FE0", VA = "0x1868349E0", Slot = "19")]
	public Task EEIAOMPPOMB(LNFFLOCKLNL ABJMKCJGBOF, Dictionary<string, string> BHNBCCEIEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "20")]
	public bool PHNPDCLAHFD(string DPIKBBGEHEI, bool HPHCKIAMMGO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6834C40", Offset = "0x6833240", VA = "0x186834C40", Slot = "21")]
	public FOOECFICNGH HDHBALAMFEF(string BCMHPHBJEIM, bool HPHCKIAMMGO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6834EB0", Offset = "0x68334B0", VA = "0x186834EB0", Slot = "22")]
	public AJHCDAGNBOF KBLDKCPBDOH(string NHKDOCGIOAK, bool HPHCKIAMMGO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6834A70", Offset = "0x6833070", VA = "0x186834A70", Slot = "23")]
	public Task FJFEOEPJCBO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class GMCEIKLKLNF : FGFGKMMLECO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly GEIFDLPILBB NINGGCJPPNN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IReadOnlyDictionary<string, object> KBBNNNNIBGD
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x13093C0", Offset = "0x13079C0", VA = "0x1813093C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public GMCEIKLKLNF(GEIFDLPILBB KBLBFNMFHIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HICJKKDENBM
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DFIIFHDMJGP OCPCFLPOFAI(string DKNKEFHHHDG);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FFGAFFIIPGJ
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum HFHKGPLKIGM
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	long LPMBHFNNKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string FPBMMFCNNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string JFNCCIFHEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool JOFHGFEFALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long CHMMGININKE();

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CKOIJBGJFNB(long AGNGLGAAPJN, bool AMHGAIHCDML = true);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KBNPPNDJCBJ(string MGIHCPMKPNG, string MDMPNMPPEHD, string KKGLAJMELHH);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MNKIMEPCDOP(string MGIHCPMKPNG);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CAKFFBFDFGP(string MGIHCPMKPNG, string HBAAAOBNDDM, string PCCEOGOIOMD);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AGBDHHHHECE(string FNOBCMGGGAK, object PHIFLKPOJHA, object NPCAAJHNNND);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GIDECBPCAGB(HFHKGPLKIGM MHFDLOCNDIB, int JELOEPGHNLC, [Optional] PGOMGPDBMDM FDCJLOOIDMA, [Optional] string LFDNCCCLCHB, [Optional] string BDGJCBKBDPI);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OCMKOLMOLKI(PGOMGPDBMDM FDCJLOOIDMA, long EFMNMKIMFCN, long FHKPMGGAJEO, int NCPEKHGMNDB, string LFDNCCCLCHB, int JELOEPGHNLC);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IJKECKNACFG(PGOMGPDBMDM FDCJLOOIDMA, bool GCPCBKFMNEC, [Optional] string BDGJCBKBDPI);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LEFIBIGOAKI(PGOMGPDBMDM FDCJLOOIDMA, bool GCPCBKFMNEC, [Optional] string BDGJCBKBDPI);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BDBBPLJBLAI(PGOMGPDBMDM FDCJLOOIDMA, bool GCPCBKFMNEC, [Optional] string BDGJCBKBDPI);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OPBFPJPDJHK(long ECHGOOGHLEN, string FMIIICIOIJC);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PEGMICPCKLB
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string GFCCAIFBLGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
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
