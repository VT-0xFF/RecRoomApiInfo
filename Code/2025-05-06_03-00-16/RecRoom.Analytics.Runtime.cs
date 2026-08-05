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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C5130", Offset = "0x78C3930", VA = "0x1878C5130")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78C4F00", Offset = "0x78C3700", VA = "0x1878C4F00", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C60E0", Offset = "0x78C48E0", VA = "0x1878C60E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
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
		public AmplitudeAnalyticsClient.Settings ENAKBOGNKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool OIIDJPKNIJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9E0E00", Offset = "0x9DF600", VA = "0x1809E0E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, BBHLBLBMBEP
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum PGBOHOAAGBF
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class JMCIFOKNCFA
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class NPLPDNMEFKN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int FHDILNEGBFM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> FMFBILCEMNO;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
				public NPLPDNMEFKN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class CPMFBPEDMIK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
				public CPMFBPEDMIK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x78BB1D0", Offset = "0x78B99D0", VA = "0x1878BB1D0")]
				internal bool KODJCEGKPAE(NPLPDNMEFKN item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string HOBPIINGGND = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string CGOKOPBMMLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<NPLPDNMEFKN> OGNBHFENDOD;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? FOJHFDLBJPN
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x78C2FF0", Offset = "0x78C17F0", VA = "0x1878C2FF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x78C37C0", Offset = "0x78C1FC0", VA = "0x1878C37C0")]
			internal JMCIFOKNCFA(string OAOCJCKEMMG, string PIMPFFEFLEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x78C2690", Offset = "0x78C0E90", VA = "0x1878C2690")]
			public int FOGILFMPNDO([Optional] int? GHMNMNPEHDG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x78C2A80", Offset = "0x78C1280", VA = "0x1878C2A80")]
			public List<Dictionary<string, object>> HLEJDDJCELI(int BJBKHGKKIFO, int? GHMNMNPEHDG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x78C31A0", Offset = "0x78C19A0", VA = "0x1878C31A0")]
			public void NINGECEDPJC(AmplitudeAnalyticsIdentifyMessage PNHCNFOFAFI, bool DCALHAKFKLB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x78C3090", Offset = "0x78C1890", VA = "0x1878C3090")]
			public void NINGECEDPJC(Dictionary<string, object> PNHCNFOFAFI, bool DCALHAKFKLB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x78C3240", Offset = "0x78C1A40", VA = "0x1878C3240")]
			public void PBIPDHGDNNL(params Dictionary<string, object>[] CDKEPGAEHBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x78C2840", Offset = "0x78C1040", VA = "0x1878C2840")]
			public void HHCFDJOJLNJ(List<Dictionary<string, object>> KDKDNGBKDGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x78C2CF0", Offset = "0x78C14F0", VA = "0x1878C2CF0")]
			private void KMOEBCMJNPO(Dictionary<string, object> PNHCNFOFAFI, bool DCALHAKFKLB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x78C2DF0", Offset = "0x78C15F0", VA = "0x1878C2DF0")]
			public void MJABDIKIPKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x78C33C0", Offset = "0x78C1BC0", VA = "0x1878C33C0")]
			private void PLADDICLKLB([Optional] string IOMCHGGDFAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x78C2570", Offset = "0x78C0D70", VA = "0x1878C2570")]
			private static string DLACIKFEPAF(string OPMIAMEJKDH, string BELIEAFHDAH)
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
			[Cpp2IlInjected.Address(RVA = "0x78C5D00", Offset = "0x78C4500", VA = "0x1878C5D00")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct NEOCJCEPBFJ<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int EEIINABEIDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string DDBMBKPLEEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T DKBPNBICHOG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class OMFMNEFLKGD : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private IGCELENFGND <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
			[DebuggerHidden]
			public OMFMNEFLKGD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x78C51B0", Offset = "0x78C39B0", VA = "0x1878C51B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x78C5940", Offset = "0x78C4140", VA = "0x1878C5940", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class GGMFHONIJDO : IEnumerator<object>, IEnumerator, IDisposable
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
			public ADBHNDANFKF quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
			[DebuggerHidden]
			public GGMFHONIJDO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x78BFA20", Offset = "0x78BE220", VA = "0x1878BFA20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x78BFB30", Offset = "0x78BE330", VA = "0x1878BFB30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class GAEAEFJINIA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
			[DebuggerHidden]
			public GAEAEFJINIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x78BF380", Offset = "0x78BDB80", VA = "0x1878BF380", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x78BF4F0", Offset = "0x78BDCF0", VA = "0x1878BF4F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class DAAJAADAPEB : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private IGCELENFGND <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
			[DebuggerHidden]
			public DAAJAADAPEB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x78BB240", Offset = "0x78B9A40", VA = "0x1878BB240", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x78BB4A0", Offset = "0x78B9CA0", VA = "0x1878BB4A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class GJBCDGOKFNF : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private IGCELENFGND <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
			[DebuggerHidden]
			public GJBCDGOKFNF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x78BFB80", Offset = "0x78BE380", VA = "0x1878BFB80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x78BFDD0", Offset = "0x78BE5D0", VA = "0x1878BFDD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class DLKOGGELCGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public JMCIFOKNCFA cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public DLKOGGELCGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x78BD9C0", Offset = "0x78BC1C0", VA = "0x1878BD9C0")]
			internal void HNJDFBPHNNF(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x78BD570", Offset = "0x78BBD70", VA = "0x1878BD570")]
			internal void AJNEGPIODEJ(NEOCJCEPBFJ<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class EDGICHGIKOJ : IEnumerator<IGCELENFGND>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private IGCELENFGND <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public JMCIFOKNCFA cache;

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
			private DLKOGGELCGP <>8__1;

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
			private IGCELENFGND System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
			[DebuggerHidden]
			public EDGICHGIKOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x78BDE50", Offset = "0x78BC650", VA = "0x1878BDE50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x78BE650", Offset = "0x78BCE50", VA = "0x1878BE650", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class EIOGAKBDCBI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public EIOGAKBDCBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4400BA0", Offset = "0x43FF3A0", VA = "0x184400BA0")]
			internal NEOCJCEPBFJ<T> KMGFKMGHOEF(GCBHLOMINPE postResponse)
			{
				return default(NEOCJCEPBFJ<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private EOEGNJFKOMG CMMEMAAJDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<PCACFCEPBCC> EJIPODOLALG;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string HHHPGMPPMGO = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string EIGENOKLCJD = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string DPKEPBMMLCA = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int INDLBCIFOGI = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int JGIOFLKHPDN = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int GKHCCJHLPNP = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float DKOINMKEFJL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long KMPIJLKANND = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string CPHAPJHCFEJ = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string KLDHJADBCKF = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string AJJEOPLJJIA = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string FNNMDJEFDEC = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool KAEKCBFKBNK;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool KCHNOGNLMPO;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int OFLCFDMDEEK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int PICADBBIPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private JHOMNNEJONM ONIJHCMKELC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private LBKIOCABGPE CNDBPHJGDAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private CHLALMGBIDN DHEJOBGKIOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool AAJIGOBDMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float IJGACCIHGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float LHGNGNLFIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int IDMKMMNABJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int NPOGNNEPGGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? KCABOAHGFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? IPJDGHOBNMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long KHPDAAIBGOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string FEIDKEBNALO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string PLCPHPADMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long MNFIONAMNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string LOGNJPEHHEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string FLPDCOGBIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> DJBDMBPHFPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private PGBOHOAAGBF NFOADFHKDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int JGEKKDHJDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int OKNJLMMDBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float LGABFLMCDDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool EOAJMGDGOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool FIEOMBDPFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private JMCIFOKNCFA JBPGFLPBOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private JMCIFOKNCFA EHPJOPIBEMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private JMCIFOKNCFA AMNPDFFBFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string DKDFADGKKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> GJGKGCPMDHB;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo PINEIOOAEIO;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string JOHPDDJJCBH;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string DJJHFIAIMGH = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string FNLGIIPAMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string AHMJMCNFCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string POEDBLNCGNK;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private EOEGNJFKOMG EIKCICFKHEH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x78B62C0", Offset = "0x78B4AC0", VA = "0x1878B62C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private PCACFCEPBCC KEMLDPHMMIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x78B46E0", Offset = "0x78B2EE0", VA = "0x1878B46E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int IGACPFJGDOG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x78B4B10", Offset = "0x78B3310", VA = "0x1878B4B10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long HHEGGAPMMCB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x78B8590", Offset = "0x78B6D90", VA = "0x1878B8590")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x78B86A0", Offset = "0x78B6EA0", VA = "0x1878B86A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string FKOFHOFAGJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x78B8560", Offset = "0x78B6D60", VA = "0x1878B8560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool GJDHMDIAJII
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1412030", Offset = "0x1410830", VA = "0x181412030", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1410770", Offset = "0x140EF70", VA = "0x181410770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string EAAEGJFGBDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA74760", Offset = "0xA72F60", VA = "0x180A74760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA73940", Offset = "0xA72140", VA = "0x180A73940")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? HIGADEKDBLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA9F080", Offset = "0xA9D880", VA = "0x180A9F080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB616A0", Offset = "0xB5FEA0", VA = "0x180B616A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MIOMGCIBNLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xDBA380", Offset = "0xDB8B80", VA = "0x180DBA380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x12CA3A0", Offset = "0x12C8BA0", VA = "0x1812CA3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool KJCAOEKPADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x78B8440", Offset = "0x78B6C40", VA = "0x1878B8440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> FMLOABKDCKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x78B8380", Offset = "0x78B6B80", VA = "0x1878B8380")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x78B85E0", Offset = "0x78B6DE0", VA = "0x1878B85E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x78B2CC0", Offset = "0x78B14C0", VA = "0x1878B2CC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x78B2750", Offset = "0x78B0F50", VA = "0x1878B2750")]
		private void AGBACHGIGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x78B79C0", Offset = "0x78B61C0", VA = "0x1878B79C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78B63E0", Offset = "0x78B4BE0", VA = "0x1878B63E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78B7CF0", Offset = "0x78B64F0", VA = "0x1878B7CF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x78B6740", Offset = "0x78B4F40", VA = "0x1878B6740")]
		public ELBPMMKABPA PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78B5370", Offset = "0x78B3B70", VA = "0x1878B5370")]
		[IteratorStateMachine(typeof(OMFMNEFLKGD))]
		public IEnumerator<IGCELENFGND> InitializeForLocalAccount(AmplitudeAnalyticsEvent CIMCCKHNGNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x78B70A0", Offset = "0x78B58A0", VA = "0x1878B70A0")]
		public void SendAppEnterEvent(bool FKDLCAHNIIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x78B7C70", Offset = "0x78B6470", VA = "0x1878B7C70")]
		public void UpdateLastKnownInteractionCategory(string KCEANJALGDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x78B7BC0", Offset = "0x78B63C0", VA = "0x1878B7BC0")]
		public void UpdateLastAliveTime(float LMCBAJKHEDF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x78B45A0", Offset = "0x78B2DA0", VA = "0x1878B45A0")]
		private ELBPMMKABPA DDFLIHCJKGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x78B4D10", Offset = "0x78B3510", VA = "0x1878B4D10")]
		private ELBPMMKABPA HIOCLJHFKPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x78B73B0", Offset = "0x78B5BB0", VA = "0x1878B73B0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x78B4080", Offset = "0x78B2880", VA = "0x1878B4080")]
		[IteratorStateMachine(typeof(GGMFHONIJDO))]
		private IEnumerator BNMEMFNOIJI(ADBHNDANFKF BGLAMBICJML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x78B7F80", Offset = "0x78B6780", VA = "0x1878B7F80")]
		[IteratorStateMachine(typeof(GAEAEFJINIA))]
		public IEnumerator WaitForFlush(float GCGADGABLMH = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x78B7AA0", Offset = "0x78B62A0", VA = "0x1878B7AA0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x78B79E0", Offset = "0x78B61E0", VA = "0x1878B79E0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime OIKKJHNFKFP)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x78B4E80", Offset = "0x78B3680", VA = "0x1878B4E80")]
		public static HGPHJJHLIBN Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x78B2B20", Offset = "0x78B1320", VA = "0x1878B2B20")]
		public static ILHGCPKFDMA AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string IABFMBKKDKB, string GGHJBHADPCF, HODOKHJEAOB POMNIDACHEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x78B4730", Offset = "0x78B2F30", VA = "0x1878B4730")]
		public static ILHGCPKFDMA Event([JetBrains.Annotations.NotNull] string IABFMBKKDKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x78B68D0", Offset = "0x78B50D0", VA = "0x1878B68D0")]
		public static ILHGCPKFDMA PreviousSessionEvent([JetBrains.Annotations.NotNull] string IABFMBKKDKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x78B5020", Offset = "0x78B3820", VA = "0x1878B5020")]
		public static ILHGCPKFDMA InitializeEvent(string GGHJBHADPCF, int MHOMKIMEHBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x78B75B0", Offset = "0x78B5DB0", VA = "0x1878B75B0")]
		public static ILHGCPKFDMA StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x78B42E0", Offset = "0x78B2AE0", VA = "0x1878B42E0")]
		public static ILHGCPKFDMA CreateOutOfSessionEvent(string IABFMBKKDKB, bool BMCKDIPEEFA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x78B5D00", Offset = "0x78B4500", VA = "0x1878B5D00")]
		public static ELBPMMKABPA LogOutOfSessionEvent(ILHGCPKFDMA PHLOGNJPHAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x78B5AA0", Offset = "0x78B42A0", VA = "0x1878B5AA0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent FCFNKNOOOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x78B5EC0", Offset = "0x78B46C0", VA = "0x1878B5EC0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent FCFNKNOOOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x78B5FF0", Offset = "0x78B47F0", VA = "0x1878B5FF0")]
		public void LogSerializedEventAsync(Dictionary<string, object> FCPJFMHMLBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x78B5BD0", Offset = "0x78B43D0", VA = "0x1878B5BD0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage FEMOAODLBNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x78B61C0", Offset = "0x78B49C0", VA = "0x1878B61C0")]
		private void NJCPKBINMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x78B6490", Offset = "0x78B4C90", VA = "0x1878B6490")]
		private void PCHMDEHEICD(Dictionary<string, object> FNLOEDFOJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x78B60D0", Offset = "0x78B48D0", VA = "0x1878B60D0")]
		private void MLJONGCHNCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x78B4110", Offset = "0x78B2910", VA = "0x1878B4110")]
		private void CKIKMMGAPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x78B4A30", Offset = "0x78B3230", VA = "0x1878B4A30")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x78B6350", Offset = "0x78B4B50", VA = "0x1878B6350")]
		[IteratorStateMachine(typeof(DAAJAADAPEB))]
		private IEnumerator<IGCELENFGND> OLHLNCFJHOA(float GCGADGABLMH = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x78B4650", Offset = "0x78B2E50", VA = "0x1878B4650")]
		[IteratorStateMachine(typeof(GJBCDGOKFNF))]
		private IEnumerator<IGCELENFGND> DHIEBGKNHAN(float GCGADGABLMH = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x78B5400", Offset = "0x78B3C00", VA = "0x1878B5400")]
		[IteratorStateMachine(typeof(EDGICHGIKOJ))]
		private IEnumerator<IGCELENFGND> JJFAPMBMHMA(JMCIFOKNCFA JCIIFEEGFBE, int? GHMNMNPEHDG, string NJECBJLHEHH, float GCGADGABLMH, Action<int> CPCIKAKCCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x78B5990", Offset = "0x78B4190", VA = "0x1878B5990")]
		private static void LAMPCMNAPOI(bool KKONEBBCNAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x78B58C0", Offset = "0x78B40C0", VA = "0x1878B58C0")]
		private KJPDFMLMKLI<NEOCJCEPBFJ<Dictionary<string, object>>> JODCLEKKIJK(string NJECBJLHEHH, string BJKGIHLIHLN, Dictionary<string, object> DKBPNBICHOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x78B5650", Offset = "0x78B3E50", VA = "0x1878B5650")]
		private KJPDFMLMKLI<NEOCJCEPBFJ<List<Dictionary<string, object>>>> JODCLEKKIJK(string NJECBJLHEHH, string BJKGIHLIHLN, List<Dictionary<string, object>> DKBPNBICHOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3F47980", Offset = "0x3F46180", VA = "0x183F47980")]
		private KJPDFMLMKLI<NEOCJCEPBFJ<T>> ELCFKPPMDLE<T>(string DGLMNBBIDCJ, string NJECBJLHEHH, string BJKGIHLIHLN, T DKBPNBICHOG, Dictionary<string, object> LEDIHMNBJAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x78B4AC0", Offset = "0x78B32C0", VA = "0x1878B4AC0")]
		private bool HECNFBOFAKA(float GEEOJGFNPAK, float GCGADGABLMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x78B3320", Offset = "0x78B1B20", VA = "0x1878B3320")]
		private Dictionary<string, object> BIKELKECFHB(string NJECBJLHEHH, Dictionary<string, object> DKBPNBICHOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x78B8070", Offset = "0x78B6870", VA = "0x1878B8070")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA0A8D0", Offset = "0xA090D0", VA = "0x180A0A8D0", Slot = "6")]
		private bool CCGJAFGIMCA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x78B54E0", Offset = "0x78B3CE0", VA = "0x1878B54E0")]
		[CompilerGenerated]
		private long JKPPNOLIHAC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x78B2B10", Offset = "0x78B1310", VA = "0x1878B2B10")]
		[CompilerGenerated]
		private void AJJEDEHNIAI(int LMJBDIEJDIE)
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
			[Cpp2IlInjected.Address(RVA = "0x78B9380", Offset = "0x78B7B80", VA = "0x1878B9380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x78B9450", Offset = "0x78B7C50", VA = "0x1878B9450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x78B93C0", Offset = "0x78B7BC0", VA = "0x1878B93C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x78B94A0", Offset = "0x78B7CA0", VA = "0x1878B94A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x78B9340", Offset = "0x78B7B40", VA = "0x1878B9340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x78B9400", Offset = "0x78B7C00", VA = "0x1878B9400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1F0", Offset = "0x9DB9F0", VA = "0x1809DD1F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x78B90A0", Offset = "0x78B78A0", VA = "0x1878B90A0")]
		public static ILHGCPKFDMA NKIHIDGHACP(string JLNEBEJFOHB, [JetBrains.Annotations.NotNull] string LPNCCAFPPMJ, long BFGLGAEMILF, long FOHHGJELOOL, string GGHJBHADPCF, string POMNIDACHEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x78B8700", Offset = "0x78B6F00", VA = "0x1878B8700")]
		public static ILHGCPKFDMA ANPKFIMJGBB(string JLNEBEJFOHB, [JetBrains.Annotations.NotNull] string LPNCCAFPPMJ, long BFGLGAEMILF, long FOHHGJELOOL, string GGHJBHADPCF, long NICEIKIGDGG, string PLBFOIEMKNK, string KDKOCFPDNJN, string DCADABKDCFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x78B91A0", Offset = "0x78B79A0", VA = "0x1878B91A0")]
		private AmplitudeAnalyticsEvent(string JLNEBEJFOHB, [JetBrains.Annotations.NotNull] string LPNCCAFPPMJ, long BFGLGAEMILF, long FOHHGJELOOL, string GGHJBHADPCF, string POMNIDACHEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xE297B0", Offset = "0xE27FB0", VA = "0x180E297B0")]
		public void KALHDOHPNEH(long DFAGFHJEHKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x78B89D0", Offset = "0x78B71D0", VA = "0x1878B89D0", Slot = "5")]
		public override void JOICCNPGJDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x78B8860", Offset = "0x78B7060", VA = "0x1878B8860", Slot = "6")]
		public override void INLBBKDHIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x78B8BE0", Offset = "0x78B73E0", VA = "0x1878B8BE0", Slot = "4")]
		protected override Dictionary<string, object> MKKFMDKENOE(Dictionary<string, object> EONCPKJHDBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x78B8AD0", Offset = "0x78B72D0", VA = "0x1878B8AD0")]
		private void MHANGEAPGFF(string BELIEAFHDAH, string OPMIAMEJKDH, bool GICCABHJKCP = false)
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
			[Cpp2IlInjected.Address(RVA = "0x78BDCD0", Offset = "0x78BC4D0", VA = "0x1878BDCD0")]
			public void LHHAIPACFPP(Dictionary<string, object> GMHMEIKLAOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
			[Cpp2IlInjected.Address(RVA = "0x78C5990", Offset = "0x78C4190", VA = "0x1878C5990")]
			public void LHHAIPACFPP(Dictionary<string, object> DILKOIDMEDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x128F940", Offset = "0x128E140", VA = "0x18128F940")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x78B9AE0", Offset = "0x78B82E0", VA = "0x1878B9AE0")]
		public static HGPHJJHLIBN NKIHIDGHACP(string JLNEBEJFOHB, string GGHJBHADPCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x78B9BA0", Offset = "0x78B83A0", VA = "0x1878B9BA0")]
		protected AmplitudeAnalyticsIdentifyMessage(string JLNEBEJFOHB, string GGHJBHADPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x78B9560", Offset = "0x78B7D60", VA = "0x1878B9560")]
		public Dictionary<string, object> DLLLAMDJKGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x78B9700", Offset = "0x78B7F00", VA = "0x1878B9700", Slot = "4")]
		protected virtual Dictionary<string, object> MKKFMDKENOE(Dictionary<string, object> EONCPKJHDBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x78B9A40", Offset = "0x78B8240", VA = "0x1878B9A40")]
		protected void NCLKGICAPFE(string BELIEAFHDAH, Dictionary<string, object> HIOINDOKMLL, Dictionary<string, object> EDDLJPKPMNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x78B94F0", Offset = "0x78B7CF0", VA = "0x1878B94F0")]
		protected void APLKCMCIACC(string BELIEAFHDAH, string OPMIAMEJKDH, Dictionary<string, object> BDNHAKIBKMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x78B9670", Offset = "0x78B7E70", VA = "0x1878B9670", Slot = "5")]
		public virtual void JOICCNPGJDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x78B95F0", Offset = "0x78B7DF0", VA = "0x1878B95F0", Slot = "6")]
		public virtual void INLBBKDHIND()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HGPHJJHLIBN : PDPMBKGIPMN<AmplitudeAnalyticsIdentifyMessage, HGPHJJHLIBN>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override HGPHJJHLIBN KLCDMADPPKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage LDHIAFLNMDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x78C08A0", Offset = "0x78BF0A0", VA = "0x1878C08A0")]
	public HGPHJJHLIBN(AmplitudeAnalyticsIdentifyMessage NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x78C0800", Offset = "0x78BF000", VA = "0x1878C0800", Slot = "4")]
	public override void INLBBKDHIND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ILHGCPKFDMA : PDPMBKGIPMN<AmplitudeAnalyticsEvent, ILHGCPKFDMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool NCFCEBKEBJA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override ILHGCPKFDMA KLCDMADPPKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long DMLPDGADBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x78C1050", Offset = "0x78BF850", VA = "0x1878C1050")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x78B2700", Offset = "0x78B0F00", VA = "0x1878B2700")]
	public ILHGCPKFDMA(AmplitudeAnalyticsEvent NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "5")]
	public override AmplitudeAnalyticsEvent LDHIAFLNMDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x78C1160", Offset = "0x78BF960", VA = "0x1878C1160", Slot = "4")]
	public override void INLBBKDHIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x37F3840", Offset = "0x37F2040", VA = "0x1837F3840")]
	public ILHGCPKFDMA ECNIKCJJIJA<T>(string KIIAJPLCJIE, T[] OPMIAMEJKDH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x37F3840", Offset = "0x37F2040", VA = "0x1837F3840")]
	public ILHGCPKFDMA ECNIKCJJIJA(string KIIAJPLCJIE, string[] OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x37F3590", Offset = "0x37F1D90", VA = "0x1837F3590")]
	public ILHGCPKFDMA ECNIKCJJIJA<T>(string KIIAJPLCJIE, T OPMIAMEJKDH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x78C1070", Offset = "0x78BF870", VA = "0x1878C1070")]
	public ILHGCPKFDMA ECNIKCJJIJA(string KIIAJPLCJIE, long OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x78C10F0", Offset = "0x78BF8F0", VA = "0x1878C10F0")]
	public ILHGCPKFDMA ECNIKCJJIJA(string KIIAJPLCJIE, string OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x78C12A0", Offset = "0x78BFAA0", VA = "0x1878C12A0")]
	public ILHGCPKFDMA MPPIOACMDOH(string KIIAJPLCJIE, object? OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x78C1200", Offset = "0x78BFA00", VA = "0x1878C1200")]
	public ILHGCPKFDMA KFAGNBLHLHJ(string KIIAJPLCJIE, string OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x78C0F50", Offset = "0x78BF750", VA = "0x1878C0F50")]
	private ILHGCPKFDMA AHDFFENHKHK(string KIIAJPLCJIE, object OPMIAMEJKDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AHEKILNBKEP : ILHGCPKFDMA
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x78B2700", Offset = "0x78B0F00", VA = "0x1878B2700")]
	public AHEKILNBKEP(AmplitudeAnalyticsEvent NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x78B2560", Offset = "0x78B0D60", VA = "0x1878B2560", Slot = "4")]
	public override void INLBBKDHIND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class PDPMBKGIPMN<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : PDPMBKGIPMN<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M NJAAPDELBNN;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR KLCDMADPPKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public PDPMBKGIPMN(M NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x55506F0", Offset = "0x554EEF0", VA = "0x1855506F0")]
	public BLDR EPCPEMLNFHO(AmplitudeAnalyticsIdentifyMessage.DeviceInfo BFIKINKLLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5550670", Offset = "0x554EE70", VA = "0x185550670")]
	public BLDR BBNLBEBEJFG(AmplitudeAnalyticsIdentifyMessage.RevenueData CDHKCHGELJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5550740", Offset = "0x554EF40", VA = "0x185550740")]
	public BLDR FJOMMIELDBO(string KIIAJPLCJIE, string OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1E30", Offset = "0x3EA0630", VA = "0x183EA1E30")]
	public BLDR FJOMMIELDBO<T>(string KIIAJPLCJIE, T OPMIAMEJKDH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void INLBBKDHIND();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x55506C0", Offset = "0x554EEC0", VA = "0x1855506C0")]
	internal static string BEFFJNAPHIC(string OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x55507E0", Offset = "0x554EFE0", VA = "0x1855507E0")]
	private BLDR NKEEIHDOGCC(string KIIAJPLCJIE, object OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M LDHIAFLNMDJ();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class CAODOCOPMKA : JHOMNNEJONM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct FCOHGBCENAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<GCBHLOMINPE> <>t__builder;

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
		public CAODOCOPMKA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x78BE8E0", Offset = "0x78BD0E0", VA = "0x1878BE8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x78BF310", Offset = "0x78BDB10", VA = "0x1878BF310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient PEABLBMMADG;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x78B9FC0", Offset = "0x78B87C0", VA = "0x1878B9FC0")]
	[PJMOOJOMMCC.OJAOBFKEEAO]
	internal static void BGEMLBDLOJJ(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x78BA1A0", Offset = "0x78B89A0", VA = "0x1878BA1A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CAODOCOPMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x78BA030", Offset = "0x78B8830", VA = "0x1878BA030", Slot = "4")]
	[AsyncStateMachine(typeof(FCOHGBCENAJ))]
	public Task<GCBHLOMINPE> EPNJKCFLJED(string DGLMNBBIDCJ, string BEBBNKFFBDE, string LPONCKEOFHG, string MDHABHMIGFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class EPIIEJEKCFH : JHOMNNEJONM
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class EHNMANCBAAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<GCBHLOMINPE> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EHNMANCBAAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x78BE6A0", Offset = "0x78BCEA0", VA = "0x1878BE6A0")]
		internal void HJMDGHGJNDN(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct CGHAGNFHMCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<GCBHLOMINPE> <>t__builder;

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
		private TaskAwaiter<GCBHLOMINPE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x78BA740", Offset = "0x78B8F40", VA = "0x1878BA740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x78BAC90", Offset = "0x78B9490", VA = "0x1878BAC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	[PJMOOJOMMCC.OJAOBFKEEAO]
	internal static void BMOOKMJPCCN(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	[RecRoom.NoEngine.Common.Preserve]
	public EPIIEJEKCFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x78BE780", Offset = "0x78BCF80", VA = "0x1878BE780", Slot = "4")]
	[AsyncStateMachine(typeof(CGHAGNFHMCF))]
	public Task<GCBHLOMINPE> EPNJKCFLJED(string DGLMNBBIDCJ, string BEBBNKFFBDE, string LPONCKEOFHG, string MDHABHMIGFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NEJOECIMBJE
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> LIKBGILIMLN;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x78C4F90", Offset = "0x78C3790", VA = "0x1878C4F90")]
	internal static bool FJPFNNJMHJI(string BELIEAFHDAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface JHOMNNEJONM
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GCBHLOMINPE> EPNJKCFLJED(string DGLMNBBIDCJ, string BEBBNKFFBDE, string LPONCKEOFHG, string MDHABHMIGFH);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct GCBHLOMINPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int HKCKBNPPAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string FAOGKHHOEIF;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1618B10", Offset = "0x1617310", VA = "0x181618B10")]
	public GCBHLOMINPE(int EEIINABEIDJ, string DDBMBKPLEEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum OBOLAGMBIJC
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
	DebugCommand
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class CDAPMJOADJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private long BLEIGAPOIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private ILHGCPKFDMA PBCIOBAONLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool OKNBBLANIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float LIGHDOHECOJ;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x78BA5B0", Offset = "0x78B8DB0", VA = "0x1878BA5B0")]
	public CDAPMJOADJC(string CGKCGEHPNEC, float LIGHDOHECOJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3589F20", Offset = "0x3588720", VA = "0x183589F20")]
	public void ECNIKCJJIJA<T>(string KIIAJPLCJIE, T OPMIAMEJKDH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x78BA360", Offset = "0x78B8B60", VA = "0x1878BA360")]
	public void ECNIKCJJIJA(string KIIAJPLCJIE, string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x78BA220", Offset = "0x78B8A20", VA = "0x1878BA220")]
	public void AGCJKPGDFIK(string LNLONFPICKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x78BA4F0", Offset = "0x78B8CF0", VA = "0x1878BA4F0")]
	public void MANBFIJMGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x78BA3E0", Offset = "0x78B8BE0", VA = "0x1878BA3E0")]
	private void IEIFDMINONC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x78BA310", Offset = "0x78B8B10", VA = "0x1878BA310")]
	private bool BLEIEFCCFFJ()
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
		public enum KLDKEMIEFFF
		{
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			String,
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			Bool
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private KLDKEMIEFFF parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public KLDKEMIEFFF Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
			get
			{
				return default(KLDKEMIEFFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA0BF30", Offset = "0xA0A730", VA = "0x180A0BF30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x78C5B00", Offset = "0x78C4300", VA = "0x1878C5B00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CEFLLOCONHM<T> : IADFOAGNJKK<T>, OKNJKNCCAPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly MKLIBFLPPKJ ANGPHDLCABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string JGBCIPMOKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string DNGFIMNDOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private T GDEOHNFFMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly T LHCNPHOLELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool HCACJODEHND;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string KLALJODHMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x630DF10", Offset = "0x630C710", VA = "0x18630DF10")]
	public CEFLLOCONHM(MKLIBFLPPKJ ANGPHDLCABJ, string JGBCIPMOKIK, string DNGFIMNDOKG, T LHCNPHOLELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x630DD80", Offset = "0x630C580", VA = "0x18630DD80", Slot = "4")]
	public T NJJMECDNEFH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x630DF00", Offset = "0x630C700", VA = "0x18630DF00", Slot = "6")]
	public void NNEMBDPLFBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
public class GDMOJCPGELJ : OJDICPHECFC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct BOKBJKPNEFL : IEquatable<BOKBJKPNEFL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly string LKGFGNBINIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly string JNBIIPAFDLA;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA81780", Offset = "0xA7FF80", VA = "0x180A81780")]
		public BOKBJKPNEFL(string EHEFDPNDNCO, string DIHLANNDAEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xEC9A30", Offset = "0xEC8230", VA = "0x180EC9A30", Slot = "4")]
		public bool Equals(BOKBJKPNEFL PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x78B9EA0", Offset = "0x78B86A0", VA = "0x1878B9EA0", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x78B9F50", Offset = "0x78B8750", VA = "0x1878B9F50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private MKLIBFLPPKJ ANGPHDLCABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<BOKBJKPNEFL, OKNJKNCCAPC> GLJPDFJEHCJ;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x78BF540", Offset = "0x78BDD40", VA = "0x1878BF540")]
	[PJMOOJOMMCC.OJAOBFKEEAO.IHGAJDILMAJ]
	internal static void ADFMLLHPKEO(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x78BF870", Offset = "0x78BE070", VA = "0x1878BF870")]
	[RecRoom.NoEngine.Common.Preserve]
	public GDMOJCPGELJ([System.Diagnostics.CodeAnalysis.NotNull][LDAFGEHKDJK(null)] MKLIBFLPPKJ ANGPHDLCABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x78BF5C0", Offset = "0x78BDDC0", VA = "0x1878BF5C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x78BF5B0", Offset = "0x78BDDB0", VA = "0x1878BF5B0")]
	private void DLGGHICCPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x78BF6C0", Offset = "0x78BDEC0", VA = "0x1878BF6C0")]
	private void NJEFJOPKABE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3794BD0", Offset = "0x37933D0", VA = "0x183794BD0", Slot = "4")]
	public IADFOAGNJKK<T> ODPKCPPIAGC<T>(string JGBCIPMOKIK, string MGAHECBFOJK, T LHCNPHOLELG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class CIAPKHECIIA : IENFKPOMBKF, DJBIBLIDBFL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void KDMMOOFJIIK(IHFANECCAHO GABFBPNBPCK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly EFPJNFPLBBO FHINLCHLMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly KDMMOOFJIIK LGHLMMNAGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly string FHEBEEOFCLL;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x10BC830", Offset = "0x10BB030", VA = "0x1810BC830", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string FCELAJHFAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1B00120", Offset = "0x1AFE920", VA = "0x181B00120", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LJAJJKNHKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x78BAD20", Offset = "0x78B9520", VA = "0x1878BAD20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool LKHMOCJEBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x78BAD00", Offset = "0x78B9500", VA = "0x1878BAD00", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyList<string> KLJFOFFHBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1B005F0", Offset = "0x1AFEDF0", VA = "0x181B005F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x78BAD40", Offset = "0x78B9540", VA = "0x1878BAD40")]
	public CIAPKHECIIA(EFPJNFPLBBO PKENAIPAKDA, string MHKFINGBJLL, [Optional] KDMMOOFJIIK BJACDMKEIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x358F9A0", Offset = "0x358E1A0", VA = "0x18358F9A0", Slot = "9")]
	public T EFPADONOPCC<T>(string BELIEAFHDAH, T LHCNPHOLELG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class DLHPICFFODO : MKLIBFLPPKJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KIBILDKNOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public LBKIOCABGPE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public DLHPICFFODO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x78C42F0", Offset = "0x78C2AF0", VA = "0x1878C42F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x78C4C60", Offset = "0x78C3460", VA = "0x1878C4C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct BKJMLINJDPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x78B9C60", Offset = "0x78B8460", VA = "0x1878B9C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x78B9E40", Offset = "0x78B8640", VA = "0x1878B9E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct HOJDAKIPKKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public LBKIOCABGPE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public DLHPICFFODO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x78C08F0", Offset = "0x78BF0F0", VA = "0x1878C08F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x78C0D20", Offset = "0x78BF520", VA = "0x1878C0D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct CPGBJCEMBIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public DLHPICFFODO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public LBKIOCABGPE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x78BADB0", Offset = "0x78B95B0", VA = "0x1878BADB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x78BB170", Offset = "0x78B9970", VA = "0x1878BB170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly IReadOnlyDictionary<string, JLPINDFDDDI> NGBHKFAEAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool ANNDJKBEMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool KOCHIBAOGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private TaskCompletionSource<bool> ONJNFMNAINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private TaskCompletionSource<bool> KLLHODGPOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly SemaphoreSlim OCMEPIJOAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private FBEEAKKCIFB KEOCOIEOLIJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task MHEPGIPFDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x78BC410", Offset = "0x78BAC10", VA = "0x1878BC410", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task GPOBKGPAIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x78BD180", Offset = "0x78BB980", VA = "0x1878BD180", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EDMINBAEDKL
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xC47930", Offset = "0xC46130", VA = "0x180C47930", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool JHFOIGKMLBE
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xC46E20", Offset = "0xC45620", VA = "0x180C46E20", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string EAAEGJFGBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x78BC820", Offset = "0x78BB020", VA = "0x1878BC820", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public INDBDAMDIEB NEEBDJNLAOC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x78BCCB0", Offset = "0x78BB4B0", VA = "0x1878BCCB0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action ENKGCEBLIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x78BB720", Offset = "0x78B9F20", VA = "0x1878BB720", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x78BD0E0", Offset = "0x78BB8E0", VA = "0x1878BD0E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GFBJPOEPPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x78BCCE0", Offset = "0x78BB4E0", VA = "0x1878BCCE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x78BCE80", Offset = "0x78BB680", VA = "0x1878BCE80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OCHJOJDGKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x78BB4F0", Offset = "0x78B9CF0", VA = "0x1878BB4F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x78BD040", Offset = "0x78BB840", VA = "0x1878BD040", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<IHFANECCAHO> LEDGHCFKHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x78BC730", Offset = "0x78BAF30", VA = "0x1878BC730", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x78BCC00", Offset = "0x78BB400", VA = "0x1878BCC00", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x78BC560", Offset = "0x78BAD60", VA = "0x1878BC560", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x78BCF20", Offset = "0x78BB720", VA = "0x1878BCF20", Slot = "12")]
	[AsyncStateMachine(typeof(KIBILDKNOLE))]
	public Task NPIOKLMMDIH(string PIMPFFEFLEN, [Optional] LBKIOCABGPE ONDFEGPOKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x78BC830", Offset = "0x78BB030", VA = "0x1878BC830", Slot = "24")]
	[AsyncStateMachine(typeof(BKJMLINJDPJ))]
	public Task HOPGGEGCMCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x78BCD80", Offset = "0x78BB580", VA = "0x1878BCD80", Slot = "19")]
	[AsyncStateMachine(typeof(HOJDAKIPKKP))]
	public Task MPGFADGKJDE(LBKIOCABGPE ONDFEGPOKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x78BB590", Offset = "0x78B9D90", VA = "0x1878BB590")]
	private void ADJNPGCKJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x78BC450", Offset = "0x78BAC50", VA = "0x1878BC450", Slot = "20")]
	[AsyncStateMachine(typeof(CPGBJCEMBIG))]
	public Task DMLMDFNCNMJ(LBKIOCABGPE ONDFEGPOKLD, Dictionary<string, string> LAMMFCBBGDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x78BB630", Offset = "0x78B9E30", VA = "0x1878BB630", Slot = "21")]
	public bool BAHMONLBMKC(string CJDNOEPGBEL, bool EPOACDAACAD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x78BB7C0", Offset = "0x78B9FC0", VA = "0x1878BB7C0", Slot = "22")]
	public IENFKPOMBKF BNEFDFHKAAG(string MHKFINGBJLL, bool EPOACDAACAD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x78BC8E0", Offset = "0x78BB0E0", VA = "0x1878BC8E0")]
	private EFPJNFPLBBO IIOEJJKPJBP(string MHKFINGBJLL, bool EPOACDAACAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x78BC580", Offset = "0x78BAD80", VA = "0x1878BC580", Slot = "23")]
	public ECPOCFBGBJD EDIPIDJFLCD(string EHEFDPNDNCO, bool EPOACDAACAD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x78BD1C0", Offset = "0x78BB9C0", VA = "0x1878BD1C0")]
	private PHLFAFLODNG PKPJHAGOFLC(string EHEFDPNDNCO, bool EPOACDAACAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x78BB980", Offset = "0x78BA180", VA = "0x1878BB980")]
	private DHMCGFPEHNK CBOKMJFGEGB(LBKIOCABGPE ONDFEGPOKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x78BC260", Offset = "0x78BAA60", VA = "0x1878BC260")]
	private AFEBLBAHMCK CJJHCGAGEMH(string PIMPFFEFLEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x78BCAF0", Offset = "0x78BB2F0", VA = "0x1878BCAF0")]
	private void JOGJHKDEEHD(string MHKFINGBJLL, EFPJNFPLBBO PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x78BD470", Offset = "0x78BBC70", VA = "0x1878BD470")]
	public DLHPICFFODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x78BC7E0", Offset = "0x78BAFE0", VA = "0x1878BC7E0")]
	[CompilerGenerated]
	private void GMBJEIAJMLC(IHFANECCAHO GGILEDABHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x78BC7E0", Offset = "0x78BAFE0", VA = "0x1878BC7E0")]
	[CompilerGenerated]
	private void LGGELNOCMFK(IHFANECCAHO GGILEDABHIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class JJMOFJNAJFN : MKLIBFLPPKJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GNPCOENANHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public JJMOFJNAJFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public LBKIOCABGPE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x78BFE20", Offset = "0x78BE620", VA = "0x1878BFE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x78C07A0", Offset = "0x78BEFA0", VA = "0x1878C07A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct LPNCBHNKHOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x78C4CC0", Offset = "0x78C34C0", VA = "0x1878C4CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private DLHPICFFODO LFMGJFKCEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private TaskCompletionSource<bool> ONJNFMNAINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private TaskCompletionSource<bool> KLLHODGPOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private Task KGCONKPDMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Task EEBHLGBDDJL;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private MKLIBFLPPKJ PEBAEBIABCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x78C1670", Offset = "0x78BFE70", VA = "0x1878C1670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool JHFOIGKMLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x78C1A60", Offset = "0x78C0260", VA = "0x1878C1A60", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool EDMINBAEDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x78C1840", Offset = "0x78C0040", VA = "0x1878C1840", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task MHEPGIPFDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x78C17A0", Offset = "0x78BFFA0", VA = "0x1878C17A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task GPOBKGPAIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x78C2410", Offset = "0x78C0C10", VA = "0x1878C2410", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string EAAEGJFGBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x78C1BD0", Offset = "0x78C03D0", VA = "0x1878C1BD0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public INDBDAMDIEB NEEBDJNLAOC
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x78C1DB0", Offset = "0x78C05B0", VA = "0x1878C1DB0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action GFBJPOEPPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x78C1DF0", Offset = "0x78C05F0", VA = "0x1878C1DF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x78C2120", Offset = "0x78C0920", VA = "0x1878C2120", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action ENKGCEBLIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x78C15D0", Offset = "0x78BFDD0", VA = "0x1878C15D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x78C2370", Offset = "0x78C0B70", VA = "0x1878C2370", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action OCHJOJDGKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x78C12D0", Offset = "0x78BFAD0", VA = "0x1878C12D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x78C22D0", Offset = "0x78C0AD0", VA = "0x1878C22D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<IHFANECCAHO> LEDGHCFKHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x78C1A70", Offset = "0x78C0270", VA = "0x1878C1A70", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x78C1D00", Offset = "0x78C0500", VA = "0x1878C1D00", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x78C24B0", Offset = "0x78C0CB0", VA = "0x1878C24B0")]
	[UnityEngine.Scripting.Preserve]
	public JJMOFJNAJFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x78C1370", Offset = "0x78BFB70", VA = "0x1878C1370")]
	[PJMOOJOMMCC.OJAOBFKEEAO.IHGAJDILMAJ]
	internal static void ADFMLLHPKEO(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x78C1B20", Offset = "0x78C0320", VA = "0x1878C1B20")]
	internal static void FOILILLHEDG(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x78C1970", Offset = "0x78C0170", VA = "0x1878C1970", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x78C21C0", Offset = "0x78C09C0", VA = "0x1878C21C0", Slot = "12")]
	[AsyncStateMachine(typeof(GNPCOENANHN))]
	public Task NPIOKLMMDIH(string PIMPFFEFLEN, [Optional] LBKIOCABGPE ONDFEGPOKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x78C1E90", Offset = "0x78C0690", VA = "0x1878C1E90", Slot = "19")]
	public Task MPGFADGKJDE(LBKIOCABGPE ONDFEGPOKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x78C1850", Offset = "0x78C0050", VA = "0x1878C1850", Slot = "20")]
	public Task DMLMDFNCNMJ(LBKIOCABGPE ONDFEGPOKLD, Dictionary<string, string> LAMMFCBBGDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x78C14B0", Offset = "0x78BFCB0", VA = "0x1878C14B0", Slot = "21")]
	public bool BAHMONLBMKC(string CJDNOEPGBEL, bool EPOACDAACAD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x78C16E0", Offset = "0x78BFEE0", VA = "0x1878C16E0", Slot = "22")]
	public IENFKPOMBKF BNEFDFHKAAG(string MHKFINGBJLL, bool EPOACDAACAD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x78C19A0", Offset = "0x78C01A0", VA = "0x1878C19A0", Slot = "23")]
	public ECPOCFBGBJD EDIPIDJFLCD(string EHEFDPNDNCO, bool EPOACDAACAD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x78C1BF0", Offset = "0x78C03F0", VA = "0x1878C1BF0", Slot = "24")]
	public Task HOPGGEGCMCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x78C1FA0", Offset = "0x78C07A0", VA = "0x1878C1FA0")]
	private static void NJAFIBJHCJF(TaskCompletionSource<bool> INGEFKPJIKN, Task BJLHPBDGODB, Task GFCDEEJEKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x78C13E0", Offset = "0x78BFBE0", VA = "0x1878C13E0")]
	[AsyncStateMachine(typeof(LPNCBHNKHOH))]
	private static void AFHIBGMMOIE(Task BFOIMBMKJIA, TaskCompletionSource<bool> INGEFKPJIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xE2C420", Offset = "0xE2AC20", VA = "0x180E2C420")]
	[CompilerGenerated]
	private void AEIGEAAHICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xEEFA50", Offset = "0xEEE250", VA = "0x180EEFA50")]
	[CompilerGenerated]
	private void GLNHDPPIADG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xC91C10", Offset = "0xC90410", VA = "0x180C91C10")]
	[CompilerGenerated]
	private void INEEPOCMMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x78C1B90", Offset = "0x78C0390", VA = "0x1878C1B90")]
	[CompilerGenerated]
	private void HDHENPDFMHP(IHFANECCAHO GGILEDABHIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class KBNEIOJONEH : ECPOCFBGBJD, DJBIBLIDBFL
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate void OKALAEIALBL(IHFANECCAHO GABFBPNBPCK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly OKALAEIALBL LGHLMMNAGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly PHLFAFLODNG OOCDDJOCCME;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x549E9B0", Offset = "0x549D1B0", VA = "0x18549E9B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string FCELAJHFAOD
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xDB8460", Offset = "0xDB6C60", VA = "0x180DB8460", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E050", Offset = "0x6B3C850", VA = "0x186B3E050")]
	public KBNEIOJONEH(PHLFAFLODNG JGBCIPMOKIK, [Optional] OKALAEIALBL BJACDMKEIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3832590", Offset = "0x3830D90", VA = "0x183832590", Slot = "6")]
	public T EFPADONOPCC<T>(string BELIEAFHDAH, T LHCNPHOLELG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface INJKIANDLAO
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[UsedImplicitly]
public class IIAHNMHGLKL : INJKIANDLAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly MEDFPGBPJHB ELJEHMCLLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly List<DFIBJNLLEPO> OANKCHCLFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly string AGFLKDIIDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly string OEEDAOPJIBC;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x78C0D80", Offset = "0x78BF580", VA = "0x1878C0D80")]
	[UsedImplicitly]
	[PJMOOJOMMCC.OJAOBFKEEAO.IHGAJDILMAJ]
	internal static void JMICLABLGOM(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x78C0DF0", Offset = "0x78BF5F0", VA = "0x1878C0DF0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IIAHNMHGLKL([LDAFGEHKDJK(null)][JetBrains.Annotations.NotNull] MEDFPGBPJHB ELJEHMCLLDG, [LDAFGEHKDJK(null)][JetBrains.Annotations.NotNull] BADHLLBMKOM PAJKIKHCDPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KHJNLCJOHFK : MKLIBFLPPKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Task MHEPGIPFDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x78C3B20", Offset = "0x78C2320", VA = "0x1878C3B20", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task GPOBKGPAIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x78C4260", Offset = "0x78C2A60", VA = "0x1878C4260", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool JHFOIGKMLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EDMINBAEDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string EAAEGJFGBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public INDBDAMDIEB NEEBDJNLAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action GFBJPOEPPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x78C3EC0", Offset = "0x78C26C0", VA = "0x1878C3EC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x78C3FF0", Offset = "0x78C27F0", VA = "0x1878C3FF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action ENKGCEBLIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x78C39D0", Offset = "0x78C21D0", VA = "0x1878C39D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x78C41C0", Offset = "0x78C29C0", VA = "0x1878C41C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action OCHJOJDGKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x78C3930", Offset = "0x78C2130", VA = "0x1878C3930", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x78C4120", Offset = "0x78C2920", VA = "0x1878C4120", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<IHFANECCAHO> LEDGHCFKHLB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x78C3CD0", Offset = "0x78C24D0", VA = "0x1878C3CD0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x78C3E10", Offset = "0x78C2610", VA = "0x1878C3E10", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	[RecRoom.NoEngine.Common.Preserve]
	public KHJNLCJOHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x78C4090", Offset = "0x78C2890", VA = "0x1878C4090", Slot = "12")]
	public Task NPIOKLMMDIH(string PIMPFFEFLEN, [Optional] LBKIOCABGPE ONDFEGPOKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x78C3F60", Offset = "0x78C2760", VA = "0x1878C3F60", Slot = "19")]
	public Task MPGFADGKJDE(LBKIOCABGPE ONDFEGPOKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x78C3BB0", Offset = "0x78C23B0", VA = "0x1878C3BB0", Slot = "20")]
	public Task DMLMDFNCNMJ(LBKIOCABGPE ONDFEGPOKLD, Dictionary<string, string> LAMMFCBBGDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "21")]
	public bool BAHMONLBMKC(string CJDNOEPGBEL, bool EPOACDAACAD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x78C3A70", Offset = "0x78C2270", VA = "0x1878C3A70", Slot = "22")]
	public IENFKPOMBKF BNEFDFHKAAG(string MHKFINGBJLL, bool EPOACDAACAD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x78C3C40", Offset = "0x78C2440", VA = "0x1878C3C40", Slot = "23")]
	public ECPOCFBGBJD EDIPIDJFLCD(string EHEFDPNDNCO, bool EPOACDAACAD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x78C3D80", Offset = "0x78C2580", VA = "0x1878C3D80", Slot = "24")]
	public Task HOPGGEGCMCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class FBEEAKKCIFB : INDBDAMDIEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly DHMCGFPEHNK NOOGLNALAHN;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IReadOnlyDictionary<string, object> EEPPKDGEOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xDB63E0", Offset = "0xDB4BE0", VA = "0x180DB63E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public FBEEAKKCIFB(DHMCGFPEHNK KEKIHIMAGBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface EFLPPFNMHBC
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CDAPMJOADJC EEKMGPNGLNN(string CGKCGEHPNEC);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface CHLALMGBIDN
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum GOBHCOJKKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	long MPAMLFPPLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string MGFGJMFFLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string DNKNIJFGIOD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool ONFMICMFPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long CEDFKBNNBDJ();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HJDKMGEIEPH(long BFGLGAEMILF, bool GICCABHJKCP = true);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NKFLGJDMPEP(string KLNHOILIBHH, string BLMABEPFNMK, string PCKHGCIFPNH);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EKOPGOAEBAM(string KLNHOILIBHH);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DHLNOMGDLFI(string KLNHOILIBHH, string FOHNAMIBDLJ, string KHNFDJKFIEH);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LJIKEKGMADD(string JNGEILKPDIM, object OEOJMHLCCNJ, object OPLLEIHALNO);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GKLKDBBAMPI(GOBHCOJKKFJ DLAPMIEFMAM, int JBLCDPEEHBE, [Optional] JFPJFPPIPDF GBEJOBPDFOK, [Optional] string DAALJEAMJLA, [Optional] string LKNKJJBHDKO);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KDKFIGCLGBB(JFPJFPPIPDF GBEJOBPDFOK, long LPEMDKHFCKJ, long IFFCKOPHHLD, int IEPHMINOJKN, string DAALJEAMJLA, int JBLCDPEEHBE);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CCLENOCOFNE(JFPJFPPIPDF GBEJOBPDFOK, bool EJCCGIABFNE, [Optional] string LKNKJJBHDKO);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EPFIIMECJOE(JFPJFPPIPDF GBEJOBPDFOK, bool EJCCGIABFNE, [Optional] string LKNKJJBHDKO);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NFHGDGMGGPK(JFPJFPPIPDF GBEJOBPDFOK, bool EJCCGIABFNE, [Optional] string LKNKJJBHDKO);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LDNEBDDHBKO(long MDLDCACFGIB, string OFOEPIEAIOA);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface JIBEHNFKMKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string IHDJNLKIBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
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
