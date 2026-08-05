using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AmplitudeAnalytics;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6F10", Offset = "0x5EA5D10", VA = "0x185EA6F10")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B95A0", Offset = "0x7B83A0", VA = "0x1807B95A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AGAmplitudeAnalyticsSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AmplitudeAnalyticsClient.Settings OOCOMDMNGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool DDOFBBPPDKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x78E250", Offset = "0x78D050", VA = "0x18078E250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum DCDAJHPKDOP
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class EACALELJENC
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class OHBPICCDECC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int MCBCOLHOJDA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> KBGKJEPDNOA;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
				public OHBPICCDECC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class NBBEEPFEFFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
				public NBBEEPFEFFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5EA6EA0", Offset = "0x5EA5CA0", VA = "0x185EA6EA0")]
				internal bool OAEFDGAFGON(OHBPICCDECC item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string MGLBAJEDEOJ = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string GANCAKMMLGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<OHBPICCDECC> GHKGICOCLFL;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? BEIPBDLCMFL
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5EA1730", Offset = "0x5EA0530", VA = "0x185EA1730")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5EA25F0", Offset = "0x5EA13F0", VA = "0x185EA25F0")]
			internal EACALELJENC(string AOCKLFDMIBN, string BDKFIFMPKLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5EA1330", Offset = "0x5EA0130", VA = "0x185EA1330")]
			public int ANDCJBHLBPK([Optional] int? KPHDLHONEEJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5EA1BC0", Offset = "0x5EA09C0", VA = "0x185EA1BC0")]
			public List<Dictionary<string, object>> HNCMHENLDAE(int JGJKPIBAHKD, int? KPHDLHONEEJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2200", Offset = "0x5EA1000", VA = "0x185EA2200")]
			public void LNKFKBIKKEJ(AmplitudeAnalyticsIdentifyMessage FGANJEAKCMA, bool CPEDMFGHIJN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5EA22A0", Offset = "0x5EA10A0", VA = "0x185EA22A0")]
			public void LNKFKBIKKEJ(Dictionary<string, object> FGANJEAKCMA, bool CPEDMFGHIJN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2070", Offset = "0x5EA0E70", VA = "0x185EA2070")]
			public void LKGIMLCDEOG(params Dictionary<string, object>[] ADPPHJFFBEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5EA14E0", Offset = "0x5EA02E0", VA = "0x185EA14E0")]
			public void BMJDIKAJBND(List<Dictionary<string, object>> HEOCHMAENIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5EA24E0", Offset = "0x5EA12E0", VA = "0x185EA24E0")]
			private void PNEPGPKKJBA(Dictionary<string, object> FGANJEAKCMA, bool CPEDMFGHIJN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5EA1E30", Offset = "0x5EA0C30", VA = "0x185EA1E30")]
			public void KBNEOLLHBJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5EA17D0", Offset = "0x5EA05D0", VA = "0x185EA17D0")]
			private void FINIDBPCGEB([Optional] string NKNOALGKBID)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5EA23B0", Offset = "0x5EA11B0", VA = "0x185EA23B0")]
			private static string NPHFKFAMIBG(string MBDKMNBCLGF, string IDGIKKEFDCG)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5EA7E70", Offset = "0x5EA6C70", VA = "0x185EA7E70")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct OKHGGKLDEPM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int DFIFBPPLNHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string DIKMEDBNKMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T AJNJIFFKDJL;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LFKNGEFHDAB : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private EFMJLGFKALI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
			[DebuggerHidden]
			public LFKNGEFHDAB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5EA5D60", Offset = "0x5EA4B60", VA = "0x185EA5D60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5EA6520", Offset = "0x5EA5320", VA = "0x185EA6520", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class PGNLOEHPFJC : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public EEELEBFPAJE quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
			[DebuggerHidden]
			public PGNLOEHPFJC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5EA79A0", Offset = "0x5EA67A0", VA = "0x185EA79A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5EA7AB0", Offset = "0x5EA68B0", VA = "0x185EA7AB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MEHNMJLBEAP : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
			[DebuggerHidden]
			public MEHNMJLBEAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5EA6CE0", Offset = "0x5EA5AE0", VA = "0x185EA6CE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5EA6E50", Offset = "0x5EA5C50", VA = "0x185EA6E50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class KEKLELCBBMO : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private EFMJLGFKALI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
			[DebuggerHidden]
			public KEKLELCBBMO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5EA58E0", Offset = "0x5EA46E0", VA = "0x185EA58E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5EA5B60", Offset = "0x5EA4960", VA = "0x185EA5B60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class AFBHGKMGHAD : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private EFMJLGFKALI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
			[DebuggerHidden]
			public AFBHGKMGHAD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5E97AA0", Offset = "0x5E968A0", VA = "0x185E97AA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5E97D30", Offset = "0x5E96B30", VA = "0x185E97D30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class LKPLMEENEIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public EACALELJENC cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public LKPLMEENEIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5EA6570", Offset = "0x5EA5370", VA = "0x185EA6570")]
			internal void DOAMCNBHBCO(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5EA6890", Offset = "0x5EA5690", VA = "0x185EA6890")]
			internal void PKIOCHDELGJ(OKHGGKLDEPM<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class CMIBCJEKKNI : IEnumerator<EFMJLGFKALI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private EFMJLGFKALI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public EACALELJENC cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private LKPLMEENEIM <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private EFMJLGFKALI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
			[DebuggerHidden]
			public CMIBCJEKKNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5EA0080", Offset = "0x5E9EE80", VA = "0x185EA0080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5EA08D0", Offset = "0x5E9F6D0", VA = "0x185EA08D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class EENJFOJOMCM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public EENJFOJOMCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x32429F0", Offset = "0x32417F0", VA = "0x1832429F0")]
			internal OKHGGKLDEPM<T> EGPFMPJOANC(NCLDBGEPCHP postResponse)
			{
				return default(OKHGGKLDEPM<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class NFMFCOCBECE<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public NFMFCOCBECE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x32429F0", Offset = "0x32417F0", VA = "0x1832429F0")]
			internal OKHGGKLDEPM<T> MFLBFAADCEP(NCLDBGEPCHP postResponse)
			{
				return default(OKHGGKLDEPM<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private CCHKCHPJADF LJJKGKPGPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<FJJIGNMENBP> BLLKACFBLDD;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string GCMLFFOBBDN = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string EMFOJDOPMHI = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string FPMOANBMLBB = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int ADLPEFFHLLO = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int GHBFEEGPJLA = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int LDCFAHIDKGP = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float JMKIEFIELLL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long AHNNHKIFNFC = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string CGBKHGEGEFI = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string PJIKJJLPOCG = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool ONJJMDHBHJM;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool AEJLMIOMMGK;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int NGHINOKLLJC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int CBIGGCFCFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private LBDGOLABAJC MOFDPPBNJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private PIKKIFCCDKM JJCIDAHEBIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private KAEPKEJHNCA PHPBBMOBABP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool KHIINBMIGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float PBJDPPAGHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float CCEELJEPLFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int OADLHMKJHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int HADKAIOINEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? KMFJDDHLEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? ENPFIDAAIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long DEKKGAGNKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string MIIILNGNBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool PIIMHJAPJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long NMPEDGCHIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string LMONBIJKCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string PHALJABDDEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> HCHMMPFEEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DCDAJHPKDOP NJBDMLLMHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int HFEJDKCOEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int FEJBJPOEOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float ONIFDBCCBHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool LOIFKMHIOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool LHBLPADONAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private EACALELJENC EKNEDHHDMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private EACALELJENC LOLMOEAMEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private EACALELJENC FGKFMKIOIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> ENKBLHDIKPL;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo JMKDEEMDAOL;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string KIFFJBGEEDM;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string LEKJFADMHMB = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string AIGCPMLHAOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string MGIKGIIIBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string EJONDMEIBNF;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private CCHKCHPJADF CHLKNNIBIOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5E9C5F0", Offset = "0x5E9B3F0", VA = "0x185E9C5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private FJJIGNMENBP BBAKBKBADLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5E9BE10", Offset = "0x5E9AC10", VA = "0x185E9BE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int OHGJBGMNEFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5E9C7B0", Offset = "0x5E9B5B0", VA = "0x185E9C7B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long BDHIHHLAPIA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E3C0", Offset = "0x5E9D1C0", VA = "0x185E9E3C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E4E0", Offset = "0x5E9D2E0", VA = "0x185E9E4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string KLAAOADEBKI
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E360", Offset = "0x5E9D160", VA = "0x185E9E360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string AOKJOCLPCMI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E390", Offset = "0x5E9D190", VA = "0x185E9E390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PNDIPNHDJLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x861EF0", Offset = "0x860CF0", VA = "0x180861EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x861F10", Offset = "0x860D10", VA = "0x180861F10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? OHNDODMPNPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x995C20", Offset = "0x994A20", VA = "0x180995C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E4D0", Offset = "0x5E9D2D0", VA = "0x185E9E4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OFBJAHAHDOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF13430", Offset = "0xF12230", VA = "0x180F13430")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xF132D0", Offset = "0xF120D0", VA = "0x180F132D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool PHBOKNCDMGK
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E260", Offset = "0x5E9D060", VA = "0x185E9E260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> IPPGNDPGHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E1A0", Offset = "0x5E9CFA0", VA = "0x185E9E1A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E410", Offset = "0x5E9D210", VA = "0x185E9E410")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E98AA0", Offset = "0x5E978A0", VA = "0x185E98AA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E99DC0", Offset = "0x5E98BC0", VA = "0x185E99DC0")]
		private void GPAGMKALOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D780", Offset = "0x5E9C580", VA = "0x185E9D780")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C6F0", Offset = "0x5E9B4F0", VA = "0x185E9C6F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DB20", Offset = "0x5E9C920", VA = "0x185E9DB20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CA20", Offset = "0x5E9B820", VA = "0x185E9CA20")]
		public PCFNKHPOHAG PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B8B0", Offset = "0x5E9A6B0", VA = "0x185E9B8B0")]
		[IteratorStateMachine(typeof(LFKNGEFHDAB))]
		public IEnumerator<EFMJLGFKALI> Initialize(AmplitudeAnalyticsEvent ICALMAAFDKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DA60", Offset = "0x5E9C860", VA = "0x185E9DA60")]
		public void UpdateLastKnownInteractionCategory(string DBIIIDAOEDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D970", Offset = "0x5E9C770", VA = "0x185E9D970")]
		public void UpdateLastAliveTime(float BLFDEPDEIPK = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B940", Offset = "0x5E9A740", VA = "0x185E9B940")]
		private PCFNKHPOHAG JMHIPBOFPBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E99390", Offset = "0x5E98190", VA = "0x185E99390")]
		private PCFNKHPOHAG DMINAAKHEFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D1D0", Offset = "0x5E9BFD0", VA = "0x185E9D1D0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B030", Offset = "0x5E99E30", VA = "0x185E9B030")]
		[IteratorStateMachine(typeof(PGNLOEHPFJC))]
		private IEnumerator HDOBGEFMFGD(EEELEBFPAJE FDBDLPEJDLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DDB0", Offset = "0x5E9CBB0", VA = "0x185E9DDB0")]
		[IteratorStateMachine(typeof(MEHNMJLBEAP))]
		public IEnumerator WaitForFlush(float OLPCEOCMHGC = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D850", Offset = "0x5E9C650", VA = "0x185E9D850")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D790", Offset = "0x5E9C590", VA = "0x185E9D790")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime HKAMOIHPHHI)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B420", Offset = "0x5E9A220", VA = "0x185E9B420")]
		public static OHLIBKFFCEJ Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5E98930", Offset = "0x5E97730", VA = "0x185E98930")]
		public static DKCIDCAAMKO AccountSelectionPostLoginEvent([NotNull] string FFPJEEBJPAI, string BIBKCOFJIKA, bool FKJENIPOCOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E99680", Offset = "0x5E98480", VA = "0x185E99680")]
		public static DKCIDCAAMKO Event([NotNull] string FFPJEEBJPAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CA60", Offset = "0x5E9B860", VA = "0x185E9CA60")]
		public static DKCIDCAAMKO PreviousSessionEvent([NotNull] string FFPJEEBJPAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B5D0", Offset = "0x5E9A3D0", VA = "0x185E9B5D0")]
		public static DKCIDCAAMKO InitializeEvent(string BIBKCOFJIKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D390", Offset = "0x5E9C190", VA = "0x185E9D390")]
		public static DKCIDCAAMKO StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5E99130", Offset = "0x5E97F30", VA = "0x185E99130")]
		public static DKCIDCAAMKO CreateOutOfSessionEvent(string FFPJEEBJPAI, bool FCBFECNOCBN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C0E0", Offset = "0x5E9AEE0", VA = "0x185E9C0E0")]
		public static PCFNKHPOHAG LogOutOfSessionEvent(DKCIDCAAMKO FPAHDPINMHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BE60", Offset = "0x5E9AC60", VA = "0x185E9BE60")]
		public void LogEventAsync(AmplitudeAnalyticsEvent HMHCEGEAEBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C3D0", Offset = "0x5E9B1D0", VA = "0x185E9C3D0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent HMHCEGEAEBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C510", Offset = "0x5E9B310", VA = "0x185E9C510")]
		public void LogSerializedEventAsync(Dictionary<string, object> DJBBKLBBFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BFA0", Offset = "0x5E9ADA0", VA = "0x185E9BFA0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage JDCEOBPMNEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5E99CC0", Offset = "0x5E98AC0", VA = "0x185E99CC0")]
		private void GNBBDHOFKJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E99A10", Offset = "0x5E98810", VA = "0x185E99A10")]
		private void GGLEFICODLO(Dictionary<string, object> BCOBPLINNLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B330", Offset = "0x5E9A130", VA = "0x185E9B330")]
		private void IPJDLHAHGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E98F60", Offset = "0x5E97D60", VA = "0x185E98F60")]
		private void CPEKMAPDDLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E99980", Offset = "0x5E98780", VA = "0x185E99980")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C990", Offset = "0x5E9B790", VA = "0x185E9C990")]
		[IteratorStateMachine(typeof(KEKLELCBBMO))]
		private IEnumerator<EFMJLGFKALI> PLAINBPGOHB(float OLPCEOCMHGC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C660", Offset = "0x5E9B460", VA = "0x185E9C660")]
		[IteratorStateMachine(typeof(AFBHGKMGHAD))]
		private IEnumerator<EFMJLGFKALI> NFCBEINEPAN(float OLPCEOCMHGC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5E98820", Offset = "0x5E97620", VA = "0x185E98820")]
		[IteratorStateMachine(typeof(CMIBCJEKKNI))]
		private IEnumerator<EFMJLGFKALI> AJAJECGKOPF(EACALELJENC NKBOFPLFCIM, int? KPHDLHONEEJ, string IOIMDFHFCKC, string EHEIKJNBHFN, float OLPCEOCMHGC, Action<int> ENOKELOOLJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B220", Offset = "0x5E9A020", VA = "0x185E9B220")]
		private static void IMHOHFAMMCL(bool PEKIFKMGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BCE0", Offset = "0x5E9AAE0", VA = "0x185E9BCE0")]
		private FJJBNKADFNG<OKHGGKLDEPM<Dictionary<string, object>>> JOLHLBONDHJ(string IOIMDFHFCKC, string EHEIKJNBHFN, string LMLGHBDCHAN, string IDFOKKBFMGL, Dictionary<string, object> AJNJIFFKDJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BA00", Offset = "0x5E9A800", VA = "0x185E9BA00")]
		private FJJBNKADFNG<OKHGGKLDEPM<List<Dictionary<string, object>>>> JOLHLBONDHJ(string IOIMDFHFCKC, string EHEIKJNBHFN, string LMLGHBDCHAN, string IDFOKKBFMGL, List<Dictionary<string, object>> AJNJIFFKDJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2C52910", Offset = "0x2C51710", VA = "0x182C52910")]
		private FJJBNKADFNG<OKHGGKLDEPM<T>> EGPJLHMCKJK<T>(string IOIMDFHFCKC, string EHEIKJNBHFN, string IDFOKKBFMGL, T AJNJIFFKDJL, Dictionary<string, object> DKNFHBOPCKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2C52BD0", Offset = "0x2C519D0", VA = "0x182C52BD0")]
		private FJJBNKADFNG<OKHGGKLDEPM<T>> MJKFHNNDAGN<T>(string IOIMDFHFCKC, string EHEIKJNBHFN, string LMLGHBDCHAN, T AJNJIFFKDJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5E98F10", Offset = "0x5E97D10", VA = "0x185E98F10")]
		private bool COGOHGMMGPM(float LFFDKFDIBNB, float OLPCEOCMHGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A360", Offset = "0x5E99160", VA = "0x185E9A360")]
		private Dictionary<string, object> HDNDMIENNEA(string EHEIKJNBHFN, Dictionary<string, object> AJNJIFFKDJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DEA0", Offset = "0x5E9CCA0", VA = "0x185E9DEA0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B0C0", Offset = "0x5E99EC0", VA = "0x185E9B0C0")]
		[CompilerGenerated]
		private long HIIMJDAPCJB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E98920", Offset = "0x5E97720", VA = "0x185E98920")]
		[CompilerGenerated]
		private void AONNGFLIDBE(int KPDMBGGKEFK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly bool isBrazeUser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5E9F240", Offset = "0x5E9E040", VA = "0x185E9F240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5E9F320", Offset = "0x5E9E120", VA = "0x185E9F320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5E9F280", Offset = "0x5E9E080", VA = "0x185E9F280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5E9F380", Offset = "0x5E9E180", VA = "0x185E9F380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5E9F200", Offset = "0x5E9E000", VA = "0x185E9F200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5E9F2C0", Offset = "0x5E9E0C0", VA = "0x185E9F2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x78E0C0", Offset = "0x78CEC0", VA = "0x18078E0C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E7B0", Offset = "0x5E9D5B0", VA = "0x185E9E7B0")]
		public static DKCIDCAAMKO KCGHAKHJLMB(string ECDEHLGBDJN, [NotNull] string LGOPJOBKNHL, long KOMJBDMNNDA, long OKBGCLFFMMD, string BIBKCOFJIKA, bool FKJENIPOCOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E540", Offset = "0x5E9D340", VA = "0x185E9E540")]
		public static DKCIDCAAMKO BICPDHPDBMH(string ECDEHLGBDJN, [NotNull] string LGOPJOBKNHL, long KOMJBDMNNDA, long OKBGCLFFMMD, string BIBKCOFJIKA, long DGLFJGDFCFB, bool FKJENIPOCOG, string BPJBLHJBKGI, string EIPPPAPNNPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F070", Offset = "0x5E9DE70", VA = "0x185E9F070")]
		private AmplitudeAnalyticsEvent(string ECDEHLGBDJN, [NotNull] string LGOPJOBKNHL, long KOMJBDMNNDA, long OKBGCLFFMMD, string BIBKCOFJIKA, bool FKJENIPOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x199D620", Offset = "0x199C420", VA = "0x18199D620")]
		public void KPPLDCJCCMD(long ABOPNEMJBHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EF60", Offset = "0x5E9DD60", VA = "0x185E9EF60", Slot = "5")]
		public override void NDOCGMKCFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EDE0", Offset = "0x5E9DBE0", VA = "0x185E9EDE0", Slot = "6")]
		public override void NDKIDOBHPKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E8B0", Offset = "0x5E9D6B0", VA = "0x185E9E8B0", Slot = "4")]
		protected override Dictionary<string, object> LCLAPEJAHBA(Dictionary<string, object> FMLOHGLOJHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E6A0", Offset = "0x5E9D4A0", VA = "0x185E9E6A0")]
		private void IPMBEHPONGO(string IDGIKKEFDCG, string MBDKMNBCLGF, bool LALENIAMCGM = false)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5EA11B0", Offset = "0x5E9FFB0", VA = "0x185EA11B0")]
			public void PPBJHANDDBK(Dictionary<string, object> GKOANPLFIKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5EA7B00", Offset = "0x5EA6900", VA = "0x185EA7B00")]
			public void PPBJHANDDBK(Dictionary<string, object> AKECHCFAOOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A0140", Offset = "0x89EF40", VA = "0x1808A0140")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x78E1A0", Offset = "0x78CFA0", VA = "0x18078E1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F580", Offset = "0x5E9E380", VA = "0x185E9F580")]
		public static OHLIBKFFCEJ KCGHAKHJLMB(string ECDEHLGBDJN, string BIBKCOFJIKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FAA0", Offset = "0x5E9E8A0", VA = "0x185E9FAA0")]
		protected AmplitudeAnalyticsIdentifyMessage(string ECDEHLGBDJN, string BIBKCOFJIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F3E0", Offset = "0x5E9E1E0", VA = "0x185E9F3E0")]
		public Dictionary<string, object> ANCGNEEAEMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F640", Offset = "0x5E9E440", VA = "0x185E9F640", Slot = "4")]
		protected virtual Dictionary<string, object> LCLAPEJAHBA(Dictionary<string, object> FMLOHGLOJHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F470", Offset = "0x5E9E270", VA = "0x185E9F470")]
		protected void BBBAKHCOHNN(string IDGIKKEFDCG, Dictionary<string, object> PCPLKPIICFL, Dictionary<string, object> HNFAGJHFAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F510", Offset = "0x5E9E310", VA = "0x185E9F510")]
		protected void ICHHBOPMBOH(string IDGIKKEFDCG, string MBDKMNBCLGF, Dictionary<string, object> NDIHIMNBEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FA10", Offset = "0x5E9E810", VA = "0x185E9FA10", Slot = "5")]
		public virtual void NDOCGMKCFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F980", Offset = "0x5E9E780", VA = "0x185E9F980", Slot = "6")]
		public virtual void NDKIDOBHPKF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OHLIBKFFCEJ : CNMCPJDHNGL<AmplitudeAnalyticsIdentifyMessage, OHLIBKFFCEJ>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override OHLIBKFFCEJ OLEFKAFBEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage FILGDACFIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7040", Offset = "0x5EA5E40", VA = "0x185EA7040")]
	public OHLIBKFFCEJ(AmplitudeAnalyticsIdentifyMessage EKPMNNKLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6F90", Offset = "0x5EA5D90", VA = "0x185EA6F90", Slot = "4")]
	public override void NDKIDOBHPKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DKCIDCAAMKO : CNMCPJDHNGL<AmplitudeAnalyticsEvent, DKCIDCAAMKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool KOBGECJPGBC;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override DKCIDCAAMKO OLEFKAFBEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long LOJCEOADKPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E626F0", Offset = "0x1E614F0", VA = "0x181E626F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1160", Offset = "0x5E9FF60", VA = "0x185EA1160")]
	public DKCIDCAAMKO(AmplitudeAnalyticsEvent EKPMNNKLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290", Slot = "5")]
	public override AmplitudeAnalyticsEvent FILGDACFIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5EA10C0", Offset = "0x5E9FEC0", VA = "0x185EA10C0", Slot = "4")]
	public override void NDKIDOBHPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x24720D0", Offset = "0x2470ED0", VA = "0x1824720D0")]
	public DKCIDCAAMKO MPPINLJEFMH<T>(string LEDLMNEPNJE, T[] MBDKMNBCLGF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x24720D0", Offset = "0x2470ED0", VA = "0x1824720D0")]
	public DKCIDCAAMKO MPPINLJEFMH(string LEDLMNEPNJE, string[] MBDKMNBCLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2471E20", Offset = "0x2470C20", VA = "0x182471E20")]
	public DKCIDCAAMKO MPPINLJEFMH<T>(string LEDLMNEPNJE, T MBDKMNBCLGF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1040", Offset = "0x5E9FE40", VA = "0x185EA1040")]
	public DKCIDCAAMKO MPPINLJEFMH(string LEDLMNEPNJE, long MBDKMNBCLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0FD0", Offset = "0x5E9FDD0", VA = "0x185EA0FD0")]
	public DKCIDCAAMKO MPPINLJEFMH(string LEDLMNEPNJE, string MBDKMNBCLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0E00", Offset = "0x5E9FC00", VA = "0x185EA0E00")]
	public DKCIDCAAMKO AFKBLDGEHFN(string LEDLMNEPNJE, object? MBDKMNBCLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0F30", Offset = "0x5E9FD30", VA = "0x185EA0F30")]
	public DKCIDCAAMKO JFIHBLBMGKH(string LEDLMNEPNJE, string MBDKMNBCLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0E30", Offset = "0x5E9FC30", VA = "0x185EA0E30")]
	private DKCIDCAAMKO FGGPDFKOJLC(string LEDLMNEPNJE, object MBDKMNBCLGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IAHKHPOJHNF : DKCIDCAAMKO
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1160", Offset = "0x5E9FF60", VA = "0x185EA1160")]
	public IAHKHPOJHNF(AmplitudeAnalyticsEvent EKPMNNKLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5730", Offset = "0x5EA4530", VA = "0x185EA5730", Slot = "4")]
	public override void NDKIDOBHPKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class CNMCPJDHNGL<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : CNMCPJDHNGL<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M EKPMNNKLPFJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR OLEFKAFBEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
	public CNMCPJDHNGL(M EKPMNNKLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7590", Offset = "0x4BA6390", VA = "0x184BA7590")]
	public BLDR ALNJOAIPGAI(AmplitudeAnalyticsIdentifyMessage.DeviceInfo OGLFKOHCMNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7540", Offset = "0x4BA6340", VA = "0x184BA7540")]
	public BLDR AEKNJFBJGBP(AmplitudeAnalyticsIdentifyMessage.RevenueData AAOHENMENNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7710", Offset = "0x4BA6510", VA = "0x184BA7710")]
	public BLDR PCPBJPOHOPK(string LEDLMNEPNJE, string MBDKMNBCLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2F06530", Offset = "0x2F05330", VA = "0x182F06530")]
	public BLDR PCPBJPOHOPK<T>(string LEDLMNEPNJE, T MBDKMNBCLGF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NDKIDOBHPKF();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4BA75E0", Offset = "0x4BA63E0", VA = "0x184BA75E0")]
	internal static string GEEHKHCOHGF(string MBDKMNBCLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4BA7610", Offset = "0x4BA6410", VA = "0x184BA7610")]
	private BLDR JLPBPLNHCPO(string LEDLMNEPNJE, object MBDKMNBCLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M FILGDACFIHL();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class HNBAABFLGNN : LBDGOLABAJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct OPJFMEFMHJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<NCLDBGEPCHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public HNBAABFLGNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private FormUrlEncodedContent <requestBody>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private HttpResponseMessage <httpResponse>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7090", Offset = "0x5EA5E90", VA = "0x185EA7090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7930", Offset = "0x5EA6730", VA = "0x185EA7930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct APIHKIMAIGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<NCLDBGEPCHP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public HNBAABFLGNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private StringContent <requestBody>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private HttpRequestMessage <request>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private HttpResponseMessage <httpResponse>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E97D80", Offset = "0x5E96B80", VA = "0x185E97D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E987B0", Offset = "0x5E975B0", VA = "0x185E987B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient PJPJMDFMPGE;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5EA54D0", Offset = "0x5EA42D0", VA = "0x185EA54D0")]
	[OKINHFAHPEJ(FNGNILODNLI.None)]
	private static void KDGFFLAKGCO(LPFNGCMIAEC KDNLDLIFDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5EA56B0", Offset = "0x5EA44B0", VA = "0x185EA56B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HNBAABFLGNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5380", Offset = "0x5EA4180", VA = "0x185EA5380", Slot = "4")]
	[AsyncStateMachine(typeof(OPJFMEFMHJH))]
	public Task<NCLDBGEPCHP> JOLHLBONDHJ(string IOIMDFHFCKC, Dictionary<string, string> AAGMCICHFIH, bool EMJKILMLKHK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5540", Offset = "0x5EA4340", VA = "0x185EA5540", Slot = "5")]
	[AsyncStateMachine(typeof(APIHKIMAIGE))]
	public Task<NCLDBGEPCHP> NEGIONBDHMH(string IOIMDFHFCKC, string LOLBDGAEHMO, string BBHGEAOCDCC, string FNBHLCFICAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KJHEBDFKPGL
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> DGBPGOMDAKH;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5BB0", Offset = "0x5EA49B0", VA = "0x185EA5BB0")]
	internal static bool OKDIHMPMHCL(string IDGIKKEFDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LBDGOLABAJC
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NCLDBGEPCHP> JOLHLBONDHJ(string IOIMDFHFCKC, Dictionary<string, string> AAGMCICHFIH, bool EMJKILMLKHK = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<NCLDBGEPCHP> NEGIONBDHMH(string IOIMDFHFCKC, string LOLBDGAEHMO, string BBHGEAOCDCC, string FNBHLCFICAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct NCLDBGEPCHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int CJPDADFJCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string OJCOKAGDOLC;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xB98AD0", Offset = "0xB978D0", VA = "0x180B98AD0")]
	public NCLDBGEPCHP(int DFIFBPPLNHF, string DIKMEDBNKMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum KEMDIGBDJFL
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	GameInvite,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	RoomChat,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DebugCommand
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class BDIJOIFCHIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long AAHLPAFDPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private DKCIDCAAMKO ALEJMHDHGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool KIOLNNKILOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float JFHLLBNFCBH;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FEF0", Offset = "0x5E9ECF0", VA = "0x185E9FEF0")]
	public BDIJOIFCHIP(string HAIAHACKIKB, float JFHLLBNFCBH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2397660", Offset = "0x2396460", VA = "0x182397660")]
	public void MPPINLJEFMH<T>(string LEDLMNEPNJE, T MBDKMNBCLGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FD60", Offset = "0x5E9EB60", VA = "0x185E9FD60")]
	public void MPPINLJEFMH(string LEDLMNEPNJE, string MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FC70", Offset = "0x5E9EA70", VA = "0x185E9FC70")]
	public void LOKOALPHNDO(string CPOFHFIKHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FB60", Offset = "0x5E9E960", VA = "0x185E9FB60")]
	public void EKAECOMFPCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FDE0", Offset = "0x5E9EBE0", VA = "0x185E9FDE0")]
	private void ODJMFHFAKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FC20", Offset = "0x5E9EA20", VA = "0x185E9FC20")]
	private bool KJDCHLILPEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CEGGMEIFBDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool GFKJDIILPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string PNDIPNHDJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	AIJPNJGGLPL KCPDGFMLMEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JNOLABGDOIM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BJKDPOEBOFN;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PCFNKHPOHAG CGDOOEBPPMG(string COBKGFGMIIO, string BDKFIFMPKLA, [Optional] PIKKIFCCDKM NIOJNJHNOHI);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PCFNKHPOHAG NMDMHPJAFHO(PIKKIFCCDKM NIOJNJHNOHI);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PCFNKHPOHAG CMJHHEPCHAL(PIKKIFCCDKM NIOJNJHNOHI, Dictionary<string, string> JPKEHJMJJKK);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JDMJMDMELHI(string AEOJAJLOOAE);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KEHFJOOEEJK NIMJNPFKJMA(string CIIJIBKNOOF);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LKOGGEGDJHF KDBBOBPAOCK(string KPMBBNPILGJ);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PCFNKHPOHAG PJKFNLCNBOE();
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7C70", Offset = "0x5EA6A70", VA = "0x185EA7C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class EDCLKNDDOEN : CEGGMEIFBDJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly IReadOnlyDictionary<string, GDCNKBLADHE> GKOEOBAFKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool BLMNJHIDLDM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool GFKJDIILPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEC0", Offset = "0x7DECC0", VA = "0x1807DFEC0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string PNDIPNHDJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3D60", Offset = "0x5EA2B60", VA = "0x185EA3D60", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public AIJPNJGGLPL KCPDGFMLMEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3680", Offset = "0x5EA2480", VA = "0x185EA3680", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action JNOLABGDOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3040", Offset = "0x5EA1E40", VA = "0x185EA3040", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2F20", Offset = "0x5EA1D20", VA = "0x185EA2F20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action BJKDPOEBOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5EA30E0", Offset = "0x5EA1EE0", VA = "0x185EA30E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5EA35E0", Offset = "0x5EA23E0", VA = "0x185EA35E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5EA27E0", Offset = "0x5EA15E0", VA = "0x185EA27E0", Slot = "8")]
	public PCFNKHPOHAG CGDOOEBPPMG(string COBKGFGMIIO, string BDKFIFMPKLA, [Optional] PIKKIFCCDKM NIOJNJHNOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4160", Offset = "0x5EA2F60", VA = "0x185EA4160", Slot = "17")]
	public PCFNKHPOHAG PJKFNLCNBOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3F70", Offset = "0x5EA2D70", VA = "0x185EA3F70", Slot = "12")]
	public PCFNKHPOHAG NMDMHPJAFHO(PIKKIFCCDKM NIOJNJHNOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2C50", Offset = "0x5EA1A50", VA = "0x185EA2C50", Slot = "13")]
	public PCFNKHPOHAG CMJHHEPCHAL(PIKKIFCCDKM NIOJNJHNOHI, Dictionary<string, string> JPKEHJMJJKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3180", Offset = "0x5EA1F80", VA = "0x185EA3180", Slot = "14")]
	public bool JDMJMDMELHI(string AEOJAJLOOAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3D70", Offset = "0x5EA2B70", VA = "0x185EA3D70", Slot = "15")]
	public KEHFJOOEEJK NIMJNPFKJMA(string CIIJIBKNOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3550", Offset = "0x5EA2350", VA = "0x185EA3550", Slot = "16")]
	public LKOGGEGDJHF KDBBOBPAOCK(string KPMBBNPILGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3690", Offset = "0x5EA2490", VA = "0x185EA3690")]
	private AIJPNJGGLPL LFBNDOHENJH(PIKKIFCCDKM NIOJNJHNOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5EA33A0", Offset = "0x5EA21A0", VA = "0x185EA33A0")]
	private IJJCMJABGAB JOBMNIHKHDE(string BDKFIFMPKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3210", Offset = "0x5EA2010", VA = "0x185EA3210")]
	private void JLDNIEDPBFF(string CIIJIBKNOOF, KEHFJOOEEJK FAOOIMBGECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public EDCLKNDDOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA97430", Offset = "0xA96230", VA = "0x180A97430")]
	[CompilerGenerated]
	private void FPPBLPFLKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3320", Offset = "0x5EA2120", VA = "0x185EA3320")]
	[CompilerGenerated]
	private void JLHHFEDPHCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2FC0", Offset = "0x5EA1DC0", VA = "0x185EA2FC0")]
	[CompilerGenerated]
	private void DJMAGLIELEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class EHIKHGGEAAK : CEGGMEIFBDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private CEGGMEIFBDJ MONCGPOFOHP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private CEGGMEIFBDJ JCDNCCJHBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4AA0", Offset = "0x5EA38A0", VA = "0x185EA4AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool GFKJDIILPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4DE0", Offset = "0x5EA3BE0", VA = "0x185EA4DE0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string PNDIPNHDJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4F90", Offset = "0x5EA3D90", VA = "0x185EA4F90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public AIJPNJGGLPL KCPDGFMLMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4ED0", Offset = "0x5EA3CD0", VA = "0x185EA4ED0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action JNOLABGDOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4A00", Offset = "0x5EA3800", VA = "0x185EA4A00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4960", Offset = "0x5EA3760", VA = "0x185EA4960", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action BJKDPOEBOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4B10", Offset = "0x5EA3910", VA = "0x185EA4B10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4E30", Offset = "0x5EA3C30", VA = "0x185EA4E30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	[UnityEngine.Scripting.Preserve]
	public EHIKHGGEAAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4C60", Offset = "0x5EA3A60", VA = "0x185EA4C60")]
	[OKINHFAHPEJ(FNGNILODNLI.GameOnly)]
	private static void JLCIFBCNJPA(LPFNGCMIAEC KDNLDLIFDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5200", Offset = "0x5EA4000", VA = "0x185EA5200")]
	[OKINHFAHPEJ(FNGNILODNLI.EditorOnly)]
	private static void PJBFPDJFICN(LPFNGCMIAEC KDNLDLIFDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5EA43F0", Offset = "0x5EA31F0", VA = "0x185EA43F0", Slot = "8")]
	public PCFNKHPOHAG CGDOOEBPPMG(string COBKGFGMIIO, string BDKFIFMPKLA, [Optional] PIKKIFCCDKM NIOJNJHNOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5EA50F0", Offset = "0x5EA3EF0", VA = "0x185EA50F0", Slot = "12")]
	public PCFNKHPOHAG NMDMHPJAFHO(PIKKIFCCDKM NIOJNJHNOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4840", Offset = "0x5EA3640", VA = "0x185EA4840", Slot = "13")]
	public PCFNKHPOHAG CMJHHEPCHAL(PIKKIFCCDKM NIOJNJHNOHI, Dictionary<string, string> JPKEHJMJJKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4BB0", Offset = "0x5EA39B0", VA = "0x185EA4BB0", Slot = "14")]
	public bool JDMJMDMELHI(string AEOJAJLOOAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4FE0", Offset = "0x5EA3DE0", VA = "0x185EA4FE0", Slot = "15")]
	public KEHFJOOEEJK NIMJNPFKJMA(string CIIJIBKNOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4CD0", Offset = "0x5EA3AD0", VA = "0x185EA4CD0", Slot = "16")]
	public LKOGGEGDJHF KDBBOBPAOCK(string KPMBBNPILGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5270", Offset = "0x5EA4070", VA = "0x185EA5270", Slot = "17")]
	public PCFNKHPOHAG PJKFNLCNBOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7D94E0", Offset = "0x7D82E0", VA = "0x1807D94E0")]
	[CompilerGenerated]
	private void BJBFKHOCHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xB98780", Offset = "0xB97580", VA = "0x180B98780")]
	[CompilerGenerated]
	private void BLEHKNOIDBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class DBPEJCHDLBE : CEGGMEIFBDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GFKJDIILPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7A9270", Offset = "0x7A8070", VA = "0x1807A9270", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string PNDIPNHDJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public AIJPNJGGLPL KCPDGFMLMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action JNOLABGDOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0AE0", Offset = "0x5E9F8E0", VA = "0x185EA0AE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0A40", Offset = "0x5E9F840", VA = "0x185EA0A40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action BJKDPOEBOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0B80", Offset = "0x5E9F980", VA = "0x185EA0B80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0C30", Offset = "0x5E9FA30", VA = "0x185EA0C30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DBPEJCHDLBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0920", Offset = "0x5E9F720", VA = "0x185EA0920", Slot = "8")]
	public PCFNKHPOHAG CGDOOEBPPMG(string COBKGFGMIIO, string BDKFIFMPKLA, [Optional] PIKKIFCCDKM NIOJNJHNOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0CE0", Offset = "0x5E9FAE0", VA = "0x185EA0CE0", Slot = "12")]
	public PCFNKHPOHAG NMDMHPJAFHO(PIKKIFCCDKM NIOJNJHNOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5EA09B0", Offset = "0x5E9F7B0", VA = "0x185EA09B0", Slot = "13")]
	public PCFNKHPOHAG CMJHHEPCHAL(PIKKIFCCDKM NIOJNJHNOHI, Dictionary<string, string> JPKEHJMJJKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "14")]
	public bool JDMJMDMELHI(string AEOJAJLOOAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0CD0", Offset = "0x5E9FAD0", VA = "0x185EA0CD0", Slot = "15")]
	public KEHFJOOEEJK NIMJNPFKJMA(string CIIJIBKNOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0C20", Offset = "0x5E9FA20", VA = "0x185EA0C20", Slot = "16")]
	public LKOGGEGDJHF KDBBOBPAOCK(string KPMBBNPILGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0D70", Offset = "0x5E9FB70", VA = "0x185EA0D70", Slot = "17")]
	public PCFNKHPOHAG PJKFNLCNBOE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface DCNPHOEBCEI
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BDIJOIFCHIP HHCPPCGKEPC(string HAIAHACKIKB);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KAEPKEJHNCA
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum AOHGABJOHAH
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	long LADEAPHDHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string NGBELKEHLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string KCAEMKPHDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string AJJHMKOJMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string PGMDGPOLDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool MGNAIKIEFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long DHGHJLNNGMC();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NGAOFHJFPJN(long KOMJBDMNNDA, bool LALENIAMCGM = true);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EEHIPGCLJOB(string BCCEHJNGNAL, string JANPDFNBGKD, string OOPBPPCLJMB);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CBAIEIGKLIP(string BCCEHJNGNAL);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OMGBBCIJMKH(string BCCEHJNGNAL, string KPPFBEIBKBG, string FJIEOKKLCEB);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PMJNFHGCGFK(string BGOCNLJJBDL, object KBAIDANBIOO, object IFPNLLMNNNK);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KKJOIEKLDNO(AOHGABJOHAH BPNLAMPHCEH, int KGANJEKILMM, [Optional] EOBPKIFHCLG KKMFFGHDGLO, [Optional] string GOJILPBLGJG, [Optional] string NGPMDAJFCLG);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DHLAADBGKDF(EOBPKIFHCLG KKMFFGHDGLO, long NNPINHBNMPC, long FCPCDBKFOPK, int FGMNIPCGDAF, string GOJILPBLGJG, int KGANJEKILMM);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GHJLIEGGFBG(EOBPKIFHCLG KKMFFGHDGLO, bool BAENCCECFMB, [Optional] string NGPMDAJFCLG);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JJGFJHBECNO(EOBPKIFHCLG KKMFFGHDGLO, bool BAENCCECFMB, [Optional] string NGPMDAJFCLG);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MCHJHGLHCOI(EOBPKIFHCLG KKMFFGHDGLO, bool BAENCCECFMB, [Optional] string NGPMDAJFCLG);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface PIKKIFCCDKM
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool GPJLOLNMPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool DFMOGBOLOLO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool NINLFEEHKLA
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool? FJNKNJIBJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	int? OHNDODMPNPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	int MBNIIJAGJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string GIHBLBPHBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string JNADBAOEMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string GHCINIBJKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	long OCOHBMOKOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string OIPCINMGAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string HAIGOLJHFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string FLMJJPOPFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string JACMGAAHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	double NABACAPGAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int KKNABLLKBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
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
