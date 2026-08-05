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
		public AmplitudeAnalyticsClient.Settings KHMAJHELMFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JPMDEKLPEJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4C0160", Offset = "0x4BF560", VA = "0x1804C0160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC2FB20", Offset = "0xC2EF20", VA = "0x180C2FB20")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum IPKOLDEMDHO
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class HJPKCAKMHAM
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class OKIOIJMEHDA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public int HJAGGPJHEMO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public Dictionary<string, object> HNFPNNHKEFI;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
				public OKIOIJMEHDA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class JNEKMEIDKBI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
				public JNEKMEIDKBI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x434BAC0", Offset = "0x434AEC0", VA = "0x18434BAC0")]
				internal bool <GetBatch>b__0(OKIOIJMEHDA item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private const string LGALMMBCHPI = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string OLPGJIKLBAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<OKIOIJMEHDA> LEGKJEPGEDN;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? IKKFBEAGADG
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x434AB20", Offset = "0x4349F20", VA = "0x18434AB20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? KHMELGBOGJF
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x434B030", Offset = "0x434A430", VA = "0x18434B030")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x434B8D0", Offset = "0x434ACD0", VA = "0x18434B8D0")]
			internal HJPKCAKMHAM(string FJFNJGHCFKL, string ICCFEEKCADA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x434B770", Offset = "0x434AB70", VA = "0x18434B770")]
			public int OMPAHLCPPJF([Optional] int? HMNAIKNCPPO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x434B0E0", Offset = "0x434A4E0", VA = "0x18434B0E0")]
			public List<Dictionary<string, object>> LECCJGDGOBI(int AJLDKMDPJHI, int? HMNAIKNCPPO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x434B3D0", Offset = "0x434A7D0", VA = "0x18434B3D0")]
			public void LPAPNGNBGCL(AmplitudeAnalyticsIdentifyMessage IIGCLEONCAM, bool MDGOINEPCJI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x434B2E0", Offset = "0x434A6E0", VA = "0x18434B2E0")]
			public void LPAPNGNBGCL(Dictionary<string, object> IIGCLEONCAM, bool MDGOINEPCJI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x434AF00", Offset = "0x434A300", VA = "0x18434AF00")]
			public void GALEBLGCFJN(params Dictionary<string, object>[] LEOCDBGPLFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x434ABB0", Offset = "0x4349FB0", VA = "0x18434ABB0")]
			public void EMLIBDIJLHD(List<Dictionary<string, object>> KOFPBOJGPAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x434B470", Offset = "0x434A870", VA = "0x18434B470")]
			private void NCLDEHBEGCH(Dictionary<string, object> IIGCLEONCAM, bool MDGOINEPCJI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x434B580", Offset = "0x434A980", VA = "0x18434B580")]
			public void OMOLPPCAOIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x434A750", Offset = "0x4349B50", VA = "0x18434A750")]
			private void BCKCHGKNAPM([Optional] string EKFIDIOHCHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x434ADD0", Offset = "0x434A1D0", VA = "0x18434ADD0")]
			private static string FFPEKGDPGMH(string IFBOOLFAOLF, string NDLDFCGGHEC)
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
			[Cpp2IlInjected.Address(RVA = "0x434DB40", Offset = "0x434CF40", VA = "0x18434DB40")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct LGDKACJBAIO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int CJGMAFNLBMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public string KOKGACDOHGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T MLIFDKEHGHP;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class NHLGPDCKAHB : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private LEPJMEIDDOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
			[DebuggerHidden]
			public NHLGPDCKAHB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x434C990", Offset = "0x434BD90", VA = "0x18434C990", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x434D0B0", Offset = "0x434C4B0", VA = "0x18434D0B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class MOHEDLNBPFL : IEnumerator<object>, IEnumerator, IDisposable
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
			public HHHMAENMOAP quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
			[DebuggerHidden]
			public MOHEDLNBPFL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x434C860", Offset = "0x434BC60", VA = "0x18434C860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x434C940", Offset = "0x434BD40", VA = "0x18434C940", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KODGMEKEFLL : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
			[DebuggerHidden]
			public KODGMEKEFLL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x434BB20", Offset = "0x434AF20", VA = "0x18434BB20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x434BC60", Offset = "0x434B060", VA = "0x18434BC60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GJCJIOFKKDN : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private LEPJMEIDDOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
			[DebuggerHidden]
			public GJCJIOFKKDN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x434A3E0", Offset = "0x43497E0", VA = "0x18434A3E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x434A620", Offset = "0x4349A20", VA = "0x18434A620", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class PKMHOPIBPEB : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private LEPJMEIDDOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
			[DebuggerHidden]
			public PKMHOPIBPEB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x434D790", Offset = "0x434CB90", VA = "0x18434D790", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x434D9D0", Offset = "0x434CDD0", VA = "0x18434D9D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class LIAOPBKHMDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public HJPKCAKMHAM cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
			public LIAOPBKHMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x434C290", Offset = "0x434B690", VA = "0x18434C290")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x434C330", Offset = "0x434B730", VA = "0x18434C330")]
			internal void <FlushFromCache>b__1(LGDKACJBAIO<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class OILMMFJAKGB : IEnumerator<LEPJMEIDDOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private LEPJMEIDDOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public HJPKCAKMHAM cache;

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
			private LIAOPBKHMDD <>8__1;

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
			private LEPJMEIDDOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6A4230", Offset = "0x6A3630", VA = "0x1806A4230")]
			[DebuggerHidden]
			public OILMMFJAKGB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x434D100", Offset = "0x434C500", VA = "0x18434D100", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x434D740", Offset = "0x434CB40", VA = "0x18434D740", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class ELKPMDINFIC<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
			public ELKPMDINFIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x26A8080", Offset = "0x26A7480", VA = "0x1826A8080")]
			internal LGDKACJBAIO<T> <PostJson>b__0(HGMFIEHGCAP postResponse)
			{
				return default(LGDKACJBAIO<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private EKLHCLEIIBP OFNPFHDEOJC;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string AHBJEMMNNFP = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string KKJJDPBHGBF = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string GDCOPBLEHPP = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string NFIFPEFIAAF = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string FPAMPOAEPNF = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int KLIOFBHAOMI = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int FOJBIMJIIHG = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int CCFKFIOHPIK = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float FLIFHPEEAOO = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long CKHFOIPPMJO = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string AIJPDIOALGD = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static bool OGPAIPLIKHE;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool FJNJGOLMHKE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static int HICHDPHGMMI;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int CIPKNFKAFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private GGFHDLENIFA NLKGBKIAAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool KDGKBIEBJNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float OPMGKILPKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float PLENNGOGICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int HJINFMMBPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int BFEMLHHOPGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int? OOGNMHJNKLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? FFOMFODCNNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private long IAHKEAOBHFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string JDNALLPMGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long NGCALLHCFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, object> HLMPMLDJMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private IPKOLDEMDHO IFINIJICPJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int JMKLDKNAGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int IOMOHJCKLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float PELPJFKDOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool BNBNKACDGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool EBNEOMMKPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private HJPKCAKMHAM AGENOOBJBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private HJPKCAKMHAM LCDOCHNAIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private HJPKCAKMHAM HOHFEMHCCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> HKKJEGNNIPM;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo BDMJJPHAEAP;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static string ECLFNGDHPMP;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string OAFAOBKKHBE = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string JNPGGPEGAJE = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private EKLHCLEIIBP FDOKIFMMDLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x4346470", Offset = "0x4345870", VA = "0x184346470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int JFCNLCADFOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x43479E0", Offset = "0x4346DE0", VA = "0x1843479E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long POFDKBIHGHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x4349220", Offset = "0x4348620", VA = "0x184349220")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x4349320", Offset = "0x4348720", VA = "0x184349320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string NNLOCFFEDFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x43491F0", Offset = "0x43485F0", VA = "0x1843491F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string LBBNIDNMNEB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4E3950", Offset = "0x4E2D50", VA = "0x1804E3950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x4D1A40", Offset = "0x4D0E40", VA = "0x1804D1A40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool NKMOKCKKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x599360", Offset = "0x598760", VA = "0x180599360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xF2E000", Offset = "0xF2D400", VA = "0x180F2E000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool GPLOMIMJFHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4349110", Offset = "0x4348510", VA = "0x184349110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> DJGOCOFHKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4349070", Offset = "0x4348470", VA = "0x184349070")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4349280", Offset = "0x4348680", VA = "0x184349280")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4346010", Offset = "0x4345410", VA = "0x184346010", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4348B00", Offset = "0x4347F00", VA = "0x184348B00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4348260", Offset = "0x4347660", VA = "0x184348260", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4348C80", Offset = "0x4348080", VA = "0x184348C80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x43482E0", Offset = "0x43476E0", VA = "0x1843482E0")]
		public IDJKGJMBBAG PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4347230", Offset = "0x4346630", VA = "0x184347230")]
		[IteratorStateMachine(typeof(NHLGPDCKAHB))]
		public IEnumerator<LEPJMEIDDOC> Initialize(AmplitudeAnalyticsEvent KKJGMINGADI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4348BD0", Offset = "0x4347FD0", VA = "0x184348BD0")]
		public void UpdateLastAliveTime(float LCHKCIIAGPH = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4346B40", Offset = "0x4345F40", VA = "0x184346B40")]
		private IDJKGJMBBAG HHGBDGNNPKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4348040", Offset = "0x4347440", VA = "0x184348040")]
		private IDJKGJMBBAG ONJMMAGPKBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4348790", Offset = "0x4347B90", VA = "0x184348790")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4347C70", Offset = "0x4347070", VA = "0x184347C70")]
		[IteratorStateMachine(typeof(MOHEDLNBPFL))]
		private IEnumerator MFLKCLFFJJF(HHHMAENMOAP PHNPBMCPFII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4348EE0", Offset = "0x43482E0", VA = "0x184348EE0")]
		[IteratorStateMachine(typeof(KODGMEKEFLL))]
		public IEnumerator WaitForFlush(float KFALLJEGFEJ = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4348B10", Offset = "0x4347F10", VA = "0x184348B10")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4346F40", Offset = "0x4346340", VA = "0x184346F40")]
		public static HFMAGJHOJGB Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4345ED0", Offset = "0x43452D0", VA = "0x184345ED0")]
		public static DIEPNHIGPEN AccountSelectionPostLoginEvent([NotNull] string GOGOBEKMOBM, string OACINMLPKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4346940", Offset = "0x4345D40", VA = "0x184346940")]
		public static DIEPNHIGPEN Event([NotNull] string GOGOBEKMOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4348360", Offset = "0x4347760", VA = "0x184348360")]
		public static DIEPNHIGPEN PreviousSessionEvent([NotNull] string GOGOBEKMOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4347080", Offset = "0x4346480", VA = "0x184347080")]
		public static DIEPNHIGPEN InitializeEvent(string OACINMLPKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x43488A0", Offset = "0x4347CA0", VA = "0x1843488A0")]
		public static DIEPNHIGPEN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4346540", Offset = "0x4345940", VA = "0x184346540")]
		public static DIEPNHIGPEN CreateOutOfSessionEvent(string GOGOBEKMOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4347670", Offset = "0x4346A70", VA = "0x184347670")]
		public static IDJKGJMBBAG LogOutOfSessionEvent(DIEPNHIGPEN HFHGKPCIBAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x43474C0", Offset = "0x43468C0", VA = "0x1843474C0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LOKOKOAAHDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4347840", Offset = "0x4346C40", VA = "0x184347840")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LOKOKOAAHDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4347910", Offset = "0x4346D10", VA = "0x184347910")]
		public void LogSerializedEventAsync(Dictionary<string, object> KGBPKFGFIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4347590", Offset = "0x4346990", VA = "0x184347590")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage BGCFEFCBBNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x43468A0", Offset = "0x4345CA0", VA = "0x1843468A0")]
		private void EKCMJCJJODL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x43472A0", Offset = "0x43466A0", VA = "0x1843472A0")]
		private void JMICMOHEHEJ(Dictionary<string, object> BFCCINGLGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4346E60", Offset = "0x4346260", VA = "0x184346E60")]
		private void IJDLGHFCAIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4347EB0", Offset = "0x43472B0", VA = "0x184347EB0")]
		private void NDFGGJEAHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4346AB0", Offset = "0x4345EB0", VA = "0x184346AB0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4347E40", Offset = "0x4347240", VA = "0x184347E40")]
		[IteratorStateMachine(typeof(GJCJIOFKKDN))]
		private IEnumerator<LEPJMEIDDOC> NDEOALJFEAL(float KFALLJEGFEJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4347C00", Offset = "0x4347000", VA = "0x184347C00")]
		[IteratorStateMachine(typeof(PKMHOPIBPEB))]
		private IEnumerator<LEPJMEIDDOC> MDGDMKKBFNH(float KFALLJEGFEJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x43467F0", Offset = "0x4345BF0", VA = "0x1843467F0")]
		[IteratorStateMachine(typeof(OILMMFJAKGB))]
		private IEnumerator<LEPJMEIDDOC> DBKMIFCMIFN(HJPKCAKMHAM OENDHLMDJIC, int? HMNAIKNCPPO, string HJMHICIJPJH, string KCIJLKHIENK, float KFALLJEGFEJ, Action<int> BCHLECPOPLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4346D20", Offset = "0x4346120", VA = "0x184346D20")]
		private static void HKHGPEGDEIK(bool CNPNALPFECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x22BD870", Offset = "0x22BCC70", VA = "0x1822BD870")]
		private global::PMGAAIBIJNM<LGDKACJBAIO<T>> PPPDNHKKINN<T>(string HJMHICIJPJH, string KCIJLKHIENK, string HLOHFAHPMHB, T MLIFDKEHGHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4346E10", Offset = "0x4346210", VA = "0x184346E10")]
		private bool IDOMGFACDNM(float EBNOFDOOLAP, float KFALLJEGFEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4348FB0", Offset = "0x43483B0", VA = "0x184348FB0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4347CE0", Offset = "0x43470E0", VA = "0x184347CE0")]
		[CompilerGenerated]
		private long MPCDHMBEJOC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4346AA0", Offset = "0x4345EA0", VA = "0x184346AA0")]
		[CompilerGenerated]
		private void FHCBNEKBLEB(int HAHMCDDHGFF)
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
			[Cpp2IlInjected.Address(RVA = "0x4C6310", Offset = "0x4C5710", VA = "0x1804C6310")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4349630", Offset = "0x4348A30", VA = "0x184349630")]
		public static DIEPNHIGPEN IDOEMBPAOBJ(string DFOADPEAOBI, [NotNull] string HDPMJIKCOED, long DEBJJFFLMNL, long FGCPDNHDIGB, string OACINMLPKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4349710", Offset = "0x4348B10", VA = "0x184349710")]
		public static DIEPNHIGPEN LMJFNGKAPGB(string DFOADPEAOBI, [NotNull] string HDPMJIKCOED, long DEBJJFFLMNL, long FGCPDNHDIGB, string OACINMLPKJB, long GCEEMBFGKBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4349910", Offset = "0x4348D10", VA = "0x184349910")]
		private AmplitudeAnalyticsEvent(string DFOADPEAOBI, [NotNull] string HDPMJIKCOED, long DEBJJFFLMNL, long FGCPDNHDIGB, string OACINMLPKJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x536D00", Offset = "0x536100", VA = "0x180536D00")]
		public void EIMKCMHEGHP(long PBGJIEMKFHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4349800", Offset = "0x4348C00", VA = "0x184349800", Slot = "5")]
		public override void ODPKEIHNDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4349380", Offset = "0x4348780", VA = "0x184349380", Slot = "6")]
		public override void BEMODDEIHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x43493F0", Offset = "0x43487F0", VA = "0x1843493F0", Slot = "4")]
		protected override Dictionary<string, object> EFIOPFEANEJ(Dictionary<string, object> OEEGNDDCEBD)
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
			[Cpp2IlInjected.Address(RVA = "0x434A2C0", Offset = "0x43496C0", VA = "0x18434A2C0")]
			public void CBBGGHLEHOI(Dictionary<string, object> LGCCGDFHOGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x434DA20", Offset = "0x434CE20", VA = "0x18434DA20")]
			public void CBBGGHLEHOI(Dictionary<string, object> IDGBFHOOLDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x147C740", Offset = "0x147BB40", VA = "0x18147C740")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BF5A0", VA = "0x1804C01A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4C0440", Offset = "0x4BF840", VA = "0x1804C0440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4349E20", Offset = "0x4349220", VA = "0x184349E20")]
		public static HFMAGJHOJGB IDOEMBPAOBJ(string DFOADPEAOBI, string OACINMLPKJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4349FD0", Offset = "0x43493D0", VA = "0x184349FD0")]
		protected AmplitudeAnalyticsIdentifyMessage(string DFOADPEAOBI, string OACINMLPKJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4349B70", Offset = "0x4348F70", VA = "0x184349B70")]
		public Dictionary<string, object> CPLAOFMAPJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4349BE0", Offset = "0x4348FE0", VA = "0x184349BE0", Slot = "4")]
		protected virtual Dictionary<string, object> EFIOPFEANEJ(Dictionary<string, object> OEEGNDDCEBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4349EC0", Offset = "0x43492C0", VA = "0x184349EC0")]
		protected void KLGLCDLMDAK(string NDLDFCGGHEC, Dictionary<string, object> LKODALFPHKB, Dictionary<string, object> LKJHCFJJENL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4349A90", Offset = "0x4348E90", VA = "0x184349A90")]
		protected void AHNMPOLLOGA(string NDLDFCGGHEC, string IFBOOLFAOLF, Dictionary<string, object> IKENGKNKGEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4349F60", Offset = "0x4349360", VA = "0x184349F60", Slot = "5")]
		public virtual void ODPKEIHNDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4349B00", Offset = "0x4348F00", VA = "0x184349B00", Slot = "6")]
		public virtual void BEMODDEIHMK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HFMAGJHOJGB : global::HNCCEOMGMHH<AmplitudeAnalyticsIdentifyMessage, HFMAGJHOJGB>
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override HFMAGJHOJGB CENLGGPOEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5519A0", Offset = "0x550DA0", VA = "0x1805519A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BF5A0", VA = "0x1804C01A0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage EOFFFJKFAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x434A700", Offset = "0x4349B00", VA = "0x18434A700")]
	public HFMAGJHOJGB(AmplitudeAnalyticsIdentifyMessage KHBKGOENEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x434A670", Offset = "0x4349A70", VA = "0x18434A670", Slot = "4")]
	public override void BEMODDEIHMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DIEPNHIGPEN : global::HNCCEOMGMHH<AmplitudeAnalyticsEvent, DIEPNHIGPEN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool DIGOCNHFJHN;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override DIEPNHIGPEN CENLGGPOEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5519A0", Offset = "0x550DA0", VA = "0x1805519A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x434A270", Offset = "0x4349670", VA = "0x18434A270")]
	public DIEPNHIGPEN(AmplitudeAnalyticsEvent KHBKGOENEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BF5A0", VA = "0x1804C01A0", Slot = "5")]
	public override AmplitudeAnalyticsEvent EOFFFJKFAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x434A070", Offset = "0x4349470", VA = "0x18434A070", Slot = "4")]
	public override void BEMODDEIHMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1B834E0", Offset = "0x1B828E0", VA = "0x181B834E0")]
	public DIEPNHIGPEN NBBNBPCIFIC<T>(string KJPNHGOLMME, T[] IFBOOLFAOLF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x434A1F0", Offset = "0x43495F0", VA = "0x18434A1F0")]
	public DIEPNHIGPEN NBBNBPCIFIC(string KJPNHGOLMME, string[] IFBOOLFAOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1B83470", Offset = "0x1B82870", VA = "0x181B83470")]
	public DIEPNHIGPEN NBBNBPCIFIC<T>(string KJPNHGOLMME, T IFBOOLFAOLF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x434A200", Offset = "0x4349600", VA = "0x18434A200")]
	public DIEPNHIGPEN NBBNBPCIFIC(string KJPNHGOLMME, string IFBOOLFAOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x434A110", Offset = "0x4349510", VA = "0x18434A110")]
	private DIEPNHIGPEN EPPBDMAKKJP(string KJPNHGOLMME, object IFBOOLFAOLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LNEGNLKHAAM : DIEPNHIGPEN
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x434A270", Offset = "0x4349670", VA = "0x18434A270")]
	public LNEGNLKHAAM(AmplitudeAnalyticsEvent KHBKGOENEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x434C730", Offset = "0x434BB30", VA = "0x18434C730", Slot = "4")]
	public override void BEMODDEIHMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class HNCCEOMGMHH<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::HNCCEOMGMHH<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	protected M KHBKGOENEMD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public abstract BLDR CENLGGPOEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x20D7170", Offset = "0x20D6570", VA = "0x1820D7170")]
	public HNCCEOMGMHH(M KHBKGOENEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2897E40", Offset = "0x2897240", VA = "0x182897E40")]
	public BLDR ACBLPGMCGCM(AmplitudeAnalyticsIdentifyMessage.DeviceInfo CDLAFENCENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2897F50", Offset = "0x2897350", VA = "0x182897F50")]
	public BLDR IKPAALKGOCD(AmplitudeAnalyticsIdentifyMessage.RevenueData FHAEFJNFNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2897FB0", Offset = "0x28973B0", VA = "0x182897FB0")]
	public BLDR PGGKDAPMGFL(string KJPNHGOLMME, string IFBOOLFAOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1B88950", Offset = "0x1B87D50", VA = "0x181B88950")]
	public BLDR PGGKDAPMGFL<T>(string KJPNHGOLMME, T IFBOOLFAOLF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BEMODDEIHMK();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2897F80", Offset = "0x2897380", VA = "0x182897F80")]
	internal static string LEJIILKJEKP(string IFBOOLFAOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2897E70", Offset = "0x2897270", VA = "0x182897E70")]
	private BLDR AIAFPMEDNLM(string KJPNHGOLMME, object IFBOOLFAOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M EOFFFJKFAAP();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class IMLDNDGGMBN
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int BBHLDFLKEKD = 2;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int KJOBGIGPLML = 100;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const int GMPKHIFGJBA = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const long DACKDDKNDPA = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int NOJILPPKFJH = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const int KKDJOCJIIBE = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string COKJHGODKBG = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string DDCMHPKLNDD = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string NIDGPIEKBNI = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string CMDGIHPFLBB = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string CDKKLBEAIDG = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string KLHJEOFBHCG = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string DBNONCNPGHN = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const string DNODMLPKEEM = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public const int BCODHOFFCLN = 10;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> BIFOIDDFFEC;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
	public IMLDNDGGMBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GGFHDLENIFA
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string LCPCHHNKFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string GHJJHKDKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string BPIBBONIKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::PMGAAIBIJNM<HGMFIEHGCAP> PPPDNHKKINN(string HJMHICIJPJH, Dictionary<string, string> FGAFOENBPPO);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct HGMFIEHGCAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly int AEIJNBEKLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly string LMCPFFDBJNC;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4C88C0", Offset = "0x4C7CC0", VA = "0x1804C88C0")]
	public HGMFIEHGCAP(int CJGMAFNLBMH, string KOKGACDOHGF)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LFKMCGFPHOI
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static byte[] OOHBEGEHNOI;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int BNIOKLHNMMG;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int CGJHMHBADGI;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static BigInteger ADAGEDNPLLD;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
	public LFKMCGFPHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x434BFE0", Offset = "0x434B3E0", VA = "0x18434BFE0")]
	private static string KKMKMKDJDIC(byte[] IHCAKNPGPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x434BCB0", Offset = "0x434B0B0", VA = "0x18434BCB0")]
	public static string CIJBPMJKAHN(byte[] CBCDDOHAMCB, bool PPCELFHNGKH)
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
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
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
