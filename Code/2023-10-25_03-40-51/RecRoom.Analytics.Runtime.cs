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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B91480", Offset = "0x5B90280", VA = "0x185B91480")]
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
		[Cpp2IlInjected.Address(RVA = "0x7895A0", Offset = "0x7883A0", VA = "0x1807895A0")]
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
		public AmplitudeAnalyticsClient.Settings GJFNOPFEOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool KICBEEIMGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7656C0", Offset = "0x7644C0", VA = "0x1807656C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum CLNKIBEGGMM
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class DNGJNDJHHNM
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class IABAKBNIMIN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int BMHECBIGLBI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> LNPGPICCGCG;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
				public IABAKBNIMIN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class ADHHPFIOMMO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
				public ADHHPFIOMMO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5B82720", Offset = "0x5B81520", VA = "0x185B82720")]
				internal bool IDJGGJAEKDK(IABAKBNIMIN item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string OMGJICDEKIB = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string MCGLDNPFLND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<IABAKBNIMIN> PFJLAPGGIJG;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? LKIGLMGEECO
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5B8CB50", Offset = "0x5B8B950", VA = "0x185B8CB50")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5B8CE30", Offset = "0x5B8BC30", VA = "0x185B8CE30")]
			internal DNGJNDJHHNM(string EHHCFPPKLEM, string EJOFNPJEMNF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5B8C9A0", Offset = "0x5B8B7A0", VA = "0x185B8C9A0")]
			public int JJCKJACIEDI([Optional] int? NFHKNPDFHGC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5B8C340", Offset = "0x5B8B140", VA = "0x185B8C340")]
			public List<Dictionary<string, object>> EELHNKBIGJA(int AHOMFOGEKMH, int? NFHKNPDFHGC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5B8C7F0", Offset = "0x5B8B5F0", VA = "0x185B8C7F0")]
			public void IMOBHFMNMPF(AmplitudeAnalyticsIdentifyMessage DGPHOMINFCK, bool DPJHEKNDIBP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5B8C890", Offset = "0x5B8B690", VA = "0x185B8C890")]
			public void IMOBHFMNMPF(Dictionary<string, object> DGPHOMINFCK, bool DPJHEKNDIBP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5B8C1B0", Offset = "0x5B8AFB0", VA = "0x185B8C1B0")]
			public void CMHNNNJHHLJ(params Dictionary<string, object>[] JAFPLBLELBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5B8BB70", Offset = "0x5B8A970", VA = "0x185B8BB70")]
			public void AGKPLDLGCBH(List<Dictionary<string, object>> EHKHBHNNDLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5B8CBF0", Offset = "0x5B8B9F0", VA = "0x185B8CBF0")]
			private void NBBKJDDIHGN(Dictionary<string, object> DGPHOMINFCK, bool DPJHEKNDIBP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5B8C5B0", Offset = "0x5B8B3B0", VA = "0x185B8C5B0")]
			public void IAADNMJIOFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5B8BDC0", Offset = "0x5B8ABC0", VA = "0x185B8BDC0")]
			private void BNHAOPBIBCI([Optional] string GCNAAGAJGFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5B8CD00", Offset = "0x5B8BB00", VA = "0x185B8CD00")]
			private static string NJOECGNEBLC(string POACLGOFKAJ, string GMOPMNAPKBE)
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
			[Cpp2IlInjected.Address(RVA = "0x5B92A20", Offset = "0x5B91820", VA = "0x185B92A20")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct KCEHHMGIFNB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int OIIPPBPGAHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string GMMJDPFCPEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T PLKLPCIHABH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class OLCIAHBCKMG : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private JHKLHFOKPOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
			[DebuggerHidden]
			public OLCIAHBCKMG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5B91500", Offset = "0x5B90300", VA = "0x185B91500", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5B91CC0", Offset = "0x5B90AC0", VA = "0x185B91CC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AMPPDAPLMKG : IEnumerator<object>, IEnumerator, IDisposable
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
			public OGKAMIBOIGC quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
			[DebuggerHidden]
			public AMPPDAPLMKG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5B82790", Offset = "0x5B81590", VA = "0x185B82790", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5B828A0", Offset = "0x5B816A0", VA = "0x185B828A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MNOGKMGIDCP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
			[DebuggerHidden]
			public MNOGKMGIDCP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5B912C0", Offset = "0x5B900C0", VA = "0x185B912C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5B91430", Offset = "0x5B90230", VA = "0x185B91430", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class GAPHPJBLNIA : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private JHKLHFOKPOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
			[DebuggerHidden]
			public GAPHPJBLNIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5B8FED0", Offset = "0x5B8ECD0", VA = "0x185B8FED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5B90150", Offset = "0x5B8EF50", VA = "0x185B90150", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class JFNIJBHLJHH : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private JHKLHFOKPOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
			[DebuggerHidden]
			public JFNIJBHLJHH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5B90E30", Offset = "0x5B8FC30", VA = "0x185B90E30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5B910C0", Offset = "0x5B8FEC0", VA = "0x185B910C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class IAGOAGLDPIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public DNGJNDJHHNM cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public IAGOAGLDPIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5B90B10", Offset = "0x5B8F910", VA = "0x185B90B10")]
			internal void NJBJKHPJMBI(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5B906C0", Offset = "0x5B8F4C0", VA = "0x185B906C0")]
			internal void BDAKAPBEMBN(KCEHHMGIFNB<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class PALBILDNLMK : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private JHKLHFOKPOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public DNGJNDJHHNM cache;

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
			private IAGOAGLDPIA <>8__1;

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
			private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
			[DebuggerHidden]
			public PALBILDNLMK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5B91D10", Offset = "0x5B90B10", VA = "0x185B91D10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5B92560", Offset = "0x5B91360", VA = "0x185B92560", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class MJNJJGHCOOO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public MJNJJGHCOOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3B6F630", Offset = "0x3B6E430", VA = "0x183B6F630")]
			internal KCEHHMGIFNB<T> KFJIJFLKLJF(JFNANPCCMLB postResponse)
			{
				return default(KCEHHMGIFNB<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class BIJLEDHNBHF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public BIJLEDHNBHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3B6F630", Offset = "0x3B6E430", VA = "0x183B6F630")]
			internal KCEHHMGIFNB<T> KOHLOGFLMPE(JFNANPCCMLB postResponse)
			{
				return default(KCEHHMGIFNB<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private LADPFBGJADL AELMPMDMHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<BPMCJMAGEEL> KIMFBEAEEKP;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string EAPPLDLNMLK = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string KHOFNHDODJB = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string AJNMHGPBLPP = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int FHJCLPOPGJN = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int ELDJKMCMDCD = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int PNBOGENGEON = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float DNBHCDCBPGG = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long PIICCAKKIMP = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string KLIHLJAHBPP = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string LNDNOPDLCJE = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool OOANFMJKKLL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool OEJNFAFANGM;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int EIHMOHFAMCP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int FNMADPBJLDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private BHIAOOHOJMF HJPIEFAEGEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private NNPFIGJEFLH FHPGOOAJNAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FBNOCPOJNGO KKKDHADHMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool KMDPGEMCCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float CKOIOPNMHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float JFBGFOABHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int DGLEFOAIFMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int FBNGPIAAJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? LKDBEPCKHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? HDLKPPMGPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long KINBAJJOGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string CBNMNFMAIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool OGJMMHBAJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long DOCHKKPDADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string COIIHICHMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string ABNKNBJBFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> ALGKDANCIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CLNKIBEGGMM IOBNGBMHNKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int NAKJPAMNJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int GGDEEEGENLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float GPKDBGPJFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool BMCMPODDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool MFLJFJBEBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private DNGJNDJHHNM EFAPGLCDMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private DNGJNDJHHNM EBFGHFEMMNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private DNGJNDJHHNM LPFCCKCKABN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> FDGNLOLEDHH;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo FKKOFFFLOHJ;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string DOONNKHDMFN;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string NMNCAEBHHFB = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string GKAKMDMIGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string AKLALPHNCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string MMLPDLGOOIH;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LADPFBGJADL KCBDHMFDAFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5B859B0", Offset = "0x5B847B0", VA = "0x185B859B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private BPMCJMAGEEL EDMGDANMBBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5B864A0", Offset = "0x5B852A0", VA = "0x185B864A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int BDDEKJBIGAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5B842A0", Offset = "0x5B830A0", VA = "0x185B842A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long GAOCNIJKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5B88840", Offset = "0x5B87640", VA = "0x185B88840")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5B88960", Offset = "0x5B87760", VA = "0x185B88960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string ENNJHKGNKLB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5B887E0", Offset = "0x5B875E0", VA = "0x185B887E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string HPKOGJCECDM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5B88810", Offset = "0x5B87610", VA = "0x185B88810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NCJBBIIHOND
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8B90C0", Offset = "0x8B7EC0", VA = "0x1808B90C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8B9350", Offset = "0x8B8150", VA = "0x1808B9350")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? PFBDHGIBBLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8B90B0", Offset = "0x8B7EB0", VA = "0x1808B90B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5B88950", Offset = "0x5B87750", VA = "0x185B88950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MBGPFMFEEFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xE3FDB0", Offset = "0xE3EBB0", VA = "0x180E3FDB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xE3ECF0", Offset = "0xE3DAF0", VA = "0x180E3ECF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool HCIBGCHDOME
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5B886E0", Offset = "0x5B874E0", VA = "0x185B886E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> PEOGHKELBMB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5B88620", Offset = "0x5B87420", VA = "0x185B88620")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5B88890", Offset = "0x5B87690", VA = "0x185B88890")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5B83BD0", Offset = "0x5B829D0", VA = "0x185B83BD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5B85410", Offset = "0x5B84210", VA = "0x185B85410")]
		private void HGFLDBJCOIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5B87C00", Offset = "0x5B86A00", VA = "0x185B87C00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5B86DE0", Offset = "0x5B85BE0", VA = "0x185B86DE0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5B87FA0", Offset = "0x5B86DA0", VA = "0x185B87FA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5B86EA0", Offset = "0x5B85CA0", VA = "0x185B86EA0")]
		public MMMPEMHFGNJ PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5B85EB0", Offset = "0x5B84CB0", VA = "0x185B85EB0")]
		[IteratorStateMachine(typeof(OLCIAHBCKMG))]
		public IEnumerator<JHKLHFOKPOC> Initialize(AmplitudeAnalyticsEvent JKOIDOPFDCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5B87EE0", Offset = "0x5B86CE0", VA = "0x185B87EE0")]
		public void UpdateLastKnownInteractionCategory(string POJPDIIMJOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5B87DF0", Offset = "0x5B86BF0", VA = "0x185B87DF0")]
		public void UpdateLastAliveTime(float CILPHFINCEO = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5B864F0", Offset = "0x5B852F0", VA = "0x185B864F0")]
		private MMMPEMHFGNJ LNDMDGEDNEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5B84590", Offset = "0x5B83390", VA = "0x185B84590")]
		private MMMPEMHFGNJ EJIGPAENAMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5B87650", Offset = "0x5B86450", VA = "0x185B87650")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5B86D50", Offset = "0x5B85B50", VA = "0x185B86D50")]
		[IteratorStateMachine(typeof(AMPPDAPLMKG))]
		private IEnumerator OBHACADCDBC(OGKAMIBOIGC GEDLMMEPCIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5B88230", Offset = "0x5B87030", VA = "0x185B88230")]
		[IteratorStateMachine(typeof(MNOGKMGIDCP))]
		public IEnumerator WaitForFlush(float PNDCNOOMJCC = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5B87CD0", Offset = "0x5B86AD0", VA = "0x185B87CD0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5B87C10", Offset = "0x5B86A10", VA = "0x185B87C10")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime BGDOPOOMALL)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5B85A20", Offset = "0x5B84820", VA = "0x185B85A20")]
		public static PJALPBIMHMM Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5B83A60", Offset = "0x5B82860", VA = "0x185B83A60")]
		public static CHJLCDGAHPG AccountSelectionPostLoginEvent([NotNull] string HMKLDHAJOGH, string MADDJAPMOOD, bool PLLBJLBEIFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5B849E0", Offset = "0x5B837E0", VA = "0x185B849E0")]
		public static CHJLCDGAHPG Event([NotNull] string HMKLDHAJOGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5B86EE0", Offset = "0x5B85CE0", VA = "0x185B86EE0")]
		public static CHJLCDGAHPG PreviousSessionEvent([NotNull] string HMKLDHAJOGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5B85BD0", Offset = "0x5B849D0", VA = "0x185B85BD0")]
		public static CHJLCDGAHPG InitializeEvent(string MADDJAPMOOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5B87810", Offset = "0x5B86610", VA = "0x185B87810")]
		public static CHJLCDGAHPG StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5B84040", Offset = "0x5B82E40", VA = "0x185B84040")]
		public static CHJLCDGAHPG CreateOutOfSessionEvent(string HMKLDHAJOGH, bool MHNOMMDMHJC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5B86830", Offset = "0x5B85630", VA = "0x185B86830")]
		public static MMMPEMHFGNJ LogOutOfSessionEvent(CHJLCDGAHPG JIDMAMFPNEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B865B0", Offset = "0x5B853B0", VA = "0x185B865B0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent GBDHLNBGGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5B86B20", Offset = "0x5B85920", VA = "0x185B86B20")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent GBDHLNBGGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5B86C60", Offset = "0x5B85A60", VA = "0x185B86C60")]
		public void LogSerializedEventAsync(Dictionary<string, object> EOBODMMHCJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5B866F0", Offset = "0x5B854F0", VA = "0x185B866F0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage CAHGHNBEPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5B84CE0", Offset = "0x5B83AE0", VA = "0x185B84CE0")]
		private void FOHGIHEBFBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5B85FD0", Offset = "0x5B84DD0", VA = "0x185B85FD0")]
		private void KKAKODKMPNO(Dictionary<string, object> ONOFJJKGLBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5B82CA0", Offset = "0x5B81AA0", VA = "0x185B82CA0")]
		private void AJCLHAGKNBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5B862D0", Offset = "0x5B850D0", VA = "0x185B862D0")]
		private void LBCDJPMCAAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5B84DE0", Offset = "0x5B83BE0", VA = "0x185B84DE0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5B85380", Offset = "0x5B84180", VA = "0x185B85380")]
		[IteratorStateMachine(typeof(GAPHPJBLNIA))]
		private IEnumerator<JHKLHFOKPOC> HBCKNKFLFMM(float PNDCNOOMJCC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5B85F40", Offset = "0x5B84D40", VA = "0x185B85F40")]
		[IteratorStateMachine(typeof(JFNIJBHLJHH))]
		private IEnumerator<JHKLHFOKPOC> JCBEJJPBLMC(float PNDCNOOMJCC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5B84E70", Offset = "0x5B83C70", VA = "0x185B84E70")]
		[IteratorStateMachine(typeof(PALBILDNLMK))]
		private IEnumerator<JHKLHFOKPOC> GDCNOCBMDNJ(DNGJNDJHHNM GEKHLALBKFA, int? NFHKNPDFHGC, string KDCMAGEAJHC, string FLMDBOLEJNA, float PNDCNOOMJCC, Action<int> EIBIGAGCOBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5B84480", Offset = "0x5B83280", VA = "0x185B84480")]
		private static void DHBADLEMODF(bool GICEMJAJGDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5B84F70", Offset = "0x5B83D70", VA = "0x185B84F70")]
		private MIDEJKJPMAF<KCEHHMGIFNB<Dictionary<string, object>>> GIIMAKAIPCF(string KDCMAGEAJHC, string FLMDBOLEJNA, string BENKHDEPHCF, string CPFIFMEFFAJ, Dictionary<string, object> PLKLPCIHABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5B850A0", Offset = "0x5B83EA0", VA = "0x185B850A0")]
		private MIDEJKJPMAF<KCEHHMGIFNB<List<Dictionary<string, object>>>> GIIMAKAIPCF(string KDCMAGEAJHC, string FLMDBOLEJNA, string BENKHDEPHCF, string CPFIFMEFFAJ, List<Dictionary<string, object>> PLKLPCIHABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x29E9260", Offset = "0x29E8060", VA = "0x1829E9260")]
		private MIDEJKJPMAF<KCEHHMGIFNB<T>> JAJNNOLLJMC<T>(string KDCMAGEAJHC, string FLMDBOLEJNA, string CPFIFMEFFAJ, T PLKLPCIHABH, Dictionary<string, object> HDOIPMKOIFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x29E8F10", Offset = "0x29E7D10", VA = "0x1829E8F10")]
		private MIDEJKJPMAF<KCEHHMGIFNB<T>> GFGDEOIAPHF<T>(string KDCMAGEAJHC, string FLMDBOLEJNA, string BENKHDEPHCF, T PLKLPCIHABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5B86280", Offset = "0x5B85080", VA = "0x185B86280")]
		private bool KLJBCOAFPIO(float AFODOABIHMB, float PNDCNOOMJCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5B82D90", Offset = "0x5B81B90", VA = "0x185B82D90")]
		private Dictionary<string, object> ALEFDMNIIAJ(string FLMDBOLEJNA, Dictionary<string, object> PLKLPCIHABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5B88320", Offset = "0x5B87120", VA = "0x185B88320")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5B84880", Offset = "0x5B83680", VA = "0x185B84880")]
		[CompilerGenerated]
		private long EPFJNFFKCOF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5B86D40", Offset = "0x5B85B40", VA = "0x185B86D40")]
		[CompilerGenerated]
		private void NJFGJJDGGEH(int AKIAHAEAMNB)
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
			[Cpp2IlInjected.Address(RVA = "0x5B896C0", Offset = "0x5B884C0", VA = "0x185B896C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5B897A0", Offset = "0x5B885A0", VA = "0x185B897A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5B89700", Offset = "0x5B88500", VA = "0x185B89700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5B89800", Offset = "0x5B88600", VA = "0x185B89800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5B89680", Offset = "0x5B88480", VA = "0x185B89680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5B89740", Offset = "0x5B88540", VA = "0x185B89740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x768A70", Offset = "0x767870", VA = "0x180768A70")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5B88CA0", Offset = "0x5B87AA0", VA = "0x185B88CA0")]
		public static CHJLCDGAHPG FLMMCOJOBIA(string FBJEHMGCPKI, [NotNull] string JALLFNOMJIO, long EEFBHJBOLAH, long KLPINBLCOCD, string MADDJAPMOOD, bool PLLBJLBEIFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5B88B40", Offset = "0x5B87940", VA = "0x185B88B40")]
		public static CHJLCDGAHPG EFAFKKDICLJ(string FBJEHMGCPKI, [NotNull] string JALLFNOMJIO, long EEFBHJBOLAH, long KLPINBLCOCD, string MADDJAPMOOD, long JHKKIIOJKPC, bool PLLBJLBEIFC, string KFBHDKNIIKA, string KHPGLHLJEEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5B894F0", Offset = "0x5B882F0", VA = "0x185B894F0")]
		private AmplitudeAnalyticsEvent(string FBJEHMGCPKI, [NotNull] string JALLFNOMJIO, long EEFBHJBOLAH, long KLPINBLCOCD, string MADDJAPMOOD, bool PLLBJLBEIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x188A1B0", Offset = "0x1888FB0", VA = "0x18188A1B0")]
		public void GIOMHEHKHGE(long HHCECFBJOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5B892D0", Offset = "0x5B880D0", VA = "0x185B892D0", Slot = "5")]
		public override void JBCGOJJOFLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5B889C0", Offset = "0x5B877C0", VA = "0x185B889C0", Slot = "6")]
		public override void BJMMPHCBEGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5B88DA0", Offset = "0x5B87BA0", VA = "0x185B88DA0", Slot = "4")]
		protected override Dictionary<string, object> HFBFCMFMFFF(Dictionary<string, object> NDMOPNEFKFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5B893E0", Offset = "0x5B881E0", VA = "0x185B893E0")]
		private void NHPICOCGCAF(string GMOPMNAPKBE, string POACLGOFKAJ, bool JFIAPCFACKK = false)
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
			[Cpp2IlInjected.Address(RVA = "0x5B8D020", Offset = "0x5B8BE20", VA = "0x185B8D020")]
			public void GLDDFEHDEEI(Dictionary<string, object> GJMOOHMMANO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B926B0", Offset = "0x5B914B0", VA = "0x185B926B0")]
			public void GLDDFEHDEEI(Dictionary<string, object> LDPCGNOADOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7EBE80", Offset = "0x7EAC80", VA = "0x1807EBE80")]
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
			[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5B89A00", Offset = "0x5B88800", VA = "0x185B89A00")]
		public static PJALPBIMHMM FLMMCOJOBIA(string FBJEHMGCPKI, string MADDJAPMOOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5B89F20", Offset = "0x5B88D20", VA = "0x185B89F20")]
		protected AmplitudeAnalyticsIdentifyMessage(string FBJEHMGCPKI, string MADDJAPMOOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5B89E90", Offset = "0x5B88C90", VA = "0x185B89E90")]
		public Dictionary<string, object> MNFNCJGIGIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5B89AC0", Offset = "0x5B888C0", VA = "0x185B89AC0", Slot = "4")]
		protected virtual Dictionary<string, object> HFBFCMFMFFF(Dictionary<string, object> NDMOPNEFKFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5B89960", Offset = "0x5B88760", VA = "0x185B89960")]
		protected void DLKDDLGDIDL(string GMOPMNAPKBE, Dictionary<string, object> NBGMKDBLKNM, Dictionary<string, object> ELKKPLDLPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5B89860", Offset = "0x5B88660", VA = "0x185B89860")]
		protected void BAMMLPNHNJO(string GMOPMNAPKBE, string POACLGOFKAJ, Dictionary<string, object> OMJHPGDACEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5B89E00", Offset = "0x5B88C00", VA = "0x185B89E00", Slot = "5")]
		public virtual void JBCGOJJOFLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5B898D0", Offset = "0x5B886D0", VA = "0x185B898D0", Slot = "6")]
		public virtual void BJMMPHCBEGI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PJALPBIMHMM : IAGIKNHNIPM<AmplitudeAnalyticsIdentifyMessage, PJALPBIMHMM>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override PJALPBIMHMM PFNLBBPMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage BPNHBNDHKNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5B92660", Offset = "0x5B91460", VA = "0x185B92660")]
	public PJALPBIMHMM(AmplitudeAnalyticsIdentifyMessage BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5B925B0", Offset = "0x5B913B0", VA = "0x185B925B0", Slot = "4")]
	public override void BJMMPHCBEGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CHJLCDGAHPG : IAGIKNHNIPM<AmplitudeAnalyticsEvent, CHJLCDGAHPG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool KNBIDJJEBFK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override CHJLCDGAHPG PFNLBBPMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long IGBEGECJLAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1C51B30", Offset = "0x1C50930", VA = "0x181C51B30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5B8B210", Offset = "0x5B8A010", VA = "0x185B8B210")]
	public CHJLCDGAHPG(AmplitudeAnalyticsEvent BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "5")]
	public override AmplitudeAnalyticsEvent BPNHBNDHKNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5B8AEB0", Offset = "0x5B89CB0", VA = "0x185B8AEB0", Slot = "4")]
	public override void BJMMPHCBEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x21EE7E0", Offset = "0x21ED5E0", VA = "0x1821EE7E0")]
	public CHJLCDGAHPG MHNIGENPMDF<T>(string GHOAJKHDDHN, T[] POACLGOFKAJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x21EE7E0", Offset = "0x21ED5E0", VA = "0x1821EE7E0")]
	public CHJLCDGAHPG MHNIGENPMDF(string GHOAJKHDDHN, string[] POACLGOFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x21EE530", Offset = "0x21ED330", VA = "0x1821EE530")]
	public CHJLCDGAHPG MHNIGENPMDF<T>(string GHOAJKHDDHN, T POACLGOFKAJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5B8B0F0", Offset = "0x5B89EF0", VA = "0x185B8B0F0")]
	public CHJLCDGAHPG MHNIGENPMDF(string GHOAJKHDDHN, long POACLGOFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5B8B170", Offset = "0x5B89F70", VA = "0x185B8B170")]
	public CHJLCDGAHPG MHNIGENPMDF(string GHOAJKHDDHN, string POACLGOFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5B8B1E0", Offset = "0x5B89FE0", VA = "0x185B8B1E0")]
	public CHJLCDGAHPG PECAIGMAEIB(string GHOAJKHDDHN, object? POACLGOFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5B8AF50", Offset = "0x5B89D50", VA = "0x185B8AF50")]
	public CHJLCDGAHPG BKIMHBCFANE(string GHOAJKHDDHN, string POACLGOFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5B8AFF0", Offset = "0x5B89DF0", VA = "0x185B8AFF0")]
	private CHJLCDGAHPG LDFIHFFLGNB(string GHOAJKHDDHN, object POACLGOFKAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FLBBIKDILPO : CHJLCDGAHPG
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5B8B210", Offset = "0x5B8A010", VA = "0x185B8B210")]
	public FLBBIKDILPO(AmplitudeAnalyticsEvent BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FD20", Offset = "0x5B8EB20", VA = "0x185B8FD20", Slot = "4")]
	public override void BJMMPHCBEGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class IAGIKNHNIPM<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : IAGIKNHNIPM<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M BLAOEBOMGGP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR PFNLBBPMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public IAGIKNHNIPM(M BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x36676A0", Offset = "0x36664A0", VA = "0x1836676A0")]
	public BLDR NIPDMIFGMGC(AmplitudeAnalyticsIdentifyMessage.DeviceInfo AOHCGIDHPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x36675D0", Offset = "0x36663D0", VA = "0x1836675D0")]
	public BLDR AJJBGHBJFJL(AmplitudeAnalyticsIdentifyMessage.RevenueData GLBEGLEJJKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3667620", Offset = "0x3666420", VA = "0x183667620")]
	public BLDR JBCBICJLIIN(string GHOAJKHDDHN, string POACLGOFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x22A8600", Offset = "0x22A7400", VA = "0x1822A8600")]
	public BLDR JBCBICJLIIN<T>(string GHOAJKHDDHN, T POACLGOFKAJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BJMMPHCBEGI();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x36677F0", Offset = "0x36665F0", VA = "0x1836677F0")]
	internal static string OPPGGDHLKKD(string POACLGOFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x36676F0", Offset = "0x36664F0", VA = "0x1836676F0")]
	private BLDR OHOIBFOLKHK(string GHOAJKHDDHN, object POACLGOFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M BPNHBNDHKNN();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class ANNOCKKPPPH : BHIAOOHOJMF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct DCIKLCCCCIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<JFNANPCCMLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public ANNOCKKPPPH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5B8B260", Offset = "0x5B8A060", VA = "0x185B8B260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5B8BB00", Offset = "0x5B8A900", VA = "0x185B8BB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct FGLHLMHBDKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<JFNANPCCMLB> <>t__builder;

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
		public ANNOCKKPPPH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5B8F280", Offset = "0x5B8E080", VA = "0x185B8F280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5B8FCB0", Offset = "0x5B8EAB0", VA = "0x185B8FCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient CAJCGJEHOHC;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5B828F0", Offset = "0x5B816F0", VA = "0x185B828F0")]
	[DJDJPHIPNFL(IEJLPKKICHC.None)]
	private static void CHCNECDJJDH(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5B82C20", Offset = "0x5B81A20", VA = "0x185B82C20")]
	[RecRoom.NoEngine.Common.Preserve]
	public ANNOCKKPPPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5B82AD0", Offset = "0x5B818D0", VA = "0x185B82AD0", Slot = "4")]
	[AsyncStateMachine(typeof(DCIKLCCCCIF))]
	public Task<JFNANPCCMLB> GIIMAKAIPCF(string KDCMAGEAJHC, Dictionary<string, string> ECJGPKKEFPA, bool JPJFHHPCIBC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B82960", Offset = "0x5B81760", VA = "0x185B82960", Slot = "5")]
	[AsyncStateMachine(typeof(FGLHLMHBDKP))]
	public Task<JFNANPCCMLB> FHJIMILDHDA(string KDCMAGEAJHC, string EHIEHGBOFEF, string FMBHDDOCGHM, string BLIPDINOMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KPPMKAPGMJJ
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> PPDLFEDJEOF;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5B91110", Offset = "0x5B8FF10", VA = "0x185B91110")]
	internal static bool CCMBLOILGLD(string GMOPMNAPKBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BHIAOOHOJMF
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JFNANPCCMLB> GIIMAKAIPCF(string KDCMAGEAJHC, Dictionary<string, string> ECJGPKKEFPA, bool JPJFHHPCIBC = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JFNANPCCMLB> FHJIMILDHDA(string KDCMAGEAJHC, string EHIEHGBOFEF, string FMBHDDOCGHM, string BLIPDINOMEP);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct JFNANPCCMLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int HINACNIJKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string KEPAKAJJKMM;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xAD8C40", Offset = "0xAD7A40", VA = "0x180AD8C40")]
	public JFNANPCCMLB(int OIIPPBPGAHC, string GMMJDPFCPEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum PKOHPGFFGEO
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
	RoomChat
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HNEPDHHOHAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private long LBFADDPDKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private CHJLCDGAHPG KJNPKIJBBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool EINAPJPJOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private float NPLGCBCPDAP;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5B90530", Offset = "0x5B8F330", VA = "0x185B90530")]
	public HNEPDHHOHAO(string MJMKPHHBDJD, float NPLGCBCPDAP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x23D66A0", Offset = "0x23D54A0", VA = "0x1823D66A0")]
	public void MHNIGENPMDF<T>(string GHOAJKHDDHN, T POACLGOFKAJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5B904B0", Offset = "0x5B8F2B0", VA = "0x185B904B0")]
	public void MHNIGENPMDF(string GHOAJKHDDHN, string POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5B902B0", Offset = "0x5B8F0B0", VA = "0x185B902B0")]
	public void KDCLJGCPBPD(string KMFDGAPIABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B901A0", Offset = "0x5B8EFA0", VA = "0x185B901A0")]
	public void DJGGJDNCKFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5B903A0", Offset = "0x5B8F1A0", VA = "0x185B903A0")]
	private void LCFPNLDDCCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5B90260", Offset = "0x5B8F060", VA = "0x185B90260")]
	private bool HBHFGFHNOBM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CPMLMAGGHDP
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool NCHMLMBHEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string NCJBBIIHOND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action EANFDMOLKNM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action KIOCDOHAPIA;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MMMPEMHFGNJ HCKCHEHGBKI(string GNGNAFBJOBB, string EJOFNPJEMNF, [Optional] NNPFIGJEFLH IGFHPKBICAA);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MMMPEMHFGNJ CABMILEPMJO(NNPFIGJEFLH IGFHPKBICAA);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MMMPEMHFGNJ FOOCOKOJAMK(NNPFIGJEFLH IGFHPKBICAA, Dictionary<string, string> LDJPNKCCOMO);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BICAFDCDJPO(string KNKBGFNOKDJ);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GLEIPIBDNOM MMCBGFLCLNF(string HFDELLEEAHF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IICHKOMANBI LJECDDABHEA(string NOLMDLOGCIP);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MMMPEMHFGNJ GFKOEPCEEML();
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5B92820", Offset = "0x5B91620", VA = "0x185B92820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class EBJLCALKDCP : CPMLMAGGHDP
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly IReadOnlyDictionary<string, FMDPNKFCFCM> PGAEFGBMHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool PCIHIOPCLIB;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NCHMLMBHEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B03C0", Offset = "0x7AF1C0", VA = "0x1807B03C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string NCJBBIIHOND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5B8E270", Offset = "0x5B8D070", VA = "0x185B8E270", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action EANFDMOLKNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5B8D7B0", Offset = "0x5B8C5B0", VA = "0x185B8D7B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5B8D5D0", Offset = "0x5B8C3D0", VA = "0x185B8D5D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action KIOCDOHAPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5B8D670", Offset = "0x5B8C470", VA = "0x185B8D670", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5B8D710", Offset = "0x5B8C510", VA = "0x185B8D710", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5B8DC70", Offset = "0x5B8CA70", VA = "0x185B8DC70", Slot = "8")]
	public MMMPEMHFGNJ HCKCHEHGBKI(string GNGNAFBJOBB, string EJOFNPJEMNF, [Optional] NNPFIGJEFLH IGFHPKBICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5B8DB20", Offset = "0x5B8C920", VA = "0x185B8DB20", Slot = "16")]
	public MMMPEMHFGNJ GFKOEPCEEML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5B8D3E0", Offset = "0x5B8C1E0", VA = "0x185B8D3E0", Slot = "11")]
	public MMMPEMHFGNJ CABMILEPMJO(NNPFIGJEFLH IGFHPKBICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5B8D850", Offset = "0x5B8C650", VA = "0x185B8D850", Slot = "12")]
	public MMMPEMHFGNJ FOOCOKOJAMK(NNPFIGJEFLH IGFHPKBICAA, Dictionary<string, string> LDJPNKCCOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5B8D350", Offset = "0x5B8C150", VA = "0x185B8D350", Slot = "13")]
	public bool BICAFDCDJPO(string KNKBGFNOKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5B8EA60", Offset = "0x5B8D860", VA = "0x185B8EA60", Slot = "14")]
	public GLEIPIBDNOM MMCBGFLCLNF(string HFDELLEEAHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E9D0", Offset = "0x5B8D7D0", VA = "0x185B8E9D0", Slot = "15")]
	public IICHKOMANBI LJECDDABHEA(string NOLMDLOGCIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E300", Offset = "0x5B8D100", VA = "0x185B8E300")]
	private CNAKLBLJGCF KNOOFPJCIPM(NNPFIGJEFLH IGFHPKBICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5B8D1A0", Offset = "0x5B8BFA0", VA = "0x185B8D1A0")]
	private GIJOBCCPFFP AKBPEKOEMNJ(string EJOFNPJEMNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E160", Offset = "0x5B8CF60", VA = "0x185B8E160")]
	private void JJBBDGDKFKL(string HFDELLEEAHF, GLEIPIBDNOM ODAKGFFPNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public EBJLCALKDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA3AE80", Offset = "0xA39C80", VA = "0x180A3AE80")]
	[CompilerGenerated]
	private void EMPIMFJKHDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E280", Offset = "0x5B8D080", VA = "0x185B8E280")]
	[CompilerGenerated]
	private void KFKKPLDOJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E0E0", Offset = "0x5B8CEE0", VA = "0x185B8E0E0")]
	[CompilerGenerated]
	private void IIFCNINKNGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class BPAFGFLBMHH : CPMLMAGGHDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private CPMLMAGGHDP MCOAKPINDGF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private CPMLMAGGHDP EJNKDKOJGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5B8A050", Offset = "0x5B88E50", VA = "0x185B8A050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool NCHMLMBHEAA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5B8AE60", Offset = "0x5B89C60", VA = "0x185B8AE60", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string NCJBBIIHOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5B8AB80", Offset = "0x5B89980", VA = "0x185B8AB80", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action EANFDMOLKNM
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5B8A460", Offset = "0x5B89260", VA = "0x185B8A460", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5B8A280", Offset = "0x5B89080", VA = "0x185B8A280", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action KIOCDOHAPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5B8A320", Offset = "0x5B89120", VA = "0x185B8A320", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5B8A3C0", Offset = "0x5B891C0", VA = "0x185B8A3C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	[UnityEngine.Scripting.Preserve]
	public BPAFGFLBMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5B89FE0", Offset = "0x5B88DE0", VA = "0x185B89FE0")]
	[DJDJPHIPNFL(IEJLPKKICHC.GameOnly)]
	private static void AIJFPABKFOK(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5B8ADF0", Offset = "0x5B89BF0", VA = "0x185B8ADF0")]
	[DJDJPHIPNFL(IEJLPKKICHC.EditorOnly)]
	private static void OMDOIBGBJGB(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5B8A730", Offset = "0x5B89530", VA = "0x185B8A730", Slot = "8")]
	public MMMPEMHFGNJ HCKCHEHGBKI(string GNGNAFBJOBB, string EJOFNPJEMNF, [Optional] NNPFIGJEFLH IGFHPKBICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5B8A170", Offset = "0x5B88F70", VA = "0x185B8A170", Slot = "11")]
	public MMMPEMHFGNJ CABMILEPMJO(NNPFIGJEFLH IGFHPKBICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5B8A500", Offset = "0x5B89300", VA = "0x185B8A500", Slot = "12")]
	public MMMPEMHFGNJ FOOCOKOJAMK(NNPFIGJEFLH IGFHPKBICAA, Dictionary<string, string> LDJPNKCCOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5B8A0C0", Offset = "0x5B88EC0", VA = "0x185B8A0C0", Slot = "13")]
	public bool BICAFDCDJPO(string KNKBGFNOKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5B8ACE0", Offset = "0x5B89AE0", VA = "0x185B8ACE0", Slot = "14")]
	public GLEIPIBDNOM MMCBGFLCLNF(string HFDELLEEAHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5B8ABD0", Offset = "0x5B899D0", VA = "0x185B8ABD0", Slot = "15")]
	public IICHKOMANBI LJECDDABHEA(string NOLMDLOGCIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5B8A620", Offset = "0x5B89420", VA = "0x185B8A620", Slot = "16")]
	public MMMPEMHFGNJ GFKOEPCEEML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7ABD60", Offset = "0x7AAB60", VA = "0x1807ABD60")]
	[CompilerGenerated]
	private void GNHLGNJLHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xADE750", Offset = "0xADD550", VA = "0x180ADE750")]
	[CompilerGenerated]
	private void DPGMEPMJBIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EPKCJICBAAG : CPMLMAGGHDP
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NCHMLMBHEAA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string NCJBBIIHOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action EANFDMOLKNM
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5B8F010", Offset = "0x5B8DE10", VA = "0x185B8F010", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EE30", Offset = "0x5B8DC30", VA = "0x185B8EE30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action KIOCDOHAPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EED0", Offset = "0x5B8DCD0", VA = "0x185B8EED0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EF70", Offset = "0x5B8DD70", VA = "0x185B8EF70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	[RecRoom.NoEngine.Common.Preserve]
	public EPKCJICBAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F1D0", Offset = "0x5B8DFD0", VA = "0x185B8F1D0", Slot = "8")]
	public MMMPEMHFGNJ HCKCHEHGBKI(string GNGNAFBJOBB, string EJOFNPJEMNF, [Optional] NNPFIGJEFLH IGFHPKBICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5B8EDA0", Offset = "0x5B8DBA0", VA = "0x185B8EDA0", Slot = "11")]
	public MMMPEMHFGNJ CABMILEPMJO(NNPFIGJEFLH IGFHPKBICAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F0B0", Offset = "0x5B8DEB0", VA = "0x185B8F0B0", Slot = "12")]
	public MMMPEMHFGNJ FOOCOKOJAMK(NNPFIGJEFLH IGFHPKBICAA, Dictionary<string, string> LDJPNKCCOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
	public bool BICAFDCDJPO(string KNKBGFNOKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F270", Offset = "0x5B8E070", VA = "0x185B8F270", Slot = "14")]
	public GLEIPIBDNOM MMCBGFLCLNF(string HFDELLEEAHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F260", Offset = "0x5B8E060", VA = "0x185B8F260", Slot = "15")]
	public IICHKOMANBI LJECDDABHEA(string NOLMDLOGCIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F140", Offset = "0x5B8DF40", VA = "0x185B8F140", Slot = "16")]
	public MMMPEMHFGNJ GFKOEPCEEML()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface NOELKLCLOMP
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNEPDHHOHAO INIHGFJAACO(string MJMKPHHBDJD);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface FBNOCPOJNGO
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	long HDAIILKAFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string MAKGLDCKEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string MHHAMJLLMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	string PFDPPAGJJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string IMPDFOJPMCD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool KBMDIFAGLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long DOLDPOGAEIK();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BGICCFCGNJN(long EEFBHJBOLAH, bool JFIAPCFACKK = true);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NBNLJHCBDHP(string DDMHMHFODEB, string PBCNFPCMHGO, string NEBNCCOLOIN);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JBNEFMKHAED(string DDMHMHFODEB);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CMGLDFALOMP(string DDMHMHFODEB, string NFNKKHNGOED, string KFFPMGOGEAB);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BEJHEMBEIAJ(string PEJNLGAGBJB, object BMIJFKFEMBP, object EDDNAJFMJJF);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NNPFIGJEFLH
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool LGOPNOAIKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool CGDKKGPEFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool IMGBGMGENLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool? MBGKOLMFBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	int? PFBDHGIBBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	int EJNGILBJJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string GCKGKNOELJH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string DKHDCBNHGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string EHLCMCKOLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	long HPFJFDFMFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string GJPPIKOPMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string ABHBNMDOFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string DNBIBALAEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string KHJLACFCLLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	double OAMFOAFOELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	int ENEJFPKPDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
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
