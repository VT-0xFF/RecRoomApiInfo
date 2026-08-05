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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80E9B00", Offset = "0x80E8900", VA = "0x1880E9B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80E7010", Offset = "0x80E5E10", VA = "0x1880E7010", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x80EBC60", Offset = "0x80EAA60", VA = "0x1880EBC60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
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
		public AmplitudeAnalyticsClient.Settings EPKPPDBMIDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NNNAKEPIFFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, HNBEDMLJAOM
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum FKADGEAMOIB
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class ELEFDKIOHGB
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class JBCGIBLHDIA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int LIJGCKKFCDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> OELJGONOBNK;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
				public JBCGIBLHDIA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class GHHDPCAJMME
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
				public GHHDPCAJMME()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x80E4BF0", Offset = "0x80E39F0", VA = "0x1880E4BF0")]
				internal bool ECPOHBGDAKJ(JBCGIBLHDIA item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string DOMIMLBPEEM = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string GHADMHNDJBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<JBCGIBLHDIA> KMNIGOGKHEP;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? AEDEIANJHLE
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x80E38F0", Offset = "0x80E26F0", VA = "0x1880E38F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x80E48C0", Offset = "0x80E36C0", VA = "0x1880E48C0")]
			internal ELEFDKIOHGB(string FDEJPMMFODM, string GHIJHPFLKNF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x80E4710", Offset = "0x80E3510", VA = "0x1880E4710")]
			public int OHMDMBCAPPP([Optional] int? HGAEJEFIIFI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x80E3EF0", Offset = "0x80E2CF0", VA = "0x1880E3EF0")]
			public List<Dictionary<string, object>> KMMAEAABKII(int AAPNEHOCJPD, int? HGAEJEFIIFI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x80E4160", Offset = "0x80E2F60", VA = "0x1880E4160")]
			public void MCENMBBCFDF(AmplitudeAnalyticsIdentifyMessage ALGAKMGCCLO, bool KMBDDJOBOEN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x80E4200", Offset = "0x80E3000", VA = "0x1880E4200")]
			public void MCENMBBCFDF(Dictionary<string, object> ALGAKMGCCLO, bool KMBDDJOBOEN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x80E3770", Offset = "0x80E2570", VA = "0x1880E3770")]
			public void AGAGAPOOCIC(params Dictionary<string, object>[] FMPBGOEJLJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x80E3CB0", Offset = "0x80E2AB0", VA = "0x1880E3CB0")]
			public void JBDKLPDMLHD(List<Dictionary<string, object>> OPIOEBDKMKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x80E3670", Offset = "0x80E2470", VA = "0x1880E3670")]
			private void AFJAOLILLKB(Dictionary<string, object> ALGAKMGCCLO, bool KMBDDJOBOEN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x80E3990", Offset = "0x80E2790", VA = "0x1880E3990")]
			public void CJDLNFOEJDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x80E4310", Offset = "0x80E3110", VA = "0x1880E4310")]
			private void MFNKHHNCCKJ([Optional] string GLIMJFLPLJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x80E3B90", Offset = "0x80E2990", VA = "0x1880E3B90")]
			private static string CJPOCKDECIC(string HGMAIPELJHM, string OPGJHIOADCK)
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
			[Cpp2IlInjected.Address(RVA = "0x80EB880", Offset = "0x80EA680", VA = "0x1880EB880")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct DNAHGJCPGOP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int HGHNOLNJHMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string JALKIHLAOBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T AMAOCNDGEDG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class NJMINNPPBDF : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private PHFDFIIIMCE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public NJMINNPPBDF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x80E9320", Offset = "0x80E8120", VA = "0x1880E9320", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x80E9AB0", Offset = "0x80E88B0", VA = "0x1880E9AB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class LGOCCFJONDP : IEnumerator<object>, IEnumerator, IDisposable
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
			public EPDLJACCEEM quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public LGOCCFJONDP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x80E6D90", Offset = "0x80E5B90", VA = "0x1880E6D90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x80E6EA0", Offset = "0x80E5CA0", VA = "0x1880E6EA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class FIIDPKPFOBL : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public FIIDPKPFOBL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x80E4A30", Offset = "0x80E3830", VA = "0x1880E4A30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x80E4BA0", Offset = "0x80E39A0", VA = "0x1880E4BA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class BCDOHOHJNEE : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private PHFDFIIIMCE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public BCDOHOHJNEE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x80E0FA0", Offset = "0x80DFDA0", VA = "0x1880E0FA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x80E1200", Offset = "0x80E0000", VA = "0x1880E1200", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class PBKKPBIHEJB : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private PHFDFIIIMCE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public PBKKPBIHEJB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x80EAB10", Offset = "0x80E9910", VA = "0x1880EAB10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x80EAD60", Offset = "0x80E9B60", VA = "0x1880EAD60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class PEKAJFPEDNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public ELEFDKIOHGB cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public PEKAJFPEDNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x80EB200", Offset = "0x80EA000", VA = "0x1880EB200")]
			internal void JCLEEPJGAPH(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x80EADB0", Offset = "0x80E9BB0", VA = "0x1880EADB0")]
			internal void DJPBJNGMAPB(DNAHGJCPGOP<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class OAEFDHPKFAK : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private PHFDFIIIMCE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public ELEFDKIOHGB cache;

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
			private PEKAJFPEDNJ <>8__1;

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
			private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public OAEFDHPKFAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x80E9B80", Offset = "0x80E8980", VA = "0x1880E9B80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x80EA390", Offset = "0x80E9190", VA = "0x1880EA390", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class MAEPKDLIFKI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public MAEPKDLIFKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x587B4D0", Offset = "0x587A2D0", VA = "0x18587B4D0")]
			internal DNAHGJCPGOP<T> EODEFOONPCB(JHNMHKAJONC postResponse)
			{
				return default(DNAHGJCPGOP<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private DPCFCLHFNMK NNLOLIEJGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<AJDECJFHICI> BOBMIHJFGEF;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string PLJDEOHOELL = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string FDDGHIEFNCE = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string KHGOMKGPAAM = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int OJJFNDDAMJN = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int EBBMPNAFOFI = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int FKFFFAIDICI = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float OPKGHEKBFCA = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long CFLBDDJCGAO = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string KHADOKEACKL = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string LLIHPJFJEEA = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string ICAMBKNCOML = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string JIMIOPHCBDE = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool HPHHJJMHCEB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool LOKCPPPODHA;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int KLNDFJMMKHF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int JIGAIIPKGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private ODPKBFCGCCM CHKHFLBDKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private GOPLANBKADM EDEEKICOIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private JKNHGMAKBCG NBMKMDBDJCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool LBCAJDOOGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float ANKGCOPGJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float DGAGKBFNABG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int PHPNKHLDMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int FJKDPMNPDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? BDOFBLBNONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? LJFIFLKNDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long BGCHFAJNCIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string DBJNLDFBJNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string ELOCLDHLABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long MJCILKAJJHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string LBHALLHNHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string GLNKJLKFEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> NDOLAELMJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private FKADGEAMOIB COAMCPAINJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int IKBJKMODBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int MKGACGELFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float NHNGONHEMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool PPNEIDELELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool BMAAKJGNHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private ELEFDKIOHGB NKMEGDIEFAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private ELEFDKIOHGB EAKOFAONKLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private ELEFDKIOHGB BAIIHGALFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string HHCHOPPCDFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> OABMIPKEFDA;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo FHKACJNEELO;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string CDKBMONMIIE;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string JBCOBAIHJEP = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string AOCHOPGFPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string CMNCMAFJHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string FOMANDJDCBF;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private DPCFCLHFNMK FPLCBNABJHL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x80DC960", Offset = "0x80DB760", VA = "0x1880DC960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private AJDECJFHICI OLGJMKBLPLN
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x80DD550", Offset = "0x80DC350", VA = "0x1880DD550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int BEELHMAAPGM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x80DCAF0", Offset = "0x80DB8F0", VA = "0x1880DCAF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long AGHJGEKMBKN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x80DF430", Offset = "0x80DE230", VA = "0x1880DF430")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x80DF540", Offset = "0x80DE340", VA = "0x1880DF540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string AJBIJMGFNBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x80DF400", Offset = "0x80DE200", VA = "0x1880DF400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool GFIKDCHCPJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1716D70", Offset = "0x1715B70", VA = "0x181716D70", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x17155E0", Offset = "0x17143E0", VA = "0x1817155E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string KJJBHKILKNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB2FB40", Offset = "0xB2E940", VA = "0x180B2FB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB2AF20", Offset = "0xB29D20", VA = "0x180B2AF20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? NBKBDJDGPIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xB23880", Offset = "0xB22680", VA = "0x180B23880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB23890", Offset = "0xB22690", VA = "0x180B23890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EDIDLPEGMIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xB23870", Offset = "0xB22670", VA = "0x180B23870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xB4C8F0", Offset = "0xB4B6F0", VA = "0x180B4C8F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool NEIKKDOHJJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x80DF2D0", Offset = "0x80DE0D0", VA = "0x1880DF2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> ODCDJKGBMJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x80DF210", Offset = "0x80DE010", VA = "0x1880DF210")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x80DF480", Offset = "0x80DE280", VA = "0x1880DF480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x80D9CB0", Offset = "0x80D8AB0", VA = "0x1880D9CB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x80D9740", Offset = "0x80D8540", VA = "0x1880D9740")]
		private void APLFEIDCCLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x80DE850", Offset = "0x80DD650", VA = "0x1880DE850")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x80DD4A0", Offset = "0x80DC2A0", VA = "0x1880DD4A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80DEB80", Offset = "0x80DD980", VA = "0x1880DEB80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80DD5A0", Offset = "0x80DC3A0", VA = "0x1880DD5A0")]
		public BFMPGGMMDDD PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x80DC450", Offset = "0x80DB250", VA = "0x1880DC450")]
		[IteratorStateMachine(typeof(NJMINNPPBDF))]
		public IEnumerator<PHFDFIIIMCE> InitializeForLocalAccount(AmplitudeAnalyticsEvent EDFIEKDKFGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80DDF20", Offset = "0x80DCD20", VA = "0x1880DDF20")]
		public void SendAppEnterEvent(bool NMBCGEGLOMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x80DEB00", Offset = "0x80DD900", VA = "0x1880DEB00")]
		public void UpdateLastKnownInteractionCategory(string DKHAIOJDAGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x80DEA50", Offset = "0x80DD850", VA = "0x1880DEA50")]
		public void UpdateLastAliveTime(float GCGEIJPOBEE = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x80DC8B0", Offset = "0x80DB6B0", VA = "0x1880DC8B0")]
		private BFMPGGMMDDD KEDONNCMMAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x80DCCF0", Offset = "0x80DBAF0", VA = "0x1880DCCF0")]
		private BFMPGGMMDDD LOEGGCEEGCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80DE230", Offset = "0x80DD030", VA = "0x1880DE230")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x80DBDB0", Offset = "0x80DABB0", VA = "0x1880DBDB0")]
		[IteratorStateMachine(typeof(LGOCCFJONDP))]
		private IEnumerator IAILMDOLLDN(EPDLJACCEEM MJJHINIOIBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80DEE10", Offset = "0x80DDC10", VA = "0x1880DEE10")]
		[IteratorStateMachine(typeof(FIIDPKPFOBL))]
		public IEnumerator WaitForFlush(float BCGOOMJHCJF = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80DE930", Offset = "0x80DD730", VA = "0x1880DE930")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80DE870", Offset = "0x80DD670", VA = "0x1880DE870")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime GJEDFMHCPFI)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x80DBF50", Offset = "0x80DAD50", VA = "0x1880DBF50")]
		public static BNJNBHPIKOL Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x80D9B00", Offset = "0x80D8900", VA = "0x1880D9B00")]
		public static OGMGHFPFCAF AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string JIMIIFHHIOG, string KNDDOHBNCJE, PPELIFDNGKB AKJOMFGMADL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x80DB890", Offset = "0x80DA690", VA = "0x1880DB890")]
		public static OGMGHFPFCAF Event([JetBrains.Annotations.NotNull] string JIMIIFHHIOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x80DD730", Offset = "0x80DC530", VA = "0x1880DD730")]
		public static OGMGHFPFCAF PreviousSessionEvent([JetBrains.Annotations.NotNull] string JIMIIFHHIOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x80DC0F0", Offset = "0x80DAEF0", VA = "0x1880DC0F0")]
		public static OGMGHFPFCAF InitializeEvent(string KNDDOHBNCJE, int FNABGAANJJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80DE430", Offset = "0x80DD230", VA = "0x1880DE430")]
		public static OGMGHFPFCAF StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x80DB460", Offset = "0x80DA260", VA = "0x1880DB460")]
		public static OGMGHFPFCAF CreateOutOfSessionEvent(string JIMIIFHHIOG, bool MGPHNJBOFHL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x80DD0C0", Offset = "0x80DBEC0", VA = "0x1880DD0C0")]
		public static BFMPGGMMDDD LogOutOfSessionEvent(OGMGHFPFCAF GONPLCPGKFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80DCE60", Offset = "0x80DBC60", VA = "0x1880DCE60")]
		public void LogEventAsync(AmplitudeAnalyticsEvent GIGGHKENMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80DD290", Offset = "0x80DC090", VA = "0x1880DD290")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent GIGGHKENMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80DD3C0", Offset = "0x80DC1C0", VA = "0x1880DD3C0")]
		public void LogSerializedEventAsync(Dictionary<string, object> JJJBOFPAEDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80DCF90", Offset = "0x80DBD90", VA = "0x1880DCF90")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage EONDPDGJJFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80DC9F0", Offset = "0x80DB7F0", VA = "0x1880DC9F0")]
		private void LBMMJIHBEIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80DA310", Offset = "0x80D9110", VA = "0x1880DA310")]
		private void BGALGAGCOAE(Dictionary<string, object> PCOHPKACIBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x80DBCC0", Offset = "0x80DAAC0", VA = "0x1880DBCC0")]
		private void GNNCEPBNDCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x80D9570", Offset = "0x80D8370", VA = "0x1880D9570")]
		private void AENJPFHIBED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x80DBBA0", Offset = "0x80DA9A0", VA = "0x1880DBBA0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x80DBC30", Offset = "0x80DAA30", VA = "0x1880DBC30")]
		[IteratorStateMachine(typeof(BCDOHOHJNEE))]
		private IEnumerator<PHFDFIIIMCE> GEEAJFMPHOM(float BCGOOMJHCJF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x80DC4E0", Offset = "0x80DB2E0", VA = "0x1880DC4E0")]
		[IteratorStateMachine(typeof(PBKKPBIHEJB))]
		private IEnumerator<PHFDFIIIMCE> JCBJBPBOIBK(float BCGOOMJHCJF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80DB320", Offset = "0x80DA120", VA = "0x1880DB320")]
		[IteratorStateMachine(typeof(OAEFDHPKFAK))]
		private IEnumerator<PHFDFIIIMCE> CDBFGKCAEHG(ELEFDKIOHGB FAJIBAIPGCN, int? HGAEJEFIIFI, string CCMALHDLKMK, float BCGOOMJHCJF, Action<int> OIMGEMOJHGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x80DBE40", Offset = "0x80DAC40", VA = "0x1880DBE40")]
		private static void IIFOGCKBGGD(bool NPNNELJDLKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x80DC7E0", Offset = "0x80DB5E0", VA = "0x1880DC7E0")]
		private AIKJELDGMEB<DNAHGJCPGOP<Dictionary<string, object>>> JIHIKDDAIAG(string CCMALHDLKMK, string APNJHODGEAP, Dictionary<string, object> AMAOCNDGEDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x80DC570", Offset = "0x80DB370", VA = "0x1880DC570")]
		private AIKJELDGMEB<DNAHGJCPGOP<List<Dictionary<string, object>>>> JIHIKDDAIAG(string CCMALHDLKMK, string APNJHODGEAP, List<Dictionary<string, object>> AMAOCNDGEDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3292C10", Offset = "0x3291A10", VA = "0x183292C10")]
		private AIKJELDGMEB<DNAHGJCPGOP<T>> IIJPENNOGNF<T>(string MOGHIIFJJCA, string CCMALHDLKMK, string APNJHODGEAP, T AMAOCNDGEDG, Dictionary<string, object> MNIGDJECFPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x80DB400", Offset = "0x80DA200", VA = "0x1880DB400")]
		private bool CEJNJDBDMKL(float FNCCBDMLILN, float BCGOOMJHCJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x80DA5C0", Offset = "0x80D93C0", VA = "0x1880DA5C0")]
		private Dictionary<string, object> CBMHNIOGIJD(string CCMALHDLKMK, Dictionary<string, object> AMAOCNDGEDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x80DEF00", Offset = "0x80DDD00", VA = "0x1880DEF00")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAC1030", Offset = "0xABFE30", VA = "0x180AC1030", Slot = "6")]
		private bool DOPDOPHOHMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x80DB720", Offset = "0x80DA520", VA = "0x1880DB720")]
		[CompilerGenerated]
		private long ENJAGNKENHM()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x80DB450", Offset = "0x80DA250", VA = "0x1880DB450")]
		[CompilerGenerated]
		private void CLMNKLEGPLJ(int PBCCMHLNHKC)
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
			[Cpp2IlInjected.Address(RVA = "0x80E0230", Offset = "0x80DF030", VA = "0x1880E0230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x80E0300", Offset = "0x80DF100", VA = "0x1880E0300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x80E0270", Offset = "0x80DF070", VA = "0x1880E0270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x80E0350", Offset = "0x80DF150", VA = "0x1880E0350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x80E01F0", Offset = "0x80DEFF0", VA = "0x1880E01F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x80E02B0", Offset = "0x80DF0B0", VA = "0x1880E02B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA98240", Offset = "0xA97040", VA = "0x180A98240")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x80DF5A0", Offset = "0x80DE3A0", VA = "0x1880DF5A0")]
		public static OGMGHFPFCAF INIHOJCCLPM(string HNEGIKALKJG, [JetBrains.Annotations.NotNull] string HFNHABBHAHJ, long JOJHHDMMADL, long ECKAFBKCAMD, string KNDDOHBNCJE, string AKJOMFGMADL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x80DFA30", Offset = "0x80DE830", VA = "0x1880DFA30")]
		public static OGMGHFPFCAF NINGPKMICMM(string HNEGIKALKJG, [JetBrains.Annotations.NotNull] string HFNHABBHAHJ, long JOJHHDMMADL, long ECKAFBKCAMD, string KNDDOHBNCJE, long AHMCFLJHIML, string AKPBPIMKEAE, string EEIBEGJLEHO, string IHKHCKCGHHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x80E0050", Offset = "0x80DEE50", VA = "0x1880E0050")]
		private AmplitudeAnalyticsEvent(string HNEGIKALKJG, [JetBrains.Annotations.NotNull] string HFNHABBHAHJ, long JOJHHDMMADL, long ECKAFBKCAMD, string KNDDOHBNCJE, string AKJOMFGMADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xFD2390", Offset = "0xFD1190", VA = "0x180FD2390")]
		public void GLCGOJBMGHK(long PBEJEMIHPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x80DF7B0", Offset = "0x80DE5B0", VA = "0x1880DF7B0", Slot = "5")]
		public override void KCLAHDJCOFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x80DF8B0", Offset = "0x80DE6B0", VA = "0x1880DF8B0", Slot = "6")]
		public override void LAALDJCFGFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x80DFB90", Offset = "0x80DE990", VA = "0x1880DFB90", Slot = "4")]
		protected override Dictionary<string, object> OJGNOMHBEBM(Dictionary<string, object> MEPJMBPGFPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x80DF6A0", Offset = "0x80DE4A0", VA = "0x1880DF6A0")]
		private void JJBAAHDLHLA(string OPGJHIOADCK, string HGMAIPELJHM, bool CNOIFMGIMKF = false)
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
			[Cpp2IlInjected.Address(RVA = "0x80E3090", Offset = "0x80E1E90", VA = "0x1880E3090")]
			public void ABGIGIIBJNP(Dictionary<string, object> LGGJFIKKLJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
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
			[Cpp2IlInjected.Address(RVA = "0x80EB510", Offset = "0x80EA310", VA = "0x1880EB510")]
			public void ABGIGIIBJNP(Dictionary<string, object> KPDKLAKKLDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x15823C0", Offset = "0x15811C0", VA = "0x1815823C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x80E0410", Offset = "0x80DF210", VA = "0x1880E0410")]
		public static BNJNBHPIKOL INIHOJCCLPM(string HNEGIKALKJG, string KNDDOHBNCJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x80E0A50", Offset = "0x80DF850", VA = "0x1880E0A50")]
		protected AmplitudeAnalyticsIdentifyMessage(string HNEGIKALKJG, string KNDDOHBNCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x80E09C0", Offset = "0x80DF7C0", VA = "0x1880E09C0")]
		public Dictionary<string, object> PJJBBMDEGMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x80E0680", Offset = "0x80DF480", VA = "0x1880E0680", Slot = "4")]
		protected virtual Dictionary<string, object> OJGNOMHBEBM(Dictionary<string, object> MEPJMBPGFPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x80E05E0", Offset = "0x80DF3E0", VA = "0x1880E05E0")]
		protected void LCKAIIHHDOJ(string OPGJHIOADCK, Dictionary<string, object> DMEEOBMOMAF, Dictionary<string, object> MEJHLBFADFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x80E03A0", Offset = "0x80DF1A0", VA = "0x1880E03A0")]
		protected void DAELAFBMBBA(string OPGJHIOADCK, string HGMAIPELJHM, Dictionary<string, object> BBOCEFPLDIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x80E04D0", Offset = "0x80DF2D0", VA = "0x1880E04D0", Slot = "5")]
		public virtual void KCLAHDJCOFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x80E0560", Offset = "0x80DF360", VA = "0x1880E0560", Slot = "6")]
		public virtual void LAALDJCFGFE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BNJNBHPIKOL : BFDNIMGJHOB<AmplitudeAnalyticsIdentifyMessage, BNJNBHPIKOL>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override BNJNBHPIKOL JOKFCNACFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage PGENFBENOOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x80E12F0", Offset = "0x80E00F0", VA = "0x1880E12F0")]
	public BNJNBHPIKOL(AmplitudeAnalyticsIdentifyMessage JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x80E1250", Offset = "0x80E0050", VA = "0x1880E1250", Slot = "4")]
	public override void LAALDJCFGFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OGMGHFPFCAF : BFDNIMGJHOB<AmplitudeAnalyticsEvent, OGMGHFPFCAF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool FEJBGCKMNED;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override OGMGHFPFCAF JOKFCNACFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long GEJFPICMIFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x80EA890", Offset = "0x80E9690", VA = "0x1880EA890")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x80E92D0", Offset = "0x80E80D0", VA = "0x1880E92D0")]
	public OGMGHFPFCAF(AmplitudeAnalyticsEvent JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "5")]
	public override AmplitudeAnalyticsEvent PGENFBENOOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x80EA620", Offset = "0x80E9420", VA = "0x1880EA620", Slot = "4")]
	public override void LAALDJCFGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x80EA450", Offset = "0x80E9250", VA = "0x1880EA450")]
	public OGMGHFPFCAF AEFDIFPFDGB(string HIGEDKBAGHN, long[] HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3890", Offset = "0x3EB2690", VA = "0x183EB3890")]
	public OGMGHFPFCAF AEFDIFPFDGB<T>(string HIGEDKBAGHN, T[] HGMAIPELJHM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3890", Offset = "0x3EB2690", VA = "0x183EB3890")]
	public OGMGHFPFCAF AEFDIFPFDGB(string HIGEDKBAGHN, string[] HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3EB35E0", Offset = "0x3EB23E0", VA = "0x183EB35E0")]
	public OGMGHFPFCAF AEFDIFPFDGB<T>(string HIGEDKBAGHN, T HGMAIPELJHM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x80EA5A0", Offset = "0x80E93A0", VA = "0x1880EA5A0")]
	public OGMGHFPFCAF AEFDIFPFDGB(string HIGEDKBAGHN, long HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x80EA3E0", Offset = "0x80E91E0", VA = "0x1880EA3E0")]
	public OGMGHFPFCAF AEFDIFPFDGB(string HIGEDKBAGHN, string HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x80EA6C0", Offset = "0x80E94C0", VA = "0x1880EA6C0")]
	public OGMGHFPFCAF LIHDIBNJOKA(string HIGEDKBAGHN, object? HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x80EA6F0", Offset = "0x80E94F0", VA = "0x1880EA6F0")]
	public OGMGHFPFCAF LNNKPPBEBAL(string HIGEDKBAGHN, string HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x80EA790", Offset = "0x80E9590", VA = "0x1880EA790")]
	private OGMGHFPFCAF MDNDEIPANAP(string HIGEDKBAGHN, object HGMAIPELJHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MBKCDDLJJIO : OGMGHFPFCAF
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x80E92D0", Offset = "0x80E80D0", VA = "0x1880E92D0")]
	public MBKCDDLJJIO(AmplitudeAnalyticsEvent JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x80E9120", Offset = "0x80E7F20", VA = "0x1880E9120", Slot = "4")]
	public override void LAALDJCFGFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class BFDNIMGJHOB<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : BFDNIMGJHOB<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M JDFCBBCKOGJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR JOKFCNACFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public BFDNIMGJHOB(M JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x66E7760", Offset = "0x66E6560", VA = "0x1866E7760")]
	public BLDR AJFGFKNNOIB(AmplitudeAnalyticsIdentifyMessage.DeviceInfo GINCPDBODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x66E7830", Offset = "0x66E6630", VA = "0x1866E7830")]
	public BLDR FHKFJLPPMLE(AmplitudeAnalyticsIdentifyMessage.RevenueData PFDJDCMMIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x66E77B0", Offset = "0x66E65B0", VA = "0x1866E77B0")]
	public BLDR FHCHGPLDGHC(string HIGEDKBAGHN, string HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9320", Offset = "0x3EB8120", VA = "0x183EB9320")]
	public BLDR FHCHGPLDGHC<T>(string HIGEDKBAGHN, T HGMAIPELJHM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LAALDJCFGFE();

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x66E7880", Offset = "0x66E6680", VA = "0x1866E7880")]
	internal static string MDJOMDAPAHJ(string HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x66E7660", Offset = "0x66E6460", VA = "0x1866E7660")]
	private BLDR ADEOHMFKPCP(string HIGEDKBAGHN, object HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M PGENFBENOOF();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class OHHJLGAAHFK : ODPKBFCGCCM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct GIFEJMIBOOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<JHNMHKAJONC> <>t__builder;

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
		public OHHJLGAAHFK <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x80E4C60", Offset = "0x80E3A60", VA = "0x1880E4C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x80E5690", Offset = "0x80E4490", VA = "0x1880E5690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient CFNKOOKAGPG;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x80EA8B0", Offset = "0x80E96B0", VA = "0x1880EA8B0")]
	[NKOKDPHOKEP.APMGAGDLDLC]
	internal static void ACJCIAGNCOG(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x80EAA90", Offset = "0x80E9890", VA = "0x1880EAA90")]
	[RecRoom.NoEngine.Common.Preserve]
	public OHHJLGAAHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x80EA920", Offset = "0x80E9720", VA = "0x1880EA920", Slot = "4")]
	[AsyncStateMachine(typeof(GIFEJMIBOOB))]
	public Task<JHNMHKAJONC> LEECNKMLOKD(string MOGHIIFJJCA, string LEOCENBGHEP, string JIJCMIOCLKI, string CJJFMCGFGHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class HOEKGGFCJOE : ODPKBFCGCCM
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CMKCKIIPGBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<JHNMHKAJONC> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CMKCKIIPGBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x80E27B0", Offset = "0x80E15B0", VA = "0x1880E27B0")]
		internal void HPDEOCJJNFB(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct DHFODAFPNJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<JHNMHKAJONC> <>t__builder;

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
		private TaskAwaiter<JHNMHKAJONC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x80E2890", Offset = "0x80E1690", VA = "0x1880E2890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x80E2DE0", Offset = "0x80E1BE0", VA = "0x1880E2DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	[NKOKDPHOKEP.APMGAGDLDLC]
	internal static void HOPJAIDGJDJ(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	[RecRoom.NoEngine.Common.Preserve]
	public HOEKGGFCJOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x80E58A0", Offset = "0x80E46A0", VA = "0x1880E58A0", Slot = "4")]
	[AsyncStateMachine(typeof(DHFODAFPNJA))]
	public Task<JHNMHKAJONC> LEECNKMLOKD(string MOGHIIFJJCA, string LEOCENBGHEP, string JIJCMIOCLKI, string CJJFMCGFGHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HBMFMKOINEA
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> DMEFCIOKDKN;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x80E5700", Offset = "0x80E4500", VA = "0x1880E5700")]
	internal static bool HDJGELGHPLH(string OPGJHIOADCK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface ODPKBFCGCCM
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JHNMHKAJONC> LEECNKMLOKD(string MOGHIIFJJCA, string LEOCENBGHEP, string JIJCMIOCLKI, string CJJFMCGFGHP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct JHNMHKAJONC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int MFOHFMDHIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string DPHCIPJPCCG;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1942DD0", Offset = "0x1941BD0", VA = "0x181942DD0")]
	public JHNMHKAJONC(int HGHNOLNJHMA, string JALKIHLAOBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum JBBCIAECCLF
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
public class AHCACADGJMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private long PJGMEGKHKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private OGMGHFPFCAF EELCMODGOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool LAOMEDFNGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private float FMAPGJELDND;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x80D91A0", Offset = "0x80D7FA0", VA = "0x1880D91A0")]
	public AHCACADGJMA(string HGBHNAIFMHJ, float FMAPGJELDND = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3251D00", Offset = "0x3250B00", VA = "0x183251D00")]
	public void AEFDIFPFDGB<T>(string HIGEDKBAGHN, T HGMAIPELJHM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x80D8E10", Offset = "0x80D7C10", VA = "0x1880D8E10")]
	public void AEFDIFPFDGB(string HIGEDKBAGHN, string HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x80D8F50", Offset = "0x80D7D50", VA = "0x1880D8F50")]
	public void FKKPEONAGPN(string PDHDPHMEODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x80D8E90", Offset = "0x80D7C90", VA = "0x1880D8E90")]
	public void BAFJAHNFNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x80D9090", Offset = "0x80D7E90", VA = "0x1880D9090")]
	private void PLBACOFGJFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x80D9040", Offset = "0x80D7E40", VA = "0x1880D9040")]
	private bool JNKHCDJEFOD()
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
		public enum IKOFENLALON
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
		private IKOFENLALON parameterType;

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
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IKOFENLALON Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
			get
			{
				return default(IKOFENLALON);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAC2580", Offset = "0xAC1380", VA = "0x180AC2580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x80EB680", Offset = "0x80EA480", VA = "0x1880EB680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class HCABOHIEMIJ<T> : NHDNMMLDFPG<T>, KDHMCLBFFAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly HCNPPOOIDEE PCFBHCOALKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string OGEICBNAJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly string MPJGAOEBIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private T FIBPLJJCBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly T PGFMONBPOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool IAFMLJEBHPM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string GHFKFKMALEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x507BC80", Offset = "0x507AA80", VA = "0x18507BC80")]
	public HCABOHIEMIJ(HCNPPOOIDEE PCFBHCOALKL, string OGEICBNAJLO, string MPJGAOEBIDH, T PGFMONBPOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x507BB00", Offset = "0x507A900", VA = "0x18507BB00", Slot = "4")]
	public T LHIIIPAFAOC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x507B960", Offset = "0x507A760", VA = "0x18507B960", Slot = "6")]
	public void FMJEOCFJDAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
public class AEPILDAPNLB : MKKINKKENIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct LOPHPDHGOME : IEquatable<LOPHPDHGOME>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly string NKKNFLJNLII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly string ABMEFFBEALI;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
		public LOPHPDHGOME(string JIGJPCOOJHE, string ABPBAAPENCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x13E93E0", Offset = "0x13E81E0", VA = "0x1813E93E0", Slot = "4")]
		public bool Equals(LOPHPDHGOME FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x80E6EF0", Offset = "0x80E5CF0", VA = "0x1880E6EF0", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x80E6FA0", Offset = "0x80E5DA0", VA = "0x1880E6FA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private HCNPPOOIDEE PCFBHCOALKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Dictionary<LOPHPDHGOME, KDHMCLBFFAN> IPOJNAAACLD;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x80D8940", Offset = "0x80D7740", VA = "0x1880D8940")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	internal static void DBCFEKMBJDE(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x80D8C60", Offset = "0x80D7A60", VA = "0x1880D8C60")]
	[RecRoom.NoEngine.Common.Preserve]
	public AEPILDAPNLB([POMNKOCGGBN(null)][System.Diagnostics.CodeAnalysis.NotNull] HCNPPOOIDEE PCFBHCOALKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x80D89B0", Offset = "0x80D77B0", VA = "0x1880D89B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x80D8930", Offset = "0x80D7730", VA = "0x1880D8930")]
	private void ADEBFGPJGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x80D8AB0", Offset = "0x80D78B0", VA = "0x1880D8AB0")]
	private void NLHHHMDFNJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x324FD30", Offset = "0x324EB30", VA = "0x18324FD30", Slot = "4")]
	public NHDNMMLDFPG<T> JNKAIBGDGOE<T>(string OGEICBNAJLO, string LHDBHGPBLGO, T PGFMONBPOJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class EGBBAFCBPGP : FKNHDDDMCFM, MCNKJKEDJNO
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void EAGFFAEFNEN(CPDFNJLCHCI LANHIIENGLJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly NACMGDMLNOJ EFBENMHMCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly EAGFFAEFNEN BDBNEPDFMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly string AAAGEHONPNH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x12B0670", Offset = "0x12AF470", VA = "0x1812B0670", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string PECJMKNIBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1E83940", Offset = "0x1E82740", VA = "0x181E83940", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool PDBMJJDKFCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x80E3230", Offset = "0x80E2030", VA = "0x1880E3230", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool EDNHEBMENNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x80E3210", Offset = "0x80E2010", VA = "0x1880E3210", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyList<string> AEHLELONODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1E83630", Offset = "0x1E82430", VA = "0x181E83630", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1459050", Offset = "0x1457E50", VA = "0x181459050")]
	public EGBBAFCBPGP(NACMGDMLNOJ AFFIHAGMLBN, string POOLFGMOBNO, [Optional] EAGFFAEFNEN PIOFGNEECAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DFD0", Offset = "0x3B7CDD0", VA = "0x183B7DFD0", Slot = "9")]
	public T DPMBHNJHJDJ<T>(string OPGJHIOADCK, T PGFMONBPOJI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class MAEGGDACINM : HCNPPOOIDEE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KMEAFKLNEGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public GOPLANBKADM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public MAEGGDACINM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x80E63C0", Offset = "0x80E51C0", VA = "0x1880E63C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x80E6D30", Offset = "0x80E5B30", VA = "0x1880E6D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DJEFFCOOOCD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x80E2E50", Offset = "0x80E1C50", VA = "0x1880E2E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x80E3030", Offset = "0x80E1E30", VA = "0x1880E3030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct BADKNOAMMGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public GOPLANBKADM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public MAEGGDACINM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x80E0B10", Offset = "0x80DF910", VA = "0x1880E0B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x80E0F40", Offset = "0x80DFD40", VA = "0x1880E0F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct EGPIFBNAGJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public MAEGGDACINM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public GOPLANBKADM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x80E3250", Offset = "0x80E2050", VA = "0x1880E3250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x80E3610", Offset = "0x80E2410", VA = "0x1880E3610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly IReadOnlyDictionary<string, PGGFCLAOMDP> AEAIFDBFLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool HNMEBFOGBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private bool OMFNKKBDHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private TaskCompletionSource<bool> GCBPJIILCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private TaskCompletionSource<bool> NMIKAKLHJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly SemaphoreSlim EAJFBNIOFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private HPJGPLDANMP IOFDIMBKJPE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task IEMBDHIECEA
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x80E7300", Offset = "0x80E6100", VA = "0x1880E7300", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task DAIKELPDIMI
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80E75C0", Offset = "0x80E63C0", VA = "0x1880E75C0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool FJHMLMHPKMH
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MBCCPHCICAC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC30", Offset = "0xB7AA30", VA = "0x180B7BC30", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string KJJBHKILKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x80E74A0", Offset = "0x80E62A0", VA = "0x1880E74A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MJBLOPHGFJD HOKPMADIOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x80E7590", Offset = "0x80E6390", VA = "0x1880E7590", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PKKLGIHCJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x80E73E0", Offset = "0x80E61E0", VA = "0x1880E73E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x80E76B0", Offset = "0x80E64B0", VA = "0x1880E76B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BPLKGJHHLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x80E7BE0", Offset = "0x80E69E0", VA = "0x1880E7BE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x80E8DD0", Offset = "0x80E7BD0", VA = "0x1880E8DD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DCJELJJKGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x80E74B0", Offset = "0x80E62B0", VA = "0x1880E74B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x80E7260", Offset = "0x80E6060", VA = "0x1880E7260", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<CPDFNJLCHCI> MNKGGJDDMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x80E70A0", Offset = "0x80E5EA0", VA = "0x1880E70A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x80E7600", Offset = "0x80E6400", VA = "0x1880E7600", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x80E7480", Offset = "0x80E6280", VA = "0x1880E7480", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x80E7900", Offset = "0x80E6700", VA = "0x1880E7900", Slot = "12")]
	[AsyncStateMachine(typeof(KMEAFKLNEGE))]
	public Task IEHCJBEIMLK(string GHIJHPFLKNF, [Optional] GOPLANBKADM FPJFHBGIAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x80E7B30", Offset = "0x80E6930", VA = "0x1880E7B30", Slot = "24")]
	[AsyncStateMachine(typeof(DJEFFCOOOCD))]
	public Task JMIMPNAJPIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x80E8080", Offset = "0x80E6E80", VA = "0x1880E8080", Slot = "19")]
	[AsyncStateMachine(typeof(BADKNOAMMGO))]
	public Task NCCCMGGJABF(GOPLANBKADM FPJFHBGIAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x80E7340", Offset = "0x80E6140", VA = "0x1880E7340")]
	private void DIKJPPMNCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x80E7150", Offset = "0x80E5F50", VA = "0x1880E7150", Slot = "20")]
	[AsyncStateMachine(typeof(EGPIFBNAGJH))]
	public Task AOKOJEDFMOO(GOPLANBKADM FPJFHBGIAMK, Dictionary<string, string> ODJEOHMALCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x80E7C80", Offset = "0x80E6A80", VA = "0x1880E7C80", Slot = "21")]
	public bool MBEENHBDFFF(string FEBIOAGECIC, bool POINLMHKIGC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x80E8C10", Offset = "0x80E7A10", VA = "0x1880E8C10", Slot = "22")]
	public FKNHDDDMCFM ONLDHHAJLKI(string POOLFGMOBNO, bool POINLMHKIGC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x80E7D70", Offset = "0x80E6B70", VA = "0x1880E7D70")]
	private NACMGDMLNOJ MEAAFIBDHIH(string POOLFGMOBNO, bool POINLMHKIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x80E7750", Offset = "0x80E6550", VA = "0x1880E7750", Slot = "23")]
	public AFLEMEPCOKP HKECODCIOID(string JIGJPCOOJHE, bool POINLMHKIGC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x80E7F80", Offset = "0x80E6D80", VA = "0x1880E7F80")]
	private OAIEGJLHBHA MECNAKHPMBE(string JIGJPCOOJHE, bool POINLMHKIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x80E8330", Offset = "0x80E7130", VA = "0x1880E8330")]
	private AMCCOMGFJDD OIMCLKMKEHF(GOPLANBKADM FPJFHBGIAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x80E8180", Offset = "0x80E6F80", VA = "0x1880E8180")]
	private EKOHGCLMLID OAKIHBNCEIH(string GHIJHPFLKNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x80E7A20", Offset = "0x80E6820", VA = "0x1880E7A20")]
	private void JAAECNEGFFJ(string POOLFGMOBNO, NACMGDMLNOJ AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x80E9020", Offset = "0x80E7E20", VA = "0x1880E9020")]
	public MAEGGDACINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x80E7550", Offset = "0x80E6350", VA = "0x1880E7550")]
	[CompilerGenerated]
	private void GGAGBHPNNHC(CPDFNJLCHCI BIHPDMNFJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x80E7550", Offset = "0x80E6350", VA = "0x1880E7550")]
	[CompilerGenerated]
	private void NDOBLHONBII(CPDFNJLCHCI BIHPDMNFJGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class BPDNMDMHPAF : HCNPPOOIDEE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct AACDDOJMJEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public BPDNMDMHPAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public GOPLANBKADM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x80D7F50", Offset = "0x80D6D50", VA = "0x1880D7F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x80D88D0", Offset = "0x80D76D0", VA = "0x1880D88D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct ALHKHHGMBJB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x80D9330", Offset = "0x80D8130", VA = "0x1880D9330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xAE56D0", Offset = "0xAE44D0", VA = "0x180AE56D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private MAEGGDACINM FPGADPFIGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private TaskCompletionSource<bool> GCBPJIILCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private TaskCompletionSource<bool> NMIKAKLHJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Task GNJANOBNCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Task IKFJEAFFMPD;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private HCNPPOOIDEE CMGHMGMKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x80E2340", Offset = "0x80E1140", VA = "0x1880E2340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MBCCPHCICAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x80E23B0", Offset = "0x80E11B0", VA = "0x1880E23B0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool FJHMLMHPKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x80E1C00", Offset = "0x80E0A00", VA = "0x1880E1C00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task IEMBDHIECEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x80E1730", Offset = "0x80E0530", VA = "0x1880E1730", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task DAIKELPDIMI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x80E1A10", Offset = "0x80E0810", VA = "0x1880E1A10", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string KJJBHKILKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x80E1910", Offset = "0x80E0710", VA = "0x1880E1910", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public MJBLOPHGFJD HOKPMADIOPN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x80E19D0", Offset = "0x80E07D0", VA = "0x1880E19D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action BPLKGJHHLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x80E2070", Offset = "0x80E0E70", VA = "0x1880E2070", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x80E2480", Offset = "0x80E1280", VA = "0x1880E2480", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action PKKLGIHCJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x80E1840", Offset = "0x80E0640", VA = "0x1880E1840", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x80E1B60", Offset = "0x80E0960", VA = "0x1880E1B60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action DCJELJJKGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x80E1930", Offset = "0x80E0730", VA = "0x1880E1930", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x80E1510", Offset = "0x80E0310", VA = "0x1880E1510", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<CPDFNJLCHCI> MNKGGJDDMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x80E1340", Offset = "0x80E0140", VA = "0x1880E1340", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x80E1AB0", Offset = "0x80E08B0", VA = "0x1880E1AB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x80E2520", Offset = "0x80E1320", VA = "0x1880E2520")]
	[UnityEngine.Scripting.Preserve]
	public BPDNMDMHPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x80E17D0", Offset = "0x80E05D0", VA = "0x1880E17D0")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	internal static void DBCFEKMBJDE(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x80E1CD0", Offset = "0x80E0AD0", VA = "0x1880E1CD0")]
	internal static void HPJFNFJDLPP(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x80E18E0", Offset = "0x80E06E0", VA = "0x1880E18E0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x80E1D40", Offset = "0x80E0B40", VA = "0x1880E1D40", Slot = "12")]
	[AsyncStateMachine(typeof(AACDDOJMJEF))]
	public Task IEHCJBEIMLK(string GHIJHPFLKNF, [Optional] GOPLANBKADM FPJFHBGIAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x80E2230", Offset = "0x80E1030", VA = "0x1880E2230", Slot = "19")]
	public Task NCCCMGGJABF(GOPLANBKADM FPJFHBGIAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x80E13F0", Offset = "0x80E01F0", VA = "0x1880E13F0", Slot = "20")]
	public Task AOKOJEDFMOO(GOPLANBKADM FPJFHBGIAMK, Dictionary<string, string> ODJEOHMALCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x80E2110", Offset = "0x80E0F10", VA = "0x1880E2110", Slot = "21")]
	public bool MBEENHBDFFF(string FEBIOAGECIC, bool POINLMHKIGC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x80E23C0", Offset = "0x80E11C0", VA = "0x1880E23C0", Slot = "22")]
	public FKNHDDDMCFM ONLDHHAJLKI(string POOLFGMOBNO, bool POINLMHKIGC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x80E1C10", Offset = "0x80E0A10", VA = "0x1880E1C10", Slot = "23")]
	public AFLEMEPCOKP HKECODCIOID(string JIGJPCOOJHE, bool POINLMHKIGC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x80E1E90", Offset = "0x80E0C90", VA = "0x1880E1E90", Slot = "24")]
	public Task JMIMPNAJPIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x80E15B0", Offset = "0x80E03B0", VA = "0x1880E15B0")]
	private static void BHJDHMJJHPE(TaskCompletionSource<bool> CFGBMPECECB, Task HJMCBKGAGPL, Task NBGFMOCOLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x80E1FA0", Offset = "0x80E0DA0", VA = "0x1880E1FA0")]
	[AsyncStateMachine(typeof(ALHKHHGMBJB))]
	private static void KCLGNCFDPOE(Task MGEGHBBNKMN, TaskCompletionSource<bool> CFGBMPECECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xFCEBF0", Offset = "0xFCD9F0", VA = "0x180FCEBF0")]
	[CompilerGenerated]
	private void EDACOLFKDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1067590", Offset = "0x1066390", VA = "0x181067590")]
	[CompilerGenerated]
	private void LJFCALIBPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0xE40360", Offset = "0xE3F160", VA = "0x180E40360")]
	[CompilerGenerated]
	private void HINKJLFPLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x80E1E50", Offset = "0x80E0C50", VA = "0x1880E1E50")]
	[CompilerGenerated]
	private void JKHEFOADKJD(CPDFNJLCHCI BIHPDMNFJGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class ICCANPJPPCH : AFLEMEPCOKP, MCNKJKEDJNO
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate void BMIOINKMDIE(CPDFNJLCHCI LANHIIENGLJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly BMIOINKMDIE BDBNEPDFMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly OAIEGJLHBHA JDEADPLHHJI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x29FD070", Offset = "0x29FBE70", VA = "0x1829FD070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string PECJMKNIBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xF710E0", Offset = "0xF6FEE0", VA = "0x180F710E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x72FC7E0", Offset = "0x72FB5E0", VA = "0x1872FC7E0")]
	public ICCANPJPPCH(OAIEGJLHBHA OGEICBNAJLO, [Optional] BMIOINKMDIE PIOFGNEECAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3D449B0", Offset = "0x3D437B0", VA = "0x183D449B0", Slot = "6")]
	public T DPMBHNJHJDJ<T>(string OPGJHIOADCK, T PGFMONBPOJI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface DECCHMBHEJD
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[UsedImplicitly]
public class CJBHEMLLLNB : DECCHMBHEJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly BLJMCJPKDGJ DDDININOBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly List<LBLDOLHGJNH> FDBDFAMACFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly string NJCIDCLAPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly string ELOPJEOPFCI;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x80E25E0", Offset = "0x80E13E0", VA = "0x1880E25E0")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	[UsedImplicitly]
	internal static void ODAPPKPCBLD(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x80E2650", Offset = "0x80E1450", VA = "0x1880E2650")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CJBHEMLLLNB([JetBrains.Annotations.NotNull][POMNKOCGGBN(null)] BLJMCJPKDGJ DDDININOBBN, [POMNKOCGGBN(null)][JetBrains.Annotations.NotNull] MEJAFHGHGMF PAPDOAAABFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class IPFKDKFGOIP : HCNPPOOIDEE
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Task IEMBDHIECEA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x80E5BE0", Offset = "0x80E49E0", VA = "0x1880E5BE0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task DAIKELPDIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x80E5DB0", Offset = "0x80E4BB0", VA = "0x1880E5DB0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MBCCPHCICAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool FJHMLMHPKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string KJJBHKILKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MJBLOPHGFJD HOKPMADIOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action BPLKGJHHLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x80E6140", Offset = "0x80E4F40", VA = "0x1880E6140", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x80E6320", Offset = "0x80E5120", VA = "0x1880E6320", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action PKKLGIHCJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x80E5C70", Offset = "0x80E4A70", VA = "0x1880E5C70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x80E5EF0", Offset = "0x80E4CF0", VA = "0x1880E5EF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action DCJELJJKGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x80E5D10", Offset = "0x80E4B10", VA = "0x1880E5D10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x80E5B40", Offset = "0x80E4940", VA = "0x1880E5B40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<CPDFNJLCHCI> MNKGGJDDMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x80E5A00", Offset = "0x80E4800", VA = "0x1880E5A00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x80E5E40", Offset = "0x80E4C40", VA = "0x1880E5E40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	[RecRoom.NoEngine.Common.Preserve]
	public IPFKDKFGOIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x80E6020", Offset = "0x80E4E20", VA = "0x1880E6020", Slot = "12")]
	public Task IEHCJBEIMLK(string GHIJHPFLKNF, [Optional] GOPLANBKADM FPJFHBGIAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x80E61E0", Offset = "0x80E4FE0", VA = "0x1880E61E0", Slot = "19")]
	public Task NCCCMGGJABF(GOPLANBKADM FPJFHBGIAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x80E5AB0", Offset = "0x80E48B0", VA = "0x1880E5AB0", Slot = "20")]
	public Task AOKOJEDFMOO(GOPLANBKADM FPJFHBGIAMK, Dictionary<string, string> ODJEOHMALCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "21")]
	public bool MBEENHBDFFF(string FEBIOAGECIC, bool POINLMHKIGC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x80E6270", Offset = "0x80E5070", VA = "0x1880E6270", Slot = "22")]
	public FKNHDDDMCFM ONLDHHAJLKI(string POOLFGMOBNO, bool POINLMHKIGC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x80E5F90", Offset = "0x80E4D90", VA = "0x1880E5F90", Slot = "23")]
	public AFLEMEPCOKP HKECODCIOID(string JIGJPCOOJHE, bool POINLMHKIGC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x80E60B0", Offset = "0x80E4EB0", VA = "0x1880E60B0", Slot = "24")]
	public Task JMIMPNAJPIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class HPJGPLDANMP : MJBLOPHGFJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly AMCCOMGFJDD BANKPKGAJDO;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IReadOnlyDictionary<string, object> JDEBFBMMPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xF75AE0", Offset = "0xF748E0", VA = "0x180F75AE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public HPJGPLDANMP(AMCCOMGFJDD BMMBMCNCOMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface LKKDHLEICFO
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AHCACADGJMA DOONKFPBEBB(string HGBHNAIFMHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface JKNHGMAKBCG
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum HCMLOADMDPC
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
	public enum FAIDDADADEJ
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
	long CILEEDMLOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string EGOHFJONKBC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string AHJKKGPJMHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool GGIPAOKOMMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long OKNOAPAIGEO();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CNKBOPIKNID(long JOJHHDMMADL, bool CNOIFMGIMKF = true);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GDCCDBJNOPE(string KKBNGKDBMPF, string MMLABMCLNLN, string MFCHGNIDFBB);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EOPHJLFJKKF(Guid IPNLMCFENDF, Guid PFBIJHOAPJE, bool EPPFEKEKMED);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LBHPDHAPCKD(string KKBNGKDBMPF);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PJDJCENNMBI(string KKBNGKDBMPF, string DDFPPBEPPHH, string COHDIHGMGHK);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AGCDBDBJGLE(string KCAHPOJKMFB, object NIEGCCDJMJP, object MCKIJCNEADG);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GEJKNNNLLEE(HCMLOADMDPC CPOOLLEOHFP, int EBABNKEEAMD, [Optional] KJFALBFOFBC GDAIHJFICLN, [Optional] string AHKPOJAALAJ, [Optional] string DFOJBJDIKPM);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JNMFIHDHPJE(KJFALBFOFBC GDAIHJFICLN, long FILDMNEGHCH, long DJLDOIPDFLA, int HHOJDNJMKHA, string AHKPOJAALAJ, int EBABNKEEAMD);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KBIFBPJCPEK(KJFALBFOFBC GDAIHJFICLN, bool GELGIOCPDPF, [Optional] string DFOJBJDIKPM);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CICMKMCJJBG(KJFALBFOFBC GDAIHJFICLN, bool GELGIOCPDPF, [Optional] string DFOJBJDIKPM);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BIBLJGINBMO(KJFALBFOFBC GDAIHJFICLN, bool GELGIOCPDPF, [Optional] string DFOJBJDIKPM);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CFODMMPCFLG(long MDNJLMOPJKG, string NMBLAKMKEJJ);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MBLABGOFHED(string BCDABHDFJPD);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task AEFKPMCMNDP(FAIDDADADEJ IJBAPONMLAP, Guid? KECDHHOAEIN, List<KLAOHEICPLP> CCMNCKHIDHH, List<KLAOHEICPLP> ALJFDHEIPKE, Func<OBCKBDNDNAI, long> AHNJMCLPHAK, string BINIEENOJEB, bool? POAMNPEJCNG, [Optional] long? LNBHBEKCOGC);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface BJEHCNJJNJA
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string OGMIELMCABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
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
