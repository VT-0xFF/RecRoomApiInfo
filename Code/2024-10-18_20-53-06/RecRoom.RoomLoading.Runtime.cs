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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x74AF700", Offset = "0x74AEB00", VA = "0x1874AF700")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
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
	public class LogRegistrationIndex : HLBHPGBFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74A6FC0", Offset = "0x74A63C0", VA = "0x1874A6FC0", Slot = "4")]
		public override void MHJHNBDIMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74B4130", Offset = "0x74B3530", VA = "0x1874B4130", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AMKNFEEDHHI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74963B0", Offset = "0x74957B0", VA = "0x1874963B0")]
	public AMKNFEEDHHI(string MOKGCFCFCPE, Exception GPPNMDMLEIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class JMGCLKCKINO : FAGJJMPEGJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MIMKNMPKPLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<OLCMIFIIOEF>> <>t__builder;

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
		private TaskAwaiter<LBFLHEOLDJC<OLCMIFIIOEF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74ADBC0", Offset = "0x74ACFC0", VA = "0x1874ADBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74ADE00", Offset = "0x74AD200", VA = "0x1874ADE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LCBNCIGCOJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<NHHFDOJDDLA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<NHHFDOJDDLA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74A2360", Offset = "0x74A1760", VA = "0x1874A2360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74A2570", Offset = "0x74A1970", VA = "0x1874A2570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	[UnityEngine.Scripting.Preserve]
	public JMGCLKCKINO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74A1320", Offset = "0x74A0720", VA = "0x1874A1320", Slot = "4")]
	[AsyncStateMachine(typeof(MIMKNMPKPLI))]
	public Task<IReadOnlyList<OLCMIFIIOEF>> GBOABMPNDEF(long FJBFONPAOAD, long AEGLBCGIGGP, [Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74A1210", Offset = "0x74A0610", VA = "0x1874A1210", Slot = "5")]
	[AsyncStateMachine(typeof(LCBNCIGCOJI))]
	public Task<IReadOnlyList<NHHFDOJDDLA>> EJPHPHLKNKK(IReadOnlyList<int> KMEAFBIFAFP, [Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CACLJMNLJFD : IEquatable<CACLJMNLJFD>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int FHOBIBILOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	NHHFDOJDDLA HCMEAHIKPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime GDBOLBHKBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MPOJDGKDNEI? JKDHABKHEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OMGLPKIEHJN? FAPEFMMMIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	OINAFEOMIMP COIBPACCEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<IEJAANOGAED> OOCKNBGMOHH();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum OINAFEOMIMP
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FAGJJMPEGJH
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<OLCMIFIIOEF>> GBOABMPNDEF(long FJBFONPAOAD, long AEGLBCGIGGP, [Optional] CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<NHHFDOJDDLA>> EJPHPHLKNKK(IReadOnlyList<int> KMEAFBIFAFP, [Optional] CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MOJGEMPOKOK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class PANJMHLLNLE : CACLJMNLJFD, IEquatable<CACLJMNLJFD>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct NEIPMKKNELH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<IEJAANOGAED> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public PANJMHLLNLE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private ABPMMLMGFMJ <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<JHLHOPAPPOB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<IEJAANOGAED> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x74AF0E0", Offset = "0x74AE4E0", VA = "0x1874AF0E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x74AF5A0", Offset = "0x74AE9A0", VA = "0x1874AF5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly OLCMIFIIOEF LJJLDGMDHPC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int FHOBIBILOPE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8AACD0", Offset = "0x8AA0D0", VA = "0x1808AACD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NHHFDOJDDLA HCMEAHIKPIL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime IPKIBJPOAJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5FE19F0", Offset = "0x5FE0DF0", VA = "0x185FE19F0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MPOJDGKDNEI? JKDHABKHEHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x20CEDB0", Offset = "0x20CE1B0", VA = "0x1820CEDB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public OMGLPKIEHJN? FAPEFMMMIJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5FE1AD0", Offset = "0x5FE0ED0", VA = "0x185FE1AD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public OINAFEOMIMP COIBPACCEAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x938250", Offset = "0x937650", VA = "0x180938250", Slot = "10")]
			get
			{
				return default(OINAFEOMIMP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x74B1D10", Offset = "0x74B1110", VA = "0x1874B1D10", Slot = "9")]
		[AsyncStateMachine(typeof(NEIPMKKNELH))]
		public Task<IEJAANOGAED> OOCKNBGMOHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x74B1E10", Offset = "0x74B1210", VA = "0x1874B1E10")]
		public PANJMHLLNLE(int FPHLKBCDMEB, NHHFDOJDDLA FGMPFILAFAJ, OLCMIFIIOEF LJJLDGMDHPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x74B1BC0", Offset = "0x74B0FC0", VA = "0x1874B1BC0", Slot = "11")]
		public bool Equals(CACLJMNLJFD KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x74B1B20", Offset = "0x74B0F20", VA = "0x1874B1B20", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74B1CD0", Offset = "0x74B10D0", VA = "0x1874B1CD0")]
		private bool KHOJNPBKAKK(PANJMHLLNLE KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74B1C50", Offset = "0x74B1050", VA = "0x1874B1C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class IGOBMBJAKHA : CACLJMNLJFD, IEquatable<CACLJMNLJFD>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct DMCDIBBPMHD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<IEJAANOGAED> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public IGOBMBJAKHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<IEJAANOGAED> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7498A30", Offset = "0x7497E30", VA = "0x187498A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7498C80", Offset = "0x7498080", VA = "0x187498C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly CCFOBHEPCIJ CKAKNNDGDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly MPOJDGKDNEI NCKJNFCNHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly OMGLPKIEHJN BEPJFNHPKLI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int FHOBIBILOPE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x749E800", Offset = "0x749DC00", VA = "0x18749E800", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NHHFDOJDDLA HCMEAHIKPIL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x749E770", Offset = "0x749DB70", VA = "0x18749E770", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime IPKIBJPOAJI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x749E990", Offset = "0x749DD90", VA = "0x18749E990", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MPOJDGKDNEI? JKDHABKHEHB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x749EC00", Offset = "0x749E000", VA = "0x18749EC00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public OMGLPKIEHJN? FAPEFMMMIJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x749EAC0", Offset = "0x749DEC0", VA = "0x18749EAC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public OINAFEOMIMP COIBPACCEAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9E9140", Offset = "0x9E8540", VA = "0x1809E9140", Slot = "10")]
			get
			{
				return default(OINAFEOMIMP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x17826F0", Offset = "0x1781AF0", VA = "0x1817826F0")]
		public IGOBMBJAKHA(CCFOBHEPCIJ KCNCGGGONPD, MPOJDGKDNEI KHNEPBDKGFK, OMGLPKIEHJN OLCBICONLJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x749EB10", Offset = "0x749DF10", VA = "0x18749EB10", Slot = "9")]
		[AsyncStateMachine(typeof(DMCDIBBPMHD))]
		public Task<IEJAANOGAED> OOCKNBGMOHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x749E840", Offset = "0x749DC40", VA = "0x18749E840", Slot = "11")]
		public bool Equals(CACLJMNLJFD KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x749E8E0", Offset = "0x749DCE0", VA = "0x18749E8E0", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x749EA60", Offset = "0x749DE60", VA = "0x18749EA60")]
		private bool KHOJNPBKAKK(IGOBMBJAKHA KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x749E9E0", Offset = "0x749DDE0", VA = "0x18749E9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JJAINAIBAJA : CACLJMNLJFD, IEquatable<CACLJMNLJFD>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct BLJDPOMDLBC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<IEJAANOGAED> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<IEJAANOGAED> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x74976D0", Offset = "0x7496AD0", VA = "0x1874976D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7497930", Offset = "0x7496D30", VA = "0x187497930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly NHHFDOJDDLA LBNNBEHEKLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly MPOJDGKDNEI NCKJNFCNHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly OMGLPKIEHJN BEPJFNHPKLI;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int FHOBIBILOPE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x74A0E20", Offset = "0x74A0220", VA = "0x1874A0E20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public NHHFDOJDDLA HCMEAHIKPIL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime IPKIBJPOAJI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public MPOJDGKDNEI? JKDHABKHEHB
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x74A11C0", Offset = "0x74A05C0", VA = "0x1874A11C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public OMGLPKIEHJN? FAPEFMMMIJP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x74A10A0", Offset = "0x74A04A0", VA = "0x1874A10A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public OINAFEOMIMP COIBPACCEAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "10")]
			get
			{
				return default(OINAFEOMIMP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x17826F0", Offset = "0x1781AF0", VA = "0x1817826F0")]
		public JJAINAIBAJA(NHHFDOJDDLA FGMPFILAFAJ, MPOJDGKDNEI KHNEPBDKGFK, OMGLPKIEHJN OLCBICONLJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x74A10F0", Offset = "0x74A04F0", VA = "0x1874A10F0", Slot = "9")]
		[AsyncStateMachine(typeof(BLJDPOMDLBC))]
		public Task<IEJAANOGAED> OOCKNBGMOHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x74A0E40", Offset = "0x74A0240", VA = "0x1874A0E40", Slot = "11")]
		public bool Equals(CACLJMNLJFD KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x74A0EB0", Offset = "0x74A02B0", VA = "0x1874A0EB0", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74A0F30", Offset = "0x74A0330", VA = "0x1874A0F30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74A0FC0", Offset = "0x74A03C0", VA = "0x1874A0FC0")]
		private bool KHOJNPBKAKK(JJAINAIBAJA KNLMODPGFOA)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct OIPLFEDJAOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<CACLJMNLJFD>> <>t__builder;

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
		public MOJGEMPOKOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<OLCMIFIIOEF> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<OLCMIFIIOEF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, NHHFDOJDDLA account, OLCMIFIIOEF roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x74B0A80", Offset = "0x74AFE80", VA = "0x1874B0A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x74B18B0", Offset = "0x74B0CB0", VA = "0x1874B18B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct FGJLOCMHGPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, NHHFDOJDDLA account, OLCMIFIIOEF roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<OLCMIFIIOEF> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MOJGEMPOKOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<NHHFDOJDDLA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x749AFF0", Offset = "0x749A3F0", VA = "0x18749AFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x749B9C0", Offset = "0x749ADC0", VA = "0x18749B9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EFCDGMMGKLI ICMJCGEPMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly FAGJJMPEGJH EHKEJACGNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FFCIOOAPNCM FJNCPHFGJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NILNFLHOEJA<(long, long), IReadOnlyList<OLCMIFIIOEF>> CCDFOJFPEGA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x74AEF00", Offset = "0x74AE300", VA = "0x1874AEF00")]
	[UnityEngine.Scripting.Preserve]
	public MOJGEMPOKOK([CCLHMIDBCEM(null)] FAGJJMPEGJH OLKGLJNCHPE, [CCLHMIDBCEM(null)] FFCIOOAPNCM IHAFNFEPBPE, [CCLHMIDBCEM(null)] EFCDGMMGKLI POHKAEKEFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x74AEC10", Offset = "0x74AE010", VA = "0x1874AEC10")]
	[AsyncStateMachine(typeof(OIPLFEDJAOI))]
	public Task<IList<CACLJMNLJFD>> EHOLADCDLAJ(long FJBFONPAOAD, long JOABCKCOFMA, bool AOIMDMLCGHC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74AED60", Offset = "0x74AE160", VA = "0x1874AED60")]
	private bool OAOBLBBDJCF(DateTime? KEECODIOLJA, long FJBFONPAOAD, long JOABCKCOFMA, [Out] CCFOBHEPCIJ FKHGMFJEDDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x74AEB00", Offset = "0x74ADF00", VA = "0x1874AEB00")]
	[AsyncStateMachine(typeof(FGJLOCMHGPP))]
	private Task<IReadOnlyList<(int, NHHFDOJDDLA, OLCMIFIIOEF)>> DNOLPLPOEAF(IReadOnlyList<OLCMIFIIOEF> KFHAOJNHHCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FFCIOOAPNCM
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<CCFOBHEPCIJ> DLMOKIPBFLN;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GKADOJDCLIA(long FJBFONPAOAD, long JOABCKCOFMA, MFIELAJAPOD MDHDINIGMGL, HIHOCJFOCEE DFAEMLMEJNM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HNNCGJFMJDG(long FJBFONPAOAD, long JOABCKCOFMA, [Out] CCFOBHEPCIJ FKHGMFJEDDK);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FCOMMBLAOPE(long FJBFONPAOAD, long JOABCKCOFMA, HIHOCJFOCEE DFAEMLMEJNM, [Out] CCFOBHEPCIJ FKHGMFJEDDK);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MAKIKGPOPLC(long FJBFONPAOAD, long JOABCKCOFMA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface BAPAJANIANN : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BCBDNILBLFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task JGDGKCKAKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POOJFJCCFEE(Task IALOMLEGCDH, string FJJNMCBHJPD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface LOLFMOCOBHA : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IEJAANOGAED> BNEHOEKLBDO(CCFOBHEPCIJ FKHGMFJEDDK);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CNKDMILOKIP(CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface DDLGEINJGJN : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LHBMBLFOLNK MPCNFBEJDLG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIAHOKEEGNO();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKJKNLEKBIH();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface OEGLDJJNHCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface CMNCCIDIHGO
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan BNHDPMGOECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan CNLJCBNLPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan MJLDFFEDBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan ACNAHBEJMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MLJHNLIIMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool OOCODLBEMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OFIPGOONLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int PNACEGEDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool EEAOMNAKAOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool JKGOFJLIDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum IFBBEOPNPMI
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum OGMAIFHDKJN
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
public struct EALNFCKLDEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long DKJJGFKFFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long AEGLBCGIGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly IFBBEOPNPMI DPOLEDLIAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception NMFDEBHJBCE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7498D40", Offset = "0x7498140", VA = "0x187498D40")]
	public EALNFCKLDEO(long DKJJGFKFFDB, long AEGLBCGIGGP, IFBBEOPNPMI DPOLEDLIAMP, [CanBeNull] Exception NMFDEBHJBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7498CF0", Offset = "0x74980F0", VA = "0x187498CF0")]
	public static EALNFCKLDEO IIAGPKIJJME(IBCLDPKBHMG DFIBNLBKPPD, IFBBEOPNPMI DPOLEDLIAMP, [Optional] Exception NMFDEBHJBCE)
	{
		return default(EALNFCKLDEO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void OLNJHNNJLJG(EALNFCKLDEO IMCPDPDEAID);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface BOMKDFOENLP : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GJECHPIGFBI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OLNJHNNJLJG PBMDEACIBNJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OLNJHNNJLJG OHKFGENDMHO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event OLNJHNNJLJG AMLOCFDHHLL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<OGMAIFHDKJN, bool> EBJMOAFNGFD;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CGNCJGEOLAC();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IKNPHPEABFH(EALNFCKLDEO IMCPDPDEAID);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MEIDNDAGOJD(EALNFCKLDEO IMCPDPDEAID);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HBDMOOLLDGJ(EALNFCKLDEO IMCPDPDEAID);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IFDPMNGHOAC(OGMAIFHDKJN EHKGKLDGEHA, bool KDJCPPCLCIG);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface LAKMBECFFFC : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FCMLGOPAHMG();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKNONOJPOMF();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface OHHOIGGOBDG : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus DCDPILMKFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GEEMGBHHAFM(IBCLDPKBHMG HNOMDCFLIEN, DEGJNGBNLCG LDHDCEDMJCG, CancellationToken DAMMAGNLMMI);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class MKNJBPFNFPM
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x74ADE70", Offset = "0x74AD270", VA = "0x1874ADE70")]
	public static bool FJGHNBJHPGD(this OHHOIGGOBDG AIMPMBCDFLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate Task NLICDGELOFN(CancellationToken ABHFNNFMPHA, int DHKHFLAIFKJ, LMBPILKJBCB EAHNODIKDKH);
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface CANLDJDDNNG : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMBBCKPAPOK(NLICDGELOFN LGDCBCBIHCN);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface OEHIJBIKFHD : ABPMMLMGFMJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken DFLKGDGNKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	LBNNADLFMIK KLGGHLHBBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	JBIAOBMMOIH CCBPEADAJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CPIIMBLBJFF EGGHIKOGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	PGLGJBMIFMP CJLPCPGMLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	MHFFDFOBCLB JJKONAEEKOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NKOKNEFHBCD NKKAKGEJCKN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	MMKFOOFFIFM CNMCGFPEEBK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MDBGEBJHGHJ FLHHDICHDFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	BAPAJANIANN KPDCMKDIOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	LOLFMOCOBHA OOLIAAADAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	BOMKDFOENLP AGBCAPOGEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	LAKMBECFFFC DHGNNLGDLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	OHHOIGGOBDG CKOLBLNCMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CANLDJDDNNG FNLLALKDIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	NLBALPPPOFI INEGFDMJBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	NONIMFHLGNL KPAIGFMIHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CGAJDCPECLG CPLOMONAELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	NDGLCGJEJHI POFOCDCFDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	EMHEAIMCGOO HAMCJGEAPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	DOKGELGKKKH NODMCKDBOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CCJOCHEECEB JMOCJIBLKBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ADGBBNPKMAJ AJIHAEBDPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	DNLKJEJLIBB NAANDNILPGO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	OMFLLOJBHBJ FAJILMFMMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	DDLGEINJGJN LAOMACKJKED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	CMNCCIDIHGO OBMPJMLGBGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	KHNJNOGLJKJ DPGNKJKGNJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	FFCIOOAPNCM CHBKOKBMEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	IMCIFKKBKEK AKGBAPNJPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	BIOPFAAJHAP ILOJDOGLMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	AOCBOCJDGCN ICNJMFLBBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	FHBAINLFPIL HNJBHHNALCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void PLBLGGJEFMN(DEGJNGBNLCG AFGDKEBBGLN);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface NLBALPPPOFI : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LMBKIADHMKC LEFBGNCKNFL(Guid NEMMHGGPCGF);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BJFEGIDGDBE(Guid NEMMHGGPCGF);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GKMHBFPCAMC(Guid NEMMHGGPCGF, Task EMAFMCEJKHD);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DACOILFBBFD(Guid NEMMHGGPCGF, IEJAANOGAED FKKOMBOCFHJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(IEJAANOGAED, Task)> GDEGIIHHIJG(Guid NEMMHGGPCGF);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface FGLKNDBBKJF : OEGLDJJNHCH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface NONIMFHLGNL : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFFFJNKBJMP(JGPLAGNOLDP MOKGCFCFCPE);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJAHNCAFGBA(JGPLAGNOLDP MOKGCFCFCPE);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<EADHFCPENJI> EMOCJPMFFMP(CancellationToken EAEPMOLDJNH);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface CGAJDCPECLG : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LMBKIADHMKC JNJPMKMLNCE(JGPLAGNOLDP PMAFJOFHIOF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCMHBEEGJKP(Guid NEMMHGGPCGF, Task EMAFMCEJKHD);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface NDGLCGJEJHI : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IEJAANOGAED> POFOCDCFDOP(JGPLAGNOLDP HGICJMFBBEE);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface EMHEAIMCGOO : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HDAMGLELGPE> IGJDIBOHKEN(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, IBCLDPKBHMG HNOMDCFLIEN, CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface CCJOCHEECEB : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEJAANOGAED ELKHBFDHAOC(JDJLHJHOJPN JLPNBKMIEHB);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DGKLHLBMOAL(string NDECLOFKCPB);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface DOKGELGKKKH : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JGPLAGNOLDP> MIAMHAJECKN(JGPLAGNOLDP BCGNIJHEBIO, BEKGAEBGDOP MLKEAFJBPBA, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JGPLAGNOLDP> KOBBHDJEBCL(CancellationToken NBBCMDKGJKI, BEKGAEBGDOP MLKEAFJBPBA);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DJKKOGJAPPD EFEJGHBCGIO(NEGLAKONOOF LCPFCNEDAEO, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DJKKOGJAPPD NBIPEHLCKLA(NEGLAKONOOF LCPFCNEDAEO, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface ADGBBNPKMAJ : OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEJAANOGAED CBOMMMGGHPB(JDJLHJHOJPN JLPNBKMIEHB, EADHFCPENJI GJDDMMGENAF);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEJAANOGAED GCKMJABFAFC(JDJLHJHOJPN HGOPPBIBKNH);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface DNLKJEJLIBB
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEADBMPHMJL(AGHHFGPAKEN CNOPKEEMPNH);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEJFICKIKKG(AGHHFGPAKEN CNOPKEEMPNH);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MOHHOAMNJDB(AGHHFGPAKEN CNOPKEEMPNH);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LGHAEFLLKBK(AGHHFGPAKEN CNOPKEEMPNH);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class AGHHFGPAKEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly IBCLDPKBHMG LNPINNDJEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> MMFMMDEBCGH;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public OGAFCBAEIIJ<string> ADBKOOLJBCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8A8A00", Offset = "0x8A7E00", VA = "0x1808A8A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	public AGHHFGPAKEN(IBCLDPKBHMG PEDCCEONEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7495E80", Offset = "0x7495280", VA = "0x187495E80")]
	public AGHHFGPAKEN CILNCDHBLKL(string OEOMDKHBDFI, string EEPLCHCGAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7495F50", Offset = "0x7495350", VA = "0x187495F50")]
	public bool EBMDNCABKPE([Out] IEnumerable<KeyValuePair<string, string>> KDOOJIKBKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x66C85A0", Offset = "0x66C79A0", VA = "0x1866C85A0")]
	public AGHHFGPAKEN IDDHMFAFBDF(OGAFCBAEIIJ<string> BKBOMPKPCMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface KHNJNOGLJKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool AIBJODKIPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string ODALFHLINNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool COFMFCGAOCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMFDFHAJKMB();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NOJAIEFCJJK OPPPEBOOGBG(long GMKKKFNECIE);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BLGPLOGECAO<OJGEAFAKANE, OMMIODCOJEM> BMLNINJNFFG(long GMKKKFNECIE);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BLGPLOGECAO<OJGEAFAKANE, CALEDHBDGGG> AJBFDAECJIM(long GMKKKFNECIE);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BLGPLOGECAO<long, DAIGEEMMDMO> MACJAOIOMLI();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KJLDEIPEIFF(long GMKKKFNECIE, [Out] bool EFJBHHAGMKI);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> KHGACONIPAJ(byte[] JMBCEPAOBOI, byte[] BFPGKAHKOPK, CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface ABPMMLMGFMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool FJGHNBJHPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool DLMGIAMDINL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	DEGJNGBNLCG BOCDKFBCNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action GJECHPIGFBI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event OLNJHNNJLJG PBMDEACIBNJ;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event OLNJHNNJLJG OHKFGENDMHO;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event OLNJHNNJLJG AMLOCFDHHLL;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<OGMAIFHDKJN, bool> EBJMOAFNGFD;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GKNONOJPOMF();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BEAODDAKCJA AMGJLKIMBMJ();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EAGLIGFEODA MCBHHAJJBJD();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<IEJAANOGAED> BNEHOEKLBDO(CCFOBHEPCIJ KCNCGGGONPD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task CNKDMILOKIP(CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MHFFDFOBCLB
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool HBNKGJANPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string HADKJEEAKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKLPPFKECMN(Scene GDIFIGGEIMB);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BIHJOLLECEC(NAHMKHNIEGM LDCOELLLBAD, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task BLAFCFHPFFG();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task DDBCOKDCKLN();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface PGLGJBMIFMP
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	GEOGAMGHHBK IJMLIDMBKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool EPMKBCPBMPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool JLFPKCCACJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool CLOGJCFLLAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool CBEJIGMNLMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int DACLDOIAIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool DGKDBHNNPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool LECBENBHFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	int HCGHNFMNCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int OLCDFIBOMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool EMNHOLOOMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool LKIMPLDBLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool AFLDMDGLHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float FOFKCKDEBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> BEPJMKKADEE;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LBNNADLFMIK HBOEHFDJMDP(LBNNADLFMIK JDNHBFMLENE);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JFAIIEIEFPB(LBNNADLFMIK FKEBHAJCLGD);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCGDIBMNHOC();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task ALGGHEKBIKE(OGAFCBAEIIJ<string>.DDIOHHJLGKB MCICNKIMKFA, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DPOJNOIFFIA(float DPLFOEEOPEB);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IMAHCMIFNIH(string FOOMCLEFIFH);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<ANFGIAPIKFH> FKFOMMOHDPI();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable FIEDMKFNNBE(object OMHMFLHBNDJ, ANFGIAPIKFH LGMNIMKDFON);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<PGHGNIOMILA> BBHJAOOIGNM();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OMMIODCOJEM GBADPGCIIAN(IEnumerable<DHPBNJJBAKM> KHPFOMLECLB);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ADGIPMDGNOH(int EKDMJPGDAHA);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task AFHBNADEMLC();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OJLMBNHLKGD();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KIJCAJMFAAP();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task LAPEAACBLKN(CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task IACCJPIGMGF(CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<ELHBNEGFOIK> LFEPJDGPJAP(DateTime NOJCEJCFLOL, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> PCEBACEABFA(CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IPKIHMLPKJJ(string MOKGCFCFCPE = "", float AMGMJAOIIEE = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KCBGPNKOCPP JEHJAFOHFAF(BNMBFPNEDMN JFIBKEIOPGG, KOIIDKLEICC OEPNILNKHLE, CALEDHBDGGG CKFABOCNLPA, IEnumerable<PersistenceView> HHNBDLKEMFC, HDEHJNIKCIC GCMMKJOIJCA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void POCCFDEFFNH(CALEDHBDGGG CKFABOCNLPA);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MAHOLMCKJBF(DHPBNJJBAKM OHJDHAOMKKE, [In] KCBGPNKOCPP PLOEEJLCCGK);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task OILAKMHGNNM(CALEDHBDGGG MHHDOIMHKHK, bool OJMHGECGPLM, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task BIPPMGIIFKC(CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OONHDKMEPPO(long FJBFONPAOAD, long AEGLBCGIGGP, JHLHOPAPPOB FHMHFLLLJOO, OLCMIFIIOEF AINOJEPGCAF, MFIELAJAPOD MDHDINIGMGL, OCPEFMIEHAN? HCNGLCOMFAN, PMFOLCAOADP? JLCOANHAJDA);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void GMJNHJOFKOB(long FJBFONPAOAD, long AEGLBCGIGGP, PMFOLCAOADP? JLCOANHAJDA);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void LDCCMPEGEDH(PersistenceView GEPHNOPOHNF);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool HJJFALKNOHB(PersistenceView JAACMBBNMFM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool NFIGMKPMHDN(DHPBNJJBAKM OHJDHAOMKKE, JMININFAJOG BICIOJBDOBL, [Out] IPHLLLPPIAH DDIBIMDHMJJ);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task BPJAKPECBGJ(CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void EBIFAINANAA();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable JOPFPAHBBPK();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void HKNGFPFGHBO(CALEDHBDGGG MHHDOIMHKHK, JMININFAJOG BICIOJBDOBL);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> MKDHPIABKPE(JBIAOBMMOIH BHLNPLGEMCN, CancellationToken NBBCMDKGJKI, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void IFFMMIOKHEL(CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<GKKCGGKMNLI> DDIEILHGEHH(DABJLHFIHII BCGNIJHEBIO);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<JHLHOPAPPOB> CNLDHFOKFNG(long FJBFONPAOAD, bool DECPHIOLGHA, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<OLCMIFIIOEF> HDLENOFBKGL(long FJBFONPAOAD, long AEGLBCGIGGP, long DOFNDHIOLLL, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<OLCMIFIIOEF> JNDBAJKHJNJ(long FJBFONPAOAD, long AEGLBCGIGGP, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<CECCDIADBPO> DIPJGPHGPEP(string KCGJBHDHJNA, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<CECCDIADBPO> EDALFIFOIKL(string KCGJBHDHJNA, long FJBFONPAOAD, long AEGLBCGIGGP, string AIFCIFFNDFH, EIKHKCNEFIJ.NICNJCJFPDH AAAHDHHHHGN, EIKHKCNEFIJ.NICNJCJFPDH BFPGKAHKOPK, int PEOKACJCKGE);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool ADGAGMJGHDM();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool MIFIAJFDNHB();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool KFAPMALMBFK(IEnumerable<IPHLLLPPIAH> GMMHOEJJPNA);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void MLFNKDINNCJ(List<GameObject> EKFLIMFKMNP);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float KCOFFNOECAE();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> GFKCBAJFCBK(string HFGPDDPDFCO, LoadSceneMode PLMLMBGHIGE, bool MMPGNGKNACF, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void EHIKGHJAIFI();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void MPFLDMDHGPH(bool BOCGODCJHIA);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void COKEGDLOHHF();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void PLGFOFCBJKK();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void DLMHADOFCED(IBCLDPKBHMG PBGLHNLKLNG);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task OCJNMDMFHED(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task INKLGJDLKCJ(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task PGFGHPHKIAC(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task OKKHLJJNCEJ(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable NFFIENKPIIP();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "73")]
	OMAFNOJNOMM MFIJGDMHOMD();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task MLGFELAKHEF(CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface OMAFNOJNOMM
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HLPHDCLALEB(CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GGHLDBEIMGN(CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct KCBGPNKOCPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> KGPNEDICBBB;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum ELHBNEGFOIK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct BNMBFPNEDMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string DCONMDIAIIA;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface GEOGAMGHHBK
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	IBCLDPKBHMG GELKIOCCHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	JHLHOPAPPOB NOGEHOCGPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	CNPCHHCCLAA OJILMLPDAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool MNIMNKFANNP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool JINHDNINLCD
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int HNBNMGJFICN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action KNJCIKADBAO;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> CBJPCNGHOFK;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IEFFJNKAIBP();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.MIOOIAGBMCK> KIDMLFEFHHL(long GMKKKFNECIE, [Optional] CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<PICPMOEPPLJ> OPOGGINLFGA();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task OLHJLIGEJCB();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(IBCLDPKBHMG, DEGJNGBNLCG) KIJINDMCBKI();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FHICPPGLKDE IKLACGKIBJD();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NMAPODMKMOM(long GMKKKFNECIE);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void INLBKPKFFGO(IBCLDPKBHMG PEDCCEONEBC, Matchmaking.OCDNKJCLFAC IPNDOKDOGDG, (int Major, int? Minor)? MHEFEIGPGPO);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface OMFLLOJBHBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFMHJOHOMCO([Out] IEnumerable<int> NKIGLAFNMDN);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDGLNHCJELE(DDAANIDIMGM ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IEKDKPPBPEB(DDAANIDIMGM ABHFNNFMPHA);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface ALPBHFDJKEA
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EGBIIOCDIFK(IEJAANOGAED ICJMHKDGCCD);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GODJGBGHBGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INJOGENNLEM(BACECNAEBME.GIAKAFPIGOA FBLNIJPHOLF);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EAIDMKOLEPG(BACECNAEBME.GIAKAFPIGOA FBLNIJPHOLF);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NKOKNEFHBCD : GODJGBGHBGC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEJAANOGAED GLHFBLOGMLA(JDJLHJHOJPN HGOPPBIBKNH);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface MMKFOOFFIFM : GODJGBGHBGC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEJAANOGAED ELKHBFDHAOC(JDJLHJHOJPN OJEMPAFDPFK);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface NOJAIEFCJJK
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LMFFMMPMNDB<NAHMKHNIEGM, CIIOJBGFHGE>> ECBGEMHKGJA(string AIFCIFFNDFH, long GMKKKFNECIE, long? FJBFONPAOAD, long? AEGLBCGIGGP, CAJPIEMLHHH.IKFJJLKJLBB ILCNGDAPFGA, CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BLGPLOGECAO<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LMFFMMPMNDB<JEHNCKPPEOK<TData>, CIIOJBGFHGE>> CFLMJEMHDAE(TGetDataArg NDJFIKMCNAE, CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class MCLEKCLMHNO : OEHIJBIKFHD, ABPMMLMGFMJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct HMCODIPNNJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<IEJAANOGAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MCLEKCLMHNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public CCFOBHEPCIJ autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<IEJAANOGAED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x749E480", Offset = "0x749D880", VA = "0x18749E480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x749E700", Offset = "0x749DB00", VA = "0x18749E700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct LEOGPJPIHPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public MCLEKCLMHNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x74A2650", Offset = "0x74A1A50", VA = "0x1874A2650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x74A2880", Offset = "0x74A1C80", VA = "0x1874A2880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class IPGCDLAGMAC : IEnumerable<OEGLDJJNHCH>, IEnumerable, IEnumerator<OEGLDJJNHCH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private OEGLDJJNHCH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public MCLEKCLMHNO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		private OEGLDJJNHCH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7D0", Offset = "0x9EABD0", VA = "0x1809EB7D0")]
		[DebuggerHidden]
		public IPGCDLAGMAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x749FA70", Offset = "0x749EE70", VA = "0x18749FA70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x749FED0", Offset = "0x749F2D0", VA = "0x18749FED0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x749FE20", Offset = "0x749F220", VA = "0x18749FE20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OEGLDJJNHCH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x749FE20", Offset = "0x749F220", VA = "0x18749FE20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource MDIGOFHGOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LBNNADLFMIK FKEBHAJCLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool INBIMOFIBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private DCGKLNOHLBO ADFNODDBDHO;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public JBIAOBMMOIH CCBPEADAJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAF0", Offset = "0x8ABEF0", VA = "0x1808ACAF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAD0", Offset = "0x8ABED0", VA = "0x1808ACAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public CPIIMBLBJFF EGGHIKOGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB50", Offset = "0x8ABF50", VA = "0x1808ACB50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB20", Offset = "0x8ABF20", VA = "0x1808ACB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public PGLGJBMIFMP CJLPCPGMLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB10", Offset = "0x8ABF10", VA = "0x1808ACB10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB40", Offset = "0x8ABF40", VA = "0x1808ACB40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public MHFFDFOBCLB JJKONAEEKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB00", Offset = "0x8ABF00", VA = "0x1808ACB00", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB60", Offset = "0x8ABF60", VA = "0x1808ACB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public NKOKNEFHBCD NKKAKGEJCKN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAE0", Offset = "0x8ABEE0", VA = "0x1808ACAE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB30", Offset = "0x8ABF30", VA = "0x1808ACB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public MMKFOOFFIFM CNMCGFPEEBK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCC0", Offset = "0x8AF0C0", VA = "0x1808AFCC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD20", Offset = "0x8AF120", VA = "0x1808AFD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public MDBGEBJHGHJ FLHHDICHDFN
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC60", Offset = "0x8AF060", VA = "0x1808AFC60", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBF0", Offset = "0x8AEFF0", VA = "0x1808AFBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public BAPAJANIANN KPDCMKDIOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC80", Offset = "0x8AF080", VA = "0x1808AFC80", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB50", Offset = "0x8AEF50", VA = "0x1808AFB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public LOLFMOCOBHA OOLIAAADAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA730C0", Offset = "0xA724C0", VA = "0x180A730C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xDCE380", Offset = "0xDCD780", VA = "0x180DCE380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public BOMKDFOENLP AGBCAPOGEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC70", Offset = "0x8AF070", VA = "0x1808AFC70", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCA0", Offset = "0x8AF0A0", VA = "0x1808AFCA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public LAKMBECFFFC DHGNNLGDLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9B5880", Offset = "0x9B4C80", VA = "0x1809B5880", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9B0D00", Offset = "0x9B0100", VA = "0x1809B0D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public OHHOIGGOBDG CKOLBLNCMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8B2320", Offset = "0x8B1720", VA = "0x1808B2320", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8B2360", Offset = "0x8B1760", VA = "0x1808B2360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CANLDJDDNNG FNLLALKDIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9258E0", Offset = "0x924CE0", VA = "0x1809258E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9B5420", Offset = "0x9B4820", VA = "0x1809B5420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public NLBALPPPOFI INEGFDMJBCF
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x922080", Offset = "0x921480", VA = "0x180922080", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xDB37B0", Offset = "0xDB2BB0", VA = "0x180DB37B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public FGLKNDBBKJF OHDKDHIDBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9073F0", Offset = "0x9067F0", VA = "0x1809073F0", Slot = "57")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xC09CA0", Offset = "0xC090A0", VA = "0x180C09CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public NONIMFHLGNL KPAIGFMIHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x907440", Offset = "0x906840", VA = "0x180907440", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x924D60", Offset = "0x924160", VA = "0x180924D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public CGAJDCPECLG CPLOMONAELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x921E70", Offset = "0x921270", VA = "0x180921E70", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA0F390", Offset = "0xA0E790", VA = "0x180A0F390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public NDGLCGJEJHI POFOCDCFDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8B2350", Offset = "0x8B1750", VA = "0x1808B2350", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8B2300", Offset = "0x8B1700", VA = "0x1808B2300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EMHEAIMCGOO HAMCJGEAPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x922030", Offset = "0x921430", VA = "0x180922030", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xCAF5B0", Offset = "0xCAE9B0", VA = "0x180CAF5B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public DOKGELGKKKH NODMCKDBOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x922020", Offset = "0x921420", VA = "0x180922020", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xE67240", Offset = "0xE66640", VA = "0x180E67240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public CCJOCHEECEB JMOCJIBLKBA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8F49E0", Offset = "0x8F3DE0", VA = "0x1808F49E0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xE67220", Offset = "0xE66620", VA = "0x180E67220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public ADGBBNPKMAJ AJIHAEBDPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x921F20", Offset = "0x921320", VA = "0x180921F20", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xCAFE90", Offset = "0xCAF290", VA = "0x180CAFE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public DNLKJEJLIBB NAANDNILPGO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x922110", Offset = "0x921510", VA = "0x180922110", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D60", Offset = "0x9A0160", VA = "0x1809A0D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public OMFLLOJBHBJ FAJILMFMMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x907400", Offset = "0x906800", VA = "0x180907400", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xE67380", Offset = "0xE66780", VA = "0x180E67380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public DDLGEINJGJN LAOMACKJKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x921F90", Offset = "0x921390", VA = "0x180921F90", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xE67360", Offset = "0xE66760", VA = "0x180E67360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public CMNCCIDIHGO OBMPJMLGBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x921FC0", Offset = "0x9213C0", VA = "0x180921FC0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xD2D8E0", Offset = "0xD2CCE0", VA = "0x180D2D8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public KHNJNOGLJKJ DPGNKJKGNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x921FA0", Offset = "0x9213A0", VA = "0x180921FA0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xD2D8C0", Offset = "0xD2CCC0", VA = "0x180D2D8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public FFCIOOAPNCM CHBKOKBMEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x921FB0", Offset = "0x9213B0", VA = "0x180921FB0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public IMCIFKKBKEK AKGBAPNJPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x921FD0", Offset = "0x9213D0", VA = "0x180921FD0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public BIOPFAAJHAP ILOJDOGLMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x921FE0", Offset = "0x9213E0", VA = "0x180921FE0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public AOCBOCJDGCN ICNJMFLBBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9048E0", Offset = "0x903CE0", VA = "0x1809048E0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public FHBAINLFPIL HNJBHHNALCN
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xDE4710", Offset = "0xDE3B10", VA = "0x180DE4710", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public DEGJNGBNLCG BOCDKFBCNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F88F0", VA = "0x1809F94F0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA8A960", Offset = "0xA89D60", VA = "0x180A8A960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private bool CLKODPNBICB
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x74ACFD0", Offset = "0x74AC3D0", VA = "0x1874ACFD0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private bool JBGEEDPJAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x74AD240", Offset = "0x74AC640", VA = "0x1874AD240", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private CancellationToken ICPJJJCGJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x74AD320", Offset = "0x74AC720", VA = "0x1874AD320", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private LBNNADLFMIK HKAFMDDCFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action KFEOKONEMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x74AD510", Offset = "0x74AC910", VA = "0x1874AD510", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x74AD2C0", Offset = "0x74AC6C0", VA = "0x1874AD2C0", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event OLNJHNNJLJG AIKKMJJGCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x74AD150", Offset = "0x74AC550", VA = "0x1874AD150", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x74AD030", Offset = "0x74AC430", VA = "0x1874AD030", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event OLNJHNNJLJG BCJJJABCFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x74AD5D0", Offset = "0x74AC9D0", VA = "0x1874AD5D0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x74AD4B0", Offset = "0x74AC8B0", VA = "0x1874AD4B0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event OLNJHNNJLJG MDHMIBLCLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x74AD0F0", Offset = "0x74AC4F0", VA = "0x1874AD0F0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x74AD570", Offset = "0x74AC970", VA = "0x1874AD570", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<OGMAIFHDKJN, bool> CNGALGKJNOK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x74AD450", Offset = "0x74AC850", VA = "0x1874AD450", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x74AD090", Offset = "0x74AC490", VA = "0x1874AD090", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0xA8A960", Offset = "0xA89D60", VA = "0x180A8A960", Slot = "37")]
	public void PLBLGGJEFMN(DEGJNGBNLCG AFGDKEBBGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x74AD740", Offset = "0x74ACB40", VA = "0x1874AD740")]
	[UnityEngine.Scripting.Preserve]
	internal MCLEKCLMHNO([CCLHMIDBCEM(null)] LBNNADLFMIK FKEBHAJCLGD, [CCLHMIDBCEM(null)] JBIAOBMMOIH BHLNPLGEMCN, [CCLHMIDBCEM(null)] CPIIMBLBJFF IJGBOCJAFLH, [CCLHMIDBCEM(null)] PGLGJBMIFMP BLDEOEOIGBD, [CCLHMIDBCEM(null)] MHFFDFOBCLB FOGHACKLCGL, [CCLHMIDBCEM(null)] NKOKNEFHBCD KMEBOLLDBMM, [CCLHMIDBCEM(null)] MMKFOOFFIFM HFDFJGPGOMG, [CCLHMIDBCEM(null)] MDBGEBJHGHJ FENKJMGGEDL, [CCLHMIDBCEM(null)] BAPAJANIANN AKLLKLCOLBD, [CCLHMIDBCEM(null)] LOLFMOCOBHA DDBKMFMOIHM, [CCLHMIDBCEM(null)] BOMKDFOENLP EMOLLDGONPK, [CCLHMIDBCEM(null)] LAKMBECFFFC PEOBDEPGNHA, [CCLHMIDBCEM(null)] OHHOIGGOBDG AIMPMBCDFLO, [CCLHMIDBCEM(null)] CANLDJDDNNG HMHGGNKKJNO, [CCLHMIDBCEM(null)] NLBALPPPOFI MHNPLMLLCCB, [CCLHMIDBCEM(null)] FGLKNDBBKJF LLFDNEOHCNG, [CCLHMIDBCEM(null)] NONIMFHLGNL FLDBCEGGEMB, [CCLHMIDBCEM(null)] CGAJDCPECLG IJDKOADECEB, [CCLHMIDBCEM(null)] NDGLCGJEJHI JDNKLLKFCII, [CCLHMIDBCEM(null)] EMHEAIMCGOO OGGLKHLKMHA, [CCLHMIDBCEM(null)] CCJOCHEECEB CBJMFPIAMCF, [CCLHMIDBCEM(null)] DOKGELGKKKH JJDOKJLCONI, [CCLHMIDBCEM(null)] ADGBBNPKMAJ EMEPNKBNLLK, [CCLHMIDBCEM(null)] DNLKJEJLIBB LCIKBBKBBME, [CCLHMIDBCEM(null)] OMFLLOJBHBJ MAFIPNMPCNP, [CCLHMIDBCEM(null)] CMNCCIDIHGO HGDDFPIIMHP, [CCLHMIDBCEM(null)] KHNJNOGLJKJ HDPKIKEHAMO, [CCLHMIDBCEM(null)] FFCIOOAPNCM EEHEDGCPKBI, [CCLHMIDBCEM(null)] IMCIFKKBKEK HLBAKNLCMMH, [CCLHMIDBCEM(null)] BIOPFAAJHAP DCFMJHMNCBJ, [CCLHMIDBCEM(null)] AOCBOCJDGCN CFJKAJCOMOK, [CCLHMIDBCEM(null)] FHBAINLFPIL NOLHONDNBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x74ACD90", Offset = "0x74AC190", VA = "0x1874ACD90")]
	private void CGCFJDLGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x74ACE40", Offset = "0x74AC240", VA = "0x1874ACE40", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x74ACBF0", Offset = "0x74ABFF0", VA = "0x1874ACBF0", Slot = "50")]
	private void BFKNLBICCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x74AD3C0", Offset = "0x74AC7C0", VA = "0x1874AD3C0", Slot = "51")]
	private BEAODDAKCJA MKKPMHEPGOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x74AD1B0", Offset = "0x74AC5B0", VA = "0x1874AD1B0", Slot = "52")]
	private EAGLIGFEODA KCLHLPBAKCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x74AD630", Offset = "0x74ACA30", VA = "0x1874AD630", Slot = "53")]
	[AsyncStateMachine(typeof(HMCODIPNNJJ))]
	private Task<IEJAANOGAED> PEABKHANCCI(CCFOBHEPCIJ FKHGMFJEDDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x74ACCA0", Offset = "0x74AC0A0", VA = "0x1874ACCA0", Slot = "54")]
	[AsyncStateMachine(typeof(LEOGPJPIHPI))]
	private Task CAEIINALFGC(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x74AD340", Offset = "0x74AC740", VA = "0x1874AD340")]
	[IteratorStateMachine(typeof(IPGCDLAGMAC))]
	private IEnumerable<OEGLDJJNHCH> MHLABAJNKHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x74ACC40", Offset = "0x74AC040", VA = "0x1874ACC40")]
	[CompilerGenerated]
	private void BLMDFICAHBM(OEGLDJJNHCH GKPPNECBJFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class EJNOEMBLAEN : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x11F2E40", Offset = "0x11F2240", VA = "0x1811F2E40")]
	public EJNOEMBLAEN(string MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class CEJMNOENKJI : GJHBBILDBON
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct OAEEBMCGJKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CEJMNOENKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x74AF780", Offset = "0x74AEB80", VA = "0x1874AF780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x74AFAC0", Offset = "0x74AEEC0", VA = "0x1874AFAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly PGLGJBMIFMP BLDEOEOIGBD;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B40", Offset = "0x8B6F40", VA = "0x1808B7B40")]
	public CEJMNOENKJI(OEHIJBIKFHD LHLCJGLEKJD, PGLGJBMIFMP BLDEOEOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7497AF0", Offset = "0x7496EF0", VA = "0x187497AF0", Slot = "4")]
	[AsyncStateMachine(typeof(OAEEBMCGJKJ))]
	public Task<bool> GGBDNEJEOCP(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7497A10", Offset = "0x7496E10", VA = "0x187497A10")]
	[CompilerGenerated]
	private object DKNICEAIBMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class KBEMPOMAFIC : GJHBBILDBON
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct BIPCNBBAGLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public KBEMPOMAFIC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7496F50", Offset = "0x7496350", VA = "0x187496F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7497660", Offset = "0x7496A60", VA = "0x187497660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly PGLGJBMIFMP BLDEOEOIGBD;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private GEOGAMGHHBK IJMLIDMBKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x74A1440", Offset = "0x74A0840", VA = "0x1874A1440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B40", Offset = "0x8B6F40", VA = "0x1808B7B40")]
	public KBEMPOMAFIC(OEHIJBIKFHD LHLCJGLEKJD, PGLGJBMIFMP BLDEOEOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x74A1570", Offset = "0x74A0970", VA = "0x1874A1570", Slot = "4")]
	[AsyncStateMachine(typeof(BIPCNBBAGLH))]
	public Task<bool> GGBDNEJEOCP(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x74A1490", Offset = "0x74A0890", VA = "0x1874A1490")]
	[CompilerGenerated]
	private object DLNNENDICCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class APMELCLMKKM : GJHBBILDBON
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class HFCEEBMOIBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public APMELCLMKKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public PICPMOEPPLJ result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IBCLDPKBHMG newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public HFCEEBMOIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x749DE80", Offset = "0x749D280", VA = "0x18749DE80")]
		internal object GCPIDFOBPGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x749DF70", Offset = "0x749D370", VA = "0x18749DF70")]
		internal object NDLIJEOMIIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x749DDE0", Offset = "0x749D1E0", VA = "0x18749DDE0")]
		internal object BHNLPJCOPNB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct PBBFBFHBKME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public APMELCLMKKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private HFCEEBMOIBC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<PICPMOEPPLJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x74B1E70", Offset = "0x74B1270", VA = "0x1874B1E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x74B2790", Offset = "0x74B1B90", VA = "0x1874B2790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly PGLGJBMIFMP BLDEOEOIGBD;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private GEOGAMGHHBK IJMLIDMBKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7496420", Offset = "0x7495820", VA = "0x187496420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B40", Offset = "0x8B6F40", VA = "0x1808B7B40")]
	public APMELCLMKKM(OEHIJBIKFHD LHLCJGLEKJD, PGLGJBMIFMP BLDEOEOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7496470", Offset = "0x7495870", VA = "0x187496470", Slot = "4")]
	[AsyncStateMachine(typeof(PBBFBFHBKME))]
	public Task<bool> GGBDNEJEOCP(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal interface GJHBBILDBON
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> GGBDNEJEOCP(CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct JHFLCOMIDOM
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class FMDDJDEJNKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public OEHIJBIKFHD manager;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public FMDDJDEJNKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x749BA30", Offset = "0x749AE30", VA = "0x18749BA30")]
		internal Task LOIINLAAIDM(CancellationToken cancellationToken, int roomTotalVersion, LMBPILKJBCB localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct OIDGBAILPBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public JHFLCOMIDOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private CCFOBHEPCIJ <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<ELHBNEGFOIK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<IEJAANOGAED> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x74B0480", Offset = "0x74AF880", VA = "0x1874B0480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x74B0A10", Offset = "0x74AFE10", VA = "0x1874B0A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct LNHNOOBAAJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public JHFLCOMIDOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x74A3260", Offset = "0x74A2660", VA = "0x1874A3260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x74A3580", Offset = "0x74A2980", VA = "0x1874A3580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CancellationToken NBBCMDKGJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly OEHIJBIKFHD BLMJILKGBHG;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private JBIAOBMMOIH CCBPEADAJCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x74A06E0", Offset = "0x749FAE0", VA = "0x1874A06E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private PGLGJBMIFMP CJLPCPGMLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x74A0730", Offset = "0x749FB30", VA = "0x1874A0730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private GEOGAMGHHBK IJMLIDMBKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x74A0900", Offset = "0x749FD00", VA = "0x1874A0900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private LOLFMOCOBHA OOLIAAADAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x74A0BC0", Offset = "0x749FFC0", VA = "0x1874A0BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x222DA20", Offset = "0x222CE20", VA = "0x18222DA20")]
	public JHFLCOMIDOM(CancellationToken NBBCMDKGJKI, OEHIJBIKFHD BLMJILKGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x74A0780", Offset = "0x749FB80", VA = "0x1874A0780")]
	public static NLICDGELOFN BHFDMMFOCMC(OEHIJBIKFHD BLMJILKGBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x74A0980", Offset = "0x749FD80", VA = "0x1874A0980")]
	[AsyncStateMachine(typeof(OIDGBAILPBC))]
	public Task<bool> EPAPKGBPEKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x74A0C10", Offset = "0x74A0010", VA = "0x1874A0C10")]
	private bool OBCBFBOFNIH([Out] CCFOBHEPCIJ FKHGMFJEDDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x74A0830", Offset = "0x749FC30", VA = "0x1874A0830")]
	[AsyncStateMachine(typeof(LNHNOOBAAJF))]
	private Task BLCIJJLBHBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x74A0A90", Offset = "0x749FE90", VA = "0x1874A0A90")]
	private Task<ELHBNEGFOIK> JIBGGEBLIGC(CCFOBHEPCIJ JJBEDAJKLAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct LMBKIADHMKC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly NLBALPPPOFI MHNPLMLLCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Guid NEMMHGGPCGF;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Task<(IEJAANOGAED, Task)> HACELDIBING
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x74A3190", Offset = "0x74A2590", VA = "0x1874A3190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x45855B0", Offset = "0x45849B0", VA = "0x1845855B0")]
	public LMBKIADHMKC(NLBALPPPOFI MHNPLMLLCCB, Guid NEMMHGGPCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x74A3140", Offset = "0x74A2540", VA = "0x1874A3140")]
	public TaskAwaiter<(IEJAANOGAED, Task)> HAJOPLDNPCH()
	{
		return default(TaskAwaiter<(IEJAANOGAED, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x74A3070", Offset = "0x74A2470", VA = "0x1874A3070", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct OFOHPAJPOLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly TaskCompletionSource<(IEJAANOGAED, Task)> KHIMLJKOCNA;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Task<(IEJAANOGAED, Task)> HACELDIBING
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x74B0230", Offset = "0x74AF630", VA = "0x1874B0230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x74B0300", Offset = "0x74AF700", VA = "0x1874B0300")]
	public OFOHPAJPOLP(TimeSpan AGLEHEANGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x74B0140", Offset = "0x74AF540", VA = "0x1874B0140")]
	public void GFADGIDMGOG(Task EMAFMCEJKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x74B0270", Offset = "0x74AF670", VA = "0x1874B0270")]
	public void PGKPBLHEFKH(IEJAANOGAED ICJMHKDGCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x74B01E0", Offset = "0x74AF5E0", VA = "0x1874B01E0")]
	public void IIAJPEJDAJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x74B00B0", Offset = "0x74AF4B0", VA = "0x1874B00B0")]
	internal void ADMGPCGJFDN(string MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class LMAFHCCIMMP
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class IMJDGPGHDDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public OLCMIFIIOEF subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public IMJDGPGHDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x749EC50", Offset = "0x749E050", VA = "0x18749EC50")]
		internal bool CKHGJHBLGHB(CNPCHHCCLAA s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x74A2B60", Offset = "0x74A1F60", VA = "0x1874A2B60")]
	public static HDAMGLELGPE JMOKCOIDHBC(long DKJJGFKFFDB, long AEGLBCGIGGP, string KCGJBHDHJNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x74A2D80", Offset = "0x74A2180", VA = "0x1874A2D80")]
	public static HDAMGLELGPE JMOKCOIDHBC(long DKJJGFKFFDB, long AEGLBCGIGGP, OJGEAFAKANE JMBCEPAOBOI, long DOFNDHIOLLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x74A2BF0", Offset = "0x74A1FF0", VA = "0x1874A2BF0")]
	public static HDAMGLELGPE JMOKCOIDHBC(GKKCGGKMNLI DBIPBFGDELC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x74A2E40", Offset = "0x74A2240", VA = "0x1874A2E40")]
	public static HDAMGLELGPE JMOKCOIDHBC(JHLHOPAPPOB MCEKLAIGNKE, OLCMIFIIOEF HABBJFGJDOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x74A2A70", Offset = "0x74A1E70", VA = "0x1874A2A70")]
	public static HDAMGLELGPE JKCMAGLHKFJ(this HDAMGLELGPE GKKLHKCNNPG, JHLHOPAPPOB NIDPELCEBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x74A28E0", Offset = "0x74A1CE0", VA = "0x1874A28E0")]
	public static HDAMGLELGPE FANLIKOLGCL(this HDAMGLELGPE GKKLHKCNNPG, OLCMIFIIOEF DNDHFADENGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RecRoom.NoEngine.Common.Preserve]
internal class AJMIEMGGKNO : BAPAJANIANN, OEGLDJJNHCH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct CHAIOKEINON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AJMIEMGGKNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7497BE0", Offset = "0x7496FE0", VA = "0x187497BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7498270", Offset = "0x7497670", VA = "0x187498270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly DDAANIDIMGM FDPFLFKFHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private string JDHCANKCCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Task BLHHDFDKNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool BCBDNILBLFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x74962F0", Offset = "0x74956F0", VA = "0x1874962F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Task JGDGKCKAKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7496100", Offset = "0x7495500", VA = "0x187496100", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4B0", Offset = "0x8AC8B0", VA = "0x1808AD4B0", Slot = "7")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7496190", Offset = "0x7495590", VA = "0x187496190", Slot = "6")]
	public void POOJFJCCFEE(Task IALOMLEGCDH, string FJJNMCBHJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7495FE0", Offset = "0x74953E0", VA = "0x187495FE0")]
	[AsyncStateMachine(typeof(CHAIOKEINON))]
	private Task EOIBGLGEALF(Task CAGPKDGNEEB, string FJJNMCBHJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7496320", Offset = "0x7495720", VA = "0x187496320")]
	public AJMIEMGGKNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class HKBGLPOBDNA : DDLGEINJGJN, OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool GDIMLFEMIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private LHBMBLFOLNK IDPICIPAMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private JBIAOBMMOIH BHLNPLGEMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private CMNCCIDIHGO HGDDFPIIMHP;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public LHBMBLFOLNK MPCNFBEJDLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x749E260", Offset = "0x749D660", VA = "0x18749E260", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x749E0A0", Offset = "0x749D4A0", VA = "0x18749E0A0", Slot = "7")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x749E2D0", Offset = "0x749D6D0", VA = "0x18749E2D0", Slot = "5")]
	public void NIAHOKEEGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x749E220", Offset = "0x749D620", VA = "0x18749E220", Slot = "6")]
	public void CKJKNLEKBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x749DFE0", Offset = "0x749D3E0", VA = "0x18749DFE0")]
	private Task CDHGACHEJGE(DIOCOOCKCBC EFCBJHHANBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x749E220", Offset = "0x749D620", VA = "0x18749E220", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public HKBGLPOBDNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class INOLPFNNCDJ : CMNCCIDIHGO
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class GMOKIBJPEJC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly OMPFDBLPBEP HEFFGHBGHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly string OEOMDKHBDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly T BMLEAJPEFAD;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public T EEMLDMGPOLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x946390", Offset = "0x945790", VA = "0x180946390")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x9463A0", Offset = "0x9457A0", VA = "0x1809463A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x40BDB20", Offset = "0x40BCF20", VA = "0x1840BDB20")]
		public GMOKIBJPEJC(OMPFDBLPBEP HEFFGHBGHBG, string OEOMDKHBDFI, T BMLEAJPEFAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x40BD450", Offset = "0x40BC850", VA = "0x1840BD450")]
		private void NJEDIIHGJOA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly OMPFDBLPBEP HEFFGHBGHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly GMOKIBJPEJC<TimeSpan> EPDABEPGCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly GMOKIBJPEJC<TimeSpan> FINPAEOAIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly GMOKIBJPEJC<TimeSpan> KNMADKADNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly GMOKIBJPEJC<TimeSpan> DLHGAKICHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly GMOKIBJPEJC<bool> DJEAIAADINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly GMOKIBJPEJC<bool> OBHPEEGKPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly GMOKIBJPEJC<bool> DCAMCMMCJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly GMOKIBJPEJC<int> IJPGCNDPPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly GMOKIBJPEJC<bool> HJKMFCBEGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly GMOKIBJPEJC<bool> ALABABPGFEC;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TimeSpan BNHDPMGOECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x749F400", Offset = "0x749E800", VA = "0x18749F400", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TimeSpan CNLJCBNLPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x749F500", Offset = "0x749E900", VA = "0x18749F500", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TimeSpan MJLDFFEDBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x749F3C0", Offset = "0x749E7C0", VA = "0x18749F3C0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public TimeSpan ACNAHBEJMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x749F5C0", Offset = "0x749E9C0", VA = "0x18749F5C0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool MLJHNLIIMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x749F380", Offset = "0x749E780", VA = "0x18749F380", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool OOCODLBEMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x749F4C0", Offset = "0x749E8C0", VA = "0x18749F4C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool OFIPGOONLPO
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x749F580", Offset = "0x749E980", VA = "0x18749F580", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int PNACEGEDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x749F480", Offset = "0x749E880", VA = "0x18749F480", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool EEAOMNAKAOO
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x749F540", Offset = "0x749E940", VA = "0x18749F540", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool JKGOFJLIDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x749F440", Offset = "0x749E840", VA = "0x18749F440", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x749F600", Offset = "0x749EA00", VA = "0x18749F600")]
	[UnityEngine.Scripting.Preserve]
	public INOLPFNNCDJ([CCLHMIDBCEM(null)] OMPFDBLPBEP HEFFGHBGHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class KHDDEKCJHDB : BOMKDFOENLP, OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class EJOJOFHFMNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public EALNFCKLDEO roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public EJOJOFHFMNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x749AF10", Offset = "0x749A310", VA = "0x18749AF10")]
		internal object DOPFFFHFIAA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action GJECHPIGFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x74A1B10", Offset = "0x74A0F10", VA = "0x1874A1B10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x74A1FA0", Offset = "0x74A13A0", VA = "0x1874A1FA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event OLNJHNNJLJG PBMDEACIBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x74A1740", Offset = "0x74A0B40", VA = "0x1874A1740", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x74A16A0", Offset = "0x74A0AA0", VA = "0x1874A16A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event OLNJHNNJLJG OHKFGENDMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x74A20F0", Offset = "0x74A14F0", VA = "0x1874A20F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x74A1A70", Offset = "0x74A0E70", VA = "0x1874A1A70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event OLNJHNNJLJG AMLOCFDHHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x74A19D0", Offset = "0x74A0DD0", VA = "0x1874A19D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x74A1D40", Offset = "0x74A1140", VA = "0x1874A1D40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<OGMAIFHDKJN, bool> EBJMOAFNGFD
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x74A1C90", Offset = "0x74A1090", VA = "0x1874A1C90", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x74A2040", Offset = "0x74A1440", VA = "0x1874A2040", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "19")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x74A17E0", Offset = "0x74A0BE0", VA = "0x1874A17E0", Slot = "14")]
	public void CGNCJGEOLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x74A1C30", Offset = "0x74A1030", VA = "0x1874A1C30", Slot = "15")]
	public void IKNPHPEABFH(EALNFCKLDEO IMCPDPDEAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x74A1C60", Offset = "0x74A1060", VA = "0x1874A1C60", Slot = "16")]
	public void MEIDNDAGOJD(EALNFCKLDEO IMCPDPDEAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x74A1BB0", Offset = "0x74A0FB0", VA = "0x1874A1BB0", Slot = "17")]
	public void HBDMOOLLDGJ(EALNFCKLDEO IMCPDPDEAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x74A1BE0", Offset = "0x74A0FE0", VA = "0x1874A1BE0", Slot = "18")]
	public void IFDPMNGHOAC(OGMAIFHDKJN EHKGKLDGEHA, bool KDJCPPCLCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x74A1DE0", Offset = "0x74A11E0", VA = "0x1874A1DE0")]
	private void NCEDFJEFMFN(OLNJHNNJLJG LGMNIMKDFON, EALNFCKLDEO IMCPDPDEAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public KHDDEKCJHDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal class GDLOPJAOCLB : LAKMBECFFFC, OEGLDJJNHCH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct PFCKCIDDHEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public GDLOPJAOCLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x74B3510", Offset = "0x74B2910", VA = "0x1874B3510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x74B3A00", Offset = "0x74B2E00", VA = "0x1874B3A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct INIBIGMJKHJ : IAsyncStateMachine
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
		public GDLOPJAOCLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x749EC80", Offset = "0x749E080", VA = "0x18749EC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x749F320", Offset = "0x749E720", VA = "0x18749F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class LEGDFLBPNEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LEGDFLBPNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x74A25E0", Offset = "0x74A19E0", VA = "0x1874A25E0")]
		internal object KONAHMNNOHH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct JEIMGKJEJCO : IAsyncStateMachine
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
		public GDLOPJAOCLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private LEGDFLBPNEP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x749FF20", Offset = "0x749F320", VA = "0x18749FF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x74A0670", Offset = "0x749FA70", VA = "0x1874A0670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class BMJPCOCLHDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BMJPCOCLHDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x74979A0", Offset = "0x7496DA0", VA = "0x1874979A0")]
		internal object MLKJPHIGBBJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private PGLGJBMIFMP BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private GJHBBILDBON[] HCKJBOGHEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private CancellationTokenSource INALIICJMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private int EFELDCPICLC;

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x749C9E0", Offset = "0x749BDE0", VA = "0x18749C9E0", Slot = "6")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x749CB90", Offset = "0x749BF90", VA = "0x18749CB90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x749CE70", Offset = "0x749C270", VA = "0x18749CE70", Slot = "8")]
	public void JBHONAEHGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x749CC70", Offset = "0x749C070", VA = "0x18749CC70", Slot = "5")]
	public void GKNONOJPOMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x749CBA0", Offset = "0x749BFA0", VA = "0x18749CBA0", Slot = "4")]
	[AsyncStateMachine(typeof(PFCKCIDDHEK))]
	public Task FCMLGOPAHMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x749CF70", Offset = "0x749C370", VA = "0x18749CF70")]
	private void MKEJJOPJFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x749C8E0", Offset = "0x749BCE0", VA = "0x18749C8E0")]
	[AsyncStateMachine(typeof(INIBIGMJKHJ))]
	private Task CDMJLFKGEGE(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x749D450", Offset = "0x749C850", VA = "0x18749D450")]
	[AsyncStateMachine(typeof(JEIMGKJEJCO))]
	private Task<bool> PKMENPAPODA(int HAJICDLBEKC, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x749D370", Offset = "0x749C770", VA = "0x18749D370")]
	private void PILMIJILOCK(int HAJICDLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x749D290", Offset = "0x749C690", VA = "0x18749D290")]
	private void OLIBAHGKHMB(int HAJICDLBEKC, bool KDJCPPCLCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x749CD40", Offset = "0x749C140", VA = "0x18749CD40")]
	private void GLDJPICMCPL(int HAJICDLBEKC, Exception DMFMNMKKLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x749CA60", Offset = "0x749BE60", VA = "0x18749CA60")]
	private void DEIJBJLOEKA(CancellationToken NBBCMDKGJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public GDLOPJAOCLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.NoEngine.Common.Preserve]
internal class LPLDCGDBJFE : OHHOIGGOBDG, OEGLDJJNHCH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct BIGPPANBOEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public IBCLDPKBHMG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public LPLDCGDBJFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public DEGJNGBNLCG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7496590", Offset = "0x7495990", VA = "0x187496590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7496EF0", Offset = "0x74962F0", VA = "0x187496EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct PDMMEBDPMHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public LPLDCGDBJFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public IBCLDPKBHMG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public DEGJNGBNLCG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private OGAFCBAEIIJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private GADNJKDCJGL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private BEKGAEBGDOP <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private AGHHFGPAKEN <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x74B2800", Offset = "0x74B1C00", VA = "0x1874B2800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x74B34B0", Offset = "0x74B28B0", VA = "0x1874B34B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class NCDKDEPLCKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Matchmaking.OCDNKJCLFAC result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public FKGAJLIKFLF errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public NCDKDEPLCKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x74AF030", Offset = "0x74AE430", VA = "0x1874AF030")]
		internal object HHOGMLLFEGE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class DCFGOANICNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Task<HDAMGLELGPE> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public DCFGOANICNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		internal Task<HDAMGLELGPE> DGMHFCJMGCH(OGAFCBAEIIJ<string>.DDIOHHJLGKB _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct MADPDGAMAAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public LPLDCGDBJFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public IBCLDPKBHMG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public DEGJNGBNLCG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public BEKGAEBGDOP joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private DCFGOANICNI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private GPJADLBIKFB <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private GADNJKDCJGL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private HGBMDJBMOFN <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Task<Matchmaking.MIOOIAGBMCK> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private ODBJGNMCKPJ <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.MIOOIAGBMCK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter<HDAMGLELGPE> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x74A71E0", Offset = "0x74A65E0", VA = "0x1874A71E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x74ACB90", Offset = "0x74ABF90", VA = "0x1874ACB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct ECFJGLOKPPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public LPLDCGDBJFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <disconnectTimerScope>5__3;

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
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7498D60", Offset = "0x7498160", VA = "0x187498D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x74997C0", Offset = "0x7498BC0", VA = "0x1874997C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct GDKBDLOBHMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public LPLDCGDBJFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private LBNNADLFMIK <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x749C3F0", Offset = "0x749B7F0", VA = "0x18749C3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x749C880", Offset = "0x749BC80", VA = "0x18749C880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct OEAKEOFGCMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<Matchmaking.MIOOIAGBMCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public IBCLDPKBHMG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public LPLDCGDBJFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter<Matchmaking.MIOOIAGBMCK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x74AFB30", Offset = "0x74AEF30", VA = "0x1874AFB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x74B0040", Offset = "0x74AF440", VA = "0x1874B0040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct CNJKJHFAAJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Matchmaking.MIOOIAGBMCK serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public LPLDCGDBJFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public BEKGAEBGDOP joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter<BPGMLNMMGBO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x74982D0", Offset = "0x74976D0", VA = "0x1874982D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x74989D0", Offset = "0x7497DD0", VA = "0x1874989D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class OMPFJFNDMIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public IBCLDPKBHMG targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public OMPFJFNDMIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x74B1A20", Offset = "0x74B0E20", VA = "0x1874B1A20")]
		internal object IMOINBDINIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x74B1920", Offset = "0x74B0D20", VA = "0x1874B1920")]
		internal string DDKJEFOGCLM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct MOFOFCEIGCG : IAsyncStateMachine
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
		public IBCLDPKBHMG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public LPLDCGDBJFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private OMPFJFNDMIN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private GADNJKDCJGL <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x74ADEC0", Offset = "0x74AD2C0", VA = "0x1874ADEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x74AEAA0", Offset = "0x74ADEA0", VA = "0x1874AEAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct FNIBHKAFBED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public LPLDCGDBJFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public BEKGAEBGDOP joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public HDAMGLELGPE initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public IBCLDPKBHMG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public GPJADLBIKFB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x749BA80", Offset = "0x749AE80", VA = "0x18749BA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x749C390", Offset = "0x749B790", VA = "0x18749C390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct ECFPEGAFIBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public LPLDCGDBJFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private GADNJKDCJGL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap3;

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
		[Cpp2IlInjected.Address(RVA = "0x7499820", Offset = "0x7498C20", VA = "0x187499820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x749AEB0", Offset = "0x749A2B0", VA = "0x18749AEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct GMAIOEPBHKP : IAsyncStateMachine
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
		public LMBPILKJBCB localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public LPLDCGDBJFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<IEJAANOGAED> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x749D610", Offset = "0x749CA10", VA = "0x18749D610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x749DD80", Offset = "0x749D180", VA = "0x18749DD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class KLLPOFLCILK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public IBCLDPKBHMG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KLLPOFLCILK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x74A2190", Offset = "0x74A1590", VA = "0x1874A2190")]
		internal object PLIODKACIBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class NFMNCMOOFLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public NFMNCMOOFLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x74CEFE0", Offset = "0x74CE3E0", VA = "0x1874CEFE0")]
		internal void BHDOMHIBOHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class JKJADHIOKKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public IBCLDPKBHMG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public JKJADHIOKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x74C9480", Offset = "0x74C8880", VA = "0x1874C9480")]
		internal object CJDNCDKAOHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class MDMEGHGKKKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public IBCLDPKBHMG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public MDMEGHGKKKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x74CE630", Offset = "0x74CDA30", VA = "0x1874CE630")]
		internal string POLPMPPNBEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly FLILHMOBPPM GBEFEJAKFKF;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly FLILHMOBPPM JIBOIOILDPH;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly FLILHMOBPPM DKBIDBOJGIL;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string APEGEFKANCN;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string ANKKEFHFGID;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string MCLOAJDKIEP;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly Guid MGCOMLOKDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private MDBGEBJHGHJ FENKJMGGEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private CPIIMBLBJFF IJGBOCJAFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private JBIAOBMMOIH BHLNPLGEMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private PGLGJBMIFMP BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private LAKMBECFFFC PEOBDEPGNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private BAPAJANIANN AKLLKLCOLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private BOMKDFOENLP EMOLLDGONPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private BIOPFAAJHAP DCFMJHMNCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private IMCIFKKBKEK HLBAKNLCMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private IDisposable DAGBHHPHAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private FHBAINLFPIL NOLHONDNBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly DDAANIDIMGM EEMIJBLPEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private ODBJGNMCKPJ IOBCNKIHGNJ;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public TaskStatus DCDPILMKFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8D1060", Offset = "0x8D0460", VA = "0x1808D1060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xDAA760", Offset = "0xDA9B60", VA = "0x180DAA760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private GEOGAMGHHBK IJMLIDMBKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x74A3E30", Offset = "0x74A3230", VA = "0x1874A3E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x74A3B10", Offset = "0x74A2F10", VA = "0x1874A3B10", Slot = "6")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x74A4130", Offset = "0x74A3530", VA = "0x1874A4130", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x74A4610", Offset = "0x74A3A10", VA = "0x1874A4610", Slot = "5")]
	[AsyncStateMachine(typeof(BIGPPANBOEA))]
	public Task GEEMGBHHAFM(IBCLDPKBHMG HNOMDCFLIEN, DEGJNGBNLCG LDHDCEDMJCG, CancellationToken DAMMAGNLMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x74A4A10", Offset = "0x74A3E10", VA = "0x1874A4A10")]
	[AsyncStateMachine(typeof(PDMMEBDPMHB))]
	private Task GPEHIMOKPOF(IBCLDPKBHMG HNOMDCFLIEN, DEGJNGBNLCG LDHDCEDMJCG, CancellationToken DAMMAGNLMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x74A4C90", Offset = "0x74A4090", VA = "0x1874A4C90")]
	private void IAPPANACMNC(BIOPFAAJHAP DCFMJHMNCBJ, IBCLDPKBHMG HNOMDCFLIEN, Exception DMFMNMKKLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x74A5600", Offset = "0x74A4A00", VA = "0x1874A5600")]
	private static void KDNBEEGJGAA(AGHHFGPAKEN HMDBLPFJKNB, Exception DMFMNMKKLLI, [Optional] List<int> LGBGNFDGGFG, int EFELDCPICLC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x74A50F0", Offset = "0x74A44F0", VA = "0x1874A50F0")]
	[AsyncStateMachine(typeof(MADPDGAMAAF))]
	private Task JEPAPILIEMA(OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, IBCLDPKBHMG HNOMDCFLIEN, DEGJNGBNLCG LDHDCEDMJCG, BEKGAEBGDOP BLKMCDKFGJA, CancellationToken DAMMAGNLMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x74A6030", Offset = "0x74A5430", VA = "0x1874A6030")]
	private void KKPBPLIHCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x74A4B60", Offset = "0x74A3F60", VA = "0x1874A4B60")]
	[AsyncStateMachine(typeof(ECFJGLOKPPG))]
	private Task GPFAFOJIMGD(OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x74A3640", Offset = "0x74A2A40", VA = "0x1874A3640")]
	private void ADGIBOFGPFD(IBCLDPKBHMG HNOMDCFLIEN, CancellationToken DAMMAGNLMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x74A6540", Offset = "0x74A5940", VA = "0x1874A6540")]
	private void LJDIPMKCDNG(IBCLDPKBHMG HNOMDCFLIEN, BEKGAEBGDOP BLKMCDKFGJA, OperationCanceledException NPMOGDDKJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x74A6940", Offset = "0x74A5D40", VA = "0x1874A6940")]
	private void OICNBIHCOHD(IBCLDPKBHMG HNOMDCFLIEN, BEKGAEBGDOP BLKMCDKFGJA, Exception DMFMNMKKLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x74A4180", Offset = "0x74A3580", VA = "0x1874A4180")]
	private void EIKJBNHBOOM(IBCLDPKBHMG HNOMDCFLIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x74A35E0", Offset = "0x74A29E0", VA = "0x1874A35E0")]
	private static EALNFCKLDEO ABJBDMKANAF(IBCLDPKBHMG HNOMDCFLIEN)
	{
		return default(EALNFCKLDEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x74A5340", Offset = "0x74A4740", VA = "0x1874A5340")]
	[AsyncStateMachine(typeof(GDKBDLOBHMJ))]
	private Task JMIHHDCLMCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x74A5E40", Offset = "0x74A5240", VA = "0x1874A5E40")]
	[AsyncStateMachine(typeof(OEAKEOFGCMG))]
	private Task<Matchmaking.MIOOIAGBMCK> KIDMLFEFHHL(IBCLDPKBHMG HNOMDCFLIEN, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x74A3A00", Offset = "0x74A2E00", VA = "0x1874A3A00")]
	private static BPGMLNMMGBO BLBJGMHCPJA(Matchmaking.MIOOIAGBMCK ONKDGDBCNNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x74A6BE0", Offset = "0x74A5FE0", VA = "0x1874A6BE0")]
	[AsyncStateMachine(typeof(CNJKJHFAAJN))]
	private Task PKPDDADNIGH(Matchmaking.MIOOIAGBMCK ONKDGDBCNNL, BEKGAEBGDOP BLKMCDKFGJA, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken CFKHGFEFMJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x74A4750", Offset = "0x74A3B50", VA = "0x1874A4750")]
	[AsyncStateMachine(typeof(MOFOFCEIGCG))]
	private Task GHLDJBJMAHK(IBCLDPKBHMG HNOMDCFLIEN, CancellationTokenSource CIGNPAFLCBP, Task AAHDBCOBECA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x74A44A0", Offset = "0x74A38A0", VA = "0x1874A44A0")]
	[AsyncStateMachine(typeof(FNIBHKAFBED))]
	private Task FFGIHAEILJF(HDAMGLELGPE KJLCJOPILHD, GPJADLBIKFB MMOBDIJMACN, IBCLDPKBHMG NNCBMPHNFBD, BEKGAEBGDOP MMBIALMJGPM, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken FOPKGBGGBJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x74A5410", Offset = "0x74A4810", VA = "0x1874A5410")]
	private BEKGAEBGDOP KDHPDAPGBMG(BEKGAEBGDOP MMBIALMJGPM, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x74A63B0", Offset = "0x74A57B0", VA = "0x1874A63B0")]
	[AsyncStateMachine(typeof(ECFPEGAFIBE))]
	private Task LGIDHEINOGG(OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x74A6780", Offset = "0x74A5B80", VA = "0x1874A6780")]
	[AsyncStateMachine(typeof(GMAIOEPBHKP))]
	private Task MDBPCJMJECN(CancellationToken NBBCMDKGJKI, int DHKHFLAIFKJ, LMBPILKJBCB EAHNODIKDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x74A4890", Offset = "0x74A3C90", VA = "0x1874A4890")]
	private static void GMEFGMHGEKE(IBCLDPKBHMG HNOMDCFLIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x74A6180", Offset = "0x74A5580", VA = "0x1874A6180")]
	private void KNMOLHKHDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x74A68B0", Offset = "0x74A5CB0", VA = "0x1874A68B0")]
	private void MLDPDJAAEOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x74A3970", Offset = "0x74A2D70", VA = "0x1874A3970")]
	private void BHMCOMLNGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x74A5FA0", Offset = "0x74A53A0", VA = "0x1874A5FA0")]
	private void KIJHAKEFMBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x74A5250", Offset = "0x74A4650", VA = "0x1874A5250")]
	private static void JGMHMNBPIMC(IBCLDPKBHMG HNOMDCFLIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x74A4390", Offset = "0x74A3790", VA = "0x1874A4390")]
	private static CancellationTokenRegistration FEKCONHJNDL(IBCLDPKBHMG HNOMDCFLIEN, CancellationToken CFKHGFEFMJM)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x74A3E80", Offset = "0x74A3280", VA = "0x1874A3E80")]
	private static void DMENMPBOMAF(IBCLDPKBHMG HNOMDCFLIEN, Exception DMFMNMKKLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x74A3F80", Offset = "0x74A3380", VA = "0x1874A3F80")]
	private void DNPJMOGDIMC(IBCLDPKBHMG HNOMDCFLIEN, Task AAHDBCOBECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x74A6B80", Offset = "0x74A5F80", VA = "0x1874A6B80")]
	private static void PKELKJJEMAA(Func<string> IENFPCFJHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x74A6F30", Offset = "0x74A6330", VA = "0x1874A6F30")]
	public LPLDCGDBJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x74A64E0", Offset = "0x74A58E0", VA = "0x1874A64E0")]
	[CompilerGenerated]
	internal static (int, int?) LHINKIJHOAC(FKGAJLIKFLF MHEFEIGPGPO)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class CMKIACJLOKA : CANLDJDDNNG, OEGLDJJNHCH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct IELHGOLCIMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public CMKIACJLOKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public LMBPILKJBCB localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x74C5320", Offset = "0x74C4720", VA = "0x1874C5320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x74C5780", Offset = "0x74C4B80", VA = "0x1874C5780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class LKFCGKPLLCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public CMKIACJLOKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public LMBPILKJBCB localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LKFCGKPLLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x74CC180", Offset = "0x74CB580", VA = "0x1874CC180")]
		internal List<Task> KNAKJHGPCII(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct DLGNDNPKDAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public NLICDGELOFN taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public LMBPILKJBCB localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x74BE300", Offset = "0x74BD700", VA = "0x1874BE300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x74BE6A0", Offset = "0x74BDAA0", VA = "0x1874BE6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct KFLEOMPEBJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public CMKIACJLOKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x74C9C20", Offset = "0x74C9020", VA = "0x1874C9C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x74C9F00", Offset = "0x74C9300", VA = "0x1874C9F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly HashSet<NLICDGELOFN> GGCECLKEENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private CPIIMBLBJFF IJGBOCJAFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private ANFGIAPIKFH PPEGFPKKKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private NFFEEIKDCEG ADJNEMDFCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private IDisposable DAGBHHPHAAF;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x74BA8D0", Offset = "0x74B9CD0", VA = "0x1874BA8D0", Slot = "5")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x74BABD0", Offset = "0x74B9FD0", VA = "0x1874BABD0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x74BB520", Offset = "0x74BA920", VA = "0x1874BB520", Slot = "4")]
	public bool KMBBCKPAPOK(NLICDGELOFN LGDCBCBIHCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x74BB650", Offset = "0x74BAA50", VA = "0x1874BB650")]
	private void NHMPNGGOLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x74BAD70", Offset = "0x74BA170", VA = "0x1874BAD70")]
	private void HMKIOIKDLOJ(LMMLJLDDCAM AAAHDHHHHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x74BB7F0", Offset = "0x74BABF0", VA = "0x1874BB7F0")]
	[AsyncStateMachine(typeof(IELHGOLCIMJ))]
	private Task PFGJIAMMIHC(int DHKHFLAIFKJ, LMBPILKJBCB EAHNODIKDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x74BB580", Offset = "0x74BA980", VA = "0x1874BB580")]
	private Func<CancellationToken, List<Task>> LLLOBHMJDHO(int DHKHFLAIFKJ, LMBPILKJBCB EAHNODIKDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x74BAF90", Offset = "0x74BA390", VA = "0x1874BAF90")]
	private List<Task> ICBLBMHDCGM(int DHKHFLAIFKJ, LMBPILKJBCB EAHNODIKDKH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x74BAC50", Offset = "0x74BA050", VA = "0x1874BAC50")]
	[AsyncStateMachine(typeof(DLGNDNPKDAK))]
	private Task EOAHNEGDOEP(NLICDGELOFN JJDNJMKEDJK, CancellationToken ABHFNNFMPHA, int DHKHFLAIFKJ, LMBPILKJBCB EAHNODIKDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x74BB720", Offset = "0x74BAB20", VA = "0x1874BB720")]
	[AsyncStateMachine(typeof(KFLEOMPEBJI))]
	private Task OAIIBMPCDFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x74BB470", Offset = "0x74BA870", VA = "0x1874BB470")]
	private void JBHONAEHGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x74BB8E0", Offset = "0x74BACE0", VA = "0x1874BB8E0")]
	public CMKIACJLOKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[UnityEngine.Scripting.Preserve]
internal sealed class CFGFNBEMJHI : NLBALPPPOFI, OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class PGLDKFDCGHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public PGLDKFDCGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x74D2630", Offset = "0x74D1A30", VA = "0x1874D2630")]
		internal object KIAKDLALAJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class KPPHEMIIHBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KPPHEMIIHBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x74CAD00", Offset = "0x74CA100", VA = "0x1874CAD00")]
		internal object OAEFEIIAMBO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class PIHEJGHELCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public PIHEJGHELCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class COOEDMDNFBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public COOEDMDNFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x74BB9E0", Offset = "0x74BADE0", VA = "0x1874BB9E0")]
		internal object ELPLJLOJIID()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class MBKCBKPHGLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public MBKCBKPHGLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x74CC8D0", Offset = "0x74CBCD0", VA = "0x1874CC8D0")]
		internal object IACLGCHPAHK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly Dictionary<Guid, OFOHPAJPOLP> MHNPLMLLCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly TimeSpan NJFDPMAGGGO;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "9")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x74B8890", Offset = "0x74B7C90", VA = "0x1874B8890", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x74B8C40", Offset = "0x74B8040", VA = "0x1874B8C40", Slot = "4")]
	public LMBKIADHMKC LEFBGNCKNFL(Guid NEMMHGGPCGF)
	{
		return default(LMBKIADHMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x74B8270", Offset = "0x74B7670", VA = "0x1874B8270", Slot = "5")]
	public bool BJFEGIDGDBE(Guid NEMMHGGPCGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x74B8910", Offset = "0x74B7D10", VA = "0x1874B8910", Slot = "6")]
	public bool GKMHBFPCAMC(Guid NEMMHGGPCGF, Task EMAFMCEJKHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x74B86B0", Offset = "0x74B7AB0", VA = "0x1874B86B0", Slot = "7")]
	public bool DACOILFBBFD(Guid NEMMHGGPCGF, IEJAANOGAED ICJMHKDGCCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x74B88A0", Offset = "0x74B7CA0", VA = "0x1874B88A0", Slot = "8")]
	public Task<(IEJAANOGAED, Task)> GDEGIIHHIJG(Guid NEMMHGGPCGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x74B8480", Offset = "0x74B7880", VA = "0x1874B8480")]
	private void CDOGDKFLNMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x74B8E60", Offset = "0x74B8260", VA = "0x1874B8E60")]
	public CFGFNBEMJHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.NoEngine.Common.Preserve]
internal class PNLJMCHMGKF : FGLKNDBBKJF, OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private class DMBLGBOPCPI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private readonly IBCLDPKBHMG PBGLHNLKLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private readonly CancellationTokenSource INALIICJMHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public readonly CancellationToken ALNILDJDLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool IIHNCJBEJNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private bool NLOIKEFMMEI;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x74BE880", Offset = "0x74BDC80", VA = "0x1874BE880")]
		public DMBLGBOPCPI(IBCLDPKBHMG PBGLHNLKLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x74BE730", Offset = "0x74BDB30", VA = "0x1874BE730")]
		public void JBHONAEHGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x74BE700", Offset = "0x74BDB00", VA = "0x1874BE700", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class JIAJIPPEDJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public DIOCOOCKCBC disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public JIAJIPPEDJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x74C93F0", Offset = "0x74C87F0", VA = "0x1874C93F0")]
		internal object BIHGGCOMGGE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct CHMCOHEOHKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public DIOCOOCKCBC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public PNLJMCHMGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x74B9160", Offset = "0x74B8560", VA = "0x1874B9160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x74B9560", Offset = "0x74B8960", VA = "0x1874B9560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class PLBCMIDKFGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public PLBCMIDKFGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x74D2690", Offset = "0x74D1A90", VA = "0x1874D2690")]
		internal object GNBDFKIDFCC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct GLEACHLMIEN : IAsyncStateMachine
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
		public PNLJMCHMGKF <>4__this;

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
		private GADNJKDCJGL <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x74BF4B0", Offset = "0x74BE8B0", VA = "0x1874BF4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class NDOFEDMGBKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public IBCLDPKBHMG newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public NDOFEDMGBKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x74CEC40", Offset = "0x74CE040", VA = "0x1874CEC40")]
		internal object JGLMKOOGFCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x74CEC00", Offset = "0x74CE000", VA = "0x1874CEC00")]
		internal object DNAMEGIKPBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x74CECE0", Offset = "0x74CE0E0", VA = "0x1874CECE0")]
		internal object NPCIJCMKFDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class KKAMDLGNILO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KKAMDLGNILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x74C9F60", Offset = "0x74C9360", VA = "0x1874C9F60")]
		internal void GGCJNLAALKJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct HEOIMJKKDOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public IBCLDPKBHMG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public PNLJMCHMGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public DEGJNGBNLCG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private NDOFEDMGBKP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private GADNJKDCJGL <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x74C1030", Offset = "0x74C0430", VA = "0x1874C1030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x74C1FC0", Offset = "0x74C13C0", VA = "0x1874C1FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly GBJALBCAJMA.ODLHMKCNKBK MPLNGHPNONO;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly JJLLFFCPCMI APLDBFNCJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private CPIIMBLBJFF IJGBOCJAFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private LAKMBECFFFC PEOBDEPGNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private PGLGJBMIFMP BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private CMNCCIDIHGO HGDDFPIIMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private OHHOIGGOBDG AIMPMBCDFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private IBCLDPKBHMG DMOKJOALLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private DMBLGBOPCPI KPMBGAIBLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private bool GBDOJKEBKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private Task OBCBIAMABGB;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private GEOGAMGHHBK IJMLIDMBKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x74D3270", Offset = "0x74D2670", VA = "0x1874D3270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool MKPMPPOLEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA15480", Offset = "0xA14880", VA = "0x180A15480")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x74D3CC0", Offset = "0x74D30C0", VA = "0x1874D3CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x74D2EB0", Offset = "0x74D22B0", VA = "0x1874D2EB0", Slot = "4")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x74D32C0", Offset = "0x74D26C0", VA = "0x1874D32C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x74D34A0", Offset = "0x74D28A0", VA = "0x1874D34A0")]
	[AsyncStateMachine(typeof(CHMCOHEOHKL))]
	private Task GPBIBIKJJPF(DIOCOOCKCBC FNBDFDDJMLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x74D3B30", Offset = "0x74D2F30", VA = "0x1874D3B30")]
	private void KNJCIKADBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x74D36C0", Offset = "0x74D2AC0", VA = "0x1874D36C0")]
	private void IICDDGCIHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x74D3CD0", Offset = "0x74D30D0", VA = "0x1874D3CD0")]
	private void NPLAIFIINIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x74D3430", Offset = "0x74D2830", VA = "0x1874D3430")]
	private bool FDKCOFHHCDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x74D2DE0", Offset = "0x74D21E0", VA = "0x1874D2DE0")]
	[AsyncStateMachine(typeof(GLEACHLMIEN))]
	private void CBJPCNGHOFK(int AEAJAMHEDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x74D3850", Offset = "0x74D2C50", VA = "0x1874D3850")]
	private void JJEDIIGAOLN([Out] IDisposable MGNOMMGBFEC, [Out] IDisposable GBHFAMKJKIE, [Out] IDisposable PNEOAGGMGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x74D3150", Offset = "0x74D2550", VA = "0x1874D3150")]
	private bool DGDCJNHGKLO(IBCLDPKBHMG PBGLHNLKLNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x74D3AE0", Offset = "0x74D2EE0", VA = "0x1874D3AE0")]
	private void JNDEDFNJJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x74D3590", Offset = "0x74D2990", VA = "0x1874D3590")]
	[AsyncStateMachine(typeof(HEOIMJKKDOO))]
	private Task GPEHIMOKPOF(IBCLDPKBHMG PBGLHNLKLNG, DEGJNGBNLCG LDHDCEDMJCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x74D41E0", Offset = "0x74D35E0", VA = "0x1874D41E0")]
	public PNLJMCHMGKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class IKHPIDJFOJA : NONIMFHLGNL, OEGLDJJNHCH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct IJHLADJFMGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public AsyncTaskMethodBuilder<EADHFCPENJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public IKHPIDJFOJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<EADHFCPENJI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x74C5840", Offset = "0x74C4C40", VA = "0x1874C5840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x74C5AD0", Offset = "0x74C4ED0", VA = "0x1874C5AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class AKBBAELKPIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public JGPLAGNOLDP message;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public AKBBAELKPIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x74B4BC0", Offset = "0x74B3FC0", VA = "0x1874B4BC0")]
		internal object DGEACLNOMAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class IBPIINDGFGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public JGPLAGNOLDP messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public IBPIINDGFGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x74C52C0", Offset = "0x74C46C0", VA = "0x1874C52C0")]
		internal object IGCDEJDLCBN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class ECBFOEBMKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public JGPLAGNOLDP request;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public ECBFOEBMKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x74BE930", Offset = "0x74BDD30", VA = "0x1874BE930")]
		internal object DOOANGNNNHB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct MDCFECGKFKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public JGPLAGNOLDP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public IKHPIDJFOJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<NEGLAKONOOF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x74CD790", Offset = "0x74CCB90", VA = "0x1874CD790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x74CE060", Offset = "0x74CD460", VA = "0x1874CE060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class NLKLMHIBCCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public JGPLAGNOLDP operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public NLKLMHIBCCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x74D1070", Offset = "0x74D0470", VA = "0x1874D1070")]
		internal object IBHCCKHOEFJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct AMFONOIFOHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public JGPLAGNOLDP operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public IKHPIDJFOJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private BEKGAEBGDOP <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<JGPLAGNOLDP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x74B53C0", Offset = "0x74B47C0", VA = "0x1874B53C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x74B5F30", Offset = "0x74B5330", VA = "0x1874B5F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct CLFJBIFHNNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<NEGLAKONOOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public IKHPIDJFOJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public JGPLAGNOLDP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private MHOFMDHHIEC.OCEGJEFCBIP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private BEKGAEBGDOP <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<JGPLAGNOLDP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x74BA330", Offset = "0x74B9730", VA = "0x1874BA330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x74BA860", Offset = "0x74B9C60", VA = "0x1874BA860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class BNNACPLPNKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public NEGLAKONOOF operation;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BNNACPLPNKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x74B7760", Offset = "0x74B6B60", VA = "0x1874B7760")]
		internal object PKCHHNEGJFC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct ENBFLBGPJNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public NEGLAKONOOF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public IKHPIDJFOJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private OGAFCBAEIIJ<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x74BEA70", Offset = "0x74BDE70", VA = "0x1874BEA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x74BF0B0", Offset = "0x74BE4B0", VA = "0x1874BF0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class KCOEGKADNJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public JGPLAGNOLDP request;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KCOEGKADNJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x74C9BC0", Offset = "0x74C8FC0", VA = "0x1874C9BC0")]
		internal object GDGELKHOCJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class EHHNPHHGLDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public JGPLAGNOLDP request;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public EHHNPHHGLDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x74BE990", Offset = "0x74BDD90", VA = "0x1874BE990")]
		internal object NBDFHGHIIPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private BAPAJANIANN AKLLKLCOLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private CGAJDCPECLG IJDKOADECEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private DOKGELGKKKH JJDOKJLCONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private JBIAOBMMOIH BHLNPLGEMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private TaskCompletionSource<EADHFCPENJI> OFJKPFDJIEA;

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x74C5B40", Offset = "0x74C4F40", VA = "0x1874C5B40", Slot = "7")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x74C5F50", Offset = "0x74C5350", VA = "0x1874C5F50", Slot = "6")]
	[AsyncStateMachine(typeof(IJHLADJFMGJ))]
	public Task<EADHFCPENJI> EMOCJPMFFMP(CancellationToken EAEPMOLDJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x74C6B60", Offset = "0x74C5F60", VA = "0x1874C6B60", Slot = "4")]
	public void PFFFJNKBJMP(JGPLAGNOLDP MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x74C6800", Offset = "0x74C5C00", VA = "0x1874C6800", Slot = "5")]
	public void NJAHNCAFGBA(JGPLAGNOLDP GOEACJDAIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x74C6060", Offset = "0x74C5460", VA = "0x1874C6060")]
	[AsyncStateMachine(typeof(MDCFECGKFKB))]
	private Task FBFGANKFLHP(JGPLAGNOLDP BCGNIJHEBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x74C5C30", Offset = "0x74C5030", VA = "0x1874C5C30")]
	[AsyncStateMachine(typeof(AMFONOIFOHA))]
	private Task EBBFCJNOLAC(JGPLAGNOLDP CFOHBHGBLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x74C6170", Offset = "0x74C5570", VA = "0x1874C6170")]
	[AsyncStateMachine(typeof(CLFJBIFHNNG))]
	private Task<NEGLAKONOOF> HDNKKIMEHID(JGPLAGNOLDP BCGNIJHEBIO, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x74C62C0", Offset = "0x74C56C0", VA = "0x1874C62C0")]
	private BEKGAEBGDOP JEJBJNIJHAC(JGPLAGNOLDP HGICJMFBBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x74C6350", Offset = "0x74C5750", VA = "0x1874C6350")]
	[AsyncStateMachine(typeof(ENBFLBGPJNK))]
	private Task JPEJCLFNBHL(NEGLAKONOOF DJJCJPCNFNK, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x74C5D40", Offset = "0x74C5140", VA = "0x1874C5D40")]
	private NEGLAKONOOF EFIFLMPGOGC(JGPLAGNOLDP BCGNIJHEBIO, BEKGAEBGDOP MLKEAFJBPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2E96D50", Offset = "0x2E96150", VA = "0x182E96D50")]
	private T JDIAIJENMGN<T>(T EEPLCHCGAIN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x74C6470", Offset = "0x74C5870", VA = "0x1874C6470")]
	private NEGLAKONOOF MKAANMGBEKK(JGPLAGNOLDP BCGNIJHEBIO, BEKGAEBGDOP MLKEAFJBPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public IKHPIDJFOJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[UnityEngine.Scripting.Preserve]
internal sealed class NLBMMLFCDJG : CGAJDCPECLG, OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class BDBBBJDCDDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BDBBBJDCDDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x74B7690", Offset = "0x74B6A90", VA = "0x1874B7690")]
		internal object NDFFCOLNBCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class NKHLJOPOBNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public NKHLJOPOBNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x74CF080", Offset = "0x74CE480", VA = "0x1874CF080")]
		internal object HIDJMMINDBO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private JBIAOBMMOIH BHLNPLGEMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private ADGBBNPKMAJ EMEPNKBNLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private NONIMFHLGNL FLDBCEGGEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private NLBALPPPOFI MHNPLMLLCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private OMFLLOJBHBJ MAFIPNMPCNP;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x74CF320", Offset = "0x74CE720", VA = "0x1874CF320", Slot = "6")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x74CF490", Offset = "0x74CE890", VA = "0x1874CF490", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x74CFD20", Offset = "0x74CF120", VA = "0x1874CFD20", Slot = "4")]
	public LMBKIADHMKC JNJPMKMLNCE(JGPLAGNOLDP PMAFJOFHIOF)
	{
		return default(LMBKIADHMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x74D0B70", Offset = "0x74CFF70", VA = "0x1874D0B70", Slot = "5")]
	public void PCMHBEEGJKP(Guid NEMMHGGPCGF, Task EMAFMCEJKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x74D0AA0", Offset = "0x74CFEA0", VA = "0x1874D0AA0")]
	private void NNJKJGDFGLB(byte DMNMJLMKEPO, int GBMMGNPMANI, object MKNCMBLIJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x74CF7B0", Offset = "0x74CEBB0", VA = "0x1874CF7B0")]
	private void IDGLPIKADHG(AIIFBMJFMEA COLIBJAKAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x74D0D80", Offset = "0x74D0180", VA = "0x1874D0D80")]
	private void PLPAFBFIOKB(AIIFBMJFMEA COLIBJAKAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x74D03E0", Offset = "0x74CF7E0", VA = "0x1874D03E0")]
	private void LDLDCJIMMFP(AIIFBMJFMEA COLIBJAKAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x74CF0F0", Offset = "0x74CE4F0", VA = "0x1874CF0F0")]
	private IEJAANOGAED BEHDDCNCMKB(JGPLAGNOLDP HGICJMFBBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x74D0620", Offset = "0x74CFA20", VA = "0x1874D0620")]
	private void MGJAHCGDJPN(JGPLAGNOLDP CFOHBHGBLDH, IEJAANOGAED ICJMHKDGCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x74D0140", Offset = "0x74CF540", VA = "0x1874D0140")]
	private bool KOECADOFFOF(JGPLAGNOLDP CFOHBHGBLDH, IEJAANOGAED ICJMHKDGCCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x74CF540", Offset = "0x74CE940", VA = "0x1874CF540")]
	private bool FAKEKNBPPHN(JGPLAGNOLDP LENJAFIDCJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x74D0820", Offset = "0x74CFC20", VA = "0x1874D0820")]
	private bool NFHKCKHINAA(byte DMNMJLMKEPO, ExitGames.Client.Photon.Hashtable COLIBJAKAHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public NLBMMLFCDJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[UnityEngine.Scripting.Preserve]
internal sealed class CICMGIPEAFL : NDGLCGJEJHI, OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class JNJEAOLECEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public EADHFCPENJI operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public CICMGIPEAFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public JGPLAGNOLDP roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public JNJEAOLECEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x74C9500", Offset = "0x74C8900", VA = "0x1874C9500")]
		internal object MBIDDECAGLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x74C9570", Offset = "0x74C8970", VA = "0x1874C9570")]
		internal object MOMMAJOHGHB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct JDFJDIFDLGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AsyncTaskMethodBuilder<IEJAANOGAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public CICMGIPEAFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public JGPLAGNOLDP roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private TaskAwaiter<IEJAANOGAED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x74C7CD0", Offset = "0x74C70D0", VA = "0x1874C7CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x74C8370", Offset = "0x74C7770", VA = "0x1874C8370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class CNIIMLMNOBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public EADHFCPENJI operationType;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public CNIIMLMNOBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x74BB970", Offset = "0x74BAD70", VA = "0x1874BB970")]
		internal object JGIBIKKFEEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class LOKNNFDIKHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public JGPLAGNOLDP request;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LOKNNFDIKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x74CC780", Offset = "0x74CBB80", VA = "0x1874CC780")]
		internal object NHAHKJPKKCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x74CC860", Offset = "0x74CBC60", VA = "0x1874CC860")]
		internal object OJBDAGCDOMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x74CC7F0", Offset = "0x74CBBF0", VA = "0x1874CC7F0")]
		internal object OECEKLCMGJA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct HJEEIMOOJJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<IEJAANOGAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public JGPLAGNOLDP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public CICMGIPEAFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private LOKNNFDIKHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private LMBKIADHMKC <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private IEJAANOGAED <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<(IEJAANOGAED validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x74C29C0", Offset = "0x74C1DC0", VA = "0x1874C29C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x74C3290", Offset = "0x74C2690", VA = "0x1874C3290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private JBIAOBMMOIH BHLNPLGEMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private ADGBBNPKMAJ EMEPNKBNLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private CGAJDCPECLG IJDKOADECEB;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x74B97B0", Offset = "0x74B8BB0", VA = "0x1874B97B0", Slot = "5")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x74B9860", Offset = "0x74B8C60", VA = "0x1874B9860", Slot = "4")]
	[AsyncStateMachine(typeof(JDFJDIFDLGG))]
	private Task<IEJAANOGAED> EIBGCNDMLGN(JGPLAGNOLDP HGICJMFBBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x74B95C0", Offset = "0x74B89C0", VA = "0x1874B95C0")]
	private bool CENMLMLICGP(EADHFCPENJI EHKGKLDGEHA, [Out] IEJAANOGAED IPNDOKDOGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x74B9980", Offset = "0x74B8D80", VA = "0x1874B9980")]
	[AsyncStateMachine(typeof(HJEEIMOOJJI))]
	private Task<IEJAANOGAED> HMALLGFKGCL(JGPLAGNOLDP BCGNIJHEBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public CICMGIPEAFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class CIOEAHJOCPH : EMHEAIMCGOO, OEGLDJJNHCH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct LGLGHBHOKHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<HDAMGLELGPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public IBCLDPKBHMG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public CIOEAHJOCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<JHLHOPAPPOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<HDAMGLELGPE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x74CB500", Offset = "0x74CA900", VA = "0x1874CB500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x74CBAD0", Offset = "0x74CAED0", VA = "0x1874CBAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class INDIGEMMEEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public INDIGEMMEEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x74C7030", Offset = "0x74C6430", VA = "0x1874C7030")]
		internal object FLBGCOEFKGP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct DEGMHELFHFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<JHLHOPAPPOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public CIOEAHJOCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public IBCLDPKBHMG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private INDIGEMMEEM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<JHLHOPAPPOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x74BC990", Offset = "0x74BBD90", VA = "0x1874BC990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x74BCF80", Offset = "0x74BC380", VA = "0x1874BCF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct MHBEFACAMMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<HDAMGLELGPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public CIOEAHJOCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public IBCLDPKBHMG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public JHLHOPAPPOB roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<(OJGEAFAKANE superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x74CE730", Offset = "0x74CDB30", VA = "0x1874CE730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x74CEB90", Offset = "0x74CDF90", VA = "0x1874CEB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class LNIJKFEDPKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LNIJKFEDPKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x9A23F0", Offset = "0x9A17F0", VA = "0x1809A23F0")]
		internal bool PIMLMGBEADL(CNPCHHCCLAA sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct PDLHKFACNJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<(OJGEAFAKANE superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public JHLHOPAPPOB roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public CIOEAHJOCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public IBCLDPKBHMG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter<(OJGEAFAKANE superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x74D17B0", Offset = "0x74D0BB0", VA = "0x1874D17B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x74D1E50", Offset = "0x74D1250", VA = "0x1874D1E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class HPNEENAGOFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public HPNEENAGOFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x74C5210", Offset = "0x74C4610", VA = "0x1874C5210")]
		internal object FOJCKJPNAEJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct KLGPDKJGFIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<(OJGEAFAKANE superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public CNPCHHCCLAA subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public CIOEAHJOCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public IBCLDPKBHMG dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private HPNEENAGOFG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<OLCMIFIIOEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x74CA200", Offset = "0x74C9600", VA = "0x1874CA200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x74CA930", Offset = "0x74C9D30", VA = "0x1874CA930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly (OJGEAFAKANE superRoomData, long subRoomDataSaveId) JOFADJKMPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private PGLGJBMIFMP BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private AOCBOCJDGCN CFJKAJCOMOK;

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x74B9C30", Offset = "0x74B9030", VA = "0x1874B9C30", Slot = "5")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x74B9CC0", Offset = "0x74B90C0", VA = "0x1874B9CC0", Slot = "4")]
	[AsyncStateMachine(typeof(LGLGHBHOKHN))]
	public Task<HDAMGLELGPE> IGJDIBOHKEN(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, IBCLDPKBHMG HNOMDCFLIEN, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x74B9E20", Offset = "0x74B9220", VA = "0x1874B9E20")]
	[AsyncStateMachine(typeof(DEGMHELFHFM))]
	private Task<JHLHOPAPPOB> ILHDPOAAGLH(IBCLDPKBHMG HNOMDCFLIEN, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x74B9F80", Offset = "0x74B9380", VA = "0x1874B9F80")]
	[AsyncStateMachine(typeof(MHBEFACAMMN))]
	private Task<HDAMGLELGPE> JOKCIAMJCEE(IBCLDPKBHMG HNOMDCFLIEN, JHLHOPAPPOB OAFACHFKNOP, long JOABCKCOFMA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x74B9AC0", Offset = "0x74B8EC0", VA = "0x1874B9AC0")]
	[AsyncStateMachine(typeof(PDLHKFACNJN))]
	private Task<(OJGEAFAKANE, long)> BELKHDFFAKD(IBCLDPKBHMG HNOMDCFLIEN, JHLHOPAPPOB OAFACHFKNOP, long JOABCKCOFMA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x74BA0F0", Offset = "0x74B94F0", VA = "0x1874BA0F0")]
	[AsyncStateMachine(typeof(KLGPDKJGFIB))]
	private Task<(OJGEAFAKANE, long)> NHEBJAPJCHD(IBCLDPKBHMG EOLABHIABGI, CNPCHHCCLAA GMMPGCELEJE, long JOABCKCOFMA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public CIOEAHJOCPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[UnityEngine.Scripting.Preserve]
internal sealed class HFLDOLAGBPM : DOKGELGKKKH, OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class OKHPAPCIFEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public JGPLAGNOLDP request;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public OKHPAPCIFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x74D1750", Offset = "0x74D0B50", VA = "0x1874D1750")]
		internal object IMHHNJGOOBD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct OFOLAABIHAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public AsyncTaskMethodBuilder<JGPLAGNOLDP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public JGPLAGNOLDP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public HFLDOLAGBPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public BEKGAEBGDOP pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<JGPLAGNOLDP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x74D10D0", Offset = "0x74D04D0", VA = "0x1874D10D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x74D16E0", Offset = "0x74D0AE0", VA = "0x1874D16E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct PMLBKBEFELO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public AsyncTaskMethodBuilder<JGPLAGNOLDP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public HFLDOLAGBPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public BEKGAEBGDOP pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter<FNMFMKAIHBG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x74D2780", Offset = "0x74D1B80", VA = "0x1874D2780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x74D2D70", Offset = "0x74D2170", VA = "0x1874D2D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class GJNOPCOMKLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public JGPLAGNOLDP request;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public GJNOPCOMKLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x74BF450", Offset = "0x74BE850", VA = "0x1874BF450")]
		internal object MDODIKHHOPK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct BAEADIFKKMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<JGPLAGNOLDP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public JGPLAGNOLDP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public HFLDOLAGBPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public BEKGAEBGDOP pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private JONDGCMMCKA <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private FAMKJENNDFG <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter<FNMFMKAIHBG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x74B6A30", Offset = "0x74B5E30", VA = "0x1874B6A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x74B7620", Offset = "0x74B6A20", VA = "0x1874B7620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private JBIAOBMMOIH BHLNPLGEMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private DDLGEINJGJN LLKBKHCJHGI;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private LHBMBLFOLNK MPCNFBEJDLG
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x74C2420", Offset = "0x74C1820", VA = "0x1874C2420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x74C2020", Offset = "0x74C1420", VA = "0x1874C2020", Slot = "8")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x74C2630", Offset = "0x74C1A30", VA = "0x1874C2630", Slot = "4")]
	[AsyncStateMachine(typeof(OFOLAABIHAH))]
	public Task<JGPLAGNOLDP> MIAMHAJECKN(JGPLAGNOLDP BCGNIJHEBIO, BEKGAEBGDOP MLKEAFJBPBA, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x74C24E0", Offset = "0x74C18E0", VA = "0x1874C24E0", Slot = "5")]
	[AsyncStateMachine(typeof(PMLBKBEFELO))]
	public Task<JGPLAGNOLDP> KOBBHDJEBCL(CancellationToken NBBCMDKGJKI, BEKGAEBGDOP MLKEAFJBPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x74C2210", Offset = "0x74C1610", VA = "0x1874C2210", Slot = "6")]
	public DJKKOGJAPPD EFEJGHBCGIO(NEGLAKONOOF LCPFCNEDAEO, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x74C2790", Offset = "0x74C1B90", VA = "0x1874C2790", Slot = "7")]
	public DJKKOGJAPPD NBIPEHLCKLA(NEGLAKONOOF LCPFCNEDAEO, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x74C20B0", Offset = "0x74C14B0", VA = "0x1874C20B0")]
	[AsyncStateMachine(typeof(BAEADIFKKMD))]
	private Task<JGPLAGNOLDP> DIDAAKPGIOM(JGPLAGNOLDP BCGNIJHEBIO, BEKGAEBGDOP MLKEAFJBPBA, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2CA31E0", Offset = "0x2CA25E0", VA = "0x182CA31E0")]
	private static byte[] FIDGFIAKODC(JGPLAGNOLDP MOKGCFCFCPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public HFLDOLAGBPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class LJHFOKKDNLM : ADGBBNPKMAJ, OEGLDJJNHCH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private NKOKNEFHBCD KMEBOLLDBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private JBIAOBMMOIH BHLNPLGEMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private BAPAJANIANN AKLLKLCOLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private CCJOCHEECEB CBJMFPIAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private PGLGJBMIFMP BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private OHHOIGGOBDG AIMPMBCDFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private CANLDJDDNNG HMHGGNKKJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private CMNCCIDIHGO HGDDFPIIMHP;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private GEOGAMGHHBK IJMLIDMBKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x74CBE20", Offset = "0x74CB220", VA = "0x1874CBE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private static IEJAANOGAED LNGCJLJCJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x74C9B40", Offset = "0x74C8F40", VA = "0x1874C9B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x74CBCB0", Offset = "0x74CB0B0", VA = "0x1874CBCB0", Slot = "6")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x74CBB40", Offset = "0x74CAF40", VA = "0x1874CBB40", Slot = "4")]
	public IEJAANOGAED CBOMMMGGHPB(JDJLHJHOJPN JLPNBKMIEHB, EADHFCPENJI GJDDMMGENAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x74CBE70", Offset = "0x74CB270", VA = "0x1874CBE70", Slot = "5")]
	public IEJAANOGAED GCKMJABFAFC(JDJLHJHOJPN HGOPPBIBKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x74C96A0", Offset = "0x74C8AA0", VA = "0x1874C96A0")]
	private static IEJAANOGAED BPHFIKJHIDM(BCIGOMEILBF ENJPANJMAJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public LJHFOKKDNLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class CFGBABODMHF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x74B8230", Offset = "0x74B7630", VA = "0x1874B8230")]
	public CFGBABODMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x68FD1B0", Offset = "0x68FC5B0", VA = "0x1868FD1B0")]
	public CFGBABODMHF(string MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[UnityEngine.Scripting.Preserve]
internal sealed class JEPMDONINJF : LOLFMOCOBHA, OEGLDJJNHCH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct JBMFBHPEOLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder<IEJAANOGAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public JEPMDONINJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public CCFOBHEPCIJ autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private OGAFCBAEIIJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private NJNLFKIHDFJ <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<IEJAANOGAED> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x74C70E0", Offset = "0x74C64E0", VA = "0x1874C70E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x74C7C60", Offset = "0x74C7060", VA = "0x1874C7C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct ALBPIBCODCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public JEPMDONINJF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x74B4C20", Offset = "0x74B4020", VA = "0x1874B4C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x74B5360", Offset = "0x74B4760", VA = "0x1874B5360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct MDGEPPBJADM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public JEPMDONINJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x74CE0C0", Offset = "0x74CD4C0", VA = "0x1874CE0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x74CE5D0", Offset = "0x74CD9D0", VA = "0x1874CE5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct KPPJKJIIAPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public JEPMDONINJF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x74CAD60", Offset = "0x74CA160", VA = "0x1874CAD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x74CB4A0", Offset = "0x74CA8A0", VA = "0x1874CB4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct KKKINEGLNGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public JEPMDONINJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x74CA000", Offset = "0x74C9400", VA = "0x1874CA000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x74CA1A0", Offset = "0x74C95A0", VA = "0x1874CA1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct PGIAOJALNEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public JEPMDONINJF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x74D1EC0", Offset = "0x74D12C0", VA = "0x1874D1EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x74D25D0", Offset = "0x74D19D0", VA = "0x1874D25D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct BPJPLPFFMKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public JEPMDONINJF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x74B77E0", Offset = "0x74B6BE0", VA = "0x1874B77E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x74B7C50", Offset = "0x74B7050", VA = "0x1874B7C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct DCFCCCCINGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public JEPMDONINJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public HIHOCJFOCEE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private OGAFCBAEIIJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x74BBA40", Offset = "0x74BAE40", VA = "0x1874BBA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x74BBFA0", Offset = "0x74BB3A0", VA = "0x1874BBFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private JBIAOBMMOIH BHLNPLGEMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private PGLGJBMIFMP BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private DOKGELGKKKH JJDOKJLCONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private BAPAJANIANN AKLLKLCOLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private CANLDJDDNNG HMHGGNKKJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private CancellationTokenSource HHLFIEBKLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private Task PDILBMOMEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private TaskCompletionSource<int> IILJCNCKCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private int LLLANCLMHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private int JCEHIDKGPDA;

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x74C8510", Offset = "0x74C7910", VA = "0x1874C8510", Slot = "6")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0xD3A140", Offset = "0xD39540", VA = "0x180D3A140", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x74C8C90", Offset = "0x74C8090", VA = "0x1874C8C90")]
	private void FGNEDJLFMGC(float AMHGDMJHJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x74C83E0", Offset = "0x74C77E0", VA = "0x1874C83E0", Slot = "4")]
	[AsyncStateMachine(typeof(JBMFBHPEOLD))]
	public Task<IEJAANOGAED> BNEHOEKLBDO(CCFOBHEPCIJ FKHGMFJEDDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x74C8830", Offset = "0x74C7C30", VA = "0x1874C8830", Slot = "5")]
	[AsyncStateMachine(typeof(ALBPIBCODCM))]
	public Task CNKDMILOKIP([Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xD3A140", Offset = "0xD39540", VA = "0x180D3A140")]
	public void LHBCIHKIHDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x74C86C0", Offset = "0x74C7AC0", VA = "0x1874C86C0")]
	private NJNLFKIHDFJ CJNNPEDMPBA(CCFOBHEPCIJ FKHGMFJEDDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x74C8D70", Offset = "0x74C8170", VA = "0x1874C8D70")]
	[AsyncStateMachine(typeof(MDGEPPBJADM))]
	private Task FLHAHIJPCKA(CancellationToken DAMMAGNLMMI, int DHKHFLAIFKJ, LMBPILKJBCB EAHNODIKDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x74C91E0", Offset = "0x74C85E0", VA = "0x1874C91E0")]
	[AsyncStateMachine(typeof(KPPJKJIIAPA))]
	private Task NOHMGNJBBOJ(CancellationToken DAMMAGNLMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x74C8920", Offset = "0x74C7D20", VA = "0x1874C8920")]
	[AsyncStateMachine(typeof(KKKINEGLNGA))]
	private Task DPNNCMIIOLB([Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x74C8E60", Offset = "0x74C8260", VA = "0x1874C8E60")]
	[AsyncStateMachine(typeof(PGIAOJALNEI))]
	private Task FMCBMPBPKEM(CancellationToken DAMMAGNLMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x74C8F50", Offset = "0x74C8350", VA = "0x1874C8F50")]
	[AsyncStateMachine(typeof(BPJPLPFFMKL))]
	private Task KGOIKLBBNCK(CancellationToken AILJFKJEJKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x74C9050", Offset = "0x74C8450", VA = "0x1874C9050")]
	private Task KOFBLPPCFDJ(HIHOCJFOCEE DFAEMLMEJNM, CancellationToken DAMMAGNLMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x74C92E0", Offset = "0x74C86E0", VA = "0x1874C92E0")]
	[AsyncStateMachine(typeof(DCFCCCCINGP))]
	private Task PHAGKDEOLFC(HIHOCJFOCEE DFAEMLMEJNM, CancellationToken DAMMAGNLMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x74C8A10", Offset = "0x74C7E10", VA = "0x1874C8A10")]
	private bool ELKHBFDHAOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public JEPMDONINJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[UnityEngine.Scripting.Preserve]
internal class CCACLHOKKDD : CCJOCHEECEB, OEGLDJJNHCH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct LMDMHALGLDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public CCACLHOKKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private OGAFCBAEIIJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x74CC1C0", Offset = "0x74CB5C0", VA = "0x1874CC1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x74CC720", Offset = "0x74CBB20", VA = "0x1874CC720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private MMKFOOFFIFM HFDFJGPGOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private ADGBBNPKMAJ EMEPNKBNLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private DOKGELGKKKH JJDOKJLCONI;

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x74B7CB0", Offset = "0x74B70B0", VA = "0x1874B7CB0", Slot = "6")]
	public void CGCFJDLGJFP(OEHIJBIKFHD LHLCJGLEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x74B8090", Offset = "0x74B7490", VA = "0x1874B8090", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x74B7F90", Offset = "0x74B7390", VA = "0x1874B7F90", Slot = "5")]
	[AsyncStateMachine(typeof(LMDMHALGLDF))]
	public Task DGKLHLBMOAL(string NDECLOFKCPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x74B80E0", Offset = "0x74B74E0", VA = "0x1874B80E0", Slot = "4")]
	public IEJAANOGAED ELKHBFDHAOC(JDJLHJHOJPN JLPNBKMIEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x74B8140", Offset = "0x74B7540", VA = "0x1874B8140")]
	private ICGNPHIHIMP OPDNLAKPFFD(string NDECLOFKCPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public CCACLHOKKDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class GPOJABJCCHE
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x74C06A0", Offset = "0x74BFAA0", VA = "0x1874C06A0")]
	public static void BDMICHHOACP(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x74C08E0", Offset = "0x74BFCE0", VA = "0x1874C08E0")]
	internal static void BHPOFBBLKFK(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x74C0E90", Offset = "0x74C0290", VA = "0x1874C0E90")]
	internal static void LHOHBLAPEBC(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x74C0A40", Offset = "0x74BFE40", VA = "0x1874C0A40")]
	internal static void FGENFJGPNHH(LBNNADLFMIK FKEBHAJCLGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class DDACFNMBPNK : OBFHMKPJCKH<JGPLAGNOLDP>
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class KNOBLBJKJGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public JGPLAGNOLDP message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KNOBLBJKJGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x74CA9A0", Offset = "0x74C9DA0", VA = "0x1874CA9A0")]
		internal object HDIMLIILBOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly DDACFNMBPNK GJPJBBHLIHD;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x74BC360", Offset = "0x74BB760", VA = "0x1874BC360")]
	public ExitGames.Client.Photon.Hashtable IFDLICGNEEM(JGPLAGNOLDP MOKGCFCFCPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x74BC230", Offset = "0x74BB630", VA = "0x1874BC230", Slot = "5")]
	protected override void EHNPMOGOBDK(JGPLAGNOLDP MOKGCFCFCPE, IDictionary<object, object> AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x74BC000", Offset = "0x74BB400", VA = "0x1874BC000", Slot = "6")]
	public override JGPLAGNOLDP AJCCBGLJAMD(IDictionary<object, object> AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x74BC6A0", Offset = "0x74BBAA0", VA = "0x1874BC6A0")]
	private static void PKELKJJEMAA(string ACIGGFPDBDE, JGPLAGNOLDP MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x74BC840", Offset = "0x74BBC40", VA = "0x1874BC840")]
	public DDACFNMBPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x74BC3F0", Offset = "0x74BB7F0", VA = "0x1874BC3F0")]
	[CompilerGenerated]
	internal static string MJNMNOEDCFM(HDAMGLELGPE GKKLHKCNNPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class KAKPHKOBKDB
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public static IEJAANOGAED LNGCJLJCJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x74C9B40", Offset = "0x74C8F40", VA = "0x1874C9B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x74C9BA0", Offset = "0x74C8FA0", VA = "0x1874C9BA0")]
	public static bool NHDBGCAHKIN(this IEJAANOGAED ICJMHKDGCCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x74C96A0", Offset = "0x74C8AA0", VA = "0x1874C96A0")]
	public static IEJAANOGAED BPHFIKJHIDM(BCIGOMEILBF CPNMDDBHIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x74C9950", Offset = "0x74C8D50", VA = "0x1874C9950")]
	public static IEJAANOGAED FKDMJDNEHDH(IEnumerable<IEJAANOGAED> CJCFDOIJDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x74C9700", Offset = "0x74C8B00", VA = "0x1874C9700")]
	public static string CHJPMPNFKBN(this IEJAANOGAED IPNDOKDOGDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public abstract class BACECNAEBME : GODJGBGHBGC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public delegate IEJAANOGAED GIAKAFPIGOA([NotNull] JDJLHJHOJPN JKMCFDPMPIK);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class GNGMJOKKMNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public JDJLHJHOJPN photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public GNGMJOKKMNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x6B1C4B0", Offset = "0x6B1B8B0", VA = "0x186B1C4B0")]
		internal IEJAANOGAED PHJCKEOAFJG(GIAKAFPIGOA v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private bool INBIMOFIBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	protected readonly HashSet<GIAKAFPIGOA> EODFGNMDGBO;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x74B6940", Offset = "0x74B5D40", VA = "0x1874B6940", Slot = "4")]
	public void INJOGENNLEM(GIAKAFPIGOA FBLNIJPHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x74B6650", Offset = "0x74B5A50", VA = "0x1874B6650", Slot = "5")]
	public void EAIDMKOLEPG(GIAKAFPIGOA FBLNIJPHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x74B6600", Offset = "0x74B5A00", VA = "0x1874B6600", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x74B66B0", Offset = "0x74B5AB0", VA = "0x1874B66B0")]
	protected IEJAANOGAED FJKGAPDGNAI(JDJLHJHOJPN HGOPPBIBKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x74B69A0", Offset = "0x74B5DA0", VA = "0x1874B69A0")]
	protected BACECNAEBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class DEDJFIILKJM : BACECNAEBME, NKOKNEFHBCD, GODJGBGHBGC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private sealed class BELCFPJIKOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public IEJAANOGAED result;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BELCFPJIKOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x74B7700", Offset = "0x74B6B00", VA = "0x1874B7700")]
		internal object MGDHBKFLDFO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x74B65F0", Offset = "0x74B59F0", VA = "0x1874B65F0")]
	[UnityEngine.Scripting.Preserve]
	public DEDJFIILKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x74BC880", Offset = "0x74BBC80", VA = "0x1874BC880", Slot = "8")]
	public IEJAANOGAED GLHFBLOGMLA(JDJLHJHOJPN HGOPPBIBKNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class AOLBIFDELHI : BACECNAEBME, MMKFOOFFIFM, GODJGBGHBGC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private sealed class IIPIAMGMEPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public IEJAANOGAED result;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public IIPIAMGMEPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x74C57E0", Offset = "0x74C4BE0", VA = "0x1874C57E0")]
		internal object PCIABPMMKAG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x74B65F0", Offset = "0x74B59F0", VA = "0x1874B65F0")]
	[UnityEngine.Scripting.Preserve]
	public AOLBIFDELHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x74B64E0", Offset = "0x74B58E0", VA = "0x1874B64E0", Slot = "8")]
	public IEJAANOGAED ELKHBFDHAOC(JDJLHJHOJPN OJEMPAFDPFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class GCBDNPPBPNI
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class PLOKEBCNOMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public OGAFCBAEIIJ<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public PLOKEBCNOMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x74D2700", Offset = "0x74D1B00", VA = "0x1874D2700")]
		internal object MAOFAAIKAPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x74BF2B0", Offset = "0x74BE6B0", VA = "0x1874BF2B0")]
	public static OGAFCBAEIIJ<string> GLIIELPPGIG(FLILHMOBPPM APPINHJJCPL, [Optional] string OHNLDFKLCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x74BF1F0", Offset = "0x74BE5F0", VA = "0x1874BF1F0")]
	public static void CCOPIPMHGGG(OGAFCBAEIIJ<string> BKBOMPKPCMH, FLILHMOBPPM APPINHJJCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x74BF390", Offset = "0x74BE790", VA = "0x1874BF390")]
	public static string PGMGCBKKFMJ(JGPLAGNOLDP HGICJMFBBEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal static class IMKHALCHDCA
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x74C7010", Offset = "0x74C6410", VA = "0x1874C7010")]
	public static void AHECPMDENKH(this JBIAOBMMOIH BHLNPLGEMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x74C7020", Offset = "0x74C6420", VA = "0x1874C7020")]
	public static void CGNINENMEDI(this JBIAOBMMOIH BHLNPLGEMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x74C6EF0", Offset = "0x74C62F0", VA = "0x1874C6EF0")]
	private static void ACGNILDIDHC(this JBIAOBMMOIH BHLNPLGEMCN, bool NLDIDKMPOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class AMOFCMGNCIJ : JGLHEIGPCDB, DKLPBAGFKOA, KFEDDHBCGFG, ALHFIOHELPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private readonly DKLPBAGFKOA JKHBOPCDBMM;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public JDJLHJHOJPN CPFAJDPOGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x74B6070", Offset = "0x74B5470", VA = "0x1874B6070", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int DIMDGPMHLAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x74B6250", Offset = "0x74B5650", VA = "0x1874B6250", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int FBLAAJDNOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x74B62A0", Offset = "0x74B56A0", VA = "0x1874B62A0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool NIGDGGKMOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int NDKCFGBAMON
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x938250", Offset = "0x937650", VA = "0x180938250", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GABICFGLGNN.DILJLMONHDG MCLJKFHNFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event JPLIMPJFIFF ONMHMCOMMNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x74B60C0", Offset = "0x74B54C0", VA = "0x1874B60C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x74B62F0", Offset = "0x74B56F0", VA = "0x1874B62F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> CAPGOBFFPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<JDJLHJHOJPN> NJNAIEFMOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action GAOCJIIHJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x74B6160", Offset = "0x74B5560", VA = "0x1874B6160", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x74B6390", Offset = "0x74B5790", VA = "0x1874B6390", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0xD15540", Offset = "0xD14940", VA = "0x180D15540")]
	public AMOFCMGNCIJ(DKLPBAGFKOA JKHBOPCDBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x74B6430", Offset = "0x74B5830", VA = "0x1874B6430", Slot = "8")]
	public bool PACMCHNIOOK(byte DMNMJLMKEPO, ExitGames.Client.Photon.Hashtable GLNEEJKHJJE, AJAGNHIFIBJ DJMDJJNAPIL, SendOptions ANELFBCDBLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x74B5F90", Offset = "0x74B5390", VA = "0x1874B5F90", Slot = "16")]
	public JDJLHJHOJPN AKJMPMEEEBE(int OEOJIBEMNAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "19")]
	public void NFAJEPEPBEI(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "20")]
	public void PJNAAOILBJA(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "21")]
	public void MEAHCFHICEA(object ABHFNNFMPHA, bool HGMONEPLJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x74B6200", Offset = "0x74B5600", VA = "0x1874B6200", Slot = "22")]
	public IDisposable HCJPPILKIJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "23")]
	private bool OFHECCMLGAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "24")]
	public void PEFAPBIEGCB(StringBuilder LJHEIFKGPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xA951A0", Offset = "0xA945A0", VA = "0x180A951A0", Slot = "25")]
	public bool CAAANAGOHKK(bool GMGFFOCKMKF, [Out] string MEDJAOOGFHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x9B04A0", Offset = "0x9AF8A0", VA = "0x1809B04A0", Slot = "28")]
	public void GNEDHCBLDBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct AIIFBMJFMEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly IDictionary<object, object> COLIBJAKAHH;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
	public AIIFBMJFMEA(IDictionary<object, object> COLIBJAKAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x74B48F0", Offset = "0x74B3CF0", VA = "0x1874B48F0")]
	public bool JBJBIMLNNCC([Out] JGPLAGNOLDP MOKGCFCFCPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x74B4840", Offset = "0x74B3C40", VA = "0x1874B4840")]
	public Guid CPDOEICFONK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x74B4A90", Offset = "0x74B3E90", VA = "0x1874B4A90")]
	public IEJAANOGAED PKJGLIOGBJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x74B49A0", Offset = "0x74B3DA0", VA = "0x1874B49A0")]
	public static ExitGames.Client.Photon.Hashtable JMOKCOIDHBC(JGPLAGNOLDP MOKGCFCFCPE, IEJAANOGAED ICJMHKDGCCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal static class ELHFMAABNDF
{
	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x74BE9F0", Offset = "0x74BDDF0", VA = "0x1874BE9F0")]
	public static bool MOHNNIGIPLI(this IBCLDPKBHMG PEDCCEONEBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct NFFEEIKDCEG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct CHKELKOHADC : IAsyncStateMachine
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
		public NFFEEIKDCEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x74B8F20", Offset = "0x74B8320", VA = "0x1874B8F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x74B9100", Offset = "0x74B8500", VA = "0x1874B9100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private readonly CancellationTokenSource INALIICJMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private bool INBIMOFIBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private Task IALOMLEGCDH;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool CPKPPJFCLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x74CEE80", Offset = "0x74CE280", VA = "0x1874CEE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x74CEEB0", Offset = "0x74CE2B0", VA = "0x1874CEEB0")]
	public NFFEEIKDCEG(CancellationToken NBBCMDKGJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x74CED70", Offset = "0x74CE170", VA = "0x1874CED70")]
	[AsyncStateMachine(typeof(CHKELKOHADC))]
	public Task FPHOILLJLPI(Func<CancellationToken, List<Task>> IMCHGMIDLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x74CED20", Offset = "0x74CE120", VA = "0x1874CED20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public readonly struct LKEKLPFEJCA<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct CEPCGINFPHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<JEHNCKPPEOK<TData>, CIIOJBGFHGE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public LKEKLPFEJCA<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private TaskAwaiter<LMFFMMPMNDB<JEHNCKPPEOK<TData>, CIIOJBGFHGE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x5878680", Offset = "0x5877A80", VA = "0x185878680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x4A10A10", Offset = "0x4A0FE10", VA = "0x184A10A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private readonly BLGPLOGECAO<TGetDataArg, TData> DBHDOFFCGAC;

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
	internal LKEKLPFEJCA(BLGPLOGECAO<TGetDataArg, TData> CLOGBAKPPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x45BCEA0", Offset = "0x45BC2A0", VA = "0x1845BCEA0")]
	[AsyncStateMachine(typeof(LKEKLPFEJCA<, >.CEPCGINFPHG))]
	public Task<LMFFMMPMNDB<JEHNCKPPEOK<TData>, CIIOJBGFHGE>> BLDJKIANNBL(TGetDataArg NDJFIKMCNAE, string IIKOMHNIBKE, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class NOFFJGFJPEO
{
	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7870", Offset = "0x2CF6C70", VA = "0x182CF7870")]
	public static LKEKLPFEJCA<TGetDataArg, TData> AHLALEPNKFA<TGetDataArg, TData>(BLGPLOGECAO<TGetDataArg, TData> CLOGBAKPPIL)
	{
		return default(LKEKLPFEJCA<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct FKGAJLIKFLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public readonly int NCEFFBGNFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public readonly int? GJOIDOMDFOH;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x456C390", Offset = "0x456B790", VA = "0x18456C390")]
	public FKGAJLIKFLF(int EKDMJPGDAHA, [Optional] int? FGOJEGCKOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x74BF110", Offset = "0x74BE510", VA = "0x1874BF110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface FJJCLGODEPF<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCCNLHDPOML();

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FJJCLGODEPF<T> CLEIGALCKOD(string MOHONHDGABF);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FJJCLGODEPF<T> BDCKEJCGAIB(HFLMHHLIMPJ<T> AJOLIOBIGCN);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FJJCLGODEPF<T> HMPGGPKOPGK(int MHEFEIGPGPO);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FJJCLGODEPF<T> BOOFFDGFGMN(int MHEFEIGPGPO, DKLNBDCMCDN<T> LLCMJGAJFHD);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface BIOPFAAJHAP
{
	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FJJCLGODEPF<T> LBAMKGADDGF<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HEEMCNDKJDI FIAIBKDFIOE(Exception DMFMNMKKLLI);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FKGAJLIKFLF ABMNDLDDLLF(Exception DMFMNMKKLLI);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate string HFLMHHLIMPJ<in T>(T DMFMNMKKLLI) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public delegate int DKLNBDCMCDN<in T>(T DMFMNMKKLLI) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class HOMLNFOPHIC : BIOPFAAJHAP
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate string HFBKCKHOOMA(Exception DMFMNMKKLLI);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private delegate int HKPNIKNPHIA(Exception DMFMNMKKLLI);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class JFGCGIELKAD<T> : FJJCLGODEPF<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class OKHEIPELCBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public OKHEIPELCBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
			internal string FLDIKHGLMJF(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class HJFNLKDJEAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public HFLMHHLIMPJ<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public HJFNLKDJEAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x41639E0", Offset = "0x4162DE0", VA = "0x1841639E0")]
			internal string JGJGLBDOAHL(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class JIODPCAJONC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public DKLNBDCMCDN<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public JIODPCAJONC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x41639E0", Offset = "0x4162DE0", VA = "0x1841639E0")]
			internal int HGFDNNOAGKN(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly HOMLNFOPHIC DCFMJHMNCBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private readonly Type FNHABCBCOKP;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x4419B70", Offset = "0x4418F70", VA = "0x184419B70")]
		internal JFGCGIELKAD(HOMLNFOPHIC DCFMJHMNCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x4419B40", Offset = "0x4418F40", VA = "0x184419B40", Slot = "4")]
		public void KCCNLHDPOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x44199E0", Offset = "0x4418DE0", VA = "0x1844199E0", Slot = "5")]
		public FJJCLGODEPF<T> CLEIGALCKOD(string MOHONHDGABF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x4419780", Offset = "0x4418B80", VA = "0x184419780", Slot = "6")]
		public FJJCLGODEPF<T> BDCKEJCGAIB(HFLMHHLIMPJ<T> AJOLIOBIGCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x4419B00", Offset = "0x4418F00", VA = "0x184419B00", Slot = "7")]
		public FJJCLGODEPF<T> HMPGGPKOPGK(int MHEFEIGPGPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x44198A0", Offset = "0x4418CA0", VA = "0x1844198A0", Slot = "8")]
		public FJJCLGODEPF<T> BOOFFDGFGMN(int MHEFEIGPGPO, DKLNBDCMCDN<T> LLCMJGAJFHD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class PMKMEGKGEFD<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private bool BAAFFNKCDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private readonly List<Type> LBBBOJHFKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private readonly Dictionary<Type, TVal> AJHFGFILNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly Dictionary<Type, int> ECFNCCAGLGP;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public IReadOnlyList<Type> OLJNOKEOBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x4B2D7A0", Offset = "0x4B2CBA0", VA = "0x184B2D7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x4B2DD00", Offset = "0x4B2D100", VA = "0x184B2DD00")]
		public PMKMEGKGEFD(Dictionary<Type, int> ECFNCCAGLGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x4B2DBE0", Offset = "0x4B2CFE0", VA = "0x184B2DBE0")]
		public void LEFBGNCKNFL(Type OEOMDKHBDFI, TVal OAKJBMEGCLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x4B2DAC0", Offset = "0x4B2CEC0", VA = "0x184B2DAC0")]
		public bool KKAFDBAIGOK(Type FNHABCBCOKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x4B2DCA0", Offset = "0x4B2D0A0", VA = "0x184B2DCA0")]
		public bool MMGNJIFNHBF(TVal EEPLCHCGAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x4B2D920", Offset = "0x4B2CD20", VA = "0x184B2D920")]
		public TVal CADKKGPFCDD(Type DPOLEDLIAMP)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x4B2D980", Offset = "0x4B2CD80", VA = "0x184B2D980")]
		[CompilerGenerated]
		private int IPAALINBLLG(Type FMKAHPDEOAI, Type JNKBGICAPGI)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class HKMPODIHAIK : IEnumerable<FKGAJLIKFLF>, IEnumerable, IEnumerator<FKGAJLIKFLF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private FKGAJLIKFLF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public HOMLNFOPHIC <>4__this;

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
		private IEnumerator<FKGAJLIKFLF> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		private FKGAJLIKFLF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x3C15E50", Offset = "0x3C15250", VA = "0x183C15E50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(FKGAJLIKFLF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x74C3960", Offset = "0x74C2D60", VA = "0x1874C3960", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7D0", Offset = "0x9EABD0", VA = "0x1809EB7D0")]
		[DebuggerHidden]
		public HKMPODIHAIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x74C39B0", Offset = "0x74C2DB0", VA = "0x1874C39B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x74C33A0", Offset = "0x74C27A0", VA = "0x1874C33A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x74C3300", Offset = "0x74C2700", VA = "0x1874C3300")]
		private void CPDIPGODGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x74C3350", Offset = "0x74C2750", VA = "0x1874C3350")]
		private void FKMGMNDEOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x74C3910", Offset = "0x74C2D10", VA = "0x1874C3910", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x74C3850", Offset = "0x74C2C50", VA = "0x1874C3850", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FKGAJLIKFLF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x74C3850", Offset = "0x74C2C50", VA = "0x1874C3850", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly FKGAJLIKFLF AGKBMLELJBK;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Dictionary<Type, int> CODKFJAMLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly HashSet<Type> BAJDLMBCAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly PMKMEGKGEFD<int> GEGIDCMIPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly PMKMEGKGEFD<HKPNIKNPHIA> EKOMDIDCHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly PMKMEGKGEFD<HFBKCKHOOMA> BBIKDHCCPGJ;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x74C4C30", Offset = "0x74C4030", VA = "0x1874C4C30")]
	[OAJAKDHKADM.LHNCMMKCKFL.AGBJBPFJEIM]
	internal static void MHNICLDHNFP(LBNNADLFMIK PCMEKEJCMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x74C4EE0", Offset = "0x74C42E0", VA = "0x1874C4EE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HOMLNFOPHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2C61870", Offset = "0x2C60C70", VA = "0x182C61870", Slot = "4")]
	public FJJCLGODEPF<T> LBAMKGADDGF<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x74C4670", Offset = "0x74C3A70", VA = "0x1874C4670", Slot = "5")]
	public HEEMCNDKJDI FIAIBKDFIOE(Exception DMFMNMKKLLI)
	{
		return default(HEEMCNDKJDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x74C3B00", Offset = "0x74C2F00", VA = "0x1874C3B00", Slot = "6")]
	public FKGAJLIKFLF ABMNDLDDLLF(Exception? DMFMNMKKLLI)
	{
		return default(FKGAJLIKFLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x74C4AB0", Offset = "0x74C3EB0", VA = "0x1874C4AB0", Slot = "7")]
	[IteratorStateMachine(typeof(HKMPODIHAIK))]
	public IEnumerable<FKGAJLIKFLF> JLOPMNBENKC(Exception DMFMNMKKLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x74C3F50", Offset = "0x74C3350", VA = "0x1874C3F50", Slot = "8")]
	public string BDJBMADLBNG(Exception? DMFMNMKKLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x74C40A0", Offset = "0x74C34A0", VA = "0x1874C40A0")]
	private string DLEAKNCBODD(AggregateException MHMNCDAKDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x74C4700", Offset = "0x74C3B00", VA = "0x1874C4700")]
	private void IMNLIBMOEJG(Type FNHABCBCOKP, int MHEFEIGPGPO, HKPNIKNPHIA? KHJKOLOLPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x74C3D00", Offset = "0x74C3100", VA = "0x1874C3D00")]
	private void APIMIIDLNBG(Type FNHABCBCOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x74C43A0", Offset = "0x74C37A0", VA = "0x1874C43A0")]
	private void EIJNAKJJGKD(Type FNHABCBCOKP, HFBKCKHOOMA OEDADALDIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x74C4CA0", Offset = "0x74C40A0", VA = "0x1874C4CA0")]
	private static int NLLMJMHBHNF(Type FNHABCBCOKP, Dictionary<Type, int> ECFNCCAGLGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2E7B910", Offset = "0x2E7AD10", VA = "0x182E7B910")]
	private static bool DHODENMCGLK<TVal>(PMKMEGKGEFD<TVal> BFAMJIIMLEB, Type FNHABCBCOKP, [Out] TVal EEPLCHCGAIN) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x74C4B50", Offset = "0x74C3F50", VA = "0x1874C4B50")]
	[CompilerGenerated]
	internal static int KEGICLNBIKO(Type LIENINLAGBA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct HEEMCNDKJDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public readonly FKGAJLIKFLF FJKLJIGNJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public readonly string JCPBEOJPLBD;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x74C1010", Offset = "0x74C0410", VA = "0x1874C1010")]
	public HEEMCNDKJDI(string LCINLKMHBAB, FKGAJLIKFLF MHEFEIGPGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x74C0F70", Offset = "0x74C0370", VA = "0x1874C0F70")]
	public string CPOBNMGPJMP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class MDBGEBJHGHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly LIABMCCCGLG IPDPLJNCNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private string ELPGFLLGGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private long? JEKFJEJPGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private long? MCOHJEEJONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? OHJHHFHFIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private string GLFAOGKKNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private KAHPGONBPBJ EFOKHODOCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private long? MCPKBJBGGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private bool LOMMGHKLCBE;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string MFDODBBHGHH
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long MHGHEDHIEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x74CD040", Offset = "0x74CC440", VA = "0x1874CD040")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public long KKAOHBFAEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x74CD570", Offset = "0x74CC970", VA = "0x1874CD570")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public long HKEECABIACF
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x74CCFE0", Offset = "0x74CC3E0", VA = "0x1874CCFE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string NGEMAAEIOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x74CD0A0", Offset = "0x74CC4A0", VA = "0x1874CD0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public KAHPGONBPBJ EJIABAHPCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8F0", Offset = "0x9BDCF0", VA = "0x1809BE8F0")]
		get
		{
			return default(KAHPGONBPBJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x74CCEF0", Offset = "0x74CC2F0", VA = "0x1874CCEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long MMHAJPBKJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x74CD5D0", Offset = "0x74CC9D0", VA = "0x1874CD5D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x74CD750", Offset = "0x74CCB50", VA = "0x1874CD750")]
	[UnityEngine.Scripting.Preserve]
	public MDBGEBJHGHJ([CCLHMIDBCEM(null)] LIABMCCCGLG IPDPLJNCNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x74CCCA0", Offset = "0x74CC0A0", VA = "0x1874CCCA0")]
	private void BPOIIMFAPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x74CD0E0", Offset = "0x74CC4E0", VA = "0x1874CD0E0")]
	public void IPJILHEAGLD(long FJBFONPAOAD, long JOABCKCOFMA, [Optional] long? GMKKKFNECIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x74CD630", Offset = "0x74CCA30", VA = "0x1874CD630")]
	public void OJHPEHEBNKA(long GMKKKFNECIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x74CD6D0", Offset = "0x74CCAD0", VA = "0x1874CD6D0")]
	public void PHMEHHBMIGK(string DKEBEKMOMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x74CC930", Offset = "0x74CBD30", VA = "0x1874CC930")]
	public void BABKMHJOAJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class DJKKOGJAPPD : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct CEEIPLPAOAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public AsyncTaskMethodBuilder<JGPLAGNOLDP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public JGPLAGNOLDP roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public DJKKOGJAPPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private TaskAwaiter<LHBMBLFOLNK.CNEOKBPLDCG<JGPLAGNOLDP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x74D5660", Offset = "0x74D4A60", VA = "0x1874D5660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x74D5A70", Offset = "0x74D4E70", VA = "0x1874D5A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct KNGBGMGMMNO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class BEBOLLPFCIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public JGPLAGNOLDP roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BEBOLLPFCIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x74D5420", Offset = "0x74D4820", VA = "0x1874D5420")]
		internal JGPLAGNOLDP MPBEJFHDAGC(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct PALCCAEPOND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder<LHBMBLFOLNK.CNEOKBPLDCG<JGPLAGNOLDP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public JGPLAGNOLDP roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public DJKKOGJAPPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private JONDGCMMCKA <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<LHBMBLFOLNK.CNEOKBPLDCG<JGPLAGNOLDP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x74E9CD0", Offset = "0x74E90D0", VA = "0x1874E9CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x74EA2E0", Offset = "0x74E96E0", VA = "0x1874EA2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct LMKDFEHEAND<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public DJKKOGJAPPD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x45E2640", Offset = "0x45E1A40", VA = "0x1845E2640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x38768C0", Offset = "0x3875CC0", VA = "0x1838768C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct DJHBBGMFENE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public DJKKOGJAPPD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x74D7DD0", Offset = "0x74D71D0", VA = "0x1874D7DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x74D7F90", Offset = "0x74D7390", VA = "0x1874D7F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class CPIANHFKGBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public CPIANHFKGBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x74D77B0", Offset = "0x74D6BB0", VA = "0x1874D77B0")]
		internal object MINDAHHGJOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x74D76F0", Offset = "0x74D6AF0", VA = "0x1874D76F0")]
		internal bool DDHJCIJIPIL(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class APHDCOEFNKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public APHDCOEFNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x74D4D20", Offset = "0x74D4120", VA = "0x1874D4D20")]
		internal object EKGFPAJJCBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class NILPMEIPACC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public NILPMEIPACC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x74E6100", Offset = "0x74E5500", VA = "0x1874E6100")]
		internal object LPPGHCKBIIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class LIIJGNHKAKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LIIJGNHKAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x74E2E90", Offset = "0x74E2290", VA = "0x1874E2E90")]
		internal object ACJALIPBEIJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class OKDCKGLPEOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public DJKKOGJAPPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public OKDCKGLPEOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x74E9930", Offset = "0x74E8D30", VA = "0x1874E9930")]
		internal object HDIMLIILBOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private static readonly Guid FHLCPKGKADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly NEGLAKONOOF MKKFEHGOENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly LHBMBLFOLNK IFGLIFIBMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly KFEDDHBCGFG BHLNPLGEMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly ALHFIOHELPK HKEAOKHOACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private bool EAAPDNMKBIE;

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x74BE0D0", Offset = "0x74BD4D0", VA = "0x1874BE0D0")]
	public DJKKOGJAPPD(NEGLAKONOOF DJJCJPCNFNK, LHBMBLFOLNK IFGLIFIBMBL, KFEDDHBCGFG BHLNPLGEMCN, ALHFIOHELPK HKEAOKHOACM, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x74BCFF0", Offset = "0x74BC3F0", VA = "0x1874BCFF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x74BCFF0", Offset = "0x74BC3F0", VA = "0x1874BCFF0")]
	public void BAJBGDGNEHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x74BDA80", Offset = "0x74BCE80", VA = "0x1874BDA80")]
	public void KNOBOAENPGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x74BD7F0", Offset = "0x74BCBF0", VA = "0x1874BD7F0")]
	public void HGOGPLBNLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x74BDE00", Offset = "0x74BD200", VA = "0x1874BDE00")]
	[AsyncStateMachine(typeof(CEEIPLPAOAK))]
	internal Task<JGPLAGNOLDP> PIBPAPFOCDG(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, JGPLAGNOLDP HGICJMFBBEE, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2CA31E0", Offset = "0x2CA25E0", VA = "0x182CA31E0")]
	private static byte[] KEAHPICMMKJ<T>(T MOKGCFCFCPE) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2CA31F0", Offset = "0x2CA25F0", VA = "0x182CA31F0")]
	private static T MLLADIMBJDD<T>(MessageParser<T> APABPEFHAHN, byte[] MOKGCFCFCPE, T APPGEEMEONO) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x74BD530", Offset = "0x74BC930", VA = "0x1874BD530")]
	[AsyncStateMachine(typeof(PALCCAEPOND))]
	private Task<LHBMBLFOLNK.CNEOKBPLDCG<JGPLAGNOLDP>> FEPDIJLBIFJ(JGPLAGNOLDP HGICJMFBBEE, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2BC0", Offset = "0x2CA1FC0", VA = "0x182CA2BC0")]
	[AsyncStateMachine(typeof(LMKDFEHEAND<>))]
	internal Task<T> BDABNIJPLKC<T>(CancellationToken DAMMAGNLMMI, Func<CancellationToken, Task<T>> PHMMJPJJMGH, int COPOHFAGFBB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x74BD110", Offset = "0x74BC510", VA = "0x1874BD110")]
	[AsyncStateMachine(typeof(DJHBBGMFENE))]
	internal Task BDABNIJPLKC(CancellationToken DAMMAGNLMMI, Func<CancellationToken, Task> PHMMJPJJMGH, int COPOHFAGFBB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x74BD240", Offset = "0x74BC640", VA = "0x1874BD240")]
	public LPJBLPKFEAL CJHCIIFBHHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x74BDD80", Offset = "0x74BD180", VA = "0x1874BDD80")]
	public IJMPCJAGGFD OBHLOGHMMDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x74BD670", Offset = "0x74BCA70", VA = "0x1874BD670")]
	public AKCMKPCICCG GJILGEFGOLD([Optional] FLILHMOBPPM? APPINHJJCPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x74BD3D0", Offset = "0x74BC7D0", VA = "0x1874BD3D0")]
	public void EBGMGLPFHNB(Func<Guid, bool> PDOLCPJNKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x74BDC70", Offset = "0x74BD070", VA = "0x1874BDC70")]
	public void MNIDLHOILFK(Func<Guid, bool> NIAIJCOALNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x74BD900", Offset = "0x74BCD00", VA = "0x1874BD900")]
	public Guid KDLLGLFECJG()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x74BD2C0", Offset = "0x74BC6C0", VA = "0x1874BD2C0")]
	public void CPLLNLEAIPA(Guid BBBHLNJPLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x74BDB40", Offset = "0x74BCF40", VA = "0x1874BDB40")]
	public void KOEABGFOBFB(JGPLAGNOLDP OCGPCJGAILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x74BDF60", Offset = "0x74BD360", VA = "0x1874BDF60")]
	public void PKELKJJEMAA(string LGJIOPIOBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3100", Offset = "0x2CA2500", VA = "0x182CA3100")]
	private T JDIAIJENMGN<T>(T EEPLCHCGAIN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x74BD8B0", Offset = "0x74BCCB0", VA = "0x1874BD8B0")]
	public void IFJELODGJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2E60", Offset = "0x2CA2260", VA = "0x182CA2E60")]
	[CompilerGenerated]
	internal static string IKOKBABKNAJ<T>(byte[] FAHBHOHHIKE, int EOANMDEAJKL, KNGBGMGMMNO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal sealed class HEACNOMIOGB : NEGLAKONOOF
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class OCMKIDFCIHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public OCMKIDFCIHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x74E7DA0", Offset = "0x74E71A0", VA = "0x1874E7DA0")]
		internal object LDLJEKOJOFM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct CHLLCGLNGHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public HEACNOMIOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public DJKKOGJAPPD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private FHICPPGLKDE <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private IJMPCJAGGFD <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x74D62B0", Offset = "0x74D56B0", VA = "0x1874D62B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x74D6B80", Offset = "0x74D5F80", VA = "0x1874D6B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct KALLBAENMMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public HEACNOMIOGB <>4__this;

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
		private TaskAwaiter<JHLHOPAPPOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x74E1EB0", Offset = "0x74E12B0", VA = "0x1874E1EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x74E2650", Offset = "0x74E1A50", VA = "0x1874E2650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct CHPEHBBIODB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public HEACNOMIOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter<OLCMIFIIOEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x74D6BE0", Offset = "0x74D5FE0", VA = "0x1874D6BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x74D6EF0", Offset = "0x74D62F0", VA = "0x1874D6EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class BDKBOEMBGED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public FHICPPGLKDE presence;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BDKBOEMBGED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x74D52E0", Offset = "0x74D46E0", VA = "0x1874D52E0")]
		internal object HCACLNLIIHM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private static readonly FLILHMOBPPM OBOPKNNHEJB;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly FLILHMOBPPM ELJNHEHDJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private readonly HDAMGLELGPE KJLCJOPILHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly IBCLDPKBHMG NCMDGBEJIGD;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x74DBC90", Offset = "0x74DB090", VA = "0x1874DBC90")]
	public HEACNOMIOGB(HDAMGLELGPE KJLCJOPILHD, IBCLDPKBHMG NCMDGBEJIGD, Guid NEMMHGGPCGF, OEHIJBIKFHD LHLCJGLEKJD, BEKGAEBGDOP GLJIFCIPEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x74DB6A0", Offset = "0x74DAAA0", VA = "0x1874DB6A0", Slot = "7")]
	[AsyncStateMachine(typeof(CHLLCGLNGHE))]
	protected override Task BEMPBCHMMEA(DJKKOGJAPPD DONMHGDIMAA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x74DBAC0", Offset = "0x74DAEC0", VA = "0x1874DBAC0")]
	[AsyncStateMachine(typeof(KALLBAENMMO))]
	private Task MPFLDMDHGPH(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x74DB9B0", Offset = "0x74DADB0", VA = "0x1874DB9B0")]
	[AsyncStateMachine(typeof(CHPEHBBIODB))]
	private Task<int> KKGCJJPGFDD(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x74DB7E0", Offset = "0x74DABE0", VA = "0x1874DB7E0")]
	private FHICPPGLKDE IKLACGKIBJD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class NJNLFKIHDFJ : NEGLAKONOOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct NLNNPHMJHNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public NJNLFKIHDFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public DJKKOGJAPPD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private TaskAwaiter<GKKCGGKMNLI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x74E63C0", Offset = "0x74E57C0", VA = "0x1874E63C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x74E6D60", Offset = "0x74E6160", VA = "0x1874E6D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private readonly int NHIPJCJECAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private readonly CCFOBHEPCIJ KCNCGGGONPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public readonly long LMAPJLOLJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public readonly long OEBIIDGDJHO;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public GKKCGGKMNLI GAJPGAAGOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC80", Offset = "0x8AF080", VA = "0x1808AFC80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB50", Offset = "0x8AEF50", VA = "0x1808AFB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x74E6290", Offset = "0x74E5690", VA = "0x1874E6290")]
	public NJNLFKIHDFJ(Guid NEMMHGGPCGF, OEHIJBIKFHD LHLCJGLEKJD, BEKGAEBGDOP GLJIFCIPEAA, int NHIPJCJECAD, CCFOBHEPCIJ KCNCGGGONPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x74E6170", Offset = "0x74E5570", VA = "0x1874E6170", Slot = "7")]
	[AsyncStateMachine(typeof(NLNNPHMJHNK))]
	protected override Task BEMPBCHMMEA(DJKKOGJAPPD DONMHGDIMAA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class EDJIAICJLKL : NEGLAKONOOF
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class DHNALALMKNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public EDJIAICJLKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public OMAFNOJNOMM playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public DHNALALMKNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x74D7810", Offset = "0x74D6C10", VA = "0x1874D7810")]
		internal Task FPKJHNLOOHP(OGAFCBAEIIJ<string>.DDIOHHJLGKB postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x74D7850", Offset = "0x74D6C50", VA = "0x1874D7850")]
		internal object GMOBJDMPBHN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct NGPANIGHEPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public EDJIAICJLKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public DJKKOGJAPPD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private DHNALALMKNB <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x74E58E0", Offset = "0x74E4CE0", VA = "0x1874E58E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x74E60A0", Offset = "0x74E54A0", VA = "0x1874E60A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct KMDNBLJEDMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public OMAFNOJNOMM playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public EDJIAICJLKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x74E27D0", Offset = "0x74E1BD0", VA = "0x1874E27D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x74E2D70", Offset = "0x74E2170", VA = "0x1874E2D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x74D8F20", Offset = "0x74D8320", VA = "0x1874D8F20")]
	public EDJIAICJLKL(Guid NEMMHGGPCGF, OEHIJBIKFHD LHLCJGLEKJD, BEKGAEBGDOP GLJIFCIPEAA, string NOBOAELJBLI, OGMAIFHDKJN EHKGKLDGEHA, bool IMMIDMMLAFE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x74D8CA0", Offset = "0x74D80A0", VA = "0x1874D8CA0", Slot = "7")]
	[AsyncStateMachine(typeof(NGPANIGHEPH))]
	protected override Task BEMPBCHMMEA(DJKKOGJAPPD DONMHGDIMAA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task DLBDDAOICLE(DJKKOGJAPPD DONMHGDIMAA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x74D8DE0", Offset = "0x74D81E0", VA = "0x1874D8DE0")]
	[AsyncStateMachine(typeof(KMDNBLJEDMM))]
	private Task IJOLIAOHLBP(IDisposable NLFHBAAKKMH, OMAFNOJNOMM GHJHJKEIMMP, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class PMGAJPAGFAF : NEGLAKONOOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct EKMHJIPJOPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public PMGAJPAGFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public DJKKOGJAPPD operationContext;

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
		private TaskAwaiter<MFIELAJAPOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x74D8F70", Offset = "0x74D8370", VA = "0x1874D8F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x74D94E0", Offset = "0x74D88E0", VA = "0x1874D94E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly HIHOCJFOCEE DFAEMLMEJNM;

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x74EAF40", Offset = "0x74EA340", VA = "0x1874EAF40")]
	public PMGAJPAGFAF(Guid NEMMHGGPCGF, OEHIJBIKFHD LHLCJGLEKJD, BEKGAEBGDOP GLJIFCIPEAA, HIHOCJFOCEE DFAEMLMEJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x74EAE60", Offset = "0x74EA260", VA = "0x1874EAE60", Slot = "6")]
	protected override string GIMLDNJHNJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x74EAD40", Offset = "0x74EA140", VA = "0x1874EAD40", Slot = "7")]
	[AsyncStateMachine(typeof(EKMHJIPJOPH))]
	protected override Task BEMPBCHMMEA(DJKKOGJAPPD DONMHGDIMAA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal abstract class NEGLAKONOOF : ADPKMNDFFIC
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public delegate Task OLCKCHBIEIJ(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class JNADOAKELOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public NEGLAKONOOF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public JNADOAKELOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x74E0C10", Offset = "0x74E0010", VA = "0x1874E0C10")]
		internal Task JJJNEBAOCLC(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class KOOPMKLJDIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public JNADOAKELOC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KOOPMKLJDIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x74E2DD0", Offset = "0x74E21D0", VA = "0x1874E2DD0")]
		internal object PCAIJGACNCN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct JNONOAKEMEA : IAsyncStateMachine
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
		public NEGLAKONOOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public Func<NEGLAKONOOF, OGAFCBAEIIJ<string>.DDIOHHJLGKB, DJKKOGJAPPD> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private JNADOAKELOC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private DJKKOGJAPPD <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private TaskAwaiter<JGPLAGNOLDP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x74E0D40", Offset = "0x74E0140", VA = "0x1874E0D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x74E1E50", Offset = "0x74E1250", VA = "0x1874E1E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct DNAOCFOGENJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x74D81A0", Offset = "0x74D75A0", VA = "0x1874D81A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x74D8C40", Offset = "0x74D8040", VA = "0x1874D8C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct JBAEPDCNHKM : IAsyncStateMachine
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
		public NEGLAKONOOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x74E0850", Offset = "0x74DFC50", VA = "0x1874E0850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x74E0BB0", Offset = "0x74DFFB0", VA = "0x1874E0BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public readonly Guid OHIHJKBAAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public readonly ByteString JFFBNCGLEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly BEKGAEBGDOP IKDPPPOHKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	protected readonly string MKLMJOGDNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private readonly OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private readonly bool IMMIDMMLAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly Queue<OLCKCHBIEIJ> GNIKFAJOLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly HGBMDJBMOFN CAIHDBBDOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly OGMAIFHDKJN EHKGKLDGEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private bool KEOPGECLKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public KAHPGONBPBJ IOOFHBOKBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public KAHPGONBPBJ FJLKGCCEFDE;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public OEHIJBIKFHD BKNHFCPOMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x8AD870", Offset = "0x8ACC70", VA = "0x1808AD870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public PGLGJBMIFMP CJLPCPGMLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x74E3C00", Offset = "0x74E3000", VA = "0x1874E3C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public MHFFDFOBCLB JJKONAEEKOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x74E41C0", Offset = "0x74E35C0", VA = "0x1874E41C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public GEOGAMGHHBK IJMLIDMBKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x74E3DC0", Offset = "0x74E31C0", VA = "0x1874E3DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event KDLDBEDPPNM ONNPBDAPDLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x74E41A0", Offset = "0x74E35A0", VA = "0x1874E41A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x74E3BE0", Offset = "0x74E2FE0", VA = "0x1874E3BE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x74E4610", Offset = "0x74E3A10", VA = "0x1874E4610")]
	protected NEGLAKONOOF(Guid NEMMHGGPCGF, OEHIJBIKFHD LHLCJGLEKJD, BEKGAEBGDOP GLJIFCIPEAA, string NOBOAELJBLI, OGMAIFHDKJN EHKGKLDGEHA, bool IMMIDMMLAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x74E4160", Offset = "0x74E3560", VA = "0x1874E4160", Slot = "6")]
	protected virtual string GIMLDNJHNJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x74E45B0", Offset = "0x74E39B0", VA = "0x1874E45B0")]
	public void MHKPHDMIPOM(OLCKCHBIEIJ JJDNJMKEDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x74E40C0", Offset = "0x74E34C0", VA = "0x1874E40C0")]
	protected void GBCPBAGCEEM(float KKPMNJCHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x74E3F70", Offset = "0x74E3370", VA = "0x1874E3F70")]
	[AsyncStateMachine(typeof(JNONOAKEMEA))]
	public Task EPAPKGBPEKK(CancellationToken NBBCMDKGJKI, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, [Optional] Func<NEGLAKONOOF, OGAFCBAEIIJ<string>.DDIOHHJLGKB, DJKKOGJAPPD> EEDBAHGNBCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x74E3E40", Offset = "0x74E3240", VA = "0x1874E3E40")]
	[AsyncStateMachine(typeof(DNAOCFOGENJ))]
	private static Task DLPFEJAFAEM(Func<CancellationToken, Task> KHDCLPFFMBK, Func<CancellationToken, Task> BBCHADHJCJO, CancellationToken DAMMAGNLMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x74E3C50", Offset = "0x74E3050", VA = "0x1874E3C50")]
	private void BFGLDOPBMIC(bool KDJCPPCLCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x74E43B0", Offset = "0x74E37B0", VA = "0x1874E43B0")]
	private void MFPFFAILOHK(DJKKOGJAPPD DONMHGDIMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task BEMPBCHMMEA(DJKKOGJAPPD DONMHGDIMAA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x74E4290", Offset = "0x74E3690", VA = "0x1874E4290")]
	[AsyncStateMachine(typeof(JBAEPDCNHKM))]
	private Task LHJONEBEPIC(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x74E40E0", Offset = "0x74E34E0", VA = "0x1874E40E0")]
	public JGPLAGNOLDP GEBCGLLCANG(JONDGCMMCKA ILILEAGKBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x74E44C0", Offset = "0x74E38C0", VA = "0x1874E44C0")]
	[CompilerGenerated]
	private Task MHACCAKADIB(CancellationToken KBFPLGGGODF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x74E4210", Offset = "0x74E3610", VA = "0x1874E4210")]
	[CompilerGenerated]
	private object IOOMEFELGMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal sealed class MEAHKIDKFIN : EDJIAICJLKL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct MIHMOHFIFCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public MEAHKIDKFIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public DJKKOGJAPPD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private EALNFCKLDEO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private IJMPCJAGGFD <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x74E3100", Offset = "0x74E2500", VA = "0x1874E3100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x74E3870", Offset = "0x74E2C70", VA = "0x1874E3870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private readonly HDAMGLELGPE HLHJLJAAJCL;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x74E3050", Offset = "0x74E2450", VA = "0x1874E3050")]
	public MEAHKIDKFIN(Guid NEMMHGGPCGF, OEHIJBIKFHD LHLCJGLEKJD, HDAMGLELGPE HLHJLJAAJCL, BEKGAEBGDOP GLJIFCIPEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x74E2F00", Offset = "0x74E2300", VA = "0x1874E2F00", Slot = "8")]
	[AsyncStateMachine(typeof(MIHMOHFIFCN))]
	protected override Task DLBDDAOICLE(DJKKOGJAPPD DONMHGDIMAA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class ICGNPHIHIMP : NEGLAKONOOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct JAPBLEIBGOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public ICGNPHIHIMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public DJKKOGJAPPD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private TaskAwaiter<MFIELAJAPOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x74E0440", Offset = "0x74DF840", VA = "0x1874E0440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x74E07F0", Offset = "0x74DFBF0", VA = "0x1874E07F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private readonly string FEMOAECJJKP;

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x74DD270", Offset = "0x74DC670", VA = "0x1874DD270")]
	public ICGNPHIHIMP(Guid NEMMHGGPCGF, OEHIJBIKFHD LHLCJGLEKJD, BEKGAEBGDOP GLJIFCIPEAA, string FEMOAECJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x74DD160", Offset = "0x74DC560", VA = "0x1874DD160", Slot = "7")]
	[AsyncStateMachine(typeof(JAPBLEIBGOP))]
	protected override Task BEMPBCHMMEA(DJKKOGJAPPD DONMHGDIMAA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class FNJCCOEGMMD : EDJIAICJLKL
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class KBFLJLEEGJE
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
			public AsyncTaskMethodBuilder<JGPLAGNOLDP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public KBFLJLEEGJE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<MFIELAJAPOD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			private TaskAwaiter<JGPLAGNOLDP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x74ECB00", Offset = "0x74EBF00", VA = "0x1874ECB00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x74ECFC0", Offset = "0x74EC3C0", VA = "0x1874ECFC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public FNJCCOEGMMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public AKCMKPCICCG serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public BNMBFPNEDMN roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public LPJBLPKFEAL uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public PMFOLCAOADP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KBFLJLEEGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x74E26B0", Offset = "0x74E1AB0", VA = "0x1874E26B0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<JGPLAGNOLDP> MIBELCJBLKK(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct NNLCALAIEJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public FNJCCOEGMMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public DJKKOGJAPPD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private KBFLJLEEGJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private EALNFCKLDEO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private IJMPCJAGGFD <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private JGPLAGNOLDP <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter<JGPLAGNOLDP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x74E6DC0", Offset = "0x74E61C0", VA = "0x1874E6DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x74E7D40", Offset = "0x74E7140", VA = "0x1874E7D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private static readonly FLILHMOBPPM OBOPKNNHEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly int PEOKACJCKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	[CanBeNull]
	private readonly OCPEFMIEHAN HCNGLCOMFAN;

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x74D9A00", Offset = "0x74D8E00", VA = "0x1874D9A00")]
	public FNJCCOEGMMD(Guid NEMMHGGPCGF, OEHIJBIKFHD LHLCJGLEKJD, int PEOKACJCKGE, OCPEFMIEHAN HCNGLCOMFAN, BEKGAEBGDOP GLJIFCIPEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x74D9710", Offset = "0x74D8B10", VA = "0x1874D9710", Slot = "8")]
	[AsyncStateMachine(typeof(NNLCALAIEJE))]
	protected override Task DLBDDAOICLE(DJKKOGJAPPD DONMHGDIMAA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x74D9850", Offset = "0x74D8C50", VA = "0x1874D9850")]
	private void INPMDGOHINK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x74D9540", Offset = "0x74D8940", VA = "0x1874D9540")]
	private void AEFFFOALFBM(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, EALNFCKLDEO IMCPDPDEAID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal abstract class BFFAIILPGFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public readonly NEGLAKONOOF MKKFEHGOENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public readonly DJKKOGJAPPD NHGLNAMJGOM;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public PGLGJBMIFMP CJLPCPGMLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x74D5500", Offset = "0x74D4900", VA = "0x1874D5500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public GEOGAMGHHBK IJMLIDMBKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x74D5550", Offset = "0x74D4950", VA = "0x1874D5550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x74D5600", Offset = "0x74D4A00", VA = "0x1874D5600")]
	protected BFFAIILPGFG(DJKKOGJAPPD DONMHGDIMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x74D55E0", Offset = "0x74D49E0", VA = "0x1874D55E0")]
	protected void PKELKJJEMAA(string LGJIOPIOBAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct IHFOPKOBJND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public Dictionary<Guid, List<HIIEHPJKCJC>> GNBDFFFKBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public Dictionary<Guid, List<HIIEHPJKCJC>> CLCNEKIIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<HIIEHPJKCJC>> PHJBFPALPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public List<Guid> IOGDCNLFIBE;

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x74DD320", Offset = "0x74DC720", VA = "0x1874DD320")]
	public static IHFOPKOBJND CADKKGPFCDD(PGLGJBMIFMP BLDEOEOIGBD, KAHPGONBPBJ FEFACIMNDGF, LMMLJLDDCAM JINMCGDCFPF)
	{
		return default(IHFOPKOBJND);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct GBFPDAMIGCH
{
	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0")]
	public static GBFPDAMIGCH JMOKCOIDHBC()
	{
		return default(GBFPDAMIGCH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct AMCGBCFAKGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public readonly JHLHOPAPPOB FHMHFLLLJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public readonly CNPCHHCCLAA BGCEAPKPICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly string AIFCIFFNDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly OJGEAFAKANE JMBCEPAOBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly OJGEAFAKANE BFPGKAHKOPK;

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x74D4CA0", Offset = "0x74D40A0", VA = "0x1874D4CA0")]
	public AMCGBCFAKGD(JHLHOPAPPOB FHMHFLLLJOO, CNPCHHCCLAA BGCEAPKPICL, string AIFCIFFNDFH, OJGEAFAKANE JMBCEPAOBOI, OJGEAFAKANE BFPGKAHKOPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct DKOBHELJFLB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private readonly DJKKOGJAPPD DONMHGDIMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private readonly Guid BBBHLNJPLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private bool KDJCPPCLCIG;

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x74D8050", Offset = "0x74D7450", VA = "0x1874D8050")]
	public static DKOBHELJFLB KDLLGLFECJG(DJKKOGJAPPD DONMHGDIMAA)
	{
		return default(DKOBHELJFLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0xC67C10", Offset = "0xC67010", VA = "0x180C67C10")]
	public void IDIHCENJGDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x74D7FF0", Offset = "0x74D73F0", VA = "0x1874D7FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x74D8150", Offset = "0x74D7550", VA = "0x1874D8150")]
	private DKOBHELJFLB(DJKKOGJAPPD DONMHGDIMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x74D7FF0", Offset = "0x74D73F0", VA = "0x1874D7FF0")]
	private void CPLLNLEAIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x74D80B0", Offset = "0x74D74B0", VA = "0x1874D80B0")]
	private Func<Guid, bool> NHCJFNJIKIK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class IJMPCJAGGFD : BFFAIILPGFG, ADPKMNDFFIC
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public delegate Task<KAHPGONBPBJ> AIAMPNPDJPG(LMMLJLDDCAM AIKOCCMKKAE, MOMKGMJECNP HKMKICMIIOJ, HGBMDJBMOFN MMOBDIJMACN, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct CHBABGFDIPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public HDAMGLELGPE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private DKOBHELJFLB <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private TaskAwaiter<JGPLAGNOLDP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x74D5AE0", Offset = "0x74D4EE0", VA = "0x1874D5AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x74D6250", Offset = "0x74D5650", VA = "0x1874D6250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct HEOOCJNAICD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public AsyncTaskMethodBuilder<JGPLAGNOLDP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public HDAMGLELGPE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private TaskAwaiter<JGPLAGNOLDP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x74DBE20", Offset = "0x74DB220", VA = "0x1874DBE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x74DC250", Offset = "0x74DB650", VA = "0x1874DC250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct DIBBEHAGHMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public HDAMGLELGPE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x74D78E0", Offset = "0x74D6CE0", VA = "0x1874D78E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x74D7D70", Offset = "0x74D7170", VA = "0x1874D7D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class BCHAOKOEDHF
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
			public AsyncTaskMethodBuilder<AMCGBCFAKGD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public BCHAOKOEDHF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private AMCGBCFAKGD <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private TaskAwaiter<KAHPGONBPBJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private TaskAwaiter<AMCGBCFAKGD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x74EB5A0", Offset = "0x74EA9A0", VA = "0x1874EB5A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x74EBD40", Offset = "0x74EB140", VA = "0x1874EBD40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<LMMLJLDDCAM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public BCHAOKOEDHF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private LMMLJLDDCAM <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter<KAHPGONBPBJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter<LMMLJLDDCAM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x74EBDB0", Offset = "0x74EB1B0", VA = "0x1874EBDB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x74EC400", Offset = "0x74EB800", VA = "0x1874EC400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public HDAMGLELGPE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public HGBMDJBMOFN preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public HGBMDJBMOFN downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public AMCGBCFAKGD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public HGBMDJBMOFN postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public LMMLJLDDCAM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public CAJPIEMLHHH.IKFJJLKJLBB <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BCHAOKOEDHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x74D4EE0", Offset = "0x74D42E0", VA = "0x1874D4EE0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<AMCGBCFAKGD> HAJGIDALLMI(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x74D5020", Offset = "0x74D4420", VA = "0x1874D5020")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<LMMLJLDDCAM> JAMGOCOKNMD(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x74D52A0", Offset = "0x74D46A0", VA = "0x1874D52A0")]
		internal void OJAOJCNPAHB(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x74D4D80", Offset = "0x74D4180", VA = "0x1874D4D80")]
		internal Task DCGOGDBNPJI(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x74D5140", Offset = "0x74D4540", VA = "0x1874D5140")]
		internal Task NCJPGAOCAEM(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct HNEPBDOGMMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public HDAMGLELGPE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private BCHAOKOEDHF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter<AMCGBCFAKGD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter<LMMLJLDDCAM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x74DC2C0", Offset = "0x74DB6C0", VA = "0x1874DC2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x74DCFE0", Offset = "0x74DC3E0", VA = "0x1874DCFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct OIDCLCFFNBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public LMMLJLDDCAM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public HGBMDJBMOFN postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private TaskAwaiter<KAHPGONBPBJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private MOMKGMJECNP <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x74E89B0", Offset = "0x74E7DB0", VA = "0x1874E89B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x74E98D0", Offset = "0x74E8CD0", VA = "0x1874E98D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct GNCMNJOACPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x74DAD80", Offset = "0x74DA180", VA = "0x1874DAD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x74DB640", Offset = "0x74DAA40", VA = "0x1874DB640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct PKHNCLEMIIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public HGBMDJBMOFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private TaskAwaiter<KAHPGONBPBJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x74EA350", Offset = "0x74E9750", VA = "0x1874EA350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x74EACE0", Offset = "0x74EA0E0", VA = "0x1874EACE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct GJEFEAOLGNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AsyncTaskMethodBuilder<KAHPGONBPBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public HGBMDJBMOFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private TaskAwaiter<KAHPGONBPBJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x74D9D30", Offset = "0x74D9130", VA = "0x1874D9D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x74DAD10", Offset = "0x74DA110", VA = "0x1874DAD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct NFFIBADOFAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public AsyncTaskMethodBuilder<KAHPGONBPBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public HGBMDJBMOFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public MOMKGMJECNP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter<KAHPGONBPBJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x74E4770", Offset = "0x74E3B70", VA = "0x1874E4770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x74E5870", Offset = "0x74E4C70", VA = "0x1874E5870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct MMCAKEPCBPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder<KAHPGONBPBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public KAHPGONBPBJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public HGBMDJBMOFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public LMMLJLDDCAM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter<KAHPGONBPBJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x74E38D0", Offset = "0x74E2CD0", VA = "0x1874E38D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x74E3B70", Offset = "0x74E2F70", VA = "0x1874E3B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class IBIOCBLHGOM
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
			public AsyncTaskMethodBuilder<KAHPGONBPBJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public IBIOCBLHGOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			private GADNJKDCJGL <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private TaskAwaiter<KAHPGONBPBJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0x74EC470", Offset = "0x74EB870", VA = "0x1874EC470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x74ECA90", Offset = "0x74EBE90", VA = "0x1874ECA90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public HGBMDJBMOFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public AIAMPNPDJPG masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public MOMKGMJECNP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public KAHPGONBPBJ originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public IBIOCBLHGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x74DD040", Offset = "0x74DC440", VA = "0x1874DD040")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<KAHPGONBPBJ> BLBDBAIDNCN(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct COHDNMLINKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public AsyncTaskMethodBuilder<KAHPGONBPBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public HGBMDJBMOFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public AIAMPNPDJPG masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public MOMKGMJECNP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<KAHPGONBPBJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x74D7160", Offset = "0x74D6560", VA = "0x1874D7160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x74D7680", Offset = "0x74D6A80", VA = "0x1874D7680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct PMNGIJJPAEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public HGBMDJBMOFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private KAHPGONBPBJ <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private IEnumerator<KAHPGONBPBJ> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private TaskAwaiter<KAHPGONBPBJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x74EAFE0", Offset = "0x74EA3E0", VA = "0x1874EAFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x74EB540", Offset = "0x74EA940", VA = "0x1874EB540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct FNMPNBCNCKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x74D9AB0", Offset = "0x74D8EB0", VA = "0x1874D9AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x74D9CD0", Offset = "0x74D90D0", VA = "0x1874D9CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct CJJGOBCKPAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x74D6F60", Offset = "0x74D6360", VA = "0x1874D6F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x74D7100", Offset = "0x74D6500", VA = "0x1874D7100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct IOGIINPLPCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public LMMLJLDDCAM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public HGBMDJBMOFN postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter<KAHPGONBPBJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private MOMKGMJECNP <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x74DF4C0", Offset = "0x74DE8C0", VA = "0x1874DF4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x74E03E0", Offset = "0x74DF7E0", VA = "0x1874E03E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct OFAOGLMEIFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public AsyncTaskMethodBuilder<KAHPGONBPBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public IJMPCJAGGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public HGBMDJBMOFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter<KAHPGONBPBJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x74E7E10", Offset = "0x74E7210", VA = "0x1874E7E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x74E8940", Offset = "0x74E7D40", VA = "0x1874E8940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly DDAANIDIMGM GBLPAPPILOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly DDAANIDIMGM HOKPKFMJAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly MDBGEBJHGHJ FENKJMGGEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly NGMBBKMGECK KBBMCGPNBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly NHOIFAEMLPI LALKDIHKGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private ProfilerCounterValue<int> OHNEHFJHPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly GPJADLBIKFB FBIGAKGMIJF;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private OEHIJBIKFHD BKNHFCPOMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x74DEC10", Offset = "0x74DE010", VA = "0x1874DEC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event KDLDBEDPPNM ONNPBDAPDLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x74DE740", Offset = "0x74DDB40", VA = "0x1874DE740", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x74DD920", Offset = "0x74DCD20", VA = "0x1874DD920", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x74DF1F0", Offset = "0x74DE5F0", VA = "0x1874DF1F0")]
	public IJMPCJAGGFD(DJKKOGJAPPD DONMHGDIMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x74DDDD0", Offset = "0x74DD1D0", VA = "0x1874DDDD0")]
	[AsyncStateMachine(typeof(CHBABGFDIPG))]
	public Task COJHGFNFDLO(HDAMGLELGPE BCGNIJHEBIO, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x74DE760", Offset = "0x74DDB60", VA = "0x1874DE760")]
	[AsyncStateMachine(typeof(HEOOCJNAICD))]
	private Task<JGPLAGNOLDP> JFJJPIKMBKP(HDAMGLELGPE BCGNIJHEBIO, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x74DE600", Offset = "0x74DDA00", VA = "0x1874DE600")]
	[AsyncStateMachine(typeof(DIBBEHAGHMH))]
	private Task IHBGNPJFJEM(HDAMGLELGPE BCGNIJHEBIO, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x74DE920", Offset = "0x74DDD20", VA = "0x1874DE920")]
	[AsyncStateMachine(typeof(HNEPBDOGMMB))]
	private Task KLIAAKILLDK(HDAMGLELGPE BCGNIJHEBIO, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken FCDGJJCBDDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x74DDF60", Offset = "0x74DD360", VA = "0x1874DDF60")]
	[AsyncStateMachine(typeof(OIDCLCFFNBK))]
	private Task GHMKEGNLKOO(LMMLJLDDCAM BIJLICMGMLJ, HGBMDJBMOFN PELGGPJBIEK, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken HLLGIEODBNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x74DEE20", Offset = "0x74DE220", VA = "0x1874DEE20")]
	[AsyncStateMachine(typeof(GNCMNJOACPN))]
	private Task OCJNMDMFHED(OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x74DE240", Offset = "0x74DD640", VA = "0x1874DE240")]
	[AsyncStateMachine(typeof(PKHNCLEMIIG))]
	private Task IBJEMOLCAHN(LMMLJLDDCAM AIKOCCMKKAE, HGBMDJBMOFN MMOBDIJMACN, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x74DDC50", Offset = "0x74DD050", VA = "0x1874DDC50")]
	[AsyncStateMachine(typeof(GJEFEAOLGNH))]
	private Task<KAHPGONBPBJ> CDOJLPDCNCB(LMMLJLDDCAM AIKOCCMKKAE, MOMKGMJECNP IAHAEKGJFCB, HGBMDJBMOFN MMOBDIJMACN, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x74DE480", Offset = "0x74DD880", VA = "0x1874DE480")]
	[AsyncStateMachine(typeof(NFFIBADOFAI))]
	private Task<KAHPGONBPBJ> IDHLOPCOGEM(LMMLJLDDCAM AIKOCCMKKAE, MOMKGMJECNP IAHAEKGJFCB, HGBMDJBMOFN MMOBDIJMACN, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x74DDAD0", Offset = "0x74DCED0", VA = "0x1874DDAD0")]
	[AsyncStateMachine(typeof(MMCAKEPCBPG))]
	private Task<KAHPGONBPBJ> BHFLEJBDILC(KAHPGONBPBJ FEFACIMNDGF, LMMLJLDDCAM JINMCGDCFPF, HGBMDJBMOFN MMOBDIJMACN, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI, bool JOILGMMCGBM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x74DE390", Offset = "0x74DD790", VA = "0x1874DE390")]
	private bool IBMDADAENJP(LMMLJLDDCAM BIJLICMGMLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x74DEC80", Offset = "0x74DE080", VA = "0x1874DEC80")]
	[AsyncStateMachine(typeof(COHDNMLINKO))]
	protected Task<KAHPGONBPBJ> NFALCDLMDGE(LMMLJLDDCAM AIKOCCMKKAE, MOMKGMJECNP IAHAEKGJFCB, HGBMDJBMOFN MMOBDIJMACN, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI, AIAMPNPDJPG LICCAAELEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x74DD980", Offset = "0x74DCD80", VA = "0x1874DD980")]
	[AsyncStateMachine(typeof(PMNGIJJPAEM))]
	private Task APGMLNBGKKG(LMMLJLDDCAM AIKOCCMKKAE, HGBMDJBMOFN MMOBDIJMACN, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x74DF170", Offset = "0x74DE570", VA = "0x1874DF170")]
	private void PCDMLNJPOOI(KAHPGONBPBJ EAJGJHLDOOA, HGBMDJBMOFN MMOBDIJMACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x74DE8E0", Offset = "0x74DDCE0", VA = "0x1874DE8E0")]
	private void KJKHEECJEJJ(KAHPGONBPBJ MGLDAKEJGAF, [Out] KAHPGONBPBJ LKGNLMLJCLP, [Out] KAHPGONBPBJ GMKELKEPABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x74DEC40", Offset = "0x74DE040", VA = "0x1874DEC40")]
	private Task<AMCGBCFAKGD> NBBBPJBEPBH(HDAMGLELGPE BCGNIJHEBIO, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x74DD940", Offset = "0x74DCD40", VA = "0x1874DD940")]
	private Task<LMMLJLDDCAM> AJLBOFHIPMJ(AMCGBCFAKGD AIKOCCMKKAE, CAJPIEMLHHH.IKFJJLKJLBB ILCNGDAPFGA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x74DF020", Offset = "0x74DE420", VA = "0x1874DF020")]
	[AsyncStateMachine(typeof(FNMPNBCNCKH))]
	private Task ONMDEBBHGCC(LMMLJLDDCAM AIKOCCMKKAE, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI, bool DHODAAHOPPI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x74DEF30", Offset = "0x74DE330", VA = "0x1874DEF30")]
	[AsyncStateMachine(typeof(CJJGOBCKPAA))]
	private Task OHMAIELIHCJ(LMMLJLDDCAM AIKOCCMKKAE, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x74DF1C0", Offset = "0x74DE5C0", VA = "0x1874DF1C0")]
	private Task PGJDFEEJNGO(LMMLJLDDCAM AIKOCCMKKAE, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x74DDDB0", Offset = "0x74DD1B0", VA = "0x1874DDDB0")]
	private Task CEOAIFCBKEO(LMMLJLDDCAM AIKOCCMKKAE, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x74DDF40", Offset = "0x74DD340", VA = "0x1874DDF40")]
	private Task GGOBBPBLABC(LMMLJLDDCAM AIKOCCMKKAE, MOMKGMJECNP IAHAEKGJFCB, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x74DE200", Offset = "0x74DD600", VA = "0x1874DE200")]
	private Task HDFNLJHCIOK(LMMLJLDDCAM AIKOCCMKKAE, MOMKGMJECNP IAHAEKGJFCB, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x74DEE10", Offset = "0x74DE210", VA = "0x1874DEE10")]
	private static Task NGDNMFOECNP(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x74DDF20", Offset = "0x74DD320", VA = "0x1874DDF20")]
	private Task EEKCBPMMBIM(LMMLJLDDCAM AIKOCCMKKAE, MOMKGMJECNP IAHAEKGJFCB, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x74DE8C0", Offset = "0x74DDCC0", VA = "0x1874DE8C0")]
	private Task JNLJIMANELD(LMMLJLDDCAM AIKOCCMKKAE, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x74DEBC0", Offset = "0x74DDFC0", VA = "0x1874DEBC0")]
	private void LFDFEKICIEF(HDAMGLELGPE BCGNIJHEBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x74DE220", Offset = "0x74DD620", VA = "0x1874DE220")]
	public void HEHMKPGHGDB(long GMKKKFNECIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	private static void CMBGIFKGJAB(JHLHOPAPPOB FHMHFLLLJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x74DE0B0", Offset = "0x74DD4B0", VA = "0x1874DE0B0")]
	[AsyncStateMachine(typeof(IOGIINPLPCG))]
	private Task HCMDPOBFGGA(LMMLJLDDCAM BIJLICMGMLJ, HGBMDJBMOFN PELGGPJBIEK, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken HLLGIEODBNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x74DEA60", Offset = "0x74DDE60", VA = "0x1874DEA60")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(OFAOGLMEIFN))]
	private Task<KAHPGONBPBJ> LFAEKEAIDOA(LMMLJLDDCAM AIKOCCMKKAE, MOMKGMJECNP IAHAEKGJFCB, HGBMDJBMOFN MMOBDIJMACN, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct OKOAHGGLFNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private LMMLJLDDCAM AIKOCCMKKAE;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private PGLGJBMIFMP CJLPCPGMLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7503650", Offset = "0x7502A50", VA = "0x187503650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x75036A0", Offset = "0x7502AA0", VA = "0x1875036A0")]
	public static Task EPAPKGBPEKK(OEHIJBIKFHD LHLCJGLEKJD, LMMLJLDDCAM AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x7503780", Offset = "0x7502B80", VA = "0x187503780")]
	private void EPAPKGBPEKK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct NCFAFGNMHDM
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x75004D0", Offset = "0x74FF8D0", VA = "0x1875004D0")]
	public static Task EPAPKGBPEKK(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct FDFPMIAEGJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct LDCNHIOHKFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public DJKKOGJAPPD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x74FCDB0", Offset = "0x74FC1B0", VA = "0x1874FCDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x74FD2E0", Offset = "0x74FC6E0", VA = "0x1874FD2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x74F6150", Offset = "0x74F5550", VA = "0x1874F6150")]
	[AsyncStateMachine(typeof(LDCNHIOHKFB))]
	public static Task EPAPKGBPEKK(DJKKOGJAPPD DONMHGDIMAA, LMMLJLDDCAM AIKOCCMKKAE, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct OIPEEGEMCMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct DOELNJEBJOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public DJKKOGJAPPD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public MOMKGMJECNP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private KAHPGONBPBJ <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private OEHIJBIKFHD <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private PGLGJBMIFMP <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private GADNJKDCJGL <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private List<(PersistenceView, DHPBNJJBAKM)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private DHPBNJJBAKM <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x74F2DB0", Offset = "0x74F21B0", VA = "0x1874F2DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x74F3A40", Offset = "0x74F2E40", VA = "0x1874F3A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x7503020", Offset = "0x7502420", VA = "0x187503020")]
	[AsyncStateMachine(typeof(DOELNJEBJOG))]
	public static Task EPAPKGBPEKK(DJKKOGJAPPD DONMHGDIMAA, LMMLJLDDCAM AIKOCCMKKAE, MOMKGMJECNP IAHAEKGJFCB, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x7502E30", Offset = "0x7502230", VA = "0x187502E30")]
	private static void EBJNBAKBIPH(PersistenceView JAACMBBNMFM, DHPBNJJBAKM OHJDHAOMKKE, LMMLJLDDCAM AIKOCCMKKAE, KAHPGONBPBJ FEFACIMNDGF, bool OJMHGECGPLM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct NHNBLMOOHNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct LKCEOJGCIBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public OEHIJBIKFHD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x74FD870", Offset = "0x74FCC70", VA = "0x1874FD870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x74FDCA0", Offset = "0x74FD0A0", VA = "0x1874FDCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x75014F0", Offset = "0x75008F0", VA = "0x1875014F0")]
	[AsyncStateMachine(typeof(LKCEOJGCIBN))]
	public static Task EPAPKGBPEKK(OEHIJBIKFHD LHLCJGLEKJD, LMMLJLDDCAM AIKOCCMKKAE, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct BNMLEFJNPEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct EJGPOBCJEPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public OEHIJBIKFHD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public DJKKOGJAPPD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x74F42E0", Offset = "0x74F36E0", VA = "0x1874F42E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x74F44F0", Offset = "0x74F38F0", VA = "0x1874F44F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class DOGJLILNEKK
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
			public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public DOGJLILNEKK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x7506220", Offset = "0x7505620", VA = "0x187506220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x75065B0", Offset = "0x75059B0", VA = "0x1875065B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public DOGJLILNEKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x74F3AA0", Offset = "0x74F2EA0", VA = "0x1874F3AA0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task OHONEHBOGIC(OGAFCBAEIIJ<string>.DDIOHHJLGKB timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct JGLOHEOCJJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public BNMLEFJNPEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter<JGPLAGNOLDP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x74FAE60", Offset = "0x74FA260", VA = "0x1874FAE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x74FB830", Offset = "0x74FAC30", VA = "0x1874FB830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class GFMJLPGCMDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public JMININFAJOG version;

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
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public GFMJLPGCMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x74F7A40", Offset = "0x74F6E40", VA = "0x1874F7A40")]
		internal object FAKHOGCNHEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x74F7B20", Offset = "0x74F6F20", VA = "0x1874F7B20")]
		internal object MONGGKCMMEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private LMMLJLDDCAM AIKOCCMKKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private DJKKOGJAPPD DONMHGDIMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private bool DHODAAHOPPI;

	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private static readonly ByteString LILDHHHIIFL;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private PGLGJBMIFMP CJLPCPGMLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x74EFEB0", Offset = "0x74EF2B0", VA = "0x1874EFEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private GEOGAMGHHBK IJMLIDMBKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x74EFF00", Offset = "0x74EF300", VA = "0x1874EFF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x74F00E0", Offset = "0x74EF4E0", VA = "0x1874F00E0")]
	[AsyncStateMachine(typeof(EJGPOBCJEPJ))]
	public static Task EPAPKGBPEKK(OEHIJBIKFHD LHLCJGLEKJD, LMMLJLDDCAM AIKOCCMKKAE, DJKKOGJAPPD DONMHGDIMAA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI, bool DHODAAHOPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x74EFFA0", Offset = "0x74EF3A0", VA = "0x1874EFFA0")]
	[AsyncStateMachine(typeof(JGLOHEOCJJN))]
	private Task EPAPKGBPEKK(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x74F0270", Offset = "0x74EF670", VA = "0x1874F0270")]
	private void OAHNHKMBMMI([NotNull] CALEDHBDGGG MHHDOIMHKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x74F0230", Offset = "0x74EF630", VA = "0x1874F0230")]
	private bool HELHMDMJGLF(JMININFAJOG ABNEAOFINHP, CALEDHBDGGG MHHDOIMHKHK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct BOGHFFPNAOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct GMHDOFBFCAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public AsyncTaskMethodBuilder<LMMLJLDDCAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public BOGHFFPNAOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CAJPIEMLHHH.IKFJJLKJLBB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private TaskAwaiter<(LMFFMMPMNDB<NAHMKHNIEGM, CIIOJBGFHGE>, LMFFMMPMNDB<JEHNCKPPEOK<CALEDHBDGGG>, CIIOJBGFHGE>, LMFFMMPMNDB<JEHNCKPPEOK<OMMIODCOJEM>, CIIOJBGFHGE>, LMFFMMPMNDB<JEHNCKPPEOK<DAIGEEMMDMO>, CIIOJBGFHGE>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x74F7D00", Offset = "0x74F7100", VA = "0x1874F7D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x74F87B0", Offset = "0x74F7BB0", VA = "0x1874F87B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct OHKEKPCEFAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<NAHMKHNIEGM, CIIOJBGFHGE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public BOGHFFPNAOB <>4__this;

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
		public CAJPIEMLHHH.IKFJJLKJLBB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter<LMFFMMPMNDB<NAHMKHNIEGM, CIIOJBGFHGE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x75027B0", Offset = "0x7501BB0", VA = "0x1875027B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x7502DC0", Offset = "0x75021C0", VA = "0x187502DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private LKEKLPFEJCA<OJGEAFAKANE, OMMIODCOJEM> EAPFPPGONMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private LKEKLPFEJCA<OJGEAFAKANE, CALEDHBDGGG> CCFOKENAGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private LKEKLPFEJCA<long, DAIGEEMMDMO> DCGJLKNFFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private NOJAIEFCJJK EHEDCLMLDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private JHLHOPAPPOB FHMHFLLLJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private CNPCHHCCLAA BGCEAPKPICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private string AIFCIFFNDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private OJGEAFAKANE JMBCEPAOBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private OJGEAFAKANE BFPGKAHKOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private long GMKKKFNECIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH;

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x74F0CD0", Offset = "0x74F00D0", VA = "0x1874F0CD0")]
	public static Task<LMMLJLDDCAM> MMJOOEINCMM(OEHIJBIKFHD LHLCJGLEKJD, [In] AMCGBCFAKGD AIKOCCMKKAE, CAJPIEMLHHH.IKFJJLKJLBB ILCNGDAPFGA, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x74F0B40", Offset = "0x74EFF40", VA = "0x1874F0B40")]
	[AsyncStateMachine(typeof(GMHDOFBFCAA))]
	private Task<LMMLJLDDCAM> EPAPKGBPEKK(CAJPIEMLHHH.IKFJJLKJLBB ILCNGDAPFGA, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x74F0980", Offset = "0x74EFD80", VA = "0x1874F0980")]
	[AsyncStateMachine(typeof(OHKEKPCEFAD))]
	private Task<LMFFMMPMNDB<NAHMKHNIEGM, CIIOJBGFHGE>> EALIKMLOKKC(string AIFCIFFNDFH, long GMKKKFNECIE, long? FJBFONPAOAD, long? AEGLBCGIGGP, CAJPIEMLHHH.IKFJJLKJLBB ILCNGDAPFGA, OGAFCBAEIIJ<string>.DDIOHHJLGKB LIAHCLIOJKI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct MHHLAMPJHED
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct PNMPDDDGELP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public AsyncTaskMethodBuilder<AMCGBCFAKGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public MHHLAMPJHED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private TaskAwaiter<AMCGBCFAKGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7505880", Offset = "0x7504C80", VA = "0x187505880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7505C90", Offset = "0x7505090", VA = "0x187505C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct KPCLKCNIHLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AsyncTaskMethodBuilder<AMCGBCFAKGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public MHHLAMPJHED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter<AMCGBCFAKGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x74FC420", Offset = "0x74FB820", VA = "0x1874FC420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x74FC850", Offset = "0x74FBC50", VA = "0x1874FC850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class NLBDANGLLML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public NLBDANGLLML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x9A23F0", Offset = "0x9A17F0", VA = "0x1809A23F0")]
		internal bool EPAEDOONMIH(CNPCHHCCLAA sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct FAGMFCANENL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder<AMCGBCFAKGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public OJGEAFAKANE superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public PGLGJBMIFMP callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private NLBDANGLLML <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public KHNJNOGLJKJ roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private JHLHOPAPPOB <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private CNPCHHCCLAA <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private OJGEAFAKANE <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private OJGEAFAKANE <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private TaskAwaiter<JHLHOPAPPOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter<CECCDIADBPO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private TaskAwaiter<OLCMIFIIOEF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x74F4FA0", Offset = "0x74F43A0", VA = "0x1874F4FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x74F60E0", Offset = "0x74F54E0", VA = "0x1874F60E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private PGLGJBMIFMP BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private MDBGEBJHGHJ FENKJMGGEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private KHNJNOGLJKJ HDPKIKEHAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private long FJBFONPAOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private long JOABCKCOFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private long DOFNDHIOLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private string KCGJBHDHJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private OJGEAFAKANE NBHGFCHKBOD;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x74FF840", Offset = "0x74FEC40", VA = "0x1874FF840")]
	public static Task<AMCGBCFAKGD> MMJOOEINCMM(OEHIJBIKFHD LHLCJGLEKJD, HDAMGLELGPE BCGNIJHEBIO, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x74FF6F0", Offset = "0x74FEAF0", VA = "0x1874FF6F0")]
	[AsyncStateMachine(typeof(PNMPDDDGELP))]
	private Task<AMCGBCFAKGD> EPAPKGBPEKK(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x74FFAB0", Offset = "0x74FEEB0", VA = "0x1874FFAB0")]
	[AsyncStateMachine(typeof(KPCLKCNIHLM))]
	private Task<AMCGBCFAKGD> NBBBPJBEPBH(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x74FFC10", Offset = "0x74FF010", VA = "0x1874FFC10")]
	[AsyncStateMachine(typeof(FAGMFCANENL))]
	private static Task<AMCGBCFAKGD> NBBBPJBEPBH(PGLGJBMIFMP BLDEOEOIGBD, KHNJNOGLJKJ HDPKIKEHAMO, long FJBFONPAOAD, long JOABCKCOFMA, long DOFNDHIOLLL, string KCGJBHDHJNA, OJGEAFAKANE NBHGFCHKBOD, CancellationToken NBBCMDKGJKI, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x74FF6C0", Offset = "0x74FEAC0", VA = "0x1874FF6C0")]
	private void BCOBAMOMEHK(JHLHOPAPPOB FHMHFLLLJOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal struct JJGLJNNPCNI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct DEFEMLJENOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public JJGLJNNPCNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x74F2150", Offset = "0x74F1550", VA = "0x1874F2150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x74F26E0", Offset = "0x74F1AE0", VA = "0x1874F26E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private PGLGJBMIFMP BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private LMMLJLDDCAM AIKOCCMKKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private float FKIKDANBKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private float NNBOLDKIKAD;

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x74FBD20", Offset = "0x74FB120", VA = "0x1874FBD20")]
	public static Task NHDINPPPCEJ(OEHIJBIKFHD LHLCJGLEKJD, LMMLJLDDCAM AIKOCCMKKAE, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x74FB890", Offset = "0x74FAC90", VA = "0x1874FB890")]
	[AsyncStateMachine(typeof(DEFEMLJENOJ))]
	public Task EPAPKGBPEKK(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x74FB9B0", Offset = "0x74FADB0", VA = "0x1874FB9B0")]
	private static void FJBFHLPBMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x74FBBC0", Offset = "0x74FAFC0", VA = "0x1874FBBC0")]
	private void NHDGPDJHFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x74FBAE0", Offset = "0x74FAEE0", VA = "0x1874FBAE0")]
	private static float FMEOGPFNFDA(PGLGJBMIFMP BLDEOEOIGBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x74FBBA0", Offset = "0x74FAFA0", VA = "0x1874FBBA0")]
	private static float KBIKHIGAHGN()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct ODDHPHHKNJI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct MFGELGAHLHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public DJKKOGJAPPD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private NEGLAKONOOF <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private OEHIJBIKFHD <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private AICIHMAGLDI.GFCFDFOABNN <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private TaskAwaiter<JGPLAGNOLDP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x74FED00", Offset = "0x74FE100", VA = "0x1874FED00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x74FF520", Offset = "0x74FE920", VA = "0x1874FF520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct FLOODEPEPLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x74F69A0", Offset = "0x74F5DA0", VA = "0x1874F69A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x74F6CD0", Offset = "0x74F60D0", VA = "0x1874F6CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x7502540", Offset = "0x7501940", VA = "0x187502540")]
	[AsyncStateMachine(typeof(MFGELGAHLHG))]
	public static Task EPAPKGBPEKK(DJKKOGJAPPD DONMHGDIMAA, LMMLJLDDCAM AIKOCCMKKAE, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x7502680", Offset = "0x7501A80", VA = "0x187502680")]
	private static Task<JGPLAGNOLDP> FHFCFJCEFPP(DJKKOGJAPPD DONMHGDIMAA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x75026F0", Offset = "0x7501AF0", VA = "0x1875026F0")]
	[AsyncStateMachine(typeof(FLOODEPEPLK))]
	private static Task JEIKPIBEEHO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct ECIPGKMHGKL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct DALPCNIGIDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public ECIPGKMHGKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x74F1A40", Offset = "0x74F0E40", VA = "0x1874F1A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x74F20F0", Offset = "0x74F14F0", VA = "0x1874F20F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class HKBNKHCJCLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public HKBNKHCJCLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x74F90F0", Offset = "0x74F84F0", VA = "0x1874F90F0")]
		internal object MJMJMPOPMLN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct OJEIBJOOEGH : IAsyncStateMachine
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
		public ECIPGKMHGKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x7503170", Offset = "0x7502570", VA = "0x187503170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x75035F0", Offset = "0x75029F0", VA = "0x1875035F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	private bool DEDLIFDJKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	private CancellationToken NBBCMDKGJKI;

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x74F4050", Offset = "0x74F3450", VA = "0x1874F4050")]
	public static Task DKFOCNBEOCM(OEHIJBIKFHD LHLCJGLEKJD, bool DEDLIFDJKCA, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken CFKHGFEFMJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x74F40C0", Offset = "0x74F34C0", VA = "0x1874F40C0")]
	[AsyncStateMachine(typeof(DALPCNIGIDL))]
	private Task EPAPKGBPEKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x74F41B0", Offset = "0x74F35B0", VA = "0x1874F41B0")]
	[AsyncStateMachine(typeof(OJEIBJOOEGH))]
	private Task HELLJKCOFDE(bool MMPGNGKNACF, string HFGPDDPDFCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0")]
	private bool DCPHIBKAHBJ(bool DEDLIFDJKCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct KAKIEFLJPJI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct IEPCABLHIJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public KAKIEFLJPJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x74F9A50", Offset = "0x74F8E50", VA = "0x1874F9A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x74F9FC0", Offset = "0x74F93C0", VA = "0x1874F9FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class MMKMPFJJNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public MMKMPFJJNEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x7500480", Offset = "0x74FF880", VA = "0x187500480")]
		internal object MJMJMPOPMLN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct KPCPFGLPOIB : IAsyncStateMachine
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
		public KAKIEFLJPJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x74FC8C0", Offset = "0x74FBCC0", VA = "0x1874FC8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x74FCD40", Offset = "0x74FC140", VA = "0x1874FCD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private GCLCFNGPMNH HCBGDCFINPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private bool BPHOCOAPJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private LMMLJLDDCAM AIKOCCMKKAE;

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x74FC220", Offset = "0x74FB620", VA = "0x1874FC220")]
	public static Task<Scene> GKOMPCKJCJK(OEHIJBIKFHD LHLCJGLEKJD, GCLCFNGPMNH FAFLDOELENK, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x74FC100", Offset = "0x74FB500", VA = "0x1874FC100")]
	[AsyncStateMachine(typeof(IEPCABLHIJC))]
	private Task<Scene> EPAPKGBPEKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x74FC3F0", Offset = "0x74FB7F0", VA = "0x1874FC3F0")]
	private bool LGNFKHIDGFN(LMMLJLDDCAM AIKOCCMKKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x74FC090", Offset = "0x74FB490", VA = "0x1874FC090")]
	private void EHIKGHJAIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x74FC2A0", Offset = "0x74FB6A0", VA = "0x1874FC2A0")]
	[AsyncStateMachine(typeof(KPCPFGLPOIB))]
	private Task<Scene> HELLJKCOFDE(string HFGPDDPDFCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct NHOIFAEMLPI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct OLIOEDMKOEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder<KAHPGONBPBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public NHOIFAEMLPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public KAHPGONBPBJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public LMMLJLDDCAM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private TaskAwaiter<KAHPGONBPBJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x7503990", Offset = "0x7502D90", VA = "0x187503990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7504490", Offset = "0x7503890", VA = "0x187504490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct MKPIDPEHJOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public AsyncTaskMethodBuilder<KAHPGONBPBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public NHOIFAEMLPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public KAHPGONBPBJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private TaskAwaiter<JGPLAGNOLDP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x7500130", Offset = "0x74FF530", VA = "0x187500130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x7500410", Offset = "0x74FF810", VA = "0x187500410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private readonly DJKKOGJAPPD DONMHGDIMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private readonly MDBGEBJHGHJ FENKJMGGEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private readonly NGMBBKMGECK KBBMCGPNBCP;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private NEGLAKONOOF MKKFEHGOENO
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x5C02EE0", Offset = "0x5C022E0", VA = "0x185C02EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x7501930", Offset = "0x7500D30", VA = "0x187501930")]
	public NHOIFAEMLPI(DJKKOGJAPPD DONMHGDIMAA, MDBGEBJHGHJ FENKJMGGEDL, NGMBBKMGECK KBBMCGPNBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x7501600", Offset = "0x7500A00", VA = "0x187501600")]
	[AsyncStateMachine(typeof(OLIOEDMKOEN))]
	public Task<KAHPGONBPBJ> CKJLGBAIPNC(KAHPGONBPBJ HMMFHKIALBB, LMMLJLDDCAM JINMCGDCFPF, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI, bool JOILGMMCGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x7501780", Offset = "0x7500B80", VA = "0x187501780")]
	[AsyncStateMachine(typeof(MKPIDPEHJOF))]
	private Task<KAHPGONBPBJ> FENMHNLOOKI(OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, KAHPGONBPBJ NMAIGNOENJN, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x75018E0", Offset = "0x7500CE0", VA = "0x1875018E0")]
	private bool MKAEAENNNNK(KAHPGONBPBJ LPHNPPAOOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x7501910", Offset = "0x7500D10", VA = "0x187501910")]
	private void PKELKJJEMAA(string IENFPCFJHIE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct ICKCBKHMNCH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct ICHJIAIBPOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public NEGLAKONOOF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public MOMKGMJECNP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private GADNJKDCJGL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private List<(PersistenceView, DHPBNJJBAKM)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private (PersistenceView, DHPBNJJBAKM) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x74F9260", Offset = "0x74F8660", VA = "0x1874F9260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x74F98B0", Offset = "0x74F8CB0", VA = "0x1874F98B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x74F9910", Offset = "0x74F8D10", VA = "0x1874F9910")]
	[AsyncStateMachine(typeof(ICHJIAIBPOJ))]
	public static Task EPAPKGBPEKK(NEGLAKONOOF DJJCJPCNFNK, LMMLJLDDCAM AIKOCCMKKAE, MOMKGMJECNP IAHAEKGJFCB, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct FLPJLIPNNCP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct IOMCLLLLOIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public NEGLAKONOOF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public MOMKGMJECNP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private JMININFAJOG <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private GADNJKDCJGL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private List<(PersistenceView, DHPBNJJBAKM)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private DHPBNJJBAKM <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x74FA030", Offset = "0x74F9430", VA = "0x1874FA030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x74FA8E0", Offset = "0x74F9CE0", VA = "0x1874FA8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x74F6D30", Offset = "0x74F6130", VA = "0x1874F6D30")]
	[AsyncStateMachine(typeof(IOMCLLLLOIL))]
	public static Task EPAPKGBPEKK(NEGLAKONOOF DJJCJPCNFNK, LMMLJLDDCAM AIKOCCMKKAE, MOMKGMJECNP IAHAEKGJFCB, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct AICIHMAGLDI
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public struct GFCFDFOABNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public List<IPHLLLPPIAH> DFJCAMKEBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public List<DHPBNJJBAKM> EPNMPEHKDPJ;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xD74C00", Offset = "0xD74000", VA = "0x180D74C00")]
		public GFCFDFOABNN(List<IPHLLLPPIAH> DFJCAMKEBJO, List<DHPBNJJBAKM> EPNMPEHKDPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class FGAOKLDCEJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public IEnumerable<IPHLLLPPIAH> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public FGAOKLDCEJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x74F6920", Offset = "0x74F5D20", VA = "0x1874F6920")]
		internal object NMFODKDFMMK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private OEHIJBIKFHD LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000600")]
	private LMMLJLDDCAM AIKOCCMKKAE;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private PGLGJBMIFMP CJLPCPGMLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x74ED370", Offset = "0x74EC770", VA = "0x1874ED370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x74ED3C0", Offset = "0x74EC7C0", VA = "0x1874ED3C0")]
	public static GFCFDFOABNN EPAPKGBPEKK(OEHIJBIKFHD LHLCJGLEKJD, LMMLJLDDCAM AIKOCCMKKAE)
	{
		return default(GFCFDFOABNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x74ED420", Offset = "0x74EC820", VA = "0x1874ED420")]
	private GFCFDFOABNN EPAPKGBPEKK()
	{
		return default(GFCFDFOABNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x74ED840", Offset = "0x74ECC40", VA = "0x1874ED840")]
	private GFCFDFOABNN NDMJPNBIGDL(CALEDHBDGGG MHHDOIMHKHK, JMININFAJOG BICIOJBDOBL)
	{
		return default(GFCFDFOABNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x74ED670", Offset = "0x74ECA70", VA = "0x1874ED670")]
	private bool LIIPPILCDDD(IEnumerable<IPHLLLPPIAH> DFJCAMKEBJO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct GAGDPFIGGBC
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class NMOJCELLDEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public AICIHMAGLDI.GFCFDFOABNN instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public NMOJCELLDEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x7501D90", Offset = "0x7501190", VA = "0x187501D90")]
		internal object OHONEHBOGIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class EMKMJNGCABP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public EMKMJNGCABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x74F4820", Offset = "0x74F3C20", VA = "0x1874F4820")]
		internal object JJJNEBAOCLC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x74F6E70", Offset = "0x74F6270", VA = "0x1874F6E70")]
	public static void EPAPKGBPEKK(NEGLAKONOOF DJJCJPCNFNK, LMMLJLDDCAM AIKOCCMKKAE, AICIHMAGLDI.GFCFDFOABNN ECLJJGDFAAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal class NGMBBKMGECK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct BLALIEHCDAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public NGMBBKMGECK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public KAHPGONBPBJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public LMMLJLDDCAM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x74EF580", Offset = "0x74EE980", VA = "0x1874EF580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x74EFCF0", Offset = "0x74EF0F0", VA = "0x1874EFCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class HOBEDHGCLGP
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
			public HOBEDHGCLGP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x7505F00", Offset = "0x7505300", VA = "0x187505F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x75061C0", Offset = "0x75055C0", VA = "0x1875061C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public NGMBBKMGECK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public HOBEDHGCLGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x74F9170", Offset = "0x74F8570", VA = "0x1874F9170")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task NIHHFBFJJHN(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct PFJLLEEEEFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public NGMBBKMGECK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private HOBEDHGCLGP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x7504500", Offset = "0x7503900", VA = "0x187504500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x7504A30", Offset = "0x7503E30", VA = "0x187504A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct DMMNMCDNIAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public NGMBBKMGECK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private Dictionary<Guid, List<HIIEHPJKCJC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x74F2740", Offset = "0x74F1B40", VA = "0x1874F2740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x74F2D50", Offset = "0x74F2150", VA = "0x1874F2D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct NOPKMLKMIIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public NGMBBKMGECK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private Dictionary<Guid, List<HIIEHPJKCJC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x7501E40", Offset = "0x7501240", VA = "0x187501E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x75024E0", Offset = "0x75018E0", VA = "0x1875024E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class EKBOMOPHHIA
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
			public HIIEHPJKCJC handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			public EKBOMOPHHIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x7505D00", Offset = "0x7505100", VA = "0x187505D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x7505EA0", Offset = "0x75052A0", VA = "0x187505EA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public ANBKKFLJNCD runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public List<HIIEHPJKCJC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public EKBOMOPHHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x74F4550", Offset = "0x74F3950", VA = "0x1874F4550")]
		internal object AOAJPNFBNFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x74F4730", Offset = "0x74F3B30", VA = "0x1874F4730")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task LHBFNCHDNPL(HIIEHPJKCJC handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x74F4640", Offset = "0x74F3A40", VA = "0x1874F4640")]
		internal object KANGGJBPMCF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct LFKEPEIHCHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public ANBKKFLJNCD runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public List<HIIEHPJKCJC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private EKBOMOPHHIA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x74FD340", Offset = "0x74FC740", VA = "0x1874FD340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x74FD810", Offset = "0x74FCC10", VA = "0x1874FD810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct GEIDIEGPIJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public NGMBBKMGECK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timer;

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
		[Cpp2IlInjected.Address(RVA = "0x74F7420", Offset = "0x74F6820", VA = "0x1874F7420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x74F79E0", Offset = "0x74F6DE0", VA = "0x1874F79E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class CLINCPJCDOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public CLINCPJCDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x74F19D0", Offset = "0x74F0DD0", VA = "0x1874F19D0")]
		internal object AGOPOHHDOMO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct JAPDNKOOFIN : IAsyncStateMachine
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
		public NGMBBKMGECK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public LMMLJLDDCAM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x74FA940", Offset = "0x74F9D40", VA = "0x1874FA940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x74FAE00", Offset = "0x74FA200", VA = "0x1874FAE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class CFBLAHIPMPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public CFBLAHIPMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x74F18F0", Offset = "0x74F0CF0", VA = "0x1874F18F0")]
		internal object CDEIAOGJIEA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct FECKKFMHIFC : IAsyncStateMachine
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
		public NGMBBKMGECK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private TaskAwaiter<JGPLAGNOLDP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x74F6290", Offset = "0x74F5690", VA = "0x1874F6290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x74F68C0", Offset = "0x74F5CC0", VA = "0x1874F68C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class BILJFGCKMNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BILJFGCKMNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x74EF510", Offset = "0x74EE910", VA = "0x1874EF510")]
		internal object BKFCFFNMMME()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private readonly DJKKOGJAPPD DONMHGDIMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private IHFOPKOBJND KBBMCGPNBCP;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private NEGLAKONOOF MKKFEHGOENO
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xBD73B0", Offset = "0xBD67B0", VA = "0x180BD73B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	public NGMBBKMGECK(DJKKOGJAPPD DONMHGDIMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x75008F0", Offset = "0x74FFCF0", VA = "0x1875008F0")]
	[AsyncStateMachine(typeof(BLALIEHCDAB))]
	public Task EPAPKGBPEKK(KAHPGONBPBJ FEFACIMNDGF, LMMLJLDDCAM JINMCGDCFPF, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x7500A40", Offset = "0x74FFE40", VA = "0x187500A40")]
	[AsyncStateMachine(typeof(PFJLLEEEEFG))]
	private Task FIKDDILBPLE(LMMLJLDDCAM AIKOCCMKKAE, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x7500E90", Offset = "0x7500290", VA = "0x187500E90")]
	[AsyncStateMachine(typeof(DMMNMCDNIAE))]
	private Task LKDLHPBPEDJ(LMMLJLDDCAM AIKOCCMKKAE, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x75005B0", Offset = "0x74FF9B0", VA = "0x1875005B0")]
	[AsyncStateMachine(typeof(NOPKMLKMIIN))]
	private Task BHNNBHOFIKL(LMMLJLDDCAM AIKOCCMKKAE, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x75006F0", Offset = "0x74FFAF0", VA = "0x1875006F0")]
	[AsyncStateMachine(typeof(LFKEPEIHCHK))]
	private Task CDOEKLBIJBG(Guid OMHNILLFPIL, List<HIIEHPJKCJC> KBAPODFJIGI, ANBKKFLJNCD EBPGEEADNOD, LMMLJLDDCAM AIKOCCMKKAE, CancellationToken ABHFNNFMPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x75010E0", Offset = "0x75004E0", VA = "0x1875010E0")]
	[AsyncStateMachine(typeof(GEIDIEGPIJH))]
	private Task LPNCAAGKBJE(LMMLJLDDCAM AIKOCCMKKAE, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x75013B0", Offset = "0x75007B0", VA = "0x1875013B0")]
	[AsyncStateMachine(typeof(JAPDNKOOFIN))]
	private Task PMOKFCIEJHL(Guid GBCFPFLMFMB, LMMLJLDDCAM AIKOCCMKKAE, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x7500D50", Offset = "0x7500150", VA = "0x187500D50")]
	[AsyncStateMachine(typeof(FECKKFMHIFC))]
	private Task HGLEJNEJPEC(Guid GBCFPFLMFMB, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x7500FD0", Offset = "0x75003D0", VA = "0x187500FD0")]
	private void LNICDDDKELC(Guid GBCFPFLMFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x7500840", Offset = "0x74FFC40", VA = "0x187500840")]
	private void CMKHGJGJLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x7501220", Offset = "0x7500620", VA = "0x187501220")]
	public Guid OMNKEONOBJM(KAHPGONBPBJ EAJGJHLDOOA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x7500B80", Offset = "0x74FFF80", VA = "0x187500B80")]
	[CompilerGenerated]
	private object FOCDEBCBIAN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct BLINKPKANLD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct PLJDOLCEGBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public BLINKPKANLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private IEnumerator<PGHGNIOMILA> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x7505190", Offset = "0x7504590", VA = "0x187505190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x7505820", Offset = "0x7504C20", VA = "0x187505820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private PGLGJBMIFMP BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private CancellationToken NBBCMDKGJKI;

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x74EFE40", Offset = "0x74EF240", VA = "0x1874EFE40")]
	public static Task FPHOILLJLPI(PGLGJBMIFMP BLDEOEOIGBD, OGAFCBAEIIJ<string>.DDIOHHJLGKB BKBOMPKPCMH, CancellationToken CFKHGFEFMJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x74EFD50", Offset = "0x74EF150", VA = "0x1874EFD50")]
	[AsyncStateMachine(typeof(PLJDOLCEGBG))]
	private Task EPAPKGBPEKK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct PMFOLCAOADP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	public readonly bool CFDOCCHGKHB;

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x23E8990", Offset = "0x23E7D90", VA = "0x1823E8990")]
	public PMFOLCAOADP(bool LEJPLBCOBDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public readonly struct MFIELAJAPOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	public readonly CALEDHBDGGG? PGCLNFKLJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	public readonly NALCBJJMBEM MHDBBNGJDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	public readonly string? DCONMDIAIIA;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public IReadOnlyCollection<string> LLDFBNADGIE
	{
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x74FF580", Offset = "0x74FE980", VA = "0x1874FF580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IReadOnlyDictionary<long, int> OMOBPOGKCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x74FF5A0", Offset = "0x74FE9A0", VA = "0x1874FF5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x74FF5C0", Offset = "0x74FE9C0", VA = "0x1874FF5C0")]
	public MFIELAJAPOD(CALEDHBDGGG? AAAHDHHHHGN, NALCBJJMBEM EAMEDBPLKAN, string? AIFCIFFNDFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class AKCMKPCICCG : BFFAIILPGFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct ENHFAFLPNHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder<MFIELAJAPOD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public AKCMKPCICCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public KOIIDKLEICC serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public BNMBFPNEDMN roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private GADNJKDCJGL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x74F48B0", Offset = "0x74F3CB0", VA = "0x1874F48B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x74F4F30", Offset = "0x74F4330", VA = "0x1874F4F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class LMMEHKCIPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public KOIIDKLEICC serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public AKCMKPCICCG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LMMEHKCIPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x74FDDE0", Offset = "0x74FD1E0", VA = "0x1874FDDE0")]
		internal Task DGECBNMLJPM(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x74FDD00", Offset = "0x74FD100", VA = "0x1874FDD00")]
		internal Task AFNHNPMNKGH(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class CKIKBIOJFFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public LMMEHKCIPEM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public CKIKBIOJFFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x74F1960", Offset = "0x74F0D60", VA = "0x1874F1960")]
		internal object DGIAHEMAMOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class NICLEJFHFPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public LMMEHKCIPEM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public NICLEJFHFPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x7501990", Offset = "0x7500D90", VA = "0x187501990")]
		internal Task NKABAMAMEGN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct CAKLEGBCMHO : IAsyncStateMachine
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
		public KOIIDKLEICC serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public AKCMKPCICCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private CKIKBIOJFFE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private GADNJKDCJGL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x74F1030", Offset = "0x74F0430", VA = "0x1874F1030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x74F1890", Offset = "0x74F0C90", VA = "0x1874F1890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private static readonly TimeSpan FBJBLOAGDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly ANHFCGBBAON ENAOGDPJDJH;

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x74EEF00", Offset = "0x74EE300", VA = "0x1874EEF00")]
	public AKCMKPCICCG(DJKKOGJAPPD DONMHGDIMAA, ANHFCGBBAON ENAOGDPJDJH, FLILHMOBPPM APPINHJJCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x74EE290", Offset = "0x74ED690", VA = "0x1874EE290")]
	[AsyncStateMachine(typeof(ENHFAFLPNHH))]
	public Task<MFIELAJAPOD> IFDLICGNEEM(long JOABCKCOFMA, BNMBFPNEDMN JFIBKEIOPGG, KOIIDKLEICC OEPNILNKHLE, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x74EE790", Offset = "0x74EDB90", VA = "0x1874EE790")]
	[AsyncStateMachine(typeof(CAKLEGBCMHO))]
	private Task OJLCEFEGBEN(KOIIDKLEICC OEPNILNKHLE, IEnumerable<PersistenceView> HHNBDLKEMFC, StringBuilder LABOBAICHMO, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x74EE8D0", Offset = "0x74EDCD0", VA = "0x1874EE8D0")]
	private MFIELAJAPOD PALEDMKIECJ(long JOABCKCOFMA, BNMBFPNEDMN JFIBKEIOPGG, KOIIDKLEICC OEPNILNKHLE, IEnumerable<PersistenceView> HHNBDLKEMFC, StringBuilder LABOBAICHMO)
	{
		return default(MFIELAJAPOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x74EE3F0", Offset = "0x74ED7F0", VA = "0x1874EE3F0")]
	private CALEDHBDGGG IFEFJIPAKMP(long JOABCKCOFMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x74EE540", Offset = "0x74ED940", VA = "0x1874EE540")]
	private void OFBPPPDIALA(CALEDHBDGGG CKFABOCNLPA, StringBuilder LABOBAICHMO, IEnumerable<PersistenceView> HHNBDLKEMFC, [In] KCBGPNKOCPP PLOEEJLCCGK, HDEHJNIKCIC GCMMKJOIJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x74EDDF0", Offset = "0x74ED1F0", VA = "0x1874EDDF0")]
	private void GLJNGPCHBLE(CALEDHBDGGG CKFABOCNLPA, StringBuilder LABOBAICHMO, PersistenceView JAACMBBNMFM, HDEHJNIKCIC GCMMKJOIJCA, [In] KCBGPNKOCPP PLOEEJLCCGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal class LPJBLPKFEAL : BFFAIILPGFG
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class MCLGPCMLNAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public EIKHKCNEFIJ.NICNJCJFPDH roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public MCLGPCMLNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x74FEB60", Offset = "0x74FDF60", VA = "0x1874FEB60")]
		internal object KBELMAACKNE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct HDDLEANLELN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public AsyncTaskMethodBuilder<(EIKHKCNEFIJ.NICNJCJFPDH roomDataUpload, EIKHKCNEFIJ.NICNJCJFPDH subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public MFIELAJAPOD roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public LPJBLPKFEAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private MCLGPCMLNAA <>8__1;

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
		private TaskAwaiter<EIKHKCNEFIJ.NICNJCJFPDH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x74F8820", Offset = "0x74F7C20", VA = "0x1874F8820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x74F9080", Offset = "0x74F8480", VA = "0x1874F9080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct PKNLHILPBGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public AsyncTaskMethodBuilder<GKKCGGKMNLI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public LPJBLPKFEAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public MFIELAJAPOD roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public OCPEFMIEHAN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private TaskAwaiter<(EIKHKCNEFIJ.NICNJCJFPDH roomDataUpload, EIKHKCNEFIJ.NICNJCJFPDH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private TaskAwaiter<GKKCGGKMNLI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x7504A90", Offset = "0x7503E90", VA = "0x187504A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x7505120", Offset = "0x7504520", VA = "0x187505120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private struct LOMJLMCKHGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public AsyncTaskMethodBuilder<CECCDIADBPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public LPJBLPKFEAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public MFIELAJAPOD roomSerializedData;

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
		private TaskAwaiter<(EIKHKCNEFIJ.NICNJCJFPDH roomDataUpload, EIKHKCNEFIJ.NICNJCJFPDH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private TaskAwaiter<CECCDIADBPO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x74FDFF0", Offset = "0x74FD3F0", VA = "0x1874FDFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x74FE410", Offset = "0x74FD810", VA = "0x1874FE410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class GLDDMDEDJPN
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
			public AsyncTaskMethodBuilder<JGPLAGNOLDP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			public GLDDMDEDJPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			private JGPLAGNOLDP <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			private TaskAwaiter<CECCDIADBPO> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			private TaskAwaiter<GKKCGGKMNLI> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			private TaskAwaiter<JGPLAGNOLDP> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x7506610", Offset = "0x7505A10", VA = "0x187506610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x75075A0", Offset = "0x75069A0", VA = "0x1875075A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public LPJBLPKFEAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public MFIELAJAPOD roomSerializedData;

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
		public OCPEFMIEHAN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public PMFOLCAOADP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public GLDDMDEDJPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x74F7BD0", Offset = "0x74F6FD0", VA = "0x1874F7BD0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<JGPLAGNOLDP> AFDGIJAIIDF(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct MJJNBJEBIIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public AsyncTaskMethodBuilder<JGPLAGNOLDP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public LPJBLPKFEAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public MFIELAJAPOD roomSerializedData;

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
		public OCPEFMIEHAN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public PMFOLCAOADP roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private TaskAwaiter<JGPLAGNOLDP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x74FFDB0", Offset = "0x74FF1B0", VA = "0x1874FFDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x75000C0", Offset = "0x74FF4C0", VA = "0x1875000C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private static readonly FLILHMOBPPM OBOPKNNHEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private readonly EMHEAIMCGOO OGGLKHLKMHA;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private OEHIJBIKFHD BKNHFCPOMJB
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x74DEC10", Offset = "0x74DE010", VA = "0x1874DEC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x74FEAD0", Offset = "0x74FDED0", VA = "0x1874FEAD0")]
	public LPJBLPKFEAL(DJKKOGJAPPD DONMHGDIMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x74FE760", Offset = "0x74FDB60", VA = "0x1874FE760")]
	[AsyncStateMachine(typeof(HDDLEANLELN))]
	private Task<(EIKHKCNEFIJ.NICNJCJFPDH, EIKHKCNEFIJ.NICNJCJFPDH)> FNPFKCDKMFO(MFIELAJAPOD MDHDINIGMGL, long FJBFONPAOAD, long AEGLBCGIGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x74FE5F0", Offset = "0x74FD9F0", VA = "0x1874FE5F0")]
	[AsyncStateMachine(typeof(PKNLHILPBGA))]
	public Task<GKKCGGKMNLI> DHJFBCKPIGD(int PEOKACJCKGE, [CanBeNull] OCPEFMIEHAN HCNGLCOMFAN, MFIELAJAPOD MDHDINIGMGL, long FJBFONPAOAD, long AEGLBCGIGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x74FE480", Offset = "0x74FD880", VA = "0x1874FE480")]
	[AsyncStateMachine(typeof(LOMJLMCKHGG))]
	private Task<CECCDIADBPO> BMAHAHLPFIE(string KCGJBHDHJNA, int PEOKACJCKGE, MFIELAJAPOD MDHDINIGMGL, long FJBFONPAOAD, long AEGLBCGIGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x74FE8A0", Offset = "0x74FDCA0", VA = "0x1874FE8A0")]
	[AsyncStateMachine(typeof(MJJNBJEBIIO))]
	public Task<JGPLAGNOLDP> HJHDBCDKMIG(int PEOKACJCKGE, OCPEFMIEHAN? HCNGLCOMFAN, MFIELAJAPOD MDHDINIGMGL, long FJBFONPAOAD, long AEGLBCGIGGP, PMFOLCAOADP JLCOANHAJDA, OGAFCBAEIIJ<string>.DDIOHHJLGKB DMKIFKPNKMI, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public abstract class LCHLGLFCKFF<T> where T : LCHLGLFCKFF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	internal readonly OEHIJBIKFHD MOKOAIIAICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private int? JDDGCPNEBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	protected readonly Guid OHIHJKBAAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	protected readonly EADHFCPENJI JNOJPAAKOFG;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	protected T EDHFCKMLAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x458EC70", Offset = "0x458E070", VA = "0x18458EC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x458EE00", Offset = "0x458E200", VA = "0x18458EE00")]
	internal LCHLGLFCKFF(OEHIJBIKFHD JILAEGMJGAI, EADHFCPENJI GJDDMMGENAF, [Optional] Guid? NEMMHGGPCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x458EB90", Offset = "0x458DF90", VA = "0x18458EB90")]
	private JGPLAGNOLDP HLJCPAHLLEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
	protected virtual void DPADEIMJIEF(JGPLAGNOLDP MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x458EA80", Offset = "0x458DE80", VA = "0x18458EA80")]
	public T DAKPIHCHCEC(JDJLHJHOJPN OJEMPAFDPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x458E9D0", Offset = "0x458DDD0", VA = "0x18458E9D0")]
	public T CLGNJLNNKEO(int CGKGDLELLKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x458ECD0", Offset = "0x458E0D0", VA = "0x18458ECD0", Slot = "5")]
	public virtual Task<IEJAANOGAED> LIEPGKKNHGI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class BEAODDAKCJA : LCHLGLFCKFF<BEAODDAKCJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private HDAMGLELGPE GKKLHKCNNPG;

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x74EF440", Offset = "0x74EE840", VA = "0x1874EF440")]
	internal BEAODDAKCJA(OEHIJBIKFHD JILAEGMJGAI, EADHFCPENJI GJDDMMGENAF, [Optional] Guid? NEMMHGGPCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x69CEDC0", Offset = "0x69CE1C0", VA = "0x1869CEDC0")]
	public BEAODDAKCJA GBBHMOOLFML(HDAMGLELGPE GKKLHKCNNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x74EF370", Offset = "0x74EE770", VA = "0x1874EF370", Slot = "4")]
	protected override void DPADEIMJIEF(JGPLAGNOLDP MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public class EAGLIGFEODA : LCHLGLFCKFF<EAGLIGFEODA>
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	internal enum MNLMADEKIGG
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
	private struct BDJFEIGBHLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public AsyncTaskMethodBuilder<IEJAANOGAED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public EAGLIGFEODA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private TaskAwaiter<IEJAANOGAED> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x74EEF50", Offset = "0x74EE350", VA = "0x1874EEF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x74EF300", Offset = "0x74EE700", VA = "0x1874EF300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private MNLMADEKIGG DPOEFNMNNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private string DFHMPKDAIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private OCPEFMIEHAN GKKLHKCNNPG;

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x74F3EE0", Offset = "0x74F32E0", VA = "0x1874F3EE0")]
	internal EAGLIGFEODA(OEHIJBIKFHD JILAEGMJGAI, EADHFCPENJI GJDDMMGENAF, [Optional] Guid? NEMMHGGPCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x74F3EB0", Offset = "0x74F32B0", VA = "0x1874F3EB0")]
	public EAGLIGFEODA OKONDGEEPGK(string BCAMDINMAHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x74F3D30", Offset = "0x74F3130", VA = "0x1874F3D30")]
	public EAGLIGFEODA HLCONKKICJE(bool DABNPJADCDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x74F3D50", Offset = "0x74F3150", VA = "0x1874F3D50")]
	public EAGLIGFEODA IDCIDLAHBNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x74F3BC0", Offset = "0x74F2FC0", VA = "0x1874F3BC0", Slot = "4")]
	protected override void DPADEIMJIEF(JGPLAGNOLDP MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x74F3D80", Offset = "0x74F3180", VA = "0x1874F3D80", Slot = "5")]
	[AsyncStateMachine(typeof(BDJFEIGBHLE))]
	public override Task<IEJAANOGAED> LIEPGKKNHGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x74F3E70", Offset = "0x74F3270", VA = "0x1874F3E70")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<IEJAANOGAED> OIPNKCINLBI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal static class JPOHCBBPMMM
{
	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x74FBF40", Offset = "0x74FB340", VA = "0x1874FBF40")]
	public static void LNICBLMMLML(this FHICPPGLKDE MANIKNIIHEE, IBCLDPKBHMG NCMDGBEJIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x74FBEC0", Offset = "0x74FB2C0", VA = "0x1874FBEC0")]
	public static void GMEFGMHGEKE(this IBCLDPKBHMG PEDCCEONEBC, [Optional] string MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public static class MDAKDJLAIEC
{
	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x74FEC60", Offset = "0x74FE060", VA = "0x1874FEC60")]
	public static OJGEAFAKANE PJBJHENPNHM(this EJPGKEDJCHD IOLEPLKAOCL)
	{
		return default(OJGEAFAKANE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x74FEBB0", Offset = "0x74FDFB0", VA = "0x1874FEBB0")]
	public static EJPGKEDJCHD CJOIFKCICBJ(this OJGEAFAKANE OEIJKNBNMLI)
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
			public BCIGOMEILBF ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public BCIGOMEILBF HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private static BCIGOMEILBF[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private Dictionary<BCIGOMEILBF, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x7507AF0", Offset = "0x7506EF0", VA = "0x187507AF0")]
		public bool EKOBOPLELLG(BCIGOMEILBF CPNMDDBHIBN, [Out] ResultConfig HGDDFPIIMHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x7507B60", Offset = "0x7506F60", VA = "0x187507B60")]
		public ResultConfig MOAFCPGAEPJ(BCIGOMEILBF ENJPANJMAJE, [Optional] HashSet<BCIGOMEILBF> HIHLKGJJONN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x75081D0", Offset = "0x75075D0", VA = "0x1875081D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x7507CA0", Offset = "0x75070A0", VA = "0x187507CA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xA255A0", Offset = "0xA249A0", VA = "0x180A255A0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class NJHEHCBOEAH : FHBAINLFPIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct OKJHGFEKBFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public NJHEHCBOEAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x750DAC0", Offset = "0x750CEC0", VA = "0x18750DAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x750DC50", Offset = "0x750D050", VA = "0x18750DC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct KFBELKKOBDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public OGAFCBAEIIJ<string>.DDIOHHJLGKB timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public FHBAINLFPIL preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private OGAFCBAEIIJ<string>.DDIOHHJLGKB <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x750B410", Offset = "0x750A810", VA = "0x18750B410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x750B930", Offset = "0x750AD30", VA = "0x18750B930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private readonly GAGHGPEIDMA OKNGGPOJJEC;

	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public string LFMNCBNNEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x7501AC0", Offset = "0x7500EC0", VA = "0x187501AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x75019D0", Offset = "0x7500DD0", VA = "0x1875019D0")]
	[OAJAKDHKADM.LHNCMMKCKFL.AGBJBPFJEIM]
	internal static void CMJIFNFGFLF(LBNNADLFMIK PCMEKEJCMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public NJHEHCBOEAH([CCLHMIDBCEM(null)] GAGHGPEIDMA OKNGGPOJJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x7501AF0", Offset = "0x7500EF0", VA = "0x187501AF0", Slot = "5")]
	[AsyncStateMachine(typeof(OKJHGFEKBFB))]
	public Task EPAPKGBPEKK(OGAFCBAEIIJ<string>.DDIOHHJLGKB EMFPIJAEOEN, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x7501C00", Offset = "0x7501000", VA = "0x187501C00")]
	[AsyncStateMachine(typeof(KFBELKKOBDK))]
	private Task PCNPGODBLNG(FHBAINLFPIL NOLHONDNBJE, OGAFCBAEIIJ<string>.DDIOHHJLGKB EMFPIJAEOEN, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public interface GAGHGPEIDMA : FHBAINLFPIL
{
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public interface FHBAINLFPIL
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string LFMNCBNNEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EPAPKGBPEKK(OGAFCBAEIIJ<string>.DDIOHHJLGKB EMFPIJAEOEN, CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public static class JHDJPGDJKBA
{
	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x750A4D0", Offset = "0x75098D0", VA = "0x18750A4D0")]
	[OAJAKDHKADM.LHNCMMKCKFL.AGBJBPFJEIM]
	internal static void INBAICEHNJG(LBNNADLFMIK PCMEKEJCMGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public interface CCFOBHEPCIJ : IEquatable<CCFOBHEPCIJ>
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	DateTime LNNAADNOKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIHPDFFAGNK();

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PADMKBKDIPH(long FJBFONPAOAD, long JOABCKCOFMA, [Out] MFIELAJAPOD MDHDINIGMGL);
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class LNEBJJEBNIC : FFCIOOAPNCM
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class OICHPCOIBDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public HIHOCJFOCEE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public OICHPCOIBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x750DA50", Offset = "0x750CE50", VA = "0x18750DA50")]
		internal object HGBABLEICOE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	private readonly MECMPNMDIOL FGLIKLANHMI;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<CCFOBHEPCIJ> DLMOKIPBFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x750BF20", Offset = "0x750B320", VA = "0x18750BF20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x750B990", Offset = "0x750AD90", VA = "0x18750B990", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	[UnityEngine.Scripting.Preserve]
	public LNEBJJEBNIC([CCLHMIDBCEM(null)] MECMPNMDIOL FGLIKLANHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x750BFD0", Offset = "0x750B3D0", VA = "0x18750BFD0", Slot = "6")]
	public bool GKADOJDCLIA(long FJBFONPAOAD, long JOABCKCOFMA, MFIELAJAPOD MDHDINIGMGL, HIHOCJFOCEE DFAEMLMEJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x92B020", Offset = "0x92A420", VA = "0x18092B020")]
	private void KFFLDHGPGPH(CCFOBHEPCIJ KCNCGGGONPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x750C2B0", Offset = "0x750B6B0", VA = "0x18750C2B0", Slot = "7")]
	public bool HNNCGJFMJDG(long FJBFONPAOAD, long JOABCKCOFMA, [Out] CCFOBHEPCIJ FKHGMFJEDDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x750BE70", Offset = "0x750B270", VA = "0x18750BE70", Slot = "8")]
	public bool FCOMMBLAOPE(long FJBFONPAOAD, long JOABCKCOFMA, HIHOCJFOCEE DFAEMLMEJNM, [Out] CCFOBHEPCIJ FKHGMFJEDDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x750BA40", Offset = "0x750AE40", VA = "0x18750BA40")]
	private void EGJNBEFMNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x750C420", Offset = "0x750B820", VA = "0x18750C420", Slot = "9")]
	public void MAKIKGPOPLC(long FJBFONPAOAD, long JOABCKCOFMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal abstract class EHMDMEGEGLC : MECMPNMDIOL
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	protected enum NNFJACDMAIA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class ACPELCCDCAJ : IEnumerable<CCFOBHEPCIJ>, IEnumerable, IEnumerator<CCFOBHEPCIJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private CCFOBHEPCIJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public EHMDMEGEGLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private HIHOCJFOCEE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public HIHOCJFOCEE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private CCFOBHEPCIJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7D0", Offset = "0x9EABD0", VA = "0x1809EB7D0")]
		[DebuggerHidden]
		public ACPELCCDCAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x7508550", Offset = "0x7507950", VA = "0x187508550", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x7508830", Offset = "0x7507C30", VA = "0x187508830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x7508780", Offset = "0x7507B80", VA = "0x187508780", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CCFOBHEPCIJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x7508780", Offset = "0x7507B80", VA = "0x187508780", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class HJDLPLAOHGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public HIHOCJFOCEE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public HJDLPLAOHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x7509B70", Offset = "0x7508F70", VA = "0x187509B70")]
		internal object OAKOLKEDAIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class BMBNHKIKFJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public EHMDMEGEGLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BMBNHKIKFJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x7508880", Offset = "0x7507C80", VA = "0x187508880")]
		internal void JMILBBEIMLN(JJOOLAOPIPO.HFBANAHFBGC ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private readonly object FENMFPCNGCE;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	protected string MBMLCPFPJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x7508C90", Offset = "0x7508090", VA = "0x187508C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public abstract PKFCAHIPGKG EODELBAAHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x7509630", Offset = "0x7508A30", VA = "0x187509630")]
	protected EHMDMEGEGLC([CanBeNull] string GEJBCHBGOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x7508CA0", Offset = "0x75080A0", VA = "0x187508CA0", Slot = "5")]
	public bool KFDJDLCAEJO(long FJBFONPAOAD, long JOABCKCOFMA, HIHOCJFOCEE DFAEMLMEJNM, [Out] CCFOBHEPCIJ KCNCGGGONPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x7508E80", Offset = "0x7508280", VA = "0x187508E80", Slot = "6")]
	[IteratorStateMachine(typeof(ACPELCCDCAJ))]
	public IEnumerable<CCFOBHEPCIJ> KOMPJOBBOMK(HIHOCJFOCEE DFAEMLMEJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void GCOAOOAGBFE(Stream LMMEANMDCGP, long FJBFONPAOAD, long JOABCKCOFMA, MFIELAJAPOD MDHDINIGMGL);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool ELOFNMBBGFA(Stream BOHCOLIDNEI, long FJBFONPAOAD, long JOABCKCOFMA, DDLHLPIDHCF FDFIPFCFPGL, [Out] MFIELAJAPOD MDHDINIGMGL);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x7508F10", Offset = "0x7508310", VA = "0x187508F10", Slot = "7")]
	public CCFOBHEPCIJ PDFOGJMPDLH(long FJBFONPAOAD, long JOABCKCOFMA, MFIELAJAPOD MDHDINIGMGL, HIHOCJFOCEE DFAEMLMEJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo MCBFJOLEABN(long FJBFONPAOAD, long JOABCKCOFMA, HIHOCJFOCEE DFAEMLMEJNM, NNFJACDMAIA JCFOALDAFKL);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo IMBCDNBNNGF(HIHOCJFOCEE DFAEMLMEJNM, NNFJACDMAIA JCFOALDAFKL);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x7508C20", Offset = "0x7508020", VA = "0x187508C20")]
	protected void FEKPPIBABNB(JJOOLAOPIPO.HFBANAHFBGC BDDEEDJGLEG, string IENFPCFJHIE, FileInfo BAIAJLEACNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x7509280", Offset = "0x7508680", VA = "0x187509280")]
	internal bool PMBCNMCKOIE(FileInfo FEBIFGGIELH, long FJBFONPAOAD, long JOABCKCOFMA, [Out] MFIELAJAPOD MDHDINIGMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	private void CPLCJMNMPGL(Exception LGAEDPBIIBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class JLKBLIJHGFK : EHMDMEGEGLC
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public override PKFCAHIPGKG EODELBAAHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x16E8780", Offset = "0x16E7B80", VA = "0x1816E8780", Slot = "8")]
		get
		{
			return default(PKFCAHIPGKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x750B3D0", Offset = "0x750A7D0", VA = "0x18750B3D0")]
	public JLKBLIJHGFK([Optional] string GEJBCHBGOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x750B160", Offset = "0x750A560", VA = "0x18750B160")]
	private void IKINLADJEHA(HIHOCJFOCEE DFAEMLMEJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x750AED0", Offset = "0x750A2D0", VA = "0x18750AED0", Slot = "9")]
	internal override void GCOAOOAGBFE(Stream LMMEANMDCGP, long FJBFONPAOAD, long JOABCKCOFMA, MFIELAJAPOD MDHDINIGMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x750A8E0", Offset = "0x7509CE0", VA = "0x18750A8E0", Slot = "10")]
	internal override bool ELOFNMBBGFA(Stream BOHCOLIDNEI, long FJBFONPAOAD, long JOABCKCOFMA, DDLHLPIDHCF FDFIPFCFPGL, [Out] MFIELAJAPOD MDHDINIGMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x750B2E0", Offset = "0x750A6E0", VA = "0x18750B2E0", Slot = "11")]
	protected override FileInfo MCBFJOLEABN(long FJBFONPAOAD, long JOABCKCOFMA, HIHOCJFOCEE DFAEMLMEJNM, NNFJACDMAIA JCFOALDAFKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x750B1E0", Offset = "0x750A5E0", VA = "0x18750B1E0", Slot = "12")]
	protected override DirectoryInfo IMBCDNBNNGF(HIHOCJFOCEE DFAEMLMEJNM, NNFJACDMAIA JCFOALDAFKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class MKDNIBHMFFC : EHMDMEGEGLC
{
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private static readonly byte[] OEOMDKHBDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private readonly byte[] IDKAJJBANGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private readonly byte[] LCAHPOJOFAC;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public override PKFCAHIPGKG EODELBAAHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x625D3C0", Offset = "0x625C7C0", VA = "0x18625D3C0", Slot = "8")]
		get
		{
			return default(PKFCAHIPGKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x750D960", Offset = "0x750CD60", VA = "0x18750D960")]
	public MKDNIBHMFFC([Optional] string GEJBCHBGOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x750D320", Offset = "0x750C720", VA = "0x18750D320", Slot = "9")]
	internal override void GCOAOOAGBFE(Stream LMMEANMDCGP, long FJBFONPAOAD, long JOABCKCOFMA, MFIELAJAPOD MDHDINIGMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x750CB40", Offset = "0x750BF40", VA = "0x18750CB40", Slot = "10")]
	internal override bool ELOFNMBBGFA(Stream BOHCOLIDNEI, long FJBFONPAOAD, long JOABCKCOFMA, DDLHLPIDHCF FDFIPFCFPGL, [Out] MFIELAJAPOD MDHDINIGMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x750D5D0", Offset = "0x750C9D0", VA = "0x18750D5D0")]
	private void HGKPJHINPFD(byte[] FAHBHOHHIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x750D7A0", Offset = "0x750CBA0", VA = "0x18750D7A0", Slot = "11")]
	protected override FileInfo MCBFJOLEABN(long FJBFONPAOAD, long JOABCKCOFMA, HIHOCJFOCEE DFAEMLMEJNM, NNFJACDMAIA JCFOALDAFKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x750D690", Offset = "0x750CA90", VA = "0x18750D690", Slot = "12")]
	protected override DirectoryInfo IMBCDNBNNGF(HIHOCJFOCEE DFAEMLMEJNM, NNFJACDMAIA JCFOALDAFKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public enum PKFCAHIPGKG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal class IACOPKMHCFL : MECMPNMDIOL
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class GOCJPFECFOL : IEnumerable<CCFOBHEPCIJ>, IEnumerable, IEnumerator<CCFOBHEPCIJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private CCFOBHEPCIJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public IACOPKMHCFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private HIHOCJFOCEE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public HIHOCJFOCEE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private PKFCAHIPGKG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private IEnumerator<CCFOBHEPCIJ> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private CCFOBHEPCIJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7D0", Offset = "0x9EABD0", VA = "0x1809EB7D0")]
		[DebuggerHidden]
		public GOCJPFECFOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x7509AE0", Offset = "0x7508EE0", VA = "0x187509AE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x7509700", Offset = "0x7508B00", VA = "0x187509700", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x75096B0", Offset = "0x7508AB0", VA = "0x1875096B0")]
		private void CPDIPGODGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x7509A90", Offset = "0x7508E90", VA = "0x187509A90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x75099E0", Offset = "0x7508DE0", VA = "0x1875099E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CCFOBHEPCIJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x75099E0", Offset = "0x7508DE0", VA = "0x1875099E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private readonly PKFCAHIPGKG[] LLCNEKLJPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private readonly Dictionary<PKFCAHIPGKG, MECMPNMDIOL> AAEBGPPFLIK;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public PKFCAHIPGKG EODELBAAHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x7509DF0", Offset = "0x75091F0", VA = "0x187509DF0", Slot = "4")]
		get
		{
			return default(PKFCAHIPGKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x750A1A0", Offset = "0x75095A0", VA = "0x18750A1A0")]
	[UnityEngine.Scripting.Preserve]
	public IACOPKMHCFL(params MECMPNMDIOL[] MOFAPCFCLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x7509C10", Offset = "0x7509010", VA = "0x187509C10", Slot = "5")]
	public bool KFDJDLCAEJO(long FJBFONPAOAD, long JOABCKCOFMA, HIHOCJFOCEE DFAEMLMEJNM, [Out] CCFOBHEPCIJ KCNCGGGONPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x7509E20", Offset = "0x7509220", VA = "0x187509E20")]
	private void PALJJMAFJGH(int PJCDJKPMAJM, long FJBFONPAOAD, long JOABCKCOFMA, HIHOCJFOCEE DFAEMLMEJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x7509D60", Offset = "0x7509160", VA = "0x187509D60", Slot = "6")]
	[IteratorStateMachine(typeof(GOCJPFECFOL))]
	public IEnumerable<CCFOBHEPCIJ> KOMPJOBBOMK(HIHOCJFOCEE DFAEMLMEJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x750A050", Offset = "0x7509450", VA = "0x18750A050", Slot = "7")]
	public CCFOBHEPCIJ PDFOGJMPDLH(long FJBFONPAOAD, long JOABCKCOFMA, MFIELAJAPOD MDHDINIGMGL, HIHOCJFOCEE DFAEMLMEJNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class BOPGBJGHHFC
{
	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x7508B60", Offset = "0x7507F60", VA = "0x187508B60")]
	internal static byte[] HJFBFODKHDH(byte[] FAHBHOHHIKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x7508900", Offset = "0x7507D00", VA = "0x187508900")]
	public static void CCNPDIGJDCB(Stream OFEOCHDJIOO, byte[] KOIGFKKHLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x7508980", Offset = "0x7507D80", VA = "0x187508980")]
	public static bool DOAGIHBPOEH(Stream OFEOCHDJIOO, long JCDJIIDDPIF, DDLHLPIDHCF FOILLHEGMMB, [Out] byte[] MDFPKHCEOIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
internal sealed class MJNEJMCFMJA : CCFOBHEPCIJ, IEquatable<CCFOBHEPCIJ>, IEquatable<MJNEJMCFMJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private readonly EHMDMEGEGLC HGMONGJNKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	public readonly FileInfo HOPKBKDJNJG;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public PKFCAHIPGKG EODELBAAHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E620", Offset = "0x6E9DA20", VA = "0x186E9E620", Slot = "9")]
		get
		{
			return default(PKFCAHIPGKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DateTime LNNAADNOKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x750C8B0", Offset = "0x750BCB0", VA = "0x18750C8B0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x750CA30", Offset = "0x750BE30", VA = "0x18750CA30")]
	public MJNEJMCFMJA(EHMDMEGEGLC LKJNGCKBGOB, FileInfo FEBIFGGIELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x750C980", Offset = "0x750BD80", VA = "0x18750C980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x750C7F0", Offset = "0x750BBF0", VA = "0x18750C7F0", Slot = "5")]
	public void JIHPDFFAGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x750C940", Offset = "0x750BD40", VA = "0x18750C940", Slot = "6")]
	public bool PADMKBKDIPH(long FJBFONPAOAD, long JOABCKCOFMA, [Out] MFIELAJAPOD MDHDINIGMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x750C600", Offset = "0x750BA00", VA = "0x18750C600", Slot = "7")]
	public bool Equals(CCFOBHEPCIJ KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x750C540", Offset = "0x750B940", VA = "0x18750C540", Slot = "8")]
	public bool Equals(MJNEJMCFMJA KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x750C670", Offset = "0x750BA70", VA = "0x18750C670", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x750C760", Offset = "0x750BB60", VA = "0x18750C760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public delegate void DDLHLPIDHCF(JJOOLAOPIPO.HFBANAHFBGC JOOLEEIOCCN, string MOKGCFCFCPE);
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface MECMPNMDIOL
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	PKFCAHIPGKG EODELBAAHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFDJDLCAEJO(long FJBFONPAOAD, long JOABCKCOFMA, HIHOCJFOCEE DFAEMLMEJNM, [Out] CCFOBHEPCIJ KCNCGGGONPD);

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<CCFOBHEPCIJ> KOMPJOBBOMK(HIHOCJFOCEE DFAEMLMEJNM);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CCFOBHEPCIJ PDFOGJMPDLH(long FJBFONPAOAD, long JOABCKCOFMA, MFIELAJAPOD MDHDINIGMGL, HIHOCJFOCEE DFAEMLMEJNM);
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
