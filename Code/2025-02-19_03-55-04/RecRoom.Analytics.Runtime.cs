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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72BE150", Offset = "0x72BCD50", VA = "0x1872BE150")]
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
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
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
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72BB910", Offset = "0x72BA510", VA = "0x1872BB910", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72C19F0", Offset = "0x72C05F0", VA = "0x1872C19F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
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
		public AmplitudeAnalyticsClient.Settings MAABGBELOBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool CKLIKABDCEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x95D150", Offset = "0x95BD50", VA = "0x18095D150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, PMHAEKLGAHN
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum MGPFBCDEGIN
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class LNFLLKFJANF
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class MFFCOOOAAKD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int ENIHIFMAEHJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> DCDAHJFJNCO;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
				public MFFCOOOAAKD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class KLMFGNBBFIH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
				public KLMFGNBBFIH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x72B9080", Offset = "0x72B7C80", VA = "0x1872B9080")]
				internal bool MIAJOKPCEMN(MFFCOOOAAKD item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string GJPFMIKLLIK = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string ICLCPILCBMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<MFFCOOOAAKD> DOJJEFJPKGH;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? IMDMLBPENLI
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x72BA900", Offset = "0x72B9500", VA = "0x1872BA900")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x72BB7A0", Offset = "0x72BA3A0", VA = "0x1872BB7A0")]
			internal LNFLLKFJANF(string DPPNDGMPNGO, string EPBGOMEOIIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x72BAD60", Offset = "0x72B9960", VA = "0x1872BAD60")]
			public int LGNIGHIMAHF([Optional] int? OHFAGPHCLNP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x72BB530", Offset = "0x72BA130", VA = "0x1872BB530")]
			public List<Dictionary<string, object>> PAMPHLDEIDF(int AGDBFLOOBHD, int? OHFAGPHCLNP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x72BA750", Offset = "0x72B9350", VA = "0x1872BA750")]
			public void BHFJALGFGAE(AmplitudeAnalyticsIdentifyMessage CFMCKCBBBKK, bool ADAFFCKAAJG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x72BA7F0", Offset = "0x72B93F0", VA = "0x1872BA7F0")]
			public void BHFJALGFGAE(Dictionary<string, object> CFMCKCBBBKK, bool ADAFFCKAAJG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x72BA9A0", Offset = "0x72B95A0", VA = "0x1872BA9A0")]
			public void KBJIHFOFCPO(params Dictionary<string, object>[] OEMBCKOOPPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x72BAB20", Offset = "0x72B9720", VA = "0x1872BAB20")]
			public void LBIMOHGOMBK(List<Dictionary<string, object>> KOHGOGAKPID)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x72BB310", Offset = "0x72B9F10", VA = "0x1872BB310")]
			private void NDGIMLBPJEB(Dictionary<string, object> CFMCKCBBBKK, bool ADAFFCKAAJG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x72BA550", Offset = "0x72B9150", VA = "0x1872BA550")]
			public void AEKALMNCOPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x72BAF10", Offset = "0x72B9B10", VA = "0x1872BAF10")]
			private void MGDNLKNBDMN([Optional] string EJGBLJJEFMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x72BB410", Offset = "0x72BA010", VA = "0x1872BB410")]
			private static string OGFHKJMPEEP(string MPDLOLIOGJL, string NKANGPLHEGE)
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
			[Cpp2IlInjected.Address(RVA = "0x72C1610", Offset = "0x72C0210", VA = "0x1872C1610")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct KMBIEGNOOLN<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int IADKPANPOOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string NOAKLIGIIJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T BKENIDNEDLL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class OHBNFAHALCN : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private LNKBBFODFEI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public OHBNFAHALCN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x72BE1D0", Offset = "0x72BCDD0", VA = "0x1872BE1D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x72BE960", Offset = "0x72BD560", VA = "0x1872BE960", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class DJFKCJLEDMN : IEnumerator<object>, IEnumerator, IDisposable
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
			public CPONDHIMEMO quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public DJFKCJLEDMN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x72B6AD0", Offset = "0x72B56D0", VA = "0x1872B6AD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x72B6BE0", Offset = "0x72B57E0", VA = "0x1872B6BE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JFFOENKMOOO : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public JFFOENKMOOO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x72B7780", Offset = "0x72B6380", VA = "0x1872B7780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x72B78F0", Offset = "0x72B64F0", VA = "0x1872B78F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class HKMEELOHHDG : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private LNKBBFODFEI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public HKMEELOHHDG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x72B74D0", Offset = "0x72B60D0", VA = "0x1872B74D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x72B7730", Offset = "0x72B6330", VA = "0x1872B7730", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class PEDBLGMJEMI : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private LNKBBFODFEI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public PEDBLGMJEMI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x72BE9B0", Offset = "0x72BD5B0", VA = "0x1872BE9B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x72BEC00", Offset = "0x72BD800", VA = "0x1872BEC00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class KKEILFNCCBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public LNFLLKFJANF cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public KKEILFNCCBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x72B8D60", Offset = "0x72B7960", VA = "0x1872B8D60")]
			internal void PJGMFFONOLD(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x72B8910", Offset = "0x72B7510", VA = "0x1872B8910")]
			internal void OMKNCEPNOGN(KMBIEGNOOLN<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class ACDJGJNAIOA : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private LNKBBFODFEI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public LNFLLKFJANF cache;

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
			private KKEILFNCCBO <>8__1;

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
			private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public ACDJGJNAIOA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x72AE390", Offset = "0x72ACF90", VA = "0x1872AE390", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x72AEBA0", Offset = "0x72AD7A0", VA = "0x1872AEBA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class FLCGLCHMBLD<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public FLCGLCHMBLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4414070", Offset = "0x4412C70", VA = "0x184414070")]
			internal KMBIEGNOOLN<T> IFFHECLMLLB(GAENLACMGKH postResponse)
			{
				return default(KMBIEGNOOLN<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private LPPPCMBMLLD BDJHAOHMJLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<CKDJDDJMBLN> MNJMNDHFDOH;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string KHLLOCABCPG = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string BFGJBBJPLBL = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string ELBICBAFJKA = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int CFGLAEEGOPP = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int GBACKMKHIGO = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int CMOENIODLNO = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float MCOHABKLEDM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long BPBIMFONAKI = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string MCHJDJFENKL = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string PBEBGGDMODP = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string PIKPMJMKFJP = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string KNFMLHFIEKI = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool MNCEFEPALIM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool PMEELEJBLJH;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int MGNIENOABIA;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int OEAKPGGHIEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private JIEPJEEDEJI ENKLAOEEHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private FOPCJJNIGDB DGPJDPEPNAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private BJLGAMNMGNO GLOGAFIJIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool NGJDNOIKLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float LMJHPIFFPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float CKOPGKAFGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int INFJHMIBKFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int ONPGCOJJPPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? FPIJKPGPFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? EIGHJONJLPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long KEAMBFHOGBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string MGOAELOIJCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string GLBGIHGKNIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long AKGPKBCAJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string GLNHFEPPECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string COBKBGEECOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> GPMNFBGBECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private MGPFBCDEGIN CEOGFBACNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int CIPBKIODAAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int NGBKKBPMAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float LDKJCCKKMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool CCBEALOGMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool KLNPKFALDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private LNFLLKFJANF IEMMDLIODGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private LNFLLKFJANF BHAGJOAPKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private LNFLLKFJANF BBOHPLIEKNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string FLFEJJINBBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> CFAMFHJFPPN;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo BFLKIOHHCCE;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string IDGKOFGLHIB;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string ACGNCKBFKHI = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string GLEBGDFFNFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string EHAFOIPOGCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string MNEIMPJILDM;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LPPPCMBMLLD BPKACLOMMEM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x72AFEB0", Offset = "0x72AEAB0", VA = "0x1872AFEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private CKDJDDJMBLN HCHPGEKPGPF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x72AFD80", Offset = "0x72AE980", VA = "0x1872AFD80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int ACFNOKAEKGM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x72B0980", Offset = "0x72AF580", VA = "0x1872B0980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long HLNNAGBOJAH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x72B4ED0", Offset = "0x72B3AD0", VA = "0x1872B4ED0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x72B4FE0", Offset = "0x72B3BE0", VA = "0x1872B4FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string OIEIENEFCCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x72B4EA0", Offset = "0x72B3AA0", VA = "0x1872B4EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OHHMMIABLJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1232580", Offset = "0x1231180", VA = "0x181232580", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x12312E0", Offset = "0x122FEE0", VA = "0x1812312E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OHJAPKODNJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA42890", Offset = "0xA41490", VA = "0x180A42890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA48950", Offset = "0xA47550", VA = "0x180A48950")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? KCNEGJPHFEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA428A0", Offset = "0xA414A0", VA = "0x180A428A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA488E0", Offset = "0xA474E0", VA = "0x180A488E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NELNDJCCJKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xC78950", Offset = "0xC77550", VA = "0x180C78950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x112F830", Offset = "0x112E430", VA = "0x18112F830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool KLHKKCJEAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x72B4D70", Offset = "0x72B3970", VA = "0x1872B4D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> BFBEHFCCEFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x72B4CB0", Offset = "0x72B38B0", VA = "0x1872B4CB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x72B4F20", Offset = "0x72B3B20", VA = "0x1872B4F20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72AF240", Offset = "0x72ADE40", VA = "0x1872AF240", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72B0CF0", Offset = "0x72AF8F0", VA = "0x1872B0CF0")]
		private void ICKPLOKIAHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x72B42F0", Offset = "0x72B2EF0", VA = "0x1872B42F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72B2F90", Offset = "0x72B1B90", VA = "0x1872B2F90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72B4620", Offset = "0x72B3220", VA = "0x1872B4620")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72B3040", Offset = "0x72B1C40", VA = "0x1872B3040")]
		public HAGJNGKFIOK PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72B15B0", Offset = "0x72B01B0", VA = "0x1872B15B0")]
		[IteratorStateMachine(typeof(OHBNFAHALCN))]
		public IEnumerator<LNKBBFODFEI> InitializeForLocalAccount(AmplitudeAnalyticsEvent EIAIBBKFOHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72B39C0", Offset = "0x72B25C0", VA = "0x1872B39C0")]
		public void SendAppEnterEvent(bool PFBGLFEFPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72B45A0", Offset = "0x72B31A0", VA = "0x1872B45A0")]
		public void UpdateLastKnownInteractionCategory(string HCOFGILINCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x72B44F0", Offset = "0x72B30F0", VA = "0x1872B44F0")]
		public void UpdateLastAliveTime(float BLINLOHDAAB = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72B08D0", Offset = "0x72AF4D0", VA = "0x1872B08D0")]
		private HAGJNGKFIOK HEECBDKABDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72B16D0", Offset = "0x72B02D0", VA = "0x1872B16D0")]
		private HAGJNGKFIOK LBHIPGIFJDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x72B3CD0", Offset = "0x72B28D0", VA = "0x1872B3CD0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x72B1640", Offset = "0x72B0240", VA = "0x1872B1640")]
		[IteratorStateMachine(typeof(DJFKCJLEDMN))]
		private IEnumerator JFKHHLIFAMO(CPONDHIMEMO PKLIGBGLCDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x72B48B0", Offset = "0x72B34B0", VA = "0x1872B48B0")]
		[IteratorStateMachine(typeof(JFFOENKMOOO))]
		public IEnumerator WaitForFlush(float IOGIGKLDIAN = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x72B43D0", Offset = "0x72B2FD0", VA = "0x1872B43D0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72B4310", Offset = "0x72B2F10", VA = "0x1872B4310")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime MKKLKGKOEPB)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72B10B0", Offset = "0x72AFCB0", VA = "0x1872B10B0")]
		public static EJEOMFFICMD Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x72AF090", Offset = "0x72ADC90", VA = "0x1872AF090")]
		public static JOCLJIGCILJ AccountSelectionPostLoginEvent([NotNull] string BMLHJFEDFKN, string HLKMIHCGHAM, MBNMLPDIBLL BJAHCGDLFGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x72AFF40", Offset = "0x72AEB40", VA = "0x1872AFF40")]
		public static JOCLJIGCILJ Event([NotNull] string BMLHJFEDFKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x72B31D0", Offset = "0x72B1DD0", VA = "0x1872B31D0")]
		public static JOCLJIGCILJ PreviousSessionEvent([NotNull] string BMLHJFEDFKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x72B1250", Offset = "0x72AFE50", VA = "0x1872B1250")]
		public static JOCLJIGCILJ InitializeEvent(string HLKMIHCGHAM, int IDLEIPHJFCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72B3ED0", Offset = "0x72B2AD0", VA = "0x1872B3ED0")]
		public static JOCLJIGCILJ StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x72AFAC0", Offset = "0x72AE6C0", VA = "0x1872AFAC0")]
		public static JOCLJIGCILJ CreateOutOfSessionEvent(string BMLHJFEDFKN, bool MDLICJDHHAO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72B1B90", Offset = "0x72B0790", VA = "0x1872B1B90")]
		public static HAGJNGKFIOK LogOutOfSessionEvent(JOCLJIGCILJ GOGPEAMBPNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x72B1930", Offset = "0x72B0530", VA = "0x1872B1930")]
		public void LogEventAsync(AmplitudeAnalyticsEvent IBIFJKCBEPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72B1D60", Offset = "0x72B0960", VA = "0x1872B1D60")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent IBIFJKCBEPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72B1E90", Offset = "0x72B0A90", VA = "0x1872B1E90")]
		public void LogSerializedEventAsync(Dictionary<string, object> AMIIPDPFDMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72B1A60", Offset = "0x72B0660", VA = "0x1872B1A60")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage DDPDHJPHGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72AF9C0", Offset = "0x72AE5C0", VA = "0x1872AF9C0")]
		private void CFCCLECACNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72B1F70", Offset = "0x72B0B70", VA = "0x1872B1F70")]
		private void NIFLDBKALNG(Dictionary<string, object> LPPMMOCPCCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72B1840", Offset = "0x72B0440", VA = "0x1872B1840")]
		private void LHCDAKIBOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x72B0620", Offset = "0x72AF220", VA = "0x1872B0620")]
		private void GCDGPMBMIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72B0590", Offset = "0x72AF190", VA = "0x1872B0590")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x72B07F0", Offset = "0x72AF3F0", VA = "0x1872B07F0")]
		[IteratorStateMachine(typeof(HKMEELOHHDG))]
		private IEnumerator<LNKBBFODFEI> GFCGOHBNIMB(float IOGIGKLDIAN = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x72AF000", Offset = "0x72ADC00", VA = "0x1872AF000")]
		[IteratorStateMachine(typeof(PEDBLGMJEMI))]
		private IEnumerator<LNKBBFODFEI> ADEGBMAKJGB(float IOGIGKLDIAN = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x72AFDD0", Offset = "0x72AE9D0", VA = "0x1872AFDD0")]
		[IteratorStateMachine(typeof(ACDJGJNAIOA))]
		private IEnumerator<LNKBBFODFEI> DMKGJEKOGMD(LNFLLKFJANF POACKIHOABP, int? OHFAGPHCLNP, string EFFILNMJCAH, float IOGIGKLDIAN, Action<int> DPOPHCPHPIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x72AF8A0", Offset = "0x72AE4A0", VA = "0x1872AF8A0")]
		private static void BBABKBMKKPF(bool CDBNFKPMPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72B04C0", Offset = "0x72AF0C0", VA = "0x1872B04C0")]
		private JOIICJDLMNO<KMBIEGNOOLN<Dictionary<string, object>>> FKBGOKDLIHM(string EFFILNMJCAH, string JFEPLFPJKNO, Dictionary<string, object> BKENIDNEDLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x72B0250", Offset = "0x72AEE50", VA = "0x1872B0250")]
		private JOIICJDLMNO<KMBIEGNOOLN<List<Dictionary<string, object>>>> FKBGOKDLIHM(string EFFILNMJCAH, string JFEPLFPJKNO, List<Dictionary<string, object>> BKENIDNEDLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBE20", Offset = "0x3AFAA20", VA = "0x183AFBE20")]
		private JOIICJDLMNO<KMBIEGNOOLN<T>> GIMMPFGMCEO<T>(string DNNIGDLHAIF, string EFFILNMJCAH, string JFEPLFPJKNO, T BKENIDNEDLL, Dictionary<string, object> ICLMCLHPINK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x72B0880", Offset = "0x72AF480", VA = "0x1872B0880")]
		private bool GFKFNNPOAPJ(float EICIOFHBACJ, float IOGIGKLDIAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x72B2230", Offset = "0x72B0E30", VA = "0x1872B2230")]
		private Dictionary<string, object> OJILCLGGNKE(string EFFILNMJCAH, Dictionary<string, object> BKENIDNEDLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x72B49A0", Offset = "0x72B35A0", VA = "0x1872B49A0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x985A00", Offset = "0x984600", VA = "0x180985A00", Slot = "6")]
		private bool DGIDCMLKFAK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x72B0B80", Offset = "0x72AF780", VA = "0x1872B0B80")]
		[CompilerGenerated]
		private long HOLBPGICNEO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x72AF9B0", Offset = "0x72AE5B0", VA = "0x1872AF9B0")]
		[CompilerGenerated]
		private void CAFPINMJFFP(int FPBAOPBLMOA)
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
			[Cpp2IlInjected.Address(RVA = "0x72B5CD0", Offset = "0x72B48D0", VA = "0x1872B5CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x72B5DA0", Offset = "0x72B49A0", VA = "0x1872B5DA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x72B5D10", Offset = "0x72B4910", VA = "0x1872B5D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x72B5DF0", Offset = "0x72B49F0", VA = "0x1872B5DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x72B5C90", Offset = "0x72B4890", VA = "0x1872B5C90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x72B5D50", Offset = "0x72B4950", VA = "0x1872B5D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x961620", Offset = "0x960220", VA = "0x180961620")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72B51C0", Offset = "0x72B3DC0", VA = "0x1872B51C0")]
		public static JOCLJIGCILJ EPPBBCFCJMI(string HBIBCNEICNM, [NotNull] string BBNMPEGFDHI, long PKLHPLNMANJ, long GBGIMLJNELK, string HLKMIHCGHAM, string BJAHCGDLFGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x72B5990", Offset = "0x72B4590", VA = "0x1872B5990")]
		public static JOCLJIGCILJ NMJOPEFNHHD(string HBIBCNEICNM, [NotNull] string BBNMPEGFDHI, long PKLHPLNMANJ, long GBGIMLJNELK, string HLKMIHCGHAM, long CGKMNPMIPMK, string EIAHPEJIMFG, string FKCKGLLLNPM, string MMDMDMJMNBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72B5AF0", Offset = "0x72B46F0", VA = "0x1872B5AF0")]
		private AmplitudeAnalyticsEvent(string HBIBCNEICNM, [NotNull] string BBNMPEGFDHI, long PKLHPLNMANJ, long GBGIMLJNELK, string HLKMIHCGHAM, string BJAHCGDLFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCF2CE0", Offset = "0xCF18E0", VA = "0x180CF2CE0")]
		public void BHKPGLANJDC(long FBMIOOKMPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x72B52C0", Offset = "0x72B3EC0", VA = "0x1872B52C0", Slot = "5")]
		public override void JMDDHFMACCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x72B5040", Offset = "0x72B3C40", VA = "0x1872B5040", Slot = "6")]
		public override void BNOPHIDIEBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x72B53C0", Offset = "0x72B3FC0", VA = "0x1872B53C0", Slot = "4")]
		protected override Dictionary<string, object> LFJFIAHEAMN(Dictionary<string, object> HGKLAIEFAOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x72B5880", Offset = "0x72B4480", VA = "0x1872B5880")]
		private void NHAGCPGCGNI(string NKANGPLHEGE, string MPDLOLIOGJL, bool EPNLCICIDJA = false)
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
			[Cpp2IlInjected.Address(RVA = "0x72B6C30", Offset = "0x72B5830", VA = "0x1872B6C30")]
			public void LKMHLCBGBEE(Dictionary<string, object> JJBAIBMHFEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
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
			[Cpp2IlInjected.Address(RVA = "0x72C1290", Offset = "0x72BFE90", VA = "0x1872C1290")]
			public void LKMHLCBGBEE(Dictionary<string, object> LLEKBPKDIDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x10D4E70", Offset = "0x10D3A70", VA = "0x1810D4E70")]
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
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x72B5EC0", Offset = "0x72B4AC0", VA = "0x1872B5EC0")]
		public static EJEOMFFICMD EPPBBCFCJMI(string HBIBCNEICNM, string HLKMIHCGHAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x72B64F0", Offset = "0x72B50F0", VA = "0x1872B64F0")]
		protected AmplitudeAnalyticsIdentifyMessage(string HBIBCNEICNM, string HLKMIHCGHAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x72B6460", Offset = "0x72B5060", VA = "0x1872B6460")]
		public Dictionary<string, object> MLMOBKCIELM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x72B6120", Offset = "0x72B4D20", VA = "0x1872B6120", Slot = "4")]
		protected virtual Dictionary<string, object> LFJFIAHEAMN(Dictionary<string, object> HGKLAIEFAOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x72B5FF0", Offset = "0x72B4BF0", VA = "0x1872B5FF0")]
		protected void HEGECKFNDOE(string NKANGPLHEGE, Dictionary<string, object> CKCKGEIFHDI, Dictionary<string, object> CENHNJMDECP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x72B5F80", Offset = "0x72B4B80", VA = "0x1872B5F80")]
		protected void GFDHELMCJBO(string NKANGPLHEGE, string MPDLOLIOGJL, Dictionary<string, object> BOAMAIEJHEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x72B6090", Offset = "0x72B4C90", VA = "0x1872B6090", Slot = "5")]
		public virtual void JMDDHFMACCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x72B5E40", Offset = "0x72B4A40", VA = "0x1872B5E40", Slot = "6")]
		public virtual void BNOPHIDIEBO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EJEOMFFICMD : MLBEHBCKEEH<AmplitudeAnalyticsIdentifyMessage, EJEOMFFICMD>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override EJEOMFFICMD ODHMCHEKOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage CKGLHBNNAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x72B6F30", Offset = "0x72B5B30", VA = "0x1872B6F30")]
	public EJEOMFFICMD(AmplitudeAnalyticsIdentifyMessage KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x72B6E90", Offset = "0x72B5A90", VA = "0x1872B6E90", Slot = "4")]
	public override void BNOPHIDIEBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JOCLJIGCILJ : MLBEHBCKEEH<AmplitudeAnalyticsEvent, JOCLJIGCILJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool DNLBECEHBKP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override JOCLJIGCILJ ODHMCHEKOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long DHLKBLHKLDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x72B8390", Offset = "0x72B6F90", VA = "0x1872B8390")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x72B80B0", Offset = "0x72B6CB0", VA = "0x1872B80B0")]
	public JOCLJIGCILJ(AmplitudeAnalyticsEvent KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "5")]
	public override AmplitudeAnalyticsEvent CKGLHBNNAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x72B81F0", Offset = "0x72B6DF0", VA = "0x1872B81F0", Slot = "4")]
	public override void BNOPHIDIEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x340E4E0", Offset = "0x340D0E0", VA = "0x18340E4E0")]
	public JOCLJIGCILJ ACKKPEFKBEB<T>(string JENIGBAOHNC, T[] MPDLOLIOGJL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x340E4E0", Offset = "0x340D0E0", VA = "0x18340E4E0")]
	public JOCLJIGCILJ ACKKPEFKBEB(string JENIGBAOHNC, string[] MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x340E230", Offset = "0x340CE30", VA = "0x18340E230")]
	public JOCLJIGCILJ ACKKPEFKBEB<T>(string JENIGBAOHNC, T MPDLOLIOGJL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x72B8100", Offset = "0x72B6D00", VA = "0x1872B8100")]
	public JOCLJIGCILJ ACKKPEFKBEB(string JENIGBAOHNC, long MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x72B8180", Offset = "0x72B6D80", VA = "0x1872B8180")]
	public JOCLJIGCILJ ACKKPEFKBEB(string JENIGBAOHNC, string MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x72B8450", Offset = "0x72B7050", VA = "0x1872B8450")]
	public JOCLJIGCILJ JPBNPMMCIED(string JENIGBAOHNC, object? MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x72B83B0", Offset = "0x72B6FB0", VA = "0x1872B83B0")]
	public JOCLJIGCILJ IFEPHLKPCFI(string JENIGBAOHNC, string MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x72B8290", Offset = "0x72B6E90", VA = "0x1872B8290")]
	private JOCLJIGCILJ EJHPMDPGMKL(string JENIGBAOHNC, object MPDLOLIOGJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JNNJCFKKKCI : JOCLJIGCILJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x72B80B0", Offset = "0x72B6CB0", VA = "0x1872B80B0")]
	public JNNJCFKKKCI(AmplitudeAnalyticsEvent KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x72B7F00", Offset = "0x72B6B00", VA = "0x1872B7F00", Slot = "4")]
	public override void BNOPHIDIEBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class MLBEHBCKEEH<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : MLBEHBCKEEH<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M KBPDEFFIKOJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR ODHMCHEKOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public MLBEHBCKEEH(M KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4D83950", Offset = "0x4D82550", VA = "0x184D83950")]
	public BLDR JMHFBCDFJOE(AmplitudeAnalyticsIdentifyMessage.DeviceInfo KLEAPPEHINP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4D83AA0", Offset = "0x4D826A0", VA = "0x184D83AA0")]
	public BLDR PJOKIGADOLJ(AmplitudeAnalyticsIdentifyMessage.RevenueData GOAOOMBANCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4D83870", Offset = "0x4D82470", VA = "0x184D83870")]
	public BLDR GGLJBDFJFLD(string JENIGBAOHNC, string MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x33D8040", Offset = "0x33D6C40", VA = "0x1833D8040")]
	public BLDR GGLJBDFJFLD<T>(string JENIGBAOHNC, T MPDLOLIOGJL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BNOPHIDIEBO();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4D83920", Offset = "0x4D82520", VA = "0x184D83920")]
	internal static string HECCPLLJDGN(string MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D839A0", Offset = "0x4D825A0", VA = "0x184D839A0")]
	private BLDR LPMPIDNMMKH(string JENIGBAOHNC, object MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M CKGLHBNNAEF();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class FGFFDFNBDKP : JIEPJEEDEJI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct KPLMPDBCBEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<GAENLACMGKH> <>t__builder;

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
		public FGFFDFNBDKP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x72B90F0", Offset = "0x72B7CF0", VA = "0x1872B90F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x72B9B20", Offset = "0x72B8720", VA = "0x1872B9B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient CGGENJCLBOI;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x72B6F80", Offset = "0x72B5B80", VA = "0x1872B6F80")]
	[DMDJPIBKEJJ.OHIIEKNFAKB]
	internal static void JHMIDELHHNK(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x72B7160", Offset = "0x72B5D60", VA = "0x1872B7160")]
	[RecRoom.NoEngine.Common.Preserve]
	public FGFFDFNBDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x72B6FF0", Offset = "0x72B5BF0", VA = "0x1872B6FF0", Slot = "4")]
	[AsyncStateMachine(typeof(KPLMPDBCBEG))]
	public Task<GAENLACMGKH> MHHGMCAFMON(string DNNIGDLHAIF, string FLLKCNONKKL, string ILGCBOHNNPF, string PIONDJFEPHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class MEJFPHJLAHM : JIEPJEEDEJI
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class EEMHJHOGLIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<GAENLACMGKH> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public EEMHJHOGLIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x72B6DB0", Offset = "0x72B59B0", VA = "0x1872B6DB0")]
		internal void PIGDFCDEDAF(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct PFDIGKHBONK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<GAENLACMGKH> <>t__builder;

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
		private TaskAwaiter<GAENLACMGKH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x72BEC50", Offset = "0x72BD850", VA = "0x1872BEC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x72BF1A0", Offset = "0x72BDDA0", VA = "0x1872BF1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	[DMDJPIBKEJJ.OHIIEKNFAKB]
	internal static void IFFOCDDDCFB(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	[RecRoom.NoEngine.Common.Preserve]
	public MEJFPHJLAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x72BC370", Offset = "0x72BAF70", VA = "0x1872BC370", Slot = "4")]
	[AsyncStateMachine(typeof(PFDIGKHBONK))]
	public Task<GAENLACMGKH> MHHGMCAFMON(string DNNIGDLHAIF, string FLLKCNONKKL, string ILGCBOHNNPF, string PIONDJFEPHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JILFKECICFO
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> GEIIGNNNOFJ;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x72B7940", Offset = "0x72B6540", VA = "0x1872B7940")]
	internal static bool GNMAPBDOKLL(string NKANGPLHEGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface JIEPJEEDEJI
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GAENLACMGKH> MHHGMCAFMON(string DNNIGDLHAIF, string FLLKCNONKKL, string ILGCBOHNNPF, string PIONDJFEPHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct GAENLACMGKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int KPBFJCIAKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string BMKCMPPLCPL;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x142BCA0", Offset = "0x142A8A0", VA = "0x18142BCA0")]
	public GAENLACMGKH(int IADKPANPOOB, string NOAKLIGIIJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum LPOKPAFBNEC
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
public class BHPMHEFMCJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private long JPHCHGDFJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private JOCLJIGCILJ AEOOLJFIGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool LDJEOBFPGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float FNEKNMAENAD;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x72B6940", Offset = "0x72B5540", VA = "0x1872B6940")]
	public BHPMHEFMCJK(string ONCFOGPLDEH, float FNEKNMAENAD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3106D90", Offset = "0x3105990", VA = "0x183106D90")]
	public void ACKKPEFKBEB<T>(string JENIGBAOHNC, T MPDLOLIOGJL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x72B65B0", Offset = "0x72B51B0", VA = "0x1872B65B0")]
	public void ACKKPEFKBEB(string JENIGBAOHNC, string MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72B6740", Offset = "0x72B5340", VA = "0x1872B6740")]
	public void CHOGELOIAPA(string KAIGAIDNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72B6880", Offset = "0x72B5480", VA = "0x1872B6880")]
	public void JBFBAGNBBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x72B6630", Offset = "0x72B5230", VA = "0x1872B6630")]
	private void CBHKCOILNII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x72B6830", Offset = "0x72B5430", VA = "0x1872B6830")]
	private bool HGBKJDJLNIM()
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
		public enum LHHDIMJLKEK
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
		private LHHDIMJLKEK parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public LHHDIMJLKEK Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xA90E00", Offset = "0xA8FA00", VA = "0x180A90E00")]
			get
			{
				return default(LHHDIMJLKEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x986300", Offset = "0x984F00", VA = "0x180986300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x72C1400", Offset = "0x72C0000", VA = "0x1872C1400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal class GECHNBGFFFB : NOPIMODEOFI, EPGOFIPAFIN
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate void LABEMDFMGDK(CPLPELOEICE CFPDMPHHIOA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly NIBAKKEHFOO JNBFONBPDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly LABEMDFMGDK DNKCNABEFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string FLDHHDHPDFO;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string BPJEPHLNEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x18DE840", Offset = "0x18DD440", VA = "0x1818DE840", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool KGCFOBMOBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x72B7420", Offset = "0x72B6020", VA = "0x1872B7420", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool APIGDNKGCGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x72B7440", Offset = "0x72B6040", VA = "0x1872B7440", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> PGNGJBIECJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x18DE730", Offset = "0x18DD330", VA = "0x1818DE730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x72B7460", Offset = "0x72B6060", VA = "0x1872B7460")]
	public GECHNBGFFFB(NIBAKKEHFOO BKDMEACEJJF, string EMHHMFJHEMD, [Optional] LABEMDFMGDK HAGBEBHBLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3371E20", Offset = "0x3370A20", VA = "0x183371E20", Slot = "8")]
	public T IMOGIGFHIEP<T>(string NKANGPLHEGE, T NBKBMLNEBHK)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class PMMFCFOGMMF : CMLMNIGHOGD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct MAHLOAGPIFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public FOPCJJNIGDB userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public PMMFCFOGMMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x72BB9A0", Offset = "0x72BA5A0", VA = "0x1872BB9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x72BC310", Offset = "0x72BAF10", VA = "0x1872BC310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct ACIHGJACFDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x72AEBF0", Offset = "0x72AD7F0", VA = "0x1872AEBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x72AEDD0", Offset = "0x72AD9D0", VA = "0x1872AEDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JPLFKFNCDFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public FOPCJJNIGDB userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public PMMFCFOGMMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x72B8480", Offset = "0x72B7080", VA = "0x1872B8480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x72B88B0", Offset = "0x72B74B0", VA = "0x1872B88B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JMJGDEOIBDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public PMMFCFOGMMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public FOPCJJNIGDB userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x72B7AE0", Offset = "0x72B66E0", VA = "0x1872B7AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x72B7EA0", Offset = "0x72B6AA0", VA = "0x1872B7EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly IReadOnlyDictionary<string, GHCKLEJGPBB> GPBGGOPANIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool NKKLCNNNODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool MLIEMEOCMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private TaskCompletionSource<bool> PLPHAICPEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private TaskCompletionSource<bool> NFHFKCBOGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly SemaphoreSlim MABFNMPOKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private OCBOFKLAKOC COOFPEALIKN;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Task NCNADPIBEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x72C02B0", Offset = "0x72BEEB0", VA = "0x1872C02B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Task LAKBMJAADJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x72BFAD0", Offset = "0x72BE6D0", VA = "0x1872BFAD0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool OJEEMIIKCEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xB435D0", Offset = "0xB421D0", VA = "0x180B435D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool CJPCCCHIDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xB44370", Offset = "0xB42F70", VA = "0x180B44370", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string OHJAPKODNJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x72C0F30", Offset = "0x72BFB30", VA = "0x1872C0F30", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public AODFAKKBJPI INFOHMPFGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x72BF690", Offset = "0x72BE290", VA = "0x1872BF690", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HMGAEPPAILN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x72C0F40", Offset = "0x72BFB40", VA = "0x1872C0F40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x72BFE70", Offset = "0x72BEA70", VA = "0x1872BFE70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BAGOIPGGLLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x72C0D90", Offset = "0x72BF990", VA = "0x1872C0D90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x72BF5F0", Offset = "0x72BE1F0", VA = "0x1872BF5F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action FGJIMALCEMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x72BFDD0", Offset = "0x72BE9D0", VA = "0x1872BFDD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x72C0210", Offset = "0x72BEE10", VA = "0x1872C0210", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<CPLPELOEICE> LLHIIEFHKND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x72BF330", Offset = "0x72BDF30", VA = "0x1872BF330", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x72BF870", Offset = "0x72BE470", VA = "0x1872BF870", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x72BFB10", Offset = "0x72BE710", VA = "0x1872BFB10", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x72BF210", Offset = "0x72BDE10", VA = "0x1872BF210", Slot = "12")]
	[AsyncStateMachine(typeof(MAHLOAGPIFE))]
	public Task AIMKJDEKJHN(string EPBGOMEOIIC, [Optional] FOPCJJNIGDB DNAMHCLLGDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x72BFF10", Offset = "0x72BEB10", VA = "0x1872BFF10", Slot = "24")]
	[AsyncStateMachine(typeof(ACIHGJACFDC))]
	public Task GFLLHMGKKCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x72C0110", Offset = "0x72BED10", VA = "0x1872C0110", Slot = "19")]
	[AsyncStateMachine(typeof(JPLFKFNCDFM))]
	public Task HOCNHOLEBGG(FOPCJJNIGDB DNAMHCLLGDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x72BF7D0", Offset = "0x72BE3D0", VA = "0x1872BF7D0")]
	private void CBIJCAAFKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x72BF6C0", Offset = "0x72BE2C0", VA = "0x1872BF6C0", Slot = "20")]
	[AsyncStateMachine(typeof(JMJGDEOIBDE))]
	public Task BLKIMNJINHD(FOPCJJNIGDB DNAMHCLLGDP, Dictionary<string, string> KIDHDKDMIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x72BFB30", Offset = "0x72BE730", VA = "0x1872BFB30", Slot = "21")]
	public bool ELJBDLPBPEE(string HONLLHDODAH, bool MNIOKMLLEOE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x72C02F0", Offset = "0x72BEEF0", VA = "0x1872C02F0", Slot = "22")]
	public NOPIMODEOFI KNKOEFMFJNM(string EMHHMFJHEMD, bool MNIOKMLLEOE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x72BF3E0", Offset = "0x72BDFE0", VA = "0x1872BF3E0")]
	private NIBAKKEHFOO BBEGFDCEDEC(string EMHHMFJHEMD, bool MNIOKMLLEOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x72BFC20", Offset = "0x72BE820", VA = "0x1872BFC20", Slot = "23")]
	public AAEGMEBBJHJ FGCJDDBMDBL(string AHADFMEJIBA, bool MNIOKMLLEOE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x72C0E30", Offset = "0x72BFA30", VA = "0x1872C0E30")]
	private PBCGDDIOODE NLDKMMJDIFH(string AHADFMEJIBA, bool MNIOKMLLEOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x72C04B0", Offset = "0x72BF0B0", VA = "0x1872C04B0")]
	private ONAJELBADIN LMOHCGEEIKN(FOPCJJNIGDB DNAMHCLLGDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x72BF920", Offset = "0x72BE520", VA = "0x1872BF920")]
	private PEMMHNBLFNB DJEONCAKNDL(string EPBGOMEOIIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x72BFFC0", Offset = "0x72BEBC0", VA = "0x1872BFFC0")]
	private void GHGDLGBBDLI(string EMHHMFJHEMD, NIBAKKEHFOO BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x72C1190", Offset = "0x72BFD90", VA = "0x1872C1190")]
	public PMMFCFOGMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x72C00D0", Offset = "0x72BECD0", VA = "0x1872C00D0")]
	[CompilerGenerated]
	private void LPFADFMOOIE(CPLPELOEICE JLCBCLJGOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x72C00D0", Offset = "0x72BECD0", VA = "0x1872C00D0")]
	[CompilerGenerated]
	private void HEFLIOOEJIN(CPLPELOEICE JLCBCLJGOML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NLGDFBHIMMO : CMLMNIGHOGD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct NEHLEDJHMKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NLGDFBHIMMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public FOPCJJNIGDB userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x72BC4D0", Offset = "0x72BB0D0", VA = "0x1872BC4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x72BCE50", Offset = "0x72BBA50", VA = "0x1872BCE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct GCGMECJDJAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x72B71E0", Offset = "0x72B5DE0", VA = "0x1872B71E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private PMMFCFOGMMF BLPMENPNEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private TaskCompletionSource<bool> PLPHAICPEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private TaskCompletionSource<bool> NFHFKCBOGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Task KALBMLEHLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Task LPIIMKECJHH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private CMLMNIGHOGD BLANNJFJBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x72BDA60", Offset = "0x72BC660", VA = "0x1872BDA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool CJPCCCHIDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x72BD290", Offset = "0x72BBE90", VA = "0x1872BD290", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool OJEEMIIKCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x72BDC80", Offset = "0x72BC880", VA = "0x1872BDC80", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Task NCNADPIBEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x72BDC90", Offset = "0x72BC890", VA = "0x1872BDC90", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Task LAKBMJAADJI
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x72BD520", Offset = "0x72BC120", VA = "0x1872BD520", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string OHJAPKODNJD
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x72BDF60", Offset = "0x72BCB60", VA = "0x1872BDF60", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public AODFAKKBJPI INFOHMPFGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x72BD2A0", Offset = "0x72BBEA0", VA = "0x1872BD2A0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action BAGOIPGGLLK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x72BDDF0", Offset = "0x72BC9F0", VA = "0x1872BDDF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x72BD1F0", Offset = "0x72BBDF0", VA = "0x1872BD1F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action HMGAEPPAILN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x72BDF80", Offset = "0x72BCB80", VA = "0x1872BDF80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x72BD870", Offset = "0x72BC470", VA = "0x1872BD870", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action FGJIMALCEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x72BD7D0", Offset = "0x72BC3D0", VA = "0x1872BD7D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x72BDBE0", Offset = "0x72BC7E0", VA = "0x1872BDBE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<CPLPELOEICE> LLHIIEFHKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x72BD140", Offset = "0x72BBD40", VA = "0x1872BD140", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x72BD470", Offset = "0x72BC070", VA = "0x1872BD470", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x72BE090", Offset = "0x72BCC90", VA = "0x1872BE090")]
	[UnityEngine.Scripting.Preserve]
	public NLGDFBHIMMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x72BE020", Offset = "0x72BCC20", VA = "0x1872BE020")]
	[DMDJPIBKEJJ.OHIIEKNFAKB.OKGKMEFLHLK]
	internal static void OPGDNJLIDJN(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72BD400", Offset = "0x72BC000", VA = "0x1872BD400")]
	internal static void DCIKIPMFFEE(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x72BD5C0", Offset = "0x72BC1C0", VA = "0x1872BD5C0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x72BD030", Offset = "0x72BBC30", VA = "0x1872BD030", Slot = "12")]
	[AsyncStateMachine(typeof(NEHLEDJHMKJ))]
	public Task AIMKJDEKJHN(string EPBGOMEOIIC, [Optional] FOPCJJNIGDB DNAMHCLLGDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x72BDAD0", Offset = "0x72BC6D0", VA = "0x1872BDAD0", Slot = "19")]
	public Task HOCNHOLEBGG(FOPCJJNIGDB DNAMHCLLGDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x72BD2E0", Offset = "0x72BBEE0", VA = "0x1872BD2E0", Slot = "20")]
	public Task BLKIMNJINHD(FOPCJJNIGDB DNAMHCLLGDP, Dictionary<string, string> KIDHDKDMIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x72BD5F0", Offset = "0x72BC1F0", VA = "0x1872BD5F0", Slot = "21")]
	public bool ELJBDLPBPEE(string HONLLHDODAH, bool MNIOKMLLEOE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x72BDD30", Offset = "0x72BC930", VA = "0x1872BDD30", Slot = "22")]
	public NOPIMODEOFI KNKOEFMFJNM(string EMHHMFJHEMD, bool MNIOKMLLEOE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x72BD710", Offset = "0x72BC310", VA = "0x1872BD710", Slot = "23")]
	public AAEGMEBBJHJ FGCJDDBMDBL(string AHADFMEJIBA, bool MNIOKMLLEOE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x72BD910", Offset = "0x72BC510", VA = "0x1872BD910", Slot = "24")]
	public Task GFLLHMGKKCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x72BCEB0", Offset = "0x72BBAB0", VA = "0x1872BCEB0")]
	private static void AGBLCFGOJLB(TaskCompletionSource<bool> IDGIFCDJBBC, Task IFMFJFBIFIC, Task CFJEFAPJJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x72BDE90", Offset = "0x72BCA90", VA = "0x1872BDE90")]
	[AsyncStateMachine(typeof(GCGMECJDJAE))]
	private static void NELAFIOPMPP(Task LFJIOJDNNEN, TaskCompletionSource<bool> IDGIFCDJBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xCED060", Offset = "0xCEBC60", VA = "0x180CED060")]
	[CompilerGenerated]
	private void EPFIEAACBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0xD3F040", Offset = "0xD3DC40", VA = "0x180D3F040")]
	[CompilerGenerated]
	private void BINHHLNEPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0xB6B980", Offset = "0xB6A580", VA = "0x180B6B980")]
	[CompilerGenerated]
	private void HEEEAPGLAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x72BDA20", Offset = "0x72BC620", VA = "0x1872BDA20")]
	[CompilerGenerated]
	private void HBGKAAFMDNA(CPLPELOEICE JLCBCLJGOML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal class EMBHAJMEDPG : AAEGMEBBJHJ, EPGOFIPAFIN
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void HNDIHOCHEPK(CPLPELOEICE CFPDMPHHIOA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly HNDIHOCHEPK DNKCNABEFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly PBCGDDIOODE PMMOONEOBEH;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string BPJEPHLNEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xC7C2B0", Offset = "0xC7AEB0", VA = "0x180C7C2B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0xD8DDF0", Offset = "0xD8C9F0", VA = "0x180D8DDF0")]
	public EMBHAJMEDPG(PBCGDDIOODE ONGOOIJKOLB, [Optional] HNDIHOCHEPK HAGBEBHBLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x31F8F70", Offset = "0x31F7B70", VA = "0x1831F8F70", Slot = "5")]
	public T IMOGIGFHIEP<T>(string NKANGPLHEGE, T NBKBMLNEBHK)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface ICBMDFDGFEK
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[UsedImplicitly]
public class AJMCHFJOCEH : ICBMDFDGFEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly LHOPCMODPMB ACAAOPKFLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly List<LJHMLHCAEBK> EOLIEJEEIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly string DINIJACLPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly string FABHILBKBJC;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x72AEE30", Offset = "0x72ADA30", VA = "0x1872AEE30")]
	[DMDJPIBKEJJ.OHIIEKNFAKB.OKGKMEFLHLK]
	[UsedImplicitly]
	internal static void EKJPAICHAMI(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x72AEEA0", Offset = "0x72ADAA0", VA = "0x1872AEEA0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal AJMCHFJOCEH([NotNull][GJMNBPKNJPO(null)] LHOPCMODPMB ACAAOPKFLBE, [NotNull][GJMNBPKNJPO(null)] AIFCEBHCJFA OOHHEEANOKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class LGBFMBALBBK : CMLMNIGHOGD
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Task NCNADPIBEPN
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x72BA2D0", Offset = "0x72B8ED0", VA = "0x1872BA2D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Task LAKBMJAADJI
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x72B9EB0", Offset = "0x72B8AB0", VA = "0x1872B9EB0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool CJPCCCHIDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool OJEEMIIKCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string OHJAPKODNJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AODFAKKBJPI INFOHMPFGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action BAGOIPGGLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x72BA410", Offset = "0x72B9010", VA = "0x1872BA410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x72B9CD0", Offset = "0x72B88D0", VA = "0x1872B9CD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action HMGAEPPAILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x72BA4B0", Offset = "0x72B90B0", VA = "0x1872BA4B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x72BA070", Offset = "0x72B8C70", VA = "0x1872BA070", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action FGJIMALCEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x72B9FD0", Offset = "0x72B8BD0", VA = "0x1872B9FD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x72BA230", Offset = "0x72B8E30", VA = "0x1872BA230", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<CPLPELOEICE> LLHIIEFHKND
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x72B9C20", Offset = "0x72B8820", VA = "0x1872B9C20", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x72B9E00", Offset = "0x72B8A00", VA = "0x1872B9E00", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	[RecRoom.NoEngine.Common.Preserve]
	public LGBFMBALBBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x72B9B90", Offset = "0x72B8790", VA = "0x1872B9B90", Slot = "12")]
	public Task AIMKJDEKJHN(string EPBGOMEOIIC, [Optional] FOPCJJNIGDB DNAMHCLLGDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x72BA1A0", Offset = "0x72B8DA0", VA = "0x1872BA1A0", Slot = "19")]
	public Task HOCNHOLEBGG(FOPCJJNIGDB DNAMHCLLGDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x72B9D70", Offset = "0x72B8970", VA = "0x1872B9D70", Slot = "20")]
	public Task BLKIMNJINHD(FOPCJJNIGDB DNAMHCLLGDP, Dictionary<string, string> KIDHDKDMIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "21")]
	public bool ELJBDLPBPEE(string HONLLHDODAH, bool MNIOKMLLEOE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x72BA360", Offset = "0x72B8F60", VA = "0x1872BA360", Slot = "22")]
	public NOPIMODEOFI KNKOEFMFJNM(string EMHHMFJHEMD, bool MNIOKMLLEOE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x72B9F40", Offset = "0x72B8B40", VA = "0x1872B9F40", Slot = "23")]
	public AAEGMEBBJHJ FGCJDDBMDBL(string AHADFMEJIBA, bool MNIOKMLLEOE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x72BA110", Offset = "0x72B8D10", VA = "0x1872BA110", Slot = "24")]
	public Task GFLLHMGKKCM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal class OCBOFKLAKOC : AODFAKKBJPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly ONAJELBADIN MBPDKGOKEBO;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IReadOnlyDictionary<string, object> CIHLNDCLPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xC73C70", Offset = "0xC72870", VA = "0x180C73C70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public OCBOFKLAKOC(ONAJELBADIN AFGMILEKFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface OBGAGIAACHP
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BHPMHEFMCJK PAICJCBPHFD(string ONCFOGPLDEH);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BJLGAMNMGNO
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum KNNHFPHEIHP
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	long JADIMCPHKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string KBJODMHPCPO
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string NDKIFLNCPLG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool HFBCMKOCGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long NBCPNIGCLBG();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFJGEPAIIDK(long PKLHPLNMANJ, bool EPNLCICIDJA = true);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OKDJFIKEDFJ(string HJIAOGEIAJO, string GNNHLOLFEAO, string HHEPOPEFOGM);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IJHMNANBFCN(string HJIAOGEIAJO);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LLNLKONAKBK(string HJIAOGEIAJO, string DJGKFBJOAEG, string GJCFNIMAHGB);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FOKCOMHFDLK(string JLDGAOJPDBN, object MPKFNDBFNEG, object ALAFAAMJBBJ);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IFKCNPNAPCG(KNNHFPHEIHP LECAFFHNMIN, int JLCDBIJGLGB, [Optional] INCKKHCDHHG AKBKEPHFIFF, [Optional] string MMDDMDLKNOE, [Optional] string AHPAHIHOBBE);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void COPBBNOGIBA(INCKKHCDHHG AKBKEPHFIFF, long AFNDAMOFGMC, long HABHBBNLGPB, int AFNLAPCOJKI, string MMDDMDLKNOE, int JLCDBIJGLGB);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PMFIJOCJBCH(INCKKHCDHHG AKBKEPHFIFF, bool CFLNFJDNJEK, [Optional] string AHPAHIHOBBE);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LLOPLPCHCNG(INCKKHCDHHG AKBKEPHFIFF, bool CFLNFJDNJEK, [Optional] string AHPAHIHOBBE);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MHCFEPPCMFP(INCKKHCDHHG AKBKEPHFIFF, bool CFLNFJDNJEK, [Optional] string AHPAHIHOBBE);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FGNEHKCCNDP(long EPGJLNEAJPA, string OBFOKIHEJJK);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface CMBAABABMKN
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string AFDOKODAGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
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
