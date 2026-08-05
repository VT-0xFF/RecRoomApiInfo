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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D1C7B0", Offset = "0x5D1AFB0", VA = "0x185D1C7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79CD00", Offset = "0x79B500", VA = "0x18079CD00")]
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
		public AmplitudeAnalyticsClient.Settings FEEOOFKJJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JHDJCNMDPFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x77D7A0", Offset = "0x77BFA0", VA = "0x18077D7A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7721F0", Offset = "0x7709F0", VA = "0x1807721F0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum LPLBLPHHENJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class IOMCHAJEDMF
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class GFENALDIEJI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int CDKHGPGEIPL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> GPGKNNNJMPK;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
				public GFENALDIEJI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class OPEFNDKCOHC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
				public OPEFNDKCOHC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5D1C830", Offset = "0x5D1B030", VA = "0x185D1C830")]
				internal bool KCMFBHDBFGJ(GFENALDIEJI item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string FONLDPLEJAJ = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string LIAIPLNEAGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<GFENALDIEJI> HHBHOFICPHM;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? IODHLDEMHGB
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5D19A20", Offset = "0x5D18220", VA = "0x185D19A20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A3F0", Offset = "0x5D18BF0", VA = "0x185D1A3F0")]
			internal IOMCHAJEDMF(string BAMICBLANJP, string NMGLJFMIHCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5D19D10", Offset = "0x5D18510", VA = "0x185D19D10")]
			public int JFJDMLJDLLP([Optional] int? FCJHIKPOIFG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A180", Offset = "0x5D18980", VA = "0x185D1A180")]
			public List<Dictionary<string, object>> NOCNLJIKGMG(int HEGCPJJMIGO, int? FCJHIKPOIFG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5D19350", Offset = "0x5D17B50", VA = "0x185D19350")]
			public void EMOIBAGLIIM(AmplitudeAnalyticsIdentifyMessage BEKFGDCEJDH, bool KKGFPNGIGMO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5D19240", Offset = "0x5D17A40", VA = "0x185D19240")]
			public void EMOIBAGLIIM(Dictionary<string, object> BEKFGDCEJDH, bool KKGFPNGIGMO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5D19EC0", Offset = "0x5D186C0", VA = "0x185D19EC0")]
			public void LPNABOAIIEL(params Dictionary<string, object>[] MINDILMOOOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5D19AC0", Offset = "0x5D182C0", VA = "0x185D19AC0")]
			public void HAIDECLIMBN(List<Dictionary<string, object>> LPOGKHNAFEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5D19130", Offset = "0x5D17930", VA = "0x185D19130")]
			private void EIJOAHFFFAL(Dictionary<string, object> BEKFGDCEJDH, bool KKGFPNGIGMO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5D197E0", Offset = "0x5D17FE0", VA = "0x185D197E0")]
			public void GMJJKNHGJLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5D193F0", Offset = "0x5D17BF0", VA = "0x185D193F0")]
			private void FKJBFPICPON([Optional] string OKDIJDNOGGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A050", Offset = "0x5D18850", VA = "0x185D1A050")]
			private static string NMDIAOIPOII(string DOLICEBFIPF, string EMBEECDJLJB)
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
			[Cpp2IlInjected.Address(RVA = "0x5D1FB00", Offset = "0x5D1E300", VA = "0x185D1FB00")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct NCLDBFCAKHF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int PLDBGMKIDCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string PMHLMLNLCJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T HCBELPFHEBN;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class AOLHGFGPNHI : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private HHDDIFIMNDJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
			[DebuggerHidden]
			public AOLHGFGPNHI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5D0FC10", Offset = "0x5D0E410", VA = "0x185D0FC10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5D103D0", Offset = "0x5D0EBD0", VA = "0x185D103D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JFIDNPHIJGL : IEnumerator<object>, IEnumerator, IDisposable
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
			public GOHGMMDPJIA quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
			[DebuggerHidden]
			public JFIDNPHIJGL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A5E0", Offset = "0x5D18DE0", VA = "0x185D1A5E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A6F0", Offset = "0x5D18EF0", VA = "0x185D1A6F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class IGGIPAOLJHG : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
			[DebuggerHidden]
			public IGGIPAOLJHG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5D18F70", Offset = "0x5D17770", VA = "0x185D18F70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5D190E0", Offset = "0x5D178E0", VA = "0x185D190E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class PHGMGNNICBH : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private HHDDIFIMNDJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
			[DebuggerHidden]
			public PHGMGNNICBH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5D1E4B0", Offset = "0x5D1CCB0", VA = "0x185D1E4B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5D1E730", Offset = "0x5D1CF30", VA = "0x185D1E730", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class ECNIICFKAKC : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private HHDDIFIMNDJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
			[DebuggerHidden]
			public ECNIICFKAKC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5D18040", Offset = "0x5D16840", VA = "0x185D18040", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5D182D0", Offset = "0x5D16AD0", VA = "0x185D182D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class PIGGAAEIMFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public IOMCHAJEDMF cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public PIGGAAEIMFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5D1EBD0", Offset = "0x5D1D3D0", VA = "0x185D1EBD0")]
			internal void OFANNKACIGH(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5D1E780", Offset = "0x5D1CF80", VA = "0x185D1E780")]
			internal void EGIJJLLAKHB(NCLDBFCAKHF<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class PJBIOEGKDMG : IEnumerator<HHDDIFIMNDJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private HHDDIFIMNDJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public IOMCHAJEDMF cache;

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
			private PIGGAAEIMFA <>8__1;

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
			private HHDDIFIMNDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
			[DebuggerHidden]
			public PJBIOEGKDMG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5D1EEF0", Offset = "0x5D1D6F0", VA = "0x185D1EEF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5D1F740", Offset = "0x5D1DF40", VA = "0x185D1F740", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class LFICDHEHLAD<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public LFICDHEHLAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3A07AD0", Offset = "0x3A062D0", VA = "0x183A07AD0")]
			internal NCLDBFCAKHF<T> OKHDHBKIMIP(AMFJNIDFOCN postResponse)
			{
				return default(NCLDBFCAKHF<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class PGMLHELLCCC<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public PGMLHELLCCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3A07AD0", Offset = "0x3A062D0", VA = "0x183A07AD0")]
			internal NCLDBFCAKHF<T> OKJLENEPDLD(AMFJNIDFOCN postResponse)
			{
				return default(NCLDBFCAKHF<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KMGFKBEAAGE BDOIEGBNMKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<FLJHBJJNKGE> ECLAOPKHLPA;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string KJPKNJBAKOG = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string LMMNPEJDIKO = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string HEMEDIIKINF = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int OGDKKDACJMB = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int FFPDNNIGMBA = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int BONEMKAKAPI = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float JBHHKAEHJCN = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long DIDGALADDDB = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string ANIBOJCFMAE = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string ECPPDHPBBKL = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool JABICPODFKE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool DDHNEHFLPMD;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int FIKNHHCMCJL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int IFJGJONMAKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private FHKAKMMNEBE KEMNEDJPMMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private JBPBACKGAKE HDBPBCONJBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private MLHFBAJDODD NIOBCHGDIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool EOCGKBLOHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float CIIIJIKFEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float KBFOCMKFDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int BAEAJBKLOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int KIBLKOOOHID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? JBGLBONFDLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? HIFJAAKNHAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long EKMNBLEAPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string HDDKLIHPOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool KIKDKJPNHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long NMBFGLAOOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string FNIKPOEIFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string FCOBIJHAINH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> NLHMIPBHPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private LPLBLPHHENJ NHACDNNEDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int ADBKLMFLAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int LGNPECAFLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float AOPEBEMDDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool COFLPINEJCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool GDLLLEBGMLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private IOMCHAJEDMF ELKFMHAPOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private IOMCHAJEDMF GHLFJBDHCPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IOMCHAJEDMF MLCPPCMGJEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> MHDKHFOOODO;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo NBGODLLNCJJ;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string FPGDBFJJAPB;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string LHPCCIMIDJI = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string NLNBHNOFCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string LBOLGIIKGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string AGBKBICNLNH;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private KMGFKBEAAGE EGIHBJNCFFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5D11E30", Offset = "0x5D10630", VA = "0x185D11E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private FLJHBJJNKGE AHPKCDBBPKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5D12CD0", Offset = "0x5D114D0", VA = "0x185D12CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int IKFODOCEJJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5D13730", Offset = "0x5D11F30", VA = "0x185D13730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long AOGJMDIEGCB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5D15FC0", Offset = "0x5D147C0", VA = "0x185D15FC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5D160E0", Offset = "0x5D148E0", VA = "0x185D160E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string JPLCAKOKAJA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5D15F60", Offset = "0x5D14760", VA = "0x185D15F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string LEPJMHOGBHD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5D15F90", Offset = "0x5D14790", VA = "0x185D15F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HKIHDBANNBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x82D920", Offset = "0x82C120", VA = "0x18082D920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x82D930", Offset = "0x82C130", VA = "0x18082D930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? HLNPFHBINHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x966B60", Offset = "0x965360", VA = "0x180966B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5D160D0", Offset = "0x5D148D0", VA = "0x185D160D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IMEJICJCCNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xEC0DA0", Offset = "0xEBF5A0", VA = "0x180EC0DA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xEC03A0", Offset = "0xEBEBA0", VA = "0x180EC03A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool IDENFOAAAAA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5D15E60", Offset = "0x5D14660", VA = "0x185D15E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> CJAIOGLHPFG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5D15DA0", Offset = "0x5D145A0", VA = "0x185D15DA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5D16010", Offset = "0x5D14810", VA = "0x185D16010")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D11360", Offset = "0x5D0FB60", VA = "0x185D11360", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D11890", Offset = "0x5D10090", VA = "0x185D11890")]
		private void BKLOAFGKIJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5D15380", Offset = "0x5D13B80", VA = "0x185D15380")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5D14560", Offset = "0x5D12D60", VA = "0x185D14560", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D15720", Offset = "0x5D13F20", VA = "0x185D15720")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D14620", Offset = "0x5D12E20", VA = "0x185D14620")]
		public BEGOMKNHMOK PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D131B0", Offset = "0x5D119B0", VA = "0x185D131B0")]
		[IteratorStateMachine(typeof(AOLHGFGPNHI))]
		public IEnumerator<HHDDIFIMNDJ> Initialize(AmplitudeAnalyticsEvent ODBHIHMMLLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D15660", Offset = "0x5D13E60", VA = "0x185D15660")]
		public void UpdateLastKnownInteractionCategory(string DFGOEGDDPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D15570", Offset = "0x5D13D70", VA = "0x185D15570")]
		public void UpdateLastAliveTime(float GAJHKHCCEMI = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D117D0", Offset = "0x5D0FFD0", VA = "0x185D117D0")]
		private BEGOMKNHMOK BCHACHILJBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5D140A0", Offset = "0x5D128A0", VA = "0x185D140A0")]
		private BEGOMKNHMOK MPCNNKENAAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5D14DD0", Offset = "0x5D135D0", VA = "0x185D14DD0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5D12870", Offset = "0x5D11070", VA = "0x185D12870")]
		[IteratorStateMachine(typeof(JFIDNPHIJGL))]
		private IEnumerator FLHBENEKPDN(GOHGMMDPJIA INHJDLJDJDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5D159B0", Offset = "0x5D141B0", VA = "0x185D159B0")]
		[IteratorStateMachine(typeof(IGGIPAOLJHG))]
		public IEnumerator WaitForFlush(float ILOOJEFCFKO = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5D15450", Offset = "0x5D13C50", VA = "0x185D15450")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5D15390", Offset = "0x5D13B90", VA = "0x185D15390")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime ODNLKBOLFPL)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5D12D20", Offset = "0x5D11520", VA = "0x185D12D20")]
		public static LPBJGPFHADF Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D111F0", Offset = "0x5D0F9F0", VA = "0x185D111F0")]
		public static BNPNGNMCFFF AccountSelectionPostLoginEvent([NotNull] string JEFDDDGANLC, string KAOHJFECCHG, bool CEFDEHLEIEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5D12260", Offset = "0x5D10A60", VA = "0x185D12260")]
		public static BNPNGNMCFFF Event([NotNull] string JEFDDDGANLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5D14660", Offset = "0x5D12E60", VA = "0x185D14660")]
		public static BNPNGNMCFFF PreviousSessionEvent([NotNull] string JEFDDDGANLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5D12ED0", Offset = "0x5D116D0", VA = "0x185D12ED0")]
		public static BNPNGNMCFFF InitializeEvent(string KAOHJFECCHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5D14F90", Offset = "0x5D13790", VA = "0x185D14F90")]
		public static BNPNGNMCFFF StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5D11EA0", Offset = "0x5D106A0", VA = "0x185D11EA0")]
		public static BNPNGNMCFFF CreateOutOfSessionEvent(string JEFDDDGANLC, bool FDDMMLNBFDE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D13B90", Offset = "0x5D12390", VA = "0x185D13B90")]
		public static BEGOMKNHMOK LogOutOfSessionEvent(BNPNGNMCFFF EPLJOIHIJFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D13910", Offset = "0x5D12110", VA = "0x185D13910")]
		public void LogEventAsync(AmplitudeAnalyticsEvent DOHCFPFMPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5D13E80", Offset = "0x5D12680", VA = "0x185D13E80")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent DOHCFPFMPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5D13FC0", Offset = "0x5D127C0", VA = "0x185D13FC0")]
		public void LogSerializedEventAsync(Dictionary<string, object> HLJENJIKFIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5D13A50", Offset = "0x5D12250", VA = "0x185D13A50")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HKNDNKNHOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D12560", Offset = "0x5D10D60", VA = "0x185D12560")]
		private void FELJFLLKNIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D12990", Offset = "0x5D11190", VA = "0x185D12990")]
		private void HCHCANAJIMM(Dictionary<string, object> FCGOAPMCHNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5D11100", Offset = "0x5D0F900", VA = "0x185D11100")]
		private void AILOMIGKGGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5D14390", Offset = "0x5D12B90", VA = "0x185D14390")]
		private void NPPBJKLLJLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5D12900", Offset = "0x5D11100", VA = "0x185D12900")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5D12C40", Offset = "0x5D11440", VA = "0x185D12C40")]
		[IteratorStateMachine(typeof(PHGMGNNICBH))]
		private IEnumerator<HHDDIFIMNDJ> IHNPAJIHFAH(float ILOOJEFCFKO = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5D136A0", Offset = "0x5D11EA0", VA = "0x185D136A0")]
		[IteratorStateMachine(typeof(ECNIICFKAKC))]
		private IEnumerator<HHDDIFIMNDJ> LINIBJHIMEM(float ILOOJEFCFKO = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5D12770", Offset = "0x5D10F70", VA = "0x185D12770")]
		[IteratorStateMachine(typeof(PJBIOEGKDMG))]
		private IEnumerator<HHDDIFIMNDJ> FHJGDDJHCEG(IOMCHAJEDMF KPAIMHKKLCO, int? FCJHIKPOIFG, string BDGEHABJGIC, string OJILMNHJCFJ, float ILOOJEFCFKO, Action<int> EMOMACBGFIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5D12660", Offset = "0x5D10E60", VA = "0x185D12660")]
		private static void FFLOCEGNAON(bool PCIOEFPNKIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5D13520", Offset = "0x5D11D20", VA = "0x185D13520")]
		private CNJPNJMNEEH<NCLDBFCAKHF<Dictionary<string, object>>> KIABCPFCLII(string BDGEHABJGIC, string OJILMNHJCFJ, string CIAMNAIMHBM, string BJJCCHBEHOL, Dictionary<string, object> HCBELPFHEBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5D13240", Offset = "0x5D11A40", VA = "0x185D13240")]
		private CNJPNJMNEEH<NCLDBFCAKHF<List<Dictionary<string, object>>>> KIABCPFCLII(string BDGEHABJGIC, string OJILMNHJCFJ, string CIAMNAIMHBM, string BJJCCHBEHOL, List<Dictionary<string, object>> HCBELPFHEBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B4EC10", Offset = "0x2B4D410", VA = "0x182B4EC10")]
		private CNJPNJMNEEH<NCLDBFCAKHF<T>> PMLKIJJBLEC<T>(string BDGEHABJGIC, string OJILMNHJCFJ, string BJJCCHBEHOL, T HCBELPFHEBN, Dictionary<string, object> DOLCMIIHAFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E8C0", Offset = "0x2B4D0C0", VA = "0x182B4E8C0")]
		private CNJPNJMNEEH<NCLDBFCAKHF<T>> GJKFJGGKHHE<T>(string BDGEHABJGIC, string OJILMNHJCFJ, string CIAMNAIMHBM, T HCBELPFHEBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5D13650", Offset = "0x5D11E50", VA = "0x185D13650")]
		private bool KJHPOBHHOHN(float CANCEBGIMHA, float ILOOJEFCFKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5D10420", Offset = "0x5D0EC20", VA = "0x185D10420")]
		private Dictionary<string, object> AHBMJHEDPHO(string OJILMNHJCFJ, Dictionary<string, object> HCBELPFHEBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5D15AA0", Offset = "0x5D142A0", VA = "0x185D15AA0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5D12100", Offset = "0x5D10900", VA = "0x185D12100")]
		[CompilerGenerated]
		private long DLKLKEHFIME()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5D110F0", Offset = "0x5D0F8F0", VA = "0x185D110F0")]
		[CompilerGenerated]
		private void AHNPOBEBMNO(int POLAEHAHLLK)
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
			[Cpp2IlInjected.Address(RVA = "0x5D16E40", Offset = "0x5D15640", VA = "0x185D16E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5D16F20", Offset = "0x5D15720", VA = "0x185D16F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5D16E80", Offset = "0x5D15680", VA = "0x185D16E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5D16F80", Offset = "0x5D15780", VA = "0x185D16F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5D16E00", Offset = "0x5D15600", VA = "0x185D16E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5D16EC0", Offset = "0x5D156C0", VA = "0x185D16EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x779F00", Offset = "0x778700", VA = "0x180779F00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5D16A60", Offset = "0x5D15260", VA = "0x185D16A60")]
		public static BNPNGNMCFFF OEONKPJDENI(string GLPKPIDPHCF, [NotNull] string GEEMHDEFIKN, long CKJKBIFDHCG, long ODOPAHEHEJI, string KAOHJFECCHG, bool CEFDEHLEIEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5D16780", Offset = "0x5D14F80", VA = "0x185D16780")]
		public static BNPNGNMCFFF FJKHKHCGONO(string GLPKPIDPHCF, [NotNull] string GEEMHDEFIKN, long CKJKBIFDHCG, long ODOPAHEHEJI, string KAOHJFECCHG, long NEIFOLGEJLM, bool CEFDEHLEIEC, string COLNFKPICBB, string HLMNEGIPDAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5D16C70", Offset = "0x5D15470", VA = "0x185D16C70")]
		private AmplitudeAnalyticsEvent(string GLPKPIDPHCF, [NotNull] string GEEMHDEFIKN, long CKJKBIFDHCG, long ODOPAHEHEJI, string KAOHJFECCHG, bool CEFDEHLEIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1950A70", Offset = "0x194F270", VA = "0x181950A70")]
		public void MHEHDMEOANN(long LECGPLJDOEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D16670", Offset = "0x5D14E70", VA = "0x185D16670", Slot = "5")]
		public override void FJFINDFFNFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5D168E0", Offset = "0x5D150E0", VA = "0x185D168E0", Slot = "6")]
		public override void JBFIPPPJIMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D16140", Offset = "0x5D14940", VA = "0x185D16140", Slot = "4")]
		protected override Dictionary<string, object> AFGNFIKNGHA(Dictionary<string, object> KDKKIGFEMLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D16B60", Offset = "0x5D15360", VA = "0x185D16B60")]
		private void PFKGEAMDCCH(string EMBEECDJLJB, string DOLICEBFIPF, bool LOIABGHEHKN = false)
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
			[Cpp2IlInjected.Address(RVA = "0x5D17EC0", Offset = "0x5D166C0", VA = "0x185D17EC0")]
			public void KIFPMPFJIJP(Dictionary<string, object> DDACLDFNFNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D1F790", Offset = "0x5D1DF90", VA = "0x185D1F790")]
			public void KIFPMPFJIJP(Dictionary<string, object> EJHKFHEAKHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8734A0", Offset = "0x871CA0", VA = "0x1808734A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5D17570", Offset = "0x5D15D70", VA = "0x185D17570")]
		public static LPBJGPFHADF OEONKPJDENI(string GLPKPIDPHCF, string KAOHJFECCHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5D176A0", Offset = "0x5D15EA0", VA = "0x185D176A0")]
		protected AmplitudeAnalyticsIdentifyMessage(string GLPKPIDPHCF, string KAOHJFECCHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5D174E0", Offset = "0x5D15CE0", VA = "0x185D174E0")]
		public Dictionary<string, object> KBMENPOOPEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5D16FE0", Offset = "0x5D157E0", VA = "0x185D16FE0", Slot = "4")]
		protected virtual Dictionary<string, object> AFGNFIKNGHA(Dictionary<string, object> KDKKIGFEMLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5D17440", Offset = "0x5D15C40", VA = "0x185D17440")]
		protected void KBKFJKNIMPF(string EMBEECDJLJB, Dictionary<string, object> NFGKENCOFJJ, Dictionary<string, object> PFMJHGCBIAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5D17630", Offset = "0x5D15E30", VA = "0x185D17630")]
		protected void PODAEEIJEHC(string EMBEECDJLJB, string DOLICEBFIPF, Dictionary<string, object> OBPCMOIGGJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5D17320", Offset = "0x5D15B20", VA = "0x185D17320", Slot = "5")]
		public virtual void FJFINDFFNFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5D173B0", Offset = "0x5D15BB0", VA = "0x185D173B0", Slot = "6")]
		public virtual void JBFIPPPJIMI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LPBJGPFHADF : FMELPMAOLBO<AmplitudeAnalyticsIdentifyMessage, LPBJGPFHADF>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override LPBJGPFHADF NICIMAANHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage JBINOAKHLAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B2B0", Offset = "0x5D19AB0", VA = "0x185D1B2B0")]
	public LPBJGPFHADF(AmplitudeAnalyticsIdentifyMessage OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B200", Offset = "0x5D19A00", VA = "0x185D1B200", Slot = "4")]
	public override void JBFIPPPJIMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BNPNGNMCFFF : FMELPMAOLBO<AmplitudeAnalyticsEvent, BNPNGNMCFFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool MINBNJAAAAA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override BNPNGNMCFFF NICIMAANHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long OMIMCAAHCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1CB75A0", Offset = "0x1CB5DA0", VA = "0x181CB75A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D17AC0", Offset = "0x5D162C0", VA = "0x185D17AC0")]
	public BNPNGNMCFFF(AmplitudeAnalyticsEvent OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "5")]
	public override AmplitudeAnalyticsEvent JBINOAKHLAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5D17860", Offset = "0x5D16060", VA = "0x185D17860", Slot = "4")]
	public override void JBFIPPPJIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x22CCE90", Offset = "0x22CB690", VA = "0x1822CCE90")]
	public BNPNGNMCFFF KAFMAFDFBCO<T>(string AHFKMNKCLNN, T[] DOLICEBFIPF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x22CCE90", Offset = "0x22CB690", VA = "0x1822CCE90")]
	public BNPNGNMCFFF KAFMAFDFBCO(string AHFKMNKCLNN, string[] DOLICEBFIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x22CCBE0", Offset = "0x22CB3E0", VA = "0x1822CCBE0")]
	public BNPNGNMCFFF KAFMAFDFBCO<T>(string AHFKMNKCLNN, T DOLICEBFIPF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D17A10", Offset = "0x5D16210", VA = "0x185D17A10")]
	public BNPNGNMCFFF KAFMAFDFBCO(string AHFKMNKCLNN, long DOLICEBFIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D179A0", Offset = "0x5D161A0", VA = "0x185D179A0")]
	public BNPNGNMCFFF KAFMAFDFBCO(string AHFKMNKCLNN, string DOLICEBFIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D17A90", Offset = "0x5D16290", VA = "0x185D17A90")]
	public BNPNGNMCFFF PHEIAGGLDOH(string AHFKMNKCLNN, object? DOLICEBFIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D17900", Offset = "0x5D16100", VA = "0x185D17900")]
	public BNPNGNMCFFF JLICEGBGPPM(string AHFKMNKCLNN, string DOLICEBFIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D17760", Offset = "0x5D15F60", VA = "0x185D17760")]
	private BNPNGNMCFFF DOMFIKEOJMK(string AHFKMNKCLNN, object DOLICEBFIPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JIOGAOIFNJI : BNPNGNMCFFF
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D17AC0", Offset = "0x5D162C0", VA = "0x185D17AC0")]
	public JIOGAOIFNJI(AmplitudeAnalyticsEvent OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A740", Offset = "0x5D18F40", VA = "0x185D1A740", Slot = "4")]
	public override void JBFIPPPJIMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class FMELPMAOLBO<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : FMELPMAOLBO<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M OLDFIJBKFKG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR NICIMAANHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	public FMELPMAOLBO(M OLDFIJBKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3484B90", Offset = "0x3483390", VA = "0x183484B90")]
	public BLDR HGHDBANEACB(AmplitudeAnalyticsIdentifyMessage.DeviceInfo AGPLIGDDMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3484990", Offset = "0x3483190", VA = "0x183484990")]
	public BLDR BOIMKFDKNGE(AmplitudeAnalyticsIdentifyMessage.RevenueData AEHJALGDLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3484A10", Offset = "0x3483210", VA = "0x183484A10")]
	public BLDR FNNEJOHBLDI(string AHFKMNKCLNN, string DOLICEBFIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2E2AF70", Offset = "0x2E29770", VA = "0x182E2AF70")]
	public BLDR FNNEJOHBLDI<T>(string AHFKMNKCLNN, T DOLICEBFIPF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JBFIPPPJIMI();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x34849E0", Offset = "0x34831E0", VA = "0x1834849E0")]
	internal static string DGHHNJABMLN(string DOLICEBFIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3484A90", Offset = "0x3483290", VA = "0x183484A90")]
	private BLDR GJHJEJHDCJA(string AHFKMNKCLNN, object DOLICEBFIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M JBINOAKHLAC();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class DNFJNJLLLLM : FHKAKMMNEBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct JPHOEDEJGHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<AMFJNIDFOCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public DNFJNJLLLLM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5D1A8F0", Offset = "0x5D190F0", VA = "0x185D1A8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B190", Offset = "0x5D19990", VA = "0x185D1B190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct GDODJLDIJKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<AMFJNIDFOCN> <>t__builder;

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
		public DNFJNJLLLLM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5D18320", Offset = "0x5D16B20", VA = "0x185D18320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D18D50", Offset = "0x5D17550", VA = "0x185D18D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient NIBPJNKHGMK;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D17C80", Offset = "0x5D16480", VA = "0x185D17C80")]
	[IOOPNJKFHOG(FICJCHGEBPC.None)]
	private static void FEBDBEAJJPC(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D17E40", Offset = "0x5D16640", VA = "0x185D17E40")]
	[RecRoom.NoEngine.Common.Preserve]
	public DNFJNJLLLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D17CF0", Offset = "0x5D164F0", VA = "0x185D17CF0", Slot = "4")]
	[AsyncStateMachine(typeof(JPHOEDEJGHJ))]
	public Task<AMFJNIDFOCN> KIABCPFCLII(string BDGEHABJGIC, Dictionary<string, string> KPAHIHBHJOD, bool OKCDGINHIFL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D17B10", Offset = "0x5D16310", VA = "0x185D17B10", Slot = "5")]
	[AsyncStateMachine(typeof(GDODJLDIJKG))]
	public Task<AMFJNIDFOCN> DMCEHKDADCE(string BDGEHABJGIC, string OLNPHKDDJEL, string DLACCPNDFFG, string NGNKHDCECDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class GMFBJEKFKAG
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> BPNCPAHIKEB;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D18DC0", Offset = "0x5D175C0", VA = "0x185D18DC0")]
	internal static bool DLLOGFIHPAC(string EMBEECDJLJB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FHKAKMMNEBE
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AMFJNIDFOCN> KIABCPFCLII(string BDGEHABJGIC, Dictionary<string, string> KPAHIHBHJOD, bool OKCDGINHIFL = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AMFJNIDFOCN> DMCEHKDADCE(string BDGEHABJGIC, string OLNPHKDDJEL, string DLACCPNDFFG, string NGNKHDCECDL);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct AMFJNIDFOCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int IMPEKJOENJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string MMICACFEJOF;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xB58170", Offset = "0xB56970", VA = "0x180B58170")]
	public AMFJNIDFOCN(int PLDBGMKIDCO, string PMHLMLNLCJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum JBKLCOPNFMB
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
public class NMHFFEFFPIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long MKKMEGPBAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private BNPNGNMCFFF GEEJOLFPJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool MEFLNKJPIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float LOAADEEPAAD;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C620", Offset = "0x5D1AE20", VA = "0x185D1C620")]
	public NMHFFEFFPIF(string JDKKMJFOJEF, float LOAADEEPAAD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2633000", Offset = "0x2631800", VA = "0x182633000")]
	public void KAFMAFDFBCO<T>(string AHFKMNKCLNN, T DOLICEBFIPF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C4E0", Offset = "0x5D1ACE0", VA = "0x185D1C4E0")]
	public void KAFMAFDFBCO(string AHFKMNKCLNN, string DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C290", Offset = "0x5D1AA90", VA = "0x185D1C290")]
	public void ACIGNONLHGP(string KNMDNMLJEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C560", Offset = "0x5D1AD60", VA = "0x185D1C560")]
	public void MPIJAIFPMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C380", Offset = "0x5D1AB80", VA = "0x185D1C380")]
	private void AKBIALDFLFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C490", Offset = "0x5D1AC90", VA = "0x185D1C490")]
	private bool HJIDMOKCMMF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface DENJEHOGNCA
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool PCAIHPKKNOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string HKIHDBANNBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	GDAAAAAIPBB NOODOMNDCMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action OMKNNPABNNG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action EDOODAFAIDJ;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BEGOMKNHMOK EBEAKPIECKB(string FPMGCKHKCEM, string NMGLJFMIHCI, [Optional] JBPBACKGAKE OMHFAAFCGEJ);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BEGOMKNHMOK KCADNDMHEGF(JBPBACKGAKE OMHFAAFCGEJ);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BEGOMKNHMOK NCNGIEJNBFC(JBPBACKGAKE OMHFAAFCGEJ, Dictionary<string, string> JLDPBIKDPBA);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GFLGGJLANDG(string MLJGIFEFFAF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EKHCNFNIAHE KCINLNFFGPH(string HNMJGJFECLB);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EEKDILLKGHL IKJNJINFMHD(string HOPGAGPKOGB);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BEGOMKNHMOK MCABPFHEMBD();
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
			[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D1F900", Offset = "0x5D1E100", VA = "0x185D1F900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OPNJFNNOJMN : DENJEHOGNCA
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly IReadOnlyDictionary<string, NNGMFDIEBBE> CJIJALPKEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool JFCANDLLMEH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PCAIHPKKNOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C5270", Offset = "0x7C3A70", VA = "0x1807C5270", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string HKIHDBANNBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E2C0", Offset = "0x5D1CAC0", VA = "0x185D1E2C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public GDAAAAAIPBB NOODOMNDCMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D7D0", Offset = "0x5D1BFD0", VA = "0x185D1D7D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OMKNNPABNNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D610", Offset = "0x5D1BE10", VA = "0x185D1D610", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C8A0", Offset = "0x5D1B0A0", VA = "0x185D1C8A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action EDOODAFAIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E2D0", Offset = "0x5D1CAD0", VA = "0x185D1E2D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E070", Offset = "0x5D1C870", VA = "0x185D1E070", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D1A0", Offset = "0x5D1B9A0", VA = "0x185D1D1A0", Slot = "8")]
	public BEGOMKNHMOK EBEAKPIECKB(string FPMGCKHKCEM, string NMGLJFMIHCI, [Optional] JBPBACKGAKE OMHFAAFCGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DC50", Offset = "0x5D1C450", VA = "0x185D1DC50", Slot = "17")]
	public BEGOMKNHMOK MCABPFHEMBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D860", Offset = "0x5D1C060", VA = "0x185D1D860", Slot = "12")]
	public BEGOMKNHMOK KCADNDMHEGF(JBPBACKGAKE OMHFAAFCGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DDA0", Offset = "0x5D1C5A0", VA = "0x185D1DDA0", Slot = "13")]
	public BEGOMKNHMOK NCNGIEJNBFC(JBPBACKGAKE OMHFAAFCGEJ, Dictionary<string, string> JLDPBIKDPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D6B0", Offset = "0x5D1BEB0", VA = "0x185D1D6B0", Slot = "14")]
	public bool GFLGGJLANDG(string MLJGIFEFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DA50", Offset = "0x5D1C250", VA = "0x185D1DA50", Slot = "15")]
	public EKHCNFNIAHE KCINLNFFGPH(string HNMJGJFECLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D740", Offset = "0x5D1BF40", VA = "0x185D1D740", Slot = "16")]
	public EEKDILLKGHL IKJNJINFMHD(string HOPGAGPKOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5D1CAD0", Offset = "0x5D1B2D0", VA = "0x185D1CAD0")]
	private GDAAAAAIPBB CDLBCCCKBCB(JBPBACKGAKE OMHFAAFCGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E110", Offset = "0x5D1C910", VA = "0x185D1E110")]
	private BHLBHNBPJHG NMDAGPNOJOL(string NMGLJFMIHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C9C0", Offset = "0x5D1B1C0", VA = "0x185D1C9C0")]
	private void BCNJBCMFIOP(string HNMJGJFECLB, EKHCNFNIAHE MIIMIMJDOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public OPNJFNNOJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA823D0", Offset = "0xA80BD0", VA = "0x180A823D0")]
	[CompilerGenerated]
	private void KAOKDBDEOPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D7E0", Offset = "0x5D1BFE0", VA = "0x185D1D7E0")]
	[CompilerGenerated]
	private void JLONJBOLKHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C940", Offset = "0x5D1B140", VA = "0x185D1C940")]
	[CompilerGenerated]
	private void AHPEHPMLHOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class MHHGEEPHHEM : DENJEHOGNCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private DENJEHOGNCA BAABKPECPGC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private DENJEHOGNCA MILFBNPFDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BDF0", Offset = "0x5D1A5F0", VA = "0x185D1BDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool PCAIHPKKNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BB80", Offset = "0x5D1A380", VA = "0x185D1BB80", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string HKIHDBANNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C130", Offset = "0x5D1A930", VA = "0x185D1C130", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public GDAAAAAIPBB NOODOMNDCMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BAC0", Offset = "0x5D1A2C0", VA = "0x185D1BAC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action OMKNNPABNNG
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B7F0", Offset = "0x5D19FF0", VA = "0x185D1B7F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B300", Offset = "0x5D19B00", VA = "0x185D1B300", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action EDOODAFAIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C180", Offset = "0x5D1A980", VA = "0x185D1C180", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C090", Offset = "0x5D1A890", VA = "0x185D1C090", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	[UnityEngine.Scripting.Preserve]
	public MHHGEEPHHEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C220", Offset = "0x5D1AA20", VA = "0x185D1C220")]
	[IOOPNJKFHOG(FICJCHGEBPC.GameOnly)]
	private static void PIAOHNCICLB(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B940", Offset = "0x5D1A140", VA = "0x185D1B940")]
	[IOOPNJKFHOG(FICJCHGEBPC.EditorOnly)]
	private static void IGNOFOEPKMI(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B3A0", Offset = "0x5D19BA0", VA = "0x185D1B3A0", Slot = "8")]
	public BEGOMKNHMOK EBEAKPIECKB(string FPMGCKHKCEM, string NMGLJFMIHCI, [Optional] JBPBACKGAKE OMHFAAFCGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BBD0", Offset = "0x5D1A3D0", VA = "0x185D1BBD0", Slot = "12")]
	public BEGOMKNHMOK KCADNDMHEGF(JBPBACKGAKE OMHFAAFCGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BF70", Offset = "0x5D1A770", VA = "0x185D1BF70", Slot = "13")]
	public BEGOMKNHMOK NCNGIEJNBFC(JBPBACKGAKE OMHFAAFCGEJ, Dictionary<string, string> JLDPBIKDPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B890", Offset = "0x5D1A090", VA = "0x185D1B890", Slot = "14")]
	public bool GFLGGJLANDG(string MLJGIFEFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BCE0", Offset = "0x5D1A4E0", VA = "0x185D1BCE0", Slot = "15")]
	public EKHCNFNIAHE KCINLNFFGPH(string HNMJGJFECLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B9B0", Offset = "0x5D1A1B0", VA = "0x185D1B9B0", Slot = "16")]
	public EEKDILLKGHL IKJNJINFMHD(string HOPGAGPKOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BE60", Offset = "0x5D1A660", VA = "0x185D1BE60", Slot = "17")]
	public BEGOMKNHMOK MCABPFHEMBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF330", Offset = "0x7BDB30", VA = "0x1807BF330")]
	[CompilerGenerated]
	private void MBCMLLLHMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xB5DBC0", Offset = "0xB5C3C0", VA = "0x180B5DBC0")]
	[CompilerGenerated]
	private void INBOLGOGDDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class AEFMGAOIJNA : DENJEHOGNCA
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PCAIHPKKNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x78D2A0", Offset = "0x78BAA0", VA = "0x18078D2A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string HKIHDBANNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x772210", Offset = "0x770A10", VA = "0x180772210", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public GDAAAAAIPBB NOODOMNDCMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x772210", Offset = "0x770A10", VA = "0x180772210", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action OMKNNPABNNG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F860", Offset = "0x5D0E060", VA = "0x185D0F860", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F730", Offset = "0x5D0DF30", VA = "0x185D0F730", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action EDOODAFAIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FB70", Offset = "0x5D0E370", VA = "0x185D0FB70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FAD0", Offset = "0x5D0E2D0", VA = "0x185D0FAD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	[RecRoom.NoEngine.Common.Preserve]
	public AEFMGAOIJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F7D0", Offset = "0x5D0DFD0", VA = "0x185D0F7D0", Slot = "8")]
	public BEGOMKNHMOK EBEAKPIECKB(string FPMGCKHKCEM, string NMGLJFMIHCI, [Optional] JBPBACKGAKE OMHFAAFCGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F910", Offset = "0x5D0E110", VA = "0x185D0F910", Slot = "12")]
	public BEGOMKNHMOK KCADNDMHEGF(JBPBACKGAKE OMHFAAFCGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FA40", Offset = "0x5D0E240", VA = "0x185D0FA40", Slot = "13")]
	public BEGOMKNHMOK NCNGIEJNBFC(JBPBACKGAKE OMHFAAFCGEJ, Dictionary<string, string> JLDPBIKDPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "14")]
	public bool GFLGGJLANDG(string MLJGIFEFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F9A0", Offset = "0x5D0E1A0", VA = "0x185D0F9A0", Slot = "15")]
	public EKHCNFNIAHE KCINLNFFGPH(string HNMJGJFECLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F900", Offset = "0x5D0E100", VA = "0x185D0F900", Slot = "16")]
	public EEKDILLKGHL IKJNJINFMHD(string HOPGAGPKOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F9B0", Offset = "0x5D0E1B0", VA = "0x185D0F9B0", Slot = "17")]
	public BEGOMKNHMOK MCABPFHEMBD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface ILAKMHKAAEI
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NMHFFEFFPIF JIKCKOEMMKH(string JDKKMJFOJEF);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface MLHFBAJDODD
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	long HCEHGNGENKK
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string EDKEPPBOGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string FHJPKECDJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string NHJGFMEEPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string CFAEHKCBOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool AHGPCCGJJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long GIPINLMBLEK();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BOEDBFFGHBJ(long CKJKBIFDHCG, bool LOIABGHEHKN = true);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void APLGGBBKEOH(string LFDLOIPEDMO, string MCEBJEHCIGK, string DJOMFOCLMEL);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GFCNPIODDCJ(string LFDLOIPEDMO);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CLBADCMAIMN(string LFDLOIPEDMO, string BNNOGGHNBNB, string DJPKCPPJFPM);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LLBPAECKECL(string FIKFKHLEGOG, object BOBHMHBKDDH, object GHHBDJGLOLI);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface JBPBACKGAKE
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool GAEPAJFIDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool FAEILBODOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool FMKLJNKJGDN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool? OLIKBKDIOIA
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	int? HLNPFHBINHB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	int DJBMCECJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string LHNEBCHLNDC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string FPIGJGGIGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string JPGELOJGOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	long POJIPNBKEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string HKAAGNFKLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string MIBCAIEKACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string MLCFBMCMLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string INJHDNDLLBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	double DPEIGINOAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int HODDANNHOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "15")]
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
