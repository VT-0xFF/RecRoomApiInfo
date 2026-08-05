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
		public AmplitudeAnalyticsClient.Settings LDFIDBIJFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool CEAIPJLLABE
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x449160", Offset = "0x448360", VA = "0x180449160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACA3F0", Offset = "0xAC95F0", VA = "0x180ACA3F0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum EADBFMIDAIC
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class DILCEOGKLON
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class CGJDMBFBJGL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public int KMIKMDKMNEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public Dictionary<string, object> HHBONCCOELJ;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
				public CGJDMBFBJGL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class LLLOHJLBKGC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
				public LLLOHJLBKGC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x40474C0", Offset = "0x40466C0", VA = "0x1840474C0")]
				internal bool <GetBatch>b__0(CGJDMBFBJGL item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private const string APOHFBHJMBH = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string AKDBDKFLBMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<CGJDMBFBJGL> IPHNBOBHECN;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? MNKDNBNPJOJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x4045770", Offset = "0x4044970", VA = "0x184045770")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? IEDIIIFCOAE
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x4045460", Offset = "0x4044660", VA = "0x184045460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x4045EB0", Offset = "0x40450B0", VA = "0x184045EB0")]
			internal DILCEOGKLON(string JNJFMLLEPFK, string KHOGLOJMKLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x4045300", Offset = "0x4044500", VA = "0x184045300")]
			public int FGPFKDDNONB([Optional] int? KIABOKGMOME)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4045100", Offset = "0x4044300", VA = "0x184045100")]
			public List<Dictionary<string, object>> FAHLMKFABIL(int IHEDEKBABCK, int? KIABOKGMOME)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4045A20", Offset = "0x4044C20", VA = "0x184045A20")]
			public void KGJFIGHDPJJ(AmplitudeAnalyticsIdentifyMessage LBCPAPMBFKI, bool DCPFDDPMHOI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4045AC0", Offset = "0x4044CC0", VA = "0x184045AC0")]
			public void KGJFIGHDPJJ(Dictionary<string, object> LBCPAPMBFKI, bool DCPFDDPMHOI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4045640", Offset = "0x4044840", VA = "0x184045640")]
			public void FPDAMAGMBDJ(params Dictionary<string, object>[] CINHCENDLEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4045800", Offset = "0x4044A00", VA = "0x184045800")]
			public void IJMBJDFNBIF(List<Dictionary<string, object>> BAFNBIOGEON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4045DA0", Offset = "0x4044FA0", VA = "0x184045DA0")]
			private void OCCKDJMBLBF(Dictionary<string, object> LBCPAPMBFKI, bool DCPFDDPMHOI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4045BB0", Offset = "0x4044DB0", VA = "0x184045BB0")]
			public void OBBKGOIDCLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4044D30", Offset = "0x4043F30", VA = "0x184044D30")]
			private void DCHDNOOGIEK([Optional] string LMPLKNNAFNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4045510", Offset = "0x4044710", VA = "0x184045510")]
			private static string FMPMBOKEJFI(string DIDEMEECIEC, string KPLFFOGJEBN)
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
			[Cpp2IlInjected.Address(RVA = "0x4047E60", Offset = "0x4047060", VA = "0x184047E60")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct HDGCJNNILOO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int AIHCFBLDAMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public string ABHCGJIGAOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T DAPNLLCMIGD;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class EJLMNAMKAMJ : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private GGOLJFPNLLB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
			[DebuggerHidden]
			public EJLMNAMKAMJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4046120", Offset = "0x4045320", VA = "0x184046120", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4046840", Offset = "0x4045A40", VA = "0x184046840", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class JBGDBNJNAMG : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
			[DebuggerHidden]
			public JBGDBNJNAMG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4046DC0", Offset = "0x4045FC0", VA = "0x184046DC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4046E90", Offset = "0x4046090", VA = "0x184046E90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MHNLOEHMEEA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
			[DebuggerHidden]
			public MHNLOEHMEEA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4047BB0", Offset = "0x4046DB0", VA = "0x184047BB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4047CF0", Offset = "0x4046EF0", VA = "0x184047CF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BFKFNPHDFCA : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private GGOLJFPNLLB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
			[DebuggerHidden]
			public BFKFNPHDFCA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4044480", Offset = "0x4043680", VA = "0x184044480", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x40446C0", Offset = "0x40438C0", VA = "0x1840446C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class GEKKPKEIAKD : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private GGOLJFPNLLB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
			[DebuggerHidden]
			public GEKKPKEIAKD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4046890", Offset = "0x4045A90", VA = "0x184046890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x4046AD0", Offset = "0x4045CD0", VA = "0x184046AD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class CCAACACMPLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public DILCEOGKLON cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
			public CCAACACMPLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4044890", Offset = "0x4043A90", VA = "0x184044890")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4044930", Offset = "0x4043B30", VA = "0x184044930")]
			internal void <FlushFromCache>b__1(HDGCJNNILOO<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class LOEOBLBNNIJ : IEnumerator<GGOLJFPNLLB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private GGOLJFPNLLB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public DILCEOGKLON cache;

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
			private CCAACACMPLJ <>8__1;

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
			private GGOLJFPNLLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
			[DebuggerHidden]
			public LOEOBLBNNIJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4047520", Offset = "0x4046720", VA = "0x184047520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4047B60", Offset = "0x4046D60", VA = "0x184047B60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class GICFBFODIMO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x16F2AE0", Offset = "0x16F1CE0", VA = "0x1816F2AE0")]
			public GICFBFODIMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2492C90", Offset = "0x2491E90", VA = "0x182492C90")]
			internal HDGCJNNILOO<T> <PostJson>b__0(BIPGDBABAND postResponse)
			{
				return default(HDGCJNNILOO<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private LGHEGMFLLFJ LPJIJOMKPCN;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string EKHDPBMJDKK = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string OAIMADEKLJH = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string IFHAOCJMFMB = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string LCLNEMHDMIC = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string JDLIIDJLBBB = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int ABNILEPMAML = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int IBBIHJOJJNP = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int GJPFJBHKGAN = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float PGHHMGFDENO = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long ILNNOGPFEJJ = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string MKAKGBAJCFL = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static bool MFJAHGCPLNF;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool DGNLCHAOBME;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static int EHBPDKPGENP;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int MDALIMNCFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private BFEHJOADAPJ ICLIPJODCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool MKAHFOIIGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float MFHJODFKEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float OJDOIMPDKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int CNPLJBAIIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int OEHHLHBPFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int? ABEFOBAKAFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? AKOCLHFHNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private long JPPIEGLOKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string HEAGKGKNDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long HILKDPLPOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, object> CKJIGHMCBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private EADBFMIDAIC MGKMJGIAKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int AMGEOCOGICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int MOJNLOACIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float PINBEKBJJND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool MBPDMLBKLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool OIBAAEEDAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private DILCEOGKLON EAGHJGCNGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private DILCEOGKLON LLMIAHGAGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private DILCEOGKLON IHPMACCGBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> JLOJEOPOPNL;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo LDPKNGDAJAF;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static string ABKMIJENLOJ;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string IHHDJBGGIEJ = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string HLGDCEAGHLA = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LGHEGMFLLFJ DEDLPGMENIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x4040BA0", Offset = "0x403FDA0", VA = "0x184040BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int MIGCPDMPJCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x4041510", Offset = "0x4040710", VA = "0x184041510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long EJMBABOGAHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x4043550", Offset = "0x4042750", VA = "0x184043550")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x4043650", Offset = "0x4042850", VA = "0x184043650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string PPNHJMPCFKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x4043520", Offset = "0x4042720", VA = "0x184043520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string GIKJPIDLCBB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x46C950", Offset = "0x46BB50", VA = "0x18046C950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x45AA40", Offset = "0x459C40", VA = "0x18045AA40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool GFACFGJCFDD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4BA070", Offset = "0x4B9270", VA = "0x1804BA070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC2E4F0", Offset = "0xC2D6F0", VA = "0x180C2E4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool HLGECACFECE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4043440", Offset = "0x4042640", VA = "0x184043440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> GAHNHOGIIJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x40433A0", Offset = "0x40425A0", VA = "0x1840433A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x40435B0", Offset = "0x40427B0", VA = "0x1840435B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4040510", Offset = "0x403F710", VA = "0x184040510", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4042E30", Offset = "0x4042030", VA = "0x184042E30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4042610", Offset = "0x4041810", VA = "0x184042610", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4042FB0", Offset = "0x40421B0", VA = "0x184042FB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4041C80", Offset = "0x4040E80", VA = "0x184041C80")]
		private bool LNOAIMBGFNI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4041A20", Offset = "0x4040C20", VA = "0x184041A20")]
		[IteratorStateMachine(typeof(EJLMNAMKAMJ))]
		public IEnumerator<GGOLJFPNLLB> Initialize(AmplitudeAnalyticsEvent JAPGNPCNBGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4042F00", Offset = "0x4042100", VA = "0x184042F00")]
		public void UpdateLastAliveTime(float DAOMFMAJIKO = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x40413A0", Offset = "0x40405A0", VA = "0x1840413A0")]
		private bool GNPHLGMPEKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4042210", Offset = "0x4041410", VA = "0x184042210")]
		private bool NALFFFGOBOF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4042AC0", Offset = "0x4041CC0", VA = "0x184042AC0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4041A90", Offset = "0x4040C90", VA = "0x184041A90")]
		[IteratorStateMachine(typeof(JBGDBNJNAMG))]
		private IEnumerator JFMPCNCCHDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4043210", Offset = "0x4042410", VA = "0x184043210")]
		[IteratorStateMachine(typeof(MHNLOEHMEEA))]
		public IEnumerator WaitForFlush(float GDAMCIMKMPM = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4042E40", Offset = "0x4042040", VA = "0x184042E40")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4041730", Offset = "0x4040930", VA = "0x184041730")]
		public static BELGKGDIHGK Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x40403D0", Offset = "0x403F5D0", VA = "0x1840403D0")]
		public static GNHCPNHCEPN AccountSelectionPostLoginEvent([NotNull] string APJILFAGILJ, string CFBGAIKCKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4040F70", Offset = "0x4040170", VA = "0x184040F70")]
		public static GNHCPNHCEPN Event([NotNull] string APJILFAGILJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4042690", Offset = "0x4041890", VA = "0x184042690")]
		public static GNHCPNHCEPN PreviousSessionEvent([NotNull] string APJILFAGILJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4041870", Offset = "0x4040A70", VA = "0x184041870")]
		public static GNHCPNHCEPN InitializeEvent(string CFBGAIKCKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4042BD0", Offset = "0x4041DD0", VA = "0x184042BD0")]
		public static GNHCPNHCEPN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4040CC0", Offset = "0x403FEC0", VA = "0x184040CC0")]
		public static GNHCPNHCEPN CreateOutOfSessionEvent(string APJILFAGILJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4041E90", Offset = "0x4041090", VA = "0x184041E90")]
		public static NIIPAOBAIGP LogOutOfSessionEvent(GNHCPNHCEPN BKEDKACGODI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4041CE0", Offset = "0x4040EE0", VA = "0x184041CE0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent JNBBDNDAPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4042060", Offset = "0x4041260", VA = "0x184042060")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent JNBBDNDAPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4042130", Offset = "0x4041330", VA = "0x184042130")]
		public void LogSerializedEventAsync(Dictionary<string, object> AOKOPCLNOAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4041DB0", Offset = "0x4040FB0", VA = "0x184041DB0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage KHHFFPCHMPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4040330", Offset = "0x403F530", VA = "0x184040330")]
		private void AKJGDNDHOPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x40423F0", Offset = "0x40415F0", VA = "0x1840423F0")]
		private void ONCDGIBHILE(Dictionary<string, object> HGLLNMEHECP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x40412C0", Offset = "0x40404C0", VA = "0x1840412C0")]
		private void GDCKJOKGKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4041AF0", Offset = "0x4040CF0", VA = "0x184041AF0")]
		private void KBNDFCNNDIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4041230", Offset = "0x4040430", VA = "0x184041230")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x40402C0", Offset = "0x403F4C0", VA = "0x1840402C0")]
		[IteratorStateMachine(typeof(BFKFNPHDFCA))]
		private IEnumerator<GGOLJFPNLLB> AJJBNCELEFF(float GDAMCIMKMPM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x40411C0", Offset = "0x40403C0", VA = "0x1840411C0")]
		[IteratorStateMachine(typeof(GEKKPKEIAKD))]
		private IEnumerator<GGOLJFPNLLB> FCKHPBOCBGM(float GDAMCIMKMPM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4040AF0", Offset = "0x403FCF0", VA = "0x184040AF0")]
		[IteratorStateMachine(typeof(LOEOBLBNNIJ))]
		private IEnumerator<GGOLJFPNLLB> BGOOKPNOIEM(DILCEOGKLON IJKHLKJCCGE, int? KIABOKGMOME, string EAJJGBMOEEP, string HGPJGBDBKAB, float GDAMCIMKMPM, Action<int> BOIKBAGGNOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x40410D0", Offset = "0x40402D0", VA = "0x1840410D0")]
		private static void FBANDLOHJLB(bool LOKJOKNALIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1D667B0", Offset = "0x1D659B0", VA = "0x181D667B0")]
		private global::IJNOJIGJDDE<HDGCJNNILOO<T>> ELGADCCMICE<T>(string EAJJGBMOEEP, string HGPJGBDBKAB, string MOHOJKNHHEN, T DAPNLLCMIGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4040C70", Offset = "0x403FE70", VA = "0x184040C70")]
		private bool CDNJGANNMKK(float NPMPGFDNGOJ, float GDAMCIMKMPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x40432E0", Offset = "0x40424E0", VA = "0x1840432E0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4040990", Offset = "0x403FB90", VA = "0x184040990")]
		[CompilerGenerated]
		private long BBIFJMAAMAC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4042200", Offset = "0x4041400", VA = "0x184042200")]
		[CompilerGenerated]
		private void MPNKMCNMKJD(int PDJAAJKGNBF)
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
			[Cpp2IlInjected.Address(RVA = "0x44F310", Offset = "0x44E510", VA = "0x18044F310")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x40436B0", Offset = "0x40428B0", VA = "0x1840436B0")]
		public static GNHCPNHCEPN BAHAJJMALOP(string ALLGOKCDAJA, [NotNull] string DIIEKDHPJEI, long CPMOBPNHPJE, long HCDIDJBBBJB, string CFBGAIKCKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4043790", Offset = "0x4042990", VA = "0x184043790")]
		public static GNHCPNHCEPN CPKLIIMCNLM(string ALLGOKCDAJA, [NotNull] string DIIEKDHPJEI, long CPMOBPNHPJE, long HCDIDJBBBJB, string CFBGAIKCKAN, long IFGBIADJFOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4043C40", Offset = "0x4042E40", VA = "0x184043C40")]
		private AmplitudeAnalyticsEvent(string ALLGOKCDAJA, [NotNull] string DIIEKDHPJEI, long CPMOBPNHPJE, long HCDIDJBBBJB, string CFBGAIKCKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4BD840", Offset = "0x4BCA40", VA = "0x1804BD840")]
		public void MFGAOKAKEJN(long KLJOMHGCAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4043880", Offset = "0x4042A80", VA = "0x184043880", Slot = "5")]
		public override void HKCDBBIHBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4043BD0", Offset = "0x4042DD0", VA = "0x184043BD0", Slot = "6")]
		public override void OLOPMJIPFIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4043990", Offset = "0x4042B90", VA = "0x184043990", Slot = "4")]
		protected override Dictionary<string, object> OBOPMJCLODK(Dictionary<string, object> EFCLDBKLCNM)
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
			[Cpp2IlInjected.Address(RVA = "0x4046000", Offset = "0x4045200", VA = "0x184046000")]
			public void CEHGHKNFHLO(Dictionary<string, object> NEKCGBEFOLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4047D40", Offset = "0x4046F40", VA = "0x184047D40")]
			public void CEHGHKNFHLO(Dictionary<string, object> LGGOMHLNCKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xDFAC60", Offset = "0xDF9E60", VA = "0x180DFAC60")]
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
			[Cpp2IlInjected.Address(RVA = "0x4491A0", Offset = "0x4483A0", VA = "0x1804491A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x449440", Offset = "0x448640", VA = "0x180449440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4043DC0", Offset = "0x4042FC0", VA = "0x184043DC0")]
		public static BELGKGDIHGK BAHAJJMALOP(string ALLGOKCDAJA, string CFBGAIKCKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4044300", Offset = "0x4043500", VA = "0x184044300")]
		protected AmplitudeAnalyticsIdentifyMessage(string ALLGOKCDAJA, string CFBGAIKCKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4043E60", Offset = "0x4043060", VA = "0x184043E60")]
		public Dictionary<string, object> BJJJDPGOLLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4043F40", Offset = "0x4043140", VA = "0x184043F40", Slot = "4")]
		protected virtual Dictionary<string, object> OBOPMJCLODK(Dictionary<string, object> EFCLDBKLCNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4044180", Offset = "0x4043380", VA = "0x184044180")]
		protected void OBPCPGEBEKL(string KPLFFOGJEBN, Dictionary<string, object> BKAJMIBEGAG, Dictionary<string, object> BBDANNINBIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4044290", Offset = "0x4043490", VA = "0x184044290")]
		protected void PLFBIJJCPOG(string KPLFFOGJEBN, string DIDEMEECIEC, Dictionary<string, object> JFMADAPBOKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4043ED0", Offset = "0x40430D0", VA = "0x184043ED0", Slot = "5")]
		public virtual void HKCDBBIHBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4044220", Offset = "0x4043420", VA = "0x184044220", Slot = "6")]
		public virtual void OLOPMJIPFIM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BELGKGDIHGK : global::FCNNAJKJHHC<AmplitudeAnalyticsIdentifyMessage, BELGKGDIHGK>
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override BELGKGDIHGK ECFAIADNAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x49B140", Offset = "0x49A340", VA = "0x18049B140", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4491A0", Offset = "0x4483A0", VA = "0x1804491A0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage CDEDEAFICLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4044430", Offset = "0x4043630", VA = "0x184044430")]
	public BELGKGDIHGK(AmplitudeAnalyticsIdentifyMessage MMMNDCGJHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x40443A0", Offset = "0x40435A0", VA = "0x1840443A0", Slot = "4")]
	public override void OLOPMJIPFIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GNHCPNHCEPN : global::FCNNAJKJHHC<AmplitudeAnalyticsEvent, GNHCPNHCEPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool FCENGFBNILG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override GNHCPNHCEPN ECFAIADNAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x49B140", Offset = "0x49A340", VA = "0x18049B140", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4044840", Offset = "0x4043A40", VA = "0x184044840")]
	public GNHCPNHCEPN(AmplitudeAnalyticsEvent MMMNDCGJHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4491A0", Offset = "0x4483A0", VA = "0x1804491A0", Slot = "5")]
	public override AmplitudeAnalyticsEvent CDEDEAFICLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4046C80", Offset = "0x4045E80", VA = "0x184046C80", Slot = "4")]
	public override void OLOPMJIPFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	public GNHCPNHCEPN BPNEOOBGEOP<T>(string ILHKAMEPJFJ, T[] DIDEMEECIEC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4046B20", Offset = "0x4045D20", VA = "0x184046B20")]
	public GNHCPNHCEPN BPNEOOBGEOP(string ILHKAMEPJFJ, string[] DIDEMEECIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C9C0", Offset = "0x1D6BBC0", VA = "0x181D6C9C0")]
	public GNHCPNHCEPN BPNEOOBGEOP<T>(string ILHKAMEPJFJ, T DIDEMEECIEC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4046B30", Offset = "0x4045D30", VA = "0x184046B30")]
	public GNHCPNHCEPN BPNEOOBGEOP(string ILHKAMEPJFJ, string DIDEMEECIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4046BA0", Offset = "0x4045DA0", VA = "0x184046BA0")]
	private GNHCPNHCEPN OGNBGLAGKPJ(string ILHKAMEPJFJ, object DIDEMEECIEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BMDAKIHDNNF : GNHCPNHCEPN
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4044840", Offset = "0x4043A40", VA = "0x184044840")]
	public BMDAKIHDNNF(AmplitudeAnalyticsEvent MMMNDCGJHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4044710", Offset = "0x4043910", VA = "0x184044710", Slot = "4")]
	public override void OLOPMJIPFIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class FCNNAJKJHHC<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::FCNNAJKJHHC<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	protected M MMMNDCGJHGD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public abstract BLDR ECFAIADNAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x264AC20", Offset = "0x2649E20", VA = "0x18264AC20")]
	public FCNNAJKJHHC(M MMMNDCGJHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x31549E0", Offset = "0x3153BE0", VA = "0x1831549E0")]
	public BLDR GLPNPIPKEEJ(AmplitudeAnalyticsIdentifyMessage.DeviceInfo ADKOAHILINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3154A80", Offset = "0x3153C80", VA = "0x183154A80")]
	public BLDR KAHCAFJAGHK(AmplitudeAnalyticsIdentifyMessage.RevenueData CLAPLGPGAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3154A10", Offset = "0x3153C10", VA = "0x183154A10")]
	public BLDR GMAFDMBIABA(string ILHKAMEPJFJ, string DIDEMEECIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1D6A7A0", Offset = "0x1D699A0", VA = "0x181D6A7A0")]
	public BLDR GMAFDMBIABA<T>(string ILHKAMEPJFJ, T DIDEMEECIEC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void OLOPMJIPFIM();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3154B90", Offset = "0x3153D90", VA = "0x183154B90")]
	internal static string NABDNBADIBC(string DIDEMEECIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3154AB0", Offset = "0x3153CB0", VA = "0x183154AB0")]
	private BLDR KBJHGAIBCKA(string ILHKAMEPJFJ, object DIDEMEECIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M CDEDEAFICLC();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HOGLKPIGMJH
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public const int PDEPHPJBANL = 2;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int ABANOELPPMH = 100;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int ODPHGANHAME = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const long LCMJFMPCFJL = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const int MGMLOLANKPP = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int LJKINFOKDHG = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const string LAJCAHNBIAJ = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string HNDMELGDKFK = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string BAMBIAJJEDA = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string NDBHPPOCBIC = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string GDOJBNMGDGC = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string BFAIMIFOPIL = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string CPOCNPPGEPN = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string FPHHDOPKCLB = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const int NNPJLBEJAPI = 10;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> HAMOPDIJGOL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
	public HOGLKPIGMJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BFEHJOADAPJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string BEJNDBHEJGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string NKNLJDDOPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string NPGBNIFHMBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::IJNOJIGJDDE<BIPGDBABAND> ELGADCCMICE(string EAJJGBMOEEP, Dictionary<string, string> NACNGMIIJIH);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BIPGDBABAND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly int GPDKDFHHFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly string LJBLNPMANMD;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4518C0", Offset = "0x450AC0", VA = "0x1804518C0")]
	public BIPGDBABAND(int AIHCFBLDAMA, string ABHCGJIGAOP)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KIIENADHBAP
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static byte[] JHNDOHIGIOO;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int MADEGOKLHIN;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int MONIHPJNDGC;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static BigInteger PDPNCLAKIEF;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
	public KIIENADHBAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4046EE0", Offset = "0x40460E0", VA = "0x184046EE0")]
	private static string BNMKEPLLJLH(byte[] PADLHGFNBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4046FE0", Offset = "0x40461E0", VA = "0x184046FE0")]
	public static string GOGNAPBDLJC(byte[] POCBBJNICOK, bool NLKNEOPMNBJ)
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
		[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
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
