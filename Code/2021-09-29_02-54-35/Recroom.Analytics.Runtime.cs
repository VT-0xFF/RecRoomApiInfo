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
		public AmplitudeAnalyticsClient.Settings BPJFJHKGGAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JAHCPBMFPNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x41F160", Offset = "0x41DF60", VA = "0x18041F160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAA44D0", Offset = "0xAA32D0", VA = "0x180AA44D0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum AOEKBJGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class OBEACEBCEIN
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class CNDAFDDKJIJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public int BMDFJMDEDKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public Dictionary<string, object> INBBDLIFFNN;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
				public CNDAFDDKJIJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class AEDIMCOIPAP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
				public AEDIMCOIPAP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x3C6E070", Offset = "0x3C6CE70", VA = "0x183C6E070")]
				internal bool <GetBatch>b__0(CNDAFDDKJIJ item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private const string IFGPCKMMKHO = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string HDGHGNPFNPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<CNDAFDDKJIJ> CLKDJNICLNM;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? JIKMHAFIHDL
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x3C74820", Offset = "0x3C73620", VA = "0x183C74820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? AFMINNDMIMD
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x3C74C20", Offset = "0x3C73A20", VA = "0x183C74C20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3C759A0", Offset = "0x3C747A0", VA = "0x183C759A0")]
			internal OBEACEBCEIN(string APCCNPPMILJ, string NGDGFHCAFHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3C75840", Offset = "0x3C74640", VA = "0x183C75840")]
			public int PJEMEJHHKEO([Optional] int? KGKBMCCFPKP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3C75640", Offset = "0x3C74440", VA = "0x183C75640")]
			public List<Dictionary<string, object>> PIGGKKCKLOG(int EPAGEHFPCLB, int? KGKBMCCFPKP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3C75380", Offset = "0x3C74180", VA = "0x183C75380")]
			public void MJMFDMDLMDJ(AmplitudeAnalyticsIdentifyMessage NMIBNAJICKO, bool OCPACOLLDNN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3C75290", Offset = "0x3C74090", VA = "0x183C75290")]
			public void MJMFDMDLMDJ(Dictionary<string, object> NMIBNAJICKO, bool OCPACOLLDNN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3C749C0", Offset = "0x3C737C0", VA = "0x183C749C0")]
			public void HJFBCNLMAGE(params Dictionary<string, object>[] DICHFANEGBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3C75420", Offset = "0x3C74220", VA = "0x183C75420")]
			public void PFMEEMNFJNE(List<Dictionary<string, object>> CMFMFFGHJFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3C748B0", Offset = "0x3C736B0", VA = "0x183C748B0")]
			private void DBGFLLIBHKP(Dictionary<string, object> NMIBNAJICKO, bool OCPACOLLDNN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3C750A0", Offset = "0x3C73EA0", VA = "0x183C750A0")]
			public void KPLJPCLDBAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3C74CD0", Offset = "0x3C73AD0", VA = "0x183C74CD0")]
			private void KIGBLGDKDLA([Optional] string JHFHLEFHJFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3C74AF0", Offset = "0x3C738F0", VA = "0x183C74AF0")]
			private static string IFKPMJBKDHB(string NAHKACCDOIA, string JEAOBHPGMKJ)
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
			[Cpp2IlInjected.Address(RVA = "0x3C75C10", Offset = "0x3C74A10", VA = "0x183C75C10")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct JCJFMBDIHAM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int MKJEDFPOOOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public string FOLIKLGGNMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T EBOPADJJLGO;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class IPPCLFMMANJ : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private CMKOPAPLFOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
			[DebuggerHidden]
			public IPPCLFMMANJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3C73A90", Offset = "0x3C72890", VA = "0x183C73A90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3C741B0", Offset = "0x3C72FB0", VA = "0x183C741B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class NEEMMLGANDD : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
			[DebuggerHidden]
			public NEEMMLGANDD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3C74700", Offset = "0x3C73500", VA = "0x183C74700", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3C747D0", Offset = "0x3C735D0", VA = "0x183C747D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LHCDKICHNJP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
			[DebuggerHidden]
			public LHCDKICHNJP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3C74570", Offset = "0x3C73370", VA = "0x183C74570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3C746B0", Offset = "0x3C734B0", VA = "0x183C746B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LCGJLIGJJPG : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private CMKOPAPLFOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
			[DebuggerHidden]
			public LCGJLIGJJPG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3C742E0", Offset = "0x3C730E0", VA = "0x183C742E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3C74520", Offset = "0x3C73320", VA = "0x183C74520", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class GBBNKJCPGFG : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private CMKOPAPLFOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
			[DebuggerHidden]
			public GBBNKJCPGFG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3C73800", Offset = "0x3C72600", VA = "0x183C73800", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3C73A40", Offset = "0x3C72840", VA = "0x183C73A40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class EKGPCNCAFBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public OBEACEBCEIN cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
			public EKGPCNCAFBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3C73230", Offset = "0x3C72030", VA = "0x183C73230")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3C732D0", Offset = "0x3C720D0", VA = "0x183C732D0")]
			internal void <FlushFromCache>b__1(JCJFMBDIHAM<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class CDBAHMJJMHB : IEnumerator<CMKOPAPLFOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private CMKOPAPLFOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public OBEACEBCEIN cache;

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
			private EKGPCNCAFBN <>8__1;

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
			private CMKOPAPLFOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
			[DebuggerHidden]
			public CDBAHMJJMHB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x3C72250", Offset = "0x3C71050", VA = "0x183C72250", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3C72890", Offset = "0x3C71690", VA = "0x183C72890", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class HCDFFAHKKAP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
			public HCDFFAHKKAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1D48090", Offset = "0x1D46E90", VA = "0x181D48090")]
			internal JCJFMBDIHAM<T> <PostJson>b__0(EJCLEFJENGN postResponse)
			{
				return default(JCJFMBDIHAM<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ECCLKCHOECE DGKAPFMCGBO;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string GABOPBDCFBL = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string OEHIPFGCNGM = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string DLFOHPJEIKI = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string CHCKMFEAAAN = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string DLAAOCHAHOC = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int FBKFIMMMPLE = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int PFDIGCEENOP = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int EIOAHPOADOC = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float OFFPHNJIMMK = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long HHHPMKOENIL = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string IIHLCBKNOPB = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static bool MGBNFGGALLD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool NEKFCPFHHNA;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static int GJLGBGLFDLC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int BKNFBCNAGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private LAKOLCAHEPN MGCKAMHOPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool BEOBAIDNHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float MHMMEOIALKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float FOCBBAOKBAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int GIKGJJGJNGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int PINNAJGMJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int? DBPOCHPDEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? LDJDLDJEKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private long LDDJEHIOFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string CJHMIPAJFNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long OPADIFDBPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, object> LENDPNNJFHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private AOEKBJGGLGA GHACEOCJMDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int DODEPLCNEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int JGHGKHOGNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float ACJEENNPOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool GJDFBDMMOKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool HAOKODJMCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private OBEACEBCEIN FFDFHHLBLBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private OBEACEBCEIN OAKGFGPBBEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private OBEACEBCEIN IHKCJPJFECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> CAEMLHBHGNF;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo JCGMPKICBOM;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static string BFGIMNNIPOA;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string HNLNJHOIGGK = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string CKBDJPDHMHD = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ECCLKCHOECE FGHOBLPOOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3C6F500", Offset = "0x3C6E300", VA = "0x183C6F500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int KMJGHBFJPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3C6EE10", Offset = "0x3C6DC10", VA = "0x183C6EE10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long AIOPAMJNFFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3C71360", Offset = "0x3C70160", VA = "0x183C71360")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3C71460", Offset = "0x3C70260", VA = "0x183C71460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string DEGHEFLOCHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3C71330", Offset = "0x3C70130", VA = "0x183C71330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string ODHNDFJKNBA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x442950", Offset = "0x441750", VA = "0x180442950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x430A40", Offset = "0x42F840", VA = "0x180430A40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JBNCCJPJDCO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x490070", Offset = "0x48EE70", VA = "0x180490070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xBAC140", Offset = "0xBAAF40", VA = "0x180BAC140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool BJFDAEOHOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3C71250", Offset = "0x3C70050", VA = "0x183C71250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> FIDLOBAACNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3C711B0", Offset = "0x3C6FFB0", VA = "0x183C711B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3C713C0", Offset = "0x3C701C0", VA = "0x183C713C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E270", Offset = "0x3C6D070", VA = "0x183C6E270", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3C70C40", Offset = "0x3C6FA40", VA = "0x183C70C40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C703C0", Offset = "0x3C6F1C0", VA = "0x183C703C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3C70DC0", Offset = "0x3C6FBC0", VA = "0x183C70DC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C70440", Offset = "0x3C6F240", VA = "0x183C70440")]
		private bool PGMBHLCECOK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F490", Offset = "0x3C6E290", VA = "0x183C6F490")]
		[IteratorStateMachine(typeof(IPPCLFMMANJ))]
		public IEnumerator<CMKOPAPLFOC> Initialize(AmplitudeAnalyticsEvent KGOEBMKMLLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C70D10", Offset = "0x3C6FB10", VA = "0x183C70D10")]
		public void UpdateLastAliveTime(float GCKCHDJKBBL = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FFC0", Offset = "0x3C6EDC0", VA = "0x183C6FFC0")]
		private bool NONAAJJBDLI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FC50", Offset = "0x3C6EA50", VA = "0x183C6FC50")]
		private bool MBMOLNHJCBP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3C708D0", Offset = "0x3C6F6D0", VA = "0x183C708D0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EDB0", Offset = "0x3C6DBB0", VA = "0x183C6EDB0")]
		[IteratorStateMachine(typeof(NEEMMLGANDD))]
		private IEnumerator FJMEHKPFFEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C71020", Offset = "0x3C6FE20", VA = "0x183C71020")]
		[IteratorStateMachine(typeof(LHCDKICHNJP))]
		public IEnumerator WaitForFlush(float FIPNEIMGEIA = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3C70C50", Offset = "0x3C6FA50", VA = "0x183C70C50")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F1A0", Offset = "0x3C6DFA0", VA = "0x183C6F1A0")]
		public static KBBLCEMOINJ Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E130", Offset = "0x3C6CF30", VA = "0x183C6E130")]
		public static EBLAKFFCJEN AccountSelectionPostLoginEvent([NotNull] string LIMGCEJFHFE, string IOAHCDLHAHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EC50", Offset = "0x3C6DA50", VA = "0x183C6EC50")]
		public static EBLAKFFCJEN Event([NotNull] string LIMGCEJFHFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3C704A0", Offset = "0x3C6F2A0", VA = "0x183C704A0")]
		public static EBLAKFFCJEN PreviousSessionEvent([NotNull] string LIMGCEJFHFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F2E0", Offset = "0x3C6E0E0", VA = "0x183C6F2E0")]
		public static EBLAKFFCJEN InitializeEvent(string IOAHCDLHAHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3C709E0", Offset = "0x3C6F7E0", VA = "0x183C709E0")]
		public static EBLAKFFCJEN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E880", Offset = "0x3C6D680", VA = "0x183C6E880")]
		public static EBLAKFFCJEN CreateOutOfSessionEvent(string LIMGCEJFHFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F8E0", Offset = "0x3C6E6E0", VA = "0x183C6F8E0")]
		public static DCLDNCDAGBP LogOutOfSessionEvent(EBLAKFFCJEN IODKKPPFFLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F730", Offset = "0x3C6E530", VA = "0x183C6F730")]
		public void LogEventAsync(AmplitudeAnalyticsEvent EGCHNOFCJFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FAB0", Offset = "0x3C6E8B0", VA = "0x183C6FAB0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent EGCHNOFCJFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FB80", Offset = "0x3C6E980", VA = "0x183C6FB80")]
		public void LogSerializedEventAsync(Dictionary<string, object> KNPKKDCIAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F800", Offset = "0x3C6E600", VA = "0x183C6F800")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage MGPHHGMIECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E6F0", Offset = "0x3C6D4F0", VA = "0x183C6E6F0")]
		private void BEENFHFCAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3C70130", Offset = "0x3C6EF30", VA = "0x183C70130")]
		private void OBCAOLMLIGC(Dictionary<string, object> MBLHIPOKDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F0C0", Offset = "0x3C6DEC0", VA = "0x183C6F0C0")]
		private void IFHDKHDHPNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3C6FE30", Offset = "0x3C6EC30", VA = "0x183C6FE30")]
		private void MDDILEJINHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F030", Offset = "0x3C6DE30", VA = "0x183C6F030")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3C70350", Offset = "0x3C6F150", VA = "0x183C70350")]
		[IteratorStateMachine(typeof(LCGJLIGJJPG))]
		private IEnumerator<CMKOPAPLFOC> OECCPMOCLKC(float FIPNEIMGEIA = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EB30", Offset = "0x3C6D930", VA = "0x183C6EB30")]
		[IteratorStateMachine(typeof(GBBNKJCPGFG))]
		private IEnumerator<CMKOPAPLFOC> EMHFOIJBGGG(float FIPNEIMGEIA = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EBA0", Offset = "0x3C6D9A0", VA = "0x183C6EBA0")]
		[IteratorStateMachine(typeof(CDBAHMJJMHB))]
		private IEnumerator<CMKOPAPLFOC> EPHBGKMOEPJ(OBEACEBCEIN DCHGPABLNJJ, int? KGKBMCCFPKP, string FCCFGBGPADE, string GCECLGEJPJP, float FIPNEIMGEIA, Action<int> IMNPNNJMFKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E790", Offset = "0x3C6D590", VA = "0x183C6E790")]
		private static void BHACAOINPNH(bool CLBNDFHDNKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2147E10", Offset = "0x2146C10", VA = "0x182147E10")]
		private global::BGNOPMFAGGO<JCJFMBDIHAM<T>> BMPDMEFCDOO<T>(string FCCFGBGPADE, string GCECLGEJPJP, string HMBHGLHILMN, T EBOPADJJLGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E0E0", Offset = "0x3C6CEE0", VA = "0x183C6E0E0")]
		private bool ALLOKNPNDEH(float GBGHKHPBBFG, float FIPNEIMGEIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3C710F0", Offset = "0x3C6FEF0", VA = "0x183C710F0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F5D0", Offset = "0x3C6E3D0", VA = "0x183C6F5D0")]
		[CompilerGenerated]
		private long LNEBKLMIDGO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E0D0", Offset = "0x3C6CED0", VA = "0x183C6E0D0")]
		[CompilerGenerated]
		private void AFHHNFLJPCB(int AMGJHPBCBPD)
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
			[Cpp2IlInjected.Address(RVA = "0x425310", Offset = "0x424110", VA = "0x180425310")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3C715B0", Offset = "0x3C703B0", VA = "0x183C715B0")]
		public static EBLAKFFCJEN IHJCHFBBHFH(string HCIEIPIJONO, [NotNull] string FBEKFGKNJOH, long AKJCLOIJDOH, long KAPEEFNGPEI, string IOAHCDLHAHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3C714C0", Offset = "0x3C702C0", VA = "0x183C714C0")]
		public static EBLAKFFCJEN GNOELHJIPGB(string HCIEIPIJONO, [NotNull] string FBEKFGKNJOH, long AKJCLOIJDOH, long KAPEEFNGPEI, string IOAHCDLHAHP, long AFCEDJDDHHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3C71A50", Offset = "0x3C70850", VA = "0x183C71A50")]
		private AmplitudeAnalyticsEvent(string HCIEIPIJONO, [NotNull] string FBEKFGKNJOH, long AKJCLOIJDOH, long KAPEEFNGPEI, string IOAHCDLHAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x493840", Offset = "0x492640", VA = "0x180493840")]
		public void MNMDHJPHHHJ(long LNJPGMHMDCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3C71940", Offset = "0x3C70740", VA = "0x183C71940", Slot = "5")]
		public override void NMEDJHIFMLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3C71690", Offset = "0x3C70490", VA = "0x183C71690", Slot = "6")]
		public override void KJKHBABHDMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3C71700", Offset = "0x3C70500", VA = "0x183C71700", Slot = "4")]
		protected override Dictionary<string, object> MFHOAHMODHF(Dictionary<string, object> BPMLOKPGOOJ)
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
			[Cpp2IlInjected.Address(RVA = "0x3C72EC0", Offset = "0x3C71CC0", VA = "0x183C72EC0")]
			public void DLBIFFKFILA(Dictionary<string, object> BBELBHEHMIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C75AF0", Offset = "0x3C748F0", VA = "0x183C75AF0")]
			public void DLBIFFKFILA(Dictionary<string, object> DFIMFEKAFBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xE41170", Offset = "0xE3FF70", VA = "0x180E41170")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F1A0", Offset = "0x41DFA0", VA = "0x18041F1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x41F440", Offset = "0x41E240", VA = "0x18041F440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3C71D50", Offset = "0x3C70B50", VA = "0x183C71D50")]
		public static KBBLCEMOINJ IHJCHFBBHFH(string HCIEIPIJONO, string IOAHCDLHAHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3C72110", Offset = "0x3C70F10", VA = "0x183C72110")]
		protected AmplitudeAnalyticsIdentifyMessage(string HCIEIPIJONO, string IOAHCDLHAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3C71BD0", Offset = "0x3C709D0", VA = "0x183C71BD0")]
		public Dictionary<string, object> DMPFDNPDJOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3C71E60", Offset = "0x3C70C60", VA = "0x183C71E60", Slot = "4")]
		protected virtual Dictionary<string, object> MFHOAHMODHF(Dictionary<string, object> BPMLOKPGOOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3C71C40", Offset = "0x3C70A40", VA = "0x183C71C40")]
		protected void EBMCEDELMDF(string JEAOBHPGMKJ, Dictionary<string, object> KIIPCGCMCHP, Dictionary<string, object> CEKGFKDEHPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3C71CE0", Offset = "0x3C70AE0", VA = "0x183C71CE0")]
		protected void GGFHKGOCBBK(string JEAOBHPGMKJ, string NAHKACCDOIA, Dictionary<string, object> AKAHMFEPECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3C720A0", Offset = "0x3C70EA0", VA = "0x183C720A0", Slot = "5")]
		public virtual void NMEDJHIFMLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3C71DF0", Offset = "0x3C70BF0", VA = "0x183C71DF0", Slot = "6")]
		public virtual void KJKHBABHDMG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KBBLCEMOINJ : global::HDNLCAPEDKK<AmplitudeAnalyticsIdentifyMessage, KBBLCEMOINJ>
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override KBBLCEMOINJ GFBKFODJCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x471140", Offset = "0x46FF40", VA = "0x180471140", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x41F1A0", Offset = "0x41DFA0", VA = "0x18041F1A0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage CINDGHHNHMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3C74290", Offset = "0x3C73090", VA = "0x183C74290")]
	public KBBLCEMOINJ(AmplitudeAnalyticsIdentifyMessage CNCIDCNIFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3C74200", Offset = "0x3C73000", VA = "0x183C74200", Slot = "4")]
	public override void KJKHBABHDMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EBLAKFFCJEN : global::HDNLCAPEDKK<AmplitudeAnalyticsEvent, EBLAKFFCJEN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool NNPIKDFANFE;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override EBLAKFFCJEN GFBKFODJCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x471140", Offset = "0x46FF40", VA = "0x180471140", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3C731E0", Offset = "0x3C71FE0", VA = "0x183C731E0")]
	public EBLAKFFCJEN(AmplitudeAnalyticsEvent CNCIDCNIFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x41F1A0", Offset = "0x41DFA0", VA = "0x18041F1A0", Slot = "5")]
	public override AmplitudeAnalyticsEvent CINDGHHNHMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3C73060", Offset = "0x3C71E60", VA = "0x183C73060", Slot = "4")]
	public override void KJKHBABHDMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	public EBLAKFFCJEN AHGDOABMEJH<T>(string GKAFECFJKEL, T[] NAHKACCDOIA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3C73050", Offset = "0x3C71E50", VA = "0x183C73050")]
	public EBLAKFFCJEN AHGDOABMEJH(string GKAFECFJKEL, string[] NAHKACCDOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1B07AB0", Offset = "0x1B068B0", VA = "0x181B07AB0")]
	public EBLAKFFCJEN AHGDOABMEJH<T>(string GKAFECFJKEL, T NAHKACCDOIA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3C72FE0", Offset = "0x3C71DE0", VA = "0x183C72FE0")]
	public EBLAKFFCJEN AHGDOABMEJH(string GKAFECFJKEL, string NAHKACCDOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3C73100", Offset = "0x3C71F00", VA = "0x183C73100")]
	private EBLAKFFCJEN NENAANJDGJP(string GKAFECFJKEL, object NAHKACCDOIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FCLPLFHOKDD : EBLAKFFCJEN
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3C731E0", Offset = "0x3C71FE0", VA = "0x183C731E0")]
	public FCLPLFHOKDD(AmplitudeAnalyticsEvent CNCIDCNIFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3C736D0", Offset = "0x3C724D0", VA = "0x183C736D0", Slot = "4")]
	public override void KJKHBABHDMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class HDNLCAPEDKK<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::HDNLCAPEDKK<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	protected M CNCIDCNIFHM;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public abstract BLDR GFBKFODJCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1C25190", Offset = "0x1C23F90", VA = "0x181C25190")]
	public HDNLCAPEDKK(M CNCIDCNIFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3377530", Offset = "0x3376330", VA = "0x183377530")]
	public BLDR JLKMMFCMMCN(AmplitudeAnalyticsIdentifyMessage.DeviceInfo GFNEGDCKIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x33774D0", Offset = "0x33762D0", VA = "0x1833774D0")]
	public BLDR BOEKPFFENFM(AmplitudeAnalyticsIdentifyMessage.RevenueData MOLFOJHPNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3377460", Offset = "0x3376260", VA = "0x183377460")]
	public BLDR AGHKDJCLGCG(string GKAFECFJKEL, string NAHKACCDOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1EDB060", Offset = "0x1ED9E60", VA = "0x181EDB060")]
	public BLDR AGHKDJCLGCG<T>(string GKAFECFJKEL, T NAHKACCDOIA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KJKHBABHDMG();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3377500", Offset = "0x3376300", VA = "0x183377500")]
	internal static string FAJEDNOBHIB(string NAHKACCDOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3377560", Offset = "0x3376360", VA = "0x183377560")]
	private BLDR MGKFPBKHIHB(string GKAFECFJKEL, object NAHKACCDOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M CINDGHHNHMB();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BGGBNHPMKEF
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public const int JOLLBJJJGKO = 2;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int JDJHHKKIMKM = 100;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int HJBDLOCBHCC = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const long PAEFAAKIHAO = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const int ABLAFFNJACC = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int LCODHAHMDAK = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const string OBBLIEDKPKI = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string OHGIDGHJAEJ = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string MCPDBGBPFMN = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string OCOPCKKEBHP = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string COCGEKBAOEH = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string GIKBDJAAEMD = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string GLPCLDJFCFC = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string CKKPNJLOEMA = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const int OGAGIMMCHIG = 10;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> MCBLJEFPLOK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
	public BGGBNHPMKEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LAKOLCAHEPN
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string BIOICOPABHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string OAIOAADIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string GJDIHMMBMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::BGNOPMFAGGO<EJCLEFJENGN> BMPDMEFCDOO(string FCCFGBGPADE, Dictionary<string, string> MEPEMLHJBID);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EJCLEFJENGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly int NIJHHEKANGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly string AFDMDCHJAKJ;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4278C0", Offset = "0x4266C0", VA = "0x1804278C0")]
	public EJCLEFJENGN(int MKJEDFPOOOP, string FOLIKLGGNMP)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DLELAMAGEBO
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static byte[] GJIBIPFNGFK;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int DIHKALOCDCB;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int LFHDFLOBKAF;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static BigInteger FNIOAIDKCMO;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
	public DLELAMAGEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3C72C10", Offset = "0x3C71A10", VA = "0x183C72C10")]
	private static string KGDDMKENHCD(byte[] DIHLDHDCJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3C728E0", Offset = "0x3C716E0", VA = "0x183C728E0")]
	public static string GAOFMFFNDED(byte[] PAJKEDJCHEF, bool GDFPKOHPJFN)
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
		[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
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
