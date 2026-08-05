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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x73B2860", Offset = "0x73B1C60", VA = "0x1873B2860")]
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
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
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
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x73B1DB0", Offset = "0x73B11B0", VA = "0x1873B1DB0", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x73B3AC0", Offset = "0x73B2EC0", VA = "0x1873B3AC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
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
		public AmplitudeAnalyticsClient.Settings JOKGKKOFMJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LGKDNPIGLFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x96A750", Offset = "0x969B50", VA = "0x18096A750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, PCDEJAOCFEP
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum MMKOMDKPJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class IIJLHDFLGEF
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class BEDPOJEHDNG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int FLAPAGIPGAO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> BGNKBOJBFMC;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
				public BEDPOJEHDNG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class KJPBAJJAOKP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
				public KJPBAJJAOKP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x73B1C20", Offset = "0x73B1020", VA = "0x1873B1C20")]
				internal bool OENHBNGOHJA(BEDPOJEHDNG item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string JALKGAKNAIB = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string CBAOKODFJCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<BEDPOJEHDNG> MIAJPCAAGOP;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? ENECDKIJPDE
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x73AE460", Offset = "0x73AD860", VA = "0x1873AE460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x73AE500", Offset = "0x73AD900", VA = "0x1873AE500")]
			internal IIJLHDFLGEF(string COHFFLLOAOK, string DNBLAAELGNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x73AD2B0", Offset = "0x73AC6B0", VA = "0x1873AD2B0")]
			public int ADDOEMBLGHA([Optional] int? ECMGKENIAPJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x73ADDF0", Offset = "0x73AD1F0", VA = "0x1873ADDF0")]
			public List<Dictionary<string, object>> JDMCBGPHFBG(int DIBKCICCNNM, int? ECMGKENIAPJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x73ADD50", Offset = "0x73AD150", VA = "0x1873ADD50")]
			public void HLGAHALJIED(AmplitudeAnalyticsIdentifyMessage NBAMGPFDMIB, bool EHBNJFMEFPL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x73ADC40", Offset = "0x73AD040", VA = "0x1873ADC40")]
			public void HLGAHALJIED(Dictionary<string, object> NBAMGPFDMIB, bool EHBNJFMEFPL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x73AD680", Offset = "0x73ACA80", VA = "0x1873AD680")]
			public void CPPHMMNAPIN(params Dictionary<string, object>[] IAKKKDHCJAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x73ADA00", Offset = "0x73ACE00", VA = "0x1873ADA00")]
			public void HHLBNIFFFPJ(List<Dictionary<string, object>> PGGPIPIABDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x73AD460", Offset = "0x73AC860", VA = "0x1873AD460")]
			private void AJNMIFKOPKM(Dictionary<string, object> NBAMGPFDMIB, bool EHBNJFMEFPL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x73AD800", Offset = "0x73ACC00", VA = "0x1873AD800")]
			public void GDLFGCLIAJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x73AE060", Offset = "0x73AD460", VA = "0x1873AE060")]
			private void LIILEEOCDCB([Optional] string KLJMJDGKAPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x73AD560", Offset = "0x73AC960", VA = "0x1873AD560")]
			private static string CKINIGMGEED(string PEBNJNGMMHE, string MCNLCGLNHHO)
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
			[Cpp2IlInjected.Address(RVA = "0x73B36E0", Offset = "0x73B2AE0", VA = "0x1873B36E0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct BIKFMNIONLI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int KEFFGBGDIPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string MFEMIHMHPAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T MKINHOPMJMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MODHBOCDFGA : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private MOLDBMJPKNN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
			[DebuggerHidden]
			public MODHBOCDFGA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x73B2080", Offset = "0x73B1480", VA = "0x1873B2080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x73B2810", Offset = "0x73B1C10", VA = "0x1873B2810", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class MDCPKOGOLKJ : IEnumerator<object>, IEnumerator, IDisposable
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
			public DOJAMHMCGOK quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
			[DebuggerHidden]
			public MDCPKOGOLKJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x73B1E40", Offset = "0x73B1240", VA = "0x1873B1E40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x73B1F50", Offset = "0x73B1350", VA = "0x1873B1F50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class GPCBCFOFIPC : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
			[DebuggerHidden]
			public GPCBCFOFIPC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x73ABFD0", Offset = "0x73AB3D0", VA = "0x1873ABFD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x73AC140", Offset = "0x73AB540", VA = "0x1873AC140", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class KANLHOCFINO : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private MOLDBMJPKNN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
			[DebuggerHidden]
			public KANLHOCFINO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x73AEEC0", Offset = "0x73AE2C0", VA = "0x1873AEEC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x73AF120", Offset = "0x73AE520", VA = "0x1873AF120", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class BOPMDOAGOIN : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private MOLDBMJPKNN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
			[DebuggerHidden]
			public BOPMDOAGOIN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x73A8940", Offset = "0x73A7D40", VA = "0x1873A8940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x73A8B90", Offset = "0x73A7F90", VA = "0x1873A8B90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class IALAMDFADNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public IIJLHDFLGEF cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public IALAMDFADNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x73AC5E0", Offset = "0x73AB9E0", VA = "0x1873AC5E0")]
			internal void FJPPIADJKOI(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x73AC190", Offset = "0x73AB590", VA = "0x1873AC190")]
			internal void EOFBLPPCLCG(BIKFMNIONLI<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class PGPLLIAABHD : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private MOLDBMJPKNN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public IIJLHDFLGEF cache;

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
			private IALAMDFADNL <>8__1;

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
			private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
			[DebuggerHidden]
			public PGPLLIAABHD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x73B2B20", Offset = "0x73B1F20", VA = "0x1873B2B20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x73B3320", Offset = "0x73B2720", VA = "0x1873B3320", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class ALAIHKDALCK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public ALAIHKDALCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4736860", Offset = "0x4735C60", VA = "0x184736860")]
			internal BIKFMNIONLI<T> ABFMLBLDCDA(MCHHGHDCIPH postResponse)
			{
				return default(BIKFMNIONLI<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MPOANHNJNCL PLOJFHJIOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<PIFFNGJMMKJ> KFDJFJFNDFM;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string MJCLDANLPPP = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string GNLKKALDLIF = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string EPMDEGELGJL = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int EFDPGIPADPL = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int DGHIIFMCEIE = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int AACLJJDBPJP = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float BEIFJGDIBOI = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long CPBNKLFFGAN = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string HIPPDGNLPPP = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string JKDKHLOOCNI = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string MEEKPICEPFB = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string OFMPANLKANJ = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool BNJJNNEIELM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool CAKEFBIIOCK;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int BKKABGKNPDN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int OAMGDFOMPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private BCKFBHFHBHN DJLBFLGLJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private ACIOJCKHAEM JNGFCHPHJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private PHBCPCHNMPE MEGFEENFKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool ANPMJAPFLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float NBHPDEIKOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float APFBFLOIDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int CFBFCFALGOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int CKENCGPKALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? CFGMKLNBHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? FAHCDKFPGMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long NCLLFKIJNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string COAKEBHCOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string DBGINICFILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long CAIPDBJLMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string KACOODPCKIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string AIBGDBPJEAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> LKBEBKFGPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private MMKOMDKPJIJ FDJPBCMMCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int GLPILNABCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int PDKGKDNFIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float NDJEGAKPPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool GAAEJLINLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool AGHCEDBFCBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IIJLHDFLGEF JACEINMLMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private IIJLHDFLGEF LEHJKBFNBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private IIJLHDFLGEF MGCHDKFHCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string CHGACMHBLAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> OGAFIHECENC;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo PLIKBKNDEDA;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string DAOCFNDLHGO;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string KAELMMCKJOC = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string CAJJAJCPCBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string MDPBKHKBPIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string OJJFACFDPAJ;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private MPOANHNJNCL KDFHOPFBABF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x73A23F0", Offset = "0x73A17F0", VA = "0x1873A23F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private PIFFNGJMMKJ KEBPMNNMJIP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x73A20E0", Offset = "0x73A14E0", VA = "0x1873A20E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int JEIEBLPJEJG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x73A3690", Offset = "0x73A2A90", VA = "0x1873A3690")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long HBCLPHFMPDP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x73A6E50", Offset = "0x73A6250", VA = "0x1873A6E50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x73A6F60", Offset = "0x73A6360", VA = "0x1873A6F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string BHEAFGKHNEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x73A6E20", Offset = "0x73A6220", VA = "0x1873A6E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OPONMODNLPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x12B22A0", Offset = "0x12B16A0", VA = "0x1812B22A0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x12B0FD0", Offset = "0x12B03D0", VA = "0x1812B0FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ELLFGOFFOGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA97C40", Offset = "0xA97040", VA = "0x180A97C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA9DE40", Offset = "0xA9D240", VA = "0x180A9DE40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? BFLEMGECPGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA97C50", Offset = "0xA97050", VA = "0x180A97C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA9DA80", Offset = "0xA9CE80", VA = "0x180A9DA80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IINAFGGPIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xCCBE40", Offset = "0xCCB240", VA = "0x180CCBE40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x1193760", Offset = "0x1192B60", VA = "0x181193760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool MFECEKEIAML
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x73A6D00", Offset = "0x73A6100", VA = "0x1873A6D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> CNOLMFCFHNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x73A6C40", Offset = "0x73A6040", VA = "0x1873A6C40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x73A6EA0", Offset = "0x73A62A0", VA = "0x1873A6EA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x73A1A80", Offset = "0x73A0E80", VA = "0x1873A1A80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x73A1520", Offset = "0x73A0920", VA = "0x1873A1520")]
		private void AILKBIEAPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x73A6280", Offset = "0x73A5680", VA = "0x1873A6280")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x73A4E70", Offset = "0x73A4270", VA = "0x1873A4E70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x73A65B0", Offset = "0x73A59B0", VA = "0x1873A65B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x73A5000", Offset = "0x73A4400", VA = "0x1873A5000")]
		public OCLDKMPDLBK PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x73A3320", Offset = "0x73A2720", VA = "0x1873A3320")]
		[IteratorStateMachine(typeof(MODHBOCDFGA))]
		public IEnumerator<MOLDBMJPKNN> InitializeForLocalAccount(AmplitudeAnalyticsEvent PMDMPMPBHCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x73A5960", Offset = "0x73A4D60", VA = "0x1873A5960")]
		public void SendAppEnterEvent(bool FMMHGHHBOBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x73A6530", Offset = "0x73A5930", VA = "0x1873A6530")]
		public void UpdateLastKnownInteractionCategory(string LPIDGGIHONC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x73A6480", Offset = "0x73A5880", VA = "0x1873A6480")]
		public void UpdateLastAliveTime(float JHAIOFABKNB = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x73A3890", Offset = "0x73A2C90", VA = "0x1873A3890")]
		private OCLDKMPDLBK LEOCMCNOBOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x73A33B0", Offset = "0x73A27B0", VA = "0x1873A33B0")]
		private OCLDKMPDLBK JDEFPKMIFJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x73A5C70", Offset = "0x73A5070", VA = "0x1873A5C70")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x73A4DE0", Offset = "0x73A41E0", VA = "0x1873A4DE0")]
		[IteratorStateMachine(typeof(MDCPKOGOLKJ))]
		private IEnumerator OMFPHBFEIOM(DOJAMHMCGOK KEGNNKBJIFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x73A6840", Offset = "0x73A5C40", VA = "0x1873A6840")]
		[IteratorStateMachine(typeof(GPCBCFOFIPC))]
		public IEnumerator WaitForFlush(float OFCJJHCKIII = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x73A6360", Offset = "0x73A5760", VA = "0x1873A6360")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x73A62A0", Offset = "0x73A56A0", VA = "0x1873A62A0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime LLHIMIEALOC)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x73A2E30", Offset = "0x73A2230", VA = "0x1873A2E30")]
		public static JBLMCAJDIOM Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x73A18E0", Offset = "0x73A0CE0", VA = "0x1873A18E0")]
		public static ECKNJDEFDLE AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string OPOAEAPCBHA, string KBMKGCENPKE, HCGMNMOOGOF AGBGMLEGLKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x73A2480", Offset = "0x73A1880", VA = "0x1873A2480")]
		public static ECKNJDEFDLE Event([JetBrains.Annotations.NotNull] string OPOAEAPCBHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x73A5190", Offset = "0x73A4590", VA = "0x1873A5190")]
		public static ECKNJDEFDLE PreviousSessionEvent([JetBrains.Annotations.NotNull] string OPOAEAPCBHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x73A2FD0", Offset = "0x73A23D0", VA = "0x1873A2FD0")]
		public static ECKNJDEFDLE InitializeEvent(string KBMKGCENPKE, int NBAHAEPCOFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x73A5E70", Offset = "0x73A5270", VA = "0x1873A5E70")]
		public static ECKNJDEFDLE StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x73A2130", Offset = "0x73A1530", VA = "0x1873A2130")]
		public static ECKNJDEFDLE CreateOutOfSessionEvent(string OPOAEAPCBHA, bool OMHCGDGDACJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x73A3BA0", Offset = "0x73A2FA0", VA = "0x1873A3BA0")]
		public static OCLDKMPDLBK LogOutOfSessionEvent(ECKNJDEFDLE EBPIMLKOJFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x73A3940", Offset = "0x73A2D40", VA = "0x1873A3940")]
		public void LogEventAsync(AmplitudeAnalyticsEvent KHFPAFIPBPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x73A3D60", Offset = "0x73A3160", VA = "0x1873A3D60")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent KHFPAFIPBPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x73A3E90", Offset = "0x73A3290", VA = "0x1873A3E90")]
		public void LogSerializedEventAsync(Dictionary<string, object> JJOCKMPLFPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x73A3A70", Offset = "0x73A2E70", VA = "0x1873A3A70")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage DDDCJMJMHEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x73A2780", Offset = "0x73A1B80", VA = "0x1873A2780")]
		private void FGKEHIJIHEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x73A2910", Offset = "0x73A1D10", VA = "0x1873A2910")]
		private void GAHNMKFGNGD(Dictionary<string, object> ONOFIEDKHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x73A2BD0", Offset = "0x73A1FD0", VA = "0x1873A2BD0")]
		private void HPIAMJCLIAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x73A1010", Offset = "0x73A0410", VA = "0x1873A1010")]
		private void ABLLHKHJGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x73A2880", Offset = "0x73A1C80", VA = "0x1873A2880")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x73A4F20", Offset = "0x73A4320", VA = "0x1873A4F20")]
		[IteratorStateMachine(typeof(KANLHOCFINO))]
		private IEnumerator<MOLDBMJPKNN> PHMNLHLLMDB(float OFCJJHCKIII = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x73A3520", Offset = "0x73A2920", VA = "0x1873A3520")]
		[IteratorStateMachine(typeof(BOPMDOAGOIN))]
		private IEnumerator<MOLDBMJPKNN> KCPLDALGMNO(float OFCJJHCKIII = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x73A35B0", Offset = "0x73A29B0", VA = "0x1873A35B0")]
		[IteratorStateMachine(typeof(PGPLLIAABHD))]
		private IEnumerator<MOLDBMJPKNN> KOGPEMGEOBF(IIJLHDFLGEF IHGBEEAPOFO, int? ECMGKENIAPJ, string LHLPPHFKNKD, float OFCJJHCKIII, Action<int> HJHNCBCDFAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x73A4CD0", Offset = "0x73A40D0", VA = "0x1873A4CD0")]
		private static void OGOCOPGPPGE(bool DKCGHNAEKHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x73A11E0", Offset = "0x73A05E0", VA = "0x1873A11E0")]
		private HHPFDJMLPAL<BIKFMNIONLI<Dictionary<string, object>>> AIJGPHKBFDN(string LHLPPHFKNKD, string MJLMLGGKOJC, Dictionary<string, object> MKINHOPMJMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x73A12B0", Offset = "0x73A06B0", VA = "0x1873A12B0")]
		private HHPFDJMLPAL<BIKFMNIONLI<List<Dictionary<string, object>>>> AIJGPHKBFDN(string LHLPPHFKNKD, string MJLMLGGKOJC, List<Dictionary<string, object>> MKINHOPMJMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3C06620", Offset = "0x3C05A20", VA = "0x183C06620")]
		private HHPFDJMLPAL<BIKFMNIONLI<T>> MIOBMLGKEIP<T>(string KHEGPKJHFJB, string LHLPPHFKNKD, string MJLMLGGKOJC, T MKINHOPMJMD, Dictionary<string, object> PGFGFGOHJJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x73A4FB0", Offset = "0x73A43B0", VA = "0x1873A4FB0")]
		private bool PMGDJOHOFDG(float AMOMCNHNNKK, float OFCJJHCKIII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x73A3F70", Offset = "0x73A3370", VA = "0x1873A3F70")]
		private Dictionary<string, object> NKAOGCCBKFB(string LHLPPHFKNKD, Dictionary<string, object> MKINHOPMJMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x73A6930", Offset = "0x73A5D30", VA = "0x1873A6930")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x991AF0", Offset = "0x990EF0", VA = "0x180991AF0", Slot = "6")]
		private bool EDMNCKJLANA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x73A2CC0", Offset = "0x73A20C0", VA = "0x1873A2CC0")]
		[CompilerGenerated]
		private long IGMKIJECKEH()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x73A2BC0", Offset = "0x73A1FC0", VA = "0x1873A2BC0")]
		[CompilerGenerated]
		private void HCHOMDHMMEK(int ADDGBJDFHLB)
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
			[Cpp2IlInjected.Address(RVA = "0x73A7C40", Offset = "0x73A7040", VA = "0x1873A7C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x73A7D10", Offset = "0x73A7110", VA = "0x1873A7D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x73A7C80", Offset = "0x73A7080", VA = "0x1873A7C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x73A7D60", Offset = "0x73A7160", VA = "0x1873A7D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x73A7C00", Offset = "0x73A7000", VA = "0x1873A7C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x73A7CC0", Offset = "0x73A70C0", VA = "0x1873A7CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9650D0", Offset = "0x9644D0", VA = "0x1809650D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x73A7340", Offset = "0x73A6740", VA = "0x1873A7340")]
		public static ECKNJDEFDLE GEEFBNOOFMP(string IFKCKGNMHDI, [JetBrains.Annotations.NotNull] string KKABDGGFDJF, long AKOHGADPNOK, long NCOPHMHDBIB, string KBMKGCENPKE, string AGBGMLEGLKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x73A7900", Offset = "0x73A6D00", VA = "0x1873A7900")]
		public static ECKNJDEFDLE IICBDBCNHOK(string IFKCKGNMHDI, [JetBrains.Annotations.NotNull] string KKABDGGFDJF, long AKOHGADPNOK, long NCOPHMHDBIB, string KBMKGCENPKE, long PIJBGOPJLCJ, string GAABCBKACJA, string FFJILDFFGPM, string BLBHFGKLLDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x73A7A60", Offset = "0x73A6E60", VA = "0x1873A7A60")]
		private AmplitudeAnalyticsEvent(string IFKCKGNMHDI, [JetBrains.Annotations.NotNull] string KKABDGGFDJF, long AKOHGADPNOK, long NCOPHMHDBIB, string KBMKGCENPKE, string AGBGMLEGLKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD31FD0", Offset = "0xD313D0", VA = "0x180D31FD0")]
		public void KBJHDEJIICJ(long BFIACKIABEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x73A70D0", Offset = "0x73A64D0", VA = "0x1873A70D0", Slot = "5")]
		public override void DLNEPIOLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x73A71D0", Offset = "0x73A65D0", VA = "0x1873A71D0", Slot = "6")]
		public override void DOAKJBGDPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x73A7440", Offset = "0x73A6840", VA = "0x1873A7440", Slot = "4")]
		protected override Dictionary<string, object> HBGJBBAPBPB(Dictionary<string, object> COEGFJFLLJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x73A6FC0", Offset = "0x73A63C0", VA = "0x1873A6FC0")]
		private void DIHCGEEOKJJ(string MCNLCGLNHHO, string PEBNJNGMMHE, bool JLMDHMFNMGC = false)
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
			[Cpp2IlInjected.Address(RVA = "0x73A94D0", Offset = "0x73A88D0", VA = "0x1873A94D0")]
			public void OANEBHOMAOO(Dictionary<string, object> JINAACGDPMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
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
			[Cpp2IlInjected.Address(RVA = "0x73B3370", Offset = "0x73B2770", VA = "0x1873B3370")]
			public void OANEBHOMAOO(Dictionary<string, object> KNNHMJEJEHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x1159800", Offset = "0x1158C00", VA = "0x181159800")]
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
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x73A7F30", Offset = "0x73A7330", VA = "0x1873A7F30")]
		public static JBLMCAJDIOM GEEFBNOOFMP(string IFKCKGNMHDI, string KBMKGCENPKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x73A8460", Offset = "0x73A7860", VA = "0x1873A8460")]
		protected AmplitudeAnalyticsIdentifyMessage(string IFKCKGNMHDI, string KBMKGCENPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x73A8330", Offset = "0x73A7730", VA = "0x1873A8330")]
		public Dictionary<string, object> IOJGFFNMGHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x73A7FF0", Offset = "0x73A73F0", VA = "0x1873A7FF0", Slot = "4")]
		protected virtual Dictionary<string, object> HBGJBBAPBPB(Dictionary<string, object> COEGFJFLLJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x73A83C0", Offset = "0x73A77C0", VA = "0x1873A83C0")]
		protected void KOBNBIMKEBE(string MCNLCGLNHHO, Dictionary<string, object> JLKNBNAHBNL, Dictionary<string, object> FNPKLPMDGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x73A7DB0", Offset = "0x73A71B0", VA = "0x1873A7DB0")]
		protected void ANDOLJPEJJI(string MCNLCGLNHHO, string PEBNJNGMMHE, Dictionary<string, object> JGPJLGAGLMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x73A7E20", Offset = "0x73A7220", VA = "0x1873A7E20", Slot = "5")]
		public virtual void DLNEPIOLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x73A7EB0", Offset = "0x73A72B0", VA = "0x1873A7EB0", Slot = "6")]
		public virtual void DOAKJBGDPNJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JBLMCAJDIOM : NDACFGBJEBC<AmplitudeAnalyticsIdentifyMessage, JBLMCAJDIOM>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override JBLMCAJDIOM DCCDLDGDJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage DNIAFNIJEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x73AECD0", Offset = "0x73AE0D0", VA = "0x1873AECD0")]
	public JBLMCAJDIOM(AmplitudeAnalyticsIdentifyMessage LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x73AEC30", Offset = "0x73AE030", VA = "0x1873AEC30", Slot = "4")]
	public override void DOAKJBGDPNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ECKNJDEFDLE : NDACFGBJEBC<AmplitudeAnalyticsEvent, ECKNJDEFDLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool NFIAOINCCEK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override ECKNJDEFDLE DCCDLDGDJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long KBHGFPKDADI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x73A97F0", Offset = "0x73A8BF0", VA = "0x1873A97F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x73A9B70", Offset = "0x73A8F70", VA = "0x1873A9B70")]
	public ECKNJDEFDLE(AmplitudeAnalyticsEvent LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "5")]
	public override AmplitudeAnalyticsEvent DNIAFNIJEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x73A9810", Offset = "0x73A8C10", VA = "0x1873A9810", Slot = "4")]
	public override void DOAKJBGDPNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x32F08F0", Offset = "0x32EFCF0", VA = "0x1832F08F0")]
	public ECKNJDEFDLE LCPEPFIDDBK<T>(string MFGHKKFEKII, T[] PEBNJNGMMHE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x32F08F0", Offset = "0x32EFCF0", VA = "0x1832F08F0")]
	public ECKNJDEFDLE LCPEPFIDDBK(string MFGHKKFEKII, string[] PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x32F0640", Offset = "0x32EFA40", VA = "0x1832F0640")]
	public ECKNJDEFDLE LCPEPFIDDBK<T>(string MFGHKKFEKII, T PEBNJNGMMHE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x73A9950", Offset = "0x73A8D50", VA = "0x1873A9950")]
	public ECKNJDEFDLE LCPEPFIDDBK(string MFGHKKFEKII, long PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x73A98E0", Offset = "0x73A8CE0", VA = "0x1873A98E0")]
	public ECKNJDEFDLE LCPEPFIDDBK(string MFGHKKFEKII, string PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x73A98B0", Offset = "0x73A8CB0", VA = "0x1873A98B0")]
	public ECKNJDEFDLE GJBFEJOGPHI(string MFGHKKFEKII, object? PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x73A9AD0", Offset = "0x73A8ED0", VA = "0x1873A9AD0")]
	public ECKNJDEFDLE POLIJLMKLAA(string MFGHKKFEKII, string PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x73A99D0", Offset = "0x73A8DD0", VA = "0x1873A99D0")]
	private ECKNJDEFDLE LPEHLPMHGMI(string MFGHKKFEKII, object PEBNJNGMMHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JOOKMHJNMOE : ECKNJDEFDLE
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x73A9B70", Offset = "0x73A8F70", VA = "0x1873A9B70")]
	public JOOKMHJNMOE(AmplitudeAnalyticsEvent LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x73AED20", Offset = "0x73AE120", VA = "0x1873AED20", Slot = "4")]
	public override void DOAKJBGDPNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class NDACFGBJEBC<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : NDACFGBJEBC<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M LPIFIOEEOGF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR DCCDLDGDJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public NDACFGBJEBC(M LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4E75780", Offset = "0x4E74B80", VA = "0x184E75780")]
	public BLDR EMIDBLFABJN(AmplitudeAnalyticsIdentifyMessage.DeviceInfo AMNEAPNIJMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4E75970", Offset = "0x4E74D70", VA = "0x184E75970")]
	public BLDR NIOCGIJNIJO(AmplitudeAnalyticsIdentifyMessage.RevenueData LHGFKBACAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4E758D0", Offset = "0x4E74CD0", VA = "0x184E758D0")]
	public BLDR LOPKAKDLLIE(string MFGHKKFEKII, string PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x39A6160", Offset = "0x39A5560", VA = "0x1839A6160")]
	public BLDR LOPKAKDLLIE<T>(string MFGHKKFEKII, T PEBNJNGMMHE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DOAKJBGDPNJ();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4E75750", Offset = "0x4E74B50", VA = "0x184E75750")]
	internal static string BABCLIOFLCP(string PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4E757D0", Offset = "0x4E74BD0", VA = "0x184E757D0")]
	private BLDR GOLGNFIFDED(string MFGHKKFEKII, object PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M DNIAFNIJEIJ();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class GDHPMPPJNBA : BCKFBHFHBHN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct APDKCIHCKIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<MCHHGHDCIPH> <>t__builder;

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
		public GDHPMPPJNBA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x73A0570", Offset = "0x739F970", VA = "0x1873A0570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x73A0FA0", Offset = "0x73A03A0", VA = "0x1873A0FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient OJPNEOIFNGD;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x73AB510", Offset = "0x73AA910", VA = "0x1873AB510")]
	[AEDFFNEEAKJ.AMNMLEGDOCC]
	internal static void NOGBKFBHDOO(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x73AB580", Offset = "0x73AA980", VA = "0x1873AB580")]
	[RecRoom.NoEngine.Common.Preserve]
	public GDHPMPPJNBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x73AB3A0", Offset = "0x73AA7A0", VA = "0x1873AB3A0", Slot = "4")]
	[AsyncStateMachine(typeof(APDKCIHCKIA))]
	public Task<MCHHGHDCIPH> AEKLIHOCDLH(string KHEGPKJHFJB, string PEBJGMHENII, string JBHFNMBHCOL, string JHAFAINBCGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class AGNLCOPDOIC : BCKFBHFHBHN
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class MMCNAOGNFKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<MCHHGHDCIPH> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MMCNAOGNFKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x73B1FA0", Offset = "0x73B13A0", VA = "0x1873B1FA0")]
		internal void DDCFLKJOKOI(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct IOKNJODIPFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<MCHHGHDCIPH> <>t__builder;

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
		private TaskAwaiter<MCHHGHDCIPH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x73AE670", Offset = "0x73ADA70", VA = "0x1873AE670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x73AEBC0", Offset = "0x73ADFC0", VA = "0x1873AEBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	[AEDFFNEEAKJ.AMNMLEGDOCC]
	internal static void NPIJHJLCLOL(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	[RecRoom.NoEngine.Common.Preserve]
	public AGNLCOPDOIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x73A0410", Offset = "0x739F810", VA = "0x1873A0410", Slot = "4")]
	[AsyncStateMachine(typeof(IOKNJODIPFG))]
	public Task<MCHHGHDCIPH> AEKLIHOCDLH(string KHEGPKJHFJB, string PEBJGMHENII, string JBHFNMBHCOL, string JHAFAINBCGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class EAGPEKCLNKI
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> KLNPKAHFKPA;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x73A9650", Offset = "0x73A8A50", VA = "0x1873A9650")]
	internal static bool NOKBDCOGOAN(string MCNLCGLNHHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface BCKFBHFHBHN
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MCHHGHDCIPH> AEKLIHOCDLH(string KHEGPKJHFJB, string PEBJGMHENII, string JBHFNMBHCOL, string JHAFAINBCGE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct MCHHGHDCIPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int OJAMMHLFEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string NJNFJBOAFPA;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1495760", Offset = "0x1494B60", VA = "0x181495760")]
	public MCHHGHDCIPH(int KEFFGBGDIPN, string MFEMIHMHPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum LNCMLJDCPFC
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
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class AANDLEHKKAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private long NEFJFAKNEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private ECKNJDEFDLE PGGGKPFJHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool HGKBFIKJKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float NJAAPLMAKND;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x73A0280", Offset = "0x739F680", VA = "0x1873A0280")]
	public AANDLEHKKAP(string CPOHAGKCFGG, float NJAAPLMAKND = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3BB61B0", Offset = "0x3BB55B0", VA = "0x183BB61B0")]
	public void LCPEPFIDDBK<T>(string MFGHKKFEKII, T PEBNJNGMMHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x73A0000", Offset = "0x739F400", VA = "0x1873A0000")]
	public void LCPEPFIDDBK(string MFGHKKFEKII, string PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x73A0190", Offset = "0x739F590", VA = "0x1873A0190")]
	public void NMPFELEJPIL(string OOFJOPNMOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x739FF40", Offset = "0x739F340", VA = "0x18739FF40")]
	public void KIALJLKPPBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x73A0080", Offset = "0x739F480", VA = "0x1873A0080")]
	private void NMJHECIODJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x739FEF0", Offset = "0x739F2F0", VA = "0x18739FEF0")]
	private bool FDOBNKALNGE()
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
		public enum JJHKEMGAMJO
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
		private JJHKEMGAMJO parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public JJHKEMGAMJO Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAE5990", Offset = "0xAE4D90", VA = "0x180AE5990")]
			get
			{
				return default(JJHKEMGAMJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x993140", Offset = "0x992540", VA = "0x180993140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x73B34E0", Offset = "0x73B28E0", VA = "0x1873B34E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class BFMOCAACNFH<T> : DPBNAOAILKK<T>, IHLPOMLMOMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly HKNCEKAFBLB OANGCDEFDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string AEPPPPJLFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string DAPOANIDJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private T GPBAJEBEDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly T CIKOELCEFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool DLIGFGPMFKO;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string GFIJGFOGIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5C850D0", Offset = "0x5C844D0", VA = "0x185C850D0")]
	public BFMOCAACNFH(HKNCEKAFBLB OANGCDEFDJB, string AEPPPPJLFAJ, string DAPOANIDJKG, T CIKOELCEFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5C84B60", Offset = "0x5C83F60", VA = "0x185C84B60", Slot = "4")]
	public T KDOJKOMAMBG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5C84B50", Offset = "0x5C83F50", VA = "0x185C84B50", Slot = "6")]
	public void JIMFDDOIBMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
public class CIAKIECEKMC : DOHAEDJMKMC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct LCAAJEJHAGB : IEquatable<LCAAJEJHAGB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly string AALKONKDLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly string KEGAOIHKHPA;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9CC970", Offset = "0x9CBD70", VA = "0x1809CC970")]
		public LCAAJEJHAGB(string FFJPKGHBPNC, string HIDHBKALCLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6BC3AB0", Offset = "0x6BC2EB0", VA = "0x186BC3AB0", Slot = "4")]
		public bool Equals(LCAAJEJHAGB MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x73B1C90", Offset = "0x73B1090", VA = "0x1873B1C90", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x73B1D40", Offset = "0x73B1140", VA = "0x1873B1D40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private HKNCEKAFBLB OANGCDEFDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<LCAAJEJHAGB, IHLPOMLMOMB> ECDPFLGPPJN;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x73A90E0", Offset = "0x73A84E0", VA = "0x1873A90E0")]
	[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
	internal static void OOLIJHLPGJB(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x73A9150", Offset = "0x73A8550", VA = "0x1873A9150")]
	[RecRoom.NoEngine.Common.Preserve]
	public CIAKIECEKMC([System.Diagnostics.CodeAnalysis.NotNull][PNFCCJKFMBH(null)] HKNCEKAFBLB OANGCDEFDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x73A8E20", Offset = "0x73A8220", VA = "0x1873A8E20", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x73A8F20", Offset = "0x73A8320", VA = "0x1873A8F20")]
	private void LDIDNANJGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x73A8F30", Offset = "0x73A8330", VA = "0x1873A8F30")]
	private void NCANEHJKIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3276290", Offset = "0x3275690", VA = "0x183276290", Slot = "4")]
	public DPBNAOAILKK<T> AGLDCLDMONB<T>(string AEPPPPJLFAJ, string PIHDLFPOPKJ, T CIKOELCEFFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class EFEOEBKCPPO : EMHLKGNIAGM, FALOAKKFPMD
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void HLGDMOJHAOA(LBCAIBIOCBM AFFIINHJOEF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly OBLIMGMPDEB IDHPKJAACID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly HLGDMOJHAOA PDHAFEINFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly string MELHOENJINB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string EEBIHLMDJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x197EB90", Offset = "0x197DF90", VA = "0x18197EB90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HLODMNGDNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x73A9BC0", Offset = "0x73A8FC0", VA = "0x1873A9BC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LIFMLNGEDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x73A9BE0", Offset = "0x73A8FE0", VA = "0x1873A9BE0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public IReadOnlyList<string> FBHALIGJJKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x197EA30", Offset = "0x197DE30", VA = "0x18197EA30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x73A9C00", Offset = "0x73A9000", VA = "0x1873A9C00")]
	public EFEOEBKCPPO(OBLIMGMPDEB FLKLAANBPFM, string LNKOMPBEMNB, [Optional] HLGDMOJHAOA LCHNMJAFNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x32F18D0", Offset = "0x32F0CD0", VA = "0x1832F18D0", Slot = "8")]
	public T FCPELJIOJPN<T>(string MCNLCGLNHHO, T CIKOELCEFFM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class KIHJNPJNIPL : HKNCEKAFBLB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct GLOEMNHCPKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public ACIOJCKHAEM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public KIHJNPJNIPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x73AB600", Offset = "0x73AAA00", VA = "0x1873AB600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x73ABF70", Offset = "0x73AB370", VA = "0x1873ABF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct OAEHBHAGNLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x73B28E0", Offset = "0x73B1CE0", VA = "0x1873B28E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x73B2AC0", Offset = "0x73B1EC0", VA = "0x1873B2AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct EIMLHIHONDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public ACIOJCKHAEM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public KIHJNPJNIPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x73A9C70", Offset = "0x73A9070", VA = "0x1873A9C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x73AA0A0", Offset = "0x73A94A0", VA = "0x1873AA0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct BKPNEHPMHGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public KIHJNPJNIPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public ACIOJCKHAEM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x73A8520", Offset = "0x73A7920", VA = "0x1873A8520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x73A88E0", Offset = "0x73A7CE0", VA = "0x1873A88E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly IReadOnlyDictionary<string, JCNOHDDLADH> GDEIIDHOBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool FDPMMOELDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool IHGNCHFBPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private TaskCompletionSource<bool> DNFOCBGOMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private TaskCompletionSource<bool> AJCNMDPMLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly SemaphoreSlim FAJGDLFPANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private DCIFEKNMPLF KOKNFLAFOIP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Task BOFBMBDNPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x73B0E70", Offset = "0x73B0270", VA = "0x1873B0E70", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task MOMAMBGMIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x73AFD30", Offset = "0x73AF130", VA = "0x1873AFD30", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool NDCPECEIGPO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xB8D840", Offset = "0xB8CC40", VA = "0x180B8D840", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GKIPHIOFEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xB8D860", Offset = "0xB8CC60", VA = "0x180B8D860", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string ELLFGOFFOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x73B10B0", Offset = "0x73B04B0", VA = "0x1873B10B0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public FJHCPKEHMAL FHEDKHONPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x73B0D90", Offset = "0x73B0190", VA = "0x1873B0D90", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GBAHHMHGFAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x73B18D0", Offset = "0x73B0CD0", VA = "0x1873B18D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x73AFBF0", Offset = "0x73AEFF0", VA = "0x1873AFBF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BMCOCMHBOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x73B11B0", Offset = "0x73B05B0", VA = "0x1873B11B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x73B1710", Offset = "0x73B0B10", VA = "0x1873B1710", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GNGHMJMIGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x73AFB50", Offset = "0x73AEF50", VA = "0x1873AFB50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x73AFC90", Offset = "0x73AF090", VA = "0x1873AFC90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<LBCAIBIOCBM> NINNIKKAGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x73AFF40", Offset = "0x73AF340", VA = "0x1873AFF40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x73B0DC0", Offset = "0x73B01C0", VA = "0x1873B0DC0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x73AFF20", Offset = "0x73AF320", VA = "0x1873AFF20", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x73B17B0", Offset = "0x73B0BB0", VA = "0x1873B17B0", Slot = "12")]
	[AsyncStateMachine(typeof(GLOEMNHCPKM))]
	public Task OBBALIPJEND(string DNBLAAELGNE, [Optional] ACIOJCKHAEM IPLCJOBGMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x73B03A0", Offset = "0x73AF7A0", VA = "0x1873B03A0", Slot = "24")]
	[AsyncStateMachine(typeof(OAEHBHAGNLE))]
	public Task GPHPKALMMCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x73B1250", Offset = "0x73B0650", VA = "0x1873B1250", Slot = "19")]
	[AsyncStateMachine(typeof(EIMLHIHONDL))]
	public Task LNFLFDOPOCA(ACIOJCKHAEM IPLCJOBGMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x73AFD70", Offset = "0x73AF170", VA = "0x1873AFD70")]
	private void DAEJCJMMLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x73AFE10", Offset = "0x73AF210", VA = "0x1873AFE10", Slot = "20")]
	[AsyncStateMachine(typeof(BKPNEHPMHGB))]
	public Task DJINPGFBNNJ(ACIOJCKHAEM IPLCJOBGMMJ, Dictionary<string, string> CFLEEONCIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x73B10C0", Offset = "0x73B04C0", VA = "0x1873B10C0", Slot = "21")]
	public bool LKJMJOPJLGH(string CNAKCPGIHFF, bool GHFHPGEHMMF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x73B0EF0", Offset = "0x73B02F0", VA = "0x1873B0EF0", Slot = "22")]
	public EMHLKGNIAGM LEFFAENNKDG(string LNKOMPBEMNB, bool GHFHPGEHMMF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x73B1350", Offset = "0x73B0750", VA = "0x1873B1350")]
	private OBLIMGMPDEB MJMICCGGPKJ(string LNKOMPBEMNB, bool GHFHPGEHMMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x73B1560", Offset = "0x73B0960", VA = "0x1873B1560", Slot = "23")]
	public HHBOFLHCMCF NDLFNCPMLPA(string FFJPKGHBPNC, bool GHFHPGEHMMF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x73B0100", Offset = "0x73AF500", VA = "0x1873B0100")]
	private CJKCKKKEDLH GCJPGDJDHJG(string FFJPKGHBPNC, bool GHFHPGEHMMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x73B0450", Offset = "0x73AF850", VA = "0x1873B0450")]
	private HODHGOOJIBH HNMNKBMALCP(ACIOJCKHAEM IPLCJOBGMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x73B0200", Offset = "0x73AF600", VA = "0x1873B0200")]
	private BELNGGNLMEF GGGINALJCBM(string DNBLAAELGNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x73AFFF0", Offset = "0x73AF3F0", VA = "0x1873AFFF0")]
	private void EJMGEMHCMLN(string LNKOMPBEMNB, OBLIMGMPDEB FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x73B1B20", Offset = "0x73B0F20", VA = "0x1873B1B20")]
	public KIHJNPJNIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x73B0EB0", Offset = "0x73B02B0", VA = "0x1873B0EB0")]
	[CompilerGenerated]
	private void MABFPOHOCNE(LBCAIBIOCBM NPJNBFDHKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x73B0EB0", Offset = "0x73B02B0", VA = "0x1873B0EB0")]
	[CompilerGenerated]
	private void JHOGAEDNEKB(LBCAIBIOCBM NPJNBFDHKLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class ELJCJNKNCAH : HKNCEKAFBLB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct KBBAPLJDGKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ELJCJNKNCAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public ACIOJCKHAEM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x73AF170", Offset = "0x73AE570", VA = "0x1873AF170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x73AFAF0", Offset = "0x73AEEF0", VA = "0x1873AFAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct CDCNFIKGAKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x73A8BE0", Offset = "0x73A7FE0", VA = "0x1873A8BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private KIHJNPJNIPL KHPCIDGGNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private TaskCompletionSource<bool> DNFOCBGOMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private TaskCompletionSource<bool> AJCNMDPMLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private Task EDBFHKGJEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Task BGGBGOCANKH;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private HKNCEKAFBLB BCFJPNINOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x73AA9A0", Offset = "0x73A9DA0", VA = "0x1873AA9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GKIPHIOFEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x73AB250", Offset = "0x73AA650", VA = "0x1873AB250", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool NDCPECEIGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x73AB2D0", Offset = "0x73AA6D0", VA = "0x1873AB2D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Task BOFBMBDNPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x73AA900", Offset = "0x73A9D00", VA = "0x1873AA900", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task MOMAMBGMIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x73AA2E0", Offset = "0x73A96E0", VA = "0x1873AA2E0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string ELLFGOFFOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x73AAC50", Offset = "0x73AA050", VA = "0x1873AAC50", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public FJHCPKEHMAL FHEDKHONPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x73AA810", Offset = "0x73A9C10", VA = "0x1873AA810", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action BMCOCMHBOND
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x73AAD90", Offset = "0x73AA190", VA = "0x1873AAD90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x73AB000", Offset = "0x73AA400", VA = "0x1873AB000", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action GBAHHMHGFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x73AB1B0", Offset = "0x73AA5B0", VA = "0x1873AB1B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x73AA1A0", Offset = "0x73A95A0", VA = "0x1873AA1A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action GNGHMJMIGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x73AA100", Offset = "0x73A9500", VA = "0x1873AA100", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x73AA240", Offset = "0x73A9640", VA = "0x1873AA240", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<LBCAIBIOCBM> NINNIKKAGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x73AA4D0", Offset = "0x73A98D0", VA = "0x1873AA4D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x73AA850", Offset = "0x73A9C50", VA = "0x1873AA850", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x73AB2E0", Offset = "0x73AA6E0", VA = "0x1873AB2E0")]
	[UnityEngine.Scripting.Preserve]
	public ELJCJNKNCAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x73AB260", Offset = "0x73AA660", VA = "0x1873AB260")]
	[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
	internal static void OOLIJHLPGJB(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x73AA5C0", Offset = "0x73A99C0", VA = "0x1873AA5C0")]
	internal static void FEPPCJIIEMK(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x73AA4A0", Offset = "0x73A98A0", VA = "0x1873AA4A0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x73AB0A0", Offset = "0x73AA4A0", VA = "0x1873AB0A0", Slot = "12")]
	[AsyncStateMachine(typeof(KBBAPLJDGKM))]
	public Task OBBALIPJEND(string DNBLAAELGNE, [Optional] ACIOJCKHAEM IPLCJOBGMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x73AAE30", Offset = "0x73AA230", VA = "0x1873AAE30", Slot = "19")]
	public Task LNFLFDOPOCA(ACIOJCKHAEM IPLCJOBGMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x73AA380", Offset = "0x73A9780", VA = "0x1873AA380", Slot = "20")]
	public Task DJINPGFBNNJ(ACIOJCKHAEM IPLCJOBGMMJ, Dictionary<string, string> CFLEEONCIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x73AAC70", Offset = "0x73AA070", VA = "0x1873AAC70", Slot = "21")]
	public bool LKJMJOPJLGH(string CNAKCPGIHFF, bool GHFHPGEHMMF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x73AAB90", Offset = "0x73A9F90", VA = "0x1873AAB90", Slot = "22")]
	public EMHLKGNIAGM LEFFAENNKDG(string LNKOMPBEMNB, bool GHFHPGEHMMF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x73AAF40", Offset = "0x73AA340", VA = "0x1873AAF40", Slot = "23")]
	public HHBOFLHCMCF NDLFNCPMLPA(string FFJPKGHBPNC, bool GHFHPGEHMMF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x73AA630", Offset = "0x73A9A30", VA = "0x1873AA630", Slot = "24")]
	public Task GPHPKALMMCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x73AAA10", Offset = "0x73A9E10", VA = "0x1873AAA10")]
	private static void KOHMBOMGHEH(TaskCompletionSource<bool> BIBGJEOCDEP, Task GBHAOHJEDFC, Task MFIFEJKMIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x73AA740", Offset = "0x73A9B40", VA = "0x1873AA740")]
	[AsyncStateMachine(typeof(CDCNFIKGAKO))]
	private static void HNEOKEBMPPL(Task GELALODAJCE, TaskCompletionSource<bool> BIBGJEOCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xD61BC0", Offset = "0xD60FC0", VA = "0x180D61BC0")]
	[CompilerGenerated]
	private void PJKIKIOEAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xDAEA80", Offset = "0xDADE80", VA = "0x180DAEA80")]
	[CompilerGenerated]
	private void EDMNIIPDMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xBC22A0", Offset = "0xBC16A0", VA = "0x180BC22A0")]
	[CompilerGenerated]
	private void PGOLBLOMMHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x73AA580", Offset = "0x73A9980", VA = "0x1873AA580")]
	[CompilerGenerated]
	private void EJFPBHNPJIP(LBCAIBIOCBM NPJNBFDHKLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class CIKFNOBDEJE : HHBOFLHCMCF, FALOAKKFPMD
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate void ACKMJJIPEHG(LBCAIBIOCBM AFFIINHJOEF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly ACKMJJIPEHG PDHAFEINFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly CJKCKKKEDLH AACECGADEEL;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string EEBIHLMDJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xCF0390", Offset = "0xCEF790", VA = "0x180CF0390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x66952C0", Offset = "0x66946C0", VA = "0x1866952C0")]
	public CIKFNOBDEJE(CJKCKKKEDLH AEPPPPJLFAJ, [Optional] ACKMJJIPEHG LCHNMJAFNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3278900", Offset = "0x3277D00", VA = "0x183278900", Slot = "5")]
	public T FCPELJIOJPN<T>(string MCNLCGLNHHO, T CIKOELCEFFM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface MAICHDPCDCJ
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[UsedImplicitly]
public class DEDEEKNFHKN : MAICHDPCDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly IBMHJGPEDEI LABDKJHMOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly List<ICMJEECHKIB> DMFGJOOOHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly string ACOCHFJODEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly string GKBGLIGCNFH;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x73A9300", Offset = "0x73A8700", VA = "0x1873A9300")]
	[UsedImplicitly]
	[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
	internal static void GFLBPMFPPHA(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x73A9370", Offset = "0x73A8770", VA = "0x1873A9370")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DEDEEKNFHKN([PNFCCJKFMBH(null)][JetBrains.Annotations.NotNull] IBMHJGPEDEI LABDKJHMOIM, [PNFCCJKFMBH(null)][JetBrains.Annotations.NotNull] PAEIFDFOHPF AKLHLHCPAAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class IEMKPOMJIOC : HKNCEKAFBLB
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Task BOFBMBDNPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x73ACDE0", Offset = "0x73AC1E0", VA = "0x1873ACDE0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Task MOMAMBGMIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x73ACAD0", Offset = "0x73ABED0", VA = "0x1873ACAD0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GKIPHIOFEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NDCPECEIGPO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string ELLFGOFFOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public FJHCPKEHMAL FHEDKHONPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action BMCOCMHBOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x73ACF20", Offset = "0x73AC320", VA = "0x1873ACF20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x73AD0E0", Offset = "0x73AC4E0", VA = "0x1873AD0E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action GBAHHMHGFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x73AD210", Offset = "0x73AC610", VA = "0x1873AD210", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x73AC990", Offset = "0x73ABD90", VA = "0x1873AC990", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action GNGHMJMIGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x73AC8F0", Offset = "0x73ABCF0", VA = "0x1873AC8F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x73ACA30", Offset = "0x73ABE30", VA = "0x1873ACA30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<LBCAIBIOCBM> NINNIKKAGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x73ACBF0", Offset = "0x73ABFF0", VA = "0x1873ACBF0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x73ACD30", Offset = "0x73AC130", VA = "0x1873ACD30", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	[RecRoom.NoEngine.Common.Preserve]
	public IEMKPOMJIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x73AD180", Offset = "0x73AC580", VA = "0x1873AD180", Slot = "12")]
	public Task OBBALIPJEND(string DNBLAAELGNE, [Optional] ACIOJCKHAEM IPLCJOBGMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x73ACFC0", Offset = "0x73AC3C0", VA = "0x1873ACFC0", Slot = "19")]
	public Task LNFLFDOPOCA(ACIOJCKHAEM IPLCJOBGMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x73ACB60", Offset = "0x73ABF60", VA = "0x1873ACB60", Slot = "20")]
	public Task DJINPGFBNNJ(ACIOJCKHAEM IPLCJOBGMMJ, Dictionary<string, string> CFLEEONCIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "21")]
	public bool LKJMJOPJLGH(string CNAKCPGIHFF, bool GHFHPGEHMMF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x73ACE70", Offset = "0x73AC270", VA = "0x1873ACE70", Slot = "22")]
	public EMHLKGNIAGM LEFFAENNKDG(string LNKOMPBEMNB, bool GHFHPGEHMMF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x73AD050", Offset = "0x73AC450", VA = "0x1873AD050", Slot = "23")]
	public HHBOFLHCMCF NDLFNCPMLPA(string FFJPKGHBPNC, bool GHFHPGEHMMF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x73ACCA0", Offset = "0x73AC0A0", VA = "0x1873ACCA0", Slot = "24")]
	public Task GPHPKALMMCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class DCIFEKNMPLF : FJHCPKEHMAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly HODHGOOJIBH OFEHJAOCELL;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IReadOnlyDictionary<string, object> COOOMDFGABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xCE7740", Offset = "0xCE6B40", VA = "0x180CE7740", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public DCIFEKNMPLF(HODHGOOJIBH GDCMKGGMDLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GOGICNJNDND
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AANDLEHKKAP NEACBOLFKNP(string CPOHAGKCFGG);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface PHBCPCHNMPE
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum BDNHECOMFGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	long DNOJKFACNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string ENLOODGDALC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string AOGLJBPOOAA
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool MAMJGCEKFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long ALCHCJDODON();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FJNHPBMHBDG(long AKOHGADPNOK, bool JLMDHMFNMGC = true);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DJBBAOFNGLE(string MEBLJIBNLCL, string MGBDMDPNBHD, string NLIOOFNJPJI);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KLKHBNMMFII(string MEBLJIBNLCL);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EINEBBOGNLP(string MEBLJIBNLCL, string AJMNEIPHGML, string LGJGMBKPFIP);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PDFJGHPOPNN(string HKOIFLLCMEG, object GKNLGJPDFPB, object ANJKIPFPIJF);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JNFJHOIHGNP(BDNHECOMFGH NNOMHKCBFGK, int PNOHIDJABCO, [Optional] KPNELCCOEKI FOFIGKNLJKD, [Optional] string JMBKCGKEGJC, [Optional] string JPAKKPAOGDF);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HFMAGMONHNM(KPNELCCOEKI FOFIGKNLJKD, long PEELNLDNAMO, long HKNNCLNPECE, int FCCAKOCMOBC, string JMBKCGKEGJC, int PNOHIDJABCO);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GIELHAEBOMN(KPNELCCOEKI FOFIGKNLJKD, bool LAKNLJKLEMJ, [Optional] string JPAKKPAOGDF);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MLKOGMEDDPP(KPNELCCOEKI FOFIGKNLJKD, bool LAKNLJKLEMJ, [Optional] string JPAKKPAOGDF);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ELJOELFHNPJ(KPNELCCOEKI FOFIGKNLJKD, bool LAKNLJKLEMJ, [Optional] string JPAKKPAOGDF);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GJAEKAHGBAP(long LFNEDMLHPHM, string IOFFIGBPEOL);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface GLJNFLMPPNM
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string DEIMFHALLNG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
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
