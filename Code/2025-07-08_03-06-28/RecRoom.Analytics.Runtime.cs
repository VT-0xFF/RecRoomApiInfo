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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E361A0", Offset = "0x7E34FA0", VA = "0x187E361A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
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
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E35E60", Offset = "0x7E34C60", VA = "0x187E35E60", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E3AAE0", Offset = "0x7E398E0", VA = "0x187E3AAE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
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
		public AmplitudeAnalyticsClient.Settings ONJJCGBPDBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool EMLIPBKDDKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA60460", Offset = "0xA5F260", VA = "0x180A60460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, OAGHPAJECPH
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum FMFLDHMIODG
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class PNPBIFJBMBM
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class BHGMEKOGEDC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int GIMLGOCMOCG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> OOFMCHCIFLF;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
				public BHGMEKOGEDC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class OKPHIEJOCGI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
				public OKPHIEJOCGI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x7E38300", Offset = "0x7E37100", VA = "0x187E38300")]
				internal bool DODGLBLLPFA(BHGMEKOGEDC item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string MOLFHJCHIJN = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string PFPNMKAMPMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<BHGMEKOGEDC> DGMEHHPLMOP;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? IGCPOPOEGAO
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x7E38BD0", Offset = "0x7E379D0", VA = "0x187E38BD0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7E39CC0", Offset = "0x7E38AC0", VA = "0x187E39CC0")]
			internal PNPBIFJBMBM(string MFHMDOHMNCE, string FKNAGMPCGPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7E397B0", Offset = "0x7E385B0", VA = "0x187E397B0")]
			public int MNFMCGBDDIF([Optional] int? PLIFLHGNFOD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7E393B0", Offset = "0x7E381B0", VA = "0x187E393B0")]
			public List<Dictionary<string, object>> IPNAIFBHNMH(int HGONKJFJJGM, int? PLIFLHGNFOD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7E38A20", Offset = "0x7E37820", VA = "0x187E38A20")]
			public void AHPJLGOCKJP(AmplitudeAnalyticsIdentifyMessage MKPNGAKJFMP, bool EPDLBEAHDCL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7E38AC0", Offset = "0x7E378C0", VA = "0x187E38AC0")]
			public void AHPJLGOCKJP(Dictionary<string, object> MKPNGAKJFMP, bool EPDLBEAHDCL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7E39620", Offset = "0x7E38420", VA = "0x187E39620")]
			public void KCJBBNIKKOK(params Dictionary<string, object>[] OFKIMKPGIGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7E39960", Offset = "0x7E38760", VA = "0x187E39960")]
			public void OJMPKBCHFIC(List<Dictionary<string, object>> AMAGFIDIHBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7E39BB0", Offset = "0x7E389B0", VA = "0x187E39BB0")]
			private void PBFCADIBGNJ(Dictionary<string, object> MKPNGAKJFMP, bool EPDLBEAHDCL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7E391A0", Offset = "0x7E37FA0", VA = "0x187E391A0")]
			public void EIJLCAKONCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7E38C70", Offset = "0x7E37A70", VA = "0x187E38C70")]
			private void BOFDCDBLAHD([Optional] string EGAIJLDAGHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7E39070", Offset = "0x7E37E70", VA = "0x187E39070")]
			private static string DPKGICOJFNJ(string BNECONOIKOE, string MAHBBBBCDEL)
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
			[Cpp2IlInjected.Address(RVA = "0x7E3A6D0", Offset = "0x7E394D0", VA = "0x187E3A6D0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct MIPKHCLNEGE<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int MJLBIAAAFPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string PNPDDEIMLNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T CCKOFCMPGFA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class DPKCHBPDAOM : IEnumerator<DMCHEKCEBGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private DMCHEKCEBGH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private DMCHEKCEBGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
			[DebuggerHidden]
			public DPKCHBPDAOM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7E2F120", Offset = "0x7E2DF20", VA = "0x187E2F120", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7E2F8B0", Offset = "0x7E2E6B0", VA = "0x187E2F8B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class BEKLIDBGGHM : IEnumerator<object>, IEnumerator, IDisposable
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
			public OEFHFMHBIFE quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
			[DebuggerHidden]
			public BEKLIDBGGHM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7E2E520", Offset = "0x7E2D320", VA = "0x187E2E520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7E2E630", Offset = "0x7E2D430", VA = "0x187E2E630", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class APLHFBHMPHB : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
			[DebuggerHidden]
			public APLHFBHMPHB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7E26CD0", Offset = "0x7E25AD0", VA = "0x187E26CD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7E26E40", Offset = "0x7E25C40", VA = "0x187E26E40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class NDMDLEMKOLO : IEnumerator<DMCHEKCEBGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private DMCHEKCEBGH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private DMCHEKCEBGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
			[DebuggerHidden]
			public NDMDLEMKOLO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7E35EF0", Offset = "0x7E34CF0", VA = "0x187E35EF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7E36150", Offset = "0x7E34F50", VA = "0x187E36150", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ECELPGPCKJM : IEnumerator<DMCHEKCEBGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private DMCHEKCEBGH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private DMCHEKCEBGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
			[DebuggerHidden]
			public ECELPGPCKJM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7E2FA80", Offset = "0x7E2E880", VA = "0x187E2FA80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7E2FCE0", Offset = "0x7E2EAE0", VA = "0x187E2FCE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class FEDEIPKPJKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public PNPBIFJBMBM cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public FEDEIPKPJKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7E2FD30", Offset = "0x7E2EB30", VA = "0x187E2FD30")]
			internal void FANFFIBMGCG(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7E30050", Offset = "0x7E2EE50", VA = "0x187E30050")]
			internal void MEKJFLDIKJD(MIPKHCLNEGE<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class IEKJPAAMGCN : IEnumerator<DMCHEKCEBGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private DMCHEKCEBGH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public PNPBIFJBMBM cache;

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
			private FEDEIPKPJKE <>8__1;

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
			private DMCHEKCEBGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
			[DebuggerHidden]
			public IEKJPAAMGCN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7E31100", Offset = "0x7E2FF00", VA = "0x187E31100", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7E31920", Offset = "0x7E30720", VA = "0x187E31920", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class DLGHHJGIMAC<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public DLGHHJGIMAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6E09490", Offset = "0x6E08290", VA = "0x186E09490")]
			internal MIPKHCLNEGE<T> ONMDFNKEIBB(MFGANBGPDMB postResponse)
			{
				return default(MIPKHCLNEGE<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private BKIICIJGLFD MPEGOOGCJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<LLMGBLHKPAC> EIJAMHJKHNE;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string LPBMCEHBMHH = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string HGFGBGMGIOI = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string GNDGJCEBALC = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int EEJEGGLOMGP = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int OHFBLCLBDNA = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int MLDJIBDHFMN = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float KKKEOBHBEFH = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long PFAFPJNEDOG = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string PIMHENACPFC = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string OFNIHKAFAPH = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string LHJCEBOOLAH = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string LCFHJOOCFGE = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool BCDEGMPHKHN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool GFMFMOGFCHO;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int JAJBBPBADMG;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int DKKNPNEMAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private JLKHPMFGHHM FEEDJGMAJOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private NMOBHICJOGA HNFAMOACEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private CALDANMDCAE PGLPLMOMPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool CCCJAMBMHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float FEOABPCAKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float LIPEIBGDPNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int CBJMNNIGNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int IHKPINODOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? INMJALMMBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? PGAHLOHOICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long PHBJNKCHJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string HFLFOEOIGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string LNMEIJIEOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long NDFPGHILIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string OCGEOPNHPOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string KFJODMCMGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> OIOENAMNNLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private FMFLDHMIODG LDHFGHADEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int MGNLNFNOEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int BIHEEOMJMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float HJMEAOFNCMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool NIHJNJLHMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool ABBKCHEMEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private PNPBIFJBMBM LJJDILLBPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private PNPBIFJBMBM GBMGMPJGNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private PNPBIFJBMBM EGCHIABIAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string FIJODBOKBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> NKMPEMAANCP;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo MJEMJKDKJMJ;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string GDJGBHMDKDI;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string PIADCNGLDLF = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string NLEGBPHBJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string ICFHMBLMNLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string DFGILPLGHFD;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BKIICIJGLFD ABIJOLPLGGG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7E2AD20", Offset = "0x7E29B20", VA = "0x187E2AD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private LLMGBLHKPAC EBHGOOHGMMG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7E2AE80", Offset = "0x7E29C80", VA = "0x187E2AE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int IHJIDMKLIPP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7E28DB0", Offset = "0x7E27BB0", VA = "0x187E28DB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long HHKOLBCKJMA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7E2CDE0", Offset = "0x7E2BBE0", VA = "0x187E2CDE0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7E2CEF0", Offset = "0x7E2BCF0", VA = "0x187E2CEF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string FFOOBCHKINB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7E2CDB0", Offset = "0x7E2BBB0", VA = "0x187E2CDB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool MFHPJONMPOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x16689F0", Offset = "0x16677F0", VA = "0x1816689F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x16677D0", Offset = "0x16665D0", VA = "0x1816677D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IBGCILEFLOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xADC5C0", Offset = "0xADB3C0", VA = "0x180ADC5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAD7E10", Offset = "0xAD6C10", VA = "0x180AD7E10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? PCBFONIICIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAD0AA0", Offset = "0xACF8A0", VA = "0x180AD0AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAD0AB0", Offset = "0xACF8B0", VA = "0x180AD0AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MBFBLIKLEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAD0A90", Offset = "0xACF890", VA = "0x180AD0A90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAF9C60", Offset = "0xAF8A60", VA = "0x180AF9C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool DKMJOMHJLLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7E2CCB0", Offset = "0x7E2BAB0", VA = "0x187E2CCB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> DOFLMGGFGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7E2CBF0", Offset = "0x7E2B9F0", VA = "0x187E2CBF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7E2CE30", Offset = "0x7E2BC30", VA = "0x187E2CE30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7E27210", Offset = "0x7E26010", VA = "0x187E27210", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7E27C90", Offset = "0x7E26A90", VA = "0x187E27C90")]
		private void CKLHPJIPLNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C220", Offset = "0x7E2B020", VA = "0x187E2C220")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7E2ADC0", Offset = "0x7E29BC0", VA = "0x187E2ADC0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C550", Offset = "0x7E2B350", VA = "0x187E2C550")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7E2AF60", Offset = "0x7E29D60", VA = "0x187E2AF60")]
		public IDGEJBLICGP PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7E29640", Offset = "0x7E28440", VA = "0x187E29640")]
		[IteratorStateMachine(typeof(DPKCHBPDAOM))]
		public IEnumerator<DMCHEKCEBGH> InitializeForLocalAccount(AmplitudeAnalyticsEvent GHJDIGJMBHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B8E0", Offset = "0x7E2A6E0", VA = "0x187E2B8E0")]
		public void SendAppEnterEvent(bool IFKGKFGLKNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C4D0", Offset = "0x7E2B2D0", VA = "0x187E2C4D0")]
		public void UpdateLastKnownInteractionCategory(string JOKBEDJGFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C420", Offset = "0x7E2B220", VA = "0x187E2C420")]
		public void UpdateLastAliveTime(float GJELOGAKDKA = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7E28690", Offset = "0x7E27490", VA = "0x187E28690")]
		private IDGEJBLICGP FBDINOOFJIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E2ABB0", Offset = "0x7E299B0", VA = "0x187E2ABB0")]
		private IDGEJBLICGP MADNGKHJGEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BBF0", Offset = "0x7E2A9F0", VA = "0x187E2BBF0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7E287E0", Offset = "0x7E275E0", VA = "0x187E287E0")]
		[IteratorStateMachine(typeof(BEKLIDBGGHM))]
		private IEnumerator FFBENGMHINI(OEFHFMHBIFE CLAONNBDCJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C7E0", Offset = "0x7E2B5E0", VA = "0x187E2C7E0")]
		[IteratorStateMachine(typeof(APLHFBHMPHB))]
		public IEnumerator WaitForFlush(float DKEAKDFFACG = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C300", Offset = "0x7E2B100", VA = "0x187E2C300")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C240", Offset = "0x7E2B040", VA = "0x187E2C240")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime GJEILCNCAPN)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7E29120", Offset = "0x7E27F20", VA = "0x187E29120")]
		public static IOCLGCNGPCK Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7E27060", Offset = "0x7E25E60", VA = "0x187E27060")]
		public static OMHLOHHBKLK AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string HFADEJGFJHG, string CDGHLBLIBBM, AEKFIFKNLEI MCKONMOBMNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7E28380", Offset = "0x7E27180", VA = "0x187E28380")]
		public static OMHLOHHBKLK Event([JetBrains.Annotations.NotNull] string HFADEJGFJHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B100", Offset = "0x7E29F00", VA = "0x187E2B100")]
		public static OMHLOHHBKLK PreviousSessionEvent([JetBrains.Annotations.NotNull] string HFADEJGFJHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7E292D0", Offset = "0x7E280D0", VA = "0x187E292D0")]
		public static OMHLOHHBKLK InitializeEvent(string CDGHLBLIBBM, int CEJLFNBNNDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BDF0", Offset = "0x7E2ABF0", VA = "0x187E2BDF0")]
		public static OMHLOHHBKLK StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7E28050", Offset = "0x7E26E50", VA = "0x187E28050")]
		public static OMHLOHHBKLK CreateOutOfSessionEvent(string HFADEJGFJHG, bool OFHFDKICAII = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A7C0", Offset = "0x7E295C0", VA = "0x187E2A7C0")]
		public static IDGEJBLICGP LogOutOfSessionEvent(OMHLOHHBKLK JNBBIBJLDHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A540", Offset = "0x7E29340", VA = "0x187E2A540")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LACNCNKHPII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A990", Offset = "0x7E29790", VA = "0x187E2A990")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LACNCNKHPII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E2AAD0", Offset = "0x7E298D0", VA = "0x187E2AAD0")]
		public void LogSerializedEventAsync(Dictionary<string, object> LGNPDOJOMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A680", Offset = "0x7E29480", VA = "0x187E2A680")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage PIGGHLKDEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7E289F0", Offset = "0x7E277F0", VA = "0x187E289F0")]
		private void GLCMCIGDIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7E28AF0", Offset = "0x7E278F0", VA = "0x187E28AF0")]
		private void HIBIGFBEFDP(Dictionary<string, object> JMHGGGFFMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7E28870", Offset = "0x7E27670", VA = "0x187E28870")]
		private void FNGNJLNJIPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E26E90", Offset = "0x7E25C90", VA = "0x187E26E90")]
		private void AGGHILOHNHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E28960", Offset = "0x7E27760", VA = "0x187E28960")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7E28750", Offset = "0x7E27550", VA = "0x187E28750")]
		[IteratorStateMachine(typeof(NDMDLEMKOLO))]
		private IEnumerator<DMCHEKCEBGH> FBKODJNJEED(float DKEAKDFFACG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7E2AED0", Offset = "0x7E29CD0", VA = "0x187E2AED0")]
		[IteratorStateMachine(typeof(ECELPGPCKJM))]
		private IEnumerator<DMCHEKCEBGH> PKLNCPPFCHI(float DKEAKDFFACG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E27870", Offset = "0x7E26670", VA = "0x187E27870")]
		[IteratorStateMachine(typeof(IEKJPAAMGCN))]
		private IEnumerator<DMCHEKCEBGH> BBIEEEGPIOM(PNPBIFJBMBM HGDOOOHHPKA, int? PLIFLHGNFOD, string INDELLPFAKO, float DKEAKDFFACG, Action<int> EGDGBANILMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E296D0", Offset = "0x7E284D0", VA = "0x187E296D0")]
		private static void JBMEIDLABBH(bool HPAEPHEKADN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E27BC0", Offset = "0x7E269C0", VA = "0x187E27BC0")]
		private CEBCBDBEPBJ<MIPKHCLNEGE<Dictionary<string, object>>> CGCEKPEHGBI(string INDELLPFAKO, string NAKKGKHKMNB, Dictionary<string, object> CCKOFCMPGFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7E27950", Offset = "0x7E26750", VA = "0x187E27950")]
		private CEBCBDBEPBJ<MIPKHCLNEGE<List<Dictionary<string, object>>>> CGCEKPEHGBI(string INDELLPFAKO, string NAKKGKHKMNB, List<Dictionary<string, object>> CCKOFCMPGFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x31544A0", Offset = "0x31532A0", VA = "0x1831544A0")]
		private CEBCBDBEPBJ<MIPKHCLNEGE<T>> HHNLKIHCJJA<T>(string JHIJIONPDGN, string INDELLPFAKO, string NAKKGKHKMNB, T CCKOFCMPGFA, Dictionary<string, object> LLOOHBIGNCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7E28330", Offset = "0x7E27130", VA = "0x187E28330")]
		private bool EMHOKMAPADO(float JJLJKJFEDOP, float DKEAKDFFACG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7E297E0", Offset = "0x7E285E0", VA = "0x187E297E0")]
		private Dictionary<string, object> JMINMPMGLKK(string INDELLPFAKO, Dictionary<string, object> CCKOFCMPGFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C8D0", Offset = "0x7E2B6D0", VA = "0x187E2C8D0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA85C10", Offset = "0xA84A10", VA = "0x180A85C10", Slot = "6")]
		private bool JGCGIJJFOGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7E28FB0", Offset = "0x7E27DB0", VA = "0x187E28FB0")]
		[CompilerGenerated]
		private long IHAPKAIJANH()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7E2ADB0", Offset = "0x7E29BB0", VA = "0x187E2ADB0")]
		[CompilerGenerated]
		private void NGFEMOCBLPG(int KBDNPDNPMHB)
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
			[Cpp2IlInjected.Address(RVA = "0x7E2DC00", Offset = "0x7E2CA00", VA = "0x187E2DC00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7E2DCE0", Offset = "0x7E2CAE0", VA = "0x187E2DCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7E2DC40", Offset = "0x7E2CA40", VA = "0x187E2DC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7E2DD40", Offset = "0x7E2CB40", VA = "0x187E2DD40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7E2DBC0", Offset = "0x7E2C9C0", VA = "0x187E2DBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7E2DC80", Offset = "0x7E2CA80", VA = "0x187E2DC80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E190", VA = "0x180A5F390")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D920", Offset = "0x7E2C720", VA = "0x187E2D920")]
		public static OMHLOHHBKLK LDFHHMLGJNG(string DMIBKIHBLCP, [JetBrains.Annotations.NotNull] string AHDIMGPOHGO, long HGLHDGHKJJM, long CLANJFOOKNM, string CDGHLBLIBBM, string MCKONMOBMNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D1E0", Offset = "0x7E2BFE0", VA = "0x187E2D1E0")]
		public static OMHLOHHBKLK ILPMCFNMJLE(string DMIBKIHBLCP, [JetBrains.Annotations.NotNull] string AHDIMGPOHGO, long HGLHDGHKJJM, long CLANJFOOKNM, string CDGHLBLIBBM, long MPHGGFJGJNI, string PLKDDMGBIFO, string PKHPPLKDNJP, string GOCECDKFPJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7E2DA20", Offset = "0x7E2C820", VA = "0x187E2DA20")]
		private AmplitudeAnalyticsEvent(string DMIBKIHBLCP, [JetBrains.Annotations.NotNull] string AHDIMGPOHGO, long HGLHDGHKJJM, long CLANJFOOKNM, string CDGHLBLIBBM, string MCKONMOBMNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xF7F5A0", Offset = "0xF7E3A0", VA = "0x180F7F5A0")]
		public void GGGAPBHANDG(long PEDPJCEIOJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D0D0", Offset = "0x7E2BED0", VA = "0x187E2D0D0", Slot = "5")]
		public override void HHGJMNIFAFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7E2CF50", Offset = "0x7E2BD50", VA = "0x187E2CF50", Slot = "6")]
		public override void BJLPCCNDGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D450", Offset = "0x7E2C250", VA = "0x187E2D450", Slot = "4")]
		protected override Dictionary<string, object> LBIAAJFKNKD(Dictionary<string, object> HLKIDKABHJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D340", Offset = "0x7E2C140", VA = "0x187E2D340")]
		private void JKKJPFJOPKC(string MAHBBBBCDEL, string BNECONOIKOE, bool JIJLNCKOGED = false)
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
			[Cpp2IlInjected.Address(RVA = "0x7E2F900", Offset = "0x7E2E700", VA = "0x187E2F900")]
			public void LDABGOBIHBN(Dictionary<string, object> KLBBMKHCKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E3A350", Offset = "0x7E39150", VA = "0x187E3A350")]
			public void LDABGOBIHBN(Dictionary<string, object> LAAIBKAOEFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x14B8CB0", Offset = "0x14B7AB0", VA = "0x1814B8CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7E2E3A0", Offset = "0x7E2D1A0", VA = "0x187E2E3A0")]
		public static IOCLGCNGPCK LDFHHMLGJNG(string DMIBKIHBLCP, string CDGHLBLIBBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E2E460", Offset = "0x7E2D260", VA = "0x187E2E460")]
		protected AmplitudeAnalyticsIdentifyMessage(string DMIBKIHBLCP, string CDGHLBLIBBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E2DE30", Offset = "0x7E2CC30", VA = "0x187E2DE30")]
		public Dictionary<string, object> DGKMKOGHNJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E2E060", Offset = "0x7E2CE60", VA = "0x187E2E060", Slot = "4")]
		protected virtual Dictionary<string, object> LBIAAJFKNKD(Dictionary<string, object> HLKIDKABHJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E2DEC0", Offset = "0x7E2CCC0", VA = "0x187E2DEC0")]
		protected void GNLLOFDFFGH(string MAHBBBBCDEL, Dictionary<string, object> OOJAIDBPJHF, Dictionary<string, object> BEJAFKAOIMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E2DFF0", Offset = "0x7E2CDF0", VA = "0x187E2DFF0")]
		protected void HHOCDPNKJFA(string MAHBBBBCDEL, string BNECONOIKOE, Dictionary<string, object> IAHPMCOOLLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7E2DF60", Offset = "0x7E2CD60", VA = "0x187E2DF60", Slot = "5")]
		public virtual void HHGJMNIFAFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E2DDA0", Offset = "0x7E2CBA0", VA = "0x187E2DDA0", Slot = "6")]
		public virtual void BJLPCCNDGPM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IOCLGCNGPCK : PKAMKOOEPJJ<AmplitudeAnalyticsIdentifyMessage, IOCLGCNGPCK>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override IOCLGCNGPCK CAJEMKBAHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage CGOIKJJPPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E31A20", Offset = "0x7E30820", VA = "0x187E31A20")]
	public IOCLGCNGPCK(AmplitudeAnalyticsIdentifyMessage IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7E31970", Offset = "0x7E30770", VA = "0x187E31970", Slot = "4")]
	public override void BJLPCCNDGPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OMHLOHHBKLK : PKAMKOOEPJJ<AmplitudeAnalyticsEvent, OMHLOHHBKLK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool OELGJIPOAPG;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override OMHLOHHBKLK CAJEMKBAHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long FGMHBKGPLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E385A0", Offset = "0x7E373A0", VA = "0x187E385A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E386F0", Offset = "0x7E374F0", VA = "0x187E386F0")]
	public OMHLOHHBKLK(AmplitudeAnalyticsEvent IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "5")]
	public override AmplitudeAnalyticsEvent CGOIKJJPPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7E38460", Offset = "0x7E37260", VA = "0x187E38460", Slot = "4")]
	public override void BJLPCCNDGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A240", Offset = "0x3D39040", VA = "0x183D3A240")]
	public OMHLOHHBKLK BHFIFMDIJPM<T>(string DAGPCGHBFAL, T[] BNECONOIKOE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A240", Offset = "0x3D39040", VA = "0x183D3A240")]
	public OMHLOHHBKLK BHFIFMDIJPM(string DAGPCGHBFAL, string[] BNECONOIKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3D39F90", Offset = "0x3D38D90", VA = "0x183D39F90")]
	public OMHLOHHBKLK BHFIFMDIJPM<T>(string DAGPCGHBFAL, T BNECONOIKOE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E38370", Offset = "0x7E37170", VA = "0x187E38370")]
	public OMHLOHHBKLK BHFIFMDIJPM(string DAGPCGHBFAL, long BNECONOIKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E383F0", Offset = "0x7E371F0", VA = "0x187E383F0")]
	public OMHLOHHBKLK BHFIFMDIJPM(string DAGPCGHBFAL, string BNECONOIKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E385C0", Offset = "0x7E373C0", VA = "0x187E385C0")]
	public OMHLOHHBKLK JOEKMPONNBB(string DAGPCGHBFAL, object? BNECONOIKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E38500", Offset = "0x7E37300", VA = "0x187E38500")]
	public OMHLOHHBKLK IJFIPBLEOFD(string DAGPCGHBFAL, string BNECONOIKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E385F0", Offset = "0x7E373F0", VA = "0x187E385F0")]
	private OMHLOHHBKLK LGIHAJOEJBE(string DAGPCGHBFAL, object BNECONOIKOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PFOCPOJBEKG : OMHLOHHBKLK
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E386F0", Offset = "0x7E374F0", VA = "0x187E386F0")]
	public PFOCPOJBEKG(AmplitudeAnalyticsEvent IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E38740", Offset = "0x7E37540", VA = "0x187E38740", Slot = "4")]
	public override void BJLPCCNDGPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class PKAMKOOEPJJ<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : PKAMKOOEPJJ<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M IIHOFBLPONF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR CAJEMKBAHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	public PKAMKOOEPJJ(M IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x59BF170", Offset = "0x59BDF70", VA = "0x1859BF170")]
	public BLDR EBICKBLNFMJ(AmplitudeAnalyticsIdentifyMessage.DeviceInfo KGOHKJGLIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x59BF1C0", Offset = "0x59BDFC0", VA = "0x1859BF1C0")]
	public BLDR EEOJGGIDJLJ(AmplitudeAnalyticsIdentifyMessage.RevenueData FEKKCAECFOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x59BF210", Offset = "0x59BE010", VA = "0x1859BF210")]
	public BLDR NDMEDODJFCG(string DAGPCGHBFAL, string BNECONOIKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4333950", Offset = "0x4332750", VA = "0x184333950")]
	public BLDR NDMEDODJFCG<T>(string DAGPCGHBFAL, T BNECONOIKOE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BJLPCCNDGPM();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x59BF290", Offset = "0x59BE090", VA = "0x1859BF290")]
	internal static string PDENBIENMIC(string BNECONOIKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x59BF070", Offset = "0x59BDE70", VA = "0x1859BF070")]
	private BLDR DMNLJMPCELM(string DAGPCGHBFAL, object BNECONOIKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M CGOIKJJPPIB();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class LAPDLBOBHHD : JLKHPMFGHHM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct KFNBBPKICKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<MFGANBGPDMB> <>t__builder;

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
		public LAPDLBOBHHD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7E32E70", Offset = "0x7E31C70", VA = "0x187E32E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7E338A0", Offset = "0x7E326A0", VA = "0x187E338A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient DKBAAOHELNA;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E33DB0", Offset = "0x7E32BB0", VA = "0x187E33DB0")]
	[ONLJNMLDJBD.KDDDMPKOLFO]
	internal static void EDGBNGOFHIG(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7E33F90", Offset = "0x7E32D90", VA = "0x187E33F90")]
	[RecRoom.NoEngine.Common.Preserve]
	public LAPDLBOBHHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7E33E20", Offset = "0x7E32C20", VA = "0x187E33E20", Slot = "4")]
	[AsyncStateMachine(typeof(KFNBBPKICKN))]
	public Task<MFGANBGPDMB> PBOCAJOFONC(string JHIJIONPDGN, string PIOBBACJLKM, string GHIFLHINBOH, string FFNJADKDAAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class KFJBJIHBNGH : JLKHPMFGHHM
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LOPNDKABDGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<MFGANBGPDMB> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public LOPNDKABDGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7E35D80", Offset = "0x7E34B80", VA = "0x187E35D80")]
		internal void COAAEMPEIAE(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct BNNCPDELMEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<MFGANBGPDMB> <>t__builder;

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
		private TaskAwaiter<MFGANBGPDMB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7E2EB60", Offset = "0x7E2D960", VA = "0x187E2EB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7E2F0B0", Offset = "0x7E2DEB0", VA = "0x187E2F0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	[ONLJNMLDJBD.KDDDMPKOLFO]
	internal static void HNGFGPNNLFH(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KFJBJIHBNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E32D10", Offset = "0x7E31B10", VA = "0x187E32D10", Slot = "4")]
	[AsyncStateMachine(typeof(BNNCPDELMEM))]
	public Task<MFGANBGPDMB> PBOCAJOFONC(string JHIJIONPDGN, string PIOBBACJLKM, string GHIFLHINBOH, string FFNJADKDAAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GGBELNAJDPO
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> BBBIIHKIBDK;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7E30960", Offset = "0x7E2F760", VA = "0x187E30960")]
	internal static bool KCNAGPEDDNC(string MAHBBBBCDEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface JLKHPMFGHHM
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MFGANBGPDMB> PBOCAJOFONC(string JHIJIONPDGN, string PIOBBACJLKM, string GHIFLHINBOH, string FFNJADKDAAL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct MFGANBGPDMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int PGFEAHAFFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string MAGLKBDCEGF;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1860240", Offset = "0x185F040", VA = "0x181860240")]
	public MFGANBGPDMB(int MJLBIAAAFPB, string PNPDDEIMLNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum CBJFEGGILMI
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
public class POHBBMBNKPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private long CBDIADBCBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private OMHLOHHBKLK AIDBMKGCNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool MDDPJOMOOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private float OBEFJGIAEHP;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A1C0", Offset = "0x7E38FC0", VA = "0x187E3A1C0")]
	public POHBBMBNKPO(string IBDIGHFFIGL, float OBEFJGIAEHP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3D748E0", Offset = "0x3D736E0", VA = "0x183D748E0")]
	public void BHFIFMDIJPM<T>(string DAGPCGHBFAL, T BNECONOIKOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E39EF0", Offset = "0x7E38CF0", VA = "0x187E39EF0")]
	public void BHFIFMDIJPM(string DAGPCGHBFAL, string BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E3A0D0", Offset = "0x7E38ED0", VA = "0x187E3A0D0")]
	public void LOAPNKDCCOH(string JMLCEJMNOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E39E30", Offset = "0x7E38C30", VA = "0x187E39E30")]
	public void BDDAKEKBLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7E39FC0", Offset = "0x7E38DC0", VA = "0x187E39FC0")]
	private void INCNPHCGOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E39F70", Offset = "0x7E38D70", VA = "0x187E39F70")]
	private bool HIJJDPBDLEJ()
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
		public enum JFLKEDNCJPO
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
		private JFLKEDNCJPO parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public JFLKEDNCJPO Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAAEA50", Offset = "0xAAD850", VA = "0x180AAEA50")]
			get
			{
				return default(JFLKEDNCJPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA86430", Offset = "0xA85230", VA = "0x180A86430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7E3A4C0", Offset = "0x7E392C0", VA = "0x187E3A4C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FDMEBKLEHDH<T> : DEEMOICOGGP<T>, CPIJEDCIBLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly HGFOMCHGKEH NJOCDKGDILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string FEMFINBCNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly string LKIGLBJMJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private T IDCDCAHIEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly T JILABBLHNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool LNEIKLNLFCK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string HEDHBHCKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4C9F1C0", Offset = "0x4C9DFC0", VA = "0x184C9F1C0")]
	public FDMEBKLEHDH(HGFOMCHGKEH NJOCDKGDILE, string FEMFINBCNMC, string LKIGLBJMJDG, T JILABBLHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4C9EEB0", Offset = "0x4C9DCB0", VA = "0x184C9EEB0", Slot = "4")]
	public T GGDBPONNJMM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4C9F1B0", Offset = "0x4C9DFB0", VA = "0x184C9F1B0", Slot = "6")]
	public void MKDKKBLDFOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
public class BHADHFKHHEI : BJBPLDNFCLM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct PJMPFPLJNMM : IEquatable<PJMPFPLJNMM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly string JLCADJCLKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly string PBIOKPCMDFI;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xBC8270", Offset = "0xBC7070", VA = "0x180BC8270")]
		public PJMPFPLJNMM(string MIGNBEDBLIN, string JDDAMLIIHGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1341850", Offset = "0x1340650", VA = "0x181341850", Slot = "4")]
		public bool Equals(PJMPFPLJNMM LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7E388F0", Offset = "0x7E376F0", VA = "0x187E388F0", Slot = "0")]
		public override bool Equals(object MKPNGAKJFMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7E389B0", Offset = "0x7E377B0", VA = "0x187E389B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private HGFOMCHGKEH NJOCDKGDILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Dictionary<PJMPFPLJNMM, CPIJEDCIBLN> BJKEGBBLKHH;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E680", Offset = "0x7E2D480", VA = "0x187E2E680")]
	[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
	internal static void DKGNAIFEGAN(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E9B0", Offset = "0x7E2D7B0", VA = "0x187E2E9B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BHADHFKHHEI([System.Diagnostics.CodeAnalysis.NotNull][OLOAAHJODHH(null)] HGFOMCHGKEH NJOCDKGDILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E6F0", Offset = "0x7E2D4F0", VA = "0x187E2E6F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E9A0", Offset = "0x7E2D7A0", VA = "0x187E2E9A0")]
	private void MNACMPGDBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E7F0", Offset = "0x7E2D5F0", VA = "0x187E2E7F0")]
	private void MDALKELLICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3936C00", Offset = "0x3935A00", VA = "0x183936C00", Slot = "4")]
	public DEEMOICOGGP<T> OAEJKHGOMOF<T>(string FEMFINBCNMC, string FDHJAHLLIHD, T JILABBLHNAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class GBIJGCOLAPP : JMHJMJHGBMH, CPNDGPKIFLK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void POELBDEPEPJ(DJCHOLANDPD KABOLPPJGGF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly HINALFHCCLK LOLCCHCNOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly POELBDEPEPJ MMJCGAEEOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly string HCNDMGILIAB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string OFMLOIDKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1276650", Offset = "0x1275450", VA = "0x181276650", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string KGOLJFDDJNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2900", Offset = "0x1DA1700", VA = "0x181DA2900", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool JBGALPBBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7E304A0", Offset = "0x7E2F2A0", VA = "0x187E304A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool ILPGDPINEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E304C0", Offset = "0x7E2F2C0", VA = "0x187E304C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyList<string> GKAJBFOJFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2D60", Offset = "0x1DA1B60", VA = "0x181DA2D60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x13B3EA0", Offset = "0x13B2CA0", VA = "0x1813B3EA0")]
	public GBIJGCOLAPP(HINALFHCCLK FNFCFIGCMHH, string EJKNIJHFKPM, [Optional] POELBDEPEPJ GCJLJPJHLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3B78530", Offset = "0x3B77330", VA = "0x183B78530", Slot = "9")]
	public T LHCLHJGACJJ<T>(string MAHBBBBCDEL, T JILABBLHNAO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class OJMAKIHBEJJ : HGFOMCHGKEH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LKLKDHDKACB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public NMOBHICJOGA userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public OJMAKIHBEJJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7E349F0", Offset = "0x7E337F0", VA = "0x187E349F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7E35360", Offset = "0x7E34160", VA = "0x187E35360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct GBKHIAPHEJC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7E304E0", Offset = "0x7E2F2E0", VA = "0x187E304E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7E306C0", Offset = "0x7E2F4C0", VA = "0x187E306C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct KPIHIAPFKIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public NMOBHICJOGA userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public OJMAKIHBEJJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7E33910", Offset = "0x7E32710", VA = "0x187E33910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7E33D50", Offset = "0x7E32B50", VA = "0x187E33D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct IAAPFMGDCNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public OJMAKIHBEJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public NMOBHICJOGA userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7E30CE0", Offset = "0x7E2FAE0", VA = "0x187E30CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7E310A0", Offset = "0x7E2FEA0", VA = "0x187E310A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly IReadOnlyDictionary<string, EHGHJANLCPN> HAKFOKOOJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool ELFMGNCBDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private bool OJABJAEHIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private TaskCompletionSource<bool> BAFODPHLHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private TaskCompletionSource<bool> FLFKDAKJBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly SemaphoreSlim BJMPHBKHGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private LAGNLIFCKGH OPMJKJEMPJE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task NBLLJLCCBFF
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7E38010", Offset = "0x7E36E10", VA = "0x187E38010", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task LIENGDKIHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7E37FD0", Offset = "0x7E36DD0", VA = "0x187E37FD0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DGGDEFHOBGD
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xB2CDD0", Offset = "0xB2BBD0", VA = "0x180B2CDD0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MFACGJGEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xB2CE50", Offset = "0xB2BC50", VA = "0x180B2CE50", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string IBGCILEFLOE
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7E37FC0", Offset = "0x7E36DC0", VA = "0x187E37FC0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MHLGOHLDPPN GLDABAACMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7E377B0", Offset = "0x7E365B0", VA = "0x187E377B0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KDPJGPONJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7E377E0", Offset = "0x7E365E0", VA = "0x187E377E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7E375B0", Offset = "0x7E363B0", VA = "0x187E375B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action ABMGNACOOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7E37CD0", Offset = "0x7E36AD0", VA = "0x187E37CD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7E374F0", Offset = "0x7E362F0", VA = "0x187E374F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action MIGBDDBFFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C30", Offset = "0x7E36A30", VA = "0x187E37C30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7E37230", Offset = "0x7E36030", VA = "0x187E37230", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<DJCHOLANDPD> IFNGDCNHINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7E37700", Offset = "0x7E36500", VA = "0x187E37700", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7E37650", Offset = "0x7E36450", VA = "0x187E37650", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7E37590", Offset = "0x7E36390", VA = "0x187E37590", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7E372D0", Offset = "0x7E360D0", VA = "0x187E372D0", Slot = "12")]
	[AsyncStateMachine(typeof(LKLKDHDKACB))]
	public Task DGPDNICIDDD(string FKNAGMPCGPM, [Optional] NMOBHICJOGA PDLPCFHCPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7E364F0", Offset = "0x7E352F0", VA = "0x187E364F0", Slot = "24")]
	[AsyncStateMachine(typeof(GBKHIAPHEJC))]
	public Task BAIFCPFAHAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7E373F0", Offset = "0x7E361F0", VA = "0x187E373F0", Slot = "19")]
	[AsyncStateMachine(typeof(KPIHIAPFKIJ))]
	public Task DLABKBEPOHE(NMOBHICJOGA PDLPCFHCPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7E37D70", Offset = "0x7E36B70", VA = "0x187E37D70")]
	private void JJBECJEEEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7E37880", Offset = "0x7E36680", VA = "0x187E37880", Slot = "20")]
	[AsyncStateMachine(typeof(IAAPFMGDCNC))]
	public Task HKKNEBJFBLP(NMOBHICJOGA PDLPCFHCPCF, Dictionary<string, string> MNACDFGLEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7E37B40", Offset = "0x7E36940", VA = "0x187E37B40", Slot = "21")]
	public bool IONKHKFOFKL(string JJAGFNPNLOP, bool DDLNMLHPBJD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7E36330", Offset = "0x7E35130", VA = "0x187E36330", Slot = "22")]
	public JMHJMJHGBMH ALILLJFEONE(string EJKNIJHFKPM, bool DDLNMLHPBJD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7E37020", Offset = "0x7E35E20", VA = "0x187E37020")]
	private HINALFHCCLK CKPJNMJOEPK(string EJKNIJHFKPM, bool DDLNMLHPBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7E37E10", Offset = "0x7E36C10", VA = "0x187E37E10", Slot = "23")]
	public HECMMMGBFDD KBMKLDCCCAP(string MIGNBEDBLIN, bool DDLNMLHPBJD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7E365A0", Offset = "0x7E353A0", VA = "0x187E365A0")]
	private MNLOBNBHBLN BIHPNDFGAJC(string MIGNBEDBLIN, bool DDLNMLHPBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7E366A0", Offset = "0x7E354A0", VA = "0x187E366A0")]
	private ODJPELELFIF CDLDIFLDIKC(NMOBHICJOGA PDLPCFHCPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7E37990", Offset = "0x7E36790", VA = "0x187E37990")]
	private JGNKFHMJHAA INCOJEENJGD(string FKNAGMPCGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7E36220", Offset = "0x7E35020", VA = "0x187E36220")]
	private void AAEFEGFKCGB(string EJKNIJHFKPM, HINALFHCCLK FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7E38200", Offset = "0x7E37000", VA = "0x187E38200")]
	public OJMAKIHBEJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7E36FE0", Offset = "0x7E35DE0", VA = "0x187E36FE0")]
	[CompilerGenerated]
	private void CFGFJGCOEBC(DJCHOLANDPD GCOEALJJGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7E36FE0", Offset = "0x7E35DE0", VA = "0x187E36FE0")]
	[CompilerGenerated]
	private void OFAJOOFNNFJ(DJCHOLANDPD GCOEALJJGEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class IPBBOPLKKKI : HGFOMCHGKEH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct LHELNCPDLED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public IPBBOPLKKKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public NMOBHICJOGA userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7E34010", Offset = "0x7E32E10", VA = "0x187E34010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7E34990", Offset = "0x7E33790", VA = "0x187E34990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct GDGBNPDBLJG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7E30720", Offset = "0x7E2F520", VA = "0x187E30720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD270", Offset = "0xAAC070", VA = "0x180AAD270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private OJMAKIHBEJJ OKIMADEHMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private TaskCompletionSource<bool> BAFODPHLHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private TaskCompletionSource<bool> FLFKDAKJBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Task KMHACNACEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Task FBKDOCOPNJH;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private HGFOMCHGKEH OMAGLDJIKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7E32B40", Offset = "0x7E31940", VA = "0x187E32B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MFACGJGEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7E32930", Offset = "0x7E31730", VA = "0x187E32930", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool DGGDEFHOBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7E32A70", Offset = "0x7E31870", VA = "0x187E32A70", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task NBLLJLCCBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7E32BB0", Offset = "0x7E319B0", VA = "0x187E32BB0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task LIENGDKIHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7E32AA0", Offset = "0x7E318A0", VA = "0x187E32AA0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string IBGCILEFLOE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7E32A80", Offset = "0x7E31880", VA = "0x187E32A80", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public MHLGOHLDPPN GLDABAACMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7E32400", Offset = "0x7E31200", VA = "0x187E32400", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action ABMGNACOOPM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7E32890", Offset = "0x7E31690", VA = "0x187E32890", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7E31FB0", Offset = "0x7E30DB0", VA = "0x187E31FB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action KDPJGPONJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7E32440", Offset = "0x7E31240", VA = "0x187E32440", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7E32080", Offset = "0x7E30E80", VA = "0x187E32080", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action MIGBDDBFFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7E327F0", Offset = "0x7E315F0", VA = "0x187E327F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7E31C80", Offset = "0x7E30A80", VA = "0x187E31C80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<DJCHOLANDPD> IFNGDCNHINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7E32350", Offset = "0x7E31150", VA = "0x187E32350", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7E322A0", Offset = "0x7E310A0", VA = "0x187E322A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7E32C50", Offset = "0x7E31A50", VA = "0x187E32C50")]
	[UnityEngine.Scripting.Preserve]
	public IPBBOPLKKKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7E31E30", Offset = "0x7E30C30", VA = "0x187E31E30")]
	[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
	internal static void DKGNAIFEGAN(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7E32A00", Offset = "0x7E31800", VA = "0x187E32A00")]
	internal static void KOMPHJEPACK(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7E32050", Offset = "0x7E30E50", VA = "0x187E32050", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7E31D20", Offset = "0x7E30B20", VA = "0x187E31D20", Slot = "12")]
	[AsyncStateMachine(typeof(LHELNCPDLED))]
	public Task DGPDNICIDDD(string FKNAGMPCGPM, [Optional] NMOBHICJOGA PDLPCFHCPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7E31EA0", Offset = "0x7E30CA0", VA = "0x187E31EA0", Slot = "19")]
	public Task DLABKBEPOHE(NMOBHICJOGA PDLPCFHCPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7E324E0", Offset = "0x7E312E0", VA = "0x187E324E0", Slot = "20")]
	public Task HKKNEBJFBLP(NMOBHICJOGA PDLPCFHCPCF, Dictionary<string, string> MNACDFGLEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7E326D0", Offset = "0x7E314D0", VA = "0x187E326D0", Slot = "21")]
	public bool IONKHKFOFKL(string JJAGFNPNLOP, bool DDLNMLHPBJD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7E31A70", Offset = "0x7E30870", VA = "0x187E31A70", Slot = "22")]
	public JMHJMJHGBMH ALILLJFEONE(string EJKNIJHFKPM, bool DDLNMLHPBJD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7E32940", Offset = "0x7E31740", VA = "0x187E32940", Slot = "23")]
	public HECMMMGBFDD KBMKLDCCCAP(string MIGNBEDBLIN, bool DDLNMLHPBJD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7E31B30", Offset = "0x7E30930", VA = "0x187E31B30", Slot = "24")]
	public Task BAIFCPFAHAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7E32120", Offset = "0x7E30F20", VA = "0x187E32120")]
	private static void EMAPOLCOJNH(TaskCompletionSource<bool> HLJEBJIJODM, Task HDCPMOICPIN, Task NFBMDDCFMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7E32600", Offset = "0x7E31400", VA = "0x187E32600")]
	[AsyncStateMachine(typeof(GDGBNPDBLJG))]
	private static void IOFPPJHNHMD(Task JNOGJECEFDN, TaskCompletionSource<bool> HLJEBJIJODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xF74E50", Offset = "0xF73C50", VA = "0x180F74E50")]
	[CompilerGenerated]
	private void LPGLANLAOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xFF4A10", Offset = "0xFF3810", VA = "0x180FF4A10")]
	[CompilerGenerated]
	private void MNLKINFBGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xDE7670", Offset = "0xDE6470", VA = "0x180DE7670")]
	[CompilerGenerated]
	private void IDDJNKMFOCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7E31C40", Offset = "0x7E30A40", VA = "0x187E31C40")]
	[CompilerGenerated]
	private void BIMOLJHHAKK(DJCHOLANDPD GCOEALJJGEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class HNDPEENCHBE : HECMMMGBFDD, CPNDGPKIFLK
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate void BMLOHCBGAHI(DJCHOLANDPD KABOLPPJGGF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly BMLOHCBGAHI MMJCGAEEOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly MNLOBNBHBLN IDMAJJLMJLE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string OFMLOIDKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x58C5520", Offset = "0x58C4320", VA = "0x1858C5520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string KGOLJFDDJNE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xF0AA40", Offset = "0xF09840", VA = "0x180F0AA40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x705A490", Offset = "0x7059290", VA = "0x18705A490")]
	public HNDPEENCHBE(MNLOBNBHBLN FEMFINBCNMC, [Optional] BMLOHCBGAHI GCJLJPJHLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3BB0790", Offset = "0x3BAF590", VA = "0x183BB0790", Slot = "6")]
	public T LHCLHJGACJJ<T>(string MAHBBBBCDEL, T JILABBLHNAO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EFGFDJACPAN
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[UsedImplicitly]
public class GJGKPHKNICO : EFGFDJACPAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly HDIJLECFKKG AINNNMEOEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly List<JLAKJHOMHBG> HOFCDEJENGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly string GJMOJIBICHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly string DKMOIDGOKPI;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7E30B10", Offset = "0x7E2F910", VA = "0x187E30B10")]
	[UsedImplicitly]
	[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
	internal static void KEKMDAEKNFP(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7E30B80", Offset = "0x7E2F980", VA = "0x187E30B80")]
	[RecRoom.NoEngine.Common.Preserve]
	internal GJGKPHKNICO([OLOAAHJODHH(null)][JetBrains.Annotations.NotNull] HDIJLECFKKG AINNNMEOEPL, [OLOAAHJODHH(null)][JetBrains.Annotations.NotNull] FLOKMGMFMGN KOHABHOAKPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class LMLHJLFLBBM : HGFOMCHGKEH
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Task NBLLJLCCBFF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7E35CF0", Offset = "0x7E34AF0", VA = "0x187E35CF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task LIENGDKIHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7E35C60", Offset = "0x7E34A60", VA = "0x187E35C60", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MFACGJGEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DGGDEFHOBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string IBGCILEFLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MHLGOHLDPPN GLDABAACMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action ABMGNACOOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7E35B30", Offset = "0x7E34930", VA = "0x187E35B30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7E356C0", Offset = "0x7E344C0", VA = "0x187E356C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action KDPJGPONJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7E35960", Offset = "0x7E34760", VA = "0x187E35960", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7E35760", Offset = "0x7E34560", VA = "0x187E35760", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action MIGBDDBFFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7E35A90", Offset = "0x7E34890", VA = "0x187E35A90", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7E35500", Offset = "0x7E34300", VA = "0x187E35500", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<DJCHOLANDPD> IFNGDCNHINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7E358B0", Offset = "0x7E346B0", VA = "0x187E358B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7E35800", Offset = "0x7E34600", VA = "0x187E35800", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LMLHJLFLBBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7E355A0", Offset = "0x7E343A0", VA = "0x187E355A0", Slot = "12")]
	public Task DGPDNICIDDD(string FKNAGMPCGPM, [Optional] NMOBHICJOGA PDLPCFHCPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7E35630", Offset = "0x7E34430", VA = "0x187E35630", Slot = "19")]
	public Task DLABKBEPOHE(NMOBHICJOGA PDLPCFHCPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7E35A00", Offset = "0x7E34800", VA = "0x187E35A00", Slot = "20")]
	public Task HKKNEBJFBLP(NMOBHICJOGA PDLPCFHCPCF, Dictionary<string, string> MNACDFGLEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "21")]
	public bool IONKHKFOFKL(string JJAGFNPNLOP, bool DDLNMLHPBJD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7E353C0", Offset = "0x7E341C0", VA = "0x187E353C0", Slot = "22")]
	public JMHJMJHGBMH ALILLJFEONE(string EJKNIJHFKPM, bool DDLNMLHPBJD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7E35BD0", Offset = "0x7E349D0", VA = "0x187E35BD0", Slot = "23")]
	public HECMMMGBFDD KBMKLDCCCAP(string MIGNBEDBLIN, bool DDLNMLHPBJD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7E35470", Offset = "0x7E34270", VA = "0x187E35470", Slot = "24")]
	public Task BAIFCPFAHAC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class LAGNLIFCKGH : MHLGOHLDPPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly ODJPELELFIF BDLAINEOFMF;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IReadOnlyDictionary<string, object> DBHBGBCBPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xF0D050", Offset = "0xF0BE50", VA = "0x180F0D050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	public LAGNLIFCKGH(ODJPELELFIF DEIGLJLLBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface IPPDALBHIMM
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	POHBBMBNKPO LKBEONOKPFJ(string IBDIGHFFIGL);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface CALDANMDCAE
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum ALNEOHJEEPF
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
	public enum NABOKMKEBAN
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
	long CJFLEDOLMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string ONCOOJAHFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string GEPDHMCCKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OIINDNPHHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long JKEPILHOKFN();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNODBILFAMB(long HGLHDGHKJJM, bool JIJLNCKOGED = true);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IMMMKGGEPEL(string IEOOLFDDEEF, string ANEKJEBCCOJ, string OADOKANOPOA);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KFJOGDLCNHE(Guid OHNAKIFODPI, Guid ANOLHJABADL, bool PFDKMCCCPKA);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CIFCNODNEHI(string IEOOLFDDEEF);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LMIOJPLADPI(string IEOOLFDDEEF, string KAOCLEMKPMC, string ONBEENFGPCA);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IBHLJFPIADN(string DLNGPIGGLBL, object PLLMAMBOLJM, object MFFMPBJNHCC);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EFHELBDPJLG(ALNEOHJEEPF GKDDPJDFNFK, int MFCGKLNJBDB, [Optional] KKJEHLMOIKE LIJBMNPPLHF, [Optional] string HDJENCMKHDE, [Optional] string BKBLOMKNEFC);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BJFMDJDMFAM(KKJEHLMOIKE LIJBMNPPLHF, long BENIEGAJHCB, long LHHFJNJPIBD, int FJCNMOGAJDM, string HDJENCMKHDE, int MFCGKLNJBDB);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FJLBBIBHPCE(KKJEHLMOIKE LIJBMNPPLHF, bool BIFFJAIGCIP, [Optional] string BKBLOMKNEFC);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CFFGHLJIOLE(KKJEHLMOIKE LIJBMNPPLHF, bool BIFFJAIGCIP, [Optional] string BKBLOMKNEFC);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PMOLFACHIDN(KKJEHLMOIKE LIJBMNPPLHF, bool BIFFJAIGCIP, [Optional] string BKBLOMKNEFC);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DGLMFIHMFKH(long NCGHDDJNJOM, string GENFIOKFHAD);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FNCHBGLNCBO(string EGLDLGDMAJN);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task NLJCKONGNDK(NABOKMKEBAN LJIGAFKJJAI, Guid? OCEFOHKFLDN, List<OPNNALLJDAD> NCHPPCKJIAP, List<OPNNALLJDAD> NOMFEDHBHGL, Func<AMBIDEBMCDP, long> LCHAKCLOABA, string ENKHIPKLMCG, bool? LLPMIOFJEMK, [Optional] long? JCACNGADLMN);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface BOJLGHFMIFC
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string PAFCMGIIFMP
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
