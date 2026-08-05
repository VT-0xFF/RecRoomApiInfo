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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E7D1A0", Offset = "0x5E7BBA0", VA = "0x185E7D1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D25A0", Offset = "0x7D0FA0", VA = "0x1807D25A0")]
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
		public AmplitudeAnalyticsClient.Settings GOMCIKFAIEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ALANLHCAAGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7A9210", Offset = "0x7A7C10", VA = "0x1807A9210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum ICKFDNJEOCE
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class JPMAKHHFJLF
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class CPCGLPAANKP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int EKPNNJOFBMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> MHKOHCNPPOG;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
				public CPCGLPAANKP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class MPJNODFIKLA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
				public MPJNODFIKLA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5E7D130", Offset = "0x5E7BB30", VA = "0x185E7D130")]
				internal bool HIDDBLEFABF(CPCGLPAANKP item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string LEIIIJEKODK = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string KGIHKOADMFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<CPCGLPAANKP> DEKAPKNBMPF;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? MLPANBICPNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5E7B5D0", Offset = "0x5E79FD0", VA = "0x185E7B5D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C420", Offset = "0x5E7AE20", VA = "0x185E7C420")]
			internal JPMAKHHFJLF(string HPACCCBEKOF, string OONFPPOKDON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B310", Offset = "0x5E79D10", VA = "0x185E7B310")]
			public int BGMPGFEGCIB([Optional] int? HKOJONOHKMK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B670", Offset = "0x5E7A070", VA = "0x185E7B670")]
			public List<Dictionary<string, object>> LEBHIIJMOFC(int IKCPAOEPFOF, int? HKOJONOHKMK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B160", Offset = "0x5E79B60", VA = "0x185E7B160")]
			public void ABOFJGDKCCK(AmplitudeAnalyticsIdentifyMessage MBCPMMHPENP, bool HJKPOFGMKDI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B200", Offset = "0x5E79C00", VA = "0x185E7B200")]
			public void ABOFJGDKCCK(Dictionary<string, object> MBCPMMHPENP, bool HJKPOFGMKDI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B8E0", Offset = "0x5E7A2E0", VA = "0x185E7B8E0")]
			public void NALAALIIGEI(params Dictionary<string, object>[] GIMGLGOBHFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5E7BBA0", Offset = "0x5E7A5A0", VA = "0x185E7BBA0")]
			public void NHMJEPGKDOL(List<Dictionary<string, object>> FBFPOJCKOOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B4C0", Offset = "0x5E79EC0", VA = "0x185E7B4C0")]
			private void CDLMBNEABGD(Dictionary<string, object> MBCPMMHPENP, bool HJKPOFGMKDI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C1E0", Offset = "0x5E7ABE0", VA = "0x185E7C1E0")]
			public void OPLOLDBBKIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5E7BDF0", Offset = "0x5E7A7F0", VA = "0x185E7BDF0")]
			private void NKIDBHHKNLC([Optional] string BHENJOPEDOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5E7BA70", Offset = "0x5E7A470", VA = "0x185E7BA70")]
			private static string NDCCLADPBPN(string FDFHGIHHGHO, string KCGLPAPOILB)
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
			[Cpp2IlInjected.Address(RVA = "0x5E7E4E0", Offset = "0x5E7CEE0", VA = "0x185E7E4E0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct IFDIBPOCCMA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int FMHHNIBMKCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string JJDAIPNHEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T CNNGMPKFABB;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class OBKGDHGCOLA : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private FLFEOAPLLLI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
			[DebuggerHidden]
			public OBKGDHGCOLA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5E7D500", Offset = "0x5E7BF00", VA = "0x185E7D500", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DCC0", Offset = "0x5E7C6C0", VA = "0x185E7DCC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class DKNJBLMEBNN : IEnumerator<object>, IEnumerator, IDisposable
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
			public LCADBCNGFBM quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
			[DebuggerHidden]
			public DKNJBLMEBNN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5E76450", Offset = "0x5E74E50", VA = "0x185E76450", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5E76560", Offset = "0x5E74F60", VA = "0x185E76560", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class EOOJDAIIPHC : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
			[DebuggerHidden]
			public EOOJDAIIPHC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5E78520", Offset = "0x5E76F20", VA = "0x185E78520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5E78690", Offset = "0x5E77090", VA = "0x185E78690", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class GHPBDKJGGMA : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private FLFEOAPLLLI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
			[DebuggerHidden]
			public GHPBDKJGGMA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A110", Offset = "0x5E78B10", VA = "0x185E7A110", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A390", Offset = "0x5E78D90", VA = "0x185E7A390", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class OABGNIAPGHM : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private FLFEOAPLLLI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
			[DebuggerHidden]
			public OABGNIAPGHM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5E7D220", Offset = "0x5E7BC20", VA = "0x185E7D220", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5E7D4B0", Offset = "0x5E7BEB0", VA = "0x185E7D4B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class KMNBNKCNDLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public JPMAKHHFJLF cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public KMNBNKCNDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5E7CA60", Offset = "0x5E7B460", VA = "0x185E7CA60")]
			internal void FNCDHAOFJKE(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C610", Offset = "0x5E7B010", VA = "0x185E7C610")]
			internal void DOPDFGNAIDP(IFDIBPOCCMA<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class IBAJHDHJEMM : IEnumerator<FLFEOAPLLLI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private FLFEOAPLLLI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public JPMAKHHFJLF cache;

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
			private KMNBNKCNDLC <>8__1;

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
			private FLFEOAPLLLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
			[DebuggerHidden]
			public IBAJHDHJEMM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A8C0", Offset = "0x5E792C0", VA = "0x185E7A8C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B110", Offset = "0x5E79B10", VA = "0x185E7B110", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class BNIOIGNLFMB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public BNIOIGNLFMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x36558C0", Offset = "0x36542C0", VA = "0x1836558C0")]
			internal IFDIBPOCCMA<T> HIMGHKPJOHJ(DNKCCIAMKNK postResponse)
			{
				return default(IFDIBPOCCMA<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class AADJOEDMAMP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public AADJOEDMAMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x36558C0", Offset = "0x36542C0", VA = "0x1836558C0")]
			internal IFDIBPOCCMA<T> NEDMHCDLLFO(DNKCCIAMKNK postResponse)
			{
				return default(IFDIBPOCCMA<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private BCENPLIMBOF KHCMNHDOBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<HANEFLPALEB> AINGBANCAGN;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string AEJPMBKNFHD = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string ECHIBEIIMIF = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string DPGBNHHKIOL = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int AGNJOEOIJGK = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int BHCPKKKPFFH = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int CPKKICIFMFB = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float FFACDEPCGFB = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long GLDDGAIOEFF = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string CJABFKNEEMM = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string GANIBGLBMIJ = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool GLPMGHPCOAF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool HNMDDOCNEOG;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int AEEHGDBEFGC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int HGNLEIHKFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private GLDOIEGLBEN PDMCLBPMINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private MODHJKGINOE PIMCAFEGLCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private KMHILAGGKPN HPMJJODIKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool FPOKPJCPIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float DPMDFGEPEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float FHGONAICCKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int NGINFBHKIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int HIKPNLAAGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? LGPFNMDNJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? ABJFIBALDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long ICIBCDCBCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string DMNHPBCIACI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool KIIHIEKIPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long AEHFOALNFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string HNMABPFIEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string EPMHJMBHPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> IEOFBIILCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private ICKFDNJEOCE OBFIMCABNEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int ACPDAFFDBMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int MCOFHGINAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float COEKHAMMDOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool HNEDENOBGGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool CNNIDEGLBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private JPMAKHHFJLF KDKJHGEHJCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private JPMAKHHFJLF GPABOMFEIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private JPMAKHHFJLF LJMLFFPDKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> IIEMNLDNAHM;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo ENONFAFKNAF;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string FBDDCLOFLCJ;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string LDEMCDNGOBC = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string EDJNDODBFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string IOANMFGOGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string IEDOCPDOAKH;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BCENPLIMBOF JPGENIPPICN
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5E6F160", Offset = "0x5E6DB60", VA = "0x185E6F160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HANEFLPALEB AJOFFHLBKFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5E6F9A0", Offset = "0x5E6E3A0", VA = "0x185E6F9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int FLFLKLGMODO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5E70D10", Offset = "0x5E6F710", VA = "0x185E70D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long EBNJHDALOOC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E74CB0", Offset = "0x5E736B0", VA = "0x185E74CB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5E74DD0", Offset = "0x5E737D0", VA = "0x185E74DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string HJILCCHMAPP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5E74C50", Offset = "0x5E73650", VA = "0x185E74C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string CFGBHMLFONO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5E74C80", Offset = "0x5E73680", VA = "0x185E74C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PLAHGHHFDGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x85E060", Offset = "0x85CA60", VA = "0x18085E060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x85DC10", Offset = "0x85C610", VA = "0x18085DC10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? EANDIGFADLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8899F0", Offset = "0x8883F0", VA = "0x1808899F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5E74DC0", Offset = "0x5E737C0", VA = "0x185E74DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GJBEDGBDCKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF08CB0", Offset = "0xF076B0", VA = "0x180F08CB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xF08D60", Offset = "0xF07760", VA = "0x180F08D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool IIAAEEBDLCP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5E74B50", Offset = "0x5E73550", VA = "0x185E74B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> BKLNGJDIAHP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5E74A90", Offset = "0x5E73490", VA = "0x185E74A90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5E74D00", Offset = "0x5E73700", VA = "0x185E74D00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F340", Offset = "0x5E6DD40", VA = "0x185E6F340", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E71410", Offset = "0x5E6FE10", VA = "0x185E71410")]
		private void JIOGCBMABJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5E74070", Offset = "0x5E72A70", VA = "0x185E74070")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E73250", Offset = "0x5E71C50", VA = "0x185E73250", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E74410", Offset = "0x5E72E10", VA = "0x185E74410")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E73310", Offset = "0x5E71D10", VA = "0x185E73310")]
		public BCACLFKFPHI PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E71380", Offset = "0x5E6FD80", VA = "0x185E71380")]
		[IteratorStateMachine(typeof(OBKGDHGCOLA))]
		public IEnumerator<FLFEOAPLLLI> Initialize(AmplitudeAnalyticsEvent DDJFONBEHLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E74350", Offset = "0x5E72D50", VA = "0x185E74350")]
		public void UpdateLastKnownInteractionCategory(string EHGPEDKIHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E74260", Offset = "0x5E72C60", VA = "0x185E74260")]
		public void UpdateLastAliveTime(float PLEPJKNDBHF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E73100", Offset = "0x5E71B00", VA = "0x185E73100")]
		private BCACLFKFPHI OFFGONDNBDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E70460", Offset = "0x5E6EE60", VA = "0x185E70460")]
		private BCACLFKFPHI FGCIADLBLAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E73AC0", Offset = "0x5E724C0", VA = "0x185E73AC0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F7B0", Offset = "0x5E6E1B0", VA = "0x185E6F7B0")]
		[IteratorStateMachine(typeof(DKNJBLMEBNN))]
		private IEnumerator BFNIJMDCMFF(LCADBCNGFBM AJBAJAONONC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5E746A0", Offset = "0x5E730A0", VA = "0x185E746A0")]
		[IteratorStateMachine(typeof(EOOJDAIIPHC))]
		public IEnumerator WaitForFlush(float ILFNCCAINDB = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E74140", Offset = "0x5E72B40", VA = "0x185E74140")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E74080", Offset = "0x5E72A80", VA = "0x185E74080")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime BEBEFOHACKO)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E70EF0", Offset = "0x5E6F8F0", VA = "0x185E70EF0")]
		public static PCEFFHLINCO Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F1D0", Offset = "0x5E6DBD0", VA = "0x185E6F1D0")]
		public static AKPBONJGHHM AccountSelectionPostLoginEvent([NotNull] string CDLPMFNEOJE, string LFGJDFDHDAL, bool MKAAFPCPMNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E70160", Offset = "0x5E6EB60", VA = "0x185E70160")]
		public static AKPBONJGHHM Event([NotNull] string CDLPMFNEOJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E73350", Offset = "0x5E71D50", VA = "0x185E73350")]
		public static AKPBONJGHHM PreviousSessionEvent([NotNull] string CDLPMFNEOJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5E710A0", Offset = "0x5E6FAA0", VA = "0x185E710A0")]
		public static AKPBONJGHHM InitializeEvent(string LFGJDFDHDAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5E73C80", Offset = "0x5E72680", VA = "0x185E73C80")]
		public static AKPBONJGHHM StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F9F0", Offset = "0x5E6E3F0", VA = "0x185E6F9F0")]
		public static AKPBONJGHHM CreateOutOfSessionEvent(string CDLPMFNEOJE, bool MKGDGKCJOKL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E72A20", Offset = "0x5E71420", VA = "0x185E72A20")]
		public static BCACLFKFPHI LogOutOfSessionEvent(AKPBONJGHHM JNBOLMFMLBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5E727A0", Offset = "0x5E711A0", VA = "0x185E727A0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LABMNJOCDHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5E72D10", Offset = "0x5E71710", VA = "0x185E72D10")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LABMNJOCDHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5E72E50", Offset = "0x5E71850", VA = "0x185E72E50")]
		public void LogSerializedEventAsync(Dictionary<string, object> PFEJOEKCKEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5E728E0", Offset = "0x5E712E0", VA = "0x185E728E0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage MFNCCBCCBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5E70C10", Offset = "0x5E6F610", VA = "0x185E70C10")]
		private void IMJILOKJOMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E70840", Offset = "0x5E6F240", VA = "0x185E70840")]
		private void FMNBGEGLEBG(Dictionary<string, object> NCPFGEDHINI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E70750", Offset = "0x5E6F150", VA = "0x185E70750")]
		private void FIIPMEIGPNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E72F30", Offset = "0x5E71930", VA = "0x185E72F30")]
		private void MMCFONFIONG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E70AF0", Offset = "0x5E6F4F0", VA = "0x185E70AF0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E731C0", Offset = "0x5E71BC0", VA = "0x185E731C0")]
		[IteratorStateMachine(typeof(GHPBDKJGGMA))]
		private IEnumerator<FLFEOAPLLLI> OMLBHGKNPJE(float ILFNCCAINDB = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5E70B80", Offset = "0x5E6F580", VA = "0x185E70B80")]
		[IteratorStateMachine(typeof(OABGNIAPGHM))]
		private IEnumerator<FLFEOAPLLLI> GJAFBHJHFIP(float ILFNCCAINDB = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FC50", Offset = "0x5E6E650", VA = "0x185E6FC50")]
		[IteratorStateMachine(typeof(IBAJHDHJEMM))]
		private IEnumerator<FLFEOAPLLLI> DLOCMJKOECB(JPMAKHHFJLF KLBHFGGIOJI, int? HKOJONOHKMK, string IHFNBCFKLMD, string JEKHBGKAFJC, float ILFNCCAINDB, Action<int> IHEAAPAEHAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5E719B0", Offset = "0x5E703B0", VA = "0x185E719B0")]
		private static void JPHIGMPFNFF(bool LDGHCHMOOHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5E70030", Offset = "0x5E6EA30", VA = "0x185E70030")]
		private JMGBCNAMNAH<IFDIBPOCCMA<Dictionary<string, object>>> EKOLCKDPPNC(string IHFNBCFKLMD, string JEKHBGKAFJC, string EIBGDDFOALL, string KELMBPLJFPB, Dictionary<string, object> CNNGMPKFABB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FD50", Offset = "0x5E6E750", VA = "0x185E6FD50")]
		private JMGBCNAMNAH<IFDIBPOCCMA<List<Dictionary<string, object>>>> EKOLCKDPPNC(string IHFNBCFKLMD, string JEKHBGKAFJC, string EIBGDDFOALL, string KELMBPLJFPB, List<Dictionary<string, object>> CNNGMPKFABB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2C85A10", Offset = "0x2C84410", VA = "0x182C85A10")]
		private JMGBCNAMNAH<IFDIBPOCCMA<T>> OKLDFHACPEO<T>(string IHFNBCFKLMD, string JEKHBGKAFJC, string KELMBPLJFPB, T CNNGMPKFABB, Dictionary<string, object> CJHPIELEJAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2C856C0", Offset = "0x2C840C0", VA = "0x182C856C0")]
		private JMGBCNAMNAH<IFDIBPOCCMA<T>> NLJLPOFDDFB<T>(string IHFNBCFKLMD, string JEKHBGKAFJC, string EIBGDDFOALL, T CNNGMPKFABB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F110", Offset = "0x5E6DB10", VA = "0x185E6F110")]
		private bool AHPKBMLGGFP(float HJNMDPFOKNI, float ILFNCCAINDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E71AD0", Offset = "0x5E704D0", VA = "0x185E71AD0")]
		private Dictionary<string, object> KPEHMFGGOHP(string JEKHBGKAFJC, Dictionary<string, object> CNNGMPKFABB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E74790", Offset = "0x5E73190", VA = "0x185E74790")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F840", Offset = "0x5E6E240", VA = "0x185E6F840")]
		[CompilerGenerated]
		private long BHLFNDOCNMP()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E71AC0", Offset = "0x5E704C0", VA = "0x185E71AC0")]
		[CompilerGenerated]
		private void KGOOIKCFGGN(int ANAJGJGNEJP)
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
			[Cpp2IlInjected.Address(RVA = "0x5E75B30", Offset = "0x5E74530", VA = "0x185E75B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5E75C10", Offset = "0x5E74610", VA = "0x185E75C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5E75B70", Offset = "0x5E74570", VA = "0x185E75B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5E75C70", Offset = "0x5E74670", VA = "0x185E75C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5E75AF0", Offset = "0x5E744F0", VA = "0x185E75AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5E75BB0", Offset = "0x5E745B0", VA = "0x185E75BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7A9130", Offset = "0x7A7B30", VA = "0x1807A9130")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5E75860", Offset = "0x5E74260", VA = "0x185E75860")]
		public static AKPBONJGHHM NDFPICIGPEG(string OMDPMMKPCNP, [NotNull] string INLGHBKANHG, long HFHDELPKMEG, long FKAJLBIHGJM, string LFGJDFDHDAL, bool MKAAFPCPMNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E75700", Offset = "0x5E74100", VA = "0x185E75700")]
		public static AKPBONJGHHM KMALCPCCNGP(string OMDPMMKPCNP, [NotNull] string INLGHBKANHG, long HFHDELPKMEG, long FKAJLBIHGJM, string LFGJDFDHDAL, long KPDMKKPCAFG, bool MKAAFPCPMNC, string AKAOHFMJADP, string JHGMDMBKCFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E75960", Offset = "0x5E74360", VA = "0x185E75960")]
		private AmplitudeAnalyticsEvent(string OMDPMMKPCNP, [NotNull] string INLGHBKANHG, long HFHDELPKMEG, long FKAJLBIHGJM, string LFGJDFDHDAL, bool MKAAFPCPMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x19EA0C0", Offset = "0x19E8AC0", VA = "0x1819EA0C0")]
		public void FFKHJPMCDGM(long NNIIPBNFBDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5E74F40", Offset = "0x5E73940", VA = "0x185E74F40", Slot = "5")]
		public override void FGENEGJEMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E75050", Offset = "0x5E73A50", VA = "0x185E75050", Slot = "6")]
		public override void JFNGPCFPJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E751D0", Offset = "0x5E73BD0", VA = "0x185E751D0", Slot = "4")]
		protected override Dictionary<string, object> JMMGLHNHACE(Dictionary<string, object> DBHBKEPKFON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E74E30", Offset = "0x5E73830", VA = "0x185E74E30")]
		private void FFDENOLEKKF(string KCGLPAPOILB, string FDFHGIHHGHO, bool FDJPPJDALOG = false)
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
			[Cpp2IlInjected.Address(RVA = "0x5E783A0", Offset = "0x5E76DA0", VA = "0x185E783A0")]
			public void MJGOHEGDOIB(Dictionary<string, object> KADELMNFDHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E7E170", Offset = "0x5E7CB70", VA = "0x185E7E170")]
			public void MJGOHEGDOIB(Dictionary<string, object> GCHHNDBJMLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A8D80", Offset = "0x8A7780", VA = "0x1808A8D80")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A7E40", VA = "0x1807A9440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5E76240", Offset = "0x5E74C40", VA = "0x185E76240")]
		public static PCEFFHLINCO NDFPICIGPEG(string OMDPMMKPCNP, string LFGJDFDHDAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5E76390", Offset = "0x5E74D90", VA = "0x185E76390")]
		protected AmplitudeAnalyticsIdentifyMessage(string OMDPMMKPCNP, string LFGJDFDHDAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5E76300", Offset = "0x5E74D00", VA = "0x185E76300")]
		public Dictionary<string, object> OMBBHJFAMHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5E75F00", Offset = "0x5E74900", VA = "0x185E75F00", Slot = "4")]
		protected virtual Dictionary<string, object> JMMGLHNHACE(Dictionary<string, object> DBHBKEPKFON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5E75CD0", Offset = "0x5E746D0", VA = "0x185E75CD0")]
		protected void BNGLNJINGBO(string KCGLPAPOILB, Dictionary<string, object> LMIDFGEBCCH, Dictionary<string, object> LLDKLCICPCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E75D70", Offset = "0x5E74770", VA = "0x185E75D70")]
		protected void EGOFJGBBEOF(string KCGLPAPOILB, string FDFHGIHHGHO, Dictionary<string, object> ILDBCNKLHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E75DE0", Offset = "0x5E747E0", VA = "0x185E75DE0", Slot = "5")]
		public virtual void FGENEGJEMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E75E70", Offset = "0x5E74870", VA = "0x185E75E70", Slot = "6")]
		public virtual void JFNGPCFPJGA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PCEFFHLINCO : LMBPNBGEAKM<AmplitudeAnalyticsIdentifyMessage, PCEFFHLINCO>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override PCEFFHLINCO LGBPEGJFIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x877270", Offset = "0x875C70", VA = "0x180877270", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage KGKNHALPIHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E120", Offset = "0x5E7CB20", VA = "0x185E7E120")]
	public PCEFFHLINCO(AmplitudeAnalyticsIdentifyMessage DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E070", Offset = "0x5E7CA70", VA = "0x185E7E070", Slot = "4")]
	public override void JFNGPCFPJGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class AKPBONJGHHM : LMBPNBGEAKM<AmplitudeAnalyticsEvent, AKPBONJGHHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool GLKJKHOEOPN;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override AKPBONJGHHM LGBPEGJFIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x877270", Offset = "0x875C70", VA = "0x180877270", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long JILOAGEIGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6EF60", Offset = "0x5E6D960", VA = "0x185E6EF60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F0C0", Offset = "0x5E6DAC0", VA = "0x185E6F0C0")]
	public AKPBONJGHHM(AmplitudeAnalyticsEvent DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200", Slot = "5")]
	public override AmplitudeAnalyticsEvent KGKNHALPIHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EF80", Offset = "0x5E6D980", VA = "0x185E6EF80", Slot = "4")]
	public override void JFNGPCFPJGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C619D0", Offset = "0x2C603D0", VA = "0x182C619D0")]
	public AKPBONJGHHM HLNDDDDAOLC<T>(string EEAABMKADCD, T[] FDFHGIHHGHO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2C619D0", Offset = "0x2C603D0", VA = "0x182C619D0")]
	public AKPBONJGHHM HLNDDDDAOLC(string EEAABMKADCD, string[] FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2C61720", Offset = "0x2C60120", VA = "0x182C61720")]
	public AKPBONJGHHM HLNDDDDAOLC<T>(string EEAABMKADCD, T FDFHGIHHGHO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EEE0", Offset = "0x5E6D8E0", VA = "0x185E6EEE0")]
	public AKPBONJGHHM HLNDDDDAOLC(string EEAABMKADCD, long FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EE70", Offset = "0x5E6D870", VA = "0x185E6EE70")]
	public AKPBONJGHHM HLNDDDDAOLC(string EEAABMKADCD, string FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E6ED40", Offset = "0x5E6D740", VA = "0x185E6ED40")]
	public AKPBONJGHHM EABDDBEFMON(string EEAABMKADCD, object? FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F020", Offset = "0x5E6DA20", VA = "0x185E6F020")]
	public AKPBONJGHHM KIJODJNMFHL(string EEAABMKADCD, string FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E6ED70", Offset = "0x5E6D770", VA = "0x185E6ED70")]
	private AKPBONJGHHM HCGPHNFMAAJ(string EEAABMKADCD, object FDFHGIHHGHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OLPKIKLKMKA : AKPBONJGHHM
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F0C0", Offset = "0x5E6DAC0", VA = "0x185E6F0C0")]
	public OLPKIKLKMKA(AmplitudeAnalyticsEvent DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E7DEC0", Offset = "0x5E7C8C0", VA = "0x185E7DEC0", Slot = "4")]
	public override void JFNGPCFPJGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class LMBPNBGEAKM<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : LMBPNBGEAKM<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M DCKDMGKGDFN;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR LGBPEGJFIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public LMBPNBGEAKM(M DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3B9DAB0", Offset = "0x3B9C4B0", VA = "0x183B9DAB0")]
	public BLDR JJBHIPCMGGD(AmplitudeAnalyticsIdentifyMessage.DeviceInfo PJJMKLDJJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D9E0", Offset = "0x3B9C3E0", VA = "0x183B9D9E0")]
	public BLDR EHMGFJJMFOC(AmplitudeAnalyticsIdentifyMessage.RevenueData FEKJJEJGNNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3B9DA30", Offset = "0x3B9C430", VA = "0x183B9DA30")]
	public BLDR FNBFFMCCHFF(string EEAABMKADCD, string FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x25BD850", Offset = "0x25BC250", VA = "0x1825BD850")]
	public BLDR FNBFFMCCHFF<T>(string EEAABMKADCD, T FDFHGIHHGHO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JFNGPCFPJGA();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3B9DB00", Offset = "0x3B9C500", VA = "0x183B9DB00")]
	internal static string LNKOIPKICFA(string FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D8E0", Offset = "0x3B9C2E0", VA = "0x183B9D8E0")]
	private BLDR DGHCENODNHJ(string EEAABMKADCD, object FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M KGKNHALPIHC();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class LHKLDCCACHC : GLDOIEGLBEN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct ACCMEBGIAIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<DNKCCIAMKNK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public LHKLDCCACHC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5E6E430", Offset = "0x5E6CE30", VA = "0x185E6E430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6ECD0", Offset = "0x5E6D6D0", VA = "0x185E6ECD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct FPDFNGBADJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<DNKCCIAMKNK> <>t__builder;

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
		public LHKLDCCACHC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5E786E0", Offset = "0x5E770E0", VA = "0x185E786E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E79110", Offset = "0x5E77B10", VA = "0x185E79110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient HPADMLEFMAH;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D040", Offset = "0x5E7BA40", VA = "0x185E7D040")]
	[NEHHKLCIMGL(OJLOCLENGNC.None)]
	private static void LHEJOCHGLBC(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D0B0", Offset = "0x5E7BAB0", VA = "0x185E7D0B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LHKLDCCACHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CD80", Offset = "0x5E7B780", VA = "0x185E7CD80", Slot = "4")]
	[AsyncStateMachine(typeof(ACCMEBGIAIA))]
	public Task<DNKCCIAMKNK> EKOLCKDPPNC(string IHFNBCFKLMD, Dictionary<string, string> AGFGKJEJPOM, bool KGPBICGIJND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CED0", Offset = "0x5E7B8D0", VA = "0x185E7CED0", Slot = "5")]
	[AsyncStateMachine(typeof(FPDFNGBADJM))]
	public Task<DNKCCIAMKNK> IJKEDELIDPA(string IHFNBCFKLMD, string KBFNFCIEMOD, string FOEGIHHJHAA, string KJENBJOEHEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ODNPBEBJBIL
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> LMPBMDKLHHL;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E7DD10", Offset = "0x5E7C710", VA = "0x185E7DD10")]
	internal static bool OOPAIGCHNII(string KCGLPAPOILB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GLDOIEGLBEN
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DNKCCIAMKNK> EKOLCKDPPNC(string IHFNBCFKLMD, Dictionary<string, string> AGFGKJEJPOM, bool KGPBICGIJND = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DNKCCIAMKNK> IJKEDELIDPA(string IHFNBCFKLMD, string KBFNFCIEMOD, string FOEGIHHJHAA, string KJENBJOEHEC);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DNKCCIAMKNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int JNIKAKHJKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string FCONKAGHCHG;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xBAADD0", Offset = "0xBA97D0", VA = "0x180BAADD0")]
	public DNKCCIAMKNK(int FMHHNIBMKCK, string JJDAIPNHEKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum JBAFNPMCHGI
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
public class AAFMDGIBHBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long OIDNEOMJCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private AKPBONJGHHM LODJNELOEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool OIHBBHJHEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float GBBAMCDMFOE;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E2A0", Offset = "0x5E6CCA0", VA = "0x185E6E2A0")]
	public AAFMDGIBHBL(string ONKEONDDBLL, float GBBAMCDMFOE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C6E0", Offset = "0x2C5B0E0", VA = "0x182C5C6E0")]
	public void HLNDDDDAOLC<T>(string EEAABMKADCD, T FDFHGIHHGHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E0C0", Offset = "0x5E6CAC0", VA = "0x185E6E0C0")]
	public void HLNDDDDAOLC(string EEAABMKADCD, string FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DF10", Offset = "0x5E6C910", VA = "0x185E6DF10")]
	public void ACIFCHFLCBO(string ABACEHFNNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E000", Offset = "0x5E6CA00", VA = "0x185E6E000")]
	public void BPCFHCIGLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E140", Offset = "0x5E6CB40", VA = "0x185E6E140")]
	private void KCKEPFBONIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E250", Offset = "0x5E6CC50", VA = "0x185E6E250")]
	private bool NFPFCFILNCG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IHEGMKEPADJ
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool FEJBNDKBHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string PLAHGHHFDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	LLNKIAFJBCM EOJCFCFOAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action BNKHAODHJHM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action FNEJIDEPFFE;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BCACLFKFPHI NGFHLNOOHDK(string BNMBEAJFNJE, string OONFPPOKDON, [Optional] MODHJKGINOE MFIBKFGAANK);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BCACLFKFPHI LOCJFIILGEI(MODHJKGINOE MFIBKFGAANK);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BCACLFKFPHI EKFCCPCCLIP(MODHJKGINOE MFIBKFGAANK, Dictionary<string, string> KJGFMHJKPNI);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IIFIJFPHHHD(string KOGPIBPEDII);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GENBCAJKIAP MGFEGFDMLBF(string ICDNHPHINKF);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JKIONIJGNMA LPKEBPHKNCO(string HDFPBKEPDBL);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BCACLFKFPHI MCHNBGCAHOP();
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum GFMDPLEJAMB
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
		private GFMDPLEJAMB parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public GFMDPLEJAMB Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8C30C0", Offset = "0x8C1AC0", VA = "0x1808C30C0")]
			get
			{
				return default(GFMDPLEJAMB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7FDF40", Offset = "0x7FC940", VA = "0x1807FDF40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E2E0", Offset = "0x5E7CCE0", VA = "0x185E7E2E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class DONIHKMFLAC : IHEGMKEPADJ
{
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly IReadOnlyDictionary<string, KAHJJHANCFC> DPEKNEEKFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool EHOOOIGPALP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool FEJBNDKBHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7F4420", Offset = "0x7F2E20", VA = "0x1807F4420", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string PLAHGHHFDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E772F0", Offset = "0x5E75CF0", VA = "0x185E772F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public LLNKIAFJBCM EOJCFCFOAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E76900", Offset = "0x5E75300", VA = "0x185E76900", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BNKHAODHJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E77570", Offset = "0x5E75F70", VA = "0x185E77570", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E777B0", Offset = "0x5E761B0", VA = "0x185E777B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action FNEJIDEPFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E781C0", Offset = "0x5E76BC0", VA = "0x185E781C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E769A0", Offset = "0x5E753A0", VA = "0x185E769A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E77BA0", Offset = "0x5E765A0", VA = "0x185E77BA0", Slot = "8")]
	public BCACLFKFPHI NGFHLNOOHDK(string BNMBEAJFNJE, string OONFPPOKDON, [Optional] MODHJKGINOE MFIBKFGAANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E77850", Offset = "0x5E76250", VA = "0x185E77850", Slot = "17")]
	public BCACLFKFPHI MCHNBGCAHOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E77380", Offset = "0x5E75D80", VA = "0x185E77380", Slot = "12")]
	public BCACLFKFPHI LOCJFIILGEI(MODHJKGINOE MFIBKFGAANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E765B0", Offset = "0x5E74FB0", VA = "0x185E765B0", Slot = "13")]
	public BCACLFKFPHI EKFCCPCCLIP(MODHJKGINOE MFIBKFGAANK, Dictionary<string, string> KJGFMHJKPNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E76910", Offset = "0x5E75310", VA = "0x185E76910", Slot = "14")]
	public bool IIFIJFPHHHD(string KOGPIBPEDII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5E779A0", Offset = "0x5E763A0", VA = "0x185E779A0", Slot = "15")]
	public GENBCAJKIAP MGFEGFDMLBF(string ICDNHPHINKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5E77720", Offset = "0x5E76120", VA = "0x185E77720", Slot = "16")]
	public JKIONIJGNMA LPKEBPHKNCO(string HDFPBKEPDBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5E76A40", Offset = "0x5E75440", VA = "0x185E76A40")]
	private LLNKIAFJBCM KAKDCKGNHDG(MODHJKGINOE MFIBKFGAANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5E78010", Offset = "0x5E76A10", VA = "0x185E78010")]
	private LOPPDHJIOCH OIALFDPCJIL(string OONFPPOKDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5E77610", Offset = "0x5E76010", VA = "0x185E77610")]
	private void LOMOKCFILBA(string ICDNHPHINKF, GENBCAJKIAP IEOEELMKLEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public DONIHKMFLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xAA2A50", Offset = "0xAA1450", VA = "0x180AA2A50")]
	[CompilerGenerated]
	private void FMJLGELBIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E77300", Offset = "0x5E75D00", VA = "0x185E77300")]
	[CompilerGenerated]
	private void LIAHJDPCBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E76880", Offset = "0x5E75280", VA = "0x185E76880")]
	[CompilerGenerated]
	private void HODNCBKJBOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GFCOMJNHIFC : IHEGMKEPADJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private IHEGMKEPADJ KMAPBDOAJFL;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private IHEGMKEPADJ EFMEBNACKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5E79360", Offset = "0x5E77D60", VA = "0x185E79360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FEJBNDKBHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5E79180", Offset = "0x5E77B80", VA = "0x185E79180", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string PLAHGHHFDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5E79650", Offset = "0x5E78050", VA = "0x185E79650", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public LLNKIAFJBCM EOJCFCFOAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5E793D0", Offset = "0x5E77DD0", VA = "0x185E793D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action BNKHAODHJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5E797B0", Offset = "0x5E781B0", VA = "0x185E797B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5E79960", Offset = "0x5E78360", VA = "0x185E79960", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action FNEJIDEPFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A070", Offset = "0x5E78A70", VA = "0x185E7A070", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5E795B0", Offset = "0x5E77FB0", VA = "0x185E795B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	[UnityEngine.Scripting.Preserve]
	public GFCOMJNHIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5E79540", Offset = "0x5E77F40", VA = "0x185E79540")]
	[NEHHKLCIMGL(OJLOCLENGNC.GameOnly)]
	private static void JAMHGAPJMJA(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5E792F0", Offset = "0x5E77CF0", VA = "0x185E792F0")]
	[NEHHKLCIMGL(OJLOCLENGNC.EditorOnly)]
	private static void EKMHBNFFOMP(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5E79C20", Offset = "0x5E78620", VA = "0x185E79C20", Slot = "8")]
	public BCACLFKFPHI NGFHLNOOHDK(string BNMBEAJFNJE, string OONFPPOKDON, [Optional] MODHJKGINOE MFIBKFGAANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E796A0", Offset = "0x5E780A0", VA = "0x185E796A0", Slot = "12")]
	public BCACLFKFPHI LOCJFIILGEI(MODHJKGINOE MFIBKFGAANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5E791D0", Offset = "0x5E77BD0", VA = "0x185E791D0", Slot = "13")]
	public BCACLFKFPHI EKFCCPCCLIP(MODHJKGINOE MFIBKFGAANK, Dictionary<string, string> KJGFMHJKPNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E79490", Offset = "0x5E77E90", VA = "0x185E79490", Slot = "14")]
	public bool IIFIJFPHHHD(string KOGPIBPEDII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5E79B10", Offset = "0x5E78510", VA = "0x185E79B10", Slot = "15")]
	public GENBCAJKIAP MGFEGFDMLBF(string ICDNHPHINKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5E79850", Offset = "0x5E78250", VA = "0x185E79850", Slot = "16")]
	public JKIONIJGNMA LPKEBPHKNCO(string HDFPBKEPDBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5E79A00", Offset = "0x5E78400", VA = "0x185E79A00", Slot = "17")]
	public BCACLFKFPHI MCHNBGCAHOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8DBE60", Offset = "0x8DA860", VA = "0x1808DBE60")]
	[CompilerGenerated]
	private void JEJMLEMAOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xB99D10", Offset = "0xB98710", VA = "0x180B99D10")]
	[CompilerGenerated]
	private void FJGHDCAFIIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class HEFKHADGGJJ : IHEGMKEPADJ
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool FEJBNDKBHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string PLAHGHHFDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LLNKIAFJBCM EOJCFCFOAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action BNKHAODHJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A5A0", Offset = "0x5E78FA0", VA = "0x185E7A5A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A650", Offset = "0x5E79050", VA = "0x185E7A650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action FNEJIDEPFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A820", Offset = "0x5E79220", VA = "0x185E7A820", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A470", Offset = "0x5E78E70", VA = "0x185E7A470", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	[RecRoom.NoEngine.Common.Preserve]
	public HEFKHADGGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A790", Offset = "0x5E79190", VA = "0x185E7A790", Slot = "8")]
	public BCACLFKFPHI NGFHLNOOHDK(string BNMBEAJFNJE, string OONFPPOKDON, [Optional] MODHJKGINOE MFIBKFGAANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A510", Offset = "0x5E78F10", VA = "0x185E7A510", Slot = "12")]
	public BCACLFKFPHI LOCJFIILGEI(MODHJKGINOE MFIBKFGAANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A3E0", Offset = "0x5E78DE0", VA = "0x185E7A3E0", Slot = "13")]
	public BCACLFKFPHI EKFCCPCCLIP(MODHJKGINOE MFIBKFGAANK, Dictionary<string, string> KJGFMHJKPNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "14")]
	public bool IIFIJFPHHHD(string KOGPIBPEDII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A780", Offset = "0x5E79180", VA = "0x185E7A780", Slot = "15")]
	public GENBCAJKIAP MGFEGFDMLBF(string ICDNHPHINKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A640", Offset = "0x5E79040", VA = "0x185E7A640", Slot = "16")]
	public JKIONIJGNMA LPKEBPHKNCO(string HDFPBKEPDBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A6F0", Offset = "0x5E790F0", VA = "0x185E7A6F0", Slot = "17")]
	public BCACLFKFPHI MCHNBGCAHOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface MMGANAMHHMH
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AAFMDGIBHBL FIEIMGEDBHH(string ONKEONDDBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface KMHILAGGKPN
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public enum MBICCHAOBKA
	{
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	long GONAFLMIIMI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string ENPGCFCEJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string IJPJLLNOKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string MNDCADPFGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string BMBDJGBEIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool LHGHEGBHEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long FLILLIICBAN();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BPDPCLDPBIH(long HFHDELPKMEG, bool FDJPPJDALOG = true);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GECMEKKAOJE(string PEHINKLIDNC, string NPMJHAGINOK, string PKJGNPNBAMH);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FHLDDEABIBC(string PEHINKLIDNC);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IIIABBHEAFM(string PEHINKLIDNC, string IFCOGMHALOJ, string NPJJHMMPGEL);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BFADGFIANLC(string BBEJDLOJLLM, object IIIPIPELICG, object LPJKFIINKJH);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HPMCIPOFEKH(MBICCHAOBKA CFODMFMDMDM, int OGKNDCGCKLO, [Optional] PNECFPIPNNP JEPAAFJLNCN, [Optional] string PPDGNLPANMM, [Optional] string JKDHCOHJJFE);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MKNOPMJDNPE(PNECFPIPNNP JEPAAFJLNCN, long IPPFHBFMPGF, long NIGMCINLCEH, int IAIBPOLKCOM, string PPDGNLPANMM, int OGKNDCGCKLO);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PCBEMCDOFGL(PNECFPIPNNP JEPAAFJLNCN, bool OHANFNIJEEA, [Optional] string JKDHCOHJJFE);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NBGAOIPECAG(PNECFPIPNNP JEPAAFJLNCN, bool OHANFNIJEEA, [Optional] string JKDHCOHJJFE);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MGPKKIBKGKD(PNECFPIPNNP JEPAAFJLNCN, bool OHANFNIJEEA, [Optional] string JKDHCOHJJFE);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MODHJKGINOE
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool KPNKHPAHPLN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool KNCGCKEJCFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool JANKIPHHCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool? AKFHKHNLANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	int? EANDIGFADLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	int AAIOOFMEEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string JDNOFKODIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string MMMBFCLECMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string MACEJIBLPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	long OEFILAKFLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string CBHFNGMDNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string MLPNCCJEMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	string DBCJDHFAMFC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string NICLFODFMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string IPPAJKNMMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	double GMBFLLKKOHG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	int KAPDCAMJHMK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string IJIANMOEPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string ADJGGBNAABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	Guid? CLNGABGPFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
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
