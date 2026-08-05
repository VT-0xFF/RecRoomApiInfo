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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5FE3C30", Offset = "0x5FE2E30", VA = "0x185FE3C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
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
		public AmplitudeAnalyticsClient.Settings KFOJFLKCLGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HGGKDOKJDNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B77B0", Offset = "0x7B69B0", VA = "0x1807B77B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum PHBODKDMEDA
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class CLKCFANHGBB
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class OHNJIOPLOBB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int LNDIDAGCPLM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> BJCBEBMHKLC;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
				public OHNJIOPLOBB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class FCDNJGDFIFB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
				public FCDNJGDFIFB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5FDFD90", Offset = "0x5FDEF90", VA = "0x185FDFD90")]
				internal bool PIIIJOHFBEM(OHNJIOPLOBB item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string GIBNKKAKHOA = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string HJAAHPMFKAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<OHNJIOPLOBB> AMDABAEFLBD;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? HKOILCPFMKN
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5FDE9D0", Offset = "0x5FDDBD0", VA = "0x185FDE9D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEF00", Offset = "0x5FDE100", VA = "0x185FDEF00")]
			internal CLKCFANHGBB(string PGMINOHJLFP, string KLEKIFCKLDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5FDE430", Offset = "0x5FDD630", VA = "0x185FDE430")]
			public int GJIFKFHICLO([Optional] int? CIAMLCMDLOE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEB70", Offset = "0x5FDDD70", VA = "0x185FDEB70")]
			public List<Dictionary<string, object>> MCBKPBPIHFE(int HLLMMCPFLBO, int? CIAMLCMDLOE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5FDE930", Offset = "0x5FDDB30", VA = "0x185FDE930")]
			public void JGNEDNMOMDP(AmplitudeAnalyticsIdentifyMessage GLMGCMELGFD, bool LJFIHGECDML = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5FDE820", Offset = "0x5FDDA20", VA = "0x185FDE820")]
			public void JGNEDNMOMDP(Dictionary<string, object> GLMGCMELGFD, bool LJFIHGECDML = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5FDDC30", Offset = "0x5FDCE30", VA = "0x185FDDC30")]
			public void ACLJIBBEEJF(params Dictionary<string, object>[] OOFGGMPMHJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5FDE5E0", Offset = "0x5FDD7E0", VA = "0x185FDE5E0")]
			public void GMAOJMPBKBG(List<Dictionary<string, object>> AKIADAIHLPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEA70", Offset = "0x5FDDC70", VA = "0x185FDEA70")]
			private void LFCJIOBIFMF(Dictionary<string, object> GLMGCMELGFD, bool LJFIHGECDML = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5FDDDB0", Offset = "0x5FDCFB0", VA = "0x185FDDDB0")]
			public void CEMDPEICCLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5FDDFE0", Offset = "0x5FDD1E0", VA = "0x185FDDFE0")]
			private void DNAOIACJLPF([Optional] string GOBIFJJLEAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEDE0", Offset = "0x5FDDFE0", VA = "0x185FDEDE0")]
			private static string OFFOOICHNED(string EKDDCPALANJ, string GHBNLDGJPCB)
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
			[Cpp2IlInjected.Address(RVA = "0x5FE4800", Offset = "0x5FE3A00", VA = "0x185FE4800")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct JGCCBKEOCJJ<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int FHKIOOODNCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string NCIKEKDFIIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T NDILMHHDKPH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class IFLBDCCEAEK : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private AHKNJJJKEOF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
			[DebuggerHidden]
			public IFLBDCCEAEK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5FE0FF0", Offset = "0x5FE01F0", VA = "0x185FE0FF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5FE17A0", Offset = "0x5FE09A0", VA = "0x185FE17A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class CILJCEOINDF : IEnumerator<object>, IEnumerator, IDisposable
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
			public EAEPIGKFFMI quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
			[DebuggerHidden]
			public CILJCEOINDF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5FDDAD0", Offset = "0x5FDCCD0", VA = "0x185FDDAD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5FDDBE0", Offset = "0x5FDCDE0", VA = "0x185FDDBE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JPKENFKAFHM : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
			[DebuggerHidden]
			public JPKENFKAFHM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5FE25F0", Offset = "0x5FE17F0", VA = "0x185FE25F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5FE2760", Offset = "0x5FE1960", VA = "0x185FE2760", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class IMMHLFMDDHE : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private AHKNJJJKEOF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
			[DebuggerHidden]
			public IMMHLFMDDHE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5FE1B70", Offset = "0x5FE0D70", VA = "0x185FE1B70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5FE1DF0", Offset = "0x5FE0FF0", VA = "0x185FE1DF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class BLINDGGJOAD : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private AHKNJJJKEOF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
			[DebuggerHidden]
			public BLINDGGJOAD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5FDA950", Offset = "0x5FD9B50", VA = "0x185FDA950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5FDABD0", Offset = "0x5FD9DD0", VA = "0x185FDABD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CANGAIENEKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public CLKCFANHGBB cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public CANGAIENEKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5FDCB00", Offset = "0x5FDBD00", VA = "0x185FDCB00")]
			internal void OFEAMKNKMCL(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5FDCE10", Offset = "0x5FDC010", VA = "0x185FDCE10")]
			internal void OGHOFCPIJHE(JGCCBKEOCJJ<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class GBECHGAJDCG : IEnumerator<AHKNJJJKEOF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private AHKNJJJKEOF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public CLKCFANHGBB cache;

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
			private CANGAIENEKL <>8__1;

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
			private AHKNJJJKEOF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
			[DebuggerHidden]
			public GBECHGAJDCG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5FDFE00", Offset = "0x5FDF000", VA = "0x185FDFE00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5FE06A0", Offset = "0x5FDF8A0", VA = "0x185FE06A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class CEAILJOCPJH<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public CEAILJOCPJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x410E140", Offset = "0x410D340", VA = "0x18410E140")]
			internal JGCCBKEOCJJ<T> JBMNMGFEJIN(PGFFELGBIHH postResponse)
			{
				return default(JGCCBKEOCJJ<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class OPBDIJEDLCG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public OPBDIJEDLCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x410E140", Offset = "0x410D340", VA = "0x18410E140")]
			internal JGCCBKEOCJJ<T> CCMDLMHALLO(PGFFELGBIHH postResponse)
			{
				return default(JGCCBKEOCJJ<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private AFNPEINCDIO FNGMPKIOMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<LNCHGOKGNIB> KBOJBCADEHN;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string JBDGEMJKLHO = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string LPJHBONMMGM = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string JFNFCEELLFK = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int FLMDKLMPFCO = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int NMOJHMCAJOF = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int FFAKMJDDGDJ = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float OKHMPJMKAFN = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long NLFMBNEJBAN = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string GHKLNDJGNMM = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string FDJIAJNGILG = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool OIEPLOCKIDE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool KLMBFABPFEI;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int AJHCIEAJILC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int BMDDOPALJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private FFLAPLNODFG FCGKCEEDJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private KALDHBEDLBO DEKHIOAFHAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private IIEKHPEDJHI FGGNCHABOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool BFENKFFNLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float MHPFOCJLFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float IIPKFEAHGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int INLOMEOEJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int BDAAKBBFDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? NMDINDOKKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? NCOFBLCMMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long EBMOCENLBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string HMMNIGKJJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool JAJHBDAKJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long IKFGKBBMFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string OPDNBCFNLFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string NJBELEIPFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> GPBOHFCMLMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private PHBODKDMEDA JKLNCAIMFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int APBAGPBKKGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int PODHHHCKLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float KBDMPFOIJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool MNOBFMMNPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool BJGPLIOIAOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private CLKCFANHGBB LMKEDPHJPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private CLKCFANHGBB LFJCHKKNHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CLKCFANHGBB FJNCNKFAJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> IELNMCAFHCA;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo NJPFHPDBNGP;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string ODEENJDPHNG;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string MJOKKNCMCKL = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string KIAFDGPKHMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string EJNOONIDJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string IJGENGLBCEA;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private AFNPEINCDIO GKDMEGAECMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5FD3C40", Offset = "0x5FD2E40", VA = "0x185FD3C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private LNCHGOKGNIB EJGNJCAKGOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5FD4090", Offset = "0x5FD3290", VA = "0x185FD4090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int IDGEGAJNKND
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5FD7540", Offset = "0x5FD6740", VA = "0x185FD7540")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long HIOGCPOCEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9080", Offset = "0x5FD8280", VA = "0x185FD9080")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5FD91A0", Offset = "0x5FD83A0", VA = "0x185FD91A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string GAHIICHIGLB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9020", Offset = "0x5FD8220", VA = "0x185FD9020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string IGIGEIHHCFL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9050", Offset = "0x5FD8250", VA = "0x185FD9050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HGJMNICOFFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8DB250", Offset = "0x8DA450", VA = "0x1808DB250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8DB230", Offset = "0x8DA430", VA = "0x1808DB230")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? ABMMILJECDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8FDC30", Offset = "0x8FCE30", VA = "0x1808FDC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9190", Offset = "0x5FD8390", VA = "0x185FD9190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GKNJEDMDBFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xFCDD80", Offset = "0xFCCF80", VA = "0x180FCDD80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xFCDA30", Offset = "0xFCCC30", VA = "0x180FCDA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool CCKIOJLLJGE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5FD8F00", Offset = "0x5FD8100", VA = "0x185FD8F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> OBLMFOFCLLA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5FD8E40", Offset = "0x5FD8040", VA = "0x185FD8E40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5FD90D0", Offset = "0x5FD82D0", VA = "0x185FD90D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FD36D0", Offset = "0x5FD28D0", VA = "0x185FD36D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FD58A0", Offset = "0x5FD4AA0", VA = "0x185FD58A0")]
		private void MEKAGICBHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8430", Offset = "0x5FD7630", VA = "0x185FD8430")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5FD7010", Offset = "0x5FD6210", VA = "0x185FD7010", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5FD87D0", Offset = "0x5FD79D0", VA = "0x185FD87D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5FD7710", Offset = "0x5FD6910", VA = "0x185FD7710")]
		public BCIJDCGHKGJ PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4BB0", Offset = "0x5FD3DB0", VA = "0x185FD4BB0")]
		[IteratorStateMachine(typeof(IFLBDCCEAEK))]
		public IEnumerator<AHKNJJJKEOF> Initialize(AmplitudeAnalyticsEvent HLLFEJCFFDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8710", Offset = "0x5FD7910", VA = "0x185FD8710")]
		public void UpdateLastKnownInteractionCategory(string OGNBIDGAJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8620", Offset = "0x5FD7820", VA = "0x185FD8620")]
		public void UpdateLastAliveTime(float PJADGMHMMIA = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FD44F0", Offset = "0x5FD36F0", VA = "0x185FD44F0")]
		private BCIJDCGHKGJ HFKMGNODHBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4E60", Offset = "0x5FD4060", VA = "0x185FD4E60")]
		private BCIJDCGHKGJ KEGJPLAPGPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5FD7EA0", Offset = "0x5FD70A0", VA = "0x185FD7EA0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4460", Offset = "0x5FD3660", VA = "0x185FD4460")]
		[IteratorStateMachine(typeof(CILJCEOINDF))]
		private IEnumerator GGJFBCHGECG(EAEPIGKFFMI LNGPKCCCCJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8A60", Offset = "0x5FD7C60", VA = "0x185FD8A60")]
		[IteratorStateMachine(typeof(JPKENFKAFHM))]
		public IEnumerator WaitForFlush(float FJBGLIDGKNL = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8500", Offset = "0x5FD7700", VA = "0x185FD8500")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8440", Offset = "0x5FD7640", VA = "0x185FD8440")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime NOOMBIPKGEF)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4740", Offset = "0x5FD3940", VA = "0x185FD4740")]
		public static CDJPPGBNECO Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3570", Offset = "0x5FD2770", VA = "0x185FD3570")]
		public static IGIPFCFNCFA AccountSelectionPostLoginEvent([NotNull] string MEOKOMEAJEC, string EKIDEPBKGEL, bool IBJBOOOOGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5FD40E0", Offset = "0x5FD32E0", VA = "0x185FD40E0")]
		public static IGIPFCFNCFA Event([NotNull] string MEOKOMEAJEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FD7750", Offset = "0x5FD6950", VA = "0x185FD7750")]
		public static IGIPFCFNCFA PreviousSessionEvent([NotNull] string MEOKOMEAJEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5FD48E0", Offset = "0x5FD3AE0", VA = "0x185FD48E0")]
		public static IGIPFCFNCFA InitializeEvent(string EKIDEPBKGEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8060", Offset = "0x5FD7260", VA = "0x185FD8060")]
		public static IGIPFCFNCFA StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3CB0", Offset = "0x5FD2EB0", VA = "0x185FD3CB0")]
		public static IGIPFCFNCFA CreateOutOfSessionEvent(string MEOKOMEAJEC, bool MDDNBFHEMEO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FD53B0", Offset = "0x5FD45B0", VA = "0x185FD53B0")]
		public static BCIJDCGHKGJ LogOutOfSessionEvent(IGIPFCFNCFA PPNABAILGDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5150", Offset = "0x5FD4350", VA = "0x185FD5150")]
		public void LogEventAsync(AmplitudeAnalyticsEvent KDJOELCGCGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5690", Offset = "0x5FD4890", VA = "0x185FD5690")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent KDJOELCGCGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FD57C0", Offset = "0x5FD49C0", VA = "0x185FD57C0")]
		public void LogSerializedEventAsync(Dictionary<string, object> KAIKKECFDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5280", Offset = "0x5FD4480", VA = "0x185FD5280")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage BCCMIFKNGLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3B30", Offset = "0x5FD2D30", VA = "0x185FD3B30")]
		private void BJEEGCKCKLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5F30", Offset = "0x5FD5130", VA = "0x185FD5F30")]
		private void NPOJLLAJCMA(Dictionary<string, object> LONIJHJPBBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5E40", Offset = "0x5FD5040", VA = "0x185FD5E40")]
		private void MPEAHNBPPHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4C40", Offset = "0x5FD3E40", VA = "0x185FD4C40")]
		private void JKKKGJHOJAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5FD43D0", Offset = "0x5FD35D0", VA = "0x185FD43D0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4000", Offset = "0x5FD3200", VA = "0x185FD4000")]
		[IteratorStateMachine(typeof(IMMHLFMDDHE))]
		private IEnumerator<AHKNJJJKEOF> DIIOCPNILKK(float FJBGLIDGKNL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5FD46B0", Offset = "0x5FD38B0", VA = "0x185FD46B0")]
		[IteratorStateMachine(typeof(BLINDGGJOAD))]
		private IEnumerator<AHKNJJJKEOF> IMFJELOJIOP(float FJBGLIDGKNL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3F00", Offset = "0x5FD3100", VA = "0x185FD3F00")]
		[IteratorStateMachine(typeof(GBECHGAJDCG))]
		private IEnumerator<AHKNJJJKEOF> DBJHCIMBGPO(CLKCFANHGBB KFPKKDDFIOC, int? CIAMLCMDLOE, string FJMENOKABAA, string KMJCNCAEHCC, float FJBGLIDGKNL, Action<int> EJLBGNECGAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5FD45A0", Offset = "0x5FD37A0", VA = "0x185FD45A0")]
		private static void HKGLILLEDIP(bool IPJDFADHMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5FD70C0", Offset = "0x5FD62C0", VA = "0x185FD70C0")]
		private OCNPNNKFOAO<JGCCBKEOCJJ<Dictionary<string, object>>> PBHICJLDPPC(string FJMENOKABAA, string KMJCNCAEHCC, string FMCHEAIPKAH, string PCECMNIEGMB, Dictionary<string, object> NDILMHHDKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD71F0", Offset = "0x5FD63F0", VA = "0x185FD71F0")]
		private OCNPNNKFOAO<JGCCBKEOCJJ<List<Dictionary<string, object>>>> PBHICJLDPPC(string FJMENOKABAA, string KMJCNCAEHCC, string FMCHEAIPKAH, string PCECMNIEGMB, List<Dictionary<string, object>> NDILMHHDKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2ED05B0", Offset = "0x2ECF7B0", VA = "0x182ED05B0")]
		private OCNPNNKFOAO<JGCCBKEOCJJ<T>> ABLBGIFKDKF<T>(string FJMENOKABAA, string KMJCNCAEHCC, string PCECMNIEGMB, T NDILMHHDKPH, Dictionary<string, object> BGIKJJGKAOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2ED0860", Offset = "0x2ECFA60", VA = "0x182ED0860")]
		private OCNPNNKFOAO<JGCCBKEOCJJ<T>> PHNPGLIKKDO<T>(string FJMENOKABAA, string KMJCNCAEHCC, string FMCHEAIPKAH, T NDILMHHDKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4E10", Offset = "0x5FD4010", VA = "0x185FD4E10")]
		private bool KAIDAOHJHLG(float NAKJEPNEEIE, float FJBGLIDGKNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5FD6340", Offset = "0x5FD5540", VA = "0x185FD6340")]
		private Dictionary<string, object> OLINCDPMBFI(string KMJCNCAEHCC, Dictionary<string, object> NDILMHHDKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8B50", Offset = "0x5FD7D50", VA = "0x185FD8B50")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5FD61E0", Offset = "0x5FD53E0", VA = "0x185FD61E0")]
		[CompilerGenerated]
		private long OJBOOHDDJHH()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3C30", Offset = "0x5FD2E30", VA = "0x185FD3C30")]
		[CompilerGenerated]
		private void BNEDOOBBLBI(int OINBLEOCHCC)
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
			[Cpp2IlInjected.Address(RVA = "0x5FD9ED0", Offset = "0x5FD90D0", VA = "0x185FD9ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9FA0", Offset = "0x5FD91A0", VA = "0x185FD9FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9F10", Offset = "0x5FD9110", VA = "0x185FD9F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9FF0", Offset = "0x5FD91F0", VA = "0x185FD9FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9E90", Offset = "0x5FD9090", VA = "0x185FD9E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9F50", Offset = "0x5FD9150", VA = "0x185FD9F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7BCC50", Offset = "0x7BBE50", VA = "0x1807BCC50")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9360", Offset = "0x5FD8560", VA = "0x185FD9360")]
		public static IGIPFCFNCFA DMOLILFLBFL(string BKPHPJDBECD, [NotNull] string IIMBDPDOKJG, long OLAALDHHLHB, long AFLGLNKEHFH, string EKIDEPBKGEL, bool IBJBOOOOGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9200", Offset = "0x5FD8400", VA = "0x185FD9200")]
		public static IGIPFCFNCFA AMKDMDAHLNP(string BKPHPJDBECD, [NotNull] string IIMBDPDOKJG, long OLAALDHHLHB, long AFLGLNKEHFH, string EKIDEPBKGEL, long DLFHGMMLHHJ, bool IBJBOOOOGLJ, string LDIKJKLJGKI, string EGLADLOHHOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9D00", Offset = "0x5FD8F00", VA = "0x185FD9D00")]
		private AmplitudeAnalyticsEvent(string BKPHPJDBECD, [NotNull] string IIMBDPDOKJG, long OLAALDHHLHB, long AFLGLNKEHFH, string EKIDEPBKGEL, bool IBJBOOOOGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6DF0", Offset = "0x1AD5FF0", VA = "0x181AD6DF0")]
		public void BONLNNMFCOA(long GLNPHPIIHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9980", Offset = "0x5FD8B80", VA = "0x185FD9980", Slot = "5")]
		public override void FCPHOOHHCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9B90", Offset = "0x5FD8D90", VA = "0x185FD9B90", Slot = "6")]
		public override void OBGACDADEDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9460", Offset = "0x5FD8660", VA = "0x185FD9460", Slot = "4")]
		protected override Dictionary<string, object> EAMJHKHBEFK(Dictionary<string, object> MPLACICGJHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9A80", Offset = "0x5FD8C80", VA = "0x185FD9A80")]
		private void HNKHHFLAJHM(string GHBNLDGJPCB, string EKDDCPALANJ, bool ABGMHPBGLJB = false)
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
			[Cpp2IlInjected.Address(RVA = "0x5FDF1A0", Offset = "0x5FDE3A0", VA = "0x185FDF1A0")]
			public void EMFCFCGGJNI(Dictionary<string, object> MMGMIKLCDON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FE4490", Offset = "0x5FE3690", VA = "0x185FE4490")]
			public void EMFCFCGGJNI(Dictionary<string, object> HGCNBACBLLJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x93B790", Offset = "0x93A990", VA = "0x18093B790")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA040", Offset = "0x5FD9240", VA = "0x185FDA040")]
		public static CDJPPGBNECO DMOLILFLBFL(string BKPHPJDBECD, string EKIDEPBKGEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA6F0", Offset = "0x5FD98F0", VA = "0x185FDA6F0")]
		protected AmplitudeAnalyticsIdentifyMessage(string BKPHPJDBECD, string EKIDEPBKGEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA440", Offset = "0x5FD9640", VA = "0x185FDA440")]
		public Dictionary<string, object> EOFHLCLPABH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA100", Offset = "0x5FD9300", VA = "0x185FDA100", Slot = "4")]
		protected virtual Dictionary<string, object> EAMJHKHBEFK(Dictionary<string, object> MPLACICGJHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA5D0", Offset = "0x5FD97D0", VA = "0x185FDA5D0")]
		protected void JNFOANOFPHH(string GHBNLDGJPCB, Dictionary<string, object> IJOGELMMMCP, Dictionary<string, object> ICCLKKFECJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA560", Offset = "0x5FD9760", VA = "0x185FDA560")]
		protected void HOOCMGMOFIA(string GHBNLDGJPCB, string EKDDCPALANJ, Dictionary<string, object> FMNBOKPLADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA4D0", Offset = "0x5FD96D0", VA = "0x185FDA4D0", Slot = "5")]
		public virtual void FCPHOOHHCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA670", Offset = "0x5FD9870", VA = "0x185FDA670", Slot = "6")]
		public virtual void OBGACDADEDJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CDJPPGBNECO : JPBCDOEKIDC<AmplitudeAnalyticsIdentifyMessage, CDJPPGBNECO>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override CDJPPGBNECO LLJLCOGFAIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage PMNPBLFGDKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5FDDA80", Offset = "0x5FDCC80", VA = "0x185FDDA80")]
	public CDJPPGBNECO(AmplitudeAnalyticsIdentifyMessage FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5FDD9E0", Offset = "0x5FDCBE0", VA = "0x185FDD9E0", Slot = "4")]
	public override void OBGACDADEDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IGIPFCFNCFA : JPBCDOEKIDC<AmplitudeAnalyticsEvent, IGIPFCFNCFA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool NLEGBGKHLPO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override IGIPFCFNCFA LLJLCOGFAIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long JKPAEMBGNFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1B50", Offset = "0x5FE0D50", VA = "0x185FE1B50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5FDCAB0", Offset = "0x5FDBCB0", VA = "0x185FDCAB0")]
	public IGIPFCFNCFA(AmplitudeAnalyticsEvent FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140", Slot = "5")]
	public override AmplitudeAnalyticsEvent PMNPBLFGDKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1AB0", Offset = "0x5FE0CB0", VA = "0x185FE1AB0", Slot = "4")]
	public override void OBGACDADEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x28B9BA0", Offset = "0x28B8DA0", VA = "0x1828B9BA0")]
	public IGIPFCFNCFA AKACGDJLAPB<T>(string BMIMCNPMKAE, T[] EKDDCPALANJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x28B9BA0", Offset = "0x28B8DA0", VA = "0x1828B9BA0")]
	public IGIPFCFNCFA AKACGDJLAPB(string BMIMCNPMKAE, string[] EKDDCPALANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x28B98F0", Offset = "0x28B8AF0", VA = "0x1828B98F0")]
	public IGIPFCFNCFA AKACGDJLAPB<T>(string BMIMCNPMKAE, T EKDDCPALANJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1860", Offset = "0x5FE0A60", VA = "0x185FE1860")]
	public IGIPFCFNCFA AKACGDJLAPB(string BMIMCNPMKAE, long EKDDCPALANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5FE17F0", Offset = "0x5FE09F0", VA = "0x185FE17F0")]
	public IGIPFCFNCFA AKACGDJLAPB(string BMIMCNPMKAE, string EKDDCPALANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5FE19E0", Offset = "0x5FE0BE0", VA = "0x185FE19E0")]
	public IGIPFCFNCFA COBDPILBAPI(string BMIMCNPMKAE, object? EKDDCPALANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1A10", Offset = "0x5FE0C10", VA = "0x185FE1A10")]
	public IGIPFCFNCFA EMIDJNCBDOP(string BMIMCNPMKAE, string EKDDCPALANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5FE18E0", Offset = "0x5FE0AE0", VA = "0x185FE18E0")]
	private IGIPFCFNCFA BJCDPNBEAOK(string BMIMCNPMKAE, object EKDDCPALANJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BPPDBHANKHI : IGIPFCFNCFA
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5FDCAB0", Offset = "0x5FDBCB0", VA = "0x185FDCAB0")]
	public BPPDBHANKHI(AmplitudeAnalyticsEvent FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5FDC910", Offset = "0x5FDBB10", VA = "0x185FDC910", Slot = "4")]
	public override void OBGACDADEDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class JPBCDOEKIDC<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : JPBCDOEKIDC<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M FFDOAJJEAOK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR LLJLCOGFAIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public JPBCDOEKIDC(M FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3C56860", Offset = "0x3C55A60", VA = "0x183C56860")]
	public BLDR MGGHFOMAONL(AmplitudeAnalyticsIdentifyMessage.DeviceInfo ABOAOAMLJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3C56810", Offset = "0x3C55A10", VA = "0x183C56810")]
	public BLDR IGIAMPFGHMP(AmplitudeAnalyticsIdentifyMessage.RevenueData ELMKNAHPOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3C567A0", Offset = "0x3C559A0", VA = "0x183C567A0")]
	public BLDR EHABDEDJMNJ(string BMIMCNPMKAE, string EKDDCPALANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x27AD5A0", Offset = "0x27AC7A0", VA = "0x1827AD5A0")]
	public BLDR EHABDEDJMNJ<T>(string BMIMCNPMKAE, T EKDDCPALANJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void OBGACDADEDJ();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3C568B0", Offset = "0x3C55AB0", VA = "0x183C568B0")]
	internal static string MJEJENLGBJM(string EKDDCPALANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3C568E0", Offset = "0x3C55AE0", VA = "0x183C568E0")]
	private BLDR PFCEBFGEFKL(string BMIMCNPMKAE, object EKDDCPALANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M PMNPBLFGDKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class PAKJECMMDGC : FFLAPLNODFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct GDFIFEIAMCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<PGFFELGBIHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public PAKJECMMDGC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5FE06F0", Offset = "0x5FDF8F0", VA = "0x185FE06F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0F80", Offset = "0x5FE0180", VA = "0x185FE0F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct AGDENNDAFMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<PGFFELGBIHH> <>t__builder;

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
		public PAKJECMMDGC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5FD2AE0", Offset = "0x5FD1CE0", VA = "0x185FD2AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3500", Offset = "0x5FD2700", VA = "0x185FD3500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient GKLCHFAFFGP;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3CB0", Offset = "0x5FE2EB0", VA = "0x185FE3CB0")]
	[BDCLMMIIFOD(CIJFMPALMOO.None)]
	private static void EJFFCPDPKBM(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3FE0", Offset = "0x5FE31E0", VA = "0x185FE3FE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PAKJECMMDGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3E90", Offset = "0x5FE3090", VA = "0x185FE3E90", Slot = "4")]
	[AsyncStateMachine(typeof(GDFIFEIAMCO))]
	public Task<PGFFELGBIHH> PBHICJLDPPC(string FJMENOKABAA, Dictionary<string, string> IAILFBDMMMK, bool OLAHDODEHHB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3D20", Offset = "0x5FE2F20", VA = "0x185FE3D20", Slot = "5")]
	[AsyncStateMachine(typeof(AGDENNDAFMI))]
	public Task<PGFFELGBIHH> OEPMFPBIEHI(string FJMENOKABAA, string HHIAGFIOHIA, string IFHAJIGOAFG, string KAIDHIOKIBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BEACDNGNDJE
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> NAFFBPIEAEK;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA7B0", Offset = "0x5FD99B0", VA = "0x185FDA7B0")]
	internal static bool NCAFDGDCJFI(string GHBNLDGJPCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FFLAPLNODFG
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PGFFELGBIHH> PBHICJLDPPC(string FJMENOKABAA, Dictionary<string, string> IAILFBDMMMK, bool OLAHDODEHHB = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<PGFFELGBIHH> OEPMFPBIEHI(string FJMENOKABAA, string HHIAGFIOHIA, string IFHAJIGOAFG, string KAIDHIOKIBE);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct PGFFELGBIHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int PJLJAIAGEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string ICFGMKMNDIB;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xC29F90", Offset = "0xC29190", VA = "0x180C29F90")]
	public PGFFELGBIHH(int FHKIOOODNCP, string NCIKEKDFIIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum OCEMCHBPAIP
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
public class CDDMDNDCCII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long GBOMLGBBEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private IGIPFCFNCFA HNBJGHGJBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool BDDOEBHFFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float KFHHDLLLOOA;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5FDD5E0", Offset = "0x5FDC7E0", VA = "0x185FDD5E0")]
	public CDDMDNDCCII(string LEGAFEDCJJF, float KFHHDLLLOOA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x26C5940", Offset = "0x26C4B40", VA = "0x1826C5940")]
	public void AKACGDJLAPB<T>(string BMIMCNPMKAE, T EKDDCPALANJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FDD250", Offset = "0x5FDC450", VA = "0x185FDD250")]
	public void AKACGDJLAPB(string BMIMCNPMKAE, string EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FDD2D0", Offset = "0x5FDC4D0", VA = "0x185FDD2D0")]
	public void BDHHOBDCCDE(string JEPNECDFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5FDD3C0", Offset = "0x5FDC5C0", VA = "0x185FDD3C0")]
	public void CJPGOEEOMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5FDD4D0", Offset = "0x5FDC6D0", VA = "0x185FDD4D0")]
	private void JDBJBKILLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5FDD480", Offset = "0x5FDC680", VA = "0x185FDD480")]
	private bool EBMDIGLJACE()
	{
		return default(bool);
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum IHDMDCNBNAK
		{
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			String,
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			Bool
		}

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
		private IHDMDCNBNAK parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IHDMDCNBNAK Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x95D910", Offset = "0x95CB10", VA = "0x18095D910")]
			get
			{
				return default(IHDMDCNBNAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x880780", Offset = "0x87F980", VA = "0x180880780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5FE4600", Offset = "0x5FE3800", VA = "0x185FE4600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class DGKJHEPFAFB : DCLDDFNAFDD, AEOJOEOHBIC
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void BPJLALEABHG(HBCJGINDEBM KFMKOLFMHLE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly ALCMOAMGBMH PIIFEKOIILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly BPJLALEABHG OGJDGNOIIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly string GCMEBLNKHCM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string KHAGCMDBGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x10B2110", Offset = "0x10B1310", VA = "0x1810B2110", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LJNNBIAHAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF0F0", Offset = "0x5FDE2F0", VA = "0x185FDF0F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HJEKGHEFHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF110", Offset = "0x5FDE310", VA = "0x185FDF110", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> GDMBOGADAHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x10B2200", Offset = "0x10B1400", VA = "0x1810B2200", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5FDF130", Offset = "0x5FDE330", VA = "0x185FDF130")]
	public DGKJHEPFAFB(ALCMOAMGBMH JDOEDLEPGFL, string GNAEFGDJFCN, [Optional] BPJLALEABHG BGJIIMBGIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x271F3D0", Offset = "0x271E5D0", VA = "0x18271F3D0", Slot = "8")]
	public T CEIMJGKDJPN<T>(string GHBNLDGJPCB, T LKGDLFBLIFL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class BNLPBDEJMIF : GJGMEPPNEHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct EBBONAKOIGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public BNLPBDEJMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public KALDHBEDLBO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF320", Offset = "0x5FDE520", VA = "0x185FDF320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF7A0", Offset = "0x5FDE9A0", VA = "0x185FDF7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct EMHGLKGJCOO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF800", Offset = "0x5FDEA00", VA = "0x185FDF800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFA10", Offset = "0x5FDEC10", VA = "0x185FDFA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct EMIHBCPBFHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public BNLPBDEJMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public KALDHBEDLBO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFA70", Offset = "0x5FDEC70", VA = "0x185FDFA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFD30", Offset = "0x5FDEF30", VA = "0x185FDFD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct PGNGNFEEDNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public BNLPBDEJMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public KALDHBEDLBO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE4060", Offset = "0x5FE3260", VA = "0x185FE4060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5FE4430", Offset = "0x5FE3630", VA = "0x185FE4430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly IReadOnlyDictionary<string, ENEDPHENHCN> IKDIIJBHCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool ALPECAMGPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private DGIBPFNHMEK LNPPIPBEKEI;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool HKJFMKICGME
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x806F10", Offset = "0x806110", VA = "0x180806F10", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string HGJMNICOFFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5FDBB70", Offset = "0x5FDAD70", VA = "0x185FDBB70", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public ENIEPNOLIFN BIHOADMLMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5FDC710", Offset = "0x5FDB910", VA = "0x185FDC710", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KIHEDJCDKID
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5FDBB80", Offset = "0x5FDAD80", VA = "0x185FDBB80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5FDAF20", Offset = "0x5FDA120", VA = "0x185FDAF20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IKAOALPCIGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5FDBAD0", Offset = "0x5FDACD0", VA = "0x185FDBAD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5FDAC90", Offset = "0x5FD9E90", VA = "0x185FDAC90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<HBCJGINDEBM> KGBBNGKCDIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5FDC660", Offset = "0x5FDB860", VA = "0x185FDC660", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5FDC3E0", Offset = "0x5FDB5E0", VA = "0x185FDC3E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5FDC490", Offset = "0x5FDB690", VA = "0x185FDC490", Slot = "10")]
	[AsyncStateMachine(typeof(EBBONAKOIGE))]
	public Task MEJEOBIHPJE(string JMGDHKIBOAC, string KLEKIFCKLDI, [Optional] KALDHBEDLBO BGOGLKENJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5FDBA20", Offset = "0x5FDAC20", VA = "0x185FDBA20", Slot = "19")]
	[AsyncStateMachine(typeof(EMHGLKGJCOO))]
	public Task EKKAHFJJLHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB930", Offset = "0x5FDAB30", VA = "0x185FDB930", Slot = "14")]
	[AsyncStateMachine(typeof(EMIHBCPBFHE))]
	public Task EEPLPEACEBL(KALDHBEDLBO BGOGLKENJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5FDC110", Offset = "0x5FDB310", VA = "0x185FDC110", Slot = "15")]
	[AsyncStateMachine(typeof(PGNGNFEEDNB))]
	public Task LHPCKPAIBNK(KALDHBEDLBO BGOGLKENJDE, Dictionary<string, string> PKHMBALADFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5FDC5D0", Offset = "0x5FDB7D0", VA = "0x185FDC5D0", Slot = "16")]
	public bool OEBDNKOICPP(string MCGNAGBFOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5FDBCB0", Offset = "0x5FDAEB0", VA = "0x185FDBCB0", Slot = "17")]
	public DCLDDFNAFDD IONDBNFENBD(string GNAEFGDJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5FDC220", Offset = "0x5FDB420", VA = "0x185FDC220")]
	private ALCMOAMGBMH LPIFIDGKAFO(string GNAEFGDJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAD30", Offset = "0x5FD9F30", VA = "0x185FDAD30", Slot = "18")]
	public JLEAPCEBEFI BMCAMBPMAKI(string IDHFBKNOFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5FDBC20", Offset = "0x5FDAE20", VA = "0x185FDBC20")]
	private KJHCLJMODEJ IENMLFAFOPE(string IDHFBKNOFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAFC0", Offset = "0x5FDA1C0", VA = "0x185FDAFC0")]
	private CLKGCELIFDD DFFBANNGEOE(KALDHBEDLBO BGOGLKENJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5FDBF70", Offset = "0x5FDB170", VA = "0x185FDBF70")]
	private FPFAIGGEOCN KCBCALFEGNG(string KLEKIFCKLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5FDBE60", Offset = "0x5FDB060", VA = "0x185FDBE60")]
	private void JMIHPNJFGNC(string GNAEFGDJFCN, ALCMOAMGBMH JDOEDLEPGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BNLPBDEJMIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAEE0", Offset = "0x5FDA0E0", VA = "0x185FDAEE0")]
	[CompilerGenerated]
	private void PFPKPKPGGPD(HBCJGINDEBM COLCKPIEBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAEE0", Offset = "0x5FDA0E0", VA = "0x185FDAEE0")]
	[CompilerGenerated]
	private void CLFHFEGMOAM(HBCJGINDEBM COLCKPIEBCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class KENPEEKJIIC : GJGMEPPNEHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JNPMENOHNCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public KENPEEKJIIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public KALDHBEDLBO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1E40", Offset = "0x5FE1040", VA = "0x185FE1E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2590", Offset = "0x5FE1790", VA = "0x185FE2590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private GJGMEPPNEHB EPGJEDGJFMN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private GJGMEPPNEHB PGAIFKPODHO
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE27B0", Offset = "0x5FE19B0", VA = "0x185FE27B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HKJFMKICGME
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5FE3260", Offset = "0x5FE2460", VA = "0x185FE3260", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string HGJMNICOFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2D40", Offset = "0x5FE1F40", VA = "0x185FE2D40", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ENIEPNOLIFN BIHOADMLMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE3410", Offset = "0x5FE2610", VA = "0x185FE3410", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action KIHEDJCDKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2D90", Offset = "0x5FE1F90", VA = "0x185FE2D90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2970", Offset = "0x5FE1B70", VA = "0x185FE2970", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action IKAOALPCIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2C30", Offset = "0x5FE1E30", VA = "0x185FE2C30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2820", Offset = "0x5FE1A20", VA = "0x185FE2820", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<HBCJGINDEBM> KGBBNGKCDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5FE3360", Offset = "0x5FE2560", VA = "0x185FE3360", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5FE3070", Offset = "0x5FE2270", VA = "0x185FE3070", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	[UnityEngine.Scripting.Preserve]
	public KENPEEKJIIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3000", Offset = "0x5FE2200", VA = "0x185FE3000")]
	[BDCLMMIIFOD(CIJFMPALMOO.GameOnly)]
	private static void MAIBGIMLEBL(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2CD0", Offset = "0x5FE1ED0", VA = "0x185FE2CD0")]
	[BDCLMMIIFOD(CIJFMPALMOO.EditorOnly)]
	private static void FGEDNLLGMDJ(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3120", Offset = "0x5FE2320", VA = "0x185FE3120", Slot = "10")]
	[AsyncStateMachine(typeof(JNPMENOHNCJ))]
	public Task MEJEOBIHPJE(string JMGDHKIBOAC, string KLEKIFCKLDI, [Optional] KALDHBEDLBO BGOGLKENJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2A10", Offset = "0x5FE1C10", VA = "0x185FE2A10", Slot = "14")]
	public Task EEPLPEACEBL(KALDHBEDLBO BGOGLKENJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2EE0", Offset = "0x5FE20E0", VA = "0x185FE2EE0", Slot = "15")]
	public Task LHPCKPAIBNK(KALDHBEDLBO BGOGLKENJDE, Dictionary<string, string> PKHMBALADFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE32B0", Offset = "0x5FE24B0", VA = "0x185FE32B0", Slot = "16")]
	public bool OEBDNKOICPP(string MCGNAGBFOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2E30", Offset = "0x5FE2030", VA = "0x185FE2E30", Slot = "17")]
	public DCLDDFNAFDD IONDBNFENBD(string GNAEFGDJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5FE28C0", Offset = "0x5FE1AC0", VA = "0x185FE28C0", Slot = "18")]
	public JLEAPCEBEFI BMCAMBPMAKI(string IDHFBKNOFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2B20", Offset = "0x5FE1D20", VA = "0x185FE2B20", Slot = "19")]
	public Task EKKAHFJJLHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x800480", Offset = "0x7FF680", VA = "0x180800480")]
	[CompilerGenerated]
	private void HHFPHOIBHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x825F40", Offset = "0x825140", VA = "0x180825F40")]
	[CompilerGenerated]
	private void BBNCHINCHED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAEE0", Offset = "0x5FDA0E0", VA = "0x185FDAEE0")]
	[CompilerGenerated]
	private void DDOAKJOLBPA(HBCJGINDEBM COLCKPIEBCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal class HGDFEJOICLL : JLEAPCEBEFI, AEOJOEOHBIC
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate void HENKBLOBPFH(HBCJGINDEBM KFMKOLFMHLE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly HENKBLOBPFH OGJDGNOIIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly KJHCLJMODEJ LJPPCMJHNGC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string KHAGCMDBGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1A714E0", Offset = "0x1A706E0", VA = "0x181A714E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5386EF0", Offset = "0x53860F0", VA = "0x185386EF0")]
	public HGDFEJOICLL(KJHCLJMODEJ OCLMGFCPPDD, [Optional] HENKBLOBPFH BGJIIMBGIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x28A9EB0", Offset = "0x28A90B0", VA = "0x1828A9EB0", Slot = "5")]
	public T CEIMJGKDJPN<T>(string GHBNLDGJPCB, T LKGDLFBLIFL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface MAKCKGBJGDL
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BLLNKDHDIPL(string GNAEFGDJFCN, string POHLCAKNDPC);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[UsedImplicitly]
public class CDJPBJHKOGO : MAKCKGBJGDL
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class BMCIAOBNCAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public string parameterName;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public BMCIAOBNCAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5FDAC20", Offset = "0x5FD9E20", VA = "0x185FDAC20")]
		internal bool NKHAJGIBGEG(PEIHHDPFPHK o)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly PIILAPIMAKD NGJBFELPPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly List<PEIHHDPFPHK> HANHMFCDLEI;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5FDD770", Offset = "0x5FDC970", VA = "0x185FDD770")]
	[UsedImplicitly]
	[BDCLMMIIFOD(AILNDCKFLHJ.Root, CIJFMPALMOO.GameOnly)]
	private static void AMDCJFPBGPG(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5FDD8E0", Offset = "0x5FDCAE0", VA = "0x185FDD8E0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CDJPBJHKOGO([MINIJLJAKNC(null)][NotNull] PIILAPIMAKD NGJBFELPPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5FDD7E0", Offset = "0x5FDC9E0", VA = "0x185FDD7E0", Slot = "4")]
	public bool BLLNKDHDIPL(string GNAEFGDJFCN, string POHLCAKNDPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class LHIPFCGHBGB : GJGMEPPNEHB
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HKJFMKICGME
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string HGJMNICOFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public ENIEPNOLIFN BIHOADMLMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action KIHEDJCDKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5FE3860", Offset = "0x5FE2A60", VA = "0x185FE3860", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5FE3600", Offset = "0x5FE2800", VA = "0x185FE3600", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action IKAOALPCIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5FE37C0", Offset = "0x5FE29C0", VA = "0x185FE37C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5FE34D0", Offset = "0x5FE26D0", VA = "0x185FE34D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<HBCJGINDEBM> KGBBNGKCDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5FE3B80", Offset = "0x5FE2D80", VA = "0x185FE3B80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5FE3A40", Offset = "0x5FE2C40", VA = "0x185FE3A40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LHIPFCGHBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3AF0", Offset = "0x5FE2CF0", VA = "0x185FE3AF0", Slot = "10")]
	public Task MEJEOBIHPJE(string JMGDHKIBOAC, string KLEKIFCKLDI, [Optional] KALDHBEDLBO BGOGLKENJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE36A0", Offset = "0x5FE28A0", VA = "0x185FE36A0", Slot = "14")]
	public Task EEPLPEACEBL(KALDHBEDLBO BGOGLKENJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE39B0", Offset = "0x5FE2BB0", VA = "0x185FE39B0", Slot = "15")]
	public Task LHPCKPAIBNK(KALDHBEDLBO BGOGLKENJDE, Dictionary<string, string> PKHMBALADFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "16")]
	public bool OEBDNKOICPP(string MCGNAGBFOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3900", Offset = "0x5FE2B00", VA = "0x185FE3900", Slot = "17")]
	public DCLDDFNAFDD IONDBNFENBD(string GNAEFGDJFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3570", Offset = "0x5FE2770", VA = "0x185FE3570", Slot = "18")]
	public JLEAPCEBEFI BMCAMBPMAKI(string IDHFBKNOFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3730", Offset = "0x5FE2930", VA = "0x185FE3730", Slot = "19")]
	public Task EKKAHFJJLHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class DGIBPFNHMEK : ENIEPNOLIFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly CLKGCELIFDD LNPPIPBEKEI;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IReadOnlyDictionary<string, object> PEPEFHKBGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x10B2460", Offset = "0x10B1660", VA = "0x1810B2460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public DGIBPFNHMEK(CLKGCELIFDD EIMFHBKGJAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IGCINOGFDMB
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CDDMDNDCCII HLHJIAAKJAE(string LEGAFEDCJJF);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IIEKHPEDJHI
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum AMHNKDJGDFO
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	long FFGGFEIIPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string FMCBLCFOIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string OFLBAMMOFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string ODJHHKKPMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string CDGIGOGJDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool KDCPDFDIOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long OBILJJFNPHO();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AOLHAOHBNMI(long OLAALDHHLHB, bool ABGMHPBGLJB = true);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FAMILIEDBBA(string DPGBKIGAHAN, string NDCLOLBBPLE, string AGAAENEIJGP);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HAHAJGJHHOA(string DPGBKIGAHAN);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MLIFDDIIKCK(string DPGBKIGAHAN, string GIPDPANLLEI, string HEIKHBKNHCG);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HIEPDIDPOHP(string EEGPHDBPPJO, object BOMHJEMCMLO, object NLCANBNFPMM);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PHMIMOJNMBK(AMHNKDJGDFO OLPANEHHCFD, int PBDMEIFOAHD, [Optional] CADLAGEAGBI JDLKJFEFCAH, [Optional] string MAFJJHKCHME, [Optional] string AABEEDLKHEA);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CDEJLOPJOGC(CADLAGEAGBI JDLKJFEFCAH, long COMCAAIKJLK, long IDDOGOJFKJF, int BHADJJIPIAF, string MAFJJHKCHME, int PBDMEIFOAHD);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AIBEFCOBDBK(CADLAGEAGBI JDLKJFEFCAH, bool AKGAGOOFDNB, [Optional] string AABEEDLKHEA);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DCJGAPOCBHA(CADLAGEAGBI JDLKJFEFCAH, bool AKGAGOOFDNB, [Optional] string AABEEDLKHEA);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OGMKNGPOADE(CADLAGEAGBI JDLKJFEFCAH, bool AKGAGOOFDNB, [Optional] string AABEEDLKHEA);
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
