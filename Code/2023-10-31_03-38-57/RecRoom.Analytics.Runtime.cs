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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B90000", Offset = "0x5B8F400", VA = "0x185B90000")]
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
		[Cpp2IlInjected.Address(RVA = "0x787CE0", Offset = "0x7870E0", VA = "0x180787CE0")]
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
		public AmplitudeAnalyticsClient.Settings PENGLKAEJPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NEHNCEELJOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x75C550", Offset = "0x75B950", VA = "0x18075C550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum DCMDNNLMLPL
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class IIODOMCDLCM
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class NLODLFHBEIE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int IIKPDDOHJMC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> HDKGEJJKKJK;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
				public NLODLFHBEIE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class IGKLIEMPNAO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
				public IGKLIEMPNAO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5B89940", Offset = "0x5B88D40", VA = "0x185B89940")]
				internal bool NFHCDCODEKM(NLODLFHBEIE item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string NFGDHAFKBJA = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string MLDHHBJPPMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<NLODLFHBEIE> FDAJGGKGEFF;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? CHBEKKJCABD
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5B89C70", Offset = "0x5B89070", VA = "0x185B89C70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5B8AC70", Offset = "0x5B8A070", VA = "0x185B8AC70")]
			internal IIODOMCDLCM(string CDOIMKHAPLB, string EADLCNJELLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5B8A480", Offset = "0x5B89880", VA = "0x185B8A480")]
			public int LMKMOPOPAGD([Optional] int? BFEOBJMNMDM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5B8A210", Offset = "0x5B89610", VA = "0x185B8A210")]
			public List<Dictionary<string, object>> LMGJNIAIIFN(int CKICOBBMJAP, int? BFEOBJMNMDM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5B89AC0", Offset = "0x5B88EC0", VA = "0x185B89AC0")]
			public void DPONNGCDAOP(AmplitudeAnalyticsIdentifyMessage BAFDGKKJJJD, bool IMMDGCKPDHN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5B899B0", Offset = "0x5B88DB0", VA = "0x185B899B0")]
			public void DPONNGCDAOP(Dictionary<string, object> BAFDGKKJJJD, bool IMMDGCKPDHN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5B8A080", Offset = "0x5B89480", VA = "0x185B8A080")]
			public void IPPPMNMGBIN(params Dictionary<string, object>[] NLKLOLMHMHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5B8A630", Offset = "0x5B89A30", VA = "0x185B8A630")]
			public void MODHNKIDAGO(List<Dictionary<string, object>> MHKBIHKHHGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5B89B60", Offset = "0x5B88F60", VA = "0x185B89B60")]
			private void GIDJJCDGPOP(Dictionary<string, object> BAFDGKKJJJD, bool IMMDGCKPDHN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5B89E40", Offset = "0x5B89240", VA = "0x185B89E40")]
			public void INCLFEPJCEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5B8A880", Offset = "0x5B89C80", VA = "0x185B8A880")]
			private void ONHEDDIIOFB([Optional] string KOKLIJEKINL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5B89D10", Offset = "0x5B89110", VA = "0x185B89D10")]
			private static string HCNEHEADJLG(string EOHMJBFGDPD, string DGCJCBHPPBD)
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
			[Cpp2IlInjected.Address(RVA = "0x5B90EC0", Offset = "0x5B902C0", VA = "0x185B90EC0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct GBAPMKAEPEB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int JOJEPIOCCBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string KPFPMGPDGEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T EBIPCCGGKCH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class PPHPPJGPDDO : IEnumerator<KALNLPJNFEA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private KALNLPJNFEA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private KALNLPJNFEA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
			[DebuggerHidden]
			public PPHPPJGPDDO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5B90340", Offset = "0x5B8F740", VA = "0x185B90340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5B90B00", Offset = "0x5B8FF00", VA = "0x185B90B00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class DGFKAOAEIAO : IEnumerator<object>, IEnumerator, IDisposable
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
			public NFBEAPPNOOK quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
			[DebuggerHidden]
			public DGFKAOAEIAO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5B890B0", Offset = "0x5B884B0", VA = "0x185B890B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5B891C0", Offset = "0x5B885C0", VA = "0x185B891C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class PHIGCGLKFGB : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
			[DebuggerHidden]
			public PHIGCGLKFGB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5B90080", Offset = "0x5B8F480", VA = "0x185B90080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5B901F0", Offset = "0x5B8F5F0", VA = "0x185B901F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class JLACCPPKIAF : IEnumerator<KALNLPJNFEA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private KALNLPJNFEA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private KALNLPJNFEA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
			[DebuggerHidden]
			public JLACCPPKIAF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5B8B780", Offset = "0x5B8AB80", VA = "0x185B8B780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5B8BA00", Offset = "0x5B8AE00", VA = "0x185B8BA00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class KEOBAKGHLGM : IEnumerator<KALNLPJNFEA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private KALNLPJNFEA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private KALNLPJNFEA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
			[DebuggerHidden]
			public KEOBAKGHLGM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5B8BA50", Offset = "0x5B8AE50", VA = "0x185B8BA50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5B8BCE0", Offset = "0x5B8B0E0", VA = "0x185B8BCE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class JAHBCELEHBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public IIODOMCDLCM cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public JAHBCELEHBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5B8B460", Offset = "0x5B8A860", VA = "0x185B8B460")]
			internal void CNINBMDHFJM(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5B8B010", Offset = "0x5B8A410", VA = "0x185B8B010")]
			internal void AKMIMNPJELF(GBAPMKAEPEB<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class BGJIHDNBNHA : IEnumerator<KALNLPJNFEA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private KALNLPJNFEA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public IIODOMCDLCM cache;

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
			private JAHBCELEHBF <>8__1;

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
			private KALNLPJNFEA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
			[DebuggerHidden]
			public BGJIHDNBNHA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5B88810", Offset = "0x5B87C10", VA = "0x185B88810", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5B89060", Offset = "0x5B88460", VA = "0x185B89060", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class KNCJNDGFJAF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public KNCJNDGFJAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3701320", Offset = "0x3700720", VA = "0x183701320")]
			internal GBAPMKAEPEB<T> LMOHFFDPOKJ(OONMAOMENEJ postResponse)
			{
				return default(GBAPMKAEPEB<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class AOBGFOPOLLA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public AOBGFOPOLLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3701320", Offset = "0x3700720", VA = "0x183701320")]
			internal GBAPMKAEPEB<T> EKIIELNPLLB(OONMAOMENEJ postResponse)
			{
				return default(GBAPMKAEPEB<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private PGLCOAKHOLD CGPJOCNLFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<CHJLDGBKJAP> OGLBNLBCHLI;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string DHAGEGHMEGM = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string KKJGKFLFPPH = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string MFNBCGCNLIA = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int CLILIPHDKHB = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int GPDHAEOHBGO = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int HFGHDKGPGJF = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float LKBAAEFEJKH = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long GDLHFCGBBEH = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string PHFJIDIHCBJ = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string ONBKNHLIEPC = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool PCIOGONAJHG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool JENFBLPLEBD;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int EOBECANBKBA;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int HNMBECHLBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private DJONEGNOFEJ MCBLOLGCDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private NKEGCDFIBBN OJJGMBDDMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private IJGJALGBECN NOIJLNFJCDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool LBOCHFCHLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float GPMODGIFNOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float CNAFECADBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int INOLKFDIGPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int BOEGKJEONON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? PEFDAICACME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? DDPMMPDGKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long JABFINHBPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string NBOFAFCMNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool ANOGKANPLHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long ILCABAOHBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string PBCFCOEJBIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string GFGHJEEMBJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> IEHFFCLBJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DCMDNNLMLPL KAHFPMMHCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int NAONFDCDMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int HAHIIIJBPHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float PNLCLOOADDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool CIPADOEIJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool HLJGNKOGEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private IIODOMCDLCM JFLLDDGJLGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private IIODOMCDLCM DKKJKJPIKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IIODOMCDLCM ILFLHLLGIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> PGLDBNGKMLP;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo GILKLLJLEPA;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string HKEGDFEMLFI;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string PMNIPMCKMGM = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string EHOPAEGGDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string PNDFKOFAHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string AKODMMLIPDC;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private PGLCOAKHOLD IIMFOOLGODI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5B81370", Offset = "0x5B80770", VA = "0x185B81370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private CHJLDGBKJAP FKHFEIEPGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5B81A80", Offset = "0x5B80E80", VA = "0x185B81A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int IFNGODLKBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5B81DD0", Offset = "0x5B811D0", VA = "0x185B81DD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long EDHKPBIKEHK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5B86760", Offset = "0x5B85B60", VA = "0x185B86760")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5B86880", Offset = "0x5B85C80", VA = "0x185B86880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string HOEAFFIJLAF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5B86700", Offset = "0x5B85B00", VA = "0x185B86700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string KKHMIAEFKAH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5B86730", Offset = "0x5B85B30", VA = "0x185B86730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BOEABPCJGCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8BB590", Offset = "0x8BA990", VA = "0x1808BB590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8BB820", Offset = "0x8BAC20", VA = "0x1808BB820")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? HDAPECJNDBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8BB580", Offset = "0x8BA980", VA = "0x1808BB580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5B86870", Offset = "0x5B85C70", VA = "0x185B86870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JHPDJJDJBDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xE3F0A0", Offset = "0xE3E4A0", VA = "0x180E3F0A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool MOLAPDOABGG
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5B86600", Offset = "0x5B85A00", VA = "0x185B86600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> CDLFCEFHCKC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5B86540", Offset = "0x5B85940", VA = "0x185B86540")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5B867B0", Offset = "0x5B85BB0", VA = "0x185B867B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5B80F00", Offset = "0x5B80300", VA = "0x185B80F00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5B82870", Offset = "0x5B81C70", VA = "0x185B82870")]
		private void JDBAEBKHGPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5B85B20", Offset = "0x5B84F20", VA = "0x185B85B20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5B84BB0", Offset = "0x5B83FB0", VA = "0x185B84BB0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5B85EC0", Offset = "0x5B852C0", VA = "0x185B85EC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5B84DC0", Offset = "0x5B841C0", VA = "0x185B84DC0")]
		public AFGBDCJCGDG PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5B827E0", Offset = "0x5B81BE0", VA = "0x185B827E0")]
		[IteratorStateMachine(typeof(PPHPPJGPDDO))]
		public IEnumerator<KALNLPJNFEA> Initialize(AmplitudeAnalyticsEvent KEHCLDGFBFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5B85E00", Offset = "0x5B85200", VA = "0x185B85E00")]
		public void UpdateLastKnownInteractionCategory(string NIBDLPOBEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5B85D10", Offset = "0x5B85110", VA = "0x185B85D10")]
		public void UpdateLastAliveTime(float HGGDOAEFCDP = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5B82290", Offset = "0x5B81690", VA = "0x185B82290")]
		private AFGBDCJCGDG IIFLDIPANMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5B82EB0", Offset = "0x5B822B0", VA = "0x185B82EB0")]
		private AFGBDCJCGDG LDGJCLENJLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5B85570", Offset = "0x5B84970", VA = "0x185B85570")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5B82E20", Offset = "0x5B82220", VA = "0x185B82E20")]
		[IteratorStateMachine(typeof(DGFKAOAEIAO))]
		private IEnumerator LAKCOEJJOPF(NFBEAPPNOOK GKILPKEMGLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5B86150", Offset = "0x5B85550", VA = "0x185B86150")]
		[IteratorStateMachine(typeof(PHIGCGLKFGB))]
		public IEnumerator WaitForFlush(float LBOMALIMPNP = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5B85BF0", Offset = "0x5B84FF0", VA = "0x185B85BF0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5B85B30", Offset = "0x5B84F30", VA = "0x185B85B30")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime EGHBFNCPCGI)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5B82350", Offset = "0x5B81750", VA = "0x185B82350")]
		public static PINAHOCBMGM Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5B80D90", Offset = "0x5B80190", VA = "0x185B80D90")]
		public static NBFJALPNFCN AccountSelectionPostLoginEvent([NotNull] string OCADFKKLCPA, string PBBBEOIALCM, bool GLMLJGKMANA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5B81AD0", Offset = "0x5B80ED0", VA = "0x185B81AD0")]
		public static NBFJALPNFCN Event([NotNull] string OCADFKKLCPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5B84E00", Offset = "0x5B84200", VA = "0x185B84E00")]
		public static NBFJALPNFCN PreviousSessionEvent([NotNull] string OCADFKKLCPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5B82500", Offset = "0x5B81900", VA = "0x185B82500")]
		public static NBFJALPNFCN InitializeEvent(string PBBBEOIALCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5B85730", Offset = "0x5B84B30", VA = "0x185B85730")]
		public static NBFJALPNFCN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5B81820", Offset = "0x5B80C20", VA = "0x185B81820")]
		public static NBFJALPNFCN CreateOutOfSessionEvent(string OCADFKKLCPA, bool MPGJPLEGMHN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5B83420", Offset = "0x5B82820", VA = "0x185B83420")]
		public static AFGBDCJCGDG LogOutOfSessionEvent(NBFJALPNFCN DCEDHGLALOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B831A0", Offset = "0x5B825A0", VA = "0x185B831A0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent ICMEGCNHPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5B83710", Offset = "0x5B82B10", VA = "0x185B83710")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent ICMEGCNHPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5B83850", Offset = "0x5B82C50", VA = "0x185B83850")]
		public void LogSerializedEventAsync(Dictionary<string, object> KGGMKCLMEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5B832E0", Offset = "0x5B826E0", VA = "0x185B832E0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage OJMPFJHGIDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5B84C70", Offset = "0x5B84070", VA = "0x185B84C70")]
		private void PNAKBJPBGAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5B813E0", Offset = "0x5B807E0", VA = "0x185B813E0")]
		private void BGDAJOKDPOL(Dictionary<string, object> KCEBJALKPAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5B82040", Offset = "0x5B81440", VA = "0x185B82040")]
		private void HKKKBGIFIIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5B80BC0", Offset = "0x5B7FFC0", VA = "0x185B80BC0")]
		private void APDJDBCEOHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5B81FB0", Offset = "0x5B813B0", VA = "0x185B81FB0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5B84B20", Offset = "0x5B83F20", VA = "0x185B84B20")]
		[IteratorStateMachine(typeof(JLACCPPKIAF))]
		private IEnumerator<KALNLPJNFEA> ONNJILADMHL(float LBOMALIMPNP = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5B81790", Offset = "0x5B80B90", VA = "0x185B81790")]
		[IteratorStateMachine(typeof(KEOBAKGHLGM))]
		private IEnumerator<KALNLPJNFEA> CNFKGCCBAMM(float LBOMALIMPNP = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5B81690", Offset = "0x5B80A90", VA = "0x185B81690")]
		[IteratorStateMachine(typeof(BGJIHDNBNHA))]
		private IEnumerator<KALNLPJNFEA> BHABJDOAFEM(IIODOMCDLCM MKOBKFKDLMA, int? BFEOBJMNMDM, string MDNHNLCMAGC, string CBINHBGCPCF, float LBOMALIMPNP, Action<int> PBIHMKCEAJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5B83930", Offset = "0x5B82D30", VA = "0x185B83930")]
		private static void NPMLPBKPILG(bool GFFKLEMNOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5B83A40", Offset = "0x5B82E40", VA = "0x185B83A40")]
		private OCKEEDNGMLO<GBAPMKAEPEB<Dictionary<string, object>>> OEDOANDJIKO(string MDNHNLCMAGC, string CBINHBGCPCF, string FDEFKBDBMJK, string PELIHFIEKEI, Dictionary<string, object> EBIPCCGGKCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5B83B70", Offset = "0x5B82F70", VA = "0x185B83B70")]
		private OCKEEDNGMLO<GBAPMKAEPEB<List<Dictionary<string, object>>>> OEDOANDJIKO(string MDNHNLCMAGC, string CBINHBGCPCF, string FDEFKBDBMJK, string PELIHFIEKEI, List<Dictionary<string, object>> EBIPCCGGKCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x29F6F80", Offset = "0x29F6380", VA = "0x1829F6F80")]
		private OCKEEDNGMLO<GBAPMKAEPEB<T>> KLPKEBFBMFP<T>(string MDNHNLCMAGC, string CBINHBGCPCF, string PELIHFIEKEI, T EBIPCCGGKCH, Dictionary<string, object> ILGNFLCHGKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x29F6C30", Offset = "0x29F6030", VA = "0x1829F6C30")]
		private OCKEEDNGMLO<GBAPMKAEPEB<T>> JGGCDHKAMPK<T>(string MDNHNLCMAGC, string CBINHBGCPCF, string FDEFKBDBMJK, T EBIPCCGGKCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5B84D70", Offset = "0x5B84170", VA = "0x185B84D70")]
		private bool PNLKPJAOLFG(float FPJMEBILACK, float LBOMALIMPNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5B83E50", Offset = "0x5B83250", VA = "0x185B83E50")]
		private Dictionary<string, object> OIEGGEKBMCF(string CBINHBGCPCF, Dictionary<string, object> EBIPCCGGKCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5B86240", Offset = "0x5B85640", VA = "0x185B86240")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5B82130", Offset = "0x5B81530", VA = "0x185B82130")]
		[CompilerGenerated]
		private long IHHFHCPCCGM()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5B82E10", Offset = "0x5B82210", VA = "0x185B82E10")]
		[CompilerGenerated]
		private void KBEDHBCCMDA(int DIAPIMDMJIG)
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
			[Cpp2IlInjected.Address(RVA = "0x5B875E0", Offset = "0x5B869E0", VA = "0x185B875E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5B876C0", Offset = "0x5B86AC0", VA = "0x185B876C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5B87620", Offset = "0x5B86A20", VA = "0x185B87620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5B87720", Offset = "0x5B86B20", VA = "0x185B87720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5B875A0", Offset = "0x5B869A0", VA = "0x185B875A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5B87660", Offset = "0x5B86A60", VA = "0x185B87660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x761D10", Offset = "0x761110", VA = "0x180761D10")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5B86E10", Offset = "0x5B86210", VA = "0x185B86E10")]
		public static NBFJALPNFCN EECJKDKEFDC(string FOIKACEEEGH, [NotNull] string DDNAIIAEIKD, long MHDKPAOKAEC, long OOMJABCAOBL, string PBBBEOIALCM, bool GLMLJGKMANA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5B872B0", Offset = "0x5B866B0", VA = "0x185B872B0")]
		public static NBFJALPNFCN LKHABPBKPFC(string FOIKACEEEGH, [NotNull] string DDNAIIAEIKD, long MHDKPAOKAEC, long OOMJABCAOBL, string PBBBEOIALCM, long HKGMCOBIHPC, bool GLMLJGKMANA, string KCIFNAHKDLE, string JLNKEGJKDEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5B87410", Offset = "0x5B86810", VA = "0x185B87410")]
		private AmplitudeAnalyticsEvent(string FOIKACEEEGH, [NotNull] string DDNAIIAEIKD, long MHDKPAOKAEC, long OOMJABCAOBL, string PBBBEOIALCM, bool GLMLJGKMANA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1883410", Offset = "0x1882810", VA = "0x181883410")]
		public void IHEDONIBAFC(long FDLNKNFIEFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5B87090", Offset = "0x5B86490", VA = "0x185B87090", Slot = "5")]
		public override void JHDEMCPFOBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5B86F10", Offset = "0x5B86310", VA = "0x185B86F10", Slot = "6")]
		public override void FEFCDFNECHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5B868E0", Offset = "0x5B85CE0", VA = "0x185B868E0", Slot = "4")]
		protected override Dictionary<string, object> DNKOOFFLAAE(Dictionary<string, object> PGJDFPKBNHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5B871A0", Offset = "0x5B865A0", VA = "0x185B871A0")]
		private void LHJJNEHCKCD(string DGCJCBHPPBD, string EOHMJBFGDPD, bool PPODCCFGAPH = false)
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
			[Cpp2IlInjected.Address(RVA = "0x5B89210", Offset = "0x5B88610", VA = "0x185B89210")]
			public void NIIMCENJFAO(Dictionary<string, object> AJJNJGPPCBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B90B50", Offset = "0x5B8FF50", VA = "0x185B90B50")]
			public void NIIMCENJFAO(Dictionary<string, object> OCPHMPDFEJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7EC360", Offset = "0x7EB760", VA = "0x1807EC360")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5B87AC0", Offset = "0x5B86EC0", VA = "0x185B87AC0")]
		public static PINAHOCBMGM EECJKDKEFDC(string FOIKACEEEGH, string PBBBEOIALCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5B87E40", Offset = "0x5B87240", VA = "0x185B87E40")]
		protected AmplitudeAnalyticsIdentifyMessage(string FOIKACEEEGH, string PBBBEOIALCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5B87C80", Offset = "0x5B87080", VA = "0x185B87C80")]
		public Dictionary<string, object> HHONMLOECLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5B87780", Offset = "0x5B86B80", VA = "0x185B87780", Slot = "4")]
		protected virtual Dictionary<string, object> DNKOOFFLAAE(Dictionary<string, object> PGJDFPKBNHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5B87D10", Offset = "0x5B87110", VA = "0x185B87D10")]
		protected void JBNCHDPFLGK(string DGCJCBHPPBD, Dictionary<string, object> CDMHJJHBEHD, Dictionary<string, object> DDLKJHJAMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5B87C10", Offset = "0x5B87010", VA = "0x185B87C10")]
		protected void FEOMIMOAPGC(string DGCJCBHPPBD, string EOHMJBFGDPD, Dictionary<string, object> BABIFNPNHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5B87DB0", Offset = "0x5B871B0", VA = "0x185B87DB0", Slot = "5")]
		public virtual void JHDEMCPFOBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5B87B80", Offset = "0x5B86F80", VA = "0x185B87B80", Slot = "6")]
		public virtual void FEFCDFNECHP()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PINAHOCBMGM : PANOONEKCDN<AmplitudeAnalyticsIdentifyMessage, PINAHOCBMGM>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override PINAHOCBMGM INIALMCBOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage JOALHKNOLHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5B902F0", Offset = "0x5B8F6F0", VA = "0x185B902F0")]
	public PINAHOCBMGM(AmplitudeAnalyticsIdentifyMessage NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5B90240", Offset = "0x5B8F640", VA = "0x185B90240", Slot = "4")]
	public override void FEFCDFNECHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NBFJALPNFCN : PANOONEKCDN<AmplitudeAnalyticsEvent, NBFJALPNFCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool KHAGHDBABFP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override NBFJALPNFCN INIALMCBOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long AIMOFGJPINA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1C56270", Offset = "0x1C55670", VA = "0x181C56270")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5B898F0", Offset = "0x5B88CF0", VA = "0x185B898F0")]
	public NBFJALPNFCN(AmplitudeAnalyticsEvent NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "5")]
	public override AmplitudeAnalyticsEvent JOALHKNOLHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F7C0", Offset = "0x5B8EBC0", VA = "0x185B8F7C0", Slot = "4")]
	public override void FEFCDFNECHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x24D1050", Offset = "0x24D0450", VA = "0x1824D1050")]
	public NBFJALPNFCN LOAGNMOICKK<T>(string ANNDMLIIDLL, T[] EOHMJBFGDPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x24D1050", Offset = "0x24D0450", VA = "0x1824D1050")]
	public NBFJALPNFCN LOAGNMOICKK(string ANNDMLIIDLL, string[] EOHMJBFGDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x24D0DA0", Offset = "0x24D01A0", VA = "0x1824D0DA0")]
	public NBFJALPNFCN LOAGNMOICKK<T>(string ANNDMLIIDLL, T EOHMJBFGDPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FAA0", Offset = "0x5B8EEA0", VA = "0x185B8FAA0")]
	public NBFJALPNFCN LOAGNMOICKK(string ANNDMLIIDLL, long EOHMJBFGDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FA30", Offset = "0x5B8EE30", VA = "0x185B8FA30")]
	public NBFJALPNFCN LOAGNMOICKK(string ANNDMLIIDLL, string EOHMJBFGDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FA00", Offset = "0x5B8EE00", VA = "0x185B8FA00")]
	public NBFJALPNFCN KHMLNIKNKIK(string ANNDMLIIDLL, object? EOHMJBFGDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F960", Offset = "0x5B8ED60", VA = "0x185B8F960")]
	public NBFJALPNFCN JENKEPMEBGB(string ANNDMLIIDLL, string EOHMJBFGDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F860", Offset = "0x5B8EC60", VA = "0x185B8F860")]
	private NBFJALPNFCN GJNKPKDIFPI(string ANNDMLIIDLL, object EOHMJBFGDPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FMOAMECOJPB : NBFJALPNFCN
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5B898F0", Offset = "0x5B88CF0", VA = "0x185B898F0")]
	public FMOAMECOJPB(AmplitudeAnalyticsEvent NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5B89740", Offset = "0x5B88B40", VA = "0x185B89740", Slot = "4")]
	public override void FEFCDFNECHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class PANOONEKCDN<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : PANOONEKCDN<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M NJKPBIBMIJE;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR INIALMCBOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x763340", Offset = "0x762740", VA = "0x180763340")]
	public PANOONEKCDN(M NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3DB41C0", Offset = "0x3DB35C0", VA = "0x183DB41C0")]
	public BLDR GCMNDGPGHOD(AmplitudeAnalyticsIdentifyMessage.DeviceInfo IDKGNFPEPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4240", Offset = "0x3DB3640", VA = "0x183DB4240")]
	public BLDR JHFJDLCHHMH(AmplitudeAnalyticsIdentifyMessage.RevenueData HPEOAEKICPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4290", Offset = "0x3DB3690", VA = "0x183DB4290")]
	public BLDR JNFONDFCOJJ(string ANNDMLIIDLL, string EOHMJBFGDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x22D80D0", Offset = "0x22D74D0", VA = "0x1822D80D0")]
	public BLDR JNFONDFCOJJ<T>(string ANNDMLIIDLL, T EOHMJBFGDPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FEFCDFNECHP();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4210", Offset = "0x3DB3610", VA = "0x183DB4210")]
	internal static string JCCIEFMLNGC(string EOHMJBFGDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4310", Offset = "0x3DB3710", VA = "0x183DB4310")]
	private BLDR NPCAABLEPEK(string ANNDMLIIDLL, object EOHMJBFGDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M JOALHKNOLHL();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class FLNCPNBABNA : DJONEGNOFEJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct BGCDAGPFFBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<OONMAOMENEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public FLNCPNBABNA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5B87F00", Offset = "0x5B87300", VA = "0x185B87F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5B887A0", Offset = "0x5B87BA0", VA = "0x185B887A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct MJIGGIPKGDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<OONMAOMENEJ> <>t__builder;

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
		public FLNCPNBABNA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5B8D120", Offset = "0x5B8C520", VA = "0x185B8D120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5B8DB50", Offset = "0x5B8CF50", VA = "0x185B8DB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient EMHFGMLJBKP;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5B89500", Offset = "0x5B88900", VA = "0x185B89500")]
	[JMHDKPKEECF(OPIGPDFNEON.None)]
	private static void ILDEHAKBOPN(HLDKHDLHDPB KBPJCNHNBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5B896C0", Offset = "0x5B88AC0", VA = "0x185B896C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FLNCPNBABNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5B89570", Offset = "0x5B88970", VA = "0x185B89570", Slot = "4")]
	[AsyncStateMachine(typeof(BGCDAGPFFBK))]
	public Task<OONMAOMENEJ> OEDOANDJIKO(string MDNHNLCMAGC, Dictionary<string, string> MLLHBIDGOFB, bool AANFIPPJPEG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B89390", Offset = "0x5B88790", VA = "0x185B89390", Slot = "5")]
	[AsyncStateMachine(typeof(MJIGGIPKGDA))]
	public Task<OONMAOMENEJ> GJEPIJHBDCI(string MDNHNLCMAGC, string NKHPEOKMKPO, string POBEPEILCMN, string HLFDJDGBAJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IJOAMPJBOLH
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> JJDODGGBPCH;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5B8AE60", Offset = "0x5B8A260", VA = "0x185B8AE60")]
	internal static bool NFPOEOIKBIN(string DGCJCBHPPBD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface DJONEGNOFEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OONMAOMENEJ> OEDOANDJIKO(string MDNHNLCMAGC, Dictionary<string, string> MLLHBIDGOFB, bool AANFIPPJPEG = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OONMAOMENEJ> GJEPIJHBDCI(string MDNHNLCMAGC, string NKHPEOKMKPO, string POBEPEILCMN, string HLFDJDGBAJP);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct OONMAOMENEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int FADPKIPFDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string AGALAHIBJII;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xAE29E0", Offset = "0xAE1DE0", VA = "0x180AE29E0")]
	public OONMAOMENEJ(int JOJEPIOCCBI, string KPFPMGPDGEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum NHJILHDCMOJ
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
public class MFOFIAGPABA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private long FDNFHMKHLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NBFJALPNFCN OLPLHJMLNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool NMNNDFONAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private float LEHBEEJJBNA;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5B8C0C0", Offset = "0x5B8B4C0", VA = "0x185B8C0C0")]
	public MFOFIAGPABA(string LEBBGGNFGLC, float LEHBEEJJBNA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x24773F0", Offset = "0x24767F0", VA = "0x1824773F0")]
	public void LOAGNMOICKK<T>(string ANNDMLIIDLL, T EOHMJBFGDPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5B8C040", Offset = "0x5B8B440", VA = "0x185B8C040")]
	public void LOAGNMOICKK(string ANNDMLIIDLL, string EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5B8BDF0", Offset = "0x5B8B1F0", VA = "0x185B8BDF0")]
	public void CLIJLLPOGHA(string MAPNEMJHIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B8BD30", Offset = "0x5B8B130", VA = "0x185B8BD30")]
	public void AJPBHMNBGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5B8BF30", Offset = "0x5B8B330", VA = "0x185B8BF30")]
	private void HEJLBPPOOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5B8BEE0", Offset = "0x5B8B2E0", VA = "0x185B8BEE0")]
	private bool FGIBMLCFHHB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface FMJHJJHGABO
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool MDIKGCAGGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string BOEABPCJGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action CADJEFKPJLJ;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NFOIDICDPJF;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AFGBDCJCGDG FGBNJEBGKMH(string PAECKDINGMD, string EADLCNJELLB, [Optional] NKEGCDFIBBN FJNGLAKPPDG);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AFGBDCJCGDG NMOOBIADKPM(NKEGCDFIBBN FJNGLAKPPDG);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AFGBDCJCGDG EPMGKDOKPEB(NKEGCDFIBBN FJNGLAKPPDG, Dictionary<string, string> KPHAHIJAKJI);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HKJDLDOLCAI(string NJKJIOKCJBG);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BLJNEDFDFIB HBEBMBHCFPH(string JPPPJDKGLGE);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PAINBPNJBKD CHAEDANIPKC(string OBOHINCDAPD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	AFGBDCJCGDG LBGGCCPPAJH();
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
			[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5B90CC0", Offset = "0x5B900C0", VA = "0x185B90CC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MNBECKIMNHC : FMJHJJHGABO
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly IReadOnlyDictionary<string, EOHCEGFMCAG> APIDBIKMLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool LOBDHMNONBN;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MDIKGCAGGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7AEE20", Offset = "0x7AE220", VA = "0x1807AEE20", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string BOEABPCJGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5B8DD70", Offset = "0x5B8D170", VA = "0x185B8DD70", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action CADJEFKPJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5B8F160", Offset = "0x5B8E560", VA = "0x185B8F160", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5B8F350", Offset = "0x5B8E750", VA = "0x185B8F350", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action NFOIDICDPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5B8F5E0", Offset = "0x5B8E9E0", VA = "0x185B8F5E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5B8E4E0", Offset = "0x5B8D8E0", VA = "0x185B8E4E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E850", Offset = "0x5B8DC50", VA = "0x185B8E850", Slot = "8")]
	public AFGBDCJCGDG FGBNJEBGKMH(string PAECKDINGMD, string EADLCNJELLB, [Optional] NKEGCDFIBBN FJNGLAKPPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F200", Offset = "0x5B8E600", VA = "0x185B8F200", Slot = "16")]
	public AFGBDCJCGDG LBGGCCPPAJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F3F0", Offset = "0x5B8E7F0", VA = "0x185B8F3F0", Slot = "11")]
	public AFGBDCJCGDG NMOOBIADKPM(NKEGCDFIBBN FJNGLAKPPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E580", Offset = "0x5B8D980", VA = "0x185B8E580", Slot = "12")]
	public AFGBDCJCGDG EPMGKDOKPEB(NKEGCDFIBBN FJNGLAKPPDG, Dictionary<string, string> KPHAHIJAKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5B8EF40", Offset = "0x5B8E340", VA = "0x185B8EF40", Slot = "13")]
	public bool HKJDLDOLCAI(string NJKJIOKCJBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5B8ED40", Offset = "0x5B8E140", VA = "0x185B8ED40", Slot = "14")]
	public BLJNEDFDFIB HBEBMBHCFPH(string JPPPJDKGLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5B8DD80", Offset = "0x5B8D180", VA = "0x185B8DD80", Slot = "15")]
	public PAINBPNJBKD CHAEDANIPKC(string OBOHINCDAPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5B8DE10", Offset = "0x5B8D210", VA = "0x185B8DE10")]
	private GCJEKPIKGIN DDGFEKMICCB(NKEGCDFIBBN FJNGLAKPPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5B8DBC0", Offset = "0x5B8CFC0", VA = "0x185B8DBC0")]
	private COHAELNNECN BBPCBOEHLOJ(string EADLCNJELLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F050", Offset = "0x5B8E450", VA = "0x185B8F050")]
	private void KHNNHHIIKFA(string JPPPJDKGLGE, BLJNEDFDFIB BMPHEIEDACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MNBECKIMNHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA46F70", Offset = "0xA46370", VA = "0x180A46F70")]
	[CompilerGenerated]
	private void MDKJHFMINJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5B8EFD0", Offset = "0x5B8E3D0", VA = "0x185B8EFD0")]
	[CompilerGenerated]
	private void ICDJCCBMLIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5B8ECC0", Offset = "0x5B8E0C0", VA = "0x185B8ECC0")]
	[CompilerGenerated]
	private void GFMDADBCEEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class MGKHEIGJNBD : FMJHJJHGABO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private FMJHJJHGABO EJIIHBNJMOF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private FMJHJJHGABO GHKHAMLBHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5B8CE60", Offset = "0x5B8C260", VA = "0x185B8CE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool MDIKGCAGGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5B8CB40", Offset = "0x5B8BF40", VA = "0x185B8CB40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string BOEABPCJGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5B8C250", Offset = "0x5B8B650", VA = "0x185B8C250", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action CADJEFKPJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5B8CCB0", Offset = "0x5B8C0B0", VA = "0x185B8CCB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5B8CED0", Offset = "0x5B8C2D0", VA = "0x185B8CED0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action NFOIDICDPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5B8D080", Offset = "0x5B8C480", VA = "0x185B8D080", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5B8C3B0", Offset = "0x5B8B7B0", VA = "0x185B8C3B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	[UnityEngine.Scripting.Preserve]
	public MGKHEIGJNBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5B8C9C0", Offset = "0x5B8BDC0", VA = "0x185B8C9C0")]
	[JMHDKPKEECF(OPIGPDFNEON.GameOnly)]
	private static void GOPHCAAEPOM(HLDKHDLHDPB KBPJCNHNBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5B8CC40", Offset = "0x5B8C040", VA = "0x185B8CC40")]
	[JMHDKPKEECF(OPIGPDFNEON.EditorOnly)]
	private static void KIBENACHGLI(HLDKHDLHDPB KBPJCNHNBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5B8C570", Offset = "0x5B8B970", VA = "0x185B8C570", Slot = "8")]
	public AFGBDCJCGDG FGBNJEBGKMH(string PAECKDINGMD, string EADLCNJELLB, [Optional] NKEGCDFIBBN FJNGLAKPPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5B8CF70", Offset = "0x5B8C370", VA = "0x185B8CF70", Slot = "11")]
	public AFGBDCJCGDG NMOOBIADKPM(NKEGCDFIBBN FJNGLAKPPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5B8C450", Offset = "0x5B8B850", VA = "0x185B8C450", Slot = "12")]
	public AFGBDCJCGDG EPMGKDOKPEB(NKEGCDFIBBN FJNGLAKPPDG, Dictionary<string, string> KPHAHIJAKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5B8CB90", Offset = "0x5B8BF90", VA = "0x185B8CB90", Slot = "13")]
	public bool HKJDLDOLCAI(string NJKJIOKCJBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5B8CA30", Offset = "0x5B8BE30", VA = "0x185B8CA30", Slot = "14")]
	public BLJNEDFDFIB HBEBMBHCFPH(string JPPPJDKGLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5B8C2A0", Offset = "0x5B8B6A0", VA = "0x185B8C2A0", Slot = "15")]
	public PAINBPNJBKD CHAEDANIPKC(string OBOHINCDAPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5B8CD50", Offset = "0x5B8C150", VA = "0x185B8CD50", Slot = "16")]
	public AFGBDCJCGDG LBGGCCPPAJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7AA960", Offset = "0x7A9D60", VA = "0x1807AA960")]
	[CompilerGenerated]
	private void INGEBMBMEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xAD6250", Offset = "0xAD5650", VA = "0x180AD6250")]
	[CompilerGenerated]
	private void KIALHABICFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class NCDCJNFMECC : FMJHJJHGABO
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool MDIKGCAGGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7785F0", Offset = "0x7779F0", VA = "0x1807785F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string BOEABPCJGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action CADJEFKPJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5B8FD00", Offset = "0x5B8F100", VA = "0x185B8FD00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5B8FE30", Offset = "0x5B8F230", VA = "0x185B8FE30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action NFOIDICDPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5B8FF60", Offset = "0x5B8F360", VA = "0x185B8FF60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5B8FB30", Offset = "0x5B8EF30", VA = "0x185B8FB30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public NCDCJNFMECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FC60", Offset = "0x5B8F060", VA = "0x185B8FC60", Slot = "8")]
	public AFGBDCJCGDG FGBNJEBGKMH(string PAECKDINGMD, string EADLCNJELLB, [Optional] NKEGCDFIBBN FJNGLAKPPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FED0", Offset = "0x5B8F2D0", VA = "0x185B8FED0", Slot = "11")]
	public AFGBDCJCGDG NMOOBIADKPM(NKEGCDFIBBN FJNGLAKPPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FBD0", Offset = "0x5B8EFD0", VA = "0x185B8FBD0", Slot = "12")]
	public AFGBDCJCGDG EPMGKDOKPEB(NKEGCDFIBBN FJNGLAKPPDG, Dictionary<string, string> KPHAHIJAKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
	public bool HKJDLDOLCAI(string NJKJIOKCJBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FCF0", Offset = "0x5B8F0F0", VA = "0x185B8FCF0", Slot = "14")]
	public BLJNEDFDFIB HBEBMBHCFPH(string JPPPJDKGLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FB20", Offset = "0x5B8EF20", VA = "0x185B8FB20", Slot = "15")]
	public PAINBPNJBKD CHAEDANIPKC(string OBOHINCDAPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FDA0", Offset = "0x5B8F1A0", VA = "0x185B8FDA0", Slot = "16")]
	public AFGBDCJCGDG LBGGCCPPAJH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface GDOLCHEJAMG
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MFOFIAGPABA GJLBMPJOICL(string LEBBGGNFGLC);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface IJGJALGBECN
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	long LLGKCGLAGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string JLDPFHPKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string KFFBGKALLOC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	string MEOKFEPEPHE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string BGKKLACDLCK
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool NNOFJBAGEGD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long PDLIHMOFCHM();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CPMDGMFPCAJ(long MHDKPAOKAEC, bool PPODCCFGAPH = true);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KDFKCOOICPC(string FJHKACIMEOO, string ILFEKMKEOMN, string LJOHDICLGFA);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PODGNPKLGOO(string FJHKACIMEOO);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HBKCCJIINEM(string FJHKACIMEOO, string LADGDDGFHHA, string AMIPNLILGEK);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CFACDBLKOEC(string NAKFLJFKNJL, object PPMJHMBHBKB, object LCNHHEAECLC);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NKEGCDFIBBN
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool FMDJBHOLEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool DAHNBGGBHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool FMOAMHDPIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool? LAEFNLNPNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	int? HDAPECJNDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	int ENPEGABHBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string JCGIDEHMNLK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string MEJMFCAKNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string FCADOHJIEDN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	long KKDHGJGMHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string BPHPEFFPNKB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string HPCPMCHENJE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string MGCFAOPINLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string FLOPIFGFFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	double PEJDOJKHGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	int LLLFIBFBDFG
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
