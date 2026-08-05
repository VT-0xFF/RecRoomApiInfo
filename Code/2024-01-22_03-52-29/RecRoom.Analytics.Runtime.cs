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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EE3550", Offset = "0x5EE2950", VA = "0x185EE3550")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BB490", Offset = "0x7BA890", VA = "0x1807BB490")]
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
		public AmplitudeAnalyticsClient.Settings BJMAJMGHBLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool CGFGJHKENEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x793FF0", Offset = "0x7933F0", VA = "0x180793FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x791430", Offset = "0x790830", VA = "0x180791430")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum FKLDNINAJBC
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class PKKBHNNLBEN
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class BKIDLMBFDKF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int BMJJIMEJGGF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> EBPANBDABEK;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
				public BKIDLMBFDKF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class GEOOHAIJOMC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
				public GEOOHAIJOMC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5EDE350", Offset = "0x5EDD750", VA = "0x185EDE350")]
				internal bool GAKLAKOCKNM(BKIDLMBFDKF item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string BBPAAINLGMH = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string DEOINHDHAIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<BKIDLMBFDKF> HKILHPKOIGP;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? IPGBMIKHDCE
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5EE4020", Offset = "0x5EE3420", VA = "0x185EE4020")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5EE4B70", Offset = "0x5EE3F70", VA = "0x185EE4B70")]
			internal PKKBHNNLBEN(string BAIJHLKNICF, string BKNFBOILPCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5EE4380", Offset = "0x5EE3780", VA = "0x185EE4380")]
			public int JFPCMKDJFGF([Optional] int? KEIEKPIPPIL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5EE38B0", Offset = "0x5EE2CB0", VA = "0x185EE38B0")]
			public List<Dictionary<string, object>> AAILDOABAOE(int FKGIKDHNEMC, int? KEIEKPIPPIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5EE3B20", Offset = "0x5EE2F20", VA = "0x185EE3B20")]
			public void CCCJAJMNCHN(AmplitudeAnalyticsIdentifyMessage DFFBALIDCLL, bool AKPDKPNLMPG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5EE3BC0", Offset = "0x5EE2FC0", VA = "0x185EE3BC0")]
			public void CCCJAJMNCHN(Dictionary<string, object> DFFBALIDCLL, bool AKPDKPNLMPG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5EE40C0", Offset = "0x5EE34C0", VA = "0x185EE40C0")]
			public void FDAEICLDPLP(params Dictionary<string, object>[] LKPGGFHPDHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5EE4530", Offset = "0x5EE3930", VA = "0x185EE4530")]
			public void LKOGFBMHOEP(List<Dictionary<string, object>> AAPCJDJAGAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5EE3CD0", Offset = "0x5EE30D0", VA = "0x185EE3CD0")]
			private void CLOBACFMPAG(Dictionary<string, object> DFFBALIDCLL, bool AKPDKPNLMPG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5EE3DE0", Offset = "0x5EE31E0", VA = "0x185EE3DE0")]
			public void DBCDBBGIBLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5EE4780", Offset = "0x5EE3B80", VA = "0x185EE4780")]
			private void MMBAHEKMBKB([Optional] string MHIHKIAOGIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5EE4250", Offset = "0x5EE3650", VA = "0x185EE4250")]
			private static string HDDIPPCANHE(string PAHKKNONPEO, string CONEAMPCFEL)
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
			[Cpp2IlInjected.Address(RVA = "0x5EE5840", Offset = "0x5EE4C40", VA = "0x185EE5840")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct OMJCENCNNKL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int APDIKAGDMEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string HJGDIJMGHDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T LCCEELMPMNP;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class IDPLMAEMPHP : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private LEOLCGBMIAN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
			[DebuggerHidden]
			public IDPLMAEMPHP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5EDEE60", Offset = "0x5EDE260", VA = "0x185EDEE60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5EDF620", Offset = "0x5EDEA20", VA = "0x185EDF620", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BKJFEKCKFIM : IEnumerator<object>, IEnumerator, IDisposable
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
			public EJJODCOIBAE quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
			[DebuggerHidden]
			public BKJFEKCKFIM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC720", Offset = "0x5EDBB20", VA = "0x185EDC720", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5EDC830", Offset = "0x5EDBC30", VA = "0x185EDC830", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class FPNFFPJEBBI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
			[DebuggerHidden]
			public FPNFFPJEBBI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5EDE190", Offset = "0x5EDD590", VA = "0x185EDE190", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5EDE300", Offset = "0x5EDD700", VA = "0x185EDE300", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class IFMGEPIPFJO : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private LEOLCGBMIAN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
			[DebuggerHidden]
			public IFMGEPIPFJO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5EDF670", Offset = "0x5EDEA70", VA = "0x185EDF670", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5EDF8F0", Offset = "0x5EDECF0", VA = "0x185EDF8F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class OPPCIDKMMLB : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private LEOLCGBMIAN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
			[DebuggerHidden]
			public OPPCIDKMMLB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5EE35D0", Offset = "0x5EE29D0", VA = "0x185EE35D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5EE3860", Offset = "0x5EE2C60", VA = "0x185EE3860", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class PMHEGOJPGFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public PKKBHNNLBEN cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public PMHEGOJPGFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5EE51B0", Offset = "0x5EE45B0", VA = "0x185EE51B0")]
			internal void GMLNCCNMCPO(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5EE4D60", Offset = "0x5EE4160", VA = "0x185EE4D60")]
			internal void AGJCIHKLFGG(OMJCENCNNKL<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class FJOIPDNHCFE : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private LEOLCGBMIAN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PKKBHNNLBEN cache;

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
			private PMHEGOJPGFC <>8__1;

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
			private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
			[DebuggerHidden]
			public FJOIPDNHCFE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5EDD8F0", Offset = "0x5EDCCF0", VA = "0x185EDD8F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5EDE140", Offset = "0x5EDD540", VA = "0x185EDE140", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class OIOEKKGFFDM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public OIOEKKGFFDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3FA4340", Offset = "0x3FA3740", VA = "0x183FA4340")]
			internal OMJCENCNNKL<T> LMKPEEJKKME(ELCLHAHPGDK postResponse)
			{
				return default(OMJCENCNNKL<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class CDDBANJGGIF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public CDDBANJGGIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3FA4340", Offset = "0x3FA3740", VA = "0x183FA4340")]
			internal OMJCENCNNKL<T> IALBIBCAKNF(ELCLHAHPGDK postResponse)
			{
				return default(OMJCENCNNKL<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private AEGEKEPHPII KJDAFKJPEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<CMPGLMGAGIN> BGCCOJKBKFA;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string BCKFNGAFFND = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string GOFIENNDFIE = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string GOCJDFBLLAI = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int BEOJIOLGGJH = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int PNLDFLABEMM = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int IGDDEICAOAC = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float AEEJFLELGNC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long JJABDLCNPBO = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string GBCIMDEKJHJ = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string FENPBGDPBPJ = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool HOEEMPAJOCJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool EIMEMGAKDAP;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int FBPIPJMDLNB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int MNDPENHFMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private HDMHOMBHHHD EIJJEDLINNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private JGCOPAHIJHJ JNKMKKPMFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private KGDLPKLBGOA NNBEDIJKHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool EOCMGPNGGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float KCKFOMDNIAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float NCEKPLPNJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int LJBKFEKEAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int EEBGOKNBHMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? LPIDGGKDIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? KLEAPFMLEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long HPPNANOEHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string OMFFALAKDNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool LMOEHDPNPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long HHEIFBEJCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string LOFNBALDNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string KPGLAEAGKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> GBDLCLHIMLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private FKLDNINAJBC BHMDHPKCADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int LJGEKHMILCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int JKILLOMNPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float OOKDEPNMKHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool MLPAOJPMGCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool OFCJPCGCJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private PKKBHNNLBEN EPFKMGNLGKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private PKKBHNNLBEN KCHEGLHFBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private PKKBHNNLBEN BLDNDJDHGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> KMBBDNDADLH;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo NMOAKGHHEHP;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string FACJDJHIHBF;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string KGEAEEOPNBJ = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string GMNIBGNLKNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string LCFEHNNJFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string HGFNOMEDJPJ;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private AEGEKEPHPII JEBCIHBCCEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5ED73D0", Offset = "0x5ED67D0", VA = "0x185ED73D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private CMPGLMGAGIN NDHKHOOHADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5ED7730", Offset = "0x5ED6B30", VA = "0x185ED7730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int OCILPHHOHLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5ED70F0", Offset = "0x5ED64F0", VA = "0x185ED70F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long PCDPPCPOEDB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5EDAF80", Offset = "0x5EDA380", VA = "0x185EDAF80")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5EDB0A0", Offset = "0x5EDA4A0", VA = "0x185EDB0A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string GEDIBPACAOG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5EDAF20", Offset = "0x5EDA320", VA = "0x185EDAF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string BHHHOCIAJMN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5EDAF50", Offset = "0x5EDA350", VA = "0x185EDAF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LIOJHMABPAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x863AC0", Offset = "0x862EC0", VA = "0x180863AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x863650", Offset = "0x862A50", VA = "0x180863650")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? ECCICKAMAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x999D10", Offset = "0x999110", VA = "0x180999D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5EDB090", Offset = "0x5EDA490", VA = "0x185EDB090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JICBIDCNKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF15D20", Offset = "0xF15120", VA = "0x180F15D20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xF15350", Offset = "0xF14750", VA = "0x180F15350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool EEDHOFBHFNF
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5EDAE20", Offset = "0x5EDA220", VA = "0x185EDAE20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> BEKHIKNELFK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5EDAD60", Offset = "0x5EDA160", VA = "0x185EDAD60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5EDAFD0", Offset = "0x5EDA3D0", VA = "0x185EDAFD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5550", Offset = "0x5ED4950", VA = "0x185ED5550", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7F60", Offset = "0x5ED7360", VA = "0x185ED7F60")]
		private void KLJCJBLPHDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA340", Offset = "0x5ED9740", VA = "0x185EDA340")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9520", Offset = "0x5ED8920", VA = "0x185ED9520", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA6E0", Offset = "0x5ED9AE0", VA = "0x185EDA6E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED95E0", Offset = "0x5ED89E0", VA = "0x185ED95E0")]
		public DONEJHADFEN PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7C10", Offset = "0x5ED7010", VA = "0x185ED7C10")]
		[IteratorStateMachine(typeof(IDPLMAEMPHP))]
		public IEnumerator<LEOLCGBMIAN> Initialize(AmplitudeAnalyticsEvent DFBKOPEMDJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA620", Offset = "0x5ED9A20", VA = "0x185EDA620")]
		public void UpdateLastKnownInteractionCategory(string OMIHLOCAIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA530", Offset = "0x5ED9930", VA = "0x185EDA530")]
		public void UpdateLastAliveTime(float IILLPFGJNOB = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7EA0", Offset = "0x5ED72A0", VA = "0x185ED7EA0")]
		private DONEJHADFEN KJEMINMKOML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7440", Offset = "0x5ED6840", VA = "0x185ED7440")]
		private DONEJHADFEN IPHCDOOBBME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9D90", Offset = "0x5ED9190", VA = "0x185ED9D90")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6FD0", Offset = "0x5ED63D0", VA = "0x185ED6FD0")]
		[IteratorStateMachine(typeof(BKJFEKCKFIM))]
		private IEnumerator FPFFMLHCJGG(EJJODCOIBAE IAJHFHIFDPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA970", Offset = "0x5ED9D70", VA = "0x185EDA970")]
		[IteratorStateMachine(typeof(FPNFFPJEBBI))]
		public IEnumerator WaitForFlush(float AEOPAJNOPOK = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA410", Offset = "0x5ED9810", VA = "0x185EDA410")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA350", Offset = "0x5ED9750", VA = "0x185EDA350")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime HKJHKEPHGIB)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7780", Offset = "0x5ED6B80", VA = "0x185ED7780")]
		public static DEJMHIICGKM Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5ED53E0", Offset = "0x5ED47E0", VA = "0x185ED53E0")]
		public static JGDKNAKPDOI AccountSelectionPostLoginEvent([NotNull] string APMFHCPDGEH, string EDHFPGBPPLM, bool MAJELLAOBKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6C70", Offset = "0x5ED6070", VA = "0x185ED6C70")]
		public static JGDKNAKPDOI Event([NotNull] string APMFHCPDGEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9620", Offset = "0x5ED8A20", VA = "0x185ED9620")]
		public static JGDKNAKPDOI PreviousSessionEvent([NotNull] string APMFHCPDGEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7930", Offset = "0x5ED6D30", VA = "0x185ED7930")]
		public static JGDKNAKPDOI InitializeEvent(string EDHFPGBPPLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9F50", Offset = "0x5ED9350", VA = "0x185ED9F50")]
		public static JGDKNAKPDOI StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5AC0", Offset = "0x5ED4EC0", VA = "0x185ED5AC0")]
		public static JGDKNAKPDOI CreateOutOfSessionEvent(string APMFHCPDGEH, bool MKBPILEFDJF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8A30", Offset = "0x5ED7E30", VA = "0x185ED8A30")]
		public static DONEJHADFEN LogOutOfSessionEvent(JGDKNAKPDOI KJEOEEBJNLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED87B0", Offset = "0x5ED7BB0", VA = "0x185ED87B0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent JAKAPCPOFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8D20", Offset = "0x5ED8120", VA = "0x185ED8D20")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent JAKAPCPOFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8E60", Offset = "0x5ED8260", VA = "0x185ED8E60")]
		public void LogSerializedEventAsync(Dictionary<string, object> LPPKHFLCKNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5ED88F0", Offset = "0x5ED7CF0", VA = "0x185ED88F0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage GAAPCGLBGHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5ED72D0", Offset = "0x5ED66D0", VA = "0x185ED72D0")]
		private void GOBKIAKHJDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8500", Offset = "0x5ED7900", VA = "0x185ED8500")]
		private void LPPBGPCLBMK(Dictionary<string, object> PEDGAJMEGLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7CA0", Offset = "0x5ED70A0", VA = "0x185ED7CA0")]
		private void JFECDPLMJOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8F40", Offset = "0x5ED8340", VA = "0x185ED8F40")]
		private void MCCLOCPGIPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7060", Offset = "0x5ED6460", VA = "0x185ED7060")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6BE0", Offset = "0x5ED5FE0", VA = "0x185ED6BE0")]
		[IteratorStateMachine(typeof(IFMGEPIPFJO))]
		private IEnumerator<LEOLCGBMIAN> EIFHGLGMHNP(float AEOPAJNOPOK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5E80", Offset = "0x5ED5280", VA = "0x185ED5E80")]
		[IteratorStateMachine(typeof(OPPCIDKMMLB))]
		private IEnumerator<LEOLCGBMIAN> DMLPLHOEEEF(float AEOPAJNOPOK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED59C0", Offset = "0x5ED4DC0", VA = "0x185ED59C0")]
		[IteratorStateMachine(typeof(FJOIPDNHCFE))]
		private IEnumerator<LEOLCGBMIAN> CNNKGMPBEDO(PKKBHNNLBEN JILCDALCFCE, int? KEIEKPIPPIL, string JMLMDDKNNAP, string BNIAMPJKIAF, float AEOPAJNOPOK, Action<int> AFPHFANOOGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7D90", Offset = "0x5ED7190", VA = "0x185ED7D90")]
		private static void KHDKCADOOOF(bool GKDPPFIPHCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9110", Offset = "0x5ED8510", VA = "0x185ED9110")]
		private BIDJOPNIEEO<OMJCENCNNKL<Dictionary<string, object>>> NMDFOMHMCKB(string JMLMDDKNNAP, string BNIAMPJKIAF, string OLAFMJGKLOJ, string NMBDLGMBBAE, Dictionary<string, object> LCCEELMPMNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9240", Offset = "0x5ED8640", VA = "0x185ED9240")]
		private BIDJOPNIEEO<OMJCENCNNKL<List<Dictionary<string, object>>>> NMDFOMHMCKB(string JMLMDDKNNAP, string BNIAMPJKIAF, string OLAFMJGKLOJ, string NMBDLGMBBAE, List<Dictionary<string, object>> LCCEELMPMNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2C88160", Offset = "0x2C87560", VA = "0x182C88160")]
		private BIDJOPNIEEO<OMJCENCNNKL<T>> LDKDBFAGEPH<T>(string JMLMDDKNNAP, string BNIAMPJKIAF, string NMBDLGMBBAE, T LCCEELMPMNP, Dictionary<string, object> HJGFIBKIJNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2C87E10", Offset = "0x2C87210", VA = "0x182C87E10")]
		private BIDJOPNIEEO<OMJCENCNNKL<T>> FAFNPKEOPGF<T>(string JMLMDDKNNAP, string BNIAMPJKIAF, string OLAFMJGKLOJ, T LCCEELMPMNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6F80", Offset = "0x5ED6380", VA = "0x185ED6F80")]
		private bool FPFCAOICHNH(float NLBCFDHNMGL, float AEOPAJNOPOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5F10", Offset = "0x5ED5310", VA = "0x185ED5F10")]
		private Dictionary<string, object> DOOEAGJOIAD(string BNIAMPJKIAF, Dictionary<string, object> LCCEELMPMNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAA60", Offset = "0x5ED9E60", VA = "0x185EDAA60")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5D20", Offset = "0x5ED5120", VA = "0x185ED5D20")]
		[CompilerGenerated]
		private long DKOIGAGLKPG()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6F70", Offset = "0x5ED6370", VA = "0x185ED6F70")]
		[CompilerGenerated]
		private void FKNNGFCMAEA(int DDGMMAEKHJB)
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
			[Cpp2IlInjected.Address(RVA = "0x5EDBE00", Offset = "0x5EDB200", VA = "0x185EDBE00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5EDBEE0", Offset = "0x5EDB2E0", VA = "0x185EDBEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5EDBE40", Offset = "0x5EDB240", VA = "0x185EDBE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5EDBF40", Offset = "0x5EDB340", VA = "0x185EDBF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5EDBDC0", Offset = "0x5EDB1C0", VA = "0x185EDBDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5EDBE80", Offset = "0x5EDB280", VA = "0x185EDBE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x793FA0", Offset = "0x7933A0", VA = "0x180793FA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB100", Offset = "0x5EDA500", VA = "0x185EDB100")]
		public static JGDKNAKPDOI CNMCABBAMHK(string IEOKPDEFBIP, [NotNull] string LFBEEOHBILH, long ONGEFBKHPDG, long BCCPNBHJPPE, string EDHFPGBPPLM, bool MAJELLAOBKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBAD0", Offset = "0x5EDAED0", VA = "0x185EDBAD0")]
		public static JGDKNAKPDOI LPEHGAGHLGC(string IEOKPDEFBIP, [NotNull] string LFBEEOHBILH, long ONGEFBKHPDG, long BCCPNBHJPPE, string EDHFPGBPPLM, long IELGGDNEFJJ, bool MAJELLAOBKH, string NOINMDGHNBH, string DJBNNCILGEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBC30", Offset = "0x5EDB030", VA = "0x185EDBC30")]
		private AmplitudeAnalyticsEvent(string IEOKPDEFBIP, [NotNull] string LFBEEOHBILH, long ONGEFBKHPDG, long BCCPNBHJPPE, string EDHFPGBPPLM, bool MAJELLAOBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x19A56B0", Offset = "0x19A4AB0", VA = "0x1819A56B0")]
		public void PNFMCDFFEPJ(long LJDDMCFGFFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB380", Offset = "0x5EDA780", VA = "0x185EDB380", Slot = "5")]
		public override void FHEMKKIIAPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB200", Offset = "0x5EDA600", VA = "0x185EDB200", Slot = "6")]
		public override void FCNEIHDKPOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB5A0", Offset = "0x5EDA9A0", VA = "0x185EDB5A0", Slot = "4")]
		protected override Dictionary<string, object> GFHJNIHLPMB(Dictionary<string, object> LDOENACFPEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB490", Offset = "0x5EDA890", VA = "0x185EDB490")]
		private void FPNCENMGPNL(string CONEAMPCFEL, string PAHKKNONPEO, bool CJKFDFKKKOF = false)
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
			[Cpp2IlInjected.Address(RVA = "0x5EDD770", Offset = "0x5EDCB70", VA = "0x185EDD770")]
			public void CDKMFEHILEF(Dictionary<string, object> IBGLCPIMJDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EE54D0", Offset = "0x5EE48D0", VA = "0x185EE54D0")]
			public void CDKMFEHILEF(Dictionary<string, object> AKEEBPEEMKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A2880", Offset = "0x8A1C80", VA = "0x1808A2880")]
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
			[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x793930", Offset = "0x792D30", VA = "0x180793930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBFA0", Offset = "0x5EDB3A0", VA = "0x185EDBFA0")]
		public static DEJMHIICGKM CNMCABBAMHK(string IEOKPDEFBIP, string EDHFPGBPPLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC660", Offset = "0x5EDBA60", VA = "0x185EDC660")]
		protected AmplitudeAnalyticsIdentifyMessage(string IEOKPDEFBIP, string EDHFPGBPPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC220", Offset = "0x5EDB620", VA = "0x185EDC220")]
		public Dictionary<string, object> GBGDDHGDANB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC2B0", Offset = "0x5EDB6B0", VA = "0x185EDC2B0", Slot = "4")]
		protected virtual Dictionary<string, object> GFHJNIHLPMB(Dictionary<string, object> LDOENACFPEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC060", Offset = "0x5EDB460", VA = "0x185EDC060")]
		protected void EAHNEECFCFN(string CONEAMPCFEL, Dictionary<string, object> OBBMDBNLKGL, Dictionary<string, object> KJNIKDFKNGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC5F0", Offset = "0x5EDB9F0", VA = "0x185EDC5F0")]
		protected void GLEFMKMJGNJ(string CONEAMPCFEL, string PAHKKNONPEO, Dictionary<string, object> JJCILDAOOGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC190", Offset = "0x5EDB590", VA = "0x185EDC190", Slot = "5")]
		public virtual void FHEMKKIIAPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC100", Offset = "0x5EDB500", VA = "0x185EDC100", Slot = "6")]
		public virtual void FCNEIHDKPOO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DEJMHIICGKM : KMJJPKDFNAE<AmplitudeAnalyticsIdentifyMessage, DEJMHIICGKM>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override DEJMHIICGKM OAHCIHDOLPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage KNPAJLOCLLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD720", Offset = "0x5EDCB20", VA = "0x185EDD720")]
	public DEJMHIICGKM(AmplitudeAnalyticsIdentifyMessage AGOKDCAFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD670", Offset = "0x5EDCA70", VA = "0x185EDD670", Slot = "4")]
	public override void FCNEIHDKPOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JGDKNAKPDOI : KMJJPKDFNAE<AmplitudeAnalyticsEvent, JGDKNAKPDOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool MLLLDPJPFOB;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override JGDKNAKPDOI OAHCIHDOLPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long LHAAGMDPHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E610", Offset = "0x1E6DA10", VA = "0x181E6E610")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5EDFE50", Offset = "0x5EDF250", VA = "0x185EDFE50")]
	public JGDKNAKPDOI(AmplitudeAnalyticsEvent AGOKDCAFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920", Slot = "5")]
	public override AmplitudeAnalyticsEvent KNPAJLOCLLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5EDFAF0", Offset = "0x5EDEEF0", VA = "0x185EDFAF0", Slot = "4")]
	public override void FCNEIHDKPOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2663140", Offset = "0x2662540", VA = "0x182663140")]
	public JGDKNAKPDOI MEPLKNIGBCO<T>(string JAOOJJKNLDO, T[] PAHKKNONPEO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2663140", Offset = "0x2662540", VA = "0x182663140")]
	public JGDKNAKPDOI MEPLKNIGBCO(string JAOOJJKNLDO, string[] PAHKKNONPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2662E90", Offset = "0x2662290", VA = "0x182662E90")]
	public JGDKNAKPDOI MEPLKNIGBCO<T>(string JAOOJJKNLDO, T PAHKKNONPEO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5EDFC90", Offset = "0x5EDF090", VA = "0x185EDFC90")]
	public JGDKNAKPDOI MEPLKNIGBCO(string JAOOJJKNLDO, long PAHKKNONPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5EDFD10", Offset = "0x5EDF110", VA = "0x185EDFD10")]
	public JGDKNAKPDOI MEPLKNIGBCO(string JAOOJJKNLDO, string PAHKKNONPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5EDFE20", Offset = "0x5EDF220", VA = "0x185EDFE20")]
	public JGDKNAKPDOI OAHFGBMKOGD(string JAOOJJKNLDO, object? PAHKKNONPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EDFD80", Offset = "0x5EDF180", VA = "0x185EDFD80")]
	public JGDKNAKPDOI NEPFPGHEPHM(string JAOOJJKNLDO, string PAHKKNONPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EDFB90", Offset = "0x5EDEF90", VA = "0x185EDFB90")]
	private JGDKNAKPDOI JIDIELLIOFI(string JAOOJJKNLDO, object PAHKKNONPEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JJJFBKMEGMH : JGDKNAKPDOI
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5EDFE50", Offset = "0x5EDF250", VA = "0x185EDFE50")]
	public JJJFBKMEGMH(AmplitudeAnalyticsEvent AGOKDCAFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EDFEA0", Offset = "0x5EDF2A0", VA = "0x185EDFEA0", Slot = "4")]
	public override void FCNEIHDKPOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class KMJJPKDFNAE<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : KMJJPKDFNAE<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M AGOKDCAFCLN;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR OAHCIHDOLPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	public KMJJPKDFNAE(M AGOKDCAFCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3B74D50", Offset = "0x3B74150", VA = "0x183B74D50")]
	public BLDR IDDIDNOCLKC(AmplitudeAnalyticsIdentifyMessage.DeviceInfo CAABFNPEPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3B74ED0", Offset = "0x3B742D0", VA = "0x183B74ED0")]
	public BLDR OKMPCCMMPFI(AmplitudeAnalyticsIdentifyMessage.RevenueData PGBNFPLFEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3B74CD0", Offset = "0x3B740D0", VA = "0x183B74CD0")]
	public BLDR BOMKBNGJOMO(string JAOOJJKNLDO, string PAHKKNONPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x25364C0", Offset = "0x25358C0", VA = "0x1825364C0")]
	public BLDR BOMKBNGJOMO<T>(string JAOOJJKNLDO, T PAHKKNONPEO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FCNEIHDKPOO();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3B74DA0", Offset = "0x3B741A0", VA = "0x183B74DA0")]
	internal static string LNMAJHICJJI(string PAHKKNONPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3B74DD0", Offset = "0x3B741D0", VA = "0x183B74DD0")]
	private BLDR MAOJAECDABL(string JAOOJJKNLDO, object PAHKKNONPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M KNPAJLOCLLF();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class LJJAEENJMHG : HDMHOMBHHHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct CCADJJPIKNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<ELCLHAHPGDK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public LJJAEENJMHG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5EDC880", Offset = "0x5EDBC80", VA = "0x185EDC880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD120", Offset = "0x5EDC520", VA = "0x185EDD120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct IBJMNDMKMPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<ELCLHAHPGDK> <>t__builder;

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
		public LJJAEENJMHG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5EDE3C0", Offset = "0x5EDD7C0", VA = "0x185EDE3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5EDEDF0", Offset = "0x5EDE1F0", VA = "0x185EDEDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient JEMFKCPLIOD;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1670", Offset = "0x5EE0A70", VA = "0x185EE1670")]
	[ABIGJEDBLLA(BMBIBJGPNHE.None)]
	private static void KELDFOCEHCO(DFNLNAANFCD MKEGOGNADMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1830", Offset = "0x5EE0C30", VA = "0x185EE1830")]
	[RecRoom.NoEngine.Common.Preserve]
	public LJJAEENJMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EE16E0", Offset = "0x5EE0AE0", VA = "0x185EE16E0", Slot = "4")]
	[AsyncStateMachine(typeof(CCADJJPIKNA))]
	public Task<ELCLHAHPGDK> NMDFOMHMCKB(string JMLMDDKNNAP, Dictionary<string, string> BBAJLHCCMPJ, bool LPLGCDCHILP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1500", Offset = "0x5EE0900", VA = "0x185EE1500", Slot = "5")]
	[AsyncStateMachine(typeof(IBJMNDMKMPA))]
	public Task<ELCLHAHPGDK> JEDNHAOCOLC(string JMLMDDKNNAP, string KJDAFDAGBEF, string IACCKLPHIJJ, string PHADPOMBAGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IOCLMNIJGGE
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> MJJGJMHCLCN;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF940", Offset = "0x5EDED40", VA = "0x185EDF940")]
	internal static bool PAJFBEDLLKP(string CONEAMPCFEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HDMHOMBHHHD
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ELCLHAHPGDK> NMDFOMHMCKB(string JMLMDDKNNAP, Dictionary<string, string> BBAJLHCCMPJ, bool LPLGCDCHILP = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ELCLHAHPGDK> JEDNHAOCOLC(string JMLMDDKNNAP, string KJDAFDAGBEF, string IACCKLPHIJJ, string PHADPOMBAGI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct ELCLHAHPGDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int AEHFDAIJNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string EKEMAEIAKOG;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xB97A80", Offset = "0xB96E80", VA = "0x180B97A80")]
	public ELCLHAHPGDK(int APDIKAGDMEH, string HJGDIJMGHDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum NPAAMHHAMAC
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
public class KPJMJFDPCEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long JNFJEIAIGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private JGDKNAKPDOI LBJNGELJJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool BCEABOIGKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float AFOAGLGFACA;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1370", Offset = "0x5EE0770", VA = "0x185EE1370")]
	public KPJMJFDPCEE(string EIBCMAFJFCF, float AFOAGLGFACA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x26A44D0", Offset = "0x26A38D0", VA = "0x1826A44D0")]
	public void MEPLKNIGBCO<T>(string JAOOJJKNLDO, T PAHKKNONPEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1230", Offset = "0x5EE0630", VA = "0x185EE1230")]
	public void MEPLKNIGBCO(string JAOOJJKNLDO, string PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0FE0", Offset = "0x5EE03E0", VA = "0x185EE0FE0")]
	public void CHNHLCPBHCI(string DNENKPDDJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5EE12B0", Offset = "0x5EE06B0", VA = "0x185EE12B0")]
	public void OOKLJHGCAFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1120", Offset = "0x5EE0520", VA = "0x185EE1120")]
	private void FAEICFADNDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5EE10D0", Offset = "0x5EE04D0", VA = "0x185EE10D0")]
	private bool CJICABBBKAJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface FDGEEPCHEBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool KJBEDCLLEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string LIOJHMABPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	OOIEIHEFKPF EMAECDPFBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JFKEGJJONLM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BNJNKLBNPPM;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DONEJHADFEN FILODNFGCKM(string LLOKCBEJGAC, string BKNFBOILPCI, [Optional] JGCOPAHIJHJ CONPKEPKLCH);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DONEJHADFEN KHFCMKKNHAF(JGCOPAHIJHJ CONPKEPKLCH);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DONEJHADFEN HAAJMOPPGGF(JGCOPAHIJHJ CONPKEPKLCH, Dictionary<string, string> JIGEDIHEBNI);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GLPGMDNLKOG(string PBDMGNBIHHC);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	POPMKNDFAAK HAAIHFIKNAB(string KACPDFCDCBB);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PFKNIBANKCK NKFLNLCABIC(string MMBGDLODNAM);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DONEJHADFEN IDDCHKBAOLP();
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
			[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5640", Offset = "0x5EE4A40", VA = "0x185EE5640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LLBOOFDBBGI : FDGEEPCHEBJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly IReadOnlyDictionary<string, ONCOIOKDOOC> AMDFIKLNBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool PPBDGKJLDBC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool KJBEDCLLEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B90", Offset = "0x7DFF90", VA = "0x1807E0B90", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string LIOJHMABPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2640", Offset = "0x5EE1A40", VA = "0x185EE2640", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public OOIEIHEFKPF EMAECDPFBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5EE3400", Offset = "0x5EE2800", VA = "0x185EE3400", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action JFKEGJJONLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2EB0", Offset = "0x5EE22B0", VA = "0x185EE2EB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2E10", Offset = "0x5EE2210", VA = "0x185EE2E10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action BNJNKLBNPPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2090", Offset = "0x5EE1490", VA = "0x185EE2090", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5EE25A0", Offset = "0x5EE19A0", VA = "0x185EE25A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2130", Offset = "0x5EE1530", VA = "0x185EE2130", Slot = "8")]
	public DONEJHADFEN FILODNFGCKM(string LLOKCBEJGAC, string BKNFBOILPCI, [Optional] JGCOPAHIJHJ CONPKEPKLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2CC0", Offset = "0x5EE20C0", VA = "0x185EE2CC0", Slot = "17")]
	public DONEJHADFEN IDDCHKBAOLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2F50", Offset = "0x5EE2350", VA = "0x185EE2F50", Slot = "12")]
	public DONEJHADFEN KHFCMKKNHAF(JGCOPAHIJHJ CONPKEPKLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5EE28E0", Offset = "0x5EE1CE0", VA = "0x185EE28E0", Slot = "13")]
	public DONEJHADFEN HAAJMOPPGGF(JGCOPAHIJHJ CONPKEPKLCH, Dictionary<string, string> JIGEDIHEBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2650", Offset = "0x5EE1A50", VA = "0x185EE2650", Slot = "14")]
	public bool GLPGMDNLKOG(string PBDMGNBIHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EE26E0", Offset = "0x5EE1AE0", VA = "0x185EE26E0", Slot = "15")]
	public POPMKNDFAAK HAAIHFIKNAB(string KACPDFCDCBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3140", Offset = "0x5EE2540", VA = "0x185EE3140", Slot = "16")]
	public PFKNIBANKCK NKFLNLCABIC(string MMBGDLODNAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1930", Offset = "0x5EE0D30", VA = "0x185EE1930")]
	private OOIEIHEFKPF EBJJOJHCKIM(JGCOPAHIJHJ CONPKEPKLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5EE31D0", Offset = "0x5EE25D0", VA = "0x185EE31D0")]
	private JMPLBCJOMDP NNMGHBFDGEG(string BKNFBOILPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2BB0", Offset = "0x5EE1FB0", VA = "0x185EE2BB0")]
	private void HMFAOMLFJNL(string KACPDFCDCBB, POPMKNDFAAK BDPNGCCHMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public LLBOOFDBBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xAA42B0", Offset = "0xAA36B0", VA = "0x180AA42B0")]
	[CompilerGenerated]
	private void JPEDJKPJDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5EE18B0", Offset = "0x5EE0CB0", VA = "0x185EE18B0")]
	[CompilerGenerated]
	private void CBEIILOKLNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3380", Offset = "0x5EE2780", VA = "0x185EE3380")]
	[CompilerGenerated]
	private void OLJNHPLDNHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JPGELEBAIBP : FDGEEPCHEBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private FDGEEPCHEBJ NFAGHEPFEHJ;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private FDGEEPCHEBJ AFMAIMAFNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5EE00C0", Offset = "0x5EDF4C0", VA = "0x185EE00C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KJBEDCLLEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0620", Offset = "0x5EDFA20", VA = "0x185EE0620", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string LIOJHMABPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0710", Offset = "0x5EDFB10", VA = "0x185EE0710", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public OOIEIHEFKPF EMAECDPFBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0F20", Offset = "0x5EE0320", VA = "0x185EE0F20", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action JFKEGJJONLM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0C60", Offset = "0x5EE0060", VA = "0x185EE0C60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0BC0", Offset = "0x5EDFFC0", VA = "0x185EE0BC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action BNJNKLBNPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0130", Offset = "0x5EDF530", VA = "0x185EE0130", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0670", Offset = "0x5EDFA70", VA = "0x185EE0670", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	[UnityEngine.Scripting.Preserve]
	public JPGELEBAIBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0B50", Offset = "0x5EDFF50", VA = "0x185EE0B50")]
	[ABIGJEDBLLA(BMBIBJGPNHE.GameOnly)]
	private static void JKLDANPBABA(DFNLNAANFCD MKEGOGNADMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0050", Offset = "0x5EDF450", VA = "0x185EE0050")]
	[ABIGJEDBLLA(BMBIBJGPNHE.EditorOnly)]
	private static void ACAHGIHPNOO(DFNLNAANFCD MKEGOGNADMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5EE01D0", Offset = "0x5EDF5D0", VA = "0x185EE01D0", Slot = "8")]
	public DONEJHADFEN FILODNFGCKM(string LLOKCBEJGAC, string BKNFBOILPCI, [Optional] JGCOPAHIJHJ CONPKEPKLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0D00", Offset = "0x5EE0100", VA = "0x185EE0D00", Slot = "12")]
	public DONEJHADFEN KHFCMKKNHAF(JGCOPAHIJHJ CONPKEPKLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0920", Offset = "0x5EDFD20", VA = "0x185EE0920", Slot = "13")]
	public DONEJHADFEN HAAJMOPPGGF(JGCOPAHIJHJ CONPKEPKLCH, Dictionary<string, string> JIGEDIHEBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0760", Offset = "0x5EDFB60", VA = "0x185EE0760", Slot = "14")]
	public bool GLPGMDNLKOG(string PBDMGNBIHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0810", Offset = "0x5EDFC10", VA = "0x185EE0810", Slot = "15")]
	public POPMKNDFAAK HAAIHFIKNAB(string KACPDFCDCBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0E10", Offset = "0x5EE0210", VA = "0x185EE0E10", Slot = "16")]
	public PFKNIBANKCK NKFLNLCABIC(string MMBGDLODNAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0A40", Offset = "0x5EDFE40", VA = "0x185EE0A40", Slot = "17")]
	public DONEJHADFEN IDDCHKBAOLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4F0", Offset = "0x7DA8F0", VA = "0x1807DB4F0")]
	[CompilerGenerated]
	private void GBNCIKLHBCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xB9A290", Offset = "0xB99690", VA = "0x180B9A290")]
	[CompilerGenerated]
	private void PDGHCEGEFDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CNCDICBJMDI : FDGEEPCHEBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KJBEDCLLEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string LIOJHMABPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public OOIEIHEFKPF EMAECDPFBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action JFKEGJJONLM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD530", Offset = "0x5EDC930", VA = "0x185EDD530", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD490", Offset = "0x5EDC890", VA = "0x185EDD490", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action BNJNKLBNPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD190", Offset = "0x5EDC590", VA = "0x185EDD190", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD2C0", Offset = "0x5EDC6C0", VA = "0x185EDD2C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CNCDICBJMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD230", Offset = "0x5EDC630", VA = "0x185EDD230", Slot = "8")]
	public DONEJHADFEN FILODNFGCKM(string LLOKCBEJGAC, string BKNFBOILPCI, [Optional] JGCOPAHIJHJ CONPKEPKLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD5D0", Offset = "0x5EDC9D0", VA = "0x185EDD5D0", Slot = "12")]
	public DONEJHADFEN KHFCMKKNHAF(JGCOPAHIJHJ CONPKEPKLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD370", Offset = "0x5EDC770", VA = "0x185EDD370", Slot = "13")]
	public DONEJHADFEN HAAJMOPPGGF(JGCOPAHIJHJ CONPKEPKLCH, Dictionary<string, string> JIGEDIHEBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "14")]
	public bool GLPGMDNLKOG(string PBDMGNBIHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD360", Offset = "0x5EDC760", VA = "0x185EDD360", Slot = "15")]
	public POPMKNDFAAK HAAIHFIKNAB(string KACPDFCDCBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD660", Offset = "0x5EDCA60", VA = "0x185EDD660", Slot = "16")]
	public PFKNIBANKCK NKFLNLCABIC(string MMBGDLODNAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD400", Offset = "0x5EDC800", VA = "0x185EDD400", Slot = "17")]
	public DONEJHADFEN IDDCHKBAOLP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface ALACLMOGAMH
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KPJMJFDPCEE KPECBCBFLBE(string EIBCMAFJFCF);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KGDLPKLBGOA
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum IININDDLHJO
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
	long EEIAJNPIBMC
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string JNCFMFDGMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string KFHCFEBOENI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string HHBEEGIOHMB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string EOCKNKBJKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool PMMHOPOPJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long KDMEGLNGGEK();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HPFBBGBOAPC(long ONGEFBKHPDG, bool CJKFDFKKKOF = true);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BCPPOIFKAFL(string AOGDICEMNLI, string GHIMFGPONMO, string OPDELHLJIPE);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LGOKFELJFPI(string AOGDICEMNLI);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GPMENEIJEMF(string AOGDICEMNLI, string AJCEJMPNNOH, string LEJOKLMABGA);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void COFJPPJHGBJ(string OKEJCPJBJCK, object EFDMECOKJKE, object ACOLPOLGEPE);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LKBBNPDHMOG(IININDDLHJO CPOMNIINDPB, int PAJBMBKMIHA, [Optional] NGIEHABMNNE GLGFNOEECHE, [Optional] string AGEJMLPGLKG, [Optional] string HNINMPIFBCK);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HDOIGOBJMAM(NGIEHABMNNE GLGFNOEECHE, long BJDHLJJFJME, long KLNHMIFLGKC, int FHHMCIJNPOD, string AGEJMLPGLKG, int PAJBMBKMIHA);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LNPCOIKNEIM(NGIEHABMNNE GLGFNOEECHE, bool NMDELEBPBKE, [Optional] string HNINMPIFBCK);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HCNHLLKBKKN(NGIEHABMNNE GLGFNOEECHE, bool NMDELEBPBKE, [Optional] string HNINMPIFBCK);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DAABACGGNFM(NGIEHABMNNE GLGFNOEECHE, bool NMDELEBPBKE, [Optional] string HNINMPIFBCK);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface JGCOPAHIJHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool PCDENGGPALK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool EFKIAMLFBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool BOJPILBGPCE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool? NGMNDMMMHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	int? ECCICKAMAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	int OALIMKFIGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string GNNNJDMCECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string MKHADCIECKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string OLICAIJPGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	long HPPACLIOOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string PLKBNICDLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string JHENGOKCGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string BGMHCDPCFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string EOOPMPBNHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	string KIFNAIFCJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	double DCELKNFOIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	int PMOABHHKGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "16")]
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
