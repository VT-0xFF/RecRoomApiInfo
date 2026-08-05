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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x70958C0", Offset = "0x70946C0", VA = "0x1870958C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
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
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7095050", Offset = "0x7093E50", VA = "0x187095050", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x709A500", Offset = "0x7099300", VA = "0x18709A500", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
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
		public AmplitudeAnalyticsClient.Settings OBPCDOLCDGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BAILLHFMKCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8F4420", Offset = "0x8F3220", VA = "0x1808F4420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, HECGOLGDACB
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum KMPAIBCBDPD
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class OABFDKLJLDP
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class ICEPLFCGLCO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int ICDMOOPFBAI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> CCFEHBLOGBC;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
				public ICEPLFCGLCO()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class ECOMEHLHMPA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
				public ECOMEHLHMPA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x7090E00", Offset = "0x708FC00", VA = "0x187090E00")]
				internal bool CJNACELNENA(ICEPLFCGLCO item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string DCEIEMHCGPH = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string FIJDAMLGBMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<ICEPLFCGLCO> LMPIKKLOJAM;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? KMPLONFKFPB
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x7096230", Offset = "0x7095030", VA = "0x187096230")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7096BE0", Offset = "0x70959E0", VA = "0x187096BE0")]
			internal OABFDKLJLDP(string ILDBBGIINGK, string DBHFMIBNLOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7095E70", Offset = "0x7094C70", VA = "0x187095E70")]
			public int DAOCCOEFEIM([Optional] int? AAJKMBOOHNO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7095940", Offset = "0x7094740", VA = "0x187095940")]
			public List<Dictionary<string, object>> BHHHDMNDBGH(int DKGKFELFJEP, int? AAJKMBOOHNO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x70962D0", Offset = "0x70950D0", VA = "0x1870962D0")]
			public void LLJKBEDGPJL(AmplitudeAnalyticsIdentifyMessage JOOHPPHJKMI, bool NEECJDLNDMP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7096370", Offset = "0x7095170", VA = "0x187096370")]
			public void LLJKBEDGPJL(Dictionary<string, object> JOOHPPHJKMI, bool NEECJDLNDMP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7095CE0", Offset = "0x7094AE0", VA = "0x187095CE0")]
			public void CEJMABBAFKB(params Dictionary<string, object>[] ILFNLONCOJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7096590", Offset = "0x7095390", VA = "0x187096590")]
			public void OAJEOKKJHCB(List<Dictionary<string, object>> CCIMKBAHPDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7096480", Offset = "0x7095280", VA = "0x187096480")]
			private void LOCGFPEAGBO(Dictionary<string, object> JOOHPPHJKMI, bool NEECJDLNDMP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7096020", Offset = "0x7094E20", VA = "0x187096020")]
			public void DDEOBOEKOLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x70967E0", Offset = "0x70955E0", VA = "0x1870967E0")]
			private void ODDNAIGPFCE([Optional] string IMEIKLAJEDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7095BB0", Offset = "0x70949B0", VA = "0x187095BB0")]
			private static string BPCGNFCCNAK(string IPHILEOFJLB, string FFOHLCGHDKA)
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
			[Cpp2IlInjected.Address(RVA = "0x709A0F0", Offset = "0x7098EF0", VA = "0x18709A0F0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct DHDMLPGBFDL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int LMINHIEJFGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string JANHGFDBFBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T HHMAPNDFNIP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MEGINCHJGOJ : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private HLGDLHCLDFE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
			[DebuggerHidden]
			public MEGINCHJGOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x70950E0", Offset = "0x7093EE0", VA = "0x1870950E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7095870", Offset = "0x7094670", VA = "0x187095870", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class EMBBILCPODL : IEnumerator<object>, IEnumerator, IDisposable
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
			public IFLNFKMEDGB quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
			[DebuggerHidden]
			public EMBBILCPODL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7090F50", Offset = "0x708FD50", VA = "0x187090F50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7091060", Offset = "0x708FE60", VA = "0x187091060", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class AMDBBAOOHMH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
			[DebuggerHidden]
			public AMDBBAOOHMH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7087670", Offset = "0x7086470", VA = "0x187087670", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x70877E0", Offset = "0x70865E0", VA = "0x1870877E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class PCBPFJIFMKE : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private HLGDLHCLDFE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
			[DebuggerHidden]
			public PCBPFJIFMKE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7098660", Offset = "0x7097460", VA = "0x187098660", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x70988C0", Offset = "0x70976C0", VA = "0x1870988C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ODGEABHJLIC : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private HLGDLHCLDFE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
			[DebuggerHidden]
			public ODGEABHJLIC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7096F00", Offset = "0x7095D00", VA = "0x187096F00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7097160", Offset = "0x7095F60", VA = "0x187097160", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class CEFMIBIHDPF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public OABFDKLJLDP cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public CEFMIBIHDPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x708F810", Offset = "0x708E610", VA = "0x18708F810")]
			internal void GIGMGKDOOFH(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x708F3C0", Offset = "0x708E1C0", VA = "0x18708F3C0")]
			internal void DKOOPMLFOFN(DHDMLPGBFDL<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class LKMBFJKKOMD : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private HLGDLHCLDFE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public OABFDKLJLDP cache;

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
			private CEFMIBIHDPF <>8__1;

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
			private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
			[DebuggerHidden]
			public LKMBFJKKOMD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x70945A0", Offset = "0x70933A0", VA = "0x1870945A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7094DC0", Offset = "0x7093BC0", VA = "0x187094DC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class IFIGHIGDGBO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public IFIGHIGDGBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x46DB6E0", Offset = "0x46DA4E0", VA = "0x1846DB6E0")]
			internal DHDMLPGBFDL<T> POHIEJNFGMM(OAGKOOBICFK postResponse)
			{
				return default(DHDMLPGBFDL<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private PIDAIGGFAFH KNMJFDABFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<CFMDFPPKOBB> EDOEJMPLIKM;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string LKNFEBDEJBO = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string AAKPLBHBCCO = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string DPBFMMAGCNC = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int PEFKJBKNGEE = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int FBLELNNCNCK = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int PAIBCACIMDC = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float KAGPIINEBFJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long CAODMNNEAAG = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string BDADLDFFAMD = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string CHNCKCBHHKN = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string GPEIAANGGBM = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string MGCNJBBBDAP = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool EFABJFPBMLP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool JMJCJFAFBPA;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int CALMPMNHJEK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int FOGMEMLOAIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private KOOPDCBCACL BBJKMAFKJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private PNBANFBGNJH LBGLFNEPOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private APGKKIHKPFK NGOGICJFNDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool PNGBHFMKMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float NECDPNCPOIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float BNHIBDOGAJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int MDOHHADHKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int DKEIJIOPKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? GDFEJKLHIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? CEBIJLHNKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long GFCOOEDHPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string ODDMNBJCMLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string AIPLGFEPLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long CBKOAPIJKFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string HCCDHPHLJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string HJIFLOFCOKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> NOGIOHIIFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private KMPAIBCBDPD MJIHDCHFHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int JKJJHHHEEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int MADGJNHHAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float LGDMJNDOLPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool PEKMPKEGMJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool EJOEMGBHNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private OABFDKLJLDP PNDGNGECNHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private OABFDKLJLDP ENGNAKBNING;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private OABFDKLJLDP JGLJBOAPIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string KCJOGIAJIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> JHGCKGJIECE;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo EEKLGHPAJLO;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string EEPKANFICKG;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string HDONHMHFPJA = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string CMOAJEKAENI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string PINBHGLJLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string NDJBGKNBPNL;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private PIDAIGGFAFH MKCOJHBKIEP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x70880D0", Offset = "0x7086ED0", VA = "0x1870880D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private CFMDFPPKOBB PILMPGPPGPE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x708A100", Offset = "0x7088F00", VA = "0x18708A100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int HHGFODMNGGP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x708AD60", Offset = "0x7089B60", VA = "0x18708AD60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long MJFCLGNCPEE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x708D720", Offset = "0x708C520", VA = "0x18708D720")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x708D830", Offset = "0x708C630", VA = "0x18708D830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string BIGJGKAHJBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x708D6F0", Offset = "0x708C4F0", VA = "0x18708D6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JHOHEJMLBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x961BC0", Offset = "0x9609C0", VA = "0x180961BC0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1261C50", Offset = "0x1260A50", VA = "0x181261C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string JHBJMPIMGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x969740", Offset = "0x968540", VA = "0x180969740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA59030", Offset = "0xA57E30", VA = "0x180A59030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? IJGGEDENBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA59510", Offset = "0xA58310", VA = "0x180A59510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA58C10", Offset = "0xA57A10", VA = "0x180A58C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JBHPGKILOML
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xCA4000", Offset = "0xCA2E00", VA = "0x180CA4000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x114B820", Offset = "0x114A620", VA = "0x18114B820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool FBPCPLHEBBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x708D600", Offset = "0x708C400", VA = "0x18708D600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> BANCDMKLNCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x708D540", Offset = "0x708C340", VA = "0x18708D540")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x708D770", Offset = "0x708C570", VA = "0x18708D770")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x70879E0", Offset = "0x70867E0", VA = "0x1870879E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7088160", Offset = "0x7086F60", VA = "0x187088160")]
		private void CAIEBAJEELG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x708CB70", Offset = "0x708B970", VA = "0x18708CB70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x708B650", Offset = "0x708A450", VA = "0x18708B650", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x708CEA0", Offset = "0x708BCA0", VA = "0x18708CEA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x708B8E0", Offset = "0x708A6E0", VA = "0x18708B8E0")]
		public LDHIGNIGDAL PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x708A650", Offset = "0x7089450", VA = "0x18708A650")]
		[IteratorStateMachine(typeof(MEGINCHJGOJ))]
		public IEnumerator<HLGDLHCLDFE> InitializeForLocalAccount(AmplitudeAnalyticsEvent LKHGEPDBEPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x708C240", Offset = "0x708B040", VA = "0x18708C240")]
		public void SendAppEnterEvent(bool MCHMPHIJIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x708CE20", Offset = "0x708BC20", VA = "0x18708CE20")]
		public void UpdateLastKnownInteractionCategory(string BOCIGMAPNPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x708CD70", Offset = "0x708BB70", VA = "0x18708CD70")]
		public void UpdateLastAliveTime(float GLDLKCMKFON = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x708A040", Offset = "0x7088E40", VA = "0x18708A040")]
		private LDHIGNIGDAL HGAMAPMHBLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x708B4E0", Offset = "0x708A2E0", VA = "0x18708B4E0")]
		private LDHIGNIGDAL OMBBPKIPGBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x708C550", Offset = "0x708B350", VA = "0x18708C550")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7089ED0", Offset = "0x7088CD0", VA = "0x187089ED0")]
		[IteratorStateMachine(typeof(EMBBILCPODL))]
		private IEnumerator GEJENPBHAAJ(IFLNFKMEDGB CCCHJAEKPJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x708D130", Offset = "0x708BF30", VA = "0x18708D130")]
		[IteratorStateMachine(typeof(AMDBBAOOHMH))]
		public IEnumerator WaitForFlush(float BHBDEJJKCAE = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x708CC50", Offset = "0x708BA50", VA = "0x18708CC50")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x708CB90", Offset = "0x708B990", VA = "0x18708CB90")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime LEAPIIAHEEF)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x708A150", Offset = "0x7088F50", VA = "0x18708A150")]
		public static KHLIFMDIEKC Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7087830", Offset = "0x7086630", VA = "0x187087830")]
		public static BCBDEMBMMLC AccountSelectionPostLoginEvent([NotNull] string PDFBIALKONF, string OOLFINCIKKG, HLMPGEIJDPO PCAPJDJIAIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7088C30", Offset = "0x7087A30", VA = "0x187088C30")]
		public static BCBDEMBMMLC Event([NotNull] string PDFBIALKONF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x708BA80", Offset = "0x708A880", VA = "0x18708BA80")]
		public static BCBDEMBMMLC PreviousSessionEvent([NotNull] string PDFBIALKONF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x708A2F0", Offset = "0x70890F0", VA = "0x18708A2F0")]
		public static BCBDEMBMMLC InitializeEvent(string OOLFINCIKKG, int AEPMEIAEPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x708C750", Offset = "0x708B550", VA = "0x18708C750")]
		public static BCBDEMBMMLC StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7088860", Offset = "0x7087660", VA = "0x187088860")]
		public static BCBDEMBMMLC CreateOutOfSessionEvent(string PDFBIALKONF, bool NMCIBAHFIDJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x708A970", Offset = "0x7089770", VA = "0x18708A970")]
		public static LDHIGNIGDAL LogOutOfSessionEvent(BCBDEMBMMLC GLDJOKMCDEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x708A6F0", Offset = "0x70894F0", VA = "0x18708A6F0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent AOIAHMKBHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x708AB40", Offset = "0x7089940", VA = "0x18708AB40")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent AOIAHMKBHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x708AC80", Offset = "0x7089A80", VA = "0x18708AC80")]
		public void LogSerializedEventAsync(Dictionary<string, object> BCCLAMCFKFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x708A830", Offset = "0x7089630", VA = "0x18708A830")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage IKAHNHAEIHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x708B390", Offset = "0x708A190", VA = "0x18708B390")]
		private void MNNEIANIJLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x708B0D0", Offset = "0x7089ED0", VA = "0x18708B0D0")]
		private void MMJBLIIOOIF(Dictionary<string, object> DMALMKGJLDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7088B40", Offset = "0x7087940", VA = "0x187088B40")]
		private void ECHJIEILFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x708B710", Offset = "0x708A510", VA = "0x18708B710")]
		private void PBFNAMOIOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7089D30", Offset = "0x7088B30", VA = "0x187089D30")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7089CA0", Offset = "0x7088AA0", VA = "0x187089CA0")]
		[IteratorStateMachine(typeof(PCBPFJIFMKE))]
		private IEnumerator<HLGDLHCLDFE> FLDBBLODEHA(float BHBDEJJKCAE = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7088040", Offset = "0x7086E40", VA = "0x187088040")]
		[IteratorStateMachine(typeof(ODGEABHJLIC))]
		private IEnumerator<HLGDLHCLDFE> BGJENGOPMPN(float BHBDEJJKCAE = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7089F60", Offset = "0x7088D60", VA = "0x187089F60")]
		[IteratorStateMachine(typeof(LKMBFJKKOMD))]
		private IEnumerator<HLGDLHCLDFE> GJGBAJAHGJB(OABFDKLJLDP IEEJJABBJCG, int? AAJKMBOOHNO, string HCGHKGHKIPM, float BHBDEJJKCAE, Action<int> EFDBDBMDHPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7089DC0", Offset = "0x7088BC0", VA = "0x187089DC0")]
		private static void GDGOAKAGMJO(bool PFLPPGJHMLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7088520", Offset = "0x7087320", VA = "0x187088520")]
		private MNHDJBCOCND<DHDMLPGBFDL<Dictionary<string, object>>> CMPOLOHNCIM(string HCGHKGHKIPM, string DDIBFNNEDBH, Dictionary<string, object> HHMAPNDFNIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x70885F0", Offset = "0x70873F0", VA = "0x1870885F0")]
		private MNHDJBCOCND<DHDMLPGBFDL<List<Dictionary<string, object>>>> CMPOLOHNCIM(string HCGHKGHKIPM, string DDIBFNNEDBH, List<Dictionary<string, object>> HHMAPNDFNIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3A63B10", Offset = "0x3A62910", VA = "0x183A63B10")]
		private MNHDJBCOCND<DHDMLPGBFDL<T>> EMDIFHAJPGH<T>(string FEMABBCJEFJ, string HCGHKGHKIPM, string DDIBFNNEDBH, T HHMAPNDFNIP, Dictionary<string, object> BLHIEDAGELH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x708B490", Offset = "0x708A290", VA = "0x18708B490")]
		private bool NPLJDBBJJNO(float JHKFEMICOCN, float BHBDEJJKCAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7088F40", Offset = "0x7087D40", VA = "0x187088F40")]
		private Dictionary<string, object> FBMKBOAMEGJ(string HCGHKGHKIPM, Dictionary<string, object> HHMAPNDFNIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x708D220", Offset = "0x708C020", VA = "0x18708D220")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9226D0", Offset = "0x9214D0", VA = "0x1809226D0", Slot = "6")]
		private bool DDBKHOBDKBO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x708AF60", Offset = "0x7089D60", VA = "0x18708AF60")]
		[CompilerGenerated]
		private long MCCJJOMPMBG()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x708A6E0", Offset = "0x70894E0", VA = "0x18708A6E0")]
		[CompilerGenerated]
		private void KNDJGNFNIOM(int OICLDAOJEFK)
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
			[Cpp2IlInjected.Address(RVA = "0x708E530", Offset = "0x708D330", VA = "0x18708E530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x708E610", Offset = "0x708D410", VA = "0x18708E610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x708E570", Offset = "0x708D370", VA = "0x18708E570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x708E670", Offset = "0x708D470", VA = "0x18708E670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x708E4F0", Offset = "0x708D2F0", VA = "0x18708E4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x708E5B0", Offset = "0x708D3B0", VA = "0x18708E5B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8F4240", Offset = "0x8F3040", VA = "0x1808F4240")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x708D990", Offset = "0x708C790", VA = "0x18708D990")]
		public static BCBDEMBMMLC DCMOGLEGFAE(string BBDOELHAPOH, [NotNull] string CMBLAJKGABB, long MNGOHBKCBKP, long LDAHFMAONKF, string OOLFINCIKKG, string PCAPJDJIAIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x708DA90", Offset = "0x708C890", VA = "0x18708DA90")]
		public static BCBDEMBMMLC EKHBJDLDBIF(string BBDOELHAPOH, [NotNull] string CMBLAJKGABB, long MNGOHBKCBKP, long LDAHFMAONKF, string OOLFINCIKKG, long LMEPAFMGLHC, string PJIFENGGNJK, string DMOEBGONPMH, string IMFGIIKFNEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x708E350", Offset = "0x708D150", VA = "0x18708E350")]
		private AmplitudeAnalyticsEvent(string BBDOELHAPOH, [NotNull] string CMBLAJKGABB, long MNGOHBKCBKP, long LDAHFMAONKF, string OOLFINCIKKG, string PCAPJDJIAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD0FB60", Offset = "0xD0E960", VA = "0x180D0FB60")]
		public void KDBPMJNILON(long JJIJIDIJLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x708D890", Offset = "0x708C690", VA = "0x18708D890", Slot = "5")]
		public override void BOJNKDDHCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x708DD00", Offset = "0x708CB00", VA = "0x18708DD00", Slot = "6")]
		public override void LLIGLAPNLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x708DE80", Offset = "0x708CC80", VA = "0x18708DE80", Slot = "4")]
		protected override Dictionary<string, object> PCKHLEPIGBM(Dictionary<string, object> JLKPFGCJBOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x708DBF0", Offset = "0x708C9F0", VA = "0x18708DBF0")]
		private void FGHAKKOKLJH(string FFOHLCGHDKA, string IPHILEOFJLB, bool IBONICHNIMN = false)
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
			[Cpp2IlInjected.Address(RVA = "0x7090C80", Offset = "0x708FA80", VA = "0x187090C80")]
			public void OKDGCKFJOAB(Dictionary<string, object> DEJACFIJKGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
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
			[Cpp2IlInjected.Address(RVA = "0x7099D70", Offset = "0x7098B70", VA = "0x187099D70")]
			public void OKDGCKFJOAB(Dictionary<string, object> IGOBHCNLOGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x110C330", Offset = "0x110B130", VA = "0x18110C330")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x708E760", Offset = "0x708D560", VA = "0x18708E760")]
		public static KHLIFMDIEKC DCMOGLEGFAE(string BBDOELHAPOH, string OOLFINCIKKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x708ED80", Offset = "0x708DB80", VA = "0x18708ED80")]
		protected AmplitudeAnalyticsIdentifyMessage(string BBDOELHAPOH, string OOLFINCIKKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x708EC50", Offset = "0x708DA50", VA = "0x18708EC50")]
		public Dictionary<string, object> PEDIIMCCKKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x708E910", Offset = "0x708D710", VA = "0x18708E910", Slot = "4")]
		protected virtual Dictionary<string, object> PCKHLEPIGBM(Dictionary<string, object> JLKPFGCJBOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x708ECE0", Offset = "0x708DAE0", VA = "0x18708ECE0")]
		protected void PLIBKKIIILF(string FFOHLCGHDKA, Dictionary<string, object> DEHHOKDILKO, Dictionary<string, object> CFNHFFOGPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x708E8A0", Offset = "0x708D6A0", VA = "0x18708E8A0")]
		protected void NCGGBMKHIDJ(string FFOHLCGHDKA, string IPHILEOFJLB, Dictionary<string, object> BADGNDIADDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x708E6D0", Offset = "0x708D4D0", VA = "0x18708E6D0", Slot = "5")]
		public virtual void BOJNKDDHCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x708E820", Offset = "0x708D620", VA = "0x18708E820", Slot = "6")]
		public virtual void LLIGLAPNLMD()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KHLIFMDIEKC : AEEGNEIIMIC<AmplitudeAnalyticsIdentifyMessage, KHLIFMDIEKC>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override KHLIFMDIEKC PMDJHGPBOGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage LKFEBNKGPOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7093850", Offset = "0x7092650", VA = "0x187093850")]
	public KHLIFMDIEKC(AmplitudeAnalyticsIdentifyMessage KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x70937B0", Offset = "0x70925B0", VA = "0x1870937B0", Slot = "4")]
	public override void LLIGLAPNLMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BCBDEMBMMLC : AEEGNEIIMIC<AmplitudeAnalyticsEvent, BCBDEMBMMLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool BEOAOBNBCNL;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override BCBDEMBMMLC PMDJHGPBOGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long ADCLPAHBMBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x708EFE0", Offset = "0x708DDE0", VA = "0x18708EFE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x708F1C0", Offset = "0x708DFC0", VA = "0x18708F1C0")]
	public BCBDEMBMMLC(AmplitudeAnalyticsEvent KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "5")]
	public override AmplitudeAnalyticsEvent LKFEBNKGPOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x708F030", Offset = "0x708DE30", VA = "0x18708F030", Slot = "4")]
	public override void LLIGLAPNLMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x306FD90", Offset = "0x306EB90", VA = "0x18306FD90")]
	public BCBDEMBMMLC PHBIGIKBCJM<T>(string AMBDMECJFHI, T[] IPHILEOFJLB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x306FD90", Offset = "0x306EB90", VA = "0x18306FD90")]
	public BCBDEMBMMLC PHBIGIKBCJM(string AMBDMECJFHI, string[] IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x306FAE0", Offset = "0x306E8E0", VA = "0x18306FAE0")]
	public BCBDEMBMMLC PHBIGIKBCJM<T>(string AMBDMECJFHI, T IPHILEOFJLB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x708F140", Offset = "0x708DF40", VA = "0x18708F140")]
	public BCBDEMBMMLC PHBIGIKBCJM(string AMBDMECJFHI, long IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x708F0D0", Offset = "0x708DED0", VA = "0x18708F0D0")]
	public BCBDEMBMMLC PHBIGIKBCJM(string AMBDMECJFHI, string IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x708F000", Offset = "0x708DE00", VA = "0x18708F000")]
	public BCBDEMBMMLC IBAFKDHFBJN(string AMBDMECJFHI, object? IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x708EF40", Offset = "0x708DD40", VA = "0x18708EF40")]
	public BCBDEMBMMLC FAFAOONCHHG(string AMBDMECJFHI, string IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x708EE40", Offset = "0x708DC40", VA = "0x18708EE40")]
	private BCBDEMBMMLC DIAIBDFLEPN(string AMBDMECJFHI, object IPHILEOFJLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CAONKAIPJLA : BCBDEMBMMLC
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x708F1C0", Offset = "0x708DFC0", VA = "0x18708F1C0")]
	public CAONKAIPJLA(AmplitudeAnalyticsEvent KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x708F210", Offset = "0x708E010", VA = "0x18708F210", Slot = "4")]
	public override void LLIGLAPNLMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class AEEGNEIIMIC<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : AEEGNEIIMIC<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M KKBJAPCBOHH;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR PMDJHGPBOGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public AEEGNEIIMIC(M KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x447F5A0", Offset = "0x447E3A0", VA = "0x18447F5A0")]
	public BLDR GPGFIMNCAME(AmplitudeAnalyticsIdentifyMessage.DeviceInfo MCFGCDJKLNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x447F550", Offset = "0x447E350", VA = "0x18447F550")]
	public BLDR GJPCMABBODN(AmplitudeAnalyticsIdentifyMessage.RevenueData OLDDBLGBDKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x447F620", Offset = "0x447E420", VA = "0x18447F620")]
	public BLDR HHDPIIKOFFG(string AMBDMECJFHI, string IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B9BD20", Offset = "0x2B9AB20", VA = "0x182B9BD20")]
	public BLDR HHDPIIKOFFG<T>(string AMBDMECJFHI, T IPHILEOFJLB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LLIGLAPNLMD();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x447F5F0", Offset = "0x447E3F0", VA = "0x18447F5F0")]
	internal static string HABHPGKLHGL(string IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x447F6C0", Offset = "0x447E4C0", VA = "0x18447F6C0")]
	private BLDR JCAECPMFMKM(string AMBDMECJFHI, object IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M LKFEBNKGPOB();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class LADDHPGPOCM : KOOPDCBCACL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct KMINIEOGCOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<OAGKOOBICFK> <>t__builder;

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
		public LADDHPGPOCM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x70938A0", Offset = "0x70926A0", VA = "0x1870938A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x70942D0", Offset = "0x70930D0", VA = "0x1870942D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient LNGNDAFNLJL;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7094340", Offset = "0x7093140", VA = "0x187094340")]
	[FOLINPJCBJN.HMBDLNHFFEJ]
	internal static void IMNCOPPGKEN(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7094520", Offset = "0x7093320", VA = "0x187094520")]
	[RecRoom.NoEngine.Common.Preserve]
	public LADDHPGPOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x70943B0", Offset = "0x70931B0", VA = "0x1870943B0", Slot = "4")]
	[AsyncStateMachine(typeof(KMINIEOGCOJ))]
	public Task<OAGKOOBICFK> KEPNBKEFJOA(string FEMABBCJEFJ, string NMAEHAJMEMN, string CMJAGLINAJO, string OOEBIFOILJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class OFBPNBPPEDJ : KOOPDCBCACL
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class EIHAJPKFDBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<OAGKOOBICFK> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public EIHAJPKFDBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7090E70", Offset = "0x708FC70", VA = "0x187090E70")]
		internal void LMFIEKJEMMB(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct CEKPFGJJOJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<OAGKOOBICFK> <>t__builder;

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
		private TaskAwaiter<OAGKOOBICFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x708FB30", Offset = "0x708E930", VA = "0x18708FB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7090080", Offset = "0x708EE80", VA = "0x187090080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	[FOLINPJCBJN.HMBDLNHFFEJ]
	internal static void ECCENLEPHFA(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	[RecRoom.NoEngine.Common.Preserve]
	public OFBPNBPPEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x70971B0", Offset = "0x7095FB0", VA = "0x1870971B0", Slot = "4")]
	[AsyncStateMachine(typeof(CEKPFGJJOJD))]
	public Task<OAGKOOBICFK> KEPNBKEFJOA(string FEMABBCJEFJ, string NMAEHAJMEMN, string CMJAGLINAJO, string OOEBIFOILJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OCEJAMEJPKE
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> KDMBPKCCGAE;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7096D50", Offset = "0x7095B50", VA = "0x187096D50")]
	internal static bool PMDMAFDMBEO(string FFOHLCGHDKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KOOPDCBCACL
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OAGKOOBICFK> KEPNBKEFJOA(string FEMABBCJEFJ, string NMAEHAJMEMN, string CMJAGLINAJO, string OOEBIFOILJH);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct OAGKOOBICFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int PHOKHCOPAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string MHAHDLBLODA;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x14426C0", Offset = "0x14414C0", VA = "0x1814426C0")]
	public OAGKOOBICFK(int LMINHIEJFGE, string JANHGFDBFBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum BEDGHDEOEHD
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
public class DLKOCCGEJEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private long KKOGDHPDCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private BCBDEMBMMLC BFMJINOLMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool JDGPCCFHNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float DPGFPNEFGIM;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7090920", Offset = "0x708F720", VA = "0x187090920")]
	public DLKOCCGEJEA(string LJOEOLIACBE, float DPGFPNEFGIM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3147880", Offset = "0x3146680", VA = "0x183147880")]
	public void PHBIGIKBCJM<T>(string AMBDMECJFHI, T IPHILEOFJLB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x70908A0", Offset = "0x708F6A0", VA = "0x1870908A0")]
	public void PHBIGIKBCJM(string AMBDMECJFHI, string IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x70907B0", Offset = "0x708F5B0", VA = "0x1870907B0")]
	public void PFOMADOJIOG(string NENFMDJENCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x70906F0", Offset = "0x708F4F0", VA = "0x1870906F0")]
	public void MPKOHPIGFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7090590", Offset = "0x708F390", VA = "0x187090590")]
	private void DKNLFMABKII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x70906A0", Offset = "0x708F4A0", VA = "0x1870906A0")]
	private bool FKLDDPCDNFL()
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
		public enum LIEHDBLEAFG
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
		private LIEHDBLEAFG parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public LIEHDBLEAFG Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAB5DD0", Offset = "0xAB4BD0", VA = "0x180AB5DD0")]
			get
			{
				return default(LIEHDBLEAFG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x922F70", Offset = "0x921D70", VA = "0x180922F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7099EE0", Offset = "0x7098CE0", VA = "0x187099EE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal class PINKFHMNAKL : MEBFFNJMPKE, JFKLFHAJFOH
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate void JCLFFLNKOFF(LDHACAGGCKL BJAPJDGLMJG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly PBOGNMPOJPM DNCHGIMLMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly JCLFFLNKOFF MMFIGKNPPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string MPPPGELDKHI;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string LPNFDFDKLKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1914250", Offset = "0x1913050", VA = "0x181914250", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CPNHHLOKFNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7099300", Offset = "0x7098100", VA = "0x187099300", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool JGNOAIAKMMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x70992E0", Offset = "0x70980E0", VA = "0x1870992E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> HEGFABHBAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x19140A0", Offset = "0x1912EA0", VA = "0x1819140A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7099320", Offset = "0x7098120", VA = "0x187099320")]
	public PINKFHMNAKL(PBOGNMPOJPM LHCHLNOABPH, string ILHHKILKFLK, [Optional] JCLFFLNKOFF GHEHIDGJPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x349F8B0", Offset = "0x349E6B0", VA = "0x18349F8B0", Slot = "8")]
	public T ANFJBBFMPMK<T>(string FFOHLCGHDKA, T KBHDDKCAINE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class GGEGJDMLEKD : JGLLKCGMCOF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct PFBKMGIPABO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public PNBANFBGNJH userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public GGEGJDMLEKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7098910", Offset = "0x7097710", VA = "0x187098910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7099280", Offset = "0x7098080", VA = "0x187099280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct LOAMPHMNICK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7094E10", Offset = "0x7093C10", VA = "0x187094E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7094FF0", Offset = "0x7093DF0", VA = "0x187094FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct DGDKBDGAOKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public PNBANFBGNJH userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public GGEGJDMLEKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x70900F0", Offset = "0x708EEF0", VA = "0x1870900F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7090530", Offset = "0x708F330", VA = "0x187090530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct HOBOBBKIAND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public GGEGJDMLEKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public PNBANFBGNJH userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7093150", Offset = "0x7091F50", VA = "0x187093150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7093510", Offset = "0x7092310", VA = "0x187093510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly IReadOnlyDictionary<string, NPLMMFBBGIJ> FNBCGOJKPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool EJOFCDLHGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool ANIFHNGEODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private TaskCompletionSource<bool> OOBBHNJBOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private TaskCompletionSource<bool> JIDAFCAHFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly SemaphoreSlim CANPDDGCIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private NGNGPHEOFDG JBCFNNMKPAD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Task OFHHHHKJLKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x70922E0", Offset = "0x70910E0", VA = "0x1870922E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool LHLAHELLMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xB4A960", Offset = "0xB49760", VA = "0x180B4A960", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool BLFNJHDJEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xB4A970", Offset = "0xB49770", VA = "0x180B4A970", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string JHBJMPIMGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7092AC0", Offset = "0x70918C0", VA = "0x187092AC0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public MLECMBJNLBB JCPJFIMMJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7091970", Offset = "0x7090770", VA = "0x187091970", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HMFCCLHFAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7092970", Offset = "0x7091770", VA = "0x187092970", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7091510", Offset = "0x7090310", VA = "0x187091510", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action MPGNNEDIAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x70926D0", Offset = "0x70914D0", VA = "0x1870926D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7092770", Offset = "0x7091570", VA = "0x187092770", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action CNMKEDGPIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x70915B0", Offset = "0x70903B0", VA = "0x1870915B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x70924D0", Offset = "0x70912D0", VA = "0x1870924D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<LDHACAGGCKL> CBPDCNJMEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x70928C0", Offset = "0x70916C0", VA = "0x1870928C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7092810", Offset = "0x7091610", VA = "0x187092810", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7091760", Offset = "0x7090560", VA = "0x187091760", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x70925B0", Offset = "0x70913B0", VA = "0x1870925B0", Slot = "12")]
	[AsyncStateMachine(typeof(PFBKMGIPABO))]
	public Task JEELJGCJJCO(string DBHFMIBNLOP, [Optional] PNBANFBGNJH OGGEJOHOGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7092A10", Offset = "0x7091810", VA = "0x187092A10", Slot = "23")]
	[AsyncStateMachine(typeof(LOAMPHMNICK))]
	public Task OJAKBHGBPAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7091870", Offset = "0x7090670", VA = "0x187091870", Slot = "18")]
	[AsyncStateMachine(typeof(DGDKBDGAOKM))]
	public Task FDBAMOAILOL(PNBANFBGNJH OGGEJOHOGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7092320", Offset = "0x7091120", VA = "0x187092320")]
	private void HPIINCOLCHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7091650", Offset = "0x7090450", VA = "0x187091650", Slot = "19")]
	[AsyncStateMachine(typeof(HOBOBBKIAND))]
	public Task DDIFKNNPNDJ(PNBANFBGNJH OGGEJOHOGGN, Dictionary<string, string> KJFKALKNGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7091780", Offset = "0x7090580", VA = "0x187091780", Slot = "20")]
	public bool EHJLFNMGJBN(string HPCPGKHMDHF, bool OCGFEAFOAOG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7092CE0", Offset = "0x7091AE0", VA = "0x187092CE0", Slot = "21")]
	public MEBFFNJMPKE POECIANNIPJ(string ILHHKILKFLK, bool OCGFEAFOAOG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7092AD0", Offset = "0x70918D0", VA = "0x187092AD0")]
	private PBOGNMPOJPM PHILFHDGFDL(string ILHHKILKFLK, bool OCGFEAFOAOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x70910B0", Offset = "0x708FEB0", VA = "0x1870910B0", Slot = "22")]
	public NPLIPNMEOOK APMCDLEKIDL(string FPBKDJFOPLC, bool OCGFEAFOAOG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7091410", Offset = "0x7090210", VA = "0x187091410")]
	private PDGCIFDLBIG BOHECBJFDGM(string FPBKDJFOPLC, bool OCGFEAFOAOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x70919A0", Offset = "0x70907A0", VA = "0x1870919A0")]
	private JJHNILGKPOG FPLBCCNHEBC(PNBANFBGNJH OGGEJOHOGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7091260", Offset = "0x7090060", VA = "0x187091260")]
	private JGNLCIHELEI BKHCBHOPFJM(string DBHFMIBNLOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x70923C0", Offset = "0x70911C0", VA = "0x1870923C0")]
	private void ICKMAFCICIE(string ILHHKILKFLK, PBOGNMPOJPM LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7093050", Offset = "0x7091E50", VA = "0x187093050")]
	public GGEGJDMLEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7092570", Offset = "0x7091370", VA = "0x187092570")]
	[CompilerGenerated]
	private void NAJIJEEFNMG(LDHACAGGCKL MLFMLAODHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7092570", Offset = "0x7091370", VA = "0x187092570")]
	[CompilerGenerated]
	private void IONONECPHHA(LDHACAGGCKL MLFMLAODHNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class OPEBBLNPONB : JGLLKCGMCOF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct POOIBLPAIJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public OPEBBLNPONB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public PNBANFBGNJH userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7099390", Offset = "0x7098190", VA = "0x187099390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7099D10", Offset = "0x7098B10", VA = "0x187099D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct JHIOFJPMION : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7093570", Offset = "0x7092370", VA = "0x187093570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private GGEGJDMLEKD JOIBMCDNDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private TaskCompletionSource<bool> OOBBHNJBOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private TaskCompletionSource<bool> JIDAFCAHFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Task CIDHLCOIKMJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private JGLLKCGMCOF ONFPGHDPKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7097B90", Offset = "0x7096990", VA = "0x187097B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BLFNJHDJEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x70981A0", Offset = "0x7096FA0", VA = "0x1870981A0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool LHLAHELLMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x70980E0", Offset = "0x7096EE0", VA = "0x1870980E0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Task OFHHHHKJLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x70978C0", Offset = "0x70966C0", VA = "0x1870978C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string JHBJMPIMGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x70984C0", Offset = "0x70972C0", VA = "0x1870984C0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MLECMBJNLBB JCPJFIMMJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7097880", Offset = "0x7096680", VA = "0x187097880", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action MPGNNEDIAOF
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7097FA0", Offset = "0x7096DA0", VA = "0x187097FA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7098040", Offset = "0x7096E40", VA = "0x187098040", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action HMFCCLHFAMA
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7098310", Offset = "0x7097110", VA = "0x187098310", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x70973D0", Offset = "0x70961D0", VA = "0x1870973D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action CNMKEDGPIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7097470", Offset = "0x7096270", VA = "0x187097470", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7097C00", Offset = "0x7096A00", VA = "0x187097C00", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<LDHACAGGCKL> CBPDCNJMEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7098260", Offset = "0x7097060", VA = "0x187098260", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x70981B0", Offset = "0x7096FB0", VA = "0x1870981B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x70985A0", Offset = "0x70973A0", VA = "0x1870985A0")]
	[UnityEngine.Scripting.Preserve]
	public OPEBBLNPONB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7098130", Offset = "0x7096F30", VA = "0x187098130")]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	internal static void LHLKGADJEGF(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7097F30", Offset = "0x7096D30", VA = "0x187097F30")]
	internal static void JIHJJLMFBKB(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7097630", Offset = "0x7096430", VA = "0x187097630", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7097E20", Offset = "0x7096C20", VA = "0x187097E20", Slot = "12")]
	[AsyncStateMachine(typeof(POOIBLPAIJJ))]
	public Task JEELJGCJJCO(string DBHFMIBNLOP, [Optional] PNBANFBGNJH OGGEJOHOGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7097780", Offset = "0x7096580", VA = "0x187097780", Slot = "18")]
	public Task FDBAMOAILOL(PNBANFBGNJH OGGEJOHOGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7097510", Offset = "0x7096310", VA = "0x187097510", Slot = "19")]
	public Task DDIFKNNPNDJ(PNBANFBGNJH OGGEJOHOGGN, Dictionary<string, string> KJFKALKNGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7097660", Offset = "0x7096460", VA = "0x187097660", Slot = "20")]
	public bool EHJLFNMGJBN(string HPCPGKHMDHF, bool OCGFEAFOAOG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x70984E0", Offset = "0x70972E0", VA = "0x1870984E0", Slot = "21")]
	public MEBFFNJMPKE POECIANNIPJ(string ILHHKILKFLK, bool OCGFEAFOAOG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7097310", Offset = "0x7096110", VA = "0x187097310", Slot = "22")]
	public NPLIPNMEOOK APMCDLEKIDL(string FPBKDJFOPLC, bool OCGFEAFOAOG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x70983B0", Offset = "0x70971B0", VA = "0x1870983B0", Slot = "23")]
	public Task OJAKBHGBPAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7097CA0", Offset = "0x7096AA0", VA = "0x187097CA0")]
	private static void JDPAFCEKINI(TaskCompletionSource<bool> FCHHBDBKHLJ, Task DCBGHHEEMKD, Task MKOLBJPLCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7097AC0", Offset = "0x70968C0", VA = "0x187097AC0")]
	[AsyncStateMachine(typeof(JHIOFJPMION))]
	private static void HCMLIFLBGBN(Task BDCCICFJHCL, TaskCompletionSource<bool> FCHHBDBKHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xD10310", Offset = "0xD0F110", VA = "0x180D10310")]
	[CompilerGenerated]
	private void DIHOPEOOBCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xD5F2B0", Offset = "0xD5E0B0", VA = "0x180D5F2B0")]
	[CompilerGenerated]
	private void EICLKNGEDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xB82B20", Offset = "0xB81920", VA = "0x180B82B20")]
	[CompilerGenerated]
	private void MOBCAMNJMNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x70980F0", Offset = "0x7096EF0", VA = "0x1870980F0")]
	[CompilerGenerated]
	private void KGJBELELMEO(LDHACAGGCKL MLFMLAODHNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal class JGGLDLNHAIM : NPLIPNMEOOK, JFKLFHAJFOH
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void OBAIHNFFLII(LDHACAGGCKL BJAPJDGLMJG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly OBAIHNFFLII MMFIGKNPPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly PDGCIFDLBIG IBAHIEEPGPP;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string LPNFDFDKLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xCA31D0", Offset = "0xCA1FD0", VA = "0x180CA31D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x639A170", Offset = "0x6398F70", VA = "0x18639A170")]
	public JGGLDLNHAIM(PDGCIFDLBIG EMAGOACMMCH, [Optional] OBAIHNFFLII GHEHIDGJPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x333E320", Offset = "0x333D120", VA = "0x18333E320", Slot = "5")]
	public T ANFJBBFMPMK<T>(string FFOHLCGHDKA, T KBHDDKCAINE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface HBOLAKECPIA
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[UsedImplicitly]
public class DMPMEKCFAJM : HBOLAKECPIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly CGLNGKOOMOA LIFKIABLLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly List<ANAKEBGPEIL> BAPMIGBGNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly string DHCFCGNKPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly string NCOAJJJDGNG;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7090AB0", Offset = "0x708F8B0", VA = "0x187090AB0")]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	[UsedImplicitly]
	internal static void GGGLAIJELEP(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7090B20", Offset = "0x708F920", VA = "0x187090B20")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DMPMEKCFAJM([NotNull][MHFJPMCEEAM(null)] CGLNGKOOMOA LIFKIABLLGO, [NotNull][MHFJPMCEEAM(null)] DAKDLPOBLCC MGKCFIMIHGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class ABCMOLOPDJD : JGLLKCGMCOF
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task OFHHHHKJLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7087030", Offset = "0x7085E30", VA = "0x187087030", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool BLFNJHDJEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool LHLAHELLMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string JHBJMPIMGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MLECMBJNLBB JCPJFIMMJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action MPGNNEDIAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x70871F0", Offset = "0x7085FF0", VA = "0x1870871F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7087290", Offset = "0x7086090", VA = "0x187087290", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action HMFCCLHFAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7087490", Offset = "0x7086290", VA = "0x187087490", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7086DD0", Offset = "0x7085BD0", VA = "0x187086DD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action CNMKEDGPIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7086E70", Offset = "0x7085C70", VA = "0x187086E70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x70870C0", Offset = "0x7085EC0", VA = "0x1870870C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<LDHACAGGCKL> CBPDCNJMEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x70873E0", Offset = "0x70861E0", VA = "0x1870873E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7087330", Offset = "0x7086130", VA = "0x187087330", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	[RecRoom.NoEngine.Common.Preserve]
	public ABCMOLOPDJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7087160", Offset = "0x7085F60", VA = "0x187087160", Slot = "12")]
	public Task JEELJGCJJCO(string DBHFMIBNLOP, [Optional] PNBANFBGNJH OGGEJOHOGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7086FA0", Offset = "0x7085DA0", VA = "0x187086FA0", Slot = "18")]
	public Task FDBAMOAILOL(PNBANFBGNJH OGGEJOHOGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7086F10", Offset = "0x7085D10", VA = "0x187086F10", Slot = "19")]
	public Task DDIFKNNPNDJ(PNBANFBGNJH OGGEJOHOGGN, Dictionary<string, string> KJFKALKNGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "20")]
	public bool EHJLFNMGJBN(string HPCPGKHMDHF, bool OCGFEAFOAOG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x70875C0", Offset = "0x70863C0", VA = "0x1870875C0", Slot = "21")]
	public MEBFFNJMPKE POECIANNIPJ(string ILHHKILKFLK, bool OCGFEAFOAOG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7086D40", Offset = "0x7085B40", VA = "0x187086D40", Slot = "22")]
	public NPLIPNMEOOK APMCDLEKIDL(string FPBKDJFOPLC, bool OCGFEAFOAOG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7087530", Offset = "0x7086330", VA = "0x187087530", Slot = "23")]
	public Task OJAKBHGBPAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal class NGNGPHEOFDG : MLECMBJNLBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly JJHNILGKPOG PDBEBGMHENI;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IReadOnlyDictionary<string, object> BHHDPGADMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xCADD20", Offset = "0xCACB20", VA = "0x180CADD20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public NGNGPHEOFDG(JJHNILGKPOG DJEAFICDMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface IFHLJJEOBAD
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DLKOCCGEJEA NMMFEKCJLBC(string LJOEOLIACBE);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface APGKKIHKPFK
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum IFCOEPNKINC
	{
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	long IEKBFCLLLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string HKDDJCOBEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string IEADMMEJLPM
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool DMHNDAKMKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long PDACIJMPMOH();

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GEBJFFPHCFM(long MNGOHBKCBKP, bool IBONICHNIMN = true);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HLCHNBCNMGH(string MOBMLKIIAJP, string FPLEEPOHAOC, string IJGIJMBLPFF);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AFECBBKCEID(string MOBMLKIIAJP);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MAEDEHJJEHD(string MOBMLKIIAJP, string BIHEPDOIBMB, string MCBFGEJMOME);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NKCJIBCCJMC(string FDOHOLOFKDI, object KGBEEJOPGNK, object DGKHKMCINEG);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CFEIOIBIEON(IFCOEPNKINC ELAJEBKCJLO, int FDHKHEAGCEI, [Optional] NCNNJGKIGFO LIAFPNJBDPE, [Optional] string CLGOCBIBDPA, [Optional] string LKNDCPLLKMB);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KIHLDNHCOJD(NCNNJGKIGFO LIAFPNJBDPE, long ABKPCGDMNGL, long LCCFEMLOGHL, int PFFCDAEMAMN, string CLGOCBIBDPA, int FDHKHEAGCEI);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ILGCMHIFKHN(NCNNJGKIGFO LIAFPNJBDPE, bool AAIFAFJIHJG, [Optional] string LKNDCPLLKMB);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JBBKECCKOPM(NCNNJGKIGFO LIAFPNJBDPE, bool AAIFAFJIHJG, [Optional] string LKNDCPLLKMB);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LAGHFDHBDGI(NCNNJGKIGFO LIAFPNJBDPE, bool AAIFAFJIHJG, [Optional] string LKNDCPLLKMB);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FFDPKFALPBI(long OGMIFIGJENM, string BOPEIMOLACK);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface BKKJBEIFDMD
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string EFCGACHNMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
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
