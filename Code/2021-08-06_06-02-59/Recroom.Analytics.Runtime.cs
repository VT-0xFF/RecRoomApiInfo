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
			[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IOMNJOCFLNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x3F71D0", Offset = "0x3F5FD0", VA = "0x1803F71D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74EA40", Offset = "0x74D840", VA = "0x18074EA40")]
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
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class LGNIKEMIHIE
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

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x3F5100", Offset = "0x3F3F00", VA = "0x1803F5100")]
				public HGEGKDOFHCK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class MPDBCDGJKOC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x3F5100", Offset = "0x3F3F00", VA = "0x1803F5100")]
				public MPDBCDGJKOC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x3860710", Offset = "0x385F510", VA = "0x183860710")]
				internal bool <GetBatch>b__0(HGEGKDOFHCK item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private const string FFJGIJOFDBC = "queued_events";

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private const string JNLGIIEDBOG = "queued_identify";

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private const string MFNLINGPFIM = "prev_user_props";

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private const string HBPFDDPGLHD = "AnalyticsCacheKey";

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly LGNIKEMIHIE EHCHEKGAEFG;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly LGNIKEMIHIE NKBHNNKICIO;

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly LGNIKEMIHIE INBCJEHHMEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string CBCDLMLKBJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<HGEGKDOFHCK> FPBIKLDCIJF;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public int? CPMPHJGGGPB
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x385F490", Offset = "0x385E290", VA = "0x18385F490")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? LDOCMGKGOOK
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x385FEF0", Offset = "0x385ECF0", VA = "0x18385FEF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3860060", Offset = "0x385EE60", VA = "0x183860060")]
			private LGNIKEMIHIE(string MEIIMAIGBJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x385F520", Offset = "0x385E320", VA = "0x18385F520")]
			public int GHICFPNGGOD([Optional] int? MADLMGFMFMN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x385F030", Offset = "0x385DE30", VA = "0x18385F030")]
			public List<Dictionary<string, object>> AHDGOECGFHE(int BBPAOGDGDOI, int? MADLMGFMFMN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x385FC50", Offset = "0x385EA50", VA = "0x18385FC50")]
			public void MEAKBDKDFKF(AmplitudeAnalyticsIdentifyMessage NLNHFEEMFBN, bool BPPFJEHCKFL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x385FCF0", Offset = "0x385EAF0", VA = "0x18385FCF0")]
			public void MEAKBDKDFKF(Dictionary<string, object> NLNHFEEMFBN, bool BPPFJEHCKFL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x385F230", Offset = "0x385E030", VA = "0x18385F230")]
			public void DAKLDLDFDJI(params Dictionary<string, object>[] HHLLJLDFBPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x385EE10", Offset = "0x385DC10", VA = "0x18385EE10")]
			public void ADOEAIINDBN(List<Dictionary<string, object>> PPPMBOLNNBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x385FDE0", Offset = "0x385EBE0", VA = "0x18385FDE0")]
			private void MOBOEANLOCA(Dictionary<string, object> NLNHFEEMFBN, bool BPPFJEHCKFL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x385FA40", Offset = "0x385E840", VA = "0x18385FA40")]
			public void IGCBDPJHEHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x385F680", Offset = "0x385E480", VA = "0x18385F680")]
			public void IECOIFMKKHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x385F360", Offset = "0x385E160", VA = "0x18385F360")]
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

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x38611B0", Offset = "0x385FFB0", VA = "0x1838611B0")]
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
		private sealed class GLPIJBGIAGO : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x445B90", Offset = "0x444990", VA = "0x180445B90")]
			[DebuggerHidden]
			public GLPIJBGIAGO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x385E1F0", Offset = "0x385CFF0", VA = "0x18385E1F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x385E7A0", Offset = "0x385D5A0", VA = "0x18385E7A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class HJCILLMECLK : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x445B90", Offset = "0x444990", VA = "0x180445B90")]
			[DebuggerHidden]
			public HJCILLMECLK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x385EAB0", Offset = "0x385D8B0", VA = "0x18385EAB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x385EB80", Offset = "0x385D980", VA = "0x18385EB80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MGIAJKFAIMP : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x445B90", Offset = "0x444990", VA = "0x180445B90")]
			[DebuggerHidden]
			public MGIAJKFAIMP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3860110", Offset = "0x385EF10", VA = "0x183860110", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3860220", Offset = "0x385F020", VA = "0x183860220", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class PCHPKDLPKDK : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x445B90", Offset = "0x444990", VA = "0x180445B90")]
			[DebuggerHidden]
			public PCHPKDLPKDK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3860770", Offset = "0x385F570", VA = "0x183860770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x38609F0", Offset = "0x385F7F0", VA = "0x1838609F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class HGKAALJHHEM : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x445B90", Offset = "0x444990", VA = "0x180445B90")]
			[DebuggerHidden]
			public HGKAALJHHEM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x385E7F0", Offset = "0x385D5F0", VA = "0x18385E7F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x385EA60", Offset = "0x385D860", VA = "0x18385EA60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class MLOKEEIPBHE
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

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3F5100", Offset = "0x3F3F00", VA = "0x1803F5100")]
			public MLOKEEIPBHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3860270", Offset = "0x385F070", VA = "0x183860270")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x3860310", Offset = "0x385F110", VA = "0x183860310")]
			internal void <FlushFromCache>b__1(DDAGJMCHCED<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class PFAKAPIEPOC : IEnumerator<KENFJGFMIPM>, IEnumerator, IDisposable
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
			private MLOKEEIPBHE <>8__1;

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
			private float <startTime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private bool <timedOut>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <batchSize>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private KENFJGFMIPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x445B90", Offset = "0x444990", VA = "0x180445B90")]
			[DebuggerHidden]
			public PFAKAPIEPOC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3860A40", Offset = "0x385F840", VA = "0x183860A40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x3861040", Offset = "0x385FE40", VA = "0x183861040", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class LMDMEHOALFH<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
			public LMDMEHOALFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x1A8D450", Offset = "0x1A8C250", VA = "0x181A8D450")]
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
		private const int EBBOPNEDCPL = 10;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int LMOEOCGHDIG = 10;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int DABDGJMHIEI = 5;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float IPPHCLMLLBG = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const long NGIGLEHJPIC = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string AEEDGOKGKEF = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static bool KMOBPHAEFED;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static bool PMHELGALBGH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static int CGMCAODNLIP;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static int GBAHOIHAADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private MAFPBPHMEIP LNAGPGAJBEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private bool HHJDFAFFLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float GEEIILBKAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float PMPKLOKJJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int MOMIDOJHPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int HDLGFKBDBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int? KGGCBKLPCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int? CODEJLOOGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private long LPBDFCPAMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private string NLPCNGHPOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private long EFICAPHFFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Dictionary<string, object> BOICFBAACCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private KEJFBHKLOMK BBJFGHALHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int KLJBLBOKDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int IOHDHGPEFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float MPOEBJCPDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool LICNADBMLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool ENILJCOMLNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> EMMIHJLBIKG;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo JKNFCFKGLNN;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static string KFLMIFBLAPF;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private const string JGPIKDJBDFE = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private const string JIBBOBFICHH = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private EFEFMHJPJIJ BMLHHONEDGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x385A9D0", Offset = "0x38597D0", VA = "0x18385A9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int CMDHDIEMIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x385B130", Offset = "0x3859F30", VA = "0x18385B130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long HFCOPCCCFBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x385C9E0", Offset = "0x385B7E0", VA = "0x18385C9E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x385CAE0", Offset = "0x385B8E0", VA = "0x18385CAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string IHLKNNKEGHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x385C9B0", Offset = "0x385B7B0", VA = "0x18385C9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string KFMCHKJANAP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x536420", Offset = "0x535220", VA = "0x180536420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x536B50", Offset = "0x535950", VA = "0x180536B50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PCCJHHABHCM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4569A0", Offset = "0x4557A0", VA = "0x1804569A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA81D80", Offset = "0xA80B80", VA = "0x180A81D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> HHDKCOGPHNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x385C910", Offset = "0x385B710", VA = "0x18385C910")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x385CA40", Offset = "0x385B840", VA = "0x18385CA40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x38598C0", Offset = "0x38586C0", VA = "0x1838598C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x385C2F0", Offset = "0x385B0F0", VA = "0x18385C2F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x385B910", Offset = "0x385A710", VA = "0x18385B910", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x385C470", Offset = "0x385B270", VA = "0x18385C470")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3859D00", Offset = "0x3858B00", VA = "0x183859D00")]
		private bool BHEANPAOPOA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x385AD90", Offset = "0x3859B90", VA = "0x18385AD90")]
		[IteratorStateMachine(typeof(GLPIJBGIAGO))]
		public IEnumerator<KENFJGFMIPM> Initialize(AmplitudeAnalyticsEvent LNAFLFNFDIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x385C3C0", Offset = "0x385B1C0", VA = "0x18385C3C0")]
		public void UpdateLastAliveTime(float POGAEJIEPIM = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x385A860", Offset = "0x3859660", VA = "0x18385A860")]
		private bool HJPIFKNBGJA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x385A250", Offset = "0x3859050", VA = "0x18385A250")]
		private bool EHJFPCAMLIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x385BF80", Offset = "0x385AD80", VA = "0x18385BF80")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3859D10", Offset = "0x3858B10", VA = "0x183859D10")]
		[IteratorStateMachine(typeof(HJCILLMECLK))]
		private IEnumerator CMDNJJPDAGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x385C780", Offset = "0x385B580", VA = "0x18385C780")]
		[IteratorStateMachine(typeof(MGIAJKFAIMP))]
		public IEnumerator WaitForFlush(float DJJMDAINGCG = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x385C300", Offset = "0x385B100", VA = "0x18385C300")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x385AAA0", Offset = "0x38598A0", VA = "0x18385AAA0")]
		public static ICBHDPFJBKD Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3859780", Offset = "0x3858580", VA = "0x183859780")]
		public static CCNBJFOPLBG AccountSelectionPostLoginEvent([NotNull] string JMDCOMHKKAN, string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x385A430", Offset = "0x3859230", VA = "0x18385A430")]
		public static CCNBJFOPLBG Event([NotNull] string JMDCOMHKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x385BB90", Offset = "0x385A990", VA = "0x18385BB90")]
		public static CCNBJFOPLBG PreviousSessionEvent([NotNull] string JMDCOMHKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x385ABE0", Offset = "0x38599E0", VA = "0x18385ABE0")]
		public static CCNBJFOPLBG InitializeEvent(string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x385C090", Offset = "0x385AE90", VA = "0x18385C090")]
		public static CCNBJFOPLBG StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3859D70", Offset = "0x3858B70", VA = "0x183859D70")]
		public static CCNBJFOPLBG CreateOutOfSessionEvent(string JMDCOMHKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x385B560", Offset = "0x385A360", VA = "0x18385B560")]
		public static DABKFAIHBBP LogOutOfSessionEvent(CCNBJFOPLBG EMGIIALFJEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x385B350", Offset = "0x385A150", VA = "0x18385B350")]
		public void LogEventAsync(AmplitudeAnalyticsEvent EIANIOCNJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x385B730", Offset = "0x385A530", VA = "0x18385B730")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent EIANIOCNJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x385B820", Offset = "0x385A620", VA = "0x18385B820")]
		public void LogSerializedEventAsync(Dictionary<string, object> OGFGPCCGGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x385B450", Offset = "0x385A250", VA = "0x18385B450")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HNNMMGFNPOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x385AE00", Offset = "0x3859C00", VA = "0x18385AE00")]
		private void JFGMGIDFKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x385AEE0", Offset = "0x3859CE0", VA = "0x18385AEE0")]
		private void KLICCPHKPAK(Dictionary<string, object> JFKDDPJDCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x385BA80", Offset = "0x385A880", VA = "0x18385BA80")]
		private void PNHILKHLNEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x385A020", Offset = "0x3858E20", VA = "0x18385A020")]
		private void EBHHHJJPPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x385A760", Offset = "0x3859560", VA = "0x18385A760")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x385A7F0", Offset = "0x38595F0", VA = "0x18385A7F0")]
		[IteratorStateMachine(typeof(PCHPKDLPKDK))]
		private IEnumerator<KENFJGFMIPM> GDNCPJOIAMO(float DJJMDAINGCG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x385A6F0", Offset = "0x38594F0", VA = "0x18385A6F0")]
		[IteratorStateMachine(typeof(HGKAALJHHEM))]
		private IEnumerator<KENFJGFMIPM> FOIOMKBBHPA(float DJJMDAINGCG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x38596D0", Offset = "0x38584D0", VA = "0x1838596D0")]
		[IteratorStateMachine(typeof(PFAKAPIEPOC))]
		private IEnumerator<KENFJGFMIPM> AGJOIPCNEOD(LGNIKEMIHIE ONOBMHNFCHB, int? MADLMGFMFMN, string KCDNNDGKINC, string CPPKDDGBGFI, float DJJMDAINGCG, Action<int> ELEPHKHJNPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x385B990", Offset = "0x385A790", VA = "0x18385B990")]
		private static void PBFPIKPIFKG(bool LHJKDKNHECD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x17720E0", Offset = "0x1770EE0", VA = "0x1817720E0")]
		private global::PMGCJEPKFOF<DDAGJMCHCED<T>> GIBPCILMHIA<T>(string KCDNNDGKINC, string CPPKDDGBGFI, T PHFDPICANAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1771DB0", Offset = "0x1770BB0", VA = "0x181771DB0")]
		private global::PMGCJEPKFOF<DDAGJMCHCED<T>> GIBPCILMHIA<T>(string KCDNNDGKINC, string CPPKDDGBGFI, string KCCLHCJAIJI, T PHFDPICANAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x385A200", Offset = "0x3859000", VA = "0x18385A200")]
		private bool EEFIJLDABPN(float JODPOANPJNK, float DJJMDAINGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x385C850", Offset = "0x385B650", VA = "0x18385C850")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x385A590", Offset = "0x3859390", VA = "0x18385A590")]
		[CompilerGenerated]
		private long FEFMHFKCNHI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x385AED0", Offset = "0x3859CD0", VA = "0x18385AED0")]
		[CompilerGenerated]
		private void JPHKKFIBIKG(int OPGBFHMGPAH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string event_type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		internal Dictionary<string, object> event_properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		internal Dictionary<string, object> groups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x4335D0", Offset = "0x4323D0", VA = "0x1804335D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x385D030", Offset = "0x385BE30", VA = "0x18385D030")]
		public static CCNBJFOPLBG NFHADFCEMML(string HNPBHLIOFNC, [NotNull] string JMDCOMHKKAN, long FOGIDAPKPPH, long ODOHHNIMGIM, [Optional] string IGANOAGGFJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x385CE70", Offset = "0x385BC70", VA = "0x18385CE70")]
		public static CCNBJFOPLBG HLKAEHCLFJC(string HNPBHLIOFNC, [NotNull] string JMDCOMHKKAN, long FOGIDAPKPPH, long ODOHHNIMGIM, string IGANOAGGFJJ, long KLGCHPCCIEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x385D110", Offset = "0x385BF10", VA = "0x18385D110")]
		private AmplitudeAnalyticsEvent(string HNPBHLIOFNC, [NotNull] string JMDCOMHKKAN, long FOGIDAPKPPH, long ODOHHNIMGIM, [Optional] string IGANOAGGFJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x703580", Offset = "0x702380", VA = "0x180703580")]
		public void NBBAILPLAME(long NLCNLKLECAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		public AmplitudeAnalyticsEvent JOBHLMFKFNO<T>(string KOOIDPHIAIA, T[] ONGBFDACHHG) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x385CFB0", Offset = "0x385BDB0", VA = "0x18385CFB0")]
		public AmplitudeAnalyticsEvent JOBHLMFKFNO(string KOOIDPHIAIA, string[] ONGBFDACHHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		public AmplitudeAnalyticsEvent JOBHLMFKFNO<T>(string KOOIDPHIAIA, T ONGBFDACHHG) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x385CF60", Offset = "0x385BD60", VA = "0x18385CF60")]
		public AmplitudeAnalyticsEvent JOBHLMFKFNO(string KOOIDPHIAIA, string ONGBFDACHHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x385CDD0", Offset = "0x385BBD0", VA = "0x18385CDD0")]
		private AmplitudeAnalyticsEvent FNHCBLEPHIF(string KOOIDPHIAIA, object ONGBFDACHHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x385CB40", Offset = "0x385B940", VA = "0x18385CB40")]
		private string AAKODJMFMKO(string ONGBFDACHHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x385CFC0", Offset = "0x385BDC0", VA = "0x18385CFC0", Slot = "5")]
		public override void LHJKMBOGMCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x385CB70", Offset = "0x385B970", VA = "0x18385CB70", Slot = "4")]
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
			public string os_name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public string os_version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public string device_brand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string device_manufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string device_model;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public string device_type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x385DA50", Offset = "0x385C850", VA = "0x18385DA50")]
			public void NADFBGIJJLM(Dictionary<string, object> DKEFODEJBEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3F5100", Offset = "0x3F3F00", VA = "0x1803F5100")]
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

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x3861090", Offset = "0x385FE90", VA = "0x183861090")]
			public void NADFBGIJJLM(Dictionary<string, object> DKEFODEJBEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x100AD60", Offset = "0x1009B60", VA = "0x18100AD60")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		protected readonly string user_id;

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
		internal Dictionary<string, object> user_properties;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x385D6C0", Offset = "0x385C4C0", VA = "0x18385D6C0")]
		public static ICBHDPFJBKD NFHADFCEMML(string HNPBHLIOFNC, string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x385D760", Offset = "0x385C560", VA = "0x18385D760")]
		protected AmplitudeAnalyticsIdentifyMessage(string HNPBHLIOFNC, [Optional] string IGANOAGGFJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x385D290", Offset = "0x385C090", VA = "0x18385D290")]
		public Dictionary<string, object> CGKHPNNLKDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x385D300", Offset = "0x385C100", VA = "0x18385D300", Slot = "4")]
		protected virtual Dictionary<string, object> FCFGBBENGPC(Dictionary<string, object> ICPCGIMPCGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x385D620", Offset = "0x385C420", VA = "0x18385D620")]
		protected void MMMPHAOAJCB(string DNGKIAJLLHG, Dictionary<string, object> JKAELHGHJAJ, Dictionary<string, object> GKLOGJJFBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x385D540", Offset = "0x385C340", VA = "0x18385D540")]
		protected void HCMAEDCGBIH(string DNGKIAJLLHG, string ONGBFDACHHG, Dictionary<string, object> PMMGDNALAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x385D5B0", Offset = "0x385C3B0", VA = "0x18385D5B0", Slot = "5")]
		public virtual void LHJKMBOGMCH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ICBHDPFJBKD : global::BBGJEKJBJCM<AmplitudeAnalyticsIdentifyMessage, ICBHDPFJBKD>
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override ICBHDPFJBKD OMDFMNJINFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x434BD0", Offset = "0x4339D0", VA = "0x180434BD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E20", Offset = "0x3F5C20", VA = "0x1803F6E20", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage MFBDEFCEDGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x385EC60", Offset = "0x385DA60", VA = "0x18385EC60")]
	public ICBHDPFJBKD(AmplitudeAnalyticsIdentifyMessage NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x385EBD0", Offset = "0x385D9D0", VA = "0x18385EBD0", Slot = "4")]
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

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override CCNBJFOPLBG OMDFMNJINFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x434BD0", Offset = "0x4339D0", VA = "0x180434BD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x385DA00", Offset = "0x385C800", VA = "0x18385DA00")]
	public CCNBJFOPLBG(AmplitudeAnalyticsEvent NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E20", Offset = "0x3F5C20", VA = "0x1803F6E20", Slot = "5")]
	public override AmplitudeAnalyticsEvent MFBDEFCEDGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x385D960", Offset = "0x385C760", VA = "0x18385D960", Slot = "4")]
	public override void LHJKMBOGMCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	public CCNBJFOPLBG JOBHLMFKFNO<T>(string KOOIDPHIAIA, T[] ONGBFDACHHG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x385D8E0", Offset = "0x385C6E0", VA = "0x18385D8E0")]
	public CCNBJFOPLBG JOBHLMFKFNO(string KOOIDPHIAIA, string[] ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1774EA0", Offset = "0x1773CA0", VA = "0x181774EA0")]
	public CCNBJFOPLBG JOBHLMFKFNO<T>(string KOOIDPHIAIA, T ONGBFDACHHG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x385D8F0", Offset = "0x385C6F0", VA = "0x18385D8F0")]
	public CCNBJFOPLBG JOBHLMFKFNO(string KOOIDPHIAIA, string ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x385D800", Offset = "0x385C600", VA = "0x18385D800")]
	private CCNBJFOPLBG FNHCBLEPHIF(string KOOIDPHIAIA, object ONGBFDACHHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JOAOPMIJNMM : CCNBJFOPLBG
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x385DA00", Offset = "0x385C800", VA = "0x18385DA00")]
	public JOAOPMIJNMM(AmplitudeAnalyticsEvent NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x385ECB0", Offset = "0x385DAB0", VA = "0x18385ECB0", Slot = "4")]
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

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public abstract BLDR OMDFMNJINFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1A83E00", Offset = "0x1A82C00", VA = "0x181A83E00")]
	public BBGJEKJBJCM(M NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1A83DA0", Offset = "0x1A82BA0", VA = "0x181A83DA0")]
	public BLDR IADLHONHOKB(AmplitudeAnalyticsIdentifyMessage.DeviceInfo AJAAOHEMPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1A83DD0", Offset = "0x1A82BD0", VA = "0x181A83DD0")]
	public BLDR IICOEBCDPNM(AmplitudeAnalyticsIdentifyMessage.RevenueData HLPAKKPJOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1A83D30", Offset = "0x1A82B30", VA = "0x181A83D30")]
	public BLDR FHKPFOMIHLE(string KOOIDPHIAIA, string ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1774100", Offset = "0x1772F00", VA = "0x181774100")]
	public BLDR FHKPFOMIHLE<T>(string KOOIDPHIAIA, T ONGBFDACHHG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LHJKMBOGMCH();

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1A83C20", Offset = "0x1A82A20", VA = "0x181A83C20")]
	internal static string AAKODJMFMKO(string ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1A83C50", Offset = "0x1A82A50", VA = "0x181A83C50")]
	private BLDR EBLEMBLJOLH(string KOOIDPHIAIA, object ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
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

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3F5100", Offset = "0x3F3F00", VA = "0x1803F5100")]
	public GGICANINMLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MAFPBPHMEIP
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string ICKMCNMKFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string PDGHPHCFECP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
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

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5667D0", Offset = "0x5655D0", VA = "0x1805667D0")]
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

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3F5100", Offset = "0x3F3F00", VA = "0x1803F5100")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x385DB70", Offset = "0x385C970", VA = "0x18385DB70")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x385DC70", Offset = "0x385CA70", VA = "0x18385DC70")]
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

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3F5100", Offset = "0x3F3F00", VA = "0x1803F5100")]
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
