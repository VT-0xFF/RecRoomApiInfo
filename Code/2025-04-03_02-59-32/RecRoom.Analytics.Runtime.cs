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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x763CBA0", Offset = "0x763BFA0", VA = "0x18763CBA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x763C950", Offset = "0x763BD50", VA = "0x18763C950", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x763F380", Offset = "0x763E780", VA = "0x18763F380", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
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
		public AmplitudeAnalyticsClient.Settings JAABFIHPKFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool FOBKHMOLHFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9943A0", Offset = "0x9937A0", VA = "0x1809943A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, LEGAGIOCBAL
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum NIOHGNGPOMG
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class CIIJGBOACNJ
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class MNEKBBLGHAG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int ACDLENFLODN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> EHFKNBPIFNF;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
				public MNEKBBLGHAG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class GIMCEDBBINH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
				public GIMCEDBBINH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x763A530", Offset = "0x7639930", VA = "0x18763A530")]
				internal bool JFGNMJNPJFP(MNEKBBLGHAG item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string HCGICCAAENJ = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string IOOOOBAIEAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<MNEKBBLGHAG> LEIIKKJCJMO;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? NLNEEFEAAEN
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x7633FB0", Offset = "0x76333B0", VA = "0x187633FB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x76350A0", Offset = "0x76344A0", VA = "0x1876350A0")]
			internal CIIJGBOACNJ(string DGOGNLFFOAO, string GOKALJGBJHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7634BB0", Offset = "0x7633FB0", VA = "0x187634BB0")]
			public int NGAGCHCALPI([Optional] int? OANGFMNCLPK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x76341E0", Offset = "0x76335E0", VA = "0x1876341E0")]
			public List<Dictionary<string, object>> FLIGDOLBEBE(int HCDNFOHDIKD, int? OANGFMNCLPK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7633E00", Offset = "0x7633200", VA = "0x187633E00")]
			public void AGCFKKKCBNH(AmplitudeAnalyticsIdentifyMessage BLFGIKOAKOL, bool CHOLJGPDIHA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7633EA0", Offset = "0x76332A0", VA = "0x187633EA0")]
			public void AGCFKKKCBNH(Dictionary<string, object> BLFGIKOAKOL, bool CHOLJGPDIHA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7634050", Offset = "0x7633450", VA = "0x187634050")]
			public void DKDDPKACJKB(params Dictionary<string, object>[] GBDMGDCLIKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7634560", Offset = "0x7633960", VA = "0x187634560")]
			public void INJHJFHGEKF(List<Dictionary<string, object>> GIFMMMNCGCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7634450", Offset = "0x7633850", VA = "0x187634450")]
			private void HLAHHHGJELC(Dictionary<string, object> BLFGIKOAKOL, bool CHOLJGPDIHA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7634E90", Offset = "0x7634290", VA = "0x187634E90")]
			public void OMGEIOLLNKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x76347B0", Offset = "0x7633BB0", VA = "0x1876347B0")]
			private void LMBFMBBIDHJ([Optional] string HNFLEJGACGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7634D60", Offset = "0x7634160", VA = "0x187634D60")]
			private static string OBPNJBCGLAB(string FFOEEMKIKJO, string DJBLFBEBKGO)
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
			[Cpp2IlInjected.Address(RVA = "0x763EF70", Offset = "0x763E370", VA = "0x18763EF70")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct DMFHLGOOJFM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int NNDAFJOCIOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string AGGOMAPJGLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T NNKGEGJEPEL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class GCCDPHIACHM : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private CIKDDGFOAFI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public GCCDPHIACHM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7639D50", Offset = "0x7639150", VA = "0x187639D50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x763A4E0", Offset = "0x76398E0", VA = "0x18763A4E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class KJJKDEANJBF : IEnumerator<object>, IEnumerator, IDisposable
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
			public NOCDIBGNFAP quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public KJJKDEANJBF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x763B500", Offset = "0x763A900", VA = "0x18763B500", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x763B610", Offset = "0x763AA10", VA = "0x18763B610", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class NDPDJIHFDCN : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public NDPDJIHFDCN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x763C9E0", Offset = "0x763BDE0", VA = "0x18763C9E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x763CB50", Offset = "0x763BF50", VA = "0x18763CB50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class FKLOIJGKMPE : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private CIKDDGFOAFI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public FKLOIJGKMPE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7638680", Offset = "0x7637A80", VA = "0x187638680", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x76388E0", Offset = "0x7637CE0", VA = "0x1876388E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class CCBNMPFCPLE : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private CIKDDGFOAFI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public CCBNMPFCPLE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7633500", Offset = "0x7632900", VA = "0x187633500", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7633760", Offset = "0x7632B60", VA = "0x187633760", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class LCIKEMLGIJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public CIIJGBOACNJ cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public LCIKEMLGIJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x763BAB0", Offset = "0x763AEB0", VA = "0x18763BAB0")]
			internal void JLOEFDHGEOG(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x763B660", Offset = "0x763AA60", VA = "0x18763B660")]
			internal void IEIJHKHBLHO(DMFHLGOOJFM<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class FNLONDMFNMC : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private CIKDDGFOAFI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CIIJGBOACNJ cache;

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
			private LCIKEMLGIJG <>8__1;

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
			private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public FNLONDMFNMC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7638B00", Offset = "0x7637F00", VA = "0x187638B00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7639320", Offset = "0x7638720", VA = "0x187639320", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class BPOCPGEPJHF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public BPOCPGEPJHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6023CE0", Offset = "0x60230E0", VA = "0x186023CE0")]
			internal DMFHLGOOJFM<T> IJNFDPKGNDH(LKBDJIDGIOA postResponse)
			{
				return default(DMFHLGOOJFM<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private IFCCBFAGEOA BELIOMNDLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<OIELOJNAGCB> KAHNLDCLIDJ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string IFKKNAIJFJE = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string HNPGFDHCIGJ = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string AHLHGFCFAMJ = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int FCFBPOHOBPI = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int FKBGBHKKJCG = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int HCALHFGHMME = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float DDDLNMDACFJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long BNBGAFMNGMB = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string BBIILEPNIKF = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string DBHEGECEDDJ = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string PDNOOJACLKC = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string MGAMMBLFOOJ = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool ILHCLNBPAJJ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool BLHENKOBIHL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int LJKJJBJKNAC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int GNIENHJOECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private JOLCPCBICIC PPLGCMELOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private OLJAPIMLBLN PMCMCNJIJLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private LCEBKHHFGNL IKCMILIPJHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool NCGEJLANIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float LGMEOEBAJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float NMMIHHCFCAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int CCDLIAJENMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int LCGGDBAGNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? FCJOGNJOJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? ACCNKKCKLON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long KNOJKLAAPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string PLGDEAOECCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string NAKFPILHJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long BNFHBAGJHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string DDCFEEPIDFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string FJNLLKHMCLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> BNCGIEIBCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private NIOHGNGPOMG OKIKHBFJGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int GBEGNGBBJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int IPDGCAJKMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float LPDEGDADDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool KGKKFCKPIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool GCEIDGLMJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CIIJGBOACNJ BINBKEEOCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private CIIJGBOACNJ NMHLEHLCNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CIIJGBOACNJ AHJJBIBAMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string CIPMKOKOCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> FFOBIBBAHFA;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo LALFBFOAIEP;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string PJIEADPEIOD;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string IPAMKJMJMIH = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string JPMKKKLEANA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string LBBFNFMBACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string MMIMGIJIBDP;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private IFCCBFAGEOA PAGCFMDAEGO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x762CE10", Offset = "0x762C210", VA = "0x18762CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private OIELOJNAGCB LPOIJOEACFA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x762CD30", Offset = "0x762C130", VA = "0x18762CD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int LLFHGELMOJG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x762CEA0", Offset = "0x762C2A0", VA = "0x18762CEA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long OMGKHLJIOGP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7631CF0", Offset = "0x76310F0", VA = "0x187631CF0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7631E00", Offset = "0x7631200", VA = "0x187631E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string PMCPFJJPAEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7631CC0", Offset = "0x76310C0", VA = "0x187631CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LOAGEPKNJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1331D40", Offset = "0x1331140", VA = "0x181331D40", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x13302F0", Offset = "0x132F6F0", VA = "0x1813302F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BKOCPKEGALN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA05CE0", Offset = "0xA050E0", VA = "0x180A05CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA0E8D0", Offset = "0xA0DCD0", VA = "0x180A0E8D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? EMBFOIFGOLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA1B8C0", Offset = "0xA1ACC0", VA = "0x180A1B8C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAF9450", Offset = "0xAF8850", VA = "0x180AF9450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LJAOKBELOAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xD3DEB0", Offset = "0xD3D2B0", VA = "0x180D3DEB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x1205630", Offset = "0x1204A30", VA = "0x181205630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool EGLLMCGJNFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7631BD0", Offset = "0x7630FD0", VA = "0x187631BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> MDLCKJONPGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7631B10", Offset = "0x7630F10", VA = "0x187631B10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7631D40", Offset = "0x7631140", VA = "0x187631D40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x762C0A0", Offset = "0x762B4A0", VA = "0x18762C0A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x762E810", Offset = "0x762DC10", VA = "0x18762E810")]
		private void OCJNKIJOEJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7631140", Offset = "0x7630540", VA = "0x187631140")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x762ED40", Offset = "0x762E140", VA = "0x18762ED40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7631470", Offset = "0x7630870", VA = "0x187631470")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x762FEB0", Offset = "0x762F2B0", VA = "0x18762FEB0")]
		public DJNFHDJGNJD PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x762DBF0", Offset = "0x762CFF0", VA = "0x18762DBF0")]
		[IteratorStateMachine(typeof(GCCDPHIACHM))]
		public IEnumerator<CIKDDGFOAFI> InitializeForLocalAccount(AmplitudeAnalyticsEvent MLAEPLHLKBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7630810", Offset = "0x762FC10", VA = "0x187630810")]
		public void SendAppEnterEvent(bool GCMKDGBEBII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76313F0", Offset = "0x76307F0", VA = "0x1876313F0")]
		public void UpdateLastKnownInteractionCategory(string ECOFHMDEJHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7631340", Offset = "0x7630740", VA = "0x187631340")]
		public void UpdateLastAliveTime(float JNFHMFBFJPM = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x762D630", Offset = "0x762CA30", VA = "0x18762D630")]
		private DJNFHDJGNJD IPBDAFFLCKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x762EBD0", Offset = "0x762DFD0", VA = "0x18762EBD0")]
		private DJNFHDJGNJD OLCNLDJBCGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7630B20", Offset = "0x762FF20", VA = "0x187630B20")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x762FE10", Offset = "0x762F210", VA = "0x18762FE10")]
		[IteratorStateMachine(typeof(KJJKDEANJBF))]
		private IEnumerator PLHACCBIOPH(NOCDIBGNFAP CAIAEMNIBBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7631700", Offset = "0x7630B00", VA = "0x187631700")]
		[IteratorStateMachine(typeof(NDPDJIHFDCN))]
		public IEnumerator WaitForFlush(float ADEFLDLMJBI = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7631220", Offset = "0x7630620", VA = "0x187631220")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7631160", Offset = "0x7630560", VA = "0x187631160")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime GLBFMHKMALN)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x762D6F0", Offset = "0x762CAF0", VA = "0x18762D6F0")]
		public static BDGGBFMHNAA Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x762BEF0", Offset = "0x762B2F0", VA = "0x18762BEF0")]
		public static AHINLMBCMKD AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string HENADLOCFJG, string MOEFOOADDIC, EOFLPOGDEHN KGHJGMMJKMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x762D0A0", Offset = "0x762C4A0", VA = "0x18762D0A0")]
		public static AHINLMBCMKD Event([JetBrains.Annotations.NotNull] string HENADLOCFJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7630050", Offset = "0x762F450", VA = "0x187630050")]
		public static AHINLMBCMKD PreviousSessionEvent([JetBrains.Annotations.NotNull] string HENADLOCFJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x762D890", Offset = "0x762CC90", VA = "0x18762D890")]
		public static AHINLMBCMKD InitializeEvent(string MOEFOOADDIC, int GMBGNNGIEIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7630D20", Offset = "0x7630120", VA = "0x187630D20")]
		public static AHINLMBCMKD StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x762CA50", Offset = "0x762BE50", VA = "0x18762CA50")]
		public static AHINLMBCMKD CreateOutOfSessionEvent(string HENADLOCFJG, bool BPMOGMAPOGP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x762DFE0", Offset = "0x762D3E0", VA = "0x18762DFE0")]
		public static DJNFHDJGNJD LogOutOfSessionEvent(AHINLMBCMKD BCDDDAJDGDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x762DD60", Offset = "0x762D160", VA = "0x18762DD60")]
		public void LogEventAsync(AmplitudeAnalyticsEvent JKPAFFFNHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x762E1B0", Offset = "0x762D5B0", VA = "0x18762E1B0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent JKPAFFFNHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x762E2F0", Offset = "0x762D6F0", VA = "0x18762E2F0")]
		public void LogSerializedEventAsync(Dictionary<string, object> DEJBLIHNJDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x762DEA0", Offset = "0x762D2A0", VA = "0x18762DEA0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage AEMGMLNPMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x762E5A0", Offset = "0x762D9A0", VA = "0x18762E5A0")]
		private void NEEPPGIPMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x762EE00", Offset = "0x762E200", VA = "0x18762EE00")]
		private void PDKAEDAIAME(Dictionary<string, object> MMFCHLFFDDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x762BE00", Offset = "0x762B200", VA = "0x18762BE00")]
		private void AGPDPNGLPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x762E3D0", Offset = "0x762D7D0", VA = "0x18762E3D0")]
		private void NDLBFEJGACB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x762D550", Offset = "0x762C950", VA = "0x18762D550")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x762CD80", Offset = "0x762C180", VA = "0x18762CD80")]
		[IteratorStateMachine(typeof(FKLOIJGKMPE))]
		private IEnumerator<CIKDDGFOAFI> DEBOOPKLPDG(float ADEFLDLMJBI = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x762D4C0", Offset = "0x762C8C0", VA = "0x18762D4C0")]
		[IteratorStateMachine(typeof(CCBNMPFCPLE))]
		private IEnumerator<CIKDDGFOAFI> FGMJLEOLODB(float ADEFLDLMJBI = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x762DC80", Offset = "0x762D080", VA = "0x18762DC80")]
		[IteratorStateMachine(typeof(FNLONDMFNMC))]
		private IEnumerator<CIKDDGFOAFI> LOHJLAALGLJ(CIIJGBOACNJ OEEONBHNECC, int? OANGFMNCLPK, string GIHPEPDKLGB, float ADEFLDLMJBI, Action<int> KLEOJPKHLKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x762D3B0", Offset = "0x762C7B0", VA = "0x18762D3B0")]
		private static void FGLJFKCODPH(bool JIHHLONAMHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x762C710", Offset = "0x762BB10", VA = "0x18762C710")]
		private GOBMEFCJDOP<DMFHLGOOJFM<Dictionary<string, object>>> CCBLEEFJGOH(string GIHPEPDKLGB, string GDMCFMKHEEO, Dictionary<string, object> NNKGEGJEPEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x762C7E0", Offset = "0x762BBE0", VA = "0x18762C7E0")]
		private GOBMEFCJDOP<DMFHLGOOJFM<List<Dictionary<string, object>>>> CCBLEEFJGOH(string GIHPEPDKLGB, string GDMCFMKHEEO, List<Dictionary<string, object>> NNKGEGJEPEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3DAA900", Offset = "0x3DA9D00", VA = "0x183DAA900")]
		private GOBMEFCJDOP<DMFHLGOOJFM<T>> EBCMJOMPOPN<T>(string OOCMLDKDEFE, string GIHPEPDKLGB, string GDMCFMKHEEO, T NNKGEGJEPEL, Dictionary<string, object> MFAOJOAKGAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x762D5E0", Offset = "0x762C9E0", VA = "0x18762D5E0")]
		private bool IGEKOBOHMIB(float AAHABAEBMKI, float ADEFLDLMJBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x762F0B0", Offset = "0x762E4B0", VA = "0x18762F0B0")]
		private Dictionary<string, object> PKOOKBJNDPJ(string GIHPEPDKLGB, Dictionary<string, object> NNKGEGJEPEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x76317F0", Offset = "0x7630BF0", VA = "0x1876317F0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9C0950", Offset = "0x9BFD50", VA = "0x1809C0950", Slot = "6")]
		private bool CBMMHJLPIMM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x762E6A0", Offset = "0x762DAA0", VA = "0x18762E6A0")]
		[CompilerGenerated]
		private long NOLFBNJCADG()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x762FEA0", Offset = "0x762F2A0", VA = "0x18762FEA0")]
		[CompilerGenerated]
		private void PMJPKHOHGEJ(int LIPNIHGICGI)
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
			[Cpp2IlInjected.Address(RVA = "0x7632B00", Offset = "0x7631F00", VA = "0x187632B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7632BE0", Offset = "0x7631FE0", VA = "0x187632BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7632B40", Offset = "0x7631F40", VA = "0x187632B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7632C40", Offset = "0x7632040", VA = "0x187632C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7632AC0", Offset = "0x7631EC0", VA = "0x187632AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7632B80", Offset = "0x7631F80", VA = "0x187632B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x993A40", Offset = "0x992E40", VA = "0x180993A40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7632540", Offset = "0x7631940", VA = "0x187632540")]
		public static AHINLMBCMKD GNHEPACBJCH(string IOFNCNFBMGK, [JetBrains.Annotations.NotNull] string DEPLFLMGIOJ, long HFGKEOIDFDA, long ALGEAFEDHMP, string MOEFOOADDIC, string KGHJGMMJKMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x76327C0", Offset = "0x7631BC0", VA = "0x1876327C0")]
		public static AHINLMBCMKD JPPGGNAPLFJ(string IOFNCNFBMGK, [JetBrains.Annotations.NotNull] string DEPLFLMGIOJ, long HFGKEOIDFDA, long ALGEAFEDHMP, string MOEFOOADDIC, long EFHCJJDNFPB, string HNKLIADNAPA, string MLFOODECOIO, string FJGHFJGHGFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7632920", Offset = "0x7631D20", VA = "0x187632920")]
		private AmplitudeAnalyticsEvent(string IOFNCNFBMGK, [JetBrains.Annotations.NotNull] string DEPLFLMGIOJ, long HFGKEOIDFDA, long ALGEAFEDHMP, string MOEFOOADDIC, string KGHJGMMJKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD9AD70", Offset = "0xD9A170", VA = "0x180D9AD70")]
		public void GJFNECMBJCI(long BIMMLABABMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7631E60", Offset = "0x7631260", VA = "0x187631E60", Slot = "5")]
		public override void AMPIMGIDCFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7632640", Offset = "0x7631A40", VA = "0x187632640", Slot = "6")]
		public override void ILKOGDNGDHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7631F60", Offset = "0x7631360", VA = "0x187631F60", Slot = "4")]
		protected override Dictionary<string, object> BIJCAHJGDPO(Dictionary<string, object> GKKKBFJGPOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7632430", Offset = "0x7631830", VA = "0x187632430")]
		private void EHELCJCMPDN(string DJBLFBEBKGO, string FFOEEMKIKJO, bool MDIJKPHCGAP = false)
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
			[Cpp2IlInjected.Address(RVA = "0x7638450", Offset = "0x7637850", VA = "0x187638450")]
			public void LBFAJGNCGLL(Dictionary<string, object> LMKBANAEPPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
			[Cpp2IlInjected.Address(RVA = "0x763EC00", Offset = "0x763E000", VA = "0x18763EC00")]
			public void LBFAJGNCGLL(Dictionary<string, object> JKIBDPCBOBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x11C8160", Offset = "0x11C7560", VA = "0x1811C8160")]
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
			[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7633070", Offset = "0x7632470", VA = "0x187633070")]
		public static BDGGBFMHNAA GNHEPACBJCH(string IOFNCNFBMGK, string MOEFOOADDIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7633350", Offset = "0x7632750", VA = "0x187633350")]
		protected AmplitudeAnalyticsIdentifyMessage(string IOFNCNFBMGK, string MOEFOOADDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7633220", Offset = "0x7632620", VA = "0x187633220")]
		public Dictionary<string, object> JPGNNCJBMMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7632D30", Offset = "0x7632130", VA = "0x187632D30", Slot = "4")]
		protected virtual Dictionary<string, object> BIJCAHJGDPO(Dictionary<string, object> GKKKBFJGPOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x76332B0", Offset = "0x76326B0", VA = "0x1876332B0")]
		protected void NIIFNLHOCJO(string DJBLFBEBKGO, Dictionary<string, object> AMKONOIDFGP, Dictionary<string, object> KFKEPIKLIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7633130", Offset = "0x7632530", VA = "0x187633130")]
		protected void IBAMINKAAFO(string DJBLFBEBKGO, string FFOEEMKIKJO, Dictionary<string, object> KHMDEBPOBOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7632CA0", Offset = "0x76320A0", VA = "0x187632CA0", Slot = "5")]
		public virtual void AMPIMGIDCFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x76331A0", Offset = "0x76325A0", VA = "0x1876331A0", Slot = "6")]
		public virtual void ILKOGDNGDHF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BDGGBFMHNAA : ICBOJOIKIPF<AmplitudeAnalyticsIdentifyMessage, BDGGBFMHNAA>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override BDGGBFMHNAA MNMEIIAEAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage EDKBIKJEBKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x76334B0", Offset = "0x76328B0", VA = "0x1876334B0")]
	public BDGGBFMHNAA(AmplitudeAnalyticsIdentifyMessage DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7633410", Offset = "0x7632810", VA = "0x187633410", Slot = "4")]
	public override void ILKOGDNGDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AHINLMBCMKD : ICBOJOIKIPF<AmplitudeAnalyticsEvent, AHINLMBCMKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool GNKBACFPLOO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override AHINLMBCMKD MNMEIIAEAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long NGMKGLKALCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x762BD90", Offset = "0x762B190", VA = "0x18762BD90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x762BDB0", Offset = "0x762B1B0", VA = "0x18762BDB0")]
	public AHINLMBCMKD(AmplitudeAnalyticsEvent DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "5")]
	public override AmplitudeAnalyticsEvent EDKBIKJEBKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x762BCF0", Offset = "0x762B0F0", VA = "0x18762BCF0", Slot = "4")]
	public override void ILKOGDNGDHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F5B0", Offset = "0x3D6E9B0", VA = "0x183D6F5B0")]
	public AHINLMBCMKD GIHLOONBFMD<T>(string MHALMOGKEGG, T[] FFOEEMKIKJO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F5B0", Offset = "0x3D6E9B0", VA = "0x183D6F5B0")]
	public AHINLMBCMKD GIHLOONBFMD(string MHALMOGKEGG, string[] FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F300", Offset = "0x3D6E700", VA = "0x183D6F300")]
	public AHINLMBCMKD GIHLOONBFMD<T>(string MHALMOGKEGG, T FFOEEMKIKJO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x762BC70", Offset = "0x762B070", VA = "0x18762BC70")]
	public AHINLMBCMKD GIHLOONBFMD(string MHALMOGKEGG, long FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x762BC00", Offset = "0x762B000", VA = "0x18762BC00")]
	public AHINLMBCMKD GIHLOONBFMD(string MHALMOGKEGG, string FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x762BA30", Offset = "0x762AE30", VA = "0x18762BA30")]
	public AHINLMBCMKD ADIEKOACJOA(string MHALMOGKEGG, object? FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x762BA60", Offset = "0x762AE60", VA = "0x18762BA60")]
	public AHINLMBCMKD BGGHIKMLADA(string MHALMOGKEGG, string FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x762BB00", Offset = "0x762AF00", VA = "0x18762BB00")]
	private AHINLMBCMKD BLEKKAHEHAK(string MHALMOGKEGG, object FFOEEMKIKJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CFEKNBGABCI : AHINLMBCMKD
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x762BDB0", Offset = "0x762B1B0", VA = "0x18762BDB0")]
	public CFEKNBGABCI(AmplitudeAnalyticsEvent DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7633C50", Offset = "0x7633050", VA = "0x187633C50", Slot = "4")]
	public override void ILKOGDNGDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class ICBOJOIKIPF<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : ICBOJOIKIPF<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M DAMFJFKKFBI;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR MNMEIIAEAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	public ICBOJOIKIPF(M DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x49D7310", Offset = "0x49D6710", VA = "0x1849D7310")]
	public BLDR GPMMKDFNNIN(AmplitudeAnalyticsIdentifyMessage.DeviceInfo ECLKHMOKKEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x49D7290", Offset = "0x49D6690", VA = "0x1849D7290")]
	public BLDR CELGKKEEJGD(AmplitudeAnalyticsIdentifyMessage.RevenueData AJADCILGNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x49D7360", Offset = "0x49D6760", VA = "0x1849D7360")]
	public BLDR KEEHKMNIFLI(string MHALMOGKEGG, string FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2630", Offset = "0x3BA1A30", VA = "0x183BA2630")]
	public BLDR KEEHKMNIFLI<T>(string MHALMOGKEGG, T FFOEEMKIKJO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void ILKOGDNGDHF();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x49D72E0", Offset = "0x49D66E0", VA = "0x1849D72E0")]
	internal static string EBDMPDPOHBD(string FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x49D7400", Offset = "0x49D6800", VA = "0x1849D7400")]
	private BLDR OHJHMACNMMM(string MHALMOGKEGG, object FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M EDKBIKJEBKB();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class PMEMDDDKKEN : JOLCPCBICIC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct DAJGDEBABNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<LKBDJIDGIOA> <>t__builder;

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
		public PMEMDDDKKEN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x76374D0", Offset = "0x76368D0", VA = "0x1876374D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7637F00", Offset = "0x7637300", VA = "0x187637F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient PJBEJGMMEEJ;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x763EB10", Offset = "0x763DF10", VA = "0x18763EB10")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void PBPDHGDPAFH(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x763EB80", Offset = "0x763DF80", VA = "0x18763EB80")]
	[RecRoom.NoEngine.Common.Preserve]
	public PMEMDDDKKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x763E9A0", Offset = "0x763DDA0", VA = "0x18763E9A0", Slot = "4")]
	[AsyncStateMachine(typeof(DAJGDEBABNE))]
	public Task<LKBDJIDGIOA> LLKAODJKDKI(string OOCMLDKDEFE, string PIPMJPPMBOI, string KKNAPPHIAHN, string IAFFFKMEKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class IEODGBLHKEF : JOLCPCBICIC
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HGAJLGDIKLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<LKBDJIDGIOA> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public HGAJLGDIKLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x763ADA0", Offset = "0x763A1A0", VA = "0x18763ADA0")]
		internal void DHBFJCPCGOP(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct GMINCDBKPKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<LKBDJIDGIOA> <>t__builder;

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
		private TaskAwaiter<LKBDJIDGIOA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x763A5A0", Offset = "0x76399A0", VA = "0x18763A5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x763AAF0", Offset = "0x7639EF0", VA = "0x18763AAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void CNLGEFILAOM(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	[RecRoom.NoEngine.Common.Preserve]
	public IEODGBLHKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x763AE80", Offset = "0x763A280", VA = "0x18763AE80", Slot = "4")]
	[AsyncStateMachine(typeof(GMINCDBKPKM))]
	public Task<LKBDJIDGIOA> LLKAODJKDKI(string OOCMLDKDEFE, string PIPMJPPMBOI, string KKNAPPHIAHN, string IAFFFKMEKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LHFGFEDMOMP
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> JMPGLADIOMB;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x763BDD0", Offset = "0x763B1D0", VA = "0x18763BDD0")]
	internal static bool MCMECEMCMDH(string DJBLFBEBKGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface JOLCPCBICIC
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LKBDJIDGIOA> LLKAODJKDKI(string OOCMLDKDEFE, string PIPMJPPMBOI, string KKNAPPHIAHN, string IAFFFKMEKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct LKBDJIDGIOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int LDGIDANNLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string MFEDLAOEAEM;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1536EA0", Offset = "0x15362A0", VA = "0x181536EA0")]
	public LKBDJIDGIOA(int NNDAFJOCIOP, string AGGOMAPJGLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum HFKBGNFGCKA
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
public class JPMDOGLIEFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private long AMIGMDMMBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private AHINLMBCMKD EFJCDOLBLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool GALNDCKLIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float IBKDJCHJMAC;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x763B370", Offset = "0x763A770", VA = "0x18763B370")]
	public JPMDOGLIEFI(string GHNIGGEMFFK, float IBKDJCHJMAC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3686A60", Offset = "0x3685E60", VA = "0x183686A60")]
	public void GIHLOONBFMD<T>(string MHALMOGKEGG, T FFOEEMKIKJO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x763B0A0", Offset = "0x763A4A0", VA = "0x18763B0A0")]
	public void GIHLOONBFMD(string MHALMOGKEGG, string FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x763B120", Offset = "0x763A520", VA = "0x18763B120")]
	public void LJKKKBLKCPK(string GBMLOBCPFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x763AFE0", Offset = "0x763A3E0", VA = "0x18763AFE0")]
	public void FDOGCDAFOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x763B260", Offset = "0x763A660", VA = "0x18763B260")]
	private void MLIHBHPOCJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x763B210", Offset = "0x763A610", VA = "0x18763B210")]
	private bool MDDPCNGLBGM()
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
		public enum FIPCANMGKLE
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
		private FIPCANMGKLE parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public FIPCANMGKLE Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xB35CF0", Offset = "0xB350F0", VA = "0x180B35CF0")]
			get
			{
				return default(FIPCANMGKLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9C1F60", Offset = "0x9C1360", VA = "0x1809C1F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x763ED70", Offset = "0x763E170", VA = "0x18763ED70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class LCFIABBPJJH<T> : BDHBCGNDLBL<T>, JHENHHAEFJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly KKKJLBLOICG EJMCLPMBLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string DMGLPHIJGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string INNDGAPKKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private T HAANLGCBGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly T PFCPDJEHNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool HDANPKLHKNO;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string DKLNIOELLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4E33B10", Offset = "0x4E32F10", VA = "0x184E33B10")]
	public LCFIABBPJJH(KKKJLBLOICG EJMCLPMBLBH, string DMGLPHIJGLL, string INNDGAPKKHI, T PFCPDJEHNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4E33790", Offset = "0x4E32B90", VA = "0x184E33790", Slot = "4")]
	public T MLACMEICEMO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4E33610", Offset = "0x4E32A10", VA = "0x184E33610", Slot = "6")]
	public void CJEMNCEDADJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
public class DLIFNCDPFIJ : CHDHAFELELA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct PHOIHLMPKKB : IEquatable<PHOIHLMPKKB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly string OLNDHHKOLPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly string HGBPNOHINLC;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA147A0", Offset = "0xA13BA0", VA = "0x180A147A0")]
		public PHOIHLMPKKB(string ICAEAKAPILN, string MOOIMHFHGJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD400", Offset = "0x6DFC800", VA = "0x186DFD400", Slot = "4")]
		public bool Equals(PHOIHLMPKKB KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x763E880", Offset = "0x763DC80", VA = "0x18763E880", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x763E930", Offset = "0x763DD30", VA = "0x18763E930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private KKKJLBLOICG EJMCLPMBLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<PHOIHLMPKKB, JHENHHAEFJB> DFCPINLLCPL;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7638230", Offset = "0x7637630", VA = "0x187638230")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	internal static void OGCPPBNKBAK(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x76382A0", Offset = "0x76376A0", VA = "0x1876382A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DLIFNCDPFIJ([System.Diagnostics.CodeAnalysis.NotNull][CMKKAFOAFJE(null)] KKKJLBLOICG EJMCLPMBLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7637F80", Offset = "0x7637380", VA = "0x187637F80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7637F70", Offset = "0x7637370", VA = "0x187637F70")]
	private void CBHKENEAFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7638080", Offset = "0x7637480", VA = "0x187638080")]
	private void FNBBJJPEJGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3447E80", Offset = "0x3447280", VA = "0x183447E80", Slot = "4")]
	public BDHBCGNDLBL<T> ECPKCFLALGC<T>(string DMGLPHIJGLL, string IHEIKJJHAOP, T PFCPDJEHNAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class FFBFJPLOELP : HENELBFEDCM, DLMNMBIDMDD
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void CPMICGEFLCE(APKOBAKLOPM PEHOHDIAHIO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly MEMFNFLGFDC NAHLKHJHOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly CPMICGEFLCE OFBMJCCOBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly string DJGJENPOOIM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xFF9210", Offset = "0xFF8610", VA = "0x180FF9210", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string CIDPFFAPCID
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1A12BB0", Offset = "0x1A11FB0", VA = "0x181A12BB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool OFIHGOFNPOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x76385D0", Offset = "0x76379D0", VA = "0x1876385D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool LICALDBGIBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x76385F0", Offset = "0x76379F0", VA = "0x1876385F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyList<string> FHDMLFLHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1A12850", Offset = "0x1A11C50", VA = "0x181A12850", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7638610", Offset = "0x7637A10", VA = "0x187638610")]
	public FFBFJPLOELP(MEMFNFLGFDC HNFCGGMPMHM, string EBFIHPGOKOB, [Optional] CPMICGEFLCE GDFPBPNJNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x35BD8D0", Offset = "0x35BCCD0", VA = "0x1835BD8D0", Slot = "9")]
	public T IOLMGDEDCOJ<T>(string DJBLFBEBKGO, T PFCPDJEHNAP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class CLBNBFGKJFL : KKKJLBLOICG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LMKKKJNMCKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public OLJAPIMLBLN userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CLBNBFGKJFL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x763BF80", Offset = "0x763B380", VA = "0x18763BF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x763C8F0", Offset = "0x763BCF0", VA = "0x18763C8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct GNCGNAIDDCD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x763AB60", Offset = "0x7639F60", VA = "0x18763AB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x763AD40", Offset = "0x763A140", VA = "0x18763AD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct CEEILNIAOLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public OLJAPIMLBLN userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CLBNBFGKJFL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x76337B0", Offset = "0x7632BB0", VA = "0x1876337B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7633BF0", Offset = "0x7632FF0", VA = "0x187633BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct ADILGIFGNNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public CLBNBFGKJFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public OLJAPIMLBLN userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x762B610", Offset = "0x762AA10", VA = "0x18762B610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x762B9D0", Offset = "0x762ADD0", VA = "0x18762B9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly IReadOnlyDictionary<string, IFCLFINHGAL> LIICGKKGGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool DJJGLNONCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool AMEKNGBMGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private TaskCompletionSource<bool> LAEHMFLPOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private TaskCompletionSource<bool> FGGFALGIGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly SemaphoreSlim AABGCLMBMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private MIFGPDEGEMI EFOOHOBKOKD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task IJKKPNOBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7636C80", Offset = "0x7636080", VA = "0x187636C80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task MEDLHLCJKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7636210", Offset = "0x7635610", VA = "0x187636210", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EFLAIOOGMCP
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xBE3960", Offset = "0xBE2D60", VA = "0x180BE3960", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool OMNNPNGABAD
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xBE3600", Offset = "0xBE2A00", VA = "0x180BE3600", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string BKOCPKEGALN
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7637100", Offset = "0x7636500", VA = "0x187637100", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public JNOAAICKIKB DHDLDPIGKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7635E60", Offset = "0x7635260", VA = "0x187635E60", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DCEMJDKMPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7635600", Offset = "0x7634A00", VA = "0x187635600", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7636DC0", Offset = "0x76361C0", VA = "0x187636DC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IBEFKBDNLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7635900", Offset = "0x7634D00", VA = "0x187635900", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7635860", Offset = "0x7634C60", VA = "0x187635860", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GNKBDLPFPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7635560", Offset = "0x7634960", VA = "0x187635560", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7636250", Offset = "0x7635650", VA = "0x187636250", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<APKOBAKLOPM> NGICILOKALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x76362F0", Offset = "0x76356F0", VA = "0x1876362F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7636E60", Offset = "0x7636260", VA = "0x187636E60", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7635E40", Offset = "0x7635240", VA = "0x187635E40", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x76360F0", Offset = "0x76354F0", VA = "0x1876360F0", Slot = "12")]
	[AsyncStateMachine(typeof(LMKKKJNMCKJ))]
	public Task GDCNGOALEGL(string GOKALJGBJHH, [Optional] OLJAPIMLBLN ALCDDFEIMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7635E90", Offset = "0x7635290", VA = "0x187635E90", Slot = "24")]
	[AsyncStateMachine(typeof(GNCGNAIDDCD))]
	public Task EPLMEHCPNMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7637000", Offset = "0x7636400", VA = "0x187637000", Slot = "19")]
	[AsyncStateMachine(typeof(CEEILNIAOLN))]
	public Task OMANGPAOAEH(OLJAPIMLBLN ALCDDFEIMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x76359A0", Offset = "0x7634DA0", VA = "0x1876359A0")]
	private void CMKKLJOANGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7635450", Offset = "0x7634850", VA = "0x187635450", Slot = "20")]
	[AsyncStateMachine(typeof(ADILGIFGNNI))]
	public Task AIIKPIJCCIE(OLJAPIMLBLN ALCDDFEIMFD, Dictionary<string, string> JJIIMFDMEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7636F10", Offset = "0x7636310", VA = "0x187636F10", Slot = "21")]
	public bool OGBAOGKIEGN(string BJHDDEKOFJK, bool MNDFDNOLOJL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x76356A0", Offset = "0x7634AA0", VA = "0x1876356A0", Slot = "22")]
	public HENELBFEDCM BPPAMPNMHDF(string EBFIHPGOKOB, bool MNDFDNOLOJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7635A40", Offset = "0x7634E40", VA = "0x187635A40")]
	private MEMFNFLGFDC CPFLNGAOGPI(string EBFIHPGOKOB, bool MNDFDNOLOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7635F40", Offset = "0x7635340", VA = "0x187635F40", Slot = "23")]
	public EAFDMPMEONO FIOHDFANDFF(string ICAEAKAPILN, bool MNDFDNOLOJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7636CC0", Offset = "0x76360C0", VA = "0x187636CC0")]
	private JGGHAOMMHKI LCJJFHGMEFE(string ICAEAKAPILN, bool MNDFDNOLOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x76363A0", Offset = "0x76357A0", VA = "0x1876363A0")]
	private IOBPPBKDDBE IDBDHDNEMDD(OLJAPIMLBLN ALCDDFEIMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7635C90", Offset = "0x7635090", VA = "0x187635C90")]
	private DMJJGHJBPDJ DKPNFCFHFPI(string GOKALJGBJHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7637110", Offset = "0x7636510", VA = "0x187637110")]
	private void PNBAKJOEHOC(string EBFIHPGOKOB, MEMFNFLGFDC HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x76373D0", Offset = "0x76367D0", VA = "0x1876373D0")]
	public CLBNBFGKJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7635C50", Offset = "0x7635050", VA = "0x187635C50")]
	[CompilerGenerated]
	private void ENLEMLJDACB(APKOBAKLOPM IEDBNFIMLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7635C50", Offset = "0x7635050", VA = "0x187635C50")]
	[CompilerGenerated]
	private void DGBPGPJNNMM(APKOBAKLOPM IEDBNFIMLNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class ODHKMJBBMKI : KKKJLBLOICG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct FPPGJFJCEJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ODHKMJBBMKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public OLJAPIMLBLN userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7639370", Offset = "0x7638770", VA = "0x187639370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7639CF0", Offset = "0x76390F0", VA = "0x187639CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct CKHJEHMPBKI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7635210", Offset = "0x7634610", VA = "0x187635210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9F4FB0", Offset = "0x9F43B0", VA = "0x1809F4FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private CLBNBFGKJFL BCPFIMMNIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private TaskCompletionSource<bool> LAEHMFLPOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private TaskCompletionSource<bool> FGGFALGIGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private Task BDFJMPHMCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Task BNKFKFOPPKB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private KKKJLBLOICG GGEMNOPDOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x763D2E0", Offset = "0x763C6E0", VA = "0x18763D2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool OMNNPNGABAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x763DDF0", Offset = "0x763D1F0", VA = "0x18763DDF0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool EFLAIOOGMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x763D150", Offset = "0x763C550", VA = "0x18763D150", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task IJKKPNOBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x763D890", Offset = "0x763CC90", VA = "0x18763D890", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task MEDLHLCJKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x763D6A0", Offset = "0x763CAA0", VA = "0x18763D6A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string BKOCPKEGALN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x763DD90", Offset = "0x763D190", VA = "0x18763DD90", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public JNOAAICKIKB DHDLDPIGKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x763D190", Offset = "0x763C590", VA = "0x18763D190", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action IBEFKBDNLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x763D0B0", Offset = "0x763C4B0", VA = "0x18763D0B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x763D010", Offset = "0x763C410", VA = "0x18763D010", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action DCEMJDKMPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x763CDE0", Offset = "0x763C1E0", VA = "0x18763CDE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x763D930", Offset = "0x763CD30", VA = "0x18763D930", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action GNKBDLPFPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x763CD40", Offset = "0x763C140", VA = "0x18763CD40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x763D740", Offset = "0x763CB40", VA = "0x18763D740", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<APKOBAKLOPM> NGICILOKALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x763D7E0", Offset = "0x763CBE0", VA = "0x18763D7E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x763D9D0", Offset = "0x763CDD0", VA = "0x18763D9D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x763DE00", Offset = "0x763D200", VA = "0x18763DE00")]
	[UnityEngine.Scripting.Preserve]
	public ODHKMJBBMKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x763DC10", Offset = "0x763D010", VA = "0x18763DC10")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	internal static void OGCPPBNKBAK(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x763DA80", Offset = "0x763CE80", VA = "0x18763DA80")]
	internal static void NPNHMBHPBFP(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x763D160", Offset = "0x763C560", VA = "0x18763D160", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x763D590", Offset = "0x763C990", VA = "0x18763D590", Slot = "12")]
	[AsyncStateMachine(typeof(FPPGJFJCEJI))]
	public Task GDCNGOALEGL(string GOKALJGBJHH, [Optional] OLJAPIMLBLN ALCDDFEIMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x763DC80", Offset = "0x763D080", VA = "0x18763DC80", Slot = "19")]
	public Task OMANGPAOAEH(OLJAPIMLBLN ALCDDFEIMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x763CC20", Offset = "0x763C020", VA = "0x18763CC20", Slot = "20")]
	public Task AIIKPIJCCIE(OLJAPIMLBLN ALCDDFEIMFD, Dictionary<string, string> JJIIMFDMEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x763DAF0", Offset = "0x763CEF0", VA = "0x18763DAF0", Slot = "21")]
	public bool OGBAOGKIEGN(string BJHDDEKOFJK, bool MNDFDNOLOJL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x763CE80", Offset = "0x763C280", VA = "0x18763CE80", Slot = "22")]
	public HENELBFEDCM BPPAMPNMHDF(string EBFIHPGOKOB, bool MNDFDNOLOJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x763D350", Offset = "0x763C750", VA = "0x18763D350", Slot = "23")]
	public EAFDMPMEONO FIOHDFANDFF(string ICAEAKAPILN, bool MNDFDNOLOJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x763D1D0", Offset = "0x763C5D0", VA = "0x18763D1D0", Slot = "24")]
	public Task EPLMEHCPNMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x763D410", Offset = "0x763C810", VA = "0x18763D410")]
	private static void FPJABEJFIOF(TaskCompletionSource<bool> BBMIIIIDLPN, Task PFKGLBHNMHA, Task FCPNOPLOADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x763CF40", Offset = "0x763C340", VA = "0x18763CF40")]
	[AsyncStateMachine(typeof(CKHJEHMPBKI))]
	private static void CANDBGMBKFK(Task NHNFPALEEPM, TaskCompletionSource<bool> BBMIIIIDLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xDA98B0", Offset = "0xDA8CB0", VA = "0x180DA98B0")]
	[CompilerGenerated]
	private void LIIPKNIHKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xE2BD60", Offset = "0xE2B160", VA = "0x180E2BD60")]
	[CompilerGenerated]
	private void MKNPNDOAKAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xC16490", Offset = "0xC15890", VA = "0x180C16490")]
	[CompilerGenerated]
	private void HNEMNCKDICC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x763DDB0", Offset = "0x763D1B0", VA = "0x18763DDB0")]
	[CompilerGenerated]
	private void PFJBLHDEGIH(APKOBAKLOPM IEDBNFIMLNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class HIAPNMGNDOI : EAFDMPMEONO, DLMNMBIDMDD
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate void PKNOGNGEMDO(APKOBAKLOPM PEHOHDIAHIO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly PKNOGNGEMDO OFBMJCCOBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly JGGHAOMMHKI PJEODDKGNAE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x24DCD20", Offset = "0x24DC120", VA = "0x1824DCD20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string CIDPFFAPCID
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xD3AA30", Offset = "0xD39E30", VA = "0x180D3AA30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x68C5660", Offset = "0x68C4A60", VA = "0x1868C5660")]
	public HIAPNMGNDOI(JGGHAOMMHKI DMGLPHIJGLL, [Optional] PKNOGNGEMDO GDFPBPNJNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x35EE6A0", Offset = "0x35EDAA0", VA = "0x1835EE6A0", Slot = "6")]
	public T IOLMGDEDCOJ<T>(string DJBLFBEBKGO, T PFCPDJEHNAP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface NLIPHEJJPKA
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[UsedImplicitly]
public class FNCEHPOGNLK : NLIPHEJJPKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly HBBCCJPEIBM DLODNDHBPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly List<LLKJAKDKMID> HLDJCHHCFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly string PKCIGCCGNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly string OEPGIOMONGF;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7638930", Offset = "0x7637D30", VA = "0x187638930")]
	[UsedImplicitly]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	internal static void BBLAOBGDHMG(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x76389A0", Offset = "0x7637DA0", VA = "0x1876389A0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal FNCEHPOGNLK([CMKKAFOAFJE(null)][JetBrains.Annotations.NotNull] HBBCCJPEIBM DLODNDHBPPH, [CMKKAFOAFJE(null)][JetBrains.Annotations.NotNull] AOEDBNOBGKE DAFBCHCLCHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class OKELPALMDNL : KKKJLBLOICG
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Task IJKKPNOBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x763E610", Offset = "0x763DA10", VA = "0x18763E610", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task MEDLHLCJKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x763E430", Offset = "0x763D830", VA = "0x18763E430", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool OMNNPNGABAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EFLAIOOGMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string BKOCPKEGALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public JNOAAICKIKB DHDLDPIGKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action IBEFKBDNLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x763E1E0", Offset = "0x763D5E0", VA = "0x18763E1E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x763E140", Offset = "0x763D540", VA = "0x18763E140", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action DCEMJDKMPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x763DFF0", Offset = "0x763D3F0", VA = "0x18763DFF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x763E6A0", Offset = "0x763DAA0", VA = "0x18763E6A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action GNKBDLPFPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x763DF50", Offset = "0x763D350", VA = "0x18763DF50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x763E4C0", Offset = "0x763D8C0", VA = "0x18763E4C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<APKOBAKLOPM> NGICILOKALN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x763E560", Offset = "0x763D960", VA = "0x18763E560", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x763E740", Offset = "0x763DB40", VA = "0x18763E740", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	[RecRoom.NoEngine.Common.Preserve]
	public OKELPALMDNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x763E3A0", Offset = "0x763D7A0", VA = "0x18763E3A0", Slot = "12")]
	public Task GDCNGOALEGL(string GOKALJGBJHH, [Optional] OLJAPIMLBLN ALCDDFEIMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x763E7F0", Offset = "0x763DBF0", VA = "0x18763E7F0", Slot = "19")]
	public Task OMANGPAOAEH(OLJAPIMLBLN ALCDDFEIMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x763DEC0", Offset = "0x763D2C0", VA = "0x18763DEC0", Slot = "20")]
	public Task AIIKPIJCCIE(OLJAPIMLBLN ALCDDFEIMFD, Dictionary<string, string> JJIIMFDMEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "21")]
	public bool OGBAOGKIEGN(string BJHDDEKOFJK, bool MNDFDNOLOJL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x763E090", Offset = "0x763D490", VA = "0x18763E090", Slot = "22")]
	public HENELBFEDCM BPPAMPNMHDF(string EBFIHPGOKOB, bool MNDFDNOLOJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x763E310", Offset = "0x763D710", VA = "0x18763E310", Slot = "23")]
	public EAFDMPMEONO FIOHDFANDFF(string ICAEAKAPILN, bool MNDFDNOLOJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x763E280", Offset = "0x763D680", VA = "0x18763E280", Slot = "24")]
	public Task EPLMEHCPNMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class MIFGPDEGEMI : JNOAAICKIKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly IOBPPBKDDBE KFCKHPJOCGC;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IReadOnlyDictionary<string, object> BGLJANPPHGA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xD43D70", Offset = "0xD43170", VA = "0x180D43D70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	public MIFGPDEGEMI(IOBPPBKDDBE KICBDCDKDHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface KDEKNMBGJLE
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPMDOGLIEFI MEGABOJEFCP(string GHNIGGEMFFK);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface LCEBKHHFGNL
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum PGKBJCFFMNF
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
	long GGEFJPCECPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string IPMHPMDACDL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string CMNPEKDBHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool LMCNMIBAICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long DBOLMHMKLGN();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMEDHKCBIHB(long HFGKEOIDFDA, bool MDIJKPHCGAP = true);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OILBALOGNEP(string PCJJKLDOJMD, string NADHILHOIBL, string OGPEAJMIILP);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ODDKIOADNAH(string PCJJKLDOJMD);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CDLCBICJFJB(string PCJJKLDOJMD, string NHMJHFMLNEB, string KOBJKMBNFLG);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LJDLFHAHMHD(string BBLPHGNPPDD, object GJPLBAGDNJO, object FMNPKLJIIEM);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OIKBOMKBIOK(PGKBJCFFMNF HCFJCCMIMOL, int OMENMEAMBDP, [Optional] DLMHIIMNLDK KLAOCGNJIDO, [Optional] string MKLBIIODCEH, [Optional] string AFHGIBDEPMG);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NJMOJEOPHEI(DLMHIIMNLDK KLAOCGNJIDO, long IIKPOFBIONP, long CAFPIGKBEBF, int KAHEJLNPPOB, string MKLBIIODCEH, int OMENMEAMBDP);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JBGMIEMBCPA(DLMHIIMNLDK KLAOCGNJIDO, bool JKLFEMENKBM, [Optional] string AFHGIBDEPMG);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DBMLEOBFCNK(DLMHIIMNLDK KLAOCGNJIDO, bool JKLFEMENKBM, [Optional] string AFHGIBDEPMG);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PMLEKKMJFDJ(DLMHIIMNLDK KLAOCGNJIDO, bool JKLFEMENKBM, [Optional] string AFHGIBDEPMG);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BOGNBBIPLMG(long MIFADOBCMAC, string CDKJBBAADKL);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface NMEAKJFIGPM
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string AIJHALAMHGP
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
