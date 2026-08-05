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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67F8790", Offset = "0x67F7790", VA = "0x1867F8790")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
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
		public AmplitudeAnalyticsClient.Settings PCBNLPAIHHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HMHKDPEAMJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x851860", Offset = "0x850860", VA = "0x180851860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum FHLMMLOKBIC
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class BHIEPFOICNK
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class BPNCMAKIGGF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				public int HPKODJDNFMD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public Dictionary<string, object> IKPOFCNFHED;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
				public BPNCMAKIGGF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class LHKFIFGJLID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
				public LHKFIFGJLID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x67F7B90", Offset = "0x67F6B90", VA = "0x1867F7B90")]
				internal bool DJGPDIPGKDF(BPNCMAKIGGF item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private const string EHGNLDHPGAD = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly string PLCNFEGEAJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private List<BPNCMAKIGGF> OKOEIGALJGI;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public int? LANDCENGCHL
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x67EF6A0", Offset = "0x67EE6A0", VA = "0x1867EF6A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x67F0510", Offset = "0x67EF510", VA = "0x1867F0510")]
			internal BHIEPFOICNK(string NDPFHIMAAJN, string CELLCBFHIHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x67EFF70", Offset = "0x67EEF70", VA = "0x1867EFF70")]
			public int OGHLKJOLHJM([Optional] int? OCMFFAKOFMF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x67EF280", Offset = "0x67EE280", VA = "0x1867EF280")]
			public List<Dictionary<string, object>> AIKPIBCIGMI(int IPFGGHBPDEE, int? OCMFFAKOFMF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x67EF4F0", Offset = "0x67EE4F0", VA = "0x1867EF4F0")]
			public void BGOCFKMCHOF(AmplitudeAnalyticsIdentifyMessage NOPFNIKINJA, bool EGIIGKALPPN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x67EF590", Offset = "0x67EE590", VA = "0x1867EF590")]
			public void BGOCFKMCHOF(Dictionary<string, object> NOPFNIKINJA, bool EGIIGKALPPN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x67EFAC0", Offset = "0x67EEAC0", VA = "0x1867EFAC0")]
			public void MMMFJOJMMLN(params Dictionary<string, object>[] ALJHMOPNDAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x67EF740", Offset = "0x67EE740", VA = "0x1867EF740")]
			public void JNAOKBJALNJ(List<Dictionary<string, object>> INKHACEIOAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x67EFE60", Offset = "0x67EEE60", VA = "0x1867EFE60")]
			private void NAKEOLNGIOJ(Dictionary<string, object> NOPFNIKINJA, bool EGIIGKALPPN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x67EFC50", Offset = "0x67EEC50", VA = "0x1867EFC50")]
			public void MNOCEOGLGMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x67F0120", Offset = "0x67EF120", VA = "0x1867F0120")]
			private void PLGNANNAODG([Optional] string LHEGNOINOAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x67EF990", Offset = "0x67EE990", VA = "0x1867EF990")]
			private static string KIKEJBICMLD(string JJCEIJMGOAB, string GMFCIHEFPPO)
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
			[Cpp2IlInjected.Address(RVA = "0x67FA560", Offset = "0x67F9560", VA = "0x1867FA560")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct BBMDIMKAEED<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public int MMFMDFHGJDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public string KHGNCDBFOKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T KNJLHCCMKFF;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class FCOPOOMHFKA : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private FAKEPIEMOLB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
			[DebuggerHidden]
			public FCOPOOMHFKA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x67F44C0", Offset = "0x67F34C0", VA = "0x1867F44C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x67F4C80", Offset = "0x67F3C80", VA = "0x1867F4C80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class KNKGJIIMAMO : IEnumerator<object>, IEnumerator, IDisposable
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
			public NEIBFFKKMCM quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
			[DebuggerHidden]
			public KNKGJIIMAMO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x67F6490", Offset = "0x67F5490", VA = "0x1867F6490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x67F65A0", Offset = "0x67F55A0", VA = "0x1867F65A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class KOKIBEFLGCE : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
			[DebuggerHidden]
			public KOKIBEFLGCE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x67F65F0", Offset = "0x67F55F0", VA = "0x1867F65F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x67F6760", Offset = "0x67F5760", VA = "0x1867F6760", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class IICFIGHKFHP : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private FAKEPIEMOLB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
			[DebuggerHidden]
			public IICFIGHKFHP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x67F5250", Offset = "0x67F4250", VA = "0x1867F5250", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x67F54B0", Offset = "0x67F44B0", VA = "0x1867F54B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class POOFEHCFEKI : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private FAKEPIEMOLB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
			[DebuggerHidden]
			public POOFEHCFEKI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x67F9F30", Offset = "0x67F8F30", VA = "0x1867F9F30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x67FA190", Offset = "0x67F9190", VA = "0x1867FA190", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class JPOCPOFBBAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public BHIEPFOICNK cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public JPOCPOFBBAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x67F6170", Offset = "0x67F5170", VA = "0x1867F6170")]
			internal void JOBFKDGGJDK(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x67F5D20", Offset = "0x67F4D20", VA = "0x1867F5D20")]
			internal void JAMOMOAOMFC(BBMDIMKAEED<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class PGIEEICGCCM : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private FAKEPIEMOLB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public BHIEPFOICNK cache;

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
			private JPOCPOFBBAN <>8__1;

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
			private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
			[DebuggerHidden]
			public PGIEEICGCCM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x67F96C0", Offset = "0x67F86C0", VA = "0x1867F96C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x67F9EE0", Offset = "0x67F8EE0", VA = "0x1867F9EE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class DCFLOEJPIJK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public DCFLOEJPIJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5821140", Offset = "0x5820140", VA = "0x185821140")]
			internal BBMDIMKAEED<T> IDADJOMHPJO(GDLMGGLPEJF postResponse)
			{
				return default(BBMDIMKAEED<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private LFDOIPPMKHF JEHJGGHNNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<NBAKKNFCMLK> BDFHGMBGJBI;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string NKJAOIEMKKJ = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string BPNALKPIPKD = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string OLKHGLJHJNA = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int HGCCGIJHCDD = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int GDLBGEMOMKI = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int HPELCMJGIMO = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float GDGLCOBPCJJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long BGMPCOHNNGD = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string HLNBCDEIGCD = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string EAGMEBKPHMD = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string KJGJMLJLHJK = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string BDKGFMANDPI = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool NNNPGABJGEG;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool DLMOHJLJJBK;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int MCDIFEPCPMH;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int DMIPBFBNOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private IAEKAHPMALK BEPKBHHADFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private BDLIBGOKKJO DKHIIPGJAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private LFEJBBDAJKP FBNDOOAMFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool EPHCGGHIKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float NKJAKMDNAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float FPEJJMDIILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int AEPINPMMIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int FEDCOJKEHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? JGBBEACKHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? LAGJDMGAAOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long GOKCNFEHPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string NAEGFMNFJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool IEBBHEKLCAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long GNHINCLICHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string GANNMCKLIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string JLIOPONEFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> EKDGPIHLNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private FHLMMLOKBIC NLLDELDOGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int ACNDMLABGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int AHOEBEHAMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float GKPPHDNMFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool BNAOGIJCKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool ILOJEBPOMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private BHIEPFOICNK MMEOBDDMGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private BHIEPFOICNK HGGDANFHIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private BHIEPFOICNK CKJCEHMOBDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string BDINJPMKFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> KHMBDDLKBPC;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo FIHJNFDHMMK;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static string EODCMABALLP;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string KKMABGOJIEO = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly string KCJFOPIDHHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string IIGJDKDLHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string MHJIMPCDNID;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LFDOIPPMKHF BAAEDJGBHFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x67EBCF0", Offset = "0x67EACF0", VA = "0x1867EBCF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private NBAKKNFCMLK IGGAKEIDLEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x67EB170", Offset = "0x67EA170", VA = "0x1867EB170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int AEHCNFPAFDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x67E8670", Offset = "0x67E7670", VA = "0x1867E8670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long HAEDLNIBKMB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x67EDB10", Offset = "0x67ECB10", VA = "0x1867EDB10")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x67EDC20", Offset = "0x67ECC20", VA = "0x1867EDC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string ICOAHNPKPCN
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x67EDAE0", Offset = "0x67ECAE0", VA = "0x1867EDAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string IIBNDGFBGOF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x99B680", Offset = "0x99A680", VA = "0x18099B680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xC75890", Offset = "0xC74890", VA = "0x180C75890")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int? HIGBIDBKCGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x99B690", Offset = "0x99A690", VA = "0x18099B690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x17BC0F0", Offset = "0x17BB0F0", VA = "0x1817BC0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MLMIDMFHGDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x120B400", Offset = "0x120A400", VA = "0x18120B400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1252D20", Offset = "0x1251D20", VA = "0x181252D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool IGLHJBOJADE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x67ED9F0", Offset = "0x67EC9F0", VA = "0x1867ED9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> NBIKEBJNNPG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x67ED930", Offset = "0x67EC930", VA = "0x1867ED930")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x67EDB60", Offset = "0x67ECB60", VA = "0x1867EDB60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x67E7FA0", Offset = "0x67E6FA0", VA = "0x1867E7FA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x67EABD0", Offset = "0x67E9BD0", VA = "0x1867EABD0")]
		private void KEMNIHGDKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67ECF10", Offset = "0x67EBF10", VA = "0x1867ECF10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x67EBD60", Offset = "0x67EAD60", VA = "0x1867EBD60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x67ED2B0", Offset = "0x67EC2B0", VA = "0x1867ED2B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67EBF30", Offset = "0x67EAF30", VA = "0x1867EBF30")]
		public OBDNBLKJHLC PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67E9E70", Offset = "0x67E8E70", VA = "0x1867E9E70")]
		[IteratorStateMachine(typeof(FCOPOOMHFKA))]
		public IEnumerator<FAKEPIEMOLB> InitializeForLocalAccount(AmplitudeAnalyticsEvent DNBKADEMPPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x67EC6C0", Offset = "0x67EB6C0", VA = "0x1867EC6C0")]
		public void SendAppEnterEvent(bool KFOADDBCOLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67ED1F0", Offset = "0x67EC1F0", VA = "0x1867ED1F0")]
		public void UpdateLastKnownInteractionCategory(string PNBCMPKEPLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67ED100", Offset = "0x67EC100", VA = "0x1867ED100")]
		public void UpdateLastAliveTime(float HEGNCBOIFLG = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67E98F0", Offset = "0x67E88F0", VA = "0x1867E98F0")]
		private OBDNBLKJHLC ILFBPACGBJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67EB910", Offset = "0x67EA910", VA = "0x1867EB910")]
		private OBDNBLKJHLC MGFAAJAFAMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67EC970", Offset = "0x67EB970", VA = "0x1867EC970")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67EB1C0", Offset = "0x67EA1C0", VA = "0x1867EB1C0")]
		[IteratorStateMachine(typeof(KNKGJIIMAMO))]
		private IEnumerator LKGIKCHCGFN(NEIBFFKKMCM JDGNBGFHPEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x67ED540", Offset = "0x67EC540", VA = "0x1867ED540")]
		[IteratorStateMachine(typeof(KOKIBEFLGCE))]
		public IEnumerator WaitForFlush(float AOBFBAOECKG = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x67ECFE0", Offset = "0x67EBFE0", VA = "0x1867ECFE0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x67ECF20", Offset = "0x67EBF20", VA = "0x1867ECF20")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime PJONDALPKNN)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67E99B0", Offset = "0x67E89B0", VA = "0x1867E99B0")]
		public static NJMLIPOLJKP Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67E7E30", Offset = "0x67E6E30", VA = "0x1867E7E30")]
		public static GDCAOJIBJJO AccountSelectionPostLoginEvent([NotNull] string FACJLHPPNDN, string IHECLGKBIAJ, bool KKDDNAPDAOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67E8BB0", Offset = "0x67E7BB0", VA = "0x1867E8BB0")]
		public static GDCAOJIBJJO Event([NotNull] string FACJLHPPNDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67EBF70", Offset = "0x67EAF70", VA = "0x1867EBF70")]
		public static GDCAOJIBJJO PreviousSessionEvent([NotNull] string FACJLHPPNDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67E9B50", Offset = "0x67E8B50", VA = "0x1867E9B50")]
		public static GDCAOJIBJJO InitializeEvent(string IHECLGKBIAJ, int HOMDGOIOGPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67ECB30", Offset = "0x67EBB30", VA = "0x1867ECB30")]
		public static GDCAOJIBJJO StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67E8850", Offset = "0x67E7850", VA = "0x1867E8850")]
		public static GDCAOJIBJJO CreateOutOfSessionEvent(string FACJLHPPNDN, bool JCNLGIINNKK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67EB4D0", Offset = "0x67EA4D0", VA = "0x1867EB4D0")]
		public static OBDNBLKJHLC LogOutOfSessionEvent(GDCAOJIBJJO KCNGKGBFGIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67EB250", Offset = "0x67EA250", VA = "0x1867EB250")]
		public void LogEventAsync(AmplitudeAnalyticsEvent PGOLGHCNBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67EB6A0", Offset = "0x67EA6A0", VA = "0x1867EB6A0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent PGOLGHCNBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x67EB7E0", Offset = "0x67EA7E0", VA = "0x1867EB7E0")]
		public void LogSerializedEventAsync(Dictionary<string, object> DPDJHLICKGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67EB390", Offset = "0x67EA390", VA = "0x1867EB390")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage NBPNDAHLNDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67E8AB0", Offset = "0x67E7AB0", VA = "0x1867E8AB0")]
		private void EKMNJLONNPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67E95A0", Offset = "0x67E85A0", VA = "0x1867E95A0")]
		private void HAIHEDHHBEJ(Dictionary<string, object> CIHODCMNLEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67EBC00", Offset = "0x67EAC00", VA = "0x1867EBC00")]
		private void MOPCPHFKIIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x67E8F30", Offset = "0x67E7F30", VA = "0x1867E8F30")]
		private void GELPNKPMFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67E8EA0", Offset = "0x67E7EA0", VA = "0x1867E8EA0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x67E9860", Offset = "0x67E8860", VA = "0x1867E9860")]
		[IteratorStateMachine(typeof(IICFIGHKFHP))]
		private IEnumerator<FAKEPIEMOLB> IHCAEALBPOK(float AOBFBAOECKG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x67E85E0", Offset = "0x67E75E0", VA = "0x1867E85E0")]
		[IteratorStateMachine(typeof(POOFEHCFEKI))]
		private IEnumerator<FAKEPIEMOLB> BIMBOKLPIBC(float AOBFBAOECKG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x67E7D50", Offset = "0x67E6D50", VA = "0x1867E7D50")]
		[IteratorStateMachine(typeof(PGIEEICGCCM))]
		private IEnumerator<FAKEPIEMOLB> AMCPMAEFCNF(BHIEPFOICNK JLBEALEHLIN, int? OCMFFAKOFMF, string HLDBALJPFCB, float AOBFBAOECKG, Action<int> AAMMIBMIBME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x67EBE20", Offset = "0x67EAE20", VA = "0x1867EBE20")]
		private static void PFKINGPJJON(bool CPPHDKEDBPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x67E9370", Offset = "0x67E8370", VA = "0x1867E9370")]
		private EPEDBCONEGO<BBMDIMKAEED<Dictionary<string, object>>> GIHBLCGFPLO(string HLDBALJPFCB, string CNBIECHMOOF, Dictionary<string, object> KNJLHCCMKFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x67E9100", Offset = "0x67E8100", VA = "0x1867E9100")]
		private EPEDBCONEGO<BBMDIMKAEED<List<Dictionary<string, object>>>> GIHBLCGFPLO(string HLDBALJPFCB, string CNBIECHMOOF, List<Dictionary<string, object>> KNJLHCCMKFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x329F000", Offset = "0x329E000", VA = "0x18329F000")]
		private EPEDBCONEGO<BBMDIMKAEED<T>> BBPGIAEAIOH<T>(string LCIPJECHPPJ, string HLDBALJPFCB, string CNBIECHMOOF, T KNJLHCCMKFF, Dictionary<string, object> FNGGCGPIBHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x67EB8C0", Offset = "0x67EA8C0", VA = "0x1867EB8C0")]
		private bool MDNFDGLIOLD(float NPGLKCPEHKE, float AOBFBAOECKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x67E9F00", Offset = "0x67E8F00", VA = "0x1867E9F00")]
		private Dictionary<string, object> JGGLNMKBNLH(string HLDBALJPFCB, Dictionary<string, object> KNJLHCCMKFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x67ED630", Offset = "0x67EC630", VA = "0x1867ED630")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x67E9440", Offset = "0x67E8440", VA = "0x1867E9440")]
		[CompilerGenerated]
		private long HAAIFAHNEKF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x67E7D40", Offset = "0x67E6D40", VA = "0x1867E7D40")]
		[CompilerGenerated]
		private void AGJALAPPEFB(int BAMJBCMJABD)
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
			[Cpp2IlInjected.Address(RVA = "0x67EE970", Offset = "0x67ED970", VA = "0x1867EE970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x67EEA50", Offset = "0x67EDA50", VA = "0x1867EEA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x67EE9B0", Offset = "0x67ED9B0", VA = "0x1867EE9B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x67EEAB0", Offset = "0x67EDAB0", VA = "0x1867EEAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x67EE930", Offset = "0x67ED930", VA = "0x1867EE930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x67EE9F0", Offset = "0x67ED9F0", VA = "0x1867EE9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x8507D0", VA = "0x1808517D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x67EE2C0", Offset = "0x67ED2C0", VA = "0x1867EE2C0")]
		public static GDCAOJIBJJO EAPGIKBOING(string FFOAGBHJNBO, [NotNull] string JNOAFHENCKP, long OEDGDGLNKDI, long FNAMCLANENI, string IHECLGKBIAJ, bool KKDDNAPDAOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x67EE4C0", Offset = "0x67ED4C0", VA = "0x1867EE4C0")]
		public static GDCAOJIBJJO HCHOHBCJJBC(string FFOAGBHJNBO, [NotNull] string JNOAFHENCKP, long OEDGDGLNKDI, long FNAMCLANENI, string IHECLGKBIAJ, long OBJAKEMEJJC, bool KKDDNAPDAOA, string MECODBOFHBH, string OFCABBOJIDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x67EE7A0", Offset = "0x67ED7A0", VA = "0x1867EE7A0")]
		private AmplitudeAnalyticsEvent(string FFOAGBHJNBO, [NotNull] string JNOAFHENCKP, long OEDGDGLNKDI, long FNAMCLANENI, string IHECLGKBIAJ, bool KKDDNAPDAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5A30", Offset = "0x1DD4A30", VA = "0x181DD5A30")]
		public void GJEKMDHIFEL(long CAPCOIMGDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x67EE3C0", Offset = "0x67ED3C0", VA = "0x1867EE3C0", Slot = "5")]
		public override void FDBHBLPNLCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x67EE620", Offset = "0x67ED620", VA = "0x1867EE620", Slot = "6")]
		public override void LAMHBBGCJHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x67EDC80", Offset = "0x67ECC80", VA = "0x1867EDC80", Slot = "4")]
		protected override Dictionary<string, object> BFEOLGPADOE(Dictionary<string, object> GFDPHLKICNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x67EE1B0", Offset = "0x67ED1B0", VA = "0x1867EE1B0")]
		private void DFMKGGMDKPL(string GMFCIHEFPPO, string JJCEIJMGOAB, bool GBHOHPHBBCG = false)
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
			[Cpp2IlInjected.Address(RVA = "0x67F37E0", Offset = "0x67F27E0", VA = "0x1867F37E0")]
			public void LCGGIEPHOKN(Dictionary<string, object> OJKFPJNPKCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
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
			[Cpp2IlInjected.Address(RVA = "0x67FA1E0", Offset = "0x67F91E0", VA = "0x1867FA1E0")]
			public void LCGGIEPHOKN(Dictionary<string, object> PJPDBJFLBML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xB890F0", Offset = "0xB880F0", VA = "0x180B890F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x67EEEC0", Offset = "0x67EDEC0", VA = "0x1867EEEC0")]
		public static NJMLIPOLJKP EAPGIKBOING(string FFOAGBHJNBO, string IHECLGKBIAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x67EF1C0", Offset = "0x67EE1C0", VA = "0x1867EF1C0")]
		protected AmplitudeAnalyticsIdentifyMessage(string FFOAGBHJNBO, string IHECLGKBIAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x67EF010", Offset = "0x67EE010", VA = "0x1867EF010")]
		public Dictionary<string, object> IPDIDCCCKAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x67EEB80", Offset = "0x67EDB80", VA = "0x1867EEB80", Slot = "4")]
		protected virtual Dictionary<string, object> BFEOLGPADOE(Dictionary<string, object> GFDPHLKICNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x67EF0A0", Offset = "0x67EE0A0", VA = "0x1867EF0A0")]
		protected void JPNHFGDFNBM(string GMFCIHEFPPO, Dictionary<string, object> FFGPOFDHJAM, Dictionary<string, object> OGNAFBDKCNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x67EEB10", Offset = "0x67EDB10", VA = "0x1867EEB10")]
		protected void AKKIMLCPMJL(string GMFCIHEFPPO, string JJCEIJMGOAB, Dictionary<string, object> KMCODFKCCMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x67EEF80", Offset = "0x67EDF80", VA = "0x1867EEF80", Slot = "5")]
		public virtual void FDBHBLPNLCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x67EF140", Offset = "0x67EE140", VA = "0x1867EF140", Slot = "6")]
		public virtual void LAMHBBGCJHK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NJMLIPOLJKP : JMJPKJHCMNF<AmplitudeAnalyticsIdentifyMessage, NJMLIPOLJKP>
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public override NJMLIPOLJKP HFMHJIJPJCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage JGHAGELBDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x67F8570", Offset = "0x67F7570", VA = "0x1867F8570")]
	public NJMLIPOLJKP(AmplitudeAnalyticsIdentifyMessage KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x67F84D0", Offset = "0x67F74D0", VA = "0x1867F84D0", Slot = "4")]
	public override void LAMHBBGCJHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GDCAOJIBJJO : JMJPKJHCMNF<AmplitudeAnalyticsEvent, GDCAOJIBJJO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool NABEKJPJKBO;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override GDCAOJIBJJO HFMHJIJPJCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public long EKBLLIAJAFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x67F4EA0", Offset = "0x67F3EA0", VA = "0x1867F4EA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x67F5050", Offset = "0x67F4050", VA = "0x1867F5050")]
	public GDCAOJIBJJO(AmplitudeAnalyticsEvent KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0", Slot = "5")]
	public override AmplitudeAnalyticsEvent JGHAGELBDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x67F4FB0", Offset = "0x67F3FB0", VA = "0x1867F4FB0", Slot = "4")]
	public override void LAMHBBGCJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7700", Offset = "0x2BB6700", VA = "0x182BB7700")]
	public GDCAOJIBJJO JKHPJMLAHIP<T>(string HNKKKCPLLDH, T[] JJCEIJMGOAB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7700", Offset = "0x2BB6700", VA = "0x182BB7700")]
	public GDCAOJIBJJO JKHPJMLAHIP(string HNKKKCPLLDH, string[] JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7450", Offset = "0x2BB6450", VA = "0x182BB7450")]
	public GDCAOJIBJJO JKHPJMLAHIP<T>(string HNKKKCPLLDH, T JJCEIJMGOAB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x67F4F30", Offset = "0x67F3F30", VA = "0x1867F4F30")]
	public GDCAOJIBJJO JKHPJMLAHIP(string HNKKKCPLLDH, long JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x67F4EC0", Offset = "0x67F3EC0", VA = "0x1867F4EC0")]
	public GDCAOJIBJJO JKHPJMLAHIP(string HNKKKCPLLDH, string JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x67F4E70", Offset = "0x67F3E70", VA = "0x1867F4E70")]
	public GDCAOJIBJJO DIALHLLNOME(string HNKKKCPLLDH, object? JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x67F4DD0", Offset = "0x67F3DD0", VA = "0x1867F4DD0")]
	public GDCAOJIBJJO CALIMECDAKF(string HNKKKCPLLDH, string JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x67F4CD0", Offset = "0x67F3CD0", VA = "0x1867F4CD0")]
	private GDCAOJIBJJO BIFJEJEMGND(string HNKKKCPLLDH, object JJCEIJMGOAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LMNBMFMIMAJ : GDCAOJIBJJO
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x67F5050", Offset = "0x67F4050", VA = "0x1867F5050")]
	public LMNBMFMIMAJ(AmplitudeAnalyticsEvent KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x67F7C00", Offset = "0x67F6C00", VA = "0x1867F7C00", Slot = "4")]
	public override void LAMHBBGCJHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class JMJPKJHCMNF<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : JMJPKJHCMNF<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M KKHEHGHPOAA;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract BLDR HFMHJIJPJCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public JMJPKJHCMNF(M KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x411A8C0", Offset = "0x41198C0", VA = "0x18411A8C0")]
	public BLDR HNDFIHKLCDJ(AmplitudeAnalyticsIdentifyMessage.DeviceInfo GEGPACJGLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x411A840", Offset = "0x4119840", VA = "0x18411A840")]
	public BLDR FIKDJHHIEDM(AmplitudeAnalyticsIdentifyMessage.RevenueData BNPFCKGJNKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x411A910", Offset = "0x4119910", VA = "0x18411A910")]
	public BLDR LPLAJFOEKCA(string HNKKKCPLLDH, string JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8170", Offset = "0x2AE7170", VA = "0x182AE8170")]
	public BLDR LPLAJFOEKCA<T>(string HNKKKCPLLDH, T JJCEIJMGOAB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LAMHBBGCJHK();

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x411A890", Offset = "0x4119890", VA = "0x18411A890")]
	internal static string GKMFEKODDIP(string JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x411A740", Offset = "0x4119740", VA = "0x18411A740")]
	private BLDR CENPMCABLHN(string HNKKKCPLLDH, object JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M JGHAGELBDHM();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class OLIJLDECDLM : IAEKAHPMALK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct DJIOLCCOCHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<GDLMGGLPEJF> <>t__builder;

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
		public OLIJLDECDLM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x67F2D40", Offset = "0x67F1D40", VA = "0x1867F2D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x67F3770", Offset = "0x67F2770", VA = "0x1867F3770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient NLFKPIKFOAF;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x67F88C0", Offset = "0x67F78C0", VA = "0x1867F88C0")]
	[ONAOIKEPAJE(IKAJKCKEGIH.None)]
	private static void HKPFBPFEFMO(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x67F8AA0", Offset = "0x67F7AA0", VA = "0x1867F8AA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OLIJLDECDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x67F8930", Offset = "0x67F7930", VA = "0x1867F8930", Slot = "4")]
	[AsyncStateMachine(typeof(DJIOLCCOCHE))]
	public Task<GDLMGGLPEJF> JPCGHEDADNK(string LCIPJECHPPJ, string KNDHCMBCPNC, string CCGLPDDPAIJ, string DFKHLKABPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class LOJPECBGGAF : IAEKAHPMALK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DBJMBHCLEDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TaskCompletionSource<GDLMGGLPEJF> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DBJMBHCLEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x67F0BA0", Offset = "0x67EFBA0", VA = "0x1867F0BA0")]
		internal void JEIIFKBBICK(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct MKFEPLMFIPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<GDLMGGLPEJF> <>t__builder;

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
		private TaskAwaiter<GDLMGGLPEJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x67F7F10", Offset = "0x67F6F10", VA = "0x1867F7F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x67F8460", Offset = "0x67F7460", VA = "0x1867F8460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	[ONAOIKEPAJE(IKAJKCKEGIH.None)]
	private static void NMHELIGOGLH(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	[RecRoom.NoEngine.Common.Preserve]
	public LOJPECBGGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x67F7DB0", Offset = "0x67F6DB0", VA = "0x1867F7DB0", Slot = "4")]
	[AsyncStateMachine(typeof(MKFEPLMFIPG))]
	public Task<GDLMGGLPEJF> JPCGHEDADNK(string LCIPJECHPPJ, string KNDHCMBCPNC, string CCGLPDDPAIJ, string DFKHLKABPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IDKLEGNOIFD
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> DNENCOOLKJO;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x67F50A0", Offset = "0x67F40A0", VA = "0x1867F50A0")]
	internal static bool JKHFICIPJLA(string GMFCIHEFPPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface IAEKAHPMALK
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GDLMGGLPEJF> JPCGHEDADNK(string LCIPJECHPPJ, string KNDHCMBCPNC, string CCGLPDDPAIJ, string DFKHLKABPBF);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct GDLMGGLPEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly int MPJNGFHGIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly string OHOAJMBBFBD;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0xEB7C80", Offset = "0xEB6C80", VA = "0x180EB7C80")]
	public GDLMGGLPEJF(int MMFMDFHGJDH, string KHGNCDBFOKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum PEGFPLODDOM
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
public class CEPOMCEACHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private long EFMDDMGHFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private GDCAOJIBJJO HFEAGLEDNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool LEDKEDFKOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float BAEINIOONDM;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x67F0A10", Offset = "0x67EFA10", VA = "0x1867F0A10")]
	public CEPOMCEACHC(string BOMMOGKIKLP, float BAEINIOONDM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x29962C0", Offset = "0x29952C0", VA = "0x1829962C0")]
	public void JKHPJMLAHIP<T>(string HNKKKCPLLDH, T JJCEIJMGOAB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x67F0880", Offset = "0x67EF880", VA = "0x1867F0880")]
	public void JKHPJMLAHIP(string HNKKKCPLLDH, string JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x67F0680", Offset = "0x67EF680", VA = "0x1867F0680")]
	public void BAEGPCNEGFA(string DFOIDEDBEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x67F0770", Offset = "0x67EF770", VA = "0x1867F0770")]
	public void EKIEFIHNOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x67F0900", Offset = "0x67EF900", VA = "0x1867F0900")]
	private void NALMPNNGLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x67F0830", Offset = "0x67EF830", VA = "0x1867F0830")]
	private bool IOHLDJILHNO()
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
		public enum JBHHHEEGDJA
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
		private JBHHHEEGDJA parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public JBHHHEEGDJA Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x9ABFE0", Offset = "0x9AAFE0", VA = "0x1809ABFE0")]
			get
			{
				return default(JBHHHEEGDJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xA68730", Offset = "0xA67730", VA = "0x180A68730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x67FA350", Offset = "0x67F9350", VA = "0x1867FA350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class OAAOGPMFLKL : ADPMCNIDIED, HDPODJECOBG
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void IOMGBPHJMGJ(BEDPKJBGBCH KAJNKNDFKFE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly CILDNOOOEME GDBAHMBJMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly IOMGBPHJMGJ DMBPNAHCCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string KEFOLMBIECO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string NDBPPLAFCON
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1329330", Offset = "0x1328330", VA = "0x181329330", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool KANJMMONKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x67F8810", Offset = "0x67F7810", VA = "0x1867F8810", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IFPBKBCEPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x67F8830", Offset = "0x67F7830", VA = "0x1867F8830", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<string> CPGPLEHKOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1329400", Offset = "0x1328400", VA = "0x181329400", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x67F8850", Offset = "0x67F7850", VA = "0x1867F8850")]
	public OAAOGPMFLKL(CILDNOOOEME IOPKIGDDBDF, string MEBINPBKMIC, [Optional] IOMGBPHJMGJ BPKIDDLAFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D39A20", Offset = "0x2D38A20", VA = "0x182D39A20", Slot = "8")]
	public T MKHPGHPCCLG<T>(string GMFCIHEFPPO, T KCDEJIJHLPJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class DHONDOJMCIO : NLFAAHGJLCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct EDGJAOICLJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public BDLIBGOKKJO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public DHONDOJMCIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x67F3960", Offset = "0x67F2960", VA = "0x1867F3960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x67F4030", Offset = "0x67F3030", VA = "0x1867F4030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct PCMFLJAAPDI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x67F9450", Offset = "0x67F8450", VA = "0x1867F9450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x67F9660", Offset = "0x67F8660", VA = "0x1867F9660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct AENEOPMNOPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public BDLIBGOKKJO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public DHONDOJMCIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x67E7880", Offset = "0x67E6880", VA = "0x1867E7880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x67E7CE0", Offset = "0x67E6CE0", VA = "0x1867E7CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct FBAJIAHDAFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public DHONDOJMCIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public BDLIBGOKKJO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x67F4090", Offset = "0x67F3090", VA = "0x1867F4090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x67F4460", Offset = "0x67F3460", VA = "0x1867F4460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly IReadOnlyDictionary<string, ELGBLJAAIBB> GDKDGAIBEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool PEDMJLCCKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool FCLIGKENJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private TaskCompletionSource<bool> JNJPIAGMHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private TaskCompletionSource<bool> HPCOPCOKIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private MBEHHOMPLIO IGDCMHOCGEJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Task HBKGNGFIKHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x67F1330", Offset = "0x67F0330", VA = "0x1867F1330", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool PBNPHADIJBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8A3710", Offset = "0x8A2710", VA = "0x1808A3710", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KNOJPEFAHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xC5CD80", Offset = "0xC5BD80", VA = "0x180C5CD80", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string IIBNDGFBGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x67F16E0", Offset = "0x67F06E0", VA = "0x1867F16E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public PALIMLOJGOG JFOKPFCLMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x67F1300", Offset = "0x67F0300", VA = "0x1867F1300", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MDLNOKKAAFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x67F20F0", Offset = "0x67F10F0", VA = "0x1867F20F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x67F1A90", Offset = "0x67F0A90", VA = "0x1867F1A90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LLIMOBHJDND
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x67F1EA0", Offset = "0x67F0EA0", VA = "0x1867F1EA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x67F16F0", Offset = "0x67F06F0", VA = "0x1867F16F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action PPEMOJEKLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x67F1C30", Offset = "0x67F0C30", VA = "0x1867F1C30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x67F2A70", Offset = "0x67F1A70", VA = "0x1867F2A70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<BEDPKJBGBCH> ADOKJHLNHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x67F19E0", Offset = "0x67F09E0", VA = "0x1867F19E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x67F1210", Offset = "0x67F0210", VA = "0x1867F1210", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x67F1D80", Offset = "0x67F0D80", VA = "0x1867F1D80", Slot = "12")]
	[AsyncStateMachine(typeof(EDGJAOICLJO))]
	public Task LFNNOPDGNGK(string CELLCBFHIHM, [Optional] BDLIBGOKKJO KPACPHOFLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x67F1CD0", Offset = "0x67F0CD0", VA = "0x1867F1CD0", Slot = "23")]
	[AsyncStateMachine(typeof(PCMFLJAAPDI))]
	public Task KAICENFOACA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x67F1B30", Offset = "0x67F0B30", VA = "0x1867F1B30", Slot = "18")]
	[AsyncStateMachine(typeof(AENEOPMNOPA))]
	public Task JADJOFPGFCP(BDLIBGOKKJO KPACPHOFLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x67F2050", Offset = "0x67F1050", VA = "0x1867F2050")]
	private void NGHOFLNGNCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x67F0EC0", Offset = "0x67EFEC0", VA = "0x1867F0EC0", Slot = "19")]
	[AsyncStateMachine(typeof(FBAJIAHDAFJ))]
	public Task AFEKBNMMHNO(BDLIBGOKKJO KPACPHOFLCO, Dictionary<string, string> ELOGOIFBOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x67F1790", Offset = "0x67F0790", VA = "0x1867F1790", Slot = "20")]
	public bool GCNAHAJJAHP(string BEFPLJAKGKB, bool LHHMEGGMFMA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x67F1820", Offset = "0x67F0820", VA = "0x1867F1820", Slot = "21")]
	public ADPMCNIDIED GEKDBEJNGMB(string MEBINPBKMIC, bool LHHMEGGMFMA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x67F1520", Offset = "0x67F0520", VA = "0x1867F1520")]
	private CILDNOOOEME EIBDKGCNCPF(string MEBINPBKMIC, bool LHHMEGGMFMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x67F1370", Offset = "0x67F0370", VA = "0x1867F1370", Slot = "22")]
	public IIBKHNNOJPH EHOIBCAMOFG(string PFODBIKAKGE, bool LHHMEGGMFMA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x67F1180", Offset = "0x67F0180", VA = "0x1867F1180")]
	private FMIHEFPIPAF CIFJCDLIFBK(string PFODBIKAKGE, bool LHHMEGGMFMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x67F2190", Offset = "0x67F1190", VA = "0x1867F2190")]
	private LPDCHCAEKNG PGKNDNBEMDA(BDLIBGOKKJO KPACPHOFLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x67F0FD0", Offset = "0x67EFFD0", VA = "0x1867F0FD0")]
	private OMPOCOFIAOO AGIIFJAJIOD(string CELLCBFHIHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x67F1F40", Offset = "0x67F0F40", VA = "0x1867F1F40")]
	private void MBBDLKKJABP(string MEBINPBKMIC, CILDNOOOEME IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x67F2C80", Offset = "0x67F1C80", VA = "0x1867F2C80")]
	public DHONDOJMCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x67F12C0", Offset = "0x67F02C0", VA = "0x1867F12C0")]
	[CompilerGenerated]
	private void DAMINAJNJEP(BEDPKJBGBCH IELHIIDGIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x67F12C0", Offset = "0x67F02C0", VA = "0x1867F12C0")]
	[CompilerGenerated]
	private void KGEFABKCKEN(BEDPKJBGBCH IELHIIDGIMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class LFPLHHOCGHG : NLFAAHGJLCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JPEGCEMPGNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public LFPLHHOCGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public BDLIBGOKKJO userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x67F5500", Offset = "0x67F4500", VA = "0x1867F5500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x67F5CC0", Offset = "0x67F4CC0", VA = "0x1867F5CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DGIHLBFEANM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x67F0C80", Offset = "0x67EFC80", VA = "0x1867F0C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NLFAAHGJLCJ BIOHMFKEGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private TaskCompletionSource<bool> JNJPIAGMHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private TaskCompletionSource<bool> HPCOPCOKIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Task ICNFEKDFHKH;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private NLFAAHGJLCJ FOIAGJPPEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x67F79C0", Offset = "0x67F69C0", VA = "0x1867F79C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool KNOJPEFAHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x67F68D0", Offset = "0x67F58D0", VA = "0x1867F68D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PBNPHADIJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x67F6920", Offset = "0x67F5920", VA = "0x1867F6920", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task HBKGNGFIKHA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x67F6AE0", Offset = "0x67F5AE0", VA = "0x1867F6AE0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string IIBNDGFBGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x67F6D90", Offset = "0x67F5D90", VA = "0x1867F6D90", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public PALIMLOJGOG JFOKPFCLMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x67F6A20", Offset = "0x67F5A20", VA = "0x1867F6A20", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action LLIMOBHJDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x67F7700", Offset = "0x67F6700", VA = "0x1867F7700", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x67F6DE0", Offset = "0x67F5DE0", VA = "0x1867F6DE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action MDLNOKKAAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x67F7920", Offset = "0x67F6920", VA = "0x1867F7920", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x67F7250", Offset = "0x67F6250", VA = "0x1867F7250", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action PPEMOJEKLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x67F74B0", Offset = "0x67F64B0", VA = "0x1867F74B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x67F7A30", Offset = "0x67F6A30", VA = "0x1867F7A30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<BEDPKJBGBCH> ADOKJHLNHAH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x67F71A0", Offset = "0x67F61A0", VA = "0x1867F71A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x67F6970", Offset = "0x67F5970", VA = "0x1867F6970", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x67F7AD0", Offset = "0x67F6AD0", VA = "0x1867F7AD0")]
	[UnityEngine.Scripting.Preserve]
	public LFPLHHOCGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x67F7130", Offset = "0x67F6130", VA = "0x1867F7130")]
	[ONAOIKEPAJE(IKAJKCKEGIH.GameOnly)]
	private static void HDKCILMBALK(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x67F7330", Offset = "0x67F6330", VA = "0x1867F7330")]
	[ONAOIKEPAJE(IKAJKCKEGIH.EditorOnly)]
	private static void JABPAILHLGD(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67F75F0", Offset = "0x67F65F0", VA = "0x1867F75F0", Slot = "12")]
	[AsyncStateMachine(typeof(JPEGCEMPGNE))]
	public Task LFNNOPDGNGK(string CELLCBFHIHM, [Optional] BDLIBGOKKJO KPACPHOFLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x67F73A0", Offset = "0x67F63A0", VA = "0x1867F73A0", Slot = "18")]
	public Task JADJOFPGFCP(BDLIBGOKKJO KPACPHOFLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x67F67B0", Offset = "0x67F57B0", VA = "0x1867F67B0", Slot = "19")]
	public Task AFEKBNMMHNO(BDLIBGOKKJO KPACPHOFLCO, Dictionary<string, string> ELOGOIFBOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x67F6E80", Offset = "0x67F5E80", VA = "0x1867F6E80", Slot = "20")]
	public bool GCNAHAJJAHP(string BEFPLJAKGKB, bool LHHMEGGMFMA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x67F7070", Offset = "0x67F6070", VA = "0x1867F7070", Slot = "21")]
	public ADPMCNIDIED GEKDBEJNGMB(string MEBINPBKMIC, bool LHHMEGGMFMA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x67F6CD0", Offset = "0x67F5CD0", VA = "0x1867F6CD0", Slot = "22")]
	public IIBKHNNOJPH EHOIBCAMOFG(string PFODBIKAKGE, bool LHHMEGGMFMA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x67F7550", Offset = "0x67F6550", VA = "0x1867F7550", Slot = "23")]
	public Task KAICENFOACA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x67F77A0", Offset = "0x67F67A0", VA = "0x1867F77A0")]
	private static void MEEDHKLNCIF(TaskCompletionSource<bool> BCPBDDPEGFL, Task HAMIBBBOHFP, Task IPKKLFONDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x67F6FA0", Offset = "0x67F5FA0", VA = "0x1867F6FA0")]
	[AsyncStateMachine(typeof(DGIHLBFEANM))]
	private static void GDDDLCHPGOD(Task FGPHJGHMKNM, TaskCompletionSource<bool> BCPBDDPEGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x89CCE0", Offset = "0x89BCE0", VA = "0x18089CCE0")]
	[CompilerGenerated]
	private void KPMGLMPEAOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xA51BE0", Offset = "0xA50BE0", VA = "0x180A51BE0")]
	[CompilerGenerated]
	private void HDIOKNDGCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xA4F320", Offset = "0xA4E320", VA = "0x180A4F320")]
	[CompilerGenerated]
	private void DHDHLOCOJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x67F72F0", Offset = "0x67F62F0", VA = "0x1867F72F0")]
	[CompilerGenerated]
	private void ILJMGDOJLDE(BEDPKJBGBCH IELHIIDGIMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class EGALMKPBNOG : IIBKHNNOJPH, HDPODJECOBG
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate void EHNDCFAGBBB(BEDPKJBGBCH KAJNKNDFKFE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly EHNDCFAGBBB DMBPNAHCCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly FMIHEFPIPAF IHOBBGIMGMK;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string NDBPPLAFCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1D97080", Offset = "0x1D96080", VA = "0x181D97080", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5B29EB0", Offset = "0x5B28EB0", VA = "0x185B29EB0")]
	public EGALMKPBNOG(FMIHEFPIPAF HGBAHFEDPPC, [Optional] EHNDCFAGBBB BPKIDDLAFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2A31F60", Offset = "0x2A30F60", VA = "0x182A31F60", Slot = "5")]
	public T MKHPGHPCCLG<T>(string GMFCIHEFPPO, T KCDEJIJHLPJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface HIOFBKMJFLI
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[UsedImplicitly]
public class NPGJNAJKGLM : HIOFBKMJFLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly NGKEJCKEMOO HFOLIPBNALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly List<PGHOAHAKNJC> JJEHBBJGAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly string ANHDIKKAAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly string OKHIKMKAECF;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x67F85C0", Offset = "0x67F75C0", VA = "0x1867F85C0")]
	[ONAOIKEPAJE(NOFONODCPKJ.Root, IKAJKCKEGIH.GameOnly)]
	[UsedImplicitly]
	private static void ACLEMPFHCOI(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x67F8630", Offset = "0x67F7630", VA = "0x1867F8630")]
	[RecRoom.NoEngine.Common.Preserve]
	internal NPGJNAJKGLM([JONIFKKOOAA(null)][NotNull] NGKEJCKEMOO HFOLIPBNALK, [NotNull][JONIFKKOOAA(null)] POPDEMOCHJE GCFLDIFPDBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class OOGKCFOHLNL : NLFAAHGJLCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task HBKGNGFIKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x67F8C60", Offset = "0x67F7C60", VA = "0x1867F8C60", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool KNOJPEFAHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool PBNPHADIJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string IIBNDGFBGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public PALIMLOJGOG JFOKPFCLMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action LLIMOBHJDND
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x67F9270", Offset = "0x67F8270", VA = "0x1867F9270", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x67F8D80", Offset = "0x67F7D80", VA = "0x1867F8D80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action MDLNOKKAAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x67F9310", Offset = "0x67F8310", VA = "0x1867F9310", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x67F8F80", Offset = "0x67F7F80", VA = "0x1867F8F80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action PPEMOJEKLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x67F90B0", Offset = "0x67F80B0", VA = "0x1867F90B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x67F93B0", Offset = "0x67F83B0", VA = "0x1867F93B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<BEDPKJBGBCH> ADOKJHLNHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x67F8ED0", Offset = "0x67F7ED0", VA = "0x1867F8ED0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x67F8BB0", Offset = "0x67F7BB0", VA = "0x1867F8BB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	[RecRoom.NoEngine.Common.Preserve]
	public OOGKCFOHLNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x67F91E0", Offset = "0x67F81E0", VA = "0x1867F91E0", Slot = "12")]
	public Task LFNNOPDGNGK(string CELLCBFHIHM, [Optional] BDLIBGOKKJO KPACPHOFLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x67F9020", Offset = "0x67F8020", VA = "0x1867F9020", Slot = "18")]
	public Task JADJOFPGFCP(BDLIBGOKKJO KPACPHOFLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x67F8B20", Offset = "0x67F7B20", VA = "0x1867F8B20", Slot = "19")]
	public Task AFEKBNMMHNO(BDLIBGOKKJO KPACPHOFLCO, Dictionary<string, string> ELOGOIFBOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "20")]
	public bool GCNAHAJJAHP(string BEFPLJAKGKB, bool LHHMEGGMFMA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x67F8E20", Offset = "0x67F7E20", VA = "0x1867F8E20", Slot = "21")]
	public ADPMCNIDIED GEKDBEJNGMB(string MEBINPBKMIC, bool LHHMEGGMFMA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x67F8CF0", Offset = "0x67F7CF0", VA = "0x1867F8CF0", Slot = "22")]
	public IIBKHNNOJPH EHOIBCAMOFG(string PFODBIKAKGE, bool LHHMEGGMFMA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x67F9150", Offset = "0x67F8150", VA = "0x1867F9150", Slot = "23")]
	public Task KAICENFOACA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class MBEHHOMPLIO : PALIMLOJGOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly LPDCHCAEKNG MFIBOAJEOEP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IReadOnlyDictionary<string, object> PCLOEHIIHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x1329350", Offset = "0x1328350", VA = "0x181329350", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public MBEHHOMPLIO(LPDCHCAEKNG AJPFHLDEOLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface BFJBNCKICPO
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CEPOMCEACHC MLDLEMFGFFG(string BOMMOGKIKLP);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface LFEJBBDAJKP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum ONLHANGGEBI
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	long CEOIFEIJEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string MDLLICHGMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string BEAFJHGOPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool FDDBMKBGPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long MIOENENGPFP();

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MKFBMEINEPG(long OEDGDGLNKDI, bool GBHOHPHBBCG = true);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EOOOAOLFJBB(string PDLLDMABKGP, string PDLJGFPHDBD, string KFMJEGEPAFD);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BGEJHJJNGCE(string PDLLDMABKGP);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HPHJLEICFMJ(string PDLLDMABKGP, string FCHJLCAJOHJ, string OMDLDDPIHKM);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CJKABNBCCOB(string FAFNIBDAFEG, object HEKAALJEGBK, object FBBIGKJLJHG);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NPKGJEFDHOK(ONLHANGGEBI FFLPMGAPGDN, int BHANGKNKGFI, [Optional] HEDDEFDKDDB GNDCFPKLKDK, [Optional] string MICNAMEPOFE, [Optional] string EHELKEOJPOO);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FLILFLGFHAD(HEDDEFDKDDB GNDCFPKLKDK, long JGCILOCJPBE, long GGHONHBHHAJ, int BHMNIGNMNEF, string MICNAMEPOFE, int BHANGKNKGFI);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FIBHLMFIHKP(HEDDEFDKDDB GNDCFPKLKDK, bool ADMMLGCNPFE, [Optional] string EHELKEOJPOO);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FCGKBEPHDIL(HEDDEFDKDDB GNDCFPKLKDK, bool ADMMLGCNPFE, [Optional] string EHELKEOJPOO);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MIBHECEFKGK(HEDDEFDKDDB GNDCFPKLKDK, bool ADMMLGCNPFE, [Optional] string EHELKEOJPOO);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ONDOLLHMCLE(long MFLLPFDNGGL, string KJKNDAKGGME);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface JAEEILPHMEK
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string AFLABGIIIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
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
