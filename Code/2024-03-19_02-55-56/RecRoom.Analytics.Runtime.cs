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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x6041EF0", Offset = "0x6040EF0", VA = "0x186041EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E62F0", Offset = "0x7E52F0", VA = "0x1807E62F0")]
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
		public AmplitudeAnalyticsClient.Settings LOBONDKBNHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HGEONKAENBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7BC460", Offset = "0x7BB460", VA = "0x1807BC460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum OAKJODBKCND
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class GGFPPIGCCOO
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class IMAGAODGCND
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int APKADCHGPPH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> OOALLCEMNCH;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
				public IMAGAODGCND()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class JNIEJEEHDFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
				public JNIEJEEHDFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x603E940", Offset = "0x603D940", VA = "0x18603E940")]
				internal bool GFDGAKCKMHL(IMAGAODGCND item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string OCOKLCCDNLD = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string MOOBDKACMAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<IMAGAODGCND> CCDHHGBOJLF;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? LCHHAMNLKOE
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x603D790", Offset = "0x603C790", VA = "0x18603D790")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x603E650", Offset = "0x603D650", VA = "0x18603E650")]
			internal GGFPPIGCCOO(string PFNKEJMINFK, string MJCHNGDAIMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x603D5E0", Offset = "0x603C5E0", VA = "0x18603D5E0")]
			public int APENKIKNMGP([Optional] int? GOPINKDMLPM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x603D960", Offset = "0x603C960", VA = "0x18603D960")]
			public List<Dictionary<string, object>> HGEBIOMCDCC(int LAGEBIEDNOG, int? GOPINKDMLPM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x603E310", Offset = "0x603D310", VA = "0x18603E310")]
			public void LCPKKDKJLFB(AmplitudeAnalyticsIdentifyMessage FGOCJODIEMI, bool PBEPODNFFEB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x603E3B0", Offset = "0x603D3B0", VA = "0x18603E3B0")]
			public void LCPKKDKJLFB(Dictionary<string, object> FGOCJODIEMI, bool PBEPODNFFEB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x603E4C0", Offset = "0x603D4C0", VA = "0x18603E4C0")]
			public void NEEMIPJCGJE(params Dictionary<string, object>[] IAGHJNPPBNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x603D390", Offset = "0x603C390", VA = "0x18603D390")]
			public void AAACMHLAGKC(List<Dictionary<string, object>> DGLIEDFLOKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x603DBD0", Offset = "0x603CBD0", VA = "0x18603DBD0")]
			private void IGGGKLPIOBP(Dictionary<string, object> FGOCJODIEMI, bool PBEPODNFFEB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x603DCE0", Offset = "0x603CCE0", VA = "0x18603DCE0")]
			public void KJFFOIKJAMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x603DF20", Offset = "0x603CF20", VA = "0x18603DF20")]
			private void LAAHAOMLMBC([Optional] string AEKFAKLNBJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x603D830", Offset = "0x603C830", VA = "0x18603D830")]
			private static string GENPDAFEKGA(string CFJDHAGGAJO, string IPAJBJLLPIJ)
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
			[Cpp2IlInjected.Address(RVA = "0x6044550", Offset = "0x6043550", VA = "0x186044550")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct PAMNELBOCCA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int LLIBNLCBMFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string HCICOBODMOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T KKCDKJOHHNA;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class FMJGHBIPCFC : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private LLCDBDMNGNA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
			[DebuggerHidden]
			public FMJGHBIPCFC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x603CB80", Offset = "0x603BB80", VA = "0x18603CB80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x603D340", Offset = "0x603C340", VA = "0x18603D340", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class LILMFPGOPPN : IEnumerator<object>, IEnumerator, IDisposable
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
			public KEPNMKDFAKI quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
			[DebuggerHidden]
			public LILMFPGOPPN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x60406C0", Offset = "0x603F6C0", VA = "0x1860406C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x60407D0", Offset = "0x603F7D0", VA = "0x1860407D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class DHAKGIJLNCG : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
			[DebuggerHidden]
			public DHAKGIJLNCG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x603B070", Offset = "0x603A070", VA = "0x18603B070", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x603B1E0", Offset = "0x603A1E0", VA = "0x18603B1E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class NEFNMGEODPG : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private LLCDBDMNGNA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
			[DebuggerHidden]
			public NEFNMGEODPG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6041BE0", Offset = "0x6040BE0", VA = "0x186041BE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6041E60", Offset = "0x6040E60", VA = "0x186041E60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class ALOLLHCEDGG : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private LLCDBDMNGNA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
			[DebuggerHidden]
			public ALOLLHCEDGG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x60335E0", Offset = "0x60325E0", VA = "0x1860335E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6033870", Offset = "0x6032870", VA = "0x186033870", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class FBPIFJIMPOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public GGFPPIGCCOO cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public FBPIFJIMPOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x603C860", Offset = "0x603B860", VA = "0x18603C860")]
			internal void ODMNEPEBICD(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x603C410", Offset = "0x603B410", VA = "0x18603C410")]
			internal void FFKEFBDMOCN(PAMNELBOCCA<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class LANJIHBHBHG : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private LLCDBDMNGNA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public GGFPPIGCCOO cache;

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
			private FBPIFJIMPOM <>8__1;

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
			private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
			[DebuggerHidden]
			public LANJIHBHBHG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x603FDC0", Offset = "0x603EDC0", VA = "0x18603FDC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6040670", Offset = "0x603F670", VA = "0x186040670", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class MGJKNKDIJBI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public MGJKNKDIJBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3ECC830", Offset = "0x3ECB830", VA = "0x183ECC830")]
			internal PAMNELBOCCA<T> DAAJDPGOOCK(DPMMJBFIGHE postResponse)
			{
				return default(PAMNELBOCCA<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class PAAEKCBJLCO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public PAAEKCBJLCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3ECC830", Offset = "0x3ECB830", VA = "0x183ECC830")]
			internal PAMNELBOCCA<T> OLPBBELKPOB(DPMMJBFIGHE postResponse)
			{
				return default(PAMNELBOCCA<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KPFLOLMDIGJ DDOHEKCLKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<JNLIAFJCIFC> HEPKFEMINPD;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string PAJPBOGECNO = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string BNLDJOFMHDI = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string AMIFEGLOPHF = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int BGHKEILIFAI = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int JIMKCFHMNEH = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int IOPPJEJIMBA = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float HFKGPBIADNG = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long JLELFAMDGBO = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string CNMJIAJPMEK = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string FLDFLAINLNI = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool NKAJCCPJBEA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool MKPNPFCJCNI;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int GHKNGGCOEKN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int KKPIHNPDKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private BHCMNCOOAPP IOPDJBDNJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private NJGFEFLGJII NDNKGLMIODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private AAKKNIPGGAI DELMPFOPDHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool HCCPKPIINPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float JMAHHGJCEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float JKEMGOKBAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int FHFPIKFKKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int HIILBCPCKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? FJLGAGFNMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? AOLEIIEKGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long NPPCPNDMKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string ELKLCDFMONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool DIHONOMGFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long GFKEIDKOIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string HOBFOBBIFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string DCBEKIOJGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> CMNAFOKBALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private OAKJODBKCND CCNOEIOONFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int NAKFFCIPNKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int HPEJPPOJNAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float KAGEFECHKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool PNJPNEJFFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool FHBNHLLPMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private GGFPPIGCCOO PJLMHPIBJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private GGFPPIGCCOO LFENPNFCKIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private GGFPPIGCCOO MHBPEJNJFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> CLFIFKCLNLO;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo FOKJLDDAEMG;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string ADMGLBLJJGO;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string ICAMPHPIGBH = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string MBJLJHOGOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string FKONNALLOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string NCIAHNKNGJL;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private KPFLOLMDIGJ JMEMGLMEGEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6034080", Offset = "0x6033080", VA = "0x186034080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private JNLIAFJCIFC DGLAJAIIBAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6036050", Offset = "0x6035050", VA = "0x186036050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int ACANCIOBBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6033EA0", Offset = "0x6032EA0", VA = "0x186033EA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long EMOEKFHPNOE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6039460", Offset = "0x6038460", VA = "0x186039460")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6039580", Offset = "0x6038580", VA = "0x186039580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string AJPIOBIDKNO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6039400", Offset = "0x6038400", VA = "0x186039400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string GNNBGIDJIMA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6039430", Offset = "0x6038430", VA = "0x186039430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LFABBMPAAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8E4410", Offset = "0x8E3410", VA = "0x1808E4410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8E4860", Offset = "0x8E3860", VA = "0x1808E4860")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? MNHGJCPEKOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x905720", Offset = "0x904720", VA = "0x180905720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6039570", Offset = "0x6038570", VA = "0x186039570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JNKIIEEPJJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF91BF0", Offset = "0xF90BF0", VA = "0x180F91BF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xFD6F30", Offset = "0xFD5F30", VA = "0x180FD6F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool DCJECBCFNFL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6039300", Offset = "0x6038300", VA = "0x186039300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> HAIBDFKCDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6039240", Offset = "0x6038240", VA = "0x186039240")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x60394B0", Offset = "0x60384B0", VA = "0x1860394B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6033A30", Offset = "0x6032A30", VA = "0x186033A30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60360A0", Offset = "0x60350A0", VA = "0x1860360A0")]
		private void JHJHCPDAGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6038820", Offset = "0x6037820", VA = "0x186038820")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60379B0", Offset = "0x60369B0", VA = "0x1860379B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6038BC0", Offset = "0x6037BC0", VA = "0x186038BC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6037AC0", Offset = "0x6036AC0", VA = "0x186037AC0")]
		public NCJNDIGDIHF PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6035D10", Offset = "0x6034D10", VA = "0x186035D10")]
		[IteratorStateMachine(typeof(FMJGHBIPCFC))]
		public IEnumerator<LLCDBDMNGNA> Initialize(AmplitudeAnalyticsEvent KLNLOKGMKAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6038B00", Offset = "0x6037B00", VA = "0x186038B00")]
		public void UpdateLastKnownInteractionCategory(string MCNFFFHBDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6038A10", Offset = "0x6037A10", VA = "0x186038A10")]
		public void UpdateLastAliveTime(float HBFOIDKFIJC = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60378F0", Offset = "0x60368F0", VA = "0x1860378F0")]
		private NCJNDIGDIHF OELHFHNCLHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60367E0", Offset = "0x60357E0", VA = "0x1860367E0")]
		private NCJNDIGDIHF LDACEPDPFPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6038270", Offset = "0x6037270", VA = "0x186038270")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6036750", Offset = "0x6035750", VA = "0x186036750")]
		[IteratorStateMachine(typeof(LILMFPGOPPN))]
		private IEnumerator KKEAPGLMOAG(KEPNMKDFAKI LLMNDOIHEPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6038E50", Offset = "0x6037E50", VA = "0x186038E50")]
		[IteratorStateMachine(typeof(DHAKGIJLNCG))]
		public IEnumerator WaitForFlush(float ONBAFMEFHPF = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x60388F0", Offset = "0x60378F0", VA = "0x1860388F0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6038830", Offset = "0x6037830", VA = "0x186038830")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime CJLMIDOLMHB)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6035880", Offset = "0x6034880", VA = "0x186035880")]
		public static HGJOJHMBJPA Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60338C0", Offset = "0x60328C0", VA = "0x1860338C0")]
		public static OPNLCBJBIJH AccountSelectionPostLoginEvent([NotNull] string CLJKFGBMJBF, string GGOPKPCEMFD, bool AIEPONDJFEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60350C0", Offset = "0x60340C0", VA = "0x1860350C0")]
		public static OPNLCBJBIJH Event([NotNull] string CLJKFGBMJBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6037B00", Offset = "0x6036B00", VA = "0x186037B00")]
		public static OPNLCBJBIJH PreviousSessionEvent([NotNull] string CLJKFGBMJBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6035A30", Offset = "0x6034A30", VA = "0x186035A30")]
		public static OPNLCBJBIJH InitializeEvent(string GGOPKPCEMFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6038430", Offset = "0x6037430", VA = "0x186038430")]
		public static OPNLCBJBIJH StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x60340F0", Offset = "0x60330F0", VA = "0x1860340F0")]
		public static OPNLCBJBIJH CreateOutOfSessionEvent(string CLJKFGBMJBF, bool IJDDFJBPKGA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6036EE0", Offset = "0x6035EE0", VA = "0x186036EE0")]
		public static NCJNDIGDIHF LogOutOfSessionEvent(OPNLCBJBIJH DPJNPINOEJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6036C60", Offset = "0x6035C60", VA = "0x186036C60")]
		public void LogEventAsync(AmplitudeAnalyticsEvent BPBMGOEMEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x60371D0", Offset = "0x60361D0", VA = "0x1860371D0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent BPBMGOEMEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6037310", Offset = "0x6036310", VA = "0x186037310")]
		public void LogSerializedEventAsync(Dictionary<string, object> NFHJHDJAABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6036DA0", Offset = "0x6035DA0", VA = "0x186036DA0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage BIGLNKAMLPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6036AD0", Offset = "0x6035AD0", VA = "0x186036AD0")]
		private void LDJFHGKOPID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6035DA0", Offset = "0x6034DA0", VA = "0x186035DA0")]
		private void JCBADJDHEII(Dictionary<string, object> JBFMHMOENBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60373F0", Offset = "0x60363F0", VA = "0x1860373F0")]
		private void MBOLENHAIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6035550", Offset = "0x6034550", VA = "0x186035550")]
		private void GGPCEBICHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x60353C0", Offset = "0x60343C0", VA = "0x1860353C0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6035020", Offset = "0x6034020", VA = "0x186035020")]
		[IteratorStateMachine(typeof(NEFNMGEODPG))]
		private IEnumerator<LLCDBDMNGNA> EIGEOJHJAFM(float ONBAFMEFHPF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6036BD0", Offset = "0x6035BD0", VA = "0x186036BD0")]
		[IteratorStateMachine(typeof(ALOLLHCEDGG))]
		private IEnumerator<LLCDBDMNGNA> LNFDDCGLCLD(float ONBAFMEFHPF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6035450", Offset = "0x6034450", VA = "0x186035450")]
		[IteratorStateMachine(typeof(LANJIHBHBHG))]
		private IEnumerator<LLCDBDMNGNA> GGJIDFFIAIA(GGFPPIGCCOO AMEJCPPGMKJ, int? GOPINKDMLPM, string BPLNOILGLFL, string CDNCKLMGBON, float ONBAFMEFHPF, Action<int> LMAOAIALPJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6036640", Offset = "0x6035640", VA = "0x186036640")]
		private static void KCONIIKICCA(bool KGCHDNBLKLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x60374E0", Offset = "0x60364E0", VA = "0x1860374E0")]
		private BJNFJNCLHKJ<PAMNELBOCCA<Dictionary<string, object>>> NOAIJOFJJDG(string BPLNOILGLFL, string CDNCKLMGBON, string GCGHDDIEDMB, string MMECIAMKIBE, Dictionary<string, object> KKCDKJOHHNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6037610", Offset = "0x6036610", VA = "0x186037610")]
		private BJNFJNCLHKJ<PAMNELBOCCA<List<Dictionary<string, object>>>> NOAIJOFJJDG(string BPLNOILGLFL, string CDNCKLMGBON, string GCGHDDIEDMB, string MMECIAMKIBE, List<Dictionary<string, object>> KKCDKJOHHNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2DAA670", Offset = "0x2DA9670", VA = "0x182DAA670")]
		private BJNFJNCLHKJ<PAMNELBOCCA<T>> FMDEFHLHOHE<T>(string BPLNOILGLFL, string CDNCKLMGBON, string MMECIAMKIBE, T KKCDKJOHHNA, Dictionary<string, object> BCIBKMMPDHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2DAA320", Offset = "0x2DA9320", VA = "0x182DAA320")]
		private BJNFJNCLHKJ<PAMNELBOCCA<T>> BCDNEKJGABD<T>(string BPLNOILGLFL, string CDNCKLMGBON, string GCGHDDIEDMB, T KKCDKJOHHNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6037A70", Offset = "0x6036A70", VA = "0x186037A70")]
		private bool PNNFPOCCHAO(float GBFOIDHNKHH, float ONBAFMEFHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6034350", Offset = "0x6033350", VA = "0x186034350")]
		private Dictionary<string, object> DBEKLONMFCI(string CDNCKLMGBON, Dictionary<string, object> KKCDKJOHHNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6038F40", Offset = "0x6037F40", VA = "0x186038F40")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6035720", Offset = "0x6034720", VA = "0x186035720")]
		[CompilerGenerated]
		private long HODMJDCCJBE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x60350B0", Offset = "0x60340B0", VA = "0x1860350B0")]
		[CompilerGenerated]
		private void ELPGKGBGKKM(int ILAAJFMCHEN)
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
			[Cpp2IlInjected.Address(RVA = "0x603A2E0", Offset = "0x60392E0", VA = "0x18603A2E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x603A3C0", Offset = "0x60393C0", VA = "0x18603A3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x603A320", Offset = "0x6039320", VA = "0x18603A320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x603A420", Offset = "0x6039420", VA = "0x18603A420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x603A2A0", Offset = "0x60392A0", VA = "0x18603A2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x603A360", Offset = "0x6039360", VA = "0x18603A360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7C3250", Offset = "0x7C2250", VA = "0x1807C3250")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6039F00", Offset = "0x6038F00", VA = "0x186039F00")]
		public static OPNLCBJBIJH OOGKEDOOOJC(string PENODPCCLDA, [NotNull] string FOFCKMLBHLJ, long HEPBCOGEGKH, long POEOOMFBMMB, string GGOPKPCEMFD, bool AIEPONDJFEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6039760", Offset = "0x6038760", VA = "0x186039760")]
		public static OPNLCBJBIJH KCAKJOEAOOG(string PENODPCCLDA, [NotNull] string FOFCKMLBHLJ, long HEPBCOGEGKH, long POEOOMFBMMB, string GGOPKPCEMFD, long NOCALMIAOGB, bool AIEPONDJFEB, string HOBLLFLPDGM, string HJKCAGPBOKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x603A110", Offset = "0x6039110", VA = "0x18603A110")]
		private AmplitudeAnalyticsEvent(string PENODPCCLDA, [NotNull] string FOFCKMLBHLJ, long HEPBCOGEGKH, long POEOOMFBMMB, string GGOPKPCEMFD, bool AIEPONDJFEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA870", Offset = "0x1AA9870", VA = "0x181AAA870")]
		public void OFMFNDJELBL(long IDCHGKIPPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x603A000", Offset = "0x6039000", VA = "0x18603A000", Slot = "5")]
		public override void PBBGPPJKAFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x60395E0", Offset = "0x60385E0", VA = "0x1860395E0", Slot = "6")]
		public override void BAJKHODFPOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x60399D0", Offset = "0x60389D0", VA = "0x1860399D0", Slot = "4")]
		protected override Dictionary<string, object> LLFBMJODMBO(Dictionary<string, object> KJALJKIOCIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x60398C0", Offset = "0x60388C0", VA = "0x1860398C0")]
		private void LFJNLABPMDK(string IPAJBJLLPIJ, string CFJDHAGGAJO, bool OKDAIEGFKEH = false)
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
			[Cpp2IlInjected.Address(RVA = "0x603B230", Offset = "0x603A230", VA = "0x18603B230")]
			public void LFNMGLJKCIE(Dictionary<string, object> EELPJKNIHHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x60441E0", Offset = "0x60431E0", VA = "0x1860441E0")]
			public void LFNMGLJKCIE(Dictionary<string, object> EHNELDFCPBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x944000", Offset = "0x943000", VA = "0x180944000")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7BC250", Offset = "0x7BB250", VA = "0x1807BC250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x603A9F0", Offset = "0x60399F0", VA = "0x18603A9F0")]
		public static HGJOJHMBJPA OOGKEDOOOJC(string PENODPCCLDA, string GGOPKPCEMFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x603AB40", Offset = "0x6039B40", VA = "0x18603AB40")]
		protected AmplitudeAnalyticsIdentifyMessage(string PENODPCCLDA, string GGOPKPCEMFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x603A580", Offset = "0x6039580", VA = "0x18603A580")]
		public Dictionary<string, object> HEFCEOKPNEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x603A6B0", Offset = "0x60396B0", VA = "0x18603A6B0", Slot = "4")]
		protected virtual Dictionary<string, object> LLFBMJODMBO(Dictionary<string, object> KJALJKIOCIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x603A610", Offset = "0x6039610", VA = "0x18603A610")]
		protected void IAGGDDJCABP(string IPAJBJLLPIJ, Dictionary<string, object> IBEGNFKFHAI, Dictionary<string, object> MNIDDANKPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x603A510", Offset = "0x6039510", VA = "0x18603A510")]
		protected void DKDCNLKOHNE(string IPAJBJLLPIJ, string CFJDHAGGAJO, Dictionary<string, object> ICPFAJGFHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x603AAB0", Offset = "0x6039AB0", VA = "0x18603AAB0", Slot = "5")]
		public virtual void PBBGPPJKAFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x603A480", Offset = "0x6039480", VA = "0x18603A480", Slot = "6")]
		public virtual void BAJKHODFPOK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HGJOJHMBJPA : KAMPAJJGLHH<AmplitudeAnalyticsIdentifyMessage, HGJOJHMBJPA>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override HGJOJHMBJPA DJGIPGDMDDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage PDHDHAGICPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x603E8F0", Offset = "0x603D8F0", VA = "0x18603E8F0")]
	public HGJOJHMBJPA(AmplitudeAnalyticsIdentifyMessage DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x603E840", Offset = "0x603D840", VA = "0x18603E840", Slot = "4")]
	public override void BAJKHODFPOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OPNLCBJBIJH : KAMPAJJGLHH<AmplitudeAnalyticsEvent, OPNLCBJBIJH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool LPKCPCIHGLF;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override OPNLCBJBIJH DJGIPGDMDDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long NIKOAFECCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x60426F0", Offset = "0x60416F0", VA = "0x1860426F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x603B020", Offset = "0x603A020", VA = "0x18603B020")]
	public OPNLCBJBIJH(AmplitudeAnalyticsEvent DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "5")]
	public override AmplitudeAnalyticsEvent PDHDHAGICPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6042650", Offset = "0x6041650", VA = "0x186042650", Slot = "4")]
	public override void BAJKHODFPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2920730", Offset = "0x291F730", VA = "0x182920730")]
	public OPNLCBJBIJH PLENMPLKNGA<T>(string DFALMLPAKJC, T[] CFJDHAGGAJO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2920730", Offset = "0x291F730", VA = "0x182920730")]
	public OPNLCBJBIJH PLENMPLKNGA(string DFALMLPAKJC, string[] CFJDHAGGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2920480", Offset = "0x291F480", VA = "0x182920480")]
	public OPNLCBJBIJH PLENMPLKNGA<T>(string DFALMLPAKJC, T CFJDHAGGAJO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x60428E0", Offset = "0x60418E0", VA = "0x1860428E0")]
	public OPNLCBJBIJH PLENMPLKNGA(string DFALMLPAKJC, long CFJDHAGGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6042960", Offset = "0x6041960", VA = "0x186042960")]
	public OPNLCBJBIJH PLENMPLKNGA(string DFALMLPAKJC, string CFJDHAGGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x60428B0", Offset = "0x60418B0", VA = "0x1860428B0")]
	public OPNLCBJBIJH NPMCALDNABK(string DFALMLPAKJC, object? CFJDHAGGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6042810", Offset = "0x6041810", VA = "0x186042810")]
	public OPNLCBJBIJH NALNLKFGOMA(string DFALMLPAKJC, string CFJDHAGGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6042710", Offset = "0x6041710", VA = "0x186042710")]
	private OPNLCBJBIJH ILMJDFEKOOG(string DFALMLPAKJC, object CFJDHAGGAJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CHJOHDMDBGC : OPNLCBJBIJH
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x603B020", Offset = "0x603A020", VA = "0x18603B020")]
	public CHJOHDMDBGC(AmplitudeAnalyticsEvent DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x603AE70", Offset = "0x6039E70", VA = "0x18603AE70", Slot = "4")]
	public override void BAJKHODFPOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class KAMPAJJGLHH<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : KAMPAJJGLHH<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M DFJKCKBFLAD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR DJGIPGDMDDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public KAMPAJJGLHH(M DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7210", Offset = "0x3BE6210", VA = "0x183BE7210")]
	public BLDR CDOCJKPEICL(AmplitudeAnalyticsIdentifyMessage.DeviceInfo AJKENPAFHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3BE71C0", Offset = "0x3BE61C0", VA = "0x183BE71C0")]
	public BLDR CBFPOLPFBKN(AmplitudeAnalyticsIdentifyMessage.RevenueData AHADEFCFBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7390", Offset = "0x3BE6390", VA = "0x183BE7390")]
	public BLDR PIFEALCLFHJ(string DFALMLPAKJC, string CFJDHAGGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x25B60B0", Offset = "0x25B50B0", VA = "0x1825B60B0")]
	public BLDR PIFEALCLFHJ<T>(string DFALMLPAKJC, T CFJDHAGGAJO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BAJKHODFPOK();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7260", Offset = "0x3BE6260", VA = "0x183BE7260")]
	internal static string LIOELAHPMMF(string CFJDHAGGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7290", Offset = "0x3BE6290", VA = "0x183BE7290")]
	private BLDR PDCPIOAHNIL(string DFALMLPAKJC, object CFJDHAGGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M PDHDHAGICPC();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class KEMMCCFKPNP : BHCMNCOOAPP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct KEAFCMGGBMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<DPMMJBFIGHE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public KEMMCCFKPNP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x603ECD0", Offset = "0x603DCD0", VA = "0x18603ECD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x603F570", Offset = "0x603E570", VA = "0x18603F570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct EEBMIKCHAOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<DPMMJBFIGHE> <>t__builder;

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
		public KEMMCCFKPNP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x603B3B0", Offset = "0x603A3B0", VA = "0x18603B3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x603BDE0", Offset = "0x603ADE0", VA = "0x18603BDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient IOGJMGOIPKF;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x603F750", Offset = "0x603E750", VA = "0x18603F750")]
	[KEBGMDILACL(JMIJNHPDBML.None)]
	private static void IAKNJKNLHOC(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x603F910", Offset = "0x603E910", VA = "0x18603F910")]
	[RecRoom.NoEngine.Common.Preserve]
	public KEMMCCFKPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x603F7C0", Offset = "0x603E7C0", VA = "0x18603F7C0", Slot = "4")]
	[AsyncStateMachine(typeof(KEAFCMGGBMC))]
	public Task<DPMMJBFIGHE> NOAIJOFJJDG(string BPLNOILGLFL, Dictionary<string, string> FKKBICBDJMP, bool KJEEDDGLMBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x603F5E0", Offset = "0x603E5E0", VA = "0x18603F5E0", Slot = "5")]
	[AsyncStateMachine(typeof(EEBMIKCHAOC))]
	public Task<DPMMJBFIGHE> EOFAKAJGNJP(string BPLNOILGLFL, string BDGJACDDIBK, string ABJFCPPOMHG, string MIILICJMMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MLGICBGLDBK
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> BBEOKHBKAAD;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6040E70", Offset = "0x603FE70", VA = "0x186040E70")]
	internal static bool FEAMNKPBKPL(string IPAJBJLLPIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BHCMNCOOAPP
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DPMMJBFIGHE> NOAIJOFJJDG(string BPLNOILGLFL, Dictionary<string, string> FKKBICBDJMP, bool KJEEDDGLMBI = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DPMMJBFIGHE> EOFAKAJGNJP(string BPLNOILGLFL, string BDGJACDDIBK, string ABJFCPPOMHG, string MIILICJMMFA);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DPMMJBFIGHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int IDIAABOKJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string FLMGGAADKDN;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xC44CC0", Offset = "0xC43CC0", VA = "0x180C44CC0")]
	public DPMMJBFIGHE(int LLIBNLCBMFN, string HCICOBODMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum GDNMBEMNGDP
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
public class AKNCIHDOFJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long AJHICDLGKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private OPNLCBJBIJH HGIENFLIPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool FFNKGJNGHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float DCKPPPHHPFB;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6033450", Offset = "0x6032450", VA = "0x186033450")]
	public AKNCIHDOFJG(string NGDPEONIODF, float DCKPPPHHPFB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D863B0", Offset = "0x2D853B0", VA = "0x182D863B0")]
	public void PLENMPLKNGA<T>(string DFALMLPAKJC, T CFJDHAGGAJO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x60333D0", Offset = "0x60323D0", VA = "0x1860333D0")]
	public void PLENMPLKNGA(string DFALMLPAKJC, string CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6033290", Offset = "0x6032290", VA = "0x186033290")]
	public void IFKHCEOAMBJ(string GIOLNEGOMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x60331D0", Offset = "0x60321D0", VA = "0x1860331D0")]
	public void FIMDMAOEMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x60330C0", Offset = "0x60320C0", VA = "0x1860330C0")]
	private void EJDOOOMBHHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6033380", Offset = "0x6032380", VA = "0x186033380")]
	private bool OOCNMKAEEHH()
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
		public enum AHDEMAKMMLA
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
		private AHDEMAKMMLA parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public AHDEMAKMMLA Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x967480", Offset = "0x966480", VA = "0x180967480")]
			get
			{
				return default(AHDEMAKMMLA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7BC220", Offset = "0x7BB220", VA = "0x1807BC220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x883B80", Offset = "0x882B80", VA = "0x180883B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6044350", Offset = "0x6043350", VA = "0x186044350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class NHAPBCBMIJP : EJPJBIBGFAM, FCOOJBFEAGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly HGICIMMKMFG BBBBJJILJDE;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string KFFFNNLLPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1094540", Offset = "0x1093540", VA = "0x181094540", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CBBHGDLMENF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6041ED0", Offset = "0x6040ED0", VA = "0x186041ED0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GNMJONCCNEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6041EB0", Offset = "0x6040EB0", VA = "0x186041EB0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> BJHLBDMJLLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1094520", Offset = "0x1093520", VA = "0x181094520", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public NHAPBCBMIJP(HGICIMMKMFG DJEDGNFIGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x288E8F0", Offset = "0x288D8F0", VA = "0x18288E8F0", Slot = "8")]
	public T LNKEGHLMDOM<T>(string IPAJBJLLPIJ, T BKJBKPCHJIH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class PHIHOBFPGIA : ICNGNPAFHKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct MHFFMCEOGDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public PHIHOBFPGIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public NJGFEFLGJII userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6040990", Offset = "0x603F990", VA = "0x186040990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6040E10", Offset = "0x603FE10", VA = "0x186040E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct CGEGANKPBAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x603AC00", Offset = "0x6039C00", VA = "0x18603AC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x603AE10", Offset = "0x6039E10", VA = "0x18603AE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct KADNPCCAJHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public PHIHOBFPGIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public NJGFEFLGJII userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x603E9B0", Offset = "0x603D9B0", VA = "0x18603E9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x603EC70", Offset = "0x603DC70", VA = "0x18603EC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct KFPIFOIEJFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public PHIHOBFPGIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public NJGFEFLGJII userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x603F990", Offset = "0x603E990", VA = "0x18603F990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x603FD60", Offset = "0x603ED60", VA = "0x18603FD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly IReadOnlyDictionary<string, KLHOGFOOOAK> JHFLIDDDEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool KODKGNBPGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private DLBOEBPLGAG MHKNENGKLPF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool BKDIPLKNCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x80F210", Offset = "0x80E210", VA = "0x18080F210", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string LFABBMPAAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6043D30", Offset = "0x6042D30", VA = "0x186043D30", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public GLCKJOMHIOO AJKFBNHMAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6043EF0", Offset = "0x6042EF0", VA = "0x186043EF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BHCANHFBAEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6043270", Offset = "0x6042270", VA = "0x186043270", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60429D0", Offset = "0x60419D0", VA = "0x1860429D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action CAFBHDOCDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6043E50", Offset = "0x6042E50", VA = "0x186043E50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6042B00", Offset = "0x6041B00", VA = "0x186042B00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6042F90", Offset = "0x6041F90", VA = "0x186042F90", Slot = "8")]
	[AsyncStateMachine(typeof(MHFFMCEOGDF))]
	public Task DPGLELIALOP(string MEHCPINJOHB, string MJCHNGDAIMO, [Optional] NJGFEFLGJII LKMCHFFGKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x60430D0", Offset = "0x60420D0", VA = "0x1860430D0", Slot = "17")]
	[AsyncStateMachine(typeof(CGEGANKPBAA))]
	public Task DPHAIKAJGBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6043180", Offset = "0x6042180", VA = "0x186043180", Slot = "12")]
	[AsyncStateMachine(typeof(KADNPCCAJHK))]
	public Task GFJIGFBFEFI(NJGFEFLGJII LKMCHFFGKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6043F90", Offset = "0x6042F90", VA = "0x186043F90", Slot = "13")]
	[AsyncStateMachine(typeof(KFPIFOIEJFE))]
	public Task PLIIGDKAAGM(NJGFEFLGJII LKMCHFFGKFP, Dictionary<string, string> KJCHPHGKFNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6043310", Offset = "0x6042310", VA = "0x186043310", Slot = "14")]
	public bool GIPECIIGAHI(string NODPPNIIIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x60433A0", Offset = "0x60423A0", VA = "0x1860433A0", Slot = "15")]
	public EJPJBIBGFAM IDGGIOODDEK(string GGFFHOKPEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6042DD0", Offset = "0x6041DD0", VA = "0x186042DD0")]
	private HGICIMMKMFG CKBMGLFEAPE(string GGFFHOKPEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6042D50", Offset = "0x6041D50", VA = "0x186042D50", Slot = "16")]
	public FEAMPNDKNIB BBGLNMFCABC(string HEEDLHCGDKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6042A70", Offset = "0x6041A70", VA = "0x186042A70")]
	private BMJGNCIPJAF ADMHJFFELFO(string HEEDLHCGDKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6043420", Offset = "0x6042420", VA = "0x186043420")]
	private DPCHNGGKLMK JBDGNGIGBAD(NJGFEFLGJII LKMCHFFGKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6042BA0", Offset = "0x6041BA0", VA = "0x186042BA0")]
	private DBECFFFDJDG ANEMOCCOBOF(string MJCHNGDAIMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6043D40", Offset = "0x6042D40", VA = "0x186043D40")]
	private void NAKEIIDHKIA(string GGFFHOKPEKG, HGICIMMKMFG DJEDGNFIGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public PHIHOBFPGIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class MLHHCPHHEMP : ICNGNPAFHKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct OMNIPMKKEBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public MLHHCPHHEMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public NJGFEFLGJII userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6041F70", Offset = "0x6040F70", VA = "0x186041F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x60425F0", Offset = "0x60415F0", VA = "0x1860425F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private ICNGNPAFHKP ECFNJDKFINP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private ICNGNPAFHKP JJPKIGPGLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6041210", Offset = "0x6040210", VA = "0x186041210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BKDIPLKNCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x60417E0", Offset = "0x60407E0", VA = "0x1860417E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string LFABBMPAAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x60418A0", Offset = "0x60408A0", VA = "0x1860418A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public GLCKJOMHIOO AJKFBNHMAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6041A00", Offset = "0x6040A00", VA = "0x186041A00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BHCANHFBAEK
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x60415E0", Offset = "0x60405E0", VA = "0x1860415E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6041020", Offset = "0x6040020", VA = "0x186041020", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action CAFBHDOCDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6041960", Offset = "0x6040960", VA = "0x186041960", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x60410C0", Offset = "0x60400C0", VA = "0x1860410C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	[UnityEngine.Scripting.Preserve]
	public MLHHCPHHEMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60418F0", Offset = "0x60408F0", VA = "0x1860418F0")]
	[KEBGMDILACL(JMIJNHPDBML.GameOnly)]
	private static void NGBEIAHPFCC(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6041830", Offset = "0x6040830", VA = "0x186041830")]
	[KEBGMDILACL(JMIJNHPDBML.EditorOnly)]
	private static void LCOKAFPNLLF(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6041280", Offset = "0x6040280", VA = "0x186041280", Slot = "8")]
	[AsyncStateMachine(typeof(OMNIPMKKEBF))]
	public Task DPGLELIALOP(string MEHCPINJOHB, string MJCHNGDAIMO, [Optional] NJGFEFLGJII LKMCHFFGKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x60414D0", Offset = "0x60404D0", VA = "0x1860414D0", Slot = "12")]
	public Task GFJIGFBFEFI(NJGFEFLGJII LKMCHFFGKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6041AC0", Offset = "0x6040AC0", VA = "0x186041AC0", Slot = "13")]
	public Task PLIIGDKAAGM(NJGFEFLGJII LKMCHFFGKFP, Dictionary<string, string> KJCHPHGKFNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6041680", Offset = "0x6040680", VA = "0x186041680", Slot = "14")]
	public bool GIPECIIGAHI(string NODPPNIIIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6041730", Offset = "0x6040730", VA = "0x186041730", Slot = "15")]
	public EJPJBIBGFAM IDGGIOODDEK(string GGFFHOKPEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6041160", Offset = "0x6040160", VA = "0x186041160", Slot = "16")]
	public FEAMPNDKNIB BBGLNMFCABC(string HEEDLHCGDKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x60413C0", Offset = "0x60403C0", VA = "0x1860413C0", Slot = "17")]
	public Task DPHAIKAJGBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x808260", Offset = "0x807260", VA = "0x180808260")]
	[CompilerGenerated]
	private void FNNKCGBKCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x830020", Offset = "0x82F020", VA = "0x180830020")]
	[CompilerGenerated]
	private void HIBCHKCJKEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class MNJHPIGGFKH : FEAMPNDKNIB, FCOOJBFEAGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly BMJGNCIPJAF HPDBMEGIAHL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string KFFFNNLLPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1094770", Offset = "0x1093770", VA = "0x181094770", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public MNJHPIGGFKH(BMJGNCIPJAF ADMMNLEBHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x288E8F0", Offset = "0x288D8F0", VA = "0x18288E8F0", Slot = "5")]
	public T LNKEGHLMDOM<T>(string IPAJBJLLPIJ, T BKJBKPCHJIH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface BGKACFFFHAO
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[UsedImplicitly]
public class MAKNFJJNENL : BGKACFFFHAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly ICODCLDFAAO DGECCNNFKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly Dictionary<string, IMLABOFOFKP> NJBBAFIINMK;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6040820", Offset = "0x603F820", VA = "0x186040820")]
	[KEBGMDILACL(LNECJMDANHH.Session, JMIJNHPDBML.GameOnly)]
	[UsedImplicitly]
	private static void FKKENIGIKEJ(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6040890", Offset = "0x603F890", VA = "0x186040890")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MAKNFJJNENL([CJCLEPGLAOP(null)][NotNull] ICODCLDFAAO DGECCNNFKOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class FACECNBOABO : ICNGNPAFHKP
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool BKDIPLKNCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string LFABBMPAAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public GLCKJOMHIOO AJKFBNHMAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action BHCANHFBAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x603C1C0", Offset = "0x603B1C0", VA = "0x18603C1C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x603BE50", Offset = "0x603AE50", VA = "0x18603BE50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action CAFBHDOCDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x603C2E0", Offset = "0x603B2E0", VA = "0x18603C2E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x603BEF0", Offset = "0x603AEF0", VA = "0x18603BEF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FACECNBOABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x603C010", Offset = "0x603B010", VA = "0x18603C010", Slot = "8")]
	public Task DPGLELIALOP(string MEHCPINJOHB, string MJCHNGDAIMO, [Optional] NJGFEFLGJII LKMCHFFGKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x603C130", Offset = "0x603B130", VA = "0x18603C130", Slot = "12")]
	public Task GFJIGFBFEFI(NJGFEFLGJII LKMCHFFGKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x603C380", Offset = "0x603B380", VA = "0x18603C380", Slot = "13")]
	public Task PLIIGDKAAGM(NJGFEFLGJII LKMCHFFGKFP, Dictionary<string, string> KJCHPHGKFNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "14")]
	public bool GIPECIIGAHI(string NODPPNIIIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x603C260", Offset = "0x603B260", VA = "0x18603C260", Slot = "15")]
	public EJPJBIBGFAM IDGGIOODDEK(string GGFFHOKPEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x603BF90", Offset = "0x603AF90", VA = "0x18603BF90", Slot = "16")]
	public FEAMPNDKNIB BBGLNMFCABC(string HEEDLHCGDKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x603C0A0", Offset = "0x603B0A0", VA = "0x18603C0A0", Slot = "17")]
	public Task DPHAIKAJGBL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal class DLBOEBPLGAG : GLCKJOMHIOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly DPCHNGGKLMK MHKNENGKLPF;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IReadOnlyDictionary<string, object> MDBGCNMHOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1094770", Offset = "0x1093770", VA = "0x181094770", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public DLBOEBPLGAG(DPCHNGGKLMK BIFMDDGGBOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface MNHJDMOBGNI
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKNCIHDOFJG LDNODDMMOIG(string NGDPEONIODF);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface AAKKNIPGGAI
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public enum JOCAFDPHPNM
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	long HOPIJCOAEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string IHMLCCDMOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string NOKOFAKNLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string DBJLKMDHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string MDMPEDEBMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool KKCPCANFNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long NBBEKPDMGHI();

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NFPLKPMNCOB(long HEPBCOGEGKH, bool OKDAIEGFKEH = true);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OHBOGHKGJCE(string LNLKAOCIPJI, string DDDKGNCDAMB, string BIEOPKPPJHN);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BEJKHJPOLCN(string LNLKAOCIPJI);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KGGMHCIHHHN(string LNLKAOCIPJI, string HMMMBPMCNJD, string KDDBPBJIPDE);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JAKDFPKBMPC(string CCNDHICBNLO, object KHNBNFIHFHO, object ELKIMMJINGO);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void INFLBLEINDF(JOCAFDPHPNM IGFFIDHIEKP, int IBMLGBPJGGA, [Optional] GEGMIIJMJAG BGMDFHBOKAF, [Optional] string JANPKGAEGPD, [Optional] string AIKAPCCDDEJ);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NCOAGALPEDL(GEGMIIJMJAG BGMDFHBOKAF, long MCKKJOCMJEE, long AGGGJGHGLAD, int GKLDKEOOMLA, string JANPKGAEGPD, int IBMLGBPJGGA);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CEAPLHBONMO(GEGMIIJMJAG BGMDFHBOKAF, bool LAFOEMFOPKK, [Optional] string AIKAPCCDDEJ);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void APMNKIFENIK(GEGMIIJMJAG BGMDFHBOKAF, bool LAFOEMFOPKK, [Optional] string AIKAPCCDDEJ);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ONGPJADJGGO(GEGMIIJMJAG BGMDFHBOKAF, bool LAFOEMFOPKK, [Optional] string AIKAPCCDDEJ);
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
