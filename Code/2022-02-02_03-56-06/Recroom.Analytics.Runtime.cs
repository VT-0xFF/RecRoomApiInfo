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
		public AmplitudeAnalyticsClient.Settings KBONALEGOFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool KAHONKJPBEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4E3190", Offset = "0x4E2190", VA = "0x1804E3190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC75CE0", Offset = "0xC74CE0", VA = "0x180C75CE0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum KBIGAGJHDLG
		{
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class KCNBHKEPCBO
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class GGIJFJFJBDM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public int BEOGEEOJALJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003F")]
				public Dictionary<string, object> BODPKFHPCCK;

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
				public GGIJFJFJBDM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class BAKELMPNFAH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
				public BAKELMPNFAH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x4623740", Offset = "0x4622740", VA = "0x184623740")]
				internal bool <GetBatch>b__0(GGIJFJFJBDM item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private const string IPINANINEGP = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private readonly string ACKLKGJOPAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private List<GGIJFJFJBDM> GFDPEPDLNFD;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? HIOKODDIIBL
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x4625DC0", Offset = "0x4624DC0", VA = "0x184625DC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public int? OMLAOKPPMDO
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x4626470", Offset = "0x4625470", VA = "0x184626470")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4626870", Offset = "0x4625870", VA = "0x184626870")]
			internal KCNBHKEPCBO(string LEFLKPINGHE, string OJGCBGFDDCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4626310", Offset = "0x4625310", VA = "0x184626310")]
			public int IPKAMNNCOOI([Optional] int? FIIACPIMFCE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4626520", Offset = "0x4625520", VA = "0x184626520")]
			public List<Dictionary<string, object>> ODBNLOKIGDF(int PKOIOCBJBBN, int? FIIACPIMFCE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4626040", Offset = "0x4625040", VA = "0x184626040")]
			public void HMLKPAPJIGA(AmplitudeAnalyticsIdentifyMessage HPPOIDNICFG, bool LDKCHKNPKMA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x46260E0", Offset = "0x46250E0", VA = "0x1846260E0")]
			public void HMLKPAPJIGA(Dictionary<string, object> HPPOIDNICFG, bool LDKCHKNPKMA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4626720", Offset = "0x4625720", VA = "0x184626720")]
			public void PBIPIKIACCE(params Dictionary<string, object>[] KPLFNOMIECO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4625A90", Offset = "0x4624A90", VA = "0x184625A90")]
			public void CHBPGLDHJEP(List<Dictionary<string, object>> AEAMGAFHILF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4625CB0", Offset = "0x4624CB0", VA = "0x184625CB0")]
			private void EKBFDMGDLKA(Dictionary<string, object> HPPOIDNICFG, bool LDKCHKNPKMA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4625E50", Offset = "0x4624E50", VA = "0x184625E50")]
			public void HJFECNPCCFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x46256C0", Offset = "0x46246C0", VA = "0x1846256C0")]
			private void AKNNNAKHLHI([Optional] string IKKBANPPIGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x46261E0", Offset = "0x46251E0", VA = "0x1846261E0")]
			private static string IBGDNFJOOKD(string NBFFDDDBNPN, string GOLKIAIKMMJ)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4627190", Offset = "0x4626190", VA = "0x184627190")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct JEHNEGJKHCP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public int EBELODFBGGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public string NOGCGPPLHPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public T CKFKMHKJPLH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class HONAKFGJEED : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private MFENADOJIIE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
			[DebuggerHidden]
			public HONAKFGJEED(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4624420", Offset = "0x4623420", VA = "0x184624420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4624B50", Offset = "0x4623B50", VA = "0x184624B50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class INLIHDHEKHD : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public GMDJOGAHHIL quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
			[DebuggerHidden]
			public INLIHDHEKHD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4624E40", Offset = "0x4623E40", VA = "0x184624E40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x4624F30", Offset = "0x4623F30", VA = "0x184624F30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HNKAEBNHBME : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
			[DebuggerHidden]
			public HNKAEBNHBME(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4624260", Offset = "0x4623260", VA = "0x184624260", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x46243D0", Offset = "0x46233D0", VA = "0x1846243D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class IIBBBHLHDDD : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private MFENADOJIIE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
			[DebuggerHidden]
			public IIBBBHLHDDD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x4624BA0", Offset = "0x4623BA0", VA = "0x184624BA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4624DF0", Offset = "0x4623DF0", VA = "0x184624DF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class ADIAOJNBLHC : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private MFENADOJIIE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
			[DebuggerHidden]
			public ADIAOJNBLHC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x461E1F0", Offset = "0x461D1F0", VA = "0x18461E1F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x461E450", Offset = "0x461D450", VA = "0x18461E450", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class KMOIFFKFFMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public KCNBHKEPCBO cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
			public KMOIFFKFFMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x46269D0", Offset = "0x46259D0", VA = "0x1846269D0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4626A70", Offset = "0x4625A70", VA = "0x184626A70")]
			internal void <FlushFromCache>b__1(JEHNEGJKHCP<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JHGFCHDBLNK : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private MFENADOJIIE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public KCNBHKEPCBO cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private KMOIFFKFFMH <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
			[DebuggerHidden]
			public JHGFCHDBLNK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4624F80", Offset = "0x4623F80", VA = "0x184624F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4625670", Offset = "0x4624670", VA = "0x184625670", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class KHBOHPBPEOL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
			public KHBOHPBPEOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x31F1CE0", Offset = "0x31F0CE0", VA = "0x1831F1CE0")]
			internal JEHNEGJKHCP<T> <PostRudderStackJson>b__0(LKDPFODGAMK postResponse)
			{
				return default(JEHNEGJKHCP<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class BFHGNMPIGKA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
			public BFHGNMPIGKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x31F1CE0", Offset = "0x31F0CE0", VA = "0x1831F1CE0")]
			internal JEHNEGJKHCP<T> <PostAmplitudeJson>b__0(LKDPFODGAMK postResponse)
			{
				return default(JEHNEGJKHCP<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private JNDHNDEAGOB CAPIFFDLKCN;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string KKLCMKPOHME = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string EEOMNDMIAII = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string AIPCGCBHBDG = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string OHGAGICCBLK = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string KGCBLPMFGBK = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int JEAOJPEFJCC = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int FLDPGICLFGL = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int IEBFKLGPGPL = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float KDGDLNCIOBA = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long OMKLENJCIDG = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string CKNKCKICFEL = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const string FPILPPEHCAC = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool AGGFOOLIOLD;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static bool BCOBKPOGKEM;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int HOILIFGLEKO;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static int DJPJBBMECCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private AKOFMHLFKFM IJOHHKLMJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private bool JIKAKOGNAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float FOMFLHKMGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private float KHHLHNOPPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int GAAAANBODOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int MEOHJOMHAGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? EFENDPHJLCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private int? LAGGBOADMKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private long LMGHHPHPGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private string BMKNJEBEHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private long MPFPOOEMPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<string, object> MBGOCAIAJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private KBIGAGJHDLG AMPGDELHCPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int ONKLFMHDBIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int JKOEJMAPHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private float AKJPEJAKAAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool PLJBCEOKLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool AJBNKJNNIEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private KCNBHKEPCBO AAPFFCNJPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private KCNBHKEPCBO JEFHJDIBILB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private KCNBHKEPCBO AGFNFAHKAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> DDHGOHEHKPK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo LKIIHJEPBGM;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static string EPNFOFODFAD;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string NJEOCEDGOKE = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly string JNGPJJBCFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly string DICCEGCAPCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly string JNOMBJGMOPC;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string BOJJKENBCGG = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string IBLGNKIALJN = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private JNDHNDEAGOB JEOKIDIDOIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x46209A0", Offset = "0x461F9A0", VA = "0x1846209A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int EDHJIBJDMKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x461EC50", Offset = "0x461DC50", VA = "0x18461EC50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long KHELIMCOJED
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x46228A0", Offset = "0x46218A0", VA = "0x1846228A0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x46229A0", Offset = "0x46219A0", VA = "0x1846229A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string NHDDEPHMBBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x4622840", Offset = "0x4621840", VA = "0x184622840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string FKEJNJHCINN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4622870", Offset = "0x4621870", VA = "0x184622870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string BINPMHHECLM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x507700", Offset = "0x506700", VA = "0x180507700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4F5260", Offset = "0x4F4260", VA = "0x1804F5260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool EKLKPHPOMMI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5C1CA0", Offset = "0x5C0CA0", VA = "0x1805C1CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xEC8D80", Offset = "0xEC7D80", VA = "0x180EC8D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static bool FBGCNKBEKBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x4622760", Offset = "0x4621760", VA = "0x184622760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> JNHEAFLLMGI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x46226C0", Offset = "0x46216C0", VA = "0x1846226C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4622900", Offset = "0x4621900", VA = "0x184622900")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x461E7C0", Offset = "0x461D7C0", VA = "0x18461E7C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x46220E0", Offset = "0x46210E0", VA = "0x1846220E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4621790", Offset = "0x4620790", VA = "0x184621790", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4622260", Offset = "0x4621260", VA = "0x184622260")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x46218C0", Offset = "0x46208C0", VA = "0x1846218C0")]
		public BKMNEANDFIL PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x461FEB0", Offset = "0x461EEB0", VA = "0x18461FEB0")]
		[IteratorStateMachine(typeof(HONAKFGJEED))]
		public IEnumerator<MFENADOJIIE> Initialize(AmplitudeAnalyticsEvent HEHCINHDEOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x46221B0", Offset = "0x46211B0", VA = "0x1846221B0")]
		public void UpdateLastAliveTime(float IKOCDDLDBGA = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x461E4A0", Offset = "0x461D4A0", VA = "0x18461E4A0")]
		private BKMNEANDFIL ACJBKALLJHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x461F2C0", Offset = "0x461E2C0", VA = "0x18461F2C0")]
		private BKMNEANDFIL EADJNICBHOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4621D70", Offset = "0x4620D70", VA = "0x184621D70")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4621830", Offset = "0x4620830", VA = "0x184621830")]
		[IteratorStateMachine(typeof(INLIHDHEKHD))]
		private IEnumerator PLCKEAJLLGL(GMDJOGAHHIL LKCKMJLJNNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x46224C0", Offset = "0x46214C0", VA = "0x1846224C0")]
		[IteratorStateMachine(typeof(HNKAEBNHBME))]
		public IEnumerator WaitForFlush(float GKIOCKNNKGM = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x46220F0", Offset = "0x46210F0", VA = "0x1846220F0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x461FBB0", Offset = "0x461EBB0", VA = "0x18461FBB0")]
		public static BMFAIDLAMIC Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x461E680", Offset = "0x461D680", VA = "0x18461E680")]
		public static OCOAIPLPMLI AccountSelectionPostLoginEvent([NotNull] string KNDKGMDLMKO, string BGBKENHFAMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x461F4F0", Offset = "0x461E4F0", VA = "0x18461F4F0")]
		public static OCOAIPLPMLI Event([NotNull] string KNDKGMDLMKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4621940", Offset = "0x4620940", VA = "0x184621940")]
		public static OCOAIPLPMLI PreviousSessionEvent([NotNull] string KNDKGMDLMKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x461FCF0", Offset = "0x461ECF0", VA = "0x18461FCF0")]
		public static OCOAIPLPMLI InitializeEvent(string BGBKENHFAMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4621E80", Offset = "0x4620E80", VA = "0x184621E80")]
		public static OCOAIPLPMLI StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x461EE70", Offset = "0x461DE70", VA = "0x18461EE70")]
		public static OCOAIPLPMLI CreateOutOfSessionEvent(string KNDKGMDLMKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4620550", Offset = "0x461F550", VA = "0x184620550")]
		public static BKMNEANDFIL LogOutOfSessionEvent(OCOAIPLPMLI OPBILLOMNLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x46203A0", Offset = "0x461F3A0", VA = "0x1846203A0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LDDAJMKMLON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4620800", Offset = "0x461F800", VA = "0x184620800")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LDDAJMKMLON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x46208D0", Offset = "0x461F8D0", VA = "0x1846208D0")]
		public void LogSerializedEventAsync(Dictionary<string, object> FHENOHKDLFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4620470", Offset = "0x461F470", VA = "0x184620470")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage LDEEEDFIGFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4620C60", Offset = "0x461FC60", VA = "0x184620C60")]
		private void OAJLMBCMKFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4620090", Offset = "0x461F090", VA = "0x184620090")]
		private void LGCGJPINKHO(Dictionary<string, object> PHJHELNLMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x461FAC0", Offset = "0x461EAC0", VA = "0x18461FAC0")]
		private void HDCBNMOIMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x461F130", Offset = "0x461E130", VA = "0x18461F130")]
		private void DPGJKIJFNLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x461F6D0", Offset = "0x461E6D0", VA = "0x18461F6D0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x461F650", Offset = "0x461E650", VA = "0x18461F650")]
		[IteratorStateMachine(typeof(IIBBBHLHDDD))]
		private IEnumerator<MFENADOJIIE> FBNCMMNLHHM(float GKIOCKNNKGM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4620A80", Offset = "0x461FA80", VA = "0x184620A80")]
		[IteratorStateMachine(typeof(ADIAOJNBLHC))]
		private IEnumerator<MFENADOJIIE> NAJONJHMAJO(float GKIOCKNNKGM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x46202C0", Offset = "0x461F2C0", VA = "0x1846202C0")]
		[IteratorStateMachine(typeof(JHGFCHDBLNK))]
		private IEnumerator<MFENADOJIIE> LNPMOGNNJAE(KCNBHKEPCBO MPGDAHEICII, int? FIIACPIMFCE, string MAPMBBLKJCH, string DFILCCALMNF, float GKIOCKNNKGM, Action<int> HDKFDFBMJHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x461FFA0", Offset = "0x461EFA0", VA = "0x18461FFA0")]
		private static void LALFDBNBFAO(bool BAFGKEIANEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x461F760", Offset = "0x461E760", VA = "0x18461F760")]
		private global::IDCJFNACHEM<JEHNEGJKHCP<Dictionary<string, object>>> GOBDBMOMNMM(string MAPMBBLKJCH, string DFILCCALMNF, string JIJEBMPAEMF, string MMEILOLIKLE, Dictionary<string, object> CKFKMHKJPLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x461F860", Offset = "0x461E860", VA = "0x18461F860")]
		private global::IDCJFNACHEM<JEHNEGJKHCP<List<Dictionary<string, object>>>> GOBDBMOMNMM(string MAPMBBLKJCH, string DFILCCALMNF, string JIJEBMPAEMF, string MMEILOLIKLE, List<Dictionary<string, object>> CKFKMHKJPLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2710C90", Offset = "0x270FC90", VA = "0x182710C90")]
		private global::IDCJFNACHEM<JEHNEGJKHCP<T>> JMGKEOEOHAH<T>(string MAPMBBLKJCH, string DFILCCALMNF, string MMEILOLIKLE, T CKFKMHKJPLH, Dictionary<string, object> DAMHODCNJNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2710EF0", Offset = "0x270FEF0", VA = "0x182710EF0")]
		private global::IDCJFNACHEM<JEHNEGJKHCP<T>> LDDCKNBMAPM<T>(string MAPMBBLKJCH, string DFILCCALMNF, string JIJEBMPAEMF, T CKFKMHKJPLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x461FF50", Offset = "0x461EF50", VA = "0x18461FF50")]
		private bool LABDDHGHGDK(float FFDCFEIKCKI, float GKIOCKNNKGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4620D10", Offset = "0x461FD10", VA = "0x184620D10")]
		private Dictionary<string, object> ODNKIGNBJFN(string DFILCCALMNF, Dictionary<string, object> CKFKMHKJPLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x46225A0", Offset = "0x46215A0", VA = "0x1846225A0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4620B00", Offset = "0x461FB00", VA = "0x184620B00")]
		[CompilerGenerated]
		private long NFIGBEFMEAJ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x461FF40", Offset = "0x461EF40", VA = "0x18461FF40")]
		[CompilerGenerated]
		private void KGMBBKLKLCO(int OFPHKHGHKIP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4E9620", Offset = "0x4E8620", VA = "0x1804E9620")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4622EB0", Offset = "0x4621EB0", VA = "0x184622EB0")]
		public static OCOAIPLPMLI OHLBCBNLJLB(string GDDDELIOHBI, [NotNull] string JDKKKDEGIGM, long IPLFFIPGGKH, long BLNCMHDNEKL, string BGBKENHFAMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4622A00", Offset = "0x4621A00", VA = "0x184622A00")]
		public static OCOAIPLPMLI GMIGOOJJDBL(string GDDDELIOHBI, [NotNull] string JDKKKDEGIGM, long IPLFFIPGGKH, long BLNCMHDNEKL, string BGBKENHFAMK, long AIFGHBEMOJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4622F90", Offset = "0x4621F90", VA = "0x184622F90")]
		private AmplitudeAnalyticsEvent(string GDDDELIOHBI, [NotNull] string JDKKKDEGIGM, long IPLFFIPGGKH, long BLNCMHDNEKL, string BGBKENHFAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7E7D00", Offset = "0x7E6D00", VA = "0x1807E7D00")]
		public void NEHKFOBBDCF(long HBECICEPOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4622AF0", Offset = "0x4621AF0", VA = "0x184622AF0", Slot = "5")]
		public override void JKBHKEPJGCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4622C00", Offset = "0x4621C00", VA = "0x184622C00", Slot = "6")]
		public override void KDGMLIDNCAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4622C70", Offset = "0x4621C70", VA = "0x184622C70", Slot = "4")]
		protected override Dictionary<string, object> KGDBIMLKOIO(Dictionary<string, object> ELHOIIPNGDH)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4624140", Offset = "0x4623140", VA = "0x184624140")]
			public void HLKCEKCFCLN(Dictionary<string, object> ENHICGBOJCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4627070", Offset = "0x4626070", VA = "0x184627070")]
			public void HLKCEKCFCLN(Dictionary<string, object> HOBDMMBFEBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x161B270", Offset = "0x161A270", VA = "0x18161B270")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x4E3490", Offset = "0x4E2490", VA = "0x1804E3490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4623570", Offset = "0x4622570", VA = "0x184623570")]
		public static BMFAIDLAMIC OHLBCBNLJLB(string GDDDELIOHBI, string BGBKENHFAMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4623680", Offset = "0x4622680", VA = "0x184623680")]
		protected AmplitudeAnalyticsIdentifyMessage(string GDDDELIOHBI, string BGBKENHFAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4623610", Offset = "0x4622610", VA = "0x184623610")]
		public Dictionary<string, object> PDAONNAGGFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x46232C0", Offset = "0x46222C0", VA = "0x1846232C0", Slot = "4")]
		protected virtual Dictionary<string, object> KGDBIMLKOIO(Dictionary<string, object> ELHOIIPNGDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4623130", Offset = "0x4622130", VA = "0x184623130")]
		protected void CHCNPJAAMAA(string GOLKIAIKMMJ, Dictionary<string, object> NPNJEOACDMO, Dictionary<string, object> BFMGBJOGKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4623500", Offset = "0x4622500", VA = "0x184623500")]
		protected void NMJJDAEFACL(string GOLKIAIKMMJ, string NBFFDDDBNPN, Dictionary<string, object> AIKLAALBEGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x46231D0", Offset = "0x46221D0", VA = "0x1846231D0", Slot = "5")]
		public virtual void JKBHKEPJGCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4623250", Offset = "0x4622250", VA = "0x184623250", Slot = "6")]
		public virtual void KDGMLIDNCAD()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BMFAIDLAMIC : global::LPMKOIPIEPK<AmplitudeAnalyticsIdentifyMessage, BMFAIDLAMIC>
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override BMFAIDLAMIC JCHNNIKFOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x578B30", Offset = "0x577B30", VA = "0x180578B30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage BDJCGCFLIOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4623830", Offset = "0x4622830", VA = "0x184623830")]
	public BMFAIDLAMIC(AmplitudeAnalyticsIdentifyMessage LOJFCHHAAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x46237A0", Offset = "0x46227A0", VA = "0x1846237A0", Slot = "4")]
	public override void KDGMLIDNCAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OCOAIPLPMLI : global::LPMKOIPIEPK<AmplitudeAnalyticsEvent, OCOAIPLPMLI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool HEKJLFAKDNL;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public override OCOAIPLPMLI JCHNNIKFOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x578B30", Offset = "0x577B30", VA = "0x180578B30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x46239B0", Offset = "0x46229B0", VA = "0x1846239B0")]
	public OCOAIPLPMLI(AmplitudeAnalyticsEvent LOJFCHHAAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0", Slot = "5")]
	public override AmplitudeAnalyticsEvent BDJCGCFLIOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4626F50", Offset = "0x4625F50", VA = "0x184626F50", Slot = "4")]
	public override void KDGMLIDNCAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2936390", Offset = "0x2935390", VA = "0x182936390")]
	public OCOAIPLPMLI NFLOMDGCAGI<T>(string CKKDJEODKDP, T[] NBFFDDDBNPN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4626FF0", Offset = "0x4625FF0", VA = "0x184626FF0")]
	public OCOAIPLPMLI NFLOMDGCAGI(string CKKDJEODKDP, string[] NBFFDDDBNPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2936320", Offset = "0x2935320", VA = "0x182936320")]
	public OCOAIPLPMLI NFLOMDGCAGI<T>(string CKKDJEODKDP, T NBFFDDDBNPN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4627000", Offset = "0x4626000", VA = "0x184627000")]
	public OCOAIPLPMLI NFLOMDGCAGI(string CKKDJEODKDP, string NBFFDDDBNPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4626E70", Offset = "0x4625E70", VA = "0x184626E70")]
	private OCOAIPLPMLI EPAEIMOLOAH(string CKKDJEODKDP, object NBFFDDDBNPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BPDGIKFOLEB : OCOAIPLPMLI
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x46239B0", Offset = "0x46229B0", VA = "0x1846239B0")]
	public BPDGIKFOLEB(AmplitudeAnalyticsEvent LOJFCHHAAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4623880", Offset = "0x4622880", VA = "0x184623880", Slot = "4")]
	public override void KDGMLIDNCAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class LPMKOIPIEPK<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::LPMKOIPIEPK<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	protected M LOJFCHHAAAF;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public abstract BLDR JCHNNIKFOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1BE0F90", Offset = "0x1BDFF90", VA = "0x181BE0F90")]
	public LPMKOIPIEPK(M LOJFCHHAAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC0F0", Offset = "0x1EAB0F0", VA = "0x181EAC0F0")]
	public BLDR JIJCJCGDMBH(AmplitudeAnalyticsIdentifyMessage.DeviceInfo NCINHKLAODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC0B0", Offset = "0x1EAB0B0", VA = "0x181EAC0B0")]
	public BLDR GJPDANKDGGK(AmplitudeAnalyticsIdentifyMessage.RevenueData JKNJELIMNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC040", Offset = "0x1EAB040", VA = "0x181EAC040")]
	public BLDR EALDCEOMHJJ(string CKKDJEODKDP, string NBFFDDDBNPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x271F530", Offset = "0x271E530", VA = "0x18271F530")]
	public BLDR EALDCEOMHJJ<T>(string CKKDJEODKDP, T NBFFDDDBNPN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KDGMLIDNCAD();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC130", Offset = "0x1EAB130", VA = "0x181EAC130")]
	internal static string LOENEGHFEHG(string NBFFDDDBNPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC160", Offset = "0x1EAB160", VA = "0x181EAC160")]
	private BLDR OFDABPPILLG(string CKKDJEODKDP, object NBFFDDDBNPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M BDJCGCFLIOJ();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DEMJOBIPNAP
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string DJKNENGLGIB = "batch";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string OAEFBKHOGKO = "type";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string JFJAJILAGPC = "identify";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string GKNOABKANKD = "track";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string OBOFPELCOGG = "userId";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string KJGDHAGJBPB = "event";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string NPBMPBDPMAK = "version";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const string FICFJNLHOAA = "locale";

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public const string LELGJFFAGFO = "name";

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public const string OHKAEOCHGNM = "properties";

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public const string MALAGNGAKDI = "traits";

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public const string NKOBEBFEJKN = "context";

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public const string INKJKPEBKIE = "app";

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public const string EMJGFFJCPCA = "os";

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public const string INCIGGGOAJC = "device";

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public const string MFOKKFBMCOM = "timestamp";

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public const string CGNFFKOCHBJ = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public const string KGGKGBJACGK = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public const string LJBBHLKCPGN = "model";

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public const string IJHABPEHJDG = "type";

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	public DEMJOBIPNAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DLAGEIABELN
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public const int AMCOHNFGNPJ = 2;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public const int CEOFIOJGIBG = 100;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public const int LPBDLOJOHFE = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public const long PNIGCKCOBPP = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public const int KCBBIMCCCIO = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public const int ENOEDCPECFI = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public const string JHKONAIIFLH = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public const string NFMNDLPGCMH = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public const string OPCCJMDEHPD = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const string MGOLHCDEMKG = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public const string IAPDCKPBFHG = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public const string OJBEAAKHGIJ = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const string KBJLKKPCCAM = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const string KAEDCHIGLPG = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public const string ANNIIOGDBNH = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public const string CMOCLLJHCMH = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public const string LAPPNKLCHIK = "language";

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public const string OCKIHHCOBOB = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public const string IGGNKCFGBMD = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const string MOFELADGHDL = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public const string HBIJGIOODHA = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const string HPLFMCBPECK = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const string OFDAELNOFLB = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public const string EIEFDNCOFEM = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public const string BJHDHGNDOJJ = "price";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const string JANNAOLBGCD = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public const string BOOFKANKOGC = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public const string KPDDIOIMGAO = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public const string APONHGCNIDG = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public const string GEIDOBGLGMA = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public const string OBOFPELCOGG = "user_id";

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public const string AJCFMOOLKGK = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int CFDKCODMGPL = 10;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> PDLOKJAPGPI;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4623FF0", Offset = "0x4622FF0", VA = "0x184623FF0")]
	internal static bool JJGLIFICGNN(string GOLKIAIKMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	public DLAGEIABELN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface AKOFMHLFKFM
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool HPLPFGHBMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string EOLBOMAANCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string BIDDDDPFOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string LLDGCONMIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string BHNNGKEKDGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::IDCJFNACHEM<LKDPFODGAMK> GOBDBMOMNMM(string MAPMBBLKJCH, Dictionary<string, string> HEAAAFDOMBP);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::IDCJFNACHEM<LKDPFODGAMK> IHGCGJHGKCD(string MAPMBBLKJCH, string CHALLLHLHMF, string IIBNHGENANO, string JMPNEFMCFNC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct LKDPFODGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly int NIDNBKOCLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly string IILOIGNGGAE;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4EBCF0", Offset = "0x4EACF0", VA = "0x1804EBCF0")]
	public LKDPFODGAMK(int EBELODFBGGB, string NOGCGPPLHPN)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DFIKEAFJCGD
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static byte[] FPMGPNDCJGI;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static int HLAPLPHEDOF;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static int DIHDAAMIHIE;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static BigInteger CBFIPIFMBJA;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	public DFIKEAFJCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4623A00", Offset = "0x4622A00", VA = "0x184623A00")]
	private static string FCGBJJFHIPJ(byte[] DJHKGFLFIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4623B00", Offset = "0x4622B00", VA = "0x184623B00")]
	public static string JDIAMALCPMN(byte[] ONAFAFJGCAI, bool NMLDFLAABOD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
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
