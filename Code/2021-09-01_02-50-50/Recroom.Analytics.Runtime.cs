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
		public AmplitudeAnalyticsClient.Settings DEDGNFDEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4157B0", Offset = "0x4147B0", VA = "0x1804157B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IOMNJOCFLNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4700C0", Offset = "0x46F0C0", VA = "0x1804700C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x428AD0", Offset = "0x427AD0", VA = "0x180428AD0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum KEJFBHKLOMK
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class LGNIKEMIHIE
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class HGEGKDOFHCK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public int MJBHMKLIPHK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public Dictionary<string, object> LCMLLPBFAPJ;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x412370", Offset = "0x411370", VA = "0x180412370")]
				public HGEGKDOFHCK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class ILBENLNNFMN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x412370", Offset = "0x411370", VA = "0x180412370")]
				public ILBENLNNFMN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x3BAFB90", Offset = "0x3BAEB90", VA = "0x183BAFB90")]
				internal bool <GetBatch>b__0(HGEGKDOFHCK item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private const string HBPFDDPGLHD = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string CBCDLMLKBJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<HGEGKDOFHCK> FPBIKLDCIJF;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? CPMPHJGGGPB
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x3BB0CE0", Offset = "0x3BAFCE0", VA = "0x183BB0CE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? LDOCMGKGOOK
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x3BB1730", Offset = "0x3BB0730", VA = "0x183BB1730")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3BB17E0", Offset = "0x3BB07E0", VA = "0x183BB17E0")]
			internal LGNIKEMIHIE(string LFBABEDGCOM, string HPJHNGGCLHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3BB0D70", Offset = "0x3BAFD70", VA = "0x183BB0D70")]
			public int GHICFPNGGOD([Optional] int? MADLMGFMFMN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3BB0880", Offset = "0x3BAF880", VA = "0x183BB0880")]
			public List<Dictionary<string, object>> AHDGOECGFHE(int BBPAOGDGDOI, int? MADLMGFMFMN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3BB1490", Offset = "0x3BB0490", VA = "0x183BB1490")]
			public void MEAKBDKDFKF(AmplitudeAnalyticsIdentifyMessage NLNHFEEMFBN, bool BPPFJEHCKFL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3BB1530", Offset = "0x3BB0530", VA = "0x183BB1530")]
			public void MEAKBDKDFKF(Dictionary<string, object> NLNHFEEMFBN, bool BPPFJEHCKFL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3BB0A80", Offset = "0x3BAFA80", VA = "0x183BB0A80")]
			public void DAKLDLDFDJI(params Dictionary<string, object>[] HHLLJLDFBPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3BB0660", Offset = "0x3BAF660", VA = "0x183BB0660")]
			public void ADOEAIINDBN(List<Dictionary<string, object>> PPPMBOLNNBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3BB1620", Offset = "0x3BB0620", VA = "0x183BB1620")]
			private void MOBOEANLOCA(Dictionary<string, object> NLNHFEEMFBN, bool BPPFJEHCKFL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3BB12A0", Offset = "0x3BB02A0", VA = "0x183BB12A0")]
			public void IGCBDPJHEHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3BB0ED0", Offset = "0x3BAFED0", VA = "0x183BB0ED0")]
			private void IECOIFMKKHC([Optional] string MCFONLFCHFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3BB0BB0", Offset = "0x3BAFBB0", VA = "0x183BB0BB0")]
			private static string FJABICEKMNO(string ONGBFDACHHG, string DNGKIAJLLHG)
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
			[Cpp2IlInjected.Address(RVA = "0x3BB1A50", Offset = "0x3BB0A50", VA = "0x183BB1A50")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct DDAGJMCHCED<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int LMOEMCOMALK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public string HFOCDNIDIBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T PHFDPICANAP;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class FCPECEOLIKP : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private KENFJGFMIPM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x4157B0", Offset = "0x4147B0", VA = "0x1804157B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4157B0", Offset = "0x4147B0", VA = "0x1804157B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x44F040", Offset = "0x44E040", VA = "0x18044F040")]
			[DebuggerHidden]
			public FCPECEOLIKP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4242D0", Offset = "0x4232D0", VA = "0x1804242D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3BAE820", Offset = "0x3BAD820", VA = "0x183BAE820", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3BAEF40", Offset = "0x3BADF40", VA = "0x183BAEF40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class JHKKHMGNLOM : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4157B0", Offset = "0x4147B0", VA = "0x1804157B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4157B0", Offset = "0x4147B0", VA = "0x1804157B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x44F040", Offset = "0x44E040", VA = "0x18044F040")]
			[DebuggerHidden]
			public JHKKHMGNLOM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4242D0", Offset = "0x4232D0", VA = "0x1804242D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3BB0280", Offset = "0x3BAF280", VA = "0x183BB0280", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3BB0350", Offset = "0x3BAF350", VA = "0x183BB0350", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JKKMONDAPLG : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4157B0", Offset = "0x4147B0", VA = "0x1804157B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4157B0", Offset = "0x4147B0", VA = "0x1804157B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x44F040", Offset = "0x44E040", VA = "0x18044F040")]
			[DebuggerHidden]
			public JKKMONDAPLG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4242D0", Offset = "0x4232D0", VA = "0x1804242D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3BB03A0", Offset = "0x3BAF3A0", VA = "0x183BB03A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3BB04E0", Offset = "0x3BAF4E0", VA = "0x183BB04E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DGDCGHAODAJ : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private KENFJGFMIPM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x4157B0", Offset = "0x4147B0", VA = "0x1804157B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4157B0", Offset = "0x4147B0", VA = "0x1804157B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x44F040", Offset = "0x44E040", VA = "0x18044F040")]
			[DebuggerHidden]
			public DGDCGHAODAJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4242D0", Offset = "0x4232D0", VA = "0x1804242D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3BAE470", Offset = "0x3BAD470", VA = "0x183BAE470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3BAE6B0", Offset = "0x3BAD6B0", VA = "0x183BAE6B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class CNCALEMFLHL : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private KENFJGFMIPM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x4157B0", Offset = "0x4147B0", VA = "0x1804157B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4157B0", Offset = "0x4147B0", VA = "0x1804157B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x44F040", Offset = "0x44E040", VA = "0x18044F040")]
			[DebuggerHidden]
			public CNCALEMFLHL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x4242D0", Offset = "0x4232D0", VA = "0x1804242D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3BAE1E0", Offset = "0x3BAD1E0", VA = "0x183BAE1E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3BAE420", Offset = "0x3BAD420", VA = "0x183BAE420", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class HDFEPFLCIBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public LGNIKEMIHIE cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x412370", Offset = "0x411370", VA = "0x180412370")]
			public HDFEPFLCIBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3BAF610", Offset = "0x3BAE610", VA = "0x183BAF610")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3BAF6B0", Offset = "0x3BAE6B0", VA = "0x183BAF6B0")]
			internal void <FlushFromCache>b__1(DDAGJMCHCED<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JCGJOOMFAHF : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private KENFJGFMIPM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public LGNIKEMIHIE cache;

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
			private HDFEPFLCIBG <>8__1;

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
			private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x4157B0", Offset = "0x4147B0", VA = "0x1804157B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4157B0", Offset = "0x4147B0", VA = "0x1804157B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x44F040", Offset = "0x44E040", VA = "0x18044F040")]
			[DebuggerHidden]
			public JCGJOOMFAHF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4242D0", Offset = "0x4232D0", VA = "0x1804242D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x3BAFBF0", Offset = "0x3BAEBF0", VA = "0x183BAFBF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3BB0230", Offset = "0x3BAF230", VA = "0x183BB0230", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class AOFKHJJPJNO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1CC5E40", Offset = "0x1CC4E40", VA = "0x181CC5E40")]
			public AOFKHJJPJNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2422780", Offset = "0x2421780", VA = "0x182422780")]
			internal DDAGJMCHCED<T> <PostJson>b__0(OADHHEBMJOA postResponse)
			{
				return default(DDAGJMCHCED<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private EFEFMHJPJIJ JFMOEGCPNAC;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string NIKNMDJHFNI = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string JJPIMLDMLCG = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string FFJGIJOFDBC = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string JNLGIIEDBOG = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string MFNLINGPFIM = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int EBBOPNEDCPL = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int LMOEOCGHDIG = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int DABDGJMHIEI = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float IPPHCLMLLBG = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long NGIGLEHJPIC = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string AEEDGOKGKEF = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static bool KMOBPHAEFED;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool PMHELGALBGH;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static int CGMCAODNLIP;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int GBAHOIHAADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private MAFPBPHMEIP LNAGPGAJBEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool HHJDFAFFLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float GEEIILBKAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float PMPKLOKJJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int MOMIDOJHPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int HDLGFKBDBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int? KGGCBKLPCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? CODEJLOOGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private long LPBDFCPAMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string NLPCNGHPOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long EFICAPHFFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, object> BOICFBAACCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private KEJFBHKLOMK BBJFGHALHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int KLJBLBOKDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int IOHDHGPEFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float MPOEBJCPDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool LICNADBMLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool ENILJCOMLNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private LGNIKEMIHIE LHDFCNEIBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private LGNIKEMIHIE KCDBMIPHLCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private LGNIKEMIHIE JBCDDMDGGKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> EMMIHJLBIKG;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo JKNFCFKGLNN;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static string KFLMIFBLAPF;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string JGPIKDJBDFE = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string JIBBOBFICHH = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private EFEFMHJPJIJ BMLHHONEDGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3BAB0A0", Offset = "0x3BAA0A0", VA = "0x183BAB0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int CMDHDIEMIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3BAB790", Offset = "0x3BAA790", VA = "0x183BAB790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long HFCOPCCCFBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3BAD140", Offset = "0x3BAC140", VA = "0x183BAD140")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3BAD240", Offset = "0x3BAC240", VA = "0x183BAD240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string IHLKNNKEGHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3BAD110", Offset = "0x3BAC110", VA = "0x183BAD110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string KFMCHKJANAP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4936C0", Offset = "0x4926C0", VA = "0x1804936C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x42B6C0", Offset = "0x42A6C0", VA = "0x18042B6C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PCCJHHABHCM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x54D0E0", Offset = "0x54C0E0", VA = "0x18054D0E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x78C2C0", Offset = "0x78B2C0", VA = "0x18078C2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool BLCLEMBJGJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3BAD030", Offset = "0x3BAC030", VA = "0x183BAD030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> HHDKCOGPHNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3BACF90", Offset = "0x3BABF90", VA = "0x183BACF90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3BAD1A0", Offset = "0x3BAC1A0", VA = "0x183BAD1A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA0F0", Offset = "0x3BA90F0", VA = "0x183BAA0F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3BACA20", Offset = "0x3BABA20", VA = "0x183BACA20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3BABED0", Offset = "0x3BAAED0", VA = "0x183BABED0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3BACBA0", Offset = "0x3BABBA0", VA = "0x183BACBA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA570", Offset = "0x3BA9570", VA = "0x183BAA570")]
		private bool BHEANPAOPOA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3BAB460", Offset = "0x3BAA460", VA = "0x183BAB460")]
		[IteratorStateMachine(typeof(FCPECEOLIKP))]
		public IEnumerator<KENFJGFMIPM> Initialize(AmplitudeAnalyticsEvent LNAFLFNFDIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3BACAF0", Offset = "0x3BABAF0", VA = "0x183BACAF0")]
		public void UpdateLastAliveTime(float POGAEJIEPIM = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3BAAF30", Offset = "0x3BA9F30", VA = "0x183BAAF30")]
		private bool HJPIFKNBGJA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3BAAA80", Offset = "0x3BA9A80", VA = "0x183BAAA80")]
		private bool EHJFPCAMLIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC6B0", Offset = "0x3BAB6B0", VA = "0x183BAC6B0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA590", Offset = "0x3BA9590", VA = "0x183BAA590")]
		[IteratorStateMachine(typeof(JHKKHMGNLOM))]
		private IEnumerator CMDNJJPDAGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3BACE00", Offset = "0x3BABE00", VA = "0x183BACE00")]
		[IteratorStateMachine(typeof(JKKMONDAPLG))]
		public IEnumerator WaitForFlush(float DJJMDAINGCG = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3BACA30", Offset = "0x3BABA30", VA = "0x183BACA30")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BAB170", Offset = "0x3BAA170", VA = "0x183BAB170")]
		public static ICBHDPFJBKD Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3BA9FB0", Offset = "0x3BA8FB0", VA = "0x183BA9FB0")]
		public static CCNBJFOPLBG AccountSelectionPostLoginEvent([NotNull] string JMDCOMHKKAN, string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3BAAC60", Offset = "0x3BA9C60", VA = "0x183BAAC60")]
		public static CCNBJFOPLBG Event([NotNull] string JMDCOMHKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC280", Offset = "0x3BAB280", VA = "0x183BAC280")]
		public static CCNBJFOPLBG PreviousSessionEvent([NotNull] string JMDCOMHKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3BAB2B0", Offset = "0x3BAA2B0", VA = "0x183BAB2B0")]
		public static CCNBJFOPLBG InitializeEvent(string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC7C0", Offset = "0x3BAB7C0", VA = "0x183BAC7C0")]
		public static CCNBJFOPLBG StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA5F0", Offset = "0x3BA95F0", VA = "0x183BAA5F0")]
		public static CCNBJFOPLBG CreateOutOfSessionEvent(string JMDCOMHKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3BABB60", Offset = "0x3BAAB60", VA = "0x183BABB60")]
		public static DABKFAIHBBP LogOutOfSessionEvent(CCNBJFOPLBG EMGIIALFJEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3BAB9B0", Offset = "0x3BAA9B0", VA = "0x183BAB9B0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent EIANIOCNJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3BABD30", Offset = "0x3BAAD30", VA = "0x183BABD30")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent EIANIOCNJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3BABE00", Offset = "0x3BAAE00", VA = "0x183BABE00")]
		public void LogSerializedEventAsync(Dictionary<string, object> OGFGPCCGGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3BABA80", Offset = "0x3BAAA80", VA = "0x183BABA80")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HNNMMGFNPOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3BAB4D0", Offset = "0x3BAA4D0", VA = "0x183BAB4D0")]
		private void JFGMGIDFKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3BAB570", Offset = "0x3BAA570", VA = "0x183BAB570")]
		private void KLICCPHKPAK(Dictionary<string, object> JFKDDPJDCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC1A0", Offset = "0x3BAB1A0", VA = "0x183BAC1A0")]
		private void PNHILKHLNEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA8A0", Offset = "0x3BA98A0", VA = "0x183BAA8A0")]
		private void EBHHHJJPPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3BAAE30", Offset = "0x3BA9E30", VA = "0x183BAAE30")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3BAAEC0", Offset = "0x3BA9EC0", VA = "0x183BAAEC0")]
		[IteratorStateMachine(typeof(DGDCGHAODAJ))]
		private IEnumerator<KENFJGFMIPM> GDNCPJOIAMO(float DJJMDAINGCG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3BAADC0", Offset = "0x3BA9DC0", VA = "0x183BAADC0")]
		[IteratorStateMachine(typeof(CNCALEMFLHL))]
		private IEnumerator<KENFJGFMIPM> FOIOMKBBHPA(float DJJMDAINGCG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3BA9F00", Offset = "0x3BA8F00", VA = "0x183BA9F00")]
		[IteratorStateMachine(typeof(JCGJOOMFAHF))]
		private IEnumerator<KENFJGFMIPM> AGJOIPCNEOD(LGNIKEMIHIE ONOBMHNFCHB, int? MADLMGFMFMN, string KCDNNDGKINC, string CPPKDDGBGFI, float DJJMDAINGCG, Action<int> ELEPHKHJNPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC0B0", Offset = "0x3BAB0B0", VA = "0x183BAC0B0")]
		private static void PBFPIKPIFKG(bool LHJKDKNHECD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x21B7650", Offset = "0x21B6650", VA = "0x1821B7650")]
		private global::PMGCJEPKFOF<DDAGJMCHCED<T>> GIBPCILMHIA<T>(string KCDNNDGKINC, string CPPKDDGBGFI, string KCCLHCJAIJI, T PHFDPICANAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3BAAA30", Offset = "0x3BA9A30", VA = "0x183BAAA30")]
		private bool EEFIJLDABPN(float JODPOANPJNK, float DJJMDAINGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3BACED0", Offset = "0x3BABED0", VA = "0x183BACED0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3BABF50", Offset = "0x3BAAF50", VA = "0x183BABF50")]
		[CompilerGenerated]
		private long PBEOIAOFGFO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA580", Offset = "0x3BA9580", VA = "0x183BAA580")]
		[CompilerGenerated]
		private void BLBNJNENKLL(int OPGBFHMGPAH)
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
			[Cpp2IlInjected.Address(RVA = "0x4177D0", Offset = "0x4167D0", VA = "0x1804177D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD750", Offset = "0x3BAC750", VA = "0x183BAD750")]
		public static CCNBJFOPLBG NFHADFCEMML(string HNPBHLIOFNC, [NotNull] string DDFOHKALPKN, long FOGIDAPKPPH, long ODOHHNIMGIM, string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD4E0", Offset = "0x3BAC4E0", VA = "0x183BAD4E0")]
		public static CCNBJFOPLBG HLKAEHCLFJC(string HNPBHLIOFNC, [NotNull] string DDFOHKALPKN, long FOGIDAPKPPH, long ODOHHNIMGIM, string BHBHMMAEFMK, long KLGCHPCCIEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD830", Offset = "0x3BAC830", VA = "0x183BAD830")]
		private AmplitudeAnalyticsEvent(string HNPBHLIOFNC, [NotNull] string DDFOHKALPKN, long FOGIDAPKPPH, long ODOHHNIMGIM, string BHBHMMAEFMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x417AC0", Offset = "0x416AC0", VA = "0x180417AC0")]
		public void NBBAILPLAME(long NLCNLKLECAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD5D0", Offset = "0x3BAC5D0", VA = "0x183BAD5D0", Slot = "5")]
		public override void JEBCDGPBFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD6E0", Offset = "0x3BAC6E0", VA = "0x183BAD6E0", Slot = "6")]
		public override void LHJKMBOGMCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD2A0", Offset = "0x3BAC2A0", VA = "0x183BAD2A0", Slot = "4")]
		protected override Dictionary<string, object> FCFGBBENGPC(Dictionary<string, object> ICPCGIMPCGB)
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
			[Cpp2IlInjected.Address(RVA = "0x3BAE700", Offset = "0x3BAD700", VA = "0x183BAE700")]
			public void NADFBGIJJLM(Dictionary<string, object> CACJCCOABOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x412370", Offset = "0x411370", VA = "0x180412370")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BB1930", Offset = "0x3BB0930", VA = "0x183BB1930")]
			public void NADFBGIJJLM(Dictionary<string, object> DKEFODEJBEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1A981D0", Offset = "0x1A971D0", VA = "0x181A981D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x411530", Offset = "0x410530", VA = "0x180411530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x415800", Offset = "0x414800", VA = "0x180415800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3BADE50", Offset = "0x3BACE50", VA = "0x183BADE50")]
		public static ICBHDPFJBKD NFHADFCEMML(string HNPBHLIOFNC, string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3BADEF0", Offset = "0x3BACEF0", VA = "0x183BADEF0")]
		protected AmplitudeAnalyticsIdentifyMessage(string HNPBHLIOFNC, string BHBHMMAEFMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD9B0", Offset = "0x3BAC9B0", VA = "0x183BAD9B0")]
		public Dictionary<string, object> CGKHPNNLKDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3BADA20", Offset = "0x3BACA20", VA = "0x183BADA20", Slot = "4")]
		protected virtual Dictionary<string, object> FCFGBBENGPC(Dictionary<string, object> ICPCGIMPCGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3BADDB0", Offset = "0x3BACDB0", VA = "0x183BADDB0")]
		protected void MMMPHAOAJCB(string DNGKIAJLLHG, Dictionary<string, object> JKAELHGHJAJ, Dictionary<string, object> GKLOGJJFBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3BADC60", Offset = "0x3BACC60", VA = "0x183BADC60")]
		protected void HCMAEDCGBIH(string DNGKIAJLLHG, string ONGBFDACHHG, Dictionary<string, object> PMMGDNALAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3BADCD0", Offset = "0x3BACCD0", VA = "0x183BADCD0", Slot = "5")]
		public virtual void JEBCDGPBFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3BADD40", Offset = "0x3BACD40", VA = "0x183BADD40", Slot = "6")]
		public virtual void LHJKMBOGMCH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ICBHDPFJBKD : global::BBGJEKJBJCM<AmplitudeAnalyticsIdentifyMessage, ICBHDPFJBKD>
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override ICBHDPFJBKD OMDFMNJINFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4A65C0", Offset = "0x4A55C0", VA = "0x1804A65C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x411530", Offset = "0x410530", VA = "0x180411530", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage MFBDEFCEDGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3BAFB40", Offset = "0x3BAEB40", VA = "0x183BAFB40")]
	public ICBHDPFJBKD(AmplitudeAnalyticsIdentifyMessage NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3BAFAB0", Offset = "0x3BAEAB0", VA = "0x183BAFAB0", Slot = "4")]
	public override void LHJKMBOGMCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CCNBJFOPLBG : global::BBGJEKJBJCM<AmplitudeAnalyticsEvent, CCNBJFOPLBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool JNPECPPECNJ;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override CCNBJFOPLBG OMDFMNJINFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4A65C0", Offset = "0x4A55C0", VA = "0x1804A65C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE190", Offset = "0x3BAD190", VA = "0x183BAE190")]
	public CCNBJFOPLBG(AmplitudeAnalyticsEvent NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x411530", Offset = "0x410530", VA = "0x180411530", Slot = "5")]
	public override AmplitudeAnalyticsEvent MFBDEFCEDGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE0F0", Offset = "0x3BAD0F0", VA = "0x183BAE0F0", Slot = "4")]
	public override void LHJKMBOGMCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	public CCNBJFOPLBG JOBHLMFKFNO<T>(string KOOIDPHIAIA, T[] ONGBFDACHHG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE070", Offset = "0x3BAD070", VA = "0x183BAE070")]
	public CCNBJFOPLBG JOBHLMFKFNO(string KOOIDPHIAIA, string[] ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x21BA6F0", Offset = "0x21B96F0", VA = "0x1821BA6F0")]
	public CCNBJFOPLBG JOBHLMFKFNO<T>(string KOOIDPHIAIA, T ONGBFDACHHG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE080", Offset = "0x3BAD080", VA = "0x183BAE080")]
	public CCNBJFOPLBG JOBHLMFKFNO(string KOOIDPHIAIA, string ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3BADF90", Offset = "0x3BACF90", VA = "0x183BADF90")]
	private CCNBJFOPLBG FNHCBLEPHIF(string KOOIDPHIAIA, object ONGBFDACHHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JOAOPMIJNMM : CCNBJFOPLBG
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE190", Offset = "0x3BAD190", VA = "0x183BAE190")]
	public JOAOPMIJNMM(AmplitudeAnalyticsEvent NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3BB0530", Offset = "0x3BAF530", VA = "0x183BB0530", Slot = "4")]
	public override void LHJKMBOGMCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class BBGJEKJBJCM<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::BBGJEKJBJCM<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	protected M NGPMADFHHKP;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public abstract BLDR OMDFMNJINFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2427900", Offset = "0x2426900", VA = "0x182427900")]
	public BBGJEKJBJCM(M NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x24278A0", Offset = "0x24268A0", VA = "0x1824278A0")]
	public BLDR IADLHONHOKB(AmplitudeAnalyticsIdentifyMessage.DeviceInfo AJAAOHEMPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x24278D0", Offset = "0x24268D0", VA = "0x1824278D0")]
	public BLDR IICOEBCDPNM(AmplitudeAnalyticsIdentifyMessage.RevenueData HLPAKKPJOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2427830", Offset = "0x2426830", VA = "0x182427830")]
	public BLDR FHKPFOMIHLE(string KOOIDPHIAIA, string ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x21B9880", Offset = "0x21B8880", VA = "0x1821B9880")]
	public BLDR FHKPFOMIHLE<T>(string KOOIDPHIAIA, T ONGBFDACHHG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LHJKMBOGMCH();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2427720", Offset = "0x2426720", VA = "0x182427720")]
	internal static string AAKODJMFMKO(string ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2427750", Offset = "0x2426750", VA = "0x182427750")]
	private BLDR EBLEMBLJOLH(string KOOIDPHIAIA, object ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M MFBDEFCEDGN();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GGICANINMLB
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public const int JEAKKDAPKLL = 2;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int NGPHFJNCCCA = 100;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int GNOFDLPOFMN = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const long BFGMODBDIGA = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const int BBGGHOBBLDJ = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int ODHJBJMMCBO = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const string APPANLPPDPG = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string KIKNHAHFGCK = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string PPOLJMJHAJH = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string KPAHPMNHLBP = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string KDBLMDDNOOE = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string JGDEPBBPNFJ = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string OAHHLPLBPHJ = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string KHIJGCAGIPG = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const int JFIEBABNINC = 10;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> OGLGKCNJJJO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x412370", Offset = "0x411370", VA = "0x180412370")]
	public GGICANINMLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MAFPBPHMEIP
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string ICKMCNMKFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string PDGHPHCFECP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string IPFPGMDKMON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::PMGCJEPKFOF<OADHHEBMJOA> GIBPCILMHIA(string KCDNNDGKINC, Dictionary<string, string> LOGDHPJIFFN);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OADHHEBMJOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly int LLODNIOIDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly string DKPCLPHKFDI;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x478700", Offset = "0x477700", VA = "0x180478700")]
	public OADHHEBMJOA(int LMOEMCOMALK, string HFOCDNIDIBO)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FFAFDAOBAHN
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static byte[] OHCLMBBDJLC;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int NJPHPOMKGAO;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int NCHLFMFMLBC;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static BigInteger AEEDJIDCNEO;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x412370", Offset = "0x411370", VA = "0x180412370")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEF90", Offset = "0x3BADF90", VA = "0x183BAEF90")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3BAF090", Offset = "0x3BAE090", VA = "0x183BAF090")]
	public static string PAMIGJPGHHB(byte[] MGPDDEMABPB, bool KOILKPGDKMG)
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
		[Cpp2IlInjected.Address(RVA = "0x412370", Offset = "0x411370", VA = "0x180412370")]
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
