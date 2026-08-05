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
		public AmplitudeAnalyticsClient.Settings KCCIMFKMBMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GJIAAMHCBEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x428160", Offset = "0x427160", VA = "0x180428160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB8B5C0", Offset = "0xB8A5C0", VA = "0x180B8B5C0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum EGEGJEIDHBP
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class OGNPIJIHOIA
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class JKHGFHGAKCM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public int KEGMIDCAEHN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public Dictionary<string, object> NCGHHKLLIKE;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
				public JKHGFHGAKCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class MCFHNDMKHHB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
				public MCFHNDMKHHB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x3D0DBF0", Offset = "0x3D0CBF0", VA = "0x183D0DBF0")]
				internal bool <GetBatch>b__0(JKHGFHGAKCM item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private const string HPEBDBJGLJL = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string BAJJLBLMEDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<JKHGFHGAKCM> AIMCDJNEMKF;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? GOOOKILCGII
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x3D0E4D0", Offset = "0x3D0D4D0", VA = "0x183D0E4D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? KGPLFMHALMP
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x3D0ECA0", Offset = "0x3D0DCA0", VA = "0x183D0ECA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3D0F540", Offset = "0x3D0E540", VA = "0x183D0F540")]
			internal OGNPIJIHOIA(string PFNCHNGCGCI, string HHIJHKPAKPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3D0E820", Offset = "0x3D0D820", VA = "0x183D0E820")]
			public int IBNJHNAPMAL([Optional] int? FOMEHLNFPFG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3D0F120", Offset = "0x3D0E120", VA = "0x183D0F120")]
			public List<Dictionary<string, object>> MCFGHNOPMOE(int CJHAANGBHGC, int? FOMEHLNFPFG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3D0E690", Offset = "0x3D0D690", VA = "0x183D0E690")]
			public void HPGOFOEPKFP(AmplitudeAnalyticsIdentifyMessage KFEIKGNAKCK, bool DLAFDPCMBML = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3D0E730", Offset = "0x3D0D730", VA = "0x183D0E730")]
			public void HPGOFOEPKFP(Dictionary<string, object> KFEIKGNAKCK, bool DLAFDPCMBML = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3D0E560", Offset = "0x3D0D560", VA = "0x183D0E560")]
			public void FLCGPAMDFHC(params Dictionary<string, object>[] JLCHPKLEGJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3D0F320", Offset = "0x3D0E320", VA = "0x183D0F320")]
			public void NJBCCIKFOKH(List<Dictionary<string, object>> CFEJPLBELIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3D0E3C0", Offset = "0x3D0D3C0", VA = "0x183D0E3C0")]
			private void FBCGOLAMPPL(Dictionary<string, object> KFEIKGNAKCK, bool DLAFDPCMBML = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3D0E980", Offset = "0x3D0D980", VA = "0x183D0E980")]
			public void IJLJBGEMAEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3D0ED50", Offset = "0x3D0DD50", VA = "0x183D0ED50")]
			private void JMEKAFCPBCA([Optional] string PAOJBCEBCEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3D0EB70", Offset = "0x3D0DB70", VA = "0x183D0EB70")]
			private static string ILEFMPKOFDJ(string DAPPHEJJLEB, string FNHMPFHLGJM)
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
			[Cpp2IlInjected.Address(RVA = "0x3D0FBD0", Offset = "0x3D0EBD0", VA = "0x183D0FBD0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct ADOEIAFNPFC<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int JBIDLJNDIOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public string FHPAKBDOFFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T GHKCBNJJDJD;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class NGELGMHECFK : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private MKDOJLNJHKD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
			[DebuggerHidden]
			public NGELGMHECFK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3D0DC50", Offset = "0x3D0CC50", VA = "0x183D0DC50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3D0E370", Offset = "0x3D0D370", VA = "0x183D0E370", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class BJGIFFLHJPD : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
			[DebuggerHidden]
			public BJGIFFLHJPD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3D0C3A0", Offset = "0x3D0B3A0", VA = "0x183D0C3A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3D0C470", Offset = "0x3D0B470", VA = "0x183D0C470", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PHCJANEAPHK : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
			[DebuggerHidden]
			public PHCJANEAPHK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3D0F920", Offset = "0x3D0E920", VA = "0x183D0F920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3D0FA60", Offset = "0x3D0EA60", VA = "0x183D0FA60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class PEDHHDANPCN : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private MKDOJLNJHKD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
			[DebuggerHidden]
			public PEDHHDANPCN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3D0F690", Offset = "0x3D0E690", VA = "0x183D0F690", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3D0F8D0", Offset = "0x3D0E8D0", VA = "0x183D0F8D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class ADBBEONLFLE : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private MKDOJLNJHKD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
			[DebuggerHidden]
			public ADBBEONLFLE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3D08030", Offset = "0x3D07030", VA = "0x183D08030", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3D08270", Offset = "0x3D07270", VA = "0x183D08270", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class JKLHJKEJFHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public OGNPIJIHOIA cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
			public JKLHJKEJFHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3D0D040", Offset = "0x3D0C040", VA = "0x183D0D040")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3D0D0E0", Offset = "0x3D0C0E0", VA = "0x183D0D0E0")]
			internal void <FlushFromCache>b__1(ADOEIAFNPFC<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JKGFBKCJKLH : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private MKDOJLNJHKD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public OGNPIJIHOIA cache;

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
			private JKLHJKEJFHG <>8__1;

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
			private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
			[DebuggerHidden]
			public JKGFBKCJKLH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x3D0C9B0", Offset = "0x3D0B9B0", VA = "0x183D0C9B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3D0CFF0", Offset = "0x3D0BFF0", VA = "0x183D0CFF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class NAHFFMPDLAJ<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
			public NAHFFMPDLAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1B103F0", Offset = "0x1B0F3F0", VA = "0x181B103F0")]
			internal ADOEIAFNPFC<T> <PostJson>b__0(ECHGBOGBIDB postResponse)
			{
				return default(ADOEIAFNPFC<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private LGOEDGIHILL JJMIAACFBPO;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string LOANILGDKPD = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string PNKBAPPHEPH = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string PNDCJKBDPNH = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string KHCPGBAHCKL = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string HODPEJJBKOC = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int GHPLPLGPBAB = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int NNDEMMOFDNH = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int EHHOBLNFJOB = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float KAHHGMFFJGA = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long EOLNINPAFJF = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string NGEKFBHNJCO = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static bool KBNCONBNGLA;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool IECAMKGPPBL;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static int APCNEKPOBNO;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int DIHACMHKBJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private LAPKGCOCBII INFACKIGDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool IIHIJDCLJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float MMEBHIFBHHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float EGIAAPMHOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int GFNLMOHNPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int ODDBBJNHDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int? MJFBGOIBKIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? INIIHHCMCPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private long OEEKKNOKJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string JMGDMOFLPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long IDFPNANINHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, object> KHHOMCEFEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private EGEGJEIDHBP HLDGEFJNJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int GPLPLOCPADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int HJIFBFKPJBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float JNDOLFIEMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool AJIFHHDADOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool BLMHCNIBGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private OGNPIJIHOIA PJDKEDPINMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private OGNPIJIHOIA MANHJLNKONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private OGNPIJIHOIA NHPGMAFNDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> PEKDCFPHKHN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo KLKMOOBHLKA;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static string IAMNLJKOGPO;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string MILKGDKPKGK = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string GCMCPNKPIHH = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LGOEDGIHILL AEKCMOKADON
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3D09170", Offset = "0x3D08170", VA = "0x183D09170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int OKADIOCOICG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3D0A410", Offset = "0x3D09410", VA = "0x183D0A410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long PBPKJBIPHCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3D0B550", Offset = "0x3D0A550", VA = "0x183D0B550")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3D0B650", Offset = "0x3D0A650", VA = "0x183D0B650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string BHHILGJILBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3D0B520", Offset = "0x3D0A520", VA = "0x183D0B520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string FKIBFODNLBE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x44B950", Offset = "0x44A950", VA = "0x18044B950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x439A40", Offset = "0x438A40", VA = "0x180439A40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool EJLHLGNJMPH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4E1FC0", Offset = "0x4E0FC0", VA = "0x1804E1FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xEB3C70", Offset = "0xEB2C70", VA = "0x180EB3C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool OHLAPJPNDLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3D0B440", Offset = "0x3D0A440", VA = "0x183D0B440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> IBGIGJMDIAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3D0B3A0", Offset = "0x3D0A3A0", VA = "0x183D0B3A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3D0B5B0", Offset = "0x3D0A5B0", VA = "0x183D0B5B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D08400", Offset = "0x3D07400", VA = "0x183D08400", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3D0AE30", Offset = "0x3D09E30", VA = "0x183D0AE30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A390", Offset = "0x3D09390", VA = "0x183D0A390", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D0AFB0", Offset = "0x3D09FB0", VA = "0x183D0AFB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D09590", Offset = "0x3D08590", VA = "0x183D09590")]
		private bool IHMBIKEJBNH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D098E0", Offset = "0x3D088E0", VA = "0x183D098E0")]
		[IteratorStateMachine(typeof(NGELGMHECFK))]
		public IEnumerator<MKDOJLNJHKD> Initialize(AmplitudeAnalyticsEvent CBGHJOOIDNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D0AF00", Offset = "0x3D09F00", VA = "0x183D0AF00")]
		public void UpdateLastAliveTime(float EHEMMFPAKCF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D09A10", Offset = "0x3D08A10", VA = "0x183D09A10")]
		private bool LHNPGCGMBAL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D08C10", Offset = "0x3D07C10", VA = "0x183D08C10")]
		private bool ECINFBEFFJL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D0AAC0", Offset = "0x3D09AC0", VA = "0x183D0AAC0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A630", Offset = "0x3D09630", VA = "0x183D0A630")]
		[IteratorStateMachine(typeof(BJGIFFLHJPD))]
		private IEnumerator PKNKHOCFPCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B210", Offset = "0x3D0A210", VA = "0x183D0B210")]
		[IteratorStateMachine(typeof(PHCJANEAPHK))]
		public IEnumerator WaitForFlush(float DGBPOHPPPMG = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D0AE40", Offset = "0x3D09E40", VA = "0x183D0AE40")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D095F0", Offset = "0x3D085F0", VA = "0x183D095F0")]
		public static DALENJNCKHB Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D082C0", Offset = "0x3D072C0", VA = "0x183D082C0")]
		public static INMBONFCCOM AccountSelectionPostLoginEvent([NotNull] string LHEJFMDEHDC, string IGBMBJPCOPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D08F80", Offset = "0x3D07F80", VA = "0x183D08F80")]
		public static INMBONFCCOM Event([NotNull] string LHEJFMDEHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A690", Offset = "0x3D09690", VA = "0x183D0A690")]
		public static INMBONFCCOM PreviousSessionEvent([NotNull] string LHEJFMDEHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3D09730", Offset = "0x3D08730", VA = "0x183D09730")]
		public static INMBONFCCOM InitializeEvent(string IGBMBJPCOPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3D0ABD0", Offset = "0x3D09BD0", VA = "0x183D0ABD0")]
		public static INMBONFCCOM StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D08880", Offset = "0x3D07880", VA = "0x183D08880")]
		public static INMBONFCCOM CreateOutOfSessionEvent(string LHEJFMDEHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3D09D30", Offset = "0x3D08D30", VA = "0x183D09D30")]
		public static EBJFPPEJHJH LogOutOfSessionEvent(INMBONFCCOM KCMLLLCEFOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3D09B80", Offset = "0x3D08B80", VA = "0x183D09B80")]
		public void LogEventAsync(AmplitudeAnalyticsEvent MLBJGJGKINH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D09F00", Offset = "0x3D08F00", VA = "0x183D09F00")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent MLBJGJGKINH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D09FD0", Offset = "0x3D08FD0", VA = "0x183D09FD0")]
		public void LogSerializedEventAsync(Dictionary<string, object> HNKJCPJEMBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D09C50", Offset = "0x3D08C50", VA = "0x183D09C50")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage CFLFFBNHBGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A0A0", Offset = "0x3D090A0", VA = "0x183D0A0A0")]
		private void MIEMPHKGJPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D092C0", Offset = "0x3D082C0", VA = "0x183D092C0")]
		private void HADCHJALKGG(Dictionary<string, object> MEJGEIJNPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3D08B30", Offset = "0x3D07B30", VA = "0x183D08B30")]
		private void EAFCLGJKEEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3D08DF0", Offset = "0x3D07DF0", VA = "0x183D08DF0")]
		private void EIKIHKOHPKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3D090E0", Offset = "0x3D080E0", VA = "0x183D090E0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D09950", Offset = "0x3D08950", VA = "0x183D09950")]
		[IteratorStateMachine(typeof(PEDHHDANPCN))]
		private IEnumerator<MKDOJLNJHKD> JELKIPLBIFM(float DGBPOHPPPMG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D09240", Offset = "0x3D08240", VA = "0x183D09240")]
		[IteratorStateMachine(typeof(ADBBEONLFLE))]
		private IEnumerator<MKDOJLNJHKD> GEDOCFFDGNA(float DGBPOHPPPMG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D094E0", Offset = "0x3D084E0", VA = "0x183D094E0")]
		[IteratorStateMachine(typeof(JKGFBKCJKLH))]
		private IEnumerator<MKDOJLNJHKD> HKLPFGHKGPG(OGNPIJIHOIA CDBAJJCEPCF, int? FOMEHLNFPFG, string AOHAGHMLDGG, string CDAEOGDFPKF, float DGBPOHPPPMG, Action<int> JOLCOEDJGOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A2A0", Offset = "0x3D092A0", VA = "0x183D0A2A0")]
		private static void NLICHLMHNLH(bool OPBOCBFNHNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE120", Offset = "0x1ABD120", VA = "0x181ABE120")]
		private global::CFGAGIADBID<ADOEIAFNPFC<T>> CGJGMKKOJLM<T>(string AOHAGHMLDGG, string CDAEOGDFPKF, string POELCABNEHC, T GHKCBNJJDJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3D099C0", Offset = "0x3D089C0", VA = "0x183D099C0")]
		private bool KHLFOGAFHEC(float LHGOELFJINM, float DGBPOHPPPMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B2E0", Offset = "0x3D0A2E0", VA = "0x183D0B2E0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A140", Offset = "0x3D09140", VA = "0x183D0A140")]
		[CompilerGenerated]
		private long MPJFPFIFJDM()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3D092B0", Offset = "0x3D082B0", VA = "0x183D092B0")]
		[CompilerGenerated]
		private void GILPBHAGLEL(int DEDBLHHLMCF)
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
			[Cpp2IlInjected.Address(RVA = "0x42E310", Offset = "0x42D310", VA = "0x18042E310")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B6B0", Offset = "0x3D0A6B0", VA = "0x183D0B6B0")]
		public static INMBONFCCOM FIOHCBANLKE(string CGMBLHAMNGM, [NotNull] string LLHJKBAAEKP, long MJLIBALMKBF, long PHOPJKIIIEN, string IGBMBJPCOPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B800", Offset = "0x3D0A800", VA = "0x183D0B800")]
		public static INMBONFCCOM JJDEDHHACNA(string CGMBLHAMNGM, [NotNull] string LLHJKBAAEKP, long MJLIBALMKBF, long PHOPJKIIIEN, string IGBMBJPCOPE, long GEKOPIPNPJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3D0BC40", Offset = "0x3D0AC40", VA = "0x183D0BC40")]
		private AmplitudeAnalyticsEvent(string CGMBLHAMNGM, [NotNull] string LLHJKBAAEKP, long MJLIBALMKBF, long PHOPJKIIIEN, string IGBMBJPCOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x49ED00", Offset = "0x49DD00", VA = "0x18049ED00")]
		public void PPHMHLIDMFM(long IPCMFIIKJOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3D0BB30", Offset = "0x3D0AB30", VA = "0x183D0BB30", Slot = "5")]
		public override void PAPDEJBPHNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B790", Offset = "0x3D0A790", VA = "0x183D0B790", Slot = "6")]
		public override void HALLMKDLMMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B8F0", Offset = "0x3D0A8F0", VA = "0x183D0B8F0", Slot = "4")]
		protected override Dictionary<string, object> JNCLALDPJAI(Dictionary<string, object> GLMKJIECICE)
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
			[Cpp2IlInjected.Address(RVA = "0x3D0C5A0", Offset = "0x3D0B5A0", VA = "0x183D0C5A0")]
			public void PAEAMNNNCJO(Dictionary<string, object> HGBDOPHIEND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D0FAB0", Offset = "0x3D0EAB0", VA = "0x183D0FAB0")]
			public void PAEAMNNNCJO(Dictionary<string, object> DGKOAEJKOFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xEE7120", Offset = "0xEE6120", VA = "0x180EE7120")]
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
			[Cpp2IlInjected.Address(RVA = "0x4281A0", Offset = "0x4271A0", VA = "0x1804281A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x428440", Offset = "0x427440", VA = "0x180428440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3D0BED0", Offset = "0x3D0AED0", VA = "0x183D0BED0")]
		public static DALENJNCKHB FIOHCBANLKE(string CGMBLHAMNGM, string IGBMBJPCOPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C300", Offset = "0x3D0B300", VA = "0x183D0C300")]
		protected AmplitudeAnalyticsIdentifyMessage(string CGMBLHAMNGM, string IGBMBJPCOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C220", Offset = "0x3D0B220", VA = "0x183D0C220")]
		public Dictionary<string, object> JOJGAJPDDAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3D0BFE0", Offset = "0x3D0AFE0", VA = "0x183D0BFE0", Slot = "4")]
		protected virtual Dictionary<string, object> JNCLALDPJAI(Dictionary<string, object> GLMKJIECICE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3D0BE30", Offset = "0x3D0AE30", VA = "0x183D0BE30")]
		protected void ADAPCPILMFP(string FNHMPFHLGJM, Dictionary<string, object> MEFBLNCAIBJ, Dictionary<string, object> NLJHLOCMFNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3D0BDC0", Offset = "0x3D0ADC0", VA = "0x183D0BDC0")]
		protected void AAKEECHPKPN(string FNHMPFHLGJM, string DAPPHEJJLEB, Dictionary<string, object> CHMCGJKKKCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C290", Offset = "0x3D0B290", VA = "0x183D0C290", Slot = "5")]
		public virtual void PAPDEJBPHNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3D0BF70", Offset = "0x3D0AF70", VA = "0x183D0BF70", Slot = "6")]
		public virtual void HALLMKDLMMM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DALENJNCKHB : global::KDHNDLIOEIO<AmplitudeAnalyticsIdentifyMessage, DALENJNCKHB>
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override DALENJNCKHB PBACMOPPMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4B99A0", Offset = "0x4B89A0", VA = "0x1804B99A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4281A0", Offset = "0x4271A0", VA = "0x1804281A0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage ANONMFCKNBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C550", Offset = "0x3D0B550", VA = "0x183D0C550")]
	public DALENJNCKHB(AmplitudeAnalyticsIdentifyMessage PGGLBCNNNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C4C0", Offset = "0x3D0B4C0", VA = "0x183D0C4C0", Slot = "4")]
	public override void HALLMKDLMMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class INMBONFCCOM : global::KDHNDLIOEIO<AmplitudeAnalyticsEvent, INMBONFCCOM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool COIEAAAHKHH;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override INMBONFCCOM PBACMOPPMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4B99A0", Offset = "0x4B89A0", VA = "0x1804B99A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C960", Offset = "0x3D0B960", VA = "0x183D0C960")]
	public INMBONFCCOM(AmplitudeAnalyticsEvent PGGLBCNNNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4281A0", Offset = "0x4271A0", VA = "0x1804281A0", Slot = "5")]
	public override AmplitudeAnalyticsEvent ANONMFCKNBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C7E0", Offset = "0x3D0B7E0", VA = "0x183D0C7E0", Slot = "4")]
	public override void HALLMKDLMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0220", Offset = "0x1CBF220", VA = "0x181CC0220")]
	public INMBONFCCOM CIBPCDCBMLM<T>(string MJNBLHFKKJN, T[] DAPPHEJJLEB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C760", Offset = "0x3D0B760", VA = "0x183D0C760")]
	public INMBONFCCOM CIBPCDCBMLM(string MJNBLHFKKJN, string[] DAPPHEJJLEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1CC01B0", Offset = "0x1CBF1B0", VA = "0x181CC01B0")]
	public INMBONFCCOM CIBPCDCBMLM<T>(string MJNBLHFKKJN, T DAPPHEJJLEB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C770", Offset = "0x3D0B770", VA = "0x183D0C770")]
	public INMBONFCCOM CIBPCDCBMLM(string MJNBLHFKKJN, string DAPPHEJJLEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C880", Offset = "0x3D0B880", VA = "0x183D0C880")]
	private INMBONFCCOM IMNDCOEHDGO(string MJNBLHFKKJN, object DAPPHEJJLEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LPJGCILAMKA : INMBONFCCOM
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C960", Offset = "0x3D0B960", VA = "0x183D0C960")]
	public LPJGCILAMKA(AmplitudeAnalyticsEvent PGGLBCNNNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3D0DAC0", Offset = "0x3D0CAC0", VA = "0x183D0DAC0", Slot = "4")]
	public override void HALLMKDLMMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class KDHNDLIOEIO<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::KDHNDLIOEIO<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	protected M PGGLBCNNNLK;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public abstract BLDR PBACMOPPMOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1B08420", Offset = "0x1B07420", VA = "0x181B08420")]
	public KDHNDLIOEIO(M PGGLBCNNNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1C02B40", Offset = "0x1C01B40", VA = "0x181C02B40")]
	public BLDR FHCECNPLFOG(AmplitudeAnalyticsIdentifyMessage.DeviceInfo FOHDMMIEHLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1C02B70", Offset = "0x1C01B70", VA = "0x181C02B70")]
	public BLDR HKDKIMDFKED(AmplitudeAnalyticsIdentifyMessage.RevenueData NHOECJDMDID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1C02BA0", Offset = "0x1C01BA0", VA = "0x181C02BA0")]
	public BLDR KDLDLKCHHLL(string MJNBLHFKKJN, string DAPPHEJJLEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8010", Offset = "0x1AC7010", VA = "0x181AC8010")]
	public BLDR KDLDLKCHHLL<T>(string MJNBLHFKKJN, T DAPPHEJJLEB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void HALLMKDLMMM();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1C02C10", Offset = "0x1C01C10", VA = "0x181C02C10")]
	internal static string OLGPJJPGLKI(string DAPPHEJJLEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1C02C40", Offset = "0x1C01C40", VA = "0x181C02C40")]
	private BLDR PMBOFFNPGFF(string MJNBLHFKKJN, object DAPPHEJJLEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M ANONMFCKNBK();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EBCLMAACEPL
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public const int CPGBCNCJGLE = 2;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int EBJIKNGFEMN = 100;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int POELPGENEFE = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const long KKDHCNEAIFF = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const int LJKDDKAKCEC = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int HHMGKJLNKMK = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const string AIJHDDEDNNI = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string MJDAFBOICAN = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string JHFILDKENCC = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string MOHCAINELLO = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string PNNCGAKLINE = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string DFJBCAEGKMD = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string NCJJLDHFCEO = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string HCLDFBANIFB = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const int MHIGBFNBJCC = 10;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> DLLOFLIMCKK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
	public EBCLMAACEPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LAPKGCOCBII
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string ABCHBMCBCKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string FIDGHJAGDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string HNFKKMMPEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::CFGAGIADBID<ECHGBOGBIDB> CGJGMKKOJLM(string AOHAGHMLDGG, Dictionary<string, string> ODDINIHKFDB);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct ECHGBOGBIDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly int HJHPLEGLHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly string BMFFHLJFJLM;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4308C0", Offset = "0x42F8C0", VA = "0x1804308C0")]
	public ECHGBOGBIDB(int JBIDLJNDIOI, string FHPAKBDOFFK)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LGDKMIAMCPL
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static byte[] LLKCDANIMKG;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int KMKLKIAMDMD;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int BIIMDIBEBNB;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static BigInteger IFDENKAOIAA;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
	public LGDKMIAMCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D4E0", Offset = "0x3D0C4E0", VA = "0x183D0D4E0")]
	private static string CIKBPDDNPOK(byte[] AFFHLKNKJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D5E0", Offset = "0x3D0C5E0", VA = "0x183D0D5E0")]
	public static string PKHKMHCALIH(byte[] CKHCBGBCFMM, bool INBKMGGNPMJ)
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
		[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
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
