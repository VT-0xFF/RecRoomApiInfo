using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AmplitudeAnalytics;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using UnityEngine;
using UnityEngine.Networking;
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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3140", Offset = "0x6AD2340", VA = "0x186AD3140")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5AC0", Offset = "0x6AD4CC0", VA = "0x186AD5AC0", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
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
		public AmplitudeAnalyticsClient.Settings EMJFDOHHLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HNPIMADFOEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8944D0", Offset = "0x8936D0", VA = "0x1808944D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private enum MJEGEBKOBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal class ELLJJHOPECO
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class IBBAKCDKHJM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				public int BAOIAOKEPCM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public Dictionary<string, object> HEMJHBFHMCI;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
				public IBBAKCDKHJM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class BFMEBCJIMNP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
				public BFMEBCJIMNP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x6ACB260", Offset = "0x6ACA460", VA = "0x186ACB260")]
				internal bool IOJGPBMMBJP(IBBAKCDKHJM item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private const string IOHJLMOGDKM = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly string PBNPILECCPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private List<IBBAKCDKHJM> LPBLKPONHAE;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public int? COPFHFCGFFK
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6ACD640", Offset = "0x6ACC840", VA = "0x186ACD640")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6ACE190", Offset = "0x6ACD390", VA = "0x186ACE190")]
			internal ELLJJHOPECO(string DDAMIDBBNEI, string GFNENCIDJCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6ACD6E0", Offset = "0x6ACC8E0", VA = "0x186ACD6E0")]
			public int ELHJDKKCLIM([Optional] int? MLNJEAAGGLM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6ACDA10", Offset = "0x6ACCC10", VA = "0x186ACDA10")]
			public List<Dictionary<string, object>> IOEJGLMGOJC(int CCEMABFNHHP, int? MLNJEAAGGLM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6ACDDA0", Offset = "0x6ACCFA0", VA = "0x186ACDDA0")]
			public void KHFLMDCPECB(AmplitudeAnalyticsIdentifyMessage JMJAOKJJFGJ, bool NNLGCNHBAKF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6ACDE40", Offset = "0x6ACD040", VA = "0x186ACDE40")]
			public void KHFLMDCPECB(Dictionary<string, object> JMJAOKJJFGJ, bool NNLGCNHBAKF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6ACD890", Offset = "0x6ACCA90", VA = "0x186ACD890")]
			public void GNBBLFIOJDO(params Dictionary<string, object>[] EDPNLAFFEKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6ACDF50", Offset = "0x6ACD150", VA = "0x186ACDF50")]
			public void MHPPCDHAEKE(List<Dictionary<string, object>> KDJFGIJCDCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6ACD340", Offset = "0x6ACC540", VA = "0x186ACD340")]
			private void CCILPNDIKKD(Dictionary<string, object> JMJAOKJJFGJ, bool NNLGCNHBAKF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6ACD440", Offset = "0x6ACC640", VA = "0x186ACD440")]
			public void EDPHNDJJBBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6ACCF40", Offset = "0x6ACC140", VA = "0x186ACCF40")]
			private void AEFJOIIEIND([Optional] string LBJEKBNJPON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6ACDC80", Offset = "0x6ACCE80", VA = "0x186ACDC80")]
			private static string JNGAEPMONOB(string JECHHBGMFLN, string CPBLLDDDHEE)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6AD56E0", Offset = "0x6AD48E0", VA = "0x186AD56E0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct OLOIACLCIAK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public int OEGBCGDKDOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public string IHFHGAFJENN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T LEENMGJBOLI;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class FJCGLLOHOKD : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private CKLDDHMAHNL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
			[DebuggerHidden]
			public FJCGLLOHOKD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6ACECE0", Offset = "0x6ACDEE0", VA = "0x186ACECE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF450", Offset = "0x6ACE650", VA = "0x186ACF450", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MAEFMEBGFKB : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public KOKEAEPGGEH quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
			[DebuggerHidden]
			public MAEFMEBGFKB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6AD2FE0", Offset = "0x6AD21E0", VA = "0x186AD2FE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6AD30F0", Offset = "0x6AD22F0", VA = "0x186AD30F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class DCBKNCEKPCI : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
			[DebuggerHidden]
			public DCBKNCEKPCI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6ACBA10", Offset = "0x6ACAC10", VA = "0x186ACBA10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6ACBB80", Offset = "0x6ACAD80", VA = "0x186ACBB80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class CKLMLONPJHN : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private CKLDDHMAHNL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
			[DebuggerHidden]
			public CKLMLONPJHN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB760", Offset = "0x6ACA960", VA = "0x186ACB760", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB9C0", Offset = "0x6ACABC0", VA = "0x186ACB9C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class BHCGLOEJAEM : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private CKLDDHMAHNL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
			[DebuggerHidden]
			public BHCGLOEJAEM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB2D0", Offset = "0x6ACA4D0", VA = "0x186ACB2D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB520", Offset = "0x6ACA720", VA = "0x186ACB520", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class OENENKCAEAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public ELLJJHOPECO cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public OENENKCAEAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4560", Offset = "0x6AD3760", VA = "0x186AD4560")]
			internal void PKDNBBPNNML(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4110", Offset = "0x6AD3310", VA = "0x186AD4110")]
			internal void MLNBKDHPACA(OLOIACLCIAK<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class EIJADGFOEOD : IEnumerator<CKLDDHMAHNL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private CKLDDHMAHNL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public ELLJJHOPECO cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private OENENKCAEAD <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private float <startTime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private bool <timedOut>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private int <batchSize>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private CKLDDHMAHNL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
			[DebuggerHidden]
			public EIJADGFOEOD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC6F0", Offset = "0x6ACB8F0", VA = "0x186ACC6F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6ACCEF0", Offset = "0x6ACC0F0", VA = "0x186ACCEF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class LBJECFOAEIG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public LBJECFOAEIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x4530410", Offset = "0x452F610", VA = "0x184530410")]
			internal OLOIACLCIAK<T> EIOBPADEJFN(PNOMACLKAHH postResponse)
			{
				return default(OLOIACLCIAK<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private JFGAINJNGMJ OPFGPIAJHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<PBOBJPLMOIJ> NJPPCKIFAHJ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string HNDLKMDCHHN = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string ECAEABNJLLH = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string NNHBJFJMPNI = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int LDDNABMBEGG = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int BMMHGJNCOMC = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int IDDHDDDDGNH = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float AFNPMBMOMEH = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long AFKDKJKECDG = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string CLECIFINBPG = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string HGMODCKKFPA = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string MIDIOKNMMDP = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string NCKAOJMMKIN = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool PEFIIAENHDN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool PBOJDFOJNMC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int MPIOFNBDGOK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int PNLOFPDCIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PMIBECDCMDP GHCINLABCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private AKADCABGAFE BDMDCPCDAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private NHPNODKLKOI HGMOGMHICAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool MNKIFJDDBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float OAMHHNNMMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float MAICGIKBPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int MCOHOAFEPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int MNFFMCHGLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? NFDAGFJDIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? OFDDCJOICLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long HGFDPIJKENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string HBEHAABJLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string LLDFBLFKGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long DBDBJMPOPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string KFBEDDNIKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string KLIIHMOMOKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> JLOAGLFHOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private MJEGEBKOBEJ IGFABDIBDCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int KIDJFDOPPNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int OADGFNAEFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float EIHIGBPONLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool CNHILCFPKED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool HKCMFFJLDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private ELLJJHOPECO FKNOHNCNNBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private ELLJJHOPECO ELKHIBLLIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private ELLJJHOPECO IOFGAGMJBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string LIDANICBNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> HOHHMDLIMBG;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo MLOJEIEANIC;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static string BCIMGCKOODP;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string HIPBNHLABBH = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly string DNCBDJDFOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string DCCCPFNBOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string BAJBFPKBLFB;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private JFGAINJNGMJ HHFBCAKGGLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6AC4A50", Offset = "0x6AC3C50", VA = "0x186AC4A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private PBOBJPLMOIJ KALFGNDDGGM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6AC6840", Offset = "0x6AC5A40", VA = "0x186AC6840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int NDIOOFPPKFP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6AC47C0", Offset = "0x6AC39C0", VA = "0x186AC47C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long BOLEDCANLEO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6AC86D0", Offset = "0x6AC78D0", VA = "0x186AC86D0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6AC87E0", Offset = "0x6AC79E0", VA = "0x186AC87E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string GLKJIAOBMEM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6AC86A0", Offset = "0x6AC78A0", VA = "0x186AC86A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string CHEKPCIKJOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8E07B0", Offset = "0x8DF9B0", VA = "0x1808E07B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xE473F0", Offset = "0xE465F0", VA = "0x180E473F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int? BGPOEMNEDHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x90B2A0", Offset = "0x90A4A0", VA = "0x18090B2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1B619B0", Offset = "0x1B60BB0", VA = "0x181B619B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KJAFJLIPMDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x923A30", Offset = "0x922C30", VA = "0x180923A30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1427720", Offset = "0x1426920", VA = "0x181427720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool OKJNEDBPIAP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6AC8580", Offset = "0x6AC7780", VA = "0x186AC8580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> JCIKFHGNPLL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6AC84C0", Offset = "0x6AC76C0", VA = "0x186AC84C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6AC8720", Offset = "0x6AC7920", VA = "0x186AC8720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2AA0", Offset = "0x6AC1CA0", VA = "0x186AC2AA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3E80", Offset = "0x6AC3080", VA = "0x186AC3E80")]
		private void HIGOMIMFENH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7B10", Offset = "0x6AC6D10", VA = "0x186AC7B10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6790", Offset = "0x6AC5990", VA = "0x186AC6790", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7E30", Offset = "0x6AC7030", VA = "0x186AC7E30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6890", Offset = "0x6AC5A90", VA = "0x186AC6890")]
		public KAHDNIHNJDF PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4730", Offset = "0x6AC3930", VA = "0x186AC4730")]
		[IteratorStateMachine(typeof(FJCGLLOHOKD))]
		public IEnumerator<CKLDDHMAHNL> InitializeForLocalAccount(AmplitudeAnalyticsEvent BEHNPEKGOEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC71F0", Offset = "0x6AC63F0", VA = "0x186AC71F0")]
		public void SendAppEnterEvent(bool AJAKIOIIPGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7DB0", Offset = "0x6AC6FB0", VA = "0x186AC7DB0")]
		public void UpdateLastKnownInteractionCategory(string COIMCHHKJDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7D00", Offset = "0x6AC6F00", VA = "0x186AC7D00")]
		public void UpdateLastAliveTime(float GCFLAEHGPCH = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6AC39A0", Offset = "0x6AC2BA0", VA = "0x186AC39A0")]
		private KAHDNIHNJDF GHEPMMDNCCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3A50", Offset = "0x6AC2C50", VA = "0x186AC3A50")]
		private KAHDNIHNJDF GKKFDJIJDIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7500", Offset = "0x6AC6700", VA = "0x186AC7500")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6AC49C0", Offset = "0x6AC3BC0", VA = "0x186AC49C0")]
		[IteratorStateMachine(typeof(MAEFMEBGFKB))]
		private IEnumerator KAKAEHABIML(KOKEAEPGGEH GAKOPPNPOAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6AC80C0", Offset = "0x6AC72C0", VA = "0x186AC80C0")]
		[IteratorStateMachine(typeof(DCBKNCEKPCI))]
		public IEnumerator WaitForFlush(float ANKNBCMNEHH = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7BE0", Offset = "0x6AC6DE0", VA = "0x186AC7BE0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7B20", Offset = "0x6AC6D20", VA = "0x186AC7B20")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime APFBMHLAJIF)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4240", Offset = "0x6AC3440", VA = "0x186AC4240")]
		public static IKFFBFFANPB Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2900", Offset = "0x6AC1B00", VA = "0x186AC2900")]
		public static JDBFPHFBMDO AccountSelectionPostLoginEvent([NotNull] string FCPNJMLJDJD, string FONNPINLHLC, GEAEDAGDAEC MHABBHNHBJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC35C0", Offset = "0x6AC27C0", VA = "0x186AC35C0")]
		public static JDBFPHFBMDO Event([NotNull] string FCPNJMLJDJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6A20", Offset = "0x6AC5C20", VA = "0x186AC6A20")]
		public static JDBFPHFBMDO PreviousSessionEvent([NotNull] string FCPNJMLJDJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC43E0", Offset = "0x6AC35E0", VA = "0x186AC43E0")]
		public static JDBFPHFBMDO InitializeEvent(string FONNPINLHLC, int KDHFDKJIFII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7700", Offset = "0x6AC6900", VA = "0x186AC7700")]
		public static JDBFPHFBMDO StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3190", Offset = "0x6AC2390", VA = "0x186AC3190")]
		public static JDBFPHFBMDO CreateOutOfSessionEvent(string FCPNJMLJDJD, bool IHKHNHPBJCD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4DE0", Offset = "0x6AC3FE0", VA = "0x186AC4DE0")]
		public static KAHDNIHNJDF LogOutOfSessionEvent(JDBFPHFBMDO CEPCGMLEKGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4B80", Offset = "0x6AC3D80", VA = "0x186AC4B80")]
		public void LogEventAsync(AmplitudeAnalyticsEvent KPBLGPDJPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4FA0", Offset = "0x6AC41A0", VA = "0x186AC4FA0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent KPBLGPDJPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6AC50D0", Offset = "0x6AC42D0", VA = "0x186AC50D0")]
		public void LogSerializedEventAsync(Dictionary<string, object> MPIAGKAMBKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4CB0", Offset = "0x6AC3EB0", VA = "0x186AC4CB0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage LIPDNPLNPOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6AC58B0", Offset = "0x6AC4AB0", VA = "0x186AC58B0")]
		private void NJMMGLIOPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5600", Offset = "0x6AC4800", VA = "0x186AC5600")]
		private void NDFAOMBOGBA(Dictionary<string, object> LDLGCGPDDBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3BC0", Offset = "0x6AC2DC0", VA = "0x186AC3BC0")]
		private void GLEMDAJOJDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3CB0", Offset = "0x6AC2EB0", VA = "0x186AC3CB0")]
		private void GMLPPNCLLPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3910", Offset = "0x6AC2B10", VA = "0x186AC3910")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4AE0", Offset = "0x6AC3CE0", VA = "0x186AC4AE0")]
		[IteratorStateMachine(typeof(CKLMLONPJHN))]
		private IEnumerator<CKLDDHMAHNL> LFEFLMJLGFN(float ANKNBCMNEHH = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3100", Offset = "0x6AC2300", VA = "0x186AC3100")]
		[IteratorStateMachine(typeof(BHCGLOEJAEM))]
		private IEnumerator<CKLDDHMAHNL> CAIKGBNIOJL(float ANKNBCMNEHH = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC66B0", Offset = "0x6AC58B0", VA = "0x186AC66B0")]
		[IteratorStateMachine(typeof(EIJADGFOEOD))]
		private IEnumerator<CKLDDHMAHNL> OFAMBFPNBCN(ELLJJHOPECO MNONINFHDLB, int? MLNJEAAGGLM, string EJJMJIMBCLB, float ANKNBCMNEHH, Action<int> MABCGHLCNFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC54F0", Offset = "0x6AC46F0", VA = "0x186AC54F0")]
		private static void MIDEADNFPPJ(bool FGNOJADNCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC51B0", Offset = "0x6AC43B0", VA = "0x186AC51B0")]
		private PIHPPMDHIHB<OLOIACLCIAK<Dictionary<string, object>>> MDBLJOCIPDA(string EJJMJIMBCLB, string ACPPFLNGCAE, Dictionary<string, object> LEENMGJBOLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5280", Offset = "0x6AC4480", VA = "0x186AC5280")]
		private PIHPPMDHIHB<OLOIACLCIAK<List<Dictionary<string, object>>>> MDBLJOCIPDA(string EJJMJIMBCLB, string ACPPFLNGCAE, List<Dictionary<string, object>> LEENMGJBOLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x355C6B0", Offset = "0x355B8B0", VA = "0x18355C6B0")]
		private PIHPPMDHIHB<OLOIACLCIAK<T>> JAKMBNDDEPP<T>(string MHONNIKPEDB, string EJJMJIMBCLB, string ACPPFLNGCAE, T LEENMGJBOLI, Dictionary<string, object> OFHJLIKABAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6AC38C0", Offset = "0x6AC2AC0", VA = "0x186AC38C0")]
		private bool FLMIPEOCJBM(float AMCBJCFOACD, float ANKNBCMNEHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6AC59B0", Offset = "0x6AC4BB0", VA = "0x186AC59B0")]
		private Dictionary<string, object> NKBPINBKCEH(string EJJMJIMBCLB, Dictionary<string, object> LEENMGJBOLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6AC81B0", Offset = "0x6AC73B0", VA = "0x186AC81B0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3450", Offset = "0x6AC2650", VA = "0x186AC3450")]
		[CompilerGenerated]
		private long DNELOEPDEGA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4B70", Offset = "0x6AC3D70", VA = "0x186AC4B70")]
		[CompilerGenerated]
		private void LILKCKLOHIG(int IBLHCIDOKEK)
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
		private readonly string assignedUserCrm;

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

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6AC94C0", Offset = "0x6AC86C0", VA = "0x186AC94C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6AC9590", Offset = "0x6AC8790", VA = "0x186AC9590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6AC9500", Offset = "0x6AC8700", VA = "0x186AC9500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6AC95E0", Offset = "0x6AC87E0", VA = "0x186AC95E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6AC9480", Offset = "0x6AC8680", VA = "0x186AC9480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6AC9540", Offset = "0x6AC8740", VA = "0x186AC9540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x894380", Offset = "0x893580", VA = "0x180894380")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC91E0", Offset = "0x6AC83E0", VA = "0x186AC91E0")]
		public static JDBFPHFBMDO LGJIMIKIEOH(string AIIGKGFGNPA, [NotNull] string EIGECJIBAAN, long AGBINIFDAHI, long MKNGLLMMLIM, string FONNPINLHLC, string MHABBHNHBJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8F80", Offset = "0x6AC8180", VA = "0x186AC8F80")]
		public static JDBFPHFBMDO HONCNGDPFND(string AIIGKGFGNPA, [NotNull] string EIGECJIBAAN, long AGBINIFDAHI, long MKNGLLMMLIM, string FONNPINLHLC, long PHFLGGCBLBA, string PIJEIBPOHMK, string PDNIPNMILHI, string LGANMEKJKLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6AC92E0", Offset = "0x6AC84E0", VA = "0x186AC92E0")]
		private AmplitudeAnalyticsEvent(string AIIGKGFGNPA, [NotNull] string EIGECJIBAAN, long AGBINIFDAHI, long MKNGLLMMLIM, string FONNPINLHLC, string MHABBHNHBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x98E380", Offset = "0x98D580", VA = "0x18098E380")]
		public void CFPHOFLMIJD(long PCFEGKEJCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6AC90E0", Offset = "0x6AC82E0", VA = "0x186AC90E0", Slot = "5")]
		public override void JLEJECIDMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8E10", Offset = "0x6AC8010", VA = "0x186AC8E10", Slot = "6")]
		public override void EDECJLLKNCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8950", Offset = "0x6AC7B50", VA = "0x186AC8950", Slot = "4")]
		protected override Dictionary<string, object> DMDECAMIKJD(Dictionary<string, object> CCOBOHOBKBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8840", Offset = "0x6AC7A40", VA = "0x186AC8840")]
		private void CPJEBIPELPL(string CPBLLDDDHEE, string JECHHBGMFLN, bool DDGLPPDOPPB = false)
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

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC0F0", Offset = "0x6ACB2F0", VA = "0x186ACC0F0")]
			public void AIGEMFELHAF(Dictionary<string, object> PDKPPMKCJMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
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

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6AD5370", Offset = "0x6AD4570", VA = "0x186AD5370")]
			public void AIGEMFELHAF(Dictionary<string, object> FJPDCCCDNGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xD5E060", Offset = "0xD5D260", VA = "0x180D5E060")]
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

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9C20", Offset = "0x6AC8E20", VA = "0x186AC9C20")]
		public static IKFFBFFANPB LGJIMIKIEOH(string AIIGKGFGNPA, string FONNPINLHLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9CE0", Offset = "0x6AC8EE0", VA = "0x186AC9CE0")]
		protected AmplitudeAnalyticsIdentifyMessage(string AIIGKGFGNPA, string FONNPINLHLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9A90", Offset = "0x6AC8C90", VA = "0x186AC9A90")]
		public Dictionary<string, object> FEFHBHACEOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9630", Offset = "0x6AC8830", VA = "0x186AC9630", Slot = "4")]
		protected virtual Dictionary<string, object> DMDECAMIKJD(Dictionary<string, object> CCOBOHOBKBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9970", Offset = "0x6AC8B70", VA = "0x186AC9970")]
		protected void DPKECBPAGLP(string CPBLLDDDHEE, Dictionary<string, object> OHIAEJIIMIE, Dictionary<string, object> FFBOMOGHBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9B20", Offset = "0x6AC8D20", VA = "0x186AC9B20")]
		protected void HMPICGOCFHD(string CPBLLDDDHEE, string JECHHBGMFLN, Dictionary<string, object> HGDNMGCGPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9B90", Offset = "0x6AC8D90", VA = "0x186AC9B90", Slot = "5")]
		public virtual void JLEJECIDMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9A10", Offset = "0x6AC8C10", VA = "0x186AC9A10", Slot = "6")]
		public virtual void EDECJLLKNCK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class IKFFBFFANPB : ADJDBEIKLDF<AmplitudeAnalyticsIdentifyMessage, IKFFBFFANPB>
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public override IKFFBFFANPB CNALDFNPJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage CJMNJFCMAPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6AD23E0", Offset = "0x6AD15E0", VA = "0x186AD23E0")]
	public IKFFBFFANPB(AmplitudeAnalyticsIdentifyMessage ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2340", Offset = "0x6AD1540", VA = "0x186AD2340", Slot = "4")]
	public override void EDECJLLKNCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JDBFPHFBMDO : ADJDBEIKLDF<AmplitudeAnalyticsEvent, JDBFPHFBMDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool CIMBNHMBGKI;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override JDBFPHFBMDO CNALDFNPJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public long EICMPGONHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6AD25A0", Offset = "0x6AD17A0", VA = "0x186AD25A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB710", Offset = "0x6ACA910", VA = "0x186ACB710")]
	public JDBFPHFBMDO(AmplitudeAnalyticsEvent ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "5")]
	public override AmplitudeAnalyticsEvent CJMNJFCMAPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2500", Offset = "0x6AD1700", VA = "0x186AD2500", Slot = "4")]
	public override void EDECJLLKNCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2E6D350", Offset = "0x2E6C550", VA = "0x182E6D350")]
	public JDBFPHFBMDO OBIMIFGACNE<T>(string BAEKDMBADGA, T[] JECHHBGMFLN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E6D350", Offset = "0x2E6C550", VA = "0x182E6D350")]
	public JDBFPHFBMDO OBIMIFGACNE(string BAEKDMBADGA, string[] JECHHBGMFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E6D0A0", Offset = "0x2E6C2A0", VA = "0x182E6D0A0")]
	public JDBFPHFBMDO OBIMIFGACNE<T>(string BAEKDMBADGA, T JECHHBGMFLN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2730", Offset = "0x6AD1930", VA = "0x186AD2730")]
	public JDBFPHFBMDO OBIMIFGACNE(string BAEKDMBADGA, long JECHHBGMFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AD26C0", Offset = "0x6AD18C0", VA = "0x186AD26C0")]
	public JDBFPHFBMDO OBIMIFGACNE(string BAEKDMBADGA, string JECHHBGMFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6AD24D0", Offset = "0x6AD16D0", VA = "0x186AD24D0")]
	public JDBFPHFBMDO DKLPFOGGHAL(string BAEKDMBADGA, object? JECHHBGMFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2430", Offset = "0x6AD1630", VA = "0x186AD2430")]
	public JDBFPHFBMDO AKDLDDMFMHE(string BAEKDMBADGA, string JECHHBGMFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6AD25C0", Offset = "0x6AD17C0", VA = "0x186AD25C0")]
	private JDBFPHFBMDO MHEJGLCGONL(string BAEKDMBADGA, object JECHHBGMFLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BODFCJHIMPJ : JDBFPHFBMDO
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB710", Offset = "0x6ACA910", VA = "0x186ACB710")]
	public BODFCJHIMPJ(AmplitudeAnalyticsEvent ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB570", Offset = "0x6ACA770", VA = "0x186ACB570", Slot = "4")]
	public override void EDECJLLKNCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class ADJDBEIKLDF<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : ADJDBEIKLDF<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M ADNFLGLLNKI;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract BLDR CNALDFNPJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	public ADJDBEIKLDF(M ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3F03490", Offset = "0x3F02690", VA = "0x183F03490")]
	public BLDR KKIIHNACIFE(AmplitudeAnalyticsIdentifyMessage.DeviceInfo NFCBDANJHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3F03410", Offset = "0x3F02610", VA = "0x183F03410")]
	public BLDR EIJMNHPIBCF(AmplitudeAnalyticsIdentifyMessage.RevenueData BOFGGFBONCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3F03370", Offset = "0x3F02570", VA = "0x183F03370")]
	public BLDR EFFLELINHMG(string BAEKDMBADGA, string JECHHBGMFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x27FD190", Offset = "0x27FC390", VA = "0x1827FD190")]
	public BLDR EFFLELINHMG<T>(string BAEKDMBADGA, T JECHHBGMFLN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void EDECJLLKNCK();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3F03460", Offset = "0x3F02660", VA = "0x183F03460")]
	internal static string KBGCJNLEGND(string JECHHBGMFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3F034E0", Offset = "0x3F026E0", VA = "0x183F034E0")]
	private BLDR PJNOKFKLNML(string BAEKDMBADGA, object JECHHBGMFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M CJMNJFCMAPN();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class EEIACKKKANF : PMIBECDCMDP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct GNPJBGIJLDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<PNOMACLKAHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public EEIACKKKANF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private StringContent <requestBody>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private HttpRequestMessage <request>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private HttpResponseMessage <httpResponse>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6AD12F0", Offset = "0x6AD04F0", VA = "0x186AD12F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1D20", Offset = "0x6AD0F20", VA = "0x186AD1D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient PDLKBPFOOLP;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC600", Offset = "0x6ACB800", VA = "0x186ACC600")]
	[NPIOOMADHDK.JLDADBHPDAA]
	internal static void BFDNLINEPIL(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC670", Offset = "0x6ACB870", VA = "0x186ACC670")]
	[RecRoom.NoEngine.Common.Preserve]
	public EEIACKKKANF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC490", Offset = "0x6ACB690", VA = "0x186ACC490", Slot = "4")]
	[AsyncStateMachine(typeof(GNPJBGIJLDF))]
	public Task<PNOMACLKAHH> AIJOJGPNNFO(string MHONNIKPEDB, string KBNMEIKBHAG, string PAEEABFFCMJ, string DBPKAGLGOAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class BFGFDIFIJCO : PMIBECDCMDP
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KDJOBKDPFJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TaskCompletionSource<PNOMACLKAHH> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public KDJOBKDPFJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6AD27B0", Offset = "0x6AD19B0", VA = "0x186AD27B0")]
		internal void ECPFFIGILPK(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct OAMIJANAPPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<PNOMACLKAHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<PNOMACLKAHH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3B50", Offset = "0x6AD2D50", VA = "0x186AD3B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6AD40A0", Offset = "0x6AD32A0", VA = "0x186AD40A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	[NPIOOMADHDK.JLDADBHPDAA]
	internal static void PNMFLIPHOLK(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BFGFDIFIJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB100", Offset = "0x6ACA300", VA = "0x186ACB100", Slot = "4")]
	[AsyncStateMachine(typeof(OAMIJANAPPM))]
	public Task<PNOMACLKAHH> AIJOJGPNNFO(string MHONNIKPEDB, string KBNMEIKBHAG, string PAEEABFFCMJ, string DBPKAGLGOAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GPBHPLMFDOO
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> PMGKEJNODJG;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1D90", Offset = "0x6AD0F90", VA = "0x186AD1D90")]
	internal static bool LHPHOAANPBO(string CPBLLDDDHEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface PMIBECDCMDP
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PNOMACLKAHH> AIJOJGPNNFO(string MHONNIKPEDB, string KBNMEIKBHAG, string PAEEABFFCMJ, string DBPKAGLGOAE);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct PNOMACLKAHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly int DEHJDCJBCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly string DGHPMFGMOCA;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1070F90", Offset = "0x1070190", VA = "0x181070F90")]
	public PNOMACLKAHH(int OEGBCGDKDOJ, string IHFHGAFJENN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum BGDIKFPEGCL
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	GameInvite,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	RoomChat,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DebugCommand
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DDHLOEMNAFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private long COBMBCMJFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private JDBFPHFBMDO CCKMMJDGLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool EJHLCMNPJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float FKKOCPAHMOG;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBF60", Offset = "0x6ACB160", VA = "0x186ACBF60")]
	public DDHLOEMNAFJ(string FLEMEDDEBNI, float FKKOCPAHMOG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C62DA0", Offset = "0x2C61FA0", VA = "0x182C62DA0")]
	public void OBIMIFGACNE<T>(string BAEKDMBADGA, T JECHHBGMFLN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBEE0", Offset = "0x6ACB0E0", VA = "0x186ACBEE0")]
	public void OBIMIFGACNE(string BAEKDMBADGA, string JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBBD0", Offset = "0x6ACADD0", VA = "0x186ACBBD0")]
	public void FKGBLLNPGOI(string GBGMLDIABCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBCC0", Offset = "0x6ACAEC0", VA = "0x186ACBCC0")]
	public void JAAPACOCIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBD80", Offset = "0x6ACAF80", VA = "0x186ACBD80")]
	private void KFHCJNPJIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBE90", Offset = "0x6ACB090", VA = "0x186ACBE90")]
	private bool NINOFOJOKAP()
	{
		return default(bool);
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum MACDJIMPIHP
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			String,
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			Bool
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private MACDJIMPIHP parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public MACDJIMPIHP Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8FBD20", Offset = "0x8FAF20", VA = "0x1808FBD20")]
			get
			{
				return default(MACDJIMPIHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xC93170", Offset = "0xC92370", VA = "0x180C93170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6AD54E0", Offset = "0x6AD46E0", VA = "0x186AD54E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class LHAGAAJCJPP : KPIDGIMPLBI, KHMBEBJKPHP
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate void OKFJPJLBAEC(FCHINOJFCHA GFKOAKNNKON);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly GHDKFKLGKPA DEMEOLMJOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly OKFJPJLBAEC HNMDGODLBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string LBLAHKNCHOO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string LNICLEHIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x14F7350", Offset = "0x14F6550", VA = "0x1814F7350", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool ANCIIEDJFIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2AD0", Offset = "0x6AD1CD0", VA = "0x186AD2AD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JJGEDLPHOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2AF0", Offset = "0x6AD1CF0", VA = "0x186AD2AF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<string> IKLFNNAMFHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x14F7090", Offset = "0x14F6290", VA = "0x1814F7090", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2B10", Offset = "0x6AD1D10", VA = "0x186AD2B10")]
	public LHAGAAJCJPP(GHDKFKLGKPA MADBAEFJKGN, string GDAMGDKDKGN, [Optional] OKFJPJLBAEC DAPKHOCOMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2EF34C0", Offset = "0x2EF26C0", VA = "0x182EF34C0", Slot = "8")]
	public T PLOCNKMCLIO<T>(string CPBLLDDDHEE, T IIGPKDCCLGH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class GMDFINCJOLK : DEGDDAKEMCN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct OALDJIMIDFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AKADCABGAFE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public GMDFINCJOLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD31C0", Offset = "0x6AD23C0", VA = "0x186AD31C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3AF0", Offset = "0x6AD2CF0", VA = "0x186AD3AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct EECCMKIEPOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC270", Offset = "0x6ACB470", VA = "0x186ACC270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC430", Offset = "0x6ACB630", VA = "0x186ACC430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct LPMCKGNJMMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AKADCABGAFE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public GMDFINCJOLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2B80", Offset = "0x6AD1D80", VA = "0x186AD2B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2F80", Offset = "0x6AD2180", VA = "0x186AD2F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct IKBEJGDLABJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public GMDFINCJOLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AKADCABGAFE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1F30", Offset = "0x6AD1130", VA = "0x186AD1F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6AD22E0", Offset = "0x6AD14E0", VA = "0x186AD22E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly IReadOnlyDictionary<string, CKPFFBGCKDG> OKNLFLIGHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool GGIHLMPODDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool JOAIBNIDHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private TaskCompletionSource<bool> HKGNFDKCPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private TaskCompletionSource<bool> FJKNNOKDFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly SemaphoreSlim FPPMEONIFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private APJNKDNCNCN MHEGGHEGCNG;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Task MJFEDOHBAML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0370", Offset = "0x6ACF570", VA = "0x186AD0370", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool FLLMDJGFOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x931B60", Offset = "0x930D60", VA = "0x180931B60", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FOOPFCPKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xE2E4F0", Offset = "0xE2D6F0", VA = "0x180E2E4F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string CHEKPCIKJOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0E10", Offset = "0x6AD0010", VA = "0x186AD0E10", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public DDILIDAGLCL GMOGFIIDJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6ACF610", Offset = "0x6ACE810", VA = "0x186ACF610", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FKGHAPBAFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6AD07E0", Offset = "0x6ACF9E0", VA = "0x186AD07E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0D70", Offset = "0x6ACFF70", VA = "0x186AD0D70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action OBMGGHCHDHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0C30", Offset = "0x6ACFE30", VA = "0x186AD0C30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0CD0", Offset = "0x6ACFED0", VA = "0x186AD0CD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AMJMPBFJPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6ACF8F0", Offset = "0x6ACEAF0", VA = "0x186ACF8F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0A30", Offset = "0x6ACFC30", VA = "0x186AD0A30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<FCHINOJFCHA> MACMLIJPDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0FE0", Offset = "0x6AD01E0", VA = "0x186AD0FE0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0AD0", Offset = "0x6ACFCD0", VA = "0x186AD0AD0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0510", Offset = "0x6ACF710", VA = "0x186AD0510", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6AD03F0", Offset = "0x6ACF5F0", VA = "0x186AD03F0", Slot = "12")]
	[AsyncStateMachine(typeof(OALDJIMIDFK))]
	public Task DDNLIMMJHCH(string GFNENCIDJCI, [Optional] AKADCABGAFE OPKOIMHEIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0B80", Offset = "0x6ACFD80", VA = "0x186AD0B80", Slot = "23")]
	[AsyncStateMachine(typeof(EECCMKIEPOD))]
	public Task LCMKKAECBFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0530", Offset = "0x6ACF730", VA = "0x186AD0530", Slot = "18")]
	[AsyncStateMachine(typeof(LPMCKGNJMMJ))]
	public Task HBEKOCHCJFF(AKADCABGAFE OPKOIMHEIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF990", Offset = "0x6ACEB90", VA = "0x186ACF990")]
	private void AOBODJECODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF7E0", Offset = "0x6ACE9E0", VA = "0x186ACF7E0", Slot = "19")]
	[AsyncStateMachine(typeof(IKBEJGDLABJ))]
	public Task AKGDBBNIENK(AKADCABGAFE OPKOIMHEIFO, Dictionary<string, string> FCEONFIJAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6AD09E0", Offset = "0x6ACFBE0", VA = "0x186AD09E0", Slot = "20")]
	public bool JCPIJEEKMAH(string NHJLPOMONDN, bool GEHCGCDFHEP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0E20", Offset = "0x6AD0020", VA = "0x186AD0E20", Slot = "21")]
	public KPIDGIMPLBI OFPCNGNLMAE(string GDAMGDKDKGN, bool GEHCGCDFHEP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF4A0", Offset = "0x6ACE6A0", VA = "0x186ACF4A0")]
	private GHDKFKLGKPA AGGNJDEAIHB(string GDAMGDKDKGN, bool GEHCGCDFHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0630", Offset = "0x6ACF830", VA = "0x186AD0630", Slot = "22")]
	public GBPNHCNGEAJ HCODDLOIFCB(string OPOBADNHGHD, bool GEHCGCDFHEP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0880", Offset = "0x6ACFA80", VA = "0x186AD0880")]
	private NHFMJGLMIPN IEPIIPOPKIP(string OPOBADNHGHD, bool GEHCGCDFHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFA30", Offset = "0x6ACEC30", VA = "0x186ACFA30")]
	private BOIBBKOOKFN CBHEJNBEAND(AKADCABGAFE OPKOIMHEIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF640", Offset = "0x6ACE840", VA = "0x186ACF640")]
	private JABFMEHIHFP AKALJKKCKFK(string GFNENCIDJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6AD08D0", Offset = "0x6ACFAD0", VA = "0x186AD08D0")]
	private void IIGDIOGDPLJ(string GDAMGDKDKGN, GHDKFKLGKPA MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6AD11F0", Offset = "0x6AD03F0", VA = "0x186AD11F0")]
	public GMDFINCJOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6AD03B0", Offset = "0x6ACF5B0", VA = "0x186AD03B0")]
	[CompilerGenerated]
	private void EGONOCDMBPB(FCHINOJFCHA KHFLFLECNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD03B0", Offset = "0x6ACF5B0", VA = "0x186AD03B0")]
	[CompilerGenerated]
	private void CLLBOGMLDFK(FCHINOJFCHA KHFLFLECNEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class BACJABFHNFL : DEGDDAKEMCN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct EOIOILCCLIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public BACJABFHNFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public AKADCABGAFE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE300", Offset = "0x6ACD500", VA = "0x186ACE300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6ACEC80", Offset = "0x6ACDE80", VA = "0x186ACEC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct KPFKOHHGGJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2890", Offset = "0x6AD1A90", VA = "0x186AD2890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private GMDFINCJOLK GNENAKPCMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private TaskCompletionSource<bool> HKGNFDKCPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private TaskCompletionSource<bool> FJKNNOKDFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Task JFGACOCMIOD;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private DEGDDAKEMCN KPNJLGMNFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9FA0", Offset = "0x6AC91A0", VA = "0x186AC9FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool FOOPFCPKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA6F0", Offset = "0x6AC98F0", VA = "0x186ACA6F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool FLLMDJGFOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA3C0", Offset = "0x6AC95C0", VA = "0x186ACA3C0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task MJFEDOHBAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA010", Offset = "0x6AC9210", VA = "0x186ACA010", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string CHEKPCIKJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6ACAEB0", Offset = "0x6ACA0B0", VA = "0x186ACAEB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DDILIDAGLCL GMOGFIIDJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9DA0", Offset = "0x6AC8FA0", VA = "0x186AC9DA0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action OBMGGHCHDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6ACACD0", Offset = "0x6AC9ED0", VA = "0x186ACACD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6ACAD70", Offset = "0x6AC9F70", VA = "0x186ACAD70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action FKGHAPBAFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6ACA610", Offset = "0x6AC9810", VA = "0x186ACA610", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6ACAE10", Offset = "0x6ACA010", VA = "0x186ACAE10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action AMJMPBFJPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9F00", Offset = "0x6AC9100", VA = "0x186AC9F00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6ACAA70", Offset = "0x6AC9C70", VA = "0x186ACAA70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<FCHINOJFCHA> MACMLIJPDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6ACAF90", Offset = "0x6ACA190", VA = "0x186ACAF90", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6ACAB10", Offset = "0x6AC9D10", VA = "0x186ACAB10", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB040", Offset = "0x6ACA240", VA = "0x186ACB040")]
	[UnityEngine.Scripting.Preserve]
	public BACJABFHNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA3D0", Offset = "0x6AC95D0", VA = "0x186ACA3D0")]
	[NPIOOMADHDK.JLDADBHPDAA.GOAAFNNCHDN]
	internal static void GLGGBEPLOGP(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA350", Offset = "0x6AC9550", VA = "0x186ACA350")]
	internal static void GEMOOFAFKMF(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA320", Offset = "0x6AC9520", VA = "0x186ACA320", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA210", Offset = "0x6AC9410", VA = "0x186ACA210", Slot = "12")]
	[AsyncStateMachine(typeof(EOIOILCCLIG))]
	public Task DDNLIMMJHCH(string GFNENCIDJCI, [Optional] AKADCABGAFE OPKOIMHEIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA440", Offset = "0x6AC9640", VA = "0x186ACA440", Slot = "18")]
	public Task HBEKOCHCJFF(AKADCABGAFE OPKOIMHEIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9DE0", Offset = "0x6AC8FE0", VA = "0x186AC9DE0", Slot = "19")]
	public Task AKGDBBNIENK(AKADCABGAFE OPKOIMHEIFO, Dictionary<string, string> FCEONFIJAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA7D0", Offset = "0x6AC99D0", VA = "0x186ACA7D0", Slot = "20")]
	public bool JCPIJEEKMAH(string NHJLPOMONDN, bool GEHCGCDFHEP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAED0", Offset = "0x6ACA0D0", VA = "0x186ACAED0", Slot = "21")]
	public KPIDGIMPLBI OFPCNGNLMAE(string GDAMGDKDKGN, bool GEHCGCDFHEP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA550", Offset = "0x6AC9750", VA = "0x186ACA550", Slot = "22")]
	public GBPNHCNGEAJ HCODDLOIFCB(string OPOBADNHGHD, bool GEHCGCDFHEP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACABC0", Offset = "0x6AC9DC0", VA = "0x186ACABC0", Slot = "23")]
	public Task LCMKKAECBFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA8F0", Offset = "0x6AC9AF0", VA = "0x186ACA8F0")]
	private static void KCOBLEMCGLF(TaskCompletionSource<bool> HNKDADPHGFG, Task DAEBCDEKCLJ, Task FMGOFBMDNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA700", Offset = "0x6AC9900", VA = "0x186ACA700")]
	[AsyncStateMachine(typeof(KPFKOHHGGJC))]
	private static void JBFNCIFKNGO(Task HMHJFGCCEGP, TaskCompletionSource<bool> HNKDADPHGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x9FD3C0", Offset = "0x9FC5C0", VA = "0x1809FD3C0")]
	[CompilerGenerated]
	private void NFAIOMCGDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x99F8E0", Offset = "0x99EAE0", VA = "0x18099F8E0")]
	[CompilerGenerated]
	private void EBGCHGLGIFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x9E9BE0", Offset = "0x9E8DE0", VA = "0x1809E9BE0")]
	[CompilerGenerated]
	private void BNLFNMDLKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA6B0", Offset = "0x6AC98B0", VA = "0x186ACA6B0")]
	[CompilerGenerated]
	private void IKONJIJEDNM(FCHINOJFCHA KHFLFLECNEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class NHNEIBHCFJH : GBPNHCNGEAJ, KHMBEBJKPHP
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void INFLFFBOPML(FCHINOJFCHA GFKOAKNNKON);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly INFLFFBOPML HNMDGODLBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly NHFMJGLMIPN HPEIEBOLNHA;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string LNICLEHIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x931130", Offset = "0x930330", VA = "0x180931130", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5E08AC0", Offset = "0x5E07CC0", VA = "0x185E08AC0")]
	public NHNEIBHCFJH(NHFMJGLMIPN FKKDMNGBFLM, [Optional] INFLFFBOPML DAPKHOCOMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2F7D390", Offset = "0x2F7C590", VA = "0x182F7D390", Slot = "5")]
	public T PLOCNKMCLIO<T>(string CPBLLDDDHEE, T IIGPKDCCLGH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface MDCGGIMIBLL
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[UsedImplicitly]
public class PMKJAKNJLBD : MDCGGIMIBLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly MCGMIKOKJJJ MOPPOPIHOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<BCMKLOJLAMC> IHLJFANDJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly string HOOKPJIKHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly string ICCEECCALPP;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD51A0", Offset = "0x6AD43A0", VA = "0x186AD51A0")]
	[UsedImplicitly]
	[NPIOOMADHDK.JLDADBHPDAA.GOAAFNNCHDN]
	internal static void NLJAFONFJGA(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5210", Offset = "0x6AD4410", VA = "0x186AD5210")]
	[RecRoom.NoEngine.Common.Preserve]
	internal PMKJAKNJLBD([GEFLINBOFNF(null)][NotNull] MCGMIKOKJJJ MOPPOPIHOAJ, [GEFLINBOFNF(null)][NotNull] AMJPIGONLEJ PBINAFCJLHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class OKJMOFDAPBE : DEGDDAKEMCN
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task MJFEDOHBAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6AD49A0", Offset = "0x6AD3BA0", VA = "0x186AD49A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool FOOPFCPKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool FLLMDJGFOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string CHEKPCIKJOH
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DDILIDAGLCL GMOGFIIDJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action OBMGGHCHDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4E60", Offset = "0x6AD4060", VA = "0x186AD4E60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4F00", Offset = "0x6AD4100", VA = "0x186AD4F00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action FKGHAPBAFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4BE0", Offset = "0x6AD3DE0", VA = "0x186AD4BE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4FA0", Offset = "0x6AD41A0", VA = "0x186AD4FA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action AMJMPBFJPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4900", Offset = "0x6AD3B00", VA = "0x186AD4900", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4C80", Offset = "0x6AD3E80", VA = "0x186AD4C80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<FCHINOJFCHA> MACMLIJPDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6AD50F0", Offset = "0x6AD42F0", VA = "0x186AD50F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4D20", Offset = "0x6AD3F20", VA = "0x186AD4D20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OKJMOFDAPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4A30", Offset = "0x6AD3C30", VA = "0x186AD4A30", Slot = "12")]
	public Task DDNLIMMJHCH(string GFNENCIDJCI, [Optional] AKADCABGAFE OPKOIMHEIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4AC0", Offset = "0x6AD3CC0", VA = "0x186AD4AC0", Slot = "18")]
	public Task HBEKOCHCJFF(AKADCABGAFE OPKOIMHEIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4870", Offset = "0x6AD3A70", VA = "0x186AD4870", Slot = "19")]
	public Task AKGDBBNIENK(AKADCABGAFE OPKOIMHEIFO, Dictionary<string, string> FCEONFIJAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "20")]
	public bool JCPIJEEKMAH(string NHJLPOMONDN, bool GEHCGCDFHEP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5040", Offset = "0x6AD4240", VA = "0x186AD5040", Slot = "21")]
	public KPIDGIMPLBI OFPCNGNLMAE(string GDAMGDKDKGN, bool GEHCGCDFHEP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4B50", Offset = "0x6AD3D50", VA = "0x186AD4B50", Slot = "22")]
	public GBPNHCNGEAJ HCODDLOIFCB(string OPOBADNHGHD, bool GEHCGCDFHEP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4DD0", Offset = "0x6AD3FD0", VA = "0x186AD4DD0", Slot = "23")]
	public Task LCMKKAECBFG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal class APJNKDNCNCN : DDILIDAGLCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly BOIBBKOOKFN IBIEGPBHEFE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IReadOnlyDictionary<string, object> DHOOOKBHAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x92FA90", Offset = "0x92EC90", VA = "0x18092FA90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	public APJNKDNCNCN(BOIBBKOOKFN GOLOONOPNMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GLBDGBJGHGK
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DDHLOEMNAFJ MJFGMEBDIPK(string FLEMEDDEBNI);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface NHPNODKLKOI
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum KGHHOEBJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	long AKPKHFIOFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string ALCJGKOKBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string GKMIENODMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool NNPMHGNBMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long FAPENEIOEAC();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void COONFFHJGJP(long AGBINIFDAHI, bool DDGLPPDOPPB = true);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MGNOFILCKKG(string GFIAFOEJCDD, string FDCBHNILAGI, string IPNJNLPAKHE);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ALICONJFMJH(string GFIAFOEJCDD);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BKPFPDIAMPC(string GFIAFOEJCDD, string OLEPLFMJOOA, string OAHKEFOEPIF);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KMFIEPOCGGL(string HFKACMMIPME, object CKMBHDGCECN, object CLNPFCDMAHL);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PGKCAHDHNEF(KGHHOEBJIIM IDOOLMBPLGK, int LNKBLOMPPCK, [Optional] AHFMDOHLFNN FCOFEJGOIPN, [Optional] string LOLFBGECLNL, [Optional] string BAHJDCJDFHC);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PHACNAOMCLL(AHFMDOHLFNN FCOFEJGOIPN, long JDKFCLDPMMD, long DHBJOFPMEJP, int KOAKDHBPOBB, string LOLFBGECLNL, int LNKBLOMPPCK);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OAMKHCBDCAO(AHFMDOHLFNN FCOFEJGOIPN, bool LIFLGCGNBFL, [Optional] string BAHJDCJDFHC);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JCNNGDBBAPK(AHFMDOHLFNN FCOFEJGOIPN, bool LIFLGCGNBFL, [Optional] string BAHJDCJDFHC);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PHKGCKDJEGF(AHFMDOHLFNN FCOFEJGOIPN, bool LIFLGCGNBFL, [Optional] string BAHJDCJDFHC);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HBKHKJCAPGN(long MMNCPOOFGEF, string FANKNEFFHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface CDBDCFDAGPN
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string EKDDHBKOCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "0")]
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
