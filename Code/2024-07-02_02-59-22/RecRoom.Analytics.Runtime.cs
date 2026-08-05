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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67F7010", Offset = "0x67F6010", VA = "0x1867F7010")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890780", Offset = "0x88F780", VA = "0x180890780")]
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
		public AmplitudeAnalyticsClient.Settings JGBMFIMBCJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GKCMJPJKOPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x86FCF0", Offset = "0x86ECF0", VA = "0x18086FCF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x866340", Offset = "0x865340", VA = "0x180866340")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum OOLDAHFGJPN
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class HEKFNJCPPBA
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class LFKCKGFCINM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				public int JBKANKCEBBN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public Dictionary<string, object> COELGPKEBDB;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
				public LFKCKGFCINM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class IHMLNMBCINP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
				public IHMLNMBCINP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x67F5240", Offset = "0x67F4240", VA = "0x1867F5240")]
				internal bool MEJPKEIJFGO(LFKCKGFCINM item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private const string KIKNIDBDAGJ = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly string AKCHJOKAGJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private List<LFKCKGFCINM> GNEJCPMJACC;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public int? PBBHPPIMAEL
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x67F3F80", Offset = "0x67F2F80", VA = "0x1867F3F80")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x67F4F70", Offset = "0x67F3F70", VA = "0x1867F4F70")]
			internal HEKFNJCPPBA(string BNPOJFFPBOB, string NHHBOGKKMDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x67F4570", Offset = "0x67F3570", VA = "0x1867F4570")]
			public int KCPGLJNBJCN([Optional] int? IAOFEMGDFGI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x67F4300", Offset = "0x67F3300", VA = "0x1867F4300")]
			public List<Dictionary<string, object>> KAFPOEGDALI(int JAJGMHAGDMO, int? IAOFEMGDFGI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x67F4150", Offset = "0x67F3150", VA = "0x1867F4150")]
			public void HPCHEELPPGC(AmplitudeAnalyticsIdentifyMessage HBFCGFKGCAF, bool MBGGFMLJOLG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x67F41F0", Offset = "0x67F31F0", VA = "0x1867F41F0")]
			public void HPCHEELPPGC(Dictionary<string, object> HBFCGFKGCAF, bool MBGGFMLJOLG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x67F3CE0", Offset = "0x67F2CE0", VA = "0x1867F3CE0")]
			public void ADIJHEOCCOL(params Dictionary<string, object>[] OLBGMOGEHCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x67F4D20", Offset = "0x67F3D20", VA = "0x1867F4D20")]
			public void PNIOACDPAJO(List<Dictionary<string, object>> FOCNAICGHGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x67F3E70", Offset = "0x67F2E70", VA = "0x1867F3E70")]
			private void DICCNIICJEI(Dictionary<string, object> HBFCGFKGCAF, bool MBGGFMLJOLG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x67F4720", Offset = "0x67F3720", VA = "0x1867F4720")]
			public void NJGBJGIGBDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x67F4930", Offset = "0x67F3930", VA = "0x1867F4930")]
			private void OMGJIHLEGMI([Optional] string NIMBHMIABML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x67F4020", Offset = "0x67F3020", VA = "0x1867F4020")]
			private static string GPADHHDLFPN(string CBAEIEAPLIH, string BHEIPBKEDLG)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x67F7D20", Offset = "0x67F6D20", VA = "0x1867F7D20")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct IIHCKDKPNDG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public int GICIPAPDFBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public string IHNEKMANEKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T CFPKNANJCOC;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DGABLFCJCCG : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private MBMMHILCGCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
			[DebuggerHidden]
			public DGABLFCJCCG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x67F06E0", Offset = "0x67EF6E0", VA = "0x1867F06E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x67F0EA0", Offset = "0x67EFEA0", VA = "0x1867F0EA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class IFPNJDNJGHM : IEnumerator<object>, IEnumerator, IDisposable
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
			public NIIIJMDBGHD quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
			[DebuggerHidden]
			public IFPNJDNJGHM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x67F50E0", Offset = "0x67F40E0", VA = "0x1867F50E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x67F51F0", Offset = "0x67F41F0", VA = "0x1867F51F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class FPEOJCFBMCC : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
			[DebuggerHidden]
			public FPEOJCFBMCC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x67F3580", Offset = "0x67F2580", VA = "0x1867F3580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x67F36F0", Offset = "0x67F26F0", VA = "0x1867F36F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class JFICAPOLGAC : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private MBMMHILCGCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
			[DebuggerHidden]
			public JFICAPOLGAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x67F55D0", Offset = "0x67F45D0", VA = "0x1867F55D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x67F5830", Offset = "0x67F4830", VA = "0x1867F5830", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class FBGCFMCCBGP : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private MBMMHILCGCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
			[DebuggerHidden]
			public FBGCFMCCBGP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x67F1B40", Offset = "0x67F0B40", VA = "0x1867F1B40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x67F1DA0", Offset = "0x67F0DA0", VA = "0x1867F1DA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class PEHKBMJFNGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public HEKFNJCPPBA cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public PEHKBMJFNGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x67F7240", Offset = "0x67F6240", VA = "0x1867F7240")]
			internal void KNMOMHABOEA(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x67F7560", Offset = "0x67F6560", VA = "0x1867F7560")]
			internal void LDBHDDOIGOM(IIHCKDKPNDG<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class DHMHLAJECGN : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private MBMMHILCGCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public HEKFNJCPPBA cache;

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
			private PEHKBMJFNGG <>8__1;

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
			private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
			[DebuggerHidden]
			public DHMHLAJECGN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x67F0EF0", Offset = "0x67EFEF0", VA = "0x1867F0EF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x67F1710", Offset = "0x67F0710", VA = "0x1867F1710", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class DJFFABGEMBM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public DJFFABGEMBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5830BC0", Offset = "0x582FBC0", VA = "0x185830BC0")]
			internal IIHCKDKPNDG<T> PCGPLJKPKHE(BGHHBAEFCBP postResponse)
			{
				return default(IIHCKDKPNDG<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private LCAGPDDFOEC EOANLDPPLGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<CPGHKFMFPCM> JPBMDJLOIEO;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string JPCKAEIODCH = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string LKLNGIGJFKM = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string LPLOKCJOBJG = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int EJABDIDPFCH = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int FAOCJCMEFAD = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int LINFMBIACHF = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float KKMHCIMKAMC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long JMPJGHCEOFC = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string MJAJHOLPJME = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string GDNHLNBNLMH = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string FPBAFMCBMCD = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string FACINKLBCJN = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool JMGHEKIBCCE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool FNCLJMFKEPJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int DPIOPHOLGKA;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int PDCANLBOFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private NIMKLHJJLJP OGKEIKBBAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private HLDIBJPFHCP JCOHJGENDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private DIHEBHKLPPM JBFNFLFEMDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool DCPHLJFGMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float HMCKDOIGNAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float OCJHKNFLIBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int IKIFBGEAEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int AKHAOCDNAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? EBNNDOEMOCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? GHODECKMDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long GLCMDFNMELE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string GAKPGMPPGPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool DCGCCKODDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long KGHHIKEKAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string NFJIPFAEAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string FEMLGFFICNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> DKBHOPDKBBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private OOLDAHFGJPN JEKPBOOLCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int CADPDMDACCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int IIHKEHIHEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float KOFEPALOOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool CCGBPGIIOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool FMIOINAEDCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private HEKFNJCPPBA LOMKNMOEBCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private HEKFNJCPPBA EBKJPGOGKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private HEKFNJCPPBA KFJEMEHMIOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string BPNBKKOOJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> OCGAIMLBDDN;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo HMJLHFLJENP;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static string FKBDMDFNDCK;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string FMELOOAJGJO = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly string AFNGKJGIBPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string NDHBKCAMOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string FMJFAPJPHGP;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LCAGPDDFOEC OHLLLKFGDIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x67EA890", Offset = "0x67E9890", VA = "0x1867EA890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private CPGHKFMFPCM NHBPIHNKDHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x67EB300", Offset = "0x67EA300", VA = "0x1867EB300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int KLPLMJNEBBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x67EB030", Offset = "0x67EA030", VA = "0x1867EB030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long HIOMEAJBHLI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x67EE6B0", Offset = "0x67ED6B0", VA = "0x1867EE6B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x67EE7C0", Offset = "0x67ED7C0", VA = "0x1867EE7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string KAIDDAJLMKD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x67EE680", Offset = "0x67ED680", VA = "0x1867EE680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FHJNCKPPAJD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8D03B0", VA = "0x1808D13B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xBA25C0", Offset = "0xBA15C0", VA = "0x180BA25C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int? AOJMAHFKCPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8D13C0", Offset = "0x8D03C0", VA = "0x1808D13C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x16C93F0", Offset = "0x16C83F0", VA = "0x1816C93F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ANCFGDOKOCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1131930", Offset = "0x1130930", VA = "0x181131930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x117D6B0", Offset = "0x117C6B0", VA = "0x18117D6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool HKGFKKHJNFD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x67EE580", Offset = "0x67ED580", VA = "0x1867EE580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> IJLJMOIJIAH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x67EE4C0", Offset = "0x67ED4C0", VA = "0x1867EE4C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x67EE700", Offset = "0x67ED700", VA = "0x1867EE700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x67E8A00", Offset = "0x67E7A00", VA = "0x1867E8A00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x67E91F0", Offset = "0x67E81F0", VA = "0x1867E91F0")]
		private void BOECOKALLKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67EDAA0", Offset = "0x67ECAA0", VA = "0x1867EDAA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x67EC940", Offset = "0x67EB940", VA = "0x1867EC940", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x67EDE40", Offset = "0x67ECE40", VA = "0x1867EDE40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67ECA90", Offset = "0x67EBA90", VA = "0x1867ECA90")]
		public PGILFKJEHOF PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67EAFA0", Offset = "0x67E9FA0", VA = "0x1867EAFA0")]
		[IteratorStateMachine(typeof(DGABLFCJCCG))]
		public IEnumerator<MBMMHILCGCA> InitializeForLocalAccount(AmplitudeAnalyticsEvent PALLFKLNBOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x67ED240", Offset = "0x67EC240", VA = "0x1867ED240")]
		public void SendAppEnterEvent(bool GNAFAOEJGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67EDD80", Offset = "0x67ECD80", VA = "0x1867EDD80")]
		public void UpdateLastKnownInteractionCategory(string NJFPDMKPLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67EDC90", Offset = "0x67ECC90", VA = "0x1867EDC90")]
		public void UpdateLastAliveTime(float DGOHALMDCDO = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67EC880", Offset = "0x67EB880", VA = "0x1867EC880")]
		private PGILFKJEHOF OHCBFAJFFFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67EA4C0", Offset = "0x67E94C0", VA = "0x1867EA4C0")]
		private PGILFKJEHOF GIJGADKJOGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67ED4F0", Offset = "0x67EC4F0", VA = "0x1867ED4F0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67ECA00", Offset = "0x67EBA00", VA = "0x1867ECA00")]
		[IteratorStateMachine(typeof(IFPNJDNJGHM))]
		private IEnumerator PKBCGLEMJGC(NIIIJMDBGHD JJMOCGNHOMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x67EE0D0", Offset = "0x67ED0D0", VA = "0x1867EE0D0")]
		[IteratorStateMachine(typeof(FPEOJCFBMCC))]
		public IEnumerator WaitForFlush(float MNIKPDPFHJC = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x67EDB70", Offset = "0x67ECB70", VA = "0x1867EDB70")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x67EDAB0", Offset = "0x67ECAB0", VA = "0x1867EDAB0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime IKBJFKDEOPL)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67EAAD0", Offset = "0x67E9AD0", VA = "0x1867EAAD0")]
		public static AIECNFOOPAP Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67E8890", Offset = "0x67E7890", VA = "0x1867E8890")]
		public static JJAAPGCLBGK AccountSelectionPostLoginEvent([NotNull] string KOBJIHPDNIB, string OHPNDCFMKAD, bool LENEMKJJLNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67EA130", Offset = "0x67E9130", VA = "0x1867EA130")]
		public static JJAAPGCLBGK Event([NotNull] string KOBJIHPDNIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67ECAD0", Offset = "0x67EBAD0", VA = "0x1867ECAD0")]
		public static JJAAPGCLBGK PreviousSessionEvent([NotNull] string KOBJIHPDNIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67EAC80", Offset = "0x67E9C80", VA = "0x1867EAC80")]
		public static JJAAPGCLBGK InitializeEvent(string OHPNDCFMKAD, int PABAOKFNJLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67ED6B0", Offset = "0x67EC6B0", VA = "0x1867ED6B0")]
		public static JJAAPGCLBGK StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67E9890", Offset = "0x67E8890", VA = "0x1867E9890")]
		public static JJAAPGCLBGK CreateOutOfSessionEvent(string KOBJIHPDNIB, bool DLONFDPLBOD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67EB5D0", Offset = "0x67EA5D0", VA = "0x1867EB5D0")]
		public static PGILFKJEHOF LogOutOfSessionEvent(JJAAPGCLBGK OCAOLDKAGMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67EB350", Offset = "0x67EA350", VA = "0x1867EB350")]
		public void LogEventAsync(AmplitudeAnalyticsEvent EPPKDFPEPHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67EB7A0", Offset = "0x67EA7A0", VA = "0x1867EB7A0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent EPPKDFPEPHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x67EB8E0", Offset = "0x67EA8E0", VA = "0x1867EB8E0")]
		public void LogSerializedEventAsync(Dictionary<string, object> AHLOOCIJKGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67EB490", Offset = "0x67EA490", VA = "0x1867EB490")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage ACILHAPPACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67E9790", Offset = "0x67E8790", VA = "0x1867E9790")]
		private void CLDNEGOBDBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67E9AF0", Offset = "0x67E8AF0", VA = "0x1867E9AF0")]
		private void DGMFGJLEOLJ(Dictionary<string, object> EPPBBINIJEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67EB210", Offset = "0x67EA210", VA = "0x1867EB210")]
		private void LDOOHCCEKNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x67EA900", Offset = "0x67E9900", VA = "0x1867EA900")]
		private void IFDCJBMEAMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67EA430", Offset = "0x67E9430", VA = "0x1867EA430")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x67EC7F0", Offset = "0x67EB7F0", VA = "0x1867EC7F0")]
		[IteratorStateMachine(typeof(JFICAPOLGAC))]
		private IEnumerator<MBMMHILCGCA> OFGIECPALIG(float MNIKPDPFHJC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x67E9040", Offset = "0x67E8040", VA = "0x1867E9040")]
		[IteratorStateMachine(typeof(FBGCFMCCBGP))]
		private IEnumerator<MBMMHILCGCA> BCHHHAFCMOP(float MNIKPDPFHJC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x67EA7B0", Offset = "0x67E97B0", VA = "0x1867EA7B0")]
		[IteratorStateMachine(typeof(DHMHLAJECGN))]
		private IEnumerator<MBMMHILCGCA> HAGEPFOPALI(HEKFNJCPPBA AMAMLMNLJEL, int? IAOFEMGDFGI, string HICBNCCNEPA, float MNIKPDPFHJC, Action<int> MEPJADLCGHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x67E90E0", Offset = "0x67E80E0", VA = "0x1867E90E0")]
		private static void BMDMLHEDGLG(bool CDIELAKFLJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x67E9DA0", Offset = "0x67E8DA0", VA = "0x1867E9DA0")]
		private HCGNNEJAOHI<IIHCKDKPNDG<Dictionary<string, object>>> DPJJNHEAFOL(string HICBNCCNEPA, string KAJMJFOJDNO, Dictionary<string, object> CFPKNANJCOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x67E9E70", Offset = "0x67E8E70", VA = "0x1867E9E70")]
		private HCGNNEJAOHI<IIHCKDKPNDG<List<Dictionary<string, object>>>> DPJJNHEAFOL(string HICBNCCNEPA, string KAJMJFOJDNO, List<Dictionary<string, object>> CFPKNANJCOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x31F2130", Offset = "0x31F1130", VA = "0x1831F2130")]
		private HCGNNEJAOHI<IIHCKDKPNDG<T>> GNMHKFOJLCO<T>(string CNGEJIMOJIJ, string HICBNCCNEPA, string KAJMJFOJDNO, T CFPKNANJCOC, Dictionary<string, object> PEBJHIBCOBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x67EA0E0", Offset = "0x67E90E0", VA = "0x1867EA0E0")]
		private bool ENEELLBIJBL(float COKDJDHEACI, float MNIKPDPFHJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x67EB9C0", Offset = "0x67EA9C0", VA = "0x1867EB9C0")]
		private Dictionary<string, object> MGNJHBEKGIK(string HICBNCCNEPA, Dictionary<string, object> CFPKNANJCOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x67EE1C0", Offset = "0x67ED1C0", VA = "0x1867EE1C0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x67EC690", Offset = "0x67EB690", VA = "0x1867EC690")]
		[CompilerGenerated]
		private long OBJOFMLDCOF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x67E90D0", Offset = "0x67E80D0", VA = "0x1867E90D0")]
		[CompilerGenerated]
		private void BMCGOPLHFJM(int HNNEOKFOPBN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
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

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x67EF520", Offset = "0x67EE520", VA = "0x1867EF520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x67EF600", Offset = "0x67EE600", VA = "0x1867EF600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x67EF560", Offset = "0x67EE560", VA = "0x1867EF560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x67EF660", Offset = "0x67EE660", VA = "0x1867EF660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x67EF4E0", Offset = "0x67EE4E0", VA = "0x1867EF4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x67EF5A0", Offset = "0x67EE5A0", VA = "0x1867EF5A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x866E50", Offset = "0x865E50", VA = "0x180866E50")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x67EE820", Offset = "0x67ED820", VA = "0x1867EE820")]
		public static JJAAPGCLBGK GIGNPOIHFIA(string HNNOPDLCPBM, [NotNull] string LEOGAAKKHNN, long LKOPNCGNEGH, long PHOKHPJHJDA, string OHPNDCFMKAD, bool LENEMKJJLNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x67EEA30", Offset = "0x67EDA30", VA = "0x1867EEA30")]
		public static JJAAPGCLBGK IPIJLHEIGPL(string HNNOPDLCPBM, [NotNull] string LEOGAAKKHNN, long LKOPNCGNEGH, long PHOKHPJHJDA, string OHPNDCFMKAD, long FMODLGFKLKE, bool LENEMKJJLNI, string DOIEDHJHLAK, string LEKNLANKBIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x67EF350", Offset = "0x67EE350", VA = "0x1867EF350")]
		private AmplitudeAnalyticsEvent(string HNNOPDLCPBM, [NotNull] string LEOGAAKKHNN, long LKOPNCGNEGH, long PHOKHPJHJDA, string OHPNDCFMKAD, bool LENEMKJJLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1CCC940", Offset = "0x1CCB940", VA = "0x181CCC940")]
		public void INEJMFOIGAL(long BOBIBOJPLLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x67EF240", Offset = "0x67EE240", VA = "0x1867EF240", Slot = "5")]
		public override void NFEAPKHNCPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x67EF0C0", Offset = "0x67EE0C0", VA = "0x1867EF0C0", Slot = "6")]
		public override void MFEHMAIGCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x67EEB90", Offset = "0x67EDB90", VA = "0x1867EEB90", Slot = "4")]
		protected override Dictionary<string, object> JDDMOFPBELN(Dictionary<string, object> ANDJDKLJFIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x67EE920", Offset = "0x67ED920", VA = "0x1867EE920")]
		private void IGGLLKHOHJH(string BHEIPBKEDLG, string CBAEIEAPLIH, bool CJLPIDIGLKL = false)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
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

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x67F19C0", Offset = "0x67F09C0", VA = "0x1867F19C0")]
			public void CMCFFMOKKDF(Dictionary<string, object> CAOLIJGJLIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
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

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x67F79B0", Offset = "0x67F69B0", VA = "0x1867F79B0")]
			public void CMCFFMOKKDF(Dictionary<string, object> JCPJBBGELJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA9CC20", Offset = "0xA9BC20", VA = "0x180A9CC20")]
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
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8687E0", Offset = "0x8677E0", VA = "0x1808687E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x67EF750", Offset = "0x67EE750", VA = "0x1867EF750")]
		public static AIECNFOOPAP GIGNPOIHFIA(string HNNOPDLCPBM, string OHPNDCFMKAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x67EFD80", Offset = "0x67EED80", VA = "0x1867EFD80")]
		protected AmplitudeAnalyticsIdentifyMessage(string HNNOPDLCPBM, string OHPNDCFMKAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x67EF6C0", Offset = "0x67EE6C0", VA = "0x1867EF6C0")]
		public Dictionary<string, object> FPGEJNBFNDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x67EF810", Offset = "0x67EE810", VA = "0x1867EF810", Slot = "4")]
		protected virtual Dictionary<string, object> JDDMOFPBELN(Dictionary<string, object> ANDJDKLJFIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x67EFB50", Offset = "0x67EEB50", VA = "0x1867EFB50")]
		protected void KMGBAAPNOKN(string BHEIPBKEDLG, Dictionary<string, object> ENPEGLLPBKJ, Dictionary<string, object> MOJJACNFOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x67EFD10", Offset = "0x67EED10", VA = "0x1867EFD10")]
		protected void OBDJKDGBOJL(string BHEIPBKEDLG, string CBAEIEAPLIH, Dictionary<string, object> DJDPLLMFNJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x67EFC80", Offset = "0x67EEC80", VA = "0x1867EFC80", Slot = "5")]
		public virtual void NFEAPKHNCPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x67EFBF0", Offset = "0x67EEBF0", VA = "0x1867EFBF0", Slot = "6")]
		public virtual void MFEHMAIGCKM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AIECNFOOPAP : DJGKMPKLIPN<AmplitudeAnalyticsIdentifyMessage, AIECNFOOPAP>
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public override AIECNFOOPAP BOCHEDHCPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage CEHEHJDBNJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x67E7FC0", Offset = "0x67E6FC0", VA = "0x1867E7FC0")]
	public AIECNFOOPAP(AmplitudeAnalyticsIdentifyMessage NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x67E7F10", Offset = "0x67E6F10", VA = "0x1867E7F10", Slot = "4")]
	public override void MFEHMAIGCKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JJAAPGCLBGK : DJGKMPKLIPN<AmplitudeAnalyticsEvent, JJAAPGCLBGK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool GOCBCACOPAL;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override JJAAPGCLBGK BOCHEDHCPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public long EOOHHPGEINL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x67F5AE0", Offset = "0x67F4AE0", VA = "0x1867F5AE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x67F5C00", Offset = "0x67F4C00", VA = "0x1867F5C00")]
	public JJAAPGCLBGK(AmplitudeAnalyticsEvent NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0", Slot = "5")]
	public override AmplitudeAnalyticsEvent CEHEHJDBNJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x67F5A40", Offset = "0x67F4A40", VA = "0x1867F5A40", Slot = "4")]
	public override void MFEHMAIGCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD250", Offset = "0x2BAC250", VA = "0x182BAD250")]
	public JJAAPGCLBGK FHBJPHMBENH<T>(string PDOOMGNBLHC, T[] CBAEIEAPLIH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD250", Offset = "0x2BAC250", VA = "0x182BAD250")]
	public JJAAPGCLBGK FHBJPHMBENH(string PDOOMGNBLHC, string[] CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2BACFA0", Offset = "0x2BABFA0", VA = "0x182BACFA0")]
	public JJAAPGCLBGK FHBJPHMBENH<T>(string PDOOMGNBLHC, T CBAEIEAPLIH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x67F5990", Offset = "0x67F4990", VA = "0x1867F5990")]
	public JJAAPGCLBGK FHBJPHMBENH(string PDOOMGNBLHC, long CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x67F5920", Offset = "0x67F4920", VA = "0x1867F5920")]
	public JJAAPGCLBGK FHBJPHMBENH(string PDOOMGNBLHC, string CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x67F5A10", Offset = "0x67F4A10", VA = "0x1867F5A10")]
	public JJAAPGCLBGK JIOCMDJBIGD(string PDOOMGNBLHC, object? CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x67F5880", Offset = "0x67F4880", VA = "0x1867F5880")]
	public JJAAPGCLBGK DKNJFJBINEE(string PDOOMGNBLHC, string CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x67F5B00", Offset = "0x67F4B00", VA = "0x1867F5B00")]
	private JJAAPGCLBGK PIFMIAMEHBK(string PDOOMGNBLHC, object CBAEIEAPLIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OKEKONDBCLL : JJAAPGCLBGK
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x67F5C00", Offset = "0x67F4C00", VA = "0x1867F5C00")]
	public OKEKONDBCLL(AmplitudeAnalyticsEvent NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x67F7090", Offset = "0x67F6090", VA = "0x1867F7090", Slot = "4")]
	public override void MFEHMAIGCKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class DJGKMPKLIPN<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : DJGKMPKLIPN<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M NFOHONOFFAP;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract BLDR BOCHEDHCPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	public DJGKMPKLIPN(M NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5830E40", Offset = "0x582FE40", VA = "0x185830E40")]
	public BLDR MNAGFOFFAOB(AmplitudeAnalyticsIdentifyMessage.DeviceInfo PNFHPOPJOBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5830DF0", Offset = "0x582FDF0", VA = "0x185830DF0")]
	public BLDR MKPEJMMJICL(AmplitudeAnalyticsIdentifyMessage.RevenueData LGMFAOMPAKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5830D10", Offset = "0x582FD10", VA = "0x185830D10")]
	public BLDR JBNGALNGIDP(string PDOOMGNBLHC, string CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x274C720", Offset = "0x274B720", VA = "0x18274C720")]
	public BLDR JBNGALNGIDP<T>(string PDOOMGNBLHC, T CBAEIEAPLIH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void MFEHMAIGCKM();

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5830DC0", Offset = "0x582FDC0", VA = "0x185830DC0")]
	internal static string LNPIHAHDCMF(string CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5830C10", Offset = "0x582FC10", VA = "0x185830C10")]
	private BLDR DBPKMDKCMID(string PDOOMGNBLHC, object CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M CEHEHJDBNJD();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class DIEFCOEPKMC : NIMKLHJJLJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct FODLHLMFDEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<BGHHBAEFCBP> <>t__builder;

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
		public DIEFCOEPKMC <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x67F2AE0", Offset = "0x67F1AE0", VA = "0x1867F2AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x67F3510", Offset = "0x67F2510", VA = "0x1867F3510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient BFNKIHOEJMO;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x67F1760", Offset = "0x67F0760", VA = "0x1867F1760")]
	[PECFDJPHGEK(BOIKMOKIOJG.None)]
	private static void IFBCPDJCIHD(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x67F1940", Offset = "0x67F0940", VA = "0x1867F1940")]
	[RecRoom.NoEngine.Common.Preserve]
	public DIEFCOEPKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x67F17D0", Offset = "0x67F07D0", VA = "0x1867F17D0", Slot = "4")]
	[AsyncStateMachine(typeof(FODLHLMFDEL))]
	public Task<BGHHBAEFCBP> KDFBGHIEMFH(string CNGEJIMOJIJ, string JDJFCIDHDJH, string HCJLPGAHDGO, string BMBFEBMOMGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class AKELHBJFMIA : NIMKLHJJLJP
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class AFECMECFDAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TaskCompletionSource<BGHHBAEFCBP> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public AFECMECFDAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x67E7E30", Offset = "0x67E6E30", VA = "0x1867E7E30")]
		internal void COEPFMFCDMH(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct MIKAANIGPBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<BGHHBAEFCBP> <>t__builder;

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
		private TaskAwaiter<BGHHBAEFCBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x67F67E0", Offset = "0x67F57E0", VA = "0x1867F67E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x67F6D30", Offset = "0x67F5D30", VA = "0x1867F6D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	[PECFDJPHGEK(BOIKMOKIOJG.None)]
	private static void CPMOCDAFPHO(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	[RecRoom.NoEngine.Common.Preserve]
	public AKELHBJFMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x67E8010", Offset = "0x67E7010", VA = "0x1867E8010", Slot = "4")]
	[AsyncStateMachine(typeof(MIKAANIGPBH))]
	public Task<BGHHBAEFCBP> KDFBGHIEMFH(string CNGEJIMOJIJ, string JDJFCIDHDJH, string HCJLPGAHDGO, string BMBFEBMOMGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BAMBFHBNEAK
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> FNAJOFODCKI;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x67EFE40", Offset = "0x67EEE40", VA = "0x1867EFE40")]
	internal static bool HKNFBEPMIEJ(string BHEIPBKEDLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NIMKLHJJLJP
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BGHHBAEFCBP> KDFBGHIEMFH(string CNGEJIMOJIJ, string JDJFCIDHDJH, string HCJLPGAHDGO, string BMBFEBMOMGG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct BGHHBAEFCBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly int JMJEIFJJBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly string IIKIDHHFFFN;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0xD91A30", Offset = "0xD90A30", VA = "0x180D91A30")]
	public BGHHBAEFCBP(int GICIPAPDFBH, string IHNEKMANEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum LLIHINHBFOC
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
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CENLKHOHGGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private long PAECILHPEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private JJAAPGCLBGK BGIAHFKIAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool GCGPNMHEIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float NPAKCDEDCID;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x67F0380", Offset = "0x67EF380", VA = "0x1867F0380")]
	public CENLKHOHGGA(string NCLMBBBPFAH, float NPAKCDEDCID = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x292B330", Offset = "0x292A330", VA = "0x18292B330")]
	public void FHBJPHMBENH<T>(string PDOOMGNBLHC, T CBAEIEAPLIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x67F01A0", Offset = "0x67EF1A0", VA = "0x1867F01A0")]
	public void FHBJPHMBENH(string PDOOMGNBLHC, string CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x67F00B0", Offset = "0x67EF0B0", VA = "0x1867F00B0")]
	public void AOIFOIKNIJE(string ADGBAIOGEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x67EFFF0", Offset = "0x67EEFF0", VA = "0x1867EFFF0")]
	public void AIJOADFCJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x67F0220", Offset = "0x67EF220", VA = "0x1867F0220")]
	private void JOKDBEELIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x67F0330", Offset = "0x67EF330", VA = "0x1867F0330")]
	private bool NFPHFHEFKIL()
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
		public enum IIJODMIABEN
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
		private IIJODMIABEN parameterType;

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
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IIJODMIABEN Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8DB860", Offset = "0x8DA860", VA = "0x1808DB860")]
			get
			{
				return default(IIJODMIABEN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9CFAC0", Offset = "0x9CEAC0", VA = "0x1809CFAC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x67F7B20", Offset = "0x67F6B20", VA = "0x1867F7B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class GKBHDIAJFBH : FJDHNPAOKKO, FCOGOFLAMAM
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void GLCEPKDAHHK(EMPOFLJLFDB LFMBADLPAMJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly MNEGBJILLOH ACALJLMPPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly GLCEPKDAHHK NADCOCFLBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string LADDAOLFNGJ;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string NADGKMNBOGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1221560", Offset = "0x1220560", VA = "0x181221560", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IKGIELDKKPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x67F3C50", Offset = "0x67F2C50", VA = "0x1867F3C50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LOCABOAGPKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x67F3C30", Offset = "0x67F2C30", VA = "0x1867F3C30", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<string> GFGNPFAAHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1221290", Offset = "0x1220290", VA = "0x181221290", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x67F3C70", Offset = "0x67F2C70", VA = "0x1867F3C70")]
	public GKBHDIAJFBH(MNEGBJILLOH FFADDNJMIIP, string KPKIFNAGLBL, [Optional] GLCEPKDAHHK LANEMLOBHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B5D0", Offset = "0x2B1A5D0", VA = "0x182B1B5D0", Slot = "8")]
	public T BDJJCDMMBKL<T>(string BHEIPBKEDLG, T AJMLHGDNPEK)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class AAADPJJHLJI : KKBDEFJOIBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct GACLNJFGHNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AAADPJJHLJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public HLDIBJPFHCP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x67F3740", Offset = "0x67F2740", VA = "0x1867F3740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x67F3BD0", Offset = "0x67F2BD0", VA = "0x1867F3BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct NIOKFBNGIDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x67F6DA0", Offset = "0x67F5DA0", VA = "0x1867F6DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x67F6FB0", Offset = "0x67F5FB0", VA = "0x1867F6FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct JDIECINBOOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AAADPJJHLJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public HLDIBJPFHCP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x67F52B0", Offset = "0x67F42B0", VA = "0x1867F52B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x67F5570", Offset = "0x67F4570", VA = "0x1867F5570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct KKJCAFOAHJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AAADPJJHLJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public HLDIBJPFHCP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x67F5C50", Offset = "0x67F4C50", VA = "0x1867F5C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x67F6020", Offset = "0x67F5020", VA = "0x1867F6020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly IReadOnlyDictionary<string, DPPCJFAGPMO> KAPIFKMNLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool MIOAGFNKGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MKLCFOJGLLD OIBOMMDPBCL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LMMCDOJHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B8780", Offset = "0x8B7780", VA = "0x1808B8780", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string FHJNCKPPAJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x67E6CD0", Offset = "0x67E5CD0", VA = "0x1867E6CD0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public MGGOAIJEIPB BFOGFLKIDPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x67E7200", Offset = "0x67E6200", VA = "0x1867E7200", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NDEDBGEBIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x67E6820", Offset = "0x67E5820", VA = "0x1867E6820", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x67E68C0", Offset = "0x67E58C0", VA = "0x1867E68C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action POMCLLACPKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x67E6780", Offset = "0x67E5780", VA = "0x1867E6780", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x67E7160", Offset = "0x67E6160", VA = "0x1867E7160", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<EMPOFLJLFDB> NBGJHNKOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x67E6A70", Offset = "0x67E5A70", VA = "0x1867E6A70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x67E6E00", Offset = "0x67E5E00", VA = "0x1867E6E00", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x67E6420", Offset = "0x67E5420", VA = "0x1867E6420", Slot = "10")]
	[AsyncStateMachine(typeof(GACLNJFGHNO))]
	public Task BGGINNGCCML(string NHHBOGKKMDF, [Optional] HLDIBJPFHCP JLANMLLPCND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x67E6EB0", Offset = "0x67E5EB0", VA = "0x1867E6EB0", Slot = "19")]
	[AsyncStateMachine(typeof(NIOKFBNGIDA))]
	public Task LLEEPCOAPIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x67E7070", Offset = "0x67E6070", VA = "0x1867E7070", Slot = "14")]
	[AsyncStateMachine(typeof(JDIECINBOOG))]
	public Task MJFGGHBPAFH(HLDIBJPFHCP JLANMLLPCND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x67E66E0", Offset = "0x67E56E0", VA = "0x1867E66E0")]
	private void CFFBCKKMEKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x67E6F60", Offset = "0x67E5F60", VA = "0x1867E6F60", Slot = "15")]
	[AsyncStateMachine(typeof(KKJCAFOAHJD))]
	public Task MFPLIEOOJGF(HLDIBJPFHCP JLANMLLPCND, Dictionary<string, string> OEBNFLIKNLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x67E6CE0", Offset = "0x67E5CE0", VA = "0x1867E6CE0", Slot = "16")]
	public bool KIOCMKBKEMF(string IJLNIAGLAGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x67E6530", Offset = "0x67E5530", VA = "0x1867E6530", Slot = "17")]
	public FJDHNPAOKKO CBGPGKDHBMG(string KPKIFNAGLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x67E6260", Offset = "0x67E5260", VA = "0x1867E6260")]
	private MNEGBJILLOH BFEACFCHBBG(string KPKIFNAGLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x67E7B10", Offset = "0x67E6B10", VA = "0x1867E7B10", Slot = "18")]
	public BAEMJIDOOBK PKMIKMCODIL(string DLLMDAGIEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x67E6D70", Offset = "0x67E5D70", VA = "0x1867E6D70")]
	private IJDFJLEELEF LDFMICMHOIH(string DLLMDAGIEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x67E7230", Offset = "0x67E6230", VA = "0x1867E7230")]
	private MHMNFGNBGHB PBJACJKLKLH(HLDIBJPFHCP JLANMLLPCND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x67E6B20", Offset = "0x67E5B20", VA = "0x1867E6B20")]
	private BHLMDGJJLCG JIPGHPNECME(string NHHBOGKKMDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x67E6960", Offset = "0x67E5960", VA = "0x1867E6960")]
	private void IHOGEIHEAKI(string KPKIFNAGLBL, MNEGBJILLOH FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public AAADPJJHLJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x67E6220", Offset = "0x67E5220", VA = "0x1867E6220")]
	[CompilerGenerated]
	private void GADALGPLMCE(EMPOFLJLFDB LJNBPEFJOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x67E6220", Offset = "0x67E5220", VA = "0x1867E6220")]
	[CompilerGenerated]
	private void AKABPDCOJPG(EMPOFLJLFDB LJNBPEFJOFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class FNMABMCDKLD : KKBDEFJOIBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct ANJMHAGMADJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public FNMABMCDKLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public HLDIBJPFHCP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x67E8170", Offset = "0x67E7170", VA = "0x1867E8170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x67E8830", Offset = "0x67E7830", VA = "0x1867E8830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private KKBDEFJOIBO PDNLICNCIHL;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private KKBDEFJOIBO HNAILNEMKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x67F20C0", Offset = "0x67F10C0", VA = "0x1867F20C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LMMCDOJHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x67F2A90", Offset = "0x67F1A90", VA = "0x1867F2A90", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string FHJNCKPPAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x67F2390", Offset = "0x67F1390", VA = "0x1867F2390", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public MGGOAIJEIPB BFOGFLKIDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x67F2920", Offset = "0x67F1920", VA = "0x1867F2920", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action NDEDBGEBIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x67F2130", Offset = "0x67F1130", VA = "0x1867F2130", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x67F21D0", Offset = "0x67F11D0", VA = "0x1867F21D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action POMCLLACPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x67F2020", Offset = "0x67F1020", VA = "0x1867F2020", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x67F2880", Offset = "0x67F1880", VA = "0x1867F2880", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<EMPOFLJLFDB> NBGJHNKOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x67F22E0", Offset = "0x67F12E0", VA = "0x1867F22E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x67F2490", Offset = "0x67F1490", VA = "0x1867F2490", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	[UnityEngine.Scripting.Preserve]
	public FNMABMCDKLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x67F1FB0", Offset = "0x67F0FB0", VA = "0x1867F1FB0")]
	[PECFDJPHGEK(BOIKMOKIOJG.GameOnly)]
	private static void DBDMEAACDHD(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x67F2270", Offset = "0x67F1270", VA = "0x1867F2270")]
	[PECFDJPHGEK(BOIKMOKIOJG.EditorOnly)]
	private static void IFBCOILACCH(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x67F1DF0", Offset = "0x67F0DF0", VA = "0x1867F1DF0", Slot = "10")]
	[AsyncStateMachine(typeof(ANJMHAGMADJ))]
	public Task BGGINNGCCML(string NHHBOGKKMDF, [Optional] HLDIBJPFHCP JLANMLLPCND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x67F2770", Offset = "0x67F1770", VA = "0x1867F2770", Slot = "14")]
	public Task MJFGGHBPAFH(HLDIBJPFHCP JLANMLLPCND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x67F2650", Offset = "0x67F1650", VA = "0x1867F2650", Slot = "15")]
	public Task MFPLIEOOJGF(HLDIBJPFHCP JLANMLLPCND, Dictionary<string, string> OEBNFLIKNLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67F23E0", Offset = "0x67F13E0", VA = "0x1867F23E0", Slot = "16")]
	public bool KIOCMKBKEMF(string IJLNIAGLAGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x67F1F00", Offset = "0x67F0F00", VA = "0x1867F1F00", Slot = "17")]
	public FJDHNPAOKKO CBGPGKDHBMG(string KPKIFNAGLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x67F29E0", Offset = "0x67F19E0", VA = "0x1867F29E0", Slot = "18")]
	public BAEMJIDOOBK PKMIKMCODIL(string DLLMDAGIEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x67F2540", Offset = "0x67F1540", VA = "0x1867F2540", Slot = "19")]
	public Task LLEEPCOAPIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8B1840", Offset = "0x8B0840", VA = "0x1808B1840")]
	[CompilerGenerated]
	private void KAMMKOPIGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x980740", Offset = "0x97F740", VA = "0x180980740")]
	[CompilerGenerated]
	private void DIGFJBNLFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x67E6220", Offset = "0x67E5220", VA = "0x1867E6220")]
	[CompilerGenerated]
	private void KNCLDAGNOHH(EMPOFLJLFDB LJNBPEFJOFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal class KGLDJGKMADM : BAEMJIDOOBK, FCOGOFLAMAM
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate void ELKMLELNNNC(EMPOFLJLFDB LFMBADLPAMJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly ELKMLELNNNC NADCOCFLBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly IJDFJLEELEF JJBBEEPEJBK;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string NADGKMNBOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1C5F520", Offset = "0x1C5E520", VA = "0x181C5F520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5B3CF20", Offset = "0x5B3BF20", VA = "0x185B3CF20")]
	public KGLDJGKMADM(IJDFJLEELEF AHFHOBDDPJH, [Optional] ELKMLELNNNC LANEMLOBHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2BED220", Offset = "0x2BEC220", VA = "0x182BED220", Slot = "5")]
	public T BDJJCDMMBKL<T>(string BHEIPBKEDLG, T AJMLHGDNPEK)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface OIFLBOIFAJB
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[UsedImplicitly]
public class DCNEHNOKAJH : OIFLBOIFAJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly IKNBMEDHKON JIHAMPFKKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly List<CFJPGFGPLEM> MJDCEFEDPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly string PADFNLEOKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly string NCCPAOKAOLO;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x67F0510", Offset = "0x67EF510", VA = "0x1867F0510")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.GameOnly)]
	[UsedImplicitly]
	private static void JEEKJHILOBP(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x67F0580", Offset = "0x67EF580", VA = "0x1867F0580")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DCNEHNOKAJH([JFHFHOOOEKP(null)][NotNull] IKNBMEDHKON JIHAMPFKKGO, [NotNull][JFHFHOOOEKP(null)] MDHJNFKADGL JNNLKHDLLKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class MDNNKCLHIGH : KKBDEFJOIBO
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool LMMCDOJHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string FHJNCKPPAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MGGOAIJEIPB BFOGFLKIDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action NDEDBGEBIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x67F6260", Offset = "0x67F5260", VA = "0x1867F6260", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x67F6300", Offset = "0x67F5300", VA = "0x1867F6300", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action POMCLLACPKN
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x67F61C0", Offset = "0x67F51C0", VA = "0x1867F61C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x67F66B0", Offset = "0x67F56B0", VA = "0x1867F66B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<EMPOFLJLFDB> NBGJHNKOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x67F63A0", Offset = "0x67F53A0", VA = "0x1867F63A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x67F6450", Offset = "0x67F5450", VA = "0x1867F6450", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	[RecRoom.NoEngine.Common.Preserve]
	public MDNNKCLHIGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x67F6080", Offset = "0x67F5080", VA = "0x1867F6080", Slot = "10")]
	public Task BGGINNGCCML(string NHHBOGKKMDF, [Optional] HLDIBJPFHCP JLANMLLPCND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x67F6620", Offset = "0x67F5620", VA = "0x1867F6620", Slot = "14")]
	public Task MJFGGHBPAFH(HLDIBJPFHCP JLANMLLPCND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x67F6590", Offset = "0x67F5590", VA = "0x1867F6590", Slot = "15")]
	public Task MFPLIEOOJGF(HLDIBJPFHCP JLANMLLPCND, Dictionary<string, string> OEBNFLIKNLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "16")]
	public bool KIOCMKBKEMF(string IJLNIAGLAGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x67F6110", Offset = "0x67F5110", VA = "0x1867F6110", Slot = "17")]
	public FJDHNPAOKKO CBGPGKDHBMG(string KPKIFNAGLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x67F6750", Offset = "0x67F5750", VA = "0x1867F6750", Slot = "18")]
	public BAEMJIDOOBK PKMIKMCODIL(string DLLMDAGIEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x67F6500", Offset = "0x67F5500", VA = "0x1867F6500", Slot = "19")]
	public Task LLEEPCOAPIE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal class MKLCFOJGLLD : MGGOAIJEIPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly MHMNFGNBGHB CDLJKOMKAEA;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IReadOnlyDictionary<string, object> OBFLIENNFON
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x12214F0", Offset = "0x12204F0", VA = "0x1812214F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	public MKLCFOJGLLD(MHMNFGNBGHB DCMIPDHNBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface KNGCEDNFFFK
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CENLKHOHGGA JCAOIOBBJMO(string NCLMBBBPFAH);
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
