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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x806E5F0", Offset = "0x806CFF0", VA = "0x18806E5F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
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
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x806DBF0", Offset = "0x806C5F0", VA = "0x18806DBF0", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x806F270", Offset = "0x806DC70", VA = "0x18806F270", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
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
		public AmplitudeAnalyticsClient.Settings KOIGNOMIJOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MCEHDCPHLPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, DFEHPODJAJA
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum DGHMANHAPOM
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class FKHIFALEOEK
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class EALNHCGAAAD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int EBDGJFLOKDK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> OPDLKKFEMEE;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
				public EALNHCGAAAD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class PNBEEMFBCPB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
				public PNBEEMFBCPB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x806EA80", Offset = "0x806D480", VA = "0x18806EA80")]
				internal bool JHLENECCFBP(EALNHCGAAAD item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string PFBKGKBAHND = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string HODLOHIDPMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<EALNHCGAAAD> LKBPKFODBPD;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? KJEDICPGJFP
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x806B960", Offset = "0x806A360", VA = "0x18806B960")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x806BCC0", Offset = "0x806A6C0", VA = "0x18806BCC0")]
			internal FKHIFALEOEK(string CDFPHGONFPI, string MKGIMOEEMKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x806BB10", Offset = "0x806A510", VA = "0x18806BB10")]
			public int OJJDACBAAIF([Optional] int? JIIBDDBAGFG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x806B370", Offset = "0x8069D70", VA = "0x18806B370")]
			public List<Dictionary<string, object>> LLKJGMGKCFN(int JOPIJKCGFHK, int? JIIBDDBAGFG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x806B1C0", Offset = "0x8069BC0", VA = "0x18806B1C0")]
			public void JJCFMECEOCD(AmplitudeAnalyticsIdentifyMessage CEFJEHJNIAP, bool FAGEILHEDKN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x806B260", Offset = "0x8069C60", VA = "0x18806B260")]
			public void JJCFMECEOCD(Dictionary<string, object> CEFJEHJNIAP, bool FAGEILHEDKN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x806AA20", Offset = "0x8069420", VA = "0x18806AA20")]
			public void EFBEAHMOKMC(params Dictionary<string, object>[] LHEAJNMGMFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x806B710", Offset = "0x806A110", VA = "0x18806B710")]
			public void NNLFOGIHODF(List<Dictionary<string, object>> CAKIPOPDDFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x806BA00", Offset = "0x806A400", VA = "0x18806BA00")]
			private void OHNAEAEIDLH(Dictionary<string, object> CEFJEHJNIAP, bool FAGEILHEDKN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x806AFB0", Offset = "0x80699B0", VA = "0x18806AFB0")]
			public void HBEDDLFGFCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x806ABB0", Offset = "0x80695B0", VA = "0x18806ABB0")]
			private void FFBEGDJLCDN([Optional] string EHLDAOMNLDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x806B5E0", Offset = "0x8069FE0", VA = "0x18806B5E0")]
			private static string NGGPCBAECBI(string PDKJBMPOMNC, string LNBCHJPEENA)
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
			[Cpp2IlInjected.Address(RVA = "0x806EE60", Offset = "0x806D860", VA = "0x18806EE60")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct HCPMBHPHKEC<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int BBPDHEABJPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string GBDGJNBKEPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T OCHDKIMEFDI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class CIKJADPCKAC : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private BHOPOIJKEJE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public CIKJADPCKAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8068DE0", Offset = "0x80677E0", VA = "0x188068DE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8069570", Offset = "0x8067F70", VA = "0x188069570", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class KFDHAFEFOPC : IEnumerator<object>, IEnumerator, IDisposable
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
			public HNFFHHICMCD quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public KFDHAFEFOPC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x806D3C0", Offset = "0x806BDC0", VA = "0x18806D3C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x806D4D0", Offset = "0x806BED0", VA = "0x18806D4D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JBIIEOLGMHG : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public JBIIEOLGMHG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x806C720", Offset = "0x806B120", VA = "0x18806C720", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x806C890", Offset = "0x806B290", VA = "0x18806C890", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class LOKHBHIEDKN : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private BHOPOIJKEJE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public LOKHBHIEDKN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x806D940", Offset = "0x806C340", VA = "0x18806D940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x806DBA0", Offset = "0x806C5A0", VA = "0x18806DBA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class PKDODJDIIIN : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private BHOPOIJKEJE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public PKDODJDIIIN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x806E7D0", Offset = "0x806D1D0", VA = "0x18806E7D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x806EA30", Offset = "0x806D430", VA = "0x18806EA30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class MDGGHMBJCCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public FKHIFALEOEK cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public MDGGHMBJCCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x806DC80", Offset = "0x806C680", VA = "0x18806DC80")]
			internal void JKEJONMOLHK(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x806DFA0", Offset = "0x806C9A0", VA = "0x18806DFA0")]
			internal void KDHAFACGLEF(HCPMBHPHKEC<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class CFBOOJABLJH : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private BHOPOIJKEJE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public FKHIFALEOEK cache;

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
			private MDGGHMBJCCE <>8__1;

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
			private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public CFBOOJABLJH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8068580", Offset = "0x8066F80", VA = "0x188068580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8068D90", Offset = "0x8067790", VA = "0x188068D90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class PNIKBFDMFLF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public PNIKBFDMFLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5B5EB80", Offset = "0x5B5D580", VA = "0x185B5EB80")]
			internal HCPMBHPHKEC<T> DCKIOAPGPNC(PNPHMGPNHEK postResponse)
			{
				return default(HCPMBHPHKEC<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private OEDJIHBFGCK CPJMFIMIBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<JHJDLPAKEGG> OBPAFIDLCBM;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string IADJHICFLOK = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string OGCJHDBIOEB = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string MIKBDMGDDNP = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int INPEGAGPGFM = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int NAPMNEGOJJK = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int AJHFHCIEJFI = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float ELDNEHAALEA = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long AHKOJCLJOLI = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string IMJMOLLBHGH = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string DMCOKBPHNGO = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string EDECHKECJLF = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string FLBMMFCABLG = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool IKNDNACEPNB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool BAIGLIBCHJA;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int APHCCDGCOIG;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int MHFANNGPHEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CLLIICBMGBK IKLICNGEEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private OHEDDMLNNNP ECAHBJDLDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private GMOIKPPICLH GLGCLFNNBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool CKNOOKMFOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float BDOIJACPOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float HMDDLNPECBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int JBFIAEKDDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int NMEHFMFEMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? DBMOJDPMOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? HLMKFEFADED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long AJJJDLDLJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string EFGEJKLMNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string ADFHFCAODLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long NPIAPFFKOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string MNGNFPDECPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string CIGGOJNEDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> EHLAEOMKCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private DGHMANHAPOM JOPHBMNHPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int LPONBOOEFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int FEKOIDCGGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float MGPLDGNEILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool PKFEEPAKJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool GOOHAMNOKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private FKHIFALEOEK CDIEIMFIFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private FKHIFALEOEK BCJOCLNHGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private FKHIFALEOEK IBGCEGPKLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string CJGJCBJOEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> FLHLDAALLJL;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo GLKCDHALKGM;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string HIMIDKNICKE;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string MMNGANIMGAH = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string PNMPJPHJOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string GFOFGGHMLEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string OKPOFNFOJBB;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private OEDJIHBFGCK BEOAIEHGPCE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x80608F0", Offset = "0x805F2F0", VA = "0x1880608F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private JHJDLPAKEGG LPOPHLDAHCA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x805E6C0", Offset = "0x805D0C0", VA = "0x18805E6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int IBAONGOFGED
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x805F230", Offset = "0x805DC30", VA = "0x18805F230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long OKBODONOABJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x80628C0", Offset = "0x80612C0", VA = "0x1880628C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x80629D0", Offset = "0x80613D0", VA = "0x1880629D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string GOPJGMLFGEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8062890", Offset = "0x8061290", VA = "0x188062890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HAAHJMNIMKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x16D2AF0", Offset = "0x16D14F0", VA = "0x1816D2AF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x16D14E0", Offset = "0x16CFEE0", VA = "0x1816D14E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OOHADEBOMAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB0A4B0", Offset = "0xB08EB0", VA = "0x180B0A4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB06350", Offset = "0xB04D50", VA = "0x180B06350")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? DIJMFFFNHIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAFE220", Offset = "0xAFCC20", VA = "0x180AFE220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAFE230", Offset = "0xAFCC30", VA = "0x180AFE230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HFKHLPNGJJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAFE210", Offset = "0xAFCC10", VA = "0x180AFE210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xB27510", Offset = "0xB25F10", VA = "0x180B27510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool ONAOFPCDPCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8062790", Offset = "0x8061190", VA = "0x188062790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> LLIHNGODOGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x80626D0", Offset = "0x80610D0", VA = "0x1880626D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8062910", Offset = "0x8061310", VA = "0x188062910")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x805CF70", Offset = "0x805B970", VA = "0x18805CF70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x805F510", Offset = "0x805DF10", VA = "0x18805F510")]
		private void IOMNOFLDOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8061D00", Offset = "0x8060700", VA = "0x188061D00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8060980", Offset = "0x805F380", VA = "0x188060980", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8062030", Offset = "0x8060A30", VA = "0x188062030")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8060A40", Offset = "0x805F440", VA = "0x188060A40")]
		public PNBAKNHPHGJ PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x805FDF0", Offset = "0x805E7F0", VA = "0x18805FDF0")]
		[IteratorStateMachine(typeof(CIKJADPCKAC))]
		public IEnumerator<BHOPOIJKEJE> InitializeForLocalAccount(AmplitudeAnalyticsEvent OKODGLHHDBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80613C0", Offset = "0x805FDC0", VA = "0x1880613C0")]
		public void SendAppEnterEvent(bool EJBPMFHCCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8061FB0", Offset = "0x80609B0", VA = "0x188061FB0")]
		public void UpdateLastKnownInteractionCategory(string OFPMGBEFKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8061F00", Offset = "0x8060900", VA = "0x188061F00")]
		public void UpdateLastAliveTime(float NIHEEOMEEPL = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x805EA00", Offset = "0x805D400", VA = "0x18805EA00")]
		private PNBAKNHPHGJ EAHJHMIKJBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x805E550", Offset = "0x805CF50", VA = "0x18805E550")]
		private PNBAKNHPHGJ CDKEBDOMOLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80616D0", Offset = "0x80600D0", VA = "0x1880616D0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x805EDD0", Offset = "0x805D7D0", VA = "0x18805EDD0")]
		[IteratorStateMachine(typeof(KFDHAFEFOPC))]
		private IEnumerator FCDBDNOBFMJ(HNFFHHICMCD EDGDNKCGAAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80622C0", Offset = "0x8060CC0", VA = "0x1880622C0")]
		[IteratorStateMachine(typeof(JBIIEOLGMHG))]
		public IEnumerator WaitForFlush(float LCCCJECCOIL = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8061DE0", Offset = "0x80607E0", VA = "0x188061DE0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8061D20", Offset = "0x8060720", VA = "0x188061D20")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime FPIFKAOGCDC)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x805F8D0", Offset = "0x805E2D0", VA = "0x18805F8D0")]
		public static ELBEOPJMOKN Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x805CDC0", Offset = "0x805B7C0", VA = "0x18805CDC0")]
		public static JLBGHIMCEJJ AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string HDLMNNDMHMA, string PJLPOHFCGBL, GECHJFPPMNA ANEHNMLFAFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x805EAC0", Offset = "0x805D4C0", VA = "0x18805EAC0")]
		public static JLBGHIMCEJJ Event([JetBrains.Annotations.NotNull] string HDLMNNDMHMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8060BE0", Offset = "0x805F5E0", VA = "0x188060BE0")]
		public static JLBGHIMCEJJ PreviousSessionEvent([JetBrains.Annotations.NotNull] string HDLMNNDMHMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x805FA80", Offset = "0x805E480", VA = "0x18805FA80")]
		public static JLBGHIMCEJJ InitializeEvent(string PJLPOHFCGBL, int MPHPIOCMHDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80618D0", Offset = "0x80602D0", VA = "0x1880618D0")]
		public static JLBGHIMCEJJ StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x805E710", Offset = "0x805D110", VA = "0x18805E710")]
		public static JLBGHIMCEJJ CreateOutOfSessionEvent(string HDLMNNDMHMA, bool PIKCIKJGCNE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8060360", Offset = "0x805ED60", VA = "0x188060360")]
		public static PNBAKNHPHGJ LogOutOfSessionEvent(JLBGHIMCEJJ INBBCGDHOCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80600E0", Offset = "0x805EAE0", VA = "0x1880600E0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LPIFKNMLBKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8060530", Offset = "0x805EF30", VA = "0x188060530")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LPIFKNMLBKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8060670", Offset = "0x805F070", VA = "0x188060670")]
		public void LogSerializedEventAsync(Dictionary<string, object> PBONGBNPONN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8060220", Offset = "0x805EC20", VA = "0x188060220")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage PIMCAPDIPMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x805CCC0", Offset = "0x805B6C0", VA = "0x18805CCC0")]
		private void ANENNCFELBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x805EF80", Offset = "0x805D980", VA = "0x18805EF80")]
		private void HOKPINHDHAF(Dictionary<string, object> PGLEJOKJMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x805FE80", Offset = "0x805E880", VA = "0x18805FE80")]
		private void JDFIPKEFNMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x805E330", Offset = "0x805CD30", VA = "0x18805E330")]
		private void BDDDJECFIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x805EE60", Offset = "0x805D860", VA = "0x18805EE60")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8060750", Offset = "0x805F150", VA = "0x188060750")]
		[IteratorStateMachine(typeof(LOKHBHIEDKN))]
		private IEnumerator<BHOPOIJKEJE> ODEKPIKEIGM(float LCCCJECCOIL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x805EEF0", Offset = "0x805D8F0", VA = "0x18805EEF0")]
		[IteratorStateMachine(typeof(PKDODJDIIIN))]
		private IEnumerator<BHOPOIJKEJE> GANBEDNHNLJ(float LCCCJECCOIL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x805F430", Offset = "0x805DE30", VA = "0x18805F430")]
		[IteratorStateMachine(typeof(CFBOOJABLJH))]
		private IEnumerator<BHOPOIJKEJE> IKHJBABHHAO(FKHIFALEOEK FNLAOKPMGLM, int? JIIBDDBAGFG, string GEALHIFKOJA, float LCCCJECCOIL, Action<int> ECDNJMJHEAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x80607E0", Offset = "0x805F1E0", VA = "0x1880607E0")]
		private static void OFJLIKHNEHK(bool EHDGJALCANP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x805C980", Offset = "0x805B380", VA = "0x18805C980")]
		private DPMDGLGHBHJ<HCPMBHPHKEC<Dictionary<string, object>>> AEIGNBEPKJI(string GEALHIFKOJA, string DOPBNMMPAOP, Dictionary<string, object> OCHDKIMEFDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x805CA50", Offset = "0x805B450", VA = "0x18805CA50")]
		private DPMDGLGHBHJ<HCPMBHPHKEC<List<Dictionary<string, object>>>> AEIGNBEPKJI(string GEALHIFKOJA, string DOPBNMMPAOP, List<Dictionary<string, object>> OCHDKIMEFDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3201110", Offset = "0x31FFB10", VA = "0x183201110")]
		private DPMDGLGHBHJ<HCPMBHPHKEC<T>> IGNHENIHECD<T>(string NJCFLFCMPKC, string GEALHIFKOJA, string DOPBNMMPAOP, T OCHDKIMEFDI, Dictionary<string, object> NBMOCONBMNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x805E500", Offset = "0x805CF00", VA = "0x18805E500")]
		private bool CCGNDLOPAPP(float ABGKAAONMGB, float LCCCJECCOIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x805D5D0", Offset = "0x805BFD0", VA = "0x18805D5D0")]
		private Dictionary<string, object> BDDDIBANBON(string GEALHIFKOJA, Dictionary<string, object> OCHDKIMEFDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x80623B0", Offset = "0x8060DB0", VA = "0x1880623B0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAB2D40", Offset = "0xAB1740", VA = "0x180AB2D40", Slot = "6")]
		private bool OELMCBECINB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x805FF70", Offset = "0x805E970", VA = "0x18805FF70")]
		[CompilerGenerated]
		private long KBNOLAOFMKF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x805E9F0", Offset = "0x805D3F0", VA = "0x18805E9F0")]
		[CompilerGenerated]
		private void DNDJKJNIHHA(int OOBKOIPBJEO)
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
			[Cpp2IlInjected.Address(RVA = "0x80636E0", Offset = "0x80620E0", VA = "0x1880636E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x80637C0", Offset = "0x80621C0", VA = "0x1880637C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8063720", Offset = "0x8062120", VA = "0x188063720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8063820", Offset = "0x8062220", VA = "0x188063820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x80636A0", Offset = "0x80620A0", VA = "0x1880636A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8063760", Offset = "0x8062160", VA = "0x188063760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA841F0", Offset = "0xA82BF0", VA = "0x180A841F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8063400", Offset = "0x8061E00", VA = "0x188063400")]
		public static JLBGHIMCEJJ OIDBKGGJJLH(string OHBCMIBMOPM, [JetBrains.Annotations.NotNull] string PPGAEGJEDLO, long NECAJFCJIIO, long NIEJHDIFLBM, string PJLPOHFCGBL, string ANEHNMLFAFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8063190", Offset = "0x8061B90", VA = "0x188063190")]
		public static JLBGHIMCEJJ KKGIDJOBELF(string OHBCMIBMOPM, [JetBrains.Annotations.NotNull] string PPGAEGJEDLO, long NECAJFCJIIO, long NIEJHDIFLBM, string PJLPOHFCGBL, long LGHGGCOBNBA, string PLHIIGNEMBK, string BPHJPJGBMEC, string AGHFEMKCMNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8063500", Offset = "0x8061F00", VA = "0x188063500")]
		private AmplitudeAnalyticsEvent(string OHBCMIBMOPM, [JetBrains.Annotations.NotNull] string PPGAEGJEDLO, long NECAJFCJIIO, long NIEJHDIFLBM, string PJLPOHFCGBL, string ANEHNMLFAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xFAD8C0", Offset = "0xFAC2C0", VA = "0x180FAD8C0")]
		public void HFMGOHHNNFD(long NIINPEJKEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8063080", Offset = "0x8061A80", VA = "0x188063080", Slot = "5")]
		public override void KAHCAPFGJEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8062F00", Offset = "0x8061900", VA = "0x188062F00", Slot = "6")]
		public override void JEOLGJCFIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8062A30", Offset = "0x8061430", VA = "0x188062A30", Slot = "4")]
		protected override Dictionary<string, object> HHBEOAMEOJJ(Dictionary<string, object> FDKGGJCNDND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x80632F0", Offset = "0x8061CF0", VA = "0x1880632F0")]
		private void NJEMLBOACFF(string LNBCHJPEENA, string PDKJBMPOMNC, bool JLDFPGHJIDJ = false)
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
			[Cpp2IlInjected.Address(RVA = "0x806A1E0", Offset = "0x8068BE0", VA = "0x18806A1E0")]
			public void JCCIAKIONME(Dictionary<string, object> AKDDMMLCCBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x806EAF0", Offset = "0x806D4F0", VA = "0x18806EAF0")]
			public void JCCIAKIONME(Dictionary<string, object> LLDJLMEGMEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x153D800", Offset = "0x153C200", VA = "0x18153D800")]
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
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8063E80", Offset = "0x8062880", VA = "0x188063E80")]
		public static ELBEOPJMOKN OIDBKGGJJLH(string OHBCMIBMOPM, string PJLPOHFCGBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8063F40", Offset = "0x8062940", VA = "0x188063F40")]
		protected AmplitudeAnalyticsIdentifyMessage(string OHBCMIBMOPM, string PJLPOHFCGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8063DF0", Offset = "0x80627F0", VA = "0x188063DF0")]
		public Dictionary<string, object> KBFALFFHCDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x80638F0", Offset = "0x80622F0", VA = "0x1880638F0", Slot = "4")]
		protected virtual Dictionary<string, object> HHBEOAMEOJJ(Dictionary<string, object> FDKGGJCNDND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8063CC0", Offset = "0x80626C0", VA = "0x188063CC0")]
		protected void JHAABDOCPIF(string LNBCHJPEENA, Dictionary<string, object> CICFDABFHFN, Dictionary<string, object> DGCILNDNBNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8063880", Offset = "0x8062280", VA = "0x188063880")]
		protected void BFDFPCPLLMM(string LNBCHJPEENA, string PDKJBMPOMNC, Dictionary<string, object> IOPIPHHCNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8063D60", Offset = "0x8062760", VA = "0x188063D60", Slot = "5")]
		public virtual void KAHCAPFGJEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8063C30", Offset = "0x8062630", VA = "0x188063C30", Slot = "6")]
		public virtual void JEOLGJCFIDJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ELBEOPJMOKN : FEFEAHGINNJ<AmplitudeAnalyticsIdentifyMessage, ELBEOPJMOKN>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override ELBEOPJMOKN LHLMIGBNJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage BNHDINMFIMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x806A410", Offset = "0x8068E10", VA = "0x18806A410")]
	public ELBEOPJMOKN(AmplitudeAnalyticsIdentifyMessage ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x806A360", Offset = "0x8068D60", VA = "0x18806A360", Slot = "4")]
	public override void JEOLGJCFIDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JLBGHIMCEJJ : FEFEAHGINNJ<AmplitudeAnalyticsEvent, JLBGHIMCEJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool GFJOHMCOKLA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override JLBGHIMCEJJ LHLMIGBNJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long MFMOGGIOGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x806D2A0", Offset = "0x806BCA0", VA = "0x18806D2A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x806C6D0", Offset = "0x806B0D0", VA = "0x18806C6D0")]
	public JLBGHIMCEJJ(AmplitudeAnalyticsEvent ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "5")]
	public override AmplitudeAnalyticsEvent BNHDINMFIMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x806D070", Offset = "0x806BA70", VA = "0x18806D070", Slot = "4")]
	public override void JEOLGJCFIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3D04B10", Offset = "0x3D03510", VA = "0x183D04B10")]
	public JLBGHIMCEJJ MHINJHDDJDB<T>(string OGFGMDINCKP, T[] PDKJBMPOMNC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D04B10", Offset = "0x3D03510", VA = "0x183D04B10")]
	public JLBGHIMCEJJ MHINJHDDJDB(string OGFGMDINCKP, string[] PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3D04860", Offset = "0x3D03260", VA = "0x183D04860")]
	public JLBGHIMCEJJ MHINJHDDJDB<T>(string OGFGMDINCKP, T PDKJBMPOMNC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x806D1B0", Offset = "0x806BBB0", VA = "0x18806D1B0")]
	public JLBGHIMCEJJ MHINJHDDJDB(string OGFGMDINCKP, long PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x806D230", Offset = "0x806BC30", VA = "0x18806D230")]
	public JLBGHIMCEJJ MHINJHDDJDB(string OGFGMDINCKP, string PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x806D040", Offset = "0x806BA40", VA = "0x18806D040")]
	public JLBGHIMCEJJ CIHGEKGGPKF(string OGFGMDINCKP, object? PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x806D110", Offset = "0x806BB10", VA = "0x18806D110")]
	public JLBGHIMCEJJ MCCNIEAPACH(string OGFGMDINCKP, string PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x806D2C0", Offset = "0x806BCC0", VA = "0x18806D2C0")]
	private JLBGHIMCEJJ PINHDENHGLD(string OGFGMDINCKP, object PDKJBMPOMNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IDLGGBDGNMH : JLBGHIMCEJJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x806C6D0", Offset = "0x806B0D0", VA = "0x18806C6D0")]
	public IDLGGBDGNMH(AmplitudeAnalyticsEvent ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x806C520", Offset = "0x806AF20", VA = "0x18806C520", Slot = "4")]
	public override void JEOLGJCFIDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class FEFEAHGINNJ<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : FEFEAHGINNJ<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M ONGDPODJNBL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR LHLMIGBNJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public FEFEAHGINNJ(M ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4DF4DD0", Offset = "0x4DF37D0", VA = "0x184DF4DD0")]
	public BLDR AJMDEIBNPBF(AmplitudeAnalyticsIdentifyMessage.DeviceInfo FAJENPDAGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4DF4E20", Offset = "0x4DF3820", VA = "0x184DF4E20")]
	public BLDR EHPFJIFPIIK(AmplitudeAnalyticsIdentifyMessage.RevenueData PJOJKJJOIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4DF4E70", Offset = "0x4DF3870", VA = "0x184DF4E70")]
	public BLDR FMJAJGJDDFI(string OGFGMDINCKP, string PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x43F85A0", Offset = "0x43F6FA0", VA = "0x1843F85A0")]
	public BLDR FMJAJGJDDFI<T>(string OGFGMDINCKP, T PDKJBMPOMNC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JEOLGJCFIDJ();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4DF4FF0", Offset = "0x4DF39F0", VA = "0x184DF4FF0")]
	internal static string LODNJAPDLDH(string PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4DF4EF0", Offset = "0x4DF38F0", VA = "0x184DF4EF0")]
	private BLDR LIKOAGKJFNE(string OGFGMDINCKP, object PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M BNHDINMFIMO();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class DJAFLMJDGAO : CLLIICBMGBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct APNECDBOCNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<PNPHMGPNHEK> <>t__builder;

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
		public DJAFLMJDGAO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x805BEE0", Offset = "0x805A8E0", VA = "0x18805BEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x805C910", Offset = "0x805B310", VA = "0x18805C910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient NNPNILNEFEG;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8069F80", Offset = "0x8068980", VA = "0x188069F80")]
	[PPMDKOHJEBA.KMGFFEOOKKA]
	internal static void GLGMGKKJCDN(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x806A160", Offset = "0x8068B60", VA = "0x18806A160")]
	[RecRoom.NoEngine.Common.Preserve]
	public DJAFLMJDGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8069FF0", Offset = "0x80689F0", VA = "0x188069FF0", Slot = "4")]
	[AsyncStateMachine(typeof(APNECDBOCNN))]
	public Task<PNPHMGPNHEK> JEKBHGAGJJF(string NJCFLFCMPKC, string NHLFIGMLKML, string AEIGHGCLPJP, string OFOMNJEKAEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class OHOBBHGAIEB : CLLIICBMGBK
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NFENEAIMLLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<PNPHMGPNHEK> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NFENEAIMLLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x806E510", Offset = "0x806CF10", VA = "0x18806E510")]
		internal void EDANMOKCBGN(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct FEIMDGANCJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<PNPHMGPNHEK> <>t__builder;

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
		private TaskAwaiter<PNPHMGPNHEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x806A460", Offset = "0x8068E60", VA = "0x18806A460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x806A9B0", Offset = "0x80693B0", VA = "0x18806A9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	[PPMDKOHJEBA.KMGFFEOOKKA]
	internal static void DNKFKFENFHB(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OHOBBHGAIEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x806E670", Offset = "0x806D070", VA = "0x18806E670", Slot = "4")]
	[AsyncStateMachine(typeof(FEIMDGANCJL))]
	public Task<PNPHMGPNHEK> JEKBHGAGJJF(string NJCFLFCMPKC, string NHLFIGMLKML, string AEIGHGCLPJP, string OFOMNJEKAEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BJNAPAGJKKN
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> PEPIICCJLMG;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8065EB0", Offset = "0x80648B0", VA = "0x188065EB0")]
	internal static bool PIIJIHCLNOD(string LNBCHJPEENA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface CLLIICBMGBK
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PNPHMGPNHEK> JEKBHGAGJJF(string NJCFLFCMPKC, string NHLFIGMLKML, string AEIGHGCLPJP, string OFOMNJEKAEO);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct PNPHMGPNHEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int OEPLIOMPGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string FFCCIDJOONG;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1900540", Offset = "0x18FEF40", VA = "0x181900540")]
	public PNPHMGPNHEK(int BBPDHEABJPP, string GBDGJNBKEPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum FEJOAPDPGOJ
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
public class JDJLBPFGIAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private long JOLHAAGJKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private JLBGHIMCEJJ AENNGECCLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool GDAEEDLAFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private float OBDDMOILNLM;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x806CC70", Offset = "0x806B670", VA = "0x18806CC70")]
	public JDJLBPFGIAP(string APCDCLBLKAG, float OBDDMOILNLM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4A80", Offset = "0x3CF3480", VA = "0x183CF4A80")]
	public void MHINJHDDJDB<T>(string OGFGMDINCKP, T PDKJBMPOMNC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x806CB30", Offset = "0x806B530", VA = "0x18806CB30")]
	public void MHINJHDDJDB(string OGFGMDINCKP, string PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x806CA40", Offset = "0x806B440", VA = "0x18806CA40")]
	public void JJIBBCAPNOP(string IFBIHMGALCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x806CBB0", Offset = "0x806B5B0", VA = "0x18806CBB0")]
	public void NNFNADFOGMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x806C8E0", Offset = "0x806B2E0", VA = "0x18806C8E0")]
	private void EIBICKMFNCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x806C9F0", Offset = "0x806B3F0", VA = "0x18806C9F0")]
	private bool IMILABGAIHL()
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
		public enum LCIFGDDPKKM
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
		private LCIFGDDPKKM parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public LCIFGDDPKKM Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
			get
			{
				return default(LCIFGDDPKKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB3420", Offset = "0xAB1E20", VA = "0x180AB3420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x806EC60", Offset = "0x806D660", VA = "0x18806EC60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class MAANKLCFLPE<T> : ECDJEILNODO<T>, AONDODPMLML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly OADOONOPPPN LJLGJHJNHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string FJOENFKFEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly string GMKFALMHNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private T IDJLFIHEALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly T KKCMINIPIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool LCBEPKJDILH;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string JAOFMDLAIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5808770", Offset = "0x5807170", VA = "0x185808770")]
	public MAANKLCFLPE(OADOONOPPPN LJLGJHJNHOB, string FJOENFKFEOK, string GMKFALMHNPH, T KKCMINIPIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x58083D0", Offset = "0x5806DD0", VA = "0x1858083D0", Slot = "4")]
	public T LAFPCILEMFP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x58083C0", Offset = "0x5806DC0", VA = "0x1858083C0", Slot = "6")]
	public void CHLOADNGFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
public class FLEJDBCNPNA : LIMPHMCDJLA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct MENOEHDMGAE : IEquatable<MENOEHDMGAE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly string NBNBLBCGHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly string EJFCEINOBJH;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xC12020", Offset = "0xC10A20", VA = "0x180C12020")]
		public MENOEHDMGAE(string LCHLAIPKLJN, string BKDDHDKNNOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x13BE890", Offset = "0x13BD290", VA = "0x1813BE890", Slot = "4")]
		public bool Equals(MENOEHDMGAE EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x806E3F0", Offset = "0x806CDF0", VA = "0x18806E3F0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x806E4A0", Offset = "0x806CEA0", VA = "0x18806E4A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private OADOONOPPPN LJLGJHJNHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Dictionary<MENOEHDMGAE, AONDODPMLML> DMPEPAECELD;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x806C0F0", Offset = "0x806AAF0", VA = "0x18806C0F0")]
	[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
	internal static void INJFIJEPFFK(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x806C160", Offset = "0x806AB60", VA = "0x18806C160")]
	[RecRoom.NoEngine.Common.Preserve]
	public FLEJDBCNPNA([System.Diagnostics.CodeAnalysis.NotNull][LNLOHEINMEO(null)] OADOONOPPPN LJLGJHJNHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x806BE30", Offset = "0x806A830", VA = "0x18806BE30", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x806C0E0", Offset = "0x806AAE0", VA = "0x18806C0E0")]
	private void EGMBPOCPEAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x806BF30", Offset = "0x806A930", VA = "0x18806BF30")]
	private void EDBLKOEMCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3C55200", Offset = "0x3C53C00", VA = "0x183C55200", Slot = "4")]
	public ECDJEILNODO<T> BACNAJFFPJK<T>(string FJOENFKFEOK, string BHIEAHEDEPP, T KKCMINIPIBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class HBOCJLKGICH : CDCEEIHLBMN, KACDFBHMNKD
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void CDCOAJIIJKD(FJPLDHCCCBF BOPGAHLLAHF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly IDIFDIIANPB HKDHOCODDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly CDCOAJIIJKD LBJDCIJEADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly string FOEMBEKAIJD;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x128DFA0", Offset = "0x128C9A0", VA = "0x18128DFA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string LFPMIKJMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1E285C0", Offset = "0x1E26FC0", VA = "0x181E285C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool BJNMAMMENKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x806C4E0", Offset = "0x806AEE0", VA = "0x18806C4E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool BFEIBICAEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x806C500", Offset = "0x806AF00", VA = "0x18806C500", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyList<string> NMENJHEPKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1E285A0", Offset = "0x1E26FA0", VA = "0x181E285A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1441CB0", Offset = "0x14406B0", VA = "0x181441CB0")]
	public HBOCJLKGICH(IDIFDIIANPB CJFJFBGGCAJ, string PNBDEHFPLDN, [Optional] CDCOAJIIJKD IECEMJHNCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3C7C310", Offset = "0x3C7AD10", VA = "0x183C7C310", Slot = "9")]
	public T DHBICMHDGKM<T>(string LNBCHJPEENA, T KKCMINIPIBD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class BNEGBEDCCMA : OADOONOPPPN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BDLFHFGKJJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public OHEDDMLNNNP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public BNEGBEDCCMA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8064000", Offset = "0x8062A00", VA = "0x188064000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8064970", Offset = "0x8063370", VA = "0x188064970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct BEBJHKDJMHP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80649D0", Offset = "0x80633D0", VA = "0x1880649D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8064BB0", Offset = "0x80635B0", VA = "0x188064BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct BPMCCKJCJIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public OHEDDMLNNNP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public BNEGBEDCCMA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x80680E0", Offset = "0x8066AE0", VA = "0x1880680E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8068520", Offset = "0x8066F20", VA = "0x188068520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct LKGFACKHEDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public BNEGBEDCCMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public OHEDDMLNNNP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x806D520", Offset = "0x806BF20", VA = "0x18806D520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x806D8E0", Offset = "0x806C2E0", VA = "0x18806D8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly IReadOnlyDictionary<string, OCGFBFKLCDG> CCGAMCNKFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool LNGCHKMJJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private bool PLNHKCPFEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private TaskCompletionSource<bool> FCPJBNDGNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private TaskCompletionSource<bool> GACOLFLBBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly SemaphoreSlim MKDPAOKDNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private KJPPBLPICEB DCIJHLPMADK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task KHLLIICDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x80661A0", Offset = "0x8064BA0", VA = "0x1880661A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task CMLIKJKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8067CF0", Offset = "0x80666F0", VA = "0x188067CF0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LBDDOODJBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool NPCGGLBFJLI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xB50B30", Offset = "0xB4F530", VA = "0x180B50B30", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string OOHADEBOMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8067CE0", Offset = "0x80666E0", VA = "0x188067CE0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public BALAFNIDLJF JPILIEGPKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8067450", Offset = "0x8065E50", VA = "0x188067450", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OLDIHALGCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8067640", Offset = "0x8066040", VA = "0x188067640", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8067A90", Offset = "0x8066490", VA = "0x188067A90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action OJDAKIIPCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8066100", Offset = "0x8064B00", VA = "0x188066100", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8066290", Offset = "0x8064C90", VA = "0x188066290", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action EIMHHEMILFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x80673B0", Offset = "0x8065DB0", VA = "0x1880673B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8066060", Offset = "0x8064A60", VA = "0x188066060", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<FJPLDHCCCBF> NHGEAFKMKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8066540", Offset = "0x8064F40", VA = "0x188066540", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x80678F0", Offset = "0x80662F0", VA = "0x1880678F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x80665F0", Offset = "0x8064FF0", VA = "0x1880665F0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8067480", Offset = "0x8065E80", VA = "0x188067480", Slot = "12")]
	[AsyncStateMachine(typeof(BDLFHFGKJJC))]
	public Task ICNIAFDKEKI(string MKGIMOEEMKE, [Optional] OHEDDMLNNNP KMIHMPGPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x80661E0", Offset = "0x8064BE0", VA = "0x1880661E0", Slot = "24")]
	[AsyncStateMachine(typeof(BEBJHKDJMHP))]
	public Task CELNCAKHCJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8067D30", Offset = "0x8066730", VA = "0x188067D30", Slot = "19")]
	[AsyncStateMachine(typeof(BPMCCKJCJIF))]
	public Task OILDPGODFJL(OHEDDMLNNNP KMIHMPGPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x80675A0", Offset = "0x8065FA0", VA = "0x1880675A0")]
	private void IFGCEEMGAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8066610", Offset = "0x8065010", VA = "0x188066610", Slot = "20")]
	[AsyncStateMachine(typeof(LKGFACKHEDP))]
	public Task EEKMMBCJLID(OHEDDMLNNNP KMIHMPGPMOB, Dictionary<string, string> HHMNMLKMPNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x80679A0", Offset = "0x80663A0", VA = "0x1880679A0", Slot = "21")]
	public bool KNIHCLPGNJM(string ANMLAIKJMJB, bool ILMAJIHPIKG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x80671B0", Offset = "0x8065BB0", VA = "0x1880671B0", Slot = "22")]
	public CDCEEIHLBMN HAGOHDMPFHA(string PNBDEHFPLDN, bool ILMAJIHPIKG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8066330", Offset = "0x8064D30", VA = "0x188066330")]
	private IDIFDIIANPB DHFHDNOPLIG(string PNBDEHFPLDN, bool ILMAJIHPIKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8067B30", Offset = "0x8066530", VA = "0x188067B30", Slot = "23")]
	public BMLGBJHAGKF NFAMLKABCDD(string LCHLAIPKLJN, bool ILMAJIHPIKG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x80676E0", Offset = "0x80660E0", VA = "0x1880676E0")]
	private PALLMCAKPAI IONJCDINHEH(string LCHLAIPKLJN, bool ILMAJIHPIKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x80668D0", Offset = "0x80652D0", VA = "0x1880668D0")]
	private JLKMAJGAFHL GBACILGPMLE(OHEDDMLNNNP KMIHMPGPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8066720", Offset = "0x8065120", VA = "0x188066720")]
	private CJIEJNNIGAH EJNHBLMLNDJ(string MKGIMOEEMKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x80677E0", Offset = "0x80661E0", VA = "0x1880677E0")]
	private void JKKKKNOKGLE(string PNBDEHFPLDN, IDIFDIIANPB CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8067FE0", Offset = "0x80669E0", VA = "0x188067FE0")]
	public BNEGBEDCCMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8067370", Offset = "0x8065D70", VA = "0x188067370")]
	[CompilerGenerated]
	private void HHOIOIFLJJN(FJPLDHCCCBF PENFKHFIGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8067370", Offset = "0x8065D70", VA = "0x188067370")]
	[CompilerGenerated]
	private void KDBMIHCNDDG(FJPLDHCCCBF PENFKHFIGID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class BFHHMMFLMEP : OADOONOPPPN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct ALKAAMJIGGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public BFHHMMFLMEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public OHEDDMLNNNP userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x805B500", Offset = "0x8059F00", VA = "0x18805B500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x805BE80", Offset = "0x805A880", VA = "0x18805BE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct JGPPHDLOMFD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x806CE00", Offset = "0x806B800", VA = "0x18806CE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private BNEGBEDCCMA OIEBKBMLKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private TaskCompletionSource<bool> FCPJBNDGNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private TaskCompletionSource<bool> GACOLFLBBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Task DDNKIKGLBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Task BMIBNHLEKOF;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private OADOONOPPPN EJHJDCLJFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x80651F0", Offset = "0x8063BF0", VA = "0x1880651F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool NPCGGLBFJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8065BC0", Offset = "0x80645C0", VA = "0x188065BC0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool LBDDOODJBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8064DF0", Offset = "0x80637F0", VA = "0x188064DF0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task KHLLIICDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8064D50", Offset = "0x8063750", VA = "0x188064D50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task CMLIKJKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8065BD0", Offset = "0x80645D0", VA = "0x188065BD0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string OOHADEBOMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8065BA0", Offset = "0x80645A0", VA = "0x188065BA0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public BALAFNIDLJF JPILIEGPKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x80653C0", Offset = "0x8063DC0", VA = "0x1880653C0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action OJDAKIIPCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8064CB0", Offset = "0x80636B0", VA = "0x188064CB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8064F50", Offset = "0x8063950", VA = "0x188064F50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action OLDIHALGCEA
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8065510", Offset = "0x8063F10", VA = "0x188065510", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8065970", Offset = "0x8064370", VA = "0x188065970", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action EIMHHEMILFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8065320", Offset = "0x8063D20", VA = "0x188065320", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8064C10", Offset = "0x8063610", VA = "0x188064C10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<FJPLDHCCCBF> NHGEAFKMKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8064FF0", Offset = "0x80639F0", VA = "0x188064FF0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x80657A0", Offset = "0x80641A0", VA = "0x1880657A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8065DF0", Offset = "0x80647F0", VA = "0x188065DF0")]
	[UnityEngine.Scripting.Preserve]
	public BFHHMMFLMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x8065730", Offset = "0x8064130", VA = "0x188065730")]
	[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
	internal static void INJFIJEPFFK(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8065C70", Offset = "0x8064670", VA = "0x188065C70")]
	internal static void OHOPKLJLOMF(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x80650A0", Offset = "0x8063AA0", VA = "0x1880650A0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x8065400", Offset = "0x8063E00", VA = "0x188065400", Slot = "12")]
	[AsyncStateMachine(typeof(ALKAAMJIGGN))]
	public Task ICNIAFDKEKI(string MKGIMOEEMKE, [Optional] OHEDDMLNNNP KMIHMPGPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8065CE0", Offset = "0x80646E0", VA = "0x188065CE0", Slot = "19")]
	public Task OILDPGODFJL(OHEDDMLNNNP KMIHMPGPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x80650D0", Offset = "0x8063AD0", VA = "0x1880650D0", Slot = "20")]
	public Task EEKMMBCJLID(OHEDDMLNNNP KMIHMPGPMOB, Dictionary<string, string> HHMNMLKMPNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8065850", Offset = "0x8064250", VA = "0x188065850", Slot = "21")]
	public bool KNIHCLPGNJM(string ANMLAIKJMJB, bool ILMAJIHPIKG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8065260", Offset = "0x8063C60", VA = "0x188065260", Slot = "22")]
	public CDCEEIHLBMN HAGOHDMPFHA(string PNBDEHFPLDN, bool ILMAJIHPIKG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8065AE0", Offset = "0x80644E0", VA = "0x188065AE0", Slot = "23")]
	public BMLGBJHAGKF NFAMLKABCDD(string LCHLAIPKLJN, bool ILMAJIHPIKG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8064E00", Offset = "0x8063800", VA = "0x188064E00", Slot = "24")]
	public Task CELNCAKHCJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x80655B0", Offset = "0x8063FB0", VA = "0x1880655B0")]
	private static void INBGJMBPIFK(TaskCompletionSource<bool> ALJABHEDHBP, Task KILJDNODINA, Task HFGIACPJFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x8065A10", Offset = "0x8064410", VA = "0x188065A10")]
	[AsyncStateMachine(typeof(JGPPHDLOMFD))]
	private static void MPHJJCPLEHC(Task AIPCFMDLKCK, TaskCompletionSource<bool> ALJABHEDHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xFA76D0", Offset = "0xFA60D0", VA = "0x180FA76D0")]
	[CompilerGenerated]
	private void CLDBFPACGEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x105E040", Offset = "0x105CA40", VA = "0x18105E040")]
	[CompilerGenerated]
	private void DPCEOOGJCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xE18BC0", Offset = "0xE175C0", VA = "0x180E18BC0")]
	[CompilerGenerated]
	private void PGGCJELDKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x8064F10", Offset = "0x8063910", VA = "0x188064F10")]
	[CompilerGenerated]
	private void CMLLNBFFLAJ(FJPLDHCCCBF PENFKHFIGID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class PBNMEENPDHB : BMLGBJHAGKF, KACDFBHMNKD
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate void GLICODBOLFG(FJPLDHCCCBF BOPGAHLLAHF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly GLICODBOLFG LBJDCIJEADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly PALLMCAKPAI ALDNFHBBMBI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5A471D0", Offset = "0x5A45BD0", VA = "0x185A471D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string LFPMIKJMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xF4BEC0", Offset = "0xF4A8C0", VA = "0x180F4BEC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x72719A0", Offset = "0x72703A0", VA = "0x1872719A0")]
	public PBNMEENPDHB(PALLMCAKPAI FJOENFKFEOK, [Optional] GLICODBOLFG IECEMJHNCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3E57A60", Offset = "0x3E56460", VA = "0x183E57A60", Slot = "6")]
	public T DHBICMHDGKM<T>(string LNBCHJPEENA, T KKCMINIPIBD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GKCAOOEMEGB
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[UsedImplicitly]
public class FMFIOCJMPJM : GKCAOOEMEGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly LFFEFBOGOJD DIFIPPIKDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly List<CNNNFHGDLNJ> KDEIGGDDLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly string JGLDAEEPEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly string KNFHHKLKJJM;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x806C310", Offset = "0x806AD10", VA = "0x18806C310")]
	[UsedImplicitly]
	[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
	internal static void EIKIOMKMPDG(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x806C380", Offset = "0x806AD80", VA = "0x18806C380")]
	[RecRoom.NoEngine.Common.Preserve]
	internal FMFIOCJMPJM([LNLOHEINMEO(null)][JetBrains.Annotations.NotNull] LFFEFBOGOJD DIFIPPIKDLK, [LNLOHEINMEO(null)][JetBrains.Annotations.NotNull] PELCFBNBCGD NFOLOAHPADH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class COKLJHKDGEO : OADOONOPPPN
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Task KHLLIICDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8069700", Offset = "0x8068100", VA = "0x188069700", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task CMLIKJKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8069E60", Offset = "0x8068860", VA = "0x188069E60", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool NPCGGLBFJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LBDDOODJBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string OOHADEBOMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public BALAFNIDLJF JPILIEGPKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action OJDAKIIPCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8069660", Offset = "0x8068060", VA = "0x188069660", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8069820", Offset = "0x8068220", VA = "0x188069820", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action OLDIHALGCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8069BE0", Offset = "0x80685E0", VA = "0x188069BE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8069D30", Offset = "0x8068730", VA = "0x188069D30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action EIMHHEMILFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8069AB0", Offset = "0x80684B0", VA = "0x188069AB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x80695C0", Offset = "0x8067FC0", VA = "0x1880695C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<FJPLDHCCCBF> NHGEAFKMKAK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x80698C0", Offset = "0x80682C0", VA = "0x1880698C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8069C80", Offset = "0x8068680", VA = "0x188069C80", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public COKLJHKDGEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8069B50", Offset = "0x8068550", VA = "0x188069B50", Slot = "12")]
	public Task ICNIAFDKEKI(string MKGIMOEEMKE, [Optional] OHEDDMLNNNP KMIHMPGPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8069EF0", Offset = "0x80688F0", VA = "0x188069EF0", Slot = "19")]
	public Task OILDPGODFJL(OHEDDMLNNNP KMIHMPGPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8069970", Offset = "0x8068370", VA = "0x188069970", Slot = "20")]
	public Task EEKMMBCJLID(OHEDDMLNNNP KMIHMPGPMOB, Dictionary<string, string> HHMNMLKMPNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "21")]
	public bool KNIHCLPGNJM(string ANMLAIKJMJB, bool ILMAJIHPIKG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8069A00", Offset = "0x8068400", VA = "0x188069A00", Slot = "22")]
	public CDCEEIHLBMN HAGOHDMPFHA(string PNBDEHFPLDN, bool ILMAJIHPIKG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8069DD0", Offset = "0x80687D0", VA = "0x188069DD0", Slot = "23")]
	public BMLGBJHAGKF NFAMLKABCDD(string LCHLAIPKLJN, bool ILMAJIHPIKG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8069790", Offset = "0x8068190", VA = "0x188069790", Slot = "24")]
	public Task CELNCAKHCJF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class KJPPBLPICEB : BALAFNIDLJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly JLKMAJGAFHL ELFGGJHALNG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IReadOnlyDictionary<string, object> ICBJJLPFGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xF497E0", Offset = "0xF481E0", VA = "0x180F497E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public KJPPBLPICEB(JLKMAJGAFHL BIKFFCNEMFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GBAGGFLJINF
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JDJLBPFGIAP JLNFBKAENHH(string APCDCLBLKAG);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface GMOIKPPICLH
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum LLEFPGHNAJF
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

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum GGJJMJAPMNE
	{
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Add,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Remove,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Purchase,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		RemoveFromUpdate
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	long HJOPAELMOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string FDNNCCPEFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string EHPKAHDLALC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool DHMBPPPMEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long KJFDLHMGGOD();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MJODJHJFPJC(long NECAJFCJIIO, bool JLDFPGHJIDJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AFNMKBILELJ(string HCLPHJDKMCA, string INOODCMMOCF, string MEEIPJGKJCN);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NGPPMCDMBPI(Guid DIOJHPPMMOA, Guid JGDJHHJKBEP, bool JGFPOIEAMOF);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LMNMILBJEOM(string HCLPHJDKMCA);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MFJKIEANONJ(string HCLPHJDKMCA, string BAJNNCIOPBC, string CPNOEBMCDPL);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JEECBBBKAND(string HJIKHCCLFIK, object FPNHBACLOOO, object NCLFMDEEAIM);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HOOBEFOCDBM(LLEFPGHNAJF HOEBMBKPLJP, int BOILODJDIKH, [Optional] MJCBLPBPAOA MJBLJJDMODF, [Optional] string JBNEHDCIDPM, [Optional] string GFHOJCCMEDK);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MBMEAPBJKNI(MJCBLPBPAOA MJBLJJDMODF, long IFKMEFFOHLD, long OKJJDDKMDFH, int PCALEEDDNHI, string JBNEHDCIDPM, int BOILODJDIKH);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FNFHEOPFMKF(MJCBLPBPAOA MJBLJJDMODF, bool CEHCEBOGFEO, [Optional] string GFHOJCCMEDK);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NLGEHEHMLBE(MJCBLPBPAOA MJBLJJDMODF, bool CEHCEBOGFEO, [Optional] string GFHOJCCMEDK);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GMLFGAHGGDA(MJCBLPBPAOA MJBLJJDMODF, bool CEHCEBOGFEO, [Optional] string GFHOJCCMEDK);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LCLGNFCHLBB(long DKMPIOFKFMN, string BJJFKLKMAGH);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DOEPBPFNOIF(string HDDLNGLMMKN);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task MLFGPFPEDDA(GGJJMJAPMNE FOAIPBIEILM, Guid? CFAEOHGJKBI, List<LDKLCMHOOFP> HGKLIBAJEOL, List<LDKLCMHOOFP> BNACCMJIDCB, Func<DCGEDIHFEKC, long> ODEEBCNALPD, string PICBKLGJNEB, bool? NPDJPCJNOLN, [Optional] long? EBHBDHJBKIG);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface MGABMIFGCKH
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string MEGKOIBCIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
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
