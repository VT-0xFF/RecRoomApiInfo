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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5BD49A0", Offset = "0x5BD31A0", VA = "0x185BD49A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C360", Offset = "0x78AB60", VA = "0x18078C360")]
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
		public AmplitudeAnalyticsClient.Settings HJACGOJJNKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IAMLCOOBPAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x762AD0", Offset = "0x7612D0", VA = "0x180762AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum CLFMLCAOMKI
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class HFFCPJIELLG
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class KHGBGDPOADF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000046")]
				public int AJACHLOLFFB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public Dictionary<string, object> AOAIDGONIAO;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
				public KHGBGDPOADF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class HEMBLFHLKNE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
				public HEMBLFHLKNE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5BCF6A0", Offset = "0x5BCDEA0", VA = "0x185BCF6A0")]
				internal bool BFHNMJFAKNL(KHGBGDPOADF item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private const string IMGEIPMGDJA = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private readonly string OMHPAGCEPHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private List<KHGBGDPOADF> BPLGGNJNIHC;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? GBDOLMBIPOA
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5BD01E0", Offset = "0x5BCE9E0", VA = "0x185BD01E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5BD09D0", Offset = "0x5BCF1D0", VA = "0x185BD09D0")]
			internal HFFCPJIELLG(string LKKCJLPGCCN, string HPHIDKFALLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5BCFC10", Offset = "0x5BCE410", VA = "0x185BCFC10")]
			public int EICOOHJLOCF([Optional] int? FFIFINFEJEK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5BCFF70", Offset = "0x5BCE770", VA = "0x185BCFF70")]
			public List<Dictionary<string, object>> HFBKMFENAEN(int PDBJHFJODPI, int? FFIFINFEJEK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5BCFDC0", Offset = "0x5BCE5C0", VA = "0x185BCFDC0")]
			public void GIIOPGICNCG(AmplitudeAnalyticsIdentifyMessage ELOCHLKHPBP, bool DDFBFDDBPHJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5BCFE60", Offset = "0x5BCE660", VA = "0x185BCFE60")]
			public void GIIOPGICNCG(Dictionary<string, object> ELOCHLKHPBP, bool DDFBFDDBPHJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5BCF710", Offset = "0x5BCDF10", VA = "0x185BCF710")]
			public void AIOMILLMFOC(params Dictionary<string, object>[] EIAHDOGBPII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5BD0780", Offset = "0x5BCEF80", VA = "0x185BD0780")]
			public void LAJDHPGDBPN(List<Dictionary<string, object>> EAFINPLDFGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5BD0670", Offset = "0x5BCEE70", VA = "0x185BD0670")]
			private void JLPANECDGPJ(Dictionary<string, object> ELOCHLKHPBP, bool DDFBFDDBPHJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5BCF8A0", Offset = "0x5BCE0A0", VA = "0x185BCF8A0")]
			public void AMPFJKBCLLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5BD0280", Offset = "0x5BCEA80", VA = "0x185BD0280")]
			private void JLMPPCAMIAD([Optional] string NMLIEDFGFAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5BCFAE0", Offset = "0x5BCE2E0", VA = "0x185BCFAE0")]
			private static string CLAHNHOMEIA(string IFKKLLBODIE, string EBICOEDOGKC)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5BD5610", Offset = "0x5BD3E10", VA = "0x185BD5610")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct NDBOHACAOIM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int JIGGEGIKCKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public string IMAFGAOKIEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public T ALJKEPLBMFI;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HLLIBJGLMOE : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private JCNDEIPBHJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
			[DebuggerHidden]
			public HLLIBJGLMOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5BD0B60", Offset = "0x5BCF360", VA = "0x185BD0B60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5BD1320", Offset = "0x5BCFB20", VA = "0x185BD1320", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class CFLHOPKIDBO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public MPIIFDIEJMJ quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
			[DebuggerHidden]
			public CFLHOPKIDBO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE2B0", Offset = "0x5BCCAB0", VA = "0x185BCE2B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE3C0", Offset = "0x5BCCBC0", VA = "0x185BCE3C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class DLNGGDACBEA : IEnumerator<object>, IEnumerator, IDisposable
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
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
			[DebuggerHidden]
			public DLNGGDACBEA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE410", Offset = "0x5BCCC10", VA = "0x185BCE410", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE580", Offset = "0x5BCCD80", VA = "0x185BCE580", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class AAHNCOCHEGL : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private JCNDEIPBHJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
			[DebuggerHidden]
			public AAHNCOCHEGL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5BC6EA0", Offset = "0x5BC56A0", VA = "0x185BC6EA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5BC7120", Offset = "0x5BC5920", VA = "0x185BC7120", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class JMIJEKILHKP : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private JCNDEIPBHJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
			[DebuggerHidden]
			public JMIJEKILHKP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5BD1520", Offset = "0x5BCFD20", VA = "0x185BD1520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5BD17B0", Offset = "0x5BCFFB0", VA = "0x185BD17B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class GDAAEIAFGJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public HFFCPJIELLG cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public GDAAEIAFGJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5BCED30", Offset = "0x5BCD530", VA = "0x185BCED30")]
			internal void DEGNKKAAPGP(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5BCF050", Offset = "0x5BCD850", VA = "0x185BCF050")]
			internal void DLMLOLIBIEO(NDBOHACAOIM<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class MOLFPHEHFHJ : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private JCNDEIPBHJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public HFFCPJIELLG cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private GDAAEIAFGJE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
			[DebuggerHidden]
			public MOLFPHEHFHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5BD33F0", Offset = "0x5BD1BF0", VA = "0x185BD33F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5BD3C40", Offset = "0x5BD2440", VA = "0x185BD3C40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class FOAAJOFLGLH<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public FOAAJOFLGLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x33B5AC0", Offset = "0x33B42C0", VA = "0x1833B5AC0")]
			internal NDBOHACAOIM<T> LILDBONGCJJ(HPCGIBOENPM postResponse)
			{
				return default(NDBOHACAOIM<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class MJGFINFHJHM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public MJGFINFHJHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x33B5AC0", Offset = "0x33B42C0", VA = "0x1833B5AC0")]
			internal NDBOHACAOIM<T> EPCIKFNPICA(HPCGIBOENPM postResponse)
			{
				return default(NDBOHACAOIM<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private NIHIPDEEGMN JFBOGDKCHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<NILKMOJJKII> PGNJKPKJDCJ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string NFIPEOBFKLH = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string JNMNKOMMKON = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string FJHNNEIMBHA = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int FACIIGKPLKC = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int JBEBINJOHBN = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int JHJPDLKNHHB = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float EJBICNJNPID = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long NPHEHPIDANH = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string PGFJEDAGNNI = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string BAGIBLJAODC = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool PGLCBDAIINO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool ELNHBDKHKMP;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int GOPIGGPBMKF;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int EEGCDNABOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private MFKCHMLIIKD KGBAFGPBMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private GBPIJPMGOOG NKAPGFFCCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool ENFBDPIHOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private float PFEPFHBBDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float NMALCAJJIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int AKMBHGJDHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int JFBHOIJABJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int? GICEIPOPCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? LLPLBLJAJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private long EGJIHFFKJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private string HCGMJKLIJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool FOEFCKDMPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long JBNOPEKNKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string KKPMGHFGNNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string IFKEMLCMNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Dictionary<string, object> BKJEEFCANFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private CLFMLCAOMKI NFPGGFJBLGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int AFMEHNGECEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int KEPJPIOKLLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private float GLFKJGKMJLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool IDLKMEKDMEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool MJKBIGCMPAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private HFFCPJIELLG ACFDJALNADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private HFFCPJIELLG DDHOMLCFMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private HFFCPJIELLG BHJIHOCAADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> PCFFPCLOBHP;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo DKGPHBIBCGH;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static string EEKPDFKKGBP;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const string AIGFHPKKNPC = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string KIAJHDIKKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string ILHJBEIFMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string CCACFLHBCFJ;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private NIHIPDEEGMN BILDAPADDHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5BC7CC0", Offset = "0x5BC64C0", VA = "0x185BC7CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private NILKMOJJKII LGGBLBEGKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5BC7250", Offset = "0x5BC5A50", VA = "0x185BC7250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int OHPLAHMJGDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5BC9C30", Offset = "0x5BC8430", VA = "0x185BC9C30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long BLGFJBGPLMN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5BCCB20", Offset = "0x5BCB320", VA = "0x185BCCB20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5BCCC30", Offset = "0x5BCB430", VA = "0x185BCCC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string PGELDFNOFOB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5BCCAC0", Offset = "0x5BCB2C0", VA = "0x185BCCAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string LKEHBNKCKON
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5BCCAF0", Offset = "0x5BCB2F0", VA = "0x185BCCAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LEKDOLKIGOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7DA8B0", Offset = "0x7D90B0", VA = "0x1807DA8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7DA8C0", Offset = "0x7D90C0", VA = "0x1807DA8C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? LFPFIMHBGJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8B66C0", Offset = "0x8B4EC0", VA = "0x1808B66C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x10C7250", Offset = "0x10C5A50", VA = "0x1810C7250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NEOANFHBPEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x93B2E0", Offset = "0x939AE0", VA = "0x18093B2E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xE5C940", Offset = "0xE5B140", VA = "0x180E5C940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool FIMCNNJOEDM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5BCC9C0", Offset = "0x5BCB1C0", VA = "0x185BCC9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> MMCLCMJBJCK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5BCC900", Offset = "0x5BCB100", VA = "0x185BCC900")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5BCCB70", Offset = "0x5BCB370", VA = "0x185BCCB70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5BC7410", Offset = "0x5BC5C10", VA = "0x185BC7410", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5BC7D30", Offset = "0x5BC6530", VA = "0x185BC7D30")]
		private void DMHKDKBDHIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5BCBEE0", Offset = "0x5BCA6E0", VA = "0x185BCBEE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5BCB0B0", Offset = "0x5BC98B0", VA = "0x185BCB0B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC280", Offset = "0x5BCAA80", VA = "0x185BCC280")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5BCB180", Offset = "0x5BC9980", VA = "0x185BCB180")]
		public DFJLMOHJECJ PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA360", Offset = "0x5BC8B60", VA = "0x185BCA360")]
		[IteratorStateMachine(typeof(HLLIBJGLMOE))]
		public IEnumerator<JCNDEIPBHJP> Initialize(AmplitudeAnalyticsEvent KEMPANNOBKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC1C0", Offset = "0x5BCA9C0", VA = "0x185BCC1C0")]
		public void UpdateLastKnownInteractionCategory(string JADBLCDJOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC0D0", Offset = "0x5BCA8D0", VA = "0x185BCC0D0")]
		public void UpdateLastAliveTime(float DBACBIFMKHN = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5BC9E10", Offset = "0x5BC8610", VA = "0x185BC9E10")]
		private DFJLMOHJECJ HKOKHKLNABA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5BC7770", Offset = "0x5BC5F70", VA = "0x185BC7770")]
		private DFJLMOHJECJ BMOIJBPJAJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5BCB930", Offset = "0x5BCA130", VA = "0x185BCB930")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5BCB020", Offset = "0x5BC9820", VA = "0x185BCB020")]
		[IteratorStateMachine(typeof(CFLHOPKIDBO))]
		private IEnumerator MPMCHGAAOGB(MPIIFDIEJMJ OGFJCIENCPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC510", Offset = "0x5BCAD10", VA = "0x185BCC510")]
		[IteratorStateMachine(typeof(DLNGGDACBEA))]
		public IEnumerator WaitForFlush(float EMAKFGFOEMJ = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5BCBFB0", Offset = "0x5BCA7B0", VA = "0x185BCBFB0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5BCBEF0", Offset = "0x5BCA6F0", VA = "0x185BCBEF0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime OBAHCJJDGLP)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5BC9ED0", Offset = "0x5BC86D0", VA = "0x185BC9ED0")]
		public static FIECGEHFMDN Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5BC72A0", Offset = "0x5BC5AA0", VA = "0x185BC72A0")]
		public static PPNIKBNBGEF AccountSelectionPostLoginEvent([NotNull] string JAGKCFLBLDJ, string ELEMKMJCNDO, bool DHIJLDLKFEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5BC89A0", Offset = "0x5BC71A0", VA = "0x185BC89A0")]
		public static PPNIKBNBGEF Event([NotNull] string JAGKCFLBLDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5BCB1C0", Offset = "0x5BC99C0", VA = "0x185BCB1C0")]
		public static PPNIKBNBGEF PreviousSessionEvent([NotNull] string JAGKCFLBLDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA080", Offset = "0x5BC8880", VA = "0x185BCA080")]
		public static PPNIKBNBGEF InitializeEvent(string ELEMKMJCNDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5BCBAF0", Offset = "0x5BCA2F0", VA = "0x185BCBAF0")]
		public static PPNIKBNBGEF StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5BC7A60", Offset = "0x5BC6260", VA = "0x185BC7A60")]
		public static PPNIKBNBGEF CreateOutOfSessionEvent(string JAGKCFLBLDJ, bool LEAPDEMIBDD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA860", Offset = "0x5BC9060", VA = "0x185BCA860")]
		public static DFJLMOHJECJ LogOutOfSessionEvent(PPNIKBNBGEF FEHGNDKPABB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA5E0", Offset = "0x5BC8DE0", VA = "0x185BCA5E0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent FAGNHOIMIPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5BCAB50", Offset = "0x5BC9350", VA = "0x185BCAB50")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent FAGNHOIMIPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5BCAC90", Offset = "0x5BC9490", VA = "0x185BCAC90")]
		public void LogSerializedEventAsync(Dictionary<string, object> EHKHPEBEEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA720", Offset = "0x5BC8F20", VA = "0x185BCA720")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage KEAHFIOCOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5BC9990", Offset = "0x5BC8190", VA = "0x185BC9990")]
		private void FOGDNMCNDHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5BCAD70", Offset = "0x5BC9570", VA = "0x185BCAD70")]
		private void MNMPDFOMBFO(Dictionary<string, object> EANDJFCDJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5BC98A0", Offset = "0x5BC80A0", VA = "0x185BC98A0")]
		private void FGGIMOEFFKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5BC87D0", Offset = "0x5BC6FD0", VA = "0x185BC87D0")]
		private void EOICFBCLILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5BC9A90", Offset = "0x5BC8290", VA = "0x185BC9A90")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5BC7170", Offset = "0x5BC5970", VA = "0x185BC7170")]
		[IteratorStateMachine(typeof(AAHNCOCHEGL))]
		private IEnumerator<JCNDEIPBHJP> ALMELMKGCGC(float EMAKFGFOEMJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA3F0", Offset = "0x5BC8BF0", VA = "0x185BCA3F0")]
		[IteratorStateMachine(typeof(JMIJEKILHKP))]
		private IEnumerator<JCNDEIPBHJP> JEOJLNLHHDD(float EMAKFGFOEMJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5BC82D0", Offset = "0x5BC6AD0", VA = "0x185BC82D0")]
		[IteratorStateMachine(typeof(MOLFPHEHFHJ))]
		private IEnumerator<JCNDEIPBHJP> EMCOEFIAJEC(HFFCPJIELLG PBBLGCKBEBB, int? FFIFINFEJEK, string FAKHHJDOAHB, string NKJCIAFOELA, float EMAKFGFOEMJ, Action<int> NMBAGFPLFJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5BC9B20", Offset = "0x5BC8320", VA = "0x185BC9B20")]
		private static void HCIBLMHPFKE(bool AMHPKGGFJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5BC83D0", Offset = "0x5BC6BD0", VA = "0x185BC83D0")]
		private FNFCBJEHDPL<NDBOHACAOIM<Dictionary<string, object>>> EOHFKDGJODC(string FAKHHJDOAHB, string NKJCIAFOELA, string AEIKOGKJBKH, string JBPJEPCOKOC, Dictionary<string, object> ALJKEPLBMFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5BC84F0", Offset = "0x5BC6CF0", VA = "0x185BC84F0")]
		private FNFCBJEHDPL<NDBOHACAOIM<List<Dictionary<string, object>>>> EOHFKDGJODC(string FAKHHJDOAHB, string NKJCIAFOELA, string AEIKOGKJBKH, string JBPJEPCOKOC, List<Dictionary<string, object>> ALJKEPLBMFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x29FB0F0", Offset = "0x29F98F0", VA = "0x1829FB0F0")]
		private FNFCBJEHDPL<NDBOHACAOIM<T>> OGJEMLMDGON<T>(string FAKHHJDOAHB, string NKJCIAFOELA, string JBPJEPCOKOC, T ALJKEPLBMFI, Dictionary<string, object> ILBKBCKDCHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x29FADC0", Offset = "0x29F95C0", VA = "0x1829FADC0")]
		private FNFCBJEHDPL<NDBOHACAOIM<T>> GOEPLPBBCMG<T>(string FAKHHJDOAHB, string NKJCIAFOELA, string AEIKOGKJBKH, T ALJKEPLBMFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5BC7200", Offset = "0x5BC5A00", VA = "0x185BC7200")]
		private bool ANALEEHKILL(float JHOEGDEHLMP, float EMAKFGFOEMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5BC8BD0", Offset = "0x5BC73D0", VA = "0x185BC8BD0")]
		private Dictionary<string, object> FBAIMGPCIMN(string NKJCIAFOELA, Dictionary<string, object> ALJKEPLBMFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC600", Offset = "0x5BCAE00", VA = "0x185BCC600")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA480", Offset = "0x5BC8C80", VA = "0x185BCA480")]
		[CompilerGenerated]
		private long LEFLPMDHLMG()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5BCB170", Offset = "0x5BC9970", VA = "0x185BCB170")]
		[CompilerGenerated]
		private void PILGBHMMJNG(int HKAKBFONFLF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly bool isBrazeUser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD990", Offset = "0x5BCC190", VA = "0x185BCD990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5BCDA70", Offset = "0x5BCC270", VA = "0x185BCDA70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD9D0", Offset = "0x5BCC1D0", VA = "0x185BCD9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5BCDAD0", Offset = "0x5BCC2D0", VA = "0x185BCDAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD950", Offset = "0x5BCC150", VA = "0x185BCD950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5BCDA10", Offset = "0x5BCC210", VA = "0x185BCDA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x762AB0", Offset = "0x7612B0", VA = "0x180762AB0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD540", Offset = "0x5BCBD40", VA = "0x185BCD540")]
		public static PPNIKBNBGEF GFPEABNIECK(string OJAHFIICKFC, [NotNull] string CEIJCNCAKII, long MINEIKHPFOJ, long LLAMDFPLIBO, string ELEMKMJCNDO, bool DHIJLDLKFEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD3E0", Offset = "0x5BCBBE0", VA = "0x185BCD3E0")]
		public static PPNIKBNBGEF FKDMBEOBLJE(string OJAHFIICKFC, [NotNull] string CEIJCNCAKII, long MINEIKHPFOJ, long LLAMDFPLIBO, string ELEMKMJCNDO, long GMCEEPLODLN, bool DHIJLDLKFEK, string MGNGMCPNHKB, string DGOBKKJMPAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD7C0", Offset = "0x5BCBFC0", VA = "0x185BCD7C0")]
		private AmplitudeAnalyticsEvent(string OJAHFIICKFC, [NotNull] string CEIJCNCAKII, long MINEIKHPFOJ, long LLAMDFPLIBO, string ELEMKMJCNDO, bool DHIJLDLKFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x186FFC0", Offset = "0x186E7C0", VA = "0x18186FFC0")]
		public void BOLPPAPGJIC(long FKJBPPAJFMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD2D0", Offset = "0x5BCBAD0", VA = "0x185BCD2D0", Slot = "5")]
		public override void BLLHPCBKPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD640", Offset = "0x5BCBE40", VA = "0x185BCD640", Slot = "6")]
		public override void PMOGGKOIBOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5BCCC90", Offset = "0x5BCB490", VA = "0x185BCCC90", Slot = "4")]
		protected override Dictionary<string, object> BEFNGDDOHKK(Dictionary<string, object> EIFOEPKBHME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD1C0", Offset = "0x5BCB9C0", VA = "0x185BCD1C0")]
		private void BJMIJLHBAFP(string EBICOEDOGKC, string IFKKLLBODIE, bool EOKFAAHEMDB = false)
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
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE5D0", Offset = "0x5BCCDD0", VA = "0x185BCE5D0")]
			public void ECPOBIICIBI(Dictionary<string, object> LFKPKBKGJFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5BD52A0", Offset = "0x5BD3AA0", VA = "0x185BD52A0")]
			public void ECPOBIICIBI(Dictionary<string, object> DBNJLFOKNAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7F0510", Offset = "0x7EED10", VA = "0x1807F0510")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x762B90", Offset = "0x761390", VA = "0x180762B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5BCDF00", Offset = "0x5BCC700", VA = "0x185BCDF00")]
		public static FIECGEHFMDN GFPEABNIECK(string OJAHFIICKFC, string ELEMKMJCNDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE1F0", Offset = "0x5BCC9F0", VA = "0x185BCE1F0")]
		protected AmplitudeAnalyticsIdentifyMessage(string OJAHFIICKFC, string ELEMKMJCNDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE030", Offset = "0x5BCC830", VA = "0x185BCE030")]
		public Dictionary<string, object> KCEBKMIGCAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5BCDB30", Offset = "0x5BCC330", VA = "0x185BCDB30", Slot = "4")]
		protected virtual Dictionary<string, object> BEFNGDDOHKK(Dictionary<string, object> EIFOEPKBHME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE0C0", Offset = "0x5BCC8C0", VA = "0x185BCE0C0")]
		protected void KPKKDGDDGBK(string EBICOEDOGKC, Dictionary<string, object> JMKEAMOPOHL, Dictionary<string, object> FKIICGKDCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5BCDFC0", Offset = "0x5BCC7C0", VA = "0x185BCDFC0")]
		protected void HAEJNOFGFAJ(string EBICOEDOGKC, string IFKKLLBODIE, Dictionary<string, object> IHKDIBHLJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5BCDE70", Offset = "0x5BCC670", VA = "0x185BCDE70", Slot = "5")]
		public virtual void BLLHPCBKPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE160", Offset = "0x5BCC960", VA = "0x185BCE160", Slot = "6")]
		public virtual void PMOGGKOIBOI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FIECGEHFMDN : BOPHMDFABME<AmplitudeAnalyticsIdentifyMessage, FIECGEHFMDN>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override FIECGEHFMDN DJBCGGPGPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage PPHNHIDOFBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5BCECE0", Offset = "0x5BCD4E0", VA = "0x185BCECE0")]
	public FIECGEHFMDN(AmplitudeAnalyticsIdentifyMessage LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5BCEC30", Offset = "0x5BCD430", VA = "0x185BCEC30", Slot = "4")]
	public override void PMOGGKOIBOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PPNIKBNBGEF : BOPHMDFABME<AmplitudeAnalyticsEvent, PPNIKBNBGEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool EMCKEJPDJCL;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override PPNIKBNBGEF DJBCGGPGPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long PENCOIMHLPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1C21B70", Offset = "0x1C20370", VA = "0x181C21B70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5BCF650", Offset = "0x5BCDE50", VA = "0x185BCF650")]
	public PPNIKBNBGEF(AmplitudeAnalyticsEvent LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "5")]
	public override AmplitudeAnalyticsEvent PPHNHIDOFBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5BD5200", Offset = "0x5BD3A00", VA = "0x185BD5200", Slot = "4")]
	public override void PMOGGKOIBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2508A80", Offset = "0x2507280", VA = "0x182508A80")]
	public PPNIKBNBGEF EENCAEABCPL<T>(string OLJMCOBAMDO, T[] IFKKLLBODIE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2508A80", Offset = "0x2507280", VA = "0x182508A80")]
	public PPNIKBNBGEF EENCAEABCPL(string OLJMCOBAMDO, string[] IFKKLLBODIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x25087D0", Offset = "0x2506FD0", VA = "0x1825087D0")]
	public PPNIKBNBGEF EENCAEABCPL<T>(string OLJMCOBAMDO, T IFKKLLBODIE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5BD4FE0", Offset = "0x5BD37E0", VA = "0x185BD4FE0")]
	public PPNIKBNBGEF EENCAEABCPL(string OLJMCOBAMDO, long IFKKLLBODIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5BD4F70", Offset = "0x5BD3770", VA = "0x185BD4F70")]
	public PPNIKBNBGEF EENCAEABCPL(string OLJMCOBAMDO, string IFKKLLBODIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5BD4F40", Offset = "0x5BD3740", VA = "0x185BD4F40")]
	public PPNIKBNBGEF BJPNJBLFKHL(string OLJMCOBAMDO, object? IFKKLLBODIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5BD5160", Offset = "0x5BD3960", VA = "0x185BD5160")]
	public PPNIKBNBGEF JOBLFAHAGLJ(string OLJMCOBAMDO, string IFKKLLBODIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5BD5060", Offset = "0x5BD3860", VA = "0x185BD5060")]
	private PPNIKBNBGEF IIKPJGICBBO(string OLJMCOBAMDO, object IFKKLLBODIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GNOHCAAACBE : PPNIKBNBGEF
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5BCF650", Offset = "0x5BCDE50", VA = "0x185BCF650")]
	public GNOHCAAACBE(AmplitudeAnalyticsEvent LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5BCF4A0", Offset = "0x5BCDCA0", VA = "0x185BCF4A0", Slot = "4")]
	public override void PMOGGKOIBOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class BOPHMDFABME<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : BOPHMDFABME<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	protected M LACIBLEADOC;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR DJBCGGPGPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	public BOPHMDFABME(M LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4795D50", Offset = "0x4794550", VA = "0x184795D50")]
	public BLDR IFPCMHAKEDH(AmplitudeAnalyticsIdentifyMessage.DeviceInfo NMCCGJGFBEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4795DD0", Offset = "0x47945D0", VA = "0x184795DD0")]
	public BLDR OLLJMDDKHGN(AmplitudeAnalyticsIdentifyMessage.RevenueData KFLOCDDDAOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4795E20", Offset = "0x4794620", VA = "0x184795E20")]
	public BLDR PCODKFFBDIO(string OLJMCOBAMDO, string IFKKLLBODIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9C20", Offset = "0x2BE8420", VA = "0x182BE9C20")]
	public BLDR PCODKFFBDIO<T>(string OLJMCOBAMDO, T IFKKLLBODIE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PMOGGKOIBOI();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4795DA0", Offset = "0x47945A0", VA = "0x184795DA0")]
	internal static string IIFJKAKBCKD(string IFKKLLBODIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4795C50", Offset = "0x4794450", VA = "0x184795C50")]
	private BLDR HNOFMJIJBHI(string OLJMCOBAMDO, object IFKKLLBODIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M PPHNHIDOFBC();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JLMCFDEOBFO
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> JDBCIAJNDHH;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5BD1370", Offset = "0x5BCFB70", VA = "0x185BD1370")]
	internal static bool PPIDDBILMNA(string EBICOEDOGKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MFKCHMLIIKD
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool BJCBAODMEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string LGHFCGHJNOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	string OLDALHDCIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	string DJGPOEGPHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	string KBMOJDHGCGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FNFCBJEHDPL<HPCGIBOENPM> EOHFKDGJODC(string FAKHHJDOAHB, Dictionary<string, string> LBDHAMDJFKI, bool LHPHKOKMABI = false);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FNFCBJEHDPL<HPCGIBOENPM> OAJMLJOAEGD(string FAKHHJDOAHB, string HMAIDKKIKIG, string HNCNDKHHPJF, string OKJDDCJGBIG);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HPCGIBOENPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly int LMEBJGPCEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly string KOKANNPDFEP;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0xAB95B0", Offset = "0xAB7DB0", VA = "0x180AB95B0")]
	public HPCGIBOENPM(int JIGGEGIKCKL, string IMAFGAOKIEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum BPGOJMNMGOM
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	GameInvite
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class POPHFBBJCJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private long BKLFODDMAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private PPNIKBNBGEF KIBFNFGKBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool IKKNKBCPLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private float JDCHLAAAEBK;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5BD4DB0", Offset = "0x5BD35B0", VA = "0x185BD4DB0")]
	public POPHFBBJCJJ(string MFDALLIEHDG, float JDCHLAAAEBK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x25083A0", Offset = "0x2506BA0", VA = "0x1825083A0")]
	public void EENCAEABCPL<T>(string OLJMCOBAMDO, T IFKKLLBODIE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5BD4C40", Offset = "0x5BD3440", VA = "0x185BD4C40")]
	public void EENCAEABCPL(string OLJMCOBAMDO, string IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5BD4CC0", Offset = "0x5BD34C0", VA = "0x185BD4CC0")]
	public void KJCJBDCAIMJ(string ELMAMKJOOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5BD4A70", Offset = "0x5BD3270", VA = "0x185BD4A70")]
	public void AHPHDODMPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5BD4B30", Offset = "0x5BD3330", VA = "0x185BD4B30")]
	private void DBFLEJGCMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5BD4A20", Offset = "0x5BD3220", VA = "0x185BD4A20")]
	private bool AEIBDMOBNPH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HKFOCLLIPFB
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool KCOGMFJCNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MIKOHEFGBKI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action AEBLBPKPHHJ;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DFJLMOHJECJ MJKJMKCCJMD(string OBAIJIJHGOD, string HPHIDKFALLE, [Optional] GBPIJPMGOOG IDNINDABAMJ);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DFJLMOHJECJ KOIPCPCFHFD(GBPIJPMGOOG IDNINDABAMJ);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DFJLMOHJECJ PKKHCIAIFHF(GBPIJPMGOOG IDNINDABAMJ, Dictionary<string, string> KNCHNJGIIGF);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EKBJJMLJOJL(string EMALGAIGFKJ);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ECCKGMJPNBD NAIMOINBGLF(string OGNIDINIHBL);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FJFFBIJCFHK EAFDMOJJDIH(string ODMNNKDIFJA);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DFJLMOHJECJ HPJDDOODMLK();
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5BD5410", Offset = "0x5BD3C10", VA = "0x185BD5410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LNPDPOHCJGF : HKFOCLLIPFB
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly IReadOnlyDictionary<string, IKEOEMFEEJP> LGDCAPJBAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool HODGHDKAKGO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool KCOGMFJCNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B28A0", Offset = "0x7B10A0", VA = "0x1807B28A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action MIKOHEFGBKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5BD2370", Offset = "0x5BD0B70", VA = "0x185BD2370", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5BD2EC0", Offset = "0x5BD16C0", VA = "0x185BD2EC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action AEBLBPKPHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5BD2C20", Offset = "0x5BD1420", VA = "0x185BD2C20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5BD2520", Offset = "0x5BD0D20", VA = "0x185BD2520", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5BD27B0", Offset = "0x5BD0FB0", VA = "0x185BD27B0", Slot = "8")]
	public DFJLMOHJECJ MJKJMKCCJMD(string OBAIJIJHGOD, string HPHIDKFALLE, [Optional] GBPIJPMGOOG IDNINDABAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5BD2220", Offset = "0x5BD0A20", VA = "0x185BD2220", Slot = "15")]
	public DFJLMOHJECJ HPJDDOODMLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5BD25C0", Offset = "0x5BD0DC0", VA = "0x185BD25C0", Slot = "10")]
	public DFJLMOHJECJ KOIPCPCFHFD(GBPIJPMGOOG IDNINDABAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5BD2FE0", Offset = "0x5BD17E0", VA = "0x185BD2FE0", Slot = "11")]
	public DFJLMOHJECJ PKKHCIAIFHF(GBPIJPMGOOG IDNINDABAMJ, Dictionary<string, string> KNCHNJGIIGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5BD2190", Offset = "0x5BD0990", VA = "0x185BD2190", Slot = "12")]
	public bool EKBJJMLJOJL(string EMALGAIGFKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5BD2CC0", Offset = "0x5BD14C0", VA = "0x185BD2CC0", Slot = "13")]
	public ECCKGMJPNBD NAIMOINBGLF(string OGNIDINIHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5BD1F50", Offset = "0x5BD0750", VA = "0x185BD1F50", Slot = "14")]
	public FJFFBIJCFHK EAFDMOJJDIH(string ODMNNKDIFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5BD1880", Offset = "0x5BD0080", VA = "0x185BD1880")]
	private AGNHOAJNBJI DJMFDPMPEOB(GBPIJPMGOOG IDNINDABAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5BD1FE0", Offset = "0x5BD07E0", VA = "0x185BD1FE0")]
	private BNLFBIGDJIG EHINPLBBGBP(string HPHIDKFALLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5BD2410", Offset = "0x5BD0C10", VA = "0x185BD2410")]
	private void KFPOCDCCLCL(string OGNIDINIHBL, ECCKGMJPNBD NPLDMOPOFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public LNPDPOHCJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xA403E0", Offset = "0xA3EBE0", VA = "0x180A403E0")]
	[CompilerGenerated]
	private void HNCKEAHPGHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5BD2F60", Offset = "0x5BD1760", VA = "0x185BD2F60")]
	[CompilerGenerated]
	private void PGDKLNHOBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5BD1800", Offset = "0x5BD0000", VA = "0x185BD1800")]
	[CompilerGenerated]
	private void CLANLMCCLBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NKDMMJJJAND : HKFOCLLIPFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private HKFOCLLIPFB MLDPNAKJGMC;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private HKFOCLLIPFB BCPILFPJLKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5BD3C90", Offset = "0x5BD2490", VA = "0x185BD3C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool KCOGMFJCNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5BD3EC0", Offset = "0x5BD26C0", VA = "0x185BD3EC0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action MIKOHEFGBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5BD4090", Offset = "0x5BD2890", VA = "0x185BD4090", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5BD47E0", Offset = "0x5BD2FE0", VA = "0x185BD47E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action AEBLBPKPHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5BD45C0", Offset = "0x5BD2DC0", VA = "0x185BD45C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5BD4130", Offset = "0x5BD2930", VA = "0x185BD4130", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	[UnityEngine.Scripting.Preserve]
	public NKDMMJJJAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5BD3F10", Offset = "0x5BD2710", VA = "0x185BD3F10")]
	[OPPPCFMOGOO(OIAOEFLOJIJ.GameOnly)]
	private static void HMIMLLFNGCM(MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5BD4770", Offset = "0x5BD2F70", VA = "0x185BD4770")]
	[OPPPCFMOGOO(OIAOEFLOJIJ.EditorOnly)]
	private static void NPNBAELOIEG(MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5BD42E0", Offset = "0x5BD2AE0", VA = "0x185BD42E0", Slot = "8")]
	public DFJLMOHJECJ MJKJMKCCJMD(string OBAIJIJHGOD, string HPHIDKFALLE, [Optional] GBPIJPMGOOG IDNINDABAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5BD41D0", Offset = "0x5BD29D0", VA = "0x185BD41D0", Slot = "10")]
	public DFJLMOHJECJ KOIPCPCFHFD(GBPIJPMGOOG IDNINDABAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5BD4880", Offset = "0x5BD3080", VA = "0x185BD4880", Slot = "11")]
	public DFJLMOHJECJ PKKHCIAIFHF(GBPIJPMGOOG IDNINDABAMJ, Dictionary<string, string> KNCHNJGIIGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5BD3E10", Offset = "0x5BD2610", VA = "0x185BD3E10", Slot = "12")]
	public bool EKBJJMLJOJL(string EMALGAIGFKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5BD4660", Offset = "0x5BD2E60", VA = "0x185BD4660", Slot = "13")]
	public ECCKGMJPNBD NAIMOINBGLF(string OGNIDINIHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5BD3D00", Offset = "0x5BD2500", VA = "0x185BD3D00", Slot = "14")]
	public FJFFBIJCFHK EAFDMOJJDIH(string ODMNNKDIFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5BD3F80", Offset = "0x5BD2780", VA = "0x185BD3F80", Slot = "15")]
	public DFJLMOHJECJ HPJDDOODMLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7AE340", Offset = "0x7ACB40", VA = "0x1807AE340")]
	[CompilerGenerated]
	private void CHGEJGOFMKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC70", Offset = "0xAAE470", VA = "0x180AAFC70")]
	[CompilerGenerated]
	private void NDPHMMODKHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class ELKMCMBJBJF : HKFOCLLIPFB
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool KCOGMFJCNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action MIKOHEFGBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE7F0", Offset = "0x5BCCFF0", VA = "0x185BCE7F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5BCEB00", Offset = "0x5BCD300", VA = "0x185BCEB00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action AEBLBPKPHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5BCEA50", Offset = "0x5BCD250", VA = "0x185BCEA50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE890", Offset = "0x5BCD090", VA = "0x185BCE890", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	[RecRoom.NoEngine.Common.Preserve]
	public ELKMCMBJBJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5BCE9C0", Offset = "0x5BCD1C0", VA = "0x185BCE9C0", Slot = "8")]
	public DFJLMOHJECJ MJKJMKCCJMD(string OBAIJIJHGOD, string HPHIDKFALLE, [Optional] GBPIJPMGOOG IDNINDABAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5BCE930", Offset = "0x5BCD130", VA = "0x185BCE930", Slot = "10")]
	public DFJLMOHJECJ KOIPCPCFHFD(GBPIJPMGOOG IDNINDABAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5BCEBA0", Offset = "0x5BCD3A0", VA = "0x185BCEBA0", Slot = "11")]
	public DFJLMOHJECJ PKKHCIAIFHF(GBPIJPMGOOG IDNINDABAMJ, Dictionary<string, string> KNCHNJGIIGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "12")]
	public bool EKBJJMLJOJL(string EMALGAIGFKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5BCEAF0", Offset = "0x5BCD2F0", VA = "0x185BCEAF0", Slot = "13")]
	public ECCKGMJPNBD NAIMOINBGLF(string OGNIDINIHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5BCE750", Offset = "0x5BCCF50", VA = "0x185BCE750", Slot = "14")]
	public FJFFBIJCFHK EAFDMOJJDIH(string ODMNNKDIFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5BCE760", Offset = "0x5BCCF60", VA = "0x185BCE760", Slot = "15")]
	public DFJLMOHJECJ HPJDDOODMLK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DOMNFKHOKPL
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	POPHFBBJCJJ NGLKOLEGNGN(string MFDALLIEHDG);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface PCBAFLAPOKO
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	long EGJCMNNPCND
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long MKCIMCHGAKB();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPDCAFKFDOF(long MINEIKHPFOJ, bool EOKFAAHEMDB = true);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LLDONKPNEPK(string LIODJEBJPCP, string PGFADODOFOH, string PAHHLKPGKIE);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LNCPINNGAHJ(string LIODJEBJPCP);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HHPDOKJPGCP(string LIODJEBJPCP, string ONCOBFDNJLB, string EEGLICOPLGF);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EEMEHNHONEH(string PMFEOHBFPBF, object DBEPMDOJNOC, object GOCDEEMEMNN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface GBPIJPMGOOG
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool DFFPCGOGBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool DDHBLANDADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool OJCOAPNHGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool? NDMKKPAFGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	int? LFPFIMHBGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int NHAOOGAPCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string IFMPAOBELPE
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string BHPBCFAIMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string BFDLBIPODGO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	long MDCPKGOJBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string HCMKACFBPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string AKCNJJKAJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string PCLDLMHGJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string JAPOPFKEGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	double BHFAFCDMIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	int BEKAHMLHIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
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
