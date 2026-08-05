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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x606ECC0", Offset = "0x606E0C0", VA = "0x18606ECC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E85A0", Offset = "0x7E79A0", VA = "0x1807E85A0")]
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
		public AmplitudeAnalyticsClient.Settings JKBGCMIFPHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ICGDAPIMCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7C4670", Offset = "0x7C3A70", VA = "0x1807C4670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum FBGIJGBHKLF
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class HGKDEPGDDHF
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class FPEMGJGHFFB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int LIPLHJLCDJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> CNBGNKMFGOK;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
				public FPEMGJGHFFB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class NJHDMOPADMO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
				public NJHDMOPADMO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x606D8B0", Offset = "0x606CCB0", VA = "0x18606D8B0")]
				internal bool OPMBGDFDGCJ(FPEMGJGHFFB item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string JHPDPCCKEEN = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string GBHBCPBCKNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<FPEMGJGHFFB> HLMHGHMKDCN;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? CLPIHKOCOHL
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x606A2D0", Offset = "0x60696D0", VA = "0x18606A2D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x606B590", Offset = "0x606A990", VA = "0x18606B590")]
			internal HGKDEPGDDHF(string AJMNACNODGH, string LAGBPJBMLHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x606A5B0", Offset = "0x60699B0", VA = "0x18606A5B0")]
			public int FFMEOCLDJJP([Optional] int? AGJCHDHBBBA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x606A9B0", Offset = "0x6069DB0", VA = "0x18606A9B0")]
			public List<Dictionary<string, object>> HFOMKADMKOP(int OEBDBJPNJKP, int? AGJCHDHBBBA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x606B360", Offset = "0x606A760", VA = "0x18606B360")]
			public void NDKCMCPIOMB(AmplitudeAnalyticsIdentifyMessage LIKEKIACGIL, bool PCJCEDIGMIG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x606B250", Offset = "0x606A650", VA = "0x18606B250")]
			public void NDKCMCPIOMB(Dictionary<string, object> LIKEKIACGIL, bool PCJCEDIGMIG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x606B400", Offset = "0x606A800", VA = "0x18606B400")]
			public void PJIKDEPNHHD(params Dictionary<string, object>[] HHGNJMHJBLF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x606A760", Offset = "0x6069B60", VA = "0x18606A760")]
			public void GOCLFGFGGIM(List<Dictionary<string, object>> LCDCLFAAHOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x606AC20", Offset = "0x606A020", VA = "0x18606AC20")]
			private void HOFIPJPDOKI(Dictionary<string, object> LIKEKIACGIL, bool PCJCEDIGMIG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x606A370", Offset = "0x6069770", VA = "0x18606A370")]
			public void EHBLJPHECBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x606AD30", Offset = "0x606A130", VA = "0x18606AD30")]
			private void IFPHHMMIPGD([Optional] string BPHPCMABALK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x606B120", Offset = "0x606A520", VA = "0x18606B120")]
			private static string NDDOMFKMIJC(string PCGOHCLJAPN, string NIOPCMHKLMB)
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
			[Cpp2IlInjected.Address(RVA = "0x606F660", Offset = "0x606EA60", VA = "0x18606F660")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct EPMFHLLOLJH<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int POJGPIMDLJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string GBMMHBEGDNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T GGNPBGJKJAK;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HMOIGBPIHAE : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private KIBBKCLDIIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
			[DebuggerHidden]
			public HMOIGBPIHAE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x606B930", Offset = "0x606AD30", VA = "0x18606B930", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x606C0F0", Offset = "0x606B4F0", VA = "0x18606C0F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MPLADEOIIIB : IEnumerator<object>, IEnumerator, IDisposable
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
			public IBOPGHHDJFG quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
			[DebuggerHidden]
			public MPLADEOIIIB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x606D750", Offset = "0x606CB50", VA = "0x18606D750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x606D860", Offset = "0x606CC60", VA = "0x18606D860", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JHHPKLMFGDM : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
			[DebuggerHidden]
			public JHHPKLMFGDM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x606C3B0", Offset = "0x606B7B0", VA = "0x18606C3B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x606C520", Offset = "0x606B920", VA = "0x18606C520", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class OAAGIEBOIKG : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private KIBBKCLDIIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
			[DebuggerHidden]
			public OAAGIEBOIKG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x606ED40", Offset = "0x606E140", VA = "0x18606ED40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x606EFC0", Offset = "0x606E3C0", VA = "0x18606EFC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class PLHLLJGHOPB : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private KIBBKCLDIIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
			[DebuggerHidden]
			public PLHLLJGHOPB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x606F010", Offset = "0x606E410", VA = "0x18606F010", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x606F2A0", Offset = "0x606E6A0", VA = "0x18606F2A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CMBHJFNLCAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public HGKDEPGDDHF cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public CMBHJFNLCAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x60659F0", Offset = "0x6064DF0", VA = "0x1860659F0")]
			internal void FOICKFPHNFF(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6065D10", Offset = "0x6065110", VA = "0x186065D10")]
			internal void NBINAFKHPBH(EPMFHLLOLJH<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class KGBCLKBEHNC : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private KIBBKCLDIIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public HGKDEPGDDHF cache;

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
			private CMBHJFNLCAI <>8__1;

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
			private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
			[DebuggerHidden]
			public KGBCLKBEHNC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x606C570", Offset = "0x606B970", VA = "0x18606C570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x606CE20", Offset = "0x606C220", VA = "0x18606CE20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class MNAGFFGBPHB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public MNAGFFGBPHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x36AD9F0", Offset = "0x36ACDF0", VA = "0x1836AD9F0")]
			internal EPMFHLLOLJH<T> BLJPFKIDNID(CMJFOJCBEAN postResponse)
			{
				return default(EPMFHLLOLJH<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class FBEENHDFGNE<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public FBEENHDFGNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x36AD9F0", Offset = "0x36ACDF0", VA = "0x1836AD9F0")]
			internal EPMFHLLOLJH<T> MKPNKLPENPM(CMJFOJCBEAN postResponse)
			{
				return default(EPMFHLLOLJH<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private CBMBIENNKDO MGOCJHEKPPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<JEDJMCAIPEB> CLLEEBKCIIO;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string CGFCCMACEMG = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string LGMBNEOPJPC = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string OAELMGMHPPJ = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int OANKGBDIABG = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int BKPHDNCILJN = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int ENKCDOAIBBJ = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float KIGAHEPJAHB = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long KKOLEEMLBLN = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string KNDADJOOAPN = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string DKAGLBLGPON = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool FFKOMJPNOFC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool OKKKIIGEOBN;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int MNHJLBHBGNO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int NOOJLBFMJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private IMCJJMCMBNK AONFNIHJOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private BJBGDIGAMBP MDFANGJCFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private BGFFNAAGJNJ CHPEOODHAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool CDLMKLBLNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float NMKONGNEEJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float LCNLEKINJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int CKNFNOGFILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int GPPHGHDNKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? HLLOGHNBHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? HLAJKPIKELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long DHINNLONMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string MHJFJKADHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool CIMFBFFBHFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long NBDMICPBLBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string LFPIEJHGEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string DHPEPIAJAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> DBDBCDEOPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private FBGIJGBHKLF JAHPKICMDNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int FBHPCIHKPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int HHPKMGLEHEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float FLCLHPJGMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool GNANAPGANBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool FOHNHPOFDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private HGKDEPGDDHF ADPHAECPBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private HGKDEPGDDHF OAOCJPIBHHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private HGKDEPGDDHF IHCCLFFHBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> IFNKMBCIMDB;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo CIHJJOIEGLA;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string NHNMAPDANKI;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string OHPALMPMMKP = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string HEIPDCJDDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string FHKFPEIKLBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string OJJBHOCMJGM;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private CBMBIENNKDO CNBEMDBONHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6062000", Offset = "0x6061400", VA = "0x186062000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private JEDJMCAIPEB LBLIEPCPEJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x605E4E0", Offset = "0x605D8E0", VA = "0x18605E4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int EHLKPDGKJIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x60612C0", Offset = "0x60606C0", VA = "0x1860612C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long NJKHMLBJNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6063A10", Offset = "0x6062E10", VA = "0x186063A10")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6063B30", Offset = "0x6062F30", VA = "0x186063B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string JFNDBANIODE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x60639B0", Offset = "0x6062DB0", VA = "0x1860639B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string JBEKFCCBINB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x60639E0", Offset = "0x6062DE0", VA = "0x1860639E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NBKBKOPOHGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8E1790", Offset = "0x8E0B90", VA = "0x1808E1790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8E1760", Offset = "0x8E0B60", VA = "0x1808E1760")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? AOCDLJNLMOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x907D80", Offset = "0x907180", VA = "0x180907D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6063B20", Offset = "0x6062F20", VA = "0x186063B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MHOHDKPIMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xFDFF40", Offset = "0xFDF340", VA = "0x180FDFF40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xFDEF80", Offset = "0xFDE380", VA = "0x180FDEF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool GNHMJCFAEBG
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x60638B0", Offset = "0x6062CB0", VA = "0x1860638B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> IICIPFHNHNL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x60637F0", Offset = "0x6062BF0", VA = "0x1860637F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6063A60", Offset = "0x6062E60", VA = "0x186063A60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x605DFE0", Offset = "0x605D3E0", VA = "0x18605DFE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x605E7E0", Offset = "0x605DBE0", VA = "0x18605E7E0")]
		private void DMKMNKCBNLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6062DD0", Offset = "0x60621D0", VA = "0x186062DD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60614A0", Offset = "0x60608A0", VA = "0x1860614A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6063170", Offset = "0x6062570", VA = "0x186063170")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6062070", Offset = "0x6061470", VA = "0x186062070")]
		public PEMLHLMJEJH PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x605F890", Offset = "0x605EC90", VA = "0x18605F890")]
		[IteratorStateMachine(typeof(HMOIGBPIHAE))]
		public IEnumerator<KIBBKCLDIIA> Initialize(AmplitudeAnalyticsEvent BEOLFCLFCOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x60630B0", Offset = "0x60624B0", VA = "0x1860630B0")]
		public void UpdateLastKnownInteractionCategory(string ALLMIFIMKHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6062FC0", Offset = "0x60623C0", VA = "0x186062FC0")]
		public void UpdateLastAliveTime(float MEOLIKAEACM = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x605F920", Offset = "0x605ED20", VA = "0x18605F920")]
		private PEMLHLMJEJH JIEFDJFPOCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6060740", Offset = "0x605FB40", VA = "0x186060740")]
		private PEMLHLMJEJH KKIPKAJFEDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6062820", Offset = "0x6061C20", VA = "0x186062820")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x605F370", Offset = "0x605E770", VA = "0x18605F370")]
		[IteratorStateMachine(typeof(MPLADEOIIIB))]
		private IEnumerator HPHJBCMLJCF(IBOPGHHDJFG DPGGEOGLDJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6063400", Offset = "0x6062800", VA = "0x186063400")]
		[IteratorStateMachine(typeof(JHHPKLMFGDM))]
		public IEnumerator WaitForFlush(float KCLHELHGLEJ = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6062EA0", Offset = "0x60622A0", VA = "0x186062EA0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6062DE0", Offset = "0x60621E0", VA = "0x186062DE0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime BBPLEPJCAHF)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x605F400", Offset = "0x605E800", VA = "0x18605F400")]
		public static MLLBBLKBBED Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x605DE70", Offset = "0x605D270", VA = "0x18605DE70")]
		public static EFOJBJONOOM AccountSelectionPostLoginEvent([NotNull] string CGFCNIELFHI, string CIKIAALPDMP, bool PHAGDHCKLBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x605EEE0", Offset = "0x605E2E0", VA = "0x18605EEE0")]
		public static EFOJBJONOOM Event([NotNull] string CGFCNIELFHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x60620B0", Offset = "0x60614B0", VA = "0x1860620B0")]
		public static EFOJBJONOOM PreviousSessionEvent([NotNull] string CGFCNIELFHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x605F5B0", Offset = "0x605E9B0", VA = "0x18605F5B0")]
		public static EFOJBJONOOM InitializeEvent(string CIKIAALPDMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60629E0", Offset = "0x6061DE0", VA = "0x1860629E0")]
		public static EFOJBJONOOM StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x605E530", Offset = "0x605D930", VA = "0x18605E530")]
		public static EFOJBJONOOM CreateOutOfSessionEvent(string CGFCNIELFHI, bool FGHGMLECANF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6060DB0", Offset = "0x60601B0", VA = "0x186060DB0")]
		public static PEMLHLMJEJH LogOutOfSessionEvent(EFOJBJONOOM IPOAADHENPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6060B30", Offset = "0x605FF30", VA = "0x186060B30")]
		public void LogEventAsync(AmplitudeAnalyticsEvent CCJCHIBELCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x60610A0", Offset = "0x60604A0", VA = "0x1860610A0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent CCJCHIBELCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x60611E0", Offset = "0x60605E0", VA = "0x1860611E0")]
		public void LogSerializedEventAsync(Dictionary<string, object> ADFDCOCLCCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6060C70", Offset = "0x6060070", VA = "0x186060C70")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage FNLIGPMHNFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6060A30", Offset = "0x605FE30", VA = "0x186060A30")]
		private void LJGJGMFAHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6061830", Offset = "0x6060C30", VA = "0x186061830")]
		private void PKAMJAEIIDK(Dictionary<string, object> MLLOCGHENMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6061560", Offset = "0x6060960", VA = "0x186061560")]
		private void PEGBLNGPDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6061650", Offset = "0x6060A50", VA = "0x186061650")]
		private void PFDDECIHACP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x605F1E0", Offset = "0x605E5E0", VA = "0x18605F1E0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x60606B0", Offset = "0x605FAB0", VA = "0x1860606B0")]
		[IteratorStateMachine(typeof(OAAGIEBOIKG))]
		private IEnumerator<KIBBKCLDIIA> JKJOBAJNNIJ(float KCLHELHGLEJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x605E450", Offset = "0x605D850", VA = "0x18605E450")]
		[IteratorStateMachine(typeof(PLHLLJGHOPB))]
		private IEnumerator<KIBBKCLDIIA> CFJDJMMEKDE(float KCLHELHGLEJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x605F270", Offset = "0x605E670", VA = "0x18605F270")]
		[IteratorStateMachine(typeof(KGBCLKBEHNC))]
		private IEnumerator<KIBBKCLDIIA> HHBFLJLIIGA(HGKDEPGDDHF PNLGEMHJHFP, int? AGJCHDHBBBA, string EIMOCFCDONJ, string FKJJDNJDILF, float KCLHELHGLEJ, Action<int> FLNGLBAIKAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6061AE0", Offset = "0x6060EE0", VA = "0x186061AE0")]
		private static void PKHIMJCCDBM(bool ELJNGIIMJGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6061ED0", Offset = "0x60612D0", VA = "0x186061ED0")]
		private JNFFOANFOAP<EPMFHLLOLJH<Dictionary<string, object>>> PMBPKGADDMA(string EIMOCFCDONJ, string FKJJDNJDILF, string EBPDAPFEMBK, string IHEFOKMLLHB, Dictionary<string, object> GGNPBGJKJAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6061BF0", Offset = "0x6060FF0", VA = "0x186061BF0")]
		private JNFFOANFOAP<EPMFHLLOLJH<List<Dictionary<string, object>>>> PMBPKGADDMA(string EIMOCFCDONJ, string FKJJDNJDILF, string EBPDAPFEMBK, string IHEFOKMLLHB, List<Dictionary<string, object>> GGNPBGJKJAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA230", Offset = "0x2DD9630", VA = "0x182DDA230")]
		private JNFFOANFOAP<EPMFHLLOLJH<T>> APECDKJMLPC<T>(string EIMOCFCDONJ, string FKJJDNJDILF, string IHEFOKMLLHB, T GGNPBGJKJAK, Dictionary<string, object> AMMCIPEIGOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA4F0", Offset = "0x2DD98F0", VA = "0x182DDA4F0")]
		private JNFFOANFOAP<EPMFHLLOLJH<T>> IPHCJJIFDLB<T>(string EIMOCFCDONJ, string FKJJDNJDILF, string EBPDAPFEMBK, T GGNPBGJKJAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x605E790", Offset = "0x605DB90", VA = "0x18605E790")]
		private bool DCLGMKDKHDF(float DFBILAELKII, float KCLHELHGLEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x605F9E0", Offset = "0x605EDE0", VA = "0x18605F9E0")]
		private Dictionary<string, object> JIFNODKIFJM(string FKJJDNJDILF, Dictionary<string, object> GGNPBGJKJAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60634F0", Offset = "0x60628F0", VA = "0x1860634F0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x605ED80", Offset = "0x605E180", VA = "0x18605ED80")]
		[CompilerGenerated]
		private long EPLMKIECEMG()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6061820", Offset = "0x6060C20", VA = "0x186061820")]
		[CompilerGenerated]
		private void PGDLCAJPOML(int LHJLAFIGGHO)
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
			[Cpp2IlInjected.Address(RVA = "0x6064890", Offset = "0x6063C90", VA = "0x186064890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6064970", Offset = "0x6063D70", VA = "0x186064970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x60648D0", Offset = "0x6063CD0", VA = "0x1860648D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x60649D0", Offset = "0x6063DD0", VA = "0x1860649D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6064850", Offset = "0x6063C50", VA = "0x186064850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6064910", Offset = "0x6063D10", VA = "0x186064910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7C3CC0", Offset = "0x7C30C0", VA = "0x1807C3CC0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6064330", Offset = "0x6063730", VA = "0x186064330")]
		public static EFOJBJONOOM HEJOOLMEDMH(string PAKIAOEKDPK, [NotNull] string BJGELIIILMO, long FCEEEFBGJPN, long BEBIBDLAFOF, string CIKIAALPDMP, bool PHAGDHCKLBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x60641D0", Offset = "0x60635D0", VA = "0x1860641D0")]
		public static EFOJBJONOOM GOIPPOHMFCM(string PAKIAOEKDPK, [NotNull] string BJGELIIILMO, long FCEEEFBGJPN, long BEBIBDLAFOF, string CIKIAALPDMP, long KJCANLIJNFC, bool PHAGDHCKLBB, string OIKJLEDDIOI, string HDEBGJLMAKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x60646C0", Offset = "0x6063AC0", VA = "0x1860646C0")]
		private AmplitudeAnalyticsEvent(string PAKIAOEKDPK, [NotNull] string BJGELIIILMO, long FCEEEFBGJPN, long BEBIBDLAFOF, string CIKIAALPDMP, bool PHAGDHCKLBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1AB6760", Offset = "0x1AB5B60", VA = "0x181AB6760")]
		public void ALMGFODLMJB(long GHPLAKMCBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x60645B0", Offset = "0x60639B0", VA = "0x1860645B0", Slot = "5")]
		public override void NJPFOPFBELB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6064430", Offset = "0x6063830", VA = "0x186064430", Slot = "6")]
		public override void KPKNEKKBHKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6063B90", Offset = "0x6062F90", VA = "0x186063B90", Slot = "4")]
		protected override Dictionary<string, object> CIBDLOLMOIG(Dictionary<string, object> HEHBILDONMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x60640C0", Offset = "0x60634C0", VA = "0x1860640C0")]
		private void FENLPOOENIB(string NIOPCMHKLMB, string PCGOHCLJAPN, bool PDJMOBONFJM = false)
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
			[Cpp2IlInjected.Address(RVA = "0x60669F0", Offset = "0x6065DF0", VA = "0x1860669F0")]
			public void CIHALGMLILP(Dictionary<string, object> OKLCCGCIAFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
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
			[Cpp2IlInjected.Address(RVA = "0x606F2F0", Offset = "0x606E6F0", VA = "0x18606F2F0")]
			public void CIHALGMLILP(Dictionary<string, object> KKFFGKHENPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x946060", Offset = "0x945460", VA = "0x180946060")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6064DE0", Offset = "0x60641E0", VA = "0x186064DE0")]
		public static MLLBBLKBBED HEJOOLMEDMH(string PAKIAOEKDPK, string CIKIAALPDMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x60650F0", Offset = "0x60644F0", VA = "0x1860650F0")]
		protected AmplitudeAnalyticsIdentifyMessage(string PAKIAOEKDPK, string CIKIAALPDMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6064F30", Offset = "0x6064330", VA = "0x186064F30")]
		public Dictionary<string, object> MEBEINJHEPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6064A30", Offset = "0x6063E30", VA = "0x186064A30", Slot = "4")]
		protected virtual Dictionary<string, object> CIBDLOLMOIG(Dictionary<string, object> HEHBILDONMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6065050", Offset = "0x6064450", VA = "0x186065050")]
		protected void OJDEFOPHFNE(string NIOPCMHKLMB, Dictionary<string, object> IAMJEKBLBCG, Dictionary<string, object> JHLOPGBMGDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6064D70", Offset = "0x6064170", VA = "0x186064D70")]
		protected void FDPNOPNFGOM(string NIOPCMHKLMB, string PCGOHCLJAPN, Dictionary<string, object> GCKEABHOMIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6064FC0", Offset = "0x60643C0", VA = "0x186064FC0", Slot = "5")]
		public virtual void NJPFOPFBELB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6064EA0", Offset = "0x60642A0", VA = "0x186064EA0", Slot = "6")]
		public virtual void KPKNEKKBHKL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MLLBBLKBBED : PMDGDFOBGED<AmplitudeAnalyticsIdentifyMessage, MLLBBLKBBED>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override MLLBBLKBBED GGMFPNCKHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage KCMMFHCANCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x606D2D0", Offset = "0x606C6D0", VA = "0x18606D2D0")]
	public MLLBBLKBBED(AmplitudeAnalyticsIdentifyMessage JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x606D220", Offset = "0x606C620", VA = "0x18606D220", Slot = "4")]
	public override void KPKNEKKBHKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EFOJBJONOOM : PMDGDFOBGED<AmplitudeAnalyticsEvent, EFOJBJONOOM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool HPINFIMDHFE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override EFOJBJONOOM GGMFPNCKHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long KMJKIEJJPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6066D00", Offset = "0x6066100", VA = "0x186066D00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6066EF0", Offset = "0x60662F0", VA = "0x186066EF0")]
	public EFOJBJONOOM(AmplitudeAnalyticsEvent JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "5")]
	public override AmplitudeAnalyticsEvent KCMMFHCANCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6066D20", Offset = "0x6066120", VA = "0x186066D20", Slot = "4")]
	public override void KPKNEKKBHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2688820", Offset = "0x2687C20", VA = "0x182688820")]
	public EFOJBJONOOM FNBEEJBOJOD<T>(string KENAPEDMLDN, T[] PCGOHCLJAPN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2688820", Offset = "0x2687C20", VA = "0x182688820")]
	public EFOJBJONOOM FNBEEJBOJOD(string KENAPEDMLDN, string[] PCGOHCLJAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2688570", Offset = "0x2687970", VA = "0x182688570")]
	public EFOJBJONOOM FNBEEJBOJOD<T>(string KENAPEDMLDN, T PCGOHCLJAPN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6066C80", Offset = "0x6066080", VA = "0x186066C80")]
	public EFOJBJONOOM FNBEEJBOJOD(string KENAPEDMLDN, long PCGOHCLJAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6066C10", Offset = "0x6066010", VA = "0x186066C10")]
	public EFOJBJONOOM FNBEEJBOJOD(string KENAPEDMLDN, string PCGOHCLJAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6066DC0", Offset = "0x60661C0", VA = "0x186066DC0")]
	public EFOJBJONOOM NOCBJLBLFGI(string KENAPEDMLDN, object? PCGOHCLJAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6066B70", Offset = "0x6065F70", VA = "0x186066B70")]
	public EFOJBJONOOM DEDFAPDBPBM(string KENAPEDMLDN, string PCGOHCLJAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6066DF0", Offset = "0x60661F0", VA = "0x186066DF0")]
	private EFOJBJONOOM PCJNIIDIFEE(string KENAPEDMLDN, object PCGOHCLJAPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HMDGAACNMMN : EFOJBJONOOM
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6066EF0", Offset = "0x60662F0", VA = "0x186066EF0")]
	public HMDGAACNMMN(AmplitudeAnalyticsEvent JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x606B780", Offset = "0x606AB80", VA = "0x18606B780", Slot = "4")]
	public override void KPKNEKKBHKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class PMDGDFOBGED<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : PMDGDFOBGED<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M JEBCFBFPEMG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR GGMFPNCKHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public PMDGDFOBGED(M JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x41B6880", Offset = "0x41B5C80", VA = "0x1841B6880")]
	public BLDR DIOFKDKEJDH(AmplitudeAnalyticsIdentifyMessage.DeviceInfo ICLGKPEGMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x41B6800", Offset = "0x41B5C00", VA = "0x1841B6800")]
	public BLDR AEIJLBHGBIE(AmplitudeAnalyticsIdentifyMessage.RevenueData BADJOILIPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x41B69D0", Offset = "0x41B5DD0", VA = "0x1841B69D0")]
	public BLDR IPOOOPENPOD(string KENAPEDMLDN, string PCGOHCLJAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2728D20", Offset = "0x2728120", VA = "0x182728D20")]
	public BLDR IPOOOPENPOD<T>(string KENAPEDMLDN, T PCGOHCLJAPN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KPKNEKKBHKL();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x41B6850", Offset = "0x41B5C50", VA = "0x1841B6850")]
	internal static string CIPIFFKPIKD(string PCGOHCLJAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x41B68D0", Offset = "0x41B5CD0", VA = "0x1841B68D0")]
	private BLDR DJFJMEAAIDB(string KENAPEDMLDN, object PCGOHCLJAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M KCMMFHCANCI();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class MLJBGOEIPFO : IMCJJMCMBNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct FINDCJIBGAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<CMJFOJCBEAN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public MLJBGOEIPFO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x60672B0", Offset = "0x60666B0", VA = "0x1860672B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6067B50", Offset = "0x6066F50", VA = "0x186067B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct GBCBANBNLAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<CMJFOJCBEAN> <>t__builder;

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
		public MLJBGOEIPFO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x60697E0", Offset = "0x6068BE0", VA = "0x1860697E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x606A210", Offset = "0x6069610", VA = "0x18606A210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient BBHGBGIKDKI;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x606CFE0", Offset = "0x606C3E0", VA = "0x18606CFE0")]
	[AMCIKKJLCIB(HENHDGEOMOC.None)]
	private static void NGOHCHKMGPP(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x606D1A0", Offset = "0x606C5A0", VA = "0x18606D1A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MLJBGOEIPFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x606D050", Offset = "0x606C450", VA = "0x18606D050", Slot = "4")]
	[AsyncStateMachine(typeof(FINDCJIBGAK))]
	public Task<CMJFOJCBEAN> PMBPKGADDMA(string EIMOCFCDONJ, Dictionary<string, string> LGGCDCBAGLN, bool OBEBCOPNGOC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x606CE70", Offset = "0x606C270", VA = "0x18606CE70", Slot = "5")]
	[AsyncStateMachine(typeof(GBCBANBNLAH))]
	public Task<CMJFOJCBEAN> DHBJAEFFLKB(string EIMOCFCDONJ, string MKBGJOINFOJ, string KBPAGEDKPOB, string MOBLCPFBHPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EJCLFMLBBAH
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> JABPGCHLNND;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6066F40", Offset = "0x6066340", VA = "0x186066F40")]
	internal static bool KPKJENLEBKN(string NIOPCMHKLMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface IMCJJMCMBNK
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CMJFOJCBEAN> PMBPKGADDMA(string EIMOCFCDONJ, Dictionary<string, string> LGGCDCBAGLN, bool OBEBCOPNGOC = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CMJFOJCBEAN> DHBJAEFFLKB(string EIMOCFCDONJ, string MKBGJOINFOJ, string KBPAGEDKPOB, string MOBLCPFBHPN);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct CMJFOJCBEAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int APMPOLLGHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string OOABKBNJCOM;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xC40350", Offset = "0xC3F750", VA = "0x180C40350")]
	public CMJFOJCBEAN(int POJGPIMDLJN, string GBMMHBEGDNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum CMBFACAHKIL
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
public class NJLMNKMOHJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long DHOBBJBIHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private EFOJBJONOOM CGPDHIPNOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool HJINLAAAMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float EBCGJEBBBNN;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x606EB30", Offset = "0x606DF30", VA = "0x18606EB30")]
	public NJLMNKMOHJG(string CAHFIFPIFGK, float EBCGJEBBBNN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2922D40", Offset = "0x2922140", VA = "0x182922D40")]
	public void FNBEEJBOJOD<T>(string KENAPEDMLDN, T PCGOHCLJAPN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x606E9F0", Offset = "0x606DDF0", VA = "0x18606E9F0")]
	public void FNBEEJBOJOD(string KENAPEDMLDN, string PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x606E7A0", Offset = "0x606DBA0", VA = "0x18606E7A0")]
	public void BEBNBEFLOJD(string JHKEPMOLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x606EA70", Offset = "0x606DE70", VA = "0x18606EA70")]
	public void GHMFCJNINJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x606E8E0", Offset = "0x606DCE0", VA = "0x18606E8E0")]
	private void FFILMMLCGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x606E890", Offset = "0x606DC90", VA = "0x18606E890")]
	private bool CHDCIKOBHHJ()
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
		public enum CMGBDFHOHGJ
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
		private CMGBDFHOHGJ parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CMGBDFHOHGJ Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x968FB0", Offset = "0x9683B0", VA = "0x180968FB0")]
			get
			{
				return default(CMGBDFHOHGJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8854D0", Offset = "0x8848D0", VA = "0x1808854D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x606F460", Offset = "0x606E860", VA = "0x18606F460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class BCKGHMCIAGE : FNAKILAICEA, DGLLGPNMIPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly IPJKLBONPMF BJEGCIKNDCA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string GHGIGKDAOGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x10983D0", Offset = "0x10977D0", VA = "0x1810983D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool AKECCMGPKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x60651B0", Offset = "0x60645B0", VA = "0x1860651B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool JFFNCOHPNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x60651D0", Offset = "0x60645D0", VA = "0x1860651D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> CDFBPLHAALE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1098220", Offset = "0x1097620", VA = "0x181098220", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public BCKGHMCIAGE(IPJKLBONPMF GLPHPNDFKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2597240", Offset = "0x2596640", VA = "0x182597240", Slot = "8")]
	public T EBLDKANKNCA<T>(string NIOPCMHKLMB, T DADBDDPBLHB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class FPIKPCNIFAO : AJLEJELNGKA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct CKPIFGMFIIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public FPIKPCNIFAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public BJBGDIGAMBP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6065510", Offset = "0x6064910", VA = "0x186065510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6065990", Offset = "0x6064D90", VA = "0x186065990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct IOIDKNINNOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x606C140", Offset = "0x606B540", VA = "0x18606C140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x606C350", Offset = "0x606B750", VA = "0x18606C350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct CDGCGANEOKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public FPIKPCNIFAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public BJBGDIGAMBP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x60651F0", Offset = "0x60645F0", VA = "0x1860651F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x60654B0", Offset = "0x60648B0", VA = "0x1860654B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct MMOMGDDFCDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public FPIKPCNIFAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public BJBGDIGAMBP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x606D320", Offset = "0x606C720", VA = "0x18606D320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x606D6F0", Offset = "0x606CAF0", VA = "0x18606D6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class GEALBHHBLFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public FPIKPCNIFAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public ILDECEHCHLP layer;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public GEALBHHBLFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x606A280", Offset = "0x6069680", VA = "0x18606A280")]
		internal void GGANMJNPGBE(string key)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly IReadOnlyDictionary<string, OACGNEJBMHM> PMEDEAJEHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool HIECCLPEMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private LCLKAEPEGIP BDALBPDADIL;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool PEJFPPKJLCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x811020", Offset = "0x810420", VA = "0x180811020", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string NBKBKOPOHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6067F40", Offset = "0x6067340", VA = "0x186067F40", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LCLIMPMHKNO DCEEAPADDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6067BC0", Offset = "0x6066FC0", VA = "0x186067BC0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FFDGONEGFEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6067E20", Offset = "0x6067220", VA = "0x186067E20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60685A0", Offset = "0x60679A0", VA = "0x1860685A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JKEKAFLJBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6068500", Offset = "0x6067900", VA = "0x186068500", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6068640", Offset = "0x6067A40", VA = "0x186068640", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<string, string> JOKLMLJIMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6069490", Offset = "0x6068890", VA = "0x186069490", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60695F0", Offset = "0x60689F0", VA = "0x1860695F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<string> NPAKPOLCHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x60692D0", Offset = "0x60686D0", VA = "0x1860692D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x60687F0", Offset = "0x6067BF0", VA = "0x1860687F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6068210", Offset = "0x6067610", VA = "0x186068210", Slot = "12")]
	[AsyncStateMachine(typeof(CKPIFGMFIIG))]
	public Task EOPEJCOCBHD(string ALDMOBLOJMP, string LAGBPJBMLHD, [Optional] BJBGDIGAMBP JAPIGMAKNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6069540", Offset = "0x6068940", VA = "0x186069540", Slot = "21")]
	[AsyncStateMachine(typeof(IOIDKNINNOH))]
	public Task PNHIHLJPELJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6067F50", Offset = "0x6067350", VA = "0x186067F50", Slot = "16")]
	[AsyncStateMachine(typeof(CDGCGANEOKB))]
	public Task EFNBJDLFHKK(BJBGDIGAMBP JAPIGMAKNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x60686E0", Offset = "0x6067AE0", VA = "0x1860686E0", Slot = "17")]
	[AsyncStateMachine(typeof(MMOMGDDFCDO))]
	public Task HPEOHLIBDNM(BJBGDIGAMBP JAPIGMAKNLK, Dictionary<string, string> INICGJEIMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6068930", Offset = "0x6067D30", VA = "0x186068930", Slot = "18")]
	public bool LHODJANEGLD(string AIBKDIKNMOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6067EC0", Offset = "0x60672C0", VA = "0x186067EC0", Slot = "19")]
	public FNAKILAICEA BFAEOLBLOMO(string KHJICJCPGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6068040", Offset = "0x6067440", VA = "0x186068040")]
	private IPJKLBONPMF EKEODOHDFHD(string KHJICJCPGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6067C60", Offset = "0x6067060", VA = "0x186067C60", Slot = "20")]
	public JKMPGPGDADE AMIJHOAKLAP(string KKNANIMPCHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x13F9840", Offset = "0x13F8C40", VA = "0x1813F9840")]
	private void MPOFGPIJIFO(string KKNANIMPCHI, string DDBJBELNPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x60688A0", Offset = "0x6067CA0", VA = "0x1860688A0")]
	private ILDECEHCHLP KIOOMJAEAJL(string KKNANIMPCHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x60689C0", Offset = "0x6067DC0", VA = "0x1860689C0")]
	private PBDEABEFAEC MOIOKLAKFJH(BJBGDIGAMBP JAPIGMAKNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6068350", Offset = "0x6067750", VA = "0x186068350")]
	private CEEEAJONGCJ EPJCHIILPJA(string LAGBPJBMLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6069380", Offset = "0x6068780", VA = "0x186069380")]
	private void PAOADFNCGEF(string KHJICJCPGMG, IPJKLBONPMF GLPHPNDFKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public FPIKPCNIFAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class NJHMJCLLDFF : AJLEJELNGKA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct AHPGNNAFMGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public NJHMJCLLDFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public BJBGDIGAMBP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x605D5C0", Offset = "0x605C9C0", VA = "0x18605D5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x605DE10", Offset = "0x605D210", VA = "0x18605DE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private AJLEJELNGKA LNPNGAPAIDA;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private AJLEJELNGKA KICPMODEHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x606E4C0", Offset = "0x606D8C0", VA = "0x18606E4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PEJFPPKJLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x606DF60", Offset = "0x606D360", VA = "0x18606DF60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string NBKBKOPOHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x606DC50", Offset = "0x606D050", VA = "0x18606DC50", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public LCLIMPMHKNO DCEEAPADDMB
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x606D920", Offset = "0x606CD20", VA = "0x18606D920", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action FFDGONEGFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x606DB00", Offset = "0x606CF00", VA = "0x18606DB00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x606E050", Offset = "0x606D450", VA = "0x18606E050", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action JKEKAFLJBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x606DFB0", Offset = "0x606D3B0", VA = "0x18606DFB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x606E0F0", Offset = "0x606D4F0", VA = "0x18606E0F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<string> NPAKPOLCHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x606E410", Offset = "0x606D810", VA = "0x18606E410", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x606E2B0", Offset = "0x606D6B0", VA = "0x18606E2B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<string, string> JOKLMLJIMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x606E530", Offset = "0x606D930", VA = "0x18606E530", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x606E6F0", Offset = "0x606DAF0", VA = "0x18606E6F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	[UnityEngine.Scripting.Preserve]
	public NJHMJCLLDFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x606DEF0", Offset = "0x606D2F0", VA = "0x18606DEF0")]
	[AMCIKKJLCIB(HENHDGEOMOC.GameOnly)]
	private static void EPIAPJMNNFJ(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x606DA90", Offset = "0x606CE90", VA = "0x18606DA90")]
	[AMCIKKJLCIB(HENHDGEOMOC.EditorOnly)]
	private static void BAPAEPMGIGF(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x606DDB0", Offset = "0x606D1B0", VA = "0x18606DDB0", Slot = "12")]
	[AsyncStateMachine(typeof(AHPGNNAFMGN))]
	public Task EOPEJCOCBHD(string ALDMOBLOJMP, string LAGBPJBMLHD, [Optional] BJBGDIGAMBP JAPIGMAKNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x606DCA0", Offset = "0x606D0A0", VA = "0x18606DCA0", Slot = "16")]
	public Task EFNBJDLFHKK(BJBGDIGAMBP JAPIGMAKNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x606E190", Offset = "0x606D590", VA = "0x18606E190", Slot = "17")]
	public Task HPEOHLIBDNM(BJBGDIGAMBP JAPIGMAKNLK, Dictionary<string, string> INICGJEIMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x606E360", Offset = "0x606D760", VA = "0x18606E360", Slot = "18")]
	public bool LHODJANEGLD(string AIBKDIKNMOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x606DBA0", Offset = "0x606CFA0", VA = "0x18606DBA0", Slot = "19")]
	public FNAKILAICEA BFAEOLBLOMO(string KHJICJCPGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x606D9E0", Offset = "0x606CDE0", VA = "0x18606D9E0", Slot = "20")]
	public JKMPGPGDADE AMIJHOAKLAP(string KKNANIMPCHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x606E5E0", Offset = "0x606D9E0", VA = "0x18606E5E0", Slot = "21")]
	public Task PNHIHLJPELJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8094B0", Offset = "0x8088B0", VA = "0x1808094B0")]
	[CompilerGenerated]
	private void BIBILMNJEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x8343C0", Offset = "0x8337C0", VA = "0x1808343C0")]
	[CompilerGenerated]
	private void BAIKCEBHJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0xBD88F0", Offset = "0xBD7CF0", VA = "0x180BD88F0")]
	[CompilerGenerated]
	private void LBEELDBBDLM(string CCNKHEJHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3881050", Offset = "0x3880450", VA = "0x183881050")]
	[CompilerGenerated]
	private void KHMBIMJIPLH(string CCNKHEJHFKM, string NIOPCMHKLMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal class BDGPLMCOAEP : JKMPGPGDADE, DGLLGPNMIPH
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate void NBJMAKHBADB(string NIOPCMHKLMB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly NBJMAKHBADB EMLKKJGFNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly ILDECEHCHLP AEHCNKGCGJG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string GHGIGKDAOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1A45A50", Offset = "0x1A44E50", VA = "0x181A45A50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x53EFCE0", Offset = "0x53EF0E0", VA = "0x1853EFCE0")]
	public BDGPLMCOAEP(ILDECEHCHLP DFNBKLDEMIL, [Optional] NBJMAKHBADB HCJCEEJJCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2597410", Offset = "0x2596810", VA = "0x182597410", Slot = "5")]
	public T EBLDKANKNCA<T>(string NIOPCMHKLMB, T DADBDDPBLHB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface BILPECKKKDJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[UsedImplicitly]
public class EMAEEBPBBPC : BILPECKKKDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly LHPMGHNBLJK GNHFDBJIFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Dictionary<string, BDHNKMAEFON> OBDBJDFDEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly Dictionary<string, HashSet<string>> HLGDJNPOHKD;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x60670F0", Offset = "0x60664F0", VA = "0x1860670F0")]
	[AMCIKKJLCIB(FDMHFCDINAO.Session, HENHDGEOMOC.GameOnly)]
	[UsedImplicitly]
	private static void ICLFDKDIFAJ(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6067160", Offset = "0x6066560", VA = "0x186067160")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EMAEEBPBBPC([AKGMOFMFNCG(null)][NotNull] LHPMGHNBLJK GNHFDBJIFJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class DMCOBJGDOHA : AJLEJELNGKA
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool PEJFPPKJLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string NBKBKOPOHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LCLIMPMHKNO DCEEAPADDMB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action FFDGONEGFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x60661F0", Offset = "0x60655F0", VA = "0x1860661F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x60664D0", Offset = "0x60658D0", VA = "0x1860664D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action JKEKAFLJBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6066430", Offset = "0x6065830", VA = "0x186066430", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6066570", Offset = "0x6065970", VA = "0x186066570", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action<string, string> JOKLMLJIMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6066800", Offset = "0x6065C00", VA = "0x186066800", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6066940", Offset = "0x6065D40", VA = "0x186066940", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<string> NPAKPOLCHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6066750", Offset = "0x6065B50", VA = "0x186066750", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x60666A0", Offset = "0x6065AA0", VA = "0x1860666A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	[RecRoom.NoEngine.Common.Preserve]
	public DMCOBJGDOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x60663A0", Offset = "0x60657A0", VA = "0x1860663A0", Slot = "12")]
	public Task EOPEJCOCBHD(string ALDMOBLOJMP, string LAGBPJBMLHD, [Optional] BJBGDIGAMBP JAPIGMAKNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6066310", Offset = "0x6065710", VA = "0x186066310", Slot = "16")]
	public Task EFNBJDLFHKK(BJBGDIGAMBP JAPIGMAKNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6066610", Offset = "0x6065A10", VA = "0x186066610", Slot = "17")]
	public Task HPEOHLIBDNM(BJBGDIGAMBP JAPIGMAKNLK, Dictionary<string, string> INICGJEIMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "18")]
	public bool LHODJANEGLD(string AIBKDIKNMOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6066290", Offset = "0x6065690", VA = "0x186066290", Slot = "19")]
	public FNAKILAICEA BFAEOLBLOMO(string KHJICJCPGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6066160", Offset = "0x6065560", VA = "0x186066160", Slot = "20")]
	public JKMPGPGDADE AMIJHOAKLAP(string KKNANIMPCHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x60668B0", Offset = "0x6065CB0", VA = "0x1860668B0", Slot = "21")]
	public Task PNHIHLJPELJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal class LCLKAEPEGIP : LCLIMPMHKNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly PBDEABEFAEC BDALBPDADIL;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IReadOnlyDictionary<string, object> FAKIHACADEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1098200", Offset = "0x1097600", VA = "0x181098200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public LCLKAEPEGIP(PBDEABEFAEC LLKHOGKJFGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface AHGFMIKFLNH
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NJLMNKMOHJG LHIGHNCEAOJ(string CAHFIFPIFGK);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface BGFFNAAGJNJ
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum OKAJHNBBFLE
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	long MAOGEKANOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string LBOKCINEIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string DJDOJPADDPP
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string JFLMIENMKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string LLMHPOCOLID
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool DIHADJDBFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long CDBIAGEJIIP();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DFOOAMLDDKH(long FCEEEFBGJPN, bool PDJMOBONFJM = true);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PDGDOOFLGPK(string APOKKKDAFKO, string ADCFKLOGGNJ, string DKJIFNJBMOA);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GBIHLMOJFPH(string APOKKKDAFKO);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PPBJPIKBACG(string APOKKKDAFKO, string DJBKLKFKOPK, string CJJMHKCPBLF);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LKOLDHFBAIO(string BPMLHPFKFKM, object NGHHABLMFOH, object KKPPBJPEGHF);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GHNLOJCPCOG(OKAJHNBBFLE HGFJCBJDEDM, int GEHEIIBAMPL, [Optional] OEGGPJPPPLI LFOKNCGJPMI, [Optional] string BFAIMPAPDON, [Optional] string NBDBHDLNPOA);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OEKDCIHHAAB(OEGGPJPPPLI LFOKNCGJPMI, long CBKFOCLAFEE, long ABLNIFPDACF, int HFAHOCLADIK, string BFAIMPAPDON, int GEHEIIBAMPL);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HJHPAPKHECJ(OEGGPJPPPLI LFOKNCGJPMI, bool DLEFFDAKKCK, [Optional] string NBDBHDLNPOA);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AGKKIKFNLIG(OEGGPJPPPLI LFOKNCGJPMI, bool DLEFFDAKKCK, [Optional] string NBDBHDLNPOA);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CIDBEEGMFBK(OEGGPJPPPLI LFOKNCGJPMI, bool DLEFFDAKKCK, [Optional] string NBDBHDLNPOA);
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
