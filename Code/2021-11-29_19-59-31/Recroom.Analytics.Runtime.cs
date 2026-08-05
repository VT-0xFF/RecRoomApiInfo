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
		public AmplitudeAnalyticsClient.Settings FAPNMKPDHCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HHHNJKNANKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x427160", Offset = "0x425B60", VA = "0x180427160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6691E0", Offset = "0x667BE0", VA = "0x1806691E0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum DLDMMEJEIPH
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class GIKOCCGBOKM
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class KLHKIEKHMEP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public int MHMHAPJOCDH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public Dictionary<string, object> KMJMBENOJHB;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
				public KLHKIEKHMEP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class LPAGBLLPAIA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
				public LPAGBLLPAIA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x3D3C790", Offset = "0x3D3B190", VA = "0x183D3C790")]
				internal bool <GetBatch>b__0(KLHKIEKHMEP item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private const string BDLKNBECHKJ = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string DPEIBPJEGHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<KLHKIEKHMEP> OLNOMCOBGFA;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? EMKAIOMHPFJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x3D3B4A0", Offset = "0x3D39EA0", VA = "0x183D3B4A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? FJIECDOBJDN
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x3D3AA50", Offset = "0x3D39450", VA = "0x183D3AA50")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3D3B9B0", Offset = "0x3D3A3B0", VA = "0x183D3B9B0")]
			internal GIKOCCGBOKM(string FCFHGCCEHMK, string OOADIEPBJDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3D3B530", Offset = "0x3D39F30", VA = "0x183D3B530")]
			public int EMOLGEABABL([Optional] int? LKBEFLPMHOL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3D3AFE0", Offset = "0x3D399E0", VA = "0x183D3AFE0")]
			public List<Dictionary<string, object>> DMOJEKCPPKK(int OKLAHLKONLG, int? LKBEFLPMHOL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3D3B400", Offset = "0x3D39E00", VA = "0x183D3B400")]
			public void EKKGKFPGGGD(AmplitudeAnalyticsIdentifyMessage AEFCLOMAMKL, bool CEGPFBMPMBB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3D3B310", Offset = "0x3D39D10", VA = "0x183D3B310")]
			public void EKKGKFPGGGD(Dictionary<string, object> AEFCLOMAMKL, bool CEGPFBMPMBB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3D3B880", Offset = "0x3D3A280", VA = "0x183D3B880")]
			public void MANDCHPOCFI(params Dictionary<string, object>[] AIEDOMNKNDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3D3A830", Offset = "0x3D39230", VA = "0x183D3A830")]
			public void BAJJEALLNDO(List<Dictionary<string, object>> AJFDCAGMEMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3D3AED0", Offset = "0x3D398D0", VA = "0x183D3AED0")]
			private void DINFGNMAKLK(Dictionary<string, object> AEFCLOMAMKL, bool CEGPFBMPMBB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3D3B690", Offset = "0x3D3A090", VA = "0x183D3B690")]
			public void HCFGKNJDJGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3D3AB00", Offset = "0x3D39500", VA = "0x183D3AB00")]
			private void DCGBFBOHHDL([Optional] string GFCBDLBAODB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3D3B1E0", Offset = "0x3D39BE0", VA = "0x183D3B1E0")]
			private static string EIECOGMMLBF(string MDAEJMIAMDO, string AOLPFBNJMEA)
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
			[Cpp2IlInjected.Address(RVA = "0x3D3DC50", Offset = "0x3D3C650", VA = "0x183D3DC50")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct PNGOLOACLPP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int OPFCKHBIDEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public string KMEOLILACHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T PGKIOIEMBOB;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class NOMLOOHENAP : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private EIDNADAHLNE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
			[DebuggerHidden]
			public NOMLOOHENAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3D3CE80", Offset = "0x3D3B880", VA = "0x183D3CE80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3D3D5A0", Offset = "0x3D3BFA0", VA = "0x183D3D5A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class FMLHPBLJHEM : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
			[DebuggerHidden]
			public FMLHPBLJHEM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3D3A710", Offset = "0x3D39110", VA = "0x183D3A710", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3D3A7E0", Offset = "0x3D391E0", VA = "0x183D3A7E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JNPPOCAJDKP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
			[DebuggerHidden]
			public JNPPOCAJDKP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3D3C370", Offset = "0x3D3AD70", VA = "0x183D3C370", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3D3C4B0", Offset = "0x3D3AEB0", VA = "0x183D3C4B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LMOOAOFHIIA : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private EIDNADAHLNE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
			[DebuggerHidden]
			public LMOOAOFHIIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3D3C500", Offset = "0x3D3AF00", VA = "0x183D3C500", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3D3C740", Offset = "0x3D3B140", VA = "0x183D3C740", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JIDKBHJLONH : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private EIDNADAHLNE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
			[DebuggerHidden]
			public JIDKBHJLONH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3D3C0E0", Offset = "0x3D3AAE0", VA = "0x183D3C0E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3D3C320", Offset = "0x3D3AD20", VA = "0x183D3C320", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class OOEEJPFEDAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public GIKOCCGBOKM cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
			public OOEEJPFEDAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3D3D690", Offset = "0x3D3C090", VA = "0x183D3D690")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3D3D730", Offset = "0x3D3C130", VA = "0x183D3D730")]
			internal void <FlushFromCache>b__1(PNGOLOACLPP<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class MGEHGIEOMKI : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private EIDNADAHLNE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public GIKOCCGBOKM cache;

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
			private OOEEJPFEDAE <>8__1;

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
			private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
			[DebuggerHidden]
			public MGEHGIEOMKI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x3D3C7F0", Offset = "0x3D3B1F0", VA = "0x183D3C7F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3D3CE30", Offset = "0x3D3B830", VA = "0x183D3CE30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class JJJFDGAJPKK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
			public JJJFDGAJPKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2EA31A0", Offset = "0x2EA1BA0", VA = "0x182EA31A0")]
			internal PNGOLOACLPP<T> <PostJson>b__0(CCLNKJFAACJ postResponse)
			{
				return default(PNGOLOACLPP<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ONPGCPFDNJG ANNLAEODDIA;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string EGDLKFPKPON = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string JELIHBIOIOH = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string BAEJMEMDCFK = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string EIMJCPDEHDH = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string CHDDKEFLCEF = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int OMPKLGLINAI = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int MAGBNFLNDCM = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int DHGACNMMIJA = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float OMCJLDCKANH = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long ELLDMJHKJDC = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string JJIBGHELGCF = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static bool DCJGEBOGJIN;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool OEJJNJBNGAF;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static int PNBOINOGPDH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int JOFOAOHIPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private CDPHNMFBIJC PAABEPKKPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool IFEHNOMPEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float NPNLAPLOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float CKCNNGCJLMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int HNFLNDJJAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int CONMNNLEEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int? KGNEEFLEGPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? AOMLKAMMHDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private long LEGHBEPCNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string LLEHPKCBGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long FIEFPFPAICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, object> BHBJDGEKIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private DLDMMEJEIPH MONKBFOOLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int GOLKEIFIPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int DCKJBFICJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float DFDMDJKGJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool AEFABPOFBMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool CLOHCGKMHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private GIKOCCGBOKM DDDFGBNELOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GIKOCCGBOKM CHEOFFAJCNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GIKOCCGBOKM OGAJLGIODAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> DPBCLLKLCDL;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo CJBGNGOEHPD;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static string KELDGCONBOH;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string OCHLDLKPPJK = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string DFPPAILAFOE = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ONPGCPFDNJG PAKBECMAIBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3D37270", Offset = "0x3D35C70", VA = "0x183D37270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int OBNGFNJCABF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3D360B0", Offset = "0x3D34AB0", VA = "0x183D360B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long MHHCMJBMOPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3D39340", Offset = "0x3D37D40", VA = "0x183D39340")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3D39440", Offset = "0x3D37E40", VA = "0x183D39440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string HBOLNLGLDIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3D39310", Offset = "0x3D37D10", VA = "0x183D39310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string PMOKCNGALOL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x44A950", Offset = "0x449350", VA = "0x18044A950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x438A40", Offset = "0x437440", VA = "0x180438A40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IHGIONCGDPE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x533EB0", Offset = "0x5328B0", VA = "0x180533EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x95CF00", Offset = "0x95B900", VA = "0x18095CF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool CBCKOCDLKJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3D39230", Offset = "0x3D37C30", VA = "0x183D39230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> HHEMLEKBKCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3D39190", Offset = "0x3D37B90", VA = "0x183D39190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3D393A0", Offset = "0x3D37DA0", VA = "0x183D393A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D36570", Offset = "0x3D34F70", VA = "0x183D36570", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3D38C20", Offset = "0x3D37620", VA = "0x183D38C20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3D381E0", Offset = "0x3D36BE0", VA = "0x183D381E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D38DA0", Offset = "0x3D377A0", VA = "0x183D38DA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D373D0", Offset = "0x3D35DD0", VA = "0x183D373D0")]
		private bool GBCMMIJKAFD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D37880", Offset = "0x3D36280", VA = "0x183D37880")]
		[IteratorStateMachine(typeof(NOMLOOHENAP))]
		public IEnumerator<EIDNADAHLNE> Initialize(AmplitudeAnalyticsEvent CJAHNAKABMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D38CF0", Offset = "0x3D376F0", VA = "0x183D38CF0")]
		public void UpdateLastAliveTime(float JMFBDHDFBHJ = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D36E80", Offset = "0x3D35880", VA = "0x183D36E80")]
		private bool DIKCJKMPPGE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D369F0", Offset = "0x3D353F0", VA = "0x183D369F0")]
		private bool BDKAIOMCCLE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D388B0", Offset = "0x3D372B0", VA = "0x183D388B0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D378F0", Offset = "0x3D362F0", VA = "0x183D378F0")]
		[IteratorStateMachine(typeof(FMLHPBLJHEM))]
		private IEnumerator JNLHMKKGBIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D39000", Offset = "0x3D37A00", VA = "0x183D39000")]
		[IteratorStateMachine(typeof(JNPPOCAJDKP))]
		public IEnumerator WaitForFlush(float FFCJMJIHICJ = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D38C30", Offset = "0x3D37630", VA = "0x183D38C30")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D37590", Offset = "0x3D35F90", VA = "0x183D37590")]
		public static FKGHBJKHOFO Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D36430", Offset = "0x3D34E30", VA = "0x183D36430")]
		public static FHLINMEEOCC AccountSelectionPostLoginEvent([NotNull] string BKIJLJAKACA, string GIPGFNHGNCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D37060", Offset = "0x3D35A60", VA = "0x183D37060")]
		public static FHLINMEEOCC Event([NotNull] string BKIJLJAKACA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D38480", Offset = "0x3D36E80", VA = "0x183D38480")]
		public static FHLINMEEOCC PreviousSessionEvent([NotNull] string BKIJLJAKACA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3D376D0", Offset = "0x3D360D0", VA = "0x183D376D0")]
		public static FHLINMEEOCC InitializeEvent(string GIPGFNHGNCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3D389C0", Offset = "0x3D373C0", VA = "0x183D389C0")]
		public static FHLINMEEOCC StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D36BD0", Offset = "0x3D355D0", VA = "0x183D36BD0")]
		public static FHLINMEEOCC CreateOutOfSessionEvent(string BKIJLJAKACA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3D37B00", Offset = "0x3D36500", VA = "0x183D37B00")]
		public static OJNMJAKAOEK LogOutOfSessionEvent(FHLINMEEOCC NOMBMBNFJIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3D37950", Offset = "0x3D36350", VA = "0x183D37950")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LABOGNOCJNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D37CD0", Offset = "0x3D366D0", VA = "0x183D37CD0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LABOGNOCJNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D37DA0", Offset = "0x3D367A0", VA = "0x183D37DA0")]
		public void LogSerializedEventAsync(Dictionary<string, object> GLPCDGBFJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D37A20", Offset = "0x3D36420", VA = "0x183D37A20")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage JCFHBDDLODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3D37430", Offset = "0x3D35E30", VA = "0x183D37430")]
		private void GBDELKNKPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D38260", Offset = "0x3D36C60", VA = "0x183D38260")]
		private void PHKIDFIOKPM(Dictionary<string, object> CHNEGDBDNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3D38100", Offset = "0x3D36B00", VA = "0x183D38100")]
		private void OHGBNBBBJBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3D37F70", Offset = "0x3D36970", VA = "0x183D37F70")]
		private void OAHGNDGFAOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3D37340", Offset = "0x3D35D40", VA = "0x183D37340")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D36FF0", Offset = "0x3D359F0", VA = "0x183D36FF0")]
		[IteratorStateMachine(typeof(LMOOAOFHIIA))]
		private IEnumerator<EIDNADAHLNE> DJBLPGMNDME(float FFCJMJIHICJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D37520", Offset = "0x3D35F20", VA = "0x183D37520")]
		[IteratorStateMachine(typeof(JIDKBHJLONH))]
		private IEnumerator<EIDNADAHLNE> ILBEHAKAEKC(float FFCJMJIHICJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D371C0", Offset = "0x3D35BC0", VA = "0x183D371C0")]
		[IteratorStateMachine(typeof(MGEHGIEOMKI))]
		private IEnumerator<EIDNADAHLNE> FMOKCAKDMBB(GIKOCCGBOKM GLJIPJCLMGI, int? LKBEFLPMHOL, string MCOCNFJCCDK, string PECIMADIHDM, float FFCJMJIHICJ, Action<int> IOALLAHPPCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3D37E80", Offset = "0x3D36880", VA = "0x183D37E80")]
		private static void OAFMGLFDHND(bool JIOKLDLCOJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x234D970", Offset = "0x234C370", VA = "0x18234D970")]
		private global::GDHDNGFJPDI<PNGOLOACLPP<T>> PBJHAABDJEC<T>(string MCOCNFJCCDK, string PECIMADIHDM, string EPLAGFLHJGE, T PGKIOIEMBOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3D374D0", Offset = "0x3D35ED0", VA = "0x183D374D0")]
		private bool HGLBDHHJBOM(float LJBPJFGAPNI, float FFCJMJIHICJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D390D0", Offset = "0x3D37AD0", VA = "0x183D390D0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D362D0", Offset = "0x3D34CD0", VA = "0x183D362D0")]
		[CompilerGenerated]
		private long ANGPBOEJOJE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3D37E70", Offset = "0x3D36870", VA = "0x183D37E70")]
		[CompilerGenerated]
		private void MGADFGJDOCL(int IEFFOHBHGHP)
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
			[Cpp2IlInjected.Address(RVA = "0x42D310", Offset = "0x42BD10", VA = "0x18042D310")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3D39840", Offset = "0x3D38240", VA = "0x183D39840")]
		public static FHLINMEEOCC KNEDIEMGNBJ(string CDLFFBAPNOH, [NotNull] string DINDJMGGFGD, long DGCCNOCLJAN, long CFGHADHPDEE, string GIPGFNHGNCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3D39510", Offset = "0x3D37F10", VA = "0x183D39510")]
		public static FHLINMEEOCC IFCDINHCNCA(string CDLFFBAPNOH, [NotNull] string DINDJMGGFGD, long DGCCNOCLJAN, long CFGHADHPDEE, string GIPGFNHGNCF, long HIKBDFIEGEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3D39A30", Offset = "0x3D38430", VA = "0x183D39A30")]
		private AmplitudeAnalyticsEvent(string CDLFFBAPNOH, [NotNull] string DINDJMGGFGD, long DGCCNOCLJAN, long CFGHADHPDEE, string GIPGFNHGNCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4C4300", Offset = "0x4C2D00", VA = "0x1804C4300")]
		public void LHHBGHCGFJF(long IENMKEABJEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3D39920", Offset = "0x3D38320", VA = "0x183D39920", Slot = "5")]
		public override void OOHEPNHKOHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3D394A0", Offset = "0x3D37EA0", VA = "0x183D394A0", Slot = "6")]
		public override void AMBMOKBBOPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3D39600", Offset = "0x3D38000", VA = "0x183D39600", Slot = "4")]
		protected override Dictionary<string, object> IPJMFILLAMP(Dictionary<string, object> OJIIBNAGNDB)
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
			[Cpp2IlInjected.Address(RVA = "0x3D3A310", Offset = "0x3D38D10", VA = "0x183D3A310")]
			public void DELADBFIBAI(Dictionary<string, object> AAJKGFDLAIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D3DB30", Offset = "0x3D3C530", VA = "0x183D3DB30")]
			public void DELADBFIBAI(Dictionary<string, object> DAONOIBGGFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1435140", Offset = "0x1433B40", VA = "0x181435140")]
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
			[Cpp2IlInjected.Address(RVA = "0x4271A0", Offset = "0x425BA0", VA = "0x1804271A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x427440", Offset = "0x425E40", VA = "0x180427440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3D39F70", Offset = "0x3D38970", VA = "0x183D39F70")]
		public static FKGHBJKHOFO KNEDIEMGNBJ(string CDLFFBAPNOH, string GIPGFNHGNCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A0F0", Offset = "0x3D38AF0", VA = "0x183D3A0F0")]
		protected AmplitudeAnalyticsIdentifyMessage(string CDLFFBAPNOH, string GIPGFNHGNCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3D39F00", Offset = "0x3D38900", VA = "0x183D39F00")]
		public Dictionary<string, object> KKMMNOPLFIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3D39CC0", Offset = "0x3D386C0", VA = "0x183D39CC0", Slot = "4")]
		protected virtual Dictionary<string, object> IPJMFILLAMP(Dictionary<string, object> OJIIBNAGNDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3D39C20", Offset = "0x3D38620", VA = "0x183D39C20")]
		protected void CJBKOMJNBLJ(string AOLPFBNJMEA, Dictionary<string, object> KBDCAIFFJBC, Dictionary<string, object> BMNOPFFNGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A010", Offset = "0x3D38A10", VA = "0x183D3A010")]
		protected void LDCCDIOMCIA(string AOLPFBNJMEA, string MDAEJMIAMDO, Dictionary<string, object> DEEKGHMCAOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A080", Offset = "0x3D38A80", VA = "0x183D3A080", Slot = "5")]
		public virtual void OOHEPNHKOHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3D39BB0", Offset = "0x3D385B0", VA = "0x183D39BB0", Slot = "6")]
		public virtual void AMBMOKBBOPJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FKGHBJKHOFO : global::MIKAAHLCCOL<AmplitudeAnalyticsIdentifyMessage, FKGHBJKHOFO>
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override FKGHBJKHOFO FIPJMNPINDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x50B960", Offset = "0x50A360", VA = "0x18050B960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4271A0", Offset = "0x425BA0", VA = "0x1804271A0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage CCEEDGHAHKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A6C0", Offset = "0x3D390C0", VA = "0x183D3A6C0")]
	public FKGHBJKHOFO(AmplitudeAnalyticsIdentifyMessage PANDMENIIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A630", Offset = "0x3D39030", VA = "0x183D3A630", Slot = "4")]
	public override void AMBMOKBBOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FHLINMEEOCC : global::MIKAAHLCCOL<AmplitudeAnalyticsEvent, FHLINMEEOCC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool CICFKKJIIAG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override FHLINMEEOCC FIPJMNPINDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x50B960", Offset = "0x50A360", VA = "0x18050B960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A2C0", Offset = "0x3D38CC0", VA = "0x183D3A2C0")]
	public FHLINMEEOCC(AmplitudeAnalyticsEvent PANDMENIIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4271A0", Offset = "0x425BA0", VA = "0x1804271A0", Slot = "5")]
	public override AmplitudeAnalyticsEvent CCEEDGHAHKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A430", Offset = "0x3D38E30", VA = "0x183D3A430", Slot = "4")]
	public override void AMBMOKBBOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2353B10", Offset = "0x2352510", VA = "0x182353B10")]
	public FHLINMEEOCC BEJPCBDKACO<T>(string PKPICABJDGM, T[] MDAEJMIAMDO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A4D0", Offset = "0x3D38ED0", VA = "0x183D3A4D0")]
	public FHLINMEEOCC BEJPCBDKACO(string PKPICABJDGM, string[] MDAEJMIAMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2353860", Offset = "0x2352260", VA = "0x182353860")]
	public FHLINMEEOCC BEJPCBDKACO<T>(string PKPICABJDGM, T MDAEJMIAMDO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A4E0", Offset = "0x3D38EE0", VA = "0x183D3A4E0")]
	public FHLINMEEOCC BEJPCBDKACO(string PKPICABJDGM, string MDAEJMIAMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A550", Offset = "0x3D38F50", VA = "0x183D3A550")]
	private FHLINMEEOCC EIHNOFONHID(string PKPICABJDGM, object MDAEJMIAMDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CLHKMLKGENC : FHLINMEEOCC
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A2C0", Offset = "0x3D38CC0", VA = "0x183D3A2C0")]
	public CLHKMLKGENC(AmplitudeAnalyticsEvent PANDMENIIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A190", Offset = "0x3D38B90", VA = "0x183D3A190", Slot = "4")]
	public override void AMBMOKBBOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class MIKAAHLCCOL<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::MIKAAHLCCOL<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	protected M PANDMENIIKF;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public abstract BLDR FIPJMNPINDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D310", Offset = "0x1F9BD10", VA = "0x181F9D310")]
	public MIKAAHLCCOL(M PANDMENIIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D1A0", Offset = "0x1F9BBA0", VA = "0x181F9D1A0")]
	public BLDR EIOAHIDDCNA(AmplitudeAnalyticsIdentifyMessage.DeviceInfo AOIIFOIBPPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D1D0", Offset = "0x1F9BBD0", VA = "0x181F9D1D0")]
	public BLDR ICOPNIKOCHJ(AmplitudeAnalyticsIdentifyMessage.RevenueData JLPNEDBEDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D130", Offset = "0x1F9BB30", VA = "0x181F9D130")]
	public BLDR CBKKKMFMGCA(string PKPICABJDGM, string MDAEJMIAMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2357F40", Offset = "0x2356940", VA = "0x182357F40")]
	public BLDR CBKKKMFMGCA<T>(string PKPICABJDGM, T MDAEJMIAMDO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void AMBMOKBBOPJ();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D200", Offset = "0x1F9BC00", VA = "0x181F9D200")]
	internal static string IDICELOJDMD(string MDAEJMIAMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D230", Offset = "0x1F9BC30", VA = "0x181F9D230")]
	private BLDR ODHIEPJPIDO(string PKPICABJDGM, object MDAEJMIAMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M CCEEDGHAHKB();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NPJPKKHIKFG
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public const int EPKNMJAOKEJ = 2;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int CGBECIBEKGC = 100;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int IAEHFBIHGPP = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const long OIOMIBONDLN = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const int MOJABLBMPLL = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int PLFNNFLCCNN = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const string AKKOJMFONKH = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string LIJMOFBDBEL = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string OCEOHCFHBIJ = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string KJFPENDCFEL = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string GLDFIFNFIEM = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string PCCKJNNFNNG = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string EOBMKOOAGCH = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string FMMEHMOBFFJ = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const int HMCKKIDFOEM = 10;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> DGKEMDCADIE;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
	public NPJPKKHIKFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface CDPHNMFBIJC
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string HOLPGBPDEJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string EGNMABHIKNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string LGKOOHJKOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::GDHDNGFJPDI<CCLNKJFAACJ> PBJHAABDJEC(string MCOCNFJCCDK, Dictionary<string, string> PPHKFCMKKCH);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct CCLNKJFAACJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly int ELMPJPODOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly string MADDEBLDCDJ;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x42F8C0", Offset = "0x42E2C0", VA = "0x18042F8C0")]
	public CCLNKJFAACJ(int OPFCKHBIDEO, string KMEOLILACHB)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IKAEKDPBOKM
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static byte[] PLMALFKJJFH;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int MNKELEMMCIP;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int JAADIHNAGCD;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static BigInteger HGHHBJPNHEH;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
	public IKAEKDPBOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D3BB00", Offset = "0x3D3A500", VA = "0x183D3BB00")]
	private static string GHHLIKAFOCC(byte[] MAKIBMGFDDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3D3BC00", Offset = "0x3D3A600", VA = "0x183D3BC00")]
	public static string NADJMKIAKML(byte[] LKPHIKGCGGC, bool BILKIJDICLE)
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
		[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
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
