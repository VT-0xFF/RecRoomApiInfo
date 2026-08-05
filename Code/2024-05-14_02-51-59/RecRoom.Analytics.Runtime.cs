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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x61CF5F0", Offset = "0x61CDFF0", VA = "0x1861CF5F0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
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
		public AmplitudeAnalyticsClient.Settings KMEEDBCHMGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool COEOHDOEIFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7C99F0", Offset = "0x7C83F0", VA = "0x1807C99F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum CGCFIBEDMGO
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class JBGACDKJDAF
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class HLHPLKBNOME
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int PIHINNBPIGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> CDMKIGLKDAN;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
				public HLHPLKBNOME()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class EHGHOCJEBNM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
				public EHGHOCJEBNM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x61C7FE0", Offset = "0x61C69E0", VA = "0x1861C7FE0")]
				internal bool EDFCGEKFNHJ(HLHPLKBNOME item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string EDPMDJGHFLD = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string NBJNGHHJOKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<HLHPLKBNOME> PLOIEDNCDBM;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? FNDFOIMKNBK
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x61CABC0", Offset = "0x61C95C0", VA = "0x1861CABC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x61CB380", Offset = "0x61C9D80", VA = "0x1861CB380")]
			internal JBGACDKJDAF(string LCHJGMCNJLK, string KNCNPGDEIPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x61CA7C0", Offset = "0x61C91C0", VA = "0x1861CA7C0")]
			public int EOHPNDKIJCG([Optional] int? FDLJMGOIDEN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x61CA3C0", Offset = "0x61C8DC0", VA = "0x1861CA3C0")]
			public List<Dictionary<string, object>> BONOPLJHLPO(int JDPFJAAHMKP, int? FDLJMGOIDEN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x61CAC60", Offset = "0x61C9660", VA = "0x1861CAC60")]
			public void ILDAIFGNKCO(AmplitudeAnalyticsIdentifyMessage COMOOAEHALC, bool BDNPAPJJDGA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x61CAD00", Offset = "0x61C9700", VA = "0x1861CAD00")]
			public void ILDAIFGNKCO(Dictionary<string, object> COMOOAEHALC, bool BDNPAPJJDGA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x61CA630", Offset = "0x61C9030", VA = "0x1861CA630")]
			public void CDCFAPFPKKF(params Dictionary<string, object>[] BKMLLOCINPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x61CA970", Offset = "0x61C9370", VA = "0x1861CA970")]
			public void FCICBIHBFII(List<Dictionary<string, object>> ANEPMNDMPEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x61CAE10", Offset = "0x61C9810", VA = "0x1861CAE10")]
			private void KMAJDHNLDMJ(Dictionary<string, object> COMOOAEHALC, bool BDNPAPJJDGA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x61CA050", Offset = "0x61C8A50", VA = "0x1861CA050")]
			public void ALBNIKGJNEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x61CAF20", Offset = "0x61C9920", VA = "0x1861CAF20")]
			private void PEOLANDDBJF([Optional] string MDFNAKKODPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x61CA290", Offset = "0x61C8C90", VA = "0x1861CA290")]
			private static string AMKACLCONEJ(string AEJBOLFACJC, string KLDFLAABJKH)
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
			[Cpp2IlInjected.Address(RVA = "0x61D0A50", Offset = "0x61CF450", VA = "0x1861D0A50")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct COCCNFDCEOG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int IMGJALMOHLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string DCMOADBHAAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T IAMJLAJHPKE;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MLHJOPHBKPF : IEnumerator<LKAEALCJOPF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private LKAEALCJOPF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private LKAEALCJOPF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7C2410", Offset = "0x7C0E10", VA = "0x1807C2410")]
			[DebuggerHidden]
			public MLHJOPHBKPF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x61CEAD0", Offset = "0x61CD4D0", VA = "0x1861CEAD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x61CF290", Offset = "0x61CDC90", VA = "0x1861CF290", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NIKAMMIHEOO : IEnumerator<object>, IEnumerator, IDisposable
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
			public PFMMCNAEBBC quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7C2410", Offset = "0x7C0E10", VA = "0x1807C2410")]
			[DebuggerHidden]
			public NIKAMMIHEOO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x61CF490", Offset = "0x61CDE90", VA = "0x1861CF490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x61CF5A0", Offset = "0x61CDFA0", VA = "0x1861CF5A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class CNLPMPACJCI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7C2410", Offset = "0x7C0E10", VA = "0x1807C2410")]
			[DebuggerHidden]
			public CNLPMPACJCI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x61C6CE0", Offset = "0x61C56E0", VA = "0x1861C6CE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x61C6E50", Offset = "0x61C5850", VA = "0x1861C6E50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class ADFKDMHKGND : IEnumerator<LKAEALCJOPF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private LKAEALCJOPF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private LKAEALCJOPF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7C2410", Offset = "0x7C0E10", VA = "0x1807C2410")]
			[DebuggerHidden]
			public ADFKDMHKGND(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x61BEF40", Offset = "0x61BD940", VA = "0x1861BEF40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x61BF1C0", Offset = "0x61BDBC0", VA = "0x1861BF1C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class ABMEEBJLLOB : IEnumerator<LKAEALCJOPF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private LKAEALCJOPF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private LKAEALCJOPF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7C2410", Offset = "0x7C0E10", VA = "0x1807C2410")]
			[DebuggerHidden]
			public ABMEEBJLLOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x61BEC60", Offset = "0x61BD660", VA = "0x1861BEC60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x61BEEF0", Offset = "0x61BD8F0", VA = "0x1861BEEF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class PECPHNKLHFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public JBGACDKJDAF cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public PECPHNKLHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x61CFDC0", Offset = "0x61CE7C0", VA = "0x1861CFDC0")]
			internal void BGJMODHILNP(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x61D00E0", Offset = "0x61CEAE0", VA = "0x1861D00E0")]
			internal void EHIHKOCLGKL(COCCNFDCEOG<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class FOKJCJHBENK : IEnumerator<LKAEALCJOPF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private LKAEALCJOPF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public JBGACDKJDAF cache;

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
			private PECPHNKLHFB <>8__1;

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
			private LKAEALCJOPF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7C2410", Offset = "0x7C0E10", VA = "0x1807C2410")]
			[DebuggerHidden]
			public FOKJCJHBENK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x61C8400", Offset = "0x61C6E00", VA = "0x1861C8400", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x61C8CB0", Offset = "0x61C76B0", VA = "0x1861C8CB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class EGIDEANLMCK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public EGIDEANLMCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x34D89B0", Offset = "0x34D73B0", VA = "0x1834D89B0")]
			internal COCCNFDCEOG<T> FBJNGOKBLHD(MLPMAFNFHBC postResponse)
			{
				return default(COCCNFDCEOG<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class FBECLGIANHH<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public FBECLGIANHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x34D89B0", Offset = "0x34D73B0", VA = "0x1834D89B0")]
			internal COCCNFDCEOG<T> BILLMGONKLG(MLPMAFNFHBC postResponse)
			{
				return default(COCCNFDCEOG<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private IDGHBMDOALG DFEDLLOPJOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<JMIHKBFJCGH> EEMOHEJOCJN;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string OLIBKFPFAID = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string OJJBGIBFFCN = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string OKKDCEEJHMK = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int MJAKOAGNDIM = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int KCEJBKNPAFD = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int GBIJDIIEEFD = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float GLFDMMOHIGD = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long PCIIFMLAJFL = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string MBDNEIAIJJD = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string EGJGHOMNJJE = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool PENGKPPJCFF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool HPDAKFIGAHG;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int BEEKDLMNJMC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int DKFDOBHCDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ICKLOPNDAHO LOGJMBIHIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private EIDNDMLKGFM FDEFMCHIAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private BBDIBHILCKC NIHKBFKANEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool DLPHCAMOBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float MHMAKGKGJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float MJGOINDJBAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int OKCMCAHMFPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int AOBBNMLEFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? JIKJANGNFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? PJDNACLPFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long NCNPMNIFONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string ICCNMPNCFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool PAFCMHLFGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long EPOCMFDMOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string PFBPOPPGIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string HNBHMEGJGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> FMEBBNIMOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CGCFIBEDMGO HNCKGEJPBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int CFHOHJNMDNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int ALBGHABMBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float HFCNCMGIAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool EPOJKOAKOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool IKEIGDJHGON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private JBGACDKJDAF FFNMLHPPJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private JBGACDKJDAF NGLFICAEFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private JBGACDKJDAF APKNJFMEFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> HKMFBGPFFKM;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo MNCGFLFGKIO;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string EHHCAEOBKHK;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string BLOGLIDAENI = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string KNMHJMGMGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string PMGHMKOBNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string BLJLMMMBKAJ;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private IDGHBMDOALG MAOCEGIIOGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x61C31A0", Offset = "0x61C1BA0", VA = "0x1861C31A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private JMIHKBFJCGH MLGMPDMJBIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x61BF220", Offset = "0x61BDC20", VA = "0x1861BF220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int MACONKPOHBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x61BFB40", Offset = "0x61BE540", VA = "0x1861BFB40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long OOFBCKDOLPE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x61C4E00", Offset = "0x61C3800", VA = "0x1861C4E00")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x61C4F20", Offset = "0x61C3920", VA = "0x1861C4F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string ACCGBFBOLAP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x61C4DA0", Offset = "0x61C37A0", VA = "0x1861C4DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string LMCIMNPFBGI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x61C4DD0", Offset = "0x61C37D0", VA = "0x1861C4DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ELPAGHGJKKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8F6C00", Offset = "0x8F5600", VA = "0x1808F6C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8F6C10", Offset = "0x8F5610", VA = "0x1808F6C10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? HFCEGLOCBCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9C59F0", Offset = "0x9C43F0", VA = "0x1809C59F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x61C4F10", Offset = "0x61C3910", VA = "0x1861C4F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JEFMLCFGKNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xFFEE70", Offset = "0xFFD870", VA = "0x180FFEE70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xFFE5A0", Offset = "0xFFCFA0", VA = "0x180FFE5A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool OELNPMIHPGP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x61C4CB0", Offset = "0x61C36B0", VA = "0x1861C4CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> IJIJKMHJLCM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x61C4BF0", Offset = "0x61C35F0", VA = "0x1861C4BF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x61C4E50", Offset = "0x61C3850", VA = "0x1861C4E50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x61BF6D0", Offset = "0x61BE0D0", VA = "0x1861BF6D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61C0070", Offset = "0x61BEA70", VA = "0x1861C0070")]
		private void DEBHKHJPJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x61C41D0", Offset = "0x61C2BD0", VA = "0x1861C41D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x61C33E0", Offset = "0x61C1DE0", VA = "0x1861C33E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x61C4570", Offset = "0x61C2F70", VA = "0x1861C4570")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x61C34A0", Offset = "0x61C1EA0", VA = "0x1861C34A0")]
		public DBBHNMNBJNG PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x61C1360", Offset = "0x61BFD60", VA = "0x1861C1360")]
		[IteratorStateMachine(typeof(MLHJOPHBKPF))]
		public IEnumerator<LKAEALCJOPF> Initialize(AmplitudeAnalyticsEvent JEFOGGJJOAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x61C44B0", Offset = "0x61C2EB0", VA = "0x1861C44B0")]
		public void UpdateLastKnownInteractionCategory(string OEIDFICEKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x61C43C0", Offset = "0x61C2DC0", VA = "0x1861C43C0")]
		public void UpdateLastAliveTime(float JFNONBMGLIA = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x61C0610", Offset = "0x61BF010", VA = "0x1861C0610")]
		private DBBHNMNBJNG EFKGGCOJMNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x61BF270", Offset = "0x61BDC70", VA = "0x1861BF270")]
		private DBBHNMNBJNG APOFFIGBMLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x61C3C30", Offset = "0x61C2630", VA = "0x1861C3C30")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61C14F0", Offset = "0x61BFEF0", VA = "0x1861C14F0")]
		[IteratorStateMachine(typeof(NIKAMMIHEOO))]
		private IEnumerator KHIPFLKKDCC(PFMMCNAEBBC GLLHDGELPIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x61C4800", Offset = "0x61C3200", VA = "0x1861C4800")]
		[IteratorStateMachine(typeof(CNLPMPACJCI))]
		public IEnumerator WaitForFlush(float CBKBNMKLFNN = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x61C42A0", Offset = "0x61C2CA0", VA = "0x1861C42A0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x61C41E0", Offset = "0x61C2BE0", VA = "0x1861C41E0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime PAJOJJHFNPD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x61C0EA0", Offset = "0x61BF8A0", VA = "0x1861C0EA0")]
		public static JKFODDHOPOD Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x61BF560", Offset = "0x61BDF60", VA = "0x1861BF560")]
		public static KCABFJJFBBB AccountSelectionPostLoginEvent([NotNull] string CLEKKLCHALH, string CICMLCANLNN, bool NANGLGMCCMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61C06D0", Offset = "0x61BF0D0", VA = "0x1861C06D0")]
		public static KCABFJJFBBB Event([NotNull] string CLEKKLCHALH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x61C34E0", Offset = "0x61C1EE0", VA = "0x1861C34E0")]
		public static KCABFJJFBBB PreviousSessionEvent([NotNull] string CLEKKLCHALH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x61C1040", Offset = "0x61BFA40", VA = "0x1861C1040")]
		public static KCABFJJFBBB InitializeEvent(string CICMLCANLNN, int OLKAJHNGOGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x61C3DF0", Offset = "0x61C27F0", VA = "0x1861C3DF0")]
		public static KCABFJJFBBB StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x61BFE10", Offset = "0x61BE810", VA = "0x1861BFE10")]
		public static KCABFJJFBBB CreateOutOfSessionEvent(string CLEKKLCHALH, bool EALKGDBEICL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x61C2560", Offset = "0x61C0F60", VA = "0x1861C2560")]
		public static DBBHNMNBJNG LogOutOfSessionEvent(KCABFJJFBBB DGGOJDODLPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x61C22E0", Offset = "0x61C0CE0", VA = "0x1861C22E0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent IMAFGDLKGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x61C2850", Offset = "0x61C1250", VA = "0x1861C2850")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent IMAFGDLKGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x61C2990", Offset = "0x61C1390", VA = "0x1861C2990")]
		public void LogSerializedEventAsync(Dictionary<string, object> MOEMFMAKAFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x61C2420", Offset = "0x61C0E20", VA = "0x1861C2420")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HOONHDFFDFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x61C13F0", Offset = "0x61BFDF0", VA = "0x1861C13F0")]
		private void JHCABEAKGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x61C09C0", Offset = "0x61BF3C0", VA = "0x1861C09C0")]
		private void FMKLECECOND(Dictionary<string, object> AJOHDEHKGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x61BFD20", Offset = "0x61BE720", VA = "0x1861BFD20")]
		private void CPNHBNHBBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x61C3210", Offset = "0x61C1C10", VA = "0x1861C3210")]
		private void OOFBOHHLJKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x61C0C70", Offset = "0x61BF670", VA = "0x1861C0C70")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x61C2250", Offset = "0x61C0C50", VA = "0x1861C2250")]
		[IteratorStateMachine(typeof(ADFKDMHKGND))]
		private IEnumerator<LKAEALCJOPF> LKCNOAHGNNI(float CBKBNMKLFNN = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x61C0E10", Offset = "0x61BF810", VA = "0x1861C0E10")]
		[IteratorStateMachine(typeof(ABMEEBJLLOB))]
		private IEnumerator<LKAEALCJOPF> IFLLHBGPLMH(float CBKBNMKLFNN = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x61C2EF0", Offset = "0x61C18F0", VA = "0x1861C2EF0")]
		[IteratorStateMachine(typeof(FOKJCJHBENK))]
		private IEnumerator<LKAEALCJOPF> MIALEHMBJIK(JBGACDKJDAF OALDLMHJPOC, int? FDLJMGOIDEN, string PINLFFPIIJN, string LIFLMGJMKHA, float CBKBNMKLFNN, Action<int> ALNNKIHAHEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x61C0D00", Offset = "0x61BF700", VA = "0x1861C0D00")]
		private static void GIFDDEJBBFI(bool NGDJNFFGGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x61C2DC0", Offset = "0x61C17C0", VA = "0x1861C2DC0")]
		private NOCKNPDCDFN<COCCNFDCEOG<Dictionary<string, object>>> MGBEHKCONCG(string PINLFFPIIJN, string LIFLMGJMKHA, string OKKEMGLBGMG, string LJIBLHLENGI, Dictionary<string, object> IAMJLAJHPKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x61C2A70", Offset = "0x61C1470", VA = "0x1861C2A70")]
		private NOCKNPDCDFN<COCCNFDCEOG<List<Dictionary<string, object>>>> MGBEHKCONCG(string PINLFFPIIJN, string LIFLMGJMKHA, string OKKEMGLBGMG, string LJIBLHLENGI, List<Dictionary<string, object>> IAMJLAJHPKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D6C0", Offset = "0x2F9C0C0", VA = "0x182F9D6C0")]
		private NOCKNPDCDFN<COCCNFDCEOG<T>> MIDCANDLNFC<T>(string PINLFFPIIJN, string LIFLMGJMKHA, string LJIBLHLENGI, T IAMJLAJHPKE, Dictionary<string, object> HEJAHLMHEID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D970", Offset = "0x2F9C370", VA = "0x182F9D970")]
		private NOCKNPDCDFN<COCCNFDCEOG<T>> MLIGPCPBOLG<T>(string PINLFFPIIJN, string LIFLMGJMKHA, string OKKEMGLBGMG, T IAMJLAJHPKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x61C3150", Offset = "0x61C1B50", VA = "0x1861C3150")]
		private bool NHEMAEOGFNK(float IJBOKNKJPIJ, float CBKBNMKLFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x61C1580", Offset = "0x61BFF80", VA = "0x1861C1580")]
		private Dictionary<string, object> LFPOFFLAAGO(string LIFLMGJMKHA, Dictionary<string, object> IAMJLAJHPKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x61C48F0", Offset = "0x61C32F0", VA = "0x1861C48F0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x61C2FF0", Offset = "0x61C19F0", VA = "0x1861C2FF0")]
		[CompilerGenerated]
		private long MICCALLAKNA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x61BF210", Offset = "0x61BDC10", VA = "0x1861BF210")]
		[CompilerGenerated]
		private void ABPLBPCNCGB(int LCCOAIIBILB)
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
			[Cpp2IlInjected.Address(RVA = "0x61C5C70", Offset = "0x61C4670", VA = "0x1861C5C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x61C5D50", Offset = "0x61C4750", VA = "0x1861C5D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x61C5CB0", Offset = "0x61C46B0", VA = "0x1861C5CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x61C5DB0", Offset = "0x61C47B0", VA = "0x1861C5DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x61C5C30", Offset = "0x61C4630", VA = "0x1861C5C30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x61C5CF0", Offset = "0x61C46F0", VA = "0x1861C5CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7C68D0", Offset = "0x7C52D0", VA = "0x1807C68D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x61C5310", Offset = "0x61C3D10", VA = "0x1861C5310")]
		public static KCABFJJFBBB HGOBECNKDLP(string LHMJGBJEDAH, [NotNull] string FEDMFMONAEM, long LJONKKKHFNF, long ENOKDLDNKBM, string CICMLCANLNN, bool NANGLGMCCMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x61C5940", Offset = "0x61C4340", VA = "0x1861C5940")]
		public static KCABFJJFBBB KBCBNLEJCLN(string LHMJGBJEDAH, [NotNull] string FEDMFMONAEM, long LJONKKKHFNF, long ENOKDLDNKBM, string CICMLCANLNN, long IKDODLIHNBE, bool NANGLGMCCMN, string MFHKLHBOPDJ, string GKIHDPMOGIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x61C5AA0", Offset = "0x61C44A0", VA = "0x1861C5AA0")]
		private AmplitudeAnalyticsEvent(string LHMJGBJEDAH, [NotNull] string FEDMFMONAEM, long LJONKKKHFNF, long ENOKDLDNKBM, string CICMLCANLNN, bool NANGLGMCCMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1B45110", Offset = "0x1B43B10", VA = "0x181B45110")]
		public void GBAHFICEINN(long HPJDLDHGADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x61C5090", Offset = "0x61C3A90", VA = "0x1861C5090", Slot = "5")]
		public override void FICAPJGCNMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x61C5190", Offset = "0x61C3B90", VA = "0x1861C5190", Slot = "6")]
		public override void GPCEFOGBAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x61C5410", Offset = "0x61C3E10", VA = "0x1861C5410", Slot = "4")]
		protected override Dictionary<string, object> HIKDGGAMHPD(Dictionary<string, object> KKMHIFHKJCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x61C4F80", Offset = "0x61C3980", VA = "0x1861C4F80")]
		private void CEFMAFDLKOC(string KLDFLAABJKH, string AEJBOLFACJC, bool EKPOLHCCCCO = false)
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
			[Cpp2IlInjected.Address(RVA = "0x61C7940", Offset = "0x61C6340", VA = "0x1861C7940")]
			public void KNLHHDCFLGI(Dictionary<string, object> JPHEEFLMHLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
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
			[Cpp2IlInjected.Address(RVA = "0x61D06E0", Offset = "0x61CF0E0", VA = "0x1861D06E0")]
			public void KNLHHDCFLGI(Dictionary<string, object> FBPHJLADGGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x957C40", Offset = "0x956640", VA = "0x180957C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7C4FA0", Offset = "0x7C39A0", VA = "0x1807C4FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x61C5FC0", Offset = "0x61C49C0", VA = "0x1861C5FC0")]
		public static JKFODDHOPOD HGOBECNKDLP(string LHMJGBJEDAH, string CICMLCANLNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x61C64C0", Offset = "0x61C4EC0", VA = "0x1861C64C0")]
		protected AmplitudeAnalyticsIdentifyMessage(string LHMJGBJEDAH, string CICMLCANLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x61C63C0", Offset = "0x61C4DC0", VA = "0x1861C63C0")]
		public Dictionary<string, object> JKHAJGHFILA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x61C6080", Offset = "0x61C4A80", VA = "0x1861C6080", Slot = "4")]
		protected virtual Dictionary<string, object> HIKDGGAMHPD(Dictionary<string, object> KKMHIFHKJCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x61C5E10", Offset = "0x61C4810", VA = "0x1861C5E10")]
		protected void DFANFAHBHBP(string KLDFLAABJKH, Dictionary<string, object> CFDGPICHKHA, Dictionary<string, object> FOPDNGHFOMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x61C6450", Offset = "0x61C4E50", VA = "0x1861C6450")]
		protected void PAKGKGAPGLJ(string KLDFLAABJKH, string AEJBOLFACJC, Dictionary<string, object> HFKIIPKKGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x61C5EB0", Offset = "0x61C48B0", VA = "0x1861C5EB0", Slot = "5")]
		public virtual void FICAPJGCNMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x61C5F40", Offset = "0x61C4940", VA = "0x1861C5F40", Slot = "6")]
		public virtual void GPCEFOGBAPO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JKFODDHOPOD : IJJIOBEBIBD<AmplitudeAnalyticsIdentifyMessage, JKFODDHOPOD>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override JKFODDHOPOD FGBCIKFOENK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage KMGCJBMGIAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61CB610", Offset = "0x61CA010", VA = "0x1861CB610")]
	public JKFODDHOPOD(AmplitudeAnalyticsIdentifyMessage CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x61CB570", Offset = "0x61C9F70", VA = "0x1861CB570", Slot = "4")]
	public override void GPCEFOGBAPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KCABFJJFBBB : IJJIOBEBIBD<AmplitudeAnalyticsEvent, KCABFJJFBBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool IJAOKAOHNIM;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override KCABFJJFBBB FGBCIKFOENK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long OAEOFIDAICN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x61CB8C0", Offset = "0x61CA2C0", VA = "0x1861CB8C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x61CB9E0", Offset = "0x61CA3E0", VA = "0x1861CB9E0")]
	public KCABFJJFBBB(AmplitudeAnalyticsEvent CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30", Slot = "5")]
	public override AmplitudeAnalyticsEvent KMGCJBMGIAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x61CB660", Offset = "0x61CA060", VA = "0x1861CB660", Slot = "4")]
	public override void GPCEFOGBAPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x29C5ED0", Offset = "0x29C48D0", VA = "0x1829C5ED0")]
	public KCABFJJFBBB JBGDLPLNJIE<T>(string DMJMLGBLOFK, T[] AEJBOLFACJC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x29C5ED0", Offset = "0x29C48D0", VA = "0x1829C5ED0")]
	public KCABFJJFBBB JBGDLPLNJIE(string DMJMLGBLOFK, string[] AEJBOLFACJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x29C5C20", Offset = "0x29C4620", VA = "0x1829C5C20")]
	public KCABFJJFBBB JBGDLPLNJIE<T>(string DMJMLGBLOFK, T AEJBOLFACJC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x61CB810", Offset = "0x61CA210", VA = "0x1861CB810")]
	public KCABFJJFBBB JBGDLPLNJIE(string DMJMLGBLOFK, long AEJBOLFACJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61CB7A0", Offset = "0x61CA1A0", VA = "0x1861CB7A0")]
	public KCABFJJFBBB JBGDLPLNJIE(string DMJMLGBLOFK, string AEJBOLFACJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x61CB890", Offset = "0x61CA290", VA = "0x1861CB890")]
	public KCABFJJFBBB MFJKEKMCLFA(string DMJMLGBLOFK, object? AEJBOLFACJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61CB700", Offset = "0x61CA100", VA = "0x1861CB700")]
	public KCABFJJFBBB HPDGGNFJHML(string DMJMLGBLOFK, string AEJBOLFACJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x61CB8E0", Offset = "0x61CA2E0", VA = "0x1861CB8E0")]
	private KCABFJJFBBB PLBIMJCJAMC(string DMJMLGBLOFK, object AEJBOLFACJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PNNFOBAFBDF : KCABFJJFBBB
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x61CB9E0", Offset = "0x61CA3E0", VA = "0x1861CB9E0")]
	public PNNFOBAFBDF(AmplitudeAnalyticsEvent CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x61D0530", Offset = "0x61CEF30", VA = "0x1861D0530", Slot = "4")]
	public override void GPCEFOGBAPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class IJJIOBEBIBD<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : IJJIOBEBIBD<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M CPPFNMDMGHI;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR FGBCIKFOENK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	public IJJIOBEBIBD(M CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3AC00A0", Offset = "0x3ABEAA0", VA = "0x183AC00A0")]
	public BLDR ICEDDFJAJEK(AmplitudeAnalyticsIdentifyMessage.DeviceInfo PDOEALEHMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3AC00F0", Offset = "0x3ABEAF0", VA = "0x183AC00F0")]
	public BLDR KIFDBBFNBNF(AmplitudeAnalyticsIdentifyMessage.RevenueData ALDIDJFPLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3AC0140", Offset = "0x3ABEB40", VA = "0x183AC0140")]
	public BLDR MADCHEEDJOJ(string DMJMLGBLOFK, string AEJBOLFACJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x281E6C0", Offset = "0x281D0C0", VA = "0x18281E6C0")]
	public BLDR MADCHEEDJOJ<T>(string DMJMLGBLOFK, T AEJBOLFACJC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void GPCEFOGBAPO();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3AC0070", Offset = "0x3ABEA70", VA = "0x183AC0070")]
	internal static string GCOLLCLDCJE(string AEJBOLFACJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3AC01B0", Offset = "0x3ABEBB0", VA = "0x183AC01B0")]
	private BLDR NLBHIOECECM(string DMJMLGBLOFK, object AEJBOLFACJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M KMGCJBMGIAO();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class FIIPJHPJMCJ : ICKLOPNDAHO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct JBBAKOFEIGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<MLPMAFNFHBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public FIIPJHPJMCJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x61C9740", Offset = "0x61C8140", VA = "0x1861C9740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x61C9FE0", Offset = "0x61C89E0", VA = "0x1861C9FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct DOOLEKBIFDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<MLPMAFNFHBC> <>t__builder;

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
		public FIIPJHPJMCJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x61C6EA0", Offset = "0x61C58A0", VA = "0x1861C6EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x61C78D0", Offset = "0x61C62D0", VA = "0x1861C78D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient DKEDJLHKHLH;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x61C81C0", Offset = "0x61C6BC0", VA = "0x1861C81C0")]
	[JCOMPLNHMEG(AOHDMBIABEL.None)]
	private static void HMCPPKILMKC(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x61C8380", Offset = "0x61C6D80", VA = "0x1861C8380")]
	[RecRoom.NoEngine.Common.Preserve]
	public FIIPJHPJMCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x61C8230", Offset = "0x61C6C30", VA = "0x1861C8230", Slot = "4")]
	[AsyncStateMachine(typeof(JBBAKOFEIGN))]
	public Task<MLPMAFNFHBC> MGBEHKCONCG(string PINLFFPIIJN, Dictionary<string, string> BPJJBBDFNFH, bool CECIENGOOHI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x61C8050", Offset = "0x61C6A50", VA = "0x1861C8050", Slot = "5")]
	[AsyncStateMachine(typeof(DOOLEKBIFDJ))]
	public Task<MLPMAFNFHBC> CEFLGKJHNOP(string PINLFFPIIJN, string DLFAMKLAKGC, string PHMNJJKPDPA, string OAPHIOAOEDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MMHEBDBKNIE
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> CAPDNFFHLLC;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x61CF2E0", Offset = "0x61CDCE0", VA = "0x1861CF2E0")]
	internal static bool HMGHMONEPMF(string KLDFLAABJKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface ICKLOPNDAHO
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MLPMAFNFHBC> MGBEHKCONCG(string PINLFFPIIJN, Dictionary<string, string> BPJJBBDFNFH, bool CECIENGOOHI = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MLPMAFNFHBC> CEFLGKJHNOP(string PINLFFPIIJN, string DLFAMKLAKGC, string PHMNJJKPDPA, string OAPHIOAOEDM);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct MLPMAFNFHBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int JOABJPFMKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string HPCAGPGMABG;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xC56530", Offset = "0xC54F30", VA = "0x180C56530")]
	public MLPMAFNFHBC(int IMGJALMOHLC, string DCMOADBHAAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum IMNLDLIHHAG
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
public class EGJPHKMOOMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long NPMGMCNLEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private KCABFJJFBBB KCKGFPGECLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool CEABKPBMCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float EEOLDANGEIL;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x61C7E50", Offset = "0x61C6850", VA = "0x1861C7E50")]
	public EGJPHKMOOMN(string LPJEJJODPAA, float EEOLDANGEIL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x28082F0", Offset = "0x2806CF0", VA = "0x1828082F0")]
	public void JBGDLPLNJIE<T>(string DMJMLGBLOFK, T AEJBOLFACJC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x61C7C70", Offset = "0x61C6670", VA = "0x1861C7C70")]
	public void JBGDLPLNJIE(string DMJMLGBLOFK, string AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x61C7B80", Offset = "0x61C6580", VA = "0x1861C7B80")]
	public void HAGJIBADGHP(string GEMMIHEOHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x61C7AC0", Offset = "0x61C64C0", VA = "0x1861C7AC0")]
	public void EDMNJJNEKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x61C7D40", Offset = "0x61C6740", VA = "0x1861C7D40")]
	private void JLJLIOCFAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x61C7CF0", Offset = "0x61C66F0", VA = "0x1861C7CF0")]
	private bool JEAAMBJFGMM()
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
		public enum GEFGBIOCAAM
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
		private GEFGBIOCAAM parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public GEFGBIOCAAM Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x83FF90", Offset = "0x83E990", VA = "0x18083FF90")]
			get
			{
				return default(GEFGBIOCAAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x886CD0", Offset = "0x8856D0", VA = "0x180886CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x61D0850", Offset = "0x61CF250", VA = "0x1861D0850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class HOAINMBLNOA : PKFIGHNKMGA, JEFDOGDKMMP
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void BALHKOBANEK(BCLFIDIPHED FOEKNKADCEH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly IBLMOLAKHEN MHAPAGANABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly BALHKOBANEK ABHFMKNMMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly string NLCNCBIMLAL;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string MPFLJPMJCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x10E4C40", Offset = "0x10E3640", VA = "0x1810E4C40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool GIKDFJOEBMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x61C8ED0", Offset = "0x61C78D0", VA = "0x1861C8ED0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool OAEMIAFLGAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x61C8EF0", Offset = "0x61C78F0", VA = "0x1861C8EF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> CMFECPLGIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x10E4990", Offset = "0x10E3390", VA = "0x1810E4990", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x61C8F10", Offset = "0x61C7910", VA = "0x1861C8F10")]
	public HOAINMBLNOA(IBLMOLAKHEN FAKHGNGCNKM, string GGOPFAFAEMJ, [Optional] BALHKOBANEK OPBICBDCJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x296FC40", Offset = "0x296E640", VA = "0x18296FC40", Slot = "8")]
	public T OIFPBAJNOAG<T>(string KLDFLAABJKH, T LFANPJOLHJB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class MIGFMLOKOBL : PNBPIKBDKFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct OAKJKOJOFPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public MIGFMLOKOBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public EIDNDMLKGFM userData;

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
		[Cpp2IlInjected.Address(RVA = "0x61CF670", Offset = "0x61CE070", VA = "0x1861CF670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x61CFAF0", Offset = "0x61CE4F0", VA = "0x1861CFAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct PCIKGNALDNM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61CFB50", Offset = "0x61CE550", VA = "0x1861CFB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x61CFD60", Offset = "0x61CE760", VA = "0x1861CFD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct LFOEBPAOLBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public MIGFMLOKOBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public EIDNDMLKGFM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x61CBE60", Offset = "0x61CA860", VA = "0x1861CBE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x61CC120", Offset = "0x61CAB20", VA = "0x1861CC120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct KLAIMPHLDPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public MIGFMLOKOBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public EIDNDMLKGFM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x61CBA30", Offset = "0x61CA430", VA = "0x1861CBA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x61CBE00", Offset = "0x61CA800", VA = "0x1861CBE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly IReadOnlyDictionary<string, JMNPKPLAJOD> NHNJOIBLNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool MLCCGNJLIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private DKDIJLIIIHD LMIBBCOIGFC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool CIENOIJGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x838CD0", Offset = "0x8376D0", VA = "0x180838CD0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string ELPAGHGJKKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x61CD130", Offset = "0x61CBB30", VA = "0x1861CD130", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IHJDKCJPEIH PIEGCFIPNEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x61CCEE0", Offset = "0x61CB8E0", VA = "0x1861CCEE0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FGPPJFEMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x61CD3A0", Offset = "0x61CBDA0", VA = "0x1861CD3A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x61CE020", Offset = "0x61CCA20", VA = "0x1861CE020", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action MFEHEHDNCGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x61CE560", Offset = "0x61CCF60", VA = "0x1861CE560", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x61CD090", Offset = "0x61CBA90", VA = "0x1861CD090", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<BCLFIDIPHED> LEKIBJJIMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x61CD140", Offset = "0x61CBB40", VA = "0x1861CD140", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x61CE4B0", Offset = "0x61CCEB0", VA = "0x1861CE4B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x61CE1B0", Offset = "0x61CCBB0", VA = "0x1861CE1B0", Slot = "10")]
	[AsyncStateMachine(typeof(OAKJKOJOFPF))]
	public Task MPOMBMILLLK(string AJDBOBFPEEI, string KNCNPGDEIPD, [Optional] EIDNDMLKGFM GEGMONMODME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x61CDEE0", Offset = "0x61CC8E0", VA = "0x1861CDEE0", Slot = "19")]
	[AsyncStateMachine(typeof(PCIKGNALDNM))]
	public Task LDOMKFLOENA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x61CE0C0", Offset = "0x61CCAC0", VA = "0x1861CE0C0", Slot = "14")]
	[AsyncStateMachine(typeof(LFOEBPAOLBG))]
	public Task MIEKGKNPNDK(EIDNDMLKGFM GEGMONMODME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x61CCF80", Offset = "0x61CB980", VA = "0x1861CCF80", Slot = "15")]
	[AsyncStateMachine(typeof(KLAIMPHLDPC))]
	public Task CLNIOEGNMGP(EIDNDMLKGFM GEGMONMODME, Dictionary<string, string> IGOLCBCOIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x61CDD40", Offset = "0x61CC740", VA = "0x1861CDD40", Slot = "16")]
	public bool KPCLKMGAODH(string KKKKELCGCEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x61CE600", Offset = "0x61CD000", VA = "0x1861CE600", Slot = "17")]
	public PKFIGHNKMGA OHOEHPALPDH(string GGOPFAFAEMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x61CE2F0", Offset = "0x61CCCF0", VA = "0x1861CE2F0")]
	private IBLMOLAKHEN NJPGBEFOLOO(string GGOPFAFAEMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x61CE7B0", Offset = "0x61CD1B0", VA = "0x1861CE7B0", Slot = "18")]
	public JEJKJILALFJ PCIAOPCBFMH(string LCIMABFKLLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x61CDF90", Offset = "0x61CC990", VA = "0x1861CDF90")]
	private DPIIGPJFIAP LOMAFLEADFF(string LCIMABFKLLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x61CD440", Offset = "0x61CBE40", VA = "0x1861CD440")]
	private MFLIHCDPKKH JBKLHEGGMEO(EIDNDMLKGFM GEGMONMODME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x61CD1F0", Offset = "0x61CBBF0", VA = "0x1861CD1F0")]
	private FMGIPJPBKFK HHKFPFHBHHK(string KNCNPGDEIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x61CDDD0", Offset = "0x61CC7D0", VA = "0x1861CDDD0")]
	private void LCABLFJIJJM(string GGOPFAFAEMJ, IBLMOLAKHEN FAKHGNGCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public MIGFMLOKOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x61CCEA0", Offset = "0x61CB8A0", VA = "0x1861CCEA0")]
	[CompilerGenerated]
	private void ODOOFJIIPLC(BCLFIDIPHED IBKPCEPDIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x61CCEA0", Offset = "0x61CB8A0", VA = "0x1861CCEA0")]
	[CompilerGenerated]
	private void NBGHEEPGOAG(BCLFIDIPHED IBKPCEPDIIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class LIMLCLFFGFK : PNBPIKBDKFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct IOIJFOPMCFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public LIMLCLFFGFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public EIDNDMLKGFM userData;

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
		[Cpp2IlInjected.Address(RVA = "0x61C8F80", Offset = "0x61C7980", VA = "0x1861C8F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x61C96E0", Offset = "0x61C80E0", VA = "0x1861C96E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private PNBPIKBDKFG CJGKMKBKMHF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private PNBPIKBDKFG GMKKFAACACB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x61CC360", Offset = "0x61CAD60", VA = "0x1861CC360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CIENOIJGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x61CC6F0", Offset = "0x61CB0F0", VA = "0x1861CC6F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string ELPAGHGJKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x61CC550", Offset = "0x61CAF50", VA = "0x1861CC550", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IHJDKCJPEIH PIEGCFIPNEN
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x61CC180", Offset = "0x61CAB80", VA = "0x1861CC180", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action FGPPJFEMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x61CC650", Offset = "0x61CB050", VA = "0x1861CC650", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x61CC900", Offset = "0x61CB300", VA = "0x1861CC900", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action MFEHEHDNCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x61CCCA0", Offset = "0x61CB6A0", VA = "0x1861CCCA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x61CC440", Offset = "0x61CAE40", VA = "0x1861CC440", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<BCLFIDIPHED> LEKIBJJIMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x61CC5A0", Offset = "0x61CAFA0", VA = "0x1861CC5A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x61CCBF0", Offset = "0x61CB5F0", VA = "0x1861CCBF0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	[UnityEngine.Scripting.Preserve]
	public LIMLCLFFGFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x61CC3D0", Offset = "0x61CADD0", VA = "0x1861CC3D0")]
	[JCOMPLNHMEG(AOHDMBIABEL.GameOnly)]
	private static void EMFBPIFAPPJ(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x61CC4E0", Offset = "0x61CAEE0", VA = "0x1861CC4E0")]
	[JCOMPLNHMEG(AOHDMBIABEL.EditorOnly)]
	private static void GEEAEEJJCNA(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x61CCAB0", Offset = "0x61CB4B0", VA = "0x1861CCAB0", Slot = "10")]
	[AsyncStateMachine(typeof(IOIJFOPMCFG))]
	public Task MPOMBMILLLK(string AJDBOBFPEEI, string KNCNPGDEIPD, [Optional] EIDNDMLKGFM GEGMONMODME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x61CC9A0", Offset = "0x61CB3A0", VA = "0x1861CC9A0", Slot = "14")]
	public Task MIEKGKNPNDK(EIDNDMLKGFM GEGMONMODME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x61CC240", Offset = "0x61CAC40", VA = "0x1861CC240", Slot = "15")]
	public Task CLNIOEGNMGP(EIDNDMLKGFM GEGMONMODME, Dictionary<string, string> IGOLCBCOIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x61CC740", Offset = "0x61CB140", VA = "0x1861CC740", Slot = "16")]
	public bool KPCLKMGAODH(string KKKKELCGCEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x61CCD40", Offset = "0x61CB740", VA = "0x1861CCD40", Slot = "17")]
	public PKFIGHNKMGA OHOEHPALPDH(string GGOPFAFAEMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x61CCDF0", Offset = "0x61CB7F0", VA = "0x1861CCDF0", Slot = "18")]
	public JEJKJILALFJ PCIAOPCBFMH(string LCIMABFKLLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x61CC7F0", Offset = "0x61CB1F0", VA = "0x1861CC7F0", Slot = "19")]
	public Task LDOMKFLOENA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x80E770", Offset = "0x80D170", VA = "0x18080E770")]
	[CompilerGenerated]
	private void IOAHLKOPJJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x848860", Offset = "0x847260", VA = "0x180848860")]
	[CompilerGenerated]
	private void ANADKALBIHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x61CCEA0", Offset = "0x61CB8A0", VA = "0x1861CCEA0")]
	[CompilerGenerated]
	private void PGPDADFKAFG(BCLFIDIPHED IBKPCEPDIIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal class LIDGFNMMFHF : JEJKJILALFJ, JEFDOGDKMMP
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate void LBGHJKJOOHI(BCLFIDIPHED FOEKNKADCEH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly LBGHJKJOOHI ABHFMKNMMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly DPIIGPJFIAP PPJPHECCPLC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string MPFLJPMJCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1AD5EB0", Offset = "0x1AD48B0", VA = "0x181AD5EB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5549270", Offset = "0x5547C70", VA = "0x185549270")]
	public LIDGFNMMFHF(DPIIGPJFIAP MLNMEAKGKNK, [Optional] LBGHJKJOOHI OPBICBDCJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x29E83D0", Offset = "0x29E6DD0", VA = "0x1829E83D0", Slot = "5")]
	public T OIFPBAJNOAG<T>(string KLDFLAABJKH, T LFANPJOLHJB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface OEFBABDFLCC
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[UsedImplicitly]
public class GFDHDJLLHND : OEFBABDFLCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly JNGFGACPDOL FNANJKIFCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly List<FCEOCJECPPM> JMNNKBNBJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly string KMMGNJLMMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly string PFADIHMEELG;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x61C8D00", Offset = "0x61C7700", VA = "0x1861C8D00")]
	[JCOMPLNHMEG(EEKBGOJGGBC.Root, AOHDMBIABEL.GameOnly)]
	[UsedImplicitly]
	private static void EBMPOMEGCDH(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x61C8D70", Offset = "0x61C7770", VA = "0x1861C8D70")]
	[RecRoom.NoEngine.Common.Preserve]
	internal GFDHDJLLHND([JDJLHBHAJCP(null)][NotNull] JNGFGACPDOL FNANJKIFCLP, [NotNull][JDJLHBHAJCP(null)] JEKLDOKHJNF NPDLBBBILML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class CLGOMONNIPD : PNBPIKBDKFG
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CIENOIJGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string ELPAGHGJKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IHJDKCJPEIH PIEGCFIPNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action FGPPJFEMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x61C6760", Offset = "0x61C5160", VA = "0x1861C6760", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x61C6890", Offset = "0x61C5290", VA = "0x1861C6890", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action MFEHEHDNCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x61C6B00", Offset = "0x61C5500", VA = "0x1861C6B00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x61C6610", Offset = "0x61C5010", VA = "0x1861C6610", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<BCLFIDIPHED> LEKIBJJIMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x61C66B0", Offset = "0x61C50B0", VA = "0x1861C66B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x61C6A50", Offset = "0x61C5450", VA = "0x1861C6A50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	[RecRoom.NoEngine.Common.Preserve]
	public CLGOMONNIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x61C69C0", Offset = "0x61C53C0", VA = "0x1861C69C0", Slot = "10")]
	public Task MPOMBMILLLK(string AJDBOBFPEEI, string KNCNPGDEIPD, [Optional] EIDNDMLKGFM GEGMONMODME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x61C6930", Offset = "0x61C5330", VA = "0x1861C6930", Slot = "14")]
	public Task MIEKGKNPNDK(EIDNDMLKGFM GEGMONMODME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x61C6580", Offset = "0x61C4F80", VA = "0x1861C6580", Slot = "15")]
	public Task CLNIOEGNMGP(EIDNDMLKGFM GEGMONMODME, Dictionary<string, string> IGOLCBCOIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "16")]
	public bool KPCLKMGAODH(string KKKKELCGCEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x61C6BA0", Offset = "0x61C55A0", VA = "0x1861C6BA0", Slot = "17")]
	public PKFIGHNKMGA OHOEHPALPDH(string GGOPFAFAEMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x61C6C50", Offset = "0x61C5650", VA = "0x1861C6C50", Slot = "18")]
	public JEJKJILALFJ PCIAOPCBFMH(string LCIMABFKLLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x61C6800", Offset = "0x61C5200", VA = "0x1861C6800", Slot = "19")]
	public Task LDOMKFLOENA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal class DKDIJLIIIHD : IHJDKCJPEIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly MFLIHCDPKKH LMIBBCOIGFC;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IReadOnlyDictionary<string, object> LCBJABACFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x10E49B0", Offset = "0x10E33B0", VA = "0x1810E49B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	public DKDIJLIIIHD(MFLIHCDPKKH NDEDIMNPJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface LELHKPKJOPN
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGJPHKMOOMN FFNONGKANGH(string LPJEJJODPAA);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface BBDIBHILCKC
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum KEDGINHIAAK
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
	long PFALOEHMCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string ABAJDDGGGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string IJHLEKLJPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string LNMJDIMLIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string GFJMAEGLAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool HIJJIFKPDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long DFAHHFFIBNL();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FGDIAGOGCIP(long LJONKKKHFNF, bool EKPOLHCCCCO = true);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MNNHANOFGLK(string JGGBEOJAHKH, string PCEBLBPNANM, string MEDCNCHPDGJ);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GCFJCNCHKJM(string JGGBEOJAHKH);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LMBAPFBEJMP(string JGGBEOJAHKH, string DGLNHIJEMGA, string CPNJMMCFIGE);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AABJMNKCIPG(string ECJOJOJJMHE, object ELMFGACEMLP, object IDIINHBBLDL);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BEHHJHFFOGL(KEDGINHIAAK EHPGGBCDONN, int BKJKKPLNCEK, [Optional] EACFMGAEEHN EDICPNNFAJJ, [Optional] string DANJINPJLPP, [Optional] string MBGOEMJAPEP);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KFHOBHNNAAI(EACFMGAEEHN EDICPNNFAJJ, long FACOJCJJDLN, long ELHODLINEGN, int JIPAPICJBJH, string DANJINPJLPP, int BKJKKPLNCEK);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LLMGAPPPMCG(EACFMGAEEHN EDICPNNFAJJ, bool ODHGHOOKBIP, [Optional] string MBGOEMJAPEP);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MIGOEIJKIMG(EACFMGAEEHN EDICPNNFAJJ, bool ODHGHOOKBIP, [Optional] string MBGOEMJAPEP);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BJBECNIOJHA(EACFMGAEEHN EDICPNNFAJJ, bool ODHGHOOKBIP, [Optional] string MBGOEMJAPEP);
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
