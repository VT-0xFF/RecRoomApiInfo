using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Google.Protobuf;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.SceneManagement;
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80C2030", Offset = "0x80C0A30", VA = "0x1880C2030")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
		public NullableAttribute(byte[] P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80BF6F0", Offset = "0x80BE0F0", VA = "0x1880BF6F0", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80C97E0", Offset = "0x80C81E0", VA = "0x1880C97E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NNGGDGPEILL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x80C1E80", Offset = "0x80C0880", VA = "0x1880C1E80")]
	public NNGGDGPEILL(string FLPDJFEEMLN, Exception JELEKGKHKBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class MCLNKJLOFDP : KCNOFBNCEDC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CKLLENHJKEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<AOPJKBPEOJP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TaskAwaiter<PJMLNGBAELO<PENJFAOFOEP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80AE4B0", Offset = "0x80ACEB0", VA = "0x1880AE4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80AE6F0", Offset = "0x80AD0F0", VA = "0x1880AE6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AEJNPHIKCPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<AHDHLMDPMHH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<AHDHLMDPMHH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x80A9CC0", Offset = "0x80A86C0", VA = "0x1880A9CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x80A9ED0", Offset = "0x80A88D0", VA = "0x1880A9ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	[UnityEngine.Scripting.Preserve]
	public MCLNKJLOFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x80BFFA0", Offset = "0x80BE9A0", VA = "0x1880BFFA0", Slot = "4")]
	[AsyncStateMachine(typeof(CKLLENHJKEB))]
	public Task<IReadOnlyList<AOPJKBPEOJP>> ICKLGGNDMNJ(long ELGKGFHIPBE, long CPBHLEIJEHC, [Optional] CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x80C00C0", Offset = "0x80BEAC0", VA = "0x1880C00C0", Slot = "5")]
	[AsyncStateMachine(typeof(AEJNPHIKCPN))]
	public Task<IReadOnlyList<AHDHLMDPMHH>> PENEJOIPBEE(IReadOnlyList<int> OPKKPGHFBMA, [Optional] CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FLLKGGNHMMJ : IEquatable<FLLKGGNHMMJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int EPPEMAHDBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	AHDHLMDPMHH DHLELIOOCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime BDJLONKCFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	HFOGFPEGOAK? NEHDLBAHPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DHHKCDDKMAH? JCFNNCKHMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	LJMMIKDPNJO LNCDNAFHOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NEGCEOCAIKD> NDEPCPONFPA();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum LJMMIKDPNJO
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KCNOFBNCEDC
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<AOPJKBPEOJP>> ICKLGGNDMNJ(long ELGKGFHIPBE, long CPBHLEIJEHC, [Optional] CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<AHDHLMDPMHH>> PENEJOIPBEE(IReadOnlyList<int> OPKKPGHFBMA, [Optional] CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FAEJBOIGOOJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class DDCILNDLBCP : FLLKGGNHMMJ, IEquatable<FLLKGGNHMMJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct GCBOGFDBPAL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<NEGCEOCAIKD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public DDCILNDLBCP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private CNLOBPONJDO <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<AKGPNEALNMD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<NEGCEOCAIKD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x80B2080", Offset = "0x80B0A80", VA = "0x1880B2080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x80B2600", Offset = "0x80B1000", VA = "0x1880B2600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly AOPJKBPEOJP LBBHOMNMNMF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int EPPEMAHDBFA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9B5570", Offset = "0x9B3F70", VA = "0x1809B5570", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AHDHLMDPMHH DHLELIOOCGL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime IJCANBBIKLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x80AF570", Offset = "0x80ADF70", VA = "0x1880AF570", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HFOGFPEGOAK? NEHDLBAHPLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x69C4BE0", Offset = "0x69C35E0", VA = "0x1869C4BE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public DHHKCDDKMAH? JCFNNCKHMHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x28CBBD0", Offset = "0x28CA5D0", VA = "0x1828CBBD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LJMMIKDPNJO LNCDNAFHOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB5E180", Offset = "0xB5CB80", VA = "0x180B5E180", Slot = "10")]
			get
			{
				return default(LJMMIKDPNJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x80AF590", Offset = "0x80ADF90", VA = "0x1880AF590", Slot = "9")]
		[AsyncStateMachine(typeof(GCBOGFDBPAL))]
		public Task<NEGCEOCAIKD> NDEPCPONFPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x80AF690", Offset = "0x80AE090", VA = "0x1880AF690")]
		public DDCILNDLBCP(int PFLFMMBNNHG, AHDHLMDPMHH MAOIABCONOB, AOPJKBPEOJP LBBHOMNMNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x80AF380", Offset = "0x80ADD80", VA = "0x1880AF380", Slot = "11")]
		public bool Equals(FLLKGGNHMMJ OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80AF410", Offset = "0x80ADE10", VA = "0x1880AF410", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x80AF530", Offset = "0x80ADF30", VA = "0x1880AF530")]
		private bool HLEMHKOEMAH(DDCILNDLBCP OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80AF4B0", Offset = "0x80ADEB0", VA = "0x1880AF4B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class NMAMPKINDDD : FLLKGGNHMMJ, IEquatable<FLLKGGNHMMJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct CJIKJPFGLDJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<NEGCEOCAIKD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public NMAMPKINDDD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<NEGCEOCAIKD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x80ACDB0", Offset = "0x80AB7B0", VA = "0x1880ACDB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x80AD000", Offset = "0x80ABA00", VA = "0x1880AD000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly IMLDBGJKKIJ IGDMJDDJMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HFOGFPEGOAK INGBLJFLLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly DHHKCDDKMAH OGKPBAKCFLH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int EPPEMAHDBFA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x80C1AC0", Offset = "0x80C04C0", VA = "0x1880C1AC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AHDHLMDPMHH DHLELIOOCGL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x80C16C0", Offset = "0x80C00C0", VA = "0x1880C16C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime IJCANBBIKLG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x80C1980", Offset = "0x80C0380", VA = "0x1880C1980", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HFOGFPEGOAK? NEHDLBAHPLM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x80C1B00", Offset = "0x80C0500", VA = "0x1880C1B00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DHHKCDDKMAH? JCFNNCKHMHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x80C1670", Offset = "0x80C0070", VA = "0x1880C1670", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public LJMMIKDPNJO LNCDNAFHOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB540D0", Offset = "0xB52AD0", VA = "0x180B540D0", Slot = "10")]
			get
			{
				return default(LJMMIKDPNJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1D774C0", Offset = "0x1D75EC0", VA = "0x181D774C0")]
		public NMAMPKINDDD(IMLDBGJKKIJ GIHJJKKBLCB, HFOGFPEGOAK AFOFKKIDELC, DHHKCDDKMAH ENGACNDPGHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80C19D0", Offset = "0x80C03D0", VA = "0x1880C19D0", Slot = "9")]
		[AsyncStateMachine(typeof(CJIKJPFGLDJ))]
		public Task<NEGCEOCAIKD> NDEPCPONFPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x80C1800", Offset = "0x80C0200", VA = "0x1880C1800", Slot = "11")]
		public bool Equals(FLLKGGNHMMJ OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80C1750", Offset = "0x80C0150", VA = "0x1880C1750", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80C1920", Offset = "0x80C0320", VA = "0x1880C1920")]
		private bool HLEMHKOEMAH(NMAMPKINDDD OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80C18A0", Offset = "0x80C02A0", VA = "0x1880C18A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class PIFOFEFOJGD : FLLKGGNHMMJ, IEquatable<FLLKGGNHMMJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct DHMNFPEBCCC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<NEGCEOCAIKD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<NEGCEOCAIKD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x80AFD10", Offset = "0x80AE710", VA = "0x1880AFD10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x80AFF70", Offset = "0x80AE970", VA = "0x1880AFF70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly AHDHLMDPMHH MEOOEJKAOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly HFOGFPEGOAK INGBLJFLLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly DHHKCDDKMAH OGKPBAKCFLH;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int EPPEMAHDBFA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x80C8130", Offset = "0x80C6B30", VA = "0x1880C8130", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public AHDHLMDPMHH DHLELIOOCGL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime IJCANBBIKLG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public HFOGFPEGOAK? NEHDLBAHPLM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x80C8150", Offset = "0x80C6B50", VA = "0x1880C8150", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DHHKCDDKMAH? JCFNNCKHMHE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x80C7DB0", Offset = "0x80C67B0", VA = "0x1880C7DB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public LJMMIKDPNJO LNCDNAFHOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "10")]
			get
			{
				return default(LJMMIKDPNJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1D774C0", Offset = "0x1D75EC0", VA = "0x181D774C0")]
		public PIFOFEFOJGD(AHDHLMDPMHH MAOIABCONOB, HFOGFPEGOAK AFOFKKIDELC, DHHKCDDKMAH ENGACNDPGHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80C8060", Offset = "0x80C6A60", VA = "0x1880C8060", Slot = "9")]
		[AsyncStateMachine(typeof(DHMNFPEBCCC))]
		public Task<NEGCEOCAIKD> NDEPCPONFPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x80C7E80", Offset = "0x80C6880", VA = "0x1880C7E80", Slot = "11")]
		public bool Equals(FLLKGGNHMMJ OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x80C7E00", Offset = "0x80C6800", VA = "0x1880C7E00", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x80C7EF0", Offset = "0x80C68F0", VA = "0x1880C7EF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x80C7F80", Offset = "0x80C6980", VA = "0x1880C7F80")]
		private bool HLEMHKOEMAH(PIFOFEFOJGD OLKLGHOAKNE)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct OILGCMALABJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<FLLKGGNHMMJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public FAEJBOIGOOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<AOPJKBPEOJP> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<AOPJKBPEOJP>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, AHDHLMDPMHH account, AOPJKBPEOJP roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x80C6C40", Offset = "0x80C5640", VA = "0x1880C6C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x80C7A70", Offset = "0x80C6470", VA = "0x1880C7A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct HPDAJKHCGCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, AHDHLMDPMHH account, AOPJKBPEOJP roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<AOPJKBPEOJP> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public FAEJBOIGOOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<AHDHLMDPMHH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x80B5B00", Offset = "0x80B4500", VA = "0x1880B5B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x80B64D0", Offset = "0x80B4ED0", VA = "0x1880B64D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly PFDHHEOCECN AEJAIMBCFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KCNOFBNCEDC HFHOFJPMMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly OGAIKAOHFKG LNPHMBMLAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly AKJHEKJEJOA<(long, long), IReadOnlyList<AOPJKBPEOJP>> IGJFBGGLLKJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x80B13F0", Offset = "0x80AFDF0", VA = "0x1880B13F0")]
	[UnityEngine.Scripting.Preserve]
	public FAEJBOIGOOJ([GJJKIKPKKBJ(null)] KCNOFBNCEDC MPKJICKMIIN, [GJJKIKPKKBJ(null)] OGAIKAOHFKG NIDNODNCJIG, [GJJKIKPKKBJ(null)] PFDHHEOCECN GAMIHHKBLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80B12A0", Offset = "0x80AFCA0", VA = "0x1880B12A0")]
	[AsyncStateMachine(typeof(OILGCMALABJ))]
	public Task<IList<FLLKGGNHMMJ>> MLECLCCHMEJ(long ELGKGFHIPBE, long OAJKHGNBEDJ, bool BGIIJLJEDHP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80B1100", Offset = "0x80AFB00", VA = "0x1880B1100")]
	private bool EFEAFONFFMA(DateTime? ONPLHKCADAD, long ELGKGFHIPBE, long OAJKHGNBEDJ, [Out] IMLDBGJKKIJ OOOILNKOICJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80B0FF0", Offset = "0x80AF9F0", VA = "0x1880B0FF0")]
	[AsyncStateMachine(typeof(HPDAJKHCGCC))]
	private Task<IReadOnlyList<(int, AHDHLMDPMHH, AOPJKBPEOJP)>> CHPJNICJNHI(IReadOnlyList<AOPJKBPEOJP> HOKDLEODEPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OGAIKAOHFKG
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<IMLDBGJKKIJ> EEGMEHJANHI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IIDADOJDLOF(long ELGKGFHIPBE, long OAJKHGNBEDJ, GEEPHNBMNNK AJJOFFLOELF, CGNALMMEIDH NIFJJAHBNLC);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LFHOKMLNHDJ(long ELGKGFHIPBE, long OAJKHGNBEDJ, [Out] IMLDBGJKKIJ OOOILNKOICJ);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OLFNBJBKHCG(long ELGKGFHIPBE, long OAJKHGNBEDJ, CGNALMMEIDH NIFJJAHBNLC, [Out] IMLDBGJKKIJ OOOILNKOICJ);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PACEBCOOJIF(long ELGKGFHIPBE, long OAJKHGNBEDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface MPPOGMBIPDB : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IMJCMPDFLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task PEPEEIAFDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MHJDNGDBFDL(Task GLCABFFLNII, string ANPEHIIPGHO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface FHKNJJPAONB : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NEGCEOCAIKD> IKLLMAGPMIG(IMLDBGJKKIJ OOOILNKOICJ);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KAKOIGPBINN(CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface LGJGOBGLPCF : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	ANKDDIPDILL KIDCBFGDFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIFOFFHBDJK();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MELAHFDDJMB();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface HNKIOMKDACP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface PPLNHPJCIPO
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan DJIILHDMOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan DMLLJLAKHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan MKHEPOBPAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan NICPMGECGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NPELLPFNIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool LDMCLPLCFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool CELLPJOOHJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int FEOLLLLLLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NLEPBNBIHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool JBPDJILNLKL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool PKHMHMDKAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum PIEIIPBDAEA
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum LEOGKKHFKEI
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct JBLHFKMHHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long BJCKGBNCPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long CPBHLEIJEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly PIEIIPBDAEA OHCGINPDMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception JMGGMGJODOC;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x80B6F10", Offset = "0x80B5910", VA = "0x1880B6F10")]
	public JBLHFKMHHBN(long BJCKGBNCPKM, long CPBHLEIJEHC, PIEIIPBDAEA OHCGINPDMEI, [CanBeNull] Exception JMGGMGJODOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x80B6EC0", Offset = "0x80B58C0", VA = "0x1880B6EC0")]
	public static JBLHFKMHHBN JAENMCONLHL(JIFMHENFAOG CCKBCCMINKA, PIEIIPBDAEA OHCGINPDMEI, [Optional] Exception JMGGMGJODOC)
	{
		return default(JBLHFKMHHBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void MDIFJECFPAC(JBLHFKMHHBN HHKJAIHFEGG);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface NEFHJNBMHHM : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LMDBLEALGBE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MDIFJECFPAC DJABEFJBOPF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MDIFJECFPAC EMJKGHDFLPH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MDIFJECFPAC DNGCLBJFALA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<LEOGKKHFKEI, bool> FHKKABCIMPB;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LMOKCHAHBBP();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JCIEHHJOKGH(JBLHFKMHHBN HHKJAIHFEGG);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IKKKGGDGDFN(JBLHFKMHHBN HHKJAIHFEGG);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OABHBKOPEGN(JBLHFKMHHBN HHKJAIHFEGG);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HEGDIHGGCMA(LEOGKKHFKEI NPBKJOPAEBM, bool FMDMJGBDOPB);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface PKPOBPKHMHL : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum Reason
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		TestCase,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		ServerDisconnect_ClientTimeout,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		ServerDisconnect_ServerTimeout,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		ServerDisconnect_ByServer,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		ServerDisconnect_ByClient,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		ServerDisconnect_Other,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		PresenceUpdate_SentToInvalidInstance,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		UnhandledExceptionDuringInitialRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		UnhandledExceptionDuringNonInitialLoad,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FallbackFailure_UnhandledException,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		FallbackFailure_NoInternetConnection,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		FallbackFailure_Timeout,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		FallbackFailure_Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		FallbackFailure_EndedInInvalidInstance,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		FallbackFailure_EndedInIncorrectInstance,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		FallbackFailure_EndedInIncorrectScene,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		FallbackFailure_AlreadyInTargetInstance,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		FallbackFailure_MatchmakingError
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool PLPBCCAKKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PAIANENMONH(Reason NBAKHABPJGI = Reason.Unknown);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACONEJDMCBD();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface OHNHALKFFPG : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus FBCNJFGOEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LJMCMHPGGIG(JIFMHENFAOG AFMDHCINNJF, BEJEKGNNGMP PONDNJALBLB, CancellationToken OJOOKCOCPDF);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class DGKFGHHMDFE
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x80AF6F0", Offset = "0x80AE0F0", VA = "0x1880AF6F0")]
	public static bool DFCLJBOJKMG(this OHNHALKFFPG DAMHMAEMIFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task JBJOGAHMAOM(CancellationToken GNAAILLDOKI, int HBOPDPPMOIM, OEADLBOEPJO HMEIOLJKGHH);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface HJNAJNAOIBC : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BPBNJLDMHKI(JBJOGAHMAOM BJKLOELCDIC);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface HLJANHOBGDO : CNLOBPONJDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken KJJDAOGADFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	LKOLOODKMPF PIOEPEIOALH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MFOOBEAIMGO DGCCEFDKJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	JPHHEIGPJJM PJNIJAKNFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	POHGOIGKOME MNIGFADEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	MKPAKKHKDCO IOCJGOPKDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	CJGBCFNIGFE BCAMDPJELMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	OKAHAIKEOBG CNJGLAPNNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	MGIEBANOHLI KGLGCMPNEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	MPPOGMBIPDB DOICAGFDPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	FHKNJJPAONB FHADNEOAPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NEFHJNBMHHM DNKCJGPFNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	PKPOBPKHMHL KJFODBIIPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	OHNHALKFFPG PCBFIBAOGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	HJNAJNAOIBC BHOKBFAJLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CGNEECPBPBC MLGAIKFPPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	JPGBMGNCJFF FNEIIELLPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DPAMGLAJFKB EOJDECALKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	CCKGDCAJAJC JGPPLPHLHAI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	FHIJNBOPDFL KODKHPAOEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ADCJFBBIPFA BOLNDNNMOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	MKLJNDDOMLB HCDPAGDGILI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	FLECLOLLKJG NKMKJJOKLCB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	DNNNDKKKGJO OOCGFLIGLCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	BOEFIADFECB MLADABECJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	LGJGOBGLPCF DAEFKKLGMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	PPLNHPJCIPO LEDNJNCCDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	BPAFCFABALO CKOFIPMPPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	OGAIKAOHFKG GIFEKLAOGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	HMJOFPFMBKI NKKKAGFJBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	HCPGKPPOEKF FDMJPHFAAGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	KNMHECKNPBE PLFJGAIDNKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	LABMLFFGKHA NODCJEIPHNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool PLLGBOFPGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void ODNDPMMLCPL(BEJEKGNNGMP MMOIEANONBL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface CGNEECPBPBC : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PAPDCOBPBIP HEHCILJMFIP(Guid HPBDKIENPJP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CBCJJMKDJJC(Guid HPBDKIENPJP);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ICOPLBMPMDH(Guid HPBDKIENPJP, Task AMMGCNPDJMI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OKLPGEBADIH(Guid HPBDKIENPJP, NEGCEOCAIKD MNCKIGLHEIM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(NEGCEOCAIKD, Task)> MJOOCDCBLAG(Guid HPBDKIENPJP);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface NAMEGMCIFFD : HNKIOMKDACP, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface JPGBMGNCJFF : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHPDJJDBHLK(GGFPIKADCDI FLPDJFEEMLN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMIHKBNCHCK(GGFPIKADCDI FLPDJFEEMLN);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<BJBMIMDMIDH> GEOIIGOOLMN(CancellationToken LBPNPDGAHFH);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface DPAMGLAJFKB : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PAPDCOBPBIP PCKJJMHEGBN(GGFPIKADCDI KGKMMIMKBFB);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IOMKDBKNFFJ(Guid HPBDKIENPJP, Task AMMGCNPDJMI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface CCKGDCAJAJC : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NEGCEOCAIKD> JGPPLPHLHAI(GGFPIKADCDI MDBNAHHGCNO);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface FHIJNBOPDFL : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LGCLIBGOJHL> JIBAGIKOPDE(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, JIFMHENFAOG AFMDHCINNJF, CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface MKLJNDDOMLB : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NEGCEOCAIKD GHLLDDNMCIH(BKBJMNKBOED DNIJCDKNNHH);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AFEGBIDHKEL(string LMJJJIGEFFK);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface ADCJFBBIPFA : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GGFPIKADCDI> ADKLMNIIFOF(GGFPIKADCDI EELGNOJLLOB, ONJGKIHMNBI EEAGJEEABFN, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GGFPIKADCDI> PGLNHEOAGGM(CancellationToken BJEPDCCBCHJ, ONJGKIHMNBI EEAGJEEABFN);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EDFKMNECCFB COJGOIJDDDN(EDDPLOEGLIE LPECPFJMBIM, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EDFKMNECCFB KPJMNCPDNDJ(EDDPLOEGLIE LPECPFJMBIM, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface FLECLOLLKJG : HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NEGCEOCAIKD NKEOIFMLJEI(BKBJMNKBOED DNIJCDKNNHH, BJBMIMDMIDH LIJCMODMOKD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NEGCEOCAIKD NNIKLEGNDPO(BKBJMNKBOED LEJLBFMKAOE);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface LAGFPPGANGH
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	const int MEBNCDACKDF = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, HGBFKIJBDGB> BKPIJOGLKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action MFFGFFFBBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<Guid> DEHPBONBHGK();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task CLFAOPFOCCM([Optional] CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ADLKMIBLDON([Optional] CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface DNNNDKKKGJO
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPGANKLLNFI(LNJEGFLCGIN KNGHMABGLIH);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEEAJAJDLHB(LNJEGFLCGIN KNGHMABGLIH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELPCFALLDFL(LNJEGFLCGIN KNGHMABGLIH);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ECNHDFIOINC(LNJEGFLCGIN KNGHMABGLIH);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class LNJEGFLCGIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly JIFMHENFAOG EDCGCDGGPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Dictionary<string, string> GBBAKAJEGGE;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NCPOPMIDADO<string> MPKJFKIOBMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9B0460", Offset = "0x9AEE60", VA = "0x1809B0460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	public LNJEGFLCGIN(JIFMHENFAOG HCMHGCJCEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x80BF620", Offset = "0x80BE020", VA = "0x1880BF620")]
	public LNJEGFLCGIN KNNKONPDCCC(string NJBPFCDJFGD, string PPJFMHBDGNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x80BF590", Offset = "0x80BDF90", VA = "0x1880BF590")]
	public bool FBMFLPNCCBC([Out] IEnumerable<KeyValuePair<string, string>> PDBMFEOPCIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6B80", Offset = "0x6FE5580", VA = "0x186FE6B80")]
	public LNJEGFLCGIN GBMPFJIPJCB(NCPOPMIDADO<string> NDBGCDOMBIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface BPAFCFABALO
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool PMGOHAPMPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string IPBBLKNGFLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool JBNAGMGDDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AILBKHIDICH();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PDLPNAGCOEN KLFPGPIEJEO(long LNNIIMLBGJI);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DKFLGAJFHGM<LPGDPINKOBL, DHBLGJCGMLF> IKPPNHDKOFE(long LNNIIMLBGJI);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DKFLGAJFHGM<LPGDPINKOBL, ENCFJAGIPBN> JBHANMABGJN(long LNNIIMLBGJI);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DKFLGAJFHGM<long, JJNBLNEHGHE> EMJFPOMAKNE();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<NJKFFLPCAGK>> KAMPKJMJAHD(long LNNIIMLBGJI, IReadOnlyCollection<NJKFFLPCAGK> LNFHOHLCEOG, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DOHCOKCEAIK(long LNNIIMLBGJI, [Out] bool GGFELADDBHD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> CCMJMJEJCCD(byte[] AHNEEBNBDDH, byte[] AIIHIIHBDBC, IReadOnlyCollection<Guid> HLBBLKPCDPE, CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface ENACNLJLDID
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LGCLIBGOJHL IDEDHGEBOCJ(long BJCKGBNCPKM, long CPBHLEIJEHC, string HHFGONMNNMN);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LGCLIBGOJHL IDEDHGEBOCJ(long BJCKGBNCPKM, long CPBHLEIJEHC, LPGDPINKOBL AHNEEBNBDDH, Guid? IMGGCBCHJLN, long LGCPADGPCDG, bool HFAGHFGFAIN);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LGCLIBGOJHL IDEDHGEBOCJ(CMOIIBJLNAK KNPLKFMHAEG);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LGCLIBGOJHL IDEDHGEBOCJ(AKGPNEALNMD DMFEPJLKGFM, AOPJKBPEOJP PLHFMBKMCKL);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface CNLOBPONJDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool DFCLJBOJKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool PKLNMFPOKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool PLLGBOFPGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	ENACNLJLDID KCJGAGJICLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	BEJEKGNNGMP AKLAAHNCPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action LMDBLEALGBE;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MDIFJECFPAC DJABEFJBOPF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event MDIFJECFPAC EMJKGHDFLPH;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MDIFJECFPAC DNGCLBJFALA;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<LEOGKKHFKEI, bool> FHKKABCIMPB;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ACONEJDMCBD();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FKNPNNBPBDL JLCHIKANIGI();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ICBHCGIKMFO KMHPCHOFFGA();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task PCHEBDGPDKE(int NMBPNPFDHMI, EHGOBHHINHI OHONJEDJEFK, Func<GEEPHNBMNNK, GEEPHNBMNNK> EBHABDCMJLP);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<NEGCEOCAIKD> IKLLMAGPMIG(IMLDBGJKKIJ GIHJJKKBLCB);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task KAKOIGPBINN(CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface MKPAKKHKDCO
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool FLENNEHCHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool HIMFDAKEFEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? DDIOPDDKGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOFLOHDJDAE(Scene NBPKLLIILAA);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task KOJKBDMNDKP(KFPPJEPPJOI KKPENLAKGAB, IReadOnlyList<KFPPJEPPJOI> LMAFFMILOJG, IReadOnlyList<KFPPJEPPJOI> HGMIBJLCBOD, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GIKHAFHDIIC(BLAKPJCNLNI BPJKACIIJGE);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task GFHIGJIECLM(IReadOnlyList<Guid> FGKFBPEDOEB, CancellationToken FMPFALKDFBE);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DLBHPPFHEAE NEJDPGMKBHK();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task KGMCEEBBPHG();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task LFLOHPFHOMK();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface POHGOIGKOME
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	FGCPAINBMOO ELGBICGFGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool AFJFEIBGLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool JJKHEBLEPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool KPBKGDLPBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool OBDBMNDGNCL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int PBGIIBJGKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool PJCCLFCIFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool HPIKNDNGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int KELAHOBGMNF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int MEBHDOPDABH
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool NLAFMPIKOCA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool FEGEOHDLBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool KHBECGENIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float DKNBKIHPLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> MMPNEDBLGPB;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LKOLOODKMPF JJEKLGBLGKL(LKOLOODKMPF BMNODBGPMBL);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGIOIAAKNJC(LKOLOODKMPF MCJDMILNGAL);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ONCOLLPHNME();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task FCOALMPNHAH(NCPOPMIDADO<string>.CFILPBLEJMI ANFHHCLGDOE, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KMPPGHGCFKK(float IHNAEJKGEHJ);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JJHOOJFMOEM(string ICBJABOHKGL);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<PCCGNKCANDF> BINADNAGMNP();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable HIFBLILNOPE(object OJFCDDMGKNP, PCCGNKCANDF MLBJPJMCPKK);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<FLGMHHMFMNN> KCAKIGBLBFE();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DHBLGJCGMLF HEJNHKIJBBH(IEnumerable<FDOLPBGFEHG> EJEPCBHACLO);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PHHBKOMPEIL(int ICDLGGKHDLD);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task APJIGNFEMBB();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EEHCAGOFKEG();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool CBENNKGBGKK();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task GJMKBNAOKNF(CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task GGDEHMOKLJN(CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<OKOHDNPDHIM> PJIILAHMGGP(DateTime MCPPEDOIOFF, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> JLBJLKJOFEK(CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DEHDEPNCEOG(string FLPDJFEEMLN = "", float JHEFBFGKIFH = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "25")]
	IKINPFMHFBL KACAKMPHCCM(INJGBGPMOFG EGGFOEFMNBE, AOMKAOANABA NDEHFBMOBNH, ENCFJAGIPBN MJFCGLDACCB, IEnumerable<PersistenceView> HNLOHEOICHJ, AILMNHDJJMA LMAHMGHMBLP);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PIBFGCHJGGO(ENCFJAGIPBN MJFCGLDACCB);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ELPMGINGGCG(FDOLPBGFEHG JDJGOBEPLEN, [In] IKINPFMHFBL KFECFKBDBNK);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task LCGFABCMAKO(ENCFJAGIPBN JPMBHBMLCDB, bool HGAADAOEOLM, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task EOPKIMGDODH(CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void EABHMKNAJLP(long ELGKGFHIPBE, long CPBHLEIJEHC, AKGPNEALNMD ANFMILMMEOM, AOPJKBPEOJP FHGLPGAIAGE, GEEPHNBMNNK AJJOFFLOELF, EHGOBHHINHI? OHONJEDJEFK, NGFHAFELNHF? MMBONDGCHCE);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void EEKKLMBIPAG(long ELGKGFHIPBE, long CPBHLEIJEHC, NGFHAFELNHF? MMBONDGCHCE);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void INGGDHKILGC(PersistenceView JLMGJJJJGAL);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void HIBCBKJMPKC(string KNOHJKLJEJA, JIFMHENFAOG HCMHGCJCEGJ, FMHJIJNHDAA AOGDCMCHFEI, [Optional] string? DLPFCBJGMCL, [Optional] string? LNDEGIIPHKH, [Optional] string? EOEEJLANIAA);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool ONLJFBHJJDA(PersistenceView NOHDMGIIOFL);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool ELANMDKMIEA(FDOLPBGFEHG JDJGOBEPLEN, JEFPFBDEHJG HHEKGCCCGFJ, [Out] LBEGLJPHNML JCOKKDGNKDP);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task OLNOOCJDGMC(CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void AIEHKHCFOAI();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable KIIAKHJEBDD();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void KPIOENNAIBA(ENCFJAGIPBN JPMBHBMLCDB, JEFPFBDEHJG HHEKGCCCGFJ);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> KLNLHBCNDME(MFOOBEAIMGO HFDCCFJAOJK, CancellationToken BJEPDCCBCHJ, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void BOPOHAMFKBI(CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<CMOIIBJLNAK> EPABHAMABOC(MGJNHNLMEFF EELGNOJLLOB);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<AKGPNEALNMD> FIDNBJNICKE(long ELGKGFHIPBE, bool IJCPNFJCJAL, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<PENJFAOFOEP> OOOOOIMHDBK(long ELGKGFHIPBE, long CPBHLEIJEHC, long LGCPADGPCDG, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<PENJFAOFOEP> LFEKFPJJBIJ(long ELGKGFHIPBE, long CPBHLEIJEHC, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<FLOHMIGBGEM> FFKIMBFDMMD(long ELGKGFHIPBE, Guid MKLPGJLHPPJ, long? OAJKHGNBEDJ, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "47")]
	DKFLGAJFHGM<FLOHMIGBGEM, IEnumerable<PCCDMEPDNKJ>> HPPDIEPNGCC();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<HMCACHPGJHK> ECHAJMJEGCF(string HHFGONMNNMN, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<HMCACHPGJHK> IHJPOHNICPG(string HHFGONMNNMN, long ELGKGFHIPBE, long CPBHLEIJEHC, Guid? MMHKLEMPBFN, FCIJIHDEEOL.LDJGKMGNPIB COLBDAEGKBA, FCIJIHDEEOL.LDJGKMGNPIB AIIHIIHBDBC, int NMBPNPFDHMI);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool JALHLCIIGCB();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool OBNKPBGMPDH();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool KLIEELBHHKD(IEnumerable<LBEGLJPHNML> EOEBPGIHDCI);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void EPIBBHEGNMA(List<GameObject> OFNALIJFEAB);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float ICPEGBNNGJF();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> EMNOJAADCEO(CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> MBBJCNIJJME(string PABGPJFICHJ, LoadSceneMode FAMHBBNGCIG, bool DLGJGHOGGKG, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void PDCIGMOLIDC();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void DFAHKJOBABJ(bool PLGFLNLCLML);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void GPDMJGIBNPK();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void KALDPNLHECG();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void JCLHCDKMNOD(bool PIFJJIGKCPD);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task<FCIJIHDEEOL.LDJGKMGNPIB> MEDHKCNFBKB(byte[] DFPGGEDGGGN, FCIJIHDEEOL.NIDCDDOFJAB AKFKCFJEMAG, KDGAEJJENKP MBIFBLGBHJK, [Optional] IReadOnlyCollection<string>? HAEKCJCLGOD, [Optional] string? HLAOAJBOIOO);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void ICDDBEIMHDP(JIFMHENFAOG NCOPEKOHGLP);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task LPACPMFFLDE(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task OLIKKMPLJCF(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task FKACAHPKBIG(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "77")]
	Task FOHIJJOGAEK(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "78")]
	IDisposable NLLHHMCALJI();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "79")]
	BDOBAMPGLAP EANNKJPGJBK();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "80")]
	Task PIBAJOBAIPP(CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface BDOBAMPGLAP
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LAAOAHJMKHI(CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JHJGBMBDODD(CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct IKINPFMHFBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HashSet<int> CDLBACMECAI;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum OKOHDNPDHIM : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct INJGBGPMOFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Guid? JAJGNJPKMCI;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface FGCPAINBMOO
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	JIFMHENFAOG APAKLDLHHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	AKGPNEALNMD CHGNCAALJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	HPIALGGGMCA PMMKKLBFGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool GOBPIDLMDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool HIDPCDPDLBB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int INKFEAODPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action OJCDCBGKLFN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> IOCMIFBKJBI;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HFADJBEJJLL();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.EEJAHADMACG> ECOCGINFAND(long LNNIIMLBGJI, [Optional] CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<OJIDIPAFKDJ> LPPNOBHMCOA(JIFMHENFAOG HCMHGCJCEGJ, [Optional] BEJEKGNNGMP PONDNJALBLB);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<OJIDIPAFKDJ> DAGDIMGFKDK();

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task AHHLNHPIDJD();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(JIFMHENFAOG, BEJEKGNNGMP) CKAPMMOHEBN();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FFMMAHICCBH LONJLMEGCBD();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KDCDCKLIJKK(long LNNIIMLBGJI);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IDLHMIIKNCN(JIFMHENFAOG HCMHGCJCEGJ, Matchmaking.CPLJJEKEANG FFBEKAFHIDB, (int Major, int? Minor)? CCAPIJPBJLK);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface BOEFIADFECB
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LHDKGMDLALB([Out] IEnumerable<int> GCEEELGHBNO);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHCLIPEICII(MDCBAMNMOAI GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHBKDDIIFFI(MDCBAMNMOAI GNAAILLDOKI);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface PJNOOHHNKLI
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EGBCCIPNKPC(NEGCEOCAIKD PGKINBLHCBM);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface DLJIKEBIKOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFMBGEPILAD(OAFJONMHING.JONKPACCOFH PMPEFPLKPPO);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNACFNOCLCH(OAFJONMHING.JONKPACCOFH PMPEFPLKPPO);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface CJGBCFNIGFE : DLJIKEBIKOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NEGCEOCAIKD IGKPGOBBNEK(BKBJMNKBOED LEJLBFMKAOE);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface OKAHAIKEOBG : DLJIKEBIKOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NEGCEOCAIKD GHLLDDNMCIH(BKBJMNKBOED DOBJHMJOLKM);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface PDLPNAGCOEN
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CEGCKGHHPPP<NHNAPHMEOFF, MJKMNFLLIGE>> HGFEBGOBKFL(Guid? MMHKLEMPBFN, IReadOnlyCollection<NJKFFLPCAGK> FLAOADMJHFG, IReadOnlyCollection<NJKFFLPCAGK> AOCJHDJAFCO, LOKOCJIOFGG EBGPACKMOLB, long? ELGKGFHIPBE, long? CPBHLEIJEHC, MHNNGEGFDJJ.FKMANLAFEPM IAFDIDINEMC, CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class NHNAPHMEOFF
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public KFPPJEPPJOI CHJMJGGOFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<KFPPJEPPJOI> KPPMIBACIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<KFPPJEPPJOI> CBHHGOGIMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xBD8D10", Offset = "0xBD7710", VA = "0x180BD8D10")]
	public NHNAPHMEOFF(KFPPJEPPJOI IHPACJNFMKM, IReadOnlyList<KFPPJEPPJOI> LGAEDMJAPIH, IReadOnlyList<KFPPJEPPJOI> IBFFJNLOGDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface DKFLGAJFHGM<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CEGCKGHHPPP<JPHMEMEGABN<TData>, MJKMNFLLIGE>> LECCDDFCGAA(TGetDataArg JDKFBOCIIAB, CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class CKAEJOLOOOO : HLJANHOBGDO, CNLOBPONJDO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct CELPGLIGAJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<NEGCEOCAIKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CKAEJOLOOOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IMLDBGJKKIJ autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<NEGCEOCAIKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x80ACAC0", Offset = "0x80AB4C0", VA = "0x1880ACAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x80ACD40", Offset = "0x80AB740", VA = "0x1880ACD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct BIJGFKNLBCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CKAEJOLOOOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x80ABA90", Offset = "0x80AA490", VA = "0x1880ABA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x80ABCC0", Offset = "0x80AA6C0", VA = "0x1880ABCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class AGFLABMJJBJ : IEnumerable<HNKIOMKDACP>, IEnumerable, IEnumerator<HNKIOMKDACP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private HNKIOMKDACP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CKAEJOLOOOO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private HNKIOMKDACP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
		[DebuggerHidden]
		public AGFLABMJJBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x80AAC10", Offset = "0x80A9610", VA = "0x1880AAC10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x80AB070", Offset = "0x80A9A70", VA = "0x1880AB070", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x80AAFC0", Offset = "0x80A99C0", VA = "0x1880AAFC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HNKIOMKDACP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x80AAFC0", Offset = "0x80A99C0", VA = "0x1880AAFC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CancellationTokenSource HJHIJCGMEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LKOLOODKMPF MCJDMILNGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool FIMHNIKAAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private JPPIOGEGOAI EDOPIEEOIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool LNLHIMHDMNE;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public MFOOBEAIMGO DGCCEFDKJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4F0", Offset = "0x9AAEF0", VA = "0x1809AC4F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4D0", Offset = "0x9AAED0", VA = "0x1809AC4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public JPHHEIGPJJM PJNIJAKNFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9AC530", Offset = "0x9AAF30", VA = "0x1809AC530", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9AC520", Offset = "0x9AAF20", VA = "0x1809AC520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public POHGOIGKOME MNIGFADEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9AC510", Offset = "0x9AAF10", VA = "0x1809AC510", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4E0", Offset = "0x9AAEE0", VA = "0x1809AC4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public MKPAKKHKDCO IOCJGOPKDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4C0", Offset = "0x9AAEC0", VA = "0x1809AC4C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4B0", Offset = "0x9AAEB0", VA = "0x1809AC4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public CJGBCFNIGFE BCAMDPJELMN
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4A0", Offset = "0x9AAEA0", VA = "0x1809AC4A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9AC500", Offset = "0x9AAF00", VA = "0x1809AC500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public OKAHAIKEOBG CNJGLAPNNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9B7BE0", Offset = "0x9B65E0", VA = "0x1809B7BE0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9B7BC0", Offset = "0x9B65C0", VA = "0x1809B7BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public ENACNLJLDID KCJGAGJICLL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B20", Offset = "0x9B6520", VA = "0x1809B7B20", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A80", Offset = "0x9B6480", VA = "0x1809B7A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public MGIEBANOHLI KGLGCMPNEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9B7BB0", Offset = "0x9B65B0", VA = "0x1809B7BB0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B80", Offset = "0x9B6580", VA = "0x1809B7B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public MPPOGMBIPDB DOICAGFDPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xB5D590", Offset = "0xB5BF90", VA = "0x180B5D590", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x121EED0", Offset = "0x121D8D0", VA = "0x18121EED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public FHKNJJPAONB FHADNEOAPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B50", Offset = "0x9B6550", VA = "0x1809B7B50", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A20", Offset = "0x9B6420", VA = "0x1809B7A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public NEFHJNBMHHM DNKCJGPFNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xC5B7C0", Offset = "0xC5A1C0", VA = "0x180C5B7C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xDC7F50", Offset = "0xDC6950", VA = "0x180DC7F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public PKPOBPKHMHL KJFODBIIPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9B1780", Offset = "0x9B0180", VA = "0x1809B1780", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9B17D0", Offset = "0x9B01D0", VA = "0x1809B17D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public OHNHALKFFPG PCBFIBAOGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xBA86E0", Offset = "0xBA70E0", VA = "0x180BA86E0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xDD5050", Offset = "0xDD3A50", VA = "0x180DD5050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public HJNAJNAOIBC BHOKBFAJLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xCB5B20", Offset = "0xCB4520", VA = "0x180CB5B20", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xCB5B30", Offset = "0xCB4530", VA = "0x180CB5B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public CGNEECPBPBC MLGAIKFPPFH
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xC5B5F0", Offset = "0xC59FF0", VA = "0x180C5B5F0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x10A68D0", Offset = "0x10A52D0", VA = "0x1810A68D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public NAMEGMCIFFD GPOBIJEHKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xC467D0", Offset = "0xC451D0", VA = "0x180C467D0", Slot = "62")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xD011A0", Offset = "0xCFFBA0", VA = "0x180D011A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public JPGBMGNCJFF FNEIIELLPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA24370", Offset = "0xA22D70", VA = "0x180A24370", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA26F40", Offset = "0xA25940", VA = "0x180A26F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public DPAMGLAJFKB EOJDECALKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9B1830", Offset = "0x9B0230", VA = "0x1809B1830", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9B1840", Offset = "0x9B0240", VA = "0x1809B1840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public CCKGDCAJAJC JGPPLPHLHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA2EDB0", Offset = "0xA2D7B0", VA = "0x180A2EDB0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA2E850", Offset = "0xA2D250", VA = "0x180A2E850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public FHIJNBOPDFL KODKHPAOEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA2B280", Offset = "0xA29C80", VA = "0x180A2B280", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA29F70", Offset = "0xA28970", VA = "0x180A29F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public ADCJFBBIPFA BOLNDNNMOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA24510", Offset = "0xA22F10", VA = "0x180A24510", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA36440", Offset = "0xA34E40", VA = "0x180A36440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public MKLJNDDOMLB HCDPAGDGILI
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA24540", Offset = "0xA22F40", VA = "0x180A24540", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA237F0", Offset = "0xA221F0", VA = "0x180A237F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public FLECLOLLKJG NKMKJJOKLCB
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA4F0B0", Offset = "0xA4DAB0", VA = "0x180A4F0B0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xB1AB10", Offset = "0xB19510", VA = "0x180B1AB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public DNNNDKKKGJO OOCGFLIGLCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA4F070", Offset = "0xA4DA70", VA = "0x180A4F070", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA35060", Offset = "0xA33A60", VA = "0x180A35060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public BOEFIADFECB MLADABECJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA4F090", Offset = "0xA4DA90", VA = "0x180A4F090", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA41EA0", Offset = "0xA408A0", VA = "0x180A41EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public LGJGOBGLPCF DAEFKKLGMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA4F080", Offset = "0xA4DA80", VA = "0x180A4F080", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA35950", Offset = "0xA34350", VA = "0x180A35950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public PPLNHPJCIPO LEDNJNCCDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA35940", Offset = "0xA34340", VA = "0x180A35940", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA34530", Offset = "0xA32F30", VA = "0x180A34530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public BPAFCFABALO CKOFIPMPPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA4DFA0", Offset = "0xA4C9A0", VA = "0x180A4DFA0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA666F0", Offset = "0xA650F0", VA = "0x180A666F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public OGAIKAOHFKG GIFEKLAOGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA3A0D0", Offset = "0xA38AD0", VA = "0x180A3A0D0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public HMJOFPFMBKI NKKKAGFJBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA3EFD0", Offset = "0xA3D9D0", VA = "0x180A3EFD0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public HCPGKPPOEKF FDMJPHFAAGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA38FF0", Offset = "0xA379F0", VA = "0x180A38FF0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public KNMHECKNPBE PLFJGAIDNKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA3AFC0", Offset = "0xA399C0", VA = "0x180A3AFC0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public LABMLFFGKHA NODCJEIPHNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD10", Offset = "0xA4C710", VA = "0x180A4DD10", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public BEJEKGNNGMP AKLAAHNCPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA42140", Offset = "0xA40B40", VA = "0x180A42140", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xED2B50", Offset = "0xED1550", VA = "0x180ED2B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool IOGEAODBKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x80ADF20", Offset = "0x80AC920", VA = "0x1880ADF20", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool NLGJMJDCFND
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x80AD070", Offset = "0x80ABA70", VA = "0x1880AD070", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool FEEBOJCPPCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1B23E70", Offset = "0x1B22870", VA = "0x181B23E70", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken GKOOHFEHLNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x80AD200", Offset = "0x80ABC00", VA = "0x1880AD200", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private LKOLOODKMPF LMAELLJPOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool FMPFHCDJCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1B23E70", Offset = "0x1B22870", VA = "0x181B23E70", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1B21400", Offset = "0x1B1FE00", VA = "0x181B21400", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action FIIHDAOEEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x80AD6F0", Offset = "0x80AC0F0", VA = "0x1880AD6F0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x80ADBB0", Offset = "0x80AC5B0", VA = "0x1880ADBB0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event MDIFJECFPAC DOMPLGKOALL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x80AD570", Offset = "0x80ABF70", VA = "0x1880AD570", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x80AD5D0", Offset = "0x80ABFD0", VA = "0x1880AD5D0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event MDIFJECFPAC HGDMPIKCOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x80AD140", Offset = "0x80ABB40", VA = "0x1880AD140", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x80AD690", Offset = "0x80AC090", VA = "0x1880AD690", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event MDIFJECFPAC FOKAFPKMCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x80AD630", Offset = "0x80AC030", VA = "0x1880AD630", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x80ADF80", Offset = "0x80AC980", VA = "0x1880ADF80", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<LEOGKKHFKEI, bool> PDJNEMMFICK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x80ADAC0", Offset = "0x80AC4C0", VA = "0x1880ADAC0", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x80AD8C0", Offset = "0x80AC2C0", VA = "0x1880AD8C0", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xED2B50", Offset = "0xED1550", VA = "0x180ED2B50", Slot = "39")]
	public void ODNDPMMLCPL(BEJEKGNNGMP MMOIEANONBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x80ADFE0", Offset = "0x80AC9E0", VA = "0x1880ADFE0")]
	[UnityEngine.Scripting.Preserve]
	internal CKAEJOLOOOO([GJJKIKPKKBJ(null)] LKOLOODKMPF MCJDMILNGAL, [GJJKIKPKKBJ(null)] MFOOBEAIMGO HFDCCFJAOJK, [GJJKIKPKKBJ(null)] JPHHEIGPJJM IAEPFCBBPHA, [GJJKIKPKKBJ(null)] POHGOIGKOME MPDODANMFLG, [GJJKIKPKKBJ(null)] MKPAKKHKDCO JPNKENOMMJC, [GJJKIKPKKBJ(null)] CJGBCFNIGFE JNBBFPHPMAB, [GJJKIKPKKBJ(null)] OKAHAIKEOBG GCJOJDBJOAE, [GJJKIKPKKBJ(null)] MGIEBANOHLI DJOAEGGPBDP, [GJJKIKPKKBJ(null)] MPPOGMBIPDB POCJIBOPFAP, [GJJKIKPKKBJ(null)] FHKNJJPAONB DMGHAFPCGFO, [GJJKIKPKKBJ(null)] NEFHJNBMHHM DMPOELGMLAH, [GJJKIKPKKBJ(null)] PKPOBPKHMHL CHFJNDNOJCL, [GJJKIKPKKBJ(null)] OHNHALKFFPG DAMHMAEMIFJ, [GJJKIKPKKBJ(null)] HJNAJNAOIBC NLHFIDPIHMB, [GJJKIKPKKBJ(null)] CGNEECPBPBC JFGGIHEHAEA, [GJJKIKPKKBJ(null)] NAMEGMCIFFD LCADNODKIFO, [GJJKIKPKKBJ(null)] JPGBMGNCJFF BANNANAFLLK, [GJJKIKPKKBJ(null)] DPAMGLAJFKB BHLAAOMLLON, [GJJKIKPKKBJ(null)] CCKGDCAJAJC PHKPKMPCLGD, [GJJKIKPKKBJ(null)] FHIJNBOPDFL CBICBFFCNIP, [GJJKIKPKKBJ(null)] MKLJNDDOMLB GNFHOCNHKPL, [GJJKIKPKKBJ(null)] ADCJFBBIPFA ELODDEKFOOP, [GJJKIKPKKBJ(null)] FLECLOLLKJG JEKHNDIDNPM, [GJJKIKPKKBJ(null)] DNNNDKKKGJO COPIDBNCBAK, [GJJKIKPKKBJ(null)] BOEFIADFECB GLCOMMBLGMF, [GJJKIKPKKBJ(null)] PPLNHPJCIPO MOAPPBPCBJG, [GJJKIKPKKBJ(null)] BPAFCFABALO PDJFELCMDPD, [GJJKIKPKKBJ(null)] OGAIKAOHFKG OOGNPFNBGIF, [GJJKIKPKKBJ(null)] HMJOFPFMBKI HONHKIBBAAE, [GJJKIKPKKBJ(null)] HCPGKPPOEKF CIGPPMMLFJO, [GJJKIKPKKBJ(null)] KNMHECKNPBE AOHCLGOMJBH, [GJJKIKPKKBJ(null)] LABMLFFGKHA LOLOBNCIBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x80AD4C0", Offset = "0x80ABEC0", VA = "0x1880AD4C0")]
	private void ELAEPFFNBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x80AD330", Offset = "0x80ABD30", VA = "0x1880AD330", Slot = "61")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x80AD0F0", Offset = "0x80ABAF0", VA = "0x1880AD0F0", Slot = "53")]
	private void AOBGOJBELLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x80ADB20", Offset = "0x80AC520", VA = "0x1880ADB20", Slot = "54")]
	private FKNPNNBPBDL NAFBNAEJJMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x80AD920", Offset = "0x80AC320", VA = "0x1880AD920", Slot = "55")]
	private ICBHCGIKMFO LEOOJBLAICC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x80ADC10", Offset = "0x80AC610", VA = "0x1880ADC10", Slot = "57")]
	public Task PCHEBDGPDKE(int NMBPNPFDHMI, EHGOBHHINHI OHONJEDJEFK, Func<GEEPHNBMNNK, GEEPHNBMNNK> EBHABDCMJLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x80AD220", Offset = "0x80ABC20", VA = "0x1880AD220")]
	private CKOBHIHMNHK DOFPLCEFCNG(int NMBPNPFDHMI, EHGOBHHINHI OHONJEDJEFK, Func<GEEPHNBMNNK, GEEPHNBMNNK> EBHABDCMJLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x80AD9B0", Offset = "0x80AC3B0", VA = "0x1880AD9B0", Slot = "58")]
	[AsyncStateMachine(typeof(CELPGLIGAJP))]
	private Task<NEGCEOCAIKD> MKHNOKIMCOA(IMLDBGJKKIJ OOOILNKOICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x80AD7D0", Offset = "0x80AC1D0", VA = "0x1880AD7D0", Slot = "59")]
	[AsyncStateMachine(typeof(BIJGFKNLBCI))]
	private Task LDHKPILPJBM(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x80AD750", Offset = "0x80AC150", VA = "0x1880AD750")]
	[IteratorStateMachine(typeof(AGFLABMJJBJ))]
	private IEnumerable<HNKIOMKDACP> KKHBKOJMGDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x80AD1A0", Offset = "0x80ABBA0", VA = "0x1880AD1A0")]
	[CompilerGenerated]
	private void CMIBNDDCMPB(HNKIOMKDACP ANAFMCCHAKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class LJEDHIKJODA : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x16D8230", Offset = "0x16D6C30", VA = "0x1816D8230")]
	public LJEDHIKJODA(string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class DDAEHNOMBHA : EPGAEOBOMJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct HGJKMAHHPMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<EPGAEOBOMJH.ACFLHOIIMOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public HashSet<PKPOBPKHMHL.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public DDAEHNOMBHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x80B5590", Offset = "0x80B3F90", VA = "0x1880B5590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x80B5890", Offset = "0x80B4290", VA = "0x1880B5890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly POHGOIGKOME MPDODANMFLG;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string LDMKPCDCKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x80AF2D0", Offset = "0x80ADCD0", VA = "0x1880AF2D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BA330", VA = "0x1809BB930")]
	public DDAEHNOMBHA(HLJANHOBGDO DHMLBLBOLIL, POHGOIGKOME MPDODANMFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x80AF1C0", Offset = "0x80ADBC0", VA = "0x1880AF1C0", Slot = "5")]
	[AsyncStateMachine(typeof(HGJKMAHHPMA))]
	public Task<EPGAEOBOMJH.ACFLHOIIMOO> FODMPGPGBHF(HashSet<PKPOBPKHMHL.Reason> HELIALLPAFG, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class PNLDPKMJFKF : PIOAPFPPFFO, EPGAEOBOMJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct LCIDOAFCPFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<EPGAEOBOMJH.ACFLHOIIMOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public PNLDPKMJFKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public HashSet<PKPOBPKHMHL.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private JIFMHENFAOG <localRoomInstance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private long <preFallbackInstance>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private bool <currentIsOffline>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter<EPGAEOBOMJH.ACFLHOIIMOO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x80BDF30", Offset = "0x80BC930", VA = "0x1880BDF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x80BE890", Offset = "0x80BD290", VA = "0x1880BE890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string LDMKPCDCKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x80C84F0", Offset = "0x80C6EF0", VA = "0x1880C84F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BA330", VA = "0x1809BB930")]
	public PNLDPKMJFKF(HLJANHOBGDO DHMLBLBOLIL, POHGOIGKOME MPDODANMFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x80C83A0", Offset = "0x80C6DA0", VA = "0x1880C83A0", Slot = "5")]
	[AsyncStateMachine(typeof(LCIDOAFCPFC))]
	public Task<EPGAEOBOMJH.ACFLHOIIMOO> FODMPGPGBHF(HashSet<PKPOBPKHMHL.Reason> HELIALLPAFG, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class HOGLGJMDCFA : PIOAPFPPFFO, EPGAEOBOMJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct CLFFANCBMDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AsyncTaskMethodBuilder<EPGAEOBOMJH.ACFLHOIIMOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public HOGLGJMDCFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public HashSet<PKPOBPKHMHL.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter<OJIDIPAFKDJ> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<EPGAEOBOMJH.ACFLHOIIMOO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x80AE760", Offset = "0x80AD160", VA = "0x1880AE760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x80AF150", Offset = "0x80ADB50", VA = "0x1880AF150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string LDMKPCDCKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x80B5A50", Offset = "0x80B4450", VA = "0x1880B5A50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BA330", VA = "0x1809BB930")]
	public HOGLGJMDCFA(HLJANHOBGDO DHMLBLBOLIL, POHGOIGKOME MPDODANMFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x80B5900", Offset = "0x80B4300", VA = "0x1880B5900", Slot = "5")]
	[AsyncStateMachine(typeof(CLFFANCBMDN))]
	public Task<EPGAEOBOMJH.ACFLHOIIMOO> FODMPGPGBHF(HashSet<PKPOBPKHMHL.Reason> HELIALLPAFG, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class MHKOPEGJFPA : PIOAPFPPFFO, EPGAEOBOMJH
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class NOKOMHFBILN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public OJIDIPAFKDJ matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NOKOMHFBILN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x80C1FB0", Offset = "0x80C09B0", VA = "0x1880C1FB0")]
		internal object KLNBCHOGPDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x80C1EF0", Offset = "0x80C08F0", VA = "0x1880C1EF0")]
		internal object GBGMAPNHHGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct LDHKIHCEDGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder<EPGAEOBOMJH.ACFLHOIIMOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public MHKOPEGJFPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public HashSet<PKPOBPKHMHL.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private NOKOMHFBILN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<OJIDIPAFKDJ> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<EPGAEOBOMJH.ACFLHOIIMOO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x80BE900", Offset = "0x80BD300", VA = "0x1880BE900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x80BF520", Offset = "0x80BDF20", VA = "0x1880BF520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string LDMKPCDCKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x80C0320", Offset = "0x80BED20", VA = "0x1880C0320", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BA330", VA = "0x1809BB930")]
	public MHKOPEGJFPA(HLJANHOBGDO DHMLBLBOLIL, POHGOIGKOME MPDODANMFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x80C01D0", Offset = "0x80BEBD0", VA = "0x1880C01D0", Slot = "5")]
	[AsyncStateMachine(typeof(LDHKIHCEDGL))]
	public Task<EPGAEOBOMJH.ACFLHOIIMOO> FODMPGPGBHF(HashSet<PKPOBPKHMHL.Reason> HELIALLPAFG, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class PIOAPFPPFFO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct MBCCJJCFHFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public LMPJBEBLCLM log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public HashSet<PKPOBPKHMHL.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public PIOAPFPPFFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<PKPOBPKHMHL.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x80BFA20", Offset = "0x80BE420", VA = "0x1880BFA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x80BFF40", Offset = "0x80BE940", VA = "0x1880BFF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	protected readonly HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	protected readonly POHGOIGKOME MPDODANMFLG;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected FGCPAINBMOO ELGBICGFGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x80C81A0", Offset = "0x80C6BA0", VA = "0x1880C81A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BA330", VA = "0x1809BB930")]
	public PIOAPFPPFFO(HLJANHOBGDO DHMLBLBOLIL, POHGOIGKOME MPDODANMFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x80C81F0", Offset = "0x80C6BF0", VA = "0x1880C81F0")]
	[AsyncStateMachine(typeof(MBCCJJCFHFM))]
	protected Task GLBJJHPLANF(LMPJBEBLCLM BLAHIKOFFGK, HashSet<PKPOBPKHMHL.Reason> HELIALLPAFG, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class GOACPPHJDHF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct OGEDBAPKDDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<EPGAEOBOMJH.ACFLHOIIMOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public POHGOIGKOME callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x80C6850", Offset = "0x80C5250", VA = "0x1880C6850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x80C6BD0", Offset = "0x80C55D0", VA = "0x1880C6BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class AMPCNKLJKJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public HLJANHOBGDO roomManager;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public AMPCNKLJKJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x80AB560", Offset = "0x80A9F60", VA = "0x1880AB560")]
		internal object MIFGNGOOGFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly float GNOKHLANFKG;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	internal static readonly HashSet<PKPOBPKHMHL.Reason> IBKILPDANFJ;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x80B3710", Offset = "0x80B2110", VA = "0x1880B3710")]
	[AsyncStateMachine(typeof(OGEDBAPKDDE))]
	internal static Task<EPGAEOBOMJH.ACFLHOIIMOO> MDBMGIGDGEH(POHGOIGKOME MPDODANMFLG, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x80B3590", Offset = "0x80B1F90", VA = "0x1880B3590")]
	internal static void CLCNPJPCCML(HLJANHOBGDO DHMLBLBOLIL, LMPJBEBLCLM BLAHIKOFFGK, string KNOHJKLJEJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface EPGAEOBOMJH
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct ACFLHOIIMOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public bool FMDMJGBDOPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public PKPOBPKHMHL.Reason NBAKHABPJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Enum? EOEEJLANIAA;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x80A91C0", Offset = "0x80A7BC0", VA = "0x1880A91C0")]
		public static ACFLHOIIMOO LIBNPHEFPNH()
		{
			return default(ACFLHOIIMOO);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x80A9190", Offset = "0x80A7B90", VA = "0x1880A9190")]
		public static ACFLHOIIMOO APGAEAABAMM(PKPOBPKHMHL.Reason NBAKHABPJGI, [Optional] Enum? EOEEJLANIAA)
		{
			return default(ACFLHOIIMOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string MPFFHMHIMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ACFLHOIIMOO> FODMPGPGBHF(HashSet<PKPOBPKHMHL.Reason> HELIALLPAFG, CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct IBGIFKOJEMI
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class DNHPHOAKOCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public HLJANHOBGDO manager;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public DNHPHOAKOCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x80AFFE0", Offset = "0x80AE9E0", VA = "0x1880AFFE0")]
		internal Task IHNCKONBDDJ(CancellationToken cancellationToken, int roomTotalVersion, OEADLBOEPJO localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct ELBBCOEOLAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public IBGIFKOJEMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IMLDBGJKKIJ <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter<OKOHDNPDHIM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<NEGCEOCAIKD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x80B09F0", Offset = "0x80AF3F0", VA = "0x1880B09F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x80B0F80", Offset = "0x80AF980", VA = "0x1880B0F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct BIFOALJBJLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public IBGIFKOJEMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x80AB710", Offset = "0x80AA110", VA = "0x1880AB710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x80ABA30", Offset = "0x80AA430", VA = "0x1880ABA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly CancellationToken BJEPDCCBCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly HLJANHOBGDO GIGHOMPCPHH;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private MFOOBEAIMGO DGCCEFDKJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x80B6870", Offset = "0x80B5270", VA = "0x1880B6870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private POHGOIGKOME MNIGFADEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x80B6820", Offset = "0x80B5220", VA = "0x1880B6820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private FGCPAINBMOO ELGBICGFGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x80B6750", Offset = "0x80B5150", VA = "0x1880B6750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private FHKNJJPAONB FHADNEOAPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x80B67D0", Offset = "0x80B51D0", VA = "0x1880B67D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x26A9E00", Offset = "0x26A8800", VA = "0x1826A9E00")]
	public IBGIFKOJEMI(CancellationToken BJEPDCCBCHJ, HLJANHOBGDO GIGHOMPCPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x80B68C0", Offset = "0x80B52C0", VA = "0x1880B68C0")]
	public static JBJOGAHMAOM NOHEEPAGADA(HLJANHOBGDO GIGHOMPCPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x80B6970", Offset = "0x80B5370", VA = "0x1880B6970")]
	[AsyncStateMachine(typeof(ELBBCOEOLAK))]
	public Task<bool> OBEHDDJHDFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x80B6540", Offset = "0x80B4F40", VA = "0x1880B6540")]
	private bool BIHHHEMCEGN([Out] IMLDBGJKKIJ OOOILNKOICJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x80B6BB0", Offset = "0x80B55B0", VA = "0x1880B6BB0")]
	[AsyncStateMachine(typeof(BIFOALJBJLJ))]
	private Task PGOMDGNJBGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x80B6A80", Offset = "0x80B5480", VA = "0x1880B6A80")]
	private Task<OKOHDNPDHIM> PBOHJFDDGFP(IMLDBGJKKIJ EEIHFEEDJFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct PAPDCOBPBIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly CGNEECPBPBC JFGGIHEHAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Guid HPBDKIENPJP;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(NEGCEOCAIKD, Task)> CKAHMGKJPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x80C7CE0", Offset = "0x80C66E0", VA = "0x1880C7CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3520", Offset = "0x4EA1F20", VA = "0x184EA3520")]
	public PAPDCOBPBIP(CGNEECPBPBC JFGGIHEHAEA, Guid HPBDKIENPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x80C7C90", Offset = "0x80C6690", VA = "0x1880C7C90")]
	public TaskAwaiter<(NEGCEOCAIKD, Task)> FJPAAICMOHL()
	{
		return default(TaskAwaiter<(NEGCEOCAIKD, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x80C7BC0", Offset = "0x80C65C0", VA = "0x1880C7BC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct FLLADLHLMAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly TaskCompletionSource<(NEGCEOCAIKD, Task)> DMKELOGLHCF;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(NEGCEOCAIKD, Task)> CKAHMGKJPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x80B1EC0", Offset = "0x80B08C0", VA = "0x1880B1EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x80B1F00", Offset = "0x80B0900", VA = "0x1880B1F00")]
	public FLLADLHLMAB(TimeSpan PNIMMCCMCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x80B1D40", Offset = "0x80B0740", VA = "0x1880B1D40")]
	public void DDEPCMDNNKG(Task AMMGCNPDJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x80B1CB0", Offset = "0x80B06B0", VA = "0x1880B1CB0")]
	public void BMLEJGEMGKI(NEGCEOCAIKD PGKINBLHCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x80B1E70", Offset = "0x80B0870", VA = "0x1880B1E70")]
	public void JJOOGHEGOFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x80B1DE0", Offset = "0x80B07E0", VA = "0x1880B1DE0")]
	internal void HFKJCJCKNJN(string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class NNANMBGHPPL
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x80C1B50", Offset = "0x80C0550", VA = "0x1880C1B50")]
	public static LGCLIBGOJHL HAAGNGBAJLM(this LGCLIBGOJHL ECGNDACMANN, AKGPNEALNMD HFEIECCIKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x80C1CF0", Offset = "0x80C06F0", VA = "0x1880C1CF0")]
	public static LGCLIBGOJHL JHAENPHAIJF(this LGCLIBGOJHL ECGNDACMANN, AOPJKBPEOJP DKAGOMPGOOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class GLFLOFAMODE : ENACNLJLDID
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class NBIGBJIHKPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public AOPJKBPEOJP subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NBIGBJIHKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x80C03D0", Offset = "0x80BEDD0", VA = "0x1880C03D0")]
		internal bool DMEENKNNKKH(HPIALGGGMCA s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly PPLNHPJCIPO AOKCFJKBBPA;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	public GLFLOFAMODE(PPLNHPJCIPO MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x80B3500", Offset = "0x80B1F00", VA = "0x1880B3500", Slot = "4")]
	public LGCLIBGOJHL IDEDHGEBOCJ(long BJCKGBNCPKM, long CPBHLEIJEHC, string HHFGONMNNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x80B33A0", Offset = "0x80B1DA0", VA = "0x1880B33A0", Slot = "5")]
	public LGCLIBGOJHL IDEDHGEBOCJ(long BJCKGBNCPKM, long CPBHLEIJEHC, LPGDPINKOBL AHNEEBNBDDH, Guid? IMGGCBCHJLN, long LGCPADGPCDG, bool HFAGHFGFAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x80B2EC0", Offset = "0x80B18C0", VA = "0x1880B2EC0", Slot = "6")]
	public LGCLIBGOJHL IDEDHGEBOCJ(CMOIIBJLNAK KNPLKFMHAEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x80B30C0", Offset = "0x80B1AC0", VA = "0x1880B30C0", Slot = "7")]
	public LGCLIBGOJHL IDEDHGEBOCJ(AKGPNEALNMD DMFEPJLKGFM, AOPJKBPEOJP PLHFMBKMCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x80B2E10", Offset = "0x80B1810", VA = "0x1880B2E10")]
	private Guid? DBMNGKFLBAG(AKGPNEALNMD KBGEJGDEPOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class JGACAHMKAGL : MPPOGMBIPDB, HNKIOMKDACP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct JJEMBKCFHEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public JGACAHMKAGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x80B7DC0", Offset = "0x80B67C0", VA = "0x1880B7DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x80B8450", Offset = "0x80B6E50", VA = "0x1880B8450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly MDCBAMNMOAI OIPPGCCKNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private string DKANNAEHEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Task KLMCGGAPJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool IMJCMPDFLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x80B7A80", Offset = "0x80B6480", VA = "0x1880B7A80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task PEPEEIAFDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x80B79F0", Offset = "0x80B63F0", VA = "0x1880B79F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x9B6FD0", Offset = "0x9B59D0", VA = "0x1809B6FD0", Slot = "7")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x80B7AB0", Offset = "0x80B64B0", VA = "0x1880B7AB0", Slot = "6")]
	public void MHJDNGDBFDL(Task GLCABFFLNII, string ANPEHIIPGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x80B7C10", Offset = "0x80B6610", VA = "0x1880B7C10")]
	[AsyncStateMachine(typeof(JJEMBKCFHEE))]
	private Task MPPNHPNPMCP(Task KECPPNPBPGD, string ANPEHIIPGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x80B7D30", Offset = "0x80B6730", VA = "0x1880B7D30")]
	public JGACAHMKAGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class ALPNCHHIADL : LGJGOBGLPCF, HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private bool KPEHLPGCJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private ANKDDIPDILL PBMEMCLOKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private MFOOBEAIMGO HFDCCFJAOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private PPLNHPJCIPO MOAPPBPCBJG;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public ANKDDIPDILL KIDCBFGDFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x80AB430", Offset = "0x80A9E30", VA = "0x1880AB430", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x80AB2B0", Offset = "0x80A9CB0", VA = "0x1880AB2B0", Slot = "7")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x80AB0C0", Offset = "0x80A9AC0", VA = "0x1880AB0C0", Slot = "5")]
	public void CIFOFFHBDJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x80AB270", Offset = "0x80A9C70", VA = "0x1880AB270", Slot = "6")]
	public void MELAHFDDJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x80AB4A0", Offset = "0x80A9EA0", VA = "0x1880AB4A0")]
	private Task NKMMLKCIHID(NNDKFANEGFP FOAJJFFCIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x80AB270", Offset = "0x80A9C70", VA = "0x1880AB270", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public ALPNCHHIADL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class GKMJAEEBEBM : PPLNHPJCIPO
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class DAHAAHCAAEB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly BGNEBPNKOAE FAKMMFCIMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly string NJBPFCDJFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly T LPJIMLBFHAO;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T ABKPALEDJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xBFFB90", Offset = "0xBFE590", VA = "0x180BFFB90")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xBFF920", Offset = "0xBFE320", VA = "0x180BFF920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3EDED80", Offset = "0x3EDD780", VA = "0x183EDED80")]
		public DAHAAHCAAEB(BGNEBPNKOAE FAKMMFCIMGO, string NJBPFCDJFGD, T LPJIMLBFHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3EDEA80", Offset = "0x3EDD480", VA = "0x183EDEA80")]
		private void GHNMAMCFDFJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly BGNEBPNKOAE FAKMMFCIMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly DAHAAHCAAEB<TimeSpan> BCBDPDEFFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly DAHAAHCAAEB<TimeSpan> COBIHPEOINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly DAHAAHCAAEB<TimeSpan> NEPNFNPADHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly DAHAAHCAAEB<TimeSpan> KMCOBCNACKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly DAHAAHCAAEB<bool> NOEJJNADDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly DAHAAHCAAEB<bool> CLJCOHKFFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly DAHAAHCAAEB<bool> MKELKMAFNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly DAHAAHCAAEB<int> KCCKJIGKCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly DAHAAHCAAEB<bool> PECBMPIJLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly DAHAAHCAAEB<bool> MIACEHLONEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly DAHAAHCAAEB<DLMLAFPGPND> FBGLKFPGHDN;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan DJIILHDMOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x80B2800", Offset = "0x80B1200", VA = "0x1880B2800", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan DMLLJLAKHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x80B2880", Offset = "0x80B1280", VA = "0x1880B2880", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan MKHEPOBPAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x80B2730", Offset = "0x80B1130", VA = "0x1880B2730", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan NICPMGECGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x80B2670", Offset = "0x80B1070", VA = "0x1880B2670", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool NPELLPFNIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x80B26B0", Offset = "0x80B10B0", VA = "0x1880B26B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool LDMCLPLCFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x80B28C0", Offset = "0x80B12C0", VA = "0x1880B28C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool CELLPJOOHJE
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x80B2900", Offset = "0x80B1300", VA = "0x1880B2900", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int FEOLLLLLLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x80B26F0", Offset = "0x80B10F0", VA = "0x1880B26F0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool NLEPBNBIHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x80B2840", Offset = "0x80B1240", VA = "0x1880B2840", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool JBPDJILNLKL
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x80B27C0", Offset = "0x80B11C0", VA = "0x1880B27C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool PKHMHMDKAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x80B2770", Offset = "0x80B1170", VA = "0x1880B2770", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x80B2940", Offset = "0x80B1340", VA = "0x1880B2940")]
	[UnityEngine.Scripting.Preserve]
	public GKMJAEEBEBM([GJJKIKPKKBJ(null)] BGNEBPNKOAE FAKMMFCIMGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class ACFMLMBEAIL : NEFHJNBMHHM, HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class OLCMIBGAOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public JBLHFKMHHBN roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public OLCMIBGAOAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x80C7AE0", Offset = "0x80C64E0", VA = "0x1880C7AE0")]
		internal object EBKIMFLKGFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action LMDBLEALGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x80A95B0", Offset = "0x80A7FB0", VA = "0x1880A95B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x80A93B0", Offset = "0x80A7DB0", VA = "0x1880A93B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event MDIFJECFPAC DJABEFJBOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x80A9650", Offset = "0x80A8050", VA = "0x1880A9650", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x80A9270", Offset = "0x80A7C70", VA = "0x1880A9270", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event MDIFJECFPAC EMJKGHDFLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x80A9C20", Offset = "0x80A8620", VA = "0x1880A9C20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x80A91D0", Offset = "0x80A7BD0", VA = "0x1880A91D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event MDIFJECFPAC DNGCLBJFALA
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x80A96F0", Offset = "0x80A80F0", VA = "0x1880A96F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x80A9310", Offset = "0x80A7D10", VA = "0x1880A9310", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<LEOGKKHFKEI, bool> FHKKABCIMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x80A9450", Offset = "0x80A7E50", VA = "0x1880A9450", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x80A99B0", Offset = "0x80A83B0", VA = "0x1880A99B0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "19")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x80A9790", Offset = "0x80A8190", VA = "0x1880A9790", Slot = "14")]
	public void LMOKCHAHBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x80A9580", Offset = "0x80A7F80", VA = "0x1880A9580", Slot = "15")]
	public void JCIEHHJOKGH(JBLHFKMHHBN HHKJAIHFEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x80A9550", Offset = "0x80A7F50", VA = "0x1880A9550", Slot = "16")]
	public void IKKKGGDGDFN(JBLHFKMHHBN HHKJAIHFEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x80A9980", Offset = "0x80A8380", VA = "0x1880A9980", Slot = "17")]
	public void OABHBKOPEGN(JBLHFKMHHBN HHKJAIHFEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x80A9500", Offset = "0x80A7F00", VA = "0x1880A9500", Slot = "18")]
	public void HEGDIHGGCMA(LEOGKKHFKEI NPBKJOPAEBM, bool FMDMJGBDOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x80A9A60", Offset = "0x80A8460", VA = "0x1880A9A60")]
	private void PADLNKFJPNL(MDIFJECFPAC MLBJPJMCPKK, JBLHFKMHHBN HHKJAIHFEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public ACFMLMBEAIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[UnityEngine.Scripting.Preserve]
internal class OADPGHJGMIO : PKPOBPKHMHL, HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class HEOIADBDPKH : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct FDKKNDNNPEH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public HEOIADBDPKH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public PKPOBPKHMHL.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private MBDDIOMLGLG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private EPGAEOBOMJH[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private TaskAwaiter<EPGAEOBOMJH.ACFLHOIIMOO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x80B1520", Offset = "0x80AFF20", VA = "0x1880B1520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x80B1C50", Offset = "0x80B0650", VA = "0x1880B1C50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct NCHKMDILNPO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public AsyncTaskMethodBuilder<EPGAEOBOMJH.ACFLHOIIMOO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public EPGAEOBOMJH fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public HEOIADBDPKH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public PKPOBPKHMHL.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private MBDDIOMLGLG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private NGHADLPKDAC <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private TaskAwaiter<EPGAEOBOMJH.ACFLHOIIMOO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x80C0400", Offset = "0x80BEE00", VA = "0x1880C0400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x80C1090", Offset = "0x80BFA90", VA = "0x1880C1090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class PMDEJLMAKBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public EPGAEOBOMJH fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public PMDEJLMAKBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x80C8320", Offset = "0x80C6D20", VA = "0x1880C8320")]
			internal object CMFLJDDGJFF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Task GLCABFFLNII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationTokenSource LBOCPDNMHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public NGHADLPKDAC FJFPLPMFNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public POHGOIGKOME MPDODANMFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public FMHJIJNHDAA AOGDCMCHFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public JIFMHENFAOG HCMHGCJCEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public EPGAEOBOMJH[] GDOGJFEJNNC;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool PENNPAPDBNH
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x80B4500", Offset = "0x80B2F00", VA = "0x1880B4500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool OOOPGFGMHFH
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x80B4F10", Offset = "0x80B3910", VA = "0x1880B4F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x80B5470", Offset = "0x80B3E70", VA = "0x1880B5470")]
		public HEOIADBDPKH(POHGOIGKOME MPDODANMFLG, FMHJIJNHDAA AOGDCMCHFEI, JIFMHENFAOG HCMHGCJCEGJ, EPGAEOBOMJH[] GDOGJFEJNNC, CancellationToken BJEPDCCBCHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x80B3CA0", Offset = "0x80B26A0", VA = "0x1880B3CA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x80B4F30", Offset = "0x80B3930", VA = "0x1880B4F30")]
		public void ONDMDPKHEMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x80B40F0", Offset = "0x80B2AF0", VA = "0x1880B40F0")]
		public void HABLBFKPNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x80B4250", Offset = "0x80B2C50", VA = "0x1880B4250")]
		public void HAEMFBMDJPB(PKPOBPKHMHL.Reason HDHMAEMNPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x80B4740", Offset = "0x80B3140", VA = "0x1880B4740")]
		[AsyncStateMachine(typeof(FDKKNDNNPEH))]
		public Task LBJCAPIHNNA(PKPOBPKHMHL.Reason NBAKHABPJGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x80B4C00", Offset = "0x80B3600", VA = "0x1880B4C00")]
		[AsyncStateMachine(typeof(NCHKMDILNPO))]
		private Task<EPGAEOBOMJH.ACFLHOIIMOO> LGJMNKLGGOH(PKPOBPKHMHL.Reason NBAKHABPJGI, EPGAEOBOMJH ILLDOPMPGLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x80B3E30", Offset = "0x80B2830", VA = "0x1880B3E30")]
		private void EAMOKFBKAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x80B3BF0", Offset = "0x80B25F0", VA = "0x1880B3BF0")]
		public bool DIAKFHDNIJE(PKPOBPKHMHL.Reason EFHDEANMCHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x80B3940", Offset = "0x80B2340", VA = "0x1880B3940")]
		private void AJCLAHAHPJJ(NGHADLPKDAC JCFJJCIGDKC, PKPOBPKHMHL.Reason NBAKHABPJGI = PKPOBPKHMHL.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x80B4D40", Offset = "0x80B3740", VA = "0x1880B4D40")]
		private void LJNJJDCCAPA(NGHADLPKDAC JCFJJCIGDKC, EPGAEOBOMJH.ACFLHOIIMOO FFBEKAFHIDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x80B3F50", Offset = "0x80B2950", VA = "0x1880B3F50")]
		private void GDGAFNGBIFC(NGHADLPKDAC JCFJJCIGDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x80B4840", Offset = "0x80B3240", VA = "0x1880B4840")]
		private void LEOPGDDIGBG(NGHADLPKDAC JCFJJCIGDKC, EPGAEOBOMJH.ACFLHOIIMOO FFBEKAFHIDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x80B4FA0", Offset = "0x80B39A0", VA = "0x1880B4FA0")]
		private void PMEMMALIADP(NGHADLPKDAC JCFJJCIGDKC, Exception GKNCIBMNAMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x80B4630", Offset = "0x80B3030", VA = "0x1880B4630")]
		private void KPFLDEFLBNB(EPGAEOBOMJH ILLDOPMPGLK, PKPOBPKHMHL.Reason NBAKHABPJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x80B4520", Offset = "0x80B2F20", VA = "0x1880B4520")]
		private void IACNGCKGKOI(EPGAEOBOMJH ILLDOPMPGLK, PKPOBPKHMHL.Reason NBAKHABPJGI, string EOEEJLANIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x80B5100", Offset = "0x80B3B00", VA = "0x1880B5100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class NGHADLPKDAC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Task<EPGAEOBOMJH.ACFLHOIIMOO> GLCABFFLNII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public CancellationTokenSource LBOCPDNMHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public EPGAEOBOMJH ILLDOPMPGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public PKPOBPKHMHL.Reason HDHMAEMNPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public HashSet<PKPOBPKHMHL.Reason> HELIALLPAFG;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool PENNPAPDBNH
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x80B4500", Offset = "0x80B2F00", VA = "0x1880B4500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool OOOPGFGMHFH
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x80B4F10", Offset = "0x80B3910", VA = "0x1880B4F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x80C1100", Offset = "0x80BFB00", VA = "0x1880C1100")]
		public void DDDFCMLAOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x80C1260", Offset = "0x80BFC60", VA = "0x1880C1260", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x80C1280", Offset = "0x80BFC80", VA = "0x1880C1280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x80C15E0", Offset = "0x80BFFE0", VA = "0x1880C15E0")]
		public NGHADLPKDAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class IKJPGPIBIKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public PKPOBPKHMHL.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public IKJPGPIBIKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x80B6D60", Offset = "0x80B5760", VA = "0x1880B6D60")]
		internal object JCKLIMCINIE(NGHADLPKDAC x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x80B6CF0", Offset = "0x80B56F0", VA = "0x1880B6CF0")]
		internal object ICJLFIAPOMM(HEOIADBDPKH x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x80B6C80", Offset = "0x80B5680", VA = "0x1880B6C80")]
		internal object GCALPEPBCPK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct JDNOIKKBGKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public PKPOBPKHMHL.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public OADPGHJGMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private IKJPGPIBIKL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x80B6F30", Offset = "0x80B5930", VA = "0x1880B6F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x80B7990", Offset = "0x80B6390", VA = "0x1880B7990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct AEOODLNBFEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public OADPGHJGMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public PKPOBPKHMHL.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private HEOIADBDPKH <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x80A9F40", Offset = "0x80A8940", VA = "0x1880A9F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x80AABB0", Offset = "0x80A95B0", VA = "0x1880AABB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct DHFEMONHMJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public OADPGHJGMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x80AF740", Offset = "0x80AE140", VA = "0x1880AF740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x80AFCB0", Offset = "0x80AE6B0", VA = "0x1880AFCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	internal static readonly LMPJBEBLCLM DFKBDALENDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private POHGOIGKOME MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private HEOIADBDPKH BLOOCJMMIJH;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private FGCPAINBMOO ELGBICGFGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x80C21F0", Offset = "0x80C0BF0", VA = "0x1880C21F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool PLPBCCAKKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2274690", Offset = "0x2273090", VA = "0x182274690", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool FJDIICPCOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x80C2180", Offset = "0x80C0B80", VA = "0x1880C2180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x80C23D0", Offset = "0x80C0DD0", VA = "0x1880C23D0", Slot = "7")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x80C23C0", Offset = "0x80C0DC0", VA = "0x1880C23C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x80C2240", Offset = "0x80C0C40", VA = "0x1880C2240", Slot = "9")]
	public void DDDFCMLAOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x80C2BB0", Offset = "0x80C15B0", VA = "0x1880C2BB0")]
	private bool JAAOJLODLNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x80C20B0", Offset = "0x80C0AB0", VA = "0x1880C20B0", Slot = "6")]
	private void BLEFDFBDDNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x80C2DA0", Offset = "0x80C17A0", VA = "0x1880C2DA0", Slot = "5")]
	[AsyncStateMachine(typeof(JDNOIKKBGKO))]
	private Task NLLOLPLNMGO(PKPOBPKHMHL.Reason NBAKHABPJGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x80C28E0", Offset = "0x80C12E0", VA = "0x1880C28E0")]
	private bool IGKKPIBNEBC(PKPOBPKHMHL.Reason NBAKHABPJGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x80C2520", Offset = "0x80C0F20", VA = "0x1880C2520")]
	private EPGAEOBOMJH[] HKGCHFOCAAI(JIFMHENFAOG MBJELJHMIMM, FMHJIJNHDAA LOCAMEFKCKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x80C2C90", Offset = "0x80C1690", VA = "0x1880C2C90")]
	[AsyncStateMachine(typeof(AEOODLNBFEO))]
	private Task KINLOECOOKJ(PKPOBPKHMHL.Reason NBAKHABPJGI, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x80C2450", Offset = "0x80C0E50", VA = "0x1880C2450")]
	[AsyncStateMachine(typeof(DHFEMONHMJA))]
	private Task HFLECJEKBNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public OADPGHJGMIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class OCHJPFJPNAI : OHNHALKFFPG, HNKIOMKDACP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct EJNMIFLFBNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public OCHJPFJPNAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public BEJEKGNNGMP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x80B0030", Offset = "0x80AEA30", VA = "0x1880B0030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x80B0990", Offset = "0x80AF390", VA = "0x1880B0990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct BKBLEOLEMFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public OCHJPFJPNAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public BEJEKGNNGMP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private NCPOPMIDADO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private MBDDIOMLGLG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private ONJGKIHMNBI <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private LNJEGFLCGIN <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x80ABD20", Offset = "0x80AA720", VA = "0x1880ABD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x80ACA60", Offset = "0x80AB460", VA = "0x1880ACA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class BDPKPKPMPKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Matchmaking.CPLJJEKEANG result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public ONLIALKKKEI errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public BDPKPKPMPKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x80AB660", Offset = "0x80AA060", VA = "0x1880AB660")]
		internal object ANPBPNEELFL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class CJHICMEGOIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Task<LGCLIBGOJHL> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CJHICMEGOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		internal Task<LGCLIBGOJHL> LOPFMEMIJCA(NCPOPMIDADO<string>.CFILPBLEJMI _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct KFGOELPDOFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public OCHJPFJPNAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public BEJEKGNNGMP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public ONJGKIHMNBI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private CJHICMEGOIA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private BDLALLLEJJP <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private MBDDIOMLGLG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private FOAOAEBMOMB <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Task<Matchmaking.EEJAHADMACG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private GHJBLFPCPMC <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter<Matchmaking.EEJAHADMACG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<LGCLIBGOJHL> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x80B84B0", Offset = "0x80B6EB0", VA = "0x1880B84B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x80BDED0", Offset = "0x80BC8D0", VA = "0x1880BDED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct JGBDFCDOANJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public OCHJPFJPNAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x80DC970", Offset = "0x80DB370", VA = "0x1880DC970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x80DD3D0", Offset = "0x80DBDD0", VA = "0x1880DD3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct POLIGPOKDDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public OCHJPFJPNAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private LKOLOODKMPF <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x80E70E0", Offset = "0x80E5AE0", VA = "0x1880E70E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x80E7570", Offset = "0x80E5F70", VA = "0x1880E7570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct NHLKNFDCMHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public AsyncTaskMethodBuilder<Matchmaking.EEJAHADMACG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public OCHJPFJPNAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter<Matchmaking.EEJAHADMACG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x80E40C0", Offset = "0x80E2AC0", VA = "0x1880E40C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x80E45A0", Offset = "0x80E2FA0", VA = "0x1880E45A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct IMNNNECFLHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public Matchmaking.EEJAHADMACG serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public OCHJPFJPNAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public ONJGKIHMNBI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter<KKOMCOLKDLD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x80DA540", Offset = "0x80D8F40", VA = "0x1880DA540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x80DAB80", Offset = "0x80D9580", VA = "0x1880DAB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class AEEBCEPGNNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public AEEBCEPGNNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x80CC6C0", Offset = "0x80CB0C0", VA = "0x1880CC6C0")]
		internal object MEGGODJNLAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x80CC7C0", Offset = "0x80CB1C0", VA = "0x1880CC7C0")]
		internal string MNHHGCMDEAP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct MPCCKGLKPPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public OCHJPFJPNAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private AEEBCEPGNNC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x80E1840", Offset = "0x80E0240", VA = "0x1880E1840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x80E23D0", Offset = "0x80E0DD0", VA = "0x1880E23D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct DGGJIJLDFGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public OCHJPFJPNAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public ONJGKIHMNBI joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public LGCLIBGOJHL initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public JIFMHENFAOG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public BDLALLLEJJP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x80D1C00", Offset = "0x80D0600", VA = "0x1880D1C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x80D23F0", Offset = "0x80D0DF0", VA = "0x1880D23F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct LIFCGKNJFDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public OCHJPFJPNAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private MBDDIOMLGLG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private MBDDIOMLGLG <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x80DFCF0", Offset = "0x80DE6F0", VA = "0x1880DFCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x80E14D0", Offset = "0x80DFED0", VA = "0x1880E14D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct KGGIADOBHIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public OEADLBOEPJO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public OCHJPFJPNAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<NEGCEOCAIKD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x80DE570", Offset = "0x80DCF70", VA = "0x1880DE570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x80DED70", Offset = "0x80DD770", VA = "0x1880DED70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class ONJBEIGBADD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public ONJBEIGBADD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x80E5B60", Offset = "0x80E4560", VA = "0x1880E5B60")]
		internal object MKBJBOJPJGM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class IKCLCJLIBKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public IKCLCJLIBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x80DA330", Offset = "0x80D8D30", VA = "0x1880DA330")]
		internal void DGBDAOJNOAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class NBFGOLHCGAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NBFGOLHCGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x80E3490", Offset = "0x80E1E90", VA = "0x1880E3490")]
		internal object NPANEGIMEPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class IMEAMHAEKIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public IMEAMHAEKIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x80DA440", Offset = "0x80D8E40", VA = "0x1880DA440")]
		internal string EAKDENDCLPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly LMPJBEBLCLM LBKMOKIIJLH;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly LMPJBEBLCLM AOLHODOLEHB;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly LMPJBEBLCLM PBLCPLODJDK;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly string MABDKGKJMDF;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static readonly string CGNDJLIPEJK;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static readonly string GGFGNOLCIML;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static readonly Guid KNOGCFJMIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private MGIEBANOHLI DJOAEGGPBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private JPHHEIGPJJM IAEPFCBBPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private MFOOBEAIMGO HFDCCFJAOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private POHGOIGKOME MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private PKPOBPKHMHL CHFJNDNOJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private MPPOGMBIPDB POCJIBOPFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NEFHJNBMHHM DMPOELGMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private HCPGKPPOEKF CIGPPMMLFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private HMJOFPFMBKI HONHKIBBAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private IDisposable NMCCAGENGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private LABMLFFGKHA LOLOBNCIBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly MDCBAMNMOAI HICKJIBAFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private GHJBLFPCPMC KANDBHKBFJC;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus FBCNJFGOEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9D4D60", Offset = "0x9D3760", VA = "0x1809D4D60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x1216CB0", Offset = "0x12156B0", VA = "0x181216CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private FGCPAINBMOO ELGBICGFGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x80C3790", Offset = "0x80C2190", VA = "0x1880C3790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x80C3FA0", Offset = "0x80C29A0", VA = "0x1880C3FA0", Slot = "6")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x80C3AC0", Offset = "0x80C24C0", VA = "0x1880C3AC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x80C5BD0", Offset = "0x80C45D0", VA = "0x1880C5BD0", Slot = "5")]
	[AsyncStateMachine(typeof(EJNMIFLFBNN))]
	public Task LJMCMHPGGIG(JIFMHENFAOG AFMDHCINNJF, BEJEKGNNGMP PONDNJALBLB, CancellationToken OJOOKCOCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x80C43C0", Offset = "0x80C2DC0", VA = "0x1880C43C0")]
	[AsyncStateMachine(typeof(BKBLEOLEMFM))]
	private Task FDOANPEDJMI(JIFMHENFAOG AFMDHCINNJF, BEJEKGNNGMP PONDNJALBLB, CancellationToken OJOOKCOCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x80C5660", Offset = "0x80C4060", VA = "0x1880C5660")]
	private void LIFHLAAGEBG(HCPGKPPOEKF CIGPPMMLFJO, JIFMHENFAOG AFMDHCINNJF, Exception GKNCIBMNAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x80C2F50", Offset = "0x80C1950", VA = "0x1880C2F50")]
	private static void BGNMEDPANCF(LNJEGFLCGIN FPCPPEBCPKG, Exception GKNCIBMNAMA, [Optional] List<int> LDLDKIBLGGM, int MHLEAHHCAJD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x80C4EE0", Offset = "0x80C38E0", VA = "0x1880C4EE0")]
	[AsyncStateMachine(typeof(KFGOELPDOFL))]
	private Task IJMKHPJIGFC(NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, JIFMHENFAOG AFMDHCINNJF, BEJEKGNNGMP PONDNJALBLB, ONJGKIHMNBI HPHAPGLBKKF, CancellationToken OJOOKCOCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x80C50D0", Offset = "0x80C3AD0", VA = "0x1880C50D0")]
	private void JOJIAIKECHC([CallerMemberName] string CMLDDKINFLA = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x80C37E0", Offset = "0x80C21E0", VA = "0x1880C37E0")]
	[AsyncStateMachine(typeof(JGBDFCDOANJ))]
	private Task DBFHNDAJBIE(NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x80C3C70", Offset = "0x80C2670", VA = "0x1880C3C70")]
	private void EKGFKKAEBPG(JIFMHENFAOG AFMDHCINNJF, CancellationToken OJOOKCOCPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x80C5E50", Offset = "0x80C4850", VA = "0x1880C5E50")]
	private void MKMGJPGHCBI(JIFMHENFAOG AFMDHCINNJF, TaskStatus PMLAHPLBHLG, string FLPDJFEEMLN, ONJGKIHMNBI HPHAPGLBKKF, Exception MDJLCJHKPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x80C6430", Offset = "0x80C4E30", VA = "0x1880C6430")]
	private void OLELNCELDKI(JIFMHENFAOG AFMDHCINNJF, ONJGKIHMNBI HPHAPGLBKKF, OperationCanceledException AGPAGIBCJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x80C4BF0", Offset = "0x80C35F0", VA = "0x1880C4BF0")]
	private void GMKGJJFPJNE(JIFMHENFAOG AFMDHCINNJF, ONJGKIHMNBI HPHAPGLBKKF, Exception GKNCIBMNAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x80C48B0", Offset = "0x80C32B0", VA = "0x1880C48B0")]
	private void GFEMOIAAONM(JIFMHENFAOG AFMDHCINNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x80C6370", Offset = "0x80C4D70", VA = "0x1880C6370")]
	private static JBLHFKMHHBN NPKPBCJFHLG(JIFMHENFAOG AFMDHCINNJF)
	{
		return default(JBLHFKMHHBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x80C5250", Offset = "0x80C3C50", VA = "0x1880C5250")]
	[AsyncStateMachine(typeof(POLIGPOKDDD))]
	private Task KAIKONDGPCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x80C3B10", Offset = "0x80C2510", VA = "0x1880C3B10")]
	[AsyncStateMachine(typeof(NHLKNFDCMHC))]
	private Task<Matchmaking.EEJAHADMACG> ECOCGINFAND(JIFMHENFAOG AFMDHCINNJF, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x80C64B0", Offset = "0x80C4EB0", VA = "0x1880C64B0")]
	private static KKOMCOLKDLD PEPLKBBCDGC(Matchmaking.EEJAHADMACG HJANPDLODFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x80C5320", Offset = "0x80C3D20", VA = "0x1880C5320")]
	[AsyncStateMachine(typeof(IMNNNECFLHB))]
	private Task LBHJJKCEDKG(Matchmaking.EEJAHADMACG HJANPDLODFK, ONJGKIHMNBI HPHAPGLBKKF, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken FFMFJPMFBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x80C5D10", Offset = "0x80C4710", VA = "0x1880C5D10")]
	[AsyncStateMachine(typeof(MPCCKGLKPPB))]
	private Task LOMCLDCLAKG(JIFMHENFAOG AFMDHCINNJF, CancellationTokenSource MKNONJLHDEE, Task PELIJHIHNHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x80C4510", Offset = "0x80C2F10", VA = "0x1880C4510")]
	[AsyncStateMachine(typeof(DGGJIJLDFGI))]
	private Task FNHNIELOGPA(LGCLIBGOJHL MBMHANDGHDK, BDLALLLEJJP AFCEHLJIDFO, JIFMHENFAOG DLPODMKAOHB, ONJGKIHMNBI NBOEHEDNFCB, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BKLBBCMGPEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x80C5470", Offset = "0x80C3E70", VA = "0x1880C5470")]
	private ONJGKIHMNBI LDCJNCDGGDD(ONJGKIHMNBI NBOEHEDNFCB, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x80C61A0", Offset = "0x80C4BA0", VA = "0x1880C61A0")]
	[AsyncStateMachine(typeof(LIFCGKNJFDJ))]
	private Task NFLFBMCEPEA(NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x80C4AC0", Offset = "0x80C34C0", VA = "0x1880C4AC0")]
	[AsyncStateMachine(typeof(KGGIADOBHIM))]
	private Task GHBIKMLOPCB(CancellationToken BJEPDCCBCHJ, int HBOPDPPMOIM, OEADLBOEPJO HMEIOLJKGHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x80C4D60", Offset = "0x80C3760", VA = "0x1880C4D60")]
	private static void IAGLNMPFJCP(JIFMHENFAOG AFMDHCINNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x80C4680", Offset = "0x80C3080", VA = "0x1880C4680")]
	private void FONFJJFDHFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x80C62E0", Offset = "0x80C4CE0", VA = "0x1880C62E0")]
	private void NHIICBCFGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x80C4C70", Offset = "0x80C3670", VA = "0x1880C4C70")]
	private void GNHENNGGDJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x80C5040", Offset = "0x80C3A40", VA = "0x1880C5040")]
	private void JLJEIIALINH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x80C60B0", Offset = "0x80C4AB0", VA = "0x1880C60B0")]
	private static void NCCGLCELIFP(JIFMHENFAOG AFMDHCINNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x80C5AC0", Offset = "0x80C44C0", VA = "0x1880C5AC0")]
	private static CancellationTokenRegistration LIJDMDACNGG(JIFMHENFAOG AFMDHCINNJF, CancellationToken FFMFJPMFBOB)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x80C42C0", Offset = "0x80C2CC0", VA = "0x1880C42C0")]
	private static void FAEHBODFFJL(JIFMHENFAOG AFMDHCINNJF, Exception GKNCIBMNAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x80C3910", Offset = "0x80C2310", VA = "0x1880C3910")]
	private void DNABNGOAJLL(JIFMHENFAOG AFMDHCINNJF, Task PELIJHIHNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x80C4D00", Offset = "0x80C3700", VA = "0x1880C4D00")]
	private static void HIMKLMLGBHH(Func<string> GHDHNPDIMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x80C67C0", Offset = "0x80C51C0", VA = "0x1880C67C0")]
	public OCHJPFJPNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x80C63D0", Offset = "0x80C4DD0", VA = "0x1880C63D0")]
	[CompilerGenerated]
	internal static (int, int?) OGIODNGEBDN(ONLIALKKKEI CCAPIJPBJLK)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RecRoom.NoEngine.Common.Preserve]
internal class AAMJHGADFDG : HJNAJNAOIBC, HNKIOMKDACP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct NNBMBFCKFDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AAMJHGADFDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public OEADLBOEPJO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x80E4910", Offset = "0x80E3310", VA = "0x1880E4910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x80E4DF0", Offset = "0x80E37F0", VA = "0x1880E4DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class FFLDNPHMJHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public AAMJHGADFDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public OEADLBOEPJO localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public FFLDNPHMJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x80D54C0", Offset = "0x80D3EC0", VA = "0x1880D54C0")]
		internal List<Task> NPJDPJCJEOP(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct DPJKADIMOBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public JBJOGAHMAOM taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public OEADLBOEPJO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x80D2500", Offset = "0x80D0F00", VA = "0x1880D2500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x80D28A0", Offset = "0x80D12A0", VA = "0x1880D28A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct AEJPOOOMBAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AAMJHGADFDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x80CC8C0", Offset = "0x80CB2C0", VA = "0x1880CC8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x80CCBA0", Offset = "0x80CB5A0", VA = "0x1880CCBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly HashSet<JBJOGAHMAOM> OFEFIODGCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private JPHHEIGPJJM IAEPFCBBPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private PCCGNKCANDF MIDBAICDLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private EHDIPKLOJDJ CNHFAJEFLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private IDisposable NMCCAGENGLG;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x80CA180", Offset = "0x80C8B80", VA = "0x1880CA180", Slot = "5")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x80CA120", Offset = "0x80C8B20", VA = "0x1880CA120", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x80CA040", Offset = "0x80C8A40", VA = "0x1880CA040", Slot = "4")]
	public bool BPBNJLDMHKI(JBJOGAHMAOM BJKLOELCDIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x80CA680", Offset = "0x80C9080", VA = "0x1880CA680")]
	private void HDAMPEFNAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x80CA460", Offset = "0x80C8E60", VA = "0x1880CA460")]
	private void ELNNLAGHCPO(IOPDENNAJIE COLBDAEGKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x80CAE10", Offset = "0x80C9810", VA = "0x1880CAE10")]
	[AsyncStateMachine(typeof(NNBMBFCKFDG))]
	private Task PMAPMMPHMDL(int HBOPDPPMOIM, OEADLBOEPJO HMEIOLJKGHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x80CA750", Offset = "0x80C9150", VA = "0x1880CA750")]
	private Func<CancellationToken, List<Task>> LOMPBPAAPJH(int HBOPDPPMOIM, OEADLBOEPJO HMEIOLJKGHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x80CA940", Offset = "0x80C9340", VA = "0x1880CA940")]
	private List<Task> NJKAECOEHKG(int HBOPDPPMOIM, OEADLBOEPJO HMEIOLJKGHH, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x80CA820", Offset = "0x80C9220", VA = "0x1880CA820")]
	[AsyncStateMachine(typeof(DPJKADIMOBH))]
	private Task MOJJIGIEKAK(JBJOGAHMAOM KLMNFDDHBMF, CancellationToken GNAAILLDOKI, int HBOPDPPMOIM, OEADLBOEPJO HMEIOLJKGHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x80C9F70", Offset = "0x80C8970", VA = "0x1880C9F70")]
	[AsyncStateMachine(typeof(AEJPOOOMBAI))]
	private Task AKLKFNEGGFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x80CA0A0", Offset = "0x80C8AA0", VA = "0x1880CA0A0")]
	private void DDDFCMLAOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x80CAF00", Offset = "0x80C9900", VA = "0x1880CAF00")]
	public AAMJHGADFDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[UnityEngine.Scripting.Preserve]
internal sealed class PNBBBPOCFNG : CGNEECPBPBC, HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class JMGDINOHJNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public JMGDINOHJNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x80DD430", Offset = "0x80DBE30", VA = "0x1880DD430")]
		internal object EBLBJGHCCFO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class KGDPPGIMNPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KGDPPGIMNPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x80DE510", Offset = "0x80DCF10", VA = "0x1880DE510")]
		internal object LBBAILKPHPK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class OAJNJJFENGN
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public OAJNJJFENGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class CMFKNLHKGKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CMFKNLHKGKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x80D1400", Offset = "0x80CFE00", VA = "0x1880D1400")]
		internal object NPLDMJHPGGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class MMKJKOAPMNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MMKJKOAPMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x80E17E0", Offset = "0x80E01E0", VA = "0x1880E17E0")]
		internal object PAFBLNLEOMC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private readonly Dictionary<Guid, FLLADLHLMAB> JFGGIHEHAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private readonly TimeSpan HBEGPJHGFIK;

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "9")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x80E6640", Offset = "0x80E5040", VA = "0x1880E6640", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x80E6650", Offset = "0x80E5050", VA = "0x1880E6650", Slot = "4")]
	public PAPDCOBPBIP HEHCILJMFIP(Guid HPBDKIENPJP)
	{
		return default(PAPDCOBPBIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x80E6430", Offset = "0x80E4E30", VA = "0x1880E6430", Slot = "5")]
	public bool CBCJJMKDJJC(Guid HPBDKIENPJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x80E6870", Offset = "0x80E5270", VA = "0x1880E6870", Slot = "6")]
	public bool ICOPLBMPMDH(Guid HPBDKIENPJP, Task AMMGCNPDJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x80E6E40", Offset = "0x80E5840", VA = "0x1880E6E40", Slot = "7")]
	public bool OKLPGEBADIH(Guid HPBDKIENPJP, NEGCEOCAIKD PGKINBLHCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x80E6DD0", Offset = "0x80E57D0", VA = "0x1880E6DD0", Slot = "8")]
	public Task<(NEGCEOCAIKD, Task)> MJOOCDCBLAG(Guid HPBDKIENPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x80E6BA0", Offset = "0x80E55A0", VA = "0x1880E6BA0")]
	private void IHMKHGFMFEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x80E7020", Offset = "0x80E5A20", VA = "0x1880E7020")]
	public PNBBBPOCFNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[RecRoom.NoEngine.Common.Preserve]
internal class BKAKAJJGMNG : NAMEGMCIFFD, HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class IOPFHPEDFGH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly JIFMHENFAOG NCOPEKOHGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly CancellationTokenSource DBBALKKKOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public readonly CancellationToken PLJNONKKEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private bool NCICILKJKDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private bool AGGPBOPKIOC;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x80DAD60", Offset = "0x80D9760", VA = "0x1880DAD60")]
		public IOPFHPEDFGH(JIFMHENFAOG NCOPEKOHGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x80DABE0", Offset = "0x80D95E0", VA = "0x1880DABE0")]
		public void DDDFCMLAOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x80DAD30", Offset = "0x80D9730", VA = "0x1880DAD30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class LLDAIHOBKNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public NNDKFANEGFP disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public LLDAIHOBKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x80E1530", Offset = "0x80DFF30", VA = "0x1880E1530")]
		internal object BFLCBAMFBOM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct KEKJLCHBEPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public NNDKFANEGFP disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public BKAKAJJGMNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x80DE060", Offset = "0x80DCA60", VA = "0x1880DE060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x80DE4B0", Offset = "0x80DCEB0", VA = "0x1880DE4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class IKEENFJKMLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public BKAKAJJGMNG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public IKEENFJKMLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x80DA3D0", Offset = "0x80D8DD0", VA = "0x1880DA3D0")]
		internal object POKPBNMJDJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class BKPINNJAAHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public JIFMHENFAOG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public IKEENFJKMLM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public BKPINNJAAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x80CFF20", Offset = "0x80CE920", VA = "0x1880CFF20")]
		internal object PBGMLOPAMGO((JIFMHENFAOG lastLocalPlayerRoomInstance, JIFMHENFAOG newRoomInstance, PKPOBPKHMHL fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct ACBDGNFGODA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public BKAKAJJGMNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private MBDDIOMLGLG <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x80CAF90", Offset = "0x80C9990", VA = "0x1880CAF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A10", Offset = "0x9F8410", VA = "0x1809F9A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class CHKHFANJJDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public JIFMHENFAOG newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CHKHFANJJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x80D0E90", Offset = "0x80CF890", VA = "0x1880D0E90")]
		internal object MNMMFEPPECF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x80D0E10", Offset = "0x80CF810", VA = "0x1880D0E10")]
		internal void JCCPONBFAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x80D0DD0", Offset = "0x80CF7D0", VA = "0x1880D0DD0")]
		internal object EBLBMOIMLNM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x80D0D90", Offset = "0x80CF790", VA = "0x1880D0D90")]
		internal object DEENAAKEHAM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct FCKFLJOFCOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public JIFMHENFAOG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public BKAKAJJGMNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public BEJEKGNNGMP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private CHKHFANJJDF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x80D44B0", Offset = "0x80D2EB0", VA = "0x1880D44B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x80D5460", Offset = "0x80D3E60", VA = "0x1880D5460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly OPDCBHOGMHJ.LGGCNHHKFOH DMEPAGFCKKE;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly ACPBANEOEIP JGBMKBCJHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private JPHHEIGPJJM IAEPFCBBPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private PKPOBPKHMHL CHFJNDNOJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private POHGOIGKOME MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private PPLNHPJCIPO MOAPPBPCBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private OHNHALKFFPG DAMHMAEMIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private JIFMHENFAOG IFFAKOEIPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private IOPFHPEDFGH JMOMGNFEPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private bool LKDJHDDNGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Task ADMAIOPHPPI;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private FGCPAINBMOO ELGBICGFGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x80CEC40", Offset = "0x80CD640", VA = "0x1880CEC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool NKEDNNALLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xC02F10", Offset = "0xC01910", VA = "0x180C02F10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x80CF470", Offset = "0x80CDE70", VA = "0x1880CF470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x80CEE50", Offset = "0x80CD850", VA = "0x1880CEE50", Slot = "4")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x80CECE0", Offset = "0x80CD6E0", VA = "0x1880CECE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x80CF480", Offset = "0x80CDE80", VA = "0x1880CF480")]
	[AsyncStateMachine(typeof(KEKJLCHBEPG))]
	private Task MDBHFMDDBBN(NNDKFANEGFP CCEADGNEFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x80CF700", Offset = "0x80CE100", VA = "0x1880CF700")]
	private void OJCDCBGKLFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x80CF570", Offset = "0x80CDF70", VA = "0x1880CF570")]
	private void OBIPELODNGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x80CF0F0", Offset = "0x80CDAF0", VA = "0x1880CF0F0")]
	private void EPLBFFLANLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x80CEBD0", Offset = "0x80CD5D0", VA = "0x1880CEBD0")]
	private bool BJGKCKIPKJF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x80CF3A0", Offset = "0x80CDDA0", VA = "0x1880CF3A0")]
	[AsyncStateMachine(typeof(ACBDGNFGODA))]
	private void IOCMIFBKJBI(int LNFLFPBOJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x80CF890", Offset = "0x80CE290", VA = "0x1880CF890")]
	private void PICLPCFBLFI([Out] IDisposable GCEFHPJCPLI, [Out] IDisposable BONCAEMNHNL, [Out] IDisposable MNIGGGDCOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x80CEAD0", Offset = "0x80CD4D0", VA = "0x1880CEAD0")]
	private bool ALIELFIKOMO(JIFMHENFAOG NCOPEKOHGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x80CEC90", Offset = "0x80CD690", VA = "0x1880CEC90")]
	private void CPCINJAOCNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x80CF270", Offset = "0x80CDC70", VA = "0x1880CF270")]
	[AsyncStateMachine(typeof(FCKFLJOFCOO))]
	private Task FDOANPEDJMI(JIFMHENFAOG NCOPEKOHGLP, BEJEKGNNGMP PONDNJALBLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x80CFEB0", Offset = "0x80CE8B0", VA = "0x1880CFEB0")]
	public BKAKAJJGMNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[UnityEngine.Scripting.Preserve]
internal sealed class JAMPFEINPOA : JPGBMGNCJFF, HNKIOMKDACP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct NMGAAMHFGBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<BJBMIMDMIDH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public JAMPFEINPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<BJBMIMDMIDH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x80E4610", Offset = "0x80E3010", VA = "0x1880E4610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x80E48A0", Offset = "0x80E32A0", VA = "0x1880E48A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class PBPPAENBHBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public GGFPIKADCDI message;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public PBPPAENBHBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x80E5D30", Offset = "0x80E4730", VA = "0x1880E5D30")]
		internal object NLKDKHLNNEJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class NANAPHHOHNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public GGFPIKADCDI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NANAPHHOHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x80E3430", Offset = "0x80E1E30", VA = "0x1880E3430")]
		internal object GMNEGEBGAMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class LCFKAHCNPBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public GGFPIKADCDI request;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public LCFKAHCNPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x80DFC90", Offset = "0x80DE690", VA = "0x1880DFC90")]
		internal object MCJHCCFBKCP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct IFJDNFMLCFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public GGFPIKADCDI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public JAMPFEINPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<EDDPLOEGLIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x80D9A00", Offset = "0x80D8400", VA = "0x1880D9A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x80DA2D0", Offset = "0x80D8CD0", VA = "0x1880DA2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class BLEAIGFBMGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public GGFPIKADCDI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public BLEAIGFBMGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x80CFFE0", Offset = "0x80CE9E0", VA = "0x1880CFFE0")]
		internal object MEGCNNIMMMN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct KBFLFKONDFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public GGFPIKADCDI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public JAMPFEINPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private ONJGKIHMNBI <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<GGFPIKADCDI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x80DD490", Offset = "0x80DBE90", VA = "0x1880DD490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x80DE000", Offset = "0x80DCA00", VA = "0x1880DE000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct JAMEEKACIDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder<EDDPLOEGLIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public JAMPFEINPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public GGFPIKADCDI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private MENMGLNLGAP.KDFNCIOLHHK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private ONJGKIHMNBI <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter<GGFPIKADCDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x80DAE10", Offset = "0x80D9810", VA = "0x1880DAE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x80DB340", Offset = "0x80D9D40", VA = "0x1880DB340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class FLMOOCPLHBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public EDDPLOEGLIE operation;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public FLMOOCPLHBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x80D63B0", Offset = "0x80D4DB0", VA = "0x1880D63B0")]
		internal object IPLBADLOANM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct GMGPIPAFDAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public EDDPLOEGLIE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public JAMPFEINPOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private NCPOPMIDADO<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x80D74F0", Offset = "0x80D5EF0", VA = "0x1880D74F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x80D7B30", Offset = "0x80D6530", VA = "0x1880D7B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class PDMPKLBIKOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public GGFPIKADCDI request;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public PDMPKLBIKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x80E5D90", Offset = "0x80E4790", VA = "0x1880E5D90")]
		internal object NAFBBEKGFNH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class PHBPOHFICHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public GGFPIKADCDI request;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public PHBPOHFICHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x80E63D0", Offset = "0x80E4DD0", VA = "0x1880E63D0")]
		internal object KLCPGHJOMPN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private MPPOGMBIPDB POCJIBOPFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private DPAMGLAJFKB BHLAAOMLLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private ADCJFBBIPFA ELODDEKFOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private MFOOBEAIMGO HFDCCFJAOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private TaskCompletionSource<BJBMIMDMIDH> AMBFMOJJMIH;

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x80DBAF0", Offset = "0x80DA4F0", VA = "0x1880DBAF0", Slot = "7")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x80DBBE0", Offset = "0x80DA5E0", VA = "0x1880DBBE0", Slot = "6")]
	[AsyncStateMachine(typeof(NMGAAMHFGBA))]
	public Task<BJBMIMDMIDH> GEOIIGOOLMN(CancellationToken LBPNPDGAHFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x80DB4C0", Offset = "0x80D9EC0", VA = "0x1880DB4C0", Slot = "4")]
	public void CHPDJJDBHLK(GGFPIKADCDI FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x80DBF50", Offset = "0x80DA950", VA = "0x1880DBF50", Slot = "5")]
	public void KMIHKBNCHCK(GGFPIKADCDI FCMAMPMNABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x80DBE40", Offset = "0x80DA840", VA = "0x1880DBE40")]
	[AsyncStateMachine(typeof(IFJDNFMLCFK))]
	private Task JNLDMKNICPP(GGFPIKADCDI EELGNOJLLOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x80DB3B0", Offset = "0x80D9DB0", VA = "0x1880DB3B0")]
	[AsyncStateMachine(typeof(KBFLFKONDFB))]
	private Task AJMOPDFHJNA(GGFPIKADCDI IKIPPMBFJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x80DBCF0", Offset = "0x80DA6F0", VA = "0x1880DBCF0")]
	[AsyncStateMachine(typeof(JAMEEKACIDI))]
	private Task<EDDPLOEGLIE> JKGBJAIDBLJ(GGFPIKADCDI EELGNOJLLOB, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x80DBA60", Offset = "0x80DA460", VA = "0x1880DBA60")]
	private ONJGKIHMNBI DJGJFKCCMGE(GGFPIKADCDI MDBNAHHGCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x80DC640", Offset = "0x80DB040", VA = "0x1880DC640")]
	[AsyncStateMachine(typeof(GMGPIPAFDAN))]
	private Task PEECICIIMKD(EDDPLOEGLIE AJHDOLGFFAB, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x80DB850", Offset = "0x80DA250", VA = "0x1880DB850")]
	private EDDPLOEGLIE DDJOODKEMEJ(GGFPIKADCDI EELGNOJLLOB, ONJGKIHMNBI EEAGJEEABFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x36D1940", Offset = "0x36D0340", VA = "0x1836D1940")]
	private T PGDFIGNMDAI<T>(T PPJFMHBDGNA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x80DC2B0", Offset = "0x80DACB0", VA = "0x1880DC2B0")]
	private EDDPLOEGLIE MGJILMJBNPA(GGFPIKADCDI EELGNOJLLOB, ONJGKIHMNBI EEAGJEEABFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public JAMPFEINPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class HJGECJBMEIO : DPAMGLAJFKB, HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class EKOCFFAKGDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EKOCFFAKGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x80D3810", Offset = "0x80D2210", VA = "0x1880D3810")]
		internal object CGJJBJCJIAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class CHBIOCKEOBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CHBIOCKEOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x80D0D20", Offset = "0x80CF720", VA = "0x1880D0D20")]
		internal object HDOHNFEKEGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private MFOOBEAIMGO HFDCCFJAOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private FLECLOLLKJG JEKHNDIDNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private JPGBMGNCJFF BANNANAFLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private CGNEECPBPBC JFGGIHEHAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private BOEFIADFECB GLCOMMBLGMF;

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x80D82D0", Offset = "0x80D6CD0", VA = "0x1880D82D0", Slot = "6")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x80D8220", Offset = "0x80D6C20", VA = "0x1880D8220", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x80D95E0", Offset = "0x80D7FE0", VA = "0x1880D95E0", Slot = "4")]
	public PAPDCOBPBIP PCKJJMHEGBN(GGFPIKADCDI KGKMMIMKBFB)
	{
		return default(PAPDCOBPBIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x80D8AE0", Offset = "0x80D74E0", VA = "0x1880D8AE0", Slot = "5")]
	public void IOMKDBKNFFJ(Guid HPBDKIENPJP, Task AMMGCNPDJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x80D8F90", Offset = "0x80D7990", VA = "0x1880D8F90")]
	private void MLKOHFILHJJ(byte OPGMLCDKFBP, int LLAJFFDLBMG, object KOLMHPDIAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x80D9060", Offset = "0x80D7A60", VA = "0x1880D9060")]
	private void NOHKLAOPNFP(LMJBLNOKKAA GLECKDJIKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x80D8440", Offset = "0x80D6E40", VA = "0x1880D8440")]
	private void FALPPLDCOBG(LMJBLNOKKAA GLECKDJIKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x80D88A0", Offset = "0x80D72A0", VA = "0x1880D88A0")]
	private void HNMMMKNKHIJ(LMJBLNOKKAA GLECKDJIKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x80D8CF0", Offset = "0x80D76F0", VA = "0x1880D8CF0")]
	private NEGCEOCAIKD KKIFNFJLBKC(GGFPIKADCDI MDBNAHHGCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x80D7DA0", Offset = "0x80D67A0", VA = "0x1880D7DA0")]
	private void CNNPBOJKAHI(GGFPIKADCDI IKIPPMBFJNC, NEGCEOCAIKD PGKINBLHCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x80D86C0", Offset = "0x80D70C0", VA = "0x1880D86C0")]
	private bool FAPECNIJPDC(GGFPIKADCDI IKIPPMBFJNC, NEGCEOCAIKD PGKINBLHCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x80D7B90", Offset = "0x80D6590", VA = "0x1880D7B90")]
	private bool ABMEDIDCBGA(GGFPIKADCDI EOMNDHGJLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x80D7FA0", Offset = "0x80D69A0", VA = "0x1880D7FA0")]
	private bool CPFJIOKCLFB(byte OPGMLCDKFBP, ExitGames.Client.Photon.Hashtable GLECKDJIKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public HJGECJBMEIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class FBCLLMCHNGD : CCKGDCAJAJC, HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class JDMEGLKLHHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public BJBMIMDMIDH operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public FBCLLMCHNGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public GGFPIKADCDI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public JDMEGLKLHHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x80DC760", Offset = "0x80DB160", VA = "0x1880DC760")]
		internal object JMBFMIAIMLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x80DC7D0", Offset = "0x80DB1D0", VA = "0x1880DC7D0")]
		internal object PJPCGBPDBJJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct CCOBCEAEIMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AsyncTaskMethodBuilder<NEGCEOCAIKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public FBCLLMCHNGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public GGFPIKADCDI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter<NEGCEOCAIKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x80D0040", Offset = "0x80CEA40", VA = "0x1880D0040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x80D06E0", Offset = "0x80CF0E0", VA = "0x1880D06E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class FBIDBAAHOHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public BJBMIMDMIDH operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public FBIDBAAHOHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x80D4440", Offset = "0x80D2E40", VA = "0x1880D4440")]
		internal object KOEKAFCNAOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class KONKOMHCMIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public GGFPIKADCDI request;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KONKOMHCMIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x80DFBB0", Offset = "0x80DE5B0", VA = "0x1880DFBB0")]
		internal object EEIKLFMIKCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x80DFB40", Offset = "0x80DE540", VA = "0x1880DFB40")]
		internal object DHNNDNBENPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x80DFC20", Offset = "0x80DE620", VA = "0x1880DFC20")]
		internal object EGNLMEFFHAE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct FMKDCGGKMAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<NEGCEOCAIKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public GGFPIKADCDI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public FBCLLMCHNGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private KONKOMHCMIG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private PAPDCOBPBIP <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private NEGCEOCAIKD <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<(NEGCEOCAIKD validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x80D6430", Offset = "0x80D4E30", VA = "0x1880D6430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x80D6D00", Offset = "0x80D5700", VA = "0x1880D6D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private MFOOBEAIMGO HFDCCFJAOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private FLECLOLLKJG JEKHNDIDNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private DPAMGLAJFKB BHLAAOMLLON;

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x80D3F40", Offset = "0x80D2940", VA = "0x1880D3F40", Slot = "5")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x80D4320", Offset = "0x80D2D20", VA = "0x1880D4320", Slot = "4")]
	[AsyncStateMachine(typeof(CCOBCEAEIMI))]
	private Task<NEGCEOCAIKD> OFJHIGGPANF(GGFPIKADCDI MDBNAHHGCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x80D4130", Offset = "0x80D2B30", VA = "0x1880D4130")]
	private bool HGLMCFJGLGN(BJBMIMDMIDH NPBKJOPAEBM, [Out] NEGCEOCAIKD FFBEKAFHIDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x80D3FF0", Offset = "0x80D29F0", VA = "0x1880D3FF0")]
	[AsyncStateMachine(typeof(FMKDCGGKMAM))]
	private Task<NEGCEOCAIKD> FMPGMCHGFBP(GGFPIKADCDI EELGNOJLLOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public FBCLLMCHNGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class AGLPBODOANJ : FHIJNBOPDFL, HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private struct IFEPPLHIPFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public LPGDPINKOBL FAJBPIMPDAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public long PBPJPNKHCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Guid? OFHKBLCACBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public bool GECKGBPPCCP;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct KLIBOJGBCNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<LGCLIBGOJHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public AGLPBODOANJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter<AKGPNEALNMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<LGCLIBGOJHL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x80DF500", Offset = "0x80DDF00", VA = "0x1880DF500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x80DFAD0", Offset = "0x80DE4D0", VA = "0x1880DFAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class DMNIMHPADEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public DMNIMHPADEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x80D2450", Offset = "0x80D0E50", VA = "0x1880D2450")]
		internal object IEGEPJHPPDK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct AFOJJPJDGIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<AKGPNEALNMD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AGLPBODOANJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private DMNIMHPADEM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter<AKGPNEALNMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x80CCC00", Offset = "0x80CB600", VA = "0x1880CCC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x80CD1F0", Offset = "0x80CBBF0", VA = "0x1880CD1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct PELCHGPGOFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<LGCLIBGOJHL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public AGLPBODOANJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public AKGPNEALNMD roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<IFEPPLHIPFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x80E5DF0", Offset = "0x80E47F0", VA = "0x1880E5DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x80E6360", Offset = "0x80E4D60", VA = "0x1880E6360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class MEBDAEIEDEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public AKGPNEALNMD roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MEBDAEIEDEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xDC9CB0", Offset = "0xDC86B0", VA = "0x180DC9CB0")]
		internal bool OBIDCEPGDCD(HPIALGGGMCA sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x80E1650", Offset = "0x80E0050", VA = "0x1880E1650")]
		internal object FKEHMGGOGOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x80E1710", Offset = "0x80E0110", VA = "0x1880E1710")]
		internal object NIFPFCGLMLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x80E15C0", Offset = "0x80DFFC0", VA = "0x1880E15C0")]
		internal object AMCBKFNCFFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class GDIIDBKFJFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public MEBDAEIEDEG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public GDIIDBKFJFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x80D6D70", Offset = "0x80D5770", VA = "0x1880D6D70")]
		internal object ILBBLAILGPF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct MPJJDEMLANH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder<IFEPPLHIPFN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public AKGPNEALNMD roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AGLPBODOANJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public JIFMHENFAOG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private GDIIDBKFJFA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter<IFEPPLHIPFN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<FLOHMIGBGEM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x80E2430", Offset = "0x80E0E30", VA = "0x1880E2430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x80E33C0", Offset = "0x80E1DC0", VA = "0x1880E33C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class EHLLIPDNCPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EHLLIPDNCPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x80D3760", Offset = "0x80D2160", VA = "0x1880D3760")]
		internal object CBAJOHACFOE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct KJLACFOGMFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder<IFEPPLHIPFN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public HPIALGGGMCA subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public AGLPBODOANJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public JIFMHENFAOG dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private EHLLIPDNCPI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private TaskAwaiter<PENJFAOFOEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x80DEDD0", Offset = "0x80DD7D0", VA = "0x1880DEDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x80DF490", Offset = "0x80DDE90", VA = "0x1880DF490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private POHGOIGKOME MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private PPLNHPJCIPO MOAPPBPCBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private KNMHECKNPBE AOHCLGOMJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private ENACNLJLDID FABMNHNMFIN;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x80CD3D0", Offset = "0x80CBDD0", VA = "0x1880CD3D0", Slot = "5")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x80CD630", Offset = "0x80CC030", VA = "0x1880CD630", Slot = "4")]
	[AsyncStateMachine(typeof(KLIBOJGBCNM))]
	public Task<LGCLIBGOJHL> JIBAGIKOPDE(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, JIFMHENFAOG AFMDHCINNJF, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x80CD900", Offset = "0x80CC300", VA = "0x1880CD900")]
	[AsyncStateMachine(typeof(AFOJJPJDGIG))]
	private Task<AKGPNEALNMD> NLAGAGODLCD(JIFMHENFAOG AFMDHCINNJF, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x80CD4C0", Offset = "0x80CBEC0", VA = "0x1880CD4C0")]
	[AsyncStateMachine(typeof(PELCHGPGOFB))]
	private Task<LGCLIBGOJHL> GNECPOKOOJE(JIFMHENFAOG AFMDHCINNJF, AKGPNEALNMD ABDKGJKIOJH, long OAJKHGNBEDJ, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x80CD260", Offset = "0x80CBC60", VA = "0x1880CD260")]
	[AsyncStateMachine(typeof(MPJJDEMLANH))]
	private Task<IFEPPLHIPFN> AHINEEBCDNP(JIFMHENFAOG AFMDHCINNJF, AKGPNEALNMD ABDKGJKIOJH, long OAJKHGNBEDJ, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x80CD790", Offset = "0x80CC190", VA = "0x1880CD790")]
	[AsyncStateMachine(typeof(KJLACFOGMFO))]
	private Task<IFEPPLHIPFN> MHMKJMOJHKD(JIFMHENFAOG DGNOOEKHPGP, HPIALGGGMCA DKCLKEFINPN, long OAJKHGNBEDJ, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public AGLPBODOANJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[UnityEngine.Scripting.Preserve]
internal sealed class FJPODGEGDFE : ADCJFBBIPFA, HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class BGCHIADBOJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public GGFPIKADCDI request;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public BGCHIADBOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x80CDA60", Offset = "0x80CC460", VA = "0x1880CDA60")]
		internal object MOPBLAOAHII()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct GDMALELPCDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<GGFPIKADCDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public GGFPIKADCDI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public FJPODGEGDFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public ONJGKIHMNBI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter<GGFPIKADCDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x80D6E70", Offset = "0x80D5870", VA = "0x1880D6E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x80D7480", Offset = "0x80D5E80", VA = "0x1880D7480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct EOIHLFGAFKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder<GGFPIKADCDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public FJPODGEGDFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public ONJGKIHMNBI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter<MIAMCFGNIEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x80D38E0", Offset = "0x80D22E0", VA = "0x1880D38E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x80D3ED0", Offset = "0x80D28D0", VA = "0x1880D3ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class EMBIHHJMEMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public GGFPIKADCDI request;

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EMBIHHJMEMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x80D3880", Offset = "0x80D2280", VA = "0x1880D3880")]
		internal object NDMNICLDDNK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct EDELCBCNGFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<GGFPIKADCDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public GGFPIKADCDI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public FJPODGEGDFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public ONJGKIHMNBI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private CHKCIPMCHBG <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private PFOGPKEMACM <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<MIAMCFGNIEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x80D2B00", Offset = "0x80D1500", VA = "0x1880D2B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x80D36F0", Offset = "0x80D20F0", VA = "0x1880D36F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private MFOOBEAIMGO HFDCCFJAOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private LGJGOBGLPCF NHBGNCKJKMO;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private ANKDDIPDILL KIDCBFGDFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x80D5A30", Offset = "0x80D4430", VA = "0x1880D5A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x80D5710", Offset = "0x80D4110", VA = "0x1880D5710", Slot = "8")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x80D5500", Offset = "0x80D3F00", VA = "0x1880D5500", Slot = "4")]
	[AsyncStateMachine(typeof(GDMALELPCDD))]
	public Task<GGFPIKADCDI> ADKLMNIIFOF(GGFPIKADCDI EELGNOJLLOB, ONJGKIHMNBI EEAGJEEABFN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x80D5AF0", Offset = "0x80D44F0", VA = "0x1880D5AF0", Slot = "5")]
	[AsyncStateMachine(typeof(EOIHLFGAFKA))]
	public Task<GGFPIKADCDI> PGLNHEOAGGM(CancellationToken BJEPDCCBCHJ, ONJGKIHMNBI EEAGJEEABFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x80D5660", Offset = "0x80D4060", VA = "0x1880D5660", Slot = "6")]
	public EDFKMNECCFB COJGOIJDDDN(EDDPLOEGLIE LPECPFJMBIM, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x80D5900", Offset = "0x80D4300", VA = "0x1880D5900", Slot = "7")]
	public EDFKMNECCFB KPJMNCPDNDJ(EDDPLOEGLIE LPECPFJMBIM, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x80D57A0", Offset = "0x80D41A0", VA = "0x1880D57A0")]
	[AsyncStateMachine(typeof(EDELCBCNGFH))]
	private Task<GGFPIKADCDI> GCKMOBPFAKK(GGFPIKADCDI EELGNOJLLOB, ONJGKIHMNBI EEAGJEEABFN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x34B5CF0", Offset = "0x34B46F0", VA = "0x1834B5CF0")]
	private static byte[] MGNHNKOFCAO(GGFPIKADCDI FLPDJFEEMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public FJPODGEGDFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[UnityEngine.Scripting.Preserve]
internal sealed class CGGBLJHIHLD : FLECLOLLKJG, HNKIOMKDACP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private CJGBCFNIGFE JNBBFPHPMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private MFOOBEAIMGO HFDCCFJAOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private MPPOGMBIPDB POCJIBOPFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private MKLJNDDOMLB GNFHOCNHKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private POHGOIGKOME MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private OHNHALKFFPG DAMHMAEMIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private HJNAJNAOIBC NLHFIDPIHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private PPLNHPJCIPO MOAPPBPCBJG;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private FGCPAINBMOO ELGBICGFGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x80D0750", Offset = "0x80CF150", VA = "0x1880D0750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static NEGCEOCAIKD LIBNPHEFPNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x80D0910", Offset = "0x80CF310", VA = "0x1880D0910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x80D07A0", Offset = "0x80CF1A0", VA = "0x1880D07A0", Slot = "6")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x80D0930", Offset = "0x80CF330", VA = "0x1880D0930", Slot = "4")]
	public NEGCEOCAIKD NKEOIFMLJEI(BKBJMNKBOED DNIJCDKNNHH, BJBMIMDMIDH LIJCMODMOKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x80D0AA0", Offset = "0x80CF4A0", VA = "0x1880D0AA0", Slot = "5")]
	public NEGCEOCAIKD NNIKLEGNDPO(BKBJMNKBOED LEJLBFMKAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x80D0920", Offset = "0x80CF320", VA = "0x1880D0920")]
	private static NEGCEOCAIKD KFALPCPAIMM(PLOMDEGLFHP NBAKHABPJGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public CGGBLJHIHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class MHGNLKHFOAL : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x80E17A0", Offset = "0x80E01A0", VA = "0x1880E17A0")]
	public MHGNLKHFOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x735B680", Offset = "0x735A080", VA = "0x18735B680")]
	public MHGNLKHFOAL(string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class BJPEBAOEPHE : FHKNJJPAONB, HNKIOMKDACP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct NFBGJDOJFHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder<NEGCEOCAIKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public BJPEBAOEPHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public IMLDBGJKKIJ autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private NCPOPMIDADO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private HLFNPIALBNE <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private TaskAwaiter<NEGCEOCAIKD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x80E3510", Offset = "0x80E1F10", VA = "0x1880E3510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x80E4050", Offset = "0x80E2A50", VA = "0x1880E4050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct OAEEAKJNEOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public BJPEBAOEPHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x80E4E50", Offset = "0x80E3850", VA = "0x1880E4E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x80E5590", Offset = "0x80E3F90", VA = "0x1880E5590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct OMEOCMPENNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public BJPEBAOEPHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x80E55F0", Offset = "0x80E3FF0", VA = "0x1880E55F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x80E5B00", Offset = "0x80E4500", VA = "0x1880E5B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct CNPHDBAENKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public BJPEBAOEPHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x80D1460", Offset = "0x80CFE60", VA = "0x1880D1460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x80D1BA0", Offset = "0x80D05A0", VA = "0x1880D1BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct EDBKFMKNFAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public BJPEBAOEPHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x80D2900", Offset = "0x80D1300", VA = "0x1880D2900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x80D2AA0", Offset = "0x80D14A0", VA = "0x1880D2AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct FKJDPOGDIDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public BJPEBAOEPHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x80D5C40", Offset = "0x80D4640", VA = "0x1880D5C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x80D6350", Offset = "0x80D4D50", VA = "0x1880D6350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct CINBIMDPICH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public BJPEBAOEPHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x80D0F30", Offset = "0x80CF930", VA = "0x1880D0F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x80D13A0", Offset = "0x80CFDA0", VA = "0x1880D13A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct OCJMLNAAAEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public BJPEBAOEPHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public CGNALMMEIDH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private NCPOPMIDADO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x80FE730", Offset = "0x80FD130", VA = "0x1880FE730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x80FECD0", Offset = "0x80FD6D0", VA = "0x1880FECD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private MFOOBEAIMGO HFDCCFJAOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private POHGOIGKOME MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private ADCJFBBIPFA ELODDEKFOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private MPPOGMBIPDB POCJIBOPFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private HJNAJNAOIBC NLHFIDPIHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private CancellationTokenSource OEJEHAJMAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private Task ILGFKNJIOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private TaskCompletionSource<int> JEMIALICHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private int IKHAAAMBBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private int LFIECDHNBFN;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x80CDBC0", Offset = "0x80CC5C0", VA = "0x1880CDBC0", Slot = "6")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x11EFFF0", Offset = "0x11EE9F0", VA = "0x1811EFFF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x80CDD70", Offset = "0x80CC770", VA = "0x1880CDD70")]
	private void FHKHNKOEEMA(float LADHPONLBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x80CE1C0", Offset = "0x80CCBC0", VA = "0x1880CE1C0", Slot = "4")]
	[AsyncStateMachine(typeof(NFBGJDOJFHO))]
	public Task<NEGCEOCAIKD> IKLLMAGPMIG(IMLDBGJKKIJ OOOILNKOICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x80CE3E0", Offset = "0x80CCDE0", VA = "0x1880CE3E0", Slot = "5")]
	[AsyncStateMachine(typeof(OAEEAKJNEOA))]
	public Task KAKOIGPBINN([Optional] CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x11EFFF0", Offset = "0x11EE9F0", VA = "0x1811EFFF0")]
	public void LBAIKAMKHBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x80CE5C0", Offset = "0x80CCFC0", VA = "0x1880CE5C0")]
	private HLFNPIALBNE LOGMEENIPEB(IMLDBGJKKIJ OOOILNKOICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x80CE2F0", Offset = "0x80CCCF0", VA = "0x1880CE2F0")]
	[AsyncStateMachine(typeof(OMEOCMPENNF))]
	private Task JBLMPEMHEAA(CancellationToken OJOOKCOCPDF, int HBOPDPPMOIM, OEADLBOEPJO HMEIOLJKGHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x80CDAC0", Offset = "0x80CC4C0", VA = "0x1880CDAC0")]
	[AsyncStateMachine(typeof(CNPHDBAENKP))]
	private Task CNEOLFHCKEF(CancellationToken OJOOKCOCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x80CE4D0", Offset = "0x80CCED0", VA = "0x1880CE4D0")]
	[AsyncStateMachine(typeof(EDBKFMKNFAJ))]
	private Task KCEFMPHFFKP([Optional] CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x80CE0D0", Offset = "0x80CCAD0", VA = "0x1880CE0D0")]
	[AsyncStateMachine(typeof(FKJDPOGDIDE))]
	private Task IACGPALMLDK(CancellationToken OJOOKCOCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x80CE730", Offset = "0x80CD130", VA = "0x1880CE730")]
	[AsyncStateMachine(typeof(CINBIMDPICH))]
	private Task MFEOAFIKNKC(CancellationToken OFDNAKKPMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x80CE830", Offset = "0x80CD230", VA = "0x1880CE830")]
	private Task NCGCNAKLMDE(CGNALMMEIDH NIFJJAHBNLC, CancellationToken OJOOKCOCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x80CE9C0", Offset = "0x80CD3C0", VA = "0x1880CE9C0")]
	[AsyncStateMachine(typeof(OCJMLNAAAEF))]
	private Task OLIPBBPHNLN(CGNALMMEIDH NIFJJAHBNLC, CancellationToken OJOOKCOCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x80CDE50", Offset = "0x80CC850", VA = "0x1880CDE50")]
	private bool GHLLDDNMCIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public BJPEBAOEPHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[UnityEngine.Scripting.Preserve]
internal class AGLNHEEMJAM : MKLJNDDOMLB, HNKIOMKDACP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct FBMILHJHILM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public AGLNHEEMJAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private NCPOPMIDADO<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x80F1110", Offset = "0x80EFB10", VA = "0x1880F1110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x80F16D0", Offset = "0x80F00D0", VA = "0x1880F16D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private OKAHAIKEOBG GCJOJDBJOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private FLECLOLLKJG JEKHNDIDNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private ADCJFBBIPFA ELODDEKFOOP;

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x80E8210", Offset = "0x80E6C10", VA = "0x1880E8210", Slot = "6")]
	public void ELAEPFFNBKM(HLJANHOBGDO DHMLBLBOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x80E8080", Offset = "0x80E6A80", VA = "0x1880E8080", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x80E7F80", Offset = "0x80E6980", VA = "0x1880E7F80", Slot = "5")]
	[AsyncStateMachine(typeof(FBMILHJHILM))]
	public Task AFEGBIDHKEL(string LMJJJIGEFFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x80E84F0", Offset = "0x80E6EF0", VA = "0x1880E84F0", Slot = "4")]
	public NEGCEOCAIKD GHLLDDNMCIH(BKBJMNKBOED DNIJCDKNNHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x80E80D0", Offset = "0x80E6AD0", VA = "0x1880E80D0")]
	private HKHBBAIABLL EFDIKLCGODJ(string LMJJJIGEFFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public AGLNHEEMJAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class BLCFNJGNFBI
{
	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x80E9460", Offset = "0x80E7E60", VA = "0x1880E9460")]
	public static void HLBNMPIBGAK(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x80E9220", Offset = "0x80E7C20", VA = "0x1880E9220")]
	internal static void CFAGDPFKMOF(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x80E9380", Offset = "0x80E7D80", VA = "0x1880E9380")]
	internal static void GHFOIJMIKCJ(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x80E96A0", Offset = "0x80E80A0", VA = "0x1880E96A0")]
	internal static void KIILNBHPBJC(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x33B9510", Offset = "0x33B7F10", VA = "0x1833B9510")]
	private static void JKMDMLMCAJO<Interface, Impl, Interface>(LKOLOODKMPF MCJDMILNGAL) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class LDDKLDPADPA : FEMIFHBINPN<GGFPIKADCDI>
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class CMPIIPIKOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public GGFPIKADCDI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CMPIIPIKOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x80ED010", Offset = "0x80EBA10", VA = "0x1880ED010")]
		internal object POFMCKEDNFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly LDDKLDPADPA LALLOKGAEJH;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x80F7130", Offset = "0x80F5B30", VA = "0x1880F7130")]
	public ExitGames.Client.Photon.Hashtable CFLEALCFLNK(GGFPIKADCDI FLPDJFEEMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x80F77A0", Offset = "0x80F61A0", VA = "0x1880F77A0", Slot = "5")]
	protected override void JHNIFLJNLPI(GGFPIKADCDI FLPDJFEEMLN, IDictionary<object, object> DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x80F7460", Offset = "0x80F5E60", VA = "0x1880F7460", Slot = "6")]
	public override GGFPIKADCDI DHOLDBOACBA(IDictionary<object, object> DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x80F7690", Offset = "0x80F6090", VA = "0x1880F7690")]
	private static void HIMKLMLGBHH(string AOJHJIACIOB, GGFPIKADCDI FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x80F7960", Offset = "0x80F6360", VA = "0x1880F7960")]
	public LDDKLDPADPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x80F71C0", Offset = "0x80F5BC0", VA = "0x1880F71C0")]
	[CompilerGenerated]
	internal static string CFOGHMOEKJH(LGCLIBGOJHL ECGNDACMANN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class BCCPPKDLHND
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static NEGCEOCAIKD LIBNPHEFPNH
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x80E8A70", Offset = "0x80E7470", VA = "0x1880E8A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x80E8A50", Offset = "0x80E7450", VA = "0x1880E8A50")]
	public static bool FKHCEFIKECJ(this NEGCEOCAIKD PGKINBLHCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x80E8AD0", Offset = "0x80E74D0", VA = "0x1880E8AD0")]
	public static NEGCEOCAIKD KFALPCPAIMM(PLOMDEGLFHP HJEACPJALDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x80E8860", Offset = "0x80E7260", VA = "0x1880E8860")]
	public static NEGCEOCAIKD BFOJNLDGJPP(IEnumerable<NEGCEOCAIKD> FLJMBGADMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x80E8B30", Offset = "0x80E7530", VA = "0x1880E8B30")]
	public static string KFGGFHDDOBL(this NEGCEOCAIKD FFBEKAFHIDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class OAFJONMHING : DLJIKEBIKOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public delegate NEGCEOCAIKD JONKPACCOFH([NotNull] BKBJMNKBOED ODHONNAHCDC);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class EPGLMIHMJHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public BKBJMNKBOED photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EPGLMIHMJHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x148C9E0", Offset = "0x148B3E0", VA = "0x18148C9E0")]
		internal NEGCEOCAIKD HCNDNJBFCFD(JONKPACCOFH v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private bool FIMHNIKAAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	protected readonly HashSet<JONKPACCOFH> LBFAJGGKGNB;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x80FE240", Offset = "0x80FCC40", VA = "0x1880FE240", Slot = "4")]
	public void FFMBGEPILAD(JONKPACCOFH PMPEFPLKPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x80FE2A0", Offset = "0x80FCCA0", VA = "0x1880FE2A0", Slot = "5")]
	public void HNACFNOCLCH(JONKPACCOFH PMPEFPLKPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x80FE1F0", Offset = "0x80FCBF0", VA = "0x1880FE1F0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x80FDF60", Offset = "0x80FC960", VA = "0x1880FDF60")]
	protected NEGCEOCAIKD CKKEHJPFOIE(BKBJMNKBOED LEJLBFMKAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x80FE300", Offset = "0x80FCD00", VA = "0x1880FE300")]
	protected OAFJONMHING()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class EGAOHIBCJCP : OAFJONMHING, CJGBCFNIGFE, DLJIKEBIKOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class PNKEHICGNKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public NEGCEOCAIKD result;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public PNKEHICGNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8103330", Offset = "0x8101D30", VA = "0x188103330")]
		internal object MNBIEEHHNAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x80EFC90", Offset = "0x80EE690", VA = "0x1880EFC90")]
	[UnityEngine.Scripting.Preserve]
	public EGAOHIBCJCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x80EFB80", Offset = "0x80EE580", VA = "0x1880EFB80", Slot = "8")]
	public NEGCEOCAIKD IGKPGOBBNEK(BKBJMNKBOED LEJLBFMKAOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class MDNIOINDGPB : OAFJONMHING, OKAHAIKEOBG, DLJIKEBIKOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class MNNPFIMGKEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public NEGCEOCAIKD result;

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MNNPFIMGKEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x80FCE80", Offset = "0x80FB880", VA = "0x1880FCE80")]
		internal object GKLALIICOGB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x80EFC90", Offset = "0x80EE690", VA = "0x1880EFC90")]
	[UnityEngine.Scripting.Preserve]
	public MDNIOINDGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x80F8DF0", Offset = "0x80F77F0", VA = "0x1880F8DF0", Slot = "8")]
	public NEGCEOCAIKD GHLLDDNMCIH(BKBJMNKBOED DOBJHMJOLKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal static class IKNKPABMCIL
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class NBPAOONDKGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public NCPOPMIDADO<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NBPAOONDKGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x80FCEE0", Offset = "0x80FB8E0", VA = "0x1880FCEE0")]
		internal object FPDOABPBMCO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x80F32E0", Offset = "0x80F1CE0", VA = "0x1880F32E0")]
	public static NCPOPMIDADO<string> FMHNKJMPEHH(LMPJBEBLCLM BLAHIKOFFGK, [Optional] string OAKJAGGIHEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x80F3220", Offset = "0x80F1C20", VA = "0x1880F3220")]
	public static void FFJNEDGLJDC(NCPOPMIDADO<string> NDBGCDOMBIN, LMPJBEBLCLM BLAHIKOFFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x80F33C0", Offset = "0x80F1DC0", VA = "0x1880F33C0")]
	public static string IBOECIKEPCB(GGFPIKADCDI MDBNAHHGCNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class IDJFBAINFDC
{
	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x80F30E0", Offset = "0x80F1AE0", VA = "0x1880F30E0")]
	public static void FLNBHCBIKML(this MFOOBEAIMGO HFDCCFJAOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x80F30F0", Offset = "0x80F1AF0", VA = "0x1880F30F0")]
	public static void IOPNBEMDKKL(this MFOOBEAIMGO HFDCCFJAOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x80F3100", Offset = "0x80F1B00", VA = "0x1880F3100")]
	private static void KLNLMEOHLMM(this MFOOBEAIMGO HFDCCFJAOJK, bool NLEGDBEEMBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class LAPNIBJMNBP : GIKDCCHIJJM, EKHGOOMLMGL, FKANHHPELCA, PJBHFBKGGMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private readonly EKHGOOMLMGL HEDLDGIACLE;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public BKBJMNKBOED EJGLDLJPMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x80F6C80", Offset = "0x80F5680", VA = "0x1880F6C80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int ENKBCNDMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x80F6F40", Offset = "0x80F5940", VA = "0x1880F6F40", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int POCLDFPDIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x80F6DB0", Offset = "0x80F57B0", VA = "0x1880F6DB0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool JMJBJHPCHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int CNHHKFIEHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xB5E180", Offset = "0xB5CB80", VA = "0x180B5E180", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event LFJFFJEONDM.PGFICMOCNFC LFBBOEDHLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event CCODHHMFNOL OLPNDDDJCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x80F6E00", Offset = "0x80F5800", VA = "0x1880F6E00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x80F6BE0", Offset = "0x80F55E0", VA = "0x1880F6BE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> KFCHMCNIACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<BKBJMNKBOED> MKPFIJIGANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action DNJLIIKPNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x80F6EA0", Offset = "0x80F58A0", VA = "0x1880F6EA0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x80F7090", Offset = "0x80F5A90", VA = "0x1880F7090", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0xC832A0", Offset = "0xC81CA0", VA = "0x180C832A0")]
	public LAPNIBJMNBP(EKHGOOMLMGL HEDLDGIACLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x80F6FE0", Offset = "0x80F59E0", VA = "0x1880F6FE0", Slot = "8")]
	public bool MDBCCFEEAIL(byte OPGMLCDKFBP, object MAKLFEFHFBK, IJDHNGPEKCN JHFELOMPNJC, SendOptions LMINHEJGLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x80F6CD0", Offset = "0x80F56D0", VA = "0x1880F6CD0", Slot = "16")]
	public BKBJMNKBOED CNNLHJBHMCL(int IHGDIMPKJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "19")]
	public void EGIEFGIHFPA(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "20")]
	public void CKLJOGOMAGG(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "21")]
	public void IKNMHPKJFEA(object GNAAILLDOKI, bool CDHBPJNHGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x80F6F90", Offset = "0x80F5990", VA = "0x1880F6F90", Slot = "22")]
	public IDisposable LBJDCELLCAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "23")]
	private bool ELJLKBBDFEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "24")]
	public void OCILEDDAMIF(StringBuilder PNLFMPPBIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xEAB850", Offset = "0xEAA250", VA = "0x180EAB850", Slot = "25")]
	public bool EHBMJKNOPOP(bool MDJJGNLKMPD, [Out] string LPNLOGECJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0xE5F2B0", Offset = "0xE5DCB0", VA = "0x180E5F2B0", Slot = "28")]
	public void MNDLFOMDIJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal struct LMJBLNOKKAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	private readonly IDictionary<object, object> GLECKDJIKIL;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA30", Offset = "0xC9A430", VA = "0x180C9BA30")]
	public LMJBLNOKKAA(IDictionary<object, object> GLECKDJIKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x80F7E60", Offset = "0x80F6860", VA = "0x1880F7E60")]
	public bool KDCDLCDKABC([Out] GGFPIKADCDI FLPDJFEEMLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x80F7F10", Offset = "0x80F6910", VA = "0x1880F7F10")]
	public Guid KDHMCLFDMOI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x80F7FC0", Offset = "0x80F69C0", VA = "0x1880F7FC0")]
	public NEGCEOCAIKD MHCJFKKGBAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x80F7D70", Offset = "0x80F6770", VA = "0x1880F7D70")]
	public static ExitGames.Client.Photon.Hashtable IDEDHGEBOCJ(GGFPIKADCDI FLPDJFEEMLN, NEGCEOCAIKD PGKINBLHCBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal static class ANLBPCPNEBA
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x80E87E0", Offset = "0x80E71E0", VA = "0x1880E87E0")]
	public static bool LHBCJJAPGIF(this JIFMHENFAOG HCMHGCJCEGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct EHDIPKLOJDJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct LOMEGFKHOOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public EHDIPKLOJDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x80F80F0", Offset = "0x80F6AF0", VA = "0x1880F80F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x80F82D0", Offset = "0x80F6CD0", VA = "0x1880F82D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly CancellationTokenSource DBBALKKKOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	private bool FIMHNIKAAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private Task GLCABFFLNII;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool BFBBKCKIDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x80EFCF0", Offset = "0x80EE6F0", VA = "0x1880EFCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x80EFE30", Offset = "0x80EE830", VA = "0x1880EFE30")]
	public EHDIPKLOJDJ(CancellationToken BJEPDCCBCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x80EFD20", Offset = "0x80EE720", VA = "0x1880EFD20")]
	[AsyncStateMachine(typeof(LOMEGFKHOOF))]
	public Task EFPJAECMKOM(Func<CancellationToken, List<Task>> HGMHMDLMMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x80EFCA0", Offset = "0x80EE6A0", VA = "0x1880EFCA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public readonly struct ONIHCLGPELJ<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct NJHAICFFNJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public AsyncTaskMethodBuilder<CEGCKGHHPPP<JPHMEMEGABN<TData>, MJKMNFLLIGE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public ONIHCLGPELJ<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private TaskAwaiter<CEGCKGHHPPP<JPHMEMEGABN<TData>, MJKMNFLLIGE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x51B1190", Offset = "0x51AFB90", VA = "0x1851B1190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x47DC300", Offset = "0x47DAD00", VA = "0x1847DC300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private readonly DKFLGAJFHGM<TGetDataArg, TData> LGCCMBFCAMH;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA30", Offset = "0xC9A430", VA = "0x180C9BA30")]
	internal ONIHCLGPELJ(DKFLGAJFHGM<TGetDataArg, TData> DODNABDPAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x52EF7F0", Offset = "0x52EE1F0", VA = "0x1852EF7F0")]
	[AsyncStateMachine(typeof(ONIHCLGPELJ<, >.NJHAICFFNJE))]
	public Task<CEGCKGHHPPP<JPHMEMEGABN<TData>, MJKMNFLLIGE>> JCDAIOIBCGH(TGetDataArg JDKFBOCIIAB, string APHANPJFINL, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public static class MCGOPGMKCNE
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x33BEB70", Offset = "0x33BD570", VA = "0x1833BEB70")]
	public static ONIHCLGPELJ<TGetDataArg, TData> DDDHPONDPCL<TGetDataArg, TData>(DKFLGAJFHGM<TGetDataArg, TData> DODNABDPAAP)
	{
		return default(ONIHCLGPELJ<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public struct ONLIALKKKEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public readonly int APCCBPPAMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public readonly int? GPPDCJGFALE;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FE70", Offset = "0x4E9E870", VA = "0x184E9FE70")]
	public ONLIALKKKEI(int ICDLGGKHDLD, [Optional] int? HMDHJGJCMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x81004B0", Offset = "0x80FEEB0", VA = "0x1881004B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface NGOMOGPAEEG<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEOBKLDCBOA();

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NGOMOGPAEEG<T> FGOOBEOHIBL(string NDDKDBBBHMN);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NGOMOGPAEEG<T> KKIJNCMDBCM(KIPPODDKNJA<T> EINGDMCBJNO);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NGOMOGPAEEG<T> ILLDGNBBHPI(int CCAPIJPBJLK);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NGOMOGPAEEG<T> MEHEOIAIENI(int CCAPIJPBJLK, MOLPKFPNIIM<T> CGEFLKGEGPF);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface HCPGKPPOEKF
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGOMOGPAEEG<T> GHPGFKBJDHE<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PGALJAEADHD GCMKMJDMJJN(Exception GKNCIBMNAMA);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ONLIALKKKEI GCFEPJFFKMG(Exception GKNCIBMNAMA);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public delegate string KIPPODDKNJA<in T>(T GKNCIBMNAMA) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public delegate int MOLPKFPNIIM<in T>(T GKNCIBMNAMA) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class MIHEMFLCIGF : HCPGKPPOEKF
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private delegate string HKLPECOCJID(Exception GKNCIBMNAMA);

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private delegate int JKAJCDDEFCP(Exception GKNCIBMNAMA);

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class AJDDLJIBDAO<T> : NGOMOGPAEEG<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class NNFNPJLAOMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public NNFNPJLAOMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
			internal string OODPOGOHLDP(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[CompilerGenerated]
		private sealed class EGECAEODNGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public KIPPODDKNJA<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public EGECAEODNGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x3EE15F0", Offset = "0x3EDFFF0", VA = "0x183EE15F0")]
			internal string KBKLLCNABBF(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class DBHAONLKKCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public MOLPKFPNIIM<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public DBHAONLKKCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x3EE15F0", Offset = "0x3EDFFF0", VA = "0x183EE15F0")]
			internal int GMGAIINOIFF(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private readonly MIHEMFLCIGF CIGPPMMLFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private readonly Type KIPNIFMAELI;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x5025CA0", Offset = "0x50246A0", VA = "0x185025CA0")]
		internal AJDDLJIBDAO(MIHEMFLCIGF CIGPPMMLFJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x50258C0", Offset = "0x50242C0", VA = "0x1850258C0", Slot = "4")]
		public void EEOBKLDCBOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x50258F0", Offset = "0x50242F0", VA = "0x1850258F0", Slot = "5")]
		public NGOMOGPAEEG<T> FGOOBEOHIBL(string NDDKDBBBHMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x5025A50", Offset = "0x5024450", VA = "0x185025A50", Slot = "6")]
		public NGOMOGPAEEG<T> KKIJNCMDBCM(KIPPODDKNJA<T> EINGDMCBJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5025A10", Offset = "0x5024410", VA = "0x185025A10", Slot = "7")]
		public NGOMOGPAEEG<T> ILLDGNBBHPI(int CCAPIJPBJLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5025B70", Offset = "0x5024570", VA = "0x185025B70", Slot = "8")]
		public NGOMOGPAEEG<T> MEHEOIAIENI(int CCAPIJPBJLK, MOLPKFPNIIM<T> CGEFLKGEGPF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class PDMHPFPCHFK<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private bool FFBEPNOKIDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<Type> ANOOFFIMJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly Dictionary<Type, TVal> MKEPOPCCCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly Dictionary<Type, int> FDJIKJBDCMB;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public IReadOnlyList<Type> FBFAHLLNAAL
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x53C4790", Offset = "0x53C3190", VA = "0x1853C4790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x53C4A10", Offset = "0x53C3410", VA = "0x1853C4A10")]
		public PDMHPFPCHFK(Dictionary<Type, int> FDJIKJBDCMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x53C4550", Offset = "0x53C2F50", VA = "0x1853C4550")]
		public void HEHCILJMFIP(Type NJBPFCDJFGD, TVal OILNFPPOKDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x53C4450", Offset = "0x53C2E50", VA = "0x1853C4450")]
		public bool APILFENFFID(Type KIPNIFMAELI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x53C4600", Offset = "0x53C3000", VA = "0x1853C4600")]
		public bool IEJEOFPMAAI(TVal PPJFMHBDGNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F10FA0", Offset = "0x3F0F9A0", VA = "0x183F10FA0")]
		public TVal BLCCCENAIKI(Type OHCGINPDMEI)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x53C46F0", Offset = "0x53C30F0", VA = "0x1853C46F0")]
		[CompilerGenerated]
		private int JEOEEAODGCI(Type PGGFHBKIIKC, Type OLPJDDCALCA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class ENLCDNHMLCE : IEnumerable<ONLIALKKKEI>, IEnumerable, IEnumerator<ONLIALKKKEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private ONLIALKKKEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public MIHEMFLCIGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private IEnumerator<ONLIALKKKEI> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		private ONLIALKKKEI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x43FAB90", Offset = "0x43F9590", VA = "0x1843FAB90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ONLIALKKKEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x80F0F70", Offset = "0x80EF970", VA = "0x1880F0F70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
		[DebuggerHidden]
		public ENLCDNHMLCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x80F0FC0", Offset = "0x80EF9C0", VA = "0x1880F0FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x80F09B0", Offset = "0x80EF3B0", VA = "0x1880F09B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x80F0960", Offset = "0x80EF360", VA = "0x1880F0960")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x80F0910", Offset = "0x80EF310", VA = "0x1880F0910")]
		private void EKCCALBOGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x80F0F20", Offset = "0x80EF920", VA = "0x1880F0F20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x80F0E60", Offset = "0x80EF860", VA = "0x1880F0E60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ONLIALKKKEI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x80F0E60", Offset = "0x80EF860", VA = "0x1880F0E60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private static readonly ONLIALKKKEI BBJAOJCHAAH;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private static readonly Dictionary<Type, int> BBEALPNGMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly HashSet<Type> CCMBFEINPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly PDMHPFPCHFK<int> JOGGGHMDLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private readonly PDMHPFPCHFK<JKAJCDDEFCP> NECCKJFIIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly PDMHPFPCHFK<HKLPECOCJID> PBIPFADFHGO;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x80FC230", Offset = "0x80FAC30", VA = "0x1880FC230")]
	[EFEOGKEOEKD.IHENNBHNBPA.IFPBCNBMCDE]
	internal static void LMIBOGDHNKD(LKOLOODKMPF JACGBGKJHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x80FC360", Offset = "0x80FAD60", VA = "0x1880FC360")]
	[RecRoom.NoEngine.Common.Preserve]
	public MIHEMFLCIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x36A4440", Offset = "0x36A2E40", VA = "0x1836A4440", Slot = "4")]
	public NGOMOGPAEEG<T> GHPGFKBJDHE<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x80FB8D0", Offset = "0x80FA2D0", VA = "0x1880FB8D0", Slot = "5")]
	public PGALJAEADHD GCMKMJDMJJN(Exception GKNCIBMNAMA)
	{
		return default(PGALJAEADHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x80FB6D0", Offset = "0x80FA0D0", VA = "0x1880FB6D0", Slot = "6")]
	public ONLIALKKKEI GCFEPJFFKMG(Exception? GKNCIBMNAMA)
	{
		return default(ONLIALKKKEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x80FAF80", Offset = "0x80F9980", VA = "0x1880FAF80", Slot = "7")]
	[IteratorStateMachine(typeof(ENLCDNHMLCE))]
	public IEnumerable<ONLIALKKKEI> BPDKIPOELOA(Exception GKNCIBMNAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x80FBC30", Offset = "0x80FA630", VA = "0x1880FBC30", Slot = "8")]
	public string GJPKAIAMJAB(Exception? GKNCIBMNAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x80FB020", Offset = "0x80F9A20", VA = "0x1880FB020")]
	private string EDGBPDIFBJH(AggregateException HAMNEAAIEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x80FB320", Offset = "0x80F9D20", VA = "0x1880FB320")]
	private void EPKPDNEAAKG(Type KIPNIFMAELI, int CCAPIJPBJLK, JKAJCDDEFCP? KJHMIGJFKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x80FBE60", Offset = "0x80FA860", VA = "0x1880FBE60")]
	private void INFAMNLLKPL(Type KIPNIFMAELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x80FB960", Offset = "0x80FA360", VA = "0x1880FB960")]
	private void GEHDEADPKHG(Type KIPNIFMAELI, HKLPECOCJID PJAGEIOCJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x80FC0B0", Offset = "0x80FAAB0", VA = "0x1880FC0B0")]
	private static int JFOLBHICHMI(Type KIPNIFMAELI, Dictionary<Type, int> FDJIKJBDCMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x3750510", Offset = "0x374EF10", VA = "0x183750510")]
	private static bool PJOJLJMNELO<TVal>(PDMHPFPCHFK<TVal> IOMEFCNHNJN, Type KIPNIFMAELI, [Out] TVal PPJFMHBDGNA) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x80FBD80", Offset = "0x80FA780", VA = "0x1880FBD80")]
	[CompilerGenerated]
	internal static int HAJMDOJNOFC(Type CBCEMFPPAKC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public struct PGALJAEADHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public readonly ONLIALKKKEI INLDPFKAPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public readonly string FJHIDBOFBBL;

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x8101920", Offset = "0x8100320", VA = "0x188101920")]
	public PGALJAEADHD(string DCBNBCFCPNM, ONLIALKKKEI CCAPIJPBJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x8101880", Offset = "0x8100280", VA = "0x188101880")]
	public string MNEJCBFAGAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class MGIEBANOHLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	private readonly BEPPBPCKNFL KILEPFJPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	private string LCNAOLMJJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	private long? GFICNIBOEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	private long? BNJPDHCEHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	private long? KMOLAFDODFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private string FOMCCIHDGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private EOBKJOEMCOB DEAEFFPMNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private long? ELDGCNCFCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private bool BNOALLJDIFD;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public string BFEPIEOCDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public long HBODICPBBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x80FA610", Offset = "0x80F9010", VA = "0x1880FA610")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public long FENFGPAJEGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x80FA550", Offset = "0x80F8F50", VA = "0x1880FA550")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public long LLHHGIPJDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x80FA5B0", Offset = "0x80F8FB0", VA = "0x1880FA5B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public string POBLALBGPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x80FA510", Offset = "0x80F8F10", VA = "0x1880FA510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public EOBKJOEMCOB LPMECMKMFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xCFE580", Offset = "0xCFCF80", VA = "0x180CFE580")]
		get
		{
			return default(EOBKJOEMCOB);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x80FAB60", Offset = "0x80F9560", VA = "0x1880FAB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public long KADAFONBADK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x80FA670", Offset = "0x80F9070", VA = "0x1880FA670")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x80FAF40", Offset = "0x80F9940", VA = "0x1880FAF40")]
	[UnityEngine.Scripting.Preserve]
	public MGIEBANOHLI([GJJKIKPKKBJ(null)] BEPPBPCKNFL KILEPFJPHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x80FACF0", Offset = "0x80F96F0", VA = "0x1880FACF0")]
	private void NNMMOKHHLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x80FA6D0", Offset = "0x80F90D0", VA = "0x1880FA6D0")]
	public void KEKAEHKOEBA(long ELGKGFHIPBE, long OAJKHGNBEDJ, [Optional] long? LNNIIMLBGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x80FAC50", Offset = "0x80F9650", VA = "0x1880FAC50")]
	public void NCGNJKNIJJF(long LNNIIMLBGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x80FA120", Offset = "0x80F8B20", VA = "0x1880FA120")]
	public void BFIFPGONMLA(string MJIJDLCJNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x80FA1A0", Offset = "0x80F8BA0", VA = "0x1880FA1A0")]
	public void DEGPIGPPCMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class EDFKMNECCFB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct PNEEPCPGGIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public AsyncTaskMethodBuilder<GGFPIKADCDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public GGFPIKADCDI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public EDFKMNECCFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private TaskAwaiter<ANKDDIPDILL.EKFPANBFDCF<GGFPIKADCDI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x8102D80", Offset = "0x8101780", VA = "0x188102D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x81032C0", Offset = "0x8101CC0", VA = "0x1881032C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct JHNCGEEJBLC<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class GEJIDDAOAGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public GGFPIKADCDI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public GEJIDDAOAGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x80F1B40", Offset = "0x80F0540", VA = "0x1880F1B40")]
		internal GGFPIKADCDI NNHOKAHKFEE(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct NHFFLNNNIMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public AsyncTaskMethodBuilder<ANKDDIPDILL.EKFPANBFDCF<GGFPIKADCDI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public GGFPIKADCDI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public EDFKMNECCFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private CHKCIPMCHBG <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private TaskAwaiter<ANKDDIPDILL.EKFPANBFDCF<GGFPIKADCDI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x80FD8E0", Offset = "0x80FC2E0", VA = "0x1880FD8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x80FDEF0", Offset = "0x80FC8F0", VA = "0x1880FDEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct FMCKFNOCMKG<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public EDFKMNECCFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x47DBD90", Offset = "0x47DA790", VA = "0x1847DBD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x47DC300", Offset = "0x47DAD00", VA = "0x1847DC300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct OBDKIGNIFMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public EDFKMNECCFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x80FE390", Offset = "0x80FCD90", VA = "0x1880FE390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x80FE670", Offset = "0x80FD070", VA = "0x1880FE670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class GHJPGPEMLGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public GHJPGPEMLGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x80F1CE0", Offset = "0x80F06E0", VA = "0x1880F1CE0")]
		internal object NMGAANDDGGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x80F1C20", Offset = "0x80F0620", VA = "0x1880F1C20")]
		internal bool HAKPCCFEFGL(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class OBOJODEEBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public OBOJODEEBPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x80FE6D0", Offset = "0x80FD0D0", VA = "0x1880FE6D0")]
		internal object GCGNIJDHILA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class MEFPHAFGJDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MEFPHAFGJDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x80F8F00", Offset = "0x80F7900", VA = "0x1880F8F00")]
		internal object JGLINBOBKHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class MDFFJFOMJKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MDFFJFOMJKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x80F8C60", Offset = "0x80F7660", VA = "0x1880F8C60")]
		internal object FBJMJHAMGMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class ALICFKCCJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public EDFKMNECCFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public ALICFKCCJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x80E85A0", Offset = "0x80E6FA0", VA = "0x1880E85A0")]
		internal object POFMCKEDNFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private static readonly Guid JALFIGGKCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public readonly EDDPLOEGLIE CJOACOKAAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly ANKDDIPDILL ILPOBDIGPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly FKANHHPELCA HFDCCFJAOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly PJBHFBKGGMG OLFDFEJCGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private bool FKIOMADNPFE;

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x80EF950", Offset = "0x80EE350", VA = "0x1880EF950")]
	public EDFKMNECCFB(EDDPLOEGLIE AJHDOLGFFAB, ANKDDIPDILL ILPOBDIGPAM, FKANHHPELCA HFDCCFJAOJK, PJBHFBKGGMG OLFDFEJCGHO, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x80EEC60", Offset = "0x80ED660", VA = "0x1880EEC60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x80EF230", Offset = "0x80EDC30", VA = "0x1880EF230")]
	public void LBIFILAAGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x80EF830", Offset = "0x80EE230", VA = "0x1880EF830")]
	public void PEBABFJNCJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x80EF490", Offset = "0x80EDE90", VA = "0x1880EF490")]
	public void MLMJNMKGDPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x80EF550", Offset = "0x80EDF50", VA = "0x1880EF550")]
	[AsyncStateMachine(typeof(PNEEPCPGGIL))]
	internal Task<GGFPIKADCDI> MOEBHBEJJKI(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, GGFPIKADCDI MDBNAHHGCNO, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x34B5CF0", Offset = "0x34B46F0", VA = "0x1834B5CF0")]
	private static byte[] EBKJIKFMHAP<T>(T FLPDJFEEMLN) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x34B5FA0", Offset = "0x34B49A0", VA = "0x1834B5FA0")]
	private static T KPHFHHDBGOI<T>(MessageParser<T> GJEMGEADPAH, byte[] FLPDJFEEMLN, T GPKHBKNCBDE) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x80EF350", Offset = "0x80EDD50", VA = "0x1880EF350")]
	[AsyncStateMachine(typeof(NHFFLNNNIMN))]
	private Task<ANKDDIPDILL.EKFPANBFDCF<GGFPIKADCDI>> LFPIFOFFOBF(GGFPIKADCDI MDBNAHHGCNO, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x34B5D00", Offset = "0x34B4700", VA = "0x1834B5D00")]
	[AsyncStateMachine(typeof(FMCKFNOCMKG<>))]
	internal Task<T> JKKCDCGMDND<T>(CancellationToken OJOOKCOCPDF, Func<CancellationToken, Task<T>> PINPNFPHGKH, int FJIDAPFOFOF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x80EF100", Offset = "0x80EDB00", VA = "0x1880EF100")]
	[AsyncStateMachine(typeof(OBDKIGNIFMC))]
	internal Task JKKCDCGMDND(CancellationToken OJOOKCOCPDF, Func<CancellationToken, Task> PINPNFPHGKH, int FJIDAPFOFOF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x80EE950", Offset = "0x80ED350", VA = "0x1880EE950")]
	public POBEENEOBDB CFGMCGCDOMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x80EE8D0", Offset = "0x80ED2D0", VA = "0x1880EE8D0")]
	public CHICOMIOENI BDDIHDOFJIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x80EEE90", Offset = "0x80ED890", VA = "0x1880EEE90")]
	public FDABLBDMLAG IFCFMBAFIGK([Optional] LMPJBEBLCLM? BLAHIKOFFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x80EE770", Offset = "0x80ED170", VA = "0x1880EE770")]
	public void AJOMCKCPFAF(Func<Guid, bool> IJJOHNMKMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x80EE9D0", Offset = "0x80ED3D0", VA = "0x1880EE9D0")]
	public void CNDEJFMLLDK(Func<Guid, bool> EOLPLOLFFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x80EEAE0", Offset = "0x80ED4E0", VA = "0x1880EEAE0")]
	public Guid DMDIGDMJNNL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x80EEC70", Offset = "0x80ED670", VA = "0x1880EEC70")]
	public void GBJKDHNFGIK(Guid GHMOOFOLHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x80EF700", Offset = "0x80EE100", VA = "0x1880EF700")]
	public void OOAOKNPKHGI(GGFPIKADCDI HAFPENLPFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x80EED80", Offset = "0x80ED780", VA = "0x1880EED80")]
	public void HIMKLMLGBHH(string NJEMKFJODNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x34B60F0", Offset = "0x34B4AF0", VA = "0x1834B60F0")]
	private T PGDFIGNMDAI<T>(T PPJFMHBDGNA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x80EF6B0", Offset = "0x80EE0B0", VA = "0x1880EF6B0")]
	public void MPPNEECBLPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x34B5A50", Offset = "0x34B4450", VA = "0x1834B5A50")]
	[CompilerGenerated]
	internal static string AKHJCMFMAIJ<T>(byte[] OHAFLBCBHHH, int FBDEAAOGBII, JHNCGEEJBLC<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal sealed class MNIIEAFNPKA : EDDPLOEGLIE
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class ADJMDGCBNNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public ADJMDGCBNNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x80E7F10", Offset = "0x80E6910", VA = "0x1880E7F10")]
		internal object JAOIKODCLIP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct EHEDDOENHKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public MNIIEAFNPKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public EDFKMNECCFB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private FFMMAHICCBH <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private CHICOMIOENI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x80EFF60", Offset = "0x80EE960", VA = "0x1880EFF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x80F08B0", Offset = "0x80EF2B0", VA = "0x1880F08B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct IMBDECCHDDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public MNIIEAFNPKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private TaskAwaiter<AKGPNEALNMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x80F3480", Offset = "0x80F1E80", VA = "0x1880F3480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x80F3BC0", Offset = "0x80F25C0", VA = "0x1880F3BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct NDOLEEDPFLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public MNIIEAFNPKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter<PENJFAOFOEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x80FCF60", Offset = "0x80FB960", VA = "0x1880FCF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x80FD270", Offset = "0x80FBC70", VA = "0x1880FD270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private sealed class GCBNJFMFGBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public FFMMAHICCBH presence;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public GCBNJFMFGBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x80F1A00", Offset = "0x80F0400", VA = "0x1880F1A00")]
		internal object MILMADOFOKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private static readonly LMPJBEBLCLM CENGMKAENJH;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private static readonly LMPJBEBLCLM ECHHBBHPPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private readonly LGCLIBGOJHL MBMHANDGHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private readonly JIFMHENFAOG FKPAHAFPKOJ;

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x80FCCF0", Offset = "0x80FB6F0", VA = "0x1880FCCF0")]
	public MNIIEAFNPKA(LGCLIBGOJHL MBMHANDGHDK, JIFMHENFAOG FKPAHAFPKOJ, Guid HPBDKIENPJP, HLJANHOBGDO DHMLBLBOLIL, ONJGKIHMNBI JILJKGLJDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x80FC9D0", Offset = "0x80FB3D0", VA = "0x1880FC9D0", Slot = "7")]
	[AsyncStateMachine(typeof(EHEDDOENHKP))]
	protected override Task MCOPDOGMKEG(EDFKMNECCFB PEMDMDKEMNA, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x80FC700", Offset = "0x80FB100", VA = "0x1880FC700")]
	[AsyncStateMachine(typeof(IMBDECCHDDE))]
	private Task DFAHKJOBABJ(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x80FCB10", Offset = "0x80FB510", VA = "0x1880FCB10")]
	[AsyncStateMachine(typeof(NDOLEEDPFLC))]
	private Task<int> OABMFDJGLLI(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x80FC800", Offset = "0x80FB200", VA = "0x1880FC800")]
	private FFMMAHICCBH LONJLMEGCBD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class HLFNPIALBNE : EDDPLOEGLIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct HAKKJBHGOJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public HLFNPIALBNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public EDFKMNECCFB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private TaskAwaiter<CMOIIBJLNAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x80F2100", Offset = "0x80F0B00", VA = "0x1880F2100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x80F2AB0", Offset = "0x80F14B0", VA = "0x1880F2AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly int KPLAKCMCGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly IMLDBGJKKIJ GIHJJKKBLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public readonly long FJEOJHLFBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public readonly long EBCMIHDKJFH;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public CMOIIBJLNAK KBLPLEONDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x9B7BB0", Offset = "0x9B65B0", VA = "0x1809B7BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B80", Offset = "0x9B6580", VA = "0x1809B7B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x80F2EB0", Offset = "0x80F18B0", VA = "0x1880F2EB0")]
	public HLFNPIALBNE(Guid HPBDKIENPJP, HLJANHOBGDO DHMLBLBOLIL, ONJGKIHMNBI JILJKGLJDHA, int KPLAKCMCGLJ, IMLDBGJKKIJ GIHJJKKBLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x80F2D90", Offset = "0x80F1790", VA = "0x1880F2D90", Slot = "7")]
	[AsyncStateMachine(typeof(HAKKJBHGOJL))]
	protected override Task MCOPDOGMKEG(EDFKMNECCFB PEMDMDKEMNA, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal abstract class GCBCNPHKGAC : EDDPLOEGLIE
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class CLLBACOGGCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public GCBCNPHKGAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public BDOBAMPGLAP playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CLLBACOGGCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x80ECA50", Offset = "0x80EB450", VA = "0x1880ECA50")]
		internal Task GGLEEEBEPKB(NCPOPMIDADO<string>.CFILPBLEJMI postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x80ECA90", Offset = "0x80EB490", VA = "0x1880ECA90")]
		internal object HFEFFOAALGP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct PKBBDCOKJLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public GCBCNPHKGAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public EDFKMNECCFB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private CLLBACOGGCE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x8101EB0", Offset = "0x81008B0", VA = "0x188101EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x8102680", Offset = "0x8101080", VA = "0x188102680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct KHOFDFIIIIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public BDOBAMPGLAP playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public GCBCNPHKGAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x80F4310", Offset = "0x80F2D10", VA = "0x1880F4310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x80F48C0", Offset = "0x80F32C0", VA = "0x1880F48C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x80F19B0", Offset = "0x80F03B0", VA = "0x1880F19B0")]
	public GCBCNPHKGAC(Guid HPBDKIENPJP, HLJANHOBGDO DHMLBLBOLIL, ONJGKIHMNBI JILJKGLJDHA, string LEDKHDDIKHO, LEOGKKHFKEI NPBKJOPAEBM, bool ALKLOLMCBLM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x80F1730", Offset = "0x80F0130", VA = "0x1880F1730", Slot = "7")]
	[AsyncStateMachine(typeof(PKBBDCOKJLJ))]
	protected override Task MCOPDOGMKEG(EDFKMNECCFB PEMDMDKEMNA, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task AKFDBLMBAOM(EDFKMNECCFB PEMDMDKEMNA, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x80F1870", Offset = "0x80F0270", VA = "0x1880F1870")]
	[AsyncStateMachine(typeof(KHOFDFIIIIE))]
	private Task MICMKPDLHGH(IDisposable MEECGDPCGDP, BDOBAMPGLAP ACFFPDANKLE, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
internal class LEFIBDLEBLC : EDDPLOEGLIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct KOHBGNMAELF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public LEFIBDLEBLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public EDFKMNECCFB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private TaskAwaiter<GEEPHNBMNNK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x80F5A90", Offset = "0x80F4490", VA = "0x1880F5A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x80F6080", Offset = "0x80F4A80", VA = "0x1880F6080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly CGNALMMEIDH NIFJJAHBNLC;

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x80F7CD0", Offset = "0x80F66D0", VA = "0x1880F7CD0")]
	public LEFIBDLEBLC(Guid HPBDKIENPJP, HLJANHOBGDO DHMLBLBOLIL, ONJGKIHMNBI JILJKGLJDHA, CGNALMMEIDH NIFJJAHBNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x80F7BF0", Offset = "0x80F65F0", VA = "0x1880F7BF0", Slot = "6")]
	protected override string PNFMPELOOLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x80F7AD0", Offset = "0x80F64D0", VA = "0x1880F7AD0", Slot = "7")]
	[AsyncStateMachine(typeof(KOHBGNMAELF))]
	protected override Task MCOPDOGMKEG(EDFKMNECCFB PEMDMDKEMNA, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal abstract class EDDPLOEGLIE : JMDKONJHDFB
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	public delegate Task PAAIEKNJDEE(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class LDLNPDOBCAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public NCPOPMIDADO<string>.CFILPBLEJMI operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public EDDPLOEGLIE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public LDLNPDOBCAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x80F79A0", Offset = "0x80F63A0", VA = "0x1880F79A0")]
		internal Task GMJCCJHDIBK(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class HEFBFLFLPFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public LDLNPDOBCAC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public HEFBFLFLPFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x80F2B10", Offset = "0x80F1510", VA = "0x1880F2B10")]
		internal object GPAGKCPFEHC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct MFFFOIDLENL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public EDDPLOEGLIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public Func<EDDPLOEGLIE, NCPOPMIDADO<string>.CFILPBLEJMI, EDFKMNECCFB> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private LDLNPDOBCAC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private EDFKMNECCFB <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private TaskAwaiter<GGFPIKADCDI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x80F8F70", Offset = "0x80F7970", VA = "0x1880F8F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x80FA0C0", Offset = "0x80F8AC0", VA = "0x1880FA0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct KOMIHLGFOGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x80F60E0", Offset = "0x80F4AE0", VA = "0x1880F60E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x80F6B80", Offset = "0x80F5580", VA = "0x1880F6B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct GKMLCHBFNHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public EDDPLOEGLIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x80F1D40", Offset = "0x80F0740", VA = "0x1880F1D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x80F20A0", Offset = "0x80F0AA0", VA = "0x1880F20A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public readonly Guid NKPPDJMILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public readonly ByteString JMEDGBEFMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public readonly ONJGKIHMNBI KNLKHKLJNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	protected readonly string DLIMAKFIIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private readonly HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private readonly bool ALKLOLMCBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private readonly Queue<PAAIEKNJDEE> BJCFAHJHAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private readonly FOAOAEBMOMB BCEBNDCJPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private readonly LEOGKKHFKEI NPBKJOPAEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private bool BMHKEKABIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public EOBKJOEMCOB MONBLCPDGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public EOBKJOEMCOB HBBMFJICMPF;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public HLJANHOBGDO KNEFFCDAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public POHGOIGKOME MNIGFADEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x80EE0D0", Offset = "0x80ECAD0", VA = "0x1880EE0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public MKPAKKHKDCO IOCJGOPKDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x80EE2C0", Offset = "0x80ECCC0", VA = "0x1880EE2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public FGCPAINBMOO ELGBICGFGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x80EDB70", Offset = "0x80EC570", VA = "0x1880EDB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event FDMLDNIKPAA FIJMKDMBBFC
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x80EE030", Offset = "0x80ECA30", VA = "0x1880EE030", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x80EE2A0", Offset = "0x80ECCA0", VA = "0x1880EE2A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x80EE610", Offset = "0x80ED010", VA = "0x1880EE610")]
	protected EDDPLOEGLIE(Guid HPBDKIENPJP, HLJANHOBGDO DHMLBLBOLIL, ONJGKIHMNBI JILJKGLJDHA, string LEDKHDDIKHO, LEOGKKHFKEI NPBKJOPAEBM, bool ALKLOLMCBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x80EE5D0", Offset = "0x80ECFD0", VA = "0x1880EE5D0", Slot = "6")]
	protected virtual string PNFMPELOOLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x80EE120", Offset = "0x80ECB20", VA = "0x1880EE120")]
	public void KLKEPFMAALE(PAAIEKNJDEE KLMNFDDHBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x80EDAD0", Offset = "0x80EC4D0", VA = "0x1880EDAD0")]
	protected void AKKLNLBKJJP(float GJPBKNDCAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x80EE310", Offset = "0x80ECD10", VA = "0x1880EE310")]
	[AsyncStateMachine(typeof(MFFFOIDLENL))]
	public Task OBEHDDJHDFO(CancellationToken BJEPDCCBCHJ, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, [Optional] Func<EDDPLOEGLIE, NCPOPMIDADO<string>.CFILPBLEJMI, EDFKMNECCFB> DFJELGNNPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x80EDF00", Offset = "0x80EC900", VA = "0x1880EDF00")]
	[AsyncStateMachine(typeof(KOMIHLGFOGM))]
	private static Task IGGCFIOPOGJ(Func<CancellationToken, Task> FABNEHPCBHM, Func<CancellationToken, Task> OMPHIKDFJBA, CancellationToken OJOOKCOCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x80EE460", Offset = "0x80ECE60", VA = "0x1880EE460")]
	private void ONNKNPAHCJA(bool FMDMJGBDOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x80EDCE0", Offset = "0x80EC6E0", VA = "0x1880EDCE0")]
	private void EEICHDPFMOH(EDFKMNECCFB PEMDMDKEMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task MCOPDOGMKEG(EDFKMNECCFB PEMDMDKEMNA, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x80EE180", Offset = "0x80ECB80", VA = "0x1880EE180")]
	[AsyncStateMachine(typeof(GKMLCHBFNHG))]
	private Task LJFOPPDKPNM(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x80EDAF0", Offset = "0x80EC4F0", VA = "0x1880EDAF0")]
	public GGFPIKADCDI ANGLIBLJDJA(CHKCIPMCHBG GCEKLIPIJEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x80EDBF0", Offset = "0x80EC5F0", VA = "0x1880EDBF0")]
	[CompilerGenerated]
	private Task EDDFLDBGKJF(CancellationToken PPOLMDFNGFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x80EE050", Offset = "0x80ECA50", VA = "0x1880EE050")]
	[CompilerGenerated]
	private object KFAGJJPMGCN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
internal sealed class DICPBPOBOLK : GCBCNPHKGAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct OHMHFJBAIBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public DICPBPOBOLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public EDFKMNECCFB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private JBLHFKMHHBN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private CHICOMIOENI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x80FFCE0", Offset = "0x80FE6E0", VA = "0x1880FFCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8100450", Offset = "0x80FEE50", VA = "0x188100450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private readonly LGCLIBGOJHL LGGOMCCENAK;

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x80EDA20", Offset = "0x80EC420", VA = "0x1880EDA20")]
	public DICPBPOBOLK(Guid HPBDKIENPJP, HLJANHOBGDO DHMLBLBOLIL, LGCLIBGOJHL LGGOMCCENAK, ONJGKIHMNBI JILJKGLJDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x80ED8D0", Offset = "0x80EC2D0", VA = "0x1880ED8D0", Slot = "8")]
	[AsyncStateMachine(typeof(OHMHFJBAIBD))]
	protected override Task AKFDBLMBAOM(EDFKMNECCFB PEMDMDKEMNA, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal class HKHBBAIABLL : EDDPLOEGLIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct CMOFACEGMCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public HKHBBAIABLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public EDFKMNECCFB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter<GEEPHNBMNNK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x80ECB20", Offset = "0x80EB520", VA = "0x1880ECB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x80ECFB0", Offset = "0x80EB9B0", VA = "0x1880ECFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private readonly string JKHABKBPHHM;

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x80F2CE0", Offset = "0x80F16E0", VA = "0x1880F2CE0")]
	public HKHBBAIABLL(Guid HPBDKIENPJP, HLJANHOBGDO DHMLBLBOLIL, ONJGKIHMNBI JILJKGLJDHA, string JKHABKBPHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x80F2BD0", Offset = "0x80F15D0", VA = "0x1880F2BD0", Slot = "7")]
	[AsyncStateMachine(typeof(CMOFACEGMCM))]
	protected override Task MCOPDOGMKEG(EDFKMNECCFB PEMDMDKEMNA, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal class PGBCHFAOIOK : GCBCNPHKGAC
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class MDLANPNPJJC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000131")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public AsyncTaskMethodBuilder<GGFPIKADCDI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public MDLANPNPJJC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private TaskAwaiter<GEEPHNBMNNK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private TaskAwaiter<GGFPIKADCDI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x81042E0", Offset = "0x8102CE0", VA = "0x1881042E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x81047D0", Offset = "0x81031D0", VA = "0x1881047D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public PGBCHFAOIOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public FDABLBDMLAG serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public INJGBGPMOFG roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public POBEENEOBDB uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public NGFHAFELNHF roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MDLANPNPJJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x80F8CD0", Offset = "0x80F76D0", VA = "0x1880F8CD0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<GGFPIKADCDI> LIGHFCMNENE(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct OFIFLAOGOEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public PGBCHFAOIOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public EDFKMNECCFB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private MDLANPNPJJC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private JBLHFKMHHBN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private CHICOMIOENI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private GGFPIKADCDI <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private TaskAwaiter<GGFPIKADCDI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x80FED30", Offset = "0x80FD730", VA = "0x1880FED30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x80FFC80", Offset = "0x80FE680", VA = "0x1880FFC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly LMPJBEBLCLM CENGMKAENJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly int NMBPNPFDHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	[CanBeNull]
	private readonly EHGOBHHINHI OHONJEDJEFK;

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x8101E00", Offset = "0x8100800", VA = "0x188101E00")]
	public PGBCHFAOIOK(Guid HPBDKIENPJP, HLJANHOBGDO DHMLBLBOLIL, int NMBPNPFDHMI, EHGOBHHINHI OHONJEDJEFK, ONJGKIHMNBI JILJKGLJDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x8101A40", Offset = "0x8100440", VA = "0x188101A40", Slot = "8")]
	[AsyncStateMachine(typeof(OFIFLAOGOEL))]
	protected override Task AKFDBLMBAOM(EDFKMNECCFB PEMDMDKEMNA, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x8101940", Offset = "0x8100340", VA = "0x188101940")]
	private void ABMDPOLJIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x8101B80", Offset = "0x8100580", VA = "0x188101B80")]
	private void PMBGGGCBFBP(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, JBLHFKMHHBN HHKJAIHFEGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal class CKOBHIHMNHK : EDDPLOEGLIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct ONNNADHGPHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public CKOBHIHMNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private JBLHFKMHHBN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private PHLGPCMBMIF<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter<CMOIIBJLNAK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x8100590", Offset = "0x80FEF90", VA = "0x188100590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x81016D0", Offset = "0x81000D0", VA = "0x1881016D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private readonly int NMBPNPFDHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private readonly EHGOBHHINHI OHONJEDJEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private Func<GEEPHNBMNNK, GEEPHNBMNNK> EBHABDCMJLP;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x80EC990", Offset = "0x80EB390", VA = "0x1880EC990")]
	public CKOBHIHMNHK(Guid HPBDKIENPJP, HLJANHOBGDO DHMLBLBOLIL, int NMBPNPFDHMI, EHGOBHHINHI OHONJEDJEFK, Func<GEEPHNBMNNK, GEEPHNBMNNK> EBHABDCMJLP, ONJGKIHMNBI JILJKGLJDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x80EC850", Offset = "0x80EB250", VA = "0x1880EC850", Slot = "7")]
	[AsyncStateMachine(typeof(ONNNADHGPHC))]
	protected override Task MCOPDOGMKEG(EDFKMNECCFB PEMDMDKEMNA, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal abstract class JNBOJIKNCBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public readonly EDDPLOEGLIE CJOACOKAAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public readonly EDFKMNECCFB GGKHHPAJJDO;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public POHGOIGKOME MNIGFADEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x80F4260", Offset = "0x80F2C60", VA = "0x1880F4260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public FGCPAINBMOO ELGBICGFGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x80F40C0", Offset = "0x80F2AC0", VA = "0x1880F40C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x80F42B0", Offset = "0x80F2CB0", VA = "0x1880F42B0")]
	protected JNBOJIKNCBL(EDFKMNECCFB PEMDMDKEMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x80F4150", Offset = "0x80F2B50", VA = "0x1880F4150")]
	protected void HIMKLMLGBHH(string NJEMKFJODNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct NFDEHCFHLNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Dictionary<Guid, List<KHAJOKJJIBJ>> BKGLHLIOFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Dictionary<Guid, List<KHAJOKJJIBJ>> KKLPDIPLKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public Dictionary<Guid, List<KHAJOKJJIBJ>> BCFCIKAMAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public List<Guid> GJDIHBIAIEF;

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x80FD2E0", Offset = "0x80FBCE0", VA = "0x1880FD2E0")]
	public static NFDEHCFHLNJ BLCCCENAIKI(POHGOIGKOME MPDODANMFLG, EOBKJOEMCOB OHBNMHHFNEP, IOPDENNAJIE DKINBOBOKOL)
	{
		return default(NFDEHCFHLNJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct NAKPNACPBBK
{
	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930")]
	public static NAKPNACPBBK IDEDHGEBOCJ()
	{
		return default(NAKPNACPBBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct CEFPPOHGPMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public readonly AKGPNEALNMD ANFMILMMEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public readonly HPIALGGGMCA EPLHAIFNKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public readonly Guid? MMHKLEMPBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public readonly IReadOnlyCollection<NJKFFLPCAGK> FLAOADMJHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public readonly IReadOnlyCollection<NJKFFLPCAGK> AOCJHDJAFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public readonly LPGDPINKOBL AHNEEBNBDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public readonly LPGDPINKOBL AIIHIIHBDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public readonly FLOHMIGBGEM NOAEIEFPNLF;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool GGEIGEPHBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x80EA880", Offset = "0x80E9280", VA = "0x1880EA880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x80EA910", Offset = "0x80E9310", VA = "0x1880EA910")]
	public CEFPPOHGPMN(AKGPNEALNMD ANFMILMMEOM, HPIALGGGMCA EPLHAIFNKAE, Guid? MMHKLEMPBFN, IReadOnlyList<NJKFFLPCAGK> FLAOADMJHFG, IReadOnlyCollection<NJKFFLPCAGK> AOCJHDJAFCO, LPGDPINKOBL AHNEEBNBDDH, LPGDPINKOBL AIIHIIHBDBC, FLOHMIGBGEM NOAEIEFPNLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct JHJKBLDKGMH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly EDFKMNECCFB PEMDMDKEMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly Guid GHMOOFOLHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private bool FMDMJGBDOPB;

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x80F3C20", Offset = "0x80F2620", VA = "0x1880F3C20")]
	public static JHJKBLDKGMH DMDIGDMJNNL(EDFKMNECCFB PEMDMDKEMNA)
	{
		return default(JHJKBLDKGMH);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x10F00B0", Offset = "0x10EEAB0", VA = "0x1810F00B0")]
	public void EAHHBONEPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x80F3C50", Offset = "0x80F2650", VA = "0x1880F3C50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x80F3F30", Offset = "0x80F2930", VA = "0x1880F3F30")]
	private JHJKBLDKGMH(EDFKMNECCFB PEMDMDKEMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x80F3C60", Offset = "0x80F2660", VA = "0x1880F3C60")]
	private void GBJKDHNFGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x80F3E90", Offset = "0x80F2890", VA = "0x1880F3E90")]
	private Func<Guid, bool> ICOCICMBLJL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal class CHICOMIOENI : JNBOJIKNCBL, JMDKONJHDFB
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	public delegate Task<EOBKJOEMCOB> ICJOEHIHCGK(IOPDENNAJIE DFPGGEDGGGN, IOIFALKNGLN LMCKLJOHAOC, FOAOAEBMOMB AFCEHLJIDFO, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct LPNHFCGCCAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public LGCLIBGOJHL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private JHJKBLDKGMH <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private TaskAwaiter<GGFPIKADCDI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x80F8330", Offset = "0x80F6D30", VA = "0x1880F8330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x80F8C00", Offset = "0x80F7600", VA = "0x1880F8C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct BJFJJMJONPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public AsyncTaskMethodBuilder<GGFPIKADCDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public LGCLIBGOJHL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter<GGFPIKADCDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x80E8D80", Offset = "0x80E7780", VA = "0x1880E8D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x80E91B0", Offset = "0x80E7BB0", VA = "0x1880E91B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct PNCFJEOBNJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public LGCLIBGOJHL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x81026E0", Offset = "0x81010E0", VA = "0x1881026E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x8102D20", Offset = "0x8101720", VA = "0x188102D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class DBPGNHCIGAA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000141")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public AsyncTaskMethodBuilder<CEFPPOHGPMN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public DBPGNHCIGAA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			private CEFPPOHGPMN <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			private TaskAwaiter<EOBKJOEMCOB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			private TaskAwaiter<CEFPPOHGPMN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x8103390", Offset = "0x8101D90", VA = "0x188103390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x8103B80", Offset = "0x8102580", VA = "0x188103B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000142")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			public AsyncTaskMethodBuilder<IOPDENNAJIE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public DBPGNHCIGAA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			private IOPDENNAJIE <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			private TaskAwaiter<EOBKJOEMCOB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			private TaskAwaiter<IOPDENNAJIE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x8103BF0", Offset = "0x81025F0", VA = "0x188103BF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x8104270", Offset = "0x8102C70", VA = "0x188104270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public LGCLIBGOJHL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public FOAOAEBMOMB preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public FOAOAEBMOMB downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public CEFPPOHGPMN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public FOAOAEBMOMB postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public IOPDENNAJIE phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public MHNNGEGFDJJ.FKMANLAFEPM <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public DBPGNHCIGAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x80ED3A0", Offset = "0x80EBDA0", VA = "0x1880ED3A0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<CEFPPOHGPMN> IKCMHFEDEPH(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x80ED4F0", Offset = "0x80EBEF0", VA = "0x1880ED4F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<IOPDENNAJIE> MEFNNADGBGD(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x80ED360", Offset = "0x80EBD60", VA = "0x1880ED360")]
		internal void GAPAKCKNELC(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x80ED770", Offset = "0x80EC170", VA = "0x1880ED770")]
		internal Task PMHJNCLPIKI(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x80ED610", Offset = "0x80EC010", VA = "0x1880ED610")]
		internal Task OEBOBJOGICO(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct BOJCJCHAPPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public LGCLIBGOJHL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private DBPGNHCIGAA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private TaskAwaiter<CEFPPOHGPMN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private TaskAwaiter<IOPDENNAJIE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x80E9AD0", Offset = "0x80E84D0", VA = "0x1880E9AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x80EA820", Offset = "0x80E9220", VA = "0x1880EA820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct KKJDIAOOLGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public IOPDENNAJIE phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public FOAOAEBMOMB postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter<EOBKJOEMCOB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private IOIFALKNGLN <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x80F4920", Offset = "0x80F3320", VA = "0x1880F4920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x80F5A30", Offset = "0x80F4430", VA = "0x1880F5A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct LINCMPDPMLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x8114D60", Offset = "0x8113760", VA = "0x188114D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x8115540", Offset = "0x8113F40", VA = "0x188115540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct AEIHEHMJJAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public FOAOAEBMOMB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private TaskAwaiter<EOBKJOEMCOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x8104F00", Offset = "0x8103900", VA = "0x188104F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x8105740", Offset = "0x8104140", VA = "0x188105740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct BOECEAMFKGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder<EOBKJOEMCOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public FOAOAEBMOMB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter<EOBKJOEMCOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x81075D0", Offset = "0x8105FD0", VA = "0x1881075D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8108590", Offset = "0x8106F90", VA = "0x188108590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct GNJJEBLCDFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public AsyncTaskMethodBuilder<EOBKJOEMCOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public FOAOAEBMOMB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public IOIFALKNGLN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private TaskAwaiter<EOBKJOEMCOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x810F1F0", Offset = "0x810DBF0", VA = "0x18810F1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x8110300", Offset = "0x810ED00", VA = "0x188110300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct BOCCAMPMPHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public AsyncTaskMethodBuilder<EOBKJOEMCOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public EOBKJOEMCOB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public FOAOAEBMOMB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public IOPDENNAJIE deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private TaskAwaiter<EOBKJOEMCOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8107310", Offset = "0x8105D10", VA = "0x188107310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x8107560", Offset = "0x8105F60", VA = "0x188107560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class NEMPAKPLDDK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014C")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			public AsyncTaskMethodBuilder<EOBKJOEMCOB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public NEMPAKPLDDK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			private MBDDIOMLGLG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private TaskAwaiter<EOBKJOEMCOB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x811CAF0", Offset = "0x811B4F0", VA = "0x18811CAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x811D110", Offset = "0x811BB10", VA = "0x18811D110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public FOAOAEBMOMB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public ICJOEHIHCGK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public IOIFALKNGLN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public EOBKJOEMCOB originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NEMPAKPLDDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8117600", Offset = "0x8116000", VA = "0x188117600")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<EOBKJOEMCOB> GBGHNGJIEHL(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct BFNBBHKPADI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder<EOBKJOEMCOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public FOAOAEBMOMB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public ICJOEHIHCGK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public IOIFALKNGLN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter<EOBKJOEMCOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x8106790", Offset = "0x8105190", VA = "0x188106790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x8106CB0", Offset = "0x81056B0", VA = "0x188106CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct OOCFKLJKPPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public FOAOAEBMOMB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private EOBKJOEMCOB <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private IEnumerator<EOBKJOEMCOB> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter<EOBKJOEMCOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x811A5C0", Offset = "0x8118FC0", VA = "0x18811A5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x811AB20", Offset = "0x8119520", VA = "0x18811AB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct EPCNKNJKEEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x810E410", Offset = "0x810CE10", VA = "0x18810E410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x810E700", Offset = "0x810D100", VA = "0x18810E700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct IHJMFGGEGNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x8111CB0", Offset = "0x81106B0", VA = "0x188111CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x8111ED0", Offset = "0x81108D0", VA = "0x188111ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class CNGCJGNNBFH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000152")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			public AsyncTaskMethodBuilder<EOBKJOEMCOB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public CNGCJGNNBFH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public IOPDENNAJIE data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public FOAOAEBMOMB progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private TaskAwaiter<EOBKJOEMCOB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			private TaskAwaiter<BKBJBOFJLGE> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x811D180", Offset = "0x811BB80", VA = "0x18811D180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x811DC50", Offset = "0x811C650", VA = "0x18811DC50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public JLGPJMONJFP mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CNGCJGNNBFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x81099B0", Offset = "0x81083B0", VA = "0x1881099B0")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<EOBKJOEMCOB> FJJPJMCABBE(IOPDENNAJIE data, IOIFALKNGLN _, FOAOAEBMOMB progressTracker, NCPOPMIDADO<string>.CFILPBLEJMI stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct JNECAKKKAHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public IOPDENNAJIE phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public FOAOAEBMOMB postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private CNGCJGNNBFH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private IOIFALKNGLN <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<EOBKJOEMCOB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x8113170", Offset = "0x8111B70", VA = "0x188113170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x8114030", Offset = "0x8112A30", VA = "0x188114030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct NOGAEOIFNMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x8117DB0", Offset = "0x81167B0", VA = "0x188117DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x81181B0", Offset = "0x8116BB0", VA = "0x1881181B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct NFPPJGLGHGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public AsyncTaskMethodBuilder<EOBKJOEMCOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CHICOMIOENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public FOAOAEBMOMB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private TaskAwaiter<EOBKJOEMCOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x8117720", Offset = "0x8116120", VA = "0x188117720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x8117D40", Offset = "0x8116740", VA = "0x188117D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private readonly MDCBAMNMOAI BAEFJCEEAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private readonly MDCBAMNMOAI PCLPNFJCPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private readonly MGIEBANOHLI DJOAEGGPBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private readonly EBCPGDDINLF AKPEAGGPMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private readonly ECFKIIGPOJD BACOJOBKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private ProfilerCounterValue<int> FDIJGEOJEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private readonly BDLALLLEJJP MLCAEENEPDI;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private HLJANHOBGDO KNEFFCDAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x80EB9A0", Offset = "0x80EA3A0", VA = "0x1880EB9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event FDMLDNIKPAA FIJMKDMBBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x80EB9D0", Offset = "0x80EA3D0", VA = "0x1880EB9D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x80EBEB0", Offset = "0x80EA8B0", VA = "0x1880EBEB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x80EC580", Offset = "0x80EAF80", VA = "0x1880EC580")]
	public CHICOMIOENI(EDFKMNECCFB PEMDMDKEMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x80EB290", Offset = "0x80E9C90", VA = "0x1880EB290")]
	[AsyncStateMachine(typeof(LPNHFCGCCAB))]
	public Task EBPCHGDAAAD(LGCLIBGOJHL EELGNOJLLOB, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x80EBA10", Offset = "0x80EA410", VA = "0x1880EBA10")]
	[AsyncStateMachine(typeof(BJFJJMJONPJ))]
	private Task<GGFPIKADCDI> JNMFCOCOEBN(LGCLIBGOJHL EELGNOJLLOB, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x80EAF70", Offset = "0x80E9970", VA = "0x1880EAF70")]
	[AsyncStateMachine(typeof(PNCFJEOBNJG))]
	private Task DHENOPAFJAD(LGCLIBGOJHL EELGNOJLLOB, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x80EC430", Offset = "0x80EAE30", VA = "0x1880EC430")]
	[AsyncStateMachine(typeof(BOJCJCHAPPK))]
	private Task PFKMFHJPDOM(LGCLIBGOJHL EELGNOJLLOB, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken GFAMOBMOALN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x80EC170", Offset = "0x80EAB70", VA = "0x1880EC170")]
	[AsyncStateMachine(typeof(KKJDIAOOLGL))]
	private Task OMBLHJGBLJE(IOPDENNAJIE ILFMFLFFJEI, FOAOAEBMOMB IIAPPGKJLMJ, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken OCKDGPAKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x80EBED0", Offset = "0x80EA8D0", VA = "0x1880EBED0")]
	[AsyncStateMachine(typeof(LINCMPDPMLA))]
	private Task LPACPMFFLDE(NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x80EC020", Offset = "0x80EAA20", VA = "0x1880EC020")]
	[AsyncStateMachine(typeof(AEIHEHMJJAJ))]
	private Task NMKEGGJDFHO(IOPDENNAJIE DFPGGEDGGGN, FOAOAEBMOMB AFCEHLJIDFO, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x80EAC80", Offset = "0x80E9680", VA = "0x1880EAC80")]
	[AsyncStateMachine(typeof(BOECEAMFKGB))]
	private Task<EOBKJOEMCOB> CKHANCDAKGD(IOPDENNAJIE DFPGGEDGGGN, IOIFALKNGLN IOFJMDEEPLG, FOAOAEBMOMB AFCEHLJIDFO, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x80EB3E0", Offset = "0x80E9DE0", VA = "0x1880EB3E0")]
	[AsyncStateMachine(typeof(GNJJEBLCDFG))]
	private Task<EOBKJOEMCOB> FAIIDBHKOJM(IOPDENNAJIE DFPGGEDGGGN, IOIFALKNGLN IOFJMDEEPLG, FOAOAEBMOMB AFCEHLJIDFO, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x80EBCE0", Offset = "0x80EA6E0", VA = "0x1880EBCE0")]
	[AsyncStateMachine(typeof(BOCCAMPMPHG))]
	private Task<EOBKJOEMCOB> LAJCJCFHDLB(EOBKJOEMCOB OHBNMHHFNEP, IOPDENNAJIE DKINBOBOKOL, FOAOAEBMOMB AFCEHLJIDFO, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ, bool FKGBNAKFHMM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x80EB1A0", Offset = "0x80E9BA0", VA = "0x1880EB1A0")]
	private bool EBNEFHLDFBF(IOPDENNAJIE ILFMFLFFJEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x80EADE0", Offset = "0x80E97E0", VA = "0x1880EADE0")]
	[AsyncStateMachine(typeof(BFNBBHKPADI))]
	protected Task<EOBKJOEMCOB> CKLKMLCAHOF(IOPDENNAJIE DFPGGEDGGGN, IOIFALKNGLN IOFJMDEEPLG, FOAOAEBMOMB AFCEHLJIDFO, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ, ICJOEHIHCGK JDNIIKJIMHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x80EB810", Offset = "0x80EA210", VA = "0x1880EB810")]
	[AsyncStateMachine(typeof(OOCFKLJKPPE))]
	private Task GIDBBBJGOLE(IOPDENNAJIE DFPGGEDGGGN, FOAOAEBMOMB AFCEHLJIDFO, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x80EBB70", Offset = "0x80EA570", VA = "0x1880EBB70")]
	private void KEIJOACMFLE(EOBKJOEMCOB JGEKEBHNBDK, FOAOAEBMOMB AFCEHLJIDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x80EAB00", Offset = "0x80E9500", VA = "0x1880EAB00")]
	private void BDPPJNPPEDO(EOBKJOEMCOB FKAHCFLDKGF, [Out] EOBKJOEMCOB MLLKJOOMNJO, [Out] EOBKJOEMCOB NDNOHPDENBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x80EB960", Offset = "0x80EA360", VA = "0x1880EB960")]
	private Task<CEFPPOHGPMN> GIOAFNJGKDE(LGCLIBGOJHL EELGNOJLLOB, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x80EB160", Offset = "0x80E9B60", VA = "0x1880EB160")]
	private Task<IOPDENNAJIE> DMLJLHANBJO(CEFPPOHGPMN DFPGGEDGGGN, MHNNGEGFDJJ.FKMANLAFEPM IAFDIDINEMC, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x80EB560", Offset = "0x80E9F60", VA = "0x1880EB560")]
	[AsyncStateMachine(typeof(EPCNKNJKEEF))]
	private Task FGECMCOBGAF(IOPDENNAJIE DFPGGEDGGGN, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ, bool KENJCCIJHOO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x80EBBC0", Offset = "0x80EA5C0", VA = "0x1880EBBC0")]
	[AsyncStateMachine(typeof(IHJMFGGEGNM))]
	private Task KGBMEEFKANK(IOPDENNAJIE DFPGGEDGGGN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x80EBCB0", Offset = "0x80EA6B0", VA = "0x1880EBCB0")]
	private Task KHIOOLKAGHK(IOPDENNAJIE DFPGGEDGGGN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x80EC410", Offset = "0x80EAE10", VA = "0x1880EC410")]
	private Task PEKBGKOGBON(IOPDENNAJIE DFPGGEDGGGN, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x80EB9F0", Offset = "0x80EA3F0", VA = "0x1880EB9F0")]
	private Task JJJFEGPCBHM(IOPDENNAJIE DFPGGEDGGGN, IOIFALKNGLN IOFJMDEEPLG, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x80EC000", Offset = "0x80EAA00", VA = "0x1880EC000")]
	private Task NMDKDPMBGEJ(IOPDENNAJIE DFPGGEDGGGN, IOIFALKNGLN IOFJMDEEPLG, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x80EC570", Offset = "0x80EAF70", VA = "0x1880EC570")]
	private static Task PHPPNPOBJMM(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x80EAC60", Offset = "0x80E9660", VA = "0x1880EAC60")]
	private Task CCHJKLAODDN(IOPDENNAJIE DFPGGEDGGGN, IOIFALKNGLN IOFJMDEEPLG, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x80EBFE0", Offset = "0x80EA9E0", VA = "0x1880EBFE0")]
	private Task NJPLBGIOMED(IOPDENNAJIE DFPGGEDGGGN, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x80EBE60", Offset = "0x80EA860", VA = "0x1880EBE60")]
	private void LFHGPNEFPPK(LGCLIBGOJHL EELGNOJLLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x80EB0B0", Offset = "0x80E9AB0", VA = "0x1880EB0B0")]
	public void DKMDAFDMGHO(long LNNIIMLBGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	private static void GBLMNBOLHGG(AKGPNEALNMD ANFMILMMEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x80EC2C0", Offset = "0x80EACC0", VA = "0x1880EC2C0")]
	[AsyncStateMachine(typeof(JNECAKKKAHB))]
	private Task OOOIKBGPKNN(IOPDENNAJIE ILFMFLFFJEI, FOAOAEBMOMB IIAPPGKJLMJ, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken OCKDGPAKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x80EA9C0", Offset = "0x80E93C0", VA = "0x1880EA9C0")]
	[AsyncStateMachine(typeof(NOGAEOIFNMC))]
	private Task AOAHLFNGOPF(IOPDENNAJIE DFPGGEDGGGN, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x80EAB40", Offset = "0x80E9540", VA = "0x1880EAB40")]
	private static KPELGGMCHHD BEDAKAEGMJD(IOPDENNAJIE DKINBOBOKOL)
	{
		return default(KPELGGMCHHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x80EB6B0", Offset = "0x80EA0B0", VA = "0x1880EB6B0")]
	[AsyncStateMachine(typeof(NFPPJGLGHGG))]
	private Task<EOBKJOEMCOB> GHLLLGIJIII(IOPDENNAJIE DFPGGEDGGGN, IOIFALKNGLN IOFJMDEEPLG, FOAOAEBMOMB AFCEHLJIDFO, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	private void LBLHGNNMJLJ(EOBKJOEMCOB NIGCCIKDLHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct PIBGHNGDAMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	private HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	private IOPDENNAJIE DFPGGEDGGGN;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private POHGOIGKOME MNIGFADEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x811BDA0", Offset = "0x811A7A0", VA = "0x18811BDA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x811C000", Offset = "0x811AA00", VA = "0x18811C000")]
	public static Task OBEHDDJHDFO(HLJANHOBGDO DHMLBLBOLIL, IOPDENNAJIE DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x811BDF0", Offset = "0x811A7F0", VA = "0x18811BDF0")]
	private void OBEHDDJHDFO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct CHFAJLMNIJP
{
	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x8108E20", Offset = "0x8107820", VA = "0x188108E20")]
	public static Task OBEHDDJHDFO(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct AKFOAHONIBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct PFDLBBHMDEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public EDFKMNECCFB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x811B4C0", Offset = "0x8119EC0", VA = "0x18811B4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x811B9F0", Offset = "0x811A3F0", VA = "0x18811B9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x8105EB0", Offset = "0x81048B0", VA = "0x188105EB0")]
	[AsyncStateMachine(typeof(PFDLBBHMDEM))]
	public static Task OBEHDDJHDFO(EDFKMNECCFB PEMDMDKEMNA, IOPDENNAJIE DFPGGEDGGGN, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct CKDOCNBMBAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct HBHCLICLJKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public EDFKMNECCFB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public IOIFALKNGLN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private HLJANHOBGDO <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private POHGOIGKOME <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private EOBKJOEMCOB <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private MBDDIOMLGLG <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private List<(PersistenceView, FDOLPBGFEHG)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private FDOLPBGFEHG <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8110370", Offset = "0x810ED70", VA = "0x188110370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x8111040", Offset = "0x810FA40", VA = "0x188111040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x81090F0", Offset = "0x8107AF0", VA = "0x1881090F0")]
	[AsyncStateMachine(typeof(HBHCLICLJKG))]
	public static Task OBEHDDJHDFO(EDFKMNECCFB PEMDMDKEMNA, IOPDENNAJIE DFPGGEDGGGN, IOIFALKNGLN IOFJMDEEPLG, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x8108F00", Offset = "0x8107900", VA = "0x188108F00")]
	private static void FKBPCEICLOK(PersistenceView NOHDMGIIOFL, FDOLPBGFEHG JDJGOBEPLEN, IOPDENNAJIE DFPGGEDGGGN, EOBKJOEMCOB OHBNMHHFNEP, bool HGAADAOEOLM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct DIMNFBENFAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct KPPJPPNBPFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public HLJANHOBGDO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private MBDDIOMLGLG <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x81146E0", Offset = "0x81130E0", VA = "0x1881146E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x8114D00", Offset = "0x8113700", VA = "0x188114D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x810AF70", Offset = "0x8109970", VA = "0x18810AF70")]
	[AsyncStateMachine(typeof(KPPJPPNBPFF))]
	public static Task OBEHDDJHDFO(HLJANHOBGDO DHMLBLBOLIL, IOPDENNAJIE DFPGGEDGGGN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct NBNKNDBPCLL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct CBAIBNHFIDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public HLJANHOBGDO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public EDFKMNECCFB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x8108600", Offset = "0x8107000", VA = "0x188108600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x8108810", Offset = "0x8107210", VA = "0x188108810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class DBMDCGDCKEI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000162")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			public NCPOPMIDADO<string>.CFILPBLEJMI timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			public DBMDCGDCKEI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x811DFE0", Offset = "0x811C9E0", VA = "0x18811DFE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x811E370", Offset = "0x811CD70", VA = "0x18811E370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public DBMDCGDCKEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x810A000", Offset = "0x8108A00", VA = "0x18810A000")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task MIEALKEMCHM(NCPOPMIDADO<string>.CFILPBLEJMI timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct IMIMIMAPDEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public NBNKNDBPCLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private MBDDIOMLGLG <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private TaskAwaiter<GGFPIKADCDI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x8111F30", Offset = "0x8110930", VA = "0x188111F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x8112B30", Offset = "0x8111530", VA = "0x188112B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class ENDFJCOIELG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public JEFPFBDEHJG version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public ENDFJCOIELG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x810D800", Offset = "0x810C200", VA = "0x18810D800")]
		internal object LKGKGGHAPGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x810D8E0", Offset = "0x810C2E0", VA = "0x18810D8E0")]
		internal object MFFNEHFJDMJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private IOPDENNAJIE DFPGGEDGGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private EDFKMNECCFB PEMDMDKEMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private bool KENJCCIJHOO;

	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private static readonly ByteString EINDCHGLFDL;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private POHGOIGKOME MNIGFADEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x8117210", Offset = "0x8115C10", VA = "0x188117210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private FGCPAINBMOO ELGBICGFGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x8116960", Offset = "0x8115360", VA = "0x188116960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x8117390", Offset = "0x8115D90", VA = "0x188117390")]
	[AsyncStateMachine(typeof(CBAIBNHFIDC))]
	public static Task OBEHDDJHDFO(HLJANHOBGDO DHMLBLBOLIL, IOPDENNAJIE DFPGGEDGGGN, EDFKMNECCFB PEMDMDKEMNA, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ, bool KENJCCIJHOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x8117260", Offset = "0x8115C60", VA = "0x188117260")]
	[AsyncStateMachine(typeof(IMIMIMAPDEP))]
	private Task OBEHDDJHDFO(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x8116A40", Offset = "0x8115440", VA = "0x188116A40")]
	private void INDJEDMFJAK([NotNull] ENCFJAGIPBN JPMBHBMLCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x8116A00", Offset = "0x8115400", VA = "0x188116A00")]
	private bool CGJMIBKHJIC(JEFPFBDEHJG AIBPOENNNGG, ENCFJAGIPBN JPMBHBMLCDB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct EHAPJLNMLOP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct DFDJAAJOFPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public AsyncTaskMethodBuilder<IOPDENNAJIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public EHAPJLNMLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public MHNNGEGFDJJ.FKMANLAFEPM downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private TaskAwaiter<IReadOnlyCollection<NJKFFLPCAGK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private TaskAwaiter<(CEGCKGHHPPP<NHNAPHMEOFF, MJKMNFLLIGE>, CEGCKGHHPPP<JPHMEMEGABN<ENCFJAGIPBN>, MJKMNFLLIGE>, CEGCKGHHPPP<JPHMEMEGABN<DHBLGJCGMLF>, MJKMNFLLIGE>, CEGCKGHHPPP<JPHMEMEGABN<IEnumerable<PCCDMEPDNKJ>>, MJKMNFLLIGE>, CEGCKGHHPPP<JPHMEMEGABN<JJNBLNEHGHE>, MJKMNFLLIGE>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x810A120", Offset = "0x8108B20", VA = "0x18810A120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x810AF00", Offset = "0x8109900", VA = "0x18810AF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct OCBFJIDGHJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public AsyncTaskMethodBuilder<CEGCKGHHPPP<NHNAPHMEOFF, MJKMNFLLIGE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public NCPOPMIDADO<string>.CFILPBLEJMI downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public EHAPJLNMLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public IReadOnlyCollection<NJKFFLPCAGK> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public IReadOnlyCollection<NJKFFLPCAGK> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public MHNNGEGFDJJ.FKMANLAFEPM downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter<CEGCKGHHPPP<NHNAPHMEOFF, MJKMNFLLIGE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x8118870", Offset = "0x8117270", VA = "0x188118870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x8118ED0", Offset = "0x81178D0", VA = "0x188118ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private ONIHCLGPELJ<LPGDPINKOBL, DHBLGJCGMLF> ADEKMOOLEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private ONIHCLGPELJ<LPGDPINKOBL, ENCFJAGIPBN> EJCCOAMGBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	private ONIHCLGPELJ<FLOHMIGBGEM, IEnumerable<PCCDMEPDNKJ>> CIINGAMCPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private ONIHCLGPELJ<long, JJNBLNEHGHE> IPINKOGIBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private PDLPNAGCOEN FIEFGPOMALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private AKGPNEALNMD ANFMILMMEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private HPIALGGGMCA EPLHAIFNKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private Guid? MMHKLEMPBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private IReadOnlyCollection<NJKFFLPCAGK> FLAOADMJHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private Task<IReadOnlyCollection<NJKFFLPCAGK>> FOKHBFAOOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private LPGDPINKOBL AHNEEBNBDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private LPGDPINKOBL AIIHIIHBDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private LPGDPINKOBL? OEBPNMCPLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private FLOHMIGBGEM NOAEIEFPNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN;

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x810CA40", Offset = "0x810B440", VA = "0x18810CA40")]
	public static Task<IOPDENNAJIE> CDFHIGFFGPH(HLJANHOBGDO DHMLBLBOLIL, [In] CEFPPOHGPMN DFPGGEDGGGN, MHNNGEGFDJJ.FKMANLAFEPM IAFDIDINEMC, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x810CF40", Offset = "0x810B940", VA = "0x18810CF40")]
	[AsyncStateMachine(typeof(DFDJAAJOFPL))]
	private Task<IOPDENNAJIE> OBEHDDJHDFO(MHNNGEGFDJJ.FKMANLAFEPM IAFDIDINEMC, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x810D0F0", Offset = "0x810BAF0", VA = "0x18810D0F0")]
	[AsyncStateMachine(typeof(OCBFJIDGHJF))]
	private Task<CEGCKGHHPPP<NHNAPHMEOFF, MJKMNFLLIGE>> OFCCJBKIBPE(Guid? MMHKLEMPBFN, IReadOnlyCollection<NJKFFLPCAGK> FLAOADMJHFG, IReadOnlyCollection<NJKFFLPCAGK> AOCJHDJAFCO, long? ELGKGFHIPBE, long? CPBHLEIJEHC, MHNNGEGFDJJ.FKMANLAFEPM IAFDIDINEMC, NCPOPMIDADO<string>.CFILPBLEJMI GKGDANDIIAP, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct DKPPIKBOJMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct KAKCAJMONDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public AsyncTaskMethodBuilder<CEFPPOHGPMN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public DKPPIKBOJMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private TaskAwaiter<CEFPPOHGPMN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x8114090", Offset = "0x8112A90", VA = "0x188114090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x81144E0", Offset = "0x8112EE0", VA = "0x1881144E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct JLPHDPGECHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public AsyncTaskMethodBuilder<CEFPPOHGPMN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public DKPPIKBOJMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private TaskAwaiter<CEFPPOHGPMN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8112C80", Offset = "0x8111680", VA = "0x188112C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x8113100", Offset = "0x8111B00", VA = "0x188113100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class OLDFBJJPBJF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000636")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000637")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000638")]
			public OLDFBJJPBJF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			private TaskAwaiter<HMCACHPGJHK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			private TaskAwaiter<PENJFAOFOEP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x811C0E0", Offset = "0x811AAE0", VA = "0x18811C0E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x811CA90", Offset = "0x811B490", VA = "0x18811CA90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public BPAFCFABALO roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public POHGOIGKOME callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public LPGDPINKOBL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public LPGDPINKOBL subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public IReadOnlyList<NJKFFLPCAGK> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public IReadOnlyList<NJKFFLPCAGK> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public AKGPNEALNMD roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public OLDFBJJPBJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xDC9CB0", Offset = "0xDC86B0", VA = "0x180DC9CB0")]
		internal bool DHCEPKFGLBA(HPIALGGGMCA sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x81192D0", Offset = "0x8117CD0", VA = "0x1881192D0")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task BDILGNPJDIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x81193A0", Offset = "0x8117DA0", VA = "0x1881193A0")]
		internal Task<FLOHMIGBGEM> PGDBKHFFEJB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct OLMOEFEBHJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public AsyncTaskMethodBuilder<CEFPPOHGPMN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public BPAFCFABALO roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public POHGOIGKOME callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public LPGDPINKOBL superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private OLDFBJJPBJF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private HPIALGGGMCA <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private Task<FLOHMIGBGEM> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private TaskAwaiter<AKGPNEALNMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter<FLOHMIGBGEM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x81195A0", Offset = "0x8117FA0", VA = "0x1881195A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x811A550", Offset = "0x8118F50", VA = "0x18811A550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private POHGOIGKOME MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private MGIEBANOHLI DJOAEGGPBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private BPAFCFABALO PDJFELCMDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private long ELGKGFHIPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private long OAJKHGNBEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private long LGCPADGPCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private string HHFGONMNNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private LPGDPINKOBL LMGFHOFJCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private Guid ECONFBFDMLF;

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x810B090", Offset = "0x8109A90", VA = "0x18810B090")]
	public static Task<CEFPPOHGPMN> CDFHIGFFGPH(HLJANHOBGDO DHMLBLBOLIL, LGCLIBGOJHL EELGNOJLLOB, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x810B650", Offset = "0x810A050", VA = "0x18810B650")]
	[AsyncStateMachine(typeof(KAKCAJMONDC))]
	private Task<CEFPPOHGPMN> OBEHDDJHDFO(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x810B2E0", Offset = "0x8109CE0", VA = "0x18810B2E0")]
	[AsyncStateMachine(typeof(JLPHDPGECHL))]
	private Task<CEFPPOHGPMN> GIOAFNJGKDE(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x810B450", Offset = "0x8109E50", VA = "0x18810B450")]
	[AsyncStateMachine(typeof(OLMOEFEBHJJ))]
	private static Task<CEFPPOHGPMN> GIOAFNJGKDE(POHGOIGKOME MPDODANMFLG, BPAFCFABALO PDJFELCMDPD, long ELGKGFHIPBE, long OAJKHGNBEDJ, long LGCPADGPCDG, string HHFGONMNNMN, LPGDPINKOBL LMGFHOFJCCA, Guid ECONFBFDMLF, CancellationToken BJEPDCCBCHJ, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x810B620", Offset = "0x810A020", VA = "0x18810B620")]
	private void JAHJPEGAJLA(AKGPNEALNMD ANFMILMMEOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal struct CLICOEMHPHP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct BNFPJGCIDHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public CLICOEMHPHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x8106D20", Offset = "0x8105720", VA = "0x188106D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x81072B0", Offset = "0x8105CB0", VA = "0x1881072B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private POHGOIGKOME MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private IOPDENNAJIE DFPGGEDGGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private float COCHLGGOIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private float DOLIAKAIHMP;

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x81094E0", Offset = "0x8107EE0", VA = "0x1881094E0")]
	public static Task CIDCIJDCLKF(HLJANHOBGDO DHMLBLBOLIL, IOPDENNAJIE DFPGGEDGGGN, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x8109890", Offset = "0x8108290", VA = "0x188109890")]
	[AsyncStateMachine(typeof(BNFPJGCIDHL))]
	public Task OBEHDDJHDFO(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x8109680", Offset = "0x8108080", VA = "0x188109680")]
	private static void EDJLKBDDFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x8109380", Offset = "0x8107D80", VA = "0x188109380")]
	private void CBDIOOJCEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x81097D0", Offset = "0x81081D0", VA = "0x1881097D0")]
	private static float LLLIAIMKJPC(POHGOIGKOME MPDODANMFLG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x81097B0", Offset = "0x81081B0", VA = "0x1881097B0")]
	private static float KLPNLGLNBEH()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal struct GMNIJBLJNLL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct HIAHLMOLMJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public EDFKMNECCFB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private EDDPLOEGLIE <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private HLJANHOBGDO <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private EOMGFBIKNMF.NJMPFDDGAJG <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<GGFPIKADCDI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x81110A0", Offset = "0x810FAA0", VA = "0x1881110A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x81118C0", Offset = "0x81102C0", VA = "0x1881118C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct HKAAKNEAJIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x8111920", Offset = "0x8110320", VA = "0x188111920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x8111C50", Offset = "0x8110650", VA = "0x188111C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x810F0B0", Offset = "0x810DAB0", VA = "0x18810F0B0")]
	[AsyncStateMachine(typeof(HIAHLMOLMJG))]
	public static Task OBEHDDJHDFO(EDFKMNECCFB PEMDMDKEMNA, IOPDENNAJIE DFPGGEDGGGN, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x810F040", Offset = "0x810DA40", VA = "0x18810F040")]
	private static Task<GGFPIKADCDI> KBKJBECMDKE(EDFKMNECCFB PEMDMDKEMNA, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x810EF80", Offset = "0x810D980", VA = "0x18810EF80")]
	[AsyncStateMachine(typeof(HKAAKNEAJIM))]
	private static Task EOHFHAOOELM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct FBPCNICKMNM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct AJHCJONDAIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public FBPCNICKMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x81057A0", Offset = "0x81041A0", VA = "0x1881057A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x8105E50", Offset = "0x8104850", VA = "0x188105E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class NOGPHCGCPKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NOGPHCGCPKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x8118210", Offset = "0x8116C10", VA = "0x188118210")]
		internal object BMDOLPDDOEL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct ENCFOELGAHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public FBPCNICKMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x810D320", Offset = "0x810BD20", VA = "0x18810D320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x810D7A0", Offset = "0x810C1A0", VA = "0x18810D7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private bool DKKNGPAMLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	private HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private CancellationToken BJEPDCCBCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x810E760", Offset = "0x810D160", VA = "0x18810E760")]
	public static Task MNAAGADBDMP(HLJANHOBGDO DHMLBLBOLIL, bool DKKNGPAMLEJ, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken FFMFJPMFBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x810E7D0", Offset = "0x810D1D0", VA = "0x18810E7D0")]
	[AsyncStateMachine(typeof(AJHCJONDAIP))]
	private Task OBEHDDJHDFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x810E8C0", Offset = "0x810D2C0", VA = "0x18810E8C0")]
	[AsyncStateMachine(typeof(ENCFOELGAHF))]
	private Task OHDAGDHANAE(bool DLGJGHOGGKG, string PABGPJFICHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930")]
	private bool MCDCLLLIEHC(bool DKKNGPAMLEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
internal struct OLAGHAMKGIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct OBPJMGEMLDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public OLAGHAMKGIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x8118290", Offset = "0x8116C90", VA = "0x188118290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x8118800", Offset = "0x8117200", VA = "0x188118800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class KLACOIDNHAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KLACOIDNHAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x8114690", Offset = "0x8113090", VA = "0x188114690")]
		internal object BMDOLPDDOEL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct CPJPCIMAAFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public OLAGHAMKGIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x8109B10", Offset = "0x8108510", VA = "0x188109B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x8109F90", Offset = "0x8108990", VA = "0x188109F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private NFBELFLFMEM CABFLOCHEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private bool BOEPDADDBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private IOPDENNAJIE DFPGGEDGGGN;

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x8119250", Offset = "0x8117C50", VA = "0x188119250")]
	public static Task<Scene> PLMOMCNDNLO(HLJANHOBGDO DHMLBLBOLIL, NFBELFLFMEM HEKFOBKFIBO, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x8118F70", Offset = "0x8117970", VA = "0x188118F70")]
	[AsyncStateMachine(typeof(OBPJMGEMLDH))]
	private Task<Scene> OBEHDDJHDFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x8118F40", Offset = "0x8117940", VA = "0x188118F40")]
	private bool JPPHDEGIFNL(IOPDENNAJIE DFPGGEDGGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x81191E0", Offset = "0x8117BE0", VA = "0x1881191E0")]
	private void PDCIGMOLIDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x8119090", Offset = "0x8117A90", VA = "0x188119090")]
	[AsyncStateMachine(typeof(CPJPCIMAAFN))]
	private Task<Scene> OHDAGDHANAE(string PABGPJFICHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct ECFKIIGPOJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct LINPFNEHFLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public AsyncTaskMethodBuilder<EOBKJOEMCOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public ECFKIIGPOJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public EOBKJOEMCOB nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public IOPDENNAJIE deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private TaskAwaiter<EOBKJOEMCOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x81155A0", Offset = "0x8113FA0", VA = "0x1881155A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x8116070", Offset = "0x8114A70", VA = "0x188116070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct PHMCCJNIFKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public AsyncTaskMethodBuilder<EOBKJOEMCOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public ECFKIIGPOJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public EOBKJOEMCOB state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private TaskAwaiter<GGFPIKADCDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x811BA50", Offset = "0x811A450", VA = "0x18811BA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x811BD30", Offset = "0x811A730", VA = "0x18811BD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private readonly EDFKMNECCFB PEMDMDKEMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private readonly MGIEBANOHLI DJOAEGGPBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private readonly EBCPGDDINLF AKPEAGGPMHE;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private EDDPLOEGLIE CJOACOKAAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x65822F0", Offset = "0x6580CF0", VA = "0x1865822F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x810C9E0", Offset = "0x810B3E0", VA = "0x18810C9E0")]
	public ECFKIIGPOJD(EDFKMNECCFB PEMDMDKEMNA, MGIEBANOHLI DJOAEGGPBDP, EBCPGDDINLF AKPEAGGPMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x810C6B0", Offset = "0x810B0B0", VA = "0x18810C6B0")]
	[AsyncStateMachine(typeof(LINPFNEHFLB))]
	public Task<EOBKJOEMCOB> BAJKGLIOGEP(EOBKJOEMCOB PDGPJHNCHLO, IOPDENNAJIE DKINBOBOKOL, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ, bool FKGBNAKFHMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x810C860", Offset = "0x810B260", VA = "0x18810C860")]
	[AsyncStateMachine(typeof(PHMCCJNIFKH))]
	private Task<EOBKJOEMCOB> EBFMNOFCGCN(NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, EOBKJOEMCOB JCFJJCIGDKC, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x810C830", Offset = "0x810B230", VA = "0x18810C830")]
	private bool DDFBGPLDLPL(EOBKJOEMCOB DOBGEPNDKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x810C9C0", Offset = "0x810B3C0", VA = "0x18810C9C0")]
	private void HIMKLMLGBHH(string GHDHNPDIMKE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal struct KFEKPIOELHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct BFCLHONHJEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public EDDPLOEGLIE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public IOIFALKNGLN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private MBDDIOMLGLG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private List<(PersistenceView, FDOLPBGFEHG)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private (PersistenceView, FDOLPBGFEHG) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x8106070", Offset = "0x8104A70", VA = "0x188106070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x8106730", Offset = "0x8105130", VA = "0x188106730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x8114550", Offset = "0x8112F50", VA = "0x188114550")]
	[AsyncStateMachine(typeof(BFCLHONHJEL))]
	public static Task OBEHDDJHDFO(EDDPLOEGLIE AJHDOLGFFAB, IOPDENNAJIE DFPGGEDGGGN, IOIFALKNGLN IOFJMDEEPLG, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct CKGIOCLHJBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct PDKBGPIHAPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public EDDPLOEGLIE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public IOIFALKNGLN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private JEFPFBDEHJG <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private MBDDIOMLGLG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private List<(PersistenceView, FDOLPBGFEHG)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private FDOLPBGFEHG <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x811AB80", Offset = "0x8119580", VA = "0x18811AB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x811B460", Offset = "0x8119E60", VA = "0x18811B460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x8109240", Offset = "0x8107C40", VA = "0x188109240")]
	[AsyncStateMachine(typeof(PDKBGPIHAPP))]
	public static Task OBEHDDJHDFO(EDDPLOEGLIE AJHDOLGFFAB, IOPDENNAJIE DFPGGEDGGGN, IOIFALKNGLN IOFJMDEEPLG, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct EOMGFBIKNMF
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	public struct NJMPFDDGAJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public List<LBEGLJPHNML> PLDLLLFPKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public List<FDOLPBGFEHG> GEFKHPPKILP;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xA487F0", Offset = "0xA471F0", VA = "0x180A487F0")]
		public NJMPFDDGAJG(List<LBEGLJPHNML> PLDLLLFPKJH, List<FDOLPBGFEHG> GEFKHPPKILP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class ANIPGDIACAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public IEnumerable<LBEGLJPHNML> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public ANIPGDIACAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x8105FF0", Offset = "0x81049F0", VA = "0x188105FF0")]
		internal object OPCLAJFOJGC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private HLJANHOBGDO DHMLBLBOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private IOPDENNAJIE DFPGGEDGGGN;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private POHGOIGKOME MNIGFADEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x810E110", Offset = "0x810CB10", VA = "0x18810E110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x810E160", Offset = "0x810CB60", VA = "0x18810E160")]
	public static NJMPFDDGAJG OBEHDDJHDFO(HLJANHOBGDO DHMLBLBOLIL, IOPDENNAJIE DFPGGEDGGGN)
	{
		return default(NJMPFDDGAJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x810E1C0", Offset = "0x810CBC0", VA = "0x18810E1C0")]
	private NJMPFDDGAJG OBEHDDJHDFO()
	{
		return default(NJMPFDDGAJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x810DB60", Offset = "0x810C560", VA = "0x18810DB60")]
	private NJMPFDDGAJG IIOAHOGGEBH(ENCFJAGIPBN JPMBHBMLCDB, JEFPFBDEHJG HHEKGCCCGFJ)
	{
		return default(NJMPFDDGAJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x810D990", Offset = "0x810C390", VA = "0x18810D990")]
	private bool FJABGIMOIEF(IEnumerable<LBEGLJPHNML> PLDLLLFPKJH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal struct CCBIEMFKHCI
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class LNCPOIEMJJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public EOMGFBIKNMF.NJMPFDDGAJG instantiations;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public LNCPOIEMJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x81160E0", Offset = "0x8114AE0", VA = "0x1881160E0")]
		internal object MIEALKEMCHM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class NEEKPEABGNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NEEKPEABGNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x8117570", Offset = "0x8115F70", VA = "0x188117570")]
		internal object GMJCCJHDIBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x8108870", Offset = "0x8107270", VA = "0x188108870")]
	public static void OBEHDDJHDFO(EDDPLOEGLIE AJHDOLGFFAB, IOPDENNAJIE DFPGGEDGGGN, EOMGFBIKNMF.NJMPFDDGAJG IONFDLCLMBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal class EBCPGDDINLF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct NBNANGAMILO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public EBCPGDDINLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public EOBKJOEMCOB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public IOPDENNAJIE deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x8116190", Offset = "0x8114B90", VA = "0x188116190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x8116900", Offset = "0x8115300", VA = "0x188116900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class INIJAGKBIAG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006D8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006D9")]
			public INIJAGKBIAG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006DA")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(RVA = "0x811DCC0", Offset = "0x811C6C0", VA = "0x18811DCC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x811DF80", Offset = "0x811C980", VA = "0x18811DF80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public EBCPGDDINLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public NCPOPMIDADO<string>.CFILPBLEJMI handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public INIJAGKBIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8112B90", Offset = "0x8111590", VA = "0x188112B90")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task PFKMGCIMNKM(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct FFNFPEAPJNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public EBCPGDDINLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private INIJAGKBIAG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x810E9F0", Offset = "0x810D3F0", VA = "0x18810E9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x810EF20", Offset = "0x810D920", VA = "0x18810EF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct PGOLNEOCBFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public EBCPGDDINLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private Dictionary<Guid, List<KHAJOKJJIBJ>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x812B510", Offset = "0x8129F10", VA = "0x18812B510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x812BB20", Offset = "0x812A520", VA = "0x18812BB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct CIAOFEHBICL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public EBCPGDDINLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private Dictionary<Guid, List<KHAJOKJJIBJ>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x8122120", Offset = "0x8120B20", VA = "0x188122120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x81227B0", Offset = "0x81211B0", VA = "0x1881227B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class IBGPMJMHLJI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000191")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			public KHAJOKJJIBJ handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FE")]
			public IBGPMJMHLJI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			private MBDDIOMLGLG <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000700")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x812D130", Offset = "0x812BB30", VA = "0x18812D130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x812D590", Offset = "0x812BF90", VA = "0x18812D590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public BBLIIJHMMMG runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public List<KHAJOKJJIBJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public IBGPMJMHLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x8126D90", Offset = "0x8125790", VA = "0x188126D90")]
		internal object EBEFFNCNACA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x8126E80", Offset = "0x8125880", VA = "0x188126E80")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task OKMFDHJLAFG(KHAJOKJJIBJ handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8126CA0", Offset = "0x81256A0", VA = "0x188126CA0")]
		internal object CAJOGIFOGDH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct IMLFMIMAOAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public BBLIIJHMMMG runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public List<KHAJOKJJIBJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private IBGPMJMHLJI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8128570", Offset = "0x8126F70", VA = "0x188128570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x8128A40", Offset = "0x8127440", VA = "0x188128A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private struct APPBHBILBCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public EBCPGDDINLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x8121070", Offset = "0x811FA70", VA = "0x188121070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8121360", Offset = "0x811FD60", VA = "0x188121360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class GNHPANJAHJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public GNHPANJAHJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8125B70", Offset = "0x8124570", VA = "0x188125B70")]
		internal object BJHGHINGACC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private struct LDOJNKIAHGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public EBCPGDDINLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public IOPDENNAJIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x812A190", Offset = "0x8128B90", VA = "0x18812A190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x812A640", Offset = "0x8129040", VA = "0x18812A640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class CDLBFFEPMNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CDLBFFEPMNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x8121590", Offset = "0x811FF90", VA = "0x188121590")]
		internal object CEPAAKAMGPL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct IGFFGEFILJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public EBCPGDDINLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private MBDDIOMLGLG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private TaskAwaiter<GGFPIKADCDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x8127430", Offset = "0x8125E30", VA = "0x188127430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x8127A60", Offset = "0x8126460", VA = "0x188127A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class EBEFBEHAJII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EBEFBEHAJII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x81236F0", Offset = "0x81220F0", VA = "0x1881236F0")]
		internal object DICOHDMGONL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private readonly EDFKMNECCFB PEMDMDKEMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private NFDEHCFHLNJ AKPEAGGPMHE;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private EDDPLOEGLIE CJOACOKAAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x1059650", Offset = "0x1058050", VA = "0x181059650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	public EBCPGDDINLF(EDFKMNECCFB PEMDMDKEMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x810C410", Offset = "0x810AE10", VA = "0x18810C410")]
	[AsyncStateMachine(typeof(NBNANGAMILO))]
	public Task OBEHDDJHDFO(EOBKJOEMCOB OHBNMHHFNEP, IOPDENNAJIE DKINBOBOKOL, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x810B7A0", Offset = "0x810A1A0", VA = "0x18810B7A0")]
	[AsyncStateMachine(typeof(FFNFPEAPJNN))]
	private Task CDALHCJJHKK(IOPDENNAJIE DFPGGEDGGGN, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x810BBC0", Offset = "0x810A5C0", VA = "0x18810BBC0")]
	[AsyncStateMachine(typeof(PGOLNEOCBFJ))]
	private Task DKHPOHLDLAD(IOPDENNAJIE DFPGGEDGGGN, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x810C220", Offset = "0x810AC20", VA = "0x18810C220")]
	[AsyncStateMachine(typeof(CIAOFEHBICL))]
	private Task KHAFINJKJCP(IOPDENNAJIE DFPGGEDGGGN, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x810C560", Offset = "0x810AF60", VA = "0x18810C560")]
	[AsyncStateMachine(typeof(IMLFMIMAOAJ))]
	private Task PCCGOIFBFON(Guid PDFKLECLJAK, List<KHAJOKJJIBJ> DKHCPACOEOA, BBLIIJHMMMG MFFDLILGBBD, IOPDENNAJIE DFPGGEDGGGN, CancellationToken GNAAILLDOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x810C0E0", Offset = "0x810AAE0", VA = "0x18810C0E0")]
	[AsyncStateMachine(typeof(APPBHBILBCN))]
	private Task JIPCAABGIKL(IOPDENNAJIE DFPGGEDGGGN, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x810BFA0", Offset = "0x810A9A0", VA = "0x18810BFA0")]
	[AsyncStateMachine(typeof(LDOJNKIAHGH))]
	private Task JCEDJKHAIBA(Guid CMEENEGMKEH, IOPDENNAJIE DFPGGEDGGGN, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x810BE60", Offset = "0x810A860", VA = "0x18810BE60")]
	[AsyncStateMachine(typeof(IGFFGEFILJF))]
	private Task HHMCGDCCADO(Guid CMEENEGMKEH, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x810BAB0", Offset = "0x810A4B0", VA = "0x18810BAB0")]
	private void DGCEGFGFANL(Guid CMEENEGMKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x810C360", Offset = "0x810AD60", VA = "0x18810C360")]
	private void NKEFLOKKBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x810BD00", Offset = "0x810A700", VA = "0x18810BD00")]
	public Guid HEEBHDMAAKJ(EOBKJOEMCOB JGEKEBHNBDK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x810B8E0", Offset = "0x810A2E0", VA = "0x18810B8E0")]
	[CompilerGenerated]
	private object CPPEFMJDAGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal struct LBLKIAEJCBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct GBAEOHNOMEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public LBLKIAEJCBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private IEnumerator<FLGMHHMFMNN> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x8125000", Offset = "0x8123A00", VA = "0x188125000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x8125690", Offset = "0x8124090", VA = "0x188125690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000729")]
	private POHGOIGKOME MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private CancellationToken BJEPDCCBCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x812A030", Offset = "0x8128A30", VA = "0x18812A030")]
	public static Task EFPJAECMKOM(POHGOIGKOME MPDODANMFLG, NCPOPMIDADO<string>.CFILPBLEJMI NDBGCDOMBIN, CancellationToken FFMFJPMFBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x812A0A0", Offset = "0x8128AA0", VA = "0x18812A0A0")]
	[AsyncStateMachine(typeof(GBAEOHNOMEE))]
	private Task OBEHDDJHDFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public readonly struct NGFHAFELNHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	public readonly bool KIOFBDECCAE;

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x2883870", Offset = "0x2882270", VA = "0x182883870")]
	public NGFHAFELNHF(bool GJGMPJOOMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public readonly struct GEEPHNBMNNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	public readonly ENCFJAGIPBN? NJIMJNPEBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000734")]
	public readonly OMCEIBGBPDO NDGDFBOHFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000735")]
	public readonly Guid? JAJGNJPKMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	public readonly IReadOnlyList<Guid> BKPIJOGLKHE;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public IReadOnlyCollection<string> IPCMEEOMICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x8125A50", Offset = "0x8124450", VA = "0x188125A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public IReadOnlyDictionary<long, int> ONJDBPJOMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x8125A30", Offset = "0x8124430", VA = "0x188125A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x8125A70", Offset = "0x8124470", VA = "0x188125A70")]
	public GEEPHNBMNNK(ENCFJAGIPBN? COLBDAEGKBA, OMCEIBGBPDO CJDLKHHIODA, Guid? MMHKLEMPBFN, [Optional] IReadOnlyList<Guid>? BHNHIEGPOAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal class FDABLBDMLAG : JNBOJIKNCBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private struct ILCBGFEPCCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public AsyncTaskMethodBuilder<GEEPHNBMNNK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public FDABLBDMLAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public AOMKAOANABA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public INJGBGPMOFG roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private MBDDIOMLGLG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x8127E60", Offset = "0x8126860", VA = "0x188127E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x8128500", Offset = "0x8126F00", VA = "0x188128500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private sealed class HBMLJHFNGOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public HBMLJHFNGOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x8125EF0", Offset = "0x81248F0", VA = "0x188125EF0")]
		internal object FGBPDBEOJJJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private struct CGDAAADLAGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public FDABLBDMLAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		public AOMKAOANABA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private HBMLJHFNGOO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private MBDDIOMLGLG <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private HPNOBMMHMAN<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x8121600", Offset = "0x8120000", VA = "0x188121600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x81220C0", Offset = "0x8120AC0", VA = "0x1881220C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	private readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private static readonly TimeSpan FBMMMOHMLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000739")]
	private readonly GOGBLEBKNBK BCLFFLDOMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400073A")]
	private readonly APPLCEHOLLP HHMBAPJDIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	private readonly LAGFPPGANGH OHKPOKFMJDP;

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x8124CA0", Offset = "0x81236A0", VA = "0x188124CA0")]
	public FDABLBDMLAG(EDFKMNECCFB PEMDMDKEMNA, GOGBLEBKNBK BCLFFLDOMMP, APPLCEHOLLP NBIDHECLCLI, LAGFPPGANGH OHKPOKFMJDP, LMPJBEBLCLM BLAHIKOFFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x8123AF0", Offset = "0x81224F0", VA = "0x188123AF0")]
	[AsyncStateMachine(typeof(ILCBGFEPCCO))]
	public Task<GEEPHNBMNNK> CFLEALCFLNK(long OAJKHGNBEDJ, INJGBGPMOFG EGGFOEFMNBE, AOMKAOANABA NDEHFBMOBNH, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x8124290", Offset = "0x8122C90", VA = "0x188124290")]
	[AsyncStateMachine(typeof(CGDAAADLAGA))]
	private Task MDPHINPMOIO(AOMKAOANABA NDEHFBMOBNH, PersistenceView[] HNLOHEOICHJ, StringBuilder LIPJCKKFFBK, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x81243D0", Offset = "0x8122DD0", VA = "0x1881243D0")]
	private GEEPHNBMNNK ODEOLLOLHNC(long OAJKHGNBEDJ, INJGBGPMOFG EGGFOEFMNBE, AOMKAOANABA NDEHFBMOBNH, IEnumerable<PersistenceView> HNLOHEOICHJ, StringBuilder LIPJCKKFFBK)
	{
		return default(GEEPHNBMNNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x8123C40", Offset = "0x8122640", VA = "0x188123C40")]
	private ENCFJAGIPBN DMEACDDDLGC(long OAJKHGNBEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x81249E0", Offset = "0x81233E0", VA = "0x1881249E0")]
	private void OHIEDCKLEPB(ENCFJAGIPBN MJFCGLDACCB, StringBuilder LIPJCKKFFBK, IEnumerable<PersistenceView> HNLOHEOICHJ, [In] IKINPFMHFBL KFECFKBDBNK, AILMNHDJJMA LMAHMGHMBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x8123E00", Offset = "0x8122800", VA = "0x188123E00")]
	private void EIGEDJLGPDG(ENCFJAGIPBN MJFCGLDACCB, StringBuilder LIPJCKKFFBK, PersistenceView NOHDMGIIOFL, AILMNHDJJMA LMAHMGHMBLP, [In] IKINPFMHFBL KFECFKBDBNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal class POBEENEOBDB : JNBOJIKNCBL
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private sealed class HCGLJMDOCCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public FCIJIHDEEOL.LDJGKMGNPIB roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public HCGLJMDOCCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x8125F60", Offset = "0x8124960", VA = "0x188125F60")]
		internal object CCHMOMNFAEK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private struct ABKDKHFBKHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public AsyncTaskMethodBuilder<(FCIJIHDEEOL.LDJGKMGNPIB roomDataUpload, FCIJIHDEEOL.LDJGKMGNPIB subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public GEEPHNBMNNK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public POHGOIGKOME callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private HCGLJMDOCCF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private TaskAwaiter<FCIJIHDEEOL.LDJGKMGNPIB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x811E670", Offset = "0x811D070", VA = "0x18811E670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x811EEF0", Offset = "0x811D8F0", VA = "0x18811EEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct HAHFOBJBPFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public AsyncTaskMethodBuilder<CMOIIBJLNAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public POBEENEOBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public EHGOBHHINHI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public GEEPHNBMNNK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		private TaskAwaiter<CMOIIBJLNAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x8125BE0", Offset = "0x81245E0", VA = "0x188125BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x8125E80", Offset = "0x8124880", VA = "0x188125E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private struct JEJMLOEGLHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public AsyncTaskMethodBuilder<CMOIIBJLNAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public POHGOIGKOME callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public GEEPHNBMNNK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public DALJHLKMNKG ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public EHGOBHHINHI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private TaskAwaiter<(FCIJIHDEEOL.LDJGKMGNPIB roomDataUpload, FCIJIHDEEOL.LDJGKMGNPIB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		private TaskAwaiter<CMOIIBJLNAK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x8128AA0", Offset = "0x81274A0", VA = "0x188128AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x8129100", Offset = "0x8127B00", VA = "0x188129100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private struct AHAKPKGEDBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public AsyncTaskMethodBuilder<HMCACHPGJHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		public POBEENEOBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public GEEPHNBMNNK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		private TaskAwaiter<(FCIJIHDEEOL.LDJGKMGNPIB roomDataUpload, FCIJIHDEEOL.LDJGKMGNPIB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private TaskAwaiter<HMCACHPGJHK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x811F7C0", Offset = "0x811E1C0", VA = "0x18811F7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x811FC80", Offset = "0x811E680", VA = "0x18811FC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private sealed class MCLIANLLKAD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AA")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000788")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000789")]
			public AsyncTaskMethodBuilder<GGFPIKADCDI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400078A")]
			public MCLIANLLKAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400078B")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400078C")]
			private GGFPIKADCDI <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400078D")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400078E")]
			private TaskAwaiter<HMCACHPGJHK> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400078F")]
			private TaskAwaiter<CMOIIBJLNAK> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000790")]
			private TaskAwaiter<GGFPIKADCDI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x812D5F0", Offset = "0x812BFF0", VA = "0x18812D5F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x812E800", Offset = "0x812D200", VA = "0x18812E800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public POBEENEOBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public GEEPHNBMNNK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public EHGOBHHINHI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public NGFHAFELNHF roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MCLIANLLKAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x812ACA0", Offset = "0x81296A0", VA = "0x18812ACA0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<GGFPIKADCDI> GAHHNGGEIKB(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct IKJEKFPPPCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public AsyncTaskMethodBuilder<GGFPIKADCDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public POBEENEOBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public GEEPHNBMNNK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public EHGOBHHINHI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public NGFHAFELNHF roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public NCPOPMIDADO<string>.CFILPBLEJMI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private TaskAwaiter<GGFPIKADCDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x8127AC0", Offset = "0x81264C0", VA = "0x188127AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x8127DF0", Offset = "0x81267F0", VA = "0x188127DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000755")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000756")]
	private static readonly LMPJBEBLCLM CENGMKAENJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000757")]
	private readonly FHIJNBOPDFL CBICBFFCNIP;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private HLJANHOBGDO KNEFFCDAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x80EB9A0", Offset = "0x80EA3A0", VA = "0x1880EB9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x812D0A0", Offset = "0x812BAA0", VA = "0x18812D0A0")]
	public POBEENEOBDB(EDFKMNECCFB PEMDMDKEMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x812CEC0", Offset = "0x812B8C0", VA = "0x18812CEC0")]
	[AsyncStateMachine(typeof(ABKDKHFBKHJ))]
	private static Task<(FCIJIHDEEOL.LDJGKMGNPIB, FCIJIHDEEOL.LDJGKMGNPIB)> NCDMKEOPPIO(POHGOIGKOME MPDODANMFLG, GEEPHNBMNNK AJJOFFLOELF, long ELGKGFHIPBE, long CPBHLEIJEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x812C870", Offset = "0x812B270", VA = "0x18812C870")]
	[AsyncStateMachine(typeof(HAHFOBJBPFM))]
	public Task<CMOIIBJLNAK> IOPMNIEEJIG(int NMBPNPFDHMI, [CanBeNull] EHGOBHHINHI OHONJEDJEFK, GEEPHNBMNNK AJJOFFLOELF, long ELGKGFHIPBE, long CPBHLEIJEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x812C9E0", Offset = "0x812B3E0", VA = "0x18812C9E0")]
	public static Task<CMOIIBJLNAK> IOPMNIEEJIG(POHGOIGKOME MPDODANMFLG, int NMBPNPFDHMI, [CanBeNull] EHGOBHHINHI OHONJEDJEFK, GEEPHNBMNNK AJJOFFLOELF, long ELGKGFHIPBE, long CPBHLEIJEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x812CD30", Offset = "0x812B730", VA = "0x18812CD30")]
	[AsyncStateMachine(typeof(JEJMLOEGLHA))]
	public static Task<CMOIIBJLNAK> IOPMNIEEJIG(POHGOIGKOME MPDODANMFLG, int NMBPNPFDHMI, [CanBeNull] EHGOBHHINHI OHONJEDJEFK, GEEPHNBMNNK AJJOFFLOELF, long ELGKGFHIPBE, long CPBHLEIJEHC, DALJHLKMNKG MPBAPLEIMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x812C6F0", Offset = "0x812B0F0", VA = "0x18812C6F0")]
	[AsyncStateMachine(typeof(AHAKPKGEDBG))]
	private Task<HMCACHPGJHK> HHLMNBBEGJM(string HHFGONMNNMN, int NMBPNPFDHMI, GEEPHNBMNNK AJJOFFLOELF, long ELGKGFHIPBE, long CPBHLEIJEHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x812C540", Offset = "0x812AF40", VA = "0x18812C540")]
	[AsyncStateMachine(typeof(IKJEKFPPPCD))]
	public Task<GGFPIKADCDI> EAAIMILEICK(int NMBPNPFDHMI, EHGOBHHINHI? OHONJEDJEFK, GEEPHNBMNNK AJJOFFLOELF, long ELGKGFHIPBE, long CPBHLEIJEHC, NGFHAFELNHF MMBONDGCHCE, NCPOPMIDADO<string>.CFILPBLEJMI HEFLIFKJOGL, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public abstract class MJPPHKABGNI<T> where T : MJPPHKABGNI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079D")]
	internal readonly HLJANHOBGDO PCAPEJOKLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079E")]
	private int? KPIHMFKNFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079F")]
	protected readonly Guid NKPPDJMILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007A0")]
	protected readonly BJBMIMDMIDH NCHONNPDAFI;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected T MGIAGPNBOEM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x5133F80", Offset = "0x5132980", VA = "0x185133F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x5134080", Offset = "0x5132A80", VA = "0x185134080")]
	internal MJPPHKABGNI(HLJANHOBGDO HCPEGGFIIOD, BJBMIMDMIDH LIJCMODMOKD, [Optional] Guid? HPBDKIENPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x5133D70", Offset = "0x5132770", VA = "0x185133D70")]
	private GGFPIKADCDI FGJNHIJNFNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
	protected virtual void CILOEHIMHJN(GGFPIKADCDI FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x5133FE0", Offset = "0x51329E0", VA = "0x185133FE0")]
	public T OMLOGADIOKC(BKBJMNKBOED DOBJHMJOLKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x5133CD0", Offset = "0x51326D0", VA = "0x185133CD0")]
	public T CJNHLCBEMJC(int IKBPOLEEFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x5133E50", Offset = "0x5132850", VA = "0x185133E50", Slot = "5")]
	public virtual Task<NEGCEOCAIKD> MFKEGEFEHDE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public class FKNPNNBPBDL : MJPPHKABGNI<FKNPNNBPBDL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007A1")]
	private LGCLIBGOJHL ECGNDACMANN;

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x8124F30", Offset = "0x8123930", VA = "0x188124F30")]
	internal FKNPNNBPBDL(HLJANHOBGDO HCPEGGFIIOD, BJBMIMDMIDH LIJCMODMOKD, [Optional] Guid? HPBDKIENPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x7413D50", Offset = "0x7412750", VA = "0x187413D50")]
	public FKNPNNBPBDL EJEKHLEBMIO(LGCLIBGOJHL ECGNDACMANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x8124E60", Offset = "0x8123860", VA = "0x188124E60", Slot = "4")]
	protected override void CILOEHIMHJN(GGFPIKADCDI FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public class ICBHCGIKMFO : MJPPHKABGNI<ICBHCGIKMFO>
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	internal enum DJJGJNKCFPA
	{
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[CompilerGenerated]
	private struct CPMCJGFIBCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public AsyncTaskMethodBuilder<NEGCEOCAIKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public ICBHCGIKMFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		private TaskAwaiter<NEGCEOCAIKD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x8122810", Offset = "0x8121210", VA = "0x188122810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x8122BC0", Offset = "0x81215C0", VA = "0x188122BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007A2")]
	private DJJGJNKCFPA JPACLOIIEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007A3")]
	private string KLOIIAFOIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007A4")]
	private EHGOBHHINHI ECGNDACMANN;

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x81272C0", Offset = "0x8125CC0", VA = "0x1881272C0")]
	internal ICBHCGIKMFO(HLJANHOBGDO HCPEGGFIIOD, BJBMIMDMIDH LIJCMODMOKD, [Optional] Guid? HPBDKIENPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x81270F0", Offset = "0x8125AF0", VA = "0x1881270F0")]
	public ICBHCGIKMFO CLFJIAMGLGO(string NMJGNNNOHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x81272A0", Offset = "0x8125CA0", VA = "0x1881272A0")]
	public ICBHCGIKMFO PNIICCNFLIF(bool OJMOJEBEIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x8127160", Offset = "0x8125B60", VA = "0x188127160")]
	public ICBHCGIKMFO LKLPOKKAHDA(bool DCECBEBEILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x8127270", Offset = "0x8125C70", VA = "0x188127270")]
	public ICBHCGIKMFO NJKNCKGFAPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x8126F80", Offset = "0x8125980", VA = "0x188126F80", Slot = "4")]
	protected override void CILOEHIMHJN(GGFPIKADCDI FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x8127180", Offset = "0x8125B80", VA = "0x188127180", Slot = "5")]
	[AsyncStateMachine(typeof(CPMCJGFIBCH))]
	public override Task<NEGCEOCAIKD> MFKEGEFEHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x8127120", Offset = "0x8125B20", VA = "0x188127120")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<NEGCEOCAIKD> EMFHAJLLJMI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal static class CANCLDMGLOH
{
	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x8121440", Offset = "0x811FE40", VA = "0x188121440")]
	public static void KJMCLPPBPPF(this FFMMAHICCBH LMIGJLPPNME, JIFMHENFAOG FKPAHAFPKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x81213C0", Offset = "0x811FDC0", VA = "0x1881213C0")]
	public static void IAGLNMPFJCP(this JIFMHENFAOG HCMHGCJCEGJ, [Optional] string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public static class FFHPLDHEKCA
{
	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x8124DC0", Offset = "0x81237C0", VA = "0x188124DC0")]
	public static LPGDPINKOBL LGLCLALDGJD(this JFODFPDADOM NMADNLDLIAJ)
	{
		return default(LPGDPINKOBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x8124D10", Offset = "0x8123710", VA = "0x188124D10")]
	public static JFODFPDADOM EEEIBFBMCAF(this LPGDPINKOBL AMNLLAFBEME)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B4")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public PLOMDEGLFHP ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public PLOMDEGLFHP HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		private static PLOMDEGLFHP[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		private Dictionary<PLOMDEGLFHP, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x812EF00", Offset = "0x812D900", VA = "0x18812EF00")]
		public bool MEHDBBDIDDI(PLOMDEGLFHP HJEACPJALDN, [Out] ResultConfig MOAPPBPCBJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x812EDC0", Offset = "0x812D7C0", VA = "0x18812EDC0")]
		public ResultConfig BJNNBFKFOHL(PLOMDEGLFHP NBAKHABPJGI, [Optional] HashSet<PLOMDEGLFHP> BJDBBBPGNBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x812F520", Offset = "0x812DF20", VA = "0x18812F520", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x812EF70", Offset = "0x812D970", VA = "0x18812EF70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xB404F0", Offset = "0xB3EEF0", VA = "0x180B404F0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public class GBGLKFPLDIF : LABMLFFGKHA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[CompilerGenerated]
	private struct JFNHHMLFAKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public GBGLKFPLDIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x8129170", Offset = "0x8127B70", VA = "0x188129170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x8129400", Offset = "0x8127E00", VA = "0x188129400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[CompilerGenerated]
	private struct PLKPDDJBGIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		public NCPOPMIDADO<string>.CFILPBLEJMI timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		public LABMLFFGKHA preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		private NCPOPMIDADO<string>.CFILPBLEJMI <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x812C040", Offset = "0x812AA40", VA = "0x18812C040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x812C4E0", Offset = "0x812AEE0", VA = "0x18812C4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007BC")]
	private readonly BBJKNAMOPHA HELHFCPOACE;

	[Cpp2IlInjected.Token(Token = "0x40007BD")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string OGCCKEJNCGN
	{
		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x8125810", Offset = "0x8124210", VA = "0x188125810", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x8125950", Offset = "0x8124350", VA = "0x188125950")]
	[EFEOGKEOEKD.IHENNBHNBPA.IFPBCNBMCDE]
	internal static void OFOBEAIFMFF(LKOLOODKMPF JACGBGKJHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	[RecRoom.NoEngine.Common.Preserve]
	public GBGLKFPLDIF([GJJKIKPKKBJ(null)] BBJKNAMOPHA HELHFCPOACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x8125840", Offset = "0x8124240", VA = "0x188125840", Slot = "5")]
	[AsyncStateMachine(typeof(JFNHHMLFAKL))]
	public Task OBEHDDJHDFO(NCPOPMIDADO<string>.CFILPBLEJMI LPLNNNILMKH, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x81256F0", Offset = "0x81240F0", VA = "0x1881256F0")]
	[AsyncStateMachine(typeof(PLKPDDJBGIN))]
	private Task ILDMBOMLGEB(LABMLFFGKHA LOLOBNCIBIN, NCPOPMIDADO<string>.CFILPBLEJMI LPLNNNILMKH, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public interface BBJKNAMOPHA : LABMLFFGKHA
{
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
public interface LABMLFFGKHA
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	string OGCCKEJNCGN
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OBEHDDJHDFO(NCPOPMIDADO<string>.CFILPBLEJMI LPLNNNILMKH, CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public static class MGMBILIJAAN
{
	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x812B100", Offset = "0x8129B00", VA = "0x18812B100")]
	[EFEOGKEOEKD.IHENNBHNBPA.IFPBCNBMCDE]
	internal static void DKLGFMPPBPK(LKOLOODKMPF JACGBGKJHKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
public interface IMLDBGJKKIJ : IEquatable<IMLDBGJKKIJ>
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	DateTime NADHOIAHFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OEBNOEIEPCK();

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FHEIJHCKGEJ(long ELGKGFHIPBE, long OAJKHGNBEDJ, [Out] GEEPHNBMNNK AJJOFFLOELF);
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
internal class JPAEMBJHIMN : OGAIKAOHFKG
{
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	[CompilerGenerated]
	private sealed class EFPBAGCEJPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public CGNALMMEIDH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EFPBAGCEJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x8123760", Offset = "0x8122160", VA = "0x188123760")]
		internal object AENAFDMJOEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007CB")]
	private readonly HAGFLMGNIBI LEPELGGPFEI;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<IMLDBGJKKIJ> EEGMEHJANHI
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x8129890", Offset = "0x8128290", VA = "0x188129890", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x8129DB0", Offset = "0x81287B0", VA = "0x188129DB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	[UnityEngine.Scripting.Preserve]
	public JPAEMBJHIMN([GJJKIKPKKBJ(null)] HAGFLMGNIBI LEPELGGPFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x8129940", Offset = "0x8128340", VA = "0x188129940", Slot = "6")]
	public bool IIDADOJDLOF(long ELGKGFHIPBE, long OAJKHGNBEDJ, GEEPHNBMNNK AJJOFFLOELF, CGNALMMEIDH NIFJJAHBNLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0xD340F0", Offset = "0xD32AF0", VA = "0x180D340F0")]
	private void LMMGCGGGGIG(IMLDBGJKKIJ GIHJJKKBLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x8129C40", Offset = "0x8128640", VA = "0x188129C40", Slot = "7")]
	public bool LFHOKMLNHDJ(long ELGKGFHIPBE, long OAJKHGNBEDJ, [Out] IMLDBGJKKIJ OOOILNKOICJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x8129E60", Offset = "0x8128860", VA = "0x188129E60", Slot = "8")]
	public bool OLFNBJBKHCG(long ELGKGFHIPBE, long OAJKHGNBEDJ, CGNALMMEIDH NIFJJAHBNLC, [Out] IMLDBGJKKIJ OOOILNKOICJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x8129460", Offset = "0x8127E60", VA = "0x188129460")]
	private void BENKKAGLLPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x8129F10", Offset = "0x8128910", VA = "0x188129F10", Slot = "9")]
	public void PACEBCOOJIF(long ELGKGFHIPBE, long OAJKHGNBEDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
internal abstract class DAIMNFCHPFO : HAGFLMGNIBI
{
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	protected enum LPHKFHDIEOD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[CompilerGenerated]
	private sealed class MFDJFOANDCC : IEnumerable<IMLDBGJKKIJ>, IEnumerable, IEnumerator<IMLDBGJKKIJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private IMLDBGJKKIJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		public DAIMNFCHPFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		private CGNALMMEIDH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		public CGNALMMEIDH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		private IMLDBGJKKIJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
		[DebuggerHidden]
		public MFDJFOANDCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x812ADD0", Offset = "0x81297D0", VA = "0x18812ADD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x812B0B0", Offset = "0x8129AB0", VA = "0x18812B0B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x812B000", Offset = "0x8129A00", VA = "0x18812B000", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IMLDBGJKKIJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x812B000", Offset = "0x8129A00", VA = "0x18812B000", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[CompilerGenerated]
	private sealed class HPNPAPFOFHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		public CGNALMMEIDH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public HPNPAPFOFHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x8126C00", Offset = "0x8125600", VA = "0x188126C00")]
		internal object PHKGOCDCGGP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C4")]
	[CompilerGenerated]
	private sealed class ALCILOBNAKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		public DAIMNFCHPFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public ALCILOBNAKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x811FCF0", Offset = "0x811E6F0", VA = "0x18811FCF0")]
		internal void BFMIDEFNPNJ(HCGNPHBDFMH.MLIGIIFDEJJ ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007D1")]
	private readonly object GHMHGACPNMO;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected string FOLJIFMDLON
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x8123470", Offset = "0x8121E70", VA = "0x188123470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public abstract FOEGPDFEAFE CKKHEEPEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x8123670", Offset = "0x8122070", VA = "0x188123670")]
	protected DAIMNFCHPFO([CanBeNull] string HNKFEEFEBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x8123480", Offset = "0x8121E80", VA = "0x188123480", Slot = "5")]
	public bool OPDOOPLDGOB(long ELGKGFHIPBE, long OAJKHGNBEDJ, CGNALMMEIDH NIFJJAHBNLC, [Out] IMLDBGJKKIJ GIHJJKKBLCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x8122C30", Offset = "0x8121630", VA = "0x188122C30", Slot = "6")]
	[IteratorStateMachine(typeof(MFDJFOANDCC))]
	public IEnumerable<IMLDBGJKKIJ> ADLKBNFEKOJ(CGNALMMEIDH NIFJJAHBNLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void DEEOBHFADHD(Stream NHOBMBCGOAF, long ELGKGFHIPBE, long OAJKHGNBEDJ, GEEPHNBMNNK AJJOFFLOELF);

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool IKIKPMFDMGG(Stream NPCOIJJGEEO, long ELGKGFHIPBE, long OAJKHGNBEDJ, DBCJPPLBIGI NHGAHKKHADB, [Out] GEEPHNBMNNK AJJOFFLOELF);

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x8122D30", Offset = "0x8121730", VA = "0x188122D30", Slot = "7")]
	public IMLDBGJKKIJ CIHMCJAMKIC(long ELGKGFHIPBE, long OAJKHGNBEDJ, GEEPHNBMNNK AJJOFFLOELF, CGNALMMEIDH NIFJJAHBNLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo GBLPGAGJNFD(long ELGKGFHIPBE, long OAJKHGNBEDJ, CGNALMMEIDH NIFJJAHBNLC, LPHKFHDIEOD BOHBHPNDCGL);

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo JGCHIKGKGCP(CGNALMMEIDH NIFJJAHBNLC, LPHKFHDIEOD BOHBHPNDCGL);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x8122CC0", Offset = "0x81216C0", VA = "0x188122CC0")]
	protected void CDGNGCOHIIA(HCGNPHBDFMH.MLIGIIFDEJJ MHOIKFDIKAG, string GHDHNPDIMKE, FileInfo EKCHPMHLNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x81230B0", Offset = "0x8121AB0", VA = "0x1881230B0")]
	internal bool DDBDLAOEHOP(FileInfo BECJMLPMGBP, long ELGKGFHIPBE, long OAJKHGNBEDJ, [Out] GEEPHNBMNNK AJJOFFLOELF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	private void CMAGNKKGCNJ(Exception MDJLCJHKPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
internal class HHHHAHJKIAK : DAIMNFCHPFO
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override FOEGPDFEAFE CKKHEEPEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x1CCEDF0", Offset = "0x1CCD7F0", VA = "0x181CCEDF0", Slot = "8")]
		get
		{
			return default(FOEGPDFEAFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x8126BC0", Offset = "0x81255C0", VA = "0x188126BC0")]
	public HHHHAHJKIAK([Optional] string HNKFEEFEBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x8126B40", Offset = "0x8125540", VA = "0x188126B40")]
	private void OBMNGOJNENH(CGNALMMEIDH NIFJJAHBNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x8125FB0", Offset = "0x81249B0", VA = "0x188125FB0", Slot = "9")]
	internal override void DEEOBHFADHD(Stream NHOBMBCGOAF, long ELGKGFHIPBE, long OAJKHGNBEDJ, GEEPHNBMNNK AJJOFFLOELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x8126350", Offset = "0x8124D50", VA = "0x188126350", Slot = "10")]
	internal override bool IKIKPMFDMGG(Stream NPCOIJJGEEO, long ELGKGFHIPBE, long OAJKHGNBEDJ, DBCJPPLBIGI NHGAHKKHADB, [Out] GEEPHNBMNNK AJJOFFLOELF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x8126260", Offset = "0x8124C60", VA = "0x188126260", Slot = "11")]
	protected override FileInfo GBLPGAGJNFD(long ELGKGFHIPBE, long OAJKHGNBEDJ, CGNALMMEIDH NIFJJAHBNLC, LPHKFHDIEOD BOHBHPNDCGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x8126A40", Offset = "0x8125440", VA = "0x188126A40", Slot = "12")]
	protected override DirectoryInfo JGCHIKGKGCP(CGNALMMEIDH NIFJJAHBNLC, LPHKFHDIEOD BOHBHPNDCGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
internal sealed class AMANAHBPMIL : DAIMNFCHPFO
{
	[Cpp2IlInjected.Token(Token = "0x40007E1")]
	private static readonly byte[] NJBPFCDJFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007E2")]
	private readonly byte[] LBKKKIMGLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007E3")]
	private readonly byte[] FNBMNCNBPHB;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public override FOEGPDFEAFE CKKHEEPEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x6C41D70", Offset = "0x6C40770", VA = "0x186C41D70", Slot = "8")]
		get
		{
			return default(FOEGPDFEAFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x8120F80", Offset = "0x811F980", VA = "0x188120F80")]
	public AMANAHBPMIL([Optional] string HNKFEEFEBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x811FD70", Offset = "0x811E770", VA = "0x18811FD70", Slot = "9")]
	internal override void DEEOBHFADHD(Stream NHOBMBCGOAF, long ELGKGFHIPBE, long OAJKHGNBEDJ, GEEPHNBMNNK AJJOFFLOELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x8120370", Offset = "0x811ED70", VA = "0x188120370", Slot = "10")]
	internal override bool IKIKPMFDMGG(Stream NPCOIJJGEEO, long ELGKGFHIPBE, long OAJKHGNBEDJ, DBCJPPLBIGI NHGAHKKHADB, [Out] GEEPHNBMNNK AJJOFFLOELF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x8120180", Offset = "0x811EB80", VA = "0x188120180")]
	private void DKKEGGOLIAB(byte[] OHAFLBCBHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x8120240", Offset = "0x811EC40", VA = "0x188120240", Slot = "11")]
	protected override FileInfo GBLPGAGJNFD(long ELGKGFHIPBE, long OAJKHGNBEDJ, CGNALMMEIDH NIFJJAHBNLC, LPHKFHDIEOD BOHBHPNDCGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x8120DE0", Offset = "0x811F7E0", VA = "0x188120DE0", Slot = "12")]
	protected override DirectoryInfo JGCHIKGKGCP(CGNALMMEIDH NIFJJAHBNLC, LPHKFHDIEOD BOHBHPNDCGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
public enum FOEGPDFEAFE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007E7")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007E8")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007E9")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
internal class ADKAFDCCKDA : HAGFLMGNIBI
{
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[CompilerGenerated]
	private sealed class PLAAEJBPANG : IEnumerable<IMLDBGJKKIJ>, IEnumerable, IEnumerator<IMLDBGJKKIJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private IMLDBGJKKIJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		public ADKAFDCCKDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		private CGNALMMEIDH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		public CGNALMMEIDH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		private FOEGPDFEAFE[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private IEnumerator<IMLDBGJKKIJ> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		private IMLDBGJKKIJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
		[DebuggerHidden]
		public PLAAEJBPANG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x812BFB0", Offset = "0x812A9B0", VA = "0x18812BFB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x812BBD0", Offset = "0x812A5D0", VA = "0x18812BBD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x812BB80", Offset = "0x812A580", VA = "0x18812BB80")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x812BF60", Offset = "0x812A960", VA = "0x18812BF60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x812BEB0", Offset = "0x812A8B0", VA = "0x18812BEB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IMLDBGJKKIJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x812BEB0", Offset = "0x812A8B0", VA = "0x18812BEB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007EA")]
	private readonly FOEGPDFEAFE[] AOOLHMFLEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007EB")]
	private readonly Dictionary<FOEGPDFEAFE, HAGFLMGNIBI> FKBPNJJNDED;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public FOEGPDFEAFE CKKHEEPEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x811F310", Offset = "0x811DD10", VA = "0x18811F310", Slot = "4")]
		get
		{
			return default(FOEGPDFEAFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x811F490", Offset = "0x811DE90", VA = "0x18811F490")]
	[UnityEngine.Scripting.Preserve]
	public ADKAFDCCKDA(params HAGFLMGNIBI[] EMCOLEBGCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x811F340", Offset = "0x811DD40", VA = "0x18811F340", Slot = "5")]
	public bool OPDOOPLDGOB(long ELGKGFHIPBE, long OAJKHGNBEDJ, CGNALMMEIDH NIFJJAHBNLC, [Out] IMLDBGJKKIJ GIHJJKKBLCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x811EF60", Offset = "0x811D960", VA = "0x18811EF60")]
	private void AAMEOGAKIPA(int LLLPPIGDCHI, long ELGKGFHIPBE, long OAJKHGNBEDJ, CGNALMMEIDH NIFJJAHBNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x811F190", Offset = "0x811DB90", VA = "0x18811F190", Slot = "6")]
	[IteratorStateMachine(typeof(PLAAEJBPANG))]
	public IEnumerable<IMLDBGJKKIJ> ADLKBNFEKOJ(CGNALMMEIDH NIFJJAHBNLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x811F220", Offset = "0x811DC20", VA = "0x18811F220", Slot = "7")]
	public IMLDBGJKKIJ CIHMCJAMKIC(long ELGKGFHIPBE, long OAJKHGNBEDJ, GEEPHNBMNNK AJJOFFLOELF, CGNALMMEIDH NIFJJAHBNLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
internal static class EIFPLMLEIID
{
	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x8123A30", Offset = "0x8122430", VA = "0x188123A30")]
	internal static byte[] OHBBGGPDCAN(byte[] OHAFLBCBHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x81237D0", Offset = "0x81221D0", VA = "0x1881237D0")]
	public static void HEMNAIAHGCN(Stream HDBIIHBLCHF, byte[] GLLFCHGGFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x8123850", Offset = "0x8122250", VA = "0x188123850")]
	public static bool MMDCNDJGAKP(Stream HDBIIHBLCHF, long OFKIKOAAHLL, DBCJPPLBIGI LFEEGKEDOEP, [Out] byte[] DNJNKOEHJLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
internal sealed class MANPJIECNKK : IMLDBGJKKIJ, IEquatable<IMLDBGJKKIJ>, IEquatable<MANPJIECNKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F9")]
	private readonly DAIMNFCHPFO FNKMIPONHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007FA")]
	public readonly FileInfo LJJBDBCAGPD;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public FOEGPDFEAFE CKKHEEPEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x7A185E0", Offset = "0x7A16FE0", VA = "0x187A185E0", Slot = "9")]
		get
		{
			return default(FOEGPDFEAFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public DateTime NADHOIAHFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x812A990", Offset = "0x8129390", VA = "0x18812A990", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x812AB90", Offset = "0x8129590", VA = "0x18812AB90")]
	public MANPJIECNKK(DAIMNFCHPFO JOLDOKDAGKE, FileInfo BECJMLPMGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x812AAE0", Offset = "0x81294E0", VA = "0x18812AAE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x812AA20", Offset = "0x8129420", VA = "0x18812AA20", Slot = "5")]
	public void OEBNOEIEPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x812A8C0", Offset = "0x81292C0", VA = "0x18812A8C0", Slot = "6")]
	public bool FHEIJHCKGEJ(long ELGKGFHIPBE, long OAJKHGNBEDJ, [Out] GEEPHNBMNNK AJJOFFLOELF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x812A760", Offset = "0x8129160", VA = "0x18812A760", Slot = "7")]
	public bool Equals(IMLDBGJKKIJ OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x812A6A0", Offset = "0x81290A0", VA = "0x18812A6A0", Slot = "8")]
	public bool Equals(MANPJIECNKK OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x812A7D0", Offset = "0x81291D0", VA = "0x18812A7D0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x812A900", Offset = "0x8129300", VA = "0x18812A900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
public delegate void DBCJPPLBIGI(HCGNPHBDFMH.MLIGIIFDEJJ NCHEHNPMDAI, string FLPDJFEEMLN);
[Cpp2IlInjected.Token(Token = "0x20001CF")]
internal interface HAGFLMGNIBI
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	FOEGPDFEAFE CKKHEEPEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OPDOOPLDGOB(long ELGKGFHIPBE, long OAJKHGNBEDJ, CGNALMMEIDH NIFJJAHBNLC, [Out] IMLDBGJKKIJ GIHJJKKBLCB);

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<IMLDBGJKKIJ> ADLKBNFEKOJ(CGNALMMEIDH NIFJJAHBNLC);

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IMLDBGJKKIJ CIHMCJAMKIC(long ELGKGFHIPBE, long OAJKHGNBEDJ, GEEPHNBMNNK AJJOFFLOELF, CGNALMMEIDH NIFJJAHBNLC);
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
