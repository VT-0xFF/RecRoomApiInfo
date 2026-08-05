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
		public AmplitudeAnalyticsClient.Settings CEGGNOBNKED
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool FBIMCKAICBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4462C0", Offset = "0x4452C0", VA = "0x1804462C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x41FA40", Offset = "0x41EA40", VA = "0x18041FA40")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private enum EHFNMPNKDML
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal class MIFBEFCEOML
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class ADNAEPAMCGD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public int GIGGLHEHOPK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public Dictionary<string, object> LAEJADCDOLH;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
				public ADNAEPAMCGD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class FMOCKJKMGPP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
				public FMOCKJKMGPP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x3CB48A0", Offset = "0x3CB38A0", VA = "0x183CB48A0")]
				internal bool <GetBatch>b__0(ADNAEPAMCGD item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private const string GNECMMBPFJJ = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly string FDCPLAONMDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private List<ADNAEPAMCGD> EOOIOKNJLJO;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public int? JPIJOKAGNGC
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x3CB66D0", Offset = "0x3CB56D0", VA = "0x183CB66D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public int? BLMDCEFFHIJ
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x3CB6620", Offset = "0x3CB5620", VA = "0x183CB6620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3CB74B0", Offset = "0x3CB64B0", VA = "0x183CB74B0")]
			internal MIFBEFCEOML(string HIFNBGGLOAG, string COJDGPMHMHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3CB6330", Offset = "0x3CB5330", VA = "0x183CB6330")]
			public int BHIGMKNEJDE([Optional] int? OPIADDIFJDL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3CB71A0", Offset = "0x3CB61A0", VA = "0x183CB71A0")]
			public List<Dictionary<string, object>> OGLNCACGDOC(int CODHMCKAJHE, int? OPIADDIFJDL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3CB6580", Offset = "0x3CB5580", VA = "0x183CB6580")]
			public void CGHFDBBPNOH(AmplitudeAnalyticsIdentifyMessage BLBFEBCDCJJ, bool NJDOANKFMLI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3CB6490", Offset = "0x3CB5490", VA = "0x183CB6490")]
			public void CGHFDBBPNOH(Dictionary<string, object> BLBFEBCDCJJ, bool NJDOANKFMLI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3CB7070", Offset = "0x3CB6070", VA = "0x183CB7070")]
			public void LNKIPLEBDIA(params Dictionary<string, object>[] AJEKEABLGBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3CB6E50", Offset = "0x3CB5E50", VA = "0x183CB6E50")]
			public void LBIJEPCOPEO(List<Dictionary<string, object>> MPBLMEELINC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3CB73A0", Offset = "0x3CB63A0", VA = "0x183CB73A0")]
			private void PLDINHEOGOP(Dictionary<string, object> BLBFEBCDCJJ, bool NJDOANKFMLI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3CB6C60", Offset = "0x3CB5C60", VA = "0x183CB6C60")]
			public void KCCHJLPBCNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3CB6890", Offset = "0x3CB5890", VA = "0x183CB6890")]
			private void INHADNEIGCG([Optional] string LODNFIKDCKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3CB6760", Offset = "0x3CB5760", VA = "0x183CB6760")]
			private static string IHELDPOJCHP(string MNEBKBGCGHD, string PFPLGCLHCBM)
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
			[Cpp2IlInjected.Address(RVA = "0x3CB7DA0", Offset = "0x3CB6DA0", VA = "0x183CB7DA0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct BCCLIMIEPLL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public int POKIIJPDECO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public string FKBPMEKLCKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T PNMKBBKALFA;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class IELFMBFMHFO : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private DNKAKMFKLPM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
			[DebuggerHidden]
			public IELFMBFMHFO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3CB4900", Offset = "0x3CB3900", VA = "0x183CB4900", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3CB5020", Offset = "0x3CB4020", VA = "0x183CB5020", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class IFHAJPDGFDI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
			[DebuggerHidden]
			public IFHAJPDGFDI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3CB5070", Offset = "0x3CB4070", VA = "0x183CB5070", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3CB5140", Offset = "0x3CB4140", VA = "0x183CB5140", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KDCNGKFPEBH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
			[DebuggerHidden]
			public KDCNGKFPEBH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3CB5D00", Offset = "0x3CB4D00", VA = "0x183CB5D00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3CB5E40", Offset = "0x3CB4E40", VA = "0x183CB5E40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class ILNICFOJJIO : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private DNKAKMFKLPM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
			[DebuggerHidden]
			public ILNICFOJJIO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3CB5820", Offset = "0x3CB4820", VA = "0x183CB5820", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3CB5A60", Offset = "0x3CB4A60", VA = "0x183CB5A60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class LEHNHGICNKH : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private DNKAKMFKLPM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
			[DebuggerHidden]
			public LEHNHGICNKH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3CB5F70", Offset = "0x3CB4F70", VA = "0x183CB5F70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3CB61B0", Offset = "0x3CB51B0", VA = "0x183CB61B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class CHOFKKCBIMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public MIFBEFCEOML cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
			public CHOFKKCBIMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3CB42E0", Offset = "0x3CB32E0", VA = "0x183CB42E0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3CB4380", Offset = "0x3CB3380", VA = "0x183CB4380")]
			internal void <FlushFromCache>b__1(BCCLIMIEPLL<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class IJACHGALKHJ : IEnumerator<DNKAKMFKLPM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private DNKAKMFKLPM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public MIFBEFCEOML cache;

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
			private CHOFKKCBIMI <>8__1;

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
			private DNKAKMFKLPM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
			[DebuggerHidden]
			public IJACHGALKHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x3CB5190", Offset = "0x3CB4190", VA = "0x183CB5190", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3CB57D0", Offset = "0x3CB47D0", VA = "0x183CB57D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class EFCJMIKOJKI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
			public EFCJMIKOJKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2791E70", Offset = "0x2790E70", VA = "0x182791E70")]
			internal BCCLIMIEPLL<T> <PostJson>b__0(DMAHJNBJHIO postResponse)
			{
				return default(BCCLIMIEPLL<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ONKPOJHCBNM JJMDLGDJIDO;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string BGNKLMHIMGO = "event";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string MKKINBANGJF = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string CGGEGDLCJLP = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string CPBODEONBMF = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string BHFLCBNAKCP = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const int BJBFHMFCCDL = 10;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const int LFGLKFBJDCL = 10;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const int HOAMELPIMHE = 5;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float NEJHOMKLHPD = 60f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const long NELALIKGLGD = -1L;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string HNHGHGPFAMH = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static bool ACMFNNFOCJL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool DGEFANJJNDG;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static int OMHDBJNDLPD;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static int MCHNKLKBIAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private GPJCNFGKHNO ICNGKOOGION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool LNDEEEDMLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private float DOAEHDJFBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private float DDGGANKAEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int MIIMOKFAJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int PJBBHDDJAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int? CCMNKAGCAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int? AFJNHEHKMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private long HMDIBCNNEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string EBGOEBMKPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long OPJEODBGKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, object> NGPLMPCBFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private EHFNMPNKDML FNEACBHGFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int NOPPILNKIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int NPBGJPGMPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float JMODICONFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool CDLGGMCMIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool AOCACBLFLBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private MIFBEFCEOML ABMBFMHPONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private MIFBEFCEOML EAFMFBKEFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private MIFBEFCEOML HIAKMENOAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> OJMGPBMKAKL;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo EHJHFHGLEMO;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static string HIPFPPNKMIA;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string CKONCHCDMGL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string MONPNBICLJL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ONKPOJHCBNM MDEJAFHEJOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3CB1F60", Offset = "0x3CB0F60", VA = "0x183CB1F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static int DKMEEODJLGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3CB0E30", Offset = "0x3CAFE30", VA = "0x183CB0E30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static long ICECFPJOOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3490", Offset = "0x3CB2490", VA = "0x183CB3490")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3590", Offset = "0x3CB2590", VA = "0x183CB3590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static string NHPBJBIOGKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3460", Offset = "0x3CB2460", VA = "0x183CB3460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string JALNIMMIHCG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4699F0", Offset = "0x4689F0", VA = "0x1804699F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x422650", Offset = "0x421650", VA = "0x180422650")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IDDOIODEMMK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4D0910", Offset = "0x4CF910", VA = "0x1804D0910")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x14BA270", Offset = "0x14B9270", VA = "0x1814BA270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool LPNEMAFBJLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3380", Offset = "0x3CB2380", VA = "0x183CB3380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> KJJAOGINGGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3CB32E0", Offset = "0x3CB22E0", VA = "0x183CB32E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3CB34F0", Offset = "0x3CB24F0", VA = "0x183CB34F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0340", Offset = "0x3CAF340", VA = "0x183CB0340", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2D70", Offset = "0x3CB1D70", VA = "0x183CB2D70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2240", Offset = "0x3CB1240", VA = "0x183CB2240", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2EF0", Offset = "0x3CB1EF0", VA = "0x183CB2EF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1850", Offset = "0x3CB0850", VA = "0x183CB1850")]
		private bool KDDLMKDOGIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1390", Offset = "0x3CB0390", VA = "0x183CB1390")]
		[IteratorStateMachine(typeof(IELFMBFMHFO))]
		public IEnumerator<DNKAKMFKLPM> Initialize(AmplitudeAnalyticsEvent BIJIAOMICMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2E40", Offset = "0x3CB1E40", VA = "0x183CB2E40")]
		public void UpdateLastAliveTime(float DHNOCMNGKDP = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1400", Offset = "0x3CB0400", VA = "0x183CB1400")]
		private bool JANNNPGMPJP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1570", Offset = "0x3CB0570", VA = "0x183CB1570")]
		private bool JEOFNLNOJAP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2A00", Offset = "0x3CB1A00", VA = "0x183CB2A00")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1750", Offset = "0x3CB0750", VA = "0x183CB1750")]
		[IteratorStateMachine(typeof(IFHAJPDGFDI))]
		private IEnumerator JMOOJGGOCFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3150", Offset = "0x3CB2150", VA = "0x183CB3150")]
		[IteratorStateMachine(typeof(KDCNGKFPEBH))]
		public IEnumerator WaitForFlush(float GEOJGEPDPKA = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2D80", Offset = "0x3CB1D80", VA = "0x183CB2D80")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3CB10A0", Offset = "0x3CB00A0", VA = "0x183CB10A0")]
		public static KMFLOICKBBC Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0200", Offset = "0x3CAF200", VA = "0x183CB0200")]
		public static KAKFMNLHAND AccountSelectionPostLoginEvent([NotNull] string HADAFCJLJPL, string OIIDOEOEDBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0BD0", Offset = "0x3CAFBD0", VA = "0x183CB0BD0")]
		public static KAKFMNLHAND Event([NotNull] string HADAFCJLJPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3CB25D0", Offset = "0x3CB15D0", VA = "0x183CB25D0")]
		public static KAKFMNLHAND PreviousSessionEvent([NotNull] string HADAFCJLJPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3CB11E0", Offset = "0x3CB01E0", VA = "0x183CB11E0")]
		public static KAKFMNLHAND InitializeEvent(string OIIDOEOEDBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2B10", Offset = "0x3CB1B10", VA = "0x183CB2B10")]
		public static KAKFMNLHAND StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0920", Offset = "0x3CAF920", VA = "0x183CB0920")]
		public static KAKFMNLHAND CreateOutOfSessionEvent(string HADAFCJLJPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1A60", Offset = "0x3CB0A60", VA = "0x183CB1A60")]
		public static BNIMEGFNNGI LogOutOfSessionEvent(KAKFMNLHAND LMNBDGPPHPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3CB18B0", Offset = "0x3CB08B0", VA = "0x183CB18B0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent FPMMOKADJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1C30", Offset = "0x3CB0C30", VA = "0x183CB1C30")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent FPMMOKADJAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1D00", Offset = "0x3CB0D00", VA = "0x183CB1D00")]
		public void LogSerializedEventAsync(Dictionary<string, object> LAMIABAEDFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1980", Offset = "0x3CB0980", VA = "0x183CB1980")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage LGFOIDANFLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3CB17B0", Offset = "0x3CB07B0", VA = "0x183CB17B0")]
		private void JOPHKDIEFKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3CB23B0", Offset = "0x3CB13B0", VA = "0x183CB23B0")]
		private void PPJNHIMBEFN(Dictionary<string, object> BADELGGDOHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB07C0", Offset = "0x3CAF7C0", VA = "0x183CB07C0")]
		private void BMIODNBPKMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1DD0", Offset = "0x3CB0DD0", VA = "0x183CB1DD0")]
		private void NCFHKJDFCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0DA0", Offset = "0x3CAFDA0", VA = "0x183CB0DA0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3CB08A0", Offset = "0x3CAF8A0", VA = "0x183CB08A0")]
		[IteratorStateMachine(typeof(ILNICFOJJIO))]
		private IEnumerator<DNKAKMFKLPM> BMOENNFILBL(float GEOJGEPDPKA = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0D30", Offset = "0x3CAFD30", VA = "0x183CB0D30")]
		[IteratorStateMachine(typeof(LEHNHGICNKH))]
		private IEnumerator<DNKAKMFKLPM> FPGIIGKLIBB(float GEOJGEPDPKA = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2190", Offset = "0x3CB1190", VA = "0x183CB2190")]
		[IteratorStateMachine(typeof(IJACHGALKHJ))]
		private IEnumerator<DNKAKMFKLPM> OODHGCDMCPK(MIFBEFCEOML IPLIKAEFICK, int? OPIADDIFJDL, string JMPMCMDKFLG, string BLAFBJBOBJF, float GEOJGEPDPKA, Action<int> LCILMBAEMMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3CB22C0", Offset = "0x3CB12C0", VA = "0x183CB22C0")]
		private static void PDEBNDEIMDN(bool ANMMMFLPJMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x25E6070", Offset = "0x25E5070", VA = "0x1825E6070")]
		private global::GBEKKLLKIMD<BCCLIMIEPLL<T>> PHHMCFCAADL<T>(string JMPMCMDKFLG, string BLAFBJBOBJF, string EIAOPGNDADE, T PNMKBBKALFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1050", Offset = "0x3CB0050", VA = "0x183CB1050")]
		private bool HOHNHBPIEGB(float FCCPFFHLCGF, float GEOJGEPDPKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3220", Offset = "0x3CB2220", VA = "0x183CB3220")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2030", Offset = "0x3CB1030", VA = "0x183CB2030")]
		[CompilerGenerated]
		private long NPDFNCAFNMP()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0910", Offset = "0x3CAF910", VA = "0x183CB0910")]
		[CompilerGenerated]
		private void CELMHLAKAMP(int HJFFHDKKEPP)
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
			[Cpp2IlInjected.Address(RVA = "0x44C3E0", Offset = "0x44B3E0", VA = "0x18044C3E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3770", Offset = "0x3CB2770", VA = "0x183CB3770")]
		public static KAKFMNLHAND KCCOLOKOAMM(string JMGPPINBPMH, [NotNull] string GHGPOAIENMC, long KCBJGFNNPDI, long AALPLIDHBGF, string OIIDOEOEDBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3850", Offset = "0x3CB2850", VA = "0x183CB3850")]
		public static KAKFMNLHAND MJOJDNMMMIL(string JMGPPINBPMH, [NotNull] string GHGPOAIENMC, long KCBJGFNNPDI, long AALPLIDHBGF, string OIIDOEOEDBN, long FECBGDAHKII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3B80", Offset = "0x3CB2B80", VA = "0x183CB3B80")]
		private AmplitudeAnalyticsEvent(string JMGPPINBPMH, [NotNull] string GHGPOAIENMC, long KCBJGFNNPDI, long AALPLIDHBGF, string OIIDOEOEDBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4F0490", Offset = "0x4EF490", VA = "0x1804F0490")]
		public void OFPBOEOJDMG(long BEFEGJBMDPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3660", Offset = "0x3CB2660", VA = "0x183CB3660", Slot = "5")]
		public override void HGNHGPFMEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3CB35F0", Offset = "0x3CB25F0", VA = "0x183CB35F0", Slot = "6")]
		public override void FDFKOMAFHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3940", Offset = "0x3CB2940", VA = "0x183CB3940", Slot = "4")]
		protected override Dictionary<string, object> PADKDKANMIB(Dictionary<string, object> IKDHILPADBA)
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
			[Cpp2IlInjected.Address(RVA = "0x3CB4780", Offset = "0x3CB3780", VA = "0x183CB4780")]
			public void CPGOHGMPEBJ(Dictionary<string, object> NHMEBMIDGHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CB7C80", Offset = "0x3CB6C80", VA = "0x183CB7C80")]
			public void CPGOHGMPEBJ(Dictionary<string, object> OCFLBJHBGPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x16795A0", Offset = "0x16785A0", VA = "0x1816795A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x423200", Offset = "0x422200", VA = "0x180423200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x446570", Offset = "0x445570", VA = "0x180446570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3E80", Offset = "0x3CB2E80", VA = "0x183CB3E80")]
		public static KMFLOICKBBC KCCOLOKOAMM(string JMGPPINBPMH, string OIIDOEOEDBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4240", Offset = "0x3CB3240", VA = "0x183CB4240")]
		protected AmplitudeAnalyticsIdentifyMessage(string JMGPPINBPMH, string OIIDOEOEDBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3F20", Offset = "0x3CB2F20", VA = "0x183CB3F20")]
		public Dictionary<string, object> KGOFDHCNAMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4000", Offset = "0x3CB3000", VA = "0x183CB4000", Slot = "4")]
		protected virtual Dictionary<string, object> PADKDKANMIB(Dictionary<string, object> IKDHILPADBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3D70", Offset = "0x3CB2D70", VA = "0x183CB3D70")]
		protected void GBEKDNKENHI(string PFPLGCLHCBM, Dictionary<string, object> IKHMLEBHEJB, Dictionary<string, object> HJGJGGKIHOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3F90", Offset = "0x3CB2F90", VA = "0x183CB3F90")]
		protected void MCJLNBEIOAF(string PFPLGCLHCBM, string MNEBKBGCGHD, Dictionary<string, object> IDAJGEEHDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3E10", Offset = "0x3CB2E10", VA = "0x183CB3E10", Slot = "5")]
		public virtual void HGNHGPFMEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3D00", Offset = "0x3CB2D00", VA = "0x183CB3D00", Slot = "6")]
		public virtual void FDFKOMAFHDL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KMFLOICKBBC : global::JAHAPODLGJA<AmplitudeAnalyticsIdentifyMessage, KMFLOICKBBC>
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override KMFLOICKBBC NCDPIPCKGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4B19E0", Offset = "0x4B09E0", VA = "0x1804B19E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x423200", Offset = "0x422200", VA = "0x180423200", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage NIAKEBJILGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5F20", Offset = "0x3CB4F20", VA = "0x183CB5F20")]
	public KMFLOICKBBC(AmplitudeAnalyticsIdentifyMessage LHLENEDHGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5E90", Offset = "0x3CB4E90", VA = "0x183CB5E90", Slot = "4")]
	public override void FDFKOMAFHDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KAKFMNLHAND : global::JAHAPODLGJA<AmplitudeAnalyticsEvent, KAKFMNLHAND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool BJONFBFNIKP;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override KAKFMNLHAND NCDPIPCKGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4B19E0", Offset = "0x4B09E0", VA = "0x1804B19E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5CB0", Offset = "0x3CB4CB0", VA = "0x183CB5CB0")]
	public KAKFMNLHAND(AmplitudeAnalyticsEvent LHLENEDHGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x423200", Offset = "0x422200", VA = "0x180423200", Slot = "5")]
	public override AmplitudeAnalyticsEvent NIAKEBJILGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5B90", Offset = "0x3CB4B90", VA = "0x183CB5B90", Slot = "4")]
	public override void FDFKOMAFHDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	public KAKFMNLHAND HMONPJKBCJP<T>(string FBECKPLAEGL, T[] MNEBKBGCGHD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5CA0", Offset = "0x3CB4CA0", VA = "0x183CB5CA0")]
	public KAKFMNLHAND HMONPJKBCJP(string FBECKPLAEGL, string[] MNEBKBGCGHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x24B0980", Offset = "0x24AF980", VA = "0x1824B0980")]
	public KAKFMNLHAND HMONPJKBCJP<T>(string FBECKPLAEGL, T MNEBKBGCGHD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5C30", Offset = "0x3CB4C30", VA = "0x183CB5C30")]
	public KAKFMNLHAND HMONPJKBCJP(string FBECKPLAEGL, string MNEBKBGCGHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5AB0", Offset = "0x3CB4AB0", VA = "0x183CB5AB0")]
	private KAKFMNLHAND BBAKKOFJAJA(string FBECKPLAEGL, object MNEBKBGCGHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MEKPDEFFPKC : KAKFMNLHAND
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5CB0", Offset = "0x3CB4CB0", VA = "0x183CB5CB0")]
	public MEKPDEFFPKC(AmplitudeAnalyticsEvent LHLENEDHGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6200", Offset = "0x3CB5200", VA = "0x183CB6200", Slot = "4")]
	public override void FDFKOMAFHDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class JAHAPODLGJA<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::JAHAPODLGJA<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	protected M LHLENEDHGIN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public abstract BLDR NCDPIPCKGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1F29580", Offset = "0x1F28580", VA = "0x181F29580")]
	public JAHAPODLGJA(M LHLENEDHGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1F2B1E0", Offset = "0x1F2A1E0", VA = "0x181F2B1E0")]
	public BLDR EPAMOGJNDCD(AmplitudeAnalyticsIdentifyMessage.DeviceInfo DLILGPFJCFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1F2B210", Offset = "0x1F2A210", VA = "0x181F2B210")]
	public BLDR FAPENDPEMID(AmplitudeAnalyticsIdentifyMessage.RevenueData EFPLHOPHDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1F2B140", Offset = "0x1F2A140", VA = "0x181F2B140")]
	public BLDR BFMHGECGMPE(string FBECKPLAEGL, string MNEBKBGCGHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x25EC050", Offset = "0x25EB050", VA = "0x1825EC050")]
	public BLDR BFMHGECGMPE<T>(string FBECKPLAEGL, T MNEBKBGCGHD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FDFKOMAFHDL();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1F2B1B0", Offset = "0x1F2A1B0", VA = "0x181F2B1B0")]
	internal static string EFHKDICEKGH(string MNEBKBGCGHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F2B240", Offset = "0x1F2A240", VA = "0x181F2B240")]
	private BLDR PIJPAJPKAJF(string FBECKPLAEGL, object MNEBKBGCGHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M NIAKEBJILGE();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MPGEKEHFPED
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public const int FKLPEMCFPMJ = 2;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public const int OMPOGBGJFJF = 100;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int GKEJCFFNNEH = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public const long GCIKEKJIDGJ = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public const int IIPPINEKFDN = 1024;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int ECJPFHPFHAG = 1000;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public const string ONMKBDLEOIF = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const string AAHFIBDODKE = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public const string FMAOGCIHHKE = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public const string FPLDGLIKIBK = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public const string BGFPOPDLECO = "session_start";

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public const string ONENHFAMPBI = "session_end";

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public const string NFHJMCCIIJG = "session_id";

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public const string AGKJENIOGHL = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public const int HAPDKMHDBIP = 10;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> LCEKDBEGOCG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
	public MPGEKEHFPED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GPJCNFGKHNO
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string DPJGECGPKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string FLKALPGJHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string CBNOIHBGACM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::GBEKKLLKIMD<DMAHJNBJHIO> PHHMCFCAADL(string JMPMCMDKFLG, Dictionary<string, string> JOEEIGLDGNE);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DMAHJNBJHIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly int JHNCMMDGJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly string KBDOGOOKNAN;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x44E990", Offset = "0x44D990", VA = "0x18044E990")]
	public DMAHJNBJHIO(int POKIIJPDECO, string FKBPMEKLCKK)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MPHOBGJJMAN
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static byte[] MDECFDIPDIM;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int KDCNKENIGEG;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int ONHHOGLLEIJ;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static BigInteger FFNLGEIGHMD;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
	public MPHOBGJJMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3CB79D0", Offset = "0x3CB69D0", VA = "0x183CB79D0")]
	private static string MGHDHGHNMMA(byte[] FLPHBPIKJBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3CB76A0", Offset = "0x3CB66A0", VA = "0x183CB76A0")]
	public static string EPCEKCOHIKG(byte[] FGABAFACHHN, bool IKFHCLDOPDI)
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
		[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
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
