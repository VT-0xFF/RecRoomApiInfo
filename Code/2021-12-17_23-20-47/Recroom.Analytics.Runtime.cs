using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AmplitudeAnalytics;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AGAmplitudeAnalyticsSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AmplitudeAnalyticsClient.Settings NEGOFKKNGOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PNODJHIHNGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4C0160", Offset = "0x4BED60", VA = "0x1804C0160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBD84E0", Offset = "0xBD70E0", VA = "0x180BD84E0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum LJCCHGBNNNE
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class ICCOJFOMHDP
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class BPHKBGJEPDJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public int MHJIBACFFKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public Dictionary<string, object> GOMBBLCICEC;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
				public BPHKBGJEPDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class EDINHKLKINP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
				public EDINHKLKINP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x4338050", Offset = "0x4336C50", VA = "0x184338050")]
				internal bool <GetBatch>b__0(BPHKBGJEPDJ item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private const string CGLHJOMOPAE = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string BKBLGFNJHAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<BPHKBGJEPDJ> APIJGPFIHFB;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? NOGHGEEEKJF
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x43385A0", Offset = "0x43371A0", VA = "0x1843385A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? KLANMOIBGAP
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x4338C40", Offset = "0x4337840", VA = "0x184338C40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x43395F0", Offset = "0x43381F0", VA = "0x1843395F0")]
			internal ICCOJFOMHDP(string DPCMPMHDGPB, string KAHGAIIEEEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x4338AE0", Offset = "0x43376E0", VA = "0x184338AE0")]
			public int IDBPECDBHJP([Optional] int? PABPJHFJMJM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x43393F0", Offset = "0x4337FF0", VA = "0x1843393F0")]
			public List<Dictionary<string, object>> OLDKGALHAJG(int KPDHNJOGIJE, int? PABPJHFJMJM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4338850", Offset = "0x4337450", VA = "0x184338850")]
			public void GFCBMLPBBKM(AmplitudeAnalyticsIdentifyMessage JPFPDMFLBGI, bool MGPIKJJOJHF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4338760", Offset = "0x4337360", VA = "0x184338760")]
			public void GFCBMLPBBKM(Dictionary<string, object> JPFPDMFLBGI, bool MGPIKJJOJHF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4338630", Offset = "0x4337230", VA = "0x184338630")]
			public void FCMKBEIONEE(params Dictionary<string, object>[] KLAIEHLINNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4338CF0", Offset = "0x43378F0", VA = "0x184338CF0")]
			public void LHCFHJCOCMJ(List<Dictionary<string, object>> DAACAHIBNOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x43392E0", Offset = "0x4337EE0", VA = "0x1843392E0")]
			private void OGCPONHOGHB(Dictionary<string, object> JPFPDMFLBGI, bool MGPIKJJOJHF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x43388F0", Offset = "0x43374F0", VA = "0x1843388F0")]
			public void HPGEDPJEAMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4338F10", Offset = "0x4337B10", VA = "0x184338F10")]
			private void LHCPELCCBJF([Optional] string BEMBNOJFNNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4338470", Offset = "0x4337070", VA = "0x184338470")]
			private static string CNHCNHANHBM(string CKGFDBLPDNJ, string FHJAGMPOINB)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x433A810", Offset = "0x4339410", VA = "0x18433A810")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct EJLLJKLDIAG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int FBHPPHGFNJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public string PGJJBNBOGME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T OFCLODICHCG;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class OOAOICLHHJF : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private MDIGCEIKMFK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
			[DebuggerHidden]
			public OOAOICLHHJF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4339F80", Offset = "0x4338B80", VA = "0x184339F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x433A6A0", Offset = "0x43392A0", VA = "0x18433A6A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class JJHFFKDHJIG : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public PPHLALBGLJF quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
			[DebuggerHidden]
			public JJHFFKDHJIG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4339820", Offset = "0x4338420", VA = "0x184339820", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4339900", Offset = "0x4338500", VA = "0x184339900", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OBHAKPICMFN : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
			[DebuggerHidden]
			public OBHAKPICMFN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4339DF0", Offset = "0x43389F0", VA = "0x184339DF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4339F30", Offset = "0x4338B30", VA = "0x184339F30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DEKBJHOPOLJ : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private MDIGCEIKMFK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
			[DebuggerHidden]
			public DEKBJHOPOLJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4337470", Offset = "0x4336070", VA = "0x184337470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x43376B0", Offset = "0x43362B0", VA = "0x1843376B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class IBIMOPGFNLM : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private MDIGCEIKMFK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
			[DebuggerHidden]
			public IBIMOPGFNLM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x43381E0", Offset = "0x4336DE0", VA = "0x1843381E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x4338420", Offset = "0x4337020", VA = "0x184338420", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class KIKKAHBMFKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public ICCOJFOMHDP cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
			public KIKKAHBMFKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4339950", Offset = "0x4338550", VA = "0x184339950")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x43399F0", Offset = "0x43385F0", VA = "0x1843399F0")]
			internal void <FlushFromCache>b__1(EJLLJKLDIAG<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class DCGFLLOLGLA : IEnumerator<MDIGCEIKMFK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private MDIGCEIKMFK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public ICCOJFOMHDP cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private KIKKAHBMFKL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private MDIGCEIKMFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A2E30", VA = "0x1806A4230")]
			[DebuggerHidden]
			public DCGFLLOLGLA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4336DE0", Offset = "0x43359E0", VA = "0x184336DE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4337420", Offset = "0x4336020", VA = "0x184337420", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class CIHBBFFNIGE<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
			public CIHBBFFNIGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x371C8A0", Offset = "0x371B4A0", VA = "0x18371C8A0")]
			internal EJLLJKLDIAG<T> <PostJson>b__0(OIOCGEBNNIG postResponse)
			{
				return default(EJLLJKLDIAG<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private LMPGBBBJCFH AGBPOPFMMMF;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string DIEAPEECEEI = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string PGHIJEEAOJE = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string JHIIKGKFDBG = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string KCLMGLBOFII = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string LDAJIEMJAOA = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int MCNFDMKCIJJ = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int AEAHIBEOCDC = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int IIJEPEFPCAM = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float PGHFLCKNIIA = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long JHEIHBABMKL = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string BDJJDJIKGNJ = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static bool NPKIEEDMGIK;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool JPJNEHIHPFB;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static int JGFGLEIHFPB;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int MFNDPBEKHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private GLNPGEAPGNC DOJIONABFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool CEDIGGPDJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float JCIHPOIOADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float KBDPBCKKBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int ONOFEHCEGMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int CIFMBHBNAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int? PDOFOFPGCKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? KFBBFPIBCNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private long EDEJFPEIIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string EBNJCBMKAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long CJDNHBEGNCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, object> CDENPEINDEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private LJCCHGBNNNE FNAOCPJEELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int DMKOJBKDNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int ICCMENEMNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float HPLKGFPJMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool LDPAGOPJCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool NEFGPKNPOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private ICCOJFOMHDP GPMDDEKLENI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private ICCOJFOMHDP BKDOJJLAAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private ICCOJFOMHDP HCAACGCFKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> MAHMADDHPPG;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo JONIBPCPEGK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static string JKNCPHABLJL;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string ENECHPBCCCK = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string PFIMLFMLDGO = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LMPGBBBJCFH BNPDFLOMIFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x4333F90", Offset = "0x4332B90", VA = "0x184333F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int CEGMIHGFPHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x43349F0", Offset = "0x43335F0", VA = "0x1843349F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long JLMBDJFMDHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x4335F90", Offset = "0x4334B90", VA = "0x184335F90")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x4336090", Offset = "0x4334C90", VA = "0x184336090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string ADBGFIIEMKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x4335F60", Offset = "0x4334B60", VA = "0x184335F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string PHMOLFJICMA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4E3950", Offset = "0x4E2550", VA = "0x1804E3950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x4D1A40", Offset = "0x4D0640", VA = "0x1804D1A40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BKMNCHEONPA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x599360", Offset = "0x597F60", VA = "0x180599360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xF23C00", Offset = "0xF22800", VA = "0x180F23C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool MKCCHGKFFPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4335E80", Offset = "0x4334A80", VA = "0x184335E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> EMLOAFIFPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4335DE0", Offset = "0x43349E0", VA = "0x184335DE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4335FF0", Offset = "0x4334BF0", VA = "0x184335FF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4332EE0", Offset = "0x4331AE0", VA = "0x184332EE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4335870", Offset = "0x4334470", VA = "0x184335870")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4334E40", Offset = "0x4333A40", VA = "0x184334E40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x43359F0", Offset = "0x43345F0", VA = "0x1843359F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4335050", Offset = "0x4333C50", VA = "0x184335050")]
		public DPJKDCDGPPB PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4333E10", Offset = "0x4332A10", VA = "0x184333E10")]
		[IteratorStateMachine(typeof(OOAOICLHHJF))]
		public IEnumerator<MDIGCEIKMFK> Initialize(AmplitudeAnalyticsEvent HNGKELCANDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4335940", Offset = "0x4334540", VA = "0x184335940")]
		public void UpdateLastAliveTime(float DIGHIJJCFAJ = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4334810", Offset = "0x4333410", VA = "0x184334810")]
		private DPJKDCDGPPB OAAIFFMDHAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x43345F0", Offset = "0x43331F0", VA = "0x1843345F0")]
		private DPJKDCDGPPB MKOIECAIANM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4335500", Offset = "0x4334100", VA = "0x184335500")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4333880", Offset = "0x4332480", VA = "0x184333880")]
		[IteratorStateMachine(typeof(JJHFFKDHJIG))]
		private IEnumerator FMIFCAOANJN(PPHLALBGLJF DNOGOPCJDJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4335C50", Offset = "0x4334850", VA = "0x184335C50")]
		[IteratorStateMachine(typeof(OBHAKPICMFN))]
		public IEnumerator WaitForFlush(float ENDBOLINCAJ = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4335880", Offset = "0x4334480", VA = "0x184335880")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4333B20", Offset = "0x4332720", VA = "0x184333B20")]
		public static IPDONPDCNCI Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4332DA0", Offset = "0x43319A0", VA = "0x184332DA0")]
		public static EBKJCEEKJGG AccountSelectionPostLoginEvent([NotNull] string NFJJDKGGBLK, string MBJGHLJMDCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4333720", Offset = "0x4332320", VA = "0x184333720")]
		public static EBKJCEEKJGG Event([NotNull] string NFJJDKGGBLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x43350D0", Offset = "0x4333CD0", VA = "0x1843350D0")]
		public static EBKJCEEKJGG PreviousSessionEvent([NotNull] string NFJJDKGGBLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4333C60", Offset = "0x4332860", VA = "0x184333C60")]
		public static EBKJCEEKJGG InitializeEvent(string MBJGHLJMDCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4335610", Offset = "0x4334210", VA = "0x184335610")]
		public static EBKJCEEKJGG StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4333470", Offset = "0x4332070", VA = "0x184333470")]
		public static EBKJCEEKJGG CreateOutOfSessionEvent(string NFJJDKGGBLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4334210", Offset = "0x4332E10", VA = "0x184334210")]
		public static DPJKDCDGPPB LogOutOfSessionEvent(EBKJCEEKJGG MMDIEEGKPJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4334060", Offset = "0x4332C60", VA = "0x184334060")]
		public void LogEventAsync(AmplitudeAnalyticsEvent FBBKFMGMDME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x43343E0", Offset = "0x4332FE0", VA = "0x1843343E0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent FBBKFMGMDME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x43344B0", Offset = "0x43330B0", VA = "0x1843344B0")]
		public void LogSerializedEventAsync(Dictionary<string, object> CPBBBHEBKLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4334130", Offset = "0x4332D30", VA = "0x184334130")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HGMPNELNHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4333E80", Offset = "0x4332A80", VA = "0x184333E80")]
		private void JMFLDMCBAIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4334C10", Offset = "0x4333810", VA = "0x184334C10")]
		private void OODKPAOCACK(Dictionary<string, object> MIMNBPGJKDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4333390", Offset = "0x4331F90", VA = "0x184333390")]
		private void BJLAFLEOEKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4334EC0", Offset = "0x4333AC0", VA = "0x184334EC0")]
		private void PAIMENAOMJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x43338F0", Offset = "0x43324F0", VA = "0x1843338F0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4334580", Offset = "0x4333180", VA = "0x184334580")]
		[IteratorStateMachine(typeof(DEKBJHOPOLJ))]
		private IEnumerator<MDIGCEIKMFK> MJODMCIMONN(float ENDBOLINCAJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4333F20", Offset = "0x4332B20", VA = "0x184333F20")]
		[IteratorStateMachine(typeof(IBIMOPGFNLM))]
		private IEnumerator<MDIGCEIKMFK> LDIKGLILLFM(float ENDBOLINCAJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4333980", Offset = "0x4332580", VA = "0x184333980")]
		[IteratorStateMachine(typeof(DCGFLLOLGLA))]
		private IEnumerator<MDIGCEIKMFK> GBMMCNELNLA(ICCOJFOMHDP AGCNLOJJADD, int? PABPJHFJMJM, string DFGOOIMIFIA, string KCFLPIEOPKG, float ENDBOLINCAJ, Action<int> HGFEGJCCMNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4333A30", Offset = "0x4332630", VA = "0x184333A30")]
		private static void GOCBDJAIHJO(bool APHOLLAKMLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x20E7CF0", Offset = "0x20E68F0", VA = "0x1820E7CF0")]
		private global::JLPBMLKOEIK<EJLLJKLDIAG<T>> COEPBPCELLM<T>(string DFGOOIMIFIA, string KCFLPIEOPKG, string GIOPCNKDDMK, T OFCLODICHCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4333340", Offset = "0x4331F40", VA = "0x184333340")]
		private bool BHMEKKELDPH(float KFBFODOADNH, float ENDBOLINCAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4335D20", Offset = "0x4334920", VA = "0x184335D20")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4332C40", Offset = "0x4331840", VA = "0x184332C40")]
		[CompilerGenerated]
		private long AAPGCKLBOIE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4334E30", Offset = "0x4333A30", VA = "0x184334E30")]
		[CompilerGenerated]
		private void OOMIJFIKFOF(int FFAHBLINLNI)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4C6310", Offset = "0x4C4F10", VA = "0x1804C6310")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4336270", Offset = "0x4334E70", VA = "0x184336270")]
		public static EBKJCEEKJGG EOHCEIKEHFP(string CHIJKFCCJLI, [NotNull] string HKFBDEFCCPF, long KDDICLNNIMC, long MCBCJIINAGF, string MBJGHLJMDCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4336350", Offset = "0x4334F50", VA = "0x184336350")]
		public static EBKJCEEKJGG EPNMFFCIOJN(string CHIJKFCCJLI, [NotNull] string HKFBDEFCCPF, long KDDICLNNIMC, long MCBCJIINAGF, string MBJGHLJMDCI, long FJIJCKLGONJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4336680", Offset = "0x4335280", VA = "0x184336680")]
		private AmplitudeAnalyticsEvent(string CHIJKFCCJLI, [NotNull] string HKFBDEFCCPF, long KDDICLNNIMC, long MCBCJIINAGF, string MBJGHLJMDCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x536D00", Offset = "0x535900", VA = "0x180536D00")]
		public void FEGINIDDJBN(long NNJLCAKGJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4336160", Offset = "0x4334D60", VA = "0x184336160", Slot = "5")]
		public override void DFKOJHDGFAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x43360F0", Offset = "0x4334CF0", VA = "0x1843360F0", Slot = "6")]
		public override void DDCIGJLCKAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4336440", Offset = "0x4335040", VA = "0x184336440", Slot = "4")]
		protected override Dictionary<string, object> IODFABBCADD(Dictionary<string, object> EMAGOKICOOD)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x4337CE0", Offset = "0x43368E0", VA = "0x184337CE0")]
			public void OOJPOJFNLOI(Dictionary<string, object> MBPDDGJHGFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x433A6F0", Offset = "0x43392F0", VA = "0x18433A6F0")]
			public void OOJPOJFNLOI(Dictionary<string, object> KOGJPMIHODN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x14066F0", Offset = "0x14052F0", VA = "0x1814066F0")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BEDA0", VA = "0x1804C01A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4C0440", Offset = "0x4BF040", VA = "0x1804C0440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x43369F0", Offset = "0x43355F0", VA = "0x1843369F0")]
		public static IPDONPDCNCI EOHCEIKEHFP(string CHIJKFCCJLI, string MBJGHLJMDCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4336D40", Offset = "0x4335940", VA = "0x184336D40")]
		protected AmplitudeAnalyticsIdentifyMessage(string CHIJKFCCJLI, string MBJGHLJMDCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4336CD0", Offset = "0x43358D0", VA = "0x184336CD0")]
		public Dictionary<string, object> IPGKONPNPIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4336A90", Offset = "0x4335690", VA = "0x184336A90", Slot = "4")]
		protected virtual Dictionary<string, object> IODFABBCADD(Dictionary<string, object> EMAGOKICOOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4336870", Offset = "0x4335470", VA = "0x184336870")]
		protected void CILGPGPNNMB(string FHJAGMPOINB, Dictionary<string, object> LNCAFHJBCBM, Dictionary<string, object> OLBBNFHGEBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4336800", Offset = "0x4335400", VA = "0x184336800")]
		protected void BDHIMOAAOPC(string FHJAGMPOINB, string CKGFDBLPDNJ, Dictionary<string, object> OKLFHBNGIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4336980", Offset = "0x4335580", VA = "0x184336980", Slot = "5")]
		public virtual void DFKOJHDGFAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4336910", Offset = "0x4335510", VA = "0x184336910", Slot = "6")]
		public virtual void DDCIGJLCKAN()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IPDONPDCNCI : global::IEJGJEPIINF<AmplitudeAnalyticsIdentifyMessage, IPDONPDCNCI>
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override IPDONPDCNCI GHCNBEKKKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5519A0", Offset = "0x5505A0", VA = "0x1805519A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BEDA0", VA = "0x1804C01A0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage BGCJICOOOJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x43397D0", Offset = "0x43383D0", VA = "0x1843397D0")]
	public IPDONPDCNCI(AmplitudeAnalyticsIdentifyMessage PKKJAJGOFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4339740", Offset = "0x4338340", VA = "0x184339740", Slot = "4")]
	public override void DDCIGJLCKAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EBKJCEEKJGG : global::IEJGJEPIINF<AmplitudeAnalyticsEvent, EBKJCEEKJGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool BKGBLOJPGKH;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override EBKJCEEKJGG GHCNBEKKKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5519A0", Offset = "0x5505A0", VA = "0x1805519A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4338000", Offset = "0x4336C00", VA = "0x184338000")]
	public EBKJCEEKJGG(AmplitudeAnalyticsEvent PKKJAJGOFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BEDA0", VA = "0x1804C01A0", Slot = "5")]
	public override AmplitudeAnalyticsEvent BGCJICOOOJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4337E00", Offset = "0x4336A00", VA = "0x184337E00", Slot = "4")]
	public override void DDCIGJLCKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2434A90", Offset = "0x2433690", VA = "0x182434A90")]
	public EBKJCEEKJGG FPKENLNJNIP<T>(string DODIPGMFKKN, T[] CKGFDBLPDNJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4337F10", Offset = "0x4336B10", VA = "0x184337F10")]
	public EBKJCEEKJGG FPKENLNJNIP(string DODIPGMFKKN, string[] CKGFDBLPDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2434A20", Offset = "0x2433620", VA = "0x182434A20")]
	public EBKJCEEKJGG FPKENLNJNIP<T>(string DODIPGMFKKN, T CKGFDBLPDNJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4337EA0", Offset = "0x4336AA0", VA = "0x184337EA0")]
	public EBKJCEEKJGG FPKENLNJNIP(string DODIPGMFKKN, string CKGFDBLPDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4337F20", Offset = "0x4336B20", VA = "0x184337F20")]
	private EBKJCEEKJGG JKLCFLHAKGI(string DODIPGMFKKN, object CKGFDBLPDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FJNOJDBFKOB : EBKJCEEKJGG
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4338000", Offset = "0x4336C00", VA = "0x184338000")]
	public FJNOJDBFKOB(AmplitudeAnalyticsEvent PKKJAJGOFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x43380B0", Offset = "0x4336CB0", VA = "0x1843380B0", Slot = "4")]
	public override void DDCIGJLCKAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class IEJGJEPIINF<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::IEJGJEPIINF<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	protected M PKKJAJGOFLD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public abstract BLDR GHCNBEKKKJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1B376C0", Offset = "0x1B362C0", VA = "0x181B376C0")]
	public IEJGJEPIINF(M PKKJAJGOFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x31B4230", Offset = "0x31B2E30", VA = "0x1831B4230")]
	public BLDR PPFIFAGLKGO(AmplitudeAnalyticsIdentifyMessage.DeviceInfo NBOKDMNOKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x31B40B0", Offset = "0x31B2CB0", VA = "0x1831B40B0")]
	public BLDR DPEEOFBEABD(AmplitudeAnalyticsIdentifyMessage.RevenueData BKPCHHFCLBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x31B41C0", Offset = "0x31B2DC0", VA = "0x1831B41C0")]
	public BLDR MHGGOCBJCFC(string DODIPGMFKKN, string CKGFDBLPDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x243AF80", Offset = "0x2439B80", VA = "0x18243AF80")]
	public BLDR MHGGOCBJCFC<T>(string DODIPGMFKKN, T CKGFDBLPDNJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DDCIGJLCKAN();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x31B4080", Offset = "0x31B2C80", VA = "0x1831B4080")]
	internal static string BPOIDKMCJLO(string CKGFDBLPDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x31B40E0", Offset = "0x31B2CE0", VA = "0x1831B40E0")]
	private BLDR IIFLOEPBFFC(string DODIPGMFKKN, object CKGFDBLPDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M BGCJICOOOJH();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ABEEPPIJGHB
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int MDDCONNGHCE = 2;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int DGEFBINLILJ = 100;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const int KJHDHIHLJAJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const long HGHELMMBJCC = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int KBMCKKKCOHL = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const int DKICCNPHKOA = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string HANJLPFIPNP = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string CDFPLOCCFIC = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string EIONFOPAHJC = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string CKANHAAFMLP = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string GDDFOMFNAJJ = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string PDIBNDHEBDI = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string DJPBGIIHPNO = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const string BGBCJGIJMJD = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public const int MEFBKCDLMAP = 10;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> EOHNHCDGNOK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
	public ABEEPPIJGHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GLNPGEAPGNC
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string EGCGBLPAIFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string NNDIBIAIGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string LFEPBHGLIFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::JLPBMLKOEIK<OIOCGEBNNIG> COEPBPCELLM(string DFGOOIMIFIA, Dictionary<string, string> NDCIJPLKIBI);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OIOCGEBNNIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly int BFMMJFPNMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly string DFNOHJNELIK;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4C88C0", Offset = "0x4C74C0", VA = "0x1804C88C0")]
	public OIOCGEBNNIG(int FBHPPHGFNJP, string PGJJBNBOGME)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DNLKDMBGAII
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static byte[] LPPEPCLGPFA;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int ALNIJEPLOPN;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int BOCMDGEBMMF;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static BigInteger AOEPCALDGLN;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
	public DNLKDMBGAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4337700", Offset = "0x4336300", VA = "0x184337700")]
	private static string ENAHEOFOPLE(byte[] HDBDBNKFPIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4337800", Offset = "0x4336400", VA = "0x184337800")]
	public static string JNOEGFCEOHO(byte[] LGMOCOBILLJ, bool NNFMBLOFMHM)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
