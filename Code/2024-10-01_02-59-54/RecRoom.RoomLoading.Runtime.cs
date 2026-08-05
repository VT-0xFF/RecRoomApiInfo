using System;
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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x74C0140", Offset = "0x74BF540", VA = "0x1874C0140")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
		public NullableAttribute(byte[] P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
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
	public class LogRegistrationIndex : OACCHOKJOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74BD2F0", Offset = "0x74BC6F0", VA = "0x1874BD2F0", Slot = "4")]
		public override void PFLPBBOAAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74C42F0", Offset = "0x74C36F0", VA = "0x1874C42F0", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HHMBCOEHMKJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74BA780", Offset = "0x74B9B80", VA = "0x1874BA780")]
	public HHMBCOEHMKJ(string ADPAIBGIHMB, Exception JHBBMCGELMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class MLLDBEFAFDC : KGNEHHGIOFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LKDLNKBKECL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<GAFBGJLGAKK>> <>t__builder;

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
		private TaskAwaiter<NBGBEFFJPKL<GAFBGJLGAKK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74BC180", Offset = "0x74BB580", VA = "0x1874BC180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74BC3C0", Offset = "0x74BB7C0", VA = "0x1874BC3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CJECJEIIOLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<LIJFBAFKOGK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<LIJFBAFKOGK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74AA750", Offset = "0x74A9B50", VA = "0x1874AA750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74AA960", Offset = "0x74A9D60", VA = "0x1874AA960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	[UnityEngine.Scripting.Preserve]
	public MLLDBEFAFDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74BDFE0", Offset = "0x74BD3E0", VA = "0x1874BDFE0", Slot = "4")]
	[AsyncStateMachine(typeof(LKDLNKBKECL))]
	public Task<IReadOnlyList<GAFBGJLGAKK>> EELKFDLDEHD(long HLGODMOGCOI, long LBMLFGGHFGP, [Optional] CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74BE100", Offset = "0x74BD500", VA = "0x1874BE100", Slot = "5")]
	[AsyncStateMachine(typeof(CJECJEIIOLI))]
	public Task<IReadOnlyList<LIJFBAFKOGK>> PLKJFOGGELH(IReadOnlyList<int> CMGJKHMHEBP, [Optional] CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OGEJABCADMO : IEquatable<OGEJABCADMO>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int CFNNFPIJOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LIJFBAFKOGK AANKLHCOMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime OONHAAEOPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NJLGALMALJE? MAHLCCHIIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	AJBOLKILGLL? JIOBHOKOJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	EIBIPAIFFEN MEGHDHGFKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CEFINKDJEPJ> HIPACCLDCAP();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum EIBIPAIFFEN
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KGNEHHGIOFC
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<GAFBGJLGAKK>> EELKFDLDEHD(long HLGODMOGCOI, long LBMLFGGHFGP, [Optional] CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<LIJFBAFKOGK>> PLKJFOGGELH(IReadOnlyList<int> CMGJKHMHEBP, [Optional] CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DFLJNOLPOEG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class PAIFIGLPFDI : OGEJABCADMO, IEquatable<OGEJABCADMO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct DGFKCAMHMPI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<CEFINKDJEPJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public PAIFIGLPFDI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private FNHHMHANIPH <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<JKIABJFEAHD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<CEFINKDJEPJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x74ABF00", Offset = "0x74AB300", VA = "0x1874ABF00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x74AC3C0", Offset = "0x74AB7C0", VA = "0x1874AC3C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly GAFBGJLGAKK NGCNMNJPOFM;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int CFNNFPIJOGC
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8AE510", Offset = "0x8AD910", VA = "0x1808AE510", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LIJFBAFKOGK AANKLHCOMDL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime PPOKDCJDHJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5FF3840", Offset = "0x5FF2C40", VA = "0x185FF3840", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NJLGALMALJE? MAHLCCHIIEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x920460", Offset = "0x91F860", VA = "0x180920460", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public AJBOLKILGLL? JIOBHOKOJOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5FF3920", Offset = "0x5FF2D20", VA = "0x185FF3920", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EIBIPAIFFEN MEGHDHGFKKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9178F0", Offset = "0x916CF0", VA = "0x1809178F0", Slot = "10")]
			get
			{
				return default(EIBIPAIFFEN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x74C2A90", Offset = "0x74C1E90", VA = "0x1874C2A90", Slot = "9")]
		[AsyncStateMachine(typeof(DGFKCAMHMPI))]
		public Task<CEFINKDJEPJ> HIPACCLDCAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x74C2B90", Offset = "0x74C1F90", VA = "0x1874C2B90")]
		public PAIFIGLPFDI(int LMBGMNDNIBC, LIJFBAFKOGK MPIALCEALIE, GAFBGJLGAKK NGCNMNJPOFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x74C28E0", Offset = "0x74C1CE0", VA = "0x1874C28E0", Slot = "11")]
		public bool Equals(OGEJABCADMO OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x74C2970", Offset = "0x74C1D70", VA = "0x1874C2970", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74C28A0", Offset = "0x74C1CA0", VA = "0x1874C28A0")]
		private bool ACFJOLDAPPM(PAIFIGLPFDI OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74C2A10", Offset = "0x74C1E10", VA = "0x1874C2A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class OIEGHAPOHPM : OGEJABCADMO, IEquatable<OGEJABCADMO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct NLKFGFCPCDO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<CEFINKDJEPJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public OIEGHAPOHPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<CEFINKDJEPJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x74BF4C0", Offset = "0x74BE8C0", VA = "0x1874BF4C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x74BF710", Offset = "0x74BEB10", VA = "0x1874BF710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly GDMCCAIBAAO DPBNFMNCFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly NJLGALMALJE CNEPPAAAAPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly AJBOLKILGLL LHCPKDBKHMJ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int CFNNFPIJOGC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x74C1A50", Offset = "0x74C0E50", VA = "0x1874C1A50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LIJFBAFKOGK AANKLHCOMDL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x74C1E40", Offset = "0x74C1240", VA = "0x1874C1E40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime PPOKDCJDHJD
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x74C1DF0", Offset = "0x74C11F0", VA = "0x1874C1DF0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NJLGALMALJE? MAHLCCHIIEE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x74C1DA0", Offset = "0x74C11A0", VA = "0x1874C1DA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public AJBOLKILGLL? JIOBHOKOJOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x74C1D50", Offset = "0x74C1150", VA = "0x1874C1D50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public EIBIPAIFFEN MEGHDHGFKKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x912E20", Offset = "0x912220", VA = "0x180912E20", Slot = "10")]
			get
			{
				return default(EIBIPAIFFEN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x17CF110", Offset = "0x17CE510", VA = "0x1817CF110")]
		public OIEGHAPOHPM(GDMCCAIBAAO ALHPIJFCLMO, NJLGALMALJE BDPDIGBBPEO, AJBOLKILGLL OIFFOOEONLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x74C1C60", Offset = "0x74C1060", VA = "0x1874C1C60", Slot = "9")]
		[AsyncStateMachine(typeof(NLKFGFCPCDO))]
		public Task<CEFINKDJEPJ> HIPACCLDCAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x74C1B40", Offset = "0x74C0F40", VA = "0x1874C1B40", Slot = "11")]
		public bool Equals(OGEJABCADMO OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x74C1A90", Offset = "0x74C0E90", VA = "0x1874C1A90", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x74C19F0", Offset = "0x74C0DF0", VA = "0x1874C19F0")]
		private bool ACFJOLDAPPM(OIEGHAPOHPM OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x74C1BE0", Offset = "0x74C0FE0", VA = "0x1874C1BE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class PDHCMGPAJJA : OGEJABCADMO, IEquatable<OGEJABCADMO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct DJLPEIABMKL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<CEFINKDJEPJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<CEFINKDJEPJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x74AC600", Offset = "0x74ABA00", VA = "0x1874AC600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x74AC860", Offset = "0x74ABC60", VA = "0x1874AC860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly LIJFBAFKOGK DPMIIMJBOGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly NJLGALMALJE CNEPPAAAAPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly AJBOLKILGLL LHCPKDBKHMJ;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int CFNNFPIJOGC
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x74C2CD0", Offset = "0x74C20D0", VA = "0x1874C2CD0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public LIJFBAFKOGK AANKLHCOMDL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime PPOKDCJDHJD
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NJLGALMALJE? MAHLCCHIIEE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x74C2F90", Offset = "0x74C2390", VA = "0x1874C2F90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AJBOLKILGLL? JIOBHOKOJOD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x74C2F40", Offset = "0x74C2340", VA = "0x1874C2F40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public EIBIPAIFFEN MEGHDHGFKKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "10")]
			get
			{
				return default(EIBIPAIFFEN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x17CF110", Offset = "0x17CE510", VA = "0x1817CF110")]
		public PDHCMGPAJJA(LIJFBAFKOGK MPIALCEALIE, NJLGALMALJE BDPDIGBBPEO, AJBOLKILGLL OIFFOOEONLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x74C2E70", Offset = "0x74C2270", VA = "0x1874C2E70", Slot = "9")]
		[AsyncStateMachine(typeof(DJLPEIABMKL))]
		public Task<CEFINKDJEPJ> HIPACCLDCAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x74C2D70", Offset = "0x74C2170", VA = "0x1874C2D70", Slot = "11")]
		public bool Equals(OGEJABCADMO OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x74C2CF0", Offset = "0x74C20F0", VA = "0x1874C2CF0", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74C2DE0", Offset = "0x74C21E0", VA = "0x1874C2DE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74C2BF0", Offset = "0x74C1FF0", VA = "0x1874C2BF0")]
		private bool ACFJOLDAPPM(PDHCMGPAJJA OCKBFCIKBEN)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct ADGDAGOKLBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<OGEJABCADMO>> <>t__builder;

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
		public DFLJNOLPOEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<GAFBGJLGAKK> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<GAFBGJLGAKK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, LIJFBAFKOGK account, GAFBGJLGAKK roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x74A5FE0", Offset = "0x74A53E0", VA = "0x1874A5FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x74A6E20", Offset = "0x74A6220", VA = "0x1874A6E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct JKAOPAOFKDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, LIJFBAFKOGK account, GAFBGJLGAKK roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<GAFBGJLGAKK> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DFLJNOLPOEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<LIJFBAFKOGK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x74BA8D0", Offset = "0x74B9CD0", VA = "0x1874BA8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x74BB2A0", Offset = "0x74BA6A0", VA = "0x1874BB2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LKALLHABLHL HKFHJDAMAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KGNEHHGIOFC LLLBKEAMLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly EPPKPIPMEHD FFJDPAPNMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly IODPKOFCJPG<(long, long), IReadOnlyList<GAFBGJLGAKK>> PENOPGOFLOK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x74ABDD0", Offset = "0x74AB1D0", VA = "0x1874ABDD0")]
	[UnityEngine.Scripting.Preserve]
	public DFLJNOLPOEG([ACGOIOBGIEE(null)] KGNEHHGIOFC OJCHJIBDNFB, [ACGOIOBGIEE(null)] EPPKPIPMEHD MDAHFIOGEPL, [ACGOIOBGIEE(null)] LKALLHABLHL BIDLBFBDBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x74ABC80", Offset = "0x74AB080", VA = "0x1874ABC80")]
	[AsyncStateMachine(typeof(ADGDAGOKLBL))]
	public Task<IList<OGEJABCADMO>> GMDFFOHHGBI(long HLGODMOGCOI, long DPDHHEKEIEF, bool FKHPLALLBFO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74AB9D0", Offset = "0x74AADD0", VA = "0x1874AB9D0")]
	private bool AFNIHJPCMMN(DateTime? JCPNDODMENI, long HLGODMOGCOI, long DPDHHEKEIEF, [Out] GDMCCAIBAAO CMKALAGCPMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x74ABB70", Offset = "0x74AAF70", VA = "0x1874ABB70")]
	[AsyncStateMachine(typeof(JKAOPAOFKDC))]
	private Task<IReadOnlyList<(int, LIJFBAFKOGK, GAFBGJLGAKK)>> FNNGJBIAOJI(IReadOnlyList<GAFBGJLGAKK> PGNKHOBDCMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EPPKPIPMEHD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GDMCCAIBAAO> GNPANLAEOJA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CNCKEAIIJFB(long HLGODMOGCOI, long DPDHHEKEIEF, IOMOLFGHOOF IDDBGNNFLGM, HFDEDFLKCBL DODPONFKEMI);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KOMJJHCDJBM(long HLGODMOGCOI, long DPDHHEKEIEF, [Out] GDMCCAIBAAO CMKALAGCPMC);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FIOBBIIJHGI(long HLGODMOGCOI, long DPDHHEKEIEF, HFDEDFLKCBL DODPONFKEMI, [Out] GDMCCAIBAAO CMKALAGCPMC);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CMFPGHFECIO(long HLGODMOGCOI, long DPDHHEKEIEF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface NNPLAABFNGE : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AFHEEECKMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task EOIHLHMAEAL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AOMKNOCIIPE(Task BIDGKFLMMBN, string FICDEMFGBLH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface JLEHKIMOEJC : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CEFINKDJEPJ> LCHDKFMIIEM(GDMCCAIBAAO CMKALAGCPMC);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JCLDBHGOKOJ(CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface KNABIBLMPBC : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	GGGLGKDJBLD CEKIHPLHINM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNGOICMAILC();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGOHHAIOIGL();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface FMCNBGHPHLG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface KALCCDBBFGA
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan CJOPNNDLLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan IOFFNABOCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan BNGOKIFMKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan HEFMAEJOFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BFNGIPJLCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BBAHHCJHCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool HECMDKHONMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int DKLJFKIHLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NDJNDJIGPBE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool LLFNFFBOBGL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum CFGLKPKLJFP
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum PHKHCKBHGEB
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
public struct HLIJPGBPOLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long FCGGEAOJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long LBMLFGGHFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly CFGLKPKLJFP LGJDMOCCBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception HOOLCEHGBHD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74BA840", Offset = "0x74B9C40", VA = "0x1874BA840")]
	public HLIJPGBPOLB(long FCGGEAOJELI, long LBMLFGGHFGP, CFGLKPKLJFP LGJDMOCCBDP, [CanBeNull] Exception HOOLCEHGBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74BA7F0", Offset = "0x74B9BF0", VA = "0x1874BA7F0")]
	public static HLIJPGBPOLB JJFGKJCEFJO(GAGHJCEIHCL KKCBIJFMPLJ, CFGLKPKLJFP LGJDMOCCBDP, [Optional] Exception HOOLCEHGBHD)
	{
		return default(HLIJPGBPOLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void HPEIEJMFLLC(HLIJPGBPOLB HLEALEHHCCM);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface KOEDPHHOMHP : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ADPNGHDJNAI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event HPEIEJMFLLC MDBKONPDCIB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HPEIEJMFLLC LPLMDDHBPGI;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event HPEIEJMFLLC MMONNGFFEED;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<PHKHCKBHGEB, bool> KMHBHOBALBP;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KCIFLPBADDP();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OHGBHLJPGPH(HLIJPGBPOLB HLEALEHHCCM);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BEJODACJBMC(HLIJPGBPOLB HLEALEHHCCM);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LKONCEOJKOE(HLIJPGBPOLB HLEALEHHCCM);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CLPKMKCNBAA(PHKHCKBHGEB KCOEJFJMFIK, bool HOLPGNIFENN);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface KHNGFKKFBPM : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GNGNIMGNBNO();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBKAPAHEMFA();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface ADIDNHCGFEO : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus PDCHAJNJJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GCMFLENJJIB(GAGHJCEIHCL IONGDFDGKBP, MCAMNJOCGLN DOADKJDGJIE, CancellationToken COHGPHPHNKH);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class LPMKPNPFNBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x74BD2A0", Offset = "0x74BC6A0", VA = "0x1874BD2A0")]
	public static bool JGJOHEDDCJE(this ADIDNHCGFEO ONBBIANMAJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate Task JLOKIJKJCMM(CancellationToken FDAIGOGAKMH, int OIDNDODDMLL, MJIHINAKBBL FCOADIHHMMH);
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface OFDIHMKLHIB : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LIOFIAEOFCL(JLOKIJKJCMM JLEJHKDDHFI);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface EKHKFFBCABL : FNHHMHANIPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken IJJHCPOKGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	ACFNHMKNHLL CJFBDCDDAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	ECJBOAIKALM FNNPAOGDPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	HIHPADIBAKP KMKAKAPFPJG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	EHLDCOMLOKA HEHDJMJINLD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	CLEMMADEOBN GNJEBHFINEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	GMMBDIEALIP KDOENBLCAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	EPAOBPAKFLI PAMEBHIPFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NFPKNMPBOLJ CMKIGMNOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NNPLAABFNGE JPHPAMIDNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	JLEHKIMOEJC PBPPHIHIGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	KOEDPHHOMHP DMPKPKKCDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	KHNGFKKFBPM EIKBBBLDBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	ADIDNHCGFEO PONBBNLHGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	OFDIHMKLHIB IDNKCOACKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	GEGKDJHNBPC ALEAOJGIOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PHBHICGLBJK LCIMDOEACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KHMGHFGENFF FLDGFOKAOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	FJBHGDKNFEH JOHFCLFLKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BNINCIEKNLD GKCGJELAFII
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	INMBLPBBGFE MHKODHLJLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	FEKDDEEOGIE FNBCCGGINNB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	PDMMCOOFBKL LHMJNPGHOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	OIPBPNIBPBJ CALEIJNALNP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	DEKIAMBHKHB MHDGJPNDNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	KNABIBLMPBC EMBBLDNLEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	KALCCDBBFGA CMKIEOBFAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	ICIFGLNNOMK LACHBDAHMFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	EPPKPIPMEHD GNICAAKKLFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	ACJAHDLOKAN KDAGALGKGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	DCBBIABKPIP NFENGHLMODE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	KKELKFJEAOL DEGIHEBGKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	GBMONCCFIHJ AFFJOOMMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void OCBMHOPFKLN(MCAMNJOCGLN HCGECOFKBJP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface GEGKDJHNBPC : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GCBBBMGKMGD PJLPMKJIOFF(Guid NJALKLIOMDE);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MAHJHHAHNPL(Guid NJALKLIOMDE);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PGDDMPIJFOA(Guid NJALKLIOMDE, Task CENFKNMGKJP);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AAOAGPBAENJ(Guid NJALKLIOMDE, CEFINKDJEPJ FGDGPJFNJLM);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(CEFINKDJEPJ, Task)> HKJNIBFFPMC(Guid NJALKLIOMDE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface GAOEJCBIEOJ : FMCNBGHPHLG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface PHBHICGLBJK : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJHGBOPBBMB(OGJBCMINPFI ADPAIBGIHMB);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIFHMHPLNBL(OGJBCMINPFI ADPAIBGIHMB);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<DJFIDPMCMOO> JNGCFBIADKD(CancellationToken DOIFONLLKAM);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface KHMGHFGENFF : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GCBBBMGKMGD CJGILEOJMOO(OGJBCMINPFI BCPLCGADIOL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FACHLFFDGLJ(Guid NJALKLIOMDE, Task CENFKNMGKJP);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface FJBHGDKNFEH : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CEFINKDJEPJ> JOHFCLFLKGH(OGJBCMINPFI JFLHEILMJIN);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface BNINCIEKNLD : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DKKGGCCNPKP> DNNEBLIMIJH(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, GAGHJCEIHCL IONGDFDGKBP, CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface FEKDDEEOGIE : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CEFINKDJEPJ HNECEBFPIJL(NGDBFKPHNOF HDCCMLJIDBG);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KEPAEGBOIMC(string BLDDFJAJFGI);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface INMBLPBBGFE : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OGJBCMINPFI> IMLDFGNEAJF(OGJBCMINPFI JHKMPCADNAF, MNNJFPGNFEF CBMNNOKPMCB, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OGJBCMINPFI> GFIPGPGBGHK(CancellationToken EEHACKMODLA, MNNJFPGNFEF CBMNNOKPMCB);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CEBLHCJACGB OHPGFFDBPGH(ILAHKLFLONK FFEBALGIJGF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CEBLHCJACGB JBOCAJGAEPO(ILAHKLFLONK FFEBALGIJGF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface PDMMCOOFBKL : FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CEFINKDJEPJ IFFNDNHCHHA(NGDBFKPHNOF HDCCMLJIDBG, DJFIDPMCMOO FCAFNCBGOFF);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CEFINKDJEPJ HJHMFIAHEIF(NGDBFKPHNOF OJJIKOKMIHA);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface OIPBPNIBPBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAGDFANILDK(BHEIILEEBNE CMOFOCEHOJI);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJJLGJKKMFF(BHEIILEEBNE CMOFOCEHOJI);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLJMIBOLHPG(BHEIILEEBNE CMOFOCEHOJI);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IMGGJODCHKF(BHEIILEEBNE CMOFOCEHOJI);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class BHEIILEEBNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly GAGHJCEIHCL AMMAMAMOIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> NKODNFOEODJ;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public PMKGFNIFFEC<string> ANIGKJNMLNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9750", VA = "0x1808AA350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	public BHEIILEEBNE(GAGHJCEIHCL NGFGPIIAAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x74A9C20", Offset = "0x74A9020", VA = "0x1874A9C20")]
	public BHEIILEEBNE ACGCDOELLDK(string GMJINMLEEAC, string LIHHDPOHLDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x74A9CF0", Offset = "0x74A90F0", VA = "0x1874A9CF0")]
	public bool HIKKJOJDDGA([Out] IEnumerable<KeyValuePair<string, string>> LEEAMKILMAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x66DA0A0", Offset = "0x66D94A0", VA = "0x1866DA0A0")]
	public BHEIILEEBNE HKFMNNBPKFM(PMKGFNIFFEC<string> GBIEPJHIGOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface ICIFGLNNOMK
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool BAGKGKLPMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string GANJLBMFIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool IEHEHEGDLHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNAIFCBLDIL();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HCDHHLCAOLO IIDAAIMJLAF(long PDOJDMECHAM);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CALGNJLGHDH<PNJFLFBCBJP, GIMIMNLPGGB> MOEJALDBJMN(long PDOJDMECHAM);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CALGNJLGHDH<PNJFLFBCBJP, GBHFJBFIHDK> HMHOPDCHGOD(long PDOJDMECHAM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CALGNJLGHDH<long, MMDKKMJKCJP> NJOHJJOBFCN();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LIGBNDIPGFO(long PDOJDMECHAM, [Out] bool FCHJGPEMCNM);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> BOGAPCKGBFF(byte[] PFHICJBHJNE, byte[] FGBBGGCPMMJ, CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface FNHHMHANIPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool JGJOHEDDCJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool HKALPCHENAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	MCAMNJOCGLN BOBJHDCEPED
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action ADPNGHDJNAI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event HPEIEJMFLLC MDBKONPDCIB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event HPEIEJMFLLC LPLMDDHBPGI;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event HPEIEJMFLLC MMONNGFFEED;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<PHKHCKBHGEB, bool> KMHBHOBALBP;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BBKAPAHEMFA();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DNBBCIDJOCM EIKJHNDKEFP();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MONMCGNKION IIHODBOPHEP();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<CEFINKDJEPJ> LCHDKFMIIEM(GDMCCAIBAAO ALHPIJFCLMO);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task JCLDBHGOKOJ(CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface CLEMMADEOBN
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool HFAEMNDHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string KDKFHDOIFDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHPELBCAEFC(Scene DFILHCFLAJK);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KLKEOIFKIGA(DFGCDAECACO NMCCDEMCLNA, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task BEMEDANJOFA();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task CMPBHEKMDMB();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface EHLDCOMLOKA
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	KLDHFEKEHPL AELNFGOMKIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool LOGNCNEAMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool GJJPHIMHHHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool IIBJANPILFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool LJHMECFOOHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int KDNPGGANEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool CJENECIHCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool OAIBNHOGIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	int DFBMDIFCNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int MEBNNGLBNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool MOFFCPHCHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool JHKGDAPLHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool ICHNADBBNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float GCNDNLHLNFM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> KAJJMFDPIFN;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ACFNHMKNHLL KIPOHPPIOBH(ACFNHMKNHLL GLFNOJJKPGM);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKDJICAACBO(ACFNHMKNHLL KLAPMCLMAPI);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LPAAGHNEIMI();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task FAFENPMFLEO(PMKGFNIFFEC<string>.INNANANOCLO PAFMLHOBAMA, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JBNNECPFBGO(float ONLJCHACJEP);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LJPDELHAIGE(string GLEFGBFPDGL);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<OIIJPEDCKAB> EFJOLKDHBLL();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable KAMBIODJELB(object JCPOMHNJOIE, OIIJPEDCKAB CNAPGMPCKKJ);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<HGNNFKMNJBJ> INEMLAIBCFB();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GIMIMNLPGGB BLADBDCOINK(IEnumerable<FGFJJKFMCDJ> BNJAJJDKNIL);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HJFEMMLJMKF(int IABOOOMGHFL);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task GLICDABOIBM();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KDJBHEKIIGB();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool FHOCMLOBKNC();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task DFAIEOMEFCH(CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task POMBOOIKOMK(CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<MKAHJOOCHOL> GOOGIJPODKI(DateTime PNHEGHLDMOC, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> MMIFEOIFAHJ(CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ALMHCFALEGJ(string ADPAIBGIHMB = "", float HBCBOLHLONH = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "25")]
	OBEEEAOBNEH ENLDAFDKKNA(IHFJLNHDCBG DFFPHKBABGI, GEAJINJHAGD FECDMFCELGL, GBHFJBFIHDK PCDOFDHACEA, IEnumerable<PersistenceView> AMOIAJMCMFF, HANOONHMDKF OENLMJDIFGC);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HKGLBLEHNFC(GBHFJBFIHDK PCDOFDHACEA);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NCNDDPDGLFG(FGFJJKFMCDJ BLFEKFIMKCH, [In] OBEEEAOBNEH IHLGGICNOOB);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task FMOGBAGGNKF(GBHFJBFIHDK KKIHEEBCEIB, bool FOJIFJJFEOE, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task KBPGGLAIMMD(CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MNJBHDHOBDH(long HLGODMOGCOI, long LBMLFGGHFGP, JKIABJFEAHD ENDIDOEDCIB, GAFBGJLGAKK ONJLCEIGFBA, IOMOLFGHOOF IDDBGNNFLGM, PKOOPKBNGEK? HJOEHEMELJN, IODGLGMPJNA? PAHOJBAFDIC);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void JJOMMFPLECN(long HLGODMOGCOI, long LBMLFGGHFGP, IODGLGMPJNA? PAHOJBAFDIC);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void DFCJMLKFOAI(PersistenceView JJABBEIHCBC);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool HCIHGNAAOJB(PersistenceView DOKLPJEMEAH);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool LPPCIGPJANO(FGFJJKFMCDJ BLFEKFIMKCH, NHKMAHFIMNB JJIMCHIAKMB, [Out] CLNPNHAKDGO IHCKOJDMMDG);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task CFAPFCGGHEM(CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void EOLJGIPCPII();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable AGDNOPOIGDL();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void MIFPJFJOCHO(GBHFJBFIHDK KKIHEEBCEIB, NHKMAHFIMNB JJIMCHIAKMB);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> KKEDCMBMFDL(ECJBOAIKALM GLAAFJDOHIB, CancellationToken EEHACKMODLA, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void ODIPKKDOAEF(CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<DEDLCGKHLHK> PFCBHFGKMAN(AMAAKMOMMGA JHKMPCADNAF);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<JKIABJFEAHD> IBMAHGPKLBL(long HLGODMOGCOI, bool CNDPPCOINFL, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<GAFBGJLGAKK> HKIINOJDMCF(long HLGODMOGCOI, long LBMLFGGHFGP, long LBEABPMGLBN, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<GAFBGJLGAKK> EMGAGKIIJIK(long HLGODMOGCOI, long LBMLFGGHFGP, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<MAKKJAEMIAE> DGGKLFGFDPI(string HJDGGKDHLAJ, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<MAKKJAEMIAE> BCIPADGEKHO(string HJDGGKDHLAJ, long HLGODMOGCOI, long LBMLFGGHFGP, string ABFNDBDJBEH, LBGJIEJHAJH.CIGONCEALPB CAAMOPOAIJO, LBGJIEJHAJH.CIGONCEALPB FGBBGGCPMMJ, int JGOGDPEFFEP);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool MLPIEAFCDOP();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool MOLHECBKGFF();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool LELAAPJOEEP(IEnumerable<CLNPNHAKDGO> KCDGCLHMHMI);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void JBJNJKOPJJI(List<GameObject> JMNABIHPIDJ);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float GPDLKMNKFJD();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> MCGDKCCMJPJ(string KLBNILGILEM, LoadSceneMode HIIPLOOBLJO, bool GAPNJMHJJDP, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void CCBDPECLKDM();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void CIBBOIPHNEL(bool PNHMPKNFDBD);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void HHDKJNEFLED();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void HPOJACIJBJA();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void EKJLDDIEAPP(GAGHJCEIHCL BFAOCBCJEPK);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task MNOOAPGEMNP(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task IDGOIMMGBIK(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task BEGJNDJFHDJ(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task AOHPCIFCFBD(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable JICLMLLGNBC();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "73")]
	CEKCIOBJGIF CGBIAMMLOIK();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task GBACFMEGBEO(CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface CEKCIOBJGIF
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KLCMDHEHGJN(CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JLCGGFKJECL(CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct OBEEEAOBNEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> AANDIBBPIEA;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum MKAHJOOCHOL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct IHFJLNHDCBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string FICFCOFOCPM;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface KLDHFEKEHPL
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	GAGHJCEIHCL CIGGHNLIEOE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	JKIABJFEAHD BGOEEACBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	OCIJPHOBBHK DCHIACPPKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool GIKHELDILMA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool PBNJMHIOMLM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int IAKBJJIHGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action EPNLKMJCAHO;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> GPFDMKFOBKP;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DLGLPFDDHGI();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.JCEAEFJKGJA> MBKNKALJPFC(long PDOJDMECHAM, [Optional] CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<CCAIDKLLLJD> ICAAOJGENAA();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task CEFPLDDMPKK();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(GAGHJCEIHCL, MCAMNJOCGLN) OKLGMLBKEPF();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DNKNIBGJGBA KEGHHNPPDAG();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DOHGAHDEJDM(long PDOJDMECHAM);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IFIGEBPCJNN(GAGHJCEIHCL NGFGPIIAAKC, Matchmaking.GGLBOMAGOCE CIFMGKBFCHA, (int Major, int? Minor)? CCPMBLJCLDM);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface DEKIAMBHKHB
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IOCKHCDGHJK([Out] IEnumerable<int> EJGEJKABMNE);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EDFHHJGLAKG(JEGFLDIDKCF FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBLLGBGMJIP(JEGFLDIDKCF FDAIGOGAKMH);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CBBEFDLONGM
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KIFFMIGGFFM(CEFINKDJEPJ IGHKPAMMJCF);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface DAELNCEPFGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIDCFPMBCHN(NDENECHCDCF.HMNJOFFEMCD JNGPOMJAACO);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKHEOMFIJGC(NDENECHCDCF.HMNJOFFEMCD JNGPOMJAACO);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GMMBDIEALIP : DAELNCEPFGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CEFINKDJEPJ HPPCPKADBCI(NGDBFKPHNOF OJJIKOKMIHA);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface EPAOBPAKFLI : DAELNCEPFGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CEFINKDJEPJ HNECEBFPIJL(NGDBFKPHNOF NMLJOPBBABK);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface HCDHHLCAOLO
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MLIDCCDLMIE<DFGCDAECACO, IDBHBLPOJHF>> ALENADIDKEE(string ABFNDBDJBEH, long PDOJDMECHAM, long? HLGODMOGCOI, long? LBMLFGGHFGP, JGBNIGAIAMJ.KMIHOEJJGBM DGCKOEAILPD, CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface CALGNJLGHDH<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MLIDCCDLMIE<FGAAJMCNHCK<TData>, IDBHBLPOJHF>> DGLFDKACOOL(TGetDataArg MGBFBAKCCAP, CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class AKODCHCMKNK : EKHKFFBCABL, FNHHMHANIPH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct CPCCPDFIMHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<CEFINKDJEPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AKODCHCMKNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public GDMCCAIBAAO autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<CEFINKDJEPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x74AAE70", Offset = "0x74AA270", VA = "0x1874AAE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x74AB0F0", Offset = "0x74AA4F0", VA = "0x1874AB0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct CGKDHBJMHAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AKODCHCMKNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x74AA4C0", Offset = "0x74A98C0", VA = "0x1874AA4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x74AA6F0", Offset = "0x74A9AF0", VA = "0x1874AA6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class MNCOCPPDOJM : IEnumerable<FMCNBGHPHLG>, IEnumerable, IEnumerator<FMCNBGHPHLG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private FMCNBGHPHLG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AKODCHCMKNK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		private FMCNBGHPHLG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
		[DebuggerHidden]
		public MNCOCPPDOJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x74BE210", Offset = "0x74BD610", VA = "0x1874BE210", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x74BE670", Offset = "0x74BDA70", VA = "0x1874BE670", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x74BE5C0", Offset = "0x74BD9C0", VA = "0x1874BE5C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FMCNBGHPHLG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x74BE5C0", Offset = "0x74BD9C0", VA = "0x1874BE5C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource KEEGOPAJPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly ACFNHMKNHLL KLAPMCLMAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool HLAMJAHICLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private IHIGAMANPCK IHIPNIDDPBF;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public ECJBOAIKALM FNNPAOGDPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB10", Offset = "0x8AEF10", VA = "0x1808AFB10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC10", Offset = "0x8AF010", VA = "0x1808AFC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public HIHPADIBAKP KMKAKAPFPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBA0", Offset = "0x8ACFA0", VA = "0x1808ADBA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB90", Offset = "0x8ACF90", VA = "0x1808ADB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public EHLDCOMLOKA HEHDJMJINLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB80", Offset = "0x8ACF80", VA = "0x1808ADB80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBC0", Offset = "0x8ACFC0", VA = "0x1808ADBC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public CLEMMADEOBN GNJEBHFINEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBE0", Offset = "0x8ACFE0", VA = "0x1808ADBE0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBB0", Offset = "0x8ACFB0", VA = "0x1808ADBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public GMMBDIEALIP KDOENBLCAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC00", Offset = "0x8AD000", VA = "0x1808ADC00", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB70", Offset = "0x8ACF70", VA = "0x1808ADB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public EPAOBPAKFLI PAMEBHIPFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBD0", Offset = "0x8ACFD0", VA = "0x1808ADBD0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBF0", Offset = "0x8ACFF0", VA = "0x1808ADBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public NFPKNMPBOLJ CMKIGMNOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB20", Offset = "0x8AEF20", VA = "0x1808AFB20", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8AFAA0", Offset = "0x8AEEA0", VA = "0x1808AFAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public NNPLAABFNGE JPHPAMIDNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB40", Offset = "0x8AEF40", VA = "0x1808AFB40", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC20", Offset = "0x8AF020", VA = "0x1808AFC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public JLEHKIMOEJC PBPPHIHIGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC40", Offset = "0x8AF040", VA = "0x1808AFC40", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBF0", Offset = "0x8AEFF0", VA = "0x1808AFBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public KOEDPHHOMHP DMPKPKKCDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x919AC0", Offset = "0x918EC0", VA = "0x180919AC0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xE05300", Offset = "0xE04700", VA = "0x180E05300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public KHNGFKKFBPM EIKBBBLDBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA70", Offset = "0x8AEE70", VA = "0x1808AFA70", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBA0", Offset = "0x8AEFA0", VA = "0x1808AFBA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public ADIDNHCGFEO PONBBNLHGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9EA8E0", Offset = "0x9E9CE0", VA = "0x1809EA8E0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9DFEB0", Offset = "0x9DF2B0", VA = "0x1809DFEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public OFDIHMKLHIB IDNKCOACKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B10", Offset = "0x8B3F10", VA = "0x1808B4B10", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B40", Offset = "0x8B3F40", VA = "0x1808B4B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public GEGKDJHNBPC ALEAOJGIOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x963E50", Offset = "0x963250", VA = "0x180963E50", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9EEB60", Offset = "0x9EDF60", VA = "0x1809EEB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public GAOEJCBIEOJ OMONJMJPGBP
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x95E920", Offset = "0x95DD20", VA = "0x18095E920", Slot = "57")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xDEBAB0", Offset = "0xDEAEB0", VA = "0x180DEBAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public PHBHICGLBJK LCIMDOEACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9081E0", Offset = "0x9075E0", VA = "0x1809081E0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xC5C840", Offset = "0xC5BC40", VA = "0x180C5C840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public KHMGHFGENFF FLDGFOKAOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x908230", Offset = "0x907630", VA = "0x180908230", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x962BB0", Offset = "0x961FB0", VA = "0x180962BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public FJBHGDKNFEH JOHFCLFLKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x95E710", Offset = "0x95DB10", VA = "0x18095E710", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA42360", Offset = "0xA41760", VA = "0x180A42360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public BNINCIEKNLD GKCGJELAFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8B4BA0", Offset = "0x8B3FA0", VA = "0x1808B4BA0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B80", Offset = "0x8B3F80", VA = "0x1808B4B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public INMBLPBBGFE MHKODHLJLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x95E8D0", Offset = "0x95DCD0", VA = "0x18095E8D0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xCE8750", Offset = "0xCE7B50", VA = "0x180CE8750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public FEKDDEEOGIE FNBCCGGINNB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x95E8C0", Offset = "0x95DCC0", VA = "0x18095E8C0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xE97BC0", Offset = "0xE96FC0", VA = "0x180E97BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public PDMMCOOFBKL LHMJNPGHOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F4FB0", VA = "0x1808F5BB0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xE97BA0", Offset = "0xE96FA0", VA = "0x180E97BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public OIPBPNIBPBJ CALEIJNALNP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x95E7C0", Offset = "0x95DBC0", VA = "0x18095E7C0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xCE9430", Offset = "0xCE8830", VA = "0x180CE9430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public DEKIAMBHKHB MHDGJPNDNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x95E9B0", Offset = "0x95DDB0", VA = "0x18095E9B0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC00", Offset = "0x9DC000", VA = "0x1809DCC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public KNABIBLMPBC EMBBLDNLEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9081F0", Offset = "0x9075F0", VA = "0x1809081F0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xE97D20", Offset = "0xE97120", VA = "0x180E97D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KALCCDBBFGA CMKIEOBFAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x95E830", Offset = "0x95DC30", VA = "0x18095E830", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xE97CE0", Offset = "0xE970E0", VA = "0x180E97CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public ICIFGLNNOMK LACHBDAHMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x95E860", Offset = "0x95DC60", VA = "0x18095E860", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xD65950", Offset = "0xD64D50", VA = "0x180D65950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public EPPKPIPMEHD GNICAAKKLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x95E840", Offset = "0x95DC40", VA = "0x18095E840", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public ACJAHDLOKAN KDAGALGKGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x95E850", Offset = "0x95DC50", VA = "0x18095E850", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public DCBBIABKPIP NFENGHLMODE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95DC70", VA = "0x18095E870", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public KKELKFJEAOL DEGIHEBGKLK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x95E880", Offset = "0x95DC80", VA = "0x18095E880", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public GBMONCCFIHJ AFFJOOMMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x906470", Offset = "0x905870", VA = "0x180906470", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public MCAMNJOCGLN BOBJHDCEPED
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA34E50", Offset = "0xA34250", VA = "0x180A34E50", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xE97C00", Offset = "0xE97000", VA = "0x180E97C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private bool AIOHOHDMAED
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x74A7310", Offset = "0x74A6710", VA = "0x1874A7310", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private bool MCHFKJOPDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x74A7390", Offset = "0x74A6790", VA = "0x1874A7390", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private CancellationToken NPMNKPPMFMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x74A7370", Offset = "0x74A6770", VA = "0x1874A7370", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private ACFNHMKNHLL HMLILGMAALG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action JADFODAFIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x74A7010", Offset = "0x74A6410", VA = "0x1874A7010", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x74A7410", Offset = "0x74A6810", VA = "0x1874A7410", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event HPEIEJMFLLC BPGIGLGOILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x74A6EF0", Offset = "0x74A62F0", VA = "0x1874A6EF0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x74A7670", Offset = "0x74A6A70", VA = "0x1874A7670", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event HPEIEJMFLLC PGGMJKHOPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x74A76D0", Offset = "0x74A6AD0", VA = "0x1874A76D0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x74A7610", Offset = "0x74A6A10", VA = "0x1874A7610", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event HPEIEJMFLLC HLKEKJGEINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x74A6FB0", Offset = "0x74A63B0", VA = "0x1874A6FB0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x74A6E90", Offset = "0x74A6290", VA = "0x1874A6E90", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<PHKHCKBHGEB, bool> KIJEMBGLCGO
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x74A7470", Offset = "0x74A6870", VA = "0x1874A7470", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x74A7980", Offset = "0x74A6D80", VA = "0x1874A7980", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0xE97C00", Offset = "0xE97000", VA = "0x180E97C00", Slot = "37")]
	public void OCBMHOPFKLN(MCAMNJOCGLN HCGECOFKBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x74A79E0", Offset = "0x74A6DE0", VA = "0x1874A79E0")]
	[UnityEngine.Scripting.Preserve]
	internal AKODCHCMKNK([ACGOIOBGIEE(null)] ACFNHMKNHLL KLAPMCLMAPI, [ACGOIOBGIEE(null)] ECJBOAIKALM GLAAFJDOHIB, [ACGOIOBGIEE(null)] HIHPADIBAKP LHJMAKKPBPF, [ACGOIOBGIEE(null)] EHLDCOMLOKA AJKICPHDFFF, [ACGOIOBGIEE(null)] CLEMMADEOBN NJBGOONPDOG, [ACGOIOBGIEE(null)] GMMBDIEALIP DNGPIIOIJPJ, [ACGOIOBGIEE(null)] EPAOBPAKFLI MFEJFFLILMN, [ACGOIOBGIEE(null)] NFPKNMPBOLJ DGBJOLGAOBH, [ACGOIOBGIEE(null)] NNPLAABFNGE KHKAAEIAMOI, [ACGOIOBGIEE(null)] JLEHKIMOEJC CHGCJMHMLOF, [ACGOIOBGIEE(null)] KOEDPHHOMHP FHGBEFFJLGP, [ACGOIOBGIEE(null)] KHNGFKKFBPM FJEJGNKAFKL, [ACGOIOBGIEE(null)] ADIDNHCGFEO ONBBIANMAJI, [ACGOIOBGIEE(null)] OFDIHMKLHIB GONELHEMLGH, [ACGOIOBGIEE(null)] GEGKDJHNBPC NCMDHCKDKHJ, [ACGOIOBGIEE(null)] GAOEJCBIEOJ EJNLGHEKKFJ, [ACGOIOBGIEE(null)] PHBHICGLBJK NEHLCLPCCFG, [ACGOIOBGIEE(null)] KHMGHFGENFF MMEKJGGFALG, [ACGOIOBGIEE(null)] FJBHGDKNFEH LLNEGOAPOGD, [ACGOIOBGIEE(null)] BNINCIEKNLD OLIFPFEKIHO, [ACGOIOBGIEE(null)] FEKDDEEOGIE HFAAECNOPBN, [ACGOIOBGIEE(null)] INMBLPBBGFE CNNIJNGGNOI, [ACGOIOBGIEE(null)] PDMMCOOFBKL LIFKAPNFGPL, [ACGOIOBGIEE(null)] OIPBPNIBPBJ JMJLIBHHCLL, [ACGOIOBGIEE(null)] DEKIAMBHKHB DFLOLINJEIM, [ACGOIOBGIEE(null)] KALCCDBBFGA IBOPOOBMBOE, [ACGOIOBGIEE(null)] ICIFGLNNOMK HLAMNPFMDCF, [ACGOIOBGIEE(null)] EPPKPIPMEHD ABPJNNCAPMG, [ACGOIOBGIEE(null)] ACJAHDLOKAN GLABHDEACMN, [ACGOIOBGIEE(null)] DCBBIABKPIP COODHJNFNHN, [ACGOIOBGIEE(null)] KKELKFJEAOL KHMAICDCBBO, [ACGOIOBGIEE(null)] GBMONCCFIHJ LGHIJIABLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x74A74D0", Offset = "0x74A68D0", VA = "0x1874A74D0")]
	private void JLABJFAHLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x74A7070", Offset = "0x74A6470", VA = "0x1874A7070", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x74A7730", Offset = "0x74A6B30", VA = "0x1874A7730", Slot = "50")]
	private void MINKJKDONDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x74A7280", Offset = "0x74A6680", VA = "0x1874A7280", Slot = "51")]
	private DNBBCIDJOCM EGGBEGPMGBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x74A7580", Offset = "0x74A6980", VA = "0x1874A7580", Slot = "52")]
	private MONMCGNKION JOBCPEKDBBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x74A7870", Offset = "0x74A6C70", VA = "0x1874A7870", Slot = "53")]
	[AsyncStateMachine(typeof(CPCCPDFIMHC))]
	private Task<CEFINKDJEPJ> OJGNLHLLLOD(GDMCCAIBAAO CMKALAGCPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x74A7780", Offset = "0x74A6B80", VA = "0x1874A7780", Slot = "54")]
	[AsyncStateMachine(typeof(CGKDHBJMHAB))]
	private Task ODLKBODENKB(CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x74A7200", Offset = "0x74A6600", VA = "0x1874A7200")]
	[IteratorStateMachine(typeof(MNCOCPPDOJM))]
	private IEnumerable<FMCNBGHPHLG> EGFJJNLJLPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x74A6F50", Offset = "0x74A6350", VA = "0x1874A6F50")]
	[CompilerGenerated]
	private void BIFDNBDOIDN(FMCNBGHPHLG FCNHHPDOLNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class EGBGNMHDDBA : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x12277C0", Offset = "0x1226BC0", VA = "0x1812277C0")]
	public EGBGNMHDDBA(string ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class DHICPJBCPBI : NFOECPNMOBG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct KKOIHFCBIGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public DHICPJBCPBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x74BBDD0", Offset = "0x74BB1D0", VA = "0x1874BBDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x74BC110", Offset = "0x74BB510", VA = "0x1874BC110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly EHLDCOMLOKA AJKICPHDFFF;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CD0", Offset = "0x8A90D0", VA = "0x1808A9CD0")]
	public DHICPJBCPBI(EKHKFFBCABL NOGMIFBJMHC, EHLDCOMLOKA AJKICPHDFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x74AC510", Offset = "0x74AB910", VA = "0x1874AC510", Slot = "4")]
	[AsyncStateMachine(typeof(KKOIHFCBIGG))]
	public Task<bool> HKAOICHMMEL(CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x74AC430", Offset = "0x74AB830", VA = "0x1874AC430")]
	[CompilerGenerated]
	private object DIOJBOFMMHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class NDFLLJDJJHO : NFOECPNMOBG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct ALAJNFIBJLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public NDFLLJDJJHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x74A7E50", Offset = "0x74A7250", VA = "0x1874A7E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x74A8560", Offset = "0x74A7960", VA = "0x1874A8560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly EHLDCOMLOKA AJKICPHDFFF;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private KLDHFEKEHPL AELNFGOMKIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x74BEDB0", Offset = "0x74BE1B0", VA = "0x1874BEDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CD0", Offset = "0x8A90D0", VA = "0x1808A9CD0")]
	public NDFLLJDJJHO(EKHKFFBCABL NOGMIFBJMHC, EHLDCOMLOKA AJKICPHDFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x74BEC80", Offset = "0x74BE080", VA = "0x1874BEC80", Slot = "4")]
	[AsyncStateMachine(typeof(ALAJNFIBJLG))]
	public Task<bool> HKAOICHMMEL(CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x74BEBA0", Offset = "0x74BDFA0", VA = "0x1874BEBA0")]
	[CompilerGenerated]
	private object BIIJDEMLJEB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class NDGABJCGMBA : NFOECPNMOBG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class OIFEHMELKFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public NDGABJCGMBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CCAIDKLLLJD result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public GAGHJCEIHCL newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public OIFEHMELKFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x74C1F40", Offset = "0x74C1340", VA = "0x1874C1F40")]
		internal object LPLLNKBNPIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x74C1ED0", Offset = "0x74C12D0", VA = "0x1874C1ED0")]
		internal object LLHLDGCHHHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x74C2030", Offset = "0x74C1430", VA = "0x1874C2030")]
		internal object OHOFOIHJGHJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct JPHOJGJADID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public NDGABJCGMBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private OIFEHMELKFG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<CCAIDKLLLJD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x74BB400", Offset = "0x74BA800", VA = "0x1874BB400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x74BBD10", Offset = "0x74BB110", VA = "0x1874BBD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly EHLDCOMLOKA AJKICPHDFFF;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private KLDHFEKEHPL AELNFGOMKIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x74BEF20", Offset = "0x74BE320", VA = "0x1874BEF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CD0", Offset = "0x8A90D0", VA = "0x1808A9CD0")]
	public NDGABJCGMBA(EKHKFFBCABL NOGMIFBJMHC, EHLDCOMLOKA AJKICPHDFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x74BEE00", Offset = "0x74BE200", VA = "0x1874BEE00", Slot = "4")]
	[AsyncStateMachine(typeof(JPHOJGJADID))]
	public Task<bool> HKAOICHMMEL(CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal interface NFOECPNMOBG
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> HKAOICHMMEL(CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct CFNGPOIGEAA
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class KICEICANGKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public EKHKFFBCABL manager;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KICEICANGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x74BBD80", Offset = "0x74BB180", VA = "0x1874BBD80")]
		internal Task FICMNMPKLIH(CancellationToken cancellationToken, int roomTotalVersion, MJIHINAKBBL localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct EHEFLDHHLBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CFNGPOIGEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private GDMCCAIBAAO <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<MKAHJOOCHOL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<CEFINKDJEPJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x74AD220", Offset = "0x74AC620", VA = "0x1874AD220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x74AD7B0", Offset = "0x74ACBB0", VA = "0x1874AD7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct LLGBBKGPADO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public CFNGPOIGEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x74BC430", Offset = "0x74BB830", VA = "0x1874BC430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x74BC750", Offset = "0x74BBB50", VA = "0x1874BC750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CancellationToken EEHACKMODLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly EKHKFFBCABL HPCAPMNEHGA;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private ECJBOAIKALM FNNPAOGDPOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x74AA470", Offset = "0x74A9870", VA = "0x1874AA470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private EHLDCOMLOKA HEHDJMJINLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x74AA280", Offset = "0x74A9680", VA = "0x1874AA280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private KLDHFEKEHPL AELNFGOMKIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x74AA3A0", Offset = "0x74A97A0", VA = "0x1874AA3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private JLEHKIMOEJC PBPPHIHIGMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x74AA420", Offset = "0x74A9820", VA = "0x1874AA420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x222CCE0", Offset = "0x222C0E0", VA = "0x18222CCE0")]
	public CFNGPOIGEAA(CancellationToken EEHACKMODLA, EKHKFFBCABL HPCAPMNEHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x74A9D80", Offset = "0x74A9180", VA = "0x1874A9D80")]
	public static JLOKIJKJCMM BEJMJCMAMDD(EKHKFFBCABL HPCAPMNEHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x74AA040", Offset = "0x74A9440", VA = "0x1874AA040")]
	[AsyncStateMachine(typeof(EHEFLDHHLBK))]
	public Task<bool> EHNFAJDFHCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x74A9E30", Offset = "0x74A9230", VA = "0x1874A9E30")]
	private bool DNMEGBDPJIO([Out] GDMCCAIBAAO CMKALAGCPMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x74AA2D0", Offset = "0x74A96D0", VA = "0x1874AA2D0")]
	[AsyncStateMachine(typeof(LLGBBKGPADO))]
	private Task IFIGAMFBDAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x74AA150", Offset = "0x74A9550", VA = "0x1874AA150")]
	private Task<MKAHJOOCHOL> GJHPNCHOGPB(GDMCCAIBAAO PFHMLLKLNAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct GCBBBMGKMGD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly GEGKDJHNBPC NCMDHCKDKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Guid NJALKLIOMDE;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Task<(CEFINKDJEPJ, Task)> FMCLDANHCPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x74B9730", Offset = "0x74B8B30", VA = "0x1874B9730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x45CBF00", Offset = "0x45CB300", VA = "0x1845CBF00")]
	public GCBBBMGKMGD(GEGKDJHNBPC NCMDHCKDKHJ, Guid NJALKLIOMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x74B9800", Offset = "0x74B8C00", VA = "0x1874B9800")]
	public TaskAwaiter<(CEFINKDJEPJ, Task)> LFNEGOGFAAD()
	{
		return default(TaskAwaiter<(CEFINKDJEPJ, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x74B9660", Offset = "0x74B8A60", VA = "0x1874B9660", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct OEBIJNLDCCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly TaskCompletionSource<(CEFINKDJEPJ, Task)> IJPEAMLNCKP;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Task<(CEFINKDJEPJ, Task)> FMCLDANHCPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x74C0F50", Offset = "0x74C0350", VA = "0x1874C0F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x74C1110", Offset = "0x74C0510", VA = "0x1874C1110")]
	public OEBIJNLDCCP(TimeSpan JHOELLEDCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x74C1020", Offset = "0x74C0420", VA = "0x1874C1020")]
	public void HCAFKBADLOD(Task CENFKNMGKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x74C0F90", Offset = "0x74C0390", VA = "0x1874C0F90")]
	public void GOPKBCLCIMC(CEFINKDJEPJ IGHKPAMMJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x74C10C0", Offset = "0x74C04C0", VA = "0x1874C10C0")]
	public void LMBKNOJNFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x74C0EC0", Offset = "0x74C02C0", VA = "0x1874C0EC0")]
	internal void ECEMMMNGOJO(string ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class DDKAFDHNENE
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class FHEOIKKKABO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public GAFBGJLGAKK subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public FHEOIKKKABO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x74B54E0", Offset = "0x74B48E0", VA = "0x1874B54E0")]
		internal bool LHBMIHCKMDE(OCIJPHOBBHK s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x74AB630", Offset = "0x74AAA30", VA = "0x1874AB630")]
	public static DKKGGCCNPKP LIDOGEGODKP(long FCGGEAOJELI, long LBMLFGGHFGP, string HJDGGKDHLAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x74AB570", Offset = "0x74AA970", VA = "0x1874AB570")]
	public static DKKGGCCNPKP LIDOGEGODKP(long FCGGEAOJELI, long LBMLFGGHFGP, PNJFLFBCBJP PFHICJBHJNE, long LBEABPMGLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x74AB3E0", Offset = "0x74AA7E0", VA = "0x1874AB3E0")]
	public static DKKGGCCNPKP LIDOGEGODKP(DEDLCGKHLHK OJIBCICIPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x74AB6C0", Offset = "0x74AAAC0", VA = "0x1874AB6C0")]
	public static DKKGGCCNPKP LIDOGEGODKP(JKIABJFEAHD NMCLIMCEFOL, GAFBGJLGAKK DOLMDPEFIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x74AB160", Offset = "0x74AA560", VA = "0x1874AB160")]
	public static DKKGGCCNPKP DCEIMABOKKJ(this DKKGGCCNPKP NNNHDMLPIGD, JKIABJFEAHD FBELNMGGOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x74AB250", Offset = "0x74AA650", VA = "0x1874AB250")]
	public static DKKGGCCNPKP JICNHKEJBKP(this DKKGGCCNPKP NNNHDMLPIGD, GAFBGJLGAKK LHLIPDIIGOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RecRoom.NoEngine.Common.Preserve]
internal class EGAODJFJLMN : NNPLAABFNGE, FMCNBGHPHLG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct BFHHPMBDNOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public EGAODJFJLMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x74A9530", Offset = "0x74A8930", VA = "0x1874A9530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x74A9BC0", Offset = "0x74A8FC0", VA = "0x1874A9BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly JEGFLDIDKCF IMABOFBJADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private string HGGDCIHCCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Task FFNBLFEPODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool AFHEEECKMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x74ACFB0", Offset = "0x74AC3B0", VA = "0x1874ACFB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Task EOIHLHMAEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x74AD100", Offset = "0x74AC500", VA = "0x1874AD100", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8A9F60", Offset = "0x8A9360", VA = "0x1808A9F60", Slot = "7")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x74ACE50", Offset = "0x74AC250", VA = "0x1874ACE50", Slot = "6")]
	public void AOMKNOCIIPE(Task BIDGKFLMMBN, string FICDEMFGBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x74ACFE0", Offset = "0x74AC3E0", VA = "0x1874ACFE0")]
	[AsyncStateMachine(typeof(BFHHPMBDNOB))]
	private Task KFAOMNIEDIB(Task OANCLONEIKP, string FICDEMFGBLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x74AD190", Offset = "0x74AC590", VA = "0x1874AD190")]
	public EGAODJFJLMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class CMEPPDLAJHF : KNABIBLMPBC, FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool OJPOHGAENCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private GGGLGKDJBLD JHODHHOLMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private ECJBOAIKALM GLAAFJDOHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private KALCCDBBFGA IBOPOOBMBOE;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public GGGLGKDJBLD CEKIHPLHINM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x74AAE00", Offset = "0x74AA200", VA = "0x1874AAE00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x74AAAD0", Offset = "0x74A9ED0", VA = "0x1874AAAD0", Slot = "7")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x74AAC50", Offset = "0x74AA050", VA = "0x1874AAC50", Slot = "5")]
	public void KNGOICMAILC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x74AA9D0", Offset = "0x74A9DD0", VA = "0x1874AA9D0", Slot = "6")]
	public void JGOHHAIOIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x74AAA10", Offset = "0x74A9E10", VA = "0x1874AAA10")]
	private Task HDPGIOOLNFK(PGFODMOFFAA PAHNKMKPPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x74AA9D0", Offset = "0x74A9DD0", VA = "0x1874AA9D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public CMEPPDLAJHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class BBBBCOGGIPG : KALCCDBBFGA
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class KLALFOKGMOE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly CCENJGFOMNL LJNLIKDCHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly string GMJINMLEEAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly T JGBDACMOCCC;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public T JKEIFELLNME
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x918830", Offset = "0x917C30", VA = "0x180918830")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x9822A0", Offset = "0x9816A0", VA = "0x1809822A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x454C950", Offset = "0x454BD50", VA = "0x18454C950")]
		public KLALFOKGMOE(CCENJGFOMNL LJNLIKDCHMP, string GMJINMLEEAC, T JGBDACMOCCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x454C230", Offset = "0x454B630", VA = "0x18454C230")]
		private void LILIIANOKGJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly CCENJGFOMNL LJNLIKDCHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly KLALFOKGMOE<TimeSpan> CPEPPKJCCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly KLALFOKGMOE<TimeSpan> PGNBDKMDJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly KLALFOKGMOE<TimeSpan> LBJEEEFGBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly KLALFOKGMOE<TimeSpan> GEOHNKJBHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly KLALFOKGMOE<bool> MFDJCMGPPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly KLALFOKGMOE<bool> GADAHMPCDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly KLALFOKGMOE<bool> GGCMKIJMCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly KLALFOKGMOE<int> BMDCLPIAMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly KLALFOKGMOE<bool> AIFHAOJPEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly KLALFOKGMOE<bool> ABGCLFLKBHP;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TimeSpan CJOPNNDLLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x74A8700", Offset = "0x74A7B00", VA = "0x1874A8700", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TimeSpan IOFFNABOCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x74A8880", Offset = "0x74A7C80", VA = "0x1874A8880", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TimeSpan BNGOKIFMKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x74A88C0", Offset = "0x74A7CC0", VA = "0x1874A88C0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public TimeSpan HEFMAEJOFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x74A87C0", Offset = "0x74A7BC0", VA = "0x1874A87C0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool BFNGIPJLCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x74A8740", Offset = "0x74A7B40", VA = "0x1874A8740", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool BBAHHCJHCME
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x74A8800", Offset = "0x74A7C00", VA = "0x1874A8800", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool HECMDKHONMB
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x74A8840", Offset = "0x74A7C40", VA = "0x1874A8840", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int DKLJFKIHLCE
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x74A8780", Offset = "0x74A7B80", VA = "0x1874A8780", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool NDJNDJIGPBE
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x74A8680", Offset = "0x74A7A80", VA = "0x1874A8680", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool LLFNFFBOBGL
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x74A86C0", Offset = "0x74A7AC0", VA = "0x1874A86C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x74A8900", Offset = "0x74A7D00", VA = "0x1874A8900")]
	[UnityEngine.Scripting.Preserve]
	public BBBBCOGGIPG([ACGOIOBGIEE(null)] CCENJGFOMNL LJNLIKDCHMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class LOLKBGGGEBO : KOEDPHHOMHP, FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class DEKGBJJGDBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public HLIJPGBPOLB roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public DEKGBJJGDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x74AB8F0", Offset = "0x74AACF0", VA = "0x1874AB8F0")]
		internal object AHMDANGNJFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action ADPNGHDJNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x74BCAC0", Offset = "0x74BBEC0", VA = "0x1874BCAC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x74BCB60", Offset = "0x74BBF60", VA = "0x1874BCB60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event HPEIEJMFLLC MDBKONPDCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x74BD200", Offset = "0x74BC600", VA = "0x1874BD200", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x74BC9A0", Offset = "0x74BBDA0", VA = "0x1874BC9A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event HPEIEJMFLLC LPLMDDHBPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x74BD100", Offset = "0x74BC500", VA = "0x1874BD100", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x74BC7B0", Offset = "0x74BBBB0", VA = "0x1874BC7B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event HPEIEJMFLLC MMONNGFFEED
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x74BD060", Offset = "0x74BC460", VA = "0x1874BD060", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x74BC850", Offset = "0x74BBC50", VA = "0x1874BC850", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<PHKHCKBHGEB, bool> KMHBHOBALBP
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x74BCDC0", Offset = "0x74BC1C0", VA = "0x1874BCDC0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x74BC8F0", Offset = "0x74BBCF0", VA = "0x1874BC8F0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "19")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x74BCE70", Offset = "0x74BC270", VA = "0x1874BCE70", Slot = "14")]
	public void KCIFLPBADDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x74BD1D0", Offset = "0x74BC5D0", VA = "0x1874BD1D0", Slot = "15")]
	public void OHGBHLJPGPH(HLIJPGBPOLB HLEALEHHCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x74BCA40", Offset = "0x74BBE40", VA = "0x1874BCA40", Slot = "16")]
	public void BEJODACJBMC(HLIJPGBPOLB HLEALEHHCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x74BD1A0", Offset = "0x74BC5A0", VA = "0x1874BD1A0", Slot = "17")]
	public void LKONCEOJKOE(HLIJPGBPOLB HLEALEHHCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x74BCA70", Offset = "0x74BBE70", VA = "0x1874BCA70", Slot = "18")]
	public void CLPKMKCNBAA(PHKHCKBHGEB KCOEJFJMFIK, bool HOLPGNIFENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x74BCC00", Offset = "0x74BC000", VA = "0x1874BCC00")]
	private void JNFLGGLMFJH(HPEIEJMFLLC CNAPGMPCKKJ, HLIJPGBPOLB HLEALEHHCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public LOLKBGGGEBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal class HELJHBGKAMF : KHNGFKKFBPM, FMCNBGHPHLG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct NLCLIFLCHCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public HELJHBGKAMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x74BEF70", Offset = "0x74BE370", VA = "0x1874BEF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x74BF460", Offset = "0x74BE860", VA = "0x1874BF460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct FNPJMAAFAPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public HELJHBGKAMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x74B5510", Offset = "0x74B4910", VA = "0x1874B5510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x74B5BB0", Offset = "0x74B4FB0", VA = "0x1874B5BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class IDLDGJOPPJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public IDLDGJOPPJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x74BA860", Offset = "0x74B9C60", VA = "0x1874BA860")]
		internal object HEDJIGHEBBJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct BBIFFJCLGLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public HELJHBGKAMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private IDLDGJOPPJP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x74A8D70", Offset = "0x74A8170", VA = "0x1874A8D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x74A94C0", Offset = "0x74A88C0", VA = "0x1874A94C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class ENLOEDAFDHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public ENLOEDAFDHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x74AD820", Offset = "0x74ACC20", VA = "0x1874AD820")]
		internal object JAFBMBHFCAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private EHLDCOMLOKA AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NFOECPNMOBG[] CNCMILBBIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private CancellationTokenSource INFCCFLIMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private int OGFFHNJPJLG;

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x74BA4A0", Offset = "0x74B98A0", VA = "0x1874BA4A0", Slot = "6")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x74BA2E0", Offset = "0x74B96E0", VA = "0x1874BA2E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x74BA600", Offset = "0x74B9A00", VA = "0x1874BA600", Slot = "8")]
	public void KCKAFHOGONG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x74B9A50", Offset = "0x74B8E50", VA = "0x1874B9A50", Slot = "5")]
	public void BBKAPAHEMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x74BA3D0", Offset = "0x74B97D0", VA = "0x1874BA3D0", Slot = "4")]
	[AsyncStateMachine(typeof(NLCLIFLCHCD))]
	public Task GNGNIMGNBNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x74B9D50", Offset = "0x74B9150", VA = "0x1874B9D50")]
	private void CIEEJALCLNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x74B9B20", Offset = "0x74B8F20", VA = "0x1874B9B20")]
	[AsyncStateMachine(typeof(FNPJMAAFAPN))]
	private Task BPAJIKGMCJA(CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x74BA1A0", Offset = "0x74B95A0", VA = "0x1874BA1A0")]
	[AsyncStateMachine(typeof(BBIFFJCLGLL))]
	private Task<bool> DIPHOMPAGPN(int AEAHMAMPNLO, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x74BA2F0", Offset = "0x74B96F0", VA = "0x1874BA2F0")]
	private void EKLHCDBBMLH(int AEAHMAMPNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x74BA520", Offset = "0x74B9920", VA = "0x1874BA520")]
	private void JLNHIHKCHEC(int AEAHMAMPNLO, bool HOLPGNIFENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x74BA070", Offset = "0x74B9470", VA = "0x1874BA070")]
	private void CIFHENIKNPN(int AEAHMAMPNLO, Exception JFJOELAOBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x74B9C20", Offset = "0x74B9020", VA = "0x1874B9C20")]
	private void BPFPKHKODLN(CancellationToken EEHACKMODLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public HELJHBGKAMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.NoEngine.Common.Preserve]
internal class GADCEGAPPMC : ADIDNHCGFEO, FMCNBGHPHLG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct NNEMKHGABPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public GAGHJCEIHCL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public GADCEGAPPMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public MCAMNJOCGLN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x74BF780", Offset = "0x74BEB80", VA = "0x1874BF780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x74C00E0", Offset = "0x74BF4E0", VA = "0x1874C00E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct OCIEDDOOGFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public GADCEGAPPMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public GAGHJCEIHCL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public MCAMNJOCGLN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private PMKGFNIFFEC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private DMBBNIDMCGE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private MNNJFPGNFEF <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private BHEIILEEBNE <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x74C01C0", Offset = "0x74BF5C0", VA = "0x1874C01C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x74C0E60", Offset = "0x74C0260", VA = "0x1874C0E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class APJDJMFEFIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Matchmaking.GGLBOMAGOCE result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public CBIMPNHICDA errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public APJDJMFEFIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x74A85D0", Offset = "0x74A79D0", VA = "0x1874A85D0")]
		internal object HIOAHLGCGOF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class BICCADKJKDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Task<DKKGGCCNPKP> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public BICCADKJKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		internal Task<DKKGGCCNPKP> PCBPMIJCAPJ(PMKGFNIFFEC<string>.INNANANOCLO _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct FGPHPDDGLOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public GADCEGAPPMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public GAGHJCEIHCL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public MCAMNJOCGLN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public MNNJFPGNFEF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private BICCADKJKDA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private DCJBJJMPFFF <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private DMBBNIDMCGE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private PMKGFNIFFEC<string>.INNANANOCLO <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CNFGJKAIGBN <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Task<Matchmaking.JCEAEFJKGJA> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private EEMNGFHDJJG <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private TaskAwaiter<Matchmaking.JCEAEFJKGJA> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter<DKKGGCCNPKP> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x74AFAD0", Offset = "0x74AEED0", VA = "0x1874AFAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x74B5480", Offset = "0x74B4880", VA = "0x1874B5480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct MBFCFANELCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public GADCEGAPPMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private PMKGFNIFFEC<string>.INNANANOCLO <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x74BD510", Offset = "0x74BC910", VA = "0x1874BD510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x74BDF80", Offset = "0x74BD380", VA = "0x1874BDF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct NCOCDPMFHMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public GADCEGAPPMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private ACFNHMKNHLL <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x74BE6C0", Offset = "0x74BDAC0", VA = "0x1874BE6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x74BEB40", Offset = "0x74BDF40", VA = "0x1874BEB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct DMLCBHDDBOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<Matchmaking.JCEAEFJKGJA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public GAGHJCEIHCL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public GADCEGAPPMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter<Matchmaking.JCEAEFJKGJA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x74AC8D0", Offset = "0x74ABCD0", VA = "0x1874AC8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x74ACDE0", Offset = "0x74AC1E0", VA = "0x1874ACDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct OGFICJCFJJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Matchmaking.JCEAEFJKGJA serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public GADCEGAPPMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public MNNJFPGNFEF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter<LHGBIHLHPAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x74C1290", Offset = "0x74C0690", VA = "0x1874C1290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x74C1990", Offset = "0x74C0D90", VA = "0x1874C1990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class GCDONFEAHJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public GAGHJCEIHCL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GCDONFEAHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x74B9850", Offset = "0x74B8C50", VA = "0x1874B9850")]
		internal object EAIMGACDKOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x74B9950", Offset = "0x74B8D50", VA = "0x1874B9950")]
		internal string PEKBLCALDNJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct PKNDDGHHIPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public GAGHJCEIHCL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public GADCEGAPPMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private GCDONFEAHJJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x74C2FE0", Offset = "0x74C23E0", VA = "0x1874C2FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x74C3BC0", Offset = "0x74C2FC0", VA = "0x1874C3BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct FGIOABDFBNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public GADCEGAPPMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public MNNJFPGNFEF joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public DKKGGCCNPKP initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public GAGHJCEIHCL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public DCJBJJMPFFF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private PMKGFNIFFEC<string>.INNANANOCLO <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x74ADA60", Offset = "0x74ACE60", VA = "0x1874ADA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x74AE370", Offset = "0x74AD770", VA = "0x1874AE370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct FGODJNOFHMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public GADCEGAPPMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private PMKGFNIFFEC<string>.INNANANOCLO <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private DMBBNIDMCGE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x74AE3D0", Offset = "0x74AD7D0", VA = "0x1874AE3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x74AFA70", Offset = "0x74AEE70", VA = "0x1874AFA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct OKHFFGODAIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public MJIHINAKBBL localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public GADCEGAPPMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<CEFINKDJEPJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x74C20D0", Offset = "0x74C14D0", VA = "0x1874C20D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x74C2840", Offset = "0x74C1C40", VA = "0x1874C2840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class FEIDKPHODBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public GAGHJCEIHCL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public FEIDKPHODBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x74AD890", Offset = "0x74ACC90", VA = "0x1874AD890")]
		internal object IEMCONMJMIJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class FPPBLMHDMOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public FPPBLMHDMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x74D1D00", Offset = "0x74D1100", VA = "0x1874D1D00")]
		internal void BKCOMLHAEJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class ELPNONJEEPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public GAGHJCEIHCL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public ELPNONJEEPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x74CE280", Offset = "0x74CD680", VA = "0x1874CE280")]
		internal object GAAPPACDNKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class PMGIIOHKMEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public GAGHJCEIHCL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PMGIIOHKMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x74E3D50", Offset = "0x74E3150", VA = "0x1874E3D50")]
		internal string MKJEJPDDBAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly EGGMDNJPOBA JFIBMKBKHCO;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly EGGMDNJPOBA JIAOGJBIHPO;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly EGGMDNJPOBA FLCBMELPINF;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string CLLJDFPKFJG;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string CIGIEMDPHCH;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string OCFKMFFOEAB;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly Guid NDNALJGBMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private NFPKNMPBOLJ DGBJOLGAOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private HIHPADIBAKP LHJMAKKPBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private ECJBOAIKALM GLAAFJDOHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private EHLDCOMLOKA AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private KHNGFKKFBPM FJEJGNKAFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NNPLAABFNGE KHKAAEIAMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private KOEDPHHOMHP FHGBEFFJLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private DCBBIABKPIP COODHJNFNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private ACJAHDLOKAN GLABHDEACMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private IDisposable PPFHKIOMBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private GBMONCCFIHJ LGHIJIABLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly JEGFLDIDKCF HDFFHNAFPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private EEMNGFHDJJG ECDGKDJPIOJ;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public TaskStatus PDCHAJNJJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8D21D0", Offset = "0x8D15D0", VA = "0x1808D21D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xDE2DC0", Offset = "0xDE21C0", VA = "0x180DE2DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private KLDHFEKEHPL AELNFGOMKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x74B8170", Offset = "0x74B7570", VA = "0x1874B8170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x74B7310", Offset = "0x74B6710", VA = "0x1874B7310", Slot = "6")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x74B6620", Offset = "0x74B5A20", VA = "0x1874B6620", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x74B6800", Offset = "0x74B5C00", VA = "0x1874B6800", Slot = "5")]
	[AsyncStateMachine(typeof(NNEMKHGABPP))]
	public Task GCMFLENJJIB(GAGHJCEIHCL IONGDFDGKBP, MCAMNJOCGLN DOADKJDGJIE, CancellationToken COHGPHPHNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x74B6D50", Offset = "0x74B6150", VA = "0x1874B6D50")]
	[AsyncStateMachine(typeof(OCIEDDOOGFI))]
	private Task IGHOEHNDMJB(GAGHJCEIHCL IONGDFDGKBP, MCAMNJOCGLN DOADKJDGJIE, CancellationToken COHGPHPHNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x74B76A0", Offset = "0x74B6AA0", VA = "0x1874B76A0")]
	private void LCPIDKHLHLE(DCBBIABKPIP COODHJNFNHN, GAGHJCEIHCL IONGDFDGKBP, Exception JFJOELAOBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x74B84F0", Offset = "0x74B78F0", VA = "0x1874B84F0")]
	private static void OJIIPNBANJL(BHEIILEEBNE OLLGIHBDJPD, Exception JFJOELAOBOE, [Optional] List<int> HPIBKLMCBOI, int OGFFHNJPJLG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x74B5CE0", Offset = "0x74B50E0", VA = "0x1874B5CE0")]
	[AsyncStateMachine(typeof(FGPHPDDGLOA))]
	private Task ANNOHOCDIAD(PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, GAGHJCEIHCL IONGDFDGKBP, MCAMNJOCGLN DOADKJDGJIE, MNNJFPGNFEF KAFHJEMKCME, CancellationToken COHGPHPHNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x74B7B10", Offset = "0x74B6F10", VA = "0x1874B7B10")]
	private void LOEGPDNIJEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x74B6C20", Offset = "0x74B6020", VA = "0x1874B6C20")]
	[AsyncStateMachine(typeof(MBFCFANELCM))]
	private Task IBDDOGMLJPP(PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x74B81C0", Offset = "0x74B75C0", VA = "0x1874B81C0")]
	private void NKHKNCNKCIJ(GAGHJCEIHCL IONGDFDGKBP, CancellationToken COHGPHPHNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x74B8F30", Offset = "0x74B8330", VA = "0x1874B8F30")]
	private void PLLCBAFHAII(GAGHJCEIHCL IONGDFDGKBP, MNNJFPGNFEF KAFHJEMKCME, OperationCanceledException LHMHIDBDCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x74B9180", Offset = "0x74B8580", VA = "0x1874B9180")]
	private void PMKIGNEGBNB(GAGHJCEIHCL IONGDFDGKBP, MNNJFPGNFEF KAFHJEMKCME, Exception JFJOELAOBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x74B7100", Offset = "0x74B6500", VA = "0x1874B7100")]
	private void JKIMOJLDAEH(GAGHJCEIHCL IONGDFDGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x74B65C0", Offset = "0x74B59C0", VA = "0x1874B65C0")]
	private static HLIJPGBPOLB DPNFNGLPBEA(GAGHJCEIHCL IONGDFDGKBP)
	{
		return default(HLIJPGBPOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x74B5C10", Offset = "0x74B5010", VA = "0x1874B5C10")]
	[AsyncStateMachine(typeof(NCOCDPMFHMJ))]
	private Task AMCJGMIONNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x74B7C60", Offset = "0x74B7060", VA = "0x1874B7C60")]
	[AsyncStateMachine(typeof(DMLCBHDDBOG))]
	private Task<Matchmaking.JCEAEFJKGJA> MBKNKALJPFC(GAGHJCEIHCL IONGDFDGKBP, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x74B64B0", Offset = "0x74B58B0", VA = "0x1874B64B0")]
	private static LHGBIHLHPAG DOKMBBAACNO(Matchmaking.JCEAEFJKGJA OPFFNDLHNIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x74B6FB0", Offset = "0x74B63B0", VA = "0x1874B6FB0")]
	[AsyncStateMachine(typeof(OGFICJCFJJD))]
	private Task JGOOABDBEFN(Matchmaking.JCEAEFJKGJA OPFFNDLHNIH, MNNJFPGNFEF KAFHJEMKCME, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken CGLIMBHHCON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x74B7F30", Offset = "0x74B7330", VA = "0x1874B7F30")]
	[AsyncStateMachine(typeof(PKNDDGHHIPI))]
	private Task MGIALDMDDMG(GAGHJCEIHCL IONGDFDGKBP, CancellationTokenSource HIGIDAGPAFE, Task HNEKFMIOIEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x74B7DC0", Offset = "0x74B71C0", VA = "0x1874B7DC0")]
	[AsyncStateMachine(typeof(FGIOABDFBNJ))]
	private Task MEMOPANBCBN(DKKGGCCNPKP LLEKDEGDKHC, DCJBJJMPFFF AAANMNHHFCK, GAGHJCEIHCL JNLBDDMHLJK, MNNJFPGNFEF NBPJPNCKPME, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken OFMHIKKMLNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x74B8D40", Offset = "0x74B8140", VA = "0x1874B8D40")]
	private MNNJFPGNFEF PBMJJHLKHMJ(MNNJFPGNFEF NBPJPNCKPME, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x74B6670", Offset = "0x74B5A70", VA = "0x1874B6670")]
	[AsyncStateMachine(typeof(FGODJNOFHMI))]
	private Task FPPHAIECGMM(PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x74B6AF0", Offset = "0x74B5EF0", VA = "0x1874B6AF0")]
	[AsyncStateMachine(typeof(OKHFFGODAIO))]
	private Task IAPJIKFPLBF(CancellationToken EEHACKMODLA, int OIDNDODDMLL, MJIHINAKBBL FCOADIHHMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x74B6050", Offset = "0x74B5450", VA = "0x1874B6050")]
	private static void DGHKMCOKLHH(GAGHJCEIHCL IONGDFDGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x74B61D0", Offset = "0x74B55D0", VA = "0x1874B61D0")]
	private void DKBJIBAPAMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x74B6420", Offset = "0x74B5820", VA = "0x1874B6420")]
	private void DODBLCLFCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x74B5F30", Offset = "0x74B5330", VA = "0x1874B5F30")]
	private void CGBBECFEDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x74B5FC0", Offset = "0x74B53C0", VA = "0x1874B5FC0")]
	private void DFHBDJICEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x74B5E40", Offset = "0x74B5240", VA = "0x1874B5E40")]
	private static void BCDKOBHOIKC(GAGHJCEIHCL IONGDFDGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x74B6EA0", Offset = "0x74B62A0", VA = "0x1874B6EA0")]
	private static CancellationTokenRegistration JEINKBJBOCD(GAGHJCEIHCL IONGDFDGKBP, CancellationToken CGLIMBHHCON)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x74B8070", Offset = "0x74B7470", VA = "0x1874B8070")]
	private static void MKEOMNKMLNJ(GAGHJCEIHCL IONGDFDGKBP, Exception JFJOELAOBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x74B6940", Offset = "0x74B5D40", VA = "0x1874B6940")]
	private void HOIIFJPAJOL(GAGHJCEIHCL IONGDFDGKBP, Task HNEKFMIOIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x74B7640", Offset = "0x74B6A40", VA = "0x1874B7640")]
	private static void KGPNCCLAFMC(Func<string> KHAFJMFBNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x74B95D0", Offset = "0x74B89D0", VA = "0x1874B95D0")]
	public GADCEGAPPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x74B67A0", Offset = "0x74B5BA0", VA = "0x1874B67A0")]
	[CompilerGenerated]
	internal static (int, int?) GBNDHANJBBE(CBIMPNHICDA CCPMBLJCLDM)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class HBGFELPMBNL : OFDIHMKLHIB, FMCNBGHPHLG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct KAGHICLFINA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public HBGFELPMBNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public MJIHINAKBBL localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x74D93E0", Offset = "0x74D87E0", VA = "0x1874D93E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x74D9840", Offset = "0x74D8C40", VA = "0x1874D9840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class POLEBKKIDPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public HBGFELPMBNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public MJIHINAKBBL localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public POLEBKKIDPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x74E43D0", Offset = "0x74E37D0", VA = "0x1874E43D0")]
		internal List<Task> BMLPOINJPCL(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct LKGAFCOLNIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public JLOKIJKJCMM taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public MJIHINAKBBL localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x74DCB60", Offset = "0x74DBF60", VA = "0x1874DCB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x74DCF00", Offset = "0x74DC300", VA = "0x1874DCF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct NKCKKDIHJMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public HBGFELPMBNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x74E0400", Offset = "0x74DF800", VA = "0x1874E0400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x74E06E0", Offset = "0x74DFAE0", VA = "0x1874E06E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly HashSet<JLOKIJKJCMM> MENOFMLGPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private HIHPADIBAKP LHJMAKKPBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private OIIJPEDCKAB POIGJHGPHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private EGPAAOAOMHG FEHALANDBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private IDisposable PPFHKIOMBDN;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x74D4A40", Offset = "0x74D3E40", VA = "0x1874D4A40", Slot = "5")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x74D45B0", Offset = "0x74D39B0", VA = "0x1874D45B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x74D52D0", Offset = "0x74D46D0", VA = "0x1874D52D0", Slot = "4")]
	public bool LIOFIAEOFCL(JLOKIJKJCMM JLEJHKDDHFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x74D4970", Offset = "0x74D3D70", VA = "0x1874D4970")]
	private void IPHHPEMKMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x74D4750", Offset = "0x74D3B50", VA = "0x1874D4750")]
	private void HIMMNLGGOLG(PHNAGDHGBII CAAMOPOAIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x74D43F0", Offset = "0x74D37F0", VA = "0x1874D43F0")]
	[AsyncStateMachine(typeof(KAGHICLFINA))]
	private Task BGFPGIIPFOA(int OIDNDODDMLL, MJIHINAKBBL FCOADIHHMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x74D44E0", Offset = "0x74D38E0", VA = "0x1874D44E0")]
	private Func<CancellationToken, List<Task>> BINPBPCCEFE(int OIDNDODDMLL, MJIHINAKBBL FCOADIHHMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x74D4DF0", Offset = "0x74D41F0", VA = "0x1874D4DF0")]
	private List<Task> LFNPLKNCMLC(int OIDNDODDMLL, MJIHINAKBBL FCOADIHHMMH, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x74D4630", Offset = "0x74D3A30", VA = "0x1874D4630")]
	[AsyncStateMachine(typeof(LKGAFCOLNIO))]
	private Task GNLLNOHAIOP(JLOKIJKJCMM AMDBOGBIGIM, CancellationToken FDAIGOGAKMH, int OIDNDODDMLL, MJIHINAKBBL FCOADIHHMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x74D5330", Offset = "0x74D4730", VA = "0x1874D5330")]
	[AsyncStateMachine(typeof(NKCKKDIHJMA))]
	private Task PDKAKGHLHHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x74D4D40", Offset = "0x74D4140", VA = "0x1874D4D40")]
	private void KCKAFHOGONG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x74D5400", Offset = "0x74D4800", VA = "0x1874D5400")]
	public HBGFELPMBNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[UnityEngine.Scripting.Preserve]
internal sealed class FECILLOBKME : GEGKDJHNBPC, FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class GFLGHCNOBIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GFLGHCNOBIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x74D2340", Offset = "0x74D1740", VA = "0x1874D2340")]
		internal object NNALMEAAAEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class EJDLDOMOOFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public EJDLDOMOOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x74CE220", Offset = "0x74CD620", VA = "0x1874CE220")]
		internal object DBCMFHHBOPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class BOJJGLHKIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public BOJJGLHKIBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class LBBHBCEOLIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public LBBHBCEOLIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x74DC9C0", Offset = "0x74DBDC0", VA = "0x1874DC9C0")]
		internal object HEDNMHKJAMK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class OLFBKBIOEOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public OLFBKBIOEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x74E1D00", Offset = "0x74E1100", VA = "0x1874E1D00")]
		internal object BFIKKEHFDKI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly Dictionary<Guid, OEBIJNLDCCP> NCMDHCKDKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly TimeSpan JNICHEHBEGK;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "9")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x74D0090", Offset = "0x74CF490", VA = "0x1874D0090", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x74D0650", Offset = "0x74CFA50", VA = "0x1874D0650", Slot = "4")]
	public GCBBBMGKMGD PJLPMKJIOFF(Guid NJALKLIOMDE)
	{
		return default(GCBBBMGKMGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x74D0110", Offset = "0x74CF510", VA = "0x1874D0110", Slot = "5")]
	public bool MAHJHHAHNPL(Guid NJALKLIOMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x74D0320", Offset = "0x74CF720", VA = "0x1874D0320", Slot = "6")]
	public bool PGDDMPIJFOA(Guid NJALKLIOMDE, Task CENFKNMGKJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x74CFC80", Offset = "0x74CF080", VA = "0x1874CFC80", Slot = "7")]
	public bool AAOAGPBAENJ(Guid NJALKLIOMDE, CEFINKDJEPJ IGHKPAMMJCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x74D00A0", Offset = "0x74CF4A0", VA = "0x1874D00A0", Slot = "8")]
	public Task<(CEFINKDJEPJ, Task)> HKJNIBFFPMC(Guid NJALKLIOMDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x74CFE60", Offset = "0x74CF260", VA = "0x1874CFE60")]
	private void BDEMAGIKFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x74D0870", Offset = "0x74CFC70", VA = "0x1874D0870")]
	public FECILLOBKME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.NoEngine.Common.Preserve]
internal class APAHIHHJJJL : GAOEJCBIEOJ, FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private class MOPPHENKKIL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private readonly GAGHJCEIHCL BFAOCBCJEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private readonly CancellationTokenSource INFCCFLIMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public readonly CancellationToken PLCFFPJIEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool GBKCIJPACEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private bool LNIMNIKGCDA;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x74DE2C0", Offset = "0x74DD6C0", VA = "0x1874DE2C0")]
		public MOPPHENKKIL(GAGHJCEIHCL BFAOCBCJEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x74DE170", Offset = "0x74DD570", VA = "0x1874DE170")]
		public void KCKAFHOGONG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x74DE140", Offset = "0x74DD540", VA = "0x1874DE140", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class HAGMMMOMOFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public PGFODMOFFAA disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HAGMMMOMOFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x74D3110", Offset = "0x74D2510", VA = "0x1874D3110")]
		internal object ACBKHFHKFLB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct NKHFDIHJHPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public PGFODMOFFAA disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public APAHIHHJJJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x74E0740", Offset = "0x74DFB40", VA = "0x1874E0740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x74E0B40", Offset = "0x74DFF40", VA = "0x1874E0B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class JGPGPFMKFOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public JGPGPFMKFOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x74D9250", Offset = "0x74D8650", VA = "0x1874D9250")]
		internal object KAKLFPGKEJK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct HBEGFLPNFFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public APAHIHHJJJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private DMBBNIDMCGE <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x74D3210", Offset = "0x74D2610", VA = "0x1874D3210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class JKAJBLGCKDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public GAGHJCEIHCL newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public JKAJBLGCKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x74D9300", Offset = "0x74D8700", VA = "0x1874D9300")]
		internal object ENEDIPELLOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x74D92C0", Offset = "0x74D86C0", VA = "0x1874D92C0")]
		internal object DFIJMFJMEFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x74D93A0", Offset = "0x74D87A0", VA = "0x1874D93A0")]
		internal object LGHGAPBGPJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class FOIFLJNBMEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public FOIFLJNBMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x74D1070", Offset = "0x74D0470", VA = "0x1874D1070")]
		internal void EGAEDGNONKG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct BODNGGIAJFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public GAGHJCEIHCL newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public APAHIHHJJJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public MCAMNJOCGLN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private JKAJBLGCKDA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x74C7EC0", Offset = "0x74C72C0", VA = "0x1874C7EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x74C8E50", Offset = "0x74C8250", VA = "0x1874C8E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly GKNGMAPAJGO.IDDNBHFHJAM PAOGKNJKPJN;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly OJEODDGKLBF MLFAPKKPEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private HIHPADIBAKP LHJMAKKPBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private KHNGFKKFBPM FJEJGNKAFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private EHLDCOMLOKA AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private KALCCDBBFGA IBOPOOBMBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private ADIDNHCGFEO ONBBIANMAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private GAGHJCEIHCL OHJFGAEECIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private MOPPHENKKIL HPGAMKAAEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private bool INOFLMLAIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private Task EADJMIBHEKG;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private KLDHFEKEHPL AELNFGOMKIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x74C7470", Offset = "0x74C6870", VA = "0x1874C7470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool ICIOHGMCAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA4C600", Offset = "0xA4BA00", VA = "0x180A4C600")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x74C6E80", Offset = "0x74C6280", VA = "0x1874C6E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x74C70E0", Offset = "0x74C64E0", VA = "0x1874C70E0", Slot = "4")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x74C6B80", Offset = "0x74C5F80", VA = "0x1874C6B80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x74C7380", Offset = "0x74C6780", VA = "0x1874C7380")]
	[AsyncStateMachine(typeof(NKHFDIHJHPF))]
	private Task NDAEMHMGGAN(PGFODMOFFAA OCOIHPBFFMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x74C6CF0", Offset = "0x74C60F0", VA = "0x1874C6CF0")]
	private void EPNLKMJCAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x74C74C0", Offset = "0x74C68C0", VA = "0x1874C74C0")]
	private void NILGLICBNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x74C78D0", Offset = "0x74C6CD0", VA = "0x1874C78D0")]
	private void OMDOHCDFHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x74C69F0", Offset = "0x74C5DF0", VA = "0x1874C69F0")]
	private bool BNELEHGLNHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x74C6E90", Offset = "0x74C6290", VA = "0x1874C6E90")]
	[AsyncStateMachine(typeof(HBEGFLPNFFN))]
	private void GPFDMKFOBKP(int IPFLJJEIEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x74C7650", Offset = "0x74C6A50", VA = "0x1874C7650")]
	private void OBMDALIKIPJ([Out] IDisposable HMMLEHIDPNI, [Out] IDisposable EEKPBMPMKFJ, [Out] IDisposable MEFPKNAPLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x74C6A60", Offset = "0x74C5E60", VA = "0x1874C6A60")]
	private bool DNGHHIOIEJJ(GAGHJCEIHCL BFAOCBCJEPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x74C7090", Offset = "0x74C6490", VA = "0x1874C7090")]
	private void JJECIDCIMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x74C6F60", Offset = "0x74C6360", VA = "0x1874C6F60")]
	[AsyncStateMachine(typeof(BODNGGIAJFC))]
	private Task IGHOEHNDMJB(GAGHJCEIHCL BFAOCBCJEPK, MCAMNJOCGLN DOADKJDGJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x74C7DF0", Offset = "0x74C71F0", VA = "0x1874C7DF0")]
	public APAHIHHJJJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class EABLPEJNJPD : PHBHICGLBJK, FMCNBGHPHLG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct KJAAEJPHPPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public AsyncTaskMethodBuilder<DJFIDPMCMOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public EABLPEJNJPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<DJFIDPMCMOO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x74DA040", Offset = "0x74D9440", VA = "0x1874DA040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x74DA2D0", Offset = "0x74D96D0", VA = "0x1874DA2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class PJBMALPNGPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public OGJBCMINPFI message;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PJBMALPNGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x74E3CF0", Offset = "0x74E30F0", VA = "0x1874E3CF0")]
		internal object NIMPLKNOMLK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class MFOLBKAGDMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public OGJBCMINPFI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public MFOLBKAGDMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x74DE0E0", Offset = "0x74DD4E0", VA = "0x1874DE0E0")]
		internal object GMOOCDIAPON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class DFJHKKLFMKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public OGJBCMINPFI request;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public DFJHKKLFMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x74CBD40", Offset = "0x74CB140", VA = "0x1874CBD40")]
		internal object COJLOPGFIGH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct CFDMFMCJFDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public OGJBCMINPFI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public EABLPEJNJPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<ILAHKLFLONK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x74CAE40", Offset = "0x74CA240", VA = "0x1874CAE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x74CB710", Offset = "0x74CAB10", VA = "0x1874CB710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class NMJOHINICCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public OGJBCMINPFI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public NMJOHINICCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x74E1350", Offset = "0x74E0750", VA = "0x1874E1350")]
		internal object JJEBPOPPDOK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct AEAHIHKFFNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public OGJBCMINPFI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public EABLPEJNJPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private MNNJFPGNFEF <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<OGJBCMINPFI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x74C4A60", Offset = "0x74C3E60", VA = "0x1874C4A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x74C55D0", Offset = "0x74C49D0", VA = "0x1874C55D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct GBBEFEPGNHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<ILAHKLFLONK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public EABLPEJNJPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public OGJBCMINPFI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private HAPPECADJDK.FHOBGGLKGML <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private MNNJFPGNFEF <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<OGJBCMINPFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x74D1DA0", Offset = "0x74D11A0", VA = "0x1874D1DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x74D22D0", Offset = "0x74D16D0", VA = "0x1874D22D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class DCNCGAMLLMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public ILAHKLFLONK operation;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public DCNCGAMLLMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x74CBCC0", Offset = "0x74CB0C0", VA = "0x1874CBCC0")]
		internal object EJPMMEGHNHN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct EFJALBHCKDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public ILAHKLFLONK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public EABLPEJNJPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private PMKGFNIFFEC<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x74CD8D0", Offset = "0x74CCCD0", VA = "0x1874CD8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x74CDF00", Offset = "0x74CD300", VA = "0x1874CDF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class OBLEAALLMEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public OGJBCMINPFI request;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public OBLEAALLMEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x74E1610", Offset = "0x74E0A10", VA = "0x1874E1610")]
		internal object JCAJIHMAJMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class ACDIBBGAMDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public OGJBCMINPFI request;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public ACDIBBGAMDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x74C4A00", Offset = "0x74C3E00", VA = "0x1874C4A00")]
		internal object FBPDDEDLFEI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private NNPLAABFNGE KHKAAEIAMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private KHMGHFGENFF MMEKJGGFALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private INMBLPBBGFE CNNIJNGGNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private ECJBOAIKALM GLAAFJDOHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private TaskCompletionSource<DJFIDPMCMOO> DLBJGPMEIMC;

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x74CD180", Offset = "0x74CC580", VA = "0x1874CD180", Slot = "7")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x74CD270", Offset = "0x74CC670", VA = "0x1874CD270", Slot = "6")]
	[AsyncStateMachine(typeof(KJAAEJPHPPA))]
	public Task<DJFIDPMCMOO> JNGCFBIADKD(CancellationToken DOIFONLLKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x74CD490", Offset = "0x74CC890", VA = "0x1874CD490", Slot = "4")]
	public void PJHGBOPBBMB(OGJBCMINPFI ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x74CC920", Offset = "0x74CBD20", VA = "0x1874CC920", Slot = "5")]
	public void CIFHMHPLNBL(OGJBCMINPFI MGMKHMGNLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x74CD070", Offset = "0x74CC470", VA = "0x1874CD070")]
	[AsyncStateMachine(typeof(CFDMFMCJFDH))]
	private Task IOLFMLEKAHC(OGJBCMINPFI JHKMPCADNAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x74CD380", Offset = "0x74CC780", VA = "0x1874CD380")]
	[AsyncStateMachine(typeof(AEAHIHKFFNA))]
	private Task PCEEDBMODHH(OGJBCMINPFI LHJNLBCJNDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x74CCF20", Offset = "0x74CC320", VA = "0x1874CCF20")]
	[AsyncStateMachine(typeof(GBBEFEPGNHI))]
	private Task<ILAHKLFLONK> GOKANCHIBLG(OGJBCMINPFI JHKMPCADNAF, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x74CCE90", Offset = "0x74CC290", VA = "0x1874CCE90")]
	private MNNJFPGNFEF FGENDPKFCOD(OGJBCMINPFI JFLHEILMJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x74CC470", Offset = "0x74CB870", VA = "0x1874CC470")]
	[AsyncStateMachine(typeof(EFJALBHCKDA))]
	private Task BGNEBJBNHKA(ILAHKLFLONK KFMKOKFLOBK, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x74CCC80", Offset = "0x74CC080", VA = "0x1874CCC80")]
	private ILAHKLFLONK FFJPNABPPGD(OGJBCMINPFI JHKMPCADNAF, MNNJFPGNFEF CBMNNOKPMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6E00", Offset = "0x2CA6200", VA = "0x182CA6E00")]
	private T KEBPPLHPELM<T>(T LIHHDPOHLDK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x74CC590", Offset = "0x74CB990", VA = "0x1874CC590")]
	private ILAHKLFLONK BMHLBKPNIBI(OGJBCMINPFI JHKMPCADNAF, MNNJFPGNFEF CBMNNOKPMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public EABLPEJNJPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[UnityEngine.Scripting.Preserve]
internal sealed class LAFOEODGJAF : KHMGHFGENFF, FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class HAHENJNCDOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HAHENJNCDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x74D31A0", Offset = "0x74D25A0", VA = "0x1874D31A0")]
		internal object CEIOMONMAEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class DKOCKDJLLIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public DKOCKDJLLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x74CBDA0", Offset = "0x74CB1A0", VA = "0x1874CBDA0")]
		internal object HBNNIJOGLAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private ECJBOAIKALM GLAAFJDOHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private PDMMCOOFBKL LIFKAPNFGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private PHBHICGLBJK NEHLCLPCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private GEGKDJHNBPC NCMDHCKDKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private DEKIAMBHKHB DFLOLINJEIM;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x74DC000", Offset = "0x74DB400", VA = "0x1874DC000", Slot = "6")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x74DBB40", Offset = "0x74DAF40", VA = "0x1874DBB40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x74DB2B0", Offset = "0x74DA6B0", VA = "0x1874DB2B0", Slot = "4")]
	public GCBBBMGKMGD CJGILEOJMOO(OGJBCMINPFI BCPLCGADIOL)
	{
		return default(GCBBBMGKMGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x74DBDF0", Offset = "0x74DB1F0", VA = "0x1874DBDF0", Slot = "5")]
	public void FACHLFFDGLJ(Guid NJALKLIOMDE, Task CENFKNMGKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x74DA980", Offset = "0x74D9D80", VA = "0x1874DA980")]
	private void AGAKEECIDKD(byte IMFFGFAIHGM, int MKFGJOHIBBM, object CPFJHIIALEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x74DAA50", Offset = "0x74D9E50", VA = "0x1874DAA50")]
	private void AJAAJCBFBFP(EOILANHJNDP PGKBONDNINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x74DAFC0", Offset = "0x74DA3C0", VA = "0x1874DAFC0")]
	private void BDKLCIGNJOL(EOILANHJNDP PGKBONDNINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x74DB900", Offset = "0x74DAD00", VA = "0x1874DB900")]
	private void DANMHEFFAOI(EOILANHJNDP PGKBONDNINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x74DB6D0", Offset = "0x74DAAD0", VA = "0x1874DB6D0")]
	private CEFINKDJEPJ CMBIOJMNNOA(OGJBCMINPFI JFLHEILMJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x74DBBF0", Offset = "0x74DAFF0", VA = "0x1874DBBF0")]
	private void EEPFOLPDIPD(OGJBCMINPFI LHJNLBCJNDB, CEFINKDJEPJ IGHKPAMMJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x74DC3F0", Offset = "0x74DB7F0", VA = "0x1874DC3F0")]
	private bool MICLJPJEKJO(OGJBCMINPFI LHJNLBCJNDB, CEFINKDJEPJ IGHKPAMMJCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x74DC690", Offset = "0x74DBA90", VA = "0x1874DC690")]
	private bool OMOEAFGCKFA(OGJBCMINPFI KCJPHLKBBKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x74DC170", Offset = "0x74DB570", VA = "0x1874DC170")]
	private bool LDCNPCMIEOM(byte IMFFGFAIHGM, ExitGames.Client.Photon.Hashtable PGKBONDNINN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public LAFOEODGJAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[UnityEngine.Scripting.Preserve]
internal sealed class GLCJECEGPAB : FJBHGDKNFEH, FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class AEEKCMJOPJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public DJFIDPMCMOO operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public GLCJECEGPAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public OGJBCMINPFI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public AEEKCMJOPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x74C5760", Offset = "0x74C4B60", VA = "0x1874C5760")]
		internal object PMLHJCBFBHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x74C5630", Offset = "0x74C4A30", VA = "0x1874C5630")]
		internal object OJCPEBJFLOJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct LMHLJKJDNEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AsyncTaskMethodBuilder<CEFINKDJEPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public GLCJECEGPAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public OGJBCMINPFI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private TaskAwaiter<CEFINKDJEPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x74DD2C0", Offset = "0x74DC6C0", VA = "0x1874DD2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x74DD960", Offset = "0x74DCD60", VA = "0x1874DD960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class GNIHKKHOEIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public DJFIDPMCMOO operationType;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GNIHKKHOEIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x74D30A0", Offset = "0x74D24A0", VA = "0x1874D30A0")]
		internal object IDOLCDHBJJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class NCBDPCMFCKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public OGJBCMINPFI request;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public NCBDPCMFCKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x74DE450", Offset = "0x74DD850", VA = "0x1874DE450")]
		internal object HNICGCKNJOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x74DE370", Offset = "0x74DD770", VA = "0x1874DE370")]
		internal object CJOAKCCOPKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x74DE3E0", Offset = "0x74DD7E0", VA = "0x1874DE3E0")]
		internal object DFMFCBEEALB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct CFAJJEIGBAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<CEFINKDJEPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public OGJBCMINPFI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public GLCJECEGPAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private NCBDPCMFCKL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private GCBBBMGKMGD <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private CEFINKDJEPJ <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<(CEFINKDJEPJ validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x74CA520", Offset = "0x74C9920", VA = "0x1874CA520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x74CADD0", Offset = "0x74CA1D0", VA = "0x1874CADD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private ECJBOAIKALM GLAAFJDOHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private PDMMCOOFBKL LIFKAPNFGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private KHMGHFGENFF MMEKJGGFALG;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x74D2E00", Offset = "0x74D2200", VA = "0x1874D2E00", Slot = "5")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x74D2CE0", Offset = "0x74D20E0", VA = "0x1874D2CE0", Slot = "4")]
	[AsyncStateMachine(typeof(LMHLJKJDNEJ))]
	private Task<CEFINKDJEPJ> FMFMHCJKCGN(OGJBCMINPFI JFLHEILMJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x74D2EB0", Offset = "0x74D22B0", VA = "0x1874D2EB0")]
	private bool LIANPJDNGPM(DJFIDPMCMOO KCOEJFJMFIK, [Out] CEFINKDJEPJ CIFMGKBFCHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x74D2BA0", Offset = "0x74D1FA0", VA = "0x1874D2BA0")]
	[AsyncStateMachine(typeof(CFAJJEIGBAA))]
	private Task<CEFINKDJEPJ> AHKBLNPEEBN(OGJBCMINPFI JHKMPCADNAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public GLCJECEGPAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class HGLIEIDKKJG : BNINCIEKNLD, FMCNBGHPHLG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct KJHCDMLKOIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<DKKGGCCNPKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public GAGHJCEIHCL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public HGLIEIDKKJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<JKIABJFEAHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<DKKGGCCNPKP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x74DA340", Offset = "0x74D9740", VA = "0x1874DA340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x74DA910", Offset = "0x74D9D10", VA = "0x1874DA910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class HJOMDOPBOGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HJOMDOPBOGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x74D6410", Offset = "0x74D5810", VA = "0x1874D6410")]
		internal object KEONGPCGKBC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct NCKAICNGHBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<JKIABJFEAHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public HGLIEIDKKJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public GAGHJCEIHCL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private HJOMDOPBOGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<JKIABJFEAHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x74DE4C0", Offset = "0x74DD8C0", VA = "0x1874DE4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x74DEAB0", Offset = "0x74DDEB0", VA = "0x1874DEAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct LMMAAALHBPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<DKKGGCCNPKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public HGLIEIDKKJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public GAGHJCEIHCL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public JKIABJFEAHD roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<(PNJFLFBCBJP superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x74DD9D0", Offset = "0x74DCDD0", VA = "0x1874DD9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x74DDE30", Offset = "0x74DD230", VA = "0x1874DDE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class PAMMLANOLNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PAMMLANOLNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6C0", Offset = "0x9DEAC0", VA = "0x1809DF6C0")]
		internal bool DBPGNLCGOLP(OCIJPHOBBHK sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct HJLBLFNONBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<(PNJFLFBCBJP superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public JKIABJFEAHD roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public HGLIEIDKKJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public GAGHJCEIHCL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter<(PNJFLFBCBJP superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x74D5D00", Offset = "0x74D5100", VA = "0x1874D5D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x74D63A0", Offset = "0x74D57A0", VA = "0x1874D63A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class EDGLACFPNPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public EDGLACFPNPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x74CD820", Offset = "0x74CCC20", VA = "0x1874CD820")]
		internal object HDGOJFCJMCF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct ILDJKGAOLNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<(PNJFLFBCBJP superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public OCIJPHOBBHK subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public HGLIEIDKKJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public GAGHJCEIHCL dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private EDGLACFPNPA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<GAFBGJLGAKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x74D8180", Offset = "0x74D7580", VA = "0x1874D8180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x74D88B0", Offset = "0x74D7CB0", VA = "0x1874D88B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly (PNJFLFBCBJP superRoomData, long subRoomDataSaveId) COHHHOIBFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private EHLDCOMLOKA AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private KKELKFJEAOL KHMAICDCBBO;

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x74D5760", Offset = "0x74D4B60", VA = "0x1874D5760", Slot = "5")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x74D5600", Offset = "0x74D4A00", VA = "0x1874D5600", Slot = "4")]
	[AsyncStateMachine(typeof(KJHCDMLKOIE))]
	public Task<DKKGGCCNPKP> DNNEBLIMIJH(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, GAGHJCEIHCL IONGDFDGKBP, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x74D57F0", Offset = "0x74D4BF0", VA = "0x1874D57F0")]
	[AsyncStateMachine(typeof(NCKAICNGHBD))]
	private Task<JKIABJFEAHD> LNGAHJEEGLF(GAGHJCEIHCL IONGDFDGKBP, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x74D5950", Offset = "0x74D4D50", VA = "0x1874D5950")]
	[AsyncStateMachine(typeof(LMMAAALHBPC))]
	private Task<DKKGGCCNPKP> PCDNJOFPIAN(GAGHJCEIHCL IONGDFDGKBP, JKIABJFEAHD KKKJMHEOKEA, long DPDHHEKEIEF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x74D5AC0", Offset = "0x74D4EC0", VA = "0x1874D5AC0")]
	[AsyncStateMachine(typeof(HJLBLFNONBA))]
	private Task<(PNJFLFBCBJP, long)> PICFLGMNOMB(GAGHJCEIHCL IONGDFDGKBP, JKIABJFEAHD KKKJMHEOKEA, long DPDHHEKEIEF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x74D5490", Offset = "0x74D4890", VA = "0x1874D5490")]
	[AsyncStateMachine(typeof(ILDJKGAOLNJ))]
	private Task<(PNJFLFBCBJP, long)> ALHFIOPOGCO(GAGHJCEIHCL LNILCBHFNCA, OCIJPHOBBHK PICDKEPDOKL, long DPDHHEKEIEF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public HGLIEIDKKJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[UnityEngine.Scripting.Preserve]
internal sealed class ANLIBCPKPEE : INMBLPBBGFE, FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class OGAOCAOHLJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public OGJBCMINPFI request;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public OGAOCAOHLJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x74E1C40", Offset = "0x74E1040", VA = "0x1874E1C40")]
		internal object OCCCPEAFEEH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct FIGNJFDFPJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public AsyncTaskMethodBuilder<OGJBCMINPFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public OGJBCMINPFI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public ANLIBCPKPEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public MNNJFPGNFEF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<OGJBCMINPFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x74D0930", Offset = "0x74CFD30", VA = "0x1874D0930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x74D0F40", Offset = "0x74D0340", VA = "0x1874D0F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct DLMMAEHJILD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public AsyncTaskMethodBuilder<OGJBCMINPFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public ANLIBCPKPEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public MNNJFPGNFEF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter<KOGLPOKLAAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x74CBE10", Offset = "0x74CB210", VA = "0x1874CBE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x74CC400", Offset = "0x74CB800", VA = "0x1874CC400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class IOBPFMLMOEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public OGJBCMINPFI request;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public IOBPFMLMOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x74D8920", Offset = "0x74D7D20", VA = "0x1874D8920")]
		internal object AMDLHAMCBCG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct IEHGIMMHJDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<OGJBCMINPFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public OGJBCMINPFI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public ANLIBCPKPEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public MNNJFPGNFEF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private DFOANCPGDGA <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private AGLNEHMLPKM <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter<KOGLPOKLAAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x74D7000", Offset = "0x74D6400", VA = "0x1874D7000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x74D7BF0", Offset = "0x74D6FF0", VA = "0x1874D7BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private ECJBOAIKALM GLAAFJDOHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private KNABIBLMPBC DIGNDIGEHEC;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private GGGLGKDJBLD CEKIHPLHINM
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x74C6930", Offset = "0x74C5D30", VA = "0x1874C6930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x74C6690", Offset = "0x74C5A90", VA = "0x1874C6690", Slot = "8")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x74C6300", Offset = "0x74C5700", VA = "0x1874C6300", Slot = "4")]
	[AsyncStateMachine(typeof(FIGNJFDFPJL))]
	public Task<OGJBCMINPFI> IMLDFGNEAJF(OGJBCMINPFI JHKMPCADNAF, MNNJFPGNFEF CBMNNOKPMCB, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x74C61B0", Offset = "0x74C55B0", VA = "0x1874C61B0", Slot = "5")]
	[AsyncStateMachine(typeof(DLMMAEHJILD))]
	public Task<OGJBCMINPFI> GFIPGPGBGHK(CancellationToken EEHACKMODLA, MNNJFPGNFEF CBMNNOKPMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x74C6720", Offset = "0x74C5B20", VA = "0x1874C6720", Slot = "6")]
	public CEBLHCJACGB OHPGFFDBPGH(ILAHKLFLONK FFEBALGIJGF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x74C6460", Offset = "0x74C5860", VA = "0x1874C6460", Slot = "7")]
	public CEBLHCJACGB JBOCAJGAEPO(ILAHKLFLONK FFEBALGIJGF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x74C6050", Offset = "0x74C5450", VA = "0x1874C6050")]
	[AsyncStateMachine(typeof(IEHGIMMHJDF))]
	private Task<OGJBCMINPFI> FPCLNPIIGIL(OGJBCMINPFI JHKMPCADNAF, MNNJFPGNFEF CBMNNOKPMCB, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A5D0", Offset = "0x2C499D0", VA = "0x182C4A5D0")]
	private static byte[] DNABMIICEFN(OGJBCMINPFI ADPAIBGIHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public ANLIBCPKPEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class NJJHFAIHCBE : PDMMCOOFBKL, FMCNBGHPHLG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private GMMBDIEALIP DNGPIIOIJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private ECJBOAIKALM GLAAFJDOHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private NNPLAABFNGE KHKAAEIAMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private FEKDDEEOGIE HFAAECNOPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private EHLDCOMLOKA AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private ADIDNHCGFEO ONBBIANMAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private OFDIHMKLHIB GONELHEMLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private KALCCDBBFGA IBOPOOBMBOE;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private KLDHFEKEHPL AELNFGOMKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x74E03B0", Offset = "0x74DF7B0", VA = "0x1874E03B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private static CEFINKDJEPJ LBILIHHBDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x74D8120", Offset = "0x74D7520", VA = "0x1874D8120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x74E0240", Offset = "0x74DF640", VA = "0x1874E0240", Slot = "6")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x74E00D0", Offset = "0x74DF4D0", VA = "0x1874E00D0", Slot = "4")]
	public CEFINKDJEPJ IFFNDNHCHHA(NGDBFKPHNOF HDCCMLJIDBG, DJFIDPMCMOO FCAFNCBGOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x74DFDC0", Offset = "0x74DF1C0", VA = "0x1874DFDC0", Slot = "5")]
	public CEFINKDJEPJ HJHMFIAHEIF(NGDBFKPHNOF OJJIKOKMIHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x74D7EB0", Offset = "0x74D72B0", VA = "0x1874D7EB0")]
	private static CEFINKDJEPJ DJIMKKIDCHK(DGPFKMCAMJI POKPBEJPBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public NJJHFAIHCBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class FIJFEMILJMB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x74D0FB0", Offset = "0x74D03B0", VA = "0x1874D0FB0")]
	public FIJFEMILJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x690FB10", Offset = "0x690EF10", VA = "0x18690FB10")]
	public FIJFEMILJMB(string ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[UnityEngine.Scripting.Preserve]
internal sealed class FAECPJGCPEO : JLEHKIMOEJC, FMCNBGHPHLG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct FOOHLKALNDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder<CEFINKDJEPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public FAECPJGCPEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public GDMCCAIBAAO autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private PMKGFNIFFEC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private PMKGFNIFFEC<string>.INNANANOCLO <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private OMBFDOGCILN <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<CEFINKDJEPJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x74D1110", Offset = "0x74D0510", VA = "0x1874D1110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x74D1C90", Offset = "0x74D1090", VA = "0x1874D1C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct KCGKAHCLDKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public FAECPJGCPEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x74D98A0", Offset = "0x74D8CA0", VA = "0x1874D98A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x74D9FE0", Offset = "0x74D93E0", VA = "0x1874D9FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct HLACHCGOMJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public FAECPJGCPEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x74D64C0", Offset = "0x74D58C0", VA = "0x1874D64C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x74D69D0", Offset = "0x74D5DD0", VA = "0x1874D69D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct NKIBIJHFDHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public FAECPJGCPEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x74E0BA0", Offset = "0x74DFFA0", VA = "0x1874E0BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x74E12F0", Offset = "0x74E06F0", VA = "0x1874E12F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct CEOADKFHHKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public FAECPJGCPEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x74CA320", Offset = "0x74C9720", VA = "0x1874CA320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x74CA4C0", Offset = "0x74C98C0", VA = "0x1874CA4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct OOPKEPHPKBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public FAECPJGCPEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x74E1D60", Offset = "0x74E1160", VA = "0x1874E1D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x74E2470", Offset = "0x74E1870", VA = "0x1874E2470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct FAHGKDKMPEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public FAECPJGCPEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x74CF690", Offset = "0x74CEA90", VA = "0x1874CF690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x74CFB00", Offset = "0x74CEF00", VA = "0x1874CFB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct OEPOOEHLLEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public FAECPJGCPEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public HFDEDFLKCBL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private PMKGFNIFFEC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x74E1670", Offset = "0x74E0A70", VA = "0x1874E1670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x74E1BE0", Offset = "0x74E0FE0", VA = "0x1874E1BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private ECJBOAIKALM GLAAFJDOHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private EHLDCOMLOKA AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private INMBLPBBGFE CNNIJNGGNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private NNPLAABFNGE KHKAAEIAMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private OFDIHMKLHIB GONELHEMLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private CancellationTokenSource CELMFJIONDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private Task OICAAEPFKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private TaskCompletionSource<int> ECBDMIFDELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private int HPCHGCDLIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private int PAIDCHIJHJM;

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x74CEFE0", Offset = "0x74CE3E0", VA = "0x1874CEFE0", Slot = "6")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0xD7AF10", Offset = "0xD7A310", VA = "0x180D7AF10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x74CF4A0", Offset = "0x74CE8A0", VA = "0x1874CF4A0")]
	private void LIFAEOHJBOI(float ACJMKMJAOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x74CF370", Offset = "0x74CE770", VA = "0x1874CF370", Slot = "4")]
	[AsyncStateMachine(typeof(FOOHLKALNDM))]
	public Task<CEFINKDJEPJ> LCHDKFMIIEM(GDMCCAIBAAO CMKALAGCPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x74CEEF0", Offset = "0x74CE2F0", VA = "0x1874CEEF0", Slot = "5")]
	[AsyncStateMachine(typeof(KCGKAHCLDKC))]
	public Task JCLDBHGOKOJ([Optional] CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xD7AF10", Offset = "0xD7A310", VA = "0x180D7AF10")]
	public void BMMGCBHBIAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x74CE970", Offset = "0x74CDD70", VA = "0x1874CE970")]
	private OMBFDOGCILN FPFKPDHALKM(GDMCCAIBAAO CMKALAGCPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x74CE780", Offset = "0x74CDB80", VA = "0x1874CE780")]
	[AsyncStateMachine(typeof(HLACHCGOMJK))]
	private Task ECEFLAGENCP(CancellationToken COHGPHPHNKH, int OIDNDODDMLL, MJIHINAKBBL FCOADIHHMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x74CE680", Offset = "0x74CDA80", VA = "0x1874CE680")]
	[AsyncStateMachine(typeof(NKIBIJHFDHL))]
	private Task CPBADCFJMBP(CancellationToken COHGPHPHNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x74CF190", Offset = "0x74CE590", VA = "0x1874CF190")]
	[AsyncStateMachine(typeof(CEOADKFHHKL))]
	private Task JLAFHPCNKAJ([Optional] CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x74CF280", Offset = "0x74CE680", VA = "0x1874CF280")]
	[AsyncStateMachine(typeof(OOPKEPHPKBO))]
	private Task KKDMGJHDGJJ(CancellationToken COHGPHPHNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x74CE870", Offset = "0x74CDC70", VA = "0x1874CE870")]
	[AsyncStateMachine(typeof(FAHGKDKMPEM))]
	private Task ELCHLNABFEL(CancellationToken JFMBJAGICAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x74CEAE0", Offset = "0x74CDEE0", VA = "0x1874CEAE0")]
	private Task HJGFJNNILNM(HFDEDFLKCBL DODPONFKEMI, CancellationToken COHGPHPHNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x74CF580", Offset = "0x74CE980", VA = "0x1874CF580")]
	[AsyncStateMachine(typeof(OEPOOEHLLEK))]
	private Task NHDJACFBCLK(HFDEDFLKCBL DODPONFKEMI, CancellationToken COHGPHPHNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x74CEC70", Offset = "0x74CE070", VA = "0x1874CEC70")]
	private bool HNECEBFPIJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public FAECPJGCPEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[UnityEngine.Scripting.Preserve]
internal class PNBPAJGJGLA : FEKDDEEOGIE, FMCNBGHPHLG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct HPHPDFJINLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public PNBPAJGJGLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private PMKGFNIFFEC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x74D6A30", Offset = "0x74D5E30", VA = "0x1874D6A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x74D6FA0", Offset = "0x74D63A0", VA = "0x1874D6FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private EPAOBPAKFLI MFEJFFLILMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private PDMMCOOFBKL LIFKAPNFGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private INMBLPBBGFE CNNIJNGGNOI;

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x74E3FF0", Offset = "0x74E33F0", VA = "0x1874E3FF0", Slot = "6")]
	public void JLABJFAHLGH(EKHKFFBCABL NOGMIFBJMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x74E3F40", Offset = "0x74E3340", VA = "0x1874E3F40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x74E42D0", Offset = "0x74E36D0", VA = "0x1874E42D0", Slot = "5")]
	[AsyncStateMachine(typeof(HPHPDFJINLM))]
	public Task KEPAEGBOIMC(string BLDDFJAJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x74E3F90", Offset = "0x74E3390", VA = "0x1874E3F90", Slot = "4")]
	public CEFINKDJEPJ HNECEBFPIJL(NGDBFKPHNOF HDCCMLJIDBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x74E3E50", Offset = "0x74E3250", VA = "0x1874E3E50")]
	private MJGDNICLNNA BMFMINMBNJM(string BLDDFJAJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public PNBPAJGJGLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class JDEBAJPCHOB
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x74D9010", Offset = "0x74D8410", VA = "0x1874D9010")]
	public static void MMOINBHNLOD(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x74D8DD0", Offset = "0x74D81D0", VA = "0x1874D8DD0")]
	internal static void DIDMHPLGEDK(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x74D8F30", Offset = "0x74D8330", VA = "0x1874D8F30")]
	internal static void LCPHENPBPMF(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x74D8980", Offset = "0x74D7D80", VA = "0x1874D8980")]
	internal static void AOMFGFLCONJ(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class ANLHLEPJIFO : GBMHCCPHKIC<OGJBCMINPFI>
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class LKGLIMJMFPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public OGJBCMINPFI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public LKGLIMJMFPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x74DCF60", Offset = "0x74DC360", VA = "0x1874DCF60")]
		internal object IMAHMLHPJGM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly ANLHLEPJIFO FKMJLLKHOAH;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x74C5A00", Offset = "0x74C4E00", VA = "0x1874C5A00")]
	public ExitGames.Client.Photon.Hashtable KEEAKGCJIOB(OGJBCMINPFI ADPAIBGIHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x74C5BA0", Offset = "0x74C4FA0", VA = "0x1874C5BA0", Slot = "5")]
	protected override void LLCPFNMNFLG(OGJBCMINPFI ADPAIBGIHMB, IDictionary<object, object> MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x74C57D0", Offset = "0x74C4BD0", VA = "0x1874C57D0", Slot = "6")]
	public override OGJBCMINPFI GEBAPMNFHGF(IDictionary<object, object> MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x74C5A90", Offset = "0x74C4E90", VA = "0x1874C5A90")]
	private static void KGPNCCLAFMC(string KGBHBFABAOH, OGJBCMINPFI ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x74C6010", Offset = "0x74C5410", VA = "0x1874C6010")]
	public ANLHLEPJIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x74C5CD0", Offset = "0x74C50D0", VA = "0x1874C5CD0")]
	[CompilerGenerated]
	internal static string NJMCDPOMFIA(DKKGGCCNPKP NNNHDMLPIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class IGCEAHIOEKD
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public static CEFINKDJEPJ LBILIHHBDHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x74D8120", Offset = "0x74D7520", VA = "0x1874D8120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x74D7F10", Offset = "0x74D7310", VA = "0x1874D7F10")]
	public static bool EOMKLAKEAFM(this CEFINKDJEPJ IGHKPAMMJCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x74D7EB0", Offset = "0x74D72B0", VA = "0x1874D7EB0")]
	public static CEFINKDJEPJ DJIMKKIDCHK(DGPFKMCAMJI AKMENNDFILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x74D7F30", Offset = "0x74D7330", VA = "0x1874D7F30")]
	public static CEFINKDJEPJ IEEHDONMPOK(IEnumerable<CEFINKDJEPJ> KCGALOODKMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x74D7C60", Offset = "0x74D7060", VA = "0x1874D7C60")]
	public static string BHJHEGEGOBP(this CEFINKDJEPJ CIFMGKBFCHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public abstract class NDENECHCDCF : DAELNCEPFGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public delegate CEFINKDJEPJ HMNJOFFEMCD([NotNull] NGDBFKPHNOF GCAEHKIMAHJ);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class DJIEIHABOEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public NGDBFKPHNOF photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public DJIEIHABOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x6B19CC0", Offset = "0x6B190C0", VA = "0x186B19CC0")]
		internal CEFINKDJEPJ JLCFNNFMHPK(HMNJOFFEMCD v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private bool HLAMJAHICLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	protected readonly HashSet<HMNJOFFEMCD> ODLMHKHHMOE;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x74DEB70", Offset = "0x74DDF70", VA = "0x1874DEB70", Slot = "4")]
	public void GIDCFPMBCHN(HMNJOFFEMCD JNGPOMJAACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x74DEE60", Offset = "0x74DE260", VA = "0x1874DEE60", Slot = "5")]
	public void NKHEOMFIJGC(HMNJOFFEMCD JNGPOMJAACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x74DEB20", Offset = "0x74DDF20", VA = "0x1874DEB20", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x74DEBD0", Offset = "0x74DDFD0", VA = "0x1874DEBD0")]
	protected CEFINKDJEPJ KIIHFEBOPIM(NGDBFKPHNOF OJJIKOKMIHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x74DEEC0", Offset = "0x74DE2C0", VA = "0x1874DEEC0")]
	protected NDENECHCDCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class FDALMIGPCNJ : NDENECHCDCF, GMMBDIEALIP, DAELNCEPFGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private sealed class OHECHDADDJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public CEFINKDJEPJ result;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public OHECHDADDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x74E1CA0", Offset = "0x74E10A0", VA = "0x1874E1CA0")]
		internal object NHHLALHILFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x74CFC70", Offset = "0x74CF070", VA = "0x1874CFC70")]
	[UnityEngine.Scripting.Preserve]
	public FDALMIGPCNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x74CFB60", Offset = "0x74CEF60", VA = "0x1874CFB60", Slot = "8")]
	public CEFINKDJEPJ HPPCPKADBCI(NGDBFKPHNOF OJJIKOKMIHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class PEBEJNANFAD : NDENECHCDCF, EPAOBPAKFLI, DAELNCEPFGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private sealed class BDACFHCAMDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public CEFINKDJEPJ result;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public BDACFHCAMDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x74C7E60", Offset = "0x74C7260", VA = "0x1874C7E60")]
		internal object FKPJMFLJENE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x74CFC70", Offset = "0x74CF070", VA = "0x1874CFC70")]
	[UnityEngine.Scripting.Preserve]
	public PEBEJNANFAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x74E24D0", Offset = "0x74E18D0", VA = "0x1874E24D0", Slot = "8")]
	public CEFINKDJEPJ HNECEBFPIJL(NGDBFKPHNOF NMLJOPBBABK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class NNALPFHPPME
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class CBNJJBIEBMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public PMKGFNIFFEC<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public CBNJJBIEBMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x74C8F90", Offset = "0x74C8390", VA = "0x1874C8F90")]
		internal object EDFIKMBGPLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x74E13B0", Offset = "0x74E07B0", VA = "0x1874E13B0")]
	public static PMKGFNIFFEC<string> EKBJFLHKHOE(EGGMDNJPOBA DFDLACHAHGJ, [Optional] string PABJMPEAIGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x74E1550", Offset = "0x74E0950", VA = "0x1874E1550")]
	public static void PAKAKPKCLGP(PMKGFNIFFEC<string> GBIEPJHIGOL, EGGMDNJPOBA DFDLACHAHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x74E1490", Offset = "0x74E0890", VA = "0x1874E1490")]
	public static string NJPNPADOCKL(OGJBCMINPFI JFLHEILMJIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal static class LEPDFGFADCH
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x74DCA30", Offset = "0x74DBE30", VA = "0x1874DCA30")]
	public static void CLGDDAHAPAK(this ECJBOAIKALM GLAAFJDOHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x74DCA20", Offset = "0x74DBE20", VA = "0x1874DCA20")]
	public static void BJLKKDPKKDK(this ECJBOAIKALM GLAAFJDOHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x74DCA40", Offset = "0x74DBE40", VA = "0x1874DCA40")]
	private static void KMKKNFOKGDB(this ECJBOAIKALM GLAAFJDOHIB, bool ODOBMGHPKPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class CGCLPOFDJLE : CNMNNAEOEPH, FPFKMPLEGLF, AIJHKJECJOH, DJLFHCCDDMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private readonly FPFKMPLEGLF BIMFEKALFNG;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public NGDBFKPHNOF GIAIOBCAMHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x74CB8F0", Offset = "0x74CACF0", VA = "0x1874CB8F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int DABEGFJDDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x74CB940", Offset = "0x74CAD40", VA = "0x1874CB940", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int HOBHLKHPEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x74CBA80", Offset = "0x74CAE80", VA = "0x1874CBA80", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool ELNEGCNFJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int FFIGJKHHHJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x9178F0", Offset = "0x916CF0", VA = "0x1809178F0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event KLEMCPMGFOF.HIDDBAKPMDG NBFFFFGDJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event PIADFKMOEAD LDLBGAMKBJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x74CB990", Offset = "0x74CAD90", VA = "0x1874CB990", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x74CB770", Offset = "0x74CAB70", VA = "0x1874CB770", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> PLLCGCNPLPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<NGDBFKPHNOF> MDLGKAGAEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action EMIEFHGHNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x74CBAD0", Offset = "0x74CAED0", VA = "0x1874CBAD0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x74CBC20", Offset = "0x74CB020", VA = "0x1874CBC20", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0xD52890", Offset = "0xD51C90", VA = "0x180D52890")]
	public CGCLPOFDJLE(FPFKMPLEGLF BIMFEKALFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x74CBB70", Offset = "0x74CAF70", VA = "0x1874CBB70", Slot = "8")]
	public bool PDFIDOAICII(byte IMFFGFAIHGM, ExitGames.Client.Photon.Hashtable KLEMDNBJOKC, FOFFELNILIF CPENBAEIEIB, SendOptions LJKJGJBNOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x74CB810", Offset = "0x74CAC10", VA = "0x1874CB810", Slot = "16")]
	public NGDBFKPHNOF CGOCMCAAMLP(int ALLEINDDJIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "19")]
	public void PMEGHMMGMKD(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "20")]
	public void COGLAOCJPHE(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "21")]
	public void GDGKDKNBMJL(object FDAIGOGAKMH, bool OOMFHMNMHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x74CBA30", Offset = "0x74CAE30", VA = "0x1874CBA30", Slot = "22")]
	public IDisposable NECCPBFBKLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "23")]
	private bool HCEHPCGDPOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "24")]
	public void ELBJBCBOBHI(StringBuilder DLCPIHHJLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xACE300", Offset = "0xACD700", VA = "0x180ACE300", Slot = "25")]
	public bool GBGGANCMIBA(bool CKALBGAKOIO, [Out] string GJAHCEMFFMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x9F1260", Offset = "0x9F0660", VA = "0x1809F1260", Slot = "28")]
	public void PIBHGEMECDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct EOILANHJNDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly IDictionary<object, object> PGKBONDNINN;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
	public EOILANHJNDP(IDictionary<object, object> PGKBONDNINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x74CE4E0", Offset = "0x74CD8E0", VA = "0x1874CE4E0")]
	public bool LCNELLLGLOG([Out] OGJBCMINPFI ADPAIBGIHMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x74CE430", Offset = "0x74CD830", VA = "0x1874CE430")]
	public Guid EKHOCPJMEPA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x74CE300", Offset = "0x74CD700", VA = "0x1874CE300")]
	public CEFINKDJEPJ CMPKJIMGENA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x74CE590", Offset = "0x74CD990", VA = "0x1874CE590")]
	public static ExitGames.Client.Photon.Hashtable LIDOGEGODKP(OGJBCMINPFI ADPAIBGIHMB, CEFINKDJEPJ IGHKPAMMJCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal static class FLFIHBBNHJI
{
	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x74D0FF0", Offset = "0x74D03F0", VA = "0x1874D0FF0")]
	public static bool JLNHJJADNHC(this GAGHJCEIHCL NGFGPIIAAKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct EGPAAOAOMHG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct LNCHDBOOLIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public EGPAAOAOMHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x74DDEA0", Offset = "0x74DD2A0", VA = "0x1874DDEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x74DE080", Offset = "0x74DD480", VA = "0x1874DE080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private readonly CancellationTokenSource INFCCFLIMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private bool HLAMJAHICLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private Task BIDGKFLMMBN;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool OOLCMFGMABL
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x74CDF60", Offset = "0x74CD360", VA = "0x1874CDF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x74CE0F0", Offset = "0x74CD4F0", VA = "0x1874CE0F0")]
	public EGPAAOAOMHG(CancellationToken EEHACKMODLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x74CDFE0", Offset = "0x74CD3E0", VA = "0x1874CDFE0")]
	[AsyncStateMachine(typeof(LNCHDBOOLIM))]
	public Task OBCELIKPHGH(Func<CancellationToken, List<Task>> LIGGLJMPFMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x74CDF90", Offset = "0x74CD390", VA = "0x1874CDF90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public readonly struct HMIILMAMEIM<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct MPCBJFEMDBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<FGAAJMCNHCK<TData>, IDBHBLPOJHF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public HMIILMAMEIM<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private TaskAwaiter<MLIDCCDLMIE<FGAAJMCNHCK<TData>, IDBHBLPOJHF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x484F3A0", Offset = "0x484E7A0", VA = "0x18484F3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x4082500", Offset = "0x4081900", VA = "0x184082500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private readonly CALGNJLGHDH<TGetDataArg, TData> DILMOBAKENH;

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
	internal HMIILMAMEIM(CALGNJLGHDH<TGetDataArg, TData> ICFGLKCGHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x40B7E70", Offset = "0x40B7270", VA = "0x1840B7E70")]
	[AsyncStateMachine(typeof(HMIILMAMEIM<, >.MPCBJFEMDBD))]
	public Task<MLIDCCDLMIE<FGAAJMCNHCK<TData>, IDBHBLPOJHF>> PEBIGOAHGPC(TGetDataArg MGBFBAKCCAP, string PDDHOOBKDAN, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class JGCCFCDGPGI
{
	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE020", Offset = "0x2BDD420", VA = "0x182BDE020")]
	public static HMIILMAMEIM<TGetDataArg, TData> AALKPJMFIHM<TGetDataArg, TData>(CALGNJLGHDH<TGetDataArg, TData> ICFGLKCGHOG)
	{
		return default(HMIILMAMEIM<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct CBIMPNHICDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public readonly int LGLCGKNCHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public readonly int? FFDEIHJOHCG;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x45BC7E0", Offset = "0x45BBBE0", VA = "0x1845BC7E0")]
	public CBIMPNHICDA(int IABOOOMGHFL, [Optional] int? KJEOKMKEHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x74C8EB0", Offset = "0x74C82B0", VA = "0x1874C8EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface FCMPNGBOAFJ<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIPBAENKHBC();

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FCMPNGBOAFJ<T> KOJKPODGFJD(string IJCJJCBDAMK);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FCMPNGBOAFJ<T> ALKKHNLMHAL(JLEOBLICECI<T> FJHNDLPBIOC);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FCMPNGBOAFJ<T> PJEDGFNOJDN(int CCPMBLJCLDM);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FCMPNGBOAFJ<T> ALBBMEFMNNA(int CCPMBLJCLDM, JOFCJEIGGFK<T> IAEDJDGHIJH);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface DCBBIABKPIP
{
	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FCMPNGBOAFJ<T> CJFDGHABIGA<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LAKECCBLAOP CGCPPAOCINK(Exception JFJOELAOBOE);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CBIMPNHICDA NLGAIOBDGDL(Exception JFJOELAOBOE);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate string JLEOBLICECI<in T>(T JFJOELAOBOE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public delegate int JOFCJEIGGFK<in T>(T JFJOELAOBOE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class PGNJPOBPNNG : DCBBIABKPIP
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate string NGIOAHKNPPK(Exception JFJOELAOBOE);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private delegate int DMFDDGIAPMC(Exception JFJOELAOBOE);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class IGABAOBCCNA<T> : FCMPNGBOAFJ<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class HHLIDDPOFBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public HHLIDDPOFBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
			internal string GGKLBJBFMFF(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class LMMKKPPOOOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public JLEOBLICECI<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public LMMKKPPOOOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x41D43A0", Offset = "0x41D37A0", VA = "0x1841D43A0")]
			internal string KPLJDLCAMOC(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class ICCIIEDKHHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public JOFCJEIGGFK<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public ICCIIEDKHHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x41D43A0", Offset = "0x41D37A0", VA = "0x1841D43A0")]
			internal int FBFFCPEEEML(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly PGNJPOBPNNG COODHJNFNHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private readonly Type ACGPMOOJPMH;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x41E45B0", Offset = "0x41E39B0", VA = "0x1841E45B0")]
		internal IGABAOBCCNA(PGNJPOBPNNG COODHJNFNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x41E4420", Offset = "0x41E3820", VA = "0x1841E4420", Slot = "4")]
		public void GIPBAENKHBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x41E4450", Offset = "0x41E3850", VA = "0x1841E4450", Slot = "5")]
		public FCMPNGBOAFJ<T> KOJKPODGFJD(string IJCJJCBDAMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x41E4300", Offset = "0x41E3700", VA = "0x1841E4300", Slot = "6")]
		public FCMPNGBOAFJ<T> ALKKHNLMHAL(JLEOBLICECI<T> FJHNDLPBIOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x41E4570", Offset = "0x41E3970", VA = "0x1841E4570", Slot = "7")]
		public FCMPNGBOAFJ<T> PJEDGFNOJDN(int CCPMBLJCLDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x41E41C0", Offset = "0x41E35C0", VA = "0x1841E41C0", Slot = "8")]
		public FCMPNGBOAFJ<T> ALBBMEFMNNA(int CCPMBLJCLDM, JOFCJEIGGFK<T> IAEDJDGHIJH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class DENCGHMCCGA<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private bool AIFGFCHCFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private readonly List<Type> JBKGFMDLJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private readonly Dictionary<Type, TVal> KOHMEIIDFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly Dictionary<Type, int> AMGHBCNADED;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public IReadOnlyList<Type> MALLGFAKBKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x5C28E80", Offset = "0x5C28280", VA = "0x185C28E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x5C291E0", Offset = "0x5C285E0", VA = "0x185C291E0")]
		public DENCGHMCCGA(Dictionary<Type, int> AMGHBCNADED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x5C29060", Offset = "0x5C28460", VA = "0x185C29060")]
		public void PJLPMKJIOFF(Type GMJINMLEEAC, TVal HMBPNLCBEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x5C28CE0", Offset = "0x5C280E0", VA = "0x185C28CE0")]
		public bool FDMNIDAMJIF(Type ACGPMOOJPMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x5C29000", Offset = "0x5C28400", VA = "0x185C29000")]
		public bool NEIOGECFNMJ(TVal LIHHDPOHLDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x488FD80", Offset = "0x488F180", VA = "0x18488FD80")]
		public TVal JEMJOLBMCNL(Type LGJDMOCCBDP)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x5C28DE0", Offset = "0x5C281E0", VA = "0x185C28DE0")]
		[CompilerGenerated]
		private int GAFDAHCKNPL(Type GEEDGDFGAED, Type ODJBKFGHIKJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class GHJGNDNEBFM : IEnumerable<CBIMPNHICDA>, IEnumerable, IEnumerator<CBIMPNHICDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private CBIMPNHICDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public PGNJPOBPNNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private IEnumerator<CBIMPNHICDA> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		private CBIMPNHICDA System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x3BCDAB0", Offset = "0x3BCCEB0", VA = "0x183BCDAB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CBIMPNHICDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x74D2A00", Offset = "0x74D1E00", VA = "0x1874D2A00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
		[DebuggerHidden]
		public GHJGNDNEBFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x74D2A50", Offset = "0x74D1E50", VA = "0x1874D2A50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x74D23F0", Offset = "0x74D17F0", VA = "0x1874D23F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x74D28A0", Offset = "0x74D1CA0", VA = "0x1874D28A0")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x74D23A0", Offset = "0x74D17A0", VA = "0x1874D23A0")]
		private void EMBCDMFMIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x74D29B0", Offset = "0x74D1DB0", VA = "0x1874D29B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x74D28F0", Offset = "0x74D1CF0", VA = "0x1874D28F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CBIMPNHICDA> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x74D28F0", Offset = "0x74D1CF0", VA = "0x1874D28F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly CBIMPNHICDA KACGAGLGKDO;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Dictionary<Type, int> MMANFPEINPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly HashSet<Type> BIIEPGNBCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly DENCGHMCCGA<int> JDIPAAEFNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly DENCGHMCCGA<DMFDDGIAPMC> DNLDGPBNEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly DENCGHMCCGA<NGIOAHKNPPK> MHNOKFIOKLE;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x74E3440", Offset = "0x74E2840", VA = "0x1874E3440")]
	[FHFMOACGLML.PCGBCKINAAE.IIGHLHFDGPC]
	internal static void MBGCLLCDEMF(ACFNHMKNHLL IFIBOOJGEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x74E39C0", Offset = "0x74E2DC0", VA = "0x1874E39C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PGNJPOBPNNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2E503D0", Offset = "0x2E4F7D0", VA = "0x182E503D0", Slot = "4")]
	public FCMPNGBOAFJ<T> CJFDGHABIGA<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x74E25E0", Offset = "0x74E19E0", VA = "0x1874E25E0", Slot = "5")]
	public LAKECCBLAOP CGCPPAOCINK(Exception JFJOELAOBOE)
	{
		return default(LAKECCBLAOP);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x74E3700", Offset = "0x74E2B00", VA = "0x1874E3700", Slot = "6")]
	public CBIMPNHICDA NLGAIOBDGDL(Exception? JFJOELAOBOE)
	{
		return default(CBIMPNHICDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x74E2A90", Offset = "0x74E1E90", VA = "0x1874E2A90", Slot = "7")]
	[IteratorStateMachine(typeof(GHJGNDNEBFM))]
	public IEnumerable<CBIMPNHICDA> FJJLENKCBFH(Exception JFJOELAOBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x74E2940", Offset = "0x74E1D40", VA = "0x1874E2940", Slot = "8")]
	public string DGBMPOGCCJH(Exception? JFJOELAOBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x74E2B30", Offset = "0x74E1F30", VA = "0x1874E2B30")]
	private string GFGFKFKGPDM(AggregateException FCGHMPDOAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x74E3090", Offset = "0x74E2490", VA = "0x1874E3090")]
	private void LPCDGGHGMIG(Type ACGPMOOJPMH, int CCPMBLJCLDM, DMFDDGIAPMC? LKBADMOIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x74E34B0", Offset = "0x74E28B0", VA = "0x1874E34B0")]
	private void MNOLLOLFHCL(Type ACGPMOOJPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x74E2670", Offset = "0x74E1A70", VA = "0x1874E2670")]
	private void DFJNLKJMELC(Type ACGPMOOJPMH, NGIOAHKNPPK MBKDGJDJDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x74E2E30", Offset = "0x74E2230", VA = "0x1874E2E30")]
	private static int GGNOFJJKLEJ(Type ACGPMOOJPMH, Dictionary<Type, int> AMGHBCNADED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x3015D20", Offset = "0x3015120", VA = "0x183015D20")]
	private static bool PCLKGFMJNAP<TVal>(DENCGHMCCGA<TVal> BIHDACIMKFK, Type ACGPMOOJPMH, [Out] TVal LIHHDPOHLDK) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x74E2FB0", Offset = "0x74E23B0", VA = "0x1874E2FB0")]
	[CompilerGenerated]
	internal static int KMIOHGDJPEH(Type ONPEDMLKAKF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct LAKECCBLAOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public readonly CBIMPNHICDA KAAFEEOFLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public readonly string JIDFDDBGJPG;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x74DC9A0", Offset = "0x74DBDA0", VA = "0x1874DC9A0")]
	public LAKECCBLAOP(string HNBPJHLEMLM, CBIMPNHICDA CCPMBLJCLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x74DC900", Offset = "0x74DBD00", VA = "0x1874DC900")]
	public string DCDDBNDCDBE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class NFPKNMPBOLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly JAJELMFJLBA GPAHKHJAJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private string CPFNKOOCAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private long? EOBCJEODGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private long? CJAOKKOBKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? GIFBHOEDMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private string OBPHCGAMMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private GMFHIOLLICC NEKHIKODMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private long? FPBHGNDKMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private bool KFIMBNFBJJG;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string EFACDMBOEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long DELFGIGMLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x74DFA30", Offset = "0x74DEE30", VA = "0x1874DFA30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public long HDFCKLJMLDO
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x74DF9D0", Offset = "0x74DEDD0", VA = "0x1874DF9D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public long LOONHBJBCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x74DEFD0", Offset = "0x74DE3D0", VA = "0x1874DEFD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string BMEHKOKJLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x74DFD40", Offset = "0x74DF140", VA = "0x1874DFD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public GMFHIOLLICC ALEDIMOHGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x931D20", Offset = "0x931120", VA = "0x180931D20")]
		get
		{
			return default(GMFHIOLLICC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x74DF030", Offset = "0x74DE430", VA = "0x1874DF030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long IGBEDHOEHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x74DFCE0", Offset = "0x74DF0E0", VA = "0x1874DFCE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x74DFD80", Offset = "0x74DF180", VA = "0x1874DFD80")]
	[UnityEngine.Scripting.Preserve]
	public NFPKNMPBOLJ([ACGOIOBGIEE(null)] JAJELMFJLBA GPAHKHJAJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x74DFA90", Offset = "0x74DEE90", VA = "0x1874DFA90")]
	private void HMHGIOIDFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x74DF4A0", Offset = "0x74DE8A0", VA = "0x1874DF4A0")]
	public void GDMJGLMFHCE(long HLGODMOGCOI, long DPDHHEKEIEF, [Optional] long? PDOJDMECHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x74DF930", Offset = "0x74DED30", VA = "0x1874DF930")]
	public void HEOJMHJCCNH(long PDOJDMECHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x74DEF50", Offset = "0x74DE350", VA = "0x1874DEF50")]
	public void BBACMFHDCPJ(string NKDBIOJHKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x74DF120", Offset = "0x74DE520", VA = "0x1874DF120")]
	public void EFMMAOFPMMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class CEBLHCJACGB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct BEMFHAGKFFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public AsyncTaskMethodBuilder<OGJBCMINPFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public OGJBCMINPFI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public CEBLHCJACGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private TaskAwaiter<GGGLGKDJBLD.FOKDGMNAJOJ<OGJBCMINPFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x74E76E0", Offset = "0x74E6AE0", VA = "0x1874E76E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x74E7AF0", Offset = "0x74E6EF0", VA = "0x1874E7AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct GJPLJKCNEBB<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class DOLMIJBMLML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public OGJBCMINPFI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public DOLMIJBMLML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x74EA540", Offset = "0x74E9940", VA = "0x1874EA540")]
		internal OGJBCMINPFI EHPCCAAONEP(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct PCMGIBEBHKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder<GGGLGKDJBLD.FOKDGMNAJOJ<OGJBCMINPFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public OGJBCMINPFI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public CEBLHCJACGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private DFOANCPGDGA <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<GGGLGKDJBLD.FOKDGMNAJOJ<OGJBCMINPFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x74FAC20", Offset = "0x74FA020", VA = "0x1874FAC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x74FB230", Offset = "0x74FA630", VA = "0x1874FB230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct NKLFHGENJGA<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public CEBLHCJACGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x48CE5B0", Offset = "0x48CD9B0", VA = "0x1848CE5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x38877D0", Offset = "0x3886BD0", VA = "0x1838877D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct DCOALNGGGJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public CEBLHCJACGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x74E9B50", Offset = "0x74E8F50", VA = "0x1874E9B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x74E9D10", Offset = "0x74E9110", VA = "0x1874E9D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class GCNACOHOMID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GCNACOHOMID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x74EC1B0", Offset = "0x74EB5B0", VA = "0x1874EC1B0")]
		internal object HNBIGKHOPDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x74EC0F0", Offset = "0x74EB4F0", VA = "0x1874EC0F0")]
		internal bool FOFKOJNDLII(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class JGHLFLNKKCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public JGHLFLNKKCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x74F3DE0", Offset = "0x74F31E0", VA = "0x1874F3DE0")]
		internal object PLFHEEFFLIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class MGNBAGAMKAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public MGNBAGAMKAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x74F7780", Offset = "0x74F6B80", VA = "0x1874F7780")]
		internal object GPPAAGINPFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class DPGDACJEJIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public DPGDACJEJIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x74EA620", Offset = "0x74E9A20", VA = "0x1874EA620")]
		internal object DFJOPDBEAJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class PDPPBNNBKMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public CEBLHCJACGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PDPPBNNBKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x74FB3D0", Offset = "0x74FA7D0", VA = "0x1874FB3D0")]
		internal object IMAHMLHPJGM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private static readonly Guid GFBELIMGPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly ILAHKLFLONK DMAFCAFLCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly GGGLGKDJBLD HKAEFLLAKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly AIJHKJECJOH GLAAFJDOHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly DJLFHCCDDMC CDLNNIPBNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private bool JNMGOABHDNP;

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x74CA0F0", Offset = "0x74C94F0", VA = "0x1874CA0F0")]
	public CEBLHCJACGB(ILAHKLFLONK KFMKOKFLOBK, GGGLGKDJBLD HKAEFLLAKID, AIJHKJECJOH GLAAFJDOHIB, DJLFHCCDDMC CDLNNIPBNAC, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x74C91E0", Offset = "0x74C85E0", VA = "0x1874C91E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x74C91E0", Offset = "0x74C85E0", VA = "0x1874C91E0")]
	public void EOILGGEADEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x74C9010", Offset = "0x74C8410", VA = "0x1874C9010")]
	public void ADLKKGJJABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x74C9D40", Offset = "0x74C9140", VA = "0x1874C9D40")]
	public void OCEIOGBBOIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x74C94B0", Offset = "0x74C88B0", VA = "0x1874C94B0")]
	[AsyncStateMachine(typeof(BEMFHAGKFFF))]
	internal Task<OGJBCMINPFI> JKGLPIJEKBM(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, OGJBCMINPFI JFLHEILMJIN, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A5D0", Offset = "0x2C499D0", VA = "0x182C4A5D0")]
	private static byte[] BOEJEKJFODL<T>(T ADPAIBGIHMB) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2C4AC10", Offset = "0x2C4A010", VA = "0x182C4AC10")]
	private static T KJDDMILMCHJ<T>(MessageParser<T> OKGDKKIFLBD, byte[] ADPAIBGIHMB, T EKLNJAGLKCA) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x74C9610", Offset = "0x74C8A10", VA = "0x1874C9610")]
	[AsyncStateMachine(typeof(PCMGIBEBHKF))]
	private Task<GGGLGKDJBLD.FOKDGMNAJOJ<OGJBCMINPFI>> JMIMALHAGPE(OGJBCMINPFI JFLHEILMJIN, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A5E0", Offset = "0x2C499E0", VA = "0x182C4A5E0")]
	[AsyncStateMachine(typeof(NKLFHGENJGA<>))]
	internal Task<T> HBOAPNHMPJI<T>(CancellationToken COHGPHPHNKH, Func<CancellationToken, Task<T>> LPDDCAOFOLL, int ODFGJDICHEG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x74C9300", Offset = "0x74C8700", VA = "0x1874C9300")]
	[AsyncStateMachine(typeof(DCOALNGGGJC))]
	internal Task HBOAPNHMPJI(CancellationToken COHGPHPHNKH, Func<CancellationToken, Task> LPDDCAOFOLL, int ODFGJDICHEG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x74C9CC0", Offset = "0x74C90C0", VA = "0x1874C9CC0")]
	public HGJKNFDCLAH OAMCIODFJPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x74C9430", Offset = "0x74C8830", VA = "0x1874C9430")]
	public HOJJONDIJKH INBPIACGOCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x74C9B40", Offset = "0x74C8F40", VA = "0x1874C9B40")]
	public ALHMLJMHEAB MHMNNENLJLK([Optional] EGGMDNJPOBA? DFDLACHAHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x74C99E0", Offset = "0x74C8DE0", VA = "0x1874C99E0")]
	public void LBFIKIAIPLD(Func<Guid, bool> KAICGCFDKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x74C90D0", Offset = "0x74C84D0", VA = "0x1874C90D0")]
	public void BPGKGNOBPNM(Func<Guid, bool> PPKLOOIAMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x74C9E00", Offset = "0x74C9200", VA = "0x1874C9E00")]
	public Guid OKHEIKJBMGA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x74C9F80", Offset = "0x74C9380", VA = "0x1874C9F80")]
	public void PIMDLMDHPJD(Guid AFDBFKOHEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x74C9750", Offset = "0x74C8B50", VA = "0x1874C9750")]
	public void JPMOEABDNDN(OGJBCMINPFI ECGFFGOACOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x74C9880", Offset = "0x74C8C80", VA = "0x1874C9880")]
	public void KGPNCCLAFMC(string LJOPAFFAHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2C4AB20", Offset = "0x2C49F20", VA = "0x182C4AB20")]
	private T KEBPPLHPELM<T>(T LIHHDPOHLDK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x74C9990", Offset = "0x74C8D90", VA = "0x1874C9990")]
	public void KNGJGCIPJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A880", Offset = "0x2C49C80", VA = "0x182C4A880")]
	[CompilerGenerated]
	internal static string JPLNJCCNGHA<T>(byte[] HFHEELJJDFM, int ALOHHMGKCFH, GJPLJKCNEBB<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal sealed class MNIAJLFJKIC : ILAHKLFLONK
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class EAKBIDIFJBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public EAKBIDIFJBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x74EA690", Offset = "0x74E9A90", VA = "0x1874EA690")]
		internal object LCKJGALHHIK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct EJMLAMFKBLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public MNIAJLFJKIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public CEBLHCJACGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private DNKNIBGJGBA <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private HOJJONDIJKH <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x74EA840", Offset = "0x74E9C40", VA = "0x1874EA840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x74EB110", Offset = "0x74EA510", VA = "0x1874EB110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct OKJPIHMMHJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public MNIAJLFJKIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private TaskAwaiter<JKIABJFEAHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x74F9EB0", Offset = "0x74F92B0", VA = "0x1874F9EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x74FA660", Offset = "0x74F9A60", VA = "0x1874FA660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct IDPJBFFFAJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public MNIAJLFJKIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter<GAFBGJLGAKK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x74F06F0", Offset = "0x74EFAF0", VA = "0x1874F06F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x74F0A00", Offset = "0x74EFE00", VA = "0x1874F0A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class EHIMJLKNEFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public DNKNIBGJGBA presence;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public EHIMJLKNEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x74EA700", Offset = "0x74E9B00", VA = "0x1874EA700")]
		internal object NILFIJJBBAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private static readonly EGGMDNJPOBA JMOKMPLIJJC;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly EGGMDNJPOBA CNHOJNLEEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private readonly DKKGGCCNPKP LLEKDEGDKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly GAGHJCEIHCL FBCJPMKMIOG;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x74F8770", Offset = "0x74F7B70", VA = "0x1874F8770")]
	public MNIAJLFJKIC(DKKGGCCNPKP LLEKDEGDKHC, GAGHJCEIHCL FBCJPMKMIOG, Guid NJALKLIOMDE, EKHKFFBCABL NOGMIFBJMHC, MNNJFPGNFEF HBDDKPMBHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x74F8560", Offset = "0x74F7960", VA = "0x1874F8560", Slot = "7")]
	[AsyncStateMachine(typeof(EJMLAMFKBLJ))]
	protected override Task KGLLMBAAMCF(CEBLHCJACGB FNKEHJGDCFD, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x74F8180", Offset = "0x74F7580", VA = "0x1874F8180")]
	[AsyncStateMachine(typeof(OKJPIHMMHJP))]
	private Task CIBBOIPHNEL(CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x74F8280", Offset = "0x74F7680", VA = "0x1874F8280")]
	[AsyncStateMachine(typeof(IDPJBFFFAJN))]
	private Task<int> HEOILFLDIJL(CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x74F8390", Offset = "0x74F7790", VA = "0x1874F8390")]
	private DNKNIBGJGBA KEGHHNPPDAG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class OMBFDOGCILN : ILAHKLFLONK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct JABNBJGODAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public OMBFDOGCILN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public CEBLHCJACGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private TaskAwaiter<DEDLCGKHLHK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x74F2AC0", Offset = "0x74F1EC0", VA = "0x1874F2AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x74F3460", Offset = "0x74F2860", VA = "0x1874F3460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private readonly int EFLCBOLABBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private readonly GDMCCAIBAAO ALHPIJFCLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public readonly long PKPEPDBPDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public readonly long FODDILBKLFJ;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public DEDLCGKHLHK IMGFNMKEIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC40", Offset = "0x8AF040", VA = "0x1808AFC40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBF0", Offset = "0x8AEFF0", VA = "0x1808AFBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x74FA7E0", Offset = "0x74F9BE0", VA = "0x1874FA7E0")]
	public OMBFDOGCILN(Guid NJALKLIOMDE, EKHKFFBCABL NOGMIFBJMHC, MNNJFPGNFEF HBDDKPMBHDI, int EFLCBOLABBN, GDMCCAIBAAO ALHPIJFCLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x74FA6C0", Offset = "0x74F9AC0", VA = "0x1874FA6C0", Slot = "7")]
	[AsyncStateMachine(typeof(JABNBJGODAL))]
	protected override Task KGLLMBAAMCF(CEBLHCJACGB FNKEHJGDCFD, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class IEEBIEFIEHI : ILAHKLFLONK
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class KDFPDJEANOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public IEEBIEFIEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public CEKCIOBJGIF playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KDFPDJEANOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x74F4DC0", Offset = "0x74F41C0", VA = "0x1874F4DC0")]
		internal Task CCJMEOIPKBI(PMKGFNIFFEC<string>.INNANANOCLO postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x74F4E00", Offset = "0x74F4200", VA = "0x1874F4E00")]
		internal object OOCAKJINDEE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct IBFCJNHDDPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public IEEBIEFIEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public CEBLHCJACGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private KDFPDJEANOH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x74EF940", Offset = "0x74EED40", VA = "0x1874EF940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x74F0100", Offset = "0x74EF500", VA = "0x1874F0100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct CBJNNOKNALP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public CEKCIOBJGIF playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public IEEBIEFIEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x74E7DE0", Offset = "0x74E71E0", VA = "0x1874E7DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x74E8380", Offset = "0x74E7780", VA = "0x1874E8380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x74F0CF0", Offset = "0x74F00F0", VA = "0x1874F0CF0")]
	public IEEBIEFIEHI(Guid NJALKLIOMDE, EKHKFFBCABL NOGMIFBJMHC, MNNJFPGNFEF HBDDKPMBHDI, string CAHIOLBMNML, PHKHCKBHGEB KCOEJFJMFIK, bool MAHAJKBDPDL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x74F0BB0", Offset = "0x74EFFB0", VA = "0x1874F0BB0", Slot = "7")]
	[AsyncStateMachine(typeof(IBFCJNHDDPD))]
	protected override Task KGLLMBAAMCF(CEBLHCJACGB FNKEHJGDCFD, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task KGMNFJINBLI(CEBLHCJACGB FNKEHJGDCFD, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x74F0A70", Offset = "0x74EFE70", VA = "0x1874F0A70")]
	[AsyncStateMachine(typeof(CBJNNOKNALP))]
	private Task JBMNIPNGBPO(IDisposable EOKCEDILHAF, CEKCIOBJGIF CLBMMMMIBNB, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class LJPNOLIIKGD : ILAHKLFLONK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct DEAFLHNGBIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public LJPNOLIIKGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public CEBLHCJACGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private TaskAwaiter<IOMOLFGHOOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x74E9D70", Offset = "0x74E9170", VA = "0x1874E9D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x74EA2E0", Offset = "0x74E96E0", VA = "0x1874EA2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly HFDEDFLKCBL DODPONFKEMI;

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x74F6520", Offset = "0x74F5920", VA = "0x1874F6520")]
	public LJPNOLIIKGD(Guid NJALKLIOMDE, EKHKFFBCABL NOGMIFBJMHC, MNNJFPGNFEF HBDDKPMBHDI, HFDEDFLKCBL DODPONFKEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x74F6320", Offset = "0x74F5720", VA = "0x1874F6320", Slot = "6")]
	protected override string CAIAJICDICK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x74F6400", Offset = "0x74F5800", VA = "0x1874F6400", Slot = "7")]
	[AsyncStateMachine(typeof(DEAFLHNGBIM))]
	protected override Task KGLLMBAAMCF(CEBLHCJACGB FNKEHJGDCFD, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal abstract class ILAHKLFLONK : HHHHJGPJOOF
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public delegate Task LFADLCJMGDD(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class PDGCJOIBOKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public PMKGFNIFFEC<string>.INNANANOCLO operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public ILAHKLFLONK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PDGCJOIBOKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x74FB2A0", Offset = "0x74FA6A0", VA = "0x1874FB2A0")]
		internal Task GFKFEBMJGHN(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class HKBOCGHPHAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public PDGCJOIBOKB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HKBOCGHPHAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x74ED6F0", Offset = "0x74ECAF0", VA = "0x1874ED6F0")]
		internal object ACGELIPLCCG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct BBOGLNMIEEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public ILAHKLFLONK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public Func<ILAHKLFLONK, PMKGFNIFFEC<string>.INNANANOCLO, CEBLHCJACGB> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private PDGCJOIBOKB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private CEBLHCJACGB <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private TaskAwaiter<OGJBCMINPFI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x74E6580", Offset = "0x74E5980", VA = "0x1874E6580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x74E7680", Offset = "0x74E6A80", VA = "0x1874E7680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct AEPIPJJAGEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x74E4D60", Offset = "0x74E4160", VA = "0x1874E4D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x74E5800", Offset = "0x74E4C00", VA = "0x1874E5800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct MIFLDKOIDPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public ILAHKLFLONK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x74F77F0", Offset = "0x74F6BF0", VA = "0x1874F77F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x74F7B50", Offset = "0x74F6F50", VA = "0x1874F7B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public readonly Guid OEDMAJDGCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public readonly ByteString KCNKCGHHHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly MNNJFPGNFEF HPBPHGNNMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	protected readonly string FDDMHHNGJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private readonly EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private readonly bool MAHAJKBDPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly Queue<LFADLCJMGDD> NEJEOCNLGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly CNFGJKAIGBN EFCLGOGAONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly PHKHCKBHGEB KCOEJFJMFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private bool DFHGFENGPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public GMFHIOLLICC JHNDAONIEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public GMFHIOLLICC FMDAOPNBMFD;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public EKHKFFBCABL HOIGEHNFAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F50", Offset = "0x8A9350", VA = "0x1808A9F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public EHLDCOMLOKA HEHDJMJINLD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x74F1360", Offset = "0x74F0760", VA = "0x1874F1360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public CLEMMADEOBN GNJEBHFINEE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x74F13B0", Offset = "0x74F07B0", VA = "0x1874F13B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public KLDHFEKEHPL AELNFGOMKIL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x74F1520", Offset = "0x74F0920", VA = "0x1874F1520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event FDKDILPPKAF OFPPPAICECB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x74F15A0", Offset = "0x74F09A0", VA = "0x1874F15A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x74F1420", Offset = "0x74F0820", VA = "0x1874F1420", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x74F1980", Offset = "0x74F0D80", VA = "0x1874F1980")]
	protected ILAHKLFLONK(Guid NJALKLIOMDE, EKHKFFBCABL NOGMIFBJMHC, MNNJFPGNFEF HBDDKPMBHDI, string CAHIOLBMNML, PHKHCKBHGEB KCOEJFJMFIK, bool MAHAJKBDPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x74F0FC0", Offset = "0x74F03C0", VA = "0x1874F0FC0", Slot = "6")]
	protected virtual string CAIAJICDICK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x74F1440", Offset = "0x74F0840", VA = "0x1874F1440")]
	public void LDPIBNHMJOJ(LFADLCJMGDD AMDBOGBIGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x74F1400", Offset = "0x74F0800", VA = "0x1874F1400")]
	protected void LCHDBPILCBH(float EDLBBMLDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x74F1120", Offset = "0x74F0520", VA = "0x1874F1120")]
	[AsyncStateMachine(typeof(BBOGLNMIEEM))]
	public Task EHNFAJDFHCN(CancellationToken EEHACKMODLA, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, [Optional] Func<ILAHKLFLONK, PMKGFNIFFEC<string>.INNANANOCLO, CEBLHCJACGB> FHKBCGPNGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x74F1850", Offset = "0x74F0C50", VA = "0x1874F1850")]
	[AsyncStateMachine(typeof(AEPIPJJAGEA))]
	private static Task PHAAPEBIJLN(Func<CancellationToken, Task> JEHBHDHPOGD, Func<CancellationToken, Task> MEEHJLLBMJM, CancellationToken COHGPHPHNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x74F15C0", Offset = "0x74F09C0", VA = "0x1874F15C0")]
	private void NJOGKPDIOHH(bool HOLPGNIFENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x74F1740", Offset = "0x74F0B40", VA = "0x1874F1740")]
	private void NLPFBKHONOC(CEBLHCJACGB FNKEHJGDCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task KGLLMBAAMCF(CEBLHCJACGB FNKEHJGDCFD, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x74F1000", Offset = "0x74F0400", VA = "0x1874F1000")]
	[AsyncStateMachine(typeof(MIFLDKOIDPK))]
	private Task DPJGDDCPNFN(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x74F0F40", Offset = "0x74F0340", VA = "0x1874F0F40")]
	public OGJBCMINPFI APAECFBPFKK(DFOANCPGDGA MFODCNEANIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x74F1270", Offset = "0x74F0670", VA = "0x1874F1270")]
	[CompilerGenerated]
	private Task HECAAABOHDF(CancellationToken HIKBGGAGLAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x74F14A0", Offset = "0x74F08A0", VA = "0x1874F14A0")]
	[CompilerGenerated]
	private object MBIAMOBPLON()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal sealed class DLHAAGIEAOB : IEEBIEFIEHI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct KKJCPFEMFBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public DLHAAGIEAOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public CEBLHCJACGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private HLIJPGBPOLB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private HOJJONDIJKH <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x74F5520", Offset = "0x74F4920", VA = "0x1874F5520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x74F5C80", Offset = "0x74F5080", VA = "0x1874F5C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private readonly DKKGGCCNPKP GAHAPEJEMNN;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x74EA490", Offset = "0x74E9890", VA = "0x1874EA490")]
	public DLHAAGIEAOB(Guid NJALKLIOMDE, EKHKFFBCABL NOGMIFBJMHC, DKKGGCCNPKP GAHAPEJEMNN, MNNJFPGNFEF HBDDKPMBHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x74EA340", Offset = "0x74E9740", VA = "0x1874EA340", Slot = "8")]
	[AsyncStateMachine(typeof(KKJCPFEMFBO))]
	protected override Task KGMNFJINBLI(CEBLHCJACGB FNKEHJGDCFD, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class MJGDNICLNNA : ILAHKLFLONK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct MIMDOMHPFHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public MJGDNICLNNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public CEBLHCJACGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private TaskAwaiter<IOMOLFGHOOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x74F7BB0", Offset = "0x74F6FB0", VA = "0x1874F7BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x74F7F60", Offset = "0x74F7360", VA = "0x1874F7F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private readonly string OCGEHLPJOAN;

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x74F80D0", Offset = "0x74F74D0", VA = "0x1874F80D0")]
	public MJGDNICLNNA(Guid NJALKLIOMDE, EKHKFFBCABL NOGMIFBJMHC, MNNJFPGNFEF HBDDKPMBHDI, string OCGEHLPJOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x74F7FC0", Offset = "0x74F73C0", VA = "0x1874F7FC0", Slot = "7")]
	[AsyncStateMachine(typeof(MIMDOMHPFHP))]
	protected override Task KGLLMBAAMCF(CEBLHCJACGB FNKEHJGDCFD, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class KJDPCEFIEKL : IEEBIEFIEHI
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class PFNKLDADOMD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public AsyncTaskMethodBuilder<OGJBCMINPFI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public PFNKLDADOMD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<IOMOLFGHOOF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			private TaskAwaiter<OGJBCMINPFI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x74FCCA0", Offset = "0x74FC0A0", VA = "0x1874FCCA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x74FD160", Offset = "0x74FC560", VA = "0x1874FD160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public KJDPCEFIEKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public ALHMLJMHEAB serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public IHFJLNHDCBG roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public HGJKNFDCLAH uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public IODGLGMPJNA roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PFNKLDADOMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x74FB620", Offset = "0x74FAA20", VA = "0x1874FB620")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<OGJBCMINPFI> HMPEDOIFBAM(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct IMEOIFFADHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public KJDPCEFIEKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CEBLHCJACGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private PFNKLDADOMD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private HLIJPGBPOLB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private HOJJONDIJKH <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private OGJBCMINPFI <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter<OGJBCMINPFI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x74F1AE0", Offset = "0x74F0EE0", VA = "0x1874F1AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x74F2A60", Offset = "0x74F1E60", VA = "0x1874F2A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private static readonly EGGMDNJPOBA JMOKMPLIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly int JGOGDPEFFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	[CanBeNull]
	private readonly PKOOPKBNGEK HJOEHEMELJN;

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x74F5470", Offset = "0x74F4870", VA = "0x1874F5470")]
	public KJDPCEFIEKL(Guid NJALKLIOMDE, EKHKFFBCABL NOGMIFBJMHC, int JGOGDPEFFEP, PKOOPKBNGEK HJOEHEMELJN, MNNJFPGNFEF HBDDKPMBHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x74F5280", Offset = "0x74F4680", VA = "0x1874F5280", Slot = "8")]
	[AsyncStateMachine(typeof(IMEOIFFADHE))]
	protected override Task KGMNFJINBLI(CEBLHCJACGB FNKEHJGDCFD, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x74F4FB0", Offset = "0x74F43B0", VA = "0x1874F4FB0")]
	private void HBJHLILFKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x74F50B0", Offset = "0x74F44B0", VA = "0x1874F50B0")]
	private void JFDCIMMKKGD(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, HLIJPGBPOLB HLEALEHHCCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal abstract class DAGDBOHNCLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public readonly ILAHKLFLONK DMAFCAFLCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public readonly CEBLHCJACGB GPHKOCNKHOM;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public EHLDCOMLOKA HEHDJMJINLD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x74E99F0", Offset = "0x74E8DF0", VA = "0x1874E99F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public KLDHFEKEHPL AELNFGOMKIL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x74E9A60", Offset = "0x74E8E60", VA = "0x1874E9A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x74E9AF0", Offset = "0x74E8EF0", VA = "0x1874E9AF0")]
	protected DAGDBOHNCLI(CEBLHCJACGB FNKEHJGDCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x74E9A40", Offset = "0x74E8E40", VA = "0x1874E9A40")]
	protected void KGPNCCLAFMC(string LJOPAFFAHMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct HLBBFGDNFBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public Dictionary<Guid, List<KOGFLKINEFL>> AGOLPPPBNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public Dictionary<Guid, List<KOGFLKINEFL>> LGNCCBNHDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<KOGFLKINEFL>> APAGGHIIMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public List<Guid> IBKBEJDDDFD;

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x74ED7B0", Offset = "0x74ECBB0", VA = "0x1874ED7B0")]
	public static HLBBFGDNFBE JEMJOLBMCNL(EHLDCOMLOKA AJKICPHDFFF, GMFHIOLLICC GBEKHIEOIMF, PHNAGDHGBII PDHBHCCJKNA)
	{
		return default(HLBBFGDNFBE);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct EPKNCKPPIGL
{
	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0")]
	public static EPKNCKPPIGL LIDOGEGODKP()
	{
		return default(EPKNCKPPIGL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct AFDNEPEKBNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public readonly JKIABJFEAHD ENDIDOEDCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public readonly OCIJPHOBBHK EMKDJADMIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly string ABFNDBDJBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly PNJFLFBCBJP PFHICJBHJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly PNJFLFBCBJP FGBBGGCPMMJ;

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x74E5860", Offset = "0x74E4C60", VA = "0x1874E5860")]
	public AFDNEPEKBNA(JKIABJFEAHD ENDIDOEDCIB, OCIJPHOBBHK EMKDJADMIGA, string ABFNDBDJBEH, PNJFLFBCBJP PFHICJBHJNE, PNJFLFBCBJP FGBBGGCPMMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct GGHAPGOHFHL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private readonly CEBLHCJACGB FNKEHJGDCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private readonly Guid AFDBFKOHEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private bool HOLPGNIFENN;

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x74EC310", Offset = "0x74EB710", VA = "0x1874EC310")]
	public static GGHAPGOHFHL OKHEIKJBMGA(CEBLHCJACGB FNKEHJGDCFD)
	{
		return default(GGHAPGOHFHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0xC8C5E0", Offset = "0xC8B9E0", VA = "0x180C8C5E0")]
	public void FLKHGDGCCNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x74EC210", Offset = "0x74EB610", VA = "0x1874EC210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x74EC370", Offset = "0x74EB770", VA = "0x1874EC370")]
	private GGHAPGOHFHL(CEBLHCJACGB FNKEHJGDCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x74EC210", Offset = "0x74EB610", VA = "0x1874EC210")]
	private void PIMDLMDHPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x74EC270", Offset = "0x74EB670", VA = "0x1874EC270")]
	private Func<Guid, bool> NOEECACLPPD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class HOJJONDIJKH : DAGDBOHNCLI, HHHHJGPJOOF
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public delegate Task<GMFHIOLLICC> AIMKPGNELEN(PHNAGDHGBII MPMEGOKIEPF, FACBMFKENMF OMFNDHHJEEE, CNFGJKAIGBN AAANMNHHFCK, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct LNBDANLDMJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public DKKGGCCNPKP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private GGHAPGOHFHL <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private TaskAwaiter<OGJBCMINPFI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x74F65C0", Offset = "0x74F59C0", VA = "0x1874F65C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x74F6D30", Offset = "0x74F6130", VA = "0x1874F6D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct CNPHFCDFLOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public AsyncTaskMethodBuilder<OGJBCMINPFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public DKKGGCCNPKP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private PMKGFNIFFEC<string>.INNANANOCLO <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private TaskAwaiter<OGJBCMINPFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x74E9550", Offset = "0x74E8950", VA = "0x1874E9550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x74E9980", Offset = "0x74E8D80", VA = "0x1874E9980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct LBOKNBECFJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public DKKGGCCNPKP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private PMKGFNIFFEC<string>.INNANANOCLO <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x74F5CE0", Offset = "0x74F50E0", VA = "0x1874F5CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x74F6170", Offset = "0x74F5570", VA = "0x1874F6170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class NBFJLFKLALJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AsyncTaskMethodBuilder<AFDNEPEKBNA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public NBFJLFKLALJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private AFDNEPEKBNA <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private TaskAwaiter<GMFHIOLLICC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private TaskAwaiter<AFDNEPEKBNA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x74FB740", Offset = "0x74FAB40", VA = "0x1874FB740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x74FBEE0", Offset = "0x74FB2E0", VA = "0x1874FBEE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public AsyncTaskMethodBuilder<PHNAGDHGBII> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public NBFJLFKLALJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private PHNAGDHGBII <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter<GMFHIOLLICC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter<PHNAGDHGBII> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x74FBF50", Offset = "0x74FB350", VA = "0x1874FBF50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x74FC5A0", Offset = "0x74FB9A0", VA = "0x1874FC5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public DKKGGCCNPKP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CNFGJKAIGBN preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public CNFGJKAIGBN downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public AFDNEPEKBNA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public CNFGJKAIGBN postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public PHNAGDHGBII phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public JGBNIGAIAMJ.KMIHOEJJGBM <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public NBFJLFKLALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x74F8D20", Offset = "0x74F8120", VA = "0x1874F8D20")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<AFDNEPEKBNA> NFGBFNGDPBD(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x74F8900", Offset = "0x74F7D00", VA = "0x1874F8900")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<PHNAGDHGBII> DGMCMGIHACG(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x74F8B80", Offset = "0x74F7F80", VA = "0x1874F8B80")]
		internal void GBKACJDNMEI(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x74F8BC0", Offset = "0x74F7FC0", VA = "0x1874F8BC0")]
		internal Task GMBICNAMDPI(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x74F8A20", Offset = "0x74F7E20", VA = "0x1874F8A20")]
		internal Task EGGDMNJIAEC(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct GLAKIBINPDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public DKKGGCCNPKP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private NBFJLFKLALJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter<AFDNEPEKBNA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter<PHNAGDHGBII> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x74EC970", Offset = "0x74EBD70", VA = "0x1874EC970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x74ED690", Offset = "0x74ECA90", VA = "0x1874ED690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct KBMLHIKGEAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public PHNAGDHGBII phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public CNFGJKAIGBN postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private TaskAwaiter<GMFHIOLLICC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private FACBMFKENMF <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x74F3E40", Offset = "0x74F3240", VA = "0x1874F3E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x74F4D60", Offset = "0x74F4160", VA = "0x1874F4D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct JECEJPNNHIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x74F34C0", Offset = "0x74F28C0", VA = "0x1874F34C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x74F3D80", Offset = "0x74F3180", VA = "0x1874F3D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct MFEIFPGMPHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public CNFGJKAIGBN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private PMKGFNIFFEC<string>.INNANANOCLO <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private TaskAwaiter<GMFHIOLLICC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x74F6D90", Offset = "0x74F6190", VA = "0x1874F6D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x74F7720", Offset = "0x74F6B20", VA = "0x1874F7720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct NLOOMMPBMKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AsyncTaskMethodBuilder<GMFHIOLLICC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public CNFGJKAIGBN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private PMKGFNIFFEC<string>.INNANANOCLO <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private TaskAwaiter<GMFHIOLLICC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x74F8E60", Offset = "0x74F8260", VA = "0x1874F8E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x74F9E40", Offset = "0x74F9240", VA = "0x1874F9E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct CMKOIEFBHBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public AsyncTaskMethodBuilder<GMFHIOLLICC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public CNFGJKAIGBN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public FACBMFKENMF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private PMKGFNIFFEC<string>.INNANANOCLO <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter<GMFHIOLLICC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x74E83E0", Offset = "0x74E77E0", VA = "0x1874E83E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x74E94E0", Offset = "0x74E88E0", VA = "0x1874E94E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct PAJGKFLAILI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder<GMFHIOLLICC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public GMFHIOLLICC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public CNFGJKAIGBN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public PHNAGDHGBII deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter<GMFHIOLLICC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x74FA910", Offset = "0x74F9D10", VA = "0x1874FA910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x74FABB0", Offset = "0x74F9FB0", VA = "0x1874FABB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class KFAMNIMOHIB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public AsyncTaskMethodBuilder<GMFHIOLLICC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public KFAMNIMOHIB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			private DMBBNIDMCGE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private TaskAwaiter<GMFHIOLLICC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0x74FC610", Offset = "0x74FBA10", VA = "0x1874FC610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x74FCC30", Offset = "0x74FC030", VA = "0x1874FCC30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public CNFGJKAIGBN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public AIMKPGNELEN masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public FACBMFKENMF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public GMFHIOLLICC originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KFAMNIMOHIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x74F4E90", Offset = "0x74F4290", VA = "0x1874F4E90")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<GMFHIOLLICC> JJLKGDMPPKG(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct IDGIBFJKPPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public AsyncTaskMethodBuilder<GMFHIOLLICC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public CNFGJKAIGBN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public AIMKPGNELEN masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public FACBMFKENMF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<GMFHIOLLICC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x74F0160", Offset = "0x74EF560", VA = "0x1874F0160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x74F0680", Offset = "0x74EFA80", VA = "0x1874F0680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct GIMOCELLJCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public CNFGJKAIGBN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private GMFHIOLLICC <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private IEnumerator<GMFHIOLLICC> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private TaskAwaiter<GMFHIOLLICC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x74EC3C0", Offset = "0x74EB7C0", VA = "0x1874EC3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x74EC910", Offset = "0x74EBD10", VA = "0x1874EC910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct BIGGCCCAOHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x74E7B60", Offset = "0x74E6F60", VA = "0x1874E7B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x74E7D80", Offset = "0x74E7180", VA = "0x1874E7D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct IENDLGMPJJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x74F0D40", Offset = "0x74F0140", VA = "0x1874F0D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x74F0EE0", Offset = "0x74F02E0", VA = "0x1874F0EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct ELJIEELAJMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public PHNAGDHGBII phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public CNFGJKAIGBN postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter<GMFHIOLLICC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private FACBMFKENMF <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x74EB170", Offset = "0x74EA570", VA = "0x1874EB170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x74EC090", Offset = "0x74EB490", VA = "0x1874EC090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct ANMGMDJHNGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public AsyncTaskMethodBuilder<GMFHIOLLICC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public HOJJONDIJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public CNFGJKAIGBN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter<GMFHIOLLICC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x74E59E0", Offset = "0x74E4DE0", VA = "0x1874E59E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x74E6510", Offset = "0x74E5910", VA = "0x1874E6510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly JEGFLDIDKCF BHKLNOECGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly JEGFLDIDKCF GHPKKKBDKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly NFPKNMPBOLJ DGBJOLGAOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly HKPIBPIMJBI LMIJKJCBGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly KGHDOLJLDCG MNMHHIELMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private ProfilerCounterValue<int> GDEFBDNNAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly DCJBJJMPFFF ODLCMEOIKEB;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private EKHKFFBCABL HOIGEHNFAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x74EE0D0", Offset = "0x74ED4D0", VA = "0x1874EE0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event FDKDILPPKAF OFPPPAICECB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x74EF500", Offset = "0x74EE900", VA = "0x1874EF500", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x74EF340", Offset = "0x74EE740", VA = "0x1874EF340", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x74EF680", Offset = "0x74EEA80", VA = "0x1874EF680")]
	public HOJJONDIJKH(CEBLHCJACGB FNKEHJGDCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x74EDDB0", Offset = "0x74ED1B0", VA = "0x1874EDDB0")]
	[AsyncStateMachine(typeof(LNBDANLDMJD))]
	public Task BBJMCGOJJCC(DKKGGCCNPKP JHKMPCADNAF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x74EE2E0", Offset = "0x74ED6E0", VA = "0x1874EE2E0")]
	[AsyncStateMachine(typeof(CNPHFCDFLOK))]
	private Task<OGJBCMINPFI> DMFGJEKGOCL(DKKGGCCNPKP JHKMPCADNAF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x74EF1D0", Offset = "0x74EE5D0", VA = "0x1874EF1D0")]
	[AsyncStateMachine(typeof(LBOKNBECFJD))]
	private Task KLKFINFMNFL(DKKGGCCNPKP JHKMPCADNAF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x74EEBA0", Offset = "0x74EDFA0", VA = "0x1874EEBA0")]
	[AsyncStateMachine(typeof(GLAKIBINPDB))]
	private Task IIKPHECPLFB(DKKGGCCNPKP JHKMPCADNAF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken FCLJAGBILAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x74EE480", Offset = "0x74ED880", VA = "0x1874EE480")]
	[AsyncStateMachine(typeof(KBMLHIKGEAJ))]
	private Task FAGMOEPMCEN(PHNAGDHGBII GHDOPODBOOF, CNFGJKAIGBN OJJNFFAGEJO, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken BGHPHKKMIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x74EF3A0", Offset = "0x74EE7A0", VA = "0x1874EF3A0")]
	[AsyncStateMachine(typeof(JECEJPNNHIM))]
	private Task MNOOAPGEMNP(PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x74EE5D0", Offset = "0x74ED9D0", VA = "0x1874EE5D0")]
	[AsyncStateMachine(typeof(MFEIFPGMPHN))]
	private Task FCAJNCMPNGD(PHNAGDHGBII MPMEGOKIEPF, CNFGJKAIGBN AAANMNHHFCK, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x74EF520", Offset = "0x74EE920", VA = "0x1874EF520")]
	[AsyncStateMachine(typeof(NLOOMMPBMKI))]
	private Task<GMFHIOLLICC> OJEOCJABJNN(PHNAGDHGBII MPMEGOKIEPF, FACBMFKENMF JPAHENONEFM, CNFGJKAIGBN AAANMNHHFCK, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x74EE760", Offset = "0x74EDB60", VA = "0x1874EE760")]
	[AsyncStateMachine(typeof(CMKOIEFBHBK))]
	private Task<GMFHIOLLICC> GFLDIGJKKCI(PHNAGDHGBII MPMEGOKIEPF, FACBMFKENMF JPAHENONEFM, CNFGJKAIGBN AAANMNHHFCK, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x74EF050", Offset = "0x74EE450", VA = "0x1874EF050")]
	[AsyncStateMachine(typeof(PAJGKFLAILI))]
	private Task<GMFHIOLLICC> KEPNLLMCFMD(GMFHIOLLICC GBEKHIEOIMF, PHNAGDHGBII PDHBHCCJKNA, CNFGJKAIGBN AAANMNHHFCK, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA, bool JAFILIHNMHC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x74EEF30", Offset = "0x74EE330", VA = "0x1874EEF30")]
	private bool JNGPPLBGKML(PHNAGDHGBII GHDOPODBOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x74EDF00", Offset = "0x74ED300", VA = "0x1874EDF00")]
	[AsyncStateMachine(typeof(IDGIBFJKPPI))]
	protected Task<GMFHIOLLICC> BCKBFNDBHNI(PHNAGDHGBII MPMEGOKIEPF, FACBMFKENMF JPAHENONEFM, CNFGJKAIGBN AAANMNHHFCK, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA, AIMKPGNELEN MONFOKBGFJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x74EE190", Offset = "0x74ED590", VA = "0x1874EE190")]
	[AsyncStateMachine(typeof(GIMOCELLJCN))]
	private Task CNMBDDGMHNP(PHNAGDHGBII MPMEGOKIEPF, CNFGJKAIGBN AAANMNHHFCK, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x74EF4B0", Offset = "0x74EE8B0", VA = "0x1874EF4B0")]
	private void NCHNACMAJFD(GMFHIOLLICC HDDANEACAIB, CNFGJKAIGBN AAANMNHHFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x74EE720", Offset = "0x74EDB20", VA = "0x1874EE720")]
	private void FLNBKHMJOLA(GMFHIOLLICC ENCIMPFLGIH, [Out] GMFHIOLLICC GIKKDKAFIKP, [Out] GMFHIOLLICC OONAJCBMKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x74EE440", Offset = "0x74ED840", VA = "0x1874EE440")]
	private Task<AFDNEPEKBNA> EICIDEOBGNP(DKKGGCCNPKP JHKMPCADNAF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x74EE090", Offset = "0x74ED490", VA = "0x1874EE090")]
	private Task<PHNAGDHGBII> BNBKJBCLEGN(AFDNEPEKBNA MPMEGOKIEPF, JGBNIGAIAMJ.KMIHOEJJGBM DGCKOEAILPD, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x74EEA50", Offset = "0x74EDE50", VA = "0x1874EEA50")]
	[AsyncStateMachine(typeof(BIGGCCCAOHH))]
	private Task IGDCDFFIKMJ(PHNAGDHGBII MPMEGOKIEPF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA, bool BFNNJPCMKAA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x74EECE0", Offset = "0x74EE0E0", VA = "0x1874EECE0")]
	[AsyncStateMachine(typeof(IENDLGMPJJE))]
	private Task IOODFAIEJDM(PHNAGDHGBII MPMEGOKIEPF, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x74EF020", Offset = "0x74EE420", VA = "0x1874EF020")]
	private Task KEKOCLKCMME(PHNAGDHGBII MPMEGOKIEPF, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x74EEA30", Offset = "0x74EDE30", VA = "0x1874EEA30")]
	private Task IANMEJNLPLC(PHNAGDHGBII MPMEGOKIEPF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x74EF310", Offset = "0x74EE710", VA = "0x1874EF310")]
	private Task KLOKNBCJKCE(PHNAGDHGBII MPMEGOKIEPF, FACBMFKENMF JPAHENONEFM, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x74EF360", Offset = "0x74EE760", VA = "0x1874EF360")]
	private Task LOHMPMOFHDO(PHNAGDHGBII MPMEGOKIEPF, FACBMFKENMF JPAHENONEFM, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x74EF330", Offset = "0x74EE730", VA = "0x1874EF330")]
	private static Task LBKALEHAEKJ(CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x74EF380", Offset = "0x74EE780", VA = "0x1874EF380")]
	private Task MNBILDNLNON(PHNAGDHGBII MPMEGOKIEPF, FACBMFKENMF JPAHENONEFM, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x74EE170", Offset = "0x74ED570", VA = "0x1874EE170")]
	private Task CMAAJKHKKAF(PHNAGDHGBII MPMEGOKIEPF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x74EE120", Offset = "0x74ED520", VA = "0x1874EE120")]
	private void CLOJBEGOFDK(DKKGGCCNPKP JHKMPCADNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x74EE100", Offset = "0x74ED500", VA = "0x1874EE100")]
	public void CKKDIOBPNCC(long PDOJDMECHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	private static void JLEFMDDODMB(JKIABJFEAHD ENDIDOEDCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x74EE8E0", Offset = "0x74EDCE0", VA = "0x1874EE8E0")]
	[AsyncStateMachine(typeof(ELJIEELAJMB))]
	private Task GOBDGCCMDKB(PHNAGDHGBII GHDOPODBOOF, CNFGJKAIGBN OJJNFFAGEJO, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken BGHPHKKMIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x74EEDD0", Offset = "0x74EE1D0", VA = "0x1874EEDD0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(ANMGMDJHNGN))]
	private Task<GMFHIOLLICC> JEBBBFFJOBB(PHNAGDHGBII MPMEGOKIEPF, FACBMFKENMF JPAHENONEFM, CNFGJKAIGBN AAANMNHHFCK, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct PMNLLEODONK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private PHNAGDHGBII MPMEGOKIEPF;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private EHLDCOMLOKA HEHDJMJINLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7514A20", Offset = "0x7513E20", VA = "0x187514A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x7514730", Offset = "0x7513B30", VA = "0x187514730")]
	public static Task EHNFAJDFHCN(EKHKFFBCABL NOGMIFBJMHC, PHNAGDHGBII MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x7514810", Offset = "0x7513C10", VA = "0x187514810")]
	private void EHNFAJDFHCN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct GBGHPHHCNND
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x7506490", Offset = "0x7505890", VA = "0x187506490")]
	public static Task EHNFAJDFHCN(CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct EAGCPJKADIP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct BACLCEAGPDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public CEBLHCJACGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private PMKGFNIFFEC<string>.INNANANOCLO <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x74FFA30", Offset = "0x74FEE30", VA = "0x1874FFA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x74FFF60", Offset = "0x74FF360", VA = "0x1874FFF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x7503E80", Offset = "0x7503280", VA = "0x187503E80")]
	[AsyncStateMachine(typeof(BACLCEAGPDB))]
	public static Task EHNFAJDFHCN(CEBLHCJACGB FNKEHJGDCFD, PHNAGDHGBII MPMEGOKIEPF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct BKGNMFMHFMH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct POIJBPHKPJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public CEBLHCJACGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public FACBMFKENMF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private GMFHIOLLICC <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private EKHKFFBCABL <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private EHLDCOMLOKA <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private DMBBNIDMCGE <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private List<(PersistenceView, FGFJJKFMCDJ)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private FGFJJKFMCDJ <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x75151B0", Offset = "0x75145B0", VA = "0x1875151B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x7515E40", Offset = "0x7515240", VA = "0x187515E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x7500000", Offset = "0x74FF400", VA = "0x187500000")]
	[AsyncStateMachine(typeof(POIJBPHKPJJ))]
	public static Task EHNFAJDFHCN(CEBLHCJACGB FNKEHJGDCFD, PHNAGDHGBII MPMEGOKIEPF, FACBMFKENMF JPAHENONEFM, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x7500150", Offset = "0x74FF550", VA = "0x187500150")]
	private static void KBEHNFCCHFJ(PersistenceView DOKLPJEMEAH, FGFJJKFMCDJ BLFEKFIMKCH, PHNAGDHGBII MPMEGOKIEPF, GMFHIOLLICC GBEKHIEOIMF, bool FOJIFJJFEOE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct NHOFCABJCOE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct HIGAAHJKAPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public EKHKFFBCABL roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x75091C0", Offset = "0x75085C0", VA = "0x1875091C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x75095F0", Offset = "0x75089F0", VA = "0x1875095F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7512870", Offset = "0x7511C70", VA = "0x187512870")]
	[AsyncStateMachine(typeof(HIGAAHJKAPF))]
	public static Task EHNFAJDFHCN(EKHKFFBCABL NOGMIFBJMHC, PHNAGDHGBII MPMEGOKIEPF, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct DMCDKOBEHIJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct GOGHJCFIBAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public EKHKFFBCABL roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public CEBLHCJACGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x7507AE0", Offset = "0x7506EE0", VA = "0x187507AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7507CF0", Offset = "0x75070F0", VA = "0x187507CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class GANHPKEDIBJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public PMKGFNIFFEC<string>.INNANANOCLO timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public GANHPKEDIBJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x75163C0", Offset = "0x75157C0", VA = "0x1875163C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x7516750", Offset = "0x7515B50", VA = "0x187516750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GANHPKEDIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x7506300", Offset = "0x7505700", VA = "0x187506300")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task JCBJACEEBIP(PMKGFNIFFEC<string>.INNANANOCLO timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct ILBKCKADFAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public DMCDKOBEHIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter<OGJBCMINPFI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x750C5C0", Offset = "0x750B9C0", VA = "0x18750C5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x750CF90", Offset = "0x750C390", VA = "0x18750CF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class PNIIMDNDBKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public NHKMAHFIMNB version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PNIIMDNDBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x7514B20", Offset = "0x7513F20", VA = "0x187514B20")]
		internal object NDABGPIODDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x7514A70", Offset = "0x7513E70", VA = "0x187514A70")]
		internal object KFDBMJEKCIO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private PHNAGDHGBII MPMEGOKIEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private CEBLHCJACGB FNKEHJGDCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private bool BFNNJPCMKAA;

	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private static readonly ByteString AADPDKMECHG;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private EHLDCOMLOKA HEHDJMJINLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x7503B20", Offset = "0x7502F20", VA = "0x187503B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private KLDHFEKEHPL AELNFGOMKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x7503BB0", Offset = "0x7502FB0", VA = "0x187503BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x7503890", Offset = "0x7502C90", VA = "0x187503890")]
	[AsyncStateMachine(typeof(GOGHJCFIBAP))]
	public static Task EHNFAJDFHCN(EKHKFFBCABL NOGMIFBJMHC, PHNAGDHGBII MPMEGOKIEPF, CEBLHCJACGB FNKEHJGDCFD, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA, bool BFNNJPCMKAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x75039E0", Offset = "0x7502DE0", VA = "0x1875039E0")]
	[AsyncStateMachine(typeof(ILBKCKADFAF))]
	private Task EHNFAJDFHCN(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x7503210", Offset = "0x7502610", VA = "0x187503210")]
	private void BDIKIFAADEN([NotNull] GBHFJBFIHDK KKIHEEBCEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x7503B70", Offset = "0x7502F70", VA = "0x187503B70")]
	private bool JNMFEOCGHCL(NHKMAHFIMNB DMDALLEEEHI, GBHFJBFIHDK KKIHEEBCEIB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct CAMPBNMANDO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct AOANHHFNKLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public AsyncTaskMethodBuilder<PHNAGDHGBII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public CAMPBNMANDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public JGBNIGAIAMJ.KMIHOEJJGBM downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private PMKGFNIFFEC<string>.INNANANOCLO <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private TaskAwaiter<(MLIDCCDLMIE<DFGCDAECACO, IDBHBLPOJHF>, MLIDCCDLMIE<FGAAJMCNHCK<GBHFJBFIHDK>, IDBHBLPOJHF>, MLIDCCDLMIE<FGAAJMCNHCK<GIMIMNLPGGB>, IDBHBLPOJHF>, MLIDCCDLMIE<FGAAJMCNHCK<MMDKKMJKCJP>, IDBHBLPOJHF>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x74FE810", Offset = "0x74FDC10", VA = "0x1874FE810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x74FF2C0", Offset = "0x74FE6C0", VA = "0x1874FF2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct GMCMPANMEJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<DFGCDAECACO, IDBHBLPOJHF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public PMKGFNIFFEC<string>.INNANANOCLO downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public CAMPBNMANDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public JGBNIGAIAMJ.KMIHOEJJGBM downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter<MLIDCCDLMIE<DFGCDAECACO, IDBHBLPOJHF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x7506E30", Offset = "0x7506230", VA = "0x187506E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x7507440", Offset = "0x7506840", VA = "0x187507440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private HMIILMAMEIM<PNJFLFBCBJP, GIMIMNLPGGB> PJCLFBLHBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private HMIILMAMEIM<PNJFLFBCBJP, GBHFJBFIHDK> CNIINANCDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private HMIILMAMEIM<long, MMDKKMJKCJP> DKOKNCJGEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private HCDHHLCAOLO DIBLKLPHBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private JKIABJFEAHD ENDIDOEDCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private OCIJPHOBBHK EMKDJADMIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private string ABFNDBDJBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private PNJFLFBCBJP PFHICJBHJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private PNJFLFBCBJP FGBBGGCPMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private long PDOJDMECHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL;

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x75005C0", Offset = "0x74FF9C0", VA = "0x1875005C0")]
	public static Task<PHNAGDHGBII> KIFJCJCBOFA(EKHKFFBCABL NOGMIFBJMHC, [In] AFDNEPEKBNA MPMEGOKIEPF, JGBNIGAIAMJ.KMIHOEJJGBM DGCKOEAILPD, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x7500430", Offset = "0x74FF830", VA = "0x187500430")]
	[AsyncStateMachine(typeof(AOANHHFNKLN))]
	private Task<PHNAGDHGBII> EHNFAJDFHCN(JGBNIGAIAMJ.KMIHOEJJGBM DGCKOEAILPD, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x7500930", Offset = "0x74FFD30", VA = "0x187500930")]
	[AsyncStateMachine(typeof(GMCMPANMEJI))]
	private Task<MLIDCCDLMIE<DFGCDAECACO, IDBHBLPOJHF>> NNFCNLJPKOP(string ABFNDBDJBEH, long PDOJDMECHAM, long? HLGODMOGCOI, long? LBMLFGGHFGP, JGBNIGAIAMJ.KMIHOEJJGBM DGCKOEAILPD, PMKGFNIFFEC<string>.INNANANOCLO NNHBHNHCINI, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct FNBBMINHPNH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct EDBEPBEEEPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public AsyncTaskMethodBuilder<AFDNEPEKBNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public FNBBMINHPNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private PMKGFNIFFEC<string>.INNANANOCLO <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private TaskAwaiter<AFDNEPEKBNA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7503FC0", Offset = "0x75033C0", VA = "0x187503FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x75043D0", Offset = "0x75037D0", VA = "0x1875043D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct NEBJGECANLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AsyncTaskMethodBuilder<AFDNEPEKBNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public FNBBMINHPNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter<AFDNEPEKBNA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x7512200", Offset = "0x7511600", VA = "0x187512200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x7512630", Offset = "0x7511A30", VA = "0x187512630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class NJPENOBPHCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public NJPENOBPHCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6C0", Offset = "0x9DEAC0", VA = "0x1809DF6C0")]
		internal bool JHFKKLDCKMG(OCIJPHOBBHK sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct KJKKIMCFGCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder<AFDNEPEKBNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public PNJFLFBCBJP superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public EHLDCOMLOKA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private NJPENOBPHCN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public ICIFGLNNOMK roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private JKIABJFEAHD <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private OCIJPHOBBHK <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private PNJFLFBCBJP <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private PNJFLFBCBJP <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private TaskAwaiter<JKIABJFEAHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter<MAKKJAEMIAE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private TaskAwaiter<GAFBGJLGAKK> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x750E990", Offset = "0x750DD90", VA = "0x18750E990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x750FAE0", Offset = "0x750EEE0", VA = "0x18750FAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private EHLDCOMLOKA AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private NFPKNMPBOLJ DGBJOLGAOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private ICIFGLNNOMK HLAMNPFMDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private long HLGODMOGCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private long DPDHHEKEIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private long LBEABPMGLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private string HJDGGKDHLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private PNJFLFBCBJP GOIGAEIHECB;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x7506090", Offset = "0x7505490", VA = "0x187506090")]
	public static Task<AFDNEPEKBNA> KIFJCJCBOFA(EKHKFFBCABL NOGMIFBJMHC, DKKGGCCNPKP JHKMPCADNAF, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x7505C40", Offset = "0x7505040", VA = "0x187505C40")]
	[AsyncStateMachine(typeof(EDBEPBEEEPK))]
	private Task<AFDNEPEKBNA> EHNFAJDFHCN(CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x7505F30", Offset = "0x7505330", VA = "0x187505F30")]
	[AsyncStateMachine(typeof(NEBJGECANLI))]
	private Task<AFDNEPEKBNA> EICIDEOBGNP(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x7505D90", Offset = "0x7505190", VA = "0x187505D90")]
	[AsyncStateMachine(typeof(KJKKIMCFGCA))]
	private static Task<AFDNEPEKBNA> EICIDEOBGNP(EHLDCOMLOKA AJKICPHDFFF, ICIFGLNNOMK HLAMNPFMDCF, long HLGODMOGCOI, long DPDHHEKEIEF, long LBEABPMGLBN, string HJDGGKDHLAJ, PNJFLFBCBJP GOIGAEIHECB, CancellationToken EEHACKMODLA, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x7505C10", Offset = "0x7505010", VA = "0x187505C10")]
	private void AIINJBPHINC(JKIABJFEAHD ENDIDOEDCIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal struct GODKAGDBEAM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct LBHPLBMDNHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public GODKAGDBEAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x750FDE0", Offset = "0x750F1E0", VA = "0x18750FDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x7510370", Offset = "0x750F770", VA = "0x187510370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private EHLDCOMLOKA AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private PHNAGDHGBII MPMEGOKIEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private float EMFAHMAAEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private float FNEJLGOPFJF;

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x7507810", Offset = "0x7506C10", VA = "0x187507810")]
	public static Task HJMMOPDHHJK(EKHKFFBCABL NOGMIFBJMHC, PHNAGDHGBII MPMEGOKIEPF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x7507570", Offset = "0x7506970", VA = "0x187507570")]
	[AsyncStateMachine(typeof(LBHPLBMDNHG))]
	public Task EHNFAJDFHCN(CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x75079B0", Offset = "0x7506DB0", VA = "0x1875079B0")]
	private static void KPAJPABPAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x7507690", Offset = "0x7506A90", VA = "0x187507690")]
	private void FHOOIBELLIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x75074B0", Offset = "0x75068B0", VA = "0x1875074B0")]
	private static float EDBACALOJGE(EHLDCOMLOKA AJKICPHDFFF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x75077F0", Offset = "0x7506BF0", VA = "0x1875077F0")]
	private static float GDBCKOKPLFI()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct OPAFOCMGIAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct IBDNOGBPOAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CEBLHCJACGB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private ILAHKLFLONK <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private EKHKFFBCABL <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private CNPFEPKPNOA.MDMGLHKBPCI <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private TaskAwaiter<OGJBCMINPFI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x750B3C0", Offset = "0x750A7C0", VA = "0x18750B3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x750BBE0", Offset = "0x750AFE0", VA = "0x18750BBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct OHDCPEGIAOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x7512980", Offset = "0x7511D80", VA = "0x187512980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x7512CB0", Offset = "0x75120B0", VA = "0x187512CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x75132E0", Offset = "0x75126E0", VA = "0x1875132E0")]
	[AsyncStateMachine(typeof(IBDNOGBPOAN))]
	public static Task EHNFAJDFHCN(CEBLHCJACGB FNKEHJGDCFD, PHNAGDHGBII MPMEGOKIEPF, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x7513270", Offset = "0x7512670", VA = "0x187513270")]
	private static Task<OGJBCMINPFI> DCADODOMHMF(CEBLHCJACGB FNKEHJGDCFD, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x7513420", Offset = "0x7512820", VA = "0x187513420")]
	[AsyncStateMachine(typeof(OHDCPEGIAOB))]
	private static Task GIOJLFIHLAB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct LAOJJOJOOPK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct JFDOKPLEFKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public LAOJJOJOOPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x750D7F0", Offset = "0x750CBF0", VA = "0x18750D7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x750DEA0", Offset = "0x750D2A0", VA = "0x18750DEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class NABINCDBBFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public NABINCDBBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x7512180", Offset = "0x7511580", VA = "0x187512180")]
		internal object BMJDHOIKOPH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct PJGLFNJINBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public LAOJJOJOOPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x7513D30", Offset = "0x7513130", VA = "0x187513D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x75141B0", Offset = "0x75135B0", VA = "0x1875141B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	private bool DDEKJECMIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	private CancellationToken EEHACKMODLA;

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x750FC40", Offset = "0x750F040", VA = "0x18750FC40")]
	public static Task EIHIGEOODMF(EKHKFFBCABL NOGMIFBJMHC, bool DDEKJECMIFO, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken CGLIMBHHCON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x750FB50", Offset = "0x750EF50", VA = "0x18750FB50")]
	[AsyncStateMachine(typeof(JFDOKPLEFKJ))]
	private Task EHNFAJDFHCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x750FCB0", Offset = "0x750F0B0", VA = "0x18750FCB0")]
	[AsyncStateMachine(typeof(PJGLFNJINBF))]
	private Task IPKAMLFFAOO(bool GAPNJMHJJDP, string KLBNILGILEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0")]
	private bool GBOJKBKILIO(bool DDEKJECMIFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct MJPAHHONILD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct FJEOIAEEHFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public MJPAHHONILD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7505630", Offset = "0x7504A30", VA = "0x187505630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7505BA0", Offset = "0x7504FA0", VA = "0x187505BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class CPKDJJMIIKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public CPKDJJMIIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x7502C90", Offset = "0x7502090", VA = "0x187502C90")]
		internal object BMJDHOIKOPH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct OOBDNHFCPEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public MJPAHHONILD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x7512D80", Offset = "0x7512180", VA = "0x187512D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x7513200", Offset = "0x7512600", VA = "0x187513200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private LHBBFBHIOIF EMJLHDJHBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private bool NFIHCNFEBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private PHNAGDHGBII MPMEGOKIEPF;

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x7511B10", Offset = "0x7510F10", VA = "0x187511B10")]
	public static Task<Scene> MBPNHPGLEHO(EKHKFFBCABL NOGMIFBJMHC, LHBBFBHIOIF EECMLDIMCPJ, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x75118A0", Offset = "0x7510CA0", VA = "0x1875118A0")]
	[AsyncStateMachine(typeof(FJEOIAEEHFD))]
	private Task<Scene> EHNFAJDFHCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x7511870", Offset = "0x7510C70", VA = "0x187511870")]
	private bool CMMFGACOMDC(PHNAGDHGBII MPMEGOKIEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x7511800", Offset = "0x7510C00", VA = "0x187511800")]
	private void CCBDPECLKDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x75119C0", Offset = "0x7510DC0", VA = "0x1875119C0")]
	[AsyncStateMachine(typeof(OOBDNHFCPEJ))]
	private Task<Scene> IPKAMLFFAOO(string KLBNILGILEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct KGHDOLJLDCG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct LJNFCEBBNHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder<GMFHIOLLICC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public KGHDOLJLDCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public GMFHIOLLICC nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public PHNAGDHGBII deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private PMKGFNIFFEC<string>.INNANANOCLO <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private TaskAwaiter<GMFHIOLLICC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x75103D0", Offset = "0x750F7D0", VA = "0x1875103D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7510ED0", Offset = "0x75102D0", VA = "0x187510ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct HPKCJGKLEBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public AsyncTaskMethodBuilder<GMFHIOLLICC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public KGHDOLJLDCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public GMFHIOLLICC state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private TaskAwaiter<OGJBCMINPFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x750A980", Offset = "0x7509D80", VA = "0x18750A980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x750AC60", Offset = "0x750A060", VA = "0x18750AC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private readonly CEBLHCJACGB FNKEHJGDCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private readonly NFPKNMPBOLJ DGBJOLGAOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private readonly HKPIBPIMJBI LMIJKJCBGCM;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private ILAHKLFLONK DMAFCAFLCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA180", Offset = "0x5BE9580", VA = "0x185BEA180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x750E930", Offset = "0x750DD30", VA = "0x18750E930")]
	public KGHDOLJLDCG(CEBLHCJACGB FNKEHJGDCFD, NFPKNMPBOLJ DGBJOLGAOBH, HKPIBPIMJBI LMIJKJCBGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x750E600", Offset = "0x750DA00", VA = "0x18750E600")]
	[AsyncStateMachine(typeof(LJNFCEBBNHA))]
	public Task<GMFHIOLLICC> CECAEKFKLGC(GMFHIOLLICC NFEANEOBCMD, PHNAGDHGBII PDHBHCCJKNA, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA, bool JAFILIHNMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x750E7A0", Offset = "0x750DBA0", VA = "0x18750E7A0")]
	[AsyncStateMachine(typeof(HPKCJGKLEBA))]
	private Task<GMFHIOLLICC> LCJGHAMOCHO(PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, GMFHIOLLICC NOGEMBGGBHJ, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x750E900", Offset = "0x750DD00", VA = "0x18750E900")]
	private bool ODNLOKBCLED(GMFHIOLLICC DGELBEHGGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x750E780", Offset = "0x750DB80", VA = "0x18750E780")]
	private void KGPNCCLAFMC(string KHAFJMFBNIC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct AHHEDKEFNPI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct IGDBIGGFPNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public ILAHKLFLONK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public FACBMFKENMF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private DMBBNIDMCGE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private List<(PersistenceView, FGFJJKFMCDJ)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private (PersistenceView, FGFJJKFMCDJ) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x750BC40", Offset = "0x750B040", VA = "0x18750BC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x750C290", Offset = "0x750B690", VA = "0x18750C290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x74FD580", Offset = "0x74FC980", VA = "0x1874FD580")]
	[AsyncStateMachine(typeof(IGDBIGGFPNC))]
	public static Task EHNFAJDFHCN(ILAHKLFLONK KFMKOKFLOBK, PHNAGDHGBII MPMEGOKIEPF, FACBMFKENMF JPAHENONEFM, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct EONDLDIHEFF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct ENNMOGEGNHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public ILAHKLFLONK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public FACBMFKENMF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private NHKMAHFIMNB <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private DMBBNIDMCGE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private List<(PersistenceView, FGFJJKFMCDJ)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private FGFJJKFMCDJ <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x7504570", Offset = "0x7503970", VA = "0x187504570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7504E20", Offset = "0x7504220", VA = "0x187504E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x7504E80", Offset = "0x7504280", VA = "0x187504E80")]
	[AsyncStateMachine(typeof(ENNMOGEGNHI))]
	public static Task EHNFAJDFHCN(ILAHKLFLONK KFMKOKFLOBK, PHNAGDHGBII MPMEGOKIEPF, FACBMFKENMF JPAHENONEFM, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct CNPFEPKPNOA
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public struct MDMGLHKBPCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public List<CLNPNHAKDGO> JGPKCIIGGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public List<FGFJJKFMCDJ> ENPLJEJJOOD;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xDCF0A0", Offset = "0xDCE4A0", VA = "0x180DCF0A0")]
		public MDMGLHKBPCI(List<CLNPNHAKDGO> JGPKCIIGGGG, List<FGFJJKFMCDJ> ENPLJEJJOOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class EGDIIPCHLKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public IEnumerable<CLNPNHAKDGO> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public EGDIIPCHLKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x7504440", Offset = "0x7503840", VA = "0x187504440")]
		internal object AAPLOJBJAGH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private EKHKFFBCABL NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000600")]
	private PHNAGDHGBII MPMEGOKIEPF;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private EHLDCOMLOKA HEHDJMJINLD
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7502830", Offset = "0x7501C30", VA = "0x187502830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x7502580", Offset = "0x7501980", VA = "0x187502580")]
	public static MDMGLHKBPCI EHNFAJDFHCN(EKHKFFBCABL NOGMIFBJMHC, PHNAGDHGBII MPMEGOKIEPF)
	{
		return default(MDMGLHKBPCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x75025E0", Offset = "0x75019E0", VA = "0x1875025E0")]
	private MDMGLHKBPCI EHNFAJDFHCN()
	{
		return default(MDMGLHKBPCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x7501FD0", Offset = "0x75013D0", VA = "0x187501FD0")]
	private MDMGLHKBPCI APJNKADAHMP(GBHFJBFIHDK KKIHEEBCEIB, NHKMAHFIMNB JJIMCHIAKMB)
	{
		return default(MDMGLHKBPCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x7501E00", Offset = "0x7501200", VA = "0x187501E00")]
	private bool AIBAPGFFICJ(IEnumerable<CLNPNHAKDGO> JGPKCIIGGGG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct PNOPJJNHDMM
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class EGIIPJFBBLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public CNPFEPKPNOA.MDMGLHKBPCI instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public EGIIPJFBBLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x75044C0", Offset = "0x75038C0", VA = "0x1875044C0")]
		internal object JCBJACEEBIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class CKOMIHJOLDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public CKOMIHJOLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7501C20", Offset = "0x7501020", VA = "0x187501C20")]
		internal object GFKFEBMJGHN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x7514C00", Offset = "0x7514000", VA = "0x187514C00")]
	public static void EHNFAJDFHCN(ILAHKLFLONK KFMKOKFLOBK, PHNAGDHGBII MPMEGOKIEPF, CNPFEPKPNOA.MDMGLHKBPCI FJKPOAJOGCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal class HKPIBPIMJBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct CANJEGFODLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public HKPIBPIMJBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public GMFHIOLLICC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public PHNAGDHGBII deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x7500AF0", Offset = "0x74FFEF0", VA = "0x187500AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x7501260", Offset = "0x7500660", VA = "0x187501260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class BNDDEPBLHOA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000615")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			public BNDDEPBLHOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x75160A0", Offset = "0x75154A0", VA = "0x1875160A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x7516360", Offset = "0x7515760", VA = "0x187516360", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public HKPIBPIMJBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public PMKGFNIFFEC<string>.INNANANOCLO handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public BNDDEPBLHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x7500340", Offset = "0x74FF740", VA = "0x187500340")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task EBFOBFBGBAD(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct INBEDAKOAIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public HKPIBPIMJBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private BNDDEPBLHOA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x750CFF0", Offset = "0x750C3F0", VA = "0x18750CFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x750D520", Offset = "0x750C920", VA = "0x18750D520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct CIOBADNHLOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public HKPIBPIMJBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private Dictionary<Guid, List<KOGFLKINEFL>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x75015B0", Offset = "0x75009B0", VA = "0x1875015B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x7501BC0", Offset = "0x7500FC0", VA = "0x187501BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct JPGKNNBFLJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public HKPIBPIMJBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private Dictionary<Guid, List<KOGFLKINEFL>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x750DF00", Offset = "0x750D300", VA = "0x18750DF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x750E5A0", Offset = "0x750D9A0", VA = "0x18750E5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class IIDKNIDNKBI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000173")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			public KOGFLKINEFL handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			public IIDKNIDNKBI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x7515EA0", Offset = "0x75152A0", VA = "0x187515EA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x7516040", Offset = "0x7515440", VA = "0x187516040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public DPGGBDDGALD runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public List<KOGFLKINEFL> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public IIDKNIDNKBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x750C3E0", Offset = "0x750B7E0", VA = "0x18750C3E0")]
		internal object FNCECKOKPIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x750C2F0", Offset = "0x750B6F0", VA = "0x18750C2F0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task EPOJMOGOMKP(KOGFLKINEFL handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x750C4D0", Offset = "0x750B8D0", VA = "0x18750C4D0")]
		internal object MEEGDMKAPJE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct DFLKOEAPIED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public DPGGBDDGALD runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public List<KOGFLKINEFL> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private IIDKNIDNKBI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x7502CE0", Offset = "0x75020E0", VA = "0x187502CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x75031B0", Offset = "0x75025B0", VA = "0x1875031B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct FFLHGPFAEGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public HKPIBPIMJBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public PMKGFNIFFEC<string>.INNANANOCLO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7505010", Offset = "0x7504410", VA = "0x187505010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x75055D0", Offset = "0x75049D0", VA = "0x1875055D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class GBBFMKAILFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GBBFMKAILFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x7506420", Offset = "0x7505820", VA = "0x187506420")]
		internal object KBLHOBGCGGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct PKIJONOJIBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public HKPIBPIMJBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public PHNAGDHGBII data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x7514210", Offset = "0x7513610", VA = "0x187514210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x75146D0", Offset = "0x7513AD0", VA = "0x1875146D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class ADOMNMCDJPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public ADOMNMCDJPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x74FD510", Offset = "0x74FC910", VA = "0x1874FD510")]
		internal object LPOFHHECFLP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct HDMHIJAEABB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public HKPIBPIMJBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private TaskAwaiter<OGJBCMINPFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x7508450", Offset = "0x7507850", VA = "0x187508450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x7508A80", Offset = "0x7507E80", VA = "0x187508A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class HJJBGALHBLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HJJBGALHBLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x7509650", Offset = "0x7508A50", VA = "0x187509650")]
		internal object MDBPAGFKMIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private readonly CEBLHCJACGB FNKEHJGDCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private HLBBFGDNFBE LMIJKJCBGCM;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private ILAHKLFLONK DMAFCAFLCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xC0CA80", Offset = "0xC0BE80", VA = "0x180C0CA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	public HKPIBPIMJBI(CEBLHCJACGB FNKEHJGDCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x7509800", Offset = "0x7508C00", VA = "0x187509800")]
	[AsyncStateMachine(typeof(CANJEGFODLA))]
	public Task EHNFAJDFHCN(GMFHIOLLICC GBEKHIEOIMF, PHNAGDHGBII PDHBHCCJKNA, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x7509950", Offset = "0x7508D50", VA = "0x187509950")]
	[AsyncStateMachine(typeof(INBEDAKOAIH))]
	private Task FDBKKLGJDAP(PHNAGDHGBII MPMEGOKIEPF, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x7509CE0", Offset = "0x75090E0", VA = "0x187509CE0")]
	[AsyncStateMachine(typeof(CIOBADNHLOG))]
	private Task KNEJDBCJJFH(PHNAGDHGBII MPMEGOKIEPF, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x7509E20", Offset = "0x7509220", VA = "0x187509E20")]
	[AsyncStateMachine(typeof(JPGKNNBFLJO))]
	private Task LNJOGLFCCPC(PHNAGDHGBII MPMEGOKIEPF, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x750A130", Offset = "0x7509530", VA = "0x18750A130")]
	[AsyncStateMachine(typeof(DFLKOEAPIED))]
	private Task MIGJDHIBPGH(Guid EBDNEOCEPJD, List<KOGFLKINEFL> LKFAKHMEBAP, DPGGBDDGALD HGFBEANICJL, PHNAGDHGBII MPMEGOKIEPF, CancellationToken FDAIGOGAKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x750A4C0", Offset = "0x75098C0", VA = "0x18750A4C0")]
	[AsyncStateMachine(typeof(FFLHGPFAEGL))]
	private Task PLBHJIGGBEB(PHNAGDHGBII MPMEGOKIEPF, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x7509BA0", Offset = "0x7508FA0", VA = "0x187509BA0")]
	[AsyncStateMachine(typeof(PKIJONOJIBE))]
	private Task HGPKNBLAHLP(Guid LILBDAJGBMI, PHNAGDHGBII MPMEGOKIEPF, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x75096C0", Offset = "0x7508AC0", VA = "0x1875096C0")]
	[AsyncStateMachine(typeof(HDMHIJAEABB))]
	private Task BPGCLJKHPPM(Guid LILBDAJGBMI, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x7509A90", Offset = "0x7508E90", VA = "0x187509A90")]
	private void GPNDDGEHMOP(Guid LILBDAJGBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x750A280", Offset = "0x7509680", VA = "0x18750A280")]
	private void OLHEBPGBBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x750A330", Offset = "0x7509730", VA = "0x18750A330")]
	public Guid PBPNJNMFBBA(GMFHIOLLICC HDDANEACAIB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x7509F60", Offset = "0x7509360", VA = "0x187509F60")]
	[CompilerGenerated]
	private object MFNOMFKPHID()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct MMCLNDPJGKI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct HAEBODFEIMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public MMCLNDPJGKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private PMKGFNIFFEC<string>.INNANANOCLO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private IEnumerator<HGNNFKMNJBJ> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x7507D50", Offset = "0x7507150", VA = "0x187507D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x75083F0", Offset = "0x75077F0", VA = "0x1875083F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private EHLDCOMLOKA AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private CancellationToken EEHACKMODLA;

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x7511C80", Offset = "0x7511080", VA = "0x187511C80")]
	public static Task OBCELIKPHGH(EHLDCOMLOKA AJKICPHDFFF, PMKGFNIFFEC<string>.INNANANOCLO GBIEPJHIGOL, CancellationToken CGLIMBHHCON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x7511B90", Offset = "0x7510F90", VA = "0x187511B90")]
	[AsyncStateMachine(typeof(HAEBODFEIMI))]
	private Task EHNFAJDFHCN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct IODGLGMPJNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	public readonly bool LLPBCBFMKOE;

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x23EC4C0", Offset = "0x23EB8C0", VA = "0x1823EC4C0")]
	public IODGLGMPJNA(bool IAEDHGHEKDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public readonly struct IOMOLFGHOOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	public readonly GBHFJBFIHDK? OGDDDGBECKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	public readonly GPKGCOMPHAG FOGNEFLJLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	public readonly string? FICFCOFOCPM;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public IReadOnlyCollection<string> FNJJPDKOOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x750D580", Offset = "0x750C980", VA = "0x18750D580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IReadOnlyDictionary<long, int> GEGOGDNGBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x750D5A0", Offset = "0x750C9A0", VA = "0x18750D5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x750D5C0", Offset = "0x750C9C0", VA = "0x18750D5C0")]
	public IOMOLFGHOOF(GBHFJBFIHDK? CAAMOPOAIJO, GPKGCOMPHAG OGPKPMOKHNK, string? ABFNDBDJBEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class ALHMLJMHEAB : DAGDBOHNCLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct IAAJGGKLEEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder<IOMOLFGHOOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public ALHMLJMHEAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public GEAJINJHAGD serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public IHFJLNHDCBG roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private DMBBNIDMCGE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x750ACD0", Offset = "0x750A0D0", VA = "0x18750ACD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x750B350", Offset = "0x750A750", VA = "0x18750B350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class CIAIFEJHGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public GEAJINJHAGD serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public ALHMLJMHEAB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public CIAIFEJHGNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x75013A0", Offset = "0x75007A0", VA = "0x1875013A0")]
		internal Task IPBLNAEPAJO(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x75012C0", Offset = "0x75006C0", VA = "0x1875012C0")]
		internal Task EJLNGCHOFFN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class OMGBBPEADPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public CIAIFEJHGNK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public OMGBBPEADPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x7512D10", Offset = "0x7512110", VA = "0x187512D10")]
		internal object DHLMFBEGEMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class BJNGPNMJFMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public CIAIFEJHGNK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public BJNGPNMJFMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x74FFFC0", Offset = "0x74FF3C0", VA = "0x1874FFFC0")]
		internal Task KJNBLOCINMF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct GEKIPCHDGFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public GEAJINJHAGD serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public ALHMLJMHEAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private OMGBBPEADPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private DMBBNIDMCGE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x7506570", Offset = "0x7505970", VA = "0x187506570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x7506DD0", Offset = "0x75061D0", VA = "0x187506DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private static readonly TimeSpan AIDNDCEDOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly OBHAFDAADKP PIGPHOGFFDD;

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x74FE7C0", Offset = "0x74FDBC0", VA = "0x1874FE7C0")]
	public ALHMLJMHEAB(CEBLHCJACGB FNKEHJGDCFD, OBHAFDAADKP PIGPHOGFFDD, EGGMDNJPOBA DFDLACHAHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x74FE5F0", Offset = "0x74FD9F0", VA = "0x1874FE5F0")]
	[AsyncStateMachine(typeof(IAAJGGKLEEF))]
	public Task<IOMOLFGHOOF> KEEAKGCJIOB(long DPDHHEKEIEF, IHFJLNHDCBG DFFPHKBABGI, GEAJINJHAGD FECDMFCELGL, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x74FDDA0", Offset = "0x74FD1A0", VA = "0x1874FDDA0")]
	[AsyncStateMachine(typeof(GEKIPCHDGFC))]
	private Task DLAHKBJMIJG(GEAJINJHAGD FECDMFCELGL, IEnumerable<PersistenceView> AMOIAJMCMFF, StringBuilder HGPPMODLLFE, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x74FDEE0", Offset = "0x74FD2E0", VA = "0x1874FDEE0")]
	private IOMOLFGHOOF EBBFECJINCA(long DPDHHEKEIEF, IHFJLNHDCBG DFFPHKBABGI, GEAJINJHAGD FECDMFCELGL, IEnumerable<PersistenceView> AMOIAJMCMFF, StringBuilder HGPPMODLLFE)
	{
		return default(IOMOLFGHOOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x74FE4A0", Offset = "0x74FD8A0", VA = "0x1874FE4A0")]
	private GBHFJBFIHDK GHBMCJDHELD(long DPDHHEKEIEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x74FDB50", Offset = "0x74FCF50", VA = "0x1874FDB50")]
	private void BKHODJDFCAJ(GBHFJBFIHDK PCDOFDHACEA, StringBuilder HGPPMODLLFE, IEnumerable<PersistenceView> AMOIAJMCMFF, [In] OBEEEAOBNEH IHLGGICNOOB, HANOONHMDKF OENLMJDIFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x74FD6C0", Offset = "0x74FCAC0", VA = "0x1874FD6C0")]
	private void ADCPNIAJJIP(GBHFJBFIHDK PCDOFDHACEA, StringBuilder HGPPMODLLFE, PersistenceView DOKLPJEMEAH, HANOONHMDKF OENLMJDIFGC, [In] OBEEEAOBNEH IHLGGICNOOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal class HGJKNFDCLAH : DAGDBOHNCLI
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class FAAODPHKGKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public LBGJIEJHAJH.CIGONCEALPB roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public FAAODPHKGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x7504FC0", Offset = "0x75043C0", VA = "0x187504FC0")]
		internal object PGGHGPEBLGL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct LOJAJMIBALF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public AsyncTaskMethodBuilder<(LBGJIEJHAJH.CIGONCEALPB roomDataUpload, LBGJIEJHAJH.CIGONCEALPB subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public IOMOLFGHOOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public HGJKNFDCLAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private FAAODPHKGKE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private TaskAwaiter<LBGJIEJHAJH.CIGONCEALPB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x7510F40", Offset = "0x7510340", VA = "0x187510F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x7511790", Offset = "0x7510B90", VA = "0x187511790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct APCKAAPFHCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public AsyncTaskMethodBuilder<DEDLCGKHLHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public HGJKNFDCLAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public IOMOLFGHOOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public PKOOPKBNGEK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private TaskAwaiter<(LBGJIEJHAJH.CIGONCEALPB roomDataUpload, LBGJIEJHAJH.CIGONCEALPB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private TaskAwaiter<DEDLCGKHLHK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x74FF330", Offset = "0x74FE730", VA = "0x1874FF330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x74FF9C0", Offset = "0x74FEDC0", VA = "0x1874FF9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private struct PABKFHOJBAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public AsyncTaskMethodBuilder<MAKKJAEMIAE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public HGJKNFDCLAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public IOMOLFGHOOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private TaskAwaiter<(LBGJIEJHAJH.CIGONCEALPB roomDataUpload, LBGJIEJHAJH.CIGONCEALPB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private TaskAwaiter<MAKKJAEMIAE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x75134E0", Offset = "0x75128E0", VA = "0x1875134E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x75138F0", Offset = "0x7512CF0", VA = "0x1875138F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class JDLEOMJJHEO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			public AsyncTaskMethodBuilder<OGJBCMINPFI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			public JDLEOMJJHEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			private OGJBCMINPFI <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			private TaskAwaiter<MAKKJAEMIAE> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			private TaskAwaiter<DEDLCGKHLHK> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			private TaskAwaiter<OGJBCMINPFI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x75167B0", Offset = "0x7515BB0", VA = "0x1875167B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x7517730", Offset = "0x7516B30", VA = "0x187517730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public HGJKNFDCLAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public IOMOLFGHOOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public PKOOPKBNGEK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public IODGLGMPJNA roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public JDLEOMJJHEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x750D6C0", Offset = "0x750CAC0", VA = "0x18750D6C0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<OGJBCMINPFI> LMKLBGGACKB(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct HOGGAHCCDCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public AsyncTaskMethodBuilder<OGJBCMINPFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public HGJKNFDCLAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public IOMOLFGHOOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public PKOOPKBNGEK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public IODGLGMPJNA roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public PMKGFNIFFEC<string>.INNANANOCLO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private TaskAwaiter<OGJBCMINPFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x750A600", Offset = "0x7509A00", VA = "0x18750A600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x750A910", Offset = "0x7509D10", VA = "0x18750A910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private static readonly EGGMDNJPOBA JMOKMPLIJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private readonly BNINCIEKNLD OLIFPFEKIHO;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private EKHKFFBCABL HOIGEHNFAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x74EE0D0", Offset = "0x74ED4D0", VA = "0x1874EE0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x7509130", Offset = "0x7508530", VA = "0x187509130")]
	public HGJKNFDCLAH(CEBLHCJACGB FNKEHJGDCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x7508AE0", Offset = "0x7507EE0", VA = "0x187508AE0")]
	[AsyncStateMachine(typeof(LOJAJMIBALF))]
	private Task<(LBGJIEJHAJH.CIGONCEALPB, LBGJIEJHAJH.CIGONCEALPB)> AECMDGDLDBA(IOMOLFGHOOF IDDBGNNFLGM, long HLGODMOGCOI, long LBMLFGGHFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x7508F30", Offset = "0x7508330", VA = "0x187508F30")]
	[AsyncStateMachine(typeof(APCKAAPFHCK))]
	public Task<DEDLCGKHLHK> IAIMPOCAJEI(int JGOGDPEFFEP, [CanBeNull] PKOOPKBNGEK HJOEHEMELJN, IOMOLFGHOOF IDDBGNNFLGM, long HLGODMOGCOI, long LBMLFGGHFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x7508DC0", Offset = "0x75081C0", VA = "0x187508DC0")]
	[AsyncStateMachine(typeof(PABKFHOJBAC))]
	private Task<MAKKJAEMIAE> FOBKGGLBPNL(string HJDGGKDHLAJ, int JGOGDPEFFEP, IOMOLFGHOOF IDDBGNNFLGM, long HLGODMOGCOI, long LBMLFGGHFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x7508C20", Offset = "0x7508020", VA = "0x187508C20")]
	[AsyncStateMachine(typeof(HOGGAHCCDCM))]
	public Task<OGJBCMINPFI> FKKPDLLCFHG(int JGOGDPEFFEP, PKOOPKBNGEK? HJOEHEMELJN, IOMOLFGHOOF IDDBGNNFLGM, long HLGODMOGCOI, long LBMLFGGHFGP, IODGLGMPJNA PAHOJBAFDIC, PMKGFNIFFEC<string>.INNANANOCLO LFJPEOONMIE, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public abstract class OLANOJDBDJH<T> where T : OLANOJDBDJH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	internal readonly EKHKFFBCABL BGJILJDJEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private int? NJACHBEBNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	protected readonly Guid OEDMAJDGCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	protected readonly DJFIDPMCMOO NCNOBJEOIAB;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	protected T IEPKGBBBKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x4AA4DF0", Offset = "0x4AA41F0", VA = "0x184AA4DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x4AA4EF0", Offset = "0x4AA42F0", VA = "0x184AA4EF0")]
	internal OLANOJDBDJH(EKHKFFBCABL OHCIBBNMNDM, DJFIDPMCMOO FCAFNCBGOFF, [Optional] Guid? NJALKLIOMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x4AA4B30", Offset = "0x4AA3F30", VA = "0x184AA4B30")]
	private OGJBCMINPFI CPOFCPBMAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "4")]
	protected virtual void DNBCLJKLLMD(OGJBCMINPFI ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x4AA4E50", Offset = "0x4AA4250", VA = "0x184AA4E50")]
	public T OBNJPBBKNJL(NGDBFKPHNOF NMLJOPBBABK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x4AA4D40", Offset = "0x4AA4140", VA = "0x184AA4D40")]
	public T KDHAJHHNIIB(int LBDDBKEJGLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x4AA4C10", Offset = "0x4AA4010", VA = "0x184AA4C10", Slot = "5")]
	public virtual Task<CEFINKDJEPJ> JHOGAGKCIPG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class DNBBCIDJOCM : OLANOJDBDJH<DNBBCIDJOCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private DKKGGCCNPKP NNNHDMLPIGD;

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x7503DB0", Offset = "0x75031B0", VA = "0x187503DB0")]
	internal DNBBCIDJOCM(EKHKFFBCABL OHCIBBNMNDM, DJFIDPMCMOO FCAFNCBGOFF, [Optional] Guid? NJALKLIOMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x69E2BE0", Offset = "0x69E1FE0", VA = "0x1869E2BE0")]
	public DNBBCIDJOCM LJGFPLLHJOG(DKKGGCCNPKP NNNHDMLPIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x7503CE0", Offset = "0x75030E0", VA = "0x187503CE0", Slot = "4")]
	protected override void DNBCLJKLLMD(OGJBCMINPFI ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public class MONMCGNKION : OLANOJDBDJH<MONMCGNKION>
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	internal enum DNEKJLADEPD
	{
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct CPCMFLAKNIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public AsyncTaskMethodBuilder<CEFINKDJEPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public MONMCGNKION <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private TaskAwaiter<CEFINKDJEPJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x7502880", Offset = "0x7501C80", VA = "0x187502880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x7502C20", Offset = "0x7502020", VA = "0x187502C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private DNEKJLADEPD LBLKJMGHBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private string PCAJOHOOBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private PKOOPKBNGEK NNNHDMLPIGD;

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x7512010", Offset = "0x7511410", VA = "0x187512010")]
	internal MONMCGNKION(EKHKFFBCABL OHCIBBNMNDM, DJFIDPMCMOO FCAFNCBGOFF, [Optional] Guid? NJALKLIOMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x7511FE0", Offset = "0x75113E0", VA = "0x187511FE0")]
	public MONMCGNKION NADDOCBINII(string KCBLOILGJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x7511FC0", Offset = "0x75113C0", VA = "0x187511FC0")]
	public MONMCGNKION MMLCPFMOCEE(bool ODCCLDGLGMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x7511CF0", Offset = "0x75110F0", VA = "0x187511CF0")]
	public MONMCGNKION BNOBGOJBILE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x7511D60", Offset = "0x7511160", VA = "0x187511D60", Slot = "4")]
	protected override void DNBCLJKLLMD(OGJBCMINPFI ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x7511ED0", Offset = "0x75112D0", VA = "0x187511ED0", Slot = "5")]
	[AsyncStateMachine(typeof(CPCMFLAKNIM))]
	public override Task<CEFINKDJEPJ> JHOGAGKCIPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x7511D20", Offset = "0x7511120", VA = "0x187511D20")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<CEFINKDJEPJ> CBIBIBIPJBA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal static class NGNDLOCAOEO
{
	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x7512720", Offset = "0x7511B20", VA = "0x187512720")]
	public static void MPJBMJJHIEL(this DNKNIBGJGBA EKABPCJDPCM, GAGHJCEIHCL FBCJPMKMIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x75126A0", Offset = "0x7511AA0", VA = "0x1875126A0")]
	public static void DGHKMCOKLHH(this GAGHJCEIHCL NGFGPIIAAKC, [Optional] string ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public static class CMFJBFCFDBI
{
	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x7501CB0", Offset = "0x75010B0", VA = "0x187501CB0")]
	public static PNJFLFBCBJP KFNLIAHKKAL(this IONGKIGPAJD NAPDJHIHMHH)
	{
		return default(PNJFLFBCBJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x7501D50", Offset = "0x7501150", VA = "0x187501D50")]
	public static IONGKIGPAJD OPHCCOOGKDH(this PNJFLFBCBJP HFLPDJLBKIB)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000197")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			public DGPFKMCAMJI ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public DGPFKMCAMJI HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private static DGPFKMCAMJI[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private Dictionary<DGPFKMCAMJI, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x75184D0", Offset = "0x75178D0", VA = "0x1875184D0")]
		public bool POLDMCHCCFA(DGPFKMCAMJI AKMENNDFILA, [Out] ResultConfig IBOPOOBMBOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x7517C80", Offset = "0x7517080", VA = "0x187517C80")]
		public ResultConfig IEPEBFICAGJ(DGPFKMCAMJI POKPBEJPBMH, [Optional] HashSet<DGPFKMCAMJI> BHFGMGMAAFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x75182F0", Offset = "0x75176F0", VA = "0x1875182F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x7517DC0", Offset = "0x75171C0", VA = "0x187517DC0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xA79810", Offset = "0xA78C10", VA = "0x180A79810")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class PHEKPFNBIEF : GBMONCCFIHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct OGGEPHGLBLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public PHEKPFNBIEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public PMKGFNIFFEC<string>.INNANANOCLO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x751D1A0", Offset = "0x751C5A0", VA = "0x18751D1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x751D330", Offset = "0x751C730", VA = "0x18751D330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct DBLNAEDHBIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public PMKGFNIFFEC<string>.INNANANOCLO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public GBMONCCFIHJ preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private PMKGFNIFFEC<string>.INNANANOCLO <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x7518A00", Offset = "0x7517E00", VA = "0x187518A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x7518F20", Offset = "0x7518320", VA = "0x187518F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private readonly MKJGMMLPAFB APMIALIDJIF;

	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public string BCBCFBOMCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x7513960", Offset = "0x7512D60", VA = "0x187513960", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x7513BC0", Offset = "0x7512FC0", VA = "0x187513BC0")]
	[FHFMOACGLML.PCGBCKINAAE.IIGHLHFDGPC]
	internal static void PGACNHLPKNC(ACFNHMKNHLL IFIBOOJGEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PHEKPFNBIEF([ACGOIOBGIEE(null)] MKJGMMLPAFB APMIALIDJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x7513990", Offset = "0x7512D90", VA = "0x187513990", Slot = "5")]
	[AsyncStateMachine(typeof(OGGEPHGLBLK))]
	public Task EHNFAJDFHCN(PMKGFNIFFEC<string>.INNANANOCLO ALKAKFCLFJO, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x7513AA0", Offset = "0x7512EA0", VA = "0x187513AA0")]
	[AsyncStateMachine(typeof(DBLNAEDHBIL))]
	private Task FPIHNNGPDIJ(GBMONCCFIHJ LGHIJIABLOB, PMKGFNIFFEC<string>.INNANANOCLO ALKAKFCLFJO, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public interface MKJGMMLPAFB : GBMONCCFIHJ
{
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public interface GBMONCCFIHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string BCBCFBOMCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EHNFAJDFHCN(PMKGFNIFFEC<string>.INNANANOCLO ALKAKFCLFJO, CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public static class DHHGEMJOKGP
{
	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x7518F80", Offset = "0x7518380", VA = "0x187518F80")]
	[FHFMOACGLML.PCGBCKINAAE.IIGHLHFDGPC]
	internal static void EJGLCCJGHFF(ACFNHMKNHLL IFIBOOJGEPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public interface GDMCCAIBAAO : IEquatable<GDMCCAIBAAO>
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	DateTime BCCIDCNACDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FODEFNIGOJN();

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CAONKLDBNIK(long HLGODMOGCOI, long DPDHHEKEIEF, [Out] IOMOLFGHOOF IDDBGNNFLGM);
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class KLJCNEIGBOB : EPPKPIPMEHD
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class NJLOEBPOAAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public HFDEDFLKCBL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public NJLOEBPOAAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x751B8F0", Offset = "0x751ACF0", VA = "0x18751B8F0")]
		internal object HHEJLAFPMEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	private readonly LHNNFHLAALM LCFDCJNLFIF;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<GDMCCAIBAAO> GNPANLAEOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x751AD50", Offset = "0x751A150", VA = "0x18751AD50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x751B200", Offset = "0x751A600", VA = "0x18751B200", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	[UnityEngine.Scripting.Preserve]
	public KLJCNEIGBOB([ACGOIOBGIEE(null)] LHNNFHLAALM LCFDCJNLFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x751AF20", Offset = "0x751A320", VA = "0x18751AF20", Slot = "6")]
	public bool CNCKEAIIJFB(long HLGODMOGCOI, long DPDHHEKEIEF, IOMOLFGHOOF IDDBGNNFLGM, HFDEDFLKCBL DODPONFKEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x9669C0", Offset = "0x965DC0", VA = "0x1809669C0")]
	private void KNKDHMNGMGA(GDMCCAIBAAO ALHPIJFCLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x751B360", Offset = "0x751A760", VA = "0x18751B360", Slot = "7")]
	public bool KOMJJHCDJBM(long HLGODMOGCOI, long DPDHHEKEIEF, [Out] GDMCCAIBAAO CMKALAGCPMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x751B2B0", Offset = "0x751A6B0", VA = "0x18751B2B0", Slot = "8")]
	public bool FIOBBIIJHGI(long HLGODMOGCOI, long DPDHHEKEIEF, HFDEDFLKCBL DODPONFKEMI, [Out] GDMCCAIBAAO CMKALAGCPMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x751B4D0", Offset = "0x751A8D0", VA = "0x18751B4D0")]
	private void PPCCACACKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x751AE00", Offset = "0x751A200", VA = "0x18751AE00", Slot = "9")]
	public void CMFPGHFECIO(long HLGODMOGCOI, long DPDHHEKEIEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal abstract class PIEOFAFEAFO : LHNNFHLAALM
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	protected enum GGDPLEGEDGB : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class GNNJBOGNEEO : IEnumerable<GDMCCAIBAAO>, IEnumerable, IEnumerator<GDMCCAIBAAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private GDMCCAIBAAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public PIEOFAFEAFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private HFDEDFLKCBL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public HFDEDFLKCBL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private GDMCCAIBAAO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
		[DebuggerHidden]
		public GNNJBOGNEEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x7519A30", Offset = "0x7518E30", VA = "0x187519A30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x7519D10", Offset = "0x7519110", VA = "0x187519D10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x7519C60", Offset = "0x7519060", VA = "0x187519C60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GDMCCAIBAAO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x7519C60", Offset = "0x7519060", VA = "0x187519C60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class DNFHHLMOCDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public HFDEDFLKCBL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public DNFHHLMOCDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x7519390", Offset = "0x7518790", VA = "0x187519390")]
		internal object HHPMDAJCPKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class NPCAOPGCMIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public PIEOFAFEAFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public NPCAOPGCMIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x751B960", Offset = "0x751AD60", VA = "0x18751B960")]
		internal void GCFPFMAKABK(EONNEMECKLI.EHHKANKAHKP ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private readonly object ANACFMEJGLN;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	protected string ABFNKCGFEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x751D580", Offset = "0x751C980", VA = "0x18751D580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public abstract FCOLAPJFJCL OJPHPJGIGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x751DDB0", Offset = "0x751D1B0", VA = "0x18751DDB0")]
	protected PIEOFAFEAFO([CanBeNull] string PNGBDAODENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x751D390", Offset = "0x751C790", VA = "0x18751D390", Slot = "5")]
	public bool DGMMANBBCBH(long HLGODMOGCOI, long DPDHHEKEIEF, HFDEDFLKCBL DODPONFKEMI, [Out] GDMCCAIBAAO ALHPIJFCLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x751D590", Offset = "0x751C990", VA = "0x18751D590", Slot = "6")]
	[IteratorStateMachine(typeof(GNNJBOGNEEO))]
	public IEnumerable<GDMCCAIBAAO> LGNKNJMHKML(HFDEDFLKCBL DODPONFKEMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void KFNKEHBEGLF(Stream HKCPEKJJNPG, long HLGODMOGCOI, long DPDHHEKEIEF, IOMOLFGHOOF IDDBGNNFLGM);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool AMDKNDGAMMK(Stream NMMBEBHHGMC, long HLGODMOGCOI, long DPDHHEKEIEF, FLCGDBECPIG KOEHACGPBMC, [Out] IOMOLFGHOOF IDDBGNNFLGM);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x751DA40", Offset = "0x751CE40", VA = "0x18751DA40", Slot = "7")]
	public GDMCCAIBAAO PHDEJECKJCC(long HLGODMOGCOI, long DPDHHEKEIEF, IOMOLFGHOOF IDDBGNNFLGM, HFDEDFLKCBL DODPONFKEMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo CKHCPFFLHJP(long HLGODMOGCOI, long DPDHHEKEIEF, HFDEDFLKCBL DODPONFKEMI, GGDPLEGEDGB JBACLIGCJMA);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo FOFGPNJFOLK(HFDEDFLKCBL DODPONFKEMI, GGDPLEGEDGB JBACLIGCJMA);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x751D620", Offset = "0x751CA20", VA = "0x18751D620")]
	protected void LMHLBFMPICJ(EONNEMECKLI.EHHKANKAHKP NCJFHJJKMGA, string KHAFJMFBNIC, FileInfo GKMFAGNKPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x751D690", Offset = "0x751CA90", VA = "0x18751D690")]
	internal bool PDFIECHHEFE(FileInfo APNPMMJIPCC, long HLGODMOGCOI, long DPDHHEKEIEF, [Out] IOMOLFGHOOF IDDBGNNFLGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	private void KJKNLHHABBK(Exception BIHGENFKIAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class JIGJJCIDOCD : PIEOFAFEAFO
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public override FCOLAPJFJCL OJPHPJGIGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x171DC80", Offset = "0x171D080", VA = "0x18171DC80", Slot = "8")]
		get
		{
			return default(FCOLAPJFJCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x751A850", Offset = "0x7519C50", VA = "0x18751A850")]
	public JIGJJCIDOCD([Optional] string PNGBDAODENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x751A7D0", Offset = "0x7519BD0", VA = "0x18751A7D0")]
	private void NCBAGBCIMEK(HFDEDFLKCBL DODPONFKEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x751A540", Offset = "0x7519940", VA = "0x18751A540", Slot = "9")]
	internal override void KFNKEHBEGLF(Stream HKCPEKJJNPG, long HLGODMOGCOI, long DPDHHEKEIEF, IOMOLFGHOOF IDDBGNNFLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x7519D60", Offset = "0x7519160", VA = "0x187519D60", Slot = "10")]
	internal override bool AMDKNDGAMMK(Stream NMMBEBHHGMC, long HLGODMOGCOI, long DPDHHEKEIEF, FLCGDBECPIG KOEHACGPBMC, [Out] IOMOLFGHOOF IDDBGNNFLGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x751A350", Offset = "0x7519750", VA = "0x18751A350", Slot = "11")]
	protected override FileInfo CKHCPFFLHJP(long HLGODMOGCOI, long DPDHHEKEIEF, HFDEDFLKCBL DODPONFKEMI, GGDPLEGEDGB JBACLIGCJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x751A440", Offset = "0x7519840", VA = "0x18751A440", Slot = "12")]
	protected override DirectoryInfo FOFGPNJFOLK(HFDEDFLKCBL DODPONFKEMI, GGDPLEGEDGB JBACLIGCJMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class ODJENNBDJEH : PIEOFAFEAFO
{
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private static readonly byte[] GMJINMLEEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private readonly byte[] HMBPEJPKNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private readonly byte[] GFMGJCHAOKI;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public override FCOLAPJFJCL OJPHPJGIGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x626FCE0", Offset = "0x626F0E0", VA = "0x18626FCE0", Slot = "8")]
		get
		{
			return default(FCOLAPJFJCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x751D0B0", Offset = "0x751C4B0", VA = "0x18751D0B0")]
	public ODJENNBDJEH([Optional] string PNGBDAODENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x751CCB0", Offset = "0x751C0B0", VA = "0x18751CCB0", Slot = "9")]
	internal override void KFNKEHBEGLF(Stream HKCPEKJJNPG, long HLGODMOGCOI, long DPDHHEKEIEF, IOMOLFGHOOF IDDBGNNFLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x751C290", Offset = "0x751B690", VA = "0x18751C290", Slot = "10")]
	internal override bool AMDKNDGAMMK(Stream NMMBEBHHGMC, long HLGODMOGCOI, long DPDHHEKEIEF, FLCGDBECPIG KOEHACGPBMC, [Out] IOMOLFGHOOF IDDBGNNFLGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x751CF60", Offset = "0x751C360", VA = "0x18751CF60")]
	private void NJIHPGACNNO(byte[] HFHEELJJDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x751CA70", Offset = "0x751BE70", VA = "0x18751CA70", Slot = "11")]
	protected override FileInfo CKHCPFFLHJP(long HLGODMOGCOI, long DPDHHEKEIEF, HFDEDFLKCBL DODPONFKEMI, GGDPLEGEDGB JBACLIGCJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x751CBA0", Offset = "0x751BFA0", VA = "0x18751CBA0", Slot = "12")]
	protected override DirectoryInfo FOFGPNJFOLK(HFDEDFLKCBL DODPONFKEMI, GGDPLEGEDGB JBACLIGCJMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public enum FCOLAPJFJCL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal class OCLDEEOJCMK : LHNNFHLAALM
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class KIGGOPPEKKM : IEnumerable<GDMCCAIBAAO>, IEnumerable, IEnumerator<GDMCCAIBAAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private GDMCCAIBAAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public OCLDEEOJCMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private HFDEDFLKCBL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public HFDEDFLKCBL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private FCOLAPJFJCL[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private IEnumerator<GDMCCAIBAAO> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private GDMCCAIBAAO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
		[DebuggerHidden]
		public KIGGOPPEKKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x751ACC0", Offset = "0x751A0C0", VA = "0x18751ACC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x751A890", Offset = "0x7519C90", VA = "0x18751A890", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x751AB70", Offset = "0x7519F70", VA = "0x18751AB70")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x751AC70", Offset = "0x751A070", VA = "0x18751AC70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x751ABC0", Offset = "0x7519FC0", VA = "0x18751ABC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GDMCCAIBAAO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x751ABC0", Offset = "0x7519FC0", VA = "0x18751ABC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private readonly FCOLAPJFJCL[] KLHNOHAHEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private readonly Dictionary<FCOLAPJFJCL, LHNNFHLAALM> MDALMPFNIKP;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public FCOLAPJFJCL OJPHPJGIGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x751B9E0", Offset = "0x751ADE0", VA = "0x18751B9E0", Slot = "4")]
		get
		{
			return default(FCOLAPJFJCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x751BF60", Offset = "0x751B360", VA = "0x18751BF60")]
	[UnityEngine.Scripting.Preserve]
	public OCLDEEOJCMK(params LHNNFHLAALM[] COHINLOALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x751BC30", Offset = "0x751B030", VA = "0x18751BC30", Slot = "5")]
	public bool DGMMANBBCBH(long HLGODMOGCOI, long DPDHHEKEIEF, HFDEDFLKCBL DODPONFKEMI, [Out] GDMCCAIBAAO ALHPIJFCLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x751BA10", Offset = "0x751AE10", VA = "0x18751BA10")]
	private void CIBGOFHLMMJ(int MBCALPBHOEP, long HLGODMOGCOI, long DPDHHEKEIEF, HFDEDFLKCBL DODPONFKEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x751BD80", Offset = "0x751B180", VA = "0x18751BD80", Slot = "6")]
	[IteratorStateMachine(typeof(KIGGOPPEKKM))]
	public IEnumerable<GDMCCAIBAAO> LGNKNJMHKML(HFDEDFLKCBL DODPONFKEMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x751BE10", Offset = "0x751B210", VA = "0x18751BE10", Slot = "7")]
	public GDMCCAIBAAO PHDEJECKJCC(long HLGODMOGCOI, long DPDHHEKEIEF, IOMOLFGHOOF IDDBGNNFLGM, HFDEDFLKCBL DODPONFKEMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class BIPKPHPEIHI
{
	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x7518940", Offset = "0x7517D40", VA = "0x187518940")]
	internal static byte[] MCCLMHDCDCO(byte[] HFHEELJJDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x75188C0", Offset = "0x7517CC0", VA = "0x1875188C0")]
	public static void GPAMIEOALLM(Stream JPOBDPHFPBD, byte[] NCEPJHENCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x75186E0", Offset = "0x7517AE0", VA = "0x1875186E0")]
	public static bool GEIMPEBHNNP(Stream JPOBDPHFPBD, long JEEKCGBIOLH, FLCGDBECPIG CKBIELKGMAK, [Out] byte[] KNPHEIGOGIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
internal sealed class GEHEFAENAKG : GDMCCAIBAAO, IEquatable<GDMCCAIBAAO>, IEquatable<GEHEFAENAKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private readonly PIEOFAFEAFO HJKCOAJABCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	public readonly FileInfo GGDGOOLPNAJ;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public FCOLAPJFJCL OJPHPJGIGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x6EB3460", Offset = "0x6EB2860", VA = "0x186EB3460", Slot = "9")]
		get
		{
			return default(FCOLAPJFJCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DateTime BCCIDCNACDI
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x7519470", Offset = "0x7518870", VA = "0x187519470", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x7519920", Offset = "0x7518D20", VA = "0x187519920")]
	public GEHEFAENAKG(PIEOFAFEAFO GLOIFBHMLFH, FileInfo APNPMMJIPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x7519870", Offset = "0x7518C70", VA = "0x187519870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x7519720", Offset = "0x7518B20", VA = "0x187519720", Slot = "5")]
	public void FODEFNIGOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x7519430", Offset = "0x7518830", VA = "0x187519430", Slot = "6")]
	public bool CAONKLDBNIK(long HLGODMOGCOI, long DPDHHEKEIEF, [Out] IOMOLFGHOOF IDDBGNNFLGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x75195F0", Offset = "0x75189F0", VA = "0x1875195F0", Slot = "7")]
	public bool Equals(GDMCCAIBAAO OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x7519660", Offset = "0x7518A60", VA = "0x187519660", Slot = "8")]
	public bool Equals(GEHEFAENAKG OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x7519500", Offset = "0x7518900", VA = "0x187519500", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x75197E0", Offset = "0x7518BE0", VA = "0x1875197E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public delegate void FLCGDBECPIG(EONNEMECKLI.EHHKANKAHKP BOPMIIAGNPO, string ADPAIBGIHMB);
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface LHNNFHLAALM
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	FCOLAPJFJCL OJPHPJGIGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DGMMANBBCBH(long HLGODMOGCOI, long DPDHHEKEIEF, HFDEDFLKCBL DODPONFKEMI, [Out] GDMCCAIBAAO ALHPIJFCLMO);

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<GDMCCAIBAAO> LGNKNJMHKML(HFDEDFLKCBL DODPONFKEMI);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GDMCCAIBAAO PHDEJECKJCC(long HLGODMOGCOI, long DPDHHEKEIEF, IOMOLFGHOOF IDDBGNNFLGM, HFDEDFLKCBL DODPONFKEMI);
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
