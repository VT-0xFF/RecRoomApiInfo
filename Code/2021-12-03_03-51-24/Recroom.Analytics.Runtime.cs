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
		public AmplitudeAnalyticsClient.Settings HOKDAIKLENG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NNEKDIEIJGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x46F160", Offset = "0x46E360", VA = "0x18046F160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA73410", Offset = "0xA72610", VA = "0x180A73410")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum OJEEMFIGNIH
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class NAKPINPBDNL
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class JDKILMICEFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public int IGJFCBLMEIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public Dictionary<string, object> BCNLPGMLLGC;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
				public JDKILMICEFA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class IPADPLAJENE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
				public IPADPLAJENE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x3F08780", Offset = "0x3F07980", VA = "0x183F08780")]
				internal bool <GetBatch>b__0(JDKILMICEFA item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private const string DJEILCBAKOK = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string NJNJDMHBNIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<JDKILMICEFA> FIHPGLLJHLB;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? ODLBJAMNKJN
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x3F093A0", Offset = "0x3F085A0", VA = "0x183F093A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? OHHOMKLBGCM
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x3F09190", Offset = "0x3F08390", VA = "0x183F09190")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3F0A310", Offset = "0x3F09510", VA = "0x183F0A310")]
			internal NAKPINPBDNL(string IKJDJCNPOBJ, string LHODDEGKLOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3F09240", Offset = "0x3F08440", VA = "0x183F09240")]
			public int CIHAKADDHKA([Optional] int? NFFEMDHBBHJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3F09BF0", Offset = "0x3F08DF0", VA = "0x183F09BF0")]
			public List<Dictionary<string, object>> LACEMPHHFLN(int BBEHPJMGPLK, int? NFFEMDHBBHJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3F09930", Offset = "0x3F08B30", VA = "0x183F09930")]
			public void KEALEPHMDGJ(AmplitudeAnalyticsIdentifyMessage NLPBLPBCJHC, bool HDLIPPLCCKJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3F099D0", Offset = "0x3F08BD0", VA = "0x183F099D0")]
			public void KEALEPHMDGJ(Dictionary<string, object> NLPBLPBCJHC, bool HDLIPPLCCKJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3F09800", Offset = "0x3F08A00", VA = "0x183F09800")]
			public void HLICMPPAIGO(params Dictionary<string, object>[] HGLIBPDDDPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3F09DF0", Offset = "0x3F08FF0", VA = "0x183F09DF0")]
			public void MNAHOIHGKCD(List<Dictionary<string, object>> ENFJPMLALFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3F0A200", Offset = "0x3F09400", VA = "0x183F0A200")]
			private void PJNNEHKFDFG(Dictionary<string, object> NLPBLPBCJHC, bool HDLIPPLCCKJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3F0A010", Offset = "0x3F09210", VA = "0x183F0A010")]
			public void PAGNPDNPGKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3F09430", Offset = "0x3F08630", VA = "0x183F09430")]
			private void HBEHIINJEHC([Optional] string HDBEHELPKNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3F09AC0", Offset = "0x3F08CC0", VA = "0x183F09AC0")]
			private static string KINBFNMBEFO(string LNFKIKOILLL, string FIIDMDOOCIB)
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
			[Cpp2IlInjected.Address(RVA = "0x3F0B960", Offset = "0x3F0AB60", VA = "0x183F0B960")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct CLPGHKEJBPP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int CLLOAFGDEJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public string FGOJCDHKNNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T HJFDKHMIHMO;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class PKEEBBFAAMC : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private GAGJCGDODGC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public PKEEBBFAAMC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3F0B0D0", Offset = "0x3F0A2D0", VA = "0x183F0B0D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3F0B7F0", Offset = "0x3F0A9F0", VA = "0x183F0B7F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class BGNJLBFFIKN : IEnumerator<object>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public BGNJLBFFIKN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3F07EA0", Offset = "0x3F070A0", VA = "0x183F07EA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3F07F70", Offset = "0x3F07170", VA = "0x183F07F70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LEIFHLPHNLL : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public LEIFHLPHNLL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3F08E00", Offset = "0x3F08000", VA = "0x183F08E00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3F08F40", Offset = "0x3F08140", VA = "0x183F08F40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class CDOMPFFOMEG : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private GAGJCGDODGC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public CDOMPFFOMEG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3F07FC0", Offset = "0x3F071C0", VA = "0x183F07FC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3F08200", Offset = "0x3F07400", VA = "0x183F08200", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class GAPNNLNAGMI : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private GAGJCGDODGC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public GAPNNLNAGMI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3F08370", Offset = "0x3F07570", VA = "0x183F08370", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3F085B0", Offset = "0x3F077B0", VA = "0x183F085B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class KNABGOOLIDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public NAKPINPBDNL cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
			public KNABGOOLIDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3F087E0", Offset = "0x3F079E0", VA = "0x183F087E0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3F08880", Offset = "0x3F07A80", VA = "0x183F08880")]
			internal void <FlushFromCache>b__1(CLPGHKEJBPP<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class PHOMKBGCBKP : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private GAGJCGDODGC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public NAKPINPBDNL cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private KNABGOOLIDB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public PHOMKBGCBKP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x3F0AA40", Offset = "0x3F09C40", VA = "0x183F0AA40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3F0B080", Offset = "0x3F0A280", VA = "0x183F0B080", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class PGFKEAJKPKI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
			public PGFKEAJKPKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2C03050", Offset = "0x2C02250", VA = "0x182C03050")]
			internal CLPGHKEJBPP<T> <PostJson>b__0(DBOIDMMPBAI postResponse)
			{
				return default(CLPGHKEJBPP<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private EGAGPEPFKCL HKFDOGJFNCN;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string NGLNOHHFFMD = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string GDMDNPPOJHN = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string FDNAGGIJIMO = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string LGOMIFMJAGF = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string AAKPEGEKJLC = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int HJPAACIDGFK = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int FNKOBCDKNAK = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int LFPMJJDMFBH = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float GIODDPJDFEE = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long ADMACCFLIBN = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string MEKIHHPHOBB = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static bool PKNBIEMMJDM;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool IOOEFLFECBK;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static int FGNHBLBFOCH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int NGPGOGHDEGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private HIPMIHGNAJO CCOIHHDOALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool LFPDIMGDCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float IINLCKOAAFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float MOJHNJLCNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int CJNBFLMMGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int LAKDDJKDNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int? JKNBKHMGBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? FEPBGHDBJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private long EGKAMAEBGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string LLNBGCNKNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long MAHKAMFFJJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, object> HNHKOKCFHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OJEEMFIGNIH LOPAJOPLCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int IKINFCADPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int HPMLOBDOJFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float NDLOOBFMFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool BJAFIFJAJAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool DPGLEBDHONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private NAKPINPBDNL CDHDACLGGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private NAKPINPBDNL KBGGKIJGDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NAKPINPBDNL BFONMEIBJKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> KLCMCGJHAFP;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo NLLBECDDPMF;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static string BGPCIDEFEDO;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string CGANLOFLCPG = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string EJGGKPCOLGA = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private EGAGPEPFKCL DJKFDBMEEOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3F049C0", Offset = "0x3F03BC0", VA = "0x183F049C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int MDFNJGJGELI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3F05F70", Offset = "0x3F05170", VA = "0x183F05F70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long BFOCPOLNMPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3F07050", Offset = "0x3F06250", VA = "0x183F07050")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3F07150", Offset = "0x3F06350", VA = "0x183F07150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string HJOFAOECPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3F07020", Offset = "0x3F06220", VA = "0x183F07020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string ICMDOLKFMCG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x492950", Offset = "0x491B50", VA = "0x180492950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x480A40", Offset = "0x47FC40", VA = "0x180480A40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool EMBLABOMJLK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x528FC0", Offset = "0x5281C0", VA = "0x180528FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD57480", Offset = "0xD56680", VA = "0x180D57480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool FDEDLLGOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3F06F40", Offset = "0x3F06140", VA = "0x183F06F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> KPBKMHAACKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3F06EA0", Offset = "0x3F060A0", VA = "0x183F06EA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3F070B0", Offset = "0x3F062B0", VA = "0x183F070B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3F03F00", Offset = "0x3F03100", VA = "0x183F03F00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3F06930", Offset = "0x3F05B30", VA = "0x183F06930")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3F05EF0", Offset = "0x3F050F0", VA = "0x183F05EF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3F06AB0", Offset = "0x3F05CB0", VA = "0x183F06AB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3F04F00", Offset = "0x3F04100", VA = "0x183F04F00")]
		private bool IMIAGJNODMJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3F05250", Offset = "0x3F04450", VA = "0x183F05250")]
		[IteratorStateMachine(typeof(PKEEBBFAAMC))]
		public IEnumerator<GAGJCGDODGC> Initialize(AmplitudeAnalyticsEvent JGEJGLMGAAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F06A00", Offset = "0x3F05C00", VA = "0x183F06A00")]
		public void UpdateLastAliveTime(float PICBMLKBMHD = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3F052C0", Offset = "0x3F044C0", VA = "0x183F052C0")]
		private bool JCKJLMCPBKG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3F05550", Offset = "0x3F04750", VA = "0x183F05550")]
		private bool KJKEEMCJDEM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3F065C0", Offset = "0x3F057C0", VA = "0x183F065C0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3F05E90", Offset = "0x3F05090", VA = "0x183F05E90")]
		[IteratorStateMachine(typeof(BGNJLBFFIKN))]
		private IEnumerator OHFBFJBKIMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3F06D10", Offset = "0x3F05F10", VA = "0x183F06D10")]
		[IteratorStateMachine(typeof(LEIFHLPHNLL))]
		public IEnumerator WaitForFlush(float JBCODGIJMAH = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3F06940", Offset = "0x3F05B40", VA = "0x183F06940")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3F04F60", Offset = "0x3F04160", VA = "0x183F04F60")]
		public static IANHCKADOBN Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3F03DC0", Offset = "0x3F02FC0", VA = "0x183F03DC0")]
		public static MDEPCJLODIE AccountSelectionPostLoginEvent([NotNull] string NDMLFPAGPCI, string GACIGIDLAOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3F04A90", Offset = "0x3F03C90", VA = "0x183F04A90")]
		public static MDEPCJLODIE Event([NotNull] string NDMLFPAGPCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F06190", Offset = "0x3F05390", VA = "0x183F06190")]
		public static MDEPCJLODIE PreviousSessionEvent([NotNull] string NDMLFPAGPCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3F050A0", Offset = "0x3F042A0", VA = "0x183F050A0")]
		public static MDEPCJLODIE InitializeEvent(string GACIGIDLAOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F066D0", Offset = "0x3F058D0", VA = "0x183F066D0")]
		public static MDEPCJLODIE StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F04420", Offset = "0x3F03620", VA = "0x183F04420")]
		public static MDEPCJLODIE CreateOutOfSessionEvent(string NDMLFPAGPCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F058E0", Offset = "0x3F04AE0", VA = "0x183F058E0")]
		public static MLALFLMLHEI LogOutOfSessionEvent(MDEPCJLODIE KMIAJLHEJAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F05730", Offset = "0x3F04930", VA = "0x183F05730")]
		public void LogEventAsync(AmplitudeAnalyticsEvent OAMCIIIBEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3F05AB0", Offset = "0x3F04CB0", VA = "0x183F05AB0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent OAMCIIIBEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F05B80", Offset = "0x3F04D80", VA = "0x183F05B80")]
		public void LogSerializedEventAsync(Dictionary<string, object> BHGHNOINPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3F05800", Offset = "0x3F04A00", VA = "0x183F05800")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HJKBHONJONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3F04380", Offset = "0x3F03580", VA = "0x183F04380")]
		private void BNKDGIECEJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3F047A0", Offset = "0x3F039A0", VA = "0x183F047A0")]
		private void ENLJMDNEDCE(Dictionary<string, object> JIMCDJPCPGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3F05DB0", Offset = "0x3F04FB0", VA = "0x183F05DB0")]
		private void MEGMLOCHDDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3F04BF0", Offset = "0x3F03DF0", VA = "0x183F04BF0")]
		private void FPAGFECGKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3F04D80", Offset = "0x3F03F80", VA = "0x183F04D80")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3F04730", Offset = "0x3F03930", VA = "0x183F04730")]
		[IteratorStateMachine(typeof(CDOMPFFOMEG))]
		private IEnumerator<GAGJCGDODGC> EJPFIMMNEKB(float JBCODGIJMAH = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F054E0", Offset = "0x3F046E0", VA = "0x183F054E0")]
		[IteratorStateMachine(typeof(GAPNNLNAGMI))]
		private IEnumerator<GAGJCGDODGC> KENFNCHFLLA(float JBCODGIJMAH = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3F05430", Offset = "0x3F04630", VA = "0x183F05430")]
		[IteratorStateMachine(typeof(PHOMKBGCBKP))]
		private IEnumerator<GAGJCGDODGC> KBFCJHIOHIL(NAKPINPBDNL ECBEMAPBCHH, int? NFFEMDHBBHJ, string GJAPHDHIFBP, string FAJOLBAACFL, float JBCODGIJMAH, Action<int> DIAOLGNFANG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3F04E10", Offset = "0x3F04010", VA = "0x183F04E10")]
		private static void HKBCKEIFBPH(bool JKMNEJKDFLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x19EB7C0", Offset = "0x19EA9C0", VA = "0x1819EB7C0")]
		private global::GFAADABKIAG<CLPGHKEJBPP<T>> FKBAJJEIIHL<T>(string GJAPHDHIFBP, string FAJOLBAACFL, string DDPMCDPBNJD, T HJFDKHMIHMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3F046D0", Offset = "0x3F038D0", VA = "0x183F046D0")]
		private bool DFDJICMMMPE(float HEMMAKNJOMB, float JBCODGIJMAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3F06DE0", Offset = "0x3F05FE0", VA = "0x183F06DE0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3F05C50", Offset = "0x3F04E50", VA = "0x183F05C50")]
		[CompilerGenerated]
		private long MCCBBHHIKJK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3F04720", Offset = "0x3F03920", VA = "0x183F04720")]
		[CompilerGenerated]
		private void EJJLJDEOJMC(int KNPHCCHONAG)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x475310", Offset = "0x474510", VA = "0x180475310")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3F072A0", Offset = "0x3F064A0", VA = "0x183F072A0")]
		public static MDEPCJLODIE BNELFEDOIHI(string PBJKBDFKJND, [NotNull] string FCENKLOFDOF, long HFIFPCILFJC, long AOLAILEGGND, string GACIGIDLAOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3F071B0", Offset = "0x3F063B0", VA = "0x183F071B0")]
		public static MDEPCJLODIE AFLOPBIOBJF(string PBJKBDFKJND, [NotNull] string FCENKLOFDOF, long HFIFPCILFJC, long AOLAILEGGND, string GACIGIDLAOE, long HDCNOBIMKDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3F07740", Offset = "0x3F06940", VA = "0x183F07740")]
		private AmplitudeAnalyticsEvent(string PBJKBDFKJND, [NotNull] string FCENKLOFDOF, long HFIFPCILFJC, long AOLAILEGGND, string GACIGIDLAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4E5D00", Offset = "0x4E4F00", VA = "0x1804E5D00")]
		public void EEONMLGPGOC(long JJBIMJJAIFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3F075C0", Offset = "0x3F067C0", VA = "0x183F075C0", Slot = "5")]
		public override void FDNGJPNIMEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3F076D0", Offset = "0x3F068D0", VA = "0x183F076D0", Slot = "6")]
		public override void KGBOGFMJOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3F07380", Offset = "0x3F06580", VA = "0x183F07380", Slot = "4")]
		protected override Dictionary<string, object> CFOOFPNBLNP(Dictionary<string, object> COJHGAGMOLC)
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
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x3F08250", Offset = "0x3F07450", VA = "0x183F08250")]
			public void GHCFIDCHKBG(Dictionary<string, object> GMMFBEHBPMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3F0B840", Offset = "0x3F0AA40", VA = "0x183F0B840")]
			public void GHCFIDCHKBG(Dictionary<string, object> BKCCFGFFBGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD63850", Offset = "0xD62A50", VA = "0x180D63850")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x46F1A0", Offset = "0x46E3A0", VA = "0x18046F1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x46F440", Offset = "0x46E640", VA = "0x18046F440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3F07930", Offset = "0x3F06B30", VA = "0x183F07930")]
		public static IANHCKADOBN BNELFEDOIHI(string PBJKBDFKJND, string GACIGIDLAOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3F07E00", Offset = "0x3F07000", VA = "0x183F07E00")]
		protected AmplitudeAnalyticsIdentifyMessage(string PBJKBDFKJND, string GACIGIDLAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3F078C0", Offset = "0x3F06AC0", VA = "0x183F078C0")]
		public Dictionary<string, object> AKAFFGPEKKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3F079D0", Offset = "0x3F06BD0", VA = "0x183F079D0", Slot = "4")]
		protected virtual Dictionary<string, object> CFOOFPNBLNP(Dictionary<string, object> COJHGAGMOLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3F07D60", Offset = "0x3F06F60", VA = "0x183F07D60")]
		protected void KJKBDLKIAEO(string FIIDMDOOCIB, Dictionary<string, object> PMIDKAACJMP, Dictionary<string, object> FKIJEBIGCCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3F07C80", Offset = "0x3F06E80", VA = "0x183F07C80")]
		protected void GNHEKJFHIJF(string FIIDMDOOCIB, string LNFKIKOILLL, Dictionary<string, object> GPCLDJEONBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3F07C10", Offset = "0x3F06E10", VA = "0x183F07C10", Slot = "5")]
		public virtual void FDNGJPNIMEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3F07CF0", Offset = "0x3F06EF0", VA = "0x183F07CF0", Slot = "6")]
		public virtual void KGBOGFMJOCM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IANHCKADOBN : global::PNNHKLMDAIO<AmplitudeAnalyticsIdentifyMessage, IANHCKADOBN>
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override IANHCKADOBN OKPHICPPIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5009A0", Offset = "0x4FFBA0", VA = "0x1805009A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x46F1A0", Offset = "0x46E3A0", VA = "0x18046F1A0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage NEGHMKEOJPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3F08730", Offset = "0x3F07930", VA = "0x183F08730")]
	public IANHCKADOBN(AmplitudeAnalyticsIdentifyMessage FFIHOEDPEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3F086A0", Offset = "0x3F078A0", VA = "0x183F086A0", Slot = "4")]
	public override void KGBOGFMJOCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MDEPCJLODIE : global::PNNHKLMDAIO<AmplitudeAnalyticsEvent, MDEPCJLODIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool JNMPBEHFDKM;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override MDEPCJLODIE OKPHICPPIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5009A0", Offset = "0x4FFBA0", VA = "0x1805009A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3F08DB0", Offset = "0x3F07FB0", VA = "0x183F08DB0")]
	public MDEPCJLODIE(AmplitudeAnalyticsEvent FFIHOEDPEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x46F1A0", Offset = "0x46E3A0", VA = "0x18046F1A0", Slot = "5")]
	public override AmplitudeAnalyticsEvent NEGHMKEOJPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3F09070", Offset = "0x3F08270", VA = "0x183F09070", Slot = "4")]
	public override void KGBOGFMJOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1B1A550", Offset = "0x1B19750", VA = "0x181B1A550")]
	public MDEPCJLODIE OGCHIGCIGPA<T>(string NFIHNFFMHPJ, T[] LNFKIKOILLL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3F09110", Offset = "0x3F08310", VA = "0x183F09110")]
	public MDEPCJLODIE OGCHIGCIGPA(string NFIHNFFMHPJ, string[] LNFKIKOILLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1B1A4E0", Offset = "0x1B196E0", VA = "0x181B1A4E0")]
	public MDEPCJLODIE OGCHIGCIGPA<T>(string NFIHNFFMHPJ, T LNFKIKOILLL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3F09120", Offset = "0x3F08320", VA = "0x183F09120")]
	public MDEPCJLODIE OGCHIGCIGPA(string NFIHNFFMHPJ, string LNFKIKOILLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3F08F90", Offset = "0x3F08190", VA = "0x183F08F90")]
	private MDEPCJLODIE GHDMNHFHPIK(string NFIHNFFMHPJ, object LNFKIKOILLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LEAILCAHDCA : MDEPCJLODIE
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3F08DB0", Offset = "0x3F07FB0", VA = "0x183F08DB0")]
	public LEAILCAHDCA(AmplitudeAnalyticsEvent FFIHOEDPEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3F08C80", Offset = "0x3F07E80", VA = "0x183F08C80", Slot = "4")]
	public override void KGBOGFMJOCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class PNNHKLMDAIO<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::PNNHKLMDAIO<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	protected M FFIHOEDPEIM;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public abstract BLDR OKPHICPPIPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2052D70", Offset = "0x2051F70", VA = "0x182052D70")]
	public PNNHKLMDAIO(M FFIHOEDPEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2E38D60", Offset = "0x2E37F60", VA = "0x182E38D60")]
	public BLDR PGFLEDNKHFF(AmplitudeAnalyticsIdentifyMessage.DeviceInfo BGOIECMCOPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2E38D00", Offset = "0x2E37F00", VA = "0x182E38D00")]
	public BLDR JCOKOBBACFE(AmplitudeAnalyticsIdentifyMessage.RevenueData OMDCCGFMCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2E38BB0", Offset = "0x2E37DB0", VA = "0x182E38BB0")]
	public BLDR AGMDPCPKJCN(string NFIHNFFMHPJ, string LNFKIKOILLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x19F7690", Offset = "0x19F6890", VA = "0x1819F7690")]
	public BLDR AGMDPCPKJCN<T>(string NFIHNFFMHPJ, T LNFKIKOILLL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KGBOGFMJOCM();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2E38D30", Offset = "0x2E37F30", VA = "0x182E38D30")]
	internal static string OFCPCEGMOJA(string LNFKIKOILLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2E38C20", Offset = "0x2E37E20", VA = "0x182E38C20")]
	private BLDR CKHEBELFALG(string NFIHNFFMHPJ, object LNFKIKOILLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M NEGHMKEOJPJ();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HLHCFOLCFAM
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public const int KLFIHJPDJCH = 2;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int GCFDANEMDCJ = 100;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int MANMOOLMMLD = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const long BFBCKJABCKF = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const int COIPAFKHHCK = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int OBPCFNJBMFD = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const string OILAJLEHMHC = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string OCBELGBBNFF = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string KGEGEPAEBDF = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string IMGNAJODNND = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string IEILEHAADIM = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string JKCDNKMDAAP = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string DNNGCHOJLDK = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string JAOMKIBEDID = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const int HIBAJCIGKFI = 10;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> KFCCCKNFPLK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
	public HLHCFOLCFAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HIPMIHGNAJO
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string JKMCLPLFFCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string EHOLBKNBLMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string OHDIOGBJFKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::GFAADABKIAG<DBOIDMMPBAI> FKBAJJEIIHL(string GJAPHDHIFBP, Dictionary<string, string> BNHCOBACNNO);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DBOIDMMPBAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly int BHNABNCIGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly string EPNBBKANIFI;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4778C0", Offset = "0x476AC0", VA = "0x1804778C0")]
	public DBOIDMMPBAI(int CLLOAFGDEJO, string FGOJCDHKNNM)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PCNMAEEHMFA
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static byte[] JCMJECHILOC;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int BNIACGCEGJA;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int BOLEHDFPPKM;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static BigInteger IJJDCIAOLCD;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
	public PCNMAEEHMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3F0A460", Offset = "0x3F09660", VA = "0x183F0A460")]
	private static string MFCANKEIEIP(byte[] BECJLMJILAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3F0A560", Offset = "0x3F09760", VA = "0x183F0A560")]
	public static string MMKAAAJKMHB(byte[] MNCFCOKJIPF, bool EGIHCEJJLCP)
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

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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
