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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IOMNJOCFLNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x415E10", Offset = "0x415210", VA = "0x180415E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x896940", Offset = "0x895D40", VA = "0x180896940")]
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
				[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
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
				[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
				public ILBENLNNFMN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x3883250", Offset = "0x3882650", VA = "0x183883250")]
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
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x3884180", Offset = "0x3883580", VA = "0x183884180")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? LDOCMGKGOOK
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x3884BA0", Offset = "0x3883FA0", VA = "0x183884BA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3884C50", Offset = "0x3884050", VA = "0x183884C50")]
			internal LGNIKEMIHIE(string MEIIMAIGBJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3884210", Offset = "0x3883610", VA = "0x183884210")]
			public int GHICFPNGGOD([Optional] int? MADLMGFMFMN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3883D20", Offset = "0x3883120", VA = "0x183883D20")]
			public List<Dictionary<string, object>> AHDGOECGFHE(int BBPAOGDGDOI, int? MADLMGFMFMN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3884900", Offset = "0x3883D00", VA = "0x183884900")]
			public void MEAKBDKDFKF(AmplitudeAnalyticsIdentifyMessage NLNHFEEMFBN, bool BPPFJEHCKFL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x38849A0", Offset = "0x3883DA0", VA = "0x1838849A0")]
			public void MEAKBDKDFKF(Dictionary<string, object> NLNHFEEMFBN, bool BPPFJEHCKFL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3883F20", Offset = "0x3883320", VA = "0x183883F20")]
			public void DAKLDLDFDJI(params Dictionary<string, object>[] HHLLJLDFBPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3883B00", Offset = "0x3882F00", VA = "0x183883B00")]
			public void ADOEAIINDBN(List<Dictionary<string, object>> PPPMBOLNNBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3884A90", Offset = "0x3883E90", VA = "0x183884A90")]
			private void MOBOEANLOCA(Dictionary<string, object> NLNHFEEMFBN, bool BPPFJEHCKFL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3884710", Offset = "0x3883B10", VA = "0x183884710")]
			public void IGCBDPJHEHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3884370", Offset = "0x3883770", VA = "0x183884370")]
			public void IECOIFMKKHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3884050", Offset = "0x3883450", VA = "0x183884050")]
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
			[Cpp2IlInjected.Address(RVA = "0x3884E30", Offset = "0x3884230", VA = "0x183884E30")]
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
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
			[DebuggerHidden]
			public FCPECEOLIKP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3881E70", Offset = "0x3881270", VA = "0x183881E70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3882580", Offset = "0x3881980", VA = "0x183882580", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
			[DebuggerHidden]
			public JHKKHMGNLOM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x38832B0", Offset = "0x38826B0", VA = "0x1838832B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3883380", Offset = "0x3882780", VA = "0x183883380", Slot = "8")]
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
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
			[DebuggerHidden]
			public JKKMONDAPLG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x38833D0", Offset = "0x38827D0", VA = "0x1838833D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x38834E0", Offset = "0x38828E0", VA = "0x1838834E0", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
			[DebuggerHidden]
			public HIJBJJMNHNH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3882C50", Offset = "0x3882050", VA = "0x183882C50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3882E90", Offset = "0x3882290", VA = "0x183882E90", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
			[DebuggerHidden]
			public IAIPJKDLMCC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3882EE0", Offset = "0x38822E0", VA = "0x183882EE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3883120", Offset = "0x3882520", VA = "0x183883120", Slot = "8")]
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

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
			public LDOLLAOHLDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3883660", Offset = "0x3882A60", VA = "0x183883660")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3883700", Offset = "0x3882B00", VA = "0x183883700")]
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
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
			[DebuggerHidden]
			public FCDCNPNBJJM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x3881820", Offset = "0x3880C20", VA = "0x183881820", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3881E20", Offset = "0x3881220", VA = "0x183881E20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class HLNJLKDJCDM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x12B5D40", Offset = "0x12B5140", VA = "0x1812B5D40")]
			public HLNJLKDJCDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1B39AC0", Offset = "0x1B38EC0", VA = "0x181B39AC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x387E6E0", Offset = "0x387DAE0", VA = "0x18387E6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int CMDHDIEMIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x387EDD0", Offset = "0x387E1D0", VA = "0x18387EDD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long HFCOPCCCFBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3880660", Offset = "0x387FA60", VA = "0x183880660")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3880760", Offset = "0x387FB60", VA = "0x183880760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string IHLKNNKEGHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3880630", Offset = "0x387FA30", VA = "0x183880630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string KFMCHKJANAP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9A3A00", Offset = "0x9A2E00", VA = "0x1809A3A00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9A7320", Offset = "0x9A6720", VA = "0x1809A7320")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PCCJHHABHCM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD15330", Offset = "0xD14730", VA = "0x180D15330")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB3A2E0", Offset = "0xB396E0", VA = "0x180B3A2E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> HHDKCOGPHNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3880590", Offset = "0x387F990", VA = "0x183880590")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x38806C0", Offset = "0x387FAC0", VA = "0x1838806C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x387D7A0", Offset = "0x387CBA0", VA = "0x18387D7A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3880020", Offset = "0x387F420", VA = "0x183880020")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x387F510", Offset = "0x387E910", VA = "0x18387F510", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x38801A0", Offset = "0x387F5A0", VA = "0x1838801A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x387DBB0", Offset = "0x387CFB0", VA = "0x18387DBB0")]
		private bool BHEANPAOPOA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x387EAA0", Offset = "0x387DEA0", VA = "0x18387EAA0")]
		[IteratorStateMachine(typeof(FCPECEOLIKP))]
		public IEnumerator<KENFJGFMIPM> Initialize(AmplitudeAnalyticsEvent LNAFLFNFDIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x38800F0", Offset = "0x387F4F0", VA = "0x1838800F0")]
		public void UpdateLastAliveTime(float POGAEJIEPIM = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x387E570", Offset = "0x387D970", VA = "0x18387E570")]
		private bool HJPIFKNBGJA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x387E0C0", Offset = "0x387D4C0", VA = "0x18387E0C0")]
		private bool EHJFPCAMLIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x387FCB0", Offset = "0x387F0B0", VA = "0x18387FCB0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x387DBD0", Offset = "0x387CFD0", VA = "0x18387DBD0")]
		[IteratorStateMachine(typeof(JHKKHMGNLOM))]
		private IEnumerator CMDNJJPDAGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3880400", Offset = "0x387F800", VA = "0x183880400")]
		[IteratorStateMachine(typeof(JKKMONDAPLG))]
		public IEnumerator WaitForFlush(float DJJMDAINGCG = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3880030", Offset = "0x387F430", VA = "0x183880030")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x387E7B0", Offset = "0x387DBB0", VA = "0x18387E7B0")]
		public static ICBHDPFJBKD Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x387D660", Offset = "0x387CA60", VA = "0x18387D660")]
		public static CCNBJFOPLBG AccountSelectionPostLoginEvent([NotNull] string JMDCOMHKKAN, string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x387E2A0", Offset = "0x387D6A0", VA = "0x18387E2A0")]
		public static CCNBJFOPLBG Event([NotNull] string JMDCOMHKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x387F8C0", Offset = "0x387ECC0", VA = "0x18387F8C0")]
		public static CCNBJFOPLBG PreviousSessionEvent([NotNull] string JMDCOMHKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x387E8F0", Offset = "0x387DCF0", VA = "0x18387E8F0")]
		public static CCNBJFOPLBG InitializeEvent(string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x387FDC0", Offset = "0x387F1C0", VA = "0x18387FDC0")]
		public static CCNBJFOPLBG StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x387DC30", Offset = "0x387D030", VA = "0x18387DC30")]
		public static CCNBJFOPLBG CreateOutOfSessionEvent(string JMDCOMHKKAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x387F1A0", Offset = "0x387E5A0", VA = "0x18387F1A0")]
		public static DABKFAIHBBP LogOutOfSessionEvent(CCNBJFOPLBG EMGIIALFJEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x387EFF0", Offset = "0x387E3F0", VA = "0x18387EFF0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent EIANIOCNJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x387F370", Offset = "0x387E770", VA = "0x18387F370")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent EIANIOCNJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x387F440", Offset = "0x387E840", VA = "0x18387F440")]
		public void LogSerializedEventAsync(Dictionary<string, object> OGFGPCCGGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x387F0C0", Offset = "0x387E4C0", VA = "0x18387F0C0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HNNMMGFNPOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x387EB10", Offset = "0x387DF10", VA = "0x18387EB10")]
		private void JFGMGIDFKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x387EBB0", Offset = "0x387DFB0", VA = "0x18387EBB0")]
		private void KLICCPHKPAK(Dictionary<string, object> JFKDDPJDCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x387F7E0", Offset = "0x387EBE0", VA = "0x18387F7E0")]
		private void PNHILKHLNEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x387DEE0", Offset = "0x387D2E0", VA = "0x18387DEE0")]
		private void EBHHHJJPPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x387E470", Offset = "0x387D870", VA = "0x18387E470")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x387E500", Offset = "0x387D900", VA = "0x18387E500")]
		[IteratorStateMachine(typeof(HIJBJJMNHNH))]
		private IEnumerator<KENFJGFMIPM> GDNCPJOIAMO(float DJJMDAINGCG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x387E400", Offset = "0x387D800", VA = "0x18387E400")]
		[IteratorStateMachine(typeof(IAIPJKDLMCC))]
		private IEnumerator<KENFJGFMIPM> FOIOMKBBHPA(float DJJMDAINGCG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x387D5B0", Offset = "0x387C9B0", VA = "0x18387D5B0")]
		[IteratorStateMachine(typeof(FCDCNPNBJJM))]
		private IEnumerator<KENFJGFMIPM> AGJOIPCNEOD(LGNIKEMIHIE ONOBMHNFCHB, int? MADLMGFMFMN, string KCDNNDGKINC, string CPPKDDGBGFI, float DJJMDAINGCG, Action<int> ELEPHKHJNPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x387F6F0", Offset = "0x387EAF0", VA = "0x18387F6F0")]
		private static void PBFPIKPIFKG(bool LHJKDKNHECD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x187B900", Offset = "0x187AD00", VA = "0x18187B900")]
		private global::PMGCJEPKFOF<DDAGJMCHCED<T>> GIBPCILMHIA<T>(string KCDNNDGKINC, string CPPKDDGBGFI, T PHFDPICANAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x187B5D0", Offset = "0x187A9D0", VA = "0x18187B5D0")]
		private global::PMGCJEPKFOF<DDAGJMCHCED<T>> GIBPCILMHIA<T>(string KCDNNDGKINC, string CPPKDDGBGFI, string KCCLHCJAIJI, T PHFDPICANAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x387E070", Offset = "0x387D470", VA = "0x18387E070")]
		private bool EEFIJLDABPN(float JODPOANPJNK, float DJJMDAINGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x38804D0", Offset = "0x387F8D0", VA = "0x1838804D0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x387F590", Offset = "0x387E990", VA = "0x18387F590")]
		[CompilerGenerated]
		private long PBEOIAOFGFO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x387DBC0", Offset = "0x387CFC0", VA = "0x18387DBC0")]
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
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x442950", Offset = "0x441D50", VA = "0x180442950")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3880C70", Offset = "0x3880070", VA = "0x183880C70")]
		public static CCNBJFOPLBG NFHADFCEMML(string HNPBHLIOFNC, [NotNull] string DDFOHKALPKN, long FOGIDAPKPPH, long ODOHHNIMGIM, string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3880A00", Offset = "0x387FE00", VA = "0x183880A00")]
		public static CCNBJFOPLBG HLKAEHCLFJC(string HNPBHLIOFNC, [NotNull] string DDFOHKALPKN, long FOGIDAPKPPH, long ODOHHNIMGIM, string BHBHMMAEFMK, long KLGCHPCCIEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3880D50", Offset = "0x3880150", VA = "0x183880D50")]
		private AmplitudeAnalyticsEvent(string HNPBHLIOFNC, [NotNull] string DDFOHKALPKN, long FOGIDAPKPPH, long ODOHHNIMGIM, string BHBHMMAEFMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7CFDE0", Offset = "0x7CF1E0", VA = "0x1807CFDE0")]
		public void NBBAILPLAME(long NLCNLKLECAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3880AF0", Offset = "0x387FEF0", VA = "0x183880AF0", Slot = "5")]
		public override void JEBCDGPBFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3880C00", Offset = "0x3880000", VA = "0x183880C00", Slot = "6")]
		public override void LHJKMBOGMCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x38807C0", Offset = "0x387FBC0", VA = "0x1838807C0", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x3881700", Offset = "0x3880B00", VA = "0x183881700")]
			public void NADFBGIJJLM(Dictionary<string, object> CACJCCOABOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3884D10", Offset = "0x3884110", VA = "0x183884D10")]
			public void NADFBGIJJLM(Dictionary<string, object> DKEFODEJBEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x119F760", Offset = "0x119EB60", VA = "0x18119F760")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5400", VA = "0x1803F6000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4055E0", Offset = "0x4049E0", VA = "0x1804055E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3881370", Offset = "0x3880770", VA = "0x183881370")]
		public static ICBHDPFJBKD NFHADFCEMML(string HNPBHLIOFNC, string BHBHMMAEFMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3881410", Offset = "0x3880810", VA = "0x183881410")]
		protected AmplitudeAnalyticsIdentifyMessage(string HNPBHLIOFNC, string BHBHMMAEFMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3880ED0", Offset = "0x38802D0", VA = "0x183880ED0")]
		public Dictionary<string, object> CGKHPNNLKDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3880F40", Offset = "0x3880340", VA = "0x183880F40", Slot = "4")]
		protected virtual Dictionary<string, object> FCFGBBENGPC(Dictionary<string, object> ICPCGIMPCGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x38812D0", Offset = "0x38806D0", VA = "0x1838812D0")]
		protected void MMMPHAOAJCB(string DNGKIAJLLHG, Dictionary<string, object> JKAELHGHJAJ, Dictionary<string, object> GKLOGJJFBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3881180", Offset = "0x3880580", VA = "0x183881180")]
		protected void HCMAEDCGBIH(string DNGKIAJLLHG, string ONGBFDACHHG, Dictionary<string, object> PMMGDNALAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x38811F0", Offset = "0x38805F0", VA = "0x1838811F0", Slot = "5")]
		public virtual void JEBCDGPBFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3881260", Offset = "0x3880660", VA = "0x183881260", Slot = "6")]
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
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x404140", Offset = "0x403540", VA = "0x180404140", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5400", VA = "0x1803F6000", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage MFBDEFCEDGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3883200", Offset = "0x3882600", VA = "0x183883200")]
	public ICBHDPFJBKD(AmplitudeAnalyticsIdentifyMessage NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3883170", Offset = "0x3882570", VA = "0x183883170", Slot = "4")]
	public override void LHJKMBOGMCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CCNBJFOPLBG : global::BBGJEKJBJCM<AmplitudeAnalyticsEvent, CCNBJFOPLBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool JNPECPPECNJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override CCNBJFOPLBG OMDFMNJINFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x404140", Offset = "0x403540", VA = "0x180404140", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x38816B0", Offset = "0x3880AB0", VA = "0x1838816B0")]
	public CCNBJFOPLBG(AmplitudeAnalyticsEvent NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5400", VA = "0x1803F6000", Slot = "5")]
	public override AmplitudeAnalyticsEvent MFBDEFCEDGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3881610", Offset = "0x3880A10", VA = "0x183881610", Slot = "4")]
	public override void LHJKMBOGMCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	public CCNBJFOPLBG JOBHLMFKFNO<T>(string KOOIDPHIAIA, T[] ONGBFDACHHG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3881590", Offset = "0x3880990", VA = "0x183881590")]
	public CCNBJFOPLBG JOBHLMFKFNO(string KOOIDPHIAIA, string[] ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x187E6C0", Offset = "0x187DAC0", VA = "0x18187E6C0")]
	public CCNBJFOPLBG JOBHLMFKFNO<T>(string KOOIDPHIAIA, T ONGBFDACHHG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x38815A0", Offset = "0x38809A0", VA = "0x1838815A0")]
	public CCNBJFOPLBG JOBHLMFKFNO(string KOOIDPHIAIA, string ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x38814B0", Offset = "0x38808B0", VA = "0x1838814B0")]
	private CCNBJFOPLBG FNHCBLEPHIF(string KOOIDPHIAIA, object ONGBFDACHHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JOAOPMIJNMM : CCNBJFOPLBG
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x38816B0", Offset = "0x3880AB0", VA = "0x1838816B0")]
	public JOAOPMIJNMM(AmplitudeAnalyticsEvent NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3883530", Offset = "0x3882930", VA = "0x183883530", Slot = "4")]
	public override void LHJKMBOGMCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class BBGJEKJBJCM<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::BBGJEKJBJCM<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	protected M NGPMADFHHKP;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public abstract BLDR OMDFMNJINFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1B31CE0", Offset = "0x1B310E0", VA = "0x181B31CE0")]
	public BBGJEKJBJCM(M NGPMADFHHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1B31C80", Offset = "0x1B31080", VA = "0x181B31C80")]
	public BLDR IADLHONHOKB(AmplitudeAnalyticsIdentifyMessage.DeviceInfo AJAAOHEMPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1B31CB0", Offset = "0x1B310B0", VA = "0x181B31CB0")]
	public BLDR IICOEBCDPNM(AmplitudeAnalyticsIdentifyMessage.RevenueData HLPAKKPJOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1B31C10", Offset = "0x1B31010", VA = "0x181B31C10")]
	public BLDR FHKPFOMIHLE(string KOOIDPHIAIA, string ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x187D920", Offset = "0x187CD20", VA = "0x18187D920")]
	public BLDR FHKPFOMIHLE<T>(string KOOIDPHIAIA, T ONGBFDACHHG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LHJKMBOGMCH();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1B31B00", Offset = "0x1B30F00", VA = "0x181B31B00")]
	internal static string AAKODJMFMKO(string ONGBFDACHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1B31B30", Offset = "0x1B30F30", VA = "0x181B31B30")]
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
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public const int JEAKKDAPKLL = 2;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public const int NGPHFJNCCCA = 100;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int GNOFDLPOFMN = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const long BFGMODBDIGA = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const int BBGGHOBBLDJ = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const int ODHJBJMMCBO = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const string APPANLPPDPG = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const string KIKNHAHFGCK = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string PPOLJMJHAJH = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string KPAHPMNHLBP = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string KDBLMDDNOOE = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string JGDEPBBPNFJ = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string OAHHLPLBPHJ = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string KHIJGCAGIPG = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const int JFIEBABNINC = 10;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> OGLGKCNJJJO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
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
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string PDGHPHCFECP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::PMGCJEPKFOF<OADHHEBMJOA> GIBPCILMHIA(string KCDNNDGKINC, Dictionary<string, string> LOGDHPJIFFN);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OADHHEBMJOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly int LLODNIOIDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly string DKPCLPHKFDI;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x66F900", Offset = "0x66ED00", VA = "0x18066F900")]
	public OADHHEBMJOA(int LMOEMCOMALK, string HFOCDNIDIBO)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FFAFDAOBAHN
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static byte[] OHCLMBBDJLC;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static int NJPHPOMKGAO;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int NCHLFMFMLBC;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static BigInteger AEEDJIDCNEO;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
	public FFAFDAOBAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x38825D0", Offset = "0x38819D0", VA = "0x1838825D0")]
	private static string IHFKDHGIIEJ(byte[] FOJLJNMAJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x38826D0", Offset = "0x3881AD0", VA = "0x1838826D0")]
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

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
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
