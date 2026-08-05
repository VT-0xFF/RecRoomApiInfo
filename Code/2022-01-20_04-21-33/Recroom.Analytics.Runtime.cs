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
		public AmplitudeAnalyticsClient.Settings LBKPCDNIGPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool AFPPLNHGBPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4E1B30", Offset = "0x4E0330", VA = "0x1804E1B30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5083B0", Offset = "0x506BB0", VA = "0x1805083B0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum IAGDABBJBJO
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class GAAMJMOCJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class LEAIPMFBKLL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public int NBPADNNHKBL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public Dictionary<string, object> HBDKGLHNFGO;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
				public LEAIPMFBKLL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class MCKEMOFDCMD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
				public MCKEMOFDCMD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x43FADB0", Offset = "0x43F95B0", VA = "0x1843FADB0")]
				internal bool <GetBatch>b__0(LEAIPMFBKLL item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private const string GABLCPJCCMJ = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string DHFDDJIBOIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<LEAIPMFBKLL> OEGELBDPGJE;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? OHJBONKMGAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x43F8610", Offset = "0x43F6E10", VA = "0x1843F8610")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? EDBMIGOMBGD
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x43F8560", Offset = "0x43F6D60", VA = "0x1843F8560")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x43F94A0", Offset = "0x43F7CA0", VA = "0x1843F94A0")]
			internal GAAMJMOCJDJ(string DODIGOAJOLA, string LKHBOGGELMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x43F9340", Offset = "0x43F7B40", VA = "0x1843F9340")]
			public int OKDOOGHLOGG([Optional] int? BAJPENIMKMA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x43F89C0", Offset = "0x43F71C0", VA = "0x1843F89C0")]
			public List<Dictionary<string, object>> LEGOMGLDEFH(int POOBNPNJAEP, int? BAJPENIMKMA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x43F8DE0", Offset = "0x43F75E0", VA = "0x1843F8DE0")]
			public void LHHCEFKJPDL(AmplitudeAnalyticsIdentifyMessage ANEGDOBGOJI, bool GGLHKMBENAP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x43F8E80", Offset = "0x43F7680", VA = "0x1843F8E80")]
			public void LHHCEFKJPDL(Dictionary<string, object> ANEGDOBGOJI, bool GGLHKMBENAP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x43F86A0", Offset = "0x43F6EA0", VA = "0x1843F86A0")]
			public void JJCAKBLMIBP(params Dictionary<string, object>[] FPIPNCKNFPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x43F8BC0", Offset = "0x43F73C0", VA = "0x1843F8BC0")]
			public void LHGEHJEEPME(List<Dictionary<string, object>> OALIALIBHHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x43F8320", Offset = "0x43F6B20", VA = "0x1843F8320")]
			private void DEIJNIHEDBP(Dictionary<string, object> ANEGDOBGOJI, bool GGLHKMBENAP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x43F87D0", Offset = "0x43F6FD0", VA = "0x1843F87D0")]
			public void KGKPMBDEKLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x43F8F70", Offset = "0x43F7770", VA = "0x1843F8F70")]
			private void NNNNNIIGKDJ([Optional] string FCJOJLEJAMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x43F8430", Offset = "0x43F6C30", VA = "0x1843F8430")]
			private static string FCOHJNPAIJF(string IJBLIGDNDKF, string PONAFPGHKNA)
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
			[Cpp2IlInjected.Address(RVA = "0x43FB770", Offset = "0x43F9F70", VA = "0x1843FB770")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct GHCMBMFCDLN<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int HHPIEIKBJDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public string EMKENGPPKMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T GCMCCKICJJN;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class KHPKCHNPAAK : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private OPGJILMPEBL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
			[DebuggerHidden]
			public KHPKCHNPAAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x43F9D20", Offset = "0x43F8520", VA = "0x1843F9D20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x43FA440", Offset = "0x43F8C40", VA = "0x1843FA440", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class OPMGHJJLFCF : IEnumerator<object>, IEnumerator, IDisposable
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
			public PFHHFCMCGEB quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
			[DebuggerHidden]
			public OPMGHJJLFCF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x43FB520", Offset = "0x43F9D20", VA = "0x1843FB520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x43FB600", Offset = "0x43F9E00", VA = "0x1843FB600", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class BMMDNHPKBJH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
			[DebuggerHidden]
			public BMMDNHPKBJH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x43F7CA0", Offset = "0x43F64A0", VA = "0x1843F7CA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x43F7DE0", Offset = "0x43F65E0", VA = "0x1843F7DE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LJLPGMNGINI : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private OPGJILMPEBL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
			[DebuggerHidden]
			public LJLPGMNGINI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x43FA490", Offset = "0x43F8C90", VA = "0x1843FA490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x43FA6D0", Offset = "0x43F8ED0", VA = "0x1843FA6D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class GJFMDBOCDJI : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private OPGJILMPEBL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
			[DebuggerHidden]
			public GJFMDBOCDJI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x43F95F0", Offset = "0x43F7DF0", VA = "0x1843F95F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x43F9830", Offset = "0x43F8030", VA = "0x1843F9830", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class IGGDIDPBBPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public GAAMJMOCJDJ cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
			public IGGDIDPBBPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x43F9880", Offset = "0x43F8080", VA = "0x1843F9880")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x43F9920", Offset = "0x43F8120", VA = "0x1843F9920")]
			internal void <FlushFromCache>b__1(GHCMBMFCDLN<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class LPFECBLEGPF : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private OPGJILMPEBL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public GAAMJMOCJDJ cache;

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
			private IGGDIDPBBPI <>8__1;

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
			private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
			[DebuggerHidden]
			public LPFECBLEGPF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x43FA720", Offset = "0x43F8F20", VA = "0x1843FA720", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x43FAD60", Offset = "0x43F9560", VA = "0x1843FAD60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class CMFILNFBMDD<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xFEFFE0", Offset = "0xFEE7E0", VA = "0x180FEFFE0")]
			public CMFILNFBMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x28E1DC0", Offset = "0x28E05C0", VA = "0x1828E1DC0")]
			internal GHCMBMFCDLN<T> <PostJson>b__0(LGMKKIBAHBN postResponse)
			{
				return default(GHCMBMFCDLN<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private EHBMAEAKKLB NBAJIPBFEME;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string FOCPPFKIIMK = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string LCBMOPMODFL = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string LOFAGJDACOH = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string OEDOAFFBEBI = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string HCMEPFDAKLI = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int OCBCNLIHJJN = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int DKKNJIIDHOE = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int OEMGGHMGNHK = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float KBKJEFHHKBC = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long LFMMMFBDJMH = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string BJNAIFAIDNF = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static bool KCMFMAOGIKB;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool JPLJFCFPMGF;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static int LADOCHEEAIC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int FBGNMNGDLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private NPLGADJFGAG IHMDJFHDALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool IJOIPJBNAID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float BCEFHGCGCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float LBCJEDGIJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int LLKKAECEBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int PANJIGABGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int? JLBGMKPLKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? KEJNMBMDKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private long MPAIPGJDEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string GONPPMNHICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long AEKENMOOHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, object> BNDDGODBAIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private IAGDABBJBJO CBMCDALCMED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int KOEFBMDOPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int BGHDIHDIDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float INDOPDHBGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool MEMAGNCHBHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool GOBIHIJJKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private GAAMJMOCJDJ JGNFCCKMBOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GAAMJMOCJDJ KIONCDINOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GAAMJMOCJDJ PCNLJKEALIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> MBDJBABHNLO;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo KOMODFBFKFC;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static string INPJHBGJHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string MBMMNCBBHJM = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string CBGDIHEAODJ = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private EHBMAEAKKLB KHDHBBOGHHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x43F5C60", Offset = "0x43F4460", VA = "0x1843F5C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int LGAFPCKOOLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x43F5A40", Offset = "0x43F4240", VA = "0x1843F5A40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long HBOHJHFKDBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x43F6E50", Offset = "0x43F5650", VA = "0x1843F6E50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x43F6F50", Offset = "0x43F5750", VA = "0x1843F6F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string EAKOHFEDJAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x43F6E20", Offset = "0x43F5620", VA = "0x1843F6E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string GAFOPJPNOJE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x508CE0", Offset = "0x5074E0", VA = "0x180508CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5086A0", Offset = "0x506EA0", VA = "0x1805086A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DNNGIDPMOMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6C99F0", Offset = "0x6C81F0", VA = "0x1806C99F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6C9130", Offset = "0x6C7930", VA = "0x1806C9130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool EMLKGMCAMJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x43F6D40", Offset = "0x43F5540", VA = "0x1843F6D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> JGMPMKMPKFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x43F6CA0", Offset = "0x43F54A0", VA = "0x1843F6CA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x43F6EB0", Offset = "0x43F56B0", VA = "0x1843F6EB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x43F3CF0", Offset = "0x43F24F0", VA = "0x1843F3CF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x43F6730", Offset = "0x43F4F30", VA = "0x1843F6730")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x43F5E90", Offset = "0x43F4690", VA = "0x1843F5E90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x43F68B0", Offset = "0x43F50B0", VA = "0x1843F68B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x43F5F10", Offset = "0x43F4710", VA = "0x1843F5F10")]
		public JFNFLBIAFDM PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x43F51A0", Offset = "0x43F39A0", VA = "0x1843F51A0")]
		[IteratorStateMachine(typeof(KHPKCHNPAAK))]
		public IEnumerator<OPGJILMPEBL> Initialize(AmplitudeAnalyticsEvent HIGKGLMMDGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x43F6800", Offset = "0x43F5000", VA = "0x1843F6800")]
		public void UpdateLastAliveTime(float AIEMIFJOLKC = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x43F4150", Offset = "0x43F2950", VA = "0x1843F4150")]
		private JFNFLBIAFDM BMIOKNEENJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x43F4950", Offset = "0x43F3150", VA = "0x1843F4950")]
		private JFNFLBIAFDM FAJCMEINPJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x43F63C0", Offset = "0x43F4BC0", VA = "0x1843F63C0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x43F4C00", Offset = "0x43F3400", VA = "0x1843F4C00")]
		[IteratorStateMachine(typeof(OPMGHJJLFCF))]
		private IEnumerator GALPNMKDGNB(PFHHFCMCGEB IKEEMCNFANI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x43F6B10", Offset = "0x43F5310", VA = "0x1843F6B10")]
		[IteratorStateMachine(typeof(BMMDNHPKBJH))]
		public IEnumerator WaitForFlush(float PFLJKPKAOKJ = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x43F6740", Offset = "0x43F4F40", VA = "0x1843F6740")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x43F4EB0", Offset = "0x43F36B0", VA = "0x1843F4EB0")]
		public static EFMIGFLPKPF Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x43F3BB0", Offset = "0x43F23B0", VA = "0x1843F3BB0")]
		public static CGFIFAMOIOF AccountSelectionPostLoginEvent([NotNull] string HNJODOODCPI, string OFPCNJNBIGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x43F47F0", Offset = "0x43F2FF0", VA = "0x1843F47F0")]
		public static CGFIFAMOIOF Event([NotNull] string HNJODOODCPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x43F5F90", Offset = "0x43F4790", VA = "0x1843F5F90")]
		public static CGFIFAMOIOF PreviousSessionEvent([NotNull] string HNJODOODCPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x43F4FF0", Offset = "0x43F37F0", VA = "0x1843F4FF0")]
		public static CGFIFAMOIOF InitializeEvent(string OFPCNJNBIGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x43F64D0", Offset = "0x43F4CD0", VA = "0x1843F64D0")]
		public static CGFIFAMOIOF StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x43F44D0", Offset = "0x43F2CD0", VA = "0x1843F44D0")]
		public static CGFIFAMOIOF CreateOutOfSessionEvent(string HNJODOODCPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x43F56D0", Offset = "0x43F3ED0", VA = "0x1843F56D0")]
		public static JFNFLBIAFDM LogOutOfSessionEvent(CGFIFAMOIOF GJOCJAHGMBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x43F5520", Offset = "0x43F3D20", VA = "0x1843F5520")]
		public void LogEventAsync(AmplitudeAnalyticsEvent MPNLGCIHOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x43F58A0", Offset = "0x43F40A0", VA = "0x1843F58A0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent MPNLGCIHOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x43F5970", Offset = "0x43F4170", VA = "0x1843F5970")]
		public void LogSerializedEventAsync(Dictionary<string, object> KDILPIGEEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x43F55F0", Offset = "0x43F3DF0", VA = "0x1843F55F0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage IMHOIABBDJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x43F5210", Offset = "0x43F3A10", VA = "0x1843F5210")]
		private void JNDDLPMMDLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x43F5300", Offset = "0x43F3B00", VA = "0x1843F5300")]
		private void KMJEEKFGCKJ(Dictionary<string, object> MGGHKDONOAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x43F4DD0", Offset = "0x43F35D0", VA = "0x1843F4DD0")]
		private void HNELCIHFEMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x43F4330", Offset = "0x43F2B30", VA = "0x1843F4330")]
		private void BNFLGHCPMLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x43F4B70", Offset = "0x43F3370", VA = "0x1843F4B70")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x43F4D60", Offset = "0x43F3560", VA = "0x1843F4D60")]
		[IteratorStateMachine(typeof(LJLPGMNGINI))]
		private IEnumerator<OPGJILMPEBL> HHEFECDCIKP(float PFLJKPKAOKJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x43F4780", Offset = "0x43F2F80", VA = "0x1843F4780")]
		[IteratorStateMachine(typeof(GJFMDBOCDJI))]
		private IEnumerator<OPGJILMPEBL> DBIFHPBKLMM(float PFLJKPKAOKJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x43F3B00", Offset = "0x43F2300", VA = "0x1843F3B00")]
		[IteratorStateMachine(typeof(LPFECBLEGPF))]
		private IEnumerator<OPGJILMPEBL> AFGFILIHAIJ(GAAMJMOCJDJ BPDBEEIMJON, int? BAJPENIMKMA, string DPOCEHLLOCK, string HPFICFEOJIN, float PFLJKPKAOKJ, Action<int> BCPJIFNBCIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x43F4C70", Offset = "0x43F3470", VA = "0x1843F4C70")]
		private static void GNBCDLALGPC(bool MHOFHNKMKHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x18BD680", Offset = "0x18BBE80", VA = "0x1818BD680")]
		private global::GHMNNNIJAKN<GHCMBMFCDLN<T>> LLGENCHBLFO<T>(string DPOCEHLLOCK, string HPFICFEOJIN, string PGBIHIJAMAL, T GCMCCKICJJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x43F52B0", Offset = "0x43F3AB0", VA = "0x1843F52B0")]
		private bool KIHDGJGMLFK(float BEDLAKBLIGC, float PFLJKPKAOKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x43F6BE0", Offset = "0x43F53E0", VA = "0x1843F6BE0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x43F5D30", Offset = "0x43F4530", VA = "0x1843F5D30")]
		[CompilerGenerated]
		private long NIAGKBGCEPI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x43F44C0", Offset = "0x43F2CC0", VA = "0x1843F44C0")]
		[CompilerGenerated]
		private void CPAJOBNCCLB(int IIHGHHMKHEK)
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
			[Cpp2IlInjected.Address(RVA = "0x4E59D0", Offset = "0x4E41D0", VA = "0x1804E59D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x43F73F0", Offset = "0x43F5BF0", VA = "0x1843F73F0")]
		public static CGFIFAMOIOF MJCPAEDCHAE(string LLLILKCIOIH, [NotNull] string ABBMHAHHFBF, long MJGOHHJHHDM, long CEKJCFFEKJC, string OFPCNJNBIGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x43F7300", Offset = "0x43F5B00", VA = "0x1843F7300")]
		public static CGFIFAMOIOF KOINMJIJNFH(string LLLILKCIOIH, [NotNull] string ABBMHAHHFBF, long MJGOHHJHHDM, long CEKJCFFEKJC, string OFPCNJNBIGM, long IKDGDMDHJAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x43F7540", Offset = "0x43F5D40", VA = "0x1843F7540")]
		private AmplitudeAnalyticsEvent(string LLLILKCIOIH, [NotNull] string ABBMHAHHFBF, long MJGOHHJHHDM, long CEKJCFFEKJC, string OFPCNJNBIGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4E5980", Offset = "0x4E4180", VA = "0x1804E5980")]
		public void IKAKBKAKMKG(long JOLINIPOHFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x43F6FB0", Offset = "0x43F57B0", VA = "0x1843F6FB0", Slot = "5")]
		public override void ANBMAFGDCPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x43F74D0", Offset = "0x43F5CD0", VA = "0x1843F74D0", Slot = "6")]
		public override void NAMMKLHEDAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x43F70C0", Offset = "0x43F58C0", VA = "0x1843F70C0", Slot = "4")]
		protected override Dictionary<string, object> BOENDLLEAIP(Dictionary<string, object> LCOEKPOLGFL)
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
			[Cpp2IlInjected.Address(RVA = "0x43F8080", Offset = "0x43F6880", VA = "0x1843F8080")]
			public void JNPFJGAKHFI(Dictionary<string, object> HKCBCECKDOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x43FB650", Offset = "0x43F9E50", VA = "0x1843FB650")]
			public void JNPFJGAKHFI(Dictionary<string, object> MHLIGNAMLIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8369B0", Offset = "0x8351B0", VA = "0x1808369B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4D7850", Offset = "0x4D6050", VA = "0x1804D7850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x43F7AF0", Offset = "0x43F62F0", VA = "0x1843F7AF0")]
		public static EFMIGFLPKPF MJCPAEDCHAE(string LLLILKCIOIH, string OFPCNJNBIGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x43F7C00", Offset = "0x43F6400", VA = "0x1843F7C00")]
		protected AmplitudeAnalyticsIdentifyMessage(string LLLILKCIOIH, string OFPCNJNBIGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x43F7A80", Offset = "0x43F6280", VA = "0x1843F7A80")]
		public Dictionary<string, object> JINGJCEAOPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x43F7730", Offset = "0x43F5F30", VA = "0x1843F7730", Slot = "4")]
		protected virtual Dictionary<string, object> BOENDLLEAIP(Dictionary<string, object> LCOEKPOLGFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x43F79E0", Offset = "0x43F61E0", VA = "0x1843F79E0")]
		protected void FGJEJPMFOKF(string PONAFPGHKNA, Dictionary<string, object> GOAIKLJIBBI, Dictionary<string, object> HBBAPLMJIBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x43F7970", Offset = "0x43F6170", VA = "0x1843F7970")]
		protected void EMOGNCHKPPE(string PONAFPGHKNA, string IJBLIGDNDKF, Dictionary<string, object> EJNDCECCOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x43F76C0", Offset = "0x43F5EC0", VA = "0x1843F76C0", Slot = "5")]
		public virtual void ANBMAFGDCPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x43F7B90", Offset = "0x43F6390", VA = "0x1843F7B90", Slot = "6")]
		public virtual void NAMMKLHEDAF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EFMIGFLPKPF : global::CFKPJBGEPLP<AmplitudeAnalyticsIdentifyMessage, EFMIGFLPKPF>
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override EFMIGFLPKPF HAKJCNAGGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F50", Offset = "0x5A4750", VA = "0x1805A5F50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage KJOFJCPHAKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x43F8230", Offset = "0x43F6A30", VA = "0x1843F8230")]
	public EFMIGFLPKPF(AmplitudeAnalyticsIdentifyMessage LJLDJHKJCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x43F81A0", Offset = "0x43F69A0", VA = "0x1843F81A0", Slot = "4")]
	public override void NAMMKLHEDAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CGFIFAMOIOF : global::CFKPJBGEPLP<AmplitudeAnalyticsEvent, CGFIFAMOIOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool DJCEKFKEGGN;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override CGFIFAMOIOF HAKJCNAGGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F50", Offset = "0x5A4750", VA = "0x1805A5F50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x43F8030", Offset = "0x43F6830", VA = "0x1843F8030")]
	public CGFIFAMOIOF(AmplitudeAnalyticsEvent LJLDJHKJCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860", Slot = "5")]
	public override AmplitudeAnalyticsEvent KJOFJCPHAKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x43F7F10", Offset = "0x43F6710", VA = "0x1843F7F10", Slot = "4")]
	public override void NAMMKLHEDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x18C3CB0", Offset = "0x18C24B0", VA = "0x1818C3CB0")]
	public CGFIFAMOIOF PEFKEFICPLE<T>(string EDBCKJNADOO, T[] IJBLIGDNDKF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x43F8020", Offset = "0x43F6820", VA = "0x1843F8020")]
	public CGFIFAMOIOF PEFKEFICPLE(string EDBCKJNADOO, string[] IJBLIGDNDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x18C3C40", Offset = "0x18C2440", VA = "0x1818C3C40")]
	public CGFIFAMOIOF PEFKEFICPLE<T>(string EDBCKJNADOO, T IJBLIGDNDKF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x43F7FB0", Offset = "0x43F67B0", VA = "0x1843F7FB0")]
	public CGFIFAMOIOF PEFKEFICPLE(string EDBCKJNADOO, string IJBLIGDNDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x43F7E30", Offset = "0x43F6630", VA = "0x1843F7E30")]
	private CGFIFAMOIOF KGJABEIDKBD(string EDBCKJNADOO, object IJBLIGDNDKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OPJGNNNIKGC : CGFIFAMOIOF
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x43F8030", Offset = "0x43F6830", VA = "0x1843F8030")]
	public OPJGNNNIKGC(AmplitudeAnalyticsEvent LJLDJHKJCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x43FB3F0", Offset = "0x43F9BF0", VA = "0x1843FB3F0", Slot = "4")]
	public override void NAMMKLHEDAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class CFKPJBGEPLP<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::CFKPJBGEPLP<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	protected M LJLDJHKJCME;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public abstract BLDR HAKJCNAGGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x16A4400", Offset = "0x16A2C00", VA = "0x1816A4400")]
	public CFKPJBGEPLP(M LJLDJHKJCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2E20C70", Offset = "0x2E1F470", VA = "0x182E20C70")]
	public BLDR JEHDELNKNHK(AmplitudeAnalyticsIdentifyMessage.DeviceInfo IEPOBJKBNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2E20C10", Offset = "0x2E1F410", VA = "0x182E20C10")]
	public BLDR GCCCFGLPLPD(AmplitudeAnalyticsIdentifyMessage.RevenueData AOKDILHMKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2E20CA0", Offset = "0x2E1F4A0", VA = "0x182E20CA0")]
	public BLDR LJHOIOMOAKF(string EDBCKJNADOO, string IJBLIGDNDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x18C3970", Offset = "0x18C2170", VA = "0x1818C3970")]
	public BLDR LJHOIOMOAKF<T>(string EDBCKJNADOO, T IJBLIGDNDKF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NAMMKLHEDAF();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2E20C40", Offset = "0x2E1F440", VA = "0x182E20C40")]
	internal static string IJEHFDHAEPE(string IJBLIGDNDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2E20B30", Offset = "0x2E1F330", VA = "0x182E20B30")]
	private BLDR BPALOOALNML(string EDBCKJNADOO, object IJBLIGDNDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M KJOFJCPHAKI();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FPGPBPLIIMH
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int PLEPHDLNKJN = 2;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int MOLGIFMKIEJ = 100;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const int HPIIFFEFHPO = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const long CCKGNFGFLMM = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int PPBEEIFBMFM = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const int FPNANHLNBHO = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string IHIBMOLIECH = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string PGHOHDGKJPL = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string PKJOLMIPBLP = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string CGLBKGGPOMP = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string BPIFKHIBGFL = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string NKLNBMFNIBG = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string PJHDBECJKBG = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const string FLJIHJHJLNE = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public const int OPDOAGANFLC = 10;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> BOHHBFBPMEP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	public FPGPBPLIIMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NPLGADJFGAG
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string NOFNEHDPHHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string BJLCBPPCNII
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string HKDNBOELFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::GHMNNNIJAKN<LGMKKIBAHBN> LLGENCHBLFO(string DPOCEHLLOCK, Dictionary<string, string> PPJKKIGJIFL);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct LGMKKIBAHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly int PIODMAPCLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly string OBPGLKGEOFP;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A50", Offset = "0x7C7250", VA = "0x1807C8A50")]
	public LGMKKIBAHBN(int HHPIEIKBJDN, string EMKENGPPKMO)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NNEGPLICMMD
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static byte[] JIMKOONODID;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int NMMFCBLNDCI;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int PHIEOBCOOJB;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static BigInteger DPMJLFEPCLI;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	public NNEGPLICMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x43FAE10", Offset = "0x43F9610", VA = "0x1843FAE10")]
	private static string CFIIEEFNNDM(byte[] DALEFJAMHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x43FAF10", Offset = "0x43F9710", VA = "0x1843FAF10")]
	public static string DHILBOIALCB(byte[] EGBGAEKCIGK, bool DAJGEBLMHFN)
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
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
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
