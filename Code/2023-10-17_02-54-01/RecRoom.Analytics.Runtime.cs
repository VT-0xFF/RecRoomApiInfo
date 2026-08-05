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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BED1A0", Offset = "0x5BEB9A0", VA = "0x185BED1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78D480", Offset = "0x78BC80", VA = "0x18078D480")]
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
		public AmplitudeAnalyticsClient.Settings LGKPOBBBMBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GBAKIMKHDDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x76E480", Offset = "0x76CC80", VA = "0x18076E480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum OFDHJDIGCDO
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class BALLLEMGKDI
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class LPKFLAJOCMP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000046")]
				public int HOMEEPEOHCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public Dictionary<string, object> PHCAEBKHBGE;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
				public LPKFLAJOCMP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class BEGHDIKGBCJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
				public BEGHDIKGBCJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5BE8590", Offset = "0x5BE6D90", VA = "0x185BE8590")]
				internal bool GNGJFMJKGPC(LPKFLAJOCMP item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private const string CFHLAKGBEJE = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private readonly string EPIKKECCKMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private List<LPKFLAJOCMP> JCJPLJLNBJC;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? EOBNNPILKIF
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5BE7270", Offset = "0x5BE5A70", VA = "0x185BE7270")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5BE8400", Offset = "0x5BE6C00", VA = "0x185BE8400")]
			internal BALLLEMGKDI(string NAOKMCNDMIM, string NFAOOICADEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7D50", Offset = "0x5BE6550", VA = "0x185BE7D50")]
			public int LKDEMGOCAJM([Optional] int? ENAJNBKMCNG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7950", Offset = "0x5BE6150", VA = "0x185BE7950")]
			public List<Dictionary<string, object>> GCMIHLHNOMJ(int JAHANIHPLJB, int? ENAJNBKMCNG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5BE8360", Offset = "0x5BE6B60", VA = "0x185BE8360")]
			public void NJNMEFPFOLF(AmplitudeAnalyticsIdentifyMessage CBBCDNDPNHF, bool KOPFOGFPOPJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5BE8250", Offset = "0x5BE6A50", VA = "0x185BE8250")]
			public void NJNMEFPFOLF(Dictionary<string, object> CBBCDNDPNHF, bool KOPFOGFPOPJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7BC0", Offset = "0x5BE63C0", VA = "0x185BE7BC0")]
			public void GFJMKBOLOKB(params Dictionary<string, object>[] BEOKBNNFIOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7310", Offset = "0x5BE5B10", VA = "0x185BE7310")]
			public void BCPNDFFLAID(List<Dictionary<string, object>> GONHOCDPHNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7F00", Offset = "0x5BE6700", VA = "0x185BE7F00")]
			private void MHKGGOOKBNH(Dictionary<string, object> CBBCDNDPNHF, bool KOPFOGFPOPJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5BE8010", Offset = "0x5BE6810", VA = "0x185BE8010")]
			public void NHPMLJLBGEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7560", Offset = "0x5BE5D60", VA = "0x185BE7560")]
			private void FNOABJKEDKN([Optional] string PDDMEDNHCPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7140", Offset = "0x5BE5940", VA = "0x185BE7140")]
			private static string ADJOGCIOHOG(string FKKGMPDEPMA, string OHPCNPKOLBJ)
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
			[Cpp2IlInjected.Address(RVA = "0x5BEE670", Offset = "0x5BECE70", VA = "0x185BEE670")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct FJCFHMNPBNG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int COGNLFLODGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public string MFFBJFLNALG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public T MFCDLJKLIHE;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LBFPDELLEHJ : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private DENFKKKFFPI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
			[DebuggerHidden]
			public LBFPDELLEHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5BEBAC0", Offset = "0x5BEA2C0", VA = "0x185BEBAC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5BEC280", Offset = "0x5BEAA80", VA = "0x185BEC280", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JKFANCOCOMF : IEnumerator<object>, IEnumerator, IDisposable
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
			public FBEIGKILPLF quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
			[DebuggerHidden]
			public JKFANCOCOMF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5BEB960", Offset = "0x5BEA160", VA = "0x185BEB960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5BEBA70", Offset = "0x5BEA270", VA = "0x185BEBA70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class CFOPNKHBDGB : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
			[DebuggerHidden]
			public CFOPNKHBDGB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5BE8600", Offset = "0x5BE6E00", VA = "0x185BE8600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5BE8770", Offset = "0x5BE6F70", VA = "0x185BE8770", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class AIKKIHPFJID : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private DENFKKKFFPI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
			[DebuggerHidden]
			public AIKKIHPFJID(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5BDFC60", Offset = "0x5BDE460", VA = "0x185BDFC60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5BDFEE0", Offset = "0x5BDE6E0", VA = "0x185BDFEE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class HCMBNCDHLJG : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private DENFKKKFFPI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
			[DebuggerHidden]
			public HCMBNCDHLJG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5BEB580", Offset = "0x5BE9D80", VA = "0x185BEB580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5BEB810", Offset = "0x5BEA010", VA = "0x185BEB810", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class GMHMFNLJLGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public BALLLEMGKDI cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public GMHMFNLJLGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5BE9210", Offset = "0x5BE7A10", VA = "0x185BE9210")]
			internal void GJENGIFGLDD(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5BE9530", Offset = "0x5BE7D30", VA = "0x185BE9530")]
			internal void GJNADMDGGID(FJCFHMNPBNG<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class OPPHJFDIFDI : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private DENFKKKFFPI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public BALLLEMGKDI cache;

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
			private GMHMFNLJLGI <>8__1;

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
			private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
			[DebuggerHidden]
			public OPPHJFDIFDI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5BED8B0", Offset = "0x5BEC0B0", VA = "0x185BED8B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5BEE100", Offset = "0x5BEC900", VA = "0x185BEE100", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class IPIJDKNEAAE<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public IPIJDKNEAAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3669220", Offset = "0x3667A20", VA = "0x183669220")]
			internal FJCFHMNPBNG<T> NLCJAMNMAKG(BHLFIICDNJL postResponse)
			{
				return default(FJCFHMNPBNG<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class JNEHNCJFBPB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public JNEHNCJFBPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3669220", Offset = "0x3667A20", VA = "0x183669220")]
			internal FJCFHMNPBNG<T> KJAPNPLGFMN(BHLFIICDNJL postResponse)
			{
				return default(FJCFHMNPBNG<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private POMIFCOBDBE KNJLEEAAJGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<JKMDHKCKKHD> HNBOHMNIAAD;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string MDMKLHHKGHM = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string PCBLMAJCAMN = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string BJNIEGMHLDC = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int BKLPHJGICKN = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int FMFBIAABPPN = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int DDFMPKHBKBD = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float MKPGMIILHBA = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long HHJCBPPIHEM = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string MHCEBGHCONO = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string FHGDAMKKACI = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool BOEFBMCPBDE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool LPNCAHMABGB;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int MMABMILGEGG;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int KEIDBNBPOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private KMCEDLBIPPL KGDKFJAJPAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private FPBMMBACAAH CHCEMDCLDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool HFMFLDOKKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private float KBPGIPDLILB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float KGKJKFOAINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int PAGAJBOBBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int ELCENCOPPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int? NLFBNIOKLBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? OCJIHIPCDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private long NGACOOGIECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private string POHNNBLJGOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool HENADNKIOLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long GCELGIPMBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string EKIIHOAKMCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string JPNCAHLPJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Dictionary<string, object> EHCMGPNIBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private OFDHJDIGCDO BDOGHFABMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int KGEKDMGPPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int HDGEHIEONAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private float GLNDHICMJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool COFMLJMIGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool NNONNJLKPJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private BALLLEMGKDI HAMDLNOMKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private BALLLEMGKDI IFKHHJGJAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private BALLLEMGKDI CKECPAKOBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> GEPBPHBINNM;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo JALALKDMDKI;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static string CNAKJCCPNIH;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const string JNCOAGFHBGC = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string JCJIIBFAKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string KJLGIPPGKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string NOLNEFAJCPN;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private POMIFCOBDBE CIGIBIHHOEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5BE0790", Offset = "0x5BDEF90", VA = "0x185BE0790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private JKMDHKCKKHD BGBDDOFBDIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5BE1800", Offset = "0x5BE0000", VA = "0x185BE1800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int CLHFKAEEMIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5BDFF30", Offset = "0x5BDE730", VA = "0x185BDFF30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long DHFKOEGGAJD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5BE59B0", Offset = "0x5BE41B0", VA = "0x185BE59B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5BE5AC0", Offset = "0x5BE42C0", VA = "0x185BE5AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string DLJDDHHONAG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5BE5950", Offset = "0x5BE4150", VA = "0x185BE5950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string LPKFIFKLAOA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5BE5980", Offset = "0x5BE4180", VA = "0x185BE5980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NIDIIIMNNFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7DDAD0", Offset = "0x7DC2D0", VA = "0x1807DDAD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7DDAE0", Offset = "0x7DC2E0", VA = "0x1807DDAE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? HODABIBPFPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8B6380", Offset = "0x8B4B80", VA = "0x1808B6380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x10C2760", Offset = "0x10C0F60", VA = "0x1810C2760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ANDGBEGIPJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x93BF80", Offset = "0x93A780", VA = "0x18093BF80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xE64D40", Offset = "0xE63540", VA = "0x180E64D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool NOGICFJDLIK
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5BE5850", Offset = "0x5BE4050", VA = "0x185BE5850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> KHHPABNIIPF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5BE5790", Offset = "0x5BE3F90", VA = "0x185BE5790")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5BE5A00", Offset = "0x5BE4200", VA = "0x185BE5A00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5BE02D0", Offset = "0x5BDEAD0", VA = "0x185BE02D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0AF0", Offset = "0x5BDF2F0", VA = "0x185BE0AF0")]
		private void EDGPPGMACCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4D70", Offset = "0x5BE3570", VA = "0x185BE4D70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3F50", Offset = "0x5BE2750", VA = "0x185BE3F50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5BE5110", Offset = "0x5BE3910", VA = "0x185BE5110")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4010", Offset = "0x5BE2810", VA = "0x185BE4010")]
		public CPOBDANHFCI PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1F90", Offset = "0x5BE0790", VA = "0x185BE1F90")]
		[IteratorStateMachine(typeof(LBFPDELLEHJ))]
		public IEnumerator<DENFKKKFFPI> Initialize(AmplitudeAnalyticsEvent HOFIICBEBAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE5050", Offset = "0x5BE3850", VA = "0x185BE5050")]
		public void UpdateLastKnownInteractionCategory(string JODICHFPDAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4F60", Offset = "0x5BE3760", VA = "0x185BE4F60")]
		public void UpdateLastAliveTime(float OEPJOFDPCAM = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3DA0", Offset = "0x5BE25A0", VA = "0x185BE3DA0")]
		private CPOBDANHFCI NNGDINFBOOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5BE2E10", Offset = "0x5BE1610", VA = "0x185BE2E10")]
		private CPOBDANHFCI KHBFNBOAIMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5BE47C0", Offset = "0x5BE2FC0", VA = "0x185BE47C0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5BE2D80", Offset = "0x5BE1580", VA = "0x185BE2D80")]
		[IteratorStateMachine(typeof(JKFANCOCOMF))]
		private IEnumerator KCPINDLLCAF(FBEIGKILPLF NJLOPGEEPCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5BE53A0", Offset = "0x5BE3BA0", VA = "0x185BE53A0")]
		[IteratorStateMachine(typeof(CFOPNKHBDGB))]
		public IEnumerator WaitForFlush(float EHHDIDGCGLB = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4E40", Offset = "0x5BE3640", VA = "0x185BE4E40")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4D80", Offset = "0x5BE3580", VA = "0x185BE4D80")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime EICMLNGBGBA)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1B00", Offset = "0x5BE0300", VA = "0x185BE1B00")]
		public static JFNLFBBGGMK Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0160", Offset = "0x5BDE960", VA = "0x185BE0160")]
		public static EOHMAFNNPGM AccountSelectionPostLoginEvent([NotNull] string GKAEKCFPPBI, string OEHJGBNCEDG, bool HMGJHDIGJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5BE12A0", Offset = "0x5BDFAA0", VA = "0x185BE12A0")]
		public static EOHMAFNNPGM Event([NotNull] string GKAEKCFPPBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4050", Offset = "0x5BE2850", VA = "0x185BE4050")]
		public static EOHMAFNNPGM PreviousSessionEvent([NotNull] string GKAEKCFPPBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1CB0", Offset = "0x5BE04B0", VA = "0x185BE1CB0")]
		public static EOHMAFNNPGM InitializeEvent(string OEHJGBNCEDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4980", Offset = "0x5BE3180", VA = "0x185BE4980")]
		public static EOHMAFNNPGM StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0890", Offset = "0x5BDF090", VA = "0x185BE0890")]
		public static EOHMAFNNPGM CreateOutOfSessionEvent(string GKAEKCFPPBI, bool KPJJHLABHGO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3790", Offset = "0x5BE1F90", VA = "0x185BE3790")]
		public static CPOBDANHFCI LogOutOfSessionEvent(EOHMAFNNPGM CEDMGLGEIBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3510", Offset = "0x5BE1D10", VA = "0x185BE3510")]
		public void LogEventAsync(AmplitudeAnalyticsEvent AGHPMAJHDPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3A80", Offset = "0x5BE2280", VA = "0x185BE3A80")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent AGHPMAJHDPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3BC0", Offset = "0x5BE23C0", VA = "0x185BE3BC0")]
		public void LogSerializedEventAsync(Dictionary<string, object> PNOEGCCMGBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3650", Offset = "0x5BE1E50", VA = "0x185BE3650")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage COLGNCBAJNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3CA0", Offset = "0x5BE24A0", VA = "0x185BE3CA0")]
		private void NECCGFPJEKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1850", Offset = "0x5BE0050", VA = "0x185BE1850")]
		private void ICFNALENBCL(Dictionary<string, object> CPAELIEJCIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3E60", Offset = "0x5BE2660", VA = "0x185BE3E60")]
		private void OMIEGFIOKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1630", Offset = "0x5BDFE30", VA = "0x185BE1630")]
		private void GCPJNHHFENC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5BE15A0", Offset = "0x5BDFDA0", VA = "0x185BE15A0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5BE2CF0", Offset = "0x5BE14F0", VA = "0x185BE2CF0")]
		[IteratorStateMachine(typeof(AIKKIHPFJID))]
		private IEnumerator<DENFKKKFFPI> JOMFDKPMGHE(float EHHDIDGCGLB = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0800", Offset = "0x5BDF000", VA = "0x185BE0800")]
		[IteratorStateMachine(typeof(HCMBNCDHLJG))]
		private IEnumerator<DENFKKKFFPI> CFDAAPBFBBK(float EHHDIDGCGLB = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1090", Offset = "0x5BDF890", VA = "0x185BE1090")]
		[IteratorStateMachine(typeof(OPPHJFDIFDI))]
		private IEnumerator<DENFKKKFFPI> EEAMJBJJBBJ(BALLLEMGKDI FNDFNDILEGH, int? ENAJNBKMCNG, string HKDGJPKCALD, string IKMLAEJJGPP, float EHHDIDGCGLB, Action<int> GNCCCCGEJBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1190", Offset = "0x5BDF990", VA = "0x185BE1190")]
		private static void EOHNHGEEGPK(bool MHPPDPPONOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE33F0", Offset = "0x5BE1BF0", VA = "0x185BE33F0")]
		private NLPPPLCCBHA<FJCFHMNPBNG<Dictionary<string, object>>> LDPHBPGJNLO(string HKDGJPKCALD, string IKMLAEJJGPP, string FJIFLKCDNOM, string EJOILOGHAMA, Dictionary<string, object> MFCDLJKLIHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3110", Offset = "0x5BE1910", VA = "0x185BE3110")]
		private NLPPPLCCBHA<FJCFHMNPBNG<List<Dictionary<string, object>>>> LDPHBPGJNLO(string HKDGJPKCALD, string IKMLAEJJGPP, string FJIFLKCDNOM, string EJOILOGHAMA, List<Dictionary<string, object>> MFCDLJKLIHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x29E1EE0", Offset = "0x29E06E0", VA = "0x1829E1EE0")]
		private NLPPPLCCBHA<FJCFHMNPBNG<T>> BPIEIIOHMOP<T>(string HKDGJPKCALD, string IKMLAEJJGPP, string EJOILOGHAMA, T MFCDLJKLIHE, Dictionary<string, object> MIPGMHKMIEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x29E2180", Offset = "0x29E0980", VA = "0x1829E2180")]
		private NLPPPLCCBHA<FJCFHMNPBNG<T>> JNGNDJDADHK<T>(string HKDGJPKCALD, string IKMLAEJJGPP, string FJIFLKCDNOM, T MFCDLJKLIHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0110", Offset = "0x5BDE910", VA = "0x185BE0110")]
		private bool AMLOJIDLMFG(float JGBNMNFPCHG, float EHHDIDGCGLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5BE2020", Offset = "0x5BE0820", VA = "0x185BE2020")]
		private Dictionary<string, object> JKODOPHGHDL(string IKMLAEJJGPP, Dictionary<string, object> MFCDLJKLIHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5BE5490", Offset = "0x5BE3C90", VA = "0x185BE5490")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0630", Offset = "0x5BDEE30", VA = "0x185BE0630")]
		[CompilerGenerated]
		private long BBADBEGPJFG()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3100", Offset = "0x5BE1900", VA = "0x185BE3100")]
		[CompilerGenerated]
		private void KMEJKGHMLBG(int KKLDJHBHECM)
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
			[Cpp2IlInjected.Address(RVA = "0x5BE6820", Offset = "0x5BE5020", VA = "0x185BE6820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5BE6900", Offset = "0x5BE5100", VA = "0x185BE6900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5BE6860", Offset = "0x5BE5060", VA = "0x185BE6860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5BE6960", Offset = "0x5BE5160", VA = "0x185BE6960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5BE67E0", Offset = "0x5BE4FE0", VA = "0x185BE67E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5BE68A0", Offset = "0x5BE50A0", VA = "0x185BE68A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x761C20", Offset = "0x760420", VA = "0x180761C20")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5BE62C0", Offset = "0x5BE4AC0", VA = "0x185BE62C0")]
		public static EOHMAFNNPGM KLKFANDJKFE(string IFOEKNINMPE, [NotNull] string CBAOCALLDAL, long OOGONGDDKNA, long BLLOFGDDIFC, string OEHJGBNCEDG, bool HMGJHDIGJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5BE5C30", Offset = "0x5BE4430", VA = "0x185BE5C30")]
		public static EOHMAFNNPGM BHNDBNGJLMI(string IFOEKNINMPE, [NotNull] string CBAOCALLDAL, long OOGONGDDKNA, long BLLOFGDDIFC, string OEHJGBNCEDG, long GPIIOOLEKPJ, bool HMGJHDIGJNO, string KALPDGDCCGK, string OJPJBEJJMHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6650", Offset = "0x5BE4E50", VA = "0x185BE6650")]
		private AmplitudeAnalyticsEvent(string IFOEKNINMPE, [NotNull] string CBAOCALLDAL, long OOGONGDDKNA, long BLLOFGDDIFC, string OEHJGBNCEDG, bool HMGJHDIGJNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1857A30", Offset = "0x1856230", VA = "0x181857A30")]
		public void HCDFDAODKNN(long JPMDAMFHHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5BE5B20", Offset = "0x5BE4320", VA = "0x185BE5B20", Slot = "5")]
		public override void AEFLAIBGDNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5BE64D0", Offset = "0x5BE4CD0", VA = "0x185BE64D0", Slot = "6")]
		public override void PHKKKHNFEBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5BE5D90", Offset = "0x5BE4590", VA = "0x185BE5D90", Slot = "4")]
		protected override Dictionary<string, object> JBEHPPJLIBE(Dictionary<string, object> AGJOLOHHCPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5BE63C0", Offset = "0x5BE4BC0", VA = "0x185BE63C0")]
		private void LPAJJMEIKPD(string OHPCNPKOLBJ, string FKKGMPDEPMA, bool DBPDJHLCHAC = false)
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
			[Cpp2IlInjected.Address(RVA = "0x5BE8CE0", Offset = "0x5BE74E0", VA = "0x185BE8CE0")]
			public void ENCIEECKENM(Dictionary<string, object> PCFHDKJAGIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			[Cpp2IlInjected.Address(RVA = "0x5BEE300", Offset = "0x5BECB00", VA = "0x185BEE300")]
			public void ENCIEECKENM(Dictionary<string, object> MJJIMAGOFCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7F0880", Offset = "0x7EF080", VA = "0x1807F0880")]
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
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6F30", Offset = "0x5BE5730", VA = "0x185BE6F30")]
		public static JFNLFBBGGMK KLKFANDJKFE(string IFOEKNINMPE, string OEHJGBNCEDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE7080", Offset = "0x5BE5880", VA = "0x185BE7080")]
		protected AmplitudeAnalyticsIdentifyMessage(string IFOEKNINMPE, string OEHJGBNCEDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6A50", Offset = "0x5BE5250", VA = "0x185BE6A50")]
		public Dictionary<string, object> DMLOHOOKPHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6B50", Offset = "0x5BE5350", VA = "0x185BE6B50", Slot = "4")]
		protected virtual Dictionary<string, object> JBEHPPJLIBE(Dictionary<string, object> AGJOLOHHCPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6E90", Offset = "0x5BE5690", VA = "0x185BE6E90")]
		protected void JLPPGKFHAAI(string OHPCNPKOLBJ, Dictionary<string, object> KCDMCOBGGGK, Dictionary<string, object> JPBILPNGMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6AE0", Offset = "0x5BE52E0", VA = "0x185BE6AE0")]
		protected void HJCKDDJABPB(string OHPCNPKOLBJ, string FKKGMPDEPMA, Dictionary<string, object> GPOABIDGCEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5BE69C0", Offset = "0x5BE51C0", VA = "0x185BE69C0", Slot = "5")]
		public virtual void AEFLAIBGDNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6FF0", Offset = "0x5BE57F0", VA = "0x185BE6FF0", Slot = "6")]
		public virtual void PHKKKHNFEBC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JFNLFBBGGMK : HLJFBLMANOA<AmplitudeAnalyticsIdentifyMessage, JFNLFBBGGMK>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override JFNLFBBGGMK PEMHDPCENAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage PPAOFKGEKIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB910", Offset = "0x5BEA110", VA = "0x185BEB910")]
	public JFNLFBBGGMK(AmplitudeAnalyticsIdentifyMessage BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB860", Offset = "0x5BEA060", VA = "0x185BEB860", Slot = "4")]
	public override void PHKKKHNFEBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EOHMAFNNPGM : HLJFBLMANOA<AmplitudeAnalyticsEvent, EOHMAFNNPGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool OHOCLNOECEA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override EOHMAFNNPGM PEMHDPCENAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long OOECFGGGADH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1C13E70", Offset = "0x1C12670", VA = "0x181C13E70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5BE91C0", Offset = "0x5BE79C0", VA = "0x185BE91C0")]
	public EOHMAFNNPGM(AmplitudeAnalyticsEvent BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "5")]
	public override AmplitudeAnalyticsEvent PPAOFKGEKIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9120", Offset = "0x5BE7920", VA = "0x185BE9120", Slot = "4")]
	public override void PHKKKHNFEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2249000", Offset = "0x2247800", VA = "0x182249000")]
	public EOHMAFNNPGM JLLPALEAMLC<T>(string EJKGILKDBHL, T[] FKKGMPDEPMA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2249000", Offset = "0x2247800", VA = "0x182249000")]
	public EOHMAFNNPGM JLLPALEAMLC(string EJKGILKDBHL, string[] FKKGMPDEPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2248D50", Offset = "0x2247550", VA = "0x182248D50")]
	public EOHMAFNNPGM JLLPALEAMLC<T>(string EJKGILKDBHL, T FKKGMPDEPMA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8FA0", Offset = "0x5BE77A0", VA = "0x185BE8FA0")]
	public EOHMAFNNPGM JLLPALEAMLC(string EJKGILKDBHL, long FKKGMPDEPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8F30", Offset = "0x5BE7730", VA = "0x185BE8F30")]
	public EOHMAFNNPGM JLLPALEAMLC(string EJKGILKDBHL, string FKKGMPDEPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8F00", Offset = "0x5BE7700", VA = "0x185BE8F00")]
	public EOHMAFNNPGM EIFJBHKMIBN(string EJKGILKDBHL, object? FKKGMPDEPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8E60", Offset = "0x5BE7660", VA = "0x185BE8E60")]
	public EOHMAFNNPGM CNAIFODAKMN(string EJKGILKDBHL, string FKKGMPDEPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9020", Offset = "0x5BE7820", VA = "0x185BE9020")]
	private EOHMAFNNPGM KHCOLLAFDGD(string EJKGILKDBHL, object FKKGMPDEPMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OEJFMLGNPKC : EOHMAFNNPGM
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5BE91C0", Offset = "0x5BE79C0", VA = "0x185BE91C0")]
	public OEJFMLGNPKC(AmplitudeAnalyticsEvent BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5BED700", Offset = "0x5BEBF00", VA = "0x185BED700", Slot = "4")]
	public override void PHKKKHNFEBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class HLJFBLMANOA<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : HLJFBLMANOA<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	protected M BKGEBGGPBLH;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR PEMHDPCENAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public HLJFBLMANOA(M BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3595C00", Offset = "0x3594400", VA = "0x183595C00")]
	public BLDR FKCMCGLHMDD(AmplitudeAnalyticsIdentifyMessage.DeviceInfo OLCLKJAHKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3595D50", Offset = "0x3594550", VA = "0x183595D50")]
	public BLDR LABDNCDMNND(AmplitudeAnalyticsIdentifyMessage.RevenueData KNMCIEEGCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3595B50", Offset = "0x3594350", VA = "0x183595B50")]
	public BLDR AJOOBKPADDC(string EJKGILKDBHL, string FKKGMPDEPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x215E550", Offset = "0x215CD50", VA = "0x18215E550")]
	public BLDR AJOOBKPADDC<T>(string EJKGILKDBHL, T FKKGMPDEPMA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PHKKKHNFEBC();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3595BD0", Offset = "0x35943D0", VA = "0x183595BD0")]
	internal static string CFIDNDNLMAC(string FKKGMPDEPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3595C50", Offset = "0x3594450", VA = "0x183595C50")]
	private BLDR KCLHIACAPPH(string EJKGILKDBHL, object FKKGMPDEPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M PPAOFKGEKIM();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PHEOBJMFHIH
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> OOBEKIJOEAN;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5BEE150", Offset = "0x5BEC950", VA = "0x185BEE150")]
	internal static bool GGOPCFFJGJG(string OHPCNPKOLBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KMCEDLBIPPL
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool BONOHKCJNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string PGHOOPKIDML
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	string PJGFHEDKOFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	string KCOBCMJEBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	string DEJIICIILDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NLPPPLCCBHA<BHLFIICDNJL> LDPHBPGJNLO(string HKDGJPKCALD, Dictionary<string, string> NFNOOBOKGOO, bool LKNOCEAOMMG = false);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NLPPPLCCBHA<BHLFIICDNJL> EFILNNDOHBH(string HKDGJPKCALD, string NGGMLKOGNLD, string IDBBPPLJMKG, string KIDCHDGHIKN);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct BHLFIICDNJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly int MPANCNINDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly string NHDOMFANOBP;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0xAA8750", Offset = "0xAA6F50", VA = "0x180AA8750")]
	public BHLFIICDNJL(int COGNLFLODGK, string MFFBJFLNALG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum MOAKNGMJMHM
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
public class CLFCAPHGDKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private long GNMKDEPPLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private EOHMAFNNPGM BOKPMEFGLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool JFONNOLOJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private float KPMNMMELNNG;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8B50", Offset = "0x5BE7350", VA = "0x185BE8B50")]
	public CLFCAPHGDKF(string INNHDAJOPIC, float KPMNMMELNNG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x21F1450", Offset = "0x21EFC50", VA = "0x1821F1450")]
	public void JLLPALEAMLC<T>(string EJKGILKDBHL, T FKKGMPDEPMA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5BE88D0", Offset = "0x5BE70D0", VA = "0x185BE88D0")]
	public void JLLPALEAMLC(string EJKGILKDBHL, string FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8950", Offset = "0x5BE7150", VA = "0x185BE8950")]
	public void MFBNLMDAPNE(string OPFDFCJLGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5BE87C0", Offset = "0x5BE6FC0", VA = "0x185BE87C0")]
	public void CAMNOPGLJPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8A40", Offset = "0x5BE7240", VA = "0x185BE8A40")]
	private void NIDHBMKKNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8880", Offset = "0x5BE7080", VA = "0x185BE8880")]
	private bool JFAAFFFJOCJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JJCDNFCIIMN
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool PODDKBEPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string NIDIIIMNNFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NBPJKIEJODK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BHHPLLPIFLF;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CPOBDANHFCI GLJEDCMMNGN(string POPMKEMJJAB, string NFAOOICADEH, [Optional] FPBMMBACAAH NELMHLGBOBH);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CPOBDANHFCI INDLFPCKHLM(FPBMMBACAAH NELMHLGBOBH);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CPOBDANHFCI CDDNBBHPNKK(FPBMMBACAAH NELMHLGBOBH, Dictionary<string, string> LCKPNOEICCD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GEOGEJJEFOA(string NOFOCNKENOL);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GOAMHJHIPKL HPDOEJGIAKO(string GJBFMEHMNMD);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FPALCMOHGMP EBLJMBHOGBK(string IGIOEDHJCBB);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CPOBDANHFCI FKJBPKPNJOI();
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

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5BEE470", Offset = "0x5BECC70", VA = "0x185BEE470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HCDGLJPAPJF : JJCDNFCIIMN
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly IReadOnlyDictionary<string, GPAHENACMCO> OKCEBBKPEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool MANJIBPABNA;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool PODDKBEPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B39F0", Offset = "0x7B21F0", VA = "0x1807B39F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string NIDIIIMNNFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9EA0", Offset = "0x5BE86A0", VA = "0x185BE9EA0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NBPJKIEJODK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB320", Offset = "0x5BE9B20", VA = "0x185BEB320", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB200", Offset = "0x5BE9A00", VA = "0x185BEB200", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action BHHPLLPIFLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB160", Offset = "0x5BE9960", VA = "0x185BEB160", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9E00", Offset = "0x5BE8600", VA = "0x185BE9E00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA900", Offset = "0x5BE9100", VA = "0x185BEA900", Slot = "8")]
	public CPOBDANHFCI GLJEDCMMNGN(string POPMKEMJJAB, string NFAOOICADEH, [Optional] FPBMMBACAAH NELMHLGBOBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA720", Offset = "0x5BE8F20", VA = "0x185BEA720", Slot = "16")]
	public CPOBDANHFCI FKJBPKPNJOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5BEAF70", Offset = "0x5BE9770", VA = "0x185BEAF70", Slot = "11")]
	public CPOBDANHFCI INDLFPCKHLM(FPBMMBACAAH NELMHLGBOBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9980", Offset = "0x5BE8180", VA = "0x185BE9980", Slot = "12")]
	public CPOBDANHFCI CDDNBBHPNKK(FPBMMBACAAH NELMHLGBOBH, Dictionary<string, string> LCKPNOEICCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA870", Offset = "0x5BE9070", VA = "0x185BEA870", Slot = "13")]
	public bool GEOGEJJEFOA(string NOFOCNKENOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5BEAD70", Offset = "0x5BE9570", VA = "0x185BEAD70", Slot = "14")]
	public GOAMHJHIPKL HPDOEJGIAKO(string GJBFMEHMNMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9EB0", Offset = "0x5BE86B0", VA = "0x185BE9EB0", Slot = "15")]
	public FPALCMOHGMP EBLJMBHOGBK(string IGIOEDHJCBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9F40", Offset = "0x5BE8740", VA = "0x185BE9F40")]
	private GEKCJPFCMHN FCDGPBKAOPO(FPBMMBACAAH NELMHLGBOBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9C50", Offset = "0x5BE8450", VA = "0x185BE9C50")]
	private PKANEPBHDBB CMJDJOPNPNI(string NFAOOICADEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA610", Offset = "0x5BE8E10", VA = "0x185BEA610")]
	private void FDECPGOFABG(string GJBFMEHMNMD, GOAMHJHIPKL IKANDDIAENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public HCDGLJPAPJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0xA40280", Offset = "0xA3EA80", VA = "0x180A40280")]
	[CompilerGenerated]
	private void FGJAAKACCBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB3C0", Offset = "0x5BE9BC0", VA = "0x185BEB3C0")]
	[CompilerGenerated]
	private void OBKCJKCFOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5BEB2A0", Offset = "0x5BE9AA0", VA = "0x185BEB2A0")]
	[CompilerGenerated]
	private void LIDNBCIIPMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NDFMENIJHDA : JJCDNFCIIMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private JJCDNFCIIMN KLOPCCJKMOB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private JJCDNFCIIMN HDDKOOHNGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5BED130", Offset = "0x5BEB930", VA = "0x185BED130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PODDKBEPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC890", Offset = "0x5BEB090", VA = "0x185BEC890", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string NIDIIIMNNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC570", Offset = "0x5BEAD70", VA = "0x185BEC570", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action NBPJKIEJODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5BED090", Offset = "0x5BEB890", VA = "0x185BED090", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5BECFF0", Offset = "0x5BEB7F0", VA = "0x185BECFF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action BHHPLLPIFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5BECF50", Offset = "0x5BEB750", VA = "0x185BECF50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC460", Offset = "0x5BEAC60", VA = "0x185BEC460", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	[UnityEngine.Scripting.Preserve]
	public NDFMENIJHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC500", Offset = "0x5BEAD00", VA = "0x185BEC500")]
	[NJKKEFDLCAD(AFMDLPKJFNK.GameOnly)]
	private static void DIEHNCAGMLG(LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC3F0", Offset = "0x5BEABF0", VA = "0x185BEC3F0")]
	[NJKKEFDLCAD(AFMDLPKJFNK.EditorOnly)]
	private static void CFNIDJPBPEK(LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC8E0", Offset = "0x5BEB0E0", VA = "0x185BEC8E0", Slot = "8")]
	public CPOBDANHFCI GLJEDCMMNGN(string POPMKEMJJAB, string NFAOOICADEH, [Optional] FPBMMBACAAH NELMHLGBOBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5BECE40", Offset = "0x5BEB640", VA = "0x185BECE40", Slot = "11")]
	public CPOBDANHFCI INDLFPCKHLM(FPBMMBACAAH NELMHLGBOBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC2D0", Offset = "0x5BEAAD0", VA = "0x185BEC2D0", Slot = "12")]
	public CPOBDANHFCI CDDNBBHPNKK(FPBMMBACAAH NELMHLGBOBH, Dictionary<string, string> LCKPNOEICCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC7E0", Offset = "0x5BEAFE0", VA = "0x185BEC7E0", Slot = "13")]
	public bool GEOGEJJEFOA(string NOFOCNKENOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5BECD30", Offset = "0x5BEB530", VA = "0x185BECD30", Slot = "14")]
	public GOAMHJHIPKL HPDOEJGIAKO(string GJBFMEHMNMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC5C0", Offset = "0x5BEADC0", VA = "0x185BEC5C0", Slot = "15")]
	public FPALCMOHGMP EBLJMBHOGBK(string IGIOEDHJCBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC6D0", Offset = "0x5BEAED0", VA = "0x185BEC6D0", Slot = "16")]
	public CPOBDANHFCI FKJBPKPNJOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7AF370", Offset = "0x7ADB70", VA = "0x1807AF370")]
	[CompilerGenerated]
	private void MIEFGGFJNOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xACED80", Offset = "0xACD580", VA = "0x180ACED80")]
	[CompilerGenerated]
	private void ILKILAGFMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class OEBBAIGKIDC : JJCDNFCIIMN
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PODDKBEPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string NIDIIIMNNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action NBPJKIEJODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5BED660", Offset = "0x5BEBE60", VA = "0x185BED660", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5BED5C0", Offset = "0x5BEBDC0", VA = "0x185BED5C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action BHHPLLPIFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5BED520", Offset = "0x5BEBD20", VA = "0x185BED520", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5BED2B0", Offset = "0x5BEBAB0", VA = "0x185BED2B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	[RecRoom.NoEngine.Common.Preserve]
	public OEBBAIGKIDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5BED3F0", Offset = "0x5BEBBF0", VA = "0x185BED3F0", Slot = "8")]
	public CPOBDANHFCI GLJEDCMMNGN(string POPMKEMJJAB, string NFAOOICADEH, [Optional] FPBMMBACAAH NELMHLGBOBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5BED490", Offset = "0x5BEBC90", VA = "0x185BED490", Slot = "11")]
	public CPOBDANHFCI INDLFPCKHLM(FPBMMBACAAH NELMHLGBOBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5BED220", Offset = "0x5BEBA20", VA = "0x185BED220", Slot = "12")]
	public CPOBDANHFCI CDDNBBHPNKK(FPBMMBACAAH NELMHLGBOBH, Dictionary<string, string> LCKPNOEICCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
	public bool GEOGEJJEFOA(string NOFOCNKENOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5BED480", Offset = "0x5BEBC80", VA = "0x185BED480", Slot = "14")]
	public GOAMHJHIPKL HPDOEJGIAKO(string GJBFMEHMNMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5BED350", Offset = "0x5BEBB50", VA = "0x185BED350", Slot = "15")]
	public FPALCMOHGMP EBLJMBHOGBK(string IGIOEDHJCBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5BED360", Offset = "0x5BEBB60", VA = "0x185BED360", Slot = "16")]
	public CPOBDANHFCI FKJBPKPNJOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LMFEKEHEOPG
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLFCAPHGDKF JNEAJIPFMMA(string INNHDAJOPIC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GDCHFJAPCGM
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	long LLMGKLJHEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long KDDCMKLJDJD();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABKCALMNNFN(long OOGONGDDKNA, bool DBPDJHLCHAC = true);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CLLHFKNBKIL(string FJNGJOFLBMD, string CKCANNDDCFI, string DJPJGAJMEMH);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OIEGIBFBMCF(string FJNGJOFLBMD);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HJLHIONJOHB(string FJNGJOFLBMD, string NJFJHAPAJGN, string BKCAICJLALH);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CGOFIKOFMNJ(string CNOGBCGHKGJ, object ECOHKEEFIEK, object LCJDPNPEFGD);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FPBMMBACAAH
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool LNDEDINIBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool HFBNCOCGJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool IHFHPDIFJOO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool? HIKCPGNAHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	int? HODABIBPFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	int EABLINJFOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string GJPNDEKPHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string CMLDIJHLHMK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string GAKGHIDLHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	long GFAAGMFGCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string LHDLPLFBJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string HMGGJFEDNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string AKHHKFALPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string NEEIEHOJIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	double GDAHAOHCPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	int FECALMPBOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
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
