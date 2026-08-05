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
		public AmplitudeAnalyticsClient.Settings AFMNCCACNOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NILKONEMNNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4F71D0", Offset = "0x4F65D0", VA = "0x1804F71D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x44EFE0", Offset = "0x44E3E0", VA = "0x18044EFE0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum JFKEIJANPNO
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class FGCIGHLJDNK
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class GJMNIFAFOID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public int AOOCCNAGBJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public Dictionary<string, object> IKNMFKHHGOB;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
				public GJMNIFAFOID()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class LHGNDPOGOAL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
				public LHGNDPOGOAL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x3F8CD20", Offset = "0x3F8C120", VA = "0x183F8CD20")]
				internal bool <GetBatch>b__0(GJMNIFAFOID item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private const string GOCLINDLPAE = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string ABJMLCLDPFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<GJMNIFAFOID> POLCJKKONGB;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? GGEPNIIBBHH
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x3F8B8D0", Offset = "0x3F8ACD0", VA = "0x183F8B8D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? KICHDJMBLFF
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x3F8B630", Offset = "0x3F8AA30", VA = "0x183F8B630")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3F8C190", Offset = "0x3F8B590", VA = "0x183F8C190")]
			internal FGCIGHLJDNK(string JEPLNJAGPAE, string IBCHAJFALEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B4D0", Offset = "0x3F8A8D0", VA = "0x183F8B4D0")]
			public int CJILCNNIDHH([Optional] int? CIGFEEFALOH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B2D0", Offset = "0x3F8A6D0", VA = "0x183F8B2D0")]
			public List<Dictionary<string, object>> CGIPCJCKOMG(int CDAHEKFDCLM, int? CIGFEEFALOH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B010", Offset = "0x3F8A410", VA = "0x183F8B010")]
			public void BNDGGPNPMNM(AmplitudeAnalyticsIdentifyMessage HLLMFMGFIPB, bool JOACEMMPDEM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B0B0", Offset = "0x3F8A4B0", VA = "0x183F8B0B0")]
			public void BNDGGPNPMNM(Dictionary<string, object> HLLMFMGFIPB, bool JOACEMMPDEM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B1A0", Offset = "0x3F8A5A0", VA = "0x183F8B1A0")]
			public void CEPPOBMDLOM(params Dictionary<string, object>[] BGGANGGDFOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3F8BBA0", Offset = "0x3F8AFA0", VA = "0x183F8BBA0")]
			public void LBPEDBBMLCN(List<Dictionary<string, object>> NFFGIBFGGIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B960", Offset = "0x3F8AD60", VA = "0x183F8B960")]
			private void HOOJHGHCOKD(Dictionary<string, object> HLLMFMGFIPB, bool JOACEMMPDEM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B6E0", Offset = "0x3F8AAE0", VA = "0x183F8B6E0")]
			public void FFOAPMCMPDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3F8BDC0", Offset = "0x3F8B1C0", VA = "0x183F8BDC0")]
			private void PJCGKCIDDCI([Optional] string HGKPFEHLGDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3F8BA70", Offset = "0x3F8AE70", VA = "0x183F8BA70")]
			private static string LAAMFBFMOPL(string ELCLILAGMPD, string IDFIPMLKMCO)
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
			[Cpp2IlInjected.Address(RVA = "0x3F8D7C0", Offset = "0x3F8CBC0", VA = "0x183F8D7C0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct IBGKFONPMBM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int JCGGDAGDNDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public string AEJJMBBGBEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T AOABODLLPGF;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class AHIMIMBBDPN : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private JKJIBOEKIAI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
			[DebuggerHidden]
			public AHIMIMBBDPN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3F85C20", Offset = "0x3F85020", VA = "0x183F85C20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3F86340", Offset = "0x3F85740", VA = "0x183F86340", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class KEJGJIOEHBD : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
			[DebuggerHidden]
			public KEJGJIOEHBD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3F8CC00", Offset = "0x3F8C000", VA = "0x183F8CC00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3F8CCD0", Offset = "0x3F8C0D0", VA = "0x183F8CCD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JLNMOAJNCNE : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
			[DebuggerHidden]
			public JLNMOAJNCNE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3F8CA70", Offset = "0x3F8BE70", VA = "0x183F8CA70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3F8CBB0", Offset = "0x3F8BFB0", VA = "0x183F8CBB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class IAHEAOHDNMF : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private JKJIBOEKIAI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
			[DebuggerHidden]
			public IAHEAOHDNMF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3F8C2E0", Offset = "0x3F8B6E0", VA = "0x183F8C2E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3F8C520", Offset = "0x3F8B920", VA = "0x183F8C520", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class PCIDAMGKLEC : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private JKJIBOEKIAI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
			[DebuggerHidden]
			public PCIDAMGKLEC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3F8D410", Offset = "0x3F8C810", VA = "0x183F8D410", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3F8D650", Offset = "0x3F8CA50", VA = "0x183F8D650", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class CGAFANMONKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public FGCIGHLJDNK cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
			public CGAFANMONKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3F8A470", Offset = "0x3F89870", VA = "0x183F8A470")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3F8A510", Offset = "0x3F89910", VA = "0x183F8A510")]
			internal void <FlushFromCache>b__1(IBGKFONPMBM<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class NLMMDDMOHME : IEnumerator<JKJIBOEKIAI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private JKJIBOEKIAI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public FGCIGHLJDNK cache;

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
			private CGAFANMONKE <>8__1;

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
			private JKJIBOEKIAI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
			[DebuggerHidden]
			public NLMMDDMOHME(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x3F8CD80", Offset = "0x3F8C180", VA = "0x183F8CD80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3F8D3C0", Offset = "0x3F8C7C0", VA = "0x183F8D3C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class MAEOEHKECNO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
			public MAEOEHKECNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x205ACF0", Offset = "0x205A0F0", VA = "0x18205ACF0")]
			internal IBGKFONPMBM<T> <PostJson>b__0(MLBFLMNAMEC postResponse)
			{
				return default(IBGKFONPMBM<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private EMCJLKKLOHF LPLBEPNPJKK;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string CKJFDDGENHC = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string GAOJAFPKDKB = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string NPCAKPLNEDF = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string CHBMOPFEBND = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string MDEEJJBKFAF = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int KGNNLPBBEHN = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int AOAABCEFJHI = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int JABCLEHKNML = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float GPOIPIOBILJ = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long JAGAAPDOKJF = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string LKKEPABDJNI = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static bool PEKOFGDCLCD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool HJKFILPDLAI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static int PJKPEKGAOID;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int GJKFECJLKNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private BJNEMHNODAG KKAHAFPAAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool IINHPDKNOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float ICLDJDDLONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float DGLNDBKMGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int BPNKCPCHFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int LFGEGBADANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int? PEECGLBIIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? MDKCNDPLAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private long CHOFIMLPMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string FDAFPPONEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long IAHHGBNOOIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, object> LDHPOEPFNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private JFKEIJANPNO NLFCCFBDPPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int PHJFGAFEIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int BDFFGHBHPLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float LGDJHDMODOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool LBBAJGGLBBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool PIAPIHOIOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private FGCIGHLJDNK AEPBDHGGJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private FGCIGHLJDNK DHGEFKDHHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private FGCIGHLJDNK EFEJIMOGDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> OAJCLDIGCHL;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo NAEBLGFLPGN;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static string LCBHNILGFIC;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string BBDAKEFDIBJ = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string JMEBAILGIHA = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private EMCJLKKLOHF KPDCAHKMLFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3F87740", Offset = "0x3F86B40", VA = "0x183F87740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int NHKCBEHMHED
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3F88280", Offset = "0x3F87680", VA = "0x183F88280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long MCOFGEPELLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3F89620", Offset = "0x3F88A20", VA = "0x183F89620")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3F89720", Offset = "0x3F88B20", VA = "0x183F89720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string EKIOEDKDKFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3F895F0", Offset = "0x3F889F0", VA = "0x183F895F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string GCABEEBHBKH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4572D0", Offset = "0x4566D0", VA = "0x1804572D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x751ED0", Offset = "0x7512D0", VA = "0x180751ED0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool MPBMAELJCHB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4F04D0", Offset = "0x4EF8D0", VA = "0x1804F04D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x57F870", Offset = "0x57EC70", VA = "0x18057F870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool DOJDMIIHMEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3F89510", Offset = "0x3F88910", VA = "0x183F89510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> JAHBIMKPFIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3F89470", Offset = "0x3F88870", VA = "0x183F89470")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3F89680", Offset = "0x3F88A80", VA = "0x183F89680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3F86580", Offset = "0x3F85980", VA = "0x183F86580", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3F88F00", Offset = "0x3F88300", VA = "0x183F88F00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3F88680", Offset = "0x3F87A80", VA = "0x183F88680", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3F89080", Offset = "0x3F88480", VA = "0x183F89080")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3F88220", Offset = "0x3F87620", VA = "0x183F88220")]
		private bool NKFCHIPCGIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3F875E0", Offset = "0x3F869E0", VA = "0x183F875E0")]
		[IteratorStateMachine(typeof(AHIMIMBBDPN))]
		public IEnumerator<JKJIBOEKIAI> Initialize(AmplitudeAnalyticsEvent ADBBHINLBAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F88FD0", Offset = "0x3F883D0", VA = "0x183F88FD0")]
		public void UpdateLastAliveTime(float DKCCJEANLOL = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3F878B0", Offset = "0x3F86CB0", VA = "0x183F878B0")]
		private bool KMHBNJBCODE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3F884A0", Offset = "0x3F878A0", VA = "0x183F884A0")]
		private bool OJBCJCCCACB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3F88B90", Offset = "0x3F87F90", VA = "0x183F88B90")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3F88700", Offset = "0x3F87B00", VA = "0x183F88700")]
		[IteratorStateMachine(typeof(KEJGJIOEHBD))]
		private IEnumerator PABOJCNABHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3F892E0", Offset = "0x3F886E0", VA = "0x183F892E0")]
		[IteratorStateMachine(typeof(JLNMOAJNCNE))]
		public IEnumerator WaitForFlush(float IOCLNICFHHP = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3F88F10", Offset = "0x3F88310", VA = "0x183F88F10")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3F872F0", Offset = "0x3F866F0", VA = "0x183F872F0")]
		public static JIAOKEKKHIM Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3F86440", Offset = "0x3F85840", VA = "0x183F86440")]
		public static JCMGOOPMDBE AccountSelectionPostLoginEvent([NotNull] string LCNEHNDENJD, string LNOPOLIHBDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3F86D00", Offset = "0x3F86100", VA = "0x183F86D00")]
		public static JCMGOOPMDBE Event([NotNull] string LCNEHNDENJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F88760", Offset = "0x3F87B60", VA = "0x183F88760")]
		public static JCMGOOPMDBE PreviousSessionEvent([NotNull] string LCNEHNDENJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3F87430", Offset = "0x3F86830", VA = "0x183F87430")]
		public static JCMGOOPMDBE InitializeEvent(string LNOPOLIHBDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F88CA0", Offset = "0x3F880A0", VA = "0x183F88CA0")]
		public static JCMGOOPMDBE StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F86A50", Offset = "0x3F85E50", VA = "0x183F86A50")]
		public static JCMGOOPMDBE CreateOutOfSessionEvent(string LCNEHNDENJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F87D20", Offset = "0x3F87120", VA = "0x183F87D20")]
		public static GMANCKGDIIA LogOutOfSessionEvent(JCMGOOPMDBE JDPANAGNEMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F87B70", Offset = "0x3F86F70", VA = "0x183F87B70")]
		public void LogEventAsync(AmplitudeAnalyticsEvent CMGJBJIEIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3F87EF0", Offset = "0x3F872F0", VA = "0x183F87EF0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent CMGJBJIEIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F87FC0", Offset = "0x3F873C0", VA = "0x183F87FC0")]
		public void LogSerializedEventAsync(Dictionary<string, object> PJLEBENDNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3F87C40", Offset = "0x3F87040", VA = "0x183F87C40")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage GOHANPNMHMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3F87810", Offset = "0x3F86C10", VA = "0x183F87810")]
		private void KHCDPEBOILA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3F870D0", Offset = "0x3F864D0", VA = "0x183F870D0")]
		private void IOCNKLHKIAN(Dictionary<string, object> IMLEIDACPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3F87A90", Offset = "0x3F86E90", VA = "0x183F87A90")]
		private void LNMMHLHGJLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3F88090", Offset = "0x3F87490", VA = "0x183F88090")]
		private void MPCHFJIHCGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3F86E60", Offset = "0x3F86260", VA = "0x183F86E60")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3F87A20", Offset = "0x3F86E20", VA = "0x183F87A20")]
		[IteratorStateMachine(typeof(IAHEAOHDNMF))]
		private IEnumerator<JKJIBOEKIAI> KOALBHOHFAI(float IOCLNICFHHP = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F87050", Offset = "0x3F86450", VA = "0x183F87050")]
		[IteratorStateMachine(typeof(PCIDAMGKLEC))]
		private IEnumerator<JKJIBOEKIAI> GPJDKMFBHHA(float IOCLNICFHHP = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3F86390", Offset = "0x3F85790", VA = "0x183F86390")]
		[IteratorStateMachine(typeof(NLMMDDMOHME))]
		private IEnumerator<JKJIBOEKIAI> ACDOJLNBGIC(FGCIGHLJDNK DOJJKLHJOPG, int? CIGFEEFALOH, string EMNCHGKKEEE, string MLCHLBAOFKH, float IOCLNICFHHP, Action<int> MKIGPCLLIFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3F87650", Offset = "0x3F86A50", VA = "0x183F87650")]
		private static void JDJLDKDPGEB(bool NFMIPMJOIGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x18A4E60", Offset = "0x18A4260", VA = "0x1818A4E60")]
		private global::KCBHFPPLLKO<IBGKFONPMBM<T>> HGBNKDBNNAC<T>(string EMNCHGKKEEE, string MLCHLBAOFKH, string MHDKNPFFBGF, T AOABODLLPGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3F86A00", Offset = "0x3F85E00", VA = "0x183F86A00")]
		private bool CLNOOJKOOMA(float GBIOPJHDJOL, float IOCLNICFHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3F893B0", Offset = "0x3F887B0", VA = "0x183F893B0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3F86EF0", Offset = "0x3F862F0", VA = "0x183F86EF0")]
		[CompilerGenerated]
		private long GOAFENDDNDF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3F870C0", Offset = "0x3F864C0", VA = "0x183F870C0")]
		[CompilerGenerated]
		private void HCGNIBKCHPF(int LIGCHBIKKDJ)
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
			[Cpp2IlInjected.Address(RVA = "0x46D870", Offset = "0x46CC70", VA = "0x18046D870")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3F89C30", Offset = "0x3F89030", VA = "0x183F89C30")]
		public static JCMGOOPMDBE LFIKOCHGCKP(string JGNLFPLJJBJ, [NotNull] string BLIJGJJFFEH, long HJEGLNMKGCD, long MCKJCPKMKGH, string LNOPOLIHBDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3F89780", Offset = "0x3F88B80", VA = "0x183F89780")]
		public static JCMGOOPMDBE FPCINCBCMJK(string JGNLFPLJJBJ, [NotNull] string BLIJGJJFFEH, long HJEGLNMKGCD, long MCKJCPKMKGH, string LNOPOLIHBDC, long MJHDNIHOEPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3F89D10", Offset = "0x3F89110", VA = "0x183F89D10")]
		private AmplitudeAnalyticsEvent(string JGNLFPLJJBJ, [NotNull] string BLIJGJJFFEH, long HJEGLNMKGCD, long MCKJCPKMKGH, string LNOPOLIHBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x528200", Offset = "0x527600", VA = "0x180528200")]
		public void FOGHKNIAFPP(long AOLOEIMGFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3F89870", Offset = "0x3F88C70", VA = "0x183F89870", Slot = "5")]
		public override void HEBJMKIDJAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3F89980", Offset = "0x3F88D80", VA = "0x183F89980", Slot = "6")]
		public override void JPNCCKJILBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3F899F0", Offset = "0x3F88DF0", VA = "0x183F899F0", Slot = "4")]
		protected override Dictionary<string, object> KHLKKCMPFHC(Dictionary<string, object> AABPNCPPHDN)
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
			[Cpp2IlInjected.Address(RVA = "0x3F8A910", Offset = "0x3F89D10", VA = "0x183F8A910")]
			public void MKDIDFIBOMH(Dictionary<string, object> OGJHOEJGDCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F8D6A0", Offset = "0x3F8CAA0", VA = "0x183F8D6A0")]
			public void MKDIDFIBOMH(Dictionary<string, object> IICGNFBOIPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7DD2D0", Offset = "0x7DC6D0", VA = "0x1807DD2D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B5750", Offset = "0x4B4B50", VA = "0x1804B5750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x472460", Offset = "0x471860", VA = "0x180472460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3F8A290", Offset = "0x3F89690", VA = "0x183F8A290")]
		public static JIAOKEKKHIM LFIKOCHGCKP(string JGNLFPLJJBJ, string LNOPOLIHBDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3F8A3D0", Offset = "0x3F897D0", VA = "0x183F8A3D0")]
		protected AmplitudeAnalyticsIdentifyMessage(string JGNLFPLJJBJ, string LNOPOLIHBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3F89E90", Offset = "0x3F89290", VA = "0x183F89E90")]
		public Dictionary<string, object> FBPKAPPFLOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3F8A050", Offset = "0x3F89450", VA = "0x183F8A050", Slot = "4")]
		protected virtual Dictionary<string, object> KHLKKCMPFHC(Dictionary<string, object> AABPNCPPHDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3F8A330", Offset = "0x3F89730", VA = "0x183F8A330")]
		protected void POBJOKLFCAN(string IDFIPMLKMCO, Dictionary<string, object> EKEKCODICLN, Dictionary<string, object> EPCIIJGPCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3F89FE0", Offset = "0x3F893E0", VA = "0x183F89FE0")]
		protected void KBHNMKMBAFM(string IDFIPMLKMCO, string ELCLILAGMPD, Dictionary<string, object> NMOJKOJIJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3F89F00", Offset = "0x3F89300", VA = "0x183F89F00", Slot = "5")]
		public virtual void HEBJMKIDJAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3F89F70", Offset = "0x3F89370", VA = "0x183F89F70", Slot = "6")]
		public virtual void JPNCCKJILBO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JIAOKEKKHIM : global::PEGKFBJIIKB<AmplitudeAnalyticsIdentifyMessage, JIAOKEKKHIM>
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override JIAOKEKKHIM NHJMLAKOACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x92CB70", Offset = "0x92BF70", VA = "0x18092CB70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4B5750", Offset = "0x4B4B50", VA = "0x1804B5750", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage FOHCOHGLILE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C980", Offset = "0x3F8BD80", VA = "0x183F8C980")]
	public JIAOKEKKHIM(AmplitudeAnalyticsIdentifyMessage IJDMJMJNBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C8F0", Offset = "0x3F8BCF0", VA = "0x183F8C8F0", Slot = "4")]
	public override void JPNCCKJILBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JCMGOOPMDBE : global::PEGKFBJIIKB<AmplitudeAnalyticsEvent, JCMGOOPMDBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool CMHEOJBKMKP;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override JCMGOOPMDBE NHJMLAKOACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x92CB70", Offset = "0x92BF70", VA = "0x18092CB70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C6A0", Offset = "0x3F8BAA0", VA = "0x183F8C6A0")]
	public JCMGOOPMDBE(AmplitudeAnalyticsEvent IJDMJMJNBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4B5750", Offset = "0x4B4B50", VA = "0x1804B5750", Slot = "5")]
	public override AmplitudeAnalyticsEvent FOHCOHGLILE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C6F0", Offset = "0x3F8BAF0", VA = "0x183F8C6F0", Slot = "4")]
	public override void JPNCCKJILBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	public JCMGOOPMDBE OPJAINEGJFP<T>(string NIIGDKMNLFG, T[] ELCLILAGMPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C790", Offset = "0x3F8BB90", VA = "0x183F8C790")]
	public JCMGOOPMDBE OPJAINEGJFP(string NIIGDKMNLFG, string[] ELCLILAGMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x18A73C0", Offset = "0x18A67C0", VA = "0x1818A73C0")]
	public JCMGOOPMDBE OPJAINEGJFP<T>(string NIIGDKMNLFG, T ELCLILAGMPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C7A0", Offset = "0x3F8BBA0", VA = "0x183F8C7A0")]
	public JCMGOOPMDBE OPJAINEGJFP(string NIIGDKMNLFG, string ELCLILAGMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C810", Offset = "0x3F8BC10", VA = "0x183F8C810")]
	private JCMGOOPMDBE PBEGHIPOFDM(string NIIGDKMNLFG, object ELCLILAGMPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IIACHKLHBPE : JCMGOOPMDBE
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C6A0", Offset = "0x3F8BAA0", VA = "0x183F8C6A0")]
	public IIACHKLHBPE(AmplitudeAnalyticsEvent IJDMJMJNBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C570", Offset = "0x3F8B970", VA = "0x183F8C570", Slot = "4")]
	public override void JPNCCKJILBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class PEGKFBJIIKB<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::PEGKFBJIIKB<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	protected M IJDMJMJNBOI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public abstract BLDR NHJMLAKOACH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x20747A0", Offset = "0x2073BA0", VA = "0x1820747A0")]
	public PEGKFBJIIKB(M IJDMJMJNBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2768220", Offset = "0x2767620", VA = "0x182768220")]
	public BLDR NLNODMHBIOP(AmplitudeAnalyticsIdentifyMessage.DeviceInfo MKNFBAPAIIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2768070", Offset = "0x2767470", VA = "0x182768070")]
	public BLDR HNMMIMIEOME(AmplitudeAnalyticsIdentifyMessage.RevenueData GIOKADDGCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x27680D0", Offset = "0x27674D0", VA = "0x1827680D0")]
	public BLDR KMBOKIDGOMI(string NIIGDKMNLFG, string ELCLILAGMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x20F8380", Offset = "0x20F7780", VA = "0x1820F8380")]
	public BLDR KMBOKIDGOMI<T>(string NIIGDKMNLFG, T ELCLILAGMPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JPNCCKJILBO();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x27680A0", Offset = "0x27674A0", VA = "0x1827680A0")]
	internal static string JADNDPFJBPE(string ELCLILAGMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2768140", Offset = "0x2767540", VA = "0x182768140")]
	private BLDR NGNHABAADFD(string NIIGDKMNLFG, object ELCLILAGMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M FOHCOHGLILE();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JIJLOEGKIEN
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public const int ACMPMJPCCGC = 2;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int KAHMFOMNNGG = 100;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int LHJNEJONKFP = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const long BCHMCJEHEFA = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const int JNPPHFEDJMC = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int DJHFPAFMDMD = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const string EJJEGGGEBDG = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string EKDCMIGNNCC = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string AALHHCLKMGP = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string BOKCNGPEIBE = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string CDHOKEBIICL = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string HFAHCGDHJLC = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string PPBHANLKPGH = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string IFNMHKDOBGM = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const int MAJLPCIAMFH = 10;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> IECPIKHHEOK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
	public JIJLOEGKIEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BJNEMHNODAG
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string IOOPIDCOLAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string LLLCEBBDHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string ONOGPDDCIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::KCBHFPPLLKO<MLBFLMNAMEC> HGBNKDBNNAC(string EMNCHGKKEEE, Dictionary<string, string> CADFMHIAJLM);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct MLBFLMNAMEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly int OBMAAIJJMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly string IIFHKGEGFMJ;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xCBB420", Offset = "0xCBA820", VA = "0x180CBB420")]
	public MLBFLMNAMEC(int JCGGDAGDNDF, string AEJJMBBGBEG)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EEINDPOJDJJ
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static byte[] OCLOOGINPMJ;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int CFJLDOHEGKM;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int PFIGBFOAIKM;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static BigInteger HJNCOPCDJHG;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
	public EEINDPOJDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3F8AD60", Offset = "0x3F8A160", VA = "0x183F8AD60")]
	private static string KPINMDKLMNN(byte[] LPAMLJLFLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3F8AA30", Offset = "0x3F89E30", VA = "0x183F8AA30")]
	public static string FEMGPJIFPGG(byte[] OOOKMGPDPAC, bool KLBFBHHGCEE)
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
		[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
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
