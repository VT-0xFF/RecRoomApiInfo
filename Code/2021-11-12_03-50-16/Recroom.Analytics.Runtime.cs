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
		public AmplitudeAnalyticsClient.Settings FKEADFHHOJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IPGEEDOMELL
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x425160", Offset = "0x424360", VA = "0x180425160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xADA6E0", Offset = "0xAD98E0", VA = "0x180ADA6E0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum HCFOOPDHDHD
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class NNINCDMLDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class KBJBGOCFJCC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public int DHDLMGAOMEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public Dictionary<string, object> KGFIOCNECIO;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
				public KBJBGOCFJCC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class PKMKAJPKGEJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
				public PKMKAJPKGEJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x3CFB8A0", Offset = "0x3CFAAA0", VA = "0x183CFB8A0")]
				internal bool <GetBatch>b__0(KBJBGOCFJCC item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private const string CFDCKLBLNBD = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string KONGDOPNDNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<KBJBGOCFJCC> GFIMAHFGAPH;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? APDLGINAHBF
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x3CFB1F0", Offset = "0x3CFA3F0", VA = "0x183CFB1F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? OPPPBGBLFPB
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x3CFAC70", Offset = "0x3CF9E70", VA = "0x183CFAC70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3CFB670", Offset = "0x3CFA870", VA = "0x183CFB670")]
			internal NNINCDMLDHJ(string CALEMJGFKBL, string DGBBJEBIFNF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3CFAE30", Offset = "0x3CFA030", VA = "0x183CFAE30")]
			public int HBFPKOFEEHN([Optional] int? PBEHFDALIIC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3CFB280", Offset = "0x3CFA480", VA = "0x183CFB280")]
			public List<Dictionary<string, object>> NHFOBPBBLJG(int CLGLDPFMNAM, int? PBEHFDALIIC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3CFA9B0", Offset = "0x3CF9BB0", VA = "0x183CFA9B0")]
			public void DAMGLGBEFCH(AmplitudeAnalyticsIdentifyMessage NKNAILFIDNK, bool FJEKOHIALFO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3CFA8C0", Offset = "0x3CF9AC0", VA = "0x183CFA8C0")]
			public void DAMGLGBEFCH(Dictionary<string, object> NKNAILFIDNK, bool FJEKOHIALFO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3CFB0C0", Offset = "0x3CFA2C0", VA = "0x183CFB0C0")]
			public void ILNKDCDGOMM(params Dictionary<string, object>[] JIIPMBMIAPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3CFAA50", Offset = "0x3CF9C50", VA = "0x183CFAA50")]
			public void DDAMMOBCIDJ(List<Dictionary<string, object>> CCGGKBFNGEP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3CFAD20", Offset = "0x3CF9F20", VA = "0x183CFAD20")]
			private void DFLDFNJLLEH(Dictionary<string, object> NKNAILFIDNK, bool FJEKOHIALFO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3CFB480", Offset = "0x3CFA680", VA = "0x183CFB480")]
			public void OEHMPDKNBIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3CFA4F0", Offset = "0x3CF96F0", VA = "0x183CFA4F0")]
			private void ABJLHNNKBPP([Optional] string HADFBOEALLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3CFAF90", Offset = "0x3CFA190", VA = "0x183CFAF90")]
			private static string IIJACHIIPOK(string NAOGMHDFAEF, string BGJKOMDILFD)
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
			[Cpp2IlInjected.Address(RVA = "0x3CFBA20", Offset = "0x3CFAC20", VA = "0x183CFBA20")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct IMFGAOFDFBL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int EIEKCPIJJKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public string HCJCKCBEDIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T JPMFKKBAFML;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class HICOAFAHFIH : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private EJFBNPFIIDA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
			[DebuggerHidden]
			public HICOAFAHFIH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3CF9A00", Offset = "0x3CF8C00", VA = "0x183CF9A00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3CFA120", Offset = "0x3CF9320", VA = "0x183CFA120", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class FPCALMFECEL : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
			[DebuggerHidden]
			public FPCALMFECEL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3CF8FC0", Offset = "0x3CF81C0", VA = "0x183CF8FC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3CF9090", Offset = "0x3CF8290", VA = "0x183CF9090", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EAAGALPDAOI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
			[DebuggerHidden]
			public EAAGALPDAOI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3CF8BA0", Offset = "0x3CF7DA0", VA = "0x183CF8BA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3CF8CE0", Offset = "0x3CF7EE0", VA = "0x183CF8CE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class EDHKEDMEELO : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private EJFBNPFIIDA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
			[DebuggerHidden]
			public EDHKEDMEELO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3CF8D30", Offset = "0x3CF7F30", VA = "0x183CF8D30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3CF8F70", Offset = "0x3CF8170", VA = "0x183CF8F70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class GBBBFEFGFCH : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private EJFBNPFIIDA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
			[DebuggerHidden]
			public GBBBFEFGFCH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3CF90E0", Offset = "0x3CF82E0", VA = "0x183CF90E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3CF9320", Offset = "0x3CF8520", VA = "0x183CF9320", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class ADFEGLNNGFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public NNINCDMLDHJ cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
			public ADFEGLNNGFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3CF3E80", Offset = "0x3CF3080", VA = "0x183CF3E80")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3CF3F20", Offset = "0x3CF3120", VA = "0x183CF3F20")]
			internal void <FlushFromCache>b__1(IMFGAOFDFBL<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class GNKLJBLEMJC : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private EJFBNPFIIDA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public NNINCDMLDHJ cache;

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
			private ADFEGLNNGFN <>8__1;

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
			private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
			[DebuggerHidden]
			public GNKLJBLEMJC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x3CF9370", Offset = "0x3CF8570", VA = "0x183CF9370", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3CF99B0", Offset = "0x3CF8BB0", VA = "0x183CF99B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class CCHPNJKPIJP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
			public CCHPNJKPIJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2F02010", Offset = "0x2F01210", VA = "0x182F02010")]
			internal IMFGAOFDFBL<T> <PostJson>b__0(DIEMCFLKCGA postResponse)
			{
				return default(IMFGAOFDFBL<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private KANAIOJBHFK JAMMNFJAPHB;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string MCIPHCMHHPK = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string HPBIICPHCHP = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string LIKONCOLHOG = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string IKMIPDEOICJ = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string IIOIKOINBKA = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int GLACPAIPOKJ = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int JMDLBJLGOFN = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int CPNNNIAIPMM = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float JBJOABAKAAI = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long NMPNAALEPHL = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string IHGLGGCGLPN = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static bool GHAODOFANAP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool KLLFJPLCOON;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static int ICHAPDMOOMP;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int OBIDHLMFKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private KAGKMFKAPMJ BPIHPFGEPIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool BBEJBLLBGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float MAPODIBFKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float JPMAAAIBNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int OEOFOHCKNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int PILAOMDGJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int? GKCEEPGOICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? PNCCONAHFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private long KBKMDMMGMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string LECLCHEJDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long HPGHOJEPAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, object> MHCNGLEEKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private HCFOOPDHDHD DMJGNPIEPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int FGLDMFJIJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int NCBDFMGKKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float ELCHPEKNOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool AGLLDCLBFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool DAHEJEOEMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private NNINCDMLDHJ DNFKIBAAIDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private NNINCDMLDHJ AIAOJDAGJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NNINCDMLDHJ GNMABMPGGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> CCBDHJEIHNN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo EGKLLLMKHJN;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static string LBGJHACFDOO;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string NPAHPHFGHJL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string HOMHPLJANII = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private KANAIOJBHFK JJPPOHHFBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3CF4780", Offset = "0x3CF3980", VA = "0x183CF4780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int IHBBBDCHJBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3CF6340", Offset = "0x3CF5540", VA = "0x183CF6340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long KBADOEECMJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3CF7650", Offset = "0x3CF6850", VA = "0x183CF7650")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3CF7750", Offset = "0x3CF6950", VA = "0x183CF7750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string FMLMBFBHOPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3CF7620", Offset = "0x3CF6820", VA = "0x183CF7620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string IFEBOGDMHMB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x448950", Offset = "0x447B50", VA = "0x180448950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x436A40", Offset = "0x435C40", VA = "0x180436A40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool FLOLLBKNDJK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4DEFC0", Offset = "0x4DE1C0", VA = "0x1804DEFC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB92410", Offset = "0xB91610", VA = "0x180B92410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool EEKDGAGKGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3CF7540", Offset = "0x3CF6740", VA = "0x183CF7540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> FAGIOBJCENL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3CF74A0", Offset = "0x3CF66A0", VA = "0x183CF74A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3CF76B0", Offset = "0x3CF68B0", VA = "0x183CF76B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4990", Offset = "0x3CF3B90", VA = "0x183CF4990", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6F30", Offset = "0x3CF6130", VA = "0x183CF6F30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6660", Offset = "0x3CF5860", VA = "0x183CF6660", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3CF70B0", Offset = "0x3CF62B0", VA = "0x183CF70B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5750", Offset = "0x3CF4950", VA = "0x183CF5750")]
		private bool HAFNBBIAMLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5B80", Offset = "0x3CF4D80", VA = "0x183CF5B80")]
		[IteratorStateMachine(typeof(HICOAFAHFIH))]
		public IEnumerator<EJFBNPFIIDA> Initialize(AmplitudeAnalyticsEvent CPMFABEMAPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7000", Offset = "0x3CF6200", VA = "0x183CF7000")]
		public void UpdateLastAliveTime(float LJHLCFOBNPO = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4610", Offset = "0x3CF3810", VA = "0x183CF4610")]
		private bool AJGALAKHBOI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4430", Offset = "0x3CF3630", VA = "0x183CF4430")]
		private bool ABBBJDMCGAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6BC0", Offset = "0x3CF5DC0", VA = "0x183CF6BC0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6560", Offset = "0x3CF5760", VA = "0x183CF6560")]
		[IteratorStateMachine(typeof(FPCALMFECEL))]
		private IEnumerator MMLFHNPEHEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7310", Offset = "0x3CF6510", VA = "0x183CF7310")]
		[IteratorStateMachine(typeof(EAAGALPDAOI))]
		public IEnumerator WaitForFlush(float ABCAFDNOANB = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6F40", Offset = "0x3CF6140", VA = "0x183CF6F40")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5890", Offset = "0x3CF4A90", VA = "0x183CF5890")]
		public static PEAEKADKCDF Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4850", Offset = "0x3CF3A50", VA = "0x183CF4850")]
		public static KDBCICGABDL AccountSelectionPostLoginEvent([NotNull] string CBECMBHHHMB, string ELDKMOJEMJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5310", Offset = "0x3CF4510", VA = "0x183CF5310")]
		public static KDBCICGABDL Event([NotNull] string CBECMBHHHMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6790", Offset = "0x3CF5990", VA = "0x183CF6790")]
		public static KDBCICGABDL PreviousSessionEvent([NotNull] string CBECMBHHHMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3CF59D0", Offset = "0x3CF4BD0", VA = "0x183CF59D0")]
		public static KDBCICGABDL InitializeEvent(string ELDKMOJEMJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6CD0", Offset = "0x3CF5ED0", VA = "0x183CF6CD0")]
		public static KDBCICGABDL StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5060", Offset = "0x3CF4260", VA = "0x183CF5060")]
		public static KDBCICGABDL CreateOutOfSessionEvent(string CBECMBHHHMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5FD0", Offset = "0x3CF51D0", VA = "0x183CF5FD0")]
		public static FIIDGPMBKPK LogOutOfSessionEvent(KDBCICGABDL AGKMCJDNGNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5E20", Offset = "0x3CF5020", VA = "0x183CF5E20")]
		public void LogEventAsync(AmplitudeAnalyticsEvent JINANJAJNJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3CF61A0", Offset = "0x3CF53A0", VA = "0x183CF61A0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent JINANJAJNJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6270", Offset = "0x3CF5470", VA = "0x183CF6270")]
		public void LogSerializedEventAsync(Dictionary<string, object> JFNJOPPNGMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5EF0", Offset = "0x3CF50F0", VA = "0x183CF5EF0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage GNLAHNBCHKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3CF65C0", Offset = "0x3CF57C0", VA = "0x183CF65C0")]
		private void OAIACEKMNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5C00", Offset = "0x3CF4E00", VA = "0x183CF5C00")]
		private void JBEBKKNOGJN(Dictionary<string, object> BCFKOFKMLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF57B0", Offset = "0x3CF49B0", VA = "0x183CF57B0")]
		private void HMCDBLHKJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3CF54C0", Offset = "0x3CF46C0", VA = "0x183CF54C0")]
		private void FONCFFHLLIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3CF56C0", Offset = "0x3CF48C0", VA = "0x183CF56C0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5650", Offset = "0x3CF4850", VA = "0x183CF5650")]
		[IteratorStateMachine(typeof(EDHKEDMEELO))]
		private IEnumerator<EJFBNPFIIDA> FPMHPGBCAKP(float ABCAFDNOANB = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF43C0", Offset = "0x3CF35C0", VA = "0x183CF43C0")]
		[IteratorStateMachine(typeof(GBBBFEFGFCH))]
		private IEnumerator<EJFBNPFIIDA> AAEIAHBINHN(float ABCAFDNOANB = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3CF66E0", Offset = "0x3CF58E0", VA = "0x183CF66E0")]
		[IteratorStateMachine(typeof(GNKLJBLEMJC))]
		private IEnumerator<EJFBNPFIIDA> PGDFCONHCBO(NNINCDMLDHJ JBHPDMAJHIH, int? PBEHFDALIIC, string GGMCCKDHLBA, string GAFKDBAEDFK, float ABCAFDNOANB, Action<int> DLOPKNAHAPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4F70", Offset = "0x3CF4170", VA = "0x183CF4F70")]
		private static void COGGDHCECIN(bool BCBHOEDLJNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1E9EBC0", Offset = "0x1E9DDC0", VA = "0x181E9EBC0")]
		private global::MGLHMIMFOOP<IMFGAOFDFBL<T>> BMCJKPINGEG<T>(string GGMCCKDHLBA, string GAFKDBAEDFK, string PGEAJMDELMO, T JPMFKKBAFML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5470", Offset = "0x3CF4670", VA = "0x183CF5470")]
		private bool FDHOCCFEPMI(float NIHOHIHOBGF, float ABCAFDNOANB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3CF73E0", Offset = "0x3CF65E0", VA = "0x183CF73E0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4E10", Offset = "0x3CF4010", VA = "0x183CF4E10")]
		[CompilerGenerated]
		private long BCIMPBLHMIA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5BF0", Offset = "0x3CF4DF0", VA = "0x183CF5BF0")]
		[CompilerGenerated]
		private void JALNADDACCJ(int MOFBGJAAJJA)
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
			[Cpp2IlInjected.Address(RVA = "0x42B310", Offset = "0x42A510", VA = "0x18042B310")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3CF77B0", Offset = "0x3CF69B0", VA = "0x183CF77B0")]
		public static KDBCICGABDL AEKPMIMCBBN(string LINIBNLLKGO, [NotNull] string OPFBIOJHBPM, long FGDOLAFJLCP, long AMBJDJBLKMJ, string ELDKMOJEMJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7890", Offset = "0x3CF6A90", VA = "0x183CF7890")]
		public static KDBCICGABDL IBEPDNOLCNN(string LINIBNLLKGO, [NotNull] string OPFBIOJHBPM, long FGDOLAFJLCP, long AMBJDJBLKMJ, string ELDKMOJEMJI, long GKHCNKFNLLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7D40", Offset = "0x3CF6F40", VA = "0x183CF7D40")]
		private AmplitudeAnalyticsEvent(string LINIBNLLKGO, [NotNull] string OPFBIOJHBPM, long FGDOLAFJLCP, long AMBJDJBLKMJ, string ELDKMOJEMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x49BD00", Offset = "0x49AF00", VA = "0x18049BD00")]
		public void OGFMCOIGKAC(long MNOABNAJFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7C30", Offset = "0x3CF6E30", VA = "0x183CF7C30", Slot = "5")]
		public override void NPIEDNMOBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7980", Offset = "0x3CF6B80", VA = "0x183CF7980", Slot = "6")]
		public override void JAKKJFJKFJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3CF79F0", Offset = "0x3CF6BF0", VA = "0x183CF79F0", Slot = "4")]
		protected override Dictionary<string, object> NKNEENDIPOM(Dictionary<string, object> JCPPEPLANBJ)
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
			[Cpp2IlInjected.Address(RVA = "0x3CF8A80", Offset = "0x3CF7C80", VA = "0x183CF8A80")]
			public void OLJJEFJANDK(Dictionary<string, object> FGNNFCBGPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CFB900", Offset = "0x3CFAB00", VA = "0x183CFB900")]
			public void OLJJEFJANDK(Dictionary<string, object> HKDHADIFNAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xEBC2B0", Offset = "0xEBB4B0", VA = "0x180EBC2B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4251A0", Offset = "0x4243A0", VA = "0x1804251A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x425440", Offset = "0x424640", VA = "0x180425440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7F30", Offset = "0x3CF7130", VA = "0x183CF7F30")]
		public static PEAEKADKCDF AEKPMIMCBBN(string LINIBNLLKGO, string ELDKMOJEMJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8400", Offset = "0x3CF7600", VA = "0x183CF8400")]
		protected AmplitudeAnalyticsIdentifyMessage(string LINIBNLLKGO, string ELDKMOJEMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7EC0", Offset = "0x3CF70C0", VA = "0x183CF7EC0")]
		public Dictionary<string, object> ACBFJICDKHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8150", Offset = "0x3CF7350", VA = "0x183CF8150", Slot = "4")]
		protected virtual Dictionary<string, object> NKNEENDIPOM(Dictionary<string, object> JCPPEPLANBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7FD0", Offset = "0x3CF71D0", VA = "0x183CF7FD0")]
		protected void FDMBELAGHJK(string BGJKOMDILFD, Dictionary<string, object> BHOIDHHAOMN, Dictionary<string, object> KKJMPPPHKMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3CF80E0", Offset = "0x3CF72E0", VA = "0x183CF80E0")]
		protected void MMNFGECOPJH(string BGJKOMDILFD, string NAOGMHDFAEF, Dictionary<string, object> FEOMNGMPNKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8390", Offset = "0x3CF7590", VA = "0x183CF8390", Slot = "5")]
		public virtual void NPIEDNMOBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8070", Offset = "0x3CF7270", VA = "0x183CF8070", Slot = "6")]
		public virtual void JAKKJFJKFJN()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PEAEKADKCDF : global::JFHJIMEHOAF<AmplitudeAnalyticsIdentifyMessage, PEAEKADKCDF>
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override PEAEKADKCDF CEOLHCDKKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4B69A0", Offset = "0x4B5BA0", VA = "0x1804B69A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4251A0", Offset = "0x4243A0", VA = "0x1804251A0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage EGEGBONHMEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB850", Offset = "0x3CFAA50", VA = "0x183CFB850")]
	public PEAEKADKCDF(AmplitudeAnalyticsIdentifyMessage KAFEFHCLBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB7C0", Offset = "0x3CFA9C0", VA = "0x183CFB7C0", Slot = "4")]
	public override void JAKKJFJKFJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KDBCICGABDL : global::JFHJIMEHOAF<AmplitudeAnalyticsEvent, KDBCICGABDL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool DPAGOBPNFLP;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override KDBCICGABDL CEOLHCDKKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4B69A0", Offset = "0x4B5BA0", VA = "0x1804B69A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA370", Offset = "0x3CF9570", VA = "0x183CFA370")]
	public KDBCICGABDL(AmplitudeAnalyticsEvent KAFEFHCLBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4251A0", Offset = "0x4243A0", VA = "0x1804251A0", Slot = "5")]
	public override AmplitudeAnalyticsEvent EGEGBONHMEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA250", Offset = "0x3CF9450", VA = "0x183CFA250", Slot = "4")]
	public override void JAKKJFJKFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1EA7570", Offset = "0x1EA6770", VA = "0x181EA7570")]
	public KDBCICGABDL MILNBOFPKBD<T>(string NJHMKOJPAGJ, T[] NAOGMHDFAEF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA2F0", Offset = "0x3CF94F0", VA = "0x183CFA2F0")]
	public KDBCICGABDL MILNBOFPKBD(string NJHMKOJPAGJ, string[] NAOGMHDFAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1EA7500", Offset = "0x1EA6700", VA = "0x181EA7500")]
	public KDBCICGABDL MILNBOFPKBD<T>(string NJHMKOJPAGJ, T NAOGMHDFAEF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA300", Offset = "0x3CF9500", VA = "0x183CFA300")]
	public KDBCICGABDL MILNBOFPKBD(string NJHMKOJPAGJ, string NAOGMHDFAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA170", Offset = "0x3CF9370", VA = "0x183CFA170")]
	private KDBCICGABDL FMMDPDANPLH(string NJHMKOJPAGJ, object NAOGMHDFAEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LGNFHBJDMBM : KDBCICGABDL
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA370", Offset = "0x3CF9570", VA = "0x183CFA370")]
	public LGNFHBJDMBM(AmplitudeAnalyticsEvent KAFEFHCLBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA3C0", Offset = "0x3CF95C0", VA = "0x183CFA3C0", Slot = "4")]
	public override void JAKKJFJKFJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class JFHJIMEHOAF<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::JFHJIMEHOAF<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	protected M KAFEFHCLBCF;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public abstract BLDR CEOLHCDKKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1B664A0", Offset = "0x1B656A0", VA = "0x181B664A0")]
	public JFHJIMEHOAF(M KAFEFHCLBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x249EDB0", Offset = "0x249DFB0", VA = "0x18249EDB0")]
	public BLDR HDFGLFCBAEH(AmplitudeAnalyticsIdentifyMessage.DeviceInfo HODHNKCIOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x249ED80", Offset = "0x249DF80", VA = "0x18249ED80")]
	public BLDR EMHCMKELNPC(AmplitudeAnalyticsIdentifyMessage.RevenueData POBDPAELGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x249EEC0", Offset = "0x249E0C0", VA = "0x18249EEC0")]
	public BLDR MANFLHMACIB(string NJHMKOJPAGJ, string NAOGMHDFAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1EA72A0", Offset = "0x1EA64A0", VA = "0x181EA72A0")]
	public BLDR MANFLHMACIB<T>(string NJHMKOJPAGJ, T NAOGMHDFAEF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JAKKJFJKFJN();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x249EF30", Offset = "0x249E130", VA = "0x18249EF30")]
	internal static string NKMFBIEPEOD(string NAOGMHDFAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x249EDE0", Offset = "0x249DFE0", VA = "0x18249EDE0")]
	private BLDR HFMKGLOGNBL(string NJHMKOJPAGJ, object NAOGMHDFAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M EGEGBONHMEK();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AOEJOOFBNOP
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public const int CGDOCHLFKCC = 2;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int KOLKPADCLOA = 100;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int EGHFAHMLJFB = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const long EJNIGBCNNCE = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const int KFKDJOLFPDN = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int EMHDKJLIJDD = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const string BCHCJNHJINO = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string JOIKFNNCKIN = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string OBLKPEIGOPE = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string FOIBODOOOGL = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string OOMEILNLFJJ = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string AGHLKCHCLMN = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string HEKJCJKNPJC = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string JICDMHPONID = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const int KFGNAAJBKJF = 10;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> BJMFDEEGPBP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
	public AOEJOOFBNOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KAGKMFKAPMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string EOCOMHDNECH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string OJKMHOEHFKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string ELKHOOGBFBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::MGLHMIMFOOP<DIEMCFLKCGA> BMCJKPINGEG(string GGMCCKDHLBA, Dictionary<string, string> CHOFMIKAODI);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DIEMCFLKCGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly int ELELDEFDFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly string HIOHMMPGNBJ;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x42D8C0", Offset = "0x42CAC0", VA = "0x18042D8C0")]
	public DIEMCFLKCGA(int EIEKCPIJJKM, string HCJCKCBEDIE)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BCKBGMPBOEN
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static byte[] IIKLKCCNJOK;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int EFALHOKMJDD;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int EIOLKOFHOIE;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static BigInteger DCNHKPLAFAO;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
	public BCKBGMPBOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3CF84A0", Offset = "0x3CF76A0", VA = "0x183CF84A0")]
	private static string JACOKJKBDNF(byte[] EELHLJKEFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3CF85A0", Offset = "0x3CF77A0", VA = "0x183CF85A0")]
	public static string MIOPHHLBAMI(byte[] DNMICDHPJHJ, bool AFHNMHOEHHN)
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
		[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
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
