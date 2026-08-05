using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AC6CD0", Offset = "0x7AC56D0", VA = "0x187AC6CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6160", Offset = "0x7AC4B60", VA = "0x187AC6160", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7AC8760", Offset = "0x7AC7160", VA = "0x187AC8760", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
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
		public AmplitudeAnalyticsClient.Settings MFBOMPAFBBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool DEFKNIHBLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA10D70", Offset = "0xA0F770", VA = "0x180A10D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, INBJDGLCFFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum FAHBNJKLNKN
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class AIPODFCJOAI
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class BHOMCMGPPHA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int OIEKFEDCBMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> NBMOJDBGAHB;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
				public BHOMCMGPPHA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class ODOKCHEEHIH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
				public ODOKCHEEHIH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x7AC7720", Offset = "0x7AC6120", VA = "0x187AC7720")]
				internal bool JEMPCCODOJD(BHOMCMGPPHA item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string OPPPMEGEDCK = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string KJHMBICDBAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<BHOMCMGPPHA> NNPCIOPOKKB;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? KKCHIPHOEOP
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x7AB54C0", Offset = "0x7AB3EC0", VA = "0x187AB54C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7AB6780", Offset = "0x7AB5180", VA = "0x187AB6780")]
			internal AIPODFCJOAI(string JFAGFHDEMGP, string LHGJDHICEOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7AB5560", Offset = "0x7AB3F60", VA = "0x187AB5560")]
			public int BHCLHFGAOFF([Optional] int? KIBPAHBGOLK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB6050", Offset = "0x7AB4A50", VA = "0x187AB6050")]
			public List<Dictionary<string, object>> HACEPHJLHBC(int BJBCPAKLBBA, int? KIBPAHBGOLK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7AB5EA0", Offset = "0x7AB48A0", VA = "0x187AB5EA0")]
			public void EPMFAIIDLAO(AmplitudeAnalyticsIdentifyMessage OJDHMKOBKLD, bool NHCNCLHGJOL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7AB5F40", Offset = "0x7AB4940", VA = "0x187AB5F40")]
			public void EPMFAIIDLAO(Dictionary<string, object> OJDHMKOBKLD, bool NHCNCLHGJOL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7AB6600", Offset = "0x7AB5000", VA = "0x187AB6600")]
			public void PDGFEJAPDHF(params Dictionary<string, object>[] NOGHJAEELHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7AB62C0", Offset = "0x7AB4CC0", VA = "0x187AB62C0")]
			public void ICEKAEDAPJO(List<Dictionary<string, object>> GPJAGCNEIOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7AB6500", Offset = "0x7AB4F00", VA = "0x187AB6500")]
			private void KLDBHAGMOJB(Dictionary<string, object> OJDHMKOBKLD, bool NHCNCLHGJOL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7AB5CA0", Offset = "0x7AB46A0", VA = "0x187AB5CA0")]
			public void ENKNJJPAIHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7AB5830", Offset = "0x7AB4230", VA = "0x187AB5830")]
			private void EHNGFMHLJMF([Optional] string HFGEHHJHHKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7AB5710", Offset = "0x7AB4110", VA = "0x187AB5710")]
			private static string CGJJJCNNEKJ(string PCDAHJCDHHF, string KJNEHANBOBO)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7AC8380", Offset = "0x7AC6D80", VA = "0x187AC8380")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct IAMBELLLBFD<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int LBIIHJPNJNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string JJIOMBHGAAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T OGPDJGCIFCI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class BNFHKLGMAOG : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private HGOIDBIKHMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public BNFHKLGMAOG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE150", Offset = "0x7ABCB50", VA = "0x187ABE150", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE8E0", Offset = "0x7ABD2E0", VA = "0x187ABE8E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class IBHBLDFBFGN : IEnumerator<object>, IEnumerator, IDisposable
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
			public NPBFAPINKBN quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public IBHBLDFBFGN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7AC4500", Offset = "0x7AC2F00", VA = "0x187AC4500", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7AC4610", Offset = "0x7AC3010", VA = "0x187AC4610", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ACEAEPEOMJG : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public ACEAEPEOMJG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB4D30", Offset = "0x7AB3730", VA = "0x187AB4D30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7AB4EA0", Offset = "0x7AB38A0", VA = "0x187AB4EA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class OOBDBKIFJIL : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private HGOIDBIKHMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public OOBDBKIFJIL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7AC7790", Offset = "0x7AC6190", VA = "0x187AC7790", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7AC79F0", Offset = "0x7AC63F0", VA = "0x187AC79F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class EDIOPOMOLOK : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private HGOIDBIKHMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public EDIOPOMOLOK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0540", Offset = "0x7ABEF40", VA = "0x187AC0540", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7AC0790", Offset = "0x7ABF190", VA = "0x187AC0790", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class CEFCPAJMGFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public AIPODFCJOAI cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public CEFCPAJMGFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7ABEE60", Offset = "0x7ABD860", VA = "0x187ABEE60")]
			internal void OEHALAOFMAJ(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7ABEA10", Offset = "0x7ABD410", VA = "0x187ABEA10")]
			internal void INIDEJOCEHM(IAMBELLLBFD<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class CHJECDHGPDL : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private HGOIDBIKHMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AIPODFCJOAI cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private CEFCPAJMGFP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private float <startTime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private bool <timedOut>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private int <batchSize>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public CHJECDHGPDL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7ABF180", Offset = "0x7ABDB80", VA = "0x187ABF180", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7ABF990", Offset = "0x7ABE390", VA = "0x187ABF990", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class NBOJHJDKNHO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public NBOJHJDKNHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x54FBC00", Offset = "0x54FA600", VA = "0x1854FBC00")]
			internal IAMBELLLBFD<T> PKKBPCOPFOL(BFCJHBFBDFK postResponse)
			{
				return default(IAMBELLLBFD<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private IEANCGLMOMK AINKEENJLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<GPPEONLDBAP> EOCBGFPHPLC;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string HLAPDAAFKBA = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string EOGBGNGEDBI = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string IGJOEAGPPFH = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int LPMNCOLNKND = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int DAJEIFENGKN = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int LOPMCPPDNPI = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float AMIIOJJCKLP = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long GKBIBNIKMJB = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string DDILHPGABLK = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string BGBKJAGBDAH = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string CGJIKGEFLLJ = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string FGOIJNCEBFG = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool MDKCANMNIAD;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool BGKFLKNILNE;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int ANOAJCPAOGE;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int IKELEDDONOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private BPIHGALIOEH LEFGGFFOLCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DMGFFMKLNKM FMGADHBGAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private IECMHFBIMFA FADPPBNPFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool CPJCICKPFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float DJOGHKBKNKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float IFHCKHIJKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int KINONIAEELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int JLEABICKGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? BNBMCGFDNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? POBHOKNHADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long AECCLKGPIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string LNOMHCGGGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string BDLIIIHNLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long GIMHPICMJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string BHIPNAIBKPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string NCMFBMFKDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> BBJHHJNIHIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private FAHBNJKLNKN IOKFMMNCHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int ABJHHCDPMDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int LOKJMECEIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float AOOCLPBLJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool GCGLLEJDOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool LEAMHJFBAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private AIPODFCJOAI ABBPGLBCNDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private AIPODFCJOAI GIKCDNADBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private AIPODFCJOAI HJILCINIFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string DAGLBDIIIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> EGGOILBMNOF;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo MCMIKFNEHCI;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string GEGGDCJKDFM;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string BGGNHNMCBMI = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string OAHKGIKLCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string KKFCLPBHKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string POPBJACPNIB;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private IEANCGLMOMK CEDBGIHNHJC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9320", Offset = "0x7AB7D20", VA = "0x187AB9320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private GPPEONLDBAP HBKEIPHGAKM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9240", Offset = "0x7AB7C40", VA = "0x187AB9240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int FALOIAKCJPC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9DA0", Offset = "0x7AB87A0", VA = "0x187AB9DA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long OMNJLPCJEOC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC7B0", Offset = "0x7ABB1B0", VA = "0x187ABC7B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC8C0", Offset = "0x7ABB2C0", VA = "0x187ABC8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string DCCFFOJNIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC780", Offset = "0x7ABB180", VA = "0x187ABC780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JBBKFJFGMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1599A60", Offset = "0x1598460", VA = "0x181599A60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1598060", Offset = "0x1596A60", VA = "0x181598060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OAHKIDPJCFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA7F280", Offset = "0xA7DC80", VA = "0x180A7F280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA7AE20", Offset = "0xA79820", VA = "0x180A7AE20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? CDAIIPBDOCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAAEB30", Offset = "0xAAD530", VA = "0x180AAEB30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xC47C40", Offset = "0xC46640", VA = "0x180C47C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GAFEADEAJAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA8DEA0", Offset = "0xA8C8A0", VA = "0x180A8DEA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA8D540", Offset = "0xA8BF40", VA = "0x180A8D540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool FLCGPECFLJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC660", Offset = "0x7ABB060", VA = "0x187ABC660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> CJPIOOOHLCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC5A0", Offset = "0x7ABAFA0", VA = "0x187ABC5A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7ABC800", Offset = "0x7ABB200", VA = "0x187ABC800")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6C60", Offset = "0x7AB5660", VA = "0x187AB6C60", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB72C0", Offset = "0x7AB5CC0", VA = "0x187AB72C0")]
		private void BJCODLAGCNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBBE0", Offset = "0x7ABA5E0", VA = "0x187ABBBE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7ABA7D0", Offset = "0x7AB91D0", VA = "0x187ABA7D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBF10", Offset = "0x7ABA910", VA = "0x187ABBF10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7ABA960", Offset = "0x7AB9360", VA = "0x187ABA960")]
		public FDBBAHKKNBB PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7AB98A0", Offset = "0x7AB82A0", VA = "0x187AB98A0")]
		[IteratorStateMachine(typeof(BNFHKLGMAOG))]
		public IEnumerator<HGOIDBIKHMF> InitializeForLocalAccount(AmplitudeAnalyticsEvent OPECLLHIPBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7ABB2C0", Offset = "0x7AB9CC0", VA = "0x187ABB2C0")]
		public void SendAppEnterEvent(bool CKPFJDAHGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBE90", Offset = "0x7ABA890", VA = "0x187ABBE90")]
		public void UpdateLastKnownInteractionCategory(string POJBGAGCBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBDE0", Offset = "0x7ABA7E0", VA = "0x187ABBDE0")]
		public void UpdateLastAliveTime(float HMAHKNFCDDP = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9AA0", Offset = "0x7AB84A0", VA = "0x187AB9AA0")]
		private FDBBAHKKNBB JPAGKEIKLMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9930", Offset = "0x7AB8330", VA = "0x187AB9930")]
		private FDBBAHKKNBB JFDAMKLNNGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7ABB5D0", Offset = "0x7AB9FD0", VA = "0x187ABB5D0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9D10", Offset = "0x7AB8710", VA = "0x187AB9D10")]
		[IteratorStateMachine(typeof(IBHBLDFBFGN))]
		private IEnumerator LBCEBAAGCOL(NPBFAPINKBN KKIEMFJCCMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC1A0", Offset = "0x7ABABA0", VA = "0x187ABC1A0")]
		[IteratorStateMachine(typeof(ACEAEPEOMJG))]
		public IEnumerator WaitForFlush(float PFDFCFFBOMM = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBCC0", Offset = "0x7ABA6C0", VA = "0x187ABBCC0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBC00", Offset = "0x7ABA600", VA = "0x187ABBC00")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime FDFNAMJJMBO)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB93B0", Offset = "0x7AB7DB0", VA = "0x187AB93B0")]
		public static ACIOECBJLGI Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6AC0", Offset = "0x7AB54C0", VA = "0x187AB6AC0")]
		public static MLNNBFIHMFO AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string JGHPIKBCGCH, string AIJBEMKBLNM, KIOALPNDGOH LLMHBJCNEEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7AB8830", Offset = "0x7AB7230", VA = "0x187AB8830")]
		public static MLNNBFIHMFO Event([JetBrains.Annotations.NotNull] string JGHPIKBCGCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7ABAAF0", Offset = "0x7AB94F0", VA = "0x187ABAAF0")]
		public static MLNNBFIHMFO PreviousSessionEvent([JetBrains.Annotations.NotNull] string JGHPIKBCGCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9550", Offset = "0x7AB7F50", VA = "0x187AB9550")]
		public static MLNNBFIHMFO InitializeEvent(string AIJBEMKBLNM, int EDGIKKOFAGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7ABB7D0", Offset = "0x7ABA1D0", VA = "0x187ABB7D0")]
		public static MLNNBFIHMFO StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7AB84E0", Offset = "0x7AB6EE0", VA = "0x187AB84E0")]
		public static MLNNBFIHMFO CreateOutOfSessionEvent(string JGHPIKBCGCH, bool EPINGHNHPGM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7ABA200", Offset = "0x7AB8C00", VA = "0x187ABA200")]
		public static FDBBAHKKNBB LogOutOfSessionEvent(MLNNBFIHMFO GNLMGAJIDMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9FA0", Offset = "0x7AB89A0", VA = "0x187AB9FA0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent ICILIKMNGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7ABA3C0", Offset = "0x7AB8DC0", VA = "0x187ABA3C0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent ICILIKMNGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7ABA4F0", Offset = "0x7AB8EF0", VA = "0x187ABA4F0")]
		public void LogSerializedEventAsync(Dictionary<string, object> FAOLCAKAMNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7ABA0D0", Offset = "0x7AB8AD0", VA = "0x187ABA0D0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage GCHOGGPDADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7680", Offset = "0x7AB6080", VA = "0x187AB7680")]
		private void CDCPAJPMGCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB8EF0", Offset = "0x7AB78F0", VA = "0x187AB8EF0")]
		private void FNACODAFOGB(Dictionary<string, object> OKMGMCHIGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7ABA5D0", Offset = "0x7AB8FD0", VA = "0x187ABA5D0")]
		private void MNFPPONFBJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB68F0", Offset = "0x7AB52F0", VA = "0x187AB68F0")]
		private void AHIAGINOJKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7AB91B0", Offset = "0x7AB7BB0", VA = "0x187AB91B0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7AB87A0", Offset = "0x7AB71A0", VA = "0x187AB87A0")]
		[IteratorStateMachine(typeof(OOBDBKIFJIL))]
		private IEnumerator<HGOIDBIKHMF> DEGFBKBFGPJ(float PFDFCFFBOMM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9290", Offset = "0x7AB7C90", VA = "0x187AB9290")]
		[IteratorStateMachine(typeof(EDIOPOMOLOK))]
		private IEnumerator<HGOIDBIKHMF> GJCDLGKPNKA(float PFDFCFFBOMM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7ABA880", Offset = "0x7AB9280", VA = "0x187ABA880")]
		[IteratorStateMachine(typeof(CHJECDHGPDL))]
		private IEnumerator<HGOIDBIKHMF> POPLBPMJMOA(AIPODFCJOAI DIAPHCLLMBP, int? KIBPAHBGOLK, string OKHGAIAGLDG, float PFDFCFFBOMM, Action<int> CGBBBPHJMFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7ABA6C0", Offset = "0x7AB90C0", VA = "0x187ABA6C0")]
		private static void MPIMCOCMILD(bool KOOJLHKFJDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7AB8E20", Offset = "0x7AB7820", VA = "0x187AB8E20")]
		private MPBOGDMHBIL<IAMBELLLBFD<Dictionary<string, object>>> FDAIBHHIPFB(string OKHGAIAGLDG, string DIODLLHLKCD, Dictionary<string, object> OGPDJGCIFCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7AB8B40", Offset = "0x7AB7540", VA = "0x187AB8B40")]
		private MPBOGDMHBIL<IAMBELLLBFD<List<Dictionary<string, object>>>> FDAIBHHIPFB(string OKHGAIAGLDG, string DIODLLHLKCD, List<Dictionary<string, object>> OGPDJGCIFCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x303AB40", Offset = "0x3039540", VA = "0x18303AB40")]
		private MPBOGDMHBIL<IAMBELLLBFD<T>> PJIIEKGCJPM<T>(string BCNBCNCDIKC, string OKHGAIAGLDG, string DIODLLHLKCD, T OGPDJGCIFCI, Dictionary<string, object> JMDBFAOOJEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9CC0", Offset = "0x7AB86C0", VA = "0x187AB9CC0")]
		private bool KPHHJEDGOHG(float JCDBIBKMNJP, float PFDFCFFBOMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7780", Offset = "0x7AB6180", VA = "0x187AB7780")]
		private Dictionary<string, object> CEIKPGNJHNH(string OKHGAIAGLDG, Dictionary<string, object> OGPDJGCIFCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC290", Offset = "0x7ABAC90", VA = "0x187ABC290")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA37E00", Offset = "0xA36800", VA = "0x180A37E00", Slot = "6")]
		private bool KOELFKEGDPC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9B50", Offset = "0x7AB8550", VA = "0x187AB9B50")]
		[CompilerGenerated]
		private long KIOLDHGPGOM()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7AB8B30", Offset = "0x7AB7530", VA = "0x187AB8B30")]
		[CompilerGenerated]
		private void FAKJGEBGMPE(int LNGBMDMPNMJ)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly string assignedUserCrm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD5A0", Offset = "0x7ABBFA0", VA = "0x187ABD5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD670", Offset = "0x7ABC070", VA = "0x187ABD670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD5E0", Offset = "0x7ABBFE0", VA = "0x187ABD5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD6C0", Offset = "0x7ABC0C0", VA = "0x187ABD6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD560", Offset = "0x7ABBF60", VA = "0x187ABD560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD620", Offset = "0x7ABC020", VA = "0x187ABD620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCB30", Offset = "0x7ABB530", VA = "0x187ABCB30")]
		public static MLNNBFIHMFO JEBOFNEMEAN(string GPMAOGCPKOA, [JetBrains.Annotations.NotNull] string NHLGJCILFKP, long AFFBGADOFHN, long FBGNCELOIEL, string AIJBEMKBLNM, string LLMHBJCNEEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD0F0", Offset = "0x7ABBAF0", VA = "0x187ABD0F0")]
		public static MLNNBFIHMFO KLMLBEEKFLD(string GPMAOGCPKOA, [JetBrains.Annotations.NotNull] string NHLGJCILFKP, long AFFBGADOFHN, long FBGNCELOIEL, string AIJBEMKBLNM, long MBCMBOGCLGG, string KHGDPDDOJND, string LBICBDLFBDC, string PLDKIBBFDIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD3C0", Offset = "0x7ABBDC0", VA = "0x187ABD3C0")]
		private AmplitudeAnalyticsEvent(string GPMAOGCPKOA, [JetBrains.Annotations.NotNull] string NHLGJCILFKP, long AFFBGADOFHN, long FBGNCELOIEL, string AIJBEMKBLNM, string LLMHBJCNEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xF01270", Offset = "0xEFFC70", VA = "0x180F01270")]
		public void LBLNKLIMHAF(long IDPBFNGMLOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCA30", Offset = "0x7ABB430", VA = "0x187ABCA30", Slot = "5")]
		public override void HDCPBJDHLEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD250", Offset = "0x7ABBC50", VA = "0x187ABD250", Slot = "6")]
		public override void PANOHMMCDBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCC30", Offset = "0x7ABB630", VA = "0x187ABCC30", Slot = "4")]
		protected override Dictionary<string, object> JICOJANGGJN(Dictionary<string, object> GJOPNFGGPHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC920", Offset = "0x7ABB320", VA = "0x187ABC920")]
		private void BEIHEMLKDPL(string KJNEHANBOBO, string PCDAHJCDHHF, bool OHLPCHMBOIP = false)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7AC03C0", Offset = "0x7ABEDC0", VA = "0x187AC03C0")]
			public void LLADNLGIKEC(Dictionary<string, object> IOJDEGJFHEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7AC8000", Offset = "0x7AC6A00", VA = "0x187AC8000")]
			public void LLADNLGIKEC(Dictionary<string, object> ABFMLMHFIEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x1402520", Offset = "0x1400F20", VA = "0x181402520")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD830", Offset = "0x7ABC230", VA = "0x187ABD830")]
		public static ACIOECBJLGI JEBOFNEMEAN(string GPMAOGCPKOA, string AIJBEMKBLNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7ABDDC0", Offset = "0x7ABC7C0", VA = "0x187ABDDC0")]
		protected AmplitudeAnalyticsIdentifyMessage(string GPMAOGCPKOA, string AIJBEMKBLNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD710", Offset = "0x7ABC110", VA = "0x187ABD710")]
		public Dictionary<string, object> GBIDBHNMPEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD960", Offset = "0x7ABC360", VA = "0x187ABD960", Slot = "4")]
		protected virtual Dictionary<string, object> JICOJANGGJN(Dictionary<string, object> GJOPNFGGPHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7ABDCA0", Offset = "0x7ABC6A0", VA = "0x187ABDCA0")]
		protected void OGDKKAHDELD(string KJNEHANBOBO, Dictionary<string, object> CCPHCPBCOEJ, Dictionary<string, object> NLLOIEKLMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD8F0", Offset = "0x7ABC2F0", VA = "0x187ABD8F0")]
		protected void JFIDLLKFDGP(string KJNEHANBOBO, string PCDAHJCDHHF, Dictionary<string, object> DMCELOOPCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD7A0", Offset = "0x7ABC1A0", VA = "0x187ABD7A0", Slot = "5")]
		public virtual void HDCPBJDHLEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7ABDD40", Offset = "0x7ABC740", VA = "0x187ABDD40", Slot = "6")]
		public virtual void PANOHMMCDBA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ACIOECBJLGI : NNAGNMJLJMC<AmplitudeAnalyticsIdentifyMessage, ACIOECBJLGI>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override ACIOECBJLGI KCJPOLEGHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage PFNMAFNONME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4F90", Offset = "0x7AB3990", VA = "0x187AB4F90")]
	public ACIOECBJLGI(AmplitudeAnalyticsIdentifyMessage IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4EF0", Offset = "0x7AB38F0", VA = "0x187AB4EF0", Slot = "4")]
	public override void PANOHMMCDBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MLNNBFIHMFO : NNAGNMJLJMC<AmplitudeAnalyticsEvent, MLNNBFIHMFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool ENGAMIKEIHH;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override MLNNBFIHMFO KCJPOLEGHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long GENKEKCCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7AC63B0", Offset = "0x7AC4DB0", VA = "0x187AC63B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0980", Offset = "0x7ABF380", VA = "0x187AC0980")]
	public MLNNBFIHMFO(AmplitudeAnalyticsEvent IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "5")]
	public override AmplitudeAnalyticsEvent PFNMAFNONME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7AC63D0", Offset = "0x7AC4DD0", VA = "0x187AC63D0", Slot = "4")]
	public override void PANOHMMCDBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3B58240", Offset = "0x3B56C40", VA = "0x183B58240")]
	public MLNNBFIHMFO BCIABGNDJKM<T>(string MLCOAPMDJJE, T[] PCDAHJCDHHF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3B58240", Offset = "0x3B56C40", VA = "0x183B58240")]
	public MLNNBFIHMFO BCIABGNDJKM(string MLCOAPMDJJE, string[] PCDAHJCDHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3B57F90", Offset = "0x3B56990", VA = "0x183B57F90")]
	public MLNNBFIHMFO BCIABGNDJKM<T>(string MLCOAPMDJJE, T PCDAHJCDHHF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7AC61F0", Offset = "0x7AC4BF0", VA = "0x187AC61F0")]
	public MLNNBFIHMFO BCIABGNDJKM(string MLCOAPMDJJE, long PCDAHJCDHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7AC6270", Offset = "0x7AC4C70", VA = "0x187AC6270")]
	public MLNNBFIHMFO BCIABGNDJKM(string MLCOAPMDJJE, string PCDAHJCDHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7AC6380", Offset = "0x7AC4D80", VA = "0x187AC6380")]
	public MLNNBFIHMFO GOJDIKFPBPE(string MLCOAPMDJJE, object? PCDAHJCDHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7AC62E0", Offset = "0x7AC4CE0", VA = "0x187AC62E0")]
	public MLNNBFIHMFO BMIMNFJFOAP(string MLCOAPMDJJE, string PCDAHJCDHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7AC6470", Offset = "0x7AC4E70", VA = "0x187AC6470")]
	private MLNNBFIHMFO PCLJOGGBMPB(string MLCOAPMDJJE, object PCDAHJCDHHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EGDNDLHLKJG : MLNNBFIHMFO
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0980", Offset = "0x7ABF380", VA = "0x187AC0980")]
	public EGDNDLHLKJG(AmplitudeAnalyticsEvent IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7AC07E0", Offset = "0x7ABF1E0", VA = "0x187AC07E0", Slot = "4")]
	public override void PANOHMMCDBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class NNAGNMJLJMC<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : NNAGNMJLJMC<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M IJOJGNJMCGP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR KCJPOLEGHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public NNAGNMJLJMC(M IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x553FCF0", Offset = "0x553E6F0", VA = "0x18553FCF0")]
	public BLDR BJJLMMMKMGL(AmplitudeAnalyticsIdentifyMessage.DeviceInfo FJOJMGKGPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x553FDE0", Offset = "0x553E7E0", VA = "0x18553FDE0")]
	public BLDR NNEPCHNNILE(AmplitudeAnalyticsIdentifyMessage.RevenueData KJCIPPLLKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x553FD40", Offset = "0x553E740", VA = "0x18553FD40")]
	public BLDR GDOLEEDIICJ(string MLCOAPMDJJE, string PCDAHJCDHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x41DF1F0", Offset = "0x41DDBF0", VA = "0x1841DF1F0")]
	public BLDR GDOLEEDIICJ<T>(string MLCOAPMDJJE, T PCDAHJCDHHF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PANOHMMCDBA();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x553FDB0", Offset = "0x553E7B0", VA = "0x18553FDB0")]
	internal static string GNNMLDIDFNM(string PCDAHJCDHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x553FBF0", Offset = "0x553E5F0", VA = "0x18553FBF0")]
	private BLDR BDFMOEGEBDP(string MLCOAPMDJJE, object PCDAHJCDHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M PFNMAFNONME();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class ABGNANMLGLO : BPIHGALIOEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct JGFDAHEKIID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<BFCJHBFBDFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public ABGNANMLGLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private StringContent <requestBody>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private HttpRequestMessage <request>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private HttpResponseMessage <httpResponse>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5440", Offset = "0x7AC3E40", VA = "0x187AC5440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5E70", Offset = "0x7AC4870", VA = "0x187AC5E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient MPLAKJGOGHP;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4C40", Offset = "0x7AB3640", VA = "0x187AB4C40")]
	[CGLGNCLDKHN.CKJOAALDIOP]
	internal static void MIFFFCBIIAF(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4CB0", Offset = "0x7AB36B0", VA = "0x187AB4CB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public ABGNANMLGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4AD0", Offset = "0x7AB34D0", VA = "0x187AB4AD0", Slot = "4")]
	[AsyncStateMachine(typeof(JGFDAHEKIID))]
	public Task<BFCJHBFBDFK> GCHDACLBMLL(string BCNBCNCDIKC, string MMMPAEBMNKG, string KFIOJKHMLDH, string JFJGNGHLKBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class ENDAONHKHPO : BPIHGALIOEH
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CCMBIPMFAHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<BFCJHBFBDFK> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public CCMBIPMFAHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE930", Offset = "0x7ABD330", VA = "0x187ABE930")]
		internal void CLOBDLANCNL(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct OOLGCFMBDAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<BFCJHBFBDFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<BFCJHBFBDFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7A40", Offset = "0x7AC6440", VA = "0x187AC7A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7F90", Offset = "0x7AC6990", VA = "0x187AC7F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	[CGLGNCLDKHN.CKJOAALDIOP]
	internal static void HKNEIDBOPOK(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public ENDAONHKHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7AC09D0", Offset = "0x7ABF3D0", VA = "0x187AC09D0", Slot = "4")]
	[AsyncStateMachine(typeof(OOLGCFMBDAB))]
	public Task<BFCJHBFBDFK> GCHDACLBMLL(string BCNBCNCDIKC, string MMMPAEBMNKG, string KFIOJKHMLDH, string JFJGNGHLKBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BLLDGBIAHOA
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> KOODFNLIEDL;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7ABDFB0", Offset = "0x7ABC9B0", VA = "0x187ABDFB0")]
	internal static bool DBKHECHHPMI(string KJNEHANBOBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface BPIHGALIOEH
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BFCJHBFBDFK> GCHDACLBMLL(string BCNBCNCDIKC, string MMMPAEBMNKG, string KFIOJKHMLDH, string JFJGNGHLKBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct BFCJHBFBDFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int OCINNNBGEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string LMNKDMMGDPP;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x17A0610", Offset = "0x179F010", VA = "0x1817A0610")]
	public BFCJHBFBDFK(int LBIIHJPNJNG, string JJIOMBHGAAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum IPNLAEAJJGP
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	GameInvite,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	RoomChat,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DebugCommand,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	WidgetWatch
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NKELFEIGIPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private long MFFFCBMHEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private MLNNBFIHMFO GEGIBFPNNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool CKKDNCKCDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private float NHELEEECFIB;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7AC6900", Offset = "0x7AC5300", VA = "0x187AC6900")]
	public NKELFEIGIPF(string KNKPJNJBJOP, float NHELEEECFIB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA730", Offset = "0x3BB9130", VA = "0x183BBA730")]
	public void BCIABGNDJKM<T>(string MLCOAPMDJJE, T PCDAHJCDHHF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7AC6570", Offset = "0x7AC4F70", VA = "0x187AC6570")]
	public void BCIABGNDJKM(string MLCOAPMDJJE, string PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7AC67C0", Offset = "0x7AC51C0", VA = "0x187AC67C0")]
	public void DNHJPINJJEP(string GLALMLACEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7AC65F0", Offset = "0x7AC4FF0", VA = "0x187AC65F0")]
	public void CNBEHAJJDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7AC66B0", Offset = "0x7AC50B0", VA = "0x187AC66B0")]
	private void DLBMGMKLBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7AC68B0", Offset = "0x7AC52B0", VA = "0x187AC68B0")]
	private bool HBHPKACBLAN()
	{
		return default(bool);
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum FOCPFCGFOOE
		{
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			String,
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			Bool
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private FOCPFCGFOOE parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public FOCPFCGFOOE Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550")]
			get
			{
				return default(FOCPFCGFOOE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA38610", Offset = "0xA37010", VA = "0x180A38610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7AC8170", Offset = "0x7AC6B70", VA = "0x187AC8170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class NCLPFGDNGPD<T> : MHIKODPGGDA<T>, KNCEKGECIEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly NDICJCLBPMH DGDCHCJJMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string OLNBDAKOELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly string JBFOPHBBKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private T BDLDJILLEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly T ALKDPGOIFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool BHFIEKNGBFN;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string DCOOOHMFGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x54FD420", Offset = "0x54FBE20", VA = "0x1854FD420")]
	public NCLPFGDNGPD(NDICJCLBPMH DGDCHCJJMID, string OLNBDAKOELL, string JBFOPHBBKMA, T ALKDPGOIFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x54FD1D0", Offset = "0x54FBBD0", VA = "0x1854FD1D0", Slot = "4")]
	public T BACOOPOJLAH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x54FD380", Offset = "0x54FBD80", VA = "0x1854FD380", Slot = "6")]
	public void MPMJEFEEPDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
public class AFFMMKMJJFF : ACEKNKBAKIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct BGDFGAMMIEH : IEquatable<BGDFGAMMIEH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly string BAKIDHGKMDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly string ABGHGAJDHPE;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xB64460", Offset = "0xB62E60", VA = "0x180B64460")]
		public BGDFGAMMIEH(string LLAHNKFCDCD, string DCGKPCPLCIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x129E3F0", Offset = "0x129CDF0", VA = "0x18129E3F0", Slot = "4")]
		public bool Equals(BGDFGAMMIEH NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7ABDE80", Offset = "0x7ABC880", VA = "0x187ABDE80", Slot = "0")]
		public override bool Equals(object OJDHMKOBKLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7ABDF40", Offset = "0x7ABC940", VA = "0x187ABDF40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private NDICJCLBPMH DGDCHCJJMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Dictionary<BGDFGAMMIEH, KNCEKGECIEN> GLCIKDALFEG;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7AB52A0", Offset = "0x7AB3CA0", VA = "0x187AB52A0")]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	internal static void NBDHNJGHJEB(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5310", Offset = "0x7AB3D10", VA = "0x187AB5310")]
	[RecRoom.NoEngine.Common.Preserve]
	public AFFMMKMJJFF([System.Diagnostics.CodeAnalysis.NotNull][CNHMBDDCGKB(null)] NDICJCLBPMH DGDCHCJJMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4FE0", Offset = "0x7AB39E0", VA = "0x187AB4FE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5290", Offset = "0x7AB3C90", VA = "0x187AB5290")]
	private void ELIFMDIAIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7AB50E0", Offset = "0x7AB3AE0", VA = "0x187AB50E0")]
	private void EDEOONFLFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3001B00", Offset = "0x3000500", VA = "0x183001B00", Slot = "4")]
	public MHIKODPGGDA<T> MDJPFBCGLCL<T>(string OLNBDAKOELL, string LCFNBPHBNNI, T ALKDPGOIFPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class LONEILGAKIN : CLAAPMDPEND, EKIKOENLFCM
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void MDNJDNFEBNJ(LFDGPDCKKAM IDPMGHAJNPH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly HLFFGADEPDM EGGFPNDBKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly MDNJDNFEBNJ PEDGAFFNBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly string JCNIMKBDIBC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string HMKINKIIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1153380", Offset = "0x1151D80", VA = "0x181153380", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string JFJINPPGHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8330", Offset = "0x1CC6D30", VA = "0x181CC8330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool EOJNCIDJACK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6140", Offset = "0x7AC4B40", VA = "0x187AC6140", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool EGDGCFFGEFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6120", Offset = "0x7AC4B20", VA = "0x187AC6120", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyList<string> LNLJMLDAOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8310", Offset = "0x1CC6D10", VA = "0x181CC8310", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x12F7490", Offset = "0x12F5E90", VA = "0x1812F7490")]
	public LONEILGAKIN(HLFFGADEPDM DHADAJLMNNE, string BLMPIACOCIE, [Optional] MDNJDNFEBNJ ONLJIGBEIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3B25530", Offset = "0x3B23F30", VA = "0x183B25530", Slot = "9")]
	public T IBPMNADNGOO<T>(string KJNEHANBOBO, T ALKDPGOIFPD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class GNKOKHPBDPB : NDICJCLBPMH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct OBILJNKMGHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public DMGFFMKLNKM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GNKOKHPBDPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6D50", Offset = "0x7AC5750", VA = "0x187AC6D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7AC76C0", Offset = "0x7AC60C0", VA = "0x187AC76C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct NOPEEDGDDEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6A90", Offset = "0x7AC5490", VA = "0x187AC6A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6C70", Offset = "0x7AC5670", VA = "0x187AC6C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct HNNHLILGPIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public DMGFFMKLNKM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public GNKOKHPBDPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4070", Offset = "0x7AC2A70", VA = "0x187AC4070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7AC44A0", Offset = "0x7AC2EA0", VA = "0x187AC44A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct IKBKFOHNBEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public GNKOKHPBDPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public DMGFFMKLNKM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4660", Offset = "0x7AC3060", VA = "0x187AC4660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4A20", Offset = "0x7AC3420", VA = "0x187AC4A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly IReadOnlyDictionary<string, JHGPCPINDIF> DLPHINMCKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool GNFAFEAHDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private bool HGOAHFMGPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private TaskCompletionSource<bool> BPGKPFBPDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private TaskCompletionSource<bool> IDBLGNOMGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly SemaphoreSlim BMMIMPDBLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private IOCJJABNGOD PMDNJFPOPHG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task EGJJPDPBHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0BE0", Offset = "0x7ABF5E0", VA = "0x187AC0BE0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task NLPGBFINLGD
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC14E0", Offset = "0x7ABFEE0", VA = "0x187AC14E0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DLCICJFJEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA97A50", Offset = "0xA96450", VA = "0x180A97A50", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool LBCNJLNDBHP
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA979F0", Offset = "0xA963F0", VA = "0x180A979F0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string OAHKIDPJCFG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC11D0", Offset = "0x7ABFBD0", VA = "0x187AC11D0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MPDBEIICAED IMLBNLBFDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0C20", Offset = "0x7ABF620", VA = "0x187AC0C20", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OGKDOFEJDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1130", Offset = "0x7ABFB30", VA = "0x187AC1130", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7AC22B0", Offset = "0x7AC0CB0", VA = "0x187AC22B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PJALLIPAGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1280", Offset = "0x7ABFC80", VA = "0x187AC1280", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2120", Offset = "0x7AC0B20", VA = "0x187AC2120", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action FGELLCFNPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7AC11E0", Offset = "0x7ABFBE0", VA = "0x187AC11E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0FE0", Offset = "0x7ABF9E0", VA = "0x187AC0FE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<LFDGPDCKKAM> NCGPDONGJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1080", Offset = "0x7ABFA80", VA = "0x187AC1080", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1E60", Offset = "0x7AC0860", VA = "0x187AC1E60", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0F80", Offset = "0x7ABF980", VA = "0x187AC0F80", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0D60", Offset = "0x7ABF760", VA = "0x187AC0D60", Slot = "12")]
	[AsyncStateMachine(typeof(OBILJNKMGHE))]
	public Task DBILOAODCDE(string LHGJDHICEOA, [Optional] DMGFFMKLNKM IOIPIHCJNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0B30", Offset = "0x7ABF530", VA = "0x187AC0B30", Slot = "24")]
	[AsyncStateMachine(typeof(NOPEEDGDDEB))]
	public Task AMMNDEIHGDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2350", Offset = "0x7AC0D50", VA = "0x187AC2350", Slot = "19")]
	[AsyncStateMachine(typeof(HNNHLILGPIL))]
	public Task LLDBCMGOFPJ(DMGFFMKLNKM IOIPIHCJNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7AC28B0", Offset = "0x7AC12B0", VA = "0x187AC28B0")]
	private void OELHCMGDPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2450", Offset = "0x7AC0E50", VA = "0x187AC2450", Slot = "20")]
	[AsyncStateMachine(typeof(IKBKFOHNBEE))]
	public Task MIHNGOLNGOG(DMGFFMKLNKM IOIPIHCJNEI, Dictionary<string, string> EKIDNIPDIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7AC21C0", Offset = "0x7AC0BC0", VA = "0x187AC21C0", Slot = "21")]
	public bool JJIMDPJGGLC(string HMLKLOAEPKP, bool AICMHMEGAAO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1320", Offset = "0x7ABFD20", VA = "0x187AC1320", Slot = "22")]
	public CLAAPMDPEND HAEHGDHJNKI(string BLMPIACOCIE, bool AICMHMEGAAO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1F10", Offset = "0x7AC0910", VA = "0x187AC1F10")]
	private HLFFGADEPDM HIAMADIGAHG(string BLMPIACOCIE, bool AICMHMEGAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2700", Offset = "0x7AC1100", VA = "0x187AC2700", Slot = "23")]
	public DAAAFPEPLKO OEKAOIOKKEE(string LLAHNKFCDCD, bool AICMHMEGAAO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0E80", Offset = "0x7ABF880", VA = "0x187AC0E80")]
	private DFBJCDALJEN DNDNAKGOJLA(string LLAHNKFCDCD, bool AICMHMEGAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1520", Offset = "0x7ABFF20", VA = "0x187AC1520")]
	private CNJDHJMFIBA HCFJHFNNCKP(DMGFFMKLNKM IOIPIHCJNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2560", Offset = "0x7AC0F60", VA = "0x187AC2560")]
	private CEFDNEBPFPA NJNMFPNMLCE(string LHGJDHICEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0C50", Offset = "0x7ABF650", VA = "0x187AC0C50")]
	private void CNNAJLNFNNK(string BLMPIACOCIE, HLFFGADEPDM DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2B00", Offset = "0x7AC1500", VA = "0x187AC2B00")]
	public GNKOKHPBDPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0FA0", Offset = "0x7ABF9A0", VA = "0x187AC0FA0")]
	[CompilerGenerated]
	private void LLILOINDDIP(LFDGPDCKKAM FGEFHKAEIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0FA0", Offset = "0x7ABF9A0", VA = "0x187AC0FA0")]
	[CompilerGenerated]
	private void EAHBKFDHNCA(LFDGPDCKKAM FGEFHKAEIPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class GPKMPFCLIKH : NDICJCLBPMH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct DEMOJCOBKCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public GPKMPFCLIKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public DMGFFMKLNKM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7ABF9E0", Offset = "0x7ABE3E0", VA = "0x187ABF9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0360", Offset = "0x7ABED60", VA = "0x187AC0360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct LHHGFHHHHMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5EE0", Offset = "0x7AC48E0", VA = "0x187AC5EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private GNKOKHPBDPB JFFEEPPCMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private TaskCompletionSource<bool> BPGKPFBPDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private TaskCompletionSource<bool> IDBLGNOMGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Task LKHLKHHOGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Task AFPHEPECIGB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private NDICJCLBPMH IDBKNKJEPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3620", Offset = "0x7AC2020", VA = "0x187AC3620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LBCNJLNDBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3610", Offset = "0x7AC2010", VA = "0x187AC3610", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool DLCICJFJEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2C00", Offset = "0x7AC1600", VA = "0x187AC2C00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task EGJJPDPBHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2D20", Offset = "0x7AC1720", VA = "0x187AC2D20", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task NLPGBFINLGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3420", Offset = "0x7AC1E20", VA = "0x187AC3420", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string OAHKIDPJCFG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3200", Offset = "0x7AC1C00", VA = "0x187AC3200", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public MPDBEIICAED IMLBNLBFDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2DC0", Offset = "0x7AC17C0", VA = "0x187AC2DC0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action PJALLIPAGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC32C0", Offset = "0x7AC1CC0", VA = "0x187AC32C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3570", Offset = "0x7AC1F70", VA = "0x187AC3570", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action OGKDOFEJDGL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3160", Offset = "0x7AC1B60", VA = "0x187AC3160", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3930", Offset = "0x7AC2330", VA = "0x187AC3930", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action FGELLCFNPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3220", Offset = "0x7AC1C20", VA = "0x187AC3220", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3010", Offset = "0x7AC1A10", VA = "0x187AC3010", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<LFDGPDCKKAM> NCGPDONGJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7AC30B0", Offset = "0x7AC1AB0", VA = "0x187AC30B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7AC34C0", Offset = "0x7AC1EC0", VA = "0x187AC34C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3DE0", Offset = "0x7AC27E0", VA = "0x187AC3DE0")]
	[UnityEngine.Scripting.Preserve]
	public GPKMPFCLIKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3CB0", Offset = "0x7AC26B0", VA = "0x187AC3CB0")]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	internal static void NBDHNJGHJEB(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7AC39D0", Offset = "0x7AC23D0", VA = "0x187AC39D0")]
	internal static void LFPOILLCNJL(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2FE0", Offset = "0x7AC19E0", VA = "0x187AC2FE0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2ED0", Offset = "0x7AC18D0", VA = "0x187AC2ED0", Slot = "12")]
	[AsyncStateMachine(typeof(DEMOJCOBKCC))]
	public Task DBILOAODCDE(string LHGJDHICEOA, [Optional] DMGFFMKLNKM IOIPIHCJNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3A40", Offset = "0x7AC2440", VA = "0x187AC3A40", Slot = "19")]
	public Task LLDBCMGOFPJ(DMGFFMKLNKM IOIPIHCJNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3B90", Offset = "0x7AC2590", VA = "0x187AC3B90", Slot = "20")]
	public Task MIHNGOLNGOG(DMGFFMKLNKM IOIPIHCJNEI, Dictionary<string, string> EKIDNIPDIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3690", Offset = "0x7AC2090", VA = "0x187AC3690", Slot = "21")]
	public bool JJIMDPJGGLC(string HMLKLOAEPKP, bool AICMHMEGAAO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3360", Offset = "0x7AC1D60", VA = "0x187AC3360", Slot = "22")]
	public CLAAPMDPEND HAEHGDHJNKI(string BLMPIACOCIE, bool AICMHMEGAAO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3D20", Offset = "0x7AC2720", VA = "0x187AC3D20", Slot = "23")]
	public DAAAFPEPLKO OEKAOIOKKEE(string LLAHNKFCDCD, bool AICMHMEGAAO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2C10", Offset = "0x7AC1610", VA = "0x187AC2C10", Slot = "24")]
	public Task AMMNDEIHGDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7AC37B0", Offset = "0x7AC21B0", VA = "0x187AC37B0")]
	private static void JLECNPPDJOJ(TaskCompletionSource<bool> LMMMGOIHAIN, Task APGIAMGJAMO, Task OFKLLHDAPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2E00", Offset = "0x7AC1800", VA = "0x187AC2E00")]
	[AsyncStateMachine(typeof(LHHGFHHHHMC))]
	private static void BPMJAKGFBGA(Task HAAEKADIBMM, TaskCompletionSource<bool> LMMMGOIHAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xF04520", Offset = "0xF02F20", VA = "0x180F04520")]
	[CompilerGenerated]
	private void ONOGICLCNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xF70250", Offset = "0xF6EC50", VA = "0x180F70250")]
	[CompilerGenerated]
	private void CGIGOIMIKNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xD69270", Offset = "0xD67C70", VA = "0x180D69270")]
	[CompilerGenerated]
	private void PIFNGFKPAPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3B50", Offset = "0x7AC2550", VA = "0x187AC3B50")]
	[CompilerGenerated]
	private void MCJNEBLNDDG(LFDGPDCKKAM FGEFHKAEIPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class OADOPKEJMKN : DAAAFPEPLKO, EKIKOENLFCM
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate void JABCHMKFEFO(LFDGPDCKKAM IDPMGHAJNPH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly JABCHMKFEFO PEDGAFFNBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly DFBJCDALJEN JIBLEJCMCLP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string HMKINKIIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x56B4FE0", Offset = "0x56B39E0", VA = "0x1856B4FE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string JFJINPPGHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xE92430", Offset = "0xE90E30", VA = "0x180E92430", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C860", Offset = "0x6D0B260", VA = "0x186D0C860")]
	public OADOPKEJMKN(DFBJCDALJEN OLNBDAKOELL, [Optional] JABCHMKFEFO ONLJIGBEIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0960", Offset = "0x3BEF360", VA = "0x183BF0960", Slot = "6")]
	public T IBPMNADNGOO<T>(string KJNEHANBOBO, T ALKDPGOIFPD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface NJDMLNOMNDI
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[UsedImplicitly]
public class HCELOIAHABO : NJDMLNOMNDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly ILKGFNPPFKG HBAEDKFDAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly List<ABNHOMLPKAH> KMJFKFFFIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly string LKDDELBGDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly string BGEFIANOKBA;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3EA0", Offset = "0x7AC28A0", VA = "0x187AC3EA0")]
	[UsedImplicitly]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	internal static void FEDJMCICCOK(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3F10", Offset = "0x7AC2910", VA = "0x187AC3F10")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HCELOIAHABO([CNHMBDDCGKB(null)][JetBrains.Annotations.NotNull] ILKGFNPPFKG HBAEDKFDAHJ, [CNHMBDDCGKB(null)][JetBrains.Annotations.NotNull] KBGNCHIGCAH FLKCMDEJADO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class IOKHBBJHIDG : NDICJCLBPMH
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Task EGJJPDPBHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4B10", Offset = "0x7AC3510", VA = "0x187AC4B10", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task NLPGBFINLGD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5010", Offset = "0x7AC3A10", VA = "0x187AC5010", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool LBCNJLNDBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DLCICJFJEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string OAHKIDPJCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MPDBEIICAED IMLBNLBFDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action PJALLIPAGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4EC0", Offset = "0x7AC38C0", VA = "0x187AC4EC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5150", Offset = "0x7AC3B50", VA = "0x187AC5150", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action OGKDOFEJDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4D80", Offset = "0x7AC3780", VA = "0x187AC4D80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7AC51F0", Offset = "0x7AC3BF0", VA = "0x187AC51F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action FGELLCFNPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4E20", Offset = "0x7AC3820", VA = "0x187AC4E20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4C30", Offset = "0x7AC3630", VA = "0x187AC4C30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<LFDGPDCKKAM> NCGPDONGJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4CD0", Offset = "0x7AC36D0", VA = "0x187AC4CD0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC50A0", Offset = "0x7AC3AA0", VA = "0x187AC50A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IOKHBBJHIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4BA0", Offset = "0x7AC35A0", VA = "0x187AC4BA0", Slot = "12")]
	public Task DBILOAODCDE(string LHGJDHICEOA, [Optional] DMGFFMKLNKM IOIPIHCJNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7AC5290", Offset = "0x7AC3C90", VA = "0x187AC5290", Slot = "19")]
	public Task LLDBCMGOFPJ(DMGFFMKLNKM IOIPIHCJNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7AC5320", Offset = "0x7AC3D20", VA = "0x187AC5320", Slot = "20")]
	public Task MIHNGOLNGOG(DMGFFMKLNKM IOIPIHCJNEI, Dictionary<string, string> EKIDNIPDIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "21")]
	public bool JJIMDPJGGLC(string HMLKLOAEPKP, bool AICMHMEGAAO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4F60", Offset = "0x7AC3960", VA = "0x187AC4F60", Slot = "22")]
	public CLAAPMDPEND HAEHGDHJNKI(string BLMPIACOCIE, bool AICMHMEGAAO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7AC53B0", Offset = "0x7AC3DB0", VA = "0x187AC53B0", Slot = "23")]
	public DAAAFPEPLKO OEKAOIOKKEE(string LLAHNKFCDCD, bool AICMHMEGAAO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4A80", Offset = "0x7AC3480", VA = "0x187AC4A80", Slot = "24")]
	public Task AMMNDEIHGDJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class IOCJJABNGOD : MPDBEIICAED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly CNJDHJMFIBA AJOLAFFGGFD;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IReadOnlyDictionary<string, object> BOCMFHPFEEN
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xE91D30", Offset = "0xE90730", VA = "0x180E91D30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public IOCJJABNGOD(CNJDHJMFIBA KHMGNGOCEHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface JIANEMJCBME
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKELFEIGIPF NPDBLPDLBJO(string KNKPJNJBJOP);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface IECMHFBIMFA
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum NGMGLIOLJDP
	{
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	long JFMDNGJCMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string AEOJLJPIMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string KCOGNMGLFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool PLHPIKLDBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long CNLGIBBAKAL();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DAJIECDDBJI(long AFFBGADOFHN, bool OHLPCHMBOIP = true);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FHEPKNFFBGL(string GJIMIGJJJKI, string CONNOCAAAFH, string NIPONGFDCDI);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EBJDCKKMAGI(Guid HGGGPMHMEMG, Guid CCBJEGOAHFF, bool FLEONLDNKFL);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AOCBPPFJADP(string GJIMIGJJJKI);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BHEILODACHA(string GJIMIGJJJKI, string HHCDBLNAKIL, string CLKHJMDGJIB);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BEFNLONLGEL(string DCBDCJILPIG, object EBBDFFDGIBA, object GLDAHPBMBOC);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JDCKMBPLDNA(NGMGLIOLJDP KJFFPFDPPMP, int IHEMAOAJCIP, [Optional] JHOPIHFFCBF ODMAJCCOOBO, [Optional] string ENPFKABEICC, [Optional] string OLIGKIPGKGK);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BCJNOCPNNKN(JHOPIHFFCBF ODMAJCCOOBO, long NGJPAPPEECP, long CGNKOBHBDHA, int JEGBGAEBFKB, string ENPFKABEICC, int IHEMAOAJCIP);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CJMCPDHAKEH(JHOPIHFFCBF ODMAJCCOOBO, bool CACGHLMLDCI, [Optional] string OLIGKIPGKGK);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MNKKJOEJDCC(JHOPIHFFCBF ODMAJCCOOBO, bool CACGHLMLDCI, [Optional] string OLIGKIPGKGK);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IMIPCDNALLN(JHOPIHFFCBF ODMAJCCOOBO, bool CACGHLMLDCI, [Optional] string OLIGKIPGKGK);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GFIBGFBMMCL(long FHOIPEIAACP, string HCHHCDJGGDB);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface BOPNJHNPHMM
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string HELPNMNOCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
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
