using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E65530", Offset = "0x7E64130", VA = "0x187E65530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E64B60", Offset = "0x7E63760", VA = "0x187E64B60", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E66C60", Offset = "0x7E65860", VA = "0x187E66C60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
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
		public AmplitudeAnalyticsClient.Settings IMHHGOKFDJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BMOEBLBHCGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A350", VA = "0x180A5B750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, HKJBNPOGLFP
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum DOLHMODLBME
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class FLBKGDKEMAC
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class PNALKLPDAAK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int BCPDILOCNNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> DIKOIMLCBPF;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
				public PNALKLPDAAK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class DENJPLGBLHK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
				public DENJPLGBLHK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x7E5E850", Offset = "0x7E5D450", VA = "0x187E5E850")]
				internal bool MMIAKEPCHKG(PNALKLPDAAK item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string PJOAGHEILLN = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string OKJOHKDNPGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<PNALKLPDAAK> KDALHNONDKE;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? PMPHLGABHCA
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x7E5EA40", Offset = "0x7E5D640", VA = "0x187E5EA40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7E5FD40", Offset = "0x7E5E940", VA = "0x187E5FD40")]
			internal FLBKGDKEMAC(string JNGMDFCMMHO, string FJGFPBGCPAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7E5F3A0", Offset = "0x7E5DFA0", VA = "0x187E5F3A0")]
			public int FHDLFAFJLJF([Optional] int? PFBHAKIGPEO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7E5F920", Offset = "0x7E5E520", VA = "0x187E5F920")]
			public List<Dictionary<string, object>> KNEBIPDEKEE(int INAMBFCBECJ, int? PFBHAKIGPEO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7E5FCA0", Offset = "0x7E5E8A0", VA = "0x187E5FCA0")]
			public void PNGEDLJDPLL(AmplitudeAnalyticsIdentifyMessage KOJLNGLNBMH, bool HPFLGMHBBMI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7E5FB90", Offset = "0x7E5E790", VA = "0x187E5FB90")]
			public void PNGEDLJDPLL(Dictionary<string, object> KOJLNGLNBMH, bool HPFLGMHBBMI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7E5F680", Offset = "0x7E5E280", VA = "0x187E5F680")]
			public void INBFHFEJGGD(params Dictionary<string, object>[] INBOHODJJNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7E5EF40", Offset = "0x7E5DB40", VA = "0x187E5EF40")]
			public void EAFJOMPHIOG(List<Dictionary<string, object>> MECJAEKCKGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7E5F810", Offset = "0x7E5E410", VA = "0x187E5F810")]
			private void JLKDDOMNCAO(Dictionary<string, object> KOJLNGLNBMH, bool HPFLGMHBBMI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7E5F190", Offset = "0x7E5DD90", VA = "0x187E5F190")]
			public void EPCELKAHDNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7E5EAE0", Offset = "0x7E5D6E0", VA = "0x187E5EAE0")]
			private void BIKLOFAHMIF([Optional] string HFMDAFKADOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7E5F550", Offset = "0x7E5E150", VA = "0x187E5F550")]
			private static string FLNHDPCDFDG(string BKMPCFIAHIG, string DHCHBFGMFFD)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7E66850", Offset = "0x7E65450", VA = "0x187E66850")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct OGHKKIIFBDI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int FGAFKJLGOCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string KBPDKDFOONA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T JJDLFCINKGJ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class BOEOFEALKBF : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private LIPOFPKAEIK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public BOEOFEALKBF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7E5DC50", Offset = "0x7E5C850", VA = "0x187E5DC50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7E5E3E0", Offset = "0x7E5CFE0", VA = "0x187E5E3E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class APHAIOLDBMM : IEnumerator<object>, IEnumerator, IDisposable
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
			public PHNKDLMBHEO quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public APHAIOLDBMM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7E535D0", Offset = "0x7E521D0", VA = "0x187E535D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7E536E0", Offset = "0x7E522E0", VA = "0x187E536E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class KFICPBMHEAE : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public KFICPBMHEAE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7E64390", Offset = "0x7E62F90", VA = "0x187E64390", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7E64500", Offset = "0x7E63100", VA = "0x187E64500", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class PIDMAAPIEID : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private LIPOFPKAEIK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public PIDMAAPIEID(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7E66050", Offset = "0x7E64C50", VA = "0x187E66050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7E662B0", Offset = "0x7E64EB0", VA = "0x187E662B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class BEDJJCKJNDH : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private LIPOFPKAEIK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public BEDJJCKJNDH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7E5B920", Offset = "0x7E5A520", VA = "0x187E5B920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7E5BB80", Offset = "0x7E5A780", VA = "0x187E5BB80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class IPMAFGNDCHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public FLBKGDKEMAC cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public IPMAFGNDCHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7E62A00", Offset = "0x7E61600", VA = "0x187E62A00")]
			internal void GCODDOCDEJC(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7E625B0", Offset = "0x7E611B0", VA = "0x187E625B0")]
			internal void BHEBKHBBGMF(OGHKKIIFBDI<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class IFDALEHCPDG : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private LIPOFPKAEIK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public FLBKGDKEMAC cache;

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
			private IPMAFGNDCHF <>8__1;

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

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public IFDALEHCPDG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7E61BE0", Offset = "0x7E607E0", VA = "0x187E61BE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7E62400", Offset = "0x7E61000", VA = "0x187E62400", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class OKJIFIGOENP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public OKJIFIGOENP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x58817C0", Offset = "0x58803C0", VA = "0x1858817C0")]
			internal OGHKKIIFBDI<T> BMCOCAGGCGC(OIHHHKHKPIN postResponse)
			{
				return default(OGHKKIIFBDI<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private IFMJLEBMFFE CPKMIEIDGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<BLDAOFOKLNA> GFLAIMEHLIH;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string DOBOPKNIAAF = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string JCIHHPIJNMP = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string LNHDNGJFHKD = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int BMFADLOGEJO = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int AMFDMBJMLOM = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int NLOFLOIBHLH = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float PELKJHIMEOJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long ECBNPDPMMBD = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string KKPLFKMHJHA = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string NCKPEOOBDAL = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string GMPKEDHEPGK = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string NNDJODMLCKK = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool LIJLDHJAPCK;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool EBGJMOFEFDB;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int NIMNOMAMOFF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int PNMJACFIHAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private GPBHBKBONLL FDAJIBNCAGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private EBFMNEOIKIB GCBBOALNNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private DLJGFIJIADD IIIFHIOCMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool KDELBMDCLJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float EIFKAGOOFMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float JCHIFNHJLCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int IDBGFIFCCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int JGOCEIJGLFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? DBDHJJCHMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? HJBHDOMDLDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long OBMOKGJDNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string FAKFIDEAAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string MLCCPBCEHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long GGAIFKLMPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string LLMOHMMBMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string HMEGAKHIGFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> ABGJHJFPLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private DOLHMODLBME AOFFNPJBOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int LFIHHCMIMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int EIFCOGEEBDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float HGEFPFOHOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool JMHCCJEOHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool OELMADPCPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private FLBKGDKEMAC PGGLHBHKPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private FLBKGDKEMAC LLELAEDJHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private FLBKGDKEMAC GDPOLEAAMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string HAFHEJIIGIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> FFDCEPMBPKD;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo PIOMIOEIAJE;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string JGGJENLKHFI;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string CFBLLOGDAEI = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string EFPBNJBDCOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string AAEKCHMKOHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string ADNFAJJCCCC;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private IFMJLEBMFFE NBLFNOGNJGE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7E55640", Offset = "0x7E54240", VA = "0x187E55640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private BLDAOFOKLNA HIFKNFMDHNB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7E544C0", Offset = "0x7E530C0", VA = "0x187E544C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int HBHDKGKFHML
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7E53F40", Offset = "0x7E52B40", VA = "0x187E53F40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long CJGMDLCJEIH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7E59690", Offset = "0x7E58290", VA = "0x187E59690")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7E597A0", Offset = "0x7E583A0", VA = "0x187E597A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string LMFOGCPIJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7E59660", Offset = "0x7E58260", VA = "0x187E59660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LODEDLFDNDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1682DE0", Offset = "0x16819E0", VA = "0x181682DE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1680D70", Offset = "0x167F970", VA = "0x181680D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MILFPIDBEPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAE08B0", Offset = "0xADF4B0", VA = "0x180AE08B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xADC620", Offset = "0xADB220", VA = "0x180ADC620")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? JOCGPOBHBCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAD4BD0", Offset = "0xAD37D0", VA = "0x180AD4BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAD4BE0", Offset = "0xAD37E0", VA = "0x180AD4BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ANIEEOFEHOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAD4BC0", Offset = "0xAD37C0", VA = "0x180AD4BC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAFE580", Offset = "0xAFD180", VA = "0x180AFE580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool GADPNKLHABN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7E59570", Offset = "0x7E58170", VA = "0x187E59570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> EKMEFHBOBNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7E594B0", Offset = "0x7E580B0", VA = "0x187E594B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7E596E0", Offset = "0x7E582E0", VA = "0x187E596E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7E538E0", Offset = "0x7E524E0", VA = "0x187E538E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7E556D0", Offset = "0x7E542D0", VA = "0x187E556D0")]
		private void FKMIJNIDDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7E58AE0", Offset = "0x7E576E0", VA = "0x187E58AE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7E57740", Offset = "0x7E56340", VA = "0x187E57740", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7E58E10", Offset = "0x7E57A10", VA = "0x187E58E10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7E57850", Offset = "0x7E56450", VA = "0x187E57850")]
		public IPNMFPLCPOG PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7E56990", Offset = "0x7E55590", VA = "0x187E56990")]
		[IteratorStateMachine(typeof(BOEOFEALKBF))]
		public IEnumerator<LIPOFPKAEIK> InitializeForLocalAccount(AmplitudeAnalyticsEvent HNHIIEGBLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7E581B0", Offset = "0x7E56DB0", VA = "0x187E581B0")]
		public void SendAppEnterEvent(bool KLAMPGOEIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7E58D90", Offset = "0x7E57990", VA = "0x187E58D90")]
		public void UpdateLastKnownInteractionCategory(string HABGHOKMAGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7E58CE0", Offset = "0x7E578E0", VA = "0x187E58CE0")]
		public void UpdateLastAliveTime(float EOLAIOLLEBH = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7E54510", Offset = "0x7E53110", VA = "0x187E54510")]
		private IPNMFPLCPOG DIJIHMCOFOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E55A90", Offset = "0x7E54690", VA = "0x187E55A90")]
		private IPNMFPLCPOG FLFDAJCDBOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7E584C0", Offset = "0x7E570C0", VA = "0x187E584C0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7E56A20", Offset = "0x7E55620", VA = "0x187E56A20")]
		[IteratorStateMachine(typeof(APHAIOLDBMM))]
		private IEnumerator JMPLAKEGNOK(PHNKDLMBHEO JJNGMBGHCFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7E590A0", Offset = "0x7E57CA0", VA = "0x187E590A0")]
		[IteratorStateMachine(typeof(KFICPBMHEAE))]
		public IEnumerator WaitForFlush(float CPMCAMKMDEF = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7E58BC0", Offset = "0x7E577C0", VA = "0x187E58BC0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7E58B00", Offset = "0x7E57700", VA = "0x187E58B00")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime HCMFNJGJPMC)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7E56490", Offset = "0x7E55090", VA = "0x187E56490")]
		public static POJKLPANFED Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7E53730", Offset = "0x7E52330", VA = "0x187E53730")]
		public static MAGEIKIAKKE AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string CGLHBDAMNGP, string IHLHPKIEFLA, IGCAAJNMJHN MDPNFMHCDLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7E55330", Offset = "0x7E53F30", VA = "0x187E55330")]
		public static MAGEIKIAKKE Event([JetBrains.Annotations.NotNull] string CGLHBDAMNGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7E579F0", Offset = "0x7E565F0", VA = "0x187E579F0")]
		public static MAGEIKIAKKE PreviousSessionEvent([JetBrains.Annotations.NotNull] string CGLHBDAMNGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7E56630", Offset = "0x7E55230", VA = "0x187E56630")]
		public static MAGEIKIAKKE InitializeEvent(string IHLHPKIEFLA, int DHNHOPALGDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7E586C0", Offset = "0x7E572C0", VA = "0x187E586C0")]
		public static MAGEIKIAKKE StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7E54150", Offset = "0x7E52D50", VA = "0x187E54150")]
		public static MAGEIKIAKKE CreateOutOfSessionEvent(string CGLHBDAMNGP, bool BDJKFGFNHHB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7E56FF0", Offset = "0x7E55BF0", VA = "0x187E56FF0")]
		public static IPNMFPLCPOG LogOutOfSessionEvent(MAGEIKIAKKE DBKBIMGOFIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7E56D70", Offset = "0x7E55970", VA = "0x187E56D70")]
		public void LogEventAsync(AmplitudeAnalyticsEvent GHCGILNNIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7E571C0", Offset = "0x7E55DC0", VA = "0x187E571C0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent GHCGILNNIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E57300", Offset = "0x7E55F00", VA = "0x187E57300")]
		public void LogSerializedEventAsync(Dictionary<string, object> HFANAONPJDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E56EB0", Offset = "0x7E55AB0", VA = "0x187E56EB0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HILPMKEPEEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7E573E0", Offset = "0x7E55FE0", VA = "0x187E573E0")]
		private void MABOBKLMEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7E56AB0", Offset = "0x7E556B0", VA = "0x187E56AB0")]
		private void LDLLHJPPDPJ(Dictionary<string, object> BMOMBCIONJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7E574E0", Offset = "0x7E560E0", VA = "0x187E574E0")]
		private void MOCCFNIJEOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E55C00", Offset = "0x7E54800", VA = "0x187E55C00")]
		private void FOBBBJEIPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E55DD0", Offset = "0x7E549D0", VA = "0x187E55DD0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7E55E60", Offset = "0x7E54A60", VA = "0x187E55E60")]
		[IteratorStateMachine(typeof(PIDMAAPIEID))]
		private IEnumerator<LIPOFPKAEIK> GBMFADIODEP(float CPMCAMKMDEF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7E54430", Offset = "0x7E53030", VA = "0x187E54430")]
		[IteratorStateMachine(typeof(BEDJJCKJNDH))]
		private IEnumerator<LIPOFPKAEIK> DBGLGJEMHID(float CPMCAMKMDEF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E563B0", Offset = "0x7E54FB0", VA = "0x187E563B0")]
		[IteratorStateMachine(typeof(IFDALEHCPDG))]
		private IEnumerator<LIPOFPKAEIK> HPOGOIBMJBD(FLBKGDKEMAC HGDHKCAADKN, int? PFBHAKIGPEO, string CPHDLJFOPDA, float CPMCAMKMDEF, Action<int> PKPMOEIJLOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E55EF0", Offset = "0x7E54AF0", VA = "0x187E55EF0")]
		private static void GDKOINGNBLF(bool MDJNEEGMGOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E56000", Offset = "0x7E54C00", VA = "0x187E56000")]
		private AIDGEFHMIOM<OGHKKIIFBDI<Dictionary<string, object>>> HIIEMNMBCCG(string CPHDLJFOPDA, string KKJPNGKGGLN, Dictionary<string, object> JJDLFCINKGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7E560D0", Offset = "0x7E54CD0", VA = "0x187E560D0")]
		private AIDGEFHMIOM<OGHKKIIFBDI<List<Dictionary<string, object>>>> HIIEMNMBCCG(string CPHDLJFOPDA, string KKJPNGKGGLN, List<Dictionary<string, object>> JJDLFCINKGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x31CB890", Offset = "0x31CA490", VA = "0x1831CB890")]
		private AIDGEFHMIOM<OGHKKIIFBDI<T>> CKKBPKBCKLL<T>(string NGOKBPLOMJC, string CPHDLJFOPDA, string KKJPNGKGGLN, T JJDLFCINKGJ, Dictionary<string, object> BJHNELOIEIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7E57800", Offset = "0x7E56400", VA = "0x187E57800")]
		private bool PIMJDMBLKOB(float BLMNNDJKEGK, float CPMCAMKMDEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7E545D0", Offset = "0x7E531D0", VA = "0x187E545D0")]
		private Dictionary<string, object> EBPMGGKOBCH(string CPHDLJFOPDA, Dictionary<string, object> JJDLFCINKGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7E59190", Offset = "0x7E57D90", VA = "0x187E59190")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA89010", Offset = "0xA87C10", VA = "0x180A89010", Slot = "6")]
		private bool JHHMLKIFGCE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7E575D0", Offset = "0x7E561D0", VA = "0x187E575D0")]
		[CompilerGenerated]
		private long MPMJCEJDEEJ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7E54140", Offset = "0x7E52D40", VA = "0x187E54140")]
		[CompilerGenerated]
		private void CLMNIABPGBF(int AOCOJDCPGCN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
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
		private readonly string assignedUserCrm;

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

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7E5A4A0", Offset = "0x7E590A0", VA = "0x187E5A4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7E5A580", Offset = "0x7E59180", VA = "0x187E5A580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7E5A4E0", Offset = "0x7E590E0", VA = "0x187E5A4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7E5A5E0", Offset = "0x7E591E0", VA = "0x187E5A5E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7E5A460", Offset = "0x7E59060", VA = "0x187E5A460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7E5A520", Offset = "0x7E59120", VA = "0x187E5A520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA5B440", Offset = "0xA5A040", VA = "0x180A5B440")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7E59CD0", Offset = "0x7E588D0", VA = "0x187E59CD0")]
		public static MAGEIKIAKKE FOGKIHKKOLG(string LAHAJPPAFND, [JetBrains.Annotations.NotNull] string HIPODMFACOE, long APLKCLBHHOJ, long IALELGIHAPN, string IHLHPKIEFLA, string MDPNFMHCDLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7E59F50", Offset = "0x7E58B50", VA = "0x187E59F50")]
		public static MAGEIKIAKKE JLPNFEEPDFG(string LAHAJPPAFND, [JetBrains.Annotations.NotNull] string HIPODMFACOE, long APLKCLBHHOJ, long IALELGIHAPN, string IHLHPKIEFLA, long GIKKBJMHBFA, string CGCIKPGPDMF, string EPACEKMBDLJ, string ADJIHKDBGHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A2C0", Offset = "0x7E58EC0", VA = "0x187E5A2C0")]
		private AmplitudeAnalyticsEvent(string LAHAJPPAFND, [JetBrains.Annotations.NotNull] string HIPODMFACOE, long APLKCLBHHOJ, long IALELGIHAPN, string IHLHPKIEFLA, string MDPNFMHCDLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xF7F6B0", Offset = "0xF7E2B0", VA = "0x180F7F6B0")]
		public void BFCOFMGNBFP(long JNFFGLEMMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A0B0", Offset = "0x7E58CB0", VA = "0x187E5A0B0", Slot = "5")]
		public override void MFADPAMFHCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7E59DD0", Offset = "0x7E589D0", VA = "0x187E59DD0", Slot = "6")]
		public override void GJJGPBCNFEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7E59800", Offset = "0x7E58400", VA = "0x187E59800", Slot = "4")]
		protected override Dictionary<string, object> FOCOKAECHLN(Dictionary<string, object> IGHAABPAELH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A1B0", Offset = "0x7E58DB0", VA = "0x187E5A1B0")]
		private void OPLFIJFPBDH(string DHCHBFGMFFD, string BKMPCFIAHIG, bool MFGNOHELBHM = false)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
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

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7E5E8C0", Offset = "0x7E5D4C0", VA = "0x187E5E8C0")]
			public void EGFIAGJAAPC(Dictionary<string, object> GLEFDHCKBPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
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

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7E664D0", Offset = "0x7E650D0", VA = "0x187E664D0")]
			public void EGFIAGJAAPC(Dictionary<string, object> GHECDAFAJDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x14ED7B0", Offset = "0x14EC3B0", VA = "0x1814ED7B0")]
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

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A9F0", Offset = "0x7E595F0", VA = "0x187E5A9F0")]
		public static POJKLPANFED FOGKIHKKOLG(string LAHAJPPAFND, string IHLHPKIEFLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E5ACF0", Offset = "0x7E598F0", VA = "0x187E5ACF0")]
		protected AmplitudeAnalyticsIdentifyMessage(string LAHAJPPAFND, string IHLHPKIEFLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E5AB30", Offset = "0x7E59730", VA = "0x187E5AB30")]
		public Dictionary<string, object> JEFBACPLFNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A6B0", Offset = "0x7E592B0", VA = "0x187E5A6B0", Slot = "4")]
		protected virtual Dictionary<string, object> FOCOKAECHLN(Dictionary<string, object> IGHAABPAELH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E5AC50", Offset = "0x7E59850", VA = "0x187E5AC50")]
		protected void MJGOADBKHGP(string DHCHBFGMFFD, Dictionary<string, object> HGMDEBAHCBL, Dictionary<string, object> LHDOLNNOIAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A640", Offset = "0x7E59240", VA = "0x187E5A640")]
		protected void DGDEOPNLJBA(string DHCHBFGMFFD, string BKMPCFIAHIG, Dictionary<string, object> OGJJGGEBLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7E5ABC0", Offset = "0x7E597C0", VA = "0x187E5ABC0", Slot = "5")]
		public virtual void MFADPAMFHCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E5AAB0", Offset = "0x7E596B0", VA = "0x187E5AAB0", Slot = "6")]
		public virtual void GJJGPBCNFEB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class POJKLPANFED : JOGHMMPCBNM<AmplitudeAnalyticsIdentifyMessage, POJKLPANFED>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override POJKLPANFED PGLFOIJBELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage IJKHPNJMDDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E66480", Offset = "0x7E65080", VA = "0x187E66480")]
	public POJKLPANFED(AmplitudeAnalyticsIdentifyMessage HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7E663E0", Offset = "0x7E64FE0", VA = "0x187E663E0", Slot = "4")]
	public override void GJJGPBCNFEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MAGEIKIAKKE : JOGHMMPCBNM<AmplitudeAnalyticsEvent, MAGEIKIAKKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool IGMMPBKODJP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override MAGEIKIAKKE PGLFOIJBELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long LOGGEOEGNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E64E50", Offset = "0x7E63A50", VA = "0x187E64E50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E64340", Offset = "0x7E62F40", VA = "0x187E64340")]
	public MAGEIKIAKKE(AmplitudeAnalyticsEvent HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "5")]
	public override AmplitudeAnalyticsEvent IJKHPNJMDDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7E64CE0", Offset = "0x7E638E0", VA = "0x187E64CE0", Slot = "4")]
	public override void GJJGPBCNFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3D43790", Offset = "0x3D42390", VA = "0x183D43790")]
	public MAGEIKIAKKE DIKMIIGFFIG<T>(string ABMJBIODBLM, T[] BKMPCFIAHIG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D43790", Offset = "0x3D42390", VA = "0x183D43790")]
	public MAGEIKIAKKE DIKMIIGFFIG(string ABMJBIODBLM, string[] BKMPCFIAHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3D434E0", Offset = "0x3D420E0", VA = "0x183D434E0")]
	public MAGEIKIAKKE DIKMIIGFFIG<T>(string ABMJBIODBLM, T BKMPCFIAHIG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E64C60", Offset = "0x7E63860", VA = "0x187E64C60")]
	public MAGEIKIAKKE DIKMIIGFFIG(string ABMJBIODBLM, long BKMPCFIAHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E64BF0", Offset = "0x7E637F0", VA = "0x187E64BF0")]
	public MAGEIKIAKKE DIKMIIGFFIG(string ABMJBIODBLM, string BKMPCFIAHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E64E20", Offset = "0x7E63A20", VA = "0x187E64E20")]
	public MAGEIKIAKKE LMIPOPDFKPI(string ABMJBIODBLM, object? BKMPCFIAHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E64D80", Offset = "0x7E63980", VA = "0x187E64D80")]
	public MAGEIKIAKKE HONGBKJJHHK(string ABMJBIODBLM, string BKMPCFIAHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E64E70", Offset = "0x7E63A70", VA = "0x187E64E70")]
	private MAGEIKIAKKE MKCNLLFHFJO(string ABMJBIODBLM, object BKMPCFIAHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JPKLMAHCHEC : MAGEIKIAKKE
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E64340", Offset = "0x7E62F40", VA = "0x187E64340")]
	public JPKLMAHCHEC(AmplitudeAnalyticsEvent HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E64190", Offset = "0x7E62D90", VA = "0x187E64190", Slot = "4")]
	public override void GJJGPBCNFEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class JOGHMMPCBNM<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : JOGHMMPCBNM<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M HLMEMBFCHLD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR PGLFOIJBELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public JOGHMMPCBNM(M HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x52F1510", Offset = "0x52F0110", VA = "0x1852F1510")]
	public BLDR FKPBCEILFJN(AmplitudeAnalyticsIdentifyMessage.DeviceInfo FMOCKHBHGNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x52F1560", Offset = "0x52F0160", VA = "0x1852F1560")]
	public BLDR KFFIBKOCCBE(AmplitudeAnalyticsIdentifyMessage.RevenueData EEJJENMEFEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x52F15B0", Offset = "0x52F01B0", VA = "0x1852F15B0")]
	public BLDR NFPKDOBJMMC(string ABMJBIODBLM, string BKMPCFIAHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x43A93D0", Offset = "0x43A7FD0", VA = "0x1843A93D0")]
	public BLDR NFPKDOBJMMC<T>(string ABMJBIODBLM, T BKMPCFIAHIG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void GJJGPBCNFEB();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x52F14E0", Offset = "0x52F00E0", VA = "0x1852F14E0")]
	internal static string FEMEPEEGDFM(string BKMPCFIAHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x52F1620", Offset = "0x52F0220", VA = "0x1852F1620")]
	private BLDR PFKHMLMAKCE(string ABMJBIODBLM, object BKMPCFIAHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M IJKHPNJMDDB();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class HLECCAHCOEK : GPBHBKBONLL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct PIBPJLLLNOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<OIHHHKHKPIN> <>t__builder;

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
		public HLECCAHCOEK <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7E655B0", Offset = "0x7E641B0", VA = "0x187E655B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7E65FE0", Offset = "0x7E64BE0", VA = "0x187E65FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient HDDLDODBBOB;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E61AF0", Offset = "0x7E606F0", VA = "0x187E61AF0")]
	[HHMPGEJNNFC.JKDCLEHGFFF]
	internal static void MLGIOACGFPI(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7E61B60", Offset = "0x7E60760", VA = "0x187E61B60")]
	[RecRoom.NoEngine.Common.Preserve]
	public HLECCAHCOEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7E61980", Offset = "0x7E60580", VA = "0x187E61980", Slot = "4")]
	[AsyncStateMachine(typeof(PIBPJLLLNOO))]
	public Task<OIHHHKHKPIN> FLCOAAOOMJF(string NGOKBPLOMJC, string DCHKBKFNBPG, string BNJFIDBEALE, string BIELGBKCFAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class IMILKLMCKLI : GPBHBKBONLL
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class POHKNLEBHDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<OIHHHKHKPIN> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public POHKNLEBHDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7E66300", Offset = "0x7E64F00", VA = "0x187E66300")]
		internal void GKNLBHEBIFM(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct NFFCBKKHOCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<OIHHHKHKPIN> <>t__builder;

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
		private TaskAwaiter<OIHHHKHKPIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7E64F70", Offset = "0x7E63B70", VA = "0x187E64F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7E654C0", Offset = "0x7E640C0", VA = "0x187E654C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	[HHMPGEJNNFC.JKDCLEHGFFF]
	internal static void EEFBKKFFAKJ(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	[RecRoom.NoEngine.Common.Preserve]
	public IMILKLMCKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E62450", Offset = "0x7E61050", VA = "0x187E62450", Slot = "4")]
	[AsyncStateMachine(typeof(NFFCBKKHOCG))]
	public Task<OIHHHKHKPIN> FLCOAAOOMJF(string NGOKBPLOMJC, string DCHKBKFNBPG, string BNJFIDBEALE, string BIELGBKCFAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BBPIFAFENMC
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> DGGHKDNCMOO;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7E5ADB0", Offset = "0x7E599B0", VA = "0x187E5ADB0")]
	internal static bool EBGBONOEGHE(string DHCHBFGMFFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface GPBHBKBONLL
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OIHHHKHKPIN> FLCOAAOOMJF(string NGOKBPLOMJC, string DCHKBKFNBPG, string BNJFIDBEALE, string BIELGBKCFAM);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct OIHHHKHKPIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int EMFEKPJDLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string APBNFCCNCLM;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1876FA0", Offset = "0x1875BA0", VA = "0x181876FA0")]
	public OIHHHKHKPIN(int FGAFKJLGOCG, string KBPDKDFOONA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum EJFKBDEJKKM
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
	DebugCommand,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	WidgetWatch
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class AIFMGGDKFKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private long INJFEABGMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private MAGEIKIAKKE CGCADOBGGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool LHKKIPCDGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private float PAJDKCOCDIA;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E53440", Offset = "0x7E52040", VA = "0x187E53440")]
	public AIFMGGDKFKJ(string OBFCCOBFGHI, float PAJDKCOCDIA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x31928F0", Offset = "0x31914F0", VA = "0x1831928F0")]
	public void DIKMIIGFFIG<T>(string ABMJBIODBLM, T BKMPCFIAHIG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E532B0", Offset = "0x7E51EB0", VA = "0x187E532B0")]
	public void DIKMIIGFFIG(string ABMJBIODBLM, string BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E530B0", Offset = "0x7E51CB0", VA = "0x187E530B0")]
	public void APNINAJLKOL(string JPDFINHLCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E53380", Offset = "0x7E51F80", VA = "0x187E53380")]
	public void LNLJBPILBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7E531A0", Offset = "0x7E51DA0", VA = "0x187E531A0")]
	private void DIGBFFNDJOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E53330", Offset = "0x7E51F30", VA = "0x187E53330")]
	private bool GCCEOFNFEHO()
	{
		return default(bool);
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum FGJGLHFAANH
		{
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			String,
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			Bool
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private FGJGLHFAANH parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public FGJGLHFAANH Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAB6800", Offset = "0xAB5400", VA = "0x180AB6800")]
			get
			{
				return default(FGJGLHFAANH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA8A4F0", Offset = "0xA890F0", VA = "0x180A8A4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7E66640", Offset = "0x7E65240", VA = "0x187E66640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FEOJHNLHGBI<T> : JHMHEEPEHBJ<T>, PDOJDILACFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly PEHHKHACOAC MBMIIEAOJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string JJKFIBNFCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly string OOBHLDACFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private T GFFLPNHOMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly T PLEDLJICBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool ILBKMKNNCAC;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string JHPIKMOHNII
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D6EF10", Offset = "0x4D6DB10", VA = "0x184D6EF10")]
	public FEOJHNLHGBI(PEHHKHACOAC MBMIIEAOJOA, string JJKFIBNFCFA, string OOBHLDACFKO, T PLEDLJICBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4D6EB70", Offset = "0x4D6D770", VA = "0x184D6EB70", Slot = "4")]
	public T CLFPKKLNFPN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4D6EE70", Offset = "0x4D6DA70", VA = "0x184D6EE70", Slot = "6")]
	public void HAGLLFMPLGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
public class GMODMEANKOD : EJKAJOGGMHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct KGNFENDFOPL : IEquatable<KGNFENDFOPL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly string EDDALIODIEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly string LJJKIPPCDGI;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xBCEBD0", Offset = "0xBCD7D0", VA = "0x180BCEBD0")]
		public KGNFENDFOPL(string EBKJJLBGBOL, string CBEDIDCKHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1358180", Offset = "0x1356D80", VA = "0x181358180", Slot = "4")]
		public bool Equals(KGNFENDFOPL IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7E64550", Offset = "0x7E63150", VA = "0x187E64550", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7E64610", Offset = "0x7E63210", VA = "0x187E64610", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private PEHHKHACOAC MBMIIEAOJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Dictionary<KGNFENDFOPL, PDOJDILACFM> OCINPOOMNIJ;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7E60BE0", Offset = "0x7E5F7E0", VA = "0x187E60BE0")]
	[HHMPGEJNNFC.JKDCLEHGFFF.OKMFHHNNKLI]
	internal static void KGIELNFJPKP(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E60E00", Offset = "0x7E5FA00", VA = "0x187E60E00")]
	[RecRoom.NoEngine.Common.Preserve]
	public GMODMEANKOD([System.Diagnostics.CodeAnalysis.NotNull][HAKCNCGPHPD(null)] PEHHKHACOAC MBMIIEAOJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E60AD0", Offset = "0x7E5F6D0", VA = "0x187E60AD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7E60BD0", Offset = "0x7E5F7D0", VA = "0x187E60BD0")]
	private void KDEPFHEAFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7E60C50", Offset = "0x7E5F850", VA = "0x187E60C50")]
	private void OEGLAPLMDPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3C4BF20", Offset = "0x3C4AB20", VA = "0x183C4BF20", Slot = "4")]
	public JHMHEEPEHBJ<T> CMDHMMPJDBO<T>(string JJKFIBNFCFA, string GIIMCIPKBJC, T PLEDLJICBFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class LEHNAFIFNMF : ANNJBAIJDJN, IJPLFCONMAM
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void AHLNKHNKNBM(BKAMKLHBKNN FMIDNBLDNCI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly KDFGMFOLNEH KNMDJBFLMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly AHLNKHNKNBM CMKMKEPJKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly string KNKCLDBCCEJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string FEGHCLOCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1272980", Offset = "0x1271580", VA = "0x181272980", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string PJLANHDCFPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1DBF2B0", Offset = "0x1DBDEB0", VA = "0x181DBF2B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool DBLIFBKEMAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7E64B20", Offset = "0x7E63720", VA = "0x187E64B20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool PDHLHEBECOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E64B40", Offset = "0x7E63740", VA = "0x187E64B40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyList<string> PLEHHOKIEAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1DBF290", Offset = "0x1DBDE90", VA = "0x181DBF290", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x13CC3A0", Offset = "0x13CAFA0", VA = "0x1813CC3A0")]
	public LEHNAFIFNMF(KDFGMFOLNEH IAPLIGCGIFJ, string FFNDHFPLOJO, [Optional] AHLNKHNKNBM OECJHGAGFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3D21BE0", Offset = "0x3D207E0", VA = "0x183D21BE0", Slot = "9")]
	public T LGFPFICEOKK<T>(string DHCHBFGMFFD, T PLEDLJICBFM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class BFEMMEMCNFP : PEHHKHACOAC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct GNKIBLMHKPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public EBFMNEOIKIB userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public BFEMMEMCNFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7E60FB0", Offset = "0x7E5FBB0", VA = "0x187E60FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7E61920", Offset = "0x7E60520", VA = "0x187E61920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct AHNLHCKBKEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7E52E70", Offset = "0x7E51A70", VA = "0x187E52E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7E53050", Offset = "0x7E51C50", VA = "0x187E53050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct KMMPCFCBKFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public EBFMNEOIKIB userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public BFEMMEMCNFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7E64680", Offset = "0x7E63280", VA = "0x187E64680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7E64AC0", Offset = "0x7E636C0", VA = "0x187E64AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct BPFBDMPFNAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public BFEMMEMCNFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public EBFMNEOIKIB userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7E5E430", Offset = "0x7E5D030", VA = "0x187E5E430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7E5E7F0", Offset = "0x7E5D3F0", VA = "0x187E5E7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly IReadOnlyDictionary<string, AFJKGIJBAIK> DFNEGKIIBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool DMKJPOHBDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private bool GMFEDAMOKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private TaskCompletionSource<bool> GEKKDKKLJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private TaskCompletionSource<bool> LBAEKADCJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly SemaphoreSlim PIOEEMBMDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private GEICNPPACOL AOJKAFDFBCI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task JFAGBJGBBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C290", Offset = "0x7E5AE90", VA = "0x187E5C290", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task AMAJFOLFFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7E5BD20", Offset = "0x7E5A920", VA = "0x187E5BD20", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HBFEHNJBHGB
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xB27800", Offset = "0xB26400", VA = "0x180B27800", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool JBDMHKHHAKL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xB27820", Offset = "0xB26420", VA = "0x180B27820", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string MILFPIDBEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D5F0", Offset = "0x7E5C1F0", VA = "0x187E5D5F0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public HMPJHOEIIKE KOEFPJAJLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5BF50", Offset = "0x7E5AB50", VA = "0x187E5BF50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DIKCMPBJCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D1A0", Offset = "0x7E5BDA0", VA = "0x187E5D1A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D900", Offset = "0x7E5C500", VA = "0x187E5D900", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IKDBFDINFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D240", Offset = "0x7E5BE40", VA = "0x187E5D240", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C580", Offset = "0x7E5B180", VA = "0x187E5C580", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action FJPIDGIFLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D6B0", Offset = "0x7E5C2B0", VA = "0x187E5D6B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D750", Offset = "0x7E5C350", VA = "0x187E5D750", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<BKAMKLHBKNN> NOLGBIOCBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D600", Offset = "0x7E5C200", VA = "0x187E5D600", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7E5BE80", Offset = "0x7E5AA80", VA = "0x187E5BE80", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BF30", Offset = "0x7E5AB30", VA = "0x187E5BF30", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BD60", Offset = "0x7E5A960", VA = "0x187E5BD60", Slot = "12")]
	[AsyncStateMachine(typeof(GNKIBLMHKPF))]
	public Task BFHPBJMBKJO(string FJGFPBGCPAB, [Optional] EBFMNEOIKIB BBAEJJFNOAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BBD0", Offset = "0x7E5A7D0", VA = "0x187E5BBD0", Slot = "24")]
	[AsyncStateMachine(typeof(AHNLHCKBKEG))]
	public Task ADJALNBAGNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C480", Offset = "0x7E5B080", VA = "0x187E5C480", Slot = "19")]
	[AsyncStateMachine(typeof(KMMPCFCBKFA))]
	public Task KCPHJNKPFIC(EBFMNEOIKIB BBAEJJFNOAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BC80", Offset = "0x7E5A880", VA = "0x187E5BC80")]
	private void AECNHDJPKPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D7F0", Offset = "0x7E5C3F0", VA = "0x187E5D7F0", Slot = "20")]
	[AsyncStateMachine(typeof(BPFBDMPFNAF))]
	public Task PMKHDLKDIAC(EBFMNEOIKIB BBAEJJFNOAN, Dictionary<string, string> FFCMDIEJKPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C7D0", Offset = "0x7E5B3D0", VA = "0x187E5C7D0", Slot = "21")]
	public bool LALMIEOKKEM(string KEBAOHDEHHF, bool KONGJHALCDA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C090", Offset = "0x7E5AC90", VA = "0x187E5C090", Slot = "22")]
	public ANNJBAIJDJN HFBCANJMMAN(string FFNDHFPLOJO, bool KONGJHALCDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D2E0", Offset = "0x7E5BEE0", VA = "0x187E5D2E0")]
	private KDFGMFOLNEH NJIGOLMELKG(string FFNDHFPLOJO, bool KONGJHALCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C620", Offset = "0x7E5B220", VA = "0x187E5C620", Slot = "23")]
	public MNDDBNEICIO KOJDMOKANEL(string EBKJJLBGBOL, bool KONGJHALCDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D4F0", Offset = "0x7E5C0F0", VA = "0x187E5D4F0")]
	private BECKMACIBDE NJKJNJGMEOH(string EBKJJLBGBOL, bool KONGJHALCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C8C0", Offset = "0x7E5B4C0", VA = "0x187E5C8C0")]
	private NNCGGBPGGFM LOKGBAPNKME(EBFMNEOIKIB BBAEJJFNOAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C2D0", Offset = "0x7E5AED0", VA = "0x187E5C2D0")]
	private PDNNDMLALAK JIHBHGBOEOM(string FJGFPBGCPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BF80", Offset = "0x7E5AB80", VA = "0x187E5BF80")]
	private void HBAEPGADGJP(string FFNDHFPLOJO, KDFGMFOLNEH IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7E5DB50", Offset = "0x7E5C750", VA = "0x187E5DB50")]
	public BFEMMEMCNFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C250", Offset = "0x7E5AE50", VA = "0x187E5C250")]
	[CompilerGenerated]
	private void KHBMOKKMKBP(BKAMKLHBKNN KFNDMAAELJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C250", Offset = "0x7E5AE50", VA = "0x187E5C250")]
	[CompilerGenerated]
	private void IHODBIAENIL(BKAMKLHBKNN KFNDMAAELJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class JEKKOLKPOOD : PEHHKHACOAC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct FNOFAGNIIKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public JEKKOLKPOOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public EBFMNEOIKIB userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7E5FEB0", Offset = "0x7E5EAB0", VA = "0x187E5FEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7E60830", Offset = "0x7E5F430", VA = "0x187E60830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct FPGGGDHOBKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7E60890", Offset = "0x7E5F490", VA = "0x187E60890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xAB3320", Offset = "0xAB1F20", VA = "0x180AB3320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private BFEMMEMCNFP DGFJEBBHJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private TaskCompletionSource<bool> GEKKDKKLJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private TaskCompletionSource<bool> LBAEKADCJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Task GOOIOCPLCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Task DFKEEHGEANG;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private PEHHKHACOAC GJMJLNIDJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7E63970", Offset = "0x7E62570", VA = "0x187E63970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool JBDMHKHHAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7E632E0", Offset = "0x7E61EE0", VA = "0x187E632E0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HBFEHNJBHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7E63B40", Offset = "0x7E62740", VA = "0x187E63B40", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task JFAGBJGBBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7E634D0", Offset = "0x7E620D0", VA = "0x187E634D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task AMAJFOLFFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7E62FB0", Offset = "0x7E61BB0", VA = "0x187E62FB0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string MILFPIDBEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7E63B20", Offset = "0x7E62720", VA = "0x187E63B20", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public HMPJHOEIIKE KOEFPJAJLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7E63360", Offset = "0x7E61F60", VA = "0x187E63360", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action IKDBFDINFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7E63A80", Offset = "0x7E62680", VA = "0x187E63A80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7E636F0", Offset = "0x7E622F0", VA = "0x187E636F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action DIKCMPBJCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7E639E0", Offset = "0x7E625E0", VA = "0x187E639E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7E63E60", Offset = "0x7E62A60", VA = "0x187E63E60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action FJPIDGIFLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7E63C00", Offset = "0x7E62800", VA = "0x187E63C00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7E63CA0", Offset = "0x7E628A0", VA = "0x187E63CA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<BKAMKLHBKNN> NOLGBIOCBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7E63B50", Offset = "0x7E62750", VA = "0x187E63B50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7E63160", Offset = "0x7E61D60", VA = "0x187E63160", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7E63F00", Offset = "0x7E62B00", VA = "0x187E63F00")]
	[UnityEngine.Scripting.Preserve]
	public JEKKOLKPOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7E63680", Offset = "0x7E62280", VA = "0x187E63680")]
	[HHMPGEJNNFC.JKDCLEHGFFF.OKMFHHNNKLI]
	internal static void KGIELNFJPKP(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7E63460", Offset = "0x7E62060", VA = "0x187E63460")]
	internal static void IODIKPIIEIJ(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7E632F0", Offset = "0x7E61EF0", VA = "0x187E632F0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7E63050", Offset = "0x7E61C50", VA = "0x187E63050", Slot = "12")]
	[AsyncStateMachine(typeof(FNOFAGNIIKN))]
	public Task BFHPBJMBKJO(string FJGFPBGCPAB, [Optional] EBFMNEOIKIB BBAEJJFNOAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7E63570", Offset = "0x7E62170", VA = "0x187E63570", Slot = "19")]
	public Task KCPHJNKPFIC(EBFMNEOIKIB BBAEJJFNOAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7E63D40", Offset = "0x7E62940", VA = "0x187E63D40", Slot = "20")]
	public Task PMKHDLKDIAC(EBFMNEOIKIB BBAEJJFNOAN, Dictionary<string, string> FFCMDIEJKPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7E63850", Offset = "0x7E62450", VA = "0x187E63850", Slot = "21")]
	public bool LALMIEOKKEM(string KEBAOHDEHHF, bool KONGJHALCDA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7E633A0", Offset = "0x7E61FA0", VA = "0x187E633A0", Slot = "22")]
	public ANNJBAIJDJN HFBCANJMMAN(string FFNDHFPLOJO, bool KONGJHALCDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7E63790", Offset = "0x7E62390", VA = "0x187E63790", Slot = "23")]
	public MNDDBNEICIO KOJDMOKANEL(string EBKJJLBGBOL, bool KONGJHALCDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7E62EA0", Offset = "0x7E61AA0", VA = "0x187E62EA0", Slot = "24")]
	public Task ADJALNBAGNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7E62D20", Offset = "0x7E61920", VA = "0x187E62D20")]
	private static void AAEHIGGAKBB(TaskCompletionSource<bool> FFNPFGAHDNF, Task CLMODOLLLON, Task DIMKAMGEPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7E63210", Offset = "0x7E61E10", VA = "0x187E63210")]
	[AsyncStateMachine(typeof(FPGGGDHOBKL))]
	private static void BOMPJGBDIHP(Task MHGNKNMAFFC, TaskCompletionSource<bool> FFNPFGAHDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xF7D950", Offset = "0xF7C550", VA = "0x180F7D950")]
	[CompilerGenerated]
	private void NMFDPKMOEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1000A30", Offset = "0xFFF630", VA = "0x181000A30")]
	[CompilerGenerated]
	private void IHMGEOIHEJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xDEC340", Offset = "0xDEAF40", VA = "0x180DEC340")]
	[CompilerGenerated]
	private void BEBNNCBHMCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7E63320", Offset = "0x7E61F20", VA = "0x187E63320")]
	[CompilerGenerated]
	private void EKHNDILBGNK(BKAMKLHBKNN KFNDMAAELJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class CIAAKIHGPNE : MNDDBNEICIO, IJPLFCONMAM
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate void KODDIFGIGDL(BKAMKLHBKNN FMIDNBLDNCI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly KODDIFGIGDL CMKMKEPJKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly BECKMACIBDE KIGNDOEDMOB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string FEGHCLOCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x59181B0", Offset = "0x5916DB0", VA = "0x1859181B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string PJLANHDCFPP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xF1E470", Offset = "0xF1D070", VA = "0x180F1E470", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x707D530", Offset = "0x707C130", VA = "0x18707D530")]
	public CIAAKIHGPNE(BECKMACIBDE JJKFIBNFCFA, [Optional] KODDIFGIGDL OECJHGAGFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E720", Offset = "0x3A3D320", VA = "0x183A3E720", Slot = "6")]
	public T LGFPFICEOKK<T>(string DHCHBFGMFFD, T PLEDLJICBFM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KFBOKFNFLJO
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[UsedImplicitly]
public class JNANBBLIPIF : KFBOKFNFLJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly AOODHKEJNAG JFBLPCIAGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly List<IANHFGEBNFE> OGIAFBDMLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly string NAHLFEJDEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly string GFKIJGENJLK;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7E63FC0", Offset = "0x7E62BC0", VA = "0x187E63FC0")]
	[UsedImplicitly]
	[HHMPGEJNNFC.JKDCLEHGFFF.OKMFHHNNKLI]
	internal static void GDCJIDLIJAN(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7E64030", Offset = "0x7E62C30", VA = "0x187E64030")]
	[RecRoom.NoEngine.Common.Preserve]
	internal JNANBBLIPIF([HAKCNCGPHPD(null)][JetBrains.Annotations.NotNull] AOODHKEJNAG JFBLPCIAGJB, [HAKCNCGPHPD(null)][JetBrains.Annotations.NotNull] CNLKGIJAOHJ IDMGFIECBDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class BDGFKPJDBOI : PEHHKHACOAC
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Task JFAGBJGBBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B270", Offset = "0x7E59E70", VA = "0x187E5B270", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task AMAJFOLFFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5AFF0", Offset = "0x7E59BF0", VA = "0x187E5AFF0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool JBDMHKHHAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool HBFEHNJBHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string MILFPIDBEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public HMPJHOEIIKE KOEFPJAJLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action IKDBFDINFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B560", Offset = "0x7E5A160", VA = "0x187E5B560", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B390", Offset = "0x7E59F90", VA = "0x187E5B390", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action DIKCMPBJCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B4C0", Offset = "0x7E5A0C0", VA = "0x187E5B4C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B880", Offset = "0x7E5A480", VA = "0x187E5B880", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action FJPIDGIFLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B6B0", Offset = "0x7E5A2B0", VA = "0x187E5B6B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B750", Offset = "0x7E5A350", VA = "0x187E5B750", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<BKAMKLHBKNN> NOLGBIOCBCB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B600", Offset = "0x7E5A200", VA = "0x187E5B600", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B110", Offset = "0x7E59D10", VA = "0x187E5B110", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	[RecRoom.NoEngine.Common.Preserve]
	public BDGFKPJDBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B080", Offset = "0x7E59C80", VA = "0x187E5B080", Slot = "12")]
	public Task BFHPBJMBKJO(string FJGFPBGCPAB, [Optional] EBFMNEOIKIB BBAEJJFNOAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B300", Offset = "0x7E59F00", VA = "0x187E5B300", Slot = "19")]
	public Task KCPHJNKPFIC(EBFMNEOIKIB BBAEJJFNOAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B7F0", Offset = "0x7E5A3F0", VA = "0x187E5B7F0", Slot = "20")]
	public Task PMKHDLKDIAC(EBFMNEOIKIB BBAEJJFNOAN, Dictionary<string, string> FFCMDIEJKPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "21")]
	public bool LALMIEOKKEM(string KEBAOHDEHHF, bool KONGJHALCDA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B1C0", Offset = "0x7E59DC0", VA = "0x187E5B1C0", Slot = "22")]
	public ANNJBAIJDJN HFBCANJMMAN(string FFNDHFPLOJO, bool KONGJHALCDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B430", Offset = "0x7E5A030", VA = "0x187E5B430", Slot = "23")]
	public MNDDBNEICIO KOJDMOKANEL(string EBKJJLBGBOL, bool KONGJHALCDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7E5AF60", Offset = "0x7E59B60", VA = "0x187E5AF60", Slot = "24")]
	public Task ADJALNBAGNA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class GEICNPPACOL : HMPJHOEIIKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly NNCGGBPGGFM LHPCGFNHKDD;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IReadOnlyDictionary<string, object> ABMKPDIHEEO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xF1F0D0", Offset = "0xF1DCD0", VA = "0x180F1F0D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public GEICNPPACOL(NNCGGBPGGFM HLJBKLGHBLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface FDNDOJIDAPF
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIFMGGDKFKJ DLEAJAIKALD(string OBFCCOBFGHI);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface DLJGFIJIADD
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum JLGJEKKCCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum KKDBMFCOBPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Add,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Remove,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Purchase,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		RemoveFromUpdate
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	long AMKIJMICAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string AGOCFCLCAID
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string APPCBDKPHAD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool FLKCGNEIFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long KHFGAEDNACG();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFEKODIKKFA(long APLKCLBHHOJ, bool MFGNOHELBHM = true);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AGFJGKHEFEC(string PBHLPKLGFAP, string AHIPKNFFHDO, string FFADAKCEKLL);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NLCFGEMPJFF(Guid BIDMJCHJCOC, Guid PGIDCHNAMIH, bool OFCAOGLJGJD);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PFDBFBGPNAI(string PBHLPKLGFAP);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OHAONBKCNGD(string PBHLPKLGFAP, string DPCNBGABDND, string NGCBKPEBPII);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PHHEJJEJEEH(string JOMHOLNGBJJ, object CIMPNBKHBOO, object IHPPBGHNJCM);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GKPHCNIEANH(JLGJEKKCCLJ PIDAGCOINDG, int KHGDCKMEAJM, [Optional] NBDJOKHDIFE JBJBBDEHMEE, [Optional] string HCPGLGPEAHM, [Optional] string PDIIGKEPNLO);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FJPDMFDDACB(NBDJOKHDIFE JBJBBDEHMEE, long CCKJCJELNGL, long MPJAKPKOPGC, int LMHHFHBFLED, string HCPGLGPEAHM, int KHGDCKMEAJM);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JPCCDNCCNFL(NBDJOKHDIFE JBJBBDEHMEE, bool LMBHCDMMAPI, [Optional] string PDIIGKEPNLO);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DKPBGFOBECG(NBDJOKHDIFE JBJBBDEHMEE, bool LMBHCDMMAPI, [Optional] string PDIIGKEPNLO);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FCOAIGOMJOO(NBDJOKHDIFE JBJBBDEHMEE, bool LMBHCDMMAPI, [Optional] string PDIIGKEPNLO);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FCOFDFDGGAE(long MJILNJAJHOI, string LFGKCAMIEMN);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GDMALEFEKLN(string LENOHNAJDNM);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task KBGMHGBBKHK(KKDBMFCOBPE KLIEOOEGDML, Guid? ICGHAGOBGHG, List<MBCHAJLOPLD> PEGHNJKPFMH, List<MBCHAJLOPLD> ICHECNFCPFP, Func<ENIOBPLBCEN, long> LABMAIMFHEF, string EOLKAOHFOOC, bool? ELAPGOEKLFO, [Optional] long? OHNCPNOJJPF);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface LGDDCMGAOLD
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string ANMKFBONMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
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
