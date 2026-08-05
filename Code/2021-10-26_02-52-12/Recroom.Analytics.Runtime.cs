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
		[Cpp2IlInjected.Address(RVA = "0x4B6B60", Offset = "0x4B5D60", VA = "0x1804B6B60")]
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
				[Cpp2IlInjected.Address(RVA = "0x406B510", Offset = "0x406A710", VA = "0x18406B510")]
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
				[Cpp2IlInjected.Address(RVA = "0x40697C0", Offset = "0x40689C0", VA = "0x1840697C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? IEDIIIFCOAE
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x40694B0", Offset = "0x40686B0", VA = "0x1840694B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x4069F00", Offset = "0x4069100", VA = "0x184069F00")]
			internal DILCEOGKLON(string JNJFMLLEPFK, string KHOGLOJMKLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x4069350", Offset = "0x4068550", VA = "0x184069350")]
			public int FGPFKDDNONB([Optional] int? KIABOKGMOME)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4069150", Offset = "0x4068350", VA = "0x184069150")]
			public List<Dictionary<string, object>> FAHLMKFABIL(int IHEDEKBABCK, int? KIABOKGMOME)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4069A70", Offset = "0x4068C70", VA = "0x184069A70")]
			public void KGJFIGHDPJJ(AmplitudeAnalyticsIdentifyMessage LBCPAPMBFKI, bool DCPFDDPMHOI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4069B10", Offset = "0x4068D10", VA = "0x184069B10")]
			public void KGJFIGHDPJJ(Dictionary<string, object> LBCPAPMBFKI, bool DCPFDDPMHOI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4069690", Offset = "0x4068890", VA = "0x184069690")]
			public void FPDAMAGMBDJ(params Dictionary<string, object>[] CINHCENDLEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4069850", Offset = "0x4068A50", VA = "0x184069850")]
			public void IJMBJDFNBIF(List<Dictionary<string, object>> BAFNBIOGEON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4069DF0", Offset = "0x4068FF0", VA = "0x184069DF0")]
			private void OCCKDJMBLBF(Dictionary<string, object> LBCPAPMBFKI, bool DCPFDDPMHOI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4069C00", Offset = "0x4068E00", VA = "0x184069C00")]
			public void OBBKGOIDCLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4068D80", Offset = "0x4067F80", VA = "0x184068D80")]
			private void DCHDNOOGIEK([Optional] string LMPLKNNAFNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4069560", Offset = "0x4068760", VA = "0x184069560")]
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
			[Cpp2IlInjected.Address(RVA = "0x406BEB0", Offset = "0x406B0B0", VA = "0x18406BEB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x406A170", Offset = "0x4069370", VA = "0x18406A170", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x406A890", Offset = "0x4069A90", VA = "0x18406A890", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x406AE10", Offset = "0x406A010", VA = "0x18406AE10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x406AEE0", Offset = "0x406A0E0", VA = "0x18406AEE0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x406BC00", Offset = "0x406AE00", VA = "0x18406BC00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x406BD40", Offset = "0x406AF40", VA = "0x18406BD40", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x40684D0", Offset = "0x40676D0", VA = "0x1840684D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4068710", Offset = "0x4067910", VA = "0x184068710", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x406A8E0", Offset = "0x4069AE0", VA = "0x18406A8E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x406AB20", Offset = "0x4069D20", VA = "0x18406AB20", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x40688E0", Offset = "0x4067AE0", VA = "0x1840688E0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4068980", Offset = "0x4067B80", VA = "0x184068980")]
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
			[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x406B570", Offset = "0x406A770", VA = "0x18406B570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x406BBB0", Offset = "0x406ADB0", VA = "0x18406BBB0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
			public GICFBFODIMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x270F6D0", Offset = "0x270E8D0", VA = "0x18270F6D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4064BF0", Offset = "0x4063DF0", VA = "0x184064BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int MIGCPDMPJCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x4065560", Offset = "0x4064760", VA = "0x184065560")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long EJMBABOGAHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x40675A0", Offset = "0x40667A0", VA = "0x1840675A0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x40676A0", Offset = "0x40668A0", VA = "0x1840676A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string PPNHJMPCFKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x4067570", Offset = "0x4066770", VA = "0x184067570")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D8570", Offset = "0x4D7770", VA = "0x1804D8570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5E4B30", Offset = "0x5E3D30", VA = "0x1805E4B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool HLGECACFECE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4067490", Offset = "0x4066690", VA = "0x184067490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> GAHNHOGIIJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x40673F0", Offset = "0x40665F0", VA = "0x1840673F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4067600", Offset = "0x4066800", VA = "0x184067600")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4064560", Offset = "0x4063760", VA = "0x184064560", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4066E80", Offset = "0x4066080", VA = "0x184066E80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4066660", Offset = "0x4065860", VA = "0x184066660", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4067000", Offset = "0x4066200", VA = "0x184067000")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4065CD0", Offset = "0x4064ED0", VA = "0x184065CD0")]
		private bool LNOAIMBGFNI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4065A70", Offset = "0x4064C70", VA = "0x184065A70")]
		[IteratorStateMachine(typeof(EJLMNAMKAMJ))]
		public IEnumerator<GGOLJFPNLLB> Initialize(AmplitudeAnalyticsEvent JAPGNPCNBGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4066F50", Offset = "0x4066150", VA = "0x184066F50")]
		public void UpdateLastAliveTime(float DAOMFMAJIKO = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x40653F0", Offset = "0x40645F0", VA = "0x1840653F0")]
		private bool GNPHLGMPEKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4066260", Offset = "0x4065460", VA = "0x184066260")]
		private bool NALFFFGOBOF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4066B10", Offset = "0x4065D10", VA = "0x184066B10")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4065AE0", Offset = "0x4064CE0", VA = "0x184065AE0")]
		[IteratorStateMachine(typeof(JBGDBNJNAMG))]
		private IEnumerator JFMPCNCCHDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4067260", Offset = "0x4066460", VA = "0x184067260")]
		[IteratorStateMachine(typeof(MHNLOEHMEEA))]
		public IEnumerator WaitForFlush(float GDAMCIMKMPM = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4066E90", Offset = "0x4066090", VA = "0x184066E90")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4065780", Offset = "0x4064980", VA = "0x184065780")]
		public static BELGKGDIHGK Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4064420", Offset = "0x4063620", VA = "0x184064420")]
		public static GNHCPNHCEPN AccountSelectionPostLoginEvent([NotNull] string APJILFAGILJ, string CFBGAIKCKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4064FC0", Offset = "0x40641C0", VA = "0x184064FC0")]
		public static GNHCPNHCEPN Event([NotNull] string APJILFAGILJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x40666E0", Offset = "0x40658E0", VA = "0x1840666E0")]
		public static GNHCPNHCEPN PreviousSessionEvent([NotNull] string APJILFAGILJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x40658C0", Offset = "0x4064AC0", VA = "0x1840658C0")]
		public static GNHCPNHCEPN InitializeEvent(string CFBGAIKCKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4066C20", Offset = "0x4065E20", VA = "0x184066C20")]
		public static GNHCPNHCEPN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4064D10", Offset = "0x4063F10", VA = "0x184064D10")]
		public static GNHCPNHCEPN CreateOutOfSessionEvent(string APJILFAGILJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4065EE0", Offset = "0x40650E0", VA = "0x184065EE0")]
		public static NIIPAOBAIGP LogOutOfSessionEvent(GNHCPNHCEPN BKEDKACGODI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4065D30", Offset = "0x4064F30", VA = "0x184065D30")]
		public void LogEventAsync(AmplitudeAnalyticsEvent JNBBDNDAPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x40660B0", Offset = "0x40652B0", VA = "0x1840660B0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent JNBBDNDAPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4066180", Offset = "0x4065380", VA = "0x184066180")]
		public void LogSerializedEventAsync(Dictionary<string, object> AOKOPCLNOAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4065E00", Offset = "0x4065000", VA = "0x184065E00")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage KHHFFPCHMPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4064380", Offset = "0x4063580", VA = "0x184064380")]
		private void AKJGDNDHOPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4066440", Offset = "0x4065640", VA = "0x184066440")]
		private void ONCDGIBHILE(Dictionary<string, object> HGLLNMEHECP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4065310", Offset = "0x4064510", VA = "0x184065310")]
		private void GDCKJOKGKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4065B40", Offset = "0x4064D40", VA = "0x184065B40")]
		private void KBNDFCNNDIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4065280", Offset = "0x4064480", VA = "0x184065280")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4064310", Offset = "0x4063510", VA = "0x184064310")]
		[IteratorStateMachine(typeof(BFKFNPHDFCA))]
		private IEnumerator<GGOLJFPNLLB> AJJBNCELEFF(float GDAMCIMKMPM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4065210", Offset = "0x4064410", VA = "0x184065210")]
		[IteratorStateMachine(typeof(GEKKPKEIAKD))]
		private IEnumerator<GGOLJFPNLLB> FCKHPBOCBGM(float GDAMCIMKMPM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4064B40", Offset = "0x4063D40", VA = "0x184064B40")]
		[IteratorStateMachine(typeof(LOEOBLBNNIJ))]
		private IEnumerator<GGOLJFPNLLB> BGOOKPNOIEM(DILCEOGKLON IJKHLKJCCGE, int? KIABOKGMOME, string EAJJGBMOEEP, string HGPJGBDBKAB, float GDAMCIMKMPM, Action<int> BOIKBAGGNOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4065120", Offset = "0x4064320", VA = "0x184065120")]
		private static void FBANDLOHJLB(bool LOKJOKNALIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2067610", Offset = "0x2066810", VA = "0x182067610")]
		private global::IJNOJIGJDDE<HDGCJNNILOO<T>> ELGADCCMICE<T>(string EAJJGBMOEEP, string HGPJGBDBKAB, string MOHOJKNHHEN, T DAPNLLCMIGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4064CC0", Offset = "0x4063EC0", VA = "0x184064CC0")]
		private bool CDNJGANNMKK(float NPMPGFDNGOJ, float GDAMCIMKMPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4067330", Offset = "0x4066530", VA = "0x184067330")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x40649E0", Offset = "0x4063BE0", VA = "0x1840649E0")]
		[CompilerGenerated]
		private long BBIFJMAAMAC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4066250", Offset = "0x4065450", VA = "0x184066250")]
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
		[Cpp2IlInjected.Address(RVA = "0x4067700", Offset = "0x4066900", VA = "0x184067700")]
		public static GNHCPNHCEPN BAHAJJMALOP(string ALLGOKCDAJA, [NotNull] string DIIEKDHPJEI, long CPMOBPNHPJE, long HCDIDJBBBJB, string CFBGAIKCKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x40677E0", Offset = "0x40669E0", VA = "0x1840677E0")]
		public static GNHCPNHCEPN CPKLIIMCNLM(string ALLGOKCDAJA, [NotNull] string DIIEKDHPJEI, long CPMOBPNHPJE, long HCDIDJBBBJB, string CFBGAIKCKAN, long IFGBIADJFOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4067C90", Offset = "0x4066E90", VA = "0x184067C90")]
		private AmplitudeAnalyticsEvent(string ALLGOKCDAJA, [NotNull] string DIIEKDHPJEI, long CPMOBPNHPJE, long HCDIDJBBBJB, string CFBGAIKCKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4F8100", Offset = "0x4F7300", VA = "0x1804F8100")]
		public void MFGAOKAKEJN(long KLJOMHGCAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x40678D0", Offset = "0x4066AD0", VA = "0x1840678D0", Slot = "5")]
		public override void HKCDBBIHBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4067C20", Offset = "0x4066E20", VA = "0x184067C20", Slot = "6")]
		public override void OLOPMJIPFIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x40679E0", Offset = "0x4066BE0", VA = "0x1840679E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x406A050", Offset = "0x4069250", VA = "0x18406A050")]
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
			[Cpp2IlInjected.Address(RVA = "0x406BD90", Offset = "0x406AF90", VA = "0x18406BD90")]
			public void CEHGHKNFHLO(Dictionary<string, object> LGGOMHLNCKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x11004C0", Offset = "0x10FF6C0", VA = "0x1811004C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4067E10", Offset = "0x4067010", VA = "0x184067E10")]
		public static BELGKGDIHGK BAHAJJMALOP(string ALLGOKCDAJA, string CFBGAIKCKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4068350", Offset = "0x4067550", VA = "0x184068350")]
		protected AmplitudeAnalyticsIdentifyMessage(string ALLGOKCDAJA, string CFBGAIKCKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4067EB0", Offset = "0x40670B0", VA = "0x184067EB0")]
		public Dictionary<string, object> BJJJDPGOLLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4067F90", Offset = "0x4067190", VA = "0x184067F90", Slot = "4")]
		protected virtual Dictionary<string, object> OBOPMJCLODK(Dictionary<string, object> EFCLDBKLCNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x40681D0", Offset = "0x40673D0", VA = "0x1840681D0")]
		protected void OBPCPGEBEKL(string KPLFFOGJEBN, Dictionary<string, object> BKAJMIBEGAG, Dictionary<string, object> BBDANNINBIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x40682E0", Offset = "0x40674E0", VA = "0x1840682E0")]
		protected void PLFBIJJCPOG(string KPLFFOGJEBN, string DIDEMEECIEC, Dictionary<string, object> JFMADAPBOKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4067F20", Offset = "0x4067120", VA = "0x184067F20", Slot = "5")]
		public virtual void HKCDBBIHBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4068270", Offset = "0x4067470", VA = "0x184068270", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B9650", Offset = "0x4B8850", VA = "0x1804B9650", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x4068480", Offset = "0x4067680", VA = "0x184068480")]
	public BELGKGDIHGK(AmplitudeAnalyticsIdentifyMessage MMMNDCGJHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x40683F0", Offset = "0x40675F0", VA = "0x1840683F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B9650", Offset = "0x4B8850", VA = "0x1804B9650", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4068890", Offset = "0x4067A90", VA = "0x184068890")]
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
	[Cpp2IlInjected.Address(RVA = "0x406ACD0", Offset = "0x4069ED0", VA = "0x18406ACD0", Slot = "4")]
	public override void OLOPMJIPFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	public GNHCPNHCEPN BPNEOOBGEOP<T>(string ILHKAMEPJFJ, T[] DIDEMEECIEC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x406AB70", Offset = "0x4069D70", VA = "0x18406AB70")]
	public GNHCPNHCEPN BPNEOOBGEOP(string ILHKAMEPJFJ, string[] DIDEMEECIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x206D820", Offset = "0x206CA20", VA = "0x18206D820")]
	public GNHCPNHCEPN BPNEOOBGEOP<T>(string ILHKAMEPJFJ, T DIDEMEECIEC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x406AB80", Offset = "0x4069D80", VA = "0x18406AB80")]
	public GNHCPNHCEPN BPNEOOBGEOP(string ILHKAMEPJFJ, string DIDEMEECIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x406ABF0", Offset = "0x4069DF0", VA = "0x18406ABF0")]
	private GNHCPNHCEPN OGNBGLAGKPJ(string ILHKAMEPJFJ, object DIDEMEECIEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BMDAKIHDNNF : GNHCPNHCEPN
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4068890", Offset = "0x4067A90", VA = "0x184068890")]
	public BMDAKIHDNNF(AmplitudeAnalyticsEvent MMMNDCGJHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4068760", Offset = "0x4067960", VA = "0x184068760", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x28A6CB0", Offset = "0x28A5EB0", VA = "0x1828A6CB0")]
	public FCNNAJKJHHC(M MMMNDCGJHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x329C5A0", Offset = "0x329B7A0", VA = "0x18329C5A0")]
	public BLDR GLPNPIPKEEJ(AmplitudeAnalyticsIdentifyMessage.DeviceInfo ADKOAHILINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x329C640", Offset = "0x329B840", VA = "0x18329C640")]
	public BLDR KAHCAFJAGHK(AmplitudeAnalyticsIdentifyMessage.RevenueData CLAPLGPGAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x329C5D0", Offset = "0x329B7D0", VA = "0x18329C5D0")]
	public BLDR GMAFDMBIABA(string ILHKAMEPJFJ, string DIDEMEECIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x206B600", Offset = "0x206A800", VA = "0x18206B600")]
	public BLDR GMAFDMBIABA<T>(string ILHKAMEPJFJ, T DIDEMEECIEC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void OLOPMJIPFIM();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x329C750", Offset = "0x329B950", VA = "0x18329C750")]
	internal static string NABDNBADIBC(string DIDEMEECIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x329C670", Offset = "0x329B870", VA = "0x18329C670")]
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
	[Cpp2IlInjected.Address(RVA = "0x406AF30", Offset = "0x406A130", VA = "0x18406AF30")]
	private static string BNMKEPLLJLH(byte[] PADLHGFNBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x406B030", Offset = "0x406A230", VA = "0x18406B030")]
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
