using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A79BC0", Offset = "0x6A787C0", VA = "0x186A79BC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6A7C5D0", Offset = "0x6A7B1D0", VA = "0x186A7C5D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
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
		public AmplitudeAnalyticsClient.Settings NCJDGAINHOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JLCBEGDEMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x88C770", Offset = "0x88B370", VA = "0x18088C770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, PJNLDGODMKB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private enum ELHLBOGLOFA
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal class EGNLPABMMIK
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class DKFHFDJHJKG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int FBPNJNPGHEK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> JGOCGFBGEPF;

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
				public DKFHFDJHJKG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class OGDJNCPJEKH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
				public OGDJNCPJEKH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x6A79D30", Offset = "0x6A78930", VA = "0x186A79D30")]
				internal bool OLKFCJGFBNL(DKFHFDJHJKG item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string BEMPALNGCAK = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string BJNACHPNEEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<DKFHFDJHJKG> OMAIBMDNJBF;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? EHNJCBNFOPK
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x6A72E70", Offset = "0x6A71A70", VA = "0x186A72E70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6A73BF0", Offset = "0x6A727F0", VA = "0x186A73BF0")]
			internal EGNLPABMMIK(string DNIKPGPMALJ, string CKEKLKPICBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6A733D0", Offset = "0x6A71FD0", VA = "0x186A733D0")]
			public int LLBOFOHMIIL([Optional] int? CLGEAFGBJCF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6A73980", Offset = "0x6A72580", VA = "0x186A73980")]
			public List<Dictionary<string, object>> PBCAFJALABN(int CDFHEBEBDDN, int? CLGEAFGBJCF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6A72DD0", Offset = "0x6A719D0", VA = "0x186A72DD0")]
			public void FEKJGMHEOBI(AmplitudeAnalyticsIdentifyMessage PLAMADMDGIO, bool EPFCGKHNOBC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6A72CC0", Offset = "0x6A718C0", VA = "0x186A72CC0")]
			public void FEKJGMHEOBI(Dictionary<string, object> PLAMADMDGIO, bool EPFCGKHNOBC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6A72F10", Offset = "0x6A71B10", VA = "0x186A72F10")]
			public void GINHBDELCAD(params Dictionary<string, object>[] DHBHMBIPEGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6A73190", Offset = "0x6A71D90", VA = "0x186A73190")]
			public void KODINFENFEE(List<Dictionary<string, object>> CGMFHEHJKAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6A73090", Offset = "0x6A71C90", VA = "0x186A73090")]
			private void KBKIHLDIJFH(Dictionary<string, object> PLAMADMDGIO, bool EPFCGKHNOBC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6A729A0", Offset = "0x6A715A0", VA = "0x186A729A0")]
			public void DGCJKJIIEJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6A73580", Offset = "0x6A72180", VA = "0x186A73580")]
			private void NBAHPNIEBBC([Optional] string ELOBENJFDJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6A72BA0", Offset = "0x6A717A0", VA = "0x186A72BA0")]
			private static string DHEKIHMKIGN(string CABLCDOIFFL, string NONKDEOLPHL)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6A7C1F0", Offset = "0x6A7ADF0", VA = "0x186A7C1F0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct OLNECHGHBPC<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int OBJABACLBCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string NAKJICKEJNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T CBMKPNFPPGI;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class FBADDOKFGKP : IEnumerator<HGHICIBNEGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private HGHICIBNEGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private HGHICIBNEGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
			[DebuggerHidden]
			public FBADDOKFGKP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6A73D60", Offset = "0x6A72960", VA = "0x186A73D60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6A744F0", Offset = "0x6A730F0", VA = "0x186A744F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class ADCIIHLPCMD : IEnumerator<object>, IEnumerator, IDisposable
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
			public OKALCPGKGOK quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
			[DebuggerHidden]
			public ADCIIHLPCMD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6A69BD0", Offset = "0x6A687D0", VA = "0x186A69BD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6A69CE0", Offset = "0x6A688E0", VA = "0x186A69CE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class KKFAPFCIHEP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
			[DebuggerHidden]
			public KKFAPFCIHEP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6A78550", Offset = "0x6A77150", VA = "0x186A78550", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6A786C0", Offset = "0x6A772C0", VA = "0x186A786C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class NIIABIEFIMJ : IEnumerator<HGHICIBNEGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private HGHICIBNEGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private HGHICIBNEGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
			[DebuggerHidden]
			public NIIABIEFIMJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6A79350", Offset = "0x6A77F50", VA = "0x186A79350", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6A795B0", Offset = "0x6A781B0", VA = "0x186A795B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class OJIMPDNMGOH : IEnumerator<HGHICIBNEGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private HGHICIBNEGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private HGHICIBNEGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
			[DebuggerHidden]
			public OJIMPDNMGOH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6A79DA0", Offset = "0x6A789A0", VA = "0x186A79DA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6A79FF0", Offset = "0x6A78BF0", VA = "0x186A79FF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class DNKGGPEGNNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public EGNLPABMMIK cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public DNKGGPEGNNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6A720C0", Offset = "0x6A70CC0", VA = "0x186A720C0")]
			internal void CKFLEHLBMNC(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6A723D0", Offset = "0x6A70FD0", VA = "0x186A723D0")]
			internal void GHDPMILBCAM(OLNECHGHBPC<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class GKHHOJIHPPM : IEnumerator<HGHICIBNEGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private HGHICIBNEGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public EGNLPABMMIK cache;

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
			private DNKGGPEGNNK <>8__1;

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
			private HGHICIBNEGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
			[DebuggerHidden]
			public GKHHOJIHPPM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6A74FD0", Offset = "0x6A73BD0", VA = "0x186A74FD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6A757E0", Offset = "0x6A743E0", VA = "0x186A757E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class GDLGFFCCFOP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public GDLGFFCCFOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x3ED9FA0", Offset = "0x3ED8BA0", VA = "0x183ED9FA0")]
			internal OLNECHGHBPC<T> CCCOCGBFDGI(GEPIIDOMGGP postResponse)
			{
				return default(OLNECHGHBPC<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private HCOCEAMGNIJ HLCNLJHDNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<FLELEOFJDIK> DEDDEKNECEI;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string PCBDFEIJCME = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string ANFCAMAJEAP = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string MGKMEPBHMDO = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int BKHDEGOJIPI = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int DEMDJBJFJJK = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int HIDJMLGKANH = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float JCDHMGFHMHP = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long FOAGLLHNAIF = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string GJBMJFFCJHP = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string NIOKGKJANNF = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string JLELLLADPDP = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string OAIEDFFPBAB = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool NEFELNIOAKN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool CJPBBMGFENN;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int GIGOMHEDPLG;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int DOGLLKLIJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private MGPFMJGLDHL ADPIOJJOFND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DPOPPFDIPPD GPCHGJGNJAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private ILCELNBOEME JBLNJDLFMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool KECBGLEAFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float PPABPLKOCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float AKEAJIBOEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int DOCFBDLFLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int CCHJBMLOKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? IKHGCIMKBNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? FJPAJJFPMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long DBMJFLLLBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string BJPNMAFOMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string IGJAIBNDGGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long KIOOGPLLPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string BOOJCOBIBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string FOKJHGAIJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> FCAFLNOHEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private ELHLBOGLOFA DMEEGLAMFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int MAGKOEJDLBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int AGBBLNAEOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float HNNOCIOLGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool KJDDNIPKFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool ANOMEJLDEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private EGNLPABMMIK JADKNFMCAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private EGNLPABMMIK APDPAFBAADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private EGNLPABMMIK JCDPJNKMDLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string IOJPBNFOCLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> JLFOCNEMDBA;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo PGLJLKNLEAC;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string PICELIMBGCA;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string IIFNIPMLDDO = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string PIOBDGHENOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string LMGHMMMEKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string BLINEJPFEIG;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private HCOCEAMGNIJ LMGCBFHICNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6A6C7D0", Offset = "0x6A6B3D0", VA = "0x186A6C7D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private FLELEOFJDIK JPPNJAIJMBE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6A69D30", Offset = "0x6A68930", VA = "0x186A69D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int DDNGBDBJIMF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6A6C5D0", Offset = "0x6A6B1D0", VA = "0x186A6C5D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long BHGLDKDMKKM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6A6FB70", Offset = "0x6A6E770", VA = "0x186A6FB70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6A6FC80", Offset = "0x6A6E880", VA = "0x186A6FC80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string MGPJGFFAKMF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6A6FB40", Offset = "0x6A6E740", VA = "0x186A6FB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LEOLOCPNFLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD9ECE0", Offset = "0xD9D8E0", VA = "0x180D9ECE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD9DDF0", Offset = "0xD9C9F0", VA = "0x180D9DDF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string CEOLPEGNJEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA62A90", Offset = "0xA61690", VA = "0x180A62A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD44A40", Offset = "0xD43640", VA = "0x180D44A40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? EHAOJHOJHJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8D3D00", Offset = "0x8D2900", VA = "0x1808D3D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x19C1DB0", Offset = "0x19C09B0", VA = "0x1819C1DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FCDCEBPBICI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xBE21A0", Offset = "0xBE0DA0", VA = "0x180BE21A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCA0170", Offset = "0xC9ED70", VA = "0x180CA0170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool BKGNBHEKLMN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6A6FA20", Offset = "0x6A6E620", VA = "0x186A6FA20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> HPGHKMINKMA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6A6F960", Offset = "0x6A6E560", VA = "0x186A6F960")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6A6FBC0", Offset = "0x6A6E7C0", VA = "0x186A6FBC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A69F20", Offset = "0x6A68B20", VA = "0x186A69F20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C210", Offset = "0x6A6AE10", VA = "0x186A6C210")]
		private void FBNCPCADMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EFA0", Offset = "0x6A6DBA0", VA = "0x186A6EFA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DC70", Offset = "0x6A6C870", VA = "0x186A6DC70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F2D0", Offset = "0x6A6DED0", VA = "0x186A6F2D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DD20", Offset = "0x6A6C920", VA = "0x186A6DD20")]
		public DMMKPEDFDBF PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CF70", Offset = "0x6A6BB70", VA = "0x186A6CF70")]
		[IteratorStateMachine(typeof(FBADDOKFGKP))]
		public IEnumerator<HGHICIBNEGP> InitializeForLocalAccount(AmplitudeAnalyticsEvent DJNFCPBFAIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E680", Offset = "0x6A6D280", VA = "0x186A6E680")]
		public void SendAppEnterEvent(bool EKPEGBLCMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F250", Offset = "0x6A6DE50", VA = "0x186A6F250")]
		public void UpdateLastKnownInteractionCategory(string EIPNDNGPGLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F1A0", Offset = "0x6A6DDA0", VA = "0x186A6F1A0")]
		public void UpdateLastAliveTime(float EOJDMAMGKKO = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D000", Offset = "0x6A6BC00", VA = "0x186A6D000")]
		private DMMKPEDFDBF JFADAOACLDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D1A0", Offset = "0x6A6BDA0", VA = "0x186A6D1A0")]
		private DMMKPEDFDBF KEKLNHGMNEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E990", Offset = "0x6A6D590", VA = "0x186A6E990")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A580", Offset = "0x6A69180", VA = "0x186A6A580")]
		[IteratorStateMachine(typeof(ADCIIHLPCMD))]
		private IEnumerator BBOEDOGHODG(OKALCPGKGOK MPCDIEOEPKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F560", Offset = "0x6A6E160", VA = "0x186A6F560")]
		[IteratorStateMachine(typeof(KKFAPFCIHEP))]
		public IEnumerator WaitForFlush(float KNDDOANJCCI = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F080", Offset = "0x6A6DC80", VA = "0x186A6F080")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EFC0", Offset = "0x6A6DBC0", VA = "0x186A6EFC0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime GBMJCPKKICC)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CA80", Offset = "0x6A6B680", VA = "0x186A6CA80")]
		public static ODMDPMFJKAB Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A69D80", Offset = "0x6A68980", VA = "0x186A69D80")]
		public static NOJNAJCKAON AccountSelectionPostLoginEvent([NotNull] string JAKJIOGFBJB, string OPFGDKAACDG, OEBPLANCGOE KCPBPLCCKIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BF10", Offset = "0x6A6AB10", VA = "0x186A6BF10")]
		public static NOJNAJCKAON Event([NotNull] string JAKJIOGFBJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DEB0", Offset = "0x6A6CAB0", VA = "0x186A6DEB0")]
		public static NOJNAJCKAON PreviousSessionEvent([NotNull] string JAKJIOGFBJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CC20", Offset = "0x6A6B820", VA = "0x186A6CC20")]
		public static NOJNAJCKAON InitializeEvent(string OPFGDKAACDG, int EMBODKDNMKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EB90", Offset = "0x6A6D790", VA = "0x186A6EB90")]
		public static NOJNAJCKAON StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A960", Offset = "0x6A69560", VA = "0x186A6A960")]
		public static NOJNAJCKAON CreateOutOfSessionEvent(string JAKJIOGFBJB, bool LLDADJBLDEC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D790", Offset = "0x6A6C390", VA = "0x186A6D790")]
		public static DMMKPEDFDBF LogOutOfSessionEvent(NOJNAJCKAON CPCMEIINKNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D530", Offset = "0x6A6C130", VA = "0x186A6D530")]
		public void LogEventAsync(AmplitudeAnalyticsEvent NKBLKECGIBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D950", Offset = "0x6A6C550", VA = "0x186A6D950")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent NKBLKECGIBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DA80", Offset = "0x6A6C680", VA = "0x186A6DA80")]
		public void LogSerializedEventAsync(Dictionary<string, object> ILHKJIPNKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D660", Offset = "0x6A6C260", VA = "0x186A6D660")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HODGGOAEELP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C980", Offset = "0x6A6B580", VA = "0x186A6C980")]
		private void IKCNGPGPFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BC60", Offset = "0x6A6A860", VA = "0x186A6BC60")]
		private void EPDOMPJIJJB(Dictionary<string, object> BLCHLAOACNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D0B0", Offset = "0x6A6BCB0", VA = "0x186A6D0B0")]
		private void JNBHLEOANGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D360", Offset = "0x6A6BF60", VA = "0x186A6D360")]
		private void LACHHEHGAEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C860", Offset = "0x6A6B460", VA = "0x186A6C860")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BBD0", Offset = "0x6A6A7D0", VA = "0x186A6BBD0")]
		[IteratorStateMachine(typeof(NIIABIEFIMJ))]
		private IEnumerator<HGHICIBNEGP> ELDBBIEFDBG(float KNDDOANJCCI = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C8F0", Offset = "0x6A6B4F0", VA = "0x186A6C8F0")]
		[IteratorStateMachine(typeof(OJIMPDNMGOH))]
		private IEnumerator<HGHICIBNEGP> IGHHKNDCIFG(float KNDDOANJCCI = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B980", Offset = "0x6A6A580", VA = "0x186A6B980")]
		[IteratorStateMachine(typeof(GKHHOJIHPPM))]
		private IEnumerator<HGHICIBNEGP> DHJOJMIJCCE(EGNLPABMMIK FAJPBGGJLEJ, int? CLGEAFGBJCF, string PPJHIDGOKFA, float KNDDOANJCCI, Action<int> AFDEJDCNGIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DB60", Offset = "0x6A6C760", VA = "0x186A6DB60")]
		private static void NGIPMNMEFGN(bool JCMFECDAALJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A880", Offset = "0x6A69480", VA = "0x186A6A880")]
		private HHDNLBNGHMC<OLNECHGHBPC<Dictionary<string, object>>> CGNOIHLPNFP(string PPJHIDGOKFA, string DCKDNMGDHPC, Dictionary<string, object> CBMKPNFPPGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A610", Offset = "0x6A69210", VA = "0x186A6A610")]
		private HHDNLBNGHMC<OLNECHGHBPC<List<Dictionary<string, object>>>> CGNOIHLPNFP(string PPJHIDGOKFA, string DCKDNMGDHPC, List<Dictionary<string, object>> CBMKPNFPPGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x34F90A0", Offset = "0x34F7CA0", VA = "0x1834F90A0")]
		private HHDNLBNGHMC<OLNECHGHBPC<T>> IMDFPIAMMBP<T>(string GHKGOFLMLEC, string PPJHIDGOKFA, string DCKDNMGDHPC, T CBMKPNFPPGI, Dictionary<string, object> NONDLLEIDKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D310", Offset = "0x6A6BF10", VA = "0x186A6D310")]
		private bool KFLAGAIGHAJ(float OPAEOLIADNO, float KNDDOANJCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6A6AC20", Offset = "0x6A69820", VA = "0x186A6AC20")]
		private Dictionary<string, object> DDFCLPHLMIN(string PPJHIDGOKFA, Dictionary<string, object> CBMKPNFPPGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F650", Offset = "0x6A6E250", VA = "0x186A6F650")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8B57E0", Offset = "0x8B43E0", VA = "0x1808B57E0", Slot = "6")]
		private bool OHGACKONIMH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BA60", Offset = "0x6A6A660", VA = "0x186A6BA60")]
		[CompilerGenerated]
		private long DMBLJIPJFCO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A950", Offset = "0x6A69550", VA = "0x186A6A950")]
		[CompilerGenerated]
		private void CNDFCAHHLLG(int HNBGMIOCMAD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
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
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6A70960", Offset = "0x6A6F560", VA = "0x186A70960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6A70A30", Offset = "0x6A6F630", VA = "0x186A70A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6A709A0", Offset = "0x6A6F5A0", VA = "0x186A709A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6A70A80", Offset = "0x6A6F680", VA = "0x186A70A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6A70920", Offset = "0x6A6F520", VA = "0x186A70920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6A709E0", Offset = "0x6A6F5E0", VA = "0x186A709E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x88C490", Offset = "0x88B090", VA = "0x18088C490")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FF50", Offset = "0x6A6EB50", VA = "0x186A6FF50")]
		public static NOJNAJCKAON ELGDCMPCLII(string OGMJKGKJANG, [NotNull] string BDGIAKPDGJF, long KOOCAHLAKIM, long AMPAMEEKGIN, string OPFGDKAACDG, string KCPBPLCCKIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FCE0", Offset = "0x6A6E8E0", VA = "0x186A6FCE0")]
		public static NOJNAJCKAON AFIIBOGOBNH(string OGMJKGKJANG, [NotNull] string BDGIAKPDGJF, long KOOCAHLAKIM, long AMPAMEEKGIN, string OPFGDKAACDG, long EFGGFLOFIBK, string HKKPDOGKIGJ, string AMCCEDHDJOP, string KNHPNECHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A70780", Offset = "0x6A6F380", VA = "0x186A70780")]
		private AmplitudeAnalyticsEvent(string OGMJKGKJANG, [NotNull] string BDGIAKPDGJF, long KOOCAHLAKIM, long AMPAMEEKGIN, string OPFGDKAACDG, string KCPBPLCCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5F60", Offset = "0x1FC4B60", VA = "0x181FC5F60")]
		public void LEDGAFADPND(long MDAMIBKGOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6A70050", Offset = "0x6A6EC50", VA = "0x186A70050", Slot = "5")]
		public override void GNMHOJEDAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6A70610", Offset = "0x6A6F210", VA = "0x186A70610", Slot = "6")]
		public override void OKKJOHPBJDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A70150", Offset = "0x6A6ED50", VA = "0x186A70150", Slot = "4")]
		protected override Dictionary<string, object> LFDNNCCGGEP(Dictionary<string, object> NAIBAJJPIMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FE40", Offset = "0x6A6EA40", VA = "0x186A6FE40")]
		private void DDFOCELBCLA(string NONKDEOLPHL, string CABLCDOIFFL, bool BJABEGJOPKC = false)
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

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6A72820", Offset = "0x6A71420", VA = "0x186A72820")]
			public void BLEKAMNJAPP(Dictionary<string, object> BKHOLKJEFAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
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

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6A7BE80", Offset = "0x6A7AA80", VA = "0x186A7BE80")]
			public void BLEKAMNJAPP(Dictionary<string, object> DFNEKAEJBDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xC63A40", Offset = "0xC62640", VA = "0x180C63A40")]
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
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6A70B60", Offset = "0x6A6F760", VA = "0x186A70B60")]
		public static ODMDPMFJKAB ELGDCMPCLII(string OGMJKGKJANG, string OPFGDKAACDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A71180", Offset = "0x6A6FD80", VA = "0x186A71180")]
		protected AmplitudeAnalyticsIdentifyMessage(string OGMJKGKJANG, string OPFGDKAACDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6A70AD0", Offset = "0x6A6F6D0", VA = "0x186A70AD0")]
		public Dictionary<string, object> EBJJODCKLOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A70D50", Offset = "0x6A6F950", VA = "0x186A70D50", Slot = "4")]
		protected virtual Dictionary<string, object> LFDNNCCGGEP(Dictionary<string, object> NAIBAJJPIMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A70CB0", Offset = "0x6A6F8B0", VA = "0x186A70CB0")]
		protected void KHDOGEHICMD(string NONKDEOLPHL, Dictionary<string, object> PDDNNJHGBKI, Dictionary<string, object> OJGEPDCJBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A71090", Offset = "0x6A6FC90", VA = "0x186A71090")]
		protected void LHOFOMHMOIP(string NONKDEOLPHL, string CABLCDOIFFL, Dictionary<string, object> LJEPIPDKBDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A70C20", Offset = "0x6A6F820", VA = "0x186A70C20", Slot = "5")]
		public virtual void GNMHOJEDAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6A71100", Offset = "0x6A6FD00", VA = "0x186A71100", Slot = "6")]
		public virtual void OKKJOHPBJDJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ODMDPMFJKAB : CBENAAKIDIJ<AmplitudeAnalyticsIdentifyMessage, ODMDPMFJKAB>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override ODMDPMFJKAB ALLBDPHKOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage CJFDEKLFDDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A79CE0", Offset = "0x6A788E0", VA = "0x186A79CE0")]
	public ODMDPMFJKAB(AmplitudeAnalyticsIdentifyMessage LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A79C40", Offset = "0x6A78840", VA = "0x186A79C40", Slot = "4")]
	public override void OKKJOHPBJDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NOJNAJCKAON : CBENAAKIDIJ<AmplitudeAnalyticsEvent, NOJNAJCKAON>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool BDPDNHABKOI;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override NOJNAJCKAON ALLBDPHKOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long LJCPJIKIBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6A79840", Offset = "0x6A78440", VA = "0x186A79840")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A71F90", Offset = "0x6A70B90", VA = "0x186A71F90")]
	public NOJNAJCKAON(AmplitudeAnalyticsEvent LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "5")]
	public override AmplitudeAnalyticsEvent CJFDEKLFDDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A79A30", Offset = "0x6A78630", VA = "0x186A79A30", Slot = "4")]
	public override void OKKJOHPBJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2F893B0", Offset = "0x2F87FB0", VA = "0x182F893B0")]
	public NOJNAJCKAON PANFNDPFEKI<T>(string OPOMMFAAAOF, T[] CABLCDOIFFL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2F893B0", Offset = "0x2F87FB0", VA = "0x182F893B0")]
	public NOJNAJCKAON PANFNDPFEKI(string OPOMMFAAAOF, string[] CABLCDOIFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2F89100", Offset = "0x2F87D00", VA = "0x182F89100")]
	public NOJNAJCKAON PANFNDPFEKI<T>(string OPOMMFAAAOF, T CABLCDOIFFL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A79AD0", Offset = "0x6A786D0", VA = "0x186A79AD0")]
	public NOJNAJCKAON PANFNDPFEKI(string OPOMMFAAAOF, long CABLCDOIFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A79B50", Offset = "0x6A78750", VA = "0x186A79B50")]
	public NOJNAJCKAON PANFNDPFEKI(string OPOMMFAAAOF, string CABLCDOIFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A79A00", Offset = "0x6A78600", VA = "0x186A79A00")]
	public NOJNAJCKAON ODGCKHLIHHI(string OPOMMFAAAOF, object? CABLCDOIFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A79960", Offset = "0x6A78560", VA = "0x186A79960")]
	public NOJNAJCKAON MAPOPBGDIOC(string OPOMMFAAAOF, string CABLCDOIFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A79860", Offset = "0x6A78460", VA = "0x186A79860")]
	private NOJNAJCKAON KHIKHGCHHBB(string OPOMMFAAAOF, object CABLCDOIFFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CEBOPKEIEJP : NOJNAJCKAON
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A71F90", Offset = "0x6A70B90", VA = "0x186A71F90")]
	public CEBOPKEIEJP(AmplitudeAnalyticsEvent LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A71DF0", Offset = "0x6A709F0", VA = "0x186A71DF0", Slot = "4")]
	public override void OKKJOHPBJDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class CBENAAKIDIJ<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : CBENAAKIDIJ<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M LFKIGNHCOID;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR ALLBDPHKOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	public CBENAAKIDIJ(M LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5238970", Offset = "0x5237570", VA = "0x185238970")]
	public BLDR PBIMNBENPLP(AmplitudeAnalyticsIdentifyMessage.DeviceInfo ABFLCIGHMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5238920", Offset = "0x5237520", VA = "0x185238920")]
	public BLDR KKMNGBEDCLP(AmplitudeAnalyticsIdentifyMessage.RevenueData MABHKHDDEEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5238750", Offset = "0x5237350", VA = "0x185238750")]
	public BLDR ACFDMBEPCEM(string OPOMMFAAAOF, string CABLCDOIFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B3B160", Offset = "0x2B39D60", VA = "0x182B3B160")]
	public BLDR ACFDMBEPCEM<T>(string OPOMMFAAAOF, T CABLCDOIFFL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void OKKJOHPBJDJ();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x52387F0", Offset = "0x52373F0", VA = "0x1852387F0")]
	internal static string FHCNJINDMHD(string CABLCDOIFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5238820", Offset = "0x5237420", VA = "0x185238820")]
	private BLDR JEHFIOLJGDF(string OPOMMFAAAOF, object CABLCDOIFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M CJFDEKLFDDE();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class HPLHNMGFAAG : MGPFMJGLDHL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct MCOKDHGCHMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<GEPIIDOMGGP> <>t__builder;

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
		public HPLHNMGFAAG <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6A788B0", Offset = "0x6A774B0", VA = "0x186A788B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6A792E0", Offset = "0x6A77EE0", VA = "0x186A792E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient APMBJNBLDLN;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6A77FA0", Offset = "0x6A76BA0", VA = "0x186A77FA0")]
	[BOLBLOCFHKO.ENGLBNKHCKK]
	internal static void OPDBIEOKHHN(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A78010", Offset = "0x6A76C10", VA = "0x186A78010")]
	[RecRoom.NoEngine.Common.Preserve]
	public HPLHNMGFAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A77E30", Offset = "0x6A76A30", VA = "0x186A77E30", Slot = "4")]
	[AsyncStateMachine(typeof(MCOKDHGCHMG))]
	public Task<GEPIIDOMGGP> BPKGNAPOEBL(string GHKGOFLMLEC, string DPEIBAKIOOG, string NBJEBAEPKDD, string PMFCMKKLDHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class FJOJINFNCDF : MGPFMJGLDHL
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DLDJGPCMJKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<GEPIIDOMGGP> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public DLDJGPCMJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6A71FE0", Offset = "0x6A70BE0", VA = "0x186A71FE0")]
		internal void ACLBNKNPGIL(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct OMPHHFBMANH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<GEPIIDOMGGP> <>t__builder;

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
		private TaskAwaiter<GEPIIDOMGGP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A040", Offset = "0x6A78C40", VA = "0x186A7A040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A590", Offset = "0x6A79190", VA = "0x186A7A590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	[BOLBLOCFHKO.ENGLBNKHCKK]
	internal static void MBDDGNPEGMG(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FJOJINFNCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A74540", Offset = "0x6A73140", VA = "0x186A74540", Slot = "4")]
	[AsyncStateMachine(typeof(OMPHHFBMANH))]
	public Task<GEPIIDOMGGP> BPKGNAPOEBL(string GHKGOFLMLEC, string DPEIBAKIOOG, string NBJEBAEPKDD, string PMFCMKKLDHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LPGMJFGNJLC
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> HJLFBDAIELI;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A78710", Offset = "0x6A77310", VA = "0x186A78710")]
	internal static bool GGDKGNOMLGD(string NONKDEOLPHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MGPFMJGLDHL
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GEPIIDOMGGP> BPKGNAPOEBL(string GHKGOFLMLEC, string DPEIBAKIOOG, string NBJEBAEPKDD, string PMFCMKKLDHD);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct GEPIIDOMGGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int FGCNJFOBBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string GMIKDPPLJDD;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xF963E0", Offset = "0xF94FE0", VA = "0x180F963E0")]
	public GEPIIDOMGGP(int OBJABACLBCO, string NAKJICKEJNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum DPGOCGHBFIO
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
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class POPJGDNFMLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private long ELIGILOAHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private NOJNAJCKAON JALJLGDDOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool INJBEKJMLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float BDMEBODCMBJ;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BCF0", Offset = "0x6A7A8F0", VA = "0x186A7BCF0")]
	public POPJGDNFMLO(string AFIPLPBKMEG, float BDMEBODCMBJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2FDEDF0", Offset = "0x2FDD9F0", VA = "0x182FDEDF0")]
	public void PANFNDPFEKI<T>(string OPOMMFAAAOF, T CABLCDOIFFL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BBB0", Offset = "0x6A7A7B0", VA = "0x186A7BBB0")]
	public void PANFNDPFEKI(string OPOMMFAAAOF, string CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B9B0", Offset = "0x6A7A5B0", VA = "0x186A7B9B0")]
	public void EINCONPMBAL(string LEHIILCLFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BC30", Offset = "0x6A7A830", VA = "0x186A7BC30")]
	public void PMKDCIPEDPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BAA0", Offset = "0x6A7A6A0", VA = "0x186A7BAA0")]
	private void KHFLMHOKKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B960", Offset = "0x6A7A560", VA = "0x186A7B960")]
	private bool DLJJGPAOPJB()
	{
		return default(bool);
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum GOACJOBPFIE
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
		private GOACJOBPFIE parameterType;

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
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public GOACJOBPFIE Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8E9FA0", Offset = "0x8E8BA0", VA = "0x1808E9FA0")]
			get
			{
				return default(GOACJOBPFIE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8B6010", Offset = "0x8B4C10", VA = "0x1808B6010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6A7BFF0", Offset = "0x6A7ABF0", VA = "0x186A7BFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class IMBDBMOHHFJ : LJGMMAECGKC, FBMJLDCPMCD
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate void EGLOMPFMPBK(IDDGACAAPOM JECBNPICBHO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly DBPPKJBDDHD HIHPOKDOKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly EGLOMPFMPBK DKGBAABHGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string PGPHCEEKAOJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string JLMNBDOKGCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1427B00", Offset = "0x1426700", VA = "0x181427B00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DFBGLAMFKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A784A0", Offset = "0x6A770A0", VA = "0x186A784A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool FMNJFNCPADP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6A784C0", Offset = "0x6A770C0", VA = "0x186A784C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> HONKLKKGCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1427A90", Offset = "0x1426690", VA = "0x181427A90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A784E0", Offset = "0x6A770E0", VA = "0x186A784E0")]
	public IMBDBMOHHFJ(DBPPKJBDDHD NLEDHKLDJJG, string LBPGELHODJP, [Optional] EGLOMPFMPBK DABBADCNDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2E6AFB0", Offset = "0x2E69BB0", VA = "0x182E6AFB0", Slot = "8")]
	public T IBIJBNAFKLE<T>(string NONKDEOLPHL, T IEDAFAANJNE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class HCPGEEOHBLA : OAJBCHCNOFD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct AAHICELGGPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public DPOPPFDIPPD userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public HCPGEEOHBLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6A69220", Offset = "0x6A67E20", VA = "0x186A69220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6A69B70", Offset = "0x6A68770", VA = "0x186A69B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct HNCKDAFPEKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6A77C10", Offset = "0x6A76810", VA = "0x186A77C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A77DD0", Offset = "0x6A769D0", VA = "0x186A77DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct GNDGOLOLFAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public DPOPPFDIPPD userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public HCPGEEOHBLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A75830", Offset = "0x6A74430", VA = "0x186A75830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A75C40", Offset = "0x6A74840", VA = "0x186A75C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct ILNMDDOJMFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public HCPGEEOHBLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public DPOPPFDIPPD userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6A78090", Offset = "0x6A76C90", VA = "0x186A78090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6A78440", Offset = "0x6A77040", VA = "0x186A78440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly IReadOnlyDictionary<string, MJBDEIHDBIN> CLCCKBCHPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool IMKJKBFBABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool ABOJHOAPPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private TaskCompletionSource<bool> FKOOGKMJABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private TaskCompletionSource<bool> JCALMBALLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly SemaphoreSlim JGLHNBLLJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private CCKCBLJOOEG OPGKFCIJMHM;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Task MEDKIGNPOLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A77500", Offset = "0x6A76100", VA = "0x186A77500", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool JFFMAHOMLKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x935C80", Offset = "0x934880", VA = "0x180935C80", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool NDPLONHPPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xD4B480", Offset = "0xD4A080", VA = "0x180D4B480", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string CEOLPEGNJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6A76CB0", Offset = "0x6A758B0", VA = "0x186A76CB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public GHMMAPHABKF JEKNJLELLPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A772E0", Offset = "0x6A75EE0", VA = "0x186A772E0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GADDLCHLDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A76010", Offset = "0x6A74C10", VA = "0x186A76010", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6A77310", Offset = "0x6A75F10", VA = "0x186A77310", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IGKAEKFKJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A75CA0", Offset = "0x6A748A0", VA = "0x186A75CA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A76220", Offset = "0x6A74E20", VA = "0x186A76220", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OOPHEPGJJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A77090", Offset = "0x6A75C90", VA = "0x186A77090", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6A75F70", Offset = "0x6A74B70", VA = "0x186A75F70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<IDDGACAAPOM> HLEFNBHPODE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A77450", Offset = "0x6A76050", VA = "0x186A77450", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A76E20", Offset = "0x6A75A20", VA = "0x186A76E20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A75F50", Offset = "0x6A74B50", VA = "0x186A75F50", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6A76D00", Offset = "0x6A75900", VA = "0x186A76D00", Slot = "12")]
	[AsyncStateMachine(typeof(AAHICELGGPC))]
	public Task KMAKNPIEEHP(string CKEKLKPICBH, [Optional] DPOPPFDIPPD KCEHGHMENBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A76170", Offset = "0x6A74D70", VA = "0x186A76170", Slot = "23")]
	[AsyncStateMachine(typeof(HNCKDAFPEKL))]
	public Task HALFADNJGAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A75E50", Offset = "0x6A74A50", VA = "0x186A75E50", Slot = "18")]
	[AsyncStateMachine(typeof(GNDGOLOLFAE))]
	public Task DLLCMDNALGC(DPOPPFDIPPD KCEHGHMENBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6A773B0", Offset = "0x6A75FB0", VA = "0x186A773B0")]
	private void NJCAMEIANCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A76BA0", Offset = "0x6A757A0", VA = "0x186A76BA0", Slot = "19")]
	[AsyncStateMachine(typeof(ILNMDDOJMFN))]
	public Task JJCFCPAHAKJ(DPOPPFDIPPD KCEHGHMENBC, Dictionary<string, string> NDAPJLNCOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A760B0", Offset = "0x6A74CB0", VA = "0x186A760B0", Slot = "20")]
	public bool FFMCKNNDAKO(string IHBFBCLCMIN, bool JPLJHPMPJLL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A76ED0", Offset = "0x6A75AD0", VA = "0x186A76ED0", Slot = "21")]
	public LJGMMAECGKC KOGOFEOIPJO(string LBPGELHODJP, bool JPLJHPMPJLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A777C0", Offset = "0x6A763C0", VA = "0x186A777C0")]
	private DBPPKJBDDHD PGAFBMMHJKB(string LBPGELHODJP, bool JPLJHPMPJLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6A77610", Offset = "0x6A76210", VA = "0x186A77610", Slot = "22")]
	public GGJEMLCHIKF OJAOPMMBBLO(string BAFGJOMINAM, bool JPLJHPMPJLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6A77540", Offset = "0x6A76140", VA = "0x186A77540")]
	private FBKGNILCAAC OGHENCNHFPK(string BAFGJOMINAM, bool JPLJHPMPJLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6A762C0", Offset = "0x6A74EC0", VA = "0x186A762C0")]
	private KEAOJFKOFFF IMPBHICEJLL(DPOPPFDIPPD KCEHGHMENBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6A77130", Offset = "0x6A75D30", VA = "0x186A77130")]
	private JJPPMEOGNJG MEABCJCOHAN(string CKEKLKPICBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6A75D40", Offset = "0x6A74940", VA = "0x186A75D40")]
	private void DFJOHNFJMDC(string LBPGELHODJP, DBPPKJBDDHD NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6A77B10", Offset = "0x6A76710", VA = "0x186A77B10")]
	public HCPGEEOHBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6A76CC0", Offset = "0x6A758C0", VA = "0x186A76CC0")]
	[CompilerGenerated]
	private void KJJDDHALNDH(IDDGACAAPOM LNOMDCGJNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6A76CC0", Offset = "0x6A758C0", VA = "0x186A76CC0")]
	[CompilerGenerated]
	private void LBPIPODPCCB(IDDGACAAPOM LNOMDCGJNHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class PEPMIEACHPD : OAJBCHCNOFD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct BCMGCENHMPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public PEPMIEACHPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public DPOPPFDIPPD userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6A71240", Offset = "0x6A6FE40", VA = "0x186A71240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6A71BC0", Offset = "0x6A707C0", VA = "0x186A71BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct NLEHJHMLOEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6A79600", Offset = "0x6A78200", VA = "0x186A79600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private HCPGEEOHBLA BKFHPECBPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private TaskCompletionSource<bool> FKOOGKMJABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private TaskCompletionSource<bool> JCALMBALLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Task IGGPAKIDAKD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private OAJBCHCNOFD CKILFKBLILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A7AAB0", Offset = "0x6A796B0", VA = "0x186A7AAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool NDPLONHPPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B820", Offset = "0x6A7A420", VA = "0x186A7B820", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JFFMAHOMLKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B750", Offset = "0x6A7A350", VA = "0x186A7B750", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Task MEDKIGNPOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B550", Offset = "0x6A7A150", VA = "0x186A7B550", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string CEOLPEGNJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B080", Offset = "0x6A79C80", VA = "0x186A7B080", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public GHMMAPHABKF JEKNJLELLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B3C0", Offset = "0x6A79FC0", VA = "0x186A7B3C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action IGKAEKFKJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A670", Offset = "0x6A79270", VA = "0x186A7A670", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6A7ADF0", Offset = "0x6A799F0", VA = "0x186A7ADF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action GADDLCHLDKB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A8F0", Offset = "0x6A794F0", VA = "0x186A7A8F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B400", Offset = "0x6A7A000", VA = "0x186A7B400", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action OOPHEPGJJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B320", Offset = "0x6A79F20", VA = "0x186A7B320", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A850", Offset = "0x6A79450", VA = "0x186A7A850", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<IDDGACAAPOM> HLEFNBHPODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B4A0", Offset = "0x6A7A0A0", VA = "0x186A7B4A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B1B0", Offset = "0x6A79DB0", VA = "0x186A7B1B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B8A0", Offset = "0x6A7A4A0", VA = "0x186A7B8A0")]
	[UnityEngine.Scripting.Preserve]
	public PEPMIEACHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B830", Offset = "0x6A7A430", VA = "0x186A7B830")]
	[BOLBLOCFHKO.ENGLBNKHCKK.CLDNNCAHIAO]
	internal static void PKCPHNKIBBJ(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A600", Offset = "0x6A79200", VA = "0x186A7A600")]
	internal static void AGFICJCPJCJ(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A820", Offset = "0x6A79420", VA = "0x186A7A820", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B0A0", Offset = "0x6A79CA0", VA = "0x186A7B0A0", Slot = "12")]
	[AsyncStateMachine(typeof(BCMGCENHMPL))]
	public Task KMAKNPIEEHP(string CKEKLKPICBH, [Optional] DPOPPFDIPPD KCEHGHMENBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A710", Offset = "0x6A79310", VA = "0x186A7A710", Slot = "18")]
	public Task DLLCMDNALGC(DPOPPFDIPPD KCEHGHMENBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AF60", Offset = "0x6A79B60", VA = "0x186A7AF60", Slot = "19")]
	public Task JJCFCPAHAKJ(DPOPPFDIPPD KCEHGHMENBC, Dictionary<string, string> NDAPJLNCOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A990", Offset = "0x6A79590", VA = "0x186A7A990", Slot = "20")]
	public bool FFMCKNNDAKO(string IHBFBCLCMIN, bool JPLJHPMPJLL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B260", Offset = "0x6A79E60", VA = "0x186A7B260", Slot = "21")]
	public LJGMMAECGKC KOGOFEOIPJO(string LBPGELHODJP, bool JPLJHPMPJLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B760", Offset = "0x6A7A360", VA = "0x186A7B760", Slot = "22")]
	public GGJEMLCHIKF OJAOPMMBBLO(string BAFGJOMINAM, bool JPLJHPMPJLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7ACA0", Offset = "0x6A798A0", VA = "0x186A7ACA0", Slot = "23")]
	public Task HALFADNJGAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AB20", Offset = "0x6A79720", VA = "0x186A7AB20")]
	private static void GHJLMHOMNBI(TaskCompletionSource<bool> IJDPKOGCIHP, Task AMHNJJMJJOA, Task MNANJDAALKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AE90", Offset = "0x6A79A90", VA = "0x186A7AE90")]
	[AsyncStateMachine(typeof(NLEHJHMLOEH))]
	private static void JCFLJIFMLGC(Task NEEKHCPCAAC, TaskCompletionSource<bool> IJDPKOGCIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x8F0CD0", Offset = "0x8EF8D0", VA = "0x1808F0CD0")]
	[CompilerGenerated]
	private void CJGKPBFAHOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x8F1850", Offset = "0x8F0450", VA = "0x1808F1850")]
	[CompilerGenerated]
	private void AHOOGFAAMLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x8F0750", Offset = "0x8EF350", VA = "0x1808F0750")]
	[CompilerGenerated]
	private void JBGBLMOODFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6A7ADB0", Offset = "0x6A799B0", VA = "0x186A7ADB0")]
	[CompilerGenerated]
	private void HKAOAHCPIPD(IDDGACAAPOM LNOMDCGJNHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class CMHOIFFGHLC : GGJEMLCHIKF, FBMJLDCPMCD
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void PNGIMOJACIP(IDDGACAAPOM JECBNPICBHO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly PNGIMOJACIP DKGBAABHGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly FBKGNILCAAC JCBKDIBADEC;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string JLMNBDOKGCF
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1F672F0", Offset = "0x1F65EF0", VA = "0x181F672F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5DA1C20", Offset = "0x5DA0820", VA = "0x185DA1C20")]
	public CMHOIFFGHLC(FBKGNILCAAC HLHOBJEODLD, [Optional] PNGIMOJACIP DABBADCNDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2C05A70", Offset = "0x2C04670", VA = "0x182C05A70", Slot = "5")]
	public T IBIJBNAFKLE<T>(string NONKDEOLPHL, T IEDAFAANJNE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface JBLJBLNOAIH
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[UsedImplicitly]
public class BIIEADOCCGH : JBLJBLNOAIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly LKNFHGIGDLM KDBALCAKPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly List<PDBBJOHJEMC> CPKHLEJOGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly string EGPFNHPMBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly string LDPGNAMECOK;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6A71C20", Offset = "0x6A70820", VA = "0x186A71C20")]
	[UsedImplicitly]
	[BOLBLOCFHKO.ENGLBNKHCKK.CLDNNCAHIAO]
	internal static void JDLGENCKOOG(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6A71C90", Offset = "0x6A70890", VA = "0x186A71C90")]
	[RecRoom.NoEngine.Common.Preserve]
	internal BIIEADOCCGH([NotNull][JGAMIMHCGFI(null)] LKNFHGIGDLM KDBALCAKPLG, [JGAMIMHCGFI(null)][NotNull] LDMPDONNICC GECNCKPFDAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class FMBKLCMEMBI : OAJBCHCNOFD
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task MEDKIGNPOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6A74EB0", Offset = "0x6A73AB0", VA = "0x186A74EB0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool NDPLONHPPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool JFFMAHOMLKB
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string CEOLPEGNJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GHMMAPHABKF JEKNJLELLPG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action IGKAEKFKJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6A746A0", Offset = "0x6A732A0", VA = "0x186A746A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6A749A0", Offset = "0x6A735A0", VA = "0x186A749A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action GADDLCHLDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6A74870", Offset = "0x6A73470", VA = "0x186A74870", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6A74D60", Offset = "0x6A73960", VA = "0x186A74D60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action OOPHEPGJJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6A74CC0", Offset = "0x6A738C0", VA = "0x186A74CC0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6A747D0", Offset = "0x6A733D0", VA = "0x186A747D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<IDDGACAAPOM> HLEFNBHPODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6A74E00", Offset = "0x6A73A00", VA = "0x186A74E00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6A74B60", Offset = "0x6A73760", VA = "0x186A74B60", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FMBKLCMEMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6A74AD0", Offset = "0x6A736D0", VA = "0x186A74AD0", Slot = "12")]
	public Task KMAKNPIEEHP(string CKEKLKPICBH, [Optional] DPOPPFDIPPD KCEHGHMENBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6A74740", Offset = "0x6A73340", VA = "0x186A74740", Slot = "18")]
	public Task DLLCMDNALGC(DPOPPFDIPPD KCEHGHMENBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6A74A40", Offset = "0x6A73640", VA = "0x186A74A40", Slot = "19")]
	public Task JJCFCPAHAKJ(DPOPPFDIPPD KCEHGHMENBC, Dictionary<string, string> NDAPJLNCOBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "20")]
	public bool FFMCKNNDAKO(string IHBFBCLCMIN, bool JPLJHPMPJLL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6A74C10", Offset = "0x6A73810", VA = "0x186A74C10", Slot = "21")]
	public LJGMMAECGKC KOGOFEOIPJO(string LBPGELHODJP, bool JPLJHPMPJLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6A74F40", Offset = "0x6A73B40", VA = "0x186A74F40", Slot = "22")]
	public GGJEMLCHIKF OJAOPMMBBLO(string BAFGJOMINAM, bool JPLJHPMPJLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6A74910", Offset = "0x6A73510", VA = "0x186A74910", Slot = "23")]
	public Task HALFADNJGAB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal class CCKCBLJOOEG : GHMMAPHABKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly KEAOJFKOFFF FNICHILADCF;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IReadOnlyDictionary<string, object> LPGAMGDNPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x1427C10", Offset = "0x1426810", VA = "0x181427C10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	public CCKCBLJOOEG(KEAOJFKOFFF JPEPMMGAKHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EMHFLOCNNAG
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "0")]
	POPJGDNFMLO CNECPLMPJBE(string AFIPLPBKMEG);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface ILCELNBOEME
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum LFAFJKLFCKO
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	long DOJFDFIJJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string POKPKPELBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string PCHOELKOJKP
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool JPHDFPHBAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long EIDHEDGPFBG();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHNDOLJHJHB(long KOOCAHLAKIM, bool BJABEGJOPKC = true);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BBEICJFEJHO(string PDMONEGPHPK, string LKKJMCPGGJH, string LODALMOMCCJ);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FFNADCHBIJL(string PDMONEGPHPK);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KLBDNOCEJEK(string PDMONEGPHPK, string PAELEIOGJEO, string EMEKFKPCGGI);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GKJJAMGHICH(string CMFAFEIOEHB, object DHDJABIPJKC, object IIHHLABIPLF);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KMPHCFDGJHH(LFAFJKLFCKO FHDNKBMGDKF, int IFODNKOJDJK, [Optional] DMHOMPGIOPJ DLEKODPPHKM, [Optional] string DAJBGEMDIGD, [Optional] string IHNODDPNJFM);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EKHOBPEHNEN(DMHOMPGIOPJ DLEKODPPHKM, long ODGAOOPJGNN, long LCCLGEIJJIF, int EJPONFCLOBL, string DAJBGEMDIGD, int IFODNKOJDJK);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IKIMFPPNFOJ(DMHOMPGIOPJ DLEKODPPHKM, bool GBICIGILFBJ, [Optional] string IHNODDPNJFM);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AMKAHHOIAOO(DMHOMPGIOPJ DLEKODPPHKM, bool GBICIGILFBJ, [Optional] string IHNODDPNJFM);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ENNDMLCKMKP(DMHOMPGIOPJ DLEKODPPHKM, bool GBICIGILFBJ, [Optional] string IHNODDPNJFM);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BGDEKALFIFK(long GLOFJPFEAOO, string PAMJIHDMILD);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface MLPDFAPNJBH
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string LOMMLNCCNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
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
