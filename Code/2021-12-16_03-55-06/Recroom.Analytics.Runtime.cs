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
		public AmplitudeAnalyticsClient.Settings NEFBKMKIPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NEEDMMJKMCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4BF160", Offset = "0x4BE560", VA = "0x1804BF160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD550", VA = "0x180ACE150")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum EBOIEHECPMD
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class GIBPBFKEFEM
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class CLLIKEMJJEF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public int LACFBBPDKPG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public Dictionary<string, object> KPJECNBBMJM;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
				public CLLIKEMJJEF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class IMANJGNNPJD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
				public IMANJGNNPJD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x4330290", Offset = "0x432F690", VA = "0x184330290")]
				internal bool <GetBatch>b__0(CLLIKEMJJEF item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private const string PAJBPAOLHMK = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string JIHMEJDMJDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<CLLIKEMJJEF> JBCOMJBMEMJ;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? DEOIAKPEEAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x43300B0", Offset = "0x432F4B0", VA = "0x1843300B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? ELNMCMDABAI
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x432F850", Offset = "0x432EC50", VA = "0x18432F850")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x4330140", Offset = "0x432F540", VA = "0x184330140")]
			internal GIBPBFKEFEM(string HALKCGAJOAJ, string OLHKGJDCJEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x432FD10", Offset = "0x432F110", VA = "0x18432FD10")]
			public int JPOKAAIMIOI([Optional] int? COINPIFIBLI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x432EFC0", Offset = "0x432E3C0", VA = "0x18432EFC0")]
			public List<Dictionary<string, object>> BMLEOJOAMOO(int MAEKKJLCHMJ, int? COINPIFIBLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x432F590", Offset = "0x432E990", VA = "0x18432F590")]
			public void HLBIIPJJCOD(AmplitudeAnalyticsIdentifyMessage JLOFPPFANIF, bool AFDBMKCMKGC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x432F630", Offset = "0x432EA30", VA = "0x18432F630")]
			public void HLBIIPJJCOD(Dictionary<string, object> JLOFPPFANIF, bool AFDBMKCMKGC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x432FF80", Offset = "0x432F380", VA = "0x18432FF80")]
			public void MCDMMIINJEA(params Dictionary<string, object>[] GEGEKDAMAKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x432FAF0", Offset = "0x432EEF0", VA = "0x18432FAF0")]
			public void JOLGOBOENLB(List<Dictionary<string, object>> LEBNKHJKAOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x432FE70", Offset = "0x432F270", VA = "0x18432FE70")]
			private void KOAODIANPDP(Dictionary<string, object> JLOFPPFANIF, bool AFDBMKCMKGC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x432F900", Offset = "0x432ED00", VA = "0x18432F900")]
			public void JFPIOIGPIFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x432F1C0", Offset = "0x432E5C0", VA = "0x18432F1C0")]
			private void HDFCFNBKPLI([Optional] string GLMGALHPDFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x432F720", Offset = "0x432EB20", VA = "0x18432F720")]
			private static string IAOCJGPMJFP(string DOLIKBJJDJE, string KFLAFLPOCPA)
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
			[Cpp2IlInjected.Address(RVA = "0x4332840", Offset = "0x4331C40", VA = "0x184332840")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct AONPNDLBCCP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int HPFCKPKIJGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public string AJMLANDHGAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T DCJCOHLGPAF;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class NKMKBLHKNGP : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private KDLPPIDBMCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
			[DebuggerHidden]
			public NKMKBLHKNGP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4331700", Offset = "0x4330B00", VA = "0x184331700", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4331E20", Offset = "0x4331220", VA = "0x184331E20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class AIGDKDNAGKN : IEnumerator<object>, IEnumerator, IDisposable
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
			public LCJLLILPNOL quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
			[DebuggerHidden]
			public AIGDKDNAGKN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x432ABD0", Offset = "0x4329FD0", VA = "0x18432ABD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x432ACB0", Offset = "0x432A0B0", VA = "0x18432ACB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LBJKCLGECCP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
			[DebuggerHidden]
			public LBJKCLGECCP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4330470", Offset = "0x432F870", VA = "0x184330470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x43305B0", Offset = "0x432F9B0", VA = "0x1843305B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class POMPLLJBHBI : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private KDLPPIDBMCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
			[DebuggerHidden]
			public POMPLLJBHBI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4332490", Offset = "0x4331890", VA = "0x184332490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x43326D0", Offset = "0x4331AD0", VA = "0x1843326D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MCHFIDLMGPO : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private KDLPPIDBMCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
			[DebuggerHidden]
			public MCHFIDLMGPO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4331270", Offset = "0x4330670", VA = "0x184331270", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x43314B0", Offset = "0x43308B0", VA = "0x1843314B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class PNDBNNMMNKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public GIBPBFKEFEM cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
			public PNDBNNMMNKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4331FF0", Offset = "0x43313F0", VA = "0x184331FF0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4332090", Offset = "0x4331490", VA = "0x184332090")]
			internal void <FlushFromCache>b__1(AONPNDLBCCP<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class LLPNLCLFCKF : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private KDLPPIDBMCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public GIBPBFKEFEM cache;

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
			private PNDBNNMMNKN <>8__1;

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
			private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
			[DebuggerHidden]
			public LLPNLCLFCKF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4330BE0", Offset = "0x432FFE0", VA = "0x184330BE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4331220", Offset = "0x4330620", VA = "0x184331220", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class HPJIBIPHKJH<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
			public HPJIBIPHKJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1EBD750", Offset = "0x1EBCB50", VA = "0x181EBD750")]
			internal AONPNDLBCCP<T> <PostJson>b__0(AGIBPEJENDF postResponse)
			{
				return default(AONPNDLBCCP<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private NLHPGBIKADJ JODNJGIEHMK;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string HCHMOMKIPCI = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string EFNFCEILBKK = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string LICNKLLEAHN = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string HJPINHOKOAP = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string NHODKFJPCGJ = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int NBPHDLPOOCB = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int ILOPGJDKFCB = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int FNIFGGNBGLP = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float ANDAHGNDMAH = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long OJJOFJLIHFL = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string OOFIEHDBFHE = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static bool BICGOICMNMH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool MGGOGNFLOMI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static int NABCDBIDHIL;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int DIPACDFHECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private MFLPKMNHOIN PDGDLCOMHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool KBPDBAEPAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float MNGPJACKJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float DKAAKBKIFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int ADGNKBGGLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int NFFCBACCLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int? CLCKEDHDCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? HAGNNCIIOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private long JLAFPFACLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string CIBGKPHODNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long EBCIGOIKADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, object> HJMCLCDKGPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private EBOIEHECPMD KIEMIODMLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int JFPJPPLENNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int MJPDFPBPLBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float LHEANPKOIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool AGOPLFJGFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool NIFFGFLGAHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private GIBPBFKEFEM INMGGOBBJCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GIBPBFKEFEM ONHHOEGLCPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GIBPBFKEFEM BMDIPEJKJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> EHGLLMNJPJA;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo MLCCNNIGPOI;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static string CPDDDNOACKI;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string NNBMILEPNPE = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string NGAFONGFBOA = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private NLHPGBIKADJ MKAHLNKCKMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x432CCB0", Offset = "0x432C0B0", VA = "0x18432CCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int LALGCGBIJHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x432B850", Offset = "0x432AC50", VA = "0x18432B850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long LDDEAGGLFOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x432E050", Offset = "0x432D450", VA = "0x18432E050")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x432E150", Offset = "0x432D550", VA = "0x18432E150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string JOCGEMDAHAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x432E020", Offset = "0x432D420", VA = "0x18432E020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string CJHLIBOKPGN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4E2950", Offset = "0x4E1D50", VA = "0x1804E2950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x4D0A40", Offset = "0x4CFE40", VA = "0x1804D0A40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool GIGCNAJLNBM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x578FC0", Offset = "0x5783C0", VA = "0x180578FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xBB9D10", Offset = "0xBB9110", VA = "0x180BB9D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool BKANOEPBPAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x432DF40", Offset = "0x432D340", VA = "0x18432DF40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> GMHNMFDJNNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x432DEA0", Offset = "0x432D2A0", VA = "0x18432DEA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x432E0B0", Offset = "0x432D4B0", VA = "0x18432E0B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x432B0D0", Offset = "0x432A4D0", VA = "0x18432B0D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x432D930", Offset = "0x432CD30", VA = "0x18432D930")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x432D090", Offset = "0x432C490", VA = "0x18432D090", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x432DAB0", Offset = "0x432CEB0", VA = "0x18432DAB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x432D110", Offset = "0x432C510", VA = "0x18432D110")]
		public BJPFHFGNMKO PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x432C0B0", Offset = "0x432B4B0", VA = "0x18432C0B0")]
		[IteratorStateMachine(typeof(NKMKBLHKNGP))]
		public IEnumerator<KDLPPIDBMCA> Initialize(AmplitudeAnalyticsEvent ACJIHGBJOOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x432DA00", Offset = "0x432CE00", VA = "0x18432DA00")]
		public void UpdateLastAliveTime(float HLBMIGKCEFP = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x432CAD0", Offset = "0x432BED0", VA = "0x18432CAD0")]
		private BJPFHFGNMKO MMHMKCLMDOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x432CE70", Offset = "0x432C270", VA = "0x18432CE70")]
		private BJPFHFGNMKO ONMCPJEMMFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x432D5C0", Offset = "0x432C9C0", VA = "0x18432D5C0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x432C4F0", Offset = "0x432B8F0", VA = "0x18432C4F0")]
		[IteratorStateMachine(typeof(AIGDKDNAGKN))]
		private IEnumerator LFOHBDILINO(LCJLLILPNOL HGOOBACFOJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x432DD10", Offset = "0x432D110", VA = "0x18432DD10")]
		[IteratorStateMachine(typeof(LBJKCLGECCP))]
		public IEnumerator WaitForFlush(float LNGNDMGPEEN = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x432D940", Offset = "0x432CD40", VA = "0x18432D940")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x432BDC0", Offset = "0x432B1C0", VA = "0x18432BDC0")]
		public static OMADCNKCPOE Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x432AF90", Offset = "0x432A390", VA = "0x18432AF90")]
		public static MJMOKKBGIKN AccountSelectionPostLoginEvent([NotNull] string EEBFBAHHNBC, string MAKKPGHAKJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x432BB20", Offset = "0x432AF20", VA = "0x18432BB20")]
		public static MJMOKKBGIKN Event([NotNull] string EEBFBAHHNBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x432D190", Offset = "0x432C590", VA = "0x18432D190")]
		public static MJMOKKBGIKN PreviousSessionEvent([NotNull] string EEBFBAHHNBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x432BF00", Offset = "0x432B300", VA = "0x18432BF00")]
		public static MJMOKKBGIKN InitializeEvent(string MAKKPGHAKJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x432D6D0", Offset = "0x432CAD0", VA = "0x18432D6D0")]
		public static MJMOKKBGIKN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x432B5A0", Offset = "0x432A9A0", VA = "0x18432B5A0")]
		public static MJMOKKBGIKN CreateOutOfSessionEvent(string EEBFBAHHNBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x432C760", Offset = "0x432BB60", VA = "0x18432C760")]
		public static BJPFHFGNMKO LogOutOfSessionEvent(MJMOKKBGIKN HGOKEIIJPKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x432C5B0", Offset = "0x432B9B0", VA = "0x18432C5B0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LDLAFKJIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x432C930", Offset = "0x432BD30", VA = "0x18432C930")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LDLAFKJIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x432CA00", Offset = "0x432BE00", VA = "0x18432CA00")]
		public void LogSerializedEventAsync(Dictionary<string, object> GAEHDCHAPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x432C680", Offset = "0x432BA80", VA = "0x18432C680")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage GLJNFHIBGPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x432BD10", Offset = "0x432B110", VA = "0x18432BD10")]
		private void GAKOHKMDNBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x432AD00", Offset = "0x432A100", VA = "0x18432AD00")]
		private void AICKCCOCOIP(Dictionary<string, object> AJMDLENIHFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x432C410", Offset = "0x432B810", VA = "0x18432C410")]
		private void LBFICJOANDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x432C120", Offset = "0x432B520", VA = "0x18432C120")]
		private void JFBKJEJHJJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x432BC80", Offset = "0x432B080", VA = "0x18432BC80")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x432AF20", Offset = "0x432A320", VA = "0x18432AF20")]
		[IteratorStateMachine(typeof(POMPLLJBHBI))]
		private IEnumerator<KDLPPIDBMCA> AMOBIKONJEC(float LNGNDMGPEEN = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x432B530", Offset = "0x432A930", VA = "0x18432B530")]
		[IteratorStateMachine(typeof(MCHFIDLMGPO))]
		private IEnumerator<KDLPPIDBMCA> CEPBDDPFFAN(float LNGNDMGPEEN = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x432BA70", Offset = "0x432AE70", VA = "0x18432BA70")]
		[IteratorStateMachine(typeof(LLPNLCLFCKF))]
		private IEnumerator<KDLPPIDBMCA> EOIOCNPIBDP(GIBPBFKEFEM BIOGNACILLE, int? COINPIFIBLI, string ENOHLKOBDJK, string OGICKOHHCID, float LNGNDMGPEEN, Action<int> PJAEDCPJBOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x432CD80", Offset = "0x432C180", VA = "0x18432CD80")]
		private static void NHFOKCAGHKP(bool JPBNDDLLJMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1CD0C80", Offset = "0x1CD0080", VA = "0x181CD0C80")]
		private global::GMNMGKEAFFO<AONPNDLBCCP<T>> MPDJOMKKHEN<T>(string ENOHLKOBDJK, string OGICKOHHCID, string PAFIBJPOMDK, T DCJCOHLGPAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x432C560", Offset = "0x432B960", VA = "0x18432C560")]
		private bool LPADPDJOENO(float NCPEFDAANNC, float LNGNDMGPEEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x432DDE0", Offset = "0x432D1E0", VA = "0x18432DDE0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x432C2B0", Offset = "0x432B6B0", VA = "0x18432C2B0")]
		[CompilerGenerated]
		private long KMBJNICMHDE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x432BDB0", Offset = "0x432B1B0", VA = "0x18432BDB0")]
		[CompilerGenerated]
		private void IDIGBMKBEDA(int EHOHBAGMJHL)
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
			[Cpp2IlInjected.Address(RVA = "0x4C5310", Offset = "0x4C4710", VA = "0x1804C5310")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x432E660", Offset = "0x432DA60", VA = "0x18432E660")]
		public static MJMOKKBGIKN PPKMIALMIPA(string IEDEMIPOAGB, [NotNull] string PHKOKJKPKOB, long FIKBDKFINKK, long DLHNEEIJPLD, string MAKKPGHAKJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x432E3F0", Offset = "0x432D7F0", VA = "0x18432E3F0")]
		public static MJMOKKBGIKN EBAFOOCHFHF(string IEDEMIPOAGB, [NotNull] string PHKOKJKPKOB, long FIKBDKFINKK, long DLHNEEIJPLD, string MAKKPGHAKJG, long APEFBBJCDBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x432E740", Offset = "0x432DB40", VA = "0x18432E740")]
		private AmplitudeAnalyticsEvent(string IEDEMIPOAGB, [NotNull] string PHKOKJKPKOB, long FIKBDKFINKK, long DLHNEEIJPLD, string MAKKPGHAKJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x535D00", Offset = "0x535100", VA = "0x180535D00")]
		public void PHMGOBNKAGF(long DEAGMPCMPMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x432E550", Offset = "0x432D950", VA = "0x18432E550", Slot = "5")]
		public override void PFNALEPPICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x432E4E0", Offset = "0x432D8E0", VA = "0x18432E4E0", Slot = "6")]
		public override void OMIBCAMLKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x432E1B0", Offset = "0x432D5B0", VA = "0x18432E1B0", Slot = "4")]
		protected override Dictionary<string, object> DMHLJNNEACA(Dictionary<string, object> LFAOEGBCDBF)
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
			[Cpp2IlInjected.Address(RVA = "0x432EEA0", Offset = "0x432E2A0", VA = "0x18432EEA0")]
			public void JMDCJNPFABN(Dictionary<string, object> KBIHFAFKMEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4332720", Offset = "0x4331B20", VA = "0x184332720")]
			public void JMDCJNPFABN(Dictionary<string, object> EAAEFDCDOEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1367330", Offset = "0x1366730", VA = "0x181367330")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BF1A0", Offset = "0x4BE5A0", VA = "0x1804BF1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4BF440", Offset = "0x4BE840", VA = "0x1804BF440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x432ED60", Offset = "0x432E160", VA = "0x18432ED60")]
		public static OMADCNKCPOE PPKMIALMIPA(string IEDEMIPOAGB, string MAKKPGHAKJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x432EE00", Offset = "0x432E200", VA = "0x18432EE00")]
		protected AmplitudeAnalyticsIdentifyMessage(string IEDEMIPOAGB, string MAKKPGHAKJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x432EBA0", Offset = "0x432DFA0", VA = "0x18432EBA0")]
		public Dictionary<string, object> NAFDGONKGPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x432E8C0", Offset = "0x432DCC0", VA = "0x18432E8C0", Slot = "4")]
		protected virtual Dictionary<string, object> DMHLJNNEACA(Dictionary<string, object> LFAOEGBCDBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x432EB00", Offset = "0x432DF00", VA = "0x18432EB00")]
		protected void HPBIIEDMOKI(string KFLAFLPOCPA, Dictionary<string, object> NANJJIGPBNB, Dictionary<string, object> HHNFONJPCCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x432EC10", Offset = "0x432E010", VA = "0x18432EC10")]
		protected void OCIECACJIKG(string KFLAFLPOCPA, string DOLIKBJJDJE, Dictionary<string, object> MOGHAMEBOKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x432ECF0", Offset = "0x432E0F0", VA = "0x18432ECF0", Slot = "5")]
		public virtual void PFNALEPPICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x432EC80", Offset = "0x432E080", VA = "0x18432EC80", Slot = "6")]
		public virtual void OMIBCAMLKOB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OMADCNKCPOE : global::ECBDMNMPMHG<AmplitudeAnalyticsIdentifyMessage, OMADCNKCPOE>
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override OMADCNKCPOE HAOBPDJLAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5509A0", Offset = "0x54FDA0", VA = "0x1805509A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4BF1A0", Offset = "0x4BE5A0", VA = "0x1804BF1A0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage PLHDKHBLBJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4331F00", Offset = "0x4331300", VA = "0x184331F00")]
	public OMADCNKCPOE(AmplitudeAnalyticsIdentifyMessage BFFKMLIHGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4331E70", Offset = "0x4331270", VA = "0x184331E70", Slot = "4")]
	public override void OMIBCAMLKOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MJMOKKBGIKN : global::ECBDMNMPMHG<AmplitudeAnalyticsEvent, MJMOKKBGIKN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool JHLOHIIMPBG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override MJMOKKBGIKN HAOBPDJLAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5509A0", Offset = "0x54FDA0", VA = "0x1805509A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4330420", Offset = "0x432F820", VA = "0x184330420")]
	public MJMOKKBGIKN(AmplitudeAnalyticsEvent BFFKMLIHGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4BF1A0", Offset = "0x4BE5A0", VA = "0x1804BF1A0", Slot = "5")]
	public override AmplitudeAnalyticsEvent PLHDKHBLBJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4331660", Offset = "0x4330A60", VA = "0x184331660", Slot = "4")]
	public override void OMIBCAMLKOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1B63C60", Offset = "0x1B63060", VA = "0x181B63C60")]
	public MJMOKKBGIKN GNDHPODHMHP<T>(string GPDAEKHCAPO, T[] DOLIKBJJDJE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4331570", Offset = "0x4330970", VA = "0x184331570")]
	public MJMOKKBGIKN GNDHPODHMHP(string GPDAEKHCAPO, string[] DOLIKBJJDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1B63BF0", Offset = "0x1B62FF0", VA = "0x181B63BF0")]
	public MJMOKKBGIKN GNDHPODHMHP<T>(string GPDAEKHCAPO, T DOLIKBJJDJE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4331500", Offset = "0x4330900", VA = "0x184331500")]
	public MJMOKKBGIKN GNDHPODHMHP(string GPDAEKHCAPO, string DOLIKBJJDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4331580", Offset = "0x4330980", VA = "0x184331580")]
	private MJMOKKBGIKN HNKJDEGELEF(string GPDAEKHCAPO, object DOLIKBJJDJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JHBEPCBBGMH : MJMOKKBGIKN
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4330420", Offset = "0x432F820", VA = "0x184330420")]
	public JHBEPCBBGMH(AmplitudeAnalyticsEvent BFFKMLIHGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x43302F0", Offset = "0x432F6F0", VA = "0x1843302F0", Slot = "4")]
	public override void OMIBCAMLKOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class ECBDMNMPMHG<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::ECBDMNMPMHG<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	protected M BFFKMLIHGAO;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public abstract BLDR HAOBPDJLAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1C739C0", Offset = "0x1C72DC0", VA = "0x181C739C0")]
	public ECBDMNMPMHG(M BFFKMLIHGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2484900", Offset = "0x2483D00", VA = "0x182484900")]
	public BLDR HBFGJEJINDB(AmplitudeAnalyticsIdentifyMessage.DeviceInfo KEFICEMDOFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x24848D0", Offset = "0x2483CD0", VA = "0x1824848D0")]
	public BLDR GEADGGDCGLP(AmplitudeAnalyticsIdentifyMessage.RevenueData ILBAKIGNPOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2484A10", Offset = "0x2483E10", VA = "0x182484A10")]
	public BLDR NOPBEGABFIL(string GPDAEKHCAPO, string DOLIKBJJDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1CD3C60", Offset = "0x1CD3060", VA = "0x181CD3C60")]
	public BLDR NOPBEGABFIL<T>(string GPDAEKHCAPO, T DOLIKBJJDJE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void OMIBCAMLKOB();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x24848A0", Offset = "0x2483CA0", VA = "0x1824848A0")]
	internal static string ANKECLHBIHE(string DOLIKBJJDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2484930", Offset = "0x2483D30", VA = "0x182484930")]
	private BLDR MMBGDIJIGFC(string GPDAEKHCAPO, object DOLIKBJJDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M PLHDKHBLBJE();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ONCJBNNBPEE
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int LKJMMGFACDB = 2;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int HMGNEBJAHEB = 100;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const int FALJEJNDPAG = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const long KAPBNBOHBHH = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int CKFPDMPMKKE = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const int ACMDNIHJHPB = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string LJOKPGFCMJE = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string ECAFKENBCMF = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string JKAGBPMNMMN = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string FBAHLECEENC = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string MEDEKEOMJLL = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string OABACDEFJHM = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string DBBBJMJKMNG = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const string FIIHNCGIIIH = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public const int NAGMNMDLPCA = 10;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> GCNKMEHAGGN;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
	public ONCJBNNBPEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MFLPKMNHOIN
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string MKMNDOJDACM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string EADHJBJGKOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string ANICPNJPEGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::GMNMGKEAFFO<AGIBPEJENDF> MPDJOMKKHEN(string ENOHLKOBDJK, Dictionary<string, string> IEAICOEKOPN);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct AGIBPEJENDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly int DFHLKAJMNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly string LGFBIHIEABM;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4C78C0", Offset = "0x4C6CC0", VA = "0x1804C78C0")]
	public AGIBPEJENDF(int HPFCKPKIJGB, string AJMLANDHGAJ)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LFOOCLJBDKO
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static byte[] MMIGALFGEBH;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int KKBDIGGLOKN;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int BKPLPABKLDE;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static BigInteger NPDKPCMPDOD;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
	public LFOOCLJBDKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4330600", Offset = "0x432FA00", VA = "0x184330600")]
	private static string ELDABPJJLIE(byte[] DOIHHFGBAEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4330700", Offset = "0x432FB00", VA = "0x184330700")]
	public static string OCONCCINMFA(byte[] KLJMCJLFPAA, bool NGPDKIFLJKL)
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
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
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
