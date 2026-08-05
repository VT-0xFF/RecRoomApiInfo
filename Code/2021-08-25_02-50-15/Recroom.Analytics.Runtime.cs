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
			[Cpp2IlInjected.Address(RVA = "0x3FBE70", Offset = "0x3FAC70", VA = "0x1803FBE70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IOMNJOCFLNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x42E0D0", Offset = "0x42CED0", VA = "0x18042E0D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3F8A40", Offset = "0x3F7840", VA = "0x1803F8A40")]
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

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x3F8000", Offset = "0x3F6E00", VA = "0x1803F8000")]
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

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x3F8000", Offset = "0x3F6E00", VA = "0x1803F8000")]
				public ILBENLNNFMN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x11E0400", Offset = "0x11DF200", VA = "0x1811E0400")]
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

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public int? CPMPHJGGGPB
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x11E13C0", Offset = "0x11E01C0", VA = "0x1811E13C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? LDOCMGKGOOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x11E1E10", Offset = "0x11E0C10", VA = "0x1811E1E10")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x11E1EC0", Offset = "0x11E0CC0", VA = "0x1811E1EC0")]
			internal LGNIKEMIHIE(string LFBABEDGCOM, string HPJHNGGCLHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x11E1450", Offset = "0x11E0250", VA = "0x1811E1450")]
			public int GHICFPNGGOD([Optional] int? MADLMGFMFMN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x11E0F60", Offset = "0x11DFD60", VA = "0x1811E0F60")]
			public List<Dictionary<string, object>> AHDGOECGFHE(int BBPAOGDGDOI, int? MADLMGFMFMN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x11E1B70", Offset = "0x11E0970", VA = "0x1811E1B70")]
			public void MEAKBDKDFKF(AmplitudeAnalyticsIdentifyMessage NLNHFEEMFBN, bool BPPFJEHCKFL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x11E1C10", Offset = "0x11E0A10", VA = "0x1811E1C10")]
			public void MEAKBDKDFKF(Dictionary<string, object> NLNHFEEMFBN, bool BPPFJEHCKFL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x11E1160", Offset = "0x11DFF60", VA = "0x1811E1160")]
			public void DAKLDLDFDJI(params Dictionary<string, object>[] HHLLJLDFBPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x11E0D40", Offset = "0x11DFB40", VA = "0x1811E0D40")]
			public void ADOEAIINDBN(List<Dictionary<string, object>> PPPMBOLNNBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x11E1D00", Offset = "0x11E0B00", VA = "0x1811E1D00")]
			private void MOBOEANLOCA(Dictionary<string, object> NLNHFEEMFBN, bool BPPFJEHCKFL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x11E1980", Offset = "0x11E0780", VA = "0x1811E1980")]
			public void IGCBDPJHEHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x11E15B0", Offset = "0x11E03B0", VA = "0x1811E15B0")]
			private void IECOIFMKKHC([Optional] string MCFONLFCHFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x11E1290", Offset = "0x11E0090", VA = "0x1811E1290")]
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

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x11E2140", Offset = "0x11E0F40", VA = "0x1811E2140")]
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

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x3FBE70", Offset = "0x3FAC70", VA = "0x1803FBE70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x3FBE70", Offset = "0x3FAC70", VA = "0x1803FBE70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x41F090", Offset = "0x41DE90", VA = "0x18041F090")]
			[DebuggerHidden]
			public FCPECEOLIKP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B10", Offset = "0x3F7910", VA = "0x1803F8B10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x11DF010", Offset = "0x11DDE10", VA = "0x1811DF010", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x11DF730", Offset = "0x11DE530", VA = "0x1811DF730", Slot = "8")]
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

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x3FBE70", Offset = "0x3FAC70", VA = "0x1803FBE70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3FBE70", Offset = "0x3FAC70", VA = "0x1803FBE70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x41F090", Offset = "0x41DE90", VA = "0x18041F090")]
			[DebuggerHidden]
			public JHKKHMGNLOM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B10", Offset = "0x3F7910", VA = "0x1803F8B10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x11E0460", Offset = "0x11DF260", VA = "0x1811E0460", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x11E0530", Offset = "0x11DF330", VA = "0x1811E0530", Slot = "8")]
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

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x3FBE70", Offset = "0x3FAC70", VA = "0x1803FBE70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3FBE70", Offset = "0x3FAC70", VA = "0x1803FBE70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x41F090", Offset = "0x41DE90", VA = "0x18041F090")]
			[DebuggerHidden]
			public JKKMONDAPLG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B10", Offset = "0x3F7910", VA = "0x1803F8B10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x11E05E0", Offset = "0x11DF3E0", VA = "0x1811E05E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x11E0720", Offset = "0x11DF520", VA = "0x1811E0720", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HIJBJJMNHNH : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x3FBE70", Offset = "0x3FAC70", VA = "0x1803FBE70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3FBE70", Offset = "0x3FAC70", VA = "0x1803FBE70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x41F090", Offset = "0x41DE90", VA = "0x18041F090")]
			[DebuggerHidden]
			public HIJBJJMNHNH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B10", Offset = "0x3F7910", VA = "0x1803F8B10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x11DFE00", Offset = "0x11DEC00", VA = "0x1811DFE00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x11E0040", Offset = "0x11DEE40", VA = "0x1811E0040", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class IAIPJKDLMCC : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x3FBE70", Offset = "0x3FAC70", VA = "0x1803FBE70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x3FBE70", Offset = "0x3FAC70", VA = "0x1803FBE70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x41F090", Offset = "0x41DE90", VA = "0x18041F090")]
			[DebuggerHidden]
			public IAIPJKDLMCC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B10", Offset = "0x3F7910", VA = "0x1803F8B10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x11E0090", Offset = "0x11DEE90", VA = "0x1811E0090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x11E02D0", Offset = "0x11DF0D0", VA = "0x1811E02D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class LDOLLAOHLDD
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

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3F8000", Offset = "0x3F6E00", VA = "0x1803F8000")]
			public LDOLLAOHLDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x11E08A0", Offset = "0x11DF6A0", VA = "0x1811E08A0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x11E0940", Offset = "0x11DF740", VA = "0x1811E0940")]
			internal void <FlushFromCache>b__1(DDAGJMCHCED<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class FCDCNPNBJJM : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
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
			private LDOLLAOHLDD <>8__1;

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

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x3FBE70", Offset = "0x3FAC70", VA = "0x1803FBE70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x3FBE70", Offset = "0x3FAC70", VA = "0x1803FBE70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x41F090", Offset = "0x41DE90", VA = "0x18041F090")]
			[DebuggerHidden]
			public FCDCNPNBJJM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B10", Offset = "0x3F7910", VA = "0x1803F8B10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x11DE980", Offset = "0x11DD780", VA = "0x1811DE980", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x11DEFC0", Offset = "0x11DDDC0", VA = "0x1811DEFC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class LDMEDLIJBAD<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5114A0", Offset = "0x5102A0", VA = "0x1805114A0")]
			public LDMEDLIJBAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x246B140", Offset = "0x2469F40", VA = "0x18246B140")]
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
			[Cpp2IlInjected.Address(RVA = "0x11DB7E0", Offset = "0x11DA5E0", VA = "0x1811DB7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int CMDHDIEMIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x11DBED0", Offset = "0x11DACD0", VA = "0x1811DBED0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long HFCOPCCCFBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x11DD760", Offset = "0x11DC560", VA = "0x1811DD760")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x11DD8C0", Offset = "0x11DC6C0", VA = "0x1811DD8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string IHLKNNKEGHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x11DD730", Offset = "0x11DC530", VA = "0x1811DD730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string KFMCHKJANAP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x59D1B0", Offset = "0x59BFB0", VA = "0x18059D1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x3FB650", Offset = "0x3FA450", VA = "0x1803FB650")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PCCJHHABHCM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x65E110", Offset = "0x65CF10", VA = "0x18065E110")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x65DD50", Offset = "0x65CB50", VA = "0x18065DD50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> HHDKCOGPHNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x11DD690", Offset = "0x11DC490", VA = "0x1811DD690")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x11DD820", Offset = "0x11DC620", VA = "0x1811DD820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x11DA830", Offset = "0x11D9630", VA = "0x1811DA830", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x11DD120", Offset = "0x11DBF20", VA = "0x1811DD120")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x11DC610", Offset = "0x11DB410", VA = "0x1811DC610", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11DD2A0", Offset = "0x11DC0A0", VA = "0x1811DD2A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x11DACB0", Offset = "0x11D9AB0", VA = "0x1811DACB0")]
		private bool BHEANPAOPOA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x11DBBA0", Offset = "0x11DA9A0", VA = "0x1811DBBA0")]
		[IteratorStateMachine(typeof(FCPECEOLIKP))]
		public IEnumerator<KENFJGFMIPM> Initialize(AmplitudeAnalyticsEvent LNAFLFNFDIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x11DD1F0", Offset = "0x11DBFF0", VA = "0x1811DD1F0")]
		public void UpdateLastAliveTime(float POGAEJIEPIM = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x11DB670", Offset = "0x11DA470", VA = "0x1811DB670")]
		private bool HJPIFKNBGJA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x11DB1C0", Offset = "0x11D9FC0", VA = "0x1811DB1C0")]
		private bool EHJFPCAMLIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x11DCDB0", Offset = "0x11DBBB0", VA = "0x1811DCDB0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x11DACD0", Offset = "0x11D9AD0", VA = "0x1811DACD0")]
		[IteratorStateMachine(typeof(JHKKHMGNLOM))]
		private IEnumerator CMDNJJPDAGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x11DD500", Offset = "0x11DC300", VA = "0x1811DD500")]
		[IteratorStateMachine(typeof(JKKMONDAPLG))]
		public IEnumerator WaitForFlush(float DJJMDAINGCG = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x11DD130", Offset = "0x11DBF30", VA = "0x1811DD130")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x11DB8B0", Offset = "0x11DA6B0", VA = "0x1811DB8B0")]
		public static ICBHDPFJBKD Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x11DA6F0", Offset = "0x11D94F0", VA = "0x1811DA6F0")]
		public static CCNBJFOPLBG AccountSelectionPostLoginEvent([NotNull] string JMDCOMHKKAN, string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x11DB3A0", Offset = "0x11DA1A0", VA = "0x1811DB3A0")]
		public static CCNBJFOPLBG Event([NotNull] string JMDCOMHKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x11DC9C0", Offset = "0x11DB7C0", VA = "0x1811DC9C0")]
		public static CCNBJFOPLBG PreviousSessionEvent([NotNull] string JMDCOMHKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x11DB9F0", Offset = "0x11DA7F0", VA = "0x1811DB9F0")]
		public static CCNBJFOPLBG InitializeEvent(string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x11DCEC0", Offset = "0x11DBCC0", VA = "0x1811DCEC0")]
		public static CCNBJFOPLBG StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x11DAD30", Offset = "0x11D9B30", VA = "0x1811DAD30")]
		public static CCNBJFOPLBG CreateOutOfSessionEvent(string JMDCOMHKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x11DC2A0", Offset = "0x11DB0A0", VA = "0x1811DC2A0")]
		public static DABKFAIHBBP LogOutOfSessionEvent(CCNBJFOPLBG EMGIIALFJEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x11DC0F0", Offset = "0x11DAEF0", VA = "0x1811DC0F0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent EIANIOCNJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x11DC470", Offset = "0x11DB270", VA = "0x1811DC470")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent EIANIOCNJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x11DC540", Offset = "0x11DB340", VA = "0x1811DC540")]
		public void LogSerializedEventAsync(Dictionary<string, object> OGFGPCCGGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x11DC1C0", Offset = "0x11DAFC0", VA = "0x1811DC1C0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HNNMMGFNPOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x11DBC10", Offset = "0x11DAA10", VA = "0x1811DBC10")]
		private void JFGMGIDFKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x11DBCB0", Offset = "0x11DAAB0", VA = "0x1811DBCB0")]
		private void KLICCPHKPAK(Dictionary<string, object> JFKDDPJDCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x11DC8E0", Offset = "0x11DB6E0", VA = "0x1811DC8E0")]
		private void PNHILKHLNEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x11DAFE0", Offset = "0x11D9DE0", VA = "0x1811DAFE0")]
		private void EBHHHJJPPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x11DB570", Offset = "0x11DA370", VA = "0x1811DB570")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x11DB600", Offset = "0x11DA400", VA = "0x1811DB600")]
		[IteratorStateMachine(typeof(HIJBJJMNHNH))]
		private IEnumerator<KENFJGFMIPM> GDNCPJOIAMO(float DJJMDAINGCG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x11DB500", Offset = "0x11DA300", VA = "0x1811DB500")]
		[IteratorStateMachine(typeof(IAIPJKDLMCC))]
		private IEnumerator<KENFJGFMIPM> FOIOMKBBHPA(float DJJMDAINGCG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x11DA640", Offset = "0x11D9440", VA = "0x1811DA640")]
		[IteratorStateMachine(typeof(FCDCNPNBJJM))]
		private IEnumerator<KENFJGFMIPM> AGJOIPCNEOD(LGNIKEMIHIE ONOBMHNFCHB, int? MADLMGFMFMN, string KCDNNDGKINC, string CPPKDDGBGFI, float DJJMDAINGCG, Action<int> ELEPHKHJNPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x11DC7F0", Offset = "0x11DB5F0", VA = "0x1811DC7F0")]
		private static void PBFPIKPIFKG(bool LHJKDKNHECD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x228C7D0", Offset = "0x228B5D0", VA = "0x18228C7D0")]
		private global::PMGCJEPKFOF<DDAGJMCHCED<T>> GIBPCILMHIA<T>(string KCDNNDGKINC, string CPPKDDGBGFI, string KCCLHCJAIJI, T PHFDPICANAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x11DB170", Offset = "0x11D9F70", VA = "0x1811DB170")]
		private bool EEFIJLDABPN(float JODPOANPJNK, float DJJMDAINGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x11DD5D0", Offset = "0x11DC3D0", VA = "0x1811DD5D0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x11DC690", Offset = "0x11DB490", VA = "0x1811DC690")]
		[CompilerGenerated]
		private long PBEOIAOFGFO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x11DACC0", Offset = "0x11D9AC0", VA = "0x1811DACC0")]
		[CompilerGenerated]
		private void BPHDDKMOADH(int OPGBFHMGPAH)
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

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5CD110", Offset = "0x5CBF10", VA = "0x1805CD110")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x11DDDD0", Offset = "0x11DCBD0", VA = "0x1811DDDD0")]
		public static CCNBJFOPLBG NFHADFCEMML(string HNPBHLIOFNC, [NotNull] string DDFOHKALPKN, long FOGIDAPKPPH, long ODOHHNIMGIM, string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x11DDB60", Offset = "0x11DC960", VA = "0x1811DDB60")]
		public static CCNBJFOPLBG HLKAEHCLFJC(string HNPBHLIOFNC, [NotNull] string DDFOHKALPKN, long FOGIDAPKPPH, long ODOHHNIMGIM, string BHBHMMAEFMK, long KLGCHPCCIEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x11DDEB0", Offset = "0x11DCCB0", VA = "0x1811DDEB0")]
		private AmplitudeAnalyticsEvent(string HNPBHLIOFNC, [NotNull] string DDFOHKALPKN, long FOGIDAPKPPH, long ODOHHNIMGIM, string BHBHMMAEFMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5CD440", Offset = "0x5CC240", VA = "0x1805CD440")]
		public void NBBAILPLAME(long NLCNLKLECAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x11DDC50", Offset = "0x11DCA50", VA = "0x1811DDC50", Slot = "5")]
		public override void JEBCDGPBFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x11DDD60", Offset = "0x11DCB60", VA = "0x1811DDD60", Slot = "6")]
		public override void LHJKMBOGMCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x11DD920", Offset = "0x11DC720", VA = "0x1811DD920", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x11DE860", Offset = "0x11DD660", VA = "0x1811DE860")]
			public void NADFBGIJJLM(Dictionary<string, object> CACJCCOABOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x3F8000", Offset = "0x3F6E00", VA = "0x1803F8000")]
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

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x11E2010", Offset = "0x11E0E10", VA = "0x1811E2010")]
			public void NADFBGIJJLM(Dictionary<string, object> DKEFODEJBEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x11E2130", Offset = "0x11E0F30", VA = "0x1811E2130")]
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

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3FC200", Offset = "0x3FB000", VA = "0x1803FC200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x439D40", Offset = "0x438B40", VA = "0x180439D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x11DE4D0", Offset = "0x11DD2D0", VA = "0x1811DE4D0")]
		public static ICBHDPFJBKD NFHADFCEMML(string HNPBHLIOFNC, string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x11DE570", Offset = "0x11DD370", VA = "0x1811DE570")]
		protected AmplitudeAnalyticsIdentifyMessage(string HNPBHLIOFNC, string BHBHMMAEFMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x11DE030", Offset = "0x11DCE30", VA = "0x1811DE030")]
		public Dictionary<string, object> CGKHPNNLKDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x11DE0A0", Offset = "0x11DCEA0", VA = "0x1811DE0A0", Slot = "4")]
		protected virtual Dictionary<string, object> FCFGBBENGPC(Dictionary<string, object> ICPCGIMPCGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x11DE430", Offset = "0x11DD230", VA = "0x1811DE430")]
		protected void MMMPHAOAJCB(string DNGKIAJLLHG, Dictionary<string, object> JKAELHGHJAJ, Dictionary<string, object> GKLOGJJFBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x11DE2E0", Offset = "0x11DD0E0", VA = "0x1811DE2E0")]
		protected void HCMAEDCGBIH(string DNGKIAJLLHG, string ONGBFDACHHG, Dictionary<string, object> PMMGDNALAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x11DE350", Offset = "0x11DD150", VA = "0x1811DE350", Slot = "5")]
		public virtual void JEBCDGPBFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x11DE3C0", Offset = "0x11DD1C0", VA = "0x1811DE3C0", Slot = "6")]
		public virtual void LHJKMBOGMCH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ICBHDPFJBKD : global::BBGJEKJBJCM<AmplitudeAnalyticsIdentifyMessage, ICBHDPFJBKD>
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override ICBHDPFJBKD OMDFMNJINFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x42E220", Offset = "0x42D020", VA = "0x18042E220", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3FC200", Offset = "0x3FB000", VA = "0x1803FC200", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage MFBDEFCEDGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x11E03B0", Offset = "0x11DF1B0", VA = "0x1811E03B0")]
	public ICBHDPFJBKD(AmplitudeAnalyticsIdentifyMessage NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x11E0320", Offset = "0x11DF120", VA = "0x1811E0320", Slot = "4")]
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

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override CCNBJFOPLBG OMDFMNJINFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x42E220", Offset = "0x42D020", VA = "0x18042E220", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x11DE810", Offset = "0x11DD610", VA = "0x1811DE810")]
	public CCNBJFOPLBG(AmplitudeAnalyticsEvent NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3FC200", Offset = "0x3FB000", VA = "0x1803FC200", Slot = "5")]
	public override AmplitudeAnalyticsEvent MFBDEFCEDGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x11DE770", Offset = "0x11DD570", VA = "0x1811DE770", Slot = "4")]
	public override void LHJKMBOGMCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	public CCNBJFOPLBG JOBHLMFKFNO<T>(string KOOIDPHIAIA, T[] ONGBFDACHHG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x11DE6F0", Offset = "0x11DD4F0", VA = "0x1811DE6F0")]
	public CCNBJFOPLBG JOBHLMFKFNO(string KOOIDPHIAIA, string[] ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x228F890", Offset = "0x228E690", VA = "0x18228F890")]
	public CCNBJFOPLBG JOBHLMFKFNO<T>(string KOOIDPHIAIA, T ONGBFDACHHG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x11DE700", Offset = "0x11DD500", VA = "0x1811DE700")]
	public CCNBJFOPLBG JOBHLMFKFNO(string KOOIDPHIAIA, string ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x11DE610", Offset = "0x11DD410", VA = "0x1811DE610")]
	private CCNBJFOPLBG FNHCBLEPHIF(string KOOIDPHIAIA, object ONGBFDACHHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JOAOPMIJNMM : CCNBJFOPLBG
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x11DE810", Offset = "0x11DD610", VA = "0x1811DE810")]
	public JOAOPMIJNMM(AmplitudeAnalyticsEvent NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x11E0770", Offset = "0x11DF570", VA = "0x1811E0770", Slot = "4")]
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

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public abstract BLDR OMDFMNJINFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2462FB0", Offset = "0x2461DB0", VA = "0x182462FB0")]
	public BBGJEKJBJCM(M NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2462F50", Offset = "0x2461D50", VA = "0x182462F50")]
	public BLDR IADLHONHOKB(AmplitudeAnalyticsIdentifyMessage.DeviceInfo AJAAOHEMPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2462F80", Offset = "0x2461D80", VA = "0x182462F80")]
	public BLDR IICOEBCDPNM(AmplitudeAnalyticsIdentifyMessage.RevenueData HLPAKKPJOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2462EE0", Offset = "0x2461CE0", VA = "0x182462EE0")]
	public BLDR FHKPFOMIHLE(string KOOIDPHIAIA, string ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x228EA20", Offset = "0x228D820", VA = "0x18228EA20")]
	public BLDR FHKPFOMIHLE<T>(string KOOIDPHIAIA, T ONGBFDACHHG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LHJKMBOGMCH();

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2462DD0", Offset = "0x2461BD0", VA = "0x182462DD0")]
	internal static string AAKODJMFMKO(string ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2462E00", Offset = "0x2461C00", VA = "0x182462E00")]
	private BLDR EBLEMBLJOLH(string KOOIDPHIAIA, object ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
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

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3F8000", Offset = "0x3F6E00", VA = "0x1803F8000")]
	public GGICANINMLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MAFPBPHMEIP
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string ICKMCNMKFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string PDGHPHCFECP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string IPFPGMDKMON
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
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

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xDEFDD0", Offset = "0xDEEBD0", VA = "0x180DEFDD0")]
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

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3F8000", Offset = "0x3F6E00", VA = "0x1803F8000")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x11DF780", Offset = "0x11DE580", VA = "0x1811DF780")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x11DF880", Offset = "0x11DE680", VA = "0x1811DF880")]
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

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F8000", Offset = "0x3F6E00", VA = "0x1803F8000")]
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
