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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x725A540", Offset = "0x7259940", VA = "0x18725A540")]
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
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x725A1C0", Offset = "0x72595C0", VA = "0x18725A1C0", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x725B140", Offset = "0x725A540", VA = "0x18725B140", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
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
		public AmplitudeAnalyticsClient.Settings CEEBFCJCMAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IDAHFHEHFJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x94FCE0", Offset = "0x94F0E0", VA = "0x18094FCE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, NFEDKEMNHKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum EMHAEMLDHMD
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class CAKGDIEFIAC
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class FIFBCDCFDMN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int AMFHKOGJHMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> BMGCPCAAMMK;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
				public FIFBCDCFDMN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class BNOAEAAEGLB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
				public BNOAEAAEGLB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x724F520", Offset = "0x724E920", VA = "0x18724F520")]
				internal bool FNEPALNAMFN(FIFBCDCFDMN item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string KHLGHHGPLEN = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string DPEONNMDCPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<FIFBCDCFDMN> IHJONEAIBPC;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? GNOLFJHLKEK
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x7250010", Offset = "0x724F410", VA = "0x187250010")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7250830", Offset = "0x724FC30", VA = "0x187250830")]
			internal CAKGDIEFIAC(string FAFGFLIKMPD, string OPOKIOPOKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x724FE60", Offset = "0x724F260", VA = "0x18724FE60")]
			public int HNHPHAMMNGN([Optional] int? COFHJDFKIHC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x72505C0", Offset = "0x724F9C0", VA = "0x1872505C0")]
			public List<Dictionary<string, object>> PAPJNKPHMAK(int PMIIGEJODGI, int? COFHJDFKIHC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x724FAA0", Offset = "0x724EEA0", VA = "0x18724FAA0")]
			public void GHMEBLPFNDN(AmplitudeAnalyticsIdentifyMessage GMFKPONAANG, bool PNHGOEEGDOC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x724FB40", Offset = "0x724EF40", VA = "0x18724FB40")]
			public void GHMEBLPFNDN(Dictionary<string, object> GMFKPONAANG, bool PNHGOEEGDOC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7250430", Offset = "0x724F830", VA = "0x187250430")]
			public void OAMHDLNAPFG(params Dictionary<string, object>[] APMBBMICOIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x72501E0", Offset = "0x724F5E0", VA = "0x1872501E0")]
			public void LPEBCBCLEME(List<Dictionary<string, object>> OGPOOIHMBGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x724F990", Offset = "0x724ED90", VA = "0x18724F990")]
			private void DLJJGCJHHCC(Dictionary<string, object> GMFKPONAANG, bool PNHGOEEGDOC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x724FC50", Offset = "0x724F050", VA = "0x18724FC50")]
			public void HLMPNIBBIHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x724F590", Offset = "0x724E990", VA = "0x18724F590")]
			private void DANAENKPGNB([Optional] string DAJOPLFHCAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x72500B0", Offset = "0x724F4B0", VA = "0x1872500B0")]
			private static string LLHCHKBMKGH(string KBGCCIOIGBD, string LKMGECEEGEE)
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
			[Cpp2IlInjected.Address(RVA = "0x725AD30", Offset = "0x725A130", VA = "0x18725AD30")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct EIALOPGOLNL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int AOPCFCKPJNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string HFLOHBLDMJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T MIJMEPGCMNN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class ADDLDIBMBJC : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
			[DebuggerHidden]
			public ADDLDIBMBJC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x72473B0", Offset = "0x72467B0", VA = "0x1872473B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7247B40", Offset = "0x7246F40", VA = "0x187247B40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class PGEBIGDCIDA : IEnumerator<object>, IEnumerator, IDisposable
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
			public NKJHMBFDFON quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
			[DebuggerHidden]
			public PGEBIGDCIDA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x725A850", Offset = "0x7259C50", VA = "0x18725A850", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x725A960", Offset = "0x7259D60", VA = "0x18725A960", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class HKIBMJJGNKL : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
			[DebuggerHidden]
			public HKIBMJJGNKL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7255240", Offset = "0x7254640", VA = "0x187255240", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x72553B0", Offset = "0x72547B0", VA = "0x1872553B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class JJMKIFODGIK : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
			[DebuggerHidden]
			public JJMKIFODGIK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7256DC0", Offset = "0x72561C0", VA = "0x187256DC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7257020", Offset = "0x7256420", VA = "0x187257020", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class LGHGKBJMJIM : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
			[DebuggerHidden]
			public LGHGKBJMJIM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7259930", Offset = "0x7258D30", VA = "0x187259930", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7259B90", Offset = "0x7258F90", VA = "0x187259B90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class JLHNGLEJKON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public CAKGDIEFIAC cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public JLHNGLEJKON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7257070", Offset = "0x7256470", VA = "0x187257070")]
			internal void HOCMLNPCNDB(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7257390", Offset = "0x7256790", VA = "0x187257390")]
			internal void JMICNOCDAFA(EIALOPGOLNL<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class IKMODMPKNHN : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CAKGDIEFIAC cache;

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
			private JLHNGLEJKON <>8__1;

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
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
			[DebuggerHidden]
			public IKMODMPKNHN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7255EB0", Offset = "0x72552B0", VA = "0x187255EB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x72566D0", Offset = "0x7255AD0", VA = "0x1872566D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class FHCGBCCBHBL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public FHCGBCCBHBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x43C93A0", Offset = "0x43C87A0", VA = "0x1843C93A0")]
			internal EIALOPGOLNL<T> CCMFHKDLOPO(EEBJIOCNPOE postResponse)
			{
				return default(EIALOPGOLNL<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private CDIHIOEBGKL HFGMMHMEBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<IJIECKPLCLG> DOFFFOGMIMJ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string OMFDHNHBKHF = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string INLHKPBFIPL = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string IDGBMPOIPJL = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int BNODPDLKHOK = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int LKBIMHEEPMB = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int DONGOBFAGMH = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float ANPMKLMHHFF = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long LLPKOAICEHG = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string JOLILAFKPNG = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string GENFMMIDMFK = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string GBPKFCANAJJ = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string PDALDEOAACN = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool NPPHCJJHKFL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool JLAADJIKEMA;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int GMGMIFDHOCN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int FDKGBLJJGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private DBKOIMNCEMC BJJAGPNFBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private JEPPADOHMNE JJOIDHPLDIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private AKPEKCLMGOC JJFLHFANALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool HDDBEEAIPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float BNIFNEPIEIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float JFHFLPMELJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int EFPKGPGEOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int KDAJJKHFNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? PMMHCIPGDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? LOPPJIFEMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long PLGIFNFJFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string PPNGDFGFFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string AKFMGMHANPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long BCJOICCILOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string GOLDBPOGKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string BOFFPBHLJIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> AIBIGOEHAKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private EMHAEMLDHMD BHPPEOBJFEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int JJDPIFNPEMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int KDIDGANFIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float DMGAKHJPOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool DKLBCOGGMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool OFBKADHOMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CAKGDIEFIAC FNGHIIGOOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private CAKGDIEFIAC LDNJODCCFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CAKGDIEFIAC MPKJKPLHDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string NCMLDLFEHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> FONJFKJLPGP;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo JGDAOMADFFE;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string EEKKMOFMDPA;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string FDGIGGAAIPN = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string ICDHKEGPEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string FAKMBFJKKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string LDLCDJHKMEN;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private CDIHIOEBGKL COBMNPFDHDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7249AC0", Offset = "0x7248EC0", VA = "0x187249AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private IJIECKPLCLG EABOLPIPJON
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7249690", Offset = "0x7248A90", VA = "0x187249690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int BBGOMJOKFGL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x724A130", Offset = "0x7249530", VA = "0x18724A130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long GONENKMEILN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x724DA80", Offset = "0x724CE80", VA = "0x18724DA80")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x724DB90", Offset = "0x724CF90", VA = "0x18724DB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string FPNFHDDJMGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x724DA50", Offset = "0x724CE50", VA = "0x18724DA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool KOOLCCHMOJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x122FE10", Offset = "0x122F210", VA = "0x18122FE10", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x122E3E0", Offset = "0x122D7E0", VA = "0x18122E3E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BAMGPKONIIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA34B60", Offset = "0xA33F60", VA = "0x180A34B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA3AD40", Offset = "0xA3A140", VA = "0x180A3AD40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? PEEACNGAJJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA34B70", Offset = "0xA33F70", VA = "0x180A34B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA3A7B0", Offset = "0xA39BB0", VA = "0x180A3A7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OFENFMLBBAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xC762D0", Offset = "0xC756D0", VA = "0x180C762D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x112C100", Offset = "0x112B500", VA = "0x18112C100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool LKFFBDIBKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x724D960", Offset = "0x724CD60", VA = "0x18724D960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> KONICEPMBAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x724D8A0", Offset = "0x724CCA0", VA = "0x18724D8A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x724DAD0", Offset = "0x724CED0", VA = "0x18724DAD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7247DD0", Offset = "0x72471D0", VA = "0x187247DD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7248430", Offset = "0x7247830", VA = "0x187248430")]
		private void CLDBAHNEIPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x724CED0", Offset = "0x724C2D0", VA = "0x18724CED0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x724ACB0", Offset = "0x724A0B0", VA = "0x18724ACB0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x724D200", Offset = "0x724C600", VA = "0x18724D200")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x724BC40", Offset = "0x724B040", VA = "0x18724BC40")]
		public HJOKANJAKGB PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x724A0A0", Offset = "0x72494A0", VA = "0x18724A0A0")]
		[IteratorStateMachine(typeof(ADDLDIBMBJC))]
		public IEnumerator<FBLKJCIOKGP> InitializeForLocalAccount(AmplitudeAnalyticsEvent KNJENBHEMKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x724C5A0", Offset = "0x724B9A0", VA = "0x18724C5A0")]
		public void SendAppEnterEvent(bool BGIFJFGPBDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x724D180", Offset = "0x724C580", VA = "0x18724D180")]
		public void UpdateLastKnownInteractionCategory(string EKGJIJBOMEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x724D0D0", Offset = "0x724C4D0", VA = "0x18724D0D0")]
		public void UpdateLastAliveTime(float HIBCBLOKLEA = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72492B0", Offset = "0x72486B0", VA = "0x1872492B0")]
		private HJOKANJAKGB EOEJDHCICMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x724AD70", Offset = "0x724A170", VA = "0x18724AD70")]
		private HJOKANJAKGB PFHADKLJIIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x724C8B0", Offset = "0x724BCB0", VA = "0x18724C8B0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x724A330", Offset = "0x7249730", VA = "0x18724A330")]
		[IteratorStateMachine(typeof(PGEBIGDCIDA))]
		private IEnumerator KLHIPEEBFAP(NKJHMBFDFON KAFODDCOHJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x724D490", Offset = "0x724C890", VA = "0x18724D490")]
		[IteratorStateMachine(typeof(HKIBMJJGNKL))]
		public IEnumerator WaitForFlush(float GAOGFDNIHEO = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x724CFB0", Offset = "0x724C3B0", VA = "0x18724CFB0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x724CEF0", Offset = "0x724C2F0", VA = "0x18724CEF0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime KGDKBIOOEOP)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7249BA0", Offset = "0x7248FA0", VA = "0x187249BA0")]
		public static HLFNENDJOGP Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7247C20", Offset = "0x7247020", VA = "0x187247C20")]
		public static LIIGBNJFBAA AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string NCHMBDMAKLI, string PNHEMONCBEB, BPHJFMHKELH EEPPLAEHENM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7249370", Offset = "0x7248770", VA = "0x187249370")]
		public static LIIGBNJFBAA Event([JetBrains.Annotations.NotNull] string NCHMBDMAKLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x724BDE0", Offset = "0x724B1E0", VA = "0x18724BDE0")]
		public static LIIGBNJFBAA PreviousSessionEvent([JetBrains.Annotations.NotNull] string NCHMBDMAKLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7249D40", Offset = "0x7249140", VA = "0x187249D40")]
		public static LIIGBNJFBAA InitializeEvent(string PNHEMONCBEB, int BIOKOOFIJDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x724CAB0", Offset = "0x724BEB0", VA = "0x18724CAB0")]
		public static LIIGBNJFBAA StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x72488D0", Offset = "0x7247CD0", VA = "0x1872488D0")]
		public static LIIGBNJFBAA CreateOutOfSessionEvent(string NCHMBDMAKLI, bool HLCCAFKJBCH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x724A640", Offset = "0x7249A40", VA = "0x18724A640")]
		public static HJOKANJAKGB LogOutOfSessionEvent(LIIGBNJFBAA BAKMDMHMEFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x724A3C0", Offset = "0x72497C0", VA = "0x18724A3C0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LOLIGDPJGMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x724A810", Offset = "0x7249C10", VA = "0x18724A810")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LOLIGDPJGMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x724A950", Offset = "0x7249D50", VA = "0x18724A950")]
		public void LogSerializedEventAsync(Dictionary<string, object> NCLOBOFGNGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x724A500", Offset = "0x7249900", VA = "0x18724A500")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage DOLLNIEACCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7248BB0", Offset = "0x7247FB0", VA = "0x187248BB0")]
		private void DGNKMLDGKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7248FF0", Offset = "0x72483F0", VA = "0x187248FF0")]
		private void DNEOIMAFKGA(Dictionary<string, object> DMGPEODFGGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72499D0", Offset = "0x7248DD0", VA = "0x1872499D0")]
		private void IJFBCLHHJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7249800", Offset = "0x7248C00", VA = "0x187249800")]
		private void HAEGPDOOHHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72496E0", Offset = "0x7248AE0", VA = "0x1872496E0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7247B90", Offset = "0x7246F90", VA = "0x187247B90")]
		[IteratorStateMachine(typeof(JJMKIFODGIK))]
		private IEnumerator<FBLKJCIOKGP> ADLMKACPAMH(float GAOGFDNIHEO = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7249770", Offset = "0x7248B70", VA = "0x187249770")]
		[IteratorStateMachine(typeof(LGHGKBJMJIM))]
		private IEnumerator<FBLKJCIOKGP> GOFJAOEIFNG(float GAOGFDNIHEO = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x72487F0", Offset = "0x7247BF0", VA = "0x1872487F0")]
		[IteratorStateMachine(typeof(IKMODMPKNHN))]
		private IEnumerator<FBLKJCIOKGP> CNEANFLEPAP(CAKGDIEFIAC HIDLDGNDFHN, int? COFHJDFKIHC, string OFOFNJEGEMM, float GAOGFDNIHEO, Action<int> LLOCECLHKNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x724ABA0", Offset = "0x7249FA0", VA = "0x18724ABA0")]
		private static void OBLIEPBKFPH(bool FLFKOMGIOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7248CB0", Offset = "0x72480B0", VA = "0x187248CB0")]
		private NEEPBAPEEOL<EIALOPGOLNL<Dictionary<string, object>>> DKCLCGOLCKD(string OFOFNJEGEMM, string LNDJMFKPPJJ, Dictionary<string, object> MIJMEPGCMNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7248D80", Offset = "0x7248180", VA = "0x187248D80")]
		private NEEPBAPEEOL<EIALOPGOLNL<List<Dictionary<string, object>>>> DKCLCGOLCKD(string OFOFNJEGEMM, string LNDJMFKPPJJ, List<Dictionary<string, object>> MIJMEPGCMNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3B67080", Offset = "0x3B66480", VA = "0x183B67080")]
		private NEEPBAPEEOL<EIALOPGOLNL<T>> JHLKLIIPHFP<T>(string PIBKKLOLEJD, string OFOFNJEGEMM, string LNDJMFKPPJJ, T MIJMEPGCMNN, Dictionary<string, object> FEBEFFBOBJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7249B50", Offset = "0x7248F50", VA = "0x187249B50")]
		private bool IPHLBMBMOOI(float LCHOJPBPMKM, float GAOGFDNIHEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x724AEE0", Offset = "0x724A2E0", VA = "0x18724AEE0")]
		private Dictionary<string, object> PPMHKNFJKAF(string OFOFNJEGEMM, Dictionary<string, object> MIJMEPGCMNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x724D580", Offset = "0x724C980", VA = "0x18724D580")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x976B50", Offset = "0x975F50", VA = "0x180976B50", Slot = "6")]
		private bool GIDEPICAEBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x724AA30", Offset = "0x7249E30", VA = "0x18724AA30")]
		[CompilerGenerated]
		private long MKMJCDGNAJD()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7249680", Offset = "0x7248A80", VA = "0x187249680")]
		[CompilerGenerated]
		private void FIPLELMLHKB(int LEBKLHMKLCG)
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
			[Cpp2IlInjected.Address(RVA = "0x724E890", Offset = "0x724DC90", VA = "0x18724E890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x724E970", Offset = "0x724DD70", VA = "0x18724E970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x724E8D0", Offset = "0x724DCD0", VA = "0x18724E8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x724E9D0", Offset = "0x724DDD0", VA = "0x18724E9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x724E850", Offset = "0x724DC50", VA = "0x18724E850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x724E910", Offset = "0x724DD10", VA = "0x18724E910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x94FD00", Offset = "0x94F100", VA = "0x18094FD00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x724E5B0", Offset = "0x724D9B0", VA = "0x18724E5B0")]
		public static LIIGBNJFBAA OILMBKHFGKP(string EPKMALKPPHD, [JetBrains.Annotations.NotNull] string AFCDMPICECP, long JKHDHJCLOPL, long FBCPCGEBMHM, string PNHEMONCBEB, string EEPPLAEHENM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x724E1D0", Offset = "0x724D5D0", VA = "0x18724E1D0")]
		public static LIIGBNJFBAA MAPMCHPNPIK(string EPKMALKPPHD, [JetBrains.Annotations.NotNull] string AFCDMPICECP, long JKHDHJCLOPL, long FBCPCGEBMHM, string PNHEMONCBEB, long DGEHFIPAHGK, string AGFLAALGMLA, string FLNLMBKDKAL, string JLJDNLPPMGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x724E6B0", Offset = "0x724DAB0", VA = "0x18724E6B0")]
		private AmplitudeAnalyticsEvent(string EPKMALKPPHD, [JetBrains.Annotations.NotNull] string AFCDMPICECP, long JKHDHJCLOPL, long FBCPCGEBMHM, string PNHEMONCBEB, string EEPPLAEHENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCEDEA0", Offset = "0xCED2A0", VA = "0x180CEDEA0")]
		public void ELKEGAOJMNN(long GKLNOKLILDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x724E4B0", Offset = "0x724D8B0", VA = "0x18724E4B0", Slot = "5")]
		public override void NIFAKHLGPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x724E330", Offset = "0x724D730", VA = "0x18724E330", Slot = "6")]
		public override void NBOIDEIKMKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x724DD00", Offset = "0x724D100", VA = "0x18724DD00", Slot = "4")]
		protected override Dictionary<string, object> FBAOMFBPHAG(Dictionary<string, object> HDPFACLFLHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x724DBF0", Offset = "0x724CFF0", VA = "0x18724DBF0")]
		private void BOBMDPKNGED(string LKMGECEEGEE, string KBGCCIOIGBD, bool IDNIBGLEFJO = false)
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
			[Cpp2IlInjected.Address(RVA = "0x7252A20", Offset = "0x7251E20", VA = "0x187252A20")]
			public void KMFGOACMBCL(Dictionary<string, object> PHMILIIDFEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x725A9B0", Offset = "0x7259DB0", VA = "0x18725A9B0")]
			public void KMFGOACMBCL(Dictionary<string, object> FOBKBHKAHFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x10D2330", Offset = "0x10D1730", VA = "0x1810D2330")]
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
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x724F020", Offset = "0x724E420", VA = "0x18724F020")]
		public static HLFNENDJOGP OILMBKHFGKP(string EPKMALKPPHD, string PNHEMONCBEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x724F0E0", Offset = "0x724E4E0", VA = "0x18724F0E0")]
		protected AmplitudeAnalyticsIdentifyMessage(string EPKMALKPPHD, string PNHEMONCBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x724EA30", Offset = "0x724DE30", VA = "0x18724EA30")]
		public Dictionary<string, object> BFAJHHBOIPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x724EAC0", Offset = "0x724DEC0", VA = "0x18724EAC0", Slot = "4")]
		protected virtual Dictionary<string, object> FBAOMFBPHAG(Dictionary<string, object> HDPFACLFLHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x724EE00", Offset = "0x724E200", VA = "0x18724EE00")]
		protected void HOLEDIEPDIN(string LKMGECEEGEE, Dictionary<string, object> OAIFAEMAENK, Dictionary<string, object> OCMDMHAAKGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x724EEA0", Offset = "0x724E2A0", VA = "0x18724EEA0")]
		protected void KHDBNKOIJHC(string LKMGECEEGEE, string KBGCCIOIGBD, Dictionary<string, object> CFFOECLBAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x724EF90", Offset = "0x724E390", VA = "0x18724EF90", Slot = "5")]
		public virtual void NIFAKHLGPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x724EF10", Offset = "0x724E310", VA = "0x18724EF10", Slot = "6")]
		public virtual void NBOIDEIKMKH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HLFNENDJOGP : MPHAKAKBMMF<AmplitudeAnalyticsIdentifyMessage, HLFNENDJOGP>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override HLFNENDJOGP MJDGFBDIKHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage MLDFNPPIBHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x72554A0", Offset = "0x72548A0", VA = "0x1872554A0")]
	public HLFNENDJOGP(AmplitudeAnalyticsIdentifyMessage MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7255400", Offset = "0x7254800", VA = "0x187255400", Slot = "4")]
	public override void NBOIDEIKMKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LIIGBNJFBAA : MPHAKAKBMMF<AmplitudeAnalyticsEvent, LIIGBNJFBAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool JHOJIEGKKLD;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override LIIGBNJFBAA MJDGFBDIKHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long NPELFIOBJDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7259F10", Offset = "0x7259310", VA = "0x187259F10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7254810", Offset = "0x7253C10", VA = "0x187254810")]
	public LIIGBNJFBAA(AmplitudeAnalyticsEvent MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "5")]
	public override AmplitudeAnalyticsEvent MLDFNPPIBHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7259DD0", Offset = "0x72591D0", VA = "0x187259DD0", Slot = "4")]
	public override void NBOIDEIKMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3480910", Offset = "0x347FD10", VA = "0x183480910")]
	public LIIGBNJFBAA HHDHNPBMKNK<T>(string KKCCAKAEMAH, T[] KBGCCIOIGBD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3480910", Offset = "0x347FD10", VA = "0x183480910")]
	public LIIGBNJFBAA HHDHNPBMKNK(string KKCCAKAEMAH, string[] KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3480660", Offset = "0x347FA60", VA = "0x183480660")]
	public LIIGBNJFBAA HHDHNPBMKNK<T>(string KKCCAKAEMAH, T KBGCCIOIGBD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7259D50", Offset = "0x7259150", VA = "0x187259D50")]
	public LIIGBNJFBAA HHDHNPBMKNK(string KKCCAKAEMAH, long KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7259CE0", Offset = "0x72590E0", VA = "0x187259CE0")]
	public LIIGBNJFBAA HHDHNPBMKNK(string KKCCAKAEMAH, string KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7259F30", Offset = "0x7259330", VA = "0x187259F30")]
	public LIIGBNJFBAA NLDMCDIANLJ(string KKCCAKAEMAH, object? KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7259E70", Offset = "0x7259270", VA = "0x187259E70")]
	public LIIGBNJFBAA NKDONHPINJF(string KKCCAKAEMAH, string KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7259BE0", Offset = "0x7258FE0", VA = "0x187259BE0")]
	private LIIGBNJFBAA GIAHDAJOALA(string KKCCAKAEMAH, object KBGCCIOIGBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FIJFFPIEDKJ : LIIGBNJFBAA
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7254810", Offset = "0x7253C10", VA = "0x187254810")]
	public FIJFFPIEDKJ(AmplitudeAnalyticsEvent MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7254660", Offset = "0x7253A60", VA = "0x187254660", Slot = "4")]
	public override void NBOIDEIKMKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class MPHAKAKBMMF<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : MPHAKAKBMMF<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M MIALAMIFNLM;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR MJDGFBDIKHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public MPHAKAKBMMF(M MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDBC0", Offset = "0x4DDCFC0", VA = "0x184DDDBC0")]
	public BLDR CNAPEFLPKFA(AmplitudeAnalyticsIdentifyMessage.DeviceInfo LHMKPPICIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDD40", Offset = "0x4DDD140", VA = "0x184DDDD40")]
	public BLDR PIFGIPJOMLI(AmplitudeAnalyticsIdentifyMessage.RevenueData COPGFNOCBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDB20", Offset = "0x4DDCF20", VA = "0x184DDDB20")]
	public BLDR AKOEGLHJNIA(string KKCCAKAEMAH, string KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x356B480", Offset = "0x356A880", VA = "0x18356B480")]
	public BLDR AKOEGLHJNIA<T>(string KKCCAKAEMAH, T KBGCCIOIGBD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NBOIDEIKMKH();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDD10", Offset = "0x4DDD110", VA = "0x184DDDD10")]
	internal static string JKKOHKBHDHJ(string KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDC10", Offset = "0x4DDD010", VA = "0x184DDDC10")]
	private BLDR IJGGHPEBFPI(string KKCCAKAEMAH, object KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M MLDFNPPIBHP();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class LOIIALDGJBB : DBKOIMNCEMC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct EGONBCBEENH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<EEBJIOCNPOE> <>t__builder;

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
		public LOIIALDGJBB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7252BA0", Offset = "0x7251FA0", VA = "0x187252BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x72535D0", Offset = "0x72529D0", VA = "0x1872535D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient ONBEKOKGEPN;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7259F60", Offset = "0x7259360", VA = "0x187259F60")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void CALJOAEMNPO(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x725A140", Offset = "0x7259540", VA = "0x18725A140")]
	[RecRoom.NoEngine.Common.Preserve]
	public LOIIALDGJBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7259FD0", Offset = "0x72593D0", VA = "0x187259FD0", Slot = "4")]
	[AsyncStateMachine(typeof(EGONBCBEENH))]
	public Task<EEBJIOCNPOE> INNIGHKJABD(string PIBKKLOLEJD, string GKDEEIMJHJE, string AOELHHBCGDL, string ELKJHFICEJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class OOLLEGIFILA : DBKOIMNCEMC
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JGHICCKOKKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<EEBJIOCNPOE> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JGHICCKOKKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7256CE0", Offset = "0x72560E0", VA = "0x187256CE0")]
		internal void NAIBGGMJNLM(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct IPKBJJJILLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<EEBJIOCNPOE> <>t__builder;

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
		private TaskAwaiter<EEBJIOCNPOE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7256720", Offset = "0x7255B20", VA = "0x187256720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7256C70", Offset = "0x7256070", VA = "0x187256C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void BGLCLKPENLI(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OOLLEGIFILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x725A6F0", Offset = "0x7259AF0", VA = "0x18725A6F0", Slot = "4")]
	[AsyncStateMachine(typeof(IPKBJJJILLE))]
	public Task<EEBJIOCNPOE> INNIGHKJABD(string PIBKKLOLEJD, string GKDEEIMJHJE, string AOELHHBCGDL, string ELKJHFICEJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BGGDEPLIDAC
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> EJEBOGMCFIK;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x724F1A0", Offset = "0x724E5A0", VA = "0x18724F1A0")]
	internal static bool GBKKLMJDFDB(string LKMGECEEGEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface DBKOIMNCEMC
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EEBJIOCNPOE> INNIGHKJABD(string PIBKKLOLEJD, string GKDEEIMJHJE, string AOELHHBCGDL, string ELKJHFICEJN);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct EEBJIOCNPOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int MENEGJBMHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string KDLJBDKMDPC;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x141D850", Offset = "0x141CC50", VA = "0x18141D850")]
	public EEBJIOCNPOE(int AOPCFCKPJNP, string HFLOHBLDMJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum CKEOJGLICPC
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
public class HLJCPGKDMOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private long BGEKIGECJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private LIIGBNJFBAA BGJAJNGKGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool DENGCBIELFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float EFCJBGBKNBH;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7255880", Offset = "0x7254C80", VA = "0x187255880")]
	public HLJCPGKDMOP(string NLKJMGFMOOO, float EFCJBGBKNBH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x33A9910", Offset = "0x33A8D10", VA = "0x1833A9910")]
	public void HHDHNPBMKNK<T>(string KKCCAKAEMAH, T KBGCCIOIGBD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7255540", Offset = "0x7254940", VA = "0x187255540")]
	public void HHDHNPBMKNK(string KKCCAKAEMAH, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7255680", Offset = "0x7254A80", VA = "0x187255680")]
	public void LLBKKCFGCFM(string EFCBHOMGKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72555C0", Offset = "0x72549C0", VA = "0x1872555C0")]
	public void KEKDMCFDIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7255770", Offset = "0x7254B70", VA = "0x187255770")]
	private void OFGJKOMMBHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x72554F0", Offset = "0x72548F0", VA = "0x1872554F0")]
	private bool HDJBNKBLHAE()
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
		public enum OANNIEMOBOO
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
		private OANNIEMOBOO parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public OANNIEMOBOO Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xA836D0", Offset = "0xA82AD0", VA = "0x180A836D0")]
			get
			{
				return default(OANNIEMOBOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x725AB20", Offset = "0x7259F20", VA = "0x18725AB20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[RecRoom.NoEngine.Common.Preserve]
public class KCAJKADIIJC : IIJAMPALPOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct OKNGOJKAEOH : IEquatable<OKNGOJKAEOH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly string DDJNILIEBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly string NGNJOGCLOJN;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A764D0", Offset = "0x6A758D0", VA = "0x186A764D0", Slot = "4")]
		public bool Equals(OKNGOJKAEOH OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x725A5C0", Offset = "0x72599C0", VA = "0x18725A5C0", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x725A680", Offset = "0x7259A80", VA = "0x18725A680", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private CHDNBFGGGBI DIKLELHCODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Dictionary<OKNGOJKAEOH, AALJPNGCHAL> JMLGDFMCDMI;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7258A80", Offset = "0x7257E80", VA = "0x187258A80")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7258DB0", Offset = "0x72581B0", VA = "0x187258DB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KCAJKADIIJC([System.Diagnostics.CodeAnalysis.NotNull][IBJCGEMJMJL(null)] CHDNBFGGGBI DIKLELHCODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7258AF0", Offset = "0x7257EF0", VA = "0x187258AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7258BF0", Offset = "0x7257FF0", VA = "0x187258BF0")]
	private void ICOJAMIIJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7258C00", Offset = "0x7258000", VA = "0x187258C00")]
	private void PMJMPONEDCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class MCKGOHFBAMM : ELDEJEIMAMA, FNPMEOKMMHG
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void IFNACIAINBG(ECDLMPFAGKE PDGKKPABECG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly OKGKFGHFJND OPLCAJEGNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly IFNACIAINBG AMAHLLDLPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly string MDNNIPLIIAP;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string HKEMBBKOJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x18ECED0", Offset = "0x18EC2D0", VA = "0x1818ECED0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IHPLGLEAALA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x725A250", Offset = "0x7259650", VA = "0x18725A250", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool LDBDMNBACFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x725A270", Offset = "0x7259670", VA = "0x18725A270", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> OGDFNKLPALB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x18ECEB0", Offset = "0x18EC2B0", VA = "0x1818ECEB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x725A290", Offset = "0x7259690", VA = "0x18725A290")]
	public MCKGOHFBAMM(OKGKFGHFJND HIGIOODIHPF, string JDJLOLIGKPL, [Optional] IFNACIAINBG BJIGOKGLJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x34B81D0", Offset = "0x34B75D0", VA = "0x1834B81D0", Slot = "8")]
	public T NPPDIJEBOHO<T>(string LKMGECEEGEE, T IDJBNLNBJCD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class DGPNNGHFCFM : CHDNBFGGGBI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct KFCLPNNAECA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public JEPPADOHMNE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public DGPNNGHFCFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7258F60", Offset = "0x7258360", VA = "0x187258F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x72598D0", Offset = "0x7258CD0", VA = "0x1872598D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct MJPAHOFFGOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x725A300", Offset = "0x7259700", VA = "0x18725A300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x725A4E0", Offset = "0x72598E0", VA = "0x18725A4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct ICMOCOIBCJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public JEPPADOHMNE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public DGPNNGHFCFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7255A10", Offset = "0x7254E10", VA = "0x187255A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7255E50", Offset = "0x7255250", VA = "0x187255E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct FFDMNHEEDNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public DGPNNGHFCFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public JEPPADOHMNE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7254240", Offset = "0x7253640", VA = "0x187254240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7254600", Offset = "0x7253A00", VA = "0x187254600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly IReadOnlyDictionary<string, EOOAIADNMHL> DBDOMAKIAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool JDODMFGIFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool FCJLKLOFDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private TaskCompletionSource<bool> MGMKDOOHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private TaskCompletionSource<bool> PCOCBIAIKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly SemaphoreSlim AKFKMIIGNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private IPBHPEAPBBB EBOBJMCCBON;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Task NMNAHMFGEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x72525F0", Offset = "0x72519F0", VA = "0x1872525F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Task FBCFFFFIENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7252630", Offset = "0x7251A30", VA = "0x187252630", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool GGMMNIKGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xB39EB0", Offset = "0xB392B0", VA = "0x180B39EB0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HLBAPFPPFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xB39640", Offset = "0xB38A40", VA = "0x180B39640", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string BAMGPKONIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7251DD0", Offset = "0x72511D0", VA = "0x187251DD0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public GJEABAFLEFD CGAHNJILCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7251200", Offset = "0x7250600", VA = "0x187251200", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GIJELINNMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7252310", Offset = "0x7251710", VA = "0x187252310", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x72524A0", Offset = "0x72518A0", VA = "0x1872524A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action KIKAHCLAMBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7250A40", Offset = "0x724FE40", VA = "0x187250A40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x72509A0", Offset = "0x724FDA0", VA = "0x1872509A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BFMIDNLNJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x72521C0", Offset = "0x72515C0", VA = "0x1872521C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7250DF0", Offset = "0x72501F0", VA = "0x187250DF0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<ECDLMPFAGKE> LMCIIMGNACC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7252260", Offset = "0x7251660", VA = "0x187252260", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7252540", Offset = "0x7251940", VA = "0x187252540", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7250DD0", Offset = "0x72501D0", VA = "0x187250DD0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7251FF0", Offset = "0x72513F0", VA = "0x187251FF0", Slot = "12")]
	[AsyncStateMachine(typeof(KFCLPNNAECA))]
	public Task HPHCPPKCEKM(string OPOKIOPOKBE, [Optional] JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7252110", Offset = "0x7251510", VA = "0x187252110", Slot = "24")]
	[AsyncStateMachine(typeof(MJPAHOFFGOE))]
	public Task JLIOHLLGMND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7252670", Offset = "0x7251A70", VA = "0x187252670", Slot = "19")]
	[AsyncStateMachine(typeof(ICMOCOIBCJI))]
	public Task POBCLMOILMG(JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7250D30", Offset = "0x7250130", VA = "0x187250D30")]
	private void DFGKBFAMJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7251CC0", Offset = "0x72510C0", VA = "0x187251CC0", Slot = "20")]
	[AsyncStateMachine(typeof(FFDMNHEEDNN))]
	public Task GAHHFBNPFPK(JEPPADOHMNE AGOFGEFAJDM, Dictionary<string, string> GDLLGFFMPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x72523B0", Offset = "0x72517B0", VA = "0x1872523B0", Slot = "21")]
	public bool NGGEOBINKCB(string FNBHEIHNCOL, bool FJOGPKKCMDC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7251040", Offset = "0x7250440", VA = "0x187251040", Slot = "22")]
	public ELDEJEIMAMA FHCKJNCCMCG(string JDJLOLIGKPL, bool FJOGPKKCMDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7250AE0", Offset = "0x724FEE0", VA = "0x187250AE0")]
	private OKGKFGHFJND BGCLHAJLHJJ(string JDJLOLIGKPL, bool FJOGPKKCMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7250E90", Offset = "0x7250290", VA = "0x187250E90", Slot = "23")]
	public EDOBDFIPKNK FFBMDHNLDIK(string GICEEKIGHOI, bool FJOGPKKCMDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7251EF0", Offset = "0x72512F0", VA = "0x187251EF0")]
	private PBOMDEJLLNE HBEIJEAIPCF(string GICEEKIGHOI, bool FJOGPKKCMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x72513E0", Offset = "0x72507E0", VA = "0x1872513E0")]
	private MMGHLBONINL FOHIBEBOKPA(JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7251230", Offset = "0x7250630", VA = "0x187251230")]
	private NLDONJHGGEC FNMIBLKMKGL(string OPOKIOPOKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7251DE0", Offset = "0x72511E0", VA = "0x187251DE0")]
	private void GFAOJHECAOH(string JDJLOLIGKPL, OKGKFGHFJND HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7252920", Offset = "0x7251D20", VA = "0x187252920")]
	public DGPNNGHFCFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7250CF0", Offset = "0x72500F0", VA = "0x187250CF0")]
	[CompilerGenerated]
	private void NMAAGDGOPKB(ECDLMPFAGKE FBIKENCMLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7250CF0", Offset = "0x72500F0", VA = "0x187250CF0")]
	[CompilerGenerated]
	private void BLHPKCPFOOI(ECDLMPFAGKE FBIKENCMLKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JNMDGFBFLCI : CHDNBFGGGBI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct FMIHEMFPNPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public JNMDGFBFLCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public JEPPADOHMNE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7254860", Offset = "0x7253C60", VA = "0x187254860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x72551E0", Offset = "0x72545E0", VA = "0x1872551E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct EJOCCDOHFMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7253640", Offset = "0x7252A40", VA = "0x187253640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private DGPNNGHFCFM CNCEOJIABCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private TaskCompletionSource<bool> MGMKDOOHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private TaskCompletionSource<bool> PCOCBIAIKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private Task NPMHHCGCIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private Task FHJALGGBLIH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private CHDNBFGGGBI NBIHMNBOAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x72579D0", Offset = "0x7256DD0", VA = "0x1872579D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool HLBAPFPPFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7257DE0", Offset = "0x72571E0", VA = "0x187257DE0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GGMMNIKGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7257880", Offset = "0x7256C80", VA = "0x187257880", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Task NMNAHMFGEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7258770", Offset = "0x7257B70", VA = "0x187258770", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Task FBCFFFFIENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7258810", Offset = "0x7257C10", VA = "0x187258810", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string BAMGPKONIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7257DC0", Offset = "0x72571C0", VA = "0x187257DC0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public GJEABAFLEFD CGAHNJILCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7257C60", Offset = "0x7257060", VA = "0x187257C60", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action KIKAHCLAMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7257900", Offset = "0x7256D00", VA = "0x187257900", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x72577E0", Offset = "0x7256BE0", VA = "0x1872577E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action GIJELINNMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7258460", Offset = "0x7257860", VA = "0x187258460", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7258620", Offset = "0x7257A20", VA = "0x187258620", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action BFMIDNLNJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7258150", Offset = "0x7257550", VA = "0x187258150", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7257A40", Offset = "0x7256E40", VA = "0x187257A40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<ECDLMPFAGKE> LMCIIMGNACC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x72583B0", Offset = "0x72577B0", VA = "0x1872583B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x72586C0", Offset = "0x7257AC0", VA = "0x1872586C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x72589C0", Offset = "0x7257DC0", VA = "0x1872589C0")]
	[UnityEngine.Scripting.Preserve]
	public JNMDGFBFLCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7257890", Offset = "0x7256C90", VA = "0x187257890")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7257F00", Offset = "0x7257300", VA = "0x187257F00")]
	internal static void JBPADDGJIME(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x72579A0", Offset = "0x7256DA0", VA = "0x1872579A0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7257DF0", Offset = "0x72571F0", VA = "0x187257DF0", Slot = "12")]
	[AsyncStateMachine(typeof(FMIHEMFPNPG))]
	public Task HPHCPPKCEKM(string OPOKIOPOKBE, [Optional] JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x72588B0", Offset = "0x7257CB0", VA = "0x1872588B0", Slot = "19")]
	public Task POBCLMOILMG(JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7257CA0", Offset = "0x72570A0", VA = "0x187257CA0", Slot = "20")]
	public Task GAHHFBNPFPK(JEPPADOHMNE AGOFGEFAJDM, Dictionary<string, string> GDLLGFFMPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7258500", Offset = "0x7257900", VA = "0x187258500", Slot = "21")]
	public bool NGGEOBINKCB(string FNBHEIHNCOL, bool FJOGPKKCMDC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7257BA0", Offset = "0x7256FA0", VA = "0x187257BA0", Slot = "22")]
	public ELDEJEIMAMA FHCKJNCCMCG(string JDJLOLIGKPL, bool FJOGPKKCMDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7257AE0", Offset = "0x7256EE0", VA = "0x187257AE0", Slot = "23")]
	public EDOBDFIPKNK FFBMDHNLDIK(string GICEEKIGHOI, bool FJOGPKKCMDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7258040", Offset = "0x7257440", VA = "0x187258040", Slot = "24")]
	public Task JLIOHLLGMND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7258230", Offset = "0x7257630", VA = "0x187258230")]
	private static void MFDFODOLKAO(TaskCompletionSource<bool> KDHLGIELGNK, Task AJKKKJPOLGN, Task MHLDMFINCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7257F70", Offset = "0x7257370", VA = "0x187257F70")]
	[AsyncStateMachine(typeof(EJOCCDOHFMH))]
	private static void JKGNIGGOJJK(Task CBPINBDBDCO, TaskCompletionSource<bool> KDHLGIELGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0xCE9830", Offset = "0xCE8C30", VA = "0x180CE9830")]
	[CompilerGenerated]
	private void MEBMKJJJMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xD47330", Offset = "0xD46730", VA = "0x180D47330")]
	[CompilerGenerated]
	private void OGIBFKBBOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0xB5E800", Offset = "0xB5DC00", VA = "0x180B5E800")]
	[CompilerGenerated]
	private void LNEDCGFKFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x72581F0", Offset = "0x72575F0", VA = "0x1872581F0")]
	[CompilerGenerated]
	private void LNHDKFLINLC(ECDLMPFAGKE FBIKENCMLKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal class LGEKGFOGLKJ : EDOBDFIPKNK, FNPMEOKMMHG
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate void DNNIIAMKCOD(ECDLMPFAGKE PDGKKPABECG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly DNNIIAMKCOD AMAHLLDLPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly PBOMDEJLLNE NEEJKDEDHPL;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string HKEMBBKOJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xC81050", Offset = "0xC80450", VA = "0x180C81050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xD83EC0", Offset = "0xD832C0", VA = "0x180D83EC0")]
	public LGEKGFOGLKJ(PBOMDEJLLNE GKKHJGBAALN, [Optional] DNNIIAMKCOD BJIGOKGLJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x347E610", Offset = "0x347DA10", VA = "0x18347E610", Slot = "5")]
	public T NPPDIJEBOHO<T>(string LKMGECEEGEE, T IDJBNLNBJCD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IHKILNDGGHI
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[UsedImplicitly]
public class BJCBGNDNHKK : IHKILNDGGHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly AHHIBBAIEPC EBBMEKOBJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly List<HPFFGCNAFME> PNBDCICEDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly string ILNOHDILPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly string HLMEDGNEBBE;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x724F350", Offset = "0x724E750", VA = "0x18724F350")]
	[UsedImplicitly]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void HBMGFBHOMDP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x724F3C0", Offset = "0x724E7C0", VA = "0x18724F3C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal BJCBGNDNHKK([IBJCGEMJMJL(null)][JetBrains.Annotations.NotNull] AHHIBBAIEPC EBBMEKOBJAL, [IBJCGEMJMJL(null)][JetBrains.Annotations.NotNull] IFMJIDCGCLC LJMNLKENKGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class FANFLDFAIDN : CHDNBFGGGBI
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Task NMNAHMFGEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7254090", Offset = "0x7253490", VA = "0x187254090", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Task FBCFFFFIENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7254120", Offset = "0x7253520", VA = "0x187254120", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool HLBAPFPPFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GGMMNIKGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string BAMGPKONIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GJEABAFLEFD CGAHNJILCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action KIKAHCLAMBC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7253920", Offset = "0x7252D20", VA = "0x187253920", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7253880", Offset = "0x7252C80", VA = "0x187253880", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action GIJELINNMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7253EA0", Offset = "0x72532A0", VA = "0x187253EA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7253F40", Offset = "0x7253340", VA = "0x187253F40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action BFMIDNLNJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7253D50", Offset = "0x7253150", VA = "0x187253D50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x72539C0", Offset = "0x7252DC0", VA = "0x1872539C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<ECDLMPFAGKE> LMCIIMGNACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7253DF0", Offset = "0x72531F0", VA = "0x187253DF0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7253FE0", Offset = "0x72533E0", VA = "0x187253FE0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FANFLDFAIDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7253C30", Offset = "0x7253030", VA = "0x187253C30", Slot = "12")]
	public Task HPHCPPKCEKM(string OPOKIOPOKBE, [Optional] JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x72541B0", Offset = "0x72535B0", VA = "0x1872541B0", Slot = "19")]
	public Task POBCLMOILMG(JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7253BA0", Offset = "0x7252FA0", VA = "0x187253BA0", Slot = "20")]
	public Task GAHHFBNPFPK(JEPPADOHMNE AGOFGEFAJDM, Dictionary<string, string> GDLLGFFMPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "21")]
	public bool NGGEOBINKCB(string FNBHEIHNCOL, bool FJOGPKKCMDC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7253AF0", Offset = "0x7252EF0", VA = "0x187253AF0", Slot = "22")]
	public ELDEJEIMAMA FHCKJNCCMCG(string JDJLOLIGKPL, bool FJOGPKKCMDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7253A60", Offset = "0x7252E60", VA = "0x187253A60", Slot = "23")]
	public EDOBDFIPKNK FFBMDHNLDIK(string GICEEKIGHOI, bool FJOGPKKCMDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7253CC0", Offset = "0x72530C0", VA = "0x187253CC0", Slot = "24")]
	public Task JLIOHLLGMND()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal class IPBHPEAPBBB : GJEABAFLEFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly MMGHLBONINL OHGPLAOENJA;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IReadOnlyDictionary<string, object> DAANDHOFMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xC75760", Offset = "0xC74B60", VA = "0x180C75760", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public IPBHPEAPBBB(MMGHLBONINL GBIDKKGJIIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface KCGPGKIBMPE
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HLJCPGKDMOP ILAEMIICJOL(string NLKJMGFMOOO);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface AKPEKCLMGOC
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public enum JIDBKLJICEH
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	long GIOILMPFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string GFAMGBCLJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string HGJABGKCKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool CBALJHFLJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long PPKKMDMKDMF();

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HPHOHJBOGOP(long JKHDHJCLOPL, bool IDNIBGLEFJO = true);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IOBPEBMKDBH(string BPPCEJGCMKA, string PAKCJCEHNIE, string LCLGMIAMOOG);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OBDOLAFKDBE(string BPPCEJGCMKA);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ODPFOJJHIKG(string BPPCEJGCMKA, string CBELMNGFMOM, string KNFKEHFIINA);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FGMOHIIHGCM(string BPDGMLOBIKL, object EPFPJPNDGFM, object JIFCGPEGHHA);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DAFNGCNFOMC(JIDBKLJICEH KPGDKMCLGLI, int IAKJCHAJGGI, [Optional] DODDCJEJIJO LBGNNMKOLFI, [Optional] string MBBMFJLOHJL, [Optional] string IFMHONGNKHP);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MAOKPDJHGHO(DODDCJEJIJO LBGNNMKOLFI, long EKHGBODBJDL, long OPMJALDBIEP, int OIKCKMHNIIJ, string MBBMFJLOHJL, int IAKJCHAJGGI);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void POJKGDCCAAH(DODDCJEJIJO LBGNNMKOLFI, bool JHGFMOPHGIB, [Optional] string IFMHONGNKHP);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JDOABNKABNL(DODDCJEJIJO LBGNNMKOLFI, bool JHGFMOPHGIB, [Optional] string IFMHONGNKHP);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AIGLACPCFIG(DODDCJEJIJO LBGNNMKOLFI, bool JHGFMOPHGIB, [Optional] string IFMHONGNKHP);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DDLHJMGJNFH(long FFFLOIOFAMB, string JPAOAPOJHJC);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface COINPGOHHMN
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string PEEDGMBEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
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
