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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B437F0", Offset = "0x7B423F0", VA = "0x187B437F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
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
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B41F00", Offset = "0x7B40B00", VA = "0x187B41F00", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B45300", Offset = "0x7B43F00", VA = "0x187B45300", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
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
		public AmplitudeAnalyticsClient.Settings GMCMPNHKNEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool AIDMIIMFDFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA247B0", Offset = "0xA233B0", VA = "0x180A247B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, MIGNIEJDGMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum NEGJCLFFAJH
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class FNHPPLOBKMB
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class LFAOMCKLFAD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int GMDBDFHCDBH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> CINGKAHEJJD;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
				public LFAOMCKLFAD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class GJJDPIHNCKB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
				public GJJDPIHNCKB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x7B3E600", Offset = "0x7B3D200", VA = "0x187B3E600")]
				internal bool OIBMEFJDHMD(LFAOMCKLFAD item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string GOFLMNGENMP = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string MCLDNGJMMPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<LFAOMCKLFAD> FGMPKFAACNF;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? HIPLIOKCJDC
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x7B3D4F0", Offset = "0x7B3C0F0", VA = "0x187B3D4F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7B3D590", Offset = "0x7B3C190", VA = "0x187B3D590")]
			internal FNHPPLOBKMB(string PMGKLKBMPMB, string JHBAJGBPKBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7B3CEE0", Offset = "0x7B3BAE0", VA = "0x187B3CEE0")]
			public int GMDCJEMFCJF([Optional] int? ELNDOCKBKHO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7B3C2E0", Offset = "0x7B3AEE0", VA = "0x187B3C2E0")]
			public List<Dictionary<string, object>> AKEDOBDNELJ(int FANKJOHHPMG, int? ELNDOCKBKHO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7B3CAC0", Offset = "0x7B3B6C0", VA = "0x187B3CAC0")]
			public void CNHCKBODDBJ(AmplitudeAnalyticsIdentifyMessage KDKJDFFGNJJ, bool IIPLDGKBFKL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7B3C9B0", Offset = "0x7B3B5B0", VA = "0x187B3C9B0")]
			public void CNHCKBODDBJ(Dictionary<string, object> KDKJDFFGNJJ, bool IIPLDGKBFKL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7B3CB60", Offset = "0x7B3B760", VA = "0x187B3CB60")]
			public void DJAMCBCFLBA(params Dictionary<string, object>[] PDHHFLKBNGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7B3D090", Offset = "0x7B3BC90", VA = "0x187B3D090")]
			public void JGINMDKBIDI(List<Dictionary<string, object>> FBOBAHEIPAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7B3D2D0", Offset = "0x7B3BED0", VA = "0x187B3D2D0")]
			private void LLHCCCPKOMF(Dictionary<string, object> KDKJDFFGNJJ, bool IIPLDGKBFKL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7B3CCE0", Offset = "0x7B3B8E0", VA = "0x187B3CCE0")]
			public void GHOJJNDBBHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7B3C550", Offset = "0x7B3B150", VA = "0x187B3C550")]
			private void CJELAKDEHGC([Optional] string IKJCEDNCJCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7B3D3D0", Offset = "0x7B3BFD0", VA = "0x187B3D3D0")]
			private static string MHEKEKEEKKI(string OOHGFGHCOAJ, string MEPFFFGIFGB)
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
			[Cpp2IlInjected.Address(RVA = "0x7B44F20", Offset = "0x7B43B20", VA = "0x187B44F20")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct LHBNMCJAKPC<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int BJDHGEMKCNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string MBEBNADHDLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T IBNNBILLKDB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class NJEABIGDDDK : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private FCPCPCAPDCM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
			[DebuggerHidden]
			public NJEABIGDDDK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7B43010", Offset = "0x7B41C10", VA = "0x187B43010", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7B437A0", Offset = "0x7B423A0", VA = "0x187B437A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class JNLBFICECPH : IEnumerator<object>, IEnumerator, IDisposable
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
			public LJKIHCBBHAI quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
			[DebuggerHidden]
			public JNLBFICECPH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7B415B0", Offset = "0x7B401B0", VA = "0x187B415B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7B416C0", Offset = "0x7B402C0", VA = "0x187B416C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class FJCAOEKNHJM : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
			[DebuggerHidden]
			public FJCAOEKNHJM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7B3BB60", Offset = "0x7B3A760", VA = "0x187B3BB60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7B3BCD0", Offset = "0x7B3A8D0", VA = "0x187B3BCD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class AIGPDBFAEKK : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private FCPCPCAPDCM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
			[DebuggerHidden]
			public AIGPDBFAEKK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7B31BB0", Offset = "0x7B307B0", VA = "0x187B31BB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7B31E10", Offset = "0x7B30A10", VA = "0x187B31E10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class PCCMCEHHEAF : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private FCPCPCAPDCM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
			[DebuggerHidden]
			public PCCMCEHHEAF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7B440C0", Offset = "0x7B42CC0", VA = "0x187B440C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7B44310", Offset = "0x7B42F10", VA = "0x187B44310", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class BOPEFDNNIHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public FNHPPLOBKMB cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public BOPEFDNNIHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7B3AAD0", Offset = "0x7B396D0", VA = "0x187B3AAD0")]
			internal void PKPJFEMCKCP(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7B3A680", Offset = "0x7B39280", VA = "0x187B3A680")]
			internal void BPKOGIFFDAL(LHBNMCJAKPC<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class PJNIJDLFJMN : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private FCPCPCAPDCM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public FNHPPLOBKMB cache;

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
			private BOPEFDNNIHL <>8__1;

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
			private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
			[DebuggerHidden]
			public PJNIJDLFJMN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7B44360", Offset = "0x7B42F60", VA = "0x187B44360", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7B44B60", Offset = "0x7B43760", VA = "0x187B44B60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class PLNKFBBODNF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public PLNKFBBODNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x57E1DC0", Offset = "0x57E09C0", VA = "0x1857E1DC0")]
			internal LHBNMCJAKPC<T> KGMNLJKILFB(LIKIECGGBAG postResponse)
			{
				return default(LHBNMCJAKPC<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private HOCDMBIPNHL AGKMNPEFBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<DIPBOLKOJLA> GKELKDCLBLF;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string LPHFFCNBJGK = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string OKOGBCHJAHI = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string BBIILLEDHGK = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int KAMIBCLKGPN = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int OBGFOIOMANM = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int EFEOBFMDGMI = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float ENADHOLIKNO = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long BLOGHBIGLNF = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string ELJNAKLMJBL = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string CBIBFOKOCAP = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string LHFIEPPPBND = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string KCLLKJNGAOF = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool BBEABHHBLEJ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool LAOPBJMPLOP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int DJPEAMJJLHL;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int ANDHEFIIHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private HOFEHJLMCFI AAJFOLPJDDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DKGABJGLELN MJEMNMCCDCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private MFHMPBFKGLM ADPMIMAAEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool GCADOFAKHBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float BBJMJIKEOGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float NIGNJNLHCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int GPDKBOIIDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int NBNDLCGPIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? CNAEGHJHBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? FDDNHPKLELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long AJKMOKPFGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string GJCLKINEBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string NNPMALDBGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long FBJLGIEBFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string KONFOGCDODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string LGCEPFCMMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> JJKPILBFNCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private NEGJCLFFAJH NDKDOAIPAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int NDBCOGCFBLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int OIKPLALJAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float JMJNNMJJPOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool MHBMJJAOLLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool GKLOLJGCHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private FNHPPLOBKMB DMBLCINMMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private FNHPPLOBKMB OCONJIBNGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private FNHPPLOBKMB BDDBIAPNIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string CDKKIBKOAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> FIEADBJIACP;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo DOEAPNGMMHN;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string GMELDOEGBOO;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string IEALJKBJAPG = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string LHHEBFBIBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string JHGCPLOIAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string JPAKAOPFDNI;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private HOCDMBIPNHL CNLLMNNCGKO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7B359E0", Offset = "0x7B345E0", VA = "0x187B359E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private DIPBOLKOJLA BFEOOPEHCGO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7B370C0", Offset = "0x7B35CC0", VA = "0x187B370C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int JNENBIFGGMH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7B357E0", Offset = "0x7B343E0", VA = "0x187B357E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long NDFLLAIBDJL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7B38FB0", Offset = "0x7B37BB0", VA = "0x187B38FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7B390C0", Offset = "0x7B37CC0", VA = "0x187B390C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string PCPNFGCDGFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7B38F80", Offset = "0x7B37B80", VA = "0x187B38F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool FOFOENEBAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x15B7A80", Offset = "0x15B6680", VA = "0x1815B7A80", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x15B6420", Offset = "0x15B5020", VA = "0x1815B6420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LAEONDGMFHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA91310", Offset = "0xA8FF10", VA = "0x180A91310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA8F530", Offset = "0xA8E130", VA = "0x180A8F530")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? DHAJFLLPNIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAC08B0", Offset = "0xABF4B0", VA = "0x180AC08B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2C0", Offset = "0xC4DEC0", VA = "0x180C4F2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AKAIJGACHDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA9FBD0", Offset = "0xA9E7D0", VA = "0x180A9FBD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA9F4B0", Offset = "0xA9E0B0", VA = "0x180A9F4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool CPGNJPNLDKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7B38E60", Offset = "0x7B37A60", VA = "0x187B38E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> JOFCFFDLAEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7B38DA0", Offset = "0x7B379A0", VA = "0x187B38DA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7B39000", Offset = "0x7B37C00", VA = "0x187B39000")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7B33410", Offset = "0x7B32010", VA = "0x187B33410", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7B33A70", Offset = "0x7B32670", VA = "0x187B33A70")]
		private void BAOPELLDDDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7B383E0", Offset = "0x7B36FE0", VA = "0x187B383E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B36CD0", Offset = "0x7B358D0", VA = "0x187B36CD0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7B38710", Offset = "0x7B37310", VA = "0x187B38710")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7B37160", Offset = "0x7B35D60", VA = "0x187B37160")]
		public AFMJGMMOLON PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7B363C0", Offset = "0x7B34FC0", VA = "0x187B363C0")]
		[IteratorStateMachine(typeof(NJEABIGDDDK))]
		public IEnumerator<FCPCPCAPDCM> InitializeForLocalAccount(AmplitudeAnalyticsEvent GJDILJIKIOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7B37AC0", Offset = "0x7B366C0", VA = "0x187B37AC0")]
		public void SendAppEnterEvent(bool JHFJLDEDMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B38690", Offset = "0x7B37290", VA = "0x187B38690")]
		public void UpdateLastKnownInteractionCategory(string EDCLCOMGHHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7B385E0", Offset = "0x7B371E0", VA = "0x187B385E0")]
		public void UpdateLastAliveTime(float DJGAODFCDIF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B36460", Offset = "0x7B35060", VA = "0x187B36460")]
		private AFMJGMMOLON LHCLMHOHLMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B33100", Offset = "0x7B31D00", VA = "0x187B33100")]
		private AFMJGMMOLON AEIFOIHHDJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B37DD0", Offset = "0x7B369D0", VA = "0x187B37DD0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B36D80", Offset = "0x7B35980", VA = "0x187B36D80")]
		[IteratorStateMachine(typeof(JNLBFICECPH))]
		private IEnumerator PHKBCEBCCAC(LJKIHCBBHAI PKNKOLCIKPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B389A0", Offset = "0x7B375A0", VA = "0x187B389A0")]
		[IteratorStateMachine(typeof(FJCAOEKNHJM))]
		public IEnumerator WaitForFlush(float AJHEJELDLBD = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7B384C0", Offset = "0x7B370C0", VA = "0x187B384C0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B38400", Offset = "0x7B37000", VA = "0x187B38400")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime COICELPPBEA)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B35ED0", Offset = "0x7B34AD0", VA = "0x187B35ED0")]
		public static MKFOLPDHFEK Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B33270", Offset = "0x7B31E70", VA = "0x187B33270")]
		public static MCLCLIDMJMI AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string OGBAIIMIPOE, string HFCFEBHICAO, KACIKJNKODF AOLAFIIMIDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7B354E0", Offset = "0x7B340E0", VA = "0x187B354E0")]
		public static MCLCLIDMJMI Event([JetBrains.Annotations.NotNull] string OGBAIIMIPOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7B372F0", Offset = "0x7B35EF0", VA = "0x187B372F0")]
		public static MCLCLIDMJMI PreviousSessionEvent([JetBrains.Annotations.NotNull] string OGBAIIMIPOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7B36070", Offset = "0x7B34C70", VA = "0x187B36070")]
		public static MCLCLIDMJMI InitializeEvent(string HFCFEBHICAO, int MMIBEMODIIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7B37FD0", Offset = "0x7B36BD0", VA = "0x187B37FD0")]
		public static MCLCLIDMJMI StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7B34C20", Offset = "0x7B33820", VA = "0x187B34C20")]
		public static MCLCLIDMJMI CreateOutOfSessionEvent(string OGBAIIMIPOE, bool LLPIKAKNOOG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B36800", Offset = "0x7B35400", VA = "0x187B36800")]
		public static AFMJGMMOLON LogOutOfSessionEvent(MCLCLIDMJMI MCHAPCEDGAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B365A0", Offset = "0x7B351A0", VA = "0x187B365A0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent MBKHBFNKNHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7B369C0", Offset = "0x7B355C0", VA = "0x187B369C0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent MBKHBFNKNHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B36AF0", Offset = "0x7B356F0", VA = "0x187B36AF0")]
		public void LogSerializedEventAsync(Dictionary<string, object> BBNEDKHNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B366D0", Offset = "0x7B352D0", VA = "0x187B366D0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage KMBEKPMLIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B36BD0", Offset = "0x7B357D0", VA = "0x187B36BD0")]
		private void OFACDGFCOBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B36E10", Offset = "0x7B35A10", VA = "0x187B36E10")]
		private void PIMMEIKGIME(Dictionary<string, object> DFEBMFPCKKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7B35DE0", Offset = "0x7B349E0", VA = "0x187B35DE0")]
		private void IPIFOCAHPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B35B00", Offset = "0x7B34700", VA = "0x187B35B00")]
		private void GMMGIPPEKNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7B35A70", Offset = "0x7B34670", VA = "0x187B35A70")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7B36510", Offset = "0x7B35110", VA = "0x187B36510")]
		[IteratorStateMachine(typeof(AIGPDBFAEKK))]
		private IEnumerator<FCPCPCAPDCM> LLJPCGGIBON(float AJHEJELDLBD = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7B34B90", Offset = "0x7B33790", VA = "0x187B34B90")]
		[IteratorStateMachine(typeof(PCCMCEHHEAF))]
		private IEnumerator<FCPCPCAPDCM> CODPIJKHKNK(float AJHEJELDLBD = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7B34EE0", Offset = "0x7B33AE0", VA = "0x187B34EE0")]
		[IteratorStateMachine(typeof(PJNIJDLFJMN))]
		private IEnumerator<FCPCPCAPDCM> EEMGKNGJKLG(FNHPPLOBKMB AFHEFLCAFIP, int? ELNDOCKBKHO, string MODLOGLPJPA, float AJHEJELDLBD, Action<int> FECEFIDNENH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7B35CD0", Offset = "0x7B348D0", VA = "0x187B35CD0")]
		private static void HLHKGLHLLBI(bool PCDMGKMHBOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7B352A0", Offset = "0x7B33EA0", VA = "0x187B352A0")]
		private KLHBLGBFFDH<LHBNMCJAKPC<Dictionary<string, object>>> ELIBKJJIFLO(string MODLOGLPJPA, string OEOEJMMAAEB, Dictionary<string, object> IBNNBILLKDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B34FC0", Offset = "0x7B33BC0", VA = "0x187B34FC0")]
		private KLHBLGBFFDH<LHBNMCJAKPC<List<Dictionary<string, object>>>> ELIBKJJIFLO(string MODLOGLPJPA, string OEOEJMMAAEB, List<Dictionary<string, object>> IBNNBILLKDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x307CD20", Offset = "0x307B920", VA = "0x18307CD20")]
		private KLHBLGBFFDH<LHBNMCJAKPC<T>> JHKNDKFPEFI<T>(string CHBGJAJJFLD, string MODLOGLPJPA, string OEOEJMMAAEB, T IBNNBILLKDB, Dictionary<string, object> OACBIBFLBBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B37110", Offset = "0x7B35D10", VA = "0x187B37110")]
		private bool PNHHOGHNKHB(float FJMHMJLNBID, float AJHEJELDLBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B33E30", Offset = "0x7B32A30", VA = "0x187B33E30")]
		private Dictionary<string, object> BKIDELBADJE(string MODLOGLPJPA, Dictionary<string, object> IBNNBILLKDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7B38A90", Offset = "0x7B37690", VA = "0x187B38A90")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1A0", Offset = "0xA49DA0", VA = "0x180A4B1A0", Slot = "6")]
		private bool PNAGGHBGEHF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B35370", Offset = "0x7B33F70", VA = "0x187B35370")]
		[CompilerGenerated]
		private long ENBEIFHEHNA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B36450", Offset = "0x7B35050", VA = "0x187B36450")]
		[CompilerGenerated]
		private void LFNEAGIDMOG(int MMIEAGDIJNP)
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
			[Cpp2IlInjected.Address(RVA = "0x7B39DA0", Offset = "0x7B389A0", VA = "0x187B39DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7B39E70", Offset = "0x7B38A70", VA = "0x187B39E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7B39DE0", Offset = "0x7B389E0", VA = "0x187B39DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7B39EC0", Offset = "0x7B38AC0", VA = "0x187B39EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7B39D60", Offset = "0x7B38960", VA = "0x187B39D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7B39E20", Offset = "0x7B38A20", VA = "0x187B39E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA1FDD0", Offset = "0xA1E9D0", VA = "0x180A1FDD0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7B393F0", Offset = "0x7B37FF0", VA = "0x187B393F0")]
		public static MCLCLIDMJMI GLOMJONEBBE(string JBMEHOAGBAN, [JetBrains.Annotations.NotNull] string GIFLBJADOFH, long JNOOHOGABAI, long CNLKGMCNLNG, string HFCFEBHICAO, string AOLAFIIMIDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7B39290", Offset = "0x7B37E90", VA = "0x187B39290")]
		public static MCLCLIDMJMI FOMDLLNGKKG(string JBMEHOAGBAN, [JetBrains.Annotations.NotNull] string GIFLBJADOFH, long JNOOHOGABAI, long CNLKGMCNLNG, string HFCFEBHICAO, long PLOHDHBIINL, string LJJHLPBDNKF, string JKNPIGDKIHD, string FCEEDHBFKGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7B39BC0", Offset = "0x7B387C0", VA = "0x187B39BC0")]
		private AmplitudeAnalyticsEvent(string JBMEHOAGBAN, [JetBrains.Annotations.NotNull] string GIFLBJADOFH, long JNOOHOGABAI, long CNLKGMCNLNG, string HFCFEBHICAO, string AOLAFIIMIDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xF0E710", Offset = "0xF0D310", VA = "0x180F0E710")]
		public void INCOCBMIHFO(long KCEFHPGPOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7B394F0", Offset = "0x7B380F0", VA = "0x187B394F0", Slot = "5")]
		public override void IMCMOCMMPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7B39120", Offset = "0x7B37D20", VA = "0x187B39120", Slot = "6")]
		public override void CANFMKKAMHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B395F0", Offset = "0x7B381F0", VA = "0x187B395F0", Slot = "4")]
		protected override Dictionary<string, object> MMIKDIOEFAC(Dictionary<string, object> DOGNAIEHNBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B39AB0", Offset = "0x7B386B0", VA = "0x187B39AB0")]
		private void NNEFLLLAHAF(string MEPFFFGIFGB, string OOHGFGHCOAJ, bool FHMGGOIGPOC = false)
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
			[Cpp2IlInjected.Address(RVA = "0x7B3B900", Offset = "0x7B3A500", VA = "0x187B3B900")]
			public void AGEILFIDNOP(Dictionary<string, object> IAHPLBNFODO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B44BB0", Offset = "0x7B437B0", VA = "0x187B44BB0")]
			public void AGEILFIDNOP(Dictionary<string, object> IDKHAIIGFKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x14276E0", Offset = "0x14262E0", VA = "0x1814276E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7B3A000", Offset = "0x7B38C00", VA = "0x187B3A000")]
		public static MKFOLPDHFEK GLOMJONEBBE(string JBMEHOAGBAN, string HFCFEBHICAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B3A5C0", Offset = "0x7B391C0", VA = "0x187B3A5C0")]
		protected AmplitudeAnalyticsIdentifyMessage(string JBMEHOAGBAN, string HFCFEBHICAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B3A530", Offset = "0x7B39130", VA = "0x187B3A530")]
		public Dictionary<string, object> PKNLFLALLAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B3A1F0", Offset = "0x7B38DF0", VA = "0x187B3A1F0", Slot = "4")]
		protected virtual Dictionary<string, object> MMIKDIOEFAC(Dictionary<string, object> DOGNAIEHNBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B3A150", Offset = "0x7B38D50", VA = "0x187B3A150")]
		protected void MIJKGOHHKEE(string MEPFFFGIFGB, Dictionary<string, object> EHLHJOJDEOG, Dictionary<string, object> IJHIMLKPELP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B39F90", Offset = "0x7B38B90", VA = "0x187B39F90")]
		protected void DOOKEMAEIGF(string MEPFFFGIFGB, string OOHGFGHCOAJ, Dictionary<string, object> OFPKELLCDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B3A0C0", Offset = "0x7B38CC0", VA = "0x187B3A0C0", Slot = "5")]
		public virtual void IMCMOCMMPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B39F10", Offset = "0x7B38B10", VA = "0x187B39F10", Slot = "6")]
		public virtual void CANFMKKAMHJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MKFOLPDHFEK : MJMPJEHMPBM<AmplitudeAnalyticsIdentifyMessage, MKFOLPDHFEK>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override MKFOLPDHFEK HBJGPGODEAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage DOFAAPGJEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7B423B0", Offset = "0x7B40FB0", VA = "0x187B423B0")]
	public MKFOLPDHFEK(AmplitudeAnalyticsIdentifyMessage FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7B42310", Offset = "0x7B40F10", VA = "0x187B42310", Slot = "4")]
	public override void CANFMKKAMHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MCLCLIDMJMI : MJMPJEHMPBM<AmplitudeAnalyticsEvent, MCLCLIDMJMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool HOEEHHNJEMN;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override MCLCLIDMJMI HBJGPGODEAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long HBKOEMHGDND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7B42250", Offset = "0x7B40E50", VA = "0x187B42250")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7B419D0", Offset = "0x7B405D0", VA = "0x187B419D0")]
	public MCLCLIDMJMI(AmplitudeAnalyticsEvent FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "5")]
	public override AmplitudeAnalyticsEvent DOFAAPGJEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7B42080", Offset = "0x7B40C80", VA = "0x187B42080", Slot = "4")]
	public override void CANFMKKAMHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3BAD6C0", Offset = "0x3BAC2C0", VA = "0x183BAD6C0")]
	public MCLCLIDMJMI BPPGBLBHPKB<T>(string NMCGBFDKCMK, T[] OOHGFGHCOAJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3BAD6C0", Offset = "0x3BAC2C0", VA = "0x183BAD6C0")]
	public MCLCLIDMJMI BPPGBLBHPKB(string NMCGBFDKCMK, string[] OOHGFGHCOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3BAD410", Offset = "0x3BAC010", VA = "0x183BAD410")]
	public MCLCLIDMJMI BPPGBLBHPKB<T>(string NMCGBFDKCMK, T OOHGFGHCOAJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7B42000", Offset = "0x7B40C00", VA = "0x187B42000")]
	public MCLCLIDMJMI BPPGBLBHPKB(string NMCGBFDKCMK, long OOHGFGHCOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7B41F90", Offset = "0x7B40B90", VA = "0x187B41F90")]
	public MCLCLIDMJMI BPPGBLBHPKB(string NMCGBFDKCMK, string OOHGFGHCOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7B42220", Offset = "0x7B40E20", VA = "0x187B42220")]
	public MCLCLIDMJMI EPAPIOHILHB(string NMCGBFDKCMK, object? OOHGFGHCOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7B42270", Offset = "0x7B40E70", VA = "0x187B42270")]
	public MCLCLIDMJMI JOFHOMOMEJN(string NMCGBFDKCMK, string OOHGFGHCOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7B42120", Offset = "0x7B40D20", VA = "0x187B42120")]
	private MCLCLIDMJMI DMJHFHDDJKA(string NMCGBFDKCMK, object OOHGFGHCOAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KHNPEJNDNAF : MCLCLIDMJMI
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7B419D0", Offset = "0x7B405D0", VA = "0x187B419D0")]
	public KHNPEJNDNAF(AmplitudeAnalyticsEvent FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7B41830", Offset = "0x7B40430", VA = "0x187B41830", Slot = "4")]
	public override void CANFMKKAMHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class MJMPJEHMPBM<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : MJMPJEHMPBM<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M FNFIPKNHEOF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR HBJGPGODEAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public MJMPJEHMPBM(M FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x54C4B40", Offset = "0x54C3740", VA = "0x1854C4B40")]
	public BLDR OBJKKAMFDNI(AmplitudeAnalyticsIdentifyMessage.DeviceInfo DDDMGIKCEIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x54C49F0", Offset = "0x54C35F0", VA = "0x1854C49F0")]
	public BLDR HLGKOOCDONG(AmplitudeAnalyticsIdentifyMessage.RevenueData PJJPNJDPJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x54C4980", Offset = "0x54C3580", VA = "0x1854C4980")]
	public BLDR HKNLGDLGKNO(string NMCGBFDKCMK, string OOHGFGHCOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x41E6E20", Offset = "0x41E5A20", VA = "0x1841E6E20")]
	public BLDR HKNLGDLGKNO<T>(string NMCGBFDKCMK, T OOHGFGHCOAJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void CANFMKKAMHJ();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x54C4950", Offset = "0x54C3550", VA = "0x1854C4950")]
	internal static string BKKHNKGEHPI(string OOHGFGHCOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x54C4A40", Offset = "0x54C3640", VA = "0x1854C4A40")]
	private BLDR IELMFNJKMNO(string NMCGBFDKCMK, object OOHGFGHCOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M DOFAAPGJEIJ();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class OGDINONLILH : HOFEHJLMCFI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct HDFFGPPOMBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<LIKIECGGBAG> <>t__builder;

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
		public OGDINONLILH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7B3EA50", Offset = "0x7B3D650", VA = "0x187B3EA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B3F480", Offset = "0x7B3E080", VA = "0x187B3F480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient KPLBPLDNILG;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B439E0", Offset = "0x7B425E0", VA = "0x187B439E0")]
	[IGNGJLOKDFM.EEFPBBAIHAI]
	internal static void MMJHJLCPJFA(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7B43A50", Offset = "0x7B42650", VA = "0x187B43A50")]
	[RecRoom.NoEngine.Common.Preserve]
	public OGDINONLILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7B43870", Offset = "0x7B42470", VA = "0x187B43870", Slot = "4")]
	[AsyncStateMachine(typeof(HDFFGPPOMBG))]
	public Task<LIKIECGGBAG> DPIFEHHILJM(string CHBGJAJJFLD, string NOAPJGCMPMD, string DAALDNDKFEL, string DMPLLINAEJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class DKLMHNFNLBC : HOFEHJLMCFI
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FCNDDGGINIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<LIKIECGGBAG> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FCNDDGGINIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7B3BA80", Offset = "0x7B3A680", VA = "0x187B3BA80")]
		internal void IPKPBNGIMGD(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct FMGOCPBACJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<LIKIECGGBAG> <>t__builder;

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
		private TaskAwaiter<LIKIECGGBAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7B3BD20", Offset = "0x7B3A920", VA = "0x187B3BD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7B3C270", Offset = "0x7B3AE70", VA = "0x187B3C270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	[IGNGJLOKDFM.EEFPBBAIHAI]
	internal static void HNEIGBBBJJM(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DKLMHNFNLBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B7A0", Offset = "0x7B3A3A0", VA = "0x187B3B7A0", Slot = "4")]
	[AsyncStateMachine(typeof(FMGOCPBACJA))]
	public Task<LIKIECGGBAG> DPIFEHHILJM(string CHBGJAJJFLD, string NOAPJGCMPMD, string DAALDNDKFEL, string DMPLLINAEJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GPHHNCGHCBM
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> CDFPINNFILD;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7B3E8B0", Offset = "0x7B3D4B0", VA = "0x187B3E8B0")]
	internal static bool CEHEMACFFCD(string MEPFFFGIFGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface HOFEHJLMCFI
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LIKIECGGBAG> DPIFEHHILJM(string CHBGJAJJFLD, string NOAPJGCMPMD, string DAALDNDKFEL, string DMPLLINAEJK);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct LIKIECGGBAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int FLDKAODJBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string GFLOPIIKPLJ;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x17BE2E0", Offset = "0x17BCEE0", VA = "0x1817BE2E0")]
	public LIKIECGGBAG(int BJDHGEMKCNI, string MBEBNADHDLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum GONBJFCOECL
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
public class GDFHMNNNBDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private long MHJIMIOKLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private MCLCLIDMJMI OCBBJACBAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool EFDHOLLALNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private float NHBLDIHHBIG;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7B3DA90", Offset = "0x7B3C690", VA = "0x187B3DA90")]
	public GDFHMNNNBDC(string JPHODODLEDH, float NHBLDIHHBIG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A84AF0", Offset = "0x3A836F0", VA = "0x183A84AF0")]
	public void BPPGBLBHPKB<T>(string NMCGBFDKCMK, T OOHGFGHCOAJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7B3D810", Offset = "0x7B3C410", VA = "0x187B3D810")]
	public void BPPGBLBHPKB(string NMCGBFDKCMK, string OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7B3D890", Offset = "0x7B3C490", VA = "0x187B3D890")]
	public void HGEMMCHFCAD(string MEPDPKDMEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7B3D980", Offset = "0x7B3C580", VA = "0x187B3D980")]
	public void HKJENDLFFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7B3D700", Offset = "0x7B3C300", VA = "0x187B3D700")]
	private void BEBHEGMKNDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7B3DA40", Offset = "0x7B3C640", VA = "0x187B3DA40")]
	private bool NEBMAKCIJJE()
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
		public enum EBAEPOKGGLE
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
		private EBAEPOKGGLE parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public EBAEPOKGGLE Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xA768B0", Offset = "0xA754B0", VA = "0x180A768B0")]
			get
			{
				return default(EBAEPOKGGLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA4B580", Offset = "0xA4A180", VA = "0x180A4B580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B44D20", Offset = "0x7B43920", VA = "0x187B44D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JPDPFNKCJJN<T> : NBDOEJMAKOF<T>, DAHLPMNKJIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly AHEAEJOKBNI BKHLAMDGECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string EFIHPJLECIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly string CMKDJEIPEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private T FHLOHBNEJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly T IPOLOHBNCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool OCFIKEMMPAM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string KKOKDCCMBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5118000", Offset = "0x5116C00", VA = "0x185118000")]
	public JPDPFNKCJJN(AHEAEJOKBNI BKHLAMDGECL, string EFIHPJLECIH, string CMKDJEIPEGK, T IPOLOHBNCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5117DE0", Offset = "0x51169E0", VA = "0x185117DE0", Slot = "4")]
	public T EMBLLFFHGFA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5117F60", Offset = "0x5116B60", VA = "0x185117F60", Slot = "6")]
	public void ILJKHADAMOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
public class LLFJPFBJIKP : JBLDADGINPM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct KHLAIAEIHPM : IEquatable<KHLAIAEIHPM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly string MGGGGGMFOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly string PIMNNCFGKMA;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xB5F450", Offset = "0xB5E050", VA = "0x180B5F450")]
		public KHLAIAEIHPM(string OMMLGLNLJKA, string FNJBPAHDKKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x12B1B50", Offset = "0x12B0750", VA = "0x1812B1B50", Slot = "4")]
		public bool Equals(KHLAIAEIHPM GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B41710", Offset = "0x7B40310", VA = "0x187B41710", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B417C0", Offset = "0x7B403C0", VA = "0x187B417C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private AHEAEJOKBNI BKHLAMDGECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Dictionary<KHLAIAEIHPM, DAHLPMNKJIC> MNGNCDJHKMC;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7B41CE0", Offset = "0x7B408E0", VA = "0x187B41CE0")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	internal static void OMKCNNEBHOD(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7B41D50", Offset = "0x7B40950", VA = "0x187B41D50")]
	[RecRoom.NoEngine.Common.Preserve]
	public LLFJPFBJIKP([System.Diagnostics.CodeAnalysis.NotNull][GFNPNOLPMKK(null)] AHEAEJOKBNI BKHLAMDGECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7B41A30", Offset = "0x7B40630", VA = "0x187B41A30", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7B41A20", Offset = "0x7B40620", VA = "0x187B41A20")]
	private void AAOKKAJKAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7B41B30", Offset = "0x7B40730", VA = "0x187B41B30")]
	private void FGGDKCBNIJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3B973F0", Offset = "0x3B95FF0", VA = "0x183B973F0", Slot = "4")]
	public NBDOEJMAKOF<T> EPJOEHOGBHL<T>(string EFIHPJLECIH, string IBNEBNKOENF, T IPOLOHBNCGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class JKHHNOEJPMK : GOGBMJLGOJH, PEGECOPEEON
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void FHIKCNMBBKO(FBKFLBKNBDC NHHIAALKODJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly FPHFKBNFFKD NODKOBAEEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly FHIKCNMBBKO KGDDLCOHJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly string EINJBFGJMNE;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string AJPMCBKCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x116B720", Offset = "0x116A320", VA = "0x18116B720", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string ILFNOCJNCMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5530", Offset = "0x1CF4130", VA = "0x181CF5530", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool GCPLPNNDDBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B41590", Offset = "0x7B40190", VA = "0x187B41590", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool ONOAGFBEBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B41570", Offset = "0x7B40170", VA = "0x187B41570", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyList<string> MJGCOIMDLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1CF52D0", Offset = "0x1CF3ED0", VA = "0x181CF52D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x130AA30", Offset = "0x1309630", VA = "0x18130AA30")]
	public JKHHNOEJPMK(FPHFKBNFFKD JLMFPIBLIFF, string JGDJJLCDNIA, [Optional] FHIKCNMBBKO LKMBAOIDFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3B26720", Offset = "0x3B25320", VA = "0x183B26720", Slot = "9")]
	public T LBDBFELEJGA<T>(string MEPFFFGIFGB, T IPOLOHBNCGD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class IOCFILAPDHM : AHEAEJOKBNI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NCODNEPNGLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public DKGABJGLELN userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public IOCFILAPDHM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7B42400", Offset = "0x7B41000", VA = "0x187B42400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7B42D70", Offset = "0x7B41970", VA = "0x187B42D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct GPEJHNLBJIC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7B3E670", Offset = "0x7B3D270", VA = "0x187B3E670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E850", Offset = "0x7B3D450", VA = "0x187B3E850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct AFECENAFDLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public DKGABJGLELN userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public IOCFILAPDHM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7B31720", Offset = "0x7B30320", VA = "0x187B31720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7B31B50", Offset = "0x7B30750", VA = "0x187B31B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct PBCGLELKNID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public IOCFILAPDHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public DKGABJGLELN userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7B43CA0", Offset = "0x7B428A0", VA = "0x187B43CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7B44060", Offset = "0x7B42C60", VA = "0x187B44060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly IReadOnlyDictionary<string, AAJBEINADMN> NCKPIGLHIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool CPNECPJHADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private bool PGGGMNEAAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private TaskCompletionSource<bool> MLMGPLKCKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private TaskCompletionSource<bool> NAFDKIPMBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly SemaphoreSlim AMIGPEIGDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private GGPPABGFDBJ OKBADFIALGA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task GOINPCAHIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7B40120", Offset = "0x7B3ED20", VA = "0x187B40120", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task HJBJOGAIBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7B40160", Offset = "0x7B3ED60", VA = "0x187B40160", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool JGPIJEEOOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xAA8AD0", Offset = "0xAA76D0", VA = "0x180AA8AD0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool KCHAALCBHPI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8AC0", Offset = "0xAA76C0", VA = "0x180AA8AC0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string LAEONDGMFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7B41080", Offset = "0x7B3FC80", VA = "0x187B41080", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public EOBKONMKBGO KJFIJPNHJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7B3FEE0", Offset = "0x7B3EAE0", VA = "0x187B3FEE0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OJNKMLBDGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7B402E0", Offset = "0x7B3EEE0", VA = "0x187B402E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7B40240", Offset = "0x7B3EE40", VA = "0x187B40240", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PCBMDMOJCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7B41180", Offset = "0x7B3FD80", VA = "0x187B41180", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7B40ED0", Offset = "0x7B3FAD0", VA = "0x187B40ED0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AMCOHJKILLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7B40530", Offset = "0x7B3F130", VA = "0x187B40530", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7B401A0", Offset = "0x7B3EDA0", VA = "0x187B401A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<FBKFLBKNBDC> CNIHAIFLFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D00", Offset = "0x7B3F900", VA = "0x187B40D00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7B40AA0", Offset = "0x7B3F6A0", VA = "0x187B40AA0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7B40100", Offset = "0x7B3ED00", VA = "0x187B40100", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7B40DB0", Offset = "0x7B3F9B0", VA = "0x187B40DB0", Slot = "12")]
	[AsyncStateMachine(typeof(NCODNEPNGLC))]
	public Task LEIJOMGLGOC(string JHBAJGBPKBD, [Optional] DKGABJGLELN GJJLHHDMOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7B40480", Offset = "0x7B3F080", VA = "0x187B40480", Slot = "24")]
	[AsyncStateMachine(typeof(GPEJHNLBJIC))]
	public Task HDGGKGECLNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7B40380", Offset = "0x7B3EF80", VA = "0x187B40380", Slot = "19")]
	[AsyncStateMachine(typeof(AFECENAFDLN))]
	public Task HDBCCNCIPMD(DKGABJGLELN GJJLHHDMOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7B41220", Offset = "0x7B3FE20", VA = "0x187B41220")]
	private void OPIDJEHMOMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7B40F70", Offset = "0x7B3FB70", VA = "0x187B40F70", Slot = "20")]
	[AsyncStateMachine(typeof(PBCGLELKNID))]
	public Task LMEJMOALHDL(DKGABJGLELN GJJLHHDMOLL, Dictionary<string, string> CIMAKELHLEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7B41090", Offset = "0x7B3FC90", VA = "0x187B41090", Slot = "21")]
	public bool MJPMBJJNLPN(string NBIPLKMJGLI, bool AAJKGOHMJMP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7B405D0", Offset = "0x7B3F1D0", VA = "0x187B405D0", Slot = "22")]
	public GOGBMJLGOJH JCNDKGEPHIE(string JGDJJLCDNIA, bool AAJKGOHMJMP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7B40790", Offset = "0x7B3F390", VA = "0x187B40790")]
	private FPHFKBNFFKD JKLFPOMJDDH(string JGDJJLCDNIA, bool AAJKGOHMJMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7B3FF10", Offset = "0x7B3EB10", VA = "0x187B3FF10", Slot = "23")]
	public FODFGGEKHLO CDFGOCFDNCE(string OMMLGLNLJKA, bool AAJKGOHMJMP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7B409A0", Offset = "0x7B3F5A0", VA = "0x187B409A0")]
	private NMJDOJOHKOM KAGALHCNIPO(string OMMLGLNLJKA, bool AAJKGOHMJMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7B3F4F0", Offset = "0x7B3E0F0", VA = "0x187B3F4F0")]
	private AHCFAHDIOPP ACLKLHMJDLN(DKGABJGLELN GJJLHHDMOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40B50", Offset = "0x7B3F750", VA = "0x187B40B50")]
	private JIHDAILAAGJ KKCDFEHAJKM(string JHBAJGBPKBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7B3FDD0", Offset = "0x7B3E9D0", VA = "0x187B3FDD0")]
	private void AOCPIOMEONP(string JGDJJLCDNIA, FPHFKBNFFKD JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7B41470", Offset = "0x7B40070", VA = "0x187B41470")]
	public IOCFILAPDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7B400C0", Offset = "0x7B3ECC0", VA = "0x187B400C0")]
	[CompilerGenerated]
	private void CFKJCNAGMKH(FBKFLBKNBDC DGCKGHIBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7B400C0", Offset = "0x7B3ECC0", VA = "0x187B400C0")]
	[CompilerGenerated]
	private void NAEHMHNOBFJ(FBKFLBKNBDC DGCKGHIBLHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class ALBNFPGNKGD : AHEAEJOKBNI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GIPDADHPPBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public ALBNFPGNKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public DKGABJGLELN userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DC20", Offset = "0x7B3C820", VA = "0x187B3DC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E5A0", Offset = "0x7B3D1A0", VA = "0x187B3E5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct NDOMJFKKCFB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7B42DD0", Offset = "0x7B419D0", VA = "0x187B42DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private IOCFILAPDHM BBKJHKNFHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private TaskCompletionSource<bool> MLMGPLKCKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private TaskCompletionSource<bool> NAFDKIPMBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Task AAPLHNECGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Task CNFBDMPDOBK;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private AHEAEJOKBNI KIEIIBLKGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7B32890", Offset = "0x7B31490", VA = "0x187B32890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool KCHAALCBHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7B32F80", Offset = "0x7B31B80", VA = "0x187B32F80", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool JGPIJEEOOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7B32110", Offset = "0x7B30D10", VA = "0x187B32110", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task GOINPCAHIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7B32120", Offset = "0x7B30D20", VA = "0x187B32120", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task HJBJOGAIBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7B321C0", Offset = "0x7B30DC0", VA = "0x187B321C0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string LAEONDGMFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7B32D30", Offset = "0x7B31930", VA = "0x187B32D30", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public EOBKONMKBGO KJFIJPNHJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7B31E60", Offset = "0x7B30A60", VA = "0x187B31E60", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action PCBMDMOJCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7B32E70", Offset = "0x7B31A70", VA = "0x187B32E70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7B32B70", Offset = "0x7B31770", VA = "0x187B32B70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action OJNKMLBDGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7B32470", Offset = "0x7B31070", VA = "0x187B32470", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7B323D0", Offset = "0x7B30FD0", VA = "0x187B323D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action AMCOHJKILLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7B32730", Offset = "0x7B31330", VA = "0x187B32730", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7B32330", Offset = "0x7B30F30", VA = "0x187B32330", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<FBKFLBKNBDC> CNIHAIFLFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7B329B0", Offset = "0x7B315B0", VA = "0x187B329B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7B32900", Offset = "0x7B31500", VA = "0x187B32900", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7B33040", Offset = "0x7B31C40", VA = "0x187B33040")]
	[UnityEngine.Scripting.Preserve]
	public ALBNFPGNKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7B32F10", Offset = "0x7B31B10", VA = "0x187B32F10")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	internal static void OMKCNNEBHOD(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7B32FD0", Offset = "0x7B31BD0", VA = "0x187B32FD0")]
	internal static void PLPDMHHNIGO(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7B320E0", Offset = "0x7B30CE0", VA = "0x187B320E0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7B32A60", Offset = "0x7B31660", VA = "0x187B32A60", Slot = "12")]
	[AsyncStateMachine(typeof(GIPDADHPPBB))]
	public Task LEIJOMGLGOC(string JHBAJGBPKBD, [Optional] DKGABJGLELN GJJLHHDMOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7B32510", Offset = "0x7B31110", VA = "0x187B32510", Slot = "19")]
	public Task HDBCCNCIPMD(DKGABJGLELN GJJLHHDMOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7B32C10", Offset = "0x7B31810", VA = "0x187B32C10", Slot = "20")]
	public Task LMEJMOALHDL(DKGABJGLELN GJJLHHDMOLL, Dictionary<string, string> CIMAKELHLEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7B32D50", Offset = "0x7B31950", VA = "0x187B32D50", Slot = "21")]
	public bool MJPMBJJNLPN(string NBIPLKMJGLI, bool AAJKGOHMJMP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7B327D0", Offset = "0x7B313D0", VA = "0x187B327D0", Slot = "22")]
	public GOGBMJLGOJH JCNDKGEPHIE(string JGDJJLCDNIA, bool AAJKGOHMJMP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7B31EA0", Offset = "0x7B30AA0", VA = "0x187B31EA0", Slot = "23")]
	public FODFGGEKHLO CDFGOCFDNCE(string OMMLGLNLJKA, bool AAJKGOHMJMP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7B32620", Offset = "0x7B31220", VA = "0x187B32620", Slot = "24")]
	public Task HDGGKGECLNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7B31F60", Offset = "0x7B30B60", VA = "0x187B31F60")]
	private static void DNFPKFPNCDO(TaskCompletionSource<bool> GGCMENFMEPO, Task MCABGLFACAO, Task COCPIEMJFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7B32260", Offset = "0x7B30E60", VA = "0x187B32260")]
	[AsyncStateMachine(typeof(NDOMJFKKCFB))]
	private static void EJIFHBMCEHI(Task NKDMFOKACBI, TaskCompletionSource<bool> GGCMENFMEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xF0BFE0", Offset = "0xF0ABE0", VA = "0x180F0BFE0")]
	[CompilerGenerated]
	private void IBNJAJPOMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xF79990", Offset = "0xF78590", VA = "0x180F79990")]
	[CompilerGenerated]
	private void IDFHKLOFGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xD7A390", Offset = "0xD78F90", VA = "0x180D7A390")]
	[CompilerGenerated]
	private void PGNGHKOIJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7B32F90", Offset = "0x7B31B90", VA = "0x187B32F90")]
	[CompilerGenerated]
	private void PGAGIAHKHJK(FBKFLBKNBDC DGCKGHIBLHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class OEOLMGPLPOB : FODFGGEKHLO, PEGECOPEEON
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate void LIMIAECBLAB(FBKFLBKNBDC NHHIAALKODJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly LIMIAECBLAB KGDDLCOHJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly NMJDOJOHKOM HDGJDPMFHAO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string AJPMCBKCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x56AE590", Offset = "0x56AD190", VA = "0x1856AE590", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string ILFNOCJNCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xE9DB20", Offset = "0xE9C720", VA = "0x180E9DB20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A440", Offset = "0x6D89040", VA = "0x186D8A440")]
	public OEOLMGPLPOB(NMJDOJOHKOM EFIHPJLECIH, [Optional] LIMIAECBLAB LKMBAOIDFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3C6EB90", Offset = "0x3C6D790", VA = "0x183C6EB90", Slot = "6")]
	public T LBDBFELEJGA<T>(string MEPFFFGIFGB, T IPOLOHBNCGD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface LOOLKDEIONG
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[UsedImplicitly]
public class OKBIKLFNBBP : LOOLKDEIONG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly PNALEEIJDPC CCFHPONJEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly List<HOIJHMCGCLF> BPEKHINEJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly string FIENMGLILDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly string JEENPAHHGAC;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7B43AD0", Offset = "0x7B426D0", VA = "0x187B43AD0")]
	[UsedImplicitly]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	internal static void BACILHPJJBN(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7B43B40", Offset = "0x7B42740", VA = "0x187B43B40")]
	[RecRoom.NoEngine.Common.Preserve]
	internal OKBIKLFNBBP([GFNPNOLPMKK(null)][JetBrains.Annotations.NotNull] PNALEEIJDPC CCFHPONJEFB, [GFNPNOLPMKK(null)][JetBrains.Annotations.NotNull] GEAALLHMEPN FFNEAFBBOOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class CEABBNCKCLO : AHEAEJOKBNI
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Task GOINPCAHIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3AE70", Offset = "0x7B39A70", VA = "0x187B3AE70", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task HJBJOGAIBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7B3AF00", Offset = "0x7B39B00", VA = "0x187B3AF00", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool KCHAALCBHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JGPIJEEOOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string LAEONDGMFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public EOBKONMKBGO KJFIJPNHJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action PCBMDMOJCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B700", Offset = "0x7B3A300", VA = "0x187B3B700", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B5D0", Offset = "0x7B3A1D0", VA = "0x187B3B5D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action OJNKMLBDGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B0D0", Offset = "0x7B39CD0", VA = "0x187B3B0D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B030", Offset = "0x7B39C30", VA = "0x187B3B030", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action AMCOHJKILLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B290", Offset = "0x7B39E90", VA = "0x187B3B290", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7B3AF90", Offset = "0x7B39B90", VA = "0x187B3AF90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<FBKFLBKNBDC> CNIHAIFLFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B490", Offset = "0x7B3A090", VA = "0x187B3B490", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B3E0", Offset = "0x7B39FE0", VA = "0x187B3B3E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CEABBNCKCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B540", Offset = "0x7B3A140", VA = "0x187B3B540", Slot = "12")]
	public Task LEIJOMGLGOC(string JHBAJGBPKBD, [Optional] DKGABJGLELN GJJLHHDMOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B170", Offset = "0x7B39D70", VA = "0x187B3B170", Slot = "19")]
	public Task HDBCCNCIPMD(DKGABJGLELN GJJLHHDMOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B670", Offset = "0x7B3A270", VA = "0x187B3B670", Slot = "20")]
	public Task LMEJMOALHDL(DKGABJGLELN GJJLHHDMOLL, Dictionary<string, string> CIMAKELHLEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "21")]
	public bool MJPMBJJNLPN(string NBIPLKMJGLI, bool AAJKGOHMJMP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B330", Offset = "0x7B39F30", VA = "0x187B3B330", Slot = "22")]
	public GOGBMJLGOJH JCNDKGEPHIE(string JGDJJLCDNIA, bool AAJKGOHMJMP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7B3ADE0", Offset = "0x7B399E0", VA = "0x187B3ADE0", Slot = "23")]
	public FODFGGEKHLO CDFGOCFDNCE(string OMMLGLNLJKA, bool AAJKGOHMJMP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B200", Offset = "0x7B39E00", VA = "0x187B3B200", Slot = "24")]
	public Task HDGGKGECLNF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class GGPPABGFDBJ : EOBKONMKBGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly AHCFAHDIOPP NGEELDLJIOH;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IReadOnlyDictionary<string, object> MFNHFNHEGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xE9D510", Offset = "0xE9C110", VA = "0x180E9D510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public GGPPABGFDBJ(AHCFAHDIOPP ALHPJIEHEDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface BELKLJAIOFD
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GDFHMNNNBDC AGBFKHLBAIA(string JPHODODLEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface MFHMPBFKGLM
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum CDFEOJILOGL
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

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	long BAJKNJGELLP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string DOABJLEIMMH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string OJFOBOPGGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool DECGIIDEFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long BAPHDELAFBA();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IDMFAAJLNNP(long JNOOHOGABAI, bool FHMGGOIGPOC = true);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AANNNODLEFL(string CBLPKFIJGLH, string JFPMMBJKLMI, string NLONLIKNJIG);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EAPPIDEOIFE(Guid DJOGNFCFDPF, Guid APJPHGAHPBJ, bool GBKLKDCGFMP);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FJAPMJANAGF(string CBLPKFIJGLH);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FGINJLAJCFN(string CBLPKFIJGLH, string MNFFBFOHMGA, string GCNPKENCOMI);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ABINOPHPBKL(string LPICFBBADAO, object NHADKPDJBEH, object NMKMAJACMNN);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LLHLNGNFCJM(CDFEOJILOGL EHPINILKEPG, int KCCIFDBLGOI, [Optional] JNGEBHOKLOH LACCNICKJEP, [Optional] string EJJACJNELOC, [Optional] string AJLIMPCCGHB);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EOIHNKPNHMO(JNGEBHOKLOH LACCNICKJEP, long BMBBODHEPLI, long NLPMOIMPMJB, int ONLBCFHMFCH, string EJJACJNELOC, int KCCIFDBLGOI);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AGHKNKMNDFL(JNGEBHOKLOH LACCNICKJEP, bool MBDJGJKJICC, [Optional] string AJLIMPCCGHB);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KBFGOKKJGJL(JNGEBHOKLOH LACCNICKJEP, bool MBDJGJKJICC, [Optional] string AJLIMPCCGHB);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LNKOPDMAFMD(JNGEBHOKLOH LACCNICKJEP, bool MBDJGJKJICC, [Optional] string AJLIMPCCGHB);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NFLEBDPIJDH(long JKJNCHGDMGL, string MLDECBJKPLK);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OJEIAKLPGLB(string HGJBCNEJGLD);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface CFCCGBIPHPL
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string BIAKHCOHINI
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
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
