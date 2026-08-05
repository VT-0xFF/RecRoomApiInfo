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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F55CA0", Offset = "0x5F550A0", VA = "0x185F55CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
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
		public AmplitudeAnalyticsClient.Settings MPKMPJGJHPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GIMCDKFIFIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7A5A00", Offset = "0x7A4E00", VA = "0x1807A5A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum DDIIEDIHOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class LGEJMJGOIEE
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class IJFENANKLIN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int ILBKJEMFMOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> FAPEPANBMBP;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
				public IJFENANKLIN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class BIMBAPKLGJA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
				public BIMBAPKLGJA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5F50CA0", Offset = "0x5F500A0", VA = "0x185F50CA0")]
				internal bool JHKCEFBOGME(IJFENANKLIN item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string EEPPPFIDHLH = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string NFJOGILOIIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<IJFENANKLIN> KBCPHCGGFDN;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? BPLKNJDKGHI
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5F53DE0", Offset = "0x5F531E0", VA = "0x185F53DE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5F550A0", Offset = "0x5F544A0", VA = "0x185F550A0")]
			internal LGEJMJGOIEE(string EBJNEJHFALE, string BCEDPIPJOJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5F54C10", Offset = "0x5F54010", VA = "0x185F54C10")]
			public int NICLBOLKLGJ([Optional] int? DNMAPPCMONE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5F549A0", Offset = "0x5F53DA0", VA = "0x185F549A0")]
			public List<Dictionary<string, object>> LBEEJCDBINJ(int LFIMPLNGHAJ, int? DNMAPPCMONE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5F54EF0", Offset = "0x5F542F0", VA = "0x185F54EF0")]
			public void PPANFNBPEFM(AmplitudeAnalyticsIdentifyMessage BHPOPDOKECN, bool AFBLEOGLKJK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5F54F90", Offset = "0x5F54390", VA = "0x185F54F90")]
			public void PPANFNBPEFM(Dictionary<string, object> BHPOPDOKECN, bool AFBLEOGLKJK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5F540D0", Offset = "0x5F534D0", VA = "0x185F540D0")]
			public void CPABIGKGHOL(params Dictionary<string, object>[] MCPPALDMPIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5F53E80", Offset = "0x5F53280", VA = "0x185F53E80")]
			public void CKHANOHHMCD(List<Dictionary<string, object>> MHIGHLGIFMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5F54260", Offset = "0x5F53660", VA = "0x185F54260")]
			private void EFIMKEEMJAD(Dictionary<string, object> BHPOPDOKECN, bool AFBLEOGLKJK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5F54370", Offset = "0x5F53770", VA = "0x185F54370")]
			public void FFECLHGGNNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5F545B0", Offset = "0x5F539B0", VA = "0x185F545B0")]
			private void JMJNKEAGOAL([Optional] string LNGOOFEHLEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5F54DC0", Offset = "0x5F541C0", VA = "0x185F54DC0")]
			private static string NKILPKIOBCJ(string ANJCCKHBJJO, string GPGELODKPOB)
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
			[Cpp2IlInjected.Address(RVA = "0x5F59890", Offset = "0x5F58C90", VA = "0x185F59890")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct JJBNGHPEIOF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int GGEJMGBOGCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string GNLPGDBMJPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T KAHMHDLEJBP;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HHELAFMPEGH : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private ALCMBHLDKFG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
			[DebuggerHidden]
			public HHELAFMPEGH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5F52130", Offset = "0x5F51530", VA = "0x185F52130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5F528F0", Offset = "0x5F51CF0", VA = "0x185F528F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class IFNGGLIJPGF : IEnumerator<object>, IEnumerator, IDisposable
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
			public JLJKALKJOAC quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
			[DebuggerHidden]
			public IFNGGLIJPGF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5F533E0", Offset = "0x5F527E0", VA = "0x185F533E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5F534F0", Offset = "0x5F528F0", VA = "0x185F534F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class FNPKGFIMOFE : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
			[DebuggerHidden]
			public FNPKGFIMOFE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5F51800", Offset = "0x5F50C00", VA = "0x185F51800", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5F51970", Offset = "0x5F50D70", VA = "0x185F51970", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class BHFOKNJGKEG : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private ALCMBHLDKFG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
			[DebuggerHidden]
			public BHFOKNJGKEG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5F509D0", Offset = "0x5F4FDD0", VA = "0x185F509D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5F50C50", Offset = "0x5F50050", VA = "0x185F50C50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class FNBMIIBLLPO : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private ALCMBHLDKFG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
			[DebuggerHidden]
			public FNBMIIBLLPO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5F51520", Offset = "0x5F50920", VA = "0x185F51520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5F517B0", Offset = "0x5F50BB0", VA = "0x185F517B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class GEABDDJLDKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public LGEJMJGOIEE cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public GEABDDJLDKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5F51E10", Offset = "0x5F51210", VA = "0x185F51E10")]
			internal void LNKINFEPBON(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5F519C0", Offset = "0x5F50DC0", VA = "0x185F519C0")]
			internal void LALDDMEFDIG(JJBNGHPEIOF<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class LBKGBDGPGPN : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private ALCMBHLDKFG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public LGEJMJGOIEE cache;

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
			private GEABDDJLDKI <>8__1;

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
			private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
			[DebuggerHidden]
			public LBKGBDGPGPN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5F53540", Offset = "0x5F52940", VA = "0x185F53540", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5F53D90", Offset = "0x5F53190", VA = "0x185F53D90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class BFEIHNFMIHO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public BFEIHNFMIHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x472E7D0", Offset = "0x472DBD0", VA = "0x18472E7D0")]
			internal JJBNGHPEIOF<T> HLFFMPJNEKK(GLKGAIBBIDC postResponse)
			{
				return default(JJBNGHPEIOF<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class DKCJFNEONFG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public DKCJFNEONFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x472E7D0", Offset = "0x472DBD0", VA = "0x18472E7D0")]
			internal JJBNGHPEIOF<T> PAFHKAOKJMO(GLKGAIBBIDC postResponse)
			{
				return default(JJBNGHPEIOF<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private BBHDEBBJEDM PEKHCGPCFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<AANLAINKEMJ> IIDPLFCDBOM;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string KLNDBHBEPBI = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string ABAIPPBOFKK = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string PJLAHGNFGHN = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int NBFCPBEKGON = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int DBFFBPEAJIE = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int BHOABNNHLHJ = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float JLGLEPNNINF = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long ADPHMDHBHIE = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string DFJGLAPNDKP = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string PBMBNGBFBEO = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool PILHFEMIMLK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool KMOMCBINIEH;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int JFAPOLAJAPL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int FJKGDNPEKIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private PELHBMEDFBA PIAHDPOGKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private EMMGLDNKGLN NECIBNCLBFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FHDFONCLEPF MAMDEOELOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool LLKMCDBCOHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float MOCPPPCCKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float KAKOKMINFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int AFOOJHDDBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int JFALKEDLKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? FOFCKIOCFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? MJACDHAJACO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long NOBIFONPKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string MGFONKEILAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool KDLEPHFOIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long INJHKMGCFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string MPHDGNINJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string EPEKCDFHEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> NGKFELFNHLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DDIIEDIHOBJ NDPNCELBJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int BKMJHCGMHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int AFCMKKPEKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float LIKCEHDBIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool MCPCABHDNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool PNNKDFPEAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private LGEJMJGOIEE JFAMGEOPEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private LGEJMJGOIEE PNPBLNKDEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private LGEJMJGOIEE GACEAJEBJKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> FCKJJDGGMAG;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo BCIGHNMLNEP;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string NLANPHFLJLE;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string DDHNJHDJEAF = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string OPPNDFMKGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string AINHCLDAOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string DFJGEKOILHH;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BBHDEBBJEDM AGLOGELJDBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5F4D470", Offset = "0x5F4C870", VA = "0x185F4D470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private AANLAINKEMJ BLBBGFKFKIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5F4B380", Offset = "0x5F4A780", VA = "0x185F4B380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int NEIHGINMADF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5F4ACB0", Offset = "0x5F4A0B0", VA = "0x185F4ACB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long HFIIEMHKKMN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5F4EE80", Offset = "0x5F4E280", VA = "0x185F4EE80")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5F4EFA0", Offset = "0x5F4E3A0", VA = "0x185F4EFA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string NBCFEEPHHJK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5F4EE20", Offset = "0x5F4E220", VA = "0x185F4EE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string GFJEFDHKIAL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5F4EE50", Offset = "0x5F4E250", VA = "0x185F4EE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string CCIEOIGNHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8572C0", Offset = "0x8566C0", VA = "0x1808572C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x857700", Offset = "0x856B00", VA = "0x180857700")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? AEDKFMCMAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x90BDE0", Offset = "0x90B1E0", VA = "0x18090BDE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5F4EF90", Offset = "0x5F4E390", VA = "0x185F4EF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HFGJGPNHAJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xEF8740", Offset = "0xEF7B40", VA = "0x180EF8740")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xEF87F0", Offset = "0xEF7BF0", VA = "0x180EF87F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool CDCAEPEBLBC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5F4ED20", Offset = "0x5F4E120", VA = "0x185F4ED20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> MFDDNBFPKEK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5F4EC60", Offset = "0x5F4E060", VA = "0x185F4EC60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5F4EED0", Offset = "0x5F4E2D0", VA = "0x185F4EED0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5F49540", Offset = "0x5F48940", VA = "0x185F49540", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C770", Offset = "0x5F4BB70", VA = "0x185F4C770")]
		private void MHNIFCMDLNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E240", Offset = "0x5F4D640", VA = "0x185F4E240")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D2F0", Offset = "0x5F4C6F0", VA = "0x185F4D2F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E5E0", Offset = "0x5F4D9E0", VA = "0x185F4E5E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D4E0", Offset = "0x5F4C8E0", VA = "0x185F4D4E0")]
		public IIJBCHKFBNI PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5F4BD00", Offset = "0x5F4B100", VA = "0x185F4BD00")]
		[IteratorStateMachine(typeof(HHELAFMPEGH))]
		public IEnumerator<ALCMBHLDKFG> Initialize(AmplitudeAnalyticsEvent FOFFOKKJLEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E520", Offset = "0x5F4D920", VA = "0x185F4E520")]
		public void UpdateLastKnownInteractionCategory(string GNNMNNINKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E430", Offset = "0x5F4D830", VA = "0x185F4E430")]
		public void UpdateLastAliveTime(float FANKMGPLGGP = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D3B0", Offset = "0x5F4C7B0", VA = "0x185F4D3B0")]
		private IIJBCHKFBNI PHCIBFBNBPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5F4B4F0", Offset = "0x5F4A8F0", VA = "0x185F4B4F0")]
		private IIJBCHKFBNI ICINGIJKBHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5F4DC90", Offset = "0x5F4D090", VA = "0x185F4DC90")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5F4B7E0", Offset = "0x5F4ABE0", VA = "0x185F4B7E0")]
		[IteratorStateMachine(typeof(IFNGGLIJPGF))]
		private IEnumerator IHBOALMHADL(JLJKALKJOAC GKJGNKADJJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E870", Offset = "0x5F4DC70", VA = "0x185F4E870")]
		[IteratorStateMachine(typeof(FNPKGFIMOFE))]
		public IEnumerator WaitForFlush(float NAHMIMAPPEC = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E310", Offset = "0x5F4D710", VA = "0x185F4E310")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E250", Offset = "0x5F4D650", VA = "0x185F4E250")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime OJFBKFAHIPG)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5F4B870", Offset = "0x5F4AC70", VA = "0x185F4B870")]
		public static NGOKECACIMP Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5F493D0", Offset = "0x5F487D0", VA = "0x185F493D0")]
		public static BCPGKCOPFBN AccountSelectionPostLoginEvent([NotNull] string JIKPLCLJMED, string GJFLGBMDDAH, bool JMILGBAJANB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F4AE90", Offset = "0x5F4A290", VA = "0x185F4AE90")]
		public static BCPGKCOPFBN Event([NotNull] string JIKPLCLJMED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D520", Offset = "0x5F4C920", VA = "0x185F4D520")]
		public static BCPGKCOPFBN PreviousSessionEvent([NotNull] string JIKPLCLJMED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5F4BA20", Offset = "0x5F4AE20", VA = "0x185F4BA20")]
		public static BCPGKCOPFBN InitializeEvent(string GJFLGBMDDAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5F4DE50", Offset = "0x5F4D250", VA = "0x185F4DE50")]
		public static BCPGKCOPFBN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5F4A930", Offset = "0x5F49D30", VA = "0x185F4A930")]
		public static BCPGKCOPFBN CreateOutOfSessionEvent(string JIKPLCLJMED, bool DGCGNAEINAM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C160", Offset = "0x5F4B560", VA = "0x185F4C160")]
		public static IIJBCHKFBNI LogOutOfSessionEvent(BCPGKCOPFBN NKALDAOJNCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5F4BEE0", Offset = "0x5F4B2E0", VA = "0x185F4BEE0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent KABJPOMPBBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C450", Offset = "0x5F4B850", VA = "0x185F4C450")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent KABJPOMPBBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C590", Offset = "0x5F4B990", VA = "0x185F4C590")]
		public void LogSerializedEventAsync(Dictionary<string, object> AENBIPDOKHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C020", Offset = "0x5F4B420", VA = "0x185F4C020")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage EPGNHOAJMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5F4BD90", Offset = "0x5F4B190", VA = "0x185F4BD90")]
		private void JKJMKLFIJMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5F499B0", Offset = "0x5F48DB0", VA = "0x185F499B0")]
		private void BKIGGIBDFFP(Dictionary<string, object> GLBGFJJCOHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5F492E0", Offset = "0x5F486E0", VA = "0x185F492E0")]
		private void AGFLGKHIAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CD10", Offset = "0x5F4C110", VA = "0x185F4CD10")]
		private void NLCAFLHDNPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5F4B190", Offset = "0x5F4A590", VA = "0x185F4B190")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5F4B460", Offset = "0x5F4A860", VA = "0x185F4B460")]
		[IteratorStateMachine(typeof(BHFOKNJGKEG))]
		private IEnumerator<ALCMBHLDKFG> HPPIPFDFEEL(float NAHMIMAPPEC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5F4B3D0", Offset = "0x5F4A7D0", VA = "0x185F4B3D0")]
		[IteratorStateMachine(typeof(FNBMIIBLLPO))]
		private IEnumerator<ALCMBHLDKFG> HNEJFLMBICE(float NAHMIMAPPEC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5F4C670", Offset = "0x5F4BA70", VA = "0x185F4C670")]
		[IteratorStateMachine(typeof(LBKGBDGPGPN))]
		private IEnumerator<ALCMBHLDKFG> MFAEINBEKNI(LGEJMJGOIEE ABNDHJPENBL, int? DNMAPPCMONE, string BEMFBDPELFM, string ALHJCHPKEPD, float NAHMIMAPPEC, Action<int> PDMONJFFBBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5F4AB90", Offset = "0x5F49F90", VA = "0x185F4AB90")]
		private static void DAAOOJCOAIA(bool FNLCEJFPFCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D1C0", Offset = "0x5F4C5C0", VA = "0x185F4D1C0")]
		private GKAGCLBDDCM<JJBNGHPEIOF<Dictionary<string, object>>> NPDNLENDING(string BEMFBDPELFM, string ALHJCHPKEPD, string JFAPAFDAEBE, string GIHBKNPJMIO, Dictionary<string, object> KAHMHDLEJBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CEE0", Offset = "0x5F4C2E0", VA = "0x185F4CEE0")]
		private GKAGCLBDDCM<JJBNGHPEIOF<List<Dictionary<string, object>>>> NPDNLENDING(string BEMFBDPELFM, string ALHJCHPKEPD, string JFAPAFDAEBE, string GIHBKNPJMIO, List<Dictionary<string, object>> KAHMHDLEJBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2D19190", Offset = "0x2D18590", VA = "0x182D19190")]
		private GKAGCLBDDCM<JJBNGHPEIOF<T>> LEIPCNELGMD<T>(string BEMFBDPELFM, string ALHJCHPKEPD, string GIHBKNPJMIO, T KAHMHDLEJBP, Dictionary<string, object> FNKKAOAFLPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2D18E40", Offset = "0x2D18240", VA = "0x182D18E40")]
		private GKAGCLBDDCM<JJBNGHPEIOF<T>> JDNMCEMFNNG<T>(string BEMFBDPELFM, string ALHJCHPKEPD, string JFAPAFDAEBE, T KAHMHDLEJBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5F4BE90", Offset = "0x5F4B290", VA = "0x185F4BE90")]
		private bool JNKMHGGBLFC(float BDKBBLLDCLE, float NAHMIMAPPEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5F49C60", Offset = "0x5F49060", VA = "0x185F49C60")]
		private Dictionary<string, object> CPAFMJCJDGC(string ALHJCHPKEPD, Dictionary<string, object> KAHMHDLEJBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5F4E960", Offset = "0x5F4DD60", VA = "0x185F4E960")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5F4B220", Offset = "0x5F4A620", VA = "0x185F4B220")]
		[CompilerGenerated]
		private long GMDGGKGENIJ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5F4ACA0", Offset = "0x5F4A0A0", VA = "0x185F4ACA0")]
		[CompilerGenerated]
		private void DLDBIJPCIAE(int JBNOMCLFBLK)
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
			[Cpp2IlInjected.Address(RVA = "0x5F4FD00", Offset = "0x5F4F100", VA = "0x185F4FD00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5F4FDE0", Offset = "0x5F4F1E0", VA = "0x185F4FDE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5F4FD40", Offset = "0x5F4F140", VA = "0x185F4FD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5F4FE40", Offset = "0x5F4F240", VA = "0x185F4FE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5F4FCC0", Offset = "0x5F4F0C0", VA = "0x185F4FCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5F4FD80", Offset = "0x5F4F180", VA = "0x185F4FD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7A67F0", Offset = "0x7A5BF0", VA = "0x1807A67F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F500", Offset = "0x5F4E900", VA = "0x185F4F500")]
		public static BCPGKCOPFBN HDHFILGDDKG(string MCCNLGBAILL, [NotNull] string LOHMAPLKFCN, long NFINLDCGANN, long DGPDBMLGGMD, string GJFLGBMDDAH, bool JMILGBAJANB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F3A0", Offset = "0x5F4E7A0", VA = "0x185F4F3A0")]
		public static BCPGKCOPFBN HABBPFNJPDA(string MCCNLGBAILL, [NotNull] string LOHMAPLKFCN, long NFINLDCGANN, long DGPDBMLGGMD, string GJFLGBMDDAH, long NONGMMAEPCH, bool JMILGBAJANB, string NFBGPNPPLHG, string GMBEEOHFADM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5F4FB30", Offset = "0x5F4EF30", VA = "0x185F4FB30")]
		private AmplitudeAnalyticsEvent(string MCCNLGBAILL, [NotNull] string LOHMAPLKFCN, long NFINLDCGANN, long DGPDBMLGGMD, string GJFLGBMDDAH, bool JMILGBAJANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x19B23B0", Offset = "0x19B17B0", VA = "0x1819B23B0")]
		public void KFBNPHNHGHJ(long OMEKFLPLEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F290", Offset = "0x5F4E690", VA = "0x185F4F290", Slot = "5")]
		public override void GCALNLBCEIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F000", Offset = "0x5F4E400", VA = "0x185F4F000", Slot = "6")]
		public override void BGPBKFMLKIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F600", Offset = "0x5F4EA00", VA = "0x185F4F600", Slot = "4")]
		protected override Dictionary<string, object> ODOJKLNFFOB(Dictionary<string, object> NAIKBEHONAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F180", Offset = "0x5F4E580", VA = "0x185F4F180")]
		private void BHAONNLAMMP(string GPGELODKPOB, string ANJCCKHBJJO, bool GCKILMNMMPG = false)
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
			[Cpp2IlInjected.Address(RVA = "0x5F50D10", Offset = "0x5F50110", VA = "0x185F50D10")]
			public void LDBHJPHBJAP(Dictionary<string, object> CDNMCNLECBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
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
			[Cpp2IlInjected.Address(RVA = "0x5F59520", Offset = "0x5F58920", VA = "0x185F59520")]
			public void LDBHJPHBJAP(Dictionary<string, object> ALCNFHAEPGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x89D3E0", Offset = "0x89C7E0", VA = "0x18089D3E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7A26E0", Offset = "0x7A1AE0", VA = "0x1807A26E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5F50060", Offset = "0x5F4F460", VA = "0x185F50060")]
		public static NGOKECACIMP HDHFILGDDKG(string MCCNLGBAILL, string GJFLGBMDDAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5F50560", Offset = "0x5F4F960", VA = "0x185F50560")]
		protected AmplitudeAnalyticsIdentifyMessage(string MCCNLGBAILL, string GJFLGBMDDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5F50190", Offset = "0x5F4F590", VA = "0x185F50190")]
		public Dictionary<string, object> JELOIGMCDEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5F50220", Offset = "0x5F4F620", VA = "0x185F50220", Slot = "4")]
		protected virtual Dictionary<string, object> ODOJKLNFFOB(Dictionary<string, object> NAIKBEHONAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5F4FF30", Offset = "0x5F4F330", VA = "0x185F4FF30")]
		protected void CBEPFCKGMJB(string GPGELODKPOB, Dictionary<string, object> PBOKLFMBGII, Dictionary<string, object> ONBACOKHJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5F50120", Offset = "0x5F4F520", VA = "0x185F50120")]
		protected void IJMCNNPEOPI(string GPGELODKPOB, string ANJCCKHBJJO, Dictionary<string, object> BKGHBPOMHEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5F4FFD0", Offset = "0x5F4F3D0", VA = "0x185F4FFD0", Slot = "5")]
		public virtual void GCALNLBCEIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5F4FEA0", Offset = "0x5F4F2A0", VA = "0x185F4FEA0", Slot = "6")]
		public virtual void BGPBKFMLKIB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NGOKECACIMP : CFANNLAOCAM<AmplitudeAnalyticsIdentifyMessage, NGOKECACIMP>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override NGOKECACIMP MOCELEDMAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage GGGPHICJMBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5F55C50", Offset = "0x5F55050", VA = "0x185F55C50")]
	public NGOKECACIMP(AmplitudeAnalyticsIdentifyMessage CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5F55BA0", Offset = "0x5F54FA0", VA = "0x185F55BA0", Slot = "4")]
	public override void BGPBKFMLKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BCPGKCOPFBN : CFANNLAOCAM<AmplitudeAnalyticsEvent, BCPGKCOPFBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool OFBJLPLINOJ;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override BCPGKCOPFBN MOCELEDMAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long CHABOFJPDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1EB20F0", Offset = "0x1EB14F0", VA = "0x181EB20F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5F50980", Offset = "0x5F4FD80", VA = "0x185F50980")]
	public BCPGKCOPFBN(AmplitudeAnalyticsEvent CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0", Slot = "5")]
	public override AmplitudeAnalyticsEvent GGGPHICJMBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5F50620", Offset = "0x5F4FA20", VA = "0x185F50620", Slot = "4")]
	public override void BGPBKFMLKIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2453670", Offset = "0x2452A70", VA = "0x182453670")]
	public BCPGKCOPFBN ODGNGIBCCEK<T>(string PLNALAIILFK, T[] ANJCCKHBJJO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2453670", Offset = "0x2452A70", VA = "0x182453670")]
	public BCPGKCOPFBN ODGNGIBCCEK(string PLNALAIILFK, string[] ANJCCKHBJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x24533C0", Offset = "0x24527C0", VA = "0x1824533C0")]
	public BCPGKCOPFBN ODGNGIBCCEK<T>(string PLNALAIILFK, T ANJCCKHBJJO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5F50900", Offset = "0x5F4FD00", VA = "0x185F50900")]
	public BCPGKCOPFBN ODGNGIBCCEK(string PLNALAIILFK, long ANJCCKHBJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5F50890", Offset = "0x5F4FC90", VA = "0x185F50890")]
	public BCPGKCOPFBN ODGNGIBCCEK(string PLNALAIILFK, string ANJCCKHBJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5F50860", Offset = "0x5F4FC60", VA = "0x185F50860")]
	public BCPGKCOPFBN LKIOBHFFGHH(string PLNALAIILFK, object? ANJCCKHBJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F506C0", Offset = "0x5F4FAC0", VA = "0x185F506C0")]
	public BCPGKCOPFBN EKPICGDJHPB(string PLNALAIILFK, string ANJCCKHBJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5F50760", Offset = "0x5F4FB60", VA = "0x185F50760")]
	private BCPGKCOPFBN KMDHEPCAEGN(string PLNALAIILFK, object ANJCCKHBJJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PPHCHNMDLOO : BCPGKCOPFBN
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F50980", Offset = "0x5F4FD80", VA = "0x185F50980")]
	public PPHCHNMDLOO(AmplitudeAnalyticsEvent CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F59370", Offset = "0x5F58770", VA = "0x185F59370", Slot = "4")]
	public override void BGPBKFMLKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class CFANNLAOCAM<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : CFANNLAOCAM<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M CAIOIMEOMNJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR MOCELEDMAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	public CFANNLAOCAM(M CAIOIMEOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x492BC20", Offset = "0x492B020", VA = "0x18492BC20")]
	public BLDR IKDHGJDDMKH(AmplitudeAnalyticsIdentifyMessage.DeviceInfo OLJKCBLCOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x492BBD0", Offset = "0x492AFD0", VA = "0x18492BBD0")]
	public BLDR CIKDKOMEENF(AmplitudeAnalyticsIdentifyMessage.RevenueData ENGNMANPOLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x492BB50", Offset = "0x492AF50", VA = "0x18492BB50")]
	public BLDR CCAFHLGDBPC(string PLNALAIILFK, string ANJCCKHBJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2FA9EE0", Offset = "0x2FA92E0", VA = "0x182FA9EE0")]
	public BLDR CCAFHLGDBPC<T>(string PLNALAIILFK, T ANJCCKHBJJO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BGPBKFMLKIB();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x492BB20", Offset = "0x492AF20", VA = "0x18492BB20")]
	internal static string BIDEMGLJMBK(string ANJCCKHBJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x492BC70", Offset = "0x492B070", VA = "0x18492BC70")]
	private BLDR KENLAAFCDEH(string PLNALAIILFK, object ANJCCKHBJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M GGGPHICJMBA();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class OALHNLPDEGB : PELHBMEDFBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct MKLBDMKPPHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<GLKGAIBBIDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public OALHNLPDEGB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5F55290", Offset = "0x5F54690", VA = "0x185F55290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5F55B30", Offset = "0x5F54F30", VA = "0x185F55B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct IDMDEJAIGOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<GLKGAIBBIDC> <>t__builder;

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
		public OALHNLPDEGB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5F52940", Offset = "0x5F51D40", VA = "0x185F52940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5F53370", Offset = "0x5F52770", VA = "0x185F53370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient EDJFGANDFAO;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F55FE0", Offset = "0x5F553E0", VA = "0x185F55FE0")]
	[HMKFFNEGBBO(FMOKCMPGPEB.None)]
	private static void PIAPCNIMDBL(FJIKPBKCIMI BHGHMPIHGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F56050", Offset = "0x5F55450", VA = "0x185F56050")]
	[RecRoom.NoEngine.Common.Preserve]
	public OALHNLPDEGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5F55E90", Offset = "0x5F55290", VA = "0x185F55E90", Slot = "4")]
	[AsyncStateMachine(typeof(MKLBDMKPPHK))]
	public Task<GLKGAIBBIDC> NPDNLENDING(string BEMFBDPELFM, Dictionary<string, string> GDFFLANKKPE, bool PDNICLPPPME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5F55D20", Offset = "0x5F55120", VA = "0x185F55D20", Slot = "5")]
	[AsyncStateMachine(typeof(IDMDEJAIGOM))]
	public Task<GLKGAIBBIDC> KHOHKAIKIKK(string BEMFBDPELFM, string LECOKICIGPG, string IBEOHFCJCGF, string KHNGIMMHPEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ECAKCONHFMI
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> FNODHLMJFDL;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5F50E90", Offset = "0x5F50290", VA = "0x185F50E90")]
	internal static bool IIGCCFGGDGO(string GPGELODKPOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PELHBMEDFBA
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GLKGAIBBIDC> NPDNLENDING(string BEMFBDPELFM, Dictionary<string, string> GDFFLANKKPE, bool PDNICLPPPME = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GLKGAIBBIDC> KHOHKAIKIKK(string BEMFBDPELFM, string LECOKICIGPG, string IBEOHFCJCGF, string KHNGIMMHPEK);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct GLKGAIBBIDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int EHBKONMEPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string PDGDMNAPIKJ;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xB97460", Offset = "0xB96860", VA = "0x180B97460")]
	public GLKGAIBBIDC(int GGEJMGBOGCD, string GNLPGDBMJPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum FGDENMFKDNL
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
public class PDIEIMEJGHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long DLNAHANLOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private BCPGKCOPFBN JLFGCHJAJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool ELMBCLMOBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float DLLGFIKHNBK;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5F58250", Offset = "0x5F57650", VA = "0x185F58250")]
	public PDIEIMEJGHG(string FDMNODKJOAL, float DLLGFIKHNBK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x281F6B0", Offset = "0x281EAB0", VA = "0x18281F6B0")]
	public void ODGNGIBCCEK<T>(string PLNALAIILFK, T ANJCCKHBJJO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5F581D0", Offset = "0x5F575D0", VA = "0x185F581D0")]
	public void ODGNGIBCCEK(string PLNALAIILFK, string ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5F57FD0", Offset = "0x5F573D0", VA = "0x185F57FD0")]
	public void ECPDPGKAOCL(string LFBMJHDFLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5F57EC0", Offset = "0x5F572C0", VA = "0x185F57EC0")]
	public void BAKBFBMFICG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5F580C0", Offset = "0x5F574C0", VA = "0x185F580C0")]
	private void FNHPJDODFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5F57F80", Offset = "0x5F57380", VA = "0x185F57F80")]
	private bool BFHLBEEFBAI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HNMDOIFKIPI
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool HGMIANMMKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string CCIEOIGNHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	ENKEIOKHBLM BKJEFMEOKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action KBEPIPFELEL;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action KNODCJEKIIC;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IIJBCHKFBNI OBMDJKKOMOC(string BKKLLAMMFEJ, string BCEDPIPJOJF, [Optional] EMMGLDNKGLN PFLIDENGDDC);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IIJBCHKFBNI LICGPGIGKMO(EMMGLDNKGLN PFLIDENGDDC);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IIJBCHKFBNI MKHEKINILHA(EMMGLDNKGLN PFLIDENGDDC, Dictionary<string, string> ELDHFMLDEHB);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool CAKFANKBADH(string NIEEKNPBCKB);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EIINNFDGLAC EOLGHAHLJGC(string MIHIPNNDOJC);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	POHJOBNCFGK LCACPFEBDIF(string AAFILBMINPE);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IIJBCHKFBNI OIJANFMNNOO();
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SerializedStatsigExperimentSegment
	{
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
		private string parameterValue;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5F59690", Offset = "0x5F58A90", VA = "0x185F59690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OOEMFNIHAND : HNMDOIFKIPI
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly IReadOnlyDictionary<string, JHHBFKMIJJN> HCNNILJKMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool EHFLHBHHGHF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HGMIANMMKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7EC020", Offset = "0x7EB420", VA = "0x1807EC020", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string CCIEOIGNHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5F56FA0", Offset = "0x5F563A0", VA = "0x185F56FA0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public ENKEIOKHBLM BKJEFMEOKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5F56FB0", Offset = "0x5F563B0", VA = "0x185F56FB0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action KBEPIPFELEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5F56B50", Offset = "0x5F55F50", VA = "0x185F56B50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5F56160", Offset = "0x5F55560", VA = "0x185F56160", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action KNODCJEKIIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5F56AB0", Offset = "0x5F55EB0", VA = "0x185F56AB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5F57340", Offset = "0x5F56740", VA = "0x185F57340", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5F576B0", Offset = "0x5F56AB0", VA = "0x185F576B0", Slot = "8")]
	public IIJBCHKFBNI OBMDJKKOMOC(string BKKLLAMMFEJ, string BCEDPIPJOJF, [Optional] EMMGLDNKGLN PFLIDENGDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5F57C30", Offset = "0x5F57030", VA = "0x185F57C30", Slot = "17")]
	public IIJBCHKFBNI OIJANFMNNOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5F57150", Offset = "0x5F56550", VA = "0x185F57150", Slot = "12")]
	public IIJBCHKFBNI LICGPGIGKMO(EMMGLDNKGLN PFLIDENGDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5F573E0", Offset = "0x5F567E0", VA = "0x185F573E0", Slot = "13")]
	public IIJBCHKFBNI MKHEKINILHA(EMMGLDNKGLN PFLIDENGDDC, Dictionary<string, string> ELDHFMLDEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5F560D0", Offset = "0x5F554D0", VA = "0x185F560D0", Slot = "14")]
	public bool CAKFANKBADH(string NIEEKNPBCKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5F56DA0", Offset = "0x5F561A0", VA = "0x185F56DA0", Slot = "15")]
	public EIINNFDGLAC EOLGHAHLJGC(string MIHIPNNDOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5F570C0", Offset = "0x5F564C0", VA = "0x185F570C0", Slot = "16")]
	public POHJOBNCFGK LCACPFEBDIF(string AAFILBMINPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5F56200", Offset = "0x5F55600", VA = "0x185F56200")]
	private ENKEIOKHBLM DDGNEEGOLED(EMMGLDNKGLN PFLIDENGDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5F56BF0", Offset = "0x5F55FF0", VA = "0x185F56BF0")]
	private PEJJJCLGJMM ENFKHECOJHA(string BCEDPIPJOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5F57B20", Offset = "0x5F56F20", VA = "0x185F57B20")]
	private void ODKJNKAADKG(string MIHIPNNDOJC, EIINNFDGLAC AFBINOJFBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public OOEMFNIHAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA9F000", Offset = "0xA9E400", VA = "0x180A9F000")]
	[CompilerGenerated]
	private void ANHMOMLLENO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5F56FC0", Offset = "0x5F563C0", VA = "0x185F56FC0")]
	[CompilerGenerated]
	private void JLDPCOJBNGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5F57040", Offset = "0x5F56440", VA = "0x185F57040")]
	[CompilerGenerated]
	private void JPCNLIGLOHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class PKMJLCGBGMF : HNMDOIFKIPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private HNMDOIFKIPI BOEMMOEGKIE;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private HNMDOIFKIPI PBEAHKDNFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5F58D30", Offset = "0x5F58130", VA = "0x185F58D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool HGMIANMMKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5F58840", Offset = "0x5F57C40", VA = "0x185F58840", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string CCIEOIGNHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5F587F0", Offset = "0x5F57BF0", VA = "0x185F587F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ENKEIOKHBLM BKJEFMEOKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5F58890", Offset = "0x5F57C90", VA = "0x185F58890", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action KBEPIPFELEL
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5F58640", Offset = "0x5F57A40", VA = "0x185F58640", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5F58500", Offset = "0x5F57900", VA = "0x185F58500", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action KNODCJEKIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5F585A0", Offset = "0x5F579A0", VA = "0x185F585A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5F58B70", Offset = "0x5F57F70", VA = "0x185F58B70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	[UnityEngine.Scripting.Preserve]
	public PKMJLCGBGMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5F583E0", Offset = "0x5F577E0", VA = "0x185F583E0")]
	[HMKFFNEGBBO(FMOKCMPGPEB.GameOnly)]
	private static void BEDMHIEHCCL(FJIKPBKCIMI BHGHMPIHGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5F58DA0", Offset = "0x5F581A0", VA = "0x185F58DA0")]
	[HMKFFNEGBBO(FMOKCMPGPEB.EditorOnly)]
	private static void NABNEEHAKOE(FJIKPBKCIMI BHGHMPIHGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5F58E10", Offset = "0x5F58210", VA = "0x185F58E10", Slot = "8")]
	public IIJBCHKFBNI OBMDJKKOMOC(string BKKLLAMMFEJ, string BCEDPIPJOJF, [Optional] EMMGLDNKGLN PFLIDENGDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5F58A60", Offset = "0x5F57E60", VA = "0x185F58A60", Slot = "12")]
	public IIJBCHKFBNI LICGPGIGKMO(EMMGLDNKGLN PFLIDENGDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5F58C10", Offset = "0x5F58010", VA = "0x185F58C10", Slot = "13")]
	public IIJBCHKFBNI MKHEKINILHA(EMMGLDNKGLN PFLIDENGDDC, Dictionary<string, string> ELDHFMLDEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5F58450", Offset = "0x5F57850", VA = "0x185F58450", Slot = "14")]
	public bool CAKFANKBADH(string NIEEKNPBCKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5F586E0", Offset = "0x5F57AE0", VA = "0x185F586E0", Slot = "15")]
	public EIINNFDGLAC EOLGHAHLJGC(string MIHIPNNDOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5F58950", Offset = "0x5F57D50", VA = "0x185F58950", Slot = "16")]
	public POHJOBNCFGK LCACPFEBDIF(string AAFILBMINPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5F59260", Offset = "0x5F58660", VA = "0x185F59260", Slot = "17")]
	public IIJBCHKFBNI OIJANFMNNOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8D2110", Offset = "0x8D1510", VA = "0x1808D2110")]
	[CompilerGenerated]
	private void OEKJJFHFOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xB94400", Offset = "0xB93800", VA = "0x180B94400")]
	[CompilerGenerated]
	private void EKNAGCOGNEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EFONLELLPNJ : HNMDOIFKIPI
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HGMIANMMKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string CCIEOIGNHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ENKEIOKHBLM BKJEFMEOKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action KBEPIPFELEL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5F51180", Offset = "0x5F50580", VA = "0x185F51180", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5F51040", Offset = "0x5F50440", VA = "0x185F51040", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action KNODCJEKIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5F510E0", Offset = "0x5F504E0", VA = "0x185F510E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5F512D0", Offset = "0x5F506D0", VA = "0x185F512D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	[RecRoom.NoEngine.Common.Preserve]
	public EFONLELLPNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5F51400", Offset = "0x5F50800", VA = "0x185F51400", Slot = "8")]
	public IIJBCHKFBNI OBMDJKKOMOC(string BKKLLAMMFEJ, string BCEDPIPJOJF, [Optional] EMMGLDNKGLN PFLIDENGDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5F51240", Offset = "0x5F50640", VA = "0x185F51240", Slot = "12")]
	public IIJBCHKFBNI LICGPGIGKMO(EMMGLDNKGLN PFLIDENGDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5F51370", Offset = "0x5F50770", VA = "0x185F51370", Slot = "13")]
	public IIJBCHKFBNI MKHEKINILHA(EMMGLDNKGLN PFLIDENGDDC, Dictionary<string, string> ELDHFMLDEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "14")]
	public bool CAKFANKBADH(string NIEEKNPBCKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5F51220", Offset = "0x5F50620", VA = "0x185F51220", Slot = "15")]
	public EIINNFDGLAC EOLGHAHLJGC(string MIHIPNNDOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5F51230", Offset = "0x5F50630", VA = "0x185F51230", Slot = "16")]
	public POHJOBNCFGK LCACPFEBDIF(string AAFILBMINPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5F51490", Offset = "0x5F50890", VA = "0x185F51490", Slot = "17")]
	public IIJBCHKFBNI OIJANFMNNOO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface PBLIKELDKEH
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PDIEIMEJGHG LNEOHHIGIGG(string FDMNODKJOAL);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface FHDFONCLEPF
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum AJPLJJILHOG
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	long OMBGNEHMCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string KJKEHBHKICF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string LKOLKJLLDGB
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string AOLFAMOFGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string AFHNHAPAGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool CEMECDNEKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long EKFHEDKLBJI();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FAKPDEENECG(long NFINLDCGANN, bool GCKILMNMMPG = true);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HCPGGAFDJFP(string HFPPGLCONIA, string BPHDINNFAPM, string HBFNMODJANI);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KFEJGKAPLNE(string HFPPGLCONIA);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PFMDPHCDNAL(string HFPPGLCONIA, string CJBPDEBGJEH, string IMHCBINJOED);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MHPPHODNCMM(string FDIHAPIDLHM, object PKODOAHBOGO, object HGADDNGMMMB);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PODIOGEGNDC(AJPLJJILHOG CMDMFMLBOBL, int LBOHBLKMJHE, [Optional] AJCBAGBIJEO IAEFMMJOKGP, [Optional] string MCLPGCAKNCK, [Optional] string FHHKCHCDKKO);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HLJONCBILKJ(AJCBAGBIJEO IAEFMMJOKGP, long BMNNPJKANDP, long GAFNOLGEMAF, int IACJPKHODDO, string MCLPGCAKNCK, int LBOHBLKMJHE);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OHKOMAHCHLJ(AJCBAGBIJEO IAEFMMJOKGP, bool GDPLLPCFBNP, [Optional] string FHHKCHCDKKO);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CLHEBPJHPJH(AJCBAGBIJEO IAEFMMJOKGP, bool GDPLLPCFBNP, [Optional] string FHHKCHCDKKO);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HNIMILBNJFF(AJCBAGBIJEO IAEFMMJOKGP, bool GDPLLPCFBNP, [Optional] string FHHKCHCDKKO);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EMMGLDNKGLN
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool OADDOKNONPA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool CIHFKFLCEDN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool ICDKLKJMDFK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool? MNABAFDDHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	int? AEDKFMCMAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	int MDLCLBHGDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string CDCHCILFPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string HOHNAPBGEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string AIGBJFJCDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	long NALJDJCBEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string BFCDNFGGOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string KGNEGCNEFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string LBNJGGOALBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string PFPDGLIGLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	string GHEBIJLJDAL
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	double DNLOEJNGJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	int EHBFPPPBKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string OHPJLBHPDGE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string EAHJLBDKLLE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Guid? NFOBKDKPECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "19")]
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
