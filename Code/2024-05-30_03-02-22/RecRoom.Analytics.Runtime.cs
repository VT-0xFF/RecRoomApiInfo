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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x628BFF0", Offset = "0x628B1F0", VA = "0x18628BFF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
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
		public AmplitudeAnalyticsClient.Settings GNPHFBHCMLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GMGECLEFHDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7CEA50", Offset = "0x7CDC50", VA = "0x1807CEA50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum LBOHJNJNCBN
		{
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class ECGBBGBOBFF
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class OLIHGFMFFHF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int JDKHNINIPJI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				public Dictionary<string, object> PMDHLCNFIAM;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
				public OLIHGFMFFHF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class LKJKIPNIPHM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
				public LKJKIPNIPHM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x628B220", Offset = "0x628A420", VA = "0x18628B220")]
				internal bool MICIGDNENKM(OLIHGFMFFHF item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private const string KDANHKGPOEB = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private readonly string JGJLFCNOJON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private List<OLIHGFMFFHF> KFAFLIPEFFE;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public int? OMDOJPBMJFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x6285AD0", Offset = "0x6284CD0", VA = "0x186285AD0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6286C40", Offset = "0x6285E40", VA = "0x186286C40")]
			internal ECGBBGBOBFF(string IEAFDLPKLIO, string LPBGNCMLLBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x62863C0", Offset = "0x62855C0", VA = "0x1862863C0")]
			public int ONOMEKGLHFC([Optional] int? EBJPDJFPGMH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x62869D0", Offset = "0x6285BD0", VA = "0x1862869D0")]
			public List<Dictionary<string, object>> PONJPFHDFIG(int JIEGBMHOFNL, int? EBJPDJFPGMH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6285C80", Offset = "0x6284E80", VA = "0x186285C80")]
			public void CBKANDJKDJB(AmplitudeAnalyticsIdentifyMessage CDJAKLIPEBF, bool CDEEKOHNPKP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6285B70", Offset = "0x6284D70", VA = "0x186285B70")]
			public void CBKANDJKDJB(Dictionary<string, object> CDJAKLIPEBF, bool CDEEKOHNPKP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6285940", Offset = "0x6284B40", VA = "0x186285940")]
			public void AFKNHCCDLOA(params Dictionary<string, object>[] HPLMENAEAMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6285D20", Offset = "0x6284F20", VA = "0x186285D20")]
			public void FMAJKLODHAG(List<Dictionary<string, object>> FNBLDHFGAOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x62862B0", Offset = "0x62854B0", VA = "0x1862862B0")]
			private void OAKDEDBFMGL(Dictionary<string, object> CDJAKLIPEBF, bool CDEEKOHNPKP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x62860A0", Offset = "0x62852A0", VA = "0x1862860A0")]
			public void KCHCHIJEAGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6286570", Offset = "0x6285770", VA = "0x186286570")]
			private void PAGPNHPEIIO([Optional] string AANNIDJDEKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6285F70", Offset = "0x6285170", VA = "0x186285F70")]
			private static string JDEBFNNOHLA(string HLCKBKFCMPI, string MNOIAMGNLNL)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x628EB60", Offset = "0x628DD60", VA = "0x18628EB60")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct CPEOEBOAHIN<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public int MLBLEKODFFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public string NIBELNDFJHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T FIHLINDOMFJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LFKLAHEDPEN : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private AEBIBAEBDOJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
			[DebuggerHidden]
			public LFKLAHEDPEN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x628AA10", Offset = "0x6289C10", VA = "0x18628AA10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x628B1D0", Offset = "0x628A3D0", VA = "0x18628B1D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JGDCLJNKHEM : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public MFGPODLAJFB quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
			[DebuggerHidden]
			public JGDCLJNKHEM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6289290", Offset = "0x6288490", VA = "0x186289290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x62893A0", Offset = "0x62885A0", VA = "0x1862893A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class KJNEIBHDPKF : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
			[DebuggerHidden]
			public KJNEIBHDPKF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6289E90", Offset = "0x6289090", VA = "0x186289E90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x628A000", Offset = "0x6289200", VA = "0x18628A000", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class DAKFEGGPJAK : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private AEBIBAEBDOJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
			[DebuggerHidden]
			public DAKFEGGPJAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6284740", Offset = "0x6283940", VA = "0x186284740", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x62849A0", Offset = "0x6283BA0", VA = "0x1862849A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class NJAAPELNFMA : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private AEBIBAEBDOJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
			[DebuggerHidden]
			public NJAAPELNFMA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x628BD40", Offset = "0x628AF40", VA = "0x18628BD40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x628BFA0", Offset = "0x628B1A0", VA = "0x18628BFA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class FCFHFAPCICO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public ECGBBGBOBFF cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<string> <>9__0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Action<CPEOEBOAHIN<List<Dictionary<string, object>>>> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public FCFHFAPCICO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x62872F0", Offset = "0x62864F0", VA = "0x1862872F0")]
			internal void IHAOOJLBNKF(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6286EA0", Offset = "0x62860A0", VA = "0x186286EA0")]
			internal void BEMHNIDDINJ(CPEOEBOAHIN<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class KNDLKHOBFFD : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private AEBIBAEBDOJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public ECGBBGBOBFF cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private FCFHFAPCICO <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private float <startTime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private bool <timedOut>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private int <batchSize>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
			[DebuggerHidden]
			public KNDLKHOBFFD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x628A050", Offset = "0x6289250", VA = "0x18628A050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x628A9C0", Offset = "0x6289BC0", VA = "0x18628A9C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class BLPNAAAKBHK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public BLPNAAAKBHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x4B02680", Offset = "0x4B01880", VA = "0x184B02680")]
			internal CPEOEBOAHIN<T> AAGJPPGJMIK(FJEPFIOBDGP postResponse)
			{
				return default(CPEOEBOAHIN<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private JFGFBDBIPIN GNAPBMFDOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<IEKPDOOCBJP> JFLKCBLLJGC;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string IOJALMFGPFH = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string EAMBAPEHNON = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string LCEFGFILCDH = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int MLLEPHJEFDI = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int KCMLNJGJKEN = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int GEKFPCDHICB = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float EKJNINLJBDF = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long HIKDGCJEENA = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string IJIPFDMFKHK = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string FNLCMLMNCPJ = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string DHEJKPOMKMN = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string DAGLIFCBNAB = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool ACGAPNOAJKO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool BNCMEKGIKPC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int LBKPNNDCPAG;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int HPNCCHLKLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private LKNDHHMIACG NCDGDFJFHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private CBMEANGGFNA FJHBFJFIBDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private NHBNGLAPCCE NGMLKLFLMLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool HBCEEMCPJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float LBHCAGOKODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float BFKHPKAHMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int JNBIBGPJLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int HKIBGKLNBPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? GGLDNAJIBFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? LMMLCJILHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long JICIHPDKKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string ODLGMDDAHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool BEPHDMPECED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long MNGGKOAKHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string FICJJJBIHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string DCADIHAGAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> LFMIANJOCNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private LBOHJNJNCBN OCKANENEJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int OJNOGEJGDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int JDHDCHFKPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float DDFIHCBAEPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool JDDHPCDDDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool MLPPGHMJHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private ECGBBGBOBFF JBOMDFFFBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private ECGBBGBOBFF DHDLKILGCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private ECGBBGBOBFF NNCEPMCBCMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> IDCIEFGCPOE;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo HBEKBLEMAAG;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static string PPDIIHOJBBA;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string LNFJCALGAGB = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string EHCCIDHPDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly string LBNDDCJFPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string HLGKBKPHCGA;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private JFGFBDBIPIN AKAHKJCAILC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x627F250", Offset = "0x627E450", VA = "0x18627F250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private IEKPDOOCBJP KOPOOJGCIDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x627DEC0", Offset = "0x627D0C0", VA = "0x18627DEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int FPALODGALLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6280250", Offset = "0x627F450", VA = "0x186280250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long ABNIPMHEFAL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6282CA0", Offset = "0x6281EA0", VA = "0x186282CA0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6282DC0", Offset = "0x6281FC0", VA = "0x186282DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string KPLIEEILDHB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6282C70", Offset = "0x6281E70", VA = "0x186282C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string OJBFMKIBMAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x979C20", Offset = "0x978E20", VA = "0x180979C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9797C0", Offset = "0x9789C0", VA = "0x1809797C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int? GLPLKOPLBKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x834F90", Offset = "0x834190", VA = "0x180834F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6282DB0", Offset = "0x6281FB0", VA = "0x186282DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool COBKLHPCEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x840900", Offset = "0x83FB00", VA = "0x180840900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x1087E20", Offset = "0x1087020", VA = "0x181087E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool COOGCAKPNHD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6282B80", Offset = "0x6281D80", VA = "0x186282B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> JIPHOCCBOLK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6282AC0", Offset = "0x6281CC0", VA = "0x186282AC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6282CF0", Offset = "0x6281EF0", VA = "0x186282CF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x627D6A0", Offset = "0x627C8A0", VA = "0x18627D6A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x627F990", Offset = "0x627EB90", VA = "0x18627F990")]
		private void JFPMPKAFAGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x62820A0", Offset = "0x62812A0", VA = "0x1862820A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6281150", Offset = "0x6280350", VA = "0x186281150", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6282440", Offset = "0x6281640", VA = "0x186282440")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6281370", Offset = "0x6280570", VA = "0x186281370")]
		public BNCJCHBDCBI PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x627F900", Offset = "0x627EB00", VA = "0x18627F900")]
		[IteratorStateMachine(typeof(LFKLAHEDPEN))]
		public IEnumerator<AEBIBAEBDOJ> Initialize(AmplitudeAnalyticsEvent BPGGFLHFOOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6282380", Offset = "0x6281580", VA = "0x186282380")]
		public void UpdateLastKnownInteractionCategory(string JBICJLPNKEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6282290", Offset = "0x6281490", VA = "0x186282290")]
		public void UpdateLastAliveTime(float ADBEIAHCPGL = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6280CB0", Offset = "0x627FEB0", VA = "0x186280CB0")]
		private BNCJCHBDCBI NOJLELJJGDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6280E60", Offset = "0x6280060", VA = "0x186280E60")]
		private BNCJCHBDCBI OPHLJABKKEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6281B00", Offset = "0x6280D00", VA = "0x186281B00")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x627E460", Offset = "0x627D660", VA = "0x18627E460")]
		[IteratorStateMachine(typeof(JGDCLJNKHEM))]
		private IEnumerator FOIACJDBOJN(MFGPODLAJFB FLFAKKCAIJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x62826D0", Offset = "0x62818D0", VA = "0x1862826D0")]
		[IteratorStateMachine(typeof(KJNEIBHDPKF))]
		public IEnumerator WaitForFlush(float HEEKNLGJGIH = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6282170", Offset = "0x6281370", VA = "0x186282170")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x62820B0", Offset = "0x62812B0", VA = "0x1862820B0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime BAPODJDPLNJ)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x627F440", Offset = "0x627E640", VA = "0x18627F440")]
		public static EKDMODEHDMI Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x627D530", Offset = "0x627C730", VA = "0x18627D530")]
		public static GCKEAKHLFFJ AccountSelectionPostLoginEvent([NotNull] string EMGGIECHHOA, string IJPBCGPKMHE, bool LFOLKBMJEMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x627E170", Offset = "0x627D370", VA = "0x18627E170")]
		public static GCKEAKHLFFJ Event([NotNull] string EMGGIECHHOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62813B0", Offset = "0x62805B0", VA = "0x1862813B0")]
		public static GCKEAKHLFFJ PreviousSessionEvent([NotNull] string EMGGIECHHOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x627F5E0", Offset = "0x627E7E0", VA = "0x18627F5E0")]
		public static GCKEAKHLFFJ InitializeEvent(string IJPBCGPKMHE, int EJLOHIJCALC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6281CC0", Offset = "0x6280EC0", VA = "0x186281CC0")]
		public static GCKEAKHLFFJ StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x627DF10", Offset = "0x627D110", VA = "0x18627DF10")]
		public static GCKEAKHLFFJ CreateOutOfSessionEvent(string EMGGIECHHOA, bool FMGIMIMHEND = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x62806A0", Offset = "0x627F8A0", VA = "0x1862806A0")]
		public static BNCJCHBDCBI LogOutOfSessionEvent(GCKEAKHLFFJ ONHHKPLEKII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6280420", Offset = "0x627F620", VA = "0x186280420")]
		public void LogEventAsync(AmplitudeAnalyticsEvent OAKEDCLCCGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x62808F0", Offset = "0x627FAF0", VA = "0x1862808F0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent OAKEDCLCCGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6280A30", Offset = "0x627FC30", VA = "0x186280A30")]
		public void LogSerializedEventAsync(Dictionary<string, object> NDFGDEBNDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6280560", Offset = "0x627F760", VA = "0x186280560")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage DGLCGGKBJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6280150", Offset = "0x627F350", VA = "0x186280150")]
		private void KPKALLIIAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x627D270", Offset = "0x627C470", VA = "0x18627D270")]
		private void AJPBGJMIOPH(Dictionary<string, object> PGMNFLGPPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x627F350", Offset = "0x627E550", VA = "0x18627F350")]
		private void IMIIBIAKHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x627FF80", Offset = "0x627F180", VA = "0x18627FF80")]
		private void KOCGNMMECPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x627F1C0", Offset = "0x627E3C0", VA = "0x18627F1C0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6280B10", Offset = "0x627FD10", VA = "0x186280B10")]
		[IteratorStateMachine(typeof(DAKFEGGPJAK))]
		private IEnumerator<AEBIBAEBDOJ> NBEIGHEJJIJ(float HEEKNLGJGIH = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x627F2C0", Offset = "0x627E4C0", VA = "0x18627F2C0")]
		[IteratorStateMachine(typeof(NJAAPELNFMA))]
		private IEnumerator<AEBIBAEBDOJ> ILOHCBBELPA(float HEEKNLGJGIH = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6280D70", Offset = "0x627FF70", VA = "0x186280D70")]
		[IteratorStateMachine(typeof(KNDLKHOBFFD))]
		private IEnumerator<AEBIBAEBDOJ> OGFCIDMKEFB(ECGBBGBOBFF JFCCHECKCHB, int? EBJPDJFPGMH, string HCBGCDDLGHF, float HEEKNLGJGIH, Action<int> KGFGBINFJKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6280BA0", Offset = "0x627FDA0", VA = "0x186280BA0")]
		private static void NDCENKJABNG(bool HIOPGHKENBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x627DB10", Offset = "0x627CD10", VA = "0x18627DB10")]
		private PMIHBBCEMHD<CPEOEBOAHIN<Dictionary<string, object>>> BEACLIIAGIF(string HCBGCDDLGHF, string DNGPMIFMJCE, Dictionary<string, object> FIHLINDOMFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x627DBE0", Offset = "0x627CDE0", VA = "0x18627DBE0")]
		private PMIHBBCEMHD<CPEOEBOAHIN<List<Dictionary<string, object>>>> BEACLIIAGIF(string HCBGCDDLGHF, string DNGPMIFMJCE, List<Dictionary<string, object>> FIHLINDOMFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x30163F0", Offset = "0x30155F0", VA = "0x1830163F0")]
		private PMIHBBCEMHD<CPEOEBOAHIN<T>> BGOIMPNPHHH<T>(string GBDELJLAKOO, string HCBGCDDLGHF, string DNGPMIFMJCE, T FIHLINDOMFJ, Dictionary<string, object> OINEAKLAPLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x627FF30", Offset = "0x627F130", VA = "0x18627FF30")]
		private bool JLGNHCJHADP(float IDADMJINJBK, float HEEKNLGJGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x627E4F0", Offset = "0x627D6F0", VA = "0x18627E4F0")]
		private Dictionary<string, object> FPGHDCOMFOI(string HCBGCDDLGHF, Dictionary<string, object> FIHLINDOMFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x62827C0", Offset = "0x62819C0", VA = "0x1862827C0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6281210", Offset = "0x6280410", VA = "0x186281210")]
		[CompilerGenerated]
		private long PGMCIDNHPCG()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6280E50", Offset = "0x6280050", VA = "0x186280E50")]
		[CompilerGenerated]
		private void OKAMIMLDMIG(int AKKDOEIIJJN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly bool isBrazeUser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6283B10", Offset = "0x6282D10", VA = "0x186283B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6283BF0", Offset = "0x6282DF0", VA = "0x186283BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6283B50", Offset = "0x6282D50", VA = "0x186283B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6283C50", Offset = "0x6282E50", VA = "0x186283C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6283AD0", Offset = "0x6282CD0", VA = "0x186283AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6283B90", Offset = "0x6282D90", VA = "0x186283B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7CE890", Offset = "0x7CDA90", VA = "0x1807CE890")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6282E20", Offset = "0x6282020", VA = "0x186282E20")]
		public static GCKEAKHLFFJ ADOMMGOMPJC(string DHGBHLPPCDP, [NotNull] string PPIDNBGGLHF, long NMIMEMMOJHM, long DMFLIJFMOIE, string IJPBCGPKMHE, bool LFOLKBMJEMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6283450", Offset = "0x6282650", VA = "0x186283450")]
		public static GCKEAKHLFFJ ALBONKJOPMI(string DHGBHLPPCDP, [NotNull] string PPIDNBGGLHF, long NMIMEMMOJHM, long DMFLIJFMOIE, string IJPBCGPKMHE, long CDJJJLPHAJH, bool LFOLKBMJEMB, string DONKCPOJNKG, string MELCKMJCECA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6283940", Offset = "0x6282B40", VA = "0x186283940")]
		private AmplitudeAnalyticsEvent(string DHGBHLPPCDP, [NotNull] string PPIDNBGGLHF, long NMIMEMMOJHM, long DMFLIJFMOIE, string IJPBCGPKMHE, bool LFOLKBMJEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1BDD920", Offset = "0x1BDCB20", VA = "0x181BDD920")]
		public void BOHEBBCELLJ(long PPIAHADGDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6283840", Offset = "0x6282A40", VA = "0x186283840", Slot = "5")]
		public override void LPNFOMINOHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x62835B0", Offset = "0x62827B0", VA = "0x1862835B0", Slot = "6")]
		public override void BAJMDCDKLJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6282F20", Offset = "0x6282120", VA = "0x186282F20", Slot = "4")]
		protected override Dictionary<string, object> AKFLPBENLCN(Dictionary<string, object> IPGMLPPBICJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6283730", Offset = "0x6282930", VA = "0x186283730")]
		private void CKOKNPDHILM(string MNOIAMGNLNL, string HLCKBKFCMPI, bool DAIILBPABJM = false)
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
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6285710", Offset = "0x6284910", VA = "0x186285710")]
			public void AEOKIFOBEDM(Dictionary<string, object> AADEJFDDPBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x628E7E0", Offset = "0x628D9E0", VA = "0x18628E7E0")]
			public void AEOKIFOBEDM(Dictionary<string, object> KHDBAFNPAKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9F74E0", Offset = "0x9F66E0", VA = "0x1809F74E0")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6283CB0", Offset = "0x6282EB0", VA = "0x186283CB0")]
		public static EKDMODEHDMI ADOMMGOMPJC(string DHGBHLPPCDP, string IJPBCGPKMHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6284360", Offset = "0x6283560", VA = "0x186284360")]
		protected AmplitudeAnalyticsIdentifyMessage(string DHGBHLPPCDP, string IJPBCGPKMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x62841D0", Offset = "0x62833D0", VA = "0x1862841D0")]
		public Dictionary<string, object> IMADKGMMEHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6283D70", Offset = "0x6282F70", VA = "0x186283D70", Slot = "4")]
		protected virtual Dictionary<string, object> AKFLPBENLCN(Dictionary<string, object> IPGMLPPBICJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6284130", Offset = "0x6283330", VA = "0x186284130")]
		protected void CGGKMBENPFP(string MNOIAMGNLNL, Dictionary<string, object> LALKBIGMIKI, Dictionary<string, object> FHLBEKHGCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x62842F0", Offset = "0x62834F0", VA = "0x1862842F0")]
		protected void ODHDIBGNDNC(string MNOIAMGNLNL, string HLCKBKFCMPI, Dictionary<string, object> LAOBOHCKIJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6284260", Offset = "0x6283460", VA = "0x186284260", Slot = "5")]
		public virtual void LPNFOMINOHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x62840B0", Offset = "0x62832B0", VA = "0x1862840B0", Slot = "6")]
		public virtual void BAJMDCDKLJP()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EKDMODEHDMI : LFIMFDMMEAK<AmplitudeAnalyticsIdentifyMessage, EKDMODEHDMI>
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public override EKDMODEHDMI OCPHDBIPNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage BDCAMDPNODM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6286E50", Offset = "0x6286050", VA = "0x186286E50")]
	public EKDMODEHDMI(AmplitudeAnalyticsIdentifyMessage PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6286DB0", Offset = "0x6285FB0", VA = "0x186286DB0", Slot = "4")]
	public override void BAJMDCDKLJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GCKEAKHLFFJ : LFIMFDMMEAK<AmplitudeAnalyticsEvent, GCKEAKHLFFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool BHCFLFJOJNE;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override GCKEAKHLFFJ OCPHDBIPNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public long MEMFAHAJBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6287B20", Offset = "0x6286D20", VA = "0x186287B20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6287B40", Offset = "0x6286D40", VA = "0x186287B40")]
	public GCKEAKHLFFJ(AmplitudeAnalyticsEvent PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530", Slot = "5")]
	public override AmplitudeAnalyticsEvent BDCAMDPNODM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x62877F0", Offset = "0x62869F0", VA = "0x1862877F0", Slot = "4")]
	public override void BAJMDCDKLJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x296DF10", Offset = "0x296D110", VA = "0x18296DF10")]
	public GCKEAKHLFFJ JKJPFKCBEBO<T>(string EHMJOHOMDOD, T[] HLCKBKFCMPI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x296DF10", Offset = "0x296D110", VA = "0x18296DF10")]
	public GCKEAKHLFFJ JKJPFKCBEBO(string EHMJOHOMDOD, string[] HLCKBKFCMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x296DC60", Offset = "0x296CE60", VA = "0x18296DC60")]
	public GCKEAKHLFFJ JKJPFKCBEBO<T>(string EHMJOHOMDOD, T HLCKBKFCMPI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6287A30", Offset = "0x6286C30", VA = "0x186287A30")]
	public GCKEAKHLFFJ JKJPFKCBEBO(string EHMJOHOMDOD, long HLCKBKFCMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6287AB0", Offset = "0x6286CB0", VA = "0x186287AB0")]
	public GCKEAKHLFFJ JKJPFKCBEBO(string EHMJOHOMDOD, string HLCKBKFCMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x62877C0", Offset = "0x62869C0", VA = "0x1862877C0")]
	public GCKEAKHLFFJ ANAFPBKHCHL(string EHMJOHOMDOD, object? HLCKBKFCMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6287990", Offset = "0x6286B90", VA = "0x186287990")]
	public GCKEAKHLFFJ GGLOKAGPLCD(string EHMJOHOMDOD, string HLCKBKFCMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6287890", Offset = "0x6286A90", VA = "0x186287890")]
	private GCKEAKHLFFJ CDNHONJPJKK(string EHMJOHOMDOD, object HLCKBKFCMPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HBJEJIMPANP : GCKEAKHLFFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6287B40", Offset = "0x6286D40", VA = "0x186287B40")]
	public HBJEJIMPANP(AmplitudeAnalyticsEvent PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6287D60", Offset = "0x6286F60", VA = "0x186287D60", Slot = "4")]
	public override void BAJMDCDKLJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class LFIMFDMMEAK<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : LFIMFDMMEAK<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M PPGBBBOBJLN;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract BLDR OCPHDBIPNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public LFIMFDMMEAK(M PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3F38100", Offset = "0x3F37300", VA = "0x183F38100")]
	public BLDR DDPMDEKFBEI(AmplitudeAnalyticsIdentifyMessage.DeviceInfo EIPAAEICEKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3F38280", Offset = "0x3F37480", VA = "0x183F38280")]
	public BLDR MMJMAAKHHNA(AmplitudeAnalyticsIdentifyMessage.RevenueData KNLMHAANJGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3F38090", Offset = "0x3F37290", VA = "0x183F38090")]
	public BLDR ABNJFAMIGNB(string EHMJOHOMDOD, string HLCKBKFCMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x288E860", Offset = "0x288DA60", VA = "0x18288E860")]
	public BLDR ABNJFAMIGNB<T>(string EHMJOHOMDOD, T HLCKBKFCMPI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BAJMDCDKLJP();

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3F38150", Offset = "0x3F37350", VA = "0x183F38150")]
	internal static string GHIGKNKBEIE(string HLCKBKFCMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3F38180", Offset = "0x3F37380", VA = "0x183F38180")]
	private BLDR KGPMLODPBKA(string EHMJOHOMDOD, object HLCKBKFCMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M BDCAMDPNODM();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class JBEPGODPHFL : LKNDHHMIACG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct JNOPLFLFMGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<FJEPFIOBDGP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public JBEPGODPHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private StringContent <requestBody>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private HttpRequestMessage <request>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private HttpResponseMessage <httpResponse>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x62893F0", Offset = "0x62885F0", VA = "0x1862893F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6289E20", Offset = "0x6289020", VA = "0x186289E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient GIFAHEOCKLI;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6289030", Offset = "0x6288230", VA = "0x186289030")]
	[JIMPHGEJKMA(CLDBMEKPFFP.None)]
	private static void DJEODBLNHCM(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6289210", Offset = "0x6288410", VA = "0x186289210")]
	[RecRoom.NoEngine.Common.Preserve]
	public JBEPGODPHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x62890A0", Offset = "0x62882A0", VA = "0x1862890A0", Slot = "4")]
	[AsyncStateMachine(typeof(JNOPLFLFMGK))]
	public Task<FJEPFIOBDGP> KFEMODKPHDN(string GBDELJLAKOO, string IKLFMNCFNPH, string GALKKHIBJOL, string HAJCNFLKFFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class PCFDDEEFOLG : LKNDHHMIACG
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NAOMAEGIKNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<FJEPFIOBDGP> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public NAOMAEGIKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x628BC60", Offset = "0x628AE60", VA = "0x18628BC60")]
		internal void IPANABKBMMK(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct PJFAAHMDMJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<FJEPFIOBDGP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<FJEPFIOBDGP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x628E220", Offset = "0x628D420", VA = "0x18628E220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x628E770", Offset = "0x628D970", VA = "0x18628E770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	[JIMPHGEJKMA(CLDBMEKPFFP.None)]
	private static void IGFNNJKKBDB(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PCFDDEEFOLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x628E0C0", Offset = "0x628D2C0", VA = "0x18628E0C0", Slot = "4")]
	[AsyncStateMachine(typeof(PJFAAHMDMJK))]
	public Task<FJEPFIOBDGP> KFEMODKPHDN(string GBDELJLAKOO, string IKLFMNCFNPH, string GALKKHIBJOL, string HAJCNFLKFFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FJIKLFEIPMP
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> CCJGHOOIMNC;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6287610", Offset = "0x6286810", VA = "0x186287610")]
	internal static bool KDNJNGFLEGF(string MNOIAMGNLNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LKNDHHMIACG
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FJEPFIOBDGP> KFEMODKPHDN(string GBDELJLAKOO, string IKLFMNCFNPH, string GALKKHIBJOL, string HAJCNFLKFFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct FJEPFIOBDGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int NALBMDCCIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string LLFHFEKKJIC;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0xCE5780", Offset = "0xCE4980", VA = "0x180CE5780")]
	public FJEPFIOBDGP(int MLBLEKODFFE, string NIBELNDFJHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum DBLLKBJDFNI
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	GameInvite,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	RoomChat,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DebugCommand
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ILAPFKMMLAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private long FPDNADIFNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private GCKEAKHLFFJ AEEDCHDOOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool CJHJDMLBILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float JCIEECPCKOG;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6288EA0", Offset = "0x62880A0", VA = "0x186288EA0")]
	public ILAPFKMMLAH(string MPBNEOMMLPD, float JCIEECPCKOG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x29DE4A0", Offset = "0x29DD6A0", VA = "0x1829DE4A0")]
	public void JKJPFKCBEBO<T>(string EHMJOHOMDOD, T HLCKBKFCMPI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6288BD0", Offset = "0x6287DD0", VA = "0x186288BD0")]
	public void JKJPFKCBEBO(string EHMJOHOMDOD, string HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6288C50", Offset = "0x6287E50", VA = "0x186288C50")]
	public void NLCOOLGIJMN(string DHLMJJGKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6288B10", Offset = "0x6287D10", VA = "0x186288B10")]
	public void CDMMJOLKAPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6288D90", Offset = "0x6287F90", VA = "0x186288D90")]
	private void PHJBLCFLJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6288D40", Offset = "0x6287F40", VA = "0x186288D40")]
	private bool OOBDNKDKMAE()
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
		public enum OAAOFLKKIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			String,
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			Bool
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private OAAOFLKKIHJ parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public OAAOFLKKIHJ Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x831BC0", Offset = "0x830DC0", VA = "0x180831BC0")]
			get
			{
				return default(OAAOFLKKIHJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x91A950", Offset = "0x919B50", VA = "0x18091A950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x628E950", Offset = "0x628DB50", VA = "0x18628E950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class ECCHHNNIMLJ : HLACABJKJPP, KJJGOEKMNPO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void PAHKDBGNLDC(EBECEEDDIKO OADHDBPIKPF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly HLCICAGPMBN EMKAEAPLEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly PAHKDBGNLDC PPCNAKOCCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string NOIDCOGHAEE;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string FJABLKPMHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1151370", Offset = "0x1150570", VA = "0x181151370", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool GOMANNKGHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x62858B0", Offset = "0x6284AB0", VA = "0x1862858B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IFKGNHDGIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6285890", Offset = "0x6284A90", VA = "0x186285890", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<string> LCFKGLMHDOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x11516E0", Offset = "0x11508E0", VA = "0x1811516E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x62858D0", Offset = "0x6284AD0", VA = "0x1862858D0")]
	public ECCHHNNIMLJ(HLCICAGPMBN NLBJLNFBDOF, string DADMACKCPDF, [Optional] PAHKDBGNLDC IBFKJLCDEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2820670", Offset = "0x281F870", VA = "0x182820670", Slot = "8")]
	public T JIBGFLOLNJM<T>(string MNOIAMGNLNL, T AKBALOLNFML)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class PCAJMKMFILB : HNMFBCLJGLA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HEPKCGEOAAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public PCAJMKMFILB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public CBMEANGGFNA userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6288620", Offset = "0x6287820", VA = "0x186288620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6288AB0", Offset = "0x6287CB0", VA = "0x186288AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct MHMMLDOGNGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x628B290", Offset = "0x628A490", VA = "0x18628B290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x628B4A0", Offset = "0x628A6A0", VA = "0x18628B4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct BNCEKOFIOHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public PCAJMKMFILB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CBMEANGGFNA userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6284420", Offset = "0x6283620", VA = "0x186284420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x62846E0", Offset = "0x62838E0", VA = "0x1862846E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct OFJFKBECGKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public PCAJMKMFILB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public CBMEANGGFNA userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x628C070", Offset = "0x628B270", VA = "0x18628C070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x628C440", Offset = "0x628B640", VA = "0x18628C440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly IReadOnlyDictionary<string, PNIBBEHHCPO> HEEHPOLNDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool AHOJCNJJGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private CGBPIOLAPHB LHPLNBFMLCO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9A0", Offset = "0x8CBBA0", VA = "0x1808CC9A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string OJBFMKIBMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x628C7A0", Offset = "0x628B9A0", VA = "0x18628C7A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public MECOAGONMFD FAMANAMMPDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x628D680", Offset = "0x628C880", VA = "0x18628D680", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FDGEHNLDFAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x628C4A0", Offset = "0x628B6A0", VA = "0x18628C4A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x628D840", Offset = "0x628CA40", VA = "0x18628D840", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PEDEEJHDEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x628C700", Offset = "0x628B900", VA = "0x18628C700", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x628D8E0", Offset = "0x628CAE0", VA = "0x18628D8E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<EBECEEDDIKO> JIKNBOJNJGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x628D980", Offset = "0x628CB80", VA = "0x18628D980", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x628DEA0", Offset = "0x628D0A0", VA = "0x18628DEA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x628CB00", Offset = "0x628BD00", VA = "0x18628CB00", Slot = "10")]
	[AsyncStateMachine(typeof(HEPKCGEOAAG))]
	public Task CNOOLEDIEBH(string LPBGNCMLLBF, [Optional] CBMEANGGFNA EDJJHIAHIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x628C960", Offset = "0x628BB60", VA = "0x18628C960", Slot = "19")]
	[AsyncStateMachine(typeof(MHMMLDOGNGK))]
	public Task CNFIFJFPOBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x628CA10", Offset = "0x628BC10", VA = "0x18628CA10", Slot = "14")]
	[AsyncStateMachine(typeof(BNCEKOFIOHH))]
	public Task CNIJKJDDDOM(CBMEANGGFNA EDJJHIAHIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x628DA30", Offset = "0x628CC30", VA = "0x18628DA30", Slot = "15")]
	[AsyncStateMachine(typeof(OFJFKBECGKH))]
	public Task LCIDHGMNBEB(CBMEANGGFNA EDJJHIAHIIN, Dictionary<string, string> AMIOHMJNCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x628D720", Offset = "0x628C920", VA = "0x18628D720", Slot = "16")]
	public bool FIKJMELNKIC(string FHAELHPOKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x628C7B0", Offset = "0x628B9B0", VA = "0x18628C7B0", Slot = "17")]
	public HLACABJKJPP CDCNPFMNNDL(string DADMACKCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x628C540", Offset = "0x628B740", VA = "0x18628C540")]
	private HLCICAGPMBN ADFIINIPNDC(string DADMACKCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x628DB40", Offset = "0x628CD40", VA = "0x18628DB40", Slot = "18")]
	public GPNODAKBMNM LMBHFKKJDGH(string OANKMNCAALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x628D7B0", Offset = "0x628C9B0", VA = "0x18628D7B0")]
	private DPLKBHLKDJE FJOBNHCPAHD(string OANKMNCAALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x628CC10", Offset = "0x628BE10", VA = "0x18628CC10")]
	private FIGCCPDFPAC DBIGJDBIGHK(CBMEANGGFNA EDJJHIAHIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x628DCF0", Offset = "0x628CEF0", VA = "0x18628DCF0")]
	private PIIIIIFJOCI MFLFMFFDDMC(string LPBGNCMLLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x628D570", Offset = "0x628C770", VA = "0x18628D570")]
	private void DHDAGAEPGKH(string DADMACKCPDF, HLCICAGPMBN NLBJLNFBDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public PCAJMKMFILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x62855F0", Offset = "0x62847F0", VA = "0x1862855F0")]
	[CompilerGenerated]
	private void NKGOGFICDHJ(EBECEEDDIKO EHGBCDPMKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x62855F0", Offset = "0x62847F0", VA = "0x1862855F0")]
	[CompilerGenerated]
	private void CCFOLECANOK(EBECEEDDIKO EHGBCDPMKNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class DEIHCEMEENA : HNMFBCLJGLA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct HEBLAHKNHDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public DEIHCEMEENA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public CBMEANGGFNA userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6287F10", Offset = "0x6287110", VA = "0x186287F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x62885C0", Offset = "0x62877C0", VA = "0x1862885C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private HNMFBCLJGLA AGBPBFBNOBG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private HNMFBCLJGLA HIDDLFOHBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6285630", Offset = "0x6284830", VA = "0x186285630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6285160", Offset = "0x6284360", VA = "0x186285160", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string OJBFMKIBMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6284B30", Offset = "0x6283D30", VA = "0x186284B30", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public MECOAGONMFD FAMANAMMPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6284F50", Offset = "0x6284150", VA = "0x186284F50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action FDGEHNLDFAF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x62849F0", Offset = "0x6283BF0", VA = "0x1862849F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x62850C0", Offset = "0x62842C0", VA = "0x1862850C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action PEDEEJHDEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6284A90", Offset = "0x6283C90", VA = "0x186284A90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x62851B0", Offset = "0x62843B0", VA = "0x1862851B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<EBECEEDDIKO> JIKNBOJNJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6285250", Offset = "0x6284450", VA = "0x186285250", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6285540", Offset = "0x6284740", VA = "0x186285540", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	[UnityEngine.Scripting.Preserve]
	public DEIHCEMEENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6285420", Offset = "0x6284620", VA = "0x186285420")]
	[JIMPHGEJKMA(CLDBMEKPFFP.GameOnly)]
	private static void LJKAJEFLMOE(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x62856A0", Offset = "0x62848A0", VA = "0x1862856A0")]
	[JIMPHGEJKMA(CLDBMEKPFFP.EditorOnly)]
	private static void PMGFMICDFDA(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6284E40", Offset = "0x6284040", VA = "0x186284E40", Slot = "10")]
	[AsyncStateMachine(typeof(HEBLAHKNHDP))]
	public Task CNOOLEDIEBH(string LPBGNCMLLBF, [Optional] CBMEANGGFNA EDJJHIAHIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6284D40", Offset = "0x6283F40", VA = "0x186284D40", Slot = "14")]
	public Task CNIJKJDDDOM(CBMEANGGFNA EDJJHIAHIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6285300", Offset = "0x6284500", VA = "0x186285300", Slot = "15")]
	public Task LCIDHGMNBEB(CBMEANGGFNA EDJJHIAHIIN, Dictionary<string, string> AMIOHMJNCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6285010", Offset = "0x6284210", VA = "0x186285010", Slot = "16")]
	public bool FIKJMELNKIC(string FHAELHPOKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6284B80", Offset = "0x6283D80", VA = "0x186284B80", Slot = "17")]
	public HLACABJKJPP CDCNPFMNNDL(string DADMACKCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6285490", Offset = "0x6284690", VA = "0x186285490", Slot = "18")]
	public GPNODAKBMNM LMBHFKKJDGH(string OANKMNCAALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6284C30", Offset = "0x6283E30", VA = "0x186284C30", Slot = "19")]
	public Task CNFIFJFPOBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x814470", Offset = "0x813670", VA = "0x180814470")]
	[CompilerGenerated]
	private void EIDMJJGDPOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8C9A00", Offset = "0x8C8C00", VA = "0x1808C9A00")]
	[CompilerGenerated]
	private void HDGBCDGJICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x62855F0", Offset = "0x62847F0", VA = "0x1862855F0")]
	[CompilerGenerated]
	private void OPDKAFKNOJP(EBECEEDDIKO EHGBCDPMKNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal class JFOPOBAPPNA : GPNODAKBMNM, KJJGOEKMNPO
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate void JJFAOFMCIFF(EBECEEDDIKO OADHDBPIKPF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly JJFAOFMCIFF PPCNAKOCCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly DPLKBHLKDJE BOKEOCHGHCI;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string FJABLKPMHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1B73D40", Offset = "0x1B72F40", VA = "0x181B73D40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x56044E0", Offset = "0x56036E0", VA = "0x1856044E0")]
	public JFOPOBAPPNA(DPLKBHLKDJE HEJPMNEGHKB, [Optional] JJFAOFMCIFF IBFKJLCDEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x29F2FD0", Offset = "0x29F21D0", VA = "0x1829F2FD0", Slot = "5")]
	public T JIBGFLOLNJM<T>(string MNOIAMGNLNL, T AKBALOLNFML)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface JLPIDOBHNIN
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[UsedImplicitly]
public class HBIFGBLBBJB : JLPIDOBHNIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly LEFDEHMPPKF JPPIMLHHLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly List<JAFKPPNMMKF> CMKOLOEGFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly string LFNGNHFMICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly string ENLHIILKEMP;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6287B90", Offset = "0x6286D90", VA = "0x186287B90")]
	[JIMPHGEJKMA(NFKMIHJOIMG.Root, CLDBMEKPFFP.GameOnly)]
	[UsedImplicitly]
	private static void DPFLJEJBPJI(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6287C00", Offset = "0x6286E00", VA = "0x186287C00")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HBIFGBLBBJB([NotNull][KFHLAIGNCCH(null)] LEFDEHMPPKF JPPIMLHHLFC, [NotNull][KFHLAIGNCCH(null)] JBCIOOOHNBL HIFKDBNDIPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class MMOPMAIKJGO : HNMFBCLJGLA
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string OJBFMKIBMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MECOAGONMFD FAMANAMMPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action FDGEHNLDFAF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x628B500", Offset = "0x628A700", VA = "0x18628B500", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x628B8A0", Offset = "0x628AAA0", VA = "0x18628B8A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action PEDEEJHDEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x628B5A0", Offset = "0x628A7A0", VA = "0x18628B5A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x628B940", Offset = "0x628AB40", VA = "0x18628B940", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<EBECEEDDIKO> JIKNBOJNJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x628B9E0", Offset = "0x628ABE0", VA = "0x18628B9E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x628BBB0", Offset = "0x628ADB0", VA = "0x18628BBB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MMOPMAIKJGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x628B810", Offset = "0x628AA10", VA = "0x18628B810", Slot = "10")]
	public Task CNOOLEDIEBH(string LPBGNCMLLBF, [Optional] CBMEANGGFNA EDJJHIAHIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x628B780", Offset = "0x628A980", VA = "0x18628B780", Slot = "14")]
	public Task CNIJKJDDDOM(CBMEANGGFNA EDJJHIAHIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x628BA90", Offset = "0x628AC90", VA = "0x18628BA90", Slot = "15")]
	public Task LCIDHGMNBEB(CBMEANGGFNA EDJJHIAHIIN, Dictionary<string, string> AMIOHMJNCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "16")]
	public bool FIKJMELNKIC(string FHAELHPOKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x628B640", Offset = "0x628A840", VA = "0x18628B640", Slot = "17")]
	public HLACABJKJPP CDCNPFMNNDL(string DADMACKCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x628BB20", Offset = "0x628AD20", VA = "0x18628BB20", Slot = "18")]
	public GPNODAKBMNM LMBHFKKJDGH(string OANKMNCAALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x628B6F0", Offset = "0x628A8F0", VA = "0x18628B6F0", Slot = "19")]
	public Task CNFIFJFPOBI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal class CGBPIOLAPHB : MECOAGONMFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly FIGCCPDFPAC LHPLNBFMLCO;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IReadOnlyDictionary<string, object> LHBKCOJLOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1151280", Offset = "0x1150480", VA = "0x181151280", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public CGBPIOLAPHB(FIGCCPDFPAC KOGLEFBLJIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface DHOJLGOMIKO
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILAPFKMMLAH ALLDKGGIJNC(string MPBNEOMMLPD);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface NHBNGLAPCCE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum MONIHIMIHPN
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	long IAMENBJJCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string LEGNAHIHODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string JDLHFBOPIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "3")]
	long LPDLGEMFGAM();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNFLDGFJPNI(long NMIMEMMOJHM, bool DAIILBPABJM = true);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BOEIJCPBDFF(string EOIJJPCMNGA, string KJCPAMFLEEF, string LIPPNGBLAIA);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IIOEEDLLAKL(string EOIJJPCMNGA);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AOFEOPLEPDE(string EOIJJPCMNGA, string BABCFMPNFJL, string MLGICGLLCNP);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MINKFEELMDI(string IFMOJFKAOHA, object HEBJKNABFEF, object FPMLKALFLEH);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DKBNKNMMLKI(MONIHIMIHPN JNGNNFBOPLB, int JNCACEPFDLL, [Optional] DALOPKAKLEH OIHNLLIOBHN, [Optional] string IDJCJHDNCNG, [Optional] string KFNIFKKFLAO);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LNDOBBPKHBG(DALOPKAKLEH OIHNLLIOBHN, long JFHBANDGPGA, long KKOAAOEEDFF, int KBCPBNNECLK, string IDJCJHDNCNG, int JNCACEPFDLL);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ABKEGGAMPEO(DALOPKAKLEH OIHNLLIOBHN, bool HILMMDDDLMN, [Optional] string KFNIFKKFLAO);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LOLEMJDKNOK(DALOPKAKLEH OIHNLLIOBHN, bool HILMMDDDLMN, [Optional] string KFNIFKKFLAO);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LAGLKHABIPE(DALOPKAKLEH OIHNLLIOBHN, bool HILMMDDDLMN, [Optional] string KFNIFKKFLAO);
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
